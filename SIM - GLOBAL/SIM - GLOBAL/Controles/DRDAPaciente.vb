Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports System.Data.Odbc
Imports System.Net.Http
Imports System.Text
Imports SIM___GLOBAL.Controles.DRDA

Namespace Controles

    ''' <summary>
    ''' Envía el documento RDA-Paciente (antecedentes autoreportados por el paciente) al
    ''' mecanismo de interoperabilidad de MinSalud, a partir de la orden/encuentro clínico
    ''' que se acaba de guardar.
    '''
    ''' Flujo: Config (DRDA) -> Token (DRDA.TraerToken / InteropAuthService) ->
    '''        Datos paciente/prestador/antecedentes -> Bundle (RDABundleBuilder) -> POST
    ''' </summary>
    Public Class DRDAPaciente

        ''' <summary>
        ''' Envía el RDA-Paciente en segundo plano sin bloquear ni interrumpir el flujo clínico.
        ''' Cualquier error (config incompleta, sin internet, rechazo de MinSalud, etc.) se
        ''' registra en la tabla rda_envios y NO se propaga como excepción ni bloquea al usuario:
        ''' el guardado de la historia clínica siempre debe tener prioridad sobre el envío RDA.
        ''' </summary>
        ''' <param name="onProgreso">
        ''' Opcional: se llama con un mensaje corto en cada paso ("Consultando MPI...",
        ''' "Enviando a MinSalud...", etc.) para que la interfaz pueda mostrar el avance.
        ''' Como este método se invoca desde un manejador de evento de UI (WinForms captura
        ''' el SynchronizationContext), el callback se ejecuta de vuelta en el hilo de la
        ''' interfaz — es seguro actualizar controles directamente desde él.
        ''' </param>
        Public Shared Async Sub EnviarEnSegundoPlano(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer, Optional onProgreso As Action(Of String) = Nothing)
            Try
                Await EnviarRDAPacienteAsync(idOrden, idUsuario, idEspecialista, onProgreso)
            Catch
                ' Silenciado a propósito: el detalle del error ya quedó registrado dentro de
                ' EnviarRDAPacienteAsync (tabla rda_envios). No se debe interrumpir al usuario
                ' por un fallo de interoperabilidad mientras trabaja en la historia clínica.
            End Try
        End Sub

        ''' <summary>
        ''' Ejecuta el envío de forma síncrona/awaitable. Devuelve True si MinSalud aceptó el
        ''' documento (2xx). Registra el intento (éxito o falla) en rda_envios si la tabla existe.
        ''' </summary>
        Public Shared Async Function EnviarRDAPacienteAsync(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer, Optional onProgreso As Action(Of String) = Nothing) As Task(Of Boolean)
            Dim configId As Integer = 1
            Try
                onProgreso?.Invoke("Cargando configuración de interoperabilidad...")
                ' 1. Configuración de interoperabilidad
                Dim _DRda As New DRDA
                Dim config As ConfigInteropApi = _DRda.Cargar()
                If config Is Nothing Then
                    RegistrarIntento(idOrden, False, "Sin configuración de interoperabilidad RDA (Controles/DRDA -> config_interop_api vacío).")
                    onProgreso?.Invoke("❌ No hay configuración de interoperabilidad RDA")
                    Return False
                End If
                configId = If(config.Id > 0, config.Id, 1)

                ' 2. Datos del paciente
                onProgreso?.Invoke("Cargando datos del paciente...")
                Dim paciente As Usuarios = DUsuarios.Cargar(idUsuario.ToString())
                If paciente Is Nothing Then
                    RegistrarIntento(idOrden, False, $"No se encontró el paciente id_usuario={idUsuario}.")
                    onProgreso?.Invoke("❌ No se encontró el paciente")
                    Return False
                End If

                ' 3. Datos del especialista (Practitioner) - opcional, si no existe se envía solo con Organization como autor
                Dim especialista As Especialista = CargarEspecialista(idEspecialista)

                ' 4. Token vigente (cacheado o nuevo) - se necesita ya para la consulta al MPI
                onProgreso?.Invoke("Obteniendo token de MinSalud...")
                Dim dRDA As New DRDA
                Dim token As String = Await dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    RegistrarIntento(idOrden, False, "No fue posible obtener un token de MinSalud (revisar credenciales en Interoperabilidad RDA).")
                    onProgreso?.Invoke("❌ No fue posible obtener el token de MinSalud")
                    Return False
                End If

                ' 5. Consulta previa obligatoria al MPI (Índice Maestro de Pacientes) - ver
                ' Guía RDA / Manual de Operaciones IHCE: "El Gestor RDA rechaza Bundles sin VIDA".
                ' No se aborta el envío si esta consulta falla (el MPI puede estar temporalmente
                ' no disponible); se deja constancia en rda_envios para poder revisarlo después,
                ' y se intenta el envío igual, ya que el propio $enviar-rda-paciente es la
                ' validación definitiva.
                onProgreso?.Invoke("Consultando MPI (Índice Maestro de Pacientes)...")
                Dim respuestaMpi = Await ConsultarPacienteExactoHttp(paciente, especialista, config, token)
                If Not respuestaMpi.Exitoso Then
                    RegistrarIntento(idOrden, False, "Aviso: la consulta previa al MPI no fue exitosa (se intenta el envío igual). " & respuestaMpi.Cuerpo, respuestaMpi.CodigoHttp, "RDA-PACIENTE-MPI")
                    onProgreso?.Invoke("⚠️ El MPI no respondió como se esperaba (se continúa igual)")
                End If

                ' 6. Antecedentes declarados por el paciente (texto libre)
                onProgreso?.Invoke("Cargando antecedentes del paciente...")
                Dim dAntecedentes As New DAntecedentes
                Dim dsAntecedentes As DataSet = dAntecedentes.CargarAntecedentes(idOrden.ToString())
                Dim antecedentesFamiliares As String = ""
                Dim antecedentesPersonales As String = ""
                If dsAntecedentes IsNot Nothing AndAlso dsAntecedentes.Tables.Count > 0 AndAlso dsAntecedentes.Tables(0).Rows.Count > 0 Then
                    antecedentesFamiliares = dsAntecedentes.Tables(0).Rows(0)("antecedentes_familiares").ToString()
                    antecedentesPersonales = dsAntecedentes.Tables(0).Rows(0)("antecedentes_personales").ToString()
                End If

                ' 7. Armar el Bundle FHIR
                onProgreso?.Invoke("Armando el documento RDA...")
                Dim bundleJson As String = RDABundleBuilder.ConstruirBundlePaciente(
                    paciente, especialista, config, antecedentesPersonales, antecedentesFamiliares)

                ' 8. Envío
                onProgreso?.Invoke("Enviando a MinSalud...")
                Dim resultado = Await EnviarBundleHttp(bundleJson, config, token)
                RegistrarIntento(idOrden, resultado.Exitoso, resultado.Cuerpo, resultado.CodigoHttp)
                onProgreso?.Invoke(If(resultado.Exitoso, "✅ RDA enviado correctamente", $"❌ MinSalud rechazó el RDA (HTTP {If(resultado.CodigoHttp.HasValue, resultado.CodigoHttp.Value.ToString(), "N/A")})"))
                Return resultado.Exitoso

            Catch ex As Exception
                RegistrarIntento(idOrden, False, "Excepción: " & ex.Message)
                onProgreso?.Invoke("❌ Error inesperado: " & ex.Message)
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Envía un RDA-Paciente de PRUEBA con datos fijos (no consulta la base de datos),
        ''' pensado para validar de punta a punta la conexión con MinSalud desde un botón:
        ''' toma la configuración/credenciales guardadas, verifica/renueva el token si hace
        ''' falta, arma el Bundle y hace el POST real. Devuelve un texto listo para mostrar
        ''' en un MessageBox con el resultado (éxito o error) y la respuesta cruda del API.
        ''' </summary>
        Public Shared Async Function EnviarRDAPruebaAsync() As Task(Of String)
            Try
                ' 1. Config + credenciales
                Dim _drda As New DRDA
                Dim config As ConfigInteropApi = _drda.Cargar()
                If config Is Nothing Then
                    Return "❌ No se encontró configuración de Interoperabilidad RDA. Ve a la pantalla 'Interoperabilidad RDA' y guarda las credenciales primero."
                End If
                Dim configId As Integer = If(config.Id > 0, config.Id, 1)

                ' El código de habilitación REPS de Gastrocaribe se fija aquí para este botón de
                ' prueba específico (confirmado en prestadores.minsalud.gov.co/habilitacion
                ' buscando por NIT 900270916-3: "SERVICIOS MEDICOS ESPECIALIZADOS GASTROCARIBE SAS",
                ' Código de Prestador 1300102098, sede 01), independientemente de si ya quedó
                ' guardado en la pantalla de Interoperabilidad RDA.
                Const CODIGO_REPS_GASTROCARIBE As String = "1300102098"
                Const NIT_GASTROCARIBE As String = "900270916" ' Sin dígito de verificación: $consultar-organizacion
                ' solo encontró la organización cuando el NIT se envió SIN el DV (confirmado en Postman;
                ' con "9002709163" el sistema no encontraba ninguna organización relacionada).
                Dim configPrueba As New ConfigInteropApi With {
                    .Id = config.Id,
                    .Ambiente = config.Ambiente,
                    .TenantId = config.TenantId,
                    .ClientId = config.ClientId,
                    .ClientSecret = config.ClientSecret,
                    .SubscriptionKey = config.SubscriptionKey,
                    .UrlAuthServer = config.UrlAuthServer,
                    .UrlBaseApi = config.UrlBaseApi,
                    .CodigoPrestadorReps = CODIGO_REPS_GASTROCARIBE,
                    .NitPrestador = NIT_GASTROCARIBE
                }

                ' 2. Datos fijos de prueba (ajustados para coincidir EXACTO con el registro oficial
                ' que devuelve el MPI vía $consultar-paciente-exacto: nombre "LERKIS" no "Lerki",
                ' y fecha de nacimiento 1980-08-25, no 1980-08-28 como se había puesto inicialmente)
                Dim paciente As New Usuarios With {
                    .CodigotipoIdentificacion = "CC",
                    .Identificacion = "9146310",
                    .PrimerNombre = "LERKIS",
                    .SegundoNombre = "ELIECER",
                    .PrimerApellido = "CAUSADO",
                    .SegundoApellido = "ESPITIA",
                    .Sexo = "M",
                    .FechaNacimiento = New Date(1980, 8, 25),
                    .CodigoMunicipio = "13001", ' Cartagena, Bolívar (DIVIPOLA)
                    .Zona = "U" ' Urbana
                }

                Dim especialista As New Especialista With {
                    .IdTipoIdentificacion = "CC",
                    .Identificacion = "73106055",
                    .Nombre = "Jaime Jose Bonfante",
                    .PrimerNombre = "Jaime",
                    .SegundoNombre = "Jose",
                    .PrimerApellido = "Bonfante",
                    .SegundoApellido = "Molinares"
                }

                ' 3. Verificar/renovar token vigente
                Dim dRDA As New DRDA
                Dim token As String = Await dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    RegistrarIntento(0, False, "Prueba manual: no fue posible obtener token de MinSalud.", Nothing, "RDA-PACIENTE-PRUEBA")
                    Return "❌ No fue posible obtener un token de MinSalud. Revisa TenantId / ClientId / ClientSecret en 'Interoperabilidad RDA'."
                End If

                ' 4. Consulta previa obligatoria al MPI (Índice Maestro de Pacientes) - ver
                ' Guía RDA / Manual de Operaciones IHCE: "El Gestor RDA rechaza Bundles sin VIDA".
                ' Por ahora se muestra la respuesta cruda del MPI para poder mapear correctamente
                ' el identificador VIDA una vez veamos su formato real.
                Dim respuestaMpi = Await ConsultarPacienteExactoHttp(paciente, especialista, configPrueba, token)

                ' 5. Armar Bundle (sin antecedentes: es un envío de prueba de conectividad)
                Dim bundleJson As String = RDABundleBuilder.ConstruirBundlePaciente(
                    paciente, especialista, configPrueba, antecedentesPersonales:="", antecedentesFamiliares:="",
                    nombreOrganizacion:="Gastrocaribe")

                ' 6. Enviar RDA
                Dim resultado = Await EnviarBundleHttp(bundleJson, configPrueba, token)
                RegistrarIntento(0, resultado.Exitoso, resultado.Cuerpo, resultado.CodigoHttp, "RDA-PACIENTE-PRUEBA")

                Dim mensajeMpi As String = $"— Consulta MPI ($consultar-paciente-exacto) — HTTP {If(respuestaMpi.CodigoHttp.HasValue, respuestaMpi.CodigoHttp.Value.ToString(), "N/A")}:" &
                    Environment.NewLine & respuestaMpi.Cuerpo & Environment.NewLine & Environment.NewLine

                If resultado.Exitoso Then
                    Return mensajeMpi & $"✅ MinSalud aceptó el RDA de prueba (HTTP {resultado.CodigoHttp})." & Environment.NewLine & Environment.NewLine &
                           "— Respuesta del envío RDA —" & Environment.NewLine & resultado.Cuerpo
                Else
                    Return mensajeMpi & $"🔴 MinSalud rechazó el RDA de prueba (HTTP {If(resultado.CodigoHttp.HasValue, resultado.CodigoHttp.Value.ToString(), "N/A")})." & Environment.NewLine & Environment.NewLine &
                           "— Respuesta del envío RDA —" & Environment.NewLine & resultado.Cuerpo
                End If

            Catch ex As Exception
                Return "❌ Error al enviar el RDA de prueba: " & ex.Message
            End Try
        End Function

        ''' <summary>
        ''' Consulta previa obligatoria al MPI antes de armar el Bundle RDA (ver comentario en
        ''' EnviarRDAPruebaAsync). Envía tipo/número de identificación del paciente y el
        ''' identificador del profesional que hace la consulta ("humanuser").
        ''' Devuelve la respuesta cruda (aún no se interpreta su contenido).
        ''' </summary>
        Private Shared Async Function ConsultarPacienteExactoHttp(paciente As Usuarios, especialista As Especialista, config As ConfigInteropApi, token As String) As Task(Of (Exitoso As Boolean, CodigoHttp As Integer?, Cuerpo As String))
            Dim urlConsulta As String = config.UrlBaseApi.TrimEnd("/"c) & "/Patient/$consultar-paciente-exacto"

            Dim humanUser As String = If(especialista IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(especialista.Identificacion),
                                          especialista.IdTipoIdentificacion & "-" & especialista.Identificacion,
                                          "CC-0")

            Dim parametros As New Newtonsoft.Json.Linq.JObject From {
                {"resourceType", "Parameters"},
                {"parameter", New Newtonsoft.Json.Linq.JArray From {
                    New Newtonsoft.Json.Linq.JObject From {
                        {"name", "identifier"},
                        {"part", New Newtonsoft.Json.Linq.JArray From {
                            New Newtonsoft.Json.Linq.JObject From {{"name", "type"}, {"valueString", paciente.CodigotipoIdentificacion}},
                            New Newtonsoft.Json.Linq.JObject From {{"name", "value"}, {"valueString", paciente.Identificacion}}
                        }}
                    },
                    New Newtonsoft.Json.Linq.JObject From {
                        {"name", "humanuser"},
                        {"valueString", humanUser}
                    }
                }}
            }

            Try
                Using client As New HttpClient()
                    Dim request As New HttpRequestMessage(HttpMethod.Post, urlConsulta)
                    request.Headers.Add("Authorization", "Bearer " & token)
                    If Not String.IsNullOrWhiteSpace(config.SubscriptionKey) Then
                        request.Headers.Add("Ocp-Apim-Subscription-Key", config.SubscriptionKey)
                    End If
                    request.Content = New StringContent(parametros.ToString(), Encoding.UTF8, "application/json")

                    Dim response As HttpResponseMessage = Await client.SendAsync(request)
                    Dim cuerpoRespuesta As String = Await response.Content.ReadAsStringAsync()
                    Return (response.IsSuccessStatusCode, CInt(response.StatusCode), cuerpoRespuesta)
                End Using
            Catch ex As Exception
                Return (False, Nothing, "Excepción consultando el MPI: " & ex.Message)
            End Try
        End Function

        ' ── Envío HTTP reutilizable (compartido entre el flujo real y el de prueba) ──
        Private Shared Async Function EnviarBundleHttp(bundleJson As String, config As ConfigInteropApi, token As String) As Task(Of (Exitoso As Boolean, CodigoHttp As Integer?, Cuerpo As String))
            Dim urlEnvio As String = config.UrlBaseApi.TrimEnd("/"c) & "/Composition/$enviar-rda-paciente"

            Using client As New HttpClient()
                Dim request As New HttpRequestMessage(HttpMethod.Post, urlEnvio)
                request.Headers.Add("Authorization", "Bearer " & token)
                If Not String.IsNullOrWhiteSpace(config.SubscriptionKey) Then
                    request.Headers.Add("Ocp-Apim-Subscription-Key", config.SubscriptionKey)
                End If
                request.Content = New StringContent(bundleJson, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.SendAsync(request)
                Dim cuerpoRespuesta As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    Return (True, CInt(response.StatusCode), cuerpoRespuesta)
                Else
                    Return (False, CInt(response.StatusCode), cuerpoRespuesta)
                End If
            End Using
        End Function

        ' ── Carga liviana del especialista (Practitioner) por id ──────────────────
        Private Shared Function CargarEspecialista(idEspecialista As Integer) As Especialista
            If idEspecialista <= 0 Then Return Nothing
            Try
                Dim query As String = "SELECT id_tipo_identificacion, identificacion, nombre, especialidad, registro_medico, " &
                                       "primer_nombre, segundo_nombre, primer_apellido, segundo_apellido " &
                                       "FROM especialistas WHERE id_especialista = ?"
                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using comando As New OdbcCommand(query, conn)
                        comando.Parameters.AddWithValue("?", idEspecialista)
                        Using reader As OdbcDataReader = comando.ExecuteReader()
                            If reader.Read() Then
                                Return New Especialista With {
                                    .IdEspecialista = idEspecialista,
                                    .IdTipoIdentificacion = reader("id_tipo_identificacion").ToString(),
                                    .Identificacion = reader("identificacion").ToString(),
                                    .Nombre = reader("nombre").ToString(),
                                    .Especialidad = reader("especialidad").ToString(),
                                    .RegistroMedico = reader("registro_medico").ToString(),
                                    .PrimerNombre = If(IsDBNull(reader("primer_nombre")), Nothing, reader("primer_nombre").ToString()),
                                    .SegundoNombre = If(IsDBNull(reader("segundo_nombre")), Nothing, reader("segundo_nombre").ToString()),
                                    .PrimerApellido = If(IsDBNull(reader("primer_apellido")), Nothing, reader("primer_apellido").ToString()),
                                    .SegundoApellido = If(IsDBNull(reader("segundo_apellido")), Nothing, reader("segundo_apellido").ToString())
                                }
                            End If
                        End Using
                    End Using
                End Using
            Catch
                ' Si falla la carga del especialista no se aborta el envío: se hace sin Practitioner.
            End Try
            Return Nothing
        End Function

        ' ── Auditoría de envíos (best-effort: si la tabla rda_envios no existe aún, no falla) ──
        ''' <summary>
        ''' Trae el historial de envíos de RDA (tabla rda_envios), más recientes primero, con
        ''' el nombre del paciente si se puede resolver a través de la orden. Usado por la
        ''' pantalla de historial (Vistas/frmHistorialRDA.vb).
        ''' </summary>
        Public Shared Function ListarEnvios(Optional maximoRegistros As Integer = 300) As DataTable
            Dim tabla As New DataTable()
            Try
                Dim query As String = "SELECT r.fecha_envio, r.tipo_documento, r.exitoso, r.codigo_http, r.id_orden, " &
                    "CONCAT_WS(' ', u.primer_nombre, u.primer_apellido) AS paciente, r.detalle " &
                    "FROM rda_envios r " &
                    "LEFT JOIN ordenes o ON o.id = r.id_orden " &
                    "LEFT JOIN usuarios u ON u.id = o.id_usuario " &
                    "ORDER BY r.fecha_envio DESC " &
                    "LIMIT " & maximoRegistros
                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using comando As New OdbcCommand(query, conn)
                        Using adaptador As New OdbcDataAdapter(comando)
                            adaptador.Fill(tabla)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                ' Si la tabla/columnas no existen aún (migración no corrida) o falla la consulta,
                ' se retorna una tabla vacía en vez de lanzar la excepción hacia la pantalla.
                If Not tabla.Columns.Contains("Error") Then tabla.Columns.Add("Error", GetType(String))
            End Try
            Return tabla
        End Function

        Private Shared Sub RegistrarIntento(idOrden As Integer, exitoso As Boolean, detalle As String, Optional codigoHttp As Integer? = Nothing, Optional tipoDocumento As String = "RDA-PACIENTE")
            Try
                Dim query As String = "INSERT INTO rda_envios (id_orden, tipo_documento, exitoso, codigo_http, detalle, fecha_envio) " &
                                       "VALUES (?, ?, ?, ?, ?, NOW())"
                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using comando As New OdbcCommand(query, conn)
                        comando.Parameters.AddWithValue("?", idOrden)
                        comando.Parameters.AddWithValue("?", tipoDocumento)
                        comando.Parameters.AddWithValue("?", If(exitoso, 1, 0))
                        comando.Parameters.AddWithValue("?", If(codigoHttp.HasValue, CObj(codigoHttp.Value), DBNull.Value))
                        ' Se trunca el detalle para no exceder el ancho típico de un campo TEXT/VARCHAR grande.
                        comando.Parameters.AddWithValue("?", If(detalle IsNot Nothing AndAlso detalle.Length > 4000, detalle.Substring(0, 4000), detalle))
                        comando.ExecuteNonQuery()
                    End Using
                End Using
            Catch
                ' La tabla de auditoría es complementaria; su ausencia no debe romper el envío del RDA.
            End Try
        End Sub

    End Class

End Namespace

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
        Public Shared Async Sub EnviarEnSegundoPlano(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer)
            Try
                Await EnviarRDAPacienteAsync(idOrden, idUsuario, idEspecialista)
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
        Public Shared Async Function EnviarRDAPacienteAsync(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer) As Task(Of Boolean)
            Dim configId As Integer = 1
            Try
                ' 1. Configuración de interoperabilidad
                Dim _DRda As New DRDA
                Dim config As ConfigInteropApi = _DRda.Cargar()
                If config Is Nothing Then
                    RegistrarIntento(idOrden, False, "Sin configuración de interoperabilidad RDA (Controles/DRDA -> config_interop_api vacío).")
                    Return False
                End If
                configId = If(config.Id > 0, config.Id, 1)

                ' 2. Datos del paciente
                Dim paciente As Usuarios = DUsuarios.Cargar(idUsuario.ToString())
                If paciente Is Nothing Then
                    RegistrarIntento(idOrden, False, $"No se encontró el paciente id_usuario={idUsuario}.")
                    Return False
                End If

                ' 3. Datos del especialista (Practitioner) - opcional, si no existe se envía solo con Organization como autor
                Dim especialista As Especialista = CargarEspecialista(idEspecialista)

                ' 4. Antecedentes declarados por el paciente (texto libre)
                Dim dAntecedentes As New DAntecedentes
                Dim dsAntecedentes As DataSet = dAntecedentes.CargarAntecedentes(idOrden.ToString())
                Dim antecedentesFamiliares As String = ""
                Dim antecedentesPersonales As String = ""
                If dsAntecedentes IsNot Nothing AndAlso dsAntecedentes.Tables.Count > 0 AndAlso dsAntecedentes.Tables(0).Rows.Count > 0 Then
                    antecedentesFamiliares = dsAntecedentes.Tables(0).Rows(0)("antecedentes_familiares").ToString()
                    antecedentesPersonales = dsAntecedentes.Tables(0).Rows(0)("antecedentes_personales").ToString()
                End If

                ' 5. Armar el Bundle FHIR
                Dim bundleJson As String = RDABundleBuilder.ConstruirBundlePaciente(
                    paciente, especialista, config, antecedentesPersonales, antecedentesFamiliares)

                ' 6. Token vigente (cacheado o nuevo) + 7. Envío
                Dim dRDA As New DRDA
                Dim token As String = Await dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    RegistrarIntento(idOrden, False, "No fue posible obtener un token de MinSalud (revisar credenciales en Interoperabilidad RDA).")
                    Return False
                End If

                Dim resultado = Await EnviarBundleHttp(bundleJson, config, token)
                RegistrarIntento(idOrden, resultado.Exitoso, resultado.Cuerpo, resultado.CodigoHttp)
                Return resultado.Exitoso

            Catch ex As Exception
                RegistrarIntento(idOrden, False, "Excepción: " & ex.Message)
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
                ' prueba específico (dato provisto por el usuario), independientemente de si ya
                ' quedó guardado en la pantalla de Interoperabilidad RDA. El NIT sí se toma de la
                ' configuración guardada, si existe.
                Const CODIGO_REPS_GASTROCARIBE As String = "1305200894"
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
                    .NitPrestador = config.NitPrestador
                }

                ' 2. Datos fijos de prueba
                Dim paciente As New Usuarios With {
                    .CodigotipoIdentificacion = "CC",
                    .Identificacion = "9146310",
                    .PrimerNombre = "Lerki",
                    .SegundoNombre = "Eliecer",
                    .PrimerApellido = "Causado",
                    .SegundoApellido = "Espitia",
                    .Sexo = "M",
                    .FechaNacimiento = New Date(1980, 8, 28),
                    .CodigoMunicipio = "13001", ' Cartagena, Bolívar (DIVIPOLA)
                    .Zona = "U" ' Urbana
                }

                Dim especialista As New Especialista With {
                    .IdTipoIdentificacion = "CC",
                    .Identificacion = "73106055",
                    .Nombre = "Jaime Jose Bonfante"
                }

                ' 3. Armar Bundle (sin antecedentes: es un envío de prueba de conectividad)
                Dim bundleJson As String = RDABundleBuilder.ConstruirBundlePaciente(
                    paciente, especialista, configPrueba, antecedentesPersonales:="", antecedentesFamiliares:="",
                    nombreOrganizacion:="Gastrocaribe")

                ' 4. Verificar/renovar token vigente
                Dim dRDA As New DRDA
                Dim token As String = Await dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    RegistrarIntento(0, False, "Prueba manual: no fue posible obtener token de MinSalud.", Nothing, "RDA-PACIENTE-PRUEBA")
                    Return "❌ No fue posible obtener un token de MinSalud. Revisa TenantId / ClientId / ClientSecret en 'Interoperabilidad RDA'."
                End If

                ' 5. Enviar
                Dim resultado = Await EnviarBundleHttp(bundleJson, configPrueba, token)
                RegistrarIntento(0, resultado.Exitoso, resultado.Cuerpo, resultado.CodigoHttp, "RDA-PACIENTE-PRUEBA")

                If resultado.Exitoso Then
                    Return $"✅ MinSalud aceptó el RDA de prueba (HTTP {resultado.CodigoHttp})." & Environment.NewLine & Environment.NewLine &
                           "Respuesta del API:" & Environment.NewLine & resultado.Cuerpo
                Else
                    Return $"🔴 MinSalud rechazó el RDA de prueba (HTTP {If(resultado.CodigoHttp.HasValue, resultado.CodigoHttp.Value.ToString(), "N/A")})." & Environment.NewLine & Environment.NewLine &
                           "Respuesta del API:" & Environment.NewLine & resultado.Cuerpo
                End If

            Catch ex As Exception
                Return "❌ Error al enviar el RDA de prueba: " & ex.Message
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
                Dim query As String = "SELECT id_tipo_identificacion, identificacion, nombre, especialidad, registro_medico " &
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
                                    .RegistroMedico = reader("registro_medico").ToString()
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

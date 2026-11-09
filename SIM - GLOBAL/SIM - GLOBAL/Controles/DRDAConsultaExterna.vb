Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports System.Data.Odbc
Imports System.Net.Http
Imports System.Text

Namespace Controles

    ''' <summary>
    ''' Envía documentos RDA-Consulta Externa a MinSalud. Expone tanto el envío de PRUEBA
    ''' (datos fijos) como el envío REAL a partir de una orden guardada en el SIM.
    ''' </summary>
    Public Class DRDAConsultaExterna

        ' ── Valores del prestador GASTROLAP (validados en el sandbox de MinSalud el 2026-11-08) ──
        ' Servicio habilitado REPS de la sede 1300102449-01 (CodeSystem REPShealthcareServices).
        ' Pendiente confirmar con el prestador que 316 es el servicio habilitado real.
        Private Const REPS_SERVICIO_CODIGO As String = "316"
        Private Const REPS_SERVICIO_TEXTO As String = "GASTROENTEROLOGIA"
        ' CUPS de consulta del especialista que se reporta en Encounter.serviceType cuando el
        ' encuentro es un procedimiento (el perfil solo acepta CUPS de consulta ahí; el CUPS
        ' real del procedimiento va en ServiceRequest.code).
        Private Const CUPS_CONSULTA_ESPECIALISTA As String = "890246"
        Private Const CUPS_CONSULTA_ESPECIALISTA_TEXTO As String = "CONSULTA DE PRIMERA VEZ POR ESPECIALISTA EN GASTROENTEROLOGÍA"

        ''' <summary>
        ''' Envía el RDA-Consulta Externa en segundo plano, sin bloquear el flujo clínico.
        ''' Mismo patrón que DRDAPaciente.EnviarEnSegundoPlano.
        ''' </summary>
        ''' <param name="idDetalleOrden">Opcional: detalle_orden exacto a reportar (ej. la endoscopia firmada en frmEndoscopiaGL).</param>
        ''' <param name="tipoPreferido">Opcional: si no se da idDetalleOrden, se prefiere el detalle de este tipo ('C' consulta / 'P' procedimiento).</param>
        Public Shared Async Sub EnviarEnSegundoPlano(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer, Optional onProgreso As Action(Of String) = Nothing,
                                                     Optional idDetalleOrden As Integer = 0, Optional tipoPreferido As String = Nothing)
            Try
                Await EnviarRDAConsultaExternaAsync(idOrden, idUsuario, idEspecialista, onProgreso, idDetalleOrden, tipoPreferido)
            Catch
                ' Silenciado a propósito: el detalle del error ya quedó registrado en rda_envios.
            End Try
        End Sub

        ''' <summary>
        ''' Envía el RDA-Consulta Externa real, a partir de los datos guardados de la orden.
        ''' Según detalle_orden.tipo ('C' consulta / 'P' procedimiento) decide si el CUPS de la
        ''' orden va en Encounter.serviceType (consulta) o en ServiceRequest.code (procedimiento).
        ''' GrupoServicios siempre es "01" (fijado por el perfil EncounterAmbulatoryRDA).
        ''' </summary>
        Public Shared Async Function EnviarRDAConsultaExternaAsync(idOrden As Integer, idUsuario As Integer, idEspecialista As Integer, Optional onProgreso As Action(Of String) = Nothing,
                                                                   Optional idDetalleOrden As Integer = 0, Optional tipoPreferido As String = Nothing) As Task(Of Boolean)
            Try
                ' 1. Configuración
                Dim config As ConfigInteropApi = DRDA.Cargar()
                If config Is Nothing Then
                    DRDAPaciente.RegistrarIntento(idOrden, False, "Sin configuración de interoperabilidad RDA.", Nothing, "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke("❌ No hay configuración de interoperabilidad RDA")
                    Return False
                End If
                Dim configId As Integer = If(config.Id > 0, config.Id, 1)

                ' 2. Paciente
                onProgreso?.Invoke("Validando paciente...")
                Dim paciente As Usuarios = DUsuarios.Cargar(idUsuario.ToString())
                If paciente Is Nothing Then
                    DRDAPaciente.RegistrarIntento(idOrden, False, $"No se encontró el paciente id_usuario={idUsuario}.", Nothing, "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke("❌ No se encontró el paciente")
                    Return False
                End If

                ' 3. Especialista
                onProgreso?.Invoke("Validando especialista...")
                Dim especialista As Especialista = DRDAPaciente.CargarEspecialista(idEspecialista)
                If especialista Is Nothing Then
                    DRDAPaciente.RegistrarIntento(idOrden, False, $"No se encontró el especialista id_especialista={idEspecialista}.", Nothing, "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke("❌ No se encontró el especialista")
                    Return False
                End If

                ' 4. Datos de la orden (diagnóstico, CUPS, tipo consulta/procedimiento)
                Dim detalle = CargarDetalleOrden(idOrden, idDetalleOrden, tipoPreferido)
                If detalle Is Nothing Then
                    DRDAPaciente.RegistrarIntento(idOrden, False, $"No se encontró detalle_orden para id_orden={idOrden}.", Nothing, "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke("❌ No se encontró el detalle de la orden")
                    Return False
                End If

                ' 5. Token
                Dim _dRDA As New DRDA
                Dim token As String = Await _dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    DRDAPaciente.RegistrarIntento(idOrden, False, "No fue posible obtener un token de MinSalud.", Nothing, "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke("❌ No fue posible obtener el token de MinSalud")
                    Return False
                End If

                ' 6. Armar Bundle
                onProgreso?.Invoke("Enviando RDA...")
                Dim esProcedimiento As Boolean = detalle.Value.Tipo IsNot Nothing AndAlso detalle.Value.Tipo.Trim().ToUpperInvariant() = "P"

                ' Validado contra el sandbox de MinSalud (pruebas GASTROLAP, 2026-11-08):
                ' - EncounterAmbulatoryRDA fija Encounter.type GrupoServicios = "01" / "Consulta externa"
                '   (error 1008 si se envía otro valor). Además, en el CodeSystem GrupoServicios el "04"
                '   es "Quirúrgico", no apoyo diagnóstico. Por eso SIEMPRE va "01", también el día
                '   del procedimiento.
                ' - Encounter.serviceType solo acepta CUPS de consulta (ValueSet CUPSConsultationCodes,
                '   error 6007 con un CUPS de procedimiento). El procedimiento (ej. endoscopia) va
                '   únicamente en ServiceRequest.code (ValueSet CUPSProcedureCodes).
                Dim cupsConsultaCodigo As String = If(esProcedimiento, CUPS_CONSULTA_ESPECIALISTA, detalle.Value.CupsCodigo)
                Dim cupsConsultaTexto As String = If(esProcedimiento, CUPS_CONSULTA_ESPECIALISTA_TEXTO, detalle.Value.CupsTexto)
                Dim cupsProcedimientoCodigo As String = If(esProcedimiento, detalle.Value.CupsCodigo, Nothing)
                Dim cupsProcedimientoTexto As String = If(esProcedimiento, detalle.Value.CupsTexto, Nothing)

                Dim bundleJson As String = RDAConsultaExternaBuilder.ConstruirBundleConsultaExterna(
                    paciente:=paciente,
                    especialista:=especialista,
                    config:=config,
                    nombreOrganizacion:=DRDA.NombrePrestador(),
                    diagnosticoCie10Codigo:=detalle.Value.DiagnosticoCodigo,
                    diagnosticoCie10Texto:=detalle.Value.DiagnosticoTexto,
                    cupsConsultaCodigo:=cupsConsultaCodigo,
                    cupsConsultaTexto:=cupsConsultaTexto,
                    grupoServiciosCodigo:="01",
                    grupoServiciosTexto:="Consulta externa",
                    repsHealthcareServiceCodigo:=REPS_SERVICIO_CODIGO,
                    repsHealthcareServiceTexto:=REPS_SERVICIO_TEXTO,
                    cupsProcedimientoCodigo:=cupsProcedimientoCodigo,
                    cupsProcedimientoTexto:=cupsProcedimientoTexto)

                ' 7. Enviar
                Dim urlEnvio As String = config.UrlBaseApi.TrimEnd("/"c) & "/Composition/$enviar-rda-consulta"
                Using client As New HttpClient()
                    Dim request As New HttpRequestMessage(HttpMethod.Post, urlEnvio)
                    request.Headers.Add("Authorization", "Bearer " & token)
                    If Not String.IsNullOrWhiteSpace(config.SubscriptionKey) Then
                        request.Headers.Add("Ocp-Apim-Subscription-Key", config.SubscriptionKey)
                    End If
                    request.Content = New StringContent(bundleJson, Encoding.UTF8, "application/json")

                    Dim response As HttpResponseMessage = Await client.SendAsync(request)
                    Dim cuerpo As String = Await response.Content.ReadAsStringAsync()

                    DRDAPaciente.RegistrarIntento(idOrden, response.IsSuccessStatusCode, cuerpo, CInt(response.StatusCode), "RDA-CONSULTA-EXTERNA")
                    onProgreso?.Invoke(If(response.IsSuccessStatusCode, "✅ Envío exitoso", $"❌ MinSalud rechazó el RDA (HTTP {CInt(response.StatusCode)})"))
                    Return response.IsSuccessStatusCode
                End Using

            Catch ex As Exception
                DRDAPaciente.RegistrarIntento(idOrden, False, "Excepción: " & ex.Message, Nothing, "RDA-CONSULTA-EXTERNA")
                onProgreso?.Invoke("❌ Error inesperado: " & ex.Message)
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Trae el diagnóstico (CIE-10) y CUPS reales de la orden, con sus textos descriptivos
        ''' resueltos vía JOIN, y el tipo de orden ('C' consulta / 'P' procedimiento) para decidir
        ''' el GrupoServicios del RDA. Devuelve Nothing si no se encuentra ningún detalle_orden.
        ''' </summary>
        Private Shared Function CargarDetalleOrden(idOrden As Integer, Optional idDetalleOrden As Integer = 0, Optional tipoPreferido As String = Nothing) As (Tipo As String, CupsCodigo As String, CupsTexto As String, DiagnosticoCodigo As String, DiagnosticoTexto As String)?
            Try
                ' Una orden puede tener varios detalles (consulta 'C' y procedimiento 'P'): se toma
                ' el detalle exacto si se indica, si no el del tipo preferido.
                Dim query As String = "SELECT detalle_orden.tipo, detalle_orden.estado, detalle_orden.codigo_cups, cups.nombre_cups, " &
                    "detalle_orden.diagnostico1, diagnosticos.nombre_diagnostico " &
                    "FROM detalle_orden " &
                    "LEFT JOIN cups ON detalle_orden.codigo_cups = cups.codigo_cups " &
                    "LEFT JOIN diagnosticos ON detalle_orden.diagnostico1 = diagnosticos.codigo_diagnostico " &
                    If(idDetalleOrden > 0,
                       "WHERE detalle_orden.id = ? LIMIT 1",
                       "WHERE detalle_orden.id_orden = ? ORDER BY (IFNULL(detalle_orden.tipo,'C') = ?) DESC, detalle_orden.id ASC LIMIT 1")
                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using comando As New OdbcCommand(query, conn)
                        If idDetalleOrden > 0 Then
                            comando.Parameters.AddWithValue("?", idDetalleOrden.ToString())
                        Else
                            comando.Parameters.AddWithValue("?", idOrden.ToString())
                            comando.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(tipoPreferido), "C", tipoPreferido.Trim().ToUpperInvariant()))
                        End If
                        Using reader As OdbcDataReader = comando.ExecuteReader()
                            If reader.Read() Then
                                ' Los CIE-10 en RDA van sin punto (ej. "A013", no "A01.3").
                                Dim diagCodigo As String = If(IsDBNull(reader("diagnostico1")), "", reader("diagnostico1").ToString()).Replace(".", "").Trim()
                                Dim diagTexto As String = If(IsDBNull(reader("nombre_diagnostico")), diagCodigo, reader("nombre_diagnostico").ToString())
                                Dim cupsCodigo As String = If(IsDBNull(reader("codigo_cups")), "", reader("codigo_cups").ToString()).Trim()
                                Dim cupsTexto As String = If(IsDBNull(reader("nombre_cups")), cupsCodigo, reader("nombre_cups").ToString())
                                Dim tipo As String = If(IsDBNull(reader("tipo")), "C", reader("tipo").ToString())

                                Return (tipo, cupsCodigo, cupsTexto, diagCodigo, diagTexto)
                            End If
                        End Using
                    End Using
                End Using
            Catch
                ' Se retorna Nothing; el llamador decide cómo manejar la ausencia de datos.
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' Envía un RDA-Consulta Externa de prueba: paciente Fabián Suárez, especialista Dra.
        ''' Dr. Jaime Bonfante, IPS GASTROLAP, diagnóstico K21.9, consulta CUPS 890246.
        ''' NOTA: el código CUPS del PROCEDIMIENTO (endoscopia) no se incluye por ahora porque el
        ''' catálogo CUPS del sandbox de MinSalud es un subconjunto reducido que no reconoce los
        ''' códigos reales de endoscopia (451301/483600/451600) - pendiente de escalar a soporte.
        ''' </summary>
        Public Shared Async Function EnviarRDAConsultaPruebaAsync() As Task(Of String)
            Try
                ' 1. Config + credenciales
                Dim config As ConfigInteropApi = DRDA.Cargar()
                If config Is Nothing Then
                    Return "❌ No se encontró configuración de Interoperabilidad RDA. Ve a la pantalla 'Interoperabilidad RDA' y guarda las credenciales primero."
                End If
                Dim configId As Integer = If(config.Id > 0, config.Id, 1)

                Const CODIGO_REPS_PRUEBA As String = "1300102449" ' GASTROLAP S.A.S. (REPS verificado en sandbox 2026-11-08)
                Const NIT_PRUEBA As String = "900329923"
                Dim configPrueba As New ConfigInteropApi With {
                    .Id = config.Id,
                    .Ambiente = config.Ambiente,
                    .TenantId = config.TenantId,
                    .ClientId = config.ClientId,
                    .ClientSecret = config.ClientSecret,
                    .SubscriptionKey = config.SubscriptionKey,
                    .UrlAuthServer = config.UrlAuthServer,
                    .UrlBaseApi = config.UrlBaseApi,
                    .CodigoPrestadorReps = CODIGO_REPS_PRUEBA,
                    .NitPrestador = NIT_PRUEBA
                }

                ' 2. Datos fijos de prueba (verificados contra MPI/RETHUS/REPS; Dr. Bonfante en RETHUS el 2026-11-08)
                Dim paciente As New Usuarios With {
                    .CodigotipoIdentificacion = "CC",
                    .Identificacion = "1101209317",
                    .PrimerNombre = "FABIAN",
                    .SegundoNombre = "ANDRES",
                    .PrimerApellido = "SUAREZ",
                    .SegundoApellido = "ALVERNIA",
                    .Sexo = "M",
                    .FechaNacimiento = New Date(1996, 8, 22),
                    .CodigoMunicipio = "13001",
                    .Zona = "U"
                }

                Dim especialista As New Especialista With {
                    .IdTipoIdentificacion = "CC",
                    .Identificacion = "73106055",
                    .Nombre = "JAIME JOSE BONFANTE MOLINARES",
                    .PrimerNombre = "JAIME",
                    .SegundoNombre = "JOSE",
                    .PrimerApellido = "BONFANTE",
                    .SegundoApellido = "MOLINARES"
                }

                ' 3. Token vigente
                Dim _dRDA As New DRDA
                Dim token As String = Await _dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    Return "❌ No fue posible obtener un token de MinSalud. Revisa las credenciales en 'Interoperabilidad RDA'."
                End If

                ' 4. Armar el Bundle (sin CUPS de procedimiento por la limitación del sandbox)
                Dim bundleJson As String = RDAConsultaExternaBuilder.ConstruirBundleConsultaExterna(
                    paciente:=paciente,
                    especialista:=especialista,
                    config:=configPrueba,
                    nombreOrganizacion:=DRDA.NombrePrestador(),
                    diagnosticoCie10Codigo:="K219",
                    diagnosticoCie10Texto:="ENFERMEDAD DEL REFLUJO GASTROESOFAGICO SIN ESOFAGITIS",
                    cupsConsultaCodigo:="890246",
                    cupsConsultaTexto:="CONSULTA DE PRIMERA VEZ POR ESPECIALISTA EN GASTROENTEROLOGÍA",
                    grupoServiciosCodigo:="01",
                    grupoServiciosTexto:="Consulta externa",
                    repsHealthcareServiceCodigo:=REPS_SERVICIO_CODIGO,
                    repsHealthcareServiceTexto:=REPS_SERVICIO_TEXTO)

                ' 5. Enviar
                Dim urlEnvio As String = configPrueba.UrlBaseApi.TrimEnd("/"c) & "/Composition/$enviar-rda-consulta"
                Using client As New HttpClient()
                    Dim request As New HttpRequestMessage(HttpMethod.Post, urlEnvio)
                    request.Headers.Add("Authorization", "Bearer " & token)
                    If Not String.IsNullOrWhiteSpace(configPrueba.SubscriptionKey) Then
                        request.Headers.Add("Ocp-Apim-Subscription-Key", configPrueba.SubscriptionKey)
                    End If
                    request.Content = New StringContent(bundleJson, Encoding.UTF8, "application/json")

                    Dim response As HttpResponseMessage = Await client.SendAsync(request)
                    Dim cuerpo As String = Await response.Content.ReadAsStringAsync()

                    If response.IsSuccessStatusCode Then
                        Return $"✅ MinSalud aceptó el RDA de Consulta Externa (HTTP {CInt(response.StatusCode)})." & Environment.NewLine & Environment.NewLine &
                               "Respuesta del API:" & Environment.NewLine & cuerpo
                    Else
                        Return $"🔴 MinSalud rechazó el RDA de Consulta Externa (HTTP {CInt(response.StatusCode)})." & Environment.NewLine & Environment.NewLine &
                               "Respuesta del API:" & Environment.NewLine & cuerpo
                    End If
                End Using

            Catch ex As Exception
                Return "❌ Error al enviar el RDA de Consulta Externa de prueba: " & ex.Message
            End Try
        End Function

    End Class

End Namespace

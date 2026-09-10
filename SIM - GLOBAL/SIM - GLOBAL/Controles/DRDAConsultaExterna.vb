Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports System.Net.Http
Imports System.Text

Namespace Controles

    ''' <summary>
    ''' Envía documentos RDA-Consulta Externa a MinSalud. Por ahora solo expone un envío de
    ''' PRUEBA con datos fijos (verificados contra el sandbox real el 2026-09-09), siguiendo el
    ''' mismo patrón de DRDAPaciente.EnviarRDAPruebaAsync.
    ''' </summary>
    Public Class DRDAConsultaExterna

        ''' <summary>
        ''' Envía un RDA-Consulta Externa de prueba: paciente Fabián Suárez, especialista Dra.
        ''' Yovelis Martínez, IPS Gastrocaribe, diagnóstico A01.3, consulta CUPS 890246.
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

                Const CODIGO_REPS_GASTROCARIBE As String = "1300102098"
                Const NIT_GASTROCARIBE As String = "900270916"
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

                ' 2. Datos fijos de prueba (verificados contra MPI/RETHUS/REPS el 2026-09-09)
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
                    .Identificacion = "1047365746",
                    .Nombre = "Yovelis Paola Martinez Oquendo",
                    .PrimerNombre = "Yovelis",
                    .SegundoNombre = "Paola",
                    .PrimerApellido = "Martinez",
                    .SegundoApellido = "Oquendo"
                }

                ' 3. Token vigente
                Dim dRDA As New DRDA
                Dim token As String = Await dRDA.TraerToken(configId)
                If String.IsNullOrWhiteSpace(token) Then
                    Return "❌ No fue posible obtener un token de MinSalud. Revisa las credenciales en 'Interoperabilidad RDA'."
                End If

                ' 4. Armar el Bundle (sin CUPS de procedimiento por la limitación del sandbox)
                Dim bundleJson As String = RDAConsultaExternaBuilder.ConstruirBundleConsultaExterna(
                    paciente:=paciente,
                    especialista:=especialista,
                    config:=configPrueba,
                    nombreOrganizacion:="Gastrocaribe",
                    diagnosticoCie10Codigo:="A013",
                    diagnosticoCie10Texto:="FIEBRE PARATIFOIDEA C",
                    cupsConsultaCodigo:="890246",
                    cupsConsultaTexto:="CONSULTA DE PRIMERA VEZ POR ESPECIALISTA EN GASTROENTEROLOGÍA",
                    grupoServiciosCodigo:="01",
                    grupoServiciosTexto:="Consulta externa",
                    repsHealthcareServiceCodigo:="329",
                    repsHealthcareServiceTexto:="MEDICINA INTERNA")

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

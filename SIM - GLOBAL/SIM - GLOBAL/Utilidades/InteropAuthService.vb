Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports Newtonsoft.Json
Imports SIM___GLOBAL.Modelo

Namespace Utilidades
    Public Module InteropAuthService

        Public Async Function SolicitarTokenAsync(config As ConfigInteropApi) As Task(Of TokenResponse)
            Using client As New HttpClient()

                ' URL completa construida dinámicamente usando el Tenant_Id o la UrlAuthServer de la BD
                Dim urlAuth As String = config.UrlAuthServer.Replace("{{tenantid}}", config.TenantId)

                ' Cuerpo del POST codificado en application/x-www-form-urlencoded
                Dim valoresPost As New Dictionary(Of String, String) From {
                    {"grant_type", "client_credentials"},
                    {"client_id", config.ClientId},
                    {"client_secret", config.ClientSecret},
                    {"scope", "api://ca9a5155-3135-4e44-a644-b92175eb4d21/.default"}
                }
                Dim content As New FormUrlEncodedContent(valoresPost)

                ' Realizar la petición POST
                Dim response As HttpResponseMessage = Await client.PostAsync(urlAuth, content)

                If response.IsSuccessStatusCode Then
                    Dim jsonResultado As String = Await response.Content.ReadAsStringAsync()

                    ' Deserializar usando el modelo TokenResponse
                    Dim tokenInfo As TokenResponse = JsonConvert.DeserializeObject(Of TokenResponse)(jsonResultado)

                    Return tokenInfo
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    Throw New Exception($"Error de autenticación con MinSalud: {response.StatusCode} - {errorContent}")
                End If

            End Using
        End Function

    End Module
End Namespace

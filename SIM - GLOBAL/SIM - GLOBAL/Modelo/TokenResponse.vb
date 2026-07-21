Imports Newtonsoft.Json
Namespace Modelo

    Public Class TokenResponse
        <JsonProperty("token_type")>
        Public Property TokenType As String

        <JsonProperty("expires_in")>
        Public Property ExpiresIn As Integer

        <JsonProperty("ext_expires_in")>
        Public Property ExtExpiresIn As Integer

        <JsonProperty("access_token")>
        Public Property AccessToken As String
    End Class
End Namespace

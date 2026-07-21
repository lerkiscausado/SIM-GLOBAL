Namespace Modelo
    Public Class ConfigInteropApi
        Public Property Id As Integer

        ''' <summary>
        ''' Define si es 'SANDBOX' o 'PRODUCCION'
        ''' </summary>
        Public Property Ambiente As String = "SANDBOX"

        ''' <summary>
        ''' Tenant ID de Azure Active Directory provisto por MinSalud
        ''' </summary>
        Public Property TenantId As String

        ''' <summary>
        ''' Client ID de la suscripción de la aplicación en el portal de MinSalud
        ''' </summary>
        Public Property ClientId As String

        ''' <summary>
        ''' Client Secret provisto (Debe manejarse encriptado en Base de Datos)
        ''' </summary>
        Public Property ClientSecret As String

        ''' <summary>
        ''' Clave de suscripción del API Management: Ocp-Apim-Subscription-Key
        ''' </summary>
        Public Property SubscriptionKey As String

        ''' <summary>
        ''' URL del servidor de Autenticación de Microsoft/MinSalud
        ''' </summary>
        Public Property UrlAuthServer As String

        ''' <summary>
        ''' URL Base para el envío de los Bundles FHIR RDA
        ''' </summary>
        Public Property UrlBaseApi As String

        Public Property Estado As Boolean = True
        Public Property FechaRegistro As DateTime = DateTime.Now
        Public Property FechaActualizacion As DateTime = DateTime.Now
    End Class
End Namespace


Namespace Modelo
    Public Class ConfiguracionCorreo
        Private _id As String
        Private _idLicencia As String
        Private _servidor As String
        Private _puerto As String
        Private _correo As String
        Private _pass As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Public Property IdLicencia As String
            Get
                Return _idLicencia
            End Get
            Set(value As String)
                _idLicencia = value
            End Set
        End Property

        Public Property Servidor As String
            Get
                Return _servidor
            End Get
            Set(value As String)
                _servidor = value
            End Set
        End Property

        Public Property Puerto As String
            Get
                Return _puerto
            End Get
            Set(value As String)
                _puerto = value
            End Set
        End Property

        Public Property Correo As String
            Get
                Return _correo
            End Get
            Set(value As String)
                _correo = value
            End Set
        End Property

        Public Property Pass As String
            Get
                Return _pass
            End Get
            Set(value As String)
                _pass = value
            End Set
        End Property

    End Class
End Namespace

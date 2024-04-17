Namespace Modelo
    Public Class Sesiones
        Private _Id As Integer
        Private _IdUsuario As Integer
        Private _Contrasena As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdUsuario As Integer
            Get
                Return _IdUsuario
            End Get
            Set(value As Integer)
                _IdUsuario = value
            End Set
        End Property

        Public Property Contrasena As String
            Get
                Return _Contrasena
            End Get
            Set(value As String)
                _Contrasena = value
            End Set
        End Property
    End Class
End Namespace


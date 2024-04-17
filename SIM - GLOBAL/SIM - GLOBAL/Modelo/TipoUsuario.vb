Namespace My.Modelo
    Public Class TipoUsuario
        Private _id As Integer
        Private _nombreTipoUsuario As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreTipoUsuario As String
            Get
                Return _nombreTipoUsuario
            End Get
            Set(value As String)
                _nombreTipoUsuario = value
            End Set
        End Property
    End Class
End Namespace


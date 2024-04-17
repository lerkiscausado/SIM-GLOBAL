Namespace My.Modelo
    Public Class Tarifas
        Private _id As Integer
        Private _nombre As String
        Private _estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Estado As String
            Get
                Return _estado
            End Get
            Set(value As String)
                _estado = value
            End Set
        End Property
    End Class
End Namespace


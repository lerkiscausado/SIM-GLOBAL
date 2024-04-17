Namespace My.Modelo
    Public Class Equipos
        Private _id As String
        Private _nombre As String
        Private _marca As String
        Private _modelo As String
        Private _Estado As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
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

        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property

        Public Property Modelo As String
            Get
                Return _modelo
            End Get
            Set(value As String)
                _modelo = value
            End Set
        End Property

        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(value As String)
                _Estado = value
            End Set
        End Property
    End Class
End Namespace


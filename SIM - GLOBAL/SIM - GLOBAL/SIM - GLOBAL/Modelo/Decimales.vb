Public Class Decimales
    Private _id As Integer
    Private _flotante As Single
    Private _doble As Single
    Private _decimal As Single

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Flotante As Single
        Get
            Return _flotante
        End Get
        Set(value As Single)
            _flotante = value
        End Set
    End Property

    Public Property Doble As Single
        Get
            Return _doble
        End Get
        Set(value As Single)
            _doble = value
        End Set
    End Property

    Public Property [Decimal] As Single
        Get
            Return _decimal
        End Get
        Set(value As Single)
            _decimal = value
        End Set
    End Property
End Class

Namespace Modelo
    Public Class EstudiosPDF
        Private _Id As Integer
        Private _IdOrden As Integer

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdOrden As Integer
            Get
                Return _IdOrden
            End Get
            Set(value As Integer)
                _IdOrden = value
            End Set
        End Property
    End Class
End Namespace

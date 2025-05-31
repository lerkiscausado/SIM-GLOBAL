Namespace Modelo
    Public Class ExamenesPrequirurgicos
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _Examen As String

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

        Public Property IdDetalleOrden As Integer
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As Integer)
                _IdDetalleOrden = value
            End Set
        End Property

        Public Property Examen As String
            Get
                Return _Examen
            End Get
            Set(value As String)
                _Examen = value
            End Set
        End Property
    End Class
End Namespace


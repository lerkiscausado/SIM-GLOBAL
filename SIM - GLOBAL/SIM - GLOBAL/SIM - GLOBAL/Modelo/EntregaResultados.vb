Namespace Modelo
    Public Class EntregaResultados
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _FechaEntrega As Date
        Private _TipoEstudio As String

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

        Public Property FechaEntrega As Date
            Get
                Return _FechaEntrega
            End Get
            Set(value As Date)
                _FechaEntrega = value
            End Set
        End Property

        Public Property TipoEstudio As String
            Get
                Return _TipoEstudio
            End Get
            Set(value As String)
                _TipoEstudio = value
            End Set
        End Property
    End Class
End Namespace


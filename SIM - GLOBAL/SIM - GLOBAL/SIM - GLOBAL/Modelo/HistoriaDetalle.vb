Namespace Modelo
    Public Class HistoriaDetalle
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _FuncionEscrotal As String
        Private _MicroPene As String
        Private _MeatusUretral As String
        Private _TesticuloIzquierdo As String
        Private _TesticuloDerecho As String
        Private _IdEscalaPrader As String

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

        Public Property FuncionEscrotal As String
            Get
                Return _FuncionEscrotal
            End Get
            Set(value As String)
                _FuncionEscrotal = value
            End Set
        End Property

        Public Property MicroPene As String
            Get
                Return _MicroPene
            End Get
            Set(value As String)
                _MicroPene = value
            End Set
        End Property

        Public Property MeatusUretral As String
            Get
                Return _MeatusUretral
            End Get
            Set(value As String)
                _MeatusUretral = value
            End Set
        End Property

        Public Property TesticuloIzquierdo As String
            Get
                Return _TesticuloIzquierdo
            End Get
            Set(value As String)
                _TesticuloIzquierdo = value
            End Set
        End Property

        Public Property TesticuloDerecho As String
            Get
                Return _TesticuloDerecho
            End Get
            Set(value As String)
                _TesticuloDerecho = value
            End Set
        End Property

        Public Property IdEscalaPrader As String
            Get
                Return _IdEscalaPrader
            End Get
            Set(value As String)
                _IdEscalaPrader = value
            End Set
        End Property
    End Class
End Namespace


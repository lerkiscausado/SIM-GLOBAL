Namespace Modelo
    Public Class BloqueoRegistros
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _IdUser As Integer
        Private _IdTabla As Integer

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

        Public Property IdTabla As Integer
            Get
                Return _IdTabla
            End Get
            Set(value As Integer)
                _IdTabla = value
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

        Public Property IdUser As Integer
            Get
                Return _IdUser
            End Get
            Set(value As Integer)
                _IdUser = value
            End Set
        End Property
    End Class
End Namespace


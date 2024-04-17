Namespace Modelo
    Public Class OrdenServicio
        Private _Id As Integer
        Private _idLicencia As Integer
        Private _OrdenServicio As String
        Private _FechaOrden As Date
        Private _FechaVencimiento As Date
        Private _Concepto As String
        Private _Valor As Integer
        Private _Descuento As Integer
        Private _Estado As String
        Private _IdCliente As Integer
        Private _TipoOrden As String
        Private _IdEvento As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdLicencia As Integer
            Get
                Return _idLicencia
            End Get
            Set(value As Integer)
                _idLicencia = value
            End Set
        End Property

        Public Property OrdenServicio As String
            Get
                Return _OrdenServicio
            End Get
            Set(value As String)
                _OrdenServicio = value
            End Set
        End Property

        Public Property FechaOrden As Date
            Get
                Return _FechaOrden
            End Get
            Set(value As Date)
                _FechaOrden = value
            End Set
        End Property

        Public Property FechaVencimiento As Date
            Get
                Return _FechaVencimiento
            End Get
            Set(value As Date)
                _FechaVencimiento = value
            End Set
        End Property

        Public Property Concepto As String
            Get
                Return _Concepto
            End Get
            Set(value As String)
                _Concepto = value
            End Set
        End Property

        Public Property Valor As Integer
            Get
                Return _Valor
            End Get
            Set(value As Integer)
                _Valor = value
            End Set
        End Property

        Public Property Descuento As Integer
            Get
                Return _Descuento
            End Get
            Set(value As Integer)
                _Descuento = value
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

        Public Property IdCliente As Integer
            Get
                Return _IdCliente
            End Get
            Set(value As Integer)
                _IdCliente = value
            End Set
        End Property

        Public Property TipoOrden As String
            Get
                Return _TipoOrden
            End Get
            Set(value As String)
                _TipoOrden = value
            End Set
        End Property

        Public Property IdEvento As String
            Get
                Return _IdEvento
            End Get
            Set(value As String)
                _IdEvento = value
            End Set
        End Property
    End Class
End Namespace


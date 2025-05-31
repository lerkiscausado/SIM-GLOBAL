Namespace Modelo
    Public Class Inventario
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdDocumento As Integer
        Private _IdProducto As Integer
        Private _IdMarca As Integer
        Private _IdPresentacionProducto As Integer
        Private _Movimiento As String
        Private _Factura As String
        Private _Observacion As String
        Private _EntradaCantidad As Double
        Private _EntradaValor As Double
        Private _SalidaCantidad As Double
        Private _SalidaValor As Double
        Private _SaldoCantidad As Double
        Private _SaldoTotal As Double
        Private _ValorPromedio As Double
        Private _IdEmpleado As Integer
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property

        Public Property Hora As Date
            Get
                Return _Hora
            End Get
            Set(value As Date)
                _Hora = value
            End Set
        End Property

        Public Property IdDocumento As Integer
            Get
                Return _IdDocumento
            End Get
            Set(value As Integer)
                _IdDocumento = value
            End Set
        End Property

        Public Property IdProducto As Integer
            Get
                Return _IdProducto
            End Get
            Set(value As Integer)
                _IdProducto = value
            End Set
        End Property

        Public Property IdMarca As Integer
            Get
                Return _IdMarca
            End Get
            Set(value As Integer)
                _IdMarca = value
            End Set
        End Property

        Public Property IdPresentacionProducto As Integer
            Get
                Return _IdPresentacionProducto
            End Get
            Set(value As Integer)
                _IdPresentacionProducto = value
            End Set
        End Property

        Public Property Movimiento As String
            Get
                Return _Movimiento
            End Get
            Set(value As String)
                _Movimiento = value
            End Set
        End Property

        Public Property Factura As String
            Get
                Return _Factura
            End Get
            Set(value As String)
                _Factura = value
            End Set
        End Property

        Public Property Observacion As String
            Get
                Return _Observacion
            End Get
            Set(value As String)
                _Observacion = value
            End Set
        End Property

        Public Property EntradaCantidad As Double
            Get
                Return _EntradaCantidad
            End Get
            Set(value As Double)
                _EntradaCantidad = value
            End Set
        End Property

        Public Property EntradaValor As Double
            Get
                Return _EntradaValor
            End Get
            Set(value As Double)
                _EntradaValor = value
            End Set
        End Property

        Public Property SalidaCantidad As Double
            Get
                Return _SalidaCantidad
            End Get
            Set(value As Double)
                _SalidaCantidad = value
            End Set
        End Property

        Public Property SalidaValor As Double
            Get
                Return _SalidaValor
            End Get
            Set(value As Double)
                _SalidaValor = value
            End Set
        End Property

        Public Property SaldoCantidad As Double
            Get
                Return _SaldoCantidad
            End Get
            Set(value As Double)
                _SaldoCantidad = value
            End Set
        End Property

        Public Property SaldoTotal As Double
            Get
                Return _SaldoTotal
            End Get
            Set(value As Double)
                _SaldoTotal = value
            End Set
        End Property

        Public Property ValorPromedio As Double
            Get
                Return _ValorPromedio
            End Get
            Set(value As Double)
                _ValorPromedio = value
            End Set
        End Property

        Public Property IdEmpleado As Integer
            Get
                Return _IdEmpleado
            End Get
            Set(value As Integer)
                _IdEmpleado = value
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


Namespace Modelo
    Public Class Compras
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdOrdenCompra As Integer
        Private _Concepto As String
        Private _Factura As String
        Private _Estado As String
        Private _FechaConfirmacion As Date
        Private _IdEmpleado As String

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

        Public Property IdOrdenCompra As Integer
            Get
                Return _IdOrdenCompra
            End Get
            Set(value As Integer)
                _IdOrdenCompra = value
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

        Public Property Factura As String
            Get
                Return _Factura
            End Get
            Set(value As String)
                _Factura = value
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

        Public Property FechaConfirmacion As Date
            Get
                Return _FechaConfirmacion
            End Get
            Set(value As Date)
                _FechaConfirmacion = value
            End Set
        End Property

        Public Property IdEmpleado As String
            Get
                Return _IdEmpleado
            End Get
            Set(value As String)
                _IdEmpleado = value
            End Set
        End Property
    End Class

End Namespace

Namespace Modelo
    Public Class Caja
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _Fecha As Date
        Private _Ciudad As String
        Private _Nombre As String
        Private _Identificacion As String
        Private _Direccion As String
        Private _Telefono As String
        Private _Valor As Double
        Private _Concepto As String
        Private _Estado As String
        Private _IdEmpleado As String
        Private _IdCierre As String
        Private _Referencia As String
        Private _IdCliente As Integer

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

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property

        Public Property Ciudad As String
            Get
                Return _Ciudad
            End Get
            Set(value As String)
                _Ciudad = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
            End Set
        End Property

        Public Property Identificacion As String
            Get
                Return _Identificacion
            End Get
            Set(value As String)
                _Identificacion = value
            End Set
        End Property

        Public Property Direccion As String
            Get
                Return _Direccion
            End Get
            Set(value As String)
                _Direccion = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(value As String)
                _Telefono = value
            End Set
        End Property

        Public Property Valor As Double
            Get
                Return _Valor
            End Get
            Set(value As Double)
                _Valor = value
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

        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(value As String)
                _Estado = value
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

        Public Property IdCierre As String
            Get
                Return _IdCierre
            End Get
            Set(value As String)
                _IdCierre = value
            End Set
        End Property

        Public Property Referencia As String
            Get
                Return _Referencia
            End Get
            Set(value As String)
                _Referencia = value
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
    End Class
End Namespace


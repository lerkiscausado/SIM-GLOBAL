Namespace Modelo
    Public Class Facturas
        Private _id As Integer
        Private _idLicencia As Integer
        Private _factura As String
        Private _IdContrato As Integer
        Private _fechaFactura As Date
        Private _fechaVencimiento As Date
        Private _concepto As String
        Private _valor As Integer
        Private _copagos As Integer
        Private _descuento As Integer
        Private _Estado As String
        Private _IdCliente As String
        Private _TipoFactura As String
        Private _remision As String
        Private _IdEmpleado As String
        Private _Rips As Integer

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property IdContrato As Integer
            Get
                Return _IdContrato
            End Get
            Set(value As Integer)
                _IdContrato = value
            End Set
        End Property

        Public Property FechaFactura As Date
            Get
                Return _fechaFactura
            End Get
            Set(value As Date)
                _fechaFactura = value
            End Set
        End Property

        Public Property FechaVencimiento As Date
            Get
                Return _fechaVencimiento
            End Get
            Set(value As Date)
                _fechaVencimiento = value
            End Set
        End Property

        Public Property Concepto As String
            Get
                Return _concepto
            End Get
            Set(value As String)
                _concepto = value
            End Set
        End Property

        Public Property Valor As Integer
            Get
                Return _valor
            End Get
            Set(value As Integer)
                _valor = value
            End Set
        End Property

        Public Property Copagos As Integer
            Get
                Return _copagos
            End Get
            Set(value As Integer)
                _copagos = value
            End Set
        End Property

        Public Property Descuento As Integer
            Get
                Return _descuento
            End Get
            Set(value As Integer)
                _descuento = value
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

        Public Property IdLicencia As Integer
            Get
                Return _idLicencia
            End Get
            Set(value As Integer)
                _idLicencia = value
            End Set
        End Property

        Public Property Factura As String
            Get
                Return _factura
            End Get
            Set(value As String)
                _factura = value
            End Set
        End Property

        Public Property IdCliente As String
            Get
                Return _IdCliente
            End Get
            Set(value As String)
                _IdCliente = value
            End Set
        End Property

        Public Property TipoFactura As String
            Get
                Return _TipoFactura
            End Get
            Set(value As String)
                _TipoFactura = value
            End Set
        End Property

        Public Property Remision As String
            Get
                Return _remision
            End Get
            Set(value As String)
                _remision = value
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

        Public Property Rips As Integer
            Get
                Return _Rips
            End Get
            Set(value As Integer)
                _Rips = value
            End Set
        End Property
    End Class
End Namespace

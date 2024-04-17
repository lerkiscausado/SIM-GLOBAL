Namespace Modelo
    Public Class Cotizaciones
        Private _Id As Integer
        Private _idLicencia As Integer
        Private _cotizacion As String
        Private _fechaCotizacion As Date
        Private _fechaVencimiento As Date
        Private _concepto As String
        Private _valor As Integer
        Private _descuento As Integer
        Private _estado As String
        Private _idCliente As Integer
        Private _tipoFactura As String

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

        Public Property Cotizacion As String
            Get
                Return _cotizacion
            End Get
            Set(value As String)
                _cotizacion = value
            End Set
        End Property

        Public Property FechaCotizacion As Date
            Get
                Return _fechaCotizacion
            End Get
            Set(value As Date)
                _fechaCotizacion = value
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
                Return _estado
            End Get
            Set(value As String)
                _estado = value
            End Set
        End Property

        Public Property IdCliente As Integer
            Get
                Return _idCliente
            End Get
            Set(value As Integer)
                _idCliente = value
            End Set
        End Property

        Public Property TipoFactura As String
            Get
                Return _tipoFactura
            End Get
            Set(value As String)
                _tipoFactura = value
            End Set
        End Property
    End Class
End Namespace

Namespace Modelo
    Public Class CuentasClientes
        Private _Id As Integer
        Private _IdLicencia As Integer
        Private _IdCliente As Integer
        Private _TipoDocumento As String
        Private _NumeroDocumento As String
        Private _Fecha As Date
        Private _Concepto As String
        Private _Valor As Double
        Private _Saldo As Double

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
                Return _IdLicencia
            End Get
            Set(value As Integer)
                _IdLicencia = value
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

        Public Property TipoDocumento As String
            Get
                Return _TipoDocumento
            End Get
            Set(value As String)
                _TipoDocumento = value
            End Set
        End Property

        Public Property NumeroDocumento As String
            Get
                Return _NumeroDocumento
            End Get
            Set(value As String)
                _NumeroDocumento = value
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

        Public Property Concepto As String
            Get
                Return _Concepto
            End Get
            Set(value As String)
                _Concepto = value
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

        Public Property Saldo As Double
            Get
                Return _Saldo
            End Get
            Set(value As Double)
                _Saldo = value
            End Set
        End Property
    End Class

End Namespace

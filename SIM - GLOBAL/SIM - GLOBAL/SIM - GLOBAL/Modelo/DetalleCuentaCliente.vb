Namespace Modelo
    Public Class DetalleCuentaCliente
        Private _Id As Integer
        Private _IdCuentaCliente As Integer
        Private _IdRecibo As Integer
        Private _Valor As Double
        Private _Saldo As Double
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdCuentaCliente As Integer
            Get
                Return _IdCuentaCliente
            End Get
            Set(value As Integer)
                _IdCuentaCliente = value
            End Set
        End Property

        Public Property IdRecibo As Integer
            Get
                Return _IdRecibo
            End Get
            Set(value As Integer)
                _IdRecibo = value
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

        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(value As String)
                _Estado = value
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


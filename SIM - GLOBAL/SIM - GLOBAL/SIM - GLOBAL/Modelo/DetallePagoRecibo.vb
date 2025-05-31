Namespace Modelo
    Public Class DetallePagoRecibo
        Private _Id As String
        Private _IdRecibo As String
        Private _IdMedioPago As String
        Private _Valor As Double

        Public Property Id As String
            Get
                Return _Id
            End Get
            Set(value As String)
                _Id = value
            End Set
        End Property

        Public Property IdRecibo As String
            Get
                Return _IdRecibo
            End Get
            Set(value As String)
                _IdRecibo = value
            End Set
        End Property

        Public Property IdMedioPago As String
            Get
                Return _IdMedioPago
            End Get
            Set(value As String)
                _IdMedioPago = value
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
    End Class
End Namespace


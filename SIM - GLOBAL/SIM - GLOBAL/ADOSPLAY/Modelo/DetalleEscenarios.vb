Namespace My.Modelo
    Public Class DetalleEscenarios
        Private _IdEscenario As Integer
        Private _IdDeporte As Integer

        Public Property IdEscenario As Integer
            Get
                Return _IdEscenario
            End Get
            Set(value As Integer)
                _IdEscenario = value
            End Set
        End Property

        Public Property IdDeporte As Integer
            Get
                Return _IdDeporte
            End Get
            Set(value As Integer)
                _IdDeporte = value
            End Set
        End Property
    End Class
End Namespace


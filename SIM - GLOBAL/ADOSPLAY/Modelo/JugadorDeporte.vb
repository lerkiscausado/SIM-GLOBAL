Namespace My.Modelo
    Public Class JugadorDeporte
        Private _IdJugador As Integer
        Private _IdDeporte As Integer

        Public Property IdJugador As Integer
            Get
                Return _IdJugador
            End Get
            Set(value As Integer)
                _IdJugador = value
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

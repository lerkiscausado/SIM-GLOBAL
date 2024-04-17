Namespace My.Modelo
    Public Class DetalleInscripciones
        Private _Id As Integer
        Private _Foto As String
        Private _Numero As String
        Private _IdInscripcion As Integer
        Private _IdJugador As Integer

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Foto As String
            Get
                Return _Foto
            End Get
            Set(value As String)
                _Foto = value
            End Set
        End Property

        Public Property Numero As String
            Get
                Return _Numero
            End Get
            Set(value As String)
                _Numero = value
            End Set
        End Property

        Public Property IdInscripcion As Integer
            Get
                Return _IdInscripcion
            End Get
            Set(value As Integer)
                _IdInscripcion = value
            End Set
        End Property

        Public Property IdJugador As Integer
            Get
                Return _IdJugador
            End Get
            Set(value As Integer)
                _IdJugador = value
            End Set
        End Property
    End Class

End Namespace

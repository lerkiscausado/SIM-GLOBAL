Namespace My.Modelo
    Public Class Inscripciones
        Private _Id As Integer
        Private _IdTorneo As Integer
        Private _IdEquipo As Integer

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdTorneo As Integer
            Get
                Return _IdTorneo
            End Get
            Set(value As Integer)
                _IdTorneo = value
            End Set
        End Property

        Public Property IdEquipo As Integer
            Get
                Return _IdEquipo
            End Get
            Set(value As Integer)
                _IdEquipo = value
            End Set
        End Property
    End Class

End Namespace

Namespace My.Modelo
    Public Class Programacion
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdTorneo As Integer
        Private _IdEquipoLocal As Integer
        Private _IdEquipoVisitante As Integer
        Private _IdEscenario As Integer
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property Hora As Date
            Get
                Return _Hora
            End Get
            Set(value As Date)
                _Hora = value
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

        Public Property IdEquipoLocal As Integer
            Get
                Return _IdEquipoLocal
            End Get
            Set(value As Integer)
                _IdEquipoLocal = value
            End Set
        End Property

        Public Property IdEquipoVisitante As Integer
            Get
                Return _IdEquipoVisitante
            End Get
            Set(value As Integer)
                _IdEquipoVisitante = value
            End Set
        End Property

        Public Property IdEscenario As Integer
            Get
                Return _IdEscenario
            End Get
            Set(value As Integer)
                _IdEscenario = value
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
    End Class

End Namespace

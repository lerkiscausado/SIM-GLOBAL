Namespace My.Modelo
    Public Class Torneo
        Private _Id As Integer
        Private _Nombre As String
        Private _DescripcionCampeonato As String
        Private _FechaInicio As Date
        Private _IdOrganizador As Integer
        Private _IdDeporte As Integer
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
            End Set
        End Property

        Public Property DescripcionCampeonato As String
            Get
                Return _DescripcionCampeonato
            End Get
            Set(value As String)
                _DescripcionCampeonato = value
            End Set
        End Property

        Public Property FechaInicio As Date
            Get
                Return _FechaInicio
            End Get
            Set(value As Date)
                _FechaInicio = value
            End Set
        End Property

        Public Property IdOrganizador As Integer
            Get
                Return _IdOrganizador
            End Get
            Set(value As Integer)
                _IdOrganizador = value
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


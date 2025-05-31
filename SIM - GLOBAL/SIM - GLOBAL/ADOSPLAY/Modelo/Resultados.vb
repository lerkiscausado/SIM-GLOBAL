Namespace My.Modelo
    Public Class Resultados
        Private _Id As Integer
        Private _Q1 As String
        Private _Q2 As String
        Private _Q3 As String
        Private _Q4 As String
        Private _Q5 As String
        Private _Q6 As String
        Private _IdProgramacion As Integer
        Private _IdEquipoLocal As Integer
        Private _IdEquipoVisitante As Integer

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Q1 As String
            Get
                Return _Q1
            End Get
            Set(value As String)
                _Q1 = value
            End Set
        End Property

        Public Property Q2 As String
            Get
                Return _Q2
            End Get
            Set(value As String)
                _Q2 = value
            End Set
        End Property

        Public Property Q3 As String
            Get
                Return _Q3
            End Get
            Set(value As String)
                _Q3 = value
            End Set
        End Property

        Public Property Q4 As String
            Get
                Return _Q4
            End Get
            Set(value As String)
                _Q4 = value
            End Set
        End Property

        Public Property Q5 As String
            Get
                Return _Q5
            End Get
            Set(value As String)
                _Q5 = value
            End Set
        End Property

        Public Property Q6 As String
            Get
                Return _Q6
            End Get
            Set(value As String)
                _Q6 = value
            End Set
        End Property

        Public Property IdProgramacion As Integer
            Get
                Return _IdProgramacion
            End Get
            Set(value As Integer)
                _IdProgramacion = value
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
    End Class

End Namespace

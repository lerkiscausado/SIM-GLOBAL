Namespace My.Modelo
    Public Class Jugadores
        Private _Id As Integer
        Private _Nombre As String
        Private _FechaNacimiento As Date
        Private _Sexo As String
        Private _Estatura As String
        Private _Peso As String
        Private _Correo As String
        Private _Telefono As String

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

        Public Property FechaNacimiento As Date
            Get
                Return _FechaNacimiento
            End Get
            Set(value As Date)
                _FechaNacimiento = value
            End Set
        End Property

        Public Property Estatura As String
            Get
                Return _Estatura
            End Get
            Set(value As String)
                _Estatura = value
            End Set
        End Property

        Public Property Peso As String
            Get
                Return _Peso
            End Get
            Set(value As String)
                _Peso = value
            End Set
        End Property

        Public Property Correo As String
            Get
                Return _Correo
            End Get
            Set(value As String)
                _Correo = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(value As String)
                _Telefono = value
            End Set
        End Property

        Public Property Sexo As String
            Get
                Return _Sexo
            End Get
            Set(value As String)
                _Sexo = value
            End Set
        End Property
    End Class

End Namespace

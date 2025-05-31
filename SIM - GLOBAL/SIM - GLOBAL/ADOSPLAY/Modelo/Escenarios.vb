Namespace My.Modelo
    Public Class Escenarios
        Private _Id As Integer
        Private _Nombre As String
        Private _Direccion As String
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

        Public Property Direccion As String
            Get
                Return _Direccion
            End Get
            Set(value As String)
                _Direccion = value
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

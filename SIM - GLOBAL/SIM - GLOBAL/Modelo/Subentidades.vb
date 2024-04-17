Namespace My.Modelo
    Public Class Subentidades
        Private _Id As Integer
        Private _IdContrato As Integer
        Private _Nombre As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdContrato As Integer
            Get
                Return _IdContrato
            End Get
            Set(value As Integer)
                _IdContrato = value
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


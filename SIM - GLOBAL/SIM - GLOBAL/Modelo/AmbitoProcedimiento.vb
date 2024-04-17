Namespace My.Modelo
    Public Class AmbitoProcedimiento
        Private _id As String
        Private _Nombre As String
        Private _estado As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
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
                Return _estado
            End Get
            Set(value As String)
                _estado = value
            End Set
        End Property
    End Class
End Namespace


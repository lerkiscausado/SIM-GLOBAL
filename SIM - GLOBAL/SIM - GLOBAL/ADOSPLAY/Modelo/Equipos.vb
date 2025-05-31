Namespace My.Modelo
    Public Class Equipos
        Private _id As Integer
        Private _nombre As String
        Private _descripcion As String
        Private _logo As String
        Private _IDDeporte As String
        Private _Delegado As String
        Private _estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Logo As String
            Get
                Return _logo
            End Get
            Set(value As String)
                _logo = value
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



        Public Property Delegado As String
            Get
                Return _Delegado
            End Get
            Set(value As String)
                _Delegado = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property

        Public Property IDDeporte As String
            Get
                Return _IDDeporte
            End Get
            Set(value As String)
                _IDDeporte = value
            End Set
        End Property
    End Class
End Namespace


Namespace Modelo
    Public Class Licencias
        Private _id As Integer
        Private _NombreCliente As String
        Private _fechaContatacion As Date
        Private _serial As String
        Private _idOrigen As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreCliente As String
            Get
                Return _NombreCliente
            End Get
            Set(value As String)
                _NombreCliente = value
            End Set
        End Property

        Public Property FechaContatacion As Date
            Get
                Return _fechaContatacion
            End Get
            Set(value As Date)
                _fechaContatacion = value
            End Set
        End Property

        Public Property Serial As String
            Get
                Return _serial
            End Get
            Set(value As String)
                _serial = value
            End Set
        End Property

        Public Property IdOrigen As String
            Get
                Return _idOrigen
            End Get
            Set(value As String)
                _idOrigen = value
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


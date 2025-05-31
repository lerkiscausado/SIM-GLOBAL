Namespace Modelo
    Public Class Cargos
        Private _id As Integer
        Private _NombreCargo As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreCargo As String
            Get
                Return _NombreCargo
            End Get
            Set(value As String)
                _NombreCargo = value
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


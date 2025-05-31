Namespace Modelo
    Public Class Especialidades
        Private _id As Integer
        Private _nombreEspecialidad As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreEspecialidad As String
            Get
                Return _nombreEspecialidad
            End Get
            Set(value As String)
                _nombreEspecialidad = value
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


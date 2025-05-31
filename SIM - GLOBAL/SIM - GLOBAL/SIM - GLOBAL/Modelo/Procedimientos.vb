Namespace Modelo
    Public Class Procedimientos
        Private _id As Integer
        Private _nombreProcedimiento As String
        Private _Estado As String
        Public Property ID As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Public Property NombreProcedimiento As String
            Get
                Return _nombreProcedimiento
            End Get
            Set(ByVal value As String)
                _nombreProcedimiento = value
            End Set
        End Property
        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(ByVal value As String)
                _Estado = value
            End Set
        End Property
    End Class
End Namespace


Namespace Modelo
    Public Class TipoEstudio
        Private _id As Integer
        Private _nombreTipoEstudio As String
        Private _prefijo As String
        Private _estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreTipoEstudio As String
            Get
                Return _nombreTipoEstudio
            End Get
            Set(value As String)
                _nombreTipoEstudio = value
            End Set
        End Property

        Public Property Prefijo As String
            Get
                Return _prefijo
            End Get
            Set(value As String)
                _prefijo = value
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


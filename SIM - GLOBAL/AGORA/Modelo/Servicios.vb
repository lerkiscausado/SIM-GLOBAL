Namespace Modelo
    Public Class Servicios
        Private _Id As Integer
        Private _NombreServicio As String
        Private _Descripcion As String
        Private _Valor As Double
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property NombreServicio As String
            Get
                Return _NombreServicio
            End Get
            Set(value As String)
                _NombreServicio = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return _Descripcion
            End Get
            Set(value As String)
                _Descripcion = value
            End Set
        End Property

        Public Property Valor As Double
            Get
                Return _Valor
            End Get
            Set(value As Double)
                _Valor = value
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


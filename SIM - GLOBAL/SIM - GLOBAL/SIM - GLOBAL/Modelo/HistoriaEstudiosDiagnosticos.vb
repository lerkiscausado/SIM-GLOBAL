Namespace Modelo
    Public Class HistoriaEstudiosDiagnosticos
        Private _IdEstudio As Integer
        Private _IdOrden As String
        Private _IdDetalleOrden As String
        Private _Descripcion As String

        Public Property IdEstudio As Integer
            Get
                Return _IdEstudio
            End Get
            Set(value As Integer)
                _IdEstudio = value
            End Set
        End Property

        Public Property IdOrden As String
            Get
                Return _IdOrden
            End Get
            Set(value As String)
                _IdOrden = value
            End Set
        End Property

        Public Property IdDetalleOrden As String
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As String)
                _IdDetalleOrden = value
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
    End Class
End Namespace


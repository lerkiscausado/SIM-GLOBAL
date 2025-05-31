Namespace Modelo
    Public Class HistoriaDiagnosticos
        Private _IdDiagnostico As String
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _Descripcion As String

        Public Property IdOrden As Integer
            Get
                Return _IdOrden
            End Get
            Set(value As Integer)
                _IdOrden = value
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

        Public Property IdDiagnostico As String
            Get
                Return _IdDiagnostico
            End Get
            Set(value As String)
                _IdDiagnostico = value
            End Set
        End Property

        Public Property IdDetalleOrden As Integer
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As Integer)
                _IdDetalleOrden = value
            End Set
        End Property
    End Class

End Namespace

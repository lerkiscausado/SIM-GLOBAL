Namespace Modelo
    Public Class HistoriaMedicamentos
        Private _IdMedicamento As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _IdViaAdministracion As Integer
        Private _Dosis As String
        Private _Cantidad As String
        Private _Descripcion As String

        Public Property IdMedicamento As Integer
            Get
                Return _IdMedicamento
            End Get
            Set(value As Integer)
                _IdMedicamento = value
            End Set
        End Property

        Public Property IdOrden As Integer
            Get
                Return _IdOrden
            End Get
            Set(value As Integer)
                _IdOrden = value
            End Set
        End Property

        Public Property IdViaAdministracion As Integer
            Get
                Return _IdViaAdministracion
            End Get
            Set(value As Integer)
                _IdViaAdministracion = value
            End Set
        End Property

        Public Property Dosis As String
            Get
                Return _Dosis
            End Get
            Set(value As String)
                _Dosis = value
            End Set
        End Property

        Public Property Cantidad As String
            Get
                Return _Cantidad
            End Get
            Set(value As String)
                _Cantidad = value
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

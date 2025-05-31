Namespace Modelo
    Public Class DetalleOrdenServicio
        Private _Id As Integer
        Private _IdProducto As Integer
        Private _Cantidad As Integer
        Private _Valor As Integer
        Private _Iva As Integer
        Private _Descuento As Integer
        Private _Estado As String
        Private _IdOrdenServicio As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdProducto As Integer
            Get
                Return _IdProducto
            End Get
            Set(value As Integer)
                _IdProducto = value
            End Set
        End Property

        Public Property Cantidad As Integer
            Get
                Return _Cantidad
            End Get
            Set(value As Integer)
                _Cantidad = value
            End Set
        End Property

        Public Property Valor As Integer
            Get
                Return _Valor
            End Get
            Set(value As Integer)
                _Valor = value
            End Set
        End Property

        Public Property Iva As Integer
            Get
                Return _Iva
            End Get
            Set(value As Integer)
                _Iva = value
            End Set
        End Property

        Public Property Descuento As Integer
            Get
                Return _Descuento
            End Get
            Set(value As Integer)
                _Descuento = value
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

        Public Property IdOrdenServicio As String
            Get
                Return _IdOrdenServicio
            End Get
            Set(value As String)
                _IdOrdenServicio = value
            End Set
        End Property
    End Class
End Namespace


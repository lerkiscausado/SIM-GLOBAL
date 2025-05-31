Namespace Modelo
    Public Class DetalleCotizacion
        Private _id As Integer
        Private _idProducto As Integer
        Private _cantidad As Integer
        Private _valor As Integer
        Private _iva As Integer
        Private _descuento As Integer
        Private _estado As String
        Private _idCotizacion As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property IdProducto As Integer
            Get
                Return _idProducto
            End Get
            Set(value As Integer)
                _idProducto = value
            End Set
        End Property

        Public Property Cantidad As Integer
            Get
                Return _cantidad
            End Get
            Set(value As Integer)
                _cantidad = value
            End Set
        End Property

        Public Property Valor As Integer
            Get
                Return _valor
            End Get
            Set(value As Integer)
                _valor = value
            End Set
        End Property

        Public Property Iva As Integer
            Get
                Return _iva
            End Get
            Set(value As Integer)
                _iva = value
            End Set
        End Property

        Public Property Descuento As Integer
            Get
                Return _descuento
            End Get
            Set(value As Integer)
                _descuento = value
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

        Public Property IdCotizacion As String
            Get
                Return _idCotizacion
            End Get
            Set(value As String)
                _idCotizacion = value
            End Set
        End Property
    End Class
End Namespace

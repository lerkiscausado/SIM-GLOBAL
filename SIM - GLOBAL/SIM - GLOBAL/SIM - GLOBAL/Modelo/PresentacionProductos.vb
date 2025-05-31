Namespace Modelo
    Public Class PresentacionProductos
        Private _Id As Integer
        Private _IdProducto As String
        Private _IdMarca As String
        Private _Presentacion As String
        Private _IdUnidadMedida As String
        Private _Cantidad As Double
        Private _CodigoBarra As String
        Private _FotoProducto As Byte()
        Private _Estado As String
        Private _Foto As Byte()
        Private _Inventario As String
        Private _Licencia As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdProducto As String
            Get
                Return _IdProducto
            End Get
            Set(value As String)
                _IdProducto = value
            End Set
        End Property

        Public Property IdMarca As String
            Get
                Return _IdMarca
            End Get
            Set(value As String)
                _IdMarca = value
            End Set
        End Property

        Public Property Presentacion As String
            Get
                Return _Presentacion
            End Get
            Set(value As String)
                _Presentacion = value
            End Set
        End Property

        Public Property IdUnidadMedida As String
            Get
                Return _IdUnidadMedida
            End Get
            Set(value As String)
                _IdUnidadMedida = value
            End Set
        End Property

        Public Property Cantidad As Double
            Get
                Return _Cantidad
            End Get
            Set(value As Double)
                _Cantidad = value
            End Set
        End Property

        Public Property CodigoBarra As String
            Get
                Return _CodigoBarra
            End Get
            Set(value As String)
                _CodigoBarra = value
            End Set
        End Property

        Public Property FotoProducto As Byte()
            Get
                Return _FotoProducto
            End Get
            Set(value As Byte())
                _FotoProducto = value
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

        Public Property Foto As Byte()
            Get
                Return _Foto
            End Get
            Set(value As Byte())
                _Foto = value
            End Set
        End Property

        Public Property Inventario As String
            Get
                Return _Inventario
            End Get
            Set(value As String)
                _Inventario = value
            End Set
        End Property

        Public Property Licencia As String
            Get
                Return _Licencia
            End Get
            Set(value As String)
                _Licencia = value
            End Set
        End Property
    End Class
End Namespace


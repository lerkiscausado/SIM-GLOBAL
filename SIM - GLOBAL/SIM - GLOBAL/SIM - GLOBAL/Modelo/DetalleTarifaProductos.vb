Namespace Modelo
    Public Class DetalleTarifaProductos
        Private _Id As String
        Private _IdTarifaProducto As String
        Private _IdProducto As String
        Private _Valor As Integer
        Private _Iva As Integer
        Private _Estado As String

        Public Property Id As String
            Get
                Return _Id
            End Get
            Set(value As String)
                _Id = value
            End Set
        End Property

        Public Property IdTarifaProducto As String
            Get
                Return _IdTarifaProducto
            End Get
            Set(value As String)
                _IdTarifaProducto = value
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


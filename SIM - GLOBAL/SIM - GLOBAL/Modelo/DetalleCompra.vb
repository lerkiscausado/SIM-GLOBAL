Namespace Modelo
    Public Class DetalleCompra
        Private _Id As Integer
        Private _IdCompra As String
        Private _IdProducto As Integer
        Private _Cantidad As Double
        Private _ValorUnitario As Double
        Private _Estado As String

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

        Public Property ValorUnitario As Double
            Get
                Return _ValorUnitario
            End Get
            Set(value As Double)
                _ValorUnitario = value
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

        Public Property IdCompra As String
            Get
                Return _IdCompra
            End Get
            Set(value As String)
                _IdCompra = value
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
    End Class

End Namespace

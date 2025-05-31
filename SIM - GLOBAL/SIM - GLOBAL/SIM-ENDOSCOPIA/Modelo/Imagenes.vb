Namespace Modelo
    Public Class Imagenes
        Private _Id As String
        Private _IdOrden As String
        Private _IdDetalleOrden As String
        Private _Ruta As String
        Private _Texto As String
        Private _Estado As String
        Private _Imagen As Image

        Public Property Id As String
            Get
                Return _Id
            End Get
            Set(value As String)
                _Id = value
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

        Public Property Ruta As String
            Get
                Return _Ruta
            End Get
            Set(value As String)
                _Ruta = value
            End Set
        End Property

        Public Property Texto As String
            Get
                Return _Texto
            End Get
            Set(value As String)
                _Texto = value
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

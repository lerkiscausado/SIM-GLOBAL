Namespace Modelo
    Public Class Adjuntos
        Private _ID As Integer
        Private _IdOrden As Integer
        Private _Ruta As String
        Private _Nombre As String
        Private _Estado As String

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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
        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
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

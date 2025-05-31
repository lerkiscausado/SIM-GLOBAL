Namespace Modelo
    Public Class DetalleSalon
        Private _Id As Integer
        Private _IdSalon As String
        Private _Descripcion As String
        Private _Foto As Byte()
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdSalon As String
            Get
                Return _IdSalon
            End Get
            Set(value As String)
                _IdSalon = value
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
    End Class

End Namespace

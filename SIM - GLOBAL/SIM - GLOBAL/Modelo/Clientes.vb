Namespace Modelo
    Public Class Clientes
        Private _Id As Integer
        Private _IdTipoIdentificacion As String
        Private _Identificacion As String
        Private _Nombre As String
        Private _Direccion As String
        Private _Telefono As String
        Private _CorreoElectronico As String
        Private _Contacto As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdTipoIdentificacion As String
            Get
                Return _IdTipoIdentificacion
            End Get
            Set(value As String)
                _IdTipoIdentificacion = value
            End Set
        End Property

        Public Property Identificacion As String
            Get
                Return _Identificacion
            End Get
            Set(value As String)
                _Identificacion = value
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

        Public Property Direccion As String
            Get
                Return _Direccion
            End Get
            Set(value As String)
                _Direccion = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(value As String)
                _Telefono = value
            End Set
        End Property

        Public Property CorreoElectronico As String
            Get
                Return _CorreoElectronico
            End Get
            Set(value As String)
                _CorreoElectronico = value
            End Set
        End Property

        Public Property Contacto As String
            Get
                Return _Contacto
            End Get
            Set(value As String)
                _Contacto = value
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


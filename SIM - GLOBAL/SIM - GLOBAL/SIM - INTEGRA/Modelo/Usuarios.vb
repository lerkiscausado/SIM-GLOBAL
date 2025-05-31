Namespace Modelo
    Public Class Usuarios
        Private _ID As Integer
        Private _IdTipoIdentificacion As String
        Private _Identificacion As String
        Private _primerNombre As String
        Private _segundoNombre As String
        Private _primerApellido As String
        Private _segundoApellido As String
        Private _sexo As String
        Private _fechaNacimiento As Date
        Private _ciudadNacimiento As String
        Private _paisNacimiento As String
        Private _direccion As String
        Private _telefono As String
        Private _correoElectronico As String
        Private _estadoCivil As String
        Private _Ocupacion As String
        Private _responsable As String
        Private _parentescoR As String
        Private _telefonoR As String
        Private _acompanante As String
        Private _parentescoA As String
        Private _telefonoA As String
        Private _AntecedentesFamiliares As String
        Private _AntecedentesPersonales As String
        Private _zona As String
        Private _codigoMunicipio As String
        Private _codigoTipoUsuario As Integer
        Private _carnet As String

        Public Property ID As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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

        Public Property PrimerNombre As String
            Get
                Return _primerNombre
            End Get
            Set(value As String)
                _primerNombre = value
            End Set
        End Property

        Public Property SegundoNombre As String
            Get
                Return _segundoNombre
            End Get
            Set(value As String)
                _segundoNombre = value
            End Set
        End Property

        Public Property PrimerApellido As String
            Get
                Return _primerApellido
            End Get
            Set(value As String)
                _primerApellido = value
            End Set
        End Property

        Public Property SegundoApellido As String
            Get
                Return _segundoApellido
            End Get
            Set(value As String)
                _segundoApellido = value
            End Set
        End Property

        Public Property Sexo As String
            Get
                Return _sexo
            End Get
            Set(value As String)
                _sexo = value
            End Set
        End Property

        Public Property FechaNacimiento As Date
            Get
                Return _fechaNacimiento
            End Get
            Set(value As Date)
                _fechaNacimiento = value
            End Set
        End Property

        Public Property CiudadNacimiento As String
            Get
                Return _ciudadNacimiento
            End Get
            Set(value As String)
                _ciudadNacimiento = value
            End Set
        End Property

        Public Property PaisNacimiento As String
            Get
                Return _paisNacimiento
            End Get
            Set(value As String)
                _paisNacimiento = value
            End Set
        End Property

        Public Property Direccion As String
            Get
                Return _direccion
            End Get
            Set(value As String)
                _direccion = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _telefono
            End Get
            Set(value As String)
                _telefono = value
            End Set
        End Property

        Public Property CorreoElectronico As String
            Get
                Return _correoElectronico
            End Get
            Set(value As String)
                _correoElectronico = value
            End Set
        End Property

        Public Property EstadoCivil As String
            Get
                Return _estadoCivil
            End Get
            Set(value As String)
                _estadoCivil = value
            End Set
        End Property

        Public Property Zona As String
            Get
                Return _zona
            End Get
            Set(value As String)
                _zona = value
            End Set
        End Property

        Public Property CodigoMunicipio As String
            Get
                Return _codigoMunicipio
            End Get
            Set(value As String)
                _codigoMunicipio = value
            End Set
        End Property

        Public Property CodigoTipoUsuario As Integer
            Get
                Return _codigoTipoUsuario
            End Get
            Set(value As Integer)
                _codigoTipoUsuario = value
            End Set
        End Property

        Public Property Carnet As String
            Get
                Return _carnet
            End Get
            Set(value As String)
                _carnet = value
            End Set
        End Property

        Public Property Responsable As String
            Get
                Return _responsable
            End Get
            Set(value As String)
                _responsable = value
            End Set
        End Property

        Public Property ParentescoR As String
            Get
                Return _parentescoR
            End Get
            Set(value As String)
                _parentescoR = value
            End Set
        End Property

        Public Property TelefonoR As String
            Get
                Return _telefonoR
            End Get
            Set(value As String)
                _telefonoR = value
            End Set
        End Property

        Public Property Acompanante As String
            Get
                Return _acompanante
            End Get
            Set(value As String)
                _acompanante = value
            End Set
        End Property

        Public Property ParentescoA As String
            Get
                Return _parentescoA
            End Get
            Set(value As String)
                _parentescoA = value
            End Set
        End Property

        Public Property TelefonoA As String
            Get
                Return _telefonoA
            End Get
            Set(value As String)
                _telefonoA = value
            End Set
        End Property

        Public Property AntecedentesFamiliares As String
            Get
                Return _AntecedentesFamiliares
            End Get
            Set(value As String)
                _AntecedentesFamiliares = value
            End Set
        End Property

        Public Property AntecedentesPersonales As String
            Get
                Return _AntecedentesPersonales
            End Get
            Set(value As String)
                _AntecedentesPersonales = value
            End Set
        End Property

        Public Property Ocupacion As String
            Get
                Return _Ocupacion
            End Get
            Set(value As String)
                _Ocupacion = value
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
    End Class
End Namespace

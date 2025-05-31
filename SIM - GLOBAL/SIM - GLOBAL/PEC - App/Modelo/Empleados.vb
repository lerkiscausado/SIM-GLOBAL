Namespace Modelo
    Public Class Empleados
        Private _Id As Integer
        Private _NombreEmpleado As String
        Private _IdCargo As Integer
        Private _IdEspecialidad As Integer
        Private _RegistroMedico As String
        Private _Estado As String
        Private _IdTipoIdentificacion As String
        Private _Identificacion As String
        Private _Direccion As String
        Private _Telefono As String
        Private _CorreoElectronico As String
        Private _Firma As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property NombreEmpleado As String
            Get
                Return _NombreEmpleado
            End Get
            Set(value As String)
                _NombreEmpleado = value
            End Set
        End Property

        Public Property IdCargo As Integer
            Get
                Return _IdCargo
            End Get
            Set(value As Integer)
                _IdCargo = value
            End Set
        End Property

        Public Property IdEspecialidad As Integer
            Get
                Return _IdEspecialidad
            End Get
            Set(value As Integer)
                _IdEspecialidad = value
            End Set
        End Property

        Public Property RegistroMedico As String
            Get
                Return _RegistroMedico
            End Get
            Set(value As String)
                _RegistroMedico = value
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

        Public Property Firma As String
            Get
                Return _Firma
            End Get
            Set(value As String)
                _Firma = value
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


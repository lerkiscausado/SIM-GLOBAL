Namespace Modelo
    Public Class Especialista
        Private _id As Integer
        Private _idEspecialista As Integer
        Private _nombre As String
        Private _idTipoIdentificacion As String
        Private _identificacion As String
        Private _especialidad As String
        Private _registroMedico As String
        Private _estado As String
        Private _firma As Image

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property IdEspecialista As Integer
            Get
                Return _idEspecialista
            End Get
            Set(value As Integer)
                _idEspecialista = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        ' Nombre estructurado para PractitionerRDA (RETHUS exige coincidencia con nombre/apellidos
        ' por separado, no un solo campo de texto libre). Ver Sql/rda_estructuracion_datos_migracion.sql
        Public Property PrimerNombre As String
        Public Property SegundoNombre As String
        Public Property PrimerApellido As String
        Public Property SegundoApellido As String

        Public Property Especialidad As String
            Get
                Return _especialidad
            End Get
            Set(value As String)
                _especialidad = value
            End Set
        End Property

        Public Property RegistroMedico As String
            Get
                Return _registroMedico
            End Get
            Set(value As String)
                _registroMedico = value
            End Set
        End Property

        Public Property Firma As Image
            Get
                Return _firma
            End Get
            Set(value As Image)
                _firma = value
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

        Public Property Identificacion As String
            Get
                Return _identificacion
            End Get
            Set(value As String)
                _identificacion = value
            End Set
        End Property

        Public Property IdTipoIdentificacion As String
            Get
                Return _idTipoIdentificacion
            End Get
            Set(value As String)
                _idTipoIdentificacion = value
            End Set
        End Property
    End Class
End Namespace


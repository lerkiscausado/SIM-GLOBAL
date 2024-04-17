Namespace Modelo
    Public Class Empleados
        Private _id As Integer
        Private _nombreEmpleado As String
        Private _IdCargo As Integer
        Private _idEspecialidad As Integer
        Private _registroMedico As String
        Private _Estado As String
        Private _Firma As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property NombreEmpleado As String
            Get
                Return _nombreEmpleado
            End Get
            Set(value As String)
                _nombreEmpleado = value
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
                Return _idEspecialidad
            End Get
            Set(value As Integer)
                _idEspecialidad = value
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

        Public Property RegistroMedico As String
            Get
                Return _registroMedico
            End Get
            Set(value As String)
                _registroMedico = value
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
    End Class
End Namespace



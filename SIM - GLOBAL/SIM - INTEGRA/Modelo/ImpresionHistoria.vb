Namespace Modelo
    Public Class ImpresionHistoria
        Private _id As Integer
        Private _idOrden As Integer
        Private _Fecha As Date
        Private _ReporteEvolucion As String
        Private _Especialista As String
        Private _RegistroMedico As String
        Private _NombreEspecialidad As String
        Private _Firma As Image

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property IdOrden As Integer
            Get
                Return _idOrden
            End Get
            Set(value As Integer)
                _idOrden = value
            End Set
        End Property

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property

        Public Property ReporteEvolucion As String
            Get
                Return _ReporteEvolucion
            End Get
            Set(value As String)
                _ReporteEvolucion = value
            End Set
        End Property

        Public Property Especialista As String
            Get
                Return _Especialista
            End Get
            Set(value As String)
                _Especialista = value
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

        Public Property NombreEspecialidad As String
            Get
                Return _NombreEspecialidad
            End Get
            Set(value As String)
                _NombreEspecialidad = value
            End Set
        End Property

        Public Property Firma As Image
            Get
                Return _Firma
            End Get
            Set(value As Image)
                _Firma = value
            End Set
        End Property
    End Class

End Namespace

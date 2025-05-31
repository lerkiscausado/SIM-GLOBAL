Namespace Modelo
    Public Class HistoriaIntegra
        Private _id As Integer
        Private _idOrden As Integer
        Private _idDetalleOrden As Integer
        Private _CodigoHistoria As String
        Private _Fecha As Date
        Private _Hora As Date
        Private _MotivoConsulta As String
        Private _AntecedentesPersonales As String
        Private _AntecedentesFamiliares As String
        Private _Valoracion As String
        Private _PlanSeguir As String
        Private _ReporteEvolucion As String
        Private _Remision As String
        Private _CodigoDiagnostico As String
        Private _Cita As String
        Private _IdEspecialidad As Integer
        Private _IdEmpleado As Integer
        Private _Estado As String

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

        Public Property CodigoHistoria As String
            Get
                Return _CodigoHistoria
            End Get
            Set(value As String)
                _CodigoHistoria = value
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

        Public Property Hora As Date
            Get
                Return _Hora
            End Get
            Set(value As Date)
                _Hora = value
            End Set
        End Property

        Public Property CodigoDiagnostico As String
            Get
                Return _CodigoDiagnostico
            End Get
            Set(value As String)
                _CodigoDiagnostico = value
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

        Public Property IdEmpleado As Integer
            Get
                Return _IdEmpleado
            End Get
            Set(value As Integer)
                _IdEmpleado = value
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

        Public Property MotivoConsulta As String
            Get
                Return _MotivoConsulta
            End Get
            Set(value As String)
                _MotivoConsulta = value
            End Set
        End Property

        Public Property Cita As String
            Get
                Return _Cita
            End Get
            Set(value As String)
                _Cita = value
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

        Public Property IdDetalleOrden As Integer
            Get
                Return _idDetalleOrden
            End Get
            Set(value As Integer)
                _idDetalleOrden = value
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

        Public Property AntecedentesFamiliares As String
            Get
                Return _AntecedentesFamiliares
            End Get
            Set(value As String)
                _AntecedentesFamiliares = value
            End Set
        End Property

        Public Property Valoracion As String
            Get
                Return _Valoracion
            End Get
            Set(value As String)
                _Valoracion = value
            End Set
        End Property

        Public Property PlanSeguir As String
            Get
                Return _PlanSeguir
            End Get
            Set(value As String)
                _PlanSeguir = value
            End Set
        End Property

        Public Property Remision As String
            Get
                Return _Remision
            End Get
            Set(value As String)
                _Remision = value
            End Set
        End Property
    End Class
End Namespace

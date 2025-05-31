Namespace Modelo
    Public Class ImpresionHistoria
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _NumeroHistoria As String
        Private _Nombre As String
        Private _Identificacion As String
        Private _Edad As Date
        Private _Sexo As String
        Private _EstadoCivil As String
        Private _Telefono As String
        Private _Direccion As String
        Private _Entidad As String
        Private _FechaIngreso As Date
        Private _FechaAtencion As Date
        Private _MotivoConsulta As String
        Private _Responsables As String
        Private _ConsultaControl As String
        Private _AntecedentesFamiliares As String
        Private _AntecedentesPersonales As String
        Private _EnfermedadActual As String
        Private _RevisionxSistemas As String
        Private _ExamenFisico As String
        Private _Peso As String
        Private _Talla As String
        Private _TensionArterial As String
        Private _FrecuenciaCardiaca As String
        Private _FrecuenciaRespiratoria As String
        Private _PlanSeguir As String
        Private _Formulacion As String
        Private _Laboratorios As String
        Private _OtrosEstudios As String
        Private _Diagnostico As String
        Private _TannerA As String
        Private _TannerB As String
        Private _TannerP As String
        Private _TannerVT As String
        Private _TannerLP As String
        Private _Recomendaciones As String
        Private _Temperatura As String
        Private _Firma As Image
        Private _Medico As String
        Private _Especialidad As String
        Private _RegistroMedico As String
        Private _IdEmpleado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property IdDetalleOrden As Integer
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As Integer)
                _IdDetalleOrden = value
            End Set
        End Property

        Public Property NumeroHistoria As String
            Get
                Return _NumeroHistoria
            End Get
            Set(value As String)
                _NumeroHistoria = value
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

        Public Property Identificacion As String
            Get
                Return _Identificacion
            End Get
            Set(value As String)
                _Identificacion = value
            End Set
        End Property



        Public Property Sexo As String
            Get
                Return _Sexo
            End Get
            Set(value As String)
                _Sexo = value
            End Set
        End Property

        Public Property EstadoCivil As String
            Get
                Return _EstadoCivil
            End Get
            Set(value As String)
                _EstadoCivil = value
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

        Public Property Direccion As String
            Get
                Return _Direccion
            End Get
            Set(value As String)
                _Direccion = value
            End Set
        End Property

        Public Property Entidad As String
            Get
                Return _Entidad
            End Get
            Set(value As String)
                _Entidad = value
            End Set
        End Property

        Public Property FechaIngreso As Date
            Get
                Return _FechaIngreso
            End Get
            Set(value As Date)
                _FechaIngreso = value
            End Set
        End Property

        Public Property FechaAtencion As Date
            Get
                Return _FechaAtencion
            End Get
            Set(value As Date)
                _FechaAtencion = value
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

        Public Property EnfermedadActual As String
            Get
                Return _EnfermedadActual
            End Get
            Set(value As String)
                _EnfermedadActual = value
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

        Public Property Diagnostico As String
            Get
                Return _Diagnostico
            End Get
            Set(value As String)
                _Diagnostico = value
            End Set
        End Property

        Public Property Recomendaciones As String
            Get
                Return _Recomendaciones
            End Get
            Set(value As String)
                _Recomendaciones = value
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

        Public Property Medico As String
            Get
                Return _Medico
            End Get
            Set(value As String)
                _Medico = value
            End Set
        End Property

        Public Property Especialidad As String
            Get
                Return _Especialidad
            End Get
            Set(value As String)
                _Especialidad = value
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

        Public Property IdEmpleado As String
            Get
                Return _IdEmpleado
            End Get
            Set(value As String)
                _IdEmpleado = value
            End Set
        End Property

        Public Property Edad As Date
            Get
                Return _Edad
            End Get
            Set(value As Date)
                _Edad = value
            End Set
        End Property

        Public Property ConsultaControl As String
            Get
                Return _ConsultaControl
            End Get
            Set(value As String)
                _ConsultaControl = value
            End Set
        End Property

        Public Property ExamenFisico As String
            Get
                Return _ExamenFisico
            End Get
            Set(value As String)
                _ExamenFisico = value
            End Set
        End Property

        Public Property Peso As String
            Get
                Return _Peso
            End Get
            Set(value As String)
                _Peso = value
            End Set
        End Property

        Public Property Talla As String
            Get
                Return _Talla
            End Get
            Set(value As String)
                _Talla = value
            End Set
        End Property

        Public Property TensionArterial As String
            Get
                Return _TensionArterial
            End Get
            Set(value As String)
                _TensionArterial = value
            End Set
        End Property

        Public Property FrecuenciaCardiaca As String
            Get
                Return _FrecuenciaCardiaca
            End Get
            Set(value As String)
                _FrecuenciaCardiaca = value
            End Set
        End Property

        Public Property FrecuenciaRespiratoria As String
            Get
                Return _FrecuenciaRespiratoria
            End Get
            Set(value As String)
                _FrecuenciaRespiratoria = value
            End Set
        End Property

        Public Property TannerA As String
            Get
                Return _TannerA
            End Get
            Set(value As String)
                _TannerA = value
            End Set
        End Property

        Public Property TannerB As String
            Get
                Return _TannerB
            End Get
            Set(value As String)
                _TannerB = value
            End Set
        End Property

        Public Property TannerP As String
            Get
                Return _TannerP
            End Get
            Set(value As String)
                _TannerP = value
            End Set
        End Property

        Public Property TannerVT As String
            Get
                Return _TannerVT
            End Get
            Set(value As String)
                _TannerVT = value
            End Set
        End Property

        Public Property TannerLP As String
            Get
                Return _TannerLP
            End Get
            Set(value As String)
                _TannerLP = value
            End Set
        End Property

        Public Property Temperatura As String
            Get
                Return _Temperatura
            End Get
            Set(value As String)
                _Temperatura = value
            End Set
        End Property

        Public Property Formulacion As String
            Get
                Return _Formulacion
            End Get
            Set(value As String)
                _Formulacion = value
            End Set
        End Property

        Public Property Laboratorios As String
            Get
                Return _Laboratorios
            End Get
            Set(value As String)
                _Laboratorios = value
            End Set
        End Property

        Public Property OtrosEstudios As String
            Get
                Return _OtrosEstudios
            End Get
            Set(value As String)
                _OtrosEstudios = value
            End Set
        End Property

        Public Property Responsables As String
            Get
                Return _Responsables
            End Get
            Set(value As String)
                _Responsables = value
            End Set
        End Property

        Public Property RevisionxSistemas As String
            Get
                Return _RevisionxSistemas
            End Get
            Set(value As String)
                _RevisionxSistemas = value
            End Set
        End Property
    End Class
End Namespace

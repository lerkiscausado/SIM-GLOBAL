Namespace Modelo
    Public Class Users
        Private _Id As Integer
        Private _IdEmpleado As Integer
        Private _Usuario As String
        Private _Pass As String
        Private _Nuevo As String
        Private _Editar As String
        Private _Anular As String
        Private _Consultar As String
        Private _Adjuntos As String
        Private _Agenda As String
        Private _HistoriaClinica As String
        Private _HistoriaAnteriores As String
        Private _HistoriaGrupal As String
        Private _EvolucionPaciente As String
        Private _ProgramacionCirugia As String
        Private _Citologia As String
        Private _Patologia As String
        Private _Endoscopia As String
        Private _AdjuntarImagenes As String
        Private _ListadoOrdenes As String
        Private _GenerarFactura As String
        Private _Rips As String
        Private _Inventario As String
        Private _Nomina As String
        Private _VistaPrevia As String
        Private _Imprimir As String
        Private _IndicadoresGestion As String
        Private _Usuarios As String
        Private _Entidades As String
        Private _SubEntidades As String
        Private _Contratos As String
        Private _Tarifas As String
        Private _DetalleTarifas As String
        Private _Cargos As String
        Private _Especialidades As String
        Private _Empleados As String
        Private _Examenes As String
        Private _Medicamentos As String
        Private _Cups As String
        Private _Cie10 As String
        Private _TipoPatologia As String
        Private _EstudiosPredeterminados As String
        Private _EquiposApoyo As String
        Private _ProcedimientoTerapeutico As String
        Private _EncabezadoPiedepagina As String
        Private _Logo As String
        Private _Firma As String
        Private _Users As String
        Private _Seguridad As String
        Private _Privilegios As String
        Private _AyudaProducto As String
        Private _SoporteTecnico As String
        Private _Tutoriales As String
        Private _Acercade As String
        Private _Estado As String
        Private _IdLicencia As String
        Private _Admin As String
#Region "Ordenes de Atencion"
        Public Class OrdenesAtencion
            Private _nuevo As String
            Private _editar As String
            Private _anular As String
            Private _consultar As String
            Private _adjuntos As String
            Private _agenda As String

            Public Property Nuevo As String
                Get
                    Return _nuevo
                End Get
                Set(value As String)
                    _nuevo = value
                End Set
            End Property

            Public Property Editar As String
                Get
                    Return _editar
                End Get
                Set(value As String)
                    _editar = value
                End Set
            End Property

            Public Property Anular As String
                Get
                    Return _anular
                End Get
                Set(value As String)
                    _anular = value
                End Set
            End Property

            Public Property Consultar As String
                Get
                    Return _consultar
                End Get
                Set(value As String)
                    _consultar = value
                End Set
            End Property

            Public Property Adjuntos As String
                Get
                    Return _adjuntos
                End Get
                Set(value As String)
                    _adjuntos = value
                End Set
            End Property

            Public Property Agenda As String
                Get
                    Return _agenda
                End Get
                Set(value As String)
                    _agenda = value
                End Set
            End Property
        End Class
#End Region
        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property Usuario As String
            Get
                Return _Usuario
            End Get
            Set(value As String)
                _Usuario = value
            End Set
        End Property

        Public Property Pass As String
            Get
                Return _Pass
            End Get
            Set(value As String)
                _Pass = value
            End Set
        End Property

        Public Property Nuevo As String
            Get
                Return _Nuevo
            End Get
            Set(value As String)
                _Nuevo = value
            End Set
        End Property

        Public Property Editar As String
            Get
                Return _Editar
            End Get
            Set(value As String)
                _Editar = value
            End Set
        End Property

        Public Property Anular As String
            Get
                Return _Anular
            End Get
            Set(value As String)
                _Anular = value
            End Set
        End Property

        Public Property Consultar As String
            Get
                Return _Consultar
            End Get
            Set(value As String)
                _Consultar = value
            End Set
        End Property

        Public Property Adjuntos As String
            Get
                Return _Adjuntos
            End Get
            Set(value As String)
                _Adjuntos = value
            End Set
        End Property

        Public Property Agenda As String
            Get
                Return _Agenda
            End Get
            Set(value As String)
                _Agenda = value
            End Set
        End Property

        Public Property HistoriaClinica As String
            Get
                Return _HistoriaClinica
            End Get
            Set(value As String)
                _HistoriaClinica = value
            End Set
        End Property

        Public Property HistoriaAnteriores As String
            Get
                Return _HistoriaAnteriores
            End Get
            Set(value As String)
                _HistoriaAnteriores = value
            End Set
        End Property

        Public Property HistoriaGrupal As String
            Get
                Return _HistoriaGrupal
            End Get
            Set(value As String)
                _HistoriaGrupal = value
            End Set
        End Property

        Public Property EvolucionPaciente As String
            Get
                Return _EvolucionPaciente
            End Get
            Set(value As String)
                _EvolucionPaciente = value
            End Set
        End Property

        Public Property ProgramacionCirugia As String
            Get
                Return _ProgramacionCirugia
            End Get
            Set(value As String)
                _ProgramacionCirugia = value
            End Set
        End Property

        Public Property Citologia As String
            Get
                Return _Citologia
            End Get
            Set(value As String)
                _Citologia = value
            End Set
        End Property

        Public Property Patologia As String
            Get
                Return _Patologia
            End Get
            Set(value As String)
                _Patologia = value
            End Set
        End Property

        Public Property AdjuntarImagenes As String
            Get
                Return _AdjuntarImagenes
            End Get
            Set(value As String)
                _AdjuntarImagenes = value
            End Set
        End Property

        Public Property ListadoOrdenes As String
            Get
                Return _ListadoOrdenes
            End Get
            Set(value As String)
                _ListadoOrdenes = value
            End Set
        End Property

        Public Property GenerarFactura As String
            Get
                Return _GenerarFactura
            End Get
            Set(value As String)
                _GenerarFactura = value
            End Set
        End Property

        Public Property Rips As String
            Get
                Return _Rips
            End Get
            Set(value As String)
                _Rips = value
            End Set
        End Property

        Public Property Inventario As String
            Get
                Return _Inventario
            End Get
            Set(value As String)
                _Inventario = value
            End Set
        End Property

        Public Property Nomina As String
            Get
                Return _Nomina
            End Get
            Set(value As String)
                _Nomina = value
            End Set
        End Property

        Public Property VistaPrevia As String
            Get
                Return _VistaPrevia
            End Get
            Set(value As String)
                _VistaPrevia = value
            End Set
        End Property

        Public Property Imprimir As String
            Get
                Return _Imprimir
            End Get
            Set(value As String)
                _Imprimir = value
            End Set
        End Property

        Public Property IndicadoresGestion As String
            Get
                Return _IndicadoresGestion
            End Get
            Set(value As String)
                _IndicadoresGestion = value
            End Set
        End Property

        Public Property Usuarios As String
            Get
                Return _Usuarios
            End Get
            Set(value As String)
                _Usuarios = value
            End Set
        End Property

        Public Property Entidades As String
            Get
                Return _Entidades
            End Get
            Set(value As String)
                _Entidades = value
            End Set
        End Property

        Public Property Contratos As String
            Get
                Return _Contratos
            End Get
            Set(value As String)
                _Contratos = value
            End Set
        End Property

        Public Property Tarifas As String
            Get
                Return _Tarifas
            End Get
            Set(value As String)
                _Tarifas = value
            End Set
        End Property

        Public Property DetalleTarifas As String
            Get
                Return _DetalleTarifas
            End Get
            Set(value As String)
                _DetalleTarifas = value
            End Set
        End Property

        Public Property Cargos As String
            Get
                Return _Cargos
            End Get
            Set(value As String)
                _Cargos = value
            End Set
        End Property

        Public Property Especialidades As String
            Get
                Return _Especialidades
            End Get
            Set(value As String)
                _Especialidades = value
            End Set
        End Property

        Public Property Empleados As String
            Get
                Return _Empleados
            End Get
            Set(value As String)
                _Empleados = value
            End Set
        End Property

        Public Property Examenes As String
            Get
                Return _Examenes
            End Get
            Set(value As String)
                _Examenes = value
            End Set
        End Property

        Public Property Medicamentos As String
            Get
                Return _Medicamentos
            End Get
            Set(value As String)
                _Medicamentos = value
            End Set
        End Property

        Public Property Cups As String
            Get
                Return _Cups
            End Get
            Set(value As String)
                _Cups = value
            End Set
        End Property

        Public Property Cie10 As String
            Get
                Return _Cie10
            End Get
            Set(value As String)
                _Cie10 = value
            End Set
        End Property

        Public Property TipoPatologia As String
            Get
                Return _TipoPatologia
            End Get
            Set(value As String)
                _TipoPatologia = value
            End Set
        End Property

        Public Property EstudiosPredeterminados As String
            Get
                Return _EstudiosPredeterminados
            End Get
            Set(value As String)
                _EstudiosPredeterminados = value
            End Set
        End Property

        Public Property EncabezadoPiedepagina As String
            Get
                Return _EncabezadoPiedepagina
            End Get
            Set(value As String)
                _EncabezadoPiedepagina = value
            End Set
        End Property

        Public Property Logo As String
            Get
                Return _Logo
            End Get
            Set(value As String)
                _Logo = value
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

        Public Property Users As String
            Get
                Return _Users
            End Get
            Set(value As String)
                _Users = value
            End Set
        End Property

        Public Property Seguridad As String
            Get
                Return _Seguridad
            End Get
            Set(value As String)
                _Seguridad = value
            End Set
        End Property

        Public Property Privilegios As String
            Get
                Return _Privilegios
            End Get
            Set(value As String)
                _Privilegios = value
            End Set
        End Property

        Public Property AyudaProducto As String
            Get
                Return _AyudaProducto
            End Get
            Set(value As String)
                _AyudaProducto = value
            End Set
        End Property

        Public Property SoporteTecnico As String
            Get
                Return _SoporteTecnico
            End Get
            Set(value As String)
                _SoporteTecnico = value
            End Set
        End Property

        Public Property Tutoriales As String
            Get
                Return _Tutoriales
            End Get
            Set(value As String)
                _Tutoriales = value
            End Set
        End Property

        Public Property Acercade As String
            Get
                Return _Acercade
            End Get
            Set(value As String)
                _Acercade = value
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

        Public Property Endoscopia As String
            Get
                Return _Endoscopia
            End Get
            Set(value As String)
                _Endoscopia = value
            End Set
        End Property

        Public Property EquiposApoyo As String
            Get
                Return _EquiposApoyo
            End Get
            Set(value As String)
                _EquiposApoyo = value
            End Set
        End Property

        Public Property SubEntidades As String
            Get
                Return _SubEntidades
            End Get
            Set(value As String)
                _SubEntidades = value
            End Set
        End Property

        Public Property ProcedimientoTerapeutico As String
            Get
                Return _ProcedimientoTerapeutico
            End Get
            Set(value As String)
                _ProcedimientoTerapeutico = value
            End Set
        End Property

        Public Property IdLicencia As String
            Get
                Return _IdLicencia
            End Get
            Set(value As String)
                _IdLicencia = value
            End Set
        End Property

        Public Property Admin As String
            Get
                Return _Admin
            End Get
            Set(value As String)
                _Admin = value
            End Set
        End Property
    End Class
End Namespace

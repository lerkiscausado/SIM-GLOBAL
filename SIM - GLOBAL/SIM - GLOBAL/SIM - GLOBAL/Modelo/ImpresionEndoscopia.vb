Namespace Modelo
    Public Class ImpresionEndoscopia
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _Estudio As String
        Private _FechaIngreso As Date
        Private _Nombre As String
        Private _Identificacion As String
        Private _Edad As Date
        Private _Sexo As String
        Private _EstadoCivil As String
        Private _Telefono As String
        Private _Direccion As String
        Private _Entidad As String
        Private _MedicoSolicita As String
        Private _Indicacion As String
        Private _Medicamentos As String
        Private _Equipo As String
        Private _Anestesiologo As String
        Private _ProcedimientoTerapeutico As String
        Private _Campo1 As String
        Private _Campo2 As String
        Private _Campo3 As String
        Private _Campo4 As String
        Private _Campo5 As String
        Private _Campo6 As String
        Private _Diagnostico As String
        Private _Firma As Image
        Private _Medico As String
        Private _Especialidad As String
        Private _RegistroMedico As String
        Private _IdEmpleado As String
        Private _Imagen1 As Image
        Private _Imagen2 As Image
        Private _Imagen3 As Image
        Private _Imagen4 As Image
        Private _Imagen5 As Image
        Private _Imagen6 As Image
        Private _Imagen7 As Image
        Private _Imagen8 As Image
        Private _Imagen9 As Image
        Private _Texto1 As String
        Private _Texto2 As String
        Private _Texto3 As String
        Private _Texto4 As String
        Private _Texto5 As String
        Private _Texto6 As String
        Private _Texto7 As String
        Private _Texto8 As String
        Private _Texto9 As String
        Private _NumeroFotos As String
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

        Public Property Estudio As String
            Get
                Return _Estudio
            End Get
            Set(value As String)
                _Estudio = value
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

        Public Property Edad As Date
            Get
                Return _Edad
            End Get
            Set(value As Date)
                _Edad = value
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

        Public Property MedicoSolicita As String
            Get
                Return _MedicoSolicita
            End Get
            Set(value As String)
                _MedicoSolicita = value
            End Set
        End Property

        Public Property Indicacion As String
            Get
                Return _Indicacion
            End Get
            Set(value As String)
                _Indicacion = value
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

        Public Property Equipo As String
            Get
                Return _Equipo
            End Get
            Set(value As String)
                _Equipo = value
            End Set
        End Property

        Public Property Anestesiologo As String
            Get
                Return _Anestesiologo
            End Get
            Set(value As String)
                _Anestesiologo = value
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

        Public Property Campo1 As String
            Get
                Return _Campo1
            End Get
            Set(value As String)
                _Campo1 = value
            End Set
        End Property

        Public Property Campo2 As String
            Get
                Return _Campo2
            End Get
            Set(value As String)
                _Campo2 = value
            End Set
        End Property

        Public Property Campo3 As String
            Get
                Return _Campo3
            End Get
            Set(value As String)
                _Campo3 = value
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

        Public Property Imagen1 As Image
            Get
                Return _Imagen1
            End Get
            Set(value As Image)
                _Imagen1 = value
            End Set
        End Property

        Public Property Imagen2 As Image
            Get
                Return _Imagen2
            End Get
            Set(value As Image)
                _Imagen2 = value
            End Set
        End Property

        Public Property Imagen3 As Image
            Get
                Return _Imagen3
            End Get
            Set(value As Image)
                _Imagen3 = value
            End Set
        End Property

        Public Property Imagen4 As Image
            Get
                Return _Imagen4
            End Get
            Set(value As Image)
                _Imagen4 = value
            End Set
        End Property

        Public Property Imagen5 As Image
            Get
                Return _Imagen5
            End Get
            Set(value As Image)
                _Imagen5 = value
            End Set
        End Property

        Public Property Imagen6 As Image
            Get
                Return _Imagen6
            End Get
            Set(value As Image)
                _Imagen6 = value
            End Set
        End Property

        Public Property Imagen7 As Image
            Get
                Return _Imagen7
            End Get
            Set(value As Image)
                _Imagen7 = value
            End Set
        End Property

        Public Property Imagen8 As Image
            Get
                Return _Imagen8
            End Get
            Set(value As Image)
                _Imagen8 = value
            End Set
        End Property

        Public Property Campo4 As String
            Get
                Return _Campo4
            End Get
            Set(value As String)
                _Campo4 = value
            End Set
        End Property

        Public Property Campo5 As String
            Get
                Return _Campo5
            End Get
            Set(value As String)
                _Campo5 = value
            End Set
        End Property

        Public Property Campo6 As String
            Get
                Return _Campo6
            End Get
            Set(value As String)
                _Campo6 = value
            End Set
        End Property

        Public Property Texto1 As String
            Get
                Return _Texto1
            End Get
            Set(value As String)
                _Texto1 = value
            End Set
        End Property

        Public Property Texto2 As String
            Get
                Return _Texto2
            End Get
            Set(value As String)
                _Texto2 = value
            End Set
        End Property

        Public Property Texto3 As String
            Get
                Return _Texto3
            End Get
            Set(value As String)
                _Texto3 = value
            End Set
        End Property

        Public Property Texto4 As String
            Get
                Return _Texto4
            End Get
            Set(value As String)
                _Texto4 = value
            End Set
        End Property

        Public Property Texto5 As String
            Get
                Return _Texto5
            End Get
            Set(value As String)
                _Texto5 = value
            End Set
        End Property

        Public Property Texto6 As String
            Get
                Return _Texto6
            End Get
            Set(value As String)
                _Texto6 = value
            End Set
        End Property

        Public Property Texto7 As String
            Get
                Return _Texto7
            End Get
            Set(value As String)
                _Texto7 = value
            End Set
        End Property

        Public Property Texto8 As String
            Get
                Return _Texto8
            End Get
            Set(value As String)
                _Texto8 = value
            End Set
        End Property

        Public Property Imagen9 As Image
            Get
                Return _Imagen9
            End Get
            Set(value As Image)
                _Imagen9 = value
            End Set
        End Property

        Public Property Texto9 As String
            Get
                Return _Texto9
            End Get
            Set(value As String)
                _Texto9 = value
            End Set
        End Property

        Public Property NumeroFotos As String
            Get
                Return _NumeroFotos
            End Get
            Set(value As String)
                _NumeroFotos = value
            End Set
        End Property
    End Class
End Namespace


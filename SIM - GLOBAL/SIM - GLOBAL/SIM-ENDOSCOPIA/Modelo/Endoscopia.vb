Namespace Modelo
    Public Class Endoscopia
        Private _Id As String
        Private _IdOrden As String
        Private _IdDetalleOrden As String
        Private _FechaEstudio As Date
        Private _FechaSalida As Date
        Private _Hora As Date
        Private _MedicoSolicita As String
        Private _Indicacion As String
        Private _Medicamentos As String
        Private _IdEquipo As String
        Private _IdProcedimientoTerapeutico As String
        Private _Anestesiologo As String
        Private _Campo1 As String
        Private _Campo2 As String
        Private _Campo3 As String
        Private _Campo4 As String
        Private _Campo5 As String
        Private _Campo6 As String
        Private _TomaBiopsia As String
        Private _Biopsia As String
        Private _Diagnostico As String
        Private _IdEmpleado As String
        Private _CodigoDiagnostico As String
        Public Property Id As String
            Get
                Return _Id
            End Get
            Set(value As String)
                _Id = value
            End Set
        End Property

        Public Property IdOrden As String
            Get
                Return _IdOrden
            End Get
            Set(value As String)
                _IdOrden = value
            End Set
        End Property

        Public Property IdDetalleOrden As String
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As String)
                _IdDetalleOrden = value
            End Set
        End Property

        Public Property FechaEstudio As Date
            Get
                Return _FechaEstudio
            End Get
            Set(value As Date)
                _FechaEstudio = value
            End Set
        End Property

        Public Property FechaSalida As Date
            Get
                Return _FechaSalida
            End Get
            Set(value As Date)
                _FechaSalida = value
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

        Public Property IdEquipo As String
            Get
                Return _IdEquipo
            End Get
            Set(value As String)
                _IdEquipo = value
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

        Public Property IdEmpleado As String
            Get
                Return _IdEmpleado
            End Get
            Set(value As String)
                _IdEmpleado = value
            End Set
        End Property

        Public Property IdProcedimientoTerapeutico As String
            Get
                Return _IdProcedimientoTerapeutico
            End Get
            Set(value As String)
                _IdProcedimientoTerapeutico = value
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

        Public Property CodigoDiagnostico As String
            Get
                Return _CodigoDiagnostico
            End Get
            Set(value As String)
                _CodigoDiagnostico = value
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

        Public Property Biopsia As String
            Get
                Return _Biopsia
            End Get
            Set(value As String)
                _Biopsia = value
            End Set
        End Property

        Public Property TomaBiopsia As String
            Get
                Return _TomaBiopsia
            End Get
            Set(value As String)
                _TomaBiopsia = value
            End Set
        End Property
    End Class

End Namespace

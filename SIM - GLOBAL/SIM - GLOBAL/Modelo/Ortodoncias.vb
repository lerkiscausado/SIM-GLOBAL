Namespace Modelo
    Public Class Ortodoncias
        Private _id As String
        Private _IdOrden As String
        Private _IdDetalleOrden As String
        Private _Fecha As Date
        Private _Hora As Date
        Private _MotivoConsulta As String
        Private _Responsables As String
        Private _AntecedentesPatologicos As String
        Private _perfil As String
        Private _frente As String
        Private _hipotonia As String
        Private _hipertonia As String
        Private _macroquelia As String
        Private _microquelia As String
        Private _proquelia As String
        Private _Retroquelia As String
        Private _FrenilloLabiarSuperior As String
        Private _FrenilloLabialInferior As String
        Private _frenilloLingual As String
        Private _respiracionBucal As String
        Private _usoChupo As String
        Private _bruxomania As String
        Private _succiondigital As String
        Private _succionlabial As String
        Private _deglucionInfantil As String
        Private _onicofagia As String
        Private _empujeLingual As String
        Private _morderObjeto As String
        Private _evaluacionHabito As String
        Private _fonacion As String
        Private _interpretacionCefalometrica As String
        Private _diagnostico As String
        Private _pronostico As String
        Private _planTratamiento As String
        Private _aparatologia As String
        Private _presupuesto As String
        Private _actividadRealizada As String
        Private _proximaCita As String
        Private _codigoDiagnostico As String
        Private _idEmpleado As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
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

        Public Property MotivoConsulta As String
            Get
                Return _MotivoConsulta
            End Get
            Set(value As String)
                _MotivoConsulta = value
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

        Public Property AntecedentesPatologicos As String
            Get
                Return _AntecedentesPatologicos
            End Get
            Set(value As String)
                _AntecedentesPatologicos = value
            End Set
        End Property

        Public Property Perfil As String
            Get
                Return _perfil
            End Get
            Set(value As String)
                _perfil = value
            End Set
        End Property

        Public Property Frente As String
            Get
                Return _frente
            End Get
            Set(value As String)
                _frente = value
            End Set
        End Property

        Public Property Hipotonia As String
            Get
                Return _hipotonia
            End Get
            Set(value As String)
                _hipotonia = value
            End Set
        End Property

        Public Property Hipertonia As String
            Get
                Return _hipertonia
            End Get
            Set(value As String)
                _hipertonia = value
            End Set
        End Property

        Public Property Macroquelia As String
            Get
                Return _macroquelia
            End Get
            Set(value As String)
                _macroquelia = value
            End Set
        End Property

        Public Property Microquelia As String
            Get
                Return _microquelia
            End Get
            Set(value As String)
                _microquelia = value
            End Set
        End Property

        Public Property Proquelia As String
            Get
                Return _proquelia
            End Get
            Set(value As String)
                _proquelia = value
            End Set
        End Property

        Public Property FrenilloLabiarSuperior As String
            Get
                Return _FrenilloLabiarSuperior
            End Get
            Set(value As String)
                _FrenilloLabiarSuperior = value
            End Set
        End Property

        Public Property FrenilloLabialInferior As String
            Get
                Return _FrenilloLabialInferior
            End Get
            Set(value As String)
                _FrenilloLabialInferior = value
            End Set
        End Property

        Public Property FrenilloLingual As String
            Get
                Return _frenilloLingual
            End Get
            Set(value As String)
                _frenilloLingual = value
            End Set
        End Property

        Public Property RespiracionBucal As String
            Get
                Return _respiracionBucal
            End Get
            Set(value As String)
                _respiracionBucal = value
            End Set
        End Property

        Public Property UsoChupo As String
            Get
                Return _usoChupo
            End Get
            Set(value As String)
                _usoChupo = value
            End Set
        End Property

        Public Property Bruxomania As String
            Get
                Return _bruxomania
            End Get
            Set(value As String)
                _bruxomania = value
            End Set
        End Property

        Public Property Succiondigital As String
            Get
                Return _succiondigital
            End Get
            Set(value As String)
                _succiondigital = value
            End Set
        End Property

        Public Property Succionlabial As String
            Get
                Return _succionlabial
            End Get
            Set(value As String)
                _succionlabial = value
            End Set
        End Property

        Public Property DeglucionInfantil As String
            Get
                Return _deglucionInfantil
            End Get
            Set(value As String)
                _deglucionInfantil = value
            End Set
        End Property

        Public Property Onicofagia As String
            Get
                Return _onicofagia
            End Get
            Set(value As String)
                _onicofagia = value
            End Set
        End Property

        Public Property EmpujeLingual As String
            Get
                Return _empujeLingual
            End Get
            Set(value As String)
                _empujeLingual = value
            End Set
        End Property

        Public Property MorderObjeto As String
            Get
                Return _morderObjeto
            End Get
            Set(value As String)
                _morderObjeto = value
            End Set
        End Property

        Public Property EvaluacionHabito As String
            Get
                Return _evaluacionHabito
            End Get
            Set(value As String)
                _evaluacionHabito = value
            End Set
        End Property

        Public Property Fonacion As String
            Get
                Return _fonacion
            End Get
            Set(value As String)
                _fonacion = value
            End Set
        End Property

        Public Property InterpretacionCefalometrica As String
            Get
                Return _interpretacionCefalometrica
            End Get
            Set(value As String)
                _interpretacionCefalometrica = value
            End Set
        End Property

        Public Property Diagnostico As String
            Get
                Return _diagnostico
            End Get
            Set(value As String)
                _diagnostico = value
            End Set
        End Property

        Public Property Pronostico As String
            Get
                Return _pronostico
            End Get
            Set(value As String)
                _pronostico = value
            End Set
        End Property

        Public Property PlanTratamiento As String
            Get
                Return _planTratamiento
            End Get
            Set(value As String)
                _planTratamiento = value
            End Set
        End Property

        Public Property Aparatologia As String
            Get
                Return _aparatologia
            End Get
            Set(value As String)
                _aparatologia = value
            End Set
        End Property

        Public Property Presupuesto As String
            Get
                Return _presupuesto
            End Get
            Set(value As String)
                _presupuesto = value
            End Set
        End Property

        Public Property ActividadRealizada As String
            Get
                Return _actividadRealizada
            End Get
            Set(value As String)
                _actividadRealizada = value
            End Set
        End Property

        Public Property ProximaCita As String
            Get
                Return _proximaCita
            End Get
            Set(value As String)
                _proximaCita = value
            End Set
        End Property

        Public Property CodigoDiagnostico As String
            Get
                Return _codigoDiagnostico
            End Get
            Set(value As String)
                _codigoDiagnostico = value
            End Set
        End Property

        Public Property IdEmpleado As String
            Get
                Return _idEmpleado
            End Get
            Set(value As String)
                _idEmpleado = value
            End Set
        End Property

        Public Property Retroquelia As String
            Get
                Return _Retroquelia
            End Get
            Set(value As String)
                _Retroquelia = value
            End Set
        End Property
    End Class
End Namespace


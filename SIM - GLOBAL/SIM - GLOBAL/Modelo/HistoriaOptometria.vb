Namespace Modelo
    Public Class HistoriaOptometria
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _FechaHistoria As Date
        Private _MotivoConsulta As String
        Private _Ocupacion As String
        Private _RXUSO As String
        Private _Antecedentes As String
        Private _AVVL As String
        Private _AVVP As String
        Private _RefraccionEstatica As String
        Private _DistanciaPupilar As String
        Private _Subjetivo As String
        Private _CoverTest As String
        Private _ModoUso As String
        Private _Lensometria As String
        Private _AVF As String
        Private _Diagnostico As String
        Private _OtrosHallazgos As String
        Private _CIE10 As String
        Private _Conducta As String
        Private _IdEspecialista As String
        Private _Responsables As String

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

        Public Property FechaHistoria As Date
            Get
                Return _FechaHistoria
            End Get
            Set(value As Date)
                _FechaHistoria = value
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

        Public Property Ocupacion As String
            Get
                Return _Ocupacion
            End Get
            Set(value As String)
                _Ocupacion = value
            End Set
        End Property

        Public Property RXUSO As String
            Get
                Return _RXUSO
            End Get
            Set(value As String)
                _RXUSO = value
            End Set
        End Property

        Public Property Antecedentes As String
            Get
                Return _Antecedentes
            End Get
            Set(value As String)
                _Antecedentes = value
            End Set
        End Property

        Public Property AVVL As String
            Get
                Return _AVVL
            End Get
            Set(value As String)
                _AVVL = value
            End Set
        End Property

        Public Property AVVP As String
            Get
                Return _AVVP
            End Get
            Set(value As String)
                _AVVP = value
            End Set
        End Property

        Public Property RefraccionEstatica As String
            Get
                Return _RefraccionEstatica
            End Get
            Set(value As String)
                _RefraccionEstatica = value
            End Set
        End Property

        Public Property DistanciaPupilar As String
            Get
                Return _DistanciaPupilar
            End Get
            Set(value As String)
                _DistanciaPupilar = value
            End Set
        End Property

        Public Property Subjetivo As String
            Get
                Return _Subjetivo
            End Get
            Set(value As String)
                _Subjetivo = value
            End Set
        End Property

        Public Property CoverTest As String
            Get
                Return _CoverTest
            End Get
            Set(value As String)
                _CoverTest = value
            End Set
        End Property

        Public Property ModoUso As String
            Get
                Return _ModoUso
            End Get
            Set(value As String)
                _ModoUso = value
            End Set
        End Property

        Public Property Lensometria As String
            Get
                Return _Lensometria
            End Get
            Set(value As String)
                _Lensometria = value
            End Set
        End Property

        Public Property AVF As String
            Get
                Return _AVF
            End Get
            Set(value As String)
                _AVF = value
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

        Public Property OtrosHallazgos As String
            Get
                Return _OtrosHallazgos
            End Get
            Set(value As String)
                _OtrosHallazgos = value
            End Set
        End Property

        Public Property CIE10 As String
            Get
                Return _CIE10
            End Get
            Set(value As String)
                _CIE10 = value
            End Set
        End Property

        Public Property IdEspecialista As String
            Get
                Return _IdEspecialista
            End Get
            Set(value As String)
                _IdEspecialista = value
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

        Public Property Conducta As String
            Get
                Return _Conducta
            End Get
            Set(value As String)
                _Conducta = value
            End Set
        End Property
    End Class
End Namespace


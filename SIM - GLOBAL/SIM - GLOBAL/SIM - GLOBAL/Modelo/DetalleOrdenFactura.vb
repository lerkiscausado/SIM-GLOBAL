Namespace Modelo
    Public Class DetalleFacturacion
        Private _Id As Integer
        Private _IdOrden As String
        Private _IdCausa As Integer
        Private _IdFinalidadConsulta As Integer
        Private _IdFinalidadProcedimiento As Integer
        Private _IdAmbito As Integer
        Private _IdPersonaAtiende As Integer
        Private _FechaSalida As Date
        Private _Hora As Date
        Private _IdTipoDiagnostico As Integer
        Private _Diagnostico1 As String
        Private _Diagnostico2 As String
        Private _Diagnostico3 As String
        Private _Diagnostico4 As String
        Private _IdFormaRealizacion As Integer
        Private _CodigoProcedimiento As String
        Private _CodigoCups As String
        Private _IdTipoEstudio As String
        Private _Valor As Integer
        Private _Copago As Integer
        Private _Neto As Integer
        Private _Tipo As String
        Private _Estado As String
        Private _IdRelacion As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
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

        Public Property IdCausa As Integer
            Get
                Return _IdCausa
            End Get
            Set(value As Integer)
                _IdCausa = value
            End Set
        End Property

        Public Property IdFinalidadConsulta As Integer
            Get
                Return _IdFinalidadConsulta
            End Get
            Set(value As Integer)
                _IdFinalidadConsulta = value
            End Set
        End Property

        Public Property IdFinalidadProcedimiento As Integer
            Get
                Return _IdFinalidadProcedimiento
            End Get
            Set(value As Integer)
                _IdFinalidadProcedimiento = value
            End Set
        End Property

        Public Property IdAmbito As Integer
            Get
                Return _IdAmbito
            End Get
            Set(value As Integer)
                _IdAmbito = value
            End Set
        End Property

        Public Property IdPersonaAtiende As Integer
            Get
                Return _IdPersonaAtiende
            End Get
            Set(value As Integer)
                _IdPersonaAtiende = value
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

        Public Property IdTipoDiagnostico As Integer
            Get
                Return _IdTipoDiagnostico
            End Get
            Set(value As Integer)
                _IdTipoDiagnostico = value
            End Set
        End Property

        Public Property Diagnostico1 As String
            Get
                Return _Diagnostico1
            End Get
            Set(value As String)
                _Diagnostico1 = value
            End Set
        End Property

        Public Property Diagnostico2 As String
            Get
                Return _Diagnostico2
            End Get
            Set(value As String)
                _Diagnostico2 = value
            End Set
        End Property

        Public Property Diagnostico3 As String
            Get
                Return _Diagnostico3
            End Get
            Set(value As String)
                _Diagnostico3 = value
            End Set
        End Property

        Public Property Diagnostico4 As String
            Get
                Return _Diagnostico4
            End Get
            Set(value As String)
                _Diagnostico4 = value
            End Set
        End Property

        Public Property IdFormaRealizacion As Integer
            Get
                Return _IdFormaRealizacion
            End Get
            Set(value As Integer)
                _IdFormaRealizacion = value
            End Set
        End Property

        Public Property CodigoProcedimiento As String
            Get
                Return _CodigoProcedimiento
            End Get
            Set(value As String)
                _CodigoProcedimiento = value
            End Set
        End Property

        Public Property CodigoCups As String
            Get
                Return _CodigoCups
            End Get
            Set(value As String)
                _CodigoCups = value
            End Set
        End Property

        Public Property IdTipoEstudio As String
            Get
                Return _IdTipoEstudio
            End Get
            Set(value As String)
                _IdTipoEstudio = value
            End Set
        End Property

        Public Property Valor As Integer
            Get
                Return _Valor
            End Get
            Set(value As Integer)
                _Valor = value
            End Set
        End Property

        Public Property Copago As Integer
            Get
                Return _Copago
            End Get
            Set(value As Integer)
                _Copago = value
            End Set
        End Property

        Public Property Neto As Integer
            Get
                Return _Neto
            End Get
            Set(value As Integer)
                _Neto = value
            End Set
        End Property

        Public Property Tipo As String
            Get
                Return _Tipo
            End Get
            Set(value As String)
                _Tipo = value
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

        Public Property IdRelacion As String
            Get
                Return _IdRelacion
            End Get
            Set(value As String)
                _IdRelacion = value
            End Set
        End Property
    End Class
End Namespace


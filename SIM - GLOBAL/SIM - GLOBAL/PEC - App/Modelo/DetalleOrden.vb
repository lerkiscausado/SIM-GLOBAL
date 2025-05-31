Namespace Modelo
    Public Class DetalleOrden
        Private _Id As Integer
        Private _IdOrden As String
        Private _IdTipoEstudio As String
        Private _FechaSalida As Date
        Private _Hora As Date
        Private _Valor As Double
        Private _IVA As Double
        Private _Estado As String

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

        Public Property IdTipoEstudio As String
            Get
                Return _IdTipoEstudio
            End Get
            Set(value As String)
                _IdTipoEstudio = value
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

        Public Property Valor As Double
            Get
                Return _Valor
            End Get
            Set(value As Double)
                _Valor = value
            End Set
        End Property

        Public Property IVA As Double
            Get
                Return _IVA
            End Get
            Set(value As Double)
                _IVA = value
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

    End Class
End Namespace


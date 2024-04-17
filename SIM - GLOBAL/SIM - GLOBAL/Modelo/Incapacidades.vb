Namespace Modelo
    Public Class Incapacidades
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _TipoIncapacidad As String
        Private _FechaInicial As Date
        Private _FechaFinal As Date
        Private _Nota As String
        Private _Diagnostico As String

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

        Public Property TipoIncapacidad As String
            Get
                Return _TipoIncapacidad
            End Get
            Set(value As String)
                _TipoIncapacidad = value
            End Set
        End Property

        Public Property FechaInicial As Date
            Get
                Return _FechaInicial
            End Get
            Set(value As Date)
                _FechaInicial = value
            End Set
        End Property

        Public Property FechaFinal As Date
            Get
                Return _FechaFinal
            End Get
            Set(value As Date)
                _FechaFinal = value
            End Set
        End Property

        Public Property Nota As String
            Get
                Return _Nota
            End Get
            Set(value As String)
                _Nota = value
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
    End Class
End Namespace


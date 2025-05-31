Namespace Modelo
    Public Class Patologia
        Private _id As Integer
        Private _idOrden As Integer
        Private _Fecha As Date
        Private _FechaSalida As Date
        Private _tipoMuestra As String
        Private _sitioLesion As String
        Private _solicitado As String
        Private _descripcionMacroscopica As String
        Private _descripcionMicroscopica As String
        Private _diagnostico As String
        Private _observaciones As String
        Private _codigoDiagnostico As String
        Private _idEmpleado As Integer
        Private _estado As String
        Private _codigoPatologia As String

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

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property

        Public Property DescripcionMacroscopica As String
            Get
                Return _descripcionMacroscopica
            End Get
            Set(value As String)
                _descripcionMacroscopica = value
            End Set
        End Property

        Public Property DescripcionMicroscopica As String
            Get
                Return _descripcionMicroscopica
            End Get
            Set(value As String)
                _descripcionMicroscopica = value
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

        Public Property Observaciones As String
            Get
                Return _observaciones
            End Get
            Set(value As String)
                _observaciones = value
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

        Public Property IdEmpleado As Integer
            Get
                Return _idEmpleado
            End Get
            Set(value As Integer)
                _idEmpleado = value
            End Set
        End Property

        Public Property Estado As String
            Get
                Return _estado
            End Get
            Set(value As String)
                _estado = value
            End Set
        End Property

        Public Property TipoMuestra As String
            Get
                Return _tipoMuestra
            End Get
            Set(value As String)
                _tipoMuestra = value
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

        Public Property SitioLesion As String
            Get
                Return _sitioLesion
            End Get
            Set(value As String)
                _sitioLesion = value
            End Set
        End Property

        Public Property Solicitado As String
            Get
                Return _solicitado
            End Get
            Set(value As String)
                _solicitado = value
            End Set
        End Property

        Public Property CodigoPatologia As String
            Get
                Return _codigoPatologia
            End Get
            Set(value As String)
                _codigoPatologia = value
            End Set
        End Property
    End Class
End Namespace


Namespace Modelo
    Public Class EstudiosGenerados
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _IdDetalleOrden As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _Estudio As String
        Private _IdEmpleado As Integer

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

        Public Property Estudio As String
            Get
                Return _Estudio
            End Get
            Set(value As String)
                _Estudio = value
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
    End Class
End Namespace


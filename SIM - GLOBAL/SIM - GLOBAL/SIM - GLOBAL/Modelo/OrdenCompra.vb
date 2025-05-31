Namespace Modelo
    Public Class OrdenCompra
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdProveedor As Integer
        Private _IdEmpleado As Integer
        Private _Observacion As String
        Private _Estado As String
        Private _FechaAprobacion As Date
        Private _IdAprobacion As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property IdProveedor As Integer
            Get
                Return _IdProveedor
            End Get
            Set(value As Integer)
                _IdProveedor = value
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

        Public Property Observacion As String
            Get
                Return _Observacion
            End Get
            Set(value As String)
                _Observacion = value
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

        Public Property FechaAprobacion As Date
            Get
                Return _FechaAprobacion
            End Get
            Set(value As Date)
                _FechaAprobacion = value
            End Set
        End Property

        Public Property IdAprobacion As String
            Get
                Return _IdAprobacion
            End Get
            Set(value As String)
                _IdAprobacion = value
            End Set
        End Property
    End Class

End Namespace

Namespace Modelo
    Public Class Ordenes
        Private _Id As Integer
        Private _IdUsuario As String
        Private _IdContrato As String
        Private _IdClienteSede As String
        Private _IdEmpleado As String
        Private _Autorizacion As String
        Private _FechaIngreso As Date
        Private _FechaSolicitud As Date
        Private _Hora As Date
        Private _IdFactura As String
        Private _Comentarios As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdUsuario As String
            Get
                Return _IdUsuario
            End Get
            Set(value As String)
                _IdUsuario = value
            End Set
        End Property

        Public Property IdContrato As String
            Get
                Return _IdContrato
            End Get
            Set(value As String)
                _IdContrato = value
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

        Public Property Autorizacion As String
            Get
                Return _Autorizacion
            End Get
            Set(value As String)
                _Autorizacion = value
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

        Public Property FechaSolicitud As Date
            Get
                Return _FechaSolicitud
            End Get
            Set(value As Date)
                _FechaSolicitud = value
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

        Public Property Comentarios As String
            Get
                Return _Comentarios
            End Get
            Set(value As String)
                _Comentarios = value
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

        Public Property IdClienteSede As String
            Get
                Return _IdClienteSede
            End Get
            Set(value As String)
                _IdClienteSede = value
            End Set
        End Property

        Public Property IdFactura As String
            Get
                Return _IdFactura
            End Get
            Set(value As String)
                _IdFactura = value
            End Set
        End Property
    End Class
End Namespace

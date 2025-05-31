Namespace Modelo
    Public Class Ordenes
        Private _id As Integer
        Private _fechaIngreso As Date
        Private _idUsuario As Integer
        Private _idTipoConsulta As Integer
        Private _CodigoDiagnostico As String
        Private _cometarios As String
        Private _idContrato As String
        Private _idSubEntidad As String
        Private _idIngreso As String
        Private _idSede As String
        Private _idEmpleado As String
        Private _autorizacion As String
        Private _numeroOrden As String
        Private _fechaOrden As Date
        Private _hora As Date
        Private _idFactura As String
        Private _idTipoAfiliado As String
        Private _idTipoUsuario As String
        Private _idTipoEstudio As String
        Private _estado As String

        Public Property ID As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property FechaIngreso As Date
            Get
                Return _fechaIngreso
            End Get
            Set(value As Date)
                _fechaIngreso = value
            End Set
        End Property

        Public Property IdUsuario As Integer
            Get
                Return _idUsuario
            End Get
            Set(value As Integer)
                _idUsuario = value
            End Set
        End Property

        Public Property IdTipoConsulta As Integer
            Get
                Return _idTipoConsulta
            End Get
            Set(value As Integer)
                _idTipoConsulta = value
            End Set
        End Property

        Public Property Cometarios As String
            Get
                Return _cometarios
            End Get
            Set(value As String)
                _cometarios = value
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

        Public Property CodigoDiagnostico As String
            Get
                Return _CodigoDiagnostico
            End Get
            Set(value As String)
                _CodigoDiagnostico = value
            End Set
        End Property

        Public Property IdContrato As String
            Get
                Return _idContrato
            End Get
            Set(value As String)
                _idContrato = value
            End Set
        End Property

        Public Property IdSubEntidad As String
            Get
                Return _idSubEntidad
            End Get
            Set(value As String)
                _idSubEntidad = value
            End Set
        End Property

        Public Property IdIngreso As String
            Get
                Return _idIngreso
            End Get
            Set(value As String)
                _idIngreso = value
            End Set
        End Property

        Public Property IdSede As String
            Get
                Return _idSede
            End Get
            Set(value As String)
                _idSede = value
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

        Public Property Autorizacion As String
            Get
                Return _autorizacion
            End Get
            Set(value As String)
                _autorizacion = value
            End Set
        End Property

        Public Property NumeroOrden As String
            Get
                Return _numeroOrden
            End Get
            Set(value As String)
                _numeroOrden = value
            End Set
        End Property

        Public Property FechaOrden As Date
            Get
                Return _fechaOrden
            End Get
            Set(value As Date)
                _fechaOrden = value
            End Set
        End Property

        Public Property Hora As Date
            Get
                Return _hora
            End Get
            Set(value As Date)
                _hora = value
            End Set
        End Property

        Public Property IdFactura As String
            Get
                Return _idFactura
            End Get
            Set(value As String)
                _idFactura = value
            End Set
        End Property

        Public Property IdTipoAfiliado As String
            Get
                Return _idTipoAfiliado
            End Get
            Set(value As String)
                _idTipoAfiliado = value
            End Set
        End Property

        Public Property IdTipoUsuario As String
            Get
                Return _idTipoUsuario
            End Get
            Set(value As String)
                _idTipoUsuario = value
            End Set
        End Property

        Public Property IdTipoEstudio As String
            Get
                Return _idTipoEstudio
            End Get
            Set(value As String)
                _idTipoEstudio = value
            End Set
        End Property
    End Class

End Namespace

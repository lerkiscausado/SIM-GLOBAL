Namespace My.Modelo
    Public Class Ordenes
        Private _id As Integer
        Private _idUsuario As String
        Private _idContrato As String
        Private _idIngreso As String
        Private _IdSede As String
        Private _autorizacion As String
        Private _NumeroOrden As String
        Private _fechaIngreso As Date
        Private _FechaOrden As Date
        Private _hora As Date
        Private _idfactura As String
        Private _idTipoAfiliado As String
        Private _idTipoUsuario As String
        Private _IdTipoEstudio As String
        Private _comentarios As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property IdUsuario As String
            Get
                Return _idUsuario
            End Get
            Set(value As String)
                _idUsuario = value
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

        Public Property IdIngreso As String
            Get
                Return _idIngreso
            End Get
            Set(value As String)
                _idIngreso = value
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
                Return _NumeroOrden
            End Get
            Set(value As String)
                _NumeroOrden = value
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

        Public Property FechaOrden As Date
            Get
                Return _FechaOrden
            End Get
            Set(value As Date)
                _FechaOrden = value
            End Set
        End Property



        Public Property Idfactura As String
            Get
                Return _idfactura
            End Get
            Set(value As String)
                _idfactura = value
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

        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(value As String)
                _Estado = value
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

        Public Property Comentarios As String
            Get
                Return _comentarios
            End Get
            Set(value As String)
                _comentarios = value
            End Set
        End Property

        Public Property IdSede As String
            Get
                Return _IdSede
            End Get
            Set(value As String)
                _IdSede = value
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
    End Class
End Namespace


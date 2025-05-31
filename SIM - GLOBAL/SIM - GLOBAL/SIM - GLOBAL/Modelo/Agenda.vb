Namespace My.Modelo
    Public Class Agenda
        Private _id As Integer
        Private _Fecha As Date
        Private _FechaAgenda As Date
        Private _FechaSolicitada As Date
        Private _Hora As Date
        Private _idUsuario As String
        Private _idTipoEstudio As String
        Private _IdContrato As String
        Private _nota As String
        Private _idEmpleado As String
        Private _idEspecialista As String
        Private _IdOrden As String
        Private _estado As String
        Private _CodigoCups As String
        Private _NombreCups As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
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

        Public Property Nota As String
            Get
                Return _nota
            End Get
            Set(value As String)
                _nota = value
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

        Public Property IdUsuario As String
            Get
                Return _idUsuario
            End Get
            Set(value As String)
                _idUsuario = value
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

        Public Property IdEmpleado As String
            Get
                Return _idEmpleado
            End Get
            Set(value As String)
                _idEmpleado = value
            End Set
        End Property

        Public Property IdEspecialista As String
            Get
                Return _idEspecialista
            End Get
            Set(value As String)
                _idEspecialista = value
            End Set
        End Property

        Public Property FechaAgenda As Date
            Get
                Return _FechaAgenda
            End Get
            Set(value As Date)
                _FechaAgenda = value
            End Set
        End Property

        Public Property FechaSolicitada As Date
            Get
                Return _FechaSolicitada
            End Get
            Set(value As Date)
                _FechaSolicitada = value
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

        Public Property IdOrden As String
            Get
                Return _IdOrden
            End Get
            Set(value As String)
                _IdOrden = value
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

        Public Property NombreCups As String
            Get
                Return _NombreCups
            End Get
            Set(value As String)
                _NombreCups = value
            End Set
        End Property
    End Class

End Namespace

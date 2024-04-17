Namespace Modelo
    Public Class Auditoria
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdTabla As Integer
        Private _IdRegistro As Integer
        Private _Concepto As String
        Private _Comentario As String
        Private _IdSolicita As Integer
        Private _IdAutoriza As Integer
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property IdTabla As Integer
            Get
                Return _IdTabla
            End Get
            Set(value As Integer)
                _IdTabla = value
            End Set
        End Property

        Public Property IdRegistro As Integer
            Get
                Return _IdRegistro
            End Get
            Set(value As Integer)
                _IdRegistro = value
            End Set
        End Property

        Public Property Concepto As String
            Get
                Return _Concepto
            End Get
            Set(value As String)
                _Concepto = value
            End Set
        End Property

        Public Property Comentario As String
            Get
                Return _Comentario
            End Get
            Set(value As String)
                _Comentario = value
            End Set
        End Property

        Public Property IdSolicita As Integer
            Get
                Return _IdSolicita
            End Get
            Set(value As Integer)
                _IdSolicita = value
            End Set
        End Property

        Public Property IdAutoriza As Integer
            Get
                Return _IdAutoriza
            End Get
            Set(value As Integer)
                _IdAutoriza = value
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

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property
    End Class

End Namespace

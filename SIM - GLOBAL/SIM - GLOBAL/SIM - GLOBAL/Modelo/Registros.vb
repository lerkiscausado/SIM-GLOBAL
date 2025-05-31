Namespace Modelo
    Public Class Registros
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _IdTabla As String
        Private _IdRegistro As String
        Private _IdUsuario As String
        Private _TipoRegistro As String
        Private _Nota As String

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

        Public Property IdTabla As String
            Get
                Return _IdTabla
            End Get
            Set(value As String)
                _IdTabla = value
            End Set
        End Property

        Public Property IdRegistro As String
            Get
                Return _IdRegistro
            End Get
            Set(value As String)
                _IdRegistro = value
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

        Public Property TipoRegistro As String
            Get
                Return _TipoRegistro
            End Get
            Set(value As String)
                _TipoRegistro = value
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
    End Class
End Namespace
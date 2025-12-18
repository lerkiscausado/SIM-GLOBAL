Namespace Modelo
    Public Class SmtpConfig

        Private _Id As Integer
        Private _NombreConfig As String
        Private _SmtpHost As String
        Private _SmtpPort As Integer
        Private _SmtpUser As String
        Private _SmtpPassword As String
        Private _SmtpFrom As String
        Private _DisplayName As String
        Private _EnableSsl As Boolean
        Private _IsActive As Boolean
        Private _CreatedAt As Date

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property NombreConfig As String
            Get
                Return _NombreConfig
            End Get
            Set(value As String)
                _NombreConfig = value
            End Set
        End Property

        Public Property SmtpHost As String
            Get
                Return _SmtpHost
            End Get
            Set(value As String)
                _SmtpHost = value
            End Set
        End Property

        Public Property SmtpPort As Integer
            Get
                Return _SmtpPort
            End Get
            Set(value As Integer)
                _SmtpPort = value
            End Set
        End Property

        Public Property SmtpUser As String
            Get
                Return _SmtpUser
            End Get
            Set(value As String)
                _SmtpUser = value
            End Set
        End Property

        Public Property SmtpPassword As String
            Get
                Return _SmtpPassword
            End Get
            Set(value As String)
                _SmtpPassword = value
            End Set
        End Property

        Public Property SmtpFrom As String
            Get
                Return _SmtpFrom
            End Get
            Set(value As String)
                _SmtpFrom = value
            End Set
        End Property

        Public Property DisplayName As String
            Get
                Return _DisplayName
            End Get
            Set(value As String)
                _DisplayName = value
            End Set
        End Property

        Public Property EnableSsl As Boolean
            Get
                Return _EnableSsl
            End Get
            Set(value As Boolean)
                _EnableSsl = value
            End Set
        End Property

        Public Property IsActive As Boolean
            Get
                Return _IsActive
            End Get
            Set(value As Boolean)
                _IsActive = value
            End Set
        End Property

        Public Property CreatedAt As Date
            Get
                Return _CreatedAt
            End Get
            Set(value As Date)
                _CreatedAt = value
            End Set
        End Property

    End Class
End Namespace


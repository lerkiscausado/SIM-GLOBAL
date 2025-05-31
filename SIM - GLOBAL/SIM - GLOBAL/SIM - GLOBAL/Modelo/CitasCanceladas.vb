Namespace Modelo
    Public Class CitasCanceladas
        Private _Id As Integer
        Private _Fecha As Date
        Private _IdAgenda As Integer
        Private _IdMotivo As Integer
        Private _Motivo As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdAgenda As Integer
            Get
                Return _IdAgenda
            End Get
            Set(value As Integer)
                _IdAgenda = value
            End Set
        End Property

        Public Property IdMotivo As Integer
            Get
                Return _IdMotivo
            End Get
            Set(value As Integer)
                _IdMotivo = value
            End Set
        End Property

        Public Property Motivo As String
            Get
                Return _Motivo
            End Get
            Set(value As String)
                _Motivo = value
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

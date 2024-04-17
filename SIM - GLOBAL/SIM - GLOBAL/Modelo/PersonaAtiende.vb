Namespace Modelo
    Public Class PersonaAtiende
        Private _Id As String
        Private _Nombre As String
        Private _Estado As String

        Public Property Id As String
            Get
                Return _Id
            End Get
            Set(value As String)
                _Id = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
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
    End Class
End Namespace

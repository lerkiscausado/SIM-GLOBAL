Namespace Modelo
    Public Class ClientesSedes
        Private _Id As Integer
        Private _IdContrato As String
        Private _IdCiudad As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property IdCiudad As String
            Get
                Return _IdCiudad
            End Get
            Set(value As String)
                _IdCiudad = value
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

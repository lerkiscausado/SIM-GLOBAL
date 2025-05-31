Namespace Modelo
    Public Class DetalleTarifa
        Private _Id As Integer
        Private _IdTarifa As String
        Private _IdTipoEstudio As Integer
        Private _Valor As String
        Private _IVA As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdTipoEstudio As Integer
            Get
                Return _IdTipoEstudio
            End Get
            Set(value As Integer)
                _IdTipoEstudio = value
            End Set
        End Property

        Public Property Valor As String
            Get
                Return _Valor
            End Get
            Set(value As String)
                _Valor = value
            End Set
        End Property

        Public Property IVA As String
            Get
                Return _IVA
            End Get
            Set(value As String)
                _IVA = value
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

        Public Property IdTarifa As String
            Get
                Return _IdTarifa
            End Get
            Set(value As String)
                _IdTarifa = value
            End Set
        End Property
    End Class
End Namespace

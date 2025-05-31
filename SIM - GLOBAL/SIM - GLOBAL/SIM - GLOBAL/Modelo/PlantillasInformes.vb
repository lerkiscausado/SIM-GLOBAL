Namespace Modelo
    Public Class PlantillasInformes
        Private _Id As Integer
        Private _IdTipoEstudio As Integer
        Private _IdEspecialista As Integer
        Private _Campo1 As String
        Private _Campo2 As String
        Private _Campo3 As String
        Private _Campo4 As String
        Private _Campo5 As String
        Private _Campo6 As String
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

        Public Property IdEspecialista As Integer
            Get
                Return _IdEspecialista
            End Get
            Set(value As Integer)
                _IdEspecialista = value
            End Set
        End Property

        Public Property Campo1 As String
            Get
                Return _Campo1
            End Get
            Set(value As String)
                _Campo1 = value
            End Set
        End Property

        Public Property Campo2 As String
            Get
                Return _Campo2
            End Get
            Set(value As String)
                _Campo2 = value
            End Set
        End Property

        Public Property Campo3 As String
            Get
                Return _Campo3
            End Get
            Set(value As String)
                _Campo3 = value
            End Set
        End Property

        Public Property Campo4 As String
            Get
                Return _Campo4
            End Get
            Set(value As String)
                _Campo4 = value
            End Set
        End Property

        Public Property Campo5 As String
            Get
                Return _Campo5
            End Get
            Set(value As String)
                _Campo5 = value
            End Set
        End Property

        Public Property Campo6 As String
            Get
                Return _Campo6
            End Get
            Set(value As String)
                _Campo6 = value
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

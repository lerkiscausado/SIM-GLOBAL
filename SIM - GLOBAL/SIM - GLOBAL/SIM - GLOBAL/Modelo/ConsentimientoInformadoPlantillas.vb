Namespace Modelo
    Public Class ConsentimientoInformadoPlantillas
        Private _Id As Integer
        Private _IdLicencia As Integer
        Private _TipoConsentimiento As String
        Private _Descripcion As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdLicencia As Integer
            Get
                Return _IdLicencia
            End Get
            Set(value As Integer)
                _IdLicencia = value
            End Set
        End Property

        Public Property TipoConsentimiento As String
            Get
                Return _TipoConsentimiento
            End Get
            Set(value As String)
                _TipoConsentimiento = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return _Descripcion
            End Get
            Set(value As String)
                _Descripcion = value
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


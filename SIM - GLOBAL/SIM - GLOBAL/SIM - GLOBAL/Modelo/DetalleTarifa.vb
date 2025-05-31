Namespace My.Modelo
    Public Class DetalleTarifa
        Private _id As Integer
        Private _idTarifa As String
        Private _codigoProcedimiento As String
        Private _IDTipoEstudio As String
        Private _CodigoCups As String
        Private _valor As String
        Private _Descuento As Integer
        Private _tipoAtencion As String
        Private _estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property CodigoProcedimiento As String
            Get
                Return _codigoProcedimiento
            End Get
            Set(value As String)
                _codigoProcedimiento = value
            End Set
        End Property

        Public Property IDTipoEstudio As String
            Get
                Return _IDTipoEstudio
            End Get
            Set(value As String)
                _IDTipoEstudio = value
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

        Public Property Valor As String
            Get
                Return _valor
            End Get
            Set(value As String)
                _valor = value
            End Set
        End Property

        Public Property TipoAtencion As String
            Get
                Return _tipoAtencion
            End Get
            Set(value As String)
                _tipoAtencion = value
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

        Public Property IdTarifa As String
            Get
                Return _idTarifa
            End Get
            Set(value As String)
                _idTarifa = value
            End Set
        End Property

        Public Property Descuento As Integer
            Get
                Return _Descuento
            End Get
            Set(value As Integer)
                _Descuento = value
            End Set
        End Property
    End Class
End Namespace


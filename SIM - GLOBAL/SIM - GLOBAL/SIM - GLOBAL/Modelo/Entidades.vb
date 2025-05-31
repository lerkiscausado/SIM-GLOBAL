Namespace My.Modelo
    Public Class Entidades
        Private _codigoEntidad As String
        Private _nombreEntidad As String
        Private _nit As String
        Private _direccion As String
        Private _Telefono As String
        Private _estado As String

        Public Property CodigoEntidad As String
            Get
                Return _codigoEntidad
            End Get
            Set(value As String)
                _codigoEntidad = value
            End Set
        End Property

        Public Property NombreEntidad As String
            Get
                Return _nombreEntidad
            End Get
            Set(value As String)
                _nombreEntidad = value
            End Set
        End Property

        Public Property Nit As String
            Get
                Return _nit
            End Get
            Set(value As String)
                _nit = value
            End Set
        End Property

        Public Property Direccion As String
            Get
                Return _direccion
            End Get
            Set(value As String)
                _direccion = value
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

        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(value As String)
                _Telefono = value
            End Set
        End Property
    End Class
End Namespace


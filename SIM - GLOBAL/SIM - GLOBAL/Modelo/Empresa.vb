Namespace Modelo
    Public Class Empresa
        Private _id As String
        Private _idLicencia As String
        Private _idTipoIdentificacion As String
        Private _identificacion As String
        Private _nombre As String
        Private _direccion As String
        Private _ciudad As String
        Private _telefono As String
        Private _celular As String
        Private _fax As String
        Private _email As String
        Private _paginaWeb As String
        Private _logo As Byte()
        Private _estado As String
        Private _codigoPrestador As String
        Private _tipo As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Public Property IdLicencia As String
            Get
                Return _idLicencia
            End Get
            Set(value As String)
                _idLicencia = value
            End Set
        End Property

        Public Property IdTipoIdentificacion As String
            Get
                Return _idTipoIdentificacion
            End Get
            Set(value As String)
                _idTipoIdentificacion = value
            End Set
        End Property

        Public Property Identificacion As String
            Get
                Return _identificacion
            End Get
            Set(value As String)
                _identificacion = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
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

        Public Property Ciudad As String
            Get
                Return _ciudad
            End Get
            Set(value As String)
                _ciudad = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _telefono
            End Get
            Set(value As String)
                _telefono = value
            End Set
        End Property

        Public Property Celular As String
            Get
                Return _celular
            End Get
            Set(value As String)
                _celular = value
            End Set
        End Property

        Public Property Fax As String
            Get
                Return _fax
            End Get
            Set(value As String)
                _fax = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set
        End Property

        Public Property PaginaWeb As String
            Get
                Return _paginaWeb
            End Get
            Set(value As String)
                _paginaWeb = value
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

        Public Property Logo As Byte()
            Get
                Return _logo
            End Get
            Set(value As Byte())
                _logo = value
            End Set
        End Property

        Public Property CodigoPrestador As String
            Get
                Return _codigoPrestador
            End Get
            Set(value As String)
                _codigoPrestador = value
            End Set
        End Property

        Public Property Tipo As String
            Get
                Return _tipo
            End Get
            Set(value As String)
                _tipo = value
            End Set
        End Property
    End Class
End Namespace

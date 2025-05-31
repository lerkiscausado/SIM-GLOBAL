Namespace Modelo
    Public Class Contratos
        Private _id As Integer
        Private _nombre As String
        Private _numeroContrato As String
        Private _fechaInicio As Date
        Private _fechaFinal As Date
        Private _observaciones As String
        Private _Contacto As String
        Private _Telefono As String
        Private _CorreoElectronico As String
        Private _idCliente As String
        Private _idTarifa As String
        Private _estado As String
        Private _IdLicencia As String


        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property idCliente As String
            Get
                Return _idCliente
            End Get
            Set(value As String)
                _idCliente = value
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

        Public Property NumeroContrato As String
            Get
                Return _numeroContrato
            End Get
            Set(value As String)
                _numeroContrato = value
            End Set
        End Property

        Public Property FechaInicio As Date
            Get
                Return _fechaInicio
            End Get
            Set(value As Date)
                _fechaInicio = value
            End Set
        End Property

        Public Property FechaFinal As Date
            Get
                Return _fechaFinal
            End Get
            Set(value As Date)
                _fechaFinal = value
            End Set
        End Property

        Public Property Observaciones As String
            Get
                Return _observaciones
            End Get
            Set(value As String)
                _observaciones = value
            End Set
        End Property

        Public Property Contacto As String
            Get
                Return _Contacto
            End Get
            Set(value As String)
                _Contacto = value
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

        Public Property CorreoElectronico As String
            Get
                Return _CorreoElectronico
            End Get
            Set(value As String)
                _CorreoElectronico = value
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



        Public Property IdLicencia As String
            Get
                Return _IdLicencia
            End Get
            Set(value As String)
                _IdLicencia = value
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
    End Class
End Namespace


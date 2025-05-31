Namespace Modelo
    Public Class RegistroAnestesia
        Private _Id As Integer
        Private _IdOrden As String
        Private _IdDetalleOrden As String
        Private _Fecha As Date
        Private _Cardiovisoscopico As String
        Private _PresionArterial As String
        Private _OximetriaPulso As String
        Private _ViaAerea As String
        Private _Posicion As String
        Private _Complicaciones As String
        Private _Observaciones As String
        Private _ResumenAnestesico As String
        Private _IdEndoscopista As String
        Private _AuxiliarAnestesia As String
        Private _IdAnestesiologo As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Cardiovisoscopico As String
            Get
                Return _Cardiovisoscopico
            End Get
            Set(value As String)
                _Cardiovisoscopico = value
            End Set
        End Property

        Public Property PresionArterial As String
            Get
                Return _PresionArterial
            End Get
            Set(value As String)
                _PresionArterial = value
            End Set
        End Property

        Public Property OximetriaPulso As String
            Get
                Return _OximetriaPulso
            End Get
            Set(value As String)
                _OximetriaPulso = value
            End Set
        End Property

        Public Property ViaAerea As String
            Get
                Return _ViaAerea
            End Get
            Set(value As String)
                _ViaAerea = value
            End Set
        End Property

        Public Property Posicion As String
            Get
                Return _Posicion
            End Get
            Set(value As String)
                _Posicion = value
            End Set
        End Property

        Public Property Complicaciones As String
            Get
                Return _Complicaciones
            End Get
            Set(value As String)
                _Complicaciones = value
            End Set
        End Property

        Public Property ResumenAnestesico As String
            Get
                Return _ResumenAnestesico
            End Get
            Set(value As String)
                _ResumenAnestesico = value
            End Set
        End Property

        Public Property IdEndoscopista As String
            Get
                Return _IdEndoscopista
            End Get
            Set(value As String)
                _IdEndoscopista = value
            End Set
        End Property

        Public Property AuxiliarAnestesia As String
            Get
                Return _AuxiliarAnestesia
            End Get
            Set(value As String)
                _AuxiliarAnestesia = value
            End Set
        End Property

        Public Property IdAnestesiologo As String
            Get
                Return _IdAnestesiologo
            End Get
            Set(value As String)
                _IdAnestesiologo = value
            End Set
        End Property

        Public Property IdOrden As String
            Get
                Return _IdOrden
            End Get
            Set(value As String)
                _IdOrden = value
            End Set
        End Property

        Public Property IdDetalleOrden As String
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As String)
                _IdDetalleOrden = value
            End Set
        End Property

        Public Property Observaciones As String
            Get
                Return _Observaciones
            End Get
            Set(value As String)
                _Observaciones = value
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


Namespace Modelo
    Public Class DetalleOrdenServicio
        Private _Id As Integer
        Private _Salon As String
        Private _Servicio As String
        Private _Descripcion As String
        Private _FechaServicio As Date
        Private _HoraInicio As Date
        Private _HoraFinal As Date
        Private _Cantidad As Integer
        Private _Valor As Double
        Private _IVA As Double
        Private _Descuento As Double
        Private _Estado As String
        Private _IdOrdenServicio As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Salon As String
            Get
                Return _Salon
            End Get
            Set(value As String)
                _Salon = value
            End Set
        End Property

        Public Property Servicio As String
            Get
                Return _Servicio
            End Get
            Set(value As String)
                _Servicio = value
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

        Public Property FechaServicio As Date
            Get
                Return _FechaServicio
            End Get
            Set(value As Date)
                _FechaServicio = value
            End Set
        End Property

        Public Property HoraInicio As Date
            Get
                Return _HoraInicio
            End Get
            Set(value As Date)
                _HoraInicio = value
            End Set
        End Property

        Public Property HoraFinal As Date
            Get
                Return _HoraFinal
            End Get
            Set(value As Date)
                _HoraFinal = value
            End Set
        End Property

        Public Property Cantidad As Integer
            Get
                Return _Cantidad
            End Get
            Set(value As Integer)
                _Cantidad = value
            End Set
        End Property

        Public Property Valor As Double
            Get
                Return _Valor
            End Get
            Set(value As Double)
                _Valor = value
            End Set
        End Property

        Public Property IVA As Double
            Get
                Return _IVA
            End Get
            Set(value As Double)
                _IVA = value
            End Set
        End Property

        Public Property Descuento As Double
            Get
                Return _Descuento
            End Get
            Set(value As Double)
                _Descuento = value
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

        Public Property IdOrdenServicio As String
            Get
                Return _IdOrdenServicio
            End Get
            Set(value As String)
                _IdOrdenServicio = value
            End Set
        End Property
    End Class

End Namespace

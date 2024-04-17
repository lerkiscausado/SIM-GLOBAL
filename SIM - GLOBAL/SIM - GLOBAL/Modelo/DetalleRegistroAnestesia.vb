Namespace Modelo
    Public Class DetalleRegistroAnestesia
        Private _Id As Integer
        Private _IdRegistroAnestesia As String
        Private _Hora As Date
        Private _O2 As String
        Private _Anestesia As String
        Private _FC As String 'Frecuencia Cardiaca
        Private _FR As String 'Frecuencia Respiratoria
        Private _Diuresis As String
        Private _TA As String 'Tensión Arterial
        Private _PVC As String
        Private _V As String
        Private _SATO As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdRegistroAnestesia As String
            Get
                Return _IdRegistroAnestesia
            End Get
            Set(value As String)
                _IdRegistroAnestesia = value
            End Set
        End Property

        Public Property Hora As Date
            Get
                Return _Hora
            End Get
            Set(value As Date)
                _Hora = value
            End Set
        End Property

        Public Property O2 As String
            Get
                Return _O2
            End Get
            Set(value As String)
                _O2 = value
            End Set
        End Property

        Public Property Anestesia As String
            Get
                Return _Anestesia
            End Get
            Set(value As String)
                _Anestesia = value
            End Set
        End Property

        Public Property FC As String
            Get
                Return _FC
            End Get
            Set(value As String)
                _FC = value
            End Set
        End Property

        Public Property FR As String
            Get
                Return _FR
            End Get
            Set(value As String)
                _FR = value
            End Set
        End Property

        Public Property Diuresis As String
            Get
                Return _Diuresis
            End Get
            Set(value As String)
                _Diuresis = value
            End Set
        End Property

        Public Property TA As String
            Get
                Return _TA
            End Get
            Set(value As String)
                _TA = value
            End Set
        End Property

        Public Property PVC As String
            Get
                Return _PVC
            End Get
            Set(value As String)
                _PVC = value
            End Set
        End Property

        Public Property V As String
            Get
                Return _V
            End Get
            Set(value As String)
                _V = value
            End Set
        End Property

        Public Property SATO As String
            Get
                Return _SATO
            End Get
            Set(value As String)
                _SATO = value
            End Set
        End Property
    End Class
End Namespace


Namespace Modelo
    Public Class CierreCaja
        Private _Id As Integer
        Private _Fecha As Date
        Private _Hora As Date
        Private _Saldo As Double
        Private _Observaciones As String
        Private _IdEmpleado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
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

        Public Property Hora As Date
            Get
                Return _Hora
            End Get
            Set(value As Date)
                _Hora = value
            End Set
        End Property

        Public Property Saldo As Double
            Get
                Return _Saldo
            End Get
            Set(value As Double)
                _Saldo = value
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

        Public Property IdEmpleado As String
            Get
                Return _IdEmpleado
            End Get
            Set(value As String)
                _IdEmpleado = value
            End Set
        End Property
    End Class

End Namespace

Namespace Modelo
    Public Class Temporal
        Private _IdOrden As Integer
        Private _nombre As String
        Private _idEmpleado As String

        Public Property IdOrden As Integer
            Get
                Return _IdOrden
            End Get
            Set(value As Integer)
                _IdOrden = value
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

        Public Property IdEmpleado As String
            Get
                Return _idEmpleado
            End Get
            Set(value As String)
                _idEmpleado = value
            End Set
        End Property
    End Class
End Namespace

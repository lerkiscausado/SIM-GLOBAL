Namespace Modelo
    Public Class RegistroAnestesiaMedicamentos
        Private _Id As Integer
        Private _IdRegistroAnestesia As String
        Private _IdMedicamento As String
        Private _Medicamento As String
        Private _Dosis As String

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

        Public Property IdMedicamento As String
            Get
                Return _IdMedicamento
            End Get
            Set(value As String)
                _IdMedicamento = value
            End Set
        End Property

        Public Property Medicamento As String
            Get
                Return _Medicamento
            End Get
            Set(value As String)
                _Medicamento = value
            End Set
        End Property

        Public Property Dosis As String
            Get
                Return _Dosis
            End Get
            Set(value As String)
                _Dosis = value
            End Set
        End Property
    End Class

End Namespace

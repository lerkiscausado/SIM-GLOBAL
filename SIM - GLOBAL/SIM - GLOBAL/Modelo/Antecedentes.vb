Namespace Modelo
    Public Class Antecedentes
        Private _idOrden As Integer
        Private _idUsuario As Integer
        Private _AntecedentesFamiliares As String
        Private _AntecedentesPersonales As String

        Public Property IdOrden As Integer
            Get
                Return _idOrden
            End Get
            Set(value As Integer)
                _idOrden = value
            End Set
        End Property

        Public Property IdUsuario As Integer
            Get
                Return _idUsuario
            End Get
            Set(value As Integer)
                _idUsuario = value
            End Set
        End Property

        Public Property AntecedentesFamiliares As String
            Get
                Return _AntecedentesFamiliares
            End Get
            Set(value As String)
                _AntecedentesFamiliares = value
            End Set
        End Property

        Public Property AntecedentesPersonales As String
            Get
                Return _AntecedentesPersonales
            End Get
            Set(value As String)
                _AntecedentesPersonales = value
            End Set
        End Property
    End Class
End Namespace


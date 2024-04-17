Namespace Modelo
    Public Class Informes
        Private _id As Integer
        Private _Nombre As String
        Private _Query As String
        Private _Estado As String

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
            End Set
        End Property

        Public Property Query As String
            Get
                Return _Query
            End Get
            Set(value As String)
                _Query = value
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

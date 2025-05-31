Namespace Modelo
    Public Class PlantillasPatologia
        Private _id As Integer
        Private _Nombre As String
        Private _Macro As String
        Private _Micro As String
        Private _Diagnostico As String
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

        Public Property Macro As String
            Get
                Return _Macro
            End Get
            Set(value As String)
                _Macro = value
            End Set
        End Property

        Public Property Micro As String
            Get
                Return _Micro
            End Get
            Set(value As String)
                _Micro = value
            End Set
        End Property

        Public Property Diagnostico As String
            Get
                Return _Diagnostico
            End Get
            Set(value As String)
                _Diagnostico = value
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

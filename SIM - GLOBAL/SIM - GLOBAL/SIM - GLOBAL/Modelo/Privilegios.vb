Namespace Modelo
    Public Class Privilegios
        Public Class Archivo
            Public Class OrdenesAtencion
                Private _Orden As Boolean
                Private _Consultar As Boolean
                Private _Agenda As Boolean
                Private _Adjuntos As Boolean

                Public Property Orden As Boolean
                    Get
                        Return _Orden
                    End Get
                    Set(value As Boolean)
                        _Orden = value
                    End Set
                End Property

                Public Property Consultar As Boolean
                    Get
                        Return _Consultar
                    End Get
                    Set(value As Boolean)
                        _Consultar = value
                    End Set
                End Property

                Public Property Agenda As Boolean
                    Get
                        Return _Agenda
                    End Get
                    Set(value As Boolean)
                        _Agenda = value
                    End Set
                End Property

                Public Property Adjuntos As Boolean
                    Get
                        Return _Adjuntos
                    End Get
                    Set(value As Boolean)
                        _Adjuntos = value
                    End Set
                End Property
            End Class
        End Class
    End Class
End Namespace


Namespace My.Modelo
    Public Class Citologia
        Private _Id As Integer
        Private _IdOrden As Integer
        Private _Fecha As Date
        Private _CM1 As String
        Private _CM2 As String
        Private _CM3 As String
        Private _CM4 As String
        Private _CM5 As String
        Private _CG1 As String
        Private _CG2 As String
        Private _M1 As String
        Private _M2 As String
        Private _M3 As String
        Private _M4 As String
        Private _M5 As String
        Private _M6 As String
        Private _OHNN1 As String
        Private _OHNN2 As String
        Private _OHNN3 As String
        Private _OHNN4 As String
        Private _OHNN5 As String
        Private _OHNN6 As String
        Private _ACE1 As String
        Private _ACE2 As String
        Private _ACE3 As String
        Private _ACE4 As String
        Private _ACE5 As String
        Private _ACG1 As String
        Private _ACG2 As String
        Private _ACG3 As String
        Private _ACG4 As String
        Private _ACG5 As String
        Private _ACG6 As String
        Private _ACG7 As String
        Private _ACG8 As String
        Private _FB1 As String
        Private _FB2 As String
        Private _FB3 As String
        Private _I1 As String
        Private _I2 As String
        Private _I3 As String
        Private _observaciones As String
        Private _Diagnostico As String
        Private _Img1 As String
        Private _Img2 As String
        Private _IdEmpleado As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IdOrden As Integer
            Get
                Return _IdOrden
            End Get
            Set(value As Integer)
                _IdOrden = value
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

        Public Property CM1 As String
            Get
                Return _CM1
            End Get
            Set(value As String)
                _CM1 = value
            End Set
        End Property

        Public Property CM2 As String
            Get
                Return _CM2
            End Get
            Set(value As String)
                _CM2 = value
            End Set
        End Property

        Public Property CM3 As String
            Get
                Return _CM3
            End Get
            Set(value As String)
                _CM3 = value
            End Set
        End Property

        Public Property CG1 As String
            Get
                Return _CG1
            End Get
            Set(value As String)
                _CG1 = value
            End Set
        End Property

        Public Property CG2 As String
            Get
                Return _CG2
            End Get
            Set(value As String)
                _CG2 = value
            End Set
        End Property

        Public Property FB1 As String
            Get
                Return _FB1
            End Get
            Set(value As String)
                _FB1 = value
            End Set
        End Property

        Public Property FB2 As String
            Get
                Return _FB2
            End Get
            Set(value As String)
                _FB2 = value
            End Set
        End Property

        Public Property FB3 As String
            Get
                Return _FB3
            End Get
            Set(value As String)
                _FB3 = value
            End Set
        End Property



        Public Property OHNN1 As String
            Get
                Return _OHNN1
            End Get
            Set(value As String)
                _OHNN1 = value
            End Set
        End Property

        Public Property OHNN2 As String
            Get
                Return _OHNN2
            End Get
            Set(value As String)
                _OHNN2 = value
            End Set
        End Property

        Public Property OHNN3 As String
            Get
                Return _OHNN3
            End Get
            Set(value As String)
                _OHNN3 = value
            End Set
        End Property

        Public Property OHNN4 As String
            Get
                Return _OHNN4
            End Get
            Set(value As String)
                _OHNN4 = value
            End Set
        End Property

        Public Property OHNN5 As String
            Get
                Return _OHNN5
            End Get
            Set(value As String)
                _OHNN5 = value
            End Set
        End Property

        Public Property OHNN6 As String
            Get
                Return _OHNN6
            End Get
            Set(value As String)
                _OHNN6 = value
            End Set
        End Property

        Public Property ACE1 As String
            Get
                Return _ACE1
            End Get
            Set(value As String)
                _ACE1 = value
            End Set
        End Property

        Public Property ACE2 As String
            Get
                Return _ACE2
            End Get
            Set(value As String)
                _ACE2 = value
            End Set
        End Property

        Public Property ACE3 As String
            Get
                Return _ACE3
            End Get
            Set(value As String)
                _ACE3 = value
            End Set
        End Property

        Public Property ACE4 As String
            Get
                Return _ACE4
            End Get
            Set(value As String)
                _ACE4 = value
            End Set
        End Property

        Public Property ACE5 As String
            Get
                Return _ACE5
            End Get
            Set(value As String)
                _ACE5 = value
            End Set
        End Property

        Public Property ACG1 As String
            Get
                Return _ACG1
            End Get
            Set(value As String)
                _ACG1 = value
            End Set
        End Property

        Public Property ACG2 As String
            Get
                Return _ACG2
            End Get
            Set(value As String)
                _ACG2 = value
            End Set
        End Property

        Public Property ACG3 As String
            Get
                Return _ACG3
            End Get
            Set(value As String)
                _ACG3 = value
            End Set
        End Property

        Public Property ACG4 As String
            Get
                Return _ACG4
            End Get
            Set(value As String)
                _ACG4 = value
            End Set
        End Property

        Public Property ACG5 As String
            Get
                Return _ACG5
            End Get
            Set(value As String)
                _ACG5 = value
            End Set
        End Property

        Public Property ACG6 As String
            Get
                Return _ACG6
            End Get
            Set(value As String)
                _ACG6 = value
            End Set
        End Property

        Public Property ACG7 As String
            Get
                Return _ACG7
            End Get
            Set(value As String)
                _ACG7 = value
            End Set
        End Property

        Public Property ACG8 As String
            Get
                Return _ACG8
            End Get
            Set(value As String)
                _ACG8 = value
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

        Public Property Img1 As String
            Get
                Return _Img1
            End Get
            Set(value As String)
                _Img1 = value
            End Set
        End Property

        Public Property Img2 As String
            Get
                Return _Img2
            End Get
            Set(value As String)
                _Img2 = value
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

        Public Property M1 As String
            Get
                Return _M1
            End Get
            Set(value As String)
                _M1 = value
            End Set
        End Property

        Public Property M2 As String
            Get
                Return _M2
            End Get
            Set(value As String)
                _M2 = value
            End Set
        End Property

        Public Property M3 As String
            Get
                Return _M3
            End Get
            Set(value As String)
                _M3 = value
            End Set
        End Property

        Public Property M4 As String
            Get
                Return _M4
            End Get
            Set(value As String)
                _M4 = value
            End Set
        End Property

        Public Property M5 As String
            Get
                Return _M5
            End Get
            Set(value As String)
                _M5 = value
            End Set
        End Property

        Public Property M6 As String
            Get
                Return _M6
            End Get
            Set(value As String)
                _M6 = value
            End Set
        End Property

        Public Property I1 As String
            Get
                Return _I1
            End Get
            Set(value As String)
                _I1 = value
            End Set
        End Property

        Public Property I2 As String
            Get
                Return _I2
            End Get
            Set(value As String)
                _I2 = value
            End Set
        End Property

        Public Property I3 As String
            Get
                Return _I3
            End Get
            Set(value As String)
                _I3 = value
            End Set
        End Property

        Public Property Observaciones As String
            Get
                Return _observaciones
            End Get
            Set(value As String)
                _observaciones = value
            End Set
        End Property

        Public Property CM4 As String
            Get
                Return _CM4
            End Get
            Set(value As String)
                _CM4 = value
            End Set
        End Property

        Public Property CM5 As String
            Get
                Return _CM5
            End Get
            Set(value As String)
                _CM5 = value
            End Set
        End Property
    End Class

End Namespace

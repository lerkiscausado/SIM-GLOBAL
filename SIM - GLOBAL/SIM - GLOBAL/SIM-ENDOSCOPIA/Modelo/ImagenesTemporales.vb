Imports DevExpress.XtraEditors

Namespace Modelo
    Public Class ImagenesTemporales
        Private _Id As Integer
        Private _IdDetalleOrden As String
        Private _Imagen As Image
        Private _prueba As PictureEdit



        Public Property IdDetalleOrden As String
            Get
                Return _IdDetalleOrden
            End Get
            Set(value As String)
                _IdDetalleOrden = value
            End Set
        End Property

        Public Property Imagen As Image
            Get
                Return _Imagen
            End Get
            Set(value As Image)
                _Imagen = value
            End Set
        End Property

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property Prueba As PictureEdit
            Get
                Return _prueba.EditValue
            End Get
            Set(value As PictureEdit)
                _prueba = value
            End Set
        End Property
    End Class
End Namespace

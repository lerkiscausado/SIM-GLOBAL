Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Public Class frmVisorImagenes
    Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenesGlobal
    Dim _Imagenes As GalleryItemGroup = New GalleryItemGroup()
    Dim _ds As DataSet
    Public IdDetalleOrden As String
    Private Sub frmVisorImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '_Imagenes.Items.Clear()
        'isImagenes.Gallery.Groups.Clear()
        isImagenes.Images.Clear()
        _ds = New DataSet
        _ds = _dImagenes.ListarImagenesActivasIC(IdDetalleOrden)
        If _ds.Tables(0).Rows.Count <> 0 Then
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                isImagenes.Images.Add(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString))
                '_Imagenes.Items.Add(zem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, ""))
            Next

            ''isImagenes.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            'gcCapturas.Gallery.ImageSize = New Size(120, 90)
            'gcCapturas.Gallery.Groups.Add(_Imagenes)
            'isImagenes.Images.Add()

            'Dim mySlider As ImageSlider = New ImageSlider()
            ' isImagenes.Parent = Me
            ' isImagenes.Size = New Size(240, 200)

            'Increase image sliding animation duration (default is 700 ms) 
            'isImagenes.AnimationTime = 1200

            'Display images at the center of ImageSlider in their original size 
            'isImagenes.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter
            '... 
            'Slide to the next image 
            'isImagenes.SlideNext()


        End If

    End Sub

End Class
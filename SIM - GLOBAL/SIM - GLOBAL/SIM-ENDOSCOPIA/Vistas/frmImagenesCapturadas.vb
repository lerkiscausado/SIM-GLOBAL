Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing


Public Class frmImagenesCapturadas
    Dim item As GalleryItem
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickGrillaEliminar As String
    Public _idDetalleOrden As String
    Dim _DImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
    Dim _Seleccionadas As GalleryItemGroup = New GalleryItemGroup()
    Dim TextoImagen As String
    Dim Imagen As Image
    Private Sub CargarImagenes(ByVal Filtro As String)

        'Dim _dImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes

        _ds = New DataSet
        _ds = _DImagenes.ListarImagenes(Filtro)
        If _ds.Tables(0).Rows.Count <> 0 Then
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, ""))
            Next
            gcCapturadas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcCapturadas.Gallery.ImageSize = New Size(120, 90)
            gcCapturadas.Gallery.Groups.Add(_Capturas)
        End If
    End Sub
    Private Sub GaleriaImagenesSeleccionadas()

        _ds = New DataSet
        _ds = _DImagenes.ListarImagenesActivasIC(_idDetalleOrden)
        If _ds.Tables(0).Rows.Count <> 0 Then
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                _Seleccionadas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
            Next
            gcSeleccionadas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcSeleccionadas.Gallery.ImageSize = New Size(120, 90)
            gcSeleccionadas.Gallery.Groups.Add(_Seleccionadas)
        End If
    End Sub

    Private Sub frmImagenesCapturadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImagenes(_idDetalleOrden)
        GaleriaImagenesSeleccionadas()
    End Sub

    Private Sub gcCapturadas_Gallery_ItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcCapturadas.Gallery.ItemClick
        _ClickGrilla = e.Item.Caption
        Imagen = e.Item.ImageOptions.Image
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado una imagen", "Selección de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DImagenes.ExisteImagenSeleccionada(_clickgrilla) = True Then
            MessageBox.Show("La imagen seleccionada ya fue agregada", "Selección de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DImagenes.ContarImagenesSeleccionadas(_idDetalleOrden) >= 9 Then
            MessageBox.Show("Solo se admiten ocho (9) imagenes.", "Selección de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _seleccionadas.Items.Clear()
            gcSeleccionadas.Gallery.Groups.Clear()
            _DImagenes.ActualizarEstadoImagen(_ClickGrilla, "A", TextoImagen, Imagen)
            peImagen.Image = Imagen
            GaleriaImagenesSeleccionadas()
        End If
    End Sub

    Private Sub gcSeleccionadas_Gallery_ItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcSeleccionadas.Gallery.ItemClick
        _ClickGrillaEliminar = e.Item.Caption
        peImagen.Image = e.Item.ImageOptions.Image

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If _ClickGrillaEliminar = "" Then
            MessageBox.Show("No ha Seleccionado una imagen", "Selección de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _Seleccionadas.Items.Clear()
            gcSeleccionadas.Gallery.Groups.Clear()
            _DImagenes.ActualizarEstadoImagen(_ClickGrillaEliminar, "I", "", Imagen)
            'peImagen.Image = Nothing
            GaleriaImagenesSeleccionadas()
            peImagen.Image = Nothing
            _ClickGrillaEliminar = ""
        End If
    End Sub

    Private Sub gcSeleccionadas_Gallery_ItemDoubleClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcSeleccionadas.Gallery.ItemDoubleClick
        Dim _frmOpen As New SIM_ENDOSCOPIA.frmTextoImagenes
        _frmOpen.txtTexoImagenes.Text = e.Item.Description
        _frmOpen.IdImagen = e.Item.Caption
        _frmOpen.ShowDialog()
        _Seleccionadas.Items.Clear()
        gcSeleccionadas.Gallery.Groups.Clear()
        GaleriaImagenesSeleccionadas()
    End Sub
End Class
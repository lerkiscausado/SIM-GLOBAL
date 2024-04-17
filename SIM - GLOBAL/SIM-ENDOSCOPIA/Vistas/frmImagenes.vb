Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Public Class frmImagenes
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    'Dim _Endoscopia As New SIM_ENDOSCOPIA.Modelo.Endoscopia
    'Dim _DEndoscopia As New SIM_ENDOSCOPIA.Controles.DEndoscopia
    Dim _Imagenes As New SIM_ENDOSCOPIA.Modelo.Imagenes
    Dim _dImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
    Dim _ImagenesTemporales As New SIM_ENDOSCOPIA.Modelo.ImagenesTemporales
    Dim _DimagenesTemporales As New SIM_ENDOSCOPIA.Controles.DImagenesTemporales
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickEstudio As String
    Dim _Fila As String
    Dim _NombreImagen As Integer = 1
    Dim _dtImagenes As DataTable

    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()

    Private Sub CargarImagenes(ByVal Filtro As String)
        Dim _dImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
        _Capturas.Items.Clear()
        gcCapturas.Gallery.Groups.Clear()
        _ds = New DataSet
        _ds = _dImagenes.ListarImagenesPaciente(Filtro)
        If _ds.Tables(0).Rows.Count <> 0 Then
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, ""))
            Next
            gcCapturas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcCapturas.Gallery.ImageSize = New Size(120, 90)
            gcCapturas.Gallery.Groups.Add(_Capturas)

        End If
    End Sub
    Function imgtoarr(ByVal URLimagen As String) As Byte()
        Dim img As Image = Image.FromFile(URLimagen)
        Dim ms As New System.IO.MemoryStream
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        'Dim Captura As Image
        peImagen.EditValue = ccCamara.TakeSnapshot

    End Sub
    Private Sub LimpiarCampos()
        '***************** ELIMINAMOS IMAGENES TEMPORALES **************
        _DimagenesTemporales.Eliminar(lblIdDetalleOrden.Text)
        'Limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        lblIdDetalleOrden.Text = ""
        txtDatosUsuario.Text = ""
        txtEstudio.Text = ""

        _Capturas.Items.Clear()
        gcCapturas.Gallery.Groups.Clear()

        '************ actualizamos la grilla de imagenes
        '_ds = New DataSet
        '_ds = _DimagenesTemporales.Listar(lblIdDetalleOrden.Text)
        'gcImagenes.DataSource = _ds.Tables(0)

        _NombreImagen = 1
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesImagenesEndoscopia()
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub

    Private Sub Nuevo()
        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        txtEstudio.Text = _ClickEstudio

        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")
        '******* Traemos la Orden ******************
        _Ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        '********* ACTIVAMOS GUARDAR ************
        'CargarImagenes(_ClickIdDetalleOrden)
        bbiGuardar.Enabled = True
    End Sub
    Private Sub frmImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        _DimagenesTemporales.LimpiarTabla()
        'peImagen.Image = Image.FromFile("prueba.jpg")
        '_dtImagenes.Columns.Add("RUTA", GetType(Byte()))
        '_dtImagenes.Rows.Add(imgtoarr("prueba.jpg"))
        'gcImagenes.DataSource = _dtImagenes

        _Capturas.Caption = "Imagenes Capturadas"

    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado el paciente para Capturar las imagenes", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickIdDetalleOrden = lblIdDetalleOrden.Text Then
            MessageBox.Show("El Paciente ya se encuentra Seleccionado", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If gcCapturas.Gallery.Groups.Count <> 0 Then
                If MessageBox.Show("Actualmente se esta realizando un Esudio, ¿Desea Finalizarlo y Realizar uno Nuevo?", "Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    LimpiarCampos()
                    Nuevo()
                End If
            Else
                LimpiarCampos()
                Nuevo()
            End If

        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If _NombreImagen = 50 Then
            MessageBox.Show("Excedio el numero de captura de imagenes (50)", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                'Guardamos detalle Imagen en DB
                _Imagenes.IdOrden = lblConsecutivoOrden.Text
                _Imagenes.IdDetalleOrden = lblIdDetalleOrden.Text
                _Imagenes.Ruta = "x:\\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"
                _Imagenes.Texto = "Imagen" & _NombreImagen
                _Imagenes.Estado = "I"
                _dImagenes.Guardar(_Imagenes)


                'GUARDAMOS LA IMAGEN EN FISICO
                peImagen.EditValue = ccCamara.TakeSnapshot
                peImagen.Image.Save("x:\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg")

                'CargarImagenes(lblIdDetalleOrden.Text)
                'LLENAMOS GALERY CONTROL
                '--------------------------------------------------------------------------------------------
                _Capturas.Items.Add(New GalleryItem(Image.FromFile("x:\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"), _Imagenes.IdDetalleOrden & _NombreImagen, ""))

                gcCapturas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
                gcCapturas.Gallery.ImageSize = New Size(120, 90)
                gcCapturas.Gallery.Groups.Add(_Capturas)

                _NombreImagen = _NombreImagen + 1
                '-----------------------------------------------------------------------------------------------
            Catch ex As Exception
                MessageBox.Show("Por favor verifique la conexión de la unidad de red", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub frmImagenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' If gvImagenes.RowCount <> 0 Then
        ' If MessageBox.Show("Actualmente se esta realizando un Esudio, ¿Desea Finalizarlo y Cerrar el Formulario?", "Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
        '
        '        LimpiarCampos()
        '        Nuevo()
        '        e.Cancel = False
        '        Else
        '        e.Cancel = True
        '        End If
        '        Else
        '       e.Cancel = False
        '       End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

End Class
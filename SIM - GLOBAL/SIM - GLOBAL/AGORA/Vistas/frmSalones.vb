Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Public Class frmSalones
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _ClickIdSalon As String
    Dim _Fila As Integer
    Dim _ClickGrillaFoto As String
    Dim FotosSalon As GalleryItemGroup = New GalleryItemGroup()
    Dim _DSalones As New AGORA.Controles.DSalones
    Dim _Salones As New AGORA.Modelo.Salones
    Dim _DetalleSalon As New AGORA.Modelo.DetalleSalon
    Dim _DDetalleSalon As New AGORA.Controles.DDetalleSalon
    Dim _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Private Sub LimpiarCampos()

        If txtID.Text = "" And _DDetalleSalon.Existe(_Id.ToString) = True Then
            _DDetalleSalon.EliminarFotosSalon(_Id.ToString)
        End If

        txtID.Text = Nothing
        txtSalon.Text = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        _ClickIdSalon = Nothing
        peFoto.Image = Nothing
        FotosSalon.Items.Clear()
        gcFotos.Gallery.Groups.Clear()

        _Id = Guid.NewGuid()
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DSalones.Listar
        gcConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Guardar()
        Try
            _Salones.Id = Val(txtID.Text)
            _Salones.Nombre = txtSalon.Text
            If chkEstado.Checked = True Then
                _Salones.Estado = "A"
            Else
                _Salones.Estado = "I"
            End If
            _DSalones.Guardar(_Salones)

            bbiGuardar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GaleriaFotosSeleccionadas()
        _ds = New DataSet
        If txtID.Text <> "" Then
            _ds = _DDetalleSalon.ListarImagenes(Val(txtID.Text))
        Else
            _ds = _DDetalleSalon.ListarImagenes(_Id.ToString)
        End If
        If _ds.Tables(0).Rows.Count <> 0 Then
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                FotosSalon.Items.Add(New GalleryItem(_funciones.Bytes_Imagen(_ds.Tables(0).Rows(x - 1)(0)), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
            Next
            gcFotos.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcFotos.Gallery.ImageSize = New Size(120, 90)
            gcFotos.Gallery.Groups.Add(FotosSalon)
        End If
    End Sub
    Private Sub GuardarDetalleSalon()
        If txtID.Text <> "" Then
            _DetalleSalon.IdSalon = Val(txtID.Text)
        Else
            _DetalleSalon.IdSalon = _Id.ToString
        End If
        _DetalleSalon.Descripcion = txtDescripcion.Text
        _DetalleSalon.Foto = _funciones.Imagen_Bytes(peFoto.EditValue)
        _DetalleSalon.Estado = "A"
        _DDetalleSalon.Guardar(_DetalleSalon)
    End Sub
    Private Sub EditarSalon()
        If MessageBox.Show("Desea editar el salon?", "Editar Salon",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            _Salones = _DSalones.Cargar(_ClickIdSalon)
            txtID.Text = _ClickIdSalon
            txtSalon.Text = _Salones.Nombre
            If _Salones.Estado = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
            bbiGuardar.Enabled = False
        End If
    End Sub
    Private Sub frmSalones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Id = Guid.NewGuid()
        chkEstado.Checked = True
        ActualizarGrilla()
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtSalon.Text = "" Then
            MessageBox.Show("El Campo Salon es Obligatorio", "Registro de Salones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            If txtID.Text = "" And _DDetalleSalon.Existe(_Id.ToString) = True Then
                _Salones = _DSalones.UltimoRegistro()
                _DDetalleSalon.ActualizarDetalleSalon(_Salones.Id, _Id.ToString)
            End If
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdSalon = "" Then
            MessageBox.Show("No ha seleccionado el salon", "Registro de Salones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarSalon()
            FotosSalon.Items.Clear()
            gcFotos.Gallery.Groups.Clear()
            GaleriaFotosSeleccionadas()
        End If
    End Sub

    Private Sub txtSalon_EditValueChanged(sender As Object, e As EventArgs) Handles txtSalon.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdSalon = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDescripcion.Text = "" Then
            MessageBox.Show("La descripción es obligatoria", "Registro de Salones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            FotosSalon.Items.Clear()
            gcFotos.Gallery.Groups.Clear()
            GuardarDetalleSalon()
            GaleriaFotosSeleccionadas()
            txtDescripcion.Text = Nothing
            peFoto.Image = Nothing
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If _ClickGrillaFoto = "" Then
            MessageBox.Show("Debe seleccionar la imagen a eliminar", "Eliminar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            FotosSalon.Items.Clear()
            gcFotos.Gallery.Groups.Clear()
            _DDetalleSalon.EliminarFoto(_ClickGrillaFoto)
            GaleriaFotosSeleccionadas()
            peImagen.Image = Nothing
            _ClickGrillaFoto = ""
        End If

    End Sub

    Private Sub gcFotos_Gallery_ItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcFotos.Gallery.ItemClick
        _ClickGrillaFoto = e.Item.Caption
        peImagen.Image = e.Item.ImageOptions.Image
    End Sub

    Private Sub frmSalones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If txtID.Text = "" And _DDetalleSalon.Existe(_Id.ToString) = True Then
            _DDetalleSalon.EliminarFotosSalon(_Id.ToString)
        End If
    End Sub
End Class
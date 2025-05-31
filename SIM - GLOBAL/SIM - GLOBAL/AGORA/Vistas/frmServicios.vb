Public Class frmServicios
    Dim _DServivios As New AGORA.Controles.DServicios
    Dim _Servicios As New AGORA.Modelo.Servicios
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Private Sub LimpiarCampos()
        lblId.Text = Nothing
        txtServicio.Text = Nothing
        txtDescripcion.Text = Nothing
        txtValor.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        Try
            _Servicios.Id = Val(lblId.Text)
            _Servicios.NombreServicio = txtServicio.Text
            _Servicios.Descripcion = txtDescripcion.Text
            _Servicios.Valor = Val(txtValor.EditValue)
            If chkEstado.Checked = True Then
                _Servicios.Estado = "A"
            Else
                _Servicios.Estado = "I"
            End If
            _DServivios.Guardar(_Servicios)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DServivios.Listar()
        gcConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        lblId.Text = Nothing
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el registro", "Registro de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If MessageBox.Show("Desea Editar el Registro?", "Registro de Servicios",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Servicios = _DServivios.Cargar(_ClickGrilla)
                lblID.Text = _ClickGrilla
                txtServicio.Text = _Servicios.NombreServicio
                txtDescripcion.Text = _Servicios.Descripcion
                txtValor.Text = _Servicios.Valor
                If _Servicios.Estado = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub txtServicio_EditValueChanged(sender As Object, e As EventArgs) Handles txtServicio.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtValor_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtServicio.Text = "" Then
            MessageBox.Show("El Campo Servicio es obligatorio", "Registro de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("El Campo Descripción es obligatorio", "Registro de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub txtValor_EditValueChanged_1(sender As Object, e As EventArgs) Handles txtValor.EditValueChanged
        ActivarGuardar()
    End Sub
End Class
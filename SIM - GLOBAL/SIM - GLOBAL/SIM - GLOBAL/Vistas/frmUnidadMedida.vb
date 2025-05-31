
Public Class frmUnidadMedida
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dUnidadMedida As New SIM___GLOBAL.Controles.DUnidadMedida
    Dim _UnidadMedida As New SIM___GLOBAL.Modelo.UnidadMedida
    'Dim _DUnidadMedida As New SIM___GLOBAL.Controles.DUnidadMedida
    Private Sub Guardar()
        Try
            _UnidadMedida.Id = txtID.Text
            _UnidadMedida.Nombre = txtUnidadMedida.Text
            If chkEstado.Checked = True Then
                _UnidadMedida.Estado = "A"
            Else
                _UnidadMedida.Estado = "I"
            End If
            _dUnidadMedida.Guardar(_UnidadMedida)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtID.Enabled = True
        txtID.Text = ""
        txtUnidadMedida.Text = ""
        chkEstado.Checked = False
        bbiGuardar.Enabled = False
        txtUnidadMedida.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dUnidadMedida.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmUnidadMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtUnidadMedida.Text = "" Then
            MessageBox.Show("El Campo Nombre Es Obligatorio", "Registro de Unidad Medida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el Registro", "Unidad de Medida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Editar el Registro ?", "Editar Registros ",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then

                txtID.Text = _ClickGrilla
                txtUnidadMedida.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "INACTIVO" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
                txtUnidadMedida.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtUnidadMedida_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnidadMedida.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        GVConsultar.ShowPrintPreview()
    End Sub
End Class
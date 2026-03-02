Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Controles

Public Class frmCups

    ' ─────────────────────────────────────────────
    ' VARIABLES
    ' ─────────────────────────────────────────────
    Dim _ds As DataSet
    Dim _ClickGrilla As String = String.Empty
    Dim _Fila As Integer = -1
    Dim _DCups As New SIM___GLOBAL.Controles.DCups

    ' ─────────────────────────────────────────────
    ' GUARDAR
    ' ─────────────────────────────────────────────
    Private Sub Guardar()
        Try
            Dim _Cups As New Cups
            _Cups.Id = txtCodigo.Text.Trim()
            _Cups.Nombre = txtNombre.Text.Trim()
            _Cups.Estado = If(chkEstado.Checked, "A", "I") ' ✅ simplificado

            _DCups.Guardar(_Cups) ' ✅ usa la instancia de clase, no crea una nueva
        Catch ex As Exception
            ' ✅ Notifica al usuario en lugar de silenciar el error
            MessageBox.Show($"Error al guardar el registro: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    ' LIMPIAR CAMPOS
    ' ─────────────────────────────────────────────
    Private Sub LimpiarCampos()
        txtCodigo.Enabled = True
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        chkEstado.Checked = False
        bbiGuardar.Enabled = False
        _ClickGrilla = String.Empty
        _Fila = -1
    End Sub

    ' ─────────────────────────────────────────────
    ' EDITAR CAMPOS
    ' ─────────────────────────────────────────────
    Private Sub EditarCampos()
        If MessageBox.Show("¿Desea editar el registro?", "Editar Registros",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtCodigo.Enabled = False
            txtCodigo.Text = _ClickGrilla
            txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "CUPS").ToString()
            chkEstado.Checked = GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() <> "I" ' ✅ simplificado
            bbiGuardar.Enabled = True ' ✅ debería habilitarse al editar
        End If
    End Sub

    ' ─────────────────────────────────────────────
    ' ACTUALIZAR GRILLA
    ' ─────────────────────────────────────────────
    Private Sub ActualizarGrilla()
        _ds = _DCups.Listar() ' ✅ eliminada la doble asignación
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub frmCups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
    End Sub

    ' ─────────────────────────────────────────────
    ' BOTONES TOOLBAR
    ' ─────────────────────────────────────────────
    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If String.IsNullOrEmpty(_ClickGrilla) Then ' ✅ comparación correcta
            MessageBox.Show("No ha seleccionado el procedimiento.", "Registro de CUPS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarCampos()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        ' ✅ Mensajes corregidos — ahora corresponden al campo que validan
        If String.IsNullOrWhiteSpace(txtCodigo.Text) Then
            MessageBox.Show("El campo Código es obligatorio.", "Registro de CUPS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Registro de CUPS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        ' ✅ Simplificado con NOT
        GVConsultar.OptionsFind.AlwaysVisible = Not GVConsultar.OptionsFind.AlwaysVisible
    End Sub

    ' ─────────────────────────────────────────────
    ' GRILLA — CLICK Y DOBLE CLICK
    ' ─────────────────────────────────────────────
    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _Fila = e.RowHandle  ' ✅ asigna Integer directamente, sin .ToString
            _ClickGrilla = GVConsultar.GetRowCellValue(_Fila, "ID").ToString()
        End If
    End Sub

    Private Sub GCConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GCConsultar.DoubleClick ' ✅ agregado Handles
        If Not String.IsNullOrEmpty(_ClickGrilla) Then
            EditarCampos()
        End If
    End Sub

    ' ─────────────────────────────────────────────
    ' EVENTOS DE CAMPOS
    ' ─────────────────────────────────────────────
    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If Not String.IsNullOrWhiteSpace(txtCodigo.Text) Then
            If _DCups.Existe(txtCodigo.Text.Trim()) Then ' ✅ usa instancia de clase
                MessageBox.Show("El código ya ha sido registrado.", "Registro de CUPS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigo.Text = String.Empty
                txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigo.EditValueChanged
        ' ✅ También habilita guardar al escribir el código
        bbiGuardar.Enabled = True
    End Sub

End Class
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmCups
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _DCups As New SIM___GLOBAL.Controles.DCups
    Private Sub Guardar()
        Try
            Dim _dcups As New DCups
            Dim _Cups As New Cups
            _Cups.Id = txtCodigo.Text
            _Cups.Nombre = txtNombre.Text
            If chkEstado.Checked = True Then
                _Cups.Estado = "A"
            Else
                _Cups.Estado = "I"
            End If
            _dcups.Guardar(_Cups)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = False
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If MessageBox.Show("Desea Editar el Registro ?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            txtCodigo.Enabled = False
            txtCodigo.Text = _ClickGrilla
            txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "CUPS").ToString()
            If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
            bbiGuardar.Enabled = False
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DCups.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el procedimiento", "Registro de Cups", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarCampos()
        End If

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Codigo Es Obligatorio", "Registro de Cups", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCodigo.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Cups", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub frmCups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        'TODO: esta línea de código carga datos en la tabla 'DSCups1.DTCups' Puede moverla o quitarla según sea necesario.
        'Me.DTCupsTableAdapter.Fill(Me.DSCups1.DTCups)
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
    End Sub

    Private Sub GCConsultar_DoubleClick(sender As Object, e As EventArgs)
        EditarCampos()
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        Dim _DCups As New DCups
        If _DCups.Existe(txtCodigo.Text) = True Then
            MessageBox.Show("El Codigo ya ha sido registrado", "Registro de CUPS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Text = ""
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub GVConsultar_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigo.EditValueChanged

    End Sub
End Class
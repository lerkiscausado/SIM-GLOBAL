Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo

Public Class FrmEntidades
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dEntidades As New DEntidades
    Dim _Entidades As New Entidades

    Private Sub Guardar()
        Try

            _Entidades.CodigoEntidad = txtCodigo.Text
            _Entidades.NombreEntidad = txtNombre.Text
            _Entidades.Nit = txtNit.Text
            _Entidades.Direccion = txtDireccion.Text
            If chkEstado.Checked = True Then
                _Entidades.Estado = "A"
            Else
                _Entidades.Estado = "I"
            End If
            _dEntidades.Guardar(_Entidades)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        txtNombre.Enabled = True
        txtNombre.Text = ""
        txtNit.Text = ""
        txtDireccion.Text = ""
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado la entidad", "Registro de Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                txtCodigo.Enabled = False
                txtNombre.Enabled = False
                txtCodigo.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "ENTIDAD").ToString()
                txtNit.Text = GVConsultar.GetRowCellValue(_Fila, "NIT").ToString()
                txtDireccion.Text = GVConsultar.GetRowCellValue(_Fila, "DIRECCION").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dEntidades.Listar
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub

    Private Sub FrmEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtCodigo.Text = "" Then
            MessageBox.Show("El Campo Codigo es Obligatorio", "Registro de Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()

        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        EditarCampos()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "CODIGO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        EditarCampos()
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        Dim _dEntidades As New DEntidades
        If _dEntidades.Existe(txtCodigo.Text) = True Then
            MessageBox.Show("El Codigo ya ha sido registrado", "Registro de Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Text = ""
        End If
    End Sub
    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtNit_EditValueChanged(sender As Object, e As EventArgs) Handles txtNit.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDireccion.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub GVConsultar_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "CODIGO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
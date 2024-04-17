Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmEmpleados
    Dim _ds As DataSet
    Dim _dEmpleados = New DEmpleados
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _Empleados As New Empleados
    Dim _dCargos = New DCargos
    Dim _dEspecialidades = New DEspecialidades
    Dim _Especialista = New SIM___GLOBAL.Modelo.Especialista
    Dim _DEspecialista = New SIM___GLOBAL.Controles.DEspecialista
    Private Sub Guardar()
        _Empleados.Id = Val(txtID.Text)
        _Empleados.NombreEmpleado = txtNombre.Text
        _Empleados.IdCargo = cboCargo.GetColumnValue("ID")
        _Empleados.IdEspecialidad = 13
        _Empleados.RegistroMedico = ""
        If chkEstado.Checked = True Then
            _Empleados.Estado = "A"
        Else
            _Empleados.Estado = "I"

        End If
        _dEmpleados.Guardar(_Empleados)

    End Sub
    Private Sub ActivarGuardar()
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dEmpleados.Listaragora
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        'llenamos campo Cargos
        _ds = New DataSet()
        _ds = _dCargos.ListarCombo()
        cboCargo.Properties.DataSource = _ds.Tables(0)
        cboCargo.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboCargo.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboCargo.ItemIndex = -1

        bbiGuardar.Enabled = False
        chkEstado.Checked = True

    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        cboCargo.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub
    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboCargo.Text = "" Then
            MessageBox.Show("Debe seleccionar el cargo", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub
    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el empleado", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                If MessageBox.Show("Desea Editar el Empleado?", "Editar Registros ",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.Yes Then
                    'txtCodigo.Enabled = False
                    _Empleados = _dEmpleados.Cargar(_ClickGrilla)
                    txtID.Text = _ClickGrilla
                    txtNombre.Text = _Empleados.NombreEmpleado
                    cboCargo.ItemIndex = cboCargo.Properties.GetDataSourceRowIndex("ID", _Empleados.IdCargo)
                    If _Empleados.Estado = "I" Then
                        chkEstado.Checked = False
                    Else
                        chkEstado.Checked = True
                    End If
                    bbiGuardar.Enabled = False
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub
    Private Sub cboCargo_EditValueChanged(sender As Object, e As EventArgs) Handles cboCargo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboEspecialidad_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub txtRegistroMedico_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub


End Class
Imports SIM___GLOBAL.Controles
Public Class frmEmpleados
    Dim _Empleados As New PEC___App.Modelo.Empleados
    Dim _DEmpleados As New PEC___App.Controles.DEmpleados
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    ReadOnly _tipoIdentificacion As New DTipoIdentificacion
    ReadOnly _DCargos As New DCargos
    Dim _ClickIdEmpleado As String
    Dim _Fila As String
    Private Sub ComboTipoIdentificacion()
        'llenamos campo tipo identificacion
        _ds = New DataSet()
        _ds = _tipoIdentificacion.Listar()

        cboTipoIdentificacion.Properties.DataSource = _ds.Tables(0)
        cboTipoIdentificacion.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoIdentificacion.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoIdentificacion.ItemIndex = 0
        '----------------------------------
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ComboCargos()
        'llenamos campo Cargos
        _ds = New DataSet()
        _ds = _dCargos.ListarCombo()
        cboCargo.Properties.DataSource = _ds.Tables(0)
        cboCargo.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboCargo.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboCargo.ItemIndex = -1
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Text = Nothing
        'cboTipoIdentificacion.EditValue = Nothing
        txtNumeroIdentificacion.Text = Nothing
        txtNombre.Text = Nothing
        txtDireccion.Text = Nothing
        txtTelefono.Text = Nothing
        txtCorreoElectronico.Text = Nothing
        chkEstado.Checked = True
        cboTipoIdentificacion.Enabled = True
        txtNumeroIdentificacion.Enabled = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        _Empleados.Id = Val(txtCodigo.Text)
        _Empleados.NombreEmpleado = txtNombre.Text
        _Empleados.IdCargo = cboCargo.GetColumnValue("ID")
        _Empleados.IdEspecialidad = Val("13")
        _Empleados.RegistroMedico = ""
        If chkEstado.Checked = True Then
            _Empleados.Estado = "A"
        Else
            _Empleados.Estado = "I"
        End If
        _Empleados.IdTipoIdentificacion = cboTipoIdentificacion.EditValue
        _Empleados.Identificacion = txtNumeroIdentificacion.Text
        _Empleados.Direccion = txtDireccion.Text
        _Empleados.Telefono = txtTelefono.Text
        _Empleados.CorreoElectronico = txtCorreoElectronico.Text
        _DEmpleados.Guardar(_Empleados)

    End Sub
    Private Sub EditarEmpleado()

        _Empleados = _DEmpleados.Cargar(_ClickIdEmpleado)
        txtCodigo.Text = _Empleados.Id
        cboTipoIdentificacion.ItemIndex = cboTipoIdentificacion.Properties.GetDataSourceRowIndex("CODIGO", _Empleados.IdTipoIdentificacion)
        txtNumeroIdentificacion.Text = _Empleados.Identificacion
        txtNombre.Text = _Empleados.NombreEmpleado
        cboCargo.ItemIndex = cboCargo.Properties.GetDataSourceRowIndex("ID", _Empleados.IdCargo)
        txtDireccion.Text = _Empleados.Direccion
        txtTelefono.Text = _Empleados.Telefono
        txtCorreoElectronico.Text = _Empleados.CorreoElectronico
        If _Empleados.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If

        cboTipoIdentificacion.Enabled = False
        txtNumeroIdentificacion.Enabled = False
        bbiGuardar.Enabled = False

    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DEmpleados.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboTipoIdentificacion()
        ComboCargos()
        ActualizarGrilla()
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
        If txtNumeroIdentificacion.Text = "" Then
            MessageBox.Show("El Campo Identificación es Obligatorio", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboCargo.Text = "" Then
            MessageBox.Show("Debe seleccionar el cargo", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub cboTipoIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboCargo_EditValueChanged(sender As Object, e As EventArgs) Handles cboCargo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDireccion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefono_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefono.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCorreoElectronico_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdempleado = Nothing Then
            MessageBox.Show("Debe seleccionar un Empleado", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarEmpleado()
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdEmpleado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
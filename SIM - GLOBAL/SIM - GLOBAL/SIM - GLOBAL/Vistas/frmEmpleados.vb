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
        _Empleados.IdEspecialidad = cboEspecialidad.GetColumnValue("ID")
        _Empleados.RegistroMedico = txtRegistroMedico.Text
        If chkEstado.Checked = True Then
            _Empleados.Estado = "A"
        Else
            _Empleados.Estado = "I"

        End If
        _dEmpleados.Guardar(_Empleados)

        If cboCargo.GetColumnValue("CARGO") = "ESPECIALISTA" Then
            If txtID.Text = "" Then
                _Especialista.id = Val("")
                _Especialista.idespecialista = Val(_dEmpleados.ultimoregistroempleado)
                _Especialista.nombre = txtNombre.Text
                _Especialista.especialidad = cboEspecialidad.GetColumnValue("ESPECIALIDAD")
                _Especialista.registromedico = txtRegistroMedico.Text
                _Especialista.estado = "A"
                _DEspecialista.guardar2(_Especialista)
            End If
        End If
    End Sub
    Private Sub ActivarGuardar()
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dEmpleados.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        peFirma.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
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
        txtRegistroMedico.Text = ""
        cboCargo.EditValue = Nothing
        cboEspecialidad.EditValue = Nothing
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
        ElseIf cboEspecialidad.Text = "" Then
            MessageBox.Show("Debe seleccionar la especialidad", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    cboEspecialidad.ItemIndex = cboEspecialidad.Properties.GetDataSourceRowIndex("ID", _Empleados.IdEspecialidad)
                    txtRegistroMedico.Text = _Empleados.RegistroMedico
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
        'cboEspecialidad.Properties.ValueMember = Nothing

        If cboCargo.GetColumnValue("CARGO") = "ESPECIALISTA" Then
            cboEspecialidad.Enabled = True
            txtRegistroMedico.Enabled = True
            'llenamos campo Especialidad
            _ds = New DataSet()
            _ds = _dEspecialidades.ListarEspecialista()
            cboEspecialidad.Properties.DataSource = _ds.Tables(0)
            cboEspecialidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
            cboEspecialidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
            'cboEspecialidad.ItemIndex = -1
        Else
            'cboEspecialidad.ItemIndex = cboEspecialidad.Properties.GetDataSourceRowIndex("ESPECIALIDAD", "EMPLEADO")
            cboEspecialidad.Enabled = False
            txtRegistroMedico.Enabled = False
            txtRegistroMedico.Text = ""
            'llenamos campo Especialidad
            _ds = New DataSet()
            _ds = _dEspecialidades.ListarEmpleado()
            cboEspecialidad.Properties.DataSource = _ds.Tables(0)
            cboEspecialidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
            cboEspecialidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
            cboEspecialidad.ItemIndex = 0

        End If
        ActivarGuardar()
    End Sub

    Private Sub cboEspecialidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboEspecialidad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRegistroMedico_EditValueChanged(sender As Object, e As EventArgs) Handles txtRegistroMedico.EditValueChanged
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
Imports PEC___App.Controles
Imports PEC___App.Modelo
Public Class frmContratos
    'Variables Publicas
    Public Licencia As String
    Public IdEmpleado As String
    'Declaraciones
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickClienteSede As String
    Dim _Fila As Integer
    ' declaracionees Objetos
    Dim _dContratos = New DContratos
    Dim _Contratos As New Contratos
    Dim _dClientes = New SIM___GLOBAL.Controles.DClientes
    Dim _dTarifa = New SIM___GLOBAL.Controles.DTarifas
    Dim _DCiudades = New PEC___App.Controles.DCiudades
    Dim _ClientesSedes = New PEC___App.Modelo.ClientesSedes
    Dim _DClientesSedes = New PEC___App.Controles.DClienteSedes
    Dim _Id As New Guid
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dContratos.listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GrillaClientesSedes()
        'llenamos GRILLA
        _ds = New DataSet()
        If txtID.Text = "" Then
            _ds = _DClientesSedes.ListarClientesSedes(_Id.ToString)
        Else
            _ds = _DClientesSedes.ListarClientesSedes(txtID.Text)
        End If
        gcClientesSedes.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = Nothing
        txtNombre.Text = ""
        txtNumeroContrato.Text = ""
        dtFechaInicio.Text = ""
        dtFechaFinal.Text = ""
        txtObservaciones.Text = ""
        txtContacto.Text = ""
        txtTelefeno.Text = ""
        txtCorreoElectronico.Text = ""
        chkEstado.Checked = False
        cboCliente.Enabled = True
        txtNombre.Enabled = True
        chkEstado.Checked = True
        cboCliente.EditValue = Nothing
        cboTarifa.EditValue = Nothing
        gcClientesSedes.DataSource = Nothing
        _Id = Guid.NewGuid()

        bbiGuardar.Enabled = False
    End Sub
    Private Sub Editar()
        _Contratos = _dContratos.Cargar(_ClickGrilla)
        txtID.Text = _Contratos.Id
        cboCliente.ItemIndex = cboCliente.Properties.GetDataSourceRowIndex("IDCLIENTE", _Contratos.idCliente)
        txtNombre.Text = _Contratos.Nombre
        txtNumeroContrato.Text = _Contratos.NumeroContrato
        dtFechaInicio.Text = _Contratos.FechaInicio
        dtFechaFinal.Text = _Contratos.FechaFinal
        txtObservaciones.Text = _Contratos.Observaciones
        txtContacto.Text = _Contratos.Contacto
        txtTelefeno.Text = _Contratos.Telefono
        txtCorreoElectronico.Text = _Contratos.CorreoElectronico
        'cboCliente.ItemIndex = cboCliente.Properties.GetDataSourceRowIndex("IDCLIENTE", _Contratos.idCliente)
        cboTarifa.ItemIndex = cboTarifa.Properties.GetDataSourceRowIndex("ID", _Contratos.IdTarifa)
        If _Contratos.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If
        cboCliente.Enabled = False
        txtNombre.Enabled = False
        bbiGuardar.Enabled = False
        'Bloqueamos 
    End Sub
    Private Sub Guardar()
        _Contratos.Id = Val(txtID.Text)
        _Contratos.idCliente = cboCliente.GetColumnValue("IDCLIENTE")
        _Contratos.NumeroContrato = txtNumeroContrato.Text
        _Contratos.Nombre = txtNombre.Text
        _Contratos.FechaInicio = dtFechaInicio.Text
        _Contratos.FechaFinal = dtFechaFinal.Text
        _Contratos.Observaciones = txtObservaciones.Text
        _Contratos.Contacto = txtContacto.Text
        _Contratos.Telefono = txtTelefeno.Text
        _Contratos.CorreoElectronico = txtCorreoElectronico.Text
        _Contratos.IdTarifa = cboTarifa.GetColumnValue("ID")
        _Contratos.IdLicencia = Licencia
        If chkEstado.Checked = True Then
            _Contratos.Estado = "A"
        Else
            _Contratos.Estado = "I"
        End If
        _dContratos.guardar(_Contratos)
        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarSede()
        _ClientesSedes.Id = Val(txtID.Text)
        If txtID.Text = "" Then
            _ClientesSedes.IdCONtrato = _Id.ToString
        Else
            _ClientesSedes.idcontrato = txtID.Text
        End If
        _ClientesSedes.idciudad = cboSedes.GetColumnValue("ID")
        _ClientesSedes.estado = "A"
        _DClientesSedes.guardar(_ClientesSedes)
    End Sub
    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        'llenamos Entidades
        _ds = New DataSet()
        _ds = _dClientes.listarcombo()
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        '----------------------------------
        'llenamos Tarifas
        _ds = New DataSet()
        _ds = _dTarifa.listarcombo()
        cboTarifa.Properties.DataSource = _ds.Tables(0)
        cboTarifa.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTarifa.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos Sedes
        _ds = New DataSet()
        _ds = _DCiudades.listarcombo()
        cboSedes.Properties.DataSource = _ds.Tables(0)
        cboSedes.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSedes.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        '----------------------------------
        chkEstado.Checked = True
        _Id = Guid.NewGuid()

        bbiGuardar.Enabled = False
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
            MessageBox.Show("No ha seleccionado el contrato", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If MessageBox.Show("Desea Editar el Registro ?", "Editar Registros ",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.Yes Then
                    Editar()
                    GrillaClientesSedes()
                    xtRegistroContratos.Show()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaInicio.Text = "" Then
            MessageBox.Show("El Campo Fecha Inicio es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaFinal.Text = "" Then
            MessageBox.Show("El Campo Fecha Final es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Format(dtFechaFinal.Text, "DD/MM/yyyy") < Format(dtFechaInicio.Text, "DD/MM/yyyy") Then
            MessageBox.Show("La Fecha Final No puede ser Menor a Fecha Inicial", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboCliente.Text = "" Then
            MessageBox.Show("No ha seleccionado el cliente", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTarifa.Text = "" Then
            MessageBox.Show("No ha seleccionado la tarifa", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvClientesSedes.RowCount = 0 Then
            MessageBox.Show("Debe asignar por lo menos una sede", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            _Contratos = _dContratos.ultimoregistrocontrato
            _DClientesSedes.actualizarclientesede(_Contratos.Id, _Id.ToString)
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub frmContratos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If txtID.Text = "" And gvClientesSedes.RowCount <> 0 Then
            _DClientesSedes.Eliminarsedescliente(_Id.ToString)
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroContrato_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroContrato.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicio.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaFinal.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtContacto_EditValueChanged(sender As Object, e As EventArgs) Handles txtContacto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefeno_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefeno.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCorreoElectronico_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTarifa_EditValueChanged(sender As Object, e As EventArgs) Handles cboTarifa.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub btnAgregarSede_Click(sender As Object, e As EventArgs) Handles btnAgregarSede.Click
        Dim IdContrato As String
        If txtID.Text = "" Then
            IdContrato = _Id.ToString
        Else
            IdContrato = txtID.Text
        End If
        If cboSedes.Text = "" Then
            MessageBox.Show("No ha seleccionado la sede", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _dContratos.existesede(cboSedes.GetColumnValue("ID"), IdContrato) = True Then
            MessageBox.Show("La sede ya se encuentra asignada", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarSede()
            GrillaClientesSedes()
            cboSedes.EditValue = Nothing
        End If
    End Sub

    Private Sub btnEliminarSede_Click(sender As Object, e As EventArgs) Handles btnEliminarSede.Click
        If _ClickClienteSede = "" Then
            MessageBox.Show("No ha seleccionado la sede", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DClientesSedes.ExisteClienteSedeOrden(_ClickClienteSede) = True Then
            MessageBox.Show("No se puede eliminar la sede porque hay ordenes con esta sede.", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtID.Text <> "" And gvClientesSedes.RowCount = 1 Then
            MessageBox.Show("No se puede eliminar la sede", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DClientesSedes.eliminar(_ClickClienteSede)
            GrillaClientesSedes()
            _ClickClienteSede = Nothing
        End If
    End Sub

    Private Sub gvClientesSedes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvClientesSedes.RowClick
        If e.RowHandle >= 0 Then
            _ClickClienteSede = gvClientesSedes.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
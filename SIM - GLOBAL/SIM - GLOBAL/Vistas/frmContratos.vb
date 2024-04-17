Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Public Class frmContratos
    Dim _ds As DataSet
    Dim _dContratos = New DContratos
    Dim _Contratos As New Contratos
    Dim _SubEntidades As New Subentidades
    Dim _DSubentidades As New DSudentidades
    Dim _Licencias As New SIM___GLOBAL.Modelo.Licencias
    Dim _DLicencias As New DLicencias
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    ReadOnly _Entidad = New DEntidades
    ReadOnly _Tarifa = New DTarifas

    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtNumeroContrato.Text = ""
        dtFechaInicio.Text = ""
        dtFechaFinal.Text = ""
        txtObservaciones.Text = ""
        txtContacto.Text = ""
        txtTelefeno.Text = ""
        txtCorreoElectronico.Text = ""
        txtValor.Text = ""
        chkEstado.Checked = False
        chkRips.Checked = False
        cboEntidad.Enabled = True
        txtNombre.Enabled = True
        cboTipoContrato.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        'cboEntidad.Properties.ValueMember = Nothing
        'cboTarifa.Properties.ValueMember = Nothing
    End Sub
    Private Sub Guardar()
        _Contratos.Id = Val(txtID.Text)
        _Contratos.CodigoEntidad = cboEntidad.GetColumnValue("CODIGO")
        _Contratos.Nombre = txtNombre.Text
        _Contratos.NumeroContrato = txtNumeroContrato.Text
        _Contratos.FechaInicio = dtFechaInicio.Text
        _Contratos.FechaFinal = dtFechaFinal.Text
        _Contratos.Observaciones = txtObservaciones.Text
        _Contratos.Contacto = txtContacto.Text
        _Contratos.Telefono = txtTelefeno.Text
        _Contratos.CorreoElectronico = txtCorreoElectronico.Text
        _Contratos.TipoContrato = cboTipoContrato.Text
        If chkRips.Checked = True Then
            _Contratos.Rips = "SI"
        Else
            _Contratos.Rips = "NO"
        End If
        _Contratos.IdTarifa = cboTarifa.GetColumnValue("ID")
        _Contratos.ValorConvenio = Val(txtValor.Text)
        _Contratos.IdLicencia = cboLicencia.GetColumnValue("ID")
        If chkEstado.Checked = True Then
            _Contratos.Estado = "A"
        Else
            _Contratos.Estado = "I"
        End If
        _dContratos.guardar(_Contratos)

        If txtID.Text = "" Then
            'Obtenemos el ultimo consecutivo de la tabla contratos
            _Contratos = _dContratos.ultimoregistrocontrato

            'Guardamos la Subentidad "No aplica" 
            _SubEntidades.IdContrato = _Contratos.Id
            _SubEntidades.Nombre = "NO APLICA"
            _SubEntidades.Estado = "E"
            _DSubentidades.Guardar(_SubEntidades)

            '_usuarios.CodigotipoIdentificacion = cboTipoIdentificacion.GetColumnValue("CODIGO")
        End If
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Editar()
        _Contratos = _dContratos.Cargar(_ClickGrilla)
        txtID.Text = _Contratos.Id
        cboEntidad.ItemIndex = cboEntidad.Properties.GetDataSourceRowIndex("CODIGO", _Contratos.CodigoEntidad)
        txtNombre.Text = _Contratos.Nombre
        txtNumeroContrato.Text = _Contratos.NumeroContrato
        dtFechaInicio.Text = _Contratos.FechaInicio
        dtFechaFinal.Text = _Contratos.FechaFinal
        txtObservaciones.Text = _Contratos.Observaciones
        txtContacto.Text = _Contratos.Contacto
        txtTelefeno.Text = _Contratos.Telefono
        txtCorreoElectronico.Text = _Contratos.CorreoElectronico
        cboTipoContrato.Text = _Contratos.TipoContrato
        If _Contratos.Rips = "SI" Then
            chkRips.Checked = True
        Else
            chkRips.Checked = False
        End If
        cboTarifa.ItemIndex = cboTarifa.Properties.GetDataSourceRowIndex("ID", _Contratos.IdTarifa)
        txtValor.Text = _Contratos.ValorConvenio
        cboLicencia.ItemIndex = cboLicencia.Properties.GetDataSourceRowIndex("ID", _Contratos.IdLicencia)
        If _Contratos.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If
        cboEntidad.Enabled = False
        txtNombre.Enabled = False
        bbiGuardar.Enabled = False
        'Bloqueamos 
    End Sub
    Private Sub ActualizarGrilla()

        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dContratos.listar
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub

    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        'llenamos Licencias
        _ds = New DataSet()
        _ds = _DLicencias.ListarCombo()
        cboLicencia.Properties.DataSource = _ds.Tables(0)
        cboLicencia.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboLicencia.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboLicencia.ItemIndex = 0

        cboLicencia.Properties.PopulateColumns()
        cboLicencia.Properties.Columns("ID").Visible = False
        '----------------------------------
        'llenamos Entidades
        _ds = New DataSet()
        _ds = _Entidad.listaractivos()
        cboEntidad.Properties.DataSource = _ds.Tables(0)
        cboEntidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEntidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboEntidad.ItemIndex = 0
        '----------------------------------
        'llenamos Tarifas
        _ds = New DataSet()
        _ds = _Tarifa.listarcombo()
        cboTarifa.Properties.DataSource = _ds.Tables(0)
        cboTarifa.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTarifa.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTarifa.ItemIndex = 0
        '----------------------------------
        cboTipoContrato.SelectedIndex = 0

        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
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
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub GCConsultar_DoubleClick(sender As Object, e As EventArgs)
        Try
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                Editar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtfechainicio.Text = "" Then
            MessageBox.Show("El Campo Fecha Inicio es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaFinal.Text = "" Then
            MessageBox.Show("El Campo Fecha Final es Obligatorio", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf FORMAt(dtFechaFinal.Text, "DD/MM/yyyy") < FORmat(dtFechaInicio.Text, "DD/MM/yyyy") Then
            MessageBox.Show("La Fecha Final No puede ser Menor a Fecha Inicial", "Registro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtNumeroContrato_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroContrato.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub dtFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicio.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub dtFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaFinal.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtContacto_EditValueChanged(sender As Object, e As EventArgs) Handles txtContacto.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtTelefeno_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefeno.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtCorreoElectronico_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboEntidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboEntidad.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboLicencia_EditValueChanged(sender As Object, e As EventArgs) Handles cboLicencia.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboTarifa_EditValueChanged(sender As Object, e As EventArgs) Handles cboTarifa.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboTipoContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoContrato.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkRips_EditValueChanged(sender As Object, e As EventArgs) Handles chkRips.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtValor_EditValueChanged(sender As Object, e As EventArgs) Handles txtValor.EditValueChanged
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
End Class
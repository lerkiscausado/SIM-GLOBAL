Public Class frmConsentimientoInformadoPlantillas
    Dim _ds As DataSet
    Dim _ClickID As String
    Dim _Fila As String
    Public Licencia As String
    Dim _DLicencias As New SIM___GLOBAL.Controles.DLicencias
    Dim _DConsentimientoInformadoPlantillas As New SIM___GLOBAL.Controles.DConsentimientoInformadoPlantillas
    Dim _ConsentimientoInformadoPlantillas As New SIM___GLOBAL.Modelo.ConsentimientoInformadoPlantillas
    Private Sub LimpiarCampos()
        txtID.Text = Nothing
        cboLicencia.EditValue = Nothing
        cboTipoConsentimiento.EditValue = Nothing
        txtDescripcion.Text = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DConsentimientoInformadoPlantillas.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub Guardar()
        _Consentimientoinformadoplantillas.Id = Val(txtID.Text)
        _ConsentimientoInformadoPlantillas.IdLicencia = Licencia
        _ConsentimientoInformadoPlantillas.TipoConsentimiento = cboTipoConsentimiento.Text
        _ConsentimientoInformadoPlantillas.Descripcion = txtDescripcion.Text
        If chkEstado.Checked = True Then
            _ConsentimientoInformadoPlantillas.Estado = "A"
        Else
            _ConsentimientoInformadoPlantillas.Estado = "I"
        End If
        _DConsentimientoInformadoPlantillas.Guardar(_ConsentimientoInformadoPlantillas)
    End Sub
    Private Sub EditarConsentimientoInformadoPlantillas()

        _ConsentimientoInformadoPlantillas = _DConsentimientoInformadoPlantillas.Cargar(_ClickId)
        txtID.Text = _ConsentimientoInformadoPlantillas.Id
        cboLicencia.ItemIndex = cboLicencia.Properties.GetDataSourceRowIndex("ID", _ConsentimientoInformadoPlantillas.IdLicencia)
        cboTipoConsentimiento.Text = _ConsentimientoInformadoPlantillas.TipoConsentimiento
        txtDescripcion.Text = _ConsentimientoInformadoPlantillas.Descripcion
        If _ConsentimientoInformadoPlantillas.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If

        bbiGuardar.Enabled = False

    End Sub
    Private Sub frmConsentimientoInformadoPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()

        'llenamos Licencias
        _ds = New DataSet()
        _ds = _DLicencias.ListarCombo()
        cboLicencia.Properties.DataSource = _ds.Tables(0)
        cboLicencia.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboLicencia.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboLicencia.ItemIndex = 0

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
        If cboLicencia.Text = "" Then
            MessageBox.Show("Debe seleccionar la Empresa", "Registro de Plantillas de Consentimiento Informado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTipoConsentimiento.Text = "" Then
            MessageBox.Show("El tipo de consentimiento es obligatorio", "Registro de Plantillas de Consentimiento Informado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("El campo Descripción es obligatorio", "Registro de Plantillas de Consentimiento Informado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()

            'llenamos la grilla de registros
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub cboLicencia_EditValueChanged(sender As Object, e As EventArgs) Handles cboLicencia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoConsentimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoConsentimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickID = Nothing Then
            MessageBox.Show("Debe seleccionar la plantilla", "Registro de Plantillas de Consentimiento Informado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarConsentimientoInformadoPlantillas()
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickID = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub
End Class
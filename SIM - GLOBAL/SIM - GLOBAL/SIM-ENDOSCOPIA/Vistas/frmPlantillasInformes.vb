Public Class frmPlantillasInformes
    Dim _ds As DataSet
    Dim _DPlantillasInformes As New SIM___GLOBAL.Controles.DPlantillasInformes
    Dim _DEmpleados As New SIM___GLOBAL.Controles.DEmpleados
    Dim _DTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio
    Dim _PlantillasInformes As New SIM___GLOBAL.Modelo.PlantillasInformes
    Dim _ClickGrilla As String
    Dim _Fila As String
    Private Sub ActualizarGrilla()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _Dplantillasinformes.Listar
        GCPlantillasInformes.DataSource = _ds.Tables(0)
        '----------------------------------
    End Sub
    Private Sub LimpiarCampos()
        txtELCB.Text = ""
        txtDescripcion.Text = ""
        txtCampo2.Text = ""
        txtCampo3.Text = ""
        txtCampo4.Text = ""
        txtDiagnostico.Text = ""
        cboMedico.Text = ""
        cboTipoEstudio.Text = ""
        lblId.Text = ""
        cboMedico.Enabled = True
        cboTipoEstudio.Enabled = True
        bbiGuardar.Enabled = False
        lblReporteEstudio.Visible = False
        xtcReporteEstudio.Visible = False
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub frmPlantillasInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = ""
        ActualizarGrilla()

        ' Cargar Especialista
        _ds = _Dempleados.ListarEspecialista
        cboMedico.Properties.DataSource = _ds.Tables(0)
        cboMedico.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedico.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMedico.ItemIndex = -1

        ' Cargar Tipo Estudio
        _ds = _DTipoEstudio.ListarProcedimientos
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoEstudio.ItemIndex = -1
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPlantillasInformes.OptionsFind.AlwaysVisible = True Then
            GVPlantillasInformes.OptionsFind.AlwaysVisible = False
        Else
            GVPlantillasInformes.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub
    Private Sub Guardar()
        _PlantillasInformes.Id = Val(lblId.Text)
        _PlantillasInformes.IdEspecialista = cboMedico.GetColumnValue("ID")
        _PlantillasInformes.IdTipoEstudio = cboTipoEstudio.GetColumnValue("ID")
        _PlantillasInformes.Campo1 = txtELCB.Text
        _PlantillasInformes.Campo2 = txtDescripcion.Text
        _PlantillasInformes.Campo3 = txtCampo2.Text
        _PlantillasInformes.Campo4 = txtCampo3.Text
        _PlantillasInformes.Campo5 = txtCampo4.Text
        _PlantillasInformes.Campo6 = txtDiagnostico.Text
        _PlantillasInformes.Estado = "A"
        _DPlantillasInformes.Guardar(_PlantillasInformes)
        'bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If cboMedico.Text = "" Then
            MessageBox.Show("Debe seleccionar el medico", "Plantillas de Informes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTipoEstudio.Text = "" Then
            MessageBox.Show("Debe seleccionar el medico", "Plantillas de Informes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub cboMedico_EditValueChanged(sender As Object, e As EventArgs) Handles cboMedico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoEstudio.EditValueChanged
        ActivarGuardar()
        lblReporteEstudio.Visible = True
        xtcReporteEstudio.Visible = True
        Select Case cboTipoEstudio.Text
            Case "COLONOSCOPIA"
                xtpELCB.PageVisible = True
                xtpDescripcion.PageVisible = True
                xtpCampo2.PageVisible = True
                xtpCampo3.PageVisible = True
                xtpCampo4.PageVisible = True
                xtpDiagnostico.PageVisible = True
                xtpCampo2.Text = "Inspeccion"
                xtpCampo3.Text = "Tacto"
                xtpCampo4.Text = "Colonoscopia"
            Case "RECTOSCOPIA"
                xtpELCB.PageVisible = False
                xtpDescripcion.PageVisible = True
                xtpCampo2.PageVisible = True
                xtpCampo3.PageVisible = True
                xtpCampo4.PageVisible = True
                xtpDiagnostico.PageVisible = True
                xtpCampo2.Text = "Inspeccion"
                xtpCampo3.Text = "Tacto"
                xtpCampo4.Text = "Rectoscopia"
            Case "ENDOSCOPIA"
                xtpELCB.PageVisible = False
                xtpDescripcion.PageVisible = True
                xtpCampo2.PageVisible = True
                xtpCampo3.PageVisible = True
                xtpCampo4.PageVisible = True
                xtpDiagnostico.PageVisible = True
                xtpCampo2.Text = "Esofago"
                xtpCampo3.Text = "Estomago"
                xtpCampo4.Text = "Duodeno"
            Case "ESTUDIOS ESPECIALES"
                xtpELCB.PageVisible = False
                xtpDescripcion.PageVisible = False
                xtpCampo2.PageVisible = True
                xtpCampo3.PageVisible = False
                xtpCampo4.PageVisible = False
                xtpDiagnostico.PageVisible = False
                xtpCampo2.Text = "Informe"

        End Select
    End Sub

    Private Sub txtELCB_EditValueChanged(sender As Object, e As EventArgs) Handles txtELCB.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCampo2_EditValueChanged(sender As Object, e As EventArgs) Handles txtCampo2.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCampo3_EditValueChanged(sender As Object, e As EventArgs) Handles txtCampo3.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCampo4_EditValueChanged(sender As Object, e As EventArgs) Handles txtCampo4.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVPlantillasInformes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPlantillasInformes.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPlantillasInformes.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No ha seleccionado la plantilla", "Registro de Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    lblId.Text = _ClickGrilla
                    _PlantillasInformes = _DPlantillasInformes.Cargar(lblId.Text)

                    cboMedico.ItemIndex = cboMedico.Properties.GetDataSourceRowIndex("ID", _PlantillasInformes.IdEspecialista)
                    cboTipoEstudio.ItemIndex = cboTipoEstudio.Properties.GetDataSourceRowIndex("ID", _PlantillasInformes.IdTipoEstudio)

                    txtELCB.Text = _PlantillasInformes.Campo1
                    txtDescripcion.Text = _PlantillasInformes.Campo2
                    txtCampo2.Text = _PlantillasInformes.Campo3
                    txtCampo3.Text = _PlantillasInformes.Campo4
                    txtCampo4.Text = _PlantillasInformes.Campo5
                    txtDiagnostico.Text = _PlantillasInformes.Campo6
                    cboMedico.Enabled = False
                    cboTipoEstudio.Enabled = False
                    bbiGuardar.Enabled = False
                    lblReporteEstudio.Visible = True
                    xtcReporteEstudio.Visible = True

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
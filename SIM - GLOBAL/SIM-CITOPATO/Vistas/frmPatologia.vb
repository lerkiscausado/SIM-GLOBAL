'Imports SIM_CITOPATO.Controles
Imports SIM___GLOBAL.Utilidades
Imports SIM_CITOPATO.My.Modelo
Public Class frmPatologia
    Dim _ds As DataSet
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _dUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _TipoEstudio As New SIM___GLOBAL.Modelo.TipoEstudio
    Dim _DTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio
    Dim _Patologia As New SIM_CITOPATO.My.Modelo.Patologia
    Dim _DPatologia As New SIM_CITOPATO.Controles.DPatologia
    Dim _DDiagnostico As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _IdUsuario As Integer
    Dim _ClickGrilla As String
    Dim _ClickIdentificacion As String
    Dim _Fila As Integer
#Region "PROCEDIMIENTOS"
    Private Sub LimpiarCampos()
        'limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtDatosUsuario.Text = ""
        txtConsecutivo.Text = ""
        txtSolicitado.Text = ""
        txtTipoMuestra.Text = ""
        txtSitioLesion.Text = ""
        txtMacro.Text = ""
        txtMicro.Text = ""
        txtDiagnostico.Text = ""
        txtObservaciones.Text = ""
        chkProcesado.Checked = False
        ActualizarGrilla()
        bbiGuardar.Enabled = False
    End Sub

    Private Sub NuevoEstudio()
        lblConsecutivoOrden.Text = _ClickGrilla
        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")

        '******* Traemos la Orden ******************
        _ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _ordenes.IdUsuario
        txtConsecutivo.Text = _ordenes.Consecutivo
        dtFecha.Text = _ordenes.FechaIngreso

        '************ Traemos el Tipo Estudio ****************
        _TipoEstudio = _DTipoEstudio.Cargar(_ordenes.IdTipoEstudio)

        '************ Traemos la Patologia *************
        _Patologia = _DPatologia.Cargar(_ClickGrilla)

        'txtConsecutivo.Text = _TipoEstudio.Prefijo & _Patologia.Id
        'dtFecha.Text = _Patologia.Fecha
        txtTipoMuestra.Text = _Patologia.TipoMuestra
        txtSitioLesion.Text = _Patologia.SitioLesion
        txtSolicitado.Text = _Patologia.Solicitado
        txtMacro.Text = _Patologia.DescripcionMacroscopica
        txtMicro.Text = _Patologia.DescripcionMicroscopica
        txtDiagnostico.Text = _Patologia.Diagnostico
        txtObservaciones.Text = _Patologia.Observaciones
        cboDiagnosticos.Text = _Patologia.CodigoDiagnostico

        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dOrdenes.ListarEstudiosAnteriores(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActivaGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dOrdenes.ListarPatologias
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarEstudio()
        '_Patologia.Id = Val(txtConsecutivo.Text)
        _Patologia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Patologia.TipoMuestra = txtTipoMuestra.Text
        _Patologia.SitioLesion = txtSitioLesion.Text
        _Patologia.Solicitado = txtSolicitado.Text
        _Patologia.DescripcionMacroscopica = txtMacro.Text
        _Patologia.DescripcionMicroscopica = txtMicro.Text
        _Patologia.Diagnostico = txtDiagnostico.Text
        _Patologia.Observaciones = txtObservaciones.Text
        _Patologia.CodigoDiagnostico = cboDiagnosticos.Text
        _Patologia.IdEmpleado = IdEmpleadoG
        _DPatologia.Guardar(_Patologia)
        bbiGuardar.Enabled = False
    End Sub

#End Region
    Private Sub frmPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()

        'llenamos campo Diagnostico
        _ds = New DataSet()
        _ds = _dDiagnostico.Listar()
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(0).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption


    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        ' INFORMACION DEL PACIENTE POR ATENDER
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Patologia", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Patologia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nuevo Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                NuevoEstudio()

            End If
        Else
            LimpiarCampos()
            NuevoEstudio()

        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtTipoMuestra_EditValueChanged(sender As Object, e As EventArgs) Handles txtTipoMuestra.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtMacro_EditValueChanged(sender As Object, e As EventArgs) Handles txtMacro.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtMicro_EditValueChanged(sender As Object, e As EventArgs) Handles txtMicro.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub cbodiagnosticos_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Guardar Estudio", "Registro de Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            GuardarEstudio()
            If chkProcesado.Checked = True Then
                If txtTipoMuestra.Text = "" Then
                    MessageBox.Show("El Tipo de Muestra es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkProcesado.Checked = False
                ElseIf txtMacro.Text = "" Then
                    MessageBox.Show("La descripcion macroscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkProcesado.Checked = False
                ElseIf txtMicro.Text = "" Then
                    MessageBox.Show("La descripcion microscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkProcesado.Checked = False
                ElseIf txtDiagnostico.Text = "" Then
                    MessageBox.Show("El diagnostico es obligatorio para poder firmar el estudio", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkProcesado.Checked = False
                ElseIf MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    LimpiarCampos()

                    '  NuevaHistoria()
                End If
            End If
        End If
    End Sub

    Private Sub chkProcesado_EditValueChanged(sender As Object, e As EventArgs) Handles chkProcesado.EditValueChanged
        '   If chkProcesado.Checked = True Then
        '  If txtTipoMuestra.Text = "" Then
        ' MessageBox.Show("El Tipo de Muestra es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '         chkProcesado.Checked = False
        'ElseIf txtMacro.Text = "" Then
        'MessageBox.Show("La descripcion macroscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'chkProcesado.Checked = False
        'ElseIf txtMicro.Text = "" Then
        'MessageBox.Show("La descripcion microscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'chkProcesado.Checked = False
        'ElseIf txtDiagnostico.Text = "" Then
        'MessageBox.Show("El diagnostico es obligatorio para poder firmar el estudio", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'chkProcesado.Checked = False
        'Else
        ActivaGuardar()
        'End If
        'End If
    End Sub

    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged

    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub txtSolicitado_EditValueChanged(sender As Object, e As EventArgs) Handles txtSolicitado.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtSitioLesion_EditValueChanged(sender As Object, e As EventArgs) Handles txtSitioLesion.EditValueChanged
        ActivaGuardar()
    End Sub

End Class
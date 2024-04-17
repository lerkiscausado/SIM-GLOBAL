Imports System.ComponentModel
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmTomaMuestra
    Dim _ds As DataSet
    Dim _IdUsuario As Integer
    Dim _Orden As String
    Dim _Consecutivo As String
    Dim _Fila As String
    Dim _ClickUsuario As String
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _dUsuarios = New DUsuarios
    Dim _TomaMuestra As New SIM___GLOBAL.Modelo.TomaMuestra
    Dim _DTomaMuestra = New SIM___GLOBAL.Controles.DTomaMuestra
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DOrdenes.ListarTomaMuestra
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub NuevaOrden()
        _IdUsuario = _ClickUsuario
        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)
        lblConsecutivoOrden.Text = _Orden
        txtConsecutivo.Text = _Consecutivo
        If _DTomaMuestra.existe(_IdUsuario) = True Then
            _TomaMuestra = _DTomaMuestra.cargar(_IdUsuario)
            'cargamos Toma de Muestra
            txtGestacion.Text = _TomaMuestra.G
            txtPartos.Text = _TomaMuestra.P
            txtAbortos.Text = _TomaMuestra.A
            txtCesareas.Text = _TomaMuestra.C
            txtVidaSexual.Text = _TomaMuestra.IVSA
            txtMetodoPlanificacion.Text = _TomaMuestra.MPF
            txtUltimaMestruacion.Text = _TomaMuestra.FUM
            txtUltimaCitologia.Text = _TomaMuestra.FUC
            txtUltimoParto.Text = _TomaMuestra.FUP
            chkSano.CheckState = _TomaMuestra.S
            chkUlcerado.CheckState = _TomaMuestra.U
            chkLacerado.CheckState = _TomaMuestra.L
            chkBlanco.CheckState = _TomaMuestra.BN
            chkClaro.CheckState = _TomaMuestra.CN
            chkAmarillo.CheckState = _TomaMuestra.BA
            chkOlor.CheckState = _TomaMuestra.O
            txtObservaciones.Text = _TomaMuestra.Observaciones
        Else
            LimpiarCampos()
        End If
        bbiGuardar.Enabled = False

    End Sub
    Private Sub LimpiarCampos()
        '_IdUsuario = Nothing
        'lblConsecutivoOrden.Text = Nothing
        'txtConsecutivo.Text = Nothing
        txtGestacion.Text = Nothing
        txtPartos.Text = Nothing
        txtAbortos.Text = Nothing
        txtCesareas.Text = Nothing
        txtVidaSexual.Text = Nothing
        txtMetodoPlanificacion.Text = Nothing
        txtUltimaMestruacion.Text = Nothing
        txtUltimaCitologia.Text = Nothing
        txtUltimoParto.Text = Nothing
        chkSano.Checked = False
        chkUlcerado.Checked = False
        chkLacerado.Checked = False
        chkBlanco.Checked = False
        chkClaro.Checked = False
        chkAmarillo.Checked = False
        chkOlor.Checked = False
        txtObservaciones.Text = Nothing
        'GCDatosUsuarios.DataSource = Nothing
        bbiGuardar.Enabled = False
    End Sub
    Private Sub frmTomaMuestra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickUsuario = Nothing Then
            MessageBox.Show("No ha seleccionado el paciente", "Toma de Muestra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("El Usuario presenta cambios sin guardar, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                NuevaOrden()
            End If
        Else
            NuevaOrden()
        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _Orden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "IDUSUARIO").ToString()
            _Consecutivo = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtGestacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtGestacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPartos_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAbortos_EditValueChanged(sender As Object, e As EventArgs) Handles txtAbortos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCesareas_EditValueChanged(sender As Object, e As EventArgs) Handles txtCesareas.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtVidaSexual_EditValueChanged(sender As Object, e As EventArgs) Handles txtVidaSexual.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtMetodoPlanificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtMetodoPlanificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtUltimaMestruacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtUltimaMestruacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtUltimaCitologia_EditValueChanged(sender As Object, e As EventArgs) Handles txtUltimaCitologia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtUltimoParto_EditValueChanged(sender As Object, e As EventArgs) Handles txtUltimoParto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkSano_EditValueChanged(sender As Object, e As EventArgs) Handles chkSano.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkUlcerado_EditValueChanged(sender As Object, e As EventArgs) Handles chkUlcerado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkLacerado_EditValueChanged(sender As Object, e As EventArgs) Handles chkLacerado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkBlanco_EditValueChanged(sender As Object, e As EventArgs) Handles chkBlanco.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkClaro_EditValueChanged(sender As Object, e As EventArgs) Handles chkClaro.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkAmarillo_EditValueChanged(sender As Object, e As EventArgs) Handles chkAmarillo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkOlor_EditValueChanged(sender As Object, e As EventArgs) Handles chkOlor.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        _TomaMuestra.IdUsuario = _IdUsuario
        _TomaMuestra.G = txtGestacion.Text
        _TomaMuestra.P = txtPartos.Text
        _TomaMuestra.A = txtAbortos.Text
        _TomaMuestra.C = txtCesareas.Text
        _TomaMuestra.IVSA = txtVidaSexual.Text
        _TomaMuestra.MPF = txtMetodoPlanificacion.Text
        _TomaMuestra.FUM = txtUltimaMestruacion.Text
        _TomaMuestra.FUC = txtUltimaCitologia.Text
        _TomaMuestra.FUP = txtUltimoParto.Text
        _TomaMuestra.S = chkSano.CheckState
        _TomaMuestra.U = chkUlcerado.CheckState
        _TomaMuestra.L = chkLacerado.CheckState
        _TomaMuestra.BN = chkBlanco.CheckState
        _TomaMuestra.CN = chkClaro.CheckState
        _TomaMuestra.BA = chkAmarillo.CheckState
        _TomaMuestra.O = chkOlor.CheckState
        _TomaMuestra.Observaciones = txtObservaciones.Text
        _DTomaMuestra.guardar(_TomaMuestra)
        bbiGuardar.Enabled = False
    End Sub
End Class
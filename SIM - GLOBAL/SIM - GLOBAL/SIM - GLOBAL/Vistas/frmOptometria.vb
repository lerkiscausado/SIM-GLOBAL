Public Class frmOptometria
    'declaraciones de variables
    Dim _Optometria As New SIM___GLOBAL.Modelo.HistoriaOptometria
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DOptometria As New SIM___GLOBAL.Controles.DOptometria
    Dim _DDiagnosticos As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios

    Dim _ds As DataSet
    Public IdEmpleado As String
    Public Licencia As String
    Dim _ClickGrilla As String
    Dim _ClickGrillaEstudiosAnteriores As String
    Dim _ClickTipoEstudio As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdTipoEstudio As String
    Dim _ClickIdTipoEstudiosAnteriores As String
    Dim _ClickCups As String
    Dim _IDUsuario As String
    Dim _Fila As String
    'impresion
    Dim frmImprimir As New SIM___GLOBAL.frmImprimir
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesOptometria(IdEmpleado)
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        'Limpiamos campos
        lblConsecutivo.Text = ""
        txtConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        GCDatosUsuarios.DataSource = Nothing

        '--------------------------------------
        lblIdDetalleOrden.Text = ""
        txtMotivoConsulta.Text = ""
        txtResponsables.Text = ""
        txtOcupacion.Text = ""
        txtRXUso.Text = ""
        txtAntecedentes.Text = ""
        txtAVVL.Text = ""
        txtAVVP.Text = ""
        txtRefraccionEstatica.Text = ""
        txtDistanciaPupilar.Text = ""
        txtSubjetivo.Text = ""
        txtCoverTest.Text = ""
        txtModoUso.Text = ""
        txtLensometria.Text = ""
        txtAVFinal.Text = ""
        txtDiagnostico.Text = ""
        txtOtrosHallazgos.Text = ""
        cboDiagnosticos.EditValue = Nothing
        txtRecomendaciones.Text = ""
        '--------------------------------------
        chkProcesado.Checked = False
        '****** Traer Estudios Anteriores **********
        '_ds = New DataSet()
        '_ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCHistoriasAnteriores.DataSource = Nothing

    End Sub
    Private Sub CargarOptometria()

        _Optometria = _DOptometria.Cargar(lblConsecutivoOrden.Text)
        txtConsecutivo.Text = _Optometria.Id
        dtFecha.Text = _Optometria.FechaHistoria


        '--------------------------------------
        lblIdDetalleOrden.Text = _Optometria.IdDetalleOrden
        txtMotivoConsulta.Text = _Optometria.MotivoConsulta
        txtResponsables.Text = _Optometria.Responsables
        txtOcupacion.Text = _Optometria.Ocupacion
        txtRXUso.Text = _Optometria.RXUSO
        txtAntecedentes.Text = _Optometria.Antecedentes
        txtAVVL.Text = _Optometria.AVVL
        txtAVVP.Text = _Optometria.AVVP
        txtRefraccionEstatica.Text = _Optometria.RefraccionEstatica
        txtDistanciaPupilar.Text = _Optometria.DistanciaPupilar
        txtSubjetivo.Text = _Optometria.Subjetivo
        txtCoverTest.Text = _Optometria.CoverTest
        txtModoUso.Text = _Optometria.ModoUso
        txtLensometria.Text = _Optometria.Lensometria
        txtAVFinal.Text = _Optometria.AVF
        txtDiagnostico.Text = _Optometria.Diagnostico
        txtOtrosHallazgos.Text = _Optometria.OtrosHallazgos
        cboDiagnosticos.EditValue = _Optometria.CIE10
        txtRecomendaciones.Text = _Optometria.Conducta



    End Sub
    Private Sub Nuevo()

        'traemos Nombre CUPS
        '_NombreCups = _ClickCups
        '_IDTipoEstudio = _ClickIdTipoEstudio

        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        '------------Traemoda datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        '******* Traemos la Orden ******************
        _Ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        If _DOptometria.Existe(lblConsecutivoOrden.Text) = True Then
            CargarOptometria()
        End If

        '****** Traer Estudios Anteriores **********
        _ds = New DataSet()
        _ds = _dOrdenes.ListarHistoriasAnterioresOptometria(lblConsecutivo.Text)
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)

        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarHistoria()

        _Optometria.IdOrden = Val(lblConsecutivoOrden.Text)
        _Optometria.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _Optometria.FechaHistoria = dtFecha.Text
        _Optometria.MotivoConsulta = txtMotivoConsulta.Text
        _Optometria.Responsables = txtResponsables.Text
        _Optometria.Ocupacion = txtOcupacion.Text
        _Optometria.RXUSO = txtRXUso.Text
        _Optometria.Antecedentes = txtAntecedentes.Text
        _Optometria.AVVL = txtAVVL.Text
        _Optometria.AVVP = txtAVVP.Text
        _Optometria.RefraccionEstatica = txtRefraccionEstatica.Text
        _Optometria.DistanciaPupilar = txtDistanciaPupilar.Text
        _Optometria.Subjetivo = txtSubjetivo.Text
        _Optometria.CoverTest = txtCoverTest.Text
        _Optometria.ModoUso = txtModoUso.Text
        _Optometria.Lensometria = txtLensometria.Text
        _Optometria.AVF = txtAVFinal.Text
        _Optometria.Diagnostico = txtDiagnostico.Text
        _Optometria.OtrosHallazgos = txtOtrosHallazgos.Text
        _Optometria.CIE10 = cboDiagnosticos.EditValue
        _Optometria.Conducta = txtRecomendaciones.Text
        _Optometria.IdEspecialista = IdEmpleado
        _DOptometria.Guardar(_Optometria)

    End Sub
    Private Sub frmOptometria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        'Llenamos Fecha Actual
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'Listamos los Diagnosticos
        _ds = _DDiagnosticos.ListarCombo
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickIdTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "TIPOESTUDIO").ToString()
            _ClickCups = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()

            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Atencion", "Nueva Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Consulta pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nueva Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                Nuevo()

                'CargarImagenes(_ClickIdDetalleOrden)
            End If
        Else
            LimpiarCampos()
            Nuevo()
            'CargarImagenes(_ClickIdDetalleOrden)
        End If
    End Sub

    Private Sub txtMotivoConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If chkProcesado.Checked = True Then
            If TVDatosUsuarios.RowCount = 0 Then
                MessageBox.Show("No ha Seleccionado Paciente para Guardar Consulta", "Registro de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtMotivoConsulta.Text = "" And xtpMotivoConsulta.Visible = True Then
                MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtAntecedentes.Text = "" Then
                MessageBox.Show("Campo Antecedentes  es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar la Historia?, Si continua no se podran hacer cambios en la historia. ¿Desea Continuar?", "Firmar Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    GuardarHistoria()
                    '***************** Actualizamos el estado de la Orden a Atendido *****************
                    _dOrdenes.ActualizarEstado(Val(lblConsecutivoOrden.Text), "ATENDIDO")
                    'Actualizar estado de detalle orden
                    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
                    If _DDetalleOrden.DetalleOrdenPendiente(lblConsecutivoOrden.Text) = False Then
                        _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    End If
                    If MessageBox.Show("Desea imprimir la Formula", "Imprimir Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        frmImprimir.ImprimirOptometria(lblConsecutivoOrden.Text, Licencia)
                    End If
                    LimpiarCampos()
                Else
                    GuardarHistoria()
                End If

                '****** Traer Historias Anteriores **********
                _ds = New DataSet()
                _ds = _dOrdenes.ListarHistoriasAnterioresOptometria(lblConsecutivo.Text)
                GCHistoriasAnteriores.DataSource = _ds.Tables(0)
                '***************************************

                ActualizarGrilla()
                bbiGuardar.Enabled = False
            End If
        Else
            GuardarHistoria()
            ActualizarGrilla()
            bbiGuardar.Enabled = False
        End If
    End Sub

    Private Sub txtResponsables_EditValueChanged(sender As Object, e As EventArgs) Handles txtResponsables.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtOcupacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtOcupacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRXUso_EditValueChanged(sender As Object, e As EventArgs) Handles txtRXUso.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAntecedentes_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentes.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAVVL_EditValueChanged(sender As Object, e As EventArgs) Handles txtAVVL.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAVVP_EditValueChanged(sender As Object, e As EventArgs) Handles txtAVVP.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRefraccionEstatica_EditValueChanged(sender As Object, e As EventArgs) Handles txtRefraccionEstatica.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDistanciaPupilar_EditValueChanged(sender As Object, e As EventArgs) Handles txtDistanciaPupilar.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtSubjetivo_EditValueChanged(sender As Object, e As EventArgs) Handles txtSubjetivo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCoverTest_EditValueChanged(sender As Object, e As EventArgs) Handles txtCoverTest.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtModoUso_EditValueChanged(sender As Object, e As EventArgs) Handles txtModoUso.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtLensometria_EditValueChanged(sender As Object, e As EventArgs) Handles txtLensometria.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAVFinal_EditValueChanged(sender As Object, e As EventArgs) Handles txtAVFinal.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtOtrosHallazgos_EditValueChanged(sender As Object, e As EventArgs) Handles txtOtrosHallazgos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRecomendaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtRecomendaciones.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkProcesado_EditValueChanged(sender As Object, e As EventArgs) Handles chkProcesado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs) Handles btVistaEstudios.Click
        If _ClickGrillaEstudiosAnteriores = "" Then
            MessageBox.Show("Debe seleccionar la historia", "Historia Optometria", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmImprimir.VistaOptometria(_ClickGrillaEstudiosAnteriores)
            _ClickGrillaEstudiosAnteriores = ""
        End If
    End Sub

    Private Sub gvHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaEstudiosAnteriores = gvHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
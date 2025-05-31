Imports SIM___GLOBAL.Utilidades
Public Class frmHistoria
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickGrillaIdContrato As String
    Dim _ClickGrillaHistoriasAnteriores As String
    Dim _ClickGrillaHistoriasSinFirma As String
    Dim _Fila As Integer
    Dim _idDetalleOrden As String

    Dim _dHistoria = New SIM___INTEGRA.Controles.DHistoriaIntegra
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes
    Dim _dEmpleados As New SIM___GLOBAL.Controles.DEmpleados
    Dim _dDetelleOrden As New SIM___GLOBAL.Controles.DDetalleOrden

    Dim _Historia As New SIM___INTEGRA.Modelo.HistoriaIntegra
    Dim _Ordenes As SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden

    Public EspecialistaHistoria As String
    Private Sub ActivarGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub LimpiarCampos()
        'Limpiamos Campos
        txtDatosUsuario.Text = ""
        cboProcedimiento.Text = ""
        cboDiagnosticos.Text = ""
        chkFirmar.Checked = False
        txtMotivoConsulta.Text = ""
        txtPersonales.Text = ""
        txtFamiliares.Text = ""
        txtValoracion.Text = ""
        txtPlanSeguir.Text = ""
        txtEvoluciones.Text = ""
        txtRemision.Text = ""
        _idDetalleOrden = ""
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        'cboProcedimiento.ItemIndex = -1
        bbiGuardar.Enabled = False

        'Activar Campos Historia
        HistoriaSoloLectura(False)

        _ClickGrillaHistoriasAnteriores = ""
        _ClickGrillaHistoriasSinFirma = ""

    End Sub
    Private Sub HistoriaSoloLectura(ByVal filtro As Boolean)
        If filtro = True Then
            txtMotivoConsulta.ReadOnly = True
            txtPersonales.ReadOnly = True
            txtFamiliares.ReadOnly = True
            txtValoracion.ReadOnly = True
            txtPlanSeguir.ReadOnly = True
            txtRemision.ReadOnly = True
            txtEvoluciones.ReadOnly = True
            cboDiagnosticos.ReadOnly = True
            chkFirmar.Checked = True
            chkFirmar.ReadOnly = True
            cboProcedimiento.Visible = False
            lblConsulta.Visible = False

        Else
            txtMotivoConsulta.ReadOnly = False
            txtPersonales.ReadOnly = False
            txtFamiliares.ReadOnly = False
            txtValoracion.ReadOnly = False
            txtPlanSeguir.ReadOnly = False
            txtRemision.ReadOnly = False
            txtEvoluciones.ReadOnly = False
            cboDiagnosticos.ReadOnly = False
            chkFirmar.Checked = False
            chkFirmar.ReadOnly = False
            cboProcedimiento.Visible = True
            lblConsulta.Visible = True

        End If

    End Sub
    Private Sub ActivaFicha(ByVal filtro As String)
        If filtro = "P" Then
            xtpAntecedentes.PageVisible = True
            xtpValoracion.PageVisible = True
            xtpPlanSeguir.PageVisible = True
            xtpEvoluciones.PageVisible = False
            xtpMotivoConsulta.PageVisible = True
            xtcHistoria.SelectedTabPage = xtpMotivoConsulta
        Else
            xtpMotivoConsulta.PageVisible = False
            xtpAntecedentes.PageVisible = False
            xtpValoracion.PageVisible = False
            xtpPlanSeguir.PageVisible = False
            xtpEvoluciones.PageVisible = True
            xtcHistoria.SelectedTabPage = xtpEvoluciones
        End If
    End Sub
    Private Sub NuevaHistoria()
        'traemos los datos del ususario  sugun el ID ORDEN
        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")
        ' Obtenemos el ID de la ORDEN
        lblConsecutivoOrden.Text = _ClickGrilla
        'verificamos si existe historia por especialista
        If _dHistoria.ExisteHistoriaEspecialista(_dOrdenes.CargarIDUsuario(_ClickGrilla), IdEspecialidad) = True Then
            'MsgBox("SI EXISTE")
            'EXISTE HISTORIA DEL MISMO DIA
            Dim _ds = New DataSet
            _ds = _dHistoria.ExisteHistoriaEmpleado(_dOrdenes.CargarIDUsuario(_ClickGrilla), IdEmpleado)
            If _ds.Tables(0).Rows.Count <> 0 Then

                'cargamos los datos de la historia clinica del dia de Hoy
                _Historia = _dHistoria.Cargar(_ds.Tables(0).Rows(0)(0).ToString)
                MsgBox(_ds.Tables(0).Rows(0)(0).ToString & " - " & _ds.Tables(0).Rows(0)(2).ToString & " - " & _ds.Tables(0).Rows(0)(3).ToString)
                If _ds.Tables(0).Rows(0)(2).ToString = "ATENDIDO" Then
                    'MsgBox(_ds.Tables(0).Rows(0)(2).ToString)
                    HistoriaSoloLectura(True)
                Else
                    'MsgBox(_ds.Tables(0).Rows(0)(2).ToString)
                End If

                _idDetalleOrden = _Historia.IdDetalleOrden
                txtMotivoConsulta.Text = _Historia.MotivoConsulta
                txtPersonales.Text = _Historia.AntecedentesPersonales
                txtFamiliares.Text = _Historia.AntecedentesFamiliares
                txtValoracion.Text = _Historia.Valoracion
                txtPlanSeguir.Text = _Historia.PlanSeguir
                txtEvoluciones.Text = _Historia.ReporteEvolucion
                txtRemision.Text = _Historia.Remision
                cboProcedimiento.EditValue = _ds.Tables(0).Rows(0)(3).ToString
                cboDiagnosticos.Text = _Historia.CodigoDiagnostico
                txtCodigoHistoria.Text = _Historia.CodigoHistoria
                dtFechaIngreso.Text = _Historia.Fecha
                If _Historia.Cita = "P" Then
                    ActivaFicha("P")
                Else
                    ActivaFicha("C")
                End If
            Else
                ActivaFicha("C")
            End If

        Else
            ' MsgBox("NO EXISTE")
            ActivaFicha("P")
        End If

        ListarHistoriasAnterioresFirmadas(_dOrdenes.CargarIDUsuario(_ClickGrilla))
        ListarHistoriasAnterioresSinFirma(_dOrdenes.cargaridusuario(_ClickGrilla), IdEmpleado)
        'llenamos combo procedimientos
        Dim _DDetalleTarifa = New SIM___GLOBAL.Controles.DDetalleTarifas
        _ds = New DataSet()

        _ds = _DDetalleTarifa.ListarCombo2(_ClickGrillaIdContrato)
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboProcedimiento.ItemIndex = -1
        cboProcedimiento.EditValue = ""

        ' MsgBox("tiene historia el mismos dia")

        ' End If
        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarDetalleOrden()
        'Guardamos Detalle de Orden Automatico
        _DetalleOrden.IdOrden = Val(lblConsecutivoOrden.Text)
        _DetalleOrden.IdCausa = Val("15")
        _DetalleOrden.IdFinalidadConsulta = Val("10")
        _DetalleOrden.IdFinalidadProcedimiento = Val("1")
        _DetalleOrden.IdAmbito = Val("1")
        _DetalleOrden.IdPersonaAtiende = Val("1")
        _DetalleOrden.FechaSalida = Format(DateTime.Now, "dd/MM/yyyy")
        _DetalleOrden.Hora = DateTime.Now
        _DetalleOrden.IdTipoDiagnostico = Val("1")
        _DetalleOrden.Diagnostico1 = cboDiagnosticos.EditValue
        _DetalleOrden.Diagnostico2 = ""
        _DetalleOrden.Diagnostico3 = ""
        _DetalleOrden.Diagnostico4 = ""
        _DetalleOrden.IdFormaRealizacion = Val("1")
        _DetalleOrden.CodigoProcedimiento = cboProcedimiento.GetColumnValue("CODIGO")
        _DetalleOrden.IdTipoEstudio = ""
        _DetalleOrden.Valor = cboProcedimiento.GetColumnValue("VALOR")
        _DetalleOrden.Copago = 0
        _DetalleOrden.Neto = cboProcedimiento.GetColumnValue("VALOR")
        _DetalleOrden.Tipo = "C"
        _DetalleOrden.Estado = "PENDIENTE"
        'Guardamos Historia Clinica
        _Historia.Id = Val("")
        _Historia.IdOrden = lblConsecutivoOrden.Text
        _Historia.IdDetalleOrden = Val(_idDetalleOrden)
        _Historia.CodigoHistoria = txtCodigoHistoria.Text
        _Historia.Fecha = dtFechaIngreso.Text
        _Historia.Hora = DateTime.Now
        _Historia.MotivoConsulta = txtMotivoConsulta.Text
        _Historia.AntecedentesPersonales = txtPersonales.Text
        _Historia.AntecedentesFamiliares = txtFamiliares.Text
        _Historia.Valoracion = txtValoracion.Text
        _Historia.PlanSeguir = txtPlanSeguir.Text
        _Historia.ReporteEvolucion = txtEvoluciones.Text
        _Historia.Remision = txtRemision.Text
        _Historia.CodigoDiagnostico = cboDiagnosticos.EditValue
        If xtpMotivoConsulta.PageVisible = True Then
            _Historia.Cita = "P"
        Else
            _Historia.Cita = "C"
        End If
        _Historia.IdEspecialidad = IdEspecialidad
        _Historia.IdEmpleado = IdEmpleado
        _Historia.Estado = "A"
        _idDetalleOrden = _dHistoria.GuardarHistoriayDetalle(_DetalleOrden, _Historia)
        '_DDetalleOrden.GuardarDetalleOrden(_DetalleOrden)
        'MsgBox(_idDetalleOrden)


    End Sub
    Private Sub ListarPacientesAtender()
        Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
        _ds = _dOrdenes.ListarPacientesIntegra
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ListarHistoriasAnterioresFirmadas(ByVal _idUsuario As String)
        Dim _dHistoriaIntegra As New SIM___INTEGRA.Controles.DHistoriaIntegra
        _ds = _dHistoriaIntegra.ListarHistoriasAnteriores(_idUsuario, "ATENDIDO")
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ListarHistoriasAnterioresSinFirma(ByVal _idUsuario As String, ByVal IdEmpleado As String)
        Dim _dHistoriaIntegra As New SIM___INTEGRA.Controles.DHistoriaIntegra
        _ds = _dHistoriaIntegra.ListarHistoriasSinFirma(_idUsuario, IdEmpleado)
        GCHistoriasAnterioresSinFirma.DataSource = _ds.Tables(0)
    End Sub
    Private Sub FrmHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPacientesAtender()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtEspecialista.Text = EspecialistaHistoria
        'llenamos COMBO Diagnosticos
        Dim _dDiagnosticos As New SIM___GLOBAL.Controles.DDiagnostico
        _ds = New DataSet()
        _ds = _dDiagnosticos.ListarCombo()
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(0).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption


    End Sub

    Private Sub BbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ListarPacientesAtender()
    End Sub

    Private Sub BbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickGrillaIdContrato = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_CONTRATO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub BbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        ' INFORMACION DEL PACIENTE POR ATENDER
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Historia", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf 
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una historia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nueva Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                NuevaHistoria()
            End If
        Else
            LimpiarCampos()
            NuevaHistoria()

        End If
    End Sub

    Private Sub TxtMotivoConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub TxtPersonales_EditValueChanged(sender As Object, e As EventArgs) Handles txtPersonales.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub TxtFamiliares_EditValueChanged(sender As Object, e As EventArgs) Handles txtFamiliares.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub TxtPlanSeguir_EditValueChanged(sender As Object, e As EventArgs) Handles txtPlanSeguir.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub TxtEvoluciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtEvoluciones.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub TxtRemision_EditValueChanged(sender As Object, e As EventArgs) Handles txtRemision.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub CboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub ChkFirmar_EditValueChanged(sender As Object, e As EventArgs) Handles chkFirmar.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub SbBuscar_Click(sender As Object, e As EventArgs) Handles sbBuscar.Click
        If xtcHistoriasAnteriores.SelectedTabPageIndex = 0 Then
            If gvHistoriasAnteriores.OptionsFind.AlwaysVisible = True Then
                gvHistoriasAnteriores.OptionsFind.AlwaysVisible = False
            Else
                gvHistoriasAnteriores.OptionsFind.AlwaysVisible = True
            End If
        Else
            If GVHistoriasAnterioresSinFirma.OptionsFind.AlwaysVisible = True Then
                GVHistoriasAnterioresSinFirma.OptionsFind.AlwaysVisible = False
            Else
                GVHistoriasAnterioresSinFirma.OptionsFind.AlwaysVisible = True
            End If
        End If
    End Sub

    Private Sub BbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Guardar Historia", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaIngreso.Text = "" Then
            MessageBox.Show("Campo Fecha de Historia es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProcedimiento.Text = "" Then
            MessageBox.Show("Campo Consulta de la Historia es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDiagnosticos.Text = "" Then
            MessageBox.Show("Campo Diagnostico de la Historia es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf chkFirmar.Checked = True Then
            'FIRMADA

            If txtMotivoConsulta.Text = "" And xtpMotivoConsulta.Visible = True Then
                MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtPersonales.Text = "" And xtpAntecedentes.Visible = True Then
                MessageBox.Show("Campo Antecedentes Personales es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtFamiliares.Text = "" And xtpAntecedentes.Visible = True Then
                MessageBox.Show("Campo Antecedentes Familiares es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtValoracion.Text = "" And xtpValoracion.Visible = True Then
                MessageBox.Show("Campo Valoración es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtPlanSeguir.Text = "" And xtpPlanSeguir.Visible = True Then
                MessageBox.Show("Campo Analisis y Plan a Seguir es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtEvoluciones.Text = "" And xtpEvoluciones.Visible = True Then
                MessageBox.Show("Campo Evoluciones es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar la Historia?, Si continua no se podran hacer cambios en la historia. ¿Desea Continuar?", "Firmar Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    GuardarDetalleOrden()
                    _dDetelleOrden.ActualizarEstado(_idDetalleOrden)
                    If txtRemision.Text <> "" Then
                        If MessageBox.Show("Desea imprimir la remisión?", "Imprimir Remisión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                            'Dim _DOrdenes As New DOrdenes
                            ImprimirFrm.CargarReporte("Remision.rpt", _idDetalleOrden)
                        End If
                    End If
                    ListarHistoriasAnterioresFirmadas("")
                    ListarHistoriasAnterioresSinFirma("", IdEmpleado)
                    LimpiarCampos()

                End If
            End If
        Else
            ' SIN FIRMAR
            If txtMotivoConsulta.Text = "" And xtpMotivoConsulta.Visible = True Then
                MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtEvoluciones.Text = "" And xtpEvoluciones.Visible = True Then
                MessageBox.Show("Campo Evoluciones es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chkFirmar.Checked = False
                GuardarDetalleOrden()
                bbiGuardar.Enabled = False
            End If
        End If

    End Sub

    Private Sub CboProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.EditValueChanged
        ActivarGuardar()
        'MsgBox(cboProcedimiento.EditValue)
    End Sub

    Private Sub gvHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaHistoriasAnteriores = gvHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVHistoriasAnterioresSinFirma_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVHistoriasAnterioresSinFirma.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaHistoriasSinFirma = GVHistoriasAnterioresSinFirma.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btVistaPrevia_Click(sender As Object, e As EventArgs) Handles btVistaPrevia.Click
        Dim _DCodigoConsulta = New DataSet
        If xtcHistoriasAnteriores.SelectedTabPageIndex = 0 Then
            Dim _frmOpen As New SIM___INTEGRA.frmVistaHistoria
            _frmOpen.IdDetalleOrden = _ClickGrillaHistoriasAnteriores
            _frmOpen.ShowDialog()
        Else
            If _ClickGrillaHistoriasSinFirma = "" Then
                MessageBox.Show("No ha Seleccionado Paciente para Abrir Historia", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf bbiGuardar.Enabled = True Then
                If MessageBox.Show("Tiene una historia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _Historia = _dHistoria.Cargar(_ClickGrillaHistoriasSinFirma)
                    _idDetalleOrden = _Historia.IdDetalleOrden
                    txtMotivoConsulta.Text = _Historia.MotivoConsulta
                    txtPersonales.Text = _Historia.AntecedentesPersonales
                    txtFamiliares.Text = _Historia.AntecedentesFamiliares
                    txtValoracion.Text = _Historia.Valoracion
                    txtPlanSeguir.Text = _Historia.PlanSeguir
                    txtEvoluciones.Text = _Historia.ReporteEvolucion
                    txtRemision.Text = _Historia.Remision
                    cboDiagnosticos.Text = _Historia.CodigoDiagnostico
                    txtCodigoHistoria.Text = _Historia.CodigoHistoria
                    dtFechaIngreso.Text = _Historia.Fecha
                    If _Historia.Cita = "P" Then
                        ActivaFicha("P")
                    Else
                        ActivaFicha("C")
                    End If
                    _DCodigoConsulta = _dDetelleOrden.CodigoConsulta(_idDetalleOrden)
                    cboProcedimiento.EditValue = _DCodigoConsulta.Tables(0).Rows(0)(0).ToString
                    HistoriaSoloLectura(False)
                    bbiGuardar.Enabled = False

                End If
            Else
                _Historia = _dHistoria.Cargar(_ClickGrillaHistoriasSinFirma)
                _idDetalleOrden = _Historia.IdDetalleOrden
                txtMotivoConsulta.Text = _Historia.MotivoConsulta
                txtPersonales.Text = _Historia.AntecedentesPersonales
                txtFamiliares.Text = _Historia.AntecedentesFamiliares
                txtValoracion.Text = _Historia.Valoracion
                txtPlanSeguir.Text = _Historia.PlanSeguir
                txtEvoluciones.Text = _Historia.ReporteEvolucion
                txtRemision.Text = _Historia.Remision
                cboDiagnosticos.Text = _Historia.CodigoDiagnostico
                txtCodigoHistoria.Text = _Historia.CodigoHistoria
                dtFechaIngreso.Text = _Historia.Fecha
                If _Historia.Cita = "P" Then
                    ActivaFicha("P")
                Else
                    ActivaFicha("C")
                End If

                _DCodigoConsulta = _dDetelleOrden.CodigoConsulta(_idDetalleOrden)
                cboProcedimiento.EditValue = _DCodigoConsulta.Tables(0).Rows(0)(0).ToString
                HistoriaSoloLectura(False)
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub
End Class
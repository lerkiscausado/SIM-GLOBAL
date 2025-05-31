Imports DevExpress.Utils

Public Class frmAnestesia
    Public Licencia As String
    Public IdEmpleado As String
    Dim _IdRegistroAnestesia As New Guid
    Dim _ds As DataSet
    Dim _dsMedicamentos As DataSet
    Dim _Fila As String
    Dim _IdUsuario As String
    Dim _ClickCups As String
    Dim _ClickGrilla As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdEndoscopista As String
    Dim _ClickRegistroAnestesiaMedicamento As String
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _RegistroAnestesia As New SIM___GLOBAL.Modelo.RegistroAnestesia
    Dim _DRegistroAnestesia As New SIM___GLOBAL.Controles.DRegistroAnestesia
    Dim _DRegistroAnestesiaMedicamentos As New SIM___GLOBAL.Controles.DRegistroAnestesiaMedicamentos
    Dim _RegistroAnestesiaMedicamentos As New SIM___GLOBAL.Modelo.RegistroAnestesiaMedicamentos
    Dim _DetalleRegistroAnestesia As New SIM___GLOBAL.Modelo.DetalleRegistroAnestesia
    Dim _DDetalleRegistroAnestesia As New SIM___GLOBAL.Controles.DDetalleRegistroAnestesia
    Dim _ClickIdDetalleRegistroAnestesia As String
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesRegistroAnestesia()
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Function CambiarValor(ByVal filtro As String) As String
        Select Case filtro
            Case "X"
                Return 1
            Case ""
                Return 0
            Case 1
                Return "X"
            Case 0
                Return Nothing
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub ListarMedicamentos()
        'llenamos COMBO medicamentos
        Dim _dMedicamentos As New SIM___GLOBAL.Controles.DMedicamentos
        _ds = New DataSet()
        _ds = _dMedicamentos.ListarCombo()
        cboMedicamentos.Properties.DataSource = _ds.Tables(0)
        cboMedicamentos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedicamentos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub GuardarRegistroAnestesia()

        _RegistroAnestesia.IdOrden = Val(lblConsecutivoOrden.Text)
        _RegistroAnestesia.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _RegistroAnestesia.Fecha = dtFechaIngreso.Text
        _RegistroAnestesia.Cardiovisoscopico = CambiarValor(chkCardiovisoscopico.CheckState)
        _RegistroAnestesia.PresionArterial = CambiarValor(chkPresionArterial.CheckState)
        _RegistroAnestesia.OximetriaPulso = CambiarValor(chkOximetriaPulso.CheckState)
        _RegistroAnestesia.ViaAerea = txtViaAerea.Text
        _RegistroAnestesia.Posicion = txtPosicion.Text
        _RegistroAnestesia.Complicaciones = cboComplicaciones.Text
        _RegistroAnestesia.Observaciones = txtObservaciones.Text
        _RegistroAnestesia.ResumenAnestesico = txtResumenAnestesico.Text
        _RegistroAnestesia.IdEndoscopista = _ClickIdEndoscopista
        _RegistroAnestesia.AuxiliarAnestesia = txtAuxiliarAnestesia.Text
        _RegistroAnestesia.IdAnestesiologo = IdEmpleado
        _RegistroAnestesia.Estado = "PENDIENTE"
        _DRegistroAnestesia.Guardar(_RegistroAnestesia)
    End Sub
    Private Sub GuardarDetalleRegistroAnestesia()

        If lblConsecutivo.Text = Nothing Then
            _DetalleRegistroAnestesia.IdRegistroAnestesia = _IdRegistroAnestesia.ToString
        Else
            _DetalleRegistroAnestesia.IdRegistroAnestesia = lblConsecutivo.Text
        End If
        _DetalleRegistroAnestesia.Hora = teHora.EditValue
        _DetalleRegistroAnestesia.O2 = ""
        _DetalleRegistroAnestesia.Anestesia = ""
        _DetalleRegistroAnestesia.FC = ""
        _DetalleRegistroAnestesia.FR = ""
        _DetalleRegistroAnestesia.Diuresis = ""
        _DetalleRegistroAnestesia.TA = ""
        _DetalleRegistroAnestesia.PVC = ""
        _DetalleRegistroAnestesia.V = ""
        _DetalleRegistroAnestesia.SATO = ""
        _DDetalleRegistroAnestesia.Guardar(_DetalleRegistroAnestesia)
    End Sub
    Private Sub GuardarRegistroAnestesiaMedicamentos()

        If lblConsecutivo.Text = Nothing Then
            _RegistroAnestesiaMedicamentos.IdRegistroAnestesia = _IdRegistroAnestesia.ToString
        Else
            _RegistroAnestesiaMedicamentos.IdRegistroAnestesia = lblConsecutivo.Text
        End If
        _RegistroAnestesiaMedicamentos.IdMedicamento = cboMedicamentos.GetColumnValue("ID")
        _RegistroAnestesiaMedicamentos.Medicamento = cboMedicamentos.Text
        _RegistroAnestesiaMedicamentos.Dosis = txtDosis.Text
        _DRegistroAnestesiaMedicamentos.Guardar(_RegistroAnestesiaMedicamentos)
    End Sub
    Private Sub CargarRegistroAnestesia()

        _RegistroAnestesia = _DRegistroAnestesia.Cargar(lblIdDetalleOrden.Text)
        lblConsecutivo.Text = _RegistroAnestesia.Id
        txtNumeroHistoria.Text = "" '_RegistroAnestesia.Id
        dtFechaIngreso.Text = _RegistroAnestesia.Fecha
        chkCardiovisoscopico.Checked = CambiarValor(_RegistroAnestesia.Cardiovisoscopico)
        chkPresionArterial.Checked = CambiarValor(_RegistroAnestesia.PresionArterial)
        chkOximetriaPulso.Checked = CambiarValor(_RegistroAnestesia.OximetriaPulso)
        txtViaAerea.Text = _RegistroAnestesia.ViaAerea
        txtPosicion.Text = _RegistroAnestesia.Posicion
        cboComplicaciones.Text = _RegistroAnestesia.Complicaciones
        txtObservaciones.Text = _RegistroAnestesia.Observaciones
        txtResumenAnestesico.Text = _RegistroAnestesia.ResumenAnestesico
        txtEndoscopista.Text = _DRegistroAnestesia.Especialista(_ClickGrilla)
        txtAuxiliarAnestesia.Text = _RegistroAnestesia.AuxiliarAnestesia
    End Sub
    Private Sub Nuevo()

        'traemos Nombre CUPS
        txtProcedimiento.Text = _ClickCups
        '_IDTipoEstudio = _ClickIdTipoEstudio

        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden

        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        txtEndoscopista.Text = _DRegistroAnestesia.Especialista(_ClickGrilla)
        '******* Traemos la Orden ******************
        '_Ordenes = _dOrdenes.Cargar(_ClickGrilla)
        'lblConsecutivo.Text = _Ordenes.IdUsuario

        If _DRegistroAnestesia.Existe(lblIdDetalleOrden.Text) = True Then
            CargarRegistroAnestesia()
            ActualizarGrillaAnestesiaMedicamentos(lblConsecutivo.Text)
            ActualizarGrillaDetalleRegistroAnestesia(lblConsecutivo.Text)
        Else
            'LimpiarCampos()
            ActualizarGrillaAnestesiaMedicamentos(lblConsecutivo.Text)
            ActualizarGrillaDetalleRegistroAnestesia(lblConsecutivo.Text)
        End If

        '****** Traer Estudios Anteriores **********
        '_ds = New DataSet()
        '_ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        'GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrillaAnestesiaMedicamentos(ByVal IdRegistroAnestesia As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If lblConsecutivo.Text = "" Then
            _ds = _DRegistroAnestesiaMedicamentos.Listar(_IdRegistroAnestesia.ToString)
        Else
            _ds = _DRegistroAnestesiaMedicamentos.Listar(lblConsecutivo.Text)
        End If
        GCMedicamentos.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrillaDetalleRegistroAnestesia(ByVal IdRegistroAnestesia As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If lblConsecutivo.Text = "" Then
            _ds = _DDetalleRegistroAnestesia.Listar(_IdRegistroAnestesia.ToString)
        Else
            _ds = _DDetalleRegistroAnestesia.Listar(lblConsecutivo.Text)
        End If
        gcAnestesia.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmAnestesia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()

        ListarMedicamentos()

        'Llenamos Fecha Actual
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        chkCardiovisoscopico.Checked = False
        chkPresionArterial.Checked = False
        chkOximetriaPulso.Checked = False

        _IdRegistroAnestesia = Guid.NewGuid()
        lblConsecutivo.Text = Nothing
        lblIdDetalleOrden.Text = Nothing

        'formateamos la hora
        teHora.EditValue = DateTime.Now
        teHora.Properties.DisplayFormat.FormatType = FormatType.DateTime
        teHora.Properties.DisplayFormat.FormatString = "t"
        teHora.Properties.EditFormat.FormatType = FormatType.DateTime
        teHora.Properties.EditFormat.FormatString = "t"
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
    Private Sub LimpiarCampos()
        GCDatosUsuarios.DataSource = Nothing
        lblConsecutivoOrden.Text = Nothing
        txtNumeroHistoria.Text = Nothing
        txtProcedimiento.Text = Nothing
        txtEndoscopista.Text = Nothing

        txtAuxiliarAnestesia.Text = Nothing
        chkCardiovisoscopico.Checked = False
        chkPresionArterial.Checked = False
        chkOximetriaPulso.Checked = False
        txtViaAerea.Text = Nothing
        txtPosicion.Text = Nothing
        cboComplicaciones.EditValue = Nothing
        txtObservaciones.Text = Nothing
        txtResumenAnestesico.Text = Nothing
        chkProcesado.Checked = False
        lblConsecutivo.Text = Nothing
        gcAnestesia.DataSource = Nothing
        GCMedicamentos.DataSource = Nothing
        _IdRegistroAnestesia = Guid.NewGuid()
    End Sub
    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickIdDetalleOrden = "" Then
            MessageBox.Show("No ha seleccionado al paciente", "Registro de Anestesia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If _DRegistroAnestesia.ExisteAnestesia(_ClickGrilla) = True Then
                MessageBox.Show("El registro de Anestesia para este paciente ya fue Registrado", "Registro de Anestesia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LimpiarCampos()
                Nuevo()
            End If

        End If

    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickIdEndoscopista = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "IDESPECIALISTA").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            '_ClickIdTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "TIPOESTUDIO").ToString()
            _ClickCups = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _IdUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        GuardarRegistroAnestesia()

        If lblConsecutivo.Text = "" Then
            _RegistroAnestesia = _DRegistroAnestesia.UltimoRegistro
            _DRegistroAnestesiaMedicamentos.ActualizarRegistroAnestesiaMedicamentos(_RegistroAnestesia.Id, _IdRegistroAnestesia.ToString)
            _DDetalleRegistroAnestesia.ActualizarDetalleRegistroAnestesia(_RegistroAnestesia.Id, _IdRegistroAnestesia.ToString)
        End If

        If chkProcesado.Checked = True Then
            If cboComplicaciones.Text = "" Then
                MessageBox.Show("No ha seleccionado complicaciones", "Registro de Anestesia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtResumenAnestesico.Text = "" Then
                MessageBox.Show("El campo Resumen de manejo anestesico es obligatorio", "Registro de Anestesia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar el Registro de Anestesia?, Si continua No se podran hacer cambios en el Registro ¿Desea Continuar?", "Firmar Registro de Anestesia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                    'Se firma el registro de anestesia
                    _DRegistroAnestesia.ActualizarEstado(lblConsecutivoOrden.Text)
                    LimpiarCampos()
                End If
            End If
        End If
        ActualizarGrilla()
        bbiGuardar.Enabled = False
    End Sub

    Private Sub chkCardiovisoscopico_CheckedChanged(sender As Object, e As EventArgs) Handles chkCardiovisoscopico.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub chkPresionArterial_CheckedChanged(sender As Object, e As EventArgs) Handles chkPresionArterial.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub chkOximetriaPulso_CheckedChanged(sender As Object, e As EventArgs) Handles chkOximetriaPulso.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub txtViaAerea_EditValueChanged(sender As Object, e As EventArgs) Handles txtViaAerea.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPosicion_EditValueChanged(sender As Object, e As EventArgs) Handles txtPosicion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboComplicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComplicaciones.SelectedIndexChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAuxiliarAnestesia_EditValueChanged(sender As Object, e As EventArgs) Handles txtAuxiliarAnestesia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtResumenAnestesico_EditValueChanged(sender As Object, e As EventArgs) Handles txtResumenAnestesico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmMedicamentos
        _frmOpen.ShowDialog()

        'llenamos COMBO Diagnosticos
        Dim _dMedicamentos As New SIM___GLOBAL.Controles.DMedicamentos
        _dsMedicamentos = New DataSet()
        _dsMedicamentos = _dMedicamentos.ListarCombo
        cboMedicamentos.Properties.DataSource = _dsMedicamentos.Tables(0)
        cboMedicamentos.Properties.DisplayMember = _dsMedicamentos.Tables(0).Columns(1).Caption
        cboMedicamentos.Properties.ValueMember = _dsMedicamentos.Tables(0).Columns(0).Caption
    End Sub

    Private Sub cmdAgregarMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdAgregarMedicamentos.Click
        Dim RegistroAnestesia As String
        If lblConsecutivo.Text = "" Then
            RegistroAnestesia = _IdRegistroAnestesia.ToString
        Else
            RegistroAnestesia = lblConsecutivo.Text
        End If
        If cboMedicamentos.Text = "" Then
            MessageBox.Show("Debe seleccionar un Medicamento", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDosis.Text = "" Then
            MessageBox.Show("Falta colocar la dosis", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DRegistroAnestesiaMedicamentos.Existe(RegistroAnestesia, cboMedicamentos.GetColumnValue("ID")) = True Then
            MessageBox.Show("Este Medicamento ya fue agregado", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarRegistroAnestesiaMedicamentos()
            ActualizarGrillaAnestesiaMedicamentos(lblConsecutivo.Text)

            'Limpiamos campos
            txtDosis.Text = ""
            cboMedicamentos.Text = ""

        End If
    End Sub

    Private Sub cmdEliminarMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdEliminarMedicamentos.Click
        If _ClickRegistroAnestesiaMedicamento = "" Then
            MessageBox.Show("Debe seleccionar un medicamento", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf GVDetalleOrden.RowCount = 1 And txtConsecutivo.Text <> "" Then
            '    MessageBox.Show("La Orden no puede quedar sin detalle. Agregue el servicio correcto y luego elimine el incorrecto", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DRegistroAnestesiaMedicamentos.Eliminar(_ClickRegistroAnestesiaMedicamento)
            ActualizarGrillaAnestesiaMedicamentos(lblConsecutivo.Text)
            _ClickRegistroAnestesiaMedicamento = ""
        End If
    End Sub

    Private Sub GVMedicamentos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVMedicamentos.RowClick
        If e.RowHandle >= 0 Then
            _ClickRegistroAnestesiaMedicamento = GVMedicamentos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub frmAnestesia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If lblConsecutivo.Text = "" And GVMedicamentos.RowCount <> 0 Then
            _DRegistroAnestesiaMedicamentos.EliminarRegistroAnestesiaMedicamentos(_IdRegistroAnestesia.ToString)
        End If
    End Sub

    Private Sub cmdAgregarHora_Click(sender As Object, e As EventArgs) Handles cmdAgregarHora.Click

        GuardarDetalleRegistroAnestesia()
        ActualizarGrillaDetalleRegistroAnestesia(lblConsecutivo.Text)

    End Sub

    Private Sub gvAnestesia_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvAnestesia.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdDetalleRegistroAnestesia = gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub cmdEliminarHora_Click(sender As Object, e As EventArgs) Handles cmdEliminarHora.Click
        If _ClickIdDetalleRegistroAnestesia = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Anestesia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf GVDetalleOrden.RowCount = 1 And txtConsecutivo.Text <> "" Then
            '    MessageBox.Show("La Orden no puede quedar sin detalle. Agregue el servicio correcto y luego elimine el incorrecto", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleRegistroAnestesia.Eliminar(_ClickIdDetalleRegistroAnestesia)
            ActualizarGrillaDetalleRegistroAnestesia(lblConsecutivo.Text)
            _ClickIdDetalleRegistroAnestesia = ""
        End If
    End Sub

    Private Sub gvAnestesia_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvAnestesia.RowUpdated
        If e.RowHandle >= 0 Then
            _DDetalleRegistroAnestesia.ActualizarDetalleRegistroAnestesia(gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "ID"), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "O2").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "ANESTESIA").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "FC").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "FR").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "DIURESIS").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "TA").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "PVC").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "V").ToString(), gvAnestesia.GetRowCellValue(e.RowHandle.ToString, "SATO").ToString())
        End If
    End Sub
End Class
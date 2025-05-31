Imports DevExpress.XtraEditors.Repository
Imports SIM___GLOBAL.Utilidades
Public Class frmHistoriaGrupal
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickGrillaTemporal As String
    Dim _ClickGrillaIdContrato As String
    Dim _ClickGrillaContrato As String
    Dim _Fila As Integer
    Dim _idDetalleOrden As String

    Public _Especialista As String



    Dim _dHistoria As New SIM___INTEGRA.Controles.DHistoriaIntegra
    Dim _DTemporal As New SIM___INTEGRA.Controles.DTemporal
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes
    Dim _dEmpleados As New SIM___GLOBAL.Controles.DEmpleados
    Dim _dDetelleOrden As New SIM___GLOBAL.Controles.DDetalleOrden

    Dim _Historia As New SIM___INTEGRA.Modelo.HistoriaIntegra
    Dim _Ordenes As SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
    Private Sub ActivarGuardar()
        If gvTemporal.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ListarPacientesAtender()
        Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
        _ds = _dOrdenes.ListarPacientesIntegra
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        _DTemporal.EliminarGrupal(IdEmpleado)
        txtReporteEvolucion.Text = ""
        txtContrato.Text = ""
        ListarPacientesTemporales()
        cboProcedimiento.ItemIndex = -1
        cboProcedimiento.EditValue = ""
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ListarPacientesTemporales()
        Dim _dTemporal = New SIM___INTEGRA.Controles.DTemporal
        Dim _ds As DataSet
        _ds = _dTemporal.Listar(IdEmpleado)
        gcTemporal.DataSource = _ds.Tables(0)

        'Dim RICheckEdit As New RepositoryItemCheckEdit()
        'GCTemporal.RepositoryItems.Add(RICheckEdit)
        'GVTemporal.Columns("FIRMA").ColumnEdit = RICheckEdit
        'GCTemporal.
        'If _ds.Tables(0).Rows(0)(3).ToString = "0" Then
        ' chkFirma.ValueChecked = False
        ' Else
        ' chkFirma.ValueChecked = True
        'End If


    End Sub
    Function ExisteHistoria() As Boolean
        Dim _ds = New DataSet
        _ds = _dHistoria.ExisteHistoriaEmpleado(_dOrdenes.CargarIDUsuario(_ClickGrilla), IdEmpleado)
        If _ds.Tables(0).Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub GuardarTemporal()
        Dim _temporal = New SIM___INTEGRA.Modelo.Temporal
        _temporal.IdOrden = _ClickGrilla
        _temporal.Nombre = GVPacientesAtender.GetRowCellValue(_Fila, "USUARIO").ToString()
        _temporal.IdEmpleado = IdEmpleado
        _DTemporal.Guardar(_temporal)
        ListarPacientesTemporales()
    End Sub
    Private Sub GuardarDetalleOrden(ByVal FiltroOrden As String, ByVal Diagnostico As String)
        'Guardamos Detalle de Orden Automatico
        _DetalleOrden.IdOrden = Val(FiltroOrden)
        _DetalleOrden.IdCausa = Val("15")
        _DetalleOrden.IdFinalidadConsulta = Val("10")
        _DetalleOrden.IdFinalidadProcedimiento = Val("1")
        _DetalleOrden.IdAmbito = Val("1")
        _DetalleOrden.IdPersonaAtiende = Val("1")
        _DetalleOrden.FechaSalida = Format(DateTime.Now, "dd/MM/yyyy")
        _DetalleOrden.Hora = DateTime.Now
        _DetalleOrden.IdTipoDiagnostico = Val("1")
        _DetalleOrden.Diagnostico1 = Diagnostico
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
        _Historia.IdOrden = FiltroOrden
        _Historia.IdDetalleOrden = Val(_idDetalleOrden)
        '_Historia.CodigoHistoria = txtCodigoHistoria.Text
        _Historia.Fecha = dtFechaIngreso.Text
        _Historia.Hora = DateTime.Now
        _Historia.MotivoConsulta = ""
        _Historia.AntecedentesPersonales = ""
        _Historia.AntecedentesFamiliares = ""
        _Historia.Valoracion = ""
        _Historia.PlanSeguir = ""
        _Historia.ReporteEvolucion = txtReporteEvolucion.Text
        _Historia.Remision = ""
        _Historia.CodigoDiagnostico = Diagnostico
        _Historia.Cita = "C"
        _Historia.IdEspecialidad = IdEspecialidad
        _Historia.IdEmpleado = IdEmpleado
        _Historia.Estado = "A"
        _idDetalleOrden = _dHistoria.GuardarHistoriayDetalle(_DetalleOrden, _Historia)
        '_DDetalleOrden.GuardarDetalleOrden(_DetalleOrden)
        'MsgBox(_idDetalleOrden)


    End Sub


    Private Sub FrmHistoriaGrupal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
        ListarPacientesAtender()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtEspecialista.Text = _Especialista


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
            _ClickGrillaContrato = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CONTRATO").ToString()
            _ClickGrillaIdContrato = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_CONTRATO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Agregar a la Historia Grupal", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _dHistoria.ExisteHistoriaEspecialista(_dOrdenes.CargarIDUsuario(_ClickGrilla), IdEspecialidad) = False Then
            MessageBox.Show("El Paciente No Tiene Valoracion Inicial", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DTemporal.Existe(_ClickGrilla, IdEmpleado) = True Then
            MessageBox.Show("El Paciente ya fue agregado al Listado", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ExisteHistoria = True Then
            MessageBox.Show("El Paciente ya presenta evolucion el dia de hoy", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtContrato.Text = "" Then
                GuardarTemporal()
                txtContrato.Text = _ClickGrillaContrato

                'llenamos combo procedimientos
                Dim _DDetalleTarifa = New SIM___GLOBAL.Controles.DDetalleTarifas
                _ds = New DataSet()
                _ds = _DDetalleTarifa.ListarCombo2(_ClickGrillaIdContrato)
                cboProcedimiento.Properties.DataSource = _ds.Tables(0)
                cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
                cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
                cboProcedimiento.ItemIndex = -1

            ElseIf txtContrato.Text <> _ClickGrillaContrato Then
                MessageBox.Show("El Paciente no Pertenece al Contrato Actual", "Contrato Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarTemporal()
            End If
        End If

    End Sub

    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If _ClickGrillaTemporal = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Eliminar del listado", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Eliminar el Paciente del Listado Historia Grupal?", "Historia Grupal", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                _DTemporal.Eliminar(_ClickGrillaTemporal, IdEmpleado)
                ListarPacientesTemporales()
                _ClickGrillaTemporal = ""
                If gvTemporal.RowCount = 0 Then
                    txtReporteEvolucion.Text = ""
                    txtContrato.Text = ""
                    bbiGuardar.Enabled = False

                End If
            End If
        End If
    End Sub

    Private Sub TxtReporteEvolucion_EditValueChanged(sender As Object, e As EventArgs) Handles txtReporteEvolucion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GvTemporal_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvTemporal.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaTemporal = gvTemporal.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            '_ClickGrillaFirma = GVTemporal.GetRowCellValue(e.RowHandle.ToString, "FIRMA").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub BbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If gvTemporal.RowCount = 0 Then
            MessageBox.Show("No ha Seleccionado ningun paciente", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProcedimiento.Text = "" Then
            MessageBox.Show("El Campo Consulta es Obligatorio", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtReporteEvolucion.Text = "" Then
            MessageBox.Show("El Campo Reporte de Evolucion es Obligatorio", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Antes de guardar por favor verifique que los datos esten correctos. Desea guardar las historias seleccionadas?", "Guardar Historia Grupal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim i As Integer = 0
                Do While i < gvTemporal.RowCount
                    '                    GuardarHistoria(gvTemporal.GetRowCellValue(i, "ORDEN").ToString())
                    If gvTemporal.GetRowCellValue(i, "FIRMA").ToString = "SI" Then
                        'MsgBox("FIRMADA")
                        GuardarDetalleOrden(gvTemporal.GetRowCellValue(i, "ORDEN").ToString, gvTemporal.GetRowCellValue(i, "DIAGNOSTICO").ToString)
                        _dDetelleOrden.ActualizarEstado(_idDetalleOrden)
                        _idDetalleOrden = ""
                    Else
                        'MsgBox("SIN FIRMAR")
                        GuardarDetalleOrden(gvTemporal.GetRowCellValue(i, "ORDEN").ToString, gvTemporal.GetRowCellValue(i, "DIAGNOSTICO").ToString)
                        _idDetalleOrden = ""
                    End If
                    i = i + 1
                Loop
                MessageBox.Show("Las historias se guardaron satisfactoriamente", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            End If
        End If
    End Sub
End Class
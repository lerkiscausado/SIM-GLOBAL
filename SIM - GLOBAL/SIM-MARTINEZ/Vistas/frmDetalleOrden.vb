﻿Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Public Class frmDetalleOrden
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _dDetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
    Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
    Dim _DDetalleTarifa = New SIM___GLOBAL.Controles.DDetalleTarifas
    Dim _ds As DataSet
    Dim _ClickGrillaDetalleOrden As String
    Dim _Fila As Integer
    Dim _IDContrato As Integer
    Dim _IdSubentidad As Integer
    Dim _IdTipoEstudio As Integer
    Dim _TipoAtencion As String
    Dim _ActivarGuardar As Byte
    Shared _conn As New OdbcConnection
    Dim _frmListadoOrdenes As New SIM_MARTINEZ.frmListadoOrdenes
    Public Sub ActualizarOrden()
        MsgBox("DETALLE ORDEN")
        '_dOrdenes.ActualizarCamposOrdenes(deFechaOrden.Text, txtNumeroOrden.Text, txtAutorizacion.Text, txtOrden.Text,)
    End Sub

    Private Sub LimpiarCamposDetalleOrden()
        cboProcedimiento.Properties.ValueMember = Nothing
        txtCodigoProcedimiento.Text = ""
        txtValor.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
    End Sub
    Private Sub GuardarDetalleOrden()
        Try

            _DetalleOrden.IdOrden = txtOrden.Text
            _DetalleOrden.IdCausa = "15"
            _DetalleOrden.IdFinalidadConsulta = "10"
            _DetalleOrden.IdFinalidadProcedimiento = "1"
            _DetalleOrden.IdAmbito = "1"
            _DetalleOrden.IdPersonaAtiende = "1"
            '_DetalleOrden.FechaSalida = ""
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.IdTipoDiagnostico = "1"
            '_DetalleOrden.Diagnostico1 = ""
            '_DetalleOrden.Diagnostico2 = ""
            '_DetalleOrden.Diagnostico3 = ""
            '_DetalleOrden.Diagnostico4 = ""
            _DetalleOrden.IdFormaRealizacion = "1"
            _DetalleOrden.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrden.CodigoCups = txtCodigoCups.Text
            _DetalleOrden.IdTipoEstudio = _IdTipoEstudio
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.Tipo = _TipoAtencion
            _DetalleOrden.Estado = "PENDIENTE"
            _dDetalleOrden.GuardarDetalleOrden(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub


    Private Sub ActualizarGrillaDetalleOrden()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dDetalleOrden.Listar(txtOrden.Text)
        GCDetalleOrden.DataSource = _ds.Tables(0)
        'GVDetalleOrden.Columns(0).Visible = False
        'GVDetalleOrden.Columns(1).BestFit()
        'GVDetalleOrden.Columns(2).BestFit()
        'GVDetalleOrden.Columns(3).BestFit()
        '----------------------------------
    End Sub
    Private Sub frmDetalleOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ActivarGuardar = 0
        'TRAER CONTRATO
        _Ordenes = _dOrdenes.Cargar(txtOrden.Text)
        _IDContrato = _Ordenes.IdContrato
        _IdSubentidad = _Ordenes.IdSubEntidad

        'llenamos combo subentidades
        Dim _DSubentidades = New SIM___GLOBAL.Controles.DSudentidades
        _ds = New DataSet()

        _ds = _DSubentidades.ListarComboActivas(_IDContrato, "I")
        cboSubentidad.Properties.DataSource = _ds.Tables(0)
        cboSubEntidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSubEntidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboSubentidad.Properties.PopulateColumns()
        'cboSubentidad.Properties.Columns("ID").Visible = False

        cboSubentidad.ItemIndex = cboSubentidad.Properties.GetDataSourceRowIndex("ID", _IdSubentidad)
        'cboSubentidad.Text = "NO APLICA"
        '_ds = New DataSet()
        '_ds = _DDetalleTarifa.ListarCombo2(_Ordenes.IdContrato)
        'cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        'cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        'cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboProcedimiento.ItemIndex = -1

        'llenamos combo procedimientos
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarComboanexos(_IDContrato)
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        ActualizarGrillaDetalleOrden()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodigoProcedimiento.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Procedimiento a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Val(txtValor.EditValue) - Val(txtCopago.EditValue)) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            GuardarDetalleOrden()
            ActualizarGrillaDetalleOrden()
            LimpiarCamposDetalleOrden()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDETAlleorden.GetRowCellValue(_Fila, "ESTADO").ToString() = "ATENDIDO" Then
            MessageBox.Show("Este registro no se puede eliminar porque se encuentra en estado ATENDIDO", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _dDetalleOrden.Eliminar(_ClickGrillaDetalleOrden)
            ActualizarGrillaDetalleOrden()
            _ClickGrillaDetalleOrden = ""
        End If
    End Sub

    Private Sub GVDetalleOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleOrden.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDetalleOrden = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub cboProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.EditValueChanged
        If cboProcedimiento.Text <> "" And txtOrden.Text <> "" Then
            _ds = New DataSet
            _ds = _DDetalleTarifa.ListarValor(_IDContrato, cboProcedimiento.EditValue)

            'MsgBox(_ds.Tables(0).Rows(0)(0).ToString)
            txtCodigoProcedimiento.Text = _ds.Tables(0).Rows(0)(0).ToString
            _IdTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString
            txtValor.Text = _ds.Tables(0).Rows(0)(2).ToString
            txtCodigoCups.Text = _ds.Tables(0).Rows(0)(3).ToString
            _TipoAtencion = _ds.Tables(0).Rows(0)(4).ToString
        End If
    End Sub

    Private Sub frmDetalleOrden_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.Cancel = False And _ActivarGuardar = 1 Then
            ActualizarOrden()
        End If
    End Sub

    Private Sub deFechaOrden_EditValueChanged(sender As Object, e As EventArgs) Handles deFechaOrden.EditValueChanged
        _ActivarGuardar = 1
    End Sub

    Private Sub txtNumeroOrden_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroOrden.EditValueChanged
        _ActivarGuardar = 1
    End Sub

    Private Sub txtAutorizacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtAutorizacion.EditValueChanged
        _ActivarGuardar = 1
    End Sub

    Private Sub GVDetalleOrden_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVDetalleOrden.RowUpdated
        If e.RowHandle >= 0 Then
            'If Val(GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString()) < 0 Then
            '' MessageBox.Show("El Valor que esta ingresando es negativo", "Actualización del Valor del Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf Val(GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "COPAGO").ToString()) < 0 Then
            '   MessageBox.Show("El Copago que esta ingresando es negativo", "Actualización del Copago del Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            _dOrdenes.ActualizarValoryCopago(GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString(), GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString(), GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "COPAGO").ToString())
            '   End If
        End If

    End Sub

    Private Sub cboSubentidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboSubentidad.EditValueChanged
        _ActivarGuardar = 1
    End Sub
End Class
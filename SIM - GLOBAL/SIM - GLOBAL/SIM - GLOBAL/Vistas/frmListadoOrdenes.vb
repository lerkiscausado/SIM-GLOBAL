Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
'import para validar
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
'*************************************
Public Class frmListadoOrdenes
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ClickGrilla As String
    Dim _ClickGrillaF As String
    Dim _Fila As String
    Dim _ds As DataSet
    Dim _dOrdenes As New DOrdenes

    ReadOnly _contratos As New DContratos
    ReadOnly _dDetalletarifa = New DDetalleTarifas
    Private Sub Actualizar()
        'llenamos Grilla Ordenes Atendidas
        _ds = New DataSet
        _ds = _dOrdenes.AuditoriaOrdenes
        GCOrdenesAtendidas.DataSource = _ds.Tables(0)
        'llenamos Grilla Ordenes A Facturar
        _ds = New DataSet
        _ds = _dOrdenes.OrdenesAuditadas
        GCOrdenesFacturar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub frmListadoOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
        Select Case Licencia
            Case 2, 6, 11 ' ESPECIALIDAD PATOLOGIA CITOPAT, KELLY, INMUNOPAT
                gvColID.Visible = False
                ColFacID.Visible = False
        End Select
    End Sub

    Private Sub bbConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbConsultar.ItemClick
        If GVOrdenesAtendidas.OptionsFind.AlwaysVisible = True Then
            GVOrdenesAtendidas.OptionsFind.AlwaysVisible = False
            GVOrdenesFacturar.OptionsFind.AlwaysVisible = False
        Else
            GVOrdenesAtendidas.OptionsFind.AlwaysVisible = True
            GVOrdenesFacturar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgregar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar una Orden ya Auditada", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrilla, "A")
            _ClickGrilla = ""
            Actualizar()
        End If

    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        If _ClickGrillaF = "" Then
            MessageBox.Show("Debe Seleccionar una Orden a Agregar al Listado a Facturar", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrillaF, "P")
            _ClickGrillaF = ""
            Actualizar()
        End If
    End Sub

    Private Sub GVOrdenesAtendidas_RowClick(sender As Object, e As RowClickEventArgs) Handles GVOrdenesAtendidas.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVOrdenesAtendidas.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If

    End Sub

    Private Sub GVOrdenesFacturar_RowClick(sender As Object, e As RowClickEventArgs) Handles GVOrdenesFacturar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaF = GVOrdenesFacturar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiDetalleOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetalleOrden.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar una Orden a Editar", "DETALLE DE ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmOpen As New frmDetalleOrden
            'Enviamos Valores a DEtalle Orden
            _frmOpen.txtOrden.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "ORDEN").ToString()
            _frmOpen.txtConsecutivo.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "CONSECUTIVO").ToString()
            _frmOpen.deFechaIngreso.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "FECHA_INGRESO").ToString()
            _frmOpen.txtIdentificacion.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "IDENTIFICACION").ToString()
            _frmOpen.txtPaciente.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "PACIENTE").ToString()
            '_frmOpen.txtContrato.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "CONTRATO").ToString()
            '_frmOpen.txtEntidad.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "ENTIDAD").ToString()
            _frmOpen.deFechaOrden.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "FECHA_ORDEN").ToString()
            _frmOpen.txtAutorizacion.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "AUTORIZACION").ToString()
            _frmOpen.Licencia = Licencia
            _frmOpen.ShowDialog()
            Actualizar()
        End If
    End Sub

    Private Sub bbiAgregarTodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgregarTodo.ItemClick
        If GVOrdenesAtendidas.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Agregar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Agregar los Registros Seleccionados?", "Agregar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVOrdenesAtendidas.DataRowCount
                    _dOrdenes.AgregarOrdenes(GVOrdenesAtendidas.GetRowCellValue(_Fila, "ORDEN").ToString(), "A")
                    _Fila = _Fila + 1
                End While
                Actualizar()
            End If
        End If
    End Sub

    Private Sub bbiEliminarTodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarTodo.ItemClick
        If GVOrdenesFacturar.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Eliminar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Eliminar los Registros Seleccionados?", "Eliminar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVOrdenesFacturar.DataRowCount
                    _dOrdenes.AgregarOrdenes(GVOrdenesFacturar.GetRowCellValue(_Fila, "ORDEN").ToString(), "P")
                    _Fila = _Fila + 1
                End While
                Actualizar()
            End If
        End If

    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GVOrdenesAtendidas.ShowPrintPreview()
    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCOrdenesAtendidas.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCOrdenesAtendidas.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub
End Class
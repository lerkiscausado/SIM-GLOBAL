Public Class frmHistoriasAnteriores
    Dim _ClickGrilla As String
    Dim _ClickCita As String
    Dim _ClickEstado As String
    Dim _fila As Integer
    Private Sub FrmHistoriasAnteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _dHistorias As New SIM___INTEGRA.Controles.DHistoriaIntegra
        Dim _ds As DataSet
        _ds = _dHistorias.HistoriasAnteriores
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)
    End Sub

    Private Sub GVHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "IDDETALLE").ToString()
            _ClickCita = GVHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "CITA").ToString()
            _ClickEstado = GVHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub BbiVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaPrevia.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmVistaHistoria
        _frmOpen.IdDetalleOrden = _ClickGrilla
        _frmOpen.ShowDialog()
    End Sub

    Private Sub TsmVistaPrevia_Click(sender As Object, e As EventArgs) Handles tsmVistaPrevia.Click
        Dim _frmOpen As New SIM___INTEGRA.frmVistaHistoria
        _frmOpen.IdDetalleOrden = _ClickGrilla
        _frmOpen.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        Dim _dHistorias As New SIM___INTEGRA.Controles.DHistoriaIntegra
        Dim _ds As DataSet
        If _ClickGrilla <> "" Then
            _ds = _dHistorias.HistoriasAnteriores
            GCHistoriasAnteriores.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub TsmActualizarGrilla_Click(sender As Object, e As EventArgs) Handles tsmActualizarGrilla.Click
        Dim _dHistorias As New SIM___INTEGRA.Controles.DHistoriaIntegra
        Dim _ds As DataSet
        If _ClickGrilla <> "" Then
            _ds = _dHistorias.HistoriasAnteriores
            GCHistoriasAnteriores.DataSource = _ds.Tables(0)
        End If

    End Sub

    Private Sub BbiBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBuscar.ItemClick
        If GVHistoriasAnteriores.OptionsFind.AlwaysVisible = True Then
            GVHistoriasAnteriores.OptionsFind.AlwaysVisible = False
        Else
            GVHistoriasAnteriores.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub BbiExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExcel.ItemClick
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCHistoriasAnteriores.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub BbiPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPDF.ItemClick
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCHistoriasAnteriores.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub TsmPDF_Click(sender As Object, e As EventArgs) Handles tsmPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCHistoriasAnteriores.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub TsmExcel_Click(sender As Object, e As EventArgs) Handles tsmExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCHistoriasAnteriores.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado la historia", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickEstado <> "ATENDIDO" Then
            MessageBox.Show("La historia seleccionada no puede imprimirse. Verifique si esta firmada", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _DHistoriaIntegra As New SIM___INTEGRA.Controles.DHistoriaIntegra
            If _DHistoriaIntegra.ExisteRemision(_ClickGrilla) = True Then
                Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                ImprimirFrm.CargarReporte("Remision.rpt", _ClickGrilla)
            Else
                MessageBox.Show("La historia no tiene remisión", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub bbiImprimirHistoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirHistoria.ItemClick

        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado la historia", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickEstado <> "ATENDIDO" Then
            MessageBox.Show("La historia seleccionada no puede imprimirse. Verifique si esta firmada", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickCita = "P" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("HistoriaPrimeraVez.rpt", _ClickGrilla)
        Else
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("control.rpt", _ClickGrilla)
        End If
    End Sub
End Class
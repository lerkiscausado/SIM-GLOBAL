Imports DevExpress.XtraGrid.Views.Base

Public Class frmFacturacionSandra
    Public Admin As String
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim Estado As String
    Dim _DFacturas As New SIM___GLOBAL.Controles.DFacturas
    Public Licencia As String
    Public IDEmpleado As String

    Private Sub frmFacturacionSandra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = _DFacturas.RelacionFactura()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiExportarPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPDF.ItemClick
        If GVConsultar.DataRowCount <> 0 Then
            sfdRuta.Filter = "Archivo PDF |*.pdf"
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GCConsultar.ExportToPdf(sfdRuta.FileName)
            End If
        Else
            MessageBox.Show("No se encontro información a exportar", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        If GVConsultar.DataRowCount <> 0 Then
            sfdRuta.Filter = "Archivo Excel |*.xls"
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GCConsultar.ExportToXls(sfdRuta.FileName)
            End If
        Else
            MessageBox.Show("No se encontro información a exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub GVConsultar_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GVConsultar.RowUpdated
        If e.RowHandle >= 0 Then
            _DFacturas.actualizarAutorizacion(GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString(), GVConsultar.GetRowCellValue(e.RowHandle.ToString, "AUTORIZACION").ToString())
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        _ds = _DFacturas.RelacionFactura()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
End Class
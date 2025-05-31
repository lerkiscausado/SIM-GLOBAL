Public Class frmConsultar
    Dim _ds As DataSet
    Dim _Fila As Integer
    Public Sub Recargar()
        Try
            'TODO: esta línea de código carga datos en la tabla 'DsVistas.dtOrdenes' Puede moverla o quitarla según sea necesario.
            'Me.DtOrdenesTableAdapter.Fill(Me.DsVistas.dtOrdenes)

            Dim _DOrdenes = New SIM___GLOBAL.Controles.DOrdenes
            _ds = _DOrdenes.ListarIntegra
            GCConsultar.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmExcel_Click(sender As Object, e As EventArgs) Handles tsmExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmPDF_Click(sender As Object, e As EventArgs) Handles tsmPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmActualizarGrilla_Click(sender As Object, e As EventArgs) Handles tsmActualizarGrilla.Click
        Recargar()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            Registro = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

End Class
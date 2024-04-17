'Imports SIM.Controles
'Imports SIM.Modelo
'Imports SIM___GLOBAL
Public Class frmConsultar
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim AAAA As String
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    'Dim _dordenes As New DOrdenes
    Public Sub Recargar(ByVal filtro As String)
        Try
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.dtOrdenes' Puede moverla o quitarla según sea necesario.
            '   Me.DtOrdenesTableAdapter.Fill(Me.DSVistas.dtOrdenes)
            AAAA = filtro
            bwCargar.RunWorkerAsync()
            ppCargar.Visible = True

        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.dtOrdenes' Puede moverla o quitarla según sea necesario.
        'Me.DtOrdenesTableAdapter.Fill(Me.DSVistas.dtOrdenes)
        AAAA = "2020"
        bwCargar.RunWorkerAsync()
        ppCargar.Visible = True



    End Sub


    Private Sub frmConsultar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        IDORdenG = Nothing
        IDDetalleOrdenG = Nothing
    End Sub



    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs)

        GCConsultar.PrintDialog()

    End Sub

    Private Sub tsmExcel_Click(sender As Object, e As EventArgs)
        'sfdRuta.Filter = "Archivo Excel |*.xls"
        'If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        ' GCConsultar.ExportToXls(sfdRuta.FileName)
        ' End If
    End Sub

    Private Sub tsmVistaPrevia_Click(sender As Object, e As EventArgs)
        GCConsultar.ShowPrintPreview()

    End Sub

    Private Sub tsmPDF_Click(sender As Object, e As EventArgs)
        ' sfdRuta.Filter = "Archivo PDF |*.pdf"
        ' If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        ' GCConsultar.ExportToPdf(sfdRuta.FileName)
        'End If
    End Sub

    Private Sub GCConsultar_Click(sender As Object, e As EventArgs) Handles GCConsultar.Click

    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            IDORdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            IDDetalleOrdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "DETALLE").ToString()
            _Fila = e.RowHandle.ToString

        End If
    End Sub

    Private Sub bwCargar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwCargar.DoWork
        _ds = _dOrdenes.ListarOrdenesMartinez(AAAA)

    End Sub

    Private Sub bwCargar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwCargar.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("La acción ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            'MessageBox.Show("Laación en segundo plano ha finalizado con éxito.")
            GCConsultar.DataSource = _ds.Tables(0)
            ppCargar.Visible = False

        End If
    End Sub

    Private Sub TsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub TsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub TsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        Recargar("2020")
    End Sub

    Private Sub tsm2020_Click(sender As Object, e As EventArgs) Handles tsm2020.Click
        Recargar("2020")
    End Sub

    Private Sub tsm2019_Click(sender As Object, e As EventArgs) Handles tsm2019.Click
        Recargar("2019")
    End Sub

    Private Sub tsm2018_Click(sender As Object, e As EventArgs) Handles tsm2018.Click
        Recargar("2018")
    End Sub

    Private Sub tsm2017_Click(sender As Object, e As EventArgs) Handles tsm2017.Click
        Recargar("2017")
    End Sub
End Class
Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rptOrdenCompra As New rptHistoriaClinica
            'rptOrdenCompra.SetParameterValue("filtro", "3")
            'rptOrdenCompra.SetParameterValue("licencia", 9)
            crv.ReportSource = rptOrdenCompra
            ' crv.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
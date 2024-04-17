Public Class frmPDF
    Public Consecutivo As String
    Private Sub frmPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PdfAdjuntos.LoadDocument(path:="C:\SIM\OneDrive\Resultados\" & Consecutivo & ".pdf")
    End Sub
End Class
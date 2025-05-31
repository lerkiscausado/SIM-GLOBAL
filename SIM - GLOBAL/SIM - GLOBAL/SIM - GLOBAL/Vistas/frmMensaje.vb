Public Class frmMensaje
    Public NumeroOrden As String
    Private Sub frmMensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lcNumeroOrden.Text = NumeroOrden
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class
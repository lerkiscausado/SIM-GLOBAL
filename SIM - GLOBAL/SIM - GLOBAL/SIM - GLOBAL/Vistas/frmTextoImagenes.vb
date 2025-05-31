Public Class frmTextoImagenes
    Public IdImagen As String
    Dim Imagen As Image

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim _DImagenes As New SIM___GLOBAL.Controles.DImagenes
        _DImagenes.ActualizarEstadoImagen(IdImagen, "A", txtTexoImagenes.Text, imagen)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
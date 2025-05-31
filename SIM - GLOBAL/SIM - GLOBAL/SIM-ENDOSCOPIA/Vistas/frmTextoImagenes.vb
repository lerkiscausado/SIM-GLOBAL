Public Class frmTextoImagenes
    Public IdImagen As String
    Dim Imagen As Image

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim _DImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        _DImagenes.ActualizarEstadoImagen(IdImagen, "A", txtTexoImagenes.Text, Imagen)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
Imports SIM___GLOBAL.Utilidades
Public Class frmSeguridad
    Public Licencia As String
    Public IdEmpleado As String
    Dim _DUsers As New SIM___GLOBAL.Controles.DUsers
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Public idEmpleado2 As String

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If Licencia = 17 Then
            If _DUsers.ValidarClave(IdEmpleado, txtContrasenaActual.Text) = False Then
                MessageBox.Show("Contraseña actual incorrecta", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtContrasenaNueva.Text = "" Then
                MessageBox.Show("No ha digitado la nueva contraseña", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtContrasenaNueva.Text <> txtConfirmarContrasena.Text Then
                MessageBox.Show("Al confirmar la contraseña no son iguales", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DUsers.CambiarClave(IdEmpleado, txtContrasenaNueva.Text)
                MessageBox.Show("Se cambio la contraseña satisfactoriamente", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            If _DUsers.ValidarClave(idEmpleado2, txtContrasenaActual.Text) = False Then
                MessageBox.Show("Contraseña actual incorrecta", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtContrasenaNueva.Text = "" Then
                MessageBox.Show("No ha digitado la nueva contraseña", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtContrasenaNueva.Text <> txtConfirmarContrasena.Text Then
                MessageBox.Show("Al confirmar la contraseña no son iguales", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DUsers.CambiarClave(idEmpleado2, txtContrasenaNueva.Text)
                MessageBox.Show("Se cambio la contraseña satisfactoriamente", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub


End Class
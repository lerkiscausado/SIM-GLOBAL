Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Imports System.Text.RegularExpressions
Public Class frmConfiguracionCorreo
    Public Licencia As String
    Dim dCorreo As New DConfiguracionCorreo
    Dim correo As New ConfiguracionCorreo
    Private Function ValidarMail(ByVal EMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(EMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub ActivaGuardar()
        btnGuardar.Enabled = True
    End Sub
    Private Sub frmConfiguracionCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dCorreo.Existe(Licencia) = True Then
            correo = dCorreo.Cargar(Licencia)
            txtCorreo.Text = correo.Correo
            txtPass.Text = correo.Pass
            txtServidor.Text = correo.Servidor
            txtPuerto.Text = correo.Puerto
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCorreo.Text = "" And txtPass.Text = "" And txtServidor.Text = "" And txtPuerto.Text = "" Then
            MessageBox.Show("Todos los Campos son Obligatorios", "Configuracion de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf validarmail(txtCorreo.Text) = False Then
            MessageBox.Show("El Campo Correo no es Valido", "Configuracion de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            correo.IdLicencia = Licencia
            correo.Correo = txtCorreo.Text
            correo.Pass = txtPass.Text
            correo.Servidor = txtServidor.Text
            correo.Puerto = txtPuerto.Text
            dCorreo.Guardar(correo)
            MessageBox.Show("Datos Guardados con Exito", "Configuracion de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCorreo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtPass_EditValueChanged(sender As Object, e As EventArgs) Handles txtPass.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtServidor_EditValueChanged(sender As Object, e As EventArgs) Handles txtServidor.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtPuerto_EditValueChanged(sender As Object, e As EventArgs) Handles txtPuerto.EditValueChanged
        ActivaGuardar()
    End Sub
End Class
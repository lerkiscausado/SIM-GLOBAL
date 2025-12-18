Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmSmtpConfig
    Public Licencia As String
    ReadOnly _DSmtpConfig = New DSmtpConfig
    Private Sub frmSmtpConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim config As New SmtpConfig
        config = _DSmtpConfig.cargar(1)
        txtNombre.Text = config.NombreConfig
        txtHost.Text = config.SmtpHost
        txtPuerto.Text = config.SmtpPort
        txtUsuario.Text = config.SmtpUser
        txtPass.Text = config.SmtpPassword
        txtDisplayName.Text = config.DisplayName

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        ' ======================
        '   VALIDAR CAMPOS
        ' ======================
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Debe ingresar un nombre de configuración.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtHost.Text) Then
            MessageBox.Show("Debe ingresar el host SMTP.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHost.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPuerto.Text) Or Not IsNumeric(txtPuerto.Text) Then
            MessageBox.Show("Debe ingresar un puerto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPuerto.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MessageBox.Show("Debe ingresar el usuario SMTP.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Debe ingresar la contraseña SMTP.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Exit Sub
        End If

        'If String.IsNullOrWhiteSpace(txtFrom.Text) Then
        '    XtraMessageBox.Show("Debe ingresar el correo remitente (From).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtFrom.Focus()
        ' Exit Sub
        ' End If

        ' Validar correo electrónico
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtUsuario.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("El correo remitente no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Focus()
            Exit Sub
        End If

        ' ======================
        '   GUARDAR DATOS
        ' ======================
        Try
            Dim smtp As New SmtpConfig With {
                .Id = 1, ' si estás editando, sino puedes dejarlo en ""
                .NombreConfig = txtNombre.Text.Trim(),
                .SmtpHost = txtHost.Text.Trim(),
                .SmtpPort = CInt(txtPuerto.Text),
                .SmtpUser = txtUsuario.Text.Trim(),
                .SmtpPassword = txtPass.Text.Trim(),
                .SmtpFrom = txtUsuario.Text.Trim(),
                .DisplayName = txtDisplayName.Text.Trim(),
                .EnableSsl = chkSSL.Checked,
                .IsActive = 1
            }

            Dim dSmtp As New Controles.DSmtpConfig
            dSmtp.Guardar(smtp)

            MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.Controles

Public Class frmRDA

    ' Campos "Código Prestador (REPS)" y "NIT Prestador", requeridos para armar la Organization
    ' del Bundle RDA. Se agregan por código (no en el Designer) para no arriesgar el layout
    ' visual generado por el diseñador de Visual Studio, que no está disponible en este entorno.
    Private WithEvents txtCodigoPrestadorReps As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtNitPrestador As DevExpress.XtraEditors.TextEdit

    ' Botón de prueba: envía un RDA-Paciente con datos fijos (Lerki Causado / Jaime Bonfante /
    ' Gastrocaribe) usando la configuración y el token ya guardados, y muestra la respuesta cruda
    ' del API de MinSalud en un MessageBox.
    Private WithEvents spEnviarRDAPrueba As DevExpress.XtraEditors.SimpleButton

    Private Sub AgregarCamposPrestadorReps()
        If txtCodigoPrestadorReps IsNot Nothing Then Exit Sub ' Evitar duplicar si el Load se dispara más de una vez

        ' 1. Hacer espacio dentro del panel (2 campos nuevos + botón de prueba) y correr hacia
        '    abajo lo que va después de él, conservando el margen original (6px) entre el panel
        '    y el estado del servicio.
        Const desplazamiento As Integer = 170
        GroupControl2.Size = New Size(GroupControl2.Size.Width, GroupControl2.Size.Height + desplazamiento)
        lblEstadoServicio.Location = New Point(lblEstadoServicio.Location.X, lblEstadoServicio.Location.Y + desplazamiento)
        spConectar.Location = New Point(spConectar.Location.X, spConectar.Location.Y + desplazamiento)
        spGuardar.Location = New Point(spGuardar.Location.X, spGuardar.Location.Y + desplazamiento)
        spCancelar.Location = New Point(spCancelar.Location.X, spCancelar.Location.Y + desplazamiento)
        Me.ClientSize = New Size(Me.ClientSize.Width, Me.ClientSize.Height + desplazamiento)

        ' 2. Etiquetas + campos, siguiendo el mismo espaciado (52px) de las filas existentes.
        Dim lblCodigoPrestador As New DevExpress.XtraEditors.LabelControl()
        lblCodigoPrestador.Text = "Cód. Prestador (REPS):"
        lblCodigoPrestador.Location = New Point(11, 178)

        Dim lblNitPrestador As New DevExpress.XtraEditors.LabelControl()
        lblNitPrestador.Text = "NIT Prestador:"
        lblNitPrestador.Location = New Point(11, 230)

        txtCodigoPrestadorReps = New DevExpress.XtraEditors.TextEdit()
        txtCodigoPrestadorReps.Location = New Point(106, 175)
        txtCodigoPrestadorReps.Size = New Size(395, 20)
        txtCodigoPrestadorReps.Properties.Appearance.BackColor = Color.White
        txtCodigoPrestadorReps.Properties.Appearance.Options.UseBackColor = True

        txtNitPrestador = New DevExpress.XtraEditors.TextEdit()
        txtNitPrestador.Location = New Point(106, 227)
        txtNitPrestador.Size = New Size(395, 20)
        txtNitPrestador.Properties.Appearance.BackColor = Color.White
        txtNitPrestador.Properties.Appearance.Options.UseBackColor = True

        GroupControl2.Controls.Add(lblCodigoPrestador)
        GroupControl2.Controls.Add(txtCodigoPrestadorReps)
        GroupControl2.Controls.Add(lblNitPrestador)
        GroupControl2.Controls.Add(txtNitPrestador)

        ' 3. Botón "Enviar RDA de Prueba"
        spEnviarRDAPrueba = New DevExpress.XtraEditors.SimpleButton()
        spEnviarRDAPrueba.Text = "Enviar RDA de Prueba (Lerki Causado)"
        spEnviarRDAPrueba.Location = New Point(106, 270)
        spEnviarRDAPrueba.Size = New Size(300, 30)
        GroupControl2.Controls.Add(spEnviarRDAPrueba)
    End Sub

    Private Async Sub spEnviarRDAPrueba_Click(sender As Object, e As EventArgs) Handles spEnviarRDAPrueba.Click
        spEnviarRDAPrueba.Enabled = False
        Cursor = Cursors.WaitCursor
        Try
            Dim resultado As String = Await DRDAPaciente.EnviarRDAPruebaAsync()
            MessageBox.Show(resultado, "Resultado envío RDA de Prueba", MessageBoxButtons.OK,
                             If(resultado.StartsWith("✅"), MessageBoxIcon.Information, MessageBoxIcon.Error))
        Finally
            Cursor = Cursors.Default
            spEnviarRDAPrueba.Enabled = True
        End Try
    End Sub

    Private Async Sub spConectar_Click(sender As Object, e As EventArgs) Handles spConectar.Click
        Dim _dRDA As New DRDA
        ' 1. Cambiar el estado visual a "Cargando" para evitar bloqueos
        spConectar.Enabled = False
        lblEstadoServicio.Text = "⏳ Validando credenciales con MinSalud..."
        lblEstadoServicio.ForeColor = Color.Orange

        Try
            ' 2. Capturar temporalmente los datos ingresados en el formulario en tu modelo
            Dim configTemporal As New ConfigInteropApi With {
                .Ambiente = If(rbSandbox.Checked, "SANDBOX", "PRODUCCION"),
                .TenantId = txtTenantID.Text.Trim(),
                .ClientId = txtClientID.Text.Trim(),
                .ClientSecret = txtClientSecret.Text.Trim(),
                .UrlAuthServer = txtURLAuth.Text.Trim()
            }

            ' 3. Invocar al servicio de autenticación que creamos previamente
            Dim tokenResponse As TokenResponse = Await InteropAuthService.SolicitarTokenAsync(configTemporal)

            ' 4. Si no lanza excepción y devuelve un token, la prueba es exitosa
            If tokenResponse IsNot Nothing AndAlso Not String.IsNullOrEmpty(tokenResponse.AccessToken) Then
                lblEstadoServicio.Text = "🟢 Conectado exitosamente al Sandbox de MinSalud"
                lblEstadoServicio.ForeColor = Color.Green
                ' MessageBox.Show("¡Conexión Exitosa! El servidor de MinSalud autorizó el acceso.",
                '"Interoperabilidad RDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' GUARDAR PROVISIONALMENTE el TOKEN
                Dim respuesta As DialogResult = MessageBox.Show(
                                "✅ Conexión Exitosa. El servidor de MinSalud autorizó el acceso." & Environment.NewLine & Environment.NewLine &
                                "¿Desea guardar el token generado?", "Interoperabilidad RDA",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                If respuesta = DialogResult.Yes Then
                    ' ── Guardar el token ─────────────────────────────────────

                    _dRDA.GuardarTokenCache(1, tokenResponse.AccessToken, "Bearer", tokenResponse.ExpiresIn)
                    MessageBox.Show("✅ Token guardado correctamente.",
                                    "Interoperabilidad RDA",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    ' ── No guardar el token ───────────────────────────────────
                    MessageBox.Show("⚠️ El token no fue guardado.",
                                    "Interoperabilidad RDA",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning)
                End If

            Else
                Throw New Exception("El servidor no retornó un token de acceso válido.")
            End If

        Catch ex As Exception
            ' Manejo de errores controlados (credenciales incorrectas, caídas de red, etc.)
            lblEstadoServicio.Text = "🔴 Error de autenticación / Sin conexión"
            lblEstadoServicio.ForeColor = Color.Red
            MessageBox.Show($"Fallo en la conexión: {ex.Message}", "Error de Interoperabilidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Restaurar el botón
            spConectar.Enabled = True
        End Try
    End Sub

    Private Sub spGuardar_Click(sender As Object, e As EventArgs) Handles spGuardar.Click
        Dim _dRDA As New DRDA
        Try
            ' Validaciones mínimas obligatorias antes de escribir en la BD
            If String.IsNullOrWhiteSpace(txtTenantID.Text) OrElse String.IsNullOrWhiteSpace(txtClientID.Text) Then
                MessageBox.Show("Por favor complete los campos obligatorios de identificación.",
                                "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Crear objeto de configuración con los datos limpios de la pantalla
            Dim configAGuardar As New ConfigInteropApi With {
                .Ambiente = If(rbSandbox.Checked, "SANDBOX", "PRODUCCION"),
                .TenantId = txtTenantID.Text.Trim(),
                .ClientId = txtClientID.Text.Trim(),' RECOMENDACIÓN: Implementa una función propia 'EncriptarCadena' para proteger el Secret en tu BD
                .ClientSecret = txtClientSecret.Text.Trim(),
                .SubscriptionKey = txtSubscriptionKey.Text.Trim(),
                .UrlAuthServer = txtURLAuth.Text.Trim(),
                .UrlBaseApi = txtURLBaseApi.Text.Trim(),
                .CodigoPrestadorReps = txtCodigoPrestadorReps.Text.Trim(),
                .NitPrestador = txtNitPrestador.Text.Trim(),
                .Estado = True,
                .FechaRegistro = DateTime.Now,
                .FechaActualizacion = DateTime.Now
            }

            ' Ejecutar tu método de persistencia (Aquí lo adaptas a tu capa de datos, ej: Entity Framework, Dapper o ADO.NET)
            If txtID.Text <> "" Then
                If _dRDA.Actualizar(configAGuardar) Then
                    MessageBox.Show("La configuración de la API RDA de MinSalud ha sido almacenada correctamente en SIM.",
                                 "Configuración Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' O refrescar el estado del formulario
                Else
                    Throw New Exception("No se pudo insertar el registro en la base de datos.")
                End If
            Else
                If _dRDA.Guardar(configAGuardar) Then
                    MessageBox.Show("La configuración de la API RDA de MinSalud ha sido almacenada correctamente en SIM.",
                                         "Configuración Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' O refrescar el estado del formulario
                Else
                    Throw New Exception("No se pudo insertar el registro en la base de datos.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error de Base de Datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub spVerClientSecret_Click(sender As Object, e As EventArgs) Handles spVerClientSecret.Click
        If txtClientSecret.Properties.PasswordChar = Chr(0) Then
            ' Actualmente visible -> Ocultar
            txtClientSecret.Properties.PasswordChar = "*"c
            'btnMostrarOcultarSecret.Text = "Mostrar"
            ' Si usas un botón con ícono en vez de texto, podrías cambiar la imagen aquí
        Else
            ' Actualmente oculto -> Mostrar
            txtClientSecret.Properties.PasswordChar = Chr(0)
            'btnMostrarOcultarSecret.Text = "Ocultar"
        End If
    End Sub

    Private Sub spVerSuscription_Click(sender As Object, e As EventArgs) Handles spVerSuscription.Click
        If txtSubscriptionKey.Properties.PasswordChar = Chr(0) Then
            ' Actualmente visible -> Ocultar
            txtSubscriptionKey.Properties.PasswordChar = "*"c
            'btnMostrarOcultarSecret.Text = "Mostrar"
            ' Si usas un botón con ícono en vez de texto, podrías cambiar la imagen aquí
        Else
            ' Actualmente oculto -> Mostrar
            txtSubscriptionKey.Properties.PasswordChar = Chr(0)
            'btnMostrarOcultarSecret.Text = "Ocultar"
        End If
    End Sub

    Private Sub frmRDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarCamposPrestadorReps()

        Dim _dRDA As New DRDA
        Dim configAGuardar As New ConfigInteropApi
        configAGuardar = _dRDA.Cargar()
        If configAGuardar.Ambiente = "SANDBOX" Then
            rbSandbox.Checked = True
        Else
            rbProduction.Checked = True
        End If
        txtID.Text = configAGuardar.Id
        txtTenantID.Text = configAGuardar.TenantId
        txtClientID.Text = configAGuardar.ClientId
        txtClientSecret.Text = configAGuardar.ClientSecret
        txtSubscriptionKey.Text = configAGuardar.SubscriptionKey
        txtURLAuth.Text = configAGuardar.UrlAuthServer
        txtURLBaseApi.Text = configAGuardar.UrlBaseApi
        txtCodigoPrestadorReps.Text = configAGuardar.CodigoPrestadorReps
        txtNitPrestador.Text = configAGuardar.NitPrestador
    End Sub

    Private Sub spCancelar_Click(sender As Object, e As EventArgs) Handles spCancelar.Click
        Me.Close()
    End Sub
End Class
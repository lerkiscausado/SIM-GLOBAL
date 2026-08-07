Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.Controles

Public Class frmRDA
    Private Async Sub spConectar_Click(sender As Object, e As EventArgs) Handles spConectar.Click
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
                MessageBox.Show("¡Conexión Exitosa! El servidor de MinSalud autorizó el acceso.",
                                "Interoperabilidad RDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        ' Crear objeto de configuración con los datos limpios de la pantalla
        Dim configAGuardar As New ConfigInteropApi With {
                    .Ambiente = If(rbSandbox.Checked, "SANDBOX", "PRODUCCION"),
                    .TenantId = txtTenantID.Text.Trim(),
                    .ClientId = txtClientID.Text.Trim(),' RECOMENDACIÓN: Implementa una función propia 'EncriptarCadena' para proteger el Secret en tu BD
                    .ClientSecret = txtClientSecret.Text.Trim(),
                    .SubscriptionKey = txtSubscriptionKey.Text.Trim(),
                    .UrlAuthServer = txtURLAuth.Text.Trim(),
                    .UrlBaseApi = txtURLBaseApi.Text.Trim(),
                    .Estado = True,
                    .FechaRegistro = DateTime.Now,
                    .FechaActualizacion = DateTime.Now
                }

        If txtID.Text <> "" Then
            'Dim configAGuardar As New ConfigInteropApi
            If _dRDA.Actualizar(configAGuardar) Then
                MessageBox.Show("La configuración de la API RDA de MinSalud ha sido almacenada correctamente en SIM.",
                             "Configuración Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' O refrescar el estado del formulario
            End If
        Else

            Try
                ' Validaciones mínimas obligatorias antes de escribir en la BD
                If String.IsNullOrWhiteSpace(txtTenantID.Text) OrElse String.IsNullOrWhiteSpace(txtClientID.Text) Then
                    MessageBox.Show("Por favor complete los campos obligatorios de identificación.",
                                "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Ejecutar tu método de persistencia (Aquí lo adaptas a tu capa de datos, ej: Entity Framework, Dapper o ADO.NET)
                If _dRDA.Guardar(configAGuardar) Then
                    MessageBox.Show("La configuración de la API RDA de MinSalud ha sido almacenada correctamente en SIM.",
                                 "Configuración Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' O refrescar el estado del formulario
                Else
                    Throw New Exception("No se pudo insertar el registro en la base de datos.")
                End If

            Catch ex As Exception
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error de Base de Datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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
        Dim _dRDA As New DRDA
        Dim configAGuardar As New ConfigInteropApi
        configAGuardar = _dRDA.Cargar()
        txtID.Text = configAGuardar.Id
        txtTenantID.Text = configAGuardar.TenantId
        txtClientID.Text = configAGuardar.ClientId
        txtClientSecret.Text = configAGuardar.ClientSecret
        If configAGuardar.Ambiente = "SANDBOX" Then
            rbSandbox.Checked = True
        Else
            rbProduction.Checked = True
        End If
        txtSubscriptionKey.Text = configAGuardar.SubscriptionKey
        txtURLAuth.Text = configAGuardar.UrlAuthServer
        txtURLBaseApi.Text = configAGuardar.UrlBaseApi
    End Sub

    Private Sub spCancelar_Click(sender As Object, e As EventArgs) Handles spCancelar.Click
        Me.Close()
    End Sub
End Class
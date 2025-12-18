Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Imports System.Text.RegularExpressions
Public Class frmMail
    ReadOnly _funciones As New Funciones
    Public Licencia As String
    Public IdDetalleOrden As String
    Public IdOrden As String
    Public IdFiltroAgora As String
    Public Asunto As String
    Public TipoEstudio As String
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    ReadOnly _DSmtpConfig = New DSmtpConfig
    Dim paciente As String
    Dim ruta As String
    Dim _ds As New DataSet

    Private Function ValidarMail(ByVal EMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(EMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub EnviarMail(ByVal EMail As String, ByVal Texto As String, ByVal Asunto As String)

        Try
            Dim config As New SmtpConfig
            config = _DSmtpConfig.cargar(1)
            Dim htmlBody As String = System.IO.File.ReadAllText("C:\estudios\plantilla_resultados.html")
            ' Reemplazar variables
            htmlBody = htmlBody.Replace("{{PACIENTE}}", paciente)
            htmlBody = htmlBody.Replace("{{AÑO}}", DateTime.Now.Year.ToString())
            Using correo As New System.Net.Mail.MailMessage()
                Using smtp As New System.Net.Mail.SmtpClient()

                    'CONFIGURACIÓN SMTP
                    smtp.Host = config.SmtpHost
                    smtp.Port = config.SmtpPort
                    smtp.EnableSsl = config.EnableSsl
                    smtp.Credentials = New System.Net.NetworkCredential(config.SmtpUser, config.SmtpPassword)
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network

                    'CONFIGURACIÓN DEL CORREO
                    correo.From = New System.Net.Mail.MailAddress(config.SmtpFrom)
                    correo.To.Add(EMail)
                    correo.Subject = Asunto
                    correo.Body = htmlBody
                    correo.IsBodyHtml = True
                    correo.Priority = System.Net.Mail.MailPriority.Normal

                    '📎 ARCHIVO ADJUNTO
                    Dim rutaAdjunto As String = "C:\estudios\pdf\" & ruta

                    If System.IO.File.Exists(rutaAdjunto) Then
                        Dim adjunto As New System.Net.Mail.Attachment(rutaAdjunto)
                        correo.Attachments.Add(adjunto)
                    Else
                        MessageBox.Show("Advertencia: el archivo adjunto no existe en la ruta especificada.",
                                    "Archivo no encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning)
                    End If

                    'ENVÍO
                    smtp.Send(correo)

                End Using
            End Using

            MessageBox.Show("Se ha enviado un correo al paciente confirmando su cita.",
                        "Correo enviado", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message,
                        "Error al enviar correo", MessageBoxButtons.OK)
        End Try

    End Sub



    Private Sub frmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case Licencia
            Case 17 ' AGORA

                _ds = _DOrdenes.UsuarioEmail(IdFiltroAgora)
                txtPara.Text = _ds.Tables(0).Rows(0)(1) 'Correo Electronico
                txtAsunto.Text = Asunto & " AGORA: " & IdFiltroAgora
            Case Else
                _ds = _DOrdenes.UsuarioEmail(IdOrden)
                txtPara.Text = _ds.Tables(0).Rows(0)(1) 'Correo Electronico
                txtAsunto.Text = "Reporte: " & TipoEstudio
                paciente = _ds.Tables(0).Rows(0)(2)
        End Select


        Try
            '    Se genera el reporte en PDF
            Select Case Licencia
                Case "11"
                    _funciones.GenerarPDF(IdOrden, TipoEstudio, 1, Licencia, IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
                Case Else
                    ruta = IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf"
                    _funciones.GenerarPDF(IdDetalleOrden, TipoEstudio, 1, Licencia, IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
            End Select

        Catch ex As Exception
            MsgBox(ex)
        End Try

        Try
            '    Se carga la vista previa del reporte
            PDF.LoadDocument(path:="c:\estudios\pdf\" & ruta)
        Catch ex As Exception
            MsgBox(ex)
        End Try

        If _ds.Tables(0).Rows(0)(1) <> "" Then 'Campo Correo Electronico
            ' _funciones.EnviarReporteMail(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, IDOrdenG & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf", _ds.Tables(0).Rows(0)(1).ToString)
        Else
            MessageBox.Show("El usuario no tiene correo electronico registrado", "Enviar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '_funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
    End Sub

    Private Sub btnDescartar_Click(sender As Object, e As EventArgs) Handles btnDescartar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        ' Validaciones básicas
        If String.IsNullOrWhiteSpace(txtPara.Text) Then
            MessageBox.Show("Debe ingresar un correo destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPara.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtAsunto.Text) Then
            MessageBox.Show("Debe ingresar un asunto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAsunto.Focus()
            Exit Sub
        End If


        ' Si todo está OK, enviamos el correo
        Try
            EnviarMail(txtPara.Text.Trim(),
                       "x",
                       txtAsunto.Text.Trim())
            ' Si el envío fue exitoso, cerramos el formulario
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentar enviar el correo: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub
End Class
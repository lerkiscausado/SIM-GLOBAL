Imports SIM___GLOBAL.Utilidades
Imports AGORA.Controles
Imports System.Text.RegularExpressions
Public Class frmMail
    Dim dCotizacion As New DCotizaciones
    Public Licencia As String
    Public IdFiltro As String
    Public Asunto As String
    Dim _ds As New DataSet
    ReadOnly _funciones As New Funciones
    Private Function ValidarMail(ByVal EMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(EMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub frmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Correo del Cliente
        _ds = dCotizacion.ClienteEmail(IdFiltro)
        txtPara.Text = _ds.Tables(0).Rows(0)(1) 'Correo Electronico
        txtAsunto.Text = Asunto & " No. " & IdFiltro

        Select Case Asunto
            Case "Cotizacion"
                'Generamos el PDF de la Cotizacion
                _funciones.GenerarPDFAgora(IdFiltro, 1, Licencia, IdFiltro & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
            Case "Orden de Servicio"
                'Generamos el PDF de la Cotizacion
                _funciones.GenerarPDFAgora(IdFiltro, 1, Licencia, IdFiltro & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        End Select

        Try
            '    Se carga la vista previa del reporte
            PDF.LoadDocument(path:="c:\sim\pdf\" & IdFiltro & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        Catch ex As Exception
            MsgBox(ex)
        End Try




    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If ValidarMail(txtPara.Text) = True Then
                'Generamos el PDF de la Cotizacion
                _funciones.EnviarPDF(txtPara.Text, IdFiltro & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf", txtAsunto.Text, txtConcepto.Text, Licencia)
                Me.Close()
            Else
                MessageBox.Show("El Correo electronico no es Valido ", "Enviar Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
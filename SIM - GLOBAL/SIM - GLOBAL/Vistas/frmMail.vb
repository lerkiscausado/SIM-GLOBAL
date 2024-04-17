Imports SIM___GLOBAL.Utilidades

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
    Dim _ds As New DataSet

    Private Function ValidarMail(ByVal EMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(EMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

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
        End Select


        'Try
        ' '    Se genera el reporte en PDF
        ' Select Case Licencia
        ' Case "11"
        ' _funciones.GenerarPDF(IdOrden, TipoEstudio, 1, Licencia, IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        ' Case Else
        ' _funciones.GenerarPDF(IdDetalleOrden, TipoEstudio, 1, Licencia, IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        ' End Select
        '
        '        Catch ex As Exception
        '        MsgBox(ex)
        '        End Try

        'Try
        ' '    Se carga la vista previa del reporte
        ' PDF.LoadDocument(path:="x:\pdf\" & IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        ' Catch ex As Exception
        'MsgBox(ex)
        'End Try

        'If _ds.Tables(0).Rows(0)(1) <> "" Then 'Campo Correo Electronico
        ' _funciones.EnviarReporteMail(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, IDOrdenG & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf", _ds.Tables(0).Rows(0)(1).ToString)
        ' Else
        ' MessageBox.Show("El usuario no tiene correo electronico registrado", "Enviar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
        ' _funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
    End Sub

    Private Sub btnDescartar_Click(sender As Object, e As EventArgs) Handles btnDescartar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'Dim i As Integer
        Try
            '_ds = _DOrdenes.GenerarPDF2021()
            MsgBox(_ds.Tables(0).Rows.Count)
            Dim i As Integer = 0
            Do While i < _ds.Tables(0).Rows.Count
                '                    GuardarHistoria(gvTemporal.GetRowCellValue(i, "ORDEN").ToString())
                _funciones.GenerarPDF(_ds.Tables(0).Rows(i)(0).ToString, _ds.Tables(0).Rows(i)(1).ToString, 1, Licencia, _ds.Tables(0).Rows(i)(0).ToString & ".pdf")
                i = i + 1
                txtPara.Text = Val(i)
            Loop

            'For i = 0 To _ds.Tables(0).Rows.Count - 1
            ' _funciones.GenerarPDF(_ds.Tables(0).Rows(i)(0).ToString, _ds.Tables(0).Rows(i)(1).ToString, 1, Licencia, _ds.Tables(0).Rows(i)(0).ToString & " - " & _ds.Tables(0).Rows(i)(2).ToString & ".pdf")
            ' txtPara.Text = Val(i)
            'Next
        Catch ex As Exception
            MsgBox(ex)
        End Try



        '_funciones.GenerarPDF(IdOrden, TipoEstudio, 1, Licencia, IdOrden & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf")
        'If txtPara.Text = "" Or ValidarMail(txtPara.Text) = False Then
        ' MessageBox.Show("Debe ingresar el correo electronico o no cumple con la estructura", "Enviar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Else

        ' Me.Close()
        ' End If
    End Sub
End Class
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports DevExpress.Data
Imports DevExpress.XtraBars.Ribbon
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmPrueba
    ReadOnly _dDiagnostico = New DDiagnostico
    Dim _historiaD As New HistoriaDiagnosticos
    Dim _DHistoriaD = New DHistoriaDiagnosticos
    Dim _dUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _ds As DataSet
    Dim _funciones As New Funciones
    Dim img As Byte()
    Dim img2 As Image

    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        img = _funciones.Imagen_Bytes(peFoto.EditValue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        img2 = _funciones.Bytes_Imagen(img)
        peFoto2.EditValue = img2
    End Sub
End Class

Imports SIM___GLOBAL.Utilidades
'Imports System.Text.RegularExpressions
Public Class frmGenerarPDF
    ReadOnly _funciones As New Funciones
    Public Licencia As String
    Dim _ds As DataSet
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim NumeroRegistros As Integer
    Private Sub frmGenerarPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaInicial.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaFinal.Text = Format(DateTime.Now, "dd/MM/yyyy")
    End Sub

    Private Sub btGenerarPDF_Click(sender As Object, e As EventArgs) Handles btGenerarPDF.Click
        Dim _EstudiosPDF As New SIM___GLOBAL.Modelo.EstudiosPDF
        Dim _DEstudiosPDF As New SIM___GLOBAL.Controles.DEstudiosPDF
        Try
            _ds = _DOrdenes.GenerarPDF2021(dtFechaInicial.Text, dtFechaFinal.Text)
            MsgBox(_ds.Tables(0).Rows.Count)
            If _ds.Tables(0).Rows.Count > 75 Then
                NumeroRegistros = 75
            Else
                NumeroRegistros = _ds.Tables(0).Rows.Count
            End If
            pbPDFs.Maximum = NumeroRegistros

            If NumeroRegistros <> 0 Then
                Dim i As Integer = 0
                Do While i < NumeroRegistros

                    _funciones.GenerarPDF(_ds.Tables(0).Rows(i)(0).ToString, _ds.Tables(0).Rows(i)(1).ToString, 1, Licencia, _ds.Tables(0).Rows(i)(0).ToString & ".pdf")

                    _DOrdenes.PDFGenerado(_ds.Tables(0).Rows(i)(0).ToString)

                    i = i + 1
                    pbPDFs.Value = Val(i)
                Loop
                MsgBox("Los estudios fueron generados satisfactoriamente")
                pbPDFs.Value = 0
            Else
                MsgBox("No hay reportes para generar.")
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
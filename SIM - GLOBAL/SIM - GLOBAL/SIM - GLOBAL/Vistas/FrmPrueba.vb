
Imports SIM___GLOBAL.Controles
Public Class FrmPrueba
    Dim _ds As DataSet
    Dim Dimagenes As New SIM___GLOBAL.Controles.DImagenes
    Dim conteo As Integer
    Dim _funciones As New SIM___GLOBAL.Utilidades.Funciones


    Private Sub FrmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = New DataSet
        _ds = Dimagenes.ListarImagenesUpdate
        GCConsultar.DataSource = _ds.Tables(0)
        ProgressBar1.Maximum = GVConsultar.RowCount
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            For x = 0 To GVConsultar.RowCount
                lblConteo.Text = x
                If conteo = 200 Then
                    MsgBox("pausa")
                    conteo = 0
                Else
                    conteo = conteo + 1
                End If

                If System.IO.File.Exists(_ds.Tables(0).Rows(x)(3).ToString()) = True Then
                    peImagen.Image = Image.FromFile(_ds.Tables(0).Rows(x)(3).ToString())
                    'MsgBox(_ds.Tables(0).Rows(x)(0).ToString() & " - " & _ds.Tables(0).Rows(x)(3).ToString())
                    Dimagenes.GuardarFoto(_ds.Tables(0).Rows(x)(0).ToString(), _funciones.Imagen_Bytes(peImagen.EditValue))
                    Timer1.Start()
                End If
                ProgressBar1.Value = x

            Next

        Catch ex As Exception

        End Try
        'MsgBox(_ds.Tables(0).Rows(18457)(3).ToString())

    End Sub
End Class
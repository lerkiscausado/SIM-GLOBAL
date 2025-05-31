Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports SIM___GLOBAL.My.Controles

Public Class prueba2imagenes
    Shared _conn As New OdbcConnection
    Shared _ds As DataSet
    'Shared _adapter As DataAdapter
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    Private Sub prueba2imagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' peImagen.Image = Image.FromFile("prueba.jpg")

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.peImagen.Image)
            Dim sql As String = "INSERT INTO imagenes_temporales (ID,ID_DETALLE_ORDEN, IMAGEN)VALUES (?,?,?)"
            _conn = ConexionODBC.Open()
            Dim Comando As New OdbcCommand(sql, _conn)
            'Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.peImagen.Image)

            Comando.Parameters.AddWithValue(1, "")
            Comando.Parameters.AddWithValue(2, "12")
            Comando.Parameters.AddWithValue(3, Imag)

            'Comando.Parameters("@ID_DETALLE_ORDEN").Value = "15"


            Comando.ExecuteNonQuery()
            ConexionODBC.Close(_conn)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        wbHtml.DocumentText = txtCodigo.Text
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim Inicio As Date
        Dim Final As Date
        Dim MHoras As Double
        Dim MMinDec As Double
        Dim MMin As Double
        Dim Resultado As String

        Inicio = CDate("2017/10/26 22:00")
        Final = CDate("2017/10/27 1:15")

        MHoras = Int(Final - Inicio) * 24
        MMinDec = (Int(Final - Inicio) * 24) - MHoras
        MMin = MMinDec * 60.0#

        MsgBox("Horas : " & Format(MHoras).ToString)
        '"Minutos Decimales : " & Format(MMinDec).ToString & vbCrLf &
        '"Minutos : " & Format(MMin).ToString & vbCrLf & vbCrLf &
        '"Resultado " & vbCrLf &
        '"    De:   " & Format(Inicio, "Hh:Nn").ToString & vbCrLf &
        '"     A:   " & Format(Final, "Hh:Nn").ToString & vbCrLf &
        '"Son:      " & Format(MHoras).ToString & ":" & Format(MMin, "00").ToString

    End Sub
End Class
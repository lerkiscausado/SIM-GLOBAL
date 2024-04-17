Imports System.Data
Imports System.IO
Imports System.Data.Common
Imports SIM___GLOBAL.My.Controles
'Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class frmBinarios
    Shared _conn As New OdbcConnection
    'Shared _ds As DataSet
    'Shared _adapter As DataAdapter

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Try
        Dim sql As String = "insert into tbl_imagenes(imagen)values(?imagen)"
            _conn = ConexionODBC.Open()
            Dim comando = New OdbcCommand(sql, _conn)

            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.PictureBox1.Image)

            comando.Parameters.AddWithValue("?imagen", Imag)

            comando.ExecuteNonQuery()

        'Catch ex As Exception
        '     MessageBox.Show(ex.Message)
        'End Try
    End Sub
    'convertir imagen a binario
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
End Class
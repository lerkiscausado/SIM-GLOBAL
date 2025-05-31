'Imports SIM_ENDOSCOPIA.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO

Namespace Controles
    Public Class DImagenesTemporales
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
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
        Public Sub Guardar(ByVal _ImagenesTemporales As SIM_ENDOSCOPIA.Modelo.ImagenesTemporales)
            Try
                'Dim query As String

                Dim sql As String = "insert into imagenes_temporales (ID,ID_DETALLE_ORDEN,IMAGEN) values(?,?,?)"
                _conn = ConexionODBC.Open()

                Dim Comando As New OdbcCommand(sql, _conn)
                Dim Imag As Byte()
                Imag = Imagen_Bytes(_ImagenesTemporales.Imagen)

                Comando.Parameters.AddWithValue(1, _ImagenesTemporales.Id)
                Comando.Parameters.AddWithValue(2, _ImagenesTemporales.IdDetalleOrden)
                Comando.Parameters.AddWithValue(3, Imag)

                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal Filtro As String)
            Try
                Dim query As String =
              String.Format("DELETE  FROM imagenes_temporales WHERE id_detalle_orden='" & Filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Sub
        Public Sub LimpiarTabla()
            Try
                Dim query As String =
              String.Format("DELETE  FROM imagenes_temporales")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Sub

        Public Function Listar(ByVal Filtro As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT imagen as IMAGEN FROM imagenes_temporales where id_detalle_orden='" & Filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class
End Namespace


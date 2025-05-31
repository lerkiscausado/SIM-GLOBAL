Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DDetalleSalon
        Shared _conn As New OdbcConnection
        Shared _adapter As DataAdapter
        Shared _ds As DataSet
        ReadOnly Funciones As Funciones
        Public Sub Guardar(ByVal _DetalleSalon As AGORA.Modelo.DetalleSalon)
            Try
                Dim query As String
                Dim Imag As Byte()
                Imag = _DetalleSalon.Foto
                'Guardar Imagenes
                query = "INSERT INTO detalle_salon VALUES('" & Val(_DetalleSalon.Id) & "', " _
                        & "'" & _DetalleSalon.IdSalon & "', " _
                        & "'" & _DetalleSalon.Descripcion & "',?, " _
                        & "'" & _DetalleSalon.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, Imag)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarImagenes(ByVal IdSalon As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT foto,id,descripcion FROM detalle_salon WHERE id_salon='" & IdSalon & "' and estado='A'")
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
        Public Sub EliminarFoto(ByVal IdDetalleSalon As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_salon WHERE id='" & IdDetalleSalon & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleSalon(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_salon SET id_salon='" & filtro & "' WHERE id_salon='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdSalon As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_salon WHERE id_salon='" & IdSalon & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                Dim reader As OdbcDataReader
                reader = comando.ExecuteReader()
                If reader.Read() Then
                    ConexionODBC.Close(_conn)
                    Return True
                Else
                    ConexionODBC.Close(_conn)
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Sub EliminarFotosSalon(ByVal IdSalon As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_salon WHERE id_salon='" & IdSalon & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace


Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DSesiones
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdUsuario As String) As Sesiones
            Try
                Dim query As String = String.Format("SELECT * FROM sesiones WHERE id_usuario='" & IdUsuario & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Sesiones = New Sesiones
                _Sesiones.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Sesiones.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _Sesiones.Contrasena = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Sesiones
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteUsuario(ByVal IdUsuario As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM sesiones WHERE id_usuario='" & IdUsuario & "'")
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
        Public Sub Guardar(ByVal _Sesiones As Sesiones)
            Try
                Dim query As String
                query = "INSERT INTO sesiones VALUES('0','" & _Sesiones.IdUsuario & "','" & _Sesiones.Contrasena & "')"
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


'Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DBloqueoRegistros
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ExisteIdDetalleOrden(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM bloqueo_registros WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Function ExisteIdOrden(ByVal IdOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM bloqueo_registros WHERE id_orden='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _BloqueoRegistros As BloqueoRegistros)
            Try
                Dim query As String
                query = "INSERT INTO bloqueo_registros VALUES('','" & _BloqueoRegistros.IdOrden & "','" & _BloqueoRegistros.IdDetalleOrden & "', " _
                            & "'" & _BloqueoRegistros.IdUser & "','" & _BloqueoRegistros.IdTabla & "')"
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


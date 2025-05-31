Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Namespace Controles
    Public Class DRegistros
        Shared _conn As New OdbcConnection
        Public Sub Guardar(ByVal _Registros As SIM___GLOBAL.Modelo.Registros)
            Try
                Dim query As String
                query = "INSERT INTO registros VALUES('" & _Registros.Id & "', " _
                            & "'" & Format(_Registros.Fecha, "yyyy/MM/dd") & "', " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & _Registros.IdTabla & "', " _
                            & "'" & _Registros.IdRegistro & "', " _
                            & "'" & _Registros.IdUsuario & "', " _
                            & "'" & _Registros.TipoRegistro & "', " _
                            & "'" & _Registros.Nota & "')"
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


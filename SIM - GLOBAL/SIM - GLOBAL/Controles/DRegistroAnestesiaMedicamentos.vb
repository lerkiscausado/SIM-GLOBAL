Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Namespace Controles
    Public Class DRegistroAnestesiaMedicamentos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal IdRegistroAnestesia As String) As DataSet
            Try
                Dim query As String =
                        String.Format("SELECT ID, " _
                                    & "MEDICAMENTO, " _
                                    & "DOSIS " _
                                    & "FROM	registro_anestesia_medicamentos WHERE id_registro_anestesia='" & IdRegistroAnestesia & "'")
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
        Public Function Existe(ByVal IdRegistroAnestesia As String, ByVal IdMedicamento As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM registro_anestesia_medicamentos WHERE id_registro_anestesia='" & IdRegistroAnestesia & "' and id_medicamento='" & IdMedicamento & "'")
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
        Public Sub Guardar(ByVal _RegistroAnestesiaMedicamentos As SIM___GLOBAL.Modelo.RegistroAnestesiaMedicamentos)
            Try
                Dim query As String
                query = "INSERT INTO registro_anestesia_medicamentos VALUES('" & _RegistroAnestesiaMedicamentos.Id & "', " _
                      & "'" & _RegistroAnestesiaMedicamentos.IdRegistroAnestesia & "', " _
                      & "'" & _RegistroAnestesiaMedicamentos.IdMedicamento & "', " _
                      & "'" & _RegistroAnestesiaMedicamentos.Medicamento & "', " _
                      & "'" & _RegistroAnestesiaMedicamentos.Dosis & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdRegistroAnestesiaMedicamento As String)
            Try
                Dim query As String
                query = "DELETE FROM registro_anestesia_medicamentos WHERE id='" & IdRegistroAnestesiaMedicamento & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarRegistroAnestesiaMedicamentos(ByVal IdRegistroAnestesia As String)
            Try
                Dim query As String
                query = "DELETE FROM registro_anestesia_medicamentos WHERE id_registro_anestesia='" & IdRegistroAnestesia & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarRegistroAnestesiaMedicamentos(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE registro_anestesia_medicamentos SET id_registro_anestesia='" & filtro & "' WHERE id_registro_anestesia='" & filtro2 & "'"

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

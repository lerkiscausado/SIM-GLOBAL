Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DClienteSedes
        Shared _conn As New OdbcConnection
        Shared _adapter As DataAdapter
        Shared _ds As DataSet
        Public Sub Guardar(ByVal _ClientesSedes As PEC___App.Modelo.ClientesSedes)
            Try
                Dim query As String
                query = "INSERT INTO clientes_sedes VALUES('" & Val(_ClientesSedes.Id) & "', " _
                    & "'" & _ClientesSedes.IdContrato & "', " _
                    & "'" & _ClientesSedes.IdCiudad & "', " _
                    & "'" & _ClientesSedes.Estado & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo(ByVal IdContrato As String) As DataSet
            Try
                Dim query As String =
                    String.Format("SELECT clientes_sedes.ID, " _
                                & "ciudades.CIUDAD " _
                                & "FROM clientes_sedes INNER JOIN ciudades ON (ciudades.id=clientes_sedes.id_ciudad) " _
                                & "WHERE clientes_sedes.id_contrato='" & IdContrato & "'")
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
        Public Function ListarClientesSedes(ByVal IdContrato As String) As DataSet
            Try
                Dim query As String =
                    String.Format("SELECT clientes_sedes.ID, " _
                                & "ciudades.CIUDAD " _
                                & "FROM clientes_sedes " _
                                & "INNER JOIN ciudades ON (ciudades.id=clientes_sedes.id_ciudad) " _
                                & "WHERE clientes_sedes.id_contrato='" & IdContrato & "'")
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
        Public Sub Eliminar(ByVal IdClienteSede As String)
            Try
                Dim query As String
                query = "DELETE FROM clientes_sedes WHERE id='" & IdClienteSede & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarSedesCliente(ByVal IdContrato As String)
            Try
                Dim query As String
                query = "DELETE FROM clientes_sedes WHERE id_contrato='" & IdContrato & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarClienteSede(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE clientes_sedes SET id_contrato='" & filtro & "' WHERE id_contrato='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteClienteSedeOrden(ByVal IdClienteSede As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id_cliente_sede='" & IdClienteSede & "'")
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

    End Class
End Namespace


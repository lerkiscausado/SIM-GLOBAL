Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DTemporal
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter

        Public Sub Guardar(ByVal _temporal As SIM___INTEGRA.Modelo.Temporal)
            Try
                Dim query As String
                query = "insert into temporal values('" & _temporal.IdOrden & "','" &
                            _temporal.Nombre & "','" & _temporal.IdEmpleado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal Orden As String, ByVal Empleado As String)
            Try
                Dim query As String
                query = "DELETE FROM temporal WHERE id_orden='" & Orden & "' AND id_empleado ='" & Empleado & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarGrupal(ByVal Empleado As String)
            Try
                Dim query As String
                query = "DELETE FROM temporal WHERE  id_empleado ='" & Empleado & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT temporal.ID_ORDEN AS ORDEN, temporal.NOMBRE, 'SI' AS FIRMA, ordenes.CODIGO_DIAGNOSTICO AS DIAGNOSTICO " _
                                        & "FROM temporal INNER JOIN ordenes ON (temporal.ID_ORDEN = ordenes.ID) WHERE (temporal.ID_EMPLEADO ='" & filtro & "')")
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
        Public Function Existe(ByVal filtro As String, ByVal filtro2 As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_orden FROM temporal WHERE id_orden='" & filtro & "' and id_empleado='" & filtro2 & "'")
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


Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleOrdenAnalista
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _DetalleOrdenAnalista As PEC___App.Modelo.DetalleOrdenAnalista)
            Try
                Dim query As String
                query = "INSERT INTO detalle_orden_analista VALUES('" & Val(_DetalleOrdenAnalista.Id) & "','" & _DetalleOrdenAnalista.IdOrden & "','" & _DetalleOrdenAnalista.IdDetalleOrden & "', " _
                      & "'" & _DetalleOrdenAnalista.IdEmpleado & "',?)"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleOrdenAnalista.Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarEstudioAnalista(ByVal IdDetalleOrden As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT detalle_orden_analista.ID, " _
                                        & "detalle_orden_analista.id_detalle_orden AS DETALLEORDEN, " _
                                        & "empleados.nombre_empleado AS ANALISTA, " _
                                        & "detalle_orden_analista.VALOR " _
                                        & "FROM detalle_orden_analista INNER JOIN empleados ON (detalle_orden_analista.id_empleado=empleados.id) " _
                                        & "WHERE detalle_orden_analista.id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Sub Eliminar(ByVal IdEstudioAnalista As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_analista WHERE id='" & IdEstudioAnalista & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarEstudioAnalista(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_analista WHERE id_orden='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteEstudioAnalista(ByVal IdDetalleOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_orden_analista WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Function ExisteEstudioAnalista2(ByVal IdDetalleOrden As String, ByVal IdAnalista As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_orden_analista WHERE id_detalle_orden='" & IdDetalleOrden & "' and id_empleado='" & IdAnalista & "'")
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
        Public Sub ActualizarEstudioAnalista(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_analista SET id_orden='" & filtro & "' WHERE id_orden='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarValor(ByVal IdDetalleOrdenAnalista As String, ByVal Valor As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_analista SET valor='" & Valor & "' " _
                      & "where id='" & IdDetalleOrdenAnalista & "'"
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


Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Namespace Controles
    Public Class DDetalleRegistroAnestesia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _DetalleRegistroAnestesia As SIM___GLOBAL.Modelo.DetalleRegistroAnestesia)
            Try
                Dim query As String
                query = "INSERT INTO detalle_registro_anestesia VALUES('" & _DetalleRegistroAnestesia.Id & "', " _
                      & "'" & _DetalleRegistroAnestesia.IdRegistroAnestesia & "', " _
                      & "'" & Format(_DetalleRegistroAnestesia.Hora, "HH:mm:ss") & "', " _
                      & "'" & _DetalleRegistroAnestesia.O2 & "', " _
                      & "'" & _DetalleRegistroAnestesia.Anestesia & "', " _
                      & "'" & _DetalleRegistroAnestesia.FC & "', " _
                      & "'" & _DetalleRegistroAnestesia.FR & "', " _
                      & "'" & _DetalleRegistroAnestesia.Diuresis & "', " _
                      & "'" & _DetalleRegistroAnestesia.TA & "', " _
                      & "'" & _DetalleRegistroAnestesia.PVC & "', " _
                      & "'" & _DetalleRegistroAnestesia.V & "', " _
                      & "'" & _DetalleRegistroAnestesia.SATO & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdRegistroAnestesia As String) As DataSet
            Try
                Dim query As String =
                        String.Format("select ID, HORA, O2, ANESTESIA, FC, FR, DIURESIS, TA, PVC, V, SAT_O AS SATO  from detalle_registro_anestesia where id_registro_anestesia='" & IdRegistroAnestesia & "' order by id desc")
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
        Public Sub ActualizarDetalleRegistroAnestesia(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_registro_anestesia SET id_registro_anestesia='" & filtro & "' WHERE id_registro_anestesia='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdDetalleRegistroAnestesia As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_registro_anestesia WHERE id='" & IdDetalleRegistroAnestesia & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleRegistroAnestesia(ByVal IdDetalleRegistroAnestesia As String, ByVal O2 As String, ByVal Anestesia As String, ByVal FC As String, ByVal FR As String, ByVal Diuresis As String, ByVal TA As String, ByVal PVC As String, ByVal V As String, ByVal SATO As String)
            Try
                Dim query As String
                query = "UPDATE detalle_registro_anestesia SET o2='" & O2 & "', " _
                        & "anestesia='" & Anestesia & "', " _
                        & "fc='" & FC & "', " _
                        & "fr='" & FR & "', " _
                        & "diuresis='" & Diuresis & "', " _
                        & "ta='" & TA & "', " _
                        & "pvc='" & PVC & "', " _
                        & "v='" & V & "', " _
                        & "sat_o='" & SATO & "' " _
                        & "where id='" & IdDetalleRegistroAnestesia & "'"
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


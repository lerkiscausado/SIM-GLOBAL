Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DExamenesPrequirurgicos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _ExamenesPrequirurgicos As SIM___GLOBAL.Modelo.ExamenesPrequirurgicos)
            Try
                Dim query As String
                query = "insert into examenes_prequirurgicos values('" & _ExamenesPrequirurgicos.Id & "','" &
                            _ExamenesPrequirurgicos.IdOrden & "','" & _ExamenesPrequirurgicos.IdDetalleOrden & "','" & _ExamenesPrequirurgicos.Examen & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdExamenPrequirurgico As String)
            Try
                Dim query As String
                query = "DELETE FROM examenes_prequirurgicos WHERE id='" & IdExamenPrequirurgico & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarExamen(ByVal IdOrden As String, ByVal Examen As String)
            Try
                Dim query As String
                query = "DELETE FROM examenes_prequirurgicos WHERE id_orden='" & IdOrden & "' and examen='" & Examen & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID`, " _
                                                & "`ID_ORDEN` AS `ORDEN`, " _
                                                & "`ID_DETALLE_ORDEN` AS `DETALLEORDEN`, " _
                                                & "`EXAMEN` FROM `examenes_prequirurgicos` WHERE (`ID_ORDEN` ='" & IdOrden & "')")
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

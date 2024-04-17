Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaRXS
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _historiaRXS As HistoriaRXS)
            Try
                Dim query As String
                query = "insert into historia_rxs values('" & _historiaRXS.IdRXS & "','" &
                            _historiaRXS.IdOrden & "','" & _historiaRXS.IdDetalleOrden & "','" & _historiaRXS.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _idRxs As String, ByVal _idOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_rxs WHERE id_rxs='" & _idRxs & "' AND id_orden='" & _idOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _idRxs As String, ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_rxs FROM historia_rxs WHERE id_rxs='" & _idRxs & "' and id_orden='" & _idOrden & "'")
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
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `historia_rxs`.`ID_RXS` AS ID, `revision_sistemas`.`NOMBRE`, `historia_rxs`.`DESCRIPCION` " _
                                        & "FROM `ordenes` INNER JOIN `historia_rxs` ON (`ordenes`.`ID` = `historia_rxs`.`ID_ORDEN`) " _
                                        & "INNER JOIN `revision_sistemas` ON (`historia_rxs`.`ID_RXS` = `revision_sistemas`.`ID`) WHERE (`ordenes`.`ID` ='" & IdOrden & "')")
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

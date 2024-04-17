Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetallePagoRecibo
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _DetallePagoRecibo As DetallePagoRecibo)
            Try
                Dim query As String
                query = "INSERT INTO detalle_pago_recibo VALUES('','" & _DetallePagoRecibo.IdRecibo & "','" & _DetallePagoRecibo.IdMedioPago & "',?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetallePagoRecibo.Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdDetallePagoRecibo As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_pago_recibo WHERE id='" & IdDetallePagoRecibo & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdRecibo As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_pago_recibo`.`ID`, `medios_pago`.`CONCEPTO`, " _
                                          & "`detalle_pago_recibo`.`VALOR` FROM `detalle_pago_recibo` " _
                                          & "INNER JOIN `medios_pago` ON (`detalle_pago_recibo`.`ID_MEDIO_PAGO` = `medios_pago`.`ID`) " _
                                          & "WHERE (`detalle_pago_recibo`.`id_recibo` ='" & IdRecibo & "')")
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
        Public Sub EliminarDetalleRecibo(ByVal IdRecibo As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_pago_recibo WHERE id_recibo='" & IdRecibo & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetallePago(ByVal IdRecibo As String)
            Try
                Dim query As String

                query = "UPDATE detalle_pago_recibo SET id_recibo=(SELECT id FROM recibo_caja ORDER BY id DESC LIMIT 1) WHERE id_recibo='" & IdRecibo & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdRecibo As String, ByVal IdMedioPago As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_pago_recibo WHERE id_recibo='" & IdRecibo & "' and id_medio_pago='" & IdMedioPago & "'")
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


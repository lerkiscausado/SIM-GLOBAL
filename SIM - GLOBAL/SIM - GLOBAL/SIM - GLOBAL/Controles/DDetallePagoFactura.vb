Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetallePagoFactura
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub GuardarDetallePagoFactura(ByVal _DetallePagoFactura As DetallePagoFactura)
            Try
                Dim query As String
                query = "INSERT INTO detalle_pago_factura VALUES('','" & _DetallePagoFactura.IdFactura & "','" & _DetallePagoFactura.IdMedioPago & "',?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetallePagoFactura.Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdDetallePagoFactura As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_pago_factura WHERE id='" & IdDetallePagoFactura & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdFactura As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_pago_factura`.`ID`, `medios_pago`.`CONCEPTO`, " _
                                          & "`detalle_pago_factura`.`VALOR` FROM `detalle_pago_factura` " _
                                          & "INNER JOIN `medios_pago` ON (`detalle_pago_factura`.`ID_MEDIO_PAGO` = `medios_pago`.`ID`) " _
                                          & "WHERE (`detalle_pago_factura`.`ID_FACTURA` ='" & IdFactura & "')")
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


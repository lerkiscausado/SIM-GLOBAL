Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleCuentaCliente
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _DetalleCuentaCliente As DetalleCuentaCliente)
            Try
                Dim query As String
                query = "INSERT INTO detalle_cuenta_cliente VALUES('" & _DetalleCuentaCliente.Id & "', " _
                        & "'" & _DetalleCuentaCliente.IdCuentaCliente & "','" & _DetalleCuentaCliente.IdRecibo & "',?,?,'" & _DetalleCuentaCliente.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleCuentaCliente.Valor))
                comando.Parameters.AddWithValue(2, CDec(_DetalleCuentaCliente.Saldo))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function IdCuentaCliente(ByVal IdRecibo As String) As String
            Try
                Dim query As String = String.Format("SELECT id_cuenta_cliente FROM detalle_cuenta_cliente WHERE id_recibo='" & IdRecibo & "' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub AnularDetalleCuentaCliente(ByVal Idrecibo As String)
            Try
                Dim query As String
                query = "UPDATE detalle_cuenta_cliente SET estado='I' where id_recibo='" & Idrecibo & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub AnularDetalleCuentaCliente2(ByVal IdCuentaCliente As String)
            Try
                Dim query As String
                query = "UPDATE detalle_cuenta_cliente SET estado='I' where id_cuenta_cliente='" & IdCuentaCliente & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function TotalRecibosCuentaCliente(ByVal IdCuentaCliente As String) As Double
            Try
                Dim query As String = String.Format("SELECT SUM(`VALOR`) AS `TOTAL` FROM `detalle_cuenta_cliente` WHERE (`ID_CUENTA_CLIENTE` ='" & IdCuentaCliente & "')")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


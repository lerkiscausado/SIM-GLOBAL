Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DCuentasClientes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal Id As String) As CuentasClientes
            Try
                Dim query As String = String.Format("SELECT * FROM cuentas_clientes WHERE id='" & Id & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _CuentasClientes = New CuentasClientes
                _CuentasClientes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _CuentasClientes.IdLicencia = _ds.Tables(0).Rows(0)(1).ToString()
                _CuentasClientes.IdCliente = _ds.Tables(0).Rows(0)(2).ToString()
                _CuentasClientes.TipoDocumento = _ds.Tables(0).Rows(0)(3).ToString()
                _CuentasClientes.NumeroDocumento = _ds.Tables(0).Rows(0)(4).ToString()
                _CuentasClientes.Fecha = _ds.Tables(0).Rows(0)(5).ToString()
                _CuentasClientes.Concepto = _ds.Tables(0).Rows(0)(6).ToString()
                _CuentasClientes.Valor = _ds.Tables(0).Rows(0)(7).ToString()
                _CuentasClientes.Saldo = _ds.Tables(0).Rows(0)(8).ToString()
                Return _CuentasClientes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _CuentasClientes As CuentasClientes)
            Try
                Dim query As String
                query = "INSERT INTO cuentas_clientes VALUES('" & _CuentasClientes.Id & "', " _
                        & "'" & _CuentasClientes.IdLicencia & "','" & _CuentasClientes.IdCliente & "','" & _CuentasClientes.TipoDocumento & "', " _
                        & "'" & _CuentasClientes.NumeroDocumento & "','" & Format(_CuentasClientes.Fecha, "yyyy/MM/dd") & "', " _
                        & "'" & _CuentasClientes.Concepto & "',?,?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_CuentasClientes.Valor))
                comando.Parameters.AddWithValue(2, CDec(_CuentasClientes.Saldo))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function UltimoID() As String
            Try
                Dim query As String = String.Format("SELECT id FROM cuentas_clientes ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub AjustarSaldo(ByVal IdCuentaCliente As String, ByVal Valor As Double)
            Try
                Dim query As String
                query = "UPDATE cuentas_clientes SET saldo=? where id='" & IdCuentaCliente & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function SaldoActualCliente(ByVal IdCliente As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `tipo_documento`, `numero_documento`, `valor`,saldo,id FROM `cuentas_clientes` WHERE (`id_cliente` ='" & IdCliente & "' and saldo > '0') ORDER BY `ID` DESC LIMIT 1")
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
        Public Function SaldosCliente(ByVal IdCliente As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT cuentas_clientes.`ID`,cuentas_clientes.`FECHA`" _
                                                  & ",CASE WHEN cuentas_clientes.`TIPO_DOCUMENTO`='OS' THEN 'ORDEN SERVICIO' " _
                                                  & "WHEN cuentas_clientes.`TIPO_DOCUMENTO`='FA' THEN 'FACTURA'	" _
                                                  & "WHEN cuentas_clientes.`TIPO_DOCUMENTO`='OM' THEN 'ORDEN MEDICA' " _
                                                  & "END AS DOCUMENTO ,cuentas_clientes.`NUMERO_DOCUMENTO` AS CONSECUTIVO " _
                                                  & ",cuentas_clientes.`SALDO` FROM cuentas_clientes " _
                                                  & "WHERE cuentas_clientes.`ID_CLIENTE`='" & IdCliente & "' AND cuentas_clientes.`SALDO`<>0")
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
        Public Sub AnularOrdenServicio(ByVal IdOrdenServicio As String)
            Try
                Dim query As String
                query = "UPDATE cuentas_clientes SET concepto='Orden de Servicio Anulada', saldo=0 where numero_documento='" & IdOrdenServicio & "' and tipo_documento='OS'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarSaldoCliente(ByVal IdOrden As String, ByVal Valor As Double, ByVal TipoDocumento As String)
            Try
                Dim query As String
                query = "UPDATE cuentas_clientes SET saldo=? where numero_documento='" & IdOrden & "' and tipo_documento='" & TipoDocumento & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function SaldoCuentaCliente(ByVal IdOrden As String, ByVal TipoDocumento As String) As Double
            Try
                Dim query As String = String.Format("SELECT saldo FROM cuentas_clientes WHERE numero_documento='" & IdOrden & "' and tipo_documento='" & TipoDocumento & "'")
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
        Public Function IdCuentaCliente(ByVal IdOrdenServicio As String, ByVal TipoDocumento As String) As String
            Try
                Dim query As String = String.Format("SELECT id FROM cuentas_clientes WHERE numero_documento='" & IdOrdenServicio & "' and tipo_documento='" & TipoDocumento & "'")
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
        Public Sub ActualizarConceptoCliente(ByVal IdCuentaCliente As String)
            Try
                Dim query As String
                query = "UPDATE cuentas_clientes SET concepto='Recibo de Caja Anulado' where id='" & IdCuentaCliente & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Function ExisteCuentaCliente(ByVal IdOrden As String, ByVal TipoDocumento As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM cuentas_clientes WHERE numero_documento='" & IdOrden & "' and tipo_documento='" & TipoDocumento & "'")
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
        Public Sub ActualizarCuentaCliente(ByVal IdCuentaCliente As String, ByVal Valor As Double, ByVal Saldo As Double)
            Try
                Dim query As String
                query = "UPDATE cuentas_clientes SET valor=?, saldo=? where id='" & IdCuentaCliente & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(Valor))
                comando.Parameters.AddWithValue(2, CDec(Saldo))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function OrdenesServicios(ByVal Ano As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT cuentas_clientes.numero_documento AS ORDEN, " _
                                                & "cuentas_clientes.FECHA, " _
                                                & "CONCAT(clientes.id_tipo_identificacion,' ',clientes.identificacion) AS IDENTIFICACION, " _
                                                & "clientes.nombre AS CLIENTE, " _
                                                & "cuentas_clientes.VALOR, " _
                                                & "cuentas_clientes.SALDO " _
                                                & "FROM cuentas_clientes INNER JOIN clientes ON (cuentas_clientes.id_cliente=clientes.id) " _
                                                & "WHERE YEAR(cuentas_clientes.fecha)='" & Ano & "' ORDER BY cuentas_clientes.fecha, cuentas_clientes.numero_documento DESC")
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


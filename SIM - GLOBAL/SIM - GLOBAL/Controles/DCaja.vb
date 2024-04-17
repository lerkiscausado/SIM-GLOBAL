Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DCaja
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _Caja As Caja)
            Try
                Dim query As String
                query = "INSERT INTO recibo_caja VALUES('','" & _Caja.IdOrden & "','" & Format(_Caja.Fecha, "yyyy/MM/dd") & "', '" & _Caja.Ciudad & "'," _
                            & "'" & _Caja.Nombre & "','" & _Caja.Identificacion & "', " _
                            & "'" & _Caja.Direccion & "','" & _Caja.Telefono & "', " _
                            & "?,'" & _Caja.Concepto & "','" & _Caja.Estado & "','" & _Caja.IdEmpleado & "','" & _Caja.IdCierre & "','" & _Caja.Referencia & "','" & _Caja.IdCliente & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_Caja.Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarRecibosOrden(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `recibo_caja`.`ID` AS RECIBO, " _
                                                  & "`recibo_caja`.`ID_ORDEN` AS `ORDEN`, " _
                                                  & "`recibo_caja`.`FECHA`, " _
                                                  & "`recibo_caja`.`IDENTIFICACION`, " _
                                                  & "`recibo_caja`.`NOMBRE` AS `RECIBIDO`, " _
                                                  & "`recibo_caja`.`CONCEPTO`, " _
                                                  & "`recibo_caja`.`VALOR`, " _
                                                  & "`empleados`.`NOMBRE_EMPLEADO` AS `ELABORADO`, " _
                                                  & "IF(`recibo_caja`.`ESTADO`='R','REGISTRADO',IF(recibo_caja.estado='A','ANULADO','CERRADO')) AS ESTADO, " _
                                                  & "recibo_caja.REFERENCIA AS CONSECUTIVO " _
                                                  & "FROM `recibo_caja` INNER JOIN `empleados` ON (`recibo_caja`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                                  & "WHERE (`recibo_caja`.`ID_ORDEN` ='" & IdOrden & "')")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `recibo_caja`.`ID` AS `RECIBO`, " _
                                                & "`recibo_caja`.`ID_ORDEN` AS `ORDEN`, " _
                                                & "`recibo_caja`.`FECHA`, " _
                                                & "`clientes`.`IDENTIFICACION`, " _
                                                & "`clientes`.`NOMBRE` AS `RECIBIDO`, " _
                                                & "`recibo_caja`.`CONCEPTO`, " _
                                                & "`recibo_caja`.`VALOR` AS VALOR, " _
                                                & "`empleados`.`NOMBRE_EMPLEADO` AS `ELABORADO`, " _
                                                & "IF(`recibo_caja`.`ESTADO`='R','REGISTRADO',IF(recibo_caja.estado='A','ANULADO','CERRADO')) AS ESTADO, " _
                                                & "`recibo_caja`.`REFERENCIA` AS `CONSECUTIVO` " _
                                                & "FROM `recibo_caja` INNER JOIN `clientes` ON (`recibo_caja`.`ID_CLIENTE` = `clientes`.`ID`) " _
                                                & "INNER JOIN `empleados` ON (`recibo_caja`.`ID_EMPLEADO` = `empleados`.`ID`);")
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
        Public Function ListarRecibosPendientes() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `recibo_caja`.`ID` AS `RECIBO`, " _
                                                & "`recibo_caja`.`ID_ORDEN` AS `ORDEN`, " _
                                                & "`recibo_caja`.`FECHA`, " _
                                                & "`recibo_caja`.`IDENTIFICACION`, " _
                                                & "`recibo_caja`.`NOMBRE` AS `RECIBIDO`, " _
                                                & "`recibo_caja`.`CONCEPTO`, " _
                                                & "`recibo_caja`.`VALOR`, " _
                                                & "`empleados`.`NOMBRE_EMPLEADO` AS `ELABORADO`, " _
                                                & "IF(`recibo_caja`.`ESTADO`='R','REGISTRADO',IF(recibo_caja.estado='A','ANULADO','CERRADO')) AS ESTADO, " _
                                                & "recibo_caja.REFERENCIA AS CONSECUTIVO " _
                                                & "FROM `recibo_caja` INNER JOIN `empleados` On (`recibo_caja`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                                & "INNER JOIN `detalle_pago_recibo` ON (`recibo_caja`.`ID` = `detalle_pago_recibo`.`ID_RECIBO`) " _
                                                & "WHERE (`recibo_caja`.`ESTADO` ='R')")
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
        Public Function ReciboRegistrado(ByVal IdRecibo As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM recibo_caja WHERE id='" & IdRecibo & "' and estado='R'")
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
        Public Sub AnularRecibo(ByVal IdRecibo As String)
            Try
                Dim query As String
                query = "update recibo_caja set estado='A' where id='" & IdRecibo & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarRecibos()
            Try
                Dim query As String

                query = "UPDATE recibo_caja SET id_cierre=(SELECT id FROM cierre_caja ORDER BY id DESC LIMIT 1), estado='C' WHERE estado='R'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarSaldoOrden(ByVal IdOrden As String, ByVal Saldo As Double)
            Try
                Dim query As String

                query = "UPDATE ordenes SET saldo='" & Saldo & "' WHERE id='" & IdOrden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function SaldoOrden(ByVal IdOrden As String) As Double
            Try
                Dim query As String = String.Format("SELECT saldo FROM ordenes WHERE id='" & IdOrden & "'")
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
        Public Shared Function UltimoReciboCaja() As String
            Try
                Dim query As String = String.Format("SELECT id FROM recibo_caja ORDER BY id DESC LIMIT 1")
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
        Public Function ListarCierre() As DataSet
            Try
                Dim query As String =
                             String.Format("SELECT `cierre_caja`.`ID`, " _
                                         & "`cierre_caja`.`FECHA`, " _
                                         & "`cierre_caja`.`SALDO`, " _
                                         & "`cierre_caja`.`OBSERVACIONES`, " _
                                         & "`empleados`.`NOMBRE_EMPLEADO` AS ELABORADO FROM `cierre_caja` " _
                                         & "INNER JOIN `empleados` ON (`cierre_caja`.`ID_EMPLEADO` = `empleados`.`ID`)")
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
        Public Sub AnularReciboOrdenServicio(ByVal IdOrdenServicio As String)
            Try
                Dim query As String
                query = "update recibo_caja set estado='A' where referencia='" & IdOrdenServicio & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ReciboCerradoOrdenes(ByVal IdOrdenServicio As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM recibo_caja WHERE referencia='" & IdOrdenServicio & "' and estado='C'")
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
        Public Function ExisteReciboOrdenServicio(ByVal IdOrdenServicio As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM recibo_caja WHERE referencia='" & IdOrdenServicio & "' and estado='R'")
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
        Public Function TotalRecibosOrden(ByVal IdOrden As String) As Double
            Try
                Dim query As String = String.Format("SELECT SUM(`VALOR`) AS TOTAL FROM `recibo_caja` " _
                                                    & "WHERE (`REFERENCIA` ='" & IdOrden & "' And `ESTADO` <>'A')")
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

Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DCaja
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
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
        Public Sub Guardar(ByVal _Caja As AGORA.Modelo.Caja)
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
    End Class
End Namespace


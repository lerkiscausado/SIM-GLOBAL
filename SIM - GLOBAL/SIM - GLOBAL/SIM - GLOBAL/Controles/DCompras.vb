Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DCompras
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter

        Public Shared Function Cargar(ByVal Id As String) As Compras
            Try
                Dim query As String = String.Format("SELECT * FROM compras WHERE id='" & Id & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Compras = New Compras
                _Compras.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Compras.Fecha = _ds.Tables(0).Rows(0)(1).ToString()
                _Compras.Hora = _ds.Tables(0).Rows(0)(2).ToString()
                _Compras.IdOrdenCompra = _ds.Tables(0).Rows(0)(3).ToString()
                _Compras.Concepto = _ds.Tables(0).Rows(0)(4).ToString()
                _Compras.Factura = _ds.Tables(0).Rows(0)(5).ToString()
                _Compras.Estado = _ds.Tables(0).Rows(0)(6).ToString()
                _Compras.FechaConfirmacion = _ds.Tables(0).Rows(0)(7).ToString()
                _Compras.IdEmpleado = _ds.Tables(0).Rows(0)(8).ToString()
                Return _Compras
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Compras As Compras)
            Try
                Dim query As String
                If Existe(_Compras.Id) = True Then
                    query = "UPDATE compras SET concepto='" & _Compras.Concepto & "' factura='" & _Compras.Factura & "' where id='" & _Compras.Id & "'"
                Else
                    query = "insert into compras values('" & _Compras.Id & "','" & Format(_Compras.Fecha, "yyyy/MM/dd") & "', " _
                                                        & "TIME_FORMAT(Now(), '%H:%i:%s'),'" & _Compras.IdOrdenCompra & "', " _
                                                        & "'" & _Compras.Concepto & "','" & _Compras.Factura & "','" & _Compras.Estado & "', " _
                                                        & "'" & Format(_Compras.FechaConfirmacion, "yyyy/MM/dd") & "','" & _Compras.IdEmpleado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal Id As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM compras WHERE id='" & Id & "'")
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
        Public Function UltimoConsecutivo() As String
            Try
                Dim query As String =
                        String.Format("select id from compras ORDER by ID desc LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `compras`.`ID`," _
                                        & "CONCAT('CO',CONVERT(compras.ID,CHAR(50)),DATE_FORMAT(compras.`FECHA`,'%d%m%Y')) AS CODIGO, " _
                                        & "`compras`.`FECHA`, " _
                                        & "CONCAT('OC',CONVERT(orden_compra.ID,CHAR(50)),DATE_FORMAT(orden_compra.`FECHA`,'%d%m%Y')) AS ORDEN, " _
                                        & "`proveedores`.`NOMBRE` AS PROVEEDOR, " _
                                        & "`compras`.`FACTURA`, " _
                                        & "`compras`.`CONCEPTO`, " _
                                        & "(SELECT SUM(detalle_compra.cantidad * detalle_compra.`VALOR_UNITARIO`) FROM detalle_compra WHERE detalle_compra.`ID_COMPRA`= compras.`ID`) AS TOTAL, " _
                                        & "`empleados`.`NOMBRE_EMPLEADO` AS EMPLEADO, " _
                                        & "`compras`.`ESTADO` " _
                                        & "FROM `compras` INNER JOIN `orden_compra` ON (`compras`.`ID_ORDEN_COMPRA` = `orden_compra`.`ID`) " _
                                        & "INNER JOIN `empleados` ON (`compras`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                        & "INNER JOIN `proveedores` ON (`orden_compra`.`ID_PROVEEDOR` = `proveedores`.`ID`)")
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
        Public Function CargarProveedor(ByRef IdOrdenCompra As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT CONCAT(`proveedores`.`ID_TIPO_IDENTIFICACION`,proveedores.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                                  & "`proveedores`.`NOMBRE`, " _
                                                  & "`proveedores`.`TELEFONO`, " _
                                                  & "`proveedores`.`DIRECCION`,proveedores.`CORREO_ELECTRONICO`  " _
                                                  & "FROM `orden_compra` " _
                                                  & "INNER JOIN `proveedores` ON (`orden_compra`.`ID_PROVEEDOR` = `proveedores`.`ID`) " _
                                                  & "WHERE (`orden_compra`.`ID` ='" & IdOrdenCompra & "')")
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

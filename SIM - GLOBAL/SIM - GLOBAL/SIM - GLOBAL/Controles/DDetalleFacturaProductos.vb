Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleFacturaProductos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal IdFactura As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_factura_productos`.`ID`, " _
                                                  & "`presentacion_productos`.`CODIGO_BARRA` as CODIGO, " _
                                                  & "concat(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) as PRESENTACION, " _
                                                  & "`unidad_medida`.`NOMBRE` AS UNIDAD, " _
                                                  & "`detalle_factura_productos`.`CANTIDAD`, " _
                                                  & "`detalle_factura_productos`.`VALOR_UNITARIO`, " _
                                                  & "(`detalle_factura_productos`.`VALOR_UNITARIO` * `detalle_factura_productos`.`CANTIDAD`)-`detalle_factura_productos`.`DESCUENTO` as SUBTOTAL, " _
                                                  & "`detalle_factura_productos`.`IVA`, " _
                                                  & "`detalle_factura_productos`.`DESCUENTO`, " _
                                                  & "`presentacion_productos`.`ID_PRODUCTO` AS IDPRODUCTO, " _
                                                  & "`presentacion_productos`.`ID` AS IDPRESENTACIONPRODUCTO, " _
                                                  & "`presentacion_productos`.`ID_marca` AS IDMARCA, " _
                                                  & "`detalle_factura_productos`.`COSTO_VENTA` AS COSTOVENTA, " _
                                                  & "`presentacion_productos`.`INVENTARIO` " _
                                                  & "FROM `detalle_factura_productos` " _
                                                  & "INNER JOIN `presentacion_productos` ON (`detalle_factura_productos`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "inner join productos on (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "inner join marcas on (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "WHERE (`detalle_factura_productos`.`ID_FACTURA` ='" & IdFactura & "')")
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
        Public Sub Guardar(ByVal _DetalleFacturaProductos As DetalleFacturaProductos)
            Try
                Dim query As String
                query = "insert into detalle_factura_productos values('" & _DetalleFacturaProductos.Id & "', " _
                        & "'" & _DetalleFacturaProductos.IdFactura & "','" & _DetalleFacturaProductos.IdProducto & "', " _
                        & "?,?, " _
                        & "?,?, " _
                        & "?,'" & _DetalleFacturaProductos.Estado & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleFacturaProductos.Cantidad))
                comando.Parameters.AddWithValue(2, CDec(_DetalleFacturaProductos.ValorUnitario))
                comando.Parameters.AddWithValue(3, CDec(_DetalleFacturaProductos.Iva))
                comando.Parameters.AddWithValue(4, CDec(_DetalleFacturaProductos.Descuento))
                comando.Parameters.AddWithValue(5, CDec(_DetalleFacturaProductos.CostoVenta))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleFacturaProductos(ByVal IDTemporal As String, ByVal IDFactura As String)
            Try
                Dim query As String
                query = "UPDATE detalle_factura_productos SET id_factura='" & IDFactura & "' WHERE id_factura='" & IDTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleFacturaProductos(ByVal IdTemporal As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_factura_productos WHERE id_factura='" & IdTemporal & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleFacturaProductos(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_factura_productos WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteProducto(ByVal IdFactura As String, ByVal IdProducto As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT id FROM detalle_factura_productos WHERE id_factura='" & IdFactura & "' and id_producto='" & IdProducto & "'")
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


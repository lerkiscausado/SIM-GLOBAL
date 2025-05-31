Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleOrdenCompra
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdDetalleOrdenCompra As String) As DetalleOrdenCompra
            Try
                Dim query As String = String.Format("SELECT * FROM detalle_orden_compra WHERE id='" & IdDetalleOrdenCompra & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _DetalleOrdenCompra = New DetalleOrdenCompra
                _DetalleOrdenCompra.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _DetalleOrdenCompra.IdOrdenCompra = _ds.Tables(0).Rows(0)(1).ToString()
                _DetalleOrdenCompra.IdProducto = _ds.Tables(0).Rows(0)(2).ToString()
                _DetalleOrdenCompra.Cantidad = _ds.Tables(0).Rows(0)(3).ToString()
                _DetalleOrdenCompra.ValorUnitario = _ds.Tables(0).Rows(0)(4).ToString()
                _DetalleOrdenCompra.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _DetalleOrdenCompra
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteProducto(ByVal IdOrdenCompra As String, ByVal IdProducto As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ID_ORDEN_COMPRA`, `ID_PRODUCTO` FROM " _
                                      & "`detalle_orden_compra` WHERE (`ID_ORDEN_COMPRA` ='" & IdOrdenCompra & "' AND `ID_PRODUCTO` ='" & IdProducto & "')")
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
        Public Sub Guardar(ByVal _DetalleOrdenCompra As DetalleOrdenCompra)
            Try
                Dim query As String
                query = "insert into detalle_orden_compra values('" & _DetalleOrdenCompra.Id & "','" &
                        _DetalleOrdenCompra.IdOrdenCompra & "','" & _DetalleOrdenCompra.IdProducto & "',?
                        ,?, '" &
                        _DetalleOrdenCompra.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleOrdenCompra.Cantidad))
                comando.Parameters.AddWithValue(2, CDec(_DetalleOrdenCompra.ValorUnitario))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdOrdenCompra As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden_compra`.`ID`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO, " _
                                                  & "concat(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) as PRESENTACION, " _
                                                  & "`unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_orden_compra`.`CANTIDAD` , `detalle_orden_compra`.`VALOR_UNITARIO` " _
                                                  & ",(`detalle_orden_compra`.`CANTIDAD` * `detalle_orden_compra`.`VALOR_UNITARIO`) as SUBTOTAL " _
                                                  & "FROM `detalle_orden_compra` " _
                                                  & "INNER JOIN `presentacion_productos` ON (`detalle_orden_compra`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "inner join productos on (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "inner join marcas on (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "where detalle_orden_compra.id_orden_compra='" & IdOrdenCompra & "'")
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
        Public Sub EliminarProducto(ByVal IdDetalleOrdenCompra As String)
            Try
                Dim query As String
                query = "DELETE from detalle_orden_compra where id='" & IdDetalleOrdenCompra & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo(ByVal IdOrdenCompra As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden_compra`.`ID`, `productos`.`CODIGO_BARRA` AS CODIGO, " _
                                                  & "`productos`.`PRESENTACION`, `unidad_medida`.`NOMBRE` AS UNIDAD, " _
                                                  & "`detalle_orden_compra`.`CANTIDAD` FROM `detalle_orden_compra` " _
                                                  & "INNER JOIN `productos` ON (`detalle_orden_compra`.`ID_PRODUCTO` = `productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`productos`.`ID_UNIDAD_MEDIDAD` = `unidad_medida`.`ID`) " _
                                                  & "where detalle_orden_compra.id_orden_compra='" & IdOrdenCompra & "'")
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
        Public Function ListarComboProductosOC(ByVal IdOrdenCompra As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT presentacion_productos.`ID`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO, " _
                                                  & "concat(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) as PRESENTACION, " _
                                                  & "`unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_orden_compra`.`CANTIDAD`, " _
                                                  & "detalle_orden_compra.valor_unitario as VALOR FROM `detalle_orden_compra` " _
                                                  & "INNER JOIN `presentacion_productos` ON (`detalle_orden_compra`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "inner join productos on (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "inner join marcas on (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "where detalle_orden_compra.id_orden_compra='" & IdOrdenCompra & "' and detalle_orden_compra.estado='REQUERIDO'")
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
        Public Sub ActualizarDetalleOrdenCompra(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_compra SET id_orden_compra='" & filtro & "' WHERE id_orden_compra='" & filtro2 & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleOrdenCompra(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_compra WHERE id_orden_compra='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub CambiarEstado(ByVal IdOrdenCompra As String, ByVal IdProducto As String, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_compra SET estado='" & Estado & "' where id_orden_compra='" & IdOrdenCompra & "' and id_producto='" & IdProducto & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub CambiarEstadoOrdenCompra(ByVal IdOrdenCompra As String, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_compra SET estado='" & Estado & "' where id_orden_compra='" & IdOrdenCompra & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub OrdenCompraConfirmada(ByVal IdOrdenCompra As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_compra SET estado='CONFIRMADO' where id_orden_compra='" & IdOrdenCompra & "' AND estado='ASIGNADO'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class

End Namespace

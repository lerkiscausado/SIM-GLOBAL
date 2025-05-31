Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleCompra
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdDetalleCompra As String) As DetalleCompra
            Try
                Dim query As String = String.Format("SELECT * FROM detalle_compra WHERE id='" & IdDetalleCompra & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _DetalleCompra = New DetalleCompra
                _DetalleCompra.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _DetalleCompra.IdCompra = _ds.Tables(0).Rows(0)(1).ToString()
                _DetalleCompra.IdProducto = _ds.Tables(0).Rows(0)(2).ToString()
                _DetalleCompra.Cantidad = _ds.Tables(0).Rows(0)(3).ToString()
                _DetalleCompra.ValorUnitario = _ds.Tables(0).Rows(0)(4).ToString()
                _DetalleCompra.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _DetalleCompra
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _DetalleCompra As DetalleCompra)
            Try
                Dim query As String
                query = "insert into detalle_compra values('" & _DetalleCompra.Id & "','" &
                        _DetalleCompra.IdCompra & "','" & _DetalleCompra.IdProducto & "',?,?, '" &
                        _DetalleCompra.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleCompra.Cantidad))
                comando.Parameters.AddWithValue(2, CDec(_DetalleCompra.ValorUnitario))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdCompra As String) As DataSet
            Try
                Dim query As String =
        String.Format("SELECT `detalle_compra`.`ID`, `detalle_compra`.`ID_COMPRA`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO, " _
                      & "concat(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRODUCTO, detalle_compra.`CANTIDAD`, " _
                      & "detalle_compra.`VALOR_UNITARIO`, (`detalle_compra`.`cantidad` * detalle_compra.`VALOR_UNITARIO`) as SUBTOTAL, presentacion_productos.id as IDPRESENTACIONPRODUCTO, " _
                      & "presentacion_productos.id_producto as IDPRODUCTO, presentacion_productos.id_marca as IDMARCA FROM " _
                      & "`detalle_compra` INNER JOIN presentacion_productos ON (`detalle_compra`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                      & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                      & "inner join productos on (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                      & "inner join marcas on (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                      & "where detalle_compra.id_compra='" & IdCompra & "'")
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
        Public Sub EliminarProductoDetalleCompra(ByVal IdDetalleCompra As String)
            Try
                Dim query As String
                query = "DELETE from detalle_compra where id='" & IdDetalleCompra & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleCompra(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_compra SET id_compra='" & filtro & "' WHERE id_compra='" & filtro2 & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleCompra(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_compra WHERE id_compra='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarDetalleOrdenCompra(ByVal IdCompra As String, ByVal IdOrdenCompra As String)
            Try
                Dim query As String
                query = "INSERT INTO detalle_compra (id_compra, id_producto, cantidad, valor_unitario, estado) " _
                        & "SELECT '" & IdCompra & "' AS id, id_producto, cantidad, valor_unitario, 'A' FROM detalle_orden_compra WHERE id_orden_compra='" & IdOrdenCompra & "'"
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


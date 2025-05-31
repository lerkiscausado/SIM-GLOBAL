Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleTarifaProductos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As DetalleTarifaproductos
            Try
                Dim query As String = String.Format("SELECT * FROM detalle_tarifa_productos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _DetalleTarifaProductos = New DetalleTarifaProductos
                _DetalleTarifaProductos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _DetalleTarifaProductos.IdTarifaProducto = _ds.Tables(0).Rows(0)(1).ToString()
                _DetalleTarifaProductos.IdProducto = _ds.Tables(0).Rows(0)(2).ToString()
                _DetalleTarifaProductos.Valor = _ds.Tables(0).Rows(0)(3).ToString()
                _DetalleTarifaProductos.Iva = _ds.Tables(0).Rows(0)(4).ToString()
                _DetalleTarifaProductos.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _DetalleTarifaProductos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_tarifa_productos WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _DetalleTarifaProductos As DetalleTarifaProductos)
            Try
                Dim query As String
                If Existe(_DetalleTarifaProductos.Id) = True Then
                    'query = "UPDATE detalle_tarifa_productos SET codigo_cups='" & _DetalleTarifa.CodigoCups & "', " _
                    '       & "valor='" & _DetalleTarifa.Valor & "', tipo_atencion='" & _DetalleTarifa.TipoAtencion & "', " _
                    '      & "estado='" & _DetalleTarifa.Estado & "' where id='" & _DetalleTarifa.Id & "'"
                Else
                    query = "insert into detalle_tarifa_productos values('" & _DetalleTarifaProductos.Id & "','" &
                            _DetalleTarifaProductos.IdTarifaProducto & "','" & _DetalleTarifaProductos.IdProducto & "','" &
                            _DetalleTarifaProductos.Valor & "','" & _DetalleTarifaProductos.Iva & "', '" &
                            _DetalleTarifaProductos.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleTarifa(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_tarifa_productos SET id_tarifa_producto='" & filtro & "' WHERE id_tarifa_producto='" & filtro2 & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleTarifa(ByVal IdTarifaProducto As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa_productos WHERE id_tarifa_producto='" & IdTarifaProducto & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleTarifa(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa_productos WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdTarifaProducto As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_tarifa_productos`.`ID`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION" _
                                                  & ", `unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_tarifa_productos`.`VALOR`, `detalle_tarifa_productos`.`IVA` " _
                                                  & "FROM `detalle_tarifa_productos` INNER JOIN `presentacion_productos` ON (`detalle_tarifa_productos`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`)" _
                                                  & " WHERE (`detalle_tarifa_productos`.`ESTADO` ='A' AND `detalle_tarifa_productos`.`ID_TARIFA_PRODUCTO` ='" & IdTarifaProducto & "')")
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
        Public Function ListarCombo(ByVal IdTarifaProducto As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_tarifa_productos`.`ID`, presentacion_productos.id AS IDPRESENTACIONPRODUCTO,`presentacion_productos`.`CODIGO_BARRA` AS CODIGO " _
                                    & ",CONCAT(productos.`NOMBRE`,' ',marcas.NOMBRE,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION, " _
                                    & "`unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_tarifa_productos`.`VALOR`, `detalle_tarifa_productos`.`IVA` , " _
                                    & "`detalle_tarifa_productos`.`VALOR`-`detalle_tarifa_productos`.`IVA` AS SUBTOTAL, presentacion_productos.id_producto as IDPRODUCTO, marcas.NOMBRE AS MARCA FROM `detalle_tarifa_productos` " _
                                    & "INNER JOIN `presentacion_productos` ON (`detalle_tarifa_productos`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                    & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                    & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                    & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                    & "WHERE (`detalle_tarifa_productos`.`ESTADO` ='A' And `detalle_tarifa_productos`.`ID_TARIFA_PRODUCTO` ='" & IdTarifaProducto & "')")
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


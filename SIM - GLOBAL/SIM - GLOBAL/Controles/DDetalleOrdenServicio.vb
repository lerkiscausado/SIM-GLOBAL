Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleOrdenServicio
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal IdOrdenServicio As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden_servicio`.`ID`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION " _
                                                  & ", `unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_orden_servicio`.`CANTIDAD`, `detalle_orden_servicio`.`VALOR`" _
                                                  & ",(`detalle_orden_servicio`.`VALOR`* `detalle_orden_servicio`.`CANTIDAD`)-`detalle_orden_servicio`.`DESCUENTO`  AS SUBTOTAL, " _
                                                  & "`detalle_orden_servicio`.`DESCUENTO`, detalle_orden_servicio.id_producto as IDPRODUCTO " _
                                                  & "FROM `detalle_orden_servicio` 	INNER JOIN `presentacion_productos` ON (`detalle_orden_servicio`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`)" _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) WHERE detalle_orden_servicio.`ID_ORDEN_SERVICIO`='" & IdOrdenServicio & "'")
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
        Public Function Existe(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_orden_servicio WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _DetalleOrdenServicio As DetalleOrdenServicio)
            Try
                Dim query As String
                If Existe(_DetalleOrdenServicio.Id) = True Then
                    'query = "UPDATE detalle_tarifa_productos SET codigo_cups='" & _DetalleTarifa.CodigoCups & "', " _
                    '       & "valor='" & _DetalleTarifa.Valor & "', tipo_atencion='" & _DetalleTarifa.TipoAtencion & "', " _
                    '      & "estado='" & _DetalleTarifa.Estado & "' where id='" & _DetalleTarifa.Id & "'"
                Else
                    query = "insert into detalle_orden_servicio values('" & _DetalleOrdenServicio.Id & "','" &
                            _DetalleOrdenServicio.IdProducto & "','" & _DetalleOrdenServicio.Cantidad & "','" &
                            _DetalleOrdenServicio.Valor & "','" & _DetalleOrdenServicio.Iva & "', '" &
                            _DetalleOrdenServicio.Descuento & "','" & _DetalleOrdenServicio.Estado & "','" & _DetalleOrdenServicio.IdOrdenServicio & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleOrdenServicio(ByVal IDTemporal As String, ByVal IDOrdenServicio As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden_servicio SET id_orden_servicio='" & IDOrdenServicio & "' WHERE id_orden_servicio='" & IDTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleOrdenServicio(ByVal IdTemporal As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_servicio WHERE id_orden_servicio='" & IdTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleOrdenServicio(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_servicio WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteProducto(ByVal IdOrdenServicio As String, ByVal IdProducto As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT id FROM detalle_orden_servicio WHERE id_orden_servicio='" & IdOrdenServicio & "' and id_producto='" & IdProducto & "'")
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


Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleCotizacion
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal IdCotizacion As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_cotizacion`.`ID`, `presentacion_productos`.`CODIGO_BARRA` AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION " _
                                                  & ", `unidad_medida`.`NOMBRE` AS UNIDAD, `detalle_cotizacion`.`CANTIDAD`, `detalle_cotizacion`.`VALOR`" _
                                                  & ",(`detalle_cotizacion`.`VALOR`* `detalle_cotizacion`.`CANTIDAD`)-`detalle_cotizacion`.`DESCUENTO`  AS SUBTOTAL, `detalle_cotizacion`.`DESCUENTO` " _
                                                  & "FROM `detalle_cotizacion` 	INNER JOIN `presentacion_productos` ON (`detalle_cotizacion`.`ID_PRODUCTO` = `presentacion_productos`.`ID`) " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`)" _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) WHERE detalle_cotizacion.`ID_COTIZACION`='" & IdCotizacion & "'")
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
                        String.Format("SELECT id FROM detalle_cotizacion WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _DetalleCotizacion As DetalleCotizacion)
            Try
                Dim query As String
                If Existe(_DetalleCotizacion.Id) = True Then
                    'query = "UPDATE detalle_tarifa_productos SET codigo_cups='" & _DetalleTarifa.CodigoCups & "', " _
                    '       & "valor='" & _DetalleTarifa.Valor & "', tipo_atencion='" & _DetalleTarifa.TipoAtencion & "', " _
                    '      & "estado='" & _DetalleTarifa.Estado & "' where id='" & _DetalleTarifa.Id & "'"
                Else
                    query = "insert into detalle_cotizacion values('" & _DetalleCotizacion.Id & "','" &
                            _DetalleCotizacion.IdProducto & "','" & _DetalleCotizacion.Cantidad & "','" &
                            _DetalleCotizacion.Valor & "','" & _DetalleCotizacion.Iva & "', '" &
                            _DetalleCotizacion.Descuento & "','" & _DetalleCotizacion.Estado & "','" & _DetalleCotizacion.IdCotizacion & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleCotizacion(ByVal IDTemporal As String, ByVal IDCotizacion As String)
            Try
                Dim query As String
                query = "UPDATE detalle_cotizacion SET id_cotizacion='" & IDCotizacion & "' WHERE id_cotizacion='" & IDTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleCotizacion(ByVal IdTemporal As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_cotizacion WHERE id_cotizacion='" & IdTemporal & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleCotizacion(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_cotizacion WHERE id='" & Id & "'"

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

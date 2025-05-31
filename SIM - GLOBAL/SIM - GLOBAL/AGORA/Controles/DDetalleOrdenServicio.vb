Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DDetalleOrdenServicio
        Shared _conn As New OdbcConnection
        Shared _adapter As DataAdapter
        Shared _ds As DataSet
        Public Sub Guardar(ByVal _DetalleOrdenServicio As AGORA.Modelo.DetalleOrdenServicio)
            Try
                Dim query As String
                query = "insert into detalle_orden_agora values('" & _DetalleOrdenServicio.Id & "', " _
                     & "'" & _DetalleOrdenServicio.Salon & "', " _
                     & "'" & _DetalleOrdenServicio.Servicio & "', " _
                     & "'" & _DetalleOrdenServicio.Descripcion & "', " _
                     & "'" & Format(_DetalleOrdenServicio.FechaServicio, "yyyy/MM/dd") & "', " _
                     & "'" & Format(_DetalleOrdenServicio.HoraInicio, "HH:mm:ss") & "', " _
                     & "'" & Format(_DetalleOrdenServicio.HoraFinal, "HH:mm:ss") & "', " _
                     & "'" & _DetalleOrdenServicio.Cantidad & "', " _
                     & "?,?,?,'" & _DetalleOrdenServicio.Estado & "', " _
                     & "'" & _DetalleOrdenServicio.IdOrdenServicio & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleOrdenServicio.Valor))
                comando.Parameters.AddWithValue(2, CDec(_DetalleOrdenServicio.IVA))
                comando.Parameters.AddWithValue(3, CDec(_DetalleOrdenServicio.Descuento))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_orden_agora`.`ID`, " _
                                        & "`detalle_orden_agora`.FECHA_SERVICIO, " _
                                        & "detalle_orden_agora.SALON, " _
                                        & "detalle_orden_agora.SERVICIO, " _
                                        & "`detalle_orden_agora`.`DESCRIPCION`, " _
                                        & "`detalle_orden_agora`.`HORA_INICIO`, " _
                                        & "`detalle_orden_agora`.`HORA_FINAL`, " _
                                        & "`detalle_orden_agora`.`CANTIDAD`, " _
                                        & "`detalle_orden_agora`.`VALOR`, " _
                                        & "(`detalle_orden_agora`.`CANTIDAD` * detalle_orden_agora.VALOR) as NETO, " _
                                        & "`detalle_orden_agora`.`DESCUENTO`, " _
                                        & "(`detalle_orden_agora`.`CANTIDAD` * detalle_orden_agora.VALOR) - detalle_orden_agora.DESCUENTO AS SUBTOTAL " _
                                        & "FROM `detalle_orden_agora` WHERE detalle_orden_agora.`ID_ORDEN_SERVICIO`='" & IdOrden & "'")
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
        Public Sub EliminarItemDetalleOrden(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_agora WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleOrden(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_agora WHERE id_orden_servicio='" & IdOrden & "'"

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
                query = "UPDATE detalle_orden_agora SET id_orden_servicio='" & IDOrdenServicio & "' WHERE id_orden_servicio='" & IDTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarDetalleOrdenServicio(ByVal IdOrdenServicio As String, ByVal IdCotizacion As String)
            Try
                Dim query As String
                query = "INSERT INTO detalle_orden_agora (salon, servicio, descripcion, fecha_servicio, hora_inicio, hora_final, " _
                      & "cantidad, valor, iva, descuento, estado, id_orden_servicio) SELECT salon, servicio, descripcion,  " _
                      & "fecha_servicio, hora_inicio, hora_final, cantidad, valor, iva, descuento, 'PROCESADO', '" & IdOrdenServicio & "' AS id " _
                      & "FROM detalle_cotizacion_agora WHERE id_cotizacion='" & IdCotizacion & "'"
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


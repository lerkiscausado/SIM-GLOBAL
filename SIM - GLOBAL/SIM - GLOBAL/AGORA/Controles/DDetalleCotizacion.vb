Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DDetalleCotizacion
        Shared _conn As New OdbcConnection
        Shared _adapter As DataAdapter
        Shared _ds As DataSet
        Public Sub Guardar(ByVal _DetalleCotizacion As AGORA.Modelo.DetalleCotizacion)
            Try
                Dim query As String
                query = "insert into detalle_cotizacion_agora values('" & _DetalleCotizacion.Id & "', " _
                     & "'" & _DetalleCotizacion.Salon & "', " _
                     & "'" & _DetalleCotizacion.Servicio & "', " _
                     & "'" & _DetalleCotizacion.Descripcion & "', " _
                     & "'" & Format(_DetalleCotizacion.FechaServicio, "yyyy/MM/dd") & "', " _
                     & "'" & Format(_DetalleCotizacion.HoraInicio, "HH:mm:ss") & "', " _
                     & "'" & Format(_DetalleCotizacion.HoraFinal, "HH:mm:ss") & "', " _
                     & "'" & _DetalleCotizacion.Cantidad & "', " _
                     & "?,?,?,'" & _DetalleCotizacion.Estado & "', " _
                     & "'" & _DetalleCotizacion.IdCotizacion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_DetalleCotizacion.Valor))
                comando.Parameters.AddWithValue(2, CDec(_DetalleCotizacion.IVA))
                comando.Parameters.AddWithValue(3, CDec(_DetalleCotizacion.Descuento))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdCotizacion As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_cotizacion_agora`.`ID`, " _
                                        & "`detalle_cotizacion_agora`.FECHA_SERVICIO, " _
                                        & "detalle_cotizacion_agora.SALON, " _
                                        & "detalle_cotizacion_agora.SERVICIO, " _
                                        & "`detalle_cotizacion_agora`.`DESCRIPCION`, " _
                                        & "`detalle_cotizacion_agora`.`HORA_INICIO`, " _
                                        & "`detalle_cotizacion_agora`.`HORA_FINAL`, " _
                                        & "`detalle_cotizacion_agora`.`CANTIDAD`, " _
                                        & "`detalle_cotizacion_agora`.`VALOR`, " _
                                        & "(`detalle_cotizacion_agora`.`CANTIDAD` * detalle_cotizacion_agora.VALOR) as NETO, " _
                                        & "`detalle_cotizacion_agora`.`DESCUENTO`, " _
                                        & "(`detalle_cotizacion_agora`.`CANTIDAD` * detalle_cotizacion_agora.VALOR) - detalle_cotizacion_agora.DESCUENTO AS SUBTOTAL " _
                                        & "FROM `detalle_cotizacion_agora` WHERE detalle_cotizacion_agora.`ID_COTIZACION`='" & IdCotizacion & "'")
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
        Public Sub EliminarItemDetalleCotizacion(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_cotizacion_agora WHERE id='" & Id & "'"

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
                query = "UPDATE detalle_cotizacion_agora SET id_cotizacion='" & IDCotizacion & "' WHERE id_cotizacion='" & IDTemporal & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleCotizacion(ByVal IdCotizacion As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_cotizacion_agora WHERE id_cotizacion='" & IdCotizacion & "'"

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


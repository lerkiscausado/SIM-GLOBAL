Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleFacturacion
        Shared _conn As New OdbcConnection
        Public Sub Guardar(ByVal _DetalleOrdenFactura As SIM___GLOBAL.Modelo.DetalleFacturacion)
            Try
                Dim query As String
                query = "INSERT INTO detalle_orden_factura VALUES('" & Val(_DetalleOrdenFactura.Id) & "', " _
                    & "'" & _DetalleOrdenFactura.IdOrden & "', " _
                    & "'" & _DetalleOrdenFactura.IdCausa & "', " _
                    & "'" & _DetalleOrdenFactura.IdFinalidadConsulta & "', " _
                    & "'" & _DetalleOrdenFactura.IdFinalidadProcedimiento & "', " _
                    & "'" & _DetalleOrdenFactura.IdAmbito & "', " _
                    & "'" & _DetalleOrdenFactura.IdPersonaAtiende & "', " _
                    & "'" & Format(_DetalleOrdenFactura.FechaSalida, "yyyy/MM/dd") & "', " _
                    & "'" & Format(_DetalleOrdenFactura.Hora, "hh:mm:ss") & "', " _
                    & "'" & _DetalleOrdenFactura.IdTipoDiagnostico & "', " _
                    & "'" & _DetalleOrdenFactura.Diagnostico1 & "', " _
                    & "'" & _DetalleOrdenFactura.Diagnostico2 & "', " _
                    & "'" & _DetalleOrdenFactura.Diagnostico3 & "', " _
                    & "'" & _DetalleOrdenFactura.Diagnostico4 & "', " _
                    & "'" & _DetalleOrdenFactura.IdFormaRealizacion & "', " _
                    & "'" & _DetalleOrdenFactura.CodigoProcedimiento & "', " _
                    & "'" & _DetalleOrdenFactura.CodigoCups & "', " _
                    & "'" & _DetalleOrdenFactura.IdTipoEstudio & "', " _
                    & "'" & _DetalleOrdenFactura.Valor & "', " _
                    & "'" & _DetalleOrdenFactura.Copago & "', " _
                    & "'" & _DetalleOrdenFactura.Neto & "', " _
                    & "'" & _DetalleOrdenFactura.Tipo & "', " _
                    & "'" & _DetalleOrdenFactura.Estado & "', " _
                    & " '" & _DetalleOrdenFactura.IdRelacion & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleOrdenFactura(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_factura WHERE id_orden='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal IdRelacion As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden_factura WHERE id_relacion='" & IdRelacion & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Cancelar(ByVal IdRelacion As String)
            Try
                Dim query As String
                query = "update detalle_orden_factura set estado='CANCELADO' WHERE id_relacion='" & IdRelacion & "'"
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


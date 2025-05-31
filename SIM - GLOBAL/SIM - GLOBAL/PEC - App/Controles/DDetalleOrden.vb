Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleOrden
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _DetalleOrden As PEC___App.Modelo.DetalleOrden)
            Try
                Dim query As String
                If Existe(_DetalleOrden.Id) = True Then
                    query = "UPDATE detalle_orden SET valor='" & _DetalleOrden.Valor & "', " _
                            & "iva='" & _DetalleOrden.IVA & "',	" _
                            & "estado='" & _DetalleOrden.Estado & "' " _
                            & "WHERE id='" & _DetalleOrden.Id & "'"
                Else
                    query = "INSERT INTO detalle_orden VALUES('" & Val(_DetalleOrden.Id) & "', " _
                                                           & "'" & _DetalleOrden.IdOrden & "', " _
                                                           & "'" & _DetalleOrden.IdTipoEstudio & "', " _
                                                           & "'" & Format(_DetalleOrden.FechaSalida, "yyyy/MM/dd") & "', " _
                                                           & "'" & Format(_DetalleOrden.Hora, "hh:mm:ss") & "', " _
                                                           & "'" & _DetalleOrden.Valor & "', " _
                                                           & "'" & _DetalleOrden.IVA & "', " _
                                                           & "'" & _DetalleOrden.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_orden WHERE id='" & IdDetalleOrden & "'")
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
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_orden`.`ID`, " _
                                        & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, " _
                                        & "`detalle_orden`.`VALOR`, " _
                                        & "`detalle_orden`.`IVA`, " _
                                        & "`detalle_orden`.`VALOR` + detalle_orden.IVA AS `SUBTOTAL`, " _
                                        & "`detalle_orden`.`ESTADO` " _
                                        & "FROM `detalle_orden` INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                        & "WHERE (`detalle_orden`.`ID_ORDEN` ='" & IdOrden & "') ORDER BY `detalle_orden`.`ID` ASC")
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
        Public Sub Eliminar(ByVal IdDetalleOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden WHERE id='" & IdDetalleOrden & "'"
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
                query = "DELETE FROM detalle_orden WHERE id_orden='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleOrden(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET id_orden='" & filtro & "' WHERE id_orden='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarEstadoOrden(ByVal IdOrden As String, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET estado='" & Estado & "' WHERE id_orden='" & IdOrden & "'"

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

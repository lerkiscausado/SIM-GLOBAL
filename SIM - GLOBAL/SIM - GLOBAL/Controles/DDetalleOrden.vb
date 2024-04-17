Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleOrden
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As DetalleOrden
            Try
                Dim query As String = String.Format("SELECT * FROM detalle_orden WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _DetalleOrden = New DetalleOrden
                _DetalleOrden.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _DetalleOrden.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _DetalleOrden.IdCausa = _ds.Tables(0).Rows(0)(2).ToString()
                _DetalleOrden.IdFinalidadConsulta = _ds.Tables(0).Rows(0)(3).ToString()
                _DetalleOrden.IdFinalidadProcedimiento = _ds.Tables(0).Rows(0)(4).ToString()
                _DetalleOrden.IdAmbito = _ds.Tables(0).Rows(0)(5).ToString()
                _DetalleOrden.IdPersonaAtiende = _ds.Tables(0).Rows(0)(6).ToString()
                _DetalleOrden.FechaSalida = _ds.Tables(0).Rows(0)(7).ToString()
                _DetalleOrden.Hora = _ds.Tables(0).Rows(0)(8).ToString()
                _DetalleOrden.IdTipoDiagnostico = _ds.Tables(0).Rows(0)(9).ToString()
                _DetalleOrden.Diagnostico1 = _ds.Tables(0).Rows(0)(10).ToString()
                _DetalleOrden.Diagnostico2 = _ds.Tables(0).Rows(0)(11).ToString()
                _DetalleOrden.Diagnostico3 = _ds.Tables(0).Rows(0)(12).ToString()
                _DetalleOrden.Diagnostico4 = _ds.Tables(0).Rows(0)(13).ToString()
                _DetalleOrden.IdFormaRealizacion = _ds.Tables(0).Rows(0)(14).ToString()
                _DetalleOrden.CodigoProcedimiento = _ds.Tables(0).Rows(0)(15).ToString()
                _DetalleOrden.CodigoCups = _ds.Tables(0).Rows(0)(16).ToString()
                _DetalleOrden.IdTipoEstudio = _ds.Tables(0).Rows(0)(17).ToString()
                _DetalleOrden.Valor = _ds.Tables(0).Rows(0)(18).ToString()
                _DetalleOrden.Copago = _ds.Tables(0).Rows(0)(19).ToString()
                _DetalleOrden.Neto = _ds.Tables(0).Rows(0)(20).ToString()
                _DetalleOrden.Tipo = _ds.Tables(0).Rows(0)(21).ToString()
                _DetalleOrden.Estado = _ds.Tables(0).Rows(0)(22).ToString()
                _DetalleOrden.IdRelacion = _ds.Tables(0).Rows(0)(23).ToString()
                Return _DetalleOrden
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteConsulta(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM detalle_orden WHERE id_orden='" & filtro & "'")
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
        Public Function ExisteIDOrden(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM detalle_orden WHERE id_orden='" & filtro & "'")
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
        Public Sub Guardar(ByVal _DetalleOrden As DetalleOrden)
            Try
                Dim query As String
                If ExisteConsulta(_DetalleOrden.IdOrden) = True Then
                    query = "UPDATE detalle_orden SET id_causa='" & _DetalleOrden.IdCausa & "', " _
                            & "id_finalidad_consulta='" & _DetalleOrden.IdFinalidadConsulta & "',	" _
                            & "id_finalidad_procedimiento='" & _DetalleOrden.IdFinalidadProcedimiento & "'," _
                            & "id_ambito='" & _DetalleOrden.IdAmbito & "'," _
                            & "id_persona_atiende='" & _DetalleOrden.IdPersonaAtiende & "'," _
                            & "fecha_salida='" & Format(_DetalleOrden.FechaSalida, "yyyy/MM/dd") & "'," _
                            & "hora='" & Format(_DetalleOrden.Hora, "hh:mm:ss") & "', " _
                            & "id_tipo_diagnostico='" & _DetalleOrden.IdTipoDiagnostico & "', " _
                            & "diagnostico1='" & _DetalleOrden.Diagnostico1 & "', " _
                            & "diagnostico2='" & _DetalleOrden.Diagnostico2 & "', " _
                            & "diagnostico3='" & _DetalleOrden.Diagnostico3 & "', " _
                            & "diagnostico4='" & _DetalleOrden.Diagnostico4 & "', " _
                            & "id_forma_realizacion='" & _DetalleOrden.IdFormaRealizacion & "', " _
                            & "codigo_procedimiento ='" & _DetalleOrden.CodigoProcedimiento & "', " _
                            & "codigo_cups ='" & _DetalleOrden.CodigoCups & "', " _
                            & "id_tipo_estudio ='" & _DetalleOrden.IdTipoEstudio & "', " _
                            & "valor='" & _DetalleOrden.Valor & "', copago='" & _DetalleOrden.Copago & "', " _
                            & "neto='" & _DetalleOrden.Neto & "', tipo='" & _DetalleOrden.Tipo & "', estado='" & _DetalleOrden.Estado & "' WHERE id='" & _DetalleOrden.Id & "'"
                Else
                    query = "INSERT INTO detalle_orden VALUES('" & Val(_DetalleOrden.Id) & "','" & _DetalleOrden.IdOrden & "','" & _DetalleOrden.IdCausa & "', " _
                            & "'" & _DetalleOrden.IdFinalidadConsulta & "','" & _DetalleOrden.IdFinalidadProcedimiento & "', " _
                            & "'" & _DetalleOrden.IdAmbito & "','" & _DetalleOrden.IdPersonaAtiende & "', " _
                            & "'" & Format(_DetalleOrden.FechaSalida, "yyyy/MM/dd") & "','" & Format(_DetalleOrden.Hora, "hh:mm:ss") & "', " _
                            & "'" & _DetalleOrden.IdTipoDiagnostico & "','" & _DetalleOrden.Diagnostico1 & "', " _
                            & "'" & _DetalleOrden.Diagnostico2 & "','" & _DetalleOrden.Diagnostico3 & "', " _
                            & "'" & _DetalleOrden.Diagnostico4 & "','" & _DetalleOrden.IdFormaRealizacion & "', " _
                            & "'" & _DetalleOrden.CodigoProcedimiento & "','" & _DetalleOrden.CodigoCups & "','" & _DetalleOrden.IdTipoEstudio & "','" & _DetalleOrden.Valor & "', " _
                            & "'" & _DetalleOrden.Copago & "','" & _DetalleOrden.Neto & "','" & _DetalleOrden.Tipo & "','" & _DetalleOrden.Estado & "','" & _DetalleOrden.IdRelacion & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarDetalleOrden(ByVal _DetalleOrden As DetalleOrden)
            Try
                Dim query As String
                query = "INSERT INTO detalle_orden VALUES('" & _DetalleOrden.Id & "','" & _DetalleOrden.IdOrden & "','" & _DetalleOrden.IdCausa & "', " _
                            & "'" & _DetalleOrden.IdFinalidadConsulta & "','" & _DetalleOrden.IdFinalidadProcedimiento & "', " _
                            & "'" & _DetalleOrden.IdAmbito & "','" & _DetalleOrden.IdPersonaAtiende & "', " _
                            & "'" & Format(_DetalleOrden.FechaSalida, "yyyy/MM/dd") & "',TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & _DetalleOrden.IdTipoDiagnostico & "','" & _DetalleOrden.Diagnostico1 & "', " _
                            & "'" & _DetalleOrden.Diagnostico2 & "','" & _DetalleOrden.Diagnostico3 & "', " _
                            & "'" & _DetalleOrden.Diagnostico4 & "','" & _DetalleOrden.IdFormaRealizacion & "', " _
                            & "'" & _DetalleOrden.CodigoProcedimiento & "','" & _DetalleOrden.CodigoCups & "','" & _DetalleOrden.IdTipoEstudio & "','" & _DetalleOrden.Valor & "', " _
                            & "'" & _DetalleOrden.Copago & "','" & _DetalleOrden.Neto & "','" & _DetalleOrden.Tipo & "','" & _DetalleOrden.Estado & "','" & _DetalleOrden.IdRelacion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                            String.Format("SELECT `detalle_orden`.`ID`, " _
                                          & "`detalle_orden`.`CODIGO_CUPS` AS CODIGO, " _
                                          & "`cups`.`NOMBRE_CUPS` AS NOMBRE, " _
                                          & "`detalle_orden`.`VALOR`, " _
                                          & "`detalle_orden`.`COPAGO`, " _
                                          & "`detalle_orden`.`ESTADO`, " _
                                          & "`detalle_orden`.`ID_RELACION` AS IDRELACION " _
                                          & "FROM `detalle_orden` " _
                                          & "INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                          & "WHERE (`detalle_orden`.`ESTADO` <>'CANCELADO' And `detalle_orden`.`ID_ORDEN` ='" & IdOrden & "') " _
                                          & "ORDER BY `detalle_orden`.`ID` ASC")
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
        Public Sub Cancelar(ByVal IdDetalleOrden As String)
            Try
                Dim query As String
                query = "update detalle_orden set estado='CANCELADO' WHERE id='" & IdDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleOrden(ByVal filtro As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_orden WHERE id_orden='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteDetalleOrden(ByVal filtro As String, ByVal filtro2 As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM detalle_orden WHERE id_orden='" & filtro & "' Or id_orden ='" & filtro2 & "'")
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
        Public Sub ActualizarEstado(ByVal filtro As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET estado='ATENDIDO' WHERE id='" & filtro & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function DetalleOrdenPendiente(ByVal IDORden As String) As Boolean
            Try
                Dim query As String =
                            String.Format("SELECT ID FROM detalle_orden WHERE (id_orden='" & IDORden & "' AND estado='PENDIENTE' ) AND detalle_orden.`ID_TIPO_ESTUDIO`<>'14'")
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
        Public Function DetalleOrdenPendienteEndoscopia(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                            String.Format("SELECT ID FROM detalle_orden WHERE id='" & filtro & "' and estado='PENDIENTE'")
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
        Public Function CodigoConsulta(ByVal IdDetalleOrden As String) As DataSet
            Try
                Dim query As String =
                        String.Format("SELECT codigo_procedimiento from detalle_orden where id='" & IdDetalleOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Function DetalleOrdenAtendida(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM detalle_orden WHERE id_orden='" & filtro & "' and estado<>'PENDIENTE'")
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
        Public Sub ActualizarEstadoDetalleOrden(ByVal filtro As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET estado='CANCELADO' WHERE id_orden='" & filtro & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub CancelarDetalleOrden(ByVal filtro As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET estado='CANCELADO' WHERE id='" & filtro & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ProcesoDetalleOrden(ByVal filtro As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET estado='PROCESO' WHERE id='" & filtro & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDiagnosticoyEstado(ByVal IdDetalleOrden As String, ByVal Diagnostico1 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET diagnostico1='" & Diagnostico1 & "', estado='ATENDIDO' WHERE id='" & IdDetalleOrden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDiagnosticoyEstado2(ByVal IdOrden As String, ByVal Diagnostico1 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET diagnostico1='" & Diagnostico1 & "', estado='ATENDIDO' WHERE id_orden='" & IdOrden & "'"

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
        Public Shared Function UltimoRegistro() As String
            Try
                Dim query As String = String.Format("SELECT id FROM detalle_orden ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteImagen(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                    String.Format("SELECT ID FROM imagenes WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Function ExisteEstudio(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                    String.Format("SELECT ID FROM endoscopias WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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

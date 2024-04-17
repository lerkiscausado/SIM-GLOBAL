Imports SIM___INTEGRA.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DOrdenes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT * FROM ordenes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _ordenes = New Ordenes
                _ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _ordenes.FechaIngreso = _ds.Tables(0).Rows(0)(1).ToString()
                _ordenes.IdUsuario = _ds.Tables(0).Rows(0)(2).ToString()
                _ordenes.IdTipoConsulta = _ds.Tables(0).Rows(0)(3).ToString()
                _ordenes.CodigoDiagnostico = _ds.Tables(0).Rows(0)(4).ToString()
                _ordenes.Cometarios = _ds.Tables(0).Rows(0)(5).ToString()
                _ordenes.IdContrato = _ds.Tables(0).Rows(0)(6).ToString()
                _ordenes.IdSubEntidad = _ds.Tables(0).Rows(0)(7).ToString()
                _ordenes.IdIngreso = _ds.Tables(0).Rows(0)(8).ToString()
                _ordenes.IdSede = _ds.Tables(0).Rows(0)(9).ToString()
                _ordenes.IdEmpleado = _ds.Tables(0).Rows(0)(10).ToString()
                _ordenes.Autorizacion = _ds.Tables(0).Rows(0)(11).ToString()
                _ordenes.NumeroOrden = _ds.Tables(0).Rows(0)(12).ToString()
                _ordenes.FechaOrden = _ds.Tables(0).Rows(0)(13).ToString()
                _ordenes.Hora = _ds.Tables(0).Rows(0)(14).ToString()
                _ordenes.IdFactura = _ds.Tables(0).Rows(0)(15).ToString()
                _ordenes.IdTipoAfiliado = _ds.Tables(0).Rows(0)(16).ToString()
                _ordenes.IdTipoUsuario = _ds.Tables(0).Rows(0)(17).ToString()
                _ordenes.IdTipoEstudio = _ds.Tables(0).Rows(0)(18).ToString()
                _ordenes.Estado = _ds.Tables(0).Rows(0)(19).ToString()
                Return _ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function CargarOrdenes(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT * FROM ordenes WHERE id='" & filtro & "' and estado <> 'CANCELADA'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _ordenes = New Ordenes
                _ordenes.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _ordenes.FechaIngreso = _ds.Tables(0).Rows(0)(1).ToString()
                _ordenes.IdUsuario = _ds.Tables(0).Rows(0)(2).ToString()
                _ordenes.IdTipoConsulta = _ds.Tables(0).Rows(0)(3).ToString()
                _ordenes.CodigoDiagnostico = _ds.Tables(0).Rows(0)(4).ToString()
                _ordenes.Cometarios = _ds.Tables(0).Rows(0)(5).ToString()
                _ordenes.IdContrato = _ds.Tables(0).Rows(0)(6).ToString()
                _ordenes.Estado = _ds.Tables(0).Rows(0)(7).ToString()
                Return _ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _ordenes As Ordenes)
            Try
                Dim query As String
                If Existe(_ordenes.ID) = True Then

                    query = "UPDATE ordenes SET id_tipo_consulta='" &
                     _ordenes.IdTipoConsulta & "', codigo_diagnostico='" & _ordenes.CodigoDiagnostico & "', comentarios='" & _ordenes.Cometarios & "', id_contrato='" & _ordenes.IdContrato & "' where id='" & _ordenes.ID & "'"
                Else

                    query = "insert into ordenes values('" & _ordenes.ID & "','" & Format(_ordenes.FechaIngreso, "yyyy/MM/dd") & "','" & _ordenes.IdUsuario & "','" & _ordenes.IdTipoConsulta & "','" & _ordenes.CodigoDiagnostico & "','" & _ordenes.Cometarios & "','" & _ordenes.IdContrato & "','" & _ordenes.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteUsuario(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ordenes.ID_USUARIO FROM ordenes INNER JOIN usuarios ON 
                        (ordenes.ID_USUARIO = usuarios.ID) WHERE (ordenes.ID_USUARIO ='" & filtro & "')")
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
        Public Function ExisteUsuarioFecha(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ordenes.ID_USUARIO FROM ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID)
                           WHERE (MONTH(ordenes.FECHA_INGRESO) = MONTH(CURDATE()) AND YEAR(ordenes.FECHA_INGRESO) = YEAR(CURDATE()) AND ordenes.ID_USUARIO = '" & filtro & "' AND ordenes.estado<>'CANCELADA')")
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
        Public Function Existe(ByVal codigo As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & codigo & "'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT * FROM v_ordenes")
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
        Public Function ListarUltimoRegistro(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT codigo_diagnostico, id_contrato FROM ordenes WHERE id_usuario='" & filtro & "' ORDER BY id DESC LIMIT 1")
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
        Public Function PacientesAtender() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT * FROM v_pacientesatender")
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
        Public Function PacientesAtenderMes(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS `ORDEN`, CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `NOMBRE` " _
                                    & ",`tipo_consulta`.`MOTIVO_CONSULTA` AS `CONSULTA` FROM ((`ordenes` JOIN `usuarios` ON((`ordenes`.`ID_USUARIO` = `usuarios`.`ID`))) " _
                                    & "JOIN `tipo_consulta` ON((`ordenes`.`ID_TIPO_CONSULTA` = `tipo_consulta`.`ID`))) WHERE 	((MONTH(`ordenes`.`FECHA_INGRESO`) = '" & filtro & "') " _
                                    & "AND	(YEAR(`ordenes`.`FECHA_INGRESO`) = YEAR(CURDATE())) And	((`ordenes`.`ESTADO` <> _utf8'CANCELADA') Or " _
                                    & "(`ordenes`.`ESTADO` <> _utf8'CANCELADA'))) ORDER BY `ordenes`.`ID`")
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
        Public Function DatosUsuarios(ByVal filtro As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("CALL sp_DatosUsuarios('" & filtro & "')")
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
        Public Function OrdenPendiente(ByVal filtro As Integer) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & filtro & "' and estado='PENDIENTE'")
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
        Public Function OrdenAtendida(ByVal filtro As Integer) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & filtro & "' and estado='ATENDIDA'")
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
        Public Sub CancelarOrden(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='CANCELADA' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarEstado(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='ATENDIDA' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function MotivoConsulta(ByVal filtro As Integer) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ordenes.ID FROM ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) WHERE 
                        (usuarios.ID ='" & filtro & "' AND ordenes.ESTADO <>'CANCELADA')")
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
        Public Function IdUsuario(ByVal filtro As String) As String
            Try
                Dim query As String =
                                    String.Format("SELECT ID_USUARIO FROM ordenes WHERE ID ='" & filtro & "'")
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

    End Class

End Namespace

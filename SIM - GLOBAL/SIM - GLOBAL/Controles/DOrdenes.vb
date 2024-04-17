Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc

Namespace Controles
    Public Class DOrdenes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Shared _dt1 As DataTable
        Shared _dt2 As DataTable
        Public Shared Function Cargar(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT * FROM ordenes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Ordenes.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _Ordenes.IdContrato = _ds.Tables(0).Rows(0)(2).ToString()
                _Ordenes.IdSubEntidad = _ds.Tables(0).Rows(0)(3).ToString()
                _Ordenes.IdIngreso = _ds.Tables(0).Rows(0)(4).ToString()
                _Ordenes.IdSede = _ds.Tables(0).Rows(0)(5).ToString()
                _Ordenes.IdEmpleado = _ds.Tables(0).Rows(0)(6).ToString()
                _Ordenes.Autorizacion = _ds.Tables(0).Rows(0)(7).ToString()
                _Ordenes.NumeroOrden = _ds.Tables(0).Rows(0)(8).ToString()
                _Ordenes.FechaIngreso = _ds.Tables(0).Rows(0)(9).ToString()
                _Ordenes.FechaOrden = _ds.Tables(0).Rows(0)(10).ToString()
                _Ordenes.Hora = _ds.Tables(0).Rows(0)(11).ToString()
                _Ordenes.Idfactura = _ds.Tables(0).Rows(0)(12).ToString()
                _Ordenes.IdTipoAfiliado = _ds.Tables(0).Rows(0)(13).ToString()
                _Ordenes.IdTipoUsuario = _ds.Tables(0).Rows(0)(14).ToString()
                _Ordenes.IdTipoEstudio = _ds.Tables(0).Rows(0)(15).ToString()
                _Ordenes.Comentarios = _ds.Tables(0).Rows(0)(16).ToString()
                _Ordenes.Consecutivo = _ds.Tables(0).Rows(0)(17).ToString()
                _Ordenes.Estado = _ds.Tables(0).Rows(0)(18).ToString()
                _Ordenes.IdEspecimen = _ds.Tables(0).Rows(0)(19).ToString()
                '_Ordenes.Saldo = _ds.Tables(0).Rows(0)(20)

                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Ordenes As Ordenes)
            Try
                Dim query As String
                If Existe(_Ordenes.Id) = True Then
                    query = "UPDATE ordenes SET id_contrato='" & _Ordenes.IdContrato & "',id_subentidad='" & _Ordenes.IdSubEntidad & "', numero_orden='" & _Ordenes.NumeroOrden & "', " _
                           & "fecha_orden='" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "', id_empleado='" & _Ordenes.IdEmpleado & "',autorizacion='" & _Ordenes.Autorizacion & "', " _
                           & "id_tipo_afiliado='" & _Ordenes.IdTipoAfiliado & "', id_tipo_usuario='" & _Ordenes.IdTipoUsuario & "',id_especimen='" & _Ordenes.IdEspecimen & "' " _
                           & "where id='" & _Ordenes.Id & "'"
                Else
                    query = "insert into ordenes values('" & _Ordenes.Id & "','" & _Ordenes.IdUsuario & "','" & _Ordenes.IdContrato & "', '" & _Ordenes.IdSubEntidad & "', " _
                            & "'" & _Ordenes.IdIngreso & "','" & _Ordenes.IdSede & "','" & Val(_Ordenes.IdEmpleado) & "','" & _Ordenes.Autorizacion & "', " _
                            & "'" & _Ordenes.NumeroOrden & "', '" & Format(_Ordenes.FechaIngreso, "yyyy/MM/dd") & "', '" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "', " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), '" & _Ordenes.Idfactura & "','" & _Ordenes.IdTipoAfiliado & "','" & _Ordenes.IdTipoUsuario & "', " _
                            & "'" & _Ordenes.IdTipoEstudio & "','" & _Ordenes.Comentarios & "','" & _Ordenes.Consecutivo & "', '" & _Ordenes.Estado & "','" & _Ordenes.IdEspecimen & "',?)"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_Ordenes.Saldo))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Sub AgregarOrdenes(ByVal _orden As String, ByVal _Factura As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET id_factura='" & _Factura & "' where id='" & _orden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UsuarioEmail(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID_usuario`, " _
                                                  & "`usuarios`.`CORREO_ELECTRONICO`, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.segundo_NOMBRE,' ',usuarios.PRIMER_apellido,' ',usuarios.segundo_apellido) AS PACIENTE " _
                                                  & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) WHERE (`ordenes`.`ID` ='" & IdOrden & "')")
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
        Public Function ListarPacientesAtender() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.segundo_NOMBRE,' ',usuarios.PRIMER_apellido,' ',usuarios.segundo_apellido) AS PACIENTE " _
                                                  & ", contratos.NOMBRE AS CONTRATO FROM  ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) " _
                                                  & "INNER JOIN contratos ON (ordenes.ID_CONTRATO = contratos.ID) WHERE (ordenes.FECHA_ingreso =CURDATE() AND ordenes.ESTADO <> 'CANCELADO')")
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
        Public Function ExisteOrdenDia(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM ordenes WHERE (FECHA_INGRESO=CURDATE() AND ID_USUARIO ='" & filtro & "' AND estado<>'CANCELADO')")
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
        Public Shared Function UltimoRegistroPaciente(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT id FROM ordenes WHERE id_usuario='" & filtro & "' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub CancelarOrden(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='CANCELADO' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Sub ActualizarEstado(ByVal filtro As Integer, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='" & Estado & "' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub CancelarOrdenManual(ByVal filtro As Integer, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='" & Estado & "', consecutivo='' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
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
        Public Function ListarOrdenes() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT * from v_ordenes")
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
        Public Function ListarOrdenesMartinez(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS `ORDEN`,  `ordenes`.`FECHA_INGRESO` AS `FECHA_INGRESO`,  " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION`,  " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ' " _
                                                  & ",`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `NOMBRE` " _
                                                  & ",  `usuarios`.`SEXO` AS `SEXO`,  TIMESTAMPDIFF(YEAR,`usuarios`.`FECHA_NACIMIENTO`,CURDATE()) AS `EDAD` " _
                                                  & ",  `usuarios`.`TELEFONO` AS `TELEFONOS`,  `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO` " _
                                                  & ",  `contratos`.`NOMBRE` AS `CONTRATO`,  `entidades`.`NOMBRE_ENTIDAD` AS `ENTIDAD`, " _
                                                  & "`sedes`.`NOMBRE` AS SEDE,  `ordenes`.`ESTADO` AS `ESTADO`,  detalle_orden.id AS DETALLE FROM  `ordenes`   INNER JOIN `usuarios`" _
                                                  & "ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)  INNER JOIN `sedes` ON " _
                                                  & "(`ordenes`.`ID_SEDE` = `sedes`.`ID`) INNER JOIN `contratos` ON " _
                                                  & "(`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `tipo_estudio` ON " _
                                                  & "(`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) INNER JOIN `entidades` ON " _
                                                  & "(`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `detalle_orden` ON (`ordenes`.`id` = `detalle_orden`.`id_orden`) WHERE YEAR(ordenes.`FECHA_INGRESO`)='" & filtro & "'")
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
        Public Function OrdenesFacturarMartinez(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID`, `ordenes`.`FECHA_INGRESO` AS FECHA ,  " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION` " _
                                                  & ",  CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `NOMBRE` " _
                                                  & ", `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO, `historia_diagnosticos`.`ID_DIAGNOSTICO` AS DIAGNOSTICO, " _
                                                  & "`contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `ordenes`.`NUMERO_ORDEN` AS ORDEN " _
                                                  & ", `ordenes`.`AUTORIZACION` AS AUTORIZACION , `detalle_orden`.`CODIGO_PROCEDIMIENTO` AS CODIGO   , `detalle_orden`.`VALOR` " _
                                                  & ", `detalle_orden`.`COPAGO`, (`detalle_orden`.`VALOR`-`detalle_orden`.`COPAGO`) AS NETO ,sedes.`NOMBRE` AS SEDE " _
                                                  & "FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) INNER JOIN `usuarios` " _
                                                  & "ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)  INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `historia_diagnosticos` " _
                                                  & " ON (`ordenes`.`ID` = `historia_diagnosticos`.`ID_ORDEN`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `sedes` ON (`ordenes`.`ID_SEDE` = `sedes`.`ID`) INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & " WHERE ordenes.`ESTADO`='ATENDIDO' AND ordenes.`ID_FACTURA`='" & filtro & "'  GROUP  BY ordenes.`ID`")
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
        Public Sub CancelarOrdenMartinez(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE detalle_orden INNER JOIN `ordenes` ON " _
                      & "(`detalle_orden`.`ID_ORDEN`=`ordenes`.`ID`) " _
                      & "SET ordenes.`ESTADO`='CANCELADO', detalle_orden.`ESTADO`='CANCELADO' " _
                      & "WHERE (`ordenes`.`ID` ='" & filtro & "');"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function OrdenesFacturarIntegra(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID`, `ordenes`.`FECHA_INGRESO` AS FECHA ,  " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION` " _
                                                  & ",  CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `NOMBRE` " _
                                                  & ", `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO, `historia_diagnosticos`.`ID_DIAGNOSTICO` AS DIAGNOSTICO, " _
                                                  & "`contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `ordenes`.`NUMERO_ORDEN` AS ORDEN " _
                                                  & ", `ordenes`.`AUTORIZACION` AS AUTORIZACION , `detalle_orden`.`CODIGO_PROCEDIMIENTO` AS CODIGO   , `detalle_orden`.`VALOR` " _
                                                  & ", `detalle_orden`.`COPAGO`, (`detalle_orden`.`VALOR`-`detalle_orden`.`COPAGO`) AS NETO ,sedes.`NOMBRE` AS SEDE " _
                                                  & "FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) INNER JOIN `usuarios` " _
                                                  & "ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)  INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `historia_diagnosticos` " _
                                                  & " ON (`ordenes`.`ID` = `historia_diagnosticos`.`ID_ORDEN`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `sedes` ON (`ordenes`.`ID_SEDE` = `sedes`.`ID`) INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & " WHERE ordenes.`ESTADO`='ATENDIDO' AND ordenes.`ID_FACTURA`='" & filtro & "'  GROUP  BY ordenes.`ID`")
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
        Public Function OrdenesAtendidas() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, ordenes.FECHA_INGRESO, CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                    & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS PACIENTE " _
                                    & ", contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD , ordenes.FECHA_ORDEN, ordenes.NUMERO_ORDEN, ordenes.AUTORIZACION " _
                                    & "FROM ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) INNER JOIN contratos ON (ordenes.ID_CONTRATO = contratos.ID) " _
                                    & "INNER JOIN entidades ON (contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) WHERE (ordenes.ESTADO ='ATENDIDO') AND (ordenes.ID_FACTURA ='0')")
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
        Public Function OrdenesAFacturar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, ordenes.FECHA_INGRESO, CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                    & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS PACIENTE " _
                                    & ", contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD , ordenes.FECHA_ORDEN, ordenes.NUMERO_ORDEN, ordenes.AUTORIZACION " _
                                    & "FROM ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) INNER JOIN contratos ON (ordenes.ID_CONTRATO = contratos.ID) " _
                                    & "INNER JOIN entidades ON (contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) WHERE (ordenes.ESTADO ='ATENDIDO') AND (ordenes.ID_FACTURA ='1')")
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

        Function TablaOrdenesAtendidas() As DataTable
            Try
                'CONSULTA 2
                Dim query2 As String =
                                    String.Format("SELECT `detalle_orden`.`ID` AS IDDETALLEORDEN , `detalle_orden`.`ID_ORDEN` AS ID, `ordenes`.`FECHA_INGRESO` " _
                                                  & ", CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE` " _
                                                  & ",usuarios.`SEXO` ,TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD , `contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD " _
                                                  & ", `ordenes`.`FECHA_ORDEN`, `ordenes`.`NUMERO_ORDEN`, `ordenes`.`AUTORIZACION` , `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO`  AS ESTUDIO , `detalle_orden`.`CODIGO_CUPS` as CODIGO_PROCEDIMIENTO" _
                                                  & ", `cups`.`NOMBRE_CUPS` as CUPS, `contratos`.`NOMBRE` AS CONTRATO , `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `detalle_orden`.`VALOR`, `detalle_orden`.`COPAGO` " _
                                                  & ",(`detalle_orden`.`VALOR`- `detalle_orden`.`COPAGO`) AS NETO ,licencias.`CLIENTE` AS EMPRESA FROM `detalle_orden`" _
                                                  & "INNER JOIN `ordenes`  ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) WHERE ordenes.`ID_FACTURA`='0' ")

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query2, _conn)
                Dim lector = comando.ExecuteReader()
                Dim _dt2 = New DataTable
                _dt2.Load(CType(lector, IDataReader))
                ConexionODBC.Close(_conn)

                Return _dt2
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Function TablaOrdenesFacturar() As DataTable
            Try
                'CONSULTA 2
                Dim query2 As String =
                                    String.Format("SELECT ordenes.ID, ordenes.FECHA_INGRESO, CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                    & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE` " _
                                    & ", `contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `ordenes`.`FECHA_ORDEN`, `ordenes`.`NUMERO_ORDEN`, `ordenes`.`AUTORIZACION` " _
                                    & ", `detalle_orden`.`CODIGO_PROCEDIMIENTO` , `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO`  AS ESTUDIO, `cups`.`NOMBRE_CUPS` AS CUPS    , SUM(`detalle_orden`.`VALOR`) AS VALOR " _
                                    & ", SUM(`detalle_orden`.`COPAGO`) AS COPAGO,(SUM(`detalle_orden`.`VALOR`)-SUM(`detalle_orden`.`COPAGO`)) AS NETO ,licencias.`CLIENTE` AS EMPRESA FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                    & " INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                    & " INNER JOIN `detalle_tarifa` ON (`detalle_orden`.`CODIGO_PROCEDIMIENTO` = `detalle_tarifa`.`CODIGO_PROCEDIMIENTO`) INNER JOIN `tipo_estudio` " _
                                    & "ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) AND (`contratos`.`ID_TARIFA` = `detalle_tarifa`.`ID_TARIFA`) INNER JOIN `cups` " _
                                    & "ON (`detalle_tarifa`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`)  WHERE (ordenes.`ID_FACTURA`='1' AND ordenes.`ESTADO`='ATENDIDO') GROUP BY ordenes.id")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query2, _conn)
                Dim lector = comando.ExecuteReader()
                Dim _dt2 = New DataTable
                _dt2.Load(CType(lector, IDataReader))
                ConexionODBC.Close(_conn)

                Return _dt2
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Public Function PacientesHistoriaEndoscopia(ByVal IdEspecialista As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("select detalle_orden.ID_ORDEN AS ORDEN, ordenes.FECHA_INGRESO AS FECHA_INGRESO, " _
                                                  & "concat(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "concat(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) " _
                                                  & "AS NOMBRE, tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_orden.id as ID, ordenes.`ID_USUARIO` AS ID_USUARIO from (((((((detalle_orden join ordenes on " _
                                                  & "((detalle_orden.ID_ORDEN = ordenes.ID))) join tipo_estudio on ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "join usuarios on ((ordenes.ID_USUARIO = usuarios.ID))) join contratos on ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "join empleados on ((ordenes.ID_EMPLEADO = empleados.ID))) join entidades on " _
                                                  & "((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) join licencias on " _
                                                  & "((contratos.ID_LICENCIA = licencias.ID))) where ((detalle_orden.id_tipo_estudio in (8,9,13)) and " _
                                                  & "detalle_orden.estado='PENDIENTE') and ordenes.ID_EMPLEADO='" & IdEspecialista & "'")
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
        Public Function PacientesEstudioEndoscopia(ByVal IdEspecialista As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN " _
                                                  & ", ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO " _
                                                  & ",cups.`NOMBRE_CUPS` AS CUPS " _
                                                  & ", detalle_orden.id AS ID " _
                                                  & ", tipo_estudio.prefijo AS PREFIJO, detalle_orden.ID_TIPO_ESTUDIO as TIPOESTUDIO, ordenes.id_usuario as ID_USUARIO  " _
                                                  & "FROM ((((((((detalle_orden " _
                                                  & "JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.id_tipo_estudio in (10,11,12)) AND detalle_orden.estado='PENDIENTE') AND ordenes.ID_EMPLEADO='" & IdEspecialista & "'")
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
        Public Function PacientesOrtodoncia() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN 	, ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO ,cups.`NOMBRE_CUPS` AS CUPS , detalle_orden.id AS ID " _
                                                  & ", tipo_estudio.prefijo AS PREFIJO, detalle_orden.ID_TIPO_ESTUDIO AS TIPOESTUDIO, ordenes.id_usuario AS ID_USUARIO  " _
                                                  & "FROM ((((((((detalle_orden JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.id_tipo_estudio IN (16)) And ordenes.estado='PENDIENTE')")
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
        Public Function PacientesEstudiosEspeciales(ByVal IdEspecialista As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN, " _
                                                  & "ordenes.FECHA_INGRESO AS FECHA_INGRESO, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, " _
                                                  & "cups.`NOMBRE_CUPS` AS CUPS, " _
                                                  & "detalle_orden.id AS ID, " _
                                                  & "tipo_estudio.prefijo AS PREFIJO, " _
                                                  & "detalle_orden.ID_TIPO_ESTUDIO AS TIPOESTUDIO " _
                                                  & "FROM ((((((((detalle_orden " _
                                                  & "JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.ID_TIPO_ESTUDIO='15') And detalle_orden.estado='PENDIENTE') AND ordenes.ID_EMPLEADO='" & IdEspecialista & "'")
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
        Public Function PacientesImagenesEndoscopia() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN " _
                                                  & ", ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO " _
                                                  & ",cups.`NOMBRE_CUPS` AS CUPS " _
                                                  & ",empleados.`NOMBRE_EMPLEADO` AS ESPECIALISTA " _
                                                  & ", detalle_orden.id AS ID " _
                                                  & ", tipo_estudio.prefijo AS PREFIJO, detalle_orden.ID_TIPO_ESTUDIO as TIPOESTUDIO, ordenes.ID_USUARIO  " _
                                                  & "FROM ((((((((detalle_orden " _
                                                  & "JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.id_tipo_estudio in (10,11,12,15,16)) AND detalle_orden.estado='PENDIENTE')")
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
        Public Function PacientesRegistroAnestesia() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN " _
                                                  & ", ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO " _
                                                  & ",cups.`NOMBRE_CUPS` AS CUPS " _
                                                  & ",empleados.`NOMBRE_EMPLEADO` AS ESPECIALISTA " _
                                                  & ", detalle_orden.id AS ID " _
                                                  & ", tipo_estudio.prefijo AS PREFIJO, " _
                                                  & "detalle_orden.ID_TIPO_ESTUDIO as TIPOESTUDIO, " _
                                                  & "ordenes.ID_USUARIO, ordenes.id_empleado AS IDESPECIALISTA " _
                                                  & "FROM ((((((((detalle_orden " _
                                                  & "JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.id_tipo_estudio in (10,11,12,15,16)) And detalle_orden.estado<>'CANCELADO' AND ordenes.fecha_ingreso=CURDATE())")
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
        Public Function OrdenesEndoscopia() As DataSet
            Try
                Dim query As String =
                                    String.Format("Select detalle_orden.ID As ID, detalle_orden.ID_ORDEN As ORDEN,  ordenes.FECHA_INGRESO As FECHA_INGRESO " _
                                    & ",  CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) As IDENTIFICACION " _
                                    & ",  CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                    & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD " _
                                    & ",  usuarios.TELEFONO AS TELEFONO,  empleados.NOMBRE_EMPLEADO AS ESPECIALISTA,  contratos.NOMBRE AS CONTRATO " _
                                    & ", entidades.NOMBRE_ENTIDAD AS ENTIDAD,  tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, cups.`NOMBRE_CUPS` AS CUPS,  licencias.CLIENTE AS EMPRESA " _
                                    & ", detalle_orden.ESTADO AS ESTADO FROM ((((((((detalle_orden  JOIN ordenes  ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                    & "JOIN tipo_estudio  ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                    & "JOIN cups  ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`)))  " _
                                    & "JOIN usuarios  ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                    & "JOIN contratos  ON ((ordenes.ID_CONTRATO = contratos.ID)))  " _
                                    & "JOIN empleados  ON ((ordenes.ID_EMPLEADO = empleados.ID)))  " _
                                    & "JOIN entidades  ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD)))  " _
                                    & "JOIN licencias  ON ((contratos.ID_LICENCIA = licencias.ID)))")
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
        Public Function OrdenesEndoscopiaFecha(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("Select detalle_orden.ID As ID, detalle_orden.ID_ORDEN As ORDEN,  ordenes.FECHA_INGRESO As FECHA_INGRESO " _
                                    & ",  CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) As IDENTIFICACION " _
                                    & ",  CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                    & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD " _
                                    & ",  usuarios.TELEFONO AS TELEFONO,  empleados.NOMBRE_EMPLEADO AS ESPECIALISTA, ordenes.COMENTARIOS, contratos.NOMBRE AS CONTRATO " _
                                    & ", entidades.NOMBRE_ENTIDAD AS ENTIDAD,  tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, cups.`NOMBRE_CUPS` AS CUPS,  licencias.CLIENTE AS EMPRESA " _
                                    & ", detalle_orden.ESTADO AS ESTADO FROM ((((((((detalle_orden  JOIN ordenes  ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                    & "JOIN tipo_estudio  ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                    & "JOIN cups  ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`)))  " _
                                    & "JOIN usuarios  ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                    & "JOIN contratos  ON ((ordenes.ID_CONTRATO = contratos.ID)))  " _
                                    & "JOIN empleados  ON ((ordenes.ID_EMPLEADO = empleados.ID)))  " _
                                    & "JOIN entidades  ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD)))  " _
                                    & "JOIN licencias  ON ((contratos.ID_LICENCIA = licencias.ID))) WHERE YEAR(ordenes.`FECHA_INGRESO`)='" & filtro & "' ORDER BY detalle_orden.id DESC")
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
        Public Function OrdenesxAnoAtendidos(ByVal Ano As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("Select detalle_orden.ID As ID, ordenes.CONSECUTIVO, detalle_orden.ID_ORDEN As ORDEN,  ordenes.FECHA_INGRESO As FECHA_INGRESO " _
                                    & ",  CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) As IDENTIFICACION " _
                                    & ",  CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                    & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD " _
                                    & ",  usuarios.TELEFONO AS TELEFONO,  empleados.NOMBRE_EMPLEADO AS ESPECIALISTA,  contratos.NOMBRE AS CONTRATO " _
                                    & ", entidades.NOMBRE_ENTIDAD AS ENTIDAD,  tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, cups.`NOMBRE_CUPS` AS CUPS,  licencias.CLIENTE AS EMPRESA " _
                                    & ", detalle_orden.ESTADO AS ESTADO, usuarios.id AS IDUSUARIO FROM ((((((((detalle_orden  JOIN ordenes  ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                    & "JOIN tipo_estudio  ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                    & "JOIN cups  ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`)))  " _
                                    & "JOIN usuarios  ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                    & "JOIN contratos  ON ((ordenes.ID_CONTRATO = contratos.ID)))  " _
                                    & "JOIN empleados  ON ((ordenes.ID_EMPLEADO = empleados.ID)))  " _
                                    & "JOIN entidades  ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD)))  " _
                                    & "JOIN licencias  ON ((contratos.ID_LICENCIA = licencias.ID))) WHERE YEAR(ordenes.`FECHA_INGRESO`)='" & Ano & "' and detalle_orden.estado='ATENDIDO' ORDER BY detalle_orden.id DESC")
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
        Public Function ExisteConsecutivo(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE consecutivo='" & filtro & "'")
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
        Public Function ListarCitoPato() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.consecutivo AS CONSECUTIVO, ordenes.ID AS ORDEN, ordenes.FECHA_INGRESO AS FECHA_INGRESO, " _
                                    & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                    & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                                    & "usuarios.SEXO AS SEXO, TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, usuarios.TELEFONO AS TELEFONOS, " _
                                    & "contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD, tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, " _
                                    & "licencias.CLIENTE AS EMPRESA, ordenes.ESTADO AS ESTADO FROM " _
                                    & "(((((ordenes JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID)))  JOIN contratos ON " _
                                    & "((ordenes.ID_CONTRATO = contratos.ID))) JOIN tipo_estudio ON ((ordenes.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                    & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD)))  JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID)))")
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
        Public Function ListarCitologias() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT  `ordenes`.`ID` AS `ID`,  `ordenes`.`consecutivo` AS `CONSECUTIVO` " _
                                    & ",  `ordenes`.`FECHA_INGRESO` AS `FECHA`,  CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION` " _
                                    & ",  CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `USUARIO` " _
                                    & ",  `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, usuarios.id as ID_USUARIO FROM ((`ordenes`  JOIN `usuarios`  ON ((`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)))  " _
                                    & "	JOIN `tipo_estudio`  ON ((`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`))) " _
                                    & " JOIN `detalle_orden` ON( `ordenes`.`id`= `detalle_orden`.`id_orden`) " _
                                    & "	WHERE (((`tipo_estudio`.`PREFIJO` = _utf8'CV')  OR (`tipo_estudio`.`PREFIJO` = _utf8'CB') OR (`tipo_estudio`.`PREFIJO` = _utf8'CR'))  AND (`ordenes`.`ESTADO` <> _utf8'ATENDIDO')  AND (`ordenes`.`ESTADO` <> _utf8'CANCELADO') AND (`ordenes`.`ESTADO` <> _utf8'FACTURADO')) AND `detalle_orden`.`codigo_cups` ='898001'")
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

        Public Function ListarEstudiosAnteriores(ByVal Filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT  `ordenes`.`ID` AS `ID`,  `ordenes`.`CONSECUTIVO` AS `CONSECUTIVO`,  `ordenes`.`FECHA_INGRESO` AS `FECHA`	" _
                                    & ",  `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO` FROM ((`ordenes`  JOIN `usuarios`  ON ((`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)))  " _
                                    & "	JOIN `tipo_estudio`  ON ((`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`))) 	WHERE (`ordenes`.`ESTADO` = _utf8'ATENDIDO' ) AND ordenes.`ID_USUARIO`='" & Filtro & "'")
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
        Public Function ListarPacientesMartinez() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS ORDEN, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS PACIENTE, " _
                                                  & "`contratos`.`NOMBRE` AS CONTRATO, " _
                                                  & "`ordenes`.`ESTADO` AS ESTADO, " _
                                                  & "`detalle_orden`.`ID` " _
                                                  & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                                  & "WHERE (`ordenes`.`ESTADO` <>'CANCELADO' And `ordenes`.`FECHA_INGRESO` =CURDATE())")
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
        Public Function ListarEstudiosAnterioresEndoscopias(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT detalle_orden.id as ID, detalle_orden.ID_ORDEN as ORDEN, ordenes.FECHA_INGRESO as FECHA, " _
                                              & "tipo_estudio.NOMBRE_TIPO_ESTUDIO as ESTUDIO FROM detalle_orden " _
                                              & "INNER JOIN ordenes ON (detalle_orden.ID_ORDEN = ordenes.ID) " _
                                              & "INNER JOIN tipo_estudio ON (detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                              & "WHERE (detalle_orden.ESTADO ='ATENDIDO' And ordenes.ID_USUARIO ='" & filtro & "') ORDER BY ordenes.FECHA_INGRESO ASC")
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
        Public Function ListarHistoriasAnterioresOrtodoncia(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT `detalle_orden`.`ID`, `detalle_orden`.`ID_ORDEN` as ORDEN, `ortodoncia`.`FECHA`, CONCAT(`ortodoncia`.`MOTIVO_CONSULTA`,`ortodoncia`.`ACTIVIDAD_REALIZADA`) AS ESTUDIO " _
                                & "FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                & "INNER JOIN `ortodoncia` ON (`detalle_orden`.`ID_ORDEN` = `ortodoncia`.`ID_ORDEN`) " _
                                & "WHERE (detalle_orden.ESTADO ='ATENDIDO' AND ordenes.ID_USUARIO ='" & filtro & "') ORDER BY ordenes.FECHA_INGRESO ASC")
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
#Region "INTEGRA"
        Public Function ListarIntegra() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, " _
                                                  & "`ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS USUARIO, " _
                                                  & "`usuarios`.`SEXO`, TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, " _
                                                  & "`usuarios`.`TELEFONO`, `ordenes`.`NUMERO_ORDEN`, `ordenes`.`AUTORIZACION`, " _
                                                  & "`ordenes`.`CODIGO_DIAGNOSTICO` AS DIAGNOSTICO, `contratos`.`NOMBRE` AS CONTRATO, " _
                                                  & "`entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD, `ordenes`.`ESTADO` FROM `ordenes` " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`)")
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

        Public Function ListarPacientesIntegra() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS ORDEN, `ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS USUARIO, " _
                                                  & "`usuarios`.`SEXO`, `contratos`.`NOMBRE` AS CONTRATO , `ordenes`.`ESTADO`, `ordenes`.`ID_CONTRATO` " _
                                                  & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "WHERE ordenes.`ID_FACTURA` = '0' AND ordenes.`ESTADO`<>'CANCELADA'")
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
        Public Function ExisteOrdenIntegraSinFacturar(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ordenes`.`ID` FROM `ordenes` INNER JOIN `usuarios` " _
                                      & "ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) WHERE " _
                                      & "(`ordenes`.`ID_FACTURA` ='0' And `ordenes`.`ESTADO` ='PENDIENTE' " _
                                      & "And `ordenes`.`ID_USUARIO` ='" & filtro & "');")
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
        Public Function ListarUltimaOrden(ByVal filtro As String) As DataSet
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
        Public Shared Function CargarIDUsuario(ByVal IdOrden As String) As String
            Try
                Dim query As String = String.Format("SELECT id_usuario FROM ordenes WHERE id='" & IdOrden & "'")
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
        Public Sub GuardarOrdenIntegra(ByVal _Ordenes As Ordenes, ByVal CodigoDiagnostico As String, ByVal IdTipoConsulta As String)
            Try
                Dim query As String
                If Existe(_Ordenes.Id) = True Then
                    query = "UPDATE ordenes SET numero_orden='" & _Ordenes.NumeroOrden & "', " _
                           & "fecha_orden='" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "', id_empleado='" & _Ordenes.IdEmpleado & "',autorizacion='" & _Ordenes.Autorizacion & "', " _
                           & "id_tipo_afiliado='" & _Ordenes.IdTipoAfiliado & "', id_tipo_usuario='" & _Ordenes.IdTipoUsuario & "' " _
                           & "where id='" & _Ordenes.Id & "'"
                Else
                    query = "insert into ordenes values('" & _Ordenes.Id & "','" & _Ordenes.IdUsuario & "','" & _Ordenes.IdContrato & "', '" & _Ordenes.IdSubEntidad & "', " _
                            & "'" & _Ordenes.IdIngreso & "','" & _Ordenes.IdSede & "','" & Val(_Ordenes.IdEmpleado) & "','" & _Ordenes.Autorizacion & "', " _
                            & "'" & _Ordenes.NumeroOrden & "', '" & Format(_Ordenes.FechaIngreso, "yyyy/MM/dd") & "', '" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "', " _
                            & "'" & Format(_Ordenes.Hora, "hh:mm:ss") & "', '" & _Ordenes.Idfactura & "','" & _Ordenes.IdTipoAfiliado & "','" & _Ordenes.IdTipoUsuario & "', " _
                            & "'" & _Ordenes.IdTipoEstudio & "','" & _Ordenes.Comentarios & "','" & _Ordenes.Estado & "', '" & _Ordenes.Consecutivo & "','" & CodigoDiagnostico & "','" & IdTipoConsulta & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
#End Region
#Region "GASTROLAP"
        Function ListadoOrdenesEndoscopia() As DataTable
            Try
                'CONSULTA 2
                Dim query2 As String =
                                    String.Format("SELECT `ordenes`.`ID`, `ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE`" _
                                                  & ", `contratos`.`NOMBRE` AS CONTRATO , `subentidades`.`nombre` AS SUBENTIDAD  , `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD   , `ordenes`.`FECHA_ORDEN`  , `ordenes`.`NUMERO_ORDEN` " _
                                                  & ", `ordenes`.`AUTORIZACION`, `detalle_orden`.`CODIGO_CUPS` , `cups`.`NOMBRE_CUPS` , `detalle_orden`.`VALOR`, `detalle_orden`.`COPAGO`" _
                                                  & ",( `detalle_orden`.`VALOR`- `detalle_orden`.`COPAGO`) AS NETO FROM `ordenes`  INNER JOIN `detalle_orden` " _
                                                  & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`)   INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & " INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`)" _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`)" _
                                                  & "INNER JOIN `subentidades` ON (`ordenes`.`ID_SUBENTIDAD` = `subentidades`.`id`)" _
                                                  & "WHERE ordenes.`ID_FACTURA`='0' AND detalle_orden.`ESTADO`<>'CANCELADO'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query2, _conn)
                Dim lector = comando.ExecuteReader()
                Dim _dt2 = New DataTable
                _dt2.Load(CType(lector, IDataReader))
                ConexionODBC.Close(_conn)

                Return _dt2
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Function OrdenesFacturarEndoscopia() As DataTable
            Try
                'CONSULTA 2
                Dim query2 As String =
                                    String.Format("SELECT `ordenes`.`ID`, `ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE`" _
                                                  & ", `contratos`.`NOMBRE` AS CONTRATO   , `subentidades`.`nombre` AS SUBENTIDAD  , `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD   , `ordenes`.`FECHA_ORDEN`  , `ordenes`.`NUMERO_ORDEN` " _
                                                  & ", `ordenes`.`AUTORIZACION`, `detalle_orden`.`CODIGO_CUPS` , `cups`.`NOMBRE_CUPS` , `detalle_orden`.`VALOR`, `detalle_orden`.`COPAGO`" _
                                                  & ",( `detalle_orden`.`VALOR`- `detalle_orden`.`COPAGO`) AS NETO FROM `ordenes`  INNER JOIN `detalle_orden` " _
                                                  & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`)   INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & " INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`)" _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`)" _
                                                  & "INNER JOIN `subentidades` ON (`ordenes`.`ID_SUBENTIDAD` = `subentidades`.`id`)" _
                                                  & "WHERE ordenes.`ID_FACTURA`='1' AND detalle_orden.`ESTADO`<>'CANCELADO'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query2, _conn)
                Dim lector = comando.ExecuteReader()
                Dim _dt2 = New DataTable
                _dt2.Load(CType(lector, IDataReader))
                ConexionODBC.Close(_conn)

                Return _dt2
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Public Sub ActualizarCamposOrdenes(ByVal Fecha As Date, ByVal NumeroOrden As String, ByVal Autorizacion As String, ByVal IdSubentidad As String, ByVal Filtro As String, ByVal idContrato As String)
            Try
                Dim query As String

                query = "UPDATE ordenes SET fecha_orden='" & Format(Fecha, "yyyy/MM/dd") & "', " _
                    & "numero_orden='" & NumeroOrden & "', autorizacion='" & Autorizacion & "', id_subentidad='" & IdSubentidad & "', id_contrato='" & idContrato & "' where id='" & Filtro & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarValoryCopago(ByVal IdDetalleOrden As String, ByVal Valor As String, ByVal Copago As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden SET valor='" & Valor & "', " _
                        & "copago='" & Copago & "' where id='" & IdDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarOrdenes2() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS `ORDEN`, ordenes.CONSECUTIVO, " _
                                            & "`ordenes`.`FECHA_INGRESO`, " _
                                            & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                            & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                                            & "`usuarios`.`SEXO`, " _
                                            & "TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, " _
                                            & "`empleados`.`NOMBRE_EMPLEADO` AS `ESPECIALISTA`, `contratos`.`NOMBRE` AS `CONTRATO`, " _
                                            & "`entidades`.`NOMBRE_ENTIDAD` AS `ENTIDAD`, `licencias`.`CLIENTE` AS `EMPRESA`, " _
                                            & "`ordenes`.`ESTADO`, ordenes.ID_USUARIO AS IDUSUARIO, ordenes.autorizacion as AUTORIZACION, ordenes.numero_orden as NUMERO_ORDEN   FROM `ordenes` " _
                                            & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                            & "INNER JOIN `empleados` ON (`ordenes`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                            & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                            & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                            & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) where ordenes.estado='PENDIENTE'")
                _conn = ConexionODBC.Open()
                'If _conn.State.ToString = "Open" Then
                ' _conn.Close()
                ' End If
                'MsgBox(_conn.State.ToString)
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
        Public Function ListarTomaMuestra() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS `ORDEN`,ordenes.`CONSECUTIVO`, `ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION " _
                                                  & ", CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE	" _
                                                  & ", TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD	, `contratos`.`NOMBRE` AS `CONTRATO` " _
                                                  & ", `entidades`.`NOMBRE_ENTIDAD` AS `ENTIDAD`, ordenes.ID_USUARIO AS IDUSUARIO FROM `ordenes` " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `empleados` ON (`ordenes`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) " _
                                                  & "WHERE (ordenes.`ESTADO`='PENDIENTE' AND usuarios.`SEXO`='F') AND (ordenes.`ID_TIPO_ESTUDIO`='1'OR ordenes.`ID_TIPO_ESTUDIO`='2')")
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
#End Region
        Public Sub GuardarConsecutivo(ByVal IdOrden As String, ByVal Consecutivo As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET consecutivo='" & Consecutivo & "' WHERE id='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
#Region "CITOPATO"
        Public Function OrdenesCITOPATO(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.`ID` AS ORDEN	,ordenes.`CONSECUTIVO` ,ordenes.FECHA_INGRESO AS FECHA_INGRESO,  " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION,  " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD 	,  usuarios.TELEFONO AS TELEFONO " _
                                                  & ",usuarios.`CORREO_ELECTRONICO`,  contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD,  " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO ,ordenes.`COMENTARIOS`	,ordenes.`ESTADO`, especimenes.nombre AS ESPECIMEN  FROM `ordenes`" _
                                                  & "INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) INNER JOIN `usuarios` " _
                                                  & "ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `especimenes` ON (`ordenes`.`id_especimen`=`especimenes`.`id`) WHERE  YEAR(ordenes.`FECHA_INGRESO`)='" & filtro & "' ORDER BY ordenes.id DESC")
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
        Public Function OrdenesCDPatologia() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.`ID` AS ORDEN	,ordenes.`CONSECUTIVO` ,ordenes.FECHA_INGRESO AS FECHA_INGRESO, " _
                                                  & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD 	,  usuarios.TELEFONO AS TELEFONO " _
                                                  & ",usuarios.`CORREO_ELECTRONICO`	,  contratos.NOMBRE AS CONTRATO	, entidades.NOMBRE_ENTIDAD AS ENTIDAD, tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO " _
                                                  & ",ordenes.`COMENTARIOS`	,ordenes.`ESTADO` ,especimenes.nombre as ESPECIMEN,`sedes`.`nombre` as SEDE	,`subentidades`.nombre as SUBENTIDAD " _
                                                  & "FROM `ordenes`	INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "inner join `especimenes` on (`especimenes`.`id`=`ordenes`.`id_especimen`)	inner join `sedes` on (`sedes`.`id`=`ordenes`.`id_sede`)" _
                                                  & "inner join `subentidades` on(`subentidades`.`id`=`ordenes`.`id_subentidad`)")
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
        Public Function ListarPatologias() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ID, ordenes.consecutivo AS CONSECUTIVO ,ordenes.FECHA_INGRESO AS FECHA " _
                                    & ", CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                                    & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) " _
                                    & "AS USUARIO, tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, usuarios.id AS ID_USUARIO, especimenes.`NOMBRE` AS ESPECIMEN " _
                                    & "FROM (((ordenes JOIN usuarios  ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                    & "JOIN tipo_estudio ON ((ordenes.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                    & "JOIN especimenes ON ((ordenes.`ID_ESPECIMEN` = especimenes.`ID`))) " _
                                    & "WHERE ((tipo_estudio.PREFIJO <> 'CV') AND (tipo_estudio.PREFIJO <> 'CB')  AND (ordenes.ESTADO <> 'ATENDIDO') " _
                                    & "And (ordenes.ESTADO <> 'CANCELADO') And (ordenes.ESTADO <> 'FACTURADO'))")
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
#End Region
#Region "FACTURACION"
        Public Function AuditoriaOrdenes() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS ORDEN,ordenes.`CONSECUTIVO`	 , `ordenes`.`FECHA_INGRESO` " _
                                                  & ", CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE` " _
                                                  & " ,usuarios.`SEXO`  ,TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD  , `tipo_usuario`.`nombre_tipo_usuario` AS TIPO_USUARIO, `contratos`.`NOMBRE` AS CONTRATO " _
                                                  & " , `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `ordenes`.`FECHA_ORDEN`, `ordenes`.`AUTORIZACION` " _
                                                  & ", `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO`  AS ESTUDIO  , `detalle_orden`.`CODIGO_CUPS` AS CODIGO_PROCEDIMIENTO " _
                                                  & ", `cups`.`NOMBRE_CUPS` AS CUPS	  , `detalle_orden`.`VALOR` , `detalle_orden`.`COPAGO` " _
                                                  & ",(`detalle_orden`.`VALOR`- `detalle_orden`.`COPAGO`) AS NETO  FROM `detalle_orden`" _
                                                  & "INNER JOIN `ordenes`  ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) " _
                                                  & "INNER JOIN `tipo_usuario` ON (`ordenes`.`id_tipo_usuario`=`tipo_usuario`.`id`) " _
                                                  & "WHERE ordenes.`ID_FACTURA`='P' and detalle_orden.estado<>'CANCELADO'")
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
        Public Function OrdenesAuditadas() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS ORDEN,ordenes.`CONSECUTIVO`	 , `ordenes`.`FECHA_INGRESO` " _
                                                  & ", CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE` " _
                                                  & " ,usuarios.`SEXO`  ,TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD  , `tipo_usuario`.`nombre_tipo_usuario` AS TIPO_USUARIO, `contratos`.`NOMBRE` AS CONTRATO " _
                                                  & " , `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD , `ordenes`.`FECHA_ORDEN`, `ordenes`.`AUTORIZACION` " _
                                                  & ", `tipo_estudio`.`NOMBRE_TIPO_ESTUDIO`  AS ESTUDIO  , `detalle_orden`.`CODIGO_CUPS` AS CODIGO_PROCEDIMIENTO " _
                                                  & ", `cups`.`NOMBRE_CUPS` AS CUPS	  , `detalle_orden`.`VALOR` , `detalle_orden`.`COPAGO` " _
                                                  & ",(`detalle_orden`.`VALOR`- `detalle_orden`.`COPAGO`) AS NETO  FROM `detalle_orden`" _
                                                  & "INNER JOIN `ordenes`  ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) " _
                                                  & "INNER JOIN `tipo_usuario` ON (`ordenes`.`id_tipo_usuario`=`tipo_usuario`.`id`) " _
                                                  & "WHERE ordenes.`ID_FACTURA`='A' and detalle_orden.estado<>'CANCELADO'")
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
        Public Function OrdenesAuditadasContrato(ByVal IdContrato As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.`ID` AS ID, " _
                                                  & "detalle_orden.`ID_ORDEN` AS ORDEN, " _
                                                  & "ordenes.`CONSECUTIVO`, " _
                                                  & "ordenes.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE_USUARIO, " _
                                                  & "`tipo_usuario`.`nombre_tipo_usuario` AS TIPO_USUARIO, " _
                                                  & "tipo_estudio.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO, " _
                                                  & "especimenes.`NOMBRE` AS ESPECIMEN, " _
                                                  & "subentidades.`nombre` AS SUBENTIDAD, " _
                                                  & "SUM(detalle_orden.`VALOR`) AS VALOR, " _
                                                  & "SUM(detalle_orden.`COPAGO`) AS COPAGO, " _
                                                  & "SUM(detalle_orden.`VALOR`-detalle_orden.`COPAGO`) AS NETO FROM " _
                                                  & "detalle_orden INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                                                  & "INNER JOIN usuarios ON (ordenes.`ID_USUARIO`=usuarios.`ID`) " _
                                                  & "INNER JOIN tipo_estudio ON (detalle_orden.`ID_TIPO_ESTUDIO`=tipo_estudio.`ID`) " _
                                                  & "INNER JOIN especimenes ON (ordenes.`ID_ESPECIMEN`=especimenes.`ID`) " _
                                                  & "INNER JOIN subentidades ON (ordenes.`ID_SUBENTIDAD`=subentidades.`id`) " _
                                                  & "INNER JOIN `tipo_usuario` ON (`ordenes`.`id_tipo_usuario`=`tipo_usuario`.`id`) " _
                                                  & "WHERE detalle_orden.`ESTADO`<>'CANCELADO' AND ordenes.`ID_FACTURA`='A' AND ordenes.`ID_CONTRATO`='" & IdContrato & "' GROUP BY ordenes.`ID`")
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
        Public Function OrdenesFacturarContrato(ByVal IdContrato As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.`ID` AS ID, " _
                                                  & "detalle_orden.`ID_ORDEN` AS ORDEN, " _
                                                  & "ordenes.`CONSECUTIVO`, " _
                                                  & "ordenes.`FECHA_INGRESO`, " _
                                                  & "CONCAT(usuarios.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                                  & "CONCAT(usuarios.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE_USUARIO, " _
                                                  & "`tipo_usuario`.`nombre_tipo_usuario` AS TIPO_USUARIO, " _
                                                  & "tipo_estudio.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO, " _
                                                  & "especimenes.`NOMBRE` AS ESPECIMEN, " _
                                                  & "subentidades.`nombre` AS SUBENTIDAD, " _
                                                  & "SUM(detalle_orden.`VALOR`) AS VALOR, " _
                                                  & "SUM(detalle_orden.`COPAGO`) AS COPAGO, " _
                                                  & "SUM(detalle_orden.`VALOR`-detalle_orden.`COPAGO`) AS NETO FROM " _
                                                  & "detalle_orden INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                                                  & "INNER JOIN usuarios ON (ordenes.`ID_USUARIO`=usuarios.`ID`) " _
                                                  & "INNER JOIN tipo_estudio ON (detalle_orden.`ID_TIPO_ESTUDIO`=tipo_estudio.`ID`) " _
                                                  & "INNER JOIN especimenes ON (ordenes.`ID_ESPECIMEN`=especimenes.`ID`) " _
                                                  & "INNER JOIN subentidades ON (ordenes.`ID_SUBENTIDAD`=subentidades.`id`) " _
                                                  & "INNER JOIN `tipo_usuario` ON (`ordenes`.`id_tipo_usuario`=`tipo_usuario`.`id`) " _
                                                  & "WHERE detalle_orden.`ESTADO`<>'CANCELADO' AND ordenes.`ID_FACTURA`='F' AND ordenes.`ID_CONTRATO`='" & IdContrato & "' GROUP BY ordenes.`ID`")
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
        Public Sub LiberarOrdenes(ByVal IdFactura As String)
            Try
                Dim query As String

                query = "UPDATE ordenes SET id_factura='A' WHERE id_factura='" & IdFactura & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
#End Region

        Public Function DatosUsuarioRecibo(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT " _
                                        & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE" _
                                        & ", `usuarios`.`IDENTIFICACION`" _
                                        & ", `usuarios`.`TELEFONO`" _
                                        & ", `usuarios`.`DIRECCION`" _
                                        & ", `ordenes`.`ID` AS ORDEN " _
                                        & ", `ordenes`.`SALDO` " _
                                        & ", `ordenes`.`CONSECUTIVO` " _
                                        & ", `ordenes`.`ESTADO` " _
                                        & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                        & "WHERE (`ordenes`.`ID` ='" & IdOrden & "')")
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
        Public Function ReciboCero(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT SUM(`COPAGO`) AS `COPAGO` FROM `detalle_orden` WHERE (`ID_ORDEN` ='" & IdOrden & "') HAVING (`COPAGO` =0)")
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
        Public Function DetalleRecibo(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT SUM(`detalle_orden`.`COPAGO`) AS `VALOR`" _
                                               & ", GROUP_CONCAT(`cups`.`NOMBRE_CUPS` SEPARATOR ', ') AS ESTUDIOS " _
                                               & "FROM `detalle_orden` INNER JOIN `cups` ON (`detalle_orden`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                               & "WHERE (`detalle_orden`.`ID_ORDEN` ='" & IdOrden & "')")
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
        Public Function GenerarPDF2021(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID`, " _
                                                & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO`, " _
                                                & "CONCAT(usuarios.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                                                & "FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                                & "INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                & "INNER JOIN `usuarios` ON (ordenes.id_usuario = `usuarios`.`ID`) " _
                                                & "WHERE (`ordenes`.`ESTADO` ='ATENDIDO' OR ORDENES.estado='FACTURADO') AND " _
                                                & "(`ordenes`.`FECHA_ORDEN` BETWEEN '" & Format(FechaInicial, "yyyy/MM/dd") & "' AND '" & Format(FechaFinal, "yyyy/MM/dd") & "') and (ordenes.comentarios<>'.') GROUP BY ORDENES.`ID`")
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
        Public Sub PDFGenerado(ByVal IdOrden As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET comentarios='.' where id='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function PacientesOptometria(ByVal IdEspecialista As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_orden.ID_ORDEN AS ORDEN " _
                                                  & ", ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO " _
                                                  & ",cups.`NOMBRE_CUPS` AS CUPS " _
                                                  & ", detalle_orden.id AS ID " _
                                                  & ", tipo_estudio.prefijo AS PREFIJO, detalle_orden.ID_TIPO_ESTUDIO as TIPOESTUDIO, ordenes.id_usuario as ID_USUARIO  " _
                                                  & "FROM ((((((((detalle_orden " _
                                                  & "JOIN ordenes ON ((detalle_orden.ID_ORDEN = ordenes.ID))) " _
                                                  & "JOIN tipo_estudio ON ((detalle_orden.ID_TIPO_ESTUDIO = tipo_estudio.ID))) " _
                                                  & "JOIN usuarios ON ((ordenes.ID_USUARIO = usuarios.ID))) " _
                                                  & "JOIN contratos ON ((ordenes.ID_CONTRATO = contratos.ID))) " _
                                                  & "JOIN empleados ON ((ordenes.ID_EMPLEADO = empleados.ID))) " _
                                                  & "JOIN entidades ON ((contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD))) " _
                                                  & "JOIN licencias ON ((contratos.ID_LICENCIA = licencias.ID))) " _
                                                  & "JOIN cups ON ((detalle_orden.`CODIGO_CUPS` = cups.`CODIGO_CUPS`))) " _
                                                  & "WHERE ((detalle_orden.id_tipo_estudio in (17)) AND ordenes.estado='PENDIENTE') AND ordenes.ID_EMPLEADO='" & IdEspecialista & "'")
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
        Public Function ListarHistoriasAnterioresOptometria(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT `detalle_orden`.`ID`, `detalle_orden`.`ID_ORDEN` AS ORDEN, `optometria`.`FECHA_HISTORIA` as FECHA " _
                                              & ", optometria.avf as ESTUDIO FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                              & "INNER JOIN `optometria` ON (`detalle_orden`.`ID_ORDEN` = `optometria`.`ID_ORDEN`) " _
                                              & "WHERE (ordenes.ESTADO ='ATENDIDO' AND ordenes.ID_USUARIO ='" & filtro & "') ORDER BY ordenes.FECHA_INGRESO ASC")
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
        Public Function OrdenesOPTOMETRIA() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.`ID` AS ORDEN	,ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD,  usuarios.TELEFONO AS TELEFONO " _
                                                  & ",usuarios.`CORREO_ELECTRONICO`,  contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO ,ordenes.`COMENTARIOS`,ordenes.`ESTADO`,especialistas.`NOMBRE`as ESPECIALISTA FROM `ordenes` " _
                                                  & "INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN especialistas ON (ordenes.`ID_EMPLEADO`=especialistas.id_especialista)")
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
        Public Function OrdenesProximoControl() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.`ID` AS ORDEN	,ordenes.FECHA_INGRESO AS FECHA_INGRESO " _
                                                  & ",CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                                  & ",CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE " _
                                                  & ", usuarios.SEXO AS SEXO,  TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD,  usuarios.TELEFONO AS TELEFONO " _
                                                  & ",usuarios.`CORREO_ELECTRONICO`,  contratos.NOMBRE AS CONTRATO, entidades.NOMBRE_ENTIDAD AS ENTIDAD " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO ,ordenes.`COMENTARIOS`,ordenes.`ESTADO`,especialistas.`NOMBRE`as ESPECIALISTA FROM `ordenes` " _
                                                  & "INNER JOIN `tipo_estudio`  ON (`ordenes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                                  & "INNER JOIN especialistas ON (ordenes.`ID_EMPLEADO`=especialistas.id_especialista) " _
                                                  & "WHERE DATEDIFF(CURDATE(),ordenes.FECHA_INGRESO)>=330 and DATEDIFF(CURDATE(),ordenes.FECHA_INGRESO)<=360")
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
        Public Function ExisteDiagnostico(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM historia_clinica WHERE id_orden='" & IdOrden & "'")
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
        Public Function Diagnostico(ByVal IdOrden As String) As String
            Try
                Dim query As String = String.Format("SELECT diagnostico FROM historia_clinica where id_orden='" & IdOrden & "'")
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
        Public Sub ActualizarEspecimen(ByVal IdOrden As Integer, ByVal IdEspecimen As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET id_especimen='" & IdEspecimen & "' where id='" & IdOrden & "'"
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


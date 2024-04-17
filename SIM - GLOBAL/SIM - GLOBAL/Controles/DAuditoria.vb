Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DAuditoria
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter

        Public Sub Guardar(ByVal _Auditoria As Auditoria)
            Try
                Dim query As String
                query = "insert into auditoria values('" & _Auditoria.Id & "', " _
                            & "'" & Format(_Auditoria.Fecha, "yyyy/MM/dd") & "', " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & _Auditoria.IdTabla & "', " _
                            & "'" & _Auditoria.IdRegistro & "', " _
                            & "'" & _Auditoria.Concepto & "', " _
                            & "'" & _Auditoria.Comentario & "', " _
                            & "'" & _Auditoria.IdSolicita & "', " _
                            & "'" & _Auditoria.IdAutoriza & "', " _
                            & "'" & _Auditoria.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarAuditoriaUsuario(ByVal IdUsuario As String, ByVal Tipo As String, ByVal Identificacion As String)
            Try
                Dim query As String
                query = "UPDATE usuarios Set id_tipo_identificacion='" & Tipo & "', identificacion='" & Identificacion & "' where id='" & IdUsuario & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarAuditoriaOrden(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "UPDATE ordenes Set estado='PENDIENTE' where id='" & IdOrden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarAuditoriaDetalleOrden(ByVal IdDetalleOrden As String)
            Try
                Dim query As String
                query = "UPDATE detalle_orden Set estado='PENDIENTE' where id='" & IdDetalleOrden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT `auditoria`.`ID`, `auditoria`.`FECHA`, `auditoria`.`HORA`, `tablas`.`TABLA` AS ORIGEN, " _
                                              & "`auditoria`.`ID_REGISTRO`, `auditoria`.`CONCEPTO`, `empleados`.`NOMBRE_EMPLEADO` AS SOLICITADO, " _
                                              & "`empleados_1`.`NOMBRE_EMPLEADO` AS APROBADO, `auditoria`.`ESTADO` FROM  `auditoria` " _
                                              & "INNER JOIN `tablas` ON (`auditoria`.`ID_TABLA` = `tablas`.`ID`) INNER JOIN `empleados` " _
                                              & "ON (`auditoria`.`ID_SOLICITA` = `empleados`.`ID`) INNER JOIN `empleados` AS `empleados_1` " _
                                              & "ON (`auditoria`.`ID_AUTORIZA` = `empleados_1`.`ID`) ORDER BY id DESC LIMIT 0, 500")
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
        Public Function MostrarRegistros(ByVal IdEmpleado As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM users WHERE id_empleado='" & IdEmpleado & "' AND estado='A' AND admin <> '0'")
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
        Public Function ListarRegistros() As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT registros.FECHA, " _
                                            & "registros.HORA, " _
                                            & "tablas.tabla AS TABLA, " _
                                            & "registros.id_registro AS REGISTRO, " _
                                            & "users.USUARIO, " _
                                            & "registros.tipo_registro AS TIPO, " _
                                            & "registros.NOTA " _
                                            & "FROM registros INNER JOIN tablas ON (registros.id_tabla=tablas.id) " _
                                            & "INNER JOIN users ON (registros.id_usuario=users.id_empleado) " _
                                            & "ORDER BY registros.fecha DESC, registros.hora DESC")
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
        Public Function ListarUltimosRegistros() As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT registros.FECHA, " _
                                            & "registros.HORA, " _
                                            & "tablas.tabla AS TABLA, " _
                                            & "registros.id_registro AS REGISTRO, " _
                                            & "users.USUARIO, " _
                                            & "registros.tipo_registro AS TIPO, " _
                                            & "registros.NOTA " _
                                            & "FROM registros INNER JOIN tablas ON (registros.id_tabla=tablas.id) " _
                                            & "INNER JOIN users ON (registros.id_usuario=users.id_empleado) " _
                                            & "ORDER BY registros.fecha DESC, registros.hora DESC LIMIT 0, 500")
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
        Public Function MostrarUsuario(ByVal IdUsuario As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT CONCAT(id_tipo_identificacion,identificacion) AS IDENTIFICACION, " _
                                            & "CONCAT(primer_nombre,' ',segundo_nombre,' ',primer_apellido,' ',segundo_apellido) AS NOMBRE, " _
                                            & "TIMESTAMPDIFF(YEAR,Fecha_nacimiento,CURDATE()) AS EDAD, " _
                                            & "direccion, " _
                                            & "telefono, " _
                                            & "correo_electronico " _
                                            & "FROM usuarios WHERE id='" & IdUsuario & "'")
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
        Public Function MostrarOrden(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT `ordenes`.`ID` AS `ORDEN`, ordenes.CONSECUTIVO, " _
                                            & "`ordenes`.`FECHA_INGRESO`, " _
                                            & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                            & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                                            & "`usuarios`.`SEXO`, " _
                                            & "TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, " _
                                            & "`empleados`.`NOMBRE_EMPLEADO` AS `ESPECIALISTA`, `contratos`.`NOMBRE` AS `CONTRATO`, " _
                                            & "`ordenes`.`ESTADO`, ordenes.autorizacion as AUTORIZACION, ordenes.numero_orden as NUMERO_ORDEN   FROM `ordenes` " _
                                            & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                            & "INNER JOIN `empleados` ON (`ordenes`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                                            & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                            & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                            & "INNER JOIN `licencias` ON (`contratos`.`ID_LICENCIA` = `licencias`.`ID`) where ordenes.id='" & IdOrden & "'")
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

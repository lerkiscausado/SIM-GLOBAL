Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DOrdenes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdOrden As String) As PEC___App.Modelo.Ordenes
            Try
                Dim query As String = String.Format("SELECT * FROM ordenes WHERE id='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New PEC___App.Modelo.Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Ordenes.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _Ordenes.IdContrato = _ds.Tables(0).Rows(0)(2).ToString()
                _Ordenes.IdClienteSede = _ds.Tables(0).Rows(0)(3).ToString()
                _Ordenes.IdEmpleado = _ds.Tables(0).Rows(0)(4).ToString()
                _Ordenes.Autorizacion = _ds.Tables(0).Rows(0)(5).ToString()
                _Ordenes.FechaIngreso = _ds.Tables(0).Rows(0)(6).ToString()
                _Ordenes.FechaSolicitud = _ds.Tables(0).Rows(0)(7).ToString()
                _Ordenes.Hora = _ds.Tables(0).Rows(0)(8).ToString()
                _Ordenes.IdFactura = _ds.Tables(0).Rows(0)(9).ToString()
                _Ordenes.Comentarios = _ds.Tables(0).Rows(0)(10).ToString()
                _Ordenes.Estado = _ds.Tables(0).Rows(0)(11).ToString()

                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _Ordenes As PEC___App.Modelo.Ordenes)
            Try
                Dim query As String
                If Existe(_Ordenes.Id) = True Then
                    query = "UPDATE ordenes SET id_cliente_sede='" & _Ordenes.IdClienteSede & "', id_empleado='" & _Ordenes.IdEmpleado & "', " _
                           & "autorizacion='" & _Ordenes.Autorizacion & "', " _
                           & "fecha_solicitud='" & Format(_Ordenes.FechaSolicitud, "yyyy/MM/dd") & "', " _
                           & "comentarios='" & _Ordenes.Comentarios & "' " _
                           & "where id='" & _Ordenes.Id & "'"
                Else
                    query = "insert into ordenes values('" & _Ordenes.Id & "', " _
                            & "'" & _Ordenes.IdUsuario & "', " _
                            & "'" & _Ordenes.IdContrato & "', " _
                            & "'" & _Ordenes.IdClienteSede & "', " _
                            & "'" & _Ordenes.IdEmpleado & "', " _
                            & "'" & _Ordenes.Autorizacion & "', " _
                            & "'" & Format(_Ordenes.FechaIngreso, "yyyy/MM/dd") & "', " _
                            & "'" & Format(_Ordenes.FechaSolicitud, "yyyy/MM/dd") & "', " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & _Ordenes.IdFactura & "', " _
                            & "'" & _Ordenes.Comentarios & "', " _
                            & "'" & _Ordenes.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function UltimoRegistroUsuario(ByVal IdUsuario As String) As PEC___App.Modelo.Ordenes
            Try
                Dim query As String = String.Format("SELECT id FROM ordenes WHERE id_usuario='" & IdUsuario & "' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New PEC___App.Modelo.Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function OrdenPendiente(ByVal IdOrden As Integer) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & IdOrden & "' and estado='PENDIENTE'")
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
        Public Function ListarOrdenes2() As DataSet
            Try
                Dim query As String =
                      String.Format("SELECT `ordenes`.`ID` AS `ORDEN`, " _
                        & "`ordenes`.`FECHA_INGRESO`, " _
                        & "`ordenes`.`FECHA_SOLICITUD`, " _
                        & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                        & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                        & "`usuarios`.`SEXO`, " _
                        & "`usuarios`.`TELEFONO`, " _
                        & "`usuarios`.`CORREO_ELECTRONICO` AS `EMAIL`, " _
                        & "`clientes`.`NOMBRE` AS `CLIENTE`, " _
                        & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, " _
                        & "`detalle_orden`.`ESTADO`, " _
                        & "`usuarios`.`ID` AS IDUSUARIO " _
                        & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                        & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                        & "INNER JOIN `clientes` ON (`contratos`.`ID_CLIENTE` = `clientes`.`ID`) " _
                        & "INNER JOIN `detalle_orden` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`)" _
                        & "INNER JOIN `tipo_estudio` ON (`detalle_orden`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                        & "WHERE detalle_orden.`ESTADO`='PENDIENTE' ORDER BY `ORDEN` DESC")
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
        Public Function ListarEstudios(ByVal Ano As String) As DataSet
            Try
                Dim query As String =
                      String.Format("SELECT ordenes.id AS ORDEN, " _
                                  & "ordenes.FECHA_INGRESO, " _
                                  & "ordenes.FECHA_SOLICITUD, " _
                                  & "CONCAT(usuarios.id_tipo_identificacion,usuarios.identificacion) AS IDENTIFICACION, " _
                                  & "CONCAT(usuarios.primer_nombre,' ',usuarios.segundo_nombre,' ',usuarios.primer_apellido,' ',usuarios.segundo_apellido) AS NOMBRE, " _
                                  & "usuarios.SEXO, " _
                                  & "TIMESTAMPDIFF(YEAR,Fecha_nacimiento,CURDATE()) AS EDAD, " _
                                  & "contratos.nombre_contrato AS CONTRATO, " _
                                  & "tipo_estudio.nombre_tipo_estudio AS ESTUDIO, " _
                                  & "empleados.nombre_empleado AS ANALISTA, " _
                                  & "detalle_orden.ESTADO FROM " _
                                  & "ordenes INNER JOIN usuarios ON (ordenes.id_usuario=usuarios.id) " _
                                  & "INNER JOIN detalle_orden ON (detalle_orden.id_orden=ordenes.id) " _
                                  & "INNER JOIN tipo_estudio ON (detalle_orden.id_tipo_estudio=tipo_estudio.id) " _
                                  & "INNER JOIN detalle_orden_analista ON (detalle_orden_analista.id_detalle_orden=detalle_orden.id) " _
                                  & "INNER JOIN empleados ON (detalle_orden_analista.id_empleado=empleados.id) " _
                                  & "INNER JOIN contratos ON (ordenes.id_contrato=contratos.id)  WHERE YEAR(ordenes.`FECHA_INGRESO`)='" & Ano & "' ORDER BY ordenes.fecha_ingreso DESC")
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
        Public Sub ActualizarEstado(ByVal IdOrden As Integer, ByVal Estado As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='" & Estado & "' where id='" & IdOrden & "'"
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


Imports SIM___GLOBAL.My.Controles
Imports SIM___INTEGRA.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DHistoriaIntegra
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As HistoriaIntegra
            Try
                Dim query As String = String.Format("SELECT * FROM historia_clinica WHERE id_detalle_orden='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _historia = New HistoriaIntegra
                _historia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _historia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _historia.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _historia.CodigoHistoria = _ds.Tables(0).Rows(0)(3).ToString()
                _historia.Fecha = _ds.Tables(0).Rows(0)(4).ToString()
                _historia.Hora = _ds.Tables(0).Rows(0)(5).ToString()
                _historia.MotivoConsulta = _ds.Tables(0).Rows(0)(6).ToString()
                _historia.AntecedentesPersonales = _ds.Tables(0).Rows(0)(7).ToString()
                _historia.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(8).ToString()
                _historia.Valoracion = _ds.Tables(0).Rows(0)(9).ToString()
                _historia.PlanSeguir = _ds.Tables(0).Rows(0)(10).ToString()
                _historia.ReporteEvolucion = _ds.Tables(0).Rows(0)(11).ToString()
                _historia.Remision = _ds.Tables(0).Rows(0)(12).ToString()
                _historia.CodigoDiagnostico = _ds.Tables(0).Rows(0)(13).ToString()
                _historia.Cita = _ds.Tables(0).Rows(0)(14).ToString()
                _historia.IdEspecialidad = _ds.Tables(0).Rows(0)(15).ToString()
                _historia.IdEmpleado = _ds.Tables(0).Rows(0)(16).ToString()
                _historia.Estado = _ds.Tables(0).Rows(0)(17).ToString()
                Return _historia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _historia As HistoriaIntegra)
            Try
                Dim query As String
                If Existe(_historia.IdDetalleOrden) = True Then
                    query = "UPDATE historia_clinica SET " _
                        & "motivo_consulta='" & _historia.MotivoConsulta & "', " _
                        & "antecedentes_personales='" & _historia.AntecedentesPersonales & "', " _
                        & "antecedentes_familiares='" & _historia.AntecedentesFamiliares & "', " _
                        & "antecedentes_valoracion='" & _historia.Valoracion & "', " _
                        & "plan_seguir='" & _historia.PlanSeguir & "', " _
                        & "codigo_diagnostico='" & _historia.CodigoDiagnostico & "', " _
                        & "reporte_evolucion='" & _historia.ReporteEvolucion & "', " _
                        & "remision='" & _historia.Remision & "' where id_detalle_orden='" & _historia.IdDetalleOrden & "'"
                Else
                    query = "insert into historia_clinica values('" & _historia.Id & "', " _
                        & "'" & _historia.IdOrden & "', " _
                        & "'" & _historia.IdDetalleOrden & "', " _
                        & "'" & _historia.CodigoHistoria & "', " _
                        & "'" & Format(_historia.Fecha, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_historia.Hora, "hh:mm:ss") & "', " _
                        & "'" & _historia.MotivoConsulta & "', " _
                        & "'" & _historia.AntecedentesPersonales & "', " _
                        & "'" & _historia.AntecedentesFamiliares & "', " _
                        & "'" & _historia.Valoracion & "', " _
                        & "'" & _historia.PlanSeguir & "', " _
                        & "'" & _historia.ReporteEvolucion & "', " _
                        & "'" & _historia.Remision & "', " _
                        & "'" & _historia.CodigoDiagnostico & "', " _
                        & "'" & _historia.Cita & "', " _
                        & "'" & _historia.IdEspecialidad & "', " _
                        & "'" & _historia.IdEmpleado & "', " _
                        & "'" & _historia.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function GuardarHistoriayDetalle(ByVal _detalleOrden As SIM___GLOBAL.My.Modelo.DetalleOrden, ByVal _historia As HistoriaIntegra) As String
            Try
                Dim query As String
                If Existe(_historia.IdDetalleOrden) = True Then
                    query = "UPDATE historia_clinica SET motivo_consulta='" & _historia.MotivoConsulta & "', " _
                    & "antecedentes_personales='" & _historia.AntecedentesPersonales & "', " _
                    & "antecedentes_familiares='" & _historia.AntecedentesFamiliares & "', " _
                    & "valoracion='" & _historia.Valoracion & "', " _
                    & "plan_seguir='" & _historia.PlanSeguir & "', " _
                    & "codigo_diagnostico='" & _historia.CodigoDiagnostico & "', " _
                    & "reporte_evolucion='" & _historia.ReporteEvolucion & "', " _
                    & "remision='" & _historia.Remision & "' WHERE id_detalle_orden='" & _historia.IdDetalleOrden & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                    Return _historia.IdDetalleOrden

                Else

                    query = "CALL historia_detalle ('" & _detalleOrden.IdOrden & "','" & Format(_detalleOrden.FechaSalida, "yyyy/MM/dd") & " ', '" & _detalleOrden.Diagnostico1 & "', '" & _detalleOrden.CodigoProcedimiento & "','" & _detalleOrden.Valor & "','" & _detalleOrden.Copago & "','" & _detalleOrden.Neto & "'," _
                        & "'" & _historia.IdOrden & "','" & _historia.CodigoHistoria & "','" & Format(_historia.Fecha, "yyyy/MM/dd") & "','" & _historia.MotivoConsulta & "','" & _historia.AntecedentesPersonales & "', " _
                        & "'" & _historia.AntecedentesFamiliares & "','" & _historia.Valoracion & "','" & _historia.PlanSeguir & "', '" & _historia.ReporteEvolucion & "', " _
                        & "'" & _historia.Remision & "', '" & _historia.CodigoDiagnostico & "','" & _historia.Cita & "','" & _historia.IdEspecialidad & "', '" & _historia.IdEmpleado & "')"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    _adapter = New OdbcDataAdapter(comando)
                    _ds = New DataSet()
                    _adapter.Fill(_ds)
                    ConexionODBC.Close(_conn)
                    Return _ds.Tables(0).Rows(0)(0).ToString()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                Return Nothing
            End Try
        End Function
        Public Sub GuardarProcedimientoAlmacenado()
            Try
                Dim query As String

                query = "call historia_detalle"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("Select id FROM historia_clinica WHERE id_detalle_orden='" & filtro & "'")
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
        Public Function ExisteHistoriaEspecialista(ByVal IdUsuario As String, ByVal IdEspecialidad As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ordenes`.`ID_USUARIO` FROM `historia_clinica` INNER JOIN `ordenes` " _
                                      & "ON (`historia_clinica`.`ID_ORDEN` = `ordenes`.`ID`) INNER JOIN `especialidades` " _
                                      & "ON (`historia_clinica`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) " _
                                      & "WHERE ordenes.`ID_USUARIO`='" & IdUsuario & "' AND historia_clinica.`ID_ESPECIALIDAD`='" & IdEspecialidad & "' ")
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
        Public Function ExisteHistoriaEmpleado(ByVal IdUsuario As String, ByVal Idempleado As String) As DataSet
            Try
                Dim query As String =
                        String.Format("SELECT `historia_clinica`.`ID_DETALLE_ORDEN`, `historia_clinica`.`CITA`, `detalle_orden`.`ESTADO`, detalle_orden.codigo_procedimiento " _
                                      & "FROM `historia_clinica` INNER JOIN `detalle_orden` ON (`historia_clinica`.`ID_DETALLE_ORDEN` = `detalle_orden`.`ID`) " _
                                      & "INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                      & "WHERE (`ordenes`.`ID_USUARIO` ='" & IdUsuario & "'    AND `historia_clinica`.`ID_EMPLEADO` ='" & Idempleado & "' and historia_clinica.fecha=curdate())")
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
        Public Function ListarHistoriasAnteriores(ByVal filtro As String, ByVal Estado As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden`.`ID` AS ID, `historia_clinica`.`FECHA` AS FECHA, " _
                                                  & "CONCAT(`historia_clinica`.`MOTIVO_CONSULTA`,'-', `historia_clinica`.`REPORTE_EVOLUCION`) AS CONSULTA " _
                                                  & ", `especialidades`.`NOMBRE_ESPECIALIDAD` AS ESPECIALIDAD, `ordenes`.`ID_USUARIO` AS USUARIO " _
                                                  & "FROM `detalle_orden` INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `simintegra`.`historia_clinica` ON (`detalle_orden`.`ID` = `historia_clinica`.`ID_DETALLE_ORDEN`) " _
                                                  & "INNER JOIN `simintegra`.`especialidades` ON (`historia_clinica`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) " _
                                                  & "WHERE (`detalle_orden`.`ESTADO` ='" & Estado & "' And `ordenes`.`ID_USUARIO` ='" & filtro & "')")
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

        Public Function ListarHistoriasSinFirma(ByVal IdUsuario As String, ByVal IdEspecialista As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden`.`ID` AS ID, `historia_clinica`.`FECHA` AS FECHA, " _
                                                  & "CONCAT(`historia_clinica`.`MOTIVO_CONSULTA`,'-', `historia_clinica`.`REPORTE_EVOLUCION`) AS CONSULTA " _
                                                  & ", `especialidades`.`NOMBRE_ESPECIALIDAD` AS ESPECIALIDAD, `ordenes`.`ID_USUARIO` AS USUARIO " _
                                                  & "FROM `detalle_orden` INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `simintegra`.`historia_clinica` ON (`detalle_orden`.`ID` = `historia_clinica`.`ID_DETALLE_ORDEN`) " _
                                                  & "INNER JOIN `simintegra`.`especialidades` ON (`historia_clinica`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) " _
                                                  & "WHERE (`detalle_orden`.`ESTADO` ='PENDIENTE' And `ordenes`.`ID_USUARIO` ='" & IdUsuario & "' and historia_clinica.id_empleado='" & IdEspecialista & "')")
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
        Public Function HistoriasAnteriores() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_orden`.`ID` AS IDDETALLE , `ordenes`.`ID` AS ORDEN, `historia_clinica`.`FECHA` " _
                                    & ", `historia_clinica`.`HORA`, CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION " _
                                    & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS USUARIO " _
                                    & ", `usuarios`.`SEXO`,TIMESTAMPDIFF(YEAR,`usuarios`.`FECHA_NACIMIENTO`,CURDATE()) AS EDAD, `ordenes`.`CODIGO_DIAGNOSTICO` AS DIAGNOSTICO " _
                                    & ", `contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD, `especialidades`.`NOMBRE_ESPECIALIDAD` AS ESPECIALIDAD " _
                                    & ", `empleados`.`NOMBRE_EMPLEADO` AS ESPECIALISTA , `detalle_orden`.`ESTADO`, historia_clinica.cita as CITA, historia_clinica.remision AS REMISION FROM `detalle_orden` INNER JOIN `ordenes` " _
                                    & "ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) INNER JOIN `historia_clinica` ON (`detalle_orden`.`ID` = `historia_clinica`.`ID_DETALLE_ORDEN`) " _
                                    & " INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                    & " INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) INNER JOIN `especialidades` " _
                                    & "ON (`historia_clinica`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) INNER JOIN `empleados` ON (`historia_clinica`.`ID_EMPLEADO` = `empleados`.`ID`)")
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
        Public Function VistaPreviaHistoria(ByVal Filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID_USUARIO`, CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ' ,`usuarios`.`SEGUNDO_APELLIDO`) AS USUARIO " _
                                    & ", CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION, `usuarios`.`SEXO`, " _
                                    & "TIMESTAMPDIFF(YEAR,usuarios.`FECHA_NACIMIENTO`,CURDATE()) AS EDAD , `usuarios`.`TELEFONO`, `usuarios`.`DIRECCION` " _
                                    & ", `historia_clinica`.`ID_ORDEN` AS ORDEN, `historia_clinica`.`FECHA`, `historia_clinica`.`HORA`, `contratos`.`NOMBRE` AS CONTRATO " _
                                    & ", `empleados`.`NOMBRE_EMPLEADO` AS ESPECIALISTA, `especialidades`.`NOMBRE_ESPECIALIDAD` AS ESPECIALIDAD, `historia_clinica`.`CITA`, " _
                                    & "`historia_clinica`.`MOTIVO_CONSULTA`, `historia_clinica`.`ANTECEDENTES_PERSONALES`, `historia_clinica`.`ANTECEDENTES_FAMILIARES`, " _
                                    & "`historia_clinica`.`VALORACION` , `historia_clinica`.`PLAN_SEGUIR`, `historia_clinica`.`REPORTE_EVOLUCION`, `historia_clinica`.`REMISION`, " _
                                    & "`ordenes`.`CODIGO_DIAGNOSTICO`, `detalle_orden`.`CODIGO_PROCEDIMIENTO` AS CODIGO, `cups`.`NOMBRE_CUPS` AS CUPS, " _
                                    & "`detalle_orden`.`estado` AS ESTADO FROM `historia_clinica` INNER JOIN `ordenes` ON (`historia_clinica`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                    & "INNER JOIN `empleados` ON (`historia_clinica`.`ID_EMPLEADO` = `empleados`.`ID`) INNER JOIN `especialidades` ON " _
                                    & "(`historia_clinica`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) INNER JOIN `detalle_orden` ON " _
                                    & "(`historia_clinica`.`ID_DETALLE_ORDEN` = `detalle_orden`.`ID`) INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                    & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `detalle_tarifa` " _
                                    & "ON (`detalle_orden`.`CODIGO_PROCEDIMIENTO` = `detalle_tarifa`.`CODIGO_PROCEDIMIENTO`) INNER JOIN `cups` " _
                                    & "ON (`detalle_tarifa`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) WHERE historia_clinica.`ID_DETALLE_ORDEN`='" & Filtro & "' LIMIT 1")
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
        Public Function ExisteOrdenHistoria(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ID_ORDEN` FROM `historia_clinica` WHERE (`ID_ORDEN` ='" & filtro & "')")
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
        Public Function ExisteRemision(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ID_DETALLE_ORDEN`, `REMISION` FROM `historia_clinica` " _
                                      & "WHERE (`ID_DETALLE_ORDEN` ='" & IdDetalleOrden & "' And `REMISION` <>'')")
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
        Public Function HistoriaSinFirma(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ordenes`.`ID` FROM `ordenes` INNER JOIN `detalle_orden` ON " _
                                      & "(`ordenes`.`ID` = `detalle_orden`.`ID`) " _
                                      & "WHERE (`ordenes`.`ID` ='" & filtro & "' AND `detalle_orden`.`ESTADO` ='PENDIENTE')")
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
        Public Function ExisteEvolucionHistoria(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT `ID_ORDEN` FROM `historia_clinica` WHERE (`ID_ORDEN` ='" & filtro & "' AND `CITA` ='C')")
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

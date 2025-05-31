Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO

Namespace Controles
    Public Class DImpresionHistoria
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones


        Public Sub Guardar_pryeba(ByVal _ImpresionHistoria As ImpresionHistoria)
            Try
                Dim query As String
                'Guardar Historia
                query = "INSERT INTO impresion_historia VALUES('','" & _ImpresionHistoria.IdOrden & "','" & _ImpresionHistoria.IdDetalleOrden & "', " _
                        & "'" & _ImpresionHistoria.NumeroHistoria & "','" & _ImpresionHistoria.Nombre & "','" & _ImpresionHistoria.Identificacion & "', " _
                        & "'" & Format(_ImpresionHistoria.Edad, "yyyy/MM/dd") & "','" & _ImpresionHistoria.Sexo & "','" & _ImpresionHistoria.EstadoCivil & "', " _
                        & "'" & _ImpresionHistoria.Telefono & "','" & _ImpresionHistoria.Direccion & "','" & _ImpresionHistoria.Entidad & "', " _
                        & "'" & Format(_ImpresionHistoria.FechaIngreso, "yyyy/MM/dd") & "','" & Format(_ImpresionHistoria.FechaAtencion, "yyyy/MM/dd") & "', " _
                        & "'" & _ImpresionHistoria.MotivoConsulta & "', '" & _ImpresionHistoria.AntecedentesFamiliares & "', " _
                        & "'" & _ImpresionHistoria.AntecedentesPersonales & "', '" & _ImpresionHistoria.EnfermedadActual & "','" & _ImpresionHistoria.RevisionxSistemas & "', " _
                        & "'" & _ImpresionHistoria.PlanSeguir & "', '" & _ImpresionHistoria.Diagnostico & "','" & _ImpresionHistoria.Recomendaciones & "', " _
                        & "'','" & _ImpresionHistoria.Medico & "','" & _ImpresionHistoria.Especialidad & "', '" & _ImpresionHistoria.RegistroMedico & "', " _
                        & "'" & _ImpresionHistoria.IdEmpleado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()

                query = "update Impresion_historia set FIRMA=? where id_detalle_orden='" & _ImpresionHistoria.IdDetalleOrden & "'"
                Dim Imag As Byte()
                Imag = _funciones.Imagen_Bytes(_ImpresionHistoria.Firma)
                comando.Parameters.AddWithValue(1, Imag)
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarHistoria(ByVal IdEmpleado As String)
            Try
                Dim query As String
                query = "DELETE FROM impresion_historia WHERE id_empleado='" & IdEmpleado & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal IDDetalleOrden As String, ByVal Control As String) As DataSet
            Try
                Dim query As String
                If Control = "H" Then
                    query = String.Format("SELECT `ordenes`.`ID` AS ID_ORDEN, " _
                                                  & "detalle_orden.id as ID_DETALLE_ORDEN, " _
                                                  & "`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                                  & "`usuarios`.`fecha_nacimiento` AS EDAD," _
                                                  & "`usuarios`.`SEXO`, " _
                                                  & "`usuarios`.`ESTADO_CIVIL`, " _
                                                  & "`usuarios`.`TELEFONO`, " _
                                                  & "`usuarios`.`DIRECCION`, " _
                                                  & "`entidades`.`NOMBRE_ENTIDAD`, " _
                                                  & "ordenes.FECHA_INGRESO, " _
                                                  & "`historia_clinica`.`FECHA_HISTORIA`, " _
                                                  & "`historia_clinica`.`MOTIVO_CONSULTA`, " _
                                                  & "antecedentes.`ANTECEDENTES_FAMILIARES`, " _
                                                  & "antecedentes.`ANTECEDENTES_PERSONALES`, " _
                                                  & "`historia_clinica`.`ENFERMEDAD_ACTUAL`, " _
                                                  & "`historia_clinica`.`REVISIONXSISTEMAS`, " _
                                                  & "`historia_clinica`.`PLAN_SEGUIR`, " _
                                                  & "`historia_clinica`.`DIAGNOSTICO`, " _
                                                  & "`historia_clinica`.`RECOMENDACIONES`, " _
                                                  & "especialistas.`FIRMA`, " _
                                                  & "especialistas.`NOMBRE`, " _
                                                  & "especialistas.`ESPECIALIDAD`, " _
                                                  & "especialistas.`REGISTRO_MEDICO`, " _
                                                  & "ordenes.id_empleado FROM `ordenes` INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `usuarios` ON " _
                                                  & "(`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) INNER JOIN detalle_orden " _
                                                  & "ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) INNER JOIN antecedentes ON(`ordenes`.`ID_usuario` = `antecedentes`.`ID_usuario`) " _
                                                  & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) WHERE  detalle_orden.id='" & IDDetalleOrden & "'")
                Else
                    query = String.Format("SELECT `ordenes`.`ID` AS ID_ORDEN," _
                                          & "detalle_orden.id AS ID_DETALLE_ORDEN," _
                                          & "`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA," _
                                          & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE," _
                                          & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION," _
                                          & "`usuarios`.`fecha_nacimiento` AS EDAD," _
                                          & "`usuarios`.`SEXO`," _
                                          & "`usuarios`.`ESTADO_CIVIL`," _
                                          & "`usuarios`.`TELEFONO`," _
                                          & "`usuarios`.`DIRECCION`," _
                                          & "`entidades`.`NOMBRE_ENTIDAD`," _
                                          & "ordenes.FECHA_INGRESO," _
                                          & "`historia_clinica`.`FECHA_HISTORIA`," _
                                          & "`historia_clinica`.`MOTIVO_CONSULTA` ," _
                                          & "'' AS ANTECEDENTES_FAMILIARES," _
                                          & "'' AS  ANTECEDENTES_PERSONALES," _
                                          & "`historia_clinica`.`ENFERMEDAD_ACTUAL`	," _
                                          & "`historia_clinica`.`REVISIONXSISTEMAS`	," _
                                          & "`historia_clinica`.`PLAN_SEGUIR`," _
                                          & "`historia_clinica`.`DIAGNOSTICO`," _
                                          & "`historia_clinica`.`RECOMENDACIONES`," _
                                          & "especialistas.`FIRMA`," _
                                          & "especialistas.`NOMBRE`," _
                                          & "especialistas.`ESPECIALIDAD`," _
                                          & "especialistas.`REGISTRO_MEDICO`," _
                                          & "ordenes.id_empleado " _
                                          & "FROM `ordenes`	INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) " _
                                          & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                          & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`)" _
                                          & "INNER JOIN detalle_orden ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                          & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) " _
                                          & "WHERE  detalle_orden.id='" & IDDetalleOrden & "'")
                End If
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
        Public Sub GuardarImpresionHistoria(ByVal IDDetalleOrden As String, ByVal IDEmpleado As String)
            Try
                Dim query As String
                'Guardar Historia
                query = "INSERT INTO impresion_historia SELECT " _
                    & "0 AS ID " _
                    & ",`ordenes`.`ID` AS ID_ORDEN " _
                    & ",detalle_orden.id AS ID_DETALLE_ORDEN " _
                    & ",`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA " _
                    & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                    & ",CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION " _
                    & ", `usuarios`.`fecha_nacimiento` AS EDAD " _
                    & ",`usuarios`.`SEXO` " _
                    & ",`usuarios`.`ESTADO_CIVIL` " _
                    & ", `usuarios`.`TELEFONO` " _
                    & ",`usuarios`.`DIRECCION` " _
                    & ",`entidades`.`NOMBRE_ENTIDAD` " _
                    & ",ordenes.FECHA_INGRESO " _
                    & ",`historia_clinica`.`FECHA_HISTORIA`	" _
                    & ",`historia_clinica`.`MOTIVO_CONSULTA` " _
                    & ",historia_clinica.`RESPONSABLES` " _
                    & ",historia_clinica.`CONSULTA_CONTROL` " _
                    & ",`historia_clinica`.`ENFERMEDAD_ACTUAL`" _
                    & ",`historia_clinica`.`REVISIONXSISTEMAS`" _
                    & ",'' as FAMILIARES" _
                    & ",'' as PERSONALES" _
                    & ",historia_clinica.`EXAMEN_FISICO`,`historia_clinica`.`PESO` " _
                    & ",`historia_clinica`.`TALLA`, `historia_clinica`.`TENSION_ARTERIAL`, `historia_clinica`.`FRECUENCIA_RESPIRATORIA`, `historia_clinica`.`FRECUENCIA_CARDIACA` " _
                    & ", `historia_clinica`.`TEMPERATURA`, `historia_clinica`.`TANNER_A`, `historia_clinica`.`TANNER_B`, `historia_clinica`.`TANNER_P`, `historia_clinica`.`TANNER_VT` " _
                    & ", `historia_clinica`.`TANNER_LP`	,`historia_clinica`.`RECOMENDACIONES`, `historia_clinica`.`DIAGNOSTICO`	,`historia_clinica`.`PLAN_SEGUIR` " _
                    & ", `historia_clinica`.FORMULACION	, `historia_clinica`.LABORATORIOS,`historia_clinica`.OTROS_ESTUDIOS	, especialistas.`FIRMA`	,especialistas.`NOMBRE` " _
                    & ", especialistas.`ESPECIALIDAD`,especialistas.`REGISTRO_MEDICO`	, '" & IDEmpleado & "' FROM 	`ordenes` " _
                    & "INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                    & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) 	INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                    & "INNER JOIN detalle_orden ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                    & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) WHERE  detalle_orden.id='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function CargarHistoria(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT " _
                                      & "`ordenes`.`ID` AS ID_ORDEN " _
                                      & ",detalle_orden.id AS ID_DETALLE_ORDEN " _
                                      & ",`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA " _
                                      & ", CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                                      & ",CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION " _
                                      & ", `usuarios`.`fecha_nacimiento` AS EDAD " _
                                      & ",`usuarios`.`SEXO` " _
                                      & ",`usuarios`.`ESTADO_CIVIL` " _
                                      & ", `usuarios`.`TELEFONO` " _
                                      & ",`usuarios`.`DIRECCION` " _
                                      & ",`entidades`.`NOMBRE_ENTIDAD` " _
                                      & ",ordenes.FECHA_INGRESO " _
                                      & ",`historia_clinica`.`FECHA_HISTORIA` " _
                                      & ",`historia_clinica`.`MOTIVO_CONSULTA` " _
                                      & ",historia_clinica.`RESPONSABLES` " _
                                      & ",historia_clinica.`CONSULTA_CONTROL` " _
                                      & ",`historia_clinica`.`ENFERMEDAD_ACTUAL` " _
                                      & ",`historia_clinica`.`REVISIONXSISTEMAS` " _
                                      & ",antecedentes.`ANTECEDENTES_FAMILIARES` " _
                                      & ",antecedentes.`ANTECEDENTES_PERSONALES` " _
                                      & ",historia_clinica.`EXAMEN_FISICO` " _
                                      & ",`historia_clinica`.`PESO` " _
                                      & ",`historia_clinica`.`TALLA` " _
                                      & ", `historia_clinica`.`TENSION_ARTERIAL` " _
                                      & ", `historia_clinica`.`FRECUENCIA_RESPIRATORIA` " _
                                      & ", `historia_clinica`.`FRECUENCIA_CARDIACA` " _
                                      & ", `historia_clinica`.`TEMPERATURA` " _
                                      & ", `historia_clinica`.`TANNER_A` " _
                                      & ", `historia_clinica`.`TANNER_B` " _
                                      & ", `historia_clinica`.`TANNER_P` " _
                                      & ", `historia_clinica`.`TANNER_VT` " _
                                      & ", `historia_clinica`.`TANNER_LP` " _
                                      & ",`historia_clinica`.`RECOMENDACIONES` " _
                                      & ", `historia_clinica`.`DIAGNOSTICO`	" _
                                      & ",`historia_clinica`.`PLAN_SEGUIR`	" _
                                      & ", `historia_clinica`.FORMULACION " _
                                      & ", `historia_clinica`.LABORATORIOS " _
                                      & ",`historia_clinica`.OTROS_ESTUDIOS " _
                                      & ", especialistas.`FIRMA` " _
                                      & ",especialistas.`NOMBRE` " _
                                      & ", especialistas.`ESPECIALIDAD` " _
                                      & ",especialistas.`REGISTRO_MEDICO` " _
                                      & ", ordenes.id_empleado " _
                                      & "FROM `ordenes` " _
                                      & "INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) " _
                                      & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                      & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                      & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                      & "INNER JOIN detalle_orden ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                      & "INNER JOIN antecedentes ON(`ordenes`.`ID_usuario` = `antecedentes`.`ID_usuario`) " _
                                      & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) " _
                                      & "WHERE  detalle_orden.id='" & IDDetalleOrden & "'")

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
        Public Function VistaPreviaHistoria(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT usuarios.`ID` , CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                    & ",CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION ,`usuarios`.`SEXO` ,TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD " _
                    & ", `usuarios`.`TELEFONO` ,`usuarios`.`DIRECCION` ,`ordenes`.`ID` AS ID_ORDEN ,`historia_clinica`.`FECHA_HISTORIA` ,`entidades`.`NOMBRE_ENTIDAD` ,especialistas.`NOMBRE` " _
                    & ", especialistas.`ESPECIALIDAD` ,cups.`NOMBRE_CUPS`,`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA ,`historia_clinica`.`MOTIVO_CONSULTA` ,historia_clinica.`RESPONSABLES` ,historia_clinica.`CONSULTA_CONTROL` " _
                    & ",`historia_clinica`.`ENFERMEDAD_ACTUAL`,`historia_clinica`.`REVISIONXSISTEMAS` ,'' as FAMILIARES , '' as PERSONALES " _
                    & ",historia_clinica.`EXAMEN_FISICO`,`historia_clinica`.`PESO` ,`historia_clinica`.`TALLA` , `historia_clinica`.`TENSION_ARTERIAL` " _
                    & ", `historia_clinica`.`FRECUENCIA_RESPIRATORIA` , `historia_clinica`.`FRECUENCIA_CARDIACA` , `historia_clinica`.`TEMPERATURA` " _
                    & ", `historia_clinica`.`TANNER_A` , `historia_clinica`.`TANNER_B` , `historia_clinica`.`TANNER_P` , `historia_clinica`.`TANNER_VT` , " _
                    & "`historia_clinica`.`TANNER_LP` ,`historia_clinica`.`RECOMENDACIONES` , `historia_clinica`.`DIAGNOSTICO`,`historia_clinica`.`PLAN_SEGUIR` " _
                    & ", `historia_clinica`.FORMULACION , `historia_clinica`.LABORATORIOS ,`historia_clinica`.OTROS_ESTUDIOS , especialistas.`FIRMA` 	" _
                    & ",especialistas.`REGISTRO_MEDICO` , ordenes.id_empleado FROM `ordenes` 	INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) " _
                    & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                    & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                    & "INNER JOIN detalle_orden ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`)  " _
                    & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) INNER JOIN cups ON (detalle_orden.`CODIGO_CUPS`= cups.`CODIGO_CUPS`) " _
                    & "WHERE  detalle_orden.id='" & IDDetalleOrden & "'")
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
        Public Function DatosEncabezado(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT 	usuarios.`ID` , CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                    & "	,CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION 	,`usuarios`.`SEXO` 	,TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD " _
                    & "	, `usuarios`.`TELEFONO` ,`usuarios`.`DIRECCION` ,`ordenes`.`ID` AS ID_ORDEN ,`historia_clinica`.`FECHA_HISTORIA` ,`entidades`.`NOMBRE_ENTIDAD`	,especialistas.`NOMBRE` " _
                    & ", especialistas.`ESPECIALIDAD` ,cups.`NOMBRE_CUPS`,`historia_clinica`.`CODIGO_HISTORIA` AS NUMERO_HISTORIA FROM `ordenes` INNER JOIN `historia_clinica` ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) " _
                    & "	INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) 	INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                    & "	INNER JOIN detalle_orden ON(`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) INNER JOIN antecedentes ON(`ordenes`.`ID_usuario` = `antecedentes`.`ID_usuario`) " _
                    & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) INNER JOIN cups ON (detalle_orden.`CODIGO_CUPS`= cups.`CODIGO_CUPS`) " _
                    & "WHERE  detalle_orden.id='" & IDDetalleOrden & "'")
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

        Public Sub Guardar(ByVal _ImpresionHistoria As ImpresionHistoria)
            Try
                'Dim query As String

                Dim sql As String = "insert into impresion_historia " _
                                    & "(ID,ID_ORDEN,ID_DETALLE_ORDEN,NUMERO_HISTORIA,NOMBRE,IDENTIFICACION,EDAD,SEXO,ESTADO_CIVIL,TELEFONO,DIRECCION,ENTIDAD,FECHA_INGRESO,FECHA_ATENCION,MOTIVO_CONSULTA,ANTECEDENTES_FAMILIARES,ANTECEDENTES_PERSONALES,ENFERMEDAD_ACTUAL,REVISIONXSISTEMAS,PLAN_SEGUIR,DIAGNOSTICO,RECOMENDACIONES,FIRMA,MEDICO,ESPECIALIDAD,REGISTRO_MEDICO,ID_EMPLEADO) " _
                                    & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

                _conn = ConexionODBC.Open()

                Dim Comando As New OdbcCommand(sql, _conn)
                Dim Imag As Byte()
                Imag = _funciones.Imagen_Bytes(_ImpresionHistoria.Firma)

                Comando.Parameters.AddWithValue(1, Val(_ImpresionHistoria.Id))
                Comando.Parameters.AddWithValue(2, _ImpresionHistoria.IdOrden)
                Comando.Parameters.AddWithValue(3, _ImpresionHistoria.IdDetalleOrden)
                Comando.Parameters.AddWithValue(4, _ImpresionHistoria.NumeroHistoria)
                Comando.Parameters.AddWithValue(5, _ImpresionHistoria.Nombre)
                Comando.Parameters.AddWithValue(6, _ImpresionHistoria.Identificacion)
                Comando.Parameters.AddWithValue(7, _ImpresionHistoria.Edad)
                Comando.Parameters.AddWithValue(8, _ImpresionHistoria.Sexo)
                Comando.Parameters.AddWithValue(9, _ImpresionHistoria.EstadoCivil)
                Comando.Parameters.AddWithValue(10, _ImpresionHistoria.Telefono)
                Comando.Parameters.AddWithValue(11, _ImpresionHistoria.Direccion)
                Comando.Parameters.AddWithValue(12, _ImpresionHistoria.Entidad)
                Comando.Parameters.AddWithValue(13, _ImpresionHistoria.FechaIngreso)
                Comando.Parameters.AddWithValue(14, _ImpresionHistoria.FechaAtencion)
                Comando.Parameters.AddWithValue(15, _ImpresionHistoria.MotivoConsulta)
                Comando.Parameters.AddWithValue(16, _ImpresionHistoria.AntecedentesFamiliares)
                Comando.Parameters.AddWithValue(17, _ImpresionHistoria.AntecedentesPersonales)
                Comando.Parameters.AddWithValue(18, _ImpresionHistoria.EnfermedadActual)
                Comando.Parameters.AddWithValue(19, _ImpresionHistoria.RevisionxSistemas)
                Comando.Parameters.AddWithValue(20, _ImpresionHistoria.PlanSeguir)
                Comando.Parameters.AddWithValue(21, _ImpresionHistoria.Diagnostico)
                Comando.Parameters.AddWithValue(22, _ImpresionHistoria.Recomendaciones)
                Comando.Parameters.AddWithValue(23, Imag)
                Comando.Parameters.AddWithValue(24, _ImpresionHistoria.Medico)
                Comando.Parameters.AddWithValue(25, _ImpresionHistoria.Especialidad)
                Comando.Parameters.AddWithValue(26, _ImpresionHistoria.RegistroMedico)
                Comando.Parameters.AddWithValue(27, _ImpresionHistoria.IdEmpleado)

                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function VistaPreviaHistoriaDiagnosticos(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `historia_diagnosticos`.`ID_DIAGNOSTICO` AS CODIGO, " _
                                      & "`diagnosticos`.`NOMBRE_DIAGNOSTICO` AS DIAGNOSTICO, " _
                                      & "`historia_diagnosticos`.`DESCRIPCION` FROM `historia_diagnosticos` " _
                                      & "INNER JOIN `diagnosticos` ON " _
                                      & "(`historia_diagnosticos`.`ID_DIAGNOSTICO` = `diagnosticos`.`CODIGO_DIAGNOSTICO`) " _
                                      & "WHERE (`historia_diagnosticos`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "')")
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
        Public Function VistaPreviaHistoriaRXS(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `revision_sistemas`.`NOMBRE`, " _
                                      & "`historia_rxs`.`DESCRIPCION` FROM `historia_rxs` " _
                                      & "INNER JOIN `revision_sistemas` ON " _
                                      & "(`historia_rxs`.`ID_RXS` = `revision_sistemas`.`ID`) " _
                                      & "WHERE (`historia_rxs`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "');")
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
        Public Function VistaPreviaHistoriaLaboratorios(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `historia_laboratorios`.`ID_LABORATORIO` AS CUPS, " _
                                      & "`cups`.`NOMBRE_CUPS` AS NOMBRE, " _
                                      & "`historia_laboratorios`.`DESCRIPCION` FROM `historia_laboratorios` " _
                                      & "INNER JOIN `cups` ON " _
                                      & "(`historia_laboratorios`.`ID_LABORATORIO` = `cups`.`CODIGO_CUPS`) " _
                                      & "WHERE (`historia_laboratorios`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "')")
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
        Public Function VistaPreviaHistoriaOtrosEstudios(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `historia_procedimientos`.`ID_PROCEDIMIENTO` AS CUPS, " _
                                      & "`cups`.`NOMBRE_CUPS` AS NOMBRE, `historia_procedimientos`.`DESCRIPCION` " _
                                      & "FROM `historia_procedimientos` INNER JOIN `cups` ON " _
                                      & "(`historia_procedimientos`.`ID_PROCEDIMIENTO` = `cups`.`CODIGO_CUPS`) " _
                                      & "WHERE (`historia_procedimientos`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "')")
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
        Public Function VistaPreviaHistoriaFormulacion(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `historia_medicamentos`.`CANTIDAD`, `medicamentos`.`NOMBRE`, " _
                                      & "`historia_medicamentos`.`DOSIS`, `historia_medicamentos`.`DESCRIPCION` " _
                                      & "FROM `historia_medicamentos` INNER JOIN `medicamentos` ON " _
                                      & "(`historia_medicamentos`.`ID_MEDICAMENTO` = `medicamentos`.`ID`) WHERE " _
                                      & "(`historia_medicamentos`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "')")
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
        Public Function VistaPreviaHistoriaDetalle(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String

                query = String.Format("SELECT `historia_detalle`.`FUNCION_ESCROTAL`, `historia_detalle`.`MICRO_PENE`, " _
                                      & "`historia_detalle`.`MEATUS_URETRAL`, `historia_detalle`.`TESTICULO_IZQUIERDO`, " _
                                      & "`historia_detalle`.`TESTICULO_DERECHO`, `escala_prader`.`NOMBRE` AS ESCALA_PRADER " _
                                      & "FROM `historia_detalle` INNER JOIN `escala_prader` ON " _
                                      & "(`historia_detalle`.`ID_ESCALA_PRADER` = `escala_prader`.`ID`) " _
                                      & "WHERE (`historia_detalle`.`ID_DETALLE_ORDEN` ='" & IDDetalleOrden & "');")
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

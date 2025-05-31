Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DImpresion
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ExisteIDOrden(ByVal IdOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id_Orden FROM impresion WHERE id_orden='" & IdOrden & "'")
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
        Public Function ExisteIDDetalleOrden(ByVal IdDetalleOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id_detalle_Orden FROM impresion WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Sub GuardarHistoria(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "INSERT INTO impresion (id, fecha, id_orden, id_detalle_orden, consecutivo, identificacion, nombre, edad, sexo, estado_civil " _
                    & ", telefono, direccion, correo, contrato, entidad, sub_entidad, tipo_estudio, codigo_historia, responsables, MOTIVO_CONSULTA " _
                    & ", consulta_control, ENFERMEDAD_ACTUAL, revision_sistemas, EXAMEN_FISICO, peso, talla, TENSION_ARTERIAL, FRECUENCIA_CARDIACA " _
                    & ", FRECUENCIA_RESPIRATORIA, PLAN_SEGUIR, FORMULACION, laboratorios, OTROS_ESTUDIOS, tanner_a, tanner_b, tanner_p, tanner_vt " _
                    & ", tanner_lp, recomendaciones, TEMPERATURA, fecha_estudio	, diagnostico,codigo_cie10, nombre_cie10, medico, especialidad " _
                    & ", REGISTRO_MEDICO, firma	) SELECT '' AS ID ,CURDATE() AS  FECHA_IMPRESION ,ordenes.`ID` AS IDORDEN " _
                    & ",detalle_orden.`ID` AS ID_DETALLE_ORDEN ,ordenes.`CONSECUTIVO`,CONCAT(usuarios.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION " _
                    & ",CONCAT(usuarios.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE_USUARIO " _
                    & ",CONCAT(YEAR (CURDATE()) - YEAR (usuarios.`FECHA_NACIMIENTO`) - IF (MONTH (CURDATE()) < MONTH ( usuarios.`FECHA_NACIMIENTO`), 1, " _
                    & "IF ( MONTH (CURDATE()) = MONTH (usuarios.`FECHA_NACIMIENTO`), IF ( DAY (CURDATE()) < DAY (usuarios.`FECHA_NACIMIENTO`),1,0 ),0)),' AÑOS ' " _
                    & ",MONTH (CURDATE()) - MONTH (usuarios.`FECHA_NACIMIENTO`) + 12 * 	IF (MONTH (CURDATE()) < MONTH (usuarios.`FECHA_NACIMIENTO`), 1, " _
                    & "IF (MONTH (CURDATE())= MONTH (usuarios.`FECHA_NACIMIENTO`),IF (DAY (CURDATE())< DAY(usuarios.`FECHA_NACIMIENTO`),1,0),0)) " _
                    & "- IF (MONTH (CURDATE())<> MONTH (usuarios.`FECHA_NACIMIENTO`),(DAY (CURDATE())< DAY (usuarios.`FECHA_NACIMIENTO`)), " _
                    & "IF (DAY (CURDATE())<DAY (usuarios.`FECHA_NACIMIENTO`),1,0 )),' MESES') AS EDAD ,usuarios.`SEXO` ,usuarios.`ESTADO_CIVIL` " _
                    & ",usuarios.`TELEFONO`	,usuarios.`DIRECCION`,usuarios.`CORREO_ELECTRONICO`	,contratos.`NOMBRE` AS CONTRATO " _
                    & ",entidades.`NOMBRE_ENTIDAD` AS ENTIDAD,subentidades.`nombre` AS SUBENTIDAD,tipo_estudio.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO	" _
                    & "	,historia_clinica.`CODIGO_HISTORIA` AS CODIGO_HISTORIA,historia_clinica.`RESPONSABLES` AS RESPONSABLES" _
                    & ",historia_clinica.`MOTIVO_CONSULTA` AS MOTIVO_CONSULTA,historia_clinica.`CONSULTA_CONTROL` AS CONSULTA_CONTROl " _
                    & ",historia_clinica.`ENFERMEDAD_ACTUAL` AS ENFERMEDAD_ACTUAL,historia_clinica.`REVISIONXSISTEMAS` as REVSION_SISTEMAS " _
                    & ",historia_clinica.`EXAMEN_FISICO` AS EXAMEN_FISICO,historia_clinica.`PESO` AS PESO,historia_clinica.`TALLA` AS TALLA " _
                    & ",historia_clinica.`TENSION_ARTERIAL` AS TENSION_ARTERIAL	,historia_clinica.`FRECUENCIA_CARDIACA` AS FRECUENCIA_CARDIACA " _
                    & ",historia_clinica.`FRECUENCIA_RESPIRATORIA` AS FRECUENCIA_RESPIRATORIA,historia_clinica.`PLAN_SEGUIR` AS PLAN_SEGUIR " _
                    & ",historia_clinica.`FORMULACION` AS FORMULACION,historia_clinica.`LABORATORIOS` AS LABORATORIOS " _
                    & ",historia_clinica.`OTROS_ESTUDIOS` AS OTROS_ESTUDIOS	,historia_clinica.`TANNER_A` AS TA ,historia_clinica.`TANNER_b` AS TB " _
                    & ",historia_clinica.`TANNER_p` AS TP,historia_clinica.`TANNER_VT` AS TVT,historia_clinica.`TANNER_LP` AS TLP " _
                    & ",historia_clinica.`RECOMENDACIONES` AS RECOMENDACIONES,historia_clinica.`TEMPERATURA` AS TEMPERATURA " _
                    & ",historia_clinica.`FECHA_HISTORIA` AS FECHA_ESTUDIO ,historia_clinica.`DIAGNOSTICO` AS DIAGNOSTICO " _
                    & ",detalle_orden.`DIAGNOSTICO1` AS CODIGO_CIE10 ,diagnosticos.`NOMBRE_DIAGNOSTICO` AS NOMBRE_CIE10	,especialistas.`NOMBRE` AS MEDICO " _
                    & ",especialistas.`ESPECIALIDAD`,especialistas.`REGISTRO_MEDICO`,especialistas.`FIRMA` FROM detalle_orden " _
                    & "INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                    & "INNER JOIN usuarios ON (ordenes.`ID_USUARIO`=usuarios.`ID`) " _
                    & "INNER JOIN contratos ON (ordenes.`ID_CONTRATO` =contratos.`ID`)" _
                    & "INNER JOIN entidades ON (contratos.`CODIGO_ENTIDAD`=entidades.`CODIGO_ENTIDAD`) " _
                    & "INNER JOIN subentidades ON(ordenes.`ID_SUBENTIDAD`=subentidades.`id`) " _
                    & "INNER JOIN tipo_estudio ON (detalle_orden.`ID_TIPO_ESTUDIO`=tipo_estudio.`ID`) " _
                    & "INNER JOIN Historia_clinica ON (ordenes.`ID`=historia_clinica.`ID_ORDEN`) " _
                    & "INNER JOIN diagnosticos ON (detalle_orden.`DIAGNOSTICO1`=diagnosticos.`CODIGO_DIAGNOSTICO`) " _
                    & "INNER JOIN especialistas ON (ordenes.`ID_EMPLEADO`=especialistas.`ID_ESPECIALISTA`)	" _
                    & "WHERE ordenes.id='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarImpresion(ByVal IdOrden As String, ByVal TipoEstudio As String)
            Try
                Dim query As String
                'Query Encabezado Reporte
                query = "INSERT INTO impresion (id, fecha, id_orden, id_detalle_orden, consecutivo, identificacion, nombre, edad, sexo, estado_civil " _
                        & ", telefono, direccion, correo, contrato, entidad, sub_entidad, tipo_estudio, medico, especialidad, REGISTRO_MEDICO, firma, id_licencia) " _
                        & "SELECT '0' AS ID, CURDATE() AS  FECHA_IMPRESION 	,ordenes.`ID` AS IDORDEN ,detalle_orden.`ID` AS ID_DETALLE_ORDEN " _
                        & ",ordenes.`CONSECUTIVO`,CONCAT(usuarios.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION " _
                        & ",CONCAT(usuarios.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE_USUARIO" _
                        & ",CONCAT(YEAR (CURDATE()) - YEAR (usuarios.`FECHA_NACIMIENTO`) - IF (MONTH (CURDATE()) < MONTH ( usuarios.`FECHA_NACIMIENTO`)" _
                        & ", 1, IF ( MONTH (CURDATE()) = MONTH (usuarios.`FECHA_NACIMIENTO`), IF ( DAY (CURDATE()) < DAY (usuarios.`FECHA_NACIMIENTO`),1,0 ),0)),' AÑOS '" _
                        & ",MONTH (CURDATE()) - MONTH (usuarios.`FECHA_NACIMIENTO`) + 12 * 	IF (MONTH (CURDATE()) < MONTH (usuarios.`FECHA_NACIMIENTO`), 1, " _
                        & " IF (MONTH (CURDATE())= MONTH (usuarios.`FECHA_NACIMIENTO`),IF (DAY (CURDATE())< DAY(usuarios.`FECHA_NACIMIENTO`),1,0),0)) - IF (MONTH (CURDATE())<> MONTH (usuarios.`FECHA_NACIMIENTO`) " _
                        & ",(DAY (CURDATE())< DAY (usuarios.`FECHA_NACIMIENTO`)), IF (DAY (CURDATE())<DAY (usuarios.`FECHA_NACIMIENTO`),1,0 )),' MESES') AS EDAD " _
                        & ",usuarios.`SEXO` ,usuarios.`ESTADO_CIVIL` ,usuarios.`TELEFONO`,usuarios.`DIRECCION`,usuarios.`CORREO_ELECTRONICO`,contratos.`NOMBRE` AS CONTRATO " _
                        & "	,entidades.`NOMBRE_ENTIDAD` AS ENTIDAD,subentidades.`nombre` AS SUBENTIDAD,tipo_estudio.`NOMBRE_TIPO_ESTUDIO` AS ESTUDIO,especialistas.`NOMBRE` AS MEDICO " _
                        & "	,especialistas.`ESPECIALIDAD`,especialistas.`REGISTRO_MEDICO`,especialistas.`FIRMA`,contratos.`ID_LICENCIA` FROM detalle_orden 	INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                        & "	INNER JOIN usuarios ON (ordenes.`ID_USUARIO`=usuarios.`ID`) INNER JOIN contratos ON (ordenes.`ID_CONTRATO` =contratos.`ID`)	INNER JOIN entidades ON (contratos.`CODIGO_ENTIDAD`=entidades.`CODIGO_ENTIDAD`) " _
                        & "	INNER JOIN subentidades ON(ordenes.`ID_SUBENTIDAD`=subentidades.`id`) INNER JOIN tipo_estudio ON (detalle_orden.`ID_TIPO_ESTUDIO`=tipo_estudio.`ID`) " _
                        & "INNER JOIN especialistas ON (ordenes.`ID_EMPLEADO`=especialistas.`ID_ESPECIALISTA`)	WHERE detalle_orden.id_orden='" & IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                'Query Tipos de Estudios
                Select Case TipoEstudio
                    'HISTORIA CLINICA
                    Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                        query = "INSERT INTO impresion_historia (id, id_orden, id_detalle_orden, codigo_historia, responsables, MOTIVO_CONSULTA	, consulta_control, " _
                                & "ENFERMEDAD_ACTUAL, revision_sistemas, EXAMEN_FISICO, peso, talla, TENSION_ARTERIAL, FRECUENCIA_CARDIACA, FRECUENCIA_RESPIRATORIA, " _
                                & "PLAN_SEGUIR, FORMULACION, laboratorios, OTROS_ESTUDIOS, tanner_a, tanner_b, tanner_p, tanner_vt , tanner_lp, recomendaciones, " _
                                & "TEMPERATURA, fecha_estudio	, diagnostico,codigo_cie10, nombre_cie10) SELECT '0' AS ID ,ordenes.`ID` AS IDORDEN " _
                                & ",detalle_orden.`ID` AS ID_DETALLE_ORDEN 	,historia_clinica.`CODIGO_HISTORIA` AS CODIGO_HISTORIA ,historia_clinica.`RESPONSABLES` AS RESPONSABLES " _
                                & ",historia_clinica.`MOTIVO_CONSULTA` AS MOTIVO_CONSULTA ,historia_clinica.`CONSULTA_CONTROL` AS CONSULTA_CONTROl " _
                                & ",historia_clinica.`ENFERMEDAD_ACTUAL` AS ENFERMEDAD_ACTUAL ,historia_clinica.`REVISIONXSISTEMAS` AS REVSION_SISTEMAS " _
                                & ",historia_clinica.`EXAMEN_FISICO` AS EXAMEN_FISICO ,historia_clinica.`PESO` AS PESO ,historia_clinica.`TALLA` AS TALLA " _
                                & ",historia_clinica.`TENSION_ARTERIAL` AS TENSION_ARTERIAL	,historia_clinica.`FRECUENCIA_CARDIACA` AS FRECUENCIA_CARDIACA " _
                                & ",historia_clinica.`FRECUENCIA_RESPIRATORIA` AS FRECUENCIA_RESPIRATORIA ,historia_clinica.`PLAN_SEGUIR` AS PLAN_SEGUIR " _
                                & ",historia_clinica.`FORMULACION` AS FORMULACION ,historia_clinica.`LABORATORIOS` AS LABORATORIOS 	,historia_clinica.`OTROS_ESTUDIOS` AS OTROS_ESTUDIOS" _
                                & ",historia_clinica.`TANNER_A` AS TA 	,historia_clinica.`TANNER_b` AS TB 	,historia_clinica.`TANNER_p` AS TP	,historia_clinica.`TANNER_VT` AS TVT " _
                                & ",historia_clinica.`TANNER_LP` AS TLP ,historia_clinica.`RECOMENDACIONES` AS RECOMENDACIONES	,historia_clinica.`TEMPERATURA` AS TEMPERATURA " _
                                & ",historia_clinica.`FECHA_HISTORIA` AS FECHA_ESTUDIO 	,historia_clinica.`DIAGNOSTICO` AS DIAGNOSTICO	,detalle_orden.`DIAGNOSTICO1` AS CODIGO_CIE10 " _
                                & "	,diagnosticos.`NOMBRE_DIAGNOSTICO` AS NOMBRE_CIE10 FROM detalle_orden INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                                & "INNER JOIN historia_clinica ON (ordenes.`ID`=historia_clinica.`ID_ORDEN`) INNER JOIN diagnosticos ON (detalle_orden.`DIAGNOSTICO1`=diagnosticos.`CODIGO_DIAGNOSTICO`) " _
                                & "WHERE detalle_orden.id_orden='" & IdOrden & "'"
                    'GASTROENTEROLOGIA
                    Case "ENDOSCOPIA", "COLONOSCOPIA", "RECTOSCOPIA"
                        query = "INSERT INTO impresion_endoscopia(id, id_orden, id_detalle_orden, estudio, medico_solicita, indicacion, medicamentos, equipo, " _
                                & "anestesiologo, PROCEDIMIENTO_TERAPEUTICO	,campo1, campo2, campo3, campo4, campo5, campo6, diagnostico, codigo_diagnostico, " _
                                & "nombre_diagnostico) SELECT '' AS ID 	,ordenes.`ID` AS IDORDEN ,detalle_orden.`ID` AS ID_DETALLE_ORDEN ,endoscopias.id AS ESTUDIO " _
                                & ",endoscopias.`MEDICO_SOLICITA` ,endoscopias.`INDICACION`	,endoscopias.`MEDICAMENTOS`	,CONCAT(equipos.`NOMBRE`, ' ' ,equipos.`MODELO`) AS EQUIPO " _
                                & ",endoscopias.`ANESTESIOLOGO`	,procedimientos_terapeuticos.`NOMBRE` AS PROCEDIMIENTO_TERAPEUTICO,endoscopias.`CAMPO1`	,endoscopias.`CAMPO2`" _
                                & ",endoscopias.`CAMPO3`,endoscopias.`CAMPO4`,endoscopias.`CAMPO5`,endoscopias.`CAMPO6`	,endoscopias.`DIAGNOSTICO`	,endoscopias.`CODIGO_DIAGNOSTICO` " _
                                & ",diagnosticos.`NOMBRE_DIAGNOSTICO` FROM detalle_orden INNER JOIN ordenes ON (detalle_orden.`ID_ORDEN`=ordenes.`ID`) " _
                                & "INNER JOIN endoscopias ON (ordenes.`ID`=endoscopias.`ID_ORDEN`) INNER JOIN equipos ON (endoscopias.`ID_EQUIPO`=equipos.`ID`)" _
                                & "INNER JOIN procedimientos_terapeuticos ON(endoscopias.`ID_PROCEDIMIENTO_TERAPEUTICO`=procedimientos_terapeuticos.id)" _
                                & "INNER JOIN diagnosticos ON (detalle_orden.`DIAGNOSTICO1`=diagnosticos.`CODIGO_DIAGNOSTICO`) 	WHERE ordenes.id='" & IdOrden & "'"
                End Select
                _conn = ConexionODBC.Open()
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace

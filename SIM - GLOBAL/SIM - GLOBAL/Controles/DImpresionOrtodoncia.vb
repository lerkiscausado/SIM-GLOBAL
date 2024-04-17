Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Namespace Controles
    Public Class DImpresionOrtodoncia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Function VistaPreviaOrtodoncia(ByVal IDDetalleOrden As String) As DataSet
            Try
                Dim query As String
                query = String.Format("SELECT usuarios.`ID` , CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE  " _
                    & ",CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION ,`usuarios`.`SEXO` " _
                    & ",TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, `usuarios`.`TELEFONO`,`usuarios`.`DIRECCION` " _
                    & ",`ordenes`.`ID` AS ID_ORDEN, ortodoncia.`FECHA`,contratos.`NOMBRE` ,especialistas.`NOMBRE` , especialistas.`ESPECIALIDAD` ,cups.`NOMBRE_CUPS`	" _
                    & ", especialistas.`FIRMA`	, especialistas.`REGISTRO_MEDICO` " _
                    & ", ordenes.id_empleado ,ortodoncia.`MOTIVO_CONSULTA` ,ortodoncia.`RESPONSABLES` ,ortodoncia.`ANTECEDENTES_PATOLOGICOS` " _
                    & ",ortodoncia.`PERFIL`	,ortodoncia.`FRENTE`,ortodoncia.`HIPOTONIA`	,ortodoncia.`HIPERTONIA`,ortodoncia.`MACROQUELIA` " _
                    & ",ortodoncia.`MICROQUELIA` ,ortodoncia.`PROQUELIA`,ortodoncia.`RETROQUELIA` ,ortodoncia.`FRENILLO_LABIAL_SUPERIOR`	,ortodoncia.`FRENILLO_LABIAL_INFERIOR` " _
                    & ",ortodoncia.`FRENILLO_LINGUAL` ,ortodoncia.`RESPIRACION_BUCAL` ,ortodoncia.`USO_CHUPO` ,ortodoncia.`BRUXOMANIA` ,ortodoncia.`SUCCION_DIGITAL` " _
                    & " ,ortodoncia.`SUCCION_LABIAL` ,ortodoncia.`DEGLUCION_INFANTIL` ,ortodoncia.`ONICOFAGIA` ,ortodoncia.`EMPUJE_LINGUAL`" _
                    & ",ortodoncia.`MORDER_OBJETO` ,ortodoncia.`EVALUACION_HABITO` ,ortodoncia.`FONACION` ,ortodoncia.`INTERPRETACION_CEFALOMETRICA` " _
                    & ",ortodoncia.`DIAGNOSTICO` ,ortodoncia.`PRONOSTICO`, ortodoncia.`PLAN_TRATAMIENTO` ,ortodoncia.`APARATOLOGIA` ,ortodoncia.`PRESUPUESTO` " _
                    & ",ortodoncia.`ACTIVIDAD_REALIZADA` ,ortodoncia.`PROXIMA_CITA`	 FROM 	`detalle_orden` " _
                    & "INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                    & "INNER JOIN `ortodoncia` ON (`detalle_orden`.`ID` = `ortodoncia`.`ID_DETALLE_ORDEN`) 	" _
                    & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                    & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) 	" _
                    & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                    & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) 	" _
                    & "INNER JOIN cups ON (detalle_orden.`CODIGO_CUPS`= cups.`CODIGO_CUPS`) " _
                    & "WHERE detalle_orden.id='" & IDDetalleOrden & "'")
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

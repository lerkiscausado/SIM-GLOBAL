Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DImpresionHistoria
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones

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
        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String
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
                              & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) WHERE  detalle_orden.id='" & filtro & "'")

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

        Public Sub Guardar(ByVal IdOrden As String, ByVal IdEmpleado As String)
            Try
                Dim query As String
                query = "INSERT INTO impresion_historia (SELECT '' AS ID, `historia_clinica`.`ID_ORDEN`, " _
                        & "`historia_clinica`.`FECHA`, `historia_clinica`.`REPORTE_EVOLUCION`, " _
                        & "`empleados`.`NOMBRE_EMPLEADO`, `empleados`.`REGISTRO_MEDICO`, " _
                        & "`especialidades`.`NOMBRE_ESPECIALIDAD`, `empleados`.`FIRMA`,'" & IdEmpleado & "',empleados.id " _
                        & "FROM `historia_clinica` INNER JOIN `empleados` ON (`historia_clinica`.`ID_EMPLEADO` = `empleados`.`ID`) " _
                        & "INNER JOIN `especialidades` ON (`empleados`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) " _
                        & "WHERE (`historia_clinica`.`CITA` ='C' AND historia_clinica.id_orden='" & IdOrden & "') " _
                        & "ORDER BY empleados.`ID`, especialidades.`ID`, historia_clinica.`fecha` ASC)"
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

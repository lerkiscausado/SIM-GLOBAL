Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Namespace Controles
    Public Class DImpresionDetalleHistoria
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Sub GuardarImpresionDetalleHistoria(ByVal Filtro As String, ByVal Empleado As String, ByVal Tabla As String)
            Try
                Dim query As String
                'Guardar detalle Historia
                Select Case Tabla
                    Case "L"
                        query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID    ,`ordenes`.`ID` AS ID_ORDEN    , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS ,'' AS CIE10 " _
                    & ",'' AS DIAGNOSTICO, `historia_laboratorios`.`ID_LABORATORIO` AS CUPS , `cups`.`NOMBRE_CUPS` ,'' AS NOMBRE_MEDICAMENTO,'' AS VIA,'' AS DOSIS ,'' AS CANTIDAD " _
                    & ", `historia_laboratorios`.`DESCRIPCION` AS DESCRIPCION ,'L' AS TABLA  ,'" & Empleado & "' AS ID_EMPLEADO FROM  `ordenes` INNER JOIN `historia_laboratorios` " _
                    & "ON (`ordenes`.`ID` = `historia_laboratorios`.`ID_ORDEN`)  INNER JOIN `cups` ON (`historia_laboratorios`.`ID_LABORATORIO` = `cups`.`CODIGO_CUPS`) INNER JOIN `detalle_orden` " _
                    & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `ordenes`.`ID`='" & Filtro & "'"
                    Case "M"
                        query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID  ,`ordenes`.`ID` AS ID_ORDEN , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS  ,'' AS CIE10 " _
                            & ",'' AS DIAGNOSTICO    , '' AS CUPS , '' AS NOMBRE_CUPS , medicamentos.`NOMBRE` AS NOMBRE_MEDICAMENTO ,via_administracion.`NOMBRE` AS VIA " _
                            & ",historia_medicamentos.`DOSIS` AS DOSIS  ,historia_medicamentos.`CANTIDAD` AS CANTIDAD , historia_medicamentos.`DESCRIPCION` AS DESCRIPCION  ,'M' AS TABLA " _
                            & ",'" & Empleado & "' AS ID_EMPLEADO FROM  `ordenes`   INNER JOIN `historia_medicamentos`   ON (`ordenes`.`ID` = historia_medicamentos.`ID_ORDEN`)  INNER JOIN medicamentos " _
                            & "ON(historia_medicamentos.`ID_MEDICAMENTO`=medicamentos.`ID`) INNER JOIN via_administracion   ON(historia_medicamentos.`ID_VIA_ADMINISTRACION`=via_administracion.`ID`) " _
                            & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `ordenes`.`ID`='" & Filtro & "'"
                    Case "O"
                        query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID  ,`ordenes`.`ID` AS ID_ORDEN , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS ,'' AS CIE10 " _
                            & ",'' AS DIAGNOSTICO , historia_procedimientos.`ID_PROCEDIMIENTO` AS CUPS , `cups`.`NOMBRE_CUPS` ,'' AS NOMBRE_MEDICAMENTO ,'' AS VIA ,'' AS DOSIS ,'' AS CANTIDAD " _
                            & ", historia_procedimientos.`DESCRIPCION` AS DESCRIPCION ,'O' AS TABLA ,'" & Empleado & "' AS ID_EMPLEADO FROM `ordenes`  INNER JOIN historia_procedimientos " _
                            & "ON (`ordenes`.`ID` = historia_procedimientos.`ID_ORDEN`)    INNER JOIN `cups`  ON (historia_procedimientos.`ID_PROCEDIMIENTO` = `cups`.`CODIGO_CUPS`) " _
                            & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `ordenes`.`ID`='" & Filtro & "'"
                End Select

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarDetalleHistoriaGlobal(ByVal IDDetalleOrden As String, ByVal IDEmpleado As String)
            Try
                Dim query As String
                'Guardar RXS
                query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID ,`ordenes`.`ID` AS ID_ORDEN, `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,revision_sistemas.`NOMBRE` AS RXS ,'' AS CIE10 " _
                    & ",'' AS DIAGNOSTICO , '' AS CUPS , '' AS NOMBRE_CUPS , '' AS NOMBRE_MEDICAMENTO,'' AS VIA ,'' AS DOSIS ,'' AS CANTIDAD , historia_rxs.`DESCRIPCION` AS DESCRIPCION ,'R' AS TABLA " _
                    & ",'" & IDEmpleado & "' AS ID_EMPLEADO FROM `ordenes`  INNER JOIN `historia_rxs` ON (`ordenes`.`ID` = historia_rxs.`ID_ORDEN`) INNER JOIN revision_sistemas " _
                    & "ON(historia_rxs.`ID_RXS`=revision_sistemas.`ID`) INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `detalle_orden`.`ID`='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                'Guardar DIAGNOSTICO
                query = "INSERT INTO impresion_detalle_historia SELECT	0 AS ID ,`ordenes`.`ID` AS ID_ORDEN , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS, historia_diagnosticos.`ID_DIAGNOSTICO` AS CIE10 " _
                        & ",diagnosticos.`NOMBRE_DIAGNOSTICO` AS DIAGNOSTICO , '' AS CUPS , '' AS NOMBRE_CUPS, '' AS NOMBRE_MEDICAMENTO,'' AS VIA ,'' AS DOSIS ,'' AS CANTIDAD " _
                        & ", historia_diagnosticos.`DESCRIPCION` AS DESCRIPCION ,'D' AS TABLA ,'" & IDEmpleado & "' AS ID_EMPLEADO FROM `ordenes` INNER JOIN `historia_diagnosticos` " _
                        & "ON (`ordenes`.`ID` = historia_diagnosticos.`ID_ORDEN`) INNER JOIN diagnosticos ON(historia_diagnosticos.`ID_DIAGNOSTICO`=diagnosticos.`CODIGO_DIAGNOSTICO`) " _
                        & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `detalle_orden`.`ID`='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                'Guardar MEDICAMENTOS
                query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID  ,`ordenes`.`ID` AS ID_ORDEN , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS  ,'' AS CIE10 " _
                            & ",'' AS DIAGNOSTICO    , '' AS CUPS , '' AS NOMBRE_CUPS , medicamentos.`NOMBRE` AS NOMBRE_MEDICAMENTO ,via_administracion.`NOMBRE` AS VIA " _
                            & ",historia_medicamentos.`DOSIS` AS DOSIS  ,historia_medicamentos.`CANTIDAD` AS CANTIDAD , historia_medicamentos.`DESCRIPCION` AS DESCRIPCION  ,'M' AS TABLA " _
                            & ",'" & IDEmpleado & "' AS ID_EMPLEADO FROM  `ordenes`   INNER JOIN `historia_medicamentos`   ON (`ordenes`.`ID` = historia_medicamentos.`ID_ORDEN`)  INNER JOIN medicamentos " _
                            & "ON(historia_medicamentos.`ID_MEDICAMENTO`=medicamentos.`ID`) INNER JOIN via_administracion   ON(historia_medicamentos.`ID_VIA_ADMINISTRACION`=via_administracion.`ID`) " _
                            & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `detalle_orden`.`ID`='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                'Guardar LABORATORIOS
                query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID    ,`ordenes`.`ID` AS ID_ORDEN    , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS ,'' AS CIE10 " _
                    & ",'' AS DIAGNOSTICO, `historia_laboratorios`.`ID_LABORATORIO` AS CUPS , `cups`.`NOMBRE_CUPS` ,'' AS NOMBRE_MEDICAMENTO,'' AS VIA,'' AS DOSIS ,'' AS CANTIDAD " _
                    & ", `historia_laboratorios`.`DESCRIPCION` AS DESCRIPCION ,'L' AS TABLA  ,'" & IDEmpleado & "' AS ID_EMPLEADO FROM  `ordenes` INNER JOIN `historia_laboratorios` " _
                    & "ON (`ordenes`.`ID` = `historia_laboratorios`.`ID_ORDEN`)  INNER JOIN `cups` ON (`historia_laboratorios`.`ID_LABORATORIO` = `cups`.`CODIGO_CUPS`) INNER JOIN `detalle_orden` " _
                    & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `detalle_orden`.`ID`='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                'Guardar OTROS ESTUDIOS
                query = "INSERT INTO impresion_detalle_historia  SELECT	0 AS ID  ,`ordenes`.`ID` AS ID_ORDEN , `detalle_orden`.`ID` AS ID_DETALLE_ORDEN ,'' AS RXS ,'' AS CIE10 " _
                            & ",'' AS DIAGNOSTICO , historia_procedimientos.`ID_PROCEDIMIENTO` AS CUPS , `cups`.`NOMBRE_CUPS` ,'' AS NOMBRE_MEDICAMENTO ,'' AS VIA ,'' AS DOSIS ,'' AS CANTIDAD " _
                            & ", historia_procedimientos.`DESCRIPCION` AS DESCRIPCION ,'O' AS TABLA ,'" & IDEmpleado & "' AS ID_EMPLEADO FROM `ordenes`  INNER JOIN historia_procedimientos " _
                            & "ON (`ordenes`.`ID` = historia_procedimientos.`ID_ORDEN`)    INNER JOIN `cups`  ON (historia_procedimientos.`ID_PROCEDIMIENTO` = `cups`.`CODIGO_CUPS`) " _
                            & "INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE `detalle_orden`.`ID`='" & IDDetalleOrden & "'"
                _conn = ConexionODBC.Open()
                comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleHistoria(ByVal IdEmpleado As String)
            Try
                Dim query As String
                query = "DELETE FROM impresion_detalle_historia WHERE id_empleado='" & IdEmpleado & "'"
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


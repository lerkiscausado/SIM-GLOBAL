Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Namespace Controles
    Public Class DImpresionCitoPato
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Function VistaPreviaPatologia(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String
                query = String.Format("SELECT `usuarios`.`ID`, " _
                    & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                    & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION, " _
                    & "`usuarios`.`SEXO`, " _
                    & "TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, " _
                    & "`usuarios`.`TELEFONO`, " _
                    & "`usuarios`.`DIRECCION`, " _
                    & "`ordenes`.`ID` AS ID_ORDEN, " _
                    & "`ordenes`.`CONSECUTIVO`, " _
                    & "`entidades`.`NOMBRE_ENTIDAD`, " _
                    & "`especialistas`.`NOMBRE`, " _
                    & "`especialistas`.`ESPECIALIDAD`, " _
                    & "`patologia`.`FECHA_SALIDA`, " _
                    & "`patologia`.`TIPO_MUESTRA`, " _
                    & "`patologia`.`SITIO_LESION`, " _
                    & "`patologia`.`SOLICITADO`, " _
                    & "`patologia`.`DESCRIPCION_MACROSCOPICA`, " _
                    & "`patologia`.`DESCRIPCION_MICROSCOPICA`, " _
                    & "`patologia`.`DIAGNOSTICO`, " _
                    & "`patologia`.`OBSERVACIONES` " _
                    & "FROM `usuarios` INNER JOIN `ordenes` ON (`usuarios`.`ID` = `ordenes`.`ID_USUARIO`) " _
                    & "INNER JOIN `patologia` ON (`ordenes`.`ID` = `patologia`.`ID_ORDEN`) " _
                    & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                    & "INNER JOIN `especialistas` ON (`patologia`.`ID_EMPLEADO` = `especialistas`.`ID_ESPECIALISTA`) " _
                    & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
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
    End Class

End Namespace

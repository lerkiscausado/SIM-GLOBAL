Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Namespace Controles

    Public Class DImpresionPatologia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Sub Eliminar(ByVal idOrden As String)
            Try
                Dim query As String
                If Existe(idOrden) = True Then
                    query = "DELETE FROM impresion_patologia WHERE idorden='" & idOrden & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Guardar(ByVal idOrden As String)
            Try
                Dim query As String
                If Existe(idOrden) = True Then
                    query = ""
                    'query = "UPDATE cups SET nombre_cups='" &
                    '_cups.Nombre & "', estado='" & _cups.Estado & "' where codigo_cups='" & _cups.Id & "'"
                Else
                    query = "INSERT INTO impresion_patologia SELECT  " _
                        & "0 AS ID, " _
                        & "`ordenes`.`ID` AS `IDORDEN`,  " _
                        & "`ordenes`.`CONSECUTIVO` AS `CONSECUTIVO`,  " _
                        & "`ordenes`.`FECHA_INGRESO` AS `FECHA_INGRESO`,  " _
                        & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION`,  " _
                        & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `NOMBRE`,  " _
                        & "CONCAT(YEAR(CURDATE()) - YEAR(`usuarios`.`FECHA_NACIMIENTO`) - IF(MONTH(CURDATE()) < MONTH(`usuarios`.`FECHA_NACIMIENTO`),1,IF(MONTH(CURDATE()) = MONTH(`usuarios`.`FECHA_NACIMIENTO`),IF(DAYOFMONTH(CURDATE()) < DAYOFMONTH(`usuarios`.`FECHA_NACIMIENTO`),1,0),0)),CAST(' AÑOS ' AS CHAR CHARSET utf8),MONTH(CURDATE()) - MONTH(`usuarios`.`FECHA_NACIMIENTO`) + 12 * IF(MONTH(CURDATE()) < MONTH(`usuarios`.`FECHA_NACIMIENTO`),1,IF(MONTH(CURDATE()) = MONTH(`usuarios`.`FECHA_NACIMIENTO`),IF(DAYOFMONTH(CURDATE()) < DAYOFMONTH(`usuarios`.`FECHA_NACIMIENTO`),1,0),0)) - IF(MONTH(CURDATE()) <> MONTH(`usuarios`.`FECHA_NACIMIENTO`),DAYOFMONTH(CURDATE()) < DAYOFMONTH(`usuarios`.`FECHA_NACIMIENTO`),IF(DAYOFMONTH(CURDATE()) < DAYOFMONTH(`usuarios`.`FECHA_NACIMIENTO`),1,0)),' MESES') AS `EDAD`,  " _
                        & "`usuarios`.`SEXO` AS `SEXO`,  " _
                        & "`usuarios`.`ESTADO_CIVIL` AS `ESTADO_CIVIL`,  " _
                        & "`usuarios`.`TELEFONO` AS `TELEFONO`,  " _
                        & "`subentidades`.`nombre` AS `DIRECCION`,  " _
                        & "`entidades`.`nombre_entidad` AS `NOMBRE_ENTIDAD`,  " _
                        & "`patologia`.`TIPO_MUESTRA` AS `TIPO_MUESTRA`,  " _
                        & "`patologia`.`SITIO_LESION` AS `SITIO_LESION`,  " _
                        & "`patologia`.`SOLICITADO` AS `SOLICITADO`,  " _
                        & "`patologia`.`DESCRIPCION_MACROSCOPICA` AS `DESCRIPCION_MACROSCOPICA`,  " _
                        & "`patologia`.`DESCRIPCION_MICROSCOPICA` AS `DESCRIPCION_MICROSCOPICA`,  " _
                        & "`patologia`.`DIAGNOSTICO` AS `DIAGNOSTICO`,  " _
                        & "`patologia`.`OBSERVACIONES` AS `OBSERVACIONES`,  " _
                        & "`patologia`.`CODIGO_DIAGNOSTICO` AS `CODIGO_DIAGNOSTICO`,  " _
                        & "`diagnosticos`.`NOMBRE_DIAGNOSTICO` AS `nombre_diagnostico`,  " _
                        & "`contratos`.`ID_LICENCIA` AS `ID_LICENCIA`,  " _
                        & "`patologia`.`ID_EMPLEADO` AS `ID_EMPLEADO`,  " _
                        & "`especialistas`.`NOMBRE` AS `medico`,  " _
                        & "`especialistas`.`ESPECIALIDAD` AS `especialidad`,  " _
                        & "`especialistas`.`REGISTRO_MEDICO` AS `registro_medico`, " _
                        & "`especialistas`.`FIRMA` AS `firma`,  " _
                        & "`patologia`.`FECHA_SALIDA` AS `fecha_salida`,  " _
                        & "`sedes`.`DIRECCION` AS `sede` " _
                        & "FROM `ordenes`  	INNER JOIN `usuarios`  ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                        & "	INNER JOIN `contratos`  ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                        & "	INNER JOIN `patologia`  ON (`ordenes`.`ID` = `patologia`.`ID_ORDEN`) " _
                        & "	INNER JOIN `entidades`  ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                        & "	INNER JOIN `diagnosticos`  ON (`patologia`.`CODIGO_DIAGNOSTICO` = `diagnosticos`.`CODIGO_DIAGNOSTICO`) " _
                        & "	INNER JOIN `especialistas`  ON (`patologia`.`ID_EMPLEADO` = `especialistas`.`ID_ESPECIALISTA`) " _
                        & "	INNER JOIN `sedes`  ON (`ordenes`.`ID_SEDE` = `sedes`.`ID`) " _
                        & " INNER JOIN `subentidades` ON (`ordenes`.`id_subentidad` = `subentidades`.`id`)" _
                        & "WHERE ordenes.id='" & idOrden & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarPDF(ByVal idOrden As String, ByVal ruta As String)
            Try
                ' Leer el archivo PDF como arreglo de bytes
                Dim pdfBytes As Byte() = File.ReadAllBytes(ruta)

                ' Verificar si ya existe el registro en documentospdf
                Dim existe As Boolean = False
                Dim consulta As String = "SELECT COUNT(*) FROM documentospdf WHERE consecutivo = ?"
                _conn = ConexionODBC.Open()
                Using cmd As New OdbcCommand(consulta, _conn)
                    cmd.Parameters.AddWithValue("?", idOrden)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    existe = (count > 0)
                End Using

                If Not existe Then
                    ' Insertar el nuevo PDF si no existe
                    Dim insert As String = "INSERT INTO documentospdf (consecutivo, pdf) VALUES (?, ?)"
                    Using cmdInsert As New OdbcCommand(insert, _conn)
                        cmdInsert.Parameters.AddWithValue("?", idOrden)
                        cmdInsert.Parameters.Add("?", OdbcType.Binary, pdfBytes.Length).Value = pdfBytes
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End If

                ConexionODBC.Close(_conn)

            Catch ex As Exception
                MessageBox.Show("Error al guardar el PDF: " & ex.Message)
            End Try
        End Sub

        Public Function Existe(ByVal orden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT idorden FROM impresion_patologia WHERE idorden='" & orden & "'")
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


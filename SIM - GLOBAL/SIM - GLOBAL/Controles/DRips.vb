Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DRips
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar() As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `facturas`.`ID`, facturas.FACTURA	, `facturas`.`FECHA_FACTURA` AS FECHA, " _
                                                  & "`contratos`.`NOMBRE` AS CONTRATO, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD,`facturas`.`CONCEPTO` " _
                                                  & ", `facturas`.`VALOR` , `facturas`.`COPAGOS`,(`facturas`.`VALOR`-`facturas`.`COPAGOS`) AS NETO " _
                                                  & ",licencias.`CLIENTE` AS EMPRESA, facturas.ESTADO, facturas.tipo_factura AS TIPOFACTURA FROM `facturas` " _
                                                  & "INNER JOIN `contratos`    ON (`facturas`.`ID_CONTRATO` = `contratos`.`ID`)	INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD`=`entidades`.`CODIGO_ENTIDAD`) WHERE facturas.rips ='1'")
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
        Public Function Existe(ByVal IdFactura As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM factura_temporal WHERE id='" & IdFactura & "'")
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
                Return False
                'MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Function Agregar(ByVal IdFactura As String)
            Try

                Dim query As String =
                                    String.Format("CREATE TEMPORARY TABLE IF NOT EXISTS Factura_temporal " _
                                                  & "SELECT `facturas`.`ID`, facturas.FACTURA, `facturas`.`FECHA_FACTURA` AS FECHA " _
                                                  & ", `contratos`.`NOMBRE` AS CONTRATO	, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD " _
                                                  & ",`facturas`.`CONCEPTO`	, `facturas`.`VALOR` , `facturas`.`COPAGOS`	,(`facturas`.`VALOR`-`facturas`.`COPAGOS`) AS NETO " _
                                                  & ",licencias.`CLIENTE` AS EMPRESA, facturas.ESTADO, facturas.tipo_factura AS TIPOFACTURA FROM `facturas` " _
                                                  & "INNER JOIN `contratos`    ON (`facturas`.`ID_CONTRATO` = `contratos`.`ID`)	INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`) " _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD`=`entidades`.`CODIGO_ENTIDAD`)  WHERE facturas.id='" & IdFactura & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)



            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Function Usuarios(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `usuarios`.`ID_TIPO_IDENTIFICACION` , `usuarios`.`IDENTIFICACION`, " _
                                                  & "`contratos`.`CODIGO_ENTIDAD`, `usuarios`.`CODIGO_TIPO_USUARIO`, `usuarios`.`PRIMER_APELLIDO` " _
                                                  & ", `usuarios`.`SEGUNDO_APELLIDO`, `usuarios`.`PRIMER_NOMBRE`, `usuarios`.`SEGUNDO_NOMBRE`, " _
                                                  & "TIMESTAMPDIFF(YEAR,usuarios.`FECHA_NACIMIENTO`,CURDATE()) AS EDAD ,'1' AS MEDIDA, " _
                                                  & "usuarios.`SEXO` ,SUBSTRING(usuarios.`CODIGO_MUNICIPIO`, 1,2) AS DEPARTAMENTO , " _
                                                  & "SUBSTRING(usuarios.`CODIGO_MUNICIPIO`, 3,3) AS MUNICIPIO ,usuarios.`ZONA` , " _
                                                  & "`subentidades`.`nombre` FROM   `detalle_factura` INNER JOIN `ordenes` ON " _
                                                  & "(`detalle_factura`.`ID_ORDEN` = `ordenes`.`ID`) INNER JOIN `usuarios` ON " _
                                                  & "(`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON " _
                                                  & "(`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `entidades` ON " _
                                                  & "(`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) INNER JOIN `subentidades` ON " _
                                                  & "(`ordenes`.`ID_SUBENTIDAD`=`subentidades`.`id`) WHERE ordenes.`ID_FACTURA`='" & filtro & "' " _
                                                  & "GROUP BY `usuarios`.`IDENTIFICACION`")
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
        Public Function Factura(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `licencias`.`CODIGO_PRESTADOR` AS CODIGO, `licencias`.`CLIENTE` AS PRESTADOR, " _
                                                  & "`licencias`.`TIPO_IDENTIFICACION` AS TIPO, `licencias`.`IDENTIFICACION` AS IDENTIFICACION " _
                                                  & ", `facturas`.`FACTURA` AS FACTURA, MIN(`ordenes`.`FECHA_INGRESO`) AS INGRESO, " _
                                                  & "MAX(`ordenes`.`FECHA_INGRESO`) AS FINAL, facturas.`FECHA_FACTURA` AS FECHA_FACTURA, " _
                                                  & "`contratos`.`CODIGO_ENTIDAD` AS CODIGO_ENTIDAD, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD, " _
                                                  & "`contratos`.`NUMERO_CONTRATO` AS CONTRATO,'' AS PLAN,'' AS POLIZA,'0.00' AS COPAGO	, " _
                                                  & "'0.00' AS COMISION,'0.00' AS DESCUENTO, SUM(`detalle_factura`.`valor`-`detalle_factura`.`copago`) AS NETO " _
                                                  & "FROM `detalle_factura` INNER JOIN `ordenes` ON (`detalle_factura`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`)	INNER JOIN `entidades` ON " _
                                                  & "(`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) 	INNER JOIN `licencias` ON " _
                                                  & "(`contratos`.`ID_LICENCIA` = `licencias`.`ID`) INNER JOIN `facturas` ON " _
                                                  & "(`detalle_factura`.`ID_FACTURA`=`facturas`.`ID`) WHERE ordenes.`ID_FACTURA`='" & filtro & "' GROUP BY `licencias`.`CODIGO_PRESTADOR`")
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
        Public Function Consultas(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `facturas`.`FACTURA` AS FACTURA, `licencias`.`CODIGO_PRESTADOR` AS PRESTADOR, " _
                                                  & "`usuarios`.`ID_TIPO_IDENTIFICACION` AS TIPO, `usuarios`.`IDENTIFICACION`, " _
                                                  & "`ordenes`.`FECHA_INGRESO` AS FECHA, `ordenes`.`AUTORIZACION`,`detalle_factura`.`CODIGO_PROCEDIMIENTO` AS CODIGO " _
                                                  & ", `detalle_factura`.`ID_FINALIDAD_CONSULTA`  AS FINALIDAD , `detalle_factura`.`ID_CAUSA` AS CAUSA, " _
                                                  & "`detalle_factura`.`DIAGNOSTICO1` AS CIE10,'' AS D1 ,'' AS D2,'' AS D3, `detalle_factura`.`ID_TIPO_DIAGNOSTICO`, " _
                                                  & "`detalle_factura`.`VALOR`, `detalle_factura`.`COPAGO`,(`detalle_factura`.`valor`-`detalle_factura`.`copago`) AS NETO " _
                                                  & ",`subentidades`.`nombre` FROM `detalle_factura` INNER JOIN `ordenes`  ON (`detalle_factura`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos`  ON " _
                                                  & "(`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `entidades` ON " _
                                                  & "(`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`)INNER JOIN `licencias`  ON " _
                                                  & "(`contratos`.`ID_LICENCIA` = `licencias`.`ID`) INNER JOIN `subentidades` ON " _
                                                  & "(`ordenes`.`ID_SUBENTIDAD`=`subentidades`.`id`) INNER JOIN `facturas` ON " _
                                                  & "(`detalle_factura`.`ID_FACTURA`=`facturas`.`ID`) WHERE ordenes.`ID_FACTURA`='" & filtro & "' AND detalle_factura.tipo='C'")
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
        Public Function Procedimientos(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `facturas`.`FACTURA` AS FACTURA, `licencias`.`CODIGO_PRESTADOR` AS PRESTADOR, " _
                                                  & "`usuarios`.`ID_TIPO_IDENTIFICACION` AS TIPO, `usuarios`.`IDENTIFICACION`, " _
                                                  & "`ordenes`.`FECHA_INGRESO` AS FECHA, `ordenes`.`AUTORIZACION`, " _
                                                  & "`detalle_factura`.`CODIGO_PROCEDIMIENTO` AS CODIGO , '1'  AS AMBITO, '1'  AS FINALIDAD , " _
                                                  & "'1'  AS ATIENDE, `detalle_factura`.`DIAGNOSTICO1` AS CIE10 ,'' AS D1,'' AS D2, " _
                                                  & "detalle_factura.`ID_FORMA_REALIZACION` AS REALIZACION , " _
                                                  & "(`detalle_factura`.`VALOR`- `detalle_factura`.`COPAGO`) AS NETO ,`subentidades`.`nombre` " _
                                                  & "FROM `detalle_factura` INNER JOIN `ordenes` ON (`detalle_factura`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                                  & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `contratos` ON " _
                                                  & "(`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `entidades` ON " _
                                                  & "(`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) INNER JOIN `licencias` ON " _
                                                  & "(`contratos`.`ID_LICENCIA` = `licencias`.`ID`) INNER JOIN `subentidades` ON " _
                                                  & "(`ordenes`.`ID_SUBENTIDAD`=`subentidades`.`id`) INNER JOIN `facturas` ON " _
                                                  & "(`detalle_factura`.`ID_FACTURA`=`facturas`.`ID`) WHERE ordenes.`ID_FACTURA`='" & filtro & "' AND detalle_factura.tipo='P'")
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


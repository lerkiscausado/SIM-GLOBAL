﻿Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DFacturas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function CargarContrato(ByRef filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT entidades.NIT ,entidades.`NOMBRE_ENTIDAD`, entidades.TELEFONO, entidades.DIRECCION, " _
                                                  & "contratos.TIPO_CONTRATO FROM contratos INNER JOIN entidades ON " _
                                                  & "(contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) 	WHERE (contratos.ID ='" & filtro & "')")
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
        Public Function ExisteContratoFactura(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID_CONTRATO FROM ordenes WHERE (ID_CONTRATO ='" & filtro & "' AND ID_FACTURA ='1')")
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
        Public Sub Guardar(ByVal _Factura As Facturas)
            Try
                Dim query As String

                query = "INSERT INTO facturas VALUES('" & _Factura.Id & "','" & _Factura.IdLicencia & "','" & _Factura.Factura & "','" & _Factura.IdContrato & "','" & Format(_Factura.FechaFactura, "yyyy/MM/dd") & "'," _
                            & "'" & Format(_Factura.FechaVencimiento, "yyyy/MM/dd") & "','" & _Factura.Concepto & "'," _
                            & "'" & _Factura.Valor & "','" & _Factura.Copagos & "', '" & _Factura.Descuento & "', '" & _Factura.Estado & "','" & _Factura.IdCliente & "','" & _Factura.TipoFactura & "','" & _Factura.Remision & "','" & _Factura.IdEmpleado & "','" & _Factura.rips & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarOrdenesFactura(ByVal Contrato As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, ordenes.FECHA_INGRESO, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) " _
                                                  & "AS PACIENTE, detalle_orden.`CODIGO_CUPS`,cups.`NOMBRE_CUPS`, detalle_orden.VALOR, detalle_orden.COPAGO, (detalle_orden.VALOR-detalle_orden.COPAGO) AS NETO FROM " _
                                                  & "ordenes INNER JOIN detalle_orden ON (ordenes.ID = detalle_orden.ID_ORDEN) INNER JOIN usuarios ON " _
                                                  & "(ordenes.ID_USUARIO = usuarios.ID) INNER JOIN contratos ON (ordenes.ID_CONTRATO = contratos.ID) INNER JOIN cups ON (detalle_orden.`CODIGO_CUPS`=cups.`CODIGO_CUPS`)" _
                                                  & "WHERE (ordenes.ID_FACTURA ='1' And ordenes.ID_CONTRATO ='" & Contrato & "' AND detalle_orden.`ESTADO`<>'CANCELADO')")
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
        Public Function UltimoRegistroFactura(ByVal filtro As String) As Facturas
            Try
                Dim query As String = String.Format("SELECT id FROM facturas WHERE id_contrato='" & filtro & "' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Facturas = New Facturas
                _Facturas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Facturas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function UltimoRegistroFacturaProductos() As Facturas
            Try
                Dim query As String = String.Format("SELECT id FROM facturas WHERE tipo_factura='PRODUCTOS' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Facturas = New Facturas
                _Facturas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Facturas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function TotalFactura(ByVal filtro As String) As String
            Try
                Dim query As String = String.Format("SELECT SUM(`detalle_orden`.`VALOR`-`detalle_orden`.`COPAGO`) AS TOTAL " _
                                                    & "FROM `ordenes` INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`)" _
                                                    & "WHERE ordenes.`ID_FACTURA`='1' AND ordenes.`ID_CONTRATO`='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarFacturaServicios() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `facturas`.`ID`, facturas.FACTURA, `facturas`.`FECHA_FACTURA` AS FECHA, `contratos`.`NOMBRE` AS CONTRATO	, `entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD, " _
                                                  & "`facturas`.`CONCEPTO`, `facturas`.`VALOR` , `facturas`.`COPAGOS`,(`facturas`.`VALOR`-`facturas`.`COPAGOS`) AS NETO " _
                                                  & ",licencias.`CLIENTE` AS EMPRESA, if(facturas.ESTADO='F','FACTURADA','ANULADA') as ESTADO, facturas.tipo_factura as TIPOFACTURA FROM `facturas` " _
                                                  & "INNER JOIN `contratos`    ON (`facturas`.`ID_CONTRATO` = `contratos`.`ID`)" _
                                                  & "INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`)" _
                                                  & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD`=`entidades`.`CODIGO_ENTIDAD`)")
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
        Public Function ListarFacturaProductos() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `facturas`.`ID`, facturas.FACTURA, `facturas`.`FECHA_FACTURA` AS FECHA " _
                                                  & ", `clientes`.`NOMBRE` AS CONTRATO, `clientes`.`TELEFONO` , `clientes`.`CORREO_ELECTRONICO` AS EMAIL " _
                                                  & ",`facturas`.`CONCEPTO`	, `facturas`.`VALOR` 	, `facturas`.`COPAGOS`	, `facturas`.`DESCUENTO` " _
                                                  & ",(`facturas`.`VALOR`-`facturas`.`COPAGOS`)- `facturas`.`DESCUENTO` AS NETO" _
                                                  & ",empleados.`NOMBRE_EMPLEADO` AS GENERADA, IF (facturas.ESTADO='F', 'FACTURADO','ANULADA') AS ESTADO ,facturas.`TIPO_FACTURA` AS TIPOFACTURA " _
                                                  & "FROM `facturas` INNER JOIN `clientes` ON (`facturas`.`ID_cliente` = `clientes`.`ID`) INNER JOIN empleados ON (facturas.id_empleado=empleados.id)")
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
        Public Function ListarDetalleFactura() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `facturas`.`FACTURA`, `facturas`.`FECHA_FACTURA`, `contratos`.`NOMBRE` AS CONTRATO, " _
                                                  & "`detalle_factura`.`ID_ORDEN` AS ORDEN , `ordenes`.`FECHA_INGRESO`, " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ', `usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                                                  & "`ordenes`.`AUTORIZACION`, `detalle_factura`.`CODIGO_PROCEDIMIENTO`, `detalle_factura`.`CODIGO_CUPS`, `cups`.`NOMBRE_CUPS`, " _
                                                  & "`detalle_factura`.`VALOR`, `detalle_factura`.`COPAGO` , (`detalle_factura`.`VALOR`-`detalle_factura`.`COPAGO`) AS NETO " _
                                                  & "FROM `detalle_factura` INNER JOIN `facturas` ON (`detalle_factura`.`ID_FACTURA` = `facturas`.`ID`) INNER JOIN `ordenes` " _
                                                  & "ON (`detalle_factura`.`ID_ORDEN` = `ordenes`.`ID`) INNER JOIN `cups` ON (`detalle_factura`.`CODIGO_CUPS` = `cups`.`CODIGO_CUPS`) " _
                                                  & "INNER JOIN `contratos` ON (`facturas`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`)")
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
        Public Function ExisteFactura(ByVal licencia As String, ByVal factura As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM facturas WHERE id_licencia='" & licencia & "' AND factura='" & factura & "'")
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
        Public Sub ActualizarOrdenes(ByVal _contrato As String)
            Try
                Dim query As String

                query = "UPDATE ordenes SET id_factura=(SELECT id FROM facturas ORDER BY id DESC LIMIT 1), estado='FACTURADO' WHERE ID_FACTURA='F' AND id_contrato='" & _contrato & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarDetalleFactura()
            Try
                Dim query As String
                query = "INSERT INTO detalle_factura (ID,ID_ORDEN,ID_CAUSA,ID_FINALIDAD_CONSULTA,ID_FINALIDAD_PROCEDIMIENTO,ID_AMBITO,ID_PERSONA_ATIENDE,FECHA_SALIDA,HORA,ID_TIPO_DIAGNOSTICO " _
                    & ",DIAGNOSTICO1,DIAGNOSTICO2,DIAGNOSTICO3,DIAGNOSTICO4,ID_FORMA_REALIZACION,CODIGO_PROCEDIMIENTO,CODIGO_CUPS,ID_TIPO_ESTUDIO,VALOR,COPAGO,TIPO,ESTADO,CONCEPTO_GLOSA " _
                    & ",ID_FACTURA)(SELECT	0 AS ID   ,`ordenes`.`ID` AS ID_ORDEN  ,detalle_orden.`ID_CAUSA` ,detalle_orden.`ID_FINALIDAD_CONSULTA`,detalle_orden.`ID_FINALIDAD_PROCEDIMIENTO` " _
                    & ",detalle_orden.`ID_AMBITO` ,detalle_orden.`ID_PERSONA_ATIENDE`,detalle_orden.`FECHA_SALIDA`,detalle_orden.`HORA`,detalle_orden.`ID_TIPO_DIAGNOSTICO` " _
                    & ",detalle_orden.`DIAGNOSTICO1`,detalle_orden.`DIAGNOSTICO2`,detalle_orden.`DIAGNOSTICO3`,detalle_orden.`DIAGNOSTICO4`,detalle_orden.`ID_FORMA_REALIZACION` " _
                    & ",detalle_orden.`CODIGO_PROCEDIMIENTO` ,detalle_orden.`CODIGO_CUPS`,detalle_orden.`ID_TIPO_ESTUDIO`,detalle_orden.`VALOR`,detalle_orden.`COPAGO` " _
                    & ",detalle_orden.`TIPO`,'FACTURADO','' AS CONCEPTO_GLOSA ,ordenes.`ID_FACTURA` FROM  `ordenes` INNER JOIN `detalle_orden` " _
                    & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE  detalle_orden.`ESTADO` <>'CANCELADO' AND ordenes.id_factura=(SELECT id FROM facturas ORDER BY id DESC LIMIT 1))"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub AnularFactura(ByVal IdFactura As String)
            Try
                Dim query As String

                query = "UPDATE facturas SET estado='A' WHERE ID='" & IdFactura & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub NumeroFacturaAutonumerica(ByVal IdFactura As String)
            Try
                Dim query As String

                query = "UPDATE facturas SET factura='" & IdFactura & "' WHERE ID='" & IdFactura & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarVentas() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT facturas.`ID` AS FACTURA,facturas.`FECHA_FACTURA` AS FECHA,productos.`NOMBRE` AS PRODUCTO " _
                                                  & ",marcas.`NOMBRE` AS MARCA,presentacion_productos.`PRESENTACION` ,detalle_factura_productos.`CANTIDAD` " _
                                                  & ",detalle_factura_productos.`VALOR_UNITARIO` AS VALOR,detalle_factura_productos.`DESCUENTO` " _
                                                  & ",(detalle_factura_productos.`VALOR_UNITARIO`*detalle_factura_productos.`CANTIDAD`)-detalle_factura_productos.`DESCUENTO` AS NETO " _
                                                  & ",detalle_factura_productos.`VALOR_UNITARIO`*detalle_factura_productos.`CANTIDAD` AS SUBTOTAL " _
                                                  & "FROM detalle_factura_productos	INNER JOIN facturas ON (detalle_factura_productos.`ID_FACTURA`=facturas.`ID`) " _
                                                  & "INNER JOIN presentacion_productos ON (detalle_factura_productos.`ID_PRODUCTO`=presentacion_productos.`ID`) " _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`)")
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
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DOrdenCompra
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdOrdenCompra As String) As OrdenCompra
            Try
                Dim query As String = String.Format("SELECT * FROM orden_compra WHERE id='" & IdOrdenCompra & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _OrdenCompra = New OrdenCompra
                _OrdenCompra.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _OrdenCompra.Fecha = _ds.Tables(0).Rows(0)(1).ToString()
                _OrdenCompra.Hora = _ds.Tables(0).Rows(0)(2).ToString()
                _OrdenCompra.IdProveedor = _ds.Tables(0).Rows(0)(3).ToString()
                _OrdenCompra.IdEmpleado = _ds.Tables(0).Rows(0)(4).ToString()
                _OrdenCompra.Observacion = _ds.Tables(0).Rows(0)(5).ToString()
                _OrdenCompra.Estado = _ds.Tables(0).Rows(0)(6).ToString()
                _OrdenCompra.FechaAprobacion = _ds.Tables(0).Rows(0)(7).ToString()
                _OrdenCompra.IdAprobacion = _ds.Tables(0).Rows(0)(8).ToString()
                Return _OrdenCompra
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _OrdenCompra As OrdenCompra)
            Try
                Dim query As String
                If Existe(_OrdenCompra.Id) = True Then
                    query = "UPDATE orden_compra SET id_proveedor='" & _OrdenCompra.IdProveedor & "', " _
                            & "observacion='" & _OrdenCompra.Observacion & "' where id='" & _OrdenCompra.Id & "'"
                Else
                    query = "insert into orden_compra values('" & _OrdenCompra.Id & "', " _
                            & "'" & Format(_OrdenCompra.Fecha, "yyyy/MM/dd") & "', TIME_FORMAT(Now(), '%H:%i:%s'),'" & _OrdenCompra.IdProveedor & "', " _
                            & "'" & _OrdenCompra.IdEmpleado & "','" & _OrdenCompra.Observacion & "','" & _OrdenCompra.Estado & "', " _
                            & "'" & Format(_OrdenCompra.FechaAprobacion, "yyyy/MM/dd") & "','" & _OrdenCompra.IdAprobacion & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdOrdenCompra As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM orden_compra WHERE id='" & IdOrdenCompra & "'")
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
        Public Function UltimoConsecutivo() As String
            Try
                Dim query As String =
                        String.Format("select id from orden_compra ORDER by ID desc LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Function Codigo() As String
            Try
                Dim query As String =
                        String.Format("select CONCAT('OC',CONVERT(ID,CHAR(50)),DATE_FORMAT(`FECHA`,'%d%m%Y')) AS ORDEN from orden_compra ORDER by ID desc LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT orden_compra.ID ,CONCAT('OC',CONVERT(orden_compra.ID,CHAR(50)),DATE_FORMAT(orden_compra.fecha,'%d%m%Y')) AS ORDEN " _
                                    & ",orden_compra.`FECHA`,proveedores.`NOMBRE` AS PROVEEDOR,presentacion_productos.`CODIGO_BARRA` AS CODIGO,CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`) AS PRESENTACION " _
                                    & ",unidad_medida.`NOMBRE` AS UNIDAD,detalle_orden_compra.`CANTIDAD` AS CANTIDAD,detalle_orden_compra.`VALOR_UNITARIO` AS VALOR " _
                                    & ",detalle_orden_compra.`CANTIDAD` * detalle_orden_compra.`VALOR_UNITARIO` AS TOTAL,orden_compra.`ESTADO` FROM DETALLE_ORDEN_COMPRA " _
                                    & "	INNER JOIN ORDEN_COMPRA ON (DETALLE_ORDEN_COMPRA.`ID_ORDEN_COMPRA` = ORDEN_COMPRA.ID) " _
                                    & "	INNER JOIN proveedores ON (orden_compra.`ID_PROVEEDOR`=proveedores.`ID`) " _
                                    & "	INNER JOIN presentacion_productos ON (detalle_orden_compra.`ID_PRODUCTO`=presentacion_productos.id)" _
                                    & "	INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                    & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`)" _
                                    & "INNER JOIN unidad_medida ON (presentacion_productos.`ID_UNIDAD_MEDIDA`=unidad_medida.`ID`)")
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
        Public Function OrdenCompraAprobada(ByVal IdOrdenCompra As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM orden_compra WHERE id='" & IdOrdenCompra & "' and estado='APROBADA' OR estado='PARCIAL'")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `orden_compra`.`ID`, CONCAT('OC',CONVERT(orden_compra.ID,CHAR(50)),DATE_FORMAT(orden_compra.fecha,'%d%m%Y')) " _
                                                  & "AS ORDEN, `orden_compra`.`FECHA`, `proveedores`.`NOMBRE` AS PROVEEDOR, " _
                                                  & "`orden_compra`.`OBSERVACION` FROM `orden_compra` " _
                                                  & "INNER JOIN `proveedores` ON (`orden_compra`.`ID_PROVEEDOR` = `proveedores`.`ID`) " _
                                                  & "where orden_compra.estado='APROBADA' OR orden_compra.estado='PARCIAL'")
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
        Public Function OrdenCompraAbierta(ByVal IdOrdenCompra As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM orden_compra WHERE id='" & IdOrdenCompra & "' and estado='ABIERTA'")
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
        Public Sub Anular(ByVal _IdOrdenCompra As String)
            Try
                Dim query As String
                query = "update orden_compra set estado='ANULADA' where id='" & _IdOrdenCompra & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Aprobar(ByVal _IdOrdenCompra As String)
            Try
                Dim query As String
                query = "update orden_compra set estado='APROBADA' where id='" & _IdOrdenCompra & "'"

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


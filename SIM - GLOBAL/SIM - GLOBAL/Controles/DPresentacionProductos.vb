Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades

Namespace Controles
    Public Class DPresentacionProductos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal IdProducto As String) As PresentacionProductos
            Try
                Dim query As String = String.Format("SELECT * FROM presentacion_productos WHERE id='" & IdProducto & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _PresentacionProductos = New PresentacionProductos
                _PresentacionProductos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _PresentacionProductos.IdProducto = _ds.Tables(0).Rows(0)(1).ToString()
                _PresentacionProductos.IdMarca = _ds.Tables(0).Rows(0)(2).ToString()
                _PresentacionProductos.Presentacion = _ds.Tables(0).Rows(0)(3).ToString()
                _PresentacionProductos.IdUnidadMedida = _ds.Tables(0).Rows(0)(4).ToString()
                _PresentacionProductos.Cantidad = _ds.Tables(0).Rows(0)(5).ToString()
                _PresentacionProductos.CodigoBarra = _ds.Tables(0).Rows(0)(6).ToString()
                _PresentacionProductos.FotoProducto = _ds.Tables(0).Rows(0)(7)
                _PresentacionProductos.Estado = _ds.Tables(0).Rows(0)(8).ToString()
                _PresentacionProductos.Foto = _ds.Tables(0).Rows(0)(9)
                _PresentacionProductos.Inventario = _ds.Tables(0).Rows(0)(10)
                Return _PresentacionProductos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdProducto As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM presentacion_productos WHERE id='" & IdProducto & "'")
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
        Public Sub Guardar(ByVal _PresentacionProductos As SIM___GLOBAL.Modelo.PresentacionProductos)
            Try
                Dim query As String
                Dim Imag As Byte()
                Dim Imag2 As Byte()
                Imag = _PresentacionProductos.FotoProducto
                Imag2 = _PresentacionProductos.Foto

                If Existe(_PresentacionProductos.Id) = True Then
                    'Actualizamos el Producto
                    query = "UPDATE presentacion_productos SET presentacion='" & _PresentacionProductos.Presentacion & "', " _
                             & "id_unidad_medida='" & _PresentacionProductos.IdUnidadMedida & "', " _
                             & "cantidad=? " _
                             & ",Id_Producto='" & _PresentacionProductos.IdProducto & "' " _
                             & ",id_marca='" & _PresentacionProductos.IdMarca & "' " _
                             & ",estado='" & _PresentacionProductos.Estado & "' " _
                             & ",inventario='" & _PresentacionProductos.Inventario & "' " _
                             & "WHERE id='" & _PresentacionProductos.Id & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, CDec(_PresentacionProductos.Cantidad))
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    query = "UPDATE presentacion_productos SET Foto_producto=? WHERE id='" & _PresentacionProductos.Id & "'"
                    _conn = ConexionODBC.Open()
                    comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                Else
                    'guardamos el consecutivo
                    query = "INSERT INTO presentacion_productos VALUES('" & _PresentacionProductos.Id & "','" & _PresentacionProductos.IdProducto & "', " _
                            & "'" & _PresentacionProductos.IdMarca & "','" & _PresentacionProductos.Presentacion & "', " _
                            & "'" & _PresentacionProductos.IdUnidadMedida & "',?, " _
                            & "'" & _PresentacionProductos.CodigoBarra & "',?,'" & _PresentacionProductos.Estado & "',?,'" & _PresentacionProductos.Inventario & "')"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, CDec(_PresentacionProductos.Cantidad))
                    comando.Parameters.AddWithValue(1, Imag)
                    comando.Parameters.AddWithValue(2, Imag2)
                    comando.ExecuteNonQuery()

                    ConexionODBC.Close(_conn)
                    GenerarConsecutivo(_PresentacionProductos.Licencia)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT presentacion_productos.ID, presentacion_productos.CODIGO_BARRA AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION " _
                                                  & ",unidad_medida.NOMBRE AS UNIDAD, presentacion_productos.CANTIDAD, presentacion_productos.foto_producto as FOTO " _
                                                  & ",IF(presentacion_productos.ESTADO='A','ACTIVO','INACTIVO') AS ESTADO FROM presentacion_productos INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "INNER JOIN unidad_medida ON (presentacion_productos.ID_UNIDAD_MEDIDA = unidad_medida.ID)")
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
        Public Sub GenerarConsecutivo(ByVal Licencia As String)
            Try
                Dim Codigo = New BarcodeLib.Barcode
                Dim _funciones As New SIM___GLOBAL.Utilidades.Funciones
                Dim Imag As Byte()
                Dim query As String =
                                    String.Format("select id  from presentacion_productos ORDER by ID desc LIMIT 1")

                Codigo.IncludeLabel = True


                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)

                Imag = _funciones.Imagen_Bytes(Codigo.Encode(BarcodeLib.TYPE.CODE128, Licencia & _ds.Tables(0).Rows(0)(0).ToString & Format(DateTime.Now, "ddMMyyyy"), 400, 100))
                query = "update presentacion_productos set codigo_barra='" & Licencia & _ds.Tables(0).Rows(0)(0).ToString & Format(DateTime.Now, "ddMMyyyy") & "' " _
                & ",foto=? " _
                & "where id='" & _ds.Tables(0).Rows(0)(0).ToString & "'"

                comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, Imag)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT presentacion_productos.ID	,presentacion_productos.codigo_barra AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION " _
                                                  & ", `unidad_medida`.`NOMBRE` AS MEDIDA FROM `presentacion_productos` " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "WHERE (`presentacion_productos`.`ESTADO` ='A' and presentacion_productos.inventario='SI')")
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
        Public Shared Function CantidadProducto(ByVal IdPresentacionProducto As String) As String
            Try
                Dim query As String = String.Format("SELECT cantidad FROM presentacion_productos WHERE id='" & IdPresentacionProducto & "'")
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
        Public Function ListarComboPyS() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT presentacion_productos.ID	,presentacion_productos.codigo_barra AS CODIGO " _
                                                  & ",CONCAT(productos.`NOMBRE`,' ',marcas.`NOMBRE`,' ',`presentacion_productos`.`PRESENTACION`) AS PRESENTACION " _
                                                  & ", `unidad_medida`.`NOMBRE` AS MEDIDA FROM `presentacion_productos` " _
                                                  & "INNER JOIN `unidad_medida` ON (`presentacion_productos`.`ID_UNIDAD_MEDIDA` = `unidad_medida`.`ID`) " _
                                                  & "INNER JOIN productos ON (presentacion_productos.`ID_PRODUCTO`=productos.`ID`) " _
                                                  & "INNER JOIN marcas ON (presentacion_productos.`ID_MARCA`=marcas.`ID`) " _
                                                  & "WHERE (`presentacion_productos`.`ESTADO` ='A')")
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


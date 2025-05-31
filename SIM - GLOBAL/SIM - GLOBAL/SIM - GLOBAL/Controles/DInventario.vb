Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DInventario
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _Inventario As Inventario)
            Try
                Dim query As String
                query = "INSERT INTO inventario VALUES('" & _Inventario.Id & "','" & Format(_Inventario.Fecha, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_Inventario.Hora, "HH:mm:ss") & "','" & _Inventario.IdDocumento & "', " _
                        & "'" & _Inventario.IdProducto & "','" & _Inventario.IdMarca & "','" & _Inventario.IdPresentacionProducto & "', '" & _Inventario.Movimiento & "', " _
                        & "'" & _Inventario.Factura & "', '" & _Inventario.Observacion & "', " _
                        & "?,?, " _
                        & "?,?, " _
                        & "?,?, " _
                        & "?,'" & _Inventario.IdEmpleado & "', " _
                        & "'" & _Inventario.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_Inventario.EntradaCantidad))
                comando.Parameters.AddWithValue(2, CDec(_Inventario.EntradaValor))
                comando.Parameters.AddWithValue(3, CDec(_Inventario.SalidaCantidad))
                comando.Parameters.AddWithValue(4, CDec(_Inventario.SalidaValor))
                comando.Parameters.AddWithValue(5, CDec(_Inventario.SaldoCantidad))
                comando.Parameters.AddWithValue(6, CDec(_Inventario.SaldoTotal))
                comando.Parameters.AddWithValue(7, CDec(_Inventario.ValorPromedio))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Function SaldoActualInventario(ByVal IdProducto As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID_PRODUCTO`, `SALDO_CANTIDAD`, `SALDO_TOTAL` FROM `inventario` WHERE (`ID_PRODUCTO` ='" & IdProducto & "') ORDER BY `ID` DESC LIMIT 1")
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
        Public Function SaldoActualInventario2(ByVal IdPresentacionProducto As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID_PRESENTACION_PRODUCTO`, `SALDO_CANTIDAD`, `SALDO_TOTAL` FROM `inventario` WHERE (`ID_PRESENTACION_PRODUCTO` ='" & IdPresentacionProducto & "') ORDER BY `ID` DESC LIMIT 1")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT inventario.ID,inventario.`FECHA` ,productos.`NOMBRE` AS PRODUCTO,marcas.`NOMBRE` AS MARCA,presentacion_productos.`PRESENTACION` AS PRESENTACION " _
                                    & ",IF (movimiento='E' or movimiento='C','ENTRADA','SALIDA')  AS MOVIMIENTO, inventario.`FACTURA`,inventario.`ENTRADA_CANTIDAD`,inventario.`ENTRADA_VALOR` " _
                                    & ",inventario.`ENTRADA_CANTIDAD`*inventario.`ENTRADA_VALOR` AS ENTRADA_TOTAL,inventario.`SALIDA_CANTIDAD`,inventario.`SALIDA_VALOR` " _
                                    & ",inventario.`SALIDA_CANTIDAD`*inventario.`SALIDA_VALOR` AS SALIDA_TOTAL,inventario.`SALDO_CANTIDAD`,inventario.`SALDO_TOTAL` " _
                                    & ",unidad_medida.`NOMBRE` AS UNIDAD_MEDIDA FROM inventario INNER JOIN productos ON (inventario.`ID_PRODUCTO`=productos.`ID`) INNER JOIN marcas ON (inventario.`ID_MARCA`=marcas.`ID`) " _
                                    & "	INNER JOIN presentacion_productos ON (inventario.`ID_PRESENTACION_PRODUCTO`=presentacion_productos.`ID`)" _
                                    & " INNER JOIN unidad_medida ON (presentacion_productos.`ID_UNIDAD_MEDIDA`=unidad_medida.id)")
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

        Public Function ExisteProducto(ByVal IdProducto As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM inventario WHERE id_producto='" & IdProducto & "'")
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


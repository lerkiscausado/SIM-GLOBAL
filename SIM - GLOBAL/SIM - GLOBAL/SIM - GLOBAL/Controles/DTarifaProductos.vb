Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DTarifaProductos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Tarifaproductos
            Try
                Dim query As String = String.Format("SELECT * FROM tarifa_productos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _TarifaProductos = New TarifaProductos
                _TarifaProductos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _TarifaProductos.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _TarifaProductos.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _TarifaProductos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _TarifaProductos As TarifaProductos)
            Try
                Dim query As String
                If Existe(_TarifaProductos.Id) = True Then
                    query = "UPDATE tarifa_productos SET nombre='" & _TarifaProductos.Nombre & "', estado='" & _TarifaProductos.Estado & "' where id='" & _TarifaProductos.Id & "'"
                Else
                    query = "insert into tarifa_productos values('" & _TarifaProductos.Id & "','" &
                            _TarifaProductos.Nombre & "','" & _TarifaProductos.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM tarifa_productos WHERE id='" & filtro & "'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("select id as ID, nombre as TARIFA, IF(ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO from tarifa_productos")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT tarifa_productos.ID, tarifa_productos.nombre AS TARIFA FROM 
                                    tarifa_productos INNER JOIN detalle_tarifa_productos 
                                    ON (tarifa_productos.ID = detalle_tarifa_productos.ID_TARIFA_PRODUCTO) 
                                    WHERE tarifa_productos.estado='A' GROUP BY tarifa_productos.nombre ORDER BY tarifa_productos.id")
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
        Public Shared Function UltimoRegistro() As TarifaProductos
            Try
                Dim query As String = String.Format("SELECT id FROM tarifa_productos ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _TarifaProductos = New TarifaProductos
                _TarifaProductos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Tarifaproductos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


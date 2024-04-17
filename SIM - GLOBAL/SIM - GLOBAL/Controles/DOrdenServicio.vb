Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DOrdenServicio
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT orden_servicio.id as ORDEN,orden_servicio.`FECHA_ORDEN`,orden_servicio.`FECHA_VENCIMIENTO`" _
                                    & "	,clientes.`NOMBRE`,clientes.`TELEFONO`,clientes.`CORREO_ELECTRONICO`,orden_servicio.`CONCEPTO`,orden_servicio.`VALOR`,orden_servicio.`DESCUENTO` " _
                                    & ",orden_servicio.`VALOR`-orden_servicio.`DESCUENTO` AS TOTAL, " _
                                    & "IF(`orden_servicio`.`ESTADO`='P','PENDIENTE',IF(orden_servicio.estado='A','ANULADA','FACTURADA')) AS ESTADO FROM	orden_servicio " _
                                    & "INNER JOIN clientes ON (orden_servicio.`ID_CLIENTE`=clientes.`ID`)")
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
        Public Function CargarCliente(ByRef filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT CONCAT(clientes.`ID_TIPO_IDENTIFICACION`,clientes.`IDENTIFICACION`) AS IDENTIFICACION " _
                                                  & ",clientes.`NOMBRE`	, clientes.`TELEFONO`	, clientes.`DIRECCION`	,clientes.`CORREO_ELECTRONICO`,clientes.identificacion " _
                                                  & "FROM clientes 	WHERE clientes.ID ='" & filtro & "'")
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
        Public Sub Guardar(ByVal _OrdenServicio As OrdenServicio)
            Try
                Dim query As String
                query = "INSERT INTO orden_servicio VALUES('" & _OrdenServicio.Id & "','" & _OrdenServicio.IdLicencia & "','" & _OrdenServicio.OrdenServicio & "','" & Format(_OrdenServicio.FechaOrden, "yyyy/MM/dd") & "'," _
                            & "'" & Format(_OrdenServicio.FechaVencimiento, "yyyy/MM/dd") & "','" & _OrdenServicio.Concepto & "'," _
                            & "'" & _OrdenServicio.Valor & "','" & _OrdenServicio.Descuento & "', '" & _OrdenServicio.Estado & "','" & _OrdenServicio.IdCliente & "','" & _OrdenServicio.TipoOrden & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoRegistroOrdenProductos() As OrdenServicio
            Try
                Dim query As String = String.Format("SELECT id FROM orden_servicio WHERE tipo_orden='PRODUCTOS' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _ordenservicio = New OrdenServicio
                _ordenservicio.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _ordenservicio
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteOrdenPendiente(ByVal IdOrdenServicio As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM orden_servicio WHERE id='" & IdOrdenServicio & "' and estado='P'")
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
        Public Sub AnularOrdenServicio(ByVal IdOrdenServicio As String)
            Try
                Dim query As String
                query = "UPDATE orden_servicio SET estado='A' where id='" & IdOrdenServicio & "'"

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


Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DOrdenServicio
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdOrdenServicio As String) As AGORA.Modelo.OrdenServicio
            Try
                Dim query As String = String.Format("SELECT * FROM orden_servicio_agora WHERE id='" & IdOrdenServicio & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _OrdenServicio = New AGORA.Modelo.OrdenServicio
                _OrdenServicio.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _OrdenServicio.IdLicencia = _ds.Tables(0).Rows(0)(1).ToString()
                _OrdenServicio.OrdenServicio = _ds.Tables(0).Rows(0)(2).ToString()
                _OrdenServicio.FechaOrden = _ds.Tables(0).Rows(0)(3).ToString()
                _OrdenServicio.FechaVencimiento = _ds.Tables(0).Rows(0)(4).ToString()
                _OrdenServicio.Concepto = _ds.Tables(0).Rows(0)(5).ToString()
                _OrdenServicio.Valor = _ds.Tables(0).Rows(0)(6).ToString()
                _OrdenServicio.Descuento = _ds.Tables(0).Rows(0)(7).ToString()
                _OrdenServicio.Estado = _ds.Tables(0).Rows(0)(8).ToString()
                _OrdenServicio.IdCliente = _ds.Tables(0).Rows(0)(9).ToString()
                _OrdenServicio.TipoOrden = _ds.Tables(0).Rows(0)(10).ToString()
                _OrdenServicio.IdEvento = _ds.Tables(0).Rows(0)(11).ToString()
                Return _OrdenServicio
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT orden_servicio_agora.id AS ORDEN, " _
                                    & "orden_servicio_agora.`FECHA_ORDEN`, " _
                                    & "orden_servicio_agora.`FECHA_VENCIMIENTO`, " _
                                    & "clientes.`NOMBRE`, " _
                                    & "clientes.`TELEFONO`, " _
                                    & "clientes.`CORREO_ELECTRONICO`, " _
                                    & "orden_servicio_agora.`CONCEPTO`, " _
                                    & "orden_servicio_agora.`VALOR`, " _
                                    & "orden_servicio_agora.`DESCUENTO`, " _
                                    & "orden_servicio_agora.`VALOR`-orden_servicio_agora.`DESCUENTO` AS TOTAL, " _
                                    & "IF(`orden_servicio_agora`.`ESTADO`='P','PENDIENTE',IF(orden_servicio_agora.estado='A','ANULADA','FACTURADA')) AS ESTADO " _
                                    & "FROM orden_servicio_agora INNER JOIN clientes ON (orden_servicio_agora.`ID_CLIENTE`=clientes.`ID`)")
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
        Public Sub Guardar(ByVal _OrdenServicio As AGORA.Modelo.OrdenServicio)
            Try
                Dim query As String
                If Existe(_OrdenServicio.Id) = True Then
                    query = "UPDATE orden_servicio_agora SET concepto='" & _OrdenServicio.Concepto & "', " _
                           & "fecha_orden='" & Format(_OrdenServicio.FechaOrden, "yyyy/MM/dd") & "', " _
                           & "fecha_vencimiento='" & Format(_OrdenServicio.FechaVencimiento, "yyyy/MM/dd") & "', " _
                           & "valor='" & _OrdenServicio.Valor & "', " _
                           & "descuento='" & _OrdenServicio.Descuento & "'," _
                           & "id_evento='" & _OrdenServicio.IdEvento & "' WHERE id='" & _OrdenServicio.Id & "'"
                Else
                    query = "INSERT INTO orden_servicio_agora VALUES('" & _OrdenServicio.Id & "', " _
                            & "'" & _OrdenServicio.IdLicencia & "', " _
                            & "'" & _OrdenServicio.OrdenServicio & "', " _
                            & "'" & Format(_OrdenServicio.FechaOrden, "yyyy/MM/dd") & "'," _
                            & "'" & Format(_OrdenServicio.FechaVencimiento, "yyyy/MM/dd") & "', " _
                            & "'" & _OrdenServicio.Concepto & "', " _
                            & "'" & _OrdenServicio.Valor & "', " _
                            & "'" & _OrdenServicio.Descuento & "', " _
                            & "'" & _OrdenServicio.Estado & "', " _
                            & "'" & _OrdenServicio.IdCliente & "', " _
                            & "'" & _OrdenServicio.TipoOrden & "', " _
                            & "'" & _OrdenServicio.IdEvento & "')"

                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoRegistroOrdenServicio() As AGORA.Modelo.OrdenServicio
            Try
                Dim query As String = String.Format("SELECT id FROM orden_servicio_agora ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _OrdenServicio = New AGORA.Modelo.OrdenServicio
                _OrdenServicio.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _OrdenServicio
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdOrdenServicio As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM orden_servicio_agora WHERE id='" & IdOrdenServicio & "'")
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


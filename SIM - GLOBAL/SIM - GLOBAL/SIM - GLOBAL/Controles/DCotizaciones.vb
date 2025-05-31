Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DCotizaciones
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT cotizaciones.id as COTIZACION,cotizaciones.`FECHA_COTIZACION`,cotizaciones.`FECHA_VENCIMIENTO`" _
                                    & "	,clientes.`NOMBRE`,clientes.`TELEFONO`,clientes.`CORREO_ELECTRONICO` AS EMAIL,cotizaciones.`CONCEPTO`,cotizaciones.`VALOR`	,cotizaciones.`DESCUENTO` " _
                                    & ",cotizaciones.`VALOR`-cotizaciones.`DESCUENTO` AS TOTAL FROM	cotizaciones " _
                                    & "INNER JOIN clientes ON (cotizaciones.`ID_CLIENTE`=clientes.`ID`)")
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
                                                  & ",clientes.`NOMBRE`	, clientes.`TELEFONO`	, clientes.`DIRECCION`	,clientes.`CORREO_ELECTRONICO` " _
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
        Public Sub Guardar(ByVal _Cotizaciones As Cotizaciones)
            Try
                Dim query As String

                query = "INSERT INTO cotizaciones VALUES('" & _Cotizaciones.Id & "','" & _Cotizaciones.IdLicencia & "','" & _Cotizaciones.Cotizacion & "','" & Format(_Cotizaciones.FechaCotizacion, "yyyy/MM/dd") & "'," _
                            & "'" & Format(_Cotizaciones.FechaVencimiento, "yyyy/MM/dd") & "','" & _Cotizaciones.Concepto & "'," _
                            & "'" & _Cotizaciones.Valor & "','" & _Cotizaciones.Descuento & "', '" & _Cotizaciones.Estado & "','" & _Cotizaciones.IdCliente & "','" & _Cotizaciones.TipoFactura & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoRegistroCotizacionProductos() As Cotizaciones
            Try
                Dim query As String = String.Format("SELECT id FROM Cotizaciones WHERE tipo_factura='PRODUCTOS' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Cotizaciones = New Cotizaciones
                _Cotizaciones.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Cotizaciones
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


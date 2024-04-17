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
                                    String.Format("SELECT cotizaciones_agora.id as COTIZACION,cotizaciones_agora.`FECHA_COTIZACION`,cotizaciones_agora.`FECHA_VENCIMIENTO`" _
                                    & "	,clientes.`NOMBRE`,clientes.`TELEFONO`,clientes.`CORREO_ELECTRONICO` AS EMAIL,cotizaciones_agora.`CONCEPTO`,cotizaciones_agora.`VALOR`,cotizaciones_agora.`DESCUENTO` " _
                                    & ",cotizaciones_agora.`VALOR`-cotizaciones_agora.`DESCUENTO` AS TOTAL FROM	cotizaciones_agora " _
                                    & "INNER JOIN clientes ON (cotizaciones_agora.`ID_CLIENTE`=clientes.`ID`)")
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
        Public Sub Guardar(ByVal _Cotizaciones As AGORA.Modelo.Cotizaciones)
            Try
                Dim query As String

                query = "INSERT INTO cotizaciones_agora VALUES('0', " _
                            & "'" & _Cotizaciones.IdLicencia & "', " _
                            & "'" & _Cotizaciones.Cotizacion & "', " _
                            & "'" & Format(_Cotizaciones.FechaCotizacion, "yyyy/MM/dd") & "'," _
                            & "'" & Format(_Cotizaciones.FechaVencimiento, "yyyy/MM/dd") & "', " _
                            & "'" & _Cotizaciones.Concepto & "', " _
                            & "'" & _Cotizaciones.Valor & "', " _
                            & "'" & _Cotizaciones.Descuento & "', " _
                            & "'" & _Cotizaciones.Estado & "', " _
                            & "'" & _Cotizaciones.IdCliente & "', " _
                            & "'" & _Cotizaciones.TipoFactura & "', " _
                            & "'" & _Cotizaciones.IdEvento & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoRegistroCotizacion() As AGORA.Modelo.Cotizaciones
            Try
                Dim query As String = String.Format("SELECT id FROM cotizaciones_agora ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Cotizaciones = New AGORA.Modelo.Cotizaciones
                _Cotizaciones.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Cotizaciones
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarCombo(ByVal IdCliente As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT id as COTIZACION, " _
                                    & "fecha_cotizacion AS FECHA, " _
                                    & "CONCEPTO, " _
                                    & "VALOR, " _
                                    & "DESCUENTO, " _
                                    & "valor-descuento AS NETO, " _
                                    & "id_evento AS EVENTO " _
                                    & "FROM cotizaciones_agora WHERE id_cliente='" & IdCliente & "'")
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
        Public Function ClienteEmail(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `cotizaciones_agora`.`ID_cliente`, `clientes`.`CORREO_ELECTRONICO`,`clientes`.`NOMBRE` AS CLIENTE " _
                                    & "FROM `cotizaciones_agora` INNER JOIN `clientes` ON (`cotizaciones_agora`.`ID_cliente` = `clientes`.`ID`) " _
                                    & "WHERE (`cotizaciones_agora`.`ID` ='" & filtro & "')")
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


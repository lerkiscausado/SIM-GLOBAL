Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleTarifa
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal IdTarifa As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_tarifa`.`ID`, " _
                                                & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, " _
                                                & "`detalle_tarifa`.`VALOR`, " _
                                                & "ROUND((`detalle_tarifa`.`VALOR`*`detalle_tarifa`.`IVA`)/100) AS IVA, " _
                                                & "CONCAT(CAST(`detalle_tarifa`.`IVA` AS CHAR),'%') AS TARIFA, " _
                                                & "ROUND(`detalle_tarifa`.`VALOR`+((`detalle_tarifa`.`VALOR`*`detalle_tarifa`.`IVA`)/100)) AS TOTAL " _
                                                & "FROM `detalle_tarifa` INNER JOIN `tipo_estudio` ON (`detalle_tarifa`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                & "WHERE detalle_tarifa.`ID_TARIFA`='" & IdTarifa & "'")
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
        Public Function Existe(ByVal IdDetalleTarifa As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_tarifa WHERE id='" & IdDetalleTarifa & "'")
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
        Public Sub Guardar(ByVal _DetalleTarifa As PEC___App.Modelo.DetalleTarifa)
            Try
                Dim query As String
                If Existe(_DetalleTarifa.Id) = True Then
                    query = "UPDATE detalle_tarifa SET valor='" & _DetalleTarifa.Valor & "', " _
                            & "iva='" & _DetalleTarifa.IVA & "', estado='" & _DetalleTarifa.Estado & "' where id='" & _DetalleTarifa.Id & "'"
                Else
                    query = "insert into detalle_tarifa values('" & _DetalleTarifa.Id & "','" &
                            _DetalleTarifa.IdTarifa & "','" & _DetalleTarifa.IdTipoEstudio & "','" &
                            _DetalleTarifa.Valor & "','" & _DetalleTarifa.IVA & "', '" &
                            _DetalleTarifa.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleTarifa(ByVal IdTarifa As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa WHERE id_tarifa='" & IdTarifa & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarDetalleTarifa(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_tarifa SET id_tarifa='" & filtro & "' WHERE id_tarifa='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleTarifa(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo(ByVal Contrato As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `detalle_tarifa`.`ID`, " _
                                                & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, " _
                                                & "`detalle_tarifa`.`VALOR`, " _
                                                & "ROUND((`detalle_tarifa`.`VALOR`*`detalle_tarifa`.`IVA`)/100) AS IVA, " _
                                                & "CONCAT(CAST(`detalle_tarifa`.`IVA` AS CHAR),'%') AS TARIFA, " _
                                                & "ROUND(`detalle_tarifa`.`VALOR`+((`detalle_tarifa`.`VALOR`*`detalle_tarifa`.`IVA`)/100)) AS TOTAL, " _
                                                & "`detalle_tarifa`.`ID_TIPO_ESTUDIO` AS IDTIPOESTUDIO " _
                                                & "FROM `detalle_tarifa` INNER JOIN `tipo_estudio` ON (`detalle_tarifa`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                                & "INNER JOIN `contratos` ON (`contratos`.`ID_TARIFA` = `detalle_tarifa`.`ID_TARIFA`) " _
                                                & "WHERE (`contratos`.`ID` ='" & Contrato & "' And `detalle_tarifa`.`ESTADO` ='A')")
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


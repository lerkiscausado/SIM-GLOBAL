Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaDiagnosticos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _HistoriaDiagnosticos As HistoriaDiagnosticos)
            Try
                Dim query As String
                query = "insert into historia_diagnosticos values('" & _HistoriaDiagnosticos.IdDiagnostico & "','" &
                            _HistoriaDiagnosticos.IdOrden & "','" & _HistoriaDiagnosticos.IdDetalleOrden & "','" & _HistoriaDiagnosticos.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _IdDiagnostico As String, ByVal _idOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_diagnosticos WHERE id_diagnostico='" & _IdDiagnostico & "' AND id_orden='" & _idOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _IdDiagnostico As String, ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_diagnostico FROM historia_diagnosticos WHERE id_diagnostico='" & _IdDiagnostico & "' and id_orden='" & _idOrden & "'")
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
        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `historia_diagnosticos`.`ID_DIAGNOSTICO` AS CODIGO, `diagnosticos`.`NOMBRE_DIAGNOSTICO` AS DIAGNOSTICO, " _
                                        & "`historia_diagnosticos`.`DESCRIPCION` FROM `ordenes` INNER JOIN `historia_diagnosticos` " _
                                        & "ON (`ordenes`.`ID` = `historia_diagnosticos`.`ID_ORDEN`) INNER JOIN `diagnosticos` " _
                                        & "ON (`historia_diagnosticos`.`ID_DIAGNOSTICO` = `diagnosticos`.`CODIGO_DIAGNOSTICO`) WHERE (`ordenes`.`ID` ='" & filtro & "')")
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
        Public Function ListarHistoriaDiagnostico(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `historia_diagnosticos`.`ID_DIAGNOSTICO` AS CODIGO, `diagnosticos`.`NOMBRE_DIAGNOSTICO` AS DIAGNOSTICO, " _
                                        & "`historia_diagnosticos`.`DESCRIPCION` FROM `historia_diagnosticos` INNER JOIN `diagnosticos` ON " _
                                        & "(`historia_diagnosticos`.`ID_DIAGNOSTICO` = `diagnosticos`.`CODIGO_DIAGNOSTICO`)" _
                                        & "WHERE `historia_diagnosticos`.`ID_ORDEN`='" & filtro & "'")
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

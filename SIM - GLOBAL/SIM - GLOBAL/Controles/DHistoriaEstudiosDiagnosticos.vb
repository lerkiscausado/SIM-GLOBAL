Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DHistoriaEstudiosDiagnosticos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _HistoriaEstudiosDiagnosticos As SIM___GLOBAL.Modelo.HistoriaEstudiosDiagnosticos)
            Try
                Dim query As String
                query = "insert into historia_estudios_diagnosticos values('" & _HistoriaEstudiosDiagnosticos.IdEstudio & "','" &
                            _HistoriaEstudiosDiagnosticos.IdOrden & "','" & _HistoriaEstudiosDiagnosticos.IdDetalleOrden & "','" & _HistoriaEstudiosDiagnosticos.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _IdEstudio As String, ByVal _IdOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_estudios_diagnosticos WHERE id_estudio='" & _IdEstudio & "' AND id_orden='" & _IdOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _IdEstudio As String, ByVal _IdOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_estudio FROM historia_estudios_diagnosticos WHERE id_estudio='" & _IdEstudio & "' and id_orden='" & _IdOrden & "'")
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
        Public Function Listar(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `historia_estudios_diagnosticos`.`ID_ESTUDIO` AS CUPS, `cups`.`NOMBRE_CUPS` AS ESTUDIO, " _
                                        & "`historia_estudios_diagnosticos`.`DESCRIPCION` FROM `ordenes` INNER JOIN `historia_estudios_diagnosticos` " _
                                        & "ON (`ordenes`.`ID` = `historia_estudios_diagnosticos`.`ID_ORDEN`) INNER JOIN `cups` " _
                                        & "ON (`historia_estudios_diagnosticos`.`ID_ESTUDIO` = `cups`.`CODIGO_CUPS`) WHERE (`ordenes`.`ID` ='" & IdOrden & "')")
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
        Public Function ExisteEstudiosDiagnosticos(ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT (SELECT historia_estudios_diagnosticos.`ID_ESTUDIO` FROM historia_estudios_diagnosticos WHERE historia_estudios_diagnosticos.`ID_ORDEN`='" & _idOrden & "' LIMIT 1) AS IDESTUDIOS, " _
                        & "(SELECT historia_clinica.ESTUDIOS_DIAGNOSTICOS FROM historia_clinica WHERE historia_clinica.`ID_ORDEN`='" & _idOrden & "') AS IDHISTORIA")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                'Dim reader As OdbcDataReader
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                'reader = comando.ExecuteReader()
                If _ds.Tables(0).Rows(0)(0).ToString = "" And _ds.Tables(0).Rows(0)(1).ToString = "" Then
                    ConexionODBC.Close(_conn)
                    Return False
                Else
                    ConexionODBC.Close(_conn)
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace

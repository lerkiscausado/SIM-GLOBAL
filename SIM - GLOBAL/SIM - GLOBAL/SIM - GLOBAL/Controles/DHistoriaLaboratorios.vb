Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaLaboratorios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _historiaLaboratorios As HistoriaLaboratorios)
            Try
                Dim query As String
                query = "insert into historia_laboratorios values('" & _historiaLaboratorios.IdLaboratorio & "','" &
                            _historiaLaboratorios.IdOrden & "','" & _historiaLaboratorios.IdDetalleOrden & "','" & _historiaLaboratorios.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _idLaboratorio As String, ByVal _idOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_laboratorios WHERE id_laboratorio='" & _idLaboratorio & "' AND id_orden='" & _idOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _idLaboratorio As String, ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_laboratorio FROM historia_laboratorios WHERE id_laboratorio='" & _idLaboratorio & "' and id_orden='" & _idOrden & "'")
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
        Public Function ExisteLaboratorio(ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT (SELECT historia_laboratorios.`ID_LABORATORIO` FROM historia_laboratorios WHERE historia_laboratorios.`ID_ORDEN`='" & _idOrden & "' LIMIT 1) AS IDLABORATORIO, " _
                        & "(SELECT historia_clinica.`LABORATORIOS` FROM historia_clinica WHERE historia_clinica.`ID_ORDEN`='" & _idOrden & " ') AS IDHISTORIA")
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
        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `historia_laboratorios`.`ID_LABORATORIO` AS CUPS, `cups`.`NOMBRE_CUPS` AS EXAMEN, " _
                                        & "`historia_laboratorios`.`DESCRIPCION` FROM `ordenes` INNER JOIN `historia_laboratorios` " _
                                        & "ON (`ordenes`.`ID` = `historia_laboratorios`.`ID_ORDEN`) INNER JOIN `cups` " _
                                        & "ON (`historia_laboratorios`.`ID_LABORATORIO` = `cups`.`CODIGO_CUPS`) WHERE (`ordenes`.`ID` ='" & filtro & "')")
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


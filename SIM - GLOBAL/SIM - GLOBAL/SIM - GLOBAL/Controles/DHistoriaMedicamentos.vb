Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaMedicamentos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _HistoriaMedicamentos As HistoriaMedicamentos)
            Try
                Dim query As String
                query = "insert into historia_medicamentos values('" & _HistoriaMedicamentos.IdMedicamento & "','" &
                            _HistoriaMedicamentos.IdOrden & "','" & _HistoriaMedicamentos.IdDetalleOrden & "','" & _HistoriaMedicamentos.IdViaAdministracion & "', '" &
                            _HistoriaMedicamentos.Dosis & "', '" & _HistoriaMedicamentos.Cantidad & "', '" &
                            _HistoriaMedicamentos.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _idMedicamento As String, ByVal _idOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_medicamentos WHERE id_medicamento='" & _idMedicamento & "' AND id_orden='" & _idOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _idMedicamento As String, ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_medicamento FROM historia_medicamentos WHERE id_medicamento='" & _idMedicamento & "' and id_orden='" & _idOrden & "'")
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
                                    String.Format("SELECT historia_medicamentos.ID_MEDICAMENTO AS ID, medicamentos.NOMBRE AS MEDICAMENTO, " _
                                                  & "via_administracion.NOMBRE AS VIA, historia_medicamentos.DOSIS, " _
                                                  & "historia_medicamentos.CANTIDAD, historia_medicamentos.DESCRIPCION FROM medicamentos " _
                                                  & "INNER JOIN historia_medicamentos ON (medicamentos.ID = historia_medicamentos.ID_MEDICAMENTO) " _
                                                  & "INNER JOIN via_administracion ON (historia_medicamentos.ID_VIA_ADMINISTRACION = via_administracion.ID) " _
                                                  & "WHERE (historia_medicamentos.ID_ORDEN ='" & filtro & "')")
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
        Public Function ExisteMedicamento(ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT (SELECT historia_medicamentos.`ID_medicamento` FROM historia_medicamentos WHERE historia_medicamentos.`ID_ORDEN`='" & _idOrden & "' LIMIT 1) AS IDMEDICAMENTO, " _
                        & "(SELECT historia_clinica.`FORMULACION` FROM historia_clinica WHERE historia_clinica.`ID_ORDEN`='" & _idOrden & " ') AS IDHISTORIA")
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


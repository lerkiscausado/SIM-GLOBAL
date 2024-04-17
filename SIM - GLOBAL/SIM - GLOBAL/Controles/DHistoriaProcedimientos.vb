Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaProcedimientos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _HistoriaProcedimientos As HistoriaProcedimientos)
            Try
                Dim query As String
                query = "insert into historia_procedimientos values('" & _HistoriaProcedimientos.IdProcedimiento & "','" &
                            _HistoriaProcedimientos.IdOrden & "','" & _HistoriaProcedimientos.IdDetalleOrden & "','" & _HistoriaProcedimientos.Descripcion & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _idProcedimiento As String, ByVal _idOrden As String)
            Try
                Dim query As String
                query = "DELETE FROM historia_procedimientos WHERE id_procedimiento='" & _idProcedimiento & "' AND id_orden='" & _idOrden & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal _idProcedimiento As String, ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_procedimiento FROM historia_procedimientos WHERE id_procedimiento='" & _idProcedimiento & "' and id_orden='" & _idOrden & "'")
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
                                        "SELECT historia_procedimientos.ID_procedimiento AS CUPS, cups.NOMBRE_CUPS AS PROCEDIMIENTO, " _
                                        & "historia_procedimientos.DESCRIPCION FROM ordenes INNER JOIN historia_procedimientos " _
                                        & "ON (ordenes.ID = historia_procedimientos.ID_ORDEN) INNER JOIN cups " _
                                        & "ON (historia_procedimientos.ID_procedimiento = cups.CODIGO_CUPS) WHERE (ordenes.ID ='" & filtro & "')")
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
        Public Function ExisteProcedimientos(ByVal _idOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT (SELECT historia_procedimientos.`ID_PROCEDIMIENTO` FROM historia_procedimientos WHERE historia_procedimientos.`ID_ORDEN`='" & _idOrden & "' LIMIT 1) AS IDPROCEDIMIENTO, " _
                        & "(SELECT historia_clinica.`OTROS_ESTUDIOS` FROM historia_clinica WHERE historia_clinica.`ID_ORDEN`='" & _idOrden & "') AS IDHISTORIA")
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

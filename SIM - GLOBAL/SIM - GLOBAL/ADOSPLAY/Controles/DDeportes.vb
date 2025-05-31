Imports ADOSPLAY.My.Controles
Imports ADOSPLAY.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace My.Controles
    Public Class DDeportes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select * from deportes")
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
        Public Shared Function Cargar(ByVal filtro As String) As Deportes
            Try
                Dim query As String = String.Format("SELECT * FROM cargos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Deportes = New Deportes
                _Deportes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Deportes.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Deportes.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Deportes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Deportes As Deportes)
            Try
                Dim query As String
                If Existe(_Deportes.Id) = True Then
                    query = "UPDATE deportes SET estado='" & _Deportes.Estado & "' where id='" & _Deportes.Id & "'"
                Else
                    query = "insert into deportes values('" & _Deportes.Id & "','" &
                            _Deportes.Nombre & "','" & _Deportes.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM deportes WHERE id='" & filtro & "'")
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


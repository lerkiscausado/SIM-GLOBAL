
Imports ADOSPLAY.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace My.Controles
    Public Class DEscenarios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM escenarios WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Escenarios As Escenarios)
            Try
                Dim query As String
                If Existe(_Escenarios.Id) = True Then
                    query = "UPDATE escenarios SET nombre='" & _Escenarios.Nombre & "', " _
                            & "direccion='" & _Escenarios.Direccion & "', estado='" & _Escenarios.Estado & "' " _
                            & "where id='" & _Escenarios.Id & "'"
                Else
                    query = "insert into escenarios values('" & _Escenarios.Id & "','" &
                            _Escenarios.Nombre & "','" &
                            _Escenarios.Direccion & "', '" &
                            _Escenarios.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("select * from escenarios")
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

Imports System.Data.Common
Imports System.Data.Odbc
Imports ADOSPLAY.My.Modelo
Imports ADOSPLAY.My.Controles
Namespace Controles
    Public Class DArbitros
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Arbitros
            Try
                Dim query As String = String.Format("SELECT * FROM arbitros WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Arbitros = New Arbitros
                _Arbitros.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Arbitros.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Arbitros.Escuela = _ds.Tables(0).Rows(0)(2).ToString()
                _Arbitros.Descripcion = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Arbitros
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Arbitros As Arbitros)
            Try
                Dim query As String
                If Existe(_Arbitros.Id) = True Then
                    query = "UPDATE arbitros SET nombre='" & _Arbitros.Nombre & "', escuela='" & _Arbitros.Escuela & "', " _
                            & "descripcion='" & _Arbitros.Descripcion & "', estado='" & _Arbitros.Estado & "' where id='" & _Arbitros.Id & "'"
                Else
                    query = "insert into arbitros values('" & _Arbitros.Id & "','" &
                            _Arbitros.Nombre & "','" & _Arbitros.Escuela & "','" & _Arbitros.Descripcion & "','" & _Arbitros.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _Arbitros As Arbitros)
            Try
                Dim query As String
                query = "UPDATE arbitros SET estado='I' where id='" & _Arbitros.Id & "'"
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
                        String.Format("SELECT id FROM arbitros WHERE id='" & filtro & "'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("select id as ID, nombre as NOMBRE, escuela as ESCUELA, " _
                                                  & "descripcion as DESCRIPCION, estado as ESTADO from arbitros")
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


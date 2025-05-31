Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DProcedimientos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Procedimientos
            Try
                Dim query As String = String.Format("SELECT * FROM procedimientos WHERE id='" & filtro & "' AND estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _procedimientos = New Procedimientos
                _procedimientos.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _procedimientos.NombreProcedimiento = _ds.Tables(0).Rows(0)(1).ToString()
                _procedimientos.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _procedimientos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub Guardar(ByVal _procedimientos As Procedimientos)
            Try
                Dim query As String
                If Existe(_procedimientos.ID) = True Then
                    query = "UPDATE procedimientos SET nombre_procedimiento='" &
                        _procedimientos.NombreProcedimiento & "', estado='" & _procedimientos.Estado & "' where id='" & _procedimientos.ID & "'"
                Else
                    query = "insert into procedimientos values('" & _procedimientos.ID & "','" &
                            _procedimientos.NombreProcedimiento & "','" & _procedimientos.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal ID As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM procedimientos WHERE id='" & ID & "'")
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
                                    String.Format(
                                        "Select procedimientos.id as ID, procedimientos.nombre_procedimiento as PROCEDIMIENTO, procedimientos.estado as ESTADO " _
                                        & "from procedimientos ")
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
        Public Function ListarProcedimientos() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "select * from v_procedimientos")
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

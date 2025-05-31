Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles


    Public Class DRevisionSistemas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As RevisionSistemas
            Try
                Dim query As String = String.Format("SELECT * FROM revisionsistemas WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _RevisionSistemas = New RevisionSistemas
                _RevisionSistemas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _RevisionSistemas.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _RevisionSistemas.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _RevisionSistemas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _RevisionSistemas As RevisionSistemas)
            Try
                Dim query As String
                If Existe(_RevisionSistemas.Id) = True Then
                    query = "UPDATE revisionsistemas SET estado='" & _RevisionSistemas.Estado & "' where id='" & _RevisionSistemas.Id & "'"
                Else
                    query = "insert revisionsistemas values('" & _RevisionSistemas.Id & "','" &
                            _RevisionSistemas.Nombre & "','" & _RevisionSistemas.Estado & "')"
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
                        String.Format("SELECT id FROM revisionsistemas WHERE id='" & filtro & "'")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("select id as ID, nombre as SISTEMA from revision_sistemas where estado = 'A'")
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

Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DEventos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdEvento As String) As AGORA.Modelo.Eventos
            Try
                Dim query As String = String.Format("SELECT * FROM eventos WHERE id='" & IdEvento & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Eventos = New AGORA.Modelo.Eventos
                _Eventos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Eventos.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Eventos.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Eventos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Eventos As AGORA.Modelo.Eventos)
            Try
                Dim query As String
                If Existe(_Eventos.Id) = True Then
                    query = "UPDATE eventos SET nombre='" & _Eventos.Nombre & "', estado='" & _Eventos.Estado & "' where id='" & _Eventos.Id & "'"
                Else
                    query = "insert into eventos values('" & _Eventos.Id & "','" &
                            _Eventos.Nombre & "','" & _Eventos.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdEvento As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM eventos WHERE id='" & IdEvento & "'")
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
                                        "Select ID, nombre as EVENTO, IF(estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from eventos")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select ID, nombre as EVENTO from eventos where estado='A'")
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


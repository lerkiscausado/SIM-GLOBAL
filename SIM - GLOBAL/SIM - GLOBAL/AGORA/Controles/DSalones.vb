Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DSalones
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdSalon As String) As AGORA.Modelo.Salones
            Try
                Dim query As String = String.Format("SELECT * FROM salones WHERE id='" & IdSalon & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Salones = New AGORA.Modelo.Salones
                _Salones.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Salones.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Salones.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Salones
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Salones As AGORA.Modelo.Salones)
            Try
                Dim query As String
                If Existe(_Salones.Id) = True Then
                    query = "UPDATE salones SET nombre='" & _Salones.Nombre & "', estado='" & _Salones.Estado & "' where id='" & _Salones.Id & "'"
                Else
                    query = "insert into salones values('" & _Salones.Id & "','" &
                            _Salones.Nombre & "','" & _Salones.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdSalon As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM salones WHERE id='" & IdSalon & "'")
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
                                        "Select ID, nombre as SALON, IF(estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from salones")
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
        Public Shared Function UltimoRegistro() As AGORA.Modelo.Salones
            Try
                Dim query As String = String.Format("SELECT id FROM salones ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Salones = New AGORA.Modelo.Salones
                _Salones.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Salones
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select ID, nombre as SALON from salones where estado='A'")
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

Imports ADOSPLAY.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace My.Controles
    Public Class DEquipos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM equipos WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Equipos As Equipos)
            Try
                Dim query As String
                If Existe(_Equipos.Id) = True Then
                    query = "UPDATE equipos SET nombre='" & _Equipos.Nombre & "', direccion='" & _Equipos.Descripcion & "', " _
                            & "logo='" & _Equipos.Logo & "', id_deporte='" & _Equipos.IDDeporte & "', delegado='" & _Equipos.Delegado & "', estado='" & _Equipos.Estado & "' " _
                            & "where id='" & _Equipos.Id & "'"
                Else
                    query = "insert into equipos values('" & _Equipos.Id & "','" &
                            _Equipos.Nombre & "','" &
                            _Equipos.Descripcion & "', '" &
                            _Equipos.Logo & "', '" &
                            _Equipos.IDDeporte & "', '" &
                            _Equipos.Delegado & "', '" &
                            _Equipos.Estado & "')"
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
                                    String.Format("SELECT equipos.ID AS ID, equipos.NOMBRE AS NOMBRE, equipos.DESCRIPCION AS DESCRIPCION, equipos.LOGO AS LOGO " _
                                    & ", deportes.NOMBRE AS DEPORTE, equipos.DELEGADO AS DELEGADO, equipos.ESTADO AS ESTADO FROM equipos INNER JOIN deportes " _
                                    & "  ON (equipos.ID_DEPORTE = deportes.ID)")
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


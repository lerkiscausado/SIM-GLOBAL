Imports SIM___GLOBAL.My.Controles
Imports ADOSPLAY.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace My.Controles
    Public Class DProgramacion
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM programacion WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Programacion As Programacion)
            Try
                Dim query As String
                If Existe(_Programacion.Id) = True Then
                    query = "UPDATE programacion SET fecha='" & Format(_Programacion.Fecha, "yyyy/MM/dd") & "', " _
                            & "hora='" & Format(_Programacion.Hora, "hh:mm:ss") & "', id_equipo_local='" & _Programacion.IdEquipoLocal & "', " _
                            & "id_equipo_visitante='" & _Programacion.IdEquipoVisitante & "', " _
                            & "id_escenario='" & _Programacion.IdEscenario & "',estado='" & _Programacion.Estado & "' " _
                            & "where id='" & _Programacion.Id & "'"
                Else
                    query = "insert into programacion values('" & _Programacion.Id & "','" &
                            Format(_Programacion.Fecha, "yyyy/MM/dd") & "', '" &
                            _Programacion.IdTorneo & "', '" & _Programacion.IdEquipoLocal & "', '" &
                            _Programacion.IdEquipoVisitante & "','" & _Programacion.IdEscenario & "','" & _Programacion.Estado & "')"
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
                                    String.Format("select * from programacion")
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

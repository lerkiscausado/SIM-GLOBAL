'Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports ADOSPLAY.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace My.Controles
    Public Class DJugadores
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM jugadores WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Jugadores As Jugadores)
            Try
                Dim query As String
                If Existe(_Jugadores.Id) = True Then
                    query = "UPDATE jugadores SET nombre='" & _Jugadores.Nombre & "', " _
                            & "fecha_nacimiento='" & Format(_Jugadores.FechaNacimiento, "yyyy/MM/dd") & "', sexo='" & _Jugadores.Sexo & "', " _
                            & "estatura='" & _Jugadores.Estatura & "', " _
                            & "peso='" & _Jugadores.Peso & "',correo='" & _Jugadores.Correo & "',telefono='" & _Jugadores.Telefono & "' " _
                            & "where id='" & _Jugadores.Id & "'"
                Else
                    query = "insert into jugadores values('" & _Jugadores.Id & "','" &
                            _Jugadores.Nombre & "','" &
                            Format(_Jugadores.FechaNacimiento, "yyyy/MM/dd") & "', '" &
                            _Jugadores.Sexo & "', '" & _Jugadores.Estatura & "', '" &
                            _Jugadores.Peso & "','" & _Jugadores.Correo & "','" & _Jugadores.Telefono & "')"
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
                                    String.Format("select id as ID, nombre as NOMBRE, YEAR(CURDATE())-YEAR(fecha_nacimiento) as EDAD, estatura as ESTATURA, peso as PESO from jugadores")
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

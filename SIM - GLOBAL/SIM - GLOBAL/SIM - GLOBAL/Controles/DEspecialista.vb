Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEspecialista
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select id as ID, nombre as NOMBRE, especialidad as ESPECIALIDAD " _
                                        & "from especialistas ")
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
        Public Sub Guardar(ByVal _Especialista As SIM___GLOBAL.Modelo.Especialista)
            Try
                Dim query As String
                If Existe(_Especialista.IdEspecialista) = True Then
                    query = "UPDATE especialistas SET nombre='" & _Especialista.Nombre & "', " _
                            & "especialidad='" & _Especialista.Especialidad & "', " _
                            & "registro_medico='" & _Especialista.RegistroMedico & "', " _
                            & "estado='" & _Especialista.Estado & "' where id_especialista='" & _Especialista.IdEspecialista & "'"
                Else
                    query = "insert into especialistas values('" & _Especialista.Id & "', " _
                            & "'" & _Especialista.IdEspecialista & "','" & _Especialista.Nombre & "', '" & _Especialista.Especialidad & "'," _
                            & "'" & _Especialista.RegistroMedico & "','" & _Especialista.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Guardar2(ByVal _Especialista As SIM___GLOBAL.Modelo.Especialista)
            Try
                'Dim query As String

                Dim sql As String = "insert into especialistas " _
                                    & "(ID,ID_ESPECIALISTA,NOMBRE,ESPECIALIDAD,REGISTRO_MEDICO,ESTADO,FIRMA) " _
                                    & "values(?,?,?,?,?,?,?)"

                _conn = ConexionODBC.Open()

                Dim Comando As New OdbcCommand(sql, _conn)
                'Dim Firma As Byte()

                'If Firma Is Nothing Then
                'Firma = DBNull.Value
                'Else
                ' Firma = _funciones.Imagen_Bytes(_Especialista.Firma)
                'End If
                Comando.Parameters.AddWithValue(1, Val(_Especialista.Id))
                Comando.Parameters.AddWithValue(2, _Especialista.IdEspecialista)
                Comando.Parameters.AddWithValue(3, _Especialista.Nombre)
                Comando.Parameters.AddWithValue(4, _Especialista.Especialidad)
                Comando.Parameters.AddWithValue(5, _Especialista.RegistroMedico)
                Comando.Parameters.AddWithValue(6, _Especialista.Estado)
                'If Firma Is Nothing Then
                Comando.Parameters.AddWithValue(7, DBNull.Value)
                'Else
                'Comando.Parameters.AddWithValue(7, Firma)
                'End If
                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM especialistas WHERE id_especialista='" & filtro & "'")
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


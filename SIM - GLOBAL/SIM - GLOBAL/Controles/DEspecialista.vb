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
                            & "identificacion='" & _Especialista.Identificacion & "', " _
                            & "registro_medico='" & _Especialista.RegistroMedico & "', " _
                            & "estado='" & _Especialista.Estado & "' where id_especialista='" & _Especialista.IdEspecialista & "'"
                Else
                    query = "insert into especialistas values('" & _Especialista.Id & "', " _
                            & "'" & _Especialista.IdEspecialista & "','" & _Especialista.IdTipoIdentificacion & "','" & _Especialista.Identificacion & "','" & _Especialista.Nombre & "', '" & _Especialista.Especialidad & "'," _
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
                                    & "(ID,ID_ESPECIALISTA,ID_TIPO_IDENTIFICACION, IDENTIFICACION, NOMBRE,ESPECIALIDAD,REGISTRO_MEDICO,ESTADO,FIRMA) " _
                                    & "values(?,?,?,?,?,?,?,?,?)"

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
                Comando.Parameters.AddWithValue(3, _Especialista.IdTipoIdentificacion)
                Comando.Parameters.AddWithValue(4, _Especialista.Identificacion)
                Comando.Parameters.AddWithValue(5, _Especialista.Nombre)
                Comando.Parameters.AddWithValue(6, _Especialista.Especialidad)
                Comando.Parameters.AddWithValue(7, _Especialista.RegistroMedico)
                Comando.Parameters.AddWithValue(8, _Especialista.Estado)
                'If Firma Is Nothing Then
                Comando.Parameters.AddWithValue(9, DBNull.Value)
                'Else
                'Comando.Parameters.AddWithValue(7, Firma)
                'End If
                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)

                ' Nombre estructurado para RDA (RETHUS exige apellido paterno/materno por
                ' separado). UPDATE aparte y defensivo por si la migración correspondiente
                ' (Sql/rda_especialistas_nombre_estructurado.sql) aún no se ha corrido.
                Try
                    Dim sqlRda As String = "UPDATE especialistas SET primer_nombre = ?, segundo_nombre = ?, primer_apellido = ?, segundo_apellido = ? WHERE id_especialista = ?"
                    _conn = ConexionODBC.Open()
                    Dim comandoRda As New OdbcCommand(sqlRda, _conn)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.PrimerNombre)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.SegundoNombre)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.PrimerApellido)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.SegundoApellido)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.IdEspecialista)
                    comandoRda.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                Catch
                    ' Columnas RDA aún no existen en esta base: se ignora, no bloquea el registro.
                End Try
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
        ''' <summary>
        ''' Trae el nombre estructurado (para RDA/RETHUS) de un especialista. Lectura
        ''' defensiva: si las columnas aún no existen (migración no corrida), retorna
        ''' todo vacío en vez de lanzar excepción.
        ''' </summary>
        Public Function TraerNombreEstructurado(ByVal filtro As String) As (PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String)
            Try
                Dim query As String = "SELECT primer_nombre, segundo_nombre, primer_apellido, segundo_apellido FROM especialistas WHERE id_especialista = ?"
                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue("?", filtro)
                Dim reader As OdbcDataReader = comando.ExecuteReader()
                If reader.Read() Then
                    Dim resultado = (
                        If(IsDBNull(reader("primer_nombre")), "", reader("primer_nombre").ToString()),
                        If(IsDBNull(reader("segundo_nombre")), "", reader("segundo_nombre").ToString()),
                        If(IsDBNull(reader("primer_apellido")), "", reader("primer_apellido").ToString()),
                        If(IsDBNull(reader("segundo_apellido")), "", reader("segundo_apellido").ToString())
                    )
                    ConexionODBC.Close(_conn)
                    Return resultado
                End If
                ConexionODBC.Close(_conn)
            Catch
                ' Columnas RDA aún no existen en esta base: se retorna vacío.
            End Try
            Return ("", "", "", "")
        End Function

        Public Function TraerIdentificacion(ByVal filtro As String) As String
            Try
                Dim query As String = "SELECT identificacion FROM especialistas WHERE id_especialista = ?"
                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue("?", filtro)

                Dim reader As OdbcDataReader = comando.ExecuteReader()

                If reader.Read() Then
                    Dim identificacion As String = reader("identificacion").ToString()
                    ConexionODBC.Close(_conn)
                    Return identificacion
                Else
                    ConexionODBC.Close(_conn)
                    Return String.Empty
                End If

            Catch ex As Exception
                MessageBox.Show("Error al traer identificación: " & ex.Message)
                ConexionODBC.Close(_conn)
                Return String.Empty
            End Try
        End Function
        Public Sub Actualizar(ByVal _Especialista As SIM___GLOBAL.Modelo.Especialista)
            Try
                Dim sql As String = "UPDATE especialistas SET " &
                                    "ID_TIPO_IDENTIFICACION = ?, " &
                                    "IDENTIFICACION = ?, " &
                                    "NOMBRE = ?, " &
                                    "ESPECIALIDAD = ?, " &
                                    "REGISTRO_MEDICO = ?, " &
                                    "ESTADO = ?, " &
                                    "FIRMA = ? " &
                                    "WHERE ID_ESPECIALISTA = ?"

                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(sql, _conn)

                comando.Parameters.AddWithValue("?", _Especialista.IdTipoIdentificacion)
                comando.Parameters.AddWithValue("?", _Especialista.Identificacion)
                comando.Parameters.AddWithValue("?", _Especialista.Nombre)
                comando.Parameters.AddWithValue("?", _Especialista.Especialidad)
                comando.Parameters.AddWithValue("?", _Especialista.RegistroMedico)
                comando.Parameters.AddWithValue("?", _Especialista.Estado)
                comando.Parameters.AddWithValue("?", DBNull.Value)           ' FIRMA
                comando.Parameters.AddWithValue("?", _Especialista.IdEspecialista) ' WHERE

                Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                ' Nombre estructurado para RDA: UPDATE aparte y defensivo (ver nota en Guardar2).
                Try
                    Dim sqlRda As String = "UPDATE especialistas SET primer_nombre = ?, segundo_nombre = ?, primer_apellido = ?, segundo_apellido = ? WHERE id_especialista = ?"
                    _conn = ConexionODBC.Open()
                    Dim comandoRda As New OdbcCommand(sqlRda, _conn)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.PrimerNombre)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.SegundoNombre)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.PrimerApellido)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.SegundoApellido)
                    comandoRda.Parameters.AddWithValue("?", _Especialista.IdEspecialista)
                    comandoRda.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                Catch
                    ' Columnas RDA aún no existen en esta base: se ignora.
                End Try

                If filasAfectadas > 0 Then
                    MessageBox.Show("✅ Especialista actualizado correctamente.")
                Else
                    MessageBox.Show("⚠️ No se encontró el especialista para actualizar.")
                End If

            Catch ex As Exception
                ConexionODBC.Close(_conn)
                MessageBox.Show("Error al actualizar: " & ex.ToString())
            End Try
        End Sub
    End Class
End Namespace


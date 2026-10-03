Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo

Namespace Controles
    Public Class DCargos

        ''' <summary>
        ''' Busca un cargo por su Id. Devuelve Nothing si no existe.
        ''' </summary>
        Public Shared Function Cargar(ByVal filtro As String) As Cargos
            Dim query As String = "SELECT id, nombre_cargo, estado FROM cargos WHERE id = ?"
            Using conn As OdbcConnection = ConexionODBC.Open()
                Using comando As New OdbcCommand(query, conn)
                    comando.Parameters.AddWithValue("id", filtro)
                    Using reader As OdbcDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            Return New Cargos With {
                                .Id = Convert.ToInt32(reader("id")),
                                .NombreCargo = reader("nombre_cargo").ToString(),
                                .Estado = reader("estado").ToString()
                            }
                        End If
                        Return Nothing
                    End Using
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Inserta el cargo si no existe, o actualiza su estado si ya existe.
        ''' </summary>
        Public Sub Guardar(ByVal cargo As Cargos)
            Using conn As OdbcConnection = ConexionODBC.Open()
                Dim query As String
                If Existe(cargo.Id.ToString(), conn) Then
                    query = "UPDATE cargos SET estado = ? WHERE id = ?"
                    Using comando As New OdbcCommand(query, conn)
                        comando.Parameters.AddWithValue("estado", cargo.Estado)
                        comando.Parameters.AddWithValue("id", cargo.Id)
                        comando.ExecuteNonQuery()
                    End Using
                Else
                    query = "INSERT INTO cargos (id, nombre_cargo, estado) VALUES (?, ?, ?)"
                    Using comando As New OdbcCommand(query, conn)
                        comando.Parameters.AddWithValue("id", cargo.Id)
                        comando.Parameters.AddWithValue("nombre_cargo", cargo.NombreCargo)
                        comando.Parameters.AddWithValue("estado", cargo.Estado)
                        comando.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Sub
        Private Sub GuardarTokenCache(configId As Integer,
                               accessToken As String,
                               tokenType As String,
                               expiresIn As Integer)
            Try
                Dim sql As String = "UPDATE interop_token_cache SET " &
                            "access_token = ?, " &
                            "token_type = ?, " &
                            "expires_in = ?, " &
                            "fecha_expiracion = DATE_ADD(NOW(), INTERVAL ? SECOND), " &
                            "fecha_captura = NOW() " &
                            "WHERE config_id = ?"

                Using conn As OdbcConnection = ConexionODBC.Open()
                    Dim comando As New OdbcCommand(sql, conn)
                    comando.Parameters.AddWithValue("?", accessToken)
                    comando.Parameters.AddWithValue("?", "Bearer")
                    comando.Parameters.AddWithValue("?", expiresIn)
                    comando.Parameters.AddWithValue("?", expiresIn)  ' para el DATE_ADD
                    comando.Parameters.AddWithValue("?", 1)   ' para el WHERE

                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                    ' ── Si no existe el registro, lo insertamos ───────────────
                    If filasAfectadas = 0 Then
                        Dim sqlInsert As String = "INSERT INTO interop_token_cache " &
                                         "(config_id, access_token, token_type, expires_in, fecha_expiracion) " &
                                         "VALUES (?, ?, ?, ?, DATE_ADD(NOW(), INTERVAL ? SECOND))"

                        Dim comandoInsert As New OdbcCommand(sqlInsert, conn)
                        comandoInsert.Parameters.AddWithValue("?", configId)
                        comandoInsert.Parameters.AddWithValue("?", accessToken)
                        comandoInsert.Parameters.AddWithValue("?", tokenType)
                        comandoInsert.Parameters.AddWithValue("?", expiresIn)
                        comandoInsert.Parameters.AddWithValue("?", expiresIn)
                        comandoInsert.ExecuteNonQuery()
                    End If
                End Using ' ── El Using cierra la conexión automáticamente ───────

            Catch ex As Exception
                MessageBox.Show("Error al guardar token: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Elimina lógicamente un cargo (lo marca como Estado = 'E').
        ''' </summary>
        Public Sub Eliminar(ByVal cargo As Cargos)
            Dim query As String = "UPDATE cargos SET estado = 'E' WHERE id = ?"
            Using conn As OdbcConnection = ConexionODBC.Open()
                Using comando As New OdbcCommand(query, conn)
                    comando.Parameters.AddWithValue("id", cargo.Id)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ''' <summary>
        ''' Indica si ya existe un cargo con el id dado. Reutiliza una conexión abierta si se provee.
        ''' </summary>
        Public Function Existe(ByVal filtro As String, Optional ByVal conexionExistente As OdbcConnection = Nothing) As Boolean
            Dim query As String = "SELECT 1 FROM cargos WHERE id = ?"
            Dim conn As OdbcConnection = If(conexionExistente, ConexionODBC.Open())
            Try
                Using comando As New OdbcCommand(query, conn)
                    comando.Parameters.AddWithValue("id", filtro)
                    Using reader As OdbcDataReader = comando.ExecuteReader()
                        Return reader.Read()
                    End Using
                End Using
            Finally
                If conexionExistente Is Nothing Then
                    conn.Close()
                    conn.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Lista todos los cargos con el estado ya traducido a texto (ACTIVO/INACTIVO).
        ''' </summary>
        Public Function Listar() As DataSet
            Dim query As String =
                "SELECT ID, NOMBRE_CARGO, IF(ESTADO = 'A', 'ACTIVO', 'INACTIVO') AS ESTADO FROM cargos"
            Using conn As OdbcConnection = ConexionODBC.Open()
                Using comando As New OdbcCommand(query, conn)
                    Using adapter As New OdbcDataAdapter(comando)
                        Dim ds As New DataSet()
                        adapter.Fill(ds)
                        Return ds
                    End Using
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Lista solo los cargos activos, para usarse en combos/desplegables.
        ''' </summary>
        Public Function ListarCombo() As DataSet
            Dim query As String = "SELECT id AS ID, nombre_cargo AS CARGO FROM cargos WHERE estado = 'A'"
            Using conn As OdbcConnection = ConexionODBC.Open()
                Using comando As New OdbcCommand(query, conn)
                    Using adapter As New OdbcDataAdapter(comando)
                        Dim ds As New DataSet()
                        adapter.Fill(ds)
                        Return ds
                    End Using
                End Using
            End Using
        End Function
    End Class
End Namespace


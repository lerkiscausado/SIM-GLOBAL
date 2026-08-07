Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Imports System.Net.Http
Namespace Controles
    Public Class DRDA
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar() As ConfigInteropApi
            Try
                Dim query As String = String.Format("SELECT * FROM config_interop_api")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                ' AQUI TRAEMOS LOS DATOS DE CONEXION
                ' 2. Capturar temporalmente los datos ingresados en el formulario en tu modelo
                Dim configTemporal As New ConfigInteropApi With {
                .Id = _ds.Tables(0).Rows(0)(0).ToString(),
                .Ambiente = _ds.Tables(0).Rows(0)(1).ToString(),
                .TenantId = _ds.Tables(0).Rows(0)(2).ToString(),
                .ClientId = _ds.Tables(0).Rows(0)(3).ToString(),
                .ClientSecret = _ds.Tables(0).Rows(0)(4).ToString(),
                .SubscriptionKey = _ds.Tables(0).Rows(0)(5).ToString(),
                .UrlAuthServer = _ds.Tables(0).Rows(0)(6).ToString(),
                .UrlBaseApi = _ds.Tables(0).Rows(0)(7).ToString()
          }

                ' Columnas agregadas para el envío del Bundle RDA-Paciente (código REPS y NIT del prestador).
                ' Lectura defensiva por nombre para no romper instalaciones que aún no tengan la migración aplicada.
                Dim tabla As DataTable = _ds.Tables(0)
                If tabla.Columns.Contains("codigo_prestador_reps") Then
                    configTemporal.CodigoPrestadorReps = _ds.Tables(0).Rows(0)("codigo_prestador_reps").ToString()
                End If
                If tabla.Columns.Contains("nit_prestador") Then
                    configTemporal.NitPrestador = _ds.Tables(0).Rows(0)("nit_prestador").ToString()
                End If

                Return configTemporal
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Guardar(ByVal _ConfigInteropApi As ConfigInteropApi) As Boolean
            Dim conn As OdbcConnection = Nothing
            Try
                conn = ConexionODBC.Open()

                Dim query As String = "INSERT INTO config_interop_api " &
            "(id, ambiente, tenant_id, client_id, client_secret, subscription_key, url_auth_server, url_base_api, codigo_prestador_reps, nit_prestador, estado, fecha_registro,fecha_actualizacion) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?)"

                Using comando As New OdbcCommand(query, conn)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.Id)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.Ambiente)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.TenantId)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.ClientId)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.ClientSecret)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.SubscriptionKey)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.UrlAuthServer)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.UrlBaseApi)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.CodigoPrestadorReps)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.NitPrestador)
                    comando.Parameters.AddWithValue("?", 1)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.FechaRegistro)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.FechaActualizacion)

                    comando.ExecuteNonQuery()
                End Using

                Return True

            Catch ex As Exception
                ' Mejor loguear el error y relanzarlo o manejarlo en la capa de UI
                Throw New Exception("Error al guardar la configuración de interoperabilidad: " & ex.Message, ex)

            Finally
                If conn IsNot Nothing Then
                    ConexionODBC.Close(conn)
                End If
            End Try
        End Function
        Public Sub GuardarTokenCache(configId As Integer,
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
        Public Shared Function Actualizar(config As ConfigInteropApi) As Boolean
            Try
                Dim query As String = String.Format(
            "UPDATE config_interop_api SET " &
            "ambiente = ?, " &
            "tenant_id = ?, " &
            "client_id = ?, " &
            "client_secret = ?, " &
            "subscription_key = ?, " &
            "url_auth_server = ?, " &
            "url_base_api = ?, " &
            "codigo_prestador_reps = ?, " &
            "nit_prestador = ? " &
            "WHERE id = ?")

                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(query, _conn)

                ' Parámetros en el mismo orden del UPDATE
                comando.Parameters.AddWithValue("?", config.Ambiente)
                comando.Parameters.AddWithValue("?", config.TenantId)
                comando.Parameters.AddWithValue("?", config.ClientId)
                comando.Parameters.AddWithValue("?", config.ClientSecret)
                comando.Parameters.AddWithValue("?", config.SubscriptionKey)
                comando.Parameters.AddWithValue("?", config.UrlAuthServer)
                comando.Parameters.AddWithValue("?", config.UrlBaseApi)
                comando.Parameters.AddWithValue("?", config.CodigoPrestadorReps)
                comando.Parameters.AddWithValue("?", config.NitPrestador)
                comando.Parameters.AddWithValue("?", 1)  ' <-- asegúrate que ConfigInteropApi tenga la propiedad Id

                Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

                If filasAfectadas > 0 Then
                    MessageBox.Show("✅ Configuración actualizada correctamente.")
                    Return True
                Else
                    MessageBox.Show("⚠️ No se encontró el registro para actualizar.")
                    Return False
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message)
                ConexionODBC.Close(_conn)
                Return False
            End Try
        End Function
        '------------------------------------------------------------------------------------
        Public Async Function TraerToken(ByVal configId As Integer) As Task(Of String)
            Try
                ' ── 1. Verificar si hay token vigente ────────────────────
                Dim sql As String = "SELECT access_token FROM interop_token_cache " &
                                    "WHERE config_id = ? " &
                                    "AND fecha_expiracion > NOW() " &
                                    "ORDER BY fecha_captura DESC LIMIT 1"

                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(sql, _conn)
                comando.Parameters.AddWithValue("?", configId)

                Dim reader As OdbcDataReader = comando.ExecuteReader()

                If reader.Read() Then
                    Dim tokenVigente As String = reader("access_token").ToString()
                    ConexionODBC.Close(_conn)
                    Return tokenVigente
                End If

                reader.Close()
                ConexionODBC.Close(_conn)

                ' ── 2. Token expirado: traer configuración de la BD ──────
                Dim sqlConfig As String = "SELECT ambiente, tenant_id, client_id, client_secret, " &
                                          "url_auth_server, url_base_api, subscription_key " &
                                          "FROM config_interop_api WHERE id = ? AND estado = 1 LIMIT 1"

                _conn = ConexionODBC.Open()
                Dim comandoConfig As New OdbcCommand(sqlConfig, _conn)
                comandoConfig.Parameters.AddWithValue("?", configId)

                Dim readerConfig As OdbcDataReader = comandoConfig.ExecuteReader()

                If Not readerConfig.Read() Then
                    ConexionODBC.Close(_conn)
                    MessageBox.Show("⚠️ No se encontró configuración activa para autenticar.")
                    Return String.Empty
                End If

                Dim configTemporal As New ConfigInteropApi With {
                    .Ambiente = If(readerConfig("ambiente").ToString() = "SANDBOX", 1, 0),
                    .TenantId = readerConfig("tenant_id").ToString(),
                    .ClientId = readerConfig("client_id").ToString(),
                    .ClientSecret = readerConfig("client_secret").ToString(),
                    .UrlAuthServer = readerConfig("url_auth_server").ToString(),
                    .UrlBaseApi = readerConfig("url_base_api").ToString()
                }

                readerConfig.Close()
                ConexionODBC.Close(_conn)

                ' ── 3. Solicitar nuevo token a la API ────────────────────
                Dim nuevoToken As String = Await SolicitarNuevoToken(configTemporal, configId)
                Return nuevoToken

            Catch ex As Exception
                ConexionODBC.Close(_conn)
                MessageBox.Show("Error TraerToken: " & ex.Message)
                Return String.Empty
            End Try
        End Function

        ' ── Solicitar nuevo token y guardarlo en cache ────────────────────
        ' NOTA: Delega en SIM___GLOBAL.Utilidades.InteropAuthService, que implementa el flujo
        ' OAuth2 real de MinSalud (Azure AD - login.microsoftonline.com, grant_type=client_credentials
        ' + scope). Antes había aquí una segunda implementación (username/password contra
        ' UrlAuthServer & "/oauth/token") que no correspondía al Postman/documentación oficial;
        ' se unifica para evitar dos caminos distintos de autenticación con MinSalud.
        Private Async Function SolicitarNuevoToken(config As ConfigInteropApi,
                                                   configId As Integer) As Task(Of String)
            Try
                Dim tokenInfo As TokenResponse = Await SIM___GLOBAL.Utilidades.InteropAuthService.SolicitarTokenAsync(config)

                If tokenInfo Is Nothing OrElse String.IsNullOrEmpty(tokenInfo.AccessToken) Then
                    MessageBox.Show("El servidor de MinSalud no retornó un token de acceso válido.")
                    Return String.Empty
                End If

                ' ── Guardar nuevo token en cache ───────────────────────
                GuardarTokenCache(configId, tokenInfo.AccessToken, tokenInfo.TokenType, tokenInfo.ExpiresIn)

                Return tokenInfo.AccessToken

            Catch ex As Exception
                MessageBox.Show("Error SolicitarNuevoToken: " & ex.Message)
                Return String.Empty
            End Try
        End Function

        ' ── Guardar token en la tabla interop_token_cache ─────────────────

        '------------------------------------------------------------------------------------
    End Class
End Namespace

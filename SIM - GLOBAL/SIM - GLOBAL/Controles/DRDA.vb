Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
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
            "(id, ambiente, tenant_id, client_id, client_secret, subscription_key, url_auth_server, url_base_api, estado, fecha_registro,fecha_actualizacion) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?,?)"

                Using comando As New OdbcCommand(query, conn)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.Id)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.Ambiente)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.TenantId)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.ClientId)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.ClientSecret)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.SubscriptionKey)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.UrlAuthServer)
                    comando.Parameters.AddWithValue("?", _ConfigInteropApi.UrlBaseApi)
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
                    "url_base_api = ? " &
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
    End Class
End Namespace

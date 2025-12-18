Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades

Namespace Controles
    Public Class DSmtpConfig

        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As OdbcDataAdapter

        ' =======================
        '   CARGAR CONFIGURACIÓN
        ' =======================
        Public Shared Function Cargar(ByVal Id As String) As SmtpConfig
            Try
                Dim query As String = "SELECT * FROM smtp_config WHERE id='" & Id & "'"
                _conn = ConexionODBC.Open()

                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)

                ConexionODBC.Close(_conn)

                If _ds.Tables(0).Rows.Count = 0 Then Return Nothing

                Dim fila = _ds.Tables(0).Rows(0)
                Dim config As New SmtpConfig With {
                    .Id = fila("id"),
                    .NombreConfig = fila("nombre_config"),
                    .SmtpHost = fila("smtp_host"),
                    .SmtpPort = fila("smtp_port"),
                    .SmtpUser = fila("smtp_user"),
                    .SmtpPassword = fila("smtp_password"),
                    .SmtpFrom = fila("smtp_from"),
                    .DisplayName = fila("display_name"),
                    .EnableSsl = fila("enable_ssl"),
                    .IsActive = fila("is_active"),
                    .CreatedAt = fila("createdAt")
                }

                Return config

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function


        ' =======================
        '       EXISTE
        ' =======================
        Public Shared Function Existe(ByVal NombreConfig As String) As Boolean
            Try
                Dim query As String =
                    "SELECT id FROM smtp_config WHERE nombre_config='" & NombreConfig & "'"

                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(query, _conn)

                Dim reader = comando.ExecuteReader()

                Dim existeId = reader.Read()

                ConexionODBC.Close(_conn)

                Return existeId

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Function


        ' =======================
        '       GUARDAR
        ' =======================
        Public Sub Guardar(ByVal config As SmtpConfig)
            Try
                Dim query As String

                If Existe(config.NombreConfig) Then
                    ' UPDATE
                    query =
                        "UPDATE smtp_config SET " &
                        "smtp_host='" & config.SmtpHost & "', " &
                        "smtp_port='" & config.SmtpPort & "', " &
                        "smtp_user='" & config.SmtpUser & "', " &
                        "smtp_password='" & config.SmtpPassword & "', " &
                        "smtp_from='" & config.SmtpFrom & "', " &
                        "display_name='" & config.DisplayName & "', " &
                        "enable_ssl='" & config.EnableSsl & "', " &
                        "is_active='" & config.IsActive & "' " &
                        "WHERE nombre_config='" & config.NombreConfig & "'"
                Else
                    ' INSERT
                    query =
                        "INSERT INTO smtp_config (" &
                        "nombre_config, smtp_host, smtp_port, smtp_user, smtp_password, " &
                        "smtp_from, display_name, enable_ssl, is_active, createdAt) " &
                        "VALUES ('" & config.NombreConfig & "', '" & config.SmtpHost & "', '" &
                        config.SmtpPort & "', '" & config.SmtpUser & "', '" &
                        config.SmtpPassword & "', '" & config.SmtpFrom & "', '" &
                        config.DisplayName & "', '" & config.EnableSsl & "', '" &
                        config.IsActive & "', NOW())"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        ' =======================
        '      LISTAR TODO
        ' =======================
        Public Function Listar() As DataSet
            Try
                Dim query As String = "SELECT * FROM smtp_config ORDER BY fecha_creacion DESC"

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


        ' =======================
        '    OBTENER CONFIG ACTIVA
        ' =======================
        Public Shared Function GetActiva() As SmtpConfig
            Try
                Dim query As String = "SELECT * FROM smtp_config WHERE is_active='1' LIMIT 1"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)

                If _ds.Tables(0).Rows.Count = 0 Then Return Nothing

                Dim fila = _ds.Tables(0).Rows(0)

                Return New SmtpConfig With {
                    .Id = fila("id"),
                    .NombreConfig = fila("nombre_config"),
                    .SmtpHost = fila("smtp_host"),
                    .SmtpPort = fila("smtp_port"),
                    .SmtpUser = fila("smtp_user"),
                    .SmtpPassword = fila("smtp_password"),
                    .SmtpFrom = fila("smtp_from"),
                    .DisplayName = fila("display_name"),
                    .EnableSsl = fila("enable_ssl"),
                    .IsActive = fila("is_active"),
                    .CreatedAt = fila("fecha_creacion")
                }

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

    End Class
End Namespace


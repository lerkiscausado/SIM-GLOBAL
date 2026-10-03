
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc

Namespace Controles
    Public Class DLogin

        ' ─────────────────────────────────────────────
        ' VALIDAR LOGIN
        ' ─────────────────────────────────────────────
        Public Function Validar(ByVal usuario As String, ByVal clave As String) As Boolean
            Const sql As String =
                "SELECT 1 FROM users WHERE usuario = ? AND pass = ? AND estado = 'A'"

            Try
                Using conn As OdbcConnection = ConexionODBC.Open()
                    If conn Is Nothing Then
                        Throw New InvalidOperationException("No se pudo establecer la conexión.")
                    End If

                    Using cmd As New OdbcCommand(sql, conn)
                        cmd.Parameters.Add("@usuario", OdbcType.VarChar, 50).Value = usuario
                        cmd.Parameters.Add("@pass", OdbcType.VarChar, 50).Value = clave

                        Using reader As OdbcDataReader = cmd.ExecuteReader()
                            Return reader.Read()
                        End Using
                    End Using
                End Using

            Catch ex As OdbcException
                Throw New ApplicationException("Error en la validación de usuario.", ex)
            End Try
        End Function

        ' ─────────────────────────────────────────────
        ' AUDITAR (verificar si es admin)
        ' ─────────────────────────────────────────────
        Public Function Auditar(ByVal usuario As String, ByVal clave As String) As Boolean
            Const sql As String =
                "SELECT id FROM users 
                 WHERE usuario = ? AND pass = ? AND estado = 'A' AND admin <> '0'"

            Try
                Using conn As OdbcConnection = ConexionODBC.Open()
                    If conn Is Nothing Then
                        Throw New InvalidOperationException("No se pudo establecer la conexión.")
                    End If

                    Using cmd As New OdbcCommand(sql, conn)
                        cmd.Parameters.Add("@usuario", OdbcType.VarChar, 50).Value = usuario
                        cmd.Parameters.Add("@pass", OdbcType.VarChar, 50).Value = clave

                        Using reader As OdbcDataReader = cmd.ExecuteReader()
                            Return reader.Read()
                        End Using
                    End Using
                End Using

            Catch ex As OdbcException
                Throw New ApplicationException("Error en la auditoría de usuario.", ex)
            End Try

            Return False
        End Function

        ' ─────────────────────────────────────────────
        ' LISTAR (básico: ID y nombre)
        ' ─────────────────────────────────────────────
        Public Function Listar(ByVal usuario As String, ByVal clave As String) As DataSet
            Const sql As String =
                "SELECT empleados.ID, empleados.NOMBRE_EMPLEADO
                 FROM users 
                 INNER JOIN empleados ON users.ID_EMPLEADO = empleados.ID
                 WHERE users.USUARIO = ? AND users.PASS = ? AND users.ESTADO = 'A'"

            Try
                Using conn As OdbcConnection = ConexionODBC.Open()
                    If conn Is Nothing Then
                        Throw New InvalidOperationException("No se pudo establecer la conexión.")
                    End If

                    Using cmd As New OdbcCommand(sql, conn)
                        cmd.Parameters.Add("@usuario", OdbcType.VarChar, 50).Value = usuario
                        cmd.Parameters.Add("@pass", OdbcType.VarChar, 50).Value = clave

                        Dim ds As New DataSet()
                        Using adapter As New OdbcDataAdapter(cmd)
                            adapter.Fill(ds)
                        End Using
                        Return ds
                    End Using
                End Using

            Catch ex As OdbcException
                Throw New ApplicationException("Error al listar empleado.", ex)
            End Try

            Return Nothing
        End Function

        ' ─────────────────────────────────────────────
        ' LISTAR EMPLEADOS (completo: cargo, especialidad, licencia)
        ' ─────────────────────────────────────────────
        Public Function ListarEmpleados(ByVal usuario As String, ByVal clave As String) As DataSet
            Const sql As String =
                "SELECT 
                    empleados.ID,
                    empleados.NOMBRE_EMPLEADO  AS NOMBRE,
                    cargos.NOMBRE_CARGO        AS CARGO,
                    especialidades.NOMBRE_ESPECIALIDAD AS ESPECIALIDAD,
                    empleados.id_especialidad,
                    users.id_licencia
                 FROM empleados
                 INNER JOIN cargos        ON empleados.ID_CARGO        = cargos.ID
                 INNER JOIN especialidades ON empleados.ID_ESPECIALIDAD = especialidades.ID
                 INNER JOIN users          ON users.ID_EMPLEADO         = empleados.ID
                 WHERE users.USUARIO = ? AND users.PASS = ?"

            Try
                Using conn As OdbcConnection = ConexionODBC.Open()
                    If conn Is Nothing Then
                        Throw New InvalidOperationException("No se pudo establecer la conexión.")
                    End If

                    Using cmd As New OdbcCommand(sql, conn)
                        cmd.Parameters.Add("@usuario", OdbcType.VarChar, 50).Value = usuario
                        cmd.Parameters.Add("@pass", OdbcType.VarChar, 50).Value = clave

                        Dim ds As New DataSet()
                        Using adapter As New OdbcDataAdapter(cmd)
                            adapter.Fill(ds)
                        End Using
                        Return ds
                    End Using
                End Using

            Catch ex As OdbcException
                Throw New ApplicationException("Error al listar datos del empleado.", ex)
            End Try

            Return Nothing
        End Function

    End Class
End Namespace

Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DLogin
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Validar(ByVal usuario As String, ByVal clave As String) As Boolean
            Const sql As String = "SELECT 1 FROM users WHERE usuario = ? AND pass = ? AND estado = 'A'"

            Try
                ' Abrir conexión
                Using conn As OdbcConnection = ConexionODBC.Open()
                    If conn Is Nothing Then
                        Throw New InvalidOperationException("No se pudo establecer la conexión a la base de datos.")
                    End If

                    ' Crear comando parametrizado
                    Using cmd As New OdbcCommand(sql, conn)
                        cmd.Parameters.Add("usuario", OdbcType.VarChar, 50).Value = usuario
                        cmd.Parameters.Add("pass", OdbcType.VarChar, 50).Value = clave

                        ' Ejecutar lector
                        Using reader As OdbcDataReader = cmd.ExecuteReader()
                            Return reader.Read()  ' True si hay al menos un registro
                        End Using
                    End Using
                End Using

            Catch ex As OdbcException
                ' Aquí podrías loguear a un archivo o re-lanzar
                Throw New ApplicationException("Error en la validación de usuario.", ex)
            End Try
        End Function

        Public Function Auditar(ByVal usuario As String, ByVal clave As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM users WHERE usuario='" & usuario & "' AND pass='" & clave & "' AND estado='A' AND admin <> '0'")
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

        Public Function Listar(ByVal usuario As String, ByVal clave As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.ID, empleados.NOMBRE_EMPLEADO FROM users INNER JOIN empleados " _
                                                  & "ON (users.ID_EMPLEADO = empleados.ID) WHERE (users.USUARIO ='" & usuario & "' AND users.PASS ='" & clave & "' AND users.ESTADO ='A')")
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
        Public Function ListarEmpleados(ByVal usuario As String, ByVal clave As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.`ID` , `empleados`.`NOMBRE_EMPLEADO` AS NOMBRE , `cargos`.`NOMBRE_CARGO` AS CARGO, " _
                                                  & "`especialidades`.`NOMBRE_ESPECIALIDAD` AS ESPECIALIDAD, empleados.id_especialidad, users.id_licencia FROM `empleados` INNER JOIN `cargos` " _
                                                  & "ON (`empleados`.`ID_CARGO` = `cargos`.`ID`) INNER JOIN `especialidades` " _
                                                  & "ON (`empleados`.`ID_ESPECIALIDAD` = `especialidades`.`ID`) INNER JOIN `users` " _
                                                  & "ON (`users`.`ID_EMPLEADO` = `empleados`.`ID`) WHERE (`users`.`USUARIO` ='" & usuario & "' " _
                                                  & "AND `users`.`PASS` ='" & clave & "')")
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


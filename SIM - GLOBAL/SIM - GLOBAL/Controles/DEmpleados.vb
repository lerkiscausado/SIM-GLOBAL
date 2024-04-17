Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEmpleados
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Empleados
            Try
                Dim query As String = String.Format("SELECT * FROM empleados WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _empleados = New Empleados
                _empleados.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _empleados.NombreEmpleado = _ds.Tables(0).Rows(0)(1).ToString()
                _empleados.IdCargo = _ds.Tables(0).Rows(0)(2).ToString()
                _empleados.IdEspecialidad = _ds.Tables(0).Rows(0)(3).ToString()
                _empleados.RegistroMedico = _ds.Tables(0).Rows(0)(4).ToString()
                _empleados.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _empleados
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function CargarIDEspecialista(ByVal filtro As String) As String
            Try
                Dim query As String = String.Format("SELECT id_especialidad FROM empleados WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub Guardar(ByVal _empleados As Empleados)
            Try
                Dim query As String
                If Existe(_empleados.Id) = True Then
                    query = "UPDATE empleados SET nombre_empleado='" & _empleados.NombreEmpleado & "', id_cargo='" & _empleados.IdCargo & "', " _
                    & "id_especialidad='" & _empleados.IdEspecialidad & "', registro_medico='" & _empleados.RegistroMedico & "', " _
                    & "estado='" & _empleados.Estado & "', firma='" & _empleados.Firma & "' where id='" & _empleados.Id & "'"
                Else
                    query = "insert into empleados values('" & _empleados.Id & "','" & _empleados.NombreEmpleado & "', " _
                        & "'" & _empleados.IdCargo & "','" & _empleados.IdEspecialidad & "', " _
                        & "'" & _empleados.RegistroMedico & "','" & _empleados.Estado & "','" & _empleados.Firma & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal codigo As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM empleados WHERE id='" & codigo & "'")
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
        Public Sub Eliminar(ByVal _empleados As Empleados)
            Try
                Dim query As String
                query = "UPDATE empleados SET estado='I' where id='" & _empleados.Id & "'"
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
                    String.Format("SELECT empleados.ID, " _
                        & "empleados.NOMBRE_EMPLEADO, " _
                        & "cargos.NOMBRE_CARGO, " _
                        & "especialidades.NOMBRE_ESPECIALIDAD, " _
                        & "IF(empleados.ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO " _
                        & "FROM empleados INNER JOIN cargos ON (empleados.ID_CARGO = cargos.ID) " _
                        & "INNER JOIN especialidades ON (empleados.ID_ESPECIALIDAD = especialidades.ID) " _
                        & "where empleados.estado='A'")
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
        Public Function ListarAgora() As DataSet
            Try
                Dim query As String =
                    String.Format("SELECT empleados.ID, " _
                        & "empleados.NOMBRE_EMPLEADO, " _
                        & "cargos.NOMBRE_CARGO, " _
                        & "IF(empleados.ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO " _
                        & "FROM empleados INNER JOIN cargos ON (empleados.ID_CARGO = cargos.ID) " _
                        & "where empleados.estado='A'")
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
        Public Function ListarEmpleado() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.ID AS ID, empleados.NOMBRE_EMPLEADO AS EMPLEADO FROM empleados " _
                                                  & "INNER JOIN cargos ON (empleados.ID_CARGO = cargos.ID) " _
                                                  & "INNER JOIN especialidades ON (empleados.ID_ESPECIALIDAD = especialidades.ID) WHERE (empleados.ESTADO ='A')")
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
        Public Function ListarComboAgora() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.ID AS ID, empleados.NOMBRE_EMPLEADO AS EMPLEADO FROM empleados " _
                                                  & "INNER JOIN cargos ON (empleados.ID_CARGO = cargos.ID) " _
                                                  & "WHERE (empleados.ESTADO ='A')")
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

        Public Function ListarEspecialista() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.ID, empleados.NOMBRE_EMPLEADO AS NOMBRE, especialidades.NOMBRE_ESPECIALIDAD AS " _
                                                  & "ESPECIALIDAD FROM empleados INNER JOIN cargos ON (empleados.ID_CARGO = cargos.ID) " _
                                                  & "INNER JOIN especialidades ON (empleados.ID_ESPECIALIDAD = especialidades.ID) WHERE " _
                                                  & "(cargos.NOMBRE_CARGO ='ESPECIALISTA' And empleados.ESTADO ='A')")
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

        Public Shared Function UltimoRegistroEmpleado() As String
            Try
                Dim query As String = String.Format("SELECT id FROM empleados ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Namespace Controles
    Public Class DEmpleados
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdEmpleado As String) As PEC___App.Modelo.Empleados
            Try
                Dim query As String = String.Format("SELECT * FROM empleados WHERE id='" & IdEmpleado & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Empleados = New PEC___App.Modelo.Empleados
                _Empleados.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Empleados.NombreEmpleado = _ds.Tables(0).Rows(0)(1).ToString()
                _Empleados.IdCargo = _ds.Tables(0).Rows(0)(2).ToString()
                _Empleados.IdEspecialidad = _ds.Tables(0).Rows(0)(3).ToString()
                _Empleados.RegistroMedico = _ds.Tables(0).Rows(0)(4).ToString()
                _Empleados.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                _Empleados.IdTipoIdentificacion = _ds.Tables(0).Rows(0)(6).ToString()
                _Empleados.Identificacion = _ds.Tables(0).Rows(0)(7).ToString()
                _Empleados.Direccion = _ds.Tables(0).Rows(0)(8).ToString()
                _Empleados.Telefono = _ds.Tables(0).Rows(0)(9).ToString()
                _Empleados.CorreoElectronico = _ds.Tables(0).Rows(0)(10).ToString()
                Return _Empleados
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Empleados As PEC___App.Modelo.Empleados)
            Try
                Dim query As String
                If Existe(_Empleados.Id) = True Then
                    query = "UPDATE empleados SET nombre_empleado='" & _Empleados.NombreEmpleado & "', id_cargo='" & _Empleados.IdCargo & "', " _
                    & "estado='" & _Empleados.Estado & "', direccion='" & _Empleados.Direccion & "', " _
                    & "telefono='" & _Empleados.Telefono & "', correo_electronico='" & _Empleados.CorreoElectronico & "' where id='" & _Empleados.Id & "'"
                Else
                    query = "insert into empleados values('" & _Empleados.Id & "','" & _Empleados.NombreEmpleado & "', " _
                        & "'" & _Empleados.IdCargo & "','" & _Empleados.IdEspecialidad & "', " _
                        & "'" & _Empleados.RegistroMedico & "','" & _Empleados.Estado & "', " _
                        & "'" & _Empleados.IdTipoIdentificacion & "', '" & _Empleados.Identificacion & "', " _
                        & "'" & _Empleados.Direccion & "','" & _Empleados.Telefono & "', " _
                        & "'" & _Empleados.CorreoElectronico & "','" & _Empleados.Firma & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdEmpleado As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM empleados WHERE id='" & IdEmpleado & "'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `empleados`.`ID`, " _
                                                & "`empleados`.`ID_TIPO_IDENTIFICACION` AS `TIPO`, " _
                                                & "`empleados`.`IDENTIFICACION`, " _
                                                & "`empleados`.`NOMBRE_EMPLEADO` AS `NOMBRE`, " _
                                                & "`cargos`.`NOMBRE_CARGO` AS `CARGO`, " _
                                                & "`empleados`.`DIRECCION`, " _
                                                & "`empleados`.`TELEFONO`, " _
                                                & "`empleados`.`CORREO_ELECTRONICO` AS `EMAIL`, " _
                                                & "IF(empleados.`ESTADO`='A','ACTIVO','INACTIVO') AS ESTADO " _
                                                & "FROM `empleados` INNER JOIN `cargos` ON (`empleados`.`ID_CARGO` = `cargos`.`ID`)")
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
        Public Function ListarAnalista() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT empleados.`ID`,empleados.`NOMBRE_EMPLEADO` FROM empleados " _
                                                  & "INNER JOIN cargos ON (empleados.`ID_CARGO`=cargos.`ID`) " _
                                                  & "WHERE empleados.`ESTADO`='A'")
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


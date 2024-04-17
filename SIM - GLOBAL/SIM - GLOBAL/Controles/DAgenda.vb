Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DAgenda
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ExisteDia(ByVal filtro As Date) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM agenda WHERE fecha='" & Format(filtro, "yyyy/MM/dd") & "'")
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
        Public Sub Dia(ByVal filtro As Date)
            Try
                Dim query As String = "INSERT INTO agenda (ID,FEChA,hora,nota,empleado,estado)" _
                    & "VALUES ('','" & Format(filtro, "yyyy/MM/dd") & "','06:00:00','','','DISPONIBLE')," _
                    & " ('','" & Format(filtro, "yyyy/MM/dd") & "','06:30:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','07:00:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','07:30:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','08:00:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','08:30:00','','','DISPONIBLE'),  ('','" & Format(filtro, "yyyy/MM/dd") & "','09:00:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','09:30:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','10:00:00','','','DISPONIBLE'),  ('','" & Format(filtro, "yyyy/MM/dd") & "','10:30:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','11:00:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','11:30:00','','','DISPONIBLE'),  ('','" & Format(filtro, "yyyy/MM/dd") & "','12:00:00','','','DISPONIBLE')," _
                    & " ('','" & Format(filtro, "yyyy/MM/dd") & "','12:30:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','13:00:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','13:30:00','','','DISPONIBLE'), " _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','14:00:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','14:30:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','15:00:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','15:30:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','16:00:00','','','DISPONIBLE'),  ('','" & Format(filtro, "yyyy/MM/dd") & "','16:30:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','17:00:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','17:30:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','18:00:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','18:30:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','19:00:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','19:30:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','20:00:00','','','DISPONIBLE'),('','" & Format(filtro, "yyyy/MM/dd") & "','20:30:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','21:00:00','','','DISPONIBLE')," _
                    & "	('','" & Format(filtro, "yyyy/MM/dd") & "','21:30:00','','','DISPONIBLE'),	('','" & Format(filtro, "yyyy/MM/dd") & "','22:00:00','','','DISPONIBLE')"
                'query = "insert into agenda values('" & _Agenda.Id & "','" &
                ' Format(_Agenda.Fecha, "yyyy/MM/dd") & "','" & _Agenda.Hora & "','" & _Agenda.Nota & "','" & _Agenda.Estado & "')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Guardar(ByVal _Agenda As Agenda)
            Try
                Dim query As String
                If Existe(_Agenda.Id) = True Then
                    query = "UPDATE agenda SET fecha_solicitada='" & Format(_Agenda.FechaSolicitada, "yyyy/MM/dd") & "', " _
                            & "nota='" & _Agenda.Nota & "' where id='" & _Agenda.Id & "'"
                Else
                    query = "insert into agenda values('" & _Agenda.Id & "', " _
                            & "'" & Format(_Agenda.Fecha, "yyyy/MM/dd") & "', " _
                            & "'" & Format(_Agenda.FechaAgenda, "yyyy/MM/dd") & "', " _
                            & "'" & Format(_Agenda.FechaSolicitada, "yyyy/MM/dd") & "', " _
                            & "'" & _Agenda.Hora & "', " _
                            & "'" & _Agenda.IdUsuario & "', " _
                            & "'" & _Agenda.IdTipoEstudio & "', " _
                            & "'" & _Agenda.IdContrato & "', " _
                            & "'" & _Agenda.Nota & "', " _
                            & "'" & _Agenda.IdEmpleado & "', " _
                            & "'" & _Agenda.IdEspecialista & "', " _
                            & "'" & _Agenda.IdOrden & "', " _
                            & "'" & _Agenda.Estado & "', " _
                            & "'" & _Agenda.CodigoCups & "', " _
                            & "'" & _Agenda.NombreCups & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarCita(ByVal _Agenda As Agenda)
            Try
                Dim query As String
                If Existe(_Agenda.Id) = True Then

                    query = "UPDATE agenda SET fecha_agenda='" & Format(_Agenda.FechaAgenda, "yyyy/MM/dd") & "', " _
                            & "fecha_solicitada='" & Format(_Agenda.FechaSolicitada, "yyyy/MM/dd") & "', " _
                            & "hora='" & Format(_Agenda.Hora, "HH:mm:ss") & "', " _
                            & "id_usuario='" & _Agenda.IdUsuario & "', " _
                            & "id_tipo_estudio='" & _Agenda.IdTipoEstudio & "', " _
                            & "codigo_cups='" & _Agenda.CodigoCups & "', " _
                            & "nombre_cups='" & _Agenda.NombreCups & "', " _
                            & "id_contrato='" & _Agenda.IdContrato & "', " _
                            & "nota='" & _Agenda.Nota & "', " _
                            & "id_empleado='" & _Agenda.IdEmpleado & "', " _
                            & "estado='APARTADA' where id='" & _Agenda.Id & "'"
                Else

                    query = "insert into agenda values('" & _Agenda.Id & "', " _
                        & "'" & Format(_Agenda.Fecha, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_Agenda.FechaAgenda, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_Agenda.FechaSolicitada, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_Agenda.Hora, "HH:mm:ss") & "', " _
                        & "'" & _Agenda.IdUsuario & "', " _
                        & "'" & _Agenda.IdTipoEstudio & "', " _
                        & "'" & _Agenda.IdContrato & "', " _
                        & "'" & _Agenda.Nota & "', " _
                        & "'" & _Agenda.IdEmpleado & "', " _
                        & "'" & _Agenda.IdEspecialista & "', " _
                        & "'" & _Agenda.IdOrden & "', " _
                        & "'" & _Agenda.Estado & "', " _
                        & "'" & _Agenda.CodigoCups & "', " _
                        & "'" & _Agenda.NombreCups & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM agenda WHERE id='" & filtro & "'")
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
        Public Function Listar(ByVal filtro As String, ByVal fecha As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `agenda`.`ID`, `agenda`.`FECHA`, DATE_FORMAT(`agenda`.`HORA`,'%h:%i %p') AS HORA, " _
                                                  & "CONCAT(usuarios.id_tipo_identificacion,usuarios.identificacion) AS IDENTIFICACION, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ', `usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS PACIENTE " _
                                                  & ",TIMESTAMPDIFF(YEAR,usuarios.`FECHA_NACIMIENTO`,CURDATE()) AS EDAD,usuarios.`SEXO` AS SEXO, usuarios.`TELEFONO` AS TELEFONO, `agenda`.`nombre_cups` AS ESTUDIO , `agenda`.`NOTA` AS ENTIDAD, `empleados`.`NOMBRE_EMPLEADO` AS ASIGNADO " _
                                                  & ", `especialistas`.`NOMBRE` AS ESPECIALISTA , `agenda`.`ESTADO` FROM `agenda` INNER JOIN `usuarios` " _
                                                  & " ON (`agenda`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & " INNER JOIN `empleados` ON (`agenda`.`ID_EMPLEADO` = `empleados`.`ID`) INNER JOIN `especialistas` " _
                                                  & "ON (`agenda`.`ID_ESPECIALISTA` = `especialistas`.`ID`)  WHERE agenda.`ID_ESPECIALISTA`='" & filtro & "' and agenda.`FECHA` = '" & fecha & "' ORDER BY `agenda`.`HORA` ")
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
        Public Function ListarAgenda() As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT `agenda`.`ID`, `agenda`.`FECHA`, DATE_FORMAT(`agenda`.`HORA`,'%h:%i %p') AS HORA, " _
                                                  & "CONCAT(usuarios.id_tipo_identificacion,usuarios.identificacion) AS IDENTIFICACION, " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ', `usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS PACIENTE " _
                                                  & ",TIMESTAMPDIFF(YEAR,usuarios.`FECHA_NACIMIENTO`,CURDATE()) AS EDAD,usuarios.`SEXO` AS SEXO, usuarios.`TELEFONO` AS TELEFONO, `agenda`.`NOMBRE_cups` AS ESTUDIO , `agenda`.`NOTA` AS ENTIDAD, `empleados`.`NOMBRE_EMPLEADO` AS ASIGNADO " _
                                                  & ", `especialistas`.`NOMBRE` AS ESPECIALISTA , `agenda`.`ESTADO` FROM `agenda` INNER JOIN `usuarios` " _
                                                  & " ON (`agenda`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                                  & " INNER JOIN `empleados` ON (`agenda`.`ID_EMPLEADO` = `empleados`.`ID`) INNER JOIN `especialistas` " _
                                                  & "ON (`agenda`.`ID_ESPECIALISTA` = `especialistas`.`ID`) ORDER BY agenda.id DESC LIMIT 0, 5000 ")
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
        Public Sub CancelarCita(ByVal IdAgenda As String)
            Try
                Dim query As String
                query = "UPDATE agenda Set estado='CANCELADA' where id='" & IdAgenda & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function Cargar(ByVal filtro As String) As Agenda
            Try
                Dim query As String = String.Format("SELECT * FROM agenda WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _agenda = New Agenda
                _agenda.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _agenda.Fecha = _ds.Tables(0).Rows(0)(1).ToString()
                _agenda.FechaAgenda = _ds.Tables(0).Rows(0)(2).ToString()
                _agenda.FechaSolicitada = _ds.Tables(0).Rows(0)(3).ToString()
                _agenda.Hora = _ds.Tables(0).Rows(0)(4).ToString()
                _agenda.IdUsuario = _ds.Tables(0).Rows(0)(5).ToString()
                _agenda.IdTipoEstudio = _ds.Tables(0).Rows(0)(6).ToString()
                _agenda.IdContrato = _ds.Tables(0).Rows(0)(7).ToString()
                _agenda.Nota = _ds.Tables(0).Rows(0)(8).ToString()
                _agenda.IdEmpleado = _ds.Tables(0).Rows(0)(9).ToString()
                _agenda.IdEspecialista = _ds.Tables(0).Rows(0)(10).ToString()
                _agenda.IdOrden = _ds.Tables(0).Rows(0)(11).ToString()
                _agenda.Estado = _ds.Tables(0).Rows(0)(12).ToString()

                Return _agenda
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarAgendaHoy() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `usuarios`.`ID` AS IDUSUARIO, " _
                                                  & "`usuarios`.`ID_TIPO_IDENTIFICACION` AS TI, " _
                                                  & "`usuarios`.`IDENTIFICACION`, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ', usuarios.SEGUNDO_NOMBRE,' ', usuarios.PRIMER_APELLIDO,' ', usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                                                  & "`usuarios`.`SEXO`, " _
                                                  & "`usuarios`.`TELEFONO`, " _
                                                  & "`usuarios`.`CORREO_ELECTRONICO` AS EMAIL, " _
                                                  & "`agenda`.`ID` AS IDAGENDA FROM `usuarios` " _
                                                  & "INNER JOIN `agenda` ON (`usuarios`.`ID` = `agenda`.`ID_USUARIO`) " _
                                                  & "WHERE (`agenda`.`FECHA` =CURDATE() And agenda.`ESTADO`='APARTADA');")
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
        Public Sub ActualizarAgenda(ByVal IdAgenda As String, ByVal IdOrden As String)
            Try
                Dim query As String
                query = "UPDATE agenda Set id_orden='" & IdOrden & "' where id='" & IdAgenda & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function EstadoCita(ByVal IdAgenda As String) As String
            Try
                Dim query As String = String.Format("SELECT estado FROM agenda WHERE id='" & IdAgenda & "'")
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
        Public Sub EliminarRegistro(ByVal IdAgenda As String)
            Try
                Dim query As String
                query = "DELETE FROM agenda WHERE id='" & IdAgenda & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub LiberarCita(ByVal IdAgenda As String)
            Try
                Dim query As String
                query = "UPDATE agenda Set id_usuario='1', estado='DISPONIBLE' where id='" & IdAgenda & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoPacienteAgenda() As DataSet
            Try
                Dim query As String =
                       String.Format("SELECT CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS `NOMBRE`, " _
                                     & "`agenda`.`FECHA`, " _
                                     & "`agenda`.`HORA`, " _
                                     & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO`, " _
                                     & "`especialistas`.`NOMBRE` FROM `usuarios` " _
                                     & "INNER JOIN `agenda` ON (`usuarios`.`ID` = `agenda`.`ID_USUARIO`) " _
                                     & "INNER JOIN `tipo_estudio` ON (`agenda`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) " _
                                     & "INNER JOIN `especialistas` ON (`agenda`.`ID_ESPECIALISTA` = `especialistas`.`ID`) " _
                                     & "ORDER BY `agenda`.`ID` DESC LIMIT 1")
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


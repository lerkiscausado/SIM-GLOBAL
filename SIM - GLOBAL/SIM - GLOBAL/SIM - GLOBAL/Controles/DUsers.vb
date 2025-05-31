Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DUsers
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
#Region "Ordenes de Atencion"
        Public Shared Function CargarOrdenesAtencion(ByVal filtro As String) As Users.OrdenesAtencion
            Try
                Dim query As String = String.Format("SELECT NUEVO, EDITAR, ANULAR, CONSULTAR,ADJUNTOS, AGENDA FROM users WHERE id_empleado='" & filtro & "' AND estado<>'E'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _OrdenesAtencion = New Users.OrdenesAtencion
                _OrdenesAtencion.Nuevo = _ds.Tables(0).Rows(0)(0).ToString()
                _OrdenesAtencion.Editar = _ds.Tables(0).Rows(0)(1).ToString()
                _OrdenesAtencion.Anular = _ds.Tables(0).Rows(0)(2).ToString()
                _OrdenesAtencion.Consultar = _ds.Tables(0).Rows(0)(3).ToString()
                _OrdenesAtencion.Adjuntos = _ds.Tables(0).Rows(0)(4).ToString()
                _OrdenesAtencion.Agenda = _ds.Tables(0).Rows(0)(5).ToString()

                Return _OrdenesAtencion
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub GuardarOrdenesAtencion(ByVal _users As Users)
            Try
                Dim query As String
                query = ""
                If ExisteEmpleado(_users.IdEmpleado) = True Then
                    query = "UPDATE users SET nuevo='" & _users.Nuevo & "', editar='" & _users.Editar & "', " _
                            & "anular='" & _users.Anular & "', consultar='" & _users.Consultar & "', " _
                            & "adjuntos='" & _users.Adjuntos & "', agenda='" & _users.Agenda & "', " _
                            & "historia_clinica='" & _users.HistoriaClinica & "', historias_anteriores='" & _users.HistoriaAnteriores & "', " _
                            & "historia_grupal='" & _users.HistoriaGrupal & "', evolucion_paciente='" & _users.EvolucionPaciente & "', " _
                            & "programacion_cirugia='" & _users.ProgramacionCirugia & "', citologia='" & _users.Citologia & "', " _
                            & "patologia='" & _users.Patologia & "', endoscopia='" & _users.Endoscopia & "', adjuntar_imagenes='" & _users.AdjuntarImagenes & "', " _
                            & "listado_ordenes='" & _users.ListadoOrdenes & "', generar_factura='" & _users.GenerarFactura & "', " _
                            & "rips='" & _users.Rips & "', inventario='" & _users.Inventario & "', " _
                            & "nomina='" & _users.Nomina & "', vista_previa='" & _users.VistaPrevia & "', " _
                            & "imprimir='" & _users.Imprimir & "', indicadores_gestion='" & _users.IndicadoresGestion & "', " _
                            & "usuarios='" & _users.Usuarios & "', entidades='" & _users.Entidades & "', sub_entidades='" & _users.SubEntidades & "', " _
                            & "contratos='" & _users.Contratos & "', tarifas='" & _users.Tarifas & "', " _
                            & "detalle_tarifas='" & _users.DetalleTarifas & "', cargos='" & _users.Cargos & "', " _
                            & "especialidades='" & _users.Especialidades & "', empleados='" & _users.Empleados & "', " _
                            & "examenes='" & _users.Examenes & "', medicamentos='" & _users.Medicamentos & "', " _
                            & "cups='" & _users.Cups & "', cie10='" & _users.Cie10 & "', " _
                            & "tipo_patologia='" & _users.TipoPatologia & "', estudios_predeterminados='" & _users.EstudiosPredeterminados & "', " _
                            & "equipos_apoyo='" & _users.EquiposApoyo & "',procedimiento_terapeutico='" & _users.ProcedimientoTerapeutico & "', encabezado_piedepagina='" & _users.EncabezadoPiedepagina & "', logo='" & _users.Logo & "', " _
                            & "firma='" & _users.Firma & "', users='" & _users.Users & "', " _
                            & "seguridad='" & _users.Seguridad & "', privilegios='" & _users.Privilegios & "', " _
                            & "ayuda_producto='" & _users.AyudaProducto & "', soporte_tecnico='" & _users.SoporteTecnico & "', " _
                            & "tutoriales='" & _users.Tutoriales & "', acercade='" & _users.Acercade & "' where id_empleado='" & _users.IdEmpleado & "'"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
#End Region

        Public Shared Function Cargar(ByVal filtro As String) As Users
            Try
                Dim query As String = String.Format("SELECT * FROM users WHERE id_empleado='" & filtro & "' AND estado<>'E'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Users = New Users
                _Users.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Users.IdEmpleado = _ds.Tables(0).Rows(0)(1).ToString()
                _Users.Usuario = _ds.Tables(0).Rows(0)(2).ToString()
                _Users.Pass = _ds.Tables(0).Rows(0)(3).ToString()
                _Users.Nuevo = _ds.Tables(0).Rows(0)(4).ToString()
                _Users.Editar = _ds.Tables(0).Rows(0)(5).ToString()
                _Users.Anular = _ds.Tables(0).Rows(0)(6).ToString()
                _Users.Consultar = _ds.Tables(0).Rows(0)(7).ToString()
                _Users.Adjuntos = _ds.Tables(0).Rows(0)(8).ToString()
                _Users.Agenda = _ds.Tables(0).Rows(0)(9).ToString()
                _Users.HistoriaClinica = _ds.Tables(0).Rows(0)(10).ToString()
                _Users.HistoriaAnteriores = _ds.Tables(0).Rows(0)(11).ToString()
                _Users.HistoriaGrupal = _ds.Tables(0).Rows(0)(12).ToString()
                _Users.EvolucionPaciente = _ds.Tables(0).Rows(0)(13).ToString()
                _Users.ProgramacionCirugia = _ds.Tables(0).Rows(0)(14).ToString()
                _Users.Citologia = _ds.Tables(0).Rows(0)(15).ToString()
                _Users.Patologia = _ds.Tables(0).Rows(0)(16).ToString()
                _Users.Endoscopia = _ds.Tables(0).Rows(0)(17).ToString()
                _Users.AdjuntarImagenes = _ds.Tables(0).Rows(0)(18).ToString()
                _Users.ListadoOrdenes = _ds.Tables(0).Rows(0)(19).ToString()
                _Users.GenerarFactura = _ds.Tables(0).Rows(0)(20).ToString()
                _Users.Rips = _ds.Tables(0).Rows(0)(21).ToString()
                _Users.Inventario = _ds.Tables(0).Rows(0)(22).ToString()
                _Users.Nomina = _ds.Tables(0).Rows(0)(23).ToString()
                _Users.VistaPrevia = _ds.Tables(0).Rows(0)(24).ToString()
                _Users.Imprimir = _ds.Tables(0).Rows(0)(25).ToString()
                _Users.IndicadoresGestion = _ds.Tables(0).Rows(0)(26).ToString()
                _Users.Usuarios = _ds.Tables(0).Rows(0)(27).ToString()
                _Users.Entidades = _ds.Tables(0).Rows(0)(28).ToString()
                _Users.SubEntidades = _ds.Tables(0).Rows(0)(29).ToString()
                _Users.Contratos = _ds.Tables(0).Rows(0)(30).ToString()
                _Users.Tarifas = _ds.Tables(0).Rows(0)(31).ToString()
                _Users.DetalleTarifas = _ds.Tables(0).Rows(0)(32).ToString()
                _Users.Cargos = _ds.Tables(0).Rows(0)(33).ToString()
                _Users.Especialidades = _ds.Tables(0).Rows(0)(34).ToString()
                _Users.Empleados = _ds.Tables(0).Rows(0)(35).ToString()
                _Users.Examenes = _ds.Tables(0).Rows(0)(36).ToString()
                _Users.Medicamentos = _ds.Tables(0).Rows(0)(37).ToString()
                _Users.Cups = _ds.Tables(0).Rows(0)(38).ToString()
                _Users.Cie10 = _ds.Tables(0).Rows(0)(39).ToString()
                _Users.TipoPatologia = _ds.Tables(0).Rows(0)(40).ToString()
                _Users.EstudiosPredeterminados = _ds.Tables(0).Rows(0)(41).ToString()
                _Users.EquiposApoyo = _ds.Tables(0).Rows(0)(42).ToString()
                _Users.ProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(43).ToString()
                _Users.EncabezadoPiedepagina = _ds.Tables(0).Rows(0)(44).ToString()
                _Users.Logo = _ds.Tables(0).Rows(0)(45).ToString()
                _Users.Firma = _ds.Tables(0).Rows(0)(46).ToString()
                _Users.Users = _ds.Tables(0).Rows(0)(47).ToString()
                _Users.Seguridad = _ds.Tables(0).Rows(0)(48).ToString()
                _Users.Privilegios = _ds.Tables(0).Rows(0)(49).ToString()
                _Users.AyudaProducto = _ds.Tables(0).Rows(0)(50).ToString()
                _Users.SoporteTecnico = _ds.Tables(0).Rows(0)(51).ToString()
                _Users.Tutoriales = _ds.Tables(0).Rows(0)(52).ToString()
                _Users.Acercade = _ds.Tables(0).Rows(0)(53).ToString()
                _Users.Estado = _ds.Tables(0).Rows(0)(54).ToString()
                _Users.IdLicencia = _ds.Tables(0).Rows(0)(55).ToString()
                _Users.Admin = _ds.Tables(0).Rows(0)(56).ToString()
                Return _Users
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _users As Users)
            Try
                Dim query As String
                If ExisteEmpleado(_users.IdEmpleado) = True Then
                    query = "UPDATE users SET usuario='" & _users.Usuario & "', pass='" & _users.Pass & "', estado='" & _users.Estado & "'  where id_empleado='" & _users.IdEmpleado & "'"

                Else
                    query = "insert into users values('" & _users.Id & "','" & _users.IdEmpleado & "','" & _users.Usuario & "','" & _users.Pass & "', " _
                            & "'0','0','0','0','0','0', " _
                            & "'0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0', " _
                            & "'0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','A','" & _users.IdLicencia & "','0')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Sub GuardarPrivilegios(ByVal _users As Users)
            Try
                Dim query As String
                query = ""
                If ExisteEmpleado(_users.IdEmpleado) = True Then
                    query = "UPDATE users SET nuevo='" & _users.Nuevo & "', editar='" & _users.Editar & "', " _
                            & "anular='" & _users.Anular & "', consultar='" & _users.Consultar & "', " _
                            & "adjuntos='" & _users.Adjuntos & "', agenda='" & _users.Agenda & "', " _
                            & "historia_clinica='" & _users.HistoriaClinica & "', historias_anteriores='" & _users.HistoriaAnteriores & "', " _
                            & "historia_grupal='" & _users.HistoriaGrupal & "', evolucion_paciente='" & _users.EvolucionPaciente & "', " _
                            & "programacion_cirugia='" & _users.ProgramacionCirugia & "', citologia='" & _users.Citologia & "', " _
                            & "patologia='" & _users.Patologia & "', endoscopia='" & _users.Endoscopia & "', adjuntar_imagenes='" & _users.AdjuntarImagenes & "', " _
                            & "listado_ordenes='" & _users.ListadoOrdenes & "', generar_factura='" & _users.GenerarFactura & "', " _
                            & "rips='" & _users.Rips & "', inventario='" & _users.Inventario & "', " _
                            & "nomina='" & _users.Nomina & "', vista_previa='" & _users.VistaPrevia & "', " _
                            & "imprimir='" & _users.Imprimir & "', indicadores_gestion='" & _users.IndicadoresGestion & "', " _
                            & "usuarios='" & _users.Usuarios & "', entidades='" & _users.Entidades & "', sub_entidades='" & _users.SubEntidades & "', " _
                            & "contratos='" & _users.Contratos & "', tarifas='" & _users.Tarifas & "', " _
                            & "detalle_tarifas='" & _users.DetalleTarifas & "', cargos='" & _users.Cargos & "', " _
                            & "especialidades='" & _users.Especialidades & "', empleados='" & _users.Empleados & "', " _
                            & "examenes='" & _users.Examenes & "', medicamentos='" & _users.Medicamentos & "', " _
                            & "cups='" & _users.Cups & "', cie10='" & _users.Cie10 & "', " _
                            & "tipo_patologia='" & _users.TipoPatologia & "', estudios_predeterminados='" & _users.EstudiosPredeterminados & "', " _
                            & "equipos_apoyo='" & _users.EquiposApoyo & "',procedimiento_terapeutico='" & _users.ProcedimientoTerapeutico & "', encabezado_piedepagina='" & _users.EncabezadoPiedepagina & "', logo='" & _users.Logo & "', " _
                            & "firma='" & _users.Firma & "', users='" & _users.Users & "', " _
                            & "seguridad='" & _users.Seguridad & "', privilegios='" & _users.Privilegios & "', " _
                            & "ayuda_producto='" & _users.AyudaProducto & "', soporte_tecnico='" & _users.SoporteTecnico & "', " _
                            & "tutoriales='" & _users.Tutoriales & "', acercade='" & _users.Acercade & "' where id_empleado='" & _users.IdEmpleado & "'"
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
                        String.Format("SELECT id FROM users WHERE id='" & codigo & "'")
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
        Public Function ExisteEmpleado(ByVal codigo As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM users WHERE id_empleado='" & codigo & "'")
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
                                    String.Format("SELECT users.ID as ID, users.ID_EMPLEADO, empleados.NOMBRE_EMPLEADO AS NOMBRE, 
                                        cargos.NOMBRE_CARGO AS CARGO, users.USUARIO, IF(users.ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO FROM users INNER JOIN 
                                        empleados ON (users.ID_EMPLEADO = empleados.ID) INNER JOIN cargos 
                                        ON (empleados.ID_CARGO = cargos.ID) WHERE (users.ESTADO <>'E')")
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

        Public Sub EliminarUsuario(ByVal IdUser As Integer)
            Try
                Dim query As String
                query = "UPDATE users SET estado='E' where id='" & IdUser & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ValidarClave(ByVal _IdEmpleado As String, ByVal _ClaveActual As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM users WHERE id_empleado='" & _IdEmpleado & "' and pass='" & _ClaveActual & "'")
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
        Public Sub CambiarClave(ByVal _IdEmpleado As String, ByVal _ClaveNueva As String)
            Try
                Dim query As String
                query = "UPDATE users SET pass='" & _ClaveNueva & "' where id_empleado='" & _IdEmpleado & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarUsuariosPrivilegios() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `users`.`ID` AS `ID`, `users`.`ID_EMPLEADO` AS `ID_EMPLEADO`, " _
                                                    & "`empleados`.`NOMBRE_EMPLEADO` AS `NOMBRE_EMPLEADO`, `cargos`.`NOMBRE_CARGO` " _
                                                    & "AS `NOMBRE_CARGO`, IF(`users`.`ESTADO`='A','ACTIVO','INACTIVO') AS `ESTADO` FROM ((`users`  JOIN `empleados` " _
                                                    & "ON ((`users`.`ID_EMPLEADO` = `empleados`.`ID`)))  JOIN `cargos`  ON " _
                                                    & "((`empleados`.`ID_CARGO` = `cargos`.`ID`)))")
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

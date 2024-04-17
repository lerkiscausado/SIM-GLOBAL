'Imports SIM_ENDOSCOPIA.Modelo
'Imports SIM_ENDOSCOPIA.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DHistoriaClinica
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As HistoriaClinica
            Try
                Dim query As String = String.Format("SELECT * FROM historia_clinica WHERE id_orden='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _HistoriaClinica = New HistoriaClinica
                _HistoriaClinica.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _HistoriaClinica.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _HistoriaClinica.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _HistoriaClinica.FechaHistoria = _ds.Tables(0).Rows(0)(3).ToString()
                _HistoriaClinica.CodigoHistoria = _ds.Tables(0).Rows(0)(4).ToString()
                _HistoriaClinica.Responsables = _ds.Tables(0).Rows(0)(5).ToString()
                _HistoriaClinica.MotivoConsulta = _ds.Tables(0).Rows(0)(6).ToString()
                _HistoriaClinica.ConsultaControl = _ds.Tables(0).Rows(0)(7).ToString()
                _HistoriaClinica.EnfermedadActual = _ds.Tables(0).Rows(0)(8).ToString()
                _HistoriaClinica.RevisionxSistemas = _ds.Tables(0).Rows(0)(9).ToString()
                _HistoriaClinica.ExamenFisico = _ds.Tables(0).Rows(0)(10).ToString()
                _HistoriaClinica.Peso = _ds.Tables(0).Rows(0)(11).ToString()
                _HistoriaClinica.Talla = _ds.Tables(0).Rows(0)(12).ToString()
                _HistoriaClinica.TensionArterial = _ds.Tables(0).Rows(0)(13).ToString()
                _HistoriaClinica.FrecuenciaCardiaca = _ds.Tables(0).Rows(0)(14).ToString()
                _HistoriaClinica.FrecuenciaRespiratoria = _ds.Tables(0).Rows(0)(15).ToString()
                _HistoriaClinica.Diagnostico = _ds.Tables(0).Rows(0)(16).ToString()
                _HistoriaClinica.PlanSeguir = _ds.Tables(0).Rows(0)(17).ToString()
                'Campos Anexos
                _HistoriaClinica.Formulacion = _ds.Tables(0).Rows(0)(18).ToString()
                _HistoriaClinica.Laboratorios = _ds.Tables(0).Rows(0)(19).ToString()
                _HistoriaClinica.OtrosEstudios = _ds.Tables(0).Rows(0)(20).ToString()
                _HistoriaClinica.TannerA = _ds.Tables(0).Rows(0)(21).ToString()
                _HistoriaClinica.TannerB = _ds.Tables(0).Rows(0)(22).ToString()
                _HistoriaClinica.TannerP = _ds.Tables(0).Rows(0)(23).ToString()
                _HistoriaClinica.TannerVT = _ds.Tables(0).Rows(0)(24).ToString()
                _HistoriaClinica.TannerLP = _ds.Tables(0).Rows(0)(25).ToString()
                _HistoriaClinica.Estado = _ds.Tables(0).Rows(0)(26).ToString()
                _HistoriaClinica.Recomendaciones = _ds.Tables(0).Rows(0)(27).ToString()
                _HistoriaClinica.Temperatura = _ds.Tables(0).Rows(0)(28).ToString()
                _HistoriaClinica.IdEspecialista = _ds.Tables(0).Rows(0)(29).ToString()
                _HistoriaClinica.Remision = _ds.Tables(0).Rows(0)(30).ToString()
                _HistoriaClinica.EstudiosDiagnosticos = _ds.Tables(0).Rows(0)(31).ToString()
                Return _HistoriaClinica
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM historia_clinica WHERE id_orden='" & filtro & "'")
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
        Public Sub Guardar(ByVal _HistoriaClinica As HistoriaClinica)
            Try
                Dim query As String
                If Existe(_HistoriaClinica.IdOrden) = True Then
                    'Actualizar Historia
                    query = "UPDATE historia_clinica SET " _
                        & "fecha_historia='" & Format(_HistoriaClinica.FechaHistoria, "yyyy/MM/dd") & "', " _
                        & "responsables='" & _HistoriaClinica.Responsables & "', " _
                        & "motivo_consulta='" & _HistoriaClinica.MotivoConsulta & "', " _
                        & "consulta_control='" & _HistoriaClinica.ConsultaControl & "', " _
                        & "enfermedad_actual='" & _HistoriaClinica.EnfermedadActual & "', " _
                        & "revisionxsistemas='" & _HistoriaClinica.RevisionxSistemas & "', " _
                        & "examen_fisico='" & _HistoriaClinica.ExamenFisico & "', " _
                        & "peso=?, " _
                        & "talla=?, " _
                        & "tension_arterial='" & _HistoriaClinica.TensionArterial & "', " _
                        & "frecuencia_cardiaca='" & _HistoriaClinica.FrecuenciaCardiaca & "', " _
                        & "frecuencia_respiratoria='" & _HistoriaClinica.FrecuenciaRespiratoria & "', " _
                        & "temperatura='" & _HistoriaClinica.Temperatura & "', " _
                        & "diagnostico='" & _HistoriaClinica.Diagnostico & "', " _
                        & "plan_seguir='" & _HistoriaClinica.PlanSeguir & "', " _
                        & "formulacion='" & _HistoriaClinica.Formulacion & "', " _
                        & "laboratorios='" & _HistoriaClinica.Laboratorios & "', " _
                        & "otros_estudios='" & _HistoriaClinica.OtrosEstudios & "', " _
                        & "tanner_a='" & _HistoriaClinica.TannerA & "', " _
                        & "tanner_b='" & _HistoriaClinica.TannerB & "', " _
                        & "tanner_p='" & _HistoriaClinica.TannerP & "', " _
                        & "tanner_vt='" & _HistoriaClinica.TannerVT & "', " _
                        & "tanner_lp='" & _HistoriaClinica.TannerLP & "', " _
                        & "estado='" & _HistoriaClinica.Estado & "', " _
                        & "recomendaciones='" & _HistoriaClinica.Recomendaciones & "', " _
                        & "id_especialista='" & _HistoriaClinica.IdEspecialista & "', " _
                        & "remision='" & _HistoriaClinica.Remision & "', " _
                        & "estudios_diagnosticos='" & _HistoriaClinica.EstudiosDiagnosticos & "' " _
                        & "where id_orden='" & _HistoriaClinica.IdOrden & "'"
                Else
                    'Guardar Historia
                    query = "INSERT INTO historia_clinica VALUES(0,'" & _HistoriaClinica.IdOrden & "','" & _HistoriaClinica.IdDetalleOrden & "','" & Format(_HistoriaClinica.FechaHistoria, "yyyy/MM/dd") & "'," _
                            & "'" & _HistoriaClinica.CodigoHistoria & "','" & _HistoriaClinica.Responsables & "', " _
                            & "'" & _HistoriaClinica.MotivoConsulta & "', " _
                            & "'" & _HistoriaClinica.ConsultaControl & "', " _
                            & "'" & _HistoriaClinica.EnfermedadActual & "', " _
                            & "'" & _HistoriaClinica.RevisionxSistemas & "', " _
                            & "'" & _HistoriaClinica.ExamenFisico & "', " _
                            & "?,?,'" & _HistoriaClinica.TensionArterial & "', " _
                            & "'" & _HistoriaClinica.FrecuenciaCardiaca & "','" & _HistoriaClinica.FrecuenciaRespiratoria & "'," _
                            & "'" & _HistoriaClinica.Diagnostico & "', " _
                            & "'" & _HistoriaClinica.PlanSeguir & "', " _
                            & "'" & _HistoriaClinica.Formulacion & "', " _
                            & "'" & _HistoriaClinica.Laboratorios & "', " _
                            & "'" & _HistoriaClinica.OtrosEstudios & "', " _
                            & "'" & _HistoriaClinica.TannerA & "','" & _HistoriaClinica.TannerB & "','" & _HistoriaClinica.TannerP & "', " _
                            & "'" & _HistoriaClinica.TannerVT & "','" & _HistoriaClinica.TannerLP & "','" & _HistoriaClinica.Estado & "', " _
                            & "'" & _HistoriaClinica.Recomendaciones & "','" & _HistoriaClinica.Temperatura & "', '" & _HistoriaClinica.IdEspecialista & "', '" & _HistoriaClinica.Remision & "','" & _HistoriaClinica.EstudiosDiagnosticos & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_HistoriaClinica.Peso))
                comando.Parameters.AddWithValue(2, CDec(_HistoriaClinica.Talla))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarHistoriasAnteriores(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ordenes`.`ID` AS ORDEN, `historia_clinica`.`FECHA_HISTORIA` AS FECHA, `historia_clinica`.`MOTIVO_CONSULTA`, " _
                                                  & "`detalle_orden`.`ID` FROM `ordenes` INNER JOIN `historia_clinica` " _
                                                  & "ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `detalle_orden` " _
                                                  & "ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) WHERE " _
                                                  & "(`ordenes`.`ESTADO` ='ATENDIDO' And `ordenes`.`ID_USUARIO` ='" & filtro & "') " _
                                                  & "ORDER BY `historia_clinica`.`FECHA_HISTORIA` DESC")
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
        Public Function HistoriasAnterioresMartinez() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT  `ordenes`.`ID` AS `ORDEN`,  `ordenes`.`FECHA_INGRESO` AS `FECHA`,  " _
                                                  & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS `IDENTIFICACION`,  " _
                                                  & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,_utf8' ',`usuarios`.`SEGUNDO_NOMBRE`,_utf8' ',`usuarios`.`PRIMER_APELLIDO`,_utf8' ',`usuarios`.`SEGUNDO_APELLIDO`) AS `PACIENTE` " _
                                                  & ",  TIMESTAMPDIFF(YEAR,`usuarios`.`FECHA_NACIMIENTO`,CURDATE()) AS `EDAD`,  `usuarios`.`TELEFONO` AS `TELEFONO`	,  " _
                                                  & "`usuarios`.`DIRECCION` AS `DIRECCION`,  `usuarios`.`CORREO_ELECTRONICO` AS `CORREO` , `detalle_orden`.`ID` FROM `ordenes`  " _
                                                  & "INNER JOIN `usuarios`  ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) INNER JOIN `detalle_orden` ON (`ordenes`.`ID` = `detalle_orden`.`ID_ORDEN`) " _
                                                  & "WHERE (`ordenes`.`ESTADO` = _utf8'ATENDIDO'  OR `ordenes`.`ESTADO` = _utf8'FACTURADO') ORDER BY `ordenes`.`ID`")
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


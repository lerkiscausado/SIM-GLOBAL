'Imports SIM_ENDOSCOPIA.Modelo
'Imports SIM_ENDOSCOPIA.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles

    ''' <summary>
    ''' Resolución 3100 de 2019 (inalterabilidad): se lanza cuando se intenta
    ''' modificar el contenido original de una historia clínica que ya fue
    ''' firmada. El único camino permitido a partir de ese momento es una
    ''' adenda (DHistoriaClinica.GuardarAdenda), nunca un UPDATE sobre el
    ''' contenido original.
    ''' </summary>
    Public Class HistoriaFirmadaException
        Inherits Exception
        Public Sub New(Optional mensaje As String = "Esta historia clínica ya fue firmada y no se puede modificar. Use una adenda para agregar información adicional.")
            MyBase.New(mensaje)
        End Sub
    End Class

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
                'Resolución 3100: estado de firma (columnas agregadas por
                'Sql/resolucion3100_inalterabilidad_historia.sql, al final de la tabla)
                If _ds.Tables(0).Columns.Count > 32 Then
                    _HistoriaClinica.Firmada = (_ds.Tables(0).Rows(0)(32).ToString() = "1")
                    If _ds.Tables(0).Rows(0)(33) IsNot DBNull.Value Then
                        _HistoriaClinica.FechaFirma = CDate(_ds.Tables(0).Rows(0)(33))
                    End If
                    _HistoriaClinica.UsuarioFirma = _ds.Tables(0).Rows(0)(34).ToString()
                End If
                Return _HistoriaClinica
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Resolución 3100: True si la historia de esta orden ya fue firmada
        ''' (y por lo tanto Guardar() rechazará cualquier intento de UPDATE).
        ''' </summary>
        Public Shared Function EstaFirmada(ByVal idOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT firmada FROM historia_clinica WHERE id_orden='" & idOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                Dim reader As OdbcDataReader
                reader = comando.ExecuteReader()
                Dim resultado As Boolean = False
                If reader.Read() Then
                    resultado = (reader(0).ToString() = "1")
                End If
                ConexionODBC.Close(_conn)
                Return resultado
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
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
            'Resolución 3100 (inalterabilidad): si la historia de esta orden ya fue
            'firmada, se rechaza el guardado aquí mismo, antes de tocar la base de
            'datos. El intento queda registrado en la bitácora aunque se bloquee.
            If Existe(_HistoriaClinica.IdOrden) = True AndAlso EstaFirmada(_HistoriaClinica.IdOrden.ToString()) Then
                RegistrarTrazabilidad(_HistoriaClinica.IdOrden, _HistoriaClinica.IdEspecialista, "INTENTO_BLOQUEADO",
                                       "Intento de modificar una historia ya firmada (rechazado por la aplicación)")
                Throw New HistoriaFirmadaException()
            End If
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
                    'Resolución 3100 / migración de columnas nuevas: se cambió de
                    'INSERT INTO historia_clinica VALUES(...) posicional (sin lista de
                    'columnas) a lista de columnas explícita. Con el INSERT posicional,
                    'agregar firmada/fecha_firma/usuario_firma al final de la tabla
                    '(Sql/resolucion3100_inalterabilidad_historia.sql) rompía este INSERT
                    '("Column count doesn't match value count"), porque MySQL exige que
                    'VALUES(...) sin columnas cubra TODAS las columnas de la tabla.
                    'Con columnas explícitas, las 3 columnas nuevas quedan en sus
                    'valores por defecto (firmada=0) sin tocar este INSERT.
                    query = "INSERT INTO historia_clinica " _
                            & "(id_orden, id_detalle_orden, fecha_historia, codigo_historia, responsables, motivo_consulta, " _
                            & "consulta_control, enfermedad_actual, revisionxsistemas, examen_fisico, peso, talla, " _
                            & "tension_arterial, frecuencia_cardiaca, frecuencia_respiratoria, diagnostico, plan_seguir, " _
                            & "formulacion, laboratorios, otros_estudios, tanner_a, tanner_b, tanner_p, tanner_vt, tanner_lp, " _
                            & "estado, recomendaciones, temperatura, id_especialista, remision, estudios_diagnosticos) " _
                            & "VALUES ('" & _HistoriaClinica.IdOrden & "','" & _HistoriaClinica.IdDetalleOrden & "','" & Format(_HistoriaClinica.FechaHistoria, "yyyy/MM/dd") & "'," _
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
                Dim esCreacion As Boolean = Not Existe(_HistoriaClinica.IdOrden)
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_HistoriaClinica.Peso))
                comando.Parameters.AddWithValue(2, CDec(_HistoriaClinica.Talla))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
                RegistrarTrazabilidad(_HistoriaClinica.IdOrden, _HistoriaClinica.IdEspecialista,
                                       If(esCreacion, "CREACION", "ACTUALIZACION"), Nothing)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        ''' <summary>
        ''' Resolución 3100 (inalterabilidad): marca la historia como firmada de
        ''' forma definitiva. A partir de aquí Guardar() rechaza cualquier UPDATE
        ''' sobre el contenido original; solo se permiten adendas. fecha_firma la
        ''' fija el servidor (NOW()), nunca el usuario, para poder demostrar
        ''' oportunidad real. Es idempotente: si ya estaba firmada, no hace nada.
        ''' </summary>
        Public Shared Sub MarcarFirmada(ByVal idOrden As Object, ByVal idUsuario As Object)
            Try
                Dim query As String =
                        "UPDATE historia_clinica SET firmada=1, fecha_firma=NOW(), usuario_firma=? " _
                        & "WHERE id_orden='" & idOrden.ToString() & "' AND firmada=0"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, idUsuario.ToString())
                Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
                If filasAfectadas > 0 Then
                    RegistrarTrazabilidad(idOrden, idUsuario, "FIRMA", "Historia firmada; queda bloqueada para edición")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        ''' <summary>
        ''' Bitácora de inalterabilidad. Se usa tanto para registrar guardados
        ''' normales y la firma, como para dejar constancia de intentos de
        ''' modificación bloqueados por ya estar firmada la historia.
        ''' </summary>
        Public Shared Sub RegistrarTrazabilidad(ByVal idOrden As Object, ByVal idUsuario As Object, ByVal accion As String, ByVal detalle As String)
            Try
                Dim query As String =
                        "INSERT INTO historia_clinica_trazabilidad (id_orden, id_usuario, accion, detalle) VALUES (?,?,?,?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, idOrden.ToString())
                comando.Parameters.AddWithValue(2, If(idUsuario Is Nothing, DBNull.Value, CObj(idUsuario.ToString())))
                comando.Parameters.AddWithValue(3, accion)
                comando.Parameters.AddWithValue(4, If(detalle Is Nothing, DBNull.Value, CObj(detalle)))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                'No bloqueamos el flujo clínico por un fallo al escribir la bitácora,
                'pero sí lo dejamos visible para no ocultar un problema de auditoría.
                MessageBox.Show("No se pudo registrar la trazabilidad: " & ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Resolución 3100: única forma de agregar información a una historia ya
        ''' firmada. Nunca modifica ni sobrescribe el contenido original.
        ''' </summary>
        Public Shared Sub GuardarAdenda(ByVal idOrden As Object, ByVal idHistoria As Object, ByVal idUsuario As Object, ByVal texto As String)
            Try
                Dim query As String =
                        "INSERT INTO historia_clinica_adendas (id_orden, id_historia, id_usuario, texto) VALUES (?,?,?,?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, idOrden.ToString())
                comando.Parameters.AddWithValue(2, idHistoria.ToString())
                comando.Parameters.AddWithValue(3, idUsuario.ToString())
                comando.Parameters.AddWithValue(4, texto)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
                RegistrarTrazabilidad(idOrden, idUsuario, "ADENDA", texto)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Shared Function ListarAdendas(ByVal idOrden As String) As DataSet
            Try
                Dim query As String =
                        String.Format("SELECT fecha_hora, id_usuario, texto FROM historia_clinica_adendas WHERE id_orden='" & idOrden & "' ORDER BY fecha_hora ASC")
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


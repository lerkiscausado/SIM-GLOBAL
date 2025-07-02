Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Namespace Controles
    Public Class DRipsJSON
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Usuarios(ByVal idFactura As String) As DataSet
            Try

                Dim query As String =
                      String.Format("SELECT detalle_factura.id_orden AS idOrden, " _
                      & "usuarios.id_tipo_identificacion AS tipoDocumentoIdentificacion, " _
                      & "usuarios.identificacion AS numDocumentoIdenfificacion, ordenes.id_tipo_usuario AS tipoUsuario, " _
                      & "usuarios.fecha_nacimiento AS fechaNacimiento, usuarios.sexo AS codSexo, " _
                      & "'170' AS codPaisResidencia, usuarios.codigo_municipio AS codMunicipioResidencia, " _
                      & "CASE WHEN usuarios.zona = 'R' THEN '01' WHEN usuarios.zona = 'U' THEN '02' ELSE NULL END AS " _
                      & "codZonaTerritorialResidencia, 'NO' AS incapacidad, ROW_NUMBER() OVER (ORDER BY usuarios.id) AS " _
                      & "consecutivo, '170' AS codPaisOrigen, detalle_factura.tipo FROM facturas f INNER JOIN detalle_factura ON f.id = " _
                      & "detalle_factura.id_factura INNER JOIN ordenes ON detalle_factura.id_orden = ordenes.id INNER " _
                      & "JOIN usuarios ON ordenes.id_usuario = usuarios.id WHERE f.id='" & idFactura & "'")
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
        Public Function Procedimientos(ByVal idOrden As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT '130010244901' AS codPrestador, " _
                                    & "o.fecha_ingreso AS fechaInicioAtencion, NULL AS idMIPRES, o.autorizacion, " _
                                    & "detalle_orden.codigo_cups AS codProcedimiento, '02' AS viaIngresoServicioSalud, " _
                                    & "'01' AS modalidadGrupoServicioTecSal, '02' AS grupoServicios, 706 AS codServicio, " _
                                    & "'15' AS finalidadTecnologiaSalud, 'CC' AS tipoDocumentoIdentificacion, '45632147' " _
                                    & "AS numDocumentoIdentificacion, detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                                    & "NULL AS codDiagnosticoRelacionado, NULL AS codComplicacion, " _
                                    & "detalle_orden.valor AS valorServicio, '05' AS conceptoRecaudo, " _
                                    & "detalle_orden.copago AS valorPagoModerador, NULL AS numFEVPagoModerador, " _
                                    & "ROW_NUMBER() OVER (ORDER BY o.id) AS consecutivo, o.id FROM ordenes o INNER JOIN " _
                                    & "detalle_orden ON o.id = detalle_orden.id_orden INNER JOIN " _
                                    & "endoscopias ON o.id = endoscopias.id_orden WHERE o.id = '" & idOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet("Usuarios")
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Function Consultas(ByVal idOrden As String) As DataSet
            Try

                Dim query As String =
                              String.Format("SELECT '130010244901' AS codPrestador, " _
                              & "o.fecha_ingreso AS fechaInicioAtencion, " _
                              & "o.autorizacion, " _
                              & "detalle_orden.codigo_cups AS codConsulta, " _
                              & "'01' AS modalidadGrupoServicioTecSal, " _
                              & "'01' AS grupoServicios, " _
                              & "301 AS codServicio, " _
                              & "'15' AS finalidadTecnologiaSalud, " _
                              & "'38' AS causaMotivoAtencion, " _
                              & "detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                              & "NULL AS codDiagnosticoRelacionado1, " _
                              & "NULL AS codDiagnosticoRelacionado2, " _
                              & "NULL AS codDiagnosticoRelacionado3, " _
                              & "'01' AS tipoDiagnosticoPrincipal, " _
                              & "'CC' AS tipoDocumentoIdentificacion, " _
                              & "'45632147' AS numDocumentoIdentificacion, " _
                              & "detalle_orden.valor AS vrServicio, " _
                              & "'05' AS conceptoRecaudo, " _
                              & "detalle_orden.copago AS valorPagoModerador, " _
                              & "NULL AS numFEVPagoModerador, " _
                              & "ROW_NUMBER() OVER (ORDER BY o.id) AS consecutivo " _
                              & "FROM ordenes o INNER JOIN detalle_orden ON o.id = detalle_orden.id_orden " _
                              & "INNER JOIN historia_clinica ON o.id = historia_clinica.id_orden INNER JOIN " _
                              & "especialistas ON historia_clinica.id_especialista = especialistas.id WHERE o.id = '" & idOrden & "'")
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
        Public Function GenerarJSONDesdeDataTables(dtConsultas As DataTable, dtProcedimientos As DataTable) As String
            Dim usuariosDict As New Dictionary(Of String, JObject)

            ' === Procesar Consultas ===
            For Each row As DataRow In dtConsultas.Rows
                Dim docId As String = row("numDocumentoIdentificacion").ToString()

                ' Si no existe el usuario, agregarlo
                If Not usuariosDict.ContainsKey(docId) Then
                    Dim usuario As New JObject From {
                        {"tipoDocumentoIdentificacion", row("tipoDocumentoIdentificacion")},
                        {"numDocumentoIdentificacion", docId},
                        {"tipoUsuario", "0" & row("tipoUsuario")},
                        {"fechaNacimiento", Format(row("fechaNacimiento"), "yyyy-MM-dd")},
                        {"codSexo", row("codSexo")},
                        {"codPaisResidencia", "170"},
                        {"codMunicipioResidencia", row("codMunicipioResidencia")},
                        {"codZonaTerritorialResidencia", row("codZonaTerritorialResidencia")},
                        {"incapacidad", row("incapacidad")},
                        {"consecutivo", row("consecutivo")},
                        {"codPaisOrigen", row("codPaisOrigen")},
                        {"servicios", New JObject()}
                    }

                    usuariosDict(docId) = usuario
                End If

                ' Agregar consulta
                Dim consulta As New JObject From {
                    {"codPrestador", row("codPrestador")},
                    {"fechaInicioAtencion", row("fechaInicioAtencion")},
                    {"numAutorizacion", row("numAutorizacion")},
                    {"codConsulta", row("codConsulta")},
                    {"modalidadGrupoServicioTecSal", row("modalidadGrupoServicioTecSal")},
                    {"grupoServicios", row("grupoServicios")},
                    {"codServicio", row("codServicio")},
                    {"finalidadTecnologiaSalud", row("finalidadTecnologiaSalud")},
                    {"causaMotivoAtencion", row("causaMotivoAtencion")},
                    {"codDiagnosticoPrincipal", row("codDiagnosticoPrincipal")},
                    {"codDiagnosticoRelacionado1", row("codDiagnosticoRelacionado1")},
                    {"codDiagnosticoRelacionado2", row("codDiagnosticoRelacionado2")},
                    {"codDiagnosticoRelacionado3", row("codDiagnosticoRelacionado3")},
                    {"tipoDiagnosticoPrincipal", row("tipoDiagnosticoPrincipal")},
                    {"tipoDocumentoIdentificacion", row("tipoDocumentoIdentificacion2")},
                    {"numDocumentoIdentificacion", row("numDocumentoIdentificacion2")},
                    {"vrServicio", row("vrServicio")},
                    {"conceptoRecaudo", row("conceptoRecaudo")},
                    {"valorPagoModerador", row("valorPagoModerador")},
                    {"numFEVPagoModerador", row("numFEVPagoModerador")},
                    {"consecutivo", row("consecutivo")}
                }

                Dim servicios = usuariosDict(docId)("servicios")

                If servicios("consultas") Is Nothing OrElse Not TypeOf servicios("consultas") Is JArray Then
                    servicios("consultas") = New JArray()
                End If

                CType(servicios("consultas"), JArray).Add(consulta)
            Next

            ' === Procesar Procedimientos ===
            For Each row As DataRow In dtProcedimientos.Rows
                Dim docId As String = row("numDocumentoIdentificacion").ToString()

                ' Si no existe el usuario, agregarlo
                If Not usuariosDict.ContainsKey(docId) Then
                    Dim usuario As New JObject From {
                        {"numDocumentoIdentificacion", docId},
                        {"tipoDocumentoIdentificacion", row("tipoDocumentoIdentificacion")},
                        {"tipoUsuario", row("tipoUsuario")},
                        {"fechaNacimiento", row("fechaNacimiento")},
                        {"codSexo", row("codSexo")},
                        {"codPaisResidencia", row("codPaisResidencia")},
                        {"codMunicipioResidencia", row("codMunicipioResidencia")},
                        {"codZonaTerritorialResidencia", row("codZonaTerritorialResidencia")},
                        {"incapacidad", row("incapacidad")},
                        {"consecutivo", row("consecutivo")},
                        {"codPaisOrigen", row("codPaisOrigen")},
                        {"servicios", New JObject()}
                    }

                    usuariosDict(docId) = usuario
                End If

                ' Agregar procedimiento
                Dim procedimiento As New JObject From {
                    {"codPrestador", row("codPrestador")},
                    {"fechaInicioAtencion", row("fechaInicioAtencion")},
                    {"idMIPRES", row("idMIPRES")},
                    {"numAutorizacion", row("numAutorizacion")},
                    {"codProcedimiento", row("codProcedimiento")},
                    {"viaIngresoServicioSalud", row("viaIngresoServicioSalud")},
                    {"modalidadGrupoServicioTecSal", row("modalidadGrupoServicioTecSal")},
                    {"grupoServicios", row("grupoServicios")},
                    {"codServicio", row("codServicio")},
                    {"finalidadTecnologiaSalud", row("finalidadTecnologiaSalud")},
                    {"tipoDocumentoIdentificacion", row("tipoDocumentoIdentificacion2")},
                    {"numDocumentoIdentificacion", row("numDocumentoIdentificacion2")},
                    {"codDiagnosticoPrincipal", row("codDiagnosticoPrincipal")},
                    {"codDiagnosticoRelacionado", row("codDiagnosticoPrincipal")},
                    {"codComplicacion", row("codComplicacion")},
                    {"vrServicio", row("vrServicio")},
                    {"conceptoRecaudo", row("conceptoRecaudo")},
                    {"valorPagoModerador", row("valorPagoModerador")},
                    {"numFEVPagoModerador", row("numFEVPagoModerador")},
                    {"consecutivo", row("consecutivo")}
                }

                Dim servicios = usuariosDict(docId)("servicios")

                If servicios("procedimientos") Is Nothing OrElse Not TypeOf servicios("procedimientos") Is JArray Then
                    servicios("procedimientos") = New JArray()
                End If

                CType(servicios("procedimientos"), JArray).Add(procedimiento)


            Next

            ' Construir el JSON final
            Dim root As New JObject()
            'root("usuarios") = New JArray(usuariosDict.Values)


            Dim jsonFinal As New JObject From {
                {"numDocumentoIdObligado", "9065569"},
                {"numFactura", "AM1560"},
                {"tipoNota", Nothing},
                {"numNota", Nothing},
                {"usuarios", New JArray(usuariosDict.Values)}
            }

            ' Devolver como string JSON
            Return root.ToString(Formatting.Indented)

        End Function
        Public Function procedimientos2(ByVal idFactura As String) As DataTable
            Try

                Dim query As String =
                      String.Format("SELECT detalle_factura.id_orden AS idOrden, " _
                        & "usuarios.id_tipo_identificacion AS tipoDocumentoIdentificacion, " _
                        & "usuarios.identificacion AS numDocumentoIdenfificacion, " _
                        & "ordenes.id_tipo_usuario AS tipoUsuario, usuarios.fecha_nacimiento AS fechaNacimiento, " _
                        & "usuarios.sexo AS codSexo, '170' AS codPaisResidencia, " _
                        & "usuarios.codigo_municipio AS codMunicipioResidencia, " _
                        & "CASE WHEN usuarios.zona = 'R' THEN '01' WHEN usuarios.zona = 'U' THEN '02' ELSE NULL END AS codZonaTerritorialResidencia, " _
                        & "'NO' AS incapacidad, ROW_NUMBER() OVER (ORDER BY usuarios.id) AS consecutivo, " _
                        & "'170' AS codPaisOrigen, detalle_factura.tipo, '130010244901' AS codPrestador, " _
                        & "ordenes.fecha_ingreso AS fechaInicioAtencion, NULL AS idMIPRES, ordenes.autorizacion AS numAutorizacion, " _
                        & "detalle_orden.codigo_cups AS codProcedimiento, '02' AS viaIngresoServicioSalud, " _
                        & "'01' AS modalidadGrupoServicioTecSal, '02' AS grupoServicios, 706 AS codServicio, " _
                        & "'15' AS finalidadTecnologiaSalud, 'CC' AS tipoDocumentoIdentificacion2, " _
                        & "'45632147' AS numDocumentoIdentificacion2, " _
                        & "detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                        & "NULL AS codDiagnosticoRelacionado, NULL AS codComplicacion, " _
                        & "detalle_orden.valor AS valorServicio, '05' AS conceptoRecaudo, " _
                        & "detalle_orden.copago AS valorPagoModerador, NULL AS numFEVPagoModerador, " _
                        & "ROW_NUMBER() OVER (ORDER BY ordenes.id) AS consecutivo2 FROM facturas f " _
                        & "INNER JOIN detalle_factura ON f.id = detalle_factura.id_factura " _
                        & "INNER JOIN ordenes ON detalle_factura.id_orden = ordenes.id " _
                        & "INNER JOIN detalle_orden ON ordenes.id = detalle_orden.id_orden " _
                        & "INNER JOIN usuarios ON ordenes.id_usuario = usuarios.id WHERE f.id='" & idFactura & "'")

                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using cmd As New OdbcCommand(query, conn)
                        ' Parámetro seguro para evitar SQL Injection
                        'cmd.Parameters.AddWithValue("@idFactura", idFactura)

                        Using adapter As New OdbcDataAdapter(cmd)
                            Dim dt As New DataTable()
                            adapter.Fill(dt)
                            Return dt
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Function consultas2(ByVal idFactura As String) As DataTable
            Try

                Dim query As String =
                      String.Format("SELECT detalle_factura.id_orden AS idOrden, " _
                        & "usuarios.id_tipo_identificacion AS tipoDocumentoIdentificacion, " _
                        & "usuarios.identificacion AS numDocumentoIdenfificacion, " _
                        & "ordenes.id_tipo_usuario AS tipoUsuario, " _
                        & "usuarios.fecha_nacimiento AS fechaNacimiento, usuarios.sexo AS codSexo, " _
                        & "'170' AS codPaisResidencia, " _
                        & "usuarios.codigo_municipio AS codMunicipioResidencia, " _
                        & "CASE WHEN usuarios.zona = 'R' THEN '01' WHEN usuarios.zona = 'U' THEN '02' ELSE NULL END AS codZonaTerritorialResidencia, " _
                        & "'NO' AS incapacidad, ROW_NUMBER() OVER (ORDER BY usuarios.id) AS consecutivo, " _
                        & "'170' AS codPaisOrigen, detalle_factura.tipo, '130010244901' AS codPrestador, " _
                        & "ordenes.fecha_ingreso AS fechaInicioAtencion, ordenes.autorizacion AS numAutorizacion, " _
                        & "detalle_orden.codigo_cups AS codConsulta, '01' AS modalidadGrupoServicioTecSal, " _
                        & "'02' AS grupoServicios, 706 AS codServicio, '15' AS finalidadTecnologiaSalud, " _
                        & "'38' AS causaMotivoAtencion, " _
                        & "detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                        & "NULL AS codDiagnosticoRelacionado1, NULL AS codDiagnosticoRelacionado2, " _
                        & "NULL AS codDiagnosticoRelacionado3, '01' AS tipoDiagnosticoPrincipal, " _
                        & "'CC' AS tipoDocumentoIdentificacion2, '45632147' AS numDocumentoIdentificacion2, " _
                        & "detalle_orden.valor AS valorServicio, '05' AS conceptoRecaudo, " _
                        & "detalle_orden.copago AS valorPagoModerador, NULL AS numFEVPagoModerador, " _
                        & "ROW_NUMBER() OVER (ORDER BY ordenes.id) AS consecutivo2 FROM facturas f " _
                        & "INNER JOIN detalle_factura ON f.id = detalle_factura.id_factura " _
                        & "INNER JOIN ordenes ON detalle_factura.id_orden = ordenes.id " _
                        & "INNER JOIN detalle_orden ON ordenes.id = detalle_orden.id_orden " _
                        & "INNER JOIN usuarios ON ordenes.id_usuario = usuarios.id WHERE f.id='" & idFactura & "'")

                Using conn As OdbcConnection = ConexionODBC.Open()
                    Using cmd As New OdbcCommand(query, conn)
                        ' Parámetro seguro para evitar SQL Injection
                        'cmd.Parameters.AddWithValue("@idFactura", idFactura)

                        Using adapter As New OdbcDataAdapter(cmd)
                            Dim dt As New DataTable()
                            adapter.Fill(dt)
                            Return dt
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class

End Namespace

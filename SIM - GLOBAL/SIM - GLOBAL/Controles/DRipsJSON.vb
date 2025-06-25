Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DRipsJSON
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
<<<<<<< Updated upstream
        Public Function Usuarios(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT detalle_factura.id_orden AS idOrden, " _
                                            & "usuarios.id_tipo_identificacion AS tipoDocumentoIdentificacion, " _
                                            & "usuarios.identificacion AS numDocumentoIdenfificacion, " _
                                            & "ordenes.id_tipo_usuario AS tipoUsuario, " _
                                            & "usuarios.fecha_nacimiento AS fechaNacimiento, usuarios.sexo AS codSexo, " _
                                            & "'170' AS codPaisResidencia, " _
                                            & "usuarios.codigo_municipio AS codMunicipioResidencia, " _
                                            & "CASE WHEN usuarios.zona = 'R' THEN '01' WHEN usuarios.zona = 'U' THEN '02' " _
                                            & "ELSE NULL END AS codZonaTerritorialResidencia, 'NO' AS incapacidad, " _
                                            & "ROW_NUMBER() OVER (ORDER BY usuarios.id) AS consecutivo, " _
                                            & "'170' AS codPaisOrigen FROM facturas f " _
                                            & "INNER JOIN detalle_factura ON f.id = detalle_factura.id_factura " _
                                            & "INNER JOIN ordenes ON detalle_factura.id_orden = ordenes.id " _
                                            & "INNER JOIN usuarios ON ordenes.id_usuario = usuarios.id WHERE f.factura='" & filtro & "'")
=======
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
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        Public Function Consultas(ByVal filtro As String) As DataSet
            Try

                Dim query As String =
                                    String.Format("SELECT '130010244901' AS codPrestador, o.fecha_ingreso AS fechaInicioAtencion, " _
                                                & "o.autorizacion, detalle_orden.codigo_cups AS codConsulta, " _
                                                & "'01' AS modalidadGrupoServicioTecSal, '01' AS grupoServicios, " _
                                                & "301 AS codServicio, '15' AS finalidadTecnologiaSalud, " _
                                                & "'38' AS causaMotivoAtencion, " _
                                                & "detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                                                & "NULL AS codDiagnosticoRelacionado1, NULL AS " _
                                                & "codDiagnosticoRelacionado2, NULL AS codDiagnosticoRelacionado3, " _
                                                & "'01' AS tipoDiagnosticoPrincipal, 'CC' AS tipoDocumentoIdentificacion, " _
                                                & "'45632147' AS numDocumentoIdentificacion, detalle_orden.valor AS vrServicio, " _
                                                & "'05' AS conceptoRecaudo, detalle_orden.copago AS valorPagoModerador, " _
                                                & "NULL AS numFEVPagoModerador, ROW_NUMBER() OVER (ORDER BY o.id) AS consecutivo " _
                                                & "FROM ordenes o INNER JOIN detalle_orden ON o.id = detalle_orden.id_orden " _
                                                & "INNER JOIN historia_clinica ON o.id = historia_clinica.id_orden " _
                                                & "INNER JOIN especialistas ON historia_clinica.id_especialista = especialistas.id " _
                                                & "WHERE o.id = '" & filtro & "'")
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
        Public Function Procedimientos(ByVal filtro As String) As DataSet
=======
        Public Function Procedimientos(ByVal idOrden As String) As DataSet
>>>>>>> Stashed changes
            Try

                Dim query As String =
                                    String.Format("SELECT '130010244901' AS codPrestador, " _
<<<<<<< Updated upstream
                                                & "o.fecha_ingreso AS fechaInicioAtencion, NULL AS idMIPRES, " _
                                                & "o.autorizacion, detalle_orden.codigo_cups AS codProcedimiento, " _
                                                & "'02' AS viaIngresoServicioSalud, '01' AS modalidadGrupoServicioTecSal, " _
                                                & "'02' AS grupoServicios, 706 AS codServicio, " _
                                                & "'15' AS finalidadTecnologiaSalud, 'CC' AS tipoDocumentoIdentificacion, " _
                                                & "'45632147' AS numDocumentoIdentificacion, " _
                                                & "detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, " _
                                                & "NULL AS codDiagnosticoRelacionado, NULL AS codComplicacion, " _
                                                & "detalle_orden.valor AS valorServicio, '05' AS conceptoRecaudo, " _
                                                & "detalle_orden.copago AS valorPagoModerador, NULL AS numFEVPagoModerador, " _
                                                & "ROW_NUMBER() OVER (ORDER BY o.id) AS consecutivo FROM ordenes o " _
                                                & "INNER JOIN detalle_orden ON o.id = detalle_orden.id_orden " _
                                                & "INNER JOIN endoscopias ON o.id = endoscopias.id_orden WHERE o.id = '" & filtro & "'")
=======
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
                _ds = New DataSet()
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
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream

End Namespace
=======
End Namespace

>>>>>>> Stashed changes

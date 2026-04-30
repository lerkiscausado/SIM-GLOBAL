Imports System.Data.Odbc
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class GeneradorJSON
    Shared _conn As New OdbcConnection
    Shared _ds As DataSet
    'Shared _adapter As DataAdapter
    Public Function GenerarJSON(idFactura As String, numDocumentoIdObligado As String, numFactura As String) As String
        Dim root As New JObject()
        root("numDocumentoIdObligado") = numDocumentoIdObligado
        root("numFactura") = numFactura
        root("tipoNota") = Nothing
        root("numNota") = Nothing

        ' Diccionario: clave = numDocumento, valor = objeto usuario JObject
        Dim usuariosDict As New Dictionary(Of String, JObject)
        ' Diccionario para acumular procedimientos por usuario
        Dim procedimientosDict As New Dictionary(Of String, JArray)
        ' Diccionario para acumular consultas por usuario
        Dim consultasDict As New Dictionary(Of String, JArray)
        ' Lista para mantener el orden de inserción de usuarios
        Dim usuariosOrden As New List(Of String)

        ' ============================================================
        ' CONSULTA 1: Obtener todas las ordenes de la factura
        ' ============================================================
        Dim sql1 As String = "
                SELECT detalle_factura.id_orden AS idOrden, 
                    usuarios.id_tipo_identificacion AS tipoDocumentoIdentificacion, 
                    usuarios.identificacion AS numDocumentoIdenfificacion, 
                    tipo_usuario.codigo AS tipoUsuario, 
                    usuarios.fecha_nacimiento AS fechaNacimiento, 
                    usuarios.sexo AS codSexo, 
                    '170' AS codPaisResidencia, 
                    usuarios.codigo_municipio AS codMunicipioResidencia, 
                    CASE WHEN usuarios.zona = 'R' THEN '01' WHEN usuarios.zona = 'U' THEN '02' ELSE NULL END AS codZonaTerritorialResidencia, 
                    'NO' AS incapacidad, 
                    ROW_NUMBER() OVER (ORDER BY usuarios.id) AS consecutivo, 
                    '170' AS codPaisOrigen, 
                    detalle_factura.tipo 
                FROM facturas f 
                INNER JOIN detalle_factura ON f.id = detalle_factura.id_factura 
                INNER JOIN ordenes ON detalle_factura.id_orden = ordenes.id 
                INNER JOIN tipo_usuario ON ordenes.id_tipo_usuario = tipo_usuario.id 
                INNER JOIN usuarios ON ordenes.id_usuario = usuarios.id 
                WHERE f.id = ?"

        Dim cmd1 As New OdbcCommand(sql1, _conn)
        cmd1.Parameters.AddWithValue("?", idFactura)
        Dim dr1 As OdbcDataReader = cmd1.ExecuteReader()

        While dr1.Read()
            Dim idOrden As String = dr1("idOrden").ToString()
            Dim tipoServicio As String = dr1("tipo").ToString().ToUpper()
            Dim numDoc As String = dr1("numDocumentoIdenfificacion").ToString()

            ' Si el usuario no existe aún en el diccionario, lo creamos
            If Not usuariosDict.ContainsKey(numDoc) Then
                Dim usuario As New JObject()
                usuario("tipoDocumentoIdentificacion") = dr1("tipoDocumentoIdentificacion").ToString()
                usuario("numDocumentoIdentificacion") = numDoc
                usuario("tipoUsuario") = dr1("tipoUsuario").ToString()
                usuario("fechaNacimiento") = FormatearFecha(dr1("fechaNacimiento"))
                usuario("codSexo") = dr1("codSexo").ToString()
                usuario("codPaisResidencia") = dr1("codPaisResidencia").ToString()
                usuario("codMunicipioResidencia") = dr1("codMunicipioResidencia").ToString()
                usuario("codZonaTerritorialResidencia") = If(dr1.IsDBNull(dr1.GetOrdinal("codZonaTerritorialResidencia")), Nothing, CType(dr1("codZonaTerritorialResidencia").ToString(), Object))
                usuario("incapacidad") = dr1("incapacidad").ToString()
                usuario("consecutivo") = CInt(dr1("consecutivo"))
                usuario("codPaisOrigen") = dr1("codPaisOrigen").ToString()

                usuariosDict.Add(numDoc, usuario)
                procedimientosDict.Add(numDoc, New JArray())
                consultasDict.Add(numDoc, New JArray())
                usuariosOrden.Add(numDoc)
            End If

            ' ============================================================
            ' CONSULTA 2: Obtener servicios de esta orden
            ' ============================================================
            Dim sql2 As String = "
                    SELECT '130010244901' AS codPrestador, 
                        o.fecha_ingreso AS fechaInicioAtencion, 
                        NULL AS idMIPRES, 
                        o.autorizacion, 
                        detalle_orden.codigo_cups AS codProcedimiento, 
                        '02' AS viaIngresoServicioSalud, 
                        '01' AS modalidadGrupoServicioTecSal, 
                        '02' AS grupoServicios, 
                        Cups.codigo_servicio AS codServicio, 
                        '15' AS finalidadTecnologiaSalud, 
                        'CC' AS tipoDocumentoIdentificacion, 
                        '45632147' AS numDocumentoIdentificacion, 
                        detalle_orden.diagnostico1 AS codDiagnosticoPrincipal, 
                        NULL AS codDiagnosticoRelacionado, 
                        NULL AS codComplicacion, 
                        detalle_orden.valor AS valorServicio, 
                        '05' AS conceptoRecaudo, 
                        detalle_orden.copago AS valorPagoModerador, 
                        NULL AS numFEVPagoModerador, 
                        ROW_NUMBER() OVER (ORDER BY o.id) AS consecutivo, 
                        o.id 
                    FROM ordenes o 
                    INNER JOIN detalle_orden ON o.id = detalle_orden.id_orden 
                    INNER JOIN cups ON detalle_orden.codigo_cups = cups.codigo_cups 
                    WHERE o.id = ?"

            Dim cmd2 As New OdbcCommand(sql2, _conn)
            cmd2.Parameters.AddWithValue("?", idOrden)
            Dim dr2 As OdbcDataReader = cmd2.ExecuteReader()

            While dr2.Read()
                If tipoServicio = "P" Then
                    Dim proc As New JObject()
                    proc("codPrestador") = dr2("codPrestador").ToString()
                    proc("fechaInicioAtencion") = FormatearFechaHora(dr2("fechaInicioAtencion"))
                    proc("idMIPRES") = Nothing
                    proc("numAutorizacion") = dr2("autorizacion").ToString()
                    proc("codProcedimiento") = dr2("codProcedimiento").ToString()
                    proc("viaIngresoServicioSalud") = dr2("viaIngresoServicioSalud").ToString()
                    proc("modalidadGrupoServicioTecSal") = dr2("modalidadGrupoServicioTecSal").ToString()
                    proc("grupoServicios") = dr2("grupoServicios").ToString()
                    proc("codServicio") = CInt(dr2("codServicio"))
                    proc("finalidadTecnologiaSalud") = dr2("finalidadTecnologiaSalud").ToString()
                    proc("tipoDocumentoIdentificacion") = dr2("tipoDocumentoIdentificacion").ToString()
                    proc("numDocumentoIdentificacion") = dr2("numDocumentoIdentificacion").ToString()
                    proc("codDiagnosticoPrincipal") = dr2("codDiagnosticoPrincipal").ToString()
                    proc("codDiagnosticoRelacionado") = Nothing
                    proc("codComplicacion") = Nothing
                    proc("vrServicio") = CDec(dr2("valorServicio"))
                    proc("conceptoRecaudo") = dr2("conceptoRecaudo").ToString()
                    proc("valorPagoModerador") = CDec(dr2("valorPagoModerador"))
                    proc("numFEVPagoModerador") = Nothing
                    proc("consecutivo") = CInt(dr2("consecutivo"))
                    procedimientosDict(numDoc).Add(proc)

                ElseIf tipoServicio = "C" Then
                    Dim cons As New JObject()
                    cons("codPrestador") = dr2("codPrestador").ToString()
                    cons("fechaInicioAtencion") = FormatearFechaHora(dr2("fechaInicioAtencion"))
                    cons("numAutorizacion") = dr2("autorizacion").ToString()
                    cons("codConsulta") = dr2("codProcedimiento").ToString()
                    cons("modalidadGrupoServicioTecSal") = dr2("modalidadGrupoServicioTecSal").ToString()
                    cons("grupoServicios") = dr2("grupoServicios").ToString()
                    cons("codServicio") = CInt(dr2("codServicio"))
                    cons("finalidadTecnologiaSalud") = dr2("finalidadTecnologiaSalud").ToString()
                    cons("causaMotivoAtencion") = "38"
                    cons("codDiagnosticoPrincipal") = dr2("codDiagnosticoPrincipal").ToString()
                    cons("codDiagnosticoRelacionado1") = Nothing
                    cons("codDiagnosticoRelacionado2") = Nothing
                    cons("codDiagnosticoRelacionado3") = Nothing
                    cons("tipoDiagnosticoPrincipal") = "01"
                    cons("tipoDocumentoIdentificacion") = dr2("tipoDocumentoIdentificacion").ToString()
                    cons("numDocumentoIdentificacion") = dr2("numDocumentoIdentificacion").ToString()
                    cons("vrServicio") = CDec(dr2("valorServicio"))
                    cons("conceptoRecaudo") = dr2("conceptoRecaudo").ToString()
                    cons("valorPagoModerador") = CDec(dr2("valorPagoModerador"))
                    cons("numFEVPagoModerador") = Nothing
                    cons("consecutivo") = CInt(dr2("consecutivo"))
                    consultasDict(numDoc).Add(cons)
                End If
            End While
            dr2.Close()

        End While
        dr1.Close()

        ' ============================================================
        ' ARMAR EL ARRAY FINAL DE USUARIOS con sus servicios
        ' ============================================================
        Dim usuariosArray As New JArray()

        For Each numDoc As String In usuariosOrden
            Dim usuario As JObject = usuariosDict(numDoc)
            Dim servicios As New JObject()

            ' Solo agregar la clave si tiene elementos
            If consultasDict(numDoc).Count > 0 Then
                servicios("consultas") = consultasDict(numDoc)
            End If
            If procedimientosDict(numDoc).Count > 0 Then
                servicios("procedimientos") = procedimientosDict(numDoc)
            End If

            usuario("servicios") = servicios
            usuariosArray.Add(usuario)
        Next

        root("usuarios") = usuariosArray

        Return JsonConvert.SerializeObject(root, Formatting.Indented)

    End Function

    ' Formatea fecha como "yyyy-MM-dd"
    Private Function FormatearFecha(valor As Object) As Object
        If IsDBNull(valor) OrElse valor Is Nothing Then Return Nothing
        Dim fecha As DateTime
        If DateTime.TryParse(valor.ToString(), fecha) Then
            Return fecha.ToString("yyyy-MM-dd")
        End If
        Return valor.ToString()
    End Function

    ' Formatea fecha+hora como "yyyy-MM-dd HH:mm"
    Private Function FormatearFechaHora(valor As Object) As Object
        If IsDBNull(valor) OrElse valor Is Nothing Then Return Nothing
        Dim fecha As DateTime
        If DateTime.TryParse(valor.ToString(), fecha) Then
            Return fecha.ToString("yyyy-MM-dd HH:mm")
        End If
        Return valor.ToString()
    End Function

End Class

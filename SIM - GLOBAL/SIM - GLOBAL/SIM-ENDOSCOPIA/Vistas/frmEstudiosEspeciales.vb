Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades


Public Class frmEstudiosEspeciales
    Public ContadorFotos As Byte

    ReadOnly _funciones As New Funciones
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DEquipos As New SIM___GLOBAL.Controles.DEquipos
    Dim _DDiagnosticos As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _dProcedimientosTerapeuticos As New SIM___GLOBAL.Controles.DProcedimientosTerapeuticos
    Dim _Endoscopia As New SIM_ENDOSCOPIA.Modelo.Endoscopia
    Dim _DEndoscopia As New SIM_ENDOSCOPIA.Controles.DEndoscopia
    'Dim _DImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes

    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria

    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia

    'Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden

    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()

    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickTipoEstudio As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdTipoEstudio As String
    Dim _ClickEstudio As String
    Dim _ClickIdTipoEstudiosAnteriores As String
    Dim _ClickCups As String
    'Dim _ClickIdTipoEstudio As String
    Dim _NombreCups As String
    Dim _IDTipoEstudio As String
    Dim _Fila As String
    Dim _Imagenes As Byte
    Public Licencia As String
    Public IdEmpleado As String
    Dim idDetalleOrden As String
    Dim idOrden As String
    Private Sub ActivaGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        Select Case Licencia

            Case 3 'DITEG SAS
                If _ClickEstudio = "CONSULTA PRIMERA VEZ" Or _ClickEstudio = "CONSULTA DE CONTROL" Then
                    ' Impresion de Historias
                    _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                    _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                    _funciones.ImprimirHistoria(idDetalleOrden, IdEmpleado)
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                ElseIf _ClickEstudio = "REGISTRO ANESTESIA" Then
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                Else
                    If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Reporte = 1
                    Else
                        Reporte = 0
                    End If
                    ' Impresion endoscopia endoscopias
                    _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                    ImpresionEndoscopia(idDetalleOrden)
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                End If
            Case 4 'GASTROLAP
                If _ClickEstudio = "CONSULTA PRIMERA VEZ" Or _ClickEstudio = "CONSULTA DE CONTROL" Then
                    ' Impresion de Historias
                    _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                    _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                    _funciones.ImprimirHistoria(idDetalleOrden, IdEmpleado)
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                ElseIf _ClickEstudio = "REGISTRO ANESTESIA" Then
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                Else


                    ' Impresion endoscopia endoscopias
                    _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                    ImpresionEndoscopia(idDetalleOrden)
                    ImprimirFrm.ImprimirEstudios(idOrden, idDetalleOrden, Reporte, Fotos, Licencia, _ClickEstudio, VistaPrevia)
                End If


        End Select
    End Sub
    Private Sub CargarImagenes(ByVal Filtro As String)
        Dim _dImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes

        _Capturas.Items.Clear()
        gcSeleccionadas.Gallery.Groups.Clear()
        _ds = New DataSet
        _ds = _dImagenes.ListarImagenesActivasIC(Filtro)
        If _ds.Tables(0).Rows.Count <> 0 Then
            _Imagenes = 1
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, ""))
            Next
            gcSeleccionadas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcSeleccionadas.Gallery.ImageSize = New Size(120, 90)
            gcSeleccionadas.Gallery.Groups.Add(_Capturas)
        Else
            _Imagenes = 0
        End If
    End Sub
    Private Sub CargarEndoscopia()

        _Endoscopia = _DEndoscopia.Cargar(lblIdDetalleOrden.Text)
        txtConsecutivo.Text = _Endoscopia.Id
        dtFecha.Text = _Endoscopia.FechaEstudio
        txtMedicoSolicita.Text = _Endoscopia.MedicoSolicita

        'Campos de reporte de Endoscopia
        txtInforme.Text = _Endoscopia.Campo1

    End Sub
    Private Sub Nuevo()

        'Verificamos Tipo Estudio
        lblReporteEstudio.Text = "Informe de " & " - " & _ClickCups

        'traemos Nombre CUPS
        _NombreCups = _ClickCups
        _IDTipoEstudio = _ClickIdTipoEstudio
        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")

        '----------------------- Bloqueamos el estudio del paciente -------------------
        '_DDetalleOrden.ProcesoDetalleOrden(lblIdDetalleOrden.Text)

        '******* Traemos la Orden ******************
        _Ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        If _DEndoscopia.Existe(lblIdDetalleOrden.Text) = True Then
            CargarEndoscopia()
        End If

        '****** Traer Estudios Anteriores **********
        _ds = New DataSet()
        _ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        'CargarImagenes(lblIdDetalleOrden.Text)

        bbiGuardar.Enabled = False
    End Sub
    Private Sub LimpiarCampos()
        'Limpiamos campos
        lblConsecutivo.Text = ""
        txtConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        txtDatosUsuario.Text = ""
        txtMedicoSolicita.Text = ""
        chkProcesado.Checked = False

        'CAmpos Resporte de Endoscopia
        txtInforme.Text = ""
        _NombreCups = ""

        '****** Traer Estudios Anteriores **********
        _ds = New DataSet()
        _ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        _Imagenes = 0

    End Sub
    Private Sub GuardarEndoscopia()
        '_Endoscopia.Id =

        _Endoscopia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Endoscopia.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _Endoscopia.FechaEstudio = dtFecha.Text
        _Endoscopia.FechaSalida = dtFecha.Text
        _Endoscopia.Hora = DateTime.Now
        _Endoscopia.MedicoSolicita = txtMedicoSolicita.Text
        _Endoscopia.IdEquipo = 1
        _Endoscopia.IdProcedimientoTerapeutico = 1
        'Campos del reporte de estudios especiales
        _Endoscopia.Campo1 = txtInforme.Text
        _Endoscopia.Campo6 = _NombreCups
        _Endoscopia.CodigoDiagnostico = cboDiagnosticos.EditValue
        _Endoscopia.IdEmpleado = IdEmpleado
        _DEndoscopia.Guardar(_Endoscopia)
        'ActualizarGrilla()
        bbiGuardar.Enabled = False

    End Sub
    Private Sub ImprimirEstudio()
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
        Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
        _DetalleOrden = _dDetalleOrden.Cargar(lblIdDetalleOrden.Text)
        'If _DetalleOrden.Estado = "ATENDIDO" Then

        Select Case _DetalleOrden.IdTipoEstudio
            Case 8
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleado)
                'ImpresionHistoria(lblIdDetalleOrden.Text, "H")
                ImprimirFrm.ImprimirReporte("historia_clinica.rpt", lblIdDetalleOrden.Text)
            Case 9
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleado)
                'ImpresionHistoria(lblIdDetalleOrden.Text, "C")
                ImprimirFrm.ImprimirReporte("historia_clinica.rpt", lblIdDetalleOrden.Text)
            Case 10
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("endoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 1 And ContadorFotos <= 3 Then
                    ImprimirFrm.ImprimirReporte("imgendoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 4 And ContadorFotos <= 6 Then
                    ImprimirFrm.ImprimirReporte("imgendoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgendoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 11
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("colonoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 1 And ContadorFotos <= 3 Then
                    ImprimirFrm.ImprimirReporte("imgcolonoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 4 And ContadorFotos <= 6 Then
                    ImprimirFrm.ImprimirReporte("imgcolonoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgcolonoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 12
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("rectoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 1 And ContadorFotos <= 3 Then
                    ImprimirFrm.ImprimirReporte("imgrectoscopia.rpt", lblIdDetalleOrden.Text)
                ElseIf ContadorFotos >= 4 And ContadorFotos <= 6 Then
                    ImprimirFrm.ImprimirReporte("imgrectoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgrectoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 13
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                ImpresionHistoria(lblIdDetalleOrden.Text, "C")
                ImprimirFrm.CargarReporte("historia_preanestesica.rpt", lblIdDetalleOrden.Text)
            Case 15
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If _Imagenes = 1 Then
                    ImprimirFrm.ImprimirReporte("imgestudios_especiales.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("estudios_especiales.rpt", lblIdDetalleOrden.Text)
                End If
            Case Else
                'MsgBox(Registro)

        End Select
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesEstudiosEspeciales(IdEmpleado)
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub

    Private Sub ImpresionHistoria(ByVal Filtro As String, ByVal Control As String)

        Dim _ds = New DataSet
        _ds = _dImpresionHistoria.Listar(Filtro, Control)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionHistoria.Id = Val("")
        _ImpresionHistoria.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionHistoria.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionHistoria.NumeroHistoria = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionHistoria.Nombre = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionHistoria.Identificacion = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionHistoria.Edad = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionHistoria.Sexo = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionHistoria.EstadoCivil = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionHistoria.Telefono = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionHistoria.Direccion = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionHistoria.Entidad = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionHistoria.FechaIngreso = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionHistoria.FechaAtencion = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionHistoria.MotivoConsulta = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionHistoria.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionHistoria.AntecedentesPersonales = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionHistoria.EnfermedadActual = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionHistoria.PlanSeguir = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionHistoria.Diagnostico = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionHistoria.Recomendaciones = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionHistoria.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(20))

        _ImpresionHistoria.Medico = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionHistoria.Especialidad = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionHistoria.RegistroMedico = _ds.Tables(0).Rows(0)(23).ToString
        _ImpresionHistoria.IdEmpleado = IdEmpleado
        _dImpresionHistoria.Guardar(_ImpresionHistoria)
    End Sub
    Private Sub ImpresionEndoscopia(ByVal Filtro As String)
        Dim _dimagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        Dim _ds = New DataSet

        _ds = _dImpresionEndoscopia.Listar(Filtro)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionEndoscopia.Id = Val("")
        _ImpresionEndoscopia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionEndoscopia.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionEndoscopia.Estudio = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionEndoscopia.FechaIngreso = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionEndoscopia.Nombre = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionEndoscopia.Identificacion = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionEndoscopia.Edad = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionEndoscopia.Sexo = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionEndoscopia.EstadoCivil = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionEndoscopia.Telefono = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionEndoscopia.Direccion = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionEndoscopia.Entidad = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionEndoscopia.MedicoSolicita = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionEndoscopia.Indicacion = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionEndoscopia.Medicamentos = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionEndoscopia.Equipo = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionEndoscopia.Anestesiologo = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionEndoscopia.ProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionEndoscopia.Campo1 = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionEndoscopia.Campo2 = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionEndoscopia.Campo3 = _ds.Tables(0).Rows(0)(20).ToString
        _ImpresionEndoscopia.Campo4 = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionEndoscopia.Campo5 = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionEndoscopia.Campo6 = _ds.Tables(0).Rows(0)(23).ToString

        _ImpresionEndoscopia.Diagnostico = _ds.Tables(0).Rows(0)(24).ToString
        _ImpresionEndoscopia.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(25))
        _ImpresionEndoscopia.Medico = _ds.Tables(0).Rows(0)(26).ToString
        _ImpresionEndoscopia.Especialidad = _ds.Tables(0).Rows(0)(27).ToString
        _ImpresionEndoscopia.RegistroMedico = _ds.Tables(0).Rows(0)(28).ToString
        _ImpresionEndoscopia.IdEmpleado = IdEmpleadoG '_ds.Tables(0).Rows(0)(26).ToString

        _dImpresionEndoscopia.Guardar(_ImpresionEndoscopia)


    End Sub
    Private Sub ImpresionEndoscopia2(ByVal Filtro As String)
        Dim _dimagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        Dim _ds = New DataSet

        _ds = _dImpresionEndoscopia.Listar(Filtro)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionEndoscopia.Id = Val("")
        _ImpresionEndoscopia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionEndoscopia.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionEndoscopia.Estudio = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionEndoscopia.FechaIngreso = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionEndoscopia.Nombre = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionEndoscopia.Identificacion = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionEndoscopia.Edad = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionEndoscopia.Sexo = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionEndoscopia.EstadoCivil = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionEndoscopia.Telefono = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionEndoscopia.Direccion = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionEndoscopia.Entidad = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionEndoscopia.MedicoSolicita = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionEndoscopia.Indicacion = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionEndoscopia.Medicamentos = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionEndoscopia.Equipo = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionEndoscopia.Anestesiologo = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionEndoscopia.ProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionEndoscopia.Campo1 = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionEndoscopia.Campo2 = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionEndoscopia.Campo3 = _ds.Tables(0).Rows(0)(20).ToString
        _ImpresionEndoscopia.Campo4 = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionEndoscopia.Campo5 = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionEndoscopia.Campo6 = _ds.Tables(0).Rows(0)(23).ToString
        _ImpresionEndoscopia.Diagnostico = _ds.Tables(0).Rows(0)(24).ToString

        _ImpresionEndoscopia.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(25))
        _ImpresionEndoscopia.Medico = _ds.Tables(0).Rows(0)(26).ToString
        _ImpresionEndoscopia.Especialidad = _ds.Tables(0).Rows(0)(27).ToString
        _ImpresionEndoscopia.RegistroMedico = _ds.Tables(0).Rows(0)(28).ToString
        _ImpresionEndoscopia.IdEmpleado = IdEmpleado '_ds.Tables(0).Rows(0)(26).ToString

        '************* VERIFICAMOS SI EXISTEN IMAGENES **********
        If _dimagenes.ExisteImagenes(Filtro) = True Then
            'MsgBox("tiene imagenesssssss")
            _ds = _dimagenes.ListarImagenesActivas(Filtro)
            Select Case _ds.Tables(0).Rows.Count
                Case 0
                    ' _ImpresionEndoscopia.Imagen1 = ""
                    ' _ImpresionEndoscopia.Imagen2 = ""
                    ' _ImpresionEndoscopia.Imagen3 = ""
                    ' _ImpresionEndoscopia.Imagen4 = ""
                    ' _ImpresionEndoscopia.Imagen5 = ""
                    ' _ImpresionEndoscopia.Imagen6 = ""
                    ' _ImpresionEndoscopia.Imagen7 = ""
                   ' _ImpresionEndoscopia.Imagen8 = ""
                Case 1
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString) '_funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(0))
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                Case 2
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                Case 3
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")


                Case 4
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")

                Case 5
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                Case 6
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")

                Case 7
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")

                Case 8
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                Case Else
            End Select
            _dImpresionEndoscopia.GuardarImagenes(_ImpresionEndoscopia, _ds.Tables(0).Rows.Count)
            _dimagenes.EliminarTemporales(Filtro, _ds.Tables(0).Rows.Count)
        Else
            'MsgBox("NO tiene imagenes")
            '_ImpresionEndoscopia.Imagen1 = ""
            '_ImpresionEndoscopia.Imagen2 = ""
            '_ImpresionEndoscopia.Imagen3 = ""
            '_ImpresionEndoscopia.Imagen4 = ""
            '_ImpresionEndoscopia.Imagen5 = ""
            '_ImpresionEndoscopia.Imagen6 = ""
            '_ImpresionEndoscopia.Imagen7 = ""
            '_ImpresionEndoscopia.Imagen8 = ""

            _dImpresionEndoscopia.Guardar(_ImpresionEndoscopia)
        End If

    End Sub
    Private Sub frmEndoscopia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        'Llenamos Fecha Actual
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'Listamos los Diagnosticos
        _ds = _DDiagnosticos.ListarCombo
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickIdTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "TIPOESTUDIO").ToString()
            _ClickCups = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Estudio", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Estudio pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nuevo Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                Nuevo()
                'CargarImagenes(_ClickIdDetalleOrden)
            End If
        Else
            LimpiarCampos()
            Nuevo()
            'CargarImagenes(_ClickIdDetalleOrden)
        End If
    End Sub

    Private Sub txtMedicoSolicita_EditValueChanged(sender As Object, e As EventArgs) Handles txtMedicoSolicita.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtAnestesiologo_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtIndicacion_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub cboEquipo_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtMedicamentos_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtCampo2_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtCampo3_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If chkProcesado.Checked = True Then
            If txtMedicoSolicita.Text = "" Then
                MessageBox.Show("El campo Medico que solicita es obligatorio", "Estudios Especiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboDiagnosticos.Text = "" Then
                MessageBox.Show("El campo diagnostico es obligatorio", "Estudios Especiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    GuardarEndoscopia()
                    If txtConsecutivo.Text = "" Then
                        _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                        'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
                        txtConsecutivo.Text = _Endoscopia.Id
                    End If

                    'Actualizar estado de detalle orden
                    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
                    _DDetalleOrden.ActualizarEstado(lblIdDetalleOrden.Text)
                    If _DDetalleOrden.DetalleOrdenPendiente(lblConsecutivoOrden.Text) = False Then
                        _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    End If

                    If MessageBox.Show("Desea imprimir el Estudio # " & txtConsecutivo.Text, "Imprimir Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ImprimirEstudio()
                    End If
                    ActualizarGrilla()
                    LimpiarCampos()
                    _Capturas.Items.Clear()
                    gcSeleccionadas.Gallery.Groups.Clear()
                    'End If
                Else
                    GuardarEndoscopia()
                    ActualizarGrilla()
                    If txtConsecutivo.Text = "" Then
                        _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                        txtConsecutivo.Text = _Endoscopia.Id
                        'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
                    End If
                End If
            End If
        Else
            GuardarEndoscopia()
            ActualizarGrilla()
            If txtConsecutivo.Text = "" Then
                _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                txtConsecutivo.Text = _Endoscopia.Id
                'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
            End If
        End If
    End Sub

    Private Sub cboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    ' Private Sub gvEstudiosAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
    ' If e.RowHandle >= 0 Then
    '        _ClickIdTipoEstudiosAnteriores = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
    '        _Fila = e.RowHandle.ToString
    '        MsgBox(_ClickIdTipoEstudiosAnteriores)
    ' End If
    ' End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs) Handles btVistaEstudios.Click
        If _ClickIdTipoEstudiosAnteriores <> "" Then
            'Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            'Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            'Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            '_DetalleOrden = _dDetalleOrden.Cargar(_ClickIdTipoEstudiosAnteriores)
            '
            '            Select Case _DetalleOrden.IdTipoEstudio
            '            Case 8
            '            ImpresionHistoria(_ClickIdTipoEstudiosAnteriores, "H")
            '            ImprimirFrm.CargarReporte("historia_clinica.rpt", _ClickIdTipoEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
            '            Case 9
            '            ImpresionHistoria(_ClickIdTipoEstudiosAnteriores, "C")
            '            ImprimirFrm.CargarReporte("historia_control.rpt", _ClickIdTipoEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
            '            Case 10
            '            _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            '            ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '            ImprimirFrm.CargarReporte("endoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '            Case 11
            '            _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            '            ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '            ImprimirFrm.CargarReporte("colonoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '            Case 12
            '            _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            '            ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '            ImprimirFrm.CargarReporte("rectoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '            Case 13
            '            _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
            '            ImpresionHistoria(_ClickIdTipoEstudiosAnteriores, "C")
            '            ImprimirFrm.CargarReporte("historia_preanestesica.rpt", _ClickIdTipoEstudiosAnteriores)
            '            Case 15
            '            _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            '            ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '            ImprimirFrm.CargarReporte("estudios_especiales.rpt", _ClickIdTipoEstudiosAnteriores)
            ''            Case Else
            '           'MsgBox(Registro)
            '           End Select


            ImpresionResultados("0", True)

            If Licencia = 16 Then
                ImpresionResultados("0", False)
            End If



        Else
            MessageBox.Show("Debe Seleccionar un Estudio o Historia", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCargarImagenes_Click(sender As Object, e As EventArgs) Handles btnCargarImagenes.Click
        Dim _frmOpen As New SIM_ENDOSCOPIA.frmImagenesCapturadas
        _frmOpen._idDetalleOrden = lblIdDetalleOrden.Text
        _frmOpen.ShowDialog()
        CargarImagenes(lblIdDetalleOrden.Text)
    End Sub

    Private Sub GCEstudiosAnteriores_Click(sender As Object, e As EventArgs) Handles GCEstudiosAnteriores.Click

    End Sub

    Private Sub gvEstudiosAnteriores_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvEstudiosAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdTipoEstudiosAnteriores = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            idDetalleOrden = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            idOrden = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickEstudio = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
            ' MsgBox(_ClickIdTipoEstudiosAnteriores)
        End If
    End Sub

    Private Sub txtELCB_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtCampo2_EditValueChanged_1(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtCampo3_EditValueChanged_1(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtCampo4_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged_1(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtDatosUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles txtDatosUsuario.EditValueChanged
        If txtDatosUsuario.Text = "" Then
            lblReporteEstudio.Visible = False
            lblCodigoDiagnostico.Visible = False
            cboDiagnosticos.Visible = False
        Else
            lblReporteEstudio.Visible = True
            lblCodigoDiagnostico.Visible = True
            cboDiagnosticos.Visible = True
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiAplicarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAplicarPlantilla.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha seleccionado el Estudios para aplicar plantilla", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _Dplantillas As New SIM___GLOBAL.Controles.DPlantillasInformes
            _ds = _Dplantillas.AplicarPlantilla(IdEmpleado, _IDTipoEstudio)
            txtInforme.Text = _ds.Tables(0).Rows(0)(2).ToString

        End If
    End Sub

    Private Sub txtInforme_EditValueChanged(sender As Object, e As EventArgs) Handles txtInforme.EditValueChanged
        ActivaGuardar()
    End Sub
End Class
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades


Public Class frmEndoscopiaGL
    ReadOnly _funciones As New Funciones
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DEquipos As New SIM___GLOBAL.Controles.DEquipos
    Dim _DDiagnosticos As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _dProcedimientosTerapeuticos As New SIM___GLOBAL.Controles.DProcedimientosTerapeuticos
    Dim _Endoscopia As New SIM_ENDOSCOPIA.Modelo.Endoscopia
    Dim _DEndoscopia As New SIM_ENDOSCOPIA.Controles.DEndoscopia
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _DImagenes As New SIM___GLOBAL.Controles.DImagenes
    Dim _ImagenesTemporales As New SIM___GLOBAL.Modelo.ImagenesTemporales
    Dim _DImagenesTemporales As New SIM___GLOBAL.Controles.DImagenesTemporales

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
    Dim _ClickIdTipoEstudiosAnteriores As String
    Dim _ClickCups As String
    Dim _IdUsuario As String
    'Dim _ClickIdTipoEstudio As String
    Dim _NombreCups As String
    Dim _IDTipoEstudio As String
    Dim _Fila As String
    Dim _Imagenes As Byte
    Public ContadorFotos As Byte
    Public Licencia As String
    Public IdEmpleado As String
    Private Sub ActivaGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ImprimirEstudio()
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
        Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
        _DetalleOrden = _DDetalleOrden.Cargar(lblIdDetalleOrden.Text)
        'If _DetalleOrden.Estado = "ATENDIDO" Then

        Select Case _DetalleOrden.IdTipoEstudio
            Case 8
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleadoG)
                'ImpresionHistoria(lblIdDetalleOrden.Text, "H")
                ImprimirFrm.ImprimirReporte("historia_clinica.rpt", lblIdDetalleOrden.Text)
            Case 9
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleadoG)
                'ImpresionHistoria(lblIdDetalleOrden.Text, "H")
                ImprimirFrm.ImprimirReporte("historia_clinica.rpt", lblIdDetalleOrden.Text)
            Case 10
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If _Imagenes = 1 Then
                    ImprimirFrm.ImprimirReporte("imgendoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("endoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 11
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If _Imagenes = 1 Then
                    ImprimirFrm.ImprimirReporte("imgcolonoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("colonoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 12
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If _Imagenes = 1 Then
                    ImprimirFrm.ImprimirReporte("imgrectoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("rectoscopia.rpt", lblIdDetalleOrden.Text)
                End If
            Case 13
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                ImpresionHistoria(IDDetalleOrdenG, "C")
                ImprimirFrm.CargarReporte("historia_preanestesica.rpt", IDDetalleOrdenG)
            Case 15
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
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
    'Private Sub CargarImagenes(ByVal Filtro As String)
    ' Dim _dImagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
    '
    '       _Capturas.Items.Clear()
    '      gcSeleccionadas.Gallery.Groups.Clear()
    '      _ds = New DataSet
    '      _ds = _dImagenes.ListarImagenesActivasIC(Filtro)
    '  If _ds.Tables(0).Rows.Count <> 0 Then
    '          _Imagenes = 1
    ' For x = 1 To _ds.Tables(0).Rows.Count
    '            'LLENAMOS GALERY CONTROL
    '           _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, ""))
    'Next
    '        gcSeleccionadas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
    '        gcSeleccionadas.Gallery.ImageSize = New Size(120, 90)
    '        gcSeleccionadas.Gallery.Groups.Add(_Capturas)
    ' Else
    '        _Imagenes = 0
    'End If
    'End Sub
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
                _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
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
        txtIndicacion.Text = _Endoscopia.Indicacion
        txtMedicamentos.Text = _Endoscopia.Medicamentos
        txtAnestesiologo.Text = _Endoscopia.Anestesiologo


        'Campos de reporte de Endoscopia
        txtELCB.Text = _Endoscopia.Campo5
        txtDescripcion.Text = _Endoscopia.Campo1
        txtCampo2.Text = _Endoscopia.Campo2
        txtCampo3.Text = _Endoscopia.Campo3
        txtCampo4.Text = _Endoscopia.Campo4
        txtDiagnostico.Text = _Endoscopia.Diagnostico
        cboTomaBiopsia.Text = _Endoscopia.TomaBiopsia
        txtDescripcionBiopsia.Text = _Endoscopia.Biopsia

        cboEquipo.ItemIndex = cboEquipo.Properties.GetDataSourceRowIndex("ID", _Endoscopia.IdEquipo)
        cboProcedimientosTerapeuticos.ItemIndex = cboProcedimientosTerapeuticos.Properties.GetDataSourceRowIndex("ID", _Endoscopia.IdProcedimientoTerapeutico)

        cboDiagnosticos.EditValue = _Endoscopia.CodigoDiagnostico
    End Sub
    Private Sub Nuevo()

        'Verificamos Tipo Estudio
        Select Case _ClickTipoEstudio
            Case "COLONOSCOPIA"
                lblReporteEstudio.Text = "Informe de Colonoscopia" & " - " & _ClickCups

                xtpELCB.PageVisible = True
                xtpCampo2.Text = "Inspeccion"
                xtpCampo3.Text = "Tacto"
                xtpCampo4.Text = "Colonoscopia"

            Case "RECTOSCOPIA"
                lblReporteEstudio.Text = "Informe de Rectoscopia" & " - " & _ClickCups

                xtpELCB.PageVisible = False
                xtpCampo2.Text = "Inspeccion"
                xtpCampo3.Text = "Tacto"
                xtpCampo4.Text = "Rectoscopia"
            Case "ENDOSCOPIA"
                lblReporteEstudio.Text = "Informe de Endoscopia" & " - " & _ClickCups

                xtpELCB.PageVisible = False
                xtpCampo2.Text = "Esofago"
                xtpCampo3.Text = "Estomago"
                xtpCampo4.Text = "Duodeno"
        End Select

        'traemos Nombre CUPS
        _NombreCups = _ClickCups
        _IDTipoEstudio = _ClickIdTipoEstudio

        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        ' txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")
        '------------Traemoda datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

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

        CargarImagenes(lblIdDetalleOrden.Text)

        bbiGuardar.Enabled = False
    End Sub
    Private Sub LimpiarCampos()
        'Limpiamos campos
        lblConsecutivo.Text = ""
        txtConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        GCDatosUsuarios.DataSource = Nothing
        'txtDatosUsuario.Text = ""
        txtMedicoSolicita.Text = ""
        txtAnestesiologo.Text = ""
        txtMedicamentos.Text = ""
        txtIndicacion.Text = ""
        'chkProcedimientoTerapeutico.Checked = False
        chkProcesado.Checked = False

        'CAmpos Resporte de Endoscopia
        txtELCB.Text = ""
        txtDescripcion.Text = ""
        txtCampo2.Text = ""
        txtCampo3.Text = ""
        txtCampo4.Text = ""
        txtDiagnostico.Text = ""
        cboTomaBiopsia.Text = "NO"
        txtDescripcionBiopsia.Text = ""
        _NombreCups = ""
        '****** Traer Estudios Anteriores **********
        _ds = New DataSet()
        _ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        _Imagenes = 0

    End Sub
    Private Function GuardarEndoscopia() As Boolean
        '_Endoscopia.Id =

        _Endoscopia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Endoscopia.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _Endoscopia.FechaEstudio = dtFecha.Text
        _Endoscopia.FechaSalida = dtFecha.Text
        _Endoscopia.Hora = DateTime.Now
        _Endoscopia.MedicoSolicita = txtMedicoSolicita.Text
        _Endoscopia.Indicacion = txtIndicacion.Text
        _Endoscopia.Medicamentos = txtMedicamentos.Text
        _Endoscopia.IdEquipo = cboEquipo.GetColumnValue("ID")
        _Endoscopia.IdProcedimientoTerapeutico = cboProcedimientosTerapeuticos.GetColumnValue("ID")
        _Endoscopia.Anestesiologo = txtAnestesiologo.Text

        'Campos del reporte de endoscopia
        _Endoscopia.Campo1 = txtDescripcion.Text
        _Endoscopia.Campo2 = txtCampo2.Text
        _Endoscopia.Campo3 = txtCampo3.Text
        _Endoscopia.Campo4 = txtCampo4.Text
        _Endoscopia.Diagnostico = txtDiagnostico.Text
        _Endoscopia.Campo5 = txtELCB.Text
        _Endoscopia.Campo6 = _NombreCups
        _Endoscopia.TomaBiopsia = cboTomaBiopsia.Text
        _Endoscopia.Biopsia = txtDescripcionBiopsia.Text
        _Endoscopia.CodigoDiagnostico = cboDiagnosticos.EditValue

        _Endoscopia.IdEmpleado = IdEmpleado
        If _DEndoscopia.Guardar(_Endoscopia) = True Then
            'ActualizarGrilla()
            bbiGuardar.Enabled = False
            Return True
        Else
            Return False
        End If



    End Function
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesEstudioEndoscopia(IdEmpleado)
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
        _ImpresionHistoria.IdEmpleado = IdEmpleadoG
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

        '************* VERIFICAMOS SI EXISTEN IMAGENES **********
        ContadorFotos = 0
        If _dimagenes.ExisteImagenes(Filtro) = True Then

            'MsgBox("tiene imagenesssssss")
            _ds = _dimagenes.ListarImagenesActivas(Filtro)
            ContadorFotos = 1
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
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = ""
                    _ImpresionEndoscopia.Texto3 = ""
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("1")
                    'ContadorFotos = 1
                Case 2
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = ""
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("2")
                    'ContadorFotos = 2
                Case 3
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("3")
                    'ContadorFotos = 3
                Case 4
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("4")
                    'ContadorFotos = 4
                Case 5
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("5")
                    'ContadorFotos = 5
                Case 6
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("6")
                    'ContadorFotos = 6
                Case 7
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("7")
                    'ContadorFotos = 7
                Case 8
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile(_ds.Tables(0).Rows(7)(0).ToString)
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = _ds.Tables(0).Rows(7)(1).ToString
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("8")
                    'ContadorFotos = 8
                Case Else
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile(_ds.Tables(0).Rows(7)(0).ToString)
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile(_ds.Tables(0).Rows(8)(0).ToString)
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = _ds.Tables(0).Rows(7)(1).ToString
                    _ImpresionEndoscopia.Texto9 = _ds.Tables(0).Rows(8)(1).ToString
                    _ImpresionEndoscopia.NumeroFotos = Val("9")
                    'ContadorFotos = 9
            End Select

            _dImpresionEndoscopia.GuardarImagenes(_ImpresionEndoscopia, _ds.Tables(0).Rows.Count)
            'MsgBox(_ds.Tables(0).Rows.Count)
            _dimagenes.EliminarTemporales(Filtro, _ds.Tables(0).Rows.Count)
        Else
            ContadorFotos = 0
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
        'llenamos combo Equipos

        'Listamos los equipos para procedimientos
        _ds = _DEquipos.ListarCombo
        cboEquipo.Properties.DataSource = _ds.Tables(0)
        cboEquipo.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboEquipo.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboEquipo.ItemIndex = -1

        'Listamos los Diagnosticos
        _ds = _DDiagnosticos.ListarCombo
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'Listamos los procedimientos terapeuticos
        _ds = _dProcedimientosTerapeuticos.ListarCombo
        cboProcedimientosTerapeuticos.Properties.DataSource = _ds.Tables(0)
        cboProcedimientosTerapeuticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboProcedimientosTerapeuticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboProcedimientosTerapeuticos.ItemIndex = 0


    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickIdTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "TIPOESTUDIO").ToString()
            _ClickCups = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _IdUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
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

    Private Sub txtAnestesiologo_EditValueChanged(sender As Object, e As EventArgs) Handles txtAnestesiologo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtIndicacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtIndicacion.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub cboEquipo_EditValueChanged(sender As Object, e As EventArgs) Handles cboEquipo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtMedicamentos_EditValueChanged(sender As Object, e As EventArgs) Handles txtMedicamentos.EditValueChanged
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
                MessageBox.Show("El campo Medico que solicita es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtIndicacion.Text = "" Then
                MessageBox.Show("El campo Indicación es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtDescripcion.Text = "" Then
                MessageBox.Show("El campo Descripción es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtCampo2.Text = "" Then
                MessageBox.Show("El campo " & xtpCampo2.Text & " es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtCampo3.Text = "" Then
                MessageBox.Show("El campo " & xtpCampo3.Text & " es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtCampo4.Text = "" Then
                MessageBox.Show("El campo " & xtpCampo4.Text & " es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtDiagnostico.Text = "" Then
                MessageBox.Show("El campo diagnostico es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboEquipo.Text = "" Then
                MessageBox.Show("No ha seleccionado el equipo", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cbodiagnosticos.Text = "" Then
                MessageBox.Show("El codigo diagnostico es obligatorio", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cbotomabiopsia.Text = "SI" And txtDescripcionBiopsia.Text = "" Then
                MessageBox.Show("la Descripcion de la Toma de la Biopsia es Obligatoria", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cbotomabiopsia.Text = "NO" And txtDescripcionBiopsia.Text <> "" Then
                MessageBox.Show("Realizo una descripcion en Toma de Biopsia, debe seleccionar SI en Toma de Biopsia para poder Guardar los cambios de la descripcion", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If GuardarEndoscopia() = True Then
                        If txtConsecutivo.Text = "" Then
                            _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                            'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
                            txtConsecutivo.Text = _Endoscopia.Id
                        End If
                        'Actualizar estado de detalle orden
                        Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
                        _DDetalleOrden.ActualizarDiagnosticoyEstado(lblIdDetalleOrden.Text, cboDiagnosticos.EditValue)
                        If _DDetalleOrden.DetalleOrdenPendiente(lblConsecutivoOrden.Text) = False Then
                            _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                        End If

                        'If MessageBox.Show("Desea imprimir el Estudio # " & txtConsecutivo.Text, "Imprimir Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ' ImprimirEstudio()
                        ' End If
                        ActualizarGrilla()
                        LimpiarCampos()
                        _Capturas.Items.Clear()
                        gcSeleccionadas.Gallery.Groups.Clear()
                    Else
                        MessageBox.Show("Se ha perdido la conexion al intentar guardar el Estudio, Favor Reintentar Guardar Nuevamente", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    'End If
                Else
                    If GuardarEndoscopia() = True Then
                        ActualizarGrilla()
                        If txtConsecutivo.Text = "" Then
                            _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                            txtConsecutivo.Text = _Endoscopia.Id
                            'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
                        End If
                    Else
                        MessageBox.Show("Se ha perdido la conexion al intentar guardar el Estudio, Favor Reintentar Guardar Nuevamente", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Else
            If GuardarEndoscopia() = True Then
                ActualizarGrilla()
                If txtConsecutivo.Text = "" Then
                    _Endoscopia = _DEndoscopia.UltimoRegistroEndoscopia()
                    txtConsecutivo.Text = _Endoscopia.Id
                    'txtConsecutivo.Text = _ClickIdTipoEstudio & _Endoscopia.Id
                End If
            Else
                MessageBox.Show("Se ha perdido la conexion al intentar guardar el Estudio, Favor Reintentar Guardar Nuevamente", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
            _frmOpen.IdDetalleOrden = _ClickIdTipoEstudiosAnteriores 'Registro
            _frmOpen.Licencia = LicenciaG
            _frmOpen.Estudio = Estudio
            _frmOpen.ShowDialog()

            'Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            'Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            'Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            '_DetalleOrden = _dDetalleOrden.Cargar(_ClickIdTipoEstudiosAnteriores)
            '
            '            Select Case _DetalleOrden.IdTipoEstudio
            '            Case 8
            '            ImpresionHistoria(_ClickIdTipoEstudiosAnteriores, "H")
            '            ImprimirFrm.CargarReporte("historia_clinica.rpt", _ClickIdTipoEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '            Case 9
            '            ImpresionHistoria(_ClickIdTipoEstudiosAnteriores, "C")
            '            ImprimirFrm.CargarReporte("historia_control.rpt", _ClickIdTipoEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '            Case 10
            '           ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '           ImprimirFrm.CargarReporte("endoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '           _dImpresionEndoscopia.EliminarEndoscopia(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '           Case 11
            '           ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '          ImprimirFrm.CargarReporte("colonoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '          _dImpresionEndoscopia.EliminarEndoscopia(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '          Case 12
            '          ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '          ImprimirFrm.CargarReporte("rectoscopia.rpt", _ClickIdTipoEstudiosAnteriores)
            '          _dImpresionEndoscopia.EliminarEndoscopia(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '          Case 13
            '          ImpresionHistoria(Registro, "C")
            '          ImprimirFrm.CargarReporte("historia_preanestesica.rpt", Registro)
            '          _dImpresionHistoria.EliminarHistoria(Registro, IdEmpleado)
            '          Case 15
            '          ImpresionEndoscopia(_ClickIdTipoEstudiosAnteriores)
            '          ImprimirFrm.CargarReporte("estudios_especiales.rpt", _ClickIdTipoEstudiosAnteriores)
            '          _dImpresionEndoscopia.EliminarEndoscopia(_ClickIdTipoEstudiosAnteriores, IdEmpleado)
            '          Case Else
            '          'MsgBox(Registro)
            '
            '            End Select
            _ClickIdTipoEstudiosAnteriores = ""
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
            Estudio = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
            ' MsgBox(_ClickIdTipoEstudiosAnteriores)
        End If
    End Sub

    Private Sub txtELCB_EditValueChanged(sender As Object, e As EventArgs) Handles txtELCB.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtCampo2_EditValueChanged_1(sender As Object, e As EventArgs) Handles txtCampo2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtCampo3_EditValueChanged_1(sender As Object, e As EventArgs) Handles txtCampo3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtCampo4_EditValueChanged(sender As Object, e As EventArgs) Handles txtCampo4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged_1(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtDatosUsuario_EditValueChanged(sender As Object, e As EventArgs)
        If TVDatosUsuarios.RowCount = 0 Then
            lblReporteEstudio.Visible = False
            lblCodigoDiagnostico.Visible = False
            xtcReporteEstudio.Visible = False
            cboDiagnosticos.Visible = False
        Else
            lblReporteEstudio.Visible = True
            lblCodigoDiagnostico.Visible = True
            xtcReporteEstudio.Visible = True
            cboDiagnosticos.Visible = True
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiAplicarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAplicarPlantilla.ItemClick
        If TVDatosUsuarios.RowCount = 0 Then
            MessageBox.Show("No ha seleccionado el Estudios para aplicar plantilla", "Estudios Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _Dplantillas As New SIM___GLOBAL.Controles.DPlantillasInformes
            _ds = _Dplantillas.AplicarPlantilla(IdEmpleado, _IDTipoEstudio)
            txtELCB.Text = _ds.Tables(0).Rows(0)(0).ToString
            txtDescripcion.Text = _ds.Tables(0).Rows(0)(1).ToString
            txtCampo2.Text = _ds.Tables(0).Rows(0)(2).ToString
            txtCampo3.Text = _ds.Tables(0).Rows(0)(3).ToString
            txtCampo4.Text = _ds.Tables(0).Rows(0)(4).ToString
            txtDiagnostico.Text = _ds.Tables(0).Rows(0)(5).ToString
        End If
    End Sub

    Private Sub lblConsecutivoOrden_EditValueChanged(sender As Object, e As EventArgs) Handles lblConsecutivoOrden.EditValueChanged
        If lblConsecutivoOrden.Text = "" Then
            lblReporteEstudio.Visible = False
            lblCodigoDiagnostico.Visible = False
            xtcReporteEstudio.Visible = False
            cboDiagnosticos.Visible = False
        Else
            lblReporteEstudio.Visible = True
            lblCodigoDiagnostico.Visible = True
            xtcReporteEstudio.Visible = True
            cboDiagnosticos.Visible = True
        End If
    End Sub

    Private Sub gcSeleccionadas_Gallery_ItemDoubleClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcSeleccionadas.Gallery.ItemDoubleClick
        Dim _frmOpen As New SIM_ENDOSCOPIA.frmTextoImagenes
        _frmOpen.txtTexoImagenes.Text = e.Item.Description
        _frmOpen.IdImagen = e.Item.Caption
        _frmOpen.ShowDialog()
        CargarImagenes(lblIdDetalleOrden.Text)
    End Sub

    Private Sub LabelControl9_Click(sender As Object, e As EventArgs) Handles LabelControl9.Click

    End Sub


End Class
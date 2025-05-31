Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports SIM_ENDOSCOPIA.Modelo
Imports SIM_ENDOSCOPIA.Controles

Public Class frmHistoria
#Region "DECLARACION DE VARIABLES"
    ReadOnly _funciones As New Funciones
    'Dim EstadoHistoria As Boolean = False
    Dim ContadorFotos As Byte
    Dim _ds As DataSet
    Dim _dsDiagnosticos As DataSet
    Dim _dsLaboratorios As DataSet
    Dim _dsRevisionSistemas As DataSet
    Dim _dsProcedimientos As DataSet
    Dim _dsEstudiosDiagnosticos As DataSet
    Dim _dsMedicamentos As DataSet
    Dim _dsViaAdministracion As DataSet
    Dim _dsCups As DataSet
    Dim _dordenes As New DOrdenes
    Dim _Ordenes As New Ordenes
    Dim _dsAntecedentes As New DataSet
    Dim _dsAntecedentesOrden As New DataSet
    Dim _DAntecedentes As New DAntecedentes
    'Dim _Usuarios As New Usuarios
    'Dim _dUduarios As New DUsuarios
    Dim _DhistoriaClinica = New DHistoriaClinica
    Dim _HistoriaClinica As New HistoriaClinica
    'Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden

    Dim _ClickGrilla As String
    Dim _ClickTipoEstudio As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickGrillaEstudiosAnteriores As String
    Dim _ClickCups As String
    Dim _IDUsuario As String

    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria

    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia

    Dim _HistoriaDiagnosticos As New HistoriaDiagnosticos
    Dim _DHistoriaDiagnosticos As New DHistoriaDiagnosticos

    Dim _HistoriaMedicamentos As New HistoriaMedicamentos
    Dim _DHistoriaMedicamentos As New DHistoriaMedicamentos

    Dim _HistoriaLaboratorios As New HistoriaLaboratorios
    Dim _DHistoriaLaboratorios As New DHistoriaLaboratorios

    Dim _HistoriaProcedimientos As New HistoriaProcedimientos
    Dim _DHistoriaProcedimientos As New DHistoriaProcedimientos

    Dim _DHistoriaEstudiosDiagnosticos As New SIM___GLOBAL.Controles.DHistoriaEstudiosDiagnosticos
    Dim _HistoriaEstudiosDiagnosticos As New SIM___GLOBAL.Modelo.HistoriaEstudiosDiagnosticos

    Dim _ExamenesPrequirurgicos As New SIM___GLOBAL.Modelo.ExamenesPrequirurgicos
    Dim _DExamenesPrequirurgicos As New SIM___GLOBAL.Controles.DExamenesPrequirurgicos

    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios

    Dim _ClickGrillaLaboratorios As String
    Dim _ClickGrillaProcedimientos As String
    Dim _ClickGrillaMedicamentos As String
    Dim _ClickGrillaDiagnosticos As String
    Dim _ClickGrillaRevisionxSistemas As String
    Dim _ClickGrillaEstudiosDiagnosticos As String
    Dim _ClickGrillaEP As String

    'Dim _Empleados As Empleados
    'Dim _dEmpleados = New DEmpleados
    Dim _DHistoriaRXS As New DHistoriaRXS
    Dim _HistoriaRXS As New HistoriaRXS

    Dim _Fila As Integer
    Dim _Diagnostico1 As String

    ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    ReadOnly _dDiagnostico = New DDiagnostico

    ReadOnly _DPercentil As New DPercentiles
    Public Licencia As String
    Public IdEmpleado As String
    Dim TipoEstudio As String

#End Region
#Region "PROCEDIMIENTOS Y FUNCIONES"
    Private Function IMC(ByVal peso As Double, ByVal talla As Double) As Double
        If peso <> 0 And talla <> 0 Then

            Dim x As Double = peso / ((talla / 100) ^ 2)
            If x < 18.5 Then
                txtValorIMC.Text = "Bajo"
            ElseIf x >= 18.5 And x <= 24.9 Then
                txtValorIMC.Text = "Normal"
            ElseIf x >= 25 And x <= 29.9 Then
                txtValorIMC.Text = "Sobrepeso"
            Else
                txtValorIMC.Text = "Obesidad"
            End If
            Return x
        Else
            Return Nothing
        End If
    End Function
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub GuardarRevisionSistemas()
        _HistoriaRXS.IdRXS = cboRevisionSistema.GetColumnValue("ID")
        _HistoriaRXS.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaRXS.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaRXS.Descripcion = txtDescripcionRevisionSistemas.Text
        _DHistoriaRXS.Guardar(_HistoriaRXS)
    End Sub
#End Region
    Private Sub GuardarLaboratorios()
        _HistoriaLaboratorios.IdLaboratorio = cboLaboratorios.EditValue
        _HistoriaLaboratorios.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaLaboratorios.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaLaboratorios.Descripcion = ""
        _DHistoriaLaboratorios.Guardar(_HistoriaLaboratorios)
    End Sub
    Private Sub GuardarDiagnostico()
        _HistoriaDiagnosticos.IdDiagnostico = cboDiagnosticos.EditValue
        _HistoriaDiagnosticos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaDiagnosticos.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaDiagnosticos.Descripcion = ""
        _DHistoriaDiagnosticos.Guardar(_HistoriaDiagnosticos)
    End Sub
    Private Sub GuardarMedicamentos()
        _HistoriaMedicamentos.IdMedicamento = cboMedicamentos.GetColumnValue("ID")
        _HistoriaMedicamentos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaMedicamentos.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaMedicamentos.IdViaAdministracion = cboViaAdministracion.GetColumnValue("ID")
        _HistoriaMedicamentos.Dosis = txtDosis.Text
        _HistoriaMedicamentos.Cantidad = txtCantidad.Text
        _HistoriaMedicamentos.Descripcion = txtDescripcionMedicamento.Text
        _DHistoriaMedicamentos.Guardar(_HistoriaMedicamentos)
    End Sub
    Private Sub GuardarProcedimientos()
        _HistoriaProcedimientos.IdProcedimiento = cboProcedimientos.EditValue
        _HistoriaProcedimientos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaProcedimientos.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaProcedimientos.Descripcion = ""
        _DHistoriaProcedimientos.Guardar(_HistoriaProcedimientos)
    End Sub
    Private Sub GuardarEstudiosDiagnosticos()
        _HistoriaEstudiosDiagnosticos.IdEstudio = cboEstudiosDiagnosticos.EditValue
        _HistoriaEstudiosDiagnosticos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaEstudiosDiagnosticos.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaEstudiosDiagnosticos.Descripcion = ""
        _DHistoriaEstudiosDiagnosticos.Guardar(_HistoriaEstudiosDiagnosticos)
    End Sub
    Private Sub GuardarExamenesPrequirurgicos(ByVal Examen As String)
        _ExamenesPrequirurgicos.Id = Val("")
        _ExamenesPrequirurgicos.IdOrden = Val(lblConsecutivoOrden.Text)
        _ExamenesPrequirurgicos.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _ExamenesPrequirurgicos.Examen = Examen
        _DExamenesPrequirurgicos.Guardar(_ExamenesPrequirurgicos)
    End Sub
    Private Sub LlenarCombos()

        'llenamos campo Revision Sistemas y examen fisico
        Dim _dRevisionSistema As New DRevisionSistemas
        _ds = New DataSet()
        _ds = _dRevisionSistema.ListarCombo()
        cboRevisionSistema.Properties.DataSource = _ds.Tables(0)
        cboRevisionSistema.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboRevisionSistema.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboRevisionSistema.ItemIndex = -1

        'llenamos COMBO Diagnosticos
        Dim _dDiagnosticos As New DDiagnostico
        _ds = New DataSet()
        _ds = _dDiagnosticos.ListarCombo()
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos COMBO medicamentos
        Dim _dMedicamentos As New DMedicamentos
        _ds = New DataSet()
        _ds = _dMedicamentos.ListarCombo()
        cboMedicamentos.Properties.DataSource = _ds.Tables(0)
        cboMedicamentos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedicamentos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        ' Llenamos combo Laboratorios
        Dim _dcups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dcups.ListarCombo()
        cboLaboratorios.Properties.DataSource = _dsCups.Tables(0)
        cboLaboratorios.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboLaboratorios.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

        ' Llenamos combo Procedimientos
        cboProcedimientos.Properties.DataSource = _dsCups.Tables(0)
        cboProcedimientos.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboProcedimientos.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption
        'llenamos Imagenes 
        cboEstudiosDiagnosticos.Properties.DataSource = _dsCups.Tables(0)
        cboEstudiosDiagnosticos.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboEstudiosDiagnosticos.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

        Dim _dViaAdministracion As New DViaAdministracion
        _dsViaAdministracion = New DataSet()
        _dsViaAdministracion = _dViaAdministracion.ListarCombo()
        cboViaAdministracion.Properties.DataSource = _dsViaAdministracion.Tables(0)
        cboViaAdministracion.Properties.DisplayMember = _dsViaAdministracion.Tables(0).Columns(1).Caption
        cboViaAdministracion.Properties.ValueMember = _dsViaAdministracion.Tables(0).Columns(0).Caption
        cboViaAdministracion.ItemIndex = -1
    End Sub
    Private Sub ImpresionHistoriaGeneral()
        _funciones.Imprimir(lblConsecutivoOrden.Text, lblIdDetalleOrden.Text, TipoEstudio, Licencia)

    End Sub
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        If LicenciaG = 4 Then 'Gastrolap
            If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Reporte = 1
            Else
                Reporte = 0
            End If
        End If
        ' Impresion de Historias
        _dImpresionHistoria.EliminarHistoria(IdEmpleado)
        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
        _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleado)
        ImprimirFrm.ImprimirEstudios(lblConsecutivoOrden.Text, lblIdDetalleOrden.Text, Reporte, Fotos, Licencia, Estudio, VistaPrevia)
    End Sub
    Private Sub ImprimirHistoria()
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
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
            Case 9
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                _funciones.ImprimirHistoria(lblIdDetalleOrden.Text, IdEmpleado)
                'ImpresionHistoria(lblIdDetalleOrden.Text, "C")
                ImprimirFrm.ImprimirReporte("historia_clinica.rpt", lblIdDetalleOrden.Text)
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
            Case 10
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("endoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgendoscopia.rpt", lblIdDetalleOrden.Text)
                End If
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
            Case 11
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("colonoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgcolonoscopia.rpt", lblIdDetalleOrden.Text)
                End If
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
            Case 12
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ImpresionEndoscopia(lblIdDetalleOrden.Text)
                If ContadorFotos = 0 Then
                    ImprimirFrm.ImprimirReporte("rectoscopia.rpt", lblIdDetalleOrden.Text)
                Else
                    ImprimirFrm.ImprimirReporte("imgrectoscopia.rpt", lblIdDetalleOrden.Text)
                End If
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
            Case 13
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                ImpresionHistoria(lblIdDetalleOrden.Text, "C")
                ImprimirFrm.CargarReporte("historia_preanestesica.rpt", lblIdDetalleOrden.Text)
            Case Else
                'MsgBox(Registro)
        End Select
    End Sub
    Private Sub ImpresionHistoria(ByVal Filtro As String, ByVal Control As String)

        'If IDOrdenG <> Nothing And Estado = "ATENDIDO" Then
        ' _funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If




        Dim _ds = New DataSet
        _ds = _dImpresionHistoria.Listar(Filtro, Control)
        _funciones.Imprimir(_ds.Tables(0).Rows(0)(0).ToString, _ds.Tables(0).Rows(0)(1).ToString, Estudio, Licencia)
        '************* CARGAMOS DATOS DE IMPRESION **************
        ' _ImpresionHistoria.Id = Val("")
        ' _ImpresionHistoria.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        ' _ImpresionHistoria.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        '_ImpresionHistoria.NumeroHistoria = _ds.Tables(0).Rows(0)(2).ToString
        '_ImpresionHistoria.Nombre = _ds.Tables(0).Rows(0)(3).ToString
        'ImpresionHistoria.Identificacion = _ds.Tables(0).Rows(0)(4).ToString
        'ImpresionHistoria.Edad = _ds.Tables(0).Rows(0)(5).ToString
        '_ImpresionHistoria.Sexo = _ds.Tables(0).Rows(0)(6).ToString
        '_ImpresionHistoria.EstadoCivil = _ds.Tables(0).Rows(0)(7).ToString
        '_ImpresionHistoria.Telefono = _ds.Tables(0).Rows(0)(8).ToString
        '_ImpresionHistoria.Direccion = _ds.Tables(0).Rows(0)(9).ToString
        '_ImpresionHistoria.Entidad = _ds.Tables(0).Rows(0)(10).ToString
        '_ImpresionHistoria.FechaIngreso = _ds.Tables(0).Rows(0)(11).ToString
        '_ImpresionHistoria.FechaAtencion = _ds.Tables(0).Rows(0)(12).ToString
        '_ImpresionHistoria.MotivoConsulta = _ds.Tables(0).Rows(0)(13).ToString
        '_ImpresionHistoria.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(14).ToString
        '_ImpresionHistoria.AntecedentesPersonales = _ds.Tables(0).Rows(0)(15).ToString
        '_ImpresionHistoria.EnfermedadActual = _ds.Tables(0).Rows(0)(16).ToString
        '_ImpresionHistoria.RevisionxSistemas = _ds.Tables(0).Rows(0)(17).ToString
        '_ImpresionHistoria.PlanSeguir = _ds.Tables(0).Rows(0)(18).ToString
        '_ImpresionHistoria.Diagnostico = _ds.Tables(0).Rows(0)(19).ToString
        '_ImpresionHistoria.Recomendaciones = _ds.Tables(0).Rows(0)(20).ToString
        '_ImpresionHistoria.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(21))
        '_ImpresionHistoria.Medico = _ds.Tables(0).Rows(0)(22).ToString
        '_ImpresionHistoria.Especialidad = _ds.Tables(0).Rows(0)(23).ToString
        '_ImpresionHistoria.RegistroMedico = _ds.Tables(0).Rows(0)(24).ToString
        '_ImpresionHistoria.IdEmpleado = IdEmpleado
        '_dImpresionHistoria.Guardar(_ImpresionHistoria)
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
        _ImpresionEndoscopia.IdEmpleado = IdEmpleado '_ds.Tables(0).Rows(0)(26).ToString

        '************* VERIFICAMOS SI EXISTEN IMAGENES **********
        ContadorFotos = 0
        If _dimagenes.ExisteImagenes(Filtro) = True Then
            ContadorFotos = 1
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
    Private Sub LimpiarCampos()
        'limpiamos campos
        TipoEstudio = ""
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtNumeroHistoria.Text = ""
        GCDatosUsuarios.DataSource = Nothing
        txtAntecedentesFamiliares2.Text = ""
        txtAntecedentesPersonales2.Text = ""
        txtMotivoConsulta.Text = ""
        txtResponsables.Text = Nothing
        txtConsultaControl.Text = Nothing
        txtEnfermedadActual.Text = Nothing
        txtRevisionxSistemas.Text = Nothing
        txtAntecedentesFamiliares.Text = Nothing
        txtAntecedentesPersonales.Text = Nothing
        txtExamenFisico.Text = ""
        txtPeso.Text = ""
        txtTalla.Text = ""
        txtIMC.Text = ""
        txtTA.Text = ""
        txtFC.Text = ""
        txtFR.Text = ""
        txtTemperatura.Text = ""
        txtDiagnostico.Text = ""
        txtPlanSeguir.Text = ""
        txtRemision.Text = ""
        txtFormulacion.Text = ""
        txtLaboratorios.Text = ""
        txtOtrosEstudios.Text = ""

        chkProcesado.Checked = False

        'Limpiamos grilla de Revision por Sistemas
        GCRevisionSistema.DataSource = Nothing
        txtDescripcionRevisionSistemas.Text = ""

        'Limpiamos grilla de Medicamentos
        GCMedicamentos.DataSource = Nothing
        txtDescripcionMedicamento.Text = ""
        txtDosis.Text = ""
        txtCantidad.Text = ""

        'Limpiamos grilla de Laboratorios
        GCLaboratorios.DataSource = Nothing
        cboLaboratorios.Text = ""

        'Limpiamos grilla de Procedimientos
        GCProcedimientos.DataSource = Nothing
        cboProcedimientos.Text = ""

        'Limpiamos grilla de Diagnosticos
        GCDiagnosticos.DataSource = Nothing
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrillaPacientesAtender()
        'llenamos grilla de pacientes por atender
        Dim _ds = New DataSet()
        _ds = _dordenes.PacientesHistoriaEndoscopia(IdEmpleado)
        GCPacientesAtender.DataSource = _ds.Tables(0)

    End Sub
    Private Sub NuevaHistoria()

        lblHistoriaClinica.Text = "Historia Clinica" & " - " & _ClickTipoEstudio
        'llenamos los combos
        'LlenarCombos()

        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        TipoEstudio = _ClickTipoEstudio

        'txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")
        '------------Traemoda datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        '********** Obtenemos el ID del usuario ******************
        '_Ordenes = _dordenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _ds.Tables(0).Rows(0)(0).ToString()

        '----------------------- Bloqueamos la historia del paciente -------------------
        '_DDetalleOrden.ProcesoDetalleOrden(lblIdDetalleOrden.Text)

        Select Case _ClickTipoEstudio
            Case "CONSULTA PRIMERA VEZ"
                xtpMotivoConsulta.PageVisible = True
                xtpConsultaControl.PageVisible = False
                xtpAntecedentes.PageVisible = True
                xtpEnfermedadActual.PageVisible = True
                xtpRevisionxSistemas.PageVisible = True
                xtpMotivoConsulta.Show()

            Case Else
                xtpMotivoConsulta.PageVisible = False
                xtpConsultaControl.PageVisible = True
                xtpAntecedentes.PageVisible = False
                xtpEnfermedadActual.PageVisible = False
                xtpRevisionxSistemas.PageVisible = False
                xtpConsultaControl.Show()
        End Select

        '************** Traemos Antecedentes del Paciente *****************

        'If _ds.Tables(0).Rows.Count <> 0 Then
        ' xtpAntecedentes.PageVisible = False

        If _DAntecedentes.ExisteUsuarioAntecedente(lblConsecutivo.Text) = True Then
            _dsAntecedentes = _DAntecedentes.ListarAntecedentes(lblConsecutivo.Text)
            txtAntecedentesFamiliares2.Text = _dsAntecedentes.Tables(0).Rows(0)(0).ToString
            txtAntecedentesPersonales2.Text = _dsAntecedentes.Tables(0).Rows(0)(1).ToString
        End If

        If _DAntecedentes.Existe(lblConsecutivoOrden.Text) = True Then
            _dsAntecedentesOrden = _DAntecedentes.CargarAntecedentes(lblConsecutivoOrden.Text)
            txtAntecedentesFamiliares.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(0).ToString
            txtAntecedentesPersonales.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(1).ToString
        End If

        If _DhistoriaClinica.Existe(lblConsecutivoOrden.Text) = True Then

            ' traemos historias anteriores sin firmar para edicion
            _HistoriaClinica = _DhistoriaClinica.cargar(lblConsecutivoOrden.Text)
            txtNumeroHistoria.Text = _HistoriaClinica.CodigoHistoria
            txtMotivoConsulta.Text = _HistoriaClinica.MotivoConsulta
            txtResponsables.Text = _HistoriaClinica.Responsables
            txtConsultaControl.Text = _HistoriaClinica.ConsultaControl
            txtEnfermedadActual.Text = _HistoriaClinica.EnfermedadActual
            txtRevisionxSistemas.Text = _HistoriaClinica.RevisionxSistemas
            txtExamenFisico.Text = _HistoriaClinica.ExamenFisico
            txtDiagnostico.Text = _HistoriaClinica.Diagnostico
            txtPlanSeguir.Text = _HistoriaClinica.PlanSeguir
            txtRemision.Text = _HistoriaClinica.Remision
            'campos Anexos
            txtFormulacion.Text = _HistoriaClinica.formulacion
            txtLaboratorios.Text = _HistoriaClinica.Laboratorios
            txtOtrosEstudios.Text = _HistoriaClinica.OtrosEstudios
            txtEstudiosDiagnosticos.Text = _HistoriaClinica.EstudiosDiagnosticos
            'traemos examen fisico
            txtPeso.Text = _HistoriaClinica.Peso
            txtTalla.Text = _HistoriaClinica.Talla
            txtTA.Text = _HistoriaClinica.TensionArterial
            txtFC.Text = _HistoriaClinica.FrecuenciaCardiaca
            txtFR.Text = _HistoriaClinica.FrecuenciaRespiratoria
            txtTemperatura.Text = _HistoriaClinica.Temperatura
        End If

        ' Traemos Revision por sistemas de la historia clinica actual
        _dsRevisionSistemas = New DataSet()
        _dsRevisionSistemas = _DHistoriaRXS.Listar(lblConsecutivoOrden.Text)
        GCRevisionSistema.DataSource = _dsRevisionSistemas.Tables(0)

        ' Traemos DIAGNOSTICOS de la historia clinica actual
        _ds = New DataSet()
        _ds = _DHistoriaDiagnosticos.Listar(lblConsecutivoOrden.Text)
        GCDiagnosticos.DataSource = _ds.Tables(0)

        ' Traemos LABORATORIOS de la historia clinica actual
        _dsLaboratorios = New DataSet()
        _dsLaboratorios = _DHistoriaLaboratorios.Listar(lblConsecutivoOrden.Text)
        GCLaboratorios.DataSource = _dsLaboratorios.Tables(0)

        ' Traemos procedimientos de la historia clinica actual
        _dsProcedimientos = New DataSet()
        _dsProcedimientos = _DHistoriaProcedimientos.Listar(lblConsecutivoOrden.Text)
        GCProcedimientos.DataSource = _dsProcedimientos.Tables(0)

        ' Traemos estudios diagnosticos de la historia clinica actual
        _dsEstudiosDiagnosticos = New DataSet()
        _dsEstudiosDiagnosticos = _DHistoriaEstudiosDiagnosticos.Listar(lblConsecutivoOrden.Text)
        GCEstudiosDiagnosticos.DataSource = _dsEstudiosDiagnosticos.Tables(0)

        ' Traemos Medicamentos de la historia clinica actual
        _dsMedicamentos = New DataSet()
        _dsMedicamentos = _DHistoriaMedicamentos.Listar(lblConsecutivoOrden.Text)
        GCMedicamentos.DataSource = _dsMedicamentos.Tables(0)

        '****** Traer Historias Anteriores **********
        _ds = New DataSet()
        _ds = _dordenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)
        '***************************************'_ds = New DataSet()

        If Licencia = 14 Then
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
            xtpRemision.PageVisible = True
        Else
            xtpRemision.PageVisible = False
        End If

        'desactivamos el boton GUARDAR
        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarHistoria()
        '_HistoriaClinica.Id = Val(lblConsecutivo.Text)
        'Asignamos el Numero de la Historia
        txtNumeroHistoria.Text = Funciones.CodigoUsuario(lblConsecutivoOrden.Text) & Mid(dtFechaIngreso.Text, 7, 4) & Mid(dtFechaIngreso.Text, 4, 2) & Mid(dtFechaIngreso.Text, 1, 2)

        _HistoriaClinica.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaClinica.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _HistoriaClinica.FechaHistoria = dtFechaIngreso.Text
        _HistoriaClinica.CodigoHistoria = txtNumeroHistoria.Text
        _HistoriaClinica.MotivoConsulta = txtMotivoConsulta.Text
        _HistoriaClinica.Responsables = txtResponsables.Text
        _HistoriaClinica.ConsultaControl = txtConsultaControl.Text
        _HistoriaClinica.EnfermedadActual = txtEnfermedadActual.Text
        _HistoriaClinica.RevisionxSistemas = txtRevisionxSistemas.Text
        _HistoriaClinica.ExamenFisico = txtExamenFisico.Text
        _HistoriaClinica.Peso = txtPeso.Text
        _HistoriaClinica.Talla = txtTalla.Text
        _HistoriaClinica.TensionArterial = txtTA.Text
        _HistoriaClinica.FrecuenciaCardiaca = txtFC.Text
        _HistoriaClinica.FrecuenciaRespiratoria = txtFR.Text
        _HistoriaClinica.Temperatura = txtTemperatura.Text
        _HistoriaClinica.Diagnostico = txtDiagnostico.Text
        _HistoriaClinica.PlanSeguir = txtPlanSeguir.Text
        _HistoriaClinica.Remision = txtRemision.Text
        _HistoriaClinica.Formulacion = txtFormulacion.Text
        _HistoriaClinica.Laboratorios = txtLaboratorios.Text
        _HistoriaClinica.OtrosEstudios = txtOtrosEstudios.Text
        _HistoriaClinica.EstudiosDiagnosticos = txtEstudiosDiagnosticos.Text
        _HistoriaClinica.TannerA = "-"
        _HistoriaClinica.TannerB = "-"
        _HistoriaClinica.TannerP = "-"
        _HistoriaClinica.TannerVT = "-"
        _HistoriaClinica.Estado = "A"
        _HistoriaClinica.IdEspecialista = IdEmpleado
        _DhistoriaClinica.Guardar(_HistoriaClinica)

        '***************** Actualizamos el estado de la Orden a Atendido *****************
        '_dordenes.ActualizarEstado(Val(lblConsecutivoOrden.Text), "ATENDIDO")
    End Sub
    Private Sub GuardarAntecedentes()
        Dim _Antecedentes As New Antecedentes
        Dim _DAntecedentes As New DAntecedentes
        _Antecedentes.IdOrden = Val(lblConsecutivoOrden.Text)
        _Antecedentes.IdUsuario = Val(lblConsecutivo.Text)
        _Antecedentes.AntecedentesFamiliares = txtAntecedentesFamiliares.Text
        _Antecedentes.AntecedentesPersonales = txtAntecedentesPersonales.Text
        _DAntecedentes.Guardar(_Antecedentes)

    End Sub

    Private Sub frmHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GCDatosUsuarios.DataSource = Nothing
        'llenamos grilla de pacientes por atender
        ActualizarGrillaPacientesAtender()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")

        xtpMotivoConsulta.PageVisible = True
        xtpEnfermedadActual.PageVisible = True
        xtpAntecedentes.PageVisible = True
        xtpExamenFisico.PageVisible = True
        xtpDiagnostico.PageVisible = True
        xtpAnalisis.PageVisible = True
        xtpConsultaControl.PageVisible = False
        xtpCurva.PageVisible = False
        xtpExamenesPrequirurgicos.PageVisible = False
        LlenarCombos()

        Select Case Licencia
            Case 3 'DITEG
                'xtcReporteEstudio.TabPages.Move(6, xtpLaboratorios)
                'xtcReporteEstudio.TabPages.Move(7, xtpOtrosEstudios)
                xtcReporteEstudio.TabPages.Move(8, xtpAnalisis)
            Case 14 'PONCE
                xtpExamenesPrequirurgicos.PageVisible = True
            Case Else

        End Select

    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        ' INFORMACION DEL PACIENTE POR ATENDER
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Historia", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una historia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nueva Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                NuevaHistoria()
            End If
        Else
            LimpiarCampos()
            NuevaHistoria()

        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()

            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If chkProcesado.Checked = True Then
            If TVDatosUsuarios.RowCount = 0 Then
                MessageBox.Show("No ha Seleccionado Paciente para Guardar Historia", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dtFechaIngreso.Text = "" Then
                MessageBox.Show("Campo Fecha de Historia es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtMotivoConsulta.Text = "" And xtpMotivoConsulta.Visible = True Then
                MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtEnfermedadActual.Text = "" And xtpEnfermedadActual.Visible = True Then
                '   MessageBox.Show("Campo Enfermedad Actual es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtAntecedentesFamiliares.Text = "" And xtpAntecedentes.Visible = True Then
                MessageBox.Show("Campo Antecedentes Familiares es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtAntecedentesPersonales.Text = "" And xtpAntecedentes.Visible = True Then
                MessageBox.Show("Campo Antecedentes Personales es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtExamenFisico.Text = "" And xtpExamenFisico.Visible = True Then
                '   MessageBox.Show("Campo Examen Fisico es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtDiagnostico.Text = "" And xtpDiagnostico.Visible = True Then
                '   MessageBox.Show("Campo Diagnostico es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtPlanSeguir.Text = "" And xtpAnalisis.Visible = True Then
                '   MessageBox.Show("Campo Analisis y Plan es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtConsultaControl.Text = "" And xtpConsultaControl.Visible = True Then
                MessageBox.Show("Campo Evolución es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf GVDiagnosticos.RowCount = 0 Then
                MessageBox.Show("Diagnostico CIE10 es obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar la Historia?, Si continua no se podran hacer cambios en la historia. ¿Desea Continuar?", "Firmar Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    GuardarHistoria()

                    '*********************** Guardar Antecedentes ****************************
                    If xtpAntecedentes.PageVisible = True Then
                        GuardarAntecedentes()
                    End If

                    If _DhistoriaClinica.existe(lblConsecutivoOrden.Text) = True Then
                        'Actualizar estado de detalle orden
                        Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
                        _DDetalleOrden.ActualizarDiagnosticoyEstado(lblIdDetalleOrden.Text, GVDiagnosticos.GetRowCellValue(0, "CODIGO").ToString())
                        If _DDetalleOrden.DetalleOrdenPendiente(lblConsecutivoOrden.Text) = False Then
                            _dordenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                        End If

                        'If MessageBox.Show("Desea imprimir la historia", "Imprimir Historia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        'Dim _frmOrdenesMedicas As New SIM___GLOBAL.frmOrdenesMedicas
                        '_frmOrdenesMedicas.IdOrden = lblConsecutivoOrden.Text
 _ 'frmOrdenesMedicas.Licencia = Licencia
                        '_frmOrdenesMedicas.IdEmpleado = IdEmpleado
                        ' _frmOrdenesMedicas.IdDetalleOrden = lblIdDetalleOrden.Text
                        '  _frmOrdenesMedicas.TipoEstudio = TipoEstudio
                        '   _frmOrdenesMedicas.ShowDialog()
                        'ImprimirHistoria()
                        'End If
                        LimpiarCampos()
                        Else
                            MessageBox.Show("La historia clinica no se pudo firmar. Verifique si fue guardada.", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    GuardarHistoria()
                    '*********************** Guardar Antecedentes ****************************
                    If xtpAntecedentes.PageVisible = True Then
                        GuardarAntecedentes()
                    End If

                End If

                '****** Traer Historias Anteriores **********
                _ds = New DataSet()
                _ds = _dordenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
                GCHistoriasAnteriores.DataSource = _ds.Tables(0)
                '***************************************

                ActualizarGrillaPacientesAtender()
                bbiGuardar.Enabled = False
            End If
        Else
            GuardarHistoria()

            '*********************** Guardar Antecedentes ****************************
            If xtpAntecedentes.PageVisible = True Then
                GuardarAntecedentes()
            End If

            ActualizarGrillaPacientesAtender()
            bbiGuardar.Enabled = False
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub btVistaPrevia_Click(sender As Object, e As EventArgs) Handles btVistaPrevia.Click
        If _ClickGrillaEstudiosAnteriores <> "" Then
            Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
            _frmOpen.IdDetalleOrden = _ClickGrillaEstudiosAnteriores 'Registro
            _frmOpen.Licencia = Licencia
            _frmOpen.Estudio = Estudio
            _frmOpen.ShowDialog()
            '   Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            '   Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            '   Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            '   _DetalleOrden = _dDetalleOrden.Cargar(_ClickGrillaEstudiosAnteriores)
            '
            '            Select Case _DetalleOrden.IdTipoEstudio
            '            Case 8
            '            ImpresionHistoria(_ClickGrillaEstudiosAnteriores, "H")
            '            ImprimirFrm.CargarReporte("historia_clinica.rpt", _ClickGrillaEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            '            Case 9
            '            ImpresionHistoria(_ClickGrillaEstudiosAnteriores, "C")
            '            ImprimirFrm.CargarReporte("historia_control.rpt", _ClickGrillaEstudiosAnteriores)
            '            _dImpresionHistoria.EliminarHistoria(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            '            Case 10
            '            ImpresionEndoscopia(_ClickGrillaEstudiosAnteriores)
            'ImprimirFrm.CargarReporte("endoscopia.rpt", _ClickGrillaEstudiosAnteriores)
            '                    _dImpresionEndoscopia.EliminarEndoscopia(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            '            Case 11
            'ImpresionEndoscopia(_ClickGrillaEstudiosAnteriores)
            ' ImprimirFrm.CargarReporte("colonoscopia.rpt", _ClickGrillaEstudiosAnteriores)
            ' _dImpresionEndoscopia.EliminarEndoscopia(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            ' Case 12
            ' ImpresionEndoscopia(_ClickGrillaEstudiosAnteriores)
            ' ImprimirFrm.CargarReporte("rectoscopia.rpt", _ClickGrillaEstudiosAnteriores)
            ' _dImpresionEndoscopia.EliminarEndoscopia(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            ' Case 13
            ' ImpresionHistoria(Registro, "C")
            ' ImprimirFrm.CargarReporte("historia_preanestesica.rpt", _ClickGrillaEstudiosAnteriores)
            ' _dImpresionHistoria.EliminarHistoria(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            ' Case 15
            ' ImpresionEndoscopia(_ClickGrillaEstudiosAnteriores)
            ' ImprimirFrm.CargarReporte("estudios_especiales.rpt", _ClickGrillaEstudiosAnteriores)
            ' _dImpresionEndoscopia.EliminarEndoscopia(_ClickGrillaEstudiosAnteriores, IdEmpleado)
            ' Case Else
            ' 'MsgBox(Registro)
            '
            '            End Select
        Else
            MessageBox.Show("Debe Seleccionar un Estudio o Historia", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gvHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaEstudiosAnteriores = gvHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            Estudio = gvHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            '_ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            '_ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrillaPacientesAtender()
    End Sub

    Private Sub txtPeso_Leave(sender As Object, e As EventArgs) Handles txtPeso.Leave
        If txtPeso.Text <> "" And txtTalla.Text <> "" Then
            txtIMC.Text = IMC(txtPeso.Text, txtTalla.Text)
        End If
    End Sub

    Private Sub txtTalla_Leave(sender As Object, e As EventArgs) Handles txtTalla.Leave
        If txtPeso.Text <> "" And txtTalla.Text <> "" Then
            txtIMC.Text = IMC(txtPeso.Text, txtTalla.Text)
        End If
    End Sub

    Private Sub cmdAgregarRevisionSistemas_Click(sender As Object, e As EventArgs) Handles cmdAgregarRevisionSistemas.Click
        If txtNumeroHistoria.Text <> "" Then
            If cboRevisionSistema.Text = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Revision por Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtDescripcionRevisionSistemas.Text = "" Then
                MessageBox.Show("Falta descripcion de Revision por Sistemas", "Revision por Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaRXS.Existe(cboRevisionSistema.GetColumnValue("ID"), lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Item ya fue agregado", "Revision por Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarRevisionSistemas()
                _ds = New DataSet()
                _ds = _DHistoriaRXS.Listar(lblConsecutivoOrden.Text)
                GCRevisionSistema.DataSource = _ds.Tables(0)

                'Limpiamos campos
                txtDescripcionRevisionSistemas.Text = ""
            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar el item", "Revision por Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEliminarRevisionSistemas_Click(sender As Object, e As EventArgs) Handles cmdEliminarRevisionSistemas.Click
        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaRevisionxSistemas = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Revision por Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaRXS.Eliminar(_ClickGrillaRevisionxSistemas, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaRXS.Listar(lblConsecutivoOrden.Text)
                GCRevisionSistema.DataSource = _ds.Tables(0)

                _ClickGrillaRevisionxSistemas = ""
            End If
        End If
    End Sub

    Private Sub GVRevisionSistema_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVRevisionSistema.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaRevisionxSistemas = GVRevisionSistema.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub cmdAgregarDiagnostico_Click(sender As Object, e As EventArgs) Handles cmdAgregarDiagnostico.Click
        If txtNumeroHistoria.Text <> "" Then
            If cboDiagnosticos.EditValue = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtDescripcionDiagnostico.Text = "" Then
                '   MessageBox.Show("Falta descripcion del Diagnostico", "Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaDiagnosticos.Existe(cboDiagnosticos.EditValue, lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Diagnostico ya fue agregado", "Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarDiagnostico()
                _ds = New DataSet()
                _ds = _DHistoriaDiagnosticos.Listar(lblConsecutivoOrden.Text)
                GCDiagnosticos.DataSource = _ds.Tables(0)

            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar el diagnostico", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEliminarDiagnostico_Click(sender As Object, e As EventArgs) Handles cmdEliminarDiagnostico.Click
        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaDiagnosticos = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Agregar Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaDiagnosticos.Eliminar(_ClickGrillaDiagnosticos, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaDiagnosticos.Listar(lblConsecutivoOrden.Text)
                GCDiagnosticos.DataSource = _ds.Tables(0)

                _ClickGrillaDiagnosticos = ""
            End If
        End If
    End Sub

    Private Sub GVDiagnosticos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDiagnosticos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDiagnosticos = GVDiagnosticos.GetRowCellValue(e.RowHandle.ToString, "CODIGO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnActualizarDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnActualizarDiagnosticos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmDiagnosticos
        _frmOpen.ShowDialog()

        'llenamos COMBO Diagnosticos
        Dim _dDiagnosticos As New DDiagnostico
        _dsDiagnosticos = New DataSet()
        _dsDiagnosticos = _dDiagnosticos.ListarCombo()
        cboDiagnosticos.Properties.DataSource = _dsDiagnosticos.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _dsDiagnosticos.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _dsDiagnosticos.Tables(0).Columns(0).Caption
    End Sub
    Private Sub cmdImprimirLaboratorio_Click(sender As Object, e As EventArgs)
        'If txtnumerohistoria.Text <> "" Then
        ' Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        'ImprimirFrm.CargarReporte("examenes_laboratorios.rpt", lblConsecutivoOrden.Text)
        'End If
    End Sub
    Private Sub cmdImprimirMedicamentos_Click(sender As Object, e As EventArgs)
        If txtNumeroHistoria.Text <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("medicamentos.rpt", lblConsecutivoOrden.Text)
        End If
    End Sub

    Private Sub txtMotivoConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtResponsables_EditValueChanged(sender As Object, e As EventArgs) Handles txtResponsables.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtConsultaControl_EditValueChanged(sender As Object, e As EventArgs) Handles txtConsultaControl.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtEnfermedadActual_EditValueChanged(sender As Object, e As EventArgs) Handles txtEnfermedadActual.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAntecedentesPersonales_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentesPersonales.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAntecedentesFamiliares_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentesFamiliares.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtExamenFisico_EditValueChanged(sender As Object, e As EventArgs) Handles txtExamenFisico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPeso_EditValueChanged(sender As Object, e As EventArgs) Handles txtPeso.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTalla_EditValueChanged(sender As Object, e As EventArgs) Handles txtTalla.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTA_EditValueChanged(sender As Object, e As EventArgs) Handles txtTA.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtFC_EditValueChanged(sender As Object, e As EventArgs) Handles txtFC.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtFR_EditValueChanged(sender As Object, e As EventArgs) Handles txtFR.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTemperatura_EditValueChanged(sender As Object, e As EventArgs) Handles txtTemperatura.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPlanSeguir_EditValueChanged(sender As Object, e As EventArgs) Handles txtPlanSeguir.EditValueChanged
        ActivarGuardar()
    End Sub
    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRevisionxSistemas_EditValueChanged(sender As Object, e As EventArgs) Handles txtRevisionxSistemas.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRemision_EditValueChanged(sender As Object, e As EventArgs) Handles txtRemision.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cmdAgregarExamen_Click(sender As Object, e As EventArgs) Handles cmdAgregarExamen.Click
        If lblConsecutivoOrden.Text <> "" Then
            If txtExamen.Text = "" Then
                MessageBox.Show("No hay examen para agregar", "Examenes Prequirurgicos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarExamenesPrequirurgicos(txtExamen.Text)
                txtExamen.Text = ""
                _ds = New DataSet()
                _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
                gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
            End If
        End If
    End Sub

    Private Sub gvExamenesPrequirurgicos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvExamenesPrequirurgicos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaEP = gvExamenesPrequirurgicos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub chkHemograma_CheckedChanged(sender As Object, e As EventArgs) Handles chkHemograma.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkHemograma.Checked = True Then
                GuardarExamenesPrequirurgicos("HEMOGRAMA")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "HEMOGRAMA")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub chkGlicemia_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlicemia.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkGlicemia.Checked = True Then
                GuardarExamenesPrequirurgicos("GLICEMIA AYUNAS")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "GLICEMIA AYUNAS")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub chkTP_CheckedChanged(sender As Object, e As EventArgs) Handles chkTP.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkTP.Checked = True Then
                GuardarExamenesPrequirurgicos("T.P. (Tiempo de Protombina)")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "T.P. (Tiempo de Protombina)")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub chkTPT_CheckedChanged(sender As Object, e As EventArgs) Handles chkTPT.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkTPT.Checked = True Then
                GuardarExamenesPrequirurgicos("T.P.T. (Tiempo Parcial de Tromboplastina)")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "T.P.T. (Tiempo Parcial de Tromboplastina)")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub chkRecuentoPlaquetas_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecuentoPlaquetas.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkRecuentoPlaquetas.Checked = True Then
                GuardarExamenesPrequirurgicos("RECUENTO DE PLAQUETAS")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "RECUENTO DE PLAQUETAS")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub chkBUN_CheckedChanged(sender As Object, e As EventArgs) Handles chkBUN.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkBUN.Checked = True Then
                GuardarExamenesPrequirurgicos("B.U.N.")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "B.U.N.")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub
    Private Sub chkCreatinina_CheckedChanged(sender As Object, e As EventArgs) Handles chkCreatinina.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkCreatinina.Checked = True Then
                GuardarExamenesPrequirurgicos("CREATININA")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "CREATININA")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub
    Private Sub chkUrianalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkUrianalisis.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkUrianalisis.Checked = True Then
                GuardarExamenesPrequirurgicos("URIANALISIS")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "URIANALISIS")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub
    Private Sub chkElectrocardiograma_CheckedChanged(sender As Object, e As EventArgs) Handles chkElectrocardiograma.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkElectrocardiograma.Checked = True Then
                GuardarExamenesPrequirurgicos("ELECTROCARDIOGRAMA")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "ELECTROCARDIOGRAMA")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub
    Private Sub chkRXTorax_CheckedChanged(sender As Object, e As EventArgs) Handles chkRXTorax.CheckedChanged
        If lblConsecutivoOrden.Text <> "" Then
            If chkRXTorax.Checked = True Then
                GuardarExamenesPrequirurgicos("RADIOGRAFIA DE TORAX P.A. Y LATERAL")
            Else
                _DExamenesPrequirurgicos.EliminarExamen(lblConsecutivoOrden.Text, "RADIOGRAFIA DE TORAX P.A. Y LATERAL")
            End If
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
        End If
    End Sub
    Private Sub cmdRadiografiaDinamica_Click(sender As Object, e As EventArgs) Handles cmdRadiografiaDinamica.Click
        If lblConsecutivoOrden.Text <> "" Then
            txtExamen.Text = "Radiografías dinámicas de columna            Proyecciones AP, Laterales en Flexión, Neutro y Extensión"
        End If
    End Sub
    Private Sub cmdEliminarExamen_Click(sender As Object, e As EventArgs) Handles cmdEliminarExamen.Click
        If _ClickGrillaEP = "" Then
            MessageBox.Show("Debe seleccionar el examen a eliminar", "Examenes Prequirurgicos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DExamenesPrequirurgicos.Eliminar(_ClickGrillaEP)
            _ds = New DataSet()
            _ds = _DExamenesPrequirurgicos.Listar(lblConsecutivoOrden.Text)
            gcExamenesPrequirurgicos.DataSource = _ds.Tables(0)
            _ClickGrillaEP = ""
        End If
    End Sub
    Private Sub cmdImprimirExamenesPrequirurgicos_Click(sender As Object, e As EventArgs) Handles cmdImprimirExamenesPrequirurgicos.Click
        If txtNumeroHistoria.Text = "" Then
            MessageBox.Show("Debe guardar primero la historia", "Examenes Prequirurgicos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub
    Private Sub cmdAgregarLaboratorio_Click(sender As Object, e As EventArgs) Handles cmdAgregarLaboratorio.Click

        If txtNumeroHistoria.Text <> "" Then
            If cboLaboratorios.Text = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtDescripcionLaboratorios.Text = "" Then
                '   MessageBox.Show("Falta descripcion del Examen o Laboratorio", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaLaboratorios.Existe(cboLaboratorios.EditValue, lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Item ya fue agregado", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarLaboratorios()
                _ds = New DataSet()
                _ds = _DHistoriaLaboratorios.Listar(lblConsecutivoOrden.Text)
                GCLaboratorios.DataSource = _ds.Tables(0)

                'Limpiamos campos
                'txtDescripcionLaboratorios.Text = ""
                cboLaboratorios.Text = ""

            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar laboratorios", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub cmdEliminarLaboratorio_Click(sender As Object, e As EventArgs) Handles cmdEliminarLaboratorio.Click

        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaLaboratorios = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaLaboratorios.Eliminar(_ClickGrillaLaboratorios, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaLaboratorios.Listar(lblConsecutivoOrden.Text)
                GCLaboratorios.DataSource = _ds.Tables(0)

                _ClickGrillaLaboratorios = ""
            End If
        End If
    End Sub
    Private Sub btnAgregarLaboratorios_Click(sender As Object, e As EventArgs) Handles btnAgregarLaboratorios.Click

        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()

        'llenamos COMBO 
        Dim _dcups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dcups.ListarCombo()
        cboLaboratorios.Properties.DataSource = _dsCups.Tables(0)
        cboLaboratorios.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboLaboratorios.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

    End Sub

    Private Sub btnAgregarEstudiosDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnAgregarEstudiosDiagnosticos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()

        'llenamos COMBO 
        Dim _dcups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dcups.ListarCombo()
        cboEstudiosDiagnosticos.Properties.DataSource = _dsCups.Tables(0)
        cboEstudiosDiagnosticos.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboEstudiosDiagnosticos.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption
    End Sub

    Private Sub btnAgregarProcedimientos_Click(sender As Object, e As EventArgs) Handles btnAgregarProcedimientos.Click

        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()

        'llenamos COMBO Diagnosticos
        Dim _dcups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dcups.ListarCombo()
        cboProcedimientos.Properties.DataSource = _dsCups.Tables(0)
        cboProcedimientos.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboProcedimientos.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

    End Sub

    Private Sub cmdAgregarProcedimiento_Click(sender As Object, e As EventArgs) Handles cmdAgregarProcedimiento.Click

        If txtNumeroHistoria.Text <> "" Then
            If cboProcedimientos.Text = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Procedimientos e Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtDescripcionProcedimientos.Text = "" Then
                '   MessageBox.Show("Falta descripcion del Procedimiento o Imagen", "Procedimientos e Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaProcedimientos.Existe(cboProcedimientos.EditValue, lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Item ya fue agregado", "Procedimientos e Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarProcedimientos()
                _ds = New DataSet()
                _ds = _DHistoriaProcedimientos.Listar(lblConsecutivoOrden.Text)
                GCProcedimientos.DataSource = _ds.Tables(0)

                'Limpiamos campos
                cboProcedimientos.Text = ""
                'txtDescripcionProcedimientos.Text = ""
            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar Otros Estudios", "Examenes y Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEliminarProcedimiento_Click(sender As Object, e As EventArgs) Handles cmdEliminarProcedimiento.Click

        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaProcedimientos = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Procedimientos e Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaProcedimientos.Eliminar(_ClickGrillaProcedimientos, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaProcedimientos.Listar(lblConsecutivoOrden.Text)
                GCProcedimientos.DataSource = _ds.Tables(0)

                _ClickGrillaProcedimientos = ""
            End If
        End If
    End Sub

    Private Sub cmdAgregarEstudiosDiagnosticos_Click(sender As Object, e As EventArgs) Handles cmdAgregarEstudiosDiagnosticos.Click
        If txtNumeroHistoria.Text <> "" Then
            If cboEstudiosDiagnosticos.Text = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Estudios diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf _DHistoriaestudiosdiagnosticos.Existe(cboestudiosdiagnosticos.EditValue, lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Item ya fue agregado", "Estudios diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarEstudiosDiagnosticos()
                _ds = New DataSet()
                _ds = _DHistoriaEstudiosDiagnosticos.Listar(lblConsecutivoOrden.Text)
                GCEstudiosDiagnosticos.DataSource = _ds.Tables(0)

                'Limpiamos campos
                cboEstudiosDiagnosticos.Text = ""

            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar el estudio", "Estudios diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEliminarEstudiosDiagnosticos_Click(sender As Object, e As EventArgs) Handles cmdEliminarEstudiosDiagnosticos.Click
        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaEstudiosDiagnosticos = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Estudios diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaEstudiosDiagnosticos.Eliminar(_ClickGrillaEstudiosDiagnosticos, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaEstudiosDiagnosticos.Listar(lblConsecutivoOrden.Text)
                GCEstudiosDiagnosticos.DataSource = _ds.Tables(0)

                _ClickGrillaEstudiosDiagnosticos = ""
            End If
        End If
    End Sub

    Private Sub GVEstudiosDiagnosticos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVEstudiosDiagnosticos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaEstudiosDiagnosticos = GVEstudiosDiagnosticos.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub cmdAgregarMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdAgregarMedicamentos.Click
        If txtNumeroHistoria.Text <> "" Then
            If cboMedicamentos.Text = "" Then
                MessageBox.Show("Debe seleccionar un Medicamento", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtDosis.Text = "" Then
                MessageBox.Show("Falta colocar la dosis", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboViaAdministracion.Text = "" Then
                MessageBox.Show("Debe seleccionar la via de administracion", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtCantidad.Text = "" Then
                MessageBox.Show("Falta colocar la cantidad", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtDescripcionMedicamento.Text = "" Then
                MessageBox.Show("Falta Descripcion", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaMedicamentos.Existe(cboMedicamentos.GetColumnValue("ID"), lblConsecutivoOrden.Text) = True Then
                MessageBox.Show("Este Medicamento ya fue agregado", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarMedicamentos()
                _ds = New DataSet()
                _ds = _DHistoriaMedicamentos.Listar(lblConsecutivoOrden.Text)
                GCMedicamentos.DataSource = _ds.Tables(0)

                'Limpiamos campos
                txtDosis.Text = ""
                txtCantidad.Text = ""
                txtDescripcionMedicamento.Text = ""

            End If
        Else
            MessageBox.Show("Debe Guardar la historia para agregar el medicamento", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEliminarMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdEliminarMedicamentos.Click
        If lblConsecutivoOrden.Text <> "" Then
            If _ClickGrillaMedicamentos = "" Then
                MessageBox.Show("Debe seleccionar un Item", "Formulacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DHistoriaMedicamentos.Eliminar(_ClickGrillaMedicamentos, lblConsecutivoOrden.Text)
                _ds = New DataSet()
                _ds = _DHistoriaMedicamentos.Listar(lblConsecutivoOrden.Text)
                GCMedicamentos.DataSource = _ds.Tables(0)
                _ClickGrillaMedicamentos = ""
            End If

        End If
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmMedicamentos
        _frmOpen.ShowDialog()

        'llenamos COMBO Diagnosticos
        Dim _dMedicamentos As New DMedicamentos
        _dsMedicamentos = New DataSet()
        _dsMedicamentos = _dMedicamentos.ListarCombo
        cboMedicamentos.Properties.DataSource = _dsMedicamentos.Tables(0)
        cboMedicamentos.Properties.DisplayMember = _dsMedicamentos.Tables(0).Columns(1).Caption
        cboMedicamentos.Properties.ValueMember = _dsMedicamentos.Tables(0).Columns(0).Caption
    End Sub

    Private Sub GVMedicamentos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVMedicamentos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaMedicamentos = GVMedicamentos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVLaboratorios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVLaboratorios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaLaboratorios = GVLaboratorios.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVProcedimientos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVProcedimientos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaProcedimientos = GVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtFormulacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtFormulacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtLaboratorios_EditValueChanged(sender As Object, e As EventArgs) Handles txtLaboratorios.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtEstudiosDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles txtEstudiosDiagnosticos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtOtrosEstudios_EditValueChanged(sender As Object, e As EventArgs) Handles txtOtrosEstudios.EditValueChanged
        ActivarGuardar()
    End Sub
End Class
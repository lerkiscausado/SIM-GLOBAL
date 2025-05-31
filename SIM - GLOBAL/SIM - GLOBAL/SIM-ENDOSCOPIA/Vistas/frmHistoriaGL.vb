
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Utilidades
Imports SIM_ENDOSCOPIA.Modelo
Imports SIM_ENDOSCOPIA.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Modelo
Imports DevExpress.XtraCharts
Public Class frmHistoriaGL
#Region "DECLARACION DE VARIABLES"

    'Variables de CArga de PROCESOS
    Dim _dsActualizarGrilla As DataSet
    Dim _dsHistoriasAnteriores As DataSet
    Dim _dsAntecedentes As DataSet
    Dim _dsAntecedentesOrden As DataSet

    Dim _dsRevisionSistemas As DataSet
    Dim _dsViaAdministracion As DataSet
    Dim _dsCups As DataSet
    Dim _dsMedicamentos As DataSet
    Dim _dsDiagnosticos As DataSet
    Dim _dsDatosUsuario As DataSet
    Dim _dsLaboratorios As DataSet
    Dim _dsProcedimientos As DataSet
    '------------------------------------

    Dim EstadoHistoria As Boolean = False
    Dim _ds As DataSet
    Dim _dordenes As New DOrdenes
    Dim _Ordenes As New Ordenes
    Dim _Usuarios As New Usuarios
    Dim _dUduarios As New DUsuarios
    Dim _DhistoriaClinica = New DHistoriaClinica
    Dim _HistoriaClinica As New HistoriaClinica
    Dim _Antecedentes As New Antecedentes
    Dim _DAntecedentes As New DAntecedentes

    Dim _ClickGrilla As String
    Dim _ClickGrillaHistoriasAnteriores As String
    Dim _ClickGrillaRevisionxSistemas As String
    Dim _ClickGrillaLaboratorios As String
    Dim _ClickGrillaProcedimientos As String
    Dim _ClickGrillaMedicamentos As String
    Dim _ClickGrillaDiagnosticos As String
    Dim _ClickTipoEstudio As String
    Dim _ClickIdDetalleOrden As String

    'Dim _Empleados As Empleados
    Dim _dEmpleados = New DEmpleados
    Dim _DHistoriaRXS As New DHistoriaRXS
    Dim _HistoriaRXS As New HistoriaRXS

    Dim _HistoriaLaboratorios As New HistoriaLaboratorios
    Dim _DHistoriaLaboratorios As New DHistoriaLaboratorios

    Dim _HistoriaProcedimientos As New HistoriaProcedimientos
    Dim _DHistoriaProcedimientos As New DHistoriaProcedimientos

    Dim _HistoriaMedicamentos As New HistoriaMedicamentos
    Dim _DHistoriaMedicamentos As New DHistoriaMedicamentos

    Dim _HistoriaDiagnosticos As New HistoriaDiagnosticos
    Dim _DHistoriaDiagnosticos As New DHistoriaDiagnosticos

    Dim _Fila As Integer
    Dim _IDUsuario As String
    Dim _HistoriaDia As Boolean

    ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    ReadOnly _dDiagnostico = New DDiagnostico

#End Region
#Region "IMPRESION"
    Private Sub CargarReporte(ByVal reporte As String, ByVal usuario As String, ByVal especialidad As String)
        Try

            Dim report = New ReportDocument
            report.Load(Application.StartupPath + "\Reportes\" + reporte)

            If Not (String.IsNullOrEmpty(usuario)) Then
                Dim crUsuario As New ParameterDiscreteValue
                Dim crEspecialidad As New ParameterDiscreteValue

                crUsuario.Value = usuario
                crEspecialidad.Value = especialidad

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions = report.DataDefinition.ParameterFields()
                Dim crParameterUsuario As ParameterFieldDefinition = crParameterFieldDefinitions.Item("usuario")
                Dim crParameterEspecialidad As ParameterFieldDefinition = crParameterFieldDefinitions.Item("especialidad")
                'crParameterFieldDefinition = crParameterFieldDefinitions.Item("especialidad")

                Dim crParameterValuesUsuario As ParameterValues = crParameterUsuario.CurrentValues
                Dim crParameterValuesEspecialidad As ParameterValues = crParameterEspecialidad.CurrentValues

                crParameterValuesUsuario.Clear()
                crParameterValuesUsuario.Add(crUsuario)

                crParameterValuesEspecialidad.Clear()
                crParameterValuesEspecialidad.Add(crEspecialidad)

                'crParameterDiscreteValueUsuario.Value = "3"
                crParameterValuesUsuario.Add(crUsuario)
                crParameterValuesEspecialidad.Add(crEspecialidad)
                'crParameterValues.Add(crParameterDiscreteValueEspecialidad)
                crParameterUsuario.ApplyCurrentValues(crParameterValuesUsuario)
                crParameterEspecialidad.ApplyCurrentValues(crParameterValuesEspecialidad)

            End If

            'crv.ReportSource = report
            'crv.Refresh()
            'ShowDialog()
            'crv.PrintReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ImprimirReporte(ByVal reporte As String, ByVal data As String)
        Try

            Dim report = New ReportDocument
            report.Load(Application.StartupPath + "\Reportes\" + reporte)

            If Not (String.IsNullOrEmpty(data)) Then
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = data
                Dim crParameterFieldDefinitions As ParameterFieldDefinitions = report.DataDefinition.ParameterFields()
                Dim crParameterFieldDefinition As ParameterFieldDefinition = crParameterFieldDefinitions.Item("filtro")
                Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            End If

            'crv.ReportSource = report
            'crv.Refresh()
            'ShowDialog()
            'crv.PrintReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region


#Region "PROCEDIMIENTOS"

    Private Sub LimpiarCampos()
        'limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtNumeroHistoria.Text = ""
        txtDatosUsuario.Text = ""
        txtAntecedentesFamiliares2.Text = ""
        txtAntecedentesPersonales2.Text = ""
        txtMotivoConsulta.Text = ""
        txtResponsables.Text = ""
        txtEnfermedadActual.Text = ""
        txtAntecedentesFamiliares.Text = ""
        txtAntecedentesPersonales.Text = ""
        
        txtIMC.Text = ""
        txtValorIMC.Text = ""
        txtPeso.Text = 0
        txtTalla.Text = 0
        txtTA.Text = ""
        txtFC.Text = ""
        txtFR.Text = ""
        txtTemperatura.Text = ""

        cboA.SelectedIndex = 0
        cboB.SelectedIndex = 0
        cboP.SelectedIndex = 0
        cboVT.SelectedIndex = 0

        txtLP.Text = ""
        'txtDiagnostico.Text = ""
        txtPlanSeguir.Text = ""
        txtRecomendaciones.Text = ""

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
        txtDescripcionLaboratorios.Text = ""
        cboLaboratorios.Text = ""

        'Limpiamos grilla de Procedimientos
        GCProcedimientos.DataSource = Nothing
        txtDescripcionProcedimientos.Text = ""
        cboProcedimientos.Text = ""

        'Limpiamos grilla de Diagnosticos
        GCDiagnosticos.DataSource = Nothing
        txtDescripcionDiagnostico.Text = ""

        'llenamos GRID CONTROL PACIENTES POR ATENDER
        'ActualizarGrilla()

        bbiGuardar.Enabled = False
    End Sub
    Private Sub DatosHistoria(ByVal Filtro As Integer)
        Try
            'If _DhistoriaIntegra.ExisteOrden(Filtro) = True Then
            '_historiaIntegra = _DhistoriaIntegra.CargarOrden(Filtro)
            'lblConsecutivo.Text = _historiaIntegra.Id
            'txtNumeroHistoria.Text = _historiaIntegra.CodigoHistoria
            'LLenamos campos Antecedentes Patologicos
            'End If
        Catch ex As Exception
            'MessageBox()
        End Try

    End Sub

    Private Sub DatosPaciente(ByVal Filtro As Integer)
        Try
            txtDatosUsuario.Text = Funciones.DatosUsuario("10", "HISTORIA")
        Catch ex As Exception
            'MessageBox()
        End Try

    End Sub
    Private Sub GuardarHistoria()
        '_HistoriaClinica.Id = Val(lblConsecutivo.Text)
        'Asignamos el Numero de la Historia
        txtNumeroHistoria.Text = Funciones.CodigoUsuario(lblConsecutivoOrden.Text) & Mid(dtFechaIngreso.Text, 7, 4) & Mid(dtFechaIngreso.Text, 4, 2) & Mid(dtFechaIngreso.Text, 1, 2)
        'MsgBox(lblConsecutivoOrden.Text)
        _HistoriaClinica.Id = Val("")
        _HistoriaClinica.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaClinica.FechaHistoria = dtFechaIngreso.Text
        _HistoriaClinica.CodigoHistoria = txtNumeroHistoria.Text
        _HistoriaClinica.Responsables = txtResponsables.Text
        _HistoriaClinica.MotivoConsulta = txtMotivoConsulta.Text
        _HistoriaClinica.EnfermedadActual = txtEnfermedadActual.Text

        _HistoriaClinica.Peso = txtPeso.Text
        _HistoriaClinica.Talla = txtTalla.Text

        _HistoriaClinica.TensionArterial = Val(txtTA.Text)
        _HistoriaClinica.FrecuenciaCardiaca = Val(txtFC.Text)
        _HistoriaClinica.FrecuenciaRespiratoria = Val(txtFR.Text)
        _HistoriaClinica.PlanSeguir = txtPlanSeguir.Text
        '_HistoriaClinica.Recomendaciones = txtRecomendaciones.Text
        _HistoriaClinica.TannerA = cboA.Text
        _HistoriaClinica.TannerB = cboB.Text
        _HistoriaClinica.TannerP = cboP.Text
        _HistoriaClinica.TannerVT = cboVT.Text
        _HistoriaClinica.TannerLP = txtLP.Text
        _HistoriaClinica.Estado = "A"
        _HistoriaClinica.Temperatura = Val(txtTemperatura.Text)
        _HistoriaClinica.IdEspecialista = Val("1")

        '*********** CAMPOS ANTECEDENTES  *********************************************
        _Antecedentes.IdOrden = Val(lblConsecutivoOrden.Text)
        _Antecedentes.IdUsuario = Val(lblConsecutivo.Text)
        _Antecedentes.AntecedentesFamiliares = txtAntecedentesFamiliares.Text
        _Antecedentes.AntecedentesPersonales = txtAntecedentesPersonales.Text




        bwGuardar.RunWorkerAsync()
        ppCargar.Visible = True


        '_DhistoriaClinica.Guardar(_HistoriaClinica)
        '***************** Actualizamos el estado de la Orden a Atendido *****************
        ' _dordenes.ActualizarEstado(Val(lblConsecutivoOrden.Text))
        '******************** Graficamos ***********************
        'GraficaPaciente(lblConsecutivoOrden.Text)

    End Sub

    Private Sub GuardarRevisionSistemas()
        _HistoriaRXS.IdRXS = cboRevisionSistema.GetColumnValue("ID")
        _HistoriaRXS.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaRXS.Descripcion = txtDescripcionRevisionSistemas.Text
        _DHistoriaRXS.Guardar(_HistoriaRXS)

    End Sub
    Private Sub GuardarDiagnostico()
        _HistoriaDiagnosticos.IdDiagnostico = cboDiagnosticos.EditValue
        _HistoriaDiagnosticos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaDiagnosticos.Descripcion = txtDescripcionDiagnostico.Text
        _DHistoriaDiagnosticos.Guardar(_HistoriaDiagnosticos)
    End Sub
    Private Sub GuardarLaboratorios()
        _HistoriaLaboratorios.IdLaboratorio = cboLaboratorios.EditValue
        _HistoriaLaboratorios.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaLaboratorios.Descripcion = txtDescripcionLaboratorios.Text
        _DHistoriaLaboratorios.Guardar(_HistoriaLaboratorios)
    End Sub
    Private Sub GuardarProcedimientos()
        _HistoriaProcedimientos.IdProcedimiento = cboProcedimientos.EditValue
        _HistoriaProcedimientos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaProcedimientos.Descripcion = txtDescripcionProcedimientos.Text
        _DHistoriaProcedimientos.Guardar(_HistoriaProcedimientos)
    End Sub
    Private Sub GuardarMedicamentos()
        _HistoriaMedicamentos.IdMedicamento = cboMedicamentos.GetColumnValue("ID")
        _HistoriaMedicamentos.IdOrden = Val(lblConsecutivoOrden.Text)
        _HistoriaMedicamentos.IdViaAdministracion = cboViaAdministracion.GetColumnValue("ID")
        _HistoriaMedicamentos.Dosis = txtDosis.Text
        _HistoriaMedicamentos.Cantidad = txtCantidad.Text
        _HistoriaMedicamentos.Descripcion = txtDescripcionMedicamento.Text
        _DHistoriaMedicamentos.Guardar(_HistoriaMedicamentos)
    End Sub
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
    Private Sub NuevaHistoria()
        lblConsecutivoOrden.Text = _ClickGrilla
        ' lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")

        '********** Obtenemos el ID del usuario ******************
        _Ordenes = _dordenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario

        Select Case _ClickTipoEstudio
            Case "CONSULTA PRIMERA VEZ"
                'acMotivoConsulta.Visible = True
                'acEnfermedadActual.Visible = True
                'acAntecedentes.Visible = True
                'acExamenFisico.Visible = True
                'acDiagnostico.Visible = True
                'acAnalisisyPlanSeguir.Visible = True
                'acEvolucion.Visible = False
            Case Else
                'acMotivoConsulta.Visible = False
                'acEnfermedadActual.Visible = False
                'acAntecedentes.Visible = False
                'acExamenFisico.Visible = False
                'acDiagnostico.Visible = False
                'acAnalisisyPlanSeguir.Visible = False
                'acEvolucion.Visible = True
        End Select

        '****** Traer Historias Anteriores **********
        _ds = New DataSet()
        _ds = _dordenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)

        Dim _dsAntecedentes As New DataSet
        Dim _dsAntecedentesOrden As New DataSet
        Dim _DAntecedentes As New DAntecedentes

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

            _HistoriaClinica = _DhistoriaClinica.cargar(lblConsecutivoOrden.Text)
            txtNumeroHistoria.Text = _HistoriaClinica.CodigoHistoria
            txtMotivoConsulta.Text = _HistoriaClinica.MotivoConsulta
            txtEnfermedadActual.Text = _HistoriaClinica.EnfermedadActual
            'txtDiagnostico.Text = _HistoriaClinica.Diagnostico
            'If acEvolucion.Visible = False Then
            txtPlanSeguir.Text = _HistoriaClinica.PlanSeguir
            ' Else
            ' txtEvolucion.Text = _HistoriaClinica.PlanSeguir
            'End If
            'txtExamenFisico.Text = _HistoriaClinica.ExamenFisico
        End If
        bbiGuardar.Enabled = False

    End Sub
#End Region

    Private Sub GVPacientesAtender_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub



    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Guardar Historia", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaIngreso.Text = "" Then
            MessageBox.Show("Campo Fecha de Historia es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtMotivoConsulta.Text = "" Then
            MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvHistoriasAnteriores.RowCount = 0 And txtAntecedentesFamiliares.Text = "" Then
            MessageBox.Show("Campo Antecedentes Familiares es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvHistoriasAnteriores.RowCount = 0 And txtAntecedentesPersonales.Text = "" Then
            MessageBox.Show("Campo Antecedentes Personales es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            GuardarHistoria()

        End If
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

    Private Sub btActualizar_Click(sender As Object, e As EventArgs)
        'llenamos la grilla de registros
        If dtFechaIngreso.Text <> "" Then
            If MessageBox.Show("¿Desea Abrir Historias de Fecha Seleccionada?", "Historias Clinicas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                _ds = New DataSet
                '       _ds = _dordenes.PacientesAtender()
                GCPacientesAtender.DataSource = _ds.Tables(0)
                GVPacientesAtender.Columns(0).BestFit()
                GVPacientesAtender.Columns(1).BestFit()
                GVPacientesAtender.Columns(2).BestFit()
                LimpiarCampos()
            End If
        End If
    End Sub



    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub gvHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaHistoriasAnteriores = gvHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btVistaPrevia_Click(sender As Object, e As EventArgs) Handles btVistaPrevia.Click
        If _ClickGrillaHistoriasAnteriores <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("vista_previa.rpt", _ClickGrillaHistoriasAnteriores)
        Else
            MessageBox.Show("Debe Seleccionar una Orden Historias Anteriores", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub ActualizarGrillaPacientesAtender()
        'llenamos grilla de pacientes por atender
        Dim _ds = New DataSet()
        _ds = _dordenes.PacientesHistoriaEndoscopia(IdEmpleadoG)
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub

    Private Sub frmHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos grilla de pacientes por atender
        ActualizarGrillaPacientesAtender()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        bbiGuardar.Enabled = False
    End Sub

    Private Sub txtMotivoConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.EditValueChanged

        bbiGuardar.Enabled = True
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
                txtDescripcionLaboratorios.Text = ""
                cboLaboratorios.Text = ""

            End If
        End If
    End Sub

    Private Sub GVLaboratorios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVLaboratorios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaLaboratorios = GVLaboratorios.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _Fila = e.RowHandle.ToString
        End If

    End Sub

    Private Sub cmdEliminarLaboratorio_Click(sender As Object, e As EventArgs) Handles cmdEliminarLaboratorio.Click
        If txtNumeroHistoria.Text <> "" Then
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
                txtDescripcionProcedimientos.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdEliminarProcedimiento_Click(sender As Object, e As EventArgs) Handles cmdEliminarProcedimiento.Click
        If txtNumeroHistoria.Text <> "" Then
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

    Private Sub GVProcedimientos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVProcedimientos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaProcedimientos = GVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
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
        End If
    End Sub

    Private Sub cmdEliminarMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdEliminarMedicamentos.Click
        If txtNumeroHistoria.Text <> "" Then
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

    Private Sub GVMedicamentos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVMedicamentos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaMedicamentos = GVMedicamentos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtResponsables_EditValueChanged(sender As Object, e As EventArgs) Handles txtResponsables.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtEnfermedadActual_EditValueChanged(sender As Object, e As EventArgs) Handles txtEnfermedadActual.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtAntecedentesFamiliares_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentesFamiliares.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtAntecedentesPersonales_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentesPersonales.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub



    Private Sub txtTA_EditValueChanged(sender As Object, e As EventArgs) Handles txtTA.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtFC_EditValueChanged(sender As Object, e As EventArgs) Handles txtFC.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtFR_EditValueChanged(sender As Object, e As EventArgs) Handles txtFR.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtTemperatura_EditValueChanged(sender As Object, e As EventArgs) Handles txtTemperatura.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboA_EditValueChanged(sender As Object, e As EventArgs) Handles cboA.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboB_EditValueChanged(sender As Object, e As EventArgs) Handles cboB.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboP_EditValueChanged(sender As Object, e As EventArgs) Handles cboP.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboVT_EditValueChanged(sender As Object, e As EventArgs) Handles cboVT.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtLP_EditValueChanged(sender As Object, e As EventArgs) Handles txtLP.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs)
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtPlanSeguir_EditValueChanged(sender As Object, e As EventArgs) Handles txtPlanSeguir.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtRecomendaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtRecomendaciones.EditValueChanged
        bbiGuardar.Enabled = True
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
        End If
    End Sub

    Private Sub cmdEliminarRevisionSistemas_Click(sender As Object, e As EventArgs) Handles cmdEliminarRevisionSistemas.Click
        If txtNumeroHistoria.Text <> "" Then
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

    Private Sub GVDiagnosticos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDiagnosticos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDiagnosticos = GVDiagnosticos.GetRowCellValue(e.RowHandle.ToString, "CODIGO").ToString()
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
                MessageBox.Show("Este Item ya fue agregado", "Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarDiagnostico()
                _ds = New DataSet()
                _ds = _DHistoriaDiagnosticos.Listar(lblConsecutivoOrden.Text)
                GCDiagnosticos.DataSource = _ds.Tables(0)

                'Limpiamos campos
                txtDescripcionDiagnostico.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdEliminarDiagnostico_Click(sender As Object, e As EventArgs) Handles cmdEliminarDiagnostico.Click
        If txtNumeroHistoria.Text <> "" Then
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

    Private Sub cmdImprimirMedicamentos_Click(sender As Object, e As EventArgs) Handles cmdImprimirMedicamentos.Click
        If lblConsecutivoOrden.Text <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("medicamentos.rpt", lblConsecutivoOrden.Text)
        End If
    End Sub

    Private Sub cmdImprimirLaboratorio_Click(sender As Object, e As EventArgs) Handles cmdImprimirLaboratorio.Click
        If lblConsecutivoOrden.Text <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("examenes_laboratorios.rpt", lblConsecutivoOrden.Text)
        End If
    End Sub

    Private Sub cmdImprimirProcedimiento_Click(sender As Object, e As EventArgs) Handles cmdImprimirProcedimiento.Click
        If lblConsecutivoOrden.Text <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("procedimientos.rpt", lblConsecutivoOrden.Text)
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

    Private Sub btnAgregarLaboratorios_Click(sender As Object, e As EventArgs) Handles btnAgregarLaboratorios.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()

        'llenamos COMBO Diagnosticos
        Dim _dcups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dcups.ListarCombo()
        cboLaboratorios.Properties.DataSource = _dsCups.Tables(0)
        cboLaboratorios.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
        cboLaboratorios.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

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

    Private Sub txtPeso_Leave(sender As Object, e As EventArgs) Handles txtPeso.Leave
        If txtPeso.Text <> "" And txtTalla.Text <> "" Then
            txtIMC.Text = IMC(txtPeso.Text, txtTalla.Text)
        End If
    End Sub


    Private Sub txtPeso_EditValueChanged(sender As Object, e As EventArgs) Handles txtPeso.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtTalla_Leave(sender As Object, e As EventArgs) Handles txtTalla.Leave
        If txtPeso.Text <> "" And txtTalla.Text <> "" Then
            txtIMC.Text = IMC(txtPeso.Text, txtTalla.Text)
        End If
    End Sub

    Private Sub bwLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoad.DoWork
        ' 1. LOAD - ACTUALIZAR GRILLA
        _dsActualizarGrilla = New DataSet()
        _dsActualizarGrilla = _dordenes.ListarPacientesMartinez



#Region "1. LOAD - LLENADO DE COMBOS"
        'llenamos campo Revision Sistemas y examen fisico
        Dim _dRevisionSistema As New DRevisionSistemas
        _dsRevisionSistemas = New DataSet()
        _dsRevisionSistemas = _dRevisionSistema.ListarCombo()

        'llenamos COMBO Via de Administracion 
        Dim _dViaAdministracion As New DViaAdministracion
        _dsViaAdministracion = New DataSet()
        _dsViaAdministracion = _dViaAdministracion.ListarCombo()

        'llenamos COMBO Laboratorios
        Dim _dCups As New DCups
        _dsCups = New DataSet()
        _dsCups = _dCups.ListarCombo()

        'llenamos COMBO medicamentos
        Dim _dMedicamentos As New DMedicamentos
        _dsMedicamentos = New DataSet()
        _dsMedicamentos = _dMedicamentos.ListarCombo()

        'llenamos COMBO Diagnosticos
        Dim _dDiagnosticos As New DDiagnostico
        _dsDiagnosticos = New DataSet()
        _dsDiagnosticos = _dDiagnosticos.ListarCombo()
#End Region

    End Sub

    Private Sub bwLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoad.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            '1. LOAD - ACTUALIZAR GRILLA
            GCPacientesAtender.DataSource = _dsActualizarGrilla.Tables(0)
            _dsActualizarGrilla = Nothing
            bbiGuardar.Enabled = False
            ppCargar.Visible = False

            '1. LOAD - LLENADO DE COMBOS

            'llenamos campo Revision Sistemas y examen fisico
            cboRevisionSistema.Properties.DataSource = _dsRevisionSistemas.Tables(0)
            cboRevisionSistema.Properties.DisplayMember = _dsRevisionSistemas.Tables(0).Columns(1).Caption
            cboRevisionSistema.Properties.ValueMember = _dsRevisionSistemas.Tables(0).Columns(0).Caption
            cboRevisionSistema.ItemIndex = -1

            'llenamos COMBO Via de Administracion 
            cboViaAdministracion.Properties.DataSource = _dsViaAdministracion.Tables(0)
            cboViaAdministracion.Properties.DisplayMember = _dsViaAdministracion.Tables(0).Columns(1).Caption
            cboViaAdministracion.Properties.ValueMember = _dsViaAdministracion.Tables(0).Columns(0).Caption
            cboViaAdministracion.ItemIndex = -1

            'llenamos COMBO Laboratorios
            cboLaboratorios.Properties.DataSource = _dsCups.Tables(0)
            cboLaboratorios.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
            cboLaboratorios.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

            'llenamos COMBO Procedimientos
            cboProcedimientos.Properties.DataSource = _dsCups.Tables(0)
            cboProcedimientos.Properties.DisplayMember = _dsCups.Tables(0).Columns(1).Caption
            cboProcedimientos.Properties.ValueMember = _dsCups.Tables(0).Columns(0).Caption

            'llenamos COMBO medicamentos
            cboMedicamentos.Properties.DataSource = _dsMedicamentos.Tables(0)
            cboMedicamentos.Properties.DisplayMember = _dsMedicamentos.Tables(0).Columns(1).Caption
            cboMedicamentos.Properties.ValueMember = _dsMedicamentos.Tables(0).Columns(0).Caption
            cboMedicamentos.ItemIndex = -1

            'llenamos COMBO Diagnosticos
            cboDiagnosticos.Properties.DataSource = _dsDiagnosticos.Tables(0)
            cboDiagnosticos.Properties.DisplayMember = _dsDiagnosticos.Tables(0).Columns(1).Caption
            cboDiagnosticos.Properties.ValueMember = _dsDiagnosticos.Tables(0).Columns(0).Caption

            'Seleccionamos el primer Item de cada Tanner
            cboA.SelectedIndex = 0
            cboB.SelectedIndex = 0
            cboP.SelectedIndex = 0
            cboVT.SelectedIndex = 0

            'boton guardar desactivado
            dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
            bbiGuardar.Enabled = False
            ppCargar.Visible = False

            cboProcedimientos.Text = ""
            cboLaboratorios.Text = ""
            ' MsgBox("PROCESO LOAD FINALIZADO ")
        End If
    End Sub

    Private Sub bwGuardar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwGuardar.DoWork
        '***************** PROCESO DE GUARDAR HISTORIA **********************************
        _DhistoriaClinica.Guardar(_HistoriaClinica)
        '***************** Actualizamos el estado de la Orden a Atendido *****************
        _dordenes.ActualizarEstado(Val(lblConsecutivoOrden.Text), "ATENDIDO")
        '************* GUARDAMOS ANTECEDENTES *********************************************
        _DAntecedentes.Guardar(_Antecedentes)
        ' 1. LOAD - ACTUALIZAR GRILLA
        _dsActualizarGrilla = New DataSet()
        _dsActualizarGrilla = _dordenes.ListarPacientesMartinez
    End Sub

    Private Sub bwGuardar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwGuardar.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            GCPacientesAtender.DataSource = _dsActualizarGrilla.Tables(0)
            _dsActualizarGrilla = Nothing
            bbiGuardar.Enabled = False
            ppCargar.Visible = False
        End If
    End Sub
#Region "PROCESO NUEVA HISTORIA"
    Private Sub bwNuevo_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwNuevo.DoWork
        'PROCESO NUEVA HISTORIA
        '**********  PROCESO DATOS USUARIO ***********************
        _dsDatosUsuario = New DataSet
        _dsDatosUsuario = Funciones.DatosUsuarioDS(lblConsecutivoOrden.Text)
        '****** Traer Historias Anteriores **********
        _dsHistoriasAnteriores = New DataSet()
        _dsHistoriasAnteriores = _DhistoriaClinica.listarhistoriasanteriores(_dsDatosUsuario.Tables(0).Rows(0)(0).ToString) '_Ordenes.IdUsuario)
        '***************************************

        '************** Traemos Antecedentes del Paciente *****************
        If _dsHistoriasAnteriores.Tables.Count <> 0 Then
            'If gvHistoriasAnteriores.RowCount <> 0 Then
            _dsAntecedentes = New DataSet()
            _dsAntecedentes = _DAntecedentes.ListarAntecedentes(_dsDatosUsuario.Tables(0).Rows(0)(0).ToString)
        End If
        '************ TRAEMOS HISTORIA DEL DIA   **************************
        _HistoriaDia = _DhistoriaClinica.Existe(lblConsecutivoOrden.Text)
        If _HistoriaDia = True Then
            _HistoriaClinica = _DhistoriaClinica.cargar(lblConsecutivoOrden.Text)
            ' traemos antecedentes del dia
            _dsAntecedentesOrden = New DataSet()
            _dsAntecedentesOrden = _DAntecedentes.CargarOrden(lblConsecutivoOrden.Text)

            ' Traemos Revision por sistemas de la historia clinica actual
            _dsRevisionSistemas = New DataSet()
            _dsRevisionSistemas = _DHistoriaRXS.Listar(lblConsecutivoOrden.Text)

            ' Traemos Medicamentos de la historia clinica actual
            _dsMedicamentos = New DataSet()
            _dsMedicamentos = _DHistoriaMedicamentos.Listar(lblConsecutivoOrden.Text)

            ' Traemos laboratorios de la historia clinica actual
            _dsLaboratorios = New DataSet()
            _dsLaboratorios = _DHistoriaLaboratorios.Listar(lblConsecutivoOrden.Text)

            ' Traemos procedimientos de la historia clinica actual
            _dsProcedimientos = New DataSet()
            _dsProcedimientos = _DHistoriaProcedimientos.Listar(lblConsecutivoOrden.Text)

            ' Traemos DIAGNOSTICOS de la historia clinica actual
            _dsDiagnosticos = New DataSet()
            _dsDiagnosticos = _DHistoriaDiagnosticos.Listar(lblConsecutivoOrden.Text)

        End If
        '******************************************************************
        ' 1. LOAD - ACTUALIZAR GRILLA
        _dsActualizarGrilla = New DataSet()
        _dsActualizarGrilla = _dordenes.ListarPacientesMartinez

    End Sub

    Private Sub bwNuevo_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwNuevo.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            '*************     DATOS USUARIOS   ******************
            txtDatosUsuario.Text = "ID: " & _dsDatosUsuario.Tables(0).Rows(0)(0).ToString & "     IDENTIFICACION: " & _dsDatosUsuario.Tables(0).Rows(0)(1).ToString & vbCrLf _
                            & "PACIENTE: " & _dsDatosUsuario.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "SEXO: " & _dsDatosUsuario.Tables(0).Rows(0)(3).ToString & " EDAD:" & Funciones.CalcularEdad(_dsDatosUsuario.Tables(0).Rows(0)(4).ToString) & "  TELEFONO: " & _dsDatosUsuario.Tables(0).Rows(0)(5).ToString & vbCrLf _
                            & "DIRECCION: " & _dsDatosUsuario.Tables(0).Rows(0)(6).ToString & vbCrLf _
                            & "CORREO ELECTRONICO: " & _dsDatosUsuario.Tables(0).Rows(0)(7).ToString
            '********** Obtenemos el ID del usuario ***************
            lblConsecutivo.Text = _dsDatosUsuario.Tables(0).Rows(0)(0).ToString '_Ordenes.IdUsuario

            '************* Obtenemos el SEXO del Usuario *************
            'CCPercentilTalla.Series.Clear()
            'CCPercentilPeso.Series.Clear()
            '*******_Usuarios = DUsuarios.Cargar(lblConsecutivo.Text)
            'Percentil(_dsDatosUsuario.Tables(0).Rows(0)(3).ToString) '_Usuarios.Sexo)
            '**********     HISTORIAS ANTERIORES  ********************
            GCHistoriasAnteriores.DataSource = _dsHistoriasAnteriores.Tables(0)
            '**********     ANTECEDENTES      ************************
            If gvHistoriasAnteriores.RowCount <> 0 Then
                'xtpAntecedentes.PageVisible = True
                txtAntecedentesFamiliares2.Text = _dsAntecedentes.Tables(0).Rows(0)(0).ToString()
                txtAntecedentesPersonales2.Text = _dsAntecedentes.Tables(0).Rows(0)(1).ToString()
            Else
                xtpAntecedentes.PageVisible = True
            End If
            '***********    HISTORIA DEL DIA    *******************
            If _HistoriaDia = True Then
                txtNumeroHistoria.Text = _HistoriaClinica.CodigoHistoria
                txtMotivoConsulta.Text = _HistoriaClinica.MotivoConsulta
                txtResponsables.Text = _HistoriaClinica.Responsables
                txtEnfermedadActual.Text = _HistoriaClinica.EnfermedadActual

                txtPeso.Text = _HistoriaClinica.Peso
                txtTalla.Text = _HistoriaClinica.Talla
                txtIMC.Text = IMC(_HistoriaClinica.Peso, _HistoriaClinica.Talla)
                txtTA.Text = _HistoriaClinica.TensionArterial
                txtFC.Text = _HistoriaClinica.FrecuenciaCardiaca
                txtFR.Text = _HistoriaClinica.FrecuenciaRespiratoria
                txtTemperatura.Text = _HistoriaClinica.Temperatura
                cboA.Text = _HistoriaClinica.TannerA
                cboB.Text = _HistoriaClinica.TannerB
                cboP.Text = _HistoriaClinica.TannerP
                cboVT.Text = _HistoriaClinica.TannerVT
                txtLP.Text = _HistoriaClinica.TannerLP
                txtDescripcionDiagnostico.Text = _HistoriaClinica.Diagnostico
                txtPlanSeguir.Text = _HistoriaClinica.PlanSeguir
                'txtRecomendaciones.Text = _HistoriaClinica.Recomendaciones

                'traemos antecedentes del DIA por ORDEN
                txtAntecedentesFamiliares.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(0).ToString
                txtAntecedentesPersonales.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(1).ToString

                ' Traemos Revision por sistemas de la historia clinica actual
                GCRevisionSistema.DataSource = _dsRevisionSistemas.Tables(0)

                ' Traemos Medicamentos de la historia clinica actual
                GCMedicamentos.DataSource = _dsMedicamentos.Tables(0)

                ' Traemos laboratorios de la historia clinica actual
                GCLaboratorios.DataSource = _dsLaboratorios.Tables(0)

                ' Traemos procedimientos de la historia clinica actual
                GCProcedimientos.DataSource = _dsProcedimientos.Tables(0)

                ' Traemos DIAGNOSTICOS de la historia clinica actual
                GCDiagnosticos.DataSource = _dsDiagnosticos.Tables(0)
            End If
            GCPacientesAtender.DataSource = _dsActualizarGrilla.Tables(0)
            '*********DESCARGAMOS VARIABLES    *************************************
            _dsDatosUsuario = Nothing
            _dsHistoriasAnteriores = Nothing
            _dsRevisionSistemas = Nothing
            _dsMedicamentos = Nothing
            _dsMedicamentos = Nothing
            _dsLaboratorios = Nothing
            _dsProcedimientos = Nothing
            _dsDiagnosticos = Nothing
            _dsAntecedentesOrden = Nothing
            _dsActualizarGrilla = Nothing
            '***********************************************************************

            bbiGuardar.Enabled = False
            ppCargar.Visible = False
        End If

    End Sub

#End Region
End Class
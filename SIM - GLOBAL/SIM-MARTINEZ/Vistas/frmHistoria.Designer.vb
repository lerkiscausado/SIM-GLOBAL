<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistoria
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(10.5R, New Object() {CType(100.0R, Object)})
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(10.5R, New Object() {CType(100.0R, Object)})
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoria))
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiAbrir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEnero = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFebrero = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMarzo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAbril = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMayo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiJunio = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiJulio = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAgosto = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSeptiembre = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOctubre = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNoviembre = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDiciembre = New DevExpress.XtraBars.BarButtonItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btVistaPrevia = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GCHistoriasAnteriores = New DevExpress.XtraGrid.GridControl()
        Me.gvHistoriasAnteriores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHAOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAMotivoConsulta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GCPacientesAtender = New DevExpress.XtraGrid.GridControl()
        Me.GVPacientesAtender = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPACIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblIdDetalleOrden = New DevExpress.XtraEditors.LabelControl()
        Me.ppCargar = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtAntecedentesFamiliares2 = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtAntecedentesPersonales2 = New DevExpress.XtraEditors.MemoEdit()
        Me.xtcDatosHistoria = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpMotivoConsulta = New DevExpress.XtraTab.XtraTabPage()
        Me.txtResponsables = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMotivoConsulta = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpEnfermedadActual = New DevExpress.XtraTab.XtraTabPage()
        Me.txtEnfermedadActual = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpAntecedentes = New DevExpress.XtraTab.XtraTabPage()
        Me.txtAntecedentesPersonales = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAntecedentesFamiliares = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpExamenFisico = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage14 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.cboEscalaPrader = New DevExpress.XtraEditors.LookUpEdit()
        Me.peImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cboTesticuloDER = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTesticuloIZQ = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMeathusUretral = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMicroPene = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.cboFusionEscrotal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTalla = New DevExpress.XtraEditors.TextEdit()
        Me.txtPeso = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorIMC = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtLP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.cboVT = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.cboP = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.cboB = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.cboA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTemperatura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFR = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIMC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage15 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdEliminarRevisionSistemas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarRevisionSistemas = New DevExpress.XtraEditors.SimpleButton()
        Me.GCRevisionSistema = New DevExpress.XtraGrid.GridControl()
        Me.GVRevisionSistema = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionRevisionSistemas = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRevisionSistema = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpDiagnostico = New DevExpress.XtraTab.XtraTabPage()
        Me.cboDiagnosticos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnActualizarDiagnosticos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEliminarDiagnostico = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarDiagnostico = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDiagnosticos = New DevExpress.XtraGrid.GridControl()
        Me.GVDiagnosticos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDiaCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaDiagnostico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionDiagnostico = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpPlanSeguir = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPlanSeguir = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpRecomendaciones = New DevExpress.XtraTab.XtraTabPage()
        Me.txtRecomendaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpFormulacion = New DevExpress.XtraTab.XtraTabPage()
        Me.btnMedicamentos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimirMedicamentos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.cboViaAdministracion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDosis = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdEliminarMedicamentos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarMedicamentos = New DevExpress.XtraEditors.SimpleButton()
        Me.GCMedicamentos = New DevExpress.XtraGrid.GridControl()
        Me.GVMedicamentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDICAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOSIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionMedicamento = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMedicamentos = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpLaboratorios = New DevExpress.XtraTab.XtraTabPage()
        Me.cboLaboratorios = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.co = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEProcedimientos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAgregarLaboratorios = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimirLaboratorio = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEliminarLaboratorio = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarLaboratorio = New DevExpress.XtraEditors.SimpleButton()
        Me.GCLaboratorios = New DevExpress.XtraGrid.GridControl()
        Me.GVLaboratorios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExaCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExaExamen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExaDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionLaboratorios = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpProcedimientos = New DevExpress.XtraTab.XtraTabPage()
        Me.cboProcedimientos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvProcedimientoCombo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPProcedimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAgregarProcedimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimirProcedimiento = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEliminarProcedimiento = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarProcedimiento = New DevExpress.XtraEditors.SimpleButton()
        Me.GCProcedimientos = New DevExpress.XtraGrid.GridControl()
        Me.GVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProProcedimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionProcedimientos = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpCurvaCrecimiento = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.CCPercentilTalla = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.CCPercentilPeso = New DevExpress.XtraCharts.ChartControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatosUsuario = New DevExpress.XtraEditors.MemoEdit()
        Me.lblConsecutivoOrden = New DevExpress.XtraEditors.LabelControl()
        Me.lblConsecutivo = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroHistoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaIngreso = New DevExpress.XtraEditors.DateEdit()
        Me.bwNuevo = New System.ComponentModel.BackgroundWorker()
        Me.bwLoad = New System.ComponentModel.BackgroundWorker()
        Me.bwGuardar = New System.ComponentModel.BackgroundWorker()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtAntecedentesFamiliares2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtAntecedentesPersonales2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcDatosHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcDatosHistoria.SuspendLayout()
        Me.xtpMotivoConsulta.SuspendLayout()
        CType(Me.txtResponsables.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpEnfermedadActual.SuspendLayout()
        CType(Me.txtEnfermedadActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAntecedentes.SuspendLayout()
        CType(Me.txtAntecedentesPersonales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAntecedentesFamiliares.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpExamenFisico.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage14.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.cboEscalaPrader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cboTesticuloDER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTesticuloIZQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMeathusUretral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMicroPene.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFusionEscrotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTalla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIMC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtLP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemperatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIMC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage15.SuspendLayout()
        CType(Me.GCRevisionSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRevisionSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionRevisionSistemas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRevisionSistema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDiagnostico.SuspendLayout()
        CType(Me.cboDiagnosticos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionDiagnostico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPlanSeguir.SuspendLayout()
        CType(Me.txtPlanSeguir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpRecomendaciones.SuspendLayout()
        CType(Me.txtRecomendaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFormulacion.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboViaAdministracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDosis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionMedicamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedicamentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpLaboratorios.SuspendLayout()
        CType(Me.cboLaboratorios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionLaboratorios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpProcedimientos.SuspendLayout()
        CType(Me.cboProcedimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProcedimientoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionProcedimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCurvaCrecimiento.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.CCPercentilTalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.CCPercentilPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroHistoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiAbrir, Me.bbiGuardar, Me.BarButtonItem4, Me.BarButtonItem5, Me.bbiConsultar, Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.bbiEnero, Me.bbiFebrero, Me.bbiMarzo, Me.bbiAbril, Me.bbiMayo, Me.bbiJunio, Me.bbiJulio, Me.bbiAgosto, Me.bbiSeptiembre, Me.bbiOctubre, Me.bbiNoviembre, Me.bbiDiciembre})
        Me.BarManager1.MaxItemId = 32
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar)})
        Me.Bar2.Text = "Herramientas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nueva Historia"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar Historia"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar Pacientes"
        Me.bbiConsultar.Id = 5
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1244, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 604)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1244, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 573)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1244, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 573)
        '
        'bbiAbrir
        '
        Me.bbiAbrir.Caption = "Abrir Historia"
        Me.bbiAbrir.Id = 1
        Me.bbiAbrir.ImageOptions.Image = CType(resources.GetObject("bbiAbrir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAbrir.Name = "bbiAbrir"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Seleccionar Mes"
        Me.BarSubItem1.Id = 6
        Me.BarSubItem1.ImageOptions.Image = CType(resources.GetObject("BarSubItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarSubItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Enero"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Febrero"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Marzo"
        Me.BarButtonItem3.Id = 9
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Abril"
        Me.BarButtonItem6.Id = 10
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Mayo"
        Me.BarButtonItem7.Id = 11
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Junio"
        Me.BarButtonItem8.Id = 12
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Julio"
        Me.BarButtonItem9.Id = 13
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'bbiEnero
        '
        Me.bbiEnero.Caption = "Enero"
        Me.bbiEnero.Id = 20
        Me.bbiEnero.Name = "bbiEnero"
        '
        'bbiFebrero
        '
        Me.bbiFebrero.Caption = "Febrero"
        Me.bbiFebrero.Id = 21
        Me.bbiFebrero.Name = "bbiFebrero"
        '
        'bbiMarzo
        '
        Me.bbiMarzo.Caption = "Marzo"
        Me.bbiMarzo.Id = 22
        Me.bbiMarzo.Name = "bbiMarzo"
        '
        'bbiAbril
        '
        Me.bbiAbril.Caption = "Abril"
        Me.bbiAbril.Id = 23
        Me.bbiAbril.Name = "bbiAbril"
        '
        'bbiMayo
        '
        Me.bbiMayo.Caption = "Mayo"
        Me.bbiMayo.Id = 24
        Me.bbiMayo.Name = "bbiMayo"
        '
        'bbiJunio
        '
        Me.bbiJunio.Caption = "Junio"
        Me.bbiJunio.Id = 25
        Me.bbiJunio.Name = "bbiJunio"
        '
        'bbiJulio
        '
        Me.bbiJulio.Caption = "Julio"
        Me.bbiJulio.Id = 26
        Me.bbiJulio.Name = "bbiJulio"
        '
        'bbiAgosto
        '
        Me.bbiAgosto.Caption = "Agosto"
        Me.bbiAgosto.Id = 27
        Me.bbiAgosto.Name = "bbiAgosto"
        '
        'bbiSeptiembre
        '
        Me.bbiSeptiembre.Caption = "Septiembre"
        Me.bbiSeptiembre.Id = 28
        Me.bbiSeptiembre.Name = "bbiSeptiembre"
        '
        'bbiOctubre
        '
        Me.bbiOctubre.Caption = "Octubre"
        Me.bbiOctubre.Id = 29
        Me.bbiOctubre.Name = "bbiOctubre"
        '
        'bbiNoviembre
        '
        Me.bbiNoviembre.Caption = "Noviembre"
        Me.bbiNoviembre.Id = 30
        Me.bbiNoviembre.Name = "bbiNoviembre"
        '
        'bbiDiciembre
        '
        Me.bbiDiciembre.Caption = "Diciembre"
        Me.bbiDiciembre.Id = 31
        Me.bbiDiciembre.Name = "bbiDiciembre"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btVistaPrevia)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblIdDetalleOrden)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ppCargar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.xtcDatosHistoria)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SeparatorControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDatosUsuario)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsecutivoOrden)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsecutivo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtNumeroHistoria)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dtFechaIngreso)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1244, 573)
        Me.SplitContainerControl1.SplitterPosition = 411
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'btVistaPrevia
        '
        Me.btVistaPrevia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btVistaPrevia.ImageOptions.Image = CType(resources.GetObject("btVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.btVistaPrevia.Location = New System.Drawing.Point(373, 507)
        Me.btVistaPrevia.Name = "btVistaPrevia"
        Me.btVistaPrevia.Size = New System.Drawing.Size(26, 23)
        Me.btVistaPrevia.TabIndex = 19
        Me.btVistaPrevia.Text = "Vista Previa Historias Clinicas"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.GCHistoriasAnteriores)
        Me.GroupControl2.Location = New System.Drawing.Point(11, 282)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(388, 219)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Historias Anteriores"
        '
        'GCHistoriasAnteriores
        '
        Me.GCHistoriasAnteriores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHistoriasAnteriores.Location = New System.Drawing.Point(2, 20)
        Me.GCHistoriasAnteriores.MainView = Me.gvHistoriasAnteriores
        Me.GCHistoriasAnteriores.MenuManager = Me.BarManager1
        Me.GCHistoriasAnteriores.Name = "GCHistoriasAnteriores"
        Me.GCHistoriasAnteriores.Size = New System.Drawing.Size(384, 197)
        Me.GCHistoriasAnteriores.TabIndex = 2
        Me.GCHistoriasAnteriores.UseEmbeddedNavigator = True
        Me.GCHistoriasAnteriores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHistoriasAnteriores})
        '
        'gvHistoriasAnteriores
        '
        Me.gvHistoriasAnteriores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHAOrden, Me.colHAFecha, Me.colHAMotivoConsulta, Me.colHAID})
        Me.gvHistoriasAnteriores.GridControl = Me.GCHistoriasAnteriores
        Me.gvHistoriasAnteriores.Name = "gvHistoriasAnteriores"
        Me.gvHistoriasAnteriores.OptionsBehavior.Editable = False
        Me.gvHistoriasAnteriores.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvHistoriasAnteriores.OptionsCustomization.AllowRowSizing = True
        Me.gvHistoriasAnteriores.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.gvHistoriasAnteriores.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvHistoriasAnteriores.OptionsView.EnableAppearanceOddRow = True
        Me.gvHistoriasAnteriores.OptionsView.RowAutoHeight = True
        Me.gvHistoriasAnteriores.OptionsView.ShowFooter = True
        Me.gvHistoriasAnteriores.OptionsView.ShowGroupPanel = False
        '
        'colHAOrden
        '
        Me.colHAOrden.Caption = "ORDEN"
        Me.colHAOrden.FieldName = "ORDEN"
        Me.colHAOrden.Name = "colHAOrden"
        Me.colHAOrden.Visible = True
        Me.colHAOrden.VisibleIndex = 0
        Me.colHAOrden.Width = 61
        '
        'colHAFecha
        '
        Me.colHAFecha.Caption = "FECHA"
        Me.colHAFecha.FieldName = "FECHA"
        Me.colHAFecha.Name = "colHAFecha"
        Me.colHAFecha.Visible = True
        Me.colHAFecha.VisibleIndex = 1
        Me.colHAFecha.Width = 80
        '
        'colHAMotivoConsulta
        '
        Me.colHAMotivoConsulta.Caption = "MOTIVO CONSULTA"
        Me.colHAMotivoConsulta.FieldName = "MOTIVO_CONSULTA"
        Me.colHAMotivoConsulta.Name = "colHAMotivoConsulta"
        Me.colHAMotivoConsulta.Visible = True
        Me.colHAMotivoConsulta.VisibleIndex = 2
        Me.colHAMotivoConsulta.Width = 227
        '
        'colHAID
        '
        Me.colHAID.Caption = "ID"
        Me.colHAID.FieldName = "ID"
        Me.colHAID.Name = "colHAID"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.GCPacientesAtender)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(388, 269)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Pacientes por Atender"
        '
        'GCPacientesAtender
        '
        Me.GCPacientesAtender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPacientesAtender.Location = New System.Drawing.Point(2, 20)
        Me.GCPacientesAtender.MainView = Me.GVPacientesAtender
        Me.GCPacientesAtender.MenuManager = Me.BarManager1
        Me.GCPacientesAtender.Name = "GCPacientesAtender"
        Me.GCPacientesAtender.Size = New System.Drawing.Size(384, 247)
        Me.GCPacientesAtender.TabIndex = 1
        Me.GCPacientesAtender.UseEmbeddedNavigator = True
        Me.GCPacientesAtender.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPacientesAtender})
        '
        'GVPacientesAtender
        '
        Me.GVPacientesAtender.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORDEN, Me.colPACIENTE, Me.colCONTRATO, Me.colESTADO, Me.colID2})
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colESTADO
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "PENDIENTE"
        FormatConditionRuleValue2.Value1 = "PENDIENTE"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GVPacientesAtender.FormatRules.Add(GridFormatRule2)
        Me.GVPacientesAtender.GridControl = Me.GCPacientesAtender
        Me.GVPacientesAtender.Name = "GVPacientesAtender"
        Me.GVPacientesAtender.OptionsBehavior.Editable = False
        Me.GVPacientesAtender.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVPacientesAtender.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVPacientesAtender.OptionsPrint.ExpandAllDetails = True
        Me.GVPacientesAtender.OptionsPrint.ExpandAllGroups = False
        Me.GVPacientesAtender.OptionsPrint.PrintFooter = False
        Me.GVPacientesAtender.OptionsView.EnableAppearanceOddRow = True
        Me.GVPacientesAtender.OptionsView.ShowFooter = True
        Me.GVPacientesAtender.OptionsView.ShowGroupPanel = False
        '
        'colORDEN
        '
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 0
        Me.colORDEN.Width = 60
        '
        'colPACIENTE
        '
        Me.colPACIENTE.FieldName = "PACIENTE"
        Me.colPACIENTE.Name = "colPACIENTE"
        Me.colPACIENTE.Visible = True
        Me.colPACIENTE.VisibleIndex = 1
        Me.colPACIENTE.Width = 164
        '
        'colCONTRATO
        '
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 2
        Me.colCONTRATO.Width = 144
        '
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'lblIdDetalleOrden
        '
        Me.lblIdDetalleOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdDetalleOrden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblIdDetalleOrden.Appearance.Options.UseFont = True
        Me.lblIdDetalleOrden.Appearance.Options.UseForeColor = True
        Me.lblIdDetalleOrden.Location = New System.Drawing.Point(307, 12)
        Me.lblIdDetalleOrden.Name = "lblIdDetalleOrden"
        Me.lblIdDetalleOrden.Size = New System.Drawing.Size(8, 16)
        Me.lblIdDetalleOrden.TabIndex = 89
        Me.lblIdDetalleOrden.Text = "1"
        Me.lblIdDetalleOrden.Visible = False
        '
        'ppCargar
        '
        Me.ppCargar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ppCargar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ppCargar.Appearance.Options.UseBackColor = True
        Me.ppCargar.BarAnimationElementThickness = 2
        Me.ppCargar.Caption = "Por Favor Espere"
        Me.ppCargar.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ppCargar.Description = "Cargando"
        Me.ppCargar.Location = New System.Drawing.Point(205, 75)
        Me.ppCargar.Name = "ppCargar"
        Me.ppCargar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ppCargar.Size = New System.Drawing.Size(238, 70)
        Me.ppCargar.TabIndex = 39
        Me.ppCargar.Text = "6"
        Me.ppCargar.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(620, 24)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(196, 132)
        Me.XtraTabControl1.TabIndex = 88
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtAntecedentesFamiliares2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(190, 104)
        Me.XtraTabPage1.Text = "Familiares"
        '
        'txtAntecedentesFamiliares2
        '
        Me.txtAntecedentesFamiliares2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAntecedentesFamiliares2.Location = New System.Drawing.Point(3, 16)
        Me.txtAntecedentesFamiliares2.MenuManager = Me.BarManager1
        Me.txtAntecedentesFamiliares2.Name = "txtAntecedentesFamiliares2"
        Me.txtAntecedentesFamiliares2.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAntecedentesFamiliares2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntecedentesFamiliares2.Properties.Appearance.Options.UseBackColor = True
        Me.txtAntecedentesFamiliares2.Properties.Appearance.Options.UseFont = True
        Me.txtAntecedentesFamiliares2.Properties.ReadOnly = True
        Me.txtAntecedentesFamiliares2.Size = New System.Drawing.Size(174, 82)
        Me.txtAntecedentesFamiliares2.TabIndex = 35
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtAntecedentesPersonales2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(190, 104)
        Me.XtraTabPage2.Text = "Personales"
        '
        'txtAntecedentesPersonales2
        '
        Me.txtAntecedentesPersonales2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAntecedentesPersonales2.Location = New System.Drawing.Point(3, 16)
        Me.txtAntecedentesPersonales2.MenuManager = Me.BarManager1
        Me.txtAntecedentesPersonales2.Name = "txtAntecedentesPersonales2"
        Me.txtAntecedentesPersonales2.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAntecedentesPersonales2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntecedentesPersonales2.Properties.Appearance.Options.UseBackColor = True
        Me.txtAntecedentesPersonales2.Properties.Appearance.Options.UseFont = True
        Me.txtAntecedentesPersonales2.Properties.ReadOnly = True
        Me.txtAntecedentesPersonales2.Size = New System.Drawing.Size(173, 82)
        Me.txtAntecedentesPersonales2.TabIndex = 36
        '
        'xtcDatosHistoria
        '
        Me.xtcDatosHistoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcDatosHistoria.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.xtcDatosHistoria.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcDatosHistoria.Location = New System.Drawing.Point(8, 162)
        Me.xtcDatosHistoria.Name = "xtcDatosHistoria"
        Me.xtcDatosHistoria.SelectedTabPage = Me.xtpMotivoConsulta
        Me.xtcDatosHistoria.Size = New System.Drawing.Size(808, 408)
        Me.xtcDatosHistoria.TabIndex = 44
        Me.xtcDatosHistoria.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpMotivoConsulta, Me.xtpEnfermedadActual, Me.xtpAntecedentes, Me.xtpExamenFisico, Me.xtpDiagnostico, Me.xtpPlanSeguir, Me.xtpRecomendaciones, Me.xtpFormulacion, Me.xtpLaboratorios, Me.xtpProcedimientos, Me.xtpCurvaCrecimiento})
        '
        'xtpMotivoConsulta
        '
        Me.xtpMotivoConsulta.Controls.Add(Me.txtResponsables)
        Me.xtpMotivoConsulta.Controls.Add(Me.LabelControl4)
        Me.xtpMotivoConsulta.Controls.Add(Me.txtMotivoConsulta)
        Me.xtpMotivoConsulta.Controls.Add(Me.LabelControl6)
        Me.xtpMotivoConsulta.Name = "xtpMotivoConsulta"
        Me.xtpMotivoConsulta.Size = New System.Drawing.Size(667, 402)
        Me.xtpMotivoConsulta.Text = "Motivo de Consulta"
        '
        'txtResponsables
        '
        Me.txtResponsables.Location = New System.Drawing.Point(17, 187)
        Me.txtResponsables.MenuManager = Me.BarManager1
        Me.txtResponsables.Name = "txtResponsables"
        Me.txtResponsables.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtResponsables.Properties.Appearance.Options.UseBackColor = True
        Me.txtResponsables.Size = New System.Drawing.Size(452, 109)
        Me.txtResponsables.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(17, 168)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(214, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Responsables o Acompañantes del Paciente:"
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(18, 35)
        Me.txtMotivoConsulta.MenuManager = Me.BarManager1
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMotivoConsulta.Properties.Appearance.Options.UseBackColor = True
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(452, 109)
        Me.txtMotivoConsulta.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(153, 13)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "Descripción Motivo de Consulta:"
        '
        'xtpEnfermedadActual
        '
        Me.xtpEnfermedadActual.Controls.Add(Me.txtEnfermedadActual)
        Me.xtpEnfermedadActual.Controls.Add(Me.LabelControl7)
        Me.xtpEnfermedadActual.Name = "xtpEnfermedadActual"
        Me.xtpEnfermedadActual.Size = New System.Drawing.Size(667, 402)
        Me.xtpEnfermedadActual.Text = "Enfermedad Actual"
        '
        'txtEnfermedadActual
        '
        Me.txtEnfermedadActual.Location = New System.Drawing.Point(18, 35)
        Me.txtEnfermedadActual.MenuManager = Me.BarManager1
        Me.txtEnfermedadActual.Name = "txtEnfermedadActual"
        Me.txtEnfermedadActual.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEnfermedadActual.Properties.Appearance.Options.UseBackColor = True
        Me.txtEnfermedadActual.Size = New System.Drawing.Size(452, 109)
        Me.txtEnfermedadActual.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "Descripción Enfermedad Actual:"
        '
        'xtpAntecedentes
        '
        Me.xtpAntecedentes.Controls.Add(Me.txtAntecedentesPersonales)
        Me.xtpAntecedentes.Controls.Add(Me.LabelControl9)
        Me.xtpAntecedentes.Controls.Add(Me.txtAntecedentesFamiliares)
        Me.xtpAntecedentes.Controls.Add(Me.LabelControl8)
        Me.xtpAntecedentes.Name = "xtpAntecedentes"
        Me.xtpAntecedentes.Size = New System.Drawing.Size(667, 402)
        Me.xtpAntecedentes.Text = "Antecedentes"
        '
        'txtAntecedentesPersonales
        '
        Me.txtAntecedentesPersonales.Location = New System.Drawing.Point(17, 177)
        Me.txtAntecedentesPersonales.MenuManager = Me.BarManager1
        Me.txtAntecedentesPersonales.Name = "txtAntecedentesPersonales"
        Me.txtAntecedentesPersonales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAntecedentesPersonales.Properties.Appearance.Options.UseBackColor = True
        Me.txtAntecedentesPersonales.Size = New System.Drawing.Size(452, 109)
        Me.txtAntecedentesPersonales.TabIndex = 43
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(17, 158)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(183, 13)
        Me.LabelControl9.TabIndex = 44
        Me.LabelControl9.Text = "Descripción Antecedentes Personales:"
        '
        'txtAntecedentesFamiliares
        '
        Me.txtAntecedentesFamiliares.Location = New System.Drawing.Point(18, 35)
        Me.txtAntecedentesFamiliares.MenuManager = Me.BarManager1
        Me.txtAntecedentesFamiliares.Name = "txtAntecedentesFamiliares"
        Me.txtAntecedentesFamiliares.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAntecedentesFamiliares.Properties.Appearance.Options.UseBackColor = True
        Me.txtAntecedentesFamiliares.Size = New System.Drawing.Size(452, 109)
        Me.txtAntecedentesFamiliares.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(178, 13)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "Descripción Antecedentes Familiares:"
        '
        'xtpExamenFisico
        '
        Me.xtpExamenFisico.Controls.Add(Me.XtraTabControl2)
        Me.xtpExamenFisico.Name = "xtpExamenFisico"
        Me.xtpExamenFisico.Size = New System.Drawing.Size(667, 402)
        Me.xtpExamenFisico.Text = "Examen Fisico"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(16, 11)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage14
        Me.XtraTabControl2.Size = New System.Drawing.Size(642, 358)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage14, Me.XtraTabPage15})
        '
        'XtraTabPage14
        '
        Me.XtraTabPage14.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage14.Controls.Add(Me.SeparatorControl2)
        Me.XtraTabPage14.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage14.Controls.Add(Me.txtTalla)
        Me.XtraTabPage14.Controls.Add(Me.txtPeso)
        Me.XtraTabPage14.Controls.Add(Me.txtValorIMC)
        Me.XtraTabPage14.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage14.Controls.Add(Me.txtTemperatura)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl20)
        Me.XtraTabPage14.Controls.Add(Me.txtFR)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage14.Controls.Add(Me.txtFC)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage14.Controls.Add(Me.txtTA)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage14.Controls.Add(Me.txtIMC)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage14.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage14.Name = "XtraTabPage14"
        Me.XtraTabPage14.Size = New System.Drawing.Size(636, 330)
        Me.XtraTabPage14.Text = "General"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.cboEscalaPrader)
        Me.GroupControl5.Controls.Add(Me.peImagen)
        Me.GroupControl5.Location = New System.Drawing.Point(510, 20)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(115, 284)
        Me.GroupControl5.TabIndex = 91
        Me.GroupControl5.Text = "Escala de Prader"
        '
        'cboEscalaPrader
        '
        Me.cboEscalaPrader.Location = New System.Drawing.Point(5, 23)
        Me.cboEscalaPrader.Name = "cboEscalaPrader"
        Me.cboEscalaPrader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEscalaPrader.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE")})
        Me.cboEscalaPrader.Properties.NullText = ""
        Me.cboEscalaPrader.Properties.PopupSizeable = False
        Me.cboEscalaPrader.Properties.ShowHeader = False
        Me.cboEscalaPrader.Size = New System.Drawing.Size(105, 20)
        Me.cboEscalaPrader.TabIndex = 15
        '
        'peImagen
        '
        Me.peImagen.Location = New System.Drawing.Point(5, 49)
        Me.peImagen.Name = "peImagen"
        Me.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peImagen.Size = New System.Drawing.Size(105, 230)
        Me.peImagen.TabIndex = 71
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.AutoSizeMode = True
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(484, 13)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(20, 284)
        Me.SeparatorControl2.TabIndex = 90
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cboTesticuloDER)
        Me.GroupControl4.Controls.Add(Me.LabelControl28)
        Me.GroupControl4.Controls.Add(Me.LabelControl38)
        Me.GroupControl4.Controls.Add(Me.cboTesticuloIZQ)
        Me.GroupControl4.Controls.Add(Me.LabelControl39)
        Me.GroupControl4.Controls.Add(Me.cboMeathusUretral)
        Me.GroupControl4.Controls.Add(Me.LabelControl40)
        Me.GroupControl4.Controls.Add(Me.cboMicroPene)
        Me.GroupControl4.Controls.Add(Me.LabelControl41)
        Me.GroupControl4.Controls.Add(Me.cboFusionEscrotal)
        Me.GroupControl4.Location = New System.Drawing.Point(12, 185)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(468, 112)
        Me.GroupControl4.TabIndex = 70
        Me.GroupControl4.Text = "Masculinizacion Externa"
        '
        'cboTesticuloDER
        '
        Me.cboTesticuloDER.Location = New System.Drawing.Point(380, 53)
        Me.cboTesticuloDER.MenuManager = Me.BarManager1
        Me.cboTesticuloDER.Name = "cboTesticuloDER"
        Me.cboTesticuloDER.Properties.AutoComplete = False
        Me.cboTesticuloDER.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTesticuloDER.Properties.Items.AddRange(New Object() {"-", "Ab", "0.5", "Ing", "L/S"})
        Me.cboTesticuloDER.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTesticuloDER.Size = New System.Drawing.Size(80, 20)
        Me.cboTesticuloDER.TabIndex = 70
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(380, 34)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl28.TabIndex = 69
        Me.LabelControl28.Text = "Testiculo DER."
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(288, 34)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl38.TabIndex = 67
        Me.LabelControl38.Text = "Testiculo IZQ."
        '
        'cboTesticuloIZQ
        '
        Me.cboTesticuloIZQ.Location = New System.Drawing.Point(288, 53)
        Me.cboTesticuloIZQ.MenuManager = Me.BarManager1
        Me.cboTesticuloIZQ.Name = "cboTesticuloIZQ"
        Me.cboTesticuloIZQ.Properties.AutoComplete = False
        Me.cboTesticuloIZQ.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTesticuloIZQ.Properties.Items.AddRange(New Object() {"-", "Ab", "0.5", "Ing", "L/S"})
        Me.cboTesticuloIZQ.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTesticuloIZQ.Size = New System.Drawing.Size(80, 20)
        Me.cboTesticuloIZQ.TabIndex = 19
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(196, 34)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl39.TabIndex = 65
        Me.LabelControl39.Text = "Meathus Uretral"
        '
        'cboMeathusUretral
        '
        Me.cboMeathusUretral.Location = New System.Drawing.Point(196, 53)
        Me.cboMeathusUretral.MenuManager = Me.BarManager1
        Me.cboMeathusUretral.Name = "cboMeathusUretral"
        Me.cboMeathusUretral.Properties.AutoComplete = False
        Me.cboMeathusUretral.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMeathusUretral.Properties.Items.AddRange(New Object() {"-", "PROX", "0.5", "MID", "1.5", "DISTAL", "2.5", "NORMAL"})
        Me.cboMeathusUretral.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMeathusUretral.Size = New System.Drawing.Size(80, 20)
        Me.cboMeathusUretral.TabIndex = 18
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(104, 34)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl40.TabIndex = 63
        Me.LabelControl40.Text = "Micro Penis"
        '
        'cboMicroPene
        '
        Me.cboMicroPene.Location = New System.Drawing.Point(104, 53)
        Me.cboMicroPene.MenuManager = Me.BarManager1
        Me.cboMicroPene.Name = "cboMicroPene"
        Me.cboMicroPene.Properties.AutoComplete = False
        Me.cboMicroPene.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMicroPene.Properties.Items.AddRange(New Object() {"-", "Y", "0.5", "1", "2", "2.5", "N"})
        Me.cboMicroPene.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMicroPene.Size = New System.Drawing.Size(80, 20)
        Me.cboMicroPene.TabIndex = 17
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(12, 34)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl41.TabIndex = 61
        Me.LabelControl41.Text = "Fusion Escrotal"
        '
        'cboFusionEscrotal
        '
        Me.cboFusionEscrotal.Location = New System.Drawing.Point(12, 53)
        Me.cboFusionEscrotal.MenuManager = Me.BarManager1
        Me.cboFusionEscrotal.Name = "cboFusionEscrotal"
        Me.cboFusionEscrotal.Properties.AutoComplete = False
        Me.cboFusionEscrotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFusionEscrotal.Properties.Items.AddRange(New Object() {"-", "N", "0.5", "1", "1.5", "2", "2.5", "Y"})
        Me.cboFusionEscrotal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFusionEscrotal.Size = New System.Drawing.Size(80, 20)
        Me.cboFusionEscrotal.TabIndex = 16
        '
        'txtTalla
        '
        Me.txtTalla.EditValue = "0"
        Me.txtTalla.Location = New System.Drawing.Point(65, 32)
        Me.txtTalla.Name = "txtTalla"
        Me.txtTalla.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTalla.Properties.Appearance.Options.UseBackColor = True
        Me.txtTalla.Properties.Mask.BeepOnError = True
        Me.txtTalla.Properties.Mask.EditMask = "f"
        Me.txtTalla.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTalla.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTalla.Size = New System.Drawing.Size(47, 20)
        Me.txtTalla.TabIndex = 63
        '
        'txtPeso
        '
        Me.txtPeso.EditValue = "0"
        Me.txtPeso.Location = New System.Drawing.Point(12, 32)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPeso.Properties.Appearance.Options.UseBackColor = True
        Me.txtPeso.Properties.Mask.BeepOnError = True
        Me.txtPeso.Properties.Mask.EditMask = "f"
        Me.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPeso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeso.Size = New System.Drawing.Size(47, 20)
        Me.txtPeso.TabIndex = 62
        '
        'txtValorIMC
        '
        Me.txtValorIMC.Location = New System.Drawing.Point(12, 58)
        Me.txtValorIMC.MenuManager = Me.BarManager1
        Me.txtValorIMC.Name = "txtValorIMC"
        Me.txtValorIMC.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValorIMC.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorIMC.Properties.Mask.EditMask = "n2"
        Me.txtValorIMC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorIMC.Properties.ReadOnly = True
        Me.txtValorIMC.Size = New System.Drawing.Size(153, 20)
        Me.txtValorIMC.TabIndex = 61
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtLP)
        Me.GroupControl3.Controls.Add(Me.LabelControl25)
        Me.GroupControl3.Controls.Add(Me.LabelControl24)
        Me.GroupControl3.Controls.Add(Me.cboVT)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Controls.Add(Me.cboP)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me.cboB)
        Me.GroupControl3.Controls.Add(Me.LabelControl21)
        Me.GroupControl3.Controls.Add(Me.cboA)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 85)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(468, 90)
        Me.GroupControl3.TabIndex = 60
        Me.GroupControl3.Text = "Tanner"
        '
        'txtLP
        '
        Me.txtLP.Location = New System.Drawing.Point(290, 40)
        Me.txtLP.MenuManager = Me.BarManager1
        Me.txtLP.Name = "txtLP"
        Me.txtLP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtLP.Properties.Appearance.Options.UseBackColor = True
        Me.txtLP.Size = New System.Drawing.Size(47, 20)
        Me.txtLP.TabIndex = 20
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(273, 43)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl25.TabIndex = 69
        Me.LabelControl25.Text = "LP"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(216, 43)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl24.TabIndex = 67
        Me.LabelControl24.Text = "VT"
        '
        'cboVT
        '
        Me.cboVT.Location = New System.Drawing.Point(229, 40)
        Me.cboVT.MenuManager = Me.BarManager1
        Me.cboVT.Name = "cboVT"
        Me.cboVT.Properties.AutoComplete = False
        Me.cboVT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVT.Properties.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "8", "10", "12", "15", "20", "25", "30", "35"})
        Me.cboVT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboVT.Size = New System.Drawing.Size(38, 20)
        Me.cboVT.TabIndex = 19
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(146, 43)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl23.TabIndex = 65
        Me.LabelControl23.Text = "P"
        '
        'cboP
        '
        Me.cboP.Location = New System.Drawing.Point(159, 40)
        Me.cboP.MenuManager = Me.BarManager1
        Me.cboP.Name = "cboP"
        Me.cboP.Properties.AutoComplete = False
        Me.cboP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboP.Properties.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6"})
        Me.cboP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboP.Size = New System.Drawing.Size(38, 20)
        Me.cboP.TabIndex = 18
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(81, 43)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl22.TabIndex = 63
        Me.LabelControl22.Text = "B"
        '
        'cboB
        '
        Me.cboB.Location = New System.Drawing.Point(94, 40)
        Me.cboB.MenuManager = Me.BarManager1
        Me.cboB.Name = "cboB"
        Me.cboB.Properties.AutoComplete = False
        Me.cboB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboB.Properties.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6"})
        Me.cboB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboB.Size = New System.Drawing.Size(38, 20)
        Me.cboB.TabIndex = 17
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(7, 13)
        Me.LabelControl21.TabIndex = 61
        Me.LabelControl21.Text = "A"
        '
        'cboA
        '
        Me.cboA.Location = New System.Drawing.Point(25, 40)
        Me.cboA.MenuManager = Me.BarManager1
        Me.cboA.Name = "cboA"
        Me.cboA.Properties.AutoComplete = False
        Me.cboA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboA.Properties.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6"})
        Me.cboA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboA.Size = New System.Drawing.Size(38, 20)
        Me.cboA.TabIndex = 16
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(333, 32)
        Me.txtTemperatura.MenuManager = Me.BarManager1
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTemperatura.Properties.Appearance.Options.UseBackColor = True
        Me.txtTemperatura.Size = New System.Drawing.Size(62, 20)
        Me.txtTemperatura.TabIndex = 15
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(333, 13)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl20.TabIndex = 59
        Me.LabelControl20.Text = "Temperatura"
        '
        'txtFR
        '
        Me.txtFR.Location = New System.Drawing.Point(280, 32)
        Me.txtFR.MenuManager = Me.BarManager1
        Me.txtFR.Name = "txtFR"
        Me.txtFR.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFR.Properties.Appearance.Options.UseBackColor = True
        Me.txtFR.Size = New System.Drawing.Size(47, 20)
        Me.txtFR.TabIndex = 14
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(280, 13)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl18.TabIndex = 57
        Me.LabelControl18.Text = "F.R."
        '
        'txtFC
        '
        Me.txtFC.Location = New System.Drawing.Point(227, 32)
        Me.txtFC.MenuManager = Me.BarManager1
        Me.txtFC.Name = "txtFC"
        Me.txtFC.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFC.Properties.Appearance.Options.UseBackColor = True
        Me.txtFC.Size = New System.Drawing.Size(47, 20)
        Me.txtFC.TabIndex = 13
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(227, 13)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl17.TabIndex = 55
        Me.LabelControl17.Text = "F.C."
        '
        'txtTA
        '
        Me.txtTA.Location = New System.Drawing.Point(174, 32)
        Me.txtTA.MenuManager = Me.BarManager1
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTA.Properties.Appearance.Options.UseBackColor = True
        Me.txtTA.Size = New System.Drawing.Size(47, 20)
        Me.txtTA.TabIndex = 12
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(174, 13)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl16.TabIndex = 53
        Me.LabelControl16.Text = "T.A."
        '
        'txtIMC
        '
        Me.txtIMC.Location = New System.Drawing.Point(118, 32)
        Me.txtIMC.MenuManager = Me.BarManager1
        Me.txtIMC.Name = "txtIMC"
        Me.txtIMC.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtIMC.Properties.Appearance.Options.UseBackColor = True
        Me.txtIMC.Properties.Mask.EditMask = "n2"
        Me.txtIMC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIMC.Properties.ReadOnly = True
        Me.txtIMC.Size = New System.Drawing.Size(47, 20)
        Me.txtIMC.TabIndex = 50
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(118, 13)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl15.TabIndex = 51
        Me.LabelControl15.Text = "I.M.C"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(65, 13)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl14.TabIndex = 49
        Me.LabelControl14.Text = "Talla(cm)"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 13)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl13.TabIndex = 47
        Me.LabelControl13.Text = "Peso(Kg)"
        '
        'XtraTabPage15
        '
        Me.XtraTabPage15.Controls.Add(Me.cmdEliminarRevisionSistemas)
        Me.XtraTabPage15.Controls.Add(Me.cmdAgregarRevisionSistemas)
        Me.XtraTabPage15.Controls.Add(Me.GCRevisionSistema)
        Me.XtraTabPage15.Controls.Add(Me.txtDescripcionRevisionSistemas)
        Me.XtraTabPage15.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage15.Controls.Add(Me.cboRevisionSistema)
        Me.XtraTabPage15.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage15.Name = "XtraTabPage15"
        Me.XtraTabPage15.Size = New System.Drawing.Size(636, 330)
        Me.XtraTabPage15.Text = "Revision por Sistemas"
        '
        'cmdEliminarRevisionSistemas
        '
        Me.cmdEliminarRevisionSistemas.ImageOptions.Image = CType(resources.GetObject("cmdEliminarRevisionSistemas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminarRevisionSistemas.Location = New System.Drawing.Point(502, 128)
        Me.cmdEliminarRevisionSistemas.Name = "cmdEliminarRevisionSistemas"
        Me.cmdEliminarRevisionSistemas.Size = New System.Drawing.Size(26, 23)
        Me.cmdEliminarRevisionSistemas.TabIndex = 62
        Me.cmdEliminarRevisionSistemas.Text = "Eliminar Revision por Sistemas"
        '
        'cmdAgregarRevisionSistemas
        '
        Me.cmdAgregarRevisionSistemas.ImageOptions.Image = CType(resources.GetObject("cmdAgregarRevisionSistemas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregarRevisionSistemas.Location = New System.Drawing.Point(470, 128)
        Me.cmdAgregarRevisionSistemas.Name = "cmdAgregarRevisionSistemas"
        Me.cmdAgregarRevisionSistemas.Size = New System.Drawing.Size(26, 23)
        Me.cmdAgregarRevisionSistemas.TabIndex = 61
        Me.cmdAgregarRevisionSistemas.Text = "Agregar Revision por Sistemas"
        '
        'GCRevisionSistema
        '
        Me.GCRevisionSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCRevisionSistema.Location = New System.Drawing.Point(11, 157)
        Me.GCRevisionSistema.MainView = Me.GVRevisionSistema
        Me.GCRevisionSistema.MenuManager = Me.BarManager1
        Me.GCRevisionSistema.Name = "GCRevisionSistema"
        Me.GCRevisionSistema.Size = New System.Drawing.Size(622, 170)
        Me.GCRevisionSistema.TabIndex = 65
        Me.GCRevisionSistema.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRevisionSistema})
        '
        'GVRevisionSistema
        '
        Me.GVRevisionSistema.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNOMBRE1, Me.colDESCRIPCION})
        Me.GVRevisionSistema.GridControl = Me.GCRevisionSistema
        Me.GVRevisionSistema.Name = "GVRevisionSistema"
        Me.GVRevisionSistema.OptionsBehavior.Editable = False
        Me.GVRevisionSistema.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVRevisionSistema.OptionsCustomization.AllowRowSizing = True
        Me.GVRevisionSistema.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVRevisionSistema.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVRevisionSistema.OptionsView.RowAutoHeight = True
        Me.GVRevisionSistema.OptionsView.ShowFooter = True
        Me.GVRevisionSistema.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNOMBRE1
        '
        Me.colNOMBRE1.Caption = "NOMBRE"
        Me.colNOMBRE1.FieldName = "NOMBRE"
        Me.colNOMBRE1.Name = "colNOMBRE1"
        Me.colNOMBRE1.Visible = True
        Me.colNOMBRE1.VisibleIndex = 0
        Me.colNOMBRE1.Width = 335
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "DESCRIPCION"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 357
        '
        'txtDescripcionRevisionSistemas
        '
        Me.txtDescripcionRevisionSistemas.Location = New System.Drawing.Point(11, 78)
        Me.txtDescripcionRevisionSistemas.MenuManager = Me.BarManager1
        Me.txtDescripcionRevisionSistemas.Name = "txtDescripcionRevisionSistemas"
        Me.txtDescripcionRevisionSistemas.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcionRevisionSistemas.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcionRevisionSistemas.Size = New System.Drawing.Size(451, 73)
        Me.txtDescripcionRevisionSistemas.TabIndex = 60
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(11, 59)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(165, 13)
        Me.LabelControl10.TabIndex = 64
        Me.LabelControl10.Text = "Descripción Revision por Sistemas:"
        '
        'cboRevisionSistema
        '
        Me.cboRevisionSistema.Location = New System.Drawing.Point(10, 28)
        Me.cboRevisionSistema.MenuManager = Me.BarManager1
        Me.cboRevisionSistema.Name = "cboRevisionSistema"
        Me.cboRevisionSistema.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboRevisionSistema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRevisionSistema.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SISTEMA", "SISTEMA")})
        Me.cboRevisionSistema.Properties.NullText = ""
        Me.cboRevisionSistema.Properties.PopupWidth = 600
        Me.cboRevisionSistema.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboRevisionSistema.Properties.ShowHeader = False
        Me.cboRevisionSistema.Size = New System.Drawing.Size(452, 20)
        Me.cboRevisionSistema.TabIndex = 59
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl19.TabIndex = 63
        Me.LabelControl19.Text = "Seleccionar Sistema"
        '
        'xtpDiagnostico
        '
        Me.xtpDiagnostico.Controls.Add(Me.cboDiagnosticos)
        Me.xtpDiagnostico.Controls.Add(Me.btnActualizarDiagnosticos)
        Me.xtpDiagnostico.Controls.Add(Me.cmdEliminarDiagnostico)
        Me.xtpDiagnostico.Controls.Add(Me.cmdAgregarDiagnostico)
        Me.xtpDiagnostico.Controls.Add(Me.GCDiagnosticos)
        Me.xtpDiagnostico.Controls.Add(Me.txtDescripcionDiagnostico)
        Me.xtpDiagnostico.Controls.Add(Me.LabelControl11)
        Me.xtpDiagnostico.Controls.Add(Me.LabelControl12)
        Me.xtpDiagnostico.Name = "xtpDiagnostico"
        Me.xtpDiagnostico.Size = New System.Drawing.Size(667, 402)
        Me.xtpDiagnostico.Text = "Diagnostico"
        '
        'cboDiagnosticos
        '
        Me.cboDiagnosticos.EditValue = ""
        Me.cboDiagnosticos.Location = New System.Drawing.Point(16, 32)
        Me.cboDiagnosticos.Name = "cboDiagnosticos"
        Me.cboDiagnosticos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDiagnosticos.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cboDiagnosticos.Size = New System.Drawing.Size(578, 20)
        Me.cboDiagnosticos.TabIndex = 87
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO, Me.colNOMBRE})
        Me.SearchLookUpEdit1View.DetailHeight = 200
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1000
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "CODIGO"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 0
        Me.colCODIGO.Width = 104
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "DIAGNOSTICO"
        Me.colNOMBRE.FieldName = "DIAGNOSTICO"
        Me.colNOMBRE.MaxWidth = 800
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        Me.colNOMBRE.Width = 800
        '
        'btnActualizarDiagnosticos
        '
        Me.btnActualizarDiagnosticos.ImageOptions.Image = CType(resources.GetObject("btnActualizarDiagnosticos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnActualizarDiagnosticos.Location = New System.Drawing.Point(600, 30)
        Me.btnActualizarDiagnosticos.Name = "btnActualizarDiagnosticos"
        Me.btnActualizarDiagnosticos.Size = New System.Drawing.Size(26, 23)
        Me.btnActualizarDiagnosticos.TabIndex = 86
        Me.btnActualizarDiagnosticos.Text = "Agregar Diagnosticos"
        '
        'cmdEliminarDiagnostico
        '
        Me.cmdEliminarDiagnostico.ImageOptions.Image = CType(resources.GetObject("cmdEliminarDiagnostico.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminarDiagnostico.Location = New System.Drawing.Point(632, 113)
        Me.cmdEliminarDiagnostico.Name = "cmdEliminarDiagnostico"
        Me.cmdEliminarDiagnostico.Size = New System.Drawing.Size(26, 23)
        Me.cmdEliminarDiagnostico.TabIndex = 85
        '
        'cmdAgregarDiagnostico
        '
        Me.cmdAgregarDiagnostico.ImageOptions.Image = CType(resources.GetObject("cmdAgregarDiagnostico.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregarDiagnostico.Location = New System.Drawing.Point(600, 113)
        Me.cmdAgregarDiagnostico.Name = "cmdAgregarDiagnostico"
        Me.cmdAgregarDiagnostico.Size = New System.Drawing.Size(26, 23)
        Me.cmdAgregarDiagnostico.TabIndex = 84
        '
        'GCDiagnosticos
        '
        Me.GCDiagnosticos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCDiagnosticos.Location = New System.Drawing.Point(16, 142)
        Me.GCDiagnosticos.MainView = Me.GVDiagnosticos
        Me.GCDiagnosticos.MenuManager = Me.BarManager1
        Me.GCDiagnosticos.Name = "GCDiagnosticos"
        Me.GCDiagnosticos.Size = New System.Drawing.Size(642, 189)
        Me.GCDiagnosticos.TabIndex = 70
        Me.GCDiagnosticos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDiagnosticos})
        '
        'GVDiagnosticos
        '
        Me.GVDiagnosticos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDiaCODIGO, Me.colDiaDiagnostico, Me.colDiaDescripcion})
        Me.GVDiagnosticos.GridControl = Me.GCDiagnosticos
        Me.GVDiagnosticos.Name = "GVDiagnosticos"
        Me.GVDiagnosticos.OptionsBehavior.Editable = False
        Me.GVDiagnosticos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVDiagnosticos.OptionsCustomization.AllowRowSizing = True
        Me.GVDiagnosticos.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVDiagnosticos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVDiagnosticos.OptionsView.RowAutoHeight = True
        Me.GVDiagnosticos.OptionsView.ShowFooter = True
        Me.GVDiagnosticos.OptionsView.ShowGroupPanel = False
        '
        'colDiaCODIGO
        '
        Me.colDiaCODIGO.Caption = "CODIGO"
        Me.colDiaCODIGO.FieldName = "CODIGO"
        Me.colDiaCODIGO.Name = "colDiaCODIGO"
        Me.colDiaCODIGO.Visible = True
        Me.colDiaCODIGO.VisibleIndex = 0
        Me.colDiaCODIGO.Width = 81
        '
        'colDiaDiagnostico
        '
        Me.colDiaDiagnostico.Caption = "DIAGNOSTICO"
        Me.colDiaDiagnostico.FieldName = "DIAGNOSTICO"
        Me.colDiaDiagnostico.Name = "colDiaDiagnostico"
        Me.colDiaDiagnostico.Visible = True
        Me.colDiaDiagnostico.VisibleIndex = 1
        Me.colDiaDiagnostico.Width = 644
        '
        'colDiaDescripcion
        '
        Me.colDiaDescripcion.Caption = "DESCRIPCION"
        Me.colDiaDescripcion.FieldName = "DESCRIPCION"
        Me.colDiaDescripcion.Name = "colDiaDescripcion"
        Me.colDiaDescripcion.Visible = True
        Me.colDiaDescripcion.VisibleIndex = 2
        Me.colDiaDescripcion.Width = 479
        '
        'txtDescripcionDiagnostico
        '
        Me.txtDescripcionDiagnostico.Location = New System.Drawing.Point(16, 82)
        Me.txtDescripcionDiagnostico.MenuManager = Me.BarManager1
        Me.txtDescripcionDiagnostico.Name = "txtDescripcionDiagnostico"
        Me.txtDescripcionDiagnostico.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcionDiagnostico.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcionDiagnostico.Size = New System.Drawing.Size(578, 54)
        Me.txtDescripcionDiagnostico.TabIndex = 67
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl11.TabIndex = 69
        Me.LabelControl11.Text = "Descripción Diagnostico"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(15, 13)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl12.TabIndex = 68
        Me.LabelControl12.Text = "Diagnostico"
        '
        'xtpPlanSeguir
        '
        Me.xtpPlanSeguir.Controls.Add(Me.txtPlanSeguir)
        Me.xtpPlanSeguir.Controls.Add(Me.LabelControl26)
        Me.xtpPlanSeguir.Name = "xtpPlanSeguir"
        Me.xtpPlanSeguir.Size = New System.Drawing.Size(667, 402)
        Me.xtpPlanSeguir.Text = "Plan a Seguir"
        '
        'txtPlanSeguir
        '
        Me.txtPlanSeguir.Location = New System.Drawing.Point(18, 35)
        Me.txtPlanSeguir.MenuManager = Me.BarManager1
        Me.txtPlanSeguir.Name = "txtPlanSeguir"
        Me.txtPlanSeguir.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPlanSeguir.Properties.Appearance.Options.UseBackColor = True
        Me.txtPlanSeguir.Size = New System.Drawing.Size(452, 109)
        Me.txtPlanSeguir.TabIndex = 26
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl26.TabIndex = 38
        Me.LabelControl26.Text = "Descripción Plan a Seguir:"
        '
        'xtpRecomendaciones
        '
        Me.xtpRecomendaciones.Controls.Add(Me.txtRecomendaciones)
        Me.xtpRecomendaciones.Controls.Add(Me.LabelControl27)
        Me.xtpRecomendaciones.Name = "xtpRecomendaciones"
        Me.xtpRecomendaciones.Size = New System.Drawing.Size(667, 402)
        Me.xtpRecomendaciones.Text = "Recomendaciones"
        '
        'txtRecomendaciones
        '
        Me.txtRecomendaciones.Location = New System.Drawing.Point(18, 35)
        Me.txtRecomendaciones.MenuManager = Me.BarManager1
        Me.txtRecomendaciones.Name = "txtRecomendaciones"
        Me.txtRecomendaciones.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRecomendaciones.Properties.Appearance.Options.UseBackColor = True
        Me.txtRecomendaciones.Size = New System.Drawing.Size(452, 109)
        Me.txtRecomendaciones.TabIndex = 27
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(18, 16)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(147, 13)
        Me.LabelControl27.TabIndex = 38
        Me.LabelControl27.Text = "Descripción Recomendaciones:"
        '
        'xtpFormulacion
        '
        Me.xtpFormulacion.Controls.Add(Me.btnMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.cmdImprimirMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.txtCantidad)
        Me.xtpFormulacion.Controls.Add(Me.LabelControl33)
        Me.xtpFormulacion.Controls.Add(Me.cboViaAdministracion)
        Me.xtpFormulacion.Controls.Add(Me.LabelControl32)
        Me.xtpFormulacion.Controls.Add(Me.txtDosis)
        Me.xtpFormulacion.Controls.Add(Me.LabelControl31)
        Me.xtpFormulacion.Controls.Add(Me.cmdEliminarMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.cmdAgregarMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.GCMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.txtDescripcionMedicamento)
        Me.xtpFormulacion.Controls.Add(Me.LabelControl29)
        Me.xtpFormulacion.Controls.Add(Me.cboMedicamentos)
        Me.xtpFormulacion.Controls.Add(Me.LabelControl30)
        Me.xtpFormulacion.Name = "xtpFormulacion"
        Me.xtpFormulacion.Size = New System.Drawing.Size(667, 402)
        Me.xtpFormulacion.Text = "Formulacion"
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.ImageOptions.Image = CType(resources.GetObject("btnMedicamentos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMedicamentos.Location = New System.Drawing.Point(568, 31)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(26, 23)
        Me.btnMedicamentos.TabIndex = 87
        Me.btnMedicamentos.Text = "Agregar Medicamentos"
        '
        'cmdImprimirMedicamentos
        '
        Me.cmdImprimirMedicamentos.ImageOptions.Image = CType(resources.GetObject("cmdImprimirMedicamentos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimirMedicamentos.Location = New System.Drawing.Point(632, 162)
        Me.cmdImprimirMedicamentos.Name = "cmdImprimirMedicamentos"
        Me.cmdImprimirMedicamentos.Size = New System.Drawing.Size(26, 23)
        Me.cmdImprimirMedicamentos.TabIndex = 35
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(466, 81)
        Me.txtCantidad.MenuManager = Me.BarManager1
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidad.Size = New System.Drawing.Size(96, 20)
        Me.txtCantidad.TabIndex = 31
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(466, 62)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl33.TabIndex = 73
        Me.LabelControl33.Text = "Cantidad:"
        '
        'cboViaAdministracion
        '
        Me.cboViaAdministracion.Location = New System.Drawing.Point(65, 81)
        Me.cboViaAdministracion.MenuManager = Me.BarManager1
        Me.cboViaAdministracion.Name = "cboViaAdministracion"
        Me.cboViaAdministracion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboViaAdministracion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboViaAdministracion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VIA", "VIA")})
        Me.cboViaAdministracion.Properties.NullText = ""
        Me.cboViaAdministracion.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboViaAdministracion.Properties.PopupWidth = 600
        Me.cboViaAdministracion.Properties.ShowHeader = False
        Me.cboViaAdministracion.Size = New System.Drawing.Size(395, 20)
        Me.cboViaAdministracion.TabIndex = 30
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(65, 62)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl32.TabIndex = 71
        Me.LabelControl32.Text = "Via de Administracion:"
        '
        'txtDosis
        '
        Me.txtDosis.Location = New System.Drawing.Point(12, 81)
        Me.txtDosis.MenuManager = Me.BarManager1
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDosis.Properties.Appearance.Options.UseBackColor = True
        Me.txtDosis.Size = New System.Drawing.Size(47, 20)
        Me.txtDosis.TabIndex = 29
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl31.TabIndex = 69
        Me.LabelControl31.Text = "Dosis"
        '
        'cmdEliminarMedicamentos
        '
        Me.cmdEliminarMedicamentos.ImageOptions.Image = CType(resources.GetObject("cmdEliminarMedicamentos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminarMedicamentos.Location = New System.Drawing.Point(600, 162)
        Me.cmdEliminarMedicamentos.Name = "cmdEliminarMedicamentos"
        Me.cmdEliminarMedicamentos.Size = New System.Drawing.Size(26, 23)
        Me.cmdEliminarMedicamentos.TabIndex = 34
        '
        'cmdAgregarMedicamentos
        '
        Me.cmdAgregarMedicamentos.ImageOptions.Image = CType(resources.GetObject("cmdAgregarMedicamentos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregarMedicamentos.Location = New System.Drawing.Point(568, 162)
        Me.cmdAgregarMedicamentos.Name = "cmdAgregarMedicamentos"
        Me.cmdAgregarMedicamentos.Size = New System.Drawing.Size(26, 23)
        Me.cmdAgregarMedicamentos.TabIndex = 33
        '
        'GCMedicamentos
        '
        Me.GCMedicamentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCMedicamentos.Location = New System.Drawing.Point(12, 191)
        Me.GCMedicamentos.MainView = Me.GVMedicamentos
        Me.GCMedicamentos.MenuManager = Me.BarManager1
        Me.GCMedicamentos.Name = "GCMedicamentos"
        Me.GCMedicamentos.Size = New System.Drawing.Size(646, 178)
        Me.GCMedicamentos.TabIndex = 65
        Me.GCMedicamentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMedicamentos})
        '
        'GVMedicamentos
        '
        Me.GVMedicamentos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colMEDICAMENTO, Me.colVIA, Me.colDOSIS, Me.colCANTIDAD, Me.colDESCRIPCION1})
        Me.GVMedicamentos.GridControl = Me.GCMedicamentos
        Me.GVMedicamentos.Name = "GVMedicamentos"
        Me.GVMedicamentos.OptionsBehavior.Editable = False
        Me.GVMedicamentos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVMedicamentos.OptionsCustomization.AllowRowSizing = True
        Me.GVMedicamentos.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVMedicamentos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVMedicamentos.OptionsView.RowAutoHeight = True
        Me.GVMedicamentos.OptionsView.ShowFooter = True
        Me.GVMedicamentos.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.Caption = "ID"
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colMEDICAMENTO
        '
        Me.colMEDICAMENTO.Caption = "MEDICAMENTO"
        Me.colMEDICAMENTO.FieldName = "MEDICAMENTO"
        Me.colMEDICAMENTO.Name = "colMEDICAMENTO"
        Me.colMEDICAMENTO.Visible = True
        Me.colMEDICAMENTO.VisibleIndex = 0
        Me.colMEDICAMENTO.Width = 205
        '
        'colVIA
        '
        Me.colVIA.Caption = "VIA"
        Me.colVIA.FieldName = "VIA"
        Me.colVIA.Name = "colVIA"
        Me.colVIA.Visible = True
        Me.colVIA.VisibleIndex = 1
        Me.colVIA.Width = 92
        '
        'colDOSIS
        '
        Me.colDOSIS.Caption = "DOSIS"
        Me.colDOSIS.FieldName = "DOSIS"
        Me.colDOSIS.Name = "colDOSIS"
        Me.colDOSIS.Visible = True
        Me.colDOSIS.VisibleIndex = 2
        Me.colDOSIS.Width = 90
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "CANTIDAD"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 3
        Me.colCANTIDAD.Width = 59
        '
        'colDESCRIPCION1
        '
        Me.colDESCRIPCION1.Caption = "DESCRIPCION"
        Me.colDESCRIPCION1.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION1.Name = "colDESCRIPCION1"
        Me.colDESCRIPCION1.Visible = True
        Me.colDESCRIPCION1.VisibleIndex = 4
        Me.colDESCRIPCION1.Width = 246
        '
        'txtDescripcionMedicamento
        '
        Me.txtDescripcionMedicamento.Location = New System.Drawing.Point(12, 132)
        Me.txtDescripcionMedicamento.MenuManager = Me.BarManager1
        Me.txtDescripcionMedicamento.Name = "txtDescripcionMedicamento"
        Me.txtDescripcionMedicamento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcionMedicamento.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcionMedicamento.Size = New System.Drawing.Size(550, 53)
        Me.txtDescripcionMedicamento.TabIndex = 32
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(12, 113)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl29.TabIndex = 64
        Me.LabelControl29.Text = "Descripción Medicamento:"
        '
        'cboMedicamentos
        '
        Me.cboMedicamentos.Location = New System.Drawing.Point(11, 33)
        Me.cboMedicamentos.MenuManager = Me.BarManager1
        Me.cboMedicamentos.Name = "cboMedicamentos"
        Me.cboMedicamentos.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMedicamentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMedicamentos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MEDICAMENTOS", "MEDICAMENTOS"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTADO", "ESTADO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboMedicamentos.Properties.NullText = ""
        Me.cboMedicamentos.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboMedicamentos.Properties.PopupWidth = 600
        Me.cboMedicamentos.Properties.ShowHeader = False
        Me.cboMedicamentos.Size = New System.Drawing.Size(551, 20)
        Me.cboMedicamentos.TabIndex = 28
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl30.TabIndex = 62
        Me.LabelControl30.Text = "Medicamento"
        '
        'xtpLaboratorios
        '
        Me.xtpLaboratorios.Controls.Add(Me.cboLaboratorios)
        Me.xtpLaboratorios.Controls.Add(Me.btnAgregarLaboratorios)
        Me.xtpLaboratorios.Controls.Add(Me.cmdImprimirLaboratorio)
        Me.xtpLaboratorios.Controls.Add(Me.cmdEliminarLaboratorio)
        Me.xtpLaboratorios.Controls.Add(Me.cmdAgregarLaboratorio)
        Me.xtpLaboratorios.Controls.Add(Me.GCLaboratorios)
        Me.xtpLaboratorios.Controls.Add(Me.txtDescripcionLaboratorios)
        Me.xtpLaboratorios.Controls.Add(Me.LabelControl34)
        Me.xtpLaboratorios.Controls.Add(Me.LabelControl35)
        Me.xtpLaboratorios.Name = "xtpLaboratorios"
        Me.xtpLaboratorios.Size = New System.Drawing.Size(667, 402)
        Me.xtpLaboratorios.Text = "Examenes y Laboratorios"
        '
        'cboLaboratorios
        '
        Me.cboLaboratorios.EditValue = ""
        Me.cboLaboratorios.Location = New System.Drawing.Point(12, 34)
        Me.cboLaboratorios.Name = "cboLaboratorios"
        Me.cboLaboratorios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLaboratorios.Properties.PopupView = Me.GridView1
        Me.cboLaboratorios.Size = New System.Drawing.Size(550, 20)
        Me.cboLaboratorios.TabIndex = 88
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.co, Me.colEProcedimientos})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'co
        '
        Me.co.Caption = "CODIGO"
        Me.co.FieldName = "CODIGO"
        Me.co.Name = "co"
        Me.co.Visible = True
        Me.co.VisibleIndex = 0
        Me.co.Width = 102
        '
        'colEProcedimientos
        '
        Me.colEProcedimientos.Caption = "DIAGNOSTICO"
        Me.colEProcedimientos.FieldName = "PROCEDIMIENTOS"
        Me.colEProcedimientos.Name = "colEProcedimientos"
        Me.colEProcedimientos.Visible = True
        Me.colEProcedimientos.VisibleIndex = 1
        Me.colEProcedimientos.Width = 1116
        '
        'btnAgregarLaboratorios
        '
        Me.btnAgregarLaboratorios.ImageOptions.Image = CType(resources.GetObject("btnAgregarLaboratorios.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarLaboratorios.Location = New System.Drawing.Point(568, 32)
        Me.btnAgregarLaboratorios.Name = "btnAgregarLaboratorios"
        Me.btnAgregarLaboratorios.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarLaboratorios.TabIndex = 87
        Me.btnAgregarLaboratorios.Text = "Agregar Examenes y Laboratorios"
        '
        'cmdImprimirLaboratorio
        '
        Me.cmdImprimirLaboratorio.ImageOptions.Image = CType(resources.GetObject("cmdImprimirLaboratorio.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimirLaboratorio.Location = New System.Drawing.Point(632, 109)
        Me.cmdImprimirLaboratorio.Name = "cmdImprimirLaboratorio"
        Me.cmdImprimirLaboratorio.Size = New System.Drawing.Size(26, 23)
        Me.cmdImprimirLaboratorio.TabIndex = 40
        '
        'cmdEliminarLaboratorio
        '
        Me.cmdEliminarLaboratorio.ImageOptions.Image = CType(resources.GetObject("cmdEliminarLaboratorio.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminarLaboratorio.Location = New System.Drawing.Point(600, 109)
        Me.cmdEliminarLaboratorio.Name = "cmdEliminarLaboratorio"
        Me.cmdEliminarLaboratorio.Size = New System.Drawing.Size(26, 23)
        Me.cmdEliminarLaboratorio.TabIndex = 39
        '
        'cmdAgregarLaboratorio
        '
        Me.cmdAgregarLaboratorio.ImageOptions.Image = CType(resources.GetObject("cmdAgregarLaboratorio.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregarLaboratorio.Location = New System.Drawing.Point(568, 109)
        Me.cmdAgregarLaboratorio.Name = "cmdAgregarLaboratorio"
        Me.cmdAgregarLaboratorio.Size = New System.Drawing.Size(26, 23)
        Me.cmdAgregarLaboratorio.TabIndex = 38
        '
        'GCLaboratorios
        '
        Me.GCLaboratorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCLaboratorios.Location = New System.Drawing.Point(12, 138)
        Me.GCLaboratorios.MainView = Me.GVLaboratorios
        Me.GCLaboratorios.MenuManager = Me.BarManager1
        Me.GCLaboratorios.Name = "GCLaboratorios"
        Me.GCLaboratorios.Size = New System.Drawing.Size(646, 231)
        Me.GCLaboratorios.TabIndex = 79
        Me.GCLaboratorios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLaboratorios})
        '
        'GVLaboratorios
        '
        Me.GVLaboratorios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExaCups, Me.colExaExamen, Me.colExaDescripcion})
        Me.GVLaboratorios.GridControl = Me.GCLaboratorios
        Me.GVLaboratorios.Name = "GVLaboratorios"
        Me.GVLaboratorios.OptionsBehavior.Editable = False
        Me.GVLaboratorios.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVLaboratorios.OptionsCustomization.AllowRowSizing = True
        Me.GVLaboratorios.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVLaboratorios.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVLaboratorios.OptionsView.RowAutoHeight = True
        Me.GVLaboratorios.OptionsView.ShowFooter = True
        Me.GVLaboratorios.OptionsView.ShowGroupPanel = False
        '
        'colExaCups
        '
        Me.colExaCups.Caption = "CUPS"
        Me.colExaCups.FieldName = "CUPS"
        Me.colExaCups.Name = "colExaCups"
        Me.colExaCups.Visible = True
        Me.colExaCups.VisibleIndex = 0
        Me.colExaCups.Width = 67
        '
        'colExaExamen
        '
        Me.colExaExamen.Caption = "EXAMEN"
        Me.colExaExamen.FieldName = "EXAMEN"
        Me.colExaExamen.Name = "colExaExamen"
        Me.colExaExamen.Visible = True
        Me.colExaExamen.VisibleIndex = 1
        Me.colExaExamen.Width = 290
        '
        'colExaDescripcion
        '
        Me.colExaDescripcion.Caption = "DESCRIPCION"
        Me.colExaDescripcion.FieldName = "DESCRIPCION"
        Me.colExaDescripcion.Name = "colExaDescripcion"
        Me.colExaDescripcion.Visible = True
        Me.colExaDescripcion.VisibleIndex = 2
        Me.colExaDescripcion.Width = 271
        '
        'txtDescripcionLaboratorios
        '
        Me.txtDescripcionLaboratorios.Location = New System.Drawing.Point(12, 79)
        Me.txtDescripcionLaboratorios.MenuManager = Me.BarManager1
        Me.txtDescripcionLaboratorios.Name = "txtDescripcionLaboratorios"
        Me.txtDescripcionLaboratorios.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcionLaboratorios.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcionLaboratorios.Size = New System.Drawing.Size(550, 53)
        Me.txtDescripcionLaboratorios.TabIndex = 37
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl34.TabIndex = 78
        Me.LabelControl34.Text = "Descripción "
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl35.TabIndex = 76
        Me.LabelControl35.Text = "Examenes y Laboratorios"
        '
        'xtpProcedimientos
        '
        Me.xtpProcedimientos.Controls.Add(Me.cboProcedimientos)
        Me.xtpProcedimientos.Controls.Add(Me.btnAgregarProcedimientos)
        Me.xtpProcedimientos.Controls.Add(Me.cmdImprimirProcedimiento)
        Me.xtpProcedimientos.Controls.Add(Me.cmdEliminarProcedimiento)
        Me.xtpProcedimientos.Controls.Add(Me.cmdAgregarProcedimiento)
        Me.xtpProcedimientos.Controls.Add(Me.GCProcedimientos)
        Me.xtpProcedimientos.Controls.Add(Me.txtDescripcionProcedimientos)
        Me.xtpProcedimientos.Controls.Add(Me.LabelControl36)
        Me.xtpProcedimientos.Controls.Add(Me.LabelControl37)
        Me.xtpProcedimientos.Name = "xtpProcedimientos"
        Me.xtpProcedimientos.Size = New System.Drawing.Size(667, 402)
        Me.xtpProcedimientos.Text = "Procedimientos"
        '
        'cboProcedimientos
        '
        Me.cboProcedimientos.EditValue = ""
        Me.cboProcedimientos.Location = New System.Drawing.Point(12, 33)
        Me.cboProcedimientos.Name = "cboProcedimientos"
        Me.cboProcedimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcedimientos.Properties.PopupView = Me.gvProcedimientoCombo
        Me.cboProcedimientos.Size = New System.Drawing.Size(550, 20)
        Me.cboProcedimientos.TabIndex = 89
        '
        'gvProcedimientoCombo
        '
        Me.gvProcedimientoCombo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPCodigo, Me.colPProcedimiento})
        Me.gvProcedimientoCombo.DetailHeight = 200
        Me.gvProcedimientoCombo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvProcedimientoCombo.Name = "gvProcedimientoCombo"
        Me.gvProcedimientoCombo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvProcedimientoCombo.OptionsView.ShowGroupPanel = False
        '
        'colPCodigo
        '
        Me.colPCodigo.Caption = "CODIGO"
        Me.colPCodigo.FieldName = "CODIGO"
        Me.colPCodigo.Name = "colPCodigo"
        Me.colPCodigo.Visible = True
        Me.colPCodigo.VisibleIndex = 0
        Me.colPCodigo.Width = 150
        '
        'colPProcedimiento
        '
        Me.colPProcedimiento.Caption = "PROCEDIMIENTO"
        Me.colPProcedimiento.FieldName = "PROCEDIMIENTOS"
        Me.colPProcedimiento.Name = "colPProcedimiento"
        Me.colPProcedimiento.Visible = True
        Me.colPProcedimiento.VisibleIndex = 1
        Me.colPProcedimiento.Width = 1054
        '
        'btnAgregarProcedimientos
        '
        Me.btnAgregarProcedimientos.ImageOptions.Image = CType(resources.GetObject("btnAgregarProcedimientos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarProcedimientos.Location = New System.Drawing.Point(568, 31)
        Me.btnAgregarProcedimientos.Name = "btnAgregarProcedimientos"
        Me.btnAgregarProcedimientos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarProcedimientos.TabIndex = 88
        Me.btnAgregarProcedimientos.Text = "Agregar Procedimientos"
        '
        'cmdImprimirProcedimiento
        '
        Me.cmdImprimirProcedimiento.ImageOptions.Image = CType(resources.GetObject("cmdImprimirProcedimiento.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimirProcedimiento.Location = New System.Drawing.Point(632, 109)
        Me.cmdImprimirProcedimiento.Name = "cmdImprimirProcedimiento"
        Me.cmdImprimirProcedimiento.Size = New System.Drawing.Size(26, 23)
        Me.cmdImprimirProcedimiento.TabIndex = 84
        '
        'cmdEliminarProcedimiento
        '
        Me.cmdEliminarProcedimiento.ImageOptions.Image = CType(resources.GetObject("cmdEliminarProcedimiento.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminarProcedimiento.Location = New System.Drawing.Point(600, 109)
        Me.cmdEliminarProcedimiento.Name = "cmdEliminarProcedimiento"
        Me.cmdEliminarProcedimiento.Size = New System.Drawing.Size(26, 23)
        Me.cmdEliminarProcedimiento.TabIndex = 83
        '
        'cmdAgregarProcedimiento
        '
        Me.cmdAgregarProcedimiento.ImageOptions.Image = CType(resources.GetObject("cmdAgregarProcedimiento.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregarProcedimiento.Location = New System.Drawing.Point(568, 109)
        Me.cmdAgregarProcedimiento.Name = "cmdAgregarProcedimiento"
        Me.cmdAgregarProcedimiento.Size = New System.Drawing.Size(26, 23)
        Me.cmdAgregarProcedimiento.TabIndex = 82
        '
        'GCProcedimientos
        '
        Me.GCProcedimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCProcedimientos.Location = New System.Drawing.Point(12, 138)
        Me.GCProcedimientos.MainView = Me.GVProcedimientos
        Me.GCProcedimientos.MenuManager = Me.BarManager1
        Me.GCProcedimientos.Name = "GCProcedimientos"
        Me.GCProcedimientos.Size = New System.Drawing.Size(646, 231)
        Me.GCProcedimientos.TabIndex = 87
        Me.GCProcedimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProcedimientos})
        '
        'GVProcedimientos
        '
        Me.GVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProCups, Me.colProProcedimiento, Me.colProDescripcion})
        Me.GVProcedimientos.GridControl = Me.GCProcedimientos
        Me.GVProcedimientos.Name = "GVProcedimientos"
        Me.GVProcedimientos.OptionsBehavior.Editable = False
        Me.GVProcedimientos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVProcedimientos.OptionsCustomization.AllowRowSizing = True
        Me.GVProcedimientos.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVProcedimientos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVProcedimientos.OptionsView.RowAutoHeight = True
        Me.GVProcedimientos.OptionsView.ShowFooter = True
        Me.GVProcedimientos.OptionsView.ShowGroupPanel = False
        '
        'colProCups
        '
        Me.colProCups.Caption = "CUPS"
        Me.colProCups.FieldName = "CUPS"
        Me.colProCups.Name = "colProCups"
        Me.colProCups.Visible = True
        Me.colProCups.VisibleIndex = 0
        '
        'colProProcedimiento
        '
        Me.colProProcedimiento.Caption = "PROCEDIMIENTO"
        Me.colProProcedimiento.FieldName = "PROCEDIMIENTO"
        Me.colProProcedimiento.Name = "colProProcedimiento"
        Me.colProProcedimiento.Visible = True
        Me.colProProcedimiento.VisibleIndex = 1
        Me.colProProcedimiento.Width = 634
        '
        'colProDescripcion
        '
        Me.colProDescripcion.Caption = "DESCRIPCION"
        Me.colProDescripcion.FieldName = "DESCRIPCION"
        Me.colProDescripcion.Name = "colProDescripcion"
        Me.colProDescripcion.Visible = True
        Me.colProDescripcion.VisibleIndex = 2
        Me.colProDescripcion.Width = 495
        '
        'txtDescripcionProcedimientos
        '
        Me.txtDescripcionProcedimientos.Location = New System.Drawing.Point(12, 79)
        Me.txtDescripcionProcedimientos.MenuManager = Me.BarManager1
        Me.txtDescripcionProcedimientos.Name = "txtDescripcionProcedimientos"
        Me.txtDescripcionProcedimientos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcionProcedimientos.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcionProcedimientos.Size = New System.Drawing.Size(550, 53)
        Me.txtDescripcionProcedimientos.TabIndex = 81
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl36.TabIndex = 86
        Me.LabelControl36.Text = "Descripción "
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl37.TabIndex = 85
        Me.LabelControl37.Text = "Procedimientos e Imagenes"
        '
        'xtpCurvaCrecimiento
        '
        Me.xtpCurvaCrecimiento.Controls.Add(Me.XtraTabControl3)
        Me.xtpCurvaCrecimiento.Name = "xtpCurvaCrecimiento"
        Me.xtpCurvaCrecimiento.Size = New System.Drawing.Size(667, 402)
        Me.xtpCurvaCrecimiento.Text = "Curva de Crecimiento"
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl3.Location = New System.Drawing.Point(7, 8)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl3.Size = New System.Drawing.Size(651, 390)
        Me.XtraTabControl3.TabIndex = 1
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.CCPercentilTalla)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(645, 362)
        Me.XtraTabPage3.Text = "Talla"
        '
        'CCPercentilTalla
        '
        XyDiagram3.AxisX.Title.Text = "Edad"
        XyDiagram3.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisX.VisualRange.Auto = False
        XyDiagram3.AxisX.VisualRange.MaxValueSerializable = "18"
        XyDiagram3.AxisX.VisualRange.MinValueSerializable = "2"
        XyDiagram3.AxisX.WholeRange.Auto = False
        XyDiagram3.AxisX.WholeRange.MaxValueSerializable = "18"
        XyDiagram3.AxisX.WholeRange.MinValueSerializable = "2"
        XyDiagram3.AxisY.Title.Text = "Talla (cm)"
        XyDiagram3.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.VisualRange.Auto = False
        XyDiagram3.AxisY.VisualRange.MaxValueSerializable = "200"
        XyDiagram3.AxisY.VisualRange.MinValueSerializable = "20"
        XyDiagram3.AxisY.WholeRange.Auto = False
        XyDiagram3.AxisY.WholeRange.MaxValueSerializable = "200"
        XyDiagram3.AxisY.WholeRange.MinValueSerializable = "20"
        Me.CCPercentilTalla.Diagram = XyDiagram3
        Me.CCPercentilTalla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCPercentilTalla.Legend.Name = "Default Legend"
        Me.CCPercentilTalla.Legend.Title.Text = ""
        Me.CCPercentilTalla.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.CCPercentilTalla.Location = New System.Drawing.Point(0, 0)
        Me.CCPercentilTalla.Name = "CCPercentilTalla"
        Series3.Name = "NIÑO"
        SeriesPoint3.ColorSerializable = "Red"
        Series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint3})
        LineSeriesView3.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.View = LineSeriesView3
        Me.CCPercentilTalla.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.CCPercentilTalla.Size = New System.Drawing.Size(645, 362)
        Me.CCPercentilTalla.TabIndex = 1
        ChartTitle3.Text = "Curva de Crecimiento Altura"
        Me.CCPercentilTalla.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.CCPercentilPeso)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(645, 362)
        Me.XtraTabPage4.Text = "Peso"
        '
        'CCPercentilPeso
        '
        XyDiagram4.AxisX.Title.Text = "Edad"
        XyDiagram4.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisX.VisualRange.Auto = False
        XyDiagram4.AxisX.VisualRange.MaxValueSerializable = "18"
        XyDiagram4.AxisX.VisualRange.MinValueSerializable = "2"
        XyDiagram4.AxisX.WholeRange.Auto = False
        XyDiagram4.AxisX.WholeRange.MaxValueSerializable = "18"
        XyDiagram4.AxisX.WholeRange.MinValueSerializable = "2"
        XyDiagram4.AxisY.Title.Text = "Peso (Kg)"
        XyDiagram4.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.VisualRange.Auto = False
        XyDiagram4.AxisY.VisualRange.MaxValueSerializable = "100"
        XyDiagram4.AxisY.VisualRange.MinValueSerializable = "10"
        XyDiagram4.AxisY.WholeRange.Auto = False
        XyDiagram4.AxisY.WholeRange.MaxValueSerializable = "100"
        XyDiagram4.AxisY.WholeRange.MinValueSerializable = "10"
        Me.CCPercentilPeso.Diagram = XyDiagram4
        Me.CCPercentilPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCPercentilPeso.Legend.Name = "Default Legend"
        Me.CCPercentilPeso.Legend.Title.Text = ""
        Me.CCPercentilPeso.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.CCPercentilPeso.Location = New System.Drawing.Point(0, 0)
        Me.CCPercentilPeso.Name = "CCPercentilPeso"
        Series4.Name = "NIÑO"
        Series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint4})
        LineSeriesView4.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView4.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.View = LineSeriesView4
        Me.CCPercentilPeso.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.CCPercentilPeso.Size = New System.Drawing.Size(645, 362)
        Me.CCPercentilPeso.TabIndex = 2
        ChartTitle4.Text = "Curva de Crecimiento Peso"
        Me.CCPercentilPeso.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.Location = New System.Drawing.Point(8, 29)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(606, 20)
        Me.SeparatorControl1.TabIndex = 42
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(624, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl3.TabIndex = 41
        Me.LabelControl3.Text = "Antecedentes"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 46)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Datos de Paciente:"
        '
        'txtDatosUsuario
        '
        Me.txtDatosUsuario.Location = New System.Drawing.Point(10, 64)
        Me.txtDatosUsuario.MenuManager = Me.BarManager1
        Me.txtDatosUsuario.Name = "txtDatosUsuario"
        Me.txtDatosUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDatosUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtDatosUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtDatosUsuario.Properties.ReadOnly = True
        Me.txtDatosUsuario.Size = New System.Drawing.Size(604, 87)
        Me.txtDatosUsuario.TabIndex = 34
        '
        'lblConsecutivoOrden
        '
        Me.lblConsecutivoOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivoOrden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConsecutivoOrden.Appearance.Options.UseFont = True
        Me.lblConsecutivoOrden.Appearance.Options.UseForeColor = True
        Me.lblConsecutivoOrden.Location = New System.Drawing.Point(244, 8)
        Me.lblConsecutivoOrden.Name = "lblConsecutivoOrden"
        Me.lblConsecutivoOrden.Size = New System.Drawing.Size(8, 16)
        Me.lblConsecutivoOrden.TabIndex = 17
        Me.lblConsecutivoOrden.Text = "1"
        Me.lblConsecutivoOrden.Visible = False
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivo.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConsecutivo.Appearance.Options.UseFont = True
        Me.lblConsecutivo.Appearance.Options.UseForeColor = True
        Me.lblConsecutivo.Location = New System.Drawing.Point(273, 8)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(8, 16)
        Me.lblConsecutivo.TabIndex = 16
        Me.lblConsecutivo.Text = "1"
        Me.lblConsecutivo.Visible = False
        '
        'txtNumeroHistoria
        '
        Me.txtNumeroHistoria.Location = New System.Drawing.Point(425, 6)
        Me.txtNumeroHistoria.MenuManager = Me.BarManager1
        Me.txtNumeroHistoria.Name = "txtNumeroHistoria"
        Me.txtNumeroHistoria.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroHistoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroHistoria.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroHistoria.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroHistoria.Properties.ReadOnly = True
        Me.txtNumeroHistoria.Size = New System.Drawing.Size(189, 22)
        Me.txtNumeroHistoria.TabIndex = 12
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(324, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Codigo de Historia:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Fecha:"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.EditValue = Nothing
        Me.dtFechaIngreso.Location = New System.Drawing.Point(47, 5)
        Me.dtFechaIngreso.MenuManager = Me.BarManager1
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.ReadOnly = True
        Me.dtFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaIngreso.TabIndex = 0
        '
        'bwNuevo
        '
        Me.bwNuevo.WorkerReportsProgress = True
        Me.bwNuevo.WorkerSupportsCancellation = True
        '
        'bwLoad
        '
        '
        'bwGuardar
        '
        '
        'frmHistoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 604)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHistoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historia Clinica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.txtAntecedentesFamiliares2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.txtAntecedentesPersonales2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcDatosHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcDatosHistoria.ResumeLayout(False)
        Me.xtpMotivoConsulta.ResumeLayout(False)
        Me.xtpMotivoConsulta.PerformLayout()
        CType(Me.txtResponsables.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpEnfermedadActual.ResumeLayout(False)
        Me.xtpEnfermedadActual.PerformLayout()
        CType(Me.txtEnfermedadActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAntecedentes.ResumeLayout(False)
        Me.xtpAntecedentes.PerformLayout()
        CType(Me.txtAntecedentesPersonales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAntecedentesFamiliares.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpExamenFisico.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage14.ResumeLayout(False)
        Me.XtraTabPage14.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.cboEscalaPrader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cboTesticuloDER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTesticuloIZQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMeathusUretral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMicroPene.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFusionEscrotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTalla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIMC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtLP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemperatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIMC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage15.ResumeLayout(False)
        Me.XtraTabPage15.PerformLayout()
        CType(Me.GCRevisionSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRevisionSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionRevisionSistemas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRevisionSistema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDiagnostico.ResumeLayout(False)
        Me.xtpDiagnostico.PerformLayout()
        CType(Me.cboDiagnosticos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionDiagnostico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPlanSeguir.ResumeLayout(False)
        Me.xtpPlanSeguir.PerformLayout()
        CType(Me.txtPlanSeguir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpRecomendaciones.ResumeLayout(False)
        Me.xtpRecomendaciones.PerformLayout()
        CType(Me.txtRecomendaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFormulacion.ResumeLayout(False)
        Me.xtpFormulacion.PerformLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboViaAdministracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDosis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionMedicamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedicamentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpLaboratorios.ResumeLayout(False)
        Me.xtpLaboratorios.PerformLayout()
        CType(Me.cboLaboratorios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionLaboratorios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpProcedimientos.ResumeLayout(False)
        Me.xtpProcedimientos.PerformLayout()
        CType(Me.cboProcedimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProcedimientoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionProcedimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCurvaCrecimiento.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCPercentilTalla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCPercentilPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroHistoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumeroHistoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCPacientesAtender As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPacientesAtender As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblConsecutivo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblConsecutivoOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCHistoriasAnteriores As DevExpress.XtraGrid.GridControl
    Friend WithEvents btVistaPrevia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatosUsuario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents gvHistoriasAnteriores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEnero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFebrero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMarzo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAbril As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMayo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiJunio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiJulio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAgosto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSeptiembre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOctubre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNoviembre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDiciembre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcDatosHistoria As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpEnfermedadActual As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpMotivoConsulta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpAntecedentes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpExamenFisico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDiagnostico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpPlanSeguir As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpRecomendaciones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpLaboratorios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpFormulacion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEnfermedadActual As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtResponsables As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivoConsulta As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAntecedentesFamiliares As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage14 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage15 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTemperatura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIMC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboVT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboB As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPlanSeguir As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRecomendaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdImprimirMedicamentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboViaAdministracion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDosis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEliminarMedicamentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarMedicamentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCMedicamentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMedicamentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcionMedicamento As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMedicamentos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdImprimirLaboratorio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminarLaboratorio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarLaboratorio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCLaboratorios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLaboratorios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcionLaboratorios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPACIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpProcedimientos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdImprimirProcedimiento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminarProcedimiento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarProcedimiento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCProcedimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcionProcedimientos As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAntecedentesPersonales As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAntecedentesFamiliares2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAntecedentesPersonales2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpCurvaCrecimiento As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CCPercentilTalla As DevExpress.XtraCharts.ChartControl
    Friend WithEvents CCPercentilPeso As DevExpress.XtraCharts.ChartControl
    Friend WithEvents cmdEliminarRevisionSistemas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarRevisionSistemas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCRevisionSistema As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRevisionSistema As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcionRevisionSistemas As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRevisionSistema As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEliminarDiagnostico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarDiagnostico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDiagnosticos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDiagnosticos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcionDiagnostico As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorIMC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnActualizarDiagnosticos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMedicamentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarLaboratorios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarProcedimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ppCargar As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents cboDiagnosticos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboLaboratorios As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents co As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEProcedimientos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboProcedimientos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvProcedimientoCombo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPProcedimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProProcedimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExaCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExaExamen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExaDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaDiagnostico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPeso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTalla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bwNuevo As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwGuardar As System.ComponentModel.BackgroundWorker
    Friend WithEvents colHAOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAMotivoConsulta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDICAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOSIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblIdDetalleOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboTesticuloDER As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTesticuloIZQ As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMeathusUretral As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMicroPene As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFusionEscrotal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboEscalaPrader As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents peImagen As DevExpress.XtraEditors.PictureEdit
End Class

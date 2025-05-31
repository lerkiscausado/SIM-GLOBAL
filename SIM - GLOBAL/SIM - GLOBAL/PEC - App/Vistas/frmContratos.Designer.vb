<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratos))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl18 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl19 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl20 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImpresion = New DevExpress.XtraBars.BarSubItem()
        Me.bbiPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl12 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl13 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl14 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl16 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl15 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.BarDockControl17 = New DevExpress.XtraBars.BarDockControl()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.xtcPatologia = New DevExpress.XtraTab.XtraTabControl()
        Me.xtContratos = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMERO_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtRegistroContratos = New DevExpress.XtraTab.XtraTabPage()
        Me.btnAgregarSede = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarSede = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSedes = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcClientesSedes = New DevExpress.XtraGrid.GridControl()
        Me.gvClientesSedes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIUDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.dtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.txtCorreoElectronico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.cboTarifa = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefeno = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroContrato = New DevExpress.XtraEditors.TextEdit()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContacto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        CType(Me.xtcPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcPatologia.SuspendLayout()
        Me.xtContratos.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtRegistroContratos.SuspendLayout()
        CType(Me.cboSedes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcClientesSedes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvClientesSedes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 11
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.BarDockControl18)
        Me.BarManager1.DockControls.Add(Me.BarDockControl19)
        Me.BarManager1.DockControls.Add(Me.BarDockControl20)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiImpresion, Me.bbiPrint, Me.bbiExcel, Me.bbiPDF, Me.bbiCancelar, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 12
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiCancelar
        '
        Me.bbiCancelar.Caption = "Cancelar Orden"
        Me.bbiCancelar.Id = 9
        Me.bbiCancelar.ImageOptions.Image = CType(resources.GetObject("bbiCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCancelar.Name = "bbiCancelar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 3
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(947, 24)
        '
        'BarDockControl18
        '
        Me.BarDockControl18.CausesValidation = False
        Me.BarDockControl18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl18.Location = New System.Drawing.Point(0, 462)
        Me.BarDockControl18.Manager = Me.BarManager1
        Me.BarDockControl18.Size = New System.Drawing.Size(947, 0)
        '
        'BarDockControl19
        '
        Me.BarDockControl19.CausesValidation = False
        Me.BarDockControl19.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl19.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl19.Manager = Me.BarManager1
        Me.BarDockControl19.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl20
        '
        Me.BarDockControl20.CausesValidation = False
        Me.BarDockControl20.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl20.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl20.Manager = Me.BarManager1
        Me.BarDockControl20.Size = New System.Drawing.Size(0, 438)
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'bbiImpresion
        '
        Me.bbiImpresion.Caption = "Imprimir"
        Me.bbiImpresion.Id = 5
        Me.bbiImpresion.ImageOptions.Image = CType(resources.GetObject("bbiImpresion.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImpresion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPDF)})
        Me.bbiImpresion.Name = "bbiImpresion"
        Me.bbiImpresion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "Listado Clientes"
        Me.bbiPrint.Id = 6
        Me.bbiPrint.ImageOptions.Image = CType(resources.GetObject("bbiPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiExcel
        '
        Me.bbiExcel.Caption = "Exportar Excel"
        Me.bbiExcel.Id = 7
        Me.bbiExcel.ImageOptions.Image = CType(resources.GetObject("bbiExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExcel.Name = "bbiExcel"
        '
        'bbiPDF
        '
        Me.bbiPDF.Caption = "Exportar PDF"
        Me.bbiPDF.Id = 8
        Me.bbiPDF.ImageOptions.Image = CType(resources.GetObject("bbiPDF.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPDF.Name = "bbiPDF"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bwCargar
        '
        Me.bwCargar.WorkerReportsProgress = True
        Me.bwCargar.WorkerSupportsCancellation = True
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl6.Manager = Nothing
        Me.BarDockControl6.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl7.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl7.Manager = Nothing
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl11.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl11.Manager = Nothing
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl10.Manager = Nothing
        Me.BarDockControl10.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl12
        '
        Me.BarDockControl12.CausesValidation = False
        Me.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl12.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl12.Manager = Nothing
        Me.BarDockControl12.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 462)
        Me.BarDockControl9.Manager = Nothing
        Me.BarDockControl9.Size = New System.Drawing.Size(947, 0)
        '
        'BarDockControl13
        '
        Me.BarDockControl13.CausesValidation = False
        Me.BarDockControl13.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl13.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl13.Manager = Nothing
        Me.BarDockControl13.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl14
        '
        Me.BarDockControl14.CausesValidation = False
        Me.BarDockControl14.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl14.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl14.Manager = Nothing
        Me.BarDockControl14.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl8.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl8.Manager = Nothing
        Me.BarDockControl8.Size = New System.Drawing.Size(947, 0)
        '
        'BarDockControl16
        '
        Me.BarDockControl16.CausesValidation = False
        Me.BarDockControl16.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl16.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl16.Manager = Nothing
        Me.BarDockControl16.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 462)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(947, 0)
        '
        'BarDockControl15
        '
        Me.BarDockControl15.CausesValidation = False
        Me.BarDockControl15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl15.Location = New System.Drawing.Point(0, 462)
        Me.BarDockControl15.Manager = Nothing
        Me.BarDockControl15.Size = New System.Drawing.Size(947, 0)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl2.Manager = Nothing
        Me.BarDockControl2.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(947, 24)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 462)
        Me.BarDockControl3.Manager = Nothing
        Me.BarDockControl3.Size = New System.Drawing.Size(947, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl4.Manager = Nothing
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 438)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl5.Manager = Nothing
        Me.BarDockControl5.Size = New System.Drawing.Size(947, 0)
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(-125, 231)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 230
        Me.LabelControl6.Text = "Comentarios"
        '
        'BarDockControl17
        '
        Me.BarDockControl17.CausesValidation = False
        Me.BarDockControl17.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl17.Location = New System.Drawing.Point(947, 24)
        Me.BarDockControl17.Manager = Nothing
        Me.BarDockControl17.Size = New System.Drawing.Size(0, 438)
        '
        'tsmExportarPDF
        '
        Me.tsmExportarPDF.Image = CType(resources.GetObject("tsmExportarPDF.Image"), System.Drawing.Image)
        Me.tsmExportarPDF.Name = "tsmExportarPDF"
        Me.tsmExportarPDF.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarPDF.Text = "Exportar Listado  a PDF"
        '
        'tsmExportarExcel
        '
        Me.tsmExportarExcel.Image = CType(resources.GetObject("tsmExportarExcel.Image"), System.Drawing.Image)
        Me.tsmExportarExcel.Name = "tsmExportarExcel"
        Me.tsmExportarExcel.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarExcel.Text = "Exportar Listado a Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(198, 22)
        Me.tsmImprimir.Text = "Imprimir Listado"
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(199, 76)
        '
        'xtcPatologia
        '
        Me.xtcPatologia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcPatologia.Location = New System.Drawing.Point(12, 39)
        Me.xtcPatologia.Name = "xtcPatologia"
        Me.xtcPatologia.SelectedTabPage = Me.xtContratos
        Me.xtcPatologia.Size = New System.Drawing.Size(923, 420)
        Me.xtcPatologia.TabIndex = 437
        Me.xtcPatologia.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtContratos, Me.xtRegistroContratos})
        '
        'xtContratos
        '
        Me.xtContratos.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xtContratos.Appearance.Header.Options.UseFont = True
        Me.xtContratos.Controls.Add(Me.GCConsultar)
        Me.xtContratos.Name = "xtContratos"
        Me.xtContratos.Size = New System.Drawing.Size(921, 392)
        Me.xtContratos.Text = "Contratos"
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(921, 392)
        Me.GCConsultar.TabIndex = 307
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCONTRATO, Me.colNUMERO_CONTRATO, Me.colFECHA_INICIO, Me.colENTIDAD, Me.colTARIFA})
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "I"
        FormatConditionRuleValue1.Value1 = "I"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVConsultar.FormatRules.Add(GridFormatRule1)
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 42
        '
        'colCONTRATO
        '
        Me.colCONTRATO.Caption = "CONTRATO"
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 0
        Me.colCONTRATO.Width = 202
        '
        'colNUMERO_CONTRATO
        '
        Me.colNUMERO_CONTRATO.Caption = "NUMERO"
        Me.colNUMERO_CONTRATO.FieldName = "NUMERO"
        Me.colNUMERO_CONTRATO.Name = "colNUMERO_CONTRATO"
        Me.colNUMERO_CONTRATO.Visible = True
        Me.colNUMERO_CONTRATO.VisibleIndex = 1
        Me.colNUMERO_CONTRATO.Width = 83
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "FECHA"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 2
        Me.colFECHA_INICIO.Width = 71
        '
        'colENTIDAD
        '
        Me.colENTIDAD.Caption = "CLIENTE"
        Me.colENTIDAD.FieldName = "CLIENTE"
        Me.colENTIDAD.Name = "colENTIDAD"
        Me.colENTIDAD.Visible = True
        Me.colENTIDAD.VisibleIndex = 3
        Me.colENTIDAD.Width = 278
        '
        'colTARIFA
        '
        Me.colTARIFA.Caption = "TARIFA"
        Me.colTARIFA.FieldName = "TARIFA"
        Me.colTARIFA.Name = "colTARIFA"
        Me.colTARIFA.Visible = True
        Me.colTARIFA.VisibleIndex = 4
        Me.colTARIFA.Width = 238
        '
        'xtRegistroContratos
        '
        Me.xtRegistroContratos.Controls.Add(Me.btnAgregarSede)
        Me.xtRegistroContratos.Controls.Add(Me.btnEliminarSede)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl8)
        Me.xtRegistroContratos.Controls.Add(Me.cboSedes)
        Me.xtRegistroContratos.Controls.Add(Me.gcClientesSedes)
        Me.xtRegistroContratos.Controls.Add(Me.txtID)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl1)
        Me.xtRegistroContratos.Controls.Add(Me.SeparatorControl4)
        Me.xtRegistroContratos.Controls.Add(Me.SeparatorControl3)
        Me.xtRegistroContratos.Controls.Add(Me.SeparatorControl1)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl18)
        Me.xtRegistroContratos.Controls.Add(Me.txtObservaciones)
        Me.xtRegistroContratos.Controls.Add(Me.dtFechaFinal)
        Me.xtRegistroContratos.Controls.Add(Me.txtCorreoElectronico)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl16)
        Me.xtRegistroContratos.Controls.Add(Me.dtFechaInicio)
        Me.xtRegistroContratos.Controls.Add(Me.cboTarifa)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl12)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl3)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl9)
        Me.xtRegistroContratos.Controls.Add(Me.cboCliente)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl5)
        Me.xtRegistroContratos.Controls.Add(Me.txtTelefeno)
        Me.xtRegistroContratos.Controls.Add(Me.txtNumeroContrato)
        Me.xtRegistroContratos.Controls.Add(Me.chkEstado)
        Me.xtRegistroContratos.Controls.Add(Me.txtNombre)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl11)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl4)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl7)
        Me.xtRegistroContratos.Controls.Add(Me.txtContacto)
        Me.xtRegistroContratos.Controls.Add(Me.LabelControl10)
        Me.xtRegistroContratos.Name = "xtRegistroContratos"
        Me.xtRegistroContratos.Size = New System.Drawing.Size(921, 392)
        Me.xtRegistroContratos.Text = "Registro de Contratos"
        '
        'btnAgregarSede
        '
        Me.btnAgregarSede.ImageOptions.Image = CType(resources.GetObject("btnAgregarSede.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarSede.Location = New System.Drawing.Point(452, 210)
        Me.btnAgregarSede.Name = "btnAgregarSede"
        Me.btnAgregarSede.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarSede.TabIndex = 443
        '
        'btnEliminarSede
        '
        Me.btnEliminarSede.ImageOptions.Image = CType(resources.GetObject("btnEliminarSede.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarSede.Location = New System.Drawing.Point(481, 210)
        Me.btnEliminarSede.Name = "btnEliminarSede"
        Me.btnEliminarSede.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminarSede.TabIndex = 444
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 215)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl8.TabIndex = 442
        Me.LabelControl8.Text = "Sedes"
        '
        'cboSedes
        '
        Me.cboSedes.Location = New System.Drawing.Point(112, 212)
        Me.cboSedes.MenuManager = Me.BarManager1
        Me.cboSedes.Name = "cboSedes"
        Me.cboSedes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSedes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSedes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CIUDAD", "CIUDAD")})
        Me.cboSedes.Properties.NullText = ""
        Me.cboSedes.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboSedes.Properties.PopupSizeable = False
        Me.cboSedes.Properties.ShowHeader = False
        Me.cboSedes.Size = New System.Drawing.Size(328, 20)
        Me.cboSedes.TabIndex = 441
        '
        'gcClientesSedes
        '
        Me.gcClientesSedes.Location = New System.Drawing.Point(14, 238)
        Me.gcClientesSedes.MainView = Me.gvClientesSedes
        Me.gcClientesSedes.MenuManager = Me.BarManager1
        Me.gcClientesSedes.Name = "gcClientesSedes"
        Me.gcClientesSedes.Size = New System.Drawing.Size(426, 142)
        Me.gcClientesSedes.TabIndex = 440
        Me.gcClientesSedes.UseEmbeddedNavigator = True
        Me.gcClientesSedes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvClientesSedes})
        '
        'gvClientesSedes
        '
        Me.gvClientesSedes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDS, Me.colCIUDAD})
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "I"
        FormatConditionRuleValue2.Value1 = "I"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.gvClientesSedes.FormatRules.Add(GridFormatRule2)
        Me.gvClientesSedes.GridControl = Me.gcClientesSedes
        Me.gvClientesSedes.Name = "gvClientesSedes"
        Me.gvClientesSedes.OptionsBehavior.Editable = False
        Me.gvClientesSedes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvClientesSedes.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvClientesSedes.OptionsPrint.ExpandAllDetails = True
        Me.gvClientesSedes.OptionsPrint.ExpandAllGroups = False
        Me.gvClientesSedes.OptionsPrint.PrintFooter = False
        Me.gvClientesSedes.OptionsView.ColumnAutoWidth = False
        Me.gvClientesSedes.OptionsView.EnableAppearanceOddRow = True
        Me.gvClientesSedes.OptionsView.ShowGroupPanel = False
        '
        'colIDS
        '
        Me.colIDS.Caption = "ID"
        Me.colIDS.FieldName = "ID"
        Me.colIDS.Name = "colIDS"
        '
        'colCIUDAD
        '
        Me.colCIUDAD.Caption = "CIUDAD"
        Me.colCIUDAD.FieldName = "CIUDAD"
        Me.colCIUDAD.Name = "colCIUDAD"
        Me.colCIUDAD.Visible = True
        Me.colCIUDAD.VisibleIndex = 0
        Me.colCIUDAD.Width = 271
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(521, 311)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(327, 20)
        Me.txtID.TabIndex = 439
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(494, 314)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 438
        Me.LabelControl1.Text = "ID:"
        Me.LabelControl1.Visible = False
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.Location = New System.Drawing.Point(17, 194)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Size = New System.Drawing.Size(891, 18)
        Me.SeparatorControl4.TabIndex = 437
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(444, 20)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(23, 167)
        Me.SeparatorControl3.TabIndex = 436
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(481, 92)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(427, 18)
        Me.SeparatorControl1.TabIndex = 435
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(252, 72)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl18.TabIndex = 426
        Me.LabelControl18.Text = "Fecha Final:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 95)
        Me.txtObservaciones.MenuManager = Me.BarManager1
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(328, 92)
        Me.txtObservaciones.TabIndex = 418
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.EditValue = Nothing
        Me.dtFechaFinal.Location = New System.Drawing.Point(315, 69)
        Me.dtFechaFinal.MenuManager = Me.BarManager1
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Size = New System.Drawing.Size(123, 20)
        Me.dtFechaFinal.TabIndex = 417
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.EnterMoveNextControl = True
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(581, 69)
        Me.txtCorreoElectronico.MenuManager = Me.BarManager1
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Properties.Mask.EditMask = "d"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(327, 20)
        Me.txtCorreoElectronico.TabIndex = 422
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(481, 144)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl16.TabIndex = 433
        Me.LabelControl16.Text = "Tarifa"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(112, 69)
        Me.dtFechaInicio.MenuManager = Me.BarManager1
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Size = New System.Drawing.Size(134, 20)
        Me.dtFechaInicio.TabIndex = 415
        '
        'cboTarifa
        '
        Me.cboTarifa.Location = New System.Drawing.Point(580, 141)
        Me.cboTarifa.MenuManager = Me.BarManager1
        Me.cboTarifa.Name = "cboTarifa"
        Me.cboTarifa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTarifa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTarifa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TARIFA", "TARIFA")})
        Me.cboTarifa.Properties.NullText = ""
        Me.cboTarifa.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTarifa.Properties.PopupSizeable = False
        Me.cboTarifa.Size = New System.Drawing.Size(328, 20)
        Me.cboTarifa.TabIndex = 425
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(481, 72)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl12.TabIndex = 431
        Me.LabelControl12.Text = "Correo Electronico"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(481, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl3.TabIndex = 432
        Me.LabelControl3.Text = "Entidad o Cliente"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 72)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl9.TabIndex = 423
        Me.LabelControl9.Text = "Fecha de Inicio"
        '
        'cboCliente
        '
        Me.cboCliente.Location = New System.Drawing.Point(580, 115)
        Me.cboCliente.MenuManager = Me.BarManager1
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCLIENTE", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDENTIFICACION", "IDENTIFICACION"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENTE", "CLIENTE"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTACTO", "CONTACTO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TELEFONO", "TELEFONO")})
        Me.cboCliente.Properties.NullText = ""
        Me.cboCliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboCliente.Properties.PopupSizeable = False
        Me.cboCliente.Size = New System.Drawing.Size(328, 20)
        Me.cboCliente.TabIndex = 424
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 96)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl5.TabIndex = 427
        Me.LabelControl5.Text = "Observaciones"
        '
        'txtTelefeno
        '
        Me.txtTelefeno.EnterMoveNextControl = True
        Me.txtTelefeno.Location = New System.Drawing.Point(581, 43)
        Me.txtTelefeno.MenuManager = Me.BarManager1
        Me.txtTelefeno.Name = "txtTelefeno"
        Me.txtTelefeno.Size = New System.Drawing.Size(327, 20)
        Me.txtTelefeno.TabIndex = 421
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.EnterMoveNextControl = True
        Me.txtNumeroContrato.Location = New System.Drawing.Point(112, 43)
        Me.txtNumeroContrato.MenuManager = Me.BarManager1
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(326, 20)
        Me.txtNumeroContrato.TabIndex = 414
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(824, 169)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Estado"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 429
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(111, 17)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Mask.EditMask = "d"
        Me.txtNombre.Size = New System.Drawing.Size(327, 20)
        Me.txtNombre.TabIndex = 413
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(481, 46)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl11.TabIndex = 430
        Me.LabelControl11.Text = "Telefono"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 20)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 416
        Me.LabelControl4.Text = "Nombre Contrato"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 419
        Me.LabelControl7.Text = "Numero"
        '
        'txtContacto
        '
        Me.txtContacto.EnterMoveNextControl = True
        Me.txtContacto.Location = New System.Drawing.Point(581, 17)
        Me.txtContacto.MenuManager = Me.BarManager1
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Properties.Mask.EditMask = "d"
        Me.txtContacto.Size = New System.Drawing.Size(327, 20)
        Me.txtContacto.TabIndex = 420
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(481, 20)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl10.TabIndex = 428
        Me.LabelControl10.Text = "Contacto"
        '
        'frmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 462)
        Me.Controls.Add(Me.xtcPatologia)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl12)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Controls.Add(Me.BarDockControl13)
        Me.Controls.Add(Me.BarDockControl14)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl16)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl15)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl17)
        Me.Controls.Add(Me.BarDockControl19)
        Me.Controls.Add(Me.BarDockControl20)
        Me.Controls.Add(Me.BarDockControl18)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmContratos.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Contratos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.xtcPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcPatologia.ResumeLayout(False)
        Me.xtContratos.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtRegistroContratos.ResumeLayout(False)
        Me.xtRegistroContratos.PerformLayout()
        CType(Me.cboSedes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcClientesSedes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvClientesSedes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl18 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl19 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl20 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl12 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl13 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl14 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl16 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl15 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl17 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImpresion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents xtcPatologia As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtContratos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIFA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtRegistroContratos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAgregarSede As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarSede As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSedes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcClientesSedes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvClientesSedes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIUDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl4 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCorreoElectronico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboTarifa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefeno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class

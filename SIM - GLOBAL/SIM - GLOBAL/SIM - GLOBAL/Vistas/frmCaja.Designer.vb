<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.xtcCaja = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpConsultarRecibos = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDRECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSECUTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpCaja = New DevExpress.XtraTab.XtraTabPage()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCambio = New DevExpress.XtraEditors.TextEdit()
        Me.lblCambio = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEfectivo = New DevExpress.XtraEditors.TextEdit()
        Me.lblValor = New DevExpress.XtraEditors.LabelControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDetallePagoDocumento = New DevExpress.XtraGrid.GridControl()
        Me.gvDetallePagoDocumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTODETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORDETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GCRecibosOrden = New DevExpress.XtraGrid.GridControl()
        Me.GVRecibosOrden = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDRECIBOORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDORDENRECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHARECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACIONORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBIDOORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTORECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORRECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADORECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADORECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSECUTIVORECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtGenerado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.txtSon = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroRecibo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCiudad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdentificacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpCierre = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.GCRecibosPendientes = New DevExpress.XtraGrid.GridControl()
        Me.GVRecibosPendientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRECIBOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDENP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBIDOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSECUTIVOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCerrarCaja = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaldoActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaldoAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaCierre = New DevExpress.XtraEditors.DateEdit()
        Me.txtElaborado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCaja.SuspendLayout()
        Me.xtpConsultarRecibos.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCaja.SuspendLayout()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEfectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCRecibosOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRecibosOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenerado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCierre.SuspendLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCRecibosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRecibosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCierre.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiAnular})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular)})
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
        Me.bbiEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 3
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'bbiAnular
        '
        Me.bbiAnular.Caption = "Anular"
        Me.bbiAnular.Id = 5
        Me.bbiAnular.Name = "bbiAnular"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(927, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(927, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 488)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(927, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 488)
        '
        'xtcCaja
        '
        Me.xtcCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCaja.Location = New System.Drawing.Point(0, 25)
        Me.xtcCaja.Name = "xtcCaja"
        Me.xtcCaja.SelectedTabPage = Me.xtpConsultarRecibos
        Me.xtcCaja.Size = New System.Drawing.Size(927, 488)
        Me.xtcCaja.TabIndex = 165
        Me.xtcCaja.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpCaja, Me.xtpConsultarRecibos, Me.xtpCierre})
        '
        'xtpConsultarRecibos
        '
        Me.xtpConsultarRecibos.Controls.Add(Me.GCConsultar)
        Me.xtpConsultarRecibos.Name = "xtpConsultarRecibos"
        Me.xtpConsultarRecibos.Size = New System.Drawing.Size(925, 463)
        Me.xtpConsultarRecibos.Text = "Consultar Recibos"
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(925, 463)
        Me.GCConsultar.TabIndex = 36
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDRECIBO, Me.colIDORDEN, Me.colFECHA, Me.colIDENTIFICACION, Me.colRECIBIDO, Me.colCONCEPTO, Me.colVALOR, Me.colELABORADO, Me.colESTADO, Me.colCONSECUTIVO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colIDRECIBO
        '
        Me.colIDRECIBO.Caption = "RECIBO"
        Me.colIDRECIBO.FieldName = "RECIBO"
        Me.colIDRECIBO.Name = "colIDRECIBO"
        Me.colIDRECIBO.Visible = True
        Me.colIDRECIBO.VisibleIndex = 0
        Me.colIDRECIBO.Width = 55
        '
        'colIDORDEN
        '
        Me.colIDORDEN.Caption = "ORDEN"
        Me.colIDORDEN.FieldName = "ORDEN"
        Me.colIDORDEN.Name = "colIDORDEN"
        Me.colIDORDEN.Visible = True
        Me.colIDORDEN.VisibleIndex = 1
        Me.colIDORDEN.Width = 59
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 3
        Me.colFECHA.Width = 68
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 4
        Me.colIDENTIFICACION.Width = 112
        '
        'colRECIBIDO
        '
        Me.colRECIBIDO.Caption = "RECIBIDO DE"
        Me.colRECIBIDO.FieldName = "RECIBIDO"
        Me.colRECIBIDO.Name = "colRECIBIDO"
        Me.colRECIBIDO.Visible = True
        Me.colRECIBIDO.VisibleIndex = 5
        Me.colRECIBIDO.Width = 204
        '
        'colCONCEPTO
        '
        Me.colCONCEPTO.Caption = "CONCEPTO"
        Me.colCONCEPTO.FieldName = "CONCEPTO"
        Me.colCONCEPTO.Name = "colCONCEPTO"
        Me.colCONCEPTO.Visible = True
        Me.colCONCEPTO.VisibleIndex = 6
        Me.colCONCEPTO.Width = 190
        '
        'colVALOR
        '
        Me.colVALOR.Caption = "VALOR"
        Me.colVALOR.DisplayFormat.FormatString = "{0:C0}"
        Me.colVALOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 7
        Me.colVALOR.Width = 83
        '
        'colELABORADO
        '
        Me.colELABORADO.Caption = "ELABORADO"
        Me.colELABORADO.FieldName = "ELABORADO"
        Me.colELABORADO.Name = "colELABORADO"
        Me.colELABORADO.Visible = True
        Me.colELABORADO.VisibleIndex = 8
        Me.colELABORADO.Width = 78
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 9
        Me.colESTADO.Width = 77
        '
        'colCONSECUTIVO
        '
        Me.colCONSECUTIVO.Caption = "CONSECUTIVO"
        Me.colCONSECUTIVO.FieldName = "CONSECUTIVO"
        Me.colCONSECUTIVO.Name = "colCONSECUTIVO"
        Me.colCONSECUTIVO.Visible = True
        Me.colCONSECUTIVO.VisibleIndex = 2
        '
        'xtpCaja
        '
        Me.xtpCaja.Controls.Add(Me.txtConsecutivo)
        Me.xtpCaja.Controls.Add(Me.LabelControl18)
        Me.xtpCaja.Controls.Add(Me.txtCambio)
        Me.xtpCaja.Controls.Add(Me.lblCambio)
        Me.xtpCaja.Controls.Add(Me.LabelControl20)
        Me.xtpCaja.Controls.Add(Me.txtEfectivo)
        Me.xtpCaja.Controls.Add(Me.lblValor)
        Me.xtpCaja.Controls.Add(Me.btnAgregar)
        Me.xtpCaja.Controls.Add(Me.btnEliminar)
        Me.xtpCaja.Controls.Add(Me.GCDetallePagoDocumento)
        Me.xtpCaja.Controls.Add(Me.cboFormaPago)
        Me.xtpCaja.Controls.Add(Me.SeparatorControl2)
        Me.xtpCaja.Controls.Add(Me.LabelControl12)
        Me.xtpCaja.Controls.Add(Me.txtOrden)
        Me.xtpCaja.Controls.Add(Me.LabelControl10)
        Me.xtpCaja.Controls.Add(Me.GCRecibosOrden)
        Me.xtpCaja.Controls.Add(Me.txtGenerado)
        Me.xtpCaja.Controls.Add(Me.LabelControl7)
        Me.xtpCaja.Controls.Add(Me.LabelControl11)
        Me.xtpCaja.Controls.Add(Me.txtValor)
        Me.xtpCaja.Controls.Add(Me.txtSon)
        Me.xtpCaja.Controls.Add(Me.txtNumeroRecibo)
        Me.xtpCaja.Controls.Add(Me.LabelControl9)
        Me.xtpCaja.Controls.Add(Me.txtConcepto)
        Me.xtpCaja.Controls.Add(Me.LabelControl8)
        Me.xtpCaja.Controls.Add(Me.SeparatorControl1)
        Me.xtpCaja.Controls.Add(Me.LabelControl6)
        Me.xtpCaja.Controls.Add(Me.dtFecha)
        Me.xtpCaja.Controls.Add(Me.txtDireccion)
        Me.xtpCaja.Controls.Add(Me.LabelControl4)
        Me.xtpCaja.Controls.Add(Me.txtCiudad)
        Me.xtpCaja.Controls.Add(Me.LabelControl3)
        Me.xtpCaja.Controls.Add(Me.txtTelefono)
        Me.xtpCaja.Controls.Add(Me.LabelControl2)
        Me.xtpCaja.Controls.Add(Me.txtIdentificacion)
        Me.xtpCaja.Controls.Add(Me.LabelControl1)
        Me.xtpCaja.Controls.Add(Me.txtNombre)
        Me.xtpCaja.Controls.Add(Me.LabelControl5)
        Me.xtpCaja.Name = "xtpCaja"
        Me.xtpCaja.Size = New System.Drawing.Size(925, 463)
        Me.xtpCaja.Text = "Caja"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(805, 110)
        Me.txtConsecutivo.MenuManager = Me.BarManager1
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtConsecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConsecutivo.Properties.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(125, 24)
        Me.txtConsecutivo.TabIndex = 252
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(736, 113)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl18.TabIndex = 253
        Me.LabelControl18.Text = "Consecutivo:"
        '
        'txtCambio
        '
        Me.txtCambio.Location = New System.Drawing.Point(307, 305)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCambio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCambio.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCambio.Properties.Appearance.Options.UseBackColor = True
        Me.txtCambio.Properties.Appearance.Options.UseFont = True
        Me.txtCambio.Properties.Appearance.Options.UseForeColor = True
        Me.txtCambio.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCambio.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtCambio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCambio.Properties.Mask.EditMask = "n0"
        Me.txtCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCambio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCambio.Properties.ReadOnly = True
        Me.txtCambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCambio.Size = New System.Drawing.Size(138, 28)
        Me.txtCambio.TabIndex = 251
        '
        'lblCambio
        '
        Me.lblCambio.Location = New System.Drawing.Point(307, 286)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(39, 13)
        Me.lblCambio.TabIndex = 250
        Me.lblCambio.Text = "Cambio:"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(14, 255)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(141, 22)
        Me.LabelControl20.TabIndex = 249
        Me.LabelControl20.Text = "Forma de Pago:"
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(148, 305)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtEfectivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEfectivo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtEfectivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtEfectivo.Properties.Appearance.Options.UseFont = True
        Me.txtEfectivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtEfectivo.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtEfectivo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEfectivo.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtEfectivo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEfectivo.Properties.Mask.EditMask = "n0"
        Me.txtEfectivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEfectivo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEfectivo.Size = New System.Drawing.Size(138, 28)
        Me.txtEfectivo.TabIndex = 248
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(148, 286)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(43, 13)
        Me.lblValor.TabIndex = 247
        Me.lblValor.Text = "Efectivo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(905, 252)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregar.TabIndex = 244
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(905, 281)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminar.TabIndex = 245
        '
        'GCDetallePagoDocumento
        '
        Me.GCDetallePagoDocumento.Location = New System.Drawing.Point(451, 251)
        Me.GCDetallePagoDocumento.MainView = Me.gvDetallePagoDocumento
        Me.GCDetallePagoDocumento.Name = "GCDetallePagoDocumento"
        Me.GCDetallePagoDocumento.Size = New System.Drawing.Size(448, 100)
        Me.GCDetallePagoDocumento.TabIndex = 243
        Me.GCDetallePagoDocumento.UseEmbeddedNavigator = True
        Me.GCDetallePagoDocumento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetallePagoDocumento})
        '
        'gvDetallePagoDocumento
        '
        Me.gvDetallePagoDocumento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCONCEPTODETALLEPAGO, Me.colVALORDETALLEPAGO})
        Me.gvDetallePagoDocumento.GridControl = Me.GCDetallePagoDocumento
        Me.gvDetallePagoDocumento.Name = "gvDetallePagoDocumento"
        Me.gvDetallePagoDocumento.OptionsBehavior.Editable = False
        Me.gvDetallePagoDocumento.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvDetallePagoDocumento.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllDetails = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllGroups = False
        Me.gvDetallePagoDocumento.OptionsPrint.PrintFooter = False
        Me.gvDetallePagoDocumento.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsView.ShowFooter = True
        Me.gvDetallePagoDocumento.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colCONCEPTODETALLEPAGO
        '
        Me.colCONCEPTODETALLEPAGO.Caption = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.FieldName = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.Name = "colCONCEPTODETALLEPAGO"
        Me.colCONCEPTODETALLEPAGO.Visible = True
        Me.colCONCEPTODETALLEPAGO.VisibleIndex = 0
        Me.colCONCEPTODETALLEPAGO.Width = 368
        '
        'colVALORDETALLEPAGO
        '
        Me.colVALORDETALLEPAGO.Caption = "VALOR"
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORDETALLEPAGO.FieldName = "VALOR"
        Me.colVALORDETALLEPAGO.Name = "colVALORDETALLEPAGO"
        Me.colVALORDETALLEPAGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORDETALLEPAGO.Visible = True
        Me.colVALORDETALLEPAGO.VisibleIndex = 1
        Me.colVALORDETALLEPAGO.Width = 162
        '
        'cboFormaPago
        '
        Me.cboFormaPago.Location = New System.Drawing.Point(148, 252)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cboFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONCEPTO", "CONCEPTO")})
        Me.cboFormaPago.Properties.NullText = ""
        Me.cboFormaPago.Properties.ShowHeader = False
        Me.cboFormaPago.Size = New System.Drawing.Size(297, 28)
        Me.cboFormaPago.TabIndex = 241
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Location = New System.Drawing.Point(14, 227)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(916, 18)
        Me.SeparatorControl2.TabIndex = 240
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(14, 346)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl12.TabIndex = 239
        Me.LabelControl12.Text = "Recibos Generados Orden"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(805, 84)
        Me.txtOrden.MenuManager = Me.BarManager1
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtOrden.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtOrden.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrden.Properties.Appearance.Options.UseFont = True
        Me.txtOrden.Properties.Appearance.Options.UseForeColor = True
        Me.txtOrden.Properties.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(125, 24)
        Me.txtOrden.TabIndex = 237
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(765, 88)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl10.TabIndex = 238
        Me.LabelControl10.Text = "Orden:"
        '
        'GCRecibosOrden
        '
        Me.GCRecibosOrden.Location = New System.Drawing.Point(11, 365)
        Me.GCRecibosOrden.MainView = Me.GVRecibosOrden
        Me.GCRecibosOrden.MenuManager = Me.BarManager1
        Me.GCRecibosOrden.Name = "GCRecibosOrden"
        Me.GCRecibosOrden.Size = New System.Drawing.Size(919, 138)
        Me.GCRecibosOrden.TabIndex = 236
        Me.GCRecibosOrden.UseEmbeddedNavigator = True
        Me.GCRecibosOrden.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRecibosOrden})
        '
        'GVRecibosOrden
        '
        Me.GVRecibosOrden.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDRECIBOORDEN, Me.colIDORDENRECIBO, Me.colFECHARECIBO, Me.colIDENTIFICACIONORDEN, Me.colRECIBIDOORDEN, Me.colCONCEPTORECIBO, Me.colVALORRECIBO, Me.colELABORADORECIBO, Me.colESTADORECIBO, Me.colCONSECUTIVORECIBO})
        Me.GVRecibosOrden.GridControl = Me.GCRecibosOrden
        Me.GVRecibosOrden.Name = "GVRecibosOrden"
        Me.GVRecibosOrden.OptionsBehavior.Editable = False
        Me.GVRecibosOrden.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVRecibosOrden.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVRecibosOrden.OptionsPrint.ExpandAllDetails = True
        Me.GVRecibosOrden.OptionsPrint.ExpandAllGroups = False
        Me.GVRecibosOrden.OptionsPrint.PrintFooter = False
        Me.GVRecibosOrden.OptionsView.EnableAppearanceOddRow = True
        Me.GVRecibosOrden.OptionsView.ShowGroupPanel = False
        '
        'colIDRECIBOORDEN
        '
        Me.colIDRECIBOORDEN.Caption = "RECIBO"
        Me.colIDRECIBOORDEN.FieldName = "RECIBO"
        Me.colIDRECIBOORDEN.Name = "colIDRECIBOORDEN"
        Me.colIDRECIBOORDEN.Visible = True
        Me.colIDRECIBOORDEN.VisibleIndex = 0
        Me.colIDRECIBOORDEN.Width = 55
        '
        'colIDORDENRECIBO
        '
        Me.colIDORDENRECIBO.Caption = "ORDEN"
        Me.colIDORDENRECIBO.FieldName = "ORDEN"
        Me.colIDORDENRECIBO.Name = "colIDORDENRECIBO"
        Me.colIDORDENRECIBO.Visible = True
        Me.colIDORDENRECIBO.VisibleIndex = 1
        Me.colIDORDENRECIBO.Width = 54
        '
        'colFECHARECIBO
        '
        Me.colFECHARECIBO.Caption = "FECHA"
        Me.colFECHARECIBO.FieldName = "FECHA"
        Me.colFECHARECIBO.Name = "colFECHARECIBO"
        Me.colFECHARECIBO.Visible = True
        Me.colFECHARECIBO.VisibleIndex = 3
        Me.colFECHARECIBO.Width = 64
        '
        'colIDENTIFICACIONORDEN
        '
        Me.colIDENTIFICACIONORDEN.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACIONORDEN.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACIONORDEN.Name = "colIDENTIFICACIONORDEN"
        Me.colIDENTIFICACIONORDEN.Visible = True
        Me.colIDENTIFICACIONORDEN.VisibleIndex = 4
        Me.colIDENTIFICACIONORDEN.Width = 102
        '
        'colRECIBIDOORDEN
        '
        Me.colRECIBIDOORDEN.Caption = "RECIBIDO DE"
        Me.colRECIBIDOORDEN.FieldName = "RECIBIDO"
        Me.colRECIBIDOORDEN.Name = "colRECIBIDOORDEN"
        Me.colRECIBIDOORDEN.Visible = True
        Me.colRECIBIDOORDEN.VisibleIndex = 5
        Me.colRECIBIDOORDEN.Width = 204
        '
        'colCONCEPTORECIBO
        '
        Me.colCONCEPTORECIBO.Caption = "CONCEPTO"
        Me.colCONCEPTORECIBO.FieldName = "CONCEPTO"
        Me.colCONCEPTORECIBO.Name = "colCONCEPTORECIBO"
        Me.colCONCEPTORECIBO.Visible = True
        Me.colCONCEPTORECIBO.VisibleIndex = 6
        Me.colCONCEPTORECIBO.Width = 252
        '
        'colVALORRECIBO
        '
        Me.colVALORRECIBO.Caption = "VALOR"
        Me.colVALORRECIBO.DisplayFormat.FormatString = "{0:C0}"
        Me.colVALORRECIBO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORRECIBO.FieldName = "VALOR"
        Me.colVALORRECIBO.Name = "colVALORRECIBO"
        Me.colVALORRECIBO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORRECIBO.Visible = True
        Me.colVALORRECIBO.VisibleIndex = 7
        Me.colVALORRECIBO.Width = 64
        '
        'colELABORADORECIBO
        '
        Me.colELABORADORECIBO.Caption = "ELABORADO"
        Me.colELABORADORECIBO.FieldName = "ELABORADO"
        Me.colELABORADORECIBO.Name = "colELABORADORECIBO"
        Me.colELABORADORECIBO.Visible = True
        Me.colELABORADORECIBO.VisibleIndex = 8
        Me.colELABORADORECIBO.Width = 72
        '
        'colESTADORECIBO
        '
        Me.colESTADORECIBO.Caption = "ESTADO"
        Me.colESTADORECIBO.FieldName = "ESTADO"
        Me.colESTADORECIBO.Name = "colESTADORECIBO"
        Me.colESTADORECIBO.Visible = True
        Me.colESTADORECIBO.VisibleIndex = 9
        Me.colESTADORECIBO.Width = 34
        '
        'colCONSECUTIVORECIBO
        '
        Me.colCONSECUTIVORECIBO.Caption = "CONSECUTIVO"
        Me.colCONSECUTIVORECIBO.FieldName = "CONSECUTIVO"
        Me.colCONSECUTIVORECIBO.Name = "colCONSECUTIVORECIBO"
        Me.colCONSECUTIVORECIBO.Visible = True
        Me.colCONSECUTIVORECIBO.VisibleIndex = 2
        '
        'txtGenerado
        '
        Me.txtGenerado.Location = New System.Drawing.Point(644, 204)
        Me.txtGenerado.MenuManager = Me.BarManager1
        Me.txtGenerado.Name = "txtGenerado"
        Me.txtGenerado.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtGenerado.Properties.Appearance.Options.UseBackColor = True
        Me.txtGenerado.Properties.DisplayFormat.FormatString = "C0"
        Me.txtGenerado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGenerado.Properties.EditFormat.FormatString = "C0"
        Me.txtGenerado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGenerado.Properties.ReadOnly = True
        Me.txtGenerado.Size = New System.Drawing.Size(286, 20)
        Me.txtGenerado.TabIndex = 235
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(644, 185)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl7.TabIndex = 234
        Me.LabelControl7.Text = "Generado Por:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(14, 154)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(102, 22)
        Me.LabelControl11.TabIndex = 233
        Me.LabelControl11.Text = "El Valor de:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(805, 151)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtValor.Properties.Appearance.Options.UseBackColor = True
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.Mask.EditMask = "n0"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValor.Size = New System.Drawing.Size(125, 28)
        Me.txtValor.TabIndex = 232
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(116, 151)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSon.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSon.Properties.Appearance.Options.UseBackColor = True
        Me.txtSon.Properties.Appearance.Options.UseFont = True
        Me.txtSon.Properties.Appearance.Options.UseForeColor = True
        Me.txtSon.Properties.ReadOnly = True
        Me.txtSon.Size = New System.Drawing.Size(683, 28)
        Me.txtSon.TabIndex = 231
        '
        'txtNumeroRecibo
        '
        Me.txtNumeroRecibo.Location = New System.Drawing.Point(805, 14)
        Me.txtNumeroRecibo.Name = "txtNumeroRecibo"
        Me.txtNumeroRecibo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroRecibo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRecibo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseForeColor = True
        Me.txtNumeroRecibo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumeroRecibo.Size = New System.Drawing.Size(125, 42)
        Me.txtNumeroRecibo.TabIndex = 221
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(681, 23)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(137, 29)
        Me.LabelControl9.TabIndex = 220
        Me.LabelControl9.Text = "Recibo No. "
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(116, 183)
        Me.txtConcepto.MenuManager = Me.BarManager1
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtConcepto.Properties.Appearance.Options.UseBackColor = True
        Me.txtConcepto.Size = New System.Drawing.Size(512, 41)
        Me.txtConcepto.TabIndex = 164
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 185)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl8.TabIndex = 165
        Me.LabelControl8.Text = "Por Concepto de:"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(14, 132)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(916, 18)
        Me.SeparatorControl1.TabIndex = 159
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(766, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl6.TabIndex = 136
        Me.LabelControl6.Text = "Fecha:"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(805, 58)
        Me.dtFecha.MenuManager = Me.BarManager1
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.ReadOnly = True
        Me.dtFecha.Size = New System.Drawing.Size(125, 20)
        Me.dtFecha.TabIndex = 135
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(116, 110)
        Me.txtDireccion.MenuManager = Me.BarManager1
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Properties.Appearance.Options.UseBackColor = True
        Me.txtDireccion.Size = New System.Drawing.Size(512, 20)
        Me.txtDireccion.TabIndex = 133
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 134
        Me.LabelControl4.Text = "Direccion:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(492, 84)
        Me.txtCiudad.MenuManager = Me.BarManager1
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCiudad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCiudad.Size = New System.Drawing.Size(135, 20)
        Me.txtCiudad.TabIndex = 132
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(440, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 131
        Me.LabelControl3.Text = "Ciudad:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(292, 84)
        Me.txtTelefono.MenuManager = Me.BarManager1
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Properties.Appearance.Options.UseBackColor = True
        Me.txtTelefono.Size = New System.Drawing.Size(135, 20)
        Me.txtTelefono.TabIndex = 130
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(240, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 129
        Me.LabelControl2.Text = "Telefono:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(116, 84)
        Me.txtIdentificacion.MenuManager = Me.BarManager1
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdentificacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(116, 20)
        Me.txtIdentificacion.TabIndex = 128
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 127
        Me.LabelControl1.Text = "Identificacion:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(116, 58)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNombre.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombre.Size = New System.Drawing.Size(512, 20)
        Me.txtNombre.TabIndex = 125
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(14, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 126
        Me.LabelControl5.Text = "Recibido de:"
        '
        'xtpCierre
        '
        Me.xtpCierre.Controls.Add(Me.SeparatorControl3)
        Me.xtpCierre.Controls.Add(Me.LabelControl17)
        Me.xtpCierre.Controls.Add(Me.txtObservaciones)
        Me.xtpCierre.Controls.Add(Me.GCRecibosPendientes)
        Me.xtpCierre.Controls.Add(Me.btnCerrarCaja)
        Me.xtpCierre.Controls.Add(Me.LabelControl16)
        Me.xtpCierre.Controls.Add(Me.txtSaldoActual)
        Me.xtpCierre.Controls.Add(Me.LabelControl15)
        Me.xtpCierre.Controls.Add(Me.txtSaldoAnterior)
        Me.xtpCierre.Controls.Add(Me.LabelControl14)
        Me.xtpCierre.Controls.Add(Me.dtFechaCierre)
        Me.xtpCierre.Controls.Add(Me.txtElaborado)
        Me.xtpCierre.Controls.Add(Me.LabelControl13)
        Me.xtpCierre.Name = "xtpCierre"
        Me.xtpCierre.Size = New System.Drawing.Size(925, 463)
        Me.xtpCierre.Text = "Cierre de Caja"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(22, 37)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl17.TabIndex = 247
        Me.LabelControl17.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(103, 37)
        Me.txtObservaciones.MenuManager = Me.BarManager1
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Properties.Appearance.Options.UseBackColor = True
        Me.txtObservaciones.Size = New System.Drawing.Size(559, 60)
        Me.txtObservaciones.TabIndex = 246
        '
        'GCRecibosPendientes
        '
        Me.GCRecibosPendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCRecibosPendientes.Location = New System.Drawing.Point(22, 114)
        Me.GCRecibosPendientes.MainView = Me.GVRecibosPendientes
        Me.GCRecibosPendientes.MenuManager = Me.BarManager1
        Me.GCRecibosPendientes.Name = "GCRecibosPendientes"
        Me.GCRecibosPendientes.Size = New System.Drawing.Size(891, 290)
        Me.GCRecibosPendientes.TabIndex = 245
        Me.GCRecibosPendientes.UseEmbeddedNavigator = True
        Me.GCRecibosPendientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRecibosPendientes})
        '
        'GVRecibosPendientes
        '
        Me.GVRecibosPendientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRECIBOP, Me.colORDENP, Me.colFECHAP, Me.colRECIBIDOP, Me.colCONCEPTOP, Me.colVALORP, Me.colELABORADOP, Me.colESTADOP, Me.colCONSECUTIVOP})
        Me.GVRecibosPendientes.GridControl = Me.GCRecibosPendientes
        Me.GVRecibosPendientes.Name = "GVRecibosPendientes"
        Me.GVRecibosPendientes.OptionsBehavior.Editable = False
        Me.GVRecibosPendientes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVRecibosPendientes.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVRecibosPendientes.OptionsPrint.ExpandAllDetails = True
        Me.GVRecibosPendientes.OptionsPrint.ExpandAllGroups = False
        Me.GVRecibosPendientes.OptionsPrint.PrintFooter = False
        Me.GVRecibosPendientes.OptionsView.EnableAppearanceOddRow = True
        Me.GVRecibosPendientes.OptionsView.ShowFooter = True
        Me.GVRecibosPendientes.OptionsView.ShowGroupPanel = False
        '
        'colRECIBOP
        '
        Me.colRECIBOP.Caption = "RECIBO"
        Me.colRECIBOP.FieldName = "RECIBO"
        Me.colRECIBOP.Name = "colRECIBOP"
        Me.colRECIBOP.Visible = True
        Me.colRECIBOP.VisibleIndex = 0
        Me.colRECIBOP.Width = 61
        '
        'colORDENP
        '
        Me.colORDENP.Caption = "ORDEN"
        Me.colORDENP.FieldName = "ORDEN"
        Me.colORDENP.Name = "colORDENP"
        Me.colORDENP.Visible = True
        Me.colORDENP.VisibleIndex = 1
        Me.colORDENP.Width = 72
        '
        'colFECHAP
        '
        Me.colFECHAP.Caption = "FECHA"
        Me.colFECHAP.FieldName = "FECHA"
        Me.colFECHAP.Name = "colFECHAP"
        Me.colFECHAP.Visible = True
        Me.colFECHAP.VisibleIndex = 3
        Me.colFECHAP.Width = 83
        '
        'colRECIBIDOP
        '
        Me.colRECIBIDOP.Caption = "RECIBIDO"
        Me.colRECIBIDOP.FieldName = "RECIBIDO"
        Me.colRECIBIDOP.Name = "colRECIBIDOP"
        Me.colRECIBIDOP.Visible = True
        Me.colRECIBIDOP.VisibleIndex = 4
        Me.colRECIBIDOP.Width = 227
        '
        'colCONCEPTOP
        '
        Me.colCONCEPTOP.Caption = "CONCEPTO"
        Me.colCONCEPTOP.FieldName = "CONCEPTO"
        Me.colCONCEPTOP.Name = "colCONCEPTOP"
        Me.colCONCEPTOP.Visible = True
        Me.colCONCEPTOP.VisibleIndex = 5
        Me.colCONCEPTOP.Width = 240
        '
        'colVALORP
        '
        Me.colVALORP.Caption = "VALOR"
        Me.colVALORP.DisplayFormat.FormatString = "{0:C0}"
        Me.colVALORP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORP.FieldName = "VALOR"
        Me.colVALORP.Name = "colVALORP"
        Me.colVALORP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORP.Visible = True
        Me.colVALORP.VisibleIndex = 6
        Me.colVALORP.Width = 97
        '
        'colELABORADOP
        '
        Me.colELABORADOP.Caption = "ELABORADO"
        Me.colELABORADOP.FieldName = "ELABORADO"
        Me.colELABORADOP.Name = "colELABORADOP"
        Me.colELABORADOP.Visible = True
        Me.colELABORADOP.VisibleIndex = 7
        Me.colELABORADOP.Width = 98
        '
        'colESTADOP
        '
        Me.colESTADOP.Caption = "ESTADO"
        Me.colESTADOP.FieldName = "ESTADO"
        Me.colESTADOP.Name = "colESTADOP"
        Me.colESTADOP.Visible = True
        Me.colESTADOP.VisibleIndex = 8
        Me.colESTADOP.Width = 95
        '
        'colCONSECUTIVOP
        '
        Me.colCONSECUTIVOP.Caption = "CONSECUTIVO"
        Me.colCONSECUTIVOP.FieldName = "CONSECUTIVO"
        Me.colCONSECUTIVOP.Name = "colCONSECUTIVOP"
        Me.colCONSECUTIVOP.Visible = True
        Me.colCONSECUTIVOP.VisibleIndex = 2
        Me.colCONSECUTIVOP.Width = 79
        '
        'btnCerrarCaja
        '
        Me.btnCerrarCaja.Location = New System.Drawing.Point(788, 410)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(125, 26)
        Me.btnCerrarCaja.TabIndex = 244
        Me.btnCerrarCaja.Text = "Cerrar Caja"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(719, 72)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl16.TabIndex = 243
        Me.LabelControl16.Text = "Saldo Actual:"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Location = New System.Drawing.Point(788, 64)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldoActual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoActual.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSaldoActual.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoActual.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoActual.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoActual.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtSaldoActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActual.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtSaldoActual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActual.Properties.Mask.EditMask = "n0"
        Me.txtSaldoActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoActual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoActual.Properties.ReadOnly = True
        Me.txtSaldoActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoActual.Size = New System.Drawing.Size(125, 28)
        Me.txtSaldoActual.TabIndex = 242
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(710, 32)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl15.TabIndex = 241
        Me.LabelControl15.Text = "Saldo Anterior:"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(788, 24)
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldoAnterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoAnterior.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSaldoAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoAnterior.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoAnterior.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoAnterior.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtSaldoAnterior.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAnterior.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtSaldoAnterior.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAnterior.Properties.Mask.EditMask = "n0"
        Me.txtSaldoAnterior.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoAnterior.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(125, 28)
        Me.txtSaldoAnterior.TabIndex = 240
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(64, 14)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl14.TabIndex = 239
        Me.LabelControl14.Text = "Fecha:"
        '
        'dtFechaCierre
        '
        Me.dtFechaCierre.EditValue = Nothing
        Me.dtFechaCierre.Location = New System.Drawing.Point(103, 11)
        Me.dtFechaCierre.MenuManager = Me.BarManager1
        Me.dtFechaCierre.Name = "dtFechaCierre"
        Me.dtFechaCierre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCierre.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCierre.Properties.ReadOnly = True
        Me.dtFechaCierre.Size = New System.Drawing.Size(125, 20)
        Me.dtFechaCierre.TabIndex = 238
        '
        'txtElaborado
        '
        Me.txtElaborado.Location = New System.Drawing.Point(329, 11)
        Me.txtElaborado.MenuManager = Me.BarManager1
        Me.txtElaborado.Name = "txtElaborado"
        Me.txtElaborado.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtElaborado.Properties.Appearance.Options.UseBackColor = True
        Me.txtElaborado.Properties.DisplayFormat.FormatString = "C0"
        Me.txtElaborado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtElaborado.Properties.EditFormat.FormatString = "C0"
        Me.txtElaborado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtElaborado.Properties.ReadOnly = True
        Me.txtElaborado.Size = New System.Drawing.Size(333, 20)
        Me.txtElaborado.TabIndex = 237
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(252, 14)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl13.TabIndex = 236
        Me.LabelControl13.Text = "Elaborado Por:"
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(668, 14)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(36, 83)
        Me.SeparatorControl3.TabIndex = 248
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 513)
        Me.Controls.Add(Me.xtcCaja)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCaja"
        Me.Text = "Caja"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCaja.ResumeLayout(False)
        Me.xtpConsultarRecibos.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCaja.ResumeLayout(False)
        Me.xtpCaja.PerformLayout()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEfectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCRecibosOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRecibosOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenerado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCierre.ResumeLayout(False)
        Me.xtpCierre.PerformLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCRecibosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRecibosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCierre.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents xtcCaja As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpConsultarRecibos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpCaja As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpCierre As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdentificacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroRecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCRecibosOrden As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRecibosOrden As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGenerado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIDRECIBOORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDORDENRECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHARECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACIONORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIDOORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTORECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDRECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORRECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADORECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GCRecibosPendientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRecibosPendientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRECIBOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDENP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIDOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCerrarCaja As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaCierre As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtElaborado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colELABORADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELABORADORECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELABORADOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GCDetallePagoDocumento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetallePagoDocumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTODETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORDETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCambio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEfectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCONSECUTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVORECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
End Class

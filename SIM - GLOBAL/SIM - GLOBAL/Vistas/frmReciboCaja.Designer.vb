<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReciboCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboCaja))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.txtGenerado = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOrdenServicio = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.txtElaborado = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroRecibo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCiudad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCerrarCaja = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaldoActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaldoAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaCierre = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.colCONSECUTIVOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBIDOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDENP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVRecibosPendientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCRecibosPendientes = New DevExpress.XtraGrid.GridControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpCierre = New DevExpress.XtraTab.XtraTabPage()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDRECIBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRECIBIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSECUTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.xtpConsultarRecibos = New DevExpress.XtraTab.XtraTabPage()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtcCaja = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpCaja = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTipoDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSon = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GCDetallePagoDocumento = New DevExpress.XtraGrid.GridControl()
        Me.gvDetallePagoDocumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTODETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORDETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminarFormaPago = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFormaPagoValor = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregarFormaPago = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValor = New DevExpress.XtraEditors.LabelControl()
        Me.cboFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.GCCuentasClientes = New DevExpress.XtraGrid.GridControl()
        Me.gvCuentasClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.GCDatosCliente = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosCliente = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.cboCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpConsultaCierreCaja = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultaCierre = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultaCierre = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCierre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHACIERRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELABORADOCIERRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtGenerado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCierre.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRecibosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCRecibosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCierre.SuspendLayout()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpConsultarRecibos.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCaja.SuspendLayout()
        Me.xtpCaja.SuspendLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCuentasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCuentasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpConsultaCierreCaja.SuspendLayout()
        CType(Me.GCConsultaCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultaCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileViewColumn3
        '
        Me.TileViewColumn3.Caption = "Nombres"
        Me.TileViewColumn3.FieldName = "NOMBRE"
        Me.TileViewColumn3.Name = "TileViewColumn3"
        Me.TileViewColumn3.Visible = True
        Me.TileViewColumn3.VisibleIndex = 2
        '
        'TileViewColumn5
        '
        Me.TileViewColumn5.Caption = "Telefono"
        Me.TileViewColumn5.FieldName = "TELEFONO"
        Me.TileViewColumn5.Name = "TileViewColumn5"
        Me.TileViewColumn5.Visible = True
        Me.TileViewColumn5.VisibleIndex = 4
        '
        'TileViewColumn2
        '
        Me.TileViewColumn2.Caption = "Identificacion"
        Me.TileViewColumn2.FieldName = "IDENTIFICACION"
        Me.TileViewColumn2.Name = "TileViewColumn2"
        Me.TileViewColumn2.Visible = True
        Me.TileViewColumn2.VisibleIndex = 1
        '
        'colEmail
        '
        Me.colEmail.Caption = "EMAIL"
        Me.colEmail.FieldName = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 7
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        '
        'txtGenerado
        '
        Me.txtGenerado.Location = New System.Drawing.Point(802, 181)
        Me.txtGenerado.MenuManager = Me.BarManager1
        Me.txtGenerado.Name = "txtGenerado"
        Me.txtGenerado.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtGenerado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtGenerado.Properties.Appearance.Options.UseBackColor = True
        Me.txtGenerado.Properties.Appearance.Options.UseFont = True
        Me.txtGenerado.Properties.DisplayFormat.FormatString = "C0"
        Me.txtGenerado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGenerado.Properties.EditFormat.FormatString = "C0"
        Me.txtGenerado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGenerado.Properties.ReadOnly = True
        Me.txtGenerado.Size = New System.Drawing.Size(275, 28)
        Me.txtGenerado.TabIndex = 235
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiAnular, Me.bbiOrdenServicio})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOrdenServicio)})
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
        'bbiAnular
        '
        Me.bbiAnular.Caption = "Anular"
        Me.bbiAnular.Id = 5
        Me.bbiAnular.ImageOptions.Image = CType(resources.GetObject("bbiAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAnular.Name = "bbiAnular"
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
        'bbiOrdenServicio
        '
        Me.bbiOrdenServicio.Caption = "Ver Orden de Servicio"
        Me.bbiOrdenServicio.Id = 6
        Me.bbiOrdenServicio.ImageOptions.Image = CType(resources.GetObject("bbiOrdenServicio.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiOrdenServicio.Name = "bbiOrdenServicio"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1100, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 485)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1100, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 460)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1100, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 460)
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(802, 157)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(113, 22)
        Me.LabelControl7.TabIndex = 234
        Me.LabelControl7.Text = "Generado Por:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(288, 289)
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
        'txtElaborado
        '
        Me.txtElaborado.Location = New System.Drawing.Point(322, 11)
        Me.txtElaborado.MenuManager = Me.BarManager1
        Me.txtElaborado.Name = "txtElaborado"
        Me.txtElaborado.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtElaborado.Properties.Appearance.Options.UseBackColor = True
        Me.txtElaborado.Properties.DisplayFormat.FormatString = "C0"
        Me.txtElaborado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtElaborado.Properties.EditFormat.FormatString = "C0"
        Me.txtElaborado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtElaborado.Properties.ReadOnly = True
        Me.txtElaborado.Size = New System.Drawing.Size(471, 20)
        Me.txtElaborado.TabIndex = 237
        '
        'txtNumeroRecibo
        '
        Me.txtNumeroRecibo.Location = New System.Drawing.Point(142, 22)
        Me.txtNumeroRecibo.Name = "txtNumeroRecibo"
        Me.txtNumeroRecibo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroRecibo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRecibo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroRecibo.Properties.Appearance.Options.UseForeColor = True
        Me.txtNumeroRecibo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumeroRecibo.Size = New System.Drawing.Size(133, 42)
        Me.txtNumeroRecibo.TabIndex = 221
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(9, 31)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(137, 29)
        Me.LabelControl9.TabIndex = 220
        Me.LabelControl9.Text = "Recibo No. "
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(18, 182)
        Me.txtConcepto.MenuManager = Me.BarManager1
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtConcepto.Properties.Appearance.Options.UseBackColor = True
        Me.txtConcepto.Size = New System.Drawing.Size(392, 78)
        Me.txtConcepto.TabIndex = 164
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(18, 157)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(137, 22)
        Me.LabelControl8.TabIndex = 165
        Me.LabelControl8.Text = "Por Concepto de:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(142, 100)
        Me.txtCiudad.MenuManager = Me.BarManager1
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCiudad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCiudad.Size = New System.Drawing.Size(133, 20)
        Me.txtCiudad.TabIndex = 132
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(90, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 131
        Me.LabelControl3.Text = "Ciudad:"
        '
        'btnCerrarCaja
        '
        Me.btnCerrarCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarCaja.Location = New System.Drawing.Point(962, 377)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(125, 26)
        Me.btnCerrarCaja.TabIndex = 244
        Me.btnCerrarCaja.Text = "Cerrar Caja"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(850, 25)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl16.TabIndex = 243
        Me.LabelControl16.Text = "Saldo Actual:"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Location = New System.Drawing.Point(925, 17)
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
        Me.LabelControl15.Location = New System.Drawing.Point(841, 61)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl15.TabIndex = 241
        Me.LabelControl15.Text = "Saldo Anterior:"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(925, 53)
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
        Me.LabelControl14.Location = New System.Drawing.Point(22, 14)
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
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(245, 14)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl13.TabIndex = 236
        Me.LabelControl13.Text = "Elaborado Por:"
        '
        'colCONSECUTIVOP
        '
        Me.colCONSECUTIVOP.Caption = "CONSECUTIVO"
        Me.colCONSECUTIVOP.FieldName = "CONSECUTIVO"
        Me.colCONSECUTIVOP.Name = "colCONSECUTIVOP"
        Me.colCONSECUTIVOP.Visible = True
        Me.colCONSECUTIVOP.VisibleIndex = 2
        Me.colCONSECUTIVOP.Width = 54
        '
        'colESTADOP
        '
        Me.colESTADOP.Caption = "ESTADO"
        Me.colESTADOP.FieldName = "ESTADO"
        Me.colESTADOP.Name = "colESTADOP"
        Me.colESTADOP.Visible = True
        Me.colESTADOP.VisibleIndex = 8
        Me.colESTADOP.Width = 54
        '
        'colELABORADOP
        '
        Me.colELABORADOP.Caption = "ELABORADO"
        Me.colELABORADOP.FieldName = "ELABORADO"
        Me.colELABORADOP.Name = "colELABORADOP"
        Me.colELABORADOP.Visible = True
        Me.colELABORADOP.VisibleIndex = 7
        Me.colELABORADOP.Width = 83
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
        Me.colVALORP.Width = 95
        '
        'colCONCEPTOP
        '
        Me.colCONCEPTOP.Caption = "CONCEPTO"
        Me.colCONCEPTOP.FieldName = "CONCEPTO"
        Me.colCONCEPTOP.Name = "colCONCEPTOP"
        Me.colCONCEPTOP.Visible = True
        Me.colCONCEPTOP.VisibleIndex = 5
        Me.colCONCEPTOP.Width = 236
        '
        'colRECIBIDOP
        '
        Me.colRECIBIDOP.Caption = "RECIBIDO"
        Me.colRECIBIDOP.FieldName = "RECIBIDO"
        Me.colRECIBIDOP.Name = "colRECIBIDOP"
        Me.colRECIBIDOP.Visible = True
        Me.colRECIBIDOP.VisibleIndex = 4
        Me.colRECIBIDOP.Width = 259
        '
        'colFECHAP
        '
        Me.colFECHAP.Caption = "FECHA"
        Me.colFECHAP.FieldName = "FECHA"
        Me.colFECHAP.Name = "colFECHAP"
        Me.colFECHAP.Visible = True
        Me.colFECHAP.VisibleIndex = 3
        Me.colFECHAP.Width = 109
        '
        'colORDENP
        '
        Me.colORDENP.Caption = "ORDEN / FACTURA"
        Me.colORDENP.FieldName = "ORDEN"
        Me.colORDENP.Name = "colORDENP"
        Me.colORDENP.Visible = True
        Me.colORDENP.VisibleIndex = 1
        Me.colORDENP.Width = 102
        '
        'colRECIBOP
        '
        Me.colRECIBOP.Caption = "RECIBO"
        Me.colRECIBOP.FieldName = "RECIBO"
        Me.colRECIBOP.Name = "colRECIBOP"
        Me.colRECIBOP.Visible = True
        Me.colRECIBOP.VisibleIndex = 0
        Me.colRECIBOP.Width = 60
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
        'GCRecibosPendientes
        '
        Me.GCRecibosPendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCRecibosPendientes.Location = New System.Drawing.Point(22, 99)
        Me.GCRecibosPendientes.MainView = Me.GVRecibosPendientes
        Me.GCRecibosPendientes.MenuManager = Me.BarManager1
        Me.GCRecibosPendientes.Name = "GCRecibosPendientes"
        Me.GCRecibosPendientes.Size = New System.Drawing.Size(1065, 272)
        Me.GCRecibosPendientes.TabIndex = 245
        Me.GCRecibosPendientes.UseEmbeddedNavigator = True
        Me.GCRecibosPendientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRecibosPendientes})
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(22, 39)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(690, 44)
        Me.txtObservaciones.TabIndex = 246
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
        Me.xtpCierre.Size = New System.Drawing.Size(1098, 435)
        Me.xtpCierre.Text = "Cierre de Caja"
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(799, 9)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(36, 79)
        Me.SeparatorControl3.TabIndex = 249
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 126
        Me.LabelControl5.Text = "Recibido de:"
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
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 3
        Me.colFECHA.Width = 68
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
        'colIDRECIBO
        '
        Me.colIDRECIBO.Caption = "RECIBO"
        Me.colIDRECIBO.FieldName = "RECIBO"
        Me.colIDRECIBO.Name = "colIDRECIBO"
        Me.colIDRECIBO.Visible = True
        Me.colIDRECIBO.VisibleIndex = 0
        Me.colIDRECIBO.Width = 55
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
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
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
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1098, 435)
        Me.GCConsultar.TabIndex = 36
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'xtpConsultarRecibos
        '
        Me.xtpConsultarRecibos.Controls.Add(Me.GCConsultar)
        Me.xtpConsultarRecibos.Name = "xtpConsultarRecibos"
        Me.xtpConsultarRecibos.Size = New System.Drawing.Size(1098, 435)
        Me.xtpConsultarRecibos.Text = "Consultar Recibos"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'xtcCaja
        '
        Me.xtcCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCaja.Location = New System.Drawing.Point(0, 25)
        Me.xtcCaja.Name = "xtcCaja"
        Me.xtcCaja.SelectedTabPage = Me.xtpConsultarRecibos
        Me.xtcCaja.Size = New System.Drawing.Size(1100, 460)
        Me.xtcCaja.TabIndex = 166
        Me.xtcCaja.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpCaja, Me.xtpConsultarRecibos, Me.xtpCierre, Me.xtpConsultaCierreCaja})
        '
        'xtpCaja
        '
        Me.xtpCaja.Controls.Add(Me.txtTipoDocumento)
        Me.xtpCaja.Controls.Add(Me.LabelControl6)
        Me.xtpCaja.Controls.Add(Me.txtSon)
        Me.xtpCaja.Controls.Add(Me.LabelControl23)
        Me.xtpCaja.Controls.Add(Me.LabelControl2)
        Me.xtpCaja.Controls.Add(Me.GroupBox1)
        Me.xtpCaja.Controls.Add(Me.GCCuentasClientes)
        Me.xtpCaja.Controls.Add(Me.GroupBox3)
        Me.xtpCaja.Controls.Add(Me.GCDatosCliente)
        Me.xtpCaja.Controls.Add(Me.cboCliente)
        Me.xtpCaja.Controls.Add(Me.btnClientes)
        Me.xtpCaja.Controls.Add(Me.txtConsecutivo)
        Me.xtpCaja.Controls.Add(Me.LabelControl18)
        Me.xtpCaja.Controls.Add(Me.txtGenerado)
        Me.xtpCaja.Controls.Add(Me.LabelControl7)
        Me.xtpCaja.Controls.Add(Me.txtValor)
        Me.xtpCaja.Controls.Add(Me.txtConcepto)
        Me.xtpCaja.Controls.Add(Me.LabelControl8)
        Me.xtpCaja.Controls.Add(Me.LabelControl5)
        Me.xtpCaja.Name = "xtpCaja"
        Me.xtpCaja.Size = New System.Drawing.Size(1098, 435)
        Me.xtpCaja.Text = "Caja"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(100, 289)
        Me.txtTipoDocumento.MenuManager = Me.BarManager1
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTipoDocumento.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTipoDocumento.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipoDocumento.Properties.Appearance.Options.UseFont = True
        Me.txtTipoDocumento.Properties.Appearance.Options.UseForeColor = True
        Me.txtTipoDocumento.Properties.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(182, 28)
        Me.txtTipoDocumento.TabIndex = 265
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(100, 266)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl6.TabIndex = 266
        Me.LabelControl6.Text = "Tipo Documento"
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(18, 352)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSon.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSon.Properties.Appearance.Options.UseBackColor = True
        Me.txtSon.Properties.Appearance.Options.UseFont = True
        Me.txtSon.Properties.Appearance.Options.UseForeColor = True
        Me.txtSon.Properties.ReadOnly = True
        Me.txtSon.Size = New System.Drawing.Size(392, 28)
        Me.txtSon.TabIndex = 264
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(18, 327)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(41, 22)
        Me.LabelControl23.TabIndex = 263
        Me.LabelControl23.Text = "Son:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(287, 264)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 22)
        Me.LabelControl2.TabIndex = 262
        Me.LabelControl2.Text = "SALDO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GCDetallePagoDocumento)
        Me.GroupBox1.Controls.Add(Me.btnEliminarFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtFormaPagoValor)
        Me.GroupBox1.Controls.Add(Me.btnAgregarFormaPago)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.cboFormaPago)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(419, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 210)
        Me.GroupBox1.TabIndex = 261
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pago"
        '
        'GCDetallePagoDocumento
        '
        Me.GCDetallePagoDocumento.Location = New System.Drawing.Point(16, 92)
        Me.GCDetallePagoDocumento.MainView = Me.gvDetallePagoDocumento
        Me.GCDetallePagoDocumento.Name = "GCDetallePagoDocumento"
        Me.GCDetallePagoDocumento.Size = New System.Drawing.Size(351, 104)
        Me.GCDetallePagoDocumento.TabIndex = 251
        Me.GCDetallePagoDocumento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetallePagoDocumento})
        '
        'gvDetallePagoDocumento
        '
        Me.gvDetallePagoDocumento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colCONCEPTODETALLEPAGO, Me.colVALORDETALLEPAGO})
        Me.gvDetallePagoDocumento.GridControl = Me.GCDetallePagoDocumento
        Me.gvDetallePagoDocumento.Name = "gvDetallePagoDocumento"
        Me.gvDetallePagoDocumento.OptionsBehavior.Editable = False
        Me.gvDetallePagoDocumento.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvDetallePagoDocumento.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllDetails = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllGroups = False
        Me.gvDetallePagoDocumento.OptionsPrint.PrintFooter = False
        Me.gvDetallePagoDocumento.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsView.ShowColumnHeaders = False
        Me.gvDetallePagoDocumento.OptionsView.ShowFooter = True
        Me.gvDetallePagoDocumento.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
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
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatString = "C0"
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORDETALLEPAGO.FieldName = "VALOR"
        Me.colVALORDETALLEPAGO.Name = "colVALORDETALLEPAGO"
        Me.colVALORDETALLEPAGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORDETALLEPAGO.Visible = True
        Me.colVALORDETALLEPAGO.VisibleIndex = 1
        Me.colVALORDETALLEPAGO.Width = 162
        '
        'btnEliminarFormaPago
        '
        Me.btnEliminarFormaPago.ImageOptions.Image = CType(resources.GetObject("btnEliminarFormaPago.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarFormaPago.Location = New System.Drawing.Point(341, 59)
        Me.btnEliminarFormaPago.Name = "btnEliminarFormaPago"
        Me.btnEliminarFormaPago.Size = New System.Drawing.Size(26, 27)
        Me.btnEliminarFormaPago.TabIndex = 249
        Me.btnEliminarFormaPago.ToolTip = "Eliminar Producto"
        '
        'txtFormaPagoValor
        '
        Me.txtFormaPagoValor.Location = New System.Drawing.Point(142, 60)
        Me.txtFormaPagoValor.Name = "txtFormaPagoValor"
        Me.txtFormaPagoValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtFormaPagoValor.Properties.Appearance.Options.UseFont = True
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.EditMask = "c0"
        Me.txtFormaPagoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFormaPagoValor.Size = New System.Drawing.Size(158, 28)
        Me.txtFormaPagoValor.TabIndex = 248
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.ImageOptions.Image = CType(resources.GetObject("btnAgregarFormaPago.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(309, 60)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(26, 26)
        Me.btnAgregarFormaPago.TabIndex = 248
        Me.btnAgregarFormaPago.ToolTip = "Agregar Producto"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(83, 63)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl4.TabIndex = 250
        Me.LabelControl4.Text = "Valor"
        '
        'lblValor
        '
        Me.lblValor.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblValor.Appearance.Options.UseFont = True
        Me.lblValor.Location = New System.Drawing.Point(16, 31)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(117, 22)
        Me.lblValor.TabIndex = 249
        Me.lblValor.Text = "Medio de Pago"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.Location = New System.Drawing.Point(142, 28)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cboFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONCEPTO", "CONCEPTO")})
        Me.cboFormaPago.Properties.NullText = ""
        Me.cboFormaPago.Properties.ShowHeader = False
        Me.cboFormaPago.Size = New System.Drawing.Size(158, 28)
        Me.cboFormaPago.TabIndex = 248
        '
        'GCCuentasClientes
        '
        Me.GCCuentasClientes.Location = New System.Drawing.Point(416, 11)
        Me.GCCuentasClientes.MainView = Me.gvCuentasClientes
        Me.GCCuentasClientes.MenuManager = Me.BarManager1
        Me.GCCuentasClientes.Name = "GCCuentasClientes"
        Me.GCCuentasClientes.Size = New System.Drawing.Size(380, 129)
        Me.GCCuentasClientes.TabIndex = 260
        Me.GCCuentasClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCuentasClientes})
        '
        'gvCuentasClientes
        '
        Me.gvCuentasClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSId, Me.colSFecha, Me.colSDocumento, Me.colSConsecutivo, Me.colSSaldo})
        Me.gvCuentasClientes.GridControl = Me.GCCuentasClientes
        Me.gvCuentasClientes.Name = "gvCuentasClientes"
        Me.gvCuentasClientes.OptionsBehavior.Editable = False
        Me.gvCuentasClientes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvCuentasClientes.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvCuentasClientes.OptionsPrint.ExpandAllDetails = True
        Me.gvCuentasClientes.OptionsPrint.ExpandAllGroups = False
        Me.gvCuentasClientes.OptionsPrint.PrintFooter = False
        Me.gvCuentasClientes.OptionsView.EnableAppearanceOddRow = True
        Me.gvCuentasClientes.OptionsView.ShowGroupPanel = False
        '
        'colSId
        '
        Me.colSId.Caption = "ID"
        Me.colSId.FieldName = "ID"
        Me.colSId.Name = "colSId"
        '
        'colSFecha
        '
        Me.colSFecha.Caption = "FECHA"
        Me.colSFecha.FieldName = "FECHA"
        Me.colSFecha.Name = "colSFecha"
        Me.colSFecha.Visible = True
        Me.colSFecha.VisibleIndex = 0
        Me.colSFecha.Width = 69
        '
        'colSDocumento
        '
        Me.colSDocumento.Caption = "DOCUMENTO"
        Me.colSDocumento.FieldName = "DOCUMENTO"
        Me.colSDocumento.Name = "colSDocumento"
        Me.colSDocumento.Visible = True
        Me.colSDocumento.VisibleIndex = 1
        Me.colSDocumento.Width = 118
        '
        'colSConsecutivo
        '
        Me.colSConsecutivo.Caption = "CONS."
        Me.colSConsecutivo.FieldName = "CONSECUTIVO"
        Me.colSConsecutivo.Name = "colSConsecutivo"
        Me.colSConsecutivo.Visible = True
        Me.colSConsecutivo.VisibleIndex = 2
        Me.colSConsecutivo.Width = 83
        '
        'colSSaldo
        '
        Me.colSSaldo.Caption = "SALDO"
        Me.colSSaldo.DisplayFormat.FormatString = "C0"
        Me.colSSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSSaldo.FieldName = "SALDO"
        Me.colSSaldo.Name = "colSSaldo"
        Me.colSSaldo.Visible = True
        Me.colSSaldo.VisibleIndex = 3
        Me.colSSaldo.Width = 80
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelControl1)
        Me.GroupBox3.Controls.Add(Me.dtFecha)
        Me.GroupBox3.Controls.Add(Me.txtNumeroRecibo)
        Me.GroupBox3.Controls.Add(Me.LabelControl9)
        Me.GroupBox3.Controls.Add(Me.txtCiudad)
        Me.GroupBox3.Controls.Add(Me.LabelControl3)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(802, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 129)
        Me.GroupBox3.TabIndex = 259
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Recibo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(81, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 22)
        Me.LabelControl1.TabIndex = 204
        Me.LabelControl1.Text = "Fecha:"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(142, 68)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFecha.Properties.Appearance.Options.UseFont = True
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtFecha.Properties.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom
        Me.dtFecha.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = True
        Me.dtFecha.Properties.DisplayFormat.FormatString = ""
        Me.dtFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFecha.Properties.EditFormat.FormatString = ""
        Me.dtFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFecha.Size = New System.Drawing.Size(133, 28)
        Me.dtFecha.TabIndex = 191
        '
        'GCDatosCliente
        '
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosCliente.Location = New System.Drawing.Point(15, 40)
        Me.GCDatosCliente.MainView = Me.TVDatosCliente
        Me.GCDatosCliente.Name = "GCDatosCliente"
        Me.GCDatosCliente.Size = New System.Drawing.Size(395, 100)
        Me.GCDatosCliente.TabIndex = 258
        Me.GCDatosCliente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TVDatosCliente})
        '
        'TVDatosCliente
        '
        Me.TVDatosCliente.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TVDatosCliente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn1, Me.TileViewColumn2, Me.TileViewColumn3, Me.colApellidos, Me.colEdad, Me.TileViewColumn4, Me.colDireccion, Me.colEmail, Me.TileViewColumn5, Me.colFoto})
        Me.TVDatosCliente.GridControl = Me.GCDatosCliente
        Me.TVDatosCliente.Name = "TVDatosCliente"
        Me.TVDatosCliente.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(28, 0, 0, 16)
        Me.TVDatosCliente.OptionsTiles.IndentBetweenItems = 13
        Me.TVDatosCliente.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TVDatosCliente.OptionsTiles.ItemSize = New System.Drawing.Size(372, 72)
        Me.TVDatosCliente.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        TableColumnDefinition1.Length.Value = 138.0R
        Me.TVDatosCliente.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.TileViewColumn3
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.Text = "TileViewColumn3"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(10, 5)
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumn5
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.Text = "TileViewColumn5"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(10, 35)
        TileViewItemElement3.Column = Me.TileViewColumn2
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.Text = "TileViewColumn2"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(10, 22)
        TileViewItemElement4.Column = Me.colEmail
        TileViewItemElement4.StretchHorizontal = True
        TileViewItemElement4.Text = "colEmail"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(10, 60)
        TileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.Transparent
        TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.DimGray
        TileViewItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement5.Column = Me.colDireccion
        TileViewItemElement5.StretchHorizontal = True
        TileViewItemElement5.Text = "colDireccion"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(10, 47)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement1)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement2)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement3)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement4)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement5)
        '
        'TileViewColumn1
        '
        Me.TileViewColumn1.Caption = "ID"
        Me.TileViewColumn1.FieldName = "ID"
        Me.TileViewColumn1.Name = "TileViewColumn1"
        Me.TileViewColumn1.Visible = True
        Me.TileViewColumn1.VisibleIndex = 0
        '
        'colApellidos
        '
        Me.colApellidos.Caption = "APELLIDOS"
        Me.colApellidos.FieldName = "TELEFONO"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 8
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 5
        '
        'TileViewColumn4
        '
        Me.TileViewColumn4.Caption = "Sexo"
        Me.TileViewColumn4.FieldName = "SEXO"
        Me.TileViewColumn4.Name = "TileViewColumn4"
        Me.TileViewColumn4.Visible = True
        Me.TileViewColumn4.VisibleIndex = 3
        '
        'colFoto
        '
        Me.colFoto.Caption = "FOTO"
        Me.colFoto.FieldName = "FOTO"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Visible = True
        Me.colFoto.VisibleIndex = 9
        '
        'cboCliente
        '
        Me.cboCliente.EditValue = "SELECCIONAR"
        Me.cboCliente.Location = New System.Drawing.Point(80, 14)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cboCliente.Properties.Appearance.Options.UseFont = True
        Me.cboCliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCliente.Properties.NullText = ""
        Me.cboCliente.Properties.PopupView = Me.GridView5
        Me.cboCliente.Size = New System.Drawing.Size(298, 22)
        Me.cboCliente.TabIndex = 255
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCLIENTE, Me.IDENTIFICACION, Me.CLIENTE, Me.CONTACTO, Me.TELEFONO})
        Me.GridView5.DetailHeight = 200
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView5.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.EnableAppearanceOddRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colIDCLIENTE
        '
        Me.colIDCLIENTE.Caption = "ID"
        Me.colIDCLIENTE.FieldName = "IDCLIENTE"
        Me.colIDCLIENTE.Name = "colIDCLIENTE"
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.Caption = "IDENTIFICACION"
        Me.IDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.Visible = True
        Me.IDENTIFICACION.VisibleIndex = 0
        '
        'CLIENTE
        '
        Me.CLIENTE.Caption = "CLIENTE"
        Me.CLIENTE.FieldName = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Visible = True
        Me.CLIENTE.VisibleIndex = 1
        '
        'CONTACTO
        '
        Me.CONTACTO.Caption = "CONTACTO"
        Me.CONTACTO.FieldName = "CONTACTO"
        Me.CONTACTO.Name = "CONTACTO"
        Me.CONTACTO.Visible = True
        Me.CONTACTO.VisibleIndex = 2
        '
        'TELEFONO
        '
        Me.TELEFONO.Caption = "TELEFONO"
        Me.TELEFONO.FieldName = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Visible = True
        Me.TELEFONO.VisibleIndex = 3
        '
        'btnClientes
        '
        Me.btnClientes.ImageOptions.Image = CType(resources.GetObject("btnClientes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(384, 11)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(26, 26)
        Me.btnClientes.TabIndex = 254
        Me.btnClientes.Text = "Registro de Clientes"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(18, 289)
        Me.txtConsecutivo.MenuManager = Me.BarManager1
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtConsecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConsecutivo.Properties.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(76, 28)
        Me.txtConsecutivo.TabIndex = 252
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(19, 264)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(50, 22)
        Me.LabelControl18.TabIndex = 253
        Me.LabelControl18.Text = "Cons. "
        '
        'xtpConsultaCierreCaja
        '
        Me.xtpConsultaCierreCaja.Controls.Add(Me.GCConsultaCierre)
        Me.xtpConsultaCierreCaja.Name = "xtpConsultaCierreCaja"
        Me.xtpConsultaCierreCaja.Size = New System.Drawing.Size(1098, 435)
        Me.xtpConsultaCierreCaja.Text = "Consulta Cierres"
        '
        'GCConsultaCierre
        '
        Me.GCConsultaCierre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCConsultaCierre.Location = New System.Drawing.Point(11, 12)
        Me.GCConsultaCierre.MainView = Me.GVConsultaCierre
        Me.GCConsultaCierre.MenuManager = Me.BarManager1
        Me.GCConsultaCierre.Name = "GCConsultaCierre"
        Me.GCConsultaCierre.Size = New System.Drawing.Size(1076, 412)
        Me.GCConsultaCierre.TabIndex = 37
        Me.GCConsultaCierre.UseEmbeddedNavigator = True
        Me.GCConsultaCierre.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultaCierre})
        '
        'GVConsultaCierre
        '
        Me.GVConsultaCierre.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCierre, Me.colFECHACIERRE, Me.colSALDO, Me.colOBSERVACION, Me.colELABORADOCIERRE})
        Me.GVConsultaCierre.GridControl = Me.GCConsultaCierre
        Me.GVConsultaCierre.Name = "GVConsultaCierre"
        Me.GVConsultaCierre.OptionsBehavior.Editable = False
        Me.GVConsultaCierre.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultaCierre.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultaCierre.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultaCierre.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultaCierre.OptionsPrint.PrintFooter = False
        Me.GVConsultaCierre.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultaCierre.OptionsView.ShowFooter = True
        Me.GVConsultaCierre.OptionsView.ShowGroupPanel = False
        '
        'colIDCierre
        '
        Me.colIDCierre.Caption = "ID"
        Me.colIDCierre.FieldName = "ID"
        Me.colIDCierre.Name = "colIDCierre"
        '
        'colFECHACIERRE
        '
        Me.colFECHACIERRE.Caption = "FECHA"
        Me.colFECHACIERRE.FieldName = "FECHA"
        Me.colFECHACIERRE.Name = "colFECHACIERRE"
        Me.colFECHACIERRE.Visible = True
        Me.colFECHACIERRE.VisibleIndex = 0
        Me.colFECHACIERRE.Width = 94
        '
        'colSALDO
        '
        Me.colSALDO.Caption = "SALDO"
        Me.colSALDO.DisplayFormat.FormatString = "{0:C0}"
        Me.colSALDO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSALDO.FieldName = "SALDO"
        Me.colSALDO.Name = "colSALDO"
        Me.colSALDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SALDO", "{0:C0}")})
        Me.colSALDO.Visible = True
        Me.colSALDO.VisibleIndex = 1
        Me.colSALDO.Width = 140
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.Caption = "OBSERVACION"
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 2
        Me.colOBSERVACION.Width = 317
        '
        'colELABORADOCIERRE
        '
        Me.colELABORADOCIERRE.Caption = "ELABORADO"
        Me.colELABORADOCIERRE.FieldName = "ELABORADO"
        Me.colELABORADOCIERRE.Name = "colELABORADOCIERRE"
        Me.colELABORADOCIERRE.Visible = True
        Me.colELABORADOCIERRE.VisibleIndex = 3
        Me.colELABORADOCIERRE.Width = 501
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'frmReciboCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 485)
        Me.Controls.Add(Me.xtcCaja)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmReciboCaja.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Caja"
        CType(Me.txtGenerado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCierre.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRecibosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCRecibosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCierre.ResumeLayout(False)
        Me.xtpCierre.PerformLayout()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpConsultarRecibos.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCaja.ResumeLayout(False)
        Me.xtpCaja.ResumeLayout(False)
        Me.xtpCaja.PerformLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCuentasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCuentasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpConsultaCierreCaja.ResumeLayout(False)
        CType(Me.GCConsultaCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultaCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGenerado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents xtcCaja As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpConsultarRecibos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDRECIBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELABORADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpCaja As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroRecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xtpCierre As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GCRecibosPendientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRecibosPendientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRECIBOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDENP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIDOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELABORADOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCerrarCaja As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaCierre As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtElaborado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDatosCliente As DevExpress.XtraGrid.GridControl
    Friend WithEvents TVDatosCliente As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCCuentasClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCuentasClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GCDetallePagoDocumento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetallePagoDocumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTODETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORDETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminarFormaPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFormaPagoValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregarFormaPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTipoDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiOrdenServicio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtpConsultaCierreCaja As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultaCierre As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultaCierre As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCierre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHACIERRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELABORADOCIERRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
End Class

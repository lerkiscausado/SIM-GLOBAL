<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTarifa
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTarifa))
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAbrir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.DTDetalleTarifaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDetalleTarifaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDetalleTarifa = New SIM___GLOBAL.DSDetalleTarifa()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_CUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_ATENCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTipoAtencion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCups = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtEstudio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTarifa = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DSDetalleTarifaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTDetalleTarifaTableAdapter = New SIM___GLOBAL.DSDetalleTarifaTableAdapters.DTDetalleTarifaTableAdapter()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTDetalleTarifaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDetalleTarifaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDetalleTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAtencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDetalleTarifaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(88, 58)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Properties.MaxLength = 50
        Me.txtCodigo.Size = New System.Drawing.Size(126, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiEliminar, Me.bbiAbrir})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAbrir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiAbrir
        '
        Me.bbiAbrir.Caption = "Abir"
        Me.bbiAbrir.Id = 6
        Me.bbiAbrir.ImageOptions.Image = CType(resources.GetObject("bbiAbrir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAbrir.Name = "bbiAbrir"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar "
        Me.bbiEliminar.Enabled = False
        Me.bbiEliminar.Id = 5
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
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
        Me.bbiImprimir.Enabled = False
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1083, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 330)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1083, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 299)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1083, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 299)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GCConsultar)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboTipoAtencion)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtValor)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboCups)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtEstudio)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboTarifa)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.chkEstado)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtCodigo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtID)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1083, 299)
        Me.SplitContainerControl1.SplitterPosition = 592
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GCConsultar
        '
        Me.GCConsultar.DataSource = Me.DTDetalleTarifaBindingSource
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(592, 299)
        Me.GCConsultar.TabIndex = 1
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'DTDetalleTarifaBindingSource
        '
        Me.DTDetalleTarifaBindingSource.DataMember = "DTDetalleTarifa"
        Me.DTDetalleTarifaBindingSource.DataSource = Me.DSDetalleTarifaBindingSource1
        '
        'DSDetalleTarifaBindingSource1
        '
        Me.DSDetalleTarifaBindingSource1.DataSource = Me.DSDetalleTarifa
        Me.DSDetalleTarifaBindingSource1.Position = 0
        '
        'DSDetalleTarifa
        '
        Me.DSDetalleTarifa.DataSetName = "DSDetalleTarifa"
        Me.DSDetalleTarifa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCODIGO, Me.colESTUDIO, Me.colVALOR, Me.colCUPS, Me.colCODIGO_CUPS, Me.colTIPO_ATENCION, Me.colTARIFA, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colCODIGO
        '
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 1
        '
        'colESTUDIO
        '
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 2
        '
        'colVALOR
        '
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 3
        '
        'colCUPS
        '
        Me.colCUPS.FieldName = "CUPS"
        Me.colCUPS.Name = "colCUPS"
        Me.colCUPS.Visible = True
        Me.colCUPS.VisibleIndex = 4
        '
        'colCODIGO_CUPS
        '
        Me.colCODIGO_CUPS.Caption = "CODIGO CUPS"
        Me.colCODIGO_CUPS.FieldName = "CODIGO_CUPS"
        Me.colCODIGO_CUPS.Name = "colCODIGO_CUPS"
        Me.colCODIGO_CUPS.Visible = True
        Me.colCODIGO_CUPS.VisibleIndex = 5
        Me.colCODIGO_CUPS.Width = 44
        '
        'colTIPO_ATENCION
        '
        Me.colTIPO_ATENCION.Caption = "TIPO ATENCION"
        Me.colTIPO_ATENCION.FieldName = "TIPO_ATENCION"
        Me.colTIPO_ATENCION.Name = "colTIPO_ATENCION"
        Me.colTIPO_ATENCION.Visible = True
        Me.colTIPO_ATENCION.VisibleIndex = 6
        Me.colTIPO_ATENCION.Width = 44
        '
        'colTARIFA
        '
        Me.colTARIFA.FieldName = "TARIFA"
        Me.colTARIFA.Name = "colTARIFA"
        Me.colTARIFA.Visible = True
        Me.colTARIFA.VisibleIndex = 7
        Me.colTARIFA.Width = 44
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 8
        '
        'cboTipoAtencion
        '
        Me.cboTipoAtencion.Location = New System.Drawing.Point(88, 162)
        Me.cboTipoAtencion.MenuManager = Me.BarManager1
        Me.cboTipoAtencion.Name = "cboTipoAtencion"
        Me.cboTipoAtencion.Properties.AutoComplete = False
        Me.cboTipoAtencion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAtencion.Properties.Items.AddRange(New Object() {"CONSULTA", "PROCEDIMIENTO"})
        Me.cboTipoAtencion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoAtencion.Size = New System.Drawing.Size(126, 20)
        Me.cboTipoAtencion.TabIndex = 18
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(9, 165)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Tipo Atencion:"
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(88, 136)
        Me.txtValor.MenuManager = Me.BarManager1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 50
        Me.txtValor.Size = New System.Drawing.Size(126, 20)
        Me.txtValor.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(50, 139)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Valor:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(50, 113)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Cups:"
        '
        'cboCups
        '
        Me.cboCups.Location = New System.Drawing.Point(88, 110)
        Me.cboCups.MenuManager = Me.BarManager1
        Me.cboCups.Name = "cboCups"
        Me.cboCups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCups.Properties.NullText = ""
        Me.cboCups.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboCups.Properties.PopupSizeable = False
        Me.cboCups.Size = New System.Drawing.Size(379, 20)
        Me.cboCups.TabIndex = 10
        '
        'txtEstudio
        '
        Me.txtEstudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEstudio.EnterMoveNextControl = True
        Me.txtEstudio.Location = New System.Drawing.Point(88, 84)
        Me.txtEstudio.MenuManager = Me.BarManager1
        Me.txtEstudio.Name = "txtEstudio"
        Me.txtEstudio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstudio.Properties.MaxLength = 50
        Me.txtEstudio.Size = New System.Drawing.Size(379, 20)
        Me.txtEstudio.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(39, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Estudio:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Tarifa:"
        '
        'cboTarifa
        '
        Me.cboTarifa.Location = New System.Drawing.Point(88, 32)
        Me.cboTarifa.MenuManager = Me.BarManager1
        Me.cboTarifa.Name = "cboTarifa"
        Me.cboTarifa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTarifa.Properties.NullText = ""
        Me.cboTarifa.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTarifa.Properties.PopupSizeable = False
        Me.cboTarifa.Size = New System.Drawing.Size(379, 20)
        Me.cboTarifa.TabIndex = 6
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(88, 188)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Size = New System.Drawing.Size(75, 19)
        Me.chkEstado.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(88, 6)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(41, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Codigo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(63, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID:"
        '
        'DTDetalleTarifaTableAdapter
        '
        Me.DTDetalleTarifaTableAdapter.ClearBeforeFill = True
        '
        'frmDetalleTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 330)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmDetalleTarifa"
        Me.Text = "Detalle de Tarifas"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTDetalleTarifaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDetalleTarifaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDetalleTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAtencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDetalleTarifaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCups As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtEstudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTarifa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboTipoAtencion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DSDetalleTarifaBindingSource As BindingSource
    Friend WithEvents DSDetalleTarifaBindingSource1 As BindingSource
    Friend WithEvents DSDetalleTarifa As DSDetalleTarifa
    Friend WithEvents DTDetalleTarifaBindingSource As BindingSource
    Friend WithEvents DTDetalleTarifaTableAdapter As DSDetalleTarifaTableAdapters.DTDetalleTarifaTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_ATENCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIFA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
End Class

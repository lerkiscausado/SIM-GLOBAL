<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoria))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.sbBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.xtcHistoriasAnteriores = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpEvolucionesPaciente = New DevExpress.XtraTab.XtraTabPage()
        Me.GCHistoriasAnteriores = New DevExpress.XtraGrid.GridControl()
        Me.gvHistoriasAnteriores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHAID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAConsulta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAEspecialidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizar = New DevExpress.XtraBars.BarButtonItem()
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
        Me.bbiMes = New DevExpress.XtraBars.BarSubItem()
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
        Me.bbiRemisiones = New DevExpress.XtraBars.BarButtonItem()
        Me.xtpEvolucionesSinFirma = New DevExpress.XtraTab.XtraTabPage()
        Me.GCHistoriasAnterioresSinFirma = New DevExpress.XtraGrid.GridControl()
        Me.GVHistoriasAnterioresSinFirma = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHASFID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASFFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASFCONSULTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASFESPECIALIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASFUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GCPacientesAtender = New DevExpress.XtraGrid.GridControl()
        Me.GVPacientesAtender = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btVistaPrevia = New DevExpress.XtraEditors.SimpleButton()
        Me.lblConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.cboProcedimiento = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkFirmar = New DevExpress.XtraEditors.CheckEdit()
        Me.cboDiagnosticos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtcHistoria = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpMotivoConsulta = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMotivoConsulta = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpAntecedentes = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFamiliares = New DevExpress.XtraEditors.MemoEdit()
        Me.txtPersonales = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpValoracion = New DevExpress.XtraTab.XtraTabPage()
        Me.txtValoracion = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpPlanSeguir = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPlanSeguir = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpEvoluciones = New DevExpress.XtraTab.XtraTabPage()
        Me.txtEvoluciones = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpRemision = New DevExpress.XtraTab.XtraTabPage()
        Me.txtRemision = New DevExpress.XtraEditors.MemoEdit()
        Me.txtHistoriaMesActual = New DevExpress.XtraEditors.TextEdit()
        Me.btnEvolucionPaciente = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEspecialista = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatosUsuario = New DevExpress.XtraEditors.MemoEdit()
        Me.lblConsecutivoOrden = New DevExpress.XtraEditors.LabelControl()
        Me.lblConsecutivo = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoHistoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaIngreso = New DevExpress.XtraEditors.DateEdit()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.xtcHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcHistoriasAnteriores.SuspendLayout()
        Me.xtpEvolucionesPaciente.SuspendLayout()
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpEvolucionesSinFirma.SuspendLayout()
        CType(Me.GCHistoriasAnterioresSinFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVHistoriasAnterioresSinFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFirmar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDiagnosticos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcHistoria.SuspendLayout()
        Me.xtpMotivoConsulta.SuspendLayout()
        CType(Me.txtMotivoConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAntecedentes.SuspendLayout()
        CType(Me.txtFamiliares.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersonales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpValoracion.SuspendLayout()
        CType(Me.txtValoracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPlanSeguir.SuspendLayout()
        CType(Me.txtPlanSeguir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpEvoluciones.SuspendLayout()
        CType(Me.txtEvoluciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpRemision.SuspendLayout()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHistoriaMesActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEspecialista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoHistoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.sbBuscar)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.xtcHistoriasAnteriores)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btVistaPrevia)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsulta)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboProcedimiento)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.chkFirmar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboDiagnosticos)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.xtcHistoria)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtHistoriaMesActual)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnEvolucionPaciente)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SeparatorControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl7)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtEspecialista)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDatosUsuario)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsecutivoOrden)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsecutivo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtCodigoHistoria)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dtFechaIngreso)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1137, 550)
        Me.SplitContainerControl1.SplitterPosition = 488
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'sbBuscar
        '
        Me.sbBuscar.ImageOptions.Image = CType(resources.GetObject("sbBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.sbBuscar.Location = New System.Drawing.Point(16, 505)
        Me.sbBuscar.Name = "sbBuscar"
        Me.sbBuscar.Size = New System.Drawing.Size(23, 20)
        Me.sbBuscar.TabIndex = 20
        Me.sbBuscar.Text = "Consutar Historias Anteriores"
        '
        'xtcHistoriasAnteriores
        '
        Me.xtcHistoriasAnteriores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcHistoriasAnteriores.Location = New System.Drawing.Point(14, 268)
        Me.xtcHistoriasAnteriores.Name = "xtcHistoriasAnteriores"
        Me.xtcHistoriasAnteriores.SelectedTabPage = Me.xtpEvolucionesPaciente
        Me.xtcHistoriasAnteriores.Size = New System.Drawing.Size(463, 234)
        Me.xtcHistoriasAnteriores.TabIndex = 49
        Me.xtcHistoriasAnteriores.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpEvolucionesPaciente, Me.xtpEvolucionesSinFirma})
        '
        'xtpEvolucionesPaciente
        '
        Me.xtpEvolucionesPaciente.Controls.Add(Me.GCHistoriasAnteriores)
        Me.xtpEvolucionesPaciente.Name = "xtpEvolucionesPaciente"
        Me.xtpEvolucionesPaciente.Size = New System.Drawing.Size(457, 206)
        Me.xtpEvolucionesPaciente.Text = "Evoluciones del Paciente"
        '
        'GCHistoriasAnteriores
        '
        Me.GCHistoriasAnteriores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHistoriasAnteriores.Location = New System.Drawing.Point(0, 0)
        Me.GCHistoriasAnteriores.MainView = Me.gvHistoriasAnteriores
        Me.GCHistoriasAnteriores.MenuManager = Me.BarManager1
        Me.GCHistoriasAnteriores.Name = "GCHistoriasAnteriores"
        Me.GCHistoriasAnteriores.Size = New System.Drawing.Size(457, 206)
        Me.GCHistoriasAnteriores.TabIndex = 3
        Me.GCHistoriasAnteriores.UseEmbeddedNavigator = True
        Me.GCHistoriasAnteriores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHistoriasAnteriores})
        '
        'gvHistoriasAnteriores
        '
        Me.gvHistoriasAnteriores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHAID, Me.colHAFecha, Me.colHAConsulta, Me.colHAEspecialidad, Me.colHAUsuario})
        Me.gvHistoriasAnteriores.GridControl = Me.GCHistoriasAnteriores
        Me.gvHistoriasAnteriores.Name = "gvHistoriasAnteriores"
        Me.gvHistoriasAnteriores.OptionsBehavior.Editable = False
        Me.gvHistoriasAnteriores.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvHistoriasAnteriores.OptionsCustomization.AllowRowSizing = True
        Me.gvHistoriasAnteriores.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.gvHistoriasAnteriores.OptionsView.ColumnAutoWidth = False
        Me.gvHistoriasAnteriores.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvHistoriasAnteriores.OptionsView.EnableAppearanceOddRow = True
        Me.gvHistoriasAnteriores.OptionsView.RowAutoHeight = True
        Me.gvHistoriasAnteriores.OptionsView.ShowGroupPanel = False
        '
        'colHAID
        '
        Me.colHAID.Caption = "ID"
        Me.colHAID.FieldName = "ID"
        Me.colHAID.Name = "colHAID"
        Me.colHAID.Width = 53
        '
        'colHAFecha
        '
        Me.colHAFecha.Caption = "FECHA"
        Me.colHAFecha.FieldName = "FECHA"
        Me.colHAFecha.Name = "colHAFecha"
        Me.colHAFecha.Visible = True
        Me.colHAFecha.VisibleIndex = 0
        Me.colHAFecha.Width = 81
        '
        'colHAConsulta
        '
        Me.colHAConsulta.Caption = "CONSULTA"
        Me.colHAConsulta.FieldName = "CONSULTA"
        Me.colHAConsulta.Name = "colHAConsulta"
        Me.colHAConsulta.Visible = True
        Me.colHAConsulta.VisibleIndex = 1
        Me.colHAConsulta.Width = 283
        '
        'colHAEspecialidad
        '
        Me.colHAEspecialidad.Caption = "ESPECIALIDAD"
        Me.colHAEspecialidad.FieldName = "ESPECIALIDAD"
        Me.colHAEspecialidad.Name = "colHAEspecialidad"
        Me.colHAEspecialidad.Visible = True
        Me.colHAEspecialidad.VisibleIndex = 2
        Me.colHAEspecialidad.Width = 181
        '
        'colHAUsuario
        '
        Me.colHAUsuario.Caption = "USUARIO"
        Me.colHAUsuario.FieldName = "USUARIO"
        Me.colHAUsuario.Name = "colHAUsuario"
        Me.colHAUsuario.Width = 347
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiAbrir, Me.bbiGuardar, Me.BarButtonItem4, Me.BarButtonItem5, Me.bbiConsultar, Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.bbiMes, Me.bbiEnero, Me.bbiFebrero, Me.bbiMarzo, Me.bbiAbril, Me.bbiMayo, Me.bbiJunio, Me.bbiJulio, Me.bbiAgosto, Me.bbiSeptiembre, Me.bbiOctubre, Me.bbiNoviembre, Me.bbiDiciembre, Me.bbiRemisiones, Me.bbiActualizar})
        Me.BarManager1.MaxItemId = 34
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar)})
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
        'bbiActualizar
        '
        Me.bbiActualizar.Caption = "Actualizar Listado de Pacientes"
        Me.bbiActualizar.Id = 33
        Me.bbiActualizar.ImageOptions.Image = CType(resources.GetObject("bbiActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActualizar.Name = "bbiActualizar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1137, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 581)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1137, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 550)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1137, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 550)
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
        'bbiMes
        '
        Me.bbiMes.Caption = "Seleccionar Mes"
        Me.bbiMes.Id = 19
        Me.bbiMes.ImageOptions.Image = CType(resources.GetObject("bbiMes.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiMes.ImageOptions.LargeImage = CType(resources.GetObject("bbiMes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiMes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEnero), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFebrero), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMarzo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAbril), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMayo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJunio), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJulio), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAgosto), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSeptiembre), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOctubre), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNoviembre), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDiciembre)})
        Me.bbiMes.Name = "bbiMes"
        Me.bbiMes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'bbiRemisiones
        '
        Me.bbiRemisiones.Caption = "Remisiones"
        Me.bbiRemisiones.Enabled = False
        Me.bbiRemisiones.Id = 32
        Me.bbiRemisiones.ImageOptions.Image = CType(resources.GetObject("bbiRemisiones.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiRemisiones.Name = "bbiRemisiones"
        '
        'xtpEvolucionesSinFirma
        '
        Me.xtpEvolucionesSinFirma.Controls.Add(Me.GCHistoriasAnterioresSinFirma)
        Me.xtpEvolucionesSinFirma.Name = "xtpEvolucionesSinFirma"
        Me.xtpEvolucionesSinFirma.Size = New System.Drawing.Size(457, 206)
        Me.xtpEvolucionesSinFirma.Text = "Evoluciones sin Firmar"
        '
        'GCHistoriasAnterioresSinFirma
        '
        Me.GCHistoriasAnterioresSinFirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHistoriasAnterioresSinFirma.Location = New System.Drawing.Point(0, 0)
        Me.GCHistoriasAnterioresSinFirma.MainView = Me.GVHistoriasAnterioresSinFirma
        Me.GCHistoriasAnterioresSinFirma.MenuManager = Me.BarManager1
        Me.GCHistoriasAnterioresSinFirma.Name = "GCHistoriasAnterioresSinFirma"
        Me.GCHistoriasAnterioresSinFirma.Size = New System.Drawing.Size(457, 206)
        Me.GCHistoriasAnterioresSinFirma.TabIndex = 4
        Me.GCHistoriasAnterioresSinFirma.UseEmbeddedNavigator = True
        Me.GCHistoriasAnterioresSinFirma.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVHistoriasAnterioresSinFirma})
        '
        'GVHistoriasAnterioresSinFirma
        '
        Me.GVHistoriasAnterioresSinFirma.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHASFID, Me.colHASFFECHA, Me.colHASFCONSULTA, Me.colHASFESPECIALIDAD, Me.colHASFUSUARIO})
        Me.GVHistoriasAnterioresSinFirma.GridControl = Me.GCHistoriasAnterioresSinFirma
        Me.GVHistoriasAnterioresSinFirma.Name = "GVHistoriasAnterioresSinFirma"
        Me.GVHistoriasAnterioresSinFirma.OptionsBehavior.Editable = False
        Me.GVHistoriasAnterioresSinFirma.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVHistoriasAnterioresSinFirma.OptionsCustomization.AllowRowSizing = True
        Me.GVHistoriasAnterioresSinFirma.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVHistoriasAnterioresSinFirma.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVHistoriasAnterioresSinFirma.OptionsView.EnableAppearanceOddRow = True
        Me.GVHistoriasAnterioresSinFirma.OptionsView.RowAutoHeight = True
        Me.GVHistoriasAnterioresSinFirma.OptionsView.ShowFooter = True
        Me.GVHistoriasAnterioresSinFirma.OptionsView.ShowGroupPanel = False
        '
        'colHASFID
        '
        Me.colHASFID.Caption = "ID"
        Me.colHASFID.FieldName = "ID"
        Me.colHASFID.Name = "colHASFID"
        '
        'colHASFFECHA
        '
        Me.colHASFFECHA.Caption = "FECHA"
        Me.colHASFFECHA.FieldName = "FECHA"
        Me.colHASFFECHA.Name = "colHASFFECHA"
        Me.colHASFFECHA.Visible = True
        Me.colHASFFECHA.VisibleIndex = 0
        Me.colHASFFECHA.Width = 81
        '
        'colHASFCONSULTA
        '
        Me.colHASFCONSULTA.Caption = "CONSULTA"
        Me.colHASFCONSULTA.FieldName = "CONSULTA"
        Me.colHASFCONSULTA.Name = "colHASFCONSULTA"
        Me.colHASFCONSULTA.Visible = True
        Me.colHASFCONSULTA.VisibleIndex = 1
        Me.colHASFCONSULTA.Width = 358
        '
        'colHASFESPECIALIDAD
        '
        Me.colHASFESPECIALIDAD.Caption = "ESPECIALIDAD"
        Me.colHASFESPECIALIDAD.FieldName = "ESPECIALIDAD"
        Me.colHASFESPECIALIDAD.Name = "colHASFESPECIALIDAD"
        '
        'colHASFUSUARIO
        '
        Me.colHASFUSUARIO.Caption = "USUARIO"
        Me.colHASFUSUARIO.FieldName = "USUARIO"
        Me.colHASFUSUARIO.Name = "colHASFUSUARIO"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.GCPacientesAtender)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(465, 256)
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
        Me.GCPacientesAtender.Size = New System.Drawing.Size(461, 234)
        Me.GCPacientesAtender.TabIndex = 1
        Me.GCPacientesAtender.UseEmbeddedNavigator = True
        Me.GCPacientesAtender.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPacientesAtender})
        '
        'GVPacientesAtender
        '
        Me.GVPacientesAtender.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrden, Me.colFechaIngreso, Me.colIdentificacion, Me.colUsuario, Me.colSexo, Me.colContrato, Me.colEstado, Me.colIDContrato})
        Me.GVPacientesAtender.GridControl = Me.GCPacientesAtender
        Me.GVPacientesAtender.Name = "GVPacientesAtender"
        Me.GVPacientesAtender.OptionsBehavior.Editable = False
        Me.GVPacientesAtender.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVPacientesAtender.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVPacientesAtender.OptionsPrint.ExpandAllDetails = True
        Me.GVPacientesAtender.OptionsPrint.ExpandAllGroups = False
        Me.GVPacientesAtender.OptionsPrint.PrintFooter = False
        Me.GVPacientesAtender.OptionsView.ColumnAutoWidth = False
        Me.GVPacientesAtender.OptionsView.EnableAppearanceOddRow = True
        Me.GVPacientesAtender.OptionsView.ShowGroupPanel = False
        '
        'colOrden
        '
        Me.colOrden.Caption = "ORDEN"
        Me.colOrden.FieldName = "ORDEN"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Width = 48
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "FECHA"
        Me.colFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 0
        Me.colFechaIngreso.Width = 64
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "IDENTIFICACION"
        Me.colIdentificacion.FieldName = "IDENTIFICACION"
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.Visible = True
        Me.colIdentificacion.VisibleIndex = 1
        Me.colIdentificacion.Width = 96
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "USUARIO"
        Me.colUsuario.FieldName = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 2
        Me.colUsuario.Width = 187
        '
        'colSexo
        '
        Me.colSexo.Caption = "SEXO"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 3
        Me.colSexo.Width = 43
        '
        'colContrato
        '
        Me.colContrato.Caption = "CONTRATO"
        Me.colContrato.FieldName = "CONTRATO"
        Me.colContrato.Name = "colContrato"
        Me.colContrato.Visible = True
        Me.colContrato.VisibleIndex = 4
        Me.colContrato.Width = 433
        '
        'colEstado
        '
        Me.colEstado.Caption = "ESTADO"
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Width = 92
        '
        'colIDContrato
        '
        Me.colIDContrato.Caption = "ID CONTRATO"
        Me.colIDContrato.FieldName = "ID_CONTRATO"
        Me.colIDContrato.Name = "colIDContrato"
        '
        'btVistaPrevia
        '
        Me.btVistaPrevia.ImageOptions.Image = CType(resources.GetObject("btVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.btVistaPrevia.Location = New System.Drawing.Point(43, 505)
        Me.btVistaPrevia.Name = "btVistaPrevia"
        Me.btVistaPrevia.Size = New System.Drawing.Size(23, 20)
        Me.btVistaPrevia.TabIndex = 19
        Me.btVistaPrevia.Text = "Vista Previa Historias Clinicas"
        '
        'lblConsulta
        '
        Me.lblConsulta.Location = New System.Drawing.Point(21, 235)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(46, 13)
        Me.lblConsulta.TabIndex = 106
        Me.lblConsulta.Text = "Consulta:"
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.Location = New System.Drawing.Point(74, 232)
        Me.cboProcedimiento.MenuManager = Me.BarManager1
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcedimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "CODIGO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTUDIO", "ESTUDIO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUPS", "CUPS"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VALOR", "VALOR", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_TIPO_ESTUDIO", "TIPOESTUDIO")})
        Me.cboProcedimiento.Properties.NullText = ""
        Me.cboProcedimiento.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboProcedimiento.Properties.PopupWidth = 600
        Me.cboProcedimiento.Properties.ShowHeader = False
        Me.cboProcedimiento.Size = New System.Drawing.Size(440, 20)
        Me.cboProcedimiento.TabIndex = 105
        '
        'chkFirmar
        '
        Me.chkFirmar.Location = New System.Drawing.Point(439, 258)
        Me.chkFirmar.MenuManager = Me.BarManager1
        Me.chkFirmar.Name = "chkFirmar"
        Me.chkFirmar.Properties.Caption = "Firmar"
        Me.chkFirmar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkFirmar.Size = New System.Drawing.Size(75, 19)
        Me.chkFirmar.TabIndex = 104
        '
        'cboDiagnosticos
        '
        Me.cboDiagnosticos.EditValue = ""
        Me.cboDiagnosticos.Location = New System.Drawing.Point(74, 258)
        Me.cboDiagnosticos.Name = "cboDiagnosticos"
        Me.cboDiagnosticos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDiagnosticos.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cboDiagnosticos.Size = New System.Drawing.Size(178, 20)
        Me.cboDiagnosticos.TabIndex = 88
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
        'xtcHistoria
        '
        Me.xtcHistoria.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcHistoria.Location = New System.Drawing.Point(10, 291)
        Me.xtcHistoria.Name = "xtcHistoria"
        Me.xtcHistoria.SelectedTabPage = Me.xtpMotivoConsulta
        Me.xtcHistoria.Size = New System.Drawing.Size(504, 239)
        Me.xtcHistoria.TabIndex = 50
        Me.xtcHistoria.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpMotivoConsulta, Me.xtpAntecedentes, Me.xtpValoracion, Me.xtpPlanSeguir, Me.xtpEvoluciones, Me.xtpRemision})
        '
        'xtpMotivoConsulta
        '
        Me.xtpMotivoConsulta.Controls.Add(Me.txtMotivoConsulta)
        Me.xtpMotivoConsulta.Name = "xtpMotivoConsulta"
        Me.xtpMotivoConsulta.Size = New System.Drawing.Size(498, 211)
        Me.xtpMotivoConsulta.Text = "Motivo de Consulta"
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(5, 7)
        Me.txtMotivoConsulta.MenuManager = Me.BarManager1
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMotivoConsulta.Properties.Appearance.Options.UseBackColor = True
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(490, 197)
        Me.txtMotivoConsulta.TabIndex = 34
        '
        'xtpAntecedentes
        '
        Me.xtpAntecedentes.Controls.Add(Me.LabelControl8)
        Me.xtpAntecedentes.Controls.Add(Me.LabelControl4)
        Me.xtpAntecedentes.Controls.Add(Me.txtFamiliares)
        Me.xtpAntecedentes.Controls.Add(Me.txtPersonales)
        Me.xtpAntecedentes.Name = "xtpAntecedentes"
        Me.xtpAntecedentes.Size = New System.Drawing.Size(498, 211)
        Me.xtpAntecedentes.Text = "Antecedentes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(4, 106)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "Familiares:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(4, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Personales"
        '
        'txtFamiliares
        '
        Me.txtFamiliares.Location = New System.Drawing.Point(4, 125)
        Me.txtFamiliares.MenuManager = Me.BarManager1
        Me.txtFamiliares.Name = "txtFamiliares"
        Me.txtFamiliares.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFamiliares.Properties.Appearance.Options.UseBackColor = True
        Me.txtFamiliares.Size = New System.Drawing.Size(490, 71)
        Me.txtFamiliares.TabIndex = 36
        '
        'txtPersonales
        '
        Me.txtPersonales.Location = New System.Drawing.Point(4, 31)
        Me.txtPersonales.MenuManager = Me.BarManager1
        Me.txtPersonales.Name = "txtPersonales"
        Me.txtPersonales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPersonales.Properties.Appearance.Options.UseBackColor = True
        Me.txtPersonales.Size = New System.Drawing.Size(490, 67)
        Me.txtPersonales.TabIndex = 35
        '
        'xtpValoracion
        '
        Me.xtpValoracion.Controls.Add(Me.txtValoracion)
        Me.xtpValoracion.Name = "xtpValoracion"
        Me.xtpValoracion.Size = New System.Drawing.Size(498, 211)
        Me.xtpValoracion.Text = "Valoracion"
        '
        'txtValoracion
        '
        Me.txtValoracion.Location = New System.Drawing.Point(4, 7)
        Me.txtValoracion.MenuManager = Me.BarManager1
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValoracion.Properties.Appearance.Options.UseBackColor = True
        Me.txtValoracion.Size = New System.Drawing.Size(490, 197)
        Me.txtValoracion.TabIndex = 36
        '
        'xtpPlanSeguir
        '
        Me.xtpPlanSeguir.Controls.Add(Me.txtPlanSeguir)
        Me.xtpPlanSeguir.Name = "xtpPlanSeguir"
        Me.xtpPlanSeguir.Size = New System.Drawing.Size(498, 211)
        Me.xtpPlanSeguir.Text = "Analisis y Plan a Seguir"
        '
        'txtPlanSeguir
        '
        Me.txtPlanSeguir.Location = New System.Drawing.Point(4, 7)
        Me.txtPlanSeguir.MenuManager = Me.BarManager1
        Me.txtPlanSeguir.Name = "txtPlanSeguir"
        Me.txtPlanSeguir.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPlanSeguir.Properties.Appearance.Options.UseBackColor = True
        Me.txtPlanSeguir.Size = New System.Drawing.Size(490, 197)
        Me.txtPlanSeguir.TabIndex = 35
        '
        'xtpEvoluciones
        '
        Me.xtpEvoluciones.Controls.Add(Me.txtEvoluciones)
        Me.xtpEvoluciones.Name = "xtpEvoluciones"
        Me.xtpEvoluciones.PageVisible = False
        Me.xtpEvoluciones.Size = New System.Drawing.Size(498, 211)
        Me.xtpEvoluciones.Text = "Evoluciones"
        '
        'txtEvoluciones
        '
        Me.txtEvoluciones.Location = New System.Drawing.Point(4, 7)
        Me.txtEvoluciones.MenuManager = Me.BarManager1
        Me.txtEvoluciones.Name = "txtEvoluciones"
        Me.txtEvoluciones.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEvoluciones.Properties.Appearance.Options.UseBackColor = True
        Me.txtEvoluciones.Size = New System.Drawing.Size(490, 197)
        Me.txtEvoluciones.TabIndex = 35
        '
        'xtpRemision
        '
        Me.xtpRemision.Controls.Add(Me.txtRemision)
        Me.xtpRemision.Name = "xtpRemision"
        Me.xtpRemision.Size = New System.Drawing.Size(498, 211)
        Me.xtpRemision.Text = "Remision"
        '
        'txtRemision
        '
        Me.txtRemision.Location = New System.Drawing.Point(4, 7)
        Me.txtRemision.MenuManager = Me.BarManager1
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemision.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemision.Size = New System.Drawing.Size(490, 197)
        Me.txtRemision.TabIndex = 35
        '
        'txtHistoriaMesActual
        '
        Me.txtHistoriaMesActual.EditValue = ""
        Me.txtHistoriaMesActual.Location = New System.Drawing.Point(258, 258)
        Me.txtHistoriaMesActual.MenuManager = Me.BarManager1
        Me.txtHistoriaMesActual.Name = "txtHistoriaMesActual"
        Me.txtHistoriaMesActual.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtHistoriaMesActual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistoriaMesActual.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtHistoriaMesActual.Properties.Appearance.Options.UseBackColor = True
        Me.txtHistoriaMesActual.Properties.Appearance.Options.UseFont = True
        Me.txtHistoriaMesActual.Properties.Appearance.Options.UseForeColor = True
        Me.txtHistoriaMesActual.Properties.ReadOnly = True
        Me.txtHistoriaMesActual.Size = New System.Drawing.Size(172, 22)
        Me.txtHistoriaMesActual.TabIndex = 44
        Me.txtHistoriaMesActual.Visible = False
        '
        'btnEvolucionPaciente
        '
        Me.btnEvolucionPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvolucionPaciente.ImageOptions.Image = CType(resources.GetObject("btnEvolucionPaciente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEvolucionPaciente.Location = New System.Drawing.Point(587, 6)
        Me.btnEvolucionPaciente.Name = "btnEvolucionPaciente"
        Me.btnEvolucionPaciente.Size = New System.Drawing.Size(26, 23)
        Me.btnEvolucionPaciente.TabIndex = 43
        Me.btnEvolucionPaciente.Text = "Vista Previa Historias Clinicas"
        Me.btnEvolucionPaciente.Visible = False
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.Location = New System.Drawing.Point(8, 80)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(506, 20)
        Me.SeparatorControl1.TabIndex = 42
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(530, 29)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl3.TabIndex = 41
        Me.LabelControl3.Text = "Evolucion del Paciente"
        Me.LabelControl3.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 261)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "Diagnostico:"
        '
        'txtEspecialista
        '
        Me.txtEspecialista.Location = New System.Drawing.Point(74, 24)
        Me.txtEspecialista.MenuManager = Me.BarManager1
        Me.txtEspecialista.Name = "txtEspecialista"
        Me.txtEspecialista.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtEspecialista.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialista.Properties.Appearance.Options.UseBackColor = True
        Me.txtEspecialista.Properties.Appearance.Options.UseFont = True
        Me.txtEspecialista.Properties.ReadOnly = True
        Me.txtEspecialista.Size = New System.Drawing.Size(440, 22)
        Me.txtEspecialista.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 29)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "Especialista:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 104)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Datos de Paciente:"
        '
        'txtDatosUsuario
        '
        Me.txtDatosUsuario.Location = New System.Drawing.Point(10, 123)
        Me.txtDatosUsuario.MenuManager = Me.BarManager1
        Me.txtDatosUsuario.Name = "txtDatosUsuario"
        Me.txtDatosUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDatosUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtDatosUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtDatosUsuario.Properties.ReadOnly = True
        Me.txtDatosUsuario.Size = New System.Drawing.Size(504, 101)
        Me.txtDatosUsuario.TabIndex = 34
        '
        'lblConsecutivoOrden
        '
        Me.lblConsecutivoOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivoOrden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConsecutivoOrden.Appearance.Options.UseFont = True
        Me.lblConsecutivoOrden.Appearance.Options.UseForeColor = True
        Me.lblConsecutivoOrden.Location = New System.Drawing.Point(504, 101)
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
        Me.lblConsecutivo.Location = New System.Drawing.Point(297, 101)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(46, 16)
        Me.lblConsecutivo.TabIndex = 16
        Me.lblConsecutivo.Text = "prueba"
        Me.lblConsecutivo.Visible = False
        '
        'txtCodigoHistoria
        '
        Me.txtCodigoHistoria.Location = New System.Drawing.Point(325, 53)
        Me.txtCodigoHistoria.MenuManager = Me.BarManager1
        Me.txtCodigoHistoria.Name = "txtCodigoHistoria"
        Me.txtCodigoHistoria.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoHistoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoHistoria.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoHistoria.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoHistoria.Properties.ReadOnly = True
        Me.txtCodigoHistoria.Size = New System.Drawing.Size(189, 22)
        Me.txtCodigoHistoria.TabIndex = 12
        Me.txtCodigoHistoria.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(224, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Codigo de Historia:"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Fecha:"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.EditValue = Nothing
        Me.dtFechaIngreso.Location = New System.Drawing.Point(74, 55)
        Me.dtFechaIngreso.MenuManager = Me.BarManager1
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.ReadOnly = True
        Me.dtFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaIngreso.TabIndex = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'frmHistoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 581)
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
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.xtcHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcHistoriasAnteriores.ResumeLayout(False)
        Me.xtpEvolucionesPaciente.ResumeLayout(False)
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpEvolucionesSinFirma.ResumeLayout(False)
        CType(Me.GCHistoriasAnterioresSinFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVHistoriasAnterioresSinFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFirmar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDiagnosticos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcHistoria.ResumeLayout(False)
        Me.xtpMotivoConsulta.ResumeLayout(False)
        CType(Me.txtMotivoConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAntecedentes.ResumeLayout(False)
        Me.xtpAntecedentes.PerformLayout()
        CType(Me.txtFamiliares.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersonales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpValoracion.ResumeLayout(False)
        CType(Me.txtValoracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPlanSeguir.ResumeLayout(False)
        CType(Me.txtPlanSeguir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpEvoluciones.ResumeLayout(False)
        CType(Me.txtEvoluciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpRemision.ResumeLayout(False)
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHistoriaMesActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEspecialista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoHistoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btVistaPrevia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRemisiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMes As DevExpress.XtraBars.BarSubItem
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCPacientesAtender As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPacientesAtender As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtHistoriaMesActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEvolucionPaciente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEspecialista As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatosUsuario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblConsecutivoOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblConsecutivo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoHistoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcHistoriasAnteriores As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpEvolucionesPaciente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCHistoriasAnteriores As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvHistoriasAnteriores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpEvolucionesSinFirma As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCHistoriasAnterioresSinFirma As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVHistoriasAnterioresSinFirma As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtcHistoria As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpMotivoConsulta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpAntecedentes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMotivoConsulta As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFamiliares As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtPersonales As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpPlanSeguir As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPlanSeguir As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpEvoluciones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEvoluciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpRemision As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtRemision As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDiagnosticos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkFirmar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents xtpValoracion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtValoracion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colHAID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAConsulta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAEspecialidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProcedimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colIDContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASFID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASFFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASFCONSULTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASFESPECIALIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASFUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
End Class

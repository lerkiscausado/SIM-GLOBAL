<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrivilegios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrivilegios))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_CARGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpArchivo = New DevExpress.XtraTab.XtraTabPage()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkAgenda = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAdjuntos = New DevExpress.XtraEditors.CheckEdit()
        Me.chkConsultar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAnular = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEditar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkNuevo = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkEndoscopia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkImagenes = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPatologia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCitologia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkProgramacionProcedimientos = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEvolucionPaciente = New DevExpress.XtraEditors.CheckEdit()
        Me.chkHistoriaGrupal = New DevExpress.XtraEditors.CheckEdit()
        Me.chkHistoriasAnteriores = New DevExpress.XtraEditors.CheckEdit()
        Me.chkHistoriaClinica = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer3 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkNomina = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInventario = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRips = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGenerarFactura = New DevExpress.XtraEditors.CheckEdit()
        Me.chkListadoOrdenes = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer4 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkIndicadoresGestion = New DevExpress.XtraEditors.CheckEdit()
        Me.chkImprimir = New DevExpress.XtraEditors.CheckEdit()
        Me.chkVistaPrevia = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.xtpAdministracion = New DevExpress.XtraTab.XtraTabPage()
        Me.AccordionControl2 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer5 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkUsuarios = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer6 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkSubEntidades = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDetalleTarifas = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTarifas = New DevExpress.XtraEditors.CheckEdit()
        Me.chkContratos = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEntidades = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer7 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkEmpleados = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEspecialidades = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCargos = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer8 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkEquiposApoyo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEstudiosPredeterminados = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTipoPatologia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCIE10 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCUPS = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMedicamentos = New DevExpress.XtraEditors.CheckEdit()
        Me.chkExamenes = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement7 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.xtpConfiguracion = New DevExpress.XtraTab.XtraTabPage()
        Me.AccordionControl3 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer9 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkFirma = New DevExpress.XtraEditors.CheckEdit()
        Me.chkLogo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEncabezadoPiePagina = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionContentContainer10 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkPrivilegios = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSeguridad = New DevExpress.XtraEditors.CheckEdit()
        Me.chkUsers = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement10 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.xtpAyuda = New DevExpress.XtraTab.XtraTabPage()
        Me.AccordionControl4 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer11 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.chkAcercaDe = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTutoriales = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSoporteTecnico = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAyudaProducto = New DevExpress.XtraEditors.CheckEdit()
        Me.AccordionControlElement11 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.txtDatosUsuario = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpArchivo.SuspendLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl1.SuspendLayout()
        Me.AccordionContentContainer1.SuspendLayout()
        CType(Me.chkAgenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAdjuntos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConsultar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEditar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNuevo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer2.SuspendLayout()
        CType(Me.chkEndoscopia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImagenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPatologia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCitologia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProgramacionProcedimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEvolucionPaciente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHistoriaGrupal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHistoriasAnteriores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHistoriaClinica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer3.SuspendLayout()
        CType(Me.chkNomina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGenerarFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkListadoOrdenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer4.SuspendLayout()
        CType(Me.chkIndicadoresGestion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImprimir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVistaPrevia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAdministracion.SuspendLayout()
        CType(Me.AccordionControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl2.SuspendLayout()
        Me.AccordionContentContainer5.SuspendLayout()
        CType(Me.chkUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer6.SuspendLayout()
        CType(Me.chkSubEntidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDetalleTarifas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTarifas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkContratos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEntidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer7.SuspendLayout()
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEspecialidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCargos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer8.SuspendLayout()
        CType(Me.chkEquiposApoyo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstudiosPredeterminados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTipoPatologia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCIE10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCUPS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedicamentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExamenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpConfiguracion.SuspendLayout()
        CType(Me.AccordionControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl3.SuspendLayout()
        Me.AccordionContentContainer9.SuspendLayout()
        CType(Me.chkFirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEncabezadoPiePagina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer10.SuspendLayout()
        CType(Me.chkPrivilegios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUsers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAyuda.SuspendLayout()
        CType(Me.AccordionControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl4.SuspendLayout()
        Me.AccordionContentContainer11.SuspendLayout()
        CType(Me.chkAcercaDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTutoriales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoporteTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAyudaProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridSplitContainer1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDatosUsuario)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1067, 489)
        Me.SplitContainerControl1.SplitterPosition = 447
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.GCConsultar
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.GCConsultar)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(447, 489)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(447, 489)
        Me.GCConsultar.TabIndex = 0
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colID_EMPLEADO, Me.colNOMBRE_EMPLEADO, Me.colNOMBRE_CARGO, Me.colESTADO})
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
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colID_EMPLEADO
        '
        Me.colID_EMPLEADO.FieldName = "ID_EMPLEADO"
        Me.colID_EMPLEADO.Name = "colID_EMPLEADO"
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Caption = "EMPLEADO"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Visible = True
        Me.colNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.colNOMBRE_EMPLEADO.Width = 166
        '
        'colNOMBRE_CARGO
        '
        Me.colNOMBRE_CARGO.Caption = "CARGO"
        Me.colNOMBRE_CARGO.FieldName = "NOMBRE_CARGO"
        Me.colNOMBRE_CARGO.Name = "colNOMBRE_CARGO"
        Me.colNOMBRE_CARGO.Visible = True
        Me.colNOMBRE_CARGO.VisibleIndex = 1
        Me.colNOMBRE_CARGO.Width = 168
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 2
        Me.colESTADO.Width = 55
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Enabled = False
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar Privilegios"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1067, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 520)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1067, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 489)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1067, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 489)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 67)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpArchivo
        Me.XtraTabControl1.Size = New System.Drawing.Size(604, 420)
        Me.XtraTabControl1.TabIndex = 36
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpArchivo, Me.xtpAdministracion, Me.xtpConfiguracion, Me.xtpAyuda})
        '
        'xtpArchivo
        '
        Me.xtpArchivo.Controls.Add(Me.AccordionControl1)
        Me.xtpArchivo.ImageOptions.Image = CType(resources.GetObject("xtpArchivo.ImageOptions.Image"), System.Drawing.Image)
        Me.xtpArchivo.Name = "xtpArchivo"
        Me.xtpArchivo.Size = New System.Drawing.Size(496, 414)
        Me.xtpArchivo.Text = "Archivo"
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer1)
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer2)
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer3)
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer4)
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.AccordionControlElement2, Me.AccordionControlElement3, Me.AccordionControlElement4})
        Me.AccordionControl1.Location = New System.Drawing.Point(3, 3)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.Size = New System.Drawing.Size(490, 408)
        Me.AccordionControl1.TabIndex = 0
        Me.AccordionControl1.Text = "AccordionControl1"
        '
        'AccordionContentContainer1
        '
        Me.AccordionContentContainer1.Controls.Add(Me.chkAgenda)
        Me.AccordionContentContainer1.Controls.Add(Me.chkAdjuntos)
        Me.AccordionContentContainer1.Controls.Add(Me.chkConsultar)
        Me.AccordionContentContainer1.Controls.Add(Me.chkAnular)
        Me.AccordionContentContainer1.Controls.Add(Me.chkEditar)
        Me.AccordionContentContainer1.Controls.Add(Me.chkNuevo)
        Me.AccordionContentContainer1.Name = "AccordionContentContainer1"
        Me.AccordionContentContainer1.Size = New System.Drawing.Size(473, 155)
        Me.AccordionContentContainer1.TabIndex = 1
        '
        'chkAgenda
        '
        Me.chkAgenda.Location = New System.Drawing.Point(16, 128)
        Me.chkAgenda.MenuManager = Me.BarManager1
        Me.chkAgenda.Name = "chkAgenda"
        Me.chkAgenda.Properties.Caption = "Agenda"
        Me.chkAgenda.Size = New System.Drawing.Size(244, 19)
        Me.chkAgenda.TabIndex = 5
        '
        'chkAdjuntos
        '
        Me.chkAdjuntos.Location = New System.Drawing.Point(16, 103)
        Me.chkAdjuntos.MenuManager = Me.BarManager1
        Me.chkAdjuntos.Name = "chkAdjuntos"
        Me.chkAdjuntos.Properties.Caption = "Adjuntos"
        Me.chkAdjuntos.Size = New System.Drawing.Size(244, 19)
        Me.chkAdjuntos.TabIndex = 4
        '
        'chkConsultar
        '
        Me.chkConsultar.Location = New System.Drawing.Point(16, 78)
        Me.chkConsultar.MenuManager = Me.BarManager1
        Me.chkConsultar.Name = "chkConsultar"
        Me.chkConsultar.Properties.Caption = "Consultar"
        Me.chkConsultar.Size = New System.Drawing.Size(244, 19)
        Me.chkConsultar.TabIndex = 3
        '
        'chkAnular
        '
        Me.chkAnular.Location = New System.Drawing.Point(16, 53)
        Me.chkAnular.MenuManager = Me.BarManager1
        Me.chkAnular.Name = "chkAnular"
        Me.chkAnular.Properties.Caption = "Anular"
        Me.chkAnular.Size = New System.Drawing.Size(244, 19)
        Me.chkAnular.TabIndex = 2
        '
        'chkEditar
        '
        Me.chkEditar.Location = New System.Drawing.Point(16, 28)
        Me.chkEditar.MenuManager = Me.BarManager1
        Me.chkEditar.Name = "chkEditar"
        Me.chkEditar.Properties.Caption = "Editar"
        Me.chkEditar.Size = New System.Drawing.Size(244, 19)
        Me.chkEditar.TabIndex = 1
        '
        'chkNuevo
        '
        Me.chkNuevo.Location = New System.Drawing.Point(16, 3)
        Me.chkNuevo.MenuManager = Me.BarManager1
        Me.chkNuevo.Name = "chkNuevo"
        Me.chkNuevo.Properties.Caption = "Nuevo"
        Me.chkNuevo.Size = New System.Drawing.Size(244, 19)
        Me.chkNuevo.TabIndex = 0
        '
        'AccordionContentContainer2
        '
        Me.AccordionContentContainer2.Controls.Add(Me.chkEndoscopia)
        Me.AccordionContentContainer2.Controls.Add(Me.chkImagenes)
        Me.AccordionContentContainer2.Controls.Add(Me.chkPatologia)
        Me.AccordionContentContainer2.Controls.Add(Me.chkCitologia)
        Me.AccordionContentContainer2.Controls.Add(Me.chkProgramacionProcedimientos)
        Me.AccordionContentContainer2.Controls.Add(Me.chkEvolucionPaciente)
        Me.AccordionContentContainer2.Controls.Add(Me.chkHistoriaGrupal)
        Me.AccordionContentContainer2.Controls.Add(Me.chkHistoriasAnteriores)
        Me.AccordionContentContainer2.Controls.Add(Me.chkHistoriaClinica)
        Me.AccordionContentContainer2.Name = "AccordionContentContainer2"
        Me.AccordionContentContainer2.Size = New System.Drawing.Size(473, 235)
        Me.AccordionContentContainer2.TabIndex = 2
        '
        'chkEndoscopia
        '
        Me.chkEndoscopia.Location = New System.Drawing.Point(17, 176)
        Me.chkEndoscopia.MenuManager = Me.BarManager1
        Me.chkEndoscopia.Name = "chkEndoscopia"
        Me.chkEndoscopia.Properties.Caption = "Endoscopia"
        Me.chkEndoscopia.Size = New System.Drawing.Size(244, 19)
        Me.chkEndoscopia.TabIndex = 21
        '
        'chkImagenes
        '
        Me.chkImagenes.Location = New System.Drawing.Point(17, 201)
        Me.chkImagenes.MenuManager = Me.BarManager1
        Me.chkImagenes.Name = "chkImagenes"
        Me.chkImagenes.Properties.Caption = "Imagenes"
        Me.chkImagenes.Size = New System.Drawing.Size(244, 19)
        Me.chkImagenes.TabIndex = 20
        '
        'chkPatologia
        '
        Me.chkPatologia.Location = New System.Drawing.Point(17, 153)
        Me.chkPatologia.MenuManager = Me.BarManager1
        Me.chkPatologia.Name = "chkPatologia"
        Me.chkPatologia.Properties.Caption = "Patologia"
        Me.chkPatologia.Size = New System.Drawing.Size(244, 19)
        Me.chkPatologia.TabIndex = 19
        '
        'chkCitologia
        '
        Me.chkCitologia.Location = New System.Drawing.Point(17, 128)
        Me.chkCitologia.MenuManager = Me.BarManager1
        Me.chkCitologia.Name = "chkCitologia"
        Me.chkCitologia.Properties.Caption = "Citologia"
        Me.chkCitologia.Size = New System.Drawing.Size(244, 19)
        Me.chkCitologia.TabIndex = 18
        '
        'chkProgramacionProcedimientos
        '
        Me.chkProgramacionProcedimientos.Location = New System.Drawing.Point(17, 103)
        Me.chkProgramacionProcedimientos.MenuManager = Me.BarManager1
        Me.chkProgramacionProcedimientos.Name = "chkProgramacionProcedimientos"
        Me.chkProgramacionProcedimientos.Properties.Caption = "Programacion de Procedimientos"
        Me.chkProgramacionProcedimientos.Size = New System.Drawing.Size(244, 19)
        Me.chkProgramacionProcedimientos.TabIndex = 17
        '
        'chkEvolucionPaciente
        '
        Me.chkEvolucionPaciente.Location = New System.Drawing.Point(17, 78)
        Me.chkEvolucionPaciente.MenuManager = Me.BarManager1
        Me.chkEvolucionPaciente.Name = "chkEvolucionPaciente"
        Me.chkEvolucionPaciente.Properties.Caption = "Evolucion Paciente"
        Me.chkEvolucionPaciente.Size = New System.Drawing.Size(244, 19)
        Me.chkEvolucionPaciente.TabIndex = 16
        '
        'chkHistoriaGrupal
        '
        Me.chkHistoriaGrupal.Location = New System.Drawing.Point(17, 53)
        Me.chkHistoriaGrupal.MenuManager = Me.BarManager1
        Me.chkHistoriaGrupal.Name = "chkHistoriaGrupal"
        Me.chkHistoriaGrupal.Properties.Caption = "Historia Grupal"
        Me.chkHistoriaGrupal.Size = New System.Drawing.Size(244, 19)
        Me.chkHistoriaGrupal.TabIndex = 15
        '
        'chkHistoriasAnteriores
        '
        Me.chkHistoriasAnteriores.Location = New System.Drawing.Point(17, 28)
        Me.chkHistoriasAnteriores.MenuManager = Me.BarManager1
        Me.chkHistoriasAnteriores.Name = "chkHistoriasAnteriores"
        Me.chkHistoriasAnteriores.Properties.Caption = "Historias Anteriores"
        Me.chkHistoriasAnteriores.Size = New System.Drawing.Size(244, 19)
        Me.chkHistoriasAnteriores.TabIndex = 14
        '
        'chkHistoriaClinica
        '
        Me.chkHistoriaClinica.Location = New System.Drawing.Point(17, 3)
        Me.chkHistoriaClinica.MenuManager = Me.BarManager1
        Me.chkHistoriaClinica.Name = "chkHistoriaClinica"
        Me.chkHistoriaClinica.Properties.Caption = "Historia Clinica"
        Me.chkHistoriaClinica.Size = New System.Drawing.Size(244, 19)
        Me.chkHistoriaClinica.TabIndex = 13
        '
        'AccordionContentContainer3
        '
        Me.AccordionContentContainer3.Controls.Add(Me.chkNomina)
        Me.AccordionContentContainer3.Controls.Add(Me.chkInventario)
        Me.AccordionContentContainer3.Controls.Add(Me.chkRips)
        Me.AccordionContentContainer3.Controls.Add(Me.chkGenerarFactura)
        Me.AccordionContentContainer3.Controls.Add(Me.chkListadoOrdenes)
        Me.AccordionContentContainer3.Name = "AccordionContentContainer3"
        Me.AccordionContentContainer3.Size = New System.Drawing.Size(473, 130)
        Me.AccordionContentContainer3.TabIndex = 3
        '
        'chkNomina
        '
        Me.chkNomina.Location = New System.Drawing.Point(14, 103)
        Me.chkNomina.MenuManager = Me.BarManager1
        Me.chkNomina.Name = "chkNomina"
        Me.chkNomina.Properties.Caption = "Nomina"
        Me.chkNomina.Size = New System.Drawing.Size(244, 19)
        Me.chkNomina.TabIndex = 5
        '
        'chkInventario
        '
        Me.chkInventario.Location = New System.Drawing.Point(14, 78)
        Me.chkInventario.MenuManager = Me.BarManager1
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.Properties.Caption = "Inventario"
        Me.chkInventario.Size = New System.Drawing.Size(244, 19)
        Me.chkInventario.TabIndex = 4
        '
        'chkRips
        '
        Me.chkRips.Location = New System.Drawing.Point(14, 53)
        Me.chkRips.MenuManager = Me.BarManager1
        Me.chkRips.Name = "chkRips"
        Me.chkRips.Properties.Caption = "Rips"
        Me.chkRips.Size = New System.Drawing.Size(244, 19)
        Me.chkRips.TabIndex = 3
        '
        'chkGenerarFactura
        '
        Me.chkGenerarFactura.Location = New System.Drawing.Point(14, 28)
        Me.chkGenerarFactura.MenuManager = Me.BarManager1
        Me.chkGenerarFactura.Name = "chkGenerarFactura"
        Me.chkGenerarFactura.Properties.Caption = "Generar Factura"
        Me.chkGenerarFactura.Size = New System.Drawing.Size(244, 19)
        Me.chkGenerarFactura.TabIndex = 2
        '
        'chkListadoOrdenes
        '
        Me.chkListadoOrdenes.Location = New System.Drawing.Point(14, 3)
        Me.chkListadoOrdenes.MenuManager = Me.BarManager1
        Me.chkListadoOrdenes.Name = "chkListadoOrdenes"
        Me.chkListadoOrdenes.Properties.Caption = "Listado de Ordenes"
        Me.chkListadoOrdenes.Size = New System.Drawing.Size(244, 19)
        Me.chkListadoOrdenes.TabIndex = 1
        '
        'AccordionContentContainer4
        '
        Me.AccordionContentContainer4.Controls.Add(Me.chkIndicadoresGestion)
        Me.AccordionContentContainer4.Controls.Add(Me.chkImprimir)
        Me.AccordionContentContainer4.Controls.Add(Me.chkVistaPrevia)
        Me.AccordionContentContainer4.Name = "AccordionContentContainer4"
        Me.AccordionContentContainer4.Size = New System.Drawing.Size(473, 76)
        Me.AccordionContentContainer4.TabIndex = 4
        '
        'chkIndicadoresGestion
        '
        Me.chkIndicadoresGestion.Location = New System.Drawing.Point(12, 53)
        Me.chkIndicadoresGestion.MenuManager = Me.BarManager1
        Me.chkIndicadoresGestion.Name = "chkIndicadoresGestion"
        Me.chkIndicadoresGestion.Properties.Caption = "Indicadores de Gestion"
        Me.chkIndicadoresGestion.Size = New System.Drawing.Size(244, 19)
        Me.chkIndicadoresGestion.TabIndex = 3
        '
        'chkImprimir
        '
        Me.chkImprimir.Location = New System.Drawing.Point(12, 28)
        Me.chkImprimir.MenuManager = Me.BarManager1
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Properties.Caption = "Imprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(244, 19)
        Me.chkImprimir.TabIndex = 2
        '
        'chkVistaPrevia
        '
        Me.chkVistaPrevia.Location = New System.Drawing.Point(12, 3)
        Me.chkVistaPrevia.MenuManager = Me.BarManager1
        Me.chkVistaPrevia.Name = "chkVistaPrevia"
        Me.chkVistaPrevia.Properties.Caption = "Vista Previa"
        Me.chkVistaPrevia.Size = New System.Drawing.Size(244, 19)
        Me.chkVistaPrevia.TabIndex = 1
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.ContentContainer = Me.AccordionContentContainer1
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement1.Text = "Ordenes de Atencion"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.ContentContainer = Me.AccordionContentContainer2
        Me.AccordionControlElement2.Expanded = True
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Estudios"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.ContentContainer = Me.AccordionContentContainer3
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "Contable"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.ContentContainer = Me.AccordionContentContainer4
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Reportes"
        '
        'xtpAdministracion
        '
        Me.xtpAdministracion.Controls.Add(Me.AccordionControl2)
        Me.xtpAdministracion.ImageOptions.Image = CType(resources.GetObject("xtpAdministracion.ImageOptions.Image"), System.Drawing.Image)
        Me.xtpAdministracion.Name = "xtpAdministracion"
        Me.xtpAdministracion.Size = New System.Drawing.Size(496, 414)
        Me.xtpAdministracion.Text = "Administracion"
        '
        'AccordionControl2
        '
        Me.AccordionControl2.Controls.Add(Me.AccordionContentContainer5)
        Me.AccordionControl2.Controls.Add(Me.AccordionContentContainer6)
        Me.AccordionControl2.Controls.Add(Me.AccordionContentContainer7)
        Me.AccordionControl2.Controls.Add(Me.AccordionContentContainer8)
        Me.AccordionControl2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement5, Me.AccordionControlElement6, Me.AccordionControlElement7, Me.AccordionControlElement8})
        Me.AccordionControl2.Location = New System.Drawing.Point(3, 3)
        Me.AccordionControl2.Name = "AccordionControl2"
        Me.AccordionControl2.Size = New System.Drawing.Size(490, 408)
        Me.AccordionControl2.TabIndex = 1
        Me.AccordionControl2.Text = "AccordionControl2"
        '
        'AccordionContentContainer5
        '
        Me.AccordionContentContainer5.Controls.Add(Me.chkUsuarios)
        Me.AccordionContentContainer5.Name = "AccordionContentContainer5"
        Me.AccordionContentContainer5.Size = New System.Drawing.Size(473, 31)
        Me.AccordionContentContainer5.TabIndex = 1
        '
        'chkUsuarios
        '
        Me.chkUsuarios.Location = New System.Drawing.Point(14, 3)
        Me.chkUsuarios.MenuManager = Me.BarManager1
        Me.chkUsuarios.Name = "chkUsuarios"
        Me.chkUsuarios.Properties.Caption = "Usuarios"
        Me.chkUsuarios.Size = New System.Drawing.Size(244, 19)
        Me.chkUsuarios.TabIndex = 1
        '
        'AccordionContentContainer6
        '
        Me.AccordionContentContainer6.Controls.Add(Me.chkSubEntidades)
        Me.AccordionContentContainer6.Controls.Add(Me.chkDetalleTarifas)
        Me.AccordionContentContainer6.Controls.Add(Me.chkTarifas)
        Me.AccordionContentContainer6.Controls.Add(Me.chkContratos)
        Me.AccordionContentContainer6.Controls.Add(Me.chkEntidades)
        Me.AccordionContentContainer6.Name = "AccordionContentContainer6"
        Me.AccordionContentContainer6.Size = New System.Drawing.Size(473, 130)
        Me.AccordionContentContainer6.TabIndex = 2
        '
        'chkSubEntidades
        '
        Me.chkSubEntidades.Location = New System.Drawing.Point(14, 27)
        Me.chkSubEntidades.MenuManager = Me.BarManager1
        Me.chkSubEntidades.Name = "chkSubEntidades"
        Me.chkSubEntidades.Properties.Caption = "Sub Entidades"
        Me.chkSubEntidades.Size = New System.Drawing.Size(244, 19)
        Me.chkSubEntidades.TabIndex = 5
        '
        'chkDetalleTarifas
        '
        Me.chkDetalleTarifas.Location = New System.Drawing.Point(14, 99)
        Me.chkDetalleTarifas.MenuManager = Me.BarManager1
        Me.chkDetalleTarifas.Name = "chkDetalleTarifas"
        Me.chkDetalleTarifas.Properties.Caption = "Detalle Tarifas"
        Me.chkDetalleTarifas.Size = New System.Drawing.Size(244, 19)
        Me.chkDetalleTarifas.TabIndex = 4
        '
        'chkTarifas
        '
        Me.chkTarifas.Location = New System.Drawing.Point(14, 75)
        Me.chkTarifas.MenuManager = Me.BarManager1
        Me.chkTarifas.Name = "chkTarifas"
        Me.chkTarifas.Properties.Caption = "Tarifas"
        Me.chkTarifas.Size = New System.Drawing.Size(244, 19)
        Me.chkTarifas.TabIndex = 3
        '
        'chkContratos
        '
        Me.chkContratos.Location = New System.Drawing.Point(14, 51)
        Me.chkContratos.MenuManager = Me.BarManager1
        Me.chkContratos.Name = "chkContratos"
        Me.chkContratos.Properties.Caption = "Contratos"
        Me.chkContratos.Size = New System.Drawing.Size(244, 19)
        Me.chkContratos.TabIndex = 2
        '
        'chkEntidades
        '
        Me.chkEntidades.Location = New System.Drawing.Point(14, 3)
        Me.chkEntidades.MenuManager = Me.BarManager1
        Me.chkEntidades.Name = "chkEntidades"
        Me.chkEntidades.Properties.Caption = "Entidades"
        Me.chkEntidades.Size = New System.Drawing.Size(244, 19)
        Me.chkEntidades.TabIndex = 1
        '
        'AccordionContentContainer7
        '
        Me.AccordionContentContainer7.Controls.Add(Me.chkEmpleados)
        Me.AccordionContentContainer7.Controls.Add(Me.chkEspecialidades)
        Me.AccordionContentContainer7.Controls.Add(Me.chkCargos)
        Me.AccordionContentContainer7.Name = "AccordionContentContainer7"
        Me.AccordionContentContainer7.Size = New System.Drawing.Size(473, 76)
        Me.AccordionContentContainer7.TabIndex = 3
        '
        'chkEmpleados
        '
        Me.chkEmpleados.Location = New System.Drawing.Point(14, 53)
        Me.chkEmpleados.MenuManager = Me.BarManager1
        Me.chkEmpleados.Name = "chkEmpleados"
        Me.chkEmpleados.Properties.Caption = "Empleados"
        Me.chkEmpleados.Size = New System.Drawing.Size(244, 19)
        Me.chkEmpleados.TabIndex = 3
        '
        'chkEspecialidades
        '
        Me.chkEspecialidades.Location = New System.Drawing.Point(14, 28)
        Me.chkEspecialidades.MenuManager = Me.BarManager1
        Me.chkEspecialidades.Name = "chkEspecialidades"
        Me.chkEspecialidades.Properties.Caption = "Especialidades"
        Me.chkEspecialidades.Size = New System.Drawing.Size(244, 19)
        Me.chkEspecialidades.TabIndex = 2
        '
        'chkCargos
        '
        Me.chkCargos.Location = New System.Drawing.Point(14, 3)
        Me.chkCargos.MenuManager = Me.BarManager1
        Me.chkCargos.Name = "chkCargos"
        Me.chkCargos.Properties.Caption = "Cargos"
        Me.chkCargos.Size = New System.Drawing.Size(244, 19)
        Me.chkCargos.TabIndex = 1
        '
        'AccordionContentContainer8
        '
        Me.AccordionContentContainer8.Controls.Add(Me.chkEquiposApoyo)
        Me.AccordionContentContainer8.Controls.Add(Me.chkEstudiosPredeterminados)
        Me.AccordionContentContainer8.Controls.Add(Me.chkTipoPatologia)
        Me.AccordionContentContainer8.Controls.Add(Me.chkCIE10)
        Me.AccordionContentContainer8.Controls.Add(Me.chkCUPS)
        Me.AccordionContentContainer8.Controls.Add(Me.chkMedicamentos)
        Me.AccordionContentContainer8.Controls.Add(Me.chkExamenes)
        Me.AccordionContentContainer8.Name = "AccordionContentContainer8"
        Me.AccordionContentContainer8.Size = New System.Drawing.Size(473, 182)
        Me.AccordionContentContainer8.TabIndex = 4
        '
        'chkEquiposApoyo
        '
        Me.chkEquiposApoyo.Location = New System.Drawing.Point(14, 153)
        Me.chkEquiposApoyo.MenuManager = Me.BarManager1
        Me.chkEquiposApoyo.Name = "chkEquiposApoyo"
        Me.chkEquiposApoyo.Properties.Caption = "Equipos de Apoyo"
        Me.chkEquiposApoyo.Size = New System.Drawing.Size(244, 19)
        Me.chkEquiposApoyo.TabIndex = 7
        '
        'chkEstudiosPredeterminados
        '
        Me.chkEstudiosPredeterminados.Location = New System.Drawing.Point(14, 128)
        Me.chkEstudiosPredeterminados.MenuManager = Me.BarManager1
        Me.chkEstudiosPredeterminados.Name = "chkEstudiosPredeterminados"
        Me.chkEstudiosPredeterminados.Properties.Caption = "Estudios Predeterminados"
        Me.chkEstudiosPredeterminados.Size = New System.Drawing.Size(244, 19)
        Me.chkEstudiosPredeterminados.TabIndex = 6
        '
        'chkTipoPatologia
        '
        Me.chkTipoPatologia.Location = New System.Drawing.Point(14, 103)
        Me.chkTipoPatologia.MenuManager = Me.BarManager1
        Me.chkTipoPatologia.Name = "chkTipoPatologia"
        Me.chkTipoPatologia.Properties.Caption = "Tipo de Patologia"
        Me.chkTipoPatologia.Size = New System.Drawing.Size(244, 19)
        Me.chkTipoPatologia.TabIndex = 5
        '
        'chkCIE10
        '
        Me.chkCIE10.Location = New System.Drawing.Point(14, 78)
        Me.chkCIE10.MenuManager = Me.BarManager1
        Me.chkCIE10.Name = "chkCIE10"
        Me.chkCIE10.Properties.Caption = "CIE10"
        Me.chkCIE10.Size = New System.Drawing.Size(244, 19)
        Me.chkCIE10.TabIndex = 4
        '
        'chkCUPS
        '
        Me.chkCUPS.Location = New System.Drawing.Point(14, 53)
        Me.chkCUPS.MenuManager = Me.BarManager1
        Me.chkCUPS.Name = "chkCUPS"
        Me.chkCUPS.Properties.Caption = "CUPS"
        Me.chkCUPS.Size = New System.Drawing.Size(244, 19)
        Me.chkCUPS.TabIndex = 3
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.Location = New System.Drawing.Point(14, 28)
        Me.chkMedicamentos.MenuManager = Me.BarManager1
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.chkMedicamentos.Properties.Caption = "Medicamentos"
        Me.chkMedicamentos.Size = New System.Drawing.Size(244, 19)
        Me.chkMedicamentos.TabIndex = 2
        '
        'chkExamenes
        '
        Me.chkExamenes.Location = New System.Drawing.Point(14, 3)
        Me.chkExamenes.MenuManager = Me.BarManager1
        Me.chkExamenes.Name = "chkExamenes"
        Me.chkExamenes.Properties.Caption = "Examenes"
        Me.chkExamenes.Size = New System.Drawing.Size(244, 19)
        Me.chkExamenes.TabIndex = 1
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.ContentContainer = Me.AccordionContentContainer5
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "Pacientes"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.ContentContainer = Me.AccordionContentContainer6
        Me.AccordionControlElement6.Expanded = True
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Contrataciones"
        '
        'AccordionControlElement7
        '
        Me.AccordionControlElement7.ContentContainer = Me.AccordionContentContainer7
        Me.AccordionControlElement7.Name = "AccordionControlElement7"
        Me.AccordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement7.Text = "Talento Humano"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.ContentContainer = Me.AccordionContentContainer8
        Me.AccordionControlElement8.Expanded = True
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "Complementos"
        '
        'xtpConfiguracion
        '
        Me.xtpConfiguracion.Controls.Add(Me.AccordionControl3)
        Me.xtpConfiguracion.ImageOptions.Image = CType(resources.GetObject("xtpConfiguracion.ImageOptions.Image"), System.Drawing.Image)
        Me.xtpConfiguracion.Name = "xtpConfiguracion"
        Me.xtpConfiguracion.Size = New System.Drawing.Size(496, 414)
        Me.xtpConfiguracion.Text = "Configuracion"
        '
        'AccordionControl3
        '
        Me.AccordionControl3.Controls.Add(Me.AccordionContentContainer9)
        Me.AccordionControl3.Controls.Add(Me.AccordionContentContainer10)
        Me.AccordionControl3.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement9, Me.AccordionControlElement10})
        Me.AccordionControl3.Location = New System.Drawing.Point(3, 3)
        Me.AccordionControl3.Name = "AccordionControl3"
        Me.AccordionControl3.Size = New System.Drawing.Size(490, 408)
        Me.AccordionControl3.TabIndex = 1
        Me.AccordionControl3.Text = "AccordionControl3"
        '
        'AccordionContentContainer9
        '
        Me.AccordionContentContainer9.Controls.Add(Me.chkFirma)
        Me.AccordionContentContainer9.Controls.Add(Me.chkLogo)
        Me.AccordionContentContainer9.Controls.Add(Me.chkEncabezadoPiePagina)
        Me.AccordionContentContainer9.Name = "AccordionContentContainer9"
        Me.AccordionContentContainer9.Size = New System.Drawing.Size(473, 76)
        Me.AccordionContentContainer9.TabIndex = 1
        '
        'chkFirma
        '
        Me.chkFirma.Location = New System.Drawing.Point(15, 53)
        Me.chkFirma.MenuManager = Me.BarManager1
        Me.chkFirma.Name = "chkFirma"
        Me.chkFirma.Properties.Caption = "Firma"
        Me.chkFirma.Size = New System.Drawing.Size(244, 19)
        Me.chkFirma.TabIndex = 3
        '
        'chkLogo
        '
        Me.chkLogo.Location = New System.Drawing.Point(15, 28)
        Me.chkLogo.MenuManager = Me.BarManager1
        Me.chkLogo.Name = "chkLogo"
        Me.chkLogo.Properties.Caption = "Logo"
        Me.chkLogo.Size = New System.Drawing.Size(244, 19)
        Me.chkLogo.TabIndex = 2
        '
        'chkEncabezadoPiePagina
        '
        Me.chkEncabezadoPiePagina.Location = New System.Drawing.Point(15, 3)
        Me.chkEncabezadoPiePagina.MenuManager = Me.BarManager1
        Me.chkEncabezadoPiePagina.Name = "chkEncabezadoPiePagina"
        Me.chkEncabezadoPiePagina.Properties.Caption = "Encabezado y Pie de Pagina"
        Me.chkEncabezadoPiePagina.Size = New System.Drawing.Size(244, 19)
        Me.chkEncabezadoPiePagina.TabIndex = 1
        '
        'AccordionContentContainer10
        '
        Me.AccordionContentContainer10.Controls.Add(Me.chkPrivilegios)
        Me.AccordionContentContainer10.Controls.Add(Me.chkSeguridad)
        Me.AccordionContentContainer10.Controls.Add(Me.chkUsers)
        Me.AccordionContentContainer10.Name = "AccordionContentContainer10"
        Me.AccordionContentContainer10.Size = New System.Drawing.Size(473, 81)
        Me.AccordionContentContainer10.TabIndex = 2
        '
        'chkPrivilegios
        '
        Me.chkPrivilegios.Location = New System.Drawing.Point(12, 53)
        Me.chkPrivilegios.MenuManager = Me.BarManager1
        Me.chkPrivilegios.Name = "chkPrivilegios"
        Me.chkPrivilegios.Properties.Caption = "Privilegios"
        Me.chkPrivilegios.Size = New System.Drawing.Size(244, 19)
        Me.chkPrivilegios.TabIndex = 3
        '
        'chkSeguridad
        '
        Me.chkSeguridad.Location = New System.Drawing.Point(12, 28)
        Me.chkSeguridad.MenuManager = Me.BarManager1
        Me.chkSeguridad.Name = "chkSeguridad"
        Me.chkSeguridad.Properties.Caption = "Seguridad"
        Me.chkSeguridad.Size = New System.Drawing.Size(244, 19)
        Me.chkSeguridad.TabIndex = 2
        '
        'chkUsers
        '
        Me.chkUsers.Location = New System.Drawing.Point(12, 3)
        Me.chkUsers.MenuManager = Me.BarManager1
        Me.chkUsers.Name = "chkUsers"
        Me.chkUsers.Properties.Caption = "Usuarios"
        Me.chkUsers.Size = New System.Drawing.Size(244, 19)
        Me.chkUsers.TabIndex = 1
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.ContentContainer = Me.AccordionContentContainer9
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement9.Text = "Reportes"
        '
        'AccordionControlElement10
        '
        Me.AccordionControlElement10.ContentContainer = Me.AccordionContentContainer10
        Me.AccordionControlElement10.Name = "AccordionControlElement10"
        Me.AccordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement10.Text = "Sistemas"
        '
        'xtpAyuda
        '
        Me.xtpAyuda.Controls.Add(Me.AccordionControl4)
        Me.xtpAyuda.ImageOptions.Image = CType(resources.GetObject("xtpAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.xtpAyuda.Name = "xtpAyuda"
        Me.xtpAyuda.Size = New System.Drawing.Size(496, 414)
        Me.xtpAyuda.Text = "Ayuda"
        '
        'AccordionControl4
        '
        Me.AccordionControl4.Controls.Add(Me.AccordionContentContainer11)
        Me.AccordionControl4.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement11})
        Me.AccordionControl4.Location = New System.Drawing.Point(3, 3)
        Me.AccordionControl4.Name = "AccordionControl4"
        Me.AccordionControl4.Size = New System.Drawing.Size(490, 408)
        Me.AccordionControl4.TabIndex = 1
        Me.AccordionControl4.Text = "AccordionControl4"
        '
        'AccordionContentContainer11
        '
        Me.AccordionContentContainer11.Controls.Add(Me.chkAcercaDe)
        Me.AccordionContentContainer11.Controls.Add(Me.chkTutoriales)
        Me.AccordionContentContainer11.Controls.Add(Me.chkSoporteTecnico)
        Me.AccordionContentContainer11.Controls.Add(Me.chkAyudaProducto)
        Me.AccordionContentContainer11.Name = "AccordionContentContainer11"
        Me.AccordionContentContainer11.Size = New System.Drawing.Size(473, 117)
        Me.AccordionContentContainer11.TabIndex = 1
        '
        'chkAcercaDe
        '
        Me.chkAcercaDe.Location = New System.Drawing.Point(17, 78)
        Me.chkAcercaDe.MenuManager = Me.BarManager1
        Me.chkAcercaDe.Name = "chkAcercaDe"
        Me.chkAcercaDe.Properties.Caption = "Acerca de..."
        Me.chkAcercaDe.Size = New System.Drawing.Size(244, 19)
        Me.chkAcercaDe.TabIndex = 4
        '
        'chkTutoriales
        '
        Me.chkTutoriales.Location = New System.Drawing.Point(17, 53)
        Me.chkTutoriales.MenuManager = Me.BarManager1
        Me.chkTutoriales.Name = "chkTutoriales"
        Me.chkTutoriales.Properties.Caption = "Tutoriales"
        Me.chkTutoriales.Size = New System.Drawing.Size(244, 19)
        Me.chkTutoriales.TabIndex = 3
        '
        'chkSoporteTecnico
        '
        Me.chkSoporteTecnico.Location = New System.Drawing.Point(17, 28)
        Me.chkSoporteTecnico.MenuManager = Me.BarManager1
        Me.chkSoporteTecnico.Name = "chkSoporteTecnico"
        Me.chkSoporteTecnico.Properties.Caption = "Soporte Tecnico"
        Me.chkSoporteTecnico.Size = New System.Drawing.Size(244, 19)
        Me.chkSoporteTecnico.TabIndex = 2
        '
        'chkAyudaProducto
        '
        Me.chkAyudaProducto.Location = New System.Drawing.Point(17, 3)
        Me.chkAyudaProducto.MenuManager = Me.BarManager1
        Me.chkAyudaProducto.Name = "chkAyudaProducto"
        Me.chkAyudaProducto.Properties.Caption = "Ayuda Producto"
        Me.chkAyudaProducto.Size = New System.Drawing.Size(244, 19)
        Me.chkAyudaProducto.TabIndex = 1
        '
        'AccordionControlElement11
        '
        Me.AccordionControlElement11.ContentContainer = Me.AccordionContentContainer11
        Me.AccordionControlElement11.Name = "AccordionControlElement11"
        Me.AccordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement11.Text = "Contenido SIM"
        '
        'txtDatosUsuario
        '
        Me.txtDatosUsuario.Location = New System.Drawing.Point(1, 6)
        Me.txtDatosUsuario.MenuManager = Me.BarManager1
        Me.txtDatosUsuario.Name = "txtDatosUsuario"
        Me.txtDatosUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDatosUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtDatosUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtDatosUsuario.Properties.ReadOnly = True
        Me.txtDatosUsuario.Size = New System.Drawing.Size(347, 56)
        Me.txtDatosUsuario.TabIndex = 35
        '
        'frmPrivilegios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 520)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrivilegios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de Privilegios"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpArchivo.ResumeLayout(False)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl1.ResumeLayout(False)
        Me.AccordionContentContainer1.ResumeLayout(False)
        CType(Me.chkAgenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAdjuntos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConsultar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEditar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNuevo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer2.ResumeLayout(False)
        CType(Me.chkEndoscopia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImagenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPatologia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCitologia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProgramacionProcedimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEvolucionPaciente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHistoriaGrupal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHistoriasAnteriores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHistoriaClinica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer3.ResumeLayout(False)
        CType(Me.chkNomina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGenerarFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkListadoOrdenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer4.ResumeLayout(False)
        CType(Me.chkIndicadoresGestion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImprimir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVistaPrevia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAdministracion.ResumeLayout(False)
        CType(Me.AccordionControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl2.ResumeLayout(False)
        Me.AccordionContentContainer5.ResumeLayout(False)
        CType(Me.chkUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer6.ResumeLayout(False)
        CType(Me.chkSubEntidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDetalleTarifas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTarifas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkContratos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEntidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer7.ResumeLayout(False)
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEspecialidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCargos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer8.ResumeLayout(False)
        CType(Me.chkEquiposApoyo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstudiosPredeterminados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTipoPatologia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCIE10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCUPS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedicamentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExamenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpConfiguracion.ResumeLayout(False)
        CType(Me.AccordionControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl3.ResumeLayout(False)
        Me.AccordionContentContainer9.ResumeLayout(False)
        CType(Me.chkFirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEncabezadoPiePagina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer10.ResumeLayout(False)
        CType(Me.chkPrivilegios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUsers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAyuda.ResumeLayout(False)
        CType(Me.AccordionControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl4.ResumeLayout(False)
        Me.AccordionContentContainer11.ResumeLayout(False)
        CType(Me.chkAcercaDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTutoriales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoporteTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAyudaProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents txtDatosUsuario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpArchivo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpAdministracion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpConfiguracion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpAyuda As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControl2 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement7 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControl3 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement10 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControl4 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement11 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkNuevo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents AccordionContentContainer3 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents AccordionContentContainer4 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkAgenda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAdjuntos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkConsultar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAnular As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEditar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImagenes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPatologia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCitologia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkProgramacionProcedimientos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEvolucionPaciente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkHistoriaGrupal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkHistoriasAnteriores As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkHistoriaClinica As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNomina As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInventario As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRips As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGenerarFactura As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkListadoOrdenes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIndicadoresGestion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImprimir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVistaPrevia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer5 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkUsuarios As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer6 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkDetalleTarifas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTarifas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkContratos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEntidades As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer7 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEspecialidades As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCargos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer8 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkEstudiosPredeterminados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTipoPatologia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCIE10 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCUPS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMedicamentos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkExamenes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer9 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents AccordionContentContainer10 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkFirma As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLogo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEncabezadoPiePagina As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPrivilegios As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSeguridad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUsers As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccordionContentContainer11 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents chkAcercaDe As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTutoriales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSoporteTecnico As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAyudaProducto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEndoscopia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEquiposApoyo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSubEntidades As DevExpress.XtraEditors.CheckEdit
End Class

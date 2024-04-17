<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImagenes))
        Me.lblConsecutivoOrden = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
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
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblIdDetalleOrden = New DevExpress.XtraEditors.LabelControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.DtPatologiasTableAdapter = New SIM_CITOPATO.dsVistasTableAdapters.dtPatologiasTableAdapter()
        Me.DsVistas = New SIM_CITOPATO.dsVistas()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatosUsuario = New DevExpress.XtraEditors.MemoEdit()
        Me.lblConsecutivo = New DevExpress.XtraEditors.LabelControl()
        Me.colPREFIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdDetalleOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GCPacientesAtender = New DevExpress.XtraGrid.GridControl()
        Me.GVPacientesAtender = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTIPOESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCapturas = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.txtEstudio = New DevExpress.XtraEditors.TextEdit()
        Me.peImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ccCamara = New DevExpress.XtraEditors.Camera.CameraControl()
        Me.colESPECIALISTA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.lblConsecutivoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCapturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCapturas.SuspendLayout()
        CType(Me.txtEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConsecutivoOrden
        '
        Me.lblConsecutivoOrden.Location = New System.Drawing.Point(453, 44)
        Me.lblConsecutivoOrden.MenuManager = Me.BarManager1
        Me.lblConsecutivoOrden.Name = "lblConsecutivoOrden"
        Me.lblConsecutivoOrden.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblConsecutivoOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivoOrden.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConsecutivoOrden.Properties.Appearance.Options.UseBackColor = True
        Me.lblConsecutivoOrden.Properties.Appearance.Options.UseFont = True
        Me.lblConsecutivoOrden.Properties.Appearance.Options.UseForeColor = True
        Me.lblConsecutivoOrden.Properties.ReadOnly = True
        Me.lblConsecutivoOrden.Size = New System.Drawing.Size(95, 22)
        Me.lblConsecutivoOrden.TabIndex = 94
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiAbrir, Me.bbiGuardar, Me.BarButtonItem4, Me.BarButtonItem5, Me.bbiConsultar, Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.bbiEnero, Me.bbiFebrero, Me.bbiMarzo, Me.bbiAbril, Me.bbiMayo, Me.bbiJunio, Me.bbiJulio, Me.bbiAgosto, Me.bbiSeptiembre, Me.bbiOctubre, Me.bbiNoviembre, Me.bbiDiciembre, Me.bbiActualizar})
        Me.BarManager1.MaxItemId = 33
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
        Me.bbiGuardar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
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
        Me.bbiActualizar.Caption = "Actualizar Pacientes"
        Me.bbiActualizar.Id = 32
        Me.bbiActualizar.ImageOptions.Image = CType(resources.GetObject("bbiActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActualizar.Name = "bbiActualizar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1203, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 550)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1203, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 519)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1203, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 519)
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
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(453, 25)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 95
        Me.LabelControl8.Text = "Orden No:"
        '
        'lblIdDetalleOrden
        '
        Me.lblIdDetalleOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdDetalleOrden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblIdDetalleOrden.Appearance.Options.UseFont = True
        Me.lblIdDetalleOrden.Appearance.Options.UseForeColor = True
        Me.lblIdDetalleOrden.Location = New System.Drawing.Point(834, 9)
        Me.lblIdDetalleOrden.Name = "lblIdDetalleOrden"
        Me.lblIdDetalleOrden.Size = New System.Drawing.Size(8, 16)
        Me.lblIdDetalleOrden.TabIndex = 93
        Me.lblIdDetalleOrden.Text = "1"
        Me.lblIdDetalleOrden.Visible = False
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'DtPatologiasTableAdapter
        '
        Me.DtPatologiasTableAdapter.ClearBeforeFill = True
        '
        'DsVistas
        '
        Me.DsVistas.DataSetName = "dsVistas"
        Me.DsVistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.Location = New System.Drawing.Point(10, 114)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(642, 20)
        Me.SeparatorControl1.TabIndex = 42
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 8)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Datos de Paciente:"
        '
        'txtDatosUsuario
        '
        Me.txtDatosUsuario.Location = New System.Drawing.Point(10, 26)
        Me.txtDatosUsuario.MenuManager = Me.BarManager1
        Me.txtDatosUsuario.Name = "txtDatosUsuario"
        Me.txtDatosUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDatosUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtDatosUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtDatosUsuario.Properties.ReadOnly = True
        Me.txtDatosUsuario.Size = New System.Drawing.Size(437, 87)
        Me.txtDatosUsuario.TabIndex = 2
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivo.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConsecutivo.Appearance.Options.UseFont = True
        Me.lblConsecutivo.Appearance.Options.UseForeColor = True
        Me.lblConsecutivo.Location = New System.Drawing.Point(803, 5)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(8, 16)
        Me.lblConsecutivo.TabIndex = 16
        Me.lblConsecutivo.Text = "1"
        Me.lblConsecutivo.Visible = False
        '
        'colPREFIJO
        '
        Me.colPREFIJO.Caption = "PREFIJO"
        Me.colPREFIJO.FieldName = "PREFIJO"
        Me.colPREFIJO.Name = "colPREFIJO"
        '
        'colIdDetalleOrden
        '
        Me.colIdDetalleOrden.Caption = "ID"
        Me.colIdDetalleOrden.FieldName = "ID"
        Me.colIdDetalleOrden.Name = "colIdDetalleOrden"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcCapturas)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtEstudio)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.peImagen)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ccCamara)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblConsecutivoOrden)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SeparatorControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDatosUsuario)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1203, 519)
        Me.SplitContainerControl1.SplitterPosition = 534
        Me.SplitContainerControl1.TabIndex = 7
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.GCPacientesAtender)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(511, 504)
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
        Me.GCPacientesAtender.Size = New System.Drawing.Size(507, 482)
        Me.GCPacientesAtender.TabIndex = 1
        Me.GCPacientesAtender.UseEmbeddedNavigator = True
        Me.GCPacientesAtender.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPacientesAtender})
        '
        'GVPacientesAtender
        '
        Me.GVPacientesAtender.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrden, Me.colFechaIngreso, Me.colIdentificacion, Me.colNombre, Me.colEstudio, Me.colIdDetalleOrden, Me.colPREFIJO, Me.colCUPS, Me.colESPECIALISTA, Me.colIDTIPOESTUDIO})
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
        Me.GVPacientesAtender.OptionsView.ShowFooter = True
        Me.GVPacientesAtender.OptionsView.ShowGroupPanel = False
        '
        'colOrden
        '
        Me.colOrden.Caption = "ORDEN"
        Me.colOrden.FieldName = "ORDEN"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 0
        Me.colOrden.Width = 44
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "FECHA"
        Me.colFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 1
        Me.colFechaIngreso.Width = 47
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "IDENTIFICACION"
        Me.colIdentificacion.FieldName = "IDENTIFICACION"
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colIdentificacion.Visible = True
        Me.colIdentificacion.VisibleIndex = 2
        Me.colIdentificacion.Width = 96
        '
        'colNombre
        '
        Me.colNombre.Caption = "NOMBRE"
        Me.colNombre.FieldName = "NOMBRE"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 3
        Me.colNombre.Width = 164
        '
        'colEstudio
        '
        Me.colEstudio.Caption = "ESTUDIO"
        Me.colEstudio.FieldName = "ESTUDIO"
        Me.colEstudio.Name = "colEstudio"
        Me.colEstudio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEstudio.Width = 140
        '
        'colCUPS
        '
        Me.colCUPS.Caption = "CUPS"
        Me.colCUPS.FieldName = "CUPS"
        Me.colCUPS.Name = "colCUPS"
        Me.colCUPS.Visible = True
        Me.colCUPS.VisibleIndex = 4
        Me.colCUPS.Width = 121
        '
        'colIDTIPOESTUDIO
        '
        Me.colIDTIPOESTUDIO.Caption = "IDTIPOESTUDIO"
        Me.colIDTIPOESTUDIO.FieldName = "IDTIPOESTUDIO"
        Me.colIDTIPOESTUDIO.Name = "colIDTIPOESTUDIO"
        '
        'gcCapturas
        '
        Me.gcCapturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCapturas.Controls.Add(Me.GalleryControlClient1)
        Me.gcCapturas.DesignGalleryGroupIndex = 0
        Me.gcCapturas.DesignGalleryItemIndex = 0
        '
        '
        '
        Me.gcCapturas.Gallery.ImageSize = New System.Drawing.Size(100, 100)
        Me.gcCapturas.Gallery.ShowItemText = True
        Me.gcCapturas.Location = New System.Drawing.Point(453, 136)
        Me.gcCapturas.Name = "gcCapturas"
        Me.gcCapturas.Size = New System.Drawing.Size(189, 371)
        Me.gcCapturas.TabIndex = 4
        Me.gcCapturas.Text = "gcCapturadas"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.gcCapturas
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(168, 367)
        '
        'txtEstudio
        '
        Me.txtEstudio.Location = New System.Drawing.Point(453, 91)
        Me.txtEstudio.MenuManager = Me.BarManager1
        Me.txtEstudio.Name = "txtEstudio"
        Me.txtEstudio.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtEstudio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstudio.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtEstudio.Properties.Appearance.Options.UseBackColor = True
        Me.txtEstudio.Properties.Appearance.Options.UseFont = True
        Me.txtEstudio.Properties.Appearance.Options.UseForeColor = True
        Me.txtEstudio.Properties.ReadOnly = True
        Me.txtEstudio.Size = New System.Drawing.Size(197, 22)
        Me.txtEstudio.TabIndex = 97
        '
        'peImagen
        '
        Me.peImagen.Location = New System.Drawing.Point(602, 27)
        Me.peImagen.MenuManager = Me.BarManager1
        Me.peImagen.Name = "peImagen"
        Me.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.peImagen.Size = New System.Drawing.Size(50, 46)
        Me.peImagen.TabIndex = 97
        Me.peImagen.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(453, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Text = "Estudio:"
        '
        'ccCamara
        '
        Me.ccCamara.Location = New System.Drawing.Point(10, 136)
        Me.ccCamara.Name = "ccCamara"
        Me.ccCamara.Size = New System.Drawing.Size(437, 374)
        Me.ccCamara.TabIndex = 96
        Me.ccCamara.Text = "CameraControl1"
        '
        'colESPECIALISTA
        '
        Me.colESPECIALISTA.Caption = "ESPECIALISTA"
        Me.colESPECIALISTA.FieldName = "ESPECIALISTA"
        Me.colESPECIALISTA.Name = "colESPECIALISTA"
        Me.colESPECIALISTA.Visible = True
        Me.colESPECIALISTA.VisibleIndex = 5
        Me.colESPECIALISTA.Width = 182
        '
        'frmImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 550)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.lblIdDetalleOrden)
        Me.Controls.Add(Me.lblConsecutivo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImagenes"
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Imagenes de Estudio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lblConsecutivoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPacientesAtender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCapturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCapturas.ResumeLayout(False)
        CType(Me.txtEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConsecutivoOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCPacientesAtender As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPacientesAtender As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdDetalleOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREFIJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents peImagen As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ccCamara As DevExpress.XtraEditors.Camera.CameraControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdDetalleOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatosUsuario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblConsecutivo As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents DtPatologiasTableAdapter As SIM_CITOPATO.dsVistasTableAdapters.dtPatologiasTableAdapter
    Friend WithEvents DsVistas As SIM_CITOPATO.dsVistas
    Friend WithEvents txtEstudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcCapturas As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents colCUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTIPOESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESPECIALISTA As DevExpress.XtraGrid.Columns.GridColumn
End Class

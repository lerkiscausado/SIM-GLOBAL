<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgenda
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgenda))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn7 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn6 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.DNFecha = New DevExpress.XtraScheduler.DateNavigator()
        Me.GCFecha = New DevExpress.XtraEditors.GroupControl()
        Me.GCAgenda = New DevExpress.XtraGrid.GridControl()
        Me.GVAgenda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaciente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAsignado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEspecialista = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditarAgenda = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConfigurarAgenda = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarRegistros = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cboMedico = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.cboUsuarios = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GVUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTipoEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboContrato = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.teHora = New DevExpress.XtraEditors.TimeEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GCDatosUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosUsuarios = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaSolicitudCita = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaSolicitadaPaciente = New DevExpress.XtraEditors.DateEdit()
        Me.cboProcedimiento = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.cboGVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTipoEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DNFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCFecha.SuspendLayout()
        CType(Me.GCAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDatosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSolicitudCita.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSolicitudCita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSolicitadaPaciente.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSolicitadaPaciente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'colFoto
        '
        Me.colFoto.Caption = "FOTO"
        Me.colFoto.FieldName = "FOTO"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Visible = True
        Me.colFoto.VisibleIndex = 9
        '
        'TileViewColumn3
        '
        Me.TileViewColumn3.Caption = "Nombres"
        Me.TileViewColumn3.FieldName = "NOMBRES"
        Me.TileViewColumn3.Name = "TileViewColumn3"
        Me.TileViewColumn3.Visible = True
        Me.TileViewColumn3.VisibleIndex = 2
        '
        'colApellidos
        '
        Me.colApellidos.Caption = "APELLIDOS"
        Me.colApellidos.FieldName = "APELLIDOS"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 8
        '
        'TileViewColumn2
        '
        Me.TileViewColumn2.Caption = "Identificacion"
        Me.TileViewColumn2.FieldName = "IDENTIFICACION"
        Me.TileViewColumn2.Name = "TileViewColumn2"
        Me.TileViewColumn2.Visible = True
        Me.TileViewColumn2.VisibleIndex = 1
        '
        'TileViewColumn4
        '
        Me.TileViewColumn4.Caption = "EDAD"
        Me.TileViewColumn4.FieldName = "EDAD"
        Me.TileViewColumn4.Name = "TileViewColumn4"
        Me.TileViewColumn4.Visible = True
        Me.TileViewColumn4.VisibleIndex = 5
        '
        'TileViewColumn5
        '
        Me.TileViewColumn5.Caption = "Sexo"
        Me.TileViewColumn5.FieldName = "SEXO"
        Me.TileViewColumn5.Name = "TileViewColumn5"
        Me.TileViewColumn5.Visible = True
        Me.TileViewColumn5.VisibleIndex = 3
        '
        'TileViewColumn7
        '
        Me.TileViewColumn7.Caption = "Telefono"
        Me.TileViewColumn7.FieldName = "TELEFONO"
        Me.TileViewColumn7.Name = "TileViewColumn7"
        Me.TileViewColumn7.Visible = True
        Me.TileViewColumn7.VisibleIndex = 4
        '
        'TileViewColumn6
        '
        Me.TileViewColumn6.Caption = "EMAIL"
        Me.TileViewColumn6.FieldName = "EMAIL"
        Me.TileViewColumn6.Name = "TileViewColumn6"
        Me.TileViewColumn6.Visible = True
        Me.TileViewColumn6.VisibleIndex = 7
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        '
        'DNFecha
        '
        Me.DNFecha.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.DNFecha.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.DNFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNFecha.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.[Default]
        Me.DNFecha.Enabled = False
        Me.DNFecha.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DNFecha.Location = New System.Drawing.Point(6, 32)
        Me.DNFecha.Name = "DNFecha"
        Me.DNFecha.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.[Single]
        Me.DNFecha.Size = New System.Drawing.Size(233, 473)
        Me.DNFecha.TabIndex = 0
        '
        'GCFecha
        '
        Me.GCFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCFecha.Controls.Add(Me.GCAgenda)
        Me.GCFecha.Location = New System.Drawing.Point(245, 229)
        Me.GCFecha.Name = "GCFecha"
        Me.GCFecha.Size = New System.Drawing.Size(905, 276)
        Me.GCFecha.TabIndex = 1
        Me.GCFecha.Text = "Agenda del Dia"
        '
        'GCAgenda
        '
        Me.GCAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCAgenda.Location = New System.Drawing.Point(2, 23)
        Me.GCAgenda.MainView = Me.GVAgenda
        Me.GCAgenda.Name = "GCAgenda"
        Me.GCAgenda.Size = New System.Drawing.Size(901, 251)
        Me.GCAgenda.TabIndex = 2
        Me.GCAgenda.UseEmbeddedNavigator = True
        Me.GCAgenda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAgenda})
        '
        'GVAgenda
        '
        Me.GVAgenda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFECHA, Me.colHora, Me.colIDENTIFICACION, Me.colPaciente, Me.colEdad, Me.colEstudio, Me.colEntidad, Me.colAsignado, Me.colEspecialista, Me.colESTADO, Me.colSexo, Me.colTelefono})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colESTADO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "CANCELADA"
        FormatConditionRuleValue1.Value1 = "CANCELADA"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVAgenda.FormatRules.Add(GridFormatRule1)
        Me.GVAgenda.GridControl = Me.GCAgenda
        Me.GVAgenda.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVAgenda.Name = "GVAgenda"
        Me.GVAgenda.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVAgenda.OptionsBehavior.ReadOnly = True
        Me.GVAgenda.OptionsPrint.AutoWidth = False
        Me.GVAgenda.OptionsView.ColumnAutoWidth = False
        Me.GVAgenda.OptionsView.EnableAppearanceOddRow = True
        Me.GVAgenda.OptionsView.ShowGroupPanel = False
        Me.GVAgenda.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 0
        '
        'colHora
        '
        Me.colHora.Caption = "HORA"
        Me.colHora.FieldName = "HORA"
        Me.colHora.Name = "colHora"
        Me.colHora.Visible = True
        Me.colHora.VisibleIndex = 1
        Me.colHora.Width = 84
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 2
        Me.colIDENTIFICACION.Width = 94
        '
        'colPaciente
        '
        Me.colPaciente.Caption = "PACIENTE"
        Me.colPaciente.FieldName = "PACIENTE"
        Me.colPaciente.Name = "colPaciente"
        Me.colPaciente.Visible = True
        Me.colPaciente.VisibleIndex = 3
        Me.colPaciente.Width = 236
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 4
        Me.colEdad.Width = 38
        '
        'colEstudio
        '
        Me.colEstudio.Caption = "CITA"
        Me.colEstudio.FieldName = "ESTUDIO"
        Me.colEstudio.Name = "colEstudio"
        Me.colEstudio.Visible = True
        Me.colEstudio.VisibleIndex = 7
        Me.colEstudio.Width = 198
        '
        'colEntidad
        '
        Me.colEntidad.Caption = "ENTIDAD"
        Me.colEntidad.FieldName = "ENTIDAD"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.Visible = True
        Me.colEntidad.VisibleIndex = 8
        Me.colEntidad.Width = 201
        '
        'colAsignado
        '
        Me.colAsignado.Caption = "ASIGNADO POR"
        Me.colAsignado.FieldName = "ASIGNADO"
        Me.colAsignado.Name = "colAsignado"
        Me.colAsignado.Visible = True
        Me.colAsignado.VisibleIndex = 9
        Me.colAsignado.Width = 171
        '
        'colEspecialista
        '
        Me.colEspecialista.Caption = "ESPECIALISTA"
        Me.colEspecialista.FieldName = "ESPECIALISTA"
        Me.colEspecialista.Name = "colEspecialista"
        '
        'colSexo
        '
        Me.colSexo.Caption = "SEXO"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 5
        Me.colSexo.Width = 39
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "TELEFONO"
        Me.colTelefono.FieldName = "TELEFONO"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 6
        Me.colTelefono.Width = 108
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiCancelar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiUsuarios, Me.bbiEditarAgenda, Me.bbiConfigurarAgenda, Me.bbiEliminarRegistros})
        Me.BarManager1.MaxItemId = 11
        '
        'Bar3
        '
        Me.Bar3.BarName = "Herramientas"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditarAgenda), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUsuarios, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConfigurarAgenda, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminarRegistros)})
        Me.Bar3.Text = "Herramientas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiEditarAgenda
        '
        Me.bbiEditarAgenda.Caption = "Editar Agenda"
        Me.bbiEditarAgenda.Id = 8
        Me.bbiEditarAgenda.ImageOptions.Image = CType(resources.GetObject("bbiEditarAgenda.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditarAgenda.Name = "bbiEditarAgenda"
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
        Me.bbiCancelar.Caption = "Cancelar Cita"
        Me.bbiCancelar.Id = 3
        Me.bbiCancelar.ImageOptions.Image = CType(resources.GetObject("bbiCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCancelar.Name = "bbiCancelar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 4
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imrpimir"
        Me.bbiImprimir.Id = 5
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'bbiUsuarios
        '
        Me.bbiUsuarios.Caption = "Registro de Usuarios"
        Me.bbiUsuarios.Id = 6
        Me.bbiUsuarios.ImageOptions.Image = CType(resources.GetObject("bbiUsuarios.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiUsuarios.Name = "bbiUsuarios"
        '
        'bbiConfigurarAgenda
        '
        Me.bbiConfigurarAgenda.Caption = "Configuracion"
        Me.bbiConfigurarAgenda.Id = 9
        Me.bbiConfigurarAgenda.ImageOptions.Image = CType(resources.GetObject("bbiConfigurarAgenda.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConfigurarAgenda.Name = "bbiConfigurarAgenda"
        '
        'bbiEliminarRegistros
        '
        Me.bbiEliminarRegistros.Caption = "Eliminar Registro"
        Me.bbiEliminarRegistros.Id = 10
        Me.bbiEliminarRegistros.ImageOptions.Image = CType(resources.GetObject("bbiEliminarRegistros.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminarRegistros.Name = "bbiEliminarRegistros"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(1162, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 520)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1162, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 496)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1162, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 496)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1162, 0)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Herramientas"
        '
        'cboMedico
        '
        Me.cboMedico.Location = New System.Drawing.Point(353, 31)
        Me.cboMedico.MenuManager = Me.BarManager1
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMedico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMedico.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESPECIALIDAD", "ESPECIALIDAD")})
        Me.cboMedico.Properties.NullText = ""
        Me.cboMedico.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboMedico.Properties.PopupWidth = 600
        Me.cboMedico.Size = New System.Drawing.Size(379, 20)
        Me.cboMedico.TabIndex = 1
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(288, 34)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl14.TabIndex = 71
        Me.LabelControl14.Text = "Especialista:"
        '
        'cboUsuarios
        '
        Me.cboUsuarios.EditValue = "SELECCIONAR"
        Me.cboUsuarios.Location = New System.Drawing.Point(353, 116)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUsuarios.Properties.PopupView = Me.GVUsuarios
        Me.cboUsuarios.Size = New System.Drawing.Size(379, 20)
        Me.cboUsuarios.TabIndex = 4
        '
        'GVUsuarios
        '
        Me.GVUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUID, Me.colUIdentificacion, Me.colUNombre, Me.colUSexo, Me.colUEdad, Me.colEMAIL})
        Me.GVUsuarios.DetailHeight = 200
        Me.GVUsuarios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVUsuarios.Name = "GVUsuarios"
        Me.GVUsuarios.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GVUsuarios.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVUsuarios.OptionsView.ColumnAutoWidth = False
        Me.GVUsuarios.OptionsView.ShowGroupPanel = False
        '
        'colUID
        '
        Me.colUID.Caption = "ID"
        Me.colUID.FieldName = "ID"
        Me.colUID.Name = "colUID"
        Me.colUID.Width = 45
        '
        'colUIdentificacion
        '
        Me.colUIdentificacion.Caption = "IDENTIFICACION"
        Me.colUIdentificacion.FieldName = "IDENTIFICACION"
        Me.colUIdentificacion.Name = "colUIdentificacion"
        Me.colUIdentificacion.Visible = True
        Me.colUIdentificacion.VisibleIndex = 0
        Me.colUIdentificacion.Width = 105
        '
        'colUNombre
        '
        Me.colUNombre.Caption = "USUARIO"
        Me.colUNombre.FieldName = "NOMBRE"
        Me.colUNombre.Name = "colUNombre"
        Me.colUNombre.Visible = True
        Me.colUNombre.VisibleIndex = 1
        Me.colUNombre.Width = 276
        '
        'colUSexo
        '
        Me.colUSexo.Caption = "SEXO"
        Me.colUSexo.FieldName = "SEXO"
        Me.colUSexo.Name = "colUSexo"
        Me.colUSexo.Visible = True
        Me.colUSexo.VisibleIndex = 2
        Me.colUSexo.Width = 42
        '
        'colUEdad
        '
        Me.colUEdad.Caption = "EDAD"
        Me.colUEdad.FieldName = "EDAD"
        Me.colUEdad.Name = "colUEdad"
        Me.colUEdad.Visible = True
        Me.colUEdad.VisibleIndex = 3
        Me.colUEdad.Width = 45
        '
        'colEMAIL
        '
        Me.colEMAIL.Caption = "EMAIL"
        Me.colEMAIL.FieldName = "EMAIL"
        Me.colEMAIL.Name = "colEMAIL"
        Me.colEMAIL.Visible = True
        Me.colEMAIL.VisibleIndex = 4
        '
        'cboTipoEstudio
        '
        Me.cboTipoEstudio.Location = New System.Drawing.Point(353, 168)
        Me.cboTipoEstudio.Name = "cboTipoEstudio"
        Me.cboTipoEstudio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTipoEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTUDIO", "ESTUDIO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PREFIJO", "PREFIJO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboTipoEstudio.Properties.NullText = ""
        Me.cboTipoEstudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTipoEstudio.Properties.PopupWidth = 600
        Me.cboTipoEstudio.Properties.ShowHeader = False
        Me.cboTipoEstudio.Size = New System.Drawing.Size(379, 20)
        Me.cboTipoEstudio.TabIndex = 6
        Me.cboTipoEstudio.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(272, 171)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl5.TabIndex = 85
        Me.LabelControl5.Text = "Tipo de Estudio:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(307, 119)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 86
        Me.LabelControl1.Text = "Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(294, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 88
        Me.LabelControl2.Text = "Fecha cita:"
        Me.LabelControl2.ToolTip = "FECHA DE LA ASIGNACION DE LA CITA"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(353, 87)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.ReadOnly = True
        Me.dtFecha.Size = New System.Drawing.Size(143, 20)
        Me.dtFecha.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(556, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 90
        Me.LabelControl3.Text = "Hora:"
        '
        'cboContrato
        '
        Me.cboContrato.Location = New System.Drawing.Point(353, 142)
        Me.cboContrato.Name = "cboContrato"
        Me.cboContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContrato.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTRATO", "CONTRATO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTIDAD", "ENTIDAD"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboContrato.Properties.NullText = ""
        Me.cboContrato.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboContrato.Properties.PopupWidth = 600
        Me.cboContrato.Size = New System.Drawing.Size(379, 20)
        Me.cboContrato.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(252, 145)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl8.TabIndex = 103
        Me.LabelControl8.Text = "Entidad o Contrato:"
        '
        'teHora
        '
        Me.teHora.EditValue = Nothing
        Me.teHora.Location = New System.Drawing.Point(589, 87)
        Me.teHora.Name = "teHora"
        Me.teHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.teHora.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.teHora.Properties.Mask.EditMask = "t"
        Me.teHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.teHora.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.teHora.Size = New System.Drawing.Size(143, 20)
        Me.teHora.TabIndex = 3
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(747, 27)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(19, 161)
        Me.SeparatorControl1.TabIndex = 109
        '
        'GCDatosUsuarios
        '
        Me.GCDatosUsuarios.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosUsuarios.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosUsuarios.Location = New System.Drawing.Point(783, 32)
        Me.GCDatosUsuarios.MainView = Me.TVDatosUsuarios
        Me.GCDatosUsuarios.Name = "GCDatosUsuarios"
        Me.GCDatosUsuarios.Size = New System.Drawing.Size(316, 139)
        Me.GCDatosUsuarios.TabIndex = 111
        Me.GCDatosUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TVDatosUsuarios})
        '
        'TVDatosUsuarios
        '
        Me.TVDatosUsuarios.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TVDatosUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn1, Me.TileViewColumn2, Me.TileViewColumn3, Me.colApellidos, Me.TileViewColumn4, Me.TileViewColumn5, Me.colDireccion, Me.TileViewColumn6, Me.TileViewColumn7, Me.colFoto})
        Me.TVDatosUsuarios.GridControl = Me.GCDatosUsuarios
        Me.TVDatosUsuarios.Name = "TVDatosUsuarios"
        Me.TVDatosUsuarios.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(28, 0, 0, 16)
        Me.TVDatosUsuarios.OptionsTiles.IndentBetweenItems = 13
        Me.TVDatosUsuarios.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TVDatosUsuarios.OptionsTiles.ItemSize = New System.Drawing.Size(300, 120)
        Me.TVDatosUsuarios.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        TableColumnDefinition1.Length.Value = 138.0R
        Me.TVDatosUsuarios.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.Column = Me.colFoto
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.SingleBorder
        TileViewItemElement1.ImageOptions.ImageBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.ImageOptions.ImageSize = New System.Drawing.Size(85, 150)
        TileViewItemElement1.Text = "colFoto"
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumn3
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.Text = "colNombre"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(120, 5)
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement3.Column = Me.colApellidos
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.Text = "colApellidos"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(120, 25)
        TileViewItemElement4.Column = Me.TileViewColumn2
        TileViewItemElement4.StretchHorizontal = True
        TileViewItemElement4.Text = "colIdentificacion"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(120, 42)
        TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement5.Text = "Edad:"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(120, 55)
        TileViewItemElement6.Column = Me.TileViewColumn4
        TileViewItemElement6.Text = "colEdad"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement6.TextLocation = New System.Drawing.Point(150, 55)
        TileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement7.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement7.Text = "Sexo:"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement7.TextLocation = New System.Drawing.Point(190, 55)
        TileViewItemElement8.Column = Me.TileViewColumn5
        TileViewItemElement8.Text = "colSexo"
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement8.TextLocation = New System.Drawing.Point(220, 55)
        TileViewItemElement9.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement9.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement9.Text = "Telefono:"
        TileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement9.TextLocation = New System.Drawing.Point(120, 68)
        TileViewItemElement10.Column = Me.TileViewColumn7
        TileViewItemElement10.StretchHorizontal = True
        TileViewItemElement10.Text = "colTelefono"
        TileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement10.TextLocation = New System.Drawing.Point(170, 68)
        TileViewItemElement11.Column = Me.TileViewColumn6
        TileViewItemElement11.StretchHorizontal = True
        TileViewItemElement11.Text = "colEmail"
        TileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement11.TextLocation = New System.Drawing.Point(120, 81)
        TileViewItemElement12.Column = Me.colDireccion
        TileViewItemElement12.StretchHorizontal = True
        TileViewItemElement12.Text = "colDireccion"
        TileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement12.TextLocation = New System.Drawing.Point(120, 94)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement1)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement2)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement3)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement4)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement5)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement6)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement7)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement8)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement9)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement10)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement11)
        Me.TVDatosUsuarios.TileTemplate.Add(TileViewItemElement12)
        '
        'TileViewColumn1
        '
        Me.TileViewColumn1.Caption = "ID"
        Me.TileViewColumn1.FieldName = "ID"
        Me.TileViewColumn1.Name = "TileViewColumn1"
        Me.TileViewColumn1.Visible = True
        Me.TileViewColumn1.VisibleIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(272, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 118
        Me.LabelControl4.Text = "Fecha Solicitud:"
        Me.LabelControl4.ToolTip = "FECHA DE SOLICITUD DE LA CITA"
        '
        'dtFechaSolicitudCita
        '
        Me.dtFechaSolicitudCita.EditValue = Nothing
        Me.dtFechaSolicitudCita.Location = New System.Drawing.Point(353, 57)
        Me.dtFechaSolicitudCita.Name = "dtFechaSolicitudCita"
        Me.dtFechaSolicitudCita.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSolicitudCita.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSolicitudCita.Size = New System.Drawing.Size(143, 20)
        Me.dtFechaSolicitudCita.TabIndex = 117
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(502, 64)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl6.TabIndex = 120
        Me.LabelControl6.Text = "Fecha Solicitada:"
        Me.LabelControl6.ToolTip = "FECHA PARA LA CUAL EL  USUARIO SOLICITO QUE LE FUERA ASIGNADA LA CITA"
        '
        'dtFechaSolicitadaPaciente
        '
        Me.dtFechaSolicitadaPaciente.EditValue = Nothing
        Me.dtFechaSolicitadaPaciente.Location = New System.Drawing.Point(589, 57)
        Me.dtFechaSolicitadaPaciente.Name = "dtFechaSolicitadaPaciente"
        Me.dtFechaSolicitadaPaciente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSolicitadaPaciente.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSolicitadaPaciente.Size = New System.Drawing.Size(143, 20)
        Me.dtFechaSolicitadaPaciente.TabIndex = 119
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.EditValue = "SELECCIONAR"
        Me.cboProcedimiento.Location = New System.Drawing.Point(353, 168)
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProcedimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcedimiento.Properties.NullText = ""
        Me.cboProcedimiento.Properties.PopupView = Me.cboGVProcedimientos
        Me.cboProcedimiento.Size = New System.Drawing.Size(379, 20)
        Me.cboProcedimiento.TabIndex = 126
        Me.cboProcedimiento.Visible = False
        '
        'cboGVProcedimientos
        '
        Me.cboGVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO, Me.GridColumn1, Me.colCups, Me.colNombreCBO, Me.colValor, Me.colIDTipoEstudio})
        Me.cboGVProcedimientos.DetailHeight = 200
        Me.cboGVProcedimientos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.cboGVProcedimientos.Name = "cboGVProcedimientos"
        Me.cboGVProcedimientos.OptionsBehavior.AutoPopulateColumns = False
        Me.cboGVProcedimientos.OptionsEditForm.PopupEditFormWidth = 1000
        Me.cboGVProcedimientos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.cboGVProcedimientos.OptionsView.ColumnAutoWidth = False
        Me.cboGVProcedimientos.OptionsView.EnableAppearanceOddRow = True
        Me.cboGVProcedimientos.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "CODIGO"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ESTUDIO"
        Me.GridColumn1.FieldName = "ESTUDIO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 229
        '
        'colCups
        '
        Me.colCups.Caption = "CUPS"
        Me.colCups.FieldName = "CUPS"
        Me.colCups.Name = "colCups"
        Me.colCups.Visible = True
        Me.colCups.VisibleIndex = 1
        Me.colCups.Width = 77
        '
        'colNombreCBO
        '
        Me.colNombreCBO.Caption = "NOMBRE"
        Me.colNombreCBO.FieldName = "NOMBRE"
        Me.colNombreCBO.Name = "colNombreCBO"
        Me.colNombreCBO.Visible = True
        Me.colNombreCBO.VisibleIndex = 2
        Me.colNombreCBO.Width = 349
        '
        'colValor
        '
        Me.colValor.Caption = "VALOR"
        Me.colValor.DisplayFormat.FormatString = "C0"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.Width = 89
        '
        'colIDTipoEstudio
        '
        Me.colIDTipoEstudio.Caption = "IDTIPOESTUDIO"
        Me.colIDTipoEstudio.FieldName = "TIPOESTUDIO"
        Me.colIDTipoEstudio.Name = "colIDTipoEstudio"
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 520)
        Me.Controls.Add(Me.cboProcedimiento)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.dtFechaSolicitadaPaciente)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.dtFechaSolicitudCita)
        Me.Controls.Add(Me.GCDatosUsuarios)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.cboContrato)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cboTipoEstudio)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cboUsuarios)
        Me.Controls.Add(Me.cboMedico)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.GCFecha)
        Me.Controls.Add(Me.DNFecha)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.teHora)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmAgenda.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DNFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCFecha.ResumeLayout(False)
        CType(Me.GCAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDatosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSolicitudCita.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSolicitudCita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSolicitadaPaciente.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSolicitadaPaciente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DNFecha As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents GCFecha As DevExpress.XtraEditors.GroupControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboMedico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUsuarios As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GVUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colUID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboContrato As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents GCAgenda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVAgenda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaciente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAsignado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecialista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teHora As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents bbiEditarAgenda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiConfigurarAgenda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarRegistros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GCDatosUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents TVDatosUsuarios As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn6 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn7 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaSolicitadaPaciente As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaSolicitudCita As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboProcedimiento As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents cboGVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTipoEstudio As DevExpress.XtraGrid.Columns.GridColumn
End Class

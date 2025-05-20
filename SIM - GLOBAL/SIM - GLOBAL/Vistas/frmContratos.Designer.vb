<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratos))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
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
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRips = New DevExpress.XtraEditors.CheckEdit()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.cboTipoContrato = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTarifa = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboEntidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCorreoElectronico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefeno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtContacto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.dtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroContrato = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.cboLicencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMERO_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIFA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(920, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 456)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(920, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 432)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(920, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 432)
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(828, 24)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Estado"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 14
        '
        'chkRips
        '
        Me.chkRips.Location = New System.Drawing.Point(828, 200)
        Me.chkRips.MenuManager = Me.BarManager1
        Me.chkRips.Name = "chkRips"
        Me.chkRips.Properties.Caption = "Rips"
        Me.chkRips.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkRips.Size = New System.Drawing.Size(75, 20)
        Me.chkRips.TabIndex = 12
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(576, 225)
        Me.txtValor.MenuManager = Me.BarManager1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(328, 20)
        Me.txtValor.TabIndex = 13
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.Location = New System.Drawing.Point(575, 199)
        Me.cboTipoContrato.MenuManager = Me.BarManager1
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Properties.AutoComplete = False
        Me.cboTipoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoContrato.Properties.Items.AddRange(New Object() {"EVENTO", "CAPITADO", "PAQUETE"})
        Me.cboTipoContrato.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoContrato.Size = New System.Drawing.Size(247, 20)
        Me.cboTipoContrato.TabIndex = 11
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(476, 202)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Tipo de Contrato"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(476, 228)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl6.TabIndex = 27
        Me.LabelControl6.Text = "Valor Convenio"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(476, 176)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl16.TabIndex = 22
        Me.LabelControl16.Text = "Tarifa"
        '
        'cboTarifa
        '
        Me.cboTarifa.Location = New System.Drawing.Point(575, 173)
        Me.cboTarifa.MenuManager = Me.BarManager1
        Me.cboTarifa.Name = "cboTarifa"
        Me.cboTarifa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTarifa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTarifa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TARIFA", "TARIFA")})
        Me.cboTarifa.Properties.NullText = ""
        Me.cboTarifa.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTarifa.Properties.PopupSizeable = False
        Me.cboTarifa.Size = New System.Drawing.Size(328, 20)
        Me.cboTarifa.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(476, 150)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Entidad"
        '
        'cboEntidad
        '
        Me.cboEntidad.Location = New System.Drawing.Point(575, 147)
        Me.cboEntidad.MenuManager = Me.BarManager1
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboEntidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEntidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "CODIGO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTIDAD", "ENTIDAD"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTADO", "ESTADO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEntidad.Properties.NullText = ""
        Me.cboEntidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboEntidad.Properties.PopupSizeable = False
        Me.cboEntidad.Size = New System.Drawing.Size(328, 20)
        Me.cboEntidad.TabIndex = 9
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.EnterMoveNextControl = True
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(576, 101)
        Me.txtCorreoElectronico.MenuManager = Me.BarManager1
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Properties.Mask.EditMask = "d"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(327, 20)
        Me.txtCorreoElectronico.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(476, 104)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "Correo Electronico"
        '
        'txtTelefeno
        '
        Me.txtTelefeno.EnterMoveNextControl = True
        Me.txtTelefeno.Location = New System.Drawing.Point(576, 75)
        Me.txtTelefeno.MenuManager = Me.BarManager1
        Me.txtTelefeno.Name = "txtTelefeno"
        Me.txtTelefeno.Size = New System.Drawing.Size(327, 20)
        Me.txtTelefeno.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(476, 78)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl11.TabIndex = 16
        Me.LabelControl11.Text = "Telefono"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.Location = New System.Drawing.Point(480, 122)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(1, 23)
        Me.SeparatorControl2.TabIndex = 74
        '
        'txtContacto
        '
        Me.txtContacto.EnterMoveNextControl = True
        Me.txtContacto.Location = New System.Drawing.Point(576, 49)
        Me.txtContacto.MenuManager = Me.BarManager1
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Properties.Mask.EditMask = "d"
        Me.txtContacto.Size = New System.Drawing.Size(327, 20)
        Me.txtContacto.TabIndex = 6
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(476, 52)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl10.TabIndex = 14
        Me.LabelControl10.Text = "Contacto"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(123, 153)
        Me.txtObservaciones.MenuManager = Me.BarManager1
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(328, 92)
        Me.txtObservaciones.TabIndex = 5
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.EditValue = Nothing
        Me.dtFechaFinal.Location = New System.Drawing.Point(326, 127)
        Me.dtFechaFinal.MenuManager = Me.BarManager1
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Size = New System.Drawing.Size(123, 20)
        Me.dtFechaFinal.TabIndex = 4
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(263, 130)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl18.TabIndex = 10
        Me.LabelControl18.Text = "Fecha Final:"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(123, 127)
        Me.dtFechaInicio.MenuManager = Me.BarManager1
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Size = New System.Drawing.Size(134, 20)
        Me.dtFechaInicio.TabIndex = 3
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(26, 130)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Fecha de Inicio"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(26, 154)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Observaciones"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.EnterMoveNextControl = True
        Me.txtNumeroContrato.Location = New System.Drawing.Point(123, 101)
        Me.txtNumeroContrato.MenuManager = Me.BarManager1
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(326, 20)
        Me.txtNumeroContrato.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(123, 75)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Mask.EditMask = "d"
        Me.txtNombre.Size = New System.Drawing.Size(327, 20)
        Me.txtNombre.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(26, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Nombre"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(212, 470)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(327, 20)
        Me.txtID.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 104)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Numero"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(178, 473)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "ID:"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(1151, 124)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(0, 23)
        Me.SeparatorControl1.TabIndex = 61
        '
        'cboLicencia
        '
        Me.cboLicencia.Location = New System.Drawing.Point(122, 49)
        Me.cboLicencia.MenuManager = Me.BarManager1
        Me.cboLicencia.Name = "cboLicencia"
        Me.cboLicencia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLicencia.Properties.NullText = ""
        Me.cboLicencia.Properties.PopupSizeable = False
        Me.cboLicencia.Properties.ShowHeader = False
        Me.cboLicencia.Size = New System.Drawing.Size(328, 20)
        Me.cboLicencia.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(26, 52)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Empresa o Licencia"
        '
        'GCConsultar
        '
        Me.GCConsultar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCConsultar.Location = New System.Drawing.Point(12, 256)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(891, 191)
        Me.GCConsultar.TabIndex = 75
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
        Me.colCONTRATO.FieldName = "NOMBRE"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 0
        Me.colCONTRATO.Width = 202
        '
        'colNUMERO_CONTRATO
        '
        Me.colNUMERO_CONTRATO.Caption = "NUMERO"
        Me.colNUMERO_CONTRATO.FieldName = "NUMERO_CONTRATO"
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
        Me.colENTIDAD.Caption = "ENTIDAD"
        Me.colENTIDAD.FieldName = "NOMBRE_ENTIDAD"
        Me.colENTIDAD.Name = "colENTIDAD"
        Me.colENTIDAD.Visible = True
        Me.colENTIDAD.VisibleIndex = 3
        Me.colENTIDAD.Width = 278
        '
        'colTARIFA
        '
        Me.colTARIFA.Caption = "TARIFA"
        Me.colTARIFA.FieldName = "NOMBRE_TARIFA"
        Me.colTARIFA.Name = "colTARIFA"
        Me.colTARIFA.Visible = True
        Me.colTARIFA.VisibleIndex = 4
        Me.colTARIFA.Width = 238
        '
        'frmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 456)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.chkRips)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboTipoContrato)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Controls.Add(Me.cboTarifa)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cboEntidad)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtTelefeno)
        Me.Controls.Add(Me.txtNumeroContrato)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.cboLicencia)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmContratos.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarifa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents cboLicencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkRips As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTipoContrato As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTarifa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboEntidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCorreoElectronico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefeno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIFA As DevExpress.XtraGrid.Columns.GridColumn
End Class

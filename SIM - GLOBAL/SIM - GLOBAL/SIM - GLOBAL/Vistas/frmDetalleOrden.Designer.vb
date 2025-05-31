<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleOrden))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdentificacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPaciente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroOrden = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaIngreso = New DevExpress.XtraEditors.DateEdit()
        Me.deFechaOrden = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodigoCups = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.cboProcedimiento = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.cboGVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCBO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTipoEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNeto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCopago = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoProcedimiento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDetalleOrden = New DevExpress.XtraGrid.GridControl()
        Me.GVDetalleOrden = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSubentidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.cboContrato = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaciente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaOrden.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCodigoCups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCopago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(47, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Orden"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(86, 15)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtOrden.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrden.Properties.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(197, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Fecha Ingreso"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(86, 62)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtIdentificacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdentificacion.Properties.ReadOnly = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Identificacion"
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(272, 62)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtPaciente.Properties.Appearance.Options.UseBackColor = True
        Me.txtPaciente.Properties.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(372, 20)
        Me.txtPaciente.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(225, 65)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Paciente"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(34, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Contrato"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 147)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Fecha Orden"
        '
        'txtNumeroOrden
        '
        Me.txtNumeroOrden.Location = New System.Drawing.Point(248, 144)
        Me.txtNumeroOrden.Name = "txtNumeroOrden"
        Me.txtNumeroOrden.Size = New System.Drawing.Size(86, 20)
        Me.txtNumeroOrden.TabIndex = 15
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(174, 147)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Numero Orden"
        '
        'txtAutorizacion
        '
        Me.txtAutorizacion.Location = New System.Drawing.Point(407, 144)
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Size = New System.Drawing.Size(81, 20)
        Me.txtAutorizacion.TabIndex = 17
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(341, 147)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Autorizacion"
        '
        'deFechaIngreso
        '
        Me.deFechaIngreso.EditValue = Nothing
        Me.deFechaIngreso.Location = New System.Drawing.Point(272, 15)
        Me.deFechaIngreso.Name = "deFechaIngreso"
        Me.deFechaIngreso.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.deFechaIngreso.Properties.Appearance.Options.UseBackColor = True
        Me.deFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaIngreso.Properties.ReadOnly = True
        Me.deFechaIngreso.Size = New System.Drawing.Size(83, 20)
        Me.deFechaIngreso.TabIndex = 18
        '
        'deFechaOrden
        '
        Me.deFechaOrden.EditValue = Nothing
        Me.deFechaOrden.Location = New System.Drawing.Point(84, 144)
        Me.deFechaOrden.Name = "deFechaOrden"
        Me.deFechaOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaOrden.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaOrden.Size = New System.Drawing.Size(83, 20)
        Me.deFechaOrden.TabIndex = 19
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtCodigoCups)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.cboProcedimiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtNeto)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txtCopago)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.txtValor)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.txtCodigoProcedimiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnAgregar)
        Me.GroupControl1.Controls.Add(Me.GCDetalleOrden)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 185)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(688, 288)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = "Detalle de Orden"
        '
        'txtCodigoCups
        '
        Me.txtCodigoCups.Location = New System.Drawing.Point(348, 90)
        Me.txtCodigoCups.Name = "txtCodigoCups"
        Me.txtCodigoCups.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoCups.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoCups.Properties.DisplayFormat.FormatString = "C0"
        Me.txtCodigoCups.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoCups.Properties.EditFormat.FormatString = "C0"
        Me.txtCodigoCups.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoCups.Properties.ReadOnly = True
        Me.txtCodigoCups.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoCups.TabIndex = 125
        Me.txtCodigoCups.Visible = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Enabled = False
        Me.LabelControl16.Location = New System.Drawing.Point(348, 71)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl16.TabIndex = 126
        Me.LabelControl16.Text = "Codigo Cups"
        Me.LabelControl16.Visible = False
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.EditValue = "SELECCIONAR"
        Me.cboProcedimiento.Location = New System.Drawing.Point(120, 47)
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProcedimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcedimiento.Properties.NullText = ""
        Me.cboProcedimiento.Properties.PopupView = Me.cboGVProcedimientos
        Me.cboProcedimiento.Size = New System.Drawing.Size(484, 20)
        Me.cboProcedimiento.TabIndex = 123
        '
        'cboGVProcedimientos
        '
        Me.cboGVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO, Me.colEstudio, Me.colCups, Me.colNombreCBO, Me.colValor, Me.colIDTipoEstudio})
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
        'colEstudio
        '
        Me.colEstudio.Caption = "ESTUDIO"
        Me.colEstudio.FieldName = "ESTUDIO"
        Me.colEstudio.Name = "colEstudio"
        Me.colEstudio.Width = 229
        '
        'colCups
        '
        Me.colCups.Caption = "CUPS"
        Me.colCups.FieldName = "CUPS"
        Me.colCups.Name = "colCups"
        Me.colCups.Visible = True
        Me.colCups.VisibleIndex = 0
        Me.colCups.Width = 259
        '
        'colNombreCBO
        '
        Me.colNombreCBO.Caption = "NOMBRE"
        Me.colNombreCBO.FieldName = "NOMBRE"
        Me.colNombreCBO.Name = "colNombreCBO"
        Me.colNombreCBO.Visible = True
        Me.colNombreCBO.VisibleIndex = 1
        Me.colNombreCBO.Width = 412
        '
        'colValor
        '
        Me.colValor.Caption = "VALOR"
        Me.colValor.DisplayFormat.FormatString = "C0"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 89
        '
        'colIDTipoEstudio
        '
        Me.colIDTipoEstudio.Caption = "IDTIPOESTUDIO"
        Me.colIDTipoEstudio.FieldName = "ID_TIPO_ESTUDIO"
        Me.colIDTipoEstudio.Name = "colIDTipoEstudio"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(120, 28)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl11.TabIndex = 124
        Me.LabelControl11.Text = "Seleccione Estudios"
        '
        'txtNeto
        '
        Me.txtNeto.Location = New System.Drawing.Point(233, 90)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNeto.Properties.Appearance.Options.UseBackColor = True
        Me.txtNeto.Properties.Mask.EditMask = "c"
        Me.txtNeto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNeto.Properties.ReadOnly = True
        Me.txtNeto.Size = New System.Drawing.Size(109, 20)
        Me.txtNeto.TabIndex = 118
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(233, 71)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl12.TabIndex = 122
        Me.LabelControl12.Text = "Neto:"
        '
        'txtCopago
        '
        Me.txtCopago.Location = New System.Drawing.Point(120, 90)
        Me.txtCopago.Name = "txtCopago"
        Me.txtCopago.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCopago.Properties.Appearance.Options.UseBackColor = True
        Me.txtCopago.Properties.Mask.EditMask = "c"
        Me.txtCopago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCopago.Size = New System.Drawing.Size(107, 20)
        Me.txtCopago.TabIndex = 117
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(120, 71)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl20.TabIndex = 121
        Me.LabelControl20.Text = "Copago:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(5, 90)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.Appearance.Options.UseBackColor = True
        Me.txtValor.Properties.Mask.BeepOnError = True
        Me.txtValor.Properties.Mask.EditMask = "c"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Size = New System.Drawing.Size(108, 20)
        Me.txtValor.TabIndex = 116
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(5, 73)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl21.TabIndex = 120
        Me.LabelControl21.Text = "Valor:"
        '
        'txtCodigoProcedimiento
        '
        Me.txtCodigoProcedimiento.Location = New System.Drawing.Point(6, 47)
        Me.txtCodigoProcedimiento.Name = "txtCodigoProcedimiento"
        Me.txtCodigoProcedimiento.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoProcedimiento.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCodigoProcedimiento.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoProcedimiento.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodigoProcedimiento.Properties.ReadOnly = True
        Me.txtCodigoProcedimiento.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigoProcedimiento.TabIndex = 114
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(6, 28)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl19.TabIndex = 119
        Me.LabelControl19.Text = "Codigo"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(644, 44)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminar.TabIndex = 113
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(612, 44)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregar.TabIndex = 112
        '
        'GCDetalleOrden
        '
        Me.GCDetalleOrden.Location = New System.Drawing.Point(6, 116)
        Me.GCDetalleOrden.MainView = Me.GVDetalleOrden
        Me.GCDetalleOrden.Name = "GCDetalleOrden"
        Me.GCDetalleOrden.Size = New System.Drawing.Size(668, 167)
        Me.GCDetalleOrden.TabIndex = 111
        Me.GCDetalleOrden.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetalleOrden})
        '
        'GVDetalleOrden
        '
        Me.GVDetalleOrden.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCODIGO1, Me.colNOMBRE, Me.colVALOR1, Me.colPAGO, Me.colESTADO})
        Me.GVDetalleOrden.GridControl = Me.GCDetalleOrden
        Me.GVDetalleOrden.Name = "GVDetalleOrden"
        Me.GVDetalleOrden.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVDetalleOrden.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVDetalleOrden.OptionsPrint.ExpandAllDetails = True
        Me.GVDetalleOrden.OptionsPrint.ExpandAllGroups = False
        Me.GVDetalleOrden.OptionsPrint.PrintFooter = False
        Me.GVDetalleOrden.OptionsView.ColumnAutoWidth = False
        Me.GVDetalleOrden.OptionsView.ShowFooter = True
        Me.GVDetalleOrden.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colCODIGO1
        '
        Me.colCODIGO1.Caption = "CODIGO"
        Me.colCODIGO1.FieldName = "CODIGO"
        Me.colCODIGO1.Name = "colCODIGO1"
        Me.colCODIGO1.OptionsColumn.AllowEdit = False
        Me.colCODIGO1.OptionsColumn.ReadOnly = True
        Me.colCODIGO1.Visible = True
        Me.colCODIGO1.VisibleIndex = 0
        Me.colCODIGO1.Width = 74
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "NOMBRE"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.OptionsColumn.AllowEdit = False
        Me.colNOMBRE.OptionsColumn.ReadOnly = True
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        Me.colNOMBRE.Width = 353
        '
        'colVALOR1
        '
        Me.colVALOR1.Caption = "VALOR"
        Me.colVALOR1.DisplayFormat.FormatString = "{0:C0}"
        Me.colVALOR1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR1.FieldName = "VALOR"
        Me.colVALOR1.Name = "colVALOR1"
        Me.colVALOR1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALOR1.Visible = True
        Me.colVALOR1.VisibleIndex = 2
        Me.colVALOR1.Width = 118
        '
        'colPAGO
        '
        Me.colPAGO.Caption = "COPAGO"
        Me.colPAGO.DisplayFormat.FormatString = "{0:C0}"
        Me.colPAGO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPAGO.FieldName = "COPAGO"
        Me.colPAGO.Name = "colPAGO"
        Me.colPAGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COPAGO", "{0:C0}")})
        Me.colPAGO.Visible = True
        Me.colPAGO.VisibleIndex = 3
        Me.colPAGO.Width = 105
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.OptionsColumn.ReadOnly = True
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.Location = New System.Drawing.Point(13, 37)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(688, 19)
        Me.SeparatorControl1.TabIndex = 43
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.AutoSizeMode = True
        Me.SeparatorControl2.Location = New System.Drawing.Point(20, 114)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(667, 19)
        Me.SeparatorControl2.TabIndex = 44
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(494, 147)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl10.TabIndex = 46
        Me.LabelControl10.Text = "Sub Entidad"
        '
        'cboSubentidad
        '
        Me.cboSubentidad.Location = New System.Drawing.Point(557, 144)
        Me.cboSubentidad.Name = "cboSubentidad"
        Me.cboSubentidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSubentidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubentidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE")})
        Me.cboSubentidad.Properties.NullText = ""
        Me.cboSubentidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboSubentidad.Properties.PopupWidth = 600
        Me.cboSubentidad.Properties.ShowHeader = False
        Me.cboSubentidad.Size = New System.Drawing.Size(144, 20)
        Me.cboSubentidad.TabIndex = 47
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(479, 18)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl13.TabIndex = 49
        Me.LabelControl13.Text = "Consecutivo"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(544, 15)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsecutivo.TabIndex = 48
        '
        'cboContrato
        '
        Me.cboContrato.Location = New System.Drawing.Point(86, 88)
        Me.cboContrato.Name = "cboContrato"
        Me.cboContrato.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContrato.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTRATO", "CONTRATO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTIDAD", "ENTIDAD"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA")})
        Me.cboContrato.Properties.NullText = ""
        Me.cboContrato.Properties.PopupWidth = 600
        Me.cboContrato.Size = New System.Drawing.Size(558, 20)
        Me.cboContrato.TabIndex = 132
        '
        'frmDetalleOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 496)
        Me.Controls.Add(Me.cboContrato)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.cboSubentidad)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.deFechaOrden)
        Me.Controls.Add(Me.deFechaIngreso)
        Me.Controls.Add(Me.txtAutorizacion)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtNumeroOrden)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.LabelControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmDetalleOrden.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalleOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Orden"
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaciente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaOrden.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCodigoCups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCopago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdentificacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPaciente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deFechaOrden As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNeto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCopago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoProcedimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDetalleOrden As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetalleOrden As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtCodigoCups As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProcedimiento As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents cboGVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCBO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTipoEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSubentidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboContrato As DevExpress.XtraEditors.LookUpEdit
End Class

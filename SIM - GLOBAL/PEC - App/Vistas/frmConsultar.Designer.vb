<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultar
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHASOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANALISTA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 10
        Me.colESTADO.Width = 87
        '
        'colESTUDIO
        '
        Me.colESTUDIO.Caption = "ESTUDIO"
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 8
        Me.colESTUDIO.Width = 198
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1133, 519)
        Me.GCConsultar.TabIndex = 2
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORDEN, Me.colFECHA_INGRESO, Me.colFECHASOLICITUD, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colEDAD, Me.colCONTRATO, Me.colESTUDIO, Me.colANALISTA, Me.colESTADO})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colESTADO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "PENDIENTE"
        FormatConditionRuleValue1.Value1 = "PENDIENTE"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colESTADO
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "CANCELADO"
        FormatConditionRuleValue2.Value1 = "CANCELADO"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.colESTUDIO
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Expression = "ANEXOS"
        FormatConditionRuleValue3.Value1 = "ANEXOS"
        FormatConditionRuleValue3.Value2 = ""
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.GVConsultar.FormatRules.Add(GridFormatRule1)
        Me.GVConsultar.FormatRules.Add(GridFormatRule2)
        Me.GVConsultar.FormatRules.Add(GridFormatRule3)
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsBehavior.ReadOnly = True
        Me.GVConsultar.OptionsFind.AlwaysVisible = True
        Me.GVConsultar.OptionsPrint.AutoWidth = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colORDEN
        '
        Me.colORDEN.Caption = "ORDEN"
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 0
        Me.colORDEN.Width = 49
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "FECHA INGRESO"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 97
        '
        'colFECHASOLICITUD
        '
        Me.colFECHASOLICITUD.Caption = "FECHA SOLICITUD"
        Me.colFECHASOLICITUD.FieldName = "FECHA_SOLICITUD"
        Me.colFECHASOLICITUD.Name = "colFECHASOLICITUD"
        Me.colFECHASOLICITUD.Visible = True
        Me.colFECHASOLICITUD.VisibleIndex = 2
        Me.colFECHASOLICITUD.Width = 102
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 3
        Me.colIDENTIFICACION.Width = 145
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "NOMBRE"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 4
        Me.colNOMBRE.Width = 226
        '
        'colSEXO
        '
        Me.colSEXO.Caption = "SEXO"
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 5
        Me.colSEXO.Width = 42
        '
        'colEDAD
        '
        Me.colEDAD.Caption = "EDAD"
        Me.colEDAD.FieldName = "EDAD"
        Me.colEDAD.Name = "colEDAD"
        Me.colEDAD.Visible = True
        Me.colEDAD.VisibleIndex = 6
        Me.colEDAD.Width = 53
        '
        'colCONTRATO
        '
        Me.colCONTRATO.Caption = "CONTRATO"
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 7
        Me.colCONTRATO.Width = 195
        '
        'colANALISTA
        '
        Me.colANALISTA.Caption = "ANALISTA"
        Me.colANALISTA.FieldName = "ANALISTA"
        Me.colANALISTA.Name = "colANALISTA"
        Me.colANALISTA.Visible = True
        Me.colANALISTA.VisibleIndex = 9
        Me.colANALISTA.Width = 214
        '
        'frmConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 519)
        Me.Controls.Add(Me.GCConsultar)
        Me.Name = "frmConsultar"
        Me.Text = "Consultar Estudios"
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHASOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANALISTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTorneos
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
        Me.GCTorneos = New DevExpress.XtraGrid.GridControl()
        Me.DTTorneosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSVistas = New ADOSPLAY.DSVistas()
        Me.GVTorneos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION_CAMPEONATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_ORGANIZADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboOrganizador = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colID_DEPORTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDeporte = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNombre = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.txtDescripcionTorneo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.DTTorneosTableAdapter = New ADOSPLAY.DSVistasTableAdapters.DTTorneosTableAdapter()
        CType(Me.GCTorneos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTTorneosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVTorneos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrganizador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDeporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionTorneo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCTorneos
        '
        Me.GCTorneos.DataSource = Me.DTTorneosBindingSource
        Me.GCTorneos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCTorneos.Location = New System.Drawing.Point(0, 0)
        Me.GCTorneos.MainView = Me.GVTorneos
        Me.GCTorneos.Name = "GCTorneos"
        Me.GCTorneos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboOrganizador, Me.cboDeporte, Me.txtNombre, Me.txtDescripcionTorneo, Me.txtDescripcion})
        Me.GCTorneos.Size = New System.Drawing.Size(1136, 302)
        Me.GCTorneos.TabIndex = 0
        Me.GCTorneos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTorneos})
        '
        'DTTorneosBindingSource
        '
        Me.DTTorneosBindingSource.DataMember = "DTTorneos"
        Me.DTTorneosBindingSource.DataSource = Me.DSVistas
        '
        'DSVistas
        '
        Me.DSVistas.DataSetName = "DSVistas"
        Me.DSVistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GVTorneos
        '
        Me.GVTorneos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNOMBRE, Me.colDESCRIPCION_CAMPEONATO, Me.colFECHA_INICIO, Me.colID_ORGANIZADOR, Me.colID_DEPORTE, Me.colESTADO})
        Me.GVTorneos.GridControl = Me.GCTorneos
        Me.GVTorneos.Name = "GVTorneos"
        Me.GVTorneos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colID
        '
        Me.colID.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.colID.AppearanceCell.Options.UseBackColor = True
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 45
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "TORNEOS"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        Me.colNOMBRE.Width = 233
        '
        'colDESCRIPCION_CAMPEONATO
        '
        Me.colDESCRIPCION_CAMPEONATO.Caption = "DESCRIPCION"
        Me.colDESCRIPCION_CAMPEONATO.ColumnEdit = Me.txtDescripcionTorneo
        Me.colDESCRIPCION_CAMPEONATO.FieldName = "DESCRIPCION_CAMPEONATO"
        Me.colDESCRIPCION_CAMPEONATO.Name = "colDESCRIPCION_CAMPEONATO"
        Me.colDESCRIPCION_CAMPEONATO.Visible = True
        Me.colDESCRIPCION_CAMPEONATO.VisibleIndex = 2
        Me.colDESCRIPCION_CAMPEONATO.Width = 407
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "FECHA INICIO"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 3
        Me.colFECHA_INICIO.Width = 107
        '
        'colID_ORGANIZADOR
        '
        Me.colID_ORGANIZADOR.Caption = "ORGANIZADOR"
        Me.colID_ORGANIZADOR.ColumnEdit = Me.cboOrganizador
        Me.colID_ORGANIZADOR.FieldName = "ID_ORGANIZADOR"
        Me.colID_ORGANIZADOR.Name = "colID_ORGANIZADOR"
        Me.colID_ORGANIZADOR.Visible = True
        Me.colID_ORGANIZADOR.VisibleIndex = 4
        Me.colID_ORGANIZADOR.Width = 131
        '
        'cboOrganizador
        '
        Me.cboOrganizador.AutoHeight = False
        Me.cboOrganizador.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrganizador.Name = "cboOrganizador"
        '
        'colID_DEPORTE
        '
        Me.colID_DEPORTE.Caption = "DEPORTE"
        Me.colID_DEPORTE.ColumnEdit = Me.cboDeporte
        Me.colID_DEPORTE.FieldName = "ID_DEPORTE"
        Me.colID_DEPORTE.Name = "colID_DEPORTE"
        Me.colID_DEPORTE.Visible = True
        Me.colID_DEPORTE.VisibleIndex = 5
        Me.colID_DEPORTE.Width = 127
        '
        'cboDeporte
        '
        Me.cboDeporte.AutoHeight = False
        Me.cboDeporte.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDeporte.Name = "cboDeporte"
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 6
        Me.colESTADO.Width = 68
        '
        'txtNombre
        '
        Me.txtNombre.Name = "txtNombre"
        '
        'txtDescripcionTorneo
        '
        Me.txtDescripcionTorneo.AutoHeight = False
        Me.txtDescripcionTorneo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDescripcionTorneo.Name = "txtDescripcionTorneo"
        '
        'DTTorneosTableAdapter
        '
        Me.DTTorneosTableAdapter.ClearBeforeFill = True
        '
        'frmTorneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 302)
        Me.Controls.Add(Me.GCTorneos)
        Me.Name = "frmTorneos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Torneos"
        CType(Me.GCTorneos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTTorneosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVTorneos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrganizador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDeporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionTorneo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCTorneos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVTorneos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DSVistas As DSVistas
    Friend WithEvents DTTorneosBindingSource As BindingSource
    Friend WithEvents DTTorneosTableAdapter As DSVistasTableAdapters.DTTorneosTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_CAMPEONATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ORGANIZADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_DEPORTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboOrganizador As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDeporte As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents txtDescripcionTorneo As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class

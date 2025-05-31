<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DsCD = New SIM___GLOBAL.dsCD()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportePatologiaCDTableAdapter2 = New SIM___GLOBAL.dsCDTableAdapters.ReportePatologiaCDTableAdapter()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.BindingSource2
        Me.GridControl3.Location = New System.Drawing.Point(308, 132)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(400, 200)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        '
        'DsCD
        '
        Me.DsCD.DataSetName = "dsCD"
        Me.DsCD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "ReportePatologiaCD"
        Me.BindingSource2.DataSource = Me.DsCD
        '
        'ReportePatologiaCDTableAdapter2
        '
        Me.ReportePatologiaCDTableAdapter2.ClearBeforeFill = True
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "ID"
        Me.GridColumn28.MinWidth = 22
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        Me.GridColumn28.Width = 83
        '
        'GridColumn29
        '
        Me.GridColumn29.FieldName = "CONSECUTIVO"
        Me.GridColumn29.MinWidth = 22
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 1
        Me.GridColumn29.Width = 83
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "FECHA_INGRESO"
        Me.GridColumn30.MinWidth = 22
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 2
        Me.GridColumn30.Width = 83
        '
        'GridColumn31
        '
        Me.GridColumn31.FieldName = "IDENTIFICACION"
        Me.GridColumn31.MinWidth = 22
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 3
        Me.GridColumn31.Width = 83
        '
        'GridColumn32
        '
        Me.GridColumn32.FieldName = "NOMBRE"
        Me.GridColumn32.MinWidth = 22
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 4
        Me.GridColumn32.Width = 83
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "EDAD"
        Me.GridColumn33.MinWidth = 22
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 5
        Me.GridColumn33.Width = 83
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "SEXO"
        Me.GridColumn34.MinWidth = 22
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 6
        Me.GridColumn34.Width = 83
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "ESTADO_CIVIL"
        Me.GridColumn35.MinWidth = 22
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 7
        Me.GridColumn35.Width = 83
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "TELEFONO"
        Me.GridColumn36.MinWidth = 22
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 8
        Me.GridColumn36.Width = 83
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "DIRECCION"
        Me.GridColumn37.MinWidth = 22
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 9
        Me.GridColumn37.Width = 83
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "NOMBRE_ENTIDAD"
        Me.GridColumn38.MinWidth = 22
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 10
        Me.GridColumn38.Width = 83
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "TIPO_MUESTRA"
        Me.GridColumn39.MinWidth = 22
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 11
        Me.GridColumn39.Width = 83
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "SITIO_LESION"
        Me.GridColumn40.MinWidth = 22
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 12
        Me.GridColumn40.Width = 83
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "SOLICITADO"
        Me.GridColumn41.MinWidth = 22
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 13
        Me.GridColumn41.Width = 83
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "DESCRIPCION_MACROSCOPICA"
        Me.GridColumn42.MinWidth = 22
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 14
        Me.GridColumn42.Width = 83
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "DESCRIPCION_MICROSCOPICA"
        Me.GridColumn43.MinWidth = 22
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 15
        Me.GridColumn43.Width = 83
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "DIAGNOSTICO"
        Me.GridColumn44.MinWidth = 22
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 16
        Me.GridColumn44.Width = 83
        '
        'GridColumn45
        '
        Me.GridColumn45.FieldName = "OBSERVACIONES"
        Me.GridColumn45.MinWidth = 22
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 17
        Me.GridColumn45.Width = 83
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "CODIGO_DIAGNOSTICO"
        Me.GridColumn46.MinWidth = 22
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 18
        Me.GridColumn46.Width = 83
        '
        'GridColumn47
        '
        Me.GridColumn47.FieldName = "nombre_diagnostico"
        Me.GridColumn47.MinWidth = 22
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 19
        Me.GridColumn47.Width = 83
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "ID_LICENCIA"
        Me.GridColumn48.MinWidth = 22
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 20
        Me.GridColumn48.Width = 83
        '
        'GridColumn49
        '
        Me.GridColumn49.FieldName = "ID_EMPLEADO"
        Me.GridColumn49.MinWidth = 22
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 21
        Me.GridColumn49.Width = 83
        '
        'GridColumn50
        '
        Me.GridColumn50.FieldName = "medico"
        Me.GridColumn50.MinWidth = 22
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 22
        Me.GridColumn50.Width = 83
        '
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "especialidad"
        Me.GridColumn51.MinWidth = 22
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 23
        Me.GridColumn51.Width = 83
        '
        'GridColumn52
        '
        Me.GridColumn52.FieldName = "registro_medico"
        Me.GridColumn52.MinWidth = 22
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 24
        Me.GridColumn52.Width = 83
        '
        'GridColumn53
        '
        Me.GridColumn53.FieldName = "firma"
        Me.GridColumn53.MinWidth = 22
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 25
        Me.GridColumn53.Width = 83
        '
        'GridColumn54
        '
        Me.GridColumn54.FieldName = "fecha_salida"
        Me.GridColumn54.MinWidth = 22
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 26
        Me.GridColumn54.Width = 83
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(871, 454)
        Me.Controls.Add(Me.GridControl3)
        Me.Name = "Form1"
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtIMC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTalla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPeso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents DtReportePatologiaCD As dtReportePatologiaCD
    Friend WithEvents ReportePatologiaCDBindingSource As BindingSource
    'Friend WithEvents ReportePatologiaCDTableAdapter As dtReportePatologiaCDTableAdapters.ReportePatologiaCDTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReportePatologiaCDBindingSource1 As BindingSource
    Friend WithEvents ReportePatologiaCDTableAdapter1 As DataSet1TableAdapters.ReportePatologiaCDTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_CIVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_ENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_MUESTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSITIO_LESION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOLICITADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_MACROSCOPICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_MICROSCOPICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAGNOSTICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACIONES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DIAGNOSTICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombre_diagnostico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_LICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmedico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colespecialidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colregistro_medico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfecha_salida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    'Friend WithEvents DtPatologiaCD As dtPatologiaCD
    Friend WithEvents BindingSource1 As BindingSource
    'Friend WithEvents ReportePatologiaCDTableAdapter As dtPatologiaCDTableAdapters.ReportePatologiaCDTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsCD As dsCD
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents ReportePatologiaCDTableAdapter2 As dsCDTableAdapters.ReportePatologiaCDTableAdapter
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
End Class

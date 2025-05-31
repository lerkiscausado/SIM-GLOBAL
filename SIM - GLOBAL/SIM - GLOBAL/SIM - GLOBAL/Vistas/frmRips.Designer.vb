<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRips
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRips))
        Me.xtcReporteEstudio = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUsuarios = New DevExpress.XtraTab.XtraTabPage()
        Me.GCUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.GVUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUTipoIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUCodigoEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUCodigoTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPrimerApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSegundoApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPrimerNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSegundoNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpFacturas = New DevExpress.XtraTab.XtraTabPage()
        Me.GCFacturas = New DevExpress.XtraGrid.GridControl()
        Me.GVFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPrestador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFechaFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFechaFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFCodigoEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPoliza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFComision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpConsultas = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultas = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCPrestador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFinalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCausa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCIE10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTipoDiagnostico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpProcedimientos = New DevExpress.XtraTab.XtraTabPage()
        Me.GCProcedimientos = New DevExpress.XtraGrid.GridControl()
        Me.GVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPPrestador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAmbito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPFinalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAtiende = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPCie10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRealizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFacturas = New DevExpress.XtraBars.BarEditItem()
        Me.rcboFacturas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.xtcReporteEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcReporteEstudio.SuspendLayout()
        Me.xtpUsuarios.SuspendLayout()
        CType(Me.GCUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFacturas.SuspendLayout()
        CType(Me.GCFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpConsultas.SuspendLayout()
        CType(Me.GCConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpProcedimientos.SuspendLayout()
        CType(Me.GCProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcboFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xtcReporteEstudio
        '
        Me.xtcReporteEstudio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcReporteEstudio.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcReporteEstudio.Location = New System.Drawing.Point(12, 37)
        Me.xtcReporteEstudio.Name = "xtcReporteEstudio"
        Me.xtcReporteEstudio.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.None
        Me.xtcReporteEstudio.SelectedTabPage = Me.xtpUsuarios
        Me.xtcReporteEstudio.Size = New System.Drawing.Size(1077, 329)
        Me.xtcReporteEstudio.TabIndex = 98
        Me.xtcReporteEstudio.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsuarios, Me.xtpFacturas, Me.xtpConsultas, Me.xtpProcedimientos})
        '
        'xtpUsuarios
        '
        Me.xtpUsuarios.Controls.Add(Me.GCUsuarios)
        Me.xtpUsuarios.Name = "xtpUsuarios"
        Me.xtpUsuarios.Size = New System.Drawing.Size(1071, 301)
        Me.xtpUsuarios.Text = "USUARIOS"
        '
        'GCUsuarios
        '
        Me.GCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.GCUsuarios.MainView = Me.GVUsuarios
        Me.GCUsuarios.Name = "GCUsuarios"
        Me.GCUsuarios.Size = New System.Drawing.Size(1071, 301)
        Me.GCUsuarios.TabIndex = 2
        Me.GCUsuarios.UseEmbeddedNavigator = True
        Me.GCUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVUsuarios})
        '
        'GVUsuarios
        '
        Me.GVUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUTipoIdentificacion, Me.colUIdentificacion, Me.colUCodigoEntidad, Me.colUCodigoTipoUsuario, Me.colUPrimerApellido, Me.colUSegundoApellido, Me.colUPrimerNombre, Me.colUSegundoNombre, Me.colUEdad, Me.colUMedida, Me.colUSexo, Me.colUDepartamento, Me.colUMunicipio, Me.colUZona})
        Me.GVUsuarios.GridControl = Me.GCUsuarios
        Me.GVUsuarios.Name = "GVUsuarios"
        Me.GVUsuarios.OptionsBehavior.Editable = False
        Me.GVUsuarios.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVUsuarios.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVUsuarios.OptionsPrint.ExpandAllDetails = True
        Me.GVUsuarios.OptionsPrint.ExpandAllGroups = False
        Me.GVUsuarios.OptionsPrint.PrintFooter = False
        Me.GVUsuarios.OptionsPrint.PrintHeader = False
        Me.GVUsuarios.OptionsView.ColumnAutoWidth = False
        Me.GVUsuarios.OptionsView.EnableAppearanceOddRow = True
        Me.GVUsuarios.OptionsView.ShowFooter = True
        Me.GVUsuarios.OptionsView.ShowGroupPanel = False
        '
        'colUTipoIdentificacion
        '
        Me.colUTipoIdentificacion.Caption = "TIPO"
        Me.colUTipoIdentificacion.FieldName = "ID_TIPO_IDENTIFICACION"
        Me.colUTipoIdentificacion.Name = "colUTipoIdentificacion"
        Me.colUTipoIdentificacion.Visible = True
        Me.colUTipoIdentificacion.VisibleIndex = 0
        Me.colUTipoIdentificacion.Width = 33
        '
        'colUIdentificacion
        '
        Me.colUIdentificacion.Caption = "IDENTIFICACION"
        Me.colUIdentificacion.FieldName = "IDENTIFICACION"
        Me.colUIdentificacion.Name = "colUIdentificacion"
        Me.colUIdentificacion.Visible = True
        Me.colUIdentificacion.VisibleIndex = 1
        Me.colUIdentificacion.Width = 95
        '
        'colUCodigoEntidad
        '
        Me.colUCodigoEntidad.Caption = "CODIGO ENTIDAD"
        Me.colUCodigoEntidad.FieldName = "CODIGO_ENTIDAD"
        Me.colUCodigoEntidad.Name = "colUCodigoEntidad"
        Me.colUCodigoEntidad.Visible = True
        Me.colUCodigoEntidad.VisibleIndex = 2
        Me.colUCodigoEntidad.Width = 102
        '
        'colUCodigoTipoUsuario
        '
        Me.colUCodigoTipoUsuario.Caption = "TIPO USUARIO"
        Me.colUCodigoTipoUsuario.FieldName = "CODIGO_TIPO_USUARIO"
        Me.colUCodigoTipoUsuario.Name = "colUCodigoTipoUsuario"
        Me.colUCodigoTipoUsuario.Visible = True
        Me.colUCodigoTipoUsuario.VisibleIndex = 3
        Me.colUCodigoTipoUsuario.Width = 81
        '
        'colUPrimerApellido
        '
        Me.colUPrimerApellido.Caption = "PRIMER APELLIDO"
        Me.colUPrimerApellido.FieldName = "PRIMER_APELLIDO"
        Me.colUPrimerApellido.Name = "colUPrimerApellido"
        Me.colUPrimerApellido.Visible = True
        Me.colUPrimerApellido.VisibleIndex = 4
        Me.colUPrimerApellido.Width = 98
        '
        'colUSegundoApellido
        '
        Me.colUSegundoApellido.Caption = "SEGUNDO APELLIDO"
        Me.colUSegundoApellido.FieldName = "SEGUNDO_APELLIDO"
        Me.colUSegundoApellido.Name = "colUSegundoApellido"
        Me.colUSegundoApellido.Visible = True
        Me.colUSegundoApellido.VisibleIndex = 5
        Me.colUSegundoApellido.Width = 109
        '
        'colUPrimerNombre
        '
        Me.colUPrimerNombre.Caption = "PRIMER NOMBRE"
        Me.colUPrimerNombre.FieldName = "PRIMER_NOMBRE"
        Me.colUPrimerNombre.Name = "colUPrimerNombre"
        Me.colUPrimerNombre.Visible = True
        Me.colUPrimerNombre.VisibleIndex = 6
        Me.colUPrimerNombre.Width = 96
        '
        'colUSegundoNombre
        '
        Me.colUSegundoNombre.Caption = "SEGUNDO NOMBRE"
        Me.colUSegundoNombre.FieldName = "SEGUNDO_NOMBRE"
        Me.colUSegundoNombre.Name = "colUSegundoNombre"
        Me.colUSegundoNombre.Visible = True
        Me.colUSegundoNombre.VisibleIndex = 7
        Me.colUSegundoNombre.Width = 104
        '
        'colUEdad
        '
        Me.colUEdad.Caption = "EDAD"
        Me.colUEdad.FieldName = "EDAD"
        Me.colUEdad.Name = "colUEdad"
        Me.colUEdad.Visible = True
        Me.colUEdad.VisibleIndex = 8
        Me.colUEdad.Width = 41
        '
        'colUMedida
        '
        Me.colUMedida.Caption = "MEDIDA"
        Me.colUMedida.FieldName = "MEDIDA"
        Me.colUMedida.Name = "colUMedida"
        Me.colUMedida.Visible = True
        Me.colUMedida.VisibleIndex = 9
        Me.colUMedida.Width = 47
        '
        'colUSexo
        '
        Me.colUSexo.Caption = "SEXO"
        Me.colUSexo.FieldName = "SEXO"
        Me.colUSexo.Name = "colUSexo"
        Me.colUSexo.Visible = True
        Me.colUSexo.VisibleIndex = 10
        Me.colUSexo.Width = 36
        '
        'colUDepartamento
        '
        Me.colUDepartamento.Caption = "DEPARTAMENTO"
        Me.colUDepartamento.FieldName = "DEPARTAMENTO"
        Me.colUDepartamento.Name = "colUDepartamento"
        Me.colUDepartamento.Visible = True
        Me.colUDepartamento.VisibleIndex = 11
        Me.colUDepartamento.Width = 90
        '
        'colUMunicipio
        '
        Me.colUMunicipio.Caption = "MUNICIPIO"
        Me.colUMunicipio.FieldName = "MUNICIPIO"
        Me.colUMunicipio.Name = "colUMunicipio"
        Me.colUMunicipio.Visible = True
        Me.colUMunicipio.VisibleIndex = 12
        Me.colUMunicipio.Width = 66
        '
        'colUZona
        '
        Me.colUZona.Caption = "ZONA"
        Me.colUZona.FieldName = "ZONA"
        Me.colUZona.Name = "colUZona"
        Me.colUZona.Visible = True
        Me.colUZona.VisibleIndex = 13
        '
        'xtpFacturas
        '
        Me.xtpFacturas.Controls.Add(Me.GCFacturas)
        Me.xtpFacturas.Name = "xtpFacturas"
        Me.xtpFacturas.Size = New System.Drawing.Size(1071, 301)
        Me.xtpFacturas.Text = "FACTURAS"
        '
        'GCFacturas
        '
        Me.GCFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCFacturas.Location = New System.Drawing.Point(0, 0)
        Me.GCFacturas.MainView = Me.GVFacturas
        Me.GCFacturas.Name = "GCFacturas"
        Me.GCFacturas.Size = New System.Drawing.Size(1071, 301)
        Me.GCFacturas.TabIndex = 3
        Me.GCFacturas.UseEmbeddedNavigator = True
        Me.GCFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFacturas})
        '
        'GVFacturas
        '
        Me.GVFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCodigo, Me.colFPrestador, Me.colfTipo, Me.colFIdentificacion, Me.colFFactura, Me.colFFechaIngreso, Me.colFFechaFinal, Me.colFFechaFactura, Me.colFCodigoEntidad, Me.colFEntidad, Me.colFContrato, Me.colFPlan, Me.colFPoliza, Me.colFCopago, Me.colFComision, Me.colFDescuento, Me.colFNeto})
        Me.GVFacturas.GridControl = Me.GCFacturas
        Me.GVFacturas.Name = "GVFacturas"
        Me.GVFacturas.OptionsBehavior.Editable = False
        Me.GVFacturas.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVFacturas.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVFacturas.OptionsPrint.ExpandAllDetails = True
        Me.GVFacturas.OptionsPrint.ExpandAllGroups = False
        Me.GVFacturas.OptionsPrint.PrintFooter = False
        Me.GVFacturas.OptionsView.ColumnAutoWidth = False
        Me.GVFacturas.OptionsView.EnableAppearanceOddRow = True
        Me.GVFacturas.OptionsView.ShowFooter = True
        Me.GVFacturas.OptionsView.ShowGroupPanel = False
        '
        'colFCodigo
        '
        Me.colFCodigo.Caption = "CODIGO"
        Me.colFCodigo.FieldName = "CODIGO"
        Me.colFCodigo.Name = "colFCodigo"
        Me.colFCodigo.Visible = True
        Me.colFCodigo.VisibleIndex = 0
        Me.colFCodigo.Width = 97
        '
        'colFPrestador
        '
        Me.colFPrestador.Caption = "PRESTADOR"
        Me.colFPrestador.FieldName = "PRESTADOR"
        Me.colFPrestador.Name = "colFPrestador"
        Me.colFPrestador.Visible = True
        Me.colFPrestador.VisibleIndex = 1
        Me.colFPrestador.Width = 213
        '
        'colfTipo
        '
        Me.colfTipo.Caption = "TIPO"
        Me.colfTipo.FieldName = "TIPO"
        Me.colfTipo.Name = "colfTipo"
        Me.colfTipo.Visible = True
        Me.colfTipo.VisibleIndex = 2
        Me.colfTipo.Width = 35
        '
        'colFIdentificacion
        '
        Me.colFIdentificacion.Caption = "IDENTIFICACION"
        Me.colFIdentificacion.FieldName = "IDENTIFICACION"
        Me.colFIdentificacion.Name = "colFIdentificacion"
        Me.colFIdentificacion.Visible = True
        Me.colFIdentificacion.VisibleIndex = 3
        Me.colFIdentificacion.Width = 96
        '
        'colFFactura
        '
        Me.colFFactura.Caption = "FACTURA"
        Me.colFFactura.FieldName = "FACTURA"
        Me.colFFactura.Name = "colFFactura"
        Me.colFFactura.Visible = True
        Me.colFFactura.VisibleIndex = 4
        Me.colFFactura.Width = 57
        '
        'colFFechaIngreso
        '
        Me.colFFechaIngreso.Caption = "FECHA INICIAL"
        Me.colFFechaIngreso.FieldName = "INGRESO"
        Me.colFFechaIngreso.Name = "colFFechaIngreso"
        Me.colFFechaIngreso.Visible = True
        Me.colFFechaIngreso.VisibleIndex = 6
        Me.colFFechaIngreso.Width = 83
        '
        'colFFechaFinal
        '
        Me.colFFechaFinal.Caption = "FECHA FINAL"
        Me.colFFechaFinal.FieldName = "FINAL"
        Me.colFFechaFinal.Name = "colFFechaFinal"
        Me.colFFechaFinal.Visible = True
        Me.colFFechaFinal.VisibleIndex = 7
        '
        'colFFechaFactura
        '
        Me.colFFechaFactura.Caption = "FECHA FACTURA"
        Me.colFFechaFactura.FieldName = "FECHA_FACTURA"
        Me.colFFechaFactura.Name = "colFFechaFactura"
        Me.colFFechaFactura.Visible = True
        Me.colFFechaFactura.VisibleIndex = 5
        Me.colFFechaFactura.Width = 94
        '
        'colFCodigoEntidad
        '
        Me.colFCodigoEntidad.Caption = "CODIGO"
        Me.colFCodigoEntidad.FieldName = "CODIGO_ENTIDAD"
        Me.colFCodigoEntidad.Name = "colFCodigoEntidad"
        Me.colFCodigoEntidad.Visible = True
        Me.colFCodigoEntidad.VisibleIndex = 8
        Me.colFCodigoEntidad.Width = 56
        '
        'colFEntidad
        '
        Me.colFEntidad.Caption = "ENTIDAD"
        Me.colFEntidad.FieldName = "ENTIDAD"
        Me.colFEntidad.Name = "colFEntidad"
        Me.colFEntidad.Visible = True
        Me.colFEntidad.VisibleIndex = 9
        Me.colFEntidad.Width = 202
        '
        'colFContrato
        '
        Me.colFContrato.Caption = "CONTRATO"
        Me.colFContrato.FieldName = "CONTRATO"
        Me.colFContrato.Name = "colFContrato"
        Me.colFContrato.Visible = True
        Me.colFContrato.VisibleIndex = 10
        Me.colFContrato.Width = 93
        '
        'colFPlan
        '
        Me.colFPlan.Caption = "PLAN"
        Me.colFPlan.FieldName = "PLAN"
        Me.colFPlan.Name = "colFPlan"
        Me.colFPlan.Visible = True
        Me.colFPlan.VisibleIndex = 11
        Me.colFPlan.Width = 58
        '
        'colFPoliza
        '
        Me.colFPoliza.Caption = "POLIZA"
        Me.colFPoliza.FieldName = "POLIZA"
        Me.colFPoliza.Name = "colFPoliza"
        Me.colFPoliza.Visible = True
        Me.colFPoliza.VisibleIndex = 12
        Me.colFPoliza.Width = 62
        '
        'colFCopago
        '
        Me.colFCopago.Caption = "COPAGO"
        Me.colFCopago.FieldName = "COPAGO"
        Me.colFCopago.Name = "colFCopago"
        Me.colFCopago.Visible = True
        Me.colFCopago.VisibleIndex = 13
        Me.colFCopago.Width = 70
        '
        'colFComision
        '
        Me.colFComision.Caption = "COMISION"
        Me.colFComision.FieldName = "COMISION"
        Me.colFComision.Name = "colFComision"
        Me.colFComision.Visible = True
        Me.colFComision.VisibleIndex = 14
        Me.colFComision.Width = 65
        '
        'colFDescuento
        '
        Me.colFDescuento.Caption = "DESCUENTO"
        Me.colFDescuento.FieldName = "DESCUENTO"
        Me.colFDescuento.Name = "colFDescuento"
        Me.colFDescuento.Visible = True
        Me.colFDescuento.VisibleIndex = 15
        '
        'colFNeto
        '
        Me.colFNeto.Caption = "NETO"
        Me.colFNeto.FieldName = "NETO"
        Me.colFNeto.Name = "colFNeto"
        Me.colFNeto.Visible = True
        Me.colFNeto.VisibleIndex = 16
        '
        'xtpConsultas
        '
        Me.xtpConsultas.Controls.Add(Me.GCConsultas)
        Me.xtpConsultas.Name = "xtpConsultas"
        Me.xtpConsultas.Size = New System.Drawing.Size(1071, 301)
        Me.xtpConsultas.Text = "CONSULTAS"
        '
        'GCConsultas
        '
        Me.GCConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultas.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultas.MainView = Me.GVConsultas
        Me.GCConsultas.Name = "GCConsultas"
        Me.GCConsultas.Size = New System.Drawing.Size(1071, 301)
        Me.GCConsultas.TabIndex = 3
        Me.GCConsultas.UseEmbeddedNavigator = True
        Me.GCConsultas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultas})
        '
        'GVConsultas
        '
        Me.GVConsultas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCFactura, Me.colCPrestador, Me.colCTipo, Me.colCIdentificacion, Me.colCFecha, Me.colCAutorizacion, Me.colCCodigo, Me.colCFinalidad, Me.colCCausa, Me.colCCIE10, Me.colCD1, Me.colCD2, Me.colCD3, Me.colCTipoDiagnostico, Me.colCValor, Me.colCCopago, Me.colCNeto})
        Me.GVConsultas.GridControl = Me.GCConsultas
        Me.GVConsultas.Name = "GVConsultas"
        Me.GVConsultas.OptionsBehavior.Editable = False
        Me.GVConsultas.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultas.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultas.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultas.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultas.OptionsPrint.PrintFooter = False
        Me.GVConsultas.OptionsPrint.PrintHeader = False
        Me.GVConsultas.OptionsView.ColumnAutoWidth = False
        Me.GVConsultas.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultas.OptionsView.ShowFooter = True
        Me.GVConsultas.OptionsView.ShowGroupPanel = False
        '
        'colCFactura
        '
        Me.colCFactura.Caption = "FACTURA"
        Me.colCFactura.FieldName = "FACTURA"
        Me.colCFactura.Name = "colCFactura"
        Me.colCFactura.Visible = True
        Me.colCFactura.VisibleIndex = 0
        Me.colCFactura.Width = 61
        '
        'colCPrestador
        '
        Me.colCPrestador.Caption = "PRESTADOR"
        Me.colCPrestador.FieldName = "PRESTADOR"
        Me.colCPrestador.Name = "colCPrestador"
        Me.colCPrestador.Visible = True
        Me.colCPrestador.VisibleIndex = 1
        Me.colCPrestador.Width = 98
        '
        'colCTipo
        '
        Me.colCTipo.Caption = "TIPO"
        Me.colCTipo.FieldName = "TIPO"
        Me.colCTipo.Name = "colCTipo"
        Me.colCTipo.Visible = True
        Me.colCTipo.VisibleIndex = 2
        Me.colCTipo.Width = 36
        '
        'colCIdentificacion
        '
        Me.colCIdentificacion.Caption = "IDENTIFICACION"
        Me.colCIdentificacion.FieldName = "IDENTIFICACION"
        Me.colCIdentificacion.Name = "colCIdentificacion"
        Me.colCIdentificacion.Visible = True
        Me.colCIdentificacion.VisibleIndex = 3
        Me.colCIdentificacion.Width = 108
        '
        'colCFecha
        '
        Me.colCFecha.Caption = "FECHA"
        Me.colCFecha.FieldName = "FECHA"
        Me.colCFecha.Name = "colCFecha"
        Me.colCFecha.Visible = True
        Me.colCFecha.VisibleIndex = 4
        Me.colCFecha.Width = 61
        '
        'colCAutorizacion
        '
        Me.colCAutorizacion.Caption = "AUTORIZACION"
        Me.colCAutorizacion.FieldName = "AUTORIZACION"
        Me.colCAutorizacion.Name = "colCAutorizacion"
        Me.colCAutorizacion.Visible = True
        Me.colCAutorizacion.VisibleIndex = 5
        Me.colCAutorizacion.Width = 88
        '
        'colCCodigo
        '
        Me.colCCodigo.Caption = "CODIGO"
        Me.colCCodigo.FieldName = "CODIGO"
        Me.colCCodigo.Name = "colCCodigo"
        Me.colCCodigo.Visible = True
        Me.colCCodigo.VisibleIndex = 6
        Me.colCCodigo.Width = 53
        '
        'colCFinalidad
        '
        Me.colCFinalidad.Caption = "FINALIDAD"
        Me.colCFinalidad.FieldName = "FINALIDAD"
        Me.colCFinalidad.Name = "colCFinalidad"
        Me.colCFinalidad.Visible = True
        Me.colCFinalidad.VisibleIndex = 7
        Me.colCFinalidad.Width = 64
        '
        'colCCausa
        '
        Me.colCCausa.Caption = "CAUSA"
        Me.colCCausa.FieldName = "CAUSA"
        Me.colCCausa.Name = "colCCausa"
        Me.colCCausa.Visible = True
        Me.colCCausa.VisibleIndex = 8
        Me.colCCausa.Width = 47
        '
        'colCCIE10
        '
        Me.colCCIE10.Caption = "D1"
        Me.colCCIE10.FieldName = "CIE10"
        Me.colCCIE10.Name = "colCCIE10"
        Me.colCCIE10.Visible = True
        Me.colCCIE10.VisibleIndex = 9
        Me.colCCIE10.Width = 43
        '
        'colCD1
        '
        Me.colCD1.Caption = "D2"
        Me.colCD1.FieldName = "D1"
        Me.colCD1.Name = "colCD1"
        Me.colCD1.Visible = True
        Me.colCD1.VisibleIndex = 10
        Me.colCD1.Width = 44
        '
        'colCD2
        '
        Me.colCD2.Caption = "D3"
        Me.colCD2.FieldName = "D2"
        Me.colCD2.Name = "colCD2"
        Me.colCD2.Visible = True
        Me.colCD2.VisibleIndex = 11
        Me.colCD2.Width = 41
        '
        'colCD3
        '
        Me.colCD3.Caption = "D4"
        Me.colCD3.FieldName = "D3"
        Me.colCD3.Name = "colCD3"
        Me.colCD3.Visible = True
        Me.colCD3.VisibleIndex = 12
        Me.colCD3.Width = 45
        '
        'colCTipoDiagnostico
        '
        Me.colCTipoDiagnostico.Caption = "TIPO DIAG"
        Me.colCTipoDiagnostico.FieldName = "ID_TIPO_DIAGNOSTICO"
        Me.colCTipoDiagnostico.Name = "colCTipoDiagnostico"
        Me.colCTipoDiagnostico.Visible = True
        Me.colCTipoDiagnostico.VisibleIndex = 13
        Me.colCTipoDiagnostico.Width = 67
        '
        'colCValor
        '
        Me.colCValor.Caption = "VALOR"
        Me.colCValor.FieldName = "VALOR"
        Me.colCValor.Name = "colCValor"
        Me.colCValor.Visible = True
        Me.colCValor.VisibleIndex = 14
        '
        'colCCopago
        '
        Me.colCCopago.Caption = "COPAGO"
        Me.colCCopago.FieldName = "COPAGO"
        Me.colCCopago.Name = "colCCopago"
        Me.colCCopago.Visible = True
        Me.colCCopago.VisibleIndex = 15
        '
        'colCNeto
        '
        Me.colCNeto.Caption = "NETO"
        Me.colCNeto.FieldName = "NETO"
        Me.colCNeto.Name = "colCNeto"
        Me.colCNeto.Visible = True
        Me.colCNeto.VisibleIndex = 16
        '
        'xtpProcedimientos
        '
        Me.xtpProcedimientos.Controls.Add(Me.GCProcedimientos)
        Me.xtpProcedimientos.Name = "xtpProcedimientos"
        Me.xtpProcedimientos.Size = New System.Drawing.Size(1071, 301)
        Me.xtpProcedimientos.Text = "PROCEDIMIENTOS"
        '
        'GCProcedimientos
        '
        Me.GCProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProcedimientos.Location = New System.Drawing.Point(0, 0)
        Me.GCProcedimientos.MainView = Me.GVProcedimientos
        Me.GCProcedimientos.Name = "GCProcedimientos"
        Me.GCProcedimientos.Size = New System.Drawing.Size(1071, 301)
        Me.GCProcedimientos.TabIndex = 3
        Me.GCProcedimientos.UseEmbeddedNavigator = True
        Me.GCProcedimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProcedimientos})
        '
        'GVProcedimientos
        '
        Me.GVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPFactura, Me.colPPrestador, Me.colPTipo, Me.colPIdentificacion, Me.colPFecha, Me.colPAutorizacion, Me.colPCodigo, Me.colPAmbito, Me.colPFinalidad, Me.colPAtiende, Me.colPCie10, Me.colPD1, Me.colPD2, Me.colPRealizacion, Me.colPNeto})
        Me.GVProcedimientos.GridControl = Me.GCProcedimientos
        Me.GVProcedimientos.Name = "GVProcedimientos"
        Me.GVProcedimientos.OptionsBehavior.Editable = False
        Me.GVProcedimientos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVProcedimientos.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVProcedimientos.OptionsPrint.ExpandAllDetails = True
        Me.GVProcedimientos.OptionsPrint.ExpandAllGroups = False
        Me.GVProcedimientos.OptionsPrint.PrintFooter = False
        Me.GVProcedimientos.OptionsView.ColumnAutoWidth = False
        Me.GVProcedimientos.OptionsView.EnableAppearanceOddRow = True
        Me.GVProcedimientos.OptionsView.ShowFooter = True
        Me.GVProcedimientos.OptionsView.ShowGroupPanel = False
        '
        'colPFactura
        '
        Me.colPFactura.Caption = "FACTURA"
        Me.colPFactura.FieldName = "FACTURA"
        Me.colPFactura.Name = "colPFactura"
        Me.colPFactura.Visible = True
        Me.colPFactura.VisibleIndex = 0
        Me.colPFactura.Width = 56
        '
        'colPPrestador
        '
        Me.colPPrestador.Caption = "PRESTADOR"
        Me.colPPrestador.FieldName = "PRESTADOR"
        Me.colPPrestador.Name = "colPPrestador"
        Me.colPPrestador.Visible = True
        Me.colPPrestador.VisibleIndex = 1
        Me.colPPrestador.Width = 93
        '
        'colPTipo
        '
        Me.colPTipo.Caption = "TIPO"
        Me.colPTipo.FieldName = "TIPO"
        Me.colPTipo.Name = "colPTipo"
        Me.colPTipo.Visible = True
        Me.colPTipo.VisibleIndex = 2
        Me.colPTipo.Width = 34
        '
        'colPIdentificacion
        '
        Me.colPIdentificacion.Caption = "IDENTIFICACION"
        Me.colPIdentificacion.FieldName = "IDENTIFICACION"
        Me.colPIdentificacion.Name = "colPIdentificacion"
        Me.colPIdentificacion.Visible = True
        Me.colPIdentificacion.VisibleIndex = 3
        Me.colPIdentificacion.Width = 104
        '
        'colPFecha
        '
        Me.colPFecha.Caption = "FECHA"
        Me.colPFecha.FieldName = "FECHA"
        Me.colPFecha.Name = "colPFecha"
        Me.colPFecha.Visible = True
        Me.colPFecha.VisibleIndex = 4
        Me.colPFecha.Width = 59
        '
        'colPAutorizacion
        '
        Me.colPAutorizacion.Caption = "AUTORIZACION"
        Me.colPAutorizacion.FieldName = "AUTORIZACION"
        Me.colPAutorizacion.Name = "colPAutorizacion"
        Me.colPAutorizacion.Visible = True
        Me.colPAutorizacion.VisibleIndex = 5
        Me.colPAutorizacion.Width = 111
        '
        'colPCodigo
        '
        Me.colPCodigo.Caption = "CODIGO"
        Me.colPCodigo.FieldName = "CODIGO"
        Me.colPCodigo.Name = "colPCodigo"
        Me.colPCodigo.Visible = True
        Me.colPCodigo.VisibleIndex = 6
        Me.colPCodigo.Width = 52
        '
        'colPAmbito
        '
        Me.colPAmbito.Caption = "AMBITO"
        Me.colPAmbito.FieldName = "AMBITO"
        Me.colPAmbito.Name = "colPAmbito"
        Me.colPAmbito.Visible = True
        Me.colPAmbito.VisibleIndex = 7
        Me.colPAmbito.Width = 42
        '
        'colPFinalidad
        '
        Me.colPFinalidad.Caption = "FINALIDAD"
        Me.colPFinalidad.FieldName = "FINALIDAD"
        Me.colPFinalidad.Name = "colPFinalidad"
        Me.colPFinalidad.Visible = True
        Me.colPFinalidad.VisibleIndex = 8
        Me.colPFinalidad.Width = 71
        '
        'colPAtiende
        '
        Me.colPAtiende.Caption = "ATIENDE"
        Me.colPAtiende.FieldName = "ATIENDE"
        Me.colPAtiende.Name = "colPAtiende"
        Me.colPAtiende.Visible = True
        Me.colPAtiende.VisibleIndex = 9
        Me.colPAtiende.Width = 51
        '
        'colPCie10
        '
        Me.colPCie10.Caption = "D1"
        Me.colPCie10.FieldName = "CIE10"
        Me.colPCie10.Name = "colPCie10"
        Me.colPCie10.Visible = True
        Me.colPCie10.VisibleIndex = 10
        Me.colPCie10.Width = 40
        '
        'colPD1
        '
        Me.colPD1.Caption = "D2"
        Me.colPD1.FieldName = "D1"
        Me.colPD1.Name = "colPD1"
        Me.colPD1.Visible = True
        Me.colPD1.VisibleIndex = 11
        Me.colPD1.Width = 36
        '
        'colPD2
        '
        Me.colPD2.Caption = "D3"
        Me.colPD2.FieldName = "D2"
        Me.colPD2.Name = "colPD2"
        Me.colPD2.Visible = True
        Me.colPD2.VisibleIndex = 12
        Me.colPD2.Width = 40
        '
        'colPRealizacion
        '
        Me.colPRealizacion.Caption = "REALIZACION"
        Me.colPRealizacion.FieldName = "REALIZACION"
        Me.colPRealizacion.Name = "colPRealizacion"
        Me.colPRealizacion.Visible = True
        Me.colPRealizacion.VisibleIndex = 13
        Me.colPRealizacion.Width = 88
        '
        'colPNeto
        '
        Me.colPNeto.Caption = "NETO"
        Me.colPNeto.FieldName = "NETO"
        Me.colPNeto.Name = "colPNeto"
        Me.colPNeto.Visible = True
        Me.colPNeto.VisibleIndex = 14
        Me.colPNeto.Width = 101
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1101, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiFacturas})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rcboFacturas})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bbiFacturas, "", False, True, True, 101)})
        Me.Bar2.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Generar RIPS"
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Enabled = False
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
        'bbiFacturas
        '
        Me.bbiFacturas.Caption = "Seleccionar Factura"
        Me.bbiFacturas.Edit = Me.rcboFacturas
        Me.bbiFacturas.Id = 5
        Me.bbiFacturas.Name = "bbiFacturas"
        '
        'rcboFacturas
        '
        Me.rcboFacturas.AutoHeight = False
        Me.rcboFacturas.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rcboFacturas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcboFacturas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FACTURA", "FACTURA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTRATO", "CONTRATO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONCEPTO", "CONCEPTO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VALOR", "VALOR"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COPAGOS", "COPAGOS"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NETO", "NETO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTADO", "ESTADO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.rcboFacturas.Name = "rcboFacturas"
        Me.rcboFacturas.NullText = ""
        Me.rcboFacturas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(1101, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 378)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1101, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 347)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1101, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 347)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'frmRips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 378)
        Me.Controls.Add(Me.xtcReporteEstudio)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Rips"
        CType(Me.xtcReporteEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcReporteEstudio.ResumeLayout(False)
        Me.xtpUsuarios.ResumeLayout(False)
        CType(Me.GCUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFacturas.ResumeLayout(False)
        CType(Me.GCFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpConsultas.ResumeLayout(False)
        CType(Me.GCConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpProcedimientos.ResumeLayout(False)
        CType(Me.GCProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcboFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xtcReporteEstudio As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsuarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpFacturas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpConsultas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpProcedimientos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCConsultas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCProcedimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUTipoIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUCodigoEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUCodigoTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPrimerApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSegundoApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPrimerNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSegundoNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPrestador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFechaFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFechaFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCodigoEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPrestador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFinalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCausa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCIE10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTipoDiagnostico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPPrestador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAmbito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPFinalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAtiende As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPCie10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRealizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiFacturas As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rcboFacturas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class

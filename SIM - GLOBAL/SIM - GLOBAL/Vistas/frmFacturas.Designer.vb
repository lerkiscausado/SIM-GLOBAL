<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturas))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bFacturas = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiImprimir = New DevExpress.XtraBars.BarSubItem()
        Me.bbiFacturaConcepto = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRelacionFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetalleFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRips = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarFacturasRips = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarFacturaRips = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAgregarFacturaRips = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAgregarFacturasRips = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cboFactura = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bbiVistaPrevia = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFacturaAgregarTodo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFacturaBorrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.gvConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFacturas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFContratoFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFNEtoFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFGenerada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPOFACTURA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFPEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtcFactura = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpFacturasGeneradas = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpDetalleFactura = New DevExpress.XtraTab.XtraTabPage()
        Me.GCDetalleFactura = New DevExpress.XtraGrid.GridControl()
        Me.GVDetalleFactura = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDFFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFFechaFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFFechaOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFProcedimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFCodigoCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFNombreCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDFNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpFacturaServicios = New DevExpress.XtraTab.XtraTabPage()
        Me.btnAgregarTodo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarTodo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtNit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEntidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GCOrdenesAuditadas = New DevExpress.XtraGrid.GridControl()
        Me.GVOrdenesAuditadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSECUTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESPECIMEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUBENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOPAGO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GCListadoFactura = New DevExpress.XtraGrid.GridControl()
        Me.GVListadoFactura = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLFID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFEspecimen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFSubEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLFTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalServicios = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuentoS = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalS = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIVAS = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSon = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubTotalS = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConceptoS = New DevExpress.XtraEditors.MemoEdit()
        Me.cboContrato = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaVencimientoS = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaExpedicionS = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumeroFacturaS = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpFacturaProductos = New DevExpress.XtraTab.XtraTabPage()
        Me.btnVerOrdenServicio = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSeleccionarOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl5 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtTipoDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GCCuentasClientes = New DevExpress.XtraGrid.GridControl()
        Me.gvCuentasClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GCDetallePagoDocumento = New DevExpress.XtraGrid.GridControl()
        Me.gvDetallePagoDocumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTODETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORDETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminarFormaPago = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFormaPagoValor = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregarFormaPago = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValor = New DevExpress.XtraEditors.LabelControl()
        Me.cboFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaExpedicion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuentoP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIVAP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotalP = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalP = New DevExpress.XtraEditors.TextEdit()
        Me.lblMarca = New DevExpress.XtraEditors.LabelControl()
        Me.cboCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRestaCantidad = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSumaCantidad = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorUnitarioP = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidadP = New DevExpress.XtraEditors.TextEdit()
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit()
        Me.GCDatosCliente = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosCliente = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTarifaProducto = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSonP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConceptoP = New DevExpress.XtraEditors.MemoEdit()
        Me.GCProductos = New DevExpress.XtraGrid.GridControl()
        Me.gvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDProductos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRODUCTO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRESENTACIONPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOSTOVENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINVENTARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblCodigoProducto = New DevExpress.XtraEditors.LabelControl()
        Me.cboProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvComboProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPRESENTACIONPRODUCTO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblUnidadMedida = New DevExpress.XtraEditors.LabelControl()
        Me.xtpRips = New DevExpress.XtraTab.XtraTabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.GCRips = New DevExpress.XtraGrid.GridControl()
        Me.GVRips = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFacturas = New DevExpress.XtraBars.BarEditItem()
        Me.rcboFacturas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Bar6 = New DevExpress.XtraBars.Bar()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.Bar7 = New DevExpress.XtraBars.Bar()
        Me.Bar8 = New DevExpress.XtraBars.Bar()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.CachedEjemplo1 = New SIM___GLOBAL.CachedEjemplo()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcFactura.SuspendLayout()
        Me.xtpFacturasGeneradas.SuspendLayout()
        Me.xtpDetalleFactura.SuspendLayout()
        CType(Me.GCDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFacturaServicios.SuspendLayout()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GCOrdenesAuditadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOrdenesAuditadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GCListadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalServicios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVAS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConceptoS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimientoS.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimientoS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaExpedicionS.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaExpedicionS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroFacturaS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFacturaProductos.SuspendLayout()
        CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCuentasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCuentasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDescuentoP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVAP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarifaProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSonP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConceptoP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvComboProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpRips.SuspendLayout()
        CType(Me.GCRips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRips, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcboFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileViewColumn3
        '
        Me.TileViewColumn3.Caption = "Nombres"
        Me.TileViewColumn3.FieldName = "NOMBRE"
        Me.TileViewColumn3.Name = "TileViewColumn3"
        Me.TileViewColumn3.Visible = True
        Me.TileViewColumn3.VisibleIndex = 2
        '
        'TileViewColumn5
        '
        Me.TileViewColumn5.Caption = "Telefono"
        Me.TileViewColumn5.FieldName = "TELEFONO"
        Me.TileViewColumn5.Name = "TileViewColumn5"
        Me.TileViewColumn5.Visible = True
        Me.TileViewColumn5.VisibleIndex = 4
        '
        'TileViewColumn2
        '
        Me.TileViewColumn2.Caption = "Identificacion"
        Me.TileViewColumn2.FieldName = "IDENTIFICACION"
        Me.TileViewColumn2.Name = "TileViewColumn2"
        Me.TileViewColumn2.Visible = True
        Me.TileViewColumn2.VisibleIndex = 1
        '
        'colEmail
        '
        Me.colEmail.Caption = "EMAIL"
        Me.colEmail.FieldName = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 7
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1264, 0)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(1264, 0)
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Herramientas"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bFacturas})
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiGuardar, Me.bbiImprimir, Me.bbiAnular, Me.cboFactura, Me.bbiVistaPrevia, Me.bsiImprimir, Me.bbiActualizar, Me.bbiFactura, Me.bbiDetalleFactura, Me.bbiConsultar, Me.bbiFacturaConcepto, Me.bbiRelacionFactura, Me.BarButtonItem4, Me.bbiRips, Me.bbiAgregarFacturaRips, Me.bbiFacturaAgregarTodo, Me.bbiFacturaBorrar, Me.BarStaticItem1, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.bbiEliminarFacturaRips, Me.bbiEliminarFacturasRips, Me.bbiAgregarFacturasRips})
        Me.BarManager1.MaxItemId = 28
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        '
        'bFacturas
        '
        Me.bFacturas.BarName = "Herramientas"
        Me.bFacturas.DockCol = 0
        Me.bFacturas.DockRow = 0
        Me.bFacturas.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bFacturas.FloatLocation = New System.Drawing.Point(86, 132)
        Me.bFacturas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRips, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminarFacturasRips), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminarFacturaRips), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAgregarFacturaRips), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAgregarFacturasRips)})
        Me.bFacturas.Offset = 3
        Me.bFacturas.Text = "Herramientas Facturas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nueva Factura"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar Factura"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 1
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiAnular
        '
        Me.bbiAnular.Caption = "Anular Factura"
        Me.bbiAnular.Id = 3
        Me.bbiAnular.ImageOptions.Image = CType(resources.GetObject("bbiAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAnular.Name = "bbiAnular"
        '
        'bbiActualizar
        '
        Me.bbiActualizar.Caption = "Actualizar"
        Me.bbiActualizar.Id = 7
        Me.bbiActualizar.ImageOptions.Image = CType(resources.GetObject("bbiActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActualizar.Name = "bbiActualizar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 10
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bsiImprimir
        '
        Me.bsiImprimir.Caption = "Imprimir"
        Me.bsiImprimir.Id = 6
        Me.bsiImprimir.ImageOptions.Image = CType(resources.GetObject("bsiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bsiImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFacturaConcepto), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRelacionFactura), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFactura, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetalleFactura)})
        Me.bsiImprimir.Name = "bsiImprimir"
        '
        'bbiFacturaConcepto
        '
        Me.bbiFacturaConcepto.Caption = "Factura con Concepto"
        Me.bbiFacturaConcepto.Id = 11
        Me.bbiFacturaConcepto.Name = "bbiFacturaConcepto"
        '
        'bbiRelacionFactura
        '
        Me.bbiRelacionFactura.Caption = "Relación de la Factura"
        Me.bbiRelacionFactura.Id = 12
        Me.bbiRelacionFactura.Name = "bbiRelacionFactura"
        '
        'bbiFactura
        '
        Me.bbiFactura.Caption = "Factura Resumida"
        Me.bbiFactura.Id = 8
        Me.bbiFactura.ImageOptions.Image = CType(resources.GetObject("bbiFactura.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiFactura.Name = "bbiFactura"
        '
        'bbiDetalleFactura
        '
        Me.bbiDetalleFactura.Caption = "Factura Detallada"
        Me.bbiDetalleFactura.Id = 9
        Me.bbiDetalleFactura.ImageOptions.Image = CType(resources.GetObject("bbiDetalleFactura.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDetalleFactura.Name = "bbiDetalleFactura"
        '
        'bbiRips
        '
        Me.bbiRips.Caption = "Rips"
        Me.bbiRips.Id = 14
        Me.bbiRips.Name = "bbiRips"
        '
        'bbiEliminarFacturasRips
        '
        Me.bbiEliminarFacturasRips.Caption = "Eliminar Todas las Facturas RIPS"
        Me.bbiEliminarFacturasRips.Id = 26
        Me.bbiEliminarFacturasRips.ImageOptions.Image = CType(resources.GetObject("bbiEliminarFacturasRips.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminarFacturasRips.Name = "bbiEliminarFacturasRips"
        '
        'bbiEliminarFacturaRips
        '
        Me.bbiEliminarFacturaRips.Caption = "Eliminar Factura RIPS"
        Me.bbiEliminarFacturaRips.Id = 25
        Me.bbiEliminarFacturaRips.ImageOptions.Image = CType(resources.GetObject("bbiEliminarFacturaRips.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminarFacturaRips.Name = "bbiEliminarFacturaRips"
        '
        'bbiAgregarFacturaRips
        '
        Me.bbiAgregarFacturaRips.Caption = "Agregar Factura RIPS"
        Me.bbiAgregarFacturaRips.Id = 15
        Me.bbiAgregarFacturaRips.ImageOptions.Image = CType(resources.GetObject("bbiAgregarFacturaRips.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAgregarFacturaRips.Name = "bbiAgregarFacturaRips"
        '
        'bbiAgregarFacturasRips
        '
        Me.bbiAgregarFacturasRips.Caption = "Agregar Todas las Facturas RIPS"
        Me.bbiAgregarFacturasRips.Id = 27
        Me.bbiAgregarFacturasRips.ImageOptions.Image = CType(resources.GetObject("bbiAgregarFacturasRips.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAgregarFacturasRips.Name = "bbiAgregarFacturasRips"
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Me.BarManager1
        Me.BarDockControl2.Size = New System.Drawing.Size(1264, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 594)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1264, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 570)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1264, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 570)
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 2
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'cboFactura
        '
        Me.cboFactura.Caption = "BarEditItem1"
        Me.cboFactura.Edit = Me.RepositoryItemLookUpEdit1
        Me.cboFactura.Id = 4
        Me.cboFactura.Name = "cboFactura"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'bbiVistaPrevia
        '
        Me.bbiVistaPrevia.Caption = "Imprimir"
        Me.bbiVistaPrevia.Id = 5
        Me.bbiVistaPrevia.ImageOptions.Image = CType(resources.GetObject("bbiVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiVistaPrevia.Name = "bbiVistaPrevia"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 13
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'bbiFacturaAgregarTodo
        '
        Me.bbiFacturaAgregarTodo.Caption = "Agregar todas las Facturas"
        Me.bbiFacturaAgregarTodo.Id = 16
        Me.bbiFacturaAgregarTodo.ImageOptions.Image = CType(resources.GetObject("bbiFacturaAgregarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiFacturaAgregarTodo.Name = "bbiFacturaAgregarTodo"
        '
        'bbiFacturaBorrar
        '
        Me.bbiFacturaBorrar.Caption = "Limpiar Facturas Rips"
        Me.bbiFacturaBorrar.Id = 17
        Me.bbiFacturaBorrar.ImageOptions.Image = CType(resources.GetObject("bbiFacturaBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiFacturaBorrar.Name = "bbiFacturaBorrar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Rips"
        Me.BarStaticItem1.Id = 18
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Eliminar Factura RIPS"
        Me.BarButtonItem5.Id = 19
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem6"
        Me.BarButtonItem6.Id = 20
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "BarButtonItem7"
        Me.BarButtonItem7.Id = 21
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "BarButtonItem8"
        Me.BarButtonItem8.Id = 22
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "BarButtonItem9"
        Me.BarButtonItem9.Id = 23
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "BarButtonItem10"
        Me.BarButtonItem10.Id = 24
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Herramientas"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Text = "Herramientas"
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.gvConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1262, 545)
        Me.GCConsultar.TabIndex = 14
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConsultar})
        '
        'gvConsultar
        '
        Me.gvConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFId, Me.colFFacturas, Me.colFFecha, Me.colFContratoFactura, Me.colFConcepto, Me.colFValor, Me.colFNEtoFactura, Me.colFGenerada, Me.colFEstado, Me.colTIPOFACTURA, Me.colFPDescuento, Me.colFPTelefono, Me.colFPEmail})
        Me.gvConsultar.GridControl = Me.GCConsultar
        Me.gvConsultar.Name = "gvConsultar"
        Me.gvConsultar.OptionsBehavior.Editable = False
        Me.gvConsultar.OptionsBehavior.ReadOnly = True
        Me.gvConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.gvConsultar.OptionsView.ShowFooter = True
        Me.gvConsultar.OptionsView.ShowGroupPanel = False
        Me.gvConsultar.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFFacturas, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colFId
        '
        Me.colFId.Caption = "ID"
        Me.colFId.FieldName = "ID"
        Me.colFId.Name = "colFId"
        Me.colFId.Width = 48
        '
        'colFFacturas
        '
        Me.colFFacturas.Caption = "FACTURA"
        Me.colFFacturas.FieldName = "FACTURA"
        Me.colFFacturas.Name = "colFFacturas"
        Me.colFFacturas.Visible = True
        Me.colFFacturas.VisibleIndex = 0
        Me.colFFacturas.Width = 74
        '
        'colFFecha
        '
        Me.colFFecha.Caption = "FECHA"
        Me.colFFecha.FieldName = "FECHA"
        Me.colFFecha.Name = "colFFecha"
        Me.colFFecha.Visible = True
        Me.colFFecha.VisibleIndex = 1
        '
        'colFContratoFactura
        '
        Me.colFContratoFactura.Caption = "CLIENTES "
        Me.colFContratoFactura.FieldName = "CONTRATO"
        Me.colFContratoFactura.Name = "colFContratoFactura"
        Me.colFContratoFactura.Visible = True
        Me.colFContratoFactura.VisibleIndex = 2
        Me.colFContratoFactura.Width = 190
        '
        'colFConcepto
        '
        Me.colFConcepto.Caption = "CONCEPTO"
        Me.colFConcepto.FieldName = "CONCEPTO"
        Me.colFConcepto.Name = "colFConcepto"
        Me.colFConcepto.Visible = True
        Me.colFConcepto.VisibleIndex = 5
        Me.colFConcepto.Width = 178
        '
        'colFValor
        '
        Me.colFValor.Caption = "VALOR"
        Me.colFValor.DisplayFormat.FormatString = "{0:C0}"
        Me.colFValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFValor.FieldName = "VALOR"
        Me.colFValor.Name = "colFValor"
        Me.colFValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colFValor.Visible = True
        Me.colFValor.VisibleIndex = 6
        '
        'colFNEtoFactura
        '
        Me.colFNEtoFactura.Caption = "NETO"
        Me.colFNEtoFactura.DisplayFormat.FormatString = "{0:C0}"
        Me.colFNEtoFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFNEtoFactura.FieldName = "NETO"
        Me.colFNEtoFactura.Name = "colFNEtoFactura"
        Me.colFNEtoFactura.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "{0:C0}")})
        Me.colFNEtoFactura.Visible = True
        Me.colFNEtoFactura.VisibleIndex = 8
        '
        'colFGenerada
        '
        Me.colFGenerada.Caption = "GENERADA"
        Me.colFGenerada.FieldName = "GENERADA"
        Me.colFGenerada.Name = "colFGenerada"
        Me.colFGenerada.Visible = True
        Me.colFGenerada.VisibleIndex = 9
        Me.colFGenerada.Width = 107
        '
        'colFEstado
        '
        Me.colFEstado.Caption = "ESTADO"
        Me.colFEstado.FieldName = "ESTADO"
        Me.colFEstado.Name = "colFEstado"
        Me.colFEstado.Visible = True
        Me.colFEstado.VisibleIndex = 10
        '
        'colTIPOFACTURA
        '
        Me.colTIPOFACTURA.Caption = "TIPOFACTURA"
        Me.colTIPOFACTURA.FieldName = "TIPOFACTURA"
        Me.colTIPOFACTURA.Name = "colTIPOFACTURA"
        Me.colTIPOFACTURA.Visible = True
        Me.colTIPOFACTURA.VisibleIndex = 11
        '
        'colFPDescuento
        '
        Me.colFPDescuento.Caption = "DESCUENTO"
        Me.colFPDescuento.DisplayFormat.FormatString = "C0"
        Me.colFPDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFPDescuento.FieldName = "DESCUENTO"
        Me.colFPDescuento.Name = "colFPDescuento"
        Me.colFPDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DESCUENTO", "{0:C0}")})
        Me.colFPDescuento.Visible = True
        Me.colFPDescuento.VisibleIndex = 7
        '
        'colFPTelefono
        '
        Me.colFPTelefono.Caption = "TELEFONO"
        Me.colFPTelefono.FieldName = "TELEFONO"
        Me.colFPTelefono.Name = "colFPTelefono"
        Me.colFPTelefono.Visible = True
        Me.colFPTelefono.VisibleIndex = 3
        '
        'colFPEmail
        '
        Me.colFPEmail.Caption = "EMAIL"
        Me.colFPEmail.FieldName = "EMAIL"
        Me.colFPEmail.Name = "colFPEmail"
        Me.colFPEmail.Visible = True
        Me.colFPEmail.VisibleIndex = 4
        Me.colFPEmail.Width = 163
        '
        'xtcFactura
        '
        Me.xtcFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcFactura.Location = New System.Drawing.Point(0, 24)
        Me.xtcFactura.Name = "xtcFactura"
        Me.xtcFactura.SelectedTabPage = Me.xtpFacturasGeneradas
        Me.xtcFactura.Size = New System.Drawing.Size(1264, 570)
        Me.xtcFactura.TabIndex = 82
        Me.xtcFactura.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpFacturasGeneradas, Me.xtpDetalleFactura, Me.xtpFacturaServicios, Me.xtpFacturaProductos, Me.xtpRips})
        '
        'xtpFacturasGeneradas
        '
        Me.xtpFacturasGeneradas.Controls.Add(Me.GCConsultar)
        Me.xtpFacturasGeneradas.Name = "xtpFacturasGeneradas"
        Me.xtpFacturasGeneradas.Size = New System.Drawing.Size(1262, 545)
        Me.xtpFacturasGeneradas.Text = "Facturas Generadas"
        '
        'xtpDetalleFactura
        '
        Me.xtpDetalleFactura.Controls.Add(Me.GCDetalleFactura)
        Me.xtpDetalleFactura.Name = "xtpDetalleFactura"
        Me.xtpDetalleFactura.Size = New System.Drawing.Size(1262, 544)
        Me.xtpDetalleFactura.Text = "Detalle de Factura"
        '
        'GCDetalleFactura
        '
        Me.GCDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDetalleFactura.Location = New System.Drawing.Point(0, 0)
        Me.GCDetalleFactura.MainView = Me.GVDetalleFactura
        Me.GCDetalleFactura.Name = "GCDetalleFactura"
        Me.GCDetalleFactura.Size = New System.Drawing.Size(1262, 544)
        Me.GCDetalleFactura.TabIndex = 15
        Me.GCDetalleFactura.UseEmbeddedNavigator = True
        Me.GCDetalleFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetalleFactura})
        '
        'GVDetalleFactura
        '
        Me.GVDetalleFactura.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDFFactura, Me.colDFFechaFactura, Me.colDFContrato, Me.colDFOrden, Me.colDFFechaOrden, Me.colDFIdentificacion, Me.colDFNombre, Me.colDFAutorizacion, Me.colDFProcedimiento, Me.colDFCodigoCups, Me.colDFNombreCups, Me.colDFValor, Me.colDFCopago, Me.colDFNeto})
        Me.GVDetalleFactura.GridControl = Me.GCDetalleFactura
        Me.GVDetalleFactura.Name = "GVDetalleFactura"
        Me.GVDetalleFactura.OptionsBehavior.Editable = False
        Me.GVDetalleFactura.OptionsBehavior.ReadOnly = True
        Me.GVDetalleFactura.OptionsView.ColumnAutoWidth = False
        Me.GVDetalleFactura.OptionsView.EnableAppearanceOddRow = True
        Me.GVDetalleFactura.OptionsView.ShowFooter = True
        Me.GVDetalleFactura.OptionsView.ShowGroupPanel = False
        '
        'ColDFFactura
        '
        Me.ColDFFactura.Caption = "FACTURA"
        Me.ColDFFactura.FieldName = "FACTURA"
        Me.ColDFFactura.Name = "ColDFFactura"
        Me.ColDFFactura.Visible = True
        Me.ColDFFactura.VisibleIndex = 0
        Me.ColDFFactura.Width = 58
        '
        'colDFFechaFactura
        '
        Me.colDFFechaFactura.Caption = "FECHA FACTURA"
        Me.colDFFechaFactura.FieldName = "FECHA_FACTURA"
        Me.colDFFechaFactura.Name = "colDFFechaFactura"
        Me.colDFFechaFactura.Visible = True
        Me.colDFFechaFactura.VisibleIndex = 1
        Me.colDFFechaFactura.Width = 92
        '
        'colDFContrato
        '
        Me.colDFContrato.Caption = "CONTRATO"
        Me.colDFContrato.FieldName = "CONTRATO"
        Me.colDFContrato.Name = "colDFContrato"
        Me.colDFContrato.Visible = True
        Me.colDFContrato.VisibleIndex = 2
        Me.colDFContrato.Width = 199
        '
        'colDFOrden
        '
        Me.colDFOrden.Caption = "ORDEN"
        Me.colDFOrden.FieldName = "ORDEN"
        Me.colDFOrden.Name = "colDFOrden"
        Me.colDFOrden.Visible = True
        Me.colDFOrden.VisibleIndex = 3
        Me.colDFOrden.Width = 66
        '
        'colDFFechaOrden
        '
        Me.colDFFechaOrden.Caption = "FECHA ORDEN"
        Me.colDFFechaOrden.FieldName = "FECHA_INGRESO"
        Me.colDFFechaOrden.Name = "colDFFechaOrden"
        Me.colDFFechaOrden.Visible = True
        Me.colDFFechaOrden.VisibleIndex = 4
        Me.colDFFechaOrden.Width = 84
        '
        'colDFIdentificacion
        '
        Me.colDFIdentificacion.Caption = "IDENTIFICACION"
        Me.colDFIdentificacion.FieldName = "IDENTIFICACION"
        Me.colDFIdentificacion.Name = "colDFIdentificacion"
        Me.colDFIdentificacion.Visible = True
        Me.colDFIdentificacion.VisibleIndex = 5
        Me.colDFIdentificacion.Width = 97
        '
        'colDFNombre
        '
        Me.colDFNombre.Caption = "NOMBRE"
        Me.colDFNombre.FieldName = "NOMBRE"
        Me.colDFNombre.Name = "colDFNombre"
        Me.colDFNombre.Visible = True
        Me.colDFNombre.VisibleIndex = 6
        Me.colDFNombre.Width = 208
        '
        'colDFAutorizacion
        '
        Me.colDFAutorizacion.Caption = "AUTORIZACION"
        Me.colDFAutorizacion.FieldName = "AUTORIZACION"
        Me.colDFAutorizacion.Name = "colDFAutorizacion"
        Me.colDFAutorizacion.Visible = True
        Me.colDFAutorizacion.VisibleIndex = 7
        Me.colDFAutorizacion.Width = 95
        '
        'colDFProcedimiento
        '
        Me.colDFProcedimiento.Caption = "PROCEDIMIENTO"
        Me.colDFProcedimiento.FieldName = "CODIGO_PROCEDIMIENTO"
        Me.colDFProcedimiento.Name = "colDFProcedimiento"
        Me.colDFProcedimiento.Visible = True
        Me.colDFProcedimiento.VisibleIndex = 8
        Me.colDFProcedimiento.Width = 92
        '
        'colDFCodigoCups
        '
        Me.colDFCodigoCups.Caption = "CUPS"
        Me.colDFCodigoCups.FieldName = "CODIGO_CUPS"
        Me.colDFCodigoCups.Name = "colDFCodigoCups"
        Me.colDFCodigoCups.Visible = True
        Me.colDFCodigoCups.VisibleIndex = 9
        Me.colDFCodigoCups.Width = 55
        '
        'colDFNombreCups
        '
        Me.colDFNombreCups.Caption = "NOMBRE CUPS"
        Me.colDFNombreCups.FieldName = "NOMBRE_CUPS"
        Me.colDFNombreCups.Name = "colDFNombreCups"
        Me.colDFNombreCups.Visible = True
        Me.colDFNombreCups.VisibleIndex = 10
        Me.colDFNombreCups.Width = 245
        '
        'colDFValor
        '
        Me.colDFValor.Caption = "VALOR"
        Me.colDFValor.DisplayFormat.FormatString = "{0:C0}"
        Me.colDFValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDFValor.FieldName = "VALOR"
        Me.colDFValor.Name = "colDFValor"
        Me.colDFValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colDFValor.Visible = True
        Me.colDFValor.VisibleIndex = 11
        '
        'colDFCopago
        '
        Me.colDFCopago.Caption = "COPAGO"
        Me.colDFCopago.DisplayFormat.FormatString = "{0:C0}"
        Me.colDFCopago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDFCopago.FieldName = "COPAGO"
        Me.colDFCopago.Name = "colDFCopago"
        Me.colDFCopago.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COPAGO", "{0:C0}")})
        Me.colDFCopago.Visible = True
        Me.colDFCopago.VisibleIndex = 12
        '
        'colDFNeto
        '
        Me.colDFNeto.Caption = "NETO"
        Me.colDFNeto.DisplayFormat.FormatString = "{0:C0}"
        Me.colDFNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDFNeto.FieldName = "NETO"
        Me.colDFNeto.Name = "colDFNeto"
        Me.colDFNeto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "{0:C0}")})
        Me.colDFNeto.Visible = True
        Me.colDFNeto.VisibleIndex = 13
        '
        'xtpFacturaServicios
        '
        Me.xtpFacturaServicios.Controls.Add(Me.btnAgregarTodo)
        Me.xtpFacturaServicios.Controls.Add(Me.btnEliminarTodo)
        Me.xtpFacturaServicios.Controls.Add(Me.btnAgregarOrden)
        Me.xtpFacturaServicios.Controls.Add(Me.btnEliminarOrden)
        Me.xtpFacturaServicios.Controls.Add(Me.SeparatorControl3)
        Me.xtpFacturaServicios.Controls.Add(Me.txtNit)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl28)
        Me.xtpFacturaServicios.Controls.Add(Me.txtTelefono)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl27)
        Me.xtpFacturaServicios.Controls.Add(Me.txtDireccion)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl26)
        Me.xtpFacturaServicios.Controls.Add(Me.txtEntidad)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl33)
        Me.xtpFacturaServicios.Controls.Add(Me.XtraTabControl1)
        Me.xtpFacturaServicios.Controls.Add(Me.cboContrato)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl17)
        Me.xtpFacturaServicios.Controls.Add(Me.dtFechaVencimientoS)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl3)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl2)
        Me.xtpFacturaServicios.Controls.Add(Me.dtFechaExpedicionS)
        Me.xtpFacturaServicios.Controls.Add(Me.txtNumeroFacturaS)
        Me.xtpFacturaServicios.Controls.Add(Me.LabelControl1)
        Me.xtpFacturaServicios.Name = "xtpFacturaServicios"
        Me.xtpFacturaServicios.Size = New System.Drawing.Size(1262, 544)
        Me.xtpFacturaServicios.Text = "Facturar Servicios"
        '
        'btnAgregarTodo
        '
        Me.btnAgregarTodo.ImageOptions.Image = CType(resources.GetObject("btnAgregarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarTodo.Location = New System.Drawing.Point(99, 103)
        Me.btnAgregarTodo.Name = "btnAgregarTodo"
        Me.btnAgregarTodo.Size = New System.Drawing.Size(23, 23)
        Me.btnAgregarTodo.TabIndex = 234
        Me.btnAgregarTodo.Text = "Agregar Todas las Ordenes"
        '
        'btnEliminarTodo
        '
        Me.btnEliminarTodo.ImageOptions.Image = CType(resources.GetObject("btnEliminarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarTodo.Location = New System.Drawing.Point(12, 103)
        Me.btnEliminarTodo.Name = "btnEliminarTodo"
        Me.btnEliminarTodo.Size = New System.Drawing.Size(23, 23)
        Me.btnEliminarTodo.TabIndex = 233
        Me.btnEliminarTodo.Text = "Eliminar Todas las Ordenes"
        '
        'btnAgregarOrden
        '
        Me.btnAgregarOrden.ImageOptions.Image = CType(resources.GetObject("btnAgregarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarOrden.Location = New System.Drawing.Point(70, 103)
        Me.btnAgregarOrden.Name = "btnAgregarOrden"
        Me.btnAgregarOrden.Size = New System.Drawing.Size(23, 23)
        Me.btnAgregarOrden.TabIndex = 232
        Me.btnAgregarOrden.Text = "Agregar Orden"
        '
        'btnEliminarOrden
        '
        Me.btnEliminarOrden.ImageOptions.Image = CType(resources.GetObject("btnEliminarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarOrden.Location = New System.Drawing.Point(41, 103)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(23, 23)
        Me.btnEliminarOrden.TabIndex = 231
        Me.btnEliminarOrden.Text = "Eliminar Orden"
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.AutoSizeMode = True
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(777, 10)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(19, 130)
        Me.SeparatorControl3.TabIndex = 230
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(12, 76)
        Me.txtNit.MenuManager = Me.BarManager1
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNit.Properties.Appearance.Options.UseBackColor = True
        Me.txtNit.Properties.ReadOnly = True
        Me.txtNit.Size = New System.Drawing.Size(126, 20)
        Me.txtNit.TabIndex = 228
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl28.TabIndex = 229
        Me.LabelControl28.Text = "Nit:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(143, 77)
        Me.txtTelefono.MenuManager = Me.BarManager1
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTelefono.Properties.Appearance.Options.UseBackColor = True
        Me.txtTelefono.Properties.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(245, 20)
        Me.txtTelefono.TabIndex = 226
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(143, 56)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl27.TabIndex = 227
        Me.LabelControl27.Text = "Telefono:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(394, 76)
        Me.txtDireccion.MenuManager = Me.BarManager1
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDireccion.Properties.Appearance.Options.UseBackColor = True
        Me.txtDireccion.Properties.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(377, 20)
        Me.txtDireccion.TabIndex = 224
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(394, 57)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl26.TabIndex = 225
        Me.LabelControl26.Text = "Direccion:"
        '
        'txtEntidad
        '
        Me.txtEntidad.Location = New System.Drawing.Point(394, 26)
        Me.txtEntidad.MenuManager = Me.BarManager1
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtEntidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtEntidad.Properties.ReadOnly = True
        Me.txtEntidad.Size = New System.Drawing.Size(377, 20)
        Me.txtEntidad.TabIndex = 222
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(394, 10)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl33.TabIndex = 223
        Me.LabelControl33.Text = "Cliente o Entidad:"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl1.Location = New System.Drawing.Point(11, 132)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1162, 417)
        Me.XtraTabControl1.TabIndex = 77
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GCOrdenesAuditadas)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1160, 392)
        Me.XtraTabPage1.Text = "Ordenes Auditadas"
        '
        'GCOrdenesAuditadas
        '
        Me.GCOrdenesAuditadas.Location = New System.Drawing.Point(6, 32)
        Me.GCOrdenesAuditadas.MainView = Me.GVOrdenesAuditadas
        Me.GCOrdenesAuditadas.Name = "GCOrdenesAuditadas"
        Me.GCOrdenesAuditadas.Size = New System.Drawing.Size(1136, 247)
        Me.GCOrdenesAuditadas.TabIndex = 227
        Me.GCOrdenesAuditadas.UseEmbeddedNavigator = True
        Me.GCOrdenesAuditadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOrdenesAuditadas})
        '
        'GVOrdenesAuditadas
        '
        Me.GVOrdenesAuditadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colORDEN2, Me.colCONSECUTIVO, Me.colFECHA, Me.colIDENTIFICACION, Me.colUSUARIO, Me.colESTUDIO, Me.colESPECIMEN, Me.colSUBENTIDAD, Me.colVALOR2, Me.colCOPAGO2, Me.colNETO2, Me.colTipoUsuario})
        Me.GVOrdenesAuditadas.GridControl = Me.GCOrdenesAuditadas
        Me.GVOrdenesAuditadas.Name = "GVOrdenesAuditadas"
        Me.GVOrdenesAuditadas.OptionsBehavior.Editable = False
        Me.GVOrdenesAuditadas.OptionsView.ColumnAutoWidth = False
        Me.GVOrdenesAuditadas.OptionsView.EnableAppearanceOddRow = True
        Me.GVOrdenesAuditadas.OptionsView.ShowFooter = True
        Me.GVOrdenesAuditadas.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colORDEN2
        '
        Me.colORDEN2.Caption = "ORDEN"
        Me.colORDEN2.FieldName = "ORDEN"
        Me.colORDEN2.Name = "colORDEN2"
        Me.colORDEN2.Visible = True
        Me.colORDEN2.VisibleIndex = 0
        Me.colORDEN2.Width = 73
        '
        'colCONSECUTIVO
        '
        Me.colCONSECUTIVO.Caption = "CONSECUTIVO"
        Me.colCONSECUTIVO.FieldName = "CONSECUTIVO"
        Me.colCONSECUTIVO.Name = "colCONSECUTIVO"
        Me.colCONSECUTIVO.Visible = True
        Me.colCONSECUTIVO.VisibleIndex = 1
        Me.colCONSECUTIVO.Width = 89
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA_INGRESO"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 2
        Me.colFECHA.Width = 84
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 3
        Me.colIDENTIFICACION.Width = 130
        '
        'colUSUARIO
        '
        Me.colUSUARIO.Caption = "USUARIO"
        Me.colUSUARIO.FieldName = "NOMBRE_USUARIO"
        Me.colUSUARIO.Name = "colUSUARIO"
        Me.colUSUARIO.Visible = True
        Me.colUSUARIO.VisibleIndex = 4
        Me.colUSUARIO.Width = 195
        '
        'colESTUDIO
        '
        Me.colESTUDIO.Caption = "ESTUDIO"
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 6
        Me.colESTUDIO.Width = 170
        '
        'colESPECIMEN
        '
        Me.colESPECIMEN.Caption = "ESPECIMEN"
        Me.colESPECIMEN.FieldName = "ESPECIMEN"
        Me.colESPECIMEN.Name = "colESPECIMEN"
        Me.colESPECIMEN.Visible = True
        Me.colESPECIMEN.VisibleIndex = 7
        Me.colESPECIMEN.Width = 145
        '
        'colSUBENTIDAD
        '
        Me.colSUBENTIDAD.Caption = "SUBENTIDAD"
        Me.colSUBENTIDAD.FieldName = "SUBENTIDAD"
        Me.colSUBENTIDAD.Name = "colSUBENTIDAD"
        Me.colSUBENTIDAD.Visible = True
        Me.colSUBENTIDAD.VisibleIndex = 11
        Me.colSUBENTIDAD.Width = 119
        '
        'colVALOR2
        '
        Me.colVALOR2.Caption = "VALOR"
        Me.colVALOR2.DisplayFormat.FormatString = "{0:C0}"
        Me.colVALOR2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR2.FieldName = "VALOR"
        Me.colVALOR2.Name = "colVALOR2"
        Me.colVALOR2.Visible = True
        Me.colVALOR2.VisibleIndex = 8
        Me.colVALOR2.Width = 77
        '
        'colCOPAGO2
        '
        Me.colCOPAGO2.Caption = "COPAGO"
        Me.colCOPAGO2.DisplayFormat.FormatString = "{0:C0}"
        Me.colCOPAGO2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCOPAGO2.FieldName = "COPAGO"
        Me.colCOPAGO2.Name = "colCOPAGO2"
        Me.colCOPAGO2.Visible = True
        Me.colCOPAGO2.VisibleIndex = 9
        Me.colCOPAGO2.Width = 81
        '
        'colNETO2
        '
        Me.colNETO2.Caption = "NETO"
        Me.colNETO2.DisplayFormat.FormatString = "{0:C0}"
        Me.colNETO2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNETO2.FieldName = "NETO"
        Me.colNETO2.Name = "colNETO2"
        Me.colNETO2.Visible = True
        Me.colNETO2.VisibleIndex = 10
        '
        'colTipoUsuario
        '
        Me.colTipoUsuario.Caption = "TIPO USUARIO"
        Me.colTipoUsuario.FieldName = "TIPO_USUARIO"
        Me.colTipoUsuario.MinWidth = 22
        Me.colTipoUsuario.Name = "colTipoUsuario"
        Me.colTipoUsuario.Visible = True
        Me.colTipoUsuario.VisibleIndex = 5
        Me.colTipoUsuario.Width = 142
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GCListadoFactura)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl32)
        Me.XtraTabPage2.Controls.Add(Me.txtTotalServicios)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.txtDescuentoS)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.txtTotalS)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.txtIVAS)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.txtSon)
        Me.XtraTabPage2.Controls.Add(Me.txtSubTotalS)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtConceptoS)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1160, 392)
        Me.XtraTabPage2.Text = "Generar Factura"
        '
        'GCListadoFactura
        '
        Me.GCListadoFactura.Location = New System.Drawing.Point(6, 32)
        Me.GCListadoFactura.MainView = Me.GVListadoFactura
        Me.GCListadoFactura.Name = "GCListadoFactura"
        Me.GCListadoFactura.Size = New System.Drawing.Size(840, 247)
        Me.GCListadoFactura.TabIndex = 241
        Me.GCListadoFactura.UseEmbeddedNavigator = True
        Me.GCListadoFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListadoFactura})
        '
        'GVListadoFactura
        '
        Me.GVListadoFactura.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLFID, Me.colLFOrden, Me.colLFConsecutivo, Me.colLFFecha, Me.colLFIdentificacion, Me.colLFUsuario, Me.colLFEstudio, Me.colLFEspecimen, Me.colLFSubEntidad, Me.colLFValor, Me.colLFCopago, Me.colLFNeto, Me.colLFTipoUsuario})
        Me.GVListadoFactura.GridControl = Me.GCListadoFactura
        Me.GVListadoFactura.Name = "GVListadoFactura"
        Me.GVListadoFactura.OptionsBehavior.Editable = False
        Me.GVListadoFactura.OptionsView.ColumnAutoWidth = False
        Me.GVListadoFactura.OptionsView.EnableAppearanceOddRow = True
        Me.GVListadoFactura.OptionsView.ShowGroupPanel = False
        '
        'colLFID
        '
        Me.colLFID.Caption = "ID"
        Me.colLFID.FieldName = "ID"
        Me.colLFID.Name = "colLFID"
        '
        'colLFOrden
        '
        Me.colLFOrden.Caption = "ORDEN"
        Me.colLFOrden.FieldName = "ORDEN"
        Me.colLFOrden.Name = "colLFOrden"
        Me.colLFOrden.Visible = True
        Me.colLFOrden.VisibleIndex = 0
        Me.colLFOrden.Width = 73
        '
        'colLFConsecutivo
        '
        Me.colLFConsecutivo.Caption = "CONSECUTIVO"
        Me.colLFConsecutivo.FieldName = "CONSECUTIVO"
        Me.colLFConsecutivo.Name = "colLFConsecutivo"
        Me.colLFConsecutivo.Visible = True
        Me.colLFConsecutivo.VisibleIndex = 1
        Me.colLFConsecutivo.Width = 89
        '
        'colLFFecha
        '
        Me.colLFFecha.Caption = "FECHA"
        Me.colLFFecha.FieldName = "FECHA_INGRESO"
        Me.colLFFecha.Name = "colLFFecha"
        Me.colLFFecha.Visible = True
        Me.colLFFecha.VisibleIndex = 2
        Me.colLFFecha.Width = 84
        '
        'colLFIdentificacion
        '
        Me.colLFIdentificacion.Caption = "IDENTIFICACION"
        Me.colLFIdentificacion.FieldName = "IDENTIFICACION"
        Me.colLFIdentificacion.Name = "colLFIdentificacion"
        Me.colLFIdentificacion.Visible = True
        Me.colLFIdentificacion.VisibleIndex = 3
        Me.colLFIdentificacion.Width = 130
        '
        'colLFUsuario
        '
        Me.colLFUsuario.Caption = "USUARIO"
        Me.colLFUsuario.FieldName = "NOMBRE_USUARIO"
        Me.colLFUsuario.Name = "colLFUsuario"
        Me.colLFUsuario.Visible = True
        Me.colLFUsuario.VisibleIndex = 4
        Me.colLFUsuario.Width = 195
        '
        'colLFEstudio
        '
        Me.colLFEstudio.Caption = "ESTUDIO"
        Me.colLFEstudio.FieldName = "ESTUDIO"
        Me.colLFEstudio.Name = "colLFEstudio"
        Me.colLFEstudio.Visible = True
        Me.colLFEstudio.VisibleIndex = 6
        Me.colLFEstudio.Width = 170
        '
        'colLFEspecimen
        '
        Me.colLFEspecimen.Caption = "ESPECIMEN"
        Me.colLFEspecimen.FieldName = "ESPECIMEN"
        Me.colLFEspecimen.Name = "colLFEspecimen"
        Me.colLFEspecimen.Visible = True
        Me.colLFEspecimen.VisibleIndex = 7
        Me.colLFEspecimen.Width = 145
        '
        'colLFSubEntidad
        '
        Me.colLFSubEntidad.Caption = "SUBENTIDAD"
        Me.colLFSubEntidad.FieldName = "SUBENTIDAD"
        Me.colLFSubEntidad.Name = "colLFSubEntidad"
        Me.colLFSubEntidad.Width = 119
        '
        'colLFValor
        '
        Me.colLFValor.Caption = "VALOR"
        Me.colLFValor.DisplayFormat.FormatString = "{0:C0}"
        Me.colLFValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLFValor.FieldName = "VALOR"
        Me.colLFValor.Name = "colLFValor"
        Me.colLFValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colLFValor.Visible = True
        Me.colLFValor.VisibleIndex = 8
        Me.colLFValor.Width = 77
        '
        'colLFCopago
        '
        Me.colLFCopago.Caption = "COPAGO"
        Me.colLFCopago.DisplayFormat.FormatString = "{0:C0}"
        Me.colLFCopago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLFCopago.FieldName = "COPAGO"
        Me.colLFCopago.Name = "colLFCopago"
        Me.colLFCopago.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COPAGO", "{0:C0}")})
        Me.colLFCopago.Visible = True
        Me.colLFCopago.VisibleIndex = 9
        Me.colLFCopago.Width = 81
        '
        'colLFNeto
        '
        Me.colLFNeto.Caption = "NETO"
        Me.colLFNeto.DisplayFormat.FormatString = "{0:C0}"
        Me.colLFNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLFNeto.FieldName = "NETO"
        Me.colLFNeto.Name = "colLFNeto"
        Me.colLFNeto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "SUMA={0:C0}")})
        Me.colLFNeto.Visible = True
        Me.colLFNeto.VisibleIndex = 10
        '
        'colLFTipoUsuario
        '
        Me.colLFTipoUsuario.Caption = "TIPO USUARIO"
        Me.colLFTipoUsuario.FieldName = "TIPO_USUARIO"
        Me.colLFTipoUsuario.MinWidth = 22
        Me.colLFTipoUsuario.Name = "colLFTipoUsuario"
        Me.colLFTipoUsuario.Visible = True
        Me.colLFTipoUsuario.VisibleIndex = 5
        Me.colLFTipoUsuario.Width = 121
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Location = New System.Drawing.Point(858, 293)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(146, 19)
        Me.LabelControl32.TabIndex = 240
        Me.LabelControl32.Text = "Vr. TOTAL Fac:   $"
        '
        'txtTotalServicios
        '
        Me.txtTotalServicios.Location = New System.Drawing.Point(1010, 290)
        Me.txtTotalServicios.Name = "txtTotalServicios"
        Me.txtTotalServicios.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTotalServicios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalServicios.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTotalServicios.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalServicios.Properties.Appearance.Options.UseFont = True
        Me.txtTotalServicios.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalServicios.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtTotalServicios.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalServicios.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtTotalServicios.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalServicios.Properties.Mask.EditMask = "n0"
        Me.txtTotalServicios.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalServicios.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalServicios.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalServicios.Size = New System.Drawing.Size(143, 26)
        Me.txtTotalServicios.TabIndex = 239
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(888, 228)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(116, 19)
        Me.LabelControl7.TabIndex = 238
        Me.LabelControl7.Text = "Descuento:   $"
        '
        'txtDescuentoS
        '
        Me.txtDescuentoS.Location = New System.Drawing.Point(1010, 228)
        Me.txtDescuentoS.Name = "txtDescuentoS"
        Me.txtDescuentoS.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDescuentoS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescuentoS.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtDescuentoS.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescuentoS.Properties.Appearance.Options.UseFont = True
        Me.txtDescuentoS.Properties.Appearance.Options.UseForeColor = True
        Me.txtDescuentoS.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtDescuentoS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoS.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtDescuentoS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoS.Properties.Mask.EditMask = "n0"
        Me.txtDescuentoS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuentoS.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuentoS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoS.Size = New System.Drawing.Size(143, 26)
        Me.txtDescuentoS.TabIndex = 237
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(865, 543)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl6.TabIndex = 235
        Me.LabelControl6.Text = "Total:   $"
        '
        'txtTotalS
        '
        Me.txtTotalS.Location = New System.Drawing.Point(913, 540)
        Me.txtTotalS.Name = "txtTotalS"
        Me.txtTotalS.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTotalS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalS.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTotalS.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalS.Properties.Appearance.Options.UseFont = True
        Me.txtTotalS.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalS.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtTotalS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalS.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtTotalS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalS.Properties.Mask.EditMask = "n0"
        Me.txtTotalS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalS.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalS.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalS.TabIndex = 234
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(943, 260)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl5.TabIndex = 233
        Me.LabelControl5.Text = "IVA:   $"
        '
        'txtIVAS
        '
        Me.txtIVAS.Location = New System.Drawing.Point(1010, 260)
        Me.txtIVAS.Name = "txtIVAS"
        Me.txtIVAS.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtIVAS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIVAS.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtIVAS.Properties.Appearance.Options.UseBackColor = True
        Me.txtIVAS.Properties.Appearance.Options.UseFont = True
        Me.txtIVAS.Properties.Appearance.Options.UseForeColor = True
        Me.txtIVAS.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtIVAS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIVAS.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtIVAS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIVAS.Properties.Mask.EditMask = "n0"
        Me.txtIVAS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIVAS.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIVAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIVAS.Size = New System.Drawing.Size(143, 26)
        Me.txtIVAS.TabIndex = 232
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(6, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl4.TabIndex = 231
        Me.LabelControl4.Text = "Ordenes a Facturar"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(895, 199)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(109, 19)
        Me.LabelControl10.TabIndex = 228
        Me.LabelControl10.Text = "Sub Total:   $"
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(50, 290)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSon.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSon.Properties.Appearance.Options.UseBackColor = True
        Me.txtSon.Properties.Appearance.Options.UseFont = True
        Me.txtSon.Properties.Appearance.Options.UseForeColor = True
        Me.txtSon.Properties.ReadOnly = True
        Me.txtSon.Size = New System.Drawing.Size(797, 26)
        Me.txtSon.TabIndex = 230
        '
        'txtSubTotalS
        '
        Me.txtSubTotalS.Location = New System.Drawing.Point(1010, 196)
        Me.txtSubTotalS.Name = "txtSubTotalS"
        Me.txtSubTotalS.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubTotalS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotalS.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSubTotalS.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotalS.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotalS.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubTotalS.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtSubTotalS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotalS.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtSubTotalS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotalS.Properties.Mask.EditMask = "n0"
        Me.txtSubTotalS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotalS.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSubTotalS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubTotalS.Size = New System.Drawing.Size(143, 26)
        Me.txtSubTotalS.TabIndex = 227
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(8, 293)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl11.TabIndex = 229
        Me.LabelControl11.Text = "Son:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(853, 13)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl8.TabIndex = 224
        Me.LabelControl8.Text = "Observaciones:"
        '
        'txtConceptoS
        '
        Me.txtConceptoS.Location = New System.Drawing.Point(853, 32)
        Me.txtConceptoS.Name = "txtConceptoS"
        Me.txtConceptoS.Size = New System.Drawing.Size(300, 158)
        Me.txtConceptoS.TabIndex = 225
        '
        'cboContrato
        '
        Me.cboContrato.Location = New System.Drawing.Point(11, 26)
        Me.cboContrato.Name = "cboContrato"
        Me.cboContrato.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContrato.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTRATO", "CONTRATO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTIDAD", "ENTIDAD"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LICENCIA", "LICENCIA", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboContrato.Properties.NullText = ""
        Me.cboContrato.Size = New System.Drawing.Size(377, 20)
        Me.cboContrato.TabIndex = 214
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(12, 10)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl17.TabIndex = 215
        Me.LabelControl17.Text = "Contrato:"
        '
        'dtFechaVencimientoS
        '
        Me.dtFechaVencimientoS.EditValue = Nothing
        Me.dtFechaVencimientoS.Location = New System.Drawing.Point(1022, 106)
        Me.dtFechaVencimientoS.Name = "dtFechaVencimientoS"
        Me.dtFechaVencimientoS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtFechaVencimientoS.Properties.Appearance.Options.UseFont = True
        Me.dtFechaVencimientoS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimientoS.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimientoS.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaVencimientoS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimientoS.Properties.EditFormat.FormatString = ""
        Me.dtFechaVencimientoS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimientoS.Properties.Mask.EditMask = ""
        Me.dtFechaVencimientoS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtFechaVencimientoS.Size = New System.Drawing.Size(146, 22)
        Me.dtFechaVencimientoS.TabIndex = 221
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(903, 109)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 16)
        Me.LabelControl3.TabIndex = 218
        Me.LabelControl3.Text = "Fecha Vencimiento:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(913, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl2.TabIndex = 217
        Me.LabelControl2.Text = "Fecha Expedición:"
        '
        'dtFechaExpedicionS
        '
        Me.dtFechaExpedicionS.EditValue = Nothing
        Me.dtFechaExpedicionS.Location = New System.Drawing.Point(1022, 75)
        Me.dtFechaExpedicionS.Name = "dtFechaExpedicionS"
        Me.dtFechaExpedicionS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtFechaExpedicionS.Properties.Appearance.Options.UseFont = True
        Me.dtFechaExpedicionS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicionS.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicionS.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaExpedicionS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicionS.Properties.EditFormat.FormatString = ""
        Me.dtFechaExpedicionS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicionS.Properties.Mask.EditMask = ""
        Me.dtFechaExpedicionS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtFechaExpedicionS.Size = New System.Drawing.Size(146, 22)
        Me.dtFechaExpedicionS.TabIndex = 220
        '
        'txtNumeroFacturaS
        '
        Me.txtNumeroFacturaS.Location = New System.Drawing.Point(956, 26)
        Me.txtNumeroFacturaS.Name = "txtNumeroFacturaS"
        Me.txtNumeroFacturaS.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroFacturaS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroFacturaS.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtNumeroFacturaS.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroFacturaS.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroFacturaS.Properties.Appearance.Options.UseForeColor = True
        Me.txtNumeroFacturaS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumeroFacturaS.Size = New System.Drawing.Size(212, 40)
        Me.txtNumeroFacturaS.TabIndex = 219
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(797, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(164, 33)
        Me.LabelControl1.TabIndex = 216
        Me.LabelControl1.Text = "Factura No. "
        '
        'xtpFacturaProductos
        '
        Me.xtpFacturaProductos.Controls.Add(Me.btnVerOrdenServicio)
        Me.xtpFacturaProductos.Controls.Add(Me.btnSeleccionarOrden)
        Me.xtpFacturaProductos.Controls.Add(Me.SeparatorControl5)
        Me.xtpFacturaProductos.Controls.Add(Me.txtTipoDocumento)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl13)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl15)
        Me.xtpFacturaProductos.Controls.Add(Me.txtConsecutivo)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl16)
        Me.xtpFacturaProductos.Controls.Add(Me.txtValor)
        Me.xtpFacturaProductos.Controls.Add(Me.SeparatorControl4)
        Me.xtpFacturaProductos.Controls.Add(Me.GCCuentasClientes)
        Me.xtpFacturaProductos.Controls.Add(Me.txtDescuento)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl24)
        Me.xtpFacturaProductos.Controls.Add(Me.GroupBox3)
        Me.xtpFacturaProductos.Controls.Add(Me.GroupBox2)
        Me.xtpFacturaProductos.Controls.Add(Me.SeparatorControl2)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl9)
        Me.xtpFacturaProductos.Controls.Add(Me.SeparatorControl1)
        Me.xtpFacturaProductos.Controls.Add(Me.GroupBox1)
        Me.xtpFacturaProductos.Controls.Add(Me.lblMarca)
        Me.xtpFacturaProductos.Controls.Add(Me.cboCliente)
        Me.xtpFacturaProductos.Controls.Add(Me.btnClientes)
        Me.xtpFacturaProductos.Controls.Add(Me.btnRestaCantidad)
        Me.xtpFacturaProductos.Controls.Add(Me.btnSumaCantidad)
        Me.xtpFacturaProductos.Controls.Add(Me.btnEliminar)
        Me.xtpFacturaProductos.Controls.Add(Me.btnAgregar)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl35)
        Me.xtpFacturaProductos.Controls.Add(Me.txtExistencia)
        Me.xtpFacturaProductos.Controls.Add(Me.txtValorUnitarioP)
        Me.xtpFacturaProductos.Controls.Add(Me.txtCantidadP)
        Me.xtpFacturaProductos.Controls.Add(Me.peFoto)
        Me.xtpFacturaProductos.Controls.Add(Me.GCDatosCliente)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl12)
        Me.xtpFacturaProductos.Controls.Add(Me.cboTarifaProducto)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl25)
        Me.xtpFacturaProductos.Controls.Add(Me.txtSonP)
        Me.xtpFacturaProductos.Controls.Add(Me.LabelControl23)
        Me.xtpFacturaProductos.Controls.Add(Me.txtConceptoP)
        Me.xtpFacturaProductos.Controls.Add(Me.GCProductos)
        Me.xtpFacturaProductos.Controls.Add(Me.lblCodigoProducto)
        Me.xtpFacturaProductos.Controls.Add(Me.cboProducto)
        Me.xtpFacturaProductos.Controls.Add(Me.lblUnidadMedida)
        Me.xtpFacturaProductos.Name = "xtpFacturaProductos"
        Me.xtpFacturaProductos.Size = New System.Drawing.Size(1262, 544)
        Me.xtpFacturaProductos.Text = "Facturar Productos"
        '
        'btnVerOrdenServicio
        '
        Me.btnVerOrdenServicio.ImageOptions.Image = CType(resources.GetObject("btnVerOrdenServicio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerOrdenServicio.Location = New System.Drawing.Point(920, 48)
        Me.btnVerOrdenServicio.Name = "btnVerOrdenServicio"
        Me.btnVerOrdenServicio.Size = New System.Drawing.Size(26, 26)
        Me.btnVerOrdenServicio.TabIndex = 278
        Me.btnVerOrdenServicio.Text = "Ver Orden de Servicio"
        '
        'btnSeleccionarOrden
        '
        Me.btnSeleccionarOrden.ImageOptions.Image = CType(resources.GetObject("btnSeleccionarOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSeleccionarOrden.Location = New System.Drawing.Point(920, 15)
        Me.btnSeleccionarOrden.Name = "btnSeleccionarOrden"
        Me.btnSeleccionarOrden.Size = New System.Drawing.Size(26, 26)
        Me.btnSeleccionarOrden.TabIndex = 277
        Me.btnSeleccionarOrden.Text = "Seleccionar Orden de Servicio a Facturar"
        '
        'SeparatorControl5
        '
        Me.SeparatorControl5.Location = New System.Drawing.Point(12, 173)
        Me.SeparatorControl5.Name = "SeparatorControl5"
        Me.SeparatorControl5.Size = New System.Drawing.Size(952, 20)
        Me.SeparatorControl5.TabIndex = 276
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(628, 143)
        Me.txtTipoDocumento.MenuManager = Me.BarManager1
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTipoDocumento.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTipoDocumento.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipoDocumento.Properties.Appearance.Options.UseFont = True
        Me.txtTipoDocumento.Properties.Appearance.Options.UseForeColor = True
        Me.txtTipoDocumento.Properties.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(182, 26)
        Me.txtTipoDocumento.TabIndex = 274
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(628, 126)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl13.TabIndex = 275
        Me.LabelControl13.Text = "Tipo Documento"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(815, 124)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl15.TabIndex = 273
        Me.LabelControl15.Text = "SALDO"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(546, 143)
        Me.txtConsecutivo.MenuManager = Me.BarManager1
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtConsecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConsecutivo.Properties.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(76, 26)
        Me.txtConsecutivo.TabIndex = 271
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(547, 124)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl16.TabIndex = 272
        Me.LabelControl16.Text = "Cons. "
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(816, 143)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtValor.Properties.Appearance.Options.UseBackColor = True
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.Mask.EditMask = "n0"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValor.Size = New System.Drawing.Size(130, 26)
        Me.txtValor.TabIndex = 270
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl4.Location = New System.Drawing.Point(518, 13)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Size = New System.Drawing.Size(22, 157)
        Me.SeparatorControl4.TabIndex = 269
        '
        'GCCuentasClientes
        '
        Me.GCCuentasClientes.Location = New System.Drawing.Point(546, 13)
        Me.GCCuentasClientes.MainView = Me.gvCuentasClientes
        Me.GCCuentasClientes.MenuManager = Me.BarManager1
        Me.GCCuentasClientes.Name = "GCCuentasClientes"
        Me.GCCuentasClientes.Size = New System.Drawing.Size(368, 101)
        Me.GCCuentasClientes.TabIndex = 268
        Me.GCCuentasClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCuentasClientes})
        '
        'gvCuentasClientes
        '
        Me.gvCuentasClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSId, Me.colSFecha, Me.colSDocumento, Me.colSConsecutivo, Me.colSSaldo})
        Me.gvCuentasClientes.GridControl = Me.GCCuentasClientes
        Me.gvCuentasClientes.Name = "gvCuentasClientes"
        Me.gvCuentasClientes.OptionsBehavior.Editable = False
        Me.gvCuentasClientes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvCuentasClientes.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvCuentasClientes.OptionsPrint.ExpandAllDetails = True
        Me.gvCuentasClientes.OptionsPrint.ExpandAllGroups = False
        Me.gvCuentasClientes.OptionsPrint.PrintFooter = False
        Me.gvCuentasClientes.OptionsView.EnableAppearanceOddRow = True
        Me.gvCuentasClientes.OptionsView.ShowGroupPanel = False
        '
        'colSId
        '
        Me.colSId.Caption = "ID"
        Me.colSId.FieldName = "ID"
        Me.colSId.Name = "colSId"
        '
        'colSFecha
        '
        Me.colSFecha.Caption = "FECHA"
        Me.colSFecha.FieldName = "FECHA"
        Me.colSFecha.Name = "colSFecha"
        Me.colSFecha.Visible = True
        Me.colSFecha.VisibleIndex = 0
        Me.colSFecha.Width = 69
        '
        'colSDocumento
        '
        Me.colSDocumento.Caption = "DOCUMENTO"
        Me.colSDocumento.FieldName = "DOCUMENTO"
        Me.colSDocumento.Name = "colSDocumento"
        Me.colSDocumento.Visible = True
        Me.colSDocumento.VisibleIndex = 1
        Me.colSDocumento.Width = 118
        '
        'colSConsecutivo
        '
        Me.colSConsecutivo.Caption = "CONS."
        Me.colSConsecutivo.FieldName = "CONSECUTIVO"
        Me.colSConsecutivo.Name = "colSConsecutivo"
        Me.colSConsecutivo.Visible = True
        Me.colSConsecutivo.VisibleIndex = 2
        Me.colSConsecutivo.Width = 83
        '
        'colSSaldo
        '
        Me.colSSaldo.Caption = "SALDO"
        Me.colSSaldo.DisplayFormat.FormatString = "C0"
        Me.colSSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSSaldo.FieldName = "SALDO"
        Me.colSSaldo.Name = "colSSaldo"
        Me.colSSaldo.Visible = True
        Me.colSSaldo.VisibleIndex = 3
        Me.colSSaldo.Width = 80
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(500, 341)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtDescuento.Properties.Appearance.Options.UseFont = True
        Me.txtDescuento.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Mask.EditMask = "c0"
        Me.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuento.Size = New System.Drawing.Size(132, 30)
        Me.txtDescuento.TabIndex = 267
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Location = New System.Drawing.Point(500, 316)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl24.TabIndex = 266
        Me.LabelControl24.Text = "Descuento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GCDetallePagoDocumento)
        Me.GroupBox3.Controls.Add(Me.btnEliminarFormaPago)
        Me.GroupBox3.Controls.Add(Me.txtFormaPagoValor)
        Me.GroupBox3.Controls.Add(Me.btnAgregarFormaPago)
        Me.GroupBox3.Controls.Add(Me.LabelControl29)
        Me.GroupBox3.Controls.Add(Me.lblValor)
        Me.GroupBox3.Controls.Add(Me.cboFormaPago)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(994, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 217)
        Me.GroupBox3.TabIndex = 264
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'GCDetallePagoDocumento
        '
        Me.GCDetallePagoDocumento.Location = New System.Drawing.Point(6, 83)
        Me.GCDetallePagoDocumento.MainView = Me.gvDetallePagoDocumento
        Me.GCDetallePagoDocumento.Name = "GCDetallePagoDocumento"
        Me.GCDetallePagoDocumento.Size = New System.Drawing.Size(244, 124)
        Me.GCDetallePagoDocumento.TabIndex = 251
        Me.GCDetallePagoDocumento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetallePagoDocumento})
        '
        'gvDetallePagoDocumento
        '
        Me.gvDetallePagoDocumento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.colCONCEPTODETALLEPAGO, Me.colVALORDETALLEPAGO})
        Me.gvDetallePagoDocumento.GridControl = Me.GCDetallePagoDocumento
        Me.gvDetallePagoDocumento.Name = "gvDetallePagoDocumento"
        Me.gvDetallePagoDocumento.OptionsBehavior.Editable = False
        Me.gvDetallePagoDocumento.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvDetallePagoDocumento.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllDetails = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllGroups = False
        Me.gvDetallePagoDocumento.OptionsPrint.PrintFooter = False
        Me.gvDetallePagoDocumento.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsView.ShowColumnHeaders = False
        Me.gvDetallePagoDocumento.OptionsView.ShowFooter = True
        Me.gvDetallePagoDocumento.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "ID"
        Me.GridColumn11.FieldName = "ID"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'colCONCEPTODETALLEPAGO
        '
        Me.colCONCEPTODETALLEPAGO.Caption = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.FieldName = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.Name = "colCONCEPTODETALLEPAGO"
        Me.colCONCEPTODETALLEPAGO.Visible = True
        Me.colCONCEPTODETALLEPAGO.VisibleIndex = 0
        Me.colCONCEPTODETALLEPAGO.Width = 368
        '
        'colVALORDETALLEPAGO
        '
        Me.colVALORDETALLEPAGO.Caption = "VALOR"
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORDETALLEPAGO.FieldName = "VALOR"
        Me.colVALORDETALLEPAGO.Name = "colVALORDETALLEPAGO"
        Me.colVALORDETALLEPAGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORDETALLEPAGO.Visible = True
        Me.colVALORDETALLEPAGO.VisibleIndex = 1
        Me.colVALORDETALLEPAGO.Width = 162
        '
        'btnEliminarFormaPago
        '
        Me.btnEliminarFormaPago.ImageOptions.Image = CType(resources.GetObject("btnEliminarFormaPago.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarFormaPago.Location = New System.Drawing.Point(227, 54)
        Me.btnEliminarFormaPago.Name = "btnEliminarFormaPago"
        Me.btnEliminarFormaPago.Size = New System.Drawing.Size(23, 23)
        Me.btnEliminarFormaPago.TabIndex = 249
        Me.btnEliminarFormaPago.ToolTip = "Eliminar Producto"
        '
        'txtFormaPagoValor
        '
        Me.txtFormaPagoValor.Location = New System.Drawing.Point(82, 56)
        Me.txtFormaPagoValor.Name = "txtFormaPagoValor"
        Me.txtFormaPagoValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtFormaPagoValor.Properties.Appearance.Options.UseFont = True
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.EditMask = "c0"
        Me.txtFormaPagoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFormaPagoValor.Size = New System.Drawing.Size(110, 20)
        Me.txtFormaPagoValor.TabIndex = 248
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.ImageOptions.Image = CType(resources.GetObject("btnAgregarFormaPago.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(198, 54)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(23, 23)
        Me.btnAgregarFormaPago.TabIndex = 248
        Me.btnAgregarFormaPago.ToolTip = "Agregar Producto"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(52, 59)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl29.TabIndex = 250
        Me.LabelControl29.Text = "Valor"
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(6, 31)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(70, 13)
        Me.lblValor.TabIndex = 249
        Me.lblValor.Text = "Medio de Pago"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.Location = New System.Drawing.Point(82, 28)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cboFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cboFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONCEPTO", "CONCEPTO")})
        Me.cboFormaPago.Properties.NullText = ""
        Me.cboFormaPago.Properties.ShowHeader = False
        Me.cboFormaPago.Size = New System.Drawing.Size(168, 20)
        Me.cboFormaPago.TabIndex = 248
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl14)
        Me.GroupBox2.Controls.Add(Me.dtFechaExpedicion)
        Me.GroupBox2.Controls.Add(Me.LabelControl18)
        Me.GroupBox2.Controls.Add(Me.dtFechaVencimiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(993, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 99)
        Me.GroupBox2.TabIndex = 245
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Factura"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(32, 30)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl14.TabIndex = 204
        Me.LabelControl14.Text = "Expedición:"
        '
        'dtFechaExpedicion
        '
        Me.dtFechaExpedicion.EditValue = Nothing
        Me.dtFechaExpedicion.Location = New System.Drawing.Point(122, 27)
        Me.dtFechaExpedicion.Name = "dtFechaExpedicion"
        Me.dtFechaExpedicion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaExpedicion.Properties.Appearance.Options.UseFont = True
        Me.dtFechaExpedicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = True
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Properties.EditFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Size = New System.Drawing.Size(111, 26)
        Me.dtFechaExpedicion.TabIndex = 191
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(21, 62)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl18.TabIndex = 205
        Me.LabelControl18.Text = "Vencimiento:"
        '
        'dtFechaVencimiento
        '
        Me.dtFechaVencimiento.EditValue = Nothing
        Me.dtFechaVencimiento.Location = New System.Drawing.Point(122, 59)
        Me.dtFechaVencimiento.Name = "dtFechaVencimiento"
        Me.dtFechaVencimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaVencimiento.Properties.Appearance.Options.UseFont = True
        Me.dtFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimiento.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaVencimiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimiento.Properties.EditFormat.FormatString = ""
        Me.dtFechaVencimiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimiento.Size = New System.Drawing.Size(110, 26)
        Me.dtFechaVencimiento.TabIndex = 192
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(222, 196)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(22, 175)
        Me.SeparatorControl2.TabIndex = 247
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(287, 316)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl9.TabIndex = 246
        Me.LabelControl9.Text = "Cantidad"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(969, 19)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(22, 509)
        Me.SeparatorControl1.TabIndex = 245
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl22)
        Me.GroupBox1.Controls.Add(Me.LabelControl21)
        Me.GroupBox1.Controls.Add(Me.txtDescuentoP)
        Me.GroupBox1.Controls.Add(Me.LabelControl20)
        Me.GroupBox1.Controls.Add(Me.txtIVAP)
        Me.GroupBox1.Controls.Add(Me.LabelControl19)
        Me.GroupBox1.Controls.Add(Me.txtSubTotalP)
        Me.GroupBox1.Controls.Add(Me.txtTotalP)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(994, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 177)
        Me.GroupBox1.TabIndex = 244
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales Factura"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(17, 37)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(87, 23)
        Me.LabelControl22.TabIndex = 211
        Me.LabelControl22.Text = "Sub Total:"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(68, 107)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(36, 23)
        Me.LabelControl21.TabIndex = 216
        Me.LabelControl21.Text = "IVA:"
        '
        'txtDescuentoP
        '
        Me.txtDescuentoP.EditValue = "0"
        Me.txtDescuentoP.Location = New System.Drawing.Point(121, 69)
        Me.txtDescuentoP.Name = "txtDescuentoP"
        Me.txtDescuentoP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescuentoP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescuentoP.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescuentoP.Properties.Appearance.Options.UseFont = True
        Me.txtDescuentoP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescuentoP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescuentoP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoP.Properties.Mask.BeepOnError = True
        Me.txtDescuentoP.Properties.Mask.EditMask = "c0"
        Me.txtDescuentoP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuentoP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuentoP.Properties.ReadOnly = True
        Me.txtDescuentoP.Size = New System.Drawing.Size(120, 28)
        Me.txtDescuentoP.TabIndex = 237
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(56, 144)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(48, 23)
        Me.LabelControl20.TabIndex = 218
        Me.LabelControl20.Text = "Total:"
        '
        'txtIVAP
        '
        Me.txtIVAP.EditValue = "0"
        Me.txtIVAP.Location = New System.Drawing.Point(121, 105)
        Me.txtIVAP.Name = "txtIVAP"
        Me.txtIVAP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIVAP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtIVAP.Properties.Appearance.Options.UseBackColor = True
        Me.txtIVAP.Properties.Appearance.Options.UseFont = True
        Me.txtIVAP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIVAP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIVAP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtIVAP.Properties.Mask.BeepOnError = True
        Me.txtIVAP.Properties.Mask.EditMask = "c0"
        Me.txtIVAP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIVAP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIVAP.Properties.ReadOnly = True
        Me.txtIVAP.Size = New System.Drawing.Size(120, 28)
        Me.txtIVAP.TabIndex = 238
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(95, 23)
        Me.LabelControl19.TabIndex = 221
        Me.LabelControl19.Text = "Descuento:"
        '
        'txtSubTotalP
        '
        Me.txtSubTotalP.EditValue = "0"
        Me.txtSubTotalP.Location = New System.Drawing.Point(121, 35)
        Me.txtSubTotalP.Name = "txtSubTotalP"
        Me.txtSubTotalP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSubTotalP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotalP.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotalP.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotalP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubTotalP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotalP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubTotalP.Properties.Mask.BeepOnError = True
        Me.txtSubTotalP.Properties.Mask.EditMask = "c0"
        Me.txtSubTotalP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotalP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSubTotalP.Properties.ReadOnly = True
        Me.txtSubTotalP.Size = New System.Drawing.Size(120, 28)
        Me.txtSubTotalP.TabIndex = 236
        '
        'txtTotalP
        '
        Me.txtTotalP.EditValue = "0"
        Me.txtTotalP.Location = New System.Drawing.Point(121, 142)
        Me.txtTotalP.Name = "txtTotalP"
        Me.txtTotalP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalP.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalP.Properties.Appearance.Options.UseFont = True
        Me.txtTotalP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotalP.Properties.Mask.BeepOnError = True
        Me.txtTotalP.Properties.Mask.EditMask = "c0"
        Me.txtTotalP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalP.Properties.ReadOnly = True
        Me.txtTotalP.Size = New System.Drawing.Size(120, 28)
        Me.txtTotalP.TabIndex = 239
        '
        'lblMarca
        '
        Me.lblMarca.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblMarca.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblMarca.Appearance.Options.UseFont = True
        Me.lblMarca.Appearance.Options.UseForeColor = True
        Me.lblMarca.Location = New System.Drawing.Point(254, 212)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(35, 16)
        Me.lblMarca.TabIndex = 242
        Me.lblMarca.Text = "Marca"
        '
        'cboCliente
        '
        Me.cboCliente.EditValue = "SELECCIONAR"
        Me.cboCliente.Location = New System.Drawing.Point(71, 13)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboCliente.Properties.Appearance.Options.UseFont = True
        Me.cboCliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCliente.Properties.NullText = ""
        Me.cboCliente.Properties.PopupView = Me.GridView1
        Me.cboCliente.Size = New System.Drawing.Size(404, 26)
        Me.cboCliente.TabIndex = 241
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCLIENTE, Me.IDENTIFICACION, Me.CLIENTE, Me.CONTACTO, Me.TELEFONO})
        Me.GridView1.DetailHeight = 200
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIDCLIENTE
        '
        Me.colIDCLIENTE.Caption = "ID"
        Me.colIDCLIENTE.FieldName = "IDCLIENTE"
        Me.colIDCLIENTE.Name = "colIDCLIENTE"
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.Caption = "IDENTIFICACION"
        Me.IDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.Visible = True
        Me.IDENTIFICACION.VisibleIndex = 0
        '
        'CLIENTE
        '
        Me.CLIENTE.Caption = "CLIENTE"
        Me.CLIENTE.FieldName = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Visible = True
        Me.CLIENTE.VisibleIndex = 1
        '
        'CONTACTO
        '
        Me.CONTACTO.Caption = "CONTACTO"
        Me.CONTACTO.FieldName = "CONTACTO"
        Me.CONTACTO.Name = "CONTACTO"
        Me.CONTACTO.Visible = True
        Me.CONTACTO.VisibleIndex = 2
        '
        'TELEFONO
        '
        Me.TELEFONO.Caption = "TELEFONO"
        Me.TELEFONO.FieldName = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Visible = True
        Me.TELEFONO.VisibleIndex = 3
        '
        'btnClientes
        '
        Me.btnClientes.ImageOptions.Image = CType(resources.GetObject("btnClientes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(483, 13)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(26, 26)
        Me.btnClientes.TabIndex = 240
        Me.btnClientes.Text = "Registro de Clientes"
        '
        'btnRestaCantidad
        '
        Me.btnRestaCantidad.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRestaCantidad.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnRestaCantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnRestaCantidad.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRestaCantidad.Appearance.Options.UseBackColor = True
        Me.btnRestaCantidad.Appearance.Options.UseFont = True
        Me.btnRestaCantidad.Appearance.Options.UseForeColor = True
        Me.btnRestaCantidad.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnRestaCantidad.AppearanceHovered.Options.UseBackColor = True
        Me.btnRestaCantidad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnRestaCantidad.Location = New System.Drawing.Point(250, 341)
        Me.btnRestaCantidad.Name = "btnRestaCantidad"
        Me.btnRestaCantidad.Size = New System.Drawing.Size(36, 30)
        Me.btnRestaCantidad.TabIndex = 235
        Me.btnRestaCantidad.Text = "-"
        '
        'btnSumaCantidad
        '
        Me.btnSumaCantidad.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSumaCantidad.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnSumaCantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnSumaCantidad.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSumaCantidad.Appearance.Options.UseBackColor = True
        Me.btnSumaCantidad.Appearance.Options.UseFont = True
        Me.btnSumaCantidad.Appearance.Options.UseForeColor = True
        Me.btnSumaCantidad.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSumaCantidad.AppearanceHovered.Options.UseBackColor = True
        Me.btnSumaCantidad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnSumaCantidad.Location = New System.Drawing.Point(373, 341)
        Me.btnSumaCantidad.Name = "btnSumaCantidad"
        Me.btnSumaCantidad.Size = New System.Drawing.Size(35, 30)
        Me.btnSumaCantidad.TabIndex = 234
        Me.btnSumaCantidad.Text = "+"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnEliminar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Appearance.Options.UseBackColor = True
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Appearance.Options.UseForeColor = True
        Me.btnEliminar.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnEliminar.AppearanceHovered.Options.UseBackColor = True
        Me.btnEliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnEliminar.Location = New System.Drawing.Point(804, 338)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 35)
        Me.btnEliminar.TabIndex = 233
        Me.btnEliminar.Text = "Eliminar Producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregar.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnAgregar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Appearance.Options.UseBackColor = True
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Appearance.Options.UseForeColor = True
        Me.btnAgregar.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAgregar.AppearanceHovered.Options.UseBackColor = True
        Me.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnAgregar.Location = New System.Drawing.Point(638, 338)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(160, 35)
        Me.btnAgregar.TabIndex = 232
        Me.btnAgregar.Text = "Agregar Producto"
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.Location = New System.Drawing.Point(414, 316)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl35.TabIndex = 231
        Me.LabelControl35.Text = "Exist."
        '
        'txtExistencia
        '
        Me.txtExistencia.EditValue = "0"
        Me.txtExistencia.Location = New System.Drawing.Point(414, 341)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtExistencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtExistencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtExistencia.Properties.Appearance.Options.UseFont = True
        Me.txtExistencia.Properties.Mask.BeepOnError = True
        Me.txtExistencia.Properties.Mask.EditMask = "f"
        Me.txtExistencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExistencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(80, 30)
        Me.txtExistencia.TabIndex = 230
        '
        'txtValorUnitarioP
        '
        Me.txtValorUnitarioP.EditValue = "0"
        Me.txtValorUnitarioP.Location = New System.Drawing.Point(253, 280)
        Me.txtValorUnitarioP.Name = "txtValorUnitarioP"
        Me.txtValorUnitarioP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValorUnitarioP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorUnitarioP.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorUnitarioP.Properties.Appearance.Options.UseFont = True
        Me.txtValorUnitarioP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtValorUnitarioP.Properties.Mask.BeepOnError = True
        Me.txtValorUnitarioP.Properties.Mask.EditMask = "c0"
        Me.txtValorUnitarioP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorUnitarioP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorUnitarioP.Properties.ReadOnly = True
        Me.txtValorUnitarioP.Size = New System.Drawing.Size(120, 28)
        Me.txtValorUnitarioP.TabIndex = 229
        '
        'txtCantidadP
        '
        Me.txtCantidadP.EditValue = "0"
        Me.txtCantidadP.Location = New System.Drawing.Point(287, 341)
        Me.txtCantidadP.Name = "txtCantidadP"
        Me.txtCantidadP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCantidadP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtCantidadP.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidadP.Properties.Appearance.Options.UseFont = True
        Me.txtCantidadP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCantidadP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCantidadP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCantidadP.Properties.Mask.BeepOnError = True
        Me.txtCantidadP.Properties.Mask.EditMask = "f"
        Me.txtCantidadP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidadP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidadP.Size = New System.Drawing.Size(84, 30)
        Me.txtCantidadP.TabIndex = 228
        '
        'peFoto
        '
        Me.peFoto.EditValue = CType(resources.GetObject("peFoto.EditValue"), Object)
        Me.peFoto.Location = New System.Drawing.Point(12, 196)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.InitialImageOptions.Image = CType(resources.GetObject("peFoto.Properties.InitialImageOptions.Image"), System.Drawing.Image)
        Me.peFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.peFoto.Size = New System.Drawing.Size(204, 175)
        Me.peFoto.TabIndex = 214
        '
        'GCDatosCliente
        '
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosCliente.Location = New System.Drawing.Point(12, 48)
        Me.GCDatosCliente.MainView = Me.TVDatosCliente
        Me.GCDatosCliente.Name = "GCDatosCliente"
        Me.GCDatosCliente.Size = New System.Drawing.Size(497, 84)
        Me.GCDatosCliente.TabIndex = 224
        Me.GCDatosCliente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TVDatosCliente})
        '
        'TVDatosCliente
        '
        Me.TVDatosCliente.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TVDatosCliente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn1, Me.TileViewColumn2, Me.TileViewColumn3, Me.colApellidos, Me.colEdad, Me.TileViewColumn4, Me.colDireccion, Me.colEmail, Me.TileViewColumn5, Me.colFoto})
        Me.TVDatosCliente.GridControl = Me.GCDatosCliente
        Me.TVDatosCliente.Name = "TVDatosCliente"
        Me.TVDatosCliente.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(28, 0, 0, 16)
        Me.TVDatosCliente.OptionsTiles.IndentBetweenItems = 13
        Me.TVDatosCliente.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TVDatosCliente.OptionsTiles.ItemSize = New System.Drawing.Size(372, 72)
        Me.TVDatosCliente.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        TableColumnDefinition1.Length.Value = 138.0R
        Me.TVDatosCliente.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.TileViewColumn3
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.Text = "TileViewColumn3"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(10, 5)
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumn5
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.Text = "TileViewColumn5"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(10, 35)
        TileViewItemElement3.Column = Me.TileViewColumn2
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.Text = "TileViewColumn2"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(10, 22)
        TileViewItemElement4.Column = Me.colEmail
        TileViewItemElement4.StretchHorizontal = True
        TileViewItemElement4.Text = "colEmail"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(10, 60)
        TileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.Transparent
        TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.DimGray
        TileViewItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement5.Column = Me.colDireccion
        TileViewItemElement5.StretchHorizontal = True
        TileViewItemElement5.Text = "colDireccion"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(10, 47)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement1)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement2)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement3)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement4)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement5)
        '
        'TileViewColumn1
        '
        Me.TileViewColumn1.Caption = "ID"
        Me.TileViewColumn1.FieldName = "ID"
        Me.TileViewColumn1.Name = "TileViewColumn1"
        Me.TileViewColumn1.Visible = True
        Me.TileViewColumn1.VisibleIndex = 0
        '
        'colApellidos
        '
        Me.colApellidos.Caption = "APELLIDOS"
        Me.colApellidos.FieldName = "TELEFONO"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 8
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 5
        '
        'TileViewColumn4
        '
        Me.TileViewColumn4.Caption = "Sexo"
        Me.TileViewColumn4.FieldName = "SEXO"
        Me.TileViewColumn4.Name = "TileViewColumn4"
        Me.TileViewColumn4.Visible = True
        Me.TileViewColumn4.VisibleIndex = 3
        '
        'colFoto
        '
        Me.colFoto.Caption = "FOTO"
        Me.colFoto.FieldName = "FOTO"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Visible = True
        Me.colFoto.VisibleIndex = 9
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(18, 147)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl12.TabIndex = 223
        Me.LabelControl12.Text = "Tarifa:"
        '
        'cboTarifaProducto
        '
        Me.cboTarifaProducto.Location = New System.Drawing.Point(71, 144)
        Me.cboTarifaProducto.Name = "cboTarifaProducto"
        Me.cboTarifaProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboTarifaProducto.Properties.Appearance.Options.UseFont = True
        Me.cboTarifaProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTarifaProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTarifaProducto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TARIFA", "TARIFA")})
        Me.cboTarifaProducto.Properties.NullText = ""
        Me.cboTarifaProducto.Properties.ShowHeader = False
        Me.cboTarifaProducto.Size = New System.Drawing.Size(438, 26)
        Me.cboTarifaProducto.TabIndex = 190
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl25.TabIndex = 222
        Me.LabelControl25.Text = "Cliente:"
        '
        'txtSonP
        '
        Me.txtSonP.Location = New System.Drawing.Point(52, 502)
        Me.txtSonP.Name = "txtSonP"
        Me.txtSonP.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSonP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSonP.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSonP.Properties.Appearance.Options.UseBackColor = True
        Me.txtSonP.Properties.Appearance.Options.UseFont = True
        Me.txtSonP.Properties.Appearance.Options.UseForeColor = True
        Me.txtSonP.Properties.ReadOnly = True
        Me.txtSonP.Size = New System.Drawing.Size(912, 26)
        Me.txtSonP.TabIndex = 213
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(10, 505)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl23.TabIndex = 212
        Me.LabelControl23.Text = "Son:"
        '
        'txtConceptoP
        '
        Me.txtConceptoP.Location = New System.Drawing.Point(3, 3)
        Me.txtConceptoP.Name = "txtConceptoP"
        Me.txtConceptoP.Size = New System.Drawing.Size(32, 26)
        Me.txtConceptoP.TabIndex = 209
        Me.txtConceptoP.Visible = False
        '
        'GCProductos
        '
        Me.GCProductos.Location = New System.Drawing.Point(12, 377)
        Me.GCProductos.MainView = Me.gvProductos
        Me.GCProductos.MenuManager = Me.BarManager1
        Me.GCProductos.Name = "GCProductos"
        Me.GCProductos.Size = New System.Drawing.Size(952, 119)
        Me.GCProductos.TabIndex = 199
        Me.GCProductos.UseEmbeddedNavigator = True
        Me.GCProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductos})
        '
        'gvProductos
        '
        Me.gvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProductos, Me.colCodigoProducto, Me.colPRESENTACION2, Me.colUNIDAD, Me.colCANTIDAD, Me.colValorUnitario, Me.colCSubTotal, Me.colCDescuento, Me.colIDPRODUCTO2, Me.colIDPRESENTACIONPRODUCTO, Me.colIDMARCA, Me.colCOSTOVENTA, Me.colINVENTARIO})
        Me.gvProductos.GridControl = Me.GCProductos
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.OptionsBehavior.Editable = False
        Me.gvProductos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvProductos.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsPrint.ExpandAllDetails = True
        Me.gvProductos.OptionsPrint.ExpandAllGroups = False
        Me.gvProductos.OptionsPrint.PrintFooter = False
        Me.gvProductos.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsView.ShowGroupPanel = False
        '
        'colIDProductos
        '
        Me.colIDProductos.Caption = "ID"
        Me.colIDProductos.FieldName = "ID"
        Me.colIDProductos.Name = "colIDProductos"
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.Caption = "CODIGO"
        Me.colCodigoProducto.FieldName = "CODIGO"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.Visible = True
        Me.colCodigoProducto.VisibleIndex = 0
        Me.colCodigoProducto.Width = 100
        '
        'colPRESENTACION2
        '
        Me.colPRESENTACION2.Caption = "PRESENTACION"
        Me.colPRESENTACION2.FieldName = "PRESENTACION"
        Me.colPRESENTACION2.Name = "colPRESENTACION2"
        Me.colPRESENTACION2.Visible = True
        Me.colPRESENTACION2.VisibleIndex = 1
        Me.colPRESENTACION2.Width = 417
        '
        'colUNIDAD
        '
        Me.colUNIDAD.Caption = "UNI MED"
        Me.colUNIDAD.FieldName = "UNIDAD"
        Me.colUNIDAD.Name = "colUNIDAD"
        Me.colUNIDAD.Visible = True
        Me.colUNIDAD.VisibleIndex = 2
        Me.colUNIDAD.Width = 71
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "CANTIDAD"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 3
        Me.colCANTIDAD.Width = 80
        '
        'colValorUnitario
        '
        Me.colValorUnitario.Caption = "VAL UNIT"
        Me.colValorUnitario.DisplayFormat.FormatString = "C0"
        Me.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorUnitario.FieldName = "VALOR_UNITARIO"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR_UNITARIO", "SUMA={0:C0}")})
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 4
        Me.colValorUnitario.Width = 78
        '
        'colCSubTotal
        '
        Me.colCSubTotal.Caption = "SUBTOTAL"
        Me.colCSubTotal.DisplayFormat.FormatString = "C0"
        Me.colCSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCSubTotal.FieldName = "SUBTOTAL"
        Me.colCSubTotal.Name = "colCSubTotal"
        Me.colCSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "TOTAL={0:C0}")})
        Me.colCSubTotal.Visible = True
        Me.colCSubTotal.VisibleIndex = 6
        Me.colCSubTotal.Width = 116
        '
        'colCDescuento
        '
        Me.colCDescuento.Caption = "DESCUENTO"
        Me.colCDescuento.DisplayFormat.FormatString = "C0"
        Me.colCDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCDescuento.FieldName = "DESCUENTO"
        Me.colCDescuento.Name = "colCDescuento"
        Me.colCDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DESCUENTO", "DESCUENTO={0:C0}")})
        Me.colCDescuento.Visible = True
        Me.colCDescuento.VisibleIndex = 5
        Me.colCDescuento.Width = 84
        '
        'colIDPRODUCTO2
        '
        Me.colIDPRODUCTO2.Caption = "IDPRODUCTO"
        Me.colIDPRODUCTO2.FieldName = "IDPRODUCTO"
        Me.colIDPRODUCTO2.Name = "colIDPRODUCTO2"
        '
        'colIDPRESENTACIONPRODUCTO
        '
        Me.colIDPRESENTACIONPRODUCTO.Caption = "IDPRESENTACIONPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.FieldName = "IDPRESENTACIONPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.Name = "colIDPRESENTACIONPRODUCTO"
        '
        'colIDMARCA
        '
        Me.colIDMARCA.Caption = "IDMARCA"
        Me.colIDMARCA.FieldName = "IDMARCA"
        Me.colIDMARCA.Name = "colIDMARCA"
        '
        'colCOSTOVENTA
        '
        Me.colCOSTOVENTA.Caption = "COSTOVENTA"
        Me.colCOSTOVENTA.FieldName = "COSTOVENTA"
        Me.colCOSTOVENTA.Name = "colCOSTOVENTA"
        '
        'colINVENTARIO
        '
        Me.colINVENTARIO.Caption = "INVENTARIO"
        Me.colINVENTARIO.FieldName = "INVENTARIO"
        Me.colINVENTARIO.Name = "colINVENTARIO"
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblCodigoProducto.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblCodigoProducto.Appearance.Options.UseFont = True
        Me.lblCodigoProducto.Appearance.Options.UseForeColor = True
        Me.lblCodigoProducto.Location = New System.Drawing.Point(253, 263)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(39, 16)
        Me.lblCodigoProducto.TabIndex = 198
        Me.lblCodigoProducto.Text = "Código"
        '
        'cboProducto
        '
        Me.cboProducto.EditValue = "SELECCIONAR"
        Me.cboProducto.Location = New System.Drawing.Point(251, 234)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboProducto.Properties.Appearance.Options.UseFont = True
        Me.cboProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProducto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cboProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProducto.Properties.NullText = ""
        Me.cboProducto.Properties.PopupView = Me.gvComboProductos
        Me.cboProducto.Size = New System.Drawing.Size(713, 26)
        Me.cboProducto.TabIndex = 193
        '
        'gvComboProductos
        '
        Me.gvComboProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPRESENTACIONPRODUCTO2, Me.GridColumn12, Me.colCodigoBarra, Me.colPRESENTACION, Me.colMEDIDA, Me.GridColumn13, Me.colIVA, Me.colSubTotal, Me.colIDPRODUCTO, Me.colMARCA})
        Me.gvComboProductos.DetailHeight = 200
        Me.gvComboProductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvComboProductos.Name = "gvComboProductos"
        Me.gvComboProductos.OptionsBehavior.AutoPopulateColumns = False
        Me.gvComboProductos.OptionsEditForm.PopupEditFormWidth = 1000
        Me.gvComboProductos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvComboProductos.OptionsView.ColumnAutoWidth = False
        Me.gvComboProductos.OptionsView.EnableAppearanceOddRow = True
        Me.gvComboProductos.OptionsView.ShowGroupPanel = False
        '
        'colIDPRESENTACIONPRODUCTO2
        '
        Me.colIDPRESENTACIONPRODUCTO2.Caption = "ID PRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO2.FieldName = "IDPRESENTACIONPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO2.Name = "colIDPRESENTACIONPRODUCTO2"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ID"
        Me.GridColumn12.FieldName = "ID"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.Caption = "CODIGO"
        Me.colCodigoBarra.FieldName = "CODIGO"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 0
        Me.colCodigoBarra.Width = 90
        '
        'colPRESENTACION
        '
        Me.colPRESENTACION.Caption = "PRESENTACION"
        Me.colPRESENTACION.FieldName = "PRESENTACION"
        Me.colPRESENTACION.Name = "colPRESENTACION"
        Me.colPRESENTACION.Visible = True
        Me.colPRESENTACION.VisibleIndex = 1
        Me.colPRESENTACION.Width = 251
        '
        'colMEDIDA
        '
        Me.colMEDIDA.Caption = "MEDIDA"
        Me.colMEDIDA.FieldName = "UNIDAD"
        Me.colMEDIDA.Name = "colMEDIDA"
        Me.colMEDIDA.Visible = True
        Me.colMEDIDA.VisibleIndex = 2
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "VALOR"
        Me.GridColumn13.DisplayFormat.FormatString = "C0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "VALOR"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        '
        'colIVA
        '
        Me.colIVA.Caption = "IVA"
        Me.colIVA.DisplayFormat.FormatString = "C0"
        Me.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIVA.FieldName = "IVA"
        Me.colIVA.Name = "colIVA"
        Me.colIVA.Visible = True
        Me.colIVA.VisibleIndex = 5
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SUBTOTAL"
        Me.colSubTotal.DisplayFormat.FormatString = "C0"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SUBTOTAL"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 4
        '
        'colIDPRODUCTO
        '
        Me.colIDPRODUCTO.Caption = "IDPRODUCTO"
        Me.colIDPRODUCTO.FieldName = "IDPRODUCTO"
        Me.colIDPRODUCTO.Name = "colIDPRODUCTO"
        '
        'colMARCA
        '
        Me.colMARCA.Caption = "MARCA"
        Me.colMARCA.FieldName = "MARCA"
        Me.colMARCA.Name = "colMARCA"
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnidadMedida.Appearance.Options.UseFont = True
        Me.lblUnidadMedida.Location = New System.Drawing.Point(376, 283)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(67, 23)
        Me.lblUnidadMedida.TabIndex = 200
        Me.lblUnidadMedida.Text = "Unidad"
        '
        'xtpRips
        '
        Me.xtpRips.Controls.Add(Me.Button1)
        Me.xtpRips.Controls.Add(Me.LabelControl34)
        Me.xtpRips.Controls.Add(Me.GCRips)
        Me.xtpRips.Controls.Add(Me.xtcReporteEstudio)
        Me.xtpRips.Controls.Add(Me.BarDockControl7)
        Me.xtpRips.Name = "xtpRips"
        Me.xtpRips.Size = New System.Drawing.Size(1262, 545)
        Me.xtpRips.Text = "RIPS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1026, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 225
        Me.Button1.Text = "CAmbios para GIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(15, 13)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(170, 13)
        Me.LabelControl34.TabIndex = 223
        Me.LabelControl34.Text = "Listado de Facturar a Generar RIPS"
        '
        'GCRips
        '
        Me.GCRips.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCRips.Location = New System.Drawing.Point(15, 32)
        Me.GCRips.MainView = Me.GVRips
        Me.GCRips.Name = "GCRips"
        Me.GCRips.Size = New System.Drawing.Size(963, 128)
        Me.GCRips.TabIndex = 104
        Me.GCRips.UseEmbeddedNavigator = True
        Me.GCRips.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRips})
        '
        'GVRips
        '
        Me.GVRips.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GVRips.GridControl = Me.GCRips
        Me.GVRips.Name = "GVRips"
        Me.GVRips.OptionsBehavior.Editable = False
        Me.GVRips.OptionsBehavior.ReadOnly = True
        Me.GVRips.OptionsView.ColumnAutoWidth = False
        Me.GVRips.OptionsView.EnableAppearanceOddRow = True
        Me.GVRips.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 48
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "FACTURA"
        Me.GridColumn2.FieldName = "FACTURA"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 59
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "FECHA"
        Me.GridColumn3.FieldName = "FECHA"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CLIENTES "
        Me.GridColumn4.FieldName = "CONTRATO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 250
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CONCEPTO"
        Me.GridColumn5.FieldName = "CONCEPTO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 216
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "VALOR"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:C0}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "VALOR"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "NETO"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:C0}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "NETO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "{0:C0}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GENERADA"
        Me.GridColumn8.FieldName = "GENERADA"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "ESTADO"
        Me.GridColumn9.FieldName = "ESTADO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "TIPOFACTURA"
        Me.GridColumn10.FieldName = "TIPOFACTURA"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'xtcReporteEstudio
        '
        Me.xtcReporteEstudio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcReporteEstudio.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcReporteEstudio.Location = New System.Drawing.Point(11, 170)
        Me.xtcReporteEstudio.Name = "xtcReporteEstudio"
        Me.xtcReporteEstudio.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.None
        Me.xtcReporteEstudio.SelectedTabPage = Me.xtpUsuarios
        Me.xtcReporteEstudio.Size = New System.Drawing.Size(967, 311)
        Me.xtcReporteEstudio.TabIndex = 100
        Me.xtcReporteEstudio.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsuarios, Me.xtpFacturas, Me.xtpConsultas, Me.xtpProcedimientos})
        '
        'xtpUsuarios
        '
        Me.xtpUsuarios.Controls.Add(Me.GCUsuarios)
        Me.xtpUsuarios.Name = "xtpUsuarios"
        Me.xtpUsuarios.Size = New System.Drawing.Size(965, 286)
        Me.xtpUsuarios.Text = "USUARIOS"
        '
        'GCUsuarios
        '
        Me.GCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.GCUsuarios.MainView = Me.GVUsuarios
        Me.GCUsuarios.Name = "GCUsuarios"
        Me.GCUsuarios.Size = New System.Drawing.Size(965, 286)
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
        Me.xtpFacturas.Size = New System.Drawing.Size(965, 285)
        Me.xtpFacturas.Text = "FACTURAS"
        '
        'GCFacturas
        '
        Me.GCFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCFacturas.Location = New System.Drawing.Point(0, 0)
        Me.GCFacturas.MainView = Me.GVFacturas
        Me.GCFacturas.Name = "GCFacturas"
        Me.GCFacturas.Size = New System.Drawing.Size(965, 285)
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
        Me.xtpConsultas.Size = New System.Drawing.Size(965, 285)
        Me.xtpConsultas.Text = "CONSULTAS"
        '
        'GCConsultas
        '
        Me.GCConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultas.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultas.MainView = Me.GVConsultas
        Me.GCConsultas.Name = "GCConsultas"
        Me.GCConsultas.Size = New System.Drawing.Size(965, 285)
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
        Me.xtpProcedimientos.Size = New System.Drawing.Size(965, 285)
        Me.xtpProcedimientos.Text = "PROCEDIMIENTOS"
        '
        'GCProcedimientos
        '
        Me.GCProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProcedimientos.Location = New System.Drawing.Point(0, 0)
        Me.GCProcedimientos.MainView = Me.GVProcedimientos
        Me.GCProcedimientos.Name = "GCProcedimientos"
        Me.GCProcedimientos.Size = New System.Drawing.Size(965, 285)
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
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Nothing
        Me.BarDockControl7.Size = New System.Drawing.Size(1262, 0)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 594)
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.DockControls.Add(Me.BarDockControl5)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl6)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.bbiFacturas})
        Me.BarManager2.MaxItemId = 6
        Me.BarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rcboFacturas})
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl4.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(1264, 0)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 594)
        Me.BarDockControl5.Manager = Me.BarManager2
        Me.BarDockControl5.Size = New System.Drawing.Size(1264, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl6.Location = New System.Drawing.Point(1264, 0)
        Me.BarDockControl6.Manager = Me.BarManager2
        Me.BarDockControl6.Size = New System.Drawing.Size(0, 594)
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Generar RIPS"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Consultar"
        Me.BarButtonItem2.Enabled = False
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Imprimir"
        Me.BarButtonItem3.Enabled = False
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
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
        'Bar6
        '
        Me.Bar6.BarName = "Herramientas"
        Me.Bar6.DockCol = 0
        Me.Bar6.DockRow = 0
        Me.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar6.Text = "Herramientas"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Herramientas"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(86, 132)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)})
        Me.Bar3.Text = "Herramientas Facturas"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Herramientas"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bbiFacturas, "", False, True, True, 101)})
        Me.Bar5.Text = "Herramientas"
        '
        'Bar7
        '
        Me.Bar7.BarName = "Herramientas"
        Me.Bar7.DockCol = 0
        Me.Bar7.DockRow = 0
        Me.Bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bbiFacturas, "", False, True, True, 101)})
        Me.Bar7.Text = "Herramientas"
        '
        'Bar8
        '
        Me.Bar8.BarName = "Herramientas"
        Me.Bar8.DockCol = 0
        Me.Bar8.DockRow = 0
        Me.Bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bbiFacturas, "", False, True, True, 101)})
        Me.Bar8.Text = "Herramientas"
        '
        'BarManager3
        '
        Me.BarManager3.DockControls.Add(Me.BarDockControl8)
        Me.BarManager3.DockControls.Add(Me.BarDockControl9)
        Me.BarManager3.DockControls.Add(Me.BarDockControl10)
        Me.BarManager3.DockControls.Add(Me.BarDockControl11)
        Me.BarManager3.Form = Me
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl8.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl8.Manager = Me.BarManager3
        Me.BarDockControl8.Size = New System.Drawing.Size(1264, 0)
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 594)
        Me.BarDockControl9.Manager = Me.BarManager3
        Me.BarDockControl9.Size = New System.Drawing.Size(1264, 0)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl10.Manager = Me.BarManager3
        Me.BarDockControl10.Size = New System.Drawing.Size(0, 594)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl11.Location = New System.Drawing.Point(1264, 0)
        Me.BarDockControl11.Manager = Me.BarManager3
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 594)
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(914, 28)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 168
        Me.txtID.Visible = False
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(889, 31)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl31.TabIndex = 167
        Me.LabelControl31.Text = "ID:"
        Me.LabelControl31.Visible = False
        '
        'frmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 594)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.xtcFactura)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Controls.Add(Me.BarDockControl8)
        Me.IconOptions.Icon = CType(resources.GetObject("frmFacturas.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Factura"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcFactura.ResumeLayout(False)
        Me.xtpFacturasGeneradas.ResumeLayout(False)
        Me.xtpDetalleFactura.ResumeLayout(False)
        CType(Me.GCDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFacturaServicios.ResumeLayout(False)
        Me.xtpFacturaServicios.PerformLayout()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GCOrdenesAuditadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOrdenesAuditadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GCListadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalServicios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVAS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConceptoS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimientoS.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimientoS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaExpedicionS.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaExpedicionS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroFacturaS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFacturaProductos.ResumeLayout(False)
        Me.xtpFacturaProductos.PerformLayout()
        CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCuentasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCuentasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDescuentoP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVAP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarifaProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSonP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConceptoP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvComboProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpRips.ResumeLayout(False)
        Me.xtpRips.PerformLayout()
        CType(Me.GCRips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRips, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcboFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bFacturas As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboFactura As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bsiImprimir As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVistaPrevia As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDetalleFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFacturaConcepto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRelacionFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcFactura As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpFacturasGeneradas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpFacturaServicios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpFacturaProductos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDetalleFactura As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCDetalleFactura As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetalleFactura As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColDFFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFFechaFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFFechaOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFProcedimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFCodigoCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFNombreCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpRips As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtcReporteEstudio As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsuarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents xtpFacturas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFacturas As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents xtpConsultas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultas As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents xtpProcedimientos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCProcedimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFacturas As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rcboFacturas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Bar6 As DevExpress.XtraBars.Bar
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar7 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar8 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIVAS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubTotalS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConceptoS As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboContrato As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaVencimientoS As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaExpedicionS As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumeroFacturaS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEntidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnAgregarTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCOrdenesAuditadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOrdenesAuditadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDEN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSECUTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESPECIMEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUBENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOPAGO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GCDatosCliente As DevExpress.XtraGrid.GridControl
    Friend WithEvents TVDatosCliente As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTarifaProducto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSonP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConceptoP As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtFechaExpedicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDProductos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCodigoProducto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvComboProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPRESENTACIONPRODUCTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUnidadMedida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIDPRODUCTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSTOVENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFacturas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFContratoFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFNEtoFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGenerada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalServicios As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCListadoFactura As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListadoFactura As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLFID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFEspecimen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFSubEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiRips As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTIPOFACTURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiAgregarFacturaRips As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFacturaAgregarTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFacturaBorrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GCRips As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRips As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarFacturaRips As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarFacturasRips As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAgregarFacturasRips As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button1 As Button
    Friend WithEvents colIDPRESENTACIONPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtValorUnitarioP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidadP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRestaCantidad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSumaCantidad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIVAP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubTotalP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblMarca As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colINVENTARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CachedEjemplo1 As CachedEjemplo
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GCDetallePagoDocumento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetallePagoDocumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTODETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORDETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminarFormaPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFormaPagoValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregarFormaPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colFPDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCuentasClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCuentasClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl4 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnSeleccionarOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl5 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtTipoDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnVerOrdenServicio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLFTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
End Class

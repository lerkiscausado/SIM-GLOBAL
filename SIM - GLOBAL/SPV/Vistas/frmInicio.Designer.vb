<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnFactura = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCotizaciones = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTarifas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProductos = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnVentas = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnProveedores = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUsers = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEmpleados = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUnidadMedida = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCerrarSesion = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lcIDOrigen = New DevExpress.XtraEditors.LabelControl()
        Me.lcSerial = New DevExpress.XtraEditors.LabelControl()
        Me.lcNombreCliente = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btnOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.btnPacientes = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOptometria = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCaja = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOrdenServicio = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgenda = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAcercaDe = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAuditoria = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCajaMenor = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCompras = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOrdenCompra = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
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
        Me.bbiImprimir.Caption = "Exportar PDF"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Exportar a Excel"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1277, 0)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 649)
        '
        'btnFactura
        '
        Me.btnFactura.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFactura.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnFactura.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnFactura.Appearance.Options.UseBackColor = True
        Me.btnFactura.Appearance.Options.UseFont = True
        Me.btnFactura.Appearance.Options.UseForeColor = True
        Me.btnFactura.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFactura.AppearanceHovered.Options.UseBackColor = True
        Me.btnFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnFactura.ImageOptions.Image = CType(resources.GetObject("btnFactura.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFactura.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnFactura.Location = New System.Drawing.Point(574, 31)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(129, 110)
        Me.btnFactura.TabIndex = 0
        Me.btnFactura.Text = "Factura"
        '
        'btnCotizaciones
        '
        Me.btnCotizaciones.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCotizaciones.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnCotizaciones.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnCotizaciones.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCotizaciones.Appearance.Options.UseBackColor = True
        Me.btnCotizaciones.Appearance.Options.UseFont = True
        Me.btnCotizaciones.Appearance.Options.UseForeColor = True
        Me.btnCotizaciones.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCotizaciones.AppearanceHovered.Options.UseBackColor = True
        Me.btnCotizaciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCotizaciones.ImageOptions.Image = CType(resources.GetObject("btnCotizaciones.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCotizaciones.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCotizaciones.Location = New System.Drawing.Point(25, 31)
        Me.btnCotizaciones.Name = "btnCotizaciones"
        Me.btnCotizaciones.Size = New System.Drawing.Size(129, 110)
        Me.btnCotizaciones.TabIndex = 1
        Me.btnCotizaciones.Text = "Cotizaciones"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Movimientos"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 152)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Complementos"
        '
        'btnInventario
        '
        Me.btnInventario.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.btnInventario.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnInventario.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Appearance.Options.UseBackColor = True
        Me.btnInventario.Appearance.Options.UseFont = True
        Me.btnInventario.Appearance.Options.UseForeColor = True
        Me.btnInventario.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnInventario.AppearanceHovered.Options.UseBackColor = True
        Me.btnInventario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnInventario.ImageOptions.Image = CType(resources.GetObject("btnInventario.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInventario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnInventario.Location = New System.Drawing.Point(852, 31)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(129, 110)
        Me.btnInventario.TabIndex = 4
        Me.btnInventario.Text = "Inventario"
        '
        'btnTarifas
        '
        Me.btnTarifas.Appearance.BackColor = System.Drawing.Color.MediumPurple
        Me.btnTarifas.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnTarifas.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnTarifas.Appearance.Options.UseBackColor = True
        Me.btnTarifas.Appearance.Options.UseFont = True
        Me.btnTarifas.Appearance.Options.UseForeColor = True
        Me.btnTarifas.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnTarifas.AppearanceHovered.Options.UseBackColor = True
        Me.btnTarifas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnTarifas.ImageOptions.Image = CType(resources.GetObject("btnTarifas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTarifas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnTarifas.Location = New System.Drawing.Point(160, 171)
        Me.btnTarifas.Name = "btnTarifas"
        Me.btnTarifas.Size = New System.Drawing.Size(129, 110)
        Me.btnTarifas.TabIndex = 7
        Me.btnTarifas.Text = "Tarifas"
        '
        'btnProductos
        '
        Me.btnProductos.Appearance.BackColor = System.Drawing.Color.MediumPurple
        Me.btnProductos.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnProductos.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Appearance.Options.UseBackColor = True
        Me.btnProductos.Appearance.Options.UseFont = True
        Me.btnProductos.Appearance.Options.UseForeColor = True
        Me.btnProductos.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnProductos.AppearanceHovered.Options.UseBackColor = True
        Me.btnProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnProductos.ImageOptions.Image = CType(resources.GetObject("btnProductos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProductos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnProductos.Location = New System.Drawing.Point(25, 171)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(129, 110)
        Me.btnProductos.TabIndex = 6
        Me.btnProductos.Text = "Productos"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(852, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Reportes"
        '
        'btnVentas
        '
        Me.btnVentas.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.btnVentas.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnVentas.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Appearance.Options.UseBackColor = True
        Me.btnVentas.Appearance.Options.UseFont = True
        Me.btnVentas.Appearance.Options.UseForeColor = True
        Me.btnVentas.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnVentas.AppearanceHovered.Options.UseBackColor = True
        Me.btnVentas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnVentas.ImageOptions.Image = CType(resources.GetObject("btnVentas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVentas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnVentas.Location = New System.Drawing.Point(987, 31)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(129, 110)
        Me.btnVentas.TabIndex = 5
        Me.btnVentas.Text = "Ventas"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(295, 152)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Terceros"
        '
        'btnProveedores
        '
        Me.btnProveedores.Appearance.BackColor = System.Drawing.Color.Violet
        Me.btnProveedores.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnProveedores.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Appearance.Options.UseBackColor = True
        Me.btnProveedores.Appearance.Options.UseFont = True
        Me.btnProveedores.Appearance.Options.UseForeColor = True
        Me.btnProveedores.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnProveedores.AppearanceHovered.Options.UseBackColor = True
        Me.btnProveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnProveedores.ImageOptions.Image = CType(resources.GetObject("btnProveedores.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnProveedores.Location = New System.Drawing.Point(430, 171)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(129, 110)
        Me.btnProveedores.TabIndex = 9
        Me.btnProveedores.Text = "Proveedores"
        '
        'btnClientes
        '
        Me.btnClientes.Appearance.BackColor = System.Drawing.Color.Violet
        Me.btnClientes.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnClientes.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Appearance.Options.UseBackColor = True
        Me.btnClientes.Appearance.Options.UseFont = True
        Me.btnClientes.Appearance.Options.UseForeColor = True
        Me.btnClientes.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnClientes.AppearanceHovered.Options.UseBackColor = True
        Me.btnClientes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnClientes.ImageOptions.Image = CType(resources.GetObject("btnClientes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClientes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(295, 171)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(129, 110)
        Me.btnClientes.TabIndex = 8
        Me.btnClientes.Text = "Clientes"
        '
        'btnUsers
        '
        Me.btnUsers.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUsers.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnUsers.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Appearance.Options.UseBackColor = True
        Me.btnUsers.Appearance.Options.UseFont = True
        Me.btnUsers.Appearance.Options.UseForeColor = True
        Me.btnUsers.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnUsers.AppearanceHovered.Options.UseBackColor = True
        Me.btnUsers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnUsers.ImageOptions.Image = CType(resources.GetObject("btnUsers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUsers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnUsers.Location = New System.Drawing.Point(160, 451)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(129, 110)
        Me.btnUsers.TabIndex = 11
        Me.btnUsers.Text = "Usuarios"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(25, 432)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Configuracion"
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEmpleados.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnEmpleados.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnEmpleados.Appearance.Options.UseBackColor = True
        Me.btnEmpleados.Appearance.Options.UseFont = True
        Me.btnEmpleados.Appearance.Options.UseForeColor = True
        Me.btnEmpleados.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnEmpleados.AppearanceHovered.Options.UseBackColor = True
        Me.btnEmpleados.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnEmpleados.ImageOptions.Image = CType(resources.GetObject("btnEmpleados.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEmpleados.Location = New System.Drawing.Point(25, 451)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(129, 110)
        Me.btnEmpleados.TabIndex = 10
        Me.btnEmpleados.Text = "Empleados"
        '
        'btnUnidadMedida
        '
        Me.btnUnidadMedida.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUnidadMedida.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnUnidadMedida.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnUnidadMedida.Appearance.Options.UseBackColor = True
        Me.btnUnidadMedida.Appearance.Options.UseFont = True
        Me.btnUnidadMedida.Appearance.Options.UseForeColor = True
        Me.btnUnidadMedida.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnUnidadMedida.AppearanceHovered.Options.UseBackColor = True
        Me.btnUnidadMedida.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnUnidadMedida.ImageOptions.Image = CType(resources.GetObject("btnUnidadMedida.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUnidadMedida.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnUnidadMedida.Location = New System.Drawing.Point(295, 451)
        Me.btnUnidadMedida.Name = "btnUnidadMedida"
        Me.btnUnidadMedida.Size = New System.Drawing.Size(264, 110)
        Me.btnUnidadMedida.TabIndex = 12
        Me.btnUnidadMedida.Text = "Unidad de Medida"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnSalir.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Appearance.Options.UseBackColor = True
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseForeColor = True
        Me.btnSalir.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSalir.AppearanceHovered.Options.UseBackColor = True
        Me.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(987, 171)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(129, 110)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(852, 152)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Ventana"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Appearance.BackColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSesion.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnCerrarSesion.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Appearance.Options.UseBackColor = True
        Me.btnCerrarSesion.Appearance.Options.UseFont = True
        Me.btnCerrarSesion.Appearance.Options.UseForeColor = True
        Me.btnCerrarSesion.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCerrarSesion.AppearanceHovered.Options.UseBackColor = True
        Me.btnCerrarSesion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCerrarSesion.ImageOptions.Image = CType(resources.GetObject("btnCerrarSesion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCerrarSesion.Location = New System.Drawing.Point(852, 171)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(129, 110)
        Me.btnCerrarSesion.TabIndex = 13
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.lcIDOrigen)
        Me.PanelControl1.Controls.Add(Me.lcSerial)
        Me.PanelControl1.Controls.Add(Me.lcNombreCliente)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Location = New System.Drawing.Point(25, 569)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(408, 68)
        Me.PanelControl1.TabIndex = 26
        '
        'lcIDOrigen
        '
        Me.lcIDOrigen.Location = New System.Drawing.Point(73, 47)
        Me.lcIDOrigen.Name = "lcIDOrigen"
        Me.lcIDOrigen.Size = New System.Drawing.Size(0, 13)
        Me.lcIDOrigen.TabIndex = 11
        '
        'lcSerial
        '
        Me.lcSerial.Location = New System.Drawing.Point(94, 28)
        Me.lcSerial.Name = "lcSerial"
        Me.lcSerial.Size = New System.Drawing.Size(0, 13)
        Me.lcSerial.TabIndex = 10
        '
        'lcNombreCliente
        '
        Me.lcNombreCliente.Location = New System.Drawing.Point(230, 9)
        Me.lcNombreCliente.Name = "lcNombreCliente"
        Me.lcNombreCliente.Size = New System.Drawing.Size(0, 13)
        Me.lcNombreCliente.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 47)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "ID de Origen:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Numero de Serie:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(5, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(223, 13)
        Me.LabelControl9.TabIndex = 7
        Me.LabelControl9.Text = "Este Programa esta Registrado a Nombre de : "
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.SimpleButton1.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(1122, 31)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(129, 110)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = "Utilidad"
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Location = New System.Drawing.Point(945, 624)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(321, 13)
        Me.LabelControl10.TabIndex = 30
        Me.LabelControl10.Text = "ADOS Software Copyright © Todos los Derechos Reservados 2018"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Location = New System.Drawing.Point(1046, 571)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(219, 13)
        Me.LabelControl11.TabIndex = 29
        Me.LabelControl11.Text = "SPV Sistema Punto de Venta - Versión 5.1.0.1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(1196, 494)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(69, 67)
        Me.PictureEdit1.TabIndex = 31
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Location = New System.Drawing.Point(1028, 586)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(237, 13)
        Me.LabelControl12.TabIndex = 33
        Me.LabelControl12.Text = "Tel.  304 3535702 - soporte@ados-software.com"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Location = New System.Drawing.Point(1145, 605)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl13.TabIndex = 34
        Me.LabelControl13.Text = "www.ados-software.com"
        '
        'btnOrden
        '
        Me.btnOrden.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnOrden.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOrden.Appearance.Options.UseBackColor = True
        Me.btnOrden.Appearance.Options.UseFont = True
        Me.btnOrden.Appearance.Options.UseForeColor = True
        Me.btnOrden.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnOrden.AppearanceHovered.Options.UseBackColor = True
        Me.btnOrden.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnOrden.ImageOptions.Image = CType(resources.GetObject("btnOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrden.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOrden.Location = New System.Drawing.Point(25, 313)
        Me.btnOrden.Name = "btnOrden"
        Me.btnOrden.Size = New System.Drawing.Size(264, 110)
        Me.btnOrden.TabIndex = 38
        Me.btnOrden.Text = "Orden de Atencion"
        '
        'btnConsultar
        '
        Me.btnConsultar.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnConsultar.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnConsultar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Appearance.Options.UseBackColor = True
        Me.btnConsultar.Appearance.Options.UseFont = True
        Me.btnConsultar.Appearance.Options.UseForeColor = True
        Me.btnConsultar.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConsultar.AppearanceHovered.Options.UseBackColor = True
        Me.btnConsultar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnConsultar.ImageOptions.Image = CType(resources.GetObject("btnConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultar.Location = New System.Drawing.Point(295, 314)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(60, 51)
        Me.btnConsultar.TabIndex = 37
        Me.btnConsultar.ToolTip = "Consultar Ordenes"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(25, 294)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl14.TabIndex = 39
        Me.LabelControl14.Text = "Atencion en Salud"
        '
        'btnPacientes
        '
        Me.btnPacientes.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnPacientes.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnPacientes.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnPacientes.Appearance.Options.UseBackColor = True
        Me.btnPacientes.Appearance.Options.UseFont = True
        Me.btnPacientes.Appearance.Options.UseForeColor = True
        Me.btnPacientes.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnPacientes.AppearanceHovered.Options.UseBackColor = True
        Me.btnPacientes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnPacientes.ImageOptions.Image = CType(resources.GetObject("btnPacientes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPacientes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPacientes.Location = New System.Drawing.Point(295, 372)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(60, 51)
        Me.btnPacientes.TabIndex = 36
        Me.btnPacientes.ToolTip = "Registros de Pacientes"
        '
        'btnOptometria
        '
        Me.btnOptometria.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnOptometria.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnOptometria.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOptometria.Appearance.Options.UseBackColor = True
        Me.btnOptometria.Appearance.Options.UseFont = True
        Me.btnOptometria.Appearance.Options.UseForeColor = True
        Me.btnOptometria.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnOptometria.AppearanceHovered.Options.UseBackColor = True
        Me.btnOptometria.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnOptometria.ImageOptions.Image = CType(resources.GetObject("btnOptometria.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOptometria.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOptometria.Location = New System.Drawing.Point(430, 313)
        Me.btnOptometria.Name = "btnOptometria"
        Me.btnOptometria.Size = New System.Drawing.Size(129, 110)
        Me.btnOptometria.TabIndex = 40
        Me.btnOptometria.Text = "Optometria"
        '
        'btnCaja
        '
        Me.btnCaja.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCaja.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnCaja.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnCaja.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Appearance.Options.UseBackColor = True
        Me.btnCaja.Appearance.Options.UseFont = True
        Me.btnCaja.Appearance.Options.UseForeColor = True
        Me.btnCaja.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCaja.AppearanceHovered.Options.UseBackColor = True
        Me.btnCaja.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCaja.ImageOptions.Image = CType(resources.GetObject("btnCaja.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCaja.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCaja.Location = New System.Drawing.Point(295, 31)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(129, 110)
        Me.btnCaja.TabIndex = 42
        Me.btnCaja.Text = "Caja"
        '
        'btnOrdenServicio
        '
        Me.btnOrdenServicio.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnOrdenServicio.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnOrdenServicio.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnOrdenServicio.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOrdenServicio.Appearance.Options.UseBackColor = True
        Me.btnOrdenServicio.Appearance.Options.UseFont = True
        Me.btnOrdenServicio.Appearance.Options.UseForeColor = True
        Me.btnOrdenServicio.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnOrdenServicio.AppearanceHovered.Options.UseBackColor = True
        Me.btnOrdenServicio.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnOrdenServicio.ImageOptions.Image = CType(resources.GetObject("btnOrdenServicio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrdenServicio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOrdenServicio.Location = New System.Drawing.Point(160, 31)
        Me.btnOrdenServicio.Name = "btnOrdenServicio"
        Me.btnOrdenServicio.Size = New System.Drawing.Size(129, 110)
        Me.btnOrdenServicio.TabIndex = 44
        Me.btnOrdenServicio.Text = "Orden Servicio"
        '
        'btnAgenda
        '
        Me.btnAgenda.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAgenda.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnAgenda.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAgenda.Appearance.Options.UseBackColor = True
        Me.btnAgenda.Appearance.Options.UseFont = True
        Me.btnAgenda.Appearance.Options.UseForeColor = True
        Me.btnAgenda.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAgenda.AppearanceHovered.Options.UseBackColor = True
        Me.btnAgenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnAgenda.ImageOptions.Image = CType(resources.GetObject("btnAgenda.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgenda.Location = New System.Drawing.Point(364, 314)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(60, 51)
        Me.btnAgenda.TabIndex = 46
        Me.btnAgenda.ToolTip = "Registro de Agenda"
        '
        'btnAcercaDe
        '
        Me.btnAcercaDe.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnAcercaDe.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnAcercaDe.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAcercaDe.Appearance.Options.UseBackColor = True
        Me.btnAcercaDe.Appearance.Options.UseFont = True
        Me.btnAcercaDe.Appearance.Options.UseForeColor = True
        Me.btnAcercaDe.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAcercaDe.AppearanceHovered.Options.UseBackColor = True
        Me.btnAcercaDe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnAcercaDe.ImageOptions.Image = CType(resources.GetObject("btnAcercaDe.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAcercaDe.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAcercaDe.Location = New System.Drawing.Point(1122, 171)
        Me.btnAcercaDe.Name = "btnAcercaDe"
        Me.btnAcercaDe.Size = New System.Drawing.Size(60, 51)
        Me.btnAcercaDe.TabIndex = 48
        Me.btnAcercaDe.ToolTip = "Acerca de SIM"
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAuditoria.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnAuditoria.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAuditoria.Appearance.Options.UseBackColor = True
        Me.btnAuditoria.Appearance.Options.UseFont = True
        Me.btnAuditoria.Appearance.Options.UseForeColor = True
        Me.btnAuditoria.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAuditoria.AppearanceHovered.Options.UseBackColor = True
        Me.btnAuditoria.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnAuditoria.ImageOptions.Image = CType(resources.GetObject("btnAuditoria.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAuditoria.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAuditoria.Location = New System.Drawing.Point(364, 372)
        Me.btnAuditoria.Name = "btnAuditoria"
        Me.btnAuditoria.Size = New System.Drawing.Size(60, 51)
        Me.btnAuditoria.TabIndex = 50
        Me.btnAuditoria.ToolTip = "Auditoria de Sistema"
        '
        'btnCajaMenor
        '
        Me.btnCajaMenor.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCajaMenor.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnCajaMenor.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnCajaMenor.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCajaMenor.Appearance.Options.UseBackColor = True
        Me.btnCajaMenor.Appearance.Options.UseFont = True
        Me.btnCajaMenor.Appearance.Options.UseForeColor = True
        Me.btnCajaMenor.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCajaMenor.AppearanceHovered.Options.UseBackColor = True
        Me.btnCajaMenor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCajaMenor.ImageOptions.Image = CType(resources.GetObject("btnCajaMenor.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCajaMenor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCajaMenor.Location = New System.Drawing.Point(430, 31)
        Me.btnCajaMenor.Name = "btnCajaMenor"
        Me.btnCajaMenor.Size = New System.Drawing.Size(138, 110)
        Me.btnCajaMenor.TabIndex = 52
        Me.btnCajaMenor.Text = "Caja Menor"
        '
        'btnCompras
        '
        Me.btnCompras.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCompras.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnCompras.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnCompras.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Appearance.Options.UseBackColor = True
        Me.btnCompras.Appearance.Options.UseFont = True
        Me.btnCompras.Appearance.Options.UseForeColor = True
        Me.btnCompras.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCompras.AppearanceHovered.Options.UseBackColor = True
        Me.btnCompras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCompras.ImageOptions.Image = CType(resources.GetObject("btnCompras.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCompras.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCompras.Location = New System.Drawing.Point(709, 31)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(60, 51)
        Me.btnCompras.TabIndex = 54
        Me.btnCompras.ToolTip = "Compras"
        '
        'btnOrdenCompra
        '
        Me.btnOrdenCompra.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnOrdenCompra.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnOrdenCompra.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnOrdenCompra.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOrdenCompra.Appearance.Options.UseBackColor = True
        Me.btnOrdenCompra.Appearance.Options.UseFont = True
        Me.btnOrdenCompra.Appearance.Options.UseForeColor = True
        Me.btnOrdenCompra.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnOrdenCompra.AppearanceHovered.Options.UseBackColor = True
        Me.btnOrdenCompra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnOrdenCompra.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrdenCompra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnOrdenCompra.Location = New System.Drawing.Point(775, 31)
        Me.btnOrdenCompra.Name = "btnOrdenCompra"
        Me.btnOrdenCompra.Size = New System.Drawing.Size(60, 51)
        Me.btnOrdenCompra.TabIndex = 56
        Me.btnOrdenCompra.ToolTip = "Orden Compra"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 649)
        Me.Controls.Add(Me.btnOrdenCompra)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btnCajaMenor)
        Me.Controls.Add(Me.btnAuditoria)
        Me.Controls.Add(Me.btnAcercaDe)
        Me.Controls.Add(Me.btnAgenda)
        Me.Controls.Add(Me.btnOrdenServicio)
        Me.Controls.Add(Me.btnCaja)
        Me.Controls.Add(Me.btnOptometria)
        Me.Controls.Add(Me.btnOrden)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.btnPacientes)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnUnidadMedida)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.btnTarifas)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnCotizaciones)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCotizaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTarifas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnVentas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnProveedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUsers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEmpleados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUnidadMedida As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCerrarSesion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lcIDOrigen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcSerial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcNombreCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPacientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOptometria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCaja As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOrdenServicio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgenda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAcercaDe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAuditoria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCajaMenor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCompras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOrdenCompra As DevExpress.XtraEditors.SimpleButton
End Class

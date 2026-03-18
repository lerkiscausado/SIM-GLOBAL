<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrPatologiaNuestra
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrPatologiaNuestra))
        Dim ShapeRectangle3 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDiagnostico = New DevExpress.XtraReports.UI.XRRichText()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNombreEntidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrShape3 = New DevExpress.XtraReports.UI.XRShape()
        Me.lblSolicitado = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTipoMuestra = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblEntidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFechaSalida = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFechaIngreso = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblConsecutivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblDireccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSexo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblEdad = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTelefono = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblIdentificacion = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.lblInforme = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescripcionMacroscopica = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.lblMedico = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblEspecialidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblRegistroMedico = New DevExpress.XtraReports.UI.XRLabel()
        Me.picFirma = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.lblSede = New DevExpress.XtraReports.UI.XRLabel()
        Me.DsCD1 = New SIM___GLOBAL.dsCD()
        Me.ReportePatologiaCDTableAdapter = New SIM___GLOBAL.dsCDTableAdapters.ReportePatologiaCDTableAdapter()
        CType(Me.xrDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 30.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 27.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel33, Me.xrDiagnostico})
        Me.Detail.HeightF = 73.95039!
        Me.Detail.Name = "Detail"
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(0.00008637051!, 29.11405!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(740.9435!, 43.75471!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = resources.GetString("XrLabel33.Text")
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'xrDiagnostico
        '
        Me.xrDiagnostico.CanShrink = True
        Me.xrDiagnostico.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrDiagnostico.LocationFloat = New DevExpress.Utils.PointFloat(1.886792!, 0!)
        Me.xrDiagnostico.Name = "xrDiagnostico"
        Me.xrDiagnostico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDiagnostico.SerializableRtfString = resources.GetString("xrDiagnostico.SerializableRtfString")
        Me.xrDiagnostico.SizeF = New System.Drawing.SizeF(740.9435!, 23.0!)
        Me.xrDiagnostico.StylePriority.UseFont = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrLabel36, Me.lblNombreEntidad, Me.XrPictureBox1})
        Me.ReportHeader.HeightF = 100.4167!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(582.3019!, 12.62265!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(170.585!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrPageInfo2.TextFormatString = "{0:dddd, d 'de' MMMM 'de' yyyy}"
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel36.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(659.8115!, 0!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(93.07538!, 12.62265!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Fecha Impresión"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblNombreEntidad
        '
        Me.lblNombreEntidad.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreEntidad.LocationFloat = New DevExpress.Utils.PointFloat(0!, 35.62265!)
        Me.lblNombreEntidad.Multiline = True
        Me.lblNombreEntidad.Name = "lblNombreEntidad"
        Me.lblNombreEntidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNombreEntidad.SizeF = New System.Drawing.SizeF(754.0!, 22.99999!)
        Me.lblNombreEntidad.StylePriority.UseFont = False
        Me.lblNombreEntidad.StylePriority.UseTextAlignment = False
        Me.lblNombreEntidad.Text = "LABORATORIO DE PATOLOGIA [NOMBRE_ENTIDAD]"
        Me.lblNombreEntidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(200.0!, 100.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblSolicitado, Me.XrLabel30, Me.lblTipoMuestra, Me.lblEntidad, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrPanel2, Me.lblConsecutivo, Me.XrLabel18, Me.lblInforme, Me.lblDescripcionMacroscopica, Me.XrLine1, Me.XrPanel1, Me.XrShape1, Me.XrShape2, Me.XrShape3})
        Me.PageHeader.HeightF = 167.9246!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrShape3
        '
        Me.XrShape3.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrShape3.ForeColor = System.Drawing.Color.Gainsboro
        Me.XrShape3.LocationFloat = New DevExpress.Utils.PointFloat(2.0!, 73.43392!)
        Me.XrShape3.Name = "XrShape3"
        ShapeRectangle3.Fillet = 10
        Me.XrShape3.Shape = ShapeRectangle3
        Me.XrShape3.SizeF = New System.Drawing.SizeF(741.0!, 56.56611!)
        Me.XrShape3.StylePriority.UseBorderColor = False
        Me.XrShape3.StylePriority.UseForeColor = False
        '
        'lblSolicitado
        '
        Me.lblSolicitado.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblSolicitado.LocationFloat = New DevExpress.Utils.PointFloat(559.7925!, 76.00002!)
        Me.lblSolicitado.Multiline = True
        Me.lblSolicitado.Name = "lblSolicitado"
        Me.lblSolicitado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSolicitado.SizeF = New System.Drawing.SizeF(163.2075!, 17.0!)
        Me.lblSolicitado.StylePriority.UseFont = False
        Me.lblSolicitado.Text = "lblSolicitado"
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel30.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(451.8301!, 76.00002!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(107.9624!, 17.0!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.Text = "Remitente Dr(a):"
        '
        'lblTipoMuestra
        '
        Me.lblTipoMuestra.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblTipoMuestra.LocationFloat = New DevExpress.Utils.PointFloat(102.8301!, 93.00002!)
        Me.lblTipoMuestra.Multiline = True
        Me.lblTipoMuestra.Name = "lblTipoMuestra"
        Me.lblTipoMuestra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTipoMuestra.SizeF = New System.Drawing.SizeF(620.1699!, 17.0!)
        Me.lblTipoMuestra.StylePriority.UseFont = False
        Me.lblTipoMuestra.Text = "lblTipoMuestra"
        '
        'lblEntidad
        '
        Me.lblEntidad.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblEntidad.LocationFloat = New DevExpress.Utils.PointFloat(101.8301!, 76.00002!)
        Me.lblEntidad.Multiline = True
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEntidad.SizeF = New System.Drawing.SizeF(350.0!, 17.0!)
        Me.lblEntidad.StylePriority.UseFont = False
        Me.lblEntidad.Text = "lblEntidad"
        '
        'XrLabel26
        '
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(9.000006!, 110.0!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(135.1132!, 17.0!)
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "Impresión Diagnostica:"
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(9.000008!, 93.00002!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(92.83015!, 17.0!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.Text = "Espécimen:"
        '
        'XrShape2
        '
        Me.XrShape2.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrShape2.ForeColor = System.Drawing.Color.Gainsboro
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(582.6793!, 17.62265!)
        Me.XrShape2.Name = "XrShape2"
        ShapeRectangle2.Fillet = 10
        Me.XrShape2.Shape = ShapeRectangle2
        Me.XrShape2.SizeF = New System.Drawing.SizeF(162.2642!, 50.81137!)
        Me.XrShape2.StylePriority.UseBorderColor = False
        Me.XrShape2.StylePriority.UseForeColor = False
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(9.000006!, 76.00002!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(92.83015!, 17.0!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "Atendido en:"
        '
        'XrPanel2
        '
        Me.XrPanel2.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel35, Me.lblFechaSalida, Me.lblFechaIngreso, Me.XrLabel21, Me.XrLabel20})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(582.3019!, 21.0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(162.2642!, 42.0!)
        Me.XrPanel2.StylePriority.UseBorderColor = False
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(75.24542!, 28.00002!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(83.01874!, 13.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel35.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 28.00002!)
        Me.XrLabel35.Multiline = True
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(69.24542!, 13.0!)
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "No. de Página:"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblFechaSalida.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblFechaSalida.LocationFloat = New DevExpress.Utils.PointFloat(75.24542!, 15.00002!)
        Me.lblFechaSalida.Multiline = True
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFechaSalida.SizeF = New System.Drawing.SizeF(83.01886!, 13.0!)
        Me.lblFechaSalida.StylePriority.UseBorders = False
        Me.lblFechaSalida.StylePriority.UseFont = False
        Me.lblFechaSalida.StylePriority.UseTextAlignment = False
        Me.lblFechaSalida.Text = "lblFechaSalida"
        Me.lblFechaSalida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.lblFechaSalida.TextFormatString = "{0:d}"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblFechaIngreso.LocationFloat = New DevExpress.Utils.PointFloat(75.24542!, 2.000015!)
        Me.lblFechaIngreso.Multiline = True
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFechaIngreso.SizeF = New System.Drawing.SizeF(83.01886!, 13.0!)
        Me.lblFechaIngreso.StylePriority.UseBorders = False
        Me.lblFechaIngreso.StylePriority.UseFont = False
        Me.lblFechaIngreso.StylePriority.UseTextAlignment = False
        Me.lblFechaIngreso.Text = "lblFechaIngreso"
        Me.lblFechaIngreso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.lblFechaIngreso.TextFormatString = "{0:d}"
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 15.00002!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(69.24542!, 13.0!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Fecha Salida:"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 2.000015!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(69.24542!, 13.0!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Fecha Ingreso:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblConsecutivo.LocationFloat = New DevExpress.Utils.PointFloat(644.9434!, 0!)
        Me.lblConsecutivo.Multiline = True
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblConsecutivo.SizeF = New System.Drawing.SizeF(100.0!, 21.0!)
        Me.lblConsecutivo.StylePriority.UseFont = False
        Me.lblConsecutivo.StylePriority.UseTextAlignment = False
        Me.lblConsecutivo.Text = "lblConsecutivo"
        Me.lblConsecutivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(582.3019!, 5.0!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(62.64154!, 12.62265!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "Estudio No:"
        '
        'XrPanel1
        '
        Me.XrPanel1.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDireccion, Me.lblSexo, Me.XrLabel15, Me.lblEdad, Me.XrLabel13, Me.XrLabel12, Me.lblTelefono, Me.lblIdentificacion, Me.lblNombre, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(578.3019!, 71.81137!)
        Me.XrPanel1.StylePriority.UseBorderColor = False
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'lblDireccion
        '
        Me.lblDireccion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblDireccion.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblDireccion.LocationFloat = New DevExpress.Utils.PointFloat(265.3018!, 41.62267!)
        Me.lblDireccion.Multiline = True
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDireccion.SizeF = New System.Drawing.SizeF(303.0001!, 17.0!)
        Me.lblDireccion.StylePriority.UseBorders = False
        Me.lblDireccion.StylePriority.UseFont = False
        Me.lblDireccion.Text = "lblDireccion"
        '
        'lblSexo
        '
        Me.lblSexo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblSexo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblSexo.LocationFloat = New DevExpress.Utils.PointFloat(468.3019!, 23.00002!)
        Me.lblSexo.Multiline = True
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSexo.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.lblSexo.StylePriority.UseBorders = False
        Me.lblSexo.StylePriority.UseFont = False
        Me.lblSexo.Text = "lblSexo"
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(422.6416!, 23.00002!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(45.66034!, 17.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "Sexo:"
        '
        'lblEdad
        '
        Me.lblEdad.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblEdad.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblEdad.LocationFloat = New DevExpress.Utils.PointFloat(265.3018!, 23.00002!)
        Me.lblEdad.Multiline = True
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEdad.SizeF = New System.Drawing.SizeF(118.8679!, 17.0!)
        Me.lblEdad.StylePriority.UseBorders = False
        Me.lblEdad.StylePriority.UseFont = False
        Me.lblEdad.Text = "lblEdad"
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(199.8302!, 41.62267!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(65.47168!, 17.0!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Entidad:"
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(199.8302!, 23.00002!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(45.66034!, 17.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "Edad:"
        '
        'lblTelefono
        '
        Me.lblTelefono.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTelefono.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblTelefono.LocationFloat = New DevExpress.Utils.PointFloat(99.83017!, 41.62267!)
        Me.lblTelefono.Multiline = True
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTelefono.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.lblTelefono.StylePriority.UseBorders = False
        Me.lblTelefono.StylePriority.UseFont = False
        Me.lblTelefono.Text = "lblTelefono"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblIdentificacion.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblIdentificacion.LocationFloat = New DevExpress.Utils.PointFloat(99.83017!, 23.00002!)
        Me.lblIdentificacion.Multiline = True
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblIdentificacion.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.lblIdentificacion.StylePriority.UseBorders = False
        Me.lblIdentificacion.StylePriority.UseFont = False
        Me.lblIdentificacion.Text = "lblIdentificacion"
        '
        'lblNombre
        '
        Me.lblNombre.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.LocationFloat = New DevExpress.Utils.PointFloat(99.83017!, 6.000015!)
        Me.lblNombre.Multiline = True
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNombre.SizeF = New System.Drawing.SizeF(363.2076!, 17.0!)
        Me.lblNombre.StylePriority.UseBorders = False
        Me.lblNombre.StylePriority.UseFont = False
        Me.lblNombre.Text = "lblNombre"
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(7.000006!, 41.62267!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(92.83015!, 17.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Telefono:"
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(7.000006!, 23.00001!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(92.83015!, 17.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Identificacion:"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(7.000019!, 5.999998!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(92.83014!, 17.00001!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Nombre:"
        '
        'XrShape1
        '
        Me.XrShape1.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrShape1.ForeColor = System.Drawing.Color.Gainsboro
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrShape1.Name = "XrShape1"
        ShapeRectangle1.Fillet = 10
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.SizeF = New System.Drawing.SizeF(578.3019!, 70.56606!)
        Me.XrShape1.StylePriority.UseBorderColor = False
        Me.XrShape1.StylePriority.UseForeColor = False
        '
        'lblInforme
        '
        Me.lblInforme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInforme.LocationFloat = New DevExpress.Utils.PointFloat(1.999995!, 144.9246!)
        Me.lblInforme.Multiline = True
        Me.lblInforme.Name = "lblInforme"
        Me.lblInforme.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblInforme.SizeF = New System.Drawing.SizeF(738.9435!, 23.0!)
        Me.lblInforme.StylePriority.UseFont = False
        Me.lblInforme.StylePriority.UseTextAlignment = False
        Me.lblInforme.Text = "INFORME ANATOMOPATOLOGICO No. [CONSECUTIVO]"
        Me.lblInforme.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblDescripcionMacroscopica
        '
        Me.lblDescripcionMacroscopica.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblDescripcionMacroscopica.LocationFloat = New DevExpress.Utils.PointFloat(143.4906!, 110.0!)
        Me.lblDescripcionMacroscopica.Multiline = True
        Me.lblDescripcionMacroscopica.Name = "lblDescripcionMacroscopica"
        Me.lblDescripcionMacroscopica.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDescripcionMacroscopica.SizeF = New System.Drawing.SizeF(579.5094!, 17.0!)
        Me.lblDescripcionMacroscopica.StylePriority.UseFont = False
        Me.lblDescripcionMacroscopica.Text = "lblDescripcionMacroscopica"
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.Maroon
        Me.XrLine1.BorderWidth = 4.0!
        Me.XrLine1.ForeColor = System.Drawing.Color.Maroon
        Me.XrLine1.LineWidth = 4.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 130.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(713.0001!, 14.92458!)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblMedico, Me.lblEspecialidad, Me.lblRegistroMedico, Me.picFirma})
        Me.ReportFooter.Name = "ReportFooter"
        '
        'lblMedico
        '
        Me.lblMedico.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblMedico.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMedico.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 38.15097!)
        Me.lblMedico.Multiline = True
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMedico.SizeF = New System.Drawing.SizeF(210.3773!, 17.53794!)
        Me.lblMedico.StylePriority.UseBorders = False
        Me.lblMedico.StylePriority.UseFont = False
        Me.lblMedico.Text = "lblMedico"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblEspecialidad.LocationFloat = New DevExpress.Utils.PointFloat(9.999977!, 55.6889!)
        Me.lblEspecialidad.Multiline = True
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEspecialidad.SizeF = New System.Drawing.SizeF(255.3019!, 12.62265!)
        Me.lblEspecialidad.StylePriority.UseFont = False
        Me.lblEspecialidad.Text = "lblEspecialidad"
        '
        'lblRegistroMedico
        '
        Me.lblRegistroMedico.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblRegistroMedico.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 68.68905!)
        Me.lblRegistroMedico.Multiline = True
        Me.lblRegistroMedico.Name = "lblRegistroMedico"
        Me.lblRegistroMedico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRegistroMedico.SizeF = New System.Drawing.SizeF(397.9434!, 19.99982!)
        Me.lblRegistroMedico.StylePriority.UseFont = False
        Me.lblRegistroMedico.Text = "lblRegistroMedico"
        '
        'picFirma
        '
        Me.picFirma.LocationFloat = New DevExpress.Utils.PointFloat(42.3962!, 10.0!)
        Me.picFirma.Name = "picFirma"
        Me.picFirma.SizeF = New System.Drawing.SizeF(76.90567!, 36.15095!)
        Me.picFirma.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblSede})
        Me.PageFooter.HeightF = 26.04167!
        Me.PageFooter.Name = "PageFooter"
        '
        'lblSede
        '
        Me.lblSede.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblSede.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblSede.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblSede.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lblSede.Multiline = True
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSede.SizeF = New System.Drawing.SizeF(743.0001!, 24.27662!)
        Me.lblSede.StylePriority.UseBorderColor = False
        Me.lblSede.StylePriority.UseBorders = False
        Me.lblSede.StylePriority.UseFont = False
        Me.lblSede.StylePriority.UseTextAlignment = False
        Me.lblSede.Text = "[sede]"
        Me.lblSede.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DsCD1
        '
        Me.DsCD1.DataSetName = "dsCD"
        Me.DsCD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportePatologiaCDTableAdapter
        '
        Me.ReportePatologiaCDTableAdapter.ClearBeforeFill = True
        '
        'xrPatologiaNuestra
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DsCD1})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(46, 50, 30, 27)
        Me.Version = "20.1"
        CType(Me.xrDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNombreEntidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrShape3 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblSolicitado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTipoMuestra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEntidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFechaSalida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFechaIngreso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblConsecutivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblDireccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSexo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEdad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTelefono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblIdentificacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblInforme As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDescripcionMacroscopica As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDiagnostico As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents picFirma As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents lblMedico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEspecialidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRegistroMedico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblSede As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsCD1 As dsCD
    Friend WithEvents ReportePatologiaCDTableAdapter As dsCDTableAdapters.ReportePatologiaCDTableAdapter
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class

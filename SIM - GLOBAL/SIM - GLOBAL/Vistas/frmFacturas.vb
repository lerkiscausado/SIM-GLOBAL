Imports DevExpress.XtraGrid.Views.Grid
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class frmFacturas
    Dim _Id As New Guid
    Dim _IdDetallePagoRecibo As New Guid
    Dim _ds As DataSet
    Dim _dsP As DataSet
    Dim _dsC As DataSet
    Dim _Facturas As New Facturas
    Dim _DFacturas As New DFacturas
    Dim _DContratos As New DContratos
    Dim _DOrdenes As New DOrdenes
    Dim _DClientes = New SIM___GLOBAL.Controles.DClientes
    Dim _CuentasClientes As New SIM___GLOBAL.Modelo.CuentasClientes
    Dim _DCuentasClientes As New SIM___GLOBAL.Controles.DCuentasClientes
    Dim _DTarifas = New DTarifaProductos
    Dim _DDetalleTarifaProductos = New DDetalleTarifaProductos
    Dim _DCotizaciones As New DCotizaciones
    Dim _DInventario As New DInventario
    Dim _DetalleFacturaProductos As New DetalleFacturaProductos
    Dim _DDetalleFacturaProductos As New DDetalleFacturaProductos
    Dim _Inventario As New Inventario
    Dim _DRips As New SIM___GLOBAL.Controles.DRips
    Dim _DRipsJSON As New SIM___GLOBAL.Controles.DRipsJSON
    Dim _PresentacionProductos As New SIM___GLOBAL.Modelo.PresentacionProductos
    Dim _DPresentacionProductos As New DPresentacionProductos
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim _DetalleCuentaCliente As New SIM___GLOBAL.Modelo.DetalleCuentaCliente
    Dim _DDetalleCuentaCliente As New SIM___GLOBAL.Controles.DDetalleCuentaCliente
    Dim _DDetalleordenservicio As New DDetalleOrdenServicio
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir

    Public Licencia As String
    Public IDEmpleado As String
    ReadOnly _funciones As New Funciones
    '-----------------------------------
    Dim _ClickGrillaFacturas As String
    Dim _ClickGrillaProductos As String
    Dim _ClickGrillaOrdenesAuditadas As String
    Dim _ClickGrillaOrdenesFacturar As String
    Dim _ClickGrillaTipoFactura As String
    Dim _ClickCuentasClientes As String
    Dim _EstadoFactura As String
    Dim _Fila As String
    Dim TipoFactura As String

    Dim SaldoActualProducto As Double = 0
    Dim CostoVenta As Double = 0
    Dim CantidadProducto As Double = 0
    Dim Inventario As String
    Dim IdSaldoCliente As String
    Dim _ClickDetallePago As String
    ' Serializar a JSON
    Dim json As String
    Private Sub HighlightJsonSyntax(rtb As RichTextBox)
        ' Guardamos la posición del cursor
        Dim selectionStart = rtb.SelectionStart
        Dim selectionLength = rtb.SelectionLength

        rtb.SuspendLayout()
        rtb.SelectAll()
        rtb.SelectionColor = Color.Black

        ' Palabras clave (true, false, null)
        HighlightRegex(rtb, "\b(true|false|null)\b", Color.Blue)

        ' Strings (entre comillas)
        HighlightRegex(rtb, """(\\.|[^""])*""", Color.Brown)

        ' Números
        HighlightRegex(rtb, "\b\d+(\.\d+)?\b", Color.DarkCyan)

        ' Llaves y corchetes
        HighlightRegex(rtb, "[\{\}\[\]]", Color.Purple)

        ' Dos puntos y comas
        HighlightRegex(rtb, "[:,]", Color.Gray)

        ' Restauramos la selección original
        rtb.SelectionStart = selectionStart
        rtb.SelectionLength = selectionLength
        rtb.SelectionColor = Color.Black
        rtb.ResumeLayout()
    End Sub
    Private Sub HighlightRegex(rtb As RichTextBox, pattern As String, color As Color)
        Dim matches = Regex.Matches(rtb.Text, pattern)
        For Each m As RegularExpressions.Match In matches
            rtb.Select(m.Index, m.Length)
            rtb.SelectionColor = color
        Next
    End Sub
    Private Sub RIPS()
        Dim fs As FileStream
        ':::Ruta donde crearemos nuestro archivo txt
        Dim ruta As String = "C:\RIPS\" & GVFacturas.GetRowCellValue(0, "FACTURA").ToString() & "\"
        ':::Nombre del archivo
        Dim archivo As String = "000000" & GVFacturas.GetRowCellValue(0, "FACTURA").ToString()
        ' CREAMOS NOMBRE DE ARCHIVOS
        Dim USarchivo As String = "US" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim ACarchivo As String = "AC" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim AParchivo As String = "AP" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim AFarchivo As String = "AF" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim CTarchivo As String = "CT" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"

        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then
                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & USarchivo)
                fs.Close()
                fs = File.Create(ruta & ACarchivo)
                fs.Close()
                fs = File.Create(ruta & AParchivo)
                fs.Close()
                fs = File.Create(ruta & AFarchivo)
                fs.Close()
                fs = File.Create(ruta & CTarchivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            Else
                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)
                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & USarchivo)
                fs.Close()
                fs = File.Create(ruta & ACarchivo)
                fs.Close()
                fs = File.Create(ruta & AParchivo)
                fs.Close()
                fs = File.Create(ruta & AFarchivo)
                fs.Close()
                fs = File.Create(ruta & CTarchivo)
                fs.Close()
                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
        ' ESCRIBIMOS DENTRO DE LOS ARCHIVOS

        ' CREAMOS VARIABLES PARA ESCRIBIR ARCHIVOS
        Dim USescribir As New StreamWriter(ruta & USarchivo)
        Dim ACescribir As New StreamWriter(ruta & ACarchivo)
        Dim APescribir As New StreamWriter(ruta & AParchivo)
        Dim AFescribir As New StreamWriter(ruta & AFarchivo)
        Dim CTescribir As New StreamWriter(ruta & CTarchivo)
        Try
            'ESCRIBIMOS ARCHIVO AF
            AFescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "PRESTADOR").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "TIPO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "IDENTIFICACION").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "FACTURA").ToString() &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "INGRESO"), "dd/MM/yyyy") &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "FINAL"), "dd/MM/yyyy") &
                                 "," & GVFacturas.GetRowCellValue(0, "CODIGO_ENTIDAD").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "ENTIDAD").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "CONTRATO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "PLAN").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "POLIZA").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "COPAGO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "COMISION").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "DESCUENTO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "NETO").ToString() &
                                 "")
            AFescribir.Close()

            'ESCRIBIMOS EL ARCHIVO CT
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(AFarchivo, 1, 8) & "," & GVFacturas.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(USarchivo, 1, 8) & "," & GVUsuarios.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(ACarchivo, 1, 8) & "," & GVConsultas.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(AParchivo, 1, 8) & "," & GVProcedimientos.RowCount)
            CTescribir.Close()

            'ESCRIBIMOS EL ARCHIVO US
            For x As Integer = 0 To GVUsuarios.RowCount - 1
                USescribir.WriteLine(GVUsuarios.GetRowCellValue(x, "ID_TIPO_IDENTIFICACION").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "CODIGO_ENTIDAD").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "CODIGO_TIPO_USUARIO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "PRIMER_APELLIDO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEGUNDO_APELLIDO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "PRIMER_NOMBRE").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEGUNDO_NOMBRE").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "EDAD").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "MEDIDA").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEXO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "DEPARTAMENTO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "MUNICIPIO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "ZONA").ToString &
                                     "")
            Next
            USescribir.Close()

            'ESCRIBIMOS EL ARCHIVO AC
            For x As Integer = 0 To GVConsultas.RowCount - 1
                ACescribir.WriteLine(GVConsultas.GetRowCellValue(x, "FACTURA").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "PRESTADOR").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "TIPO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & Format(GVConsultas.GetRowCellValue(x, "FECHA"), "dd/MM/yyyy") &
                                     "," & GVConsultas.GetRowCellValue(x, "AUTORIZACION").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CODIGO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "FINALIDAD").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CAUSA").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CIE10").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D1").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D2").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D3").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "ID_TIPO_DIAGNOSTICO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "VALOR").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "COPAGO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "NETO").ToString &
                                     "")
            Next
            ACescribir.Close()

            'ESCRIBIMOS EL ARCHIVO AP
            For x As Integer = 0 To GVProcedimientos.RowCount - 1
                APescribir.WriteLine(GVProcedimientos.GetRowCellValue(x, "FACTURA").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "PRESTADOR").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "TIPO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & Format(GVProcedimientos.GetRowCellValue(x, "FECHA"), "dd/MM/yyyy") &
                                     "," & GVProcedimientos.GetRowCellValue(x, "AUTORIZACION").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "CODIGO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "AMBITO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "FINALIDAD").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "ATIENDE").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "CIE10").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "D1").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "D2").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "REALIZACION").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "NETO").ToString &
                                     "")
            Next
            APescribir.Close()

            MsgBox("Archivos PLANOS generados correctamente", MsgBoxStyle.Information, "RIPS")
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Private Sub GuardarNotaCreditoInventario(ByVal IdProducto As String, ByVal IdMarca As String, ByVal IdPresentacionProducto As String, ByVal Cantidad As Double, ByVal ValorUnitario As Double, ByVal SaldoCantidad As Double, ByVal SaldoTotal As Double, ByVal ValorPromedio As Double)
        _Inventario.Fecha = DateTime.Now
        _Inventario.Hora = DateTime.Now
        _Inventario.IdDocumento = Val("1")
        _Inventario.IdProducto = Val(IdProducto)
        _Inventario.IdMarca = Val(IdMarca)
        _Inventario.IdPresentacionProducto = Val(IdPresentacionProducto)
        _Inventario.Movimiento = "C"
        _Inventario.Factura = Val("")
        _Inventario.Observacion = "."
        _Inventario.EntradaCantidad = Cantidad
        _Inventario.EntradaValor = ValorUnitario
        _Inventario.SalidaCantidad = 0
        _Inventario.SalidaValor = 0
        _Inventario.SaldoCantidad = SaldoCantidad
        _Inventario.SaldoTotal = SaldoTotal
        _Inventario.ValorPromedio = ValorPromedio
        _Inventario.IdEmpleado = IDEmpleado
        _Inventario.Estado = "A"
        '_idDetalleOrden = _dHistoria.GuardarHistoriayDetalle(_DetalleOrden, _Historia)
        _DInventario.Guardar(_Inventario)
        'MsgBox(_idDetalleOrden)
    End Sub

    Private Sub ActivaGuardar()
        If GVListadoFactura.RowCount <> 0 Then
            bbiGuardar.Enabled = True
            txtNumeroFacturaS.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        Select Case Licencia
            Case 12, 13, 15 'Aquamedical
                _ds = _DFacturas.ListarFacturaProductos
                GCConsultar.DataSource = _ds.Tables(0)
            Case Else
                _ds = _DFacturas.ListarFacturaServicios
                GCConsultar.DataSource = _ds.Tables(0)
                _ds = New DataSet
                _ds = _DFacturas.ListarDetalleFactura
                GCDetalleFactura.DataSource = _ds.Tables(0)
        End Select
    End Sub

    Private Sub NuevaFactura()
        'Factura de Servicios
        dtFechaExpedicionS.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaVencimientoS.Text = Format(DateTime.Now, "dd/MM/yyyy")

        txtEntidad.Text = Nothing
        txtNit.Text = Nothing
        txtTelefono.Text = Nothing
        txtDireccion.Text = Nothing
        txtNumeroFacturaS.Text = Nothing

        txtConceptoS.Text = Nothing
        txtSubTotalS.Text = ""
        txtDescuentoS.Text = ""
        txtIVAS.Text = ""
        txtTotalServicios.Text = ""
        txtSon.Text = Nothing

        GCOrdenesAuditadas.DataSource = Nothing
        GCListadoFactura.DataSource = Nothing
        GCDetallePagoDocumento.DataSource = Nothing
        cboContrato.EditValue = Nothing

        'Factura de Productos
        dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

        cboCliente.EditValue = Nothing
        'txtFacturaP.Text = Nothing
        cboTarifaProducto.EditValue = Nothing
        GCDatosCliente.DataSource = Nothing
        txtConceptoP.Text = Nothing
        txtSonP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotalP.Text = Nothing
        txtDescuentoP.Text = Nothing
        txtIVAP.Text = Nothing
        txtTotalP.Text = Nothing
        txtID.Text = Nothing
        _Id = Nothing

        txtConsecutivo.Text = Nothing
        txtTipoDocumento.Text = Nothing
        txtValor.Text = Nothing

        ActualizarGrillaDetalleFacturaProductos()
        LimpiarCamposDetalleFacturaProductos()
        '--------------------------------------

        bbiGuardar.Enabled = False
        txtNumeroFacturaS.Enabled = True
        '---------------------------------
        ActualizarGrilla()
    End Sub
    Private Sub GuardarServicios()
        _Facturas.Id = Val("")
        _Facturas.IdLicencia = Licencia
        _Facturas.Factura = txtNumeroFacturaS.Text
        _Facturas.IdContrato = cboContrato.GetColumnValue("ID")
        _Facturas.FechaFactura = dtFechaExpedicionS.Text
        _Facturas.FechaVencimiento = dtFechaVencimientoS.Text
        _Facturas.Concepto = txtConceptoS.Text
        _Facturas.Valor = colLFValor.SummaryItem.SummaryValue
        _Facturas.Copagos = colLFCopago.SummaryItem.SummaryValue
        _Facturas.Descuento = 0
        _Facturas.Estado = "F"
        _Facturas.IdCliente = 0
        _Facturas.TipoFactura = "SERVICIOS"
        _Facturas.Remision = "F"
        _Facturas.IdEmpleado = IDEmpleado
        _Facturas.Rips = 0
        _DFacturas.Guardar(_Facturas)
        _DFacturas.ActualizarOrdenes(cboContrato.GetColumnValue("ID"))
        _DFacturas.GuardarDetalleFactura()

    End Sub
    Private Sub GuardarProductos()
        _Facturas.Id = Val("")
        _Facturas.IdLicencia = Licencia
        _Facturas.Factura = "" 'txtFacturaP.Text
        _Facturas.IdContrato = Val("0")
        _Facturas.FechaFactura = dtFechaExpedicion.Text
        _Facturas.FechaVencimiento = dtFechaVencimiento.Text
        _Facturas.Concepto = txtConceptoP.Text
        _Facturas.Valor = Val(txtSubTotalP.EditValue)
        _Facturas.Copagos = Val("0")
        _Facturas.Descuento = Val(txtDescuentoP.EditValue)
        _Facturas.Estado = "F"
        _Facturas.IdCliente = cboCliente.EditValue
        _Facturas.TipoFactura = "PRODUCTOS"
        _Facturas.Remision = "F"
        _Facturas.IdEmpleado = IDEmpleado
        _DFacturas.Guardar(_Facturas)

        'Traemos el ultimo consecutivo de la factura guardada
        _Facturas = _DFacturas.UltimoRegistroFacturaProductos()

        Select Case Licencia
            Case 12, 13, 15
                _DFacturas.NumeroFacturaAutonumerica(_Facturas.Id)
                txtID.Text = _Facturas.Id
                'MsgBox(txtID.Text)
            Case Else
        End Select

        'Actualizamos el detalle de factura productos
        _DDetalleFacturaProductos.ActualizarDetalleFacturaProductos(_Id.ToString, _Facturas.Id)

    End Sub
    Private Sub GuardarRecibo()
        _Caja.Id = Val("")
        _Caja.IdOrden = txtID.Text
        _Caja.Fecha = dtFechaExpedicion.Text
        _Caja.Ciudad = "Cartagena"
        _Caja.Nombre = cboCliente.Text
        '_Caja.Identificacion = txtIdentificacion.Text
        '_Caja.Direccion = txtDireccion.Text
        '_Caja.Telefono = txtTelefono.Text
        _Caja.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        _Caja.Concepto = "Por concepto de pago de factura No. " & txtID.Text
        _Caja.Estado = "R"
        _Caja.IdEmpleado = IDEmpleado
        _Caja.IdCierre = Val("0")
        _Caja.Referencia = "FA" & txtID.Text
        _Caja.IdCliente = cboCliente.EditValue
        _DCaja.Guardar(_Caja)
    End Sub
    Private Sub GuardarDetallePagoRecibo()
        If _IdDetallePagoRecibo = Nothing Then
            _IdDetallePagoRecibo = Guid.NewGuid()
        End If
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _IdDetallePagoRecibo.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        _DetallePagoRecibo.Valor = txtFormaPagoValor.EditValue
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_IdDetallePagoRecibo.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarVentaInventario(ByVal IdProducto As String, ByVal IdMarca As String, ByVal IdPresentacionProducto As String, ByVal Cantidad As Double, ByVal ValorUnitario As Double, ByVal SaldoCantidad As Double, ByVal SaldoTotal As Double, ByVal ValorPromedio As Double)
        _Inventario.Fecha = DateTime.Now
        _Inventario.Hora = DateTime.Now
        _Inventario.IdDocumento = Val("1")
        _Inventario.IdProducto = Val(IdProducto)
        _Inventario.IdMarca = Val(IdMarca)
        _Inventario.IdPresentacionProducto = Val(IdPresentacionProducto)
        _Inventario.Movimiento = "S"
        _Inventario.Factura = txtID.Text
        _Inventario.Observacion = "."
        _Inventario.EntradaCantidad = 0
        _Inventario.EntradaValor = 0
        _Inventario.SalidaCantidad = Cantidad
        _Inventario.SalidaValor = ValorUnitario
        _Inventario.SaldoCantidad = SaldoCantidad
        _Inventario.SaldoTotal = SaldoTotal
        _Inventario.ValorPromedio = ValorPromedio
        _Inventario.IdEmpleado = IDEmpleado
        _Inventario.Estado = "A"
        '_idDetalleOrden = _dHistoria.GuardarHistoriayDetalle(_DetalleOrden, _Historia)
        _DInventario.Guardar(_Inventario)

    End Sub
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = New DataSet()
        _ds = _DClientes.listarcombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub GuardarDetalleFacturaProductos()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleFacturaProductos.IdFactura = Val(txtID.Text)
        Else
            'MsgBox(_Id.ToString)
            _DetalleFacturaProductos.IdFactura = _Id.ToString
        End If
        _DetalleFacturaProductos.IdProducto = cboProducto.EditValue
        _DetalleFacturaProductos.Cantidad = txtCantidadP.Text
        _DetalleFacturaProductos.ValorUnitario = txtValorUnitarioP.EditValue
        _DetalleFacturaProductos.Iva = 0
        _DetalleFacturaProductos.Descuento = Val(txtDescuento.EditValue)
        _DetalleFacturaProductos.CostoVenta = CostoVenta
        _DetalleFacturaProductos.Estado = "A"
        _DDetalleFacturaProductos.Guardar(_DetalleFacturaProductos)

    End Sub
    Private Sub ActualizarGrillaDetalleFacturaProductos()
        Select Case Licencia
            Case 12, 13, 15
                'LLENAR GRID VIEW 
                _ds = New DataSet
                If txtID.Text = "" Then
                    _ds = _DDetalleFacturaProductos.Listar(_Id.ToString)
                Else
                    _ds = _DDetalleFacturaProductos.Listar(txtID.Text)
                End If
                GCProductos.DataSource = _ds.Tables(0)
            Case Else
        End Select
    End Sub
    Private Sub LimpiarCamposDetallePagoRecibo()
        cboFormaPago.EditValue = Nothing
        txtFormaPagoValor.EditValue = Nothing
    End Sub
    Private Sub LimpiarCamposDetalleFacturaProductos()
        Select Case Licencia
            Case 12, 13, 15
                txtCantidadP.Text = 1
                txtValorUnitarioP.Text = ""
                'txtSubTotal.Text = ""
                txtExistencia.Text = ""
                lblMarca.Text = "Marca"
                lblCodigoProducto.Text = "Código"
                cboProducto.EditValue = Nothing
                Try
                    'Cargamos FOTO Temporal
                    peFoto.Image = Image.FromFile("c:\sim\imagenes\productos2.png")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case Else
        End Select
    End Sub
    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR GRILLA
        ActualizarGrilla()
        'Me.DTOrdenesFacturarTableAdapter.Fill(Me.DSVistas.DTOrdenesFacturar)
        'Llenamos Campos FECHA
        dtFechaExpedicionS.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaVencimientoS.Text = Format(DateTime.Now, "dd/MM/yyyy")

        Select Case Licencia
            Case 3, 4, 10, 14
                'Ocultamos Controles no necesarios
                colCONSECUTIVO.Visible = False
                colESPECIMEN.Visible = False
                colLFConsecutivo.Visible = False
                colLFEspecimen.Visible = False

                xtpFacturaProductos.PageVisible = False
            Case 12, 13, 15 'AQUAMEDICAL, FERRETERIA LA PUNTA Y OPTICA FREISEM
                colTIPOFACTURA.Visible = False
                xtpFacturaProductos.PageVisible = True
                'If Licencia = 15 Then
                xtpFacturaServicios.PageVisible = False
                'Else
                'xtpFacturaServicios.PageVisible = False
                'End If
                xtpRips.PageVisible = False
                xtpDetalleFactura.PageVisible = False
                xtpFacturaProductos.Show()
                TipoFactura = xtcFactura.SelectedTabPage.Text

                'Botones Rips - Ocultar
                bbiRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgregarFacturaRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgregarFacturasRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEliminarFacturaRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEliminarFacturasRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'Llenamos Campos Fecha de Factura de Productos
                dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
                dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

                ListarComboClientes()

                ' Cargar Tarifas
                '_ds = New DataSet()
                _ds = _DTarifas.ListarCombo
                cboTarifaProducto.Properties.DataSource = _ds.Tables(0)
                cboTarifaProducto.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
                cboTarifaProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
                cboTarifaProducto.ItemIndex = 0
                '---------------------------------
            Case Else
                xtpFacturaProductos.PageVisible = False
        End Select

        ' Cargar Contratos
        _ds = New DataSet()
        _ds = _DContratos.ListarComboLicencia(Licencia)
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1
        '---------------------------------

        ' Cargar Medios de Pago
        _ds = New DataSet()
        _ds = _DMedioPago.ListarCombo
        cboFormaPago.Properties.DataSource = _ds.Tables(0)
        cboFormaPago.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        bbiGuardar.Enabled = False
    End Sub
    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Factura pendiente por Guardar, Si presiona aceptar se perderan los cambios ¿Desea Continuar?", "Registro de Factura", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                If _Id <> Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleFacturaProductos.EliminarDetalleFacturaProductos(_Id.ToString)
                End If

                'Como no se guardo la factura se colocan nuevamente las ordenes en estado "A" 
                If GVListadoFactura.DataRowCount <> 0 Then
                    _Fila = 0
                    While _Fila < GVListadoFactura.DataRowCount
                        _DOrdenes.AgregarOrdenes(GVListadoFactura.GetRowCellValue(_Fila, "ORDEN").ToString(), "A")
                        _Fila = _Fila + 1
                    End While
                End If
                NuevaFactura()
            End If
        Else
            NuevaFactura()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        Dim CantidadSalida As Double = 0
        Dim ValorUnitario As Double = 0
        Dim SaldoCantidad As Double = 0
        Dim SaldoTotal As Double = 0
        Dim ValorPromedio As Double = 0

        If TipoFactura = "Facturar Servicios" Then
            'Facturar Servicios
            If dtFechaExpedicionS.Text = "" Then
                MessageBox.Show("La fecha de expedicion es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dtFechaVencimientoS.Text = "" Then
                MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtNumeroFacturaS.Text = "" Then
                MessageBox.Show("El campo Numero de Factura es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DFacturas.ExisteFactura(Licencia, txtNumeroFacturaS.Text) = True Then
                MessageBox.Show("El Numero de Factura ya fue Utilizado", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtConceptoS.Text = "" Then
                MessageBox.Show("El campo concepto es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarServicios()
                Dim _frmMensaje As New frmMensaje
                _frmMensaje.NumeroOrden = txtNumeroFacturaS.Text
                _frmMensaje.Text = "Factura Generada"
                _frmMensaje.ShowDialog()
                NuevaFactura()
            End If
        ElseIf TipoFactura = "Facturar Productos" Then
            'facturar Productos
            If dtFechaExpedicion.Text = "" Then
                MessageBox.Show("La fecha de expedicion es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dtFechaVencimiento.Text = "" Then
                MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtFacturaP.Text = "" And Licencia <> 13 Then
                '   MessageBox.Show("El campo Numero de Factura es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf _DFacturas.ExisteFactura(Licencia, txtFacturaP.Text) = True Then
                '    MessageBox.Show("El Numero de Factura ya fue Utilizado", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf txtConceptoP.Text = "" Then
                '   MessageBox.Show("El campo concepto es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtvalor.EditValue <> 0 And (txtvalor.EditValue <> Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)) Then
                MessageBox.Show("El valor a cancelar esta incorrecto", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtvalor.EditValue = 0 And (txttotalp.EditValue <> Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)) Then
                MessageBox.Show("El valor a cancelar esta incorrecto", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                GuardarProductos()

                'Se realiza barrido en el GVProductos para registrar los salidas de los productos
                Dim i As Integer = 0
                Do While i < gvProductos.RowCount
                    If gvProductos.GetRowCellValue(i, "INVENTARIO").ToString = "SI" Then
                        CantidadProducto = CDec(_DPresentacionProductos.CantidadProducto(gvProductos.GetRowCellValue(i, "IDPRESENTACIONPRODUCTO").ToString))

                        CantidadSalida = CDec(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * CantidadProducto
                        ValorUnitario = CDec(gvProductos.GetRowCellValue(i, "COSTOVENTA").ToString) / CantidadProducto

                        'BUscamos el saldo actual del producto en el inventario
                        _ds = _DInventario.SaldoActualInventario(gvProductos.GetRowCellValue(i, "IDPRODUCTO").ToString)

                        If _ds.Tables(0).Rows.Count <> 0 Then
                            SaldoCantidad = CDec(_ds.Tables(0).Rows(0)(1).ToString) - (CDec(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * CantidadProducto)
                            SaldoTotal = CDec(_ds.Tables(0).Rows(0)(2).ToString) - (ValorUnitario * CantidadSalida)

                            ValorPromedio = SaldoTotal / SaldoCantidad
                            If SaldoTotal = 0 And SaldoCantidad = 0 Then
                                ValorPromedio = 0
                            End If
                        End If

                        GuardarVentaInventario(gvProductos.GetRowCellValue(i, "IDPRODUCTO").ToString, gvProductos.GetRowCellValue(i, "IDMARCA").ToString, gvProductos.GetRowCellValue(i, "IDPRESENTACIONPRODUCTO").ToString, CantidadSalida, ValorUnitario, SaldoCantidad, SaldoTotal, ValorPromedio)
                    End If
                    i = i + 1
                Loop

                GuardarRecibo()
                _DDetallePagoRecibo.ActualizarDetallePago(_IdDetallePagoRecibo.ToString)

                If IdSaldoCliente = "0" Then
                    'Guardamos el movimiento del cliente
                    _CuentasClientes.Id = Val("")
                    _CuentasClientes.IdLicencia = Licencia
                    _CuentasClientes.IdCliente = cboCliente.EditValue
                    _CuentasClientes.TipoDocumento = "FA"
                    _CuentasClientes.NumeroDocumento = txtID.Text
                    _CuentasClientes.Fecha = dtFechaExpedicion.Text
                    _CuentasClientes.Concepto = txtConceptoP.Text
                    _CuentasClientes.Valor = Val(txtTotalP.EditValue)
                    _CuentasClientes.Saldo = Val("0")
                    _DCuentasClientes.Guardar(_CuentasClientes)

                    _DetalleCuentaCliente.Id = Val("")
                    _DetalleCuentaCliente.IdCuentaCliente = Val(_DCuentasClientes.UltimoID)
                    _DetalleCuentaCliente.IdRecibo = Val(_DCaja.UltimoReciboCaja)
                    _DetalleCuentaCliente.Valor = colVALORDETALLEPAGO.SummaryItem.SummaryValue
                    _DetalleCuentaCliente.Saldo = Val("0")
                    _DetalleCuentaCliente.Estado = "A"
                    _DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)

                Else

                    _DCuentasClientes.AjustarSaldo(Val(_ClickCuentasClientes), 0)

                    'Guardamos el movimiento del cliente
                    _CuentasClientes.Id = Val("")
                    _CuentasClientes.IdLicencia = Licencia
                    _CuentasClientes.IdCliente = cboCliente.EditValue
                    _CuentasClientes.TipoDocumento = "FA"
                    _CuentasClientes.NumeroDocumento = txtID.Text
                    _CuentasClientes.Fecha = dtFechaExpedicion.Text
                    _CuentasClientes.Concepto = txtConceptoP.Text
                    _CuentasClientes.Valor = Val(txtTotalP.EditValue)
                    _CuentasClientes.Saldo = Val("0")
                    _DCuentasClientes.Guardar(_CuentasClientes)

                    _DetalleCuentaCliente.Id = Val("")
                    _DetalleCuentaCliente.IdCuentaCliente = Val(_DCuentasClientes.UltimoID)
                    _DetalleCuentaCliente.IdRecibo = Val(_DCaja.UltimoReciboCaja)
                    _DetalleCuentaCliente.Valor = colVALORDETALLEPAGO.SummaryItem.SummaryValue
                    _DetalleCuentaCliente.Saldo = Val("0")
                    _DetalleCuentaCliente.Estado = "A"
                    _DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)

                End If

                Dim _frmMensaje As New frmMensaje
                _frmMensaje.NumeroOrden = txtID.Text
                _frmMensaje.Text = "Factura Generada"
                _frmMensaje.ShowDialog()

                If MessageBox.Show("Desea imprimir la factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Select Case Licencia
                        Case 15 'aquamedical y Optica Freisem
                            ImprimirFrm.ImprimirFacturaProductos(txtID.Text, 1)
                        Case Else
                    End Select
                End If
                If MessageBox.Show("Desea imprimir el recibo de caja?", "Imprimir Recibo de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ImprimirFrm.ImprimirReciboCaja(Val(_DCaja.UltimoReciboCaja), Licencia, 1)
                End If
                NuevaFactura()
            End If

            'Dim _frmOpen As New SIM___GLOBAL.frmReciboCaja
            '_frmOpen.ClienteFactura = cboCliente.EditValue
            '_frmOpen.IdEmpleado = IDEmpleado
            '_frmOpen.Licencia = Licencia
            '_frmOpen.txtOrden.Text = txtID.Text
            '_frmOpen.txtSaldo.Text = Val(txtTotalP.EditValue)
            '_frmOpen.txtValor.Text = Val(txtTotalP.EditValue)
            '_frmOpen.IdCuentaCliente = _DCuentasClientes.UltimoID
            '_frmOpen.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar el tipo de Facturacion", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNumeroFactura_Leave(sender As Object, e As EventArgs)
        If _DFacturas.ExisteFactura(Licencia, txtNumeroFacturaS.Text) = True Then
            MessageBox.Show("El Numero de Factura ya fue Utilizado", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumeroFacturaS.Text = ""
        End If
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaFacturas = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _EstadoFactura = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _ClickGrillaTipoFactura = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "TIPOFACTURA").ToString()
            If _ClickGrillaTipoFactura = "PRODUCTOS" Then
                bbiFacturaConcepto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiRelacionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                bbiFacturaConcepto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRelacionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        End If
    End Sub

    Private Sub bbiFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFactura.ItemClick
        'If _ClickGrillaFacturas <> "" Then
        ' Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        ' ImprimirFrm.CargarReporte("factura_resumida.rpt", _ClickGrillaFacturas)
        '
        '        Else
        '        MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        If _ClickGrillaFacturas <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirFacturaResumida(_ClickGrillaFacturas)
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiDetalleFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetalleFactura.ItemClick
        If _ClickGrillaFacturas <> Nothing Then
            Select Case Licencia
                Case 12, 15 'aquamedical
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirFacturaProductos(_ClickGrillaFacturas, 1)
                Case Else
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirFacturaDetalle(_ClickGrillaFacturas)
            End Select
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'If _ClickGrillaFacturas <> "" Then
        ' Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        ' ImprimirFrm.CargarReporte("factura_detalle.rpt", _ClickGrillaFacturas)
        '
        '        Else
        '        MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If

    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
            GVDetalleFactura.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
            GVDetalleFactura.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiFacturaConcepto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFacturaConcepto.ItemClick
        If _ClickGrillaFacturas <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirFacturaConcepto(_ClickGrillaFacturas)
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiRelacionFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRelacionFactura.ItemClick
        If _ClickGrillaFacturas <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirRelacionFactura(_ClickGrillaFacturas)
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub xtcFactura_Click(sender As Object, e As EventArgs) Handles xtcFactura.Click
        TipoFactura = xtcFactura.SelectedTabPage.Text
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub cboTarifaProducto_EditValueChanged(sender As Object, e As EventArgs) Handles cboTarifaProducto.EditValueChanged
        ' Cargar Productos
        _ds = _DDetalleTarifaProductos.ListarCombo(cboTarifaProducto.EditValue)
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(1).Caption
        '---------------------------------
    End Sub

    Private Sub gvComboProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvComboProductos.RowClick
        SaldoActualProducto = 0
        txtValorUnitarioP.Text = gvComboProductos.GetRowCellValue(e.RowHandle, "VALOR").ToString
        lblUnidadMedida.Text = gvComboProductos.GetRowCellValue(e.RowHandle, "UNIDAD").ToString
        lblCodigoProducto.Text = "Código " & gvComboProductos.GetRowCellValue(e.RowHandle, "CODIGO").ToString
        lblMarca.Text = gvComboProductos.GetRowCellValue(e.RowHandle, "MARCA").ToString
        txtCantidadP.Text = 1
        'txtSubTotal.Text = CDec(txtCantidadP.Text) * CDec(txtValorUnitarioP.EditValue)
        'MsgBox(gvComboProductos.GetRowCellValue(e.RowHandle, "IDPRODUCTO").ToString)
        CantidadProducto = CDec(_DPresentacionProductos.CantidadProducto(gvComboProductos.GetRowCellValue(e.RowHandle, "IDPRESENTACIONPRODUCTO").ToString))

        _ds = _DInventario.SaldoActualInventario(gvComboProductos.GetRowCellValue(e.RowHandle, "IDPRODUCTO").ToString)
        If _ds.Tables(0).Rows.Count <> 0 Then
            SaldoActualProducto = CDec(_ds.Tables(0).Rows(0)(1).ToString())
            If SaldoActualProducto <> 0 Then
                CostoVenta = (CDec(_ds.Tables(0).Rows(0)(2).ToString()) / CDec(_ds.Tables(0).Rows(0)(1).ToString())) * CantidadProducto
            End If
        End If

        txtExistencia.Text = SaldoActualProducto
        'MsgBox(gvComboProductos.GetRowCellValue(e.RowHandle, "IDPRODUCTO").ToString)
        'Traemos la imagen del producto
        _PresentacionProductos = _DPresentacionProductos.Cargar(gvComboProductos.GetRowCellValue(e.RowHandle, "IDPRESENTACIONPRODUCTO").ToString)

        Inventario = _PresentacionProductos.Inventario

        'Llamar funcion image bytes
        Dim FotoProducto As Image
        FotoProducto = _funciones.Bytes_Imagen(_PresentacionProductos.FotoProducto)
        peFoto.EditValue = FotoProducto

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If cboCliente.Text = "" Then
            MessageBox.Show("No se ha Seleccionado el Cliente", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTarifaProducto.Text = "" Then
            MessageBox.Show("Debe Seleccionar una Tarifa", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProducto.Text = "" Then
            MessageBox.Show("Seleccionar Producto", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidadP.Text) > CDec(txtExistencia.Text) Then
            MessageBox.Show("la Cantidad introducida es mayor a la existencia en inventario", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValorUnitarioP.EditValue) <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf SaldoActualProducto < Val(txtCantidadP.Text) Then
            'MsgBox(SaldoActualProducto)
            '   MessageBox.Show("La cantidad introducida es mayor al stock del inventario. Cantidad en Inventario: " & SaldoActualProducto, "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetalleFacturaProductos.ExisteProducto(_Id.ToString, cboProducto.EditValue) = True Then
            MessageBox.Show("El producto ya fue agregado", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleFacturaProductos()
            ActualizarGrillaDetalleFacturaProductos()
            LimpiarCamposDetalleFacturaProductos()
            txtSubTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtDescuentoP.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVAP.Text = 0
            txtTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSonP.Text = _funciones.Num2Text(txtTotalP.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If _ClickGrillaProductos = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La Factura no puede quedar sin detalle", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleFacturaProductos.EliminarItemDetalleFacturaProductos(_ClickGrillaProductos)
            ActualizarGrillaDetalleFacturaProductos()
            LimpiarCamposDetalleFacturaProductos()
            txtSubTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtDescuentoP.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVAP.Text = 0
            txtTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotalP.Text) & " PESOS M/CTE."
            _ClickGrillaProductos = Nothing
            If gvProductos.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub gvProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaProductos = gvProductos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
        End If
    End Sub

    Private Sub frmFacturas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Factura pendiente por Guardar, Si cierra la ventana se perderan los cambios ¿Desea Continuar?", "Registro de Factura", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If _Id <> Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleFacturaProductos.EliminarDetalleFacturaProductos(_Id.ToString)
                End If

                'Como no se guardo la factura se colocan nuevamente las ordenes en estado "A" 
                If GVListadoFactura.DataRowCount <> 0 Then
                    _Fila = 0
                    While _Fila < GVListadoFactura.DataRowCount
                        _DOrdenes.AgregarOrdenes(GVListadoFactura.GetRowCellValue(_Fila, "ORDEN").ToString(), "A")
                        _Fila = _Fila + 1
                    End While
                End If
            Else
                e.Cancel = True
            End If
        End If
        If gvDetallePagoDocumento.RowCount <> 0 Then
            _DDetallePagoRecibo.EliminarDetalleRecibo(_IdDetallePagoRecibo.ToString)
        End If
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged
        '_ds = New DataSet
        '_ds = _DOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
        'GCOrdenesAuditadas.DataSource = _ds.Tables(0)
        '----------------------------------------------------
        'Actualizamos grilla Factura Servicios
        _ds = New DataSet
        _ds = _DOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
        GCOrdenesAuditadas.DataSource = _ds.Tables(0)
        _ds = New DataSet
        _ds = _DOrdenes.OrdenesFacturarContrato(cboContrato.GetColumnValue("ID"))
        GCListadoFactura.DataSource = _ds.Tables(0)
        'Actualizamos las sumatorias
        txtSubTotalS.Text = colLFNeto.SummaryItem.SummaryValue
        'verificamos el COUNT de listado factura
        If GVListadoFactura.RowCount <> 0 Then
            bbiGuardar.Enabled = True
            cboContrato.Enabled = False
        Else
            bbiGuardar.Enabled = False
            cboContrato.Enabled = True
        End If
        '----------------------------------------------------
        'llemanos datos Contrato
        _ds = New DataSet
        _ds = _DContratos.DatosFactura(cboContrato.GetColumnValue("ID"))
        If _ds.Tables(0).Rows.Count <> 0 Then
            txtEntidad.Text = _ds.Tables(0).Rows(0)(0).ToString
            txtNit.Text = _ds.Tables(0).Rows(0)(1).ToString
            txtTelefono.Text = _ds.Tables(0).Rows(0)(2).ToString
            txtDireccion.Text = _ds.Tables(0).Rows(0)(3).ToString
        End If
    End Sub

    Private Sub GVOrdenesAuditadas_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVOrdenesAuditadas.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaOrdenesAuditadas = GVOrdenesAuditadas.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
        End If
    End Sub

    Private Sub btnAgregarOrden_Click(sender As Object, e As EventArgs) Handles btnAgregarOrden.Click
        If _ClickGrillaOrdenesAuditadas = Nothing Then
            MessageBox.Show("Debe Seleccionar una Orden para Facturar", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrillaOrdenesAuditadas, "F")
            _ClickGrillaOrdenesAuditadas = Nothing
            'Actualizamos grilla Factura Servicios
            _ds = New DataSet
            _ds = _dOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
            GCOrdenesAuditadas.DataSource = _ds.Tables(0)
            _ds = New DataSet
            _ds = _dOrdenes.OrdenesFacturarContrato(cboContrato.GetColumnValue("ID"))
            GCListadoFactura.DataSource = _ds.Tables(0)
            'Actualizamos las sumatorias
            txtSubTotalS.Text = colLFNeto.SummaryItem.SummaryValue
            'verificamos el COUNT de listado factura
            If GVListadoFactura.RowCount <> 0 Then
                bbiGuardar.Enabled = True
                cboContrato.Enabled = False
            Else
                bbiGuardar.Enabled = False
                cboContrato.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnEliminarOrden_Click(sender As Object, e As EventArgs) Handles btnEliminarOrden.Click
        If _ClickGrillaOrdenesFacturar = Nothing Then
            MessageBox.Show("Debe Seleccionar una Orden para Eliminar", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrillaOrdenesFacturar, "A")
            _ClickGrillaOrdenesFacturar = Nothing
            'Actualizamos grilla Factura Servicios
            _ds = New DataSet
            _ds = _dOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
            GCOrdenesAuditadas.DataSource = _ds.Tables(0)
            _ds = New DataSet
            _ds = _dOrdenes.OrdenesFacturarContrato(cboContrato.GetColumnValue("ID"))
            GCListadoFactura.DataSource = _ds.Tables(0)
            'Actualizamos las sumatorias
            txtSubTotalS.Text = colLFNeto.SummaryItem.SummaryValue
            'verificamos el COUNT de listado factura
            If GVListadoFactura.RowCount <> 0 Then
                bbiGuardar.Enabled = True
                cboContrato.Enabled = False
            Else
                bbiGuardar.Enabled = False
                cboContrato.Enabled = True
            End If
        End If
    End Sub

    Private Sub GVListadoFactura_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVListadoFactura.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaOrdenesFacturar = GVListadoFactura.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
        End If
    End Sub

    Private Sub txtSubTotalS_EditValueChanged(sender As Object, e As EventArgs) Handles txtSubTotalS.EditValueChanged
        txtDescuentoS.Text = 0
        txtIVAS.Text = 0
        txtTotalServicios.Text = txtSubTotalS.Text - txtDescuentoS.Text - txtIVAS.Text
    End Sub

    Private Sub txtTotalServicios_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalServicios.EditValueChanged
        txtSon.Text = _funciones.Num2Text(txtTotalServicios.Text) & " PESOS M/CTE."
    End Sub

    Private Sub btnAgregarTodo_Click(sender As Object, e As EventArgs) Handles btnAgregarTodo.Click

        If GVOrdenesAuditadas.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Agregar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Agregar los Registros Seleccionados?", "Agregar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVOrdenesAuditadas.DataRowCount
                    _DOrdenes.AgregarOrdenes(GVOrdenesAuditadas.GetRowCellValue(_Fila, "ORDEN").ToString(), "F")
                    _Fila = _Fila + 1
                End While
                'Actualizamos grilla Factura Servicios
                _ds = New DataSet
                _ds = _DOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
                GCOrdenesAuditadas.DataSource = _ds.Tables(0)
                _ds = New DataSet
                _ds = _DOrdenes.OrdenesFacturarContrato(cboContrato.GetColumnValue("ID"))
                GCListadoFactura.DataSource = _ds.Tables(0)
                'Actualizamos las sumatorias
                txtSubTotalS.Text = colLFNeto.SummaryItem.SummaryValue
                'verificamos el COUNT de listado factura
                If GVListadoFactura.RowCount <> 0 Then
                    bbiGuardar.Enabled = True
                    cboContrato.Enabled = False
                Else
                    bbiGuardar.Enabled = False
                    cboContrato.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnEliminarTodo_Click(sender As Object, e As EventArgs) Handles btnEliminarTodo.Click
        If GVListadoFactura.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Eliminar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Eliminar los Registros Seleccionados?", "Eliminar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVListadoFactura.DataRowCount
                    _DOrdenes.AgregarOrdenes(GVListadoFactura.GetRowCellValue(_Fila, "ORDEN").ToString(), "A")
                    _Fila = _Fila + 1
                End While
                'Actualizamos grilla Factura Servicios
                _ds = New DataSet
                _ds = _DOrdenes.OrdenesAuditadasContrato(cboContrato.GetColumnValue("ID"))
                GCOrdenesAuditadas.DataSource = _ds.Tables(0)
                _ds = New DataSet
                _ds = _DOrdenes.OrdenesFacturarContrato(cboContrato.GetColumnValue("ID"))
                GCListadoFactura.DataSource = _ds.Tables(0)
                'Actualizamos las sumatorias
                txtSubTotalS.Text = colLFNeto.SummaryItem.SummaryValue
                'verificamos el COUNT de listado factura
                If GVListadoFactura.RowCount <> 0 Then
                    bbiGuardar.Enabled = True
                    cboContrato.Enabled = False
                Else
                    bbiGuardar.Enabled = False
                    cboContrato.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        If _ClickGrillaFacturas <> Nothing Then
            If _EstadoFactura = "FACTURADO" Then
                If MessageBox.Show("Desea Anular la factura seleccionada?", "Anular factura",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                     = DialogResult.Yes Then

                    _DFacturas.AnularFactura(_ClickGrillaFacturas)

                    Select Case Licencia
                        Case "15"
                            Dim CantidadEntrada As Double = 0
                            Dim ValorUnitario As Double = 0
                            Dim SaldoCantidad As Double = 0
                            Dim SaldoTotal As Double = 0
                            Dim ValorPromedio As Double = 0
                            SaldoActualProducto = 0
                            Dim _dsSaldoInventario As DataSet
                            _ds = _DDetalleFacturaProductos.Listar(Val(_ClickGrillaFacturas))

                            For i = 0 To _ds.Tables(0).Rows.Count - 1

                                _PresentacionProductos = _DPresentacionProductos.Cargar(Val(_ds.Tables(0).Rows(i)(10).ToString()))
                                Inventario = _PresentacionProductos.Inventario

                                If Inventario = "SI" Then
                                    CantidadProducto = CDec(_DPresentacionProductos.CantidadProducto(Val(_ds.Tables(0).Rows(i)(10).ToString())))

                                    'BUscamos el saldo actual del producto en el inventario
                                    _dsSaldoInventario = _DInventario.SaldoActualInventario2(Val(_ds.Tables(0).Rows(i)(10).ToString()))
                                    CantidadEntrada = CDec(_ds.Tables(0).Rows(i)(4).ToString()) * CDec(CantidadProducto)
                                    ValorUnitario = CDec(_ds.Tables(0).Rows(i)(12).ToString()) / CDec(CantidadProducto)

                                    If _dsSaldoInventario.Tables(0).Rows.Count <> 0 Then
                                        SaldoCantidad = CDec(_dsSaldoInventario.Tables(0).Rows(0)(1).ToString) + (CDec(_ds.Tables(0).Rows(i)(4).ToString()) * CantidadProducto)
                                        SaldoTotal = CDec(_dsSaldoInventario.Tables(0).Rows(0)(2).ToString) + (ValorUnitario * CantidadEntrada)
                                        ValorPromedio = SaldoTotal / SaldoCantidad
                                    Else
                                        SaldoCantidad = CantidadEntrada
                                        SaldoTotal = ValorUnitario * CantidadEntrada
                                        ValorPromedio = ValorUnitario
                                    End If

                                    GuardarNotaCreditoInventario(Val(_ds.Tables(0).Rows(i)(9).ToString()), Val(_ds.Tables(0).Rows(i)(11).ToString()), Val(_ds.Tables(0).Rows(i)(10).ToString()), CantidadEntrada, ValorUnitario, SaldoCantidad, SaldoTotal, ValorPromedio)
                                End If
                                i = i + 1
                            Next
                            '    If _DCaja.ReciboCerradoOrdenes(_ClickGrillaFacturas) = True Then
                            '   MessageBox.Show("La Factura no puede ser Anulada. Existen Recibos de Caja cerrados", "Anular Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '  Else
                            '  If MessageBox.Show("Si anula la Factura, se anularan tambien los recibos de caja. Desea continuar?", "Anular Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            '  _DCaja.AnularReciboOrdenServicio(_ClickGrillaOrdenServicio)
                            '  _DCuentasClientes.AnularOrdenServicio(_ClickGrillaOrdenServicio)
                            'End If
                            'End If
                        Case Else
                            _DOrdenes.LiberarOrdenes(_ClickGrillaFacturas)
                    End Select

                    ActualizarGrilla()
                End If
            Else
                MessageBox.Show("La factura ya se encuentra anulada", "Anular factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar la factura", "Anular factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRips.ItemClick
        If _ClickGrillaFacturas <> "" Then

            If _ClickGrillaTipoFactura = "SERVICIOS" Then
                xtpRips.Show()
                _ds = New DataSet
                _ds = _DRips.Usuarios(_ClickGrillaFacturas)
                GCUsuarios.DataSource = _ds.Tables(0)

                _ds = New DataSet
                _ds = _DRips.Factura(_ClickGrillaFacturas)
                GCFacturas.DataSource = _ds.Tables(0)

                _ds = New DataSet
                _ds = _DRips.Consultas(_ClickGrillaFacturas)
                GCConsultas.DataSource = _ds.Tables(0)

                _ds = New DataSet
                _ds = _DRips.Procedimientos(_ClickGrillaFacturas)
                GCProcedimientos.DataSource = _ds.Tables(0)
            Else
                MessageBox.Show("Solo se generan Rips para facturas de servicios de salud", "Generar Rips", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Generar Rips", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiFacturaAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgregarFacturaRips.ItemClick
        If _ClickGrillaFacturas = "" Then
            MessageBox.Show("No se ha seleccionado una Factura", "Generar RIPS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If _ClickGrillaTipoFactura = "PRODUCTOS" Then
                MessageBox.Show("Solo se generan Rips para facturas de servicios de salud", "Generar Rips", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If _DRips.Existe(_ClickGrillaFacturas) = True Then
                    MessageBox.Show("La factura seleccionada ya se encuentra agregada", "Generar Rips", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    _ds = New DataSet
                    '_DRips.Agregar(_ClickGrillaFacturas)
                    _ds = _DRips.Listar
                    GCRips.DataSource = _ds.Tables(0)
                    _ClickGrillaFacturas = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RIPS()
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboCliente.Text = "" Then
            MessageBox.Show("No se ha Seleccionado el Cliente", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTarifaProducto.Text = "" Then
            MessageBox.Show("Debe Seleccionar una Tarifa", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProducto.Text = "" Then
            MessageBox.Show("Seleccionar Producto", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidadP.Text) > CDec(txtExistencia.Text) And Inventario = "SI" Then
            MessageBox.Show("la Cantidad introducida es mayor a la existencia en inventario", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValorUnitarioP.EditValue) <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf SaldoActualProducto < Val(txtCantidadP.Text) Then
            'MsgBox(SaldoActualProducto)
            '   MessageBox.Show("La cantidad introducida es mayor al stock del inventario. Cantidad en Inventario: " & SaldoActualProducto, "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetalleFacturaProductos.ExisteProducto(_Id.ToString, cboProducto.EditValue) = True Then
            MessageBox.Show("El producto ya fue agregado", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleFacturaProductos()
            ActualizarGrillaDetalleFacturaProductos()
            LimpiarCamposDetalleFacturaProductos()
            txtSubTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtDescuentoP.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVAP.Text = 0
            txtTotalP.Text = colCSubTotal.SummaryItem.SummaryValue - colCDescuento.SummaryItem.SummaryValue
            txtSonP.Text = _funciones.Num2Text(txtTotalP.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaProductos = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La Factura no puede quedar sin detalle", "Registro de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleFacturaProductos.EliminarItemDetalleFacturaProductos(_ClickGrillaProductos)
            ActualizarGrillaDetalleFacturaProductos()
            LimpiarCamposDetalleFacturaProductos()
            txtSubTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtDescuentoP.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVAP.Text = 0
            txtTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotalP.Text) & " PESOS M/CTE."
            _ClickGrillaProductos = Nothing
            If gvProductos.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSumaCantidad_Click(sender As Object, e As EventArgs) Handles btnSumaCantidad.Click
        txtCantidadP.Text = CDec(txtCantidadP.Text) + 1
    End Sub

    Private Sub btnRestaCantidad_Click(sender As Object, e As EventArgs) Handles btnRestaCantidad.Click
        If CDec(txtCantidadP.Text) > 1 Then
            txtCantidadP.Text = CDec(txtCantidadP.Text) - 1
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IDEmpleado
        _frmOpen.ShowDialog()
        ListarComboClientes()
    End Sub

    Private Sub cboClienteP_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        'Mostrar información del cliente
        _ds = New DataSet()
        _ds = _DCotizaciones.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)

        _ds = New DataSet
        _ds = _DCuentasClientes.SaldosCliente(cboCliente.EditValue)
        GCCuentasClientes.DataSource = _ds.Tables(0)

        If gvCuentasClientes.RowCount = 0 Then
            txtConsecutivo.Text = Nothing
            txtTipoDocumento.Text = Nothing
            txtValor.Text = Val("0")
        End If

        'bbiGuardar.Enabled = True

        '_ds = _DCuentasClientes.SaldoActualCliente(cboCliente.EditValue)
        'If _ds.Tables(0).Rows.Count <> 0 Then
        ' If _ds.Tables(0).Rows(0)(0).ToString = "OS" Then
        ' 'txtOrden.Text = _ds.Tables(0).Rows(0)(1).ToString
        ' 'txtValorOrden.Text = _ds.Tables(0).Rows(0)(2).ToString
        ' 'txtSaldo.Text = _ds.Tables(0).Rows(0)(3).ToString
        ' IdSaldoCliente = _ds.Tables(0).Rows(0)(4).ToString
        ' Else
        ' 'txtOrden.Text = Val("0")
        ' 'txtValorOrden.Text = Val("0")
        ' 'txtSaldo.Text = Val("0")
        ' IdSaldoCliente = "0"
        ' End If
        ' Else
        'txtOrden.Text = Val("0")
        'txtValorOrden.Text = Val("0")
        'txtSaldo.Text = Val("0")
        'IdSaldoCliente = "0"
        'End If
    End Sub

    Private Sub cboProducto_EditValueChanged(sender As Object, e As EventArgs) Handles cboProducto.EditValueChanged

    End Sub

    Private Sub dtFechaExpedicion_Leave(sender As Object, e As EventArgs) Handles dtFechaExpedicion.Leave
        dtFechaExpedicionS.Text = Format(dtFechaExpedicionS.Text, "dd/MM/yyyy")
    End Sub

    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtFormaPagoValor.EditValue <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_IdDetallePagoRecibo.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            LimpiarCamposDetallePagoRecibo()
        End If
    End Sub

    Private Sub btnEliminarFormaPago_Click(sender As Object, e As EventArgs) Handles btnEliminarFormaPago.Click
        If _ClickDetallePago = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago a eliminar", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetallePagoRecibo.Eliminar(_ClickDetallePago)
            ActualizarGrillaDetallePago()
            _ClickDetallePago = Nothing
            'If gvDetallePagoDocumento.RowCount <> 0 Then
            'bbiGuardar.Enabled = True
            'Else
            ' bbiGuardar.Enabled = False
            'End If
        End If
    End Sub

    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub gvCuentasClientes_RowClick(sender As Object, e As RowClickEventArgs) Handles gvCuentasClientes.RowClick
        If e.RowHandle >= 0 Then
            _ClickCuentasClientes = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            txtConsecutivo.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            txtTipoDocumento.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "DOCUMENTO").ToString()
            txtValor.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "SALDO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnVerOrdenServicio_Click(sender As Object, e As EventArgs) Handles btnVerOrdenServicio.Click
        If txtConsecutivo.Text <> "" Then
            'Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirOrdenServicio(txtConsecutivo.Text, 1)
        Else
            MessageBox.Show("Debe seleccionar la Orden de Servicio", "Vista Previa Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSeleccionarOrden_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOrden.Click
        If txtConsecutivo.Text = "" Then
            MessageBox.Show("Debe seleccionar la Orden de Servicio", "Seleccionar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount <> 0 Then
            MessageBox.Show("Debe Remover los productos antes de seleccionar la Orden de Servicio", "Seleccionar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SaldoActualProducto = 0
            Dim _dsSaldoInventario As DataSet
            _ds = _DDetalleordenservicio.Listar(Val(txtConsecutivo.Text))
            For i = 0 To _ds.Tables(0).Rows.Count - 1

                CantidadProducto = CDec(_DPresentacionProductos.CantidadProducto(Val(_ds.Tables(0).Rows(i)(8).ToString())))
                _dsSaldoInventario = _DInventario.SaldoActualInventario2(Val(_ds.Tables(0).Rows(i)(8).ToString()))
                If _dsSaldoInventario.Tables(0).Rows.Count <> 0 Then
                    SaldoActualProducto = CDec(_dsSaldoInventario.Tables(0).Rows(0)(1).ToString())
                    If SaldoActualProducto <> 0 Then
                        CostoVenta = (CDec(_dsSaldoInventario.Tables(0).Rows(0)(2).ToString()) / CDec(_dsSaldoInventario.Tables(0).Rows(0)(1).ToString())) * CantidadProducto
                    Else
                        CostoVenta = 0
                    End If
                End If

                _PresentacionProductos = _DPresentacionProductos.Cargar(Val(_ds.Tables(0).Rows(i)(8).ToString()))

                Inventario = _PresentacionProductos.Inventario

                If SaldoActualProducto = 0 And Inventario = "SI" Then
                    MessageBox.Show("No hay existencia del producto " & _PresentacionProductos.Presentacion, "Seleccionar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For
                Else
                    If _Id = Nothing Then
                        _Id = Guid.NewGuid()
                    End If
                    If txtID.Text <> "" Then
                        _DetalleFacturaProductos.IdFactura = Val(txtID.Text)
                    Else
                        'MsgBox(_Id.ToString)
                        _DetalleFacturaProductos.IdFactura = _Id.ToString
                    End If
                    _DetalleFacturaProductos.IdProducto = _ds.Tables(0).Rows(i)(8).ToString()
                    _DetalleFacturaProductos.Cantidad = _ds.Tables(0).Rows(i)(4).ToString()
                    _DetalleFacturaProductos.ValorUnitario = _ds.Tables(0).Rows(i)(5).ToString()
                    _DetalleFacturaProductos.Iva = 0
                    _DetalleFacturaProductos.Descuento = _ds.Tables(0).Rows(i)(7).ToString()
                    _DetalleFacturaProductos.CostoVenta = CostoVenta
                    _DetalleFacturaProductos.Estado = "A"
                    _DDetalleFacturaProductos.Guardar(_DetalleFacturaProductos)
                End If
            Next i
            ActualizarGrillaDetalleFacturaProductos()
            txtSubTotalP.Text = colValorUnitario.SummaryItem.SummaryValue
            txtDescuentoP.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVAP.Text = 0
            txtTotalP.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSonP.Text = _funciones.Num2Text(txtTotalP.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True

        End If
    End Sub

    Private Sub bbigenerarRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbigenerarRips.ItemClick
        ' Crear la lista de usuarios
        Dim listaUsuarios As New List(Of Object)

        If _ClickGrillaFacturas <> "" Then

            _ds = New DataSet
            _ds = _DRipsJSON.Usuarios(_ClickGrillaFacturas)

            For i As Integer = 0 To _ds.Tables(0).Rows.Count - 1

                Dim tipoEstudio As String = _ds.Tables(0).Rows(i)(12).ToString

                If tipoEstudio = "P" Then
                    _dsP = New DataSet
                    _dsP = _DRipsJSON.Procedimientos(_ds.Tables(0).Rows(i)(0).ToString)

                    If _dsP.Tables(0).Rows.Count = 0 Then
                        MsgBox("No se pueden generar los Rips porque existen procedimientos que no se han realizados")
                    Else
                        listaUsuarios.Add(New With {
                            .tipoDocumentoIdentificacion = _ds.Tables(0).Rows(i)(1).ToString,
                            .numDocumentoIdentificacion = _ds.Tables(0).Rows(i)(2).ToString,
                            .tipoUsuario = "0" & _ds.Tables(0).Rows(i)(3).ToString,
                            .fechaNacimiento = Format(_ds.Tables(0).Rows(i)(4), "yyyy-MM-dd"),
                            .codSexo = _ds.Tables(0).Rows(i)(5).ToString(),
                            .codPaisResidencia = "170",
                            .codMunicipioResidencia = _ds.Tables(0).Rows(i)(7).ToString(),
                            .codZonaTerritorialResidencia = _ds.Tables(0).Rows(i)(8).ToString(),
                            .incapacidad = "NO",
                            .consecutivo = _ds.Tables(0).Rows(i)(10),
                            .codPaisOrigen = "170",
                            .servicios = New With {
                                .Procedimientos = New Object() {
                                    New With {
                                    .codPrestador = "130010244901",
                                    .fechaInicioAtencion = Format(_dsP.Tables(0).Rows(0)(1), "yyyy-MM-dd HH:mm"),
                                    .idMIPRES = CType(Nothing, String),
                                    .numAutorizacion = _dsP.Tables(0).Rows(0)(3).ToString(),
                                    .codProcedimiento = _dsP.Tables(0).Rows(0)(4).ToString(),
                                    .viaIngresoServicioSalud = "02",
                                    .modalidadGrupoServicioTecSal = "01",
                                    .grupoServicios = "02",
                                    .codServicio = 706,
                                    .finalidadTecnologiaSalud = "15",
                                    .tipoDocumentoIdentificacion = "CC",
                                    .numDocumentoIdentificacion = "73106055",
                                    .codDiagnosticoPrincipal = _dsP.Tables(0).Rows(0)(12).ToString(),
                                    .codDiagnosticoRelacionado = CType(Nothing, String),
                                    .codComplicacion = CType(Nothing, String),
                                    .vrServicio = _dsP.Tables(0).Rows(0)(15),
                                    .conceptoRecaudo = "05",
                                    .valorPagoModerador = _dsP.Tables(0).Rows(0)(17),
                                    .numFEVPagoModerador = CType(Nothing, String),
                                    .consecutivo = _dsP.Tables(0).Rows(0)(19)
                                    }
                                }
                            }
                        })

                    End If
                Else
                    _dsC = New DataSet
                    _dsC = _DRipsJSON.Consultas(_ds.Tables(0).Rows(i)(0).ToString)

                    If _dsC.Tables(0).Rows.Count = 0 Then
                        MsgBox("No se pueden generar los Rips porque existen consultas que no se han realizados")
                    Else
                        listaUsuarios.Add(New With {
                            .tipoDocumentoIdentificacion = _ds.Tables(0).Rows(i)(1).ToString,
                            .numDocumentoIdentificacion = _ds.Tables(0).Rows(i)(2).ToString,
                            .tipoUsuario = "0" & _ds.Tables(0).Rows(i)(3).ToString,
                            .fechaNacimiento = Format(_ds.Tables(0).Rows(i)(4), "yyyy-MM-dd"),
                            .codSexo = _ds.Tables(0).Rows(i)(5).ToString(),
                            .codPaisResidencia = "170",
                            .codMunicipioResidencia = _ds.Tables(0).Rows(i)(7).ToString(),
                            .codZonaTerritorialResidencia = _ds.Tables(0).Rows(i)(8).ToString(),
                            .incapacidad = "NO",
                            .consecutivo = _ds.Tables(0).Rows(i)(10),
                            .codPaisOrigen = "170",
                            .servicios = New With {
                            .consultas = New Object() {
                                New With {
                                .codPrestador = "130010244901",
                                .fechaInicioAtencion = Format(_dsC.Tables(0).Rows(0)(1), "yyyy-MM-dd HH:mm"),
                                .numAutorizacion = _dsC.Tables(0).Rows(0)(2).ToString(),
                                .codConsulta = _dsC.Tables(0).Rows(0)(3).ToString(),
                                .modalidadGrupoServicioTecSal = "01",
                                .grupoServicios = "01",
                                .codServicio = 301,
                                .finalidadTecnologiaSalud = "15",
                                .causaMotivoAtencion = "38",
                                .codDiagnosticoPrincipal = _dsC.Tables(0).Rows(0)(9).ToString(),
                                .codDiagnosticoRelacionado1 = CType(Nothing, String),
                                .codDiagnosticoRelacionado2 = CType(Nothing, String),
                                .codDiagnosticoRelacionado3 = CType(Nothing, String),
                                .tipoDiagnosticoPrincipal = "01",
                                .tipoDocumentoIdentificacion = "CC",
                                .numDocumentoIdentificacion = "73106055",
                                .vrServicio = _dsC.Tables(0).Rows(0)(16),
                                .conceptoRecaudo = "05",
                                .valorPagoModerador = _dsC.Tables(0).Rows(0)(18),
                                .numFEVPagoModerador = CType(Nothing, String),
                                .consecutivo = _dsC.Tables(0).Rows(0)(20)
                                }
                            }
                        }
                    })
                    End If
                End If
            Next

            'Armar el JSON final con la factura
            'Dim factura = New With {
            '.numDocumentoIdObligado = "900329923",
            '.numFactura = _ClickFactura,
            '.tipoNota = CType(Nothing, String),
            '.numNota = CType(Nothing, String),
            '.usuarios = listaUsuarios.ToArray()
            '}


            'json = JsonConvert.SerializeObject(factura, Formatting.Indented)

            'rtbJSON.Text = json

            'HighlightJsonSyntax(rtbJSON)

            'btnGenerarJSON.Enabled = True

            'xtcFactura.SelectedTabPage = xtpJSON


            '----------------------------------------------------------
            ' Guardar en archivo (ajusta la ruta si es necesario)
            'Dim rutaArchivo = "C:\Otros Documentos\Proyectos\Rips\salida.json"
            'File.WriteAllText(rutaArchivo, json, Encoding.UTF8)

            ' MessageBox.Show("Archivo JSON generado exitosamente en:" & vbCrLf & rutaArchivo)

        End If
    End Sub
End Class
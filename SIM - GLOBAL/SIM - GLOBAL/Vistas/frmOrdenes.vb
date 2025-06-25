Imports System.ComponentModel
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenes
#Region "Declaracion de Variables"
    Dim _ds As DataSet
    Dim _IdUsuario As Integer
    Dim _IdUsuarioOrden As Integer
    Dim _Fila As Integer
    Dim _idTipoEstudio As Integer
    Dim _TipoAtencion As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdOrden As String
    Dim _ClickIdAgenda As String
    Dim _ClickIdRelacion As String
    Dim IdAgenda As String
    Dim Contrasena As String
    Dim Sexo As String
    Dim Identificacion As String
    Dim _Id As New Guid
    Dim _IdRelacion As New Guid
    Dim _dUsuarios = New DUsuarios
    Dim _DDetalleTarifa As New SIM___GLOBAL.Controles.DDetalleTarifas
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
    Dim _DetalleOrdenFactura As New SIM___GLOBAL.Modelo.DetalleFacturacion
    Dim _DDetalleOrdenFactura As New SIM___GLOBAL.Controles.DDetalleFacturacion
    Dim _Citologia As New SIM___GLOBAL.Modelo.Citologia
    Dim _DCitologia As New SIM___GLOBAL.Controles.DCitologia
    Dim _Patologia As New SIM___GLOBAL.Modelo.Patologia
    Dim _DPatologia As New SIM___GLOBAL.Controles.DPatologia
    Dim _DAgenda As New SIM___GLOBAL.Controles.DAgenda
    Dim _DEspecimenes As New SIM___GLOBAL.Controles.DEspecimenes
    Dim _BloqueoRegistros As New SIM___GLOBAL.Modelo.BloqueoRegistros
    Dim _DBloqueoRegistros As New SIM___GLOBAL.Controles.DBloqueoRegistros
    Dim _Sesiones As New SIM___GLOBAL.Modelo.Sesiones
    Dim _DSesiones As New SIM___GLOBAL.Controles.DSesiones
    Dim _CuentasClientes As New SIM___GLOBAL.Modelo.CuentasClientes
    Dim _DCuentasClientes As New SIM___GLOBAL.Controles.DCuentasClientes
    Dim _DDetalleCuentaCliente As New SIM___GLOBAL.Controles.DDetalleCuentaCliente
    Dim _DClientes As New SIM___GLOBAL.Controles.DClientes
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    ReadOnly _funciones As New Funciones
    Public Licencia As String
    Public IDEmpleado As String
    Public Empleado As String
    Dim NuevaO As Byte
    Dim Consecutivo As String
    Dim IdCuentaCliente As String
    Dim ValorRecibo As Double
    Dim IdCliente As String
#End Region
#Region "Procedimientos personalizados"
    Private Sub GuardarCuentaCliente()
        _CuentasClientes.Id = Val("")
        _CuentasClientes.IdLicencia = Licencia
        _CuentasClientes.IdCliente = IdCliente
        _CuentasClientes.TipoDocumento = "OM"
        _CuentasClientes.NumeroDocumento = txtConsecutivo.Text
        _CuentasClientes.Fecha = dtFechaIngreso.Text
        _CuentasClientes.Concepto = "Por Concepto de copago de acuerdo a Orden No. " & txtConsecutivo.Text
        _CuentasClientes.Valor = CDec(colDOCopago.SummaryItem.SummaryValue)
        _CuentasClientes.Saldo = CDec(colDOCopago.SummaryItem.SummaryValue)
        _DCuentasClientes.Guardar(_CuentasClientes)
    End Sub


    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrillaDetalleOrden(ByVal filtro As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtConsecutivo.Text = "" Then
            _ds = _DDetalleOrden.Listar(_Id.ToString)
        Else
            _ds = _DDetalleOrden.Listar(filtro)
        End If
        GCDetalleOrden.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DOrdenes.ListarOrdenes2
        GCConsultarOrdenes.DataSource = _ds.Tables(0)
    End Sub
    Private Sub NuevaOrden()
        If _ClickIdAgenda <> "" Then
            IdAgenda = _ClickIdAgenda
        End If

        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        Identificacion = _ds.Tables(0).Rows(0)(1).ToString

        Sexo = _ds.Tables(0).Rows(0)(5)

        Select Case Licencia
            Case 2, 6, 11, 16
                _ds = New DataSet
                _ds = _DPatologia.ListarPatologiasPaciente(_IdUsuario)
                GCEstudios.DataSource = _ds.Tables(0)
            Case Else
        End Select

        _Id = Guid.NewGuid()


    End Sub
    Private Sub LimpiarCampos()
        If txtConsecutivo.Text = "" And GVDetalleOrden.RowCount <> 0 Then
            _DDetalleOrden.EliminarDetalleOrden(_Id.ToString)
            _DDetalleOrdenFactura.EliminarDetalleOrdenFactura(_Id.ToString)
        End If

        '_IdUsuario = Nothing
        txtComentarios.Text = Nothing

        cboContrato.Enabled = True
        cboContrato.EditValue = Nothing 'cboContrato.Properties.ValueMember = Nothing
        cboContrato.ReadOnly = False
        cboSubentidades.EditValue = Nothing
        dtFechaOrden.Text = ""
        dtFechaEntrega.Text = ""
        cboMedico.EditValue = Nothing
        txtAutorizacion.Text = Nothing
        txtNumeroOrden.Text = Nothing
        txtConsecutivo.Text = Nothing
        txtPrefijo.Text = Nothing
        txtNumeroEstudio.Text = Nothing
        txtNumeroEstudio.Enabled = True
        cboTipoEstudio.EditValue = Nothing
        cboTipoEstudio.ReadOnly = False
        cboEspecimen.ReadOnly = False
        cboEspecimen.ItemIndex = 0

        _ClickIdAgenda = Nothing
        GCDetalleOrden.DataSource = Nothing
        bbiGuardar.Enabled = False
        ValorRecibo = 0
    End Sub
    Private Sub GuardarBloqueoRegistro()
        Try
            _BloqueoRegistros.Id = Val("")
            _BloqueoRegistros.IdOrden = txtConsecutivo.Text
            _BloqueoRegistros.IdDetalleOrden = Val("")
            _BloqueoRegistros.IdUser = IDEmpleado
            _BloqueoRegistros.IdTabla = 3
            _DBloqueoRegistros.Guardar(_BloqueoRegistros)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Bloqueo de Registros")
        End Try
    End Sub
    Private Sub GuardarOrdenes()
        Try
            _Ordenes.Id = Val(txtConsecutivo.Text)
            _Ordenes.IdUsuario = _IdUsuario
            _Ordenes.IdContrato = cboContrato.GetColumnValue("ID")
            _Ordenes.IdSubEntidad = cboSubentidades.GetColumnValue("ID")
            _Ordenes.IdIngreso = Val("2")
            _Ordenes.IdSede = cboSede.GetColumnValue("ID")
            _Ordenes.IdEmpleado = cboMedico.GetColumnValue("ID")
            _Ordenes.Autorizacion = txtAutorizacion.Text
            _Ordenes.NumeroOrden = txtNumeroOrden.Text
            _Ordenes.FechaIngreso = dtFechaIngreso.Text
            _Ordenes.FechaOrden = dtFechaOrden.Text
            _Ordenes.Hora = DateTime.Now
            _Ordenes.Idfactura = "P"
            _Ordenes.IdTipoAfiliado = cboTipoAfiliado.GetColumnValue("ID")
            _Ordenes.IdTipoUsuario = cboTipoUsuario.GetColumnValue("ID")

            Select Case Licencia
                Case 3, 4, 7, 8, 14 '3-DITEG, 4-GASTROLAP, 7-FAUSTO VELEZ, 8-PEDRO IMBETH Y 14-FERNANDO PONCE
                    _Ordenes.IdTipoEstudio = 8
                Case 15 'OPTICA FREISEM
                    _Ordenes.IdTipoEstudio = 17
                Case Else
                    _Ordenes.IdTipoEstudio = cboTipoEstudio.GetColumnValue("ID")
            End Select

            _Ordenes.Comentarios = txtComentarios.Text

            Select Case Licencia
                Case 2, 6, 16 '2-INMUNOPAT, 6-KELLY Y 16-CD PATOLOGIA ONCOLOGICA
                    If Licencia = 16 Then
                        '    _Ordenes.Consecutivo = "" & txtNumeroEstudio.Text & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                    Else
                        '   _Ordenes.Consecutivo = txtPrefijo.Text & txtNumeroEstudio.Text & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                    End If

                Case Else
            End Select

            _Ordenes.Estado = "PENDIENTE"

            Select Case Licencia
                Case 2, 6, 11, 16 '2-INMUNOPAT, 6-KELLY, 11-CITOPAT Y 16-CD PATOLOGIA ONCOLOGICA
                    _Ordenes.IdEspecimen = cboEspecimen.GetColumnValue("ID")
                Case Else
                    _Ordenes.IdEspecimen = Val("1")
            End Select

            _Ordenes.Saldo = colDOCopago.SummaryItem.SummaryValue
            _DOrdenes.Guardar(_Ordenes)
            bbiGuardar.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Ordenes")
        End Try
    End Sub
    Private Sub GuardarRegistro()
        Dim _Registros As New SIM___GLOBAL.Modelo.Registros
        Dim _DRegistros As New SIM___GLOBAL.Controles.DRegistros
        Try
            _Registros.Fecha = DateTime.Now
            _Registros.IdTabla = 3
            If txtConsecutivo.Text = "" Then
                _Registros.IdRegistro = _Ordenes.Id
                _Registros.TipoRegistro = "Registro"
            Else
                _Registros.IdRegistro = txtConsecutivo.Text
                _Registros.TipoRegistro = "Actualizacion"
            End If
            _Registros.IdUsuario = IDEmpleado
            _Registros.Nota = ""
            _DRegistros.Guardar(_Registros)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Registro")
        End Try
    End Sub
    Private Sub GuardarEntregaResultados()
        Dim _EntregaResultados As New SIM___GLOBAL.Modelo.EntregaResultados
        Dim _DEntregaResultados As New SIM___GLOBAL.Controles.DEntregaResultados
        Try
            _EntregaResultados.Id = Val("")
            _EntregaResultados.IdOrden = Val(_Ordenes.Id)
            _EntregaResultados.FechaEntrega = dtFechaEntrega.Text
            _EntregaResultados.TipoEstudio = cboTipoEstudio.GetColumnValue("ID")
            _DEntregaResultados.Guardar(_EntregaResultados)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Ordenes")
        End Try
    End Sub
    Private Sub GuardarDetalleFactura()
        Try
            If txtConsecutivo.Text = Nothing Then
                _DetalleOrdenFactura.IdOrden = _Id.ToString
            Else
                _DetalleOrdenFactura.IdOrden = Val(_Ordenes.Id)
            End If
            _DetalleOrdenFactura.IdCausa = Val("15")
            _DetalleOrdenFactura.IdFinalidadConsulta = Val("10")
            _DetalleOrdenFactura.IdFinalidadProcedimiento = Val("1")
            _DetalleOrdenFactura.IdAmbito = cboAmbitoProcedimiento.GetColumnValue("ID")
            _DetalleOrdenFactura.IdPersonaAtiende = Val("1")
            '_Detallefacturacion.FechaSalida = ""
            _DetalleOrdenFactura.Hora = DateTime.Now
            _DetalleOrdenFactura.IdTipoDiagnostico = Val("1")
            '_Detallefacturacion.Diagnostico1 = ""
            '_Detallefacturacion.Diagnostico2 = ""
            '_Detallefacturacion.Diagnostico3 = ""
            '_Detallefacturacion.Diagnostico4 = ""
            _DetalleOrdenFactura.IdFormaRealizacion = Val("1")
            _DetalleOrdenFactura.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrdenFactura.CodigoCups = txtCodigoCups.Text
            _DetalleOrdenFactura.IdTipoEstudio = _idTipoEstudio 'cboProcedimiento.EditValue
            _DetalleOrdenFactura.Valor = Val(txtValor.EditValue)
            _DetalleOrdenFactura.Copago = Val(txtCopago.EditValue)
            _DetalleOrdenFactura.Neto = Val(txtNeto.EditValue)
            _DetalleOrdenFactura.Tipo = _TipoAtencion
            _DetalleOrdenFactura.Estado = "PENDIENTE"
            _DetalleOrdenFactura.IdRelacion = _IdRelacion.ToString
            _DDetalleOrdenFactura.Guardar(_DetalleOrdenFactura)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle Facturacion")
        End Try
    End Sub
    Private Sub GuardarDetalleOrden()
        Try
            If txtConsecutivo.Text = Nothing Then
                _DetalleOrden.IdOrden = _Id.ToString
            Else
                _DetalleOrden.IdOrden = Val(_Ordenes.Id)
            End If
            _DetalleOrden.IdCausa = Val("15")
            _DetalleOrden.IdFinalidadConsulta = Val("10")
            _DetalleOrden.IdFinalidadProcedimiento = Val("1")
            _DetalleOrden.IdAmbito = cboAmbitoProcedimiento.GetColumnValue("ID")
            _DetalleOrden.IdPersonaAtiende = Val("1")
            '_DetalleOrden.FechaSalida = ""
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.IdTipoDiagnostico = Val("1")
            '_DetalleOrden.Diagnostico1 = ""
            '_DetalleOrden.Diagnostico2 = ""
            '_DetalleOrden.Diagnostico3 = ""
            '_DetalleOrden.Diagnostico4 = ""
            _DetalleOrden.IdFormaRealizacion = Val("1")
            _DetalleOrden.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrden.CodigoCups = txtCodigoCups.Text
            _DetalleOrden.IdTipoEstudio = _idTipoEstudio 'cboProcedimiento.EditValue
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.Tipo = _TipoAtencion
            _DetalleOrden.Estado = "PENDIENTE"
            _DetalleOrden.IdRelacion = _IdRelacion.ToString
            _DDetalleOrden.GuardarDetalleOrden(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub
    Private Sub LimpiarCamposDetalleOrden()
        txtCodigoProcedimiento.Text = ""
        txtValor.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
        txtCodigoCups.Text = ""
        cboProcedimiento.Text = ""
    End Sub
    Private Sub GuardarEstudio()
        Select Case cboTipoEstudio.GetColumnValue("ID")
            Case 1, 2, 18
                Try
                    _Citologia.IdOrden = _Ordenes.Id
                    _Citologia.Fecha = dtFechaIngreso.Text
                    _DCitologia.Guardar(_Citologia)

                    Select Case Licencia
                        Case 11
                            If _DCitologia.GenerarConsecutivo = 1 Then
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, txtPrefijo.Text & "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = txtPrefijo.Text & "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            Else
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, txtPrefijo.Text & _DCitologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = txtPrefijo.Text & _DCitologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            End If
                        Case 16
                            If _DCitologia.GenerarConsecutivo = 1 Then
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            Else
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & _DCitologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = "" & _DCitologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            End If
                        Case Else

                    End Select

                Catch ex As Exception
                    MessageBox.Show(ex.Message & " Guardar Citologias")
                End Try
            Case 3 To 7
                Try
                    _Patologia.IdOrden = _Ordenes.Id
                    _Patologia.Fecha = dtFechaIngreso.Text
                    _DPatologia.Guardar(_Patologia)

                    Select Case Licencia
                        Case 11 'CITOPAT DE LA COSTA
                            If _DPatologia.GenerarConsecutivo = 1 Then
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, txtPrefijo.Text & "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = txtPrefijo.Text & "1" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            Else
                                _DOrdenes.GuardarConsecutivo(_Ordenes.Id, txtPrefijo.Text & _DPatologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                Consecutivo = txtPrefijo.Text & _DPatologia.GenerarConsecutivo & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                            End If
                        Case 16 ' CD PATOLOGIA
                            'Generamos Consecutivo Automatico en CD PATOLOGIA
                            If _DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) = 1 Then
                                If cboSede.GetColumnValue("ID") = 1 Then
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & "60001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & "60001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                ElseIf cboSede.GetColumnValue("ID") = 2 Then
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & "10001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & "10001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                Else
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & "30001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & "20001" & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                End If

                            Else
                                If cboSede.GetColumnValue("ID") = 1 Then
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 60000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 60000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                ElseIf cboSede.GetColumnValue("ID") = 2 Then
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 10000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 10000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                Else
                                    _DOrdenes.GuardarConsecutivo(_Ordenes.Id, "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 30000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2))
                                    Consecutivo = "" & Val(_DPatologia.GenerarConsecutivoCD(cboSede.GetColumnValue("ID")) + 30000) & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                                End If
                            End If
                                Case Else

                    End Select

                Catch ex As Exception
                    MessageBox.Show(ex.Message & " Guardar Patologias")
                End Try

        End Select
    End Sub
    Private Sub EditarOrden()

        '------------Traemos datos usuarios--------------
        'NuevaO = 1
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuarioOrden)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        _Ordenes = _DOrdenes.Cargar(_ClickIdOrden)
        txtConsecutivo.Text = _Ordenes.Id

        txtComentarios.Text = _Ordenes.Comentarios
        If _Ordenes.Consecutivo <> "" Then
            'txtNumeroEstudio.Text = Mid(_Ordenes.Consecutivo, 3, Len(_Ordenes.Consecutivo) - 2)
            txtNumeroEstudio.Text = _Ordenes.Consecutivo
        End If

        cboTipoAfiliado.ItemIndex = cboTipoAfiliado.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdTipoAfiliado)
        cboTipoUsuario.ItemIndex = cboTipoUsuario.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdTipoUsuario)
        dtFechaOrden.Text = _Ordenes.FechaOrden

        dtFechaIngreso.Text = _Ordenes.FechaIngreso
        txtAutorizacion.Text = _Ordenes.Autorizacion
        txtNumeroOrden.Text = _Ordenes.NumeroOrden
        cboContrato.ItemIndex = cboContrato.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdContrato)
        '_IdContrato = cboContrato.ItemIndex
        cboMedico.ItemIndex = cboMedico.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdEmpleado)
        cboTipoEstudio.ItemIndex = cboTipoEstudio.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdTipoEstudio)
        cboEspecimen.ItemIndex = cboEspecimen.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdEspecimen)

        'GPDetalleOrden.Visible = True
        ActualizarGrillaDetalleOrden(_Ordenes.Id)
        'cboContrato.ReadOnly = True
        cboTipoEstudio.ReadOnly = True
        cboEspecimen.ReadOnly = True
        txtNumeroEstudio.Enabled = False
        bbiGuardar.Enabled = False
        _IdUsuarioOrden = Nothing
        _IdUsuario = Nothing
        ValorRecibo = CDec(colDOCopago.SummaryItem.SummaryValue)
    End Sub
    Private Sub EditarEntregaResultados()
        Dim _EntregaResultados As New SIM___GLOBAL.Modelo.EntregaResultados
        Dim _DEntregaResultados As New SIM___GLOBAL.Controles.DEntregaResultados

        _EntregaResultados = _DEntregaResultados.Cargar(_ClickIdOrden)
        dtFechaEntrega.Text = _EntregaResultados.FechaEntrega

    End Sub
#End Region
    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")

        Select Case Licencia
            Case 6, 11, 16 '6-KELLY, 11-CITOPAT Y 16-CD PATOLOGIA ONCOLOGICA
                colORDEN.Visible = False
                LabelControl13.Text = "Fec. Toma Muestra"
            Case Else
                colCONSECUTIVO2.Visible = False
        End Select

        'LLenamos grilla Ordenes
        ActualizarGrilla()

        'llenamos GridCONTROL Usuarios
        _ds = New DataSet
        _ds = _dUsuarios.ListarUltimosRegistros()
        GCConsultar.DataSource = _ds.Tables(0)

        'llenamos GridCONTROL Agendados
        _ds = New DataSet
        _ds = _DAgenda.ListarAgendaHoy
        GCAgendados.DataSource = _ds.Tables(0)

        ' Cargar Tipo Afiliado
        Dim _Dtipoafiliado = New DTipoAfiliado
        _ds = _Dtipoafiliado.Listar
        cboTipoAfiliado.Properties.DataSource = _ds.Tables(0)
        cboTipoAfiliado.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoAfiliado.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoAfiliado.ItemIndex = 0

        ' Cargar Tipo Usuario
        Dim _DtipoUsuario = New DTipoUsuario
        _ds = _DtipoUsuario.Listar
        cboTipoUsuario.Properties.DataSource = _ds.Tables(0)
        cboTipoUsuario.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoUsuario.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoUsuario.ItemIndex = 0

        ' Cargar Ambito Procedimiento
        Dim _DAmbitoProcedimiento = New SIM___GLOBAL.DAmbitoProcedimiento
        _ds = _DAmbitoProcedimiento.Listar
        cboAmbitoProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboAmbitoProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboAmbitoProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboAmbitoProcedimiento.ItemIndex = 0
        '---------------------------------

        ' Cargar FINALIDAD
        Dim _DFinalidad = New SIM___GLOBAL.Controles.DFinalidadConsulta
        _ds = _DFinalidad.Listar
        cboFinalidad.Properties.DataSource = _ds.Tables(0)
        cboFinalidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboFinalidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboFinalidad.ItemIndex = 9
        '---------------------------------

        ' Cargar Tipo Estudio
        Dim _DTipoEstudio = New DTipoEstudio
        _ds = _DTipoEstudio.Listar
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoEstudio.ItemIndex = 0
        '---------------------------------
        ' Cargar Contratos
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1

        ' Cargar Especialista
        Dim _Dempleados = New DEmpleados
        _ds = _Dempleados.ListarEspecialista
        cboMedico.Properties.DataSource = _ds.Tables(0)
        cboMedico.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedico.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMedico.ItemIndex = -1

        ' Cargar Sedes
        Dim _DSedes = New DSedes
        _ds = _DSedes.ListarCombo
        cboSede.Properties.DataSource = _ds.Tables(0)
        cboSede.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSede.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboSede.ItemIndex = 0

        'Cargar especimenes
        _ds = New DataSet()
        _ds = _DEspecimenes.Listar()
        cboEspecimen.Properties.DataSource = _ds.Tables(0)
        cboEspecimen.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEspecimen.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboEspecimen.ItemIndex = 0

        'NuevaO = 0
        Select Case Licencia
            Case 2, 6, 11, 16 '2-INMUNOPAT, 6-KELLY, 11-CITOPAT Y CD PATOLOGIA ONCOLOGICO - Si activan los campos que se utilizan para las licencias de laboratorio de Citologia y Patologia
                lblFechaEntrega.Visible = True
                dtFechaEntrega.Visible = True
                cboTipoEstudio.Visible = True
                txtPrefijo.Visible = True
                txtNumeroEstudio.Visible = True
                lblTipoEstudio.Visible = True
                lblNumeroEstudio.Visible = True
                cboEspecimen.Visible = True
                lblEspecimen.Visible = True
                xtpAgendados.PageVisible = False
                xtpEstudios.PageVisible = True
                If Licencia = 11 Or Licencia = 16 Then
                    txtNumeroEstudio.ReadOnly = True
                End If
            Case Else
                lblFechaEntrega.Visible = False
                dtFechaEntrega.Visible = False
                'cboEspecimen.Visible = True
                'lblEspecimen.Visible = True
                xtpAgendados.PageVisible = True
                xtpEstudios.PageVisible = False
        End Select

        cboEspecimen.ItemIndex = 0
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If _IdUsuario = Nothing Then
            MessageBox.Show("No ha seleccionado el paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("La Orden actual presenta cambios sin guardar, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                NuevaOrden()
                LimpiarCampos()
            End If
        Else
            NuevaOrden()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
        If GVConsultarOrdenes.OptionsFind.AlwaysVisible = True Then
            GVConsultarOrdenes.OptionsFind.AlwaysVisible = False
        Else
            GVConsultarOrdenes.OptionsFind.AlwaysVisible = True
        End If
        If GVAgendados.OptionsFind.AlwaysVisible = True Then
            GVAgendados.OptionsFind.AlwaysVisible = False
        Else
            GVAgendados.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged

        'LIMPIAMOS CAMPOS DETALLE ORDEN
        txtCodigoProcedimiento.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
        txtValor.Text = ""
        txtCodigoCups.Text = ""

        'llenamos combo procedimientos
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo2(cboContrato.GetColumnValue("ID"))
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos combo subentidades
        Dim _DSubentidades = New DSudentidades
        _ds = New DataSet()

        _ds = _DSubentidades.ListarComboActivas(cboContrato.GetColumnValue("ID"), "I")
        cboSubentidades.Properties.DataSource = _ds.Tables(0)
        cboSubentidades.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSubentidades.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboSubentidades.Properties.PopulateColumns()
        'cboSubentidades.Properties.Columns("ID").Visible = False
        cboSubentidades.ItemIndex = 0

        ActivarGuardar()
    End Sub

    Private Sub cboTipoAfiliado_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoAfiliado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoUsuario.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboAmbitoProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboAmbitoProcedimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboFinalidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboFinalidad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtComentarios_EditValueChanged(sender As Object, e As EventArgs) Handles txtComentarios.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboSubentidades_EditValueChanged(sender As Object, e As EventArgs) Handles cboSubentidades.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaOrden_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaOrden.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboSede_EditValueChanged(sender As Object, e As EventArgs) Handles cboSede.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboMedico_EditValueChanged(sender As Object, e As EventArgs) Handles cboMedico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAutorizacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtAutorizacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroOrden_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroOrden.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoEstudio.EditValueChanged
        txtPrefijo.Text = cboTipoEstudio.GetColumnValue("PREFIJO")
        ActivarGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaOrden.Text = "" Then
            MessageBox.Show("La fecha de Orden es Obligatoria", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Contrato", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboMedico.Text = "" Then
            MessageBox.Show("Debe seleccionar el medico", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTipoEstudio.Text = "" And cboTipoEstudio.Visible = True Then
            MessageBox.Show("Debe seleccionar el Tipo de Estudio", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleOrden.RowCount = 0 Then
            MessageBox.Show("Falta los servicios a prestar al paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Sexo = "M" And (cboTipoEstudio.GetColumnValue("ID") = 1 Or cboTipoEstudio.GetColumnValue("ID") = 2) And (Licencia = 2 Or Licencia = 6 Or Licencia = 11) Then
            MessageBox.Show("Tipo de estudio invalido", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtNumeroEstudio.Text = "" And (Licencia = 2 Or Licencia = 6) Then
            MessageBox.Show("Debe digitar el numero de estudio a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenes.ExisteConsecutivo(txtPrefijo.Text & txtNumeroEstudio.Text & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)) = True And (Licencia = 2 Or Licencia = 16) Then
            MessageBox.Show("Numero de consecutivo ya existe", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaEntrega.Text = "" And (Licencia = 11 Or Licencia = 16) Then
            MessageBox.Show("Fecha de entrega invalida", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtConsecutivo.Text = "" Then
                GuardarOrdenes()

                'Buscamos el ultimo consecutivo de orden registrado
                _Ordenes = _DOrdenes.UltimoRegistroPaciente(CStr(_IdUsuario))

                'Consultamos si el usuario tiene contraseña para la descarga de resultados
                Select Case Licencia
                    Case 11, 16 ' 11-CITOPAT y 16-CD PATOLOGIA ONCOLOGICA
                        If _DSesiones.ExisteUsuario(_IdUsuario) = False Then
                            _Sesiones.Id = Val("")
                            _Sesiones.IdUsuario = _IdUsuario

                            '_Sesiones.Contrasena = Mid(_Id.ToString, 1, 6)
                            _Sesiones.Contrasena = Mid(Identificacion.ToString, Len(Identificacion.ToString) - 3) & "C"
                            _DSesiones.Guardar(_Sesiones)
                            'Contrasena = Mid(_Id.ToString, 1, 6)
                            Contrasena = Mid(Identificacion.ToString, Len(Identificacion.ToString) - 3) & "C"
                        Else
                            _Sesiones = _DSesiones.Cargar(_IdUsuario)
                            Contrasena = _Sesiones.Contrasena
                        End If
                    Case Else
                End Select

                'Guardamos la citologia o patologia correspondiente a la orden registrada
                Select Case Licencia
                    '2 - LABORATORIO DE INMUNOPATOLOGICO DE LA COSTA
                    '6 - KELLY GOMEZ
                    '11 - CITOPAT
                    Case 2, 6, 11, 16 '2-INMUNOPAT, 6-KELLY, 11-CITOPAT Y 16-CD PATOLOGIA ONCOLOGICA
                        GuardarEstudio()
                        'Guardamos el registro de lo realizado por el usuario
                        _funciones.GuardarRegistro("3", _Ordenes.Id, IDEmpleado, "Registro", Consecutivo)
                        GuardarEntregaResultados()
                    Case Else
                        'Guardamos el registro de lo realizado por el usuario
                        _funciones.GuardarRegistro("3", _Ordenes.Id, IDEmpleado, "Registro", "")
                End Select

                'Actualizamos del Id Temporal al ID definitivo de la Orden en la tabla DETALLE_ORDEN
                _DDetalleOrden.ActualizarDetalleOrden(_Ordenes.Id, _Id.ToString)

                'Actualizamos la agenda con el ID_ORDEN
                If IdAgenda <> "" Then
                    _DAgenda.ActualizarAgenda(IdAgenda, _Ordenes.Id)
                End If

                'Mensaje del numero de Orden Generada
                Dim _frmMensaje As New SIM___GLOBAL.frmMensaje

                Select Case Licencia
                    Case 2, 6 '2-Inmunopat, 6-Kelly  
                        'If Licencia = 16 Then
                        ' _frmMensaje.NumeroOrden = txtNumeroEstudio.Text & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                        ' Else
                        ' _frmMensaje.NumeroOrden = txtPrefijo.Text & txtNumeroEstudio.Text & "-" & Mid(Year(dtFechaIngreso.Text), 3, 2)
                        ' End If

                        _frmMensaje.lblCodigoR.Visible = True
                        _frmMensaje.lblCodigo.Visible = True
                        _frmMensaje.lblCodigo.Text = Contrasena
                    Case 11, 16 '11-Citopat de la Costa 16-Cd Patologia Oncologica
                        _frmMensaje.NumeroOrden = Consecutivo
                        _frmMensaje.lblCodigoR.Visible = True
                        _frmMensaje.lblCodigo.Visible = True
                        _frmMensaje.lblCodigo.Text = Contrasena

                    Case Else
                        _frmMensaje.NumeroOrden = _Ordenes.Id
                End Select

                _frmMensaje.ShowDialog()

                'Imprimimos el recibo de entrega de resultados
                Select Case Licencia
                    Case 11 '11-CITOPAT
                        ImprimirFrm.ImprimirReciboEntregaResultados(_Ordenes.Id, Licencia)
                    Case Else
                End Select

                'txtNumeroEstudio.Text = NumeroEstudio
                txtConsecutivo.Text = _Ordenes.Id
                'cboContrato.ReadOnly = True
                'End If

                'Validamos si se genera un recibo de caja                 
                Select Case Licencia
                    Case 11 'CITOPAT
                        If colDOCopago.SummaryItem.SummaryValue > 0 Then

                            IdCliente = _DClientes.IdCliente(Mid(Identificacion, 1, 2), Mid(Identificacion, 3, Len(Identificacion) - 2))
                            'Guardamos el movimiento del cliente

                            GuardarCuentaCliente()

                            If MessageBox.Show("¿Desea generar un recibo de caja?", "Recibo de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Dim _frmOpen As New SIM___GLOBAL.frmReciboCaja
                                _frmOpen.IdCliente = IdCliente
                                _frmOpen.IdOrden = txtConsecutivo.Text
                                _frmOpen.Empleado = Empleado
                                _frmOpen.IdEmpleado = IDEmpleado
                                _frmOpen.Licencia = Licencia
                                _frmOpen.ShowDialog()
                            End If
                        End If
                    Case Else
                End Select

            ElseIf txtConsecutivo.Text <> "" And _DOrdenes.OrdenPendiente(txtConsecutivo.Text) = True Then
                GuardarOrdenes()

                'Guardamos el registro de lo realizado por el usuario
                If Licencia = 16 Then
                    _funciones.GuardarRegistro("3", txtConsecutivo.Text, IDEmpleado, "Actualizacion", "" & txtNumeroEstudio.Text)
                Else
                    _funciones.GuardarRegistro("3", txtConsecutivo.Text, IDEmpleado, "Actualizacion", txtPrefijo.Text & txtNumeroEstudio.Text)
                End If


                'Validamos si se genera un recibo de caja                 
                If Licencia = 11 Then '11 - CITOPAT
                    If colDOCopago.SummaryItem.SummaryValue > 0 Then
                        If _DCuentasClientes.ExisteCuentaCliente(txtConsecutivo.Text, "OM") = False Then

                            IdCliente = _DClientes.IdCliente(Mid(Identificacion, 1, 2), Mid(Identificacion, 3, Len(Identificacion) - 2))

                            GuardarCuentaCliente()

                            If MessageBox.Show("¿Desea generar un recibo de caja?", "Recibo de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Dim _frmOpen As New SIM___GLOBAL.frmReciboCaja
                                _frmOpen.IdCliente = IdCliente
                                _frmOpen.IdOrden = txtConsecutivo.Text
                                _frmOpen.Empleado = Empleado
                                _frmOpen.IdEmpleado = IDEmpleado
                                _frmOpen.Licencia = Licencia
                                _frmOpen.ShowDialog()
                            End If
                        End If
                    End If
                End If

                GuardarEntregaResultados()

            Else
                MessageBox.Show("Esta orden no puede ser actualizada porque esta Cancelada o Atendida", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            LimpiarCampos()
            _IdUsuario = Nothing
            _ClickIdAgenda = Nothing
            GCDatosUsuarios.DataSource = Nothing
            'NuevaO = 0
            ActualizarGrilla()
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TVDatosUsuarios.RowCount = 0 Then
            MessageBox.Show("Debe seleccionar el paciente y dar click en nueva orden", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCodigoProcedimiento.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Procedimiento a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Val(txtValor.EditValue) - Val(txtCopago.EditValue)) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Sexo = "M" And (_idTipoEstudio = 1 Or _idTipoEstudio = 2) And Licencia = 2 Then
            MessageBox.Show("Tipo de estudio invalido", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Asignamos el Id relacionado con el detalle_orden_factura
            _IdRelacion = Guid.NewGuid()

            GuardarDetalleOrden()
            GuardarDetalleFactura()

            'Buscamos el ultimo registro del detalle_orden
            Dim UltimoIdDetalleOrden As String
            UltimoIdDetalleOrden = _DDetalleOrden.UltimoRegistro

            'Guardamos el registro de lo realizado por el usuario
            _funciones.GuardarRegistro("4", UltimoIdDetalleOrden, IDEmpleado, "Registro", "")

            ActualizarGrillaDetalleOrden(_Ordenes.Id)
            LimpiarCamposDetalleOrden()
            bbiGuardar.Enabled = True

            If GVDetalleOrden.RowCount <> 0 Then
                cboContrato.Enabled = False
            End If
            'cboProcedimiento.Text = ""

            'If txtConsecutivo.Text <> "" Then
            ' Dim funciones = New Funciones
            'Funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
            'End If
        End If
    End Sub

    Private Sub cboProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.EditValueChanged
        If cboProcedimiento.Text <> "" And TVDatosUsuarios.RowCount <> 0 Then
            _ds = New DataSet
            _ds = _DDetalleTarifa.ListarValor(cboContrato.GetColumnValue("ID"), cboProcedimiento.EditValue)

            txtCodigoProcedimiento.Text = _ds.Tables(0).Rows(0)(0).ToString
            _idTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString
            txtValor.Text = _ds.Tables(0).Rows(0)(2).ToString
            txtCodigoCups.Text = _ds.Tables(0).Rows(0)(3).ToString
            _TipoAtencion = _ds.Tables(0).Rows(0)(4).ToString
        End If
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub txtCopago_Leave(sender As Object, e As EventArgs) Handles txtCopago.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickIdDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleOrden.RowCount = 1 And txtConsecutivo.Text <> "" Then
            MessageBox.Show("La Orden no puede quedar sin detalle. Agregue el servicio correcto y luego elimine el incorrecto", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtConsecutivo.Text <> "" And _DDetalleOrden.ExisteImagen(_ClickIdDetalleOrden) = True Then
            MessageBox.Show("No se puede eliminar el registro porque tiene fotos capturadas", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtConsecutivo.Text <> "" And _DDetalleOrden.ExisteEstudio(_ClickIdDetalleOrden) = True Then
            MessageBox.Show("No se puede eliminar el registro porque el procedimiento ya fue guardado.", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Guardamos el registro de eliminacion del detalle orden 
            _funciones.GuardarRegistro("4", _ClickIdDetalleOrden, IDEmpleado, "Eliminacion", "")

            If txtConsecutivo.Text = "" Then
                _DDetalleOrden.Eliminar(_ClickIdDetalleOrden)
                _DDetalleOrdenFactura.Eliminar(_ClickIdRelacion)
            Else
                _DDetalleOrden.Cancelar(_ClickIdDetalleOrden)
                _DDetalleOrdenFactura.Cancelar(_ClickIdRelacion)
            End If

            ActualizarGrillaDetalleOrden(_Ordenes.Id)
            _ClickIdDetalleOrden = ""

            If GVDetalleOrden.RowCount <> 0 Then
                cboContrato.Enabled = False
            Else
                cboContrato.Enabled = True
            End If

            'LimpiarCamposDetalleOrden()
            '            Dim funciones = New Funciones
            'Funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        End If
    End Sub

    Private Sub GVDetalleOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleOrden.RowClick
        If e.RowHandle >= 0 Then
            '_ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            '_ClickTipoEstudio = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickIdRelacion = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "IDRELACION").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub frmOrdenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False

                If txtConsecutivo.Text = "" And GVDetalleOrden.RowCount <> 0 Then
                    _DDetalleOrden.EliminarDetalleOrden(_Id.ToString)
                    _DDetalleOrdenFactura.EliminarDetalleOrdenFactura(_Id.ToString)
                End If
            Else
                e.Cancel = True
            End If
        Else
            If txtConsecutivo.Text = "" And GVDetalleOrden.RowCount <> 0 Then
                _DDetalleOrden.EliminarDetalleOrden(_Id.ToString)
                _DDetalleOrdenFactura.EliminarDetalleOrdenFactura(_Id.ToString)
            End If

            'Dim funciones = New Funciones
            'Funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdOrden = Nothing Then
            MessageBox.Show("Debe seleccionar una Orden", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenes.OrdenPendiente(_ClickIdOrden) = False Then
            MessageBox.Show("Solo se puede editar la Orden si esta en estado PENDIENTE", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DBloqueoRegistros.ExisteIdOrden(_ClickIdOrden) = True Then
            MessageBox.Show("La orden esta ocupada por otro usuario", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("La orden: " & _ClickIdOrden & " esta ocupada por el Usuario: " & _ds.Tables(0).Rows(0)(2).ToString(), "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si presiona Aceptar perdera los cambios y Editara la Orden seleccionada", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EditarOrden()
                If Licencia = 11 Then
                    EditarEntregaResultados()
                End If
            End If
        Else
            If MessageBox.Show("¿Desea editar la Orden seleccionada?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EditarOrden()
                If Licencia = 11 Then
                    EditarEntregaResultados()
                End If
            End If
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _IdUsuario = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVConsultarOrdenes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultarOrdenes.RowClick
        If e.RowHandle >= 0 Then
            '_ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _IdUsuarioOrden = GVConsultarOrdenes.GetRowCellValue(e.RowHandle.ToString, "IDUSUARIO").ToString()
            _ClickIdOrden = GVConsultarOrdenes.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        If txtConsecutivo.Text = Nothing Then
            MessageBox.Show("Debe seleccionar una Orden", "Cancelar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenes.OrdenPendiente(txtConsecutivo.Text) = False Then
            MessageBox.Show("Esta orden no se puede cancelar", "Cancelar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea cancelar la Orden", "Cancelar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                Select Case Licencia
                    Case 6, 16 ' Kelly Gomez y CD PATOLOGIA ONCOLOGICA
                        _DOrdenes.CancelarOrdenManual(txtConsecutivo.Text, "CANCELADO")
                    Case Else
                        _DOrdenes.ActualizarEstado(txtConsecutivo.Text, "CANCELADO")
                End Select

                _DDetalleOrden.ActualizarEstadoOrden(txtConsecutivo.Text, "CANCELADO")
                LimpiarCampos()
                _IdUsuario = Nothing
                GCDatosUsuarios.DataSource = Nothing
                'NuevaO = 0
                ActualizarGrilla()
            End If
        End If
    End Sub

    Private Sub bbiUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IDEmpleado
        _frmOpen.ShowDialog()
        'LLENAR GRID VIEW 
        '_ds = New DataSet
        '_ds = _dUsuarios.Listar()
        'GCConsultar.DataSource = _ds.Tables(0)
        'llenamos GridCONTROL Usuarios
        _ds = New DataSet
        _ds = _dUsuarios.ListarUltimosRegistros()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub GVAgendados_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVAgendados.RowClick
        If e.RowHandle >= 0 Then
            _IdUsuario = GVAgendados.GetRowCellValue(e.RowHandle.ToString, "IDUSUARIO").ToString()
            _ClickIdAgenda = GVAgendados.GetRowCellValue(e.RowHandle.ToString, "IDAGENDA").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEspecimen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecimen.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecimenes
        _frmOpen.ShowDialog()
        'Cargar especimenes
        _ds = New DataSet()
        _ds = _DEspecimenes.Listar()
        cboEspecimen.Properties.DataSource = _ds.Tables(0)
        cboEspecimen.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEspecimen.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub

    Private Sub dtFechaEntrega_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaEntrega.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVDetalleOrden_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVDetalleOrden.RowUpdated
        If e.RowHandle >= 0 Then
            _DOrdenes.ActualizarValoryCopago(GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString(), GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString(), GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "COPAGO").ToString())
        End If
    End Sub
    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.Listarultimosregistros()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub tsmTodoslosRegistros_Click(sender As Object, e As EventArgs) Handles tsmTodoslosRegistros.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

End Class
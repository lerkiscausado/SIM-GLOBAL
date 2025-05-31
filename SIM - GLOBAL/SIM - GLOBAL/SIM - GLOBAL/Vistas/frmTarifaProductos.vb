Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmTarifaProductos
    Public Licencia As String
    Public IdEmpleado As String
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _ClickIdTarifaProducto As String
    Dim _ClickIdDetalleTarifa As String
    Dim _Fila As String
    Dim _DTarifaProductos As New DTarifaProductos
    Dim _TarifaProductos As New TarifaProductos
    Dim _DetalleTarifaProductos As New SIM___GLOBAL.Modelo.DetalleTarifaProductos
    Dim _DDetalleTarifaProductos As New SIM___GLOBAL.Controles.DDetalleTarifaProductos
    Dim _DPresentacionProductos As New SIM___GLOBAL.Controles.DPresentacionProductos
    Private Sub Guardar()
        Try
            _TarifaProductos.Id = Val(txtID.Text)
            _TarifaProductos.Nombre = txtNombre.Text
            If chkEstado.Checked = True Then
                _TarifaProductos.Estado = "A"
            Else
                _TarifaProductos.Estado = "I"
            End If
            _DTarifaProductos.Guardar(_TarifaProductos)
            bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GuardarDetalleTarifaProducto()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleTarifaProductos.IdTarifaProducto = Val(txtID.Text)
        Else
            _DetalleTarifaProductos.IdTarifaProducto = _Id.ToString
        End If
        _DetalleTarifaProductos.IdProducto = cboProducto.EditValue
        _DetalleTarifaProductos.Valor = Val(txtValor.Text)
        _DetalleTarifaProductos.Iva = Val(txtIVA.Text)
        _DetalleTarifaProductos.Estado = "A"
        _DDetalleTarifaProductos.Guardar(_DetalleTarifaProductos)

    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = True
        txtNombre.Enabled = True
        bbiGuardar.Enabled = False
        _Id = Nothing
    End Sub
    Private Sub LimpiarCamposDetalleTarifa()
        txtValor.Text = ""
        txtIVA.Text = ""
        cboProducto.EditValue = ""

    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DTarifaProductos.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrillaDetalleTarifa()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtID.Text = "" Then
            _ds = _DDetalleTarifaProductos.Listar(_Id.ToString)
        Else
            _ds = _DDetalleTarifaProductos.Listar(txtID.Text)
        End If
        GCDetalleTarifa.DataSource = _ds.Tables(0)
    End Sub
    Private Sub EditarTarifaProducto()
        If MessageBox.Show("Desea Editar la Tarifa?", "Editar Tarifa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            _TarifaProductos = _DTarifaProductos.Cargar(_ClickIdTarifaProducto)
            txtID.Enabled = False
            'txtNombre.Enabled = False
            txtID.Text = _ClickIdTarifaProducto
            txtNombre.Text = _TarifaProductos.Nombre
            If _TarifaProductos.Estado = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
            bbiGuardar.Enabled = False
            ActualizarGrillaDetalleTarifa()
        End If
    End Sub
    Private Sub frmTarifaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        'llenamos combo productos
        _ds = New DataSet()
        _ds = _DPresentacionProductos.ListarComboPyS()
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("La Tarifa del producto actual presenta cambios sin guardar, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Tarifa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                LimpiarCamposDetalleTarifa()

                'LLENAR GRID VIEW 
                '_ds = New DataSet
                '_ds = _DDetalleTarifaProductos.Listar("")
                'GCDetalleTarifa.DataSource = _ds.Tables(0)
                GCDetalleTarifa.DataSource = Nothing
            End If
        Else
            LimpiarCampos()
            LimpiarCamposDetalleTarifa()

            'LLENAR GRID VIEW 
            '_ds = New DataSet
            '_ds = _DDetalleTarifaProductos.Listar("")
            'GCDetalleTarifa.DataSource = _ds.Tables(0)
            GCDetalleTarifa.DataSource = Nothing
        End If
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickIdTarifaProducto = "" Then
            MessageBox.Show("No ha seleccionado la tarifa", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarTarifaProducto()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleTarifa.RowCount = 0 Then
            MessageBox.Show("La tarifa del producto no tiene detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf txtID.Text <> "" And chkEstado.Checked = False And _DTarifaproductos.ExisteTarifaContrato(txtID.Text) = True Then
            '   MessageBox.Show("Esta tarifa no puede ser Inactivada porque esta configurada en un contrato", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            If txtID.Text = "" Then
                _TarifaProductos = _DTarifaProductos.UltimoRegistro()
                txtID.Text = _TarifaProductos.Id
                _DDetalleTarifaProductos.ActualizarDetalleTarifa(txtID.Text, _Id.ToString)
            End If
            ActualizarGrilla()
            LimpiarCampos()
            ActualizarGrillaDetalleTarifa()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdTarifaProducto = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("La tarifa debe tener un nombre", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProducto.Text = "" Then
            MessageBox.Show("Debe Seleccionar un Estudio, el Campo es Obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.Text = "" Then
            MessageBox.Show("El Campo Valor es obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleTarifaProducto()
            ActualizarGrillaDetalleTarifa()
            LimpiarCamposDetalleTarifa()
        End If
    End Sub

    Private Sub frmTarifaProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Tarifa pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Tarifa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If txtID.Text = Nothing And GVDetalleTarifa.RowCount <> 0 Then
                    _DDetalleTarifaProductos.EliminarDetalleTarifa(_Id.ToString)
                End If
            Else
                e.Cancel = True
            End If
        Else
            If txtID.Text = Nothing And GVDetalleTarifa.RowCount <> 0 Then
                _DDetalleTarifaProductos.EliminarDetalleTarifa(_Id.ToString)
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickIdDetalleTarifa = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleTarifa.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La tarifa no puede quedar sin detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleTarifaProductos.EliminarItemDetalleTarifa(_ClickIdDetalleTarifa)
            ActualizarGrillaDetalleTarifa()
            LimpiarCamposDetalleTarifa()
            _ClickIdDetalleTarifa = ""
        End If
    End Sub

    Private Sub GVDetalleTarifa_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleTarifa.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdDetalleTarifa = GVDetalleTarifa.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        If _ClickIdTarifaProducto = "" Then
            MessageBox.Show("Debe seleccionar una Tarifa", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ImprimirFrm.ImprimirTarifaProductos(_ClickIdTarifaProducto)
        End If
    End Sub
End Class
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Public Class frmTarifas
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _Id As New Guid
    Dim _ClickIdTarifa As String
    Dim _ClickGrillaDetalleTarifa As String
    Dim _Fila As String

    Dim _DTarifas As New SIM___GLOBAL.Controles.DTarifas
    Dim _Tarifas As New SIM___GLOBAL.My.Modelo.Tarifas
    Dim _DDetalleTarifa As New PEC___App.Controles.DDetalleTarifa
    Dim _DetalleTarifa As New PEC___App.Modelo.DetalleTarifa
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
        cboTipoEstudio.EditValue = Nothing
    End Sub
    Private Sub ComboTipoEstudio()
        ' Cargar Tipo Estudio
        Dim _DTipoEstudio = New DTipoEstudio
        _ds = _DTipoEstudio.Listar
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoEstudio.ItemIndex = -1
    End Sub
    Private Sub Guardar()
        Try
            _Tarifas.Id = Val(txtID.Text)
            _Tarifas.Nombre = txtNombre.Text
            If chkEstado.Checked = True Then
                _Tarifas.Estado = "A"
            Else
                _Tarifas.Estado = "I"
            End If
            _DTarifas.Guardar(_Tarifas)

            bbiGuardar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GuardarDetalleTarifa()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleTarifa.IdTarifa = Val(txtID.Text)
        Else
            _DetalleTarifa.IdTarifa = _Id.ToString
        End If
        _DetalleTarifa.IdTipoEstudio = cboTipoEstudio.GetColumnValue("ID")
        _DetalleTarifa.Valor = Val(txtValor.Text)
        _DetalleTarifa.IVA = Val(cboIVA.EditValue)
        _DetalleTarifa.Estado = "A"
        _DDetalleTarifa.Guardar(_DetalleTarifa)

    End Sub
    Private Sub EditarTarifa()
        If MessageBox.Show("Desea Editar la Tarifa?", "Editar Tarifa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            _Tarifas = _DTarifas.Cargar(_ClickIdTarifa)
            txtID.Enabled = False
            txtID.Text = _ClickIdTarifa
            txtNombre.Text = _Tarifas.Nombre
            If _Tarifas.Estado = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
            bbiGuardar.Enabled = False
            ActualizarGrillaDetalleTarifa()
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        Dim _DTarifas As New DTarifas
        _ds = _DTarifas.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrillaDetalleTarifa()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtID.Text = "" Then
            _ds = _DDetalleTarifa.Listar(_Id.ToString)
        Else
            _ds = _DDetalleTarifa.Listar(txtID.Text)
        End If
        GCDetalleTarifa.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub frmTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        ComboTipoEstudio()

        cboIVA.SelectedIndex = 0
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("La Tarifa actual presenta cambios sin guardar, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Tarifa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                LimpiarCamposDetalleTarifa()

                'LLENAR GRID VIEW 
                '_ds = New DataSet
                '_ds = _DDetalleTarifa.Listar("")
                GCDetalleTarifa.DataSource = Nothing
            End If
        Else
            LimpiarCampos()
            LimpiarCamposDetalleTarifa()

            'LLENAR GRID VIEW 
            '_ds = New DataSet
            '_ds = _DDetalleTarifa.Listar("")
            GCDetalleTarifa.DataSource = Nothing
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdTarifa = "" Then
            MessageBox.Show("No ha seleccionado la tarifa", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarTarifa()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleTarifa.RowCount = 0 Then
            MessageBox.Show("La tarifa no tiene detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtID.Text <> "" And chkEstado.Checked = False And _DTarifas.ExisteTarifaContrato(txtID.Text) = True Then
            MessageBox.Show("Esta tarifa no puede ser Inactivada porque esta configurada en un contrato", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            If txtID.Text = "" Then
                _Tarifas = _DTarifas.UltimoRegistro()
                txtID.Text = _Tarifas.Id
                _DDetalleTarifa.ActualizarDetalleTarifa(txtID.Text, _Id.ToString)
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
        If GVDetalleTarifa.OptionsFind.AlwaysVisible = True Then
            GVDetalleTarifa.OptionsFind.AlwaysVisible = False
        Else
            GVDetalleTarifa.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub frmTarifas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Tarifa pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Tarifa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If txtID.Text = "" And GVDetalleTarifa.RowCount <> 0 Then
                    _DDetalleTarifa.EliminarDetalleTarifa(_Id.ToString)
                End If
            Else
                e.Cancel = True
            End If
        Else
            If txtID.Text = "" And GVDetalleTarifa.RowCount <> 0 Then
                _DDetalleTarifa.EliminarDetalleTarifa(_Id.ToString)
            End If
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdTarifa = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("La tarifa debe tener un nombre", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTipoEstudio.Text = "" Then
            MessageBox.Show("Debe Seleccionar un Estudio, el Campo es Obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.Text = "" Then
            MessageBox.Show("El Campo Valor es obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleTarifa()
            ActualizarGrillaDetalleTarifa()
            LimpiarCamposDetalleTarifa()
            _ClickGrillaDetalleTarifa = ""
            ActivarGuardar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaDetalleTarifa = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleTarifa.RowCount = 1 Then
            MessageBox.Show("La tarifa no puede quedar sin detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleTarifa.EliminarItemDetalleTarifa(_ClickGrillaDetalleTarifa)
            ActualizarGrillaDetalleTarifa()
            LimpiarCamposDetalleTarifa()
            _ClickGrillaDetalleTarifa = ""
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub GVDetalleTarifa_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleTarifa.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDetalleTarifa = GVDetalleTarifa.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
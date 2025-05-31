Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmSubEntidades
    Dim _ds As DataSet
    Dim _dSubEntidades As New DSudentidades
    Dim _SubEntidades As New Subentidades
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dContratos As New DContratos
    Private Sub ActivarGuardar()
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dSubEntidades.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        cboContratos.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        _SubEntidades.Id = Val(txtID.Text)
        _SubEntidades.Nombre = txtNombre.Text
        _SubEntidades.IdContrato = cboContratos.GetColumnValue("ID")

        If chkEstado.Checked = True Then
            _SubEntidades.Estado = "A"
        Else
            _SubEntidades.Estado = "I"

        End If
        _dSubEntidades.Guardar(_SubEntidades)

    End Sub
    Private Sub frmSubEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()

        'llenamos campo Cargos
        _ds = New DataSet()
        _ds = _dContratos.ListarCombo()
        cboContratos.Properties.DataSource = _ds.Tables(0)
        cboContratos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContratos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContratos.ItemIndex = -1
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub



    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Sub Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContratos.Text = "" Then
            MessageBox.Show("Debe seleccionar el Contrato", "Registro de Sub Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado la Sub Entidad", "Registro de Sub Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                If MessageBox.Show("Desea Editar la SubEntidad?", "Editar Registros ",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.Yes Then

                    _SubEntidades = _dSubEntidades.Cargar(_ClickGrilla)
                    txtID.Text = _ClickGrilla
                    txtNombre.Text = _SubEntidades.Nombre
                    cboContratos.ItemIndex = cboContratos.Properties.GetDataSourceRowIndex("ID", _SubEntidades.IdContrato)
                    If _SubEntidades.Estado = "I" Then
                        chkEstado.Checked = False
                    Else
                        chkEstado.Checked = True
                    End If
                    bbiGuardar.Enabled = False
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado la Sub Entidad", "Registro de Sub Entidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                If MessageBox.Show("Desea Editar la SubEntidad?", "Editar Registros ",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.Yes Then

                    _SubEntidades = _dSubEntidades.Cargar(_ClickGrilla)
                    txtID.Text = _ClickGrilla
                    txtNombre.Text = _SubEntidades.Nombre
                    cboContratos.ItemIndex = cboContratos.Properties.GetDataSourceRowIndex("ID", _SubEntidades.IdContrato)
                    If _SubEntidades.Estado = "I" Then
                        chkEstado.Checked = False
                    Else
                        chkEstado.Checked = True
                    End If
                    bbiGuardar.Enabled = False
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboContratos_EditValueChanged(sender As Object, e As EventArgs) Handles cboContratos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
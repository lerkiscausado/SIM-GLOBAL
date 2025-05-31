Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Public Class frmDetalleTarifa
    Dim _ds As DataSet
    Dim _DDetalleTarifa = New DDetalleTarifas
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _DetalleTarifa As New DetalleTarifa
    ReadOnly _DTarifas = New DTarifas
    ReadOnly _DCups = New DCups
    'ReadOnly _departamentos = New DDepartamentos
    'ReadOnly _municipios = New DMunicipios
    Private Sub frmDetalleTarifa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSDetalleTarifa.DTDetalleTarifa' Puede moverla o quitarla según sea necesario.
        Me.DTDetalleTarifaTableAdapter.Fill(Me.DSDetalleTarifa.DTDetalleTarifa)
        cboTipoAtencion.SelectedIndex = 0

        'llenamos campo Tarifas
        _ds = New DataSet()
        _ds = _DTarifas.listar()
        cboTarifa.Properties.DataSource = _ds.Tables(0)
        cboTarifa.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTarifa.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTarifa.ItemIndex = 0

        'llenamos campo Cups
        _ds = New DataSet()
        _ds = _DCups.listaractivos()
        cboCups.Properties.DataSource = _ds.Tables(0)
        cboCups.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboCups.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboCups.ItemIndex = 0


    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtCodigo.Text = ""
        txtEstudio.Text = ""
        txtValor.Text = ""
        cboTipoAtencion.SelectedIndex = 0
        cboTarifa.Enabled = True
        txtCodigo.Enabled = True
        txtEstudio.Enabled = True
        chkEstado.Checked = False
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
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
    Private Sub Editar()
        'txtCodigo.Enabled = False
        _DetalleTarifa = _DDetalleTarifa.Cargar(_ClickGrilla)
        txtID.Text = _ClickGrilla
        cboTarifa.ItemIndex = cboTarifa.Properties.GetDataSourceRowIndex("ID", _DetalleTarifa.IdTarifa)
        txtCodigo.Text = _DetalleTarifa.CodigoProcedimiento
        txtEstudio.Text = _DetalleTarifa.IDTipoEstudio
        cboCups.ItemIndex = cboCups.Properties.GetDataSourceRowIndex("ID", _DetalleTarifa.CodigoCups)
        txtValor.Text = _DetalleTarifa.Valor
        cboTipoAtencion.Text = _DetalleTarifa.TipoAtencion
        If _DetalleTarifa.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If
        cboTarifa.Enabled = False
        txtCodigo.Enabled = False
        txtEstudio.Enabled = False
    End Sub
    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el Detalle de Tarifa", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                    Editar()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub Guardar()
        _DetalleTarifa.Id = Val(txtID.Text)
        _DetalleTarifa.IdTarifa = cboTarifa.GetColumnValue("ID")
        _DetalleTarifa.CodigoProcedimiento = txtCodigo.Text
        _DetalleTarifa.IDTipoEstudio = txtEstudio.Text
        _DetalleTarifa.CodigoCups = cboCups.GetColumnValue("ID")
        _DetalleTarifa.Valor = Val(txtValor.Text)
        _DetalleTarifa.TipoAtencion = cboTipoAtencion.Text
        If chkEstado.Checked = True Then
            _DetalleTarifa.Estado = "A"
        Else
            _DetalleTarifa.Estado = "I"
        End If

        _DDetalleTarifa.Guardar(_DetalleTarifa)

        'Actualizar Grilla
        Me.DTDetalleTarifaTableAdapter.Fill(Me.DSDetalleTarifa.DTDetalleTarifa)

    End Sub
    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtCodigo.Text = "" Then
            MessageBox.Show("El Campo Codigo es obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtEstudio.Text = "" Then
            MessageBox.Show("El Campo Estudio es obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.Text = "" Then
            MessageBox.Show("El Campo Valor es obligatorio", "Registro de Detalle de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()

        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        Dim _DDetalleTarifa As New DDetalleTarifas
        If _DDetalleTarifa.ExisteCodigoTarifa(cboTarifa.GetColumnValue("ID"), txtCodigo.Text) = True Then
            MessageBox.Show("El Codigo ya ha sido registrado", "Registro de Detalle Tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Text = ""
        End If
    End Sub

End Class
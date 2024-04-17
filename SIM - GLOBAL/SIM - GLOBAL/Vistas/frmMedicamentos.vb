Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles

Public Class frmMedicamentos
    Dim _ds As DataSet
    Dim _dMedicamentos As New DMedicamentos
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _medicamentos As New Medicamentos
    Private Sub frmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVConsultar.OptionsFind.AlwaysVisible = False
        'solo mayusculas

        'llenamos la grilla de registros
        _ds = New DataSet
        _ds = _dMedicamentos.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        'GVConsultar.Columns(0).BestFit()
        'GVConsultar.Columns(1).BestFit()
        bbiGuardar.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        txtCodigo.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el medicamento", "Registro de Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                txtCodigo.Enabled = False
                txtCodigo.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "MEDICAMENTOS").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre Medicamentos es Obligatorio", "Registro de Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            _medicamentos.ID = txtCodigo.Text
            _medicamentos.Nombre = txtNombre.Text

            If chkEstado.Checked = True Then
                _medicamentos.Estado = "A"
            Else
                _medicamentos.Estado = "I"

            End If
            _dMedicamentos.Guardar(_medicamentos)
            'llenamos la grilla de registros
            _ds = New DataSet
            _ds = _dMedicamentos.Listar()
            GCConsultar.DataSource = _ds.Tables(0)
            GVConsultar.Columns(0).BestFit()
            GVConsultar.Columns(1).BestFit()

            'Limpiar campos
            txtCodigo.Text = ""
            txtNombre.Text = ""
            chkEstado.Checked = False
            bbiGuardar.Enabled = False
        End If
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub


    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
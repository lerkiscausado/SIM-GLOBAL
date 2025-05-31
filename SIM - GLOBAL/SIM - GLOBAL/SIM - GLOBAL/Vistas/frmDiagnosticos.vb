Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmDiagnosticos
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _DDiagnostico As New SIM___GLOBAL.Controles.DDiagnostico

    Private Sub Guardar()
        Try
            Dim _dDiagnosticos As New DDiagnostico
            Dim _Diagnostico As New Diagnosticos
            _Diagnostico.Id = txtCodigo.Text
            _Diagnostico.Nombre = txtNombre.Text
            If chkEstado.Checked = True Then
                _Diagnostico.Estado = "A"
            Else
                _Diagnostico.Estado = "I"
            End If
            _dDiagnosticos.Guardar(_Diagnostico)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            txtCodigo.Enabled = False
            txtCodigo.Text = _ClickGrilla
            txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
            If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
            bbiGuardar.Enabled = False
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DDiagnostico.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        'Me.DTDiagnosticosTableAdapter.Fill(Me.DTDiagnosticos._DTDiagnosticos)
    End Sub
    Private Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DTDiagnosticos._DTDiagnosticos' Puede moverla o quitarla según sea necesario.
        'Me.DTDiagnosticosTableAdapter.Fill(Me.DTDiagnosticos._DTDiagnosticos)
        ActualizarGrilla()
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el diagnostico", "Registro de Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarCampos()
        End If

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Codigo Es Obligatorio", "Registro de Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCodigo.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub


    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        EditarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        Dim _DDiagnosticos As New DDiagnostico
        If _DDiagnosticos.Existe(txtCodigo.Text) = True Then
            MessageBox.Show("El Codigo ya ha sido registrado", "Registro de DIAGNOSTICOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Text = ""
        End If
    End Sub

    Private Sub GCConsultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
﻿Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmProcedimientosTerapeuticos
    Dim _ds As DataSet
    Dim _DProcedimientosTerapeuticos As New DProcedimientosTerapeuticos
    Dim _ProcedimientosTerapeuticos As New ProcedimientosTerapeuticos
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                txtID.Enabled = False
                txtNombre.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "PROCEDIMIENTO").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado el procedimiento", "Registro de Procedimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Guardar()
        Try
            _ProcedimientosTerapeuticos.Id = Val(txtID.Text)
            _ProcedimientosTerapeuticos.Nombre = txtNombre.Text
            If chkEstado.Checked = True Then
                _ProcedimientosTerapeuticos.Estado = "A"
            Else
                _ProcedimientosTerapeuticos.Estado = "I"
            End If
            _DProcedimientosTerapeuticos.Guardar(_ProcedimientosTerapeuticos)
            bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = True
        txtNombre.Enabled = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DProcedimientosTerapeuticos.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmProcedimientosTerapeuticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
        chkEstado.Checked = True
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

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        EditarCampos()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
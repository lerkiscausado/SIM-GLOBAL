Public Class frmEventos
    Dim _DEventos As New AGORA.Controles.DEventos
    Dim _Eventos As New AGORA.Modelo.Eventos
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DEventos.Listar()
        gcConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        lblID.Text = Nothing
        txtEvento.Text = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        Try
            _Eventos.Id = Val(lblID.Text)
            _Eventos.Nombre = txtEvento.Text
            If chkEstado.Checked = True Then
                _Eventos.Estado = "A"
            Else
                _Eventos.Estado = "I"
            End If
            _DEventos.Guardar(_Eventos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        lblID.Text = Nothing
    End Sub
    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el registro", "Registro de Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If MessageBox.Show("Desea Editar el Registro?", "Registro de Eventos",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Eventos = _DEventos.Cargar(_ClickGrilla)
                lblID.Text = _ClickGrilla
                txtEvento.Text = _Eventos.Nombre
                If _Eventos.Estado = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub txtEvento_EditValueChanged(sender As Object, e As EventArgs) Handles txtEvento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtEvento.Text = "" Then
            MessageBox.Show("El Campo Evento es obligatorio", "Registro de eventos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub
End Class
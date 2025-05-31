Public Class frmArbitros
    Dim _ds As DataSet
    Dim _DArbitros As New ADOSPLAY.Controles.DArbitros
    Dim _Arbitros As New ADOSPLAY.My.Modelo.Arbitros
    Dim _ClickGrilla As String
    Dim _Fila As Integer

    Private Sub Guardar()
        Try
            _Arbitros.Id = Val(txtID.Text)
            _Arbitros.Nombre = txtNombre.Text
            _Arbitros.Escuela = txtEscuela.Text
            _Arbitros.Descripcion = txtDescripcion.Text
            If chkEstado.Checked = True Then
                _Arbitros.Estado = "A"
            Else
                _Arbitros.Estado = "I"
            End If
            _DArbitros.Guardar(_Arbitros)
            bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtEscuela.Text = ""
        txtDescripcion.Text = ""
        chkEstado.Checked = False
        'txtNombre.Enabled = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                txtID.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
                txtEscuela.Text = GVConsultar.GetRowCellValue(_Fila, "ESCUELA").ToString()
                txtDescripcion.Text = GVConsultar.GetRowCellValue(_Fila, "DESCRIPCION").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado el Arbitro", "Registro de Arbitros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos el listado de Arbitros
        _ds = New DataSet()
        _ds = _DArbitros.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmArbitros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTArbitros' Puede moverla o quitarla según sea necesario.
        'Me.DTArbitrosTableAdapter.Fill(Me.DSVistas.DTArbitros)

        'llenamos el listado de Arbitros
        _ds = New DataSet()
        _ds = _DArbitros.listar()
        GCConsultar.DataSource = _ds.Tables(0)
        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        EditarCampos()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Arbitros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtEscuela.Text = "" Then
            MessageBox.Show("El Campo Escuela es Obligatorio", "Registro de Arbitros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GVConsultar.DoubleClick
        EditarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtEscuela_EditValueChanged(sender As Object, e As EventArgs) Handles txtEscuela.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub
End Class
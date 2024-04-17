Imports ADOSPLAY.My.Modelo
Imports ADOSPLAY.My.Controles
Public Class frmEquipos
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dDeportes As New DDeportes
    Dim _Equipos As New Equipos
    Dim _DEquipos As New DEquipos
    Private Sub ActivarGuardar()
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub Guardar()
        Try

            _Equipos.Id = Val(txtID.Text)
            _Equipos.Nombre = txtNombre.Text
            _Equipos.Descripcion = txtDescripcion.Text
            _Equipos.Logo = txtLogo.Text
            _Equipos.IDDeporte = cboDeporte.GetColumnValue("ID").ToString
            _Equipos.Delegado = txtDelegado.Text
            If chkEstado.Checked = True Then
                _Equipos.Estado = "A"
            Else
                _Equipos.Estado = "I"
            End If
            _DEquipos.Guardar(_Equipos)
            bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtLogo.Text = ""
        txtDelegado.Text = ""

        chkEstado.Checked = False
        txtNombre.Enabled = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                txtID.Enabled = False
                txtNombre.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado el cargo", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DEquipos.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos combo deporte
        _ds = New DataSet
        _ds = _dDeportes.Listar
        cboDeporte.Properties.DataSource = _ds.Tables(0)
        cboDeporte.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDeporte.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        ActualizarGrilla()

    End Sub


End Class
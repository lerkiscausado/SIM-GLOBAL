Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmPlantillaPatologia
    Dim _dPlantilla As New DPlantillasPatologia
    Dim _Plantilla As New PlantillasPatologia
    Dim _DEspecimen As New DEspecimenes
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As String
    Public Macro As String
    Public Micro As String
    Public Diagnostico As String
    Dim MacroLocal As String
    Dim MicroLocal As String
    Dim DiagnosticoLocal As String

#Region "PROCEDIMIENTOS"
    Private Sub Guardar()
        Try
            _Plantilla.Id = Val(lcID.Text)
            _Plantilla.Nombre = txtNombre.Text
            _Plantilla.Diagnostico = rtbPlantilla.HtmlText
            If chkEstado.Checked = True Then
                _Plantilla.Estado = "A"
            Else
                _Plantilla.Estado = "I"
            End If
            _dPlantilla.Guardar(_Plantilla)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        lcID.Text = ""
        txtNombre.Text = ""
        txtNombre.Enabled = True
        rtbPlantilla.Text = ""
        rtbPlantilla.ReadOnly = False
        chkEstado.Enabled = True
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dPlantilla.Listar
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro?", "Editar Registros ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                'txtID.Enabled = False
                'txtNombre.Enabled = False
                lcID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
                rtbPlantilla.HtmlText = GVConsultar.GetRowCellValue(_Fila, "DIAGNOSTICO").ToString()

                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                txtNombre.Enabled = True
                chkEstado.Enabled = True
                rtbPlantilla.ReadOnly = False
                bbiGuardar.Enabled = False

            End If
        Else
            MessageBox.Show("No ha seleccionado la plantilla a editar", "Registro de Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
    Private Sub frmPlantillaPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
    End Sub

    Private Sub bbiEspecimen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecimen.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecimenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre Es Obligatorio", "Registro de Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf rtbplantilla.Text = "" Then
            MessageBox.Show("El Campo Descripcion Plantilla es Obligatorio", "Registro de Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()

            rtbPlantilla.ReadOnly = True
            txtNombre.Enabled = False
            chkEstado.Enabled = False
            bbiGuardar.Enabled = False
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



    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("La plantilla Actual se encuentra en edicion, Desea descartar los cambios?", "Plantilla", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
            End If
        Else
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If bbiGuardar.Enabled = True Then
            MessageBox.Show("No es posible editar la plantilla, la plantilla actual se encuentra en modo de edicion", "Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarCampos()
        End If

    End Sub

    Private Sub bbiAplicarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAplicarPlantilla.ItemClick
        'If _ClickGrilla <> Nothing Then
        ' If MessageBox.Show("¿Desea Aplicar la Plantilla Seleccionada?", "Plantilla", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
        ' 'Macro = MacroLocal
        ' 'Micro = MicroLocal
        ' Diagnostico = rtbPlantilla.HtmlText
        ' Me.Close()
        ' End If
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Plantilla", "Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub


    Private Sub bbiEditarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditarPlantilla.ItemClick
        If rtbPlantilla.ReadOnly = False Then
            Dim _frmOpen As New SIM___GLOBAL.frmRtbPatologia
            _frmOpen.Text = "DESCRIPCION PLANTILLA ESTUDIO PATOLOGICO"
            _frmOpen.rtbDescripcion.HtmlText = rtbPlantilla.HtmlText
            _frmOpen.ShowDialog()
            rtbPlantilla.HtmlText = _frmOpen.rtbDescripcion.HtmlText
        Else
            MessageBox.Show("La plantilla no se encuentra en modo de edicion", "Plantillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub rtbPlantilla_TextChanged(sender As Object, e As EventArgs) Handles rtbPlantilla.TextChanged
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            'MacroLocal = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "MACROSCOPIA").ToString()
            'MicroLocal = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "MICROSCOPIA").ToString()
            DiagnosticoLocal = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "DIAGNOSTICO").ToString()

            If bbiGuardar.Enabled <> True Then
                'Visualizamos la plantilla
                rtbPlantilla.HtmlText = DiagnosticoLocal
            End If


            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class

Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Utilidades



Public Class frmCitologia
#Region "Declaracion de Variables"
    Dim _ds As DataSet
    Dim _dordenes As New DOrdenes
    Dim _Ordenes As New Ordenes
    Dim _DTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio
    Dim _TipoEstudio As New SIM___GLOBAL.Modelo.TipoEstudio
    Dim _citologia As New SIM_CITOPATO.My.Modelo.Citologia
    Dim _Dcitologia As New SIM_CITOPATO.Controles.DCitologia


    Dim _ClickGrilla As String
    Dim _Fila As Integer
#End Region
#Region "PROCEDIMIENTOS"
    Private Sub ActivaGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        Dim _ds As DataSet
        _ds = _dordenes.ListarCitologias
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub

    Private Function CambiarValor(ByVal filtro As String) As String
        Select Case filtro
            Case "X"
                Return 1
            Case ""
                Return 0
            Case 1
                Return "X"
            Case 0
                Return Nothing
        End Select


    End Function
    Private Sub LimpiarCampos()
        'limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'txtNumeroHistoria.Text = ""
        txtDatosUsuario.Text = ""
        txtConsecutivo.Text = ""
        chkFirmarEstudio.Checked = False


        'llenamos GRID CONTROL PACIENTES POR ATENDER
        ActualizarGrilla()

        'limpiamos Campos Citologia
        txtCitologiaBaseLiquida.Text = ""
        chkCM1.Checked = False
        chkCM2.Checked = False
        chkCM3.Checked = False
        chkCM4.Checked = False
        txtCM5.Text = ""
        chkCG1.Checked = False
        chkCG2.Checked = False
        chkM1.Checked = False
        chkM2.Checked = False
        chkM3.Checked = False
        chkM4.Checked = False
        chkM5.Checked = False
        chkM6.Checked = False
        chkOHNN1.Checked = False
        chkOHNN2.Checked = False
        chkOHNN3.Checked = False
        chkOHNN4.Checked = False
        chkOHNN5.Checked = False
        chkOHNN6.Checked = False
        chkACE1.Checked = False
        chkACE2.Checked = False
        chkACE3.Checked = False
        chkACE4.Checked = False
        chkACE5.Checked = False
        chkACG1.Checked = False
        chkACG2.Checked = False
        chkACG3.Checked = False
        chkACG4.Checked = False
        chkACG5.Checked = False
        'chkACG6.Checked = False
        'chkACG7.Checked = False
        chkACG8.Checked = False
        chkFB1.Checked = False
        chkFB2.Checked = False
        chkFB3.Checked = False
        chkI1.Checked = False
        chkI2.Checked = False
        chkI3.Checked = False
        txtObservaciones.Text = ""
        bbiGuardar.Enabled = False
    End Sub
    Private Sub NuevaEstudio()
        lblConsecutivoOrden.Text = _ClickGrilla
        txtDatosUsuario.Text = Funciones.DatosUsuario(_ClickGrilla, "HISTORIA")

        '********** Obtenemos el ID del usuario ******************
        _Ordenes = _dordenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        dtFecha.Text = _Ordenes.FechaIngreso
        '****** Traer Consecutivo Citologia ********
        _citologia = _Dcitologia.Cargar(_Ordenes.Id)

        '****** Traer CONSECUTIVO ESTUDIO **********
        '_TipoEstudio = _DTipoEstudio.Cargar(_Ordenes.IdTipoEstudio)
        txtConsecutivo.Text = GVPacientesAtender.GetRowCellValue(_Fila, "CONSECUTIVO").ToString() '_TipoEstudio.Prefijo & _citologia.Id

        '****** Activar Tipo de Estudio *************
        If GVPacientesAtender.GetRowCellValue(_Fila, "ESTUDIO").ToString() <> "CITOLOGIA" Then
            'If _TipoEstudio.Prefijo = "CB" Then
            ACBaseLiquida.Visible = True
            ACCalidadMuestra.Visible = False
            ACCategorizacionGeneral.Visible = False
            ACMicroorganismos.Visible = False
            ACOhnN.Visible = False
            ACACe.Visible = False
            ACAcg.Visible = False
            'ACFloraBasilar.Visible = False
            'ACInflamacion.Visible = False
            ACObservaciones.Visible = False


        Else
            ACBaseLiquida.Visible = False
            ACCalidadMuestra.Visible = True
            ACCategorizacionGeneral.Visible = True
            ACMicroorganismos.Visible = True
            ACOhnN.Visible = True
            ACACe.Visible = True
            ACAcg.Visible = True
            'ACFloraBasilar.Visible = True
            'ACInflamacion.Visible = True
            ACObservaciones.Visible = True

        End If
#Region "****Traer DAtos de Estudio ****"


        txtCitologiaBaseLiquida.Text = _citologia.Diagnostico
        chkCM1.Checked = CambiarValor(_citologia.CM1)
        chkCM2.Checked = CambiarValor(_citologia.CM2)
        chkCM3.Checked = CambiarValor(_citologia.CM3)
        chkCM4.Checked = CambiarValor(_citologia.CM4)
        txtCM5.Text = _citologia.CM5

        chkCG1.Checked = CambiarValor(_citologia.CG1)
        chkCG2.Checked = CambiarValor(_citologia.CG2)

        chkM1.Checked = CambiarValor(_citologia.M1)
        chkM2.Checked = CambiarValor(_citologia.M2)
        chkM3.Checked = CambiarValor(_citologia.M3)
        chkM4.Checked = CambiarValor(_citologia.M4)
        chkM5.Checked = CambiarValor(_citologia.M5)
        chkM6.Checked = CambiarValor(_citologia.M6)

        chkOHNN1.Checked = CambiarValor(_citologia.OHNN1)
        chkOHNN2.Checked = CambiarValor(_citologia.OHNN2)
        chkOHNN3.Checked = CambiarValor(_citologia.OHNN3)
        chkOHNN4.Checked = CambiarValor(_citologia.OHNN4)
        chkOHNN5.Checked = CambiarValor(_citologia.OHNN5)
        chkOHNN6.Checked = CambiarValor(_citologia.OHNN6)

        chkACE1.Checked = CambiarValor(_citologia.ACE1)
        chkACE2.Checked = CambiarValor(_citologia.ACE2)
        chkACE3.Checked = CambiarValor(_citologia.ACE3)
        chkACE4.Checked = CambiarValor(_citologia.ACE4)
        chkACE5.Checked = CambiarValor(_citologia.ACE5)

        chkACG1.Checked = CambiarValor(_citologia.ACG1)
        chkACG2.Checked = CambiarValor(_citologia.ACG2)
        chkACG3.Checked = CambiarValor(_citologia.ACG3)
        chkACG4.Checked = CambiarValor(_citologia.ACG4)
        chkACG5.Checked = CambiarValor(_citologia.ACG5)
        'chkACG6.Checked = CambiarValor(_citologia.ACG6)
        'chkACG7.Checked = CambiarValor(_citologia.ACG7)
        chkACG8.Checked = CambiarValor(_citologia.ACG8)

        chkFB1.Checked = CambiarValor(_citologia.FB1)
        chkFB2.Checked = CambiarValor(_citologia.FB2)
        chkFB3.Checked = CambiarValor(_citologia.FB3)

        chkI1.Checked = CambiarValor(_citologia.I1)
        chkI2.Checked = CambiarValor(_citologia.I2)
        chkI3.Checked = CambiarValor(_citologia.I3)
        txtObservaciones.Text = _citologia.Observaciones
#End Region
        '****** Traer Historias Anteriores **********
        _ds = New DataSet()
        _ds = _dordenes.ListarEstudiosAnteriores(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)


        bbiGuardar.Enabled = False

    End Sub
    Private Sub GuardarEstudio()
        _citologia.Id = Val(txtConsecutivo.Text)
        _citologia.IdOrden = lblConsecutivoOrden.Text
        _citologia.Fecha = dtFecha.Text
        '**** campos de CItologia ***
        _citologia.CM1 = CambiarValor(chkCM1.CheckState)
        _citologia.CM2 = CambiarValor(chkCM2.CheckState)
        _citologia.CM3 = CambiarValor(chkCM3.CheckState)
        _citologia.CM4 = CambiarValor(chkCM4.CheckState)
        _citologia.CM5 = txtCM5.Text

        _citologia.CG1 = CambiarValor(chkCG1.CheckState)
        _citologia.CG2 = CambiarValor(chkCG2.CheckState)

        _citologia.M1 = CambiarValor(chkM1.CheckState)
        _citologia.M2 = CambiarValor(chkM2.CheckState)
        _citologia.M3 = CambiarValor(chkM3.CheckState)
        _citologia.M4 = CambiarValor(chkM4.CheckState)
        _citologia.M5 = CambiarValor(chkM5.CheckState)
        _citologia.M6 = CambiarValor(chkM6.CheckState)

        _citologia.OHNN1 = CambiarValor(chkOHNN1.CheckState)
        _citologia.OHNN2 = CambiarValor(chkOHNN2.CheckState)
        _citologia.OHNN3 = CambiarValor(chkOHNN3.CheckState)
        _citologia.OHNN4 = CambiarValor(chkOHNN4.CheckState)
        _citologia.OHNN5 = CambiarValor(chkOHNN5.CheckState)
        _citologia.OHNN6 = CambiarValor(chkOHNN6.CheckState)

        _citologia.ACE1 = CambiarValor(chkACE1.CheckState)
        _citologia.ACE2 = CambiarValor(chkACE2.CheckState)
        _citologia.ACE3 = CambiarValor(chkACE3.CheckState)
        _citologia.ACE4 = CambiarValor(chkACE4.CheckState)
        _citologia.ACE5 = CambiarValor(chkACE5.CheckState)

        _citologia.ACG1 = CambiarValor(chkACG1.CheckState)
        _citologia.ACG2 = CambiarValor(chkACG2.CheckState)
        _citologia.ACG3 = CambiarValor(chkACG3.CheckState)
        _citologia.ACG4 = CambiarValor(chkACG4.CheckState)
        _citologia.ACG5 = CambiarValor(chkACG5.CheckState)
        '_citologia.ACG6 = CambiarValor(chkACG6.CheckState)
        '_citologia.ACG7 = CambiarValor(chkACG7.CheckState)
        _citologia.ACG8 = CambiarValor(chkACG8.CheckState)

        _citologia.FB1 = CambiarValor(chkFB1.CheckState)
        _citologia.FB2 = CambiarValor(chkFB2.CheckState)
        _citologia.FB3 = CambiarValor(chkFB3.CheckState)

        _citologia.I1 = CambiarValor(chkI1.CheckState)
        _citologia.I2 = CambiarValor(chkI2.CheckState)
        _citologia.I3 = CambiarValor(chkI3.CheckState)

        _citologia.Observaciones = txtObservaciones.Text
        _citologia.Diagnostico = txtCitologiaBaseLiquida.Text
        _citologia.Img1 = ""
        _citologia.Img2 = ""
        _citologia.IdEmpleado = IdEmpleadoG
        '****************************
        _Dcitologia.Guardar(_citologia)
        bbiGuardar.Enabled = False

    End Sub
#End Region

    Private Sub frmCitologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()

        'CAMPOS INACTIVOS CITOLOGIA KELLY
        'ACFloraBasilar.Expanded = False
        'ACInflamacion.Expanded = False
        'ACFloraBasilar.Enabled = False
        'ACInflamacion.Enabled = False
        'chkCM3.Enabled = False


    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub


    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Estudio", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene un Estudio pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nuevo Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                NuevaEstudio()

            End If
        Else
            LimpiarCampos()
            NuevaEstudio()

        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Guardar Estudio", "Registro de Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf txtconsecutivo.Text = "" Then
            '    MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '  e 'lseIf xtpAntecedentes.PageVisible = True And txtAntecedentesFamiliares.Text = "" Then
            '   MessageBox.Show("Campo Antecedentes Familiares es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf xtpAntecedentes.PageVisible = True And txtAntecedentesPersonales.Text = "" Then
            '    MessageBox.Show("Campo Antecedentes Personales es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'MsgBox(chkCM1.CheckState)
            GuardarEstudio()
            If chkFirmarEstudio.Checked = True Then
                If MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _dordenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    LimpiarCampos()

                    '  NuevaHistoria()
                End If
            End If
        End If
    End Sub
#Region "Activa Guardar"


    Private Sub txtCitologiaBaseLiquida_EditValueChanged(sender As Object, e As EventArgs) Handles txtCitologiaBaseLiquida.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCM1_EditValueChanged(sender As Object, e As EventArgs) Handles chkCM1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCM2_EditValueChanged(sender As Object, e As EventArgs) Handles chkCM2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCM3_EditValueChanged(sender As Object, e As EventArgs) Handles chkCM3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCG1_EditValueChanged(sender As Object, e As EventArgs) Handles chkCG1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCG2_EditValueChanged(sender As Object, e As EventArgs) Handles chkCG2.EditValueChanged
        ActivaGuardar()
    End Sub



    Private Sub chkOHNN1_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkOHNN2_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkOHNN3_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkOHNN4_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkOHNN5_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN5.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkOHNN6_EditValueChanged(sender As Object, e As EventArgs) Handles chkOHNN6.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACE1_EditValueChanged(sender As Object, e As EventArgs) Handles chkACE1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACE2_EditValueChanged(sender As Object, e As EventArgs) Handles chkACE2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACE3_EditValueChanged(sender As Object, e As EventArgs) Handles chkACE3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACE4_EditValueChanged(sender As Object, e As EventArgs) Handles chkACE4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG1_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG2_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG3_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG4_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG5_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG5.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkACG6_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub chkACG7_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub chkACG8_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG8.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFirmarEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles chkFirmarEstudio.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM1_EditValueChanged(sender As Object, e As EventArgs) Handles chkM1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM2_EditValueChanged(sender As Object, e As EventArgs) Handles chkM2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM3_EditValueChanged(sender As Object, e As EventArgs) Handles chkM3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM4_EditValueChanged(sender As Object, e As EventArgs) Handles chkM4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM5_EditValueChanged(sender As Object, e As EventArgs) Handles chkM5.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkM6_EditValueChanged(sender As Object, e As EventArgs) Handles chkM6.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB1_EditValueChanged(sender As Object, e As EventArgs) Handles chkFB1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB2_EditValueChanged(sender As Object, e As EventArgs) Handles chkFB2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB3_EditValueChanged(sender As Object, e As EventArgs) Handles chkFB3.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkI1_EditValueChanged(sender As Object, e As EventArgs) Handles chkI1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkI2_EditValueChanged(sender As Object, e As EventArgs) Handles chkI2.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkI3_EditValueChanged(sender As Object, e As EventArgs) Handles chkI3.EditValueChanged
        ActivaGuardar()
    End Sub



    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCM4_EditValueChanged(sender As Object, e As EventArgs) Handles chkCM4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtCM5_EditValueChanged(sender As Object, e As EventArgs) Handles txtCM5.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCM1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCM1.CheckedChanged

    End Sub





#End Region
End Class
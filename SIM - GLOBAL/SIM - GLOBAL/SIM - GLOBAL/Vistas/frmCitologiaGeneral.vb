Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmCitologiaGeneral
#Region "Declaracion de Variables"
    ReadOnly _funciones As New Funciones
    Dim _ds As DataSet
    Dim _dordenes As New DOrdenes
    Dim _Ordenes As New Ordenes
    Dim _DTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio
    Dim _TipoEstudio As New SIM___GLOBAL.Modelo.TipoEstudio
    Dim _citologia As New SIM___GLOBAL.Modelo.Citologia
    Dim _Dcitologia As New SIM___GLOBAL.Controles.DCitologia
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _DEspecialista As New SIM___GLOBAL.Controles.DEspecialista
    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
    Dim _EstudiosGenerados As New SIM___GLOBAL.Modelo.EstudiosGenerados
    Dim _DEstudiosGenerados As New SIM___GLOBAL.Controles.DEstudiosGenerados
    Dim _ClickGrilla As String
    Dim _ClickEstudio As String
    Dim _Fila As Integer
    Dim _IDUsuario As String
    Public IDEmpleado As String
    Public Licencia As String

#End Region
#Region "PROCEDIMIENTOS"
    Private Sub GuardarEstudioGenerado()
        _EstudiosGenerados.IdOrden = Val(lblConsecutivoOrden.Text)
        _EstudiosGenerados.IdDetalleOrden = Val("")
        _EstudiosGenerados.Fecha = DateTime.Now
        _EstudiosGenerados.Hora = DateTime.Now
        _EstudiosGenerados.Estudio = _ClickEstudio
        _EstudiosGenerados.IdEmpleado = IDEmpleado
        _DEstudiosGenerados.Guardar(_EstudiosGenerados)
    End Sub
    Private Sub ActivaGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
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
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub LimpiarCampos()
        'limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'txtNumeroHistoria.Text = ""
        'txtDatosUsuario.Text = ""
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
        chkFloraBasilarEscasa.Checked = False
        chkFloraBasilarModerada.Checked = False
        chkFloraBasilarAumentada.Checked = False
        chkI1.Checked = False
        chkI2.Checked = False
        chkI3.Checked = False
        txtObservaciones.Text = ""
        bbiGuardar.Enabled = False
        'limpiar campos Antecedentes Gineco obstetricos
        txtGestacion.Text = Nothing
        txtPartos.Text = Nothing
        txtAbortos.Text = Nothing
        txtCesareas.Text = Nothing
        txtVidaSexual.Text = Nothing
        txtMetodoPlanificacion.Text = Nothing
        txtUltimaMestruacion.Text = Nothing
        txtUltimaCitologia.Text = Nothing
        txtUltimoParto.Text = Nothing
        chkSano.Checked = False
        chkUlcerado.Checked = False
        chkLacerado.Checked = False
        chkBlanco.Checked = False
        chkClaro.Checked = False
        chkAmarillo.Checked = False
        chkOlor.Checked = False
        txtObservaciones.Text = Nothing

    End Sub
    Private Sub NuevaEstudio()
        lblConsecutivoOrden.Text = _ClickGrilla
        '------------Traemoda datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

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
        Select Case GVPacientesAtender.GetRowCellValue(_Fila, "ESTUDIO").ToString()
            Case "CITOLOGIA BASE LIQUIDA"
                xtpBaseLiquida.PageVisible = True
                xtpCalidadMuestra.PageVisible = False
                xtpCategorizacionGeneral.PageVisible = False
                xtpMicroorganismos.PageVisible = False
                xtpOHNN.PageVisible = False
                xtpCelulasEscamosas.PageVisible = False
                xtpCelulasGlandulares.PageVisible = False
                'ACFloraBasilar.Visible = False
                'ACInflamacion.Visible = False
                xtpObservaciones.PageVisible = False
                'ocultamos los campos no necesarios
                chkM3.Enabled = True
                chkM5.Enabled = True
                chkOHNN3.Visible = True
                chkOHNN4.Visible = True
                chkOHNN5.Visible = True
                chkOHNN6.Visible = True
                chkACG1.Visible = True
                chkACG2.Visible = True
                chkACG3.Visible = True
                chkACG4.Visible = True
                LabelControl6.Visible = True
                LabelControl7.Visible = True
                chkACE3.Text = "Lesion Intraepitelial Escamosa de Bajo Grado LIE BG (Comprende InfeccIon por el VPH y NIC I)"
                chkACE4.Text = "Lesion Intraepitelial Escamosa de Alto Grado LIE AG (Comprende NIC II Y NIC III y Carcinoma in Situ"
                chkM4.Text = "Candididasis Vaginalis"
            Case "CITOLOGIA ANAL"
                xtpBaseLiquida.PageVisible = False
                xtpCalidadMuestra.PageVisible = True
                xtpCategorizacionGeneral.PageVisible = True
                xtpMicroorganismos.PageVisible = True
                xtpOHNN.PageVisible = True
                xtpCelulasEscamosas.PageVisible = True
                xtpCelulasGlandulares.PageVisible = True
                'ACFloraBasilar.Visible = False
                'ACInflamacion.Visible = False
                xtpObservaciones.PageVisible = True
                xtpAntecedentes.PageVisible = False
                xtpInflamacion.PageVisible = False
                xtpFloraBacilar.PageVisible = False
                'ocultamos los campos no necesarios
                chkM3.Enabled = False
                chkM5.Enabled = False
                chkOHNN3.Visible = False
                chkOHNN4.Visible = False
                chkOHNN5.Visible = False
                chkOHNN6.Visible = False
                chkACG1.Visible = False
                chkACG2.Visible = False
                chkACG3.Visible = False
                chkACG4.Visible = False
                LabelControl6.Visible = False
                LabelControl7.Visible = False
                'cambiamos nombres a campos
                chkACE3.Text = "Lesion Intraepitelial Escamosa de Bajo Grado LIE BG"
                chkACE4.Text = "Lesion Intraepitelial Escamosa de Alto Grado LIE AG"
                chkM4.Text = "Candididasis"

            Case Else
                xtpBaseLiquida.PageVisible = False
                xtpCalidadMuestra.PageVisible = True
                xtpCategorizacionGeneral.PageVisible = True
                xtpMicroorganismos.PageVisible = True
                xtpOHNN.PageVisible = True
                xtpCelulasEscamosas.PageVisible = True
                xtpCelulasGlandulares.PageVisible = True
                'ACFloraBasilar.Visible = True
                'ACInflamacion.Visible = True
                xtpObservaciones.PageVisible = True
                'ocultamos los campos no necesarios
                chkM3.Enabled = True
                chkM5.Enabled = True
                chkOHNN3.Visible = True
                chkOHNN4.Visible = True
                chkOHNN5.Visible = True
                chkOHNN6.Visible = True
                chkACG1.Visible = True
                chkACG2.Visible = True
                chkACG3.Visible = True
                chkACG4.Visible = True
                LabelControl6.Visible = True
                LabelControl7.Visible = True
                chkACE3.Text = "Lesion Intraepitelial Escamosa de Bajo Grado LIE BG (Comprende InfeccIon por el VPH y NIC I)"
                chkACE4.Text = "Lesion Intraepitelial Escamosa de Alto Grado LIE AG (Comprende NIC II Y NIC III y Carcinoma in Situ"
                chkM4.Text = "Candididasis Vaginalis"
        End Select

        'If _TipoEstudio.Prefijo = "CB" Then




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

        chkFloraBasilarEscasa.Checked = CambiarValor(_citologia.FB1)
        chkFloraBasilarModerada.Checked = CambiarValor(_citologia.FB2)
        chkFloraBasilarAumentada.Checked = CambiarValor(_citologia.FB3)

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
    Private Sub Antecedentes()

        Dim _TomaMuestra As New SIM___GLOBAL.Modelo.TomaMuestra
        Dim _DTomaMuestra = New SIM___GLOBAL.Controles.DTomaMuestra

        If _DTomaMuestra.Existe(_IDUsuario) = True Then
            _TomaMuestra = _DTomaMuestra.Cargar(_IDUsuario)
            'cargamos Toma de Muestra
            txtGestacion.Text = _TomaMuestra.G
            txtPartos.Text = _TomaMuestra.P
            txtAbortos.Text = _TomaMuestra.A
            txtCesareas.Text = _TomaMuestra.C
            txtVidaSexual.Text = _TomaMuestra.IVSA
            txtMetodoPlanificacion.Text = _TomaMuestra.MPF
            txtUltimaMestruacion.Text = _TomaMuestra.FUM
            txtUltimaCitologia.Text = _TomaMuestra.FUC
            txtUltimoParto.Text = _TomaMuestra.FUP
            chkSano.CheckState = _TomaMuestra.S
            chkUlcerado.CheckState = _TomaMuestra.U
            chkLacerado.CheckState = _TomaMuestra.L
            chkBlanco.CheckState = _TomaMuestra.BN
            chkClaro.CheckState = _TomaMuestra.CN
            chkAmarillo.CheckState = _TomaMuestra.BA
            chkOlor.CheckState = _TomaMuestra.O
            txtObservacionesAntecedentes.Text = _TomaMuestra.Observaciones
        End If
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

        _citologia.FB1 = CambiarValor(chkFloraBasilarEscasa.CheckState)
        _citologia.FB2 = CambiarValor(chkFloraBasilarModerada.CheckState)
        _citologia.FB3 = CambiarValor(chkFloraBasilarAumentada.CheckState)

        _citologia.I1 = CambiarValor(chkI1.CheckState)
        _citologia.I2 = CambiarValor(chkI2.CheckState)
        _citologia.I3 = CambiarValor(chkI3.CheckState)

        _citologia.Observaciones = txtObservaciones.Text
        _citologia.Diagnostico = txtCitologiaBaseLiquida.Text
        _citologia.Img1 = ""
        _citologia.Img2 = ""
        _citologia.IdEmpleado = IDEmpleado
        '****************************
        _Dcitologia.Guardar(_citologia)
        bbiGuardar.Enabled = False

    End Sub
#End Region
    Private Sub frmCitologiaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
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
                Antecedentes()
            End If
        Else
            LimpiarCampos()
            NuevaEstudio()
            Antecedentes()
        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
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

    Private Sub chkCM4_EditValueChanged(sender As Object, e As EventArgs) Handles chkCM4.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtCM5_EditValueChanged(sender As Object, e As EventArgs) Handles txtCM5.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCG1_EditValueChanged(sender As Object, e As EventArgs) Handles chkCG1.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCG2_EditValueChanged(sender As Object, e As EventArgs) Handles chkCG2.EditValueChanged
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

    Private Sub chkACE5_EditValueChanged(sender As Object, e As EventArgs) Handles chkACE5.EditValueChanged
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

    Private Sub chkACG8_EditValueChanged(sender As Object, e As EventArgs) Handles chkACG8.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB1_EditValueChanged(sender As Object, e As EventArgs) Handles chkFloraBasilarEscasa.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB2_EditValueChanged(sender As Object, e As EventArgs) Handles chkFloraBasilarModerada.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFB3_EditValueChanged(sender As Object, e As EventArgs) Handles chkFloraBasilarAumentada.EditValueChanged
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

    Private Sub txtCitologiaBaseLiquida_EditValueChanged(sender As Object, e As EventArgs) Handles txtCitologiaBaseLiquida.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If TVDatosUsuarios.RowCount = 0 Then
            MessageBox.Show("No ha Seleccionado Paciente para Realizar Estudio", "Estudio de Citologia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'MsgBox(chkCM1.CheckState)
            GuardarEstudio()
            If chkFirmarEstudio.Checked = True Then
                If _DEspecialista.Existe(IDEmpleado) = False Then
                    MessageBox.Show("Para firmar el estudio debe ingresar al sistema el especialista", "Estudio de Citologia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf MessageBox.Show("Desea Firmar y cerrar el Estudio?, Si continua No se podran hacer cambios ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _dordenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    _DDetalleOrden.ActualizarEstadoOrden(lblConsecutivoOrden.Text, "ATENDIDO")

                    Try
                        _funciones.GenerarPDF(Val(lblConsecutivoOrden.Text), _ClickEstudio, 1, Licencia, "\\servidor-pc\pdf\" & lblConsecutivoOrden.Text & ".pdf")
                        GuardarEstudioGenerado()
                        MessageBox.Show("Se genero estudio en PDF para descarga en la plataforma", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex)
                    End Try

                    LimpiarCampos()
                End If
            End If
        End If
    End Sub

    Private Sub chkFirmarEstudio_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirmarEstudio.CheckedChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub
End Class
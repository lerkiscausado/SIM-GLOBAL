Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Public Class frmOrtodoncia
#Region "DECLARACION DE VARIABLES"
    Dim _ClickGrilla As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdentificacion As String
    Dim _ClickIdTipoEstudiosAnteriores As String
    Dim _Fila As Integer
    Dim _IDUsuario As String
    Public _IDEmpleado As String
    Public Licencia As String
    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
    Dim _Imagenes As Byte
#End Region
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DDiagnosticos As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _DOrtodoncia = New SIM___GLOBAL.Controles.DOrtodoncia
    Dim _Ortodoncia As New SIM___GLOBAL.Modelo.Ortodoncias
    Dim _ds As DataSet
#Region "PROCEDIMIENTOS"
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
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub CargarImagenes(ByVal Filtro As String)
        Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenesGlobal 'SIM_ENDOSCOPIA.Controles.DImagenes

        _Capturas.Items.Clear()
        gcSeleccionadas.Gallery.Groups.Clear()
        _ds = New DataSet
        _ds = _dImagenes.ListarImagenesActivasIC(Filtro)
        If _ds.Tables(0).Rows.Count <> 0 Then
            _Imagenes = 1
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
            Next
            gcSeleccionadas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcSeleccionadas.Gallery.ImageSize = New Size(120, 90)
            gcSeleccionadas.Gallery.Groups.Add(_Capturas)
        Else
            _Imagenes = 0
        End If
    End Sub
    Private Sub GuardarHistoria()
        '_HistoriaClinica.Id = Val(lblConsecutivo.Text)
        'Asignamos el Numero de la Historia
        'txtConsecutivo.Text = Funciones.CodigoUsuario(lblConsecutivoOrden.Text) & Mid(dtFecha.Text, 7, 4) & Mid(dtFecha.Text, 4, 2) & Mid(dtFecha.Text, 1, 2)

        _Ortodoncia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Ortodoncia.IdDetalleOrden = Val(lblIdDetalleOrden.Text)
        _Ortodoncia.Fecha = dtFecha.Text
        _Ortodoncia.Hora = DateTime.Now
        _Ortodoncia.MotivoConsulta = txtMotivoConsulta.Text
        _Ortodoncia.Responsables = txtResponsables.Text
        _Ortodoncia.AntecedentesPatologicos = txtAntecedentes.Text
        _Ortodoncia.Perfil = cboPerfil.Text
        _Ortodoncia.Frente = cboFrente.Text
        _Ortodoncia.Hipotonia = cboHipotonia.Text
        _Ortodoncia.Hipertonia = cboHipertonia.Text
        _Ortodoncia.Macroquelia = cboMacroquelia.Text
        _Ortodoncia.Microquelia = cboMicroquelia.Text
        _Ortodoncia.Proquelia = cboProquelia.Text
        _Ortodoncia.Retroquelia = cboRetroquelia.Text
        _Ortodoncia.FrenilloLabiarSuperior = cboFrenilloLabialSuperior.Text
        _Ortodoncia.FrenilloLabialInferior = cboFrenilloLabialInferior.Text
        _Ortodoncia.FrenilloLingual = cboFrenilloLingual.Text
        _Ortodoncia.RespiracionBucal = CambiarValor(chkRespiracionBucal.CheckState)
        _Ortodoncia.UsoChupo = CambiarValor(chkUsoChupo.CheckState)
        _Ortodoncia.Bruxomania = CambiarValor(chkBruxomania.CheckState)
        _Ortodoncia.Succiondigital = CambiarValor(chkSuccionDigital.CheckState)
        _Ortodoncia.Succionlabial = CambiarValor(chkSuccionLabial.CheckState)
        _Ortodoncia.DeglucionInfantil = CambiarValor(chkDeglucionInfantil.CheckState)
        _Ortodoncia.Onicofagia = CambiarValor(chkOnicofagia.CheckState)
        _Ortodoncia.EmpujeLingual = CambiarValor(chkEmpujeLingual.CheckState)
        _Ortodoncia.MorderObjeto = CambiarValor(chkMorderObjetos.CheckState)
        _Ortodoncia.EvaluacionHabito = txtEvaluacionHabito.Text
        _Ortodoncia.Fonacion = txtfonacion.Text
        _Ortodoncia.InterpretacionCefalometrica = txtInterpretacionCefalometrica.Text
        _Ortodoncia.Diagnostico = txtDiagnostico.Text
        _Ortodoncia.Pronostico = txtPronostico.Text
        _Ortodoncia.PlanTratamiento = txtPlanTratamiento.Text
        _Ortodoncia.Aparatologia = txtAparatologia.Text
        _Ortodoncia.Presupuesto = txtPresupuesto.Text
        _Ortodoncia.ActividadRealizada = txtActividadRealizada.Text
        _Ortodoncia.ProximaCita = txtProximaCita.Text
        _Ortodoncia.CodigoDiagnostico = cboDiagnosticos.EditValue
        _Ortodoncia.IdEmpleado = _IDEmpleado
        _Dortodoncia.Guardar(_Ortodoncia)

        '***************** Actualizamos el estado de la Orden a Atendido *****************
        '_dOrdenes.ActualizarEstado(Val(lblConsecutivoOrden.Text), "ATENDIDO")
    End Sub
    Private Sub NuevaHistoria()

        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        txtConsecutivo.Text = _ClickIdentificacion
        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)


        '****** Traer Historias Anteriores **********
        _ds = New DataSet()
        _ds = _dOrdenes.ListarHistoriasAnterioresOrtodoncia(_IDUsuario)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)

        ' comprobamos si tiene historias anteriores
        If gvEstudiosAnteriores.RowCount = 0 Then

            'Historia Primera Vez
            xtpControl.PageVisible = False
            xtpMotivoConsulta.PageVisible = True
            xtpAntecedentesPatologicos.PageVisible = True
            xtpFacialesBucales.PageVisible = True
            xtpFrenillos.PageVisible = True
            xtpHabitos.PageVisible = True
            xtpFonacion.PageVisible = True
            xtpDiagnostico.PageVisible = True
            xtpPronostico.PageVisible = True
            xtpPlan.PageVisible = True
            xtpAparatologia.PageVisible = True
            xtpPresupuesto.PageVisible = True
        Else

            xtpControl.PageVisible = True
            xtpMotivoConsulta.PageVisible = False
            xtpAntecedentesPatologicos.PageVisible = False
            xtpFacialesBucales.PageVisible = False
            xtpFrenillos.PageVisible = False
            xtpHabitos.PageVisible = False
            xtpFonacion.PageVisible = False
            xtpDiagnostico.PageVisible = False
            xtpPronostico.PageVisible = False
            xtpPlan.PageVisible = False
            xtpAparatologia.PageVisible = False
            xtpPresupuesto.PageVisible = False

        End If

        '---------- Bloqueamos la historia del paciente -------------------
        '_DDetalleOrden.ProcesoDetalleOrden(lblIdDetalleOrden.Text)


        'Select Case _ClickTipoEstudio
        ' Case "CONSULTA PRIMERA VEZ"
        ' xtpMotivoConsulta.PageVisible = True
        ' xtpConsultaControl.PageVisible = False
        ' xtpAntecedentes.PageVisible = True
        ' xtpMotivoConsulta.Show()
        '
        '        Case Else
        '        xtpMotivoConsulta.PageVisible = False
        '        xtpConsultaControl.PageVisible = True
        '        xtpAntecedentes.PageVisible = False
        '        xtpConsultaControl.Show()
        '        End Select
        '
        '
        '        '****** Traer Historias Anteriores **********
        '        _ds = New DataSet()
        '        _ds = _dOrdenes.ListarEstudiosAnterioresEndoscopias(lblConsecutivo.Text)
        '        GCHistoriasAnteriores.DataSource = _ds.Tables(0)
        '        '***************************************'_ds = New DataSet()
        '
        '************** Traemos Antecedentes del Paciente *****************

        'If _ds.Tables(0).Rows.Count <> 0 Then
        ' xtpAntecedentes.PageVisible = False
        '  Dim _dsAntecedentes As New DataSet
        '  Dim _dsAntecedentesOrden As New DataSet
        '  Dim _DAntecedentes As New DAntecedentes
        '
        '        If _DAntecedentes.ExisteUsuarioAntecedente(lblConsecutivo.Text) = True Then
        '        _dsAntecedentes = _DAntecedentes.ListarAntecedentes(lblConsecutivo.Text)
        '        txtAntecedentesFamiliares2.Text = _dsAntecedentes.Tables(0).Rows(0)(0).ToString
        '        txtAntecedentesPersonales2.Text = _dsAntecedentes.Tables(0).Rows(0)(1).ToString
        '        End If
        '
        '        If _DAntecedentes.Existe(lblConsecutivoOrden.Text) = True Then
        '        _dsAntecedentesOrden = _DAntecedentes.CargarAntecedentes(lblConsecutivoOrden.Text)
        '        txtAntecedentesFamiliares.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(0).ToString
        '        txtAntecedentesPersonales.Text = _dsAntecedentesOrden.Tables(0).Rows(0)(1).ToString
        '        End If
        '
        If _DOrtodoncia.Existe(lblConsecutivoOrden.Text) = True Then

            ' traemos historias anteriores sin firmar para edicion
            _Ortodoncia = _DOrtodoncia.cargar(lblConsecutivoOrden.Text)

            txtMotivoConsulta.Text = _Ortodoncia.MotivoConsulta
            txtResponsables.Text = _Ortodoncia.Responsables
            txtAntecedentes.Text = _Ortodoncia.AntecedentesPatologicos
            cboPerfil.Text = _Ortodoncia.Perfil
            cboFrente.Text = _Ortodoncia.Frente
            cboHipotonia.Text = _Ortodoncia.Hipotonia
            cboHipertonia.Text = _Ortodoncia.Hipertonia
            cboMacroquelia.Text = _Ortodoncia.Macroquelia
            cboMicroquelia.Text = _Ortodoncia.Microquelia
            cboProquelia.Text = _Ortodoncia.Proquelia
            cboRetroquelia.Text = _Ortodoncia.Retroquelia
            cboFrenilloLabialSuperior.Text = _Ortodoncia.FrenilloLabiarSuperior
            cboFrenilloLabialInferior.Text = _Ortodoncia.FrenilloLabialInferior
            cboFrenilloLingual.Text = _Ortodoncia.FrenilloLingual
            chkRespiracionBucal.Checked = CambiarValor(_Ortodoncia.RespiracionBucal)
            chkUsoChupo.Checked = CambiarValor(_Ortodoncia.UsoChupo)
            chkBruxomania.Checked = CambiarValor(_Ortodoncia.Bruxomania)
            chkSuccionDigital.Checked = CambiarValor(_Ortodoncia.Succiondigital)
            chkSuccionLabial.Checked = CambiarValor(_Ortodoncia.Succionlabial)
            chkDeglucionInfantil.Checked = CambiarValor(_Ortodoncia.DeglucionInfantil)
            chkOnicofagia.Checked = CambiarValor(_Ortodoncia.Onicofagia)
            chkEmpujeLingual.Checked = CambiarValor(_Ortodoncia.EmpujeLingual)
            chkMorderObjetos.Checked = CambiarValor(_Ortodoncia.MorderObjeto)
            txtEvaluacionHabito.Text = _Ortodoncia.EvaluacionHabito
            txtfonacion.Text = _Ortodoncia.Fonacion
            txtInterpretacionCefalometrica.Text = _Ortodoncia.InterpretacionCefalometrica
            txtDiagnostico.Text = _Ortodoncia.Diagnostico
            cboDiagnosticos.EditValue = _Ortodoncia.CodigoDiagnostico
            txtPronostico.Text = _Ortodoncia.Pronostico
            txtPlanTratamiento.Text = _Ortodoncia.PlanTratamiento
            txtAparatologia.Text = _Ortodoncia.Aparatologia
            txtPresupuesto.Text = _Ortodoncia.Presupuesto
            txtActividadRealizada.Text = _Ortodoncia.ActividadRealizada
            txtProximaCita.Text = _Ortodoncia.ProximaCita

        End If
        'desactivamos el boton GUARDAR
        bbiGuardar.Enabled = False
    End Sub
    Private Sub LimpiarCampos()
        'Limpiamos campos
        lblConsecutivo.Text = ""
        txtConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        GCDatosUsuarios.DataSource = Nothing
        chkProcesado.Checked = False

        'CAmpos Resporte de Ortodoncia
        txtMotivoConsulta.Text = ""
        txtResponsables.Text = ""
        txtAntecedentes.Text = ""
        txtEvaluacionHabito.Text = ""
        txtfonacion.Text = ""
        txtInterpretacionCefalometrica.Text = ""
        txtDiagnostico.Text = ""
        txtPronostico.Text = ""
        txtPlanTratamiento.Text = ""
        txtAparatologia.Text = ""
        txtPresupuesto.Text = ""
        txtActividadRealizada.Text = ""
        txtProximaCita.Text = ""
        txtDiagnostico.Text = ""

        chkRespiracionBucal.Checked = False
        chkUsoChupo.Checked = False
        chkBruxomania.Checked = False
        chkSuccionDigital.Checked = False
        chkSuccionLabial.Checked = False
        chkDeglucionInfantil.Checked = False
        chkOnicofagia.Checked = False
        chkEmpujeLingual.Checked = False
        chkMorderObjetos.Checked = False

        GCEstudiosAnteriores.DataSource = Nothing



    End Sub
#End Region
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesOrtodoncia
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub

    Private Sub frmOrtodoncia_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ActualizarGrilla()
        'Llenamos Fecha Actual
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'Listamos los Diagnosticos
        _ds = _DDiagnosticos.ListarCombo
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        ' INFORMACION DEL PACIENTE POR ATENDER
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Historia", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nueva Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una historia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nueva Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'LimpiarCampos()
                NuevaHistoria()
                CargarImagenes(lblIdDetalleOrden.Text)
            End If
        Else
            'LimpiarCampos()
            NuevaHistoria()
            CargarImagenes(lblIdDetalleOrden.Text)

        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            '_ClickTipoEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _ClickIdentificacion = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
#Region "ACTIVA GUARDAR"


    Private Sub txtMotivoConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtResponsables_EditValueChanged(sender As Object, e As EventArgs) Handles txtResponsables.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAntecedentes_EditValueChanged(sender As Object, e As EventArgs) Handles txtAntecedentes.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboPerfil_EditValueChanged(sender As Object, e As EventArgs) Handles cboPerfil.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboFrente_EditValueChanged(sender As Object, e As EventArgs) Handles cboFrente.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboHipotonia_EditValueChanged(sender As Object, e As EventArgs) Handles cboHipotonia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboHipertonia_EditValueChanged(sender As Object, e As EventArgs) Handles cboHipertonia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboMacroquelia_EditValueChanged(sender As Object, e As EventArgs) Handles cboMacroquelia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboMicroquelia_EditValueChanged(sender As Object, e As EventArgs) Handles cboMicroquelia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboProquelia_EditValueChanged(sender As Object, e As EventArgs) Handles cboProquelia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboRetroquelia_EditValueChanged(sender As Object, e As EventArgs) Handles cboRetroquelia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboFrenilloLabialSuperior_EditValueChanged(sender As Object, e As EventArgs) Handles cboFrenilloLabialSuperior.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboFrenilloLabialInferior_EditValueChanged(sender As Object, e As EventArgs) Handles cboFrenilloLabialInferior.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboFrenilloLingual_EditValueChanged(sender As Object, e As EventArgs) Handles cboFrenilloLingual.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkRespiracionBucal_EditValueChanged(sender As Object, e As EventArgs) Handles chkRespiracionBucal.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkUsoChupo_EditValueChanged(sender As Object, e As EventArgs) Handles chkUsoChupo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkBruxomania_EditValueChanged(sender As Object, e As EventArgs) Handles chkBruxomania.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkSuccionDigital_EditValueChanged(sender As Object, e As EventArgs) Handles chkSuccionDigital.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkSuccionLabial_EditValueChanged(sender As Object, e As EventArgs) Handles chkSuccionLabial.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkDeglucionInfantil_EditValueChanged(sender As Object, e As EventArgs) Handles chkDeglucionInfantil.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkOnicofagia_EditValueChanged(sender As Object, e As EventArgs) Handles chkOnicofagia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEmpujeLingual_EditValueChanged(sender As Object, e As EventArgs) Handles chkEmpujeLingual.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkMorderObjetos_EditValueChanged(sender As Object, e As EventArgs) Handles chkMorderObjetos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtEvaluacionHabito_EditValueChanged(sender As Object, e As EventArgs) Handles txtEvaluacionHabito.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtfonacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtfonacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtInterpretacionCefalometrica_EditValueChanged(sender As Object, e As EventArgs) Handles txtInterpretacionCefalometrica.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPronostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtPronostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPlanTratamiento_EditValueChanged(sender As Object, e As EventArgs) Handles txtPlanTratamiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAparatologia_EditValueChanged(sender As Object, e As EventArgs) Handles txtAparatologia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPresupuesto_EditValueChanged(sender As Object, e As EventArgs) Handles txtPresupuesto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtActividadRealizada_EditValueChanged(sender As Object, e As EventArgs) Handles txtActividadRealizada.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtProximaCita_EditValueChanged(sender As Object, e As EventArgs) Handles txtProximaCita.EditValueChanged
        ActivarGuardar()
    End Sub
#End Region
    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If chkProcesado.Checked = True Then
            If TVDatosUsuarios.RowCount = 0 Then
                MessageBox.Show("No ha Seleccionado Paciente para Guardar Historia", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtMotivoConsulta.Text = "" And xtpMotivoConsulta.pageVisible = True Then
                MessageBox.Show("Campo Motivo de Consulta es Obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboDiagnosticos.Text = "" And xtpDiagnostico.pageVisible = True Then
                MessageBox.Show("Diagnostico CIE10 es obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtactividadrealizada.Text = "" And xtpcontrol.pageVisible = True Then
                MessageBox.Show("El Campo Actividad realizada es obligatorio", "Registro de Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Firmar la Historia?, Si continua no se podran hacer cambios en la historia. ¿Desea Continuar?", "Firmar Historia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    GuardarHistoria()

                    'Actualizar estado de detalle orden
                    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
                    _DDetalleOrden.ActualizarDiagnosticoyEstado(lblIdDetalleOrden.Text, cboDiagnosticos.EditValue)
                    If _DDetalleOrden.DetalleOrdenPendiente(lblConsecutivoOrden.Text) = False Then
                        _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                    End If

                    'If MessageBox.Show("Desea imprimir la historia", "Imprimir Historia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ' ImprimirHistoria()
                    ' End If
                    LimpiarCampos()
                Else
                    GuardarHistoria()
                End If

                '****** Traer Historias Anteriores **********
                '_ds = New DataSet()
                '_ds = _dOrdenes.ListarHistoriasAnterioresOrtodoncia(lblConsecutivo.Text)
                'GCEstudiosAnteriores.DataSource = _ds.Tables(0)
                '***************************************

                ActualizarGrilla()
                bbiGuardar.Enabled = False
            End If
        Else
            GuardarHistoria()
            ActualizarGrilla()

            '*********************** Guardar Antecedentes ****************************
            'If xtpAntecedentes.PageVisible = True Then
            ' GuardarAntecedentes()
            ' End If

            bbiGuardar.Enabled = False
        End If
    End Sub

    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged
        ActivarGuardar()
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

    Private Sub btnCargarImagenes_Click(sender As Object, e As EventArgs) Handles btnCargarImagenes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmImagenesCapturadas 'SIM_ENDOSCOPIA.frmImagenesCapturadas

        _frmOpen._idDetalleOrden = lblIdDetalleOrden.Text
        _frmOpen.ShowDialog()
        CargarImagenes(lblIdDetalleOrden.Text)
    End Sub

    Private Sub gcSeleccionadas_Gallery_ItemDoubleClick(sender As Object, e As GalleryItemClickEventArgs) Handles gcSeleccionadas.Gallery.ItemDoubleClick
        Dim _frmOpen As New SIM___GLOBAL.frmTextoImagenes 'SIM_ENDOSCOPIA.frmTextoImagenes
        _frmOpen.txtTexoImagenes.Text = e.Item.Description
        _frmOpen.IdImagen = e.Item.Caption
        _frmOpen.ShowDialog()
        CargarImagenes(lblIdDetalleOrden.Text)
    End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs) Handles btVistaEstudios.Click
        If _ClickIdTipoEstudiosAnteriores <> "" Then
            Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
            _frmOpen.IdDetalleOrden = _ClickIdTipoEstudiosAnteriores 'Registro
            _frmOpen.Licencia = Licencia
            _frmOpen.Estudio = "ORTODONCIA"
            _frmOpen.ShowDialog()

            _ClickIdTipoEstudiosAnteriores = ""
        Else
            MessageBox.Show("Debe Seleccionar un Estudio o Historia", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gvEstudiosAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvEstudiosAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdTipoEstudiosAnteriores = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            'Estudio = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
            ' MsgBox(_ClickIdTipoEstudiosAnteriores)
        End If
    End Sub
End Class
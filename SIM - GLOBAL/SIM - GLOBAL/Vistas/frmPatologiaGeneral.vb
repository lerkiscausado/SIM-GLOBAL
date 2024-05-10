Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.Modelo
Imports DevExpress.XtraSpellChecker
Imports System
Imports System.Globalization
Public Class frmPatologiaGeneral

#Region "Declaracion de Variables"
    ReadOnly _funciones As New Funciones
    Dim _ds As DataSet
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _DDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
    Dim _dUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _TipoEstudio As New SIM___GLOBAL.Modelo.TipoEstudio
    Dim _DTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio
    Dim _Patologia As New SIM___GLOBAL.Modelo.Patologia
    Dim _DPatologia As New SIM___GLOBAL.Controles.DPatologia
    Dim _DDiagnostico As New SIM___GLOBAL.Controles.DDiagnostico
    Dim _DEspecialista As New SIM___GLOBAL.Controles.DEspecialista
    Dim _EstudiosGenerados As New SIM___GLOBAL.Modelo.EstudiosGenerados
    Dim _DEstudiosGenerados As New SIM___GLOBAL.Controles.DEstudiosGenerados
    Dim _DEspecimenes As New SIM___GLOBAL.Controles.DEspecimenes
    Dim _IdUsuario As Integer
    Dim _ClickGrilla As String
    Dim _ClickIdEstudiosAnteriores As String
    Dim _ClickIdentificacion As String
    Dim _ClickEspecimen As String
    Dim _ClickEstudio As String
    Dim _Fila As Integer
    Dim Estudio As String
    Public IDEmpleado As String
    Public Licencia As String
    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
    Dim _Imagenes As Byte
#End Region
#Region "PROCEDIMIENTOS"
    Private Sub CargarImagenes(ByVal Filtro As String)
        Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenes 'SIM_ENDOSCOPIA.Controles.DImagenes
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
    Private Sub LimpiarCampos()
        'limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'txtDatosUsuario.Text = ""
        txtConsecutivo.Text = Nothing
        gcSeleccionadas.Text = Nothing
        txtSolicitado.Text = Nothing
        txtTipoMuestra.Text = Nothing
        txtSitioLesion.Text = Nothing
        txtMacro.Text = Nothing
        txtMicro.Text = Nothing
        txtDiagnostico.Text = Nothing
        txtObservaciones.Text = Nothing
        chkProcesado.Checked = False
        ActualizarGrilla()
        GrillaEstudiosAnteriores()
        bbiGuardar.Enabled = False
    End Sub
    Private Sub NuevoEstudio()
        lblConsecutivoOrden.Text = _ClickGrilla
        '------------Traemoda datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        '******* Traemos la Orden ******************
        _ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _ordenes.IdUsuario
        txtConsecutivo.Text = _ordenes.Consecutivo

        'dtFecha.Text = _ordenes.FechaIngreso

        '************ Traemos el Tipo Estudio ****************
        _TipoEstudio = _DTipoEstudio.Cargar(_ordenes.IdTipoEstudio)

        '************ Traemos la Patologia *************
        _Patologia = _DPatologia.Cargar(_ClickGrilla)
        If _Patologia.DescripcionMacroscopica = "" Then
            dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        Else
            dtFecha.Text = _Patologia.Fecha
        End If

        'txtConsecutivo.Text = _TipoEstudio.Prefijo & _Patologia.Id

        txtTipoMuestra.Text = _ClickEspecimen '_Patologia.TipoMuestra
        txtSitioLesion.Text = _Patologia.SitioLesion
        'gcSeleccionadas.Text = _Patologia.Solicitado
        txtSolicitado.Text = _Patologia.Solicitado
        txtMacro.Text = _Patologia.DescripcionMacroscopica
        txtMicro.Text = _Patologia.DescripcionMicroscopica
        txtDiagnostico.Text = _Patologia.Diagnostico
        txtObservaciones.Text = _Patologia.Observaciones
        cboDiagnosticos.Text = _Patologia.CodigoDiagnostico
        cboDiagnostico.Text = _Patologia.CodigoPatologia

        cboEspecimen.ItemIndex = cboEspecimen.Properties.GetDataSourceRowIndex("ID", _ordenes.IdEspecimen)
        'Lllenar grilla estudios anteriores
        GrillaEstudiosAnteriores()

        bbiGuardar.Enabled = False
    End Sub
    Private Sub GrillaEstudiosAnteriores()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dOrdenes.ListarEstudiosAnteriores(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivaGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dOrdenes.ListarPatologias
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarEstudio()
        '_Patologia.Id = Val(txtConsecutivo.Text)
        _Patologia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Patologia.TipoMuestra = txtTipoMuestra.Text
        _Patologia.SitioLesion = txtSitioLesion.Text
        _Patologia.Solicitado = txtSolicitado.Text
        _Patologia.DescripcionMacroscopica = txtMacro.Text
        _Patologia.DescripcionMicroscopica = txtMicro.Text
        _Patologia.Diagnostico = txtDiagnostico.Text
        _Patologia.Observaciones = txtObservaciones.Text
        _Patologia.CodigoDiagnostico = cboDiagnosticos.EditValue
        _Patologia.IdEmpleado = IDEmpleado
        _Patologia.FechaSalida = DateTime.Now
        _Patologia.CodigoPatologia = cboDiagnostico.Text
        _DPatologia.Guardar(_Patologia)
        _dOrdenes.ActualizarEspecimen(lblConsecutivoOrden.Text, cboEspecimen.EditValue)
        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarEstudioGenerado()
        _EstudiosGenerados.IdOrden = Val(lblConsecutivoOrden.Text)
        _EstudiosGenerados.IdDetalleOrden = Val("")
        _EstudiosGenerados.Fecha = DateTime.Now
        _EstudiosGenerados.Hora = DateTime.Now
        _EstudiosGenerados.Estudio = _ClickEstudio
        _EstudiosGenerados.IdEmpleado = IDEmpleado
        _DEstudiosGenerados.Guardar(_EstudiosGenerados)
    End Sub
#End Region

    Private Sub frmPatologiaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' scOrtografia.Dictionaries.Clear()

        'Dim openOfficeDictionaryEnglish As New SpellCheckerOpenOfficeDictionary()
        'openOfficeDictionaryEnglish.DictionaryPath = "Dictionaries\OpenOffice\es_CO\es_CO.dic"
        'openOfficeDictionaryEnglish.GrammarPath = "Dictionaries\OpenOffice\es_CO\es_CO.aff"
        'openOfficeDictionaryEnglish.Culture = New CultureInfo("es-CO")
        'scOrtografia.Dictionaries.Add(openOfficeDictionaryEnglish)
        '
        '        Dim customDictionary As New SpellCheckerCustomDictionary()
        '        customDictionary.AlphabetPath = "Dictionaries\customEnglishAlphabet.txt"
        '        customDictionary.DictionaryPath = "Dictionaries\CustomEnglish.dic"
        '        customDictionary.Culture = CultureInfo.InvariantCulture
        '
        '        'Preload the dictionary to speed up the check
        '        customDictionary.Load()
        '        scOrtografia.Dictionaries.Add(customDictionary)
        '

        ActualizarGrilla()

        'llenamos campo Diagnostico
        _ds = New DataSet()
        _ds = _DDiagnostico.Listar()
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(0).Caption
        cboDiagnosticos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption


        'Cargar especimenes
        _ds = New DataSet()
        _ds = _DEspecimenes.Listar()
        cboEspecimen.Properties.DataSource = _ds.Tables(0)
        cboEspecimen.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEspecimen.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboEspecimen.ItemIndex = 0
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        ' INFORMACION DEL PACIENTE POR ATENDER
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado Paciente para Abrir Patologia", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickGrilla = lblConsecutivoOrden.Text Then
            MessageBox.Show("El paciente ya se encuentra seleccionado", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Patologia pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nuevo Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                LimpiarCampos()
                NuevoEstudio()
            End If
        Else
            LimpiarCampos()
            NuevoEstudio()
        End If
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _IdUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _ClickEspecimen = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESPECIMEN").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnCargarImagenes_Click(sender As Object, e As EventArgs) Handles btnCargarImagenes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmImagenesCapturadas 'SIM_ENDOSCOPIA.frmImagenesCapturadas
        '_frmOpen._idDetalleOrden = lblIdDetalleOrden.Text
        _frmOpen.ShowDialog()
        'CargarImagenes(lblIdDetalleOrden.Text)
    End Sub

    Private Sub txtSolicitado_EditValueChanged(sender As Object, e As EventArgs) Handles txtSolicitado.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtTipoMuestra_EditValueChanged(sender As Object, e As EventArgs) Handles txtTipoMuestra.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtSitioLesion_EditValueChanged(sender As Object, e As EventArgs) Handles txtSitioLesion.EditValueChanged
        ActivaGuardar()
    End Sub



    Private Sub cboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        GuardarEstudio()

        'Guardamos el registro del usuario que guardo o actualizo la patologia
        _funciones.GuardarRegistro("5", lblConsecutivoOrden.Text, IDEmpleado, "Actualizacion", txtConsecutivo.Text)
        If chkProcesado.Checked = True Then
            If txtTipoMuestra.Text = "" Then
                MessageBox.Show("El Tipo de Muestra es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf txtMacro.Text = "" Then
                MessageBox.Show("La descripcion macroscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf txtMicro.Text = "" Then
                MessageBox.Show("La descripcion microscopica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf txtDiagnostico.Text = "" Then
                MessageBox.Show("El diagnostico es obligatorio para poder firmar el estudio", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf _DEspecialista.Existe(IDEmpleado) = False Then
                MessageBox.Show("Para firmar el estudio debe ingresar al sistema el especialista", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                '_DDetalleOrden.ActualizarEstadoOrden(lblConsecutivoOrden.Text, "ATENDIDO")
                _DDetalleOrden.ActualizarDiagnosticoyEstado2(lblConsecutivoOrden.Text, cboDiagnosticos.EditValue)
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
    End Sub

    Private Sub chkProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles chkProcesado.CheckedChanged
        ActivaGuardar()
    End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs) Handles btVistaEstudios.Click
        Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
        _frmOpen.IdOrden = _ClickIdEstudiosAnteriores 'Id_Orden
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.Estudio = Estudio
        _frmOpen.ShowDialog()
    End Sub

    Private Sub gvEstudiosAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvEstudiosAnteriores.RowClick
        _ClickIdEstudiosAnteriores = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString
        Estudio = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO")
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub txtDiagnostico_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.TextChanged
        ActivaGuardar()
    End Sub

    Private Sub txtMacro_TextChanged(sender As Object, e As EventArgs) Handles txtMacro.TextChanged
        ActivaGuardar()
    End Sub

    Private Sub txtMicro_TextChanged(sender As Object, e As EventArgs) Handles txtMicro.TextChanged
        ActivaGuardar()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If txtConsecutivo.Text <> Nothing Then
            Dim _frmOpen As New SIM___GLOBAL.frmPlantillaPatologia
            _frmOpen.bbtNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            _frmOpen.bbiEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            _frmOpen.bbiGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            _frmOpen.bbiImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            _frmOpen.bbiEspecimen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            _frmOpen.bbiAplicarPlantilla.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '_frmOpen.xtDatosPlantilla.PageVisible = False
            _frmOpen.ShowDialog()
            'If Licencia = 16 Then ' CDPATOLOGIA
            'rtbMacro.Text = _frmOpen.Macro
            'rtbMicro.Text = _frmOpen.Micro
            'rtbDiagnostico.HtmlText = _frmOpen.rtbPlantilla.HtmlText
            'Else
            'txtMacro.Text = _frmOpen.Macro
            'txtMicro.Text = _frmOpen.Micro
            'txtDiagnostico.Text = _frmOpen.Diagnostico
            'End If

        Else
            MessageBox.Show("Debe Seleccionar un Estudio para aplicar la plantilla", "Plantilla", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles LabelControl3.Click

    End Sub
End Class
Imports DevExpress.XtraBars.Ribbon
Imports SIM___GLOBAL.Utilidades
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Net

Public Class frmPatologiaCD
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
    Dim _ClickUsuario As String
    Dim _Fila As Integer
    Dim Estudio As String
    Public IDEmpleado As String
    Public Licencia As String

    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
    Dim _Imagenes As Byte
#End Region
#Region "Procedimientos"
    Private Sub CargarResultadoAWS()
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("http://18.188.220.90:3000/api/storage"), HttpWebRequest)
            request.Method = "POST"

            Dim file_path As String = "C:\SIM\resultados\" + lblConsecutivoOrden.Text + ".pdf"

            Dim file_mime_type As String = "application/octet-stream"
            Dim file_name As String = Path.GetFileName(file_path)

            Dim file_stream As New FileStream(file_path, FileMode.Open, FileAccess.Read)
            Dim file_bytes As Byte() = New Byte(file_stream.Length - 1) {}
            file_stream.Read(file_bytes, 0, file_bytes.Length)
            file_stream.Close()

            Dim boundary As String = "---------------------------" & DateTime.Now.Ticks.ToString("x")
            request.ContentType = "multipart/form-data; boundary=" & boundary

            Dim requestStream As Stream = request.GetRequestStream()
            Dim writer As New StreamWriter(requestStream)

            writer.Write("--" & boundary & vbCrLf)
            writer.Write("Content-Disposition: form-data; name=""myfile""; filename=""" & file_name & """" & vbCrLf)
            writer.Write("Content-Type: " & file_mime_type & vbCrLf)
            writer.Write(vbCrLf)
            writer.Flush()

            requestStream.Write(file_bytes, 0, file_bytes.Length)

            writer.Write(vbCrLf)
            writer.Write("--" & boundary & "--" & vbCrLf)
            writer.Flush()

            writer.Close()

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            MsgBox("Resultado cargado satisfactoriamente")
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub
    Private Sub ResultadosAWS()
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        Select Case Licencia
            'Case 1 'ADOS SOFTWARE & DISEÑO
            'Case 2 'LABORATORIO DE INMUNOPATOLOGICO DE LA COSTA

            Case 16 'CD PATOLOGIA ONCOLOGICA SAS
                'IMPRESION CON DEVEXPRESS XTRA REPORT
                'definimos elreporte


                'Verificamos si es una Inmunohistoquimica
                If Estudio = "INMUNOHISTOQUIMICA" Then
                        'Lamamos Inmonothistoquimica
                        Dim _frmOpen As New SIM___GLOBAL.frmPDF
                        _frmOpen.Consecutivo = lblConsecutivoOrden.Text
                    _frmOpen.ShowDialog()
                Else
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        Dim reportPath As String = "c:\\SIM\resultados\" + lblConsecutivoOrden.Text + ".pdf"
                        Dim pdfOptions As PdfExportOptions = reporteRTB.ExportOptions.Pdf

                        pdfOptions.DocumentOptions.Application = "SIM - Sistema Integrado Medico"
                        pdfOptions.DocumentOptions.Author = "Ados Software"
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                        'pdfOptions.DocumentOptions.Subject = "Document Subject"
                        pdfOptions.DocumentOptions.Title = lblConsecutivoOrden.Text

                        'filtro.Name = "idOrden"
                        filtro.Value = lblConsecutivoOrden.Text
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = lblConsecutivoOrden.Text
                        reporteRTB.Parameters("idOrden").Value = lblConsecutivoOrden.Text
                        reporteRTB.ExportToPdf(reportPath, pdfOptions)

                        'Llamar funcion subir archivo AWS

                    End If




                'printTool.ShowRibbonPreview()
                'printTool.PrintDialog()


                'ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                'Case 17 'SERVICIOS AGORA
                'Case 18 '
        End Select
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _dOrdenes.ListarPatologias
        GCPacientesAtender.DataSource = _ds.Tables(0)
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
        txtEstudio.Text = _ClickEstudio
        dtFecha.Text = _ordenes.FechaIngreso
        xtDatosPersonales.Text = _ordenes.Consecutivo & " | " & _ClickUsuario & " | " & _ds.Tables(0).Rows(0)(4).ToString & " años"

        '------------visualisamos el estudio de Inmunohistoquimica ----------------
        If _ClickEstudio = "INMUNOHISTOQUIMICA" Then
            xtInmunohistoquimica.PageVisible = True
            If System.IO.File.Exists(path:="C:\SIM\OneDrive\Resultados\" & txtConsecutivo.Text & ".pdf") = True Then
                PdfAdjuntos.LoadDocument(path:="C:\SIM\OneDrive\Resultados\" & txtConsecutivo.Text & ".pdf")
            End If
        Else
            xtInmunohistoquimica.PageVisible = False
        End If
        'dtFecha.Text = _ordenes.FechaIngreso

        '************ Traemos el Tipo Estudio ****************
        _TipoEstudio = _DTipoEstudio.Cargar(_ordenes.IdTipoEstudio)

        '************ Traemos la Patologia *************
        _Patologia = _DPatologia.Cargar(_ClickGrilla)
        'If _Patologia.DescripcionMacroscopica = "" Then
        dtFechaSalida.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'Else
        'dtFechaSalida.Text = _Patologia.FechaSalida
        'End If

        'txtConsecutivo.Text = _TipoEstudio.Prefijo & _Patologia.Id

        'txtTipoMuestra.Text = _ClickEspecimen '_Patologia.TipoMuestra
        txtSitioLesion.Text = _Patologia.SitioLesion
        'gcSeleccionadas.Text = _Patologia.Solicitado
        txtSolicitado.Text = _Patologia.Solicitado
        If Licencia = 16 Then 'CD PATOLOGIA
            txtImpresionDiagnostica.Text = _Patologia.DescripcionMacroscopica
            cboResultadoDiagnostico.Text = _Patologia.DescripcionMicroscopica
            rtbDiagnostico.HtmlText = _Patologia.Diagnostico
        Else
            'txtMacro.Text = _Patologia.DescripcionMacroscopica
            'txtMicro.Text = _Patologia.DescripcionMicroscopica
            'txtDiagnostico.Text = _Patologia.Diagnostico
        End If

        txtObservaciones.Text = _Patologia.Observaciones
        cboDiagnosticos.Text = _Patologia.CodigoDiagnostico
        cboEspecimen.ItemIndex = cboEspecimen.Properties.GetDataSourceRowIndex("ID", _ordenes.IdEspecimen)

        'Lllenar grilla estudios anteriores
        GrillaEstudiosAnteriores()

        bbiGuardar.Enabled = False
    End Sub
    Private Sub GrillaEstudiosAnteriores()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _DPatologia.ListarEstudiosAnteriores(lblConsecutivo.Text)
        GCEstudiosAnteriores.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivaGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub LimpiarCampos()
        'limpiamos campos
        GCDatosUsuarios.DataSource = Nothing
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        dtFechaSalida.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'txtDatosUsuario.Text = ""
        xtDatosPersonales.Text = "Datos Estudio"
        txtConsecutivo.Text = Nothing
        gcSeleccionadas.Text = Nothing
        txtSolicitado.Text = Nothing
        'txtTipoMuestra.Text = Nothing
        txtSitioLesion.Text = Nothing
        'CD PATOLOGIA-----------
        rtbMacro.Text = Nothing
        rtbMicro.Text = Nothing
        rtbDiagnostico.Text = Nothing
        txtImpresionDiagnostica.Text = Nothing
        '-----------------------
        'txtMacro.Text = Nothing
        'txtMicro.Text = Nothing
        'txtDiagnostico.Text = Nothing
        txtObservaciones.Text = Nothing
        chkProcesado.Checked = False
        If txtEstudio.Text = "INMUNOHISTOQUIMICA" Then
            PdfAdjuntos.CloseDocument()
        End If
        xtInmunohistoquimica.PageVisible = False
        ActualizarGrilla()
        GrillaEstudiosAnteriores()
        bbiGuardar.Enabled = False
    End Sub
    Private Sub GuardarEstudio()
        '_Patologia.Id = Val(txtConsecutivo.Text)
        _Patologia.IdOrden = Val(lblConsecutivoOrden.Text)
        _Patologia.TipoMuestra = cboEspecimen.Text
        _Patologia.SitioLesion = txtSitioLesion.Text
        _Patologia.Solicitado = txtSolicitado.Text
        _Patologia.FechaSalida = dtFechaSalida.Text
        If Licencia = 16 Then 'CD PATOLOGIA
            _Patologia.DescripcionMacroscopica = txtImpresionDiagnostica.Text.Trim 'rtbMacro.HtmlText
            _Patologia.DescripcionMicroscopica = cboResultadoDiagnostico.Text.Trim 'rtbMicro.HtmlText
            _Patologia.Diagnostico = rtbDiagnostico.HtmlText.Trim

        Else
            '_Patologia.DescripcionMacroscopica = txtMacro.Text
            '_Patologia.DescripcionMicroscopica = txtMicro.Text
            '_Patologia.Diagnostico = txtDiagnostico.Text
        End If
        _Patologia.Observaciones = txtObservaciones.Text.Trim
        _Patologia.CodigoDiagnostico = cboDiagnosticos.EditValue
        _Patologia.IdEmpleado = IDEmpleado
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
    Private Sub GuardarInmuno()
        If PdfAdjuntos.IsDocumentOpened = True Then

            PdfAdjuntos.SaveDocument(path:="C:\SIM\OneDrive\Resultados\" & txtConsecutivo.Text & ".pdf")
        End If
    End Sub
#End Region
    Private Sub frmPatologiaCD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        'verificamos la licencia
        'rtbMacro.Document.DefaultCharacterProperties.FontName = "Calibri"
        'rtbMicro.Document.DefaultCharacterProperties.FontName = "Calibri"
        rtbDiagnostico.Document.DefaultCharacterProperties.FontName = "Calibri"
        If Licencia = 16 Then ' PATOLOGIA CD
            rtbMacro.Visible = False
            rtbMicro.Visible = False
            rtbDiagnostico.Visible = True
            'txtMacro.Visible = False
            'txtMicro.Visible = False
            'txtDiagnostico.Visible = False
        End If

        'llenamos campo Diagnostico
        _ds = New DataSet()
        _ds = _DDiagnostico.Listar()
        cboDiagnosticos.Properties.DataSource = _ds.Tables(0)
        cboDiagnosticos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
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
        ElseIf bbiGuardar.Enabled = True And rtbdiagnostico.Text <> "" Then
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
            _ClickUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "USUARIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub gvEstudiosAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvEstudiosAnteriores.RowClick
        _ClickIdEstudiosAnteriores = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString
        Estudio = gvEstudiosAnteriores.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO")
    End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs) Handles btVistaEstudios.Click
        If _ClickIdEstudiosAnteriores <> "" Then
            Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
            _frmOpen.IdOrden = _ClickIdEstudiosAnteriores 'Id_Orden
            '_frmOpen.Licencia = LicenciaG
            _frmOpen.Estudio = Estudio
            _frmOpen.ShowDialog()
        Else
            MessageBox.Show("No ha Seleccionado Estudio", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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

    Private Sub txtObservaciones_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservaciones.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtMicro_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtMacro_EditValueChanged(sender As Object, e As EventArgs)
        ActivaGuardar()
    End Sub

    Private Sub txtSitioLesion_EditValueChanged(sender As Object, e As EventArgs) Handles txtSitioLesion.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub txtSolicitado_EditValueChanged(sender As Object, e As EventArgs) Handles txtSolicitado.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub cboDiagnosticos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnosticos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkProcesado_EditValueChanged(sender As Object, e As EventArgs) Handles chkProcesado.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        GuardarEstudio()
        If txtEstudio.Text = "INMUNOHISTOQUIMICA" Then
            GuardarInmuno()
        End If
        'Guardamos el registro del usuario que guardo o actualizo la patologia
        _funciones.GuardarRegistro("5", lblConsecutivoOrden.Text, IDEmpleado, "Actualizacion", txtConsecutivo.Text)
        If chkProcesado.Checked = True Then
            If cboEspecimen.Text = "" Then
                MessageBox.Show("El Tipo de Muestra es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf txtImpresionDiagnostica.Text = "" Then
                MessageBox.Show("La descripcion Impresion Diagnostica es obligatoria para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf cboResultadoDiagnostico.Text = "" Then
                MessageBox.Show("El Resultado del Estudio es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf rtbDiagnostico.Text = "" Then
                MessageBox.Show("La descripcion del Estudio es obligatorio para poder firmar el estudio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkProcesado.Checked = False
            ElseIf cboDiagnosticos.Text = "" Then
                MessageBox.Show("El Diagnostico CIE10 es Obligatorio", "Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DEspecialista.Existe(IDEmpleado) = False Then
                MessageBox.Show("Para firmar el estudio debe ingresar al sistema el especialista", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf MessageBox.Show("Desea Firmar el Estudio?, Si continua No se podran hacer cambios en el Estudio ¿Desea Continuar?", "Firmar Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                _dOrdenes.ActualizarEstado(lblConsecutivoOrden.Text, "ATENDIDO")
                '_DDetalleOrden.ActualizarEstadoOrden(lblConsecutivoOrden.Text, "ATENDIDO")
                _DDetalleOrden.ActualizarDiagnosticoyEstado2(lblConsecutivoOrden.Text, cboDiagnosticos.EditValue)

                'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                _DImpresionPatologia.Eliminar(lblConsecutivoOrden.Text)
                _DImpresionPatologia.Guardar(lblConsecutivoOrden.Text)
                '------------------------------------------------------------
                'If MessageBox.Show("Desea Enviar el Resultado para descargar en plataforma?", "Descargar Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                '    ' Generar Estudio PDF para la pagina
                ' Try
                ' ResultadosAWS()
                ' CargarResultadoAWS()
                ' Catch ex As Exception
                ' MsgBox(ex)
                ' End Try



                'End If


                'Try
                ' _funciones.GenerarPDF(Val(lblConsecutivoOrden.Text), _ClickEstudio, 1, Licencia, "\\servidor-pc\pdf\" & lblConsecutivoOrden.Text & ".pdf")
                ' GuardarEstudioGenerado()
                ' MessageBox.Show("Se genero estudio en PDF para descarga en la plataforma", "Nuevo Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Catch ex As Exception
                ' MsgBox(ex)
                ' End Try
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub bbiOrtografia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrtografia.ItemClick
        Try
            'llamar el Spell Cheker
            ' scOrtografia.Check(Me.ActiveControl)
        Catch ex As Exception
            MsgBox("Esta Accion requiere Instalar un paquete de Microsoft Office")
        End Try
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

    Private Sub rtbMacro_RtfTextChanged(sender As Object, e As EventArgs) Handles rtbMacro.RtfTextChanged
        ActivaGuardar()
    End Sub

    Private Sub rtbMicro_RtfTextChanged(sender As Object, e As EventArgs) Handles rtbMicro.RtfTextChanged
        ActivaGuardar()
    End Sub

    Private Sub rtbDiagnostico_RtfTextChanged(sender As Object, e As EventArgs) Handles rtbDiagnostico.RtfTextChanged
        ActivaGuardar()
    End Sub

    Private Sub btnMacroRTB_Click(sender As Object, e As EventArgs) Handles btnMacroRTB.Click
        Dim _frmOpen As New SIM___GLOBAL.frmRtbPatologia
        '_frmOpen.bbtNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '_frmOpen.bbiEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '_frmOpen.bbiGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '_frmOpen.bbiImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '_frmOpen.bbiEspecimen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '_frmOpen.bbiAplicarPlantilla.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '_frmOpen.xtDatosPlantilla.PageVisible = False
        _frmOpen.Text = "DESCRIPCION MACROSCOPICA"
        _frmOpen.rtbDescripcion.HtmlText = rtbMacro.HtmlText
        _frmOpen.ShowDialog()
        rtbMacro.HtmlText = _frmOpen.rtbDescripcion.HtmlText
    End Sub

    Private Sub btnMicroRTB_Click(sender As Object, e As EventArgs) Handles btnMicroRTB.Click
        Dim _frmOpen As New SIM___GLOBAL.frmRtbPatologia
        _frmOpen.Text = "DESCRIPCION MICROSCOPICA"
        _frmOpen.rtbDescripcion.HtmlText = rtbMicro.HtmlText
        _frmOpen.ShowDialog()
        rtbMicro.HtmlText = _frmOpen.rtbDescripcion.HtmlText
    End Sub

    Private Sub btnDiagnosticoRTB_Click(sender As Object, e As EventArgs) Handles btnDiagnosticoRTB.Click
        Dim _frmOpen As New SIM___GLOBAL.frmRtbPatologia
        _frmOpen.Text = "DESCRIPCION ESTUDIO PATOLOGICO"
        _frmOpen.rtbDescripcion.HtmlText = rtbDiagnostico.HtmlText
        _frmOpen.ShowDialog()
        rtbDiagnostico.HtmlText = _frmOpen.rtbDescripcion.HtmlText
    End Sub

    Private Sub bbiVistaPreliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaPreliminar.ItemClick
        If txtConsecutivo.Text = "" Then
            MessageBox.Show("Debe Seleccionar un paciente para Vista Previa", "Vista Preliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCDPreliminar
            Dim filtro As New Parameter()
            'filtro.Name = "idOrden"
            filtro.Value = lblConsecutivoOrden.Text
            filtro.Visible = False

            'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
            Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
            _DImpresionPatologia.Eliminar(lblConsecutivoOrden.Text)
            _DImpresionPatologia.Guardar(lblConsecutivoOrden.Text)
            '------------------------------------------------------------

            reporteRTB.Parameters.Add(filtro)
            reporteRTB.FilterString = "[ID] = ?idOrden"
            reporteRTB.RequestParameters = False
            reporteRTB.Parameters(0).Value = lblConsecutivoOrden.Text
            reporteRTB.Parameters("idOrden").Value = lblConsecutivoOrden.Text
            Dim printTool As New ReportPrintTool(reporteRTB)
            printTool.ShowPreviewDialog()
        End If
    End Sub

    Private Sub sbAdjuntarPDF_Click(sender As Object, e As EventArgs) Handles sbAdjuntarPDF.Click
        cdArchivosPDF.ShowDialog()
        'cdArchivosPDF.
        PdfAdjuntos.LoadDocument(cdArchivosPDF.FileName)
    End Sub

    Private Sub sbEliminarPDF_Click(sender As Object, e As EventArgs) Handles sbEliminarPDF.Click
        PdfAdjuntos.CloseDocument()
    End Sub
End Class
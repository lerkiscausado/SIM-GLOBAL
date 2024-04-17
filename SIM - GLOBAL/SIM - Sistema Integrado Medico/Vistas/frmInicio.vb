Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Controles
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraPrinting
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.IO

Public Class frmInicio
#Region "DECLARACION DE VARIABLES"
    Public ContadorFotos As Byte
    ReadOnly _funciones As New Funciones
    ' Dim _frmConsultar As New frmConsultar
    Public LicenciaG As String
    Public IdEmpleadoG As String
    Public NombreEmpleado As String


    '-----------------------
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    'Dim _user As New DUsers
    Dim cerrar As Boolean = True
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _dUsers As New SIM___GLOBAL.Controles.DUsers

    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria

    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia

    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DEntregaResultados As New SIM___GLOBAL.Controles.DEntregaResultados

    ' Clases Cierre Sesion
    Dim _frmConsultarCitopato As frmConsultarCitoPato
    Dim _frmConsultarCDPatologia As frmConsultarCDPatologia
    Dim _frmConsultarEndoscopia As frmConsultarEndoscopia
    Dim _frmAuditoriaOrdenes As SIM___GLOBAL.frmListadoOrdenes

    Dim _frmAgenda As SIM___GLOBAL.frmAgenda
    Dim _frmFacturacion As SIM___GLOBAL.frmFacturas
    Dim _frmHistoria As SIM_ENDOSCOPIA.frmHistoria
    Dim _frmHistoriaGL As SIM_ENDOSCOPIA.frmHistoriaGL
    Dim _frmEndoscopia As SIM_ENDOSCOPIA.frmEndoscopia
    Dim _frmEndoscopiaGl As SIM_ENDOSCOPIA.frmEndoscopiaGL
    Dim _frmEstudiosEspeciales As SIM_ENDOSCOPIA.frmEstudiosEspeciales
    Dim _frmOrtodoncia As SIM___GLOBAL.frmOrtodoncia
    Dim _frmCitologia As SIM___GLOBAL.frmCitologiaGeneral
    Dim _frmPatologia As SIM___GLOBAL.frmPatologiaGeneral
    Dim _frmImagenes As SIM___GLOBAL.frmImagenesVideo
#End Region
#Region "Procedimientos de Impresion"
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        Select Case LicenciaG
            'Case 1 'ADOS SOFTWARE & DISEÑO
            'Case 2 'LABORATORIO DE INMUNOPATOLOGICO DE LA COSTA
            Case 3 'DITEG SAS
                If Estudio = "CONSULTA PRIMERA VEZ" Or Estudio = "CONSULTA DE CONTROL" Then
                    ' Impresion de Historias
                    _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                    _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                    _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                ElseIf Estudio = "REGISTRO ANESTESIA" Then
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                Else
                    If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Reporte = 1
                    Else
                        Reporte = 0
                    End If
                    ' Impresion endoscopia endoscopias
                    _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    ImpresionEndoscopia(IDDetalleOrdenG)
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                End If
            Case 4 'GASTROLAP
                If Estudio = "CONSULTA PRIMERA VEZ" Or Estudio = "CONSULTA DE CONTROL" Then
                    ' Impresion de Historias
                    _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                    _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                    _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                ElseIf Estudio = "REGISTRO ANESTESIA" Then
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                Else
                    If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Reporte = 1
                    Else
                        Reporte = 0
                    End If
                    ' Impresion endoscopia endoscopias
                    _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    ImpresionEndoscopia(IDDetalleOrdenG)
                    ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                End If

            'Case 5 'INTEGRAIPS
            Case 6 'KELLY GOMEZ
            'Case 7 'FAUSTO VELEZ
            'Case 8 'PEDRO IMBETH
            'Case 9 'BEATRIZ LINCE VIDES
            'Case 10 'FANNY LINCE VIDES
            Case 11 'CITOPAT DE LA COSTA LTDA
                ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
            'Case 12 'AQUAMEDICAL
            'Case 13 'MATERIALES LA PUNTA
            'Case 17 'FERNANDO PONCE IGLESIAS
            'Case 15 'OPTICA FREISEM
            Case 16 'CD PATOLOGIA ONCOLOGICA SAS
                'IMPRESION CON DEVEXPRESS XTRA REPORT
                'definimos elreporte
                If VistaPrevia = False Then
                    Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCDPreliminar
                    Dim filtro As New Parameter()
                    'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                    Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                    _DImpresionPatologia.Guardar(IDOrdenG)
                    '------------------------------------------------------------
                    'filtro.Name = "idOrden"
                    filtro.Value = IDOrdenG
                    filtro.Visible = False
                    reporteRTB.Parameters.Add(filtro)
                    reporteRTB.FilterString = "[ID] = ?idOrden"
                    reporteRTB.RequestParameters = False
                    reporteRTB.Parameters(0).Value = IDOrdenG
                    reporteRTB.Parameters("idOrden").Value = IDOrdenG
                    Dim printTool As New ReportPrintTool(reporteRTB)
                    printTool.ShowPreviewDialog()
                    'printTool.show
                Else
                    'Verificamos si es una Inmunohistoquimica
                    If Estudio = "INMUNOHISTOQUIMICA" Then
                        'Lamamos Inmonothistoquimica
                        Dim _frmOpen As New SIM___GLOBAL.frmPDF
                        _frmOpen.Consecutivo = ConsecutivoG
                        _frmOpen.ShowDialog()
                    ElseIf Fotos = "0" Then
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                        Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                        _DImpresionPatologia.Guardar(IDOrdenG)
                        '------------------------------------------------------------
                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        'reporteRTB.ExportToPdf()
                        Dim printTool As New ReportPrintTool(reporteRTB)
                        printTool.ShowPreviewDialog()
                    Else
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        Dim reportPath As String = "c:\\SIM\pdf\" + DatosPacienteG + ".pdf"
                        Dim pdfOptions As PdfExportOptions = reporteRTB.ExportOptions.Pdf

                        pdfOptions.DocumentOptions.Application = "SIM - Sistema Integrado Medico"
                        pdfOptions.DocumentOptions.Author = "Ados Software"
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                        'pdfOptions.DocumentOptions.Subject = "Document Subject"
                        pdfOptions.DocumentOptions.Title = DatosPacienteG

                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        reporteRTB.ExportToPdf(reportPath, pdfOptions)

                    End If
                End If



                'printTool.ShowRibbonPreview()
                'printTool.PrintDialog()


                'ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                'Case 17 'SERVICIOS AGORA
                'Case 18 '
        End Select
    End Sub
    Private Sub ResultadosAWS(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        Select Case LicenciaG
            'Case 1 'ADOS SOFTWARE & DISEÑO
            'Case 2 'LABORATORIO DE INMUNOPATOLOGICO DE LA COSTA

            Case 16 'CD PATOLOGIA ONCOLOGICA SAS
                'IMPRESION CON DEVEXPRESS XTRA REPORT
                'definimos elreporte
                If VistaPrevia = False Then
                    Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCDPreliminar
                    Dim filtro As New Parameter()
                    'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                    Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                    _DImpresionPatologia.Guardar(IDOrdenG)
                    '------------------------------------------------------------
                    'filtro.Name = "idOrden"
                    filtro.Value = IDOrdenG
                    filtro.Visible = False
                    reporteRTB.Parameters.Add(filtro)
                    reporteRTB.FilterString = "[ID] = ?idOrden"
                    reporteRTB.RequestParameters = False
                    reporteRTB.Parameters(0).Value = IDOrdenG
                    reporteRTB.Parameters("idOrden").Value = IDOrdenG
                    Dim printTool As New ReportPrintTool(reporteRTB)
                    printTool.ShowPreviewDialog()
                    'printTool.show
                Else
                    'Verificamos si es una Inmunohistoquimica
                    If Estudio = "INMUNOHISTOQUIMICA" Then
                        'Lamamos Inmonothistoquimica
                        Dim _frmOpen As New SIM___GLOBAL.frmPDF
                        _frmOpen.Consecutivo = ConsecutivoG
                        _frmOpen.ShowDialog()
                    ElseIf Fotos = "0" Then
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                        Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                        _DImpresionPatologia.Guardar(IDOrdenG)
                        '------------------------------------------------------------
                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        'reporteRTB.ExportToPdf()
                        Dim printTool As New ReportPrintTool(reporteRTB)
                        printTool.ShowPreviewDialog()
                    Else
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        Dim reportPath As String = "c:\\SIM\resultados\" + IDOrdenG + ".pdf"
                        Dim pdfOptions As PdfExportOptions = reporteRTB.ExportOptions.Pdf

                        pdfOptions.DocumentOptions.Application = "SIM - Sistema Integrado Medico"
                        pdfOptions.DocumentOptions.Author = "Ados Software"
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                        'pdfOptions.DocumentOptions.Subject = "Document Subject"
                        pdfOptions.DocumentOptions.Title = DatosPacienteG

                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        reporteRTB.ExportToPdf(reportPath, pdfOptions)

                        'Llamar funcion subir archivo AWS

                    End If
                End If



                'printTool.ShowRibbonPreview()
                'printTool.PrintDialog()


                'ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, LicenciaG, Estudio, VistaPrevia)
                'Case 17 'SERVICIOS AGORA
                'Case 18 '
        End Select
    End Sub
    Private Sub GastrolapImpresion() ' IMPRESION GASTROLAP ESTUDIOS E HISTORIAS
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Select Case Estudio
            Case "CONSULTA PRIMERA VEZ"
                MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "CONSULTA DE CONTROL"
                MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "ENDOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                Else
                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                End If
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "COLONOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                Else
                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                End If
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "RECTOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                Else
                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                End If
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "CONSULTA PREANESTESICA"
                MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "ESTUDIOS ESPECIALES"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                ImprimirFrm.CargarReporte("imgestudios_especiales.rpt", IDDetalleOrdenG)
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case Else
                'MsgBox(Registro)
        End Select
    End Sub
    Private Sub ImpresionDiteg()
        'Borrar despues Procedimiento imprimir Diteg OJO BORRAR
        Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
        'Dim DetalleOrden As New SIM__GLOBAL.My.Modelo.DetalleOrden
        'Dim dDetalleOrden As New SIM__GLOBAL.Controles.DDetalleOrden
        ImprimirFrm = New SIM___GLOBAL.frmImprimir

        Select Case Estudio
            Case "CONSULTA PRIMERA VEZ"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                Select Case LicenciaG
                    Case 4
                        'llamamos el Reporte de historia
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                        Else
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                        End If
                    Case 3, 9
                        ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                        'ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)

                End Select
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
            Case "CONSULTA DE CONTROL"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                Select Case LicenciaG
                    Case 4
                        'llamamos el Reporte de historia
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                        Else
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                        End If
                    Case 3, 9
                        ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
            Case "ENDOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("endoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "COLONOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("colonoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "RECTOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("rectoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "CONSULTA PREANESTESICA"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                ImpresionHistoria(IDDetalleOrdenG, "C")
                ImprimirFrm.CargarReporte("historia_preanestesica.rpt", IDDetalleOrdenG)
            Case "ESTUDIOS ESPECIALES"
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                'ImpresionEndoscopia(IDDetalleOrdenG)
                'ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case Else
                'MsgBox(Registro)
        End Select
    End Sub
    Private Sub ImpresionGastrolap()
        'Borrar despues Procedimiento imprimir Diteg OJO BORRAR
        Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
        'Dim DetalleOrden As New SIM__GLOBAL.My.Modelo.DetalleOrden
        'Dim dDetalleOrden As New SIM__GLOBAL.Controles.DDetalleOrden
        ImprimirFrm = New SIM___GLOBAL.frmImprimir

        Select Case Estudio
            Case "CONSULTA PRIMERA VEZ"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                Select Case LicenciaG
                    Case 4
                        'llamamos el Reporte de historia
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                        Else
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                        End If
                    Case 3, 9
                        ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                        'ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)

                End Select
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
            Case "CONSULTA DE CONTROL"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                Select Case LicenciaG
                    Case 4
                        'llamamos el Reporte de historia
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                        Else
                            ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                        End If
                    Case 3, 9
                        ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
            Case "ENDOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("endoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "COLONOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("colonoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "RECTOSCOPIA"
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("rectoscopia.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case "CONSULTA PREANESTESICA"
                _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                ImpresionHistoria(IDDetalleOrdenG, "C")
                ImprimirFrm.CargarReporte("historia_preanestesica.rpt", IDDetalleOrdenG)
            Case "ESTUDIOS ESPECIALES"
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                'ImpresionEndoscopia(IDDetalleOrdenG)
                'ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                ImpresionEndoscopia(IDDetalleOrdenG)
                Select Case LicenciaG
                    Case 4
                        If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 1, LicenciaG, "0")
                        Else
                            ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 0, LicenciaG, "0")
                        End If
                    Case 3
                        ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                End Select
                _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
            Case Else
                'MsgBox(Registro)
        End Select
    End Sub
#End Region

    Private Sub HabilitarPrivilegios(ByVal FiltroLicencia As String)
        Select Case FiltroLicencia
            Case 1 'ADOS Software & Diseño
#Region "ADOS SOFTWARE SOPORTE"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiIncapacidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAnestesia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgReportes.Visible = True 'Reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiReporteEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosFotos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudiosFoto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInformes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgCompras.Visible = True ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgTransacciones.Visible = True 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgConfiguracion.Visible = True 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiResolucionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONFIGURACION
                rpgReportes.Visible = True 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 2 'Inmunopat
            Case 3 'Diteg
#Region "DITEG"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgReportes.Visible = True ' Grupo Reportes
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bsiImpresionOrdenesMedicas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiResolucionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 4 ' GASTROLAP
#Region "GASTROLAP"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAnestesia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgReportes.Visible = True ' Grupo Reportes
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bsiImpresionOrdenesMedicas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiResolucionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = True 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 5 'INTEGRA
            Case 6 'KELLY GOMEZ
#Region "KELLY GOMEZ"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = True 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 7, 8 'DR VELEZ y DR IMBETH
            Case 9 'DRA LINCE
#Region "Dra LINCE"
                'Ordenbes de Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'contable
                bbiListadoOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'ventana
                'Administracion
                'Configuracion
                'Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 10 ' FANNY ORTODONCIA
#Region "FANNY LINCE ORTODONCIA"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = False 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 11 'CITOPAT DE LA COSTA
#Region "CITOPAT DE LA COSTA"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiIncapacidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgReportes.Visible = True 'Reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiReporteEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosFotos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudiosFoto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInformes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bsiImpresionOrdenesMedicas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiResolucionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 12 'Aquamedical
#Region "AQUAMEDICAL"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgEstudios.Visible = False 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgTalentoHumano.Visible = False 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgContratacionSalud.Visible = False ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgPlantillas.Visible = False 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgCompras.Visible = True ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgTransacciones.Visible = True 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgConfiguracion.Visible = True 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
#End Region
            Case 13 'Materiales la punta
            Case 14 'DR PONCE
#Region "DR PONCE"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiIncapacidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgReportes.Visible = True 'Reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiReporteEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosFotos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImprimirMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudiosFoto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInformes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = False 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
            Case 15 'OPTICA FREISEM
#Region "OPTICA FREISEM"
#End Region
            Case 16 'CD PATOLOGIA ONCOLOGICA
#Region "CD PATOLOGIA ONCOLOGICA"
                'ARCHIVO
                rpgAdmisiones.Visible = True 'Grupo Orden Atencion
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAuditoriaOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgEstudios.Visible = True 'Grupo Estudios
                bbiHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProgramacionProcedimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTomaMuestra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiOrtodoncia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiIncapacidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAnestesia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgReportes.Visible = True 'Reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiReporteEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEstudiosFotos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimirEstudiosFoto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRelacionPatologias.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiInformes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'ADMINISTRACION
                rpgTerceros.Visible = True 'Grupo Terceros
                bbiUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiProveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTalentoHumano.Visible = True 'Grupo Talento Humano
                bbiCargos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                rpgContratacionSalud.Visible = True ' Grupo Contratacion
                bbiEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSubEntidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiContratos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTarifas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                rpgComplementos.Visible = True 'Grupo Complementos Sauld
                bbiEspecialidades.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiExamenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiMedicamentos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCups.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiDiagnosticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiTipoPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEstudiosPredeterminados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEquiposApoyo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiProcedimientosTerapeuticos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEspecimenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiUnidadMedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgPlantillas.Visible = True 'Grupo Plantillas
                bbiPlantillas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPlantillaConsentimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONTABLE
                rpgFacturacion.Visible = True 'Grupo Facturacion
                bbiCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgCompras.Visible = False ' Grupo Compras
                bbiOrdenCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgTransacciones.Visible = False 'Grupo Transacciones
                bbiNotaDebito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiNotaCredito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgConfiguracion.Visible = False 'grupo Configuracion
                bbiProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiTarifaProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiResolucionFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'CONFIGURACION
                rpgReportes.Visible = False 'Grupo Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                rpgSistema.Visible = True 'Grupo Sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
#End Region
        End Select

    End Sub
    Private Sub CargarPrivilegios(ByVal filtro As String)
        _Users = _dUsers.Cargar(filtro)
        'ORDENES DE ATENCION
        bbiNuevo.Enabled = _Users.Nuevo
        bbiEditar.Enabled = _Users.Editar
        bbiCancelar.Enabled = _Users.Anular
        bbiConsultar.Enabled = _Users.Consultar
        bbiAdjuntos.Enabled = _Users.Adjuntos
        bbiAgenda.Enabled = _Users.Agenda
        'ESTUDIOS
        bbiHistoria.Enabled = _Users.HistoriaClinica
        bbiHistoriasAnteriores.Enabled = _Users.HistoriaAnteriores
        bbiHistoriaGrupal.Enabled = _Users.HistoriaGrupal
        bbiEvolucionPaciente.Enabled = _Users.EvolucionPaciente
        bbiProgramacionProcedimiento.Enabled = _Users.ProgramacionCirugia
        bbiCitologia.Enabled = _Users.Citologia
        bbiPatologia.Enabled = _Users.Patologia
        bbiEndoscopia.Enabled = _Users.Endoscopia
        bbiImagenes.Enabled = _Users.AdjuntarImagenes
        'CONTABLE
        bbiListadoOrdenes.Enabled = _Users.ListadoOrdenes
        bbiFactura.Enabled = _Users.GenerarFactura
        bbiRips.Enabled = _Users.Rips
        'inventario = _Users.Inventario
        'nomina = _Users.Nomina
        'REPORTES
        bbiVistaPrevia.Enabled = _Users.VistaPrevia
        bbiImprimir.Enabled = _Users.Imprimir
        'Indicadores = _Users.IndicadoresGestion
        'PACIENTES
        bbiUsuarios.Enabled = _Users.Usuarios
        'CONTRATACION
        bbiEntidades.Enabled = _Users.Entidades
        bbiSubEntidades.Enabled = _Users.SubEntidades
        bbiContratos.Enabled = _Users.Contratos
        bbiTarifas.Enabled = _Users.Tarifas
        bbiDetalleTarifa.Enabled = _Users.DetalleTarifas
        'TALENTO HUMANO
        bbiCargos.Enabled = _Users.Cargos
        bbiEspecialidades.Enabled = _Users.Especialidades
        bbiEmpleados.Enabled = _Users.Empleados
        'COMPLEMENTOS
        bbiExamenes.Enabled = _Users.Examenes
        bbiMedicamentos.Enabled = _Users.Medicamentos
        bbiCups.Enabled = _Users.Cups
        bbiDiagnosticos.Enabled = _Users.Cie10
        bbiTipoPatologia.Enabled = _Users.TipoPatologia
        bbiEstudiosPredeterminados.Enabled = _Users.EstudiosPredeterminados
        bbiEquiposApoyo.Enabled = _Users.EquiposApoyo
        bbiProcedimientosTerapeuticos.Enabled = _Users.ProcedimientoTerapeutico
        'REPORTES
        bbiEncabezadoPie.Enabled = _Users.EncabezadoPiedepagina
        bbiLogo.Enabled = _Users.Logo
        bbiFirma.Enabled = _Users.Firma
        'SISTEMA
        bbiUsers.Enabled = _Users.Users
        bbiSeguridad.Enabled = True
        bbiPrivilegios.Enabled = _Users.Privilegios
        'CONTENIDO SIM
        bbiAyudaProducto.Enabled = _Users.AyudaProducto
        bbiSoporteTecnico.Enabled = _Users.SoporteTecnico
        bbiTutoriales.Enabled = _Users.Tutoriales
        bbiAcercaDe.Enabled = _Users.Acercade


    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selecciona el SKIN predeterminado
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")

        HabilitarPrivilegios(LicenciaG)
        CargarPrivilegios(IdEmpleadoG)


        'Cargamos Informacion de Licencia
        Dim _Licencia As New SIM___GLOBAL.Modelo.Licencias
        Dim _DLicencia As New SIM___GLOBAL.Controles.DLicencias

        _Licencia = _DLicencia.Cargar(LicenciaG)
        Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _Licencia.NombreCliente
        lblUsers.Caption = NombreEmpleado

    End Sub

    Private Sub bbtExamanes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExamenes.ItemClick
        'Dim _frmOpen As New frmExamenes
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbtProcedimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCups.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDiagnosticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDiagnosticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMedicamentos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmMedicamentos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Formulario = Nothing
        'Dim _frmOpen As New SIM_ENDOSCOPIA.frmOrdenes
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
        IDDetalleOrdenG = Nothing
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.Empleado = lblUsers.Caption
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If Funciones.IsLoaded("frmConsultarEndoscopia") = True Or Funciones.IsLoaded("frmConsultarCitoPato") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Consultar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case LicenciaG
                Case 1 'ADOS SOFTWARE DEMO
                    MsgBox("Consultar ADOS")
                Case 2, 6 'ESPECIALIDAD LABORATORIO DE PATOLOGIA
                    _frmConsultarCitopato = New frmConsultarCitoPato
                    _frmConsultarCitopato.MdiParent = Me
                    _frmConsultarCitopato.Recargar(Year(Now))
                    _frmConsultarCitopato.Show()
                Case 11 'CITOPAT DE LA COSTA
                    _frmConsultarCitopato = New frmConsultarCitoPato
                    _frmConsultarCitopato.MdiParent = Me
                    _frmConsultarCitopato.Recargar(Year(Now))
                    _frmConsultarCitopato.Show()
                Case 16 ' CD Oncologia 
                    _frmConsultarCDPatologia = New frmConsultarCDPatologia
                    _frmConsultarCDPatologia.MdiParent = Me
                    _frmConsultarCDPatologia.Recargar(Year(Now))
                    _frmConsultarCDPatologia.Show()
                Case 3, 4, 9, 10, 14 ' ENDOSCOPIA y ORTODONCIA
                    _frmConsultarEndoscopia = New frmConsultarEndoscopia
                    _frmConsultarEndoscopia.MdiParent = Me
                    _frmConsultarEndoscopia.Recargar(Year(Now))
                    _frmConsultarEndoscopia.Show()
                Case Else
            End Select
        End If
    End Sub

    Private Sub bbtEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            Formulario = "Editar"
            Dim _DdetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
            Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden

            If _DdetalleOrden.DetalleOrdenPendienteEndoscopia(IDDetalleOrdenG) = True Then
                'MsgBox("EDITAR")
                Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
                '_frmOpen.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                _frmOpen.Size = New Size(750, 600)
                _frmOpen.StartPosition = FormStartPosition.CenterScreen
                _frmOpen.ShowDialog()

            Else
                MessageBox.Show("Esta orden ya fue Atendida o Cancelada", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtAdjuntos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdjuntos.ItemClick
        If IDOrdenG <> Nothing Then
            Dim _frmOpen As New SIM___GLOBAL.frmAdjuntos
            _frmOpen.Orden = IDOrdenG
            _frmOpen.ShowDialog()

        Else
            MessageBox.Show("Debe Seleccionar una Orden para Adjuntar Archivos", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            'Dim _Dorden = New DOrdenes
            Dim _DDetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
            If _DDetalleOrden.DetalleOrdenPendienteEndoscopia(IDDetalleOrdenG) = True Then
                If MessageBox.Show("¿Desea cancelar el estudio o historia?", "Cancelar Estudio/Historia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    _DDetalleOrden.CancelarDetalleOrden(IDDetalleOrdenG)
                    Dim funciones = New Funciones
                    funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
                End If
            Else
                MessageBox.Show("El estudio o historia no se puede cancelar", "Cancelar Estudio/Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar un estudio o historia", "Cancelar Estudio/Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtHistoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHistoria.ItemClick
        If Funciones.IsLoaded("frmHistoria") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case LicenciaG
                Case 3, 4, 9, 14 ' DITEG, GASTROLAP, BEATRIZ LINCE, FERNANDO PONCE
                    _frmHistoria = New SIM_ENDOSCOPIA.frmHistoria
                    _frmHistoria.Licencia = LicenciaG
                    _frmHistoria.IdEmpleado = IdEmpleadoG
                    _frmHistoria.MdiParent = Me
                    _frmHistoria.Show()
                Case Else
            End Select

        End If


    End Sub

    Private Sub bbtCirugia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProgramacionProcedimiento.ItemClick
        'If Registro <> "" Then
        ' Dim _Dorden = New DOrdenes
        ' If _Dorden.OrdenAtendida(Registro) = True Then
        ' Dim _frmOpen As New frmProgramacionCirugia
        ' Registro = ""
        ' _frmOpen.ShowDialog()
        ' Else
        ' MessageBox.Show("Esta orden no tiene Historia Clinica", "Programación de Cirugia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '     End If
        ' End If
    End Sub

    Private Sub bbtSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSalir.ItemClick
        '******** Formulario Principal 

        'End
    End Sub

    Private Sub bbtPrueba_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'If Funciones.IsLoaded("frmPrueba") = True Then
        ' MsgBox("cargado")
        ' '_consultarFrm.Focus()
        ' Else
        ' MsgBox("NO cargado")
        '
        '        End If
        'Dim _frm   Open As New frmPrueba
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiImagenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImagenes.ItemClick
        If Funciones.IsLoaded("frmImagenesVideo") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmImagenes = New SIM___GLOBAL.frmImagenesVideo 'SIM_ENDOSCOPIA.frmImagenes
            _frmImagenes.MdiParent = Me
            _frmImagenes.Show()
        End If
    End Sub


    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick

    End Sub

    Private Sub bbiCargos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCargos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCargos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEspecialidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecialidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecialidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEmpleados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEmpleados.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEmpleados
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsers.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEvolucionPaciente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEvolucionPaciente.ItemClick
        'If Registro <> "" Then
        ' Dim ImprimirFrm As New frmImprimir
        ' Dim _DOrdenes As New DOrdenes
        ' ImprimirFrm.CargarReporte("ReporteGeneral.rpt", _DOrdenes.IdUsuario(Registro))
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub

    Private Sub bbiTipoPatologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTipoPatologia.ItemClick
        'Dim _frmOpen As New frmTipoPatologia
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAcercaDe.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmEntidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifas.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiContratos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContratos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmContratos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtHistoriasAnteriores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHistoriasAnteriores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmHistoriasAnteriores
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiListadoOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoOrdenes.ItemClick
        'ACTUALIZAR LISTADO ORDENES EN GLOBAL 
        Dim _frmOpen As New SIM_ENDOSCOPIA.frmListadoOrdenes
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFactura.ItemClick
        If Funciones.IsLoaded("frmFacturas") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmFacturacion = New SIM___GLOBAL.frmFacturas
            _frmFacturacion.MdiParent = Me
            _frmFacturacion.IDEmpleado = IdEmpleadoG
            _frmFacturacion.Licencia = LicenciaG
            _frmFacturacion.Show()
        End If

    End Sub

    Private Sub bbiAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgenda.ItemClick
        If Funciones.IsLoaded("frmAgenda") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmAgenda = New SIM___GLOBAL.frmAgenda
            _frmAgenda.MdiParent = Me
            _frmAgenda.idEmpleado = IdEmpleadoG
            _frmAgenda.Licencia = LicenciaG
            _frmAgenda.Show()
        End If
    End Sub

    Private Sub bbiPrivilegios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrivilegios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPrivilegios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSeguridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeguridad.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        _frmOpen.idEmpleado2 = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEndoscopia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEndoscopia.ItemClick
        If Funciones.IsLoaded("frmEndoscopia") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Estudios de Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case LicenciaG
                Case 3 ' DITEG
                    _frmEndoscopia = New SIM_ENDOSCOPIA.frmEndoscopia
                    _frmEndoscopia.MdiParent = Me
                    _frmEndoscopia.Licencia = LicenciaG
                    _frmEndoscopia.IdEmpleado = IdEmpleadoG
                    _frmEndoscopia.Show()
                Case Else ' GASTROLAP
                    _frmEndoscopiaGl = New SIM_ENDOSCOPIA.frmEndoscopiaGL
                    _frmEndoscopiaGl.MdiParent = Me
                    _frmEndoscopiaGl.Licencia = LicenciaG
                    _frmEndoscopiaGl.IdEmpleado = IdEmpleadoG
                    _frmEndoscopiaGl.Show()
            End Select


        End If
    End Sub

    Private Sub bbiAyudaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAyudaProducto.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPruebaJson
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEquipos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEquiposApoyo.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEquipos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSubEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSubEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSubEntidades
        _frmOpen.ShowDialog()

    End Sub
    Private Sub ImpresionHistoria(ByVal Filtro As String, ByVal Control As String)

        Dim _ds = New DataSet
        _ds = _dImpresionHistoria.Listar(Filtro, Control)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionHistoria.Id = Val("")
        _ImpresionHistoria.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionHistoria.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionHistoria.NumeroHistoria = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionHistoria.Nombre = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionHistoria.Identificacion = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionHistoria.Edad = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionHistoria.Sexo = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionHistoria.EstadoCivil = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionHistoria.Telefono = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionHistoria.Direccion = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionHistoria.Entidad = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionHistoria.FechaIngreso = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionHistoria.FechaAtencion = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionHistoria.MotivoConsulta = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionHistoria.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionHistoria.AntecedentesPersonales = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionHistoria.EnfermedadActual = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionHistoria.PlanSeguir = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionHistoria.Diagnostico = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionHistoria.Recomendaciones = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionHistoria.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(20))

        _ImpresionHistoria.Medico = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionHistoria.Especialidad = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionHistoria.RegistroMedico = _ds.Tables(0).Rows(0)(23).ToString
        _ImpresionHistoria.IdEmpleado = IdEmpleadoG
        _dImpresionHistoria.Guardar(_ImpresionHistoria)
    End Sub
    Private Sub ImpresionEndoscopia(ByVal Filtro As String)
        Dim _dimagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        Dim _ds = New DataSet

        _ds = _dImpresionEndoscopia.Listar(Filtro)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionEndoscopia.Id = Val("")
        _ImpresionEndoscopia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionEndoscopia.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionEndoscopia.Estudio = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionEndoscopia.FechaIngreso = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionEndoscopia.Nombre = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionEndoscopia.Identificacion = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionEndoscopia.Edad = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionEndoscopia.Sexo = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionEndoscopia.EstadoCivil = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionEndoscopia.Telefono = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionEndoscopia.Direccion = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionEndoscopia.Entidad = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionEndoscopia.MedicoSolicita = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionEndoscopia.Indicacion = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionEndoscopia.Medicamentos = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionEndoscopia.Equipo = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionEndoscopia.Anestesiologo = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionEndoscopia.ProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionEndoscopia.Campo1 = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionEndoscopia.Campo2 = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionEndoscopia.Campo3 = _ds.Tables(0).Rows(0)(20).ToString
        _ImpresionEndoscopia.Campo4 = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionEndoscopia.Campo5 = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionEndoscopia.Campo6 = _ds.Tables(0).Rows(0)(23).ToString

        _ImpresionEndoscopia.Diagnostico = _ds.Tables(0).Rows(0)(24).ToString
        _ImpresionEndoscopia.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(25))
        _ImpresionEndoscopia.Medico = _ds.Tables(0).Rows(0)(26).ToString
        _ImpresionEndoscopia.Especialidad = _ds.Tables(0).Rows(0)(27).ToString
        _ImpresionEndoscopia.RegistroMedico = _ds.Tables(0).Rows(0)(28).ToString
        _ImpresionEndoscopia.IdEmpleado = IdEmpleadoG '_ds.Tables(0).Rows(0)(26).ToString

        _dImpresionEndoscopia.Guardar(_ImpresionEndoscopia)


    End Sub

    Private Sub bbiTerapeuticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcedimientosTerapeuticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProcedimientosTerapeuticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub BbiEstudiosFotos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEstudiosFotos.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                Dim dImagenes As New DImagenes
                If dImagenes.ExisteImagenes(IDDetalleOrdenG) = True Then
                    ImpresionResultados("1", True)
                Else
                    MessageBox.Show("El Estudio no Presenta Imagenes", "Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BbiReporteEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteEstudios.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                ImpresionResultados("0", True)
            Else
                If LicenciaG = 16 Then
                    ImpresionResultados("0", False)
                Else
                    MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiPlantillas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPlantillas.ItemClick

        If LicenciaG = 16 Or LicenciaG = 11 Then ' CD Patologia Oncologica
            Dim _frmOpen As New SIM___GLOBAL.frmPlantillaPatologia
            _frmOpen.ShowDialog()
        ElseIf LicenciaG = 4 Then
            Dim _frmOpen As New SIM___GLOBAL.frmPlantillasInformes
            _frmOpen.ShowDialog()
        End If
    End Sub

    Private Sub bbiCerrarSesion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrarSesion.ItemClick
        If Funciones.IsLoaded("frmConsultarEndoscopia") = True Or Funciones.IsLoaded("frmConsultarCitoPato") = True Or Funciones.IsLoaded("frmAgenda") = True Or Funciones.IsLoaded("frmHistoria") = True Or Funciones.IsLoaded("frmEndoscopiaGL") = True Or Funciones.IsLoaded("frmImagenes") = True Then
            If MessageBox.Show("Se encuentran ventanas Abiertas, ¿Desea cerrarlas junto con la Sesion?", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'MessageBox.Show("SI")
                If Funciones.IsLoaded("frmConsultarCitoPato") = True Then
                    _frmConsultarCitopato.Close()
                End If
                If Funciones.IsLoaded("frmConsultarEndoscopia") = True Then
                    _frmConsultarEndoscopia.Close()
                End If
                If Funciones.IsLoaded("frmAgenda") = True Then
                    _frmAgenda.Close()
                End If
                If Funciones.IsLoaded("frmHistoria") = True Then
                    _frmHistoria.Close()
                End If
                If Funciones.IsLoaded("frmEndoscopiaGL") = True Then
                    _frmEndoscopia.Close()
                End If
                If Funciones.IsLoaded("frmImagenes") = True Then
                    _frmImagenes.Close()
                End If
                'If Funciones.IsLoaded("frmHistoriaGrupal") = True Then
                ' _frmHistoriaGrupal.Close()
                ' End If

                'MessageBox.Show("Cerrar Sesion")
                '******** Formulario Inicio de Sesion 
                Dim _frmOpen As New frmSesion
                _frmOpen.Show()
                Me.Close()
                'If _frmOpen.validar = True Then
                ' IdEmpleadoG = _frmOpen.IDEmpleado
                ' lblUsers.Caption = _frmOpen.NombreEmpleado
                ' 'bsiCargo.Caption = _frmOpen.Cargo
                ' 'bsiEspecialidad.Caption = _frmOpen.Especialidad
                ' 'IdEspecialidad = _frmOpen.IDEspecialidad
                ' LicenciaG = _frmOpen.Licencia
                ' Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
                ' HabilitarPrivilegios(LicenciaG)
                ' CargarPrivilegios(IdEmpleadoG)
                ' Else
                '     End
                ' End If
            End If
        Else
            'MessageBox.Show("NO")
            '******** Formulario Inicio de Sesion 
            Dim _frmOpen As New frmSesion
            _frmOpen.Show()
            Me.Close()

            'If _frmOpen.validar = True Then
            ' IdEmpleadoG = _frmOpen.IDEmpleado
            ' lblUsers.Caption = _frmOpen.NombreEmpleado
            ' 'bsiCargo.Caption = _frmOpen.Cargo
            ' 'bsiEspecialidad.Caption = _frmOpen.Especialidad
            ' 'IdEspecialidad = _frmOpen.IDEspecialidad
            ' LicenciaG = _frmOpen.Licencia
            ' HabilitarPrivilegios(LicenciaG)
            ' CargarPrivilegios(IdEmpleadoG)
            ' Else
            'End
            'End If
        End If
    End Sub

    Private Sub bbiRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRips.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmRips
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOtrosEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOtrosEstudios.ItemClick
        If Funciones.IsLoaded("frmEstudiosEspeciales") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Estudios Especiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmEstudiosEspeciales = New SIM_ENDOSCOPIA.frmEstudiosEspeciales
            _frmEstudiosEspeciales.MdiParent = Me
            _frmEstudiosEspeciales.licencia = LicenciaG
            _frmEstudiosEspeciales.IdEmpleado = IdEmpleadoG
            _frmEstudiosEspeciales.Show()
        End If
    End Sub

    Private Sub bbiSoporteTecnico_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSoporteTecnico.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmGenerarPDF
        _frmOpen.Licencia = LicenciaG
        '_frmOpen.Estudio = Estudio
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTutoriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTutoriales.ItemClick
        _funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
    End Sub

    Private Sub bbiOrtodoncia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrtodoncia.ItemClick
        If Funciones.IsLoaded("frmOrtodoncia") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case LicenciaG
                Case 10 ' FANNY LINCE ORTODONCIA
                    _frmOrtodoncia = New SIM___GLOBAL.frmOrtodoncia
                    _frmOrtodoncia._IDEmpleado = IdEmpleadoG
                    _frmOrtodoncia.Licencia = LicenciaG
                    _frmOrtodoncia.MdiParent = Me
                    _frmOrtodoncia.Show()
                Case Else
            End Select

        End If
    End Sub

    Private Sub bbiPlantillaConsentimiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPlantillaConsentimiento.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmConsentimientoInformadoPlantillas

        _frmOpen.Licencia = LicenciaG
        '_frmOpen.Estudio = Estudio
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAuditoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAuditoria.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAuditoria
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifaProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifaProductos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifaProductos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProductos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProductos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInventario.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmInventario
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiNotaCredito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNotaCredito.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCredito
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiNotaDebito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNotaDebito.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDebito
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCompras.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCompras
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOrdenCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrdenCompra.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenCompra
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCotizaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCotizaciones.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCotizaciones
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProveedores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClientes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCitologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCitologia.ItemClick
        Dim _frmCitologia As New SIM___GLOBAL.frmCitologiaGeneral
        _frmCitologia.IDEmpleado = IdEmpleadoG
        _frmCitologia.Licencia = LicenciaG
        _frmCitologia.MdiParent = Me
        _frmCitologia.Show()
    End Sub

    Private Sub bbiPatologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPatologia.ItemClick
        Select Case LicenciaG
            Case 11 'Citopat de la costa
                Dim _frmPatologia As New SIM___GLOBAL.frmPatologiaGeneral
                _frmPatologia.IDEmpleado = IdEmpleadoG
                _frmPatologia.Licencia = LicenciaG
                _frmPatologia.MdiParent = Me
                _frmPatologia.Show()
            Case 16 'CO PATOLOGIA
                Dim _frmPatologia As New SIM___GLOBAL.frmPatologiaCD
                _frmPatologia.IDEmpleado = IdEmpleadoG
                _frmPatologia.Licencia = LicenciaG
                '_frmPatologia.Licencia = LicenciaG
                _frmPatologia.MdiParent = Me
                _frmPatologia.Show()
        End Select

    End Sub

    Private Sub bbiTomaMuestra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTomaMuestra.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTomaMuestra
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEnviarCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEnviarCorreo.ItemClick
        If IDOrdenG <> Nothing And Estado = "ATENDIDO" Then
            Dim _frmOpen As New SIM___GLOBAL.frmMail
            _frmOpen.Licencia = LicenciaG
            _frmOpen.IdDetalleOrden = IDDetalleOrdenG
            _frmOpen.IdOrden = IDOrdenG
            _frmOpen.TipoEstudio = Estudio
            _frmOpen.ShowDialog()
            '  Dim _ds As New DataSet
            '  _ds = _DOrdenes.UsuarioEmail(IDOrdenG)
            '  If _ds.Tables(0).Rows(0)(1) <> "" Then 'Campo Correo Electronico
            '  _funciones.EnviarReporteMail(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, IDOrdenG & " - " & _ds.Tables(0).Rows(0)(2).ToString & ".pdf", _ds.Tables(0).Rows(0)(1).ToString)
            ' Else
            '     MessageBox.Show("El usuario no tiene correo electronico registrado", "Enviar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            '_funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Enviar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub bbiAuditoriaOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAuditoriaOrdenes.ItemClick
        Dim _frmAuditoriaOrdenes As New SIM___GLOBAL.frmListadoOrdenes
        _frmAuditoriaOrdenes.IdEmpleado = IdEmpleadoG
        _frmAuditoriaOrdenes.Licencia = LicenciaG
        _frmAuditoriaOrdenes.MdiParent = Me
        _frmAuditoriaOrdenes.WindowState = FormWindowState.Maximized
        _frmAuditoriaOrdenes.Show()
    End Sub

    Private Sub bbiEspecimenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecimenes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecimenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiRelacionPatologias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRelacionPatologias.ItemClick
        Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
        ImprimirFrm = New SIM___GLOBAL.frmImprimir
        Select Case LicenciaG
            Case 2, 6, 11, 16 'PATOLOGIA
                If IDOrdenG <> Nothing Then
                    'MsgBox(Format(FechaG, "yyyy/MM/dd"))
                    ImprimirFrm.ImprimirRelacionPatologias(Format(FechaG, "yyyy/MM/dd"), LicenciaG)
                Else
                    MessageBox.Show("Debe Seleccionar una Fecha", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Else
        End Select
    End Sub

    Private Sub bbiUnidadMedida_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUnidadMedida.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUnidadMedida
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiInformes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInformes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmInformes
        _frmOpen.Admin = lblUsers.Caption
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCaja_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCaja.ItemClick
        'If IDOrdenG <> Nothing Then
        Dim _frmOpen As New SIM___GLOBAL.frmReciboCaja
        _frmOpen.IdOrden = IDOrdenG
        _frmOpen.Empleado = lblUsers.Caption
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
        'Else
        'MessageBox.Show("Debe Seleccionar una Orden", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub bbiEntregaResultados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEntregaResultados.ItemClick
        If IDOrdenG = "" Then
            MessageBox.Show("Debe seleccionar una orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DEntregaResultados.Existe(IDOrdenG) = False Then
            MessageBox.Show("No existe recibo para esta orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirReciboEntregaResultados(IDOrdenG, LicenciaG)
        End If
    End Sub

    Private Sub bbiIncapacidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiIncapacidades.ItemClick
        If IDOrdenG <> Nothing And (Estado <> "CANCELADO") Then
            Dim _frmOpen As New SIM___GLOBAL.frmIncapacidades
            _frmOpen.Licencia = LicenciaG
            _frmOpen.IdOrden = IDOrdenG
            _frmOpen.IdDetalleOrden = IDDetalleOrdenG
            _frmOpen.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar una Orden que no este Cancelada", "Incapacidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub bbiResolucionFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiResolucionFactura.ItemClick
        'Dim _frmOpen As New SIM___GLOBAL.frmTarifaProductos
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiImprimirEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirEstudios.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                ImpresionResultados("0", True)
            Else
                If LicenciaG = 16 Then
                    ImpresionResultados("0", False)
                Else
                    MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiReporteLaboratorios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteLaboratorios.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "LABORATORIOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiReporteProcedimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteProcedimientos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "PROCEDIMIENTOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiReporteEstudiosDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteEstudiosDiagnosticos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "ESTUDIOS DIAGNOSTICOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiAnestesia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnestesia.ItemClick
        Dim _frmAnestesia As New SIM___GLOBAL.frmAnestesia
        _frmAnestesia.IDEmpleado = IdEmpleadoG
        _frmAnestesia.Licencia = LicenciaG
        _frmAnestesia.MdiParent = Me
        _frmAnestesia.Show()
    End Sub





    Private Sub bbiImprimirEstudiosFoto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirEstudiosFoto.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                Dim dImagenes As New DImagenes
                If dImagenes.ExisteImagenes(IDDetalleOrdenG) = True Then
                    ImpresionResultados("1", True)
                Else
                    MessageBox.Show("El Estudio no Presenta Imagenes", "Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiRegistroAnestesia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRegistroAnestesia.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                Estudio = "REGISTRO ANESTESIA"
                ImpresionResultados("0", True)
            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
                MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiReporteMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteMedicamentos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "MEDICAMENTOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImpresionAnestesia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImpresionAnestesia.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then
                Estudio = "REGISTRO ANESTESIA"
                ImpresionResultados("0", True)
            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImpresionLaboratorios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImpresionLaboratorios.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "LABORATORIOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImpresionEstudiosDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImpresionEstudiosDiagnosticos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "ESTUDIOS DIAGNOSTICOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImpresionProcedimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImpresionProcedimientos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "PROCEDIMIENTOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImpresionMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImpresionMedicamentos.ItemClick
        If IDOrdenG <> Nothing And (Estado = "ATENDIDO" Or Estado = "FACTURADO") Then
            _funciones.ImprimirOrdenesMedicas(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG, "MEDICAMENTOS")
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiExportarPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPDF.ItemClick
        If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
            If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then

                ImpresionResultados(DatosPacienteG, True)
                'ResultadosAWS(DatosPacienteG, True)
                MessageBox.Show(DatosPacienteG, "Reporte PDF Generado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If LicenciaG = 16 Then
                    ImpresionResultados("0", False)
                Else
                    MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
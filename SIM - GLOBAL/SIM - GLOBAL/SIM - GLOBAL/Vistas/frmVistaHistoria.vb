Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades

Public Class frmVistaHistoria
    Public IdDetalleOrden As String
    Public IdOrden As String 'Se utiliza para la vista previa de Citologias y Patologias
    Public Licencia As String
    Public Estudio As String
    Dim _dsAntecedentes As DataSet

    'Dim _dhistoria As New SIM___INTEGRA.Controles.DHistoriaIntegra
    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _dImpresionOrtodoncia As New SIM___GLOBAL.Controles.DImpresionOrtodoncia
    Dim _DImpresionCitoPato As New SIM___GLOBAL.Controles.DImpresionCitoPato
    Dim _antecedentes As New SIM___GLOBAL.Modelo.Antecedentes
    Dim _DAntecedentes As New SIM___GLOBAL.Controles.DAntecedentes
    Dim _Funciones As New Funciones

    Dim _GaleriaImagenes As GalleryItemGroup = New GalleryItemGroup()
    Dim _Imagenes As Byte

    Private Sub CargarImagenes(ByVal Filtro As String)
        Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenesGlobal
        Dim _ds As DataSet

        _GaleriaImagenes.Items.Clear()
        gcImagenes.Gallery.Groups.Clear()
        _ds = New DataSet
        _ds = _dImagenes.ListarImagenesActivasIC(Filtro)
        If _ds.Tables(0).Rows.Count <> 0 Then
            _Imagenes = 1
            For x = 1 To _ds.Tables(0).Rows.Count
                'LLENAMOS GALERY CONTROL
                '_GaleriaImagenes.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
                _GaleriaImagenes.Items.Add(New GalleryItem(_Funciones.Bytes_Imagen(_ds.Tables(0).Rows(x - 1)(0)), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
            Next
            gcImagenes.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
            gcImagenes.Gallery.ImageSize = New Size(100, 70)
            gcImagenes.Gallery.Groups.Add(_GaleriaImagenes)
        Else
            _Imagenes = 0
        End If
    End Sub
    Private Sub frmVistaHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _ds As DataSet
        Dim _VPHistoriaDiagnosticos As DataSet
        Dim _VPHistoriaRXS As DataSet
        Dim _VPHistoriaLaboratorios As DataSet
        Dim _VPHistoriaOtrosEstudios As DataSet
        Dim _VPHistoriaFormulacion As DataSet
        Dim _VPHistoriaDetalle As DataSet
        If Estudio = "CONSULTA PRIMERA VEZ" Or Estudio = "CONSULTA DE CONTROL" Then
#Region "CONSULTAS"
            'Datos de la Historia
            _ds = New DataSet
            _ds = _dImpresionHistoria.VistaPreviaHistoria(IdDetalleOrden)

            'Revisión por Sistemas
            _VPHistoriaRXS = New DataSet
            _VPHistoriaRXS = _dImpresionHistoria.VistaPreviaHistoriaRXS(IdDetalleOrden)

            If Licencia = 1 Then
                'Masculinización y Escala Prader
                _VPHistoriaDetalle = New DataSet
                _VPHistoriaDetalle = _dImpresionHistoria.VistaPreviaHistoriaDetalle(IdDetalleOrden)
            End If

            'Diagnosticos
            _VPHistoriaDiagnosticos = New DataSet
            _VPHistoriaDiagnosticos = _dImpresionHistoria.VistaPreviaHistoriaDiagnosticos(IdDetalleOrden)

            'Laboratorios
            _VPHistoriaLaboratorios = New DataSet
            _VPHistoriaLaboratorios = _dImpresionHistoria.VistaPreviaHistoriaLaboratorios(IdDetalleOrden)

            'Medicamentos
            _VPHistoriaFormulacion = _dImpresionHistoria.VistaPreviaHistoriaFormulacion(IdDetalleOrden)

            'Otros Estudios
            _VPHistoriaOtrosEstudios = New DataSet
            _VPHistoriaOtrosEstudios = _dImpresionHistoria.VistaPreviaHistoriaOtrosEstudios(IdDetalleOrden)

            lblID.Text = _ds.Tables(0).Rows(0)(0).ToString
            lblUsuario.Text = _ds.Tables(0).Rows(0)(1).ToString
            lblIdentificacion.Text = _ds.Tables(0).Rows(0)(2).ToString
            lblSexo.Text = _ds.Tables(0).Rows(0)(3).ToString
            lblEdad.Text = _ds.Tables(0).Rows(0)(4).ToString
            lblTelefono.Text = _ds.Tables(0).Rows(0)(5).ToString
            lblDireccion.Text = _ds.Tables(0).Rows(0)(6).ToString

            lblOrden.Text = _ds.Tables(0).Rows(0)(7).ToString
            lblFecha.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 1, 10)
            lblContrato.Text = _ds.Tables(0).Rows(0)(9).ToString

            lblEspecialista.Text = _ds.Tables(0).Rows(0)(10).ToString
            lblEspecialidad.Text = _ds.Tables(0).Rows(0)(11).ToString
            lblHora.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 11, 13)
            lblConsulta.Text = _ds.Tables(0).Rows(0)(12).ToString
            lblHistoria.Text = _ds.Tables(0).Rows(0)(13).ToString

            If _ds.Tables(0).Rows(0)(15).ToString <> Nothing Then ' Responsables
                txtReporte.Text = txtReporte.Text & vbCrLf & "RESPONSABLES: " & vbCrLf & _ds.Tables(0).Rows(0)(15).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(14).ToString <> "" Then ' Motivo de Consulta
                txtReporte.Text = "MOTIVO DE CONSULTA: " & vbCrLf & _ds.Tables(0).Rows(0)(14).ToString & vbCrLf
            Else
                txtReporte.Text = "CONSULTA DE CONTROL: " & vbCrLf & _ds.Tables(0).Rows(0)(16).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(17).ToString <> "" Then
                txtReporte.Text = txtReporte.Text & vbCrLf & "ENFERMEDAD ACTUAL:" & vbCrLf & _ds.Tables(0).Rows(0)(17).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(18).ToString <> "" Then
                txtReporte.Text = txtReporte.Text & vbCrLf & "REVISION POR SISTEMAS:" & vbCrLf & _ds.Tables(0).Rows(0)(18).ToString & vbCrLf
            End If

            'Antecedentes
            If _DAntecedentes.ExisteUsuario(_ds.Tables(0).Rows(0)(0).ToString) = True Then
                _dsAntecedentes = New DataSet
                _dsAntecedentes = _DAntecedentes.ListarAntecedentes(_ds.Tables(0).Rows(0)(0).ToString)
                txtReporte.Text = txtReporte.Text & vbCrLf & "ANTECEDENTES FAMILIARES:" & vbCrLf & _dsAntecedentes.Tables(0).Rows(0)(0).ToString & vbCrLf
                txtReporte.Text = txtReporte.Text & vbCrLf & "ANTECEDENTES PERSONALES:" & vbCrLf & _dsAntecedentes.Tables(0).Rows(0)(1).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(21).ToString <> "" Then 'Examen Fisico
                txtReporte.Text = txtReporte.Text & vbCrLf & "EXAMEN FISICO:" & vbCrLf & _ds.Tables(0).Rows(0)(21).ToString & vbCrLf
            End If

            'Examen Fisico Peso Talla
            txtReporte.Text = txtReporte.Text & vbCrLf & "PESO:" & _ds.Tables(0).Rows(0)(22).ToString & " TALLA: " & _ds.Tables(0).Rows(0)(23).ToString & " TA: " & _ds.Tables(0).Rows(0)(24).ToString & " FR: " & _ds.Tables(0).Rows(0)(25).ToString & " FC: " & _ds.Tables(0).Rows(0)(26).ToString & " Temperatura: " & _ds.Tables(0).Rows(0)(27).ToString & vbCrLf

            'Revisión por Sistemas
            If _VPHistoriaRXS.Tables(0).Rows.Count <> 0 Then
                Dim I As Integer
                txtReporte.Text = txtReporte.Text & vbCrLf & "EXAMEN POR REGIONES:" & vbCrLf
                For I = 1 To _VPHistoriaRXS.Tables(0).Rows.Count
                    txtReporte.Text = txtReporte.Text & _VPHistoriaRXS.Tables(0).Rows(I - 1)(0).ToString & "        " & _VPHistoriaRXS.Tables(0).Rows(I - 1)(1).ToString & vbCrLf
                Next
            End If

            ' Tanner
            If Licencia = 1 Then 'Carlos MArtinez
                txtReporte.Text = txtReporte.Text & "TANNER A: " & _ds.Tables(0).Rows(0)(28).ToString
                txtReporte.Text = txtReporte.Text & "  TANNER B: " & _ds.Tables(0).Rows(0)(29).ToString
                txtReporte.Text = txtReporte.Text & "  TANNER P: " & _ds.Tables(0).Rows(0)(30).ToString
                txtReporte.Text = txtReporte.Text & "  TANNER VT: " & _ds.Tables(0).Rows(0)(31).ToString
                txtReporte.Text = txtReporte.Text & "  TANNER LP: " & _ds.Tables(0).Rows(0)(32).ToString & vbCrLf & vbCrLf
            End If

            If Licencia = 1 Then
                'Masculinización y Escala Prader
                If _VPHistoriaDetalle.Tables(0).Rows.Count <> 0 Then
                    If lblSexo.Text = "F" Then
                        txtReporte.Text = txtReporte.Text & " ESCALA PRADER: " & _VPHistoriaDetalle.Tables(0).Rows(0)(5).ToString & vbCrLf
                    Else
                        txtReporte.Text = txtReporte.Text & "FUNCION ESCROTAL: " & _VPHistoriaDetalle.Tables(0).Rows(0)(0).ToString
                        txtReporte.Text = txtReporte.Text & "  MICROPENE: " & _VPHistoriaDetalle.Tables(0).Rows(0)(1).ToString
                        txtReporte.Text = txtReporte.Text & "  MEATUS URETRAL: " & _VPHistoriaDetalle.Tables(0).Rows(0)(2).ToString
                        txtReporte.Text = txtReporte.Text & "  TESTICULO IZQUIERDO: " & _VPHistoriaDetalle.Tables(0).Rows(0)(3).ToString
                        txtReporte.Text = txtReporte.Text & "  TESTICULO DERECHO: " & _VPHistoriaDetalle.Tables(0).Rows(0)(4).ToString
                        txtReporte.Text = txtReporte.Text & "  ESCALA PRADER: " & _VPHistoriaDetalle.Tables(0).Rows(0)(5).ToString & vbCrLf
                    End If
                End If
            End If

            If _ds.Tables(0).Rows(0)(37).ToString <> "" Then 'Laboratorios
                txtReporte.Text = txtReporte.Text & vbCrLf & "LABORATORIOS:" & vbCrLf & _ds.Tables(0).Rows(0)(37).ToString & vbCrLf
            End If

            'Examenes de laboratorio
            If _VPHistoriaLaboratorios.Tables(0).Rows.Count <> 0 Then
                Dim I As Integer
                txtReporte.Text = txtReporte.Text & vbCrLf & "EXAMENES DE LABORATORIO" & vbCrLf
                For I = 1 To _VPHistoriaLaboratorios.Tables(0).Rows.Count
                    txtReporte.Text = txtReporte.Text & _VPHistoriaLaboratorios.Tables(0).Rows(I - 1)(0).ToString & "     " & _VPHistoriaLaboratorios.Tables(0).Rows(I - 1)(1).ToString & vbCrLf
                Next
            End If

            If _ds.Tables(0).Rows(0)(38).ToString <> "" Then 'Otros Estudios
                txtReporte.Text = txtReporte.Text & vbCrLf & "OTROS ESTUDIOS:" & vbCrLf & _ds.Tables(0).Rows(0)(38).ToString
            End If

            'Otros Estudios
            If _VPHistoriaOtrosEstudios.Tables(0).Rows.Count <> 0 Then
                Dim I As Integer
                txtReporte.Text = txtReporte.Text & vbCrLf & "OTROS ESTUDIOS" & vbCrLf
                For I = 1 To _VPHistoriaOtrosEstudios.Tables(0).Rows.Count
                    txtReporte.Text = txtReporte.Text & _VPHistoriaOtrosEstudios.Tables(0).Rows(I - 1)(0).ToString & "     " & _VPHistoriaOtrosEstudios.Tables(0).Rows(I - 1)(1).ToString & vbCrLf
                Next
            End If

            If _ds.Tables(0).Rows(0)(35).ToString <> "" Then 'Plan a Seguir
                txtReporte.Text = txtReporte.Text & vbCrLf & "ANALISIS Y PLAN A SEGUIR:" & vbCrLf & _ds.Tables(0).Rows(0)(35).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(34).ToString <> "" Then 'Diagnosticos
                txtReporte.Text = txtReporte.Text & vbCrLf & "DIAGNOSTICO:" & vbCrLf & _ds.Tables(0).Rows(0)(34).ToString & vbCrLf
            End If

            '------------------------------------- Historia Diagnosticos --------------------------------
            If _VPHistoriaDiagnosticos.Tables(0).Rows.Count <> 0 Then
                Dim I As Integer
                txtReporte.Text = txtReporte.Text & vbCrLf & "CODIGO - " & "DIAGNOSTICO" & vbCrLf
                For I = 1 To _VPHistoriaDiagnosticos.Tables(0).Rows.Count
                    txtReporte.Text = txtReporte.Text & _VPHistoriaDiagnosticos.Tables(0).Rows(I - 1)(0).ToString & "        " & _VPHistoriaDiagnosticos.Tables(0).Rows(I - 1)(1).ToString & vbCrLf
                Next
            End If

            If _ds.Tables(0).Rows(0)(36).ToString <> "" Then 'Formulacion
                txtReporte.Text = txtReporte.Text & vbCrLf & "FORMULACION:" & vbCrLf & _ds.Tables(0).Rows(0)(36).ToString & vbCrLf
            End If

            'Formulacion
            If _VPHistoriaFormulacion.Tables(0).Rows.Count <> 0 Then
                Dim I As Integer
                txtReporte.Text = txtReporte.Text & vbCrLf & "FORMULACION" & vbCrLf
                txtReporte.Text = txtReporte.Text & vbCrLf & "CANT    NOMBRE           DOSIS   OBSERVACIONES" & vbCrLf
                For I = 1 To _VPHistoriaFormulacion.Tables(0).Rows.Count
                    txtReporte.Text = txtReporte.Text & _VPHistoriaFormulacion.Tables(0).Rows(I - 1)(0).ToString & " - " &
                    _VPHistoriaFormulacion.Tables(0).Rows(I - 1)(1).ToString & " - " &
                    _VPHistoriaFormulacion.Tables(0).Rows(I - 1)(2).ToString & " - " &
                    _VPHistoriaFormulacion.Tables(0).Rows(I - 1)(3).ToString & vbCrLf
                Next
            End If

            If _ds.Tables(0).Rows(0)(33).ToString <> "" Then 'Recomendaciones
                txtReporte.Text = txtReporte.Text & vbCrLf & "RECOMENDACIONES:" & vbCrLf & _ds.Tables(0).Rows(0)(33).ToString & vbCrLf
            End If
#End Region
        ElseIf Estudio = "ORTODONCIA" Then
#Region "ORTODONCIA"
            'DATOS ENDOSCOPIA
            _ds = New DataSet
            _ds = _dImpresionOrtodoncia.VistaPreviaOrtodoncia(IdDetalleOrden)
            lblID.Text = _ds.Tables(0).Rows(0)(0).ToString
            lblUsuario.Text = _ds.Tables(0).Rows(0)(1).ToString
            lblIdentificacion.Text = _ds.Tables(0).Rows(0)(2).ToString
            lblSexo.Text = _ds.Tables(0).Rows(0)(3).ToString
            lblEdad.Text = _ds.Tables(0).Rows(0)(4).ToString
            lblTelefono.Text = _ds.Tables(0).Rows(0)(5).ToString
            lblDireccion.Text = _ds.Tables(0).Rows(0)(6).ToString

            lblOrden.Text = _ds.Tables(0).Rows(0)(7).ToString
            lblFecha.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 1, 10)
            lblContrato.Text = _ds.Tables(0).Rows(0)(9).ToString

            lblEspecialista.Text = _ds.Tables(0).Rows(0)(10).ToString
            lblEspecialidad.Text = _ds.Tables(0).Rows(0)(11).ToString
            lblHora.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 11, 13)
            lblConsulta.Text = _ds.Tables(0).Rows(0)(12).ToString
            lblHistoria.Text = _ds.Tables(0).Rows(0)(2).ToString

            If _ds.Tables(0).Rows(0)(16).ToString <> "" Then
                'consulta de Primera vez
                txtReporte.Text = txtReporte.Text & vbCrLf & "MOTIVO DE CONSULTA: " & _ds.Tables(0).Rows(0)(16).ToString & vbCrLf
                If _ds.Tables(0).Rows(0)(17).ToString <> "" Then 'Indicacion
                    txtReporte.Text = txtReporte.Text & vbCrLf & "RESPONSABLES: " & _ds.Tables(0).Rows(0)(17).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(18).ToString <> "" Then 'Indicacion
                    txtReporte.Text = txtReporte.Text & vbCrLf & "ANTECEDENTES PATOLOGICOS: " & _ds.Tables(0).Rows(0)(18).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(19).ToString <> "" Then 'Indicacion
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PERFIL: " & _ds.Tables(0).Rows(0)(19).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "FRENTE: " & _ds.Tables(0).Rows(0)(20).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "HIPOTONIA: " & _ds.Tables(0).Rows(0)(21).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "HIPERTONIA: " & _ds.Tables(0).Rows(0)(22).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "MACROQUELIA: " & _ds.Tables(0).Rows(0)(23).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "MICROQUELIA: " & _ds.Tables(0).Rows(0)(24).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PROQUELIA: " & _ds.Tables(0).Rows(0)(25).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "RETROQUELIA: " & _ds.Tables(0).Rows(0)(26).ToString & vbCrLf
                    txtReporte.Text = txtReporte.Text & vbCrLf & "FRENILLO LABIAL SUPERIOR: " & _ds.Tables(0).Rows(0)(27).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "FRENILLO LABIAL INFERIOR: " & _ds.Tables(0).Rows(0)(28).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "FRENILLO LINGUAL: " & _ds.Tables(0).Rows(0)(29).ToString & vbCrLf
                    txtReporte.Text = txtReporte.Text & vbCrLf & "RESPIRACION BUCAL: " & _ds.Tables(0).Rows(0)(30).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "USO CHUPO: " & _ds.Tables(0).Rows(0)(31).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "BRUXOMANIA: " & _ds.Tables(0).Rows(0)(32).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "SUCCION DIGITAL: " & _ds.Tables(0).Rows(0)(33).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "SUCCION LABIAL: " & _ds.Tables(0).Rows(0)(34).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "DEGLUCION INFANTIL: " & _ds.Tables(0).Rows(0)(35).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "ONICOFAGIA: " & _ds.Tables(0).Rows(0)(36).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "EMPUJE LINGUAL: " & _ds.Tables(0).Rows(0)(37).ToString & vbTab
                    txtReporte.Text = txtReporte.Text & vbCrLf & "MORDER OBJETO: " & _ds.Tables(0).Rows(0)(38).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(39).ToString <> "" Then 'EVALUACION HABITO
                    txtReporte.Text = txtReporte.Text & vbCrLf & "EVALUACION HABITO: " & _ds.Tables(0).Rows(0)(39).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(40).ToString <> "" Then 'FONACION
                    txtReporte.Text = txtReporte.Text & vbCrLf & "FONACION: " & _ds.Tables(0).Rows(0)(40).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(41).ToString <> "" Then 'INTERPRETACION CEFALOMETRICA
                    txtReporte.Text = txtReporte.Text & vbCrLf & "INTERPRETACION CEFALOMETRICA: " & _ds.Tables(0).Rows(0)(41).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(42).ToString <> "" Then 'DIAGNOSTICO
                    txtReporte.Text = txtReporte.Text & vbCrLf & "DIAGNOSTICO: " & _ds.Tables(0).Rows(0)(42).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(43).ToString <> "" Then 'PRONOSTICO
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PRONOSTICO: " & _ds.Tables(0).Rows(0)(43).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(44).ToString <> "" Then 'PLAN DE TRATAMIENTO
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PLAN DE TRATAMIENTO: " & _ds.Tables(0).Rows(0)(44).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(45).ToString <> "" Then 'APARATOLOGIA
                    txtReporte.Text = txtReporte.Text & vbCrLf & "APARATOLOGIA: " & _ds.Tables(0).Rows(0)(45).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(46).ToString <> "" Then 'PRESUPUESTO
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PRESUPUESTO: " & _ds.Tables(0).Rows(0)(46).ToString & vbTab
                End If
            Else
                If _ds.Tables(0).Rows(0)(47).ToString <> "" Then 'ACTIVIDAD REALIZADA
                    txtReporte.Text = txtReporte.Text & vbCrLf & "ACTIVIDAD REALIZADA: " & _ds.Tables(0).Rows(0)(47).ToString & vbTab
                End If
                If _ds.Tables(0).Rows(0)(48).ToString <> "" Then 'PROXIMA CITA
                    txtReporte.Text = txtReporte.Text & vbCrLf & "PROXIMA CITA: " & _ds.Tables(0).Rows(0)(48).ToString & vbTab
                End If
            End If

            If _ds.Tables(0).Rows(0)(49).ToString <> "" Then 'DIAGNOSTICO
                txtReporte.Text = txtReporte.Text & vbCrLf & "DIAGNOSTICO: " & _ds.Tables(0).Rows(0)(49).ToString & vbTab
            End If

#End Region
        ElseIf Estudio = "BIOPSIA" Or Estudio = "BIOPSIA POR CONGELACION" Or Estudio = "BACAF" Or Estudio = "RECEPTORES HORMONALES" Or Estudio = "INMUNOHISTOQUIMICA" Then
#Region "PATOLOGIA"
            'DATOS PATOLOGIA
            _ds = New DataSet
            _ds = _DImpresionCitoPato.VistaPreviaPatologia(IdOrden)
            lblID.Text = _ds.Tables(0).Rows(0)(0).ToString
            lblUsuario.Text = _ds.Tables(0).Rows(0)(1).ToString
            lblIdentificacion.Text = _ds.Tables(0).Rows(0)(2).ToString
            lblSexo.Text = _ds.Tables(0).Rows(0)(3).ToString
            lblEdad.Text = _ds.Tables(0).Rows(0)(4).ToString
            lblTelefono.Text = _ds.Tables(0).Rows(0)(5).ToString
            lblDireccion.Text = _ds.Tables(0).Rows(0)(6).ToString
            lblOrden.Text = _ds.Tables(0).Rows(0)(7).ToString
            lblHistoria.Text = _ds.Tables(0).Rows(0)(8).ToString
            lblContrato.Text = _ds.Tables(0).Rows(0)(9).ToString
            lblEspecialista.Text = _ds.Tables(0).Rows(0)(10).ToString
            lblEspecialidad.Text = _ds.Tables(0).Rows(0)(11).ToString
            lblFecha.Text = Mid(_ds.Tables(0).Rows(0)(12).ToString, 1, 10)

            txtReporte.Text = "TIPO DE MUESTRA: " & _ds.Tables(0).Rows(0)(13).ToString & vbCrLf
            txtReporte.Text = txtReporte.Text & vbCrLf & "SITIO LESIÓN: " & _ds.Tables(0).Rows(0)(14).ToString & vbCrLf
            txtReporte.Text = txtReporte.Text & vbCrLf & "SOLICITADO: " & _ds.Tables(0).Rows(0)(15).ToString & vbCrLf
            txtReporte.Text = txtReporte.Text & vbCrLf & "DESCRIPCION MACROSCOPICA: " & _ds.Tables(0).Rows(0)(16).ToString & vbCrLf
            txtReporte.Text = txtReporte.Text & vbCrLf & "DESCRIPCION MICROSCOPICA: " & _ds.Tables(0).Rows(0)(17).ToString & vbCrLf
            txtReporte.Text = txtReporte.Text & vbCrLf & "DIAGNOSTICO: " & _ds.Tables(0).Rows(0)(18).ToString & vbCrLf

            If _ds.Tables(0).Rows(0)(19).ToString <> "" Then 'OBSERVACIONES
                txtReporte.Text = txtReporte.Text & vbCrLf & "OBSERVACIONES: " & _ds.Tables(0).Rows(0)(19).ToString & vbCrLf
            End If
#End Region
        Else
            'DATOS ENDOSCOPIA
            _ds = New DataSet
            _ds = _dImpresionEndoscopia.VistaPreviaEndoscopia(IdDetalleOrden)

            lblID.Text = _ds.Tables(0).Rows(0)(0).ToString
            lblUsuario.Text = _ds.Tables(0).Rows(0)(1).ToString
            lblIdentificacion.Text = _ds.Tables(0).Rows(0)(2).ToString
            lblSexo.Text = _ds.Tables(0).Rows(0)(3).ToString
            lblEdad.Text = _ds.Tables(0).Rows(0)(4).ToString
            lblTelefono.Text = _ds.Tables(0).Rows(0)(5).ToString
            lblDireccion.Text = _ds.Tables(0).Rows(0)(6).ToString

            lblOrden.Text = _ds.Tables(0).Rows(0)(7).ToString
            lblFecha.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 1, 10)
            'MsgBox(_ds.Tables(0).Rows(0)(8).ToString)
            lblContrato.Text = _ds.Tables(0).Rows(0)(9).ToString

            lblEspecialista.Text = _ds.Tables(0).Rows(0)(10).ToString
            lblEspecialidad.Text = _ds.Tables(0).Rows(0)(11).ToString
            lblHora.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 11, 13)
            lblConsulta.Text = _ds.Tables(0).Rows(0)(12).ToString
            lblHistoria.Text = "" '_ds.Tables(0).Rows(0)(13).ToString

            If _ds.Tables(0).Rows(0)(14).ToString <> "" Then 'Indicacion
                txtReporte.Text = txtReporte.Text & vbCrLf & "INDICACION: " & _ds.Tables(0).Rows(0)(14).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(15).ToString <> "" Then 'Medicamentos
                txtReporte.Text = txtReporte.Text & vbCrLf & "MEDICAMENTOS: " & _ds.Tables(0).Rows(0)(15).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(16).ToString <> "" Then 'Equipos
                txtReporte.Text = txtReporte.Text & vbCrLf & "EQUIPO: " & _ds.Tables(0).Rows(0)(16).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(17).ToString <> "" Then 'Anestesiologo
                txtReporte.Text = txtReporte.Text & vbCrLf & "ANESTESIOLOGO: " & _ds.Tables(0).Rows(0)(17).ToString & vbCrLf
            End If

            If _ds.Tables(0).Rows(0)(18).ToString <> "" Then 'Procedimientos Terapeuticos
                txtReporte.Text = txtReporte.Text & vbCrLf & "PROCEDIMIENTO TERAPEUTICO: " & _ds.Tables(0).Rows(0)(18).ToString & vbCrLf
            End If

            If Licencia = "3" Then 'DITEG
                If _ds.Tables(0).Rows(0)(19).ToString <> "" Then 'campo1
                    txtReporte.Text = txtReporte.Text & vbCrLf & "DESCRIPCION DE HALLAZGOS:" & vbCrLf & _ds.Tables(0).Rows(0)(19).ToString & vbCrLf
                End If
            ElseIf Licencia = "4" Then 'DITEG GASTROLAP
                'Campos Completos DITEG Gastrolap
                If _ds.Tables(0).Rows(0)(19).ToString <> "" Then 'campo1
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO1:" & vbCrLf & _ds.Tables(0).Rows(0)(19).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(20).ToString <> "" Then 'campo2
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO2:" & vbCrLf & _ds.Tables(0).Rows(0)(20).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(21).ToString <> "" Then 'campo3
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO3:" & vbCrLf & _ds.Tables(0).Rows(0)(21).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(22).ToString <> "" Then 'campo4
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO4:" & vbCrLf & _ds.Tables(0).Rows(0)(22).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(23).ToString <> "" Then 'campo5
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO5:" & vbCrLf & _ds.Tables(0).Rows(0)(23).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(24).ToString <> "" Then 'campo6
                    txtReporte.Text = txtReporte.Text & vbCrLf & "CAMPO6:" & vbCrLf & _ds.Tables(0).Rows(0)(24).ToString & vbCrLf
                End If
                If _ds.Tables(0).Rows(0)(25).ToString <> "" Then 'Diagnostico
                    txtReporte.Text = txtReporte.Text & vbCrLf & "DIAGNOSTICO:" & vbCrLf & _ds.Tables(0).Rows(0)(25).ToString & vbCrLf
                End If
            End If
            CargarImagenes(IdDetalleOrden)
        End If
    End Sub

    Private Sub frmVistaHistoria_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        MsgBox("Ayuda")
    End Sub

    Private Sub gcImagenes_DoubleClick(sender As Object, e As EventArgs) Handles gcImagenes.DoubleClick
        Dim _frmOpen As New SIM___GLOBAL.frmVisorImagenes
        _frmOpen.IdDetalleOrden = IdDetalleOrden
        _frmOpen.ShowDialog()
    End Sub
End Class
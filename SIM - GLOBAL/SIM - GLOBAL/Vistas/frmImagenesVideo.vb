
'Imports Accord.Video
'Imports Accord.Video.DirectShow
Imports Accord.Video.FFMPEG
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Imports System.IO

Public Class frmImagenesVideo
    '   Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    '  Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    Dim ESCRITOR As New VideoFileWriter() 'GUARDA LAS IMAGENES EN MEMORIA

    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    'Dim _Endoscopia As New SIM_ENDOSCOPIA.Modelo.Endoscopia
    'Dim _DEndoscopia As New SIM_ENDOSCOPIA.Controles.DEndoscopia
    Dim _Imagenes As New SIM___GLOBAL.Modelo.Imagenes
    Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenes
    Dim _ImagenesTemporales As New SIM___GLOBAL.Modelo.ImagenesTemporales
    Dim _DimagenesTemporales As New SIM___GLOBAL.Controles.DImagenesTemporales
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickEstudio As String
    Dim _Fila As String
    Dim _NombreImagen As Integer = 1
    Dim _dtImagenes As DataTable
    Dim _IDUsuario As String
    Dim _NombreVideo As String
    Dim _Archivo As String

    Dim I As Long
    Dim Tiempo As String

    ' Control de la grabación de video (evita el NullReferenceException repetido en Timer1_Tick
    ' cuando el capturador pierde la señal: TakeSnapshot devuelve Nothing).
    Dim _Grabando As Boolean = False
    Dim _EscribiendoCuadro As Boolean = False
    Dim _CronometroGrabacion As New Stopwatch()


    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
#Region "PROCEDIMIENTOS"
    Private Sub IniciarVideo()
        'Dim CAMARAS As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        'CAMARA = New VideoCaptureDevice(CAMARAS(0).MonikerString) '0 SI ES LA PRIMERA CAMARA,1 LA SEGUNDA,2 LA TERCERA Y ASI SUCESIVAMENTE. EN MI CASO ES 2(TERCERA CAMARA)
        'AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
        'CAMARA.VideoResolution = CAMARA.VideoCapabilities(0) 'TAMAÑO DE IMAGENES 0 PARA LA PRIMERA RESOLUCION,1 PARA LA SEGUNDA Y ASI SUCESIVAMENTE.
        'CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX
        bbiDetener.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbiTimer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub



    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesImagenesEndoscopia()
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Nuevo()
        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickGrilla
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        lcCups.Text = _ClickEstudio
        _NombreVideo = _Archivo
        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        '******* Traemos la Orden ******************
        _Ordenes = _dOrdenes.Cargar(_ClickGrilla)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        '********* ACTIVAMOS GUARDAR ************
        'CargarImagenes(_ClickIdDetalleOrden)
        bbiGuardar.Enabled = True
        bbiGrabar.Enabled = True
        bbiTimer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbiTimer.Caption = ""
        Tiempo = 0
        I = 0
    End Sub
    Private Sub LimpiarCampos()
        '***************** ELIMINAMOS IMAGENES TEMPORALES **************
        _DimagenesTemporales.Eliminar(lblIdDetalleOrden.Text)
        'Limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        lblIdDetalleOrden.Text = ""

        lcCups.Text = ""

        _Capturas.Items.Clear()
        gcCapturas.Gallery.Groups.Clear()
        _NombreImagen = 1
    End Sub

#End Region
    Private Sub frmImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        _DimagenesTemporales.LimpiarTabla()

        _Capturas.Caption = "Imagenes Capturadas"
        IniciarVideo()
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _Archivo = _ClickGrilla & "-" & GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "NOMBRE").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha Seleccionado el paciente para Capturar las imagenes", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickIdDetalleOrden = lblIdDetalleOrden.Text Then
            MessageBox.Show("El Paciente ya se encuentra Seleccionado", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If gcCapturas.Gallery.Groups.Count <> 0 Then
                If MessageBox.Show("Actualmente se esta realizando un Esudio, ¿Desea Finalizarlo y Realizar uno Nuevo?", "Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    LimpiarCampos()
                    Nuevo()
                End If
            Else
                LimpiarCampos()
                Nuevo()
            End If

        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVPacientesAtender.OptionsFind.AlwaysVisible = True Then
            GVPacientesAtender.OptionsFind.AlwaysVisible = False
        Else
            GVPacientesAtender.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If _NombreImagen = 50 Then
            MessageBox.Show("Excedio el numero de captura de imagenes (50)", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' 1. Primero se toma la foto: si no hay señal de la cámara no se guarda nada
            '    (antes se insertaba el registro en BD y luego fallaba la foto, dejando un
            '    registro apuntando a un .jpg inexistente).
            Dim captura As Image = TomarCuadro()
            If captura Is Nothing Then
                MessageBox.Show("No hay señal de la cámara, la imagen no se capturó." & vbCrLf & vbCrLf &
                                "Verifique que el capturador de video esté conectado y encendido.",
                                "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                ' Configuramos Ruta de almacenamiento de Imagenes
                If Directory.Exists("c:\estudios\" & lblConsecutivoOrden.Text) = False Then
                    Directory.CreateDirectory("c:\estudios\" & lblConsecutivoOrden.Text)
                End If
                _Imagenes.IdOrden = lblConsecutivoOrden.Text
                _Imagenes.IdDetalleOrden = lblIdDetalleOrden.Text

                '2. GUARDAMOS LA IMAGEN EN FISICO
                peImagen.EditValue = captura
                captura.Save("c:\estudios\" & _Imagenes.IdOrden & "\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg")

                '3. Solo si el archivo quedó guardado, registramos el detalle de la imagen en BD
                _Imagenes.Ruta = "c:\\estudios\\" & _Imagenes.IdOrden & "\\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"
                _Imagenes.Texto = "Imagen" & _NombreImagen
                _Imagenes.Estado = "I"
                _dImagenes.Guardar(_Imagenes)

                'CargarImagenes(lblIdDetalleOrden.Text)
                'LLENAMOS GALERY CONTROL
                '--------------------------------------------------------------------------------------------
                _Capturas.Items.Add(New GalleryItem(Image.FromFile("c:\estudios\" & _Imagenes.IdOrden & "\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"), _Imagenes.IdDetalleOrden & _NombreImagen, ""))

                gcCapturas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
                gcCapturas.Gallery.ImageSize = New Size(120, 90)
                gcCapturas.Gallery.Groups.Add(_Capturas)

                _NombreImagen = _NombreImagen + 1
                '-----------------------------------------------------------------------------------------------
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar la imagen. Por favor verifique la carpeta c:\estudios y la conexión a la base de datos." & vbCrLf & vbCrLf & ex.Message,
                                "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub gcCapturas_DoubleClick(sender As Object, e As EventArgs) Handles gcCapturas.DoubleClick
        'Dim _frmOpen As New SIM___GLOBAL.frmVisorImagenes
        '_frmOpen.IdDetalleOrden = lblIdDetalleOrden.Text
        '_frmOpen.ShowDialog()
    End Sub



    Private Sub frmImagenesVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' CAMARA.Stop() 'CIERRA LA CAMARA
        DetenerGrabacion() 'DEJA DE GUARDAR DATOS.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

#Region "GRABACION DE VIDEO"
    ''' <summary>
    ''' Toma un cuadro de la cámara. Devuelve Nothing si no hay señal (capturador
    ''' desconectado, "No encontró ninguna webcam") o si el control falla.
    ''' </summary>
    Private Function TomarCuadro() As Image
        Try
            Return ccCamara.TakeSnapshot()
        Catch
            Return Nothing
        End Try
    End Function

    Private Function HaySenalCamara() As Boolean
        Dim cuadro As Image = TomarCuadro()
        If cuadro Is Nothing Then Return False
        cuadro.Dispose()
        Return True
    End Function

    ''' <summary>
    ''' Detiene la grabación de forma ordenada: apaga el timer, cierra el archivo de video
    ''' (queda guardado lo grabado hasta ese momento) y restaura los botones.
    ''' Se puede llamar varias veces sin error.
    ''' </summary>
    Private Sub DetenerGrabacion()
        Timer1.Enabled = False
        _CronometroGrabacion.Stop()
        Try
            If ESCRITOR.IsOpen Then ESCRITOR.Close()
        Catch
        End Try
        _Grabando = False
        Try
            bbiGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            bbiDetener.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            bbiNuevo.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub bbiGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        If _Grabando Then Exit Sub

        ' Verificamos que haya señal de la cámara antes de iniciar
        If Not HaySenalCamara() Then
            MessageBox.Show("No hay señal de la cámara, no se puede iniciar la grabación." & vbCrLf & vbCrLf &
                            "Verifique que el capturador de video esté conectado y encendido.",
                            "Grabar Video", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If Directory.Exists("c:\videos") = False Then
                Directory.CreateDirectory("c:\videos")
            End If
            ESCRITOR.Open("c:\videos\" & _NombreVideo & ".avi", 640, 480, 30, VideoCodec.Default, 300 * 1000)
            'ESCRITOR.Open("d:\videos\prueba.avi", 640, 480, 30, VideoCodec.Default, 300 * 1000)
        Catch ex As Exception
            MessageBox.Show("No se pudo crear el archivo de video. Verificar Carpeta Videos." & vbCrLf & vbCrLf & ex.Message,
                            "Grabar Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        'desactivamos botones para iniciar grabacion
        bbiGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbiDetener.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        bbiTimer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        bbiNuevo.Enabled = False

        'Iniciamos grabacion del video
        I = 0
        bbiTimer.Caption = "00:00:00"
        _CronometroGrabacion.Restart()
        _Grabando = True
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not _Grabando OrElse _EscribiendoCuadro Then Exit Sub
        _EscribiendoCuadro = True
        Try
            Dim cuadro As Image = TomarCuadro()
            If cuadro Is Nothing Then
                ' Se perdió la señal del capturador: antes esto lanzaba NullReferenceException
                ' cada 30 ms (WriteVideoFrame(Nothing)). Ahora se detiene y se avisa una sola vez.
                DetenerGrabacion()
                MessageBox.Show("Se perdió la señal de la cámara y la grabación se detuvo." & vbCrLf &
                                "El video quedó guardado hasta este punto (" & bbiTimer.Caption & ")." & vbCrLf & vbCrLf &
                                "Verifique la conexión del capturador de video.",
                                "Grabar Video", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                ESCRITOR.WriteVideoFrame(CType(cuadro, Bitmap))
            Finally
                cuadro.Dispose() ' cada cuadro se libera: evita que la memoria crezca en grabaciones largas
            End Try

            I = I + 1
            Dim t As TimeSpan = _CronometroGrabacion.Elapsed
            Tiempo = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(t.TotalHours), t.Minutes, t.Seconds)
            bbiTimer.Caption = Tiempo
        Catch ex As Exception
            DetenerGrabacion()
            MessageBox.Show("Ocurrió un error grabando el video y la grabación se detuvo." & vbCrLf &
                            "El video quedó guardado hasta este punto." & vbCrLf & vbCrLf & ex.Message,
                            "Grabar Video", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            _EscribiendoCuadro = False
        End Try
    End Sub

    Private Sub bbiDetener_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetener.ItemClick
        DetenerGrabacion()
        bbiGrabar.Enabled = False
    End Sub
#End Region

End Class
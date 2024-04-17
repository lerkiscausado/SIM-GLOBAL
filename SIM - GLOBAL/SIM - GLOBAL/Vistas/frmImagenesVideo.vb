
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
            Try
                ' Configuramos Ruta de almacenamiento de Imagenes
                If Directory.Exists("c:\estudios\" & lblConsecutivoOrden.Text) = False Then
                    Directory.CreateDirectory("c:\estudios\" & lblConsecutivoOrden.Text)
                End If
                'Guardamos detalle Imagen en DB
                _Imagenes.IdOrden = lblConsecutivoOrden.Text
                _Imagenes.IdDetalleOrden = lblIdDetalleOrden.Text
                _Imagenes.Ruta = "c:\\estudios\\" & _Imagenes.IdOrden & "\\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"
                _Imagenes.Texto = "Imagen" & _NombreImagen
                _Imagenes.Estado = "I"
                _dImagenes.Guardar(_Imagenes)


                'GUARDAMOS LA IMAGEN EN FISICO
                peImagen.EditValue = ccCamara.TakeSnapshot
                peImagen.Image.Save("c:\estudios\" & _Imagenes.IdOrden & "\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg")

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
                MessageBox.Show("Por favor verifique la conexión de la unidad de red", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        Try
            ' CAMARA.Stop() 'CIERRA LA CAMARA
            ESCRITOR.Close() 'DEJA DE GUARDAR DATOS.
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bbiGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        Try
            'desactivamos botones para iniciar grabacion
            bbiGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            bbiDetener.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            bbiTimer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            bbiNuevo.Enabled = False
            ESCRITOR.Open("c:\videos\" & _NombreVideo & ".avi", 640, 480, 30, VideoCodec.Default, 300 * 1000)
            'ESCRITOR.Open("d:\videos\prueba.avi", 640, 480, 30, VideoCodec.Default, 300 * 1000)
            Timer1.Enabled = True
            'Iniciamos gravacion del video
            'Dim ANCHO As Integer = CAMARA.VideoResolution.FrameSize.Width 'DEFINE EL ANCHO DEL FOTOGRAMA
            'Dim ALTO As Integer = CAMARA.VideoResolution.FrameSize.Height ' DEFINE EL ALTO DEL FOTOGRAMA
            'CREA EL ARCHIVO PARA LOS DATOS CON LOS PARAMETROS DE GUARDADO

            'ESCRITOR.WriteVideoFrame(BMP) 'EMPIEZA A GUARDAR DATOS

        Catch ex As Exception
            MessageBox.Show("Verificar Carpeta Videos", "Grabar Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ESCRITOR.WriteVideoFrame(ccCamara.TakeSnapshot)
        I = I + 1
        Tiempo = Format(Int(I / 1800) Mod 60, "00") & ":" &
                 Format(Int(I / 30) Mod 60, "00") & ":" &
                 Format(I Mod 10, "00")
        bbiTimer.Caption = Tiempo

    End Sub

    Private Sub bbiDetener_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetener.ItemClick
        Timer1.Enabled = False
        ESCRITOR.Close()
        'desactivamos botones para iniciar grabacion
        bbiGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        bbiDetener.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbiNuevo.Enabled = True
        bbiGrabar.Enabled = False
    End Sub


End Class
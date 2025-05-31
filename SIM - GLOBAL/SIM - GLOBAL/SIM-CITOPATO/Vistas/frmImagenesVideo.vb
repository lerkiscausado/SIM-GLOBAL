

Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Accord.Video.FFMPEG
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Public Class frmImagenesVideo
    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
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

    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()
#Region "PROCEDIMIENTOS"
    Private Sub CapturarPrueba()
        Dim CAMARAS As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        CAMARA = New VideoCaptureDevice(CAMARAS(0).MonikerString) '0 SI ES LA PRIMERA CAMARA,1 LA SEGUNDA,2 LA TERCERA Y ASI SUCESIVAMENTE. EN MI CASO ES 2(TERCERA CAMARA)
        AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
        CAMARA.VideoResolution = CAMARA.VideoCapabilities(1) 'TAMAÑO DE IMAGENES 0 PARA LA PRIMERA RESOLUCION,1 PARA LA SEGUNDA Y ASI SUCESIVAMENTE.
        CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX

    End Sub
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        If Button1.Text = "Grabar" Then 'SI NO ESTA GRABANDO ......
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PONE LOS DATOS EN EL BITMAP
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
            'ccCamara.DrawToBitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
        Else ' SI ESTAS GRABANDO...
            Try
                BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PON LOS DATOS EN EL BITMAP
                PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
                ESCRITOR.WriteVideoFrame(BMP) 'LOS GUARDA EN LA MEMORIA
            Catch ex As Exception
            End Try
        End If
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
        txtEstudio.Text = _ClickEstudio

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
    End Sub
    Private Sub LimpiarCampos()
        '***************** ELIMINAMOS IMAGENES TEMPORALES **************
        _DimagenesTemporales.Eliminar(lblIdDetalleOrden.Text)
        'Limpiamos campos
        lblConsecutivo.Text = ""
        lblConsecutivoOrden.Text = ""
        lblIdDetalleOrden.Text = ""

        txtEstudio.Text = ""

        _Capturas.Items.Clear()
        gcCapturas.Gallery.Groups.Clear()

        '************ actualizamos la grilla de imagenes
        '_ds = New DataSet
        '_ds = _DimagenesTemporales.Listar(lblIdDetalleOrden.Text)
        'gcImagenes.DataSource = _ds.Tables(0)

        _NombreImagen = 1
    End Sub

#End Region
    Private Sub frmImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapturarPrueba()

        AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
        CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX

        ActualizarGrilla()
        _DimagenesTemporales.LimpiarTabla()
        'peImagen.Image = Image.FromFile("prueba.jpg")
        '_dtImagenes.Columns.Add("RUTA", GetType(Byte()))
        '_dtImagenes.Rows.Add(imgtoarr("prueba.jpg"))
        'gcImagenes.DataSource = _dtImagenes
        'ccCamara.Capture
        _Capturas.Caption = "Imagenes Capturadas"
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
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
                'Guardamos detalle Imagen en DB
                _Imagenes.IdOrden = lblConsecutivoOrden.Text
                _Imagenes.IdDetalleOrden = lblIdDetalleOrden.Text
                _Imagenes.Ruta = "x:\\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"
                _Imagenes.Texto = "Imagen" & _NombreImagen
                _Imagenes.Estado = "I"
                _dImagenes.Guardar(_Imagenes)


                'GUARDAMOS LA IMAGEN EN FISICO
                'peImagen.EditValue = ccCamara.TakeSnapshot
                peImagen.Image.Save("x:\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg")

                'CargarImagenes(lblIdDetalleOrden.Text)
                'LLENAMOS GALERY CONTROL
                '--------------------------------------------------------------------------------------------
                _Capturas.Items.Add(New GalleryItem(Image.FromFile("x:\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"), _Imagenes.IdDetalleOrden & _NombreImagen, ""))

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
        Dim _frmOpen As New SIM___GLOBAL.frmVisorImagenes
        _frmOpen.IdDetalleOrden = lblIdDetalleOrden.Text
        _frmOpen.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Grabar" Then 'NO ESTA GRABANDO VIDEO
            ' SaveFileDialog1.DefaultExt = ".avi" ' GUARDARA COMO ARCHIVO AVI
            ' If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim ANCHO As Integer = CAMARA.VideoResolution.FrameSize.Width 'DEFINE EL ANCHO DEL FOTOGRAMA
                Dim ALTO As Integer = CAMARA.VideoResolution.FrameSize.Height ' DEFINE EL ALTO DEL FOTOGRAMA
            'CREA EL ARCHIVO PARA LOS DATOS CON LOS PARAMETROS DE GUARDADO
            ESCRITOR.Open("d:\estudios\prueba.avi", ANCHO, ALTO, 30, VideoCodec.Default, 300 * 1000)
            ESCRITOR.WriteVideoFrame(BMP) 'EMPIEZA A GUARDAR DATOS
            'ButtonVIDEO.BackColor = Color.Red 'PARA QUE SEPAMOS QUE ESTA GRABANDO
            Button1.Text = "Grabando"
            'End If
        Else
            'ButtonVIDEO.BackColor = Color.Black ' ESTA GRABANDO
            Button1.Text = "Grabar"
            ESCRITOR.Close() 'DEJA DE GUARDAR DATOS
        End If
    End Sub

    Private Sub frmImagenesVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            CAMARA.Stop() 'CIERRA LA CAMARA
            ESCRITOR.Close() 'DEJA DE GUARDAR DATOS.
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
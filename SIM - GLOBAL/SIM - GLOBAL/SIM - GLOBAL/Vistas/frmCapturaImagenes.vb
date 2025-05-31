Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Public Class frmCapturaImagenes
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _Imagenes As New SIM___GLOBAL.Modelo.Imagenes
    Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenes

    Dim _ds As DataSet
    Dim _ClickOrden As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickEstudio As String
    Dim _IDUsuario As String
    Dim _Fila As String
    Dim _NombreImagen As Integer = 1

    Dim _Capturas As GalleryItemGroup = New GalleryItemGroup()

#Region "Procedimientos"
    Private Sub ActualizarGrilla()
        'LLENAMOS EL LISTADO DE PACIENTES POR ATENDER
        Dim _ds = New DataSet
        _ds = _dOrdenes.PacientesImagenesEndoscopia()
        GCPacientesAtender.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Nuevo()
        'Traemos datos del Paciente
        lblConsecutivoOrden.Text = _ClickOrden
        lblIdDetalleOrden.Text = _ClickIdDetalleOrden
        txtEstudio.Text = _ClickEstudio

        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(_IDUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        '******* Traemos la Orden ******************
        _Ordenes = _dOrdenes.Cargar(_ClickOrden)
        lblConsecutivo.Text = _Ordenes.IdUsuario
        '********* ACTIVAMOS GUARDAR ************

        CargarImagenes(lblConsecutivoOrden.Text)
        'Cargamos las imagenes que han sido capturadas al paciente

        bbiGuardar.Enabled = True
    End Sub
    Private Sub CargarImagenes(ByVal IdOrden As String)
        Dim _dImagenes As New SIM___GLOBAL.Controles.DImagenes
        '_NombreImagen = 0
        Try
            _Capturas.Items.Clear()
            gcCapturas.Gallery.Groups.Clear()
            _ds = New DataSet
            _ds = _dImagenes.ListarImagenesCapturadas2(IdOrden)
            If _ds.Tables(0).Rows.Count <> 0 Then
                'Tomamos la cantidad de imagenes de la Orden
                _NombreImagen = Val(_ds.Tables(0).Rows.Count)

                For x = 1 To _ds.Tables(0).Rows.Count
                    'LLENAMOS GALERY CONTROL
                    MsgBox(_ds.Tables(0).Rows(x - 1)(0).ToString, _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString)
                    _Capturas.Items.Add(New GalleryItem(Image.FromFile(_ds.Tables(0).Rows(x - 1)(0).ToString), _ds.Tables(0).Rows(x - 1)(1).ToString, _ds.Tables(0).Rows(x - 1)(2).ToString))
                Next

                gcCapturas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
                gcCapturas.Gallery.ImageSize = New Size(120, 90)
                gcCapturas.Gallery.Groups.Add(_Capturas)
                'Else
                '   _Imagenes = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub frmCapturaImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub GVPacientesAtender_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVPacientesAtender.RowClick
        If e.RowHandle >= 0 Then
            _ClickOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickIdDetalleOrden = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickEstudio = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            _IDUsuario = GVPacientesAtender.GetRowCellValue(e.RowHandle.ToString, "ID_USUARIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If _ClickOrden = "" Then
            MessageBox.Show("No ha Seleccionado el paciente para Capturar las imagenes", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickIdDetalleOrden = lblIdDetalleOrden.Text Then
            MessageBox.Show("El Paciente ya se encuentra Seleccionado", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If gcCapturas.Gallery.Groups.Count <> 0 Then
                If MessageBox.Show("Actualmente se esta realizando un Estudio, ¿Desea Finalizarlo y Realizar uno Nuevo?", "Estudio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    'LimpiarCampos()
                    Nuevo()
                End If
            Else
                'LimpiarCampos()
                Nuevo()
            End If

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
                _Imagenes.Ruta = "x:\\" & _Imagenes.IdDetalleOrden & "-" & Format(DateTime.Now, "ddMMyyyy") & Format(DateTime.Now, "hhmmss") & ".jpg"
                _Imagenes.Texto = "Imagen" & _NombreImagen
                _Imagenes.Estado = "I"
                _dImagenes.Guardar(_Imagenes)

                'MsgBox(_Imagenes.IdDetalleOrden & "-" & Format(DateTime.Now, "ddMMyyyy") & Format(DateTime.Now, "hhmmss"))

                'GUARDAMOS LA IMAGEN EN FISICO
                peImagen.EditValue = ccCamara.TakeSnapshot
                peImagen.Image.Save("x:\" & _Imagenes.IdDetalleOrden & "-" & Format(DateTime.Now, "ddMMyyyy") & Format(DateTime.Now, "hhmmss") & ".jpg")

                _NombreImagen = _NombreImagen + 1

                'Actualizamos vista de imagenes
                CargarImagenes(lblConsecutivoOrden.Text)

                'LLENAMOS GALERY CONTROL
                '--------------------------------------------------------------------------------------------
                '_Capturas.Items.Add(New GalleryItem(Image.FromFile("x:\" & _Imagenes.IdDetalleOrden & _NombreImagen & ".jpg"), _Imagenes.IdDetalleOrden & _NombreImagen, ""))

                'gcCapturas.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
                'gcCapturas.Gallery.ImageSize = New Size(120, 90)
                'gcCapturas.Gallery.Groups.Add(_Capturas)


                '-----------------------------------------------------------------------------------------------
            Catch ex As Exception
                MessageBox.Show("Por favor verifique la conexión de la unidad de red", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub gcCapturas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gcCapturas.KeyPress

        'MsgBox(Keys.Delete)
        'MsgBox(Asc(e.KeyChar))
    End Sub

    Private Sub gcCapturas_KeyDown(sender As Object, e As KeyEventArgs) Handles gcCapturas.KeyDown
        If e.KeyCode = Keys.Delete Then
            MsgBox("Presionaste Supr")
        End If
    End Sub
End Class
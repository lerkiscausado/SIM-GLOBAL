Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades

Public Class frmAdjuntos
    Dim _Adjuntos As New Adjuntos
    Dim _DAdjuntos = New DAdjuntos
    Dim _ClickGrilla As String
    Dim _Archivo As String
    Dim _Fila As Integer
    Public Orden As String

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If txtNombre.Text <> "" And PdfAdjuntos.IsDocumentOpened = True Then
            'GUARDAMOS PROCEDIMIENTOS A REALIZAR
            _Adjuntos.IdOrden = Registro
            _Adjuntos.Nombre = txtNombre.Text
            _DAdjuntos.Guardar(_Adjuntos)
            Dim _ds = New DataSet
            _ds = _DAdjuntos.Listar(Registro)
            GCConsultar.DataSource = _ds.Tables(0)

            'Guardamos el Archivo FISICO
            PdfAdjuntos.SaveDocument(path:="x:\pdf\" & txtNombre.Text & "-" & Registro & _DAdjuntos.UltimoRegistro & ".pdf")
            txtNombre.Text = ""
            PdfAdjuntos.CloseDocument()
        Else
            MessageBox.Show("El Campo Nombre es Obligatorio o no ha seleccionado el adjunto", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub GVConsultar_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Archivo = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "RUTA").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub


    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GVConsultar.DoubleClick
        If PdfAdjuntos.IsDocumentOpened = True Then
            PdfAdjuntos.CloseDocument()
        Else

            PdfAdjuntos.LoadDocument(path:="x:\pdf\" & GVConsultar.GetFocusedRowCellValue("RUTA") & ".pdf")
        End If
    End Sub

    Private Sub frmAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Orden <> "" Then
            Dim _ds = New DataSet
            _ds = _DAdjuntos.Listar(Orden)
            GCConsultar.DataSource = _ds.Tables(0)
            Me.Text = "Datos Adjuntos - ORDEN No.:" & Orden
            txtDatosUsuario.Text = Funciones.DatosUsuario(Orden, "HISTORIA")
        Else
            MessageBox.Show("Debe seleccionar una Orden", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Try
            If _ClickGrilla <> "" And PdfAdjuntos.IsDocumentOpened = True Then
                If MessageBox.Show("¿Desea Eliminar el archivo adjunto?", "Datos Adjuntos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    _DAdjuntos.Eliminar(_ClickGrilla)
                    Dim _ds = New DataSet
                    _ds = _DAdjuntos.Listar(Registro)
                    GCConsultar.DataSource = _ds.Tables(0)
                    _ClickGrilla = ""
                    PdfAdjuntos.CloseDocument()

                End If
            Else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bbtAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If PdfAdjuntos.IsDocumentOpened = True Then
            PdfAdjuntos.CloseDocument()
        End If
        _Adjuntos = DAdjuntos.Cargar(_ClickGrilla)
        PdfAdjuntos.LoadDocument(path:="f:\pdf\" & _Adjuntos.Nombre & "-" & _Adjuntos.IdOrden & _Adjuntos.ID & ".pdf")

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text <> "" And PdfAdjuntos.IsDocumentOpened = True Then
            'GUARDAMOS PROCEDIMIENTOS A REALIZAR
            '_Adjuntos.IdOrden = Orden
            '_Adjuntos.Ruta = Orden & (GVConsultar.RowCount + 1) & ".pdf"
            '_Adjuntos.Nombre = txtNombre.Text

            '_DAdjuntos.Guardar(_Adjuntos)
            'Guardamos el Archivo FISICO
            PdfAdjuntos.SaveDocument(path:="C:\SIM\Dropbox\resultados\" & _Adjuntos.Ruta & ".pdf")
            'pePDF.Image = PdfAdjuntos.CreateBitmap(PdfAdjuntos.PageCount, PdfAdjuntos.ImageCacheSize)
            'txtNombre.Text = ""
            'PdfAdjuntos.CloseDocument()
            ' Actualizamos la grilla
            'Dim _ds = New DataSet
            '_ds = _DAdjuntos.Listar(Orden)
            'GCConsultar.DataSource = _ds.Tables(0)

        Else
            MessageBox.Show("El Campo Nombre es Obligatorio o no ha seleccionado el adjunto", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Try
            If _ClickGrilla <> "" And PdfAdjuntos.IsDocumentOpened = True Then
                If MessageBox.Show("¿Desea Eliminar el archivo adjunto?", "Datos Adjuntos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    _DAdjuntos.Eliminar(_ClickGrilla)
                    Dim _ds = New DataSet
                    _ds = _DAdjuntos.Listar(Registro)
                    GCConsultar.DataSource = _ds.Tables(0)
                    GVConsultar.Columns(0).BestFit()
                    GVConsultar.Columns(1).BestFit()
                    _ClickGrilla = ""
                    PdfAdjuntos.CloseDocument()

                End If
            Else
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PdfAdjuntos.SaveDocument(path:="C:\SIM\Dropbox\resultados\" & txtNombre.Text & ".pdf")
    End Sub
End Class
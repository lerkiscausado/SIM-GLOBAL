Imports SIM___GLOBAL.Utilidades
Public Class frmConsultar
    ReadOnly _funciones As New Funciones
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes

    Dim _dImpresionHistoria = New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria

    Dim _dImpresionEndoscopia = New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia
    Private Sub frmConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenes' Puede moverla o quitarla según sea necesario.
        Recargar(Year(Now))
    End Sub
    Public Sub Recargar(ByVal filtro As String)
        Try
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.dtOrdenes' Puede moverla o quitarla según sea necesario.
            'Me.DTOrdenesTableAdapter.Fill(Me.DSVistas.DTOrdenes)
            Dim _ds = New DataSet
            _ds = _dOrdenes.OrdenesEndoscopiafecha(filtro)
            GCConsultar.DataSource = _ds.Tables(0)
            'bwCargar.RunWorkerAsync()
            'ppCargar.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmConsultar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        IDDetalleOrdenG = Nothing
        IDORdenG = Nothing
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            IDORdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            IDDetalleOrdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            Estudio = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub tsmVistaPrevia_Click(sender As Object, e As EventArgs) Handles tsmVistaPrevia.Click
        If IDDetalleOrdenG <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            _DetalleOrden = _dDetalleOrden.Cargar(IDDetalleOrdenG)
            If _DetalleOrden.Estado = "ATENDIDO" Then

                Select Case _DetalleOrden.IdTipoEstudio
                    Case 8
                        ImpresionHistoria(IDDetalleOrdenG, "H")
                        ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                        _dImpresionHistoria.EliminarHistoria(IDDetalleOrdenG, IdEmpleadoG)
                    Case 9
                        ImpresionHistoria(IDDetalleOrdenG, "C")
                        ImprimirFrm.CargarReporte("historia_control.rpt", IDDetalleOrdenG)
                        _dImpresionHistoria.EliminarHistoria(IDDetalleOrdenG, IdEmpleadoG)
                    Case 10
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.CargarReporte("endoscopia.rpt", IDDetalleOrdenG)
                        _dImpresionEndoscopia.EliminarEndoscopia(IDDetalleOrdenG, IdEmpleadoG)
                    Case 11
                        ImprimirFrm.CargarReporte("colonoscopia.rpt", IDDetalleOrdenG)
                    Case 12
                        ImprimirFrm.CargarReporte("rectoscopia.rpt", IDDetalleOrdenG)
                    Case Else
                        'MsgBox(Registro)

                End Select

            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & _DetalleOrden.Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GCConsultar.PrintDialog()
    End Sub

    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        Recargar(Year(Now))
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

        _ImpresionEndoscopia.Diagnostico = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionEndoscopia.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(22))
        _ImpresionEndoscopia.Medico = _ds.Tables(0).Rows(0)(23).ToString
        _ImpresionEndoscopia.Especialidad = _ds.Tables(0).Rows(0)(24).ToString
        _ImpresionEndoscopia.RegistroMedico = _ds.Tables(0).Rows(0)(25).ToString
        _ImpresionEndoscopia.IdEmpleado = IdEmpleadoG '_ds.Tables(0).Rows(0)(26).ToString

        '************* VERIFICAMOS SI EXISTEN IMAGENES **********
        If _dimagenes.ExisteImagenes(Filtro) = True Then
            MsgBox("tiene imagenesssssss")
            _ds = _dimagenes.ListarImagenesActivas(Filtro)
            Select Case _ds.Tables(0).Rows.Count
                Case 1
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = ""
                    '_ImpresionEndoscopia.Imagen3 = ""
                    '_ImpresionEndoscopia.Imagen4 = ""
                    '_ImpresionEndoscopia.Imagen5 = ""
                    '_ImpresionEndoscopia.Imagen6 = ""
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""
                Case 2
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = ""
                    '_ImpresionEndoscopia.Imagen4 = ""
                    '_ImpresionEndoscopia.Imagen5 = ""
                    '_ImpresionEndoscopia.Imagen6 = ""
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""
                Case 3
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = ""
                    '_ImpresionEndoscopia.Imagen5 = ""
                    '_ImpresionEndoscopia.Imagen6 = ""
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""


                Case 4
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = _ds.Tables(0).Rows(3)(0).ToString
                    '_ImpresionEndoscopia.Imagen5 = ""
                    '_ImpresionEndoscopia.Imagen6 = ""
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""

                Case 5
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = _ds.Tables(0).Rows(3)(0).ToString
                    '_ImpresionEndoscopia.Imagen5 = _ds.Tables(0).Rows(4)(0).ToString
                    '_ImpresionEndoscopia.Imagen6 = ""
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""

                Case 6
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = _ds.Tables(0).Rows(3)(0).ToString
                    '_ImpresionEndoscopia.Imagen5 = _ds.Tables(0).Rows(4)(0).ToString
                    '_ImpresionEndoscopia.Imagen6 = _ds.Tables(0).Rows(5)(0).ToString
                    '_ImpresionEndoscopia.Imagen7 = ""
                    '_ImpresionEndoscopia.Imagen8 = ""

                Case 7
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = _ds.Tables(0).Rows(3)(0).ToString
                    '_ImpresionEndoscopia.Imagen5 = _ds.Tables(0).Rows(4)(0).ToString
                    '_ImpresionEndoscopia.Imagen6 = _ds.Tables(0).Rows(5)(0).ToString
                    '_ImpresionEndoscopia.Imagen7 = _ds.Tables(0).Rows(6)(0).ToString
                    '_ImpresionEndoscopia.Imagen8 = ""

                Case 8
                    '_ImpresionEndoscopia.Imagen1 = _ds.Tables(0).Rows(0)(0).ToString
                    '_ImpresionEndoscopia.Imagen2 = _ds.Tables(0).Rows(1)(0).ToString
                    '_ImpresionEndoscopia.Imagen3 = _ds.Tables(0).Rows(2)(0).ToString
                    '_ImpresionEndoscopia.Imagen4 = _ds.Tables(0).Rows(3)(0).ToString
                    '_ImpresionEndoscopia.Imagen5 = _ds.Tables(0).Rows(4)(0).ToString
                    '_ImpresionEndoscopia.Imagen6 = _ds.Tables(0).Rows(5)(0).ToString
                    '_ImpresionEndoscopia.Imagen7 = _ds.Tables(0).Rows(6)(0).ToString
                    '_ImpresionEndoscopia.Imagen8 = _ds.Tables(0).Rows(7)(0).ToString
                Case Else
            End Select
            _dImpresionEndoscopia.GuardarImagenes(_ImpresionEndoscopia)
            _dimagenes.EliminarTemporales(Filtro, _ds.Tables(0).Rows.Count)
        Else
            MsgBox("NO tiene imagenes")

            _dImpresionEndoscopia.Guardar(_ImpresionEndoscopia)
        End If

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

    Private Sub tsm2020_Click(sender As Object, e As EventArgs) Handles tsm2020.Click
        Recargar("2020")
    End Sub

    Private Sub tsm2019_Click(sender As Object, e As EventArgs) Handles tsm2019.Click
        Recargar("2019")
    End Sub

    Private Sub tsm2018_Click(sender As Object, e As EventArgs) Handles tsm2018.Click
        Recargar("2018")
    End Sub

    Private Sub tsm2017_Click(sender As Object, e As EventArgs) Handles tsm2017.Click
        Recargar("2017")
    End Sub

    Private Sub tsm2021_Click(sender As Object, e As EventArgs) Handles tsm2021.Click
        Recargar("2021")
    End Sub
End Class
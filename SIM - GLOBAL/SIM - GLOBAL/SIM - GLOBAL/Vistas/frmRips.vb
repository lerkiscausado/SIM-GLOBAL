Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Imports System.IO
Public Class frmRips
    Dim _DRips As New SIM___GLOBAL.Controles.DRips
    Dim _ds As DataSet
    Dim _Dfacturas As New SIM___GLOBAL.Controles.DFacturas
    Private Sub RIPS()
        Dim fs As FileStream
        ':::Ruta donde crearemos nuestro archivo txt
        Dim ruta As String = "C:\RIPS\" & GVFacturas.GetRowCellValue(0, "FACTURA").ToString() & "\"
        ':::Nombre del archivo
        Dim archivo As String = "000000" & GVFacturas.GetRowCellValue(0, "FACTURA").ToString()
        ' CREAMOS NOMBRE DE ARCHIVOS
        Dim USarchivo As String = "US" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim ACarchivo As String = "AC" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim AParchivo As String = "AP" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim AFarchivo As String = "AF" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"
        Dim CTarchivo As String = "CT" & Mid(archivo, 1 + Len(GVFacturas.GetRowCellValue(0, "FACTURA").ToString()), 6) & ".TXT"



        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then
                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & USarchivo)
                fs.Close()
                fs = File.Create(ruta & ACarchivo)
                fs.Close()
                fs = File.Create(ruta & AParchivo)
                fs.Close()
                fs = File.Create(ruta & AFarchivo)
                fs.Close()
                fs = File.Create(ruta & CTarchivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            Else
                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)
                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & USarchivo)
                fs.Close()
                fs = File.Create(ruta & ACarchivo)
                fs.Close()
                fs = File.Create(ruta & AParchivo)
                fs.Close()
                fs = File.Create(ruta & AFarchivo)
                fs.Close()
                fs = File.Create(ruta & CTarchivo)
                fs.Close()
                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
        ' ESCRIBIMOS DENTRO DE LOS ARCHIVOS

        ' CREAMOS VARIABLES PARA ESCRIBIR ARCHIVOS
        Dim USescribir As New StreamWriter(ruta & USarchivo)
        Dim ACescribir As New StreamWriter(ruta & ACarchivo)
        Dim APescribir As New StreamWriter(ruta & AParchivo)
        Dim AFescribir As New StreamWriter(ruta & AFarchivo)
        Dim CTescribir As New StreamWriter(ruta & CTarchivo)
        Try
            'ESCRIBIMOS ARCHIVO AF
            AFescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "PRESTADOR").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "TIPO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "IDENTIFICACION").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "FACTURA").ToString() &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "INGRESO"), "dd/MM/yyyy") &
                                 "," & Format(GVFacturas.GetRowCellValue(0, "FINAL"), "dd/MM/yyyy") &
                                 "," & GVFacturas.GetRowCellValue(0, "CODIGO_ENTIDAD").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "ENTIDAD").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "CONTRATO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "PLAN").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "POLIZA").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "COPAGO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "COMISION").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "DESCUENTO").ToString() &
                                 "," & GVFacturas.GetRowCellValue(0, "NETO").ToString() &
                                 "")
            AFescribir.Close()

            'ESCRIBIMOS EL ARCHIVO CT
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(AFarchivo, 1, 8) & "," & GVFacturas.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(USarchivo, 1, 8) & "," & GVUsuarios.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(ACarchivo, 1, 8) & "," & GVConsultas.RowCount)
            CTescribir.WriteLine(GVFacturas.GetRowCellValue(0, "CODIGO").ToString() & "," & Format(GVFacturas.GetRowCellValue(0, "FECHA_FACTURA"), "dd/MM/yyyy") & "," & Mid(AParchivo, 1, 8) & "," & GVProcedimientos.RowCount)
            CTescribir.Close()

            'ESCRIBIMOS EL ARCHIVO US
            For x As Integer = 0 To GVUsuarios.RowCount - 1
                USescribir.WriteLine(GVUsuarios.GetRowCellValue(x, "ID_TIPO_IDENTIFICACION").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "CODIGO_ENTIDAD").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "CODIGO_TIPO_USUARIO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "PRIMER_APELLIDO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEGUNDO_APELLIDO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "PRIMER_NOMBRE").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEGUNDO_NOMBRE").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "EDAD").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "MEDIDA").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "SEXO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "DEPARTAMENTO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "MUNICIPIO").ToString &
                                     "," & GVUsuarios.GetRowCellValue(x, "ZONA").ToString &
                                     "")
            Next
            USescribir.Close()

            'ESCRIBIMOS EL ARCHIVO AC
            For x As Integer = 0 To GVConsultas.RowCount - 1
                ACescribir.WriteLine(GVConsultas.GetRowCellValue(x, "FACTURA").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "PRESTADOR").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "TIPO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & Format(GVConsultas.GetRowCellValue(x, "FECHA"), "dd/MM/yyyy") &
                                     "," & GVConsultas.GetRowCellValue(x, "AUTORIZACION").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CODIGO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "FINALIDAD").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CAUSA").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "CIE10").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D1").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D2").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "D3").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "ID_TIPO_DIAGNOSTICO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "VALOR").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "COPAGO").ToString &
                                     "," & GVConsultas.GetRowCellValue(x, "NETO").ToString &
                                     "")
            Next
            ACescribir.Close()

            'ESCRIBIMOS EL ARCHIVO AP
            For x As Integer = 0 To GVProcedimientos.RowCount - 1
                APescribir.WriteLine(GVProcedimientos.GetRowCellValue(x, "FACTURA").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "PRESTADOR").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "TIPO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "IDENTIFICACION").ToString &
                                     "," & Format(GVProcedimientos.GetRowCellValue(x, "FECHA"), "dd/MM/yyyy") &
                                     "," & GVProcedimientos.GetRowCellValue(x, "AUTORIZACION").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "CODIGO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "AMBITO").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "FINALIDAD").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "ATIENDE").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "CIE10").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "D1").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "D2").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "REALIZACION").ToString &
                                     "," & GVProcedimientos.GetRowCellValue(x, "NETO").ToString &
                                     "")
            Next
            APescribir.Close()

            MsgBox("Archivos PLANOS generados correctamente", MsgBoxStyle.Information, "RIPS")
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Private Sub frmRips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = New DataSet
        _ds = _Dfacturas.ListarFacturaServicios
        rcboFacturas.DataSource = _ds.Tables(0)
        rcboFacturas.DisplayMember = _ds.Tables(0).Columns(1).Caption
        rcboFacturas.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub

    Private Sub btVistaEstudios_Click(sender As Object, e As EventArgs)
        ' sfdRuta.Filter = "Documentos de Texto |*.txt"
        ' If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        ' 'GVUsuarios.OptionsView.ShowColumnHeaders = False
        '
        '        GCUsuarios.ExportToText(sfdRuta.FileName, ",", False)
        'GVUsuarios.OptionsView.ShowColumnHeaders = True
        '        End If
    End Sub
    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick

        If GVFacturas.RowCount > 0 Then
            RIPS()
        Else
            MsgBox("Debe Seleccionar una Factura", MsgBoxStyle.Information, "Facturas")
        End If

    End Sub

    Private Sub bbiFacturas_EditValueChanged(sender As Object, e As EventArgs) Handles bbiFacturas.EditValueChanged
        MsgBox(bbiFacturas.EditValue)
        _ds = New DataSet

        _ds = _DRips.Usuarios(bbiFacturas.EditValue)
        GCUsuarios.DataSource = _ds.Tables(0)

        _ds = New DataSet
        _ds = _DRips.Factura(bbiFacturas.EditValue)
        GCFacturas.DataSource = _ds.Tables(0)

        _ds = New DataSet
        _ds = _DRips.Consultas(bbiFacturas.EditValue)
        GCConsultas.DataSource = _ds.Tables(0)

        _ds = New DataSet
        _ds = _DRips.Procedimientos(bbiFacturas.EditValue)
        GCProcedimientos.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        GCUsuarios.DataSource = Nothing
        GCFacturas.DataSource = Nothing
        GCConsultas.DataSource = Nothing
        GCProcedimientos.DataSource = Nothing
        rcboFacturas.DataSource = Nothing
        bbiFacturas.EditValue = ""
        _ds = New DataSet
        _ds = _Dfacturas.ListarFacturaServicios
        rcboFacturas.DataSource = _ds.Tables(0)
        rcboFacturas.DisplayMember = _ds.Tables(0).Columns(1).Caption
        rcboFacturas.ValueMember = _ds.Tables(0).Columns(0).Caption

    End Sub

    Private Sub bbiFacturas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFacturas.ItemClick

    End Sub
End Class
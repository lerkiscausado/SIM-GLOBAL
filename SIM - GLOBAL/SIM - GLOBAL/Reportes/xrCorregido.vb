Public Class xrCorregido
    Inherits DevExpress.XtraReports.UI.XtraReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal datos As DataTable)
        InitializeComponent()
        AsignarDatos(datos)
    End Sub

    Private Sub AsignarDatos(ByVal datos As DataTable)
        ' Verificar que haya datos
        If datos Is Nothing OrElse datos.Rows.Count = 0 Then Exit Sub

        ' Tomar la primera fila
        Dim fila As DataRow = datos.Rows(0)

        ' Asignar cada campo a su label correspondiente
        lblConsecutivo.Text = CStr(fila("CONSECUTIVO"))
        lblNombre.Text = CStr(fila("NOMBRE"))
        lblNombreEntidad.Text = "LABORATORIO DE PATOLOGIA " & CStr(fila("NOMBRE_ENTIDAD"))

    End Sub
End Class
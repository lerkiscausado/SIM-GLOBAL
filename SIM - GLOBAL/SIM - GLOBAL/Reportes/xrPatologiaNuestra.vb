Public Class xrPatologiaNuestra
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
        lblInforme.Text = "INFORME ANATOMOPATOLOGICO No." & CStr(fila("CONSECUTIVO"))
        lblNombreEntidad.Text = "LABORATORIO DE PATOLOGIA " & CStr(fila("NOMBRE_ENTIDAD"))
        lblFechaIngreso.Text = CStr(fila("FECHA_INGRESO"))
        lblIdentificacion.Text = CStr(fila("IDENTIFICACION"))
        lblNombre.Text = CStr(fila("NOMBRE"))
        lblEdad.Text = CStr(fila("EDAD"))
        lblSexo.Text = CStr(fila("SEXO"))
        lblEntidad.Text = CStr(fila("NOMBRE_ENTIDAD"))
        lblTipoMuestra.Text = CStr(fila("TIPO_MUESTRA"))
        'lblSitioLesion.Text = CStr(fila("SITIO_LESION"))
        lblSolicitado.Text = CStr(fila("SOLICITADO"))
        lblDescripcionMacroscopica.Text = CStr(fila("DESCRIPCION_MACROSCOPICA"))
        'lblMicroscopica.Text = CStr(fila("DESCRIPCION_MICROSCOPICA"))
        xrDiagnostico.Html = CStr(fila("DIAGNOSTICO"))
        'lblObservaciones.Text = CStr(fila("OBSERVACIONES"))
        lblMedico.Text = CStr(fila("medico"))
        lblEspecialidad.Text = CStr(fila("especialidad"))
        lblRegistroMedico.Text = CStr(fila("registro_medico"))
        lblFechaSalida.Text = CStr(fila("fecha_salida"))
        lblSede.Text = CStr(fila("sede"))
        lblTelefono.Text = CStr(fila("telefono"))
        lblDireccion.Text = CStr(fila("direccion"))

        ' Campo firma (imagen blob)
        If Not IsDBNull(fila("firma")) Then
            Dim imgBytes As Byte() = CType(fila("firma"), Byte())
            Using ms As New IO.MemoryStream(imgBytes)
                picFirma.Image = Image.FromStream(ms)
            End Using
        End If
    End Sub
End Class
Imports SIM___GLOBAL.Controles
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms

''' <summary>
''' Historial de envíos RDA (tabla rda_envios) pensado para usuarios no técnicos:
''' estado en palabras y colores, motivo del rechazo explicado en lenguaje sencillo con
''' "qué hacer", tarjetas de resumen, filtros por periodo / estado / paciente y botón para
''' reenviar. La respuesta técnica de MinSalud sigue disponible en "Ver respuesta técnica".
''' Formulario autocontenido (sin .Designer.vb).
''' </summary>
Public Class frmHistorialRDA
    Inherits System.Windows.Forms.Form

    ' ── Colores ──────────────────────────────────────────────────────────────
    Private ReadOnly colorAzul As Color = Color.FromArgb(0, 84, 147)
    Private ReadOnly colorVerde As Color = Color.FromArgb(25, 135, 84)
    Private ReadOnly colorRojo As Color = Color.FromArgb(200, 35, 51)
    Private ReadOnly colorGris As Color = Color.FromArgb(108, 117, 125)
    Private ReadOnly colorFondo As Color = Color.FromArgb(244, 246, 249)
    Private ReadOnly fuente As New Font("Segoe UI", 9.0!)
    Private ReadOnly culturaCo As New CultureInfo("es-CO")

    ' ── Controles ────────────────────────────────────────────────────────────
    Private pnlEncabezado As New Panel()
    Private pnlTarjetas As New Panel()
    Private pnlFiltros As New Panel()
    Private pnlDetalle As New Panel()
    Private WithEvents grilla As New DataGridView()

    Private lblTotal As Label, lblAceptados As Label, lblPendientes As Label, lblCorregidos As Label

    Private WithEvents cmbPeriodo As New ComboBox()
    Private WithEvents cmbEstado As New ComboBox()
    Private WithEvents txtBuscar As New TextBox()
    Private WithEvents btnActualizar As New Button()

    Private lblDetalleTitulo As New Label()
    Private lblDetalleDatos As New Label()
    Private lblDetalleResultado As New Label()
    Private lblDetalleQueHacer As New Label()
    Private WithEvents btnReenviar As New Button()
    Private WithEvents btnTecnico As New Button()
    Private WithEvents btnCopiarCodigo As New Button()

    Private datos As DataTable

    Public Sub New()
        Me.Text = "Historial de envíos RDA - MinSalud"
        Me.Size = New Size(1150, 720)
        Me.MinimumSize = New Size(900, 560)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = colorFondo
        Me.Font = fuente

        ConstruirEncabezado()
        ConstruirTarjetas()
        ConstruirFiltros()
        ConstruirGrilla()
        ConstruirDetalle()

        ' Orden de Dock: lo último agregado queda más afuera.
        Me.Controls.Add(grilla)
        Me.Controls.Add(pnlDetalle)
        Me.Controls.Add(pnlFiltros)
        Me.Controls.Add(pnlTarjetas)
        Me.Controls.Add(pnlEncabezado)

        AddHandler Me.Load, Sub() CargarDatos()
    End Sub

#Region "Construcción de la pantalla"

    Private Sub ConstruirEncabezado()
        pnlEncabezado.Dock = DockStyle.Top
        pnlEncabezado.Height = 62
        pnlEncabezado.BackColor = colorAzul

        Dim titulo As New Label With {
            .Text = "Historial de envíos a MinSalud (RDA)",
            .Font = New Font("Segoe UI", 13.0!, FontStyle.Bold),
            .ForeColor = Color.White, .AutoSize = True, .Location = New Point(16, 8)}
        Dim subtitulo As New Label With {
            .Text = "Cada vez que se firma una historia, el SIM envía a MinSalud el resumen de la atención. Aquí puede ver si llegó bien y qué hacer si no.",
            .ForeColor = Color.FromArgb(220, 232, 245), .AutoSize = True, .Location = New Point(18, 36)}
        pnlEncabezado.Controls.Add(titulo)
        pnlEncabezado.Controls.Add(subtitulo)
    End Sub

    Private Sub ConstruirTarjetas()
        pnlTarjetas.Dock = DockStyle.Top
        pnlTarjetas.Height = 92

        lblTotal = CrearTarjeta(0, "Envíos en el periodo", colorAzul, 0)
        lblAceptados = CrearTarjeta(1, "Aceptados por MinSalud", colorVerde, 1)
        lblPendientes = CrearTarjeta(2, "Con error por resolver", colorRojo, 2)
        lblCorregidos = CrearTarjeta(3, "Errores ya corregidos", colorGris, 3)
    End Sub

    ''' <summary>Tarjeta con número grande; al hacer clic filtra la lista por ese estado.</summary>
    Private Function CrearTarjeta(posicion As Integer, titulo As String, colorTarjeta As Color, indiceEstado As Integer) As Label
        Dim tarjeta As New Panel With {
            .BackColor = Color.White, .Size = New Size(250, 72),
            .Location = New Point(12 + posicion * 262, 10), .Cursor = Cursors.Hand}
        Dim franja As New Panel With {.BackColor = colorTarjeta, .Dock = DockStyle.Left, .Width = 5}
        Dim numero As New Label With {
            .Text = "0", .Font = New Font("Segoe UI", 20.0!, FontStyle.Bold), .ForeColor = colorTarjeta,
            .AutoSize = True, .Location = New Point(16, 6), .Cursor = Cursors.Hand}
        Dim texto As New Label With {
            .Text = titulo, .ForeColor = colorGris, .AutoSize = True,
            .Location = New Point(19, 46), .Cursor = Cursors.Hand}
        tarjeta.Controls.Add(numero)
        tarjeta.Controls.Add(texto)
        tarjeta.Controls.Add(franja)

        Dim alHacerClic As EventHandler = Sub(s, e) cmbEstado.SelectedIndex = indiceEstado
        AddHandler tarjeta.Click, alHacerClic
        AddHandler numero.Click, alHacerClic
        AddHandler texto.Click, alHacerClic
        pnlTarjetas.Controls.Add(tarjeta)
        Return numero
    End Function

    Private Sub ConstruirFiltros()
        pnlFiltros.Dock = DockStyle.Top
        pnlFiltros.Height = 44

        Dim lblPeriodo As New Label With {.Text = "Periodo:", .AutoSize = True, .Location = New Point(14, 14)}
        cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPeriodo.Items.AddRange(New Object() {"Hoy", "Últimos 7 días", "Últimos 30 días", "Todo"})
        cmbPeriodo.SelectedIndex = 2
        cmbPeriodo.Location = New Point(70, 10)
        cmbPeriodo.Width = 130

        Dim lblEstado As New Label With {.Text = "Mostrar:", .AutoSize = True, .Location = New Point(220, 14)}
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.Items.AddRange(New Object() {"Todos", "Aceptados", "Con error por resolver", "Errores ya corregidos"})
        cmbEstado.SelectedIndex = 0
        cmbEstado.Location = New Point(278, 10)
        cmbEstado.Width = 180

        Dim lblBuscar As New Label With {.Text = "Buscar:", .AutoSize = True, .Location = New Point(478, 14)}
        txtBuscar.Location = New Point(530, 10)
        txtBuscar.Width = 260

        btnActualizar.Text = "↻  Actualizar"
        btnActualizar.Location = New Point(806, 8)
        btnActualizar.Size = New Size(110, 28)
        EstiloBoton(btnActualizar, colorAzul)

        Dim ayudaBuscar As New ToolTip()
        ayudaBuscar.SetToolTip(txtBuscar, "Nombre del paciente, número de documento u orden")

        pnlFiltros.Controls.AddRange(New Control() {lblPeriodo, cmbPeriodo, lblEstado, cmbEstado, lblBuscar, txtBuscar, btnActualizar})
    End Sub

    Private Sub ConstruirGrilla()
        grilla.Dock = DockStyle.Fill
        grilla.ReadOnly = True
        grilla.AllowUserToAddRows = False
        grilla.AllowUserToDeleteRows = False
        grilla.AllowUserToResizeRows = False
        grilla.MultiSelect = False
        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grilla.RowHeadersVisible = False
        grilla.AutoGenerateColumns = False
        grilla.BackgroundColor = Color.White
        grilla.BorderStyle = BorderStyle.None
        grilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grilla.GridColor = Color.FromArgb(230, 233, 237)
        grilla.EnableHeadersVisualStyles = False
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        grilla.ColumnHeadersHeight = 34
        grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 238, 245)
        grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41)
        grilla.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        grilla.DefaultCellStyle.Font = fuente
        grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 226, 255)
        grilla.DefaultCellStyle.SelectionForeColor = Color.Black
        grilla.DefaultCellStyle.Padding = New Padding(4, 0, 4, 0)
        grilla.RowTemplate.Height = 30

        AgregarColumna("estado", "Estado", 130)
        AgregarColumna("fecha", "Fecha y hora", 150, "dd/MM/yyyy  h:mm tt")
        AgregarColumna("paciente", "Paciente", 230)
        AgregarColumna("documentoPaciente", "Documento", 110)
        AgregarColumna("documento", "Qué se envió", 180)
        AgregarColumna("orden", "Orden", 65)
        Dim colResultado = AgregarColumna("resultado", "Resultado", 300)
        colResultado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Function AgregarColumna(campo As String, titulo As String, ancho As Integer, Optional formato As String = Nothing) As DataGridViewTextBoxColumn
        Dim col As New DataGridViewTextBoxColumn With {
            .DataPropertyName = campo, .Name = campo, .HeaderText = titulo, .Width = ancho,
            .SortMode = DataGridViewColumnSortMode.Automatic}
        If formato IsNot Nothing Then
            col.DefaultCellStyle.Format = formato
            col.DefaultCellStyle.FormatProvider = culturaCo
        End If
        grilla.Columns.Add(col)
        Return col
    End Function

    Private Sub ConstruirDetalle()
        pnlDetalle.Dock = DockStyle.Bottom
        pnlDetalle.Height = 150
        pnlDetalle.BackColor = Color.White

        lblDetalleTitulo.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        lblDetalleTitulo.AutoSize = True
        lblDetalleTitulo.Location = New Point(16, 10)

        lblDetalleDatos.AutoSize = True
        lblDetalleDatos.ForeColor = colorGris
        lblDetalleDatos.Location = New Point(18, 36)

        lblDetalleResultado.AutoSize = False
        lblDetalleResultado.Location = New Point(18, 60)
        lblDetalleResultado.Size = New Size(760, 38)

        lblDetalleQueHacer.AutoSize = False
        lblDetalleQueHacer.Location = New Point(18, 100)
        lblDetalleQueHacer.Size = New Size(760, 40)
        lblDetalleQueHacer.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        lblDetalleQueHacer.ForeColor = Color.FromArgb(33, 37, 41)

        btnReenviar.Text = "↻  Reenviar a MinSalud"
        btnReenviar.Size = New Size(190, 32)
        btnReenviar.Location = New Point(900, 14)
        EstiloBoton(btnReenviar, colorAzul)

        btnCopiarCodigo.Text = "Copiar código MinSalud"
        btnCopiarCodigo.Size = New Size(190, 30)
        btnCopiarCodigo.Location = New Point(900, 54)
        EstiloBoton(btnCopiarCodigo, colorGris, conBorde:=True)

        btnTecnico.Text = "Ver respuesta técnica"
        btnTecnico.Size = New Size(190, 30)
        btnTecnico.Location = New Point(900, 92)
        EstiloBoton(btnTecnico, colorGris, conBorde:=True)

        pnlDetalle.Controls.AddRange(New Control() {lblDetalleTitulo, lblDetalleDatos, lblDetalleResultado, lblDetalleQueHacer,
                                                    btnReenviar, btnCopiarCodigo, btnTecnico})
        AddHandler pnlDetalle.Resize, Sub() AcomodarDetalle()
        MostrarDetalle(Nothing)
    End Sub

    ''' <summary>Botones pegados a la derecha y textos ocupando el resto del ancho.</summary>
    Private Sub AcomodarDetalle()
        Dim x As Integer = pnlDetalle.ClientSize.Width - 206
        btnReenviar.Left = x
        btnCopiarCodigo.Left = x
        btnTecnico.Left = x
        lblDetalleResultado.Width = Math.Max(200, x - 36)
        lblDetalleQueHacer.Width = Math.Max(200, x - 36)
    End Sub

    Private Sub EstiloBoton(boton As Button, colorBoton As Color, Optional conBorde As Boolean = False)
        boton.FlatStyle = FlatStyle.Flat
        boton.Cursor = Cursors.Hand
        If conBorde Then
            boton.BackColor = Color.White
            boton.ForeColor = colorBoton
            boton.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218)
        Else
            boton.BackColor = colorBoton
            boton.ForeColor = Color.White
            boton.FlatAppearance.BorderSize = 0
        End If
    End Sub

#End Region

#Region "Datos"

    Private Sub CargarDatos()
        Dim origen As DataTable = DRDAPaciente.ListarEnviosHistorial()

        datos = New DataTable()
        datos.Columns.Add("id", GetType(Integer))
        datos.Columns.Add("fecha", GetType(DateTime))
        datos.Columns.Add("estado", GetType(String))
        datos.Columns.Add("estadoClave", GetType(String))
        datos.Columns.Add("paciente", GetType(String))
        datos.Columns.Add("documentoPaciente", GetType(String))
        datos.Columns.Add("documento", GetType(String))
        datos.Columns.Add("tipoTecnico", GetType(String))
        datos.Columns.Add("orden", GetType(Integer))
        datos.Columns.Add("resultado", GetType(String))
        datos.Columns.Add("queHacer", GetType(String))
        datos.Columns.Add("composition", GetType(String))
        datos.Columns.Add("detalle", GetType(String))
        datos.Columns.Add("codigoHttp", GetType(String))

        If origen.Columns.Contains("Error") Then
            grilla.DataSource = Nothing
            MostrarDetalle(Nothing)
            lblDetalleTitulo.Text = "No se pudo cargar el historial"
            lblDetalleResultado.Text = "La tabla de envíos RDA no existe en esta base de datos. Pida a soporte que ejecute la migración RDA."
            Return
        End If

        For Each fila As DataRow In origen.Rows
            Dim exitoso As Boolean = Convert.ToInt32(fila("exitoso")) = 1
            Dim corregido As Boolean = Not exitoso AndAlso Convert.ToInt32(fila("corregido_despues")) > 0
            Dim codigoHttp As String = If(IsDBNull(fila("codigo_http")), "", fila("codigo_http").ToString())
            Dim detalle As String = If(IsDBNull(fila("detalle")), "", fila("detalle").ToString())
            Dim tipo As String = If(IsDBNull(fila("tipo_documento")), "", fila("tipo_documento").ToString())
            Dim explicacion = ExplicarResultado(exitoso, corregido, codigoHttp, detalle)

            Dim nueva As DataRow = datos.NewRow()
            nueva("id") = fila("id")
            nueva("fecha") = fila("fecha_envio")
            nueva("estadoClave") = If(exitoso, "OK", If(corregido, "CORREGIDO", "ERROR"))
            nueva("estado") = If(exitoso, "✔  Aceptado", If(corregido, "↻  Corregido", "✖  Rechazado"))
            nueva("paciente") = If(IsDBNull(fila("paciente")) OrElse fila("paciente").ToString() = "", "(sin paciente)", fila("paciente").ToString())
            nueva("documentoPaciente") = If(IsDBNull(fila("documento_paciente")), "", fila("documento_paciente").ToString())
            nueva("tipoTecnico") = tipo
            nueva("documento") = NombreDocumento(tipo)
            nueva("orden") = If(IsDBNull(fila("id_orden")), 0, Convert.ToInt32(fila("id_orden")))
            nueva("resultado") = explicacion.Resultado
            nueva("queHacer") = explicacion.QueHacer
            nueva("composition") = If(IsDBNull(fila("composition_id")), "", fila("composition_id").ToString())
            nueva("detalle") = detalle
            nueva("codigoHttp") = codigoHttp
            datos.Rows.Add(nueva)
        Next

        grilla.DataSource = New DataView(datos)
        AplicarFiltros()
        AcomodarDetalle()
    End Sub

    Private Shared Function NombreDocumento(tipo As String) As String
        Select Case tipo.Trim().ToUpperInvariant()
            Case "RDA-PACIENTE" : Return "Antecedentes del paciente"
            Case "RDA-CONSULTA-EXTERNA" : Return "Resumen de la atención"
            Case Else : Return tipo
        End Select
    End Function

    ''' <summary>
    ''' Traduce la respuesta de MinSalud (o el error interno) a una frase que un usuario no
    ''' técnico entienda, más una recomendación de qué hacer.
    ''' </summary>
    Private Shared Function ExplicarResultado(exitoso As Boolean, corregido As Boolean, codigoHttp As String, detalle As String) As (Resultado As String, QueHacer As String)
        If exitoso Then
            Return ("MinSalud recibió el documento correctamente.", "No requiere ninguna acción.")
        End If

        Dim motivo = MotivoRechazo(codigoHttp, detalle)
        If corregido Then
            Return ("Este intento falló, pero el documento se reenvió después y MinSalud lo aceptó. Motivo del primer intento: " & motivo.Resultado,
                    "No requiere ninguna acción: el error ya quedó resuelto.")
        End If
        Return motivo
    End Function

    Private Shared Function MotivoRechazo(codigoHttp As String, detalle As String) As (Resultado As String, QueHacer As String)
        Dim d As String = If(detalle, "")
        Dim dl As String = d.ToLowerInvariant()

        ' Errores internos del SIM (antes de llegar a MinSalud)
        If dl.Contains("sin configuración de interoperabilidad") Then
            Return ("Falta configurar la conexión con MinSalud.", "Pida al administrador que complete la configuración RDA (credenciales y datos del prestador).")
        End If
        If dl.StartsWith("no fue posible obtener un token") Then
            Return ("No se pudo iniciar sesión en MinSalud (credenciales vencidas o incorrectas).", "Verifique la configuración RDA con ""Probar conexión"" y luego reenvíe.")
        End If
        If dl.StartsWith("no se encontró el paciente") Then
            Return ("No se encontraron los datos del paciente de esta orden.", "Revise que la orden tenga un paciente registrado y reenvíe.")
        End If
        If dl.StartsWith("no se encontró el especialista") Then
            Return ("No se encontraron los datos del médico que atendió.", "Revise en Empleados que el especialista tenga documento y nombres completos, y reenvíe.")
        End If
        If dl.StartsWith("no se encontró detalle_orden") Then
            Return ("La orden no tiene el servicio (consulta o procedimiento) registrado.", "Revise la orden en el SIM y reenvíe.")
        End If
        If dl.StartsWith("excepción") Then
            Return ("No hubo comunicación con MinSalud (internet o servicio no disponible).", "Revise la conexión a internet y reenvíe más tarde.")
        End If

        Dim codigo As Integer = 0
        Integer.TryParse(codigoHttp, codigo)
        If codigo = 401 OrElse codigo = 403 Then
            Return ("MinSalud no aceptó las credenciales del prestador.", "Verifique la configuración RDA con ""Probar conexión"" y luego reenvíe.")
        End If
        If codigo >= 500 Then
            Return ("El servicio de MinSalud tuvo una falla temporal.", "Espere unos minutos y reenvíe.")
        End If

        ' Respuesta OperationOutcome de MinSalud: se toma el primer problema de severidad error.
        Dim textoError As String = PrimerErrorMinSalud(d)
        Dim te As String = If(textoError, "").ToLowerInvariant()
        If te.Contains("incorrect display") Then
            Return ("La descripción del diagnóstico o del procedimiento no coincide con la oficial de MinSalud.", "Reenvíe: el SIM corrige la descripción automáticamente. Si persiste, avise a soporte.")
        End If
        If te.Contains("value set") OrElse te.Contains("unknown code") OrElse te.Contains("not found in") Then
            Return ("MinSalud no reconoce uno de los códigos usados (diagnóstico CIE-10 o servicio CUPS).", "Verifique el código del diagnóstico o del procedimiento en la historia. Si es correcto, avise a soporte.")
        End If
        If te.Contains("instance count") OrElse te.Contains("minimum required") Then
            Return ("Falta un dato obligatorio en la historia o en los datos del paciente / médico.", "Revise que el paciente y el médico tengan documento, nombres y apellidos completos, y reenvíe.")
        End If
        If te.Contains("fixed value") OrElse te.Contains("not exactly equal") Then
            Return ("Un dato del documento no tiene el valor que exige MinSalud.", "Avise a soporte con la respuesta técnica.")
        End If
        If textoError IsNot Nothing Then
            Return ("MinSalud rechazó el documento: " & Recortar(textoError, 160), "Avise a soporte con la respuesta técnica.")
        End If
        If codigo > 0 Then
            Return ($"MinSalud rechazó el documento (código {codigo}).", "Avise a soporte con la respuesta técnica.")
        End If
        Return ("El envío no se completó.", "Reenvíe. Si persiste, avise a soporte con la respuesta técnica.")
    End Function

    Private Shared Function PrimerErrorMinSalud(detalle As String) As String
        If String.IsNullOrWhiteSpace(detalle) OrElse Not detalle.TrimStart().StartsWith("{") Then Return Nothing
        Try
            Dim raiz = Newtonsoft.Json.Linq.JToken.Parse(detalle)
            For Each issue In raiz.SelectTokens("$..issue[*]")
                Dim severidad As String = If(issue("severity")?.ToString(), "")
                If severidad = "error" OrElse severidad = "fatal" Then
                    Dim texto As String = If(issue.SelectToken("details.text")?.ToString(), issue("diagnostics")?.ToString())
                    If Not String.IsNullOrWhiteSpace(texto) Then Return texto
                End If
            Next
        Catch
        End Try
        Return Nothing
    End Function

    Private Shared Function Recortar(texto As String, maximo As Integer) As String
        If texto.Length <= maximo Then Return texto
        Return texto.Substring(0, maximo) & "…"
    End Function

    Private Sub AplicarFiltros()
        If datos Is Nothing Then Return
        Dim vista As DataView = TryCast(grilla.DataSource, DataView)
        If vista Is Nothing Then Return

        Dim condiciones As New List(Of String)
        Dim desde As Date? = Nothing
        Select Case cmbPeriodo.SelectedIndex
            Case 0 : desde = Date.Today
            Case 1 : desde = Date.Today.AddDays(-6)
            Case 2 : desde = Date.Today.AddDays(-29)
        End Select
        If desde.HasValue Then condiciones.Add("fecha >= #" & desde.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) & "#")

        ' Las tarjetas cuentan sobre el periodo (sin el filtro de estado ni la búsqueda).
        ActualizarTarjetas(String.Join(" AND ", condiciones))

        Select Case cmbEstado.SelectedIndex
            Case 1 : condiciones.Add("estadoClave = 'OK'")
            Case 2 : condiciones.Add("estadoClave = 'ERROR'")
            Case 3 : condiciones.Add("estadoClave = 'CORREGIDO'")
        End Select

        Dim buscar As String = txtBuscar.Text.Trim()
        If buscar <> "" Then
            Dim b As String = EscaparLike(buscar)
            condiciones.Add($"(paciente LIKE '*{b}*' OR documentoPaciente LIKE '*{b}*' OR CONVERT(orden, 'System.String') LIKE '*{b}*')")
        End If

        vista.RowFilter = String.Join(" AND ", condiciones)
        If grilla.Rows.Count = 0 Then MostrarDetalle(Nothing)
    End Sub

    Private Shared Function EscaparLike(texto As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In texto
            Select Case c
                Case "*"c, "%"c, "["c, "]"c : sb.Append("[").Append(c).Append("]")
                Case "'"c : sb.Append("''")
                Case Else : sb.Append(c)
            End Select
        Next
        Return sb.ToString()
    End Function

    Private Sub ActualizarTarjetas(filtroPeriodo As String)
        Dim total As Integer = 0, aceptados As Integer = 0, pendientes As Integer = 0, corregidos As Integer = 0
        For Each r As DataRow In datos.Select(filtroPeriodo)
            total += 1
            Select Case r("estadoClave").ToString()
                Case "OK" : aceptados += 1
                Case "ERROR" : pendientes += 1
                Case "CORREGIDO" : corregidos += 1
            End Select
        Next
        lblTotal.Text = total.ToString()
        lblAceptados.Text = aceptados.ToString()
        lblPendientes.Text = pendientes.ToString()
        lblCorregidos.Text = corregidos.ToString()
    End Sub

#End Region

#Region "Eventos"

    Private Sub Filtros_Changed(sender As Object, e As EventArgs) Handles cmbPeriodo.SelectedIndexChanged, cmbEstado.SelectedIndexChanged, txtBuscar.TextChanged
        AplicarFiltros()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarDatos()
    End Sub

    Private Sub grilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grilla.CellFormatting
        If e.RowIndex < 0 OrElse grilla.Columns(e.ColumnIndex).Name <> "estado" Then Return
        Dim fila = TryCast(grilla.Rows(e.RowIndex).DataBoundItem, DataRowView)
        If fila Is Nothing Then Return
        Dim c As Color = ColorEstado(fila("estadoClave").ToString())
        e.CellStyle.ForeColor = c
        e.CellStyle.SelectionForeColor = c
    End Sub

    Private Function ColorEstado(clave As String) As Color
        Select Case clave
            Case "OK" : Return colorVerde
            Case "ERROR" : Return colorRojo
            Case Else : Return colorGris
        End Select
    End Function

    Private Sub grilla_SelectionChanged(sender As Object, e As EventArgs) Handles grilla.SelectionChanged
        MostrarDetalle(FilaActual())
    End Sub

    Private Sub grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnTecnico.Enabled Then btnTecnico.PerformClick()
    End Sub

    Private Function FilaActual() As DataRowView
        If grilla.CurrentRow Is Nothing Then Return Nothing
        Return TryCast(grilla.CurrentRow.DataBoundItem, DataRowView)
    End Function

    Private Sub MostrarDetalle(fila As DataRowView)
        If fila Is Nothing Then
            lblDetalleTitulo.Text = "Seleccione un envío para ver el detalle"
            lblDetalleTitulo.ForeColor = Color.FromArgb(33, 37, 41)
            lblDetalleDatos.Text = ""
            lblDetalleResultado.Text = ""
            lblDetalleQueHacer.Text = ""
            HabilitarAcciones(Nothing)
            Return
        End If
        lblDetalleTitulo.Text = fila("estado").ToString().Trim() & "  ·  " & fila("documento").ToString()
        lblDetalleTitulo.ForeColor = ColorEstado(fila("estadoClave").ToString())
        lblDetalleDatos.Text = $"Paciente: {fila("paciente")}  {fila("documentoPaciente")}      Orden: {fila("orden")}      " &
                               $"Enviado: {CDate(fila("fecha")).ToString("dd/MM/yyyy h:mm tt", culturaCo)}"
        lblDetalleResultado.Text = fila("resultado").ToString()
        lblDetalleQueHacer.Text = "Qué hacer: " & fila("queHacer").ToString()
        HabilitarAcciones(fila)
    End Sub

    Private Sub HabilitarAcciones(fila As DataRowView)
        btnReenviar.Enabled = fila IsNot Nothing AndAlso fila("estadoClave").ToString() = "ERROR" AndAlso Convert.ToInt32(fila("orden")) > 0
        btnCopiarCodigo.Enabled = fila IsNot Nothing AndAlso fila("composition").ToString() <> ""
        btnTecnico.Enabled = fila IsNot Nothing AndAlso fila("detalle").ToString() <> ""
        btnReenviar.BackColor = If(btnReenviar.Enabled, colorAzul, Color.FromArgb(173, 181, 189))
    End Sub

    Private Sub btnCopiarCodigo_Click(sender As Object, e As EventArgs) Handles btnCopiarCodigo.Click
        Dim fila = FilaActual()
        If fila Is Nothing Then Return
        Clipboard.SetText(fila("composition").ToString())
        MessageBox.Show("Código copiado. Es el identificador con el que MinSalud registró este documento.",
                        "Historial RDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnTecnico_Click(sender As Object, e As EventArgs) Handles btnTecnico.Click
        Dim fila = FilaActual()
        If fila Is Nothing Then Return
        Dim texto As String = fila("detalle").ToString()
        Try
            If texto.TrimStart().StartsWith("{") Then texto = Newtonsoft.Json.Linq.JToken.Parse(texto).ToString(Newtonsoft.Json.Formatting.Indented)
        Catch
        End Try
        texto = texto.Replace(vbCrLf, vbLf).Replace(vbLf, vbCrLf)

        Using ventana As New Form With {
            .Text = $"Respuesta técnica de MinSalud - Orden {fila("orden")} - HTTP {fila("codigoHttp")}",
            .Size = New Size(820, 600), .StartPosition = FormStartPosition.CenterParent,
            .MinimizeBox = False, .ShowInTaskbar = False}
            Dim caja As New TextBox With {
                .Multiline = True, .ReadOnly = True, .ScrollBars = ScrollBars.Both, .WordWrap = False,
                .Dock = DockStyle.Fill, .Font = New Font("Consolas", 9.0!), .Text = texto, .BackColor = Color.White}
            ventana.Controls.Add(caja)
            ventana.ShowDialog(Me)
        End Using
    End Sub

    ''' <summary>
    ''' Reenvía el RDA de la fila seleccionada con los datos actuales de la orden. El resultado
    ''' queda como un nuevo registro y la lista se recarga.
    ''' </summary>
    Private Async Sub btnReenviar_Click(sender As Object, e As EventArgs) Handles btnReenviar.Click
        Dim fila = FilaActual()
        If fila Is Nothing Then Return
        Dim idOrden As Integer = Convert.ToInt32(fila("orden"))
        Dim tipo As String = fila("tipoTecnico").ToString().Trim().ToUpperInvariant()

        Dim datosOrden = DRDAPaciente.DatosParaReenvio(idOrden)
        If datosOrden Is Nothing Then
            MessageBox.Show($"No se encontraron el paciente o el médico de la orden {idOrden}.", "Reenviar a MinSalud",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show($"¿Reenviar a MinSalud el documento ""{fila("documento")}"" de {fila("paciente")} (orden {idOrden})?",
                           "Reenviar a MinSalud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        btnReenviar.Enabled = False
        btnReenviar.Text = "Enviando..."
        Cursor = Cursors.WaitCursor
        Try
            Dim ok As Boolean
            If tipo = "RDA-PACIENTE" Then
                ok = Await DRDAPaciente.EnviarRDAPacienteAsync(idOrden, datosOrden.Value.IdUsuario, datosOrden.Value.IdEspecialista)
            Else
                ok = Await DRDAConsultaExterna.EnviarRDAConsultaExternaAsync(idOrden, datosOrden.Value.IdUsuario, datosOrden.Value.IdEspecialista,
                                                                            tipoPreferido:=datosOrden.Value.TipoPreferido)
            End If
            CargarDatos()
            MessageBox.Show(If(ok, "✅ MinSalud aceptó el documento.", "❌ MinSalud volvió a rechazar el documento. Revise el motivo en la parte inferior."),
                            "Reenviar a MinSalud", MessageBoxButtons.OK, If(ok, MessageBoxIcon.Information, MessageBoxIcon.Warning))
        Finally
            Cursor = Cursors.Default
            btnReenviar.Text = "↻  Reenviar a MinSalud"
            HabilitarAcciones(FilaActual())
        End Try
    End Sub

#End Region
End Class

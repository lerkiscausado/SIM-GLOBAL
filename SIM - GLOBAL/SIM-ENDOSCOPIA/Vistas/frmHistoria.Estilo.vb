Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab

''' <summary>
''' Estilo visual de la historia clínica aplicado por código (frmHistoria.Designer.vb queda
''' intacto), con el mismo lenguaje visual de los formularios RDA (frmRDA, frmHistorialRDA):
'''  - Encabezado azul con tipo de historia, orden, código y etiqueta de estado
'''    (Borrador / Firmada / Enviada a MinSalud / error RDA).
'''  - Fondo gris claro y áreas de trabajo en blanco; antecedentes estirados al ancho.
'''  - Tarjeta del paciente legible; lista de pacientes con buscador y contador.
'''  - "Falta: motivo, antecedentes, diagnóstico" / "Lista para firmar" junto a Firmar, y
'''    pestañas con datos obligatorios vacíos en rojo.
''' DISENO_RDA = False desactiva el encabezado y la reorganización (deja solo el estilo básico).
''' Se llama desde frmHistoria_Load (AplicarEstiloVisual) y al abrir / limpiar una historia
''' (ActualizarIndicadoresHistoria).
''' </summary>
Partial Class frmHistoria

    ''' <summary>Interruptor del diseño tipo RDA (encabezado azul, fondo, tarjetas).</summary>
    Private Const DISENO_RDA As Boolean = True
    Private Const ALTO_ENCABEZADO As Integer = 58

    Private ReadOnly estiloAzul As Color = Color.FromArgb(0, 84, 147)
    Private ReadOnly estiloAzulClaro As Color = Color.FromArgb(220, 232, 245)
    Private ReadOnly estiloVerde As Color = Color.FromArgb(25, 135, 84)
    Private ReadOnly estiloRojo As Color = Color.FromArgb(200, 35, 51)
    Private ReadOnly estiloNaranja As Color = Color.FromArgb(214, 120, 0)
    Private ReadOnly estiloTexto As Color = Color.FromArgb(33, 37, 41)
    Private ReadOnly estiloGris As Color = Color.FromArgb(108, 117, 125)
    Private ReadOnly estiloFondo As Color = Color.FromArgb(244, 246, 249)

    Private lblEstadoHistoria As LabelControl
    Private pnlEncabezadoHistoria As Panel
    Private lblTituloHistoria As Label
    Private lblSubtituloHistoria As Label
    Private lblEstadoEncabezado As Label
    Private estiloAplicado As Boolean

    ' Estado de firma / RDA de la orden abierta: se consulta una sola vez al abrir la historia
    ' (no en cada tecla).
    Private estadoOrdenCache As SIM___GLOBAL.Controles.DRDAPaciente.EstadoHistoriaRDAInfo
    Private estadoOrdenId As Integer = -1

    Private Sub AplicarEstiloVisual()
        If estiloAplicado Then Return
        estiloAplicado = True
        Try
            EstiloTextos()
            EstiloTarjetaPaciente()
            EstiloGrilla(GVPacientesAtender, conBuscador:=True)
            EstiloGrilla(gvHistoriasAnteriores, conBuscador:=False)
            EstiloGrilla(GVDiagnosticos, conBuscador:=False)
            If DISENO_RDA Then DisenoTipoRDA()
            CrearIndicadorEstado()

            ' Contador de pacientes por atender en el título del panel.
            AddHandler GVPacientesAtender.RowCountChanged, Sub() GroupControl1.Text = $"Pacientes por atender ({GVPacientesAtender.RowCount})"
            GroupControl1.Text = $"Pacientes por atender ({GVPacientesAtender.RowCount})"
            GroupControl2.Text = "Historias anteriores del paciente"

            ' El indicador de "qué falta para firmar" se actualiza mientras el médico escribe.
            For Each memo As MemoEdit In {txtMotivoConsulta, txtAntecedentesFamiliares, txtAntecedentesPersonales, txtConsultaControl}
                AddHandler memo.EditValueChanged, Sub() ActualizarPendientesFirma()
            Next
            AddHandler GVDiagnosticos.RowCountChanged, Sub() ActualizarPendientesFirma()
            AddHandler txtNumeroHistoria.EditValueChanged, Sub() ActualizarEncabezado()
            ActualizarIndicadoresHistoria()
        Catch
            ' El estilo es cosmético: nunca debe impedir abrir la historia.
        End Try
    End Sub

#Region "Diseño tipo RDA"

    Private Sub DisenoTipoRDA()
        Dim panel As Control = SplitContainerControl1.Panel2

        ' 1. Fondo gris claro en ambos lados.
        SplitContainerControl1.Panel1.Appearance.BackColor = estiloFondo
        SplitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
        SplitContainerControl1.Panel2.Appearance.BackColor = estiloFondo
        SplitContainerControl1.Panel2.Appearance.Options.UseBackColor = True

        ' 2. Bajar todo el contenido del panel derecho para dar espacio al encabezado. Los
        '    controles anclados abajo se acortan lo mismo, así su borde inferior no cambia.
        For Each c As Control In panel.Controls
            c.Top += ALTO_ENCABEZADO
            If (c.Anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then c.Height = Math.Max(50, c.Height - ALTO_ENCABEZADO)
        Next

        ' 3. Encabezado azul (como frmRDA / frmHistorialRDA).
        pnlEncabezadoHistoria = New Panel With {.Dock = DockStyle.Top, .Height = ALTO_ENCABEZADO, .BackColor = estiloAzul}
        lblTituloHistoria = New Label With {
            .AutoSize = True, .Location = New Point(14, 7), .ForeColor = Color.White, .BackColor = Color.Transparent,
            .Font = New Font("Segoe UI", 13.0!, FontStyle.Bold), .Text = "Historia clínica"}
        lblSubtituloHistoria = New Label With {
            .AutoSize = True, .Location = New Point(16, 34), .ForeColor = estiloAzulClaro, .BackColor = Color.Transparent,
            .Font = New Font("Segoe UI", 9.0!)}
        lblEstadoEncabezado = New Label With {
            .AutoSize = True, .BackColor = Color.White, .Padding = New Padding(10, 5, 10, 5),
            .Font = New Font("Segoe UI", 9.5!, FontStyle.Bold), .Anchor = AnchorStyles.Top Or AnchorStyles.Right, .Visible = False}
        pnlEncabezadoHistoria.Controls.AddRange(New Control() {lblTituloHistoria, lblSubtituloHistoria, lblEstadoEncabezado})
        AddHandler pnlEncabezadoHistoria.Resize, Sub() UbicarEstadoEncabezado()
        AddHandler lblEstadoEncabezado.SizeChanged, Sub() UbicarEstadoEncabezado()
        panel.Controls.Add(pnlEncabezadoHistoria)
        pnlEncabezadoHistoria.BringToFront()

        ' El título del tipo de historia pasa al encabezado.
        lblHistoriaClinica.Visible = False

        ' 4. Antecedentes estirados hasta el borde derecho (antes quedaba un espacio vacío).
        XtraTabControl1.Width = Math.Max(XtraTabControl1.Width, xtcReporteEstudio.Right - XtraTabControl1.Left)
        XtraTabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' 5. Áreas de trabajo en blanco.
        For Each pestanas As XtraTabControl In {XtraTabControl1, xtcReporteEstudio}
            pestanas.AppearancePage.PageClient.BackColor = Color.White
            pestanas.AppearancePage.PageClient.Options.UseBackColor = True
        Next
        For Each memo As MemoEdit In {txtAntecedentesFamiliares2, txtAntecedentesPersonales2}
            memo.Properties.Appearance.BackColor = Color.FromArgb(250, 251, 253)
            memo.Properties.Appearance.Options.UseBackColor = True
        Next

        ' 6. Orden y código de historia como "etiquetas" azules suaves (antes amarillo).
        For Each campo As TextEdit In {lblConsecutivoOrden, txtNumeroHistoria}
            campo.Properties.Appearance.BackColor = estiloAzulClaro
            campo.Properties.Appearance.ForeColor = estiloAzul
            campo.Properties.Appearance.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            campo.Properties.Appearance.Options.UseBackColor = True
            campo.Properties.Appearance.Options.UseForeColor = True
            campo.Properties.Appearance.Options.UseFont = True
        Next

        ' 7. Rótulos y casilla Firmar.
        For Each etiqueta As LabelControl In ControlesDeTipo(Of LabelControl)(Me)
            If etiqueta Is lblHistoriaClinica Then Continue For
            etiqueta.Appearance.Font = New Font("Segoe UI", 8.75!)
            etiqueta.Appearance.ForeColor = Color.FromArgb(73, 80, 87)
            etiqueta.Appearance.Options.UseFont = True
            etiqueta.Appearance.Options.UseForeColor = True
        Next
        ' Con la fuente nueva los rótulos de la fila superior son más anchos: se pegan a la
        ' izquierda de su casilla para que no queden tapados ("Codigo de Historia:").
        For Each par In {Tuple.Create(LabelControl2, CType(dtFechaIngreso, Control)),
                         Tuple.Create(LabelControl7, CType(lblConsecutivoOrden, Control)),
                         Tuple.Create(LabelControl1, CType(txtNumeroHistoria, Control))}
            par.Item1.Left = par.Item2.Left - par.Item1.Width - 6
        Next

        chkProcesado.Properties.Appearance.Font = New Font("Segoe UI", 9.5!, FontStyle.Bold)
        chkProcesado.Properties.Appearance.ForeColor = estiloAzul
        chkProcesado.Properties.Appearance.Options.UseFont = True
        chkProcesado.Properties.Appearance.Options.UseForeColor = True

        For Each grupo In {GroupControl1, GroupControl2}
            grupo.AppearanceCaption.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            grupo.AppearanceCaption.ForeColor = estiloAzul
            grupo.AppearanceCaption.Options.UseFont = True
            grupo.AppearanceCaption.Options.UseForeColor = True
        Next
    End Sub

    Private Sub UbicarEstadoEncabezado()
        If pnlEncabezadoHistoria Is Nothing Then Return
        lblEstadoEncabezado.Location = New Point(pnlEncabezadoHistoria.ClientSize.Width - lblEstadoEncabezado.Width - 16,
                                                 (ALTO_ENCABEZADO - lblEstadoEncabezado.Height) \ 2)
    End Sub

    ''' <summary>Título, subtítulo y etiqueta de estado del encabezado azul.</summary>
    Private Sub ActualizarEncabezado()
        If pnlEncabezadoHistoria Is Nothing Then Return
        Dim idOrden As Integer = CInt(Val(lblConsecutivoOrden.Text))
        If idOrden <= 0 Then
            lblTituloHistoria.Text = "Historia clínica"
            lblSubtituloHistoria.Text = "Seleccione un paciente de la lista de la izquierda y pulse Nuevo para abrir su historia."
            lblEstadoEncabezado.Visible = False
            Return
        End If

        Dim tipo As String = lblHistoriaClinica.Text.Replace("Historia Clinica", "").Trim(" "c, "-"c)
        lblTituloHistoria.Text = "Historia clínica" & If(tipo <> "", "  ·  " & PrimeraMayuscula(tipo), "")
        Dim codigo As String = txtNumeroHistoria.Text.Trim()
        lblSubtituloHistoria.Text = $"Orden {idOrden}" & If(codigo <> "", $"   ·   Código de historia {codigo}", "   ·   Aún sin guardar")

        Dim estado = estadoOrdenCache
        If estado IsNot Nothing AndAlso estado.Firmada Then
            If estado.ErroresPendientes > 0 Then
                PintarEstado("✖  Firmada · error al enviar a MinSalud", estiloRojo)
            ElseIf estado.EnviosOk > 0 Then
                PintarEstado("✔  Firmada y enviada a MinSalud", estiloVerde)
            Else
                PintarEstado("●  Firmada", estiloAzul)
            End If
        Else
            PintarEstado("●  Borrador", estiloNaranja)
        End If
    End Sub

    Private Sub PintarEstado(texto As String, colorTexto As Color)
        lblEstadoEncabezado.Text = texto
        lblEstadoEncabezado.ForeColor = colorTexto
        lblEstadoEncabezado.Visible = True
        UbicarEstadoEncabezado()
    End Sub

    Private Shared Function PrimeraMayuscula(texto As String) As String
        Dim t As String = texto.Trim().ToLowerInvariant()
        If t = "" Then Return t
        Return Char.ToUpperInvariant(t(0)) & t.Substring(1)
    End Function

#End Region

#Region "Estilo básico"

    ''' <summary>Fuente más legible en los campos de texto y títulos/pestañas más claros.</summary>
    Private Sub EstiloTextos()
        Dim fuenteTexto As New Font("Segoe UI", 10.0!)
        For Each memo As MemoEdit In ControlesDeTipo(Of MemoEdit)(Me)
            memo.Properties.Appearance.Font = fuenteTexto
            memo.Properties.Appearance.Options.UseFont = True
        Next

        lblHistoriaClinica.Appearance.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        lblHistoriaClinica.Appearance.ForeColor = estiloAzul
        lblHistoriaClinica.Appearance.Options.UseFont = True
        lblHistoriaClinica.Appearance.Options.UseForeColor = True

        For Each pestanas As XtraTabControl In ControlesDeTipo(Of XtraTabControl)(Me)
            pestanas.AppearancePage.Header.Font = New Font("Segoe UI", 9.0!)
            pestanas.AppearancePage.Header.Options.UseFont = True
            pestanas.AppearancePage.HeaderActive.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            pestanas.AppearancePage.HeaderActive.ForeColor = estiloAzul
            pestanas.AppearancePage.HeaderActive.Options.UseFont = True
            pestanas.AppearancePage.HeaderActive.Options.UseForeColor = True
        Next
    End Sub

    ''' <summary>Tarjeta del paciente: nombre y apellidos en negrilla oscura, documento en azul.</summary>
    Private Sub EstiloTarjetaPaciente()
        For Each elemento In TVDatosUsuarios.TileTemplate
            Dim apariencia = elemento.Appearance.Normal
            If elemento.Column Is TileViewColumn3 OrElse elemento.Column Is colApellidos Then
                apariencia.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
                apariencia.ForeColor = estiloTexto
            ElseIf elemento.Column Is TileViewColumn2 Then
                apariencia.Font = New Font("Segoe UI", 8.5!, FontStyle.Bold)
                apariencia.ForeColor = estiloAzul
            ElseIf elemento.Column Is Nothing Then
                ' Rótulos fijos ("Edad:", "Sexo:", "Telefono:")
                apariencia.Font = New Font("Segoe UI", 8.25!)
                apariencia.ForeColor = estiloGris
            Else
                apariencia.Font = New Font("Segoe UI", 8.25!)
                apariencia.ForeColor = estiloTexto
            End If
            apariencia.Options.UseFont = True
            apariencia.Options.UseForeColor = True
        Next
        TVDatosUsuarios.Appearance.ItemNormal.BackColor = Color.White
        TVDatosUsuarios.Appearance.ItemNormal.BorderColor = estiloAzul
        TVDatosUsuarios.Appearance.ItemNormal.Options.UseBackColor = True
        TVDatosUsuarios.Appearance.ItemNormal.Options.UseBorderColor = True
    End Sub

    Private Sub EstiloGrilla(vista As GridView, conBuscador As Boolean)
        If vista Is Nothing Then Return
        vista.RowHeight = 24
        vista.Appearance.Row.Font = New Font("Segoe UI", 9.0!)
        vista.Appearance.Row.Options.UseFont = True
        vista.Appearance.HeaderPanel.Font = New Font("Segoe UI", 8.25!, FontStyle.Bold)
        vista.Appearance.HeaderPanel.Options.UseFont = True
        vista.OptionsView.EnableAppearanceEvenRow = True
        vista.Appearance.EvenRow.BackColor = Color.FromArgb(246, 248, 251)
        vista.Appearance.EvenRow.Options.UseBackColor = True
        For Each ap In {vista.Appearance.FocusedRow, vista.Appearance.SelectedRow, vista.Appearance.HideSelectionRow}
            ap.BackColor = Color.FromArgb(207, 226, 255)
            ap.ForeColor = Color.Black
            ap.Options.UseBackColor = True
            ap.Options.UseForeColor = True
        Next
        If conBuscador Then
            vista.OptionsFind.AlwaysVisible = True
            vista.OptionsFind.ShowCloseButton = False
            vista.OptionsFind.FindNullPrompt = "Buscar paciente por nombre, documento u orden..."
        End If
    End Sub

#End Region

#Region "Indicadores de firma"

    ''' <summary>Etiqueta junto a "Firmar" con lo que falta para firmar.</summary>
    Private Sub CrearIndicadorEstado()
        Dim contenedor As Control = chkProcesado.Parent
        If contenedor Is Nothing Then Return
        lblEstadoHistoria = New LabelControl With {
            .AllowHtmlString = True,
            .AutoSizeMode = LabelAutoSizeMode.Horizontal,
            .Location = New Point(chkProcesado.Right + 14, chkProcesado.Top + 3),
            .Text = ""}
        lblEstadoHistoria.Appearance.Font = New Font("Segoe UI", 9.0!)
        lblEstadoHistoria.Appearance.Options.UseFont = True
        contenedor.Controls.Add(lblEstadoHistoria)
        lblEstadoHistoria.BringToFront()
    End Sub

    ''' <summary>Consulta el estado de firma / RDA de la orden y refresca indicadores. Se llama al abrir o limpiar una historia.</summary>
    Private Sub ActualizarIndicadoresHistoria()
        Try
            Dim idOrden As Integer = CInt(Val(lblConsecutivoOrden.Text))
            estadoOrdenId = idOrden
            estadoOrdenCache = If(idOrden > 0, SIM___GLOBAL.Controles.DRDAPaciente.EstadoHistoriaRDA(idOrden), Nothing)
        Catch
            estadoOrdenCache = Nothing
        End Try
        ActualizarPendientesFirma()
    End Sub

    ''' <summary>Refresca "Falta: ..." / "Lista para firmar" y las pestañas en rojo (sin consultar la base).</summary>
    Private Sub ActualizarPendientesFirma()
        Try
            ActualizarEncabezado()
            If lblEstadoHistoria Is Nothing Then Return
            Dim idOrden As Integer = CInt(Val(lblConsecutivoOrden.Text))
            Dim firmada As Boolean = estadoOrdenCache IsNot Nothing AndAlso estadoOrdenCache.Firmada AndAlso estadoOrdenId = idOrden
            If idOrden <= 0 OrElse firmada Then
                MarcarPestana(xtpMotivoConsulta, False)
                MarcarPestana(xtpAntecedentes, False)
                MarcarPestana(xtpDiagnostico, False)
                ' Sin encabezado (DISENO_RDA = False) el estado de firma se muestra aquí.
                lblEstadoHistoria.Text = If(firmada AndAlso pnlEncabezadoHistoria Is Nothing, Html("✔ Firmada", estiloVerde, True), "")
                Return
            End If

            ' Mismos campos que valida bbiGuardar, más el diagnóstico que exige la firma.
            Dim faltaMotivo As Boolean = xtpMotivoConsulta.PageVisible AndAlso String.IsNullOrWhiteSpace(txtMotivoConsulta.Text)
            Dim faltaAntecedentes As Boolean = xtpAntecedentes.PageVisible AndAlso
                (String.IsNullOrWhiteSpace(txtAntecedentesFamiliares.Text) OrElse String.IsNullOrWhiteSpace(txtAntecedentesPersonales.Text))
            Dim faltaDiagnostico As Boolean = GVDiagnosticos.RowCount = 0
            MarcarPestana(xtpMotivoConsulta, faltaMotivo)
            MarcarPestana(xtpAntecedentes, faltaAntecedentes)
            MarcarPestana(xtpDiagnostico, faltaDiagnostico)

            Dim faltantes As New List(Of String)
            If faltaMotivo Then faltantes.Add("motivo")
            If faltaAntecedentes Then faltantes.Add("antecedentes")
            If faltaDiagnostico Then faltantes.Add("diagnóstico")

            Dim texto As String = If(pnlEncabezadoHistoria Is Nothing, Html("● Borrador", estiloNaranja, True) & "   ", "")
            If faltantes.Count > 0 Then
                texto &= Html("Falta: " & String.Join(", ", faltantes), estiloRojo, False)
            Else
                texto &= Html("✔ Lista para firmar", estiloVerde, True)
            End If
            lblEstadoHistoria.Text = texto
        Catch
        End Try
    End Sub

    ''' <summary>Pestaña con datos obligatorios vacíos: texto rojo con marca.</summary>
    Private Sub MarcarPestana(pagina As XtraTabPage, faltaDato As Boolean)
        If pagina Is Nothing Then Return
        Dim titulo As String = pagina.Text.TrimEnd(" "c, "•"c)
        pagina.Text = If(faltaDato, titulo & " •", titulo)
        pagina.Appearance.Header.ForeColor = If(faltaDato, estiloRojo, Color.Empty)
        pagina.Appearance.Header.Options.UseForeColor = faltaDato
        pagina.Appearance.HeaderActive.ForeColor = If(faltaDato, estiloRojo, Color.Empty)
        pagina.Appearance.HeaderActive.Options.UseForeColor = faltaDato
    End Sub

#End Region

    Private Shared Function Html(texto As String, colorTexto As Color, negrilla As Boolean) As String
        Dim t As String = texto.Replace("<", "&lt;").Replace(">", "&gt;")
        If negrilla Then t = "<b>" & t & "</b>"
        Return $"<color={colorTexto.R},{colorTexto.G},{colorTexto.B}>{t}</color>"
    End Function

    Private Shared Iterator Function ControlesDeTipo(Of T As Control)(raiz As Control) As IEnumerable(Of T)
        For Each hijo As Control In raiz.Controls
            If TypeOf hijo Is T Then Yield DirectCast(hijo, T)
            For Each nieto In ControlesDeTipo(Of T)(hijo)
                Yield nieto
            Next
        Next
    End Function

End Class

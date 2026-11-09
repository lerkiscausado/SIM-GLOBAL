Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab

''' <summary>
''' Estilo visual de la historia clínica aplicado por código, SIN mover controles del
''' Designer (frmHistoria.Designer.vb queda intacto):
'''  - Tarjeta del paciente más legible (nombre en negrilla, documento destacado).
'''  - Lista de pacientes por atender con buscador, contador y filas más claras.
'''  - Indicador de estado junto a "Firmar": borrador / firmada / enviada a MinSalud / error RDA,
'''    y qué falta para poder firmar (motivo, antecedentes, diagnóstico).
'''  - Pestañas con datos obligatorios vacíos resaltadas en rojo.
'''  - Textos de la historia en fuente más legible.
''' Se llama desde frmHistoria_Load (AplicarEstiloVisual) y al abrir / limpiar una historia
''' (ActualizarIndicadoresHistoria).
''' </summary>
Partial Class frmHistoria

    Private ReadOnly estiloAzul As Color = Color.FromArgb(0, 84, 147)
    Private ReadOnly estiloVerde As Color = Color.FromArgb(25, 135, 84)
    Private ReadOnly estiloRojo As Color = Color.FromArgb(200, 35, 51)
    Private ReadOnly estiloNaranja As Color = Color.FromArgb(214, 120, 0)
    Private ReadOnly estiloTexto As Color = Color.FromArgb(33, 37, 41)
    Private ReadOnly estiloGris As Color = Color.FromArgb(108, 117, 125)

    Private lblEstadoHistoria As LabelControl
    Private estiloAplicado As Boolean

    Private Sub AplicarEstiloVisual()
        If estiloAplicado Then Return
        estiloAplicado = True
        Try
            EstiloTextos()
            EstiloTarjetaPaciente()
            EstiloGrilla(GVPacientesAtender, conBuscador:=True)
            EstiloGrilla(gvHistoriasAnteriores, conBuscador:=False)
            EstiloGrilla(GVDiagnosticos, conBuscador:=False)
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
        Catch
            ' El estilo es cosmético: nunca debe impedir abrir la historia.
        End Try
    End Sub

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

    ''' <summary>Etiqueta junto a "Firmar" con el estado de la historia y lo que falta.</summary>
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

    ''' <summary>Actualiza estado (firma / RDA) y pendientes; se llama al abrir o limpiar una historia.</summary>
    Private Sub ActualizarIndicadoresHistoria()
        ActualizarPendientesFirma()
    End Sub

    Private Sub ActualizarPendientesFirma()
        If lblEstadoHistoria Is Nothing Then Return
        Try
            Dim idOrden As Integer = CInt(Val(lblConsecutivoOrden.Text))
            If idOrden <= 0 Then
                lblEstadoHistoria.Text = ""
                MarcarPestana(xtpMotivoConsulta, False)
                MarcarPestana(xtpAntecedentes, False)
                MarcarPestana(xtpDiagnostico, False)
                Return
            End If

            Dim estado = SIM___GLOBAL.Controles.DRDAPaciente.EstadoHistoriaRDA(idOrden)
            Dim textoEstado As String
            If estado.Firmada Then
                If estado.ErroresPendientes > 0 Then
                    textoEstado = Html("✖ Firmada · envío a MinSalud con error (ver Historial RDA)", estiloRojo, True)
                ElseIf estado.EnviosOk > 0 Then
                    textoEstado = Html("✔ Firmada y enviada a MinSalud", estiloVerde, True)
                Else
                    textoEstado = Html("● Firmada", estiloAzul, True)
                End If
                MarcarPestana(xtpMotivoConsulta, False)
                MarcarPestana(xtpAntecedentes, False)
                MarcarPestana(xtpDiagnostico, False)
                lblEstadoHistoria.Text = textoEstado
                Return
            End If

            textoEstado = Html("● Borrador (sin firmar)", estiloNaranja, True)

            ' Mismos campos que valida bbiGuardar, más el diagnóstico que exige la firma.
            Dim faltaMotivo As Boolean = xtpMotivoConsulta.PageVisible AndAlso String.IsNullOrWhiteSpace(txtMotivoConsulta.Text)
            Dim faltaAntecedentes As Boolean = xtpAntecedentes.PageVisible AndAlso
                (String.IsNullOrWhiteSpace(txtAntecedentesFamiliares.Text) OrElse String.IsNullOrWhiteSpace(txtAntecedentesPersonales.Text))
            Dim faltaDiagnostico As Boolean = GVDiagnosticos.RowCount = 0
            MarcarPestana(xtpMotivoConsulta, faltaMotivo)
            MarcarPestana(xtpAntecedentes, faltaAntecedentes)
            MarcarPestana(xtpDiagnostico, faltaDiagnostico)

            Dim faltantes As New List(Of String)
            If faltaMotivo Then faltantes.Add("motivo de consulta")
            If faltaAntecedentes Then faltantes.Add("antecedentes")
            If faltaDiagnostico Then faltantes.Add("diagnóstico (guarde y agregue al menos uno)")

            If faltantes.Count > 0 Then
                textoEstado &= "   " & Html("Falta para firmar: " & String.Join(", ", faltantes), estiloRojo, False)
            Else
                textoEstado &= "   " & Html("✔ Lista para firmar", estiloVerde, False)
            End If
            lblEstadoHistoria.Text = textoEstado
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

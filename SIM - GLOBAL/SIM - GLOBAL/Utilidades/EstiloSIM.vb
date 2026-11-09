Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab

Namespace Utilidades

    ''' <summary>
    ''' Estilo visual común del SIM (mismo lenguaje de los formularios RDA), aplicado
    ''' automáticamente a TODOS los formularios que se abren — ventanas MDI y diálogos — sin
    ''' tocar sus Designer.
    '''
    ''' Agrega la franja azul de encabezado (AgregarEncabezado) y además:
    '''  - Grillas: filas más altas y alternadas, selección azul suave, encabezados en negrilla.
    '''  - Títulos de grupos y pestaña activa en azul negrita.
    '''  - Campos de texto largo (MemoEdit) en Segoe UI 10.
    '''  - Campos amarillos de solo lectura en azul suave.
    '''
    ''' Uso: EstiloSIM.Activar() una vez al iniciar (frmInicio_Load). Para excluir un formulario,
    ''' poner en su Tag el texto "SinEstiloSIM".
    ''' </summary>
    Public Module EstiloSIM

        Public ReadOnly Azul As Color = Color.FromArgb(0, 84, 147)
        Public ReadOnly AzulSuave As Color = Color.FromArgb(220, 232, 245)
        Public ReadOnly FilaAlterna As Color = Color.FromArgb(246, 248, 251)
        Public ReadOnly Seleccion As Color = Color.FromArgb(207, 226, 255)

        Private activo As Boolean
        Private ReadOnly yaAplicados As New HashSet(Of Integer)()

        ''' <summary>Revisa en cada momento de inactividad si se abrió un formulario nuevo y le aplica el estilo.</summary>
        Public Sub Activar()
            If activo Then Return
            activo = True
            AddHandler Application.Idle, AddressOf RevisarFormulariosAbiertos
        End Sub

        Private Sub RevisarFormulariosAbiertos(sender As Object, e As EventArgs)
            Try
                For Each f As Form In Application.OpenForms
                    Dim id As Integer = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(f)
                    If yaAplicados.Contains(id) Then Continue For
                    yaAplicados.Add(id)
                    If EsFormularioDelSIM(f) Then
                        AgregarEncabezado(f)
                        Aplicar(f)
                        AddHandler f.FormClosed, Sub() yaAplicados.Remove(id)
                    End If
                Next
            Catch
                ' Application.OpenForms puede cambiar mientras se recorre; se reintenta en el próximo Idle.
            End Try
        End Sub

        ''' <summary>Solo formularios propios (no ventanas internas de DevExpress / Windows).</summary>
        Private Function EsFormularioDelSIM(f As Form) As Boolean
            Dim ensamblado As String = f.GetType().Assembly.GetName().Name
            If ensamblado.StartsWith("DevExpress", StringComparison.OrdinalIgnoreCase) OrElse
               ensamblado.StartsWith("System", StringComparison.OrdinalIgnoreCase) OrElse
               ensamblado.StartsWith("CrystalDecisions", StringComparison.OrdinalIgnoreCase) Then Return False
            If TypeOf f.Tag Is String AndAlso CStr(f.Tag) = "SinEstiloSIM" Then Return False
            Return True
        End Function

        ''' <summary>Aplica el estilo común a un formulario (se puede llamar directamente).</summary>
        Public Sub Aplicar(raiz As Control)
            Try
                For Each c As Control In Descendientes(raiz)
                    If TypeOf c Is GridControl Then
                        For Each vista In DirectCast(c, GridControl).Views
                            Dim gv = TryCast(vista, GridView)
                            If gv IsNot Nothing Then EstiloGrilla(gv)
                        Next
                    ElseIf TypeOf c Is GroupControl Then
                        Dim g = DirectCast(c, GroupControl)
                        g.AppearanceCaption.Font = New Font(g.AppearanceCaption.Font, FontStyle.Bold)
                        g.AppearanceCaption.ForeColor = Azul
                        g.AppearanceCaption.Options.UseFont = True
                        g.AppearanceCaption.Options.UseForeColor = True
                    ElseIf TypeOf c Is XtraTabControl Then
                        Dim t = DirectCast(c, XtraTabControl)
                        t.AppearancePage.HeaderActive.Font = New Font(t.AppearancePage.HeaderActive.Font, FontStyle.Bold)
                        t.AppearancePage.HeaderActive.ForeColor = Azul
                        t.AppearancePage.HeaderActive.Options.UseFont = True
                        t.AppearancePage.HeaderActive.Options.UseForeColor = True
                    ElseIf TypeOf c Is MemoEdit Then
                        Dim m = DirectCast(c, MemoEdit)
                        m.Properties.Appearance.Font = New Font("Segoe UI", 10.0!)
                        m.Properties.Appearance.Options.UseFont = True
                        SuavizarAmarillo(m)
                    ElseIf TypeOf c Is TextEdit Then
                        SuavizarAmarillo(DirectCast(c, TextEdit))
                    End If
                Next
            Catch
                ' El estilo es cosmético: nunca debe impedir usar un formulario.
            End Try
        End Sub

        Public Sub EstiloGrilla(gv As GridView)
            gv.RowHeight = Math.Max(gv.RowHeight, 22)
            gv.Appearance.HeaderPanel.Font = New Font(gv.Appearance.HeaderPanel.Font, FontStyle.Bold)
            gv.Appearance.HeaderPanel.Options.UseFont = True
            gv.OptionsView.EnableAppearanceEvenRow = True
            gv.Appearance.EvenRow.BackColor = FilaAlterna
            gv.Appearance.EvenRow.Options.UseBackColor = True
            For Each ap In {gv.Appearance.FocusedRow, gv.Appearance.SelectedRow, gv.Appearance.HideSelectionRow}
                ap.BackColor = Seleccion
                ap.ForeColor = Color.Black
                ap.Options.UseBackColor = True
                ap.Options.UseForeColor = True
            Next
        End Sub

        ''' <summary>Los campos amarillos (solo lectura / destacados) pasan a azul suave con texto azul.</summary>
        Private Sub SuavizarAmarillo(editor As TextEdit)
            Dim ap = editor.Properties.Appearance
            If Not ap.Options.UseBackColor Then Return
            Dim c As Color = ap.BackColor
            Dim esAmarillo As Boolean = c.R >= 235 AndAlso c.G >= 225 AndAlso c.B <= 215
            If Not esAmarillo Then Return
            ap.BackColor = AzulSuave
            ap.ForeColor = Azul
            ap.Options.UseForeColor = True
        End Sub

        ' ── Encabezado azul (como frmHistoria / frmRDA / frmHistorialRDA) ─────────────────

        Public Const AltoEncabezado As Integer = 54

        ''' <summary>Formularios que ya tienen su propio encabezado o que no deben llevarlo.</summary>
        Private ReadOnly SinEncabezado As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
            "frmInicio", "frmHistoria", "frmRDA", "frmHistorialRDA", "frmSesion", "SSPresentacion",
            "frmBienvenida", "frmMensaje", "frmToastRDA", "frmAcercaDe", "frmPrint", "frmPDF", "frmVisorImagenes"}

        ''' <summary>Línea de ayuda debajo del título, para las pantallas de uso diario.</summary>
        Private ReadOnly Ayudas As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"frmOrdenes", "Registre la admisión del paciente: contrato, estudios a realizar y valores."},
            {"frmAgenda", "Programe y consulte las citas del día por especialista."},
            {"frmConsultar", "Busque órdenes y estudios por paciente, fecha o estado."},
            {"frmConsultarEndoscopias", "Busque estudios de endoscopia por paciente, fecha o estado."},
            {"frmEndoscopia", "Informe del procedimiento. Al firmar queda bloqueado para cambios."},
            {"frmEndoscopiaGL", "Informe del procedimiento. Al firmar se envía el resumen (RDA) a MinSalud."},
            {"frmEmpleados", "Personal de la IPS. Documento, nombres y apellidos completos son obligatorios para el RDA."},
            {"frmUsuarios", "Datos del paciente. Documento, nombres, sexo y fecha de nacimiento son necesarios para el RDA."},
            {"frmListadoOrdenes", "Órdenes atendidas pendientes de facturar."},
            {"frmFacturas", "Genere la factura de las órdenes seleccionadas."},
            {"frmRipsJson", "Genere los RIPS en formato JSON para radicar."},
            {"frmContratos", "Contratos con entidades y sus tarifas."},
            {"frmCups", "Catálogo de procedimientos (CUPS)."},
            {"frmDiagnosticos", "Catálogo de diagnósticos (CIE-10)."},
            {"frmIncapacidades", "Registre e imprima incapacidades del paciente."},
            {"frmAnestesia", "Registro de anestesia del procedimiento."},
            {"frmAuditoria", "Revise y audite las órdenes atendidas."},
            {"frmUsers", "Usuarios que ingresan al SIM y su información de acceso."},
            {"frmPrivilegios", "Permisos de cada usuario sobre las opciones del menú."}}

        Private Function DebeLlevarEncabezado(f As Form) As Boolean
            If f.IsMdiContainer OrElse f.FormBorderStyle = FormBorderStyle.None Then Return False
            If SinEncabezado.Contains(f.GetType().Name) OrElse SinEncabezado.Contains(f.Name) Then Return False
            If f.ClientSize.Height < 220 OrElse f.ClientSize.Width < 320 Then Return False
            For Each c As Control In f.Controls
                If c.Name IsNot Nothing AndAlso c.Name.StartsWith("pnlEncabezado", StringComparison.OrdinalIgnoreCase) Then Return False
            Next
            Return True
        End Function

        ''' <summary>
        ''' Agrega la franja azul debajo de las barras de herramientas. El contenido que llena la
        ''' ventana (Dock = Fill) se acomoda solo; los controles con posición fija se bajan el alto
        ''' de la franja. En ventanas maximizadas / internas los anclados abajo se acortan; en
        ''' diálogos se agranda la ventana.
        ''' </summary>
        Public Sub AgregarEncabezado(f As Form)
            If Not DebeLlevarEncabezado(f) Then Return
            f.SuspendLayout()
            Try
                Dim maximizada As Boolean = f.MdiParent IsNot Nothing OrElse f.WindowState = FormWindowState.Maximized

                ' Controles con posición fija: bajarlos.
                Dim relleno As Control = Nothing
                For Each c As Control In f.Controls
                    If c.Dock = DockStyle.Fill AndAlso relleno Is Nothing Then relleno = c
                    If c.Dock <> DockStyle.None Then Continue For
                    c.Top += AltoEncabezado
                    If maximizada AndAlso (c.Anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then
                        c.Height = Math.Max(40, c.Height - AltoEncabezado)
                    End If
                Next
                If Not maximizada Then f.Height += AltoEncabezado

                ' Franja azul.
                Dim titulo As String = TituloLegible(f.Text)
                Dim ayuda As String = Nothing
                Ayudas.TryGetValue(f.GetType().Name, ayuda)

                Dim franja As New Panel With {.Name = "pnlEncabezadoSIM", .Dock = DockStyle.Top, .Height = AltoEncabezado, .BackColor = Azul}
                Dim lblTitulo As New Label With {
                    .AutoSize = True, .ForeColor = Color.White, .BackColor = Color.Transparent,
                    .Font = New Font("Segoe UI", 13.0!, FontStyle.Bold), .Text = titulo,
                    .Location = New Point(14, If(ayuda Is Nothing, 14, 6))}
                franja.Controls.Add(lblTitulo)
                If ayuda IsNot Nothing Then
                    franja.Controls.Add(New Label With {
                        .AutoSize = True, .ForeColor = AzulSuave, .BackColor = Color.Transparent,
                        .Font = New Font("Segoe UI", 9.0!), .Text = ayuda, .Location = New Point(16, 32)})
                End If
                f.Controls.Add(franja)

                ' Orden de acoplamiento: barras (afuera) → franja → contenido de relleno (adentro).
                ' WinForms acopla desde el último índice hacia el 0.
                f.Controls.SetChildIndex(franja, 0)
                If relleno IsNot Nothing Then f.Controls.SetChildIndex(relleno, 0)
            Finally
                f.ResumeLayout(True)
            End Try
        End Sub

        Private Function TituloLegible(texto As String) As String
            Dim t As String = If(texto, "").Trim()
            If t = "" Then Return "SIM"
            ' Títulos en MAYÚSCULAS → "Oración".
            If t = t.ToUpperInvariant() AndAlso t.Any(AddressOf Char.IsLetter) Then
                t = t.ToLowerInvariant()
                t = Char.ToUpperInvariant(t(0)) & t.Substring(1)
            End If
            Return t
        End Function

        Private Iterator Function Descendientes(raiz As Control) As IEnumerable(Of Control)
            For Each hijo As Control In raiz.Controls
                Yield hijo
                For Each nieto In Descendientes(hijo)
                    Yield nieto
                Next
            Next
        End Function

    End Module

End Namespace

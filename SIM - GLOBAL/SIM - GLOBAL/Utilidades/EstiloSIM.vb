Imports System.Drawing
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
    ''' Solo hace cambios "seguros" que no mueven controles ni ensanchan rótulos:
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

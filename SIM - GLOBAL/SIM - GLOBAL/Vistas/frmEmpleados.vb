Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmEmpleados
    Dim _ds As DataSet
    Dim _dEmpleados = New DEmpleados
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _Empleados As New Empleados
    Dim _dCargos = New DCargos
    Dim _dEspecialidades = New DEspecialidades
    Dim _Especialista = New SIM___GLOBAL.Modelo.Especialista
    Dim _DEspecialista = New SIM___GLOBAL.Controles.DEspecialista

    ' Apellidos por separado (paterno/materno), requeridos por RETHUS para el RDA
    ' (ver StructureDefinition-PractitionerRDA). Se agregan por código, no en el
    ' Designer, para no arriesgar el layout visual del formulario.
    Private WithEvents txtPrimerApellido As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtSegundoApellido As DevExpress.XtraEditors.TextEdit

    Private Sub AgregarCamposApellidoRDA()
        If txtPrimerApellido IsNot Nothing Then Exit Sub ' Evitar duplicar si Load se dispara más de una vez

        ' 1. Hacer espacio: correr hacia abajo lo que va después del campo de firma
        ' (peFirma termina en y=254; chkEstado/SeparatorControl1 arrancan justo ahí).
        Const desplazamiento As Integer = 80
        chkEstado.Location = New Point(chkEstado.Location.X, chkEstado.Location.Y + desplazamiento)
        SeparatorControl1.Location = New Point(SeparatorControl1.Location.X, SeparatorControl1.Location.Y + desplazamiento)
        GCConsultar.Location = New Point(GCConsultar.Location.X, GCConsultar.Location.Y + desplazamiento)
        Me.ClientSize = New Size(Me.ClientSize.Width, Me.ClientSize.Height + desplazamiento)

        ' 2. Etiquetas + campos, en el espacio liberado justo debajo de la firma (que
        ' termina en y=254), antes de donde ahora quedó chkEstado (234+80=314).
        Dim lblPrimerApellido As New DevExpress.XtraEditors.LabelControl()
        lblPrimerApellido.Text = "Primer Apellido"
        lblPrimerApellido.Location = New Point(16, 260)

        Dim lblSegundoApellido As New DevExpress.XtraEditors.LabelControl()
        lblSegundoApellido.Text = "Segundo Apellido"
        lblSegundoApellido.Location = New Point(16, 286)

        txtPrimerApellido = New DevExpress.XtraEditors.TextEdit()
        txtPrimerApellido.Location = New Point(101, 257)
        txtPrimerApellido.Size = New Size(290, 20)

        txtSegundoApellido = New DevExpress.XtraEditors.TextEdit()
        txtSegundoApellido.Location = New Point(101, 283)
        txtSegundoApellido.Size = New Size(290, 20)

        Me.Controls.Add(lblPrimerApellido)
        Me.Controls.Add(txtPrimerApellido)
        Me.Controls.Add(lblSegundoApellido)
        Me.Controls.Add(txtSegundoApellido)
    End Sub

    ''' <summary>
    ''' Fuerza el texto de un TextEdit a mayúsculas mientras el usuario escribe (evita
    ''' advertencias de MinSalud por diferencias de mayúsculas al validar contra RETHUS).
    ''' </summary>
    Private Sub ForzarMayusculas(editor As DevExpress.XtraEditors.TextEdit)
        Dim mayusculas As String = editor.Text.ToUpper()
        If editor.Text <> mayusculas Then
            Dim posicionCursor As Integer = editor.SelectionStart
            editor.Text = mayusculas
            editor.SelectionStart = posicionCursor
        End If
    End Sub

    Private Sub txtPrimerApellido_EditValueChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.EditValueChanged
        ForzarMayusculas(txtPrimerApellido)
        ActivarGuardar()
    End Sub

    Private Sub txtSegundoApellido_EditValueChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.EditValueChanged
        ForzarMayusculas(txtSegundoApellido)
        ActivarGuardar()
    End Sub

    '------------------------------------------------------------------------------
    Private Sub Guardar()
        Try
            ' ── 1. MEJORA: Función separada para mapear el modelo ────────
            ' Antes: los campos se asignaban directamente en Guardar()
            ' Ahora: se centraliza en una función reutilizable
            MapearEmpleado()

            ' ── 2. Guardar empleado ──────────────────────────────────────
            _dEmpleados.Guardar(_Empleados)

            ' ── 3. MEJORA: Se evalúa el cargo una sola vez ───────────────
            ' Antes: cboCargo.GetColumnValue("CARGO") se llamaba dos veces
            Dim esEspecialista As Boolean = (cboCargo.GetColumnValue("CARGO").ToString().Trim().ToUpper() = "ESPECIALISTA")

            If esEspecialista Then
                ' ── 4. MEJORA: Función separada para mapear el especialista
                ' Antes: los campos se repetían en el If y en el Else
                MapearEspecialista()

                ' ── 5. MEJORA: Se determina si es nuevo o edición por Id ─
                ' Antes: se comparaba txtID.Text = "" lo cual es frágil
                Dim esNuevo As Boolean = String.IsNullOrEmpty(txtID.Text.Trim())

                If esNuevo Then
                    ' Nuevo especialista: Id en 0 porque la BD lo genera
                    _Especialista.id = 0
                    _DEspecialista.guardar2(_Especialista)
                Else
                    ' Especialista existente: actualizar por idespecialista
                    _DEspecialista.actualizar(_Especialista)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    ' ── Mapear datos del formulario al modelo Empleado ───────────────
    Private Sub MapearEmpleado()
        _Empleados.Id = If(String.IsNullOrEmpty(txtID.Text.Trim()), 0, Val(txtID.Text))
        _Empleados.NombreEmpleado = txtNombre.Text.Trim()
        _Empleados.IdCargo = cboCargo.GetColumnValue("ID")
        _Empleados.IdEspecialidad = cboEspecialidad.GetColumnValue("ID")
        _Empleados.RegistroMedico = txtRegistroMedico.Text.Trim()

        ' MEJORA: Expresión ternaria en lugar de If/Else para el estado
        _Empleados.Estado = If(chkEstado.Checked, "A", "I")
    End Sub

    ' ── Mapear datos del formulario al modelo Especialista ───────────
    Private Sub MapearEspecialista()
        ' MEJORA: Los campos comunes al Insert y Update se asignan
        ' en un solo lugar, eliminando la duplicación de código
        _Especialista.idespecialista = Val(_dEmpleados.ultimoregistroempleado)
        _Especialista.idtipoidentificacion = "CC"
        _Especialista.identificacion = txtIdentificacion.Text.Trim()
        _Especialista.nombre = txtNombre.Text.Trim()
        _Especialista.especialidad = cboEspecialidad.GetColumnValue("ESPECIALIDAD").ToString()
        _Especialista.registromedico = txtRegistroMedico.Text.Trim()
        _Especialista.estado = "A"

        ' Nombre estructurado para RDA/RETHUS: txtNombre se sigue usando tal cual para
        ' "nombres" (primer/segundo nombre combinados en un solo campo, como siempre),
        ' y se agregan los 2 campos nuevos de apellido paterno/materno por separado.
        Dim partesNombre = txtNombre.Text.Trim().ToUpper().Split(New Char() {" "c}, 2, StringSplitOptions.RemoveEmptyEntries)
        _Especialista.PrimerNombre = If(partesNombre.Length > 0, partesNombre(0), "")
        _Especialista.SegundoNombre = If(partesNombre.Length > 1, partesNombre(1), "")
        _Especialista.PrimerApellido = txtPrimerApellido.Text.Trim().ToUpper()
        _Especialista.SegundoApellido = txtSegundoApellido.Text.Trim().ToUpper()
    End Sub
    '------------------------------------------------------------------------------
    Private Sub ActivarGuardar()
        If txtNombre.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dEmpleados.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarCamposApellidoRDA()
        peFirma.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        ActualizarGrilla()

        'llenamos campo Cargos
        _ds = New DataSet()
        _ds = _dCargos.ListarCombo()
        cboCargo.Properties.DataSource = _ds.Tables(0)
        cboCargo.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboCargo.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboCargo.ItemIndex = -1

        bbiGuardar.Enabled = False
        chkEstado.Checked = True

    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtIdentificacion.Text = ""
        txtRegistroMedico.Text = ""
        cboCargo.EditValue = Nothing
        cboEspecialidad.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboCargo.Text = "" Then
            MessageBox.Show("Debe seleccionar el cargo", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboEspecialidad.Text = "" Then
            MessageBox.Show("Debe seleccionar la especialidad", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("No ha seleccionado el empleado", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                If MessageBox.Show("Desea Editar el Empleado?", "Editar Registros ",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
             = DialogResult.Yes Then
                    'txtCodigo.Enabled = False
                    _Empleados = _dEmpleados.Cargar(_ClickGrilla)
                    txtID.Text = _ClickGrilla
                    txtNombre.Text = _Empleados.NombreEmpleado
                    cboCargo.ItemIndex = cboCargo.Properties.GetDataSourceRowIndex("ID", _Empleados.IdCargo)
                    txtIdentificacion.Text = _DEspecialista.traeridentificacion(_ClickGrilla)
                    Dim nombreEstructurado = _DEspecialista.TraerNombreEstructurado(_ClickGrilla)
                    txtPrimerApellido.Text = nombreEstructurado.PrimerApellido
                    txtSegundoApellido.Text = nombreEstructurado.SegundoApellido
                    cboEspecialidad.ItemIndex = cboEspecialidad.Properties.GetDataSourceRowIndex("ID", _Empleados.IdEspecialidad)
                    txtRegistroMedico.Text = _Empleados.RegistroMedico
                    If _Empleados.Estado = "I" Then
                        chkEstado.Checked = False
                    Else
                        chkEstado.Checked = True
                    End If
                    bbiGuardar.Enabled = False
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ForzarMayusculas(txtNombre)
        bbiGuardar.Enabled = True
    End Sub

    Private Sub cboCargo_EditValueChanged(sender As Object, e As EventArgs) Handles cboCargo.EditValueChanged
        Try
            Dim valorSeleccionado As String = cboCargo.Text.Trim().ToUpper()

            If valorSeleccionado = "ESPECIALISTA" Then
                txtIdentificacion.Enabled = True
                cboEspecialidad.Enabled = True
                txtRegistroMedico.Enabled = True
                txtIdentificacion.Focus()
                'llenamos campo Especialidad
                _ds = New DataSet()
                _ds = _dEspecialidades.ListarEspecialista()
                cboEspecialidad.Properties.DataSource = _ds.Tables(0)
                cboEspecialidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
                cboEspecialidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
                'cboEspecialidad.ItemIndex = -1
            Else
                txtIdentificacion.Enabled = False
                cboEspecialidad.Enabled = False
                txtRegistroMedico.Enabled = False
                txtIdentificacion.Text = ""
                txtRegistroMedico.Text = ""
                'llenamos campo Especialidad
                _ds = New DataSet()
                _ds = _dEspecialidades.ListarEmpleado()
                cboEspecialidad.Properties.DataSource = _ds.Tables(0)
                cboEspecialidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
                cboEspecialidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
                cboEspecialidad.ItemIndex = 0
            End If
            ActivarGuardar()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub cboEspecialidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboEspecialidad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtRegistroMedico_EditValueChanged(sender As Object, e As EventArgs) Handles txtRegistroMedico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub
End Class
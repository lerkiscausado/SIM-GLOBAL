Public Class frmPrivilegios
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _Dusers As New SIM___GLOBAL.Controles.DUsers
    Dim _ds As DataSet

    Private Sub Guardar()
        'ORDENES DE ATENCION
        _Users.IdEmpleado = _ClickGrilla
        _Users.Nuevo = chkNuevo.CheckState
        _Users.Editar = chkEditar.CheckState
        _Users.Anular = chkAnular.CheckState
        _Users.Consultar = chkConsultar.CheckState
        _Users.Adjuntos = chkAdjuntos.CheckState
        _Users.Agenda = chkAgenda.CheckState
        'ESTUDIOS
        _Users.HistoriaClinica = chkHistoriaClinica.CheckState
        _Users.HistoriaAnteriores = chkHistoriasAnteriores.CheckState
        _Users.HistoriaGrupal = chkHistoriaGrupal.CheckState
        _Users.EvolucionPaciente = chkEvolucionPaciente.CheckState
        _Users.ProgramacionCirugia = chkProgramacionProcedimientos.CheckState
        _Users.Citologia = chkCitologia.CheckState
        _Users.Patologia = chkPatologia.CheckState
        _Users.Endoscopia = chkEndoscopia.CheckState
        _Users.AdjuntarImagenes = chkImagenes.CheckState
        'CONTABLE
        _Users.ListadoOrdenes = chkListadoOrdenes.CheckState
        _Users.GenerarFactura = chkGenerarFactura.CheckState
        _Users.Rips = chkRips.CheckState
        _Users.Inventario = chkInventario.CheckState
        _Users.Nomina = chkNomina.CheckState
        'REPORTES
        _Users.VistaPrevia = chkVistaPrevia.CheckState
        _Users.Imprimir = chkImprimir.CheckState
        _Users.IndicadoresGestion = chkIndicadoresGestion.CheckState
        'PACIENTES
        _Users.Usuarios = chkUsuarios.CheckState
        'CONTRATACION
        _Users.Entidades = chkEntidades.CheckState
        _Users.SubEntidades = chkSubEntidades.CheckState
        _Users.Contratos = chkContratos.CheckState
        _Users.Tarifas = chkTarifas.CheckState
        _Users.DetalleTarifas = chkDetalleTarifas.CheckState
        'TALENTO HUMANO
        _Users.Cargos = chkCargos.CheckState
        _Users.Especialidades = chkEspecialidades.CheckState
        _Users.Empleados = chkEmpleados.CheckState
        'COMPLEMENTOS
        _Users.Examenes = chkExamenes.CheckState
        _Users.Medicamentos = chkMedicamentos.CheckState
        _Users.Cups = chkCUPS.CheckState
        _Users.Cie10 = chkCIE10.CheckState
        _Users.TipoPatologia = chkTipoPatologia.CheckState
        _Users.EstudiosPredeterminados = chkEstudiosPredeterminados.CheckState
        _Users.equiposapoyo = chkEquiposApoyo.CheckState
        'REPORTES
        _Users.EncabezadoPiedepagina = chkEncabezadoPiePagina.CheckState
        _Users.Logo = chkLogo.CheckState
        _Users.Firma = chkFirma.CheckState
        'SISTEMA
        _Users.Users = chkUsers.CheckState
        'chkSeguridad.checkstate = True
        _Users.Privilegios = chkPrivilegios.CheckState
        'CONTENIDO SIM
        _Users.AyudaProducto = chkAyudaProducto.CheckState
        _Users.SoporteTecnico = chkSoporteTecnico.CheckState
        _Users.Tutoriales = chkTutoriales.CheckState
        _Users.Acercade = chkAcercaDe.CheckState
        _Dusers.GuardarPrivilegios(_Users)
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Editar()
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No se ha Seleccionado Paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'LimpiarCampos()
                txtDatosUsuario.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE_EMPLEADO").ToString() & vbCrLf _
                    & GVConsultar.GetRowCellValue(_Fila, "NOMBRE_CARGO").ToString()
                _Users = _Dusers.Cargar(_ClickGrilla)
                '*****************************
                'ORDENES DE ATENCION
                chkNuevo.Checked = _Users.Nuevo
                chkEditar.Checked = _Users.Editar
                chkAnular.Checked = _Users.Anular
                chkConsultar.Checked = _Users.Consultar
                chkAdjuntos.Checked = False '_Users.Adjuntos
                chkAgenda.Checked = _Users.Agenda
                'ESTUDIOS
                chkHistoriaClinica.Checked = _Users.HistoriaClinica
                chkHistoriasAnteriores.Checked = _Users.HistoriaAnteriores
                chkHistoriaGrupal.Checked = _Users.HistoriaGrupal
                chkEvolucionPaciente.Checked = _Users.EvolucionPaciente
                chkProgramacionProcedimientos.Checked = _Users.ProgramacionCirugia
                chkCitologia.Checked = _Users.Citologia
                chkPatologia.Checked = _Users.Patologia
                chkEndoscopia.Checked = _Users.Endoscopia
                chkImagenes.Checked = _Users.AdjuntarImagenes
                'CONTABLE
                chkListadoOrdenes.Checked = _Users.ListadoOrdenes
                chkGenerarFactura.Checked = _Users.GenerarFactura
                chkRips.Checked = _Users.Rips
                'inventario = _Users.Inventario
                'nomina = _Users.Nomina
                'REPORTES
                chkVistaPrevia.Checked = _Users.VistaPrevia
                chkImprimir.Checked = _Users.Imprimir
                'Indicadores = _Users.IndicadoresGestion
                'PACIENTES
                chkUsuarios.Checked = _Users.Usuarios
                'CONTRATACION
                chkEntidades.Checked = _Users.Entidades
                chkSubEntidades.Checked = _Users.SubEntidades
                chkContratos.Checked = _Users.Contratos
                chkTarifas.Checked = _Users.Tarifas
                chkDetalleTarifas.Checked = _Users.DetalleTarifas
                'TALENTO HUMANO
                chkCargos.Checked = _Users.Cargos
                chkEspecialidades.Checked = _Users.Especialidades
                chkEmpleados.Checked = _Users.Empleados
                'COMPLEMENTOS
                chkExamenes.Checked = _Users.Examenes
                chkMedicamentos.Checked = _Users.Medicamentos
                chkCUPS.Checked = _Users.Cups
                chkCIE10.Checked = _Users.Cie10
                chkTipoPatologia.Checked = _Users.TipoPatologia
                chkEstudiosPredeterminados.Checked = _Users.EstudiosPredeterminados
                chkEquiposApoyo.Checked = _Users.EquiposApoyo
                'REPORTES
                chkEncabezadoPiePagina.Checked = _Users.EncabezadoPiedepagina
                chkLogo.Checked = _Users.Logo
                chkFirma.Checked = _Users.Firma
                'SISTEMA
                chkUsers.Checked = _Users.Users
                chkSeguridad.Checked = True
                chkPrivilegios.Checked = _Users.Privilegios
                'CONTENIDO SIM
                chkAyudaProducto.Checked = _Users.AyudaProducto
                chkSoporteTecnico.Checked = _Users.SoporteTecnico
                chkTutoriales.Checked = _Users.Tutoriales
                chkAcercaDe.Checked = _Users.Acercade
                bbiGuardar.Enabled = False
                '******************************
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ActivaGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub ActualizarGrilla()
        'llenamos GRILLA
        _ds = New DataSet()
        _ds = _Dusers.ListarUsuariosPrivilegios
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmPrivilegios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()

    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID_EMPLEADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Editar()
    End Sub

    Private Sub chkNuevo_EditValueChanged(sender As Object, e As EventArgs) Handles chkNuevo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEditar_EditValueChanged(sender As Object, e As EventArgs) Handles chkEditar.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkAnular_EditValueChanged(sender As Object, e As EventArgs) Handles chkAnular.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkConsultar_EditValueChanged(sender As Object, e As EventArgs) Handles chkConsultar.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkAdjuntos_EditValueChanged(sender As Object, e As EventArgs) Handles chkAdjuntos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkAgenda_EditValueChanged(sender As Object, e As EventArgs) Handles chkAgenda.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkHistoriaClinica_EditValueChanged(sender As Object, e As EventArgs) Handles chkHistoriaClinica.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkHistoriasAnteriores_EditValueChanged(sender As Object, e As EventArgs) Handles chkHistoriasAnteriores.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkHistoriaGrupal_EditValueChanged(sender As Object, e As EventArgs) Handles chkHistoriaGrupal.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEvolucionPaciente_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles chkEvolucionPaciente.EditValueChanging
        ActivaGuardar()
    End Sub

    Private Sub chkProgramacionProcedimientos_EditValueChanged(sender As Object, e As EventArgs) Handles chkProgramacionProcedimientos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCitologia_EditValueChanged(sender As Object, e As EventArgs) Handles chkCitologia.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkPatologia_EditValueChanged(sender As Object, e As EventArgs) Handles chkPatologia.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkImagenes_EditValueChanged(sender As Object, e As EventArgs) Handles chkImagenes.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkListadoOrdenes_EditValueChanged(sender As Object, e As EventArgs) Handles chkListadoOrdenes.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkGenerarFactura_EditValueChanged(sender As Object, e As EventArgs) Handles chkGenerarFactura.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkRips_EditValueChanged(sender As Object, e As EventArgs) Handles chkRips.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkInventario_EditValueChanged(sender As Object, e As EventArgs) Handles chkInventario.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkNomina_EditValueChanged(sender As Object, e As EventArgs) Handles chkNomina.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkVistaPrevia_EditValueChanged(sender As Object, e As EventArgs) Handles chkVistaPrevia.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkImprimir_EditValueChanged(sender As Object, e As EventArgs) Handles chkImprimir.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkIndicadoresGestion_EditValueChanged(sender As Object, e As EventArgs) Handles chkIndicadoresGestion.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkUsuarios_EditValueChanged(sender As Object, e As EventArgs) Handles chkUsuarios.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEntidades_EditValueChanged(sender As Object, e As EventArgs) Handles chkEntidades.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkContratos_EditValueChanged(sender As Object, e As EventArgs) Handles chkContratos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkTarifas_EditValueChanged(sender As Object, e As EventArgs) Handles chkTarifas.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkDetalleTarifas_EditValueChanged(sender As Object, e As EventArgs) Handles chkDetalleTarifas.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCargos_EditValueChanged(sender As Object, e As EventArgs) Handles chkCargos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEspecialidades_EditValueChanged(sender As Object, e As EventArgs) Handles chkEspecialidades.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEmpleados_EditValueChanged(sender As Object, e As EventArgs) Handles chkEmpleados.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkExamenes_EditValueChanged(sender As Object, e As EventArgs) Handles chkExamenes.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkMedicamentos_EditValueChanged(sender As Object, e As EventArgs) Handles chkMedicamentos.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCUPS_EditValueChanged(sender As Object, e As EventArgs) Handles chkCUPS.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkCIE10_EditValueChanged(sender As Object, e As EventArgs) Handles chkCIE10.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkTipoPatologia_EditValueChanged(sender As Object, e As EventArgs) Handles chkTipoPatologia.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEstudiosPredeterminados_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstudiosPredeterminados.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEncabezadoPiePagina_EditValueChanged(sender As Object, e As EventArgs) Handles chkEncabezadoPiePagina.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkLogo_EditValueChanged(sender As Object, e As EventArgs) Handles chkLogo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkFirma_EditValueChanged(sender As Object, e As EventArgs) Handles chkFirma.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkUsers_EditValueChanged(sender As Object, e As EventArgs) Handles chkUsers.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkSeguridad_EditValueChanged(sender As Object, e As EventArgs) Handles chkSeguridad.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkPrivilegios_EditValueChanged(sender As Object, e As EventArgs) Handles chkPrivilegios.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkAyudaProducto_EditValueChanged(sender As Object, e As EventArgs) Handles chkAyudaProducto.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkSoporteTecnico_EditValueChanged(sender As Object, e As EventArgs) Handles chkSoporteTecnico.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkTutoriales_EditValueChanged(sender As Object, e As EventArgs) Handles chkTutoriales.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkAcercaDe_EditValueChanged(sender As Object, e As EventArgs) Handles chkAcercaDe.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        Guardar()
    End Sub

    Private Sub chkEquiposApoyo_EditValueChanged(sender As Object, e As EventArgs) Handles chkEquiposApoyo.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub chkEndoscopia_EditValueChanged(sender As Object, e As EventArgs) Handles chkEndoscopia.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GVConsultar.DoubleClick
        Editar()
    End Sub

    Private Sub chkSubEntidades_EditValueChanged(sender As Object, e As EventArgs) Handles chkSubEntidades.EditValueChanged
        ActivaGuardar()
    End Sub
End Class
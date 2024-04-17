Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenesMedicas
    ReadOnly _funciones As New Funciones
    Public Licencia As String
    Public IdEmpleado As String
    Public IdOrden As String
    Public IdDetalleOrden As String
    Public TipoEstudio As String
    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        Select Case Licencia
            'Case 1 'ADOS SOFTWARE & DISEÑO
            'Case 2 'LABORATORIO DE INMUNOPATOLOGICO DE LA COSTA
            Case 3 'DITEG SAS
                ' Impresion de Historias
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                _funciones.ImprimirHistoria(IdDetalleOrden, IdEmpleado)
                ImprimirFrm.ImprimirEstudios(IdOrden, IdDetalleOrden, Reporte, Fotos, Licencia, TipoEstudio, VistaPrevia)
                'If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' Reporte = 1
                ' Else
                ' Reporte = 0
                ' End If
                ' ' Impresion endoscopia endoscopias
                ' _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ' ImpresionEndoscopia(IdDetalleOrden)
               ' ImprimirFrm.ImprimirEstudios(IdOrden, IdDetalleOrden, Reporte, Fotos, Licencia, "CONSULTA PRIMERA VEZ", VistaPrevia)
            Case 4 'GASTROLAP
                ' Impresion de Historias
                _dImpresionHistoria.EliminarHistoria(IdEmpleado)
                _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleado)
                _funciones.ImprimirHistoria(IdDetalleOrden, IdEmpleado)
                ImprimirFrm.ImprimirEstudios(IdOrden, IdDetalleOrden, Reporte, Fotos, Licencia, TipoEstudio, VistaPrevia)
                'If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' Reporte = 1
                ' Else
                ' Reporte = 0
                ' End If
                ' ' Impresion endoscopia endoscopias
                ' _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleado)
                ' ImpresionEndoscopia(IdDetalleOrden)
                ' ImprimirFrm.ImprimirEstudios(IdOrden, IdDetalleOrden, Reporte, Fotos, Licencia, "CONSULTA PRIMERA VEZ", VistaPrevia)
        End Select
    End Sub

    Private Sub frmOrdenesMedicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sbCancelar_Click(sender As Object, e As EventArgs) Handles sbCancelar.Click
        Me.Close()
    End Sub

    Private Sub sbLaboratorios_Click(sender As Object, e As EventArgs) Handles sbLaboratorios.Click
        _funciones.ImprimirOrdenesMedicas(IdOrden, IdDetalleOrden, "CONSULTA PRIMERA VEZ", Licencia, "LABORATORIOS")
    End Sub

    Private Sub sbProcedimientos_Click(sender As Object, e As EventArgs) Handles sbProcedimientos.Click
        _funciones.ImprimirOrdenesMedicas(IdOrden, IdDetalleOrden, "CONSULTA PRIMERA VEZ", Licencia, "PROCEDIMIENTOS")
    End Sub

    Private Sub sbImagenes_Click(sender As Object, e As EventArgs) Handles sbImagenes.Click
        _funciones.ImprimirOrdenesMedicas(IdOrden, IdDetalleOrden, "CONSULTA PRIMERA VEZ", Licencia, "ESTUDIOS DIAGNOSTICOS")
    End Sub

    Private Sub sbMedicamentos_Click(sender As Object, e As EventArgs) Handles sbMedicamentos.Click
        _funciones.ImprimirOrdenesMedicas(IdOrden, IdDetalleOrden, "CONSULTA PRIMERA VEZ", Licencia, "MEDICAMENTOS")
    End Sub

    Private Sub sbHistoria_Click(sender As Object, e As EventArgs) Handles sbHistoria.Click
        ImpresionResultados("0", True)
    End Sub
End Class
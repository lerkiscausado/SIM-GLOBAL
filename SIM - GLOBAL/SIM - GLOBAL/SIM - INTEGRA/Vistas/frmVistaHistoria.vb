Public Class frmVistaHistoria
    Public IdDetalleOrden As String
    Dim _dhistoria As New SIM___INTEGRA.Controles.DHistoriaIntegra
    Private Sub frmVistaHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _ds As DataSet
        _ds = _dhistoria.VistaPreviaHistoria(IdDetalleOrden)


        lblID.Text = _ds.Tables(0).Rows(0)(0).ToString
        lblUsuario.Text = _ds.Tables(0).Rows(0)(1).ToString
        lblIdentificacion.Text = _ds.Tables(0).Rows(0)(2).ToString
        lblSexo.Text = _ds.Tables(0).Rows(0)(3).ToString
        lblEdad.Text = _ds.Tables(0).Rows(0)(4).ToString
        lblTelefono.Text = _ds.Tables(0).Rows(0)(5).ToString
        lblDireccion.Text = _ds.Tables(0).Rows(0)(6).ToString

        lblOrden.Text = _ds.Tables(0).Rows(0)(7).ToString
        lblFecha.Text = Mid(_ds.Tables(0).Rows(0)(8).ToString, 1, 10)
        lblHora.Text = _ds.Tables(0).Rows(0)(9).ToString
        lblContrato.Text = _ds.Tables(0).Rows(0)(10).ToString

        lblEspecialista.Text = _ds.Tables(0).Rows(0)(11).ToString
        lblEspecialidad.Text = _ds.Tables(0).Rows(0)(12).ToString
        lblConsulta.Text = _ds.Tables(0).Rows(0)(22).ToString & " - " & _ds.Tables(0).Rows(0)(23).ToString
        If _ds.Tables(0).Rows(0)(13).ToString = "C" Then
            lblHistoria.Text = "CONSULTA DE CONTROL"
            txtReporte.Text = "EVOLUCION: " & vbCrLf & _ds.Tables(0).Rows(0)(19).ToString & vbCrLf & vbCrLf _
                & "REMISION:" & vbCrLf & _ds.Tables(0).Rows(0)(20).ToString


        Else
            lblHistoria.Text = "CONSULTA PRIMERA VEZ"
            txtReporte.Text = "MOTIVO DE CONSULTA: " & vbCrLf & _ds.Tables(0).Rows(0)(14).ToString & vbCrLf & vbCrLf _
                & "ANTECEDENTES PERSONALES:" & vbCrLf & _ds.Tables(0).Rows(0)(15).ToString & vbCrLf & vbCrLf _
                & "ANTECEDENTES FAMILIARES:" & vbCrLf & _ds.Tables(0).Rows(0)(16).ToString & vbCrLf & vbCrLf _
                & "VALORACION:" & vbCrLf & _ds.Tables(0).Rows(0)(17).ToString & vbCrLf & vbCrLf _
                & "PLAN A SEGUIR:" & vbCrLf & _ds.Tables(0).Rows(0)(18).ToString & vbCrLf & vbCrLf _
                & "REMISION:" & vbCrLf & _ds.Tables(0).Rows(0)(20).ToString
        End If
        lblEstado.Text = _ds.Tables(0).Rows(0)(24).ToString


    End Sub
End Class
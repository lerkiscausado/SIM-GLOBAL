Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmPrueba3
    Dim _ds As DataSet
    Dim _dDecimales As New DDecimales
    Dim _Decimales As New Decimales
    Dim texto As String
    Private Sub Guardar()
        Try
            _Decimales.Id = 0
            _Decimales.Flotante = txtFlotante.Text
            _Decimales.Doble = txtDoble.Text
            _Decimales.Decimal = txtDecimal.Text
            _dDecimales.Guardar(_Decimales)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Cargar()
        _Decimales = _dDecimales.Cargar("20")
        txtF.Text = _Decimales.Flotante
        txtD.Text = _Decimales.Doble
        txtDe.Text = _Decimales.Decimal

    End Sub
    Private Sub frmPrueba3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim json As String
        'json =[{
        '    "id":1,
        '    "nombre":"Lerkis Causado"
        '}]
        'JsonDataSource jsonDataSource = New JsonDataSource();
        'jsonDataSource.JsonSource = New CustomJsonSource(jsonString);
        'jsonDataSource.Fill();'

        'gridControl1.DataSource = jsonDataSource;
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Guardar()
        ACPrueba.Show(Me, "Titulo", "Mensaje 1", "", PictureEdit1.Image, "mensaje")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cargar()
        texto = rtbPrueba.WordMLText
        txtPrueba.Text = rtbPrueba.HtmlText
        MemoEdit1.Text = rtbPrueba.RtfText
        'MemoEdit1.Text=rtbPrueba.MhtText

        'peFoto.Image = rtbPrueba.DocBytes

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rtbResultado.HtmlText = txtPrueba.Text
    End Sub


End Class


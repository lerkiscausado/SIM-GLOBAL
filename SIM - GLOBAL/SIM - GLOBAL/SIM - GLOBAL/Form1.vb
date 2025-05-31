Public Class Form1
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim peso As Double = txtPeso.Text
        Dim talla As Double = txtTalla.Text
        MsgBox(txtPeso.Text)
        txtIMC.Text = peso / ((talla / 100) ^ 2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ReportePatologiaCD' Puede moverla o quitarla según sea necesario.
        'Me.ReportePatologiaCDTableAdapter1.Fill(Me.DataSet1.ReportePatologiaCD)
        'TODO: esta línea de código carga datos en la tabla 'DtReportePatologiaCD.ReportePatologiaCD' Puede moverla o quitarla según sea necesario.
        'Me.ReportePatologiaCDTableAdapter.Fill(Me.DtReportePatologiaCD.ReportePatologiaCD)
        txtPeso.Text = 40.5
        txtTalla.Text = "175"
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'DtPatologiaCD.ReportePatologiaCD' Puede moverla o quitarla según sea necesario.
        ' Me.ReportePatologiaCDTableAdapter.Fill(Me.DtPatologiaCD.ReportePatologiaCD)

    End Sub

    Private Sub Form1_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCD.ReportePatologiaCD' Puede moverla o quitarla según sea necesario.
        Me.ReportePatologiaCDTableAdapter2.Fill(Me.DsCD.ReportePatologiaCD)

    End Sub
End Class

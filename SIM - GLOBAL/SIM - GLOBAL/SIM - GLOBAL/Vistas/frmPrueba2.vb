Imports System.Runtime.InteropServices
Public Class frmPrueba2
    Dim speller As Object
    Dim txt As String
    Dim new_txt As String
    Dim pos As Integer

    Private Sub frmPrueba2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        wbChat.DocumentText = "
            <body style='font-family:Segoe UI, Tahoma, Geneva, Verdana, sans-serif; padding: 5px; background-image: url(http://ados-software.com/publicidad/fondo_soporte.png); '>
               <div style='text-align:left; background-color:white; border-radius: 0px 5px 5px 5px; width: 70%; padding: 5px 5px 5px 15px;'>
                    <p><strong>Marilenis:</strong></p>
                    <input type='text' name='nombre'/>                    
                    <p>buenas tardes, en uno de nuestros dominios instalamos wordpress con el plging de contact form 7 el cual en otros proyectos me ha funcionado de maravilla
                    me gustaria saber si existe algun bloqueo del servidor por el cual no me esta dejando enviar el mail del formulario gracias</p>
               </div>
                <br>
                <div style='text-align:right; background-color:#FFD6D9; border-radius: 5px 0px 5px 5px; margin-left: 30%; padding: 5px 15px 5px 5px; '>
                    <p><strong>Crispeta:</strong></p>
                    <p>Realmente no existe ningún bloque de parte nuestra para este tipo de plugin, sin embargo debe tener en cuenta que en Conexcol no está permitido el envío de correo bajo phpmail, es decir, ud puede usar PHPmailer siempre y cuando lo configure bajo SMTP. Aquí podrá encontrar más información sobre esto:
                    </p>
                </div>
            </body>"
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        ImprimirFrm.ImprimirEjemplo()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TextEdit1.Text = SpellChecker1.Check(TextEdit1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyData = Keys.Control + Keys.Q Then
            'TextBox1.Text = TextBox1.Text + " La chacara"
        End If
        ' MsgBox("Hola")
        'End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs)
        'MsgBox(e.KeyCode)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
End Class
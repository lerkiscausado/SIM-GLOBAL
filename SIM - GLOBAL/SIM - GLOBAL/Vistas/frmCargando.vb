Public Class frmCargando

    ' Propiedad para cambiar el mensaje principal
    Public Property Mensaje As String
        Get
            Return lblMensaje.Text
        End Get
        Set(value As String)
            If lblMensaje.InvokeRequired Then
                lblMensaje.Invoke(Sub() lblMensaje.Text = value)
            Else
                lblMensaje.Text = value
            End If
        End Set
    End Property

    ' Propiedad para cambiar la descripción (opcional)
    Public Property Descripcion As String
        Get
            Return lblMensaje.Text
        End Get
        Set(value As String)
            If lblMensaje.InvokeRequired Then
                lblMensaje.Invoke(Sub() lblMensaje.Text = value)
            Else
                lblMensaje.Text = value
            End If
        End Set
    End Property

End Class
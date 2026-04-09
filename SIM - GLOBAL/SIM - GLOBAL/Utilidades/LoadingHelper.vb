Namespace Utilidades
    Public Class LoadingHelper
        Private Shared _frmCargando As frmCargando

        Public Shared Sub Mostrar(ByVal owner As Form,
                              Optional ByVal mensaje As String = "Por favor espere...",
                              Optional ByVal descripcion As String = "Cargando...")
            Try
                _frmCargando = New frmCargando()
                _frmCargando.Mensaje = mensaje
                _frmCargando.Descripcion = descripcion
                _frmCargando.Show(owner)
                Application.DoEvents()
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Sub ActualizarMensaje(ByVal mensaje As String,
                                        Optional ByVal descripcion As String = "")
            Try
                If _frmCargando IsNot Nothing Then
                    _frmCargando.Mensaje = mensaje
                    If descripcion <> "" Then
                        _frmCargando.Descripcion = descripcion
                    End If
                    Application.DoEvents()
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Sub Ocultar()
            Try
                If _frmCargando IsNot Nothing Then
                    _frmCargando.Close()
                    _frmCargando.Dispose()
                    _frmCargando = Nothing
                End If
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace
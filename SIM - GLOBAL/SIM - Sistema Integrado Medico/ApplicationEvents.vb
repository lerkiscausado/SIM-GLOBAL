Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: Se genera cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: Se genera después de haberse cerrado todos los formularios de aplicación.  Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: Se genera si la aplicación encuentra una excepción no controlada.
    ' StartupNextInstance: Se genera cuando se inicia una aplicación de instancia única y dicha aplicación está ya activa. 
    ' NetworkAvailabilityChanged: Se genera cuando se conecta o desconecta la conexión de red.
    Partial Friend Class MyApplication

        ' La presentación (SSPresentacion, un SplashScreen de DevExpress) se muestra con el
        ' SplashScreenManager de DevExpress y no con la opción "Pantalla de presentación" de VB:
        ' VB la dibuja en otro hilo a la vez que se construye frmSesion, y ambos usan la caché de
        ' fuentes de DevExpress, que no es segura entre hilos -> NullReferenceException
        ' intermitente en frmSesion.InitializeComponent (DevExpress.Utils.Text.FontsCache).
        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(SSPresentacion))
            Catch
                ' Si la presentación no se puede mostrar, el SIM inicia igual.
            End Try
        End Sub

        ' Cierra la presentación; lo llama frmSesion al mostrarse.
        Friend Shared Sub CerrarPresentacion()
            Try
                If DevExpress.XtraSplashScreen.SplashScreenManager.Default IsNot Nothing Then
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)
                End If
            Catch
            End Try
        End Sub
    End Class
End Namespace

Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports SIM___GLOBAL.Utilidades
Imports System.IO
Imports Newtonsoft.Json

Public Class frmRipsJson
    Dim _Dfacturas As New SIM___GLOBAL.Controles.DFacturas
    Private Sub frmRipsJson_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub sbJSON_Click(sender As Object, e As EventArgs) Handles sbJSON.Click

        Try
            ' Obtener el DataSet de la cabecera
            Dim cabecera As DataSet = _Dfacturas.ObtenerCabecera(txtFactura.Text)

            ' Verifica si la cabecera tiene datos
            If cabecera IsNot Nothing AndAlso cabecera.Tables.Count > 0 AndAlso cabecera.Tables(0).Rows.Count > 0 Then
                ' Obtener el numDocumentoIdObligado de la cabecera
                Dim numDocumentoIdObligado As String = cabecera.Tables(0).Rows(0)("numDocumentoIdObligado").ToString()

                ' Obtener el DataSet de los usuarios asociados a la factura
                Dim usuarios As DataSet = _Dfacturas.UsuariosRipsJson(cabecera.Tables(0).Rows(0)(0).ToString())

                ' Crear un diccionario para la estructura JSON final
                Dim jsonResult As New Dictionary(Of String, Object) From {
                {"numDocumentoIdObligado", cabecera.Tables(0).Rows(0)("numDocumentoIdObligado")},
                {"numFactura", cabecera.Tables(0).Rows(0)("numFactura")},
                {"tipoNota", cabecera.Tables(0).Rows(0)("tipoNota")},
                {"numNota", cabecera.Tables(0).Rows(0)("numNota")}
            }

                ' Si hay usuarios, construir el array de usuarios
                If usuarios IsNot Nothing AndAlso usuarios.Tables.Count > 0 AndAlso usuarios.Tables(0).Rows.Count > 0 Then
                    Dim usuariosList As New List(Of Dictionary(Of String, Object))()

                    ' Recorrer las filas del DataSet de usuarios y agregar a la lista
                    For Each row As DataRow In usuarios.Tables(0).Rows
                        Dim usuarioData As New Dictionary(Of String, Object)()

                        For Each column As DataColumn In usuarios.Tables(0).Columns
                            usuarioData.Add(column.ColumnName, row(column))
                        Next

                        usuariosList.Add(usuarioData)
                    Next

                    ' Agregar los usuarios al JSON final
                    jsonResult.Add("usuarios", usuariosList)
                Else
                    ' Si no hay usuarios, agregar un array vacío
                    jsonResult.Add("usuarios", New List(Of Object)())
                End If

                ' Serializar el diccionario a JSON
                Dim json As String = JsonConvert.SerializeObject(jsonResult, Formatting.Indented)

                ' Mostrar el JSON en el TextBox
                txtJSON.Text = json
            Else
                txtJSON.Text = "No se encontraron datos de la cabecera."
            End If
        Catch ex As Exception
            txtJSON.Text = $"Error: {ex.Message}{Environment.NewLine}Detalle: {ex.StackTrace}"
        End Try

    End Sub
End Class

Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Public Class frmPrueba3
    Private Shared ReadOnly client As New HttpClient()
    Private Shared _token As String = ""
    Dim baseUrl = "https://api-sandbox.factus.com.co"

    Private Sub frmPrueba3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = "sandboxv2@factus.com.co"
        txtPass.Text = "sandbox2026%"
        txtClienteID.Text = "a18b0630-738d-4bd3-b0a2-4c77d89a1fe5"
        txtLlave.Text = "DiEWYQjfRb4tfqXjDafvB896xchXXoijKaec6bhK"

    End Sub


    Private Async Sub sbConectar_Click(sender As Object, e As EventArgs) Handles sbConectar.Click
        Try
            Dim client As New HttpClient()

            Dim parametros As New Dictionary(Of String, String) From {
            {"grant_type", "password"},
            {"client_id", txtClienteID.Text.Trim()},
            {"client_secret", txtLlave.Text.Trim()},
            {"username", txtUsuario.Text.Trim()},
            {"password", txtPass.Text.Trim()}
        }

            Dim content = New FormUrlEncodedContent(parametros)
            Dim response = Await client.PostAsync(baseUrl + "/oauth/token", content)
            Dim body = Await response.Content.ReadAsStringAsync()

            If response.IsSuccessStatusCode Then
                Dim resultado = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(body)
                Dim accessToken As String = resultado("access_token").ToString()
                'MessageBox.Show("Token: " & accessToken)
                txtToken.Text = accessToken
                Facturas()
            Else
                MessageBox.Show("Error: " & body)
            End If

        Catch ex As Exception
            MessageBox.Show("Excepción: " & ex.Message)
        End Try
    End Sub
    Private Async Sub Facturas()
        Try
            Dim client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & txtToken.Text.Trim())
            client.DefaultRequestHeaders.Add("Accept", "application/json")

            Dim url As String = "https://api-sandbox.factus.com.co/v2/bills" &
                            "?filter[identification]=" &
                            "&filter[names]=" &
                            "&filter[number]=" &
                            "&filter[prefix]=" &
                            "&filter[reference_code]=" &
                            "&filter[status]=" &
                            "&page=1"

            Dim response = Await client.GetAsync(url)
            Dim body = Await response.Content.ReadAsStringAsync()

            If response.IsSuccessStatusCode Then

                ' Parsear el JSON
                Dim json = JObject.Parse(body)
                Dim facturas = json("data")("data") ' ajusta si la ruta es diferente

                ' Crear tabla con las columnas que necesitas
                Dim tabla As New DataTable()
                tabla.Columns.Add("number", GetType(String))
                tabla.Columns.Add("identification", GetType(String))
                tabla.Columns.Add("trade_name", GetType(String))
                tabla.Columns.Add("total", GetType(String))


                ' Recorrer los registros
                For Each factura As JObject In facturas
                    Dim fila = tabla.NewRow()
                    fila("number") = If(factura("number") IsNot Nothing, factura("number").ToString(), "")
                    fila("identification") = If(factura("customer") IsNot Nothing AndAlso
                                            factura("customer")("identification") IsNot Nothing,
                                            factura("customer")("identification").ToString(), "")
                    fila("trade_name") = If(factura("customer") IsNot Nothing AndAlso
                                            factura("customer")("trade_name") IsNot Nothing,
                                            factura("customer")("trade_name").ToString(), "")
                    fila("total") = If(factura("total") IsNot Nothing, factura("total").ToString(), "")
                    tabla.Rows.Add(fila)
                Next

                ' Asignar al GridControl DevExpress
                gcFacturas.DataSource = tabla
                gvFacturas.PopulateColumns()

                ' Personalizar encabezados de columnas
                gvFacturas.Columns("number").Caption = "Número"
                gvFacturas.Columns("identification").Caption = "Identificación"
                gvFacturas.Columns("trade_name").Caption = "Razón Social"
                gvFacturas.Columns("total").Caption = "Total"

            Else
                MessageBox.Show("Error: " & body)
            End If

        Catch ex As Exception
            MessageBox.Show("Excepción: " & ex.Message)
        End Try
    End Sub
    Private Async Sub gvFacturas_DoubleClick(sender As Object, e As EventArgs) Handles gvFacturas.DoubleClick
        Try
            ' Obtener el número de factura de la fila seleccionada
            Dim numeroFactura As String = gvFacturas.GetFocusedRowCellValue("number").ToString()

            If String.IsNullOrEmpty(numeroFactura) Then
                MessageBox.Show("No se pudo obtener el número de factura.")
                Return
            End If

            Await DescargarPdfFactura(numeroFactura)

        Catch ex As Exception
            MessageBox.Show("Excepción: " & ex.Message)
        End Try
    End Sub
    Private Async Function DescargarPdfFactura(numeroFactura As String) As Task
        Try
            Dim client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & txtToken.Text.Trim())
            client.DefaultRequestHeaders.Add("Accept", "application/json")

            Dim url As String = $"https://api-sandbox.factus.com.co/v2/bills/{numeroFactura}/download-pdf"

            Dim response = Await client.GetAsync(url)
            Dim body = Await response.Content.ReadAsStringAsync()

            If response.IsSuccessStatusCode Then

                ' La API retorna el PDF en Base64 dentro del JSON
                Dim json = Newtonsoft.Json.Linq.JObject.Parse(body)
                Dim base64Pdf As String = json("data")("pdf_base_64_encoded").ToString() ' ajusta si el campo es diferente

                ' Convertir Base64 a bytes
                Dim pdfBytes As Byte() = Convert.FromBase64String(base64Pdf)

                ' Guardar en archivo temporal
                Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), $"factura_{numeroFactura}.pdf")
                File.WriteAllBytes(rutaTemporal, pdfBytes)

                ' Mostrar en el visor PDF de DevExpress
                pdfFactura.LoadDocument(rutaTemporal)

            Else
                MessageBox.Show("Error al obtener PDF: " & body)
            End If

        Catch ex As Exception
            MessageBox.Show("Excepción DescargarPdf: " & ex.Message)
        End Try
    End Function
End Class


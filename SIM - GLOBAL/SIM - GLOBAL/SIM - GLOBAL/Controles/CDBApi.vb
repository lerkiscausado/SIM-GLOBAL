Imports SIM___GLOBAL.Modelo
Imports System.Net
Imports RestSharp
Public Class CDBApi
    Public Function MGet(url As String, headers As List(Of Parametro), param_encode As List(Of Parametro)) As String
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim client = New RestClient()
        'client.BaseUrl = New Uri(url)

        Dim request = New RestRequest()
        request.Method = Method.Get

        For Each header As Parametro In headers
            request.AddHeader(header.Clave, header.Valor)
        Next

        For Each parametro As Parametro In param_encode
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        Dim response = client.Execute(request).Content.ToString()

        Return response
    End Function
End Class

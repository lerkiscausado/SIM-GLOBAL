Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web
Imports System.Xml

Public Class frmPruebaJson
    Dim DataSetJSON As DataSet
    Public Function GetApi() As DataTable

        'Dim xmlData As New XmlDocument
        'Dim ds As New DataSet
        Dim webRequest As HttpWebRequest = HttpWebRequest.Create("https://rickandmortyapi.com/api")
        webRequest.Credentials = CredentialCache.DefaultCredentials
        webRequest.Proxy = Nothing
        Dim webResponse As HttpWebResponse = webRequest.GetResponse()
        Dim myStream As Stream = webResponse.GetResponseStream
        Dim myReader As StreamReader = New StreamReader(myStream)
        Dim datos As String = HttpUtility.HtmlDecode(myReader.ReadToEnd())
        'xmlData = CType(JsonConvert.DeserializeObject(datos), XmlDocument)
        'Dim data = JsonConvert.DeserializeObject(datos)
        MsgBox(datos)
        'ds = JsonConvert.de

        'ds.ReadXml(New XmlNodeReader(xmlData))

        'Dim Des As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim ListaDatos = JsonConvert.DeserializeObject(datos)

        Dim dtDes As New DataTable
        'creamos las columnas

        dtDes.Columns.Add("id")
        dtDes.Columns.Add("identificacion")


        'Ahora los datos
        Dim drDes As DataRow
        For Rows As Integer = 0 To ListaDatos.Count - 1
            drDes = dtDes.NewRow
            ' MsgBox(ListaDatos(Rows).item("id"))
            drDes("id") = ListaDatos(Rows).Item("id")
            drDes("identificacion") = ListaDatos(Rows).Item("identificacion")
            dtDes.Rows.Add(drDes)
        Next
        Return dtDes

    End Function
    Private Function RequestPost(ByVal URL As String, ByVal JSonData As Dictionary(Of String, Object)) As JObject

    End Function
    Private Function SendRequestGetAuth() As String

    End Function
    Private Function GetListTerceros() As JArray
        'Se define la URL donde se realizará la peticion de solicitud de listado de terceros
        Dim URLPost As String = "http://192.168.1.2:5000/api/identificacion"
        'Se define el Objeto que se enviará en el cuerpo de la petición
        Dim ObjSend As New Dictionary(Of String, Object)
        'Se define el Objeto que tendrá los datos de autenticación
        'Dim ObjParams As New Dictionary(Of String, Object)
        'Se define el Objeto con los datos de página
        'Dim ObjDatosPagina = New Dictionary(Of String, String)
        'ObjDatosPagina.Add("cantidadregistros", "999")
        'ObjDatosPagina.Add("pagina", "1")
        'Se agrega el objeto de los datos de la página
        'ObjParams.Add("datospagina", ObjDatosPagina)
        'Se agrega el arreglo con los datos que se solicitaran en la lista
        'ObjParams.Add("camposderetorno", New String() {"id", "identificacion"})
        'Se construye el arreglo donde se enviaran los 4 parámetros
        'Dim arrParams(3) As String
        'El primer parámetro es el JSON con los datos a envíar
        'arrParams(0) = JsonConvert.SerializeObject(ObjParams, Formatting.None)
        'El segundo parámetro es el KeyAgente entregado enla funcion de GetAuth
        'arrParams(1) = keyAgent
        'El tercer parámetro es el código del APP configurado
        'arrParams(2) = "1001"
        'El cuarto parámetro es un random
        'arrParams(3) = "5555"
        'Se adiciona el arreglo de paramatros al objeto a enviar
        'ObjSend.Add("_parameters", arrParams)
        'Se realiza la solicitud REST y se almacena en el ObjResult con la respuesta de la petición
        Dim ObjResult As JObject = RequestPost(URLPost, ObjSend)
        'Se definen variables temporales que se usaran para acceder al JSON
        Dim arrTemp As JArray
        Dim objTemp As JObject
        Dim str As String = ""
        Dim b = False
        'Se valida si existe y se extrae el arreglo del JSON del result y se verifica que no este    vacio
        If ObjResult.TryGetValue("result", arrTemp) And Not IsNothing(arrTemp) And arrTemp.Count > 0 Then
            'Se obtiene el primer objeto del arreglo
            objTemp = arrTemp.Item(0)
            'Se obtiene el arreglo con los terceros que esta en datos de la llave respuesta
            b = objTemp.TryGetValue("respuesta", objTemp) And objTemp.TryGetValue("datos", arrTemp)
        End If
        'Se retorna el arreglo de terceros
        Return arrTemp
    End Function

    Private Sub frmPruebaJson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sbPrueba_Click(sender As Object, e As EventArgs) Handles sbPrueba.Click
        'Se solicita el keyAgente
        'Dim sKey As String = SendRequestGetAuth()
        'Se verifica que el keyAgent tenga un valor
        'If sKey <> "" Then
        'Se escribe el keyAgente en el label
        'LblControlKey.Text = "Key de autorización: " + sKey
        'Se desactivan los controles para no volver a solicitar inicio sesión
        'ButtonGetAuth.Enabled = False
        'EdEmail.Enabled = False
        'EdClave.Enabled = False
        'Se crea una nueva tabla llamada terceros
        Dim tbl = New DataTable
        'Se adicionan las columnas a la tabla con su respectivo tipo
        tbl.Columns.Add(New DataColumn("ID", System.Type.GetType("System.String")))
        tbl.Columns.Add(New DataColumn("IDENTIFICACION", System.Type.GetType("System.String")))
        'Se agrega la tabla al DataSet
        DataSetJSON.Tables.Add(tbl)
        'Se define a la grid que muestre la tabla llamada terceros
        gcResponse.DataSource = DataSetJSON.Tables("Identificacion")
        'Se define una variable de tipo registro
        Dim registro As DataRow
        'Se obtiene el listado de terceros enviando el KeyAgente obtenido previamente
        Dim arrTerceros = GetListTerceros()
        MsgBox(arrTerceros)
        'Se define un Objeto temporal para el momento de recorrer el arreglo
        Dim JRecord As JObject
        'Se recorre el arreglo con el listado de terceros
        For i As Integer = 0 To arrTerceros.Count - 1
            'Se extrea el objeto que viene la posicion i del arreglo
            JRecord = arrTerceros.Item(i)
            'Se verifica que si exista un objeto dentro del record
            If Not IsNothing(JRecord) Then
                'Se define que el registro será una nueva fila
                registro = DataSetJSON.Tables("Identificacion").NewRow()
                'Se adicionan los datos
                registro("ID") = JRecord.GetValue("id")
                registro("IDENTIFICACION") = JRecord.GetValue("identificacion")
                'registro("Apellido") = JRecord.GetValue("napellido")
                'Se agrega el registro a la tabla creada
                DataSetJSON.Tables("Identificacion").Rows.Add(registro)
            End If
        Next
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim dt As DataTable = GetApi()
        gcResponse.DataSource = dt
        'MsgBox(Prueba.data(0).identificacion.tostring)
    End Sub

    Private Sub spApi_Click(sender As Object, e As EventArgs) Handles spApi.Click

        Dim request As HttpWebRequest = CType(WebRequest.Create("http://18.188.220.90:3000/api/storage"), HttpWebRequest)
        request.Method = "POST"

        Dim file_path As String = "C:\RIPS\361\cv.pdf"
        Dim file_mime_type As String = "application/octet-stream"
        Dim file_name As String = Path.GetFileName(file_path)

        Dim file_stream As New FileStream(file_path, FileMode.Open, FileAccess.Read)
        Dim file_bytes As Byte() = New Byte(file_stream.Length - 1) {}
        file_stream.Read(file_bytes, 0, file_bytes.Length)
        file_stream.Close()

        Dim boundary As String = "---------------------------" & DateTime.Now.Ticks.ToString("x")
        request.ContentType = "multipart/form-data; boundary=" & boundary

        Dim requestStream As Stream = request.GetRequestStream()
        Dim writer As New StreamWriter(requestStream)

        writer.Write("--" & boundary & vbCrLf)
        writer.Write("Content-Disposition: form-data; name=""myfile""; filename=""" & file_name & """" & vbCrLf)
        writer.Write("Content-Type: " & file_mime_type & vbCrLf)
        writer.Write(vbCrLf)
        writer.Flush()

        requestStream.Write(file_bytes, 0, file_bytes.Length)

        writer.Write(vbCrLf)
        writer.Write("--" & boundary & "--" & vbCrLf)
        writer.Flush()

        writer.Close()

        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)




    End Sub
End Class
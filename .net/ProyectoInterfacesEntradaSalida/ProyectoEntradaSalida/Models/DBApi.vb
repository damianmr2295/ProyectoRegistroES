Imports System.Net
Imports RestSharp

Public Class DBApi
    Public Function MGet(url As String, headers As List(Of Parametro), param_encode As List(Of Parametro)) As String
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim cliente = New RestClient()
        cliente.BaseUrl = New Uri(url)

        Dim request = New RestRequest()
        request.Method = Method.GET

        For Each header As Parametro In headers
            request.AddHeader(header.Clave, header.Valor)
        Next

        For Each parametro As Parametro In param_encode
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        Dim response = cliente.Execute(request).Content.ToString()

        Return response

    End Function

    Public Function Put(url As String, headers As List(Of Parametro), param_encode As List(Of Parametro), json As Object) As String
        Dim cliente = New RestClient()
        cliente.BaseUrl = New Uri(url)

        Dim request = New RestRequest()
        request.Method = Method.PUT

        For Each item As Parametro In headers
            request.AddHeader(item.Clave, item.Valor)
        Next

        For Each parametro As Parametro In param_encode
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        If param_encode.Count = 0 Then
            request.AddJsonBody(json)

        End If

        Dim response = cliente.Execute(request).Content.ToString()
        Return response

    End Function


End Class

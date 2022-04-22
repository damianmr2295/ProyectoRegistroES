Imports Newtonsoft.Json

Public Class RestAPI
    Function usersAll() As List(Of User)
        Dim api = New DBApi
        Dim url As String = "http://localhost:8080/user"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim users As List(Of User) = JsonConvert.DeserializeObject(Of List(Of User))(response)
        Return users
    End Function
    Function userDni() As User
        Dim api = New DBApi
        Dim url As String = "http://localhost:8080/user/dni/{dni}?dni=" + frmLogin.txtUser.Text
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim user = JsonConvert.DeserializeObject(Of User)(response)

        Return user
    End Function
    Function userNombre(nombre As String) As List(Of User)
        Dim api = New DBApi
        Dim url As String = "http://localhost:8080/user/nombre/{nombre}?nombre=" + nombre
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim users As List(Of User) = JsonConvert.DeserializeObject(Of List(Of User))(response)

        Return users
    End Function

    Function aulaNombre(nombre As String) As Aula
        Dim api = New DBApi
        Dim url As String = "http://localhost:8080/aula/nombre/{nombre}?nombre=" + nombre
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim aula As Aula = JsonConvert.DeserializeObject(Of Aula)(response)

        Return aula
    End Function

    Function ficharHora(ficha As Ficha)
        Dim api = New DBApi
        ficha.fecha = DateAdd("d", 1, ficha.fecha)
        Dim url As String = "http://localhost:8080/ficha/modificar/" + ficha.idFicha.ToString

        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)


        Dim response = api.Put(url, headers, parametros, ficha)

        Dim result = JsonConvert.DeserializeObject(Of Ficha)(response)
    End Function
    Function fichaHorario(fechaActual As Date) As List(Of Ficha)
        Dim api = New DBApi
        Dim url As String = "http://localhost:8080/ficha/fecha/{fecha}?localDate=" + Format(fechaActual, "yyyy-MM-dd")
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)

        Dim fichas As List(Of Ficha) = JsonConvert.DeserializeObject(Of List(Of Ficha))(response)

        Return fichas
    End Function
End Class

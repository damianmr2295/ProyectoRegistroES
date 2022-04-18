Imports Newtonsoft.Json

Public Class frmLogin
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim api = New DBApi
        Dim url = "http://localhost:8080/user/1"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)

        Dim objeto = JsonConvert.DeserializeObject(Of User)(response)

        MessageBox.Show("Persona id " + objeto.nombre)

        frmLogin.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub
End Class

Class User
    Public Property id As Long
    Public Property dni As String
    Public Property nombre As String

End Class
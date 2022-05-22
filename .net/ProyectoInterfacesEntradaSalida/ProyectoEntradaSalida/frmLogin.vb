Imports System.Net
Imports System.IO

Public Class frmLogin
    Dim restApi = New RestAPI
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim user = restApi.userDni()
        Try
            If user Is Nothing Then
                MessageBox.Show("Usuario o contraseña incorrecta")
            Else
                If user.password.Equals(txtContrasenya.Text) Then
                    frmLogin.ActiveForm.Hide()
                    frmPrincipal.Show()
                Else
                    MessageBox.Show("Usuario o contraseña incorrecta")
                End If

            End If
        Catch
            MessageBox.Show("Usuario o contraseña incorrecta")
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"

        Dim wc As New WebClient
        Dim bytes() As Byte = wc.DownloadData(url)
        Dim ImgStream As New MemoryStream(bytes)

        imgCabeceraMZ.Image = Image.FromStream(ImgStream)
    End Sub
End Class


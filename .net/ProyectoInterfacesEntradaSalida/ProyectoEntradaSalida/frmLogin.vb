Imports Newtonsoft.Json

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

    End Sub
End Class


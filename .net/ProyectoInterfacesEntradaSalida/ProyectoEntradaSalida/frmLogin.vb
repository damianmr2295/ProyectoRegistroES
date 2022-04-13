Public Class frmLogin
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        frmLogin.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub
End Class
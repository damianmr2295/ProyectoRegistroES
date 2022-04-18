Public Class frmPrincipal
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        frmPrincipal.ActiveForm.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnFichar_Click(sender As Object, e As EventArgs) Handles btnFichar.Click
        frmPrincipal.ActiveForm.Hide()
        frmFichar.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmPrincipal.ActiveForm.Hide()
        frmBuscar.Show()
    End Sub
End Class
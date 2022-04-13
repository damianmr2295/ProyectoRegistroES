Public Class frmFichar
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmFichar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub
End Class
Public Class frmBuscar
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmBuscar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub
End Class
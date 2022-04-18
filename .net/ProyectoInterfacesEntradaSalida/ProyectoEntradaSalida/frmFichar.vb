Public Class frmFichar
    Private Sub frmFichar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim fechaActual As Date = Date.Now
        labelDiaActual.Text = Format(fechaActual, "dd/MM/yyyy")
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmFichar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub

End Class
Imports Newtonsoft.Json

Public Class frmBuscar
    Dim restApi = New RestAPI
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmBuscar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelUsuario.Text = "Usuario: " + restApi.userDni().nombre
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        Dim ocupado = False
        If rbtnProfesor.Checked Then
            DataGridView1.Columns.Add("nombre", "Nombre")
            DataGridView1.Columns.Add("apelldios", "Apelldios")
            DataGridView1.Columns.Add("estado", "Estado")
            Dim users As List(Of User) = restApi.userNombre(txtNombre.Text)
            For Each user As User In users
                For Each horario As Horario In user.horarios
                    Dim cont = 0
                    If comBoxHoraInic.Text.Equals(horario.horaInicio + " - " + horario.horaFin) Then
                        ocupado = True
                    End If
                Next

                If ocupado Then
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "Ocupado")
                Else
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "Libre")
                End If
                ocupado = False
            Next
        Else
            DataGridView1.Columns.Add("nombre", "Nombre")
            DataGridView1.Columns.Add("estado", "Estado")
            Dim aula = restApi.aulaNombre(txtNombre.Text)
            For Each horario As Horario In aula.horarios
                If comBoxHoraInic.Text.Equals(horario.horaInicio + " - " + horario.horaFin) Then
                    ocupado = True
                End If
            Next
            If ocupado Then
                DataGridView1.Rows.Add(aula.nombre, "Ocupado")
            Else
                DataGridView1.Rows.Add(aula.nombre, "Libre")
            End If
            ocupado = False
        End If
    End Sub

End Class
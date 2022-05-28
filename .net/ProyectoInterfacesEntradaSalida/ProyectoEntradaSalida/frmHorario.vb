Imports System.IO
Imports System.Net

Public Class frmHorario
    Dim restApi = New RestAPI

    Private Sub frmHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"

        Dim wc As New WebClient
        Dim bytes() As Byte = wc.DownloadData(url)
        Dim ImgStream As New MemoryStream(bytes)

        imgCabeceraMZ.Image = Image.FromStream(ImgStream)
        Dim user = restApi.userDni()
        labelUsuario.Text = "Usuario: " + user.nombre + " " + user.apellidos
        Dim fecha As Date = Date.Now
        Dim diahorario As Integer = 1

        Dim horario = restApi.horaHorario(diahorario)
        Dim lunes As List(Of String) = rellenarDiasSemana(horario, user.dni)
        diahorario += 1
        horario = restApi.horaHorario(diahorario)
        Dim martes As List(Of String) = rellenarDiasSemana(horario, user.dni)
        diahorario += 1
        horario = restApi.horaHorario(diahorario)
        Dim miercoles As List(Of String) = rellenarDiasSemana(horario, user.dni)
        diahorario += 1
        horario = restApi.horaHorario(diahorario)
        Dim jueves As List(Of String) = rellenarDiasSemana(horario, user.dni)
        diahorario += 1
        horario = restApi.horaHorario(diahorario)
        Dim viernes As List(Of String) = rellenarDiasSemana(horario, user.dni)

        rellenarTabla(lunes, martes, miercoles, jueves, viernes)
    End Sub

    Function rellenarDiasSemana(horarios As List(Of Horario), userDni As String) As List(Of String)
        Dim list As List(Of String) = New List(Of String)
        For i As Integer = 0 To 16
            list.Add("-----")
        Next
        For Each horario As Horario In horarios
            If horario.horaInicio.Equals("08:00:00") And horario.user.dni.Equals(userDni) Then
                list(0) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("08:55:00") And horario.user.dni.Equals(userDni) Then
                list(1) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("09:50:00") And horario.user.dni.Equals(userDni) Then
                list(2) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("10:45:00") And horario.user.dni.Equals(userDni) Then
                list(3) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("11:10:00") And horario.user.dni.Equals(userDni) Then
                list(4) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("12:05:00") And horario.user.dni.Equals(userDni) Then
                list(5) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("13:00:00") And horario.user.dni.Equals(userDni) Then
                list(6) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("13:45:00") And horario.user.dni.Equals(userDni) Then
                list(7) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("14:15:00") And horario.user.dni.Equals(userDni) Then
                list(8) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("15:30:00") And horario.user.dni.Equals(userDni) Then
                list(9) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("16:25:00") And horario.user.dni.Equals(userDni) Then
                list(10) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("17:20:00") And horario.user.dni.Equals(userDni) Then
                list(11) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("18:15:00") And horario.user.dni.Equals(userDni) Then
                list(12) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("18:35:00") And horario.user.dni.Equals(userDni) Then
                list(13) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("19:30:00") And horario.user.dni.Equals(userDni) Then
                list(14) = horario.aula.nombre
            ElseIf horario.horaInicio.Equals("20:25:00") And horario.user.dni.Equals(userDni) Then
                list(15) = horario.aula.nombre
            Else
            End If
        Next
        Return list
    End Function
    Function rellenarTabla(lunes As List(Of String), martes As List(Of String), miercoles As List(Of String), jueves As List(Of String), viernes As List(Of String))
        DataGridView1.Columns.Add("blanco", "     ")
        DataGridView1.Columns.Add("lunes", "Lunes")
        DataGridView1.Columns.Add("martes", "Martes")
        DataGridView1.Columns.Add("miercoles", "Miercoles")
        DataGridView1.Columns.Add("jueves", "Jueves")
        DataGridView1.Columns.Add("viernes", "Viernes")

        DataGridView1.Rows.Add("08:00 - 08:55", lunes(0), martes(0), miercoles(0), jueves(0), viernes(0))
        DataGridView1.Rows.Add("08:55 - 09:50", lunes(1), martes(1), miercoles(1), jueves(1), viernes(1))
        DataGridView1.Rows.Add("09:50 - 10:45", lunes(2), martes(2), miercoles(2), jueves(2), viernes(2))
        DataGridView1.Rows.Add("10:45 - 11:10", lunes(3), martes(3), miercoles(3), jueves(3), viernes(3))
        DataGridView1.Rows.Add("11:10 - 12:05", lunes(4), martes(4), miercoles(4), jueves(4), viernes(4))
        DataGridView1.Rows.Add("12:05 - 13:00", lunes(5), martes(5), miercoles(5), jueves(5), viernes(5))
        DataGridView1.Rows.Add("13:00 - 13:55", lunes(6), martes(6), miercoles(6), jueves(6), viernes(6))
        DataGridView1.Rows.Add("13:55 - 14:15", lunes(7), martes(7), miercoles(7), jueves(7), viernes(7))
        DataGridView1.Rows.Add("14:15 - 15:30", lunes(8), martes(8), miercoles(8), jueves(8), viernes(8))
        DataGridView1.Rows.Add("15:30 - 16:25", lunes(9), martes(9), miercoles(9), jueves(9), viernes(9))
        DataGridView1.Rows.Add("16:25 - 17:20", lunes(10), martes(10), miercoles(10), jueves(10), viernes(10))
        DataGridView1.Rows.Add("17:20 - 18:15", lunes(11), martes(11), miercoles(11), jueves(11), viernes(11))
        DataGridView1.Rows.Add("18:15 - 18:35", lunes(12), martes(12), miercoles(12), jueves(12), viernes(12))
        DataGridView1.Rows.Add("18:35 - 19:30", lunes(13), martes(13), miercoles(13), jueves(13), viernes(13))
        DataGridView1.Rows.Add("19:30 - 20:25", lunes(14), martes(14), miercoles(14), jueves(14), viernes(14))
        DataGridView1.Rows.Add("20:25 - 21:20", lunes(15), martes(15), miercoles(15), jueves(15), viernes(15))



    End Function

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmFichar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
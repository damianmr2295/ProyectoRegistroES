Public Class frmHorario
    Dim restApi = New RestAPI

    Private Sub frmHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user = restApi.userDni()
        labelUsuario.Text = "Usuario: " + user.nombre
        Dim fecha As Date = Date.Now
        Dim index As Integer = 0
        Do
            If fecha.DayOfWeek = 1 Then
                index = 7
            Else
                fecha = DateAdd("d", -1, fecha)
            End If
            index += 1
        Loop Until index > 7

        Dim fichas = restApi.fichaHorario(fecha)
        Dim lunes As List(Of String) = rellenarDiasSemana(fichas, user.nombre)
        fichas = restApi.fichaHorario(DateAdd("d", 1, fecha))
        Dim martes As List(Of String) = rellenarDiasSemana(fichas, user.nombre)
        fichas = restApi.fichaHorario(DateAdd("d", 2, fecha))
        Dim miercoles As List(Of String) = rellenarDiasSemana(fichas, user.nombre)
        fichas = restApi.fichaHorario(DateAdd("d", 3, fecha))
        Dim jueves As List(Of String) = rellenarDiasSemana(fichas, user.nombre)
        fichas = restApi.fichaHorario(DateAdd("d", 4, fecha))
        Dim viernes As List(Of String) = rellenarDiasSemana(fichas, user.nombre)

        rellenarTabla(lunes, martes, miercoles, jueves, viernes)
    End Sub

    Function rellenarDiasSemana(fichas As List(Of Ficha), userNombre As String) As List(Of String)
        Dim list As List(Of String) = New List(Of String)
        For i As Integer = 0 To 6
            list.Add("-----")
        Next
        For Each ficha As Ficha In fichas
            If ficha.horario.horaInicio.Equals("08:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(0) = ficha.horario.aula.nombre
            ElseIf ficha.horario.horaInicio.Equals("09:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(1) = ficha.horario.aula.nombre
            ElseIf ficha.horario.horaInicio.Equals("10:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(2) = ficha.horario.aula.nombre
            ElseIf ficha.horario.horaInicio.Equals("11:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(3) = ficha.horario.aula.nombre
            ElseIf ficha.horario.horaInicio.Equals("12:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(4) = ficha.horario.aula.nombre
            ElseIf ficha.horario.horaInicio.Equals("13:00 h") And ficha.horario.user.nombre.Equals(userNombre) Then
                list(5) = ficha.horario.aula.nombre
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

        DataGridView1.Rows.Add("08:00 - 09:00", lunes(0), martes(0), miercoles(0), jueves(0), viernes(0))
        DataGridView1.Rows.Add("09:00 - 10:00", lunes(1), martes(1), miercoles(1), jueves(1), viernes(1))
        DataGridView1.Rows.Add("10:00 - 11:00", lunes(2), martes(2), miercoles(2), jueves(2), viernes(2))
        DataGridView1.Rows.Add("11:00 - 12:00", lunes(3), martes(3), miercoles(3), jueves(3), viernes(3))
        DataGridView1.Rows.Add("12:00 - 13:00", lunes(4), martes(4), miercoles(4), jueves(4), viernes(4))
        DataGridView1.Rows.Add("13:00 - 14:00", lunes(5), martes(5), miercoles(5), jueves(5), viernes(5))


    End Function

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmFichar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub

End Class
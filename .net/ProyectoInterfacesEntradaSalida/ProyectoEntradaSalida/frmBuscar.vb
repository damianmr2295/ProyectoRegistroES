Imports System.Net
Imports System.IO

Public Class frmBuscar
    Dim restApi = New RestAPI
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmBuscar.ActiveForm.Hide()
        frmPrincipal.Show()
    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"

        Dim wc As New WebClient
        Dim bytes() As Byte = wc.DownloadData(url)
        Dim ImgStream As New MemoryStream(bytes)

        imgCabeceraMZ.Image = Image.FromStream(ImgStream)

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
                Dim fichas = restApi.fichaHorario(fecha.Value)
                For Each ficha As Ficha In fichas
                    If ficha.horario.user.dni.Equals(user.dni) Then
                        If ficha.fichado Then
                            ocupado = True
                        End If
                    End If
                Next

                If ocupado Then
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "Ocupado")
                Else
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "Libre")
                End If
                ocupado = False
            Next
        ElseIf rbtnNoFichados.Checked Then
            DataGridView1.Columns.Add("nombre", "Nombre")
            DataGridView1.Columns.Add("apelldios", "Apelldios")
            DataGridView1.Columns.Add("estado", "Estado")
            Dim users As List(Of User) = restApi.usersAll()
            For Each user As User In users
                Dim fichas = restApi.fichaHorario(fecha.Value)
                For Each ficha As Ficha In fichas
                    If ficha.horario.user.dni.Equals(user.dni) Then
                        If ficha.fichado Then
                            ocupado = True
                        End If
                    End If
                Next

                If ocupado Then
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "Presentado")
                Else
                    DataGridView1.Rows.Add(user.nombre, user.apellidos, "No presentado")
                End If
                ocupado = False
            Next
        Else
            DataGridView1.Columns.Add("nombre", "Nombre")
            DataGridView1.Columns.Add("estado", "Estado")
            Dim aula = restApi.aulaNombre(txtNombre.Text)
            If aula IsNot Nothing Then
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
        End If
    End Sub

    Private Sub rbtnAula_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAula.CheckedChanged
        labelNombre.Enabled = True
        txtNombre.Enabled = True
        labelHoraIni.Enabled = True
        comBoxHoraInic.Enabled = True
        labelFecha.Enabled = False
        fecha.Enabled = False
    End Sub

    Private Sub rbtnProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnProfesor.CheckedChanged
        labelNombre.Enabled = True
        txtNombre.Enabled = True
        labelFecha.Enabled = True
        fecha.Enabled = True
        labelHoraIni.Enabled = False
        comBoxHoraInic.Enabled = False
    End Sub

    Private Sub rbtnNoFichados_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNoFichados.CheckedChanged
        labelFecha.Enabled = True
        fecha.Enabled = True
        labelNombre.Enabled = False
        txtNombre.Enabled = False
        labelHoraIni.Enabled = False
        comBoxHoraInic.Enabled = False
    End Sub
End Class
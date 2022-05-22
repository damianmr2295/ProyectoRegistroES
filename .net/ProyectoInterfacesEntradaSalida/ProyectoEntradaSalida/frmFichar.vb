Imports System.Net
Imports System.IO

Public Class frmFichar
    Dim restApi = New RestAPI
    Private Sub frmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"

        Dim wc As New WebClient
        Dim bytes() As Byte = wc.DownloadData(url)
        Dim ImgStream As New MemoryStream(bytes)

        imgCabeceraMZ.Image = Image.FromStream(ImgStream)

        Dim fechaActual As Date = Date.Now
        Dim cont = 0
        Dim listaLabel = Labels()
        Dim listaButton = Buttons()
        Dim user = restApi.userDni()

        labelDiaActual.Text = Format(fechaActual, "dd/MM/yyyy")
        Dim fichas = restApi.fichaHorario(fechaActual)
        labelUsuario.Text = "Usuario: " + user.nombre
        For Each ficha As Ficha In fichas
            If ficha.horario.user.dni.Equals(user.dni) Then

                listaLabel(cont).Text = "Inicio: " + ficha.horario.horaInicio + " || Fin: " + ficha.horario.horaFin + " || Aula: " + ficha.horario.aula.nombre
                If ficha.fichado Then
                    listaLabel(cont).BackColor = Color.FromArgb(192, 255, 192)
                Else
                    listaLabel(cont).BackColor = Color.FromArgb(255, 192, 192)
                End If
                listaButton(cont).Visible = True
                cont = cont + 1
            End If
        Next
    End Sub
    Private Sub btnFichar1_Click(sender As Object, e As EventArgs) Handles btnFichar1.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(0)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula1.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula1.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar2_Click(sender As Object, e As EventArgs) Handles btnFichar2.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(1)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula2.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula2.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar3_Click(sender As Object, e As EventArgs) Handles btnFichar3.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(2)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula3.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula3.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar4_Click(sender As Object, e As EventArgs) Handles btnFichar4.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(3)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula4.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula4.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar5_Click(sender As Object, e As EventArgs) Handles btnFichar5.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(4)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula5.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula5.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar6_Click(sender As Object, e As EventArgs) Handles btnFichar6.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(5)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula6.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula6.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar7_Click(sender As Object, e As EventArgs) Handles btnFichar7.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(6)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula7.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula7.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub

    Private Sub btnFichar8_Click(sender As Object, e As EventArgs) Handles btnFichar8.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(7)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula8.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula8.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnFichar9_Click(sender As Object, e As EventArgs) Handles btnFichar9.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(8)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula9.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula9.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub

    Private Sub btnFichar10_Click(sender As Object, e As EventArgs) Handles btnFichar10.Click
        Dim fichas = restApi.fichaHorario(labelDiaActual.Text)
        Dim ficha = fichas(9)
        If ficha.fichado Then
            ficha.fichado = False
            labelIniFinAula10.BackColor = Color.FromArgb(255, 192, 192)
        Else
            ficha.fichado = True
            labelIniFinAula10.BackColor = Color.FromArgb(192, 255, 192)
        End If

        restApi.ficharHora(ficha)
        Refresh()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim user = restApi.userDni()
        frmFichar.ActiveForm.Hide()
        frmPrincipal.ultimaConexion(user)
        frmPrincipal.Show()
    End Sub
    Function Labels() As List(Of Label)
        Dim listaLabel As List(Of Label) = New List(Of Label)
        listaLabel.Add(labelIniFinAula1)
        listaLabel.Add(labelIniFinAula2)
        listaLabel.Add(labelIniFinAula3)
        listaLabel.Add(labelIniFinAula4)
        listaLabel.Add(labelIniFinAula5)
        listaLabel.Add(labelIniFinAula6)
        listaLabel.Add(labelIniFinAula7)
        listaLabel.Add(labelIniFinAula8)
        listaLabel.Add(labelIniFinAula9)
        listaLabel.Add(labelIniFinAula10)

        Return listaLabel
    End Function
    Function Buttons() As List(Of Button)
        Dim listaButton As List(Of Button) = New List(Of Button)
        listaButton.Add(btnFichar1)
        listaButton.Add(btnFichar2)
        listaButton.Add(btnFichar3)
        listaButton.Add(btnFichar4)
        listaButton.Add(btnFichar5)
        listaButton.Add(btnFichar6)
        listaButton.Add(btnFichar7)
        listaButton.Add(btnFichar8)
        listaButton.Add(btnFichar9)
        listaButton.Add(btnFichar10)
        Return listaButton
    End Function

End Class
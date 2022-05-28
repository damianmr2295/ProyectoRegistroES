Imports System.IO
Imports System.Net

Public Class frmPrincipal
    Dim restApi = New RestAPI
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Application.Restart()
        frmPrincipal.ActiveForm.Hide()
        frmLogin.Show()
        frmLogin.txtUser.Clear()
        frmLogin.txtContrasenya.Clear()
    End Sub

    Private Sub btnFichar_Click(sender As Object, e As EventArgs) Handles btnFichar.Click
        frmPrincipal.ActiveForm.Hide()
        frmFichar.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmPrincipal.ActiveForm.Hide()
        frmBuscar.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"

        Dim wc As New WebClient
        Dim bytes() As Byte = wc.DownloadData(url)
        Dim ImgStream As New MemoryStream(bytes)

        imgCabeceraMZ.Image = Image.FromStream(ImgStream)

        Dim user = restApi.userDni()
        labelUsuario.Text = "Usuario: " + user.nombre
        ultimaConexion(user)
    End Sub

    Function ultimaConexion(user As User)
        Dim fechaActual As Date = DateAdd("d", 1, Date.Now)
        Dim sinConexion = True
        Dim index As Integer = 0
        Do
            fechaActual = DateAdd("d", -1, fechaActual)
            Dim fichas As List(Of Ficha) = restApi.fichaHorario(fechaActual)
            If fichas.Count > 0 Then
                For Each ficha As Ficha In fichas
                    If ficha.horario.user.dni.Equals(user.dni) And ficha.fichado Then
                        labelUltimaConexion.Text = "Ultima conexión:" + Chr(13) + ficha.fecha
                        sinConexion = False
                        index = 20
                    End If
                Next
            End If
            index += 1
        Loop Until index > 20

        If sinConexion Then
            labelUltimaConexion.Text = "Ultima conexión:" + Chr(13) + "Anterior a 20 días"
        End If
    End Function

    Private Sub btnHorario_Click(sender As Object, e As EventArgs) Handles btnHorario.Click
        frmPrincipal.ActiveForm.Hide()
        frmHorario.Show()
    End Sub
End Class
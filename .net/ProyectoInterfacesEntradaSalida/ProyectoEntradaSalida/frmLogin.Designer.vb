<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.labelNombreUsuario = New System.Windows.Forms.Label()
        Me.labelContraseña = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.imgEmpresa = New System.Windows.Forms.PictureBox()
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        CType(Me.imgEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnIniciarSesion.Location = New System.Drawing.Point(141, 339)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(99, 27)
        Me.btnIniciarSesion.TabIndex = 2
        Me.btnIniciarSesion.Text = "Iniciar sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(121, 240)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(138, 20)
        Me.txtUser.TabIndex = 3
        '
        'labelNombreUsuario
        '
        Me.labelNombreUsuario.AutoSize = True
        Me.labelNombreUsuario.Location = New System.Drawing.Point(118, 224)
        Me.labelNombreUsuario.Name = "labelNombreUsuario"
        Me.labelNombreUsuario.Size = New System.Drawing.Size(71, 13)
        Me.labelNombreUsuario.TabIndex = 4
        Me.labelNombreUsuario.Text = "Usuario (DNI)"
        '
        'labelContraseña
        '
        Me.labelContraseña.AutoSize = True
        Me.labelContraseña.Location = New System.Drawing.Point(118, 274)
        Me.labelContraseña.Name = "labelContraseña"
        Me.labelContraseña.Size = New System.Drawing.Size(61, 13)
        Me.labelContraseña.TabIndex = 5
        Me.labelContraseña.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 290)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'imgEmpresa
        '
        Me.imgEmpresa.ErrorImage = Global.ProyectoEntradaSalida.My.Resources.Resources.MarcosZaragozaIcono
        Me.imgEmpresa.Image = Global.ProyectoEntradaSalida.My.Resources.Resources.MarcosZaragozaIcono
        Me.imgEmpresa.Location = New System.Drawing.Point(152, 137)
        Me.imgEmpresa.Name = "imgEmpresa"
        Me.imgEmpresa.Size = New System.Drawing.Size(78, 68)
        Me.imgEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEmpresa.TabIndex = 1
        Me.imgEmpresa.TabStop = False
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Image = Global.ProyectoEntradaSalida.My.Resources.Resources.IESMarcosZaragoza
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(-2, -3)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(434, 99)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 0
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 452)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelContraseña)
        Me.Controls.Add(Me.labelNombreUsuario)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.imgEmpresa)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Name = "frmLogin"
        Me.Text = "Formulario Login"
        CType(Me.imgEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents labelNombreUsuario As Label
    Friend WithEvents labelContraseña As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents imgEmpresa As PictureBox
    Friend WithEvents imgCabeceraMZ As PictureBox
End Class

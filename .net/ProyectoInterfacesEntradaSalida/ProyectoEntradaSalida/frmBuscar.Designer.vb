<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.labelUsuario = New System.Windows.Forms.Label()
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        Me.rbtnProfesor = New System.Windows.Forms.RadioButton()
        Me.rbtnAula = New System.Windows.Forms.RadioButton()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelHora = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.labelEstado = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 92)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "<----"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'labelUsuario
        '
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsuario.Location = New System.Drawing.Point(65, 56)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(183, 20)
        Me.labelUsuario.TabIndex = 8
        Me.labelUsuario.Text = "Usuario: NombreUsuario"
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Image = Global.ProyectoEntradaSalida.My.Resources.Resources.IESMarcosZaragoza
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(1, 0)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(429, 86)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 7
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'rbtnProfesor
        '
        Me.rbtnProfesor.AutoSize = True
        Me.rbtnProfesor.Checked = True
        Me.rbtnProfesor.Location = New System.Drawing.Point(140, 143)
        Me.rbtnProfesor.Name = "rbtnProfesor"
        Me.rbtnProfesor.Size = New System.Drawing.Size(64, 17)
        Me.rbtnProfesor.TabIndex = 9
        Me.rbtnProfesor.TabStop = True
        Me.rbtnProfesor.Text = "Profesor"
        Me.rbtnProfesor.UseVisualStyleBackColor = True
        '
        'rbtnAula
        '
        Me.rbtnAula.AutoSize = True
        Me.rbtnAula.Location = New System.Drawing.Point(258, 143)
        Me.rbtnAula.Name = "rbtnAula"
        Me.rbtnAula.Size = New System.Drawing.Size(46, 17)
        Me.rbtnAula.TabIndex = 10
        Me.rbtnAula.Text = "Aula"
        Me.rbtnAula.UseVisualStyleBackColor = True
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(54, 209)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(44, 13)
        Me.labelNombre.TabIndex = 11
        Me.labelNombre.Text = "Nombre"
        '
        'labelHora
        '
        Me.labelHora.AutoSize = True
        Me.labelHora.Location = New System.Drawing.Point(54, 255)
        Me.labelHora.Name = "labelHora"
        Me.labelHora.Size = New System.Drawing.Size(30, 13)
        Me.labelHora.TabIndex = 12
        Me.labelHora.Text = "Hora"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(131, 206)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 20)
        Me.txtNombre.TabIndex = 13
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(131, 252)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(224, 20)
        Me.txtHora.TabIndex = 14
        '
        'labelEstado
        '
        Me.labelEstado.AutoSize = True
        Me.labelEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEstado.Location = New System.Drawing.Point(54, 342)
        Me.labelEstado.Name = "labelEstado"
        Me.labelEstado.Size = New System.Drawing.Size(55, 18)
        Me.labelEstado.TabIndex = 15
        Me.labelEstado.Text = "Estado"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(280, 337)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 452)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.labelEstado)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.labelHora)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.rbtnAula)
        Me.Controls.Add(Me.rbtnProfesor)
        Me.Controls.Add(Me.labelUsuario)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmBuscar"
        Me.Text = "frmBuscar"
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents labelUsuario As Label
    Friend WithEvents imgCabeceraMZ As PictureBox
    Friend WithEvents rbtnProfesor As RadioButton
    Friend WithEvents rbtnAula As RadioButton
    Friend WithEvents labelNombre As Label
    Friend WithEvents labelHora As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents labelEstado As Label
    Friend WithEvents btnBuscar As Button
End Class

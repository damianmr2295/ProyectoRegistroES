<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.labelUsuario = New System.Windows.Forms.Label()
        Me.btnFichar = New System.Windows.Forms.Button()
        Me.btnHorario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.labelUltimaConexion = New System.Windows.Forms.Label()
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelUsuario
        '
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsuario.Location = New System.Drawing.Point(96, 76)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(183, 20)
        Me.labelUsuario.TabIndex = 2
        Me.labelUsuario.Text = "Usuario: NombreUsuario"
        '
        'btnFichar
        '
        Me.btnFichar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar.Location = New System.Drawing.Point(121, 165)
        Me.btnFichar.Name = "btnFichar"
        Me.btnFichar.Size = New System.Drawing.Size(158, 59)
        Me.btnFichar.TabIndex = 3
        Me.btnFichar.Text = "Fichar"
        Me.btnFichar.UseVisualStyleBackColor = True
        '
        'btnHorario
        '
        Me.btnHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorario.Location = New System.Drawing.Point(121, 290)
        Me.btnHorario.Name = "btnHorario"
        Me.btnHorario.Size = New System.Drawing.Size(158, 59)
        Me.btnHorario.TabIndex = 5
        Me.btnHorario.Text = "Horario"
        Me.btnHorario.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(121, 425)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(158, 59)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(383, 165)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(158, 59)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'labelUltimaConexion
        '
        Me.labelUltimaConexion.AutoSize = True
        Me.labelUltimaConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUltimaConexion.Location = New System.Drawing.Point(400, 310)
        Me.labelUltimaConexion.Name = "labelUltimaConexion"
        Me.labelUltimaConexion.Size = New System.Drawing.Size(114, 18)
        Me.labelUltimaConexion.TabIndex = 10
        Me.labelUltimaConexion.Text = "Ultima conexión"
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(0, 1)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(627, 113)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 1
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 616)
        Me.Controls.Add(Me.labelUltimaConexion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnHorario)
        Me.Controls.Add(Me.btnFichar)
        Me.Controls.Add(Me.labelUsuario)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgCabeceraMZ As PictureBox
    Friend WithEvents labelUsuario As Label
    Friend WithEvents btnFichar As Button
    Friend WithEvents btnHorario As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents labelUltimaConexion As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichar))
        Me.labelUsuario = New System.Windows.Forms.Label()
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.labelDiaActual = New System.Windows.Forms.Label()
        Me.labelIniFinAula3 = New System.Windows.Forms.Label()
        Me.labelIniFinAula2 = New System.Windows.Forms.Label()
        Me.labelIniFinAula4 = New System.Windows.Forms.Label()
        Me.labelIniFinAula1 = New System.Windows.Forms.Label()
        Me.labelIniFinAula5 = New System.Windows.Forms.Label()
        Me.btnFichar1 = New System.Windows.Forms.Button()
        Me.btnFichar2 = New System.Windows.Forms.Button()
        Me.btnFichar3 = New System.Windows.Forms.Button()
        Me.btnFichar4 = New System.Windows.Forms.Button()
        Me.btnFichar5 = New System.Windows.Forms.Button()
        Me.btnFichar6 = New System.Windows.Forms.Button()
        Me.labelIniFinAula6 = New System.Windows.Forms.Label()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelUsuario
        '
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsuario.Location = New System.Drawing.Point(64, 56)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(183, 20)
        Me.labelUsuario.TabIndex = 4
        Me.labelUsuario.Text = "Usuario: NombreUsuario"
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Image = Global.ProyectoEntradaSalida.My.Resources.Resources.IESMarcosZaragoza
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(0, 0)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(429, 86)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 3
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 105)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "<----"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'labelDiaActual
        '
        Me.labelDiaActual.AutoSize = True
        Me.labelDiaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDiaActual.Location = New System.Drawing.Point(158, 105)
        Me.labelDiaActual.Name = "labelDiaActual"
        Me.labelDiaActual.Size = New System.Drawing.Size(101, 20)
        Me.labelDiaActual.TabIndex = 6
        Me.labelDiaActual.Text = "Fecha actual"
        '
        'labelIniFinAula3
        '
        Me.labelIniFinAula3.AutoSize = True
        Me.labelIniFinAula3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula3.Location = New System.Drawing.Point(64, 254)
        Me.labelIniFinAula3.Name = "labelIniFinAula3"
        Me.labelIniFinAula3.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula3.TabIndex = 7
        Me.labelIniFinAula3.Text = "Hora inicio / Hora fin / Aula"
        '
        'labelIniFinAula2
        '
        Me.labelIniFinAula2.AutoSize = True
        Me.labelIniFinAula2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula2.Location = New System.Drawing.Point(64, 210)
        Me.labelIniFinAula2.Name = "labelIniFinAula2"
        Me.labelIniFinAula2.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula2.TabIndex = 8
        Me.labelIniFinAula2.Text = "Hora inicio / Hora fin / Aula"
        '
        'labelIniFinAula4
        '
        Me.labelIniFinAula4.AutoSize = True
        Me.labelIniFinAula4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula4.Location = New System.Drawing.Point(64, 299)
        Me.labelIniFinAula4.Name = "labelIniFinAula4"
        Me.labelIniFinAula4.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula4.TabIndex = 9
        Me.labelIniFinAula4.Text = "Hora inicio / Hora fin / Aula"
        '
        'labelIniFinAula1
        '
        Me.labelIniFinAula1.AutoSize = True
        Me.labelIniFinAula1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula1.Location = New System.Drawing.Point(64, 165)
        Me.labelIniFinAula1.Name = "labelIniFinAula1"
        Me.labelIniFinAula1.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula1.TabIndex = 10
        Me.labelIniFinAula1.Text = "Hora inicio / Hora fin / Aula"
        '
        'labelIniFinAula5
        '
        Me.labelIniFinAula5.AutoSize = True
        Me.labelIniFinAula5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula5.Location = New System.Drawing.Point(64, 344)
        Me.labelIniFinAula5.Name = "labelIniFinAula5"
        Me.labelIniFinAula5.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula5.TabIndex = 11
        Me.labelIniFinAula5.Text = "Hora inicio / Hora fin / Aula"
        '
        'btnFichar1
        '
        Me.btnFichar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar1.Location = New System.Drawing.Point(299, 159)
        Me.btnFichar1.Name = "btnFichar1"
        Me.btnFichar1.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar1.TabIndex = 12
        Me.btnFichar1.Text = "Fichar"
        Me.btnFichar1.UseVisualStyleBackColor = True
        '
        'btnFichar2
        '
        Me.btnFichar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar2.Location = New System.Drawing.Point(299, 204)
        Me.btnFichar2.Name = "btnFichar2"
        Me.btnFichar2.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar2.TabIndex = 13
        Me.btnFichar2.Text = "Fichar"
        Me.btnFichar2.UseVisualStyleBackColor = True
        '
        'btnFichar3
        '
        Me.btnFichar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar3.Location = New System.Drawing.Point(299, 248)
        Me.btnFichar3.Name = "btnFichar3"
        Me.btnFichar3.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar3.TabIndex = 14
        Me.btnFichar3.Text = "Fichar"
        Me.btnFichar3.UseVisualStyleBackColor = True
        '
        'btnFichar4
        '
        Me.btnFichar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar4.Location = New System.Drawing.Point(299, 293)
        Me.btnFichar4.Name = "btnFichar4"
        Me.btnFichar4.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar4.TabIndex = 15
        Me.btnFichar4.Text = "Fichar"
        Me.btnFichar4.UseVisualStyleBackColor = True
        '
        'btnFichar5
        '
        Me.btnFichar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar5.Location = New System.Drawing.Point(299, 338)
        Me.btnFichar5.Name = "btnFichar5"
        Me.btnFichar5.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar5.TabIndex = 16
        Me.btnFichar5.Text = "Fichar"
        Me.btnFichar5.UseVisualStyleBackColor = True
        '
        'btnFichar6
        '
        Me.btnFichar6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar6.Location = New System.Drawing.Point(299, 381)
        Me.btnFichar6.Name = "btnFichar6"
        Me.btnFichar6.Size = New System.Drawing.Size(100, 26)
        Me.btnFichar6.TabIndex = 18
        Me.btnFichar6.Text = "Fichar"
        Me.btnFichar6.UseVisualStyleBackColor = True
        '
        'labelIniFinAula6
        '
        Me.labelIniFinAula6.AutoSize = True
        Me.labelIniFinAula6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelIniFinAula6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIniFinAula6.Location = New System.Drawing.Point(64, 387)
        Me.labelIniFinAula6.Name = "labelIniFinAula6"
        Me.labelIniFinAula6.Size = New System.Drawing.Size(195, 20)
        Me.labelIniFinAula6.TabIndex = 17
        Me.labelIniFinAula6.Text = "Hora inicio / Hora fin / Aula"
        '
        'frmFichar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 452)
        Me.Controls.Add(Me.btnFichar6)
        Me.Controls.Add(Me.labelIniFinAula6)
        Me.Controls.Add(Me.btnFichar5)
        Me.Controls.Add(Me.btnFichar4)
        Me.Controls.Add(Me.btnFichar3)
        Me.Controls.Add(Me.btnFichar2)
        Me.Controls.Add(Me.btnFichar1)
        Me.Controls.Add(Me.labelIniFinAula5)
        Me.Controls.Add(Me.labelIniFinAula1)
        Me.Controls.Add(Me.labelIniFinAula4)
        Me.Controls.Add(Me.labelIniFinAula2)
        Me.Controls.Add(Me.labelIniFinAula3)
        Me.Controls.Add(Me.labelDiaActual)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.labelUsuario)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Name = "frmFichar"
        Me.Text = "Fichar"
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelUsuario As Label
    Friend WithEvents imgCabeceraMZ As PictureBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents labelDiaActual As Label
    Friend WithEvents labelIniFinAula3 As Label
    Friend WithEvents labelIniFinAula2 As Label
    Friend WithEvents labelIniFinAula4 As Label
    Friend WithEvents labelIniFinAula1 As Label
    Friend WithEvents labelIniFinAula5 As Label
    Friend WithEvents btnFichar1 As Button
    Friend WithEvents btnFichar2 As Button
    Friend WithEvents btnFichar3 As Button
    Friend WithEvents btnFichar4 As Button
    Friend WithEvents btnFichar5 As Button
    Friend WithEvents btnFichar6 As Button
    Friend WithEvents labelIniFinAula6 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorario))
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.labelUsuario = New System.Windows.Forms.Label()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(1, -1)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(873, 115)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 2
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(847, 390)
        Me.DataGridView1.TabIndex = 22
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 137)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 23
        Me.btnAtras.Text = "<----"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'labelUsuario
        '
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsuario.Location = New System.Drawing.Point(119, 78)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(183, 20)
        Me.labelUsuario.TabIndex = 24
        Me.labelUsuario.Text = "Usuario: NombreUsuario"
        '
        'frmHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 654)
        Me.Controls.Add(Me.labelUsuario)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Name = "frmHorario"
        Me.Text = "frmHorario"
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgCabeceraMZ As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAtras As Button
    Friend WithEvents labelUsuario As Label
End Class

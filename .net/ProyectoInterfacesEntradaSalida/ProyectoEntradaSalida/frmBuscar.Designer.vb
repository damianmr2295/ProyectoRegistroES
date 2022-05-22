<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.labelUsuario = New System.Windows.Forms.Label()
        Me.imgCabeceraMZ = New System.Windows.Forms.PictureBox()
        Me.rbtnProfesor = New System.Windows.Forms.RadioButton()
        Me.rbtnAula = New System.Windows.Forms.RadioButton()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelHoraIni = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.comBoxHoraInic = New System.Windows.Forms.ComboBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.rbtnNoFichados = New System.Windows.Forms.RadioButton()
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 101)
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
        Me.labelUsuario.Location = New System.Drawing.Point(91, 55)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(183, 20)
        Me.labelUsuario.TabIndex = 8
        Me.labelUsuario.Text = "Usuario: NombreUsuario"
        '
        'imgCabeceraMZ
        '
        Me.imgCabeceraMZ.ErrorImage = CType(resources.GetObject("imgCabeceraMZ.ErrorImage"), System.Drawing.Image)
        Me.imgCabeceraMZ.Location = New System.Drawing.Point(1, 0)
        Me.imgCabeceraMZ.Name = "imgCabeceraMZ"
        Me.imgCabeceraMZ.Size = New System.Drawing.Size(628, 86)
        Me.imgCabeceraMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCabeceraMZ.TabIndex = 7
        Me.imgCabeceraMZ.TabStop = False
        Me.imgCabeceraMZ.WaitOnLoad = True
        '
        'rbtnProfesor
        '
        Me.rbtnProfesor.AutoSize = True
        Me.rbtnProfesor.Checked = True
        Me.rbtnProfesor.Location = New System.Drawing.Point(68, 162)
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
        Me.rbtnAula.Location = New System.Drawing.Point(228, 162)
        Me.rbtnAula.Name = "rbtnAula"
        Me.rbtnAula.Size = New System.Drawing.Size(46, 17)
        Me.rbtnAula.TabIndex = 10
        Me.rbtnAula.Text = "Aula"
        Me.rbtnAula.UseVisualStyleBackColor = True
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(67, 205)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(44, 13)
        Me.labelNombre.TabIndex = 11
        Me.labelNombre.Text = "Nombre"
        '
        'labelHoraIni
        '
        Me.labelHoraIni.AutoSize = True
        Me.labelHoraIni.Enabled = False
        Me.labelHoraIni.Location = New System.Drawing.Point(67, 280)
        Me.labelHoraIni.Name = "labelHoraIni"
        Me.labelHoraIni.Size = New System.Drawing.Size(98, 13)
        Me.labelHoraIni.TabIndex = 12
        Me.labelHoraIni.Text = "Hora Inicio (hh:mm)"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(315, 202)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(277, 20)
        Me.txtNombre.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(517, 563)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 335)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 212)
        Me.DataGridView1.TabIndex = 21
        '
        'comBoxHoraInic
        '
        Me.comBoxHoraInic.DisplayMember = "09:00 h"
        Me.comBoxHoraInic.Enabled = False
        Me.comBoxHoraInic.FormattingEnabled = True
        Me.comBoxHoraInic.Items.AddRange(New Object() {"08:00 h - 09:00 h", "09:00 h - 10:00 h", "10:00 h - 11:00 h", "11:00 h - 12:00 h", "12:00 h - 13:00 h", "13:00 h - 14:00 h"})
        Me.comBoxHoraInic.Location = New System.Drawing.Point(315, 277)
        Me.comBoxHoraInic.Name = "comBoxHoraInic"
        Me.comBoxHoraInic.Size = New System.Drawing.Size(277, 21)
        Me.comBoxHoraInic.TabIndex = 19
        Me.comBoxHoraInic.Text = "08:00 h - 09:00 h"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(315, 240)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(277, 20)
        Me.fecha.TabIndex = 24
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(67, 246)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(37, 13)
        Me.labelFecha.TabIndex = 23
        Me.labelFecha.Text = "Fecha"
        '
        'rbtnNoFichados
        '
        Me.rbtnNoFichados.AutoSize = True
        Me.rbtnNoFichados.Location = New System.Drawing.Point(397, 162)
        Me.rbtnNoFichados.Name = "rbtnNoFichados"
        Me.rbtnNoFichados.Size = New System.Drawing.Size(133, 17)
        Me.rbtnNoFichados.TabIndex = 25
        Me.rbtnNoFichados.Text = "Profesores no fichados"
        Me.rbtnNoFichados.UseVisualStyleBackColor = True
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 616)
        Me.Controls.Add(Me.rbtnNoFichados)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comBoxHoraInic)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.labelHoraIni)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.rbtnAula)
        Me.Controls.Add(Me.rbtnProfesor)
        Me.Controls.Add(Me.labelUsuario)
        Me.Controls.Add(Me.imgCabeceraMZ)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmBuscar"
        Me.Text = "frmBuscar"
        CType(Me.imgCabeceraMZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents labelUsuario As Label
    Friend WithEvents imgCabeceraMZ As PictureBox
    Friend WithEvents rbtnProfesor As RadioButton
    Friend WithEvents rbtnAula As RadioButton
    Friend WithEvents labelNombre As Label
    Friend WithEvents labelHoraIni As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comBoxHoraInic As ComboBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents labelFecha As Label
    Friend WithEvents rbtnNoFichados As RadioButton
End Class

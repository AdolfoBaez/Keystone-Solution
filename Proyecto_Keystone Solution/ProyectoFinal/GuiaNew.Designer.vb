<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuiaNew
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
        Me.btnSGuia = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxPrioridad = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSGuia
        '
        Me.btnSGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSGuia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSGuia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSGuia.Location = New System.Drawing.Point(758, 417)
        Me.btnSGuia.Name = "btnSGuia"
        Me.btnSGuia.Size = New System.Drawing.Size(86, 41)
        Me.btnSGuia.TabIndex = 5
        Me.btnSGuia.Text = "Guardar"
        Me.btnSGuia.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Prioridad"
        '
        'CBoxPrioridad
        '
        Me.CBoxPrioridad.FormattingEnabled = True
        Me.CBoxPrioridad.Location = New System.Drawing.Point(185, 381)
        Me.CBoxPrioridad.Name = "CBoxPrioridad"
        Me.CBoxPrioridad.Size = New System.Drawing.Size(121, 21)
        Me.CBoxPrioridad.TabIndex = 59
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.paqueteria
        Me.PictureBox1.Location = New System.Drawing.Point(378, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(50, 72)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(256, 303)
        Me.RichTextBox1.TabIndex = 60
        Me.RichTextBox1.Text = ""
        '
        'GuiaNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 478)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CBoxPrioridad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSGuia)
        Me.Name = "GuiaNew"
        Me.Text = "GuiaNew"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSGuia As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBoxPrioridad As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

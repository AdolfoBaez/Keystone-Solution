<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAcerca = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnHorario = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEnvios = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnContactos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalendario = New System.Windows.Forms.Button()
        Me.LogoKytn = New System.Windows.Forms.PictureBox()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.LogoKytn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelCabecera)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1084, 541)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.Control
        Me.PanelFormularios.Controls.Add(Me.Label2)
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Controls.Add(Me.Label1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(220, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(864, 501)
        Me.PanelFormularios.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Fondo_de_pantalla
        Me.PictureBox1.Location = New System.Drawing.Point(134, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Keystone es una empresa que da soluciones integrales en recursos humanos."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.btnAcerca)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.btnHorario)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btnEnvios)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btnContactos)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnCalendario)
        Me.PanelMenu.Controls.Add(Me.LogoKytn)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 501)
        Me.PanelMenu.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 11
        '
        'btnAcerca
        '
        Me.btnAcerca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcerca.FlatAppearance.BorderSize = 0
        Me.btnAcerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcerca.ForeColor = System.Drawing.Color.White
        Me.btnAcerca.Image = Global.ProyectoFinal.My.Resources.Resources.about_us
        Me.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcerca.Location = New System.Drawing.Point(5, 371)
        Me.btnAcerca.Name = "btnAcerca"
        Me.btnAcerca.Size = New System.Drawing.Size(209, 50)
        Me.btnAcerca.TabIndex = 10
        Me.btnAcerca.Text = "     Acerca de"
        Me.btnAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcerca.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 315)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 9
        '
        'btnHorario
        '
        Me.btnHorario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHorario.FlatAppearance.BorderSize = 0
        Me.btnHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorario.ForeColor = System.Drawing.Color.White
        Me.btnHorario.Image = Global.ProyectoFinal.My.Resources.Resources.horario
        Me.btnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorario.Location = New System.Drawing.Point(5, 315)
        Me.btnHorario.Name = "btnHorario"
        Me.btnHorario.Size = New System.Drawing.Size(209, 50)
        Me.btnHorario.TabIndex = 8
        Me.btnHorario.Text = "     Horario"
        Me.btnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHorario.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 7
        '
        'btnEnvios
        '
        Me.btnEnvios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnvios.FlatAppearance.BorderSize = 0
        Me.btnEnvios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnEnvios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvios.ForeColor = System.Drawing.Color.White
        Me.btnEnvios.Image = Global.ProyectoFinal.My.Resources.Resources.this_side_up
        Me.btnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvios.Location = New System.Drawing.Point(5, 259)
        Me.btnEnvios.Name = "btnEnvios"
        Me.btnEnvios.Size = New System.Drawing.Size(209, 50)
        Me.btnEnvios.TabIndex = 6
        Me.btnEnvios.Text = "     Envíos"
        Me.btnEnvios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvios.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 5
        '
        'btnContactos
        '
        Me.btnContactos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContactos.FlatAppearance.BorderSize = 0
        Me.btnContactos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactos.ForeColor = System.Drawing.Color.White
        Me.btnContactos.Image = Global.ProyectoFinal.My.Resources.Resources.agenda
        Me.btnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContactos.Location = New System.Drawing.Point(5, 203)
        Me.btnContactos.Name = "btnContactos"
        Me.btnContactos.Size = New System.Drawing.Size(209, 50)
        Me.btnContactos.TabIndex = 4
        Me.btnContactos.Text = "     Contactos"
        Me.btnContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContactos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 3
        '
        'btnCalendario
        '
        Me.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalendario.FlatAppearance.BorderSize = 0
        Me.btnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendario.ForeColor = System.Drawing.Color.White
        Me.btnCalendario.Image = Global.ProyectoFinal.My.Resources.Resources.calendar_f
        Me.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalendario.Location = New System.Drawing.Point(5, 147)
        Me.btnCalendario.Name = "btnCalendario"
        Me.btnCalendario.Size = New System.Drawing.Size(209, 50)
        Me.btnCalendario.TabIndex = 2
        Me.btnCalendario.Text = "    Calendario"
        Me.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalendario.UseVisualStyleBackColor = True
        '
        'LogoKytn
        '
        Me.LogoKytn.Cursor = System.Windows.Forms.Cursors.Default
        Me.LogoKytn.Image = Global.ProyectoFinal.My.Resources.Resources.keystone
        Me.LogoKytn.Location = New System.Drawing.Point(0, 52)
        Me.LogoKytn.Name = "LogoKytn"
        Me.LogoKytn.Size = New System.Drawing.Size(220, 77)
        Me.LogoKytn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoKytn.TabIndex = 1
        Me.LogoKytn.TabStop = False
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.btnRestaurar)
        Me.PanelCabecera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabecera.Controls.Add(Me.btnMaximizar)
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1084, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1021, 6)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(28, 28)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestaurar.TabIndex = 5
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(990, 6)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(28, 28)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1021, 6)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(28, 28)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 3
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_cerrar_FN1
        Me.btnCerrar.Location = New System.Drawing.Point(1052, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(37, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Keystone Capital Humano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1084, 541)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.LogoKytn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCabecera.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAcerca As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnHorario As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEnvios As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnContactos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCalendario As Button
    Friend WithEvents LogoKytn As PictureBox
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

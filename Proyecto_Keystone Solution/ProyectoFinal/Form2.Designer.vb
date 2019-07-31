<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.ButtonRest = New System.Windows.Forms.Button()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonMax = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
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
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.NuevaGuia = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.LogoKytn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.NuevaGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.ButtonRest)
        Me.PanelCabecera.Controls.Add(Me.ButtonMin)
        Me.PanelCabecera.Controls.Add(Me.ButtonMax)
        Me.PanelCabecera.Controls.Add(Me.ButtonCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(800, 40)
        Me.PanelCabecera.TabIndex = 1
        '
        'ButtonRest
        '
        Me.ButtonRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRest.FlatAppearance.BorderSize = 0
        Me.ButtonRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.ButtonRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRest.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Restaurar
        Me.ButtonRest.Location = New System.Drawing.Point(702, 0)
        Me.ButtonRest.Name = "ButtonRest"
        Me.ButtonRest.Size = New System.Drawing.Size(40, 40)
        Me.ButtonRest.TabIndex = 3
        Me.ButtonRest.UseVisualStyleBackColor = True
        Me.ButtonRest.Visible = False
        '
        'ButtonMin
        '
        Me.ButtonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMin.FlatAppearance.BorderSize = 0
        Me.ButtonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMin.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Minimizar
        Me.ButtonMin.Location = New System.Drawing.Point(656, 0)
        Me.ButtonMin.Name = "ButtonMin"
        Me.ButtonMin.Size = New System.Drawing.Size(40, 40)
        Me.ButtonMin.TabIndex = 2
        Me.ButtonMin.UseVisualStyleBackColor = True
        '
        'ButtonMax
        '
        Me.ButtonMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMax.FlatAppearance.BorderSize = 0
        Me.ButtonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.ButtonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMax.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_Maximizar
        Me.ButtonMax.Location = New System.Drawing.Point(702, 0)
        Me.ButtonMax.Name = "ButtonMax"
        Me.ButtonMax.Size = New System.Drawing.Size(40, 40)
        Me.ButtonMax.TabIndex = 1
        Me.ButtonMax.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCerrar.FlatAppearance.BorderSize = 0
        Me.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = Global.ProyectoFinal.My.Resources.Resources.Icono_cerrar_FN
        Me.ButtonCerrar.Location = New System.Drawing.Point(748, 0)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonCerrar.TabIndex = 0
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
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
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 410)
        Me.PanelMenu.TabIndex = 2
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
        Me.LogoKytn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoKytn.Image = Global.ProyectoFinal.My.Resources.Resources.keystone
        Me.LogoKytn.Location = New System.Drawing.Point(0, 52)
        Me.LogoKytn.Name = "LogoKytn"
        Me.LogoKytn.Size = New System.Drawing.Size(220, 77)
        Me.LogoKytn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoKytn.TabIndex = 1
        Me.LogoKytn.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.ProyectoFinal.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(165, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 33)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Controls.Add(Me.NuevaGuia)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(580, 410)
        Me.PanelContenedor.TabIndex = 3
        '
        'NuevaGuia
        '
        Me.NuevaGuia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevaGuia.Image = Global.ProyectoFinal.My.Resources.Resources.add_button_inside_black_circle__1_
        Me.NuevaGuia.Location = New System.Drawing.Point(778, 414)
        Me.NuevaGuia.Name = "NuevaGuia"
        Me.NuevaGuia.Size = New System.Drawing.Size(64, 64)
        Me.NuevaGuia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NuevaGuia.TabIndex = 12
        Me.NuevaGuia.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.add_button_inside_black_circle__1_
        Me.PictureBox1.Location = New System.Drawing.Point(482, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.LogoKytn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.NuevaGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents ButtonRest As Button
    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonMax As Button
    Friend WithEvents ButtonCerrar As Button
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
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents NuevaGuia As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

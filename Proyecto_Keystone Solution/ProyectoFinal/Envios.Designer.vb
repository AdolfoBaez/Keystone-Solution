<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Envios
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
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.btnListaGuias = New System.Windows.Forms.Button()
        Me.Registrar = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtContenidoG = New System.Windows.Forms.TextBox()
        Me.labelContenidoG = New System.Windows.Forms.Label()
        Me.ComboBoxPrioridad = New System.Windows.Forms.ComboBox()
        Me.LabelGuiaE = New System.Windows.Forms.Label()
        Me.btnRegistrarG = New System.Windows.Forms.Button()
        Me.txtCiudadDG = New System.Windows.Forms.TextBox()
        Me.txtCiudadOG = New System.Windows.Forms.TextBox()
        Me.txtParaG = New System.Windows.Forms.TextBox()
        Me.txtDeG = New System.Windows.Forms.TextBox()
        Me.txtNombreG = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Actualizar = New System.Windows.Forms.TabPage()
        Me.txtContenidoGA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxPrioridadA = New System.Windows.Forms.ComboBox()
        Me.txtCiudadDGA = New System.Windows.Forms.TextBox()
        Me.txtCiudadOGA = New System.Windows.Forms.TextBox()
        Me.txtParaGA = New System.Windows.Forms.TextBox()
        Me.txtDeGA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnActualizarG = New System.Windows.Forms.Button()
        Me.btnBuscarG = New System.Windows.Forms.Button()
        Me.txtNombreGA = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.TabPage()
        Me.btnEliminarG = New System.Windows.Forms.Button()
        Me.txtContenidoGE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxPrioridadE = New System.Windows.Forms.ComboBox()
        Me.txtCiudadDGE = New System.Windows.Forms.TextBox()
        Me.txtCiudadOGE = New System.Windows.Forms.TextBox()
        Me.txtParaGE = New System.Windows.Forms.TextBox()
        Me.txtDeGE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnBuscarGE = New System.Windows.Forms.Button()
        Me.txtNombreGE = New System.Windows.Forms.TextBox()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Registrar.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Actualizar.SuspendLayout()
        Me.Eliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Image = Global.ProyectoFinal.My.Resources.Resources.cancel
        Me.btnCerrarForm.Location = New System.Drawing.Point(820, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 3
        Me.btnCerrarForm.TabStop = False
        '
        'btnListaGuias
        '
        Me.btnListaGuias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaGuias.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnListaGuias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnListaGuias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListaGuias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaGuias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaGuias.ForeColor = System.Drawing.SystemColors.Control
        Me.btnListaGuias.Location = New System.Drawing.Point(670, 412)
        Me.btnListaGuias.Name = "btnListaGuias"
        Me.btnListaGuias.Size = New System.Drawing.Size(166, 34)
        Me.btnListaGuias.TabIndex = 53
        Me.btnListaGuias.Text = "Listado de Guias"
        Me.btnListaGuias.UseVisualStyleBackColor = False
        '
        'Registrar
        '
        Me.Registrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Registrar.Controls.Add(Me.TabPage1)
        Me.Registrar.Controls.Add(Me.Actualizar)
        Me.Registrar.Controls.Add(Me.Eliminar)
        Me.Registrar.Location = New System.Drawing.Point(38, 12)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.SelectedIndex = 0
        Me.Registrar.Size = New System.Drawing.Size(566, 350)
        Me.Registrar.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.txtContenidoG)
        Me.TabPage1.Controls.Add(Me.labelContenidoG)
        Me.TabPage1.Controls.Add(Me.ComboBoxPrioridad)
        Me.TabPage1.Controls.Add(Me.LabelGuiaE)
        Me.TabPage1.Controls.Add(Me.btnRegistrarG)
        Me.TabPage1.Controls.Add(Me.txtCiudadDG)
        Me.TabPage1.Controls.Add(Me.txtCiudadOG)
        Me.TabPage1.Controls.Add(Me.txtParaG)
        Me.TabPage1.Controls.Add(Me.txtDeG)
        Me.TabPage1.Controls.Add(Me.txtNombreG)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(558, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'txtContenidoG
        '
        Me.txtContenidoG.Location = New System.Drawing.Point(170, 221)
        Me.txtContenidoG.Name = "txtContenidoG"
        Me.txtContenidoG.Size = New System.Drawing.Size(180, 20)
        Me.txtContenidoG.TabIndex = 55
        '
        'labelContenidoG
        '
        Me.labelContenidoG.AutoSize = True
        Me.labelContenidoG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContenidoG.ForeColor = System.Drawing.Color.White
        Me.labelContenidoG.Location = New System.Drawing.Point(41, 221)
        Me.labelContenidoG.Name = "labelContenidoG"
        Me.labelContenidoG.Size = New System.Drawing.Size(76, 17)
        Me.labelContenidoG.TabIndex = 54
        Me.labelContenidoG.Text = "Contenido:"
        '
        'ComboBoxPrioridad
        '
        Me.ComboBoxPrioridad.FormattingEnabled = True
        Me.ComboBoxPrioridad.Items.AddRange(New Object() {"Muy Alta", "Alta", "Normal", "Baja"})
        Me.ComboBoxPrioridad.Location = New System.Drawing.Point(170, 249)
        Me.ComboBoxPrioridad.Name = "ComboBoxPrioridad"
        Me.ComboBoxPrioridad.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPrioridad.TabIndex = 53
        '
        'LabelGuiaE
        '
        Me.LabelGuiaE.AutoSize = True
        Me.LabelGuiaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuiaE.ForeColor = System.Drawing.Color.White
        Me.LabelGuiaE.Location = New System.Drawing.Point(40, 32)
        Me.LabelGuiaE.Name = "LabelGuiaE"
        Me.LabelGuiaE.Size = New System.Drawing.Size(108, 20)
        Me.LabelGuiaE.TabIndex = 51
        Me.LabelGuiaE.Text = "Guía de Envío"
        '
        'btnRegistrarG
        '
        Me.btnRegistrarG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarG.Location = New System.Drawing.Point(460, 284)
        Me.btnRegistrarG.Name = "btnRegistrarG"
        Me.btnRegistrarG.Size = New System.Drawing.Size(92, 34)
        Me.btnRegistrarG.TabIndex = 50
        Me.btnRegistrarG.Text = "Registrar"
        Me.btnRegistrarG.UseVisualStyleBackColor = False
        '
        'txtCiudadDG
        '
        Me.txtCiudadDG.Location = New System.Drawing.Point(170, 192)
        Me.txtCiudadDG.Name = "txtCiudadDG"
        Me.txtCiudadDG.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadDG.TabIndex = 17
        '
        'txtCiudadOG
        '
        Me.txtCiudadOG.Location = New System.Drawing.Point(170, 163)
        Me.txtCiudadOG.Name = "txtCiudadOG"
        Me.txtCiudadOG.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadOG.TabIndex = 16
        '
        'txtParaG
        '
        Me.txtParaG.Location = New System.Drawing.Point(170, 135)
        Me.txtParaG.Name = "txtParaG"
        Me.txtParaG.Size = New System.Drawing.Size(180, 20)
        Me.txtParaG.TabIndex = 15
        '
        'txtDeG
        '
        Me.txtDeG.Location = New System.Drawing.Point(170, 107)
        Me.txtDeG.Name = "txtDeG"
        Me.txtDeG.Size = New System.Drawing.Size(180, 20)
        Me.txtDeG.TabIndex = 14
        '
        'txtNombreG
        '
        Me.txtNombreG.Location = New System.Drawing.Point(170, 81)
        Me.txtNombreG.Name = "txtNombreG"
        Me.txtNombreG.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreG.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Prioridad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ciudad de Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ciudad de Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Para:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "De:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.Actualizar.Controls.Add(Me.txtContenidoGA)
        Me.Actualizar.Controls.Add(Me.Label7)
        Me.Actualizar.Controls.Add(Me.ComboBoxPrioridadA)
        Me.Actualizar.Controls.Add(Me.txtCiudadDGA)
        Me.Actualizar.Controls.Add(Me.txtCiudadOGA)
        Me.Actualizar.Controls.Add(Me.txtParaGA)
        Me.Actualizar.Controls.Add(Me.txtDeGA)
        Me.Actualizar.Controls.Add(Me.Label8)
        Me.Actualizar.Controls.Add(Me.Label9)
        Me.Actualizar.Controls.Add(Me.Label10)
        Me.Actualizar.Controls.Add(Me.Label11)
        Me.Actualizar.Controls.Add(Me.Label12)
        Me.Actualizar.Controls.Add(Me.Label25)
        Me.Actualizar.Controls.Add(Me.btnActualizarG)
        Me.Actualizar.Controls.Add(Me.btnBuscarG)
        Me.Actualizar.Controls.Add(Me.txtNombreGA)
        Me.Actualizar.Location = New System.Drawing.Point(4, 22)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.Actualizar.Size = New System.Drawing.Size(558, 324)
        Me.Actualizar.TabIndex = 1
        Me.Actualizar.Text = "Actualizar"
        '
        'txtContenidoGA
        '
        Me.txtContenidoGA.Location = New System.Drawing.Point(166, 192)
        Me.txtContenidoGA.Name = "txtContenidoGA"
        Me.txtContenidoGA.Size = New System.Drawing.Size(180, 20)
        Me.txtContenidoGA.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(37, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Contenido:"
        '
        'ComboBoxPrioridadA
        '
        Me.ComboBoxPrioridadA.FormattingEnabled = True
        Me.ComboBoxPrioridadA.Items.AddRange(New Object() {"Muy Alta", "Alta", "Normal", "Baja"})
        Me.ComboBoxPrioridadA.Location = New System.Drawing.Point(166, 220)
        Me.ComboBoxPrioridadA.Name = "ComboBoxPrioridadA"
        Me.ComboBoxPrioridadA.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPrioridadA.TabIndex = 65
        '
        'txtCiudadDGA
        '
        Me.txtCiudadDGA.Location = New System.Drawing.Point(166, 163)
        Me.txtCiudadDGA.Name = "txtCiudadDGA"
        Me.txtCiudadDGA.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadDGA.TabIndex = 64
        '
        'txtCiudadOGA
        '
        Me.txtCiudadOGA.Location = New System.Drawing.Point(166, 134)
        Me.txtCiudadOGA.Name = "txtCiudadOGA"
        Me.txtCiudadOGA.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadOGA.TabIndex = 63
        '
        'txtParaGA
        '
        Me.txtParaGA.Location = New System.Drawing.Point(166, 106)
        Me.txtParaGA.Name = "txtParaGA"
        Me.txtParaGA.Size = New System.Drawing.Size(180, 20)
        Me.txtParaGA.TabIndex = 62
        '
        'txtDeGA
        '
        Me.txtDeGA.Location = New System.Drawing.Point(166, 78)
        Me.txtDeGA.Name = "txtDeGA"
        Me.txtDeGA.Size = New System.Drawing.Size(180, 20)
        Me.txtDeGA.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(37, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Prioridad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(37, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Ciudad de Destino:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(37, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Ciudad de Origen:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(37, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 17)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Para:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(37, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 17)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "De:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(37, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 17)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Nombre:"
        '
        'btnActualizarG
        '
        Me.btnActualizarG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActualizarG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarG.Location = New System.Drawing.Point(456, 287)
        Me.btnActualizarG.Name = "btnActualizarG"
        Me.btnActualizarG.Size = New System.Drawing.Size(96, 32)
        Me.btnActualizarG.TabIndex = 49
        Me.btnActualizarG.Text = "Actualizar"
        Me.btnActualizarG.UseVisualStyleBackColor = False
        '
        'btnBuscarG
        '
        Me.btnBuscarG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarG.ForeColor = System.Drawing.Color.White
        Me.btnBuscarG.Location = New System.Drawing.Point(312, 24)
        Me.btnBuscarG.Name = "btnBuscarG"
        Me.btnBuscarG.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarG.TabIndex = 16
        Me.btnBuscarG.Text = "Buscar"
        Me.btnBuscarG.UseVisualStyleBackColor = False
        '
        'txtNombreGA
        '
        Me.txtNombreGA.Location = New System.Drawing.Point(101, 27)
        Me.txtNombreGA.Name = "txtNombreGA"
        Me.txtNombreGA.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreGA.TabIndex = 15
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.Eliminar.Controls.Add(Me.txtContenidoGE)
        Me.Eliminar.Controls.Add(Me.Label13)
        Me.Eliminar.Controls.Add(Me.ComboBoxPrioridadE)
        Me.Eliminar.Controls.Add(Me.txtCiudadDGE)
        Me.Eliminar.Controls.Add(Me.txtCiudadOGE)
        Me.Eliminar.Controls.Add(Me.txtParaGE)
        Me.Eliminar.Controls.Add(Me.txtDeGE)
        Me.Eliminar.Controls.Add(Me.Label14)
        Me.Eliminar.Controls.Add(Me.Label15)
        Me.Eliminar.Controls.Add(Me.Label16)
        Me.Eliminar.Controls.Add(Me.Label17)
        Me.Eliminar.Controls.Add(Me.Label18)
        Me.Eliminar.Controls.Add(Me.Label19)
        Me.Eliminar.Controls.Add(Me.btnBuscarGE)
        Me.Eliminar.Controls.Add(Me.txtNombreGE)
        Me.Eliminar.Controls.Add(Me.btnEliminarG)
        Me.Eliminar.Location = New System.Drawing.Point(4, 22)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.Eliminar.Size = New System.Drawing.Size(558, 324)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        '
        'btnEliminarG
        '
        Me.btnEliminarG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminarG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarG.Location = New System.Drawing.Point(456, 286)
        Me.btnEliminarG.Name = "btnEliminarG"
        Me.btnEliminarG.Size = New System.Drawing.Size(96, 32)
        Me.btnEliminarG.TabIndex = 77
        Me.btnEliminarG.Text = "Eliminar"
        Me.btnEliminarG.UseVisualStyleBackColor = False
        '
        'txtContenidoGE
        '
        Me.txtContenidoGE.Location = New System.Drawing.Point(168, 195)
        Me.txtContenidoGE.Name = "txtContenidoGE"
        Me.txtContenidoGE.Size = New System.Drawing.Size(180, 20)
        Me.txtContenidoGE.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(39, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 17)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Contenido:"
        '
        'ComboBoxPrioridadE
        '
        Me.ComboBoxPrioridadE.FormattingEnabled = True
        Me.ComboBoxPrioridadE.Items.AddRange(New Object() {"Muy Alta", "Alta", "Normal", "Baja"})
        Me.ComboBoxPrioridadE.Location = New System.Drawing.Point(168, 223)
        Me.ComboBoxPrioridadE.Name = "ComboBoxPrioridadE"
        Me.ComboBoxPrioridadE.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPrioridadE.TabIndex = 90
        '
        'txtCiudadDGE
        '
        Me.txtCiudadDGE.Location = New System.Drawing.Point(168, 166)
        Me.txtCiudadDGE.Name = "txtCiudadDGE"
        Me.txtCiudadDGE.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadDGE.TabIndex = 89
        '
        'txtCiudadOGE
        '
        Me.txtCiudadOGE.Location = New System.Drawing.Point(168, 137)
        Me.txtCiudadOGE.Name = "txtCiudadOGE"
        Me.txtCiudadOGE.Size = New System.Drawing.Size(180, 20)
        Me.txtCiudadOGE.TabIndex = 88
        '
        'txtParaGE
        '
        Me.txtParaGE.Location = New System.Drawing.Point(168, 109)
        Me.txtParaGE.Name = "txtParaGE"
        Me.txtParaGE.Size = New System.Drawing.Size(180, 20)
        Me.txtParaGE.TabIndex = 87
        '
        'txtDeGE
        '
        Me.txtDeGE.Location = New System.Drawing.Point(168, 81)
        Me.txtDeGE.Name = "txtDeGE"
        Me.txtDeGE.Size = New System.Drawing.Size(180, 20)
        Me.txtDeGE.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(39, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Prioridad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(39, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 17)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Ciudad de Destino:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(39, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 17)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Ciudad de Origen:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(39, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 17)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Para:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(39, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "De:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(39, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 17)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "Nombre:"
        '
        'btnBuscarGE
        '
        Me.btnBuscarGE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarGE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarGE.ForeColor = System.Drawing.Color.White
        Me.btnBuscarGE.Location = New System.Drawing.Point(314, 27)
        Me.btnBuscarGE.Name = "btnBuscarGE"
        Me.btnBuscarGE.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarGE.TabIndex = 79
        Me.btnBuscarGE.Text = "Buscar"
        Me.btnBuscarGE.UseVisualStyleBackColor = False
        '
        'txtNombreGE
        '
        Me.txtNombreGE.Location = New System.Drawing.Point(103, 30)
        Me.txtNombreGE.Name = "txtNombreGE"
        Me.txtNombreGE.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreGE.TabIndex = 78
        '
        'Envios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 462)
        Me.Controls.Add(Me.btnListaGuias)
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Name = "Envios"
        Me.Text = "Envios"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Registrar.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Actualizar.ResumeLayout(False)
        Me.Actualizar.PerformLayout()
        Me.Eliminar.ResumeLayout(False)
        Me.Eliminar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents btnListaGuias As Button
    Friend WithEvents Registrar As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnRegistrarG As Button
    Friend WithEvents txtCiudadDG As TextBox
    Friend WithEvents txtCiudadOG As TextBox
    Friend WithEvents txtParaG As TextBox
    Friend WithEvents txtDeG As TextBox
    Friend WithEvents txtNombreG As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Actualizar As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents btnActualizarG As Button
    Friend WithEvents btnBuscarG As Button
    Friend WithEvents txtNombreGA As TextBox
    Friend WithEvents Eliminar As TabPage
    Friend WithEvents btnEliminarG As Button
    Friend WithEvents LabelGuiaE As Label
    Friend WithEvents ComboBoxPrioridad As ComboBox
    Friend WithEvents txtContenidoG As TextBox
    Friend WithEvents labelContenidoG As Label
    Friend WithEvents txtContenidoGA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxPrioridadA As ComboBox
    Friend WithEvents txtCiudadDGA As TextBox
    Friend WithEvents txtCiudadOGA As TextBox
    Friend WithEvents txtParaGA As TextBox
    Friend WithEvents txtDeGA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtContenidoGE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxPrioridadE As ComboBox
    Friend WithEvents txtCiudadDGE As TextBox
    Friend WithEvents txtCiudadOGE As TextBox
    Friend WithEvents txtParaGE As TextBox
    Friend WithEvents txtDeGE As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnBuscarGE As Button
    Friend WithEvents txtNombreGE As TextBox
End Class

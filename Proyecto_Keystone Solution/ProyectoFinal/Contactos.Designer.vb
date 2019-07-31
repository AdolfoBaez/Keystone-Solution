<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contactos
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
        Me.Registrar = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnRegistrarC = New System.Windows.Forms.Button()
        Me.txtCorreoC = New System.Windows.Forms.TextBox()
        Me.txtCelC = New System.Windows.Forms.TextBox()
        Me.txtTelefonoC = New System.Windows.Forms.TextBox()
        Me.txtPaisC = New System.Windows.Forms.TextBox()
        Me.txtEstadoC = New System.Windows.Forms.TextBox()
        Me.txtMunicipioC = New System.Windows.Forms.TextBox()
        Me.txtColoniaC = New System.Windows.Forms.TextBox()
        Me.txtCPC = New System.Windows.Forms.TextBox()
        Me.txtNumIntC = New System.Windows.Forms.TextBox()
        Me.txtNumExC = New System.Windows.Forms.TextBox()
        Me.txtCalleC = New System.Windows.Forms.TextBox()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Actualizar = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnActualizarC = New System.Windows.Forms.Button()
        Me.txtCorreoCA = New System.Windows.Forms.TextBox()
        Me.txtCelCA = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCA = New System.Windows.Forms.TextBox()
        Me.txtPaisCA = New System.Windows.Forms.TextBox()
        Me.txtEstadoCA = New System.Windows.Forms.TextBox()
        Me.txtMunicipioCA = New System.Windows.Forms.TextBox()
        Me.txtColoniaCA = New System.Windows.Forms.TextBox()
        Me.txtCPCA = New System.Windows.Forms.TextBox()
        Me.txtNumIntCA = New System.Windows.Forms.TextBox()
        Me.txtNumExCA = New System.Windows.Forms.TextBox()
        Me.txtCalleCA = New System.Windows.Forms.TextBox()
        Me.btnBuscarCA = New System.Windows.Forms.Button()
        Me.txtNombreCA = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.btnEliminarC = New System.Windows.Forms.Button()
        Me.txtCorreoCE = New System.Windows.Forms.TextBox()
        Me.txtCelCE = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCE = New System.Windows.Forms.TextBox()
        Me.txtPaisCE = New System.Windows.Forms.TextBox()
        Me.txtEstadoCE = New System.Windows.Forms.TextBox()
        Me.txtMunicipioCE = New System.Windows.Forms.TextBox()
        Me.txtColoniaCE = New System.Windows.Forms.TextBox()
        Me.txtCPCE = New System.Windows.Forms.TextBox()
        Me.txtNumIntCE = New System.Windows.Forms.TextBox()
        Me.txtNumExCE = New System.Windows.Forms.TextBox()
        Me.txtCalleCE = New System.Windows.Forms.TextBox()
        Me.btnBuscarCE = New System.Windows.Forms.Button()
        Me.txtNombreCE = New System.Windows.Forms.TextBox()
        Me.btnListaContactos = New System.Windows.Forms.Button()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Registrar.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Actualizar.SuspendLayout()
        Me.Eliminar.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registrar
        '
        Me.Registrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Registrar.Controls.Add(Me.TabPage1)
        Me.Registrar.Controls.Add(Me.Actualizar)
        Me.Registrar.Controls.Add(Me.Eliminar)
        Me.Registrar.Location = New System.Drawing.Point(63, 12)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.SelectedIndex = 0
        Me.Registrar.Size = New System.Drawing.Size(566, 438)
        Me.Registrar.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.btnRegistrarC)
        Me.TabPage1.Controls.Add(Me.txtCorreoC)
        Me.TabPage1.Controls.Add(Me.txtCelC)
        Me.TabPage1.Controls.Add(Me.txtTelefonoC)
        Me.TabPage1.Controls.Add(Me.txtPaisC)
        Me.TabPage1.Controls.Add(Me.txtEstadoC)
        Me.TabPage1.Controls.Add(Me.txtMunicipioC)
        Me.TabPage1.Controls.Add(Me.txtColoniaC)
        Me.TabPage1.Controls.Add(Me.txtCPC)
        Me.TabPage1.Controls.Add(Me.txtNumIntC)
        Me.TabPage1.Controls.Add(Me.txtNumExC)
        Me.TabPage1.Controls.Add(Me.txtCalleC)
        Me.TabPage1.Controls.Add(Me.txtNombreC)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(558, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'btnRegistrarC
        '
        Me.btnRegistrarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarC.Location = New System.Drawing.Point(460, 372)
        Me.btnRegistrarC.Name = "btnRegistrarC"
        Me.btnRegistrarC.Size = New System.Drawing.Size(92, 34)
        Me.btnRegistrarC.TabIndex = 50
        Me.btnRegistrarC.Text = "Registrar"
        Me.btnRegistrarC.UseVisualStyleBackColor = False
        '
        'txtCorreoC
        '
        Me.txtCorreoC.Location = New System.Drawing.Point(134, 340)
        Me.txtCorreoC.Name = "txtCorreoC"
        Me.txtCorreoC.Size = New System.Drawing.Size(180, 20)
        Me.txtCorreoC.TabIndex = 24
        '
        'txtCelC
        '
        Me.txtCelC.Location = New System.Drawing.Point(134, 315)
        Me.txtCelC.Name = "txtCelC"
        Me.txtCelC.Size = New System.Drawing.Size(180, 20)
        Me.txtCelC.TabIndex = 23
        '
        'txtTelefonoC
        '
        Me.txtTelefonoC.Location = New System.Drawing.Point(134, 287)
        Me.txtTelefonoC.Name = "txtTelefonoC"
        Me.txtTelefonoC.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefonoC.TabIndex = 22
        '
        'txtPaisC
        '
        Me.txtPaisC.Location = New System.Drawing.Point(134, 260)
        Me.txtPaisC.Name = "txtPaisC"
        Me.txtPaisC.Size = New System.Drawing.Size(180, 20)
        Me.txtPaisC.TabIndex = 21
        '
        'txtEstadoC
        '
        Me.txtEstadoC.Location = New System.Drawing.Point(134, 233)
        Me.txtEstadoC.Name = "txtEstadoC"
        Me.txtEstadoC.Size = New System.Drawing.Size(180, 20)
        Me.txtEstadoC.TabIndex = 20
        '
        'txtMunicipioC
        '
        Me.txtMunicipioC.Location = New System.Drawing.Point(134, 207)
        Me.txtMunicipioC.Name = "txtMunicipioC"
        Me.txtMunicipioC.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipioC.TabIndex = 19
        '
        'txtColoniaC
        '
        Me.txtColoniaC.Location = New System.Drawing.Point(134, 181)
        Me.txtColoniaC.Name = "txtColoniaC"
        Me.txtColoniaC.Size = New System.Drawing.Size(180, 20)
        Me.txtColoniaC.TabIndex = 18
        '
        'txtCPC
        '
        Me.txtCPC.Location = New System.Drawing.Point(134, 153)
        Me.txtCPC.Name = "txtCPC"
        Me.txtCPC.Size = New System.Drawing.Size(180, 20)
        Me.txtCPC.TabIndex = 17
        '
        'txtNumIntC
        '
        Me.txtNumIntC.Location = New System.Drawing.Point(134, 124)
        Me.txtNumIntC.Name = "txtNumIntC"
        Me.txtNumIntC.Size = New System.Drawing.Size(180, 20)
        Me.txtNumIntC.TabIndex = 16
        '
        'txtNumExC
        '
        Me.txtNumExC.Location = New System.Drawing.Point(134, 96)
        Me.txtNumExC.Name = "txtNumExC"
        Me.txtNumExC.Size = New System.Drawing.Size(180, 20)
        Me.txtNumExC.TabIndex = 15
        '
        'txtCalleC
        '
        Me.txtCalleC.Location = New System.Drawing.Point(134, 68)
        Me.txtCalleC.Name = "txtCalleC"
        Me.txtCalleC.Size = New System.Drawing.Size(180, 20)
        Me.txtCalleC.TabIndex = 14
        '
        'txtNombreC
        '
        Me.txtNombreC.Location = New System.Drawing.Point(134, 42)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreC.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(18, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Correo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(18, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(18, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Pais:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Municipio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Colonia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Codigo Postal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numero Interior:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Numero Exterior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Calle:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.Actualizar.Controls.Add(Me.Label14)
        Me.Actualizar.Controls.Add(Me.Label15)
        Me.Actualizar.Controls.Add(Me.Label16)
        Me.Actualizar.Controls.Add(Me.Label17)
        Me.Actualizar.Controls.Add(Me.Label18)
        Me.Actualizar.Controls.Add(Me.Label19)
        Me.Actualizar.Controls.Add(Me.Label20)
        Me.Actualizar.Controls.Add(Me.Label21)
        Me.Actualizar.Controls.Add(Me.Label22)
        Me.Actualizar.Controls.Add(Me.Label23)
        Me.Actualizar.Controls.Add(Me.Label24)
        Me.Actualizar.Controls.Add(Me.Label25)
        Me.Actualizar.Controls.Add(Me.btnActualizarC)
        Me.Actualizar.Controls.Add(Me.txtCorreoCA)
        Me.Actualizar.Controls.Add(Me.txtCelCA)
        Me.Actualizar.Controls.Add(Me.txtTelefonoCA)
        Me.Actualizar.Controls.Add(Me.txtPaisCA)
        Me.Actualizar.Controls.Add(Me.txtEstadoCA)
        Me.Actualizar.Controls.Add(Me.txtMunicipioCA)
        Me.Actualizar.Controls.Add(Me.txtColoniaCA)
        Me.Actualizar.Controls.Add(Me.txtCPCA)
        Me.Actualizar.Controls.Add(Me.txtNumIntCA)
        Me.Actualizar.Controls.Add(Me.txtNumExCA)
        Me.Actualizar.Controls.Add(Me.txtCalleCA)
        Me.Actualizar.Controls.Add(Me.btnBuscarCA)
        Me.Actualizar.Controls.Add(Me.txtNombreCA)
        Me.Actualizar.Location = New System.Drawing.Point(4, 22)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.Actualizar.Size = New System.Drawing.Size(558, 412)
        Me.Actualizar.TabIndex = 1
        Me.Actualizar.Text = "Actualizar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 362)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Correo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 337)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Celular:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(22, 309)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 17)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Telefono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(22, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Pais:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(22, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Estado:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(22, 229)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Municipio:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(22, 203)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Colonia:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(22, 175)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 17)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Codigo Postal:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(22, 144)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 17)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Numero Interior:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(22, 118)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 17)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Numero Exterior:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(22, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 17)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Calle:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(22, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 17)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Nombre:"
        '
        'btnActualizarC
        '
        Me.btnActualizarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActualizarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarC.Location = New System.Drawing.Point(456, 374)
        Me.btnActualizarC.Name = "btnActualizarC"
        Me.btnActualizarC.Size = New System.Drawing.Size(96, 32)
        Me.btnActualizarC.TabIndex = 49
        Me.btnActualizarC.Text = "Actualizar"
        Me.btnActualizarC.UseVisualStyleBackColor = False
        '
        'txtCorreoCA
        '
        Me.txtCorreoCA.Location = New System.Drawing.Point(141, 362)
        Me.txtCorreoCA.Name = "txtCorreoCA"
        Me.txtCorreoCA.Size = New System.Drawing.Size(180, 20)
        Me.txtCorreoCA.TabIndex = 48
        '
        'txtCelCA
        '
        Me.txtCelCA.Location = New System.Drawing.Point(141, 337)
        Me.txtCelCA.Name = "txtCelCA"
        Me.txtCelCA.Size = New System.Drawing.Size(180, 20)
        Me.txtCelCA.TabIndex = 47
        '
        'txtTelefonoCA
        '
        Me.txtTelefonoCA.Location = New System.Drawing.Point(141, 309)
        Me.txtTelefonoCA.Name = "txtTelefonoCA"
        Me.txtTelefonoCA.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefonoCA.TabIndex = 46
        '
        'txtPaisCA
        '
        Me.txtPaisCA.Location = New System.Drawing.Point(141, 282)
        Me.txtPaisCA.Name = "txtPaisCA"
        Me.txtPaisCA.Size = New System.Drawing.Size(180, 20)
        Me.txtPaisCA.TabIndex = 45
        '
        'txtEstadoCA
        '
        Me.txtEstadoCA.Location = New System.Drawing.Point(141, 255)
        Me.txtEstadoCA.Name = "txtEstadoCA"
        Me.txtEstadoCA.Size = New System.Drawing.Size(180, 20)
        Me.txtEstadoCA.TabIndex = 44
        '
        'txtMunicipioCA
        '
        Me.txtMunicipioCA.Location = New System.Drawing.Point(141, 229)
        Me.txtMunicipioCA.Name = "txtMunicipioCA"
        Me.txtMunicipioCA.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipioCA.TabIndex = 43
        '
        'txtColoniaCA
        '
        Me.txtColoniaCA.Location = New System.Drawing.Point(141, 203)
        Me.txtColoniaCA.Name = "txtColoniaCA"
        Me.txtColoniaCA.Size = New System.Drawing.Size(180, 20)
        Me.txtColoniaCA.TabIndex = 42
        '
        'txtCPCA
        '
        Me.txtCPCA.Location = New System.Drawing.Point(141, 175)
        Me.txtCPCA.Name = "txtCPCA"
        Me.txtCPCA.Size = New System.Drawing.Size(180, 20)
        Me.txtCPCA.TabIndex = 41
        '
        'txtNumIntCA
        '
        Me.txtNumIntCA.Location = New System.Drawing.Point(141, 146)
        Me.txtNumIntCA.Name = "txtNumIntCA"
        Me.txtNumIntCA.Size = New System.Drawing.Size(180, 20)
        Me.txtNumIntCA.TabIndex = 40
        '
        'txtNumExCA
        '
        Me.txtNumExCA.Location = New System.Drawing.Point(141, 118)
        Me.txtNumExCA.Name = "txtNumExCA"
        Me.txtNumExCA.Size = New System.Drawing.Size(180, 20)
        Me.txtNumExCA.TabIndex = 39
        '
        'txtCalleCA
        '
        Me.txtCalleCA.Location = New System.Drawing.Point(141, 90)
        Me.txtCalleCA.Name = "txtCalleCA"
        Me.txtCalleCA.Size = New System.Drawing.Size(180, 20)
        Me.txtCalleCA.TabIndex = 38
        '
        'btnBuscarCA
        '
        Me.btnBuscarCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarCA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCA.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCA.Location = New System.Drawing.Point(277, 24)
        Me.btnBuscarCA.Name = "btnBuscarCA"
        Me.btnBuscarCA.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCA.TabIndex = 16
        Me.btnBuscarCA.Text = "Buscar"
        Me.btnBuscarCA.UseVisualStyleBackColor = False
        '
        'txtNombreCA
        '
        Me.txtNombreCA.Location = New System.Drawing.Point(90, 27)
        Me.txtNombreCA.Name = "txtNombreCA"
        Me.txtNombreCA.Size = New System.Drawing.Size(150, 20)
        Me.txtNombreCA.TabIndex = 15
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.Eliminar.Controls.Add(Me.Label26)
        Me.Eliminar.Controls.Add(Me.Label27)
        Me.Eliminar.Controls.Add(Me.Label28)
        Me.Eliminar.Controls.Add(Me.Label29)
        Me.Eliminar.Controls.Add(Me.Label30)
        Me.Eliminar.Controls.Add(Me.Label31)
        Me.Eliminar.Controls.Add(Me.Label32)
        Me.Eliminar.Controls.Add(Me.Label33)
        Me.Eliminar.Controls.Add(Me.Label34)
        Me.Eliminar.Controls.Add(Me.Label35)
        Me.Eliminar.Controls.Add(Me.Label36)
        Me.Eliminar.Controls.Add(Me.Label37)
        Me.Eliminar.Controls.Add(Me.btnEliminarC)
        Me.Eliminar.Controls.Add(Me.txtCorreoCE)
        Me.Eliminar.Controls.Add(Me.txtCelCE)
        Me.Eliminar.Controls.Add(Me.txtTelefonoCE)
        Me.Eliminar.Controls.Add(Me.txtPaisCE)
        Me.Eliminar.Controls.Add(Me.txtEstadoCE)
        Me.Eliminar.Controls.Add(Me.txtMunicipioCE)
        Me.Eliminar.Controls.Add(Me.txtColoniaCE)
        Me.Eliminar.Controls.Add(Me.txtCPCE)
        Me.Eliminar.Controls.Add(Me.txtNumIntCE)
        Me.Eliminar.Controls.Add(Me.txtNumExCE)
        Me.Eliminar.Controls.Add(Me.txtCalleCE)
        Me.Eliminar.Controls.Add(Me.btnBuscarCE)
        Me.Eliminar.Controls.Add(Me.txtNombreCE)
        Me.Eliminar.Location = New System.Drawing.Point(4, 22)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.Eliminar.Size = New System.Drawing.Size(558, 412)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(23, 362)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 17)
        Me.Label26.TabIndex = 89
        Me.Label26.Text = "Correo:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(23, 337)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 17)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "Celular:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(23, 309)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 17)
        Me.Label28.TabIndex = 87
        Me.Label28.Text = "Telefono:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(23, 282)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 17)
        Me.Label29.TabIndex = 86
        Me.Label29.Text = "Pais:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(23, 255)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 17)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "Estado:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(23, 229)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 17)
        Me.Label31.TabIndex = 84
        Me.Label31.Text = "Municipio:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(23, 203)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 17)
        Me.Label32.TabIndex = 83
        Me.Label32.Text = "Colonia:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(23, 175)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 17)
        Me.Label33.TabIndex = 82
        Me.Label33.Text = "Codigo Postal:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(23, 144)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 17)
        Me.Label34.TabIndex = 81
        Me.Label34.Text = "Numero Interior:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(23, 118)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(114, 17)
        Me.Label35.TabIndex = 80
        Me.Label35.Text = "Numero Exterior:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(23, 90)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 17)
        Me.Label36.TabIndex = 79
        Me.Label36.Text = "Calle:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(23, 27)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(62, 17)
        Me.Label37.TabIndex = 78
        Me.Label37.Text = "Nombre:"
        '
        'btnEliminarC
        '
        Me.btnEliminarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarC.Location = New System.Drawing.Point(456, 374)
        Me.btnEliminarC.Name = "btnEliminarC"
        Me.btnEliminarC.Size = New System.Drawing.Size(96, 32)
        Me.btnEliminarC.TabIndex = 77
        Me.btnEliminarC.Text = "Eliminar"
        Me.btnEliminarC.UseVisualStyleBackColor = False
        '
        'txtCorreoCE
        '
        Me.txtCorreoCE.Location = New System.Drawing.Point(142, 362)
        Me.txtCorreoCE.Name = "txtCorreoCE"
        Me.txtCorreoCE.Size = New System.Drawing.Size(180, 20)
        Me.txtCorreoCE.TabIndex = 76
        '
        'txtCelCE
        '
        Me.txtCelCE.Location = New System.Drawing.Point(142, 337)
        Me.txtCelCE.Name = "txtCelCE"
        Me.txtCelCE.Size = New System.Drawing.Size(180, 20)
        Me.txtCelCE.TabIndex = 75
        '
        'txtTelefonoCE
        '
        Me.txtTelefonoCE.Location = New System.Drawing.Point(142, 309)
        Me.txtTelefonoCE.Name = "txtTelefonoCE"
        Me.txtTelefonoCE.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefonoCE.TabIndex = 74
        '
        'txtPaisCE
        '
        Me.txtPaisCE.Location = New System.Drawing.Point(142, 282)
        Me.txtPaisCE.Name = "txtPaisCE"
        Me.txtPaisCE.Size = New System.Drawing.Size(180, 20)
        Me.txtPaisCE.TabIndex = 73
        '
        'txtEstadoCE
        '
        Me.txtEstadoCE.Location = New System.Drawing.Point(142, 255)
        Me.txtEstadoCE.Name = "txtEstadoCE"
        Me.txtEstadoCE.Size = New System.Drawing.Size(180, 20)
        Me.txtEstadoCE.TabIndex = 72
        '
        'txtMunicipioCE
        '
        Me.txtMunicipioCE.Location = New System.Drawing.Point(142, 229)
        Me.txtMunicipioCE.Name = "txtMunicipioCE"
        Me.txtMunicipioCE.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipioCE.TabIndex = 71
        '
        'txtColoniaCE
        '
        Me.txtColoniaCE.Location = New System.Drawing.Point(142, 203)
        Me.txtColoniaCE.Name = "txtColoniaCE"
        Me.txtColoniaCE.Size = New System.Drawing.Size(180, 20)
        Me.txtColoniaCE.TabIndex = 70
        '
        'txtCPCE
        '
        Me.txtCPCE.Location = New System.Drawing.Point(142, 175)
        Me.txtCPCE.Name = "txtCPCE"
        Me.txtCPCE.Size = New System.Drawing.Size(180, 20)
        Me.txtCPCE.TabIndex = 69
        '
        'txtNumIntCE
        '
        Me.txtNumIntCE.Location = New System.Drawing.Point(142, 146)
        Me.txtNumIntCE.Name = "txtNumIntCE"
        Me.txtNumIntCE.Size = New System.Drawing.Size(180, 20)
        Me.txtNumIntCE.TabIndex = 68
        '
        'txtNumExCE
        '
        Me.txtNumExCE.Location = New System.Drawing.Point(142, 118)
        Me.txtNumExCE.Name = "txtNumExCE"
        Me.txtNumExCE.Size = New System.Drawing.Size(180, 20)
        Me.txtNumExCE.TabIndex = 67
        '
        'txtCalleCE
        '
        Me.txtCalleCE.Location = New System.Drawing.Point(142, 90)
        Me.txtCalleCE.Name = "txtCalleCE"
        Me.txtCalleCE.Size = New System.Drawing.Size(180, 20)
        Me.txtCalleCE.TabIndex = 66
        '
        'btnBuscarCE
        '
        Me.btnBuscarCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarCE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCE.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCE.Location = New System.Drawing.Point(275, 23)
        Me.btnBuscarCE.Name = "btnBuscarCE"
        Me.btnBuscarCE.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCE.TabIndex = 64
        Me.btnBuscarCE.Text = "Buscar"
        Me.btnBuscarCE.UseVisualStyleBackColor = False
        '
        'txtNombreCE
        '
        Me.txtNombreCE.Location = New System.Drawing.Point(91, 26)
        Me.txtNombreCE.Name = "txtNombreCE"
        Me.txtNombreCE.Size = New System.Drawing.Size(150, 20)
        Me.txtNombreCE.TabIndex = 63
        '
        'btnListaContactos
        '
        Me.btnListaContactos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaContactos.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnListaContactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnListaContactos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListaContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaContactos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnListaContactos.Location = New System.Drawing.Point(670, 406)
        Me.btnListaContactos.Name = "btnListaContactos"
        Me.btnListaContactos.Size = New System.Drawing.Size(166, 34)
        Me.btnListaContactos.TabIndex = 51
        Me.btnListaContactos.Text = "Lista de Contactos"
        Me.btnListaContactos.UseVisualStyleBackColor = False
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Image = Global.ProyectoFinal.My.Resources.Resources.cancel
        Me.btnCerrarForm.Location = New System.Drawing.Point(820, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 2
        Me.btnCerrarForm.TabStop = False
        '
        'Contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 462)
        Me.Controls.Add(Me.btnListaContactos)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Controls.Add(Me.Registrar)
        Me.Name = "Contactos"
        Me.Text = "Contactos"
        Me.Registrar.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Actualizar.ResumeLayout(False)
        Me.Actualizar.PerformLayout()
        Me.Eliminar.ResumeLayout(False)
        Me.Eliminar.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Registrar As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnRegistrarC As Button
    Friend WithEvents txtCorreoC As TextBox
    Friend WithEvents txtCelC As TextBox
    Friend WithEvents txtTelefonoC As TextBox
    Friend WithEvents txtPaisC As TextBox
    Friend WithEvents txtEstadoC As TextBox
    Friend WithEvents txtMunicipioC As TextBox
    Friend WithEvents txtColoniaC As TextBox
    Friend WithEvents txtCPC As TextBox
    Friend WithEvents txtNumIntC As TextBox
    Friend WithEvents txtNumExC As TextBox
    Friend WithEvents txtCalleC As TextBox
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Actualizar As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnActualizarC As Button
    Friend WithEvents txtCorreoCA As TextBox
    Friend WithEvents txtCelCA As TextBox
    Friend WithEvents txtTelefonoCA As TextBox
    Friend WithEvents txtPaisCA As TextBox
    Friend WithEvents txtEstadoCA As TextBox
    Friend WithEvents txtMunicipioCA As TextBox
    Friend WithEvents txtColoniaCA As TextBox
    Friend WithEvents txtCPCA As TextBox
    Friend WithEvents txtNumIntCA As TextBox
    Friend WithEvents txtNumExCA As TextBox
    Friend WithEvents txtCalleCA As TextBox
    Friend WithEvents btnBuscarCA As Button
    Friend WithEvents txtNombreCA As TextBox
    Friend WithEvents Eliminar As TabPage
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents btnEliminarC As Button
    Friend WithEvents txtCorreoCE As TextBox
    Friend WithEvents txtCelCE As TextBox
    Friend WithEvents txtTelefonoCE As TextBox
    Friend WithEvents txtPaisCE As TextBox
    Friend WithEvents txtEstadoCE As TextBox
    Friend WithEvents txtMunicipioCE As TextBox
    Friend WithEvents txtColoniaCE As TextBox
    Friend WithEvents txtCPCE As TextBox
    Friend WithEvents txtNumIntCE As TextBox
    Friend WithEvents txtNumExCE As TextBox
    Friend WithEvents txtCalleCE As TextBox
    Friend WithEvents btnBuscarCE As Button
    Friend WithEvents txtNombreCE As TextBox
    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents btnListaContactos As Button
End Class

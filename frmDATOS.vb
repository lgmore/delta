Public Class frmDATOS
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnGRABAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents arbpromocion As System.Windows.Forms.TextBox
    Friend WithEvents arbemail As System.Windows.Forms.TextBox
    Friend WithEvents arbcelular As System.Windows.Forms.TextBox
    Friend WithEvents arbtelefono As System.Windows.Forms.TextBox
    Friend WithEvents arbdireccion As System.Windows.Forms.TextBox
    Friend WithEvents arbcedula As System.Windows.Forms.TextBox
    Friend WithEvents arbnombre As System.Windows.Forms.TextBox
    Friend WithEvents arbfecnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpbsexo As System.Windows.Forms.GroupBox
    Friend WithEvents arbfemenino As System.Windows.Forms.RadioButton
    Friend WithEvents arbmasculino As System.Windows.Forms.RadioButton
    Friend WithEvents TabDATOS As System.Windows.Forms.TabControl
    Friend WithEvents cmdSALIR As System.Windows.Forms.Button
    Friend WithEvents grdARBITRO As System.Windows.Forms.DataGrid
    Friend WithEvents picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnELIMINAR As System.Windows.Forms.Button
    Friend WithEvents arbestciv As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents arbTIPOSANGRE As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents arbPROFESION As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents arbcuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents arbsocio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents arbempleado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabDATOS = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.picfoto = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.arbempleado = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.arbsocio = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.arbcuenta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.arbTIPOSANGRE = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.arbPROFESION = New System.Windows.Forms.ComboBox
        Me.arbestciv = New System.Windows.Forms.ComboBox
        Me.gpbsexo = New System.Windows.Forms.GroupBox
        Me.arbfemenino = New System.Windows.Forms.RadioButton
        Me.arbmasculino = New System.Windows.Forms.RadioButton
        Me.arbfecnac = New System.Windows.Forms.DateTimePicker
        Me.arbpromocion = New System.Windows.Forms.TextBox
        Me.arbemail = New System.Windows.Forms.TextBox
        Me.arbcelular = New System.Windows.Forms.TextBox
        Me.arbtelefono = New System.Windows.Forms.TextBox
        Me.arbdireccion = New System.Windows.Forms.TextBox
        Me.arbcedula = New System.Windows.Forms.TextBox
        Me.arbnombre = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnGRABAR = New System.Windows.Forms.Button
        Me.btnELIMINAR = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdARBITRO = New System.Windows.Forms.DataGrid
        Me.cmdSALIR = New System.Windows.Forms.Button
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabDATOS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpbsexo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdARBITRO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabDATOS
        '
        Me.TabDATOS.Controls.Add(Me.TabPage1)
        Me.TabDATOS.Location = New System.Drawing.Point(16, 40)
        Me.TabDATOS.Multiline = True
        Me.TabDATOS.Name = "TabDATOS"
        Me.TabDATOS.SelectedIndex = 0
        Me.TabDATOS.Size = New System.Drawing.Size(816, 400)
        Me.TabDATOS.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(808, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Principales"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.GroupBox2.Controls.Add(Me.picfoto)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 344)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'picfoto
        '
        Me.picfoto.BackColor = System.Drawing.Color.White
        Me.picfoto.Location = New System.Drawing.Point(8, 16)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(232, 304)
        Me.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto.TabIndex = 12
        Me.picfoto.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.arbempleado)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.arbsocio)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.arbcuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.arbTIPOSANGRE)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.arbPROFESION)
        Me.GroupBox1.Controls.Add(Me.arbestciv)
        Me.GroupBox1.Controls.Add(Me.gpbsexo)
        Me.GroupBox1.Controls.Add(Me.arbfecnac)
        Me.GroupBox1.Controls.Add(Me.arbpromocion)
        Me.GroupBox1.Controls.Add(Me.arbemail)
        Me.GroupBox1.Controls.Add(Me.arbcelular)
        Me.GroupBox1.Controls.Add(Me.arbtelefono)
        Me.GroupBox1.Controls.Add(Me.arbdireccion)
        Me.GroupBox1.Controls.Add(Me.arbcedula)
        Me.GroupBox1.Controls.Add(Me.arbnombre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'arbempleado
        '
        Me.arbempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbempleado.Location = New System.Drawing.Point(416, 304)
        Me.arbempleado.MaxLength = 5
        Me.arbempleado.Name = "arbempleado"
        Me.arbempleado.Size = New System.Drawing.Size(56, 22)
        Me.arbempleado.TabIndex = 14
        Me.arbempleado.Text = ""
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(304, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 24)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Nro. Empleado"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'arbsocio
        '
        Me.arbsocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbsocio.Location = New System.Drawing.Point(352, 24)
        Me.arbsocio.MaxLength = 9
        Me.arbsocio.Name = "arbsocio"
        Me.arbsocio.Size = New System.Drawing.Size(72, 22)
        Me.arbsocio.TabIndex = 1
        Me.arbsocio.Text = ""
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(248, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 24)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = " Nro. de Socio"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'arbcuenta
        '
        Me.arbcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbcuenta.Location = New System.Drawing.Point(416, 280)
        Me.arbcuenta.MaxLength = 9
        Me.arbcuenta.Name = "arbcuenta"
        Me.arbcuenta.Size = New System.Drawing.Size(80, 22)
        Me.arbcuenta.TabIndex = 12
        Me.arbcuenta.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nro. de Cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'arbTIPOSANGRE
        '
        Me.arbTIPOSANGRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbTIPOSANGRE.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "0+", "0-"})
        Me.arbTIPOSANGRE.Location = New System.Drawing.Point(144, 304)
        Me.arbTIPOSANGRE.Name = "arbTIPOSANGRE"
        Me.arbTIPOSANGRE.Size = New System.Drawing.Size(80, 24)
        Me.arbTIPOSANGRE.TabIndex = 13
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 304)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 24)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Tipo de Sangre"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'arbPROFESION
        '
        Me.arbPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbPROFESION.Location = New System.Drawing.Point(144, 280)
        Me.arbPROFESION.Name = "arbPROFESION"
        Me.arbPROFESION.Size = New System.Drawing.Size(152, 24)
        Me.arbPROFESION.TabIndex = 11
        '
        'arbestciv
        '
        Me.arbestciv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbestciv.Items.AddRange(New Object() {"S = Soltero", "C = Casado", "V = Viudo", "L = Separdo", "U = Unido"})
        Me.arbestciv.Location = New System.Drawing.Point(144, 136)
        Me.arbestciv.Name = "arbestciv"
        Me.arbestciv.Size = New System.Drawing.Size(168, 24)
        Me.arbestciv.TabIndex = 5
        '
        'gpbsexo
        '
        Me.gpbsexo.Controls.Add(Me.arbfemenino)
        Me.gpbsexo.Controls.Add(Me.arbmasculino)
        Me.gpbsexo.Location = New System.Drawing.Point(144, 96)
        Me.gpbsexo.Name = "gpbsexo"
        Me.gpbsexo.Size = New System.Drawing.Size(192, 40)
        Me.gpbsexo.TabIndex = 4
        Me.gpbsexo.TabStop = False
        '
        'arbfemenino
        '
        Me.arbfemenino.Location = New System.Drawing.Point(88, 8)
        Me.arbfemenino.Name = "arbfemenino"
        Me.arbfemenino.Size = New System.Drawing.Size(80, 24)
        Me.arbfemenino.TabIndex = 1
        Me.arbfemenino.Text = "Femenino"
        '
        'arbmasculino
        '
        Me.arbmasculino.Location = New System.Drawing.Point(8, 8)
        Me.arbmasculino.Name = "arbmasculino"
        Me.arbmasculino.Size = New System.Drawing.Size(80, 24)
        Me.arbmasculino.TabIndex = 0
        Me.arbmasculino.Text = "Masculino"
        '
        'arbfecnac
        '
        Me.arbfecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbfecnac.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.arbfecnac.Location = New System.Drawing.Point(144, 72)
        Me.arbfecnac.Name = "arbfecnac"
        Me.arbfecnac.ShowCheckBox = True
        Me.arbfecnac.Size = New System.Drawing.Size(112, 22)
        Me.arbfecnac.TabIndex = 3
        '
        'arbpromocion
        '
        Me.arbpromocion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbpromocion.Location = New System.Drawing.Point(144, 256)
        Me.arbpromocion.MaxLength = 4
        Me.arbpromocion.Name = "arbpromocion"
        Me.arbpromocion.Size = New System.Drawing.Size(40, 22)
        Me.arbpromocion.TabIndex = 10
        Me.arbpromocion.Text = ""
        '
        'arbemail
        '
        Me.arbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbemail.Location = New System.Drawing.Point(144, 232)
        Me.arbemail.MaxLength = 30
        Me.arbemail.Name = "arbemail"
        Me.arbemail.Size = New System.Drawing.Size(248, 22)
        Me.arbemail.TabIndex = 9
        Me.arbemail.Text = ""
        '
        'arbcelular
        '
        Me.arbcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbcelular.Location = New System.Drawing.Point(144, 208)
        Me.arbcelular.MaxLength = 15
        Me.arbcelular.Name = "arbcelular"
        Me.arbcelular.Size = New System.Drawing.Size(96, 22)
        Me.arbcelular.TabIndex = 8
        Me.arbcelular.Text = ""
        '
        'arbtelefono
        '
        Me.arbtelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbtelefono.Location = New System.Drawing.Point(144, 184)
        Me.arbtelefono.MaxLength = 15
        Me.arbtelefono.Name = "arbtelefono"
        Me.arbtelefono.Size = New System.Drawing.Size(144, 22)
        Me.arbtelefono.TabIndex = 7
        Me.arbtelefono.Text = ""
        '
        'arbdireccion
        '
        Me.arbdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbdireccion.Location = New System.Drawing.Point(144, 160)
        Me.arbdireccion.MaxLength = 70
        Me.arbdireccion.Name = "arbdireccion"
        Me.arbdireccion.Size = New System.Drawing.Size(336, 22)
        Me.arbdireccion.TabIndex = 6
        Me.arbdireccion.Text = ""
        '
        'arbcedula
        '
        Me.arbcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbcedula.Location = New System.Drawing.Point(144, 24)
        Me.arbcedula.MaxLength = 12
        Me.arbcedula.Name = "arbcedula"
        Me.arbcedula.Size = New System.Drawing.Size(96, 22)
        Me.arbcedula.TabIndex = 0
        Me.arbcedula.Text = ""
        '
        'arbnombre
        '
        Me.arbnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbnombre.Location = New System.Drawing.Point(144, 48)
        Me.arbnombre.MaxLength = 50
        Me.arbnombre.Name = "arbnombre"
        Me.arbnombre.Size = New System.Drawing.Size(336, 22)
        Me.arbnombre.TabIndex = 2
        Me.arbnombre.Text = ""
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Profesion"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 24)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Promoción"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 24)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Correo Electrónico"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Celular Nro."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Teléfono Nro."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Dirección"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Estado Civil"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Sexo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha nacimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Apellido, Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro. de Cédula"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGRABAR
        '
        Me.btnGRABAR.Location = New System.Drawing.Point(544, 448)
        Me.btnGRABAR.Name = "btnGRABAR"
        Me.btnGRABAR.Size = New System.Drawing.Size(64, 32)
        Me.btnGRABAR.TabIndex = 1
        Me.btnGRABAR.Text = "&Grabar"
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.Location = New System.Drawing.Point(616, 448)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(64, 32)
        Me.btnELIMINAR.TabIndex = 2
        Me.btnELIMINAR.Text = "&Eliminar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdARBITRO)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 480)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 208)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'grdARBITRO
        '
        Me.grdARBITRO.DataMember = ""
        Me.grdARBITRO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdARBITRO.Location = New System.Drawing.Point(0, 8)
        Me.grdARBITRO.Name = "grdARBITRO"
        Me.grdARBITRO.ReadOnly = True
        Me.grdARBITRO.Size = New System.Drawing.Size(800, 192)
        Me.grdARBITRO.TabIndex = 12
        '
        'cmdSALIR
        '
        Me.cmdSALIR.Location = New System.Drawing.Point(688, 448)
        Me.cmdSALIR.Name = "cmdSALIR"
        Me.cmdSALIR.Size = New System.Drawing.Size(64, 32)
        Me.cmdSALIR.TabIndex = 3
        Me.cmdSALIR.Text = "&Salir"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(112, 456)
        Me.txtbusqueda.MaxLength = 32
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(200, 22)
        Me.txtbusqueda.TabIndex = 16
        Me.txtbusqueda.Text = ""
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Búsqueda"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(832, 32)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "CARGA DE DATOS DE SOCIOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDATOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(848, 726)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSALIR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnELIMINAR)
        Me.Controls.Add(Me.btnGRABAR)
        Me.Controls.Add(Me.TabDATOS)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDATOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de INGRESO DE DATOS"
        Me.TabDATOS.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gpbsexo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdARBITRO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wkdirectorio = Application.StartupPath
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        cargarProfesion()
        CerrarConexion()
        With Me
            .arbTIPOSANGRE.SelectedIndex = 0
            .arbestciv.SelectedIndex = 0
        End With
    End Sub

    Sub cargarProfesion()
        Dim strELEMENTO As String
        Dim wkprofcodigo As String
        Dim wkprofnombre As String


        Dim strsql As String = "SELECT profcodigo, profnombre from profesion order by profcodigo;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        myReader = myCommand.ExecuteReader()
        'Me.arbPROFESION.Items.Add("                ")
        While myReader.Read()
            wkprofcodigo = myReader.GetValue(0)
            wkprofnombre = myReader.GetString(1)

            strELEMENTO = wkprofcodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkprofnombre
            Me.arbPROFESION.Items.Add(strELEMENTO)
        End While
        Me.arbPROFESION.SelectedIndex = 0
        myReader.Close()
    End Sub


    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub arbcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbcedula.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            arbcedula.Text = ""
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub arbnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbnombre.TextChanged

    End Sub

    Private Sub arbnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbnombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub


    Private Sub arbfecnac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbfecnac.ValueChanged

    End Sub

    Private Sub arbfecnac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbfecnac.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            Me.arbmasculino.Focus()
        End If

    End Sub

    Private Sub arbmasculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub arbmasculino_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbfemenino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub arbfemenino_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbestcivil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub arbestcivil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbdireccion.TextChanged

    End Sub

    Private Sub arbdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbdireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbtelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbtelefono.TextChanged

    End Sub

    Private Sub arbtelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbtelefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbcelular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbcelular.TextChanged

    End Sub

    Private Sub arbcelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbcelular.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbemail.TextChanged

    End Sub

    Private Sub arbemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbemail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub arbpromocion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbpromocion.TextChanged

    End Sub

    Private Sub arbpromocion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbpromocion.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            arbpromocion.Text = ""
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub arbPROFESION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub arbPROFESION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub arbfemenino_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbfemenino.CheckedChanged

    End Sub

    Private Sub arbfemenino_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbfemenino.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub arbmasculino_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbmasculino.CheckedChanged

    End Sub

    Private Sub arbmasculino_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbmasculino.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnGRABAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGRABAR.Click
        If validarDATOS() = True Then
            grabarDATOS()
            AbrirConexion()
            cargarGrilla()
            setEstiloGrilla()
            CerrarConexion()
        End If
    End Sub
    Function validarDATOS() As Boolean
        Dim auxBANDERA As Boolean
        auxBANDERA = True
        If Len(Trim(Me.arbcedula.Text)) <= 0 Then
            MessageBox.Show("Debe ingresar el Número de Cédula", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbcedula.Focus()
        ElseIf (IsNumeric(Me.arbcedula.Text)) = False Then
            MessageBox.Show("Debe ingresar el Número de Cédula", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbcedula.Focus()
        ElseIf Len(Trim(Me.arbnombre.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el Nombre y Apellido", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbnombre.Focus()
        ElseIf Val(Me.arbsocio.Text) <= 0 Then
            MessageBox.Show("Debe ingresar el Número de Socio", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbsocio.Focus()
            'ElseIf existeSOCIO(Val(Me.arbsocio.Text), Val(Me.arbcedula.Text)) = True Then
            '    MessageBox.Show("El Número de Socio ya existe!", strSLOGAN, MessageBoxButtons.OK)
            '    auxBANDERA = False
            '    Me.arbsocio.Focus()
        ElseIf existeEMPLEADO(Val(Me.arbempleado.Text), Val(Me.arbcedula.Text)) = True Then
            MessageBox.Show("El Número de Empleado para el Banco ya existe!", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbempleado.Focus()
        ElseIf existeCUENTA(Val(Me.arbcuenta.Text), Val(Me.arbcedula.Text)) = True Then
            MessageBox.Show("El Número de Cuenta del Empleado para el Banco ya existe!", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.arbcuenta.Focus()
        End If
        validarDATOS = auxBANDERA
    End Function
    Function existeSOCIO(ByVal wksocio, ByVal wkcedula) As Boolean
        Try
            AbrirConexion()
            strsql = "SELECT arbcedula, arbsocio " & _
                            "from arbitro where arbsocio = " & wksocio & ""
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnEXISTE = False
            While myReader.Read()
                If Not (wkcedula = myReader.GetString(0)) Then
                    blnEXISTE = True
                End If
            End While
            myReader.Close()
            CerrarConexion()
            existeSOCIO = blnEXISTE
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try

    End Function
    Function existeEMPLEADO(ByVal wkempleado, ByVal wkcedula) As Boolean
        If wkempleado > 0 Then
            Try
                AbrirConexion()
                strsql = "SELECT arbcedula, arbempleado " & _
                                "from arbitro where arbsocio = " & wkempleado & ""
                Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
                Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                blnEXISTE = False
                While myReader.Read()
                    If Not (wkcedula = myReader.GetString(0)) Then
                        blnEXISTE = True
                    End If
                End While
                myReader.Close()
                CerrarConexion()
                existeEMPLEADO = blnEXISTE
            Catch err As Exception
                MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End Try
        End If

    End Function
    Function existeCUENTA(ByVal wkcuenta, ByVal wkcedula) As Boolean
        If wkcuenta > 0 Then
            Try
                AbrirConexion()
                strsql = "SELECT arbcedula, arbcuenta " & _
                                "from arbitro where arbsocio = " & wkcuenta & ""
                Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
                Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                blnEXISTE = False
                While myReader.Read()
                    If Not (wkcedula = myReader.GetString(0)) Then
                        blnEXISTE = True
                    End If
                End While
                myReader.Close()
                CerrarConexion()
                existeCUENTA = blnEXISTE
            Catch err As Exception
                MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End Try
        End If

    End Function

    Sub grabarDATOS()
        Dim wkarbcedula As Double
        Dim wkarbnombre As String
        Dim wkarbfecnac As String
        Dim wkarbsexo As String
        Dim wkarbestciv As String

        Dim wkarbdireccion As String
        Dim wkarbtelefono As String
        Dim wkarbcelular As String
        Dim wkarbemail As String
        Dim wkarbpromocion As String
        Dim wkarbPROFESION As String
        Dim wkarbfoto As String
        Dim wkarbtiposangre As String
        Dim wkarbcuenta As Double
        Dim wkarbsocio As Double
        Dim wkarbempleado As Double

        wkarbcedula = Trim(Me.arbcedula.Text)
        wkarbnombre = Trim(Me.arbnombre.Text)
        If Me.arbfecnac.Checked = True Then
            wkarbfecnac = Format(Me.arbfecnac.Value, "yyyy-MM-dd")
        Else
            wkarbfecnac = ""
        End If
        If Me.arbmasculino.Checked = True Then
            wkarbsexo = "M"
        Else
            wkarbsexo = "F"
        End If

        wkarbestciv = Microsoft.VisualBasic.Left(Me.arbestciv.Text, 1)
        wkarbdireccion = Trim(Me.arbdireccion.Text)
        wkarbtelefono = Trim(Me.arbtelefono.Text)
        wkarbcelular = Trim(Me.arbcelular.Text)
        wkarbemail = Trim(Me.arbemail.Text)
        wkarbpromocion = Val(Me.arbpromocion.Text)
        wkarbPROFESION = Val(Me.arbPROFESION.Text)
        wkarbfoto = "foto" & wkarbcedula

        wkarbtiposangre = Trim(Me.arbTIPOSANGRE.Text)

        wkarbcuenta = Val(Me.arbcuenta.Text)
        wkarbsocio = Val(Me.arbsocio.Text)
        wkarbempleado = Val(Me.arbempleado.Text)

        If existeArbitro(wkarbcedula) Then
            blnEXISTE = True
        Else
            blnEXISTE = False
        End If

        Try
            AbrirConexion()
            If blnEXISTE = False Then
                strsql = "INSERT INTO arbitro (arbcedula, arbnombre, arbfecnac, arbsexo, " & _
                                      "arbestciv, arbdireccion, arbtelefono,arbcelular, arbemail, " & _
                                      "arbpromocion, arbPROFESION, arbtiposangre, arbcuenta, arbsocio, arbempleado) " & _
                              "VALUES (" & wkarbcedula & ", '" & wkarbnombre & _
                              "', '" & wkarbfecnac & "', '" & wkarbsexo & _
                              "', '" & wkarbestciv & "', '" & wkarbdireccion & _
                              "', '" & wkarbtelefono & "', '" & wkarbcelular & _
                              "', '" & wkarbemail & "', " & wkarbpromocion & _
                              ", " & wkarbPROFESION & _
                              ", '" & wkarbtiposangre & _
                              "', " & wkarbcuenta & _
                              ", " & wkarbsocio & _
                              ", " & wkarbempleado & ")"
            Else
                strsql = "UPDATE arbitro SET " & _
                "arbcedula = " & wkarbcedula & ", " & _
                "arbnombre = '" & wkarbnombre & "', " & _
                "arbfecnac = '" & wkarbfecnac & "', " & _
                "arbsexo = '" & wkarbsexo & " ', " & _
                "arbestciv = '" & wkarbestciv & "', " & _
                "arbdireccion = '" & wkarbdireccion & "', " & _
                "arbtelefono = '" & wkarbtelefono & "', " & _
                "arbcelular = '" & wkarbcelular & "', " & _
                "arbemail = '" & wkarbemail & "', " & _
                "arbpromocion = " & wkarbpromocion & ", " & _
                "arbPROFESION = " & wkarbPROFESION & ", " & _
                "arbtiposangre = '" & wkarbtiposangre & "', " & _
                "arbcuenta = " & wkarbcuenta & ", " & _
                "arbsocio = " & wkarbsocio & ", " & _
                "arbempleado = " & wkarbempleado & " " & _
                "WHERE arbcedula = " & wkarbcedula & ""
            End If


            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
            MessageBox.Show("Registro ha sido grabado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
        End Try
    End Sub
    Function existeArbitro(ByVal wkcedula) As Boolean
        Try
            AbrirConexion()
            strsql = "SELECT arbcedula " & _
                            "from arbitro where arbcedula = " & wkcedula & ""
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnEXISTE = False
            While myReader.Read()
                If wkcedula = myReader.GetString(0) Then
                    blnEXISTE = True
                End If
            End While
            myReader.Close()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try
        existeArbitro = blnEXISTE
    End Function



    Private Sub arbcedula_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcedula.LostFocus
        Call cargarARBITRO(Val(Me.arbcedula.Text))
    End Sub
    Public Function cargarARBITRO(ByVal auxcedula As Double) As Boolean
        Dim indice As Integer
        Dim wkarbfoto As String
        Try
            AbrirConexion()
            strsql = "SELECT arbcedula, arbnombre, arbfecnac, arbsexo, arbestciv, arbdireccion, " & _
                            "arbtelefono, arbcelular, arbemail, arbpromocion, arbPROFESION, arbtiposangre, arbcuenta, arbsocio, arbempleado from arbitro where arbcedula = " & auxcedula & ""
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()
                With Me
                    vaciarFORMULARIO()
                    .arbnombre.Text = myReader.GetString(1)
                    .arbfecnac.Text = myReader.GetDate(2)
                    If myReader.GetString(3) = "M" Then
                        .arbmasculino.Checked = True
                    Else
                        .arbfemenino.Checked = True
                    End If
                    For indice = 0 To Me.arbestciv.Items.Count - 1
                        If UCase(Microsoft.VisualBasic.Left(Me.arbestciv.Items.Item(indice), 1)) = UCase(myReader.GetString(4)) Then
                            Me.arbestciv.SelectedIndex = indice
                            Exit For
                        End If
                    Next
                    .arbdireccion.Text = myReader.GetString(5)
                    .arbtelefono.Text = myReader.GetString(6)
                    .arbcelular.Text = myReader.GetString(7)
                    .arbemail.Text = myReader.GetString(8)
                    .arbpromocion.Text = myReader.GetString(9)
                    For indice = 0 To Me.arbPROFESION.Items.Count - 1
                        If UCase(Microsoft.VisualBasic.Left(Me.arbPROFESION.Items.Item(indice), 1)) = UCase(myReader.GetString(10)) Then
                            Me.arbPROFESION.SelectedIndex = indice
                            Exit For
                        End If
                    Next

                    wkarbfoto = wkdirectorio & "\fotos\foto" & Trim(Me.arbcedula.Text) & ".jpg"
                    If System.IO.File.Exists(wkarbfoto) Then
                        Try
                            .picfoto.Image = New System.Drawing.Bitmap(wkarbfoto)
                        Catch ex As Exception
                            .picfoto.Image = Nothing
                        End Try
                    Else
                        .picfoto.Image = Nothing
                    End If


                    For indice = 0 To Me.arbTIPOSANGRE.Items.Count - 1
                        If Microsoft.VisualBasic.Left(Me.arbTIPOSANGRE.Items.Item(indice), 2) = myReader.GetString(11) Then
                            .arbTIPOSANGRE.SelectedIndex = indice
                            Exit For
                        End If
                    Next
                    .arbcuenta.Text = myReader.GetString(12)
                    .arbsocio.Text = myReader.GetValue(13)
                    .arbempleado.Text = myReader.GetValue(14)
                End With
            End While
            myReader.Close()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try

    End Function

    Private Sub TabDATOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabDATOS.SelectedIndexChanged

    End Sub

    Private Sub cmdSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSALIR.Click
        Me.Dispose()

    End Sub
    Private Sub setEstiloGrilla()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOS.Tables("arbitro").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn
        Dim estilo5 As New DataGridTextBoxColumn
        Dim estilo6 As New DataGridTextBoxColumn

        With estilo1
            .MappingName = "arbcedula"
            .HeaderText = " CEDULA "
            .Width = 80
        End With

        With estilo2
            .MappingName = "arbnombre"
            .HeaderText = " APELLIDO, NOMBRE "
            .Width = 250
        End With


        With estilo3
            .MappingName = "arbsocio"
            .HeaderText = " Nro. SOCIO "
            .Width = 70
        End With

        With estilo4
            .MappingName = "arbdireccion"
            .HeaderText = " DIRECCION "
            .Width = 250
        End With

        With estilo5
            .MappingName = "arbtelefono"
            .HeaderText = " TELEFONO "
            .Width = 110

        End With

        With estilo6
            .MappingName = "arbcelular"
            .HeaderText = " CELULAR "
            .Width = 110

        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        estilos.GridColumnStyles.Add(estilo4)
        estilos.GridColumnStyles.Add(estilo5)
        estilos.GridColumnStyles.Add(estilo6)
        Me.grdARBITRO.TableStyles.Clear()
        Me.grdARBITRO.TableStyles.Add(estilos)

    End Sub

    Private Sub cargarGrilla()
        Try

            Dim dataviewLOCAL As DataView
            dsDATOS = New DataSet
            strsql = "SELECT arbcedula, arbnombre, arbsocio, arbdireccion, arbtelefono, arbcelular FROM arbitro order by arbnombre"

            Dim adDATOS As New Odbc.OdbcDataAdapter
            adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
            adDATOS.Fill(dsDATOS, "arbitro")

            dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre LIKE '%'", "arbnombre ASC", DataViewRowState.OriginalRows)
            Me.grdARBITRO.DataSource = dataviewLOCAL
            Me.grdARBITRO.CaptionText = "Cantidad de Socios: " + dataviewLOCAL.Count.ToString
        Catch ex As Exception
            MessageBox.Show("Hubo un problema en la base de datos..", strSLOGAN, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub grdARBITRO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdARBITRO.Click
        Dim fila As Integer
        fila = grdARBITRO.CurrentRowIndex
        Me.arbcedula.Text = grdARBITRO.Item(fila, 0)
        Call cargarARBITRO(Val(Me.arbcedula.Text))
    End Sub

    Sub vaciarFORMULARIO()
        With Me
            .arbnombre.Text = ""
            .arbdireccion.Text = ""
            .arbtelefono.Text = ""
            .arbemail.Text = ""
            .arbcelular.Text = ""
            .arbpromocion.Text = ""
            .arbPROFESION.SelectedIndex = 0
            .arbestciv.SelectedIndex = 0
            .arbTIPOSANGRE.SelectedIndex = 0
            .arbcuenta.Text = 0
            .arbsocio.Text = 0
            .arbempleado.Text = 0
        End With

    End Sub

    Private Sub arbnombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbnombre.GotFocus
        If Len(Trim(arbnombre.Text)) > 0 Then
            arbnombre.SelectionStart = 0
            arbnombre.SelectionLength = Len(Trim(arbnombre.Text))
        End If

    End Sub

    Private Sub arbdireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbdireccion.GotFocus
        If Len(Trim(arbdireccion.Text)) > 0 Then
            arbdireccion.SelectionStart = 0
            arbdireccion.SelectionLength = Len(Trim(arbdireccion.Text))
        End If

    End Sub

    Private Sub arbtelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbtelefono.GotFocus
        If Len(Trim(arbtelefono.Text)) > 0 Then
            arbtelefono.SelectionStart = 0
            arbtelefono.SelectionLength = Len(Trim(arbtelefono.Text))
        End If

    End Sub

    Private Sub arbcelular_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcelular.GotFocus
        If Len(Trim(arbcelular.Text)) > 0 Then
            arbcelular.SelectionStart = 0
            arbcelular.SelectionLength = Len(Trim(arbcelular.Text))
        End If

    End Sub

    Private Sub arbemail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbemail.GotFocus
        If Len(Trim(arbemail.Text)) > 0 Then
            arbemail.SelectionStart = 0
            arbemail.SelectionLength = Len(Trim(arbemail.Text))
        End If

    End Sub

    Private Sub arbpromocion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbpromocion.GotFocus
        If Len(Trim(arbpromocion.Text)) > 0 Then
            arbpromocion.SelectionStart = 0
            arbpromocion.SelectionLength = Len(Trim(arbpromocion.Text))
        End If

    End Sub

    Private Sub arbPROFESION_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(Trim(arbPROFESION.Text)) > 0 Then
            arbPROFESION.SelectionStart = 0
            arbPROFESION.SelectionLength = Len(Trim(arbPROFESION.Text))
        End If

    End Sub

    Sub cargarGrillaARBITRO(ByVal auxnombre As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT arbcedula, arbnombre, arbsocio, arbdireccion, arbtelefono, arbcelular FROM arbitro order by arbnombre"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre like '%" & auxnombre & "%'", "arbnombre ASC", DataViewRowState.OriginalRows)
        'dataviewPRODUCTOS = New DataView(dsDATOS.Tables("PRODUCTOS"), "pronombre like '%" & wkPRONOMBRE & "%'", "pronombre ASC", DataViewRowState.OriginalRows)
        Me.grdARBITRO.DataSource = dataviewLOCAL
        Me.grdARBITRO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub btnELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINAR.Click
        Dim auxarbcedula As Double
        Try
            auxarbcedula = Double.Parse(Me.arbcedula.Text)
            If MessageBox.Show("Desea eliminar este registro?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                eliminarArbitro(auxarbcedula)
                AbrirConexion()
                cargarGrilla()
                setEstiloGrilla()
                CerrarConexion()
                MessageBox.Show("Registro eliminado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
                Me.arbcedula.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un problema al eliminar el registro..", strSLOGAN, MessageBoxButtons.OK)
        End Try

    End Sub
    Public Sub eliminarArbitro(ByVal auxarbcedula As Double)
        Try
            AbrirConexion()
            strsql = "delete from arbitro where arbcedula = " & auxarbcedula & ""
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la eliminacion de Registro", MessageBoxButtons.OK)
            End

        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaARBITRO(UCase(Trim(Me.txtbusqueda.Text)))
    End Sub

    Private Sub arbestciv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbestciv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub arbpromocion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbpromocion.LostFocus
        If Val(Me.arbpromocion.Text) <= 1960 Or Val(Me.arbpromocion.Text) > Val(Year(Now)) Then
            MessageBox.Show("Posible error en los datos. Verifiquelo1!!", strSLOGAN, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub arbPROFESION_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbPROFESION.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub arbTIPOSANGRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbTIPOSANGRE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub arbCUENTA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arbcuenta.GotFocus
        If Len(Trim(arbcuenta.Text)) > 0 Then
            arbcuenta.SelectionStart = 0
            arbcuenta.SelectionLength = Len(Trim(arbcuenta.Text))
        End If

    End Sub

    Private Sub arbcuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbcuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            arbcuenta.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub arbsocio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbsocio.GotFocus
        If Len(Trim(arbsocio.Text)) > 0 Then
            arbsocio.SelectionStart = 0
            arbsocio.SelectionLength = Len(Trim(arbsocio.Text))
        End If

    End Sub

    Private Sub arbsocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbsocio.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            arbcuenta.Text = ""
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub arbempleado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbempleado.GotFocus
        If Len(Trim(arbempleado.Text)) > 0 Then
            arbempleado.SelectionStart = 0
            arbempleado.SelectionLength = Len(Trim(arbempleado.Text))
        End If

    End Sub

    Private Sub arbempleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles arbempleado.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            arbcuenta.Text = ""
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub arbcedula_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcedula.GotFocus
        Call vaciarFORMULARIO()
        Me.arbcedula.SelectAll()
    End Sub

    Private Sub arbcedula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcedula.Click
        Me.arbcedula.SelectAll()
    End Sub

    Private Sub arbsocio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbsocio.Click
        arbsocio.SelectAll()
    End Sub

    Private Sub arbnombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbnombre.Click
        arbnombre.SelectAll()
    End Sub

    Private Sub arbdireccion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbdireccion.Click
        arbdireccion.SelectAll()
    End Sub

    Private Sub arbtelefono_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbtelefono.Click
        arbtelefono.SelectAll()
    End Sub

    Private Sub arbcelular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcelular.Click
        arbcelular.SelectAll()
    End Sub

    Private Sub arbemail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbemail.Click
        arbemail.SelectAll()
    End Sub

    Private Sub arbpromocion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbpromocion.Click
        arbpromocion.SelectAll()
    End Sub

    Private Sub arbcuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbcuenta.Click
        arbcuenta.SelectAll()
    End Sub

    Private Sub arbempleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arbempleado.Click
        arbempleado.SelectAll()
    End Sub

    Private Sub grdARBITRO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdARBITRO.Navigate

    End Sub
End Class

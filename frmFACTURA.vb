Public Class frmFACTURA
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
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents rbtngravadas As System.Windows.Forms.RadioButton
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRUC As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtbeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents rbtnexentas As System.Windows.Forms.RadioButton
    Friend WithEvents btnAYUDA As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents txtCONDICION As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPORCENTAJE As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTIMBRADO As System.Windows.Forms.TextBox
    Friend WithEvents txtVALIDEZ As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtVALIDEZ = New System.Windows.Forms.TextBox
        Me.txtTIMBRADO = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtbeneficiario = New System.Windows.Forms.TextBox
        Me.txtRUC = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnAYUDA = New System.Windows.Forms.Button
        Me.datfecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtPORCENTAJE = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCONDICION = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.rbtngravadas = New System.Windows.Forms.RadioButton
        Me.rbtnexentas = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(16, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(685, 32)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "EMISION DE FACTURA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtbeneficiario)
        Me.GroupBox1.Controls.Add(Me.txtRUC)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAYUDA)
        Me.GroupBox1.Controls.Add(Me.datfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Datos de Factura"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.txtVALIDEZ)
        Me.Panel1.Controls.Add(Me.txtTIMBRADO)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(317, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 65)
        Me.Panel1.TabIndex = 58
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(314, 15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(34, 44)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Ok."
        '
        'txtVALIDEZ
        '
        Me.txtVALIDEZ.Location = New System.Drawing.Point(113, 33)
        Me.txtVALIDEZ.MaxLength = 40
        Me.txtVALIDEZ.Name = "txtVALIDEZ"
        Me.txtVALIDEZ.Size = New System.Drawing.Size(194, 26)
        Me.txtVALIDEZ.TabIndex = 3
        Me.txtVALIDEZ.Text = ""
        '
        'txtTIMBRADO
        '
        Me.txtTIMBRADO.Location = New System.Drawing.Point(113, 9)
        Me.txtTIMBRADO.MaxLength = 10
        Me.txtTIMBRADO.Name = "txtTIMBRADO"
        Me.txtTIMBRADO.Size = New System.Drawing.Size(195, 26)
        Me.txtTIMBRADO.TabIndex = 2
        Me.txtTIMBRADO.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Validez."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Timbrado Nº"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(134, 170)
        Me.txttelefono.MaxLength = 36
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(163, 26)
        Me.txttelefono.TabIndex = 5
        Me.txttelefono.Text = ""
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(134, 143)
        Me.txtdireccion.MaxLength = 128
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(551, 26)
        Me.txtdireccion.TabIndex = 4
        Me.txtdireccion.Text = ""
        '
        'txtbeneficiario
        '
        Me.txtbeneficiario.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtbeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeneficiario.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtbeneficiario.Location = New System.Drawing.Point(134, 116)
        Me.txtbeneficiario.MaxLength = 64
        Me.txtbeneficiario.Name = "txtbeneficiario"
        Me.txtbeneficiario.Size = New System.Drawing.Size(392, 26)
        Me.txtbeneficiario.TabIndex = 3
        Me.txtbeneficiario.Text = ""
        '
        'txtRUC
        '
        Me.txtRUC.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(134, 89)
        Me.txtRUC.MaxLength = 18
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(136, 26)
        Me.txtRUC.TabIndex = 2
        Me.txtRUC.Text = ""
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 27)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Dirección"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 27)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 27)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Razón Social"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 27)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "RUC/CI"
        '
        'btnAYUDA
        '
        Me.btnAYUDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAYUDA.Location = New System.Drawing.Point(247, 29)
        Me.btnAYUDA.Name = "btnAYUDA"
        Me.btnAYUDA.Size = New System.Drawing.Size(47, 28)
        Me.btnAYUDA.TabIndex = 53
        Me.btnAYUDA.TabStop = False
        Me.btnAYUDA.Text = "..."
        '
        'datfecha
        '
        Me.datfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.datfecha.Location = New System.Drawing.Point(134, 59)
        Me.datfecha.Name = "datfecha"
        Me.datfecha.Size = New System.Drawing.Size(110, 26)
        Me.datfecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 27)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 27)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Número"
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(134, 31)
        Me.txtnumero.MaxLength = 10
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(107, 26)
        Me.txtnumero.TabIndex = 0
        Me.txtnumero.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPORCENTAJE)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCONDICION)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.rbtngravadas)
        Me.GroupBox2.Controls.Add(Me.rbtnexentas)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtprecio)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 272)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panel de Detalles"
        '
        'txtPORCENTAJE
        '
        Me.txtPORCENTAJE.Enabled = False
        Me.txtPORCENTAJE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORCENTAJE.ItemHeight = 20
        Me.txtPORCENTAJE.Items.AddRange(New Object() {"10", "5"})
        Me.txtPORCENTAJE.Location = New System.Drawing.Point(488, 198)
        Me.txtPORCENTAJE.Name = "txtPORCENTAJE"
        Me.txtPORCENTAJE.Size = New System.Drawing.Size(63, 28)
        Me.txtPORCENTAJE.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(361, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 27)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Porcentaje"
        '
        'txtCONDICION
        '
        Me.txtCONDICION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONDICION.ItemHeight = 20
        Me.txtCONDICION.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.txtCONDICION.Location = New System.Drawing.Point(143, 223)
        Me.txtCONDICION.Name = "txtCONDICION"
        Me.txtCONDICION.Size = New System.Drawing.Size(117, 28)
        Me.txtCONDICION.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 27)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Condición"
        '
        'rbtngravadas
        '
        Me.rbtngravadas.Checked = True
        Me.rbtngravadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtngravadas.Location = New System.Drawing.Point(141, 200)
        Me.rbtngravadas.Name = "rbtngravadas"
        Me.rbtngravadas.Size = New System.Drawing.Size(99, 25)
        Me.rbtngravadas.TabIndex = 5
        Me.rbtngravadas.TabStop = True
        Me.rbtngravadas.Text = "Gravadas"
        '
        'rbtnexentas
        '
        Me.rbtnexentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnexentas.Location = New System.Drawing.Point(255, 202)
        Me.rbtnexentas.Name = "rbtnexentas"
        Me.rbtnexentas.Size = New System.Drawing.Size(102, 23)
        Me.rbtnexentas.TabIndex = 6
        Me.rbtnexentas.Text = "Exentas"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 27)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Tipo"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txttotal.Location = New System.Drawing.Point(139, 167)
        Me.txttotal.MaxLength = 14
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(105, 26)
        Me.txttotal.TabIndex = 4
        Me.txttotal.TabStop = False
        Me.txttotal.Text = ""
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(139, 140)
        Me.txtprecio.MaxLength = 12
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(91, 26)
        Me.txtprecio.TabIndex = 3
        Me.txtprecio.Text = ""
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(138, 113)
        Me.txtcantidad.MaxLength = 3
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(46, 26)
        Me.txtcantidad.TabIndex = 2
        Me.txtcantidad.Text = ""
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(137, 59)
        Me.txtdescripcion.MaxLength = 128
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(519, 51)
        Me.txtdescripcion.TabIndex = 1
        Me.txtdescripcion.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 27)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 27)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Precio Unitario"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 27)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 27)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(136, 31)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(56, 26)
        Me.txtcodigo.TabIndex = 0
        Me.txtcodigo.Text = ""
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(292, 568)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(95, 25)
        Me.btngrabar.TabIndex = 51
        Me.btngrabar.Text = "&Grabar"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(600, 568)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(95, 25)
        Me.btnsalir.TabIndex = 52
        Me.btnsalir.Text = "&Salir"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(394, 568)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(95, 25)
        Me.btneliminar.TabIndex = 53
        Me.btneliminar.Text = "&Eliminar"
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(500, 568)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(95, 25)
        Me.btnimprimir.TabIndex = 54
        Me.btnimprimir.Text = "&Imprimir"
        '
        'frmFACTURA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(714, 599)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFACTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Emision de Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtnumero.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtnumero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.GotFocus
        If Len(Trim(txtnumero.Text)) > 0 Then
            txtnumero.SelectionStart = 0
            txtnumero.SelectionLength = Len(Trim(txtnumero.Text))
        End If
    End Sub
    Sub vaciarFORMULARIO(ByVal forma As Boolean)
        With Me
            .txtRUC.Text = ""
            .txtbeneficiario.Text = ""
            .txtdireccion.Text = ""
            .txttelefono.Text = ""
            If forma = False Then
                .txtnumero.Text = Val(Me.txtnumero.Text) + 1
            Else
                .txtcodigo.Text = ""
                .txtdescripcion.Text = ""
                .txtcantidad.Text = ""
                .txtprecio.Text = ""
                .txttotal.Text = ""
            End If
        End With
    End Sub

    Private Sub txtRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.TextChanged

    End Sub

    Private Sub txtRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtRUC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.GotFocus
        If Len(Trim(txtRUC.Text)) > 0 Then
            txtRUC.SelectionStart = 0
            txtRUC.SelectionLength = Len(Trim(txtRUC.Text))
        End If

    End Sub
    Private Sub txtbeneficiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbeneficiario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtbeneficiario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbeneficiario.GotFocus
        If Len(Trim(txtbeneficiario.Text)) > 0 Then
            txtbeneficiario.SelectionStart = 0
            txtbeneficiario.SelectionLength = Len(Trim(txtbeneficiario.Text))
        End If

    End Sub
    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdireccion.GotFocus
        If Len(Trim(txtdireccion.Text)) > 0 Then
            txtdireccion.SelectionStart = 0
            txtdireccion.SelectionLength = Len(Trim(txtdireccion.Text))
        End If

    End Sub
    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txttelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttelefono.GotFocus
        If Len(Trim(txttelefono.Text)) > 0 Then
            txttelefono.SelectionStart = 0
            txttelefono.SelectionLength = Len(Trim(txttelefono.Text))
        End If

    End Sub


    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtcodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.GotFocus
        If Len(Trim(txtcodigo.Text)) > 0 Then
            txtcodigo.SelectionStart = 0
            txtcodigo.SelectionLength = Len(Trim(txtcodigo.Text))
        End If
    End Sub
    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdescripcion.GotFocus
        If Len(Trim(txtdescripcion.Text)) > 0 Then
            txtdescripcion.SelectionStart = 0
            txtdescripcion.SelectionLength = Len(Trim(txtdescripcion.Text))
        End If

    End Sub
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtcantidad.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtcantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.GotFocus
        If Len(Trim(txtcantidad.Text)) > 0 Then
            txtcantidad.SelectionStart = 0
            txtcantidad.SelectionLength = Len(Trim(txtcantidad.Text))
        End If
    End Sub
    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtprecio.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtprecio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprecio.GotFocus
        If Len(Trim(txtprecio.Text)) > 0 Then
            txtprecio.SelectionStart = 0
            txtprecio.SelectionLength = Len(Trim(txtprecio.Text))
        End If
    End Sub


    Private Sub rbtnexentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnexentas.CheckedChanged

    End Sub

    Private Sub rbtnexentas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtnexentas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rbtngravadas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtngravadas.CheckedChanged
        If rbtngravadas.Checked = True Then
            Me.txtPORCENTAJE.Enabled = True
            Me.txtPORCENTAJE.SelectedIndex = 0
        Else
            Me.txtPORCENTAJE.Enabled = False
        End If
    End Sub

    Private Sub rbtngravadas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtngravadas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtFUENTE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCONDICION.SelectedIndexChanged

    End Sub

    Private Sub txtFUENTE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCONDICION.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim auxnumero As Double
        Try
            auxnumero = Double.Parse(Me.txtnumero.Text)
            If MessageBox.Show("Desea eliminar este registro?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                eliminarfactura(auxnumero)
                MessageBox.Show("Registro eliminado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
                Me.txtnumero.Focus()
                vaciarFORMULARIO(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un problema al eliminar el registro..", strSLOGAN, MessageBoxButtons.OK)
        End Try

    End Sub
    Public Sub eliminarfactura(ByVal auxnumero As Double)
        Try
            AbrirConexion()
            strSQL = "delete from factura where facnumero = " & auxnumero & ""
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la eliminacion de Registro", MessageBoxButtons.OK)
            End

        End Try
    End Sub

    Private Sub btnGRABAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If validarDATOS() = True Then
            grabarDATOS()
            vaciarFORMULARIO(False)
        End If
    End Sub
    Function validarDATOS() As Boolean
        Dim auxBANDERA As Boolean
        auxBANDERA = True
        If Len(Trim(Me.txtnumero.Text)) <= 0 Then
            MessageBox.Show("Debe ingresar el Número de Factura", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtnumero.Focus()
        ElseIf Len(Trim(Me.txtRUC.Text)) <= 0 Then
            MessageBox.Show("Debe ingresar el Número de RUC", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtRUC.Focus()
        ElseIf Len(Trim(Me.txtbeneficiario.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el Nombre y Apellido", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtbeneficiario.Focus()
        ElseIf Len(Trim(Me.txtdescripcion.Text)) = 0 Then
            MessageBox.Show("Debe ingresar la descripción", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtdescripcion.Focus()
        ElseIf Len(Trim(Me.txtcantidad.Text)) = 0 Then
            MessageBox.Show("Debe ingresar la cantidad", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtcantidad.Focus()
        ElseIf Len(Trim(Me.txtprecio.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el Precio Unitario", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtprecio.Focus()

        End If
        validarDATOS = auxBANDERA
    End Function
    Sub grabarDATOS()
        Dim wknumero As Double
        Dim wkfecha As String
        Dim wkruc As String
        Dim wkbeneficiario As String
        Dim wkdireccion As String
        Dim wktelefono As String
        Dim wkcodigo As String

        Dim wkdescripcion As String
        Dim wkcantidad As Integer
        Dim wkprecio As Double
        Dim wktotal As Double
        Dim wktipo As String
        Dim wkfuente As String
        Dim wkarbfoto As String
        Dim wkcondicion As String
        Dim wkporcentaje As String

        wknumero = Trim(Me.txtnumero.Text)
        wkruc = Trim(Me.txtRUC.Text)
        wkfecha = Format(Me.datfecha.Value, "yyyy-MM-dd")
        wkbeneficiario = Trim(Me.txtbeneficiario.Text)
        wkdireccion = Trim(Me.txtdireccion.Text)
        wktelefono = Trim(Me.txttelefono.Text)
        wkcodigo = Trim(Me.txtcodigo.Text)
        wkdescripcion = Trim(Me.txtdescripcion.Text)
        wkcantidad = Val(Me.txtcantidad.Text)
        wkprecio = Val(Me.txtprecio.Text)
        wktotal = Val(Me.txttotal.Text)
        If Me.rbtngravadas.Checked = True Then
            wktipo = "Gravadas"
            wkporcentaje = Val(Me.txtPORCENTAJE.Text)
        Else
            wktipo = "Exentas"
            wkporcentaje = 0
        End If
        wkcondicion = Trim(Me.txtCONDICION.Text)
        Try
            AbrirConexion()
            If blnEXISTE = False Then
                strSQL = "INSERT INTO factura (facnumero, facfecha, facruc, facbeneficiario, facdireccion, " & _
                                      "factelefono, faccodigo, facdescripcion,faccantidad, facprecio, " & _
                                      "factotal, factipo, faccondicion, facporcentaje) " & _
                              "VALUES (" & wknumero & ", '" & wkfecha & _
                              "', '" & wkruc & "', '" & wkbeneficiario & _
                              "', '" & wkdireccion & "', '" & wktelefono & _
                              "', '" & wkcodigo & "', '" & wkdescripcion & _
                              "', " & wkcantidad & ", " & wkprecio & _
                              ", " & wktotal & _
                              ", '" & wktipo & _
                              "', '" & wkcondicion & _
                              "', " & wkporcentaje & ")"
            Else
                strSQL = "UPDATE factura SET " & _
                "facnumero = " & wknumero & ", " & _
                "facfecha = '" & wkfecha & "', " & _
                "facruc = '" & wkruc & "', " & _
                "facbeneficiario = '" & wkbeneficiario & " ', " & _
                "facdireccion = '" & wkdireccion & "', " & _
                "factelefono = '" & wktelefono & "', " & _
                "faccodigo = '" & wkcodigo & "', " & _
                "facdescripcion = '" & wkdescripcion & "', " & _
                "faccantidad = " & wkcantidad & ", " & _
                "factotal = " & wktotal & ", " & _
                "factipo = '" & wktipo & "', " & _
                "faccondicion = '" & wkcondicion & "', " & _
                "facporcentaje = " & wkporcentaje & " " & _
                "WHERE facnumero = " & wknumero & ""
            End If


            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
            MessageBox.Show("Registro ha sido grabado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub frmfactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCONDICION.SelectedIndex = 0
        cargarCONFIG()
    End Sub
    Function cargarCONFIG()
        Dim indice As Integer
        Dim wkarbfoto As String
        Try
            blnEXISTE = False
            AbrirConexion()
            strSQL = "SELECT factimbrado, facvalidez from facturaconfig" & ""
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()
                With Me
                    .txtTIMBRADO.Text = myReader.GetString(0)
                    .txtVALIDEZ.Text = myReader.GetString(1)
                End With
            End While
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try

    End Function

    Private Sub datfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datfecha.ValueChanged

    End Sub

    Private Sub datfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datfecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtprecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprecio.LostFocus
        Dim auxcalculo As Double
        If IsNumeric(Me.txtcantidad.Text) And IsNumeric(Me.txtprecio.Text) Then
            auxcalculo = Val(Me.txtcantidad.Text) * Val(Me.txtprecio.Text)
            Me.txttotal.Text = auxcalculo
        End If
    End Sub


    Private Sub txtnumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.LostFocus
        Call cargarFACTURA(Val(Me.txtnumero.Text))
    End Sub
    Public Function cargarFACTURA(ByVal auxnumero As Double) As Boolean
        Dim indice As Integer
        Dim wkarbfoto As String
        Try
            blnEXISTE = False
            AbrirConexion()
            strSQL = "SELECT facnumero, facfecha, facruc, facbeneficiario, facdireccion, factelefono, " & _
                            "faccodigo, facdescripcion, faccantidad, facprecio, factotal, factipo, faccondicion, facporcentaje from factura where facnumero = " & auxnumero & ""
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()
                With Me
                    vaciarFORMULARIO(True)
                    .datfecha.Value = myReader.GetDate(1)
                    .txtRUC.Text = myReader.GetString(2)
                    .txtbeneficiario.Text = myReader.GetString(3)
                    .txtdireccion.Text = myReader.GetString(4)
                    .txttelefono.Text = myReader.GetString(5)
                    .txtcodigo.Text = myReader.GetString(6)
                    .txtdescripcion.Text = myReader.GetString(7)
                    .txtcantidad.Text = myReader.GetValue(8)
                    .txtprecio.Text = myReader.GetValue(9)
                    .txttotal.Text = myReader.GetString(10)
                    If myReader.GetString(11) = "Gravadas" Then
                        Me.rbtngravadas.Checked = True
                    Else
                        Me.rbtnexentas.Checked = True
                    End If

                    If myReader.GetString(12) = "CONTADO" Then
                        Me.txtCONDICION.SelectedIndex = 0
                    Else
                        With Me
                            .txtCONDICION.SelectedIndex = 1
                        End With

                    End If

                    If myReader.GetValue(13) > 0 Then
                        Me.txtPORCENTAJE.Enabled = True
                        If myReader.GetValue(13) = 5 Then
                            Me.txtPORCENTAJE.SelectedIndex = 1
                        Else
                            Me.txtPORCENTAJE.SelectedIndex = 0
                        End If
                    End If
                End With
                blnEXISTE = True
            End While
            myReader.Close()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try

    End Function

    Private Sub btnAYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAYUDA.Click
        Dim frmNEW As New frmFACTURACON
        glonumero = 0
        frmNEW.ShowDialog()
        If Not glonumero = 0 Then
            With Me
                .txtnumero.Text = glonumero
                .txtnumero.Focus()
            End With
        End If
    End Sub

    Private Sub txtnumero_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.DoubleClick
        Me.txtnumero.Text = ultimonumero() + 1
    End Sub
    Function ultimonumero() As Integer
        Dim auxnumero As Integer
        Try
            AbrirConexion()
            strSQL = "SELECT max(facnumero) as maxnumero from factura"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            auxnumero = 0
            While myReader.Read()
                If IsDBNull(myReader.GetValue(0)) = False Then
                    auxnumero = Int(myReader.GetValue(0))
                End If
            End While
            myReader.Close()
            myCommand.Dispose()
            CerrarConexion()
            ultimonumero = auxnumero
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Asignación de Código de factura", MessageBoxButtons.OK)
        End Try
    End Function

    Private Sub btnimprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim wkletras As String
        If Len(Trim(Me.txtTIMBRADO.Text)) = 0 Or Len(Trim(Me.txtVALIDEZ.Text)) = 0 Then
            MessageBox.Show("Debe Ingresar el timbrado y el texto de la fecha de validez", strSLOGAN, MessageBoxButtons.OK)
        Else
            Try
                Dim wktimbrado = Me.txtTIMBRADO.Text
                Dim wkvalido = Me.txtVALIDEZ.Text
                Dim dsIMPRESION As DataSet = New DataSet
                Dim adIMPRESION As New Odbc.OdbcDataAdapter
                Dim intindice As Integer

                glonumero = Val(Me.txtnumero.Text)
                wkletras = Letras(Trim(Replace(Me.txttotal.Text, ".", "")))

                strSQL = "SELECT *  FROM factura where facnumero = " & glonumero & ";"

                With adIMPRESION
                    .SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    .Fill(dsIMPRESION, "factura")
                End With

                Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                With report
                    .Load(wkdirectorio & "\crpfactura.rpt")
                    '.PrintToPrinter(1, False, 1, 100)
                    .SetDataSource(dsIMPRESION)
                    .SetParameterValue(0, wkletras)
                    .SetParameterValue(1, wktimbrado)
                    .SetParameterValue(2, wkvalido)
                End With

                'For intindice = 1 To 2
                Dim frmREPORT As New frmREPORTE
                With frmREPORT
                    .crvimpre.ReportSource = report
                    .crvimpre.SelectionFormula = "{factura.facnumero} = " & glonumero
                    .Show()
                End With
                'Next intindice
            Catch err As Exception
                MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
                End
            End Try
        End If
    End Sub

    Private Sub txtPORCENTAJE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPORCENTAJE.SelectedIndexChanged

    End Sub

    Private Sub txtPORCENTAJE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPORCENTAJE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim wkfactimbrado, wkfacvalidez As String
        Try
            blnEXISTE = False

            wkfactimbrado = Trim(Me.txtTIMBRADO.Text)
            wkfacvalidez = Trim(Me.txtVALIDEZ.Text)
            If Len(wkfactimbrado) > 0 And Len(wkfacvalidez) > 0 Then

                AbrirConexion()
                If blnEXISTE = False Then
                    strSQL = "INSERT INTO facturaconfig (factimbrado, facvalidez) " & _
                                "VALUES ('" & wkfactimbrado & "', '" & wkfacvalidez & "')"
                Else
                    strSQL = "UPDATE facturaconfig SET " & _
                    "factimbrado = '" & wkfactimbrado & "', " & _
                    "facvalidez = '" & wkfacvalidez & "'"
                End If
                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                CerrarConexion()
                MessageBox.Show("Registro ha sido grabado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
            End If
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
        End Try

    End Sub
    Function existeCONFIG(ByVal wkfactimbrado As String, ByVal wkfacvalidez As String) As Boolean
        If Len(Trim(wkfactimbrado)) > 0 And Len(Trim(wkfacvalidez)) > 0 Then
            Try
                AbrirConexion()
                strSQL = "SELECT factimbrado, facvalidez " & _
                                "from facturaconfig;"
                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                blnEXISTE = False
                While myReader.Read()
                    If Not IsDBNull(myReader.GetString(0)) Then
                        blnEXISTE = True
                    Else
                        blnEXISTE = False
                    End If
                End While
                myReader.Close()
                CerrarConexion()
                existeCONFIG = blnEXISTE
            Catch err As Exception
                MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End Try
        End If

    End Function

End Class

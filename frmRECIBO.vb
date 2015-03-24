Public Class frmRECIBO
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAYUDA As System.Windows.Forms.Button
    Friend WithEvents datfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcheque As System.Windows.Forms.TextBox
    Friend WithEvents txtbanco As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFUENTE As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtconcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcheque = New System.Windows.Forms.TextBox
        Me.txtbanco = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtFUENTE = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txttipo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtconcepto = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtbeneficiario = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnAYUDA = New System.Windows.Forms.Button
        Me.datfecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtcheque)
        Me.GroupBox1.Controls.Add(Me.txtbanco)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtFUENTE)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtconcepto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbeneficiario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnAYUDA)
        Me.GroupBox1.Controls.Add(Me.datfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Ingreso de Datos"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(264, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 27)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Banco"
        '
        'txtcheque
        '
        Me.txtcheque.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtcheque.Enabled = False
        Me.txtcheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheque.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtcheque.Location = New System.Drawing.Point(556, 337)
        Me.txtcheque.MaxLength = 24
        Me.txtcheque.Name = "txtcheque"
        Me.txtcheque.Size = New System.Drawing.Size(117, 26)
        Me.txtcheque.TabIndex = 13
        Me.txtcheque.Text = ""
        '
        'txtbanco
        '
        Me.txtbanco.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtbanco.Enabled = False
        Me.txtbanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbanco.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtbanco.Location = New System.Drawing.Point(323, 335)
        Me.txtbanco.MaxLength = 14
        Me.txtbanco.Name = "txtbanco"
        Me.txtbanco.Size = New System.Drawing.Size(128, 26)
        Me.txtbanco.TabIndex = 12
        Me.txtbanco.Text = ""
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(457, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 27)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Nro cheque"
        '
        'txtFUENTE
        '
        Me.txtFUENTE.Items.AddRange(New Object() {"Caja Chica", "Cheque"})
        Me.txtFUENTE.Location = New System.Drawing.Point(140, 332)
        Me.txtFUENTE.Name = "txtFUENTE"
        Me.txtFUENTE.Size = New System.Drawing.Size(117, 28)
        Me.txtFUENTE.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 27)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Fuente"
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(140, 299)
        Me.txtmonto.MaxLength = 12
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(91, 26)
        Me.txtmonto.TabIndex = 10
        Me.txtmonto.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 27)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Monto Gs."
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(248, 146)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(47, 28)
        Me.btnbuscar.TabIndex = 5
        Me.btnbuscar.TabStop = False
        Me.btnbuscar.Text = "..."
        '
        'txtruc
        '
        Me.txtruc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtruc.Location = New System.Drawing.Point(140, 146)
        Me.txtruc.MaxLength = 64
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(103, 26)
        Me.txtruc.TabIndex = 4
        Me.txtruc.Text = ""
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 27)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "CI Socio"
        '
        'txttipo
        '
        Me.txttipo.Items.AddRange(New Object() {"Ingreso", "Salida"})
        Me.txttipo.Location = New System.Drawing.Point(140, 39)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(129, 28)
        Me.txttipo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 27)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Tipo de Recibo"
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(140, 266)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(211, 28)
        Me.txtconcepto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 27)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Concepto"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(140, 208)
        Me.txtdescripcion.MaxLength = 128
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(466, 51)
        Me.txtdescripcion.TabIndex = 8
        Me.txtdescripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Descripción"
        '
        'txtbeneficiario
        '
        Me.txtbeneficiario.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtbeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeneficiario.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtbeneficiario.Location = New System.Drawing.Point(140, 177)
        Me.txtbeneficiario.MaxLength = 64
        Me.txtbeneficiario.Name = "txtbeneficiario"
        Me.txtbeneficiario.Size = New System.Drawing.Size(392, 26)
        Me.txtbeneficiario.TabIndex = 7
        Me.txtbeneficiario.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 27)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Beneficiario"
        '
        'btnAYUDA
        '
        Me.btnAYUDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAYUDA.Location = New System.Drawing.Point(220, 72)
        Me.btnAYUDA.Name = "btnAYUDA"
        Me.btnAYUDA.Size = New System.Drawing.Size(47, 28)
        Me.btnAYUDA.TabIndex = 2
        Me.btnAYUDA.TabStop = False
        Me.btnAYUDA.Text = "..."
        '
        'datfecha
        '
        Me.datfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.datfecha.Location = New System.Drawing.Point(140, 103)
        Me.datfecha.Name = "datfecha"
        Me.datfecha.Size = New System.Drawing.Size(132, 26)
        Me.datfecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 27)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Número"
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(140, 70)
        Me.txtnumero.MaxLength = 5
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(75, 26)
        Me.txtnumero.TabIndex = 1
        Me.txtnumero.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(15, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(691, 32)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "EMISION DE RECIBO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(491, 464)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(95, 25)
        Me.btnimprimir.TabIndex = 3
        Me.btnimprimir.Text = "&Imprimir"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(385, 464)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(95, 25)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "&Eliminar"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(591, 464)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(95, 25)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "&Salir"
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(283, 464)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(95, 25)
        Me.btngrabar.TabIndex = 1
        Me.btngrabar.Text = "&Grabar"
        '
        'frmRECIBO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 501)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRECIBO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Emisión de Recibo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub txttipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttipo.SelectedIndexChanged

    End Sub

    Private Sub txttipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttipo.LostFocus
        If txttipo.Text = "Ingreso" Then
            With Me
                .txtruc.Enabled = True
                .txtFUENTE.SelectedIndex = -1
                .txtFUENTE.Enabled = False
                .txtbanco.Enabled = False
                .txtcheque.Enabled = False
                .txtbeneficiario.Enabled = False
                .btnbuscar.Enabled = True
            End With
        Else
            With Me
                .txtruc.Enabled = True
                .txtbeneficiario.Enabled = True
                .txtFUENTE.Enabled = True
                .txtbanco.Enabled = True
                .txtcheque.Enabled = True
                .btnbuscar.Enabled = False
            End With
        End If
    End Sub

    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub frmRECIBO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txttipo.SelectedIndex = 0
        AbrirConexion()
        Call cargarConcepto()
        CerrarConexion()
    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

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

    Private Sub datfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datfecha.ValueChanged

    End Sub

    Private Sub datfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datfecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtruc.TextChanged

    End Sub

    Private Sub txtruc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtruc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtruc.GotFocus
        If Len(Trim(txtruc.Text)) > 0 Then
            txtruc.SelectionStart = 0
            txtruc.SelectionLength = Len(Trim(txtruc.Text))
        End If
    End Sub

    Private Sub txtbeneficiario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbeneficiario.TextChanged

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

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

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


    Private Sub txtconcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconcepto.SelectedIndexChanged

    End Sub

    Private Sub txtconcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconcepto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtmonto.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtFUENTE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFUENTE.SelectedIndexChanged

    End Sub

    Private Sub txtFUENTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFUENTE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtbanco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbanco.TextChanged

    End Sub

    Private Sub txtbanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbanco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtcheque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcheque.TextChanged

    End Sub

    Private Sub txtcheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcheque.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnAYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAYUDA.Click
        Dim frmNEW As New frmRECIBOCON
        If Me.txttipo.Text = "Ingreso" Then
            glonumero = 1
            glotipo = "Ingreso"
        Else
            glonumero = 2
            glotipo = "Salida"
        End If
        frmNEW.ShowDialog()
        If Not glonumero = 0 Then
            With Me
                .txtnumero.Text = glonumero
                .txtnumero.Focus()
            End With
        End If
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim auxnumero As Double
        Dim auxtipo As String
        Try
            auxnumero = Double.Parse(Me.txtnumero.Text)
            auxtipo = Me.txttipo.Text

            If MessageBox.Show("Desea eliminar este registro?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                eliminarRecibo(auxnumero, auxtipo)
                MessageBox.Show("Registro eliminado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
                Me.txtnumero.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un problema al eliminar el registro..", strSLOGAN, MessageBoxButtons.OK)
        End Try


    End Sub
    Public Sub eliminarRecibo(ByVal auxnumero As Double, ByVal auxtipo As String)
        Try
            AbrirConexion()
            strsql = "delete from recibo where recnumero = " & auxnumero & " and rectipo = '" & auxtipo & "'"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la eliminacion de Registro", MessageBoxButtons.OK)
            End

        End Try
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If validarDATOS() = True Then
            grabarDATOS()
            vaciarFORMULARIO(False)
        End If

    End Sub
    Function validarDATOS() As Boolean
        Dim auxBANDERA As Boolean
        auxBANDERA = True
        If Len(Trim(Me.txtnumero.Text)) <= 0 Then
            MessageBox.Show("Debe ingresar del Número de Recibo", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtnumero.Focus()
        ElseIf Len(Trim(Me.txttipo.Text)) <= 0 Then
            MessageBox.Show("Debe ingresar el Tipo de Recibo", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txttipo.Focus()
        ElseIf Len(Trim(Me.txtbeneficiario.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el Nombre y Apellido", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtbeneficiario.Focus()
        ElseIf Len(Trim(Me.txtdescripcion.Text)) = 0 Then
            MessageBox.Show("Debe ingresar la descripción", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtdescripcion.Focus()
        ElseIf Len(Trim(Me.txtmonto.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el monto del Recibo", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtmonto.Focus()
        ElseIf Len(Trim(Me.txtruc.Text)) = 0 Then
            MessageBox.Show("Debe ingresar el RUC o Nro. de cédula", strSLOGAN, MessageBoxButtons.OK)
            auxBANDERA = False
            Me.txtruc.Focus()
        End If
        validarDATOS = auxBANDERA
    End Function
    Sub grabarDATOS()
        Dim wktipo As String
        Dim wknumero As Double
        Dim wkfecha As String
        Dim wkruc As String
        Dim wkbeneficiario As String
        Dim wkdescripcion As String
        Dim wkconcepto As Integer
        Dim wkmonto As Double
        Dim wkfuente As String
        Dim wkbanco As String
        Dim wkcheque As String

        wktipo = Me.txttipo.Text
        wknumero = Trim(Me.txtnumero.Text)
        wkruc = Trim(Me.txtruc.Text)
        wkfecha = Format(Me.datfecha.Value, "yyyy-MM-dd")
        wkbeneficiario = Trim(Me.txtbeneficiario.Text)
        wkdescripcion = Trim(Me.txtdescripcion.Text)
        wkconcepto = Val(Me.txtconcepto.Text)
        wkmonto = Val(Me.txtmonto.Text)
        wkfuente = Me.txtFUENTE.Text
        wkbanco = Me.txtbanco.Text
        wkcheque = Trim(Me.txtcheque.Text)
        Try
            AbrirConexion()
            If blnEXISTE = False Then
                strsql = "INSERT INTO recibo (rectipo, recnumero, recfecha, recruc, recbeneficiario,  " & _
                                      "recdescripcion,recconcepto, recmonto, " & _
                                      "recfuente, recbanco, reccheque) " & _
                              "VALUES ('" & wktipo & "', " & wknumero & ", '" & wkfecha & _
                              "', '" & wkruc & "', '" & wkbeneficiario & _
                              "', '" & wkdescripcion & _
                              "', " & wkconcepto & ", " & wkmonto & _
                              ", '" & wkfuente & _
                              "', '" & wkbanco & _
                              "', '" & wkcheque & "')"
            Else
                strsql = "UPDATE recibo SET " & _
                "rectipo = '" & wktipo & "', " & _
                "recnumero = " & wknumero & ", " & _
                "recfecha = '" & wkfecha & "', " & _
                "recruc = '" & wkruc & "', " & _
                "recbeneficiario = '" & wkbeneficiario & " ', " & _
                "recdescripcion = '" & wkdescripcion & "', " & _
                "recconcepto = " & wkconcepto & ", " & _
                "recmonto = " & wkmonto & ", " & _
                "recfuente = '" & wkfuente & "', " & _
                "recbanco = '" & wkbanco & "', " & _
                "reccheque = '" & wkcheque & "' " & _
                "WHERE recnumero = " & wknumero & " and rectipo = '" & wktipo & "'"
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
    Sub vaciarFORMULARIO(ByVal forma As Boolean)
        With Me
            '.txttipo.SelectedIndex = 0
            '.txtnumero.Text = ""
            .txtruc.Text = ""
            .txtbeneficiario.Text = ""
            If forma = True Then
                .txtdescripcion.Text = ""
                .txtconcepto.SelectedIndex = -1
                .txtmonto.Text = ""
                .txtFUENTE.SelectedIndex = -1
                .txtbanco.Text = ""
                .txtcheque.Text = ""
            End If
        End With
    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim wkletras, wkconcepto As String
        Dim auxtipo As String
        Try
            Dim dsIMPRESION As DataSet = New DataSet
            Dim adIMPRESION As New Odbc.OdbcDataAdapter

            glonumero = Val(Me.txtnumero.Text)
            wkletras = UCase(Letras(Trim(Me.txtmonto.Text)))
            auxtipo = Me.txttipo.Text
            wkconcepto = Me.txtconcepto.Text

            strsql = "SELECT *  FROM recibo where recnumero = " & glonumero & " and rectipo = '" & auxtipo & "';"

            With adIMPRESION
                .SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
                .Fill(dsIMPRESION, "RECIBO")
            End With

            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            With report
                .Load(wkdirectorio & "\crpRECIBO.rpt")
                .SetDataSource(dsIMPRESION)
                .SetParameterValue(0, wkletras)
                .SetParameterValue(1, wkconcepto)
            End With

            Dim frmREPORT As New frmREPORTE
            With frmREPORT
                .crvimpre.ReportSource = report
                .crvimpre.SelectionFormula = "{recibo.recnumero} = " & glonumero & " and {recibo.rectipo} = '" & auxtipo & "'"
                .Show()
            End With
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End
        End Try
    End Sub

    Private Sub txtnumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.LostFocus
        Dim auxnumero As Double
        Dim auxtipo As String
        auxnumero = Val(Me.txtnumero.Text)
        auxtipo = Me.txttipo.Text
        blnEXISTE = False
        Call cargarRECIBO(auxnumero, auxtipo)
    End Sub
    Public Function cargarRECIBO(ByVal auxnumero As Double, ByVal auxtipo As String) As Boolean
        Dim indice As Integer
        Dim wkarbfoto As String
        Try
            blnEXISTE = False
            AbrirConexion()
            strsql = "SELECT recnumero, rectipo, recfecha, recruc, recbeneficiario,  " & _
                            "recdescripcion, recconcepto, recmonto, recfuente, recbanco, reccheque from recibo where recnumero = " & auxnumero & " and rectipo = '" & auxtipo & "';"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()
                With Me
                    vaciarFORMULARIO(True)
                    If myReader.GetString(1) = "Ingreso" Then
                        Me.txttipo.SelectedIndex = 0
                    Else
                        Me.txttipo.SelectedIndex = 1
                    End If
                    .datfecha.Value = myReader.GetDate(2)
                    .txtruc.Text = myReader.GetString(3)
                    .txtbeneficiario.Text = myReader.GetString(4)
                    .txtdescripcion.Text = myReader.GetString(5)

                    For indice = 0 To Me.txtconcepto.Items.Count - 1
                        If UCase(Microsoft.VisualBasic.Left(Me.txtconcepto.Items.Item(indice), 1)) = UCase(myReader.GetString(6)) Then
                            Me.txtconcepto.SelectedIndex = indice
                            Exit For
                        End If
                    Next

                    .txtmonto.Text = myReader.GetValue(7)

                    If Trim(myReader.GetString(8)) = "Cheque" Then
                        .txtFUENTE.SelectedIndex = 1
                        .txtbanco.Text = myReader.GetString(9)
                        .txtcheque.Text = myReader.GetString(10)
                    Else
                        With Me
                            .txtFUENTE.SelectedIndex = 0
                            .txtbanco.Text = ""
                            .txtcheque.Text = ""
                        End With
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

    Private Sub txtnumero_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.DoubleClick
        glotipo = Me.txttipo.Text
        Me.txtnumero.Text = ultimonumero() + 1
    End Sub
    Function ultimonumero() As Integer
        Dim auxnumero As Integer
        Try
            AbrirConexion()
            strsql = "SELECT max(recnumero) as recnumero from recibo where rectipo = '" & glotipo & "'"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
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
            MessageBox.Show(err.Message, "Error en Asignación de Código de Recibo", MessageBoxButtons.OK)
        End Try
    End Function

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim frmNEW As New frmDATOSCON
        wkarbcedula = 0
        glonombre = ""
        frmNEW.ShowDialog()
        If Not wkarbcedula = 0 Then
            With Me
                .txtruc.Text = wkarbcedula
                .txtbeneficiario.Text = glonombre
                .txtruc.Focus()
            End With
        End If
    End Sub
    Sub cargarConcepto()
        Dim strELEMENTO As String
        Dim wkconcodigo As Integer
        Dim wkconnombre As String
        Dim wkcontipo As String


        Dim strsql As String = "SELECT concodigo, connombre, contipo from concepto order by concodigo;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkconcodigo = myReader.GetValue(0)
            wkconnombre = myReader.GetString(1)
            wkcontipo = myReader.GetString(2)

            strELEMENTO = wkconcodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkconnombre
            If wkcontipo = "D" Then
                Me.txtconcepto.Items.Add(strELEMENTO)
            End If
        End While
        myReader.Close()
    End Sub
    Function asignaMONTO(ByVal intconcepto As Integer) As Integer
        Dim auxmonto As Integer
        AbrirConexion()
        strsql = "SELECT conmonto from concepto where concodigo = " & intconcepto & ""
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        While myReader.Read()
            If IsDBNull(myReader.GetValue(0)) = False Then
                auxmonto = Int(myReader.GetValue(0))
            End If
        End While
        myReader.Close()
        CerrarConexion()
        asignaMONTO = auxmonto
    End Function

    Private Sub txtmonto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmonto.Enter
        Me.txtmonto.Text = asignaMONTO(Val(Me.txtconcepto.Text))
        If Len(Trim(txtmonto.Text)) > 0 Then
            txtmonto.SelectionStart = 0
            txtmonto.SelectionLength = Len(Trim(txtmonto.Text))
        End If
    End Sub

End Class

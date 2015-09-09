Public Class frmINGRESO

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
    Friend WithEvents txtPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnACEPTAR As System.Windows.Forms.Button
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnINGRESAR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblBIENVENIDA As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmINGRESO))
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUSUARIO = New System.Windows.Forms.TextBox()
        Me.btnACEPTAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBIENVENIDA = New System.Windows.Forms.Label()
        Me.btnINGRESAR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASSWORD.Location = New System.Drawing.Point(288, 512)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASSWORD.Size = New System.Drawing.Size(248, 29)
        Me.txtPASSWORD.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblUsuario.Location = New System.Drawing.Point(168, 472)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(104, 23)
        Me.lblUsuario.TabIndex = 11
        Me.lblUsuario.Text = "USUARIO"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(168, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUSUARIO
        '
        Me.txtUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSUARIO.Location = New System.Drawing.Point(288, 472)
        Me.txtUSUARIO.Name = "txtUSUARIO"
        Me.txtUSUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUSUARIO.Size = New System.Drawing.Size(248, 29)
        Me.txtUSUARIO.TabIndex = 0
        '
        'btnACEPTAR
        '
        Me.btnACEPTAR.BackColor = System.Drawing.Color.Transparent
        Me.btnACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnACEPTAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnACEPTAR.ForeColor = System.Drawing.Color.Red
        Me.btnACEPTAR.Location = New System.Drawing.Point(360, 552)
        Me.btnACEPTAR.Name = "btnACEPTAR"
        Me.btnACEPTAR.Size = New System.Drawing.Size(96, 24)
        Me.btnACEPTAR.TabIndex = 2
        Me.btnACEPTAR.Text = "&INGRESAR"
        Me.btnACEPTAR.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Transparent
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSALIR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.Red
        Me.btnSALIR.Location = New System.Drawing.Point(240, 552)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(96, 24)
        Me.btnSALIR.TabIndex = 3
        Me.btnSALIR.Text = "&SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(128, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 472)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblBIENVENIDA)
        Me.GroupBox1.Controls.Add(Me.btnINGRESAR)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 136)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&SALIR"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(48, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PARA INGRESAR PULSE CLICK EN ACEPTAR"
        '
        'lblBIENVENIDA
        '
        Me.lblBIENVENIDA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBIENVENIDA.Location = New System.Drawing.Point(56, 16)
        Me.lblBIENVENIDA.Name = "lblBIENVENIDA"
        Me.lblBIENVENIDA.Size = New System.Drawing.Size(272, 40)
        Me.lblBIENVENIDA.TabIndex = 1
        Me.lblBIENVENIDA.Text = "BIENVENIDOS AL SISTEMA DE ADMINISTRACION  DEL C.P.A.F."
        '
        'btnINGRESAR
        '
        Me.btnINGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINGRESAR.Location = New System.Drawing.Point(304, 104)
        Me.btnINGRESAR.Name = "btnINGRESAR"
        Me.btnINGRESAR.Size = New System.Drawing.Size(80, 24)
        Me.btnINGRESAR.TabIndex = 0
        Me.btnINGRESAR.Text = "&ACEPTAR"
        '
        'Timer1
        '
        '
        'frmINGRESO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(720, 636)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnACEPTAR)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUSUARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPASSWORD)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmINGRESO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "&SALIR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Sub cargarUsuario()
        Dim strELEMENTO As String
        Dim wkUSUUSUARIO As String
        Dim wkUSUPASSWORD As String


        Dim strsql As String = "SELECT usuCODIGO, usuNOMBRE, usuPASSWORD from usuario order by usuCODIGO;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkUSUUSUARIO = myReader.GetValue(0)
            wkUSUPASSWORD = myReader.GetString(1)

            strELEMENTO = wkUSUUSUARIO
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkUSUPASSWORD

        End While
        myReader.Close()
    End Sub

    Private Sub frmINICIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = strSLOGAN
        Call AbrirConexion()
        Call CerrarConexion()
        Me.Timer1.Start()
        Timer1.Interval = 800

    End Sub

    Private Sub txtPASSWORD_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intLONGITUD As Integer
        intLONGITUD = Len(Trim(txtPASSWORD.Text))

        If intLONGITUD > 0 Then
            With txtPASSWORD
                .SelectionStart = 0
                .SelectionLength = intLONGITUD
            End With
        End If
    End Sub

    Private Sub txtPASSWORD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            Me.btnACEPTAR.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If

    End Sub

    Function validarPASSWORD() As Boolean
        Dim auxUSUUSUARIO As String
        Dim auxUSUPASSWORD As String

        wkUSUUSUARIO = Me.txtUSUARIO.Text
        wkUSUPASSWORD = Me.txtPASSWORD.Text

        AbrirConexion()
        Dim strsql As String = "SELECT usuUSUARIO, usuPASSWORD from usuario  WHERE usuUSUARIO = '" & Me.txtUSUARIO.Text & "';"

        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            auxUSUUSUARIO = myReader.GetValue(0)
            auxUSUPASSWORD = myReader.GetString(1)
        End While
        myReader.Close()
        CerrarConexion()
        If (UCase(auxUSUPASSWORD) = UCase(Me.txtPASSWORD.Text)) And (Me.txtPASSWORD.Text <> "") Then
            validarPASSWORD = True
           
        Else
            validarPASSWORD = False
            wkUSUUSUARIO = Nothing
            wkUSUPASSWORD = Nothing
            MessageBox.Show("Usuario o password no valido", strSLOGAN, MessageBoxButtons.OK)
        End If
    End Function
    Private Sub txtPASSWORD_KeyPress1(ByVal sender As Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPASSWORD.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            Me.btnACEPTAR.Focus()
        End If
    End Sub

    Private Sub txtUSUARIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUSUARIO.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnACEPTAR_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtPASSWORD.SelectAll()
    End Sub

    Private Sub txtUSUARIO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSUARIO.GotFocus
        txtUSUARIO.SelectAll()
    End Sub

    Private Sub btnACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACEPTAR.Click
        If validarPASSWORD() = True Then
            Dim frmNew As New frmMENU
            Me.Hide()
            frmNew.Show()
        End If
        Me.txtPASSWORD.Focus()
    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Call CerrarConexion()
        If MessageBox.Show("Desea Salir del sistema?", strSLOGAN, MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub btnINGRESAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINGRESAR.Click
        Me.GroupBox1.Visible = False
        Me.txtUSUARIO.Focus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (Me.lblBIENVENIDA.Visible = True) Then
            Me.lblBIENVENIDA.Visible = False
        Else
            Me.lblBIENVENIDA.Visible = True

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CerrarConexion()
        If MessageBox.Show("Desea Salir del sistema?", strSLOGAN, MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub txtPASSWORD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPASSWORD.GotFocus
        txtPASSWORD.SelectionStart = 0
        txtPASSWORD.SelectionLength = Len(Trim(txtPASSWORD.Text))

    End Sub

   
End Class

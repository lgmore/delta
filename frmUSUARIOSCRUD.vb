Public Class frmUSUARIOSCRUD
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
    Friend WithEvents txtUSUPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents txtUSUNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents intUSUCODIGO As System.Windows.Forms.TextBox
    Friend WithEvents lblPASSWORD As System.Windows.Forms.Label
    Friend WithEvents lblNOMBRE As System.Windows.Forms.Label
    Friend WithEvents lblCODIGO As System.Windows.Forms.Label
    Friend WithEvents lblUSUARIOS As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnELIMINAR As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents btnAGREGAR As System.Windows.Forms.Button
    Friend WithEvents lblUSUARIO As System.Windows.Forms.Label
    Friend WithEvents txtUSUUSUARIO As System.Windows.Forms.TextBox
    Public WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.lblPASSWORD = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.lblNOMBRE = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblUSUARIO = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblCODIGO = New System.Windows.Forms.Label
        Me.intUSUCODIGO = New System.Windows.Forms.TextBox
        Me.txtUSUUSUARIO = New System.Windows.Forms.TextBox
        Me.txtUSUPASSWORD = New System.Windows.Forms.TextBox
        Me.txtUSUNOMBRE = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblUSUARIOS = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAGREGAR = New System.Windows.Forms.Button
        Me.btnMODIFICAR = New System.Windows.Forms.Button
        Me.btnELIMINAR = New System.Windows.Forms.Button
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 408)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.intUSUCODIGO)
        Me.GroupBox4.Controls.Add(Me.txtUSUUSUARIO)
        Me.GroupBox4.Controls.Add(Me.txtUSUPASSWORD)
        Me.GroupBox4.Controls.Add(Me.txtUSUNOMBRE)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 240)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblPASSWORD)
        Me.GroupBox8.Location = New System.Drawing.Point(40, 160)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(160, 32)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        '
        'lblPASSWORD
        '
        Me.lblPASSWORD.ForeColor = System.Drawing.Color.Black
        Me.lblPASSWORD.Location = New System.Drawing.Point(8, 8)
        Me.lblPASSWORD.Name = "lblPASSWORD"
        Me.lblPASSWORD.Size = New System.Drawing.Size(72, 16)
        Me.lblPASSWORD.TabIndex = 3
        Me.lblPASSWORD.Text = "PASSWORD"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblNOMBRE)
        Me.GroupBox7.Location = New System.Drawing.Point(40, 104)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(160, 40)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        '
        'lblNOMBRE
        '
        Me.lblNOMBRE.ForeColor = System.Drawing.Color.Black
        Me.lblNOMBRE.Location = New System.Drawing.Point(8, 16)
        Me.lblNOMBRE.Name = "lblNOMBRE"
        Me.lblNOMBRE.Size = New System.Drawing.Size(128, 16)
        Me.lblNOMBRE.TabIndex = 2
        Me.lblNOMBRE.Text = "NOMBRE Y APELLIDO"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblUSUARIO)
        Me.GroupBox6.Location = New System.Drawing.Point(40, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(160, 32)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'lblUSUARIO
        '
        Me.lblUSUARIO.ForeColor = System.Drawing.Color.Black
        Me.lblUSUARIO.Location = New System.Drawing.Point(8, 8)
        Me.lblUSUARIO.Name = "lblUSUARIO"
        Me.lblUSUARIO.Size = New System.Drawing.Size(56, 16)
        Me.lblUSUARIO.TabIndex = 1
        Me.lblUSUARIO.Text = "USUARIO"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblCODIGO)
        Me.GroupBox5.Location = New System.Drawing.Point(40, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(160, 32)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'lblCODIGO
        '
        Me.lblCODIGO.ForeColor = System.Drawing.Color.Black
        Me.lblCODIGO.Location = New System.Drawing.Point(8, 8)
        Me.lblCODIGO.Name = "lblCODIGO"
        Me.lblCODIGO.Size = New System.Drawing.Size(57, 16)
        Me.lblCODIGO.TabIndex = 0
        Me.lblCODIGO.Text = "CODIGO"
        '
        'intUSUCODIGO
        '
        Me.intUSUCODIGO.Location = New System.Drawing.Point(200, 32)
        Me.intUSUCODIGO.MaxLength = 3
        Me.intUSUCODIGO.Name = "intUSUCODIGO"
        Me.intUSUCODIGO.Size = New System.Drawing.Size(32, 20)
        Me.intUSUCODIGO.TabIndex = 0
        Me.intUSUCODIGO.Text = ""
        '
        'txtUSUUSUARIO
        '
        Me.txtUSUUSUARIO.Location = New System.Drawing.Point(200, 72)
        Me.txtUSUUSUARIO.MaxLength = 25
        Me.txtUSUUSUARIO.Name = "txtUSUUSUARIO"
        Me.txtUSUUSUARIO.Size = New System.Drawing.Size(144, 20)
        Me.txtUSUUSUARIO.TabIndex = 1
        Me.txtUSUUSUARIO.Text = ""
        '
        'txtUSUPASSWORD
        '
        Me.txtUSUPASSWORD.Location = New System.Drawing.Point(200, 168)
        Me.txtUSUPASSWORD.MaxLength = 35
        Me.txtUSUPASSWORD.Name = "txtUSUPASSWORD"
        Me.txtUSUPASSWORD.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUSUPASSWORD.Size = New System.Drawing.Size(216, 20)
        Me.txtUSUPASSWORD.TabIndex = 3
        Me.txtUSUPASSWORD.Text = ""
        '
        'txtUSUNOMBRE
        '
        Me.txtUSUNOMBRE.Location = New System.Drawing.Point(200, 120)
        Me.txtUSUNOMBRE.MaxLength = 35
        Me.txtUSUNOMBRE.Name = "txtUSUNOMBRE"
        Me.txtUSUNOMBRE.Size = New System.Drawing.Size(192, 20)
        Me.txtUSUNOMBRE.TabIndex = 2
        Me.txtUSUNOMBRE.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.GroupBox3.Controls.Add(Me.lblUSUARIOS)
        Me.GroupBox3.Location = New System.Drawing.Point(88, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 48)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'lblUSUARIOS
        '
        Me.lblUSUARIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUSUARIOS.Location = New System.Drawing.Point(56, 16)
        Me.lblUSUARIOS.Name = "lblUSUARIOS"
        Me.lblUSUARIOS.Size = New System.Drawing.Size(224, 16)
        Me.lblUSUARIOS.TabIndex = 9
        Me.lblUSUARIOS.Text = "REGISTRO DE USUARIOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.GroupBox2.Controls.Add(Me.btnAGREGAR)
        Me.GroupBox2.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.btnELIMINAR)
        Me.GroupBox2.Controls.Add(Me.btnSALIR)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 64)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.BackColor = System.Drawing.Color.Silver
        Me.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAGREGAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.Color.Black
        Me.btnAGREGAR.Location = New System.Drawing.Point(48, 24)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(96, 24)
        Me.btnAGREGAR.TabIndex = 0
        Me.btnAGREGAR.Text = "&AGREGAR"
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMODIFICAR.BackColor = System.Drawing.Color.Silver
        Me.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.ForeColor = System.Drawing.Color.Black
        Me.btnMODIFICAR.Location = New System.Drawing.Point(152, 24)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(96, 24)
        Me.btnMODIFICAR.TabIndex = 15
        Me.btnMODIFICAR.Text = "&MODIFICAR"
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.BackColor = System.Drawing.Color.Silver
        Me.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnELIMINAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.ForeColor = System.Drawing.Color.Black
        Me.btnELIMINAR.Location = New System.Drawing.Point(256, 24)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(96, 24)
        Me.btnELIMINAR.TabIndex = 4
        Me.btnELIMINAR.Text = "&ELIMINAR"
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Silver
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSALIR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.Black
        Me.btnSALIR.Location = New System.Drawing.Point(360, 24)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(96, 24)
        Me.btnSALIR.TabIndex = 14
        Me.btnSALIR.Text = "&SALIR"
        '
        'frmUSUARIOSCRUD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 429)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUSUARIOSCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CODIFICACION DE USUARIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub txtUSUPASSWORD_KeyPress(ByVal Eventsender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUSUPASSWORD.KeyPress

        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = 13 Then

            Me.btnAGREGAR.Focus()
        Else
            Try
                If KeyAscii = 0 Then
                    Eventsender.Handled = True
                End If

            Catch ex As Exception
                MessageBox.Show(" Error al ingresar el Password, Reviselo!!! ", strSLOGAN, MessageBoxButtons.OK)
                Me.txtUSUPASSWORD.Text = ""
            End Try
        End If

    End Sub

    Private Sub intUSUCODIGO_KeyPress(ByVal EventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles intUSUCODIGO.KeyPress

        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            Me.txtUSUUSUARIO.Focus()
        End If
    End Sub


    Private Sub txtUSUNOMBRE_KeyPress(ByVal EventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUSUNOMBRE.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            Me.txtUSUPASSWORD.Focus()
        End If
    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Call CerrarConexion()
        Close()
    End Sub
    Sub procesar()
        Dim wkUSUCODIGO As Integer
        Dim wkUSUUSUARIO As String
        Dim wkUSUNOMBRE As String
        Dim wkUSUPASSWORD As String
        Dim strSQL As String

        Try
            AbrirConexion()
            wkUSUCODIGO = Val(Me.intUSUCODIGO.Text)
            wkUSUUSUARIO = Me.txtUSUUSUARIO.Text
            wkUSUNOMBRE = Me.txtUSUNOMBRE.Text
            wkUSUPASSWORD = Me.txtUSUPASSWORD.Text

            strSQL = "INSERT INTO USUARIO (USUCODIGO, USUUSUARIO, USUNOMBRE, USUPASSWORD) " & _
                      "VALUES (" & wkUSUCODIGO & ",'" & wkUSUUSUARIO & "','" & wkUSUNOMBRE & "', '" & wkUSUPASSWORD & "')"

            Dim mycommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            mycommand.ExecuteNonQuery()
            mycommand.Dispose()
            CerrarConexion()
            MessageBox.Show("Regístro ha sido  grabado con éxito!. Verifiquelo. ", strSLOGAN)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Grabación del registro")
            End
        End Try

    End Sub

    Sub limpiarCAMPOS()
        With Me
            .intUSUCODIGO.Text = ""
            .txtUSUUSUARIO.Text = ""
            .txtUSUNOMBRE.Text = ""
            .txtUSUPASSWORD.Text = ""

        End With
    End Sub
    Function validarDatos() As Boolean
        Dim blnOK As Boolean
        blnOK = True
        If Val(Me.intUSUCODIGO.Text) <= 0 Then
            blnOK = False
            MessageBox.Show("Codigo de Usuario no puede ser menores a cero", strSLOGAN)
        Else
            If Len(Trim(Me.txtUSUNOMBRE.Text)) <= 0 Then
                blnOK = False
                MessageBox.Show("Se debe ingresar Nombre de Usuario", strSLOGAN)
            End If
        End If
        validarDatos = blnOK
    End Function

    Private Sub btnSALIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
        ACTUALIZARDATAGRID = True
    End Sub

    Private Sub btnMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICAR.Click

        Dim wkUSUCODIGO As Integer
        Dim WKUSUUSUARIO As String
        Dim wkUSUNOMBRE As String
        Dim wkUSUPASSWORD As String
        Dim strSQL As String

        Try
            AbrirConexion()
            wkUSUCODIGO = Val(Me.intUSUCODIGO.Text)
            WKUSUUSUARIO = Me.txtUSUUSUARIO.Text
            wkUSUNOMBRE = Me.txtUSUNOMBRE.Text
            wkUSUPASSWORD = Me.txtUSUPASSWORD.Text

            'strSQL =  INTO USUARIO (USUCODIGO, USUNOMBRE, USUPASSWORD) " & _
            '          "VALUES (" & wkUSUCODIGO & ", '" & wkUSUNOMBRE & "', '" & wkUSUPASSWORD & "')"
            strSQL = "update usuario set " & _
                                           "usuCODIGO = " & wkUSUCODIGO & ", " & _
                                           "usuUSUARIO = '" & WKUSUUSUARIO & "', " & _
                                           "usuNOMBRE = '" & wkUSUNOMBRE & "', " & _
                                           "usuPASSWORD = '" & wkUSUPASSWORD & "' " & _
                                            "where usuCODIGO = " & wkUSUCODIGO & ""


            Dim mycommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            mycommand.ExecuteNonQuery()
            mycommand.Dispose()
            CerrarConexion()
            MessageBox.Show("Regístro ha sido  grabado con éxito!. Verifiquelo. ", strSLOGAN)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error en la Grabación del registro", strSLOGAN, MessageBoxButtons.OK)
            MessageBox.Show(ex.Message, "Error en la grabacion de registro")

            End
        End Try
    End Sub

    Private Sub btnAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGAR.Click
        If validarDatos() = True Then
            Call procesar()
            Call limpiarCAMPOS()
        End If
        Me.intUSUCODIGO.Focus()
    End Sub

    Private Sub txtUSUUSUARIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUSUUSUARIO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINAR.Click

        Dim wkUSUCODIGO As Integer
        Dim WKUSUUSUARIO As String
        Dim wkUSUNOMBRE As String
        Dim wkUSUPASSWORD As String
        Dim strSQL As String


        Try
            AbrirConexion()
            wkUSUCODIGO = Val(Me.intUSUCODIGO.Text)

            strSQL = "delete from usuario where  " & _
                                           "usuCODIGO = " & wkUSUCODIGO & " and usuUSUARIO <> 'root' ;"

            Dim mycommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            mycommand.ExecuteNonQuery()
            mycommand.Dispose()
            CerrarConexion()

            If (Me.txtUSUUSUARIO.Text = "root") Then

                MessageBox.Show("El usuario no puede ser eliminado !. Verifiquelo. ", strSLOGAN)
            Else

                MessageBox.Show("Regístro ha sido  eliminado con éxito!. Verifiquelo. ", strSLOGAN)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la eliminacion del registro")
            End
        End Try

    End Sub

    Private Sub btnAGREGAR_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAGREGAR.GotFocus
        intUSUCODIGO.Focus()
    End Sub
End Class


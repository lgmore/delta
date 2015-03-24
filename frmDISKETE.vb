Public Class frmDISKETE
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBUSCAR As System.Windows.Forms.Button
    Friend WithEvents txtARCHIVO As System.Windows.Forms.TextBox
    Friend WithEvents datfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btngenerar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBUSCAR = New System.Windows.Forms.Button
        Me.txtARCHIVO = New System.Windows.Forms.TextBox
        Me.datfecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btngenerar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(4, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(512, 32)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "GENERACIÓN DE DISKETE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBUSCAR)
        Me.GroupBox1.Controls.Add(Me.txtARCHIVO)
        Me.GroupBox1.Controls.Add(Me.datfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Archivo"
        '
        'btnBUSCAR
        '
        Me.btnBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR.Location = New System.Drawing.Point(406, 61)
        Me.btnBUSCAR.Name = "btnBUSCAR"
        Me.btnBUSCAR.Size = New System.Drawing.Size(47, 26)
        Me.btnBUSCAR.TabIndex = 2
        Me.btnBUSCAR.Text = "..."
        Me.btnBUSCAR.Visible = False
        '
        'txtARCHIVO
        '
        Me.txtARCHIVO.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtARCHIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARCHIVO.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.txtARCHIVO.Location = New System.Drawing.Point(126, 62)
        Me.txtARCHIVO.MaxLength = 64
        Me.txtARCHIVO.Name = "txtARCHIVO"
        Me.txtARCHIVO.Size = New System.Drawing.Size(275, 26)
        Me.txtARCHIVO.TabIndex = 1
        Me.txtARCHIVO.Text = ""
        '
        'datfecha
        '
        Me.datfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.datfecha.Location = New System.Drawing.Point(125, 33)
        Me.datfecha.Name = "datfecha"
        Me.datfecha.Size = New System.Drawing.Size(132, 26)
        Me.datfecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Fecha"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(405, 197)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 28)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "&Salir"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(308, 197)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(88, 29)
        Me.btngenerar.TabIndex = 3
        Me.btngenerar.Text = "&Generar"
        '
        'frmDISKETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(522, 240)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDISKETE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Generación de Diskete"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        Dim wkfecha As String
        wkfecha = Format(Me.datfecha.Value, "yyyy-MM-dd")
        If Len(Trim(Me.txtARCHIVO.Text)) > 0 Then
            vaciarMonto()
            AsignarMonto(wkfecha)
            actualizarBono(wkfecha)
            actualizarDescuento(wkfecha)
            generarArchivo(wkfecha)
        Else
            MessageBox.Show("Deberá ingresar el nombre del Archivo a enviar al Banco", strSLOGAN, MessageBoxButtons.OK)
            Me.txtARCHIVO.Focus()
        End If
    End Sub
    Sub generarArchivo(ByVal auxfecha As String)
        Dim wkarchivo, wklinea As String
        Dim wkcedula, wkcuenta, wkmonto, wkfecha As String
        Dim wknroempleado As Double
        Dim wkcontador As Integer = 0
        Dim wktotal As Double

        'Campo		Tipo		Longitud		Descripción

        'TJCOD		NUMERICO	    3		Código de la Empresa
        'TJNROEMP	NUMERICO	    5 		Código del empleado
        'EXP_3		CARACTER	    8		Fecha de proceso
        'TJMOD	NUMERICO	    2		Modulo de la cta. de la empresa.
        'TJSUCCTA	NUMERICO	    2		Sucursal de la Cta. de la empresa
        'TJCTA		NUMERICO 	    9		Numero de la Cta. de la empresa
        'TJEMMOD	NUMERICO	    2		Modulo de la Cta. del empleado
        'TJEMSUC	NUMERICO	    2		Sucursal de la Cta. del empleado
        'TJEMCTA	NUMERICO	    9		Numero de la Cta. del empelado
        'TJEMCRE	NUMERICO	   15,2		Monto a ser acreditado al empleado
        'TJEMLIM	NUMERICO	   15,2		Monto de control.
        'TJMDA	NUMERICO	     4		código de moneda de la cta. de la empresa
        'TJEMDA	NUMERICO	     4		Código de moneda de la cta. del empleado.


        Dim wkcodempresa As Integer = "194"
        'TJNROEMP	NUMERICO	    5 		Código del empleado
        'EXP_3		CARACTER	    8		Fecha de proceso
        Dim wkmodalidad As Integer = 20
        ''''TJSUCCTA	NUMERICO	    2		Sucursal de la Cta. de la empresa
        Dim wksucursal As Integer = 13
        ''''TJCTA		NUMERICO 	    9		Numero de la Cta. de la empresa
        Dim wknumerocta As Double = 1590108

        ''''TJEMMOD	NUMERICO	    2		Modulo de la Cta. del empleado
        Dim wkmodulo As Integer = 21

        ''''TJEMSUC	NUMERICO	    2		Sucursal de la Cta. del empleado
        Dim wksucursalemp As Integer = 13

        ''''TJEMCTA	NUMERICO	    9		Numero de la Cta. del empelado
        ''''TJEMCRE	NUMERICO	   15,2		Monto a ser acreditado al empleado
        ''''TJEMLIM	NUMERICO	   15,2		Monto de control.

        ''''TJMDA	NUMERICO	     4		código de moneda de la cta. de la empresa
        Dim wkmonedacta As Integer = 6900
        ''''TJEMDA	NUMERICO	     4		Código de moneda de la cta. del empleado.
        Dim wkmonedaemp As Integer = 6900


        wkfecha = Replace(auxfecha, "-", "")

        AbrirConexion()
        Dim strsql As String = "SELECT arbcedula, arbcuenta, arbmonto,arbempleado from arbitro where arbmonto > 0;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        wkarchivo = Trim(Me.txtARCHIVO.Text)
        FileOpen(1, wkarchivo, OpenMode.Output)

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkcedula = Trim(Str(myReader.GetValue(0)))
            wkcuenta = Trim(Str(myReader.GetValue(1)))
            wkmonto = Trim(Str(myReader.GetValue(2))) & ".00"
            wknroempleado = Trim(Str(Int(myReader.GetInt16(3))))

            wklinea = wkcodempresa & "," & _
                      wknroempleado & "," & _
                      wkfecha & "," & _
                      wkmodalidad & "," & _
                      wksucursal & "," & _
                      wknumerocta & "," & _
                      wkmodulo & "," & _
                      wksucursalemp & "," & _
                      wkcuenta & "," & _
                      wkmonto & "," & _
                      wkmonto & "," & _
                      wkmonedacta & "," & _
                      wkmonedaemp

            PrintLine(1, wklinea)
            wkcontador = wkcontador + 1
            wktotal = wktotal + Val(wkmonto)
        End While
        myReader.Close()
        FileClose(1)
        CerrarConexion()
        If wkcontador > 0 Then
            MessageBox.Show("Se generaron " & Trim(Str(wkcontador)) & " registros y totalizan  " & Trim(Str(wktotal)) & " guaranies.", strSLOGAN, MessageBoxButtons.OK)
        Else
            MessageBox.Show("No se generaron registro para esta fecha. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
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

    Private Sub txtARCHIVO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtARCHIVO.TextChanged

    End Sub

    Private Sub txtARCHIVO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtARCHIVO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBUSCAR.Click
        Dim txtfilename As String
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.InitialDirectory = wkdirectorio
        openFileDialog1.Filter = "Archivos (*.txt)|*.txt"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtfilename = openFileDialog1.FileName
            Me.txtARCHIVO.Text = txtfilename
        Else
            Me.txtARCHIVO.Text = ""
        End If
    End Sub

    Private Sub btnBUSCAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnBUSCAR.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmDISKETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtARCHIVO.Text = wkdirectorio & "\"
    End Sub

    Private Sub datfecha_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles datfecha.Leave
        Me.txtARCHIVO.Text = Me.txtARCHIVO.Text & "mov" & Format(Me.datfecha.Value, "dd-MM-yy") & ".txt"
    End Sub
End Class

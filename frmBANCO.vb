Public Class frmBANCO
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
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.datfecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(314, 156)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 28)
        Me.btnsalir.TabIndex = 48
        Me.btnsalir.Text = "&Salir"
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(217, 156)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(88, 29)
        Me.btnimprimir.TabIndex = 47
        Me.btnimprimir.Text = "&Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 88)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
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
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(415, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Reporte para el Banco"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBANCO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(430, 197)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBANCO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Reporte para el Banco"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim wkfecha As String
        Dim wkfechaimpre As String
        wkfecha = Format(Me.datfecha.Value, "yyyy-MM-dd")
        wkfechaimpre = Format(Me.datfecha.Value, "dd-MMMM-yyyy")
        vaciarMonto()
        AsignarMonto(wkfecha)
        actualizarBono(wkfecha)
        actualizarDescuento(wkfecha)

        Dim wkletras As String
        Try
            Dim dsIMPRESION As DataSet = New DataSet
            Dim adIMPRESION As New Odbc.OdbcDataAdapter

            wkletras = Letras(Trim(Str(sumarMONTO())))

            strSQL = "SELECT arbcedula, arbnombre, arbmonto FROM arbitro where arbmonto >= 0"

            With adIMPRESION
                .SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                .Fill(dsIMPRESION, "ARBITRO")
            End With

            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            With report
                .Load(wkdirectorio & "\crpBANCO.rpt")
                .SetDataSource(dsIMPRESION)
                .SetParameterValue(0, wkfechaimpre)
                .SetParameterValue(1, wkletras)

            End With

            Dim frmREPORT As New frmREPORTE
            With frmREPORT
                .crvimpre.ReportSource = report
                .crvimpre.SelectionFormula = "{arbitro.arbmonto} > 0 "
                .Show()
            End With
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End
        End Try
    End Sub

    Function sumarMONTO() As Double
        Dim wkfecha As String
        wkfecha = Format(Me.datfecha.Value, "yyyy-MM-dd")
        Dim wkauxmonto As Double
        AbrirConexion()
        Dim strsql As String = "SELECT sum(arbmonto) as sumatoria from arbitro where arbmonto > 0;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader


        wkauxmonto = 0
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkauxmonto = myReader.GetValue(0)
        End While
        myReader.Close()
        CerrarConexion()
        sumarMONTO = Int(wkauxmonto)
    End Function

    Private Sub datfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datfecha.ValueChanged

    End Sub

    Private Sub datfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datfecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub
End Class

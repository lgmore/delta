Public Class frmAUTOFACTURAREC
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents desdeFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents hastaFECHA As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.desdeFECHA = New System.Windows.Forms.DateTimePicker
        Me.hastaFECHA = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(10, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(439, 32)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "REPORTE DE RECIBO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.desdeFECHA)
        Me.GroupBox1.Controls.Add(Me.hastaFECHA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 101)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fecha para el Reporte"
        '
        'desdeFECHA
        '
        Me.desdeFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desdeFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.desdeFECHA.Location = New System.Drawing.Point(81, 41)
        Me.desdeFECHA.Name = "desdeFECHA"
        Me.desdeFECHA.Size = New System.Drawing.Size(133, 26)
        Me.desdeFECHA.TabIndex = 0
        '
        'hastaFECHA
        '
        Me.hastaFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hastaFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.hastaFECHA.Location = New System.Drawing.Point(292, 41)
        Me.hastaFECHA.Name = "hastaFECHA"
        Me.hastaFECHA.Size = New System.Drawing.Size(133, 26)
        Me.hastaFECHA.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Hasta :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Desde :"
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(255, 169)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(95, 25)
        Me.btnimprimir.TabIndex = 64
        Me.btnimprimir.Text = "&Imprimir"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(355, 169)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(95, 25)
        Me.btnsalir.TabIndex = 63
        Me.btnsalir.Text = "&Salir"
        '
        'frmAUTOFACTURAREC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 198)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAUTOFACTURAREC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Reporte de Recibo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim auxanho, auxmes, auxdia As Integer
        Dim auxanho1, auxmes1, auxdia1 As Integer
        Dim wkfechas As String
        Try
            auxanho = Year(Me.desdeFECHA.Value)
            auxmes = Month(Me.desdeFECHA.Value)
            auxdia = Microsoft.VisualBasic.Day(Me.desdeFECHA.Value)
            auxanho1 = Year(Me.hastaFECHA.Value)
            auxmes1 = Month(Me.hastaFECHA.Value)
            auxdia1 = Microsoft.VisualBasic.Day(Me.hastaFECHA.Value)

            wkfechas = " Desde el " & Format(Me.desdeFECHA.Value, "dd-MM-yyyy") & " hasta el " & Format(Me.hastaFECHA.Value, "dd-MM-yyyy")

            AbrirConexion()
            Dim dsIMPRESION As DataSet = New DataSet
            Dim adIMPRESION As New Odbc.OdbcDataAdapter
            Dim intindice As Integer

            strsql = "SELECT *  FROM autofactura ;"

            With adIMPRESION
                .SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
                .Fill(dsIMPRESION, "AUTOFACTURA")
            End With

            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            With report
                .Load(wkdirectorio & "\crpAUTOFACTURAREP.rpt")
                '.PrintToPrinter(1, False, 1, 100)
                .SetDataSource(dsIMPRESION)
                .SetParameterValue(0, wkfechas)
            End With

            Dim frmREPORT As New frmREPORTE
            With frmREPORT
                .crvimpre.ReportSource = report
                .crvimpre.SelectionFormula = "{autofactura.autfecha} >= Date(" & auxanho & ", " & auxmes & ", " & auxdia & ") and {autofactura.autfecha} <= Date(" & auxanho1 & ", " & auxmes1 & ", " & auxdia1 & ")"
                .Show()
            End With
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End
        End Try
    End Sub
End Class

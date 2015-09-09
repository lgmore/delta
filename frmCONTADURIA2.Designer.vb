<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDEUDASPENDIENTES2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCONTROLES = New System.Windows.Forms.GroupBox()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button()
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.dtpFECHAINICIO = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAFINAL = New System.Windows.Forms.Label()
        Me.lblFECHAINICIO = New System.Windows.Forms.Label()
        Me.lblTITULO = New System.Windows.Forms.Label()
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpCONTROLES.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCONTROLES
        '
        Me.grpCONTROLES.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grpCONTROLES.Controls.Add(Me.btnSALIR)
        Me.grpCONTROLES.Controls.Add(Me.btnGENERARREPORTE)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAFIN)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAINICIO)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAFINAL)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAINICIO)
        Me.grpCONTROLES.Location = New System.Drawing.Point(-216, -165)
        Me.grpCONTROLES.Name = "grpCONTROLES"
        Me.grpCONTROLES.Size = New System.Drawing.Size(720, 125)
        Me.grpCONTROLES.TabIndex = 7
        Me.grpCONTROLES.TabStop = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(480, 80)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(75, 32)
        Me.btnSALIR.TabIndex = 8
        Me.btnSALIR.Text = "Salir"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'btnGENERARREPORTE
        '
        Me.btnGENERARREPORTE.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGENERARREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGENERARREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(480, 24)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 7
        Me.btnGENERARREPORTE.Text = "Imprimir"
        Me.btnGENERARREPORTE.UseVisualStyleBackColor = False
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(200, 80)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.Size = New System.Drawing.Size(200, 20)
        Me.dtpFECHAFIN.TabIndex = 4
        '
        'dtpFECHAINICIO
        '
        Me.dtpFECHAINICIO.Location = New System.Drawing.Point(200, 32)
        Me.dtpFECHAINICIO.Name = "dtpFECHAINICIO"
        Me.dtpFECHAINICIO.Size = New System.Drawing.Size(200, 20)
        Me.dtpFECHAINICIO.TabIndex = 3
        '
        'lblFECHAFINAL
        '
        Me.lblFECHAFINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAFINAL.Location = New System.Drawing.Point(24, 80)
        Me.lblFECHAFINAL.Name = "lblFECHAFINAL"
        Me.lblFECHAFINAL.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAFINAL.TabIndex = 1
        Me.lblFECHAFINAL.Text = "Fecha final:"
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(24, 32)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha de inicio:"
        '
        'lblTITULO
        '
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(-216, -197)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(720, 23)
        Me.lblTITULO.TabIndex = 6
        Me.lblTITULO.Text = "INFORME PARA CONTADURIA"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpREPORTE.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpREPORTE.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crpREPORTE.Location = New System.Drawing.Point(0, 132)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.Size = New System.Drawing.Size(856, 496)
        Me.crpREPORTE.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "INFORME PARA CONTADURIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(480, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(480, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(170, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(170, 79)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha final:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de inicio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 114)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'frmDEUDASPENDIENTES2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 628)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpCONTROLES)
        Me.Controls.Add(Me.lblTITULO)
        Me.Name = "frmDEUDASPENDIENTES2"
        Me.Text = "Form1"
        Me.grpCONTROLES.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCONTROLES As System.Windows.Forms.GroupBox
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFINAL As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class

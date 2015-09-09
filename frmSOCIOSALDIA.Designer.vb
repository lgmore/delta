<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOCIOSALDIA
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
        Me.lblTITULO = New System.Windows.Forms.Label()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button()
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'lblTITULO
        '
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(0, 0)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(896, 23)
        Me.lblTITULO.TabIndex = 11
        Me.lblTITULO.Text = "LISTADO DE SOCIOS AL DIA"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(807, 37)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(80, 32)
        Me.btnSALIR.TabIndex = 10
        Me.btnSALIR.Text = "Salir"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'btnGENERARREPORTE
        '
        Me.btnGENERARREPORTE.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGENERARREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGENERARREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(721, 37)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 9
        Me.btnGENERARREPORTE.Text = "Imprimir"
        Me.btnGENERARREPORTE.UseVisualStyleBackColor = False
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpREPORTE.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpREPORTE.Location = New System.Drawing.Point(-68, 75)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.Size = New System.Drawing.Size(984, 576)
        Me.crpREPORTE.TabIndex = 12
        '
        'frmSOCIOSALDIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 636)
        Me.Controls.Add(Me.lblTITULO)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnGENERARREPORTE)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Name = "frmSOCIOSALDIA"
        Me.Text = "frmSOCIOSALDIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

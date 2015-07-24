<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDEUDASPENDIENTES
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
        Me.components = New System.ComponentModel.Container()
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvArbitros = New System.Windows.Forms.DataGridView()
        Me.ArbitroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_delta.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ArbitroTableAdapter = New proyecto_delta.DataSet1TableAdapters.arbitroTableAdapter()
        Me.colSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.arbcedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArbnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvArbitros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArbitroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpREPORTE.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpREPORTE.Location = New System.Drawing.Point(12, 162)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.Size = New System.Drawing.Size(824, 481)
        Me.crpREPORTE.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "INFORME DE DEUDAS PENDIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.dgvArbitros)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 125)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgvArbitros
        '
        Me.dgvArbitros.AutoGenerateColumns = False
        Me.dgvArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArbitros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionado, Me.arbcedula, Me.ArbnombreDataGridViewTextBoxColumn})
        Me.dgvArbitros.DataSource = Me.ArbitroBindingSource
        Me.dgvArbitros.Location = New System.Drawing.Point(198, 19)
        Me.dgvArbitros.Name = "dgvArbitros"
        Me.dgvArbitros.Size = New System.Drawing.Size(424, 100)
        Me.dgvArbitros.TabIndex = 9
        '
        'ArbitroBindingSource
        '
        Me.ArbitroBindingSource.DataMember = "arbitro"
        Me.ArbitroBindingSource.DataSource = Me.DataSet1
        Me.ArbitroBindingSource.Sort = "arbnombre"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(628, 77)
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
        Me.Button2.Location = New System.Drawing.Point(628, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 50)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccione uno o varios arbitros:"
        '
        'ArbitroTableAdapter
        '
        Me.ArbitroTableAdapter.ClearBeforeFill = True
        '
        'colSeleccionado
        '
        Me.colSeleccionado.HeaderText = "Sel"
        Me.colSeleccionado.Name = "colSeleccionado"
        Me.colSeleccionado.Width = 50
        '
        'arbcedula
        '
        Me.arbcedula.DataPropertyName = "arbcedula"
        Me.arbcedula.HeaderText = "arbcedula"
        Me.arbcedula.Name = "arbcedula"
        '
        'ArbnombreDataGridViewTextBoxColumn
        '
        Me.ArbnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ArbnombreDataGridViewTextBoxColumn.DataPropertyName = "arbnombre"
        Me.ArbnombreDataGridViewTextBoxColumn.HeaderText = "arbnombre"
        Me.ArbnombreDataGridViewTextBoxColumn.Name = "ArbnombreDataGridViewTextBoxColumn"
        Me.ArbnombreDataGridViewTextBoxColumn.Width = 21
        '
        'frmDEUDASPENDIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 628)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Name = "frmDEUDASPENDIENTES"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvArbitros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArbitroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvArbitros As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As proyecto_delta.DataSet1
    Friend WithEvents ArbitroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArbitroTableAdapter As proyecto_delta.DataSet1TableAdapters.arbitroTableAdapter
    Friend WithEvents colSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents arbcedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArbnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

Public Class frmCODIGOS
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
    Friend WithEvents TabcCODIGOS As System.Windows.Forms.TabControl
    Friend WithEvents tabpBECAS As System.Windows.Forms.TabPage
    Friend WithEvents grpDATOSINDIVIDUALES As System.Windows.Forms.GroupBox
    Friend WithEvents lblCODIGO As System.Windows.Forms.Label
    Friend WithEvents lblDESCRIPCION As System.Windows.Forms.Label
    Friend WithEvents lblINICIOBECA As System.Windows.Forms.Label
    Friend WithEvents lblFECHAFINBECA As System.Windows.Forms.Label
    Friend WithEvents lblOBSERVACIONES As System.Windows.Forms.Label
    Friend WithEvents txtCODIGO As System.Windows.Forms.TextBox
    Friend WithEvents txtDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents txtOBSERVACION As System.Windows.Forms.TextBox
    Friend WithEvents dtpFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabcCODIGOS = New System.Windows.Forms.TabControl
        Me.tabpBECAS = New System.Windows.Forms.TabPage
        Me.grpDATOSINDIVIDUALES = New System.Windows.Forms.GroupBox
        Me.txtOBSERVACION = New System.Windows.Forms.TextBox
        Me.txtDESCRIPCION = New System.Windows.Forms.TextBox
        Me.txtCODIGO = New System.Windows.Forms.TextBox
        Me.lblOBSERVACIONES = New System.Windows.Forms.Label
        Me.lblFECHAFINBECA = New System.Windows.Forms.Label
        Me.lblINICIOBECA = New System.Windows.Forms.Label
        Me.lblDESCRIPCION = New System.Windows.Forms.Label
        Me.lblCODIGO = New System.Windows.Forms.Label
        Me.dtpFECHAINICIO = New System.Windows.Forms.DateTimePicker
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker
        Me.TabcCODIGOS.SuspendLayout()
        Me.tabpBECAS.SuspendLayout()
        Me.grpDATOSINDIVIDUALES.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabcCODIGOS
        '
        Me.TabcCODIGOS.Controls.Add(Me.tabpBECAS)
        Me.TabcCODIGOS.Location = New System.Drawing.Point(0, 40)
        Me.TabcCODIGOS.Name = "TabcCODIGOS"
        Me.TabcCODIGOS.SelectedIndex = 0
        Me.TabcCODIGOS.Size = New System.Drawing.Size(1016, 544)
        Me.TabcCODIGOS.TabIndex = 0
        '
        'tabpBECAS
        '
        Me.tabpBECAS.Controls.Add(Me.grpDATOSINDIVIDUALES)
        Me.tabpBECAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpBECAS.Location = New System.Drawing.Point(4, 22)
        Me.tabpBECAS.Name = "tabpBECAS"
        Me.tabpBECAS.Size = New System.Drawing.Size(1008, 518)
        Me.tabpBECAS.TabIndex = 0
        Me.tabpBECAS.Text = "Becas"
        '
        'grpDATOSINDIVIDUALES
        '
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.dtpFECHAFIN)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.dtpFECHAINICIO)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.txtOBSERVACION)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.txtDESCRIPCION)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.txtCODIGO)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.lblOBSERVACIONES)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.lblFECHAFINBECA)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.lblINICIOBECA)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.lblDESCRIPCION)
        Me.grpDATOSINDIVIDUALES.Controls.Add(Me.lblCODIGO)
        Me.grpDATOSINDIVIDUALES.Location = New System.Drawing.Point(8, 16)
        Me.grpDATOSINDIVIDUALES.Name = "grpDATOSINDIVIDUALES"
        Me.grpDATOSINDIVIDUALES.Size = New System.Drawing.Size(992, 216)
        Me.grpDATOSINDIVIDUALES.TabIndex = 0
        Me.grpDATOSINDIVIDUALES.TabStop = False
        Me.grpDATOSINDIVIDUALES.Text = "Datos Individuales"
        '
        'txtOBSERVACION
        '
        Me.txtOBSERVACION.Location = New System.Drawing.Point(184, 136)
        Me.txtOBSERVACION.MaxLength = 600
        Me.txtOBSERVACION.Name = "txtOBSERVACION"
        Me.txtOBSERVACION.Size = New System.Drawing.Size(456, 22)
        Me.txtOBSERVACION.TabIndex = 7
        Me.txtOBSERVACION.Text = ""
        '
        'txtDESCRIPCION
        '
        Me.txtDESCRIPCION.Location = New System.Drawing.Point(184, 72)
        Me.txtDESCRIPCION.MaxLength = 400
        Me.txtDESCRIPCION.Name = "txtDESCRIPCION"
        Me.txtDESCRIPCION.Size = New System.Drawing.Size(456, 22)
        Me.txtDESCRIPCION.TabIndex = 6
        Me.txtDESCRIPCION.Text = ""
        '
        'txtCODIGO
        '
        Me.txtCODIGO.Location = New System.Drawing.Point(184, 40)
        Me.txtCODIGO.MaxLength = 4
        Me.txtCODIGO.Name = "txtCODIGO"
        Me.txtCODIGO.Size = New System.Drawing.Size(120, 22)
        Me.txtCODIGO.TabIndex = 5
        Me.txtCODIGO.Text = ""
        '
        'lblOBSERVACIONES
        '
        Me.lblOBSERVACIONES.Location = New System.Drawing.Point(16, 136)
        Me.lblOBSERVACIONES.Name = "lblOBSERVACIONES"
        Me.lblOBSERVACIONES.Size = New System.Drawing.Size(160, 23)
        Me.lblOBSERVACIONES.TabIndex = 4
        Me.lblOBSERVACIONES.Text = "Observaciones: (600) "
        Me.lblOBSERVACIONES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFECHAFINBECA
        '
        Me.lblFECHAFINBECA.Location = New System.Drawing.Point(480, 104)
        Me.lblFECHAFINBECA.Name = "lblFECHAFINBECA"
        Me.lblFECHAFINBECA.Size = New System.Drawing.Size(160, 23)
        Me.lblFECHAFINBECA.TabIndex = 3
        Me.lblFECHAFINBECA.Text = "Fecha de fin de beca: "
        Me.lblFECHAFINBECA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblINICIOBECA
        '
        Me.lblINICIOBECA.Location = New System.Drawing.Point(16, 104)
        Me.lblINICIOBECA.Name = "lblINICIOBECA"
        Me.lblINICIOBECA.Size = New System.Drawing.Size(160, 23)
        Me.lblINICIOBECA.TabIndex = 2
        Me.lblINICIOBECA.Text = "Fecha de inicio de beca: "
        Me.lblINICIOBECA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDESCRIPCION
        '
        Me.lblDESCRIPCION.Location = New System.Drawing.Point(16, 72)
        Me.lblDESCRIPCION.Name = "lblDESCRIPCION"
        Me.lblDESCRIPCION.Size = New System.Drawing.Size(152, 23)
        Me.lblDESCRIPCION.TabIndex = 1
        Me.lblDESCRIPCION.Text = "Descripción: (400) "
        Me.lblDESCRIPCION.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGO
        '
        Me.lblCODIGO.Location = New System.Drawing.Point(16, 40)
        Me.lblCODIGO.Name = "lblCODIGO"
        Me.lblCODIGO.Size = New System.Drawing.Size(152, 23)
        Me.lblCODIGO.TabIndex = 0
        Me.lblCODIGO.Text = "Código: (4) "
        Me.lblCODIGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFECHAINICIO
        '
        Me.dtpFECHAINICIO.Location = New System.Drawing.Point(184, 104)
        Me.dtpFECHAINICIO.Name = "dtpFECHAINICIO"
        Me.dtpFECHAINICIO.Size = New System.Drawing.Size(280, 22)
        Me.dtpFECHAINICIO.TabIndex = 8
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(656, 104)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.Size = New System.Drawing.Size(280, 22)
        Me.dtpFECHAFIN.TabIndex = 9
        '
        'frmCODIGOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 578)
        Me.Controls.Add(Me.TabcCODIGOS)
        Me.Name = "frmCODIGOS"
        Me.Text = "Códigos del sistema - Sistema Delta"
        Me.TabcCODIGOS.ResumeLayout(False)
        Me.tabpBECAS.ResumeLayout(False)
        Me.grpDATOSINDIVIDUALES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class

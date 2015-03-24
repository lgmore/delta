Public Class frmUSUARIOS
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
    Friend WithEvents btnAGREGAR As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents btnBORRAR As System.Windows.Forms.Button
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    Friend WithEvents dtaLISTAUSUARIOS As System.Windows.Forms.DataGrid
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblFechaActual As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUSUARIOS))
        Me.btnAGREGAR = New System.Windows.Forms.Button
        Me.btnMODIFICAR = New System.Windows.Forms.Button
        Me.btnBORRAR = New System.Windows.Forms.Button
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.lblTITULO = New System.Windows.Forms.Label
        Me.dtaLISTAUSUARIOS = New System.Windows.Forms.DataGrid
        Me.lblFechaActual = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnIMPRIMIR = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dtaLISTAUSUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.BackColor = System.Drawing.Color.Silver
        Me.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAGREGAR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.Color.Black
        Me.btnAGREGAR.Location = New System.Drawing.Point(144, 24)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(96, 24)
        Me.btnAGREGAR.TabIndex = 0
        Me.btnAGREGAR.Text = "&Agregar"
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnMODIFICAR.BackColor = System.Drawing.Color.Silver
        Me.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.ForeColor = System.Drawing.Color.Black
        Me.btnMODIFICAR.Location = New System.Drawing.Point(248, 24)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(96, 24)
        Me.btnMODIFICAR.TabIndex = 1
        Me.btnMODIFICAR.Text = "&Modificar"
        '
        'btnBORRAR
        '
        Me.btnBORRAR.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnBORRAR.BackColor = System.Drawing.Color.Silver
        Me.btnBORRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBORRAR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBORRAR.ForeColor = System.Drawing.Color.Black
        Me.btnBORRAR.Location = New System.Drawing.Point(352, 24)
        Me.btnBORRAR.Name = "btnBORRAR"
        Me.btnBORRAR.Size = New System.Drawing.Size(96, 24)
        Me.btnBORRAR.TabIndex = 2
        Me.btnBORRAR.Text = "&Borrar"
        '
        'btnSALIR
        '
        Me.btnSALIR.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnSALIR.BackColor = System.Drawing.Color.Silver
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSALIR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.Black
        Me.btnSALIR.Location = New System.Drawing.Point(560, 24)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(96, 24)
        Me.btnSALIR.TabIndex = 4
        Me.btnSALIR.Text = "&Salir"
        '
        'lblTITULO
        '
        Me.lblTITULO.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTITULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTITULO.Location = New System.Drawing.Point(232, 16)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(448, 48)
        Me.lblTITULO.TabIndex = 5
        Me.lblTITULO.Text = "ADMINISTRACION DE DATOS DEL USUARIO"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtaLISTAUSUARIOS
        '
        Me.dtaLISTAUSUARIOS.CaptionBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dtaLISTAUSUARIOS.DataMember = ""
        Me.dtaLISTAUSUARIOS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaLISTAUSUARIOS.LinkColor = System.Drawing.Color.Red
        Me.dtaLISTAUSUARIOS.Location = New System.Drawing.Point(16, 144)
        Me.dtaLISTAUSUARIOS.Name = "dtaLISTAUSUARIOS"
        Me.dtaLISTAUSUARIOS.ReadOnly = True
        Me.dtaLISTAUSUARIOS.Size = New System.Drawing.Size(672, 216)
        Me.dtaLISTAUSUARIOS.TabIndex = 8
        '
        'lblFechaActual
        '
        Me.lblFechaActual.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblFechaActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaActual.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblFechaActual.Location = New System.Drawing.Point(3, 16)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(266, 45)
        Me.lblFechaActual.TabIndex = 9
        Me.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFechaActual)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(416, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 64)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.btnBORRAR)
        Me.GroupBox2.Controls.Add(Me.btnSALIR)
        Me.GroupBox2.Controls.Add(Me.btnAGREGAR)
        Me.GroupBox2.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.btnIMPRIMIR)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(16, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'btnIMPRIMIR
        '
        Me.btnIMPRIMIR.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnIMPRIMIR.BackColor = System.Drawing.Color.Silver
        Me.btnIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIMPRIMIR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIMPRIMIR.ForeColor = System.Drawing.Color.Black
        Me.btnIMPRIMIR.Location = New System.Drawing.Point(456, 24)
        Me.btnIMPRIMIR.Name = "btnIMPRIMIR"
        Me.btnIMPRIMIR.Size = New System.Drawing.Size(96, 24)
        Me.btnIMPRIMIR.TabIndex = 14
        Me.btnIMPRIMIR.Text = "&Imprimir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 112)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmUSUARIOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(696, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtaLISTAUSUARIOS)
        Me.Controls.Add(Me.lblTITULO)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUSUARIOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRACION DE USUARIOS DEL SISTEMA ""DELTA"""
        CType(Me.dtaLISTAUSUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICAR.Click
        'If (lstOPCIONES.SelectedItem = "usuario") Then


        Dim filaGrillaActual As Integer
        Dim modificacion As New frmUSUARIOSCRUD
        modificacion.btnAGREGAR.Enabled = False
        modificacion.intUSUCODIGO.Enabled = False
        modificacion.btnELIMINAR.Enabled = False

        filaGrillaActual = dtaLISTAUSUARIOS.CurrentCell.RowNumber

        Try

            wkUSUCODIGO = dtaLISTAUSUARIOS.Item(filaGrillaActual, 0)
            wkUSUUSUARIO = dtaLISTAUSUARIOS.Item(filaGrillaActual, 1)
            wkUSUNOMBRE = dtaLISTAUSUARIOS.Item(filaGrillaActual, 2)
            wkUSUPASSWORD = dtaLISTAUSUARIOS.Item(filaGrillaActual, 3)

            modificacion.intUSUCODIGO.Text = wkUSUCODIGO.ToString
            modificacion.txtUSUUSUARIO.Text = wkUSUUSUARIO
            modificacion.txtUSUNOMBRE.Text = wkUSUNOMBRE
            modificacion.txtUSUPASSWORD.Text = wkUSUPASSWORD

            modificacion.Show()

        Catch ex As Exception
            modificacion.Close()
            modificacion.Dispose()
        End Try


    End Sub

    Private Sub setEstiloGrilla(ByVal tipoGrilla As String)
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        If (String.Equals(tipoGrilla, "usuario") = True) Then
            estilos.MappingName = dsDATOS.Tables("usuario").TableName
        End If

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn

        If (String.Equals(tipoGrilla, "usuario") = True) Then
            With estilo1
                .MappingName = "usuCODIGO"
                .HeaderText = " CODIGO "
                .Width = 100
            End With

            With estilo2
                .MappingName = "usuUSUARIO"
                .HeaderText = " USUARIO "
                .Width = 150
            End With

            With estilo3
                .MappingName = "usuNOMBRE"
                .HeaderText = " NOMBRE Y APELLIDO "
                .Width = 370
            End With

            With estilo4
                .MappingName = "usuPASSWORD"
                .HeaderText = " PASSWORD "
                .Width = 0

            End With

            estilos.GridColumnStyles.Clear()
            estilos.GridColumnStyles.Add(estilo1)
            estilos.GridColumnStyles.Add(estilo2)
            estilos.GridColumnStyles.Add(estilo3)
            estilos.GridColumnStyles.Add(estilo4)
            Me.dtaLISTAUSUARIOS.TableStyles.Clear()
            Me.dtaLISTAUSUARIOS.TableStyles.Add(estilos)
        End If
    End Sub

    Private Sub cargarGrillaUsuarios()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM usuario WHERE usuNOMBRE like '%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "usuario")

        dataviewLOCAL = New DataView(dsDATOS.Tables("usuario"), "usuNOMBRE LIKE '%'", "usuCODIGO DESC", DataViewRowState.OriginalRows)
        Me.dtaLISTAUSUARIOS.DataSource = dataviewLOCAL
        Me.dtaLISTAUSUARIOS.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub btnAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGAR.Click

        'If (lstOPCIONES.SelectedItem = "usuario") Then

        Dim frmNUEVOUSUARIO As New frmUSUARIOSCRUD
        frmNUEVOUSUARIO.btnMODIFICAR.Enabled = False
        frmNUEVOUSUARIO.btnELIMINAR.Enabled = False
        frmNUEVOUSUARIO.Show()

        'End If

    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
    End Sub

    Private Sub btnBORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBORRAR.Click
        Dim frmnew As New frmUSUARIOSCRUD
        Dim filaGrillaActual As Integer
        filaGrillaActual = dtaLISTAUSUARIOS.CurrentCell.RowNumber
        Dim opcionActual As String = "usuario"
        frmnew.intUSUCODIGO.Text = dtaLISTAUSUARIOS.Item(filaGrillaActual, 0)
        frmnew.txtUSUUSUARIO.Text = dtaLISTAUSUARIOS.Item(filaGrillaActual, 1)
        frmnew.txtUSUNOMBRE.Text = dtaLISTAUSUARIOS.Item(filaGrillaActual, 2)

        frmnew.btnMODIFICAR.Enabled = False
        frmnew.btnAGREGAR.Enabled = False
        frmnew.txtUSUPASSWORD.Enabled = False

        frmnew.Show()

    End Sub

    Private Sub frmUSUARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        cargarGrillaUsuarios()
        setEstiloGrilla("usuario")
        CerrarConexion()
        Timer1.Interval = 500
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblFechaActual.Text = Date.Now.ToString
        If ACTUALIZARDATAGRID = True Then
            AbrirConexion()
            cargarGrillaUsuarios()
            setEstiloGrilla("usuario")
            CerrarConexion()
            ACTUALIZARDATAGRID = False
        End If

    End Sub

    Private Sub btnIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIMPRIMIR.Click
        'Dim frmNEW As New frmREPORTES
        'With frmNEW
        '    .crvIMPRESION.ReportSource = wkdirectorio & "\crpUSUARIOS.rpt"
        '    .crvIMPRESION.Zoom(100)
        '    .Show()
        'End With
    End Sub

   
    Private Sub dtaLISTAUSUARIOS_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaLISTAUSUARIOS.Navigate

    End Sub

    Private Sub dtaLISTAUSUARIOS_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaLISTAUSUARIOS.CurrentCellChanged
        wkusuusuario = Me.dtaLISTAUSUARIOS.Item(Me.dtaLISTAUSUARIOS.CurrentRowIndex, 2)
    End Sub
End Class

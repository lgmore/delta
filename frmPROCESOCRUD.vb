Imports proyecto_delta.DataSet1TableAdapters

Public Class frmPROCESOCRUD
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents grdARBITRO As System.Windows.Forms.DataGrid
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCONSULTAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents tabBONO As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFECHA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtGRUPO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMONTO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnELIMINAR As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnCANCELAR As System.Windows.Forms.Button
    Friend WithEvents btnGUARDAR As System.Windows.Forms.Button
    Friend WithEvents tabDESCUENTO As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMODIFICARDESC As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARDEC As System.Windows.Forms.Button
    Friend WithEvents btnCANCELARDESC As System.Windows.Forms.Button
    Friend WithEvents btnSALIRDESC As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARDESC As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents grdMOVIMIENTO As System.Windows.Forms.DataGrid
    Friend WithEvents CONCEPTO As System.Windows.Forms.ComboBox
    Friend WithEvents EQUIPO1 As System.Windows.Forms.ComboBox
    Friend WithEvents EQUIPO2 As System.Windows.Forms.ComboBox
    Friend WithEvents ESTADIO As System.Windows.Forms.ComboBox
    Friend WithEvents TabMOVIMIENTO As System.Windows.Forms.TabControl
    Friend WithEvents txtANHO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBSERVABONO As System.Windows.Forms.RichTextBox
    Friend WithEvents chkBONO As System.Windows.Forms.CheckBox
    Friend WithEvents chkDESCUENTO As System.Windows.Forms.CheckBox
    Friend WithEvents txtMESCON As System.Windows.Forms.TextBox
    Friend WithEvents txtANHOCON As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DIVISION As System.Windows.Forms.ComboBox
    Friend WithEvents tabDeudaPendiente As System.Windows.Forms.TabPage
    Friend WithEvents dgvListaArbitros As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As proyecto_delta.DataSet1
    Friend WithEvents ArbitroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArbitroTableAdapter As proyecto_delta.DataSet1TableAdapters.arbitroTableAdapter
    Friend WithEvents ArbcedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArbnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArbsituacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSet11 As proyecto_delta.DataSet1
    Friend WithEvents ArbitroTableAdapter1 As proyecto_delta.DataSet1TableAdapters.arbitroTableAdapter
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvListaConceptos As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet2 As proyecto_delta.DataSet2
    Friend WithEvents ConceptoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConceptoTableAdapter As proyecto_delta.DataSet2TableAdapters.conceptoTableAdapter
    Friend WithEvents btnAsignarDeudas As System.Windows.Forms.Button
    Friend WithEvents colSeleccionadoDeuda As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents concodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents connombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conmonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCUOTA As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDOCUMENTODESC As System.Windows.Forms.Label
    Friend WithEvents txtMONTODESC As System.Windows.Forms.TextBox
    Friend WithEvents txtDOCUMENTODESC As System.Windows.Forms.TextBox
    Friend WithEvents lblCONCEPTODESC As System.Windows.Forms.Label
    Friend WithEvents lblFECHA2DESC As System.Windows.Forms.Label
    Friend WithEvents datFECHADOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents CONCEPTODESC As System.Windows.Forms.ComboBox
    Friend WithEvents lblFECHA1DESC As System.Windows.Forms.Label
    Friend WithEvents lblMONTODESC As System.Windows.Forms.Label
    Friend WithEvents txtNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents datFECHADESC As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNUMERODESC As System.Windows.Forms.Label
    Friend WithEvents txtOBSERVADESC As System.Windows.Forms.RichTextBox
    'Friend WithEvents DataSet4 As proyecto_delta.DataSet4
    Friend WithEvents DeudaapagarBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents Deuda_apagarTableAdapter As proyecto_delta.DataSet4TableAdapters.deuda_apagarTableAdapter
    Friend WithEvents DataSet11BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeudasApagarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tabDescontarPendiente As System.Windows.Forms.TabPage
    Friend WithEvents grdDeudaApagar As System.Windows.Forms.DataGridView
    Friend WithEvents btnDescontarPendientes As System.Windows.Forms.Button
    Friend WithEvents DataSet12BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet12 As proyecto_delta.DataSet1
    Friend WithEvents DeudasApagarBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet13 As proyecto_delta.DataSet1
    Friend WithEvents DeudasApagarTableAdapter As proyecto_delta.DataSet1TableAdapters.DeudasApagarTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoapagarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaalta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aimputar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idfila As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idconcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeleccionadoArbitro As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents arbcedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arbnombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arbsituacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTORNEO As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grdARBITRO = New System.Windows.Forms.DataGrid()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCONSULTAR = New System.Windows.Forms.Button()
        Me.txtMESCON = New System.Windows.Forms.TextBox()
        Me.txtANHOCON = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkDESCUENTO = New System.Windows.Forms.CheckBox()
        Me.chkBONO = New System.Windows.Forms.CheckBox()
        Me.grdMOVIMIENTO = New System.Windows.Forms.DataGrid()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMODIFICARDESC = New System.Windows.Forms.Button()
        Me.btnELIMINARDEC = New System.Windows.Forms.Button()
        Me.btnCANCELARDESC = New System.Windows.Forms.Button()
        Me.btnSALIRDESC = New System.Windows.Forms.Button()
        Me.btnAGREGARDESC = New System.Windows.Forms.Button()
        Me.TabMOVIMIENTO = New System.Windows.Forms.TabControl()
        Me.tabBONO = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTORNEO = New System.Windows.Forms.ComboBox()
        Me.DIVISION = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFECHA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ESTADIO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGRUPO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMONTO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datFECHA = New System.Windows.Forms.DateTimePicker()
        Me.EQUIPO1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONCEPTO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtANHO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOBSERVABONO = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EQUIPO2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnCANCELAR = New System.Windows.Forms.Button()
        Me.btnGUARDAR = New System.Windows.Forms.Button()
        Me.tabDESCUENTO = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCUOTA = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDOCUMENTODESC = New System.Windows.Forms.Label()
        Me.txtMONTODESC = New System.Windows.Forms.TextBox()
        Me.txtDOCUMENTODESC = New System.Windows.Forms.TextBox()
        Me.lblCONCEPTODESC = New System.Windows.Forms.Label()
        Me.lblFECHA2DESC = New System.Windows.Forms.Label()
        Me.datFECHADOC = New System.Windows.Forms.DateTimePicker()
        Me.CONCEPTODESC = New System.Windows.Forms.ComboBox()
        Me.lblFECHA1DESC = New System.Windows.Forms.Label()
        Me.lblMONTODESC = New System.Windows.Forms.Label()
        Me.txtNUMERODOC = New System.Windows.Forms.TextBox()
        Me.datFECHADESC = New System.Windows.Forms.DateTimePicker()
        Me.lblNUMERODESC = New System.Windows.Forms.Label()
        Me.txtOBSERVADESC = New System.Windows.Forms.RichTextBox()
        Me.tabDeudaPendiente = New System.Windows.Forms.TabPage()
        Me.btnAsignarDeudas = New System.Windows.Forms.Button()
        Me.dgvListaConceptos = New System.Windows.Forms.DataGridView()
        Me.colSeleccionadoDeuda = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.concodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.connombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conmonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New proyecto_delta.DataSet2()
        Me.dgvListaArbitros = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbitroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New proyecto_delta.DataSet1()
        Me.tabDescontarPendiente = New System.Windows.Forms.TabPage()
        Me.btnDescontarPendientes = New System.Windows.Forms.Button()
        Me.grdDeudaApagar = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoapagarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aimputar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idfila = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idconcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeudasApagarBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet13 = New proyecto_delta.DataSet1()
        Me.DeudasApagarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ArbitroTableAdapter1 = New proyecto_delta.DataSet1TableAdapters.arbitroTableAdapter()
        Me.ConceptoTableAdapter = New proyecto_delta.DataSet2TableAdapters.conceptoTableAdapter()
        Me.DataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet12 = New proyecto_delta.DataSet1()
        Me.DataSet12BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeudasApagarTableAdapter = New proyecto_delta.DataSet1TableAdapters.DeudasApagarTableAdapter()
        Me.colSeleccionadoArbitro = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.arbcedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arbnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arbsituacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdARBITRO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.grdMOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabMOVIMIENTO.SuspendLayout()
        Me.tabBONO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabDESCUENTO.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabDeudaPendiente.SuspendLayout()
        CType(Me.dgvListaConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConceptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaArbitros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ArbitroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDescontarPendiente.SuspendLayout()
        CType(Me.grdDeudaApagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudasApagarBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudasApagarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet12BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtbusqueda)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.grdARBITRO)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 136)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PANEL DE BUSQUEDA"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(79, 19)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(284, 22)
        Me.txtbusqueda.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(15, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Buscar"
        '
        'grdARBITRO
        '
        Me.grdARBITRO.CaptionVisible = False
        Me.grdARBITRO.DataMember = ""
        Me.grdARBITRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdARBITRO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdARBITRO.Location = New System.Drawing.Point(9, 45)
        Me.grdARBITRO.Name = "grdARBITRO"
        Me.grdARBITRO.ReadOnly = True
        Me.grdARBITRO.Size = New System.Drawing.Size(358, 75)
        Me.grdARBITRO.TabIndex = 12
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.btnCONSULTAR)
        Me.GroupBox6.Controls.Add(Me.txtMESCON)
        Me.GroupBox6.Controls.Add(Me.txtANHOCON)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.chkDESCUENTO)
        Me.GroupBox6.Controls.Add(Me.chkBONO)
        Me.GroupBox6.Controls.Add(Me.grdMOVIMIENTO)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(392, 56)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(536, 136)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "MOVIMIENTOS"
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(360, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 21)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Mes"
        '
        'btnCONSULTAR
        '
        Me.btnCONSULTAR.Location = New System.Drawing.Point(450, 18)
        Me.btnCONSULTAR.Name = "btnCONSULTAR"
        Me.btnCONSULTAR.Size = New System.Drawing.Size(32, 22)
        Me.btnCONSULTAR.TabIndex = 19
        Me.btnCONSULTAR.Text = "..."
        '
        'txtMESCON
        '
        Me.txtMESCON.Location = New System.Drawing.Point(405, 18)
        Me.txtMESCON.MaxLength = 3
        Me.txtMESCON.Name = "txtMESCON"
        Me.txtMESCON.Size = New System.Drawing.Size(33, 22)
        Me.txtMESCON.TabIndex = 17
        '
        'txtANHOCON
        '
        Me.txtANHOCON.Location = New System.Drawing.Point(310, 18)
        Me.txtANHOCON.MaxLength = 4
        Me.txtANHOCON.Name = "txtANHOCON"
        Me.txtANHOCON.Size = New System.Drawing.Size(42, 22)
        Me.txtANHOCON.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(261, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Año"
        '
        'chkDESCUENTO
        '
        Me.chkDESCUENTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkDESCUENTO.Location = New System.Drawing.Point(121, 23)
        Me.chkDESCUENTO.Name = "chkDESCUENTO"
        Me.chkDESCUENTO.Size = New System.Drawing.Size(131, 19)
        Me.chkDESCUENTO.TabIndex = 14
        Me.chkDESCUENTO.Text = "Sólo Descuentos"
        '
        'chkBONO
        '
        Me.chkBONO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkBONO.Location = New System.Drawing.Point(15, 22)
        Me.chkBONO.Name = "chkBONO"
        Me.chkBONO.Size = New System.Drawing.Size(96, 18)
        Me.chkBONO.TabIndex = 13
        Me.chkBONO.Text = "Sólo Bonos"
        '
        'grdMOVIMIENTO
        '
        Me.grdMOVIMIENTO.CaptionVisible = False
        Me.grdMOVIMIENTO.DataMember = ""
        Me.grdMOVIMIENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdMOVIMIENTO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdMOVIMIENTO.Location = New System.Drawing.Point(9, 46)
        Me.grdMOVIMIENTO.Name = "grdMOVIMIENTO"
        Me.grdMOVIMIENTO.ReadOnly = True
        Me.grdMOVIMIENTO.Size = New System.Drawing.Size(514, 75)
        Me.grdMOVIMIENTO.TabIndex = 12
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.TabMOVIMIENTO)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(920, 360)
        Me.GroupBox7.TabIndex = 41
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "CARGA DEMOVIMIENTOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnMODIFICARDESC)
        Me.GroupBox3.Controls.Add(Me.btnELIMINARDEC)
        Me.GroupBox3.Controls.Add(Me.btnCANCELARDESC)
        Me.GroupBox3.Controls.Add(Me.btnSALIRDESC)
        Me.GroupBox3.Controls.Add(Me.btnAGREGARDESC)
        Me.GroupBox3.Location = New System.Drawing.Point(779, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 272)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'btnMODIFICARDESC
        '
        Me.btnMODIFICARDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARDESC.Location = New System.Drawing.Point(7, 159)
        Me.btnMODIFICARDESC.Name = "btnMODIFICARDESC"
        Me.btnMODIFICARDESC.Size = New System.Drawing.Size(113, 32)
        Me.btnMODIFICARDESC.TabIndex = 59
        Me.btnMODIFICARDESC.Text = "MODIFICAR "
        Me.btnMODIFICARDESC.Visible = False
        '
        'btnELIMINARDEC
        '
        Me.btnELIMINARDEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARDEC.Location = New System.Drawing.Point(6, 47)
        Me.btnELIMINARDEC.Name = "btnELIMINARDEC"
        Me.btnELIMINARDEC.Size = New System.Drawing.Size(113, 32)
        Me.btnELIMINARDEC.TabIndex = 56
        Me.btnELIMINARDEC.Text = "&ELIMINAR "
        '
        'btnCANCELARDESC
        '
        Me.btnCANCELARDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARDESC.Location = New System.Drawing.Point(7, 85)
        Me.btnCANCELARDESC.Name = "btnCANCELARDESC"
        Me.btnCANCELARDESC.Size = New System.Drawing.Size(113, 32)
        Me.btnCANCELARDESC.TabIndex = 57
        Me.btnCANCELARDESC.Text = "&CANCELAR "
        '
        'btnSALIRDESC
        '
        Me.btnSALIRDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIRDESC.Location = New System.Drawing.Point(8, 123)
        Me.btnSALIRDESC.Name = "btnSALIRDESC"
        Me.btnSALIRDESC.Size = New System.Drawing.Size(113, 32)
        Me.btnSALIRDESC.TabIndex = 58
        Me.btnSALIRDESC.Text = "&SALIR "
        '
        'btnAGREGARDESC
        '
        Me.btnAGREGARDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARDESC.Location = New System.Drawing.Point(6, 9)
        Me.btnAGREGARDESC.Name = "btnAGREGARDESC"
        Me.btnAGREGARDESC.Size = New System.Drawing.Size(113, 32)
        Me.btnAGREGARDESC.TabIndex = 55
        Me.btnAGREGARDESC.Text = "&GRABAR "
        '
        'TabMOVIMIENTO
        '
        Me.TabMOVIMIENTO.Controls.Add(Me.tabBONO)
        Me.TabMOVIMIENTO.Controls.Add(Me.tabDESCUENTO)
        Me.TabMOVIMIENTO.Controls.Add(Me.tabDeudaPendiente)
        Me.TabMOVIMIENTO.Controls.Add(Me.tabDescontarPendiente)
        Me.TabMOVIMIENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMOVIMIENTO.Location = New System.Drawing.Point(8, 24)
        Me.TabMOVIMIENTO.Name = "TabMOVIMIENTO"
        Me.TabMOVIMIENTO.SelectedIndex = 0
        Me.TabMOVIMIENTO.Size = New System.Drawing.Size(744, 320)
        Me.TabMOVIMIENTO.TabIndex = 38
        '
        'tabBONO
        '
        Me.tabBONO.Controls.Add(Me.Label13)
        Me.tabBONO.Controls.Add(Me.GroupBox1)
        Me.tabBONO.Controls.Add(Me.GroupBox2)
        Me.tabBONO.Location = New System.Drawing.Point(4, 25)
        Me.tabBONO.Name = "tabBONO"
        Me.tabBONO.Size = New System.Drawing.Size(736, 291)
        Me.tabBONO.TabIndex = 0
        Me.tabBONO.Text = "BONO"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(706, 32)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "CARGA DE BONOS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.txtTORNEO)
        Me.GroupBox1.Controls.Add(Me.DIVISION)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtFECHA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ESTADIO)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtGRUPO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMONTO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.datFECHA)
        Me.GroupBox1.Controls.Add(Me.EQUIPO1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CONCEPTO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtANHO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOBSERVABONO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.EQUIPO2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 219)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'txtTORNEO
        '
        Me.txtTORNEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTORNEO.Items.AddRange(New Object() {"APERTURA", "CLAUSURA"})
        Me.txtTORNEO.Location = New System.Drawing.Point(524, 69)
        Me.txtTORNEO.Name = "txtTORNEO"
        Me.txtTORNEO.Size = New System.Drawing.Size(121, 24)
        Me.txtTORNEO.TabIndex = 19
        '
        'DIVISION
        '
        Me.DIVISION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVISION.Location = New System.Drawing.Point(128, 19)
        Me.DIVISION.Name = "DIVISION"
        Me.DIVISION.Size = New System.Drawing.Size(236, 24)
        Me.DIVISION.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Silver
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(19, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 23)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "DIVISION"
        '
        'txtFECHA
        '
        Me.txtFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFECHA.Location = New System.Drawing.Point(523, 94)
        Me.txtFECHA.MaxLength = 2
        Me.txtFECHA.Name = "txtFECHA"
        Me.txtFECHA.Size = New System.Drawing.Size(32, 22)
        Me.txtFECHA.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(414, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "FECHA"
        '
        'ESTADIO
        '
        Me.ESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADIO.Location = New System.Drawing.Point(523, 22)
        Me.ESTADIO.Name = "ESTADIO"
        Me.ESTADIO.Size = New System.Drawing.Size(178, 24)
        Me.ESTADIO.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(414, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "AÑO"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(414, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "GRUPO"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(414, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TORNEO"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(19, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "OBSERVACIONES"
        '
        'txtGRUPO
        '
        Me.txtGRUPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRUPO.Location = New System.Drawing.Point(523, 46)
        Me.txtGRUPO.MaxLength = 6
        Me.txtGRUPO.Name = "txtGRUPO"
        Me.txtGRUPO.Size = New System.Drawing.Size(48, 22)
        Me.txtGRUPO.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(414, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ESTADIO"
        '
        'txtMONTO
        '
        Me.txtMONTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO.Location = New System.Drawing.Point(127, 73)
        Me.txtMONTO.Name = "txtMONTO"
        Me.txtMONTO.Size = New System.Drawing.Size(88, 22)
        Me.txtMONTO.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MONTO"
        '
        'datFECHA
        '
        Me.datFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFECHA.Location = New System.Drawing.Point(127, 97)
        Me.datFECHA.Name = "datFECHA"
        Me.datFECHA.Size = New System.Drawing.Size(132, 22)
        Me.datFECHA.TabIndex = 14
        '
        'EQUIPO1
        '
        Me.EQUIPO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EQUIPO1.Location = New System.Drawing.Point(127, 121)
        Me.EQUIPO1.Name = "EQUIPO1"
        Me.EQUIPO1.Size = New System.Drawing.Size(121, 24)
        Me.EQUIPO1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONCEPTO"
        '
        'CONCEPTO
        '
        Me.CONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONCEPTO.Location = New System.Drawing.Point(127, 49)
        Me.CONCEPTO.Name = "CONCEPTO"
        Me.CONCEPTO.Size = New System.Drawing.Size(281, 24)
        Me.CONCEPTO.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EQUIPO"
        '
        'txtANHO
        '
        Me.txtANHO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANHO.Location = New System.Drawing.Point(523, 118)
        Me.txtANHO.MaxLength = 4
        Me.txtANHO.Name = "txtANHO"
        Me.txtANHO.Size = New System.Drawing.Size(48, 22)
        Me.txtANHO.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FECHA"
        '
        'txtOBSERVABONO
        '
        Me.txtOBSERVABONO.BackColor = System.Drawing.Color.White
        Me.txtOBSERVABONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVABONO.Location = New System.Drawing.Point(19, 169)
        Me.txtOBSERVABONO.MaxLength = 100
        Me.txtOBSERVABONO.Name = "txtOBSERVABONO"
        Me.txtOBSERVABONO.Size = New System.Drawing.Size(672, 40)
        Me.txtOBSERVABONO.TabIndex = 23
        Me.txtOBSERVABONO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(250, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "VS"
        '
        'EQUIPO2
        '
        Me.EQUIPO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EQUIPO2.Location = New System.Drawing.Point(287, 121)
        Me.EQUIPO2.Name = "EQUIPO2"
        Me.EQUIPO2.Size = New System.Drawing.Size(121, 24)
        Me.EQUIPO2.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnELIMINAR)
        Me.GroupBox2.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.btnSALIR)
        Me.GroupBox2.Controls.Add(Me.btnCANCELAR)
        Me.GroupBox2.Controls.Add(Me.btnGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 56)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.Location = New System.Drawing.Point(232, 16)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(104, 32)
        Me.btnELIMINAR.TabIndex = 29
        Me.btnELIMINAR.Text = "&Eliminar <F5>"
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.Location = New System.Drawing.Point(128, 16)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(104, 32)
        Me.btnMODIFICAR.TabIndex = 26
        Me.btnMODIFICAR.Text = "&Modificar <F3>"
        '
        'btnSALIR
        '
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(440, 16)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(96, 32)
        Me.btnSALIR.TabIndex = 28
        Me.btnSALIR.Text = "&Salir <F12>"
        '
        'btnCANCELAR
        '
        Me.btnCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELAR.Location = New System.Drawing.Point(336, 16)
        Me.btnCANCELAR.Name = "btnCANCELAR"
        Me.btnCANCELAR.Size = New System.Drawing.Size(104, 32)
        Me.btnCANCELAR.TabIndex = 27
        Me.btnCANCELAR.Text = "&Cancelar <F4>"
        '
        'btnGUARDAR
        '
        Me.btnGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGUARDAR.Location = New System.Drawing.Point(24, 16)
        Me.btnGUARDAR.Name = "btnGUARDAR"
        Me.btnGUARDAR.Size = New System.Drawing.Size(104, 32)
        Me.btnGUARDAR.TabIndex = 25
        Me.btnGUARDAR.Text = "&Agregar <F2>"
        '
        'tabDESCUENTO
        '
        Me.tabDESCUENTO.BackColor = System.Drawing.SystemColors.Control
        Me.tabDESCUENTO.Controls.Add(Me.Label15)
        Me.tabDESCUENTO.Controls.Add(Me.GroupBox4)
        Me.tabDESCUENTO.Location = New System.Drawing.Point(4, 25)
        Me.tabDESCUENTO.Name = "tabDESCUENTO"
        Me.tabDESCUENTO.Size = New System.Drawing.Size(736, 291)
        Me.tabDESCUENTO.TabIndex = 1
        Me.tabDESCUENTO.Text = "DESCUENTO"
        Me.tabDESCUENTO.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(696, 32)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "CARGA DE DESCUENTOS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox4.Controls.Add(Me.txtCUOTA)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblDOCUMENTODESC)
        Me.GroupBox4.Controls.Add(Me.txtMONTODESC)
        Me.GroupBox4.Controls.Add(Me.txtDOCUMENTODESC)
        Me.GroupBox4.Controls.Add(Me.lblCONCEPTODESC)
        Me.GroupBox4.Controls.Add(Me.lblFECHA2DESC)
        Me.GroupBox4.Controls.Add(Me.datFECHADOC)
        Me.GroupBox4.Controls.Add(Me.CONCEPTODESC)
        Me.GroupBox4.Controls.Add(Me.lblFECHA1DESC)
        Me.GroupBox4.Controls.Add(Me.lblMONTODESC)
        Me.GroupBox4.Controls.Add(Me.txtNUMERODOC)
        Me.GroupBox4.Controls.Add(Me.datFECHADESC)
        Me.GroupBox4.Controls.Add(Me.lblNUMERODESC)
        Me.GroupBox4.Controls.Add(Me.txtOBSERVADESC)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 192)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'txtCUOTA
        '
        Me.txtCUOTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUOTA.Location = New System.Drawing.Point(545, 94)
        Me.txtCUOTA.MaxLength = 4
        Me.txtCUOTA.Name = "txtCUOTA"
        Me.txtCUOTA.Size = New System.Drawing.Size(45, 22)
        Me.txtCUOTA.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Silver
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(423, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 24)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "CUOTA"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 24)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "OBSERVACIONES"
        '
        'lblDOCUMENTODESC
        '
        Me.lblDOCUMENTODESC.BackColor = System.Drawing.Color.Silver
        Me.lblDOCUMENTODESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDOCUMENTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOCUMENTODESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDOCUMENTODESC.Location = New System.Drawing.Point(424, 24)
        Me.lblDOCUMENTODESC.Name = "lblDOCUMENTODESC"
        Me.lblDOCUMENTODESC.Size = New System.Drawing.Size(112, 24)
        Me.lblDOCUMENTODESC.TabIndex = 3
        Me.lblDOCUMENTODESC.Text = "DOCUMENTO"
        '
        'txtMONTODESC
        '
        Me.txtMONTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTODESC.Location = New System.Drawing.Point(136, 48)
        Me.txtMONTODESC.MaxLength = 12
        Me.txtMONTODESC.Name = "txtMONTODESC"
        Me.txtMONTODESC.Size = New System.Drawing.Size(100, 22)
        Me.txtMONTODESC.TabIndex = 8
        '
        'txtDOCUMENTODESC
        '
        Me.txtDOCUMENTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOCUMENTODESC.Location = New System.Drawing.Point(544, 24)
        Me.txtDOCUMENTODESC.MaxLength = 25
        Me.txtDOCUMENTODESC.Name = "txtDOCUMENTODESC"
        Me.txtDOCUMENTODESC.Size = New System.Drawing.Size(144, 22)
        Me.txtDOCUMENTODESC.TabIndex = 10
        '
        'lblCONCEPTODESC
        '
        Me.lblCONCEPTODESC.BackColor = System.Drawing.Color.Silver
        Me.lblCONCEPTODESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCONCEPTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCONCEPTODESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCONCEPTODESC.Location = New System.Drawing.Point(16, 24)
        Me.lblCONCEPTODESC.Name = "lblCONCEPTODESC"
        Me.lblCONCEPTODESC.Size = New System.Drawing.Size(104, 24)
        Me.lblCONCEPTODESC.TabIndex = 0
        Me.lblCONCEPTODESC.Text = "CONCEPTO"
        '
        'lblFECHA2DESC
        '
        Me.lblFECHA2DESC.BackColor = System.Drawing.Color.Silver
        Me.lblFECHA2DESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFECHA2DESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA2DESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFECHA2DESC.Location = New System.Drawing.Point(424, 48)
        Me.lblFECHA2DESC.Name = "lblFECHA2DESC"
        Me.lblFECHA2DESC.Size = New System.Drawing.Size(112, 24)
        Me.lblFECHA2DESC.TabIndex = 4
        Me.lblFECHA2DESC.Text = "FECHA"
        '
        'datFECHADOC
        '
        Me.datFECHADOC.Checked = False
        Me.datFECHADOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datFECHADOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFECHADOC.Location = New System.Drawing.Point(544, 48)
        Me.datFECHADOC.Name = "datFECHADOC"
        Me.datFECHADOC.Size = New System.Drawing.Size(88, 22)
        Me.datFECHADOC.TabIndex = 11
        '
        'CONCEPTODESC
        '
        Me.CONCEPTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONCEPTODESC.Location = New System.Drawing.Point(136, 24)
        Me.CONCEPTODESC.Name = "CONCEPTODESC"
        Me.CONCEPTODESC.Size = New System.Drawing.Size(272, 24)
        Me.CONCEPTODESC.TabIndex = 7
        '
        'lblFECHA1DESC
        '
        Me.lblFECHA1DESC.BackColor = System.Drawing.Color.Silver
        Me.lblFECHA1DESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFECHA1DESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA1DESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFECHA1DESC.Location = New System.Drawing.Point(16, 72)
        Me.lblFECHA1DESC.Name = "lblFECHA1DESC"
        Me.lblFECHA1DESC.Size = New System.Drawing.Size(104, 24)
        Me.lblFECHA1DESC.TabIndex = 2
        Me.lblFECHA1DESC.Text = "FECHA"
        '
        'lblMONTODESC
        '
        Me.lblMONTODESC.BackColor = System.Drawing.Color.Silver
        Me.lblMONTODESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMONTODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTODESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMONTODESC.Location = New System.Drawing.Point(16, 48)
        Me.lblMONTODESC.Name = "lblMONTODESC"
        Me.lblMONTODESC.Size = New System.Drawing.Size(104, 24)
        Me.lblMONTODESC.TabIndex = 1
        Me.lblMONTODESC.Text = "MONTO"
        '
        'txtNUMERODOC
        '
        Me.txtNUMERODOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERODOC.Location = New System.Drawing.Point(544, 72)
        Me.txtNUMERODOC.MaxLength = 10
        Me.txtNUMERODOC.Name = "txtNUMERODOC"
        Me.txtNUMERODOC.Size = New System.Drawing.Size(100, 22)
        Me.txtNUMERODOC.TabIndex = 12
        '
        'datFECHADESC
        '
        Me.datFECHADESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datFECHADESC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFECHADESC.Location = New System.Drawing.Point(136, 72)
        Me.datFECHADESC.Name = "datFECHADESC"
        Me.datFECHADESC.Size = New System.Drawing.Size(96, 22)
        Me.datFECHADESC.TabIndex = 9
        '
        'lblNUMERODESC
        '
        Me.lblNUMERODESC.BackColor = System.Drawing.Color.Silver
        Me.lblNUMERODESC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNUMERODESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMERODESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNUMERODESC.Location = New System.Drawing.Point(424, 72)
        Me.lblNUMERODESC.Name = "lblNUMERODESC"
        Me.lblNUMERODESC.Size = New System.Drawing.Size(112, 24)
        Me.lblNUMERODESC.TabIndex = 5
        Me.lblNUMERODESC.Text = "NUMERO"
        '
        'txtOBSERVADESC
        '
        Me.txtOBSERVADESC.Location = New System.Drawing.Point(16, 120)
        Me.txtOBSERVADESC.MaxLength = 100
        Me.txtOBSERVADESC.Name = "txtOBSERVADESC"
        Me.txtOBSERVADESC.Size = New System.Drawing.Size(664, 56)
        Me.txtOBSERVADESC.TabIndex = 14
        Me.txtOBSERVADESC.Text = ""
        '
        'tabDeudaPendiente
        '
        Me.tabDeudaPendiente.Controls.Add(Me.btnAsignarDeudas)
        Me.tabDeudaPendiente.Controls.Add(Me.dgvListaConceptos)
        Me.tabDeudaPendiente.Controls.Add(Me.dgvListaArbitros)
        Me.tabDeudaPendiente.Location = New System.Drawing.Point(4, 25)
        Me.tabDeudaPendiente.Name = "tabDeudaPendiente"
        Me.tabDeudaPendiente.Size = New System.Drawing.Size(736, 291)
        Me.tabDeudaPendiente.TabIndex = 2
        Me.tabDeudaPendiente.Text = "DEUDA PENDIENTE"
        Me.tabDeudaPendiente.UseVisualStyleBackColor = True
        '
        'btnAsignarDeudas
        '
        Me.btnAsignarDeudas.Location = New System.Drawing.Point(636, 7)
        Me.btnAsignarDeudas.Name = "btnAsignarDeudas"
        Me.btnAsignarDeudas.Size = New System.Drawing.Size(97, 55)
        Me.btnAsignarDeudas.TabIndex = 2
        Me.btnAsignarDeudas.Text = "Asignar Deudas"
        Me.btnAsignarDeudas.UseVisualStyleBackColor = True
        '
        'dgvListaConceptos
        '
        Me.dgvListaConceptos.AutoGenerateColumns = False
        Me.dgvListaConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionadoDeuda, Me.concodigo, Me.connombre, Me.conmonto, Me.contipo})
        Me.dgvListaConceptos.DataSource = Me.ConceptoBindingSource
        Me.dgvListaConceptos.Location = New System.Drawing.Point(356, 7)
        Me.dgvListaConceptos.Name = "dgvListaConceptos"
        Me.dgvListaConceptos.Size = New System.Drawing.Size(274, 281)
        Me.dgvListaConceptos.TabIndex = 1
        '
        'colSeleccionadoDeuda
        '
        Me.colSeleccionadoDeuda.HeaderText = "Sel"
        Me.colSeleccionadoDeuda.Name = "colSeleccionadoDeuda"
        Me.colSeleccionadoDeuda.Width = 30
        '
        'concodigo
        '
        Me.concodigo.DataPropertyName = "concodigo"
        Me.concodigo.HeaderText = "concodigo"
        Me.concodigo.Name = "concodigo"
        Me.concodigo.Visible = False
        '
        'connombre
        '
        Me.connombre.DataPropertyName = "connombre"
        Me.connombre.HeaderText = "connombre"
        Me.connombre.Name = "connombre"
        '
        'conmonto
        '
        Me.conmonto.DataPropertyName = "conmonto"
        Me.conmonto.HeaderText = "conmonto"
        Me.conmonto.Name = "conmonto"
        '
        'contipo
        '
        Me.contipo.DataPropertyName = "contipo"
        Me.contipo.HeaderText = "contipo"
        Me.contipo.Name = "contipo"
        Me.contipo.Visible = False
        '
        'ConceptoBindingSource
        '
        Me.ConceptoBindingSource.DataMember = "concepto"
        Me.ConceptoBindingSource.DataSource = Me.DataSet2
        Me.ConceptoBindingSource.Filter = "contipo = 'D'"
        Me.ConceptoBindingSource.Sort = "connombre asc"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvListaArbitros
        '
        Me.dgvListaArbitros.AllowUserToAddRows = False
        Me.dgvListaArbitros.AutoGenerateColumns = False
        Me.dgvListaArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaArbitros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionadoArbitro, Me.arbcedula, Me.arbnombre, Me.arbsituacion})
        Me.dgvListaArbitros.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvListaArbitros.DataSource = Me.ArbitroBindingSource
        Me.dgvListaArbitros.Location = New System.Drawing.Point(6, 7)
        Me.dgvListaArbitros.Name = "dgvListaArbitros"
        Me.dgvListaArbitros.Size = New System.Drawing.Size(344, 281)
        Me.dgvListaArbitros.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 48)
        Me.ContextMenuStrip1.Text = "seleccionar todos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "seleccionar todos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem2.Text = "seleccionar ninguno"
        '
        'ArbitroBindingSource
        '
        Me.ArbitroBindingSource.DataMember = "arbitro"
        Me.ArbitroBindingSource.DataSource = Me.DataSet11
        Me.ArbitroBindingSource.Filter = "arbsituacion = 'Activo'"
        Me.ArbitroBindingSource.Sort = "arbnombre asc"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet11"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabDescontarPendiente
        '
        Me.tabDescontarPendiente.Controls.Add(Me.btnDescontarPendientes)
        Me.tabDescontarPendiente.Controls.Add(Me.grdDeudaApagar)
        Me.tabDescontarPendiente.Location = New System.Drawing.Point(4, 25)
        Me.tabDescontarPendiente.Name = "tabDescontarPendiente"
        Me.tabDescontarPendiente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDescontarPendiente.Size = New System.Drawing.Size(736, 291)
        Me.tabDescontarPendiente.TabIndex = 3
        Me.tabDescontarPendiente.Text = "Descontar Pendiente"
        Me.tabDescontarPendiente.UseVisualStyleBackColor = True
        '
        'btnDescontarPendientes
        '
        Me.btnDescontarPendientes.Location = New System.Drawing.Point(576, 6)
        Me.btnDescontarPendientes.Name = "btnDescontarPendientes"
        Me.btnDescontarPendientes.Size = New System.Drawing.Size(154, 23)
        Me.btnDescontarPendientes.TabIndex = 42
        Me.btnDescontarPendientes.Text = "Descontar Pendientes"
        Me.btnDescontarPendientes.UseVisualStyleBackColor = True
        '
        'grdDeudaApagar
        '
        Me.grdDeudaApagar.AutoGenerateColumns = False
        Me.grdDeudaApagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDeudaApagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn, Me.SaldoapagarDataGridViewTextBoxColumn, Me.fechaalta, Me.aimputar, Me.idfila, Me.idconcepto, Me.cedula})
        Me.grdDeudaApagar.DataSource = Me.DeudasApagarBindingSource1
        Me.grdDeudaApagar.Location = New System.Drawing.Point(6, 6)
        Me.grdDeudaApagar.Name = "grdDeudaApagar"
        Me.grdDeudaApagar.Size = New System.Drawing.Size(564, 237)
        Me.grdDeudaApagar.TabIndex = 41
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoapagarDataGridViewTextBoxColumn
        '
        Me.SaldoapagarDataGridViewTextBoxColumn.DataPropertyName = "saldoapagar"
        Me.SaldoapagarDataGridViewTextBoxColumn.HeaderText = "saldoapagar"
        Me.SaldoapagarDataGridViewTextBoxColumn.Name = "SaldoapagarDataGridViewTextBoxColumn"
        Me.SaldoapagarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'fechaalta
        '
        Me.fechaalta.DataPropertyName = "fechaalta"
        Me.fechaalta.HeaderText = "fechaalta"
        Me.fechaalta.Name = "fechaalta"
        Me.fechaalta.ReadOnly = True
        '
        'aimputar
        '
        Me.aimputar.HeaderText = "A Imputar"
        Me.aimputar.Name = "aimputar"
        '
        'idfila
        '
        Me.idfila.DataPropertyName = "id"
        Me.idfila.HeaderText = "id"
        Me.idfila.Name = "idfila"
        Me.idfila.ReadOnly = True
        Me.idfila.Visible = False
        '
        'idconcepto
        '
        Me.idconcepto.DataPropertyName = "idconcepto"
        Me.idconcepto.HeaderText = "idconcepto"
        Me.idconcepto.Name = "idconcepto"
        Me.idconcepto.ReadOnly = True
        Me.idconcepto.Visible = False
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Visible = False
        '
        'DeudasApagarBindingSource1
        '
        Me.DeudasApagarBindingSource1.DataMember = "DeudasApagar"
        Me.DeudasApagarBindingSource1.DataSource = Me.DataSet13
        '
        'DataSet13
        '
        Me.DataSet13.DataSetName = "DataSet1"
        Me.DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeudasApagarBindingSource
        '
        '
        'DataSet11BindingSource1
        '
        Me.DataSet11BindingSource1.DataSource = Me.DataSet11
        Me.DataSet11BindingSource1.Position = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(920, 32)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "CARGA DE BONOS Y DESCUENTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArbitroTableAdapter1
        '
        Me.ArbitroTableAdapter1.ClearBeforeFill = True
        '
        'ConceptoTableAdapter
        '
        Me.ConceptoTableAdapter.ClearBeforeFill = True
        '
        'DataSet11BindingSource
        '
        Me.DataSet11BindingSource.DataSource = Me.DataSet11
        Me.DataSet11BindingSource.Position = 0
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet12BindingSource
        '
        Me.DataSet12BindingSource.DataSource = Me.DataSet12
        Me.DataSet12BindingSource.Position = 0
        '
        'DeudasApagarTableAdapter
        '
        Me.DeudasApagarTableAdapter.ClearBeforeFill = True
        '
        'colSeleccionadoArbitro
        '
        Me.colSeleccionadoArbitro.HeaderText = "Sel"
        Me.colSeleccionadoArbitro.Name = "colSeleccionadoArbitro"
        Me.colSeleccionadoArbitro.Width = 30
        '
        'arbcedula
        '
        Me.arbcedula.DataPropertyName = "arbcedula"
        Me.arbcedula.HeaderText = "arbcedula"
        Me.arbcedula.Name = "arbcedula"
        '
        'arbnombre
        '
        Me.arbnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.arbnombre.DataPropertyName = "arbnombre"
        Me.arbnombre.FillWeight = 130.0!
        Me.arbnombre.HeaderText = "arbnombre"
        Me.arbnombre.Name = "arbnombre"
        Me.arbnombre.Width = 5
        '
        'arbsituacion
        '
        Me.arbsituacion.DataPropertyName = "arbsituacion"
        Me.arbsituacion.HeaderText = "arbsituacion"
        Me.arbsituacion.Name = "arbsituacion"
        Me.arbsituacion.Visible = False
        '
        'frmPROCESOCRUD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(936, 565)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPROCESOCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELTA - Módulo de Carga de Bonos y Descuentos"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.grdARBITRO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.grdMOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabMOVIMIENTO.ResumeLayout(False)
        Me.tabBONO.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.tabDESCUENTO.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabDeudaPendiente.ResumeLayout(False)
        CType(Me.dgvListaConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConceptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaArbitros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ArbitroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDescontarPendiente.ResumeLayout(False)
        CType(Me.grdDeudaApagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudasApagarBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudasApagarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet12BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnCEDULA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNOMBRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmPROCESOCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.DeudasApagar' table. You can move, or remove it, as needed.
        'Me.DeudasApagarTableAdapter.Fill(Me.DataSet11.DeudasApagar)
        'TODO: This line of code loads data into the 'DataSet4.deuda_apagar' table. You can move, or remove it, as needed.
        'Me.Deuda_apagarTableAdapter.Fill(Me.DataSet4.deuda_apagar)
        'TODO: This line of code loads data into the 'DataSet3.deuda_apagar' table. You can move, or remove it, as needed.
        'Me.Deuda_apagarTableAdapter.Fill(Me.DataSet3.deuda_apagar)
        'TODO: This line of code loads data into the 'DataSet2.concepto' table. You can move, or remove it, as needed.
        Me.ConceptoTableAdapter.Fill(Me.DataSet2.concepto)
        'TODO: This line of code loads data into the 'DataSet11.arbitro' table. You can move, or remove it, as needed.
        Me.ArbitroTableAdapter1.Fill(Me.DataSet11.arbitro)
        'TODO: This line of code loads data into the 'DataSet1.arbitro' table. You can move, or remove it, as needed.
        'Me.ArbitroTableAdapter.Fill(Me.DataSet11.arbitro)
        'TODO: This line of code loads data into the 'DataSet1.arbitro' table. You can move, or remove it, as needed.
        'Me.ArbitroTableAdapter.Fill(Me.DataSet11.arbitro)
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        cargarDivision()
        cargarConcepto(0)
        cargarEquipos(Val(Me.DIVISION.Text))
        cargarEstadio()
        CerrarConexion()
        With Me
            .txtTORNEO.SelectedIndex = 0
            .txtANHO.Text = FormatNumber(Year(Now), 0, TriState.UseDefault)
        End With
    End Sub

    Private Sub setEstiloGrilla()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOS.Tables("arbitro").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn

        With estilo1
            .MappingName = "arbcedula"
            .HeaderText = " CEDULA "
            .Width = 70
        End With

        With estilo2
            .MappingName = "arbnombre"
            .HeaderText = " NOMBRE "
            .Width = 230
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        Me.grdARBITRO.TableStyles.Clear()
        Me.grdARBITRO.TableStyles.Add(estilos)

    End Sub

    Private Sub cargarGrilla()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT arbcedula, arbnombre FROM arbitro order by arbnombre"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre LIKE '%'", "arbnombre ASC", DataViewRowState.OriginalRows)
        Me.grdARBITRO.DataSource = dataviewLOCAL
        'Me.grdARBITRO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub tabBONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabBONO.Click

    End Sub

    Private Sub grdARBITRO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdARBITRO.Navigate

    End Sub

    Private Sub grdARBITRO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdARBITRO.Click

        Dim fila As Integer
        fila = grdARBITRO.CurrentRowIndex
        wkarbcedula = grdARBITRO.Item(fila, 0)

        If wkarbcedula > 0 Then
            AbrirConexion()
            cargarMovimiento(wkarbcedula, 1)
            setEstiloMovimiento()
            cargarDeudasPendientesArbitro()
            CerrarConexion()
        End If
        glocedula = 0
        glofecha = ""
        glomonto = 0
        glotipo = 0
        gloconcepto = 0
        glomovid = 0
    End Sub

    Private Sub cargarDeudasPendientesArbitro()

        ' Bind the DataGridView to the BindingSource
        ' and load the data from the database.
        Dim asdf As New DataSet1TableAdapters.DeudasApagarTableAdapter
        Me.grdDeudaApagar.DataSource = asdf.GetData(grdARBITRO.Item(grdARBITRO.CurrentRowIndex, 0))
        For Each filaDeudas As DataGridViewRow In Me.grdDeudaApagar.Rows
            filaDeudas.Cells.Item("aimputar").Value = "0"
        Next

    End Sub

    Private Sub setEstiloMovimiento()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOSM.Tables("movimiento").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn
        Dim estilo5 As New DataGridTextBoxColumn
        Dim estilo6 As New DataGridTextBoxColumn
        Dim estilo7 As New DataGridTextBoxColumn



        With estilo1
            .MappingName = "movfecha"
            .HeaderText = " Fecha "
            .Width = 70
        End With

        With estilo2
            .MappingName = "connombre"
            .HeaderText = " Concepto "
            .Width = 250
        End With


        With estilo3
            .MappingName = "movmonto"
            .HeaderText = " Monto "
            .Width = 70
        End With

        With estilo4
            .MappingName = "movtipo"
            .HeaderText = "Tipo"
            .Width = 75
        End With

        With estilo5
            .MappingName = "movequipo1"
            .HeaderText = "Identificador 1"
            .Width = 35
        End With

        With estilo6
            .MappingName = "movequipo2"
            .HeaderText = "Identificador 2"
            .Width = 35
        End With

        With estilo7
            .MappingName = "movid"
            .HeaderText = "Identificador movimiento"
            .Width = 35
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        estilos.GridColumnStyles.Add(estilo4)
        estilos.GridColumnStyles.Add(estilo5)
        estilos.GridColumnStyles.Add(estilo6)
        estilos.GridColumnStyles.Add(estilo7)
        Me.grdMOVIMIENTO.TableStyles.Clear()
        Me.grdMOVIMIENTO.TableStyles.Add(estilos)

    End Sub


    Private Sub cargarMovimiento(ByVal wkarbcedula As Integer, ByVal wkforma As Integer)
        Try
            If wkforma = 1 Or (Me.chkBONO.Checked = False And Me.chkDESCUENTO.Checked = False) Then
                'FROM (movimiento INNER JOIN equipos ON movimiento.movequipo1 = equipos.codequipo) INNER JOIN equipos AS equipos_1 ON movimiento.movequipo1 = equipos_1.codequipo
                Dim dataviewLOCAL As DataView
                dsDATOSM = New DataSet
                strSQL = "SELECT movfecha, connombre, movmonto, movtipo, movequipo1, movequipo2, movid " & _
                "FROM movmensual INNER JOIN concepto ON movmensual.movconcepto = concepto.concodigo " & _
                "WHERE movcedula = " & wkarbcedula & _
                "ORDER by movfecha DESC"

                Dim adDATOSM As New Odbc.OdbcDataAdapter
                adDATOSM.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                adDATOSM.Fill(dsDATOSM, "movimiento")

                dataviewLOCAL = New DataView(dsDATOSM.Tables("movimiento"), "connombre LIKE '%'", "movfecha DESC", DataViewRowState.OriginalRows)
                Me.grdMOVIMIENTO.DataSource = dataviewLOCAL
            ElseIf wkforma = 2 Then
                'FROM (movimiento INNER JOIN equipos ON movimiento.movequipo1 = equipos.codequipo) INNER JOIN equipos AS equipos_1 ON movimiento.movequipo1 = equipos_1.codequipo
                Dim wktipo As String
                If Me.chkBONO.Checked = True Then
                    wktipo = "B"
                Else
                    If Me.chkDESCUENTO.Checked = True Then
                        wktipo = "D"
                    End If
                End If
                Dim dataviewLOCAL As DataView
                dsDATOSM = New DataSet
                strSQL = "SELECT movfecha, connombre, movmonto, movtipo, movid " & _
                "FROM movmensual INNER JOIN concepto ON movmensual.movconcepto = concepto.concodigo " & _
                "WHERE movcedula = " & wkarbcedula & " and movtipo = '" & wktipo & "' " & _
                "ORDER by movfecha DESC"

                Dim adDATOSM As New Odbc.OdbcDataAdapter
                adDATOSM.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                adDATOSM.Fill(dsDATOSM, "movimiento")

                dataviewLOCAL = New DataView(dsDATOSM.Tables("movimiento"), "connombre LIKE '%'", "movfecha DESC", DataViewRowState.OriginalRows)
                Me.grdMOVIMIENTO.DataSource = dataviewLOCAL
            End If
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en los registros de Movimientos", MessageBoxButtons.OK)
            End
        End Try

    End Sub

    Sub cargarDivision()
        Try
            Dim strELEMENTO As String
            Dim wkdivcodigo As Integer
            Dim wkdivnombre As String

            Dim strsql As String = "SELECT divcodigo, divnombre from division order by divcodigo;"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader

            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                wkdivcodigo = myReader.GetValue(0)
                wkdivnombre = myReader.GetString(1)

                strELEMENTO = wkdivcodigo
                strELEMENTO = strELEMENTO + " "
                strELEMENTO = strELEMENTO + wkdivnombre
                Me.DIVISION.Items.Add(strELEMENTO)
            End While
            Me.DIVISION.SelectedIndex = 0
            myReader.Close()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en los registros de Movimientos", MessageBoxButtons.OK)
            End
        End Try
    End Sub


    Sub cargarConcepto(ByVal wkdivision As Integer)
        Try
            Dim strELEMENTO As String
            Dim wkconcodigo As Integer
            Dim wkdivcodigo As Integer
            Dim wkconnombre As String
            Dim wkcontipo As String

            Dim strsql As String = "SELECT concodigo, connombre, contipo, condivcodigo from concepto order by concodigo;"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader

            Me.CONCEPTO.Items.Clear()

            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                wkconcodigo = myReader.GetValue(0)
                wkconnombre = myReader.GetString(1)
                wkcontipo = myReader.GetString(2)
                wkdivcodigo = myReader.GetValue(3)

                strELEMENTO = wkconcodigo
                strELEMENTO = strELEMENTO + " "
                strELEMENTO = strELEMENTO + wkconnombre
                If wkcontipo = "B" Then
                    If wkdivision > 0 Then
                        If wkdivcodigo = wkdivision Then
                            Me.CONCEPTO.Items.Add(strELEMENTO)
                        End If
                    Else
                        Me.CONCEPTO.Items.Add(strELEMENTO)
                    End If
                Else
                    Me.CONCEPTODESC.Items.Add(strELEMENTO)
                End If
            End While
            myReader.Close()
            Me.CONCEPTO.SelectedItem = 0
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en los registros", MessageBoxButtons.OK)
            End
        End Try

    End Sub
    Sub cargarConce(ByVal auxcadena As String)
        Dim strELEMENTO As String
        Dim wkconcodigo As Integer
        Dim wkdivcodigo As Integer
        Dim wkconnombre As String
        Dim wkcontipo As String
        AbrirConexion()

        Dim strsql As String = "SELECT concodigo, connombre, contipo, condivcodigo " & _
                               "FROM concepto " & _
                               "WHERE connombre ilike '%" & auxcadena & "%' order by concodigo;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        Me.CONCEPTO.Items.Clear()

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkconcodigo = myReader.GetValue(0)
            wkconnombre = myReader.GetString(1)
            wkcontipo = myReader.GetString(2)
            wkdivcodigo = myReader.GetValue(3)

            strELEMENTO = wkconcodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkconnombre
            If wkcontipo = "B" Then
                Me.CONCEPTO.Items.Add(strELEMENTO)
            End If
        End While
        myReader.Close()
        CerrarConexion()
        Me.CONCEPTO.SelectedIndex = 0
    End Sub
    Sub cargarequiaux1(ByVal auxcadena As String, ByVal auxdivision As Integer)
        Dim blnequipo As Boolean
        Dim strELEMENTO As String
        Dim wkconcodigo As Integer
        Dim wkdivcodigo As Integer
        Dim wkequinombre As String
        Dim wkequicodigo As String
        AbrirConexion()
        Dim strsql As String = "SELECT distinct equipo.equicodigo, equipo.equibreve " & _
                       "FROM equipo INNER JOIN equidivision ON equipo.equicodigo = equidivision.equicodigo " & _
                       "WHERE equidivision.divicodigo = " & auxdivision & _
                       " and equibreve ilike '%" & auxcadena & "%' " & _
                       " order by equipo.equibreve;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        blnequipo = False

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkequicodigo = myReader.GetValue(0)
            wkequinombre = myReader.GetString(1)

            strELEMENTO = wkequicodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkequinombre
            If blnequipo = False Then
                blnequipo = True
                Me.EQUIPO1.Items.Clear()
            End If
            Me.EQUIPO1.Items.Add(strELEMENTO)
        End While
        myReader.Close()
        CerrarConexion()
        If blnequipo = True Then
            Me.EQUIPO1.SelectedIndex = 0
        End If
    End Sub

    Sub cargarequiaux2(ByVal auxcadena As String, ByVal auxdivision As Integer)
        Dim blnequipo As Boolean
        Dim strELEMENTO As String
        Dim wkconcodigo As Integer
        Dim wkdivcodigo As Integer
        Dim wkequinombre As String
        Dim wkequicodigo As String
        AbrirConexion()
        Dim strsql As String = "SELECT distinct equipo.equicodigo, equipo.equibreve " & _
                       "FROM equipo INNER JOIN equidivision ON equipo.equicodigo = equidivision.equicodigo " & _
                       "WHERE equidivision.divicodigo = " & auxdivision & _
                       " and equibreve ilike '%" & auxcadena & "%' " & _
                       " order by equipo.equibreve;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        blnequipo = False

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkequicodigo = myReader.GetValue(0)
            wkequinombre = myReader.GetString(1)

            strELEMENTO = wkequicodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkequinombre
            If blnequipo = False Then
                blnequipo = True
                Me.EQUIPO2.Items.Clear()
            End If
            Me.EQUIPO2.Items.Add(strELEMENTO)
        End While
        myReader.Close()
        CerrarConexion()
        If blnequipo = True Then
            Me.EQUIPO2.SelectedIndex = 0
        End If
    End Sub


    Sub cargarEquipos(ByVal auxdivision As Integer)
        Try
            Dim strELEMENTO As String
            Dim wkequicodigo As String
            Dim wkequibreve As String


            Dim strsql As String = "SELECT distinct equipo.equicodigo, equipo.equibreve " & _
                                   "FROM equipo INNER JOIN equidivision ON equipo.equicodigo = equidivision.equicodigo " & _
                                   "WHERE equidivision.divicodigo = " & auxdivision & " order by equipo.equicodigo;"
            Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
            Dim myReader As Odbc.OdbcDataReader

            myReader = myCommand.ExecuteReader()
            With Me
                .EQUIPO1.Items.Clear()
                .EQUIPO2.Items.Clear()
            End With
            While myReader.Read()
                wkequicodigo = myReader.GetValue(0)
                wkequibreve = myReader.GetString(1)

                strELEMENTO = wkequicodigo
                strELEMENTO = strELEMENTO + " "
                strELEMENTO = strELEMENTO + wkequibreve
                With Me
                    .EQUIPO1.Items.Add(strELEMENTO)
                    .EQUIPO2.Items.Add(strELEMENTO)
                End With
            End While

            If Me.EQUIPO1.Items.Count > 0 Then
                With Me
                    .EQUIPO1.SelectedIndex = 0
                    .EQUIPO2.SelectedIndex = 0
                End With
            Else
                With Me
                    .EQUIPO1.Text = ""
                    .EQUIPO2.Text = ""
                End With
            End If
            myReader.Close()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en los registros de Movimientos", MessageBoxButtons.OK)
            End
        End Try


    End Sub

    Sub cargarEstadio()
        Dim strELEMENTO As String
        Dim wkestcodigo As String
        Dim wkestbreve As String


        Dim strsql As String = "SELECT estcodigo, estbreve from estadio order by estcodigo;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader

        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkestcodigo = myReader.GetValue(0)
            wkestbreve = myReader.GetString(1)

            strELEMENTO = wkestcodigo
            strELEMENTO = strELEMENTO + " "
            strELEMENTO = strELEMENTO + wkestbreve
            Me.ESTADIO.Items.Add(strELEMENTO)
        End While
        myReader.Close()
        Me.ESTADIO.SelectedIndex = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMOVIMIENTO.SelectedIndexChanged
        'AbrirConexion()
        'cargarConcepto()
        'cargarEquipos()
        'cargarEstadio()
        'CerrarConexion()
    End Sub

    Private Sub txtMONTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMONTO.TextChanged

    End Sub

    Private Sub txtMONTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMONTO.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtMONTO.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub CONCEPTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONCEPTO.SelectedIndexChanged

    End Sub

    Private Sub CONCEPTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONCEPTO.KeyPress
        Dim intvalor As Integer
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            intvalor = Val(Me.CONCEPTO.Text)
            If intvalor <= 0 Then
                cargarConce(Trim(Me.CONCEPTO.Text))
            Else
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End If

    End Sub

    Private Sub datFECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datFECHA.ValueChanged

    End Sub

    Private Sub datFECHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datFECHA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub EQUIPO1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQUIPO1.SelectedIndexChanged

    End Sub

    Private Sub EQUIPO1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EQUIPO1.KeyPress
        Try
            Dim auxdivision As Integer
            'If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            '    e.Handled = True
            '    SendKeys.Send("{TAB}")
            'Else
            '    e.Handled = True
            'End If
            Dim strauxiliar As String
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                If Val(Me.EQUIPO1.Text) > 0 Then
                    e.Handled = True
                    SendKeys.Send("{TAB}")
                Else
                    strauxiliar = Trim(Me.EQUIPO1.Text)
                    auxdivision = Val(Me.DIVISION.Text)
                    If Len(strauxiliar) > 0 Then
                        cargarequiaux1(strauxiliar, auxdivision)
                    Else
                        e.Handled = True
                        SendKeys.Send("{TAB}")
                    End If
                End If
            End If
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub EQUIPO2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQUIPO2.SelectedIndexChanged

    End Sub

    Private Sub EQUIPO2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EQUIPO2.KeyPress

        Try
            Dim auxdivision As Integer
            'If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            '    e.Handled = True
            '    SendKeys.Send("{TAB}")
            'Else
            '    e.Handled = True
            'End If
            Dim strauxiliar As String
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                If Val(Me.EQUIPO2.Text) > 0 Then
                    e.Handled = True
                    SendKeys.Send("{TAB}")
                Else
                    strauxiliar = Trim(Me.EQUIPO2.Text)
                    auxdivision = Val(Me.DIVISION.Text)
                    If Len(strauxiliar) > 0 Then
                        cargarequiaux2(strauxiliar, auxdivision)
                    Else
                        e.Handled = True
                        SendKeys.Send("{TAB}")
                    End If
                End If
            End If
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub ESTADIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADIO.SelectedIndexChanged

    End Sub

    Private Sub ESTADIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ESTADIO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtGRUPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGRUPO.TextChanged

    End Sub

    Private Sub txtGRUPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGRUPO.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtGRUPO.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtFECHA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFECHA.TextChanged

    End Sub

    Private Sub txtFECHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFECHA.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtMONTO.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtANHO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtANHO.TextChanged

    End Sub

    Private Sub txtANHO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtANHO.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtANHO.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub btnSALIRDESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIRDESC.Click
        Me.Dispose()
    End Sub

    Private Sub btnAGREGARDESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARDESC.Click
        'If Me.TabMOVIMIENTO.Text = "BONO" Then
        If Me.TabMOVIMIENTO.SelectedTab.Text Is "BONO" Then
            grabarBono()
        Else
            grabarDescuento()
        End If
    End Sub
    Sub limpiarBono()
        With Me
            .CONCEPTO.SelectedIndex = -1
            .txtMONTO.Text = ""
            '.EQUIPO1.SelectedIndex = -1
            '.EQUIPO2.SelectedIndex = -1
            '.ESTADIO.SelectedIndex = -1
            '.txtGRUPO.Text = ""
            '.txtTORNEO.Text = ""
            '.txtANHO.Text = ""
            '.txtFECHA.Text = ""
            '.txtOBSERVABONO.Text = ""
        End With

    End Sub
    Sub limpiarDescuento()
        With Me
            .CONCEPTODESC.SelectedIndex = -1
            .txtMONTODESC.Text = ""
            '.txtDOCUMENTODESC.Text = ""
            '.txtNUMERODOC.Text = ""
            '.txtCUOTA.Text = ""
        End With
    End Sub

    Sub grabarBono()
        If validarBono() = True Then
            Dim wkconcepto, wkmonto, wkequipo1, wkequipo2, wkestdio, wkfechapartida, wkanho As Integer
            Dim wkfecha, wkestadio, wkgrupo, wktorneo, wktipo, wkobservabono, wkTextoAmostrar As String

            wkconcepto = Val(Me.CONCEPTO.Text)
            wkmonto = Val(Replace(Me.txtMONTO.Text, ".", ""))
            wkfecha = Format(Me.datFECHA.Value, "yyyy-MM-dd")
            wkequipo1 = Trim(Str(Val(Microsoft.VisualBasic.Left(Me.EQUIPO1.Text, 2))))
            wkequipo2 = Trim(Str(Val(Microsoft.VisualBasic.Left(Me.EQUIPO2.Text, 2))))
            wkestadio = Val(Str(Val(Microsoft.VisualBasic.Left(Me.ESTADIO.Text, 2))))
            If Val(Me.txtGRUPO.Text) > 0 Then
                wkgrupo = Val(Me.txtGRUPO.Text)
            Else
                wkgrupo = 0
            End If

            If Len(Trim(Me.txtTORNEO.Text)) > 0 Then
                wktorneo = UCase(Trim(Me.txtTORNEO.Text))
            Else
                wktorneo = ""
            End If
            If Val(Me.txtFECHA.Text) > 0 Then
                wkfechapartida = Val(Me.txtFECHA.Text)
            Else
                wkfechapartida = 0
            End If

            If Val(Me.txtANHO.Text) > 0 Then
                wkanho = Val(Replace(Me.txtANHO.Text, ".", ""))
            Else
                wkanho = 0
            End If

            wktipo = "B"

            If Len(Trim(Me.txtOBSERVABONO.Text)) > 0 Then
                wkobservabono = Trim(Me.txtOBSERVABONO.Text)
            Else
                wkobservabono = ""
            End If

            If glocedula > 0 Then
                blnEXISTE = True
            Else
                blnEXISTE = False
            End If

            Try
                AbrirConexion()
                If blnEXISTE = False Then
                    strSQL = "INSERT INTO movmensual (movcedula, movconcepto, movmonto, movfecha, " & _
                                          "movequipo1, movequipo2, movestadio, movgrupo, movtorneo, " & _
                                          "movfechapartida, movanho, movtipo, movobservaciones) " & _
                                  "VALUES (" & wkarbcedula & ", " & wkconcepto & _
                                  ", " & wkmonto & ", '" & wkfecha & _
                                  "', " & wkequipo1 & ", " & wkequipo2 & _
                                  ", " & wkestadio & ", " & wkgrupo & _
                                  ", '" & wktorneo & "', " & wkfechapartida & _
                                  ", " & wkanho & _
                                  ", '" & wktipo & "'" & _
                                  ", '" & wkobservabono & "')"
                Else
                    strSQL = "UPDATE movmensual SET " & _
                    "movcedula = " & wkarbcedula & ", " & _
                    "movconcepto = " & wkconcepto & ", " & _
                    "movmonto = " & wkmonto & ", " & _
                    "movfecha = '" & wkfecha & " ', " & _
                    "movequipo1 = '" & wkequipo1 & "', " & _
                    "movequipo2 = '" & wkequipo2 & "', " & _
                    "movestadio = " & wkestadio & ", " & _
                    "movgrupo = " & wkgrupo & ", " & _
                    "movtorneo = '" & wktorneo & "', " & _
                    "movfechapartida = " & wkfechapartida & ", " & _
                    "movanho = " & wkanho & ", " & _
                    "movtipo = '" & wktipo & "', " & _
                    "movobservaciones = '" & wkobservabono & "' " & _
                    "WHERE movid =" & glomovid
                    ''"WHERE movcedula = " & glocedula & " and " & _
                    ''"movconcepto = " & gloconcepto & " and " & _
                    ''"movfecha = '" & glofecha & "' and " & _
                    ''"movtipo = '" & glotipo & "' and " & _
                    ''"movequipo1 = '" & wkequipo1 & "' and " & _
                    ''"movequipo2 = '" & wkequipo2 & "'"
                End If


                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()

                If (blnEXISTE = False) Then

                    'insertar el mantenimiento de capital correspondiente
                    strSQL = "select max(movid) from movmensual"
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)

                    AbrirConexion()
                    Dim myreader As Odbc.OdbcDataReader
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader.Read()
                    Dim movid As Integer = myreader.GetValue(0)

                    wkmonto = calcularMantenimientoCapital(wkmonto)

                    strSQL = "INSERT INTO movmensual (movcedula, movconcepto, movmonto, movfecha, " & _
                                                      "movobservaciones, movbonoasociado, movtipo) " & _
                                                    "VALUES (" & wkarbcedula & ", " & "4" & _
                                                  ", " & wkmonto & ", '" & wkfecha & _
                                                  "', '" & "mantenimiento de capital" & "', " & _
                                                  movid & ", 'D')" '' insertar el descuento, y asociar el bono
                    AbrirConexion()

                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)

                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()

                    CerrarConexion()
                End If



                cargarMovimiento(wkarbcedula, 1)
                setEstiloMovimiento()
                CerrarConexion()



                wkTextoAmostrar = "Registro ha sido grabado satisfactoriamente!" & Environment.NewLine
                If (blnEXISTE = False) Then
                    'wkTextoAmostrar = wkTextoAmostrar & "Se grabo un descuento de Gs. " & wkmonto & "en concepto de mantenimiento de capital"


                End If

                MessageBox.Show(wkTextoAmostrar, strSLOGAN, MessageBoxButtons.OK)
                limpiarBono()
                glocedula = 0
                glofecha = ""
                glomonto = 0
                glotipo = 0
                gloconcepto = 0


            Catch err As Exception
                MessageBox.Show(err.Message & "Error en la Grabación del registro. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                End
            End Try

        End If
    End Sub


    Function calcularMantenimientoCapital(wkmonto As Integer) As Integer

        Dim strSQL As String
        Dim resultado As Integer
        Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)

        strSQL = "select manmontoasignado from mantenimientocapital" & _
                 " where " & wkmonto & " between manmontoinicial and manmontofinal "
        myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)

        AbrirConexion()
        Dim myreader As Odbc.OdbcDataReader
        myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        resultado = myreader.GetValue(0)

        CerrarConexion()
        Return resultado
    End Function


    Function validarBono()
        Dim blnerror As Boolean
        blnerror = True
        If Val(Me.CONCEPTO.Text) <= 0 Then
            MessageBox.Show("Debe ingresar el concepto correspondiente. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
            blnerror = False
        Else
            If Val(Me.txtMONTO.Text) <= 0 Then
                MessageBox.Show("Debe ingresar el monto del Bono correspondiente. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                blnerror = False
            Else
                If Val(Me.EQUIPO1.Text) = Val(Me.EQUIPO2.Text) Then
                    MessageBox.Show("Los equipos son iguales. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                    blnerror = False
                Else
                    If Len(Trim(Me.txtTORNEO.Text)) = 0 Then
                        MessageBox.Show("Debe seleccionar el Torneo. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                        blnerror = False
                    Else
                        If Val(Me.txtANHO.Text) <= 0 Then
                            MessageBox.Show("Debe ingresar el año del campeonato. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                            blnerror = False
                        Else
                            If Val(Me.txtFECHA.Text) <= 0 Then
                                MessageBox.Show("Debe ingresar la fecha del Arbitraje. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                                blnerror = False
                            End If
                        End If
                    End If
                End If
            End If
        End If
        validarBono = blnerror
    End Function

    Sub grabarDescuento2(filadeuda As DataGridViewRow)
        'If validarDescuento() = True Then
        Dim wkconcepto, wkmonto, wknumerodoc, wkcuota As Integer
        Dim wkfecha, wkdocumento, wktipo, wkdocfecha, wkobservadesc As String

        wkconcepto = Val(filadeuda.Cells.Item("idconcepto").Value)
        wkmonto = Val(filadeuda.Cells.Item("aimputar").Value)
        wkfecha = Format(filadeuda.Cells.Item("fechaalta").Value, "yyyy-MM-dd")

        wkarbcedula = Trim(filadeuda.Cells.Item("cedula").Value)
        wkdocumento = ""
        wkdocfecha = Format(filadeuda.Cells.Item("fechaalta").Value, "yyyy-MM-dd")
        wknumerodoc = 0
        wkcuota = 0
        wkobservadesc = ""


        'If glocedula > 0 Then
        '    blnEXISTE = True
        'Else
        '    blnEXISTE = False
        'End If
        blnEXISTE = False

        wktipo = "D"

        Try
            AbrirConexion()


            'comando para actualizar el saldo
            strSQL = "update deuda_apagar set saldo = saldo - " & wkmonto & _
                      " where id = " & filadeuda.Cells.Item("idfila").Value

            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()


            If blnEXISTE = False Then
                strSQL = "INSERT INTO movmensual (movcedula, movconcepto, movmonto, movfecha, " & _
                                      "movdocumento, movdocfecha, movdocnumero, movcuota, " & _
                                      "movtipo, movobservaciones) " & _
                              "VALUES (" & wkarbcedula & ", " & wkconcepto & _
                              ", " & wkmonto & ", '" & wkfecha & _
                              "', '" & wkdocumento & "', '" & wkdocfecha & _
                              "', " & wknumerodoc & ", " & wkcuota & _
                              ", '" & wktipo & _
                              "', '" & wkobservadesc & "')"
            Else
                strSQL = "UPDATE movmensual SET " & _
                "movcedula = " & wkarbcedula & ", " & _
                "movconcepto = " & wkconcepto & ", " & _
                "movmonto = " & wkmonto & ", " & _
                "movfecha = '" & wkfecha & " ', " & _
                "movdocumento = '" & wkdocumento & "', " & _
                "movdocfecha = '" & wkdocfecha & "', " & _
                "movdocnumero = " & wknumerodoc & ", " & _
                "movcuota = " & wkcuota & ", " & _
                "movtipo = '" & wktipo & "', " & _
                "movobservaciones = '" & wkobservadesc & "' " & _
                "WHERE movcedula = " & glocedula & " and " & _
                "movconcepto = " & gloconcepto & " and " & _
                "movfecha = '" & glofecha & "' and " & _
                "movtipo = '" & glotipo & "'"
            End If

            myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()



            cargarMovimiento(wkarbcedula, 1)
            setEstiloMovimiento()
            CerrarConexion()

            MessageBox.Show("Registro ha sido grabado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
            limpiarDescuento()

            glocedula = 0
            glofecha = ""
            glomonto = 0
            glotipo = 0
            gloconcepto = 0

        Catch err As Exception
            MessageBox.Show(err.Message & "Error en la Grabación del registro. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
            'End
        End Try

        'End If
    End Sub


    Sub grabarDescuento()
        If validarDescuento() = True Then
            Dim wkconcepto, wkmonto, wknumerodoc, wkcuota As Integer
            Dim wkfecha, wkdocumento, wktipo, wkdocfecha, wkobservadesc As String

            wkconcepto = Val(Me.CONCEPTODESC.Text)
            wkmonto = Val(Me.txtMONTODESC.Text)
            wkfecha = Format(Me.datFECHA.Value, "yyyy-MM-dd")

            If Len(Trim(Me.txtDOCUMENTODESC.Text)) > 0 Then
                wkdocumento = Trim(Me.txtDOCUMENTODESC.Text)
            Else
                wkdocumento = ""
            End If

            If Me.datFECHA.Checked = True Then
                wkdocfecha = Me.datFECHA.Value.Date
            Else
                wkdocfecha = ""
            End If

            If Val(Me.txtNUMERODOC.Text) > 0 Then
                wknumerodoc = Val(Me.txtNUMERODOC.Text)
            Else
                wknumerodoc = 0
            End If

            If Val(Me.txtCUOTA.Text) > 0 Then
                wkcuota = Val(Me.txtCUOTA.Text)
            Else
                wkcuota = 0
            End If

            If Len(Trim(Me.txtOBSERVADESC.Text)) > 0 Then
                wkobservadesc = Trim(Me.txtOBSERVADESC.Text)
            Else
                wkobservadesc = ""
            End If

            If glocedula > 0 Then
                blnEXISTE = True
            Else
                blnEXISTE = False
            End If


            wktipo = "D"

            Try
                AbrirConexion()
                If blnEXISTE = False Then
                    strSQL = "INSERT INTO movmensual (movcedula, movconcepto, movmonto, movfecha, " & _
                                          "movdocumento, movdocfecha, movdocnumero, movcuota, " & _
                                          "movtipo, movobservaciones) " & _
                                  "VALUES (" & wkarbcedula & ", " & wkconcepto & _
                                  ", " & wkmonto & ", '" & wkfecha & _
                                  "', '" & wkdocumento & "', '" & wkdocfecha & _
                                  "', " & wknumerodoc & ", " & wkcuota & _
                                  ", '" & wktipo & _
                                  "', '" & wkobservadesc & "')"
                Else
                    strSQL = "UPDATE movmensual SET " & _
                    "movcedula = " & wkarbcedula & ", " & _
                    "movconcepto = " & wkconcepto & ", " & _
                    "movmonto = " & wkmonto & ", " & _
                    "movfecha = '" & wkfecha & " ', " & _
                    "movdocumento = '" & wkdocumento & "', " & _
                    "movdocfecha = '" & wkdocfecha & "', " & _
                    "movdocnumero = " & wknumerodoc & ", " & _
                    "movcuota = " & wkcuota & ", " & _
                    "movtipo = '" & wktipo & "', " & _
                    "movobservaciones = '" & wkobservadesc & "' " & _
                    "WHERE movcedula = " & glocedula & " and " & _
                    "movconcepto = " & gloconcepto & " and " & _
                    "movfecha = '" & glofecha & "' and " & _
                    "movtipo = '" & glotipo & "'"
                End If

                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()

                cargarMovimiento(wkarbcedula, 1)
                setEstiloMovimiento()
                CerrarConexion()

                MessageBox.Show("Registro ha sido grabado satisfactoriamente!", strSLOGAN, MessageBoxButtons.OK)
                limpiarDescuento()

                glocedula = 0
                glofecha = ""
                glomonto = 0
                glotipo = 0
                gloconcepto = 0

            Catch err As Exception
                MessageBox.Show(err.Message & "Error en la Grabación del registro. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                End
            End Try

        End If
    End Sub
    Function validarDescuento()
        Dim blnerror As Boolean
        blnerror = True
        If Val(Me.CONCEPTODESC.Text) <= 0 Then
            MessageBox.Show("Debe ingresar el concepto del Descuento. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
            blnerror = False
        Else
            If Val(Me.txtMONTODESC.Text) <= 0 Then
                MessageBox.Show("Debe ingresar el monto del Bono concepto correspondiente. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                blnerror = False
            Else
                If Val(Me.datFECHADESC.Text) <= 0 Then
                    MessageBox.Show("Debe ingresar la fecha del Arbitraje. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                    blnerror = False
                End If
            End If
        End If
        validarDescuento = blnerror
    End Function


    Private Sub txtOBSERVABONO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOBSERVABONO.TextChanged

    End Sub

    Private Sub txtOBSERVABONO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOBSERVABONO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TabMOVIMIENTO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabMOVIMIENTO.Click
    End Sub

    Private Sub CONCEPTODESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONCEPTODESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtMONTODESC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMONTODESC.TextChanged

    End Sub

    Private Sub txtMONTODESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMONTODESC.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtMONTODESC.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub datFECHADESC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datFECHADESC.ValueChanged

    End Sub

    Private Sub datFECHADESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datFECHADESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtDOCUMENTODESC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDOCUMENTODESC.TextChanged

    End Sub

    Private Sub txtDOCUMENTODESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDOCUMENTODESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub datFECHADOC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datFECHADOC.ValueChanged

    End Sub

    Private Sub datFECHADOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datFECHADOC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtNUMERODOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNUMERODOC.TextChanged

    End Sub

    Private Sub txtNUMERODOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNUMERODOC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtCUOTA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCUOTA.TextChanged

    End Sub

    Private Sub txtCUOTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCUOTA.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            txtCUOTA.Text = ""
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtOBSERVADESC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOBSERVADESC.TextChanged

    End Sub

    Private Sub txtOBSERVADESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOBSERVADESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaARBITRO(UCase(Trim(Me.txtbusqueda.Text)))
    End Sub
    Sub cargarGrillaARBITRO(ByVal auxnombre As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT arbcedula, arbnombre FROM arbitro order by arbnombre"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre like '%" & auxnombre & "%'", "arbnombre ASC", DataViewRowState.OriginalRows)
        Me.grdARBITRO.DataSource = dataviewLOCAL

    End Sub

    Private Sub chkBONO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBONO.CheckedChanged
        cargarMovimiento(wkarbcedula, 2)
    End Sub

    Private Sub chkDESCUENTO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDESCUENTO.CheckedChanged
        cargarMovimiento(wkarbcedula, 2)
    End Sub

    Private Sub txtANHOCON_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtANHOCON.TextChanged

    End Sub

    Private Sub txtANHOCON_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtANHOCON.DoubleClick
        If Val(Me.txtANHOCON.Text) = 0 Then
            Me.txtANHOCON.Text = Year(Now)
        Else
            Me.txtANHOCON.Text = 0
        End If
    End Sub

    Private Sub btnCONSULTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCONSULTAR.Click
        cargarEspecial(wkarbcedula)
    End Sub

    Private Sub grdMOVIMIENTO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdMOVIMIENTO.Navigate

    End Sub

    Sub cargarEspecial(ByVal wkarbcedula As Integer)
        If Not (Me.chkBONO.Checked = False And Me.chkDESCUENTO.Checked = False And Val(Me.txtANHOCON.Text) = 0 And Val(Me.txtMESCON.Text) = 0) Then
            Dim wktipo, wkfiltro, xfecha, yfecha As String
            Dim wkanho, xdia As Integer

            If Me.chkBONO.Checked = True Then
                wkfiltro = "WHERE movmensual.movtipo = 'B'"
            Else
                If Me.chkDESCUENTO.Checked = True Then
                    wkfiltro = "WHERE movmensual.movtipo = 'D'"
                End If
            End If
            If Val(Me.txtANHOCON.Text) = 0 Then
                wkanho = Year(Now)
            Else
                wkanho = Val(Me.txtANHOCON.Text)
            End If
            If Val(Me.txtMESCON.Text) = 0 Then
                xfecha = Trim(wkanho) & "/01/01"
                yfecha = Trim(wkanho) & "/12/31"
            Else
                Select Case Val(Me.txtMESCON.Text)
                    Case 1, 3, 5, 7, 8, 10, 12
                        xdia = 31
                    Case 4, 6, 9, 11
                        xdia = 30
                    Case 2
                        If (wkanho / 4) = Int(wkanho / 4) Then
                            xdia = 29
                        Else
                            xdia = 28

                        End If
                End Select
                xfecha = Trim(wkanho) & "/" & Trim(Val(Me.txtMESCON.Text)) & "/01"
                yfecha = Trim(wkanho) & "/" & Trim(Val(Me.txtMESCON.Text)) & "/" & Trim(xdia)

            End If
            If Len(Trim(wkfiltro)) = 0 Then
                wkfiltro = "WHERE movmensual.movfecha >= '" & xfecha & "' and movmensual.movfecha <= '" & yfecha & "'"
            Else
                wkfiltro = wkfiltro & " and movmensual.movfecha >= '" & xfecha & "' and movmensual.movfecha <= '" & yfecha & "'"
            End If
            Dim dataviewLOCAL As DataView
            dsDATOSM = New DataSet
            'FROM (movimiento INNER JOIN equipos ON movimiento.movequipo1 = equipos.codequipo) INNER JOIN equipos AS equipos_1 ON movimiento.movequipo1 = equipos_1.codequipo
            strSQL = "SELECT movfecha, connombre, movmonto, movtipo " & _
            "FROM movmensual INNER JOIN concepto ON movmensual.movconcepto = concepto.concodigo " & _
            wkfiltro & " and movcedula = " & wkarbcedula & " " & _
            "ORDER by movfecha DESC"

            Dim adDATOSM As New Odbc.OdbcDataAdapter
            adDATOSM.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            adDATOSM.Fill(dsDATOSM, "movimiento")

            dataviewLOCAL = New DataView(dsDATOSM.Tables("movimiento"), "connombre LIKE '%'", "movfecha DESC", DataViewRowState.OriginalRows)
            Me.grdMOVIMIENTO.DataSource = dataviewLOCAL
        End If
    End Sub
    Private Sub grdMOVIMIENTO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMOVIMIENTO.Click
        Dim fila, wkmonto, wkconcepto, wkdivision, wkequipo1, wkequipo2, wkmovid As Integer
        Dim wkfecha, wktipo As String

        fila = grdMOVIMIENTO.CurrentRowIndex
        wkfecha = Format(grdMOVIMIENTO.Item(fila, 0), "yyyy-MM-dd")
        wkmonto = grdMOVIMIENTO.Item(fila, 2)
        wktipo = Trim(grdMOVIMIENTO.Item(fila, 3))
        wkconcepto = traeconcepto(grdMOVIMIENTO.Item(fila, 1), wktipo)
        wkdivision = traedivision(wkconcepto)

        Integer.TryParse(Trim(grdMOVIMIENTO.Item(fila, 4)), wkequipo1)

        Integer.TryParse(Trim(grdMOVIMIENTO.Item(fila, 5)), wkequipo2)


        wkmovid = Trim(grdMOVIMIENTO.Item(fila, 6))
        '
        ' Estas varibles sirven para regrabar
        '
        AbrirConexion()
        Call cargarEquipos(wkdivision)
        CerrarConexion()

        glocedula = wkarbcedula
        glofecha = wkfecha
        glomonto = wkmonto
        glotipo = wktipo
        gloconcepto = wkconcepto
        glomovid = wkmovid

        If wkconcepto > 0 Then
            AbrirConexion()
            cargarPantalla(wkarbcedula, wkfecha, wkmonto, wkconcepto, wktipo, wkdivision, wkequipo1, wkequipo2)
            setEstiloMovimiento()
            CerrarConexion()
        End If

    End Sub
    Sub cargarPantalla(ByVal wkarbcedula As Integer, ByVal wkfecha As String, ByVal wkmonto As Integer, ByVal wkconcepto As Integer, ByVal wktipo As String, ByVal wkdivision As Integer, ByVal wkequipo1 As Integer, ByVal wkequipo2 As Integer)
        Try
            If wktipo = "B" Then
                strSQL = "SELECT movequipo1, movequipo2, movestadio, movgrupo, movtorneo, movfechapartida, movanho, movobservaciones from movmensual " & _
                         "where movcedula = " & wkarbcedula & " and " & _
                         "movfecha = '" & wkfecha & "' and " & _
                         "movmonto = " & wkmonto & " and " & _
                         "movconcepto = " & wkconcepto & " and " & _
                         "movtipo = 'B' and " & _
                         "movequipo1 = '" & wkequipo1 & "' and " & _
                         "movequipo2 = '" & wkequipo2 & "';"
                Me.TabMOVIMIENTO.SelectedIndex = 0
                AbrirConexion()
                Dim indice, auxequipo1, auxequipo2, auxestadio, auxgrupo, auxfechapartida, auxanho As Integer
                Dim auxtorneo, auxobservaciones As String
                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                While myReader.Read()
                    ' cargar los datos en pantalla desde el reader
                    With Me
                        .datFECHA.Value = wkfecha
                        .txtMONTO.Text = FormatNumber(wkmonto, 0, TriState.UseDefault)

                        For indice = 0 To Me.DIVISION.Items.Count - 1
                            If Val(Me.DIVISION.Items(indice)) = wkdivision Then
                                Me.DIVISION.SelectedIndex = indice
                                Exit For
                            End If
                        Next

                        For indice = 0 To Me.CONCEPTO.Items.Count - 1
                            If Val(Me.CONCEPTO.Items(indice)) = wkconcepto Then
                                Me.CONCEPTO.SelectedIndex = indice
                                Exit For
                            End If
                        Next

                        auxequipo1 = myReader.GetValue(0)
                        If auxequipo1 > 0 Then
                            For indice = 0 To Me.EQUIPO1.Items.Count - 1
                                If Val(Me.EQUIPO1.Items(indice)) = auxequipo1 Then
                                    Me.EQUIPO1.SelectedIndex = indice
                                    Exit For
                                End If
                            Next
                        End If

                        auxequipo2 = myReader.GetValue(1)
                        If auxequipo2 > 0 Then
                            For indice = 0 To Me.EQUIPO2.Items.Count - 1
                                If Val(Me.EQUIPO2.Items(indice)) = auxequipo2 Then
                                    Me.EQUIPO2.SelectedIndex = indice
                                    Exit For
                                End If
                            Next
                        End If

                        auxestadio = myReader.GetValue(2)
                        If auxestadio > 0 Then
                            For indice = 0 To Me.ESTADIO.Items.Count - 1
                                If Val(Me.ESTADIO.Items(indice)) = auxestadio Then
                                    Me.ESTADIO.SelectedIndex = indice
                                    Exit For
                                End If
                            Next
                        End If
                        auxgrupo = myReader.GetValue(3)
                        If Val(auxgrupo) > 0 Then
                            Me.txtGRUPO.Text = auxgrupo
                        Else
                            Me.txtGRUPO.Text = ""
                        End If

                        auxtorneo = myReader.GetString(4)
                        If Len(Trim(auxtorneo)) > 0 Then
                            Me.txtTORNEO.Text = auxtorneo
                        Else
                            Me.txtTORNEO.Text = ""
                        End If

                        auxfechapartida = myReader.GetValue(5)
                        If Val(auxfechapartida) > 0 Then
                            Me.txtFECHA.Text = auxfechapartida
                        Else
                            Me.txtFECHA.Text = ""
                        End If


                        auxanho = myReader.GetValue(6)
                        If Val(auxanho) > 0 Then
                            Me.txtANHO.Text = FormatNumber(auxanho, 0, TriState.UseDefault)
                        Else
                            Me.txtANHO.Text = ""
                        End If

                        If IsDBNull(myReader.GetString(7)) = False Then
                            auxobservaciones = myReader.GetString(7)
                            Me.txtOBSERVABONO.Text = auxobservaciones
                        Else
                            Me.txtOBSERVABONO.Text = ""
                        End If
                    End With
                End While
                myReader.Close()
                CerrarConexion()
            ElseIf wktipo = "D" Then
                strSQL = "SELECT movdocumento, movdocfecha, movdocnumero, movobservaciones, movcuota from movmensual " & _
                        "where movcedula = " & wkarbcedula & " and " & _
                        "movfecha = '" & wkfecha & "' and " & _
                        "movmonto = " & wkmonto & " and " & _
                        "movconcepto = " & wkconcepto & " and " & _
                        "movtipo = 'D'" & ";"
                Me.TabMOVIMIENTO.SelectedIndex = 1
                AbrirConexion()
                Dim indice, auxcuota As Integer
                Dim auxdocumento, auxdocfecha, auxdocnumero, auxobservaciones As String

                Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                While myReader.Read()
                    ' cargar los datos en pantalla desde el reader
                    With Me
                        .datFECHADESC.Value = wkfecha
                        .txtMONTODESC.Text = wkmonto
                        For indice = 0 To Me.CONCEPTODESC.Items.Count - 1
                            If Val(Me.CONCEPTODESC.Items(indice)) = wkconcepto Then
                                Me.CONCEPTODESC.SelectedIndex = indice
                                Exit For
                            End If
                        Next

                        'auxdocumento = myReader.GetString(0)
                        'If Not IsDBNull(auxdocumento) Then
                        If Not (myReader.IsDBNull(0)) Then
                            Me.txtDOCUMENTODESC.Text = myReader.GetString(0)
                        Else
                            Me.txtDOCUMENTODESC.Text = ""
                        End If

                        'auxdocfecha = myReader.GetString(1)
                        'If Not IsDBNull(auxdocfecha) Then
                        If Not (myReader.IsDBNull(1)) Then
                            Me.datFECHADOC.Text = myReader.GetString(1)
                        Else
                            Me.datFECHADOC.Text = ""
                        End If

                        'auxdocnumero = myReader.GetValue(2)
                        'If Not IsDBNull(auxdocnumero) Then
                        If Not (myReader.IsDBNull(2)) Then
                            auxdocnumero = myReader.GetString(2)
                            If Val(auxdocnumero) > 0 Then
                                Me.txtNUMERODOC.Text = auxdocnumero
                            Else
                                Me.txtNUMERODOC.Text = ""
                            End If
                        Else
                            Me.txtNUMERODOC.Text = ""
                        End If

                        If Not (myReader.IsDBNull(3)) Then
                            auxobservaciones = myReader.GetString(3)
                            Me.txtOBSERVADESC.Text = auxobservaciones
                        Else
                            Me.txtOBSERVADESC.Text = ""
                        End If

                        'auxcuota = myReader.GetValue(4)
                        If Not (myReader.IsDBNull(4)) Then
                            auxcuota = myReader.GetValue(4)
                            If Val(auxcuota) > 0 Then
                                Me.txtCUOTA.Text = auxcuota
                            Else
                                Me.txtCUOTA.Text = ""
                            End If
                        Else
                            Me.txtCUOTA.Text = ""
                        End If


                    End With


                End While
                myReader.Close()
                CerrarConexion()
            End If
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la lectura del registro.", MessageBoxButtons.OK)
        End Try
    End Sub

    Function traeconcepto(ByVal wkconcepto As String, ByVal wktipo As String) As Integer
        Dim auxconcepto As Integer
        AbrirConexion()
        strSQL = "SELECT concodigo, connombre from concepto where connombre = '" & wkconcepto & "'"
        Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
        Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        While myReader.Read()
            If IsDBNull(myReader.GetValue(0)) = False Then
                auxconcepto = Int(myReader.GetValue(0))
            End If
        End While
        myReader.Close()
        CerrarConexion()
        traeconcepto = auxconcepto
    End Function
    Function traedivision(ByVal wkconcepto As Integer) As Integer
        Dim auxdivision As Integer
        AbrirConexion()
        strSQL = "SELECT concodigo, condivcodigo from concepto where concodigo = " & wkconcepto & ""
        Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
        Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        While myReader.Read()
            If IsDBNull(myReader.GetValue(0)) = False Then
                auxdivision = Int(myReader.GetValue(1))
            End If
        End While
        myReader.Close()
        CerrarConexion()
        traedivision = auxdivision
    End Function

    Private Sub btnMODIFICARDESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARDESC.Click

    End Sub

    Private Sub btnELIMINARDEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARDEC.Click
        If Me.TabMOVIMIENTO.SelectedTab.Text Is "BONO" Then
            If wkarbcedula = 0 Then
                MessageBox.Show("Debe seleccionar el Arbitro primeramente. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
            Else
                If Val(Me.CONCEPTO.Text) <= 0 Then
                    MessageBox.Show("Debe seleccionar el Arbitro y el Movimiento para borrar. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                Else
                    If MessageBox.Show("Desea Borrar el Movimiento correspondiente", strSLOGAN, MessageBoxButtons.OKCancel) = DialogResult.OK Then
                        Dim wkconce, wkmonto As Integer
                        Dim wkfecha, wkequipo1, wkequipo2 As String
                        Try
                            wkconce = Val(Me.CONCEPTO.Text)
                            wkmonto = Val(Replace(Me.txtMONTO.Text, ".", ""))
                            wkfecha = Format(Me.datFECHA.Value, "yyyy-MM-dd")
                            wkequipo1 = Trim(Str(Val(Me.EQUIPO1.Text)))
                            wkequipo2 = Trim(Str(Val(Me.EQUIPO2.Text)))

                            AbrirConexion()
                            strSQL = "delete from movmensual  where movcedula = " & wkarbcedula & " and " & _
                                     "movconcepto = " & wkconce & " and movmonto = " & wkmonto & " and " & _
                                     "movfecha = '" & wkfecha & "' and movtipo = 'B'" & " and movequipo1 = '" & wkequipo1 & "' and " & _
                                     "movequipo2 = '" & wkequipo2 & "';"
                            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                            myCommand.ExecuteNonQuery()
                            myCommand.Dispose()

                            cargarMovimiento(wkarbcedula, 1)
                            setEstiloMovimiento()
                            CerrarConexion()

                            MessageBox.Show("Registro ha sido borrado con éxito. Verifiquelo!!!", strSLOGAN, MessageBoxButtons.OK)

                        Catch ex As Exception
                            MessageBox.Show("Error en el borrado de registro.", strSLOGAN, MessageBoxButtons.OK)
                        End Try
                    End If

                End If
            End If
        Else
            If wkarbcedula = 0 Then
                MessageBox.Show("Debe seleccionar el Arbitro primeramente. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
            Else
                If Val(Me.CONCEPTODESC.Text) <= 0 Then
                    MessageBox.Show("Debe seleccionar el Arbitro y el Movimiento para borrar. Verifiquelo!!", strSLOGAN, MessageBoxButtons.OK)
                Else
                    If MessageBox.Show("Desea Borrar el Movimiento correspondiente", strSLOGAN, MessageBoxButtons.OKCancel) = DialogResult.OK Then
                        Dim wkconce, wkmonto As Integer
                        Dim wkfecha As String
                        Try
                            wkconce = Val(Me.CONCEPTODESC.Text)
                            wkmonto = Val(Me.txtMONTODESC.Text)
                            wkfecha = Format(Me.datFECHADESC.Value, "yyyy-MM-dd")

                            AbrirConexion()
                            strSQL = "delete from movmensual  where movcedula = " & wkarbcedula & " and " & _
                                     "movconcepto = " & wkconce & " and movmonto = " & wkmonto & " and " & _
                                     "movfecha = '" & wkfecha & "' and movtipo = 'D'" & ""
                            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                            myCommand.ExecuteNonQuery()
                            myCommand.Dispose()
                            CerrarConexion()
                            MessageBox.Show("Registro ha sido borrado con éxito. Verifiquelo!!!", strSLOGAN, MessageBoxButtons.OK)

                        Catch ex As Exception
                            MessageBox.Show("Error en el borrado de registro.", strSLOGAN, MessageBoxButtons.OK)
                        End Try
                    End If

                End If
            End If

        End If
    End Sub

    Private Sub txtMESCON_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMESCON.TextChanged

    End Sub

    Private Sub txtMESCON_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMESCON.DoubleClick
        If Val(Me.txtMESCON.Text) = 0 Then
            Me.txtMESCON.Text = Month(Now)
        Else
            Me.txtMESCON.Text = 0
        End If

    End Sub

    Private Sub btnCANCELARDESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARDESC.Click
        limpiarBono()
        limpiarDescuento()
    End Sub

    Private Sub CONCEPTO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CONCEPTO.LostFocus
    End Sub
    Function asignaMONTO(ByVal intconcepto As Integer) As Integer
        Dim auxmonto As Integer
        AbrirConexion()
        strSQL = "SELECT conmonto from concepto where concodigo = " & intconcepto & ""
        Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
        Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        While myReader.Read()
            If IsDBNull(myReader.GetValue(0)) = False Then
                auxmonto = Int(myReader.GetValue(0))
            End If
        End While
        myReader.Close()
        CerrarConexion()
        asignaMONTO = auxmonto
    End Function

    Private Sub txtMONTO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMONTO.GotFocus
    End Sub

    Private Sub txtMONTO_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMONTO.Enter
        Dim intconcepto As Integer
        intconcepto = Val(Me.CONCEPTO.Text)
        If intconcepto > 0 Then
            Me.txtMONTO.Text = asignaMONTO(intconcepto)
        End If
    End Sub

    Private Sub CONCEPTODESC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONCEPTODESC.SelectedIndexChanged

    End Sub

    Private Sub txtMONTODESC_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMONTODESC.Enter
        Dim intconcepto As Integer
        intconcepto = Val(Me.CONCEPTODESC.Text)
        If intconcepto > 0 Then
            Me.txtMONTODESC.Text = asignaMONTO(intconcepto)
        End If

    End Sub

    Private Sub DIVISION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIVISION.SelectedIndexChanged

    End Sub

    Private Sub DIVISION_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DIVISION.LostFocus
        AbrirConexion()
        Call cargarEquipos(Val(Me.DIVISION.Text))
        CerrarConexion()
    End Sub

    Private Sub DIVISION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DIVISION.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter
        'Call cargarConcepto(0)
    End Sub

    Private Sub txtTORNEO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTORNEO.SelectedIndexChanged

    End Sub

    Private Sub txtTORNEO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTORNEO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMONTO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMONTO.Leave
        Me.txtMONTO.Text = FormatNumber(Me.txtMONTO.Text, 0, TriState.UseDefault)
    End Sub

    Private Sub txtANHO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtANHO.Leave
        Me.txtANHO.Text = FormatNumber(Me.txtANHO.Text, 0, TriState.UseDefault)
    End Sub

    Private Sub EQUIPO1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EQUIPO1.KeyDown
        'If e.KeyCode = Keys.F4 Then
        '    gloequipo = 0
        '    Dim frmNEW As New frmEQUIPOAYUDA
        '    frmNEW.ShowDialog()
        '    If gloequipo > 0 Then
        '        ' buscar en el combobox
        '    End If
        'End If
    End Sub

    Private Sub EQUIPO1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EQUIPO1.GotFocus
        gloequipo = 0
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        For Each drv As DataGridViewRow In dgvListaArbitros.Rows
            drv.Cells.Item("colSeleccionadoArbitro").Value = True
        Next
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For Each drv As DataGridViewRow In dgvListaArbitros.Rows
            drv.Cells.Item("colSeleccionadoArbitro").Value = False
        Next
    End Sub

    Private Sub btnAsignarDeudas_Click(sender As Object, e As EventArgs) Handles btnAsignarDeudas.Click
        AbrirConexion()

        For Each filaConceptos As DataGridViewRow In dgvListaConceptos.Rows
            For Each filaArbitros As DataGridViewRow In dgvListaArbitros.Rows

                If (filaConceptos.Cells.Item("colSeleccionadoDeuda").Value = True And filaArbitros.Cells.Item("colSeleccionadoArbitro").Value = True) Then
                    strSQL = "INSERT INTO deuda_apagar(concepto, monto_original, persona, saldo, fecha_alta)" & _
                              "VALUES (" & filaConceptos.Cells.Item("concodigo").Value & "," & filaConceptos.Cells.Item("conmonto").Value & "," & filaArbitros.Cells.Item("arbcedula").Value & "," & filaConceptos.Cells.Item("conmonto").Value & ",'" & Now.ToString("yyyy-MM-dd") & "')"


                    Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                End If
            Next

        Next
        CerrarConexion()
        MessageBox.Show("Los registros se cargaron de manera exitosa", strSLOGAN, MessageBoxButtons.OK)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            ''Me.Deuda_apagarTableAdapter.FillBy(Me.DataSet3.deuda_apagar)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DeudasApagarBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DeudasApagarBindingSource.CurrentChanged

    End Sub

    Private Sub btnDescontarPendientes_Click(sender As Object, e As EventArgs) Handles btnDescontarPendientes.Click


        For Each filaDeudas As DataGridViewRow In Me.grdDeudaApagar.Rows
            Dim aux As Integer
            If Not Integer.TryParse(filaDeudas.Cells.Item("aimputar").Value, aux) Then
                aux = -1
            End If
            If (aux > 0) Then

                grabarDescuento2(filaDeudas)

            End If
        Next


    End Sub
End Class

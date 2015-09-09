Public Class CRUDcodigos
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
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    Friend WithEvents tabCODIGOS As System.Windows.Forms.TabControl
    Friend WithEvents tabpCIUDAD As System.Windows.Forms.TabPage
    Friend WithEvents dtaCIUDAD As System.Windows.Forms.DataGrid
    Friend WithEvents btnVOLVER As System.Windows.Forms.Button
    Friend WithEvents lblCODIGOSCIUDAD As System.Windows.Forms.Label
    Friend WithEvents btnAGREGARCIUDAD As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARCIUDAD As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARCIUDAD As System.Windows.Forms.Button
    Friend WithEvents lblCODIGOCIUDAD As System.Windows.Forms.Label
    Friend WithEvents lblNOMBRECIUDAD As System.Windows.Forms.Label
    Friend WithEvents intCODIGOCIUDAD As System.Windows.Forms.TextBox
    Friend WithEvents txtDESCRIPCIONCIUDAD As System.Windows.Forms.TextBox
    Friend WithEvents btnCANCELARCIUDAD As System.Windows.Forms.Button
    Friend WithEvents pctboxLOGOTIPOCPAF As System.Windows.Forms.PictureBox
    Friend WithEvents lblBUSQUEDACIUDAD As System.Windows.Forms.Label
    Friend WithEvents lblFECHAHORA As System.Windows.Forms.Label
    Friend WithEvents lblUSUARIOACTUAL As System.Windows.Forms.Label
    Friend WithEvents lblUSUARIO As System.Windows.Forms.Label
    Friend WithEvents timerCIUDAD As System.Windows.Forms.Timer
    Friend WithEvents tabpIDIOMA As System.Windows.Forms.TabPage
    Friend WithEvents btnNUEVOCIUDAD As System.Windows.Forms.Button
    Friend WithEvents lblCODIGOSIDIOMA As System.Windows.Forms.Label
    Friend WithEvents timerIDIOMA As System.Windows.Forms.Timer
    Friend WithEvents lblNUEVOIDIOMA As System.Windows.Forms.Button
    Friend WithEvents lblBUSQUEDAIDIOMA As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARIDIOMA As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARIDIOMA As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARIDIOMA As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARIDIOMA As System.Windows.Forms.Button
    Friend WithEvents lblNOMBREIDIOMA As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOIDIOMA As System.Windows.Forms.Label
    Friend WithEvents txtBUSQUEDACIUDAD As System.Windows.Forms.TextBox
    Friend WithEvents dtaIDIOMA As System.Windows.Forms.DataGrid
    Friend WithEvents txtBUSQUEDAIDIOMA As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBREIDIOMA As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOIDIOMA As System.Windows.Forms.TextBox
    Friend WithEvents tabpcategoria As System.Windows.Forms.TabPage
    Friend WithEvents lblTITULOCATEGORIA As System.Windows.Forms.Label
    Friend WithEvents btnNUEVOCATEGORIA As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDACATEGORIA As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDACATEGORIA As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARCATEGORIA As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARCATEGORIA As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARCATEGORIA As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARCATEGORIA As System.Windows.Forms.Button
    Friend WithEvents dtaCATEGORIA As System.Windows.Forms.DataGrid
    Friend WithEvents txtNOMBRECATEGORIA As System.Windows.Forms.TextBox
    Friend WithEvents txtCODIGOCATEGORIA As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBRECATEGORIA As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOCATEGORIA As System.Windows.Forms.Label
    Friend WithEvents timerCATEGORIA As System.Windows.Forms.Timer
    Friend WithEvents lblNIVEL As System.Windows.Forms.Label
    Friend WithEvents txtNIVELCATEGORIA As System.Windows.Forms.TextBox
    Friend WithEvents tabpTIPODOCUMENTO As System.Windows.Forms.TabPage
    Friend WithEvents btnNUEVOTIPODOCUMENTO As System.Windows.Forms.Button
    Friend WithEvents lblBUSQUEDATIPODOCUMENTO As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARTIPODOCUMENTO As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARTIPODOCUMENTO As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARTIPODOCUMENTO As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARTIPODOCUMENTO As System.Windows.Forms.Button
    Friend WithEvents lblTITULOTIPODOCUMENTO As System.Windows.Forms.Label
    Friend WithEvents lblNOMBRETIPODOCUMENTO As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOTIPODOCUMENTO As System.Windows.Forms.Label
    Friend WithEvents txtBUSQUEDATIPODOCUMENTO As System.Windows.Forms.TextBox
    Friend WithEvents dtaTIPODOCUMENTO As System.Windows.Forms.DataGrid
    Friend WithEvents txtNOMBRETIPODOCUMENTO As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOTIPODOCUMENTO As System.Windows.Forms.TextBox
    Friend WithEvents timerTIPODOCUMENTO As System.Windows.Forms.Timer
    Friend WithEvents tabpparentesco As System.Windows.Forms.TabPage
    Friend WithEvents lblTITULOPARENTESCO As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARPARENTESCO As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARPARENTESCO As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARPARENTESCO As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARPARENTESCO As System.Windows.Forms.Button
    Friend WithEvents txtNOMBREPARENTESCO As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOPARENTESCO As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBREPARENTESCO As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOPARENTESCO As System.Windows.Forms.Label
    Friend WithEvents timerPARENTESCO As System.Windows.Forms.Timer
    Friend WithEvents btnNUEVOPARENTESCO As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDAPARENTESCO As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDAPARENTESCO As System.Windows.Forms.Label
    Friend WithEvents dtaPARENTESCO As System.Windows.Forms.DataGrid
    Friend WithEvents tabpPAIS As System.Windows.Forms.TabPage
    Friend WithEvents btnNUEVOPAIS As System.Windows.Forms.Button
    Friend WithEvents btnCANCELARPAIS As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARPAIS As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARPAIS As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARPAIS As System.Windows.Forms.Button
    Friend WithEvents lblTITULOPAIS As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREPAIS As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOPAIS As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBREPAIS As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOPAIS As System.Windows.Forms.Label
    Friend WithEvents timerPAIS As System.Windows.Forms.Timer
    Friend WithEvents txtBUSQUEDAPAIS As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDAPAIS As System.Windows.Forms.Label
    Friend WithEvents dtaPAIS As System.Windows.Forms.DataGrid
    Friend WithEvents tabpCONCEPTO As System.Windows.Forms.TabPage
    Friend WithEvents lblTITULOCONCEPTO As System.Windows.Forms.Label
    Friend WithEvents lblNOMBRECONCEPTO As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOCONCEPTO As System.Windows.Forms.Label
    Friend WithEvents lblNOMBREBREVECONCEPTO As System.Windows.Forms.Label
    Friend WithEvents btnNUEVOCONCEPTO As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDACONCEPTO As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDACONCEPTO As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARCONCEPTO As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARCONCEPTO As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARCONCEPTO As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARCONCEPTO As System.Windows.Forms.Button
    Friend WithEvents dtaCONCEPTO As System.Windows.Forms.DataGrid
    Friend WithEvents txtNOMBRECONCEPTO As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOCONCEPTO As System.Windows.Forms.TextBox
    Friend WithEvents timerCONCEPTO As System.Windows.Forms.Timer
    Friend WithEvents lblTIPO As System.Windows.Forms.Label
    Friend WithEvents cboBONODESCUENTOCONCEPTO As System.Windows.Forms.ComboBox
    Friend WithEvents lblMONTOCONCEPTO As System.Windows.Forms.Label
    Friend WithEvents intMONTOCONCEPTO As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBREBREVECONCEPTO As System.Windows.Forms.TextBox
    Friend WithEvents tabpEQUIPO As System.Windows.Forms.TabPage
    Friend WithEvents timerEQUIPO As System.Windows.Forms.Timer
    Friend WithEvents btnNUEVOEQUIPO As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDAEQUIPO As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDAEQUIPO As System.Windows.Forms.Label
    Friend WithEvents btnCANCELAREQUIPO As System.Windows.Forms.Button
    Friend WithEvents btnELIMINAREQUIPO As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICAREQUIPO As System.Windows.Forms.Button
    Friend WithEvents btnAGREGAREQUIPO As System.Windows.Forms.Button
    Friend WithEvents dtaEQUIPO As System.Windows.Forms.DataGrid
    Friend WithEvents lblTITULOEQUIPOS As System.Windows.Forms.Label
    Friend WithEvents intCODIGOEQUIPOS As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBREEQUIPOS As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOEQUIPOS As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREEQUIPOS As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBREBREVEEQUIPO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabpESTADIO As System.Windows.Forms.TabPage
    Friend WithEvents btnNUEVOESTADIO As System.Windows.Forms.Button
    Friend WithEvents lblTITULOESTADIO As System.Windows.Forms.Label
    Friend WithEvents intCODIGOESTADIO As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBREESTADIO As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOESTADIO As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARESTADIO As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARESTADIO As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARESTADIO As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARESTADIO As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDAESTADIO As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDAESTADIO As System.Windows.Forms.Label
    Friend WithEvents dtaESTADIO As System.Windows.Forms.DataGrid
    Friend WithEvents timerESTADIO As System.Windows.Forms.Timer
    Friend WithEvents txtNOMBREESTADIO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREBREVEESTADIO As System.Windows.Forms.TextBox
    Friend WithEvents tabpPROFESION As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnNUEVOPROFESION As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDAPROFESION As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDAPROFESION As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARPROFESION As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARPROFESION As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARPROFESION As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARPROFESION As System.Windows.Forms.Button
    Friend WithEvents dtaPROFESION As System.Windows.Forms.DataGrid
    Friend WithEvents lblTITULOPROFESION As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREPROFESION As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGOPROFESION As System.Windows.Forms.TextBox
    Friend WithEvents lblNOMBREPROFESION As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOPROFESION As System.Windows.Forms.Label
    Friend WithEvents timerPROFESION As System.Windows.Forms.Timer
    Friend WithEvents tabpmantcapital As System.Windows.Forms.TabPage
    Friend WithEvents lblMONTOFINALMANTENIMIENTOCAPITAL As System.Windows.Forms.Label
    Friend WithEvents lblTITULOMANTENIMIENTOCAPITAL As System.Windows.Forms.Label
    Friend WithEvents lblMONTOINICIALMANTENIMIENTOCAPITAL As System.Windows.Forms.Label
    Friend WithEvents lblCODIGOMANTENIMIENTOCAPITAL As System.Windows.Forms.Label
    Friend WithEvents intCODIGOMANTENIMIENTOCAPITAL As System.Windows.Forms.TextBox
    Friend WithEvents lblMONTOASIGNADOMANTENIMIENTOCAPITAL As System.Windows.Forms.Label
    Friend WithEvents intMONTOFINALMANTENIMIENTOCAPITAL As System.Windows.Forms.TextBox
    Friend WithEvents btnNUEVOMANTENIMIENTOCAPITAL As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARMANTENIMIENTOCAPITAL As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARMANTENIMIENTOCAPITAL As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARMANTENIMIENTOCAPITAL As System.Windows.Forms.Button
    Friend WithEvents dtaMANTENIMIENTOCAPITAL As System.Windows.Forms.DataGrid
    Friend WithEvents intMONTOINICIALMANTENIMIENTOCAPITAL As System.Windows.Forms.TextBox
    Friend WithEvents intMONTOASIGNADOMANTENIMIENTOCAPITAL As System.Windows.Forms.TextBox
    Friend WithEvents timerMANTENIMIENTOCAPITAL As System.Windows.Forms.Timer
    Friend WithEvents btnCANCELARMANTENIMIENTOCAPITAL As System.Windows.Forms.Button
    Friend WithEvents tabpDIVISION As System.Windows.Forms.TabPage
    Friend WithEvents btnNUEVODIVISIONES As System.Windows.Forms.Button
    Friend WithEvents txtBUSQUEDADIVISIONES As System.Windows.Forms.TextBox
    Friend WithEvents lblBUSQUEDADIVISIONES As System.Windows.Forms.Label
    Friend WithEvents btnCANCELARDIVISIONES As System.Windows.Forms.Button
    Friend WithEvents btnELIMINARDIVISIONES As System.Windows.Forms.Button
    Friend WithEvents btnMODIFICARDIVISIONES As System.Windows.Forms.Button
    Friend WithEvents btnAGREGARDIVISIONES As System.Windows.Forms.Button
    Friend WithEvents dtaDIVISIONES As System.Windows.Forms.DataGrid
    Friend WithEvents lblTITULODIVISIONES As System.Windows.Forms.Label
    Friend WithEvents lblNOMBRE As System.Windows.Forms.Label
    Friend WithEvents lblCODIGO As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREDIVISIONES As System.Windows.Forms.TextBox
    Friend WithEvents intCODIGODIVISIONES As System.Windows.Forms.TextBox
    Friend WithEvents timerDIVISIONES As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkdivision As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDcodigos))
        Me.pctboxLOGOTIPOCPAF = New System.Windows.Forms.PictureBox()
        Me.lblTITULO = New System.Windows.Forms.Label()
        Me.tabCODIGOS = New System.Windows.Forms.TabControl()
        Me.tabpCIUDAD = New System.Windows.Forms.TabPage()
        Me.btnNUEVOCIUDAD = New System.Windows.Forms.Button()
        Me.txtBUSQUEDACIUDAD = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDACIUDAD = New System.Windows.Forms.Label()
        Me.btnCANCELARCIUDAD = New System.Windows.Forms.Button()
        Me.btnELIMINARCIUDAD = New System.Windows.Forms.Button()
        Me.btnMODIFICARCIUDAD = New System.Windows.Forms.Button()
        Me.btnAGREGARCIUDAD = New System.Windows.Forms.Button()
        Me.dtaCIUDAD = New System.Windows.Forms.DataGrid()
        Me.lblCODIGOSCIUDAD = New System.Windows.Forms.Label()
        Me.txtDESCRIPCIONCIUDAD = New System.Windows.Forms.TextBox()
        Me.intCODIGOCIUDAD = New System.Windows.Forms.TextBox()
        Me.lblNOMBRECIUDAD = New System.Windows.Forms.Label()
        Me.lblCODIGOCIUDAD = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tabpEQUIPO = New System.Windows.Forms.TabPage()
        Me.chkdivision = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNOMBREBREVEEQUIPO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNUEVOEQUIPO = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAEQUIPO = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAEQUIPO = New System.Windows.Forms.Label()
        Me.btnCANCELAREQUIPO = New System.Windows.Forms.Button()
        Me.btnELIMINAREQUIPO = New System.Windows.Forms.Button()
        Me.btnMODIFICAREQUIPO = New System.Windows.Forms.Button()
        Me.btnAGREGAREQUIPO = New System.Windows.Forms.Button()
        Me.dtaEQUIPO = New System.Windows.Forms.DataGrid()
        Me.lblTITULOEQUIPOS = New System.Windows.Forms.Label()
        Me.txtNOMBREEQUIPOS = New System.Windows.Forms.TextBox()
        Me.intCODIGOEQUIPOS = New System.Windows.Forms.TextBox()
        Me.lblNOMBREEQUIPOS = New System.Windows.Forms.Label()
        Me.lblCODIGOEQUIPOS = New System.Windows.Forms.Label()
        Me.tabpPROFESION = New System.Windows.Forms.TabPage()
        Me.btnNUEVOPROFESION = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAPROFESION = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAPROFESION = New System.Windows.Forms.Label()
        Me.btnCANCELARPROFESION = New System.Windows.Forms.Button()
        Me.btnELIMINARPROFESION = New System.Windows.Forms.Button()
        Me.btnMODIFICARPROFESION = New System.Windows.Forms.Button()
        Me.btnAGREGARPROFESION = New System.Windows.Forms.Button()
        Me.dtaPROFESION = New System.Windows.Forms.DataGrid()
        Me.lblTITULOPROFESION = New System.Windows.Forms.Label()
        Me.txtNOMBREPROFESION = New System.Windows.Forms.TextBox()
        Me.intCODIGOPROFESION = New System.Windows.Forms.TextBox()
        Me.lblNOMBREPROFESION = New System.Windows.Forms.Label()
        Me.lblCODIGOPROFESION = New System.Windows.Forms.Label()
        Me.tabpIDIOMA = New System.Windows.Forms.TabPage()
        Me.lblNUEVOIDIOMA = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAIDIOMA = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAIDIOMA = New System.Windows.Forms.Label()
        Me.btnCANCELARIDIOMA = New System.Windows.Forms.Button()
        Me.btnELIMINARIDIOMA = New System.Windows.Forms.Button()
        Me.btnMODIFICARIDIOMA = New System.Windows.Forms.Button()
        Me.btnAGREGARIDIOMA = New System.Windows.Forms.Button()
        Me.dtaIDIOMA = New System.Windows.Forms.DataGrid()
        Me.txtNOMBREIDIOMA = New System.Windows.Forms.TextBox()
        Me.intCODIGOIDIOMA = New System.Windows.Forms.TextBox()
        Me.lblNOMBREIDIOMA = New System.Windows.Forms.Label()
        Me.lblCODIGOIDIOMA = New System.Windows.Forms.Label()
        Me.lblCODIGOSIDIOMA = New System.Windows.Forms.Label()
        Me.tabpDIVISION = New System.Windows.Forms.TabPage()
        Me.btnNUEVODIVISIONES = New System.Windows.Forms.Button()
        Me.txtBUSQUEDADIVISIONES = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDADIVISIONES = New System.Windows.Forms.Label()
        Me.btnCANCELARDIVISIONES = New System.Windows.Forms.Button()
        Me.btnELIMINARDIVISIONES = New System.Windows.Forms.Button()
        Me.btnMODIFICARDIVISIONES = New System.Windows.Forms.Button()
        Me.btnAGREGARDIVISIONES = New System.Windows.Forms.Button()
        Me.dtaDIVISIONES = New System.Windows.Forms.DataGrid()
        Me.lblTITULODIVISIONES = New System.Windows.Forms.Label()
        Me.txtNOMBREDIVISIONES = New System.Windows.Forms.TextBox()
        Me.intCODIGODIVISIONES = New System.Windows.Forms.TextBox()
        Me.lblNOMBRE = New System.Windows.Forms.Label()
        Me.lblCODIGO = New System.Windows.Forms.Label()
        Me.tabpparentesco = New System.Windows.Forms.TabPage()
        Me.btnNUEVOPARENTESCO = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAPARENTESCO = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAPARENTESCO = New System.Windows.Forms.Label()
        Me.btnCANCELARPARENTESCO = New System.Windows.Forms.Button()
        Me.btnELIMINARPARENTESCO = New System.Windows.Forms.Button()
        Me.btnMODIFICARPARENTESCO = New System.Windows.Forms.Button()
        Me.btnAGREGARPARENTESCO = New System.Windows.Forms.Button()
        Me.dtaPARENTESCO = New System.Windows.Forms.DataGrid()
        Me.lblTITULOPARENTESCO = New System.Windows.Forms.Label()
        Me.txtNOMBREPARENTESCO = New System.Windows.Forms.TextBox()
        Me.intCODIGOPARENTESCO = New System.Windows.Forms.TextBox()
        Me.lblNOMBREPARENTESCO = New System.Windows.Forms.Label()
        Me.lblCODIGOPARENTESCO = New System.Windows.Forms.Label()
        Me.tabpESTADIO = New System.Windows.Forms.TabPage()
        Me.txtNOMBREBREVEESTADIO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNUEVOESTADIO = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAESTADIO = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAESTADIO = New System.Windows.Forms.Label()
        Me.btnCANCELARESTADIO = New System.Windows.Forms.Button()
        Me.btnELIMINARESTADIO = New System.Windows.Forms.Button()
        Me.btnMODIFICARESTADIO = New System.Windows.Forms.Button()
        Me.btnAGREGARESTADIO = New System.Windows.Forms.Button()
        Me.dtaESTADIO = New System.Windows.Forms.DataGrid()
        Me.lblTITULOESTADIO = New System.Windows.Forms.Label()
        Me.txtNOMBREESTADIO = New System.Windows.Forms.TextBox()
        Me.intCODIGOESTADIO = New System.Windows.Forms.TextBox()
        Me.lblNOMBREESTADIO = New System.Windows.Forms.Label()
        Me.lblCODIGOESTADIO = New System.Windows.Forms.Label()
        Me.tabpPAIS = New System.Windows.Forms.TabPage()
        Me.btnNUEVOPAIS = New System.Windows.Forms.Button()
        Me.txtBUSQUEDAPAIS = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDAPAIS = New System.Windows.Forms.Label()
        Me.btnCANCELARPAIS = New System.Windows.Forms.Button()
        Me.btnELIMINARPAIS = New System.Windows.Forms.Button()
        Me.btnMODIFICARPAIS = New System.Windows.Forms.Button()
        Me.btnAGREGARPAIS = New System.Windows.Forms.Button()
        Me.dtaPAIS = New System.Windows.Forms.DataGrid()
        Me.lblTITULOPAIS = New System.Windows.Forms.Label()
        Me.txtNOMBREPAIS = New System.Windows.Forms.TextBox()
        Me.intCODIGOPAIS = New System.Windows.Forms.TextBox()
        Me.lblNOMBREPAIS = New System.Windows.Forms.Label()
        Me.lblCODIGOPAIS = New System.Windows.Forms.Label()
        Me.tabpTIPODOCUMENTO = New System.Windows.Forms.TabPage()
        Me.btnNUEVOTIPODOCUMENTO = New System.Windows.Forms.Button()
        Me.txtBUSQUEDATIPODOCUMENTO = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDATIPODOCUMENTO = New System.Windows.Forms.Label()
        Me.btnCANCELARTIPODOCUMENTO = New System.Windows.Forms.Button()
        Me.btnELIMINARTIPODOCUMENTO = New System.Windows.Forms.Button()
        Me.btnMODIFICARTIPODOCUMENTO = New System.Windows.Forms.Button()
        Me.btnAGREGARTIPODOCUMENTO = New System.Windows.Forms.Button()
        Me.dtaTIPODOCUMENTO = New System.Windows.Forms.DataGrid()
        Me.lblTITULOTIPODOCUMENTO = New System.Windows.Forms.Label()
        Me.txtNOMBRETIPODOCUMENTO = New System.Windows.Forms.TextBox()
        Me.intCODIGOTIPODOCUMENTO = New System.Windows.Forms.TextBox()
        Me.lblNOMBRETIPODOCUMENTO = New System.Windows.Forms.Label()
        Me.lblCODIGOTIPODOCUMENTO = New System.Windows.Forms.Label()
        Me.tabpCONCEPTO = New System.Windows.Forms.TabPage()
        Me.intMONTOCONCEPTO = New System.Windows.Forms.TextBox()
        Me.lblMONTOCONCEPTO = New System.Windows.Forms.Label()
        Me.cboBONODESCUENTOCONCEPTO = New System.Windows.Forms.ComboBox()
        Me.lblTIPO = New System.Windows.Forms.Label()
        Me.txtNOMBREBREVECONCEPTO = New System.Windows.Forms.TextBox()
        Me.lblNOMBREBREVECONCEPTO = New System.Windows.Forms.Label()
        Me.btnNUEVOCONCEPTO = New System.Windows.Forms.Button()
        Me.txtBUSQUEDACONCEPTO = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDACONCEPTO = New System.Windows.Forms.Label()
        Me.btnCANCELARCONCEPTO = New System.Windows.Forms.Button()
        Me.btnELIMINARCONCEPTO = New System.Windows.Forms.Button()
        Me.btnMODIFICARCONCEPTO = New System.Windows.Forms.Button()
        Me.btnAGREGARCONCEPTO = New System.Windows.Forms.Button()
        Me.dtaCONCEPTO = New System.Windows.Forms.DataGrid()
        Me.lblTITULOCONCEPTO = New System.Windows.Forms.Label()
        Me.txtNOMBRECONCEPTO = New System.Windows.Forms.TextBox()
        Me.intCODIGOCONCEPTO = New System.Windows.Forms.TextBox()
        Me.lblNOMBRECONCEPTO = New System.Windows.Forms.Label()
        Me.lblCODIGOCONCEPTO = New System.Windows.Forms.Label()
        Me.tabpcategoria = New System.Windows.Forms.TabPage()
        Me.txtNIVELCATEGORIA = New System.Windows.Forms.TextBox()
        Me.lblNIVEL = New System.Windows.Forms.Label()
        Me.btnNUEVOCATEGORIA = New System.Windows.Forms.Button()
        Me.txtBUSQUEDACATEGORIA = New System.Windows.Forms.TextBox()
        Me.lblBUSQUEDACATEGORIA = New System.Windows.Forms.Label()
        Me.btnCANCELARCATEGORIA = New System.Windows.Forms.Button()
        Me.btnELIMINARCATEGORIA = New System.Windows.Forms.Button()
        Me.btnMODIFICARCATEGORIA = New System.Windows.Forms.Button()
        Me.btnAGREGARCATEGORIA = New System.Windows.Forms.Button()
        Me.dtaCATEGORIA = New System.Windows.Forms.DataGrid()
        Me.lblTITULOCATEGORIA = New System.Windows.Forms.Label()
        Me.txtNOMBRECATEGORIA = New System.Windows.Forms.TextBox()
        Me.txtCODIGOCATEGORIA = New System.Windows.Forms.TextBox()
        Me.lblNOMBRECATEGORIA = New System.Windows.Forms.Label()
        Me.lblCODIGOCATEGORIA = New System.Windows.Forms.Label()
        Me.tabpmantcapital = New System.Windows.Forms.TabPage()
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL = New System.Windows.Forms.TextBox()
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL = New System.Windows.Forms.Label()
        Me.intMONTOFINALMANTENIMIENTOCAPITAL = New System.Windows.Forms.TextBox()
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL = New System.Windows.Forms.Label()
        Me.btnNUEVOMANTENIMIENTOCAPITAL = New System.Windows.Forms.Button()
        Me.btnCANCELARMANTENIMIENTOCAPITAL = New System.Windows.Forms.Button()
        Me.btnELIMINARMANTENIMIENTOCAPITAL = New System.Windows.Forms.Button()
        Me.btnMODIFICARMANTENIMIENTOCAPITAL = New System.Windows.Forms.Button()
        Me.btnAGREGARMANTENIMIENTOCAPITAL = New System.Windows.Forms.Button()
        Me.dtaMANTENIMIENTOCAPITAL = New System.Windows.Forms.DataGrid()
        Me.lblTITULOMANTENIMIENTOCAPITAL = New System.Windows.Forms.Label()
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL = New System.Windows.Forms.TextBox()
        Me.intCODIGOMANTENIMIENTOCAPITAL = New System.Windows.Forms.TextBox()
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL = New System.Windows.Forms.Label()
        Me.lblCODIGOMANTENIMIENTOCAPITAL = New System.Windows.Forms.Label()
        Me.btnVOLVER = New System.Windows.Forms.Button()
        Me.lblFECHAHORA = New System.Windows.Forms.Label()
        Me.timerCIUDAD = New System.Windows.Forms.Timer(Me.components)
        Me.lblUSUARIOACTUAL = New System.Windows.Forms.Label()
        Me.lblUSUARIO = New System.Windows.Forms.Label()
        Me.timerIDIOMA = New System.Windows.Forms.Timer(Me.components)
        Me.timerCATEGORIA = New System.Windows.Forms.Timer(Me.components)
        Me.timerTIPODOCUMENTO = New System.Windows.Forms.Timer(Me.components)
        Me.timerPARENTESCO = New System.Windows.Forms.Timer(Me.components)
        Me.timerPAIS = New System.Windows.Forms.Timer(Me.components)
        Me.timerCONCEPTO = New System.Windows.Forms.Timer(Me.components)
        Me.timerEQUIPO = New System.Windows.Forms.Timer(Me.components)
        Me.timerESTADIO = New System.Windows.Forms.Timer(Me.components)
        Me.timerPROFESION = New System.Windows.Forms.Timer(Me.components)
        Me.timerMANTENIMIENTOCAPITAL = New System.Windows.Forms.Timer(Me.components)
        Me.timerDIVISIONES = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctboxLOGOTIPOCPAF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCODIGOS.SuspendLayout()
        Me.tabpCIUDAD.SuspendLayout()
        CType(Me.dtaCIUDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpEQUIPO.SuspendLayout()
        CType(Me.dtaEQUIPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpPROFESION.SuspendLayout()
        CType(Me.dtaPROFESION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpIDIOMA.SuspendLayout()
        CType(Me.dtaIDIOMA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpDIVISION.SuspendLayout()
        CType(Me.dtaDIVISIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpparentesco.SuspendLayout()
        CType(Me.dtaPARENTESCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpESTADIO.SuspendLayout()
        CType(Me.dtaESTADIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpPAIS.SuspendLayout()
        CType(Me.dtaPAIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpTIPODOCUMENTO.SuspendLayout()
        CType(Me.dtaTIPODOCUMENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpCONCEPTO.SuspendLayout()
        CType(Me.dtaCONCEPTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpcategoria.SuspendLayout()
        CType(Me.dtaCATEGORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpmantcapital.SuspendLayout()
        CType(Me.dtaMANTENIMIENTOCAPITAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctboxLOGOTIPOCPAF
        '
        Me.pctboxLOGOTIPOCPAF.Image = CType(resources.GetObject("pctboxLOGOTIPOCPAF.Image"), System.Drawing.Image)
        Me.pctboxLOGOTIPOCPAF.Location = New System.Drawing.Point(32, 16)
        Me.pctboxLOGOTIPOCPAF.Name = "pctboxLOGOTIPOCPAF"
        Me.pctboxLOGOTIPOCPAF.Size = New System.Drawing.Size(184, 168)
        Me.pctboxLOGOTIPOCPAF.TabIndex = 0
        Me.pctboxLOGOTIPOCPAF.TabStop = False
        '
        'lblTITULO
        '
        Me.lblTITULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(240, 16)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(752, 32)
        Me.lblTITULO.TabIndex = 3
        Me.lblTITULO.Text = "Módulo de administración de códigos del sistema Delta"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCODIGOS
        '
        Me.tabCODIGOS.Controls.Add(Me.tabpCIUDAD)
        Me.tabCODIGOS.Controls.Add(Me.tabpEQUIPO)
        Me.tabCODIGOS.Controls.Add(Me.tabpPROFESION)
        Me.tabCODIGOS.Controls.Add(Me.tabpIDIOMA)
        Me.tabCODIGOS.Controls.Add(Me.tabpDIVISION)
        Me.tabCODIGOS.Controls.Add(Me.tabpparentesco)
        Me.tabCODIGOS.Controls.Add(Me.tabpESTADIO)
        Me.tabCODIGOS.Controls.Add(Me.tabpPAIS)
        Me.tabCODIGOS.Controls.Add(Me.tabpTIPODOCUMENTO)
        Me.tabCODIGOS.Controls.Add(Me.tabpCONCEPTO)
        Me.tabCODIGOS.Controls.Add(Me.tabpcategoria)
        Me.tabCODIGOS.Controls.Add(Me.tabpmantcapital)
        Me.tabCODIGOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabCODIGOS.Location = New System.Drawing.Point(0, 184)
        Me.tabCODIGOS.Name = "tabCODIGOS"
        Me.tabCODIGOS.SelectedIndex = 0
        Me.tabCODIGOS.Size = New System.Drawing.Size(992, 520)
        Me.tabCODIGOS.TabIndex = 0
        '
        'tabpCIUDAD
        '
        Me.tabpCIUDAD.BackColor = System.Drawing.SystemColors.Control
        Me.tabpCIUDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpCIUDAD.Controls.Add(Me.btnNUEVOCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.txtBUSQUEDACIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.lblBUSQUEDACIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.btnCANCELARCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.btnELIMINARCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.btnMODIFICARCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.btnAGREGARCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.dtaCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.lblCODIGOSCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.txtDESCRIPCIONCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.intCODIGOCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.lblNOMBRECIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.lblCODIGOCIUDAD)
        Me.tabpCIUDAD.Controls.Add(Me.Button1)
        Me.tabpCIUDAD.Controls.Add(Me.Label4)
        Me.tabpCIUDAD.Controls.Add(Me.Label6)
        Me.tabpCIUDAD.Controls.Add(Me.Button3)
        Me.tabpCIUDAD.Controls.Add(Me.Button4)
        Me.tabpCIUDAD.Controls.Add(Me.Button5)
        Me.tabpCIUDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpCIUDAD.Location = New System.Drawing.Point(4, 22)
        Me.tabpCIUDAD.Name = "tabpCIUDAD"
        Me.tabpCIUDAD.Size = New System.Drawing.Size(952, 494)
        Me.tabpCIUDAD.TabIndex = 0
        Me.tabpCIUDAD.Text = "Códigos de ciudad"
        '
        'btnNUEVOCIUDAD
        '
        Me.btnNUEVOCIUDAD.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOCIUDAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOCIUDAD.Location = New System.Drawing.Point(672, 88)
        Me.btnNUEVOCIUDAD.Name = "btnNUEVOCIUDAD"
        Me.btnNUEVOCIUDAD.Size = New System.Drawing.Size(104, 56)
        Me.btnNUEVOCIUDAD.TabIndex = 11
        Me.btnNUEVOCIUDAD.Text = "&Nuevo Registro"
        Me.btnNUEVOCIUDAD.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDACIUDAD
        '
        Me.txtBUSQUEDACIUDAD.AcceptsReturn = True
        Me.txtBUSQUEDACIUDAD.AcceptsTab = True
        Me.txtBUSQUEDACIUDAD.Location = New System.Drawing.Point(296, 184)
        Me.txtBUSQUEDACIUDAD.Name = "txtBUSQUEDACIUDAD"
        Me.txtBUSQUEDACIUDAD.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDACIUDAD.TabIndex = 6
        '
        'lblBUSQUEDACIUDAD
        '
        Me.lblBUSQUEDACIUDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDACIUDAD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDACIUDAD.Location = New System.Drawing.Point(96, 184)
        Me.lblBUSQUEDACIUDAD.Name = "lblBUSQUEDACIUDAD"
        Me.lblBUSQUEDACIUDAD.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDACIUDAD.TabIndex = 10
        Me.lblBUSQUEDACIUDAD.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDACIUDAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARCIUDAD
        '
        Me.btnCANCELARCIUDAD.Location = New System.Drawing.Point(504, 136)
        Me.btnCANCELARCIUDAD.Name = "btnCANCELARCIUDAD"
        Me.btnCANCELARCIUDAD.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARCIUDAD.TabIndex = 5
        Me.btnCANCELARCIUDAD.Text = "&Cancelar"
        '
        'btnELIMINARCIUDAD
        '
        Me.btnELIMINARCIUDAD.Location = New System.Drawing.Point(368, 136)
        Me.btnELIMINARCIUDAD.Name = "btnELIMINARCIUDAD"
        Me.btnELIMINARCIUDAD.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARCIUDAD.TabIndex = 4
        Me.btnELIMINARCIUDAD.Text = "&Eliminar"
        '
        'btnMODIFICARCIUDAD
        '
        Me.btnMODIFICARCIUDAD.Location = New System.Drawing.Point(232, 136)
        Me.btnMODIFICARCIUDAD.Name = "btnMODIFICARCIUDAD"
        Me.btnMODIFICARCIUDAD.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARCIUDAD.TabIndex = 3
        Me.btnMODIFICARCIUDAD.Text = "&Modificar"
        '
        'btnAGREGARCIUDAD
        '
        Me.btnAGREGARCIUDAD.Location = New System.Drawing.Point(96, 136)
        Me.btnAGREGARCIUDAD.Name = "btnAGREGARCIUDAD"
        Me.btnAGREGARCIUDAD.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARCIUDAD.TabIndex = 2
        Me.btnAGREGARCIUDAD.Text = "&Agregar"
        '
        'dtaCIUDAD
        '
        Me.dtaCIUDAD.DataMember = ""
        Me.dtaCIUDAD.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaCIUDAD.Location = New System.Drawing.Point(88, 216)
        Me.dtaCIUDAD.Name = "dtaCIUDAD"
        Me.dtaCIUDAD.Size = New System.Drawing.Size(744, 240)
        Me.dtaCIUDAD.TabIndex = 7
        '
        'lblCODIGOSCIUDAD
        '
        Me.lblCODIGOSCIUDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOSCIUDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOSCIUDAD.Location = New System.Drawing.Point(96, 16)
        Me.lblCODIGOSCIUDAD.Name = "lblCODIGOSCIUDAD"
        Me.lblCODIGOSCIUDAD.Size = New System.Drawing.Size(736, 32)
        Me.lblCODIGOSCIUDAD.TabIndex = 10
        Me.lblCODIGOSCIUDAD.Text = "CÓDIGOS DE CIUDAD"
        Me.lblCODIGOSCIUDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDESCRIPCIONCIUDAD
        '
        Me.txtDESCRIPCIONCIUDAD.AcceptsReturn = True
        Me.txtDESCRIPCIONCIUDAD.AcceptsTab = True
        Me.txtDESCRIPCIONCIUDAD.Location = New System.Drawing.Point(240, 96)
        Me.txtDESCRIPCIONCIUDAD.MaxLength = 50
        Me.txtDESCRIPCIONCIUDAD.Name = "txtDESCRIPCIONCIUDAD"
        Me.txtDESCRIPCIONCIUDAD.Size = New System.Drawing.Size(392, 26)
        Me.txtDESCRIPCIONCIUDAD.TabIndex = 1
        '
        'intCODIGOCIUDAD
        '
        Me.intCODIGOCIUDAD.AcceptsReturn = True
        Me.intCODIGOCIUDAD.AcceptsTab = True
        Me.intCODIGOCIUDAD.Location = New System.Drawing.Point(240, 64)
        Me.intCODIGOCIUDAD.MaxLength = 4
        Me.intCODIGOCIUDAD.Name = "intCODIGOCIUDAD"
        Me.intCODIGOCIUDAD.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOCIUDAD.TabIndex = 0
        '
        'lblNOMBRECIUDAD
        '
        Me.lblNOMBRECIUDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBRECIUDAD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBRECIUDAD.Location = New System.Drawing.Point(104, 96)
        Me.lblNOMBRECIUDAD.Name = "lblNOMBRECIUDAD"
        Me.lblNOMBRECIUDAD.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBRECIUDAD.TabIndex = 9
        Me.lblNOMBRECIUDAD.Text = "Nombre(50): "
        Me.lblNOMBRECIUDAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOCIUDAD
        '
        Me.lblCODIGOCIUDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOCIUDAD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOCIUDAD.Location = New System.Drawing.Point(104, 64)
        Me.lblCODIGOCIUDAD.Name = "lblCODIGOCIUDAD"
        Me.lblCODIGOCIUDAD.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOCIUDAD.TabIndex = 8
        Me.lblCODIGOCIUDAD.Text = "Código(4): "
        Me.lblCODIGOCIUDAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Agregar"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(736, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Códigos de ciudad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(104, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Búsqueda por nombre: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Modificar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&Cancelar"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(368, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "&Eliminar"
        '
        'tabpEQUIPO
        '
        Me.tabpEQUIPO.BackColor = System.Drawing.SystemColors.Control
        Me.tabpEQUIPO.Controls.Add(Me.chkdivision)
        Me.tabpEQUIPO.Controls.Add(Me.Label3)
        Me.tabpEQUIPO.Controls.Add(Me.txtNOMBREBREVEEQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.Label1)
        Me.tabpEQUIPO.Controls.Add(Me.btnNUEVOEQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.txtBUSQUEDAEQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.lblBUSQUEDAEQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.btnCANCELAREQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.btnELIMINAREQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.btnMODIFICAREQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.btnAGREGAREQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.dtaEQUIPO)
        Me.tabpEQUIPO.Controls.Add(Me.lblTITULOEQUIPOS)
        Me.tabpEQUIPO.Controls.Add(Me.txtNOMBREEQUIPOS)
        Me.tabpEQUIPO.Controls.Add(Me.intCODIGOEQUIPOS)
        Me.tabpEQUIPO.Controls.Add(Me.lblNOMBREEQUIPOS)
        Me.tabpEQUIPO.Controls.Add(Me.lblCODIGOEQUIPOS)
        Me.tabpEQUIPO.Location = New System.Drawing.Point(4, 22)
        Me.tabpEQUIPO.Name = "tabpEQUIPO"
        Me.tabpEQUIPO.Size = New System.Drawing.Size(984, 494)
        Me.tabpEQUIPO.TabIndex = 7
        Me.tabpEQUIPO.Text = "Códigos de equipo"
        '
        'chkdivision
        '
        Me.chkdivision.CheckOnClick = True
        Me.chkdivision.Location = New System.Drawing.Point(256, 160)
        Me.chkdivision.Name = "chkdivision"
        Me.chkdivision.Size = New System.Drawing.Size(392, 79)
        Me.chkdivision.TabIndex = 33
        Me.chkdivision.ThreeDCheckBoxes = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(80, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Categoría: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNOMBREBREVEEQUIPO
        '
        Me.txtNOMBREBREVEEQUIPO.AcceptsReturn = True
        Me.txtNOMBREBREVEEQUIPO.AcceptsTab = True
        Me.txtNOMBREBREVEEQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREBREVEEQUIPO.Location = New System.Drawing.Point(256, 128)
        Me.txtNOMBREBREVEEQUIPO.MaxLength = 25
        Me.txtNOMBREBREVEEQUIPO.Name = "txtNOMBREBREVEEQUIPO"
        Me.txtNOMBREBREVEEQUIPO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREBREVEEQUIPO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(80, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre breve(25): "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNUEVOEQUIPO
        '
        Me.btnNUEVOEQUIPO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOEQUIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOEQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOEQUIPO.Location = New System.Drawing.Point(720, 88)
        Me.btnNUEVOEQUIPO.Name = "btnNUEVOEQUIPO"
        Me.btnNUEVOEQUIPO.Size = New System.Drawing.Size(108, 56)
        Me.btnNUEVOEQUIPO.TabIndex = 8
        Me.btnNUEVOEQUIPO.Text = "&Nuevo Registro"
        Me.btnNUEVOEQUIPO.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAEQUIPO
        '
        Me.txtBUSQUEDAEQUIPO.AcceptsReturn = True
        Me.txtBUSQUEDAEQUIPO.AcceptsTab = True
        Me.txtBUSQUEDAEQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDAEQUIPO.Location = New System.Drawing.Point(304, 288)
        Me.txtBUSQUEDAEQUIPO.Name = "txtBUSQUEDAEQUIPO"
        Me.txtBUSQUEDAEQUIPO.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAEQUIPO.TabIndex = 9
        '
        'lblBUSQUEDAEQUIPO
        '
        Me.lblBUSQUEDAEQUIPO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAEQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAEQUIPO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAEQUIPO.Location = New System.Drawing.Point(104, 288)
        Me.lblBUSQUEDAEQUIPO.Name = "lblBUSQUEDAEQUIPO"
        Me.lblBUSQUEDAEQUIPO.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAEQUIPO.TabIndex = 23
        Me.lblBUSQUEDAEQUIPO.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAEQUIPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELAREQUIPO
        '
        Me.btnCANCELAREQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELAREQUIPO.Location = New System.Drawing.Point(512, 248)
        Me.btnCANCELAREQUIPO.Name = "btnCANCELAREQUIPO"
        Me.btnCANCELAREQUIPO.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELAREQUIPO.TabIndex = 7
        Me.btnCANCELAREQUIPO.Text = "&Cancelar"
        '
        'btnELIMINAREQUIPO
        '
        Me.btnELIMINAREQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAREQUIPO.Location = New System.Drawing.Point(376, 248)
        Me.btnELIMINAREQUIPO.Name = "btnELIMINAREQUIPO"
        Me.btnELIMINAREQUIPO.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINAREQUIPO.TabIndex = 6
        Me.btnELIMINAREQUIPO.Text = "&Eliminar"
        '
        'btnMODIFICAREQUIPO
        '
        Me.btnMODIFICAREQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAREQUIPO.Location = New System.Drawing.Point(240, 248)
        Me.btnMODIFICAREQUIPO.Name = "btnMODIFICAREQUIPO"
        Me.btnMODIFICAREQUIPO.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICAREQUIPO.TabIndex = 5
        Me.btnMODIFICAREQUIPO.Text = "&Modificar"
        '
        'btnAGREGAREQUIPO
        '
        Me.btnAGREGAREQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAREQUIPO.Location = New System.Drawing.Point(104, 248)
        Me.btnAGREGAREQUIPO.Name = "btnAGREGAREQUIPO"
        Me.btnAGREGAREQUIPO.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGAREQUIPO.TabIndex = 4
        Me.btnAGREGAREQUIPO.Text = "&Agregar"
        '
        'dtaEQUIPO
        '
        Me.dtaEQUIPO.DataMember = ""
        Me.dtaEQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaEQUIPO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaEQUIPO.Location = New System.Drawing.Point(100, 320)
        Me.dtaEQUIPO.Name = "dtaEQUIPO"
        Me.dtaEQUIPO.ReadOnly = True
        Me.dtaEQUIPO.Size = New System.Drawing.Size(744, 168)
        Me.dtaEQUIPO.TabIndex = 9
        '
        'lblTITULOEQUIPOS
        '
        Me.lblTITULOEQUIPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOEQUIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOEQUIPOS.Location = New System.Drawing.Point(80, 15)
        Me.lblTITULOEQUIPOS.Name = "lblTITULOEQUIPOS"
        Me.lblTITULOEQUIPOS.Size = New System.Drawing.Size(760, 32)
        Me.lblTITULOEQUIPOS.TabIndex = 22
        Me.lblTITULOEQUIPOS.Text = "CÓDIGOS DE EQUIPOS"
        Me.lblTITULOEQUIPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREEQUIPOS
        '
        Me.txtNOMBREEQUIPOS.AcceptsReturn = True
        Me.txtNOMBREEQUIPOS.AcceptsTab = True
        Me.txtNOMBREEQUIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREEQUIPOS.Location = New System.Drawing.Point(256, 96)
        Me.txtNOMBREEQUIPOS.MaxLength = 50
        Me.txtNOMBREEQUIPOS.Name = "txtNOMBREEQUIPOS"
        Me.txtNOMBREEQUIPOS.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREEQUIPOS.TabIndex = 1
        '
        'intCODIGOEQUIPOS
        '
        Me.intCODIGOEQUIPOS.AcceptsReturn = True
        Me.intCODIGOEQUIPOS.AcceptsTab = True
        Me.intCODIGOEQUIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOEQUIPOS.Location = New System.Drawing.Point(256, 64)
        Me.intCODIGOEQUIPOS.MaxLength = 4
        Me.intCODIGOEQUIPOS.Name = "intCODIGOEQUIPOS"
        Me.intCODIGOEQUIPOS.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOEQUIPOS.TabIndex = 0
        '
        'lblNOMBREEQUIPOS
        '
        Me.lblNOMBREEQUIPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREEQUIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREEQUIPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREEQUIPOS.Location = New System.Drawing.Point(80, 96)
        Me.lblNOMBREEQUIPOS.Name = "lblNOMBREEQUIPOS"
        Me.lblNOMBREEQUIPOS.Size = New System.Drawing.Size(160, 23)
        Me.lblNOMBREEQUIPOS.TabIndex = 21
        Me.lblNOMBREEQUIPOS.Text = "Nombre(50): "
        Me.lblNOMBREEQUIPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOEQUIPOS
        '
        Me.lblCODIGOEQUIPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOEQUIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOEQUIPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOEQUIPOS.Location = New System.Drawing.Point(80, 64)
        Me.lblCODIGOEQUIPOS.Name = "lblCODIGOEQUIPOS"
        Me.lblCODIGOEQUIPOS.Size = New System.Drawing.Size(160, 23)
        Me.lblCODIGOEQUIPOS.TabIndex = 20
        Me.lblCODIGOEQUIPOS.Text = "Código(4): "
        Me.lblCODIGOEQUIPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpPROFESION
        '
        Me.tabpPROFESION.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpPROFESION.Controls.Add(Me.btnNUEVOPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.txtBUSQUEDAPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.lblBUSQUEDAPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.btnCANCELARPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.btnELIMINARPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.btnMODIFICARPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.btnAGREGARPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.dtaPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.lblTITULOPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.txtNOMBREPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.intCODIGOPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.lblNOMBREPROFESION)
        Me.tabpPROFESION.Controls.Add(Me.lblCODIGOPROFESION)
        Me.tabpPROFESION.Location = New System.Drawing.Point(4, 22)
        Me.tabpPROFESION.Name = "tabpPROFESION"
        Me.tabpPROFESION.Size = New System.Drawing.Size(952, 494)
        Me.tabpPROFESION.TabIndex = 9
        Me.tabpPROFESION.Text = "Código de profesion"
        '
        'btnNUEVOPROFESION
        '
        Me.btnNUEVOPROFESION.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOPROFESION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOPROFESION.Location = New System.Drawing.Point(728, 72)
        Me.btnNUEVOPROFESION.Name = "btnNUEVOPROFESION"
        Me.btnNUEVOPROFESION.Size = New System.Drawing.Size(104, 56)
        Me.btnNUEVOPROFESION.TabIndex = 22
        Me.btnNUEVOPROFESION.Text = "&Nuevo Registro"
        Me.btnNUEVOPROFESION.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAPROFESION
        '
        Me.txtBUSQUEDAPROFESION.AcceptsReturn = True
        Me.txtBUSQUEDAPROFESION.AcceptsTab = True
        Me.txtBUSQUEDAPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDAPROFESION.Location = New System.Drawing.Point(304, 184)
        Me.txtBUSQUEDAPROFESION.Name = "txtBUSQUEDAPROFESION"
        Me.txtBUSQUEDAPROFESION.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAPROFESION.TabIndex = 23
        '
        'lblBUSQUEDAPROFESION
        '
        Me.lblBUSQUEDAPROFESION.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAPROFESION.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAPROFESION.Location = New System.Drawing.Point(104, 184)
        Me.lblBUSQUEDAPROFESION.Name = "lblBUSQUEDAPROFESION"
        Me.lblBUSQUEDAPROFESION.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAPROFESION.TabIndex = 29
        Me.lblBUSQUEDAPROFESION.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAPROFESION.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARPROFESION
        '
        Me.btnCANCELARPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARPROFESION.Location = New System.Drawing.Point(512, 136)
        Me.btnCANCELARPROFESION.Name = "btnCANCELARPROFESION"
        Me.btnCANCELARPROFESION.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARPROFESION.TabIndex = 21
        Me.btnCANCELARPROFESION.Text = "&Cancelar"
        '
        'btnELIMINARPROFESION
        '
        Me.btnELIMINARPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARPROFESION.Location = New System.Drawing.Point(376, 136)
        Me.btnELIMINARPROFESION.Name = "btnELIMINARPROFESION"
        Me.btnELIMINARPROFESION.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARPROFESION.TabIndex = 20
        Me.btnELIMINARPROFESION.Text = "&Eliminar"
        '
        'btnMODIFICARPROFESION
        '
        Me.btnMODIFICARPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARPROFESION.Location = New System.Drawing.Point(240, 136)
        Me.btnMODIFICARPROFESION.Name = "btnMODIFICARPROFESION"
        Me.btnMODIFICARPROFESION.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARPROFESION.TabIndex = 19
        Me.btnMODIFICARPROFESION.Text = "&Modificar"
        '
        'btnAGREGARPROFESION
        '
        Me.btnAGREGARPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARPROFESION.Location = New System.Drawing.Point(104, 136)
        Me.btnAGREGARPROFESION.Name = "btnAGREGARPROFESION"
        Me.btnAGREGARPROFESION.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARPROFESION.TabIndex = 18
        Me.btnAGREGARPROFESION.Text = "&Agregar"
        '
        'dtaPROFESION
        '
        Me.dtaPROFESION.DataMember = ""
        Me.dtaPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaPROFESION.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaPROFESION.Location = New System.Drawing.Point(100, 224)
        Me.dtaPROFESION.Name = "dtaPROFESION"
        Me.dtaPROFESION.ReadOnly = True
        Me.dtaPROFESION.Size = New System.Drawing.Size(744, 232)
        Me.dtaPROFESION.TabIndex = 24
        '
        'lblTITULOPROFESION
        '
        Me.lblTITULOPROFESION.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOPROFESION.Location = New System.Drawing.Point(104, 15)
        Me.lblTITULOPROFESION.Name = "lblTITULOPROFESION"
        Me.lblTITULOPROFESION.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOPROFESION.TabIndex = 25
        Me.lblTITULOPROFESION.Text = "CÓDIGOS DE PROFESIÓN"
        Me.lblTITULOPROFESION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREPROFESION
        '
        Me.txtNOMBREPROFESION.AcceptsReturn = True
        Me.txtNOMBREPROFESION.AcceptsTab = True
        Me.txtNOMBREPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREPROFESION.Location = New System.Drawing.Point(236, 96)
        Me.txtNOMBREPROFESION.MaxLength = 50
        Me.txtNOMBREPROFESION.Name = "txtNOMBREPROFESION"
        Me.txtNOMBREPROFESION.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREPROFESION.TabIndex = 16
        '
        'intCODIGOPROFESION
        '
        Me.intCODIGOPROFESION.AcceptsReturn = True
        Me.intCODIGOPROFESION.AcceptsTab = True
        Me.intCODIGOPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOPROFESION.Location = New System.Drawing.Point(236, 64)
        Me.intCODIGOPROFESION.MaxLength = 4
        Me.intCODIGOPROFESION.Name = "intCODIGOPROFESION"
        Me.intCODIGOPROFESION.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOPROFESION.TabIndex = 15
        '
        'lblNOMBREPROFESION
        '
        Me.lblNOMBREPROFESION.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREPROFESION.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREPROFESION.Location = New System.Drawing.Point(112, 96)
        Me.lblNOMBREPROFESION.Name = "lblNOMBREPROFESION"
        Me.lblNOMBREPROFESION.Size = New System.Drawing.Size(112, 23)
        Me.lblNOMBREPROFESION.TabIndex = 27
        Me.lblNOMBREPROFESION.Text = "Nombre(30): "
        Me.lblNOMBREPROFESION.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOPROFESION
        '
        Me.lblCODIGOPROFESION.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOPROFESION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOPROFESION.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOPROFESION.Location = New System.Drawing.Point(136, 64)
        Me.lblCODIGOPROFESION.Name = "lblCODIGOPROFESION"
        Me.lblCODIGOPROFESION.Size = New System.Drawing.Size(88, 23)
        Me.lblCODIGOPROFESION.TabIndex = 26
        Me.lblCODIGOPROFESION.Text = "Código(4): "
        Me.lblCODIGOPROFESION.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpIDIOMA
        '
        Me.tabpIDIOMA.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpIDIOMA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpIDIOMA.Controls.Add(Me.lblNUEVOIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.txtBUSQUEDAIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.lblBUSQUEDAIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.btnCANCELARIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.btnELIMINARIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.btnMODIFICARIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.btnAGREGARIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.dtaIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.txtNOMBREIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.intCODIGOIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.lblNOMBREIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.lblCODIGOIDIOMA)
        Me.tabpIDIOMA.Controls.Add(Me.lblCODIGOSIDIOMA)
        Me.tabpIDIOMA.Location = New System.Drawing.Point(4, 22)
        Me.tabpIDIOMA.Name = "tabpIDIOMA"
        Me.tabpIDIOMA.Size = New System.Drawing.Size(952, 494)
        Me.tabpIDIOMA.TabIndex = 1
        Me.tabpIDIOMA.Text = "Códigos de idioma"
        '
        'lblNUEVOIDIOMA
        '
        Me.lblNUEVOIDIOMA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblNUEVOIDIOMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNUEVOIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUEVOIDIOMA.Location = New System.Drawing.Point(664, 88)
        Me.lblNUEVOIDIOMA.Name = "lblNUEVOIDIOMA"
        Me.lblNUEVOIDIOMA.Size = New System.Drawing.Size(104, 56)
        Me.lblNUEVOIDIOMA.TabIndex = 23
        Me.lblNUEVOIDIOMA.Text = "&Nuevo Registro"
        Me.lblNUEVOIDIOMA.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAIDIOMA
        '
        Me.txtBUSQUEDAIDIOMA.AcceptsReturn = True
        Me.txtBUSQUEDAIDIOMA.AcceptsTab = True
        Me.txtBUSQUEDAIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDAIDIOMA.Location = New System.Drawing.Point(296, 184)
        Me.txtBUSQUEDAIDIOMA.Name = "txtBUSQUEDAIDIOMA"
        Me.txtBUSQUEDAIDIOMA.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAIDIOMA.TabIndex = 18
        '
        'lblBUSQUEDAIDIOMA
        '
        Me.lblBUSQUEDAIDIOMA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAIDIOMA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAIDIOMA.Location = New System.Drawing.Point(96, 184)
        Me.lblBUSQUEDAIDIOMA.Name = "lblBUSQUEDAIDIOMA"
        Me.lblBUSQUEDAIDIOMA.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAIDIOMA.TabIndex = 22
        Me.lblBUSQUEDAIDIOMA.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAIDIOMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARIDIOMA
        '
        Me.btnCANCELARIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARIDIOMA.Location = New System.Drawing.Point(504, 136)
        Me.btnCANCELARIDIOMA.Name = "btnCANCELARIDIOMA"
        Me.btnCANCELARIDIOMA.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARIDIOMA.TabIndex = 17
        Me.btnCANCELARIDIOMA.Text = "&Cancelar"
        '
        'btnELIMINARIDIOMA
        '
        Me.btnELIMINARIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARIDIOMA.Location = New System.Drawing.Point(368, 136)
        Me.btnELIMINARIDIOMA.Name = "btnELIMINARIDIOMA"
        Me.btnELIMINARIDIOMA.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARIDIOMA.TabIndex = 16
        Me.btnELIMINARIDIOMA.Text = "&Eliminar"
        '
        'btnMODIFICARIDIOMA
        '
        Me.btnMODIFICARIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARIDIOMA.Location = New System.Drawing.Point(232, 136)
        Me.btnMODIFICARIDIOMA.Name = "btnMODIFICARIDIOMA"
        Me.btnMODIFICARIDIOMA.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARIDIOMA.TabIndex = 15
        Me.btnMODIFICARIDIOMA.Text = "&Modificar"
        '
        'btnAGREGARIDIOMA
        '
        Me.btnAGREGARIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARIDIOMA.Location = New System.Drawing.Point(96, 136)
        Me.btnAGREGARIDIOMA.Name = "btnAGREGARIDIOMA"
        Me.btnAGREGARIDIOMA.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARIDIOMA.TabIndex = 14
        Me.btnAGREGARIDIOMA.Text = "&Agregar"
        '
        'dtaIDIOMA
        '
        Me.dtaIDIOMA.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaIDIOMA.DataMember = ""
        Me.dtaIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaIDIOMA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaIDIOMA.Location = New System.Drawing.Point(88, 216)
        Me.dtaIDIOMA.Name = "dtaIDIOMA"
        Me.dtaIDIOMA.Size = New System.Drawing.Size(688, 240)
        Me.dtaIDIOMA.TabIndex = 19
        '
        'txtNOMBREIDIOMA
        '
        Me.txtNOMBREIDIOMA.AcceptsReturn = True
        Me.txtNOMBREIDIOMA.AcceptsTab = True
        Me.txtNOMBREIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREIDIOMA.Location = New System.Drawing.Point(240, 96)
        Me.txtNOMBREIDIOMA.MaxLength = 50
        Me.txtNOMBREIDIOMA.Name = "txtNOMBREIDIOMA"
        Me.txtNOMBREIDIOMA.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREIDIOMA.TabIndex = 13
        '
        'intCODIGOIDIOMA
        '
        Me.intCODIGOIDIOMA.AcceptsReturn = True
        Me.intCODIGOIDIOMA.AcceptsTab = True
        Me.intCODIGOIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOIDIOMA.Location = New System.Drawing.Point(240, 64)
        Me.intCODIGOIDIOMA.MaxLength = 4
        Me.intCODIGOIDIOMA.Name = "intCODIGOIDIOMA"
        Me.intCODIGOIDIOMA.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOIDIOMA.TabIndex = 12
        '
        'lblNOMBREIDIOMA
        '
        Me.lblNOMBREIDIOMA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREIDIOMA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREIDIOMA.Location = New System.Drawing.Point(96, 96)
        Me.lblNOMBREIDIOMA.Name = "lblNOMBREIDIOMA"
        Me.lblNOMBREIDIOMA.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBREIDIOMA.TabIndex = 21
        Me.lblNOMBREIDIOMA.Text = "Nombre(50): "
        Me.lblNOMBREIDIOMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOIDIOMA
        '
        Me.lblCODIGOIDIOMA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOIDIOMA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOIDIOMA.Location = New System.Drawing.Point(96, 64)
        Me.lblCODIGOIDIOMA.Name = "lblCODIGOIDIOMA"
        Me.lblCODIGOIDIOMA.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOIDIOMA.TabIndex = 20
        Me.lblCODIGOIDIOMA.Text = "Código(4): "
        Me.lblCODIGOIDIOMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOSIDIOMA
        '
        Me.lblCODIGOSIDIOMA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOSIDIOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOSIDIOMA.Location = New System.Drawing.Point(96, 16)
        Me.lblCODIGOSIDIOMA.Name = "lblCODIGOSIDIOMA"
        Me.lblCODIGOSIDIOMA.Size = New System.Drawing.Size(736, 32)
        Me.lblCODIGOSIDIOMA.TabIndex = 11
        Me.lblCODIGOSIDIOMA.Text = "CÓDIGOS DE IDIOMA"
        Me.lblCODIGOSIDIOMA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabpDIVISION
        '
        Me.tabpDIVISION.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpDIVISION.Controls.Add(Me.btnNUEVODIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.txtBUSQUEDADIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.lblBUSQUEDADIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.btnCANCELARDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.btnELIMINARDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.btnMODIFICARDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.btnAGREGARDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.dtaDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.lblTITULODIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.txtNOMBREDIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.intCODIGODIVISIONES)
        Me.tabpDIVISION.Controls.Add(Me.lblNOMBRE)
        Me.tabpDIVISION.Controls.Add(Me.lblCODIGO)
        Me.tabpDIVISION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpDIVISION.Location = New System.Drawing.Point(4, 22)
        Me.tabpDIVISION.Name = "tabpDIVISION"
        Me.tabpDIVISION.Size = New System.Drawing.Size(952, 494)
        Me.tabpDIVISION.TabIndex = 11
        Me.tabpDIVISION.Text = "Divisiones"
        '
        'btnNUEVODIVISIONES
        '
        Me.btnNUEVODIVISIONES.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVODIVISIONES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVODIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVODIVISIONES.Location = New System.Drawing.Point(720, 56)
        Me.btnNUEVODIVISIONES.Name = "btnNUEVODIVISIONES"
        Me.btnNUEVODIVISIONES.Size = New System.Drawing.Size(104, 56)
        Me.btnNUEVODIVISIONES.TabIndex = 24
        Me.btnNUEVODIVISIONES.Text = "&Nuevo Registro"
        Me.btnNUEVODIVISIONES.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDADIVISIONES
        '
        Me.txtBUSQUEDADIVISIONES.AcceptsReturn = True
        Me.txtBUSQUEDADIVISIONES.AcceptsTab = True
        Me.txtBUSQUEDADIVISIONES.Location = New System.Drawing.Point(312, 184)
        Me.txtBUSQUEDADIVISIONES.Name = "txtBUSQUEDADIVISIONES"
        Me.txtBUSQUEDADIVISIONES.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDADIVISIONES.TabIndex = 18
        '
        'lblBUSQUEDADIVISIONES
        '
        Me.lblBUSQUEDADIVISIONES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDADIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDADIVISIONES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDADIVISIONES.Location = New System.Drawing.Point(112, 184)
        Me.lblBUSQUEDADIVISIONES.Name = "lblBUSQUEDADIVISIONES"
        Me.lblBUSQUEDADIVISIONES.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDADIVISIONES.TabIndex = 23
        Me.lblBUSQUEDADIVISIONES.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDADIVISIONES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARDIVISIONES
        '
        Me.btnCANCELARDIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARDIVISIONES.Location = New System.Drawing.Point(520, 136)
        Me.btnCANCELARDIVISIONES.Name = "btnCANCELARDIVISIONES"
        Me.btnCANCELARDIVISIONES.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARDIVISIONES.TabIndex = 17
        Me.btnCANCELARDIVISIONES.Text = "&Cancelar"
        '
        'btnELIMINARDIVISIONES
        '
        Me.btnELIMINARDIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARDIVISIONES.Location = New System.Drawing.Point(384, 136)
        Me.btnELIMINARDIVISIONES.Name = "btnELIMINARDIVISIONES"
        Me.btnELIMINARDIVISIONES.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARDIVISIONES.TabIndex = 16
        Me.btnELIMINARDIVISIONES.Text = "&Eliminar"
        '
        'btnMODIFICARDIVISIONES
        '
        Me.btnMODIFICARDIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARDIVISIONES.Location = New System.Drawing.Point(248, 136)
        Me.btnMODIFICARDIVISIONES.Name = "btnMODIFICARDIVISIONES"
        Me.btnMODIFICARDIVISIONES.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARDIVISIONES.TabIndex = 15
        Me.btnMODIFICARDIVISIONES.Text = "&Modificar"
        '
        'btnAGREGARDIVISIONES
        '
        Me.btnAGREGARDIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARDIVISIONES.Location = New System.Drawing.Point(112, 136)
        Me.btnAGREGARDIVISIONES.Name = "btnAGREGARDIVISIONES"
        Me.btnAGREGARDIVISIONES.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARDIVISIONES.TabIndex = 14
        Me.btnAGREGARDIVISIONES.Text = "&Agregar"
        '
        'dtaDIVISIONES
        '
        Me.dtaDIVISIONES.DataMember = ""
        Me.dtaDIVISIONES.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaDIVISIONES.Location = New System.Drawing.Point(104, 216)
        Me.dtaDIVISIONES.Name = "dtaDIVISIONES"
        Me.dtaDIVISIONES.Size = New System.Drawing.Size(744, 240)
        Me.dtaDIVISIONES.TabIndex = 19
        '
        'lblTITULODIVISIONES
        '
        Me.lblTITULODIVISIONES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULODIVISIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULODIVISIONES.Location = New System.Drawing.Point(112, 16)
        Me.lblTITULODIVISIONES.Name = "lblTITULODIVISIONES"
        Me.lblTITULODIVISIONES.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULODIVISIONES.TabIndex = 22
        Me.lblTITULODIVISIONES.Text = "CÓDIGOS DE DIVISIONES"
        Me.lblTITULODIVISIONES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREDIVISIONES
        '
        Me.txtNOMBREDIVISIONES.AcceptsReturn = True
        Me.txtNOMBREDIVISIONES.AcceptsTab = True
        Me.txtNOMBREDIVISIONES.Location = New System.Drawing.Point(256, 96)
        Me.txtNOMBREDIVISIONES.MaxLength = 50
        Me.txtNOMBREDIVISIONES.Name = "txtNOMBREDIVISIONES"
        Me.txtNOMBREDIVISIONES.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREDIVISIONES.TabIndex = 13
        '
        'intCODIGODIVISIONES
        '
        Me.intCODIGODIVISIONES.AcceptsReturn = True
        Me.intCODIGODIVISIONES.AcceptsTab = True
        Me.intCODIGODIVISIONES.Location = New System.Drawing.Point(256, 64)
        Me.intCODIGODIVISIONES.MaxLength = 2
        Me.intCODIGODIVISIONES.Name = "intCODIGODIVISIONES"
        Me.intCODIGODIVISIONES.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGODIVISIONES.TabIndex = 12
        '
        'lblNOMBRE
        '
        Me.lblNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBRE.Location = New System.Drawing.Point(120, 96)
        Me.lblNOMBRE.Name = "lblNOMBRE"
        Me.lblNOMBRE.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBRE.TabIndex = 21
        Me.lblNOMBRE.Text = "Nombre(50): "
        Me.lblNOMBRE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGO
        '
        Me.lblCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGO.Location = New System.Drawing.Point(120, 64)
        Me.lblCODIGO.Name = "lblCODIGO"
        Me.lblCODIGO.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGO.TabIndex = 20
        Me.lblCODIGO.Text = "Código(2): "
        Me.lblCODIGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpparentesco
        '
        Me.tabpparentesco.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpparentesco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpparentesco.Controls.Add(Me.btnNUEVOPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.txtBUSQUEDAPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.lblBUSQUEDAPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.btnCANCELARPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.btnELIMINARPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.btnMODIFICARPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.btnAGREGARPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.dtaPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.lblTITULOPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.txtNOMBREPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.intCODIGOPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.lblNOMBREPARENTESCO)
        Me.tabpparentesco.Controls.Add(Me.lblCODIGOPARENTESCO)
        Me.tabpparentesco.Location = New System.Drawing.Point(4, 22)
        Me.tabpparentesco.Name = "tabpparentesco"
        Me.tabpparentesco.Size = New System.Drawing.Size(952, 494)
        Me.tabpparentesco.TabIndex = 4
        Me.tabpparentesco.Text = "Código de parentesco"
        '
        'btnNUEVOPARENTESCO
        '
        Me.btnNUEVOPARENTESCO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOPARENTESCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOPARENTESCO.Location = New System.Drawing.Point(712, 64)
        Me.btnNUEVOPARENTESCO.Name = "btnNUEVOPARENTESCO"
        Me.btnNUEVOPARENTESCO.Size = New System.Drawing.Size(102, 56)
        Me.btnNUEVOPARENTESCO.TabIndex = 24
        Me.btnNUEVOPARENTESCO.Text = "&Nuevo Registro"
        Me.btnNUEVOPARENTESCO.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAPARENTESCO
        '
        Me.txtBUSQUEDAPARENTESCO.AcceptsReturn = True
        Me.txtBUSQUEDAPARENTESCO.AcceptsTab = True
        Me.txtBUSQUEDAPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDAPARENTESCO.Location = New System.Drawing.Point(306, 176)
        Me.txtBUSQUEDAPARENTESCO.Name = "txtBUSQUEDAPARENTESCO"
        Me.txtBUSQUEDAPARENTESCO.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAPARENTESCO.TabIndex = 18
        '
        'lblBUSQUEDAPARENTESCO
        '
        Me.lblBUSQUEDAPARENTESCO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAPARENTESCO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAPARENTESCO.Location = New System.Drawing.Point(106, 176)
        Me.lblBUSQUEDAPARENTESCO.Name = "lblBUSQUEDAPARENTESCO"
        Me.lblBUSQUEDAPARENTESCO.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAPARENTESCO.TabIndex = 23
        Me.lblBUSQUEDAPARENTESCO.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAPARENTESCO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARPARENTESCO
        '
        Me.btnCANCELARPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARPARENTESCO.Location = New System.Drawing.Point(514, 128)
        Me.btnCANCELARPARENTESCO.Name = "btnCANCELARPARENTESCO"
        Me.btnCANCELARPARENTESCO.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARPARENTESCO.TabIndex = 17
        Me.btnCANCELARPARENTESCO.Text = "&Cancelar"
        '
        'btnELIMINARPARENTESCO
        '
        Me.btnELIMINARPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARPARENTESCO.Location = New System.Drawing.Point(378, 128)
        Me.btnELIMINARPARENTESCO.Name = "btnELIMINARPARENTESCO"
        Me.btnELIMINARPARENTESCO.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARPARENTESCO.TabIndex = 16
        Me.btnELIMINARPARENTESCO.Text = "&Eliminar"
        '
        'btnMODIFICARPARENTESCO
        '
        Me.btnMODIFICARPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARPARENTESCO.Location = New System.Drawing.Point(242, 128)
        Me.btnMODIFICARPARENTESCO.Name = "btnMODIFICARPARENTESCO"
        Me.btnMODIFICARPARENTESCO.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARPARENTESCO.TabIndex = 15
        Me.btnMODIFICARPARENTESCO.Text = "&Modificar"
        '
        'btnAGREGARPARENTESCO
        '
        Me.btnAGREGARPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARPARENTESCO.Location = New System.Drawing.Point(106, 128)
        Me.btnAGREGARPARENTESCO.Name = "btnAGREGARPARENTESCO"
        Me.btnAGREGARPARENTESCO.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARPARENTESCO.TabIndex = 14
        Me.btnAGREGARPARENTESCO.Text = "&Agregar"
        '
        'dtaPARENTESCO
        '
        Me.dtaPARENTESCO.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaPARENTESCO.DataMember = ""
        Me.dtaPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaPARENTESCO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaPARENTESCO.Location = New System.Drawing.Point(98, 208)
        Me.dtaPARENTESCO.Name = "dtaPARENTESCO"
        Me.dtaPARENTESCO.Size = New System.Drawing.Size(744, 240)
        Me.dtaPARENTESCO.TabIndex = 19
        '
        'lblTITULOPARENTESCO
        '
        Me.lblTITULOPARENTESCO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOPARENTESCO.Location = New System.Drawing.Point(106, 13)
        Me.lblTITULOPARENTESCO.Name = "lblTITULOPARENTESCO"
        Me.lblTITULOPARENTESCO.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOPARENTESCO.TabIndex = 22
        Me.lblTITULOPARENTESCO.Text = "CÓDIGOS DE PARENTESCO"
        Me.lblTITULOPARENTESCO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREPARENTESCO
        '
        Me.txtNOMBREPARENTESCO.AcceptsReturn = True
        Me.txtNOMBREPARENTESCO.AcceptsTab = True
        Me.txtNOMBREPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREPARENTESCO.Location = New System.Drawing.Point(250, 88)
        Me.txtNOMBREPARENTESCO.MaxLength = 50
        Me.txtNOMBREPARENTESCO.Name = "txtNOMBREPARENTESCO"
        Me.txtNOMBREPARENTESCO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREPARENTESCO.TabIndex = 13
        '
        'intCODIGOPARENTESCO
        '
        Me.intCODIGOPARENTESCO.AcceptsReturn = True
        Me.intCODIGOPARENTESCO.AcceptsTab = True
        Me.intCODIGOPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOPARENTESCO.Location = New System.Drawing.Point(250, 56)
        Me.intCODIGOPARENTESCO.MaxLength = 4
        Me.intCODIGOPARENTESCO.Name = "intCODIGOPARENTESCO"
        Me.intCODIGOPARENTESCO.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOPARENTESCO.TabIndex = 12
        '
        'lblNOMBREPARENTESCO
        '
        Me.lblNOMBREPARENTESCO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREPARENTESCO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREPARENTESCO.Location = New System.Drawing.Point(106, 88)
        Me.lblNOMBREPARENTESCO.Name = "lblNOMBREPARENTESCO"
        Me.lblNOMBREPARENTESCO.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBREPARENTESCO.TabIndex = 21
        Me.lblNOMBREPARENTESCO.Text = "Nombre(50): "
        Me.lblNOMBREPARENTESCO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOPARENTESCO
        '
        Me.lblCODIGOPARENTESCO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOPARENTESCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOPARENTESCO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOPARENTESCO.Location = New System.Drawing.Point(106, 56)
        Me.lblCODIGOPARENTESCO.Name = "lblCODIGOPARENTESCO"
        Me.lblCODIGOPARENTESCO.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOPARENTESCO.TabIndex = 20
        Me.lblCODIGOPARENTESCO.Text = "Código(4): "
        Me.lblCODIGOPARENTESCO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpESTADIO
        '
        Me.tabpESTADIO.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpESTADIO.Controls.Add(Me.txtNOMBREBREVEESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.Label2)
        Me.tabpESTADIO.Controls.Add(Me.btnNUEVOESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.txtBUSQUEDAESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.lblBUSQUEDAESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.btnCANCELARESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.btnELIMINARESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.btnMODIFICARESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.btnAGREGARESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.dtaESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.lblTITULOESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.txtNOMBREESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.intCODIGOESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.lblNOMBREESTADIO)
        Me.tabpESTADIO.Controls.Add(Me.lblCODIGOESTADIO)
        Me.tabpESTADIO.Location = New System.Drawing.Point(4, 22)
        Me.tabpESTADIO.Name = "tabpESTADIO"
        Me.tabpESTADIO.Size = New System.Drawing.Size(952, 494)
        Me.tabpESTADIO.TabIndex = 8
        Me.tabpESTADIO.Text = "Códigos de estadio"
        '
        'txtNOMBREBREVEESTADIO
        '
        Me.txtNOMBREBREVEESTADIO.AcceptsReturn = True
        Me.txtNOMBREBREVEESTADIO.AcceptsTab = True
        Me.txtNOMBREBREVEESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREBREVEESTADIO.Location = New System.Drawing.Point(256, 128)
        Me.txtNOMBREBREVEESTADIO.MaxLength = 25
        Me.txtNOMBREBREVEESTADIO.Name = "txtNOMBREBREVEESTADIO"
        Me.txtNOMBREBREVEESTADIO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREBREVEESTADIO.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(88, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre breve(25): "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNUEVOESTADIO
        '
        Me.btnNUEVOESTADIO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOESTADIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOESTADIO.Location = New System.Drawing.Point(720, 72)
        Me.btnNUEVOESTADIO.Name = "btnNUEVOESTADIO"
        Me.btnNUEVOESTADIO.Size = New System.Drawing.Size(104, 56)
        Me.btnNUEVOESTADIO.TabIndex = 7
        Me.btnNUEVOESTADIO.Text = "&Nuevo Registro"
        Me.btnNUEVOESTADIO.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAESTADIO
        '
        Me.txtBUSQUEDAESTADIO.AcceptsReturn = True
        Me.txtBUSQUEDAESTADIO.AcceptsTab = True
        Me.txtBUSQUEDAESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDAESTADIO.Location = New System.Drawing.Point(308, 208)
        Me.txtBUSQUEDAESTADIO.Name = "txtBUSQUEDAESTADIO"
        Me.txtBUSQUEDAESTADIO.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAESTADIO.TabIndex = 8
        '
        'lblBUSQUEDAESTADIO
        '
        Me.lblBUSQUEDAESTADIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAESTADIO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAESTADIO.Location = New System.Drawing.Point(108, 208)
        Me.lblBUSQUEDAESTADIO.Name = "lblBUSQUEDAESTADIO"
        Me.lblBUSQUEDAESTADIO.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAESTADIO.TabIndex = 23
        Me.lblBUSQUEDAESTADIO.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAESTADIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARESTADIO
        '
        Me.btnCANCELARESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARESTADIO.Location = New System.Drawing.Point(516, 168)
        Me.btnCANCELARESTADIO.Name = "btnCANCELARESTADIO"
        Me.btnCANCELARESTADIO.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARESTADIO.TabIndex = 6
        Me.btnCANCELARESTADIO.Text = "&Cancelar"
        '
        'btnELIMINARESTADIO
        '
        Me.btnELIMINARESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARESTADIO.Location = New System.Drawing.Point(380, 168)
        Me.btnELIMINARESTADIO.Name = "btnELIMINARESTADIO"
        Me.btnELIMINARESTADIO.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARESTADIO.TabIndex = 5
        Me.btnELIMINARESTADIO.Text = "&Eliminar"
        '
        'btnMODIFICARESTADIO
        '
        Me.btnMODIFICARESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARESTADIO.Location = New System.Drawing.Point(244, 168)
        Me.btnMODIFICARESTADIO.Name = "btnMODIFICARESTADIO"
        Me.btnMODIFICARESTADIO.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARESTADIO.TabIndex = 4
        Me.btnMODIFICARESTADIO.Text = "&Modificar"
        '
        'btnAGREGARESTADIO
        '
        Me.btnAGREGARESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARESTADIO.Location = New System.Drawing.Point(108, 168)
        Me.btnAGREGARESTADIO.Name = "btnAGREGARESTADIO"
        Me.btnAGREGARESTADIO.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARESTADIO.TabIndex = 3
        Me.btnAGREGARESTADIO.Text = "&Agregar"
        '
        'dtaESTADIO
        '
        Me.dtaESTADIO.DataMember = ""
        Me.dtaESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaESTADIO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaESTADIO.Location = New System.Drawing.Point(100, 240)
        Me.dtaESTADIO.Name = "dtaESTADIO"
        Me.dtaESTADIO.Size = New System.Drawing.Size(744, 200)
        Me.dtaESTADIO.TabIndex = 9
        '
        'lblTITULOESTADIO
        '
        Me.lblTITULOESTADIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOESTADIO.Location = New System.Drawing.Point(108, 15)
        Me.lblTITULOESTADIO.Name = "lblTITULOESTADIO"
        Me.lblTITULOESTADIO.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOESTADIO.TabIndex = 22
        Me.lblTITULOESTADIO.Text = "CÓDIGOS DE ESTADIO"
        Me.lblTITULOESTADIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREESTADIO
        '
        Me.txtNOMBREESTADIO.AcceptsReturn = True
        Me.txtNOMBREESTADIO.AcceptsTab = True
        Me.txtNOMBREESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREESTADIO.Location = New System.Drawing.Point(256, 96)
        Me.txtNOMBREESTADIO.MaxLength = 50
        Me.txtNOMBREESTADIO.Name = "txtNOMBREESTADIO"
        Me.txtNOMBREESTADIO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREESTADIO.TabIndex = 1
        '
        'intCODIGOESTADIO
        '
        Me.intCODIGOESTADIO.AcceptsReturn = True
        Me.intCODIGOESTADIO.AcceptsTab = True
        Me.intCODIGOESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOESTADIO.Location = New System.Drawing.Point(256, 64)
        Me.intCODIGOESTADIO.MaxLength = 4
        Me.intCODIGOESTADIO.Name = "intCODIGOESTADIO"
        Me.intCODIGOESTADIO.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOESTADIO.TabIndex = 0
        '
        'lblNOMBREESTADIO
        '
        Me.lblNOMBREESTADIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREESTADIO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREESTADIO.Location = New System.Drawing.Point(88, 96)
        Me.lblNOMBREESTADIO.Name = "lblNOMBREESTADIO"
        Me.lblNOMBREESTADIO.Size = New System.Drawing.Size(152, 23)
        Me.lblNOMBREESTADIO.TabIndex = 21
        Me.lblNOMBREESTADIO.Text = "Nombre(50): "
        Me.lblNOMBREESTADIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOESTADIO
        '
        Me.lblCODIGOESTADIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOESTADIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOESTADIO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOESTADIO.Location = New System.Drawing.Point(88, 64)
        Me.lblCODIGOESTADIO.Name = "lblCODIGOESTADIO"
        Me.lblCODIGOESTADIO.Size = New System.Drawing.Size(152, 23)
        Me.lblCODIGOESTADIO.TabIndex = 20
        Me.lblCODIGOESTADIO.Text = "Código(4): "
        Me.lblCODIGOESTADIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpPAIS
        '
        Me.tabpPAIS.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpPAIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpPAIS.Controls.Add(Me.btnNUEVOPAIS)
        Me.tabpPAIS.Controls.Add(Me.txtBUSQUEDAPAIS)
        Me.tabpPAIS.Controls.Add(Me.lblBUSQUEDAPAIS)
        Me.tabpPAIS.Controls.Add(Me.btnCANCELARPAIS)
        Me.tabpPAIS.Controls.Add(Me.btnELIMINARPAIS)
        Me.tabpPAIS.Controls.Add(Me.btnMODIFICARPAIS)
        Me.tabpPAIS.Controls.Add(Me.btnAGREGARPAIS)
        Me.tabpPAIS.Controls.Add(Me.dtaPAIS)
        Me.tabpPAIS.Controls.Add(Me.lblTITULOPAIS)
        Me.tabpPAIS.Controls.Add(Me.txtNOMBREPAIS)
        Me.tabpPAIS.Controls.Add(Me.intCODIGOPAIS)
        Me.tabpPAIS.Controls.Add(Me.lblNOMBREPAIS)
        Me.tabpPAIS.Controls.Add(Me.lblCODIGOPAIS)
        Me.tabpPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpPAIS.Location = New System.Drawing.Point(4, 22)
        Me.tabpPAIS.Name = "tabpPAIS"
        Me.tabpPAIS.Size = New System.Drawing.Size(952, 494)
        Me.tabpPAIS.TabIndex = 5
        Me.tabpPAIS.Text = "códigos de país"
        '
        'btnNUEVOPAIS
        '
        Me.btnNUEVOPAIS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOPAIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOPAIS.Location = New System.Drawing.Point(714, 56)
        Me.btnNUEVOPAIS.Name = "btnNUEVOPAIS"
        Me.btnNUEVOPAIS.Size = New System.Drawing.Size(110, 56)
        Me.btnNUEVOPAIS.TabIndex = 24
        Me.btnNUEVOPAIS.Text = "&Nuevo Registro"
        Me.btnNUEVOPAIS.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDAPAIS
        '
        Me.txtBUSQUEDAPAIS.AcceptsReturn = True
        Me.txtBUSQUEDAPAIS.AcceptsTab = True
        Me.txtBUSQUEDAPAIS.Location = New System.Drawing.Point(306, 184)
        Me.txtBUSQUEDAPAIS.Name = "txtBUSQUEDAPAIS"
        Me.txtBUSQUEDAPAIS.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDAPAIS.TabIndex = 18
        '
        'lblBUSQUEDAPAIS
        '
        Me.lblBUSQUEDAPAIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDAPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDAPAIS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDAPAIS.Location = New System.Drawing.Point(106, 184)
        Me.lblBUSQUEDAPAIS.Name = "lblBUSQUEDAPAIS"
        Me.lblBUSQUEDAPAIS.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDAPAIS.TabIndex = 23
        Me.lblBUSQUEDAPAIS.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDAPAIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARPAIS
        '
        Me.btnCANCELARPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARPAIS.Location = New System.Drawing.Point(514, 136)
        Me.btnCANCELARPAIS.Name = "btnCANCELARPAIS"
        Me.btnCANCELARPAIS.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARPAIS.TabIndex = 17
        Me.btnCANCELARPAIS.Text = "&Cancelar"
        '
        'btnELIMINARPAIS
        '
        Me.btnELIMINARPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARPAIS.Location = New System.Drawing.Point(378, 136)
        Me.btnELIMINARPAIS.Name = "btnELIMINARPAIS"
        Me.btnELIMINARPAIS.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARPAIS.TabIndex = 16
        Me.btnELIMINARPAIS.Text = "&Eliminar"
        '
        'btnMODIFICARPAIS
        '
        Me.btnMODIFICARPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARPAIS.Location = New System.Drawing.Point(242, 136)
        Me.btnMODIFICARPAIS.Name = "btnMODIFICARPAIS"
        Me.btnMODIFICARPAIS.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARPAIS.TabIndex = 15
        Me.btnMODIFICARPAIS.Text = "&Modificar"
        '
        'btnAGREGARPAIS
        '
        Me.btnAGREGARPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARPAIS.Location = New System.Drawing.Point(106, 136)
        Me.btnAGREGARPAIS.Name = "btnAGREGARPAIS"
        Me.btnAGREGARPAIS.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARPAIS.TabIndex = 14
        Me.btnAGREGARPAIS.Text = "&Agregar"
        '
        'dtaPAIS
        '
        Me.dtaPAIS.DataMember = ""
        Me.dtaPAIS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaPAIS.Location = New System.Drawing.Point(98, 216)
        Me.dtaPAIS.Name = "dtaPAIS"
        Me.dtaPAIS.ReadOnly = True
        Me.dtaPAIS.Size = New System.Drawing.Size(744, 240)
        Me.dtaPAIS.TabIndex = 19
        '
        'lblTITULOPAIS
        '
        Me.lblTITULOPAIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOPAIS.Location = New System.Drawing.Point(106, 13)
        Me.lblTITULOPAIS.Name = "lblTITULOPAIS"
        Me.lblTITULOPAIS.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOPAIS.TabIndex = 22
        Me.lblTITULOPAIS.Text = "CÓDIGOS DE PAÍS"
        Me.lblTITULOPAIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBREPAIS
        '
        Me.txtNOMBREPAIS.AcceptsReturn = True
        Me.txtNOMBREPAIS.AcceptsTab = True
        Me.txtNOMBREPAIS.Location = New System.Drawing.Point(250, 96)
        Me.txtNOMBREPAIS.MaxLength = 50
        Me.txtNOMBREPAIS.Name = "txtNOMBREPAIS"
        Me.txtNOMBREPAIS.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREPAIS.TabIndex = 13
        '
        'intCODIGOPAIS
        '
        Me.intCODIGOPAIS.AcceptsReturn = True
        Me.intCODIGOPAIS.AcceptsTab = True
        Me.intCODIGOPAIS.Location = New System.Drawing.Point(250, 64)
        Me.intCODIGOPAIS.MaxLength = 4
        Me.intCODIGOPAIS.Name = "intCODIGOPAIS"
        Me.intCODIGOPAIS.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOPAIS.TabIndex = 12
        '
        'lblNOMBREPAIS
        '
        Me.lblNOMBREPAIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREPAIS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREPAIS.Location = New System.Drawing.Point(106, 96)
        Me.lblNOMBREPAIS.Name = "lblNOMBREPAIS"
        Me.lblNOMBREPAIS.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBREPAIS.TabIndex = 21
        Me.lblNOMBREPAIS.Text = "Nombre(50): "
        Me.lblNOMBREPAIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOPAIS
        '
        Me.lblCODIGOPAIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOPAIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOPAIS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOPAIS.Location = New System.Drawing.Point(106, 64)
        Me.lblCODIGOPAIS.Name = "lblCODIGOPAIS"
        Me.lblCODIGOPAIS.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOPAIS.TabIndex = 20
        Me.lblCODIGOPAIS.Text = "Código(4): "
        Me.lblCODIGOPAIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpTIPODOCUMENTO
        '
        Me.tabpTIPODOCUMENTO.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpTIPODOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.btnNUEVOTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.txtBUSQUEDATIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.lblBUSQUEDATIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.btnCANCELARTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.btnELIMINARTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.btnMODIFICARTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.btnAGREGARTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.dtaTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.lblTITULOTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.txtNOMBRETIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.intCODIGOTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.lblNOMBRETIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Controls.Add(Me.lblCODIGOTIPODOCUMENTO)
        Me.tabpTIPODOCUMENTO.Location = New System.Drawing.Point(4, 22)
        Me.tabpTIPODOCUMENTO.Name = "tabpTIPODOCUMENTO"
        Me.tabpTIPODOCUMENTO.Size = New System.Drawing.Size(952, 494)
        Me.tabpTIPODOCUMENTO.TabIndex = 3
        Me.tabpTIPODOCUMENTO.Text = "Tipos de Documento"
        '
        'btnNUEVOTIPODOCUMENTO
        '
        Me.btnNUEVOTIPODOCUMENTO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOTIPODOCUMENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOTIPODOCUMENTO.Location = New System.Drawing.Point(714, 56)
        Me.btnNUEVOTIPODOCUMENTO.Name = "btnNUEVOTIPODOCUMENTO"
        Me.btnNUEVOTIPODOCUMENTO.Size = New System.Drawing.Size(110, 56)
        Me.btnNUEVOTIPODOCUMENTO.TabIndex = 6
        Me.btnNUEVOTIPODOCUMENTO.Text = "&Nuevo Registro"
        Me.btnNUEVOTIPODOCUMENTO.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDATIPODOCUMENTO
        '
        Me.txtBUSQUEDATIPODOCUMENTO.AcceptsReturn = True
        Me.txtBUSQUEDATIPODOCUMENTO.AcceptsTab = True
        Me.txtBUSQUEDATIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDATIPODOCUMENTO.Location = New System.Drawing.Point(306, 184)
        Me.txtBUSQUEDATIPODOCUMENTO.Name = "txtBUSQUEDATIPODOCUMENTO"
        Me.txtBUSQUEDATIPODOCUMENTO.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDATIPODOCUMENTO.TabIndex = 7
        '
        'lblBUSQUEDATIPODOCUMENTO
        '
        Me.lblBUSQUEDATIPODOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDATIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDATIPODOCUMENTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDATIPODOCUMENTO.Location = New System.Drawing.Point(106, 184)
        Me.lblBUSQUEDATIPODOCUMENTO.Name = "lblBUSQUEDATIPODOCUMENTO"
        Me.lblBUSQUEDATIPODOCUMENTO.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDATIPODOCUMENTO.TabIndex = 12
        Me.lblBUSQUEDATIPODOCUMENTO.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDATIPODOCUMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARTIPODOCUMENTO
        '
        Me.btnCANCELARTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARTIPODOCUMENTO.Location = New System.Drawing.Point(514, 136)
        Me.btnCANCELARTIPODOCUMENTO.Name = "btnCANCELARTIPODOCUMENTO"
        Me.btnCANCELARTIPODOCUMENTO.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARTIPODOCUMENTO.TabIndex = 5
        Me.btnCANCELARTIPODOCUMENTO.Text = "&Cancelar"
        '
        'btnELIMINARTIPODOCUMENTO
        '
        Me.btnELIMINARTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARTIPODOCUMENTO.Location = New System.Drawing.Point(378, 136)
        Me.btnELIMINARTIPODOCUMENTO.Name = "btnELIMINARTIPODOCUMENTO"
        Me.btnELIMINARTIPODOCUMENTO.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARTIPODOCUMENTO.TabIndex = 4
        Me.btnELIMINARTIPODOCUMENTO.Text = "&Eliminar"
        '
        'btnMODIFICARTIPODOCUMENTO
        '
        Me.btnMODIFICARTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARTIPODOCUMENTO.Location = New System.Drawing.Point(242, 136)
        Me.btnMODIFICARTIPODOCUMENTO.Name = "btnMODIFICARTIPODOCUMENTO"
        Me.btnMODIFICARTIPODOCUMENTO.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARTIPODOCUMENTO.TabIndex = 3
        Me.btnMODIFICARTIPODOCUMENTO.Text = "&Modificar"
        '
        'btnAGREGARTIPODOCUMENTO
        '
        Me.btnAGREGARTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARTIPODOCUMENTO.Location = New System.Drawing.Point(106, 136)
        Me.btnAGREGARTIPODOCUMENTO.Name = "btnAGREGARTIPODOCUMENTO"
        Me.btnAGREGARTIPODOCUMENTO.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARTIPODOCUMENTO.TabIndex = 2
        Me.btnAGREGARTIPODOCUMENTO.Text = "&Agregar"
        '
        'dtaTIPODOCUMENTO
        '
        Me.dtaTIPODOCUMENTO.DataMember = ""
        Me.dtaTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaTIPODOCUMENTO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaTIPODOCUMENTO.Location = New System.Drawing.Point(98, 216)
        Me.dtaTIPODOCUMENTO.Name = "dtaTIPODOCUMENTO"
        Me.dtaTIPODOCUMENTO.Size = New System.Drawing.Size(744, 240)
        Me.dtaTIPODOCUMENTO.TabIndex = 8
        '
        'lblTITULOTIPODOCUMENTO
        '
        Me.lblTITULOTIPODOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOTIPODOCUMENTO.Location = New System.Drawing.Point(106, 13)
        Me.lblTITULOTIPODOCUMENTO.Name = "lblTITULOTIPODOCUMENTO"
        Me.lblTITULOTIPODOCUMENTO.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOTIPODOCUMENTO.TabIndex = 9
        Me.lblTITULOTIPODOCUMENTO.Text = "CÓDIGOS DE TIPO DE DOCUMENTO"
        Me.lblTITULOTIPODOCUMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBRETIPODOCUMENTO
        '
        Me.txtNOMBRETIPODOCUMENTO.AcceptsReturn = True
        Me.txtNOMBRETIPODOCUMENTO.AcceptsTab = True
        Me.txtNOMBRETIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRETIPODOCUMENTO.Location = New System.Drawing.Point(250, 96)
        Me.txtNOMBRETIPODOCUMENTO.MaxLength = 50
        Me.txtNOMBRETIPODOCUMENTO.Name = "txtNOMBRETIPODOCUMENTO"
        Me.txtNOMBRETIPODOCUMENTO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBRETIPODOCUMENTO.TabIndex = 1
        '
        'intCODIGOTIPODOCUMENTO
        '
        Me.intCODIGOTIPODOCUMENTO.AcceptsReturn = True
        Me.intCODIGOTIPODOCUMENTO.AcceptsTab = True
        Me.intCODIGOTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOTIPODOCUMENTO.Location = New System.Drawing.Point(250, 64)
        Me.intCODIGOTIPODOCUMENTO.MaxLength = 4
        Me.intCODIGOTIPODOCUMENTO.Name = "intCODIGOTIPODOCUMENTO"
        Me.intCODIGOTIPODOCUMENTO.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOTIPODOCUMENTO.TabIndex = 0
        '
        'lblNOMBRETIPODOCUMENTO
        '
        Me.lblNOMBRETIPODOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBRETIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRETIPODOCUMENTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBRETIPODOCUMENTO.Location = New System.Drawing.Point(106, 96)
        Me.lblNOMBRETIPODOCUMENTO.Name = "lblNOMBRETIPODOCUMENTO"
        Me.lblNOMBRETIPODOCUMENTO.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBRETIPODOCUMENTO.TabIndex = 11
        Me.lblNOMBRETIPODOCUMENTO.Text = "Nombre(50): "
        Me.lblNOMBRETIPODOCUMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOTIPODOCUMENTO
        '
        Me.lblCODIGOTIPODOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOTIPODOCUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOTIPODOCUMENTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOTIPODOCUMENTO.Location = New System.Drawing.Point(106, 64)
        Me.lblCODIGOTIPODOCUMENTO.Name = "lblCODIGOTIPODOCUMENTO"
        Me.lblCODIGOTIPODOCUMENTO.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOTIPODOCUMENTO.TabIndex = 10
        Me.lblCODIGOTIPODOCUMENTO.Text = "Código(4): "
        Me.lblCODIGOTIPODOCUMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpCONCEPTO
        '
        Me.tabpCONCEPTO.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpCONCEPTO.Controls.Add(Me.intMONTOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblMONTOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.cboBONODESCUENTOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblTIPO)
        Me.tabpCONCEPTO.Controls.Add(Me.txtNOMBREBREVECONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblNOMBREBREVECONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.btnNUEVOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.txtBUSQUEDACONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblBUSQUEDACONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.btnCANCELARCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.btnELIMINARCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.btnMODIFICARCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.btnAGREGARCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.dtaCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblTITULOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.txtNOMBRECONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.intCODIGOCONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblNOMBRECONCEPTO)
        Me.tabpCONCEPTO.Controls.Add(Me.lblCODIGOCONCEPTO)
        Me.tabpCONCEPTO.Location = New System.Drawing.Point(4, 22)
        Me.tabpCONCEPTO.Name = "tabpCONCEPTO"
        Me.tabpCONCEPTO.Size = New System.Drawing.Size(952, 494)
        Me.tabpCONCEPTO.TabIndex = 6
        Me.tabpCONCEPTO.Text = "Conceptos"
        '
        'intMONTOCONCEPTO
        '
        Me.intMONTOCONCEPTO.AcceptsReturn = True
        Me.intMONTOCONCEPTO.AcceptsTab = True
        Me.intMONTOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMONTOCONCEPTO.Location = New System.Drawing.Point(256, 160)
        Me.intMONTOCONCEPTO.MaxLength = 10
        Me.intMONTOCONCEPTO.Name = "intMONTOCONCEPTO"
        Me.intMONTOCONCEPTO.Size = New System.Drawing.Size(392, 26)
        Me.intMONTOCONCEPTO.TabIndex = 3
        '
        'lblMONTOCONCEPTO
        '
        Me.lblMONTOCONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMONTOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTOCONCEPTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMONTOCONCEPTO.Location = New System.Drawing.Point(80, 160)
        Me.lblMONTOCONCEPTO.Name = "lblMONTOCONCEPTO"
        Me.lblMONTOCONCEPTO.Size = New System.Drawing.Size(160, 23)
        Me.lblMONTOCONCEPTO.TabIndex = 29
        Me.lblMONTOCONCEPTO.Text = "Monto(10): "
        Me.lblMONTOCONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboBONODESCUENTOCONCEPTO
        '
        Me.cboBONODESCUENTOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBONODESCUENTOCONCEPTO.Items.AddRange(New Object() {"BONO", "DESCUENTO"})
        Me.cboBONODESCUENTOCONCEPTO.Location = New System.Drawing.Point(256, 192)
        Me.cboBONODESCUENTOCONCEPTO.Name = "cboBONODESCUENTOCONCEPTO"
        Me.cboBONODESCUENTOCONCEPTO.Size = New System.Drawing.Size(192, 24)
        Me.cboBONODESCUENTOCONCEPTO.TabIndex = 4
        '
        'lblTIPO
        '
        Me.lblTIPO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIPO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTIPO.Location = New System.Drawing.Point(80, 192)
        Me.lblTIPO.Name = "lblTIPO"
        Me.lblTIPO.Size = New System.Drawing.Size(160, 23)
        Me.lblTIPO.TabIndex = 27
        Me.lblTIPO.Text = "Tipo: "
        Me.lblTIPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNOMBREBREVECONCEPTO
        '
        Me.txtNOMBREBREVECONCEPTO.AcceptsReturn = True
        Me.txtNOMBREBREVECONCEPTO.AcceptsTab = True
        Me.txtNOMBREBREVECONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREBREVECONCEPTO.Location = New System.Drawing.Point(256, 128)
        Me.txtNOMBREBREVECONCEPTO.MaxLength = 25
        Me.txtNOMBREBREVECONCEPTO.Name = "txtNOMBREBREVECONCEPTO"
        Me.txtNOMBREBREVECONCEPTO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBREBREVECONCEPTO.TabIndex = 2
        '
        'lblNOMBREBREVECONCEPTO
        '
        Me.lblNOMBREBREVECONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBREBREVECONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREBREVECONCEPTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBREBREVECONCEPTO.Location = New System.Drawing.Point(80, 128)
        Me.lblNOMBREBREVECONCEPTO.Name = "lblNOMBREBREVECONCEPTO"
        Me.lblNOMBREBREVECONCEPTO.Size = New System.Drawing.Size(160, 23)
        Me.lblNOMBREBREVECONCEPTO.TabIndex = 26
        Me.lblNOMBREBREVECONCEPTO.Text = "Nombre breve(25): "
        Me.lblNOMBREBREVECONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNUEVOCONCEPTO
        '
        Me.btnNUEVOCONCEPTO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOCONCEPTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOCONCEPTO.Location = New System.Drawing.Point(664, 80)
        Me.btnNUEVOCONCEPTO.Name = "btnNUEVOCONCEPTO"
        Me.btnNUEVOCONCEPTO.Size = New System.Drawing.Size(104, 56)
        Me.btnNUEVOCONCEPTO.TabIndex = 12
        Me.btnNUEVOCONCEPTO.Text = "&Nuevo Registro"
        Me.btnNUEVOCONCEPTO.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDACONCEPTO
        '
        Me.txtBUSQUEDACONCEPTO.AcceptsReturn = True
        Me.txtBUSQUEDACONCEPTO.AcceptsTab = True
        Me.txtBUSQUEDACONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDACONCEPTO.Location = New System.Drawing.Point(304, 296)
        Me.txtBUSQUEDACONCEPTO.Name = "txtBUSQUEDACONCEPTO"
        Me.txtBUSQUEDACONCEPTO.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDACONCEPTO.TabIndex = 10
        '
        'lblBUSQUEDACONCEPTO
        '
        Me.lblBUSQUEDACONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDACONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDACONCEPTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDACONCEPTO.Location = New System.Drawing.Point(104, 296)
        Me.lblBUSQUEDACONCEPTO.Name = "lblBUSQUEDACONCEPTO"
        Me.lblBUSQUEDACONCEPTO.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDACONCEPTO.TabIndex = 23
        Me.lblBUSQUEDACONCEPTO.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDACONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARCONCEPTO
        '
        Me.btnCANCELARCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARCONCEPTO.Location = New System.Drawing.Point(520, 256)
        Me.btnCANCELARCONCEPTO.Name = "btnCANCELARCONCEPTO"
        Me.btnCANCELARCONCEPTO.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARCONCEPTO.TabIndex = 9
        Me.btnCANCELARCONCEPTO.Text = "&Cancelar"
        '
        'btnELIMINARCONCEPTO
        '
        Me.btnELIMINARCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARCONCEPTO.Location = New System.Drawing.Point(376, 256)
        Me.btnELIMINARCONCEPTO.Name = "btnELIMINARCONCEPTO"
        Me.btnELIMINARCONCEPTO.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARCONCEPTO.TabIndex = 8
        Me.btnELIMINARCONCEPTO.Text = "&Eliminar"
        '
        'btnMODIFICARCONCEPTO
        '
        Me.btnMODIFICARCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARCONCEPTO.Location = New System.Drawing.Point(240, 256)
        Me.btnMODIFICARCONCEPTO.Name = "btnMODIFICARCONCEPTO"
        Me.btnMODIFICARCONCEPTO.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARCONCEPTO.TabIndex = 7
        Me.btnMODIFICARCONCEPTO.Text = "&Modificar"
        '
        'btnAGREGARCONCEPTO
        '
        Me.btnAGREGARCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARCONCEPTO.Location = New System.Drawing.Point(104, 256)
        Me.btnAGREGARCONCEPTO.Name = "btnAGREGARCONCEPTO"
        Me.btnAGREGARCONCEPTO.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARCONCEPTO.TabIndex = 6
        Me.btnAGREGARCONCEPTO.Text = "&Agregar"
        '
        'dtaCONCEPTO
        '
        Me.dtaCONCEPTO.DataMember = ""
        Me.dtaCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaCONCEPTO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaCONCEPTO.Location = New System.Drawing.Point(100, 328)
        Me.dtaCONCEPTO.Name = "dtaCONCEPTO"
        Me.dtaCONCEPTO.ReadOnly = True
        Me.dtaCONCEPTO.Size = New System.Drawing.Size(744, 152)
        Me.dtaCONCEPTO.TabIndex = 11
        '
        'lblTITULOCONCEPTO
        '
        Me.lblTITULOCONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOCONCEPTO.Location = New System.Drawing.Point(88, 15)
        Me.lblTITULOCONCEPTO.Name = "lblTITULOCONCEPTO"
        Me.lblTITULOCONCEPTO.Size = New System.Drawing.Size(752, 32)
        Me.lblTITULOCONCEPTO.TabIndex = 22
        Me.lblTITULOCONCEPTO.Text = "CÓDIGOS DE CONCEPTO DE PAGO"
        Me.lblTITULOCONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBRECONCEPTO
        '
        Me.txtNOMBRECONCEPTO.AcceptsReturn = True
        Me.txtNOMBRECONCEPTO.AcceptsTab = True
        Me.txtNOMBRECONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRECONCEPTO.Location = New System.Drawing.Point(256, 96)
        Me.txtNOMBRECONCEPTO.MaxLength = 50
        Me.txtNOMBRECONCEPTO.Name = "txtNOMBRECONCEPTO"
        Me.txtNOMBRECONCEPTO.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBRECONCEPTO.TabIndex = 1
        '
        'intCODIGOCONCEPTO
        '
        Me.intCODIGOCONCEPTO.AcceptsReturn = True
        Me.intCODIGOCONCEPTO.AcceptsTab = True
        Me.intCODIGOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOCONCEPTO.Location = New System.Drawing.Point(256, 64)
        Me.intCODIGOCONCEPTO.MaxLength = 4
        Me.intCODIGOCONCEPTO.Name = "intCODIGOCONCEPTO"
        Me.intCODIGOCONCEPTO.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOCONCEPTO.TabIndex = 0
        '
        'lblNOMBRECONCEPTO
        '
        Me.lblNOMBRECONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBRECONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRECONCEPTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBRECONCEPTO.Location = New System.Drawing.Point(80, 96)
        Me.lblNOMBRECONCEPTO.Name = "lblNOMBRECONCEPTO"
        Me.lblNOMBRECONCEPTO.Size = New System.Drawing.Size(160, 23)
        Me.lblNOMBRECONCEPTO.TabIndex = 21
        Me.lblNOMBRECONCEPTO.Text = "Nombre(50): "
        Me.lblNOMBRECONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOCONCEPTO
        '
        Me.lblCODIGOCONCEPTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOCONCEPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOCONCEPTO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOCONCEPTO.Location = New System.Drawing.Point(80, 64)
        Me.lblCODIGOCONCEPTO.Name = "lblCODIGOCONCEPTO"
        Me.lblCODIGOCONCEPTO.Size = New System.Drawing.Size(160, 23)
        Me.lblCODIGOCONCEPTO.TabIndex = 20
        Me.lblCODIGOCONCEPTO.Text = "Código(4): "
        Me.lblCODIGOCONCEPTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpcategoria
        '
        Me.tabpcategoria.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpcategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabpcategoria.Controls.Add(Me.txtNIVELCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.lblNIVEL)
        Me.tabpcategoria.Controls.Add(Me.btnNUEVOCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.txtBUSQUEDACATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.lblBUSQUEDACATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.btnCANCELARCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.btnELIMINARCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.btnMODIFICARCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.btnAGREGARCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.dtaCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.lblTITULOCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.txtNOMBRECATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.txtCODIGOCATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.lblNOMBRECATEGORIA)
        Me.tabpcategoria.Controls.Add(Me.lblCODIGOCATEGORIA)
        Me.tabpcategoria.Location = New System.Drawing.Point(4, 22)
        Me.tabpcategoria.Name = "tabpcategoria"
        Me.tabpcategoria.Size = New System.Drawing.Size(952, 494)
        Me.tabpcategoria.TabIndex = 2
        Me.tabpcategoria.Text = "Códigos de Categorías"
        '
        'txtNIVELCATEGORIA
        '
        Me.txtNIVELCATEGORIA.AcceptsReturn = True
        Me.txtNIVELCATEGORIA.AcceptsTab = True
        Me.txtNIVELCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIVELCATEGORIA.Location = New System.Drawing.Point(240, 128)
        Me.txtNIVELCATEGORIA.MaxLength = 10
        Me.txtNIVELCATEGORIA.Name = "txtNIVELCATEGORIA"
        Me.txtNIVELCATEGORIA.Size = New System.Drawing.Size(392, 26)
        Me.txtNIVELCATEGORIA.TabIndex = 2
        '
        'lblNIVEL
        '
        Me.lblNIVEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNIVEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIVEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNIVEL.Location = New System.Drawing.Point(104, 128)
        Me.lblNIVEL.Name = "lblNIVEL"
        Me.lblNIVEL.Size = New System.Drawing.Size(128, 23)
        Me.lblNIVEL.TabIndex = 13
        Me.lblNIVEL.Text = "Nivel(10): "
        Me.lblNIVEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNUEVOCATEGORIA
        '
        Me.btnNUEVOCATEGORIA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOCATEGORIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOCATEGORIA.Location = New System.Drawing.Point(720, 80)
        Me.btnNUEVOCATEGORIA.Name = "btnNUEVOCATEGORIA"
        Me.btnNUEVOCATEGORIA.Size = New System.Drawing.Size(108, 56)
        Me.btnNUEVOCATEGORIA.TabIndex = 7
        Me.btnNUEVOCATEGORIA.Text = "&Nuevo Registro"
        Me.btnNUEVOCATEGORIA.UseVisualStyleBackColor = False
        '
        'txtBUSQUEDACATEGORIA
        '
        Me.txtBUSQUEDACATEGORIA.AcceptsReturn = True
        Me.txtBUSQUEDACATEGORIA.AcceptsTab = True
        Me.txtBUSQUEDACATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDACATEGORIA.Location = New System.Drawing.Point(308, 224)
        Me.txtBUSQUEDACATEGORIA.Name = "txtBUSQUEDACATEGORIA"
        Me.txtBUSQUEDACATEGORIA.Size = New System.Drawing.Size(336, 26)
        Me.txtBUSQUEDACATEGORIA.TabIndex = 8
        '
        'lblBUSQUEDACATEGORIA
        '
        Me.lblBUSQUEDACATEGORIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBUSQUEDACATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDACATEGORIA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBUSQUEDACATEGORIA.Location = New System.Drawing.Point(108, 224)
        Me.lblBUSQUEDACATEGORIA.Name = "lblBUSQUEDACATEGORIA"
        Me.lblBUSQUEDACATEGORIA.Size = New System.Drawing.Size(192, 23)
        Me.lblBUSQUEDACATEGORIA.TabIndex = 14
        Me.lblBUSQUEDACATEGORIA.Text = "Búsqueda por nombre: "
        Me.lblBUSQUEDACATEGORIA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCANCELARCATEGORIA
        '
        Me.btnCANCELARCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARCATEGORIA.Location = New System.Drawing.Point(516, 176)
        Me.btnCANCELARCATEGORIA.Name = "btnCANCELARCATEGORIA"
        Me.btnCANCELARCATEGORIA.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARCATEGORIA.TabIndex = 6
        Me.btnCANCELARCATEGORIA.Text = "&Cancelar"
        '
        'btnELIMINARCATEGORIA
        '
        Me.btnELIMINARCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARCATEGORIA.Location = New System.Drawing.Point(380, 176)
        Me.btnELIMINARCATEGORIA.Name = "btnELIMINARCATEGORIA"
        Me.btnELIMINARCATEGORIA.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARCATEGORIA.TabIndex = 5
        Me.btnELIMINARCATEGORIA.Text = "&Eliminar"
        '
        'btnMODIFICARCATEGORIA
        '
        Me.btnMODIFICARCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARCATEGORIA.Location = New System.Drawing.Point(244, 176)
        Me.btnMODIFICARCATEGORIA.Name = "btnMODIFICARCATEGORIA"
        Me.btnMODIFICARCATEGORIA.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARCATEGORIA.TabIndex = 4
        Me.btnMODIFICARCATEGORIA.Text = "&Modificar"
        '
        'btnAGREGARCATEGORIA
        '
        Me.btnAGREGARCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARCATEGORIA.Location = New System.Drawing.Point(108, 176)
        Me.btnAGREGARCATEGORIA.Name = "btnAGREGARCATEGORIA"
        Me.btnAGREGARCATEGORIA.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARCATEGORIA.TabIndex = 3
        Me.btnAGREGARCATEGORIA.Text = "&Agregar"
        '
        'dtaCATEGORIA
        '
        Me.dtaCATEGORIA.DataMember = ""
        Me.dtaCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaCATEGORIA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaCATEGORIA.Location = New System.Drawing.Point(104, 256)
        Me.dtaCATEGORIA.Name = "dtaCATEGORIA"
        Me.dtaCATEGORIA.Size = New System.Drawing.Size(744, 200)
        Me.dtaCATEGORIA.TabIndex = 9
        '
        'lblTITULOCATEGORIA
        '
        Me.lblTITULOCATEGORIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOCATEGORIA.Location = New System.Drawing.Point(108, 15)
        Me.lblTITULOCATEGORIA.Name = "lblTITULOCATEGORIA"
        Me.lblTITULOCATEGORIA.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOCATEGORIA.TabIndex = 10
        Me.lblTITULOCATEGORIA.Text = "CÓDIGOS DE CATEGORÍA"
        Me.lblTITULOCATEGORIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOMBRECATEGORIA
        '
        Me.txtNOMBRECATEGORIA.AcceptsReturn = True
        Me.txtNOMBRECATEGORIA.AcceptsTab = True
        Me.txtNOMBRECATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRECATEGORIA.Location = New System.Drawing.Point(240, 96)
        Me.txtNOMBRECATEGORIA.MaxLength = 50
        Me.txtNOMBRECATEGORIA.Name = "txtNOMBRECATEGORIA"
        Me.txtNOMBRECATEGORIA.Size = New System.Drawing.Size(392, 26)
        Me.txtNOMBRECATEGORIA.TabIndex = 1
        '
        'txtCODIGOCATEGORIA
        '
        Me.txtCODIGOCATEGORIA.AcceptsReturn = True
        Me.txtCODIGOCATEGORIA.AcceptsTab = True
        Me.txtCODIGOCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGOCATEGORIA.Location = New System.Drawing.Point(240, 64)
        Me.txtCODIGOCATEGORIA.MaxLength = 4
        Me.txtCODIGOCATEGORIA.Name = "txtCODIGOCATEGORIA"
        Me.txtCODIGOCATEGORIA.Size = New System.Drawing.Size(192, 26)
        Me.txtCODIGOCATEGORIA.TabIndex = 0
        '
        'lblNOMBRECATEGORIA
        '
        Me.lblNOMBRECATEGORIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOMBRECATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRECATEGORIA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNOMBRECATEGORIA.Location = New System.Drawing.Point(104, 96)
        Me.lblNOMBRECATEGORIA.Name = "lblNOMBRECATEGORIA"
        Me.lblNOMBRECATEGORIA.Size = New System.Drawing.Size(128, 23)
        Me.lblNOMBRECATEGORIA.TabIndex = 12
        Me.lblNOMBRECATEGORIA.Text = "Nombre(50): "
        Me.lblNOMBRECATEGORIA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOCATEGORIA
        '
        Me.lblCODIGOCATEGORIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOCATEGORIA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOCATEGORIA.Location = New System.Drawing.Point(104, 64)
        Me.lblCODIGOCATEGORIA.Name = "lblCODIGOCATEGORIA"
        Me.lblCODIGOCATEGORIA.Size = New System.Drawing.Size(128, 23)
        Me.lblCODIGOCATEGORIA.TabIndex = 11
        Me.lblCODIGOCATEGORIA.Text = "Código(4): "
        Me.lblCODIGOCATEGORIA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpmantcapital
        '
        Me.tabpmantcapital.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tabpmantcapital.Controls.Add(Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.intMONTOFINALMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.lblMONTOFINALMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.btnNUEVOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.btnCANCELARMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.btnELIMINARMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.btnMODIFICARMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.btnAGREGARMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.dtaMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.lblTITULOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.intMONTOINICIALMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.intCODIGOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.lblMONTOINICIALMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Controls.Add(Me.lblCODIGOMANTENIMIENTOCAPITAL)
        Me.tabpmantcapital.Location = New System.Drawing.Point(4, 22)
        Me.tabpmantcapital.Name = "tabpmantcapital"
        Me.tabpmantcapital.Size = New System.Drawing.Size(952, 494)
        Me.tabpmantcapital.TabIndex = 10
        Me.tabpmantcapital.Text = "mantenimiento de capital"
        '
        'intMONTOASIGNADOMANTENIMIENTOCAPITAL
        '
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.AcceptsReturn = True
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.AcceptsTab = True
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(264, 176)
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.MaxLength = 10
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Name = "intMONTOASIGNADOMANTENIMIENTOCAPITAL"
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(392, 26)
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.TabIndex = 3
        '
        'lblMONTOASIGNADOMANTENIMIENTOCAPITAL
        '
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(64, 176)
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.Name = "lblMONTOASIGNADOMANTENIMIENTOCAPITAL"
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(184, 23)
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.TabIndex = 41
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = "Monto Asignado(10): "
        Me.lblMONTOASIGNADOMANTENIMIENTOCAPITAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'intMONTOFINALMANTENIMIENTOCAPITAL
        '
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.AcceptsReturn = True
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.AcceptsTab = True
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(262, 136)
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.MaxLength = 10
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Name = "intMONTOFINALMANTENIMIENTOCAPITAL"
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(392, 26)
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.TabIndex = 2
        '
        'lblMONTOFINALMANTENIMIENTOCAPITAL
        '
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(64, 136)
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.Name = "lblMONTOFINALMANTENIMIENTOCAPITAL"
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(184, 23)
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.TabIndex = 39
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.Text = "Monto Final (10): "
        Me.lblMONTOFINALMANTENIMIENTOCAPITAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNUEVOMANTENIMIENTOCAPITAL
        '
        Me.btnNUEVOMANTENIMIENTOCAPITAL.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNUEVOMANTENIMIENTOCAPITAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(722, 72)
        Me.btnNUEVOMANTENIMIENTOCAPITAL.Name = "btnNUEVOMANTENIMIENTOCAPITAL"
        Me.btnNUEVOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(110, 56)
        Me.btnNUEVOMANTENIMIENTOCAPITAL.TabIndex = 8
        Me.btnNUEVOMANTENIMIENTOCAPITAL.Text = "&Nuevo Registro"
        Me.btnNUEVOMANTENIMIENTOCAPITAL.UseVisualStyleBackColor = False
        '
        'btnCANCELARMANTENIMIENTOCAPITAL
        '
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(522, 224)
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Name = "btnCANCELARMANTENIMIENTOCAPITAL"
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(128, 32)
        Me.btnCANCELARMANTENIMIENTOCAPITAL.TabIndex = 7
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Text = "&Cancelar"
        '
        'btnELIMINARMANTENIMIENTOCAPITAL
        '
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(386, 224)
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Name = "btnELIMINARMANTENIMIENTOCAPITAL"
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(128, 32)
        Me.btnELIMINARMANTENIMIENTOCAPITAL.TabIndex = 6
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Text = "&Eliminar"
        '
        'btnMODIFICARMANTENIMIENTOCAPITAL
        '
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(250, 224)
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Name = "btnMODIFICARMANTENIMIENTOCAPITAL"
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(128, 32)
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.TabIndex = 5
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Text = "&Modificar"
        '
        'btnAGREGARMANTENIMIENTOCAPITAL
        '
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(114, 224)
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Name = "btnAGREGARMANTENIMIENTOCAPITAL"
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(128, 32)
        Me.btnAGREGARMANTENIMIENTOCAPITAL.TabIndex = 4
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Text = "&Agregar"
        '
        'dtaMANTENIMIENTOCAPITAL
        '
        Me.dtaMANTENIMIENTOCAPITAL.DataMember = ""
        Me.dtaMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaMANTENIMIENTOCAPITAL.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(106, 256)
        Me.dtaMANTENIMIENTOCAPITAL.Name = "dtaMANTENIMIENTOCAPITAL"
        Me.dtaMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(744, 200)
        Me.dtaMANTENIMIENTOCAPITAL.TabIndex = 9
        '
        'lblTITULOMANTENIMIENTOCAPITAL
        '
        Me.lblTITULOMANTENIMIENTOCAPITAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(114, 19)
        Me.lblTITULOMANTENIMIENTOCAPITAL.Name = "lblTITULOMANTENIMIENTOCAPITAL"
        Me.lblTITULOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(736, 32)
        Me.lblTITULOMANTENIMIENTOCAPITAL.TabIndex = 38
        Me.lblTITULOMANTENIMIENTOCAPITAL.Text = "CÓDIGOS DE MANTENIMIENTO DE CAPITAL"
        Me.lblTITULOMANTENIMIENTOCAPITAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intMONTOINICIALMANTENIMIENTOCAPITAL
        '
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.AcceptsReturn = True
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.AcceptsTab = True
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(262, 104)
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.MaxLength = 10
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Name = "intMONTOINICIALMANTENIMIENTOCAPITAL"
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(392, 26)
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.TabIndex = 1
        '
        'intCODIGOMANTENIMIENTOCAPITAL
        '
        Me.intCODIGOMANTENIMIENTOCAPITAL.AcceptsReturn = True
        Me.intCODIGOMANTENIMIENTOCAPITAL.AcceptsTab = True
        Me.intCODIGOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCODIGOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(262, 72)
        Me.intCODIGOMANTENIMIENTOCAPITAL.MaxLength = 2
        Me.intCODIGOMANTENIMIENTOCAPITAL.Name = "intCODIGOMANTENIMIENTOCAPITAL"
        Me.intCODIGOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(192, 26)
        Me.intCODIGOMANTENIMIENTOCAPITAL.TabIndex = 0
        '
        'lblMONTOINICIALMANTENIMIENTOCAPITAL
        '
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(64, 104)
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.Name = "lblMONTOINICIALMANTENIMIENTOCAPITAL"
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(184, 23)
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.TabIndex = 37
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.Text = "Monto Inicial (10): "
        Me.lblMONTOINICIALMANTENIMIENTOCAPITAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCODIGOMANTENIMIENTOCAPITAL
        '
        Me.lblCODIGOMANTENIMIENTOCAPITAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCODIGOMANTENIMIENTOCAPITAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOMANTENIMIENTOCAPITAL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCODIGOMANTENIMIENTOCAPITAL.Location = New System.Drawing.Point(64, 72)
        Me.lblCODIGOMANTENIMIENTOCAPITAL.Name = "lblCODIGOMANTENIMIENTOCAPITAL"
        Me.lblCODIGOMANTENIMIENTOCAPITAL.Size = New System.Drawing.Size(184, 23)
        Me.lblCODIGOMANTENIMIENTOCAPITAL.TabIndex = 36
        Me.lblCODIGOMANTENIMIENTOCAPITAL.Text = "Código(2): "
        Me.lblCODIGOMANTENIMIENTOCAPITAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnVOLVER
        '
        Me.btnVOLVER.BackColor = System.Drawing.SystemColors.Control
        Me.btnVOLVER.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVOLVER.ForeColor = System.Drawing.Color.Red
        Me.btnVOLVER.Location = New System.Drawing.Point(240, 120)
        Me.btnVOLVER.Name = "btnVOLVER"
        Me.btnVOLVER.Size = New System.Drawing.Size(752, 48)
        Me.btnVOLVER.TabIndex = 1
        Me.btnVOLVER.Text = "&VOLVER AL MENU PRINCIPAL"
        Me.btnVOLVER.UseVisualStyleBackColor = False
        '
        'lblFECHAHORA
        '
        Me.lblFECHAHORA.BackColor = System.Drawing.SystemColors.Control
        Me.lblFECHAHORA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAHORA.Location = New System.Drawing.Point(240, 56)
        Me.lblFECHAHORA.Name = "lblFECHAHORA"
        Me.lblFECHAHORA.Size = New System.Drawing.Size(752, 32)
        Me.lblFECHAHORA.TabIndex = 2
        Me.lblFECHAHORA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerCIUDAD
        '
        '
        'lblUSUARIOACTUAL
        '
        Me.lblUSUARIOACTUAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUSUARIOACTUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIOACTUAL.Location = New System.Drawing.Point(240, 88)
        Me.lblUSUARIOACTUAL.Name = "lblUSUARIOACTUAL"
        Me.lblUSUARIOACTUAL.Size = New System.Drawing.Size(184, 32)
        Me.lblUSUARIOACTUAL.TabIndex = 4
        Me.lblUSUARIOACTUAL.Text = "Usuario actual: "
        Me.lblUSUARIOACTUAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUSUARIO
        '
        Me.lblUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO.Location = New System.Drawing.Point(432, 88)
        Me.lblUSUARIO.Name = "lblUSUARIO"
        Me.lblUSUARIO.Size = New System.Drawing.Size(264, 32)
        Me.lblUSUARIO.TabIndex = 5
        Me.lblUSUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerIDIOMA
        '
        '
        'timerCATEGORIA
        '
        '
        'timerTIPODOCUMENTO
        '
        '
        'timerPARENTESCO
        '
        '
        'timerPAIS
        '
        '
        'timerCONCEPTO
        '
        '
        'timerEQUIPO
        '
        '
        'timerESTADIO
        '
        '
        'timerPROFESION
        '
        '
        'timerMANTENIMIENTOCAPITAL
        '
        '
        'timerDIVISIONES
        '
        '
        'CRUDcodigos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1000, 628)
        Me.Controls.Add(Me.lblUSUARIO)
        Me.Controls.Add(Me.lblUSUARIOACTUAL)
        Me.Controls.Add(Me.lblFECHAHORA)
        Me.Controls.Add(Me.btnVOLVER)
        Me.Controls.Add(Me.tabCODIGOS)
        Me.Controls.Add(Me.lblTITULO)
        Me.Controls.Add(Me.pctboxLOGOTIPOCPAF)
        Me.Name = "CRUDcodigos"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Administración de Códigos - C.P.A.F. - Sistema Delta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctboxLOGOTIPOCPAF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCODIGOS.ResumeLayout(False)
        Me.tabpCIUDAD.ResumeLayout(False)
        Me.tabpCIUDAD.PerformLayout()
        CType(Me.dtaCIUDAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpEQUIPO.ResumeLayout(False)
        Me.tabpEQUIPO.PerformLayout()
        CType(Me.dtaEQUIPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpPROFESION.ResumeLayout(False)
        Me.tabpPROFESION.PerformLayout()
        CType(Me.dtaPROFESION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpIDIOMA.ResumeLayout(False)
        Me.tabpIDIOMA.PerformLayout()
        CType(Me.dtaIDIOMA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpDIVISION.ResumeLayout(False)
        Me.tabpDIVISION.PerformLayout()
        CType(Me.dtaDIVISIONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpparentesco.ResumeLayout(False)
        Me.tabpparentesco.PerformLayout()
        CType(Me.dtaPARENTESCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpESTADIO.ResumeLayout(False)
        Me.tabpESTADIO.PerformLayout()
        CType(Me.dtaESTADIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpPAIS.ResumeLayout(False)
        Me.tabpPAIS.PerformLayout()
        CType(Me.dtaPAIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpTIPODOCUMENTO.ResumeLayout(False)
        Me.tabpTIPODOCUMENTO.PerformLayout()
        CType(Me.dtaTIPODOCUMENTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpCONCEPTO.ResumeLayout(False)
        Me.tabpCONCEPTO.PerformLayout()
        CType(Me.dtaCONCEPTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpcategoria.ResumeLayout(False)
        Me.tabpcategoria.PerformLayout()
        CType(Me.dtaCATEGORIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpmantcapital.ResumeLayout(False)
        Me.tabpmantcapital.PerformLayout()
        CType(Me.dtaMANTENIMIENTOCAPITAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lblNOMBRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNOMBRECIUDAD.Click

    End Sub

    Private Sub tabpCIUDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpCIUDAD.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctboxLOGOTIPOCPAF.Click

    End Sub

    Private Sub CRUDcodigos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblUSUARIO.Text = wkusuusuario
        Me.btnCANCELARCIUDAD.Enabled = False
        Me.btnELIMINARCIUDAD.Enabled = False
        Me.btnMODIFICARCIUDAD.Enabled = False
        Me.btnAGREGARCIUDAD.Enabled = False

        Me.btnCANCELARIDIOMA.Enabled = False
        Me.btnELIMINARIDIOMA.Enabled = False
        Me.btnMODIFICARIDIOMA.Enabled = False
        Me.btnAGREGARIDIOMA.Enabled = False

        Me.btnCANCELARCATEGORIA.Enabled = False
        Me.btnELIMINARCATEGORIA.Enabled = False
        Me.btnMODIFICARCATEGORIA.Enabled = False
        Me.btnAGREGARCATEGORIA.Enabled = False

        Me.btnCANCELARTIPODOCUMENTO.Enabled = False
        Me.btnELIMINARTIPODOCUMENTO.Enabled = False
        Me.btnMODIFICARTIPODOCUMENTO.Enabled = False
        Me.btnAGREGARTIPODOCUMENTO.Enabled = False

        Me.btnCANCELARPARENTESCO.Enabled = False
        Me.btnELIMINARPARENTESCO.Enabled = False
        Me.btnMODIFICARPARENTESCO.Enabled = False
        Me.btnAGREGARPARENTESCO.Enabled = False

        Me.btnCANCELARPAIS.Enabled = False
        Me.btnELIMINARPAIS.Enabled = False
        Me.btnMODIFICARPAIS.Enabled = False
        Me.btnAGREGARPAIS.Enabled = False

        Me.btnCANCELARCONCEPTO.Enabled = False
        Me.btnELIMINARCONCEPTO.Enabled = False
        Me.btnMODIFICARCONCEPTO.Enabled = False
        Me.btnAGREGARCONCEPTO.Enabled = False

        Me.btnCANCELAREQUIPO.Enabled = False
        Me.btnELIMINAREQUIPO.Enabled = False
        Me.btnMODIFICAREQUIPO.Enabled = False
        Me.btnAGREGAREQUIPO.Enabled = False

        Me.btnCANCELARESTADIO.Enabled = False
        Me.btnELIMINARESTADIO.Enabled = False
        Me.btnMODIFICARESTADIO.Enabled = False
        Me.btnAGREGARESTADIO.Enabled = False


        Me.btnCANCELARPROFESION.Enabled = False
        Me.btnELIMINARPROFESION.Enabled = False
        Me.btnMODIFICARPROFESION.Enabled = False
        Me.btnAGREGARPROFESION.Enabled = False

        Me.btnCANCELARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Enabled = False


        Me.lblFECHAHORA.Text = "Hoy, " + Date.Now.ToString
        AbrirConexion()
        cargarGrillaCiudad()
        setEstiloGrillaciudad()
        CerrarConexion()
        Me.timerCIUDAD.Start()
        Me.timerCIUDAD.Interval = 500

        AbrirConexion()
        cargarGrillaIdioma()
        setEstiloGrillaIdioma()
        CerrarConexion()
        Me.timerIDIOMA.Start()
        Me.timerIDIOMA.Interval = 500

        AbrirConexion()
        cargarGrillaCATEGORIA()
        setEstiloGrillaCATEGORIA()
        CerrarConexion()
        Me.timerCATEGORIA.Start()
        Me.timerCATEGORIA.Interval = 500

        AbrirConexion()
        cargarGrillaTIPODOCUMENTO()
        setEstiloGrillaTIPODOCUMENTO()
        CerrarConexion()
        Me.timerTIPODOCUMENTO.Start()
        Me.timerTIPODOCUMENTO.Interval = 500

        AbrirConexion()
        cargarGrillaparentesco()
        setEstiloGrillaparentesco()
        CerrarConexion()
        Me.timerPARENTESCO.Start()
        Me.timerPARENTESCO.Interval = 500


        AbrirConexion()
        cargarGrillapais()
        setEstiloGrillapais()
        CerrarConexion()
        Me.timerPAIS.Start()
        Me.timerPAIS.Interval = 500

        AbrirConexion()
        cargarGrillaConcepto()
        setEstiloGrillaconcepto()
        CerrarConexion()
        Me.timerCONCEPTO.Start()
        Me.timerCONCEPTO.Interval = 500

        AbrirConexion()
        cargarGrillaequipo()
        setEstiloGrillaequipo()
        CerrarConexion()
        Me.timerEQUIPO.Start()
        Me.timerEQUIPO.Interval = 500

        AbrirConexion()
        cargarGrillaestadio()
        setEstiloGrillaestadio()
        CerrarConexion()
        Me.timerESTADIO.Start()
        Me.timerESTADIO.Interval = 500

        AbrirConexion()
        cargarGrillaprofesion()
        setEstiloGrillaprofesion()
        CerrarConexion()
        Me.timerPROFESION.Start()
        Me.timerPROFESION.Interval = 500

        AbrirConexion()
        cargarGrillamantenimientocapital()
        setEstiloGrillamantenimientocapital()
        CerrarConexion()
        Me.timerMANTENIMIENTOCAPITAL.Start()
        Me.timerMANTENIMIENTOCAPITAL.Interval = 500

        AbrirConexion()
        cargarGrilladivisiones()
        setEstiloGrilladivisiones()

        CerrarConexion()
        actualizarchkdivision()
        Me.timerDIVISIONES.Start()
        Me.timerDIVISIONES.Interval = 500


    End Sub

    Private Sub cargarGrillamantenimientocapital()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM mantenimientocapital "

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "mantenimientocapital")

        dataviewLOCAL = New DataView(dsDATOS.Tables("mantenimientocapital"), "", "manmontoinicial ASC", DataViewRowState.OriginalRows)
        Me.dtaMANTENIMIENTOCAPITAL.DataSource = dataviewLOCAL
        Me.dtaMANTENIMIENTOCAPITAL.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillamantenimientocapital()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("mantenimientocapital").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "mancodigo"
            .HeaderText = "Código"
            .Width = 110
        End With


        With estilo2
            .MappingName = "manmontoinicial"
            .HeaderText = "Monto inicial"
            .Width = 250

        End With

        With estilo3
            .MappingName = "manmontofinal"
            .HeaderText = "Monto final"
            .Width = 200
        End With

        With estilo4
            .MappingName = "manmontoasignado"
            .HeaderText = "Monto asignado"
            .Width = 200
        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        estilos.GridColumnStyles.Add(estilo4)

        Me.dtaMANTENIMIENTOCAPITAL.TableStyles.Clear()
        Me.dtaMANTENIMIENTOCAPITAL.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrillaestadio()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM estadio WHERE estnombre ilike '%" & Me.txtBUSQUEDAESTADIO.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "estadio")

        dataviewLOCAL = New DataView(dsDATOS.Tables("estadio"), "estnombre LIKE '%'", "estcodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaESTADIO.DataSource = dataviewLOCAL
        Me.dtaESTADIO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaestadio()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("estadio").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "estcodigo"
            .HeaderText = "Código de equipo"
            .Width = 110
        End With


        With estilo2
            .MappingName = "estnombre"
            .HeaderText = "Nombre del equipo"
            .Width = 250

        End With

        With estilo3
            .MappingName = "estbreve"
            .HeaderText = "Nombre breve"
            .Width = 200
        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)

        Me.dtaESTADIO.TableStyles.Clear()
        Me.dtaESTADIO.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrillapais()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM pais WHERE painombre ilike '%" & Me.txtBUSQUEDAPAIS.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "pais")

        dataviewLOCAL = New DataView(dsDATOS.Tables("pais"), "painombre LIKE '%'", "paicodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaPAIS.DataSource = dataviewLOCAL
        Me.dtaPAIS.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillapais()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("pais").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "paicodigo"
            .HeaderText = "Código de país"
            .Width = 110
        End With


        With estilo2
            .MappingName = "painombre"
            .HeaderText = "Nombre del país"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaPAIS.TableStyles.Clear()
        Me.dtaPAIS.TableStyles.Add(estilos)

    End Sub

    Private Sub cargarGrillaconcepto()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM concepto WHERE connombre ilike '%" & Me.txtBUSQUEDACONCEPTO.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "concepto")

        dataviewLOCAL = New DataView(dsDATOS.Tables("concepto"), "connombre LIKE '%'", "concodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaCONCEPTO.DataSource = dataviewLOCAL
        Me.dtaCONCEPTO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaconcepto()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("concepto").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn
        Dim estilo5 As New DataGridTextBoxColumn
        Dim estilo6 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "concodigo"
            .HeaderText = "Código"
            .Width = 80
        End With


        With estilo2
            .MappingName = "connombre"
            .HeaderText = "Nombre "
            .Width = 250

        End With



        With estilo3
            .MappingName = "conbreve"
            .HeaderText = "Nombre breve"
            .Width = 115
        End With


        With estilo4
            .MappingName = "conmonto"
            .HeaderText = "Monto asignado"
            .Width = 160

        End With


        With estilo5
            .MappingName = "contipo"
            .HeaderText = "Bono o descuento"
            .Width = 100

        End With

        With estilo6
            .MappingName = "condivcodigo"
            .HeaderText = "código de división"
            .Width = 100
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        estilos.GridColumnStyles.Add(estilo4)
        estilos.GridColumnStyles.Add(estilo5)
        estilos.GridColumnStyles.Add(estilo6)

        Me.dtaCONCEPTO.TableStyles.Clear()
        Me.dtaCONCEPTO.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrillaequipo()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM equipo WHERE equinombre ilike '%" & Me.txtBUSQUEDAEQUIPO.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "equipo")

        dataviewLOCAL = New DataView(dsDATOS.Tables("equipo"), "equinombre LIKE '%'", "equicodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaEQUIPO.DataSource = dataviewLOCAL
        Me.dtaEQUIPO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaequipo()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("equipo").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn
        Dim estilo4 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "equicodigo"
            .HeaderText = "Código de equipo"
            .Width = 115
        End With


        With estilo2
            .MappingName = "equinombre"
            .HeaderText = "Nombre de equipo"
            .Width = 295

        End With


        With estilo3
            .MappingName = "equibreve"
            .HeaderText = "Nombre breve"
            .Width = 295

        End With
        With estilo4
            .MappingName = "equidivision"
            .HeaderText = "Division militante"
            .Width = 295

        End With



        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        estilos.GridColumnStyles.Add(estilo4)

        Me.dtaEQUIPO.TableStyles.Clear()
        Me.dtaEQUIPO.TableStyles.Add(estilos)
    End Sub

    Private Sub cargarGrillaProfesion()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT * FROM profesion WHERE profnombre ilike '%" & Me.txtBUSQUEDAPROFESION.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "profesion")

        dataviewLOCAL = New DataView(dsDATOS.Tables("profesion"), "profnombre LIKE '%'", "profcodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaPROFESION.DataSource = dataviewLOCAL
        Me.dtaPROFESION.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaProfesion()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("profesion").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "profcodigo"
            .HeaderText = "Código de profesion"
            .Width = 115
        End With


        With estilo2
            .MappingName = "profnombre"
            .HeaderText = "Nombre de profesión"
            .Width = 295

        End With

        With estilo3
            .MappingName = "profbreve"
            .HeaderText = "Nombre breve de profesión"
            .Width = 295

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)

        Me.dtaPROFESION.TableStyles.Clear()
        Me.dtaPROFESION.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrilladivisiones()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM division WHERE divnombre ilike '%" & Me.txtBUSQUEDADIVISIONES.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "division")

        dataviewLOCAL = New DataView(dsDATOS.Tables("division"), "divnombre LIKE '%'", "divcodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaDIVISIONES.DataSource = dataviewLOCAL
        Me.dtaDIVISIONES.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrilladivisiones()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("division").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "divcodigo"
            .HeaderText = "Código de division"
            .Width = 110
        End With


        With estilo2
            .MappingName = "divnombre"
            .HeaderText = "Nombre de division"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaDIVISIONES.TableStyles.Clear()
        Me.dtaDIVISIONES.TableStyles.Add(estilos)
    End Sub

    Private Sub cargarGrillaCiudad()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM ciudad WHERE nombreciudad ilike '%" & Me.txtBUSQUEDACIUDAD.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "ciudad")

        dataviewLOCAL = New DataView(dsDATOS.Tables("ciudad"), "nombreciudad LIKE '%'", "codciudad ASC", DataViewRowState.OriginalRows)
        Me.dtaCIUDAD.DataSource = dataviewLOCAL
        Me.dtaCIUDAD.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaciudad()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("ciudad").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "codciudad"
            .HeaderText = "Código de ciudad"
            .Width = 110
        End With


        With estilo2
            .MappingName = "nombreciudad"
            .HeaderText = "Nombre de la ciudad"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaCIUDAD.TableStyles.Clear()
        Me.dtaCIUDAD.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrillaparentesco()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM parentesco WHERE parennombre ilike '%" & Me.txtBUSQUEDAPARENTESCO.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "parentesco")

        dataviewLOCAL = New DataView(dsDATOS.Tables("parentesco"), "parennombre LIKE '%'", "parencodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaPARENTESCO.DataSource = dataviewLOCAL
        Me.dtaPARENTESCO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaparentesco()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("parentesco").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "parencodigo"
            .HeaderText = "Código de parentesco"
            .Width = 110
        End With


        With estilo2
            .MappingName = "parennombre"
            .HeaderText = "Nombre de parentesco"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaPARENTESCO.TableStyles.Clear()
        Me.dtaPARENTESCO.TableStyles.Add(estilos)
    End Sub


    Private Sub cargarGrillatipodocumento()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM tipodocumento WHERE docnombre ilike '%" & Me.txtBUSQUEDATIPODOCUMENTO.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "tipodocumento")

        dataviewLOCAL = New DataView(dsDATOS.Tables("tipodocumento"), "docnombre LIKE '%'", "doccodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaTIPODOCUMENTO.DataSource = dataviewLOCAL
        Me.dtaTIPODOCUMENTO.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaTIPODOCUMENTO()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("tipodocumento").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "doccodigo"
            .HeaderText = "Código de tipo de documento"
            .Width = 110
        End With


        With estilo2
            .MappingName = "docnombre"
            .HeaderText = "Nombre de tipo de documento"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaTIPODOCUMENTO.TableStyles.Clear()
        Me.dtaTIPODOCUMENTO.TableStyles.Add(estilos)
    End Sub



    Private Sub cargarGrillaIDIOMA()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM idioma WHERE codnombre ilike '%" & Me.txtBUSQUEDAIDIOMA.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "idioma")

        dataviewLOCAL = New DataView(dsDATOS.Tables("idioma"), "codnombre LIKE '%'", "codidioma ASC", DataViewRowState.OriginalRows)
        Me.dtaIDIOMA.DataSource = dataviewLOCAL
        Me.dtaIDIOMA.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaIDIOMA()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("idioma").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "codidioma"
            .HeaderText = "Código de idioma"
            .Width = 110
        End With


        With estilo2
            .MappingName = "codnombre"
            .HeaderText = "Idioma"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaIDIOMA.TableStyles.Clear()
        Me.dtaIDIOMA.TableStyles.Add(estilos)
    End Sub

    Private Sub cargarGrillaCATEGORIA()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT * FROM categoria WHERE catnombre ilike '%" & Me.txtBUSQUEDACATEGORIA.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "categoria")

        dataviewLOCAL = New DataView(dsDATOS.Tables("categoria"), "catnombre LIKE '%'", "catcodigo ASC", DataViewRowState.OriginalRows)
        Me.dtaCATEGORIA.DataSource = dataviewLOCAL
        Me.dtaCATEGORIA.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaCategoria()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color

        estilos.MappingName = dsDATOS.Tables("categoria").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn


        With estilo1
            .MappingName = "catcodigo"
            .HeaderText = "Código de categoría"
            .Width = 190
        End With


        With estilo2
            .MappingName = "catnombre"
            .HeaderText = "Nombre de categoría"
            .Width = 310
        End With

        With estilo3
            .MappingName = "catnivel"
            .HeaderText = "Nivel"
            .Width = 205
        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)

        Me.dtaCATEGORIA.TableStyles.Clear()
        Me.dtaCATEGORIA.TableStyles.Add(estilos)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCIUDAD.Tick

        Me.lblFECHAHORA.Text = "Hoy, " + Date.Now.ToString()
        If (actualizardatagridCIUDAD = True) Then

            AbrirConexion()
            cargarGrillaCiudad()
            setEstiloGrillaciudad()
            CerrarConexion()
            actualizardatagridCIUDAD = False
            Me.dtaCIUDAD.Update()

        End If

    End Sub

    Private Sub btnAGREGARCIUDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARCIUDAD.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOCIUDAD.Text = "" Or Me.txtDESCRIPCIONCIUDAD.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from ciudad WHERE codciudad = " & Me.intCODIGOCIUDAD.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN CIUDADES HOMÓNIMAS

            AbrirConexion()
            strSQL = "SELECT * from ciudad WHERE nombreciudad ILIKE '" & Me.txtDESCRIPCIONCIUDAD.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único para las ciudades...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO ciudad (codciudad, nombreciudad) VALUES (" & _
                    Me.intCODIGOCIUDAD.Text & ", '" & Me.txtDESCRIPCIONCIUDAD.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El nombre de ciudad fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOCIUDAD.Text = ""
        Me.txtDESCRIPCIONCIUDAD.Text = ""
        Me.intCODIGOCIUDAD.Focus()
        actualizardatagridCIUDAD = True


    End Sub

    Private Sub intCODIGOCIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOCIUDAD.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOCIUDAD.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If
    End Sub

    Private Sub intCODIGOCIUDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOCIUDAD.TextChanged

    End Sub

    Private Sub txtDESCRIPCIONCIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDESCRIPCIONCIUDAD.KeyPress
        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtDESCRIPCIONCIUDAD.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If
    End Sub

    Private Sub txtDESCRIPCIONCIUDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDESCRIPCIONCIUDAD.TextChanged

    End Sub

    Private Sub btnNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOCIUDAD.Click

        Try
            AbrirConexion()
            strSQL = "SELECT codciudad FROM ciudad order by codciudad desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOCIUDAD.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOCIUDAD.Text = "1"
        End Try


        Me.txtDESCRIPCIONCIUDAD.Text = ""
        Me.btnAGREGARCIUDAD.Enabled = True
        Me.btnMODIFICARCIUDAD.Enabled = False
        Me.btnELIMINARCIUDAD.Enabled = False
        Me.btnCANCELARCIUDAD.Enabled = True
        Me.intCODIGOCIUDAD.Focus()
    End Sub



    Private Sub dtaCIUDAD_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaCIUDAD.Scroll



    End Sub

    Private Sub dtaCIUDAD_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaCIUDAD.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARCIUDAD.Enabled = False
        Me.btnMODIFICARCIUDAD.Enabled = True
        Me.btnELIMINARCIUDAD.Enabled = True
        Me.btnCANCELARCIUDAD.Enabled = True

        filaGrillaActual = Me.dtaCIUDAD.CurrentCell.RowNumber

        Try

            Me.intCODIGOCIUDAD.Text = Me.dtaCIUDAD.Item(filaGrillaActual, 0)
            Me.txtDESCRIPCIONCIUDAD.Text = Me.dtaCIUDAD.Item(filaGrillaActual, 1)
            Me.intCODIGOCIUDAD.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOCIUDAD.Text = ""
            Me.txtDESCRIPCIONCIUDAD.Text = ""
            Me.intCODIGOCIUDAD.Focus()
            Me.btnAGREGARCIUDAD.Enabled = False
            Me.btnMODIFICARCIUDAD.Enabled = False
            Me.btnELIMINARCIUDAD.Enabled = False
            Me.btnCANCELARCIUDAD.Enabled = True
        End Try

    End Sub

    Private Sub btnCANCELARCIUDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARCIUDAD.Click

        Me.intCODIGOCIUDAD.Text = ""
        Me.txtDESCRIPCIONCIUDAD.Text = ""
        Me.txtBUSQUEDACIUDAD.Text = ""
        Me.intCODIGOCIUDAD.Focus()
        Me.btnAGREGARCIUDAD.Enabled = False
        Me.btnMODIFICARCIUDAD.Enabled = False
        Me.btnELIMINARCIUDAD.Enabled = False
        Me.btnCANCELARCIUDAD.Enabled = True

    End Sub

    Private Sub btnMODIFICARCIUDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARCIUDAD.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGOCIUDAD As Integer
            Dim auxNOMBRECIUDAD As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT codciudad FROM ciudad;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOCIUDAD = myReader.GetValue(0)
                If (auxCODIGOCIUDAD <> Integer.Parse(Me.intCODIGOCIUDAD.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT nombreciudad FROM ciudad WHERE codciudad=" & auxCODIGOCIUDAD
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBRECIUDAD = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBRECIUDAD, Me.txtDESCRIPCIONCIUDAD.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update ciudad set " & _
                                               "codciudad = " & Me.intCODIGOCIUDAD.Text & ", " & _
                                               "nombreciudad = '" & Me.txtDESCRIPCIONCIUDAD.Text & "' " & _
                                               "where codciudad = " & Me.intCODIGOCIUDAD.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro de ciudad", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridCIUDAD = True

            Else
                MessageBox.Show("El nombre de ciudad que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub dtaCIUDAD_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaCIUDAD.Navigate

    End Sub

    Private Sub btnELIMINARCIUDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARCIUDAD.Click

        Dim auxCODIGOCIUDAD As Integer
        Dim auxNOMBRECIUDAD As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT codciudad FROM ciudad WHERE nombreciudad= '" & Me.txtDESCRIPCIONCIUDAD.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOCIUDAD = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOCIUDAD = Integer.Parse(Me.intCODIGOCIUDAD.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from ciudad where codciudad = " & auxCODIGOCIUDAD & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridCIUDAD = True
                    Me.btnAGREGARCIUDAD.Enabled = False
                    Me.btnMODIFICARCIUDAD.Enabled = False
                    Me.btnELIMINARCIUDAD.Enabled = False
                    Me.intCODIGOCIUDAD.Text = ""
                    Me.txtDESCRIPCIONCIUDAD.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub lblNUEVOIDIOMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNUEVOIDIOMA.Click

        Try
            AbrirConexion()
            strSQL = "SELECT codidioma FROM idioma order by codidioma desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOIDIOMA.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOIDIOMA.Text = "1"
        End Try


        Me.txtNOMBREIDIOMA.Text = ""
        Me.btnAGREGARIDIOMA.Enabled = True
        Me.btnMODIFICARIDIOMA.Enabled = False
        Me.btnELIMINARIDIOMA.Enabled = False
        Me.btnCANCELARIDIOMA.Enabled = True
        Me.intCODIGOIDIOMA.Focus()

    End Sub

    Private Sub timerIDIOMA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerIDIOMA.Tick

        If (actualizardatagridIDIOMA = True) Then

            AbrirConexion()
            cargarGrillaIDIOMA()
            setEstiloGrillaIDIOMA()
            CerrarConexion()
            actualizardatagridIDIOMA = False
            Me.dtaIDIOMA.Update()

        End If
    End Sub

    Private Sub intCODIGOIDIOMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOIDIOMA.TextChanged

    End Sub

    Private Sub intCODIGOIDIOMA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOIDIOMA.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOIDIOMA.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If
    End Sub

    Private Sub txtNOMBREIDIOMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREIDIOMA.TextChanged

    End Sub

    Private Sub txtNOMBREIDIOMA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREIDIOMA.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREIDIOMA.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnAGREGARIDIOMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARIDIOMA.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOIDIOMA.Text = "" Or Me.txtNOMBREIDIOMA.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from idioma WHERE codidioma = " & Me.intCODIGOIDIOMA.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN IDIOMAS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from idioma WHERE codnombre ILIKE '" & Me.txtNOMBREIDIOMA.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El registro ingresado es repetido, por favor ingrese un registro único ...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO idioma (codidioma, codnombre) VALUES (" & _
                    Me.intCODIGOIDIOMA.Text & ", '" & Me.txtNOMBREIDIOMA.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
                    End

                End Try
            Else

            End If
        End If

        Me.intCODIGOIDIOMA.Text = ""
        Me.txtNOMBREIDIOMA.Text = ""
        Me.intCODIGOIDIOMA.Focus()
        actualizardatagridIDIOMA = True

    End Sub

    Private Sub btnMODIFICARIDIOMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARIDIOMA.Click

        Try
            'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
            'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
            'ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
            'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO


            Dim auxCODIGOIDIOMA As Integer
            Dim auxNOMBREIDIOMA As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT codidioma FROM idioma;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False


            While myReader.Read()

                auxCODIGOIDIOMA = myReader.GetValue(0)
                If (auxCODIGOIDIOMA <> Integer.Parse(Me.intCODIGOIDIOMA.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT codnombre FROM idioma WHERE codidioma=" & auxCODIGOIDIOMA
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREIDIOMA = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBREIDIOMA, Me.txtNOMBREIDIOMA.Text, True) = 0) Then

                        blnexiste = True
                        Exit While
                    End If


                End If
            End While
            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then

                strSQL = "update idioma set " & _
                                               "codidioma = " & Me.intCODIGOIDIOMA.Text & ", " & _
                                               "codnombre = '" & Me.txtNOMBREIDIOMA.Text & "' " & _
                                               "where codidioma = " & Me.intCODIGOIDIOMA.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro..", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridIDIOMA = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Hubo un problema al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub dtaIDIOMA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaIDIOMA.Navigate

    End Sub

    Private Sub dtaIDIOMA_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaIDIOMA.Scroll

    End Sub

    Private Sub dtaIDIOMA_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaIDIOMA.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARIDIOMA.Enabled = False
        Me.btnMODIFICARIDIOMA.Enabled = True
        Me.btnELIMINARIDIOMA.Enabled = True
        Me.btnCANCELARIDIOMA.Enabled = True

        filaGrillaActual = Me.dtaIDIOMA.CurrentCell.RowNumber

        Try

            Me.intCODIGOIDIOMA.Text = Me.dtaIDIOMA.Item(filaGrillaActual, 0)
            Me.txtNOMBREIDIOMA.Text = Me.dtaIDIOMA.Item(filaGrillaActual, 1)
            Me.intCODIGOIDIOMA.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOIDIOMA.Text = ""
            Me.txtNOMBREIDIOMA.Text = ""
            Me.intCODIGOIDIOMA.Focus()
            Me.btnAGREGARIDIOMA.Enabled = False
            Me.btnMODIFICARIDIOMA.Enabled = False
            Me.btnELIMINARIDIOMA.Enabled = False
            Me.btnCANCELARIDIOMA.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINARIDIOMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARIDIOMA.Click

        Dim auxCODIGOIDIOMA As Integer
        Dim auxNOMBREIDIOMA As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT codidioma FROM idioma WHERE codnombre= '" & Me.txtNOMBREIDIOMA.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOIDIOMA = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOIDIOMA = Integer.Parse(Me.intCODIGOIDIOMA.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from idioma where codidioma = " & auxCODIGOIDIOMA & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridCIUDAD = True
                    Me.btnAGREGARIDIOMA.Enabled = False
                    Me.btnMODIFICARIDIOMA.Enabled = False
                    Me.btnELIMINARIDIOMA.Enabled = False
                    Me.intCODIGOIDIOMA.Text = ""
                    Me.txtNOMBREIDIOMA.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

        actualizardatagridIDIOMA = True

    End Sub

    Private Sub btnCANCELARIDIOMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARIDIOMA.Click
        Me.intCODIGOIDIOMA.Text = ""
        Me.txtNOMBREIDIOMA.Text = ""
        Me.txtBUSQUEDAIDIOMA.Text = ""

        Me.intCODIGOIDIOMA.Focus()
        Me.btnAGREGARIDIOMA.Enabled = False
        Me.btnMODIFICARIDIOMA.Enabled = False
        Me.btnELIMINARIDIOMA.Enabled = False
        Me.btnCANCELARIDIOMA.Enabled = True
    End Sub

    Private Sub timerCATEGORIA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCATEGORIA.Tick

        If (actualizardatagridCATEGORIA = True) Then

            AbrirConexion()
            cargarGrillaCATEGORIA()
            setEstiloGrillaCategoria()
            CerrarConexion()
            actualizardatagridCATEGORIA = False
            Me.dtaCATEGORIA.Update()

        End If

    End Sub

    Private Sub txtCODIGOCATEGORIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGOCATEGORIA.TextChanged

    End Sub

    Private Sub txtCODIGOCATEGORIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCODIGOCATEGORIA.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtCODIGOCATEGORIA.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBRECATEGORIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBRECATEGORIA.TextChanged

    End Sub

    Private Sub txtNOMBRECATEGORIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBRECATEGORIA.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBRECATEGORIA.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub txtNIVEL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIVELCATEGORIA.TextChanged

    End Sub

    Private Sub txtNIVEL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIVELCATEGORIA.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNIVELCATEGORIA.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub txtBUSQUEDAIDIOMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAIDIOMA.TextChanged
        actualizardatagridIDIOMA = True
    End Sub

    Private Sub txtBUSQUEDACIUDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDACIUDAD.TextChanged
        actualizardatagridCIUDAD = True
    End Sub

    Private Sub txtBUSQUEDACIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDACIUDAD.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDACIUDAD.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub txtBUSQUEDAIDIOMA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAIDIOMA.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAIDIOMA.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub txtBUSQUEDACATEGORIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDACATEGORIA.TextChanged
        actualizardatagridCATEGORIA = True
    End Sub

    Private Sub txtBUSQUEDACATEGORIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDACATEGORIA.KeyPress
        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDACATEGORIA.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If
    End Sub

    Private Sub btnNUEVOCATEGORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOCATEGORIA.Click

        Try
            AbrirConexion()
            strSQL = "SELECT catcodigo FROM categoria order by catcodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.txtCODIGOCATEGORIA.Text = auxcodigo

        Catch ex As Exception
            Me.txtCODIGOCATEGORIA.Text = "1"
        End Try


        Me.txtNOMBRECATEGORIA.Text = ""
        Me.txtNIVELCATEGORIA.Text = ""
        Me.btnAGREGARCATEGORIA.Enabled = True
        Me.btnMODIFICARCATEGORIA.Enabled = False
        Me.btnELIMINARCATEGORIA.Enabled = False
        Me.btnCANCELARCATEGORIA.Enabled = True
        Me.txtCODIGOCATEGORIA.Focus()

    End Sub

    Private Sub btnAGREGARCATEGORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARCATEGORIA.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.txtCODIGOCATEGORIA.Text = "" Or Me.txtNOMBRECATEGORIA.Text = "" Or Me.txtNIVELCATEGORIA.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from categoria WHERE catcodigo = " & Me.txtCODIGOCATEGORIA.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN categorias HOMÓNIMAS

            AbrirConexion()
            strSQL = "SELECT * from categoria WHERE catnombre ILIKE '" & Me.txtNOMBRECATEGORIA.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO categoria (catcodigo, catnombre,catnivel) VALUES (" & _
                    Me.txtCODIGOCATEGORIA.Text & ", '" & Me.txtNOMBRECATEGORIA.Text & "','" & _
                    Me.txtNIVELCATEGORIA.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.txtCODIGOCATEGORIA.Text = ""
        Me.txtNOMBRECATEGORIA.Text = ""
        Me.txtNIVELCATEGORIA.Text = ""
        Me.txtCODIGOCATEGORIA.Focus()
        actualizardatagridCATEGORIA = True


    End Sub

    Private Sub dtaCATEGORIA_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaCATEGORIA.CurrentCellChanged
        Dim filaGrillaActual As Integer

        Me.btnAGREGARCATEGORIA.Enabled = False
        Me.btnMODIFICARCATEGORIA.Enabled = True
        Me.btnELIMINARCATEGORIA.Enabled = True
        Me.btnCANCELARCATEGORIA.Enabled = True

        filaGrillaActual = Me.dtaCATEGORIA.CurrentCell.RowNumber

        Try

            Me.txtCODIGOCATEGORIA.Text = Me.dtaCATEGORIA.Item(filaGrillaActual, 0)
            Me.txtNOMBRECATEGORIA.Text = Me.dtaCATEGORIA.Item(filaGrillaActual, 1)
            Me.txtNIVELCATEGORIA.Text = Me.dtaCATEGORIA.Item(filaGrillaActual, 2)
            Me.intCODIGOCIUDAD.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.txtCODIGOCATEGORIA.Text = ""
            Me.txtNOMBRECATEGORIA.Text = ""
            Me.txtNIVELCATEGORIA.Text = ""
            Me.txtCODIGOCATEGORIA.Text = ""
            Me.btnAGREGARCATEGORIA.Enabled = False
            Me.btnMODIFICARCATEGORIA.Enabled = False
            Me.btnELIMINARCATEGORIA.Enabled = False
            Me.btnCANCELARCATEGORIA.Enabled = True
        End Try
    End Sub

    Private Sub btnMODIFICARCATEGORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARCATEGORIA.Click
        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO DE categoria INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'DE CLIENTE ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO DE CLIENTE

        Try
            Dim auxCODIGOcategoria As Integer
            Dim auxNOMBREcategoria As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT catcodigo FROM categoria;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False


            While myReader.Read()

                auxCODIGOcategoria = myReader.GetValue(0)
                If (auxCODIGOcategoria <> Integer.Parse(Me.txtCODIGOCATEGORIA.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT catnombre FROM categoria WHERE catcodigo=" & auxCODIGOcategoria
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREcategoria = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBREcategoria, Me.txtNOMBRECATEGORIA.Text, True) = 0) Then

                        blnexiste = True
                        Exit While
                    End If

                End If
            End While
            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then

                strSQL = "update categoria set " & _
                                               "catcodigo = " & Me.txtCODIGOCATEGORIA.Text & ", " & _
                                               "catnombre = '" & Me.txtNOMBRECATEGORIA.Text & "', " & _
                                               "catnivel = '" & Me.txtNIVELCATEGORIA.Text & "' " & _
                                               "where catcodigo = " & Me.txtCODIGOCATEGORIA.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridCATEGORIA = True

            Else
                MessageBox.Show("El nombre de categoria que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try



    End Sub

    Private Sub dtaCATEGORIA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaCATEGORIA.Navigate

    End Sub

    Private Sub btnELIMINARCATEGORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARCATEGORIA.Click
        Dim auxCODIGOCATEGORIA As Integer
        Dim auxNOMBRECATEGORIA As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT catcodigo FROM categoria WHERE catnombre= '" & Me.txtNOMBRECATEGORIA.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOCATEGORIA = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOCATEGORIA = Integer.Parse(Me.txtCODIGOCATEGORIA.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from categoria where catcodigo = " & auxCODIGOCATEGORIA & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridCATEGORIA = True
                    Me.btnAGREGARCATEGORIA.Enabled = False
                    Me.btnMODIFICARCATEGORIA.Enabled = False
                    Me.btnELIMINARCATEGORIA.Enabled = False
                    Me.txtCODIGOCATEGORIA.Text = ""
                    Me.txtNOMBRECATEGORIA.Text = ""
                    Me.txtNIVELCATEGORIA.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCANCELARCATEGORIA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCANCELARCATEGORIA.Click
        Me.txtCODIGOCATEGORIA.Text = ""
        Me.txtNOMBRECATEGORIA.Text = ""
        Me.txtNIVELCATEGORIA.Text = ""
        Me.txtBUSQUEDACATEGORIA.Text = ""

        Me.txtCODIGOCATEGORIA.Focus()
        Me.btnAGREGARCATEGORIA.Enabled = False
        Me.btnMODIFICARCATEGORIA.Enabled = False
        Me.btnELIMINARCATEGORIA.Enabled = False
        Me.btnCANCELARCATEGORIA.Enabled = True
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTIPODOCUMENTO.Tick
        If (actualizardatagridtipodocumento = True) Then

            AbrirConexion()
            cargarGrillatipodocumento()
            setEstiloGrillaTIPODOCUMENTO()
            CerrarConexion()
            actualizardatagridtipodocumento = False
            Me.dtaTIPODOCUMENTO.Update()

        End If
    End Sub

    Private Sub intCODIGOTIPODOCUMENTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOTIPODOCUMENTO.TextChanged

    End Sub

    Private Sub intCODIGOTIPODOCUMENTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOTIPODOCUMENTO.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOTIPODOCUMENTO.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBRETIPODOCUMENTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBRETIPODOCUMENTO.TextChanged

    End Sub

    Private Sub txtNOMBRETIPODOCUMENTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBRETIPODOCUMENTO.KeyPress
        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBRETIPODOCUMENTO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If
    End Sub

    Private Sub btnNUEVOTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOTIPODOCUMENTO.Click

        Try
            AbrirConexion()
            strSQL = "SELECT doccodigo FROM tipodocumento order by doccodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOTIPODOCUMENTO.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOTIPODOCUMENTO.Text = "1"
        End Try


        Me.txtNOMBRETIPODOCUMENTO.Text = ""
        Me.btnAGREGARTIPODOCUMENTO.Enabled = True
        Me.btnMODIFICARTIPODOCUMENTO.Enabled = False
        Me.btnELIMINARTIPODOCUMENTO.Enabled = False
        Me.btnCANCELARTIPODOCUMENTO.Enabled = True
        Me.intCODIGOTIPODOCUMENTO.Focus()

    End Sub

    Private Sub btnAGREGARTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARTIPODOCUMENTO.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOTIPODOCUMENTO.Text = "" Or Me.txtNOMBRETIPODOCUMENTO.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from tipodocumento WHERE doccodigo = " & Me.intCODIGOTIPODOCUMENTO.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN nombres HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from tipodocumento WHERE docnombre ILIKE '" & Me.txtNOMBRETIPODOCUMENTO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO tipodocumento (doccodigo, docnombre) VALUES (" & _
                    Me.intCODIGOTIPODOCUMENTO.Text & ", '" & Me.txtNOMBRETIPODOCUMENTO.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El nombre fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOTIPODOCUMENTO.Text = ""
        Me.txtNOMBRETIPODOCUMENTO.Text = ""
        Me.intCODIGOTIPODOCUMENTO.Focus()
        actualizardatagridtipodocumento = True

    End Sub

    Private Sub dtaTIPODOCUMENTO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaTIPODOCUMENTO.Navigate

    End Sub

    Private Sub dtaTIPODOCUMENTO_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaTIPODOCUMENTO.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARTIPODOCUMENTO.Enabled = False
        Me.btnMODIFICARTIPODOCUMENTO.Enabled = True
        Me.btnELIMINARTIPODOCUMENTO.Enabled = True
        Me.btnCANCELARTIPODOCUMENTO.Enabled = True

        filaGrillaActual = Me.dtaTIPODOCUMENTO.CurrentCell.RowNumber

        Try

            Me.intCODIGOTIPODOCUMENTO.Text = Me.dtaTIPODOCUMENTO.Item(filaGrillaActual, 0)
            Me.txtNOMBRETIPODOCUMENTO.Text = Me.dtaTIPODOCUMENTO.Item(filaGrillaActual, 1)
            Me.intCODIGOTIPODOCUMENTO.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOTIPODOCUMENTO.Text = ""
            Me.txtNOMBRETIPODOCUMENTO.Text = ""
            Me.intCODIGOTIPODOCUMENTO.Focus()
            Me.btnAGREGARTIPODOCUMENTO.Enabled = False
            Me.btnMODIFICARTIPODOCUMENTO.Enabled = False
            Me.btnELIMINARTIPODOCUMENTO.Enabled = False
            Me.btnCANCELARTIPODOCUMENTO.Enabled = True
        End Try

    End Sub

    Private Sub btnMODIFICARTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARTIPODOCUMENTO.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO  INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        ' ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO 

        Try

            Dim auxCODIGOTIPODOCUMENTO As Integer
            Dim auxNOMBRETIPODOCUMENTO As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT doccodigo FROM tipodocumento;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOTIPODOCUMENTO = myReader.GetValue(0)
                If (auxCODIGOTIPODOCUMENTO <> Integer.Parse(Me.intCODIGOTIPODOCUMENTO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT docnombre FROM tipodocumento WHERE doccodigo=" & auxCODIGOTIPODOCUMENTO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBRETIPODOCUMENTO = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBRETIPODOCUMENTO, Me.txtNOMBRETIPODOCUMENTO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update tipodocumento set " & _
                                               "doccodigo = " & Me.intCODIGOTIPODOCUMENTO.Text & ", " & _
                                               "docnombre = '" & Me.txtNOMBRETIPODOCUMENTO.Text & "' " & _
                                               "where doccodigo = " & Me.intCODIGOTIPODOCUMENTO.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridtipodocumento = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnELIMINARTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARTIPODOCUMENTO.Click


        Dim auxCODIGOtipodocumento As Integer
        Dim auxNOMBREtipodocumento As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT doccodigo FROM tipodocumento WHERE docnombre= '" & Me.txtNOMBRETIPODOCUMENTO.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOtipodocumento = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOtipodocumento = Integer.Parse(Me.intCODIGOTIPODOCUMENTO.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from tipodocumento where doccodigo = " & auxCODIGOtipodocumento & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridtipodocumento = True
                    Me.btnAGREGARTIPODOCUMENTO.Enabled = False
                    Me.btnMODIFICARTIPODOCUMENTO.Enabled = False
                    Me.btnELIMINARTIPODOCUMENTO.Enabled = False
                    Me.intCODIGOTIPODOCUMENTO.Text = ""
                    Me.txtNOMBRETIPODOCUMENTO.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnCANCELARTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARTIPODOCUMENTO.Click

        Me.intCODIGOTIPODOCUMENTO.Text = ""
        Me.txtNOMBRETIPODOCUMENTO.Text = ""
        Me.txtBUSQUEDATIPODOCUMENTO.Text = ""
        Me.intCODIGOTIPODOCUMENTO.Focus()
        Me.btnAGREGARTIPODOCUMENTO.Enabled = False
        Me.btnMODIFICARTIPODOCUMENTO.Enabled = False
        Me.btnELIMINARTIPODOCUMENTO.Enabled = False
        Me.btnCANCELARTIPODOCUMENTO.Enabled = True


    End Sub

    Private Sub txtBUSQUEDATIPODOCUMENTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDATIPODOCUMENTO.TextChanged

        actualizardatagridtipodocumento = True

    End Sub

    Private Sub txtBUSQUEDATIPODOCUMENTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDATIPODOCUMENTO.KeyPress


        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDATIPODOCUMENTO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If


    End Sub

    Private Sub tabpTIPODOCUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpTIPODOCUMENTO.Click

    End Sub

    Private Sub txtBUSQUEDATIPODOCUMENTO_ImeModeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBUSQUEDATIPODOCUMENTO.ImeModeChanged

    End Sub

    Private Sub Timer1_Tick_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPARENTESCO.Tick
        If (actualizardatagridparentesco = True) Then

            AbrirConexion()
            cargarGrillaparentesco()
            setEstiloGrillaparentesco()
            CerrarConexion()
            actualizardatagridparentesco = False
            Me.dtaPARENTESCO.Update()

        End If

    End Sub

    Private Sub btnMODIFICARPARENTESCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARPARENTESCO.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO DE CLIENTE INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'DE CLIENTE ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO DE CLIENTE

        Try


            Dim auxCODIGOPARENTESCO As Integer
            Dim auxNOMBREPARENTESCO As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT parencodigo FROM parentesco;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOPARENTESCO = myReader.GetValue(0)
                If (auxCODIGOPARENTESCO <> Integer.Parse(Me.intCODIGOPARENTESCO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT parennombre FROM parentesco WHERE parencodigo=" & auxCODIGOPARENTESCO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREPARENTESCO = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBREPARENTESCO, Me.txtNOMBREPARENTESCO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update parentesco set " & _
                                               "parencodigo = " & Me.intCODIGOPARENTESCO.Text & ", " & _
                                               "parennombre = '" & Me.txtNOMBREPARENTESCO.Text & "' " & _
                                               "where parencodigo = " & Me.intCODIGOPARENTESCO.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridparentesco = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnAGREGARPARENTESCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARPARENTESCO.Click
        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOPARENTESCO.Text = "" Or Me.txtNOMBREPARENTESCO.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from parentesco WHERE parencodigo = " & Me.intCODIGOPARENTESCO.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN PARENTESCOS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from parentesco WHERE parennombre ILIKE '" & Me.txtNOMBREPARENTESCO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único ...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO parentesco (parencodigo, parennombre) VALUES (" & _
                    Me.intCODIGOPARENTESCO.Text & ", '" & Me.txtNOMBREPARENTESCO.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El nombre fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOPARENTESCO.Text = ""
        Me.txtNOMBREPARENTESCO.Text = ""
        Me.intCODIGOPARENTESCO.Focus()
        actualizardatagridparentesco = True

    End Sub

    Private Sub intCODIGOPARENTESCO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOPARENTESCO.TextChanged

    End Sub

    Private Sub intCODIGOPARENTESCO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOPARENTESCO.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOPARENTESCO.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If


    End Sub

    Private Sub txtNOMBREPARENTESCO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREPARENTESCO.TextChanged

    End Sub

    Private Sub txtNOMBREPARENTESCO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREPARENTESCO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREPARENTESCO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If


    End Sub

    Private Sub btnNUEVOPARENTESCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOPARENTESCO.Click

        Try
            AbrirConexion()
            strSQL = "SELECT parencodigo FROM parentesco order by parencodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOPARENTESCO.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOPARENTESCO.Text = "1"
        End Try


        Me.txtNOMBREPARENTESCO.Text = ""
        Me.btnAGREGARPARENTESCO.Enabled = True
        Me.btnMODIFICARPARENTESCO.Enabled = False
        Me.btnELIMINARPARENTESCO.Enabled = False
        Me.btnCANCELARPARENTESCO.Enabled = True
        Me.intCODIGOPARENTESCO.Focus()

    End Sub

    Private Sub dtaPARENTESCO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaPARENTESCO.Navigate

    End Sub

    Private Sub dtaPARENTESCO_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaPARENTESCO.CurrentCellChanged


        Dim filaGrillaActual As Integer

        Me.btnAGREGARPARENTESCO.Enabled = False
        Me.btnMODIFICARPARENTESCO.Enabled = True
        Me.btnELIMINARPARENTESCO.Enabled = True
        Me.btnCANCELARPARENTESCO.Enabled = True

        filaGrillaActual = Me.dtaPARENTESCO.CurrentCell.RowNumber

        Try

            Me.intCODIGOPARENTESCO.Text = Me.dtaPARENTESCO.Item(filaGrillaActual, 0)
            Me.txtNOMBREPARENTESCO.Text = Me.dtaPARENTESCO.Item(filaGrillaActual, 1)
            Me.intCODIGOPARENTESCO.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOPARENTESCO.Text = ""
            Me.txtNOMBREPARENTESCO.Text = ""
            Me.intCODIGOPARENTESCO.Focus()
            Me.btnAGREGARPARENTESCO.Enabled = False
            Me.btnMODIFICARPARENTESCO.Enabled = False
            Me.btnELIMINARPARENTESCO.Enabled = False
            Me.btnCANCELARPARENTESCO.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINARPARENTESCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARPARENTESCO.Click

        Dim auxCODIGOparentesco As Integer
        Dim auxNOMBREparentesco As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT parencodigo FROM parentesco WHERE parennombre= '" & Me.txtNOMBREPARENTESCO.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOparentesco = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOparentesco = Integer.Parse(Me.intCODIGOPARENTESCO.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from parentesco where parencodigo = " & auxCODIGOparentesco & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridparentesco = True
                    Me.btnAGREGARPARENTESCO.Enabled = False
                    Me.btnMODIFICARPARENTESCO.Enabled = False
                    Me.btnELIMINARPARENTESCO.Enabled = False
                    Me.intCODIGOPARENTESCO.Text = ""
                    Me.txtNOMBREPARENTESCO.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELARPARENTESCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARPARENTESCO.Click

        Me.intCODIGOPARENTESCO.Text = ""
        Me.txtNOMBREPARENTESCO.Text = ""
        Me.txtBUSQUEDAPARENTESCO.Text = ""

        Me.intCODIGOPARENTESCO.Focus()
        Me.btnAGREGARPARENTESCO.Enabled = False
        Me.btnMODIFICARPARENTESCO.Enabled = False
        Me.btnELIMINARPARENTESCO.Enabled = False
        Me.btnCANCELARPARENTESCO.Enabled = True

    End Sub

    Private Sub txtBUSQUEDAPARENTESCO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAPARENTESCO.TextChanged
        actualizardatagridparentesco = True
    End Sub

    Private Sub txtBUSQUEDAPARENTESCO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAPARENTESCO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAPARENTESCO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub Timer1_Tick_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPAIS.Tick

        If (actualizardatagridpais = True) Then

            AbrirConexion()
            cargarGrillapais()
            setEstiloGrillapais()
            CerrarConexion()
            actualizardatagridpais = False
            Me.dtaPAIS.Update()

        End If

    End Sub

    Private Sub intCODIGOPAIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOPAIS.TextChanged

    End Sub

    Private Sub intCODIGOPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOPAIS.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOPAIS.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If


    End Sub

    Private Sub txtNOMBREPAIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREPAIS.TextChanged

    End Sub

    Private Sub txtNOMBREPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREPAIS.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREPAIS.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnNUEVOPAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOPAIS.Click

        Try
            AbrirConexion()
            strSQL = "SELECT paicodigo FROM pais order by paicodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOPAIS.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOPAIS.Text = "1"
        End Try

        Me.txtNOMBREPAIS.Text = ""
        Me.btnAGREGARPAIS.Enabled = True
        Me.btnMODIFICARPAIS.Enabled = False
        Me.btnELIMINARPAIS.Enabled = False
        Me.btnCANCELARPAIS.Enabled = True
        Me.intCODIGOPAIS.Focus()

    End Sub

    Private Sub btnAGREGARPAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARPAIS.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOPAIS.Text = "" Or Me.txtNOMBREPAIS.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from pais WHERE paicodigo = " & Me.intCODIGOPAIS.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN CIUDADES HOMÓNIMAS

            AbrirConexion()
            strSQL = "SELECT * from pais WHERE painombre ILIKE '" & Me.txtNOMBREPAIS.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único para las ciudades...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO pais (paicodigo, painombre) VALUES (" & _
                    Me.intCODIGOPAIS.Text & ", '" & Me.txtNOMBREPAIS.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El nombre fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOPAIS.Text = ""
        Me.txtNOMBREPAIS.Text = ""
        Me.intCODIGOPAIS.Focus()
        actualizardatagridpais = True

    End Sub

    Private Sub dtaPAIS_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaPAIS.Navigate

    End Sub

    Private Sub dtaPAIS_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaPAIS.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARPAIS.Enabled = False
        Me.btnMODIFICARPAIS.Enabled = True
        Me.btnELIMINARPAIS.Enabled = True
        Me.btnCANCELARPAIS.Enabled = True

        filaGrillaActual = Me.dtaPAIS.CurrentCell.RowNumber

        Try

            Me.intCODIGOPAIS.Text = Me.dtaPAIS.Item(filaGrillaActual, 0)
            Me.txtNOMBREPAIS.Text = Me.dtaPAIS.Item(filaGrillaActual, 1)
            Me.intCODIGOPAIS.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOPAIS.Text = ""
            Me.txtNOMBREPAIS.Text = ""
            Me.intCODIGOPAIS.Focus()
            Me.btnAGREGARPAIS.Enabled = False
            Me.btnMODIFICARPAIS.Enabled = False
            Me.btnELIMINARPAIS.Enabled = False
            Me.btnCANCELARPAIS.Enabled = True
        End Try


    End Sub

    Private Sub btnMODIFICARPAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARPAIS.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO DE CLIENTE INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'DE CLIENTE ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO DE CLIENTE

        Try


            Dim auxCODIGOpais As Integer
            Dim auxNOMBREpais As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT paicodigo FROM pais;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOpais = myReader.GetValue(0)
                If (auxCODIGOpais <> Integer.Parse(Me.intCODIGOPAIS.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT painombre FROM pais WHERE paicodigo=" & auxCODIGOpais
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREpais = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREpais, Me.txtNOMBREPAIS.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then

                strSQL = "update pais set " & _
                                               "paicodigo = " & Me.intCODIGOPAIS.Text & ", " & _
                                               "painombre = '" & Me.txtNOMBREPAIS.Text & "' " & _
                                               "where paicodigo = " & Me.intCODIGOPAIS.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridpais = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnELIMINARPAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARPAIS.Click

        Dim auxCODIGOpais As Integer
        Dim auxNOMBREpais As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT paicodigo FROM pais WHERE painombre= '" & Me.txtNOMBREPAIS.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOpais = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOpais = Integer.Parse(Me.intCODIGOPAIS.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from pais where paicodigo = " & auxCODIGOpais & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridpais = True
                    Me.btnAGREGARPAIS.Enabled = False
                    Me.btnMODIFICARPAIS.Enabled = False
                    Me.btnELIMINARPAIS.Enabled = False
                    Me.intCODIGOPAIS.Text = ""
                    Me.txtNOMBREPAIS.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELARPAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARPAIS.Click

        Me.intCODIGOPAIS.Text = ""
        Me.txtNOMBREPAIS.Text = ""
        Me.txtBUSQUEDAPAIS.Text = ""
        Me.intCODIGOPAIS.Focus()
        Me.btnAGREGARPAIS.Enabled = False
        Me.btnMODIFICARPAIS.Enabled = False
        Me.btnELIMINARPAIS.Enabled = False
        Me.btnCANCELARPAIS.Enabled = True

    End Sub

    Private Sub txtBUSQUEDAPAIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAPAIS.TextChanged
        actualizardatagridpais = True
    End Sub



    Private Sub txtBUSQUEDAPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAPAIS.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAPAIS.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub


    Private Sub timerCONCEPTO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCONCEPTO.Tick

        If (actualizardatagridconcepto = True) Then

            AbrirConexion()
            cargarGrillaconcepto()
            setEstiloGrillaconcepto()
            CerrarConexion()
            actualizardatagridconcepto = False
            Me.dtaCONCEPTO.Update()
            Me.dtaCONCEPTO.Update()
        End If

    End Sub

    Private Sub intCODIGOCONCEPTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOCONCEPTO.TextChanged

    End Sub

    Private Sub intCODIGOCONCEPTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOCONCEPTO.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOCIUDAD.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBRECONCEPTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBRECONCEPTO.TextChanged

    End Sub


    Private Sub txtNOMBRECONCEPTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBRECONCEPTO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBRECONCEPTO.Text = ""
        ElseIf (InStr("./(),", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnNUEVOCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOCONCEPTO.Click

        Try
            AbrirConexion()
            strSQL = "SELECT concodigo FROM concepto order by concodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOCONCEPTO.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOCONCEPTO.Text = "1"
        End Try


        Me.txtNOMBRECONCEPTO.Text = ""
        Me.txtNOMBREBREVECONCEPTO.Text = ""
        Me.intMONTOCONCEPTO.Text = ""
        Me.cboBONODESCUENTOCONCEPTO.Text = ""
        Me.btnAGREGARCONCEPTO.Enabled = True
        Me.btnMODIFICARCONCEPTO.Enabled = False
        Me.btnELIMINARCONCEPTO.Enabled = False
        Me.btnCANCELARCONCEPTO.Enabled = True
        Me.intCODIGOCONCEPTO.Focus()


    End Sub

    Private Sub txtNOMBREBREVECONCEPTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREBREVECONCEPTO.TextChanged

    End Sub

    Private Sub txtNOMBREBREVECONCEPTO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREBREVECONCEPTO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREBREVECONCEPTO.Text = ""
        ElseIf (InStr("./,()", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnAGREGARCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARCONCEPTO.Click
        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOCONCEPTO.Text = "" Or Me.txtNOMBRECONCEPTO.Text = "" Or Me.txtNOMBREBREVECONCEPTO.Text = "" Or Me.cboBONODESCUENTOCONCEPTO.SelectedItem = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from concepto WHERE concodigo = " & Me.intCODIGOCONCEPTO.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN CONCEPTOS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from concepto WHERE connombre ILIKE '" & Me.txtNOMBRECONCEPTO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN CONCEPTOS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from concepto WHERE conbreve ILIKE '" & Me.txtNOMBREBREVECONCEPTO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    Dim auxBONODESCUENTO As String
                    If (Me.cboBONODESCUENTOCONCEPTO.SelectedItem = "BONO") Then
                        auxBONODESCUENTO = "B"
                    Else
                        auxBONODESCUENTO = "D"

                    End If
                    'Dim auxdivcodigo As Integer
                    'strSQL = "SELECT divcodigo from division where divnombre ilike '" & Me.cboDIVISION.GetItemText(Me.cboDIVISION.SelectedItem) & "'"
                    'AbrirConexion()
                    'mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    'myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                    'myReader.Read()
                    'auxdivcodigo = myReader.GetValue(0)
                    'CerrarConexion()

                    AbrirConexion()
                    strSQL = "INSERT INTO concepto (concodigo,connombre,conbreve,conmonto,contipo) VALUES (" & _
                    Me.intCODIGOCONCEPTO.Text & ", '" & Me.txtNOMBRECONCEPTO.Text & "','" & _
                    Me.txtNOMBREBREVECONCEPTO.Text & "'," & Me.intMONTOCONCEPTO.Text & _
                    ",'" & auxBONODESCUENTO & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOCONCEPTO.Text = ""
        Me.txtNOMBRECONCEPTO.Text = ""
        Me.txtNOMBREBREVECONCEPTO.Text = ""
        Me.intMONTOCONCEPTO.Text = ""
        Me.cboBONODESCUENTOCONCEPTO.Text = ""
        Me.intCODIGOCONCEPTO.Focus()
        actualizardatagridconcepto = True

    End Sub

    Private Sub intMONTOCONCEPTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intMONTOCONCEPTO.TextChanged

    End Sub

    Private Sub intMONTOCONCEPTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intMONTOCONCEPTO.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intMONTOCONCEPTO.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub dtaCONCEPTO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaCONCEPTO.Navigate

    End Sub

    Private Sub dtaCONCEPTO_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaCONCEPTO.CurrentCellChanged

        Dim filaGrillaActual As Integer
        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader

        Me.btnAGREGARCONCEPTO.Enabled = False
        Me.btnMODIFICARCONCEPTO.Enabled = True
        Me.btnELIMINARCONCEPTO.Enabled = True
        Me.btnCANCELARCONCEPTO.Enabled = True

        filaGrillaActual = Me.dtaCONCEPTO.CurrentCell.RowNumber

        Try

            Me.intCODIGOCONCEPTO.Text = Me.dtaCONCEPTO.Item(filaGrillaActual, 0)
            Me.txtNOMBRECONCEPTO.Text = Me.dtaCONCEPTO.Item(filaGrillaActual, 1)
            Me.txtNOMBREBREVECONCEPTO.Text = Me.dtaCONCEPTO.Item(filaGrillaActual, 2)
            Me.intMONTOCONCEPTO.Text = Me.dtaCONCEPTO.Item(filaGrillaActual, 3)
            If (Me.dtaCONCEPTO.Item(filaGrillaActual, 4) = "B") Then
                Me.cboBONODESCUENTOCONCEPTO.SelectedIndex = 0
            Else
                Me.cboBONODESCUENTOCONCEPTO.SelectedIndex = 1
            End If
            'strSQL = "SELECT divnombre from division where divcodigo=" & Me.dtaCONCEPTO.Item(filaGrillaActual, 5)
            'AbrirConexion()
            'mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            'myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            'myreader.Read()
            'Me.cboDIVISION.Text = ""
            'Me.cboDIVISION.Text = myreader.GetValue(0)

            Me.intCODIGOCONCEPTO.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOCONCEPTO.Text = ""
            Me.txtNOMBRECONCEPTO.Text = ""
            Me.txtNOMBREBREVECONCEPTO.Text = ""
            Me.intMONTOCONCEPTO.Text = ""
            Me.cboBONODESCUENTOCONCEPTO.SelectedItem = ""
            Me.intCODIGOCONCEPTO.Focus()
            Me.btnAGREGARCONCEPTO.Enabled = False
            Me.btnMODIFICARCONCEPTO.Enabled = False
            Me.btnELIMINARCONCEPTO.Enabled = False
            Me.btnCANCELARCONCEPTO.Enabled = True
        End Try


    End Sub

    Private Sub btnMODIFICARCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARCONCEPTO.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'DE CLIENTE ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGOCONCEPTO As Integer
            Dim auxNOMBRECONCEPTO As String
            Dim auxNOMBREBREVECONCEPTO As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT concodigo FROM concepto;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOCONCEPTO = myReader.GetValue(0)
                If (auxCODIGOCONCEPTO <> Integer.Parse(Me.intCODIGOCONCEPTO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT connombre FROM concepto WHERE concodigo=" & auxCODIGOCONCEPTO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBRECONCEPTO = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBRECONCEPTO, Me.txtNOMBRECONCEPTO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            strSQL = "SELECT concodigo FROM concepto;"
            myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While myReader.Read()
                auxCODIGOCONCEPTO = myReader.GetValue(0)
                If (auxCODIGOCONCEPTO <> Integer.Parse(Me.intCODIGOCONCEPTO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT conbreve FROM concepto WHERE concodigo=" & auxCODIGOCONCEPTO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBRECONCEPTO = myreader2.GetValue(0)
                    ca_cn2.Close()

                    If (String.Compare(auxNOMBRECONCEPTO, Me.txtNOMBREBREVECONCEPTO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then
                Dim auxiliarbonodescuento As String
                If (Me.cboBONODESCUENTOCONCEPTO.SelectedItem = "BONO") Then
                    auxiliarbonodescuento = "B"
                Else
                    auxiliarbonodescuento = "D"
                End If
                'strSQL = "select divcodigo from division where divnombre ilike '" & Me.cboDIVISION.Text & "'"
                'AbrirConexion()
                'myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                'myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                'myReader.Read()
                'Dim auxiliardivcodigo As Integer
                'auxiliardivcodigo = myReader.GetValue(0)
                strSQL = "update concepto set " & _
                                               "concodigo = " & Me.intCODIGOCONCEPTO.Text & ", " & _
                                               "connombre = '" & Me.txtNOMBRECONCEPTO.Text & "', " & _
                                               "conbreve= '" & Me.txtNOMBREBREVECONCEPTO.Text & "'," & _
                                               "conmonto= " & Me.intMONTOCONCEPTO.Text & "," & _
                                               "contipo= '" & auxiliarbonodescuento & "' " & _
                                               "where concodigo = " & Me.intCODIGOCONCEPTO.Text & " "


                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridconcepto = True

            Else
                MessageBox.Show("El registro que se quiere modificar ya se encuentra con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnELIMINARCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARCONCEPTO.Click

        Dim auxCODIGOCONCEPTO As Integer
        Dim auxNOMBRECONCEPTO As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT concodigo FROM concepto WHERE connombre= '" & Me.txtNOMBRECONCEPTO.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOCONCEPTO = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOCONCEPTO = Integer.Parse(Me.intCODIGOCONCEPTO.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from concepto where concodigo = " & auxCODIGOCONCEPTO & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridconcepto = True
                    Me.btnAGREGARCONCEPTO.Enabled = False
                    Me.btnMODIFICARCONCEPTO.Enabled = False
                    Me.btnELIMINARCONCEPTO.Enabled = False
                    Me.intCODIGOCONCEPTO.Text = ""
                    Me.txtNOMBRECONCEPTO.Text = ""
                    Me.txtNOMBREBREVECONCEPTO.Text = ""
                    Me.intMONTOCONCEPTO.Text = ""
                    Me.cboBONODESCUENTOCONCEPTO.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnCANCELARCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARCONCEPTO.Click

        Me.btnAGREGARCONCEPTO.Enabled = False
        Me.btnMODIFICARCONCEPTO.Enabled = False
        Me.btnELIMINARCONCEPTO.Enabled = False
        Me.intCODIGOCONCEPTO.Text = ""
        Me.txtNOMBRECONCEPTO.Text = ""
        Me.txtNOMBREBREVECONCEPTO.Text = ""
        Me.intMONTOCONCEPTO.Text = ""
        Me.cboBONODESCUENTOCONCEPTO.Text = ""
        Me.txtBUSQUEDACONCEPTO.Text = ""



    End Sub

    Private Sub txtBUSQUEDACONCEPTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDACONCEPTO.TextChanged

        actualizardatagridconcepto = True

    End Sub

    Private Sub timerEQUIPO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerEQUIPO.Tick

        If (actualizardatagridequipo = True) Then

            AbrirConexion()
            cargarGrillaequipo()
            setEstiloGrillaequipo()
            CerrarConexion()
            actualizardatagridequipo = False
            Me.dtaEQUIPO.Update()


        End If


    End Sub

    Private Sub intCODIGOEQUIPOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOEQUIPOS.TextChanged



    End Sub

    Private Sub intCODIGOEQUIPOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOEQUIPOS.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOEQUIPOS.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If


    End Sub

    Private Sub txtNOMBREQUIPOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREEQUIPOS.TextChanged

    End Sub

    Private Sub txtNOMBREQUIPOS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREEQUIPOS.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREEQUIPOS.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If


    End Sub

    Private Sub cboBONODESCUENTOCONCEPTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBONODESCUENTOCONCEPTO.SelectedIndexChanged

    End Sub

    Private Sub cboBONODESCUENTOCONCEPTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBONODESCUENTOCONCEPTO.KeyPress

        If e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.cboBONODESCUENTOCONCEPTO.Text = ""
        End If


    End Sub

    Private Sub btnNUEVOEQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOEQUIPO.Click

        Try
            AbrirConexion()
            strSQL = "SELECT equicodigo FROM equipo order by equicodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOEQUIPOS.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOEQUIPOS.Text = "1"
        End Try

        Me.txtNOMBREEQUIPOS.Text = ""
        Me.txtNOMBREBREVEEQUIPO.Text = ""
        Me.btnAGREGAREQUIPO.Enabled = True
        Me.btnMODIFICAREQUIPO.Enabled = False
        Me.btnELIMINAREQUIPO.Enabled = False
        Me.btnCANCELAREQUIPO.Enabled = True
        actualizarchkdivision()
        Me.intCODIGOEQUIPOS.Focus()


    End Sub

    Private Sub tabpEQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpEQUIPO.Click

    End Sub

    Private Sub txtNOMBREBREVEEQUIPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREBREVEEQUIPO.TextChanged

    End Sub

    Private Sub txtNOMBREBREVEEQUIPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREBREVEEQUIPO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREBREVEEQUIPO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If


    End Sub

    Private Sub btnAGREGAREQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGAREQUIPO.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOEQUIPOS.Text = "" Or Me.txtNOMBREEQUIPOS.Text = "" Or Me.txtNOMBREBREVEEQUIPO.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from equipo WHERE equicodigo = " & Me.intCODIGOEQUIPOS.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN NOMBRES DE EQUIPOS REPETIDOS

            AbrirConexion()
            strSQL = "SELECT * from equipo WHERE equinombre ILIKE '" & Me.txtNOMBREEQUIPOS.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN NOMBRES BREVES DE EQUIPOS REPETIDOS

            AbrirConexion()
            strSQL = "SELECT * from equipo WHERE equibreve ILIKE '" & Me.txtNOMBREBREVEEQUIPO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL



            If (esrepetido = False) Then
                Try
                    Dim auxdivcodigo As Integer
                    strSQL = "SELECT divcodigo from division where divnombre ilike '" & Me.chkdivision.GetItemText(Me.chkdivision.SelectedItem) & "'"
                    AbrirConexion()
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                    myReader.Read()
                    auxdivcodigo = myReader.GetValue(0)
                    CerrarConexion()
                    AbrirConexion()
                    strSQL = "INSERT INTO equipo (equicodigo,equinombre,equibreve) VALUES (" & _
                    Me.intCODIGOEQUIPOS.Text & ", '" & Me.txtNOMBREEQUIPOS.Text & "','" & Me.txtNOMBREBREVEEQUIPO.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    Try
                        Dim auxindice As Integer
                        auxindice = Me.chkdivision.Items.Count
                        Dim aux As Integer
                        For aux = 0 To Me.chkdivision.CheckedItems.Count - 1

                            strSQL = "SELECT divcodigo from division where divnombre ilike '" & Me.chkdivision.CheckedItems(aux).ToString & "'"
                            AbrirConexion()
                            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                            myReader.Read()
                            auxdivcodigo = myReader.GetValue(0)
                            CerrarConexion()

                            AbrirConexion()
                            strSQL = "INSERT INTO equidivision (equicodigo,divicodigo) VALUES (" & _
                            Me.intCODIGOEQUIPOS.Text & ", " & auxdivcodigo & ")"
                            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                            mycommand.ExecuteNonQuery()
                            mycommand.Dispose()
                            CerrarConexion()


                        Next aux
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
                    End Try

                    MessageBox.Show("El nombre fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try

                
            Else

            End If
        End If

        Me.intCODIGOEQUIPOS.Text = ""
        Me.txtNOMBREEQUIPOS.Text = ""
        Me.txtNOMBREBREVEEQUIPO.Text = ""
        Me.intCODIGOEQUIPOS.Focus()
        actualizarchkdivision()
        actualizardatagridequipo = True


    End Sub

    Private Sub btnMODIFICAREQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICAREQUIPO.Click


        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        ' ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try

            Dim auxCODIGOEQUIPO As Integer
            Dim auxNOMBREEQUIPO As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT equicodigo FROM equipo;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOEQUIPO = myReader.GetValue(0)
                If (auxCODIGOEQUIPO <> Integer.Parse(Me.intCODIGOEQUIPOS.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT equinombre FROM equipo WHERE equicodigo=" & auxCODIGOEQUIPO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREEQUIPO = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREEQUIPO, Me.txtNOMBREEQUIPOS.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            strSQL = "SELECT equicodigo FROM equipo;"
            myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOEQUIPO = myReader.GetValue(0)
                If (auxCODIGOEQUIPO <> Integer.Parse(Me.intCODIGOEQUIPOS.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT equibreve FROM equipo WHERE equicodigo=" & auxCODIGOEQUIPO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREEQUIPO = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREEQUIPO, Me.txtNOMBREBREVEEQUIPO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then

                Dim auxdivcodigo As Integer
                strSQL = "SELECT divcodigo from division where divnombre ilike '" & Me.chkdivision.GetItemText(Me.chkdivision.SelectedItem) & "'"
                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                myReader.Read()
                auxdivcodigo = myReader.GetValue(0)
                CerrarConexion()


                strSQL = "update equipo set " & _
                                               "equicodigo = " & Me.intCODIGOEQUIPOS.Text & ", " & _
                                               "equinombre = '" & Me.txtNOMBREEQUIPOS.Text & "', " & _
                                               "equibreve  = '" & Me.txtNOMBREBREVEEQUIPO.Text & "', " & _
                                               "equidivision= 0" & _
                                               "where equicodigo = " & Me.intCODIGOEQUIPOS.Text & " "

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()


                Try
                    strSQL = "DELETE from equidivision where equicodigo= " & Me.dtaEQUIPO.Item(Me.dtaEQUIPO.CurrentCell.RowNumber, 0) & ""
                    AbrirConexion()
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    CerrarConexion()

                    Dim auxindice As Integer
                    auxindice = Me.chkdivision.Items.Count
                    Dim aux As Integer
                    For aux = 0 To Me.chkdivision.CheckedItems.Count - 1

                        strSQL = "SELECT divcodigo from division where divnombre ilike '" & Me.chkdivision.CheckedItems(aux).ToString & "'"
                        AbrirConexion()
                        myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                        myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                        myReader.Read()
                        auxdivcodigo = myReader.GetValue(0)
                        CerrarConexion()

                        AbrirConexion()
                        strSQL = "INSERT INTO equidivision (equicodigo,divicodigo) VALUES (" & _
                        Me.intCODIGOEQUIPOS.Text & ", " & auxdivcodigo & ")"
                        myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                        myCommand.ExecuteNonQuery()
                        myCommand.Dispose()
                        CerrarConexion()


                    Next aux
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
                End Try
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridequipo = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub dtaEQUIPO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaEQUIPO.Navigate

    End Sub

    Private Sub btnMODIFICAREQUIPO_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMODIFICAREQUIPO.CursorChanged

    End Sub

    Private Sub dtaEQUIPO_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaEQUIPO.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGAREQUIPO.Enabled = False
        Me.btnMODIFICAREQUIPO.Enabled = True
        Me.btnELIMINAREQUIPO.Enabled = True
        Me.btnCANCELAREQUIPO.Enabled = True

        filaGrillaActual = Me.dtaEQUIPO.CurrentCell.RowNumber

        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader

        Dim ca_cn2 As Odbc.OdbcConnection
        Dim mycommand2 As Odbc.OdbcCommand
        Dim myreader2 As Odbc.OdbcDataReader

        Try

            Me.intCODIGOEQUIPOS.Text = Me.dtaEQUIPO.Item(filaGrillaActual, 0)
            Me.txtNOMBREEQUIPOS.Text = Me.dtaEQUIPO.Item(filaGrillaActual, 1)
            Me.txtNOMBREBREVEEQUIPO.Text = Me.dtaEQUIPO.Item(filaGrillaActual, 2)
            actualizarchkdivision()
            strSQL = "SELECT divicodigo from equidivision where equicodigo=" & Me.dtaEQUIPO.Item(filaGrillaActual, 0)
            Dim indice As Integer
            Dim divisionstring As String
            Dim index As Int32
            Try
                AbrirConexion()
                mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

                While myreader.Read()
                    strSQL = "SELECT divnombre from division where divcodigo=" & myreader.GetValue(0)
                    ca_cn2 = New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
                    myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

                    myreader2.Read()
                    divisionstring = myreader2.GetValue(0)


                    For Each item As Object In Me.chkdivision.Items

                        If item.ToString.ToLower = divisionstring.ToLower Then

                            ' Obtengo el índice en base cero
                            '
                            index = Me.chkdivision.Items.IndexOf(item)


                            Exit For

                        End If

                    Next
                    Me.chkdivision.SetItemChecked(index, True)
                    ca_cn2.Close()


                End While
                CerrarConexion()
            Catch ex As Exception
                'Me.chkdivisiona.Text = ""
            End Try
            Me.intCODIGOEQUIPOS.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOEQUIPOS.Text = ""
            Me.txtNOMBREEQUIPOS.Text = ""
            Me.intCODIGOEQUIPOS.Focus()
            Me.btnAGREGARCIUDAD.Enabled = False
            Me.btnMODIFICAREQUIPO.Enabled = False
            Me.btnELIMINAREQUIPO.Enabled = False
            Me.btnCANCELAREQUIPO.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINAREQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINAREQUIPO.Click

        Dim auxCODIGOEQUIPO As Integer
        Dim auxNOMBREEQUIPO As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT equicodigo FROM equipo WHERE equinombre= '" & Me.txtNOMBREEQUIPOS.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOEQUIPO = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOEQUIPO = Integer.Parse(Me.intCODIGOEQUIPOS.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from equipo where equicodigo = " & auxCODIGOEQUIPO & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    strSQL = "DELETE from equidivision where equicodigo= " & Me.intCODIGOEQUIPOS.Text & ""
                    AbrirConexion()
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)

                    Me.btnAGREGAREQUIPO.Enabled = False
                    Me.btnMODIFICAREQUIPO.Enabled = False
                    Me.btnELIMINAREQUIPO.Enabled = False
                    Me.intCODIGOEQUIPOS.Text = ""
                    Me.txtNOMBREEQUIPOS.Text = ""
                    Me.txtNOMBREBREVEEQUIPO.Text = ""
                    actualizarchkdivision()
                    actualizardatagridequipo = True
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELAREQUIPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELAREQUIPO.Click

        Me.intCODIGOEQUIPOS.Text = ""
        Me.txtNOMBREEQUIPOS.Text = ""
        Me.txtNOMBREBREVEEQUIPO.Text = ""
        Me.txtBUSQUEDAEQUIPO.Text = ""

        Me.intCODIGOEQUIPOS.Focus()
        Me.btnAGREGAREQUIPO.Enabled = False
        Me.btnMODIFICAREQUIPO.Enabled = False
        Me.btnELIMINAREQUIPO.Enabled = False
        Me.btnCANCELAREQUIPO.Enabled = True
        actualizarchkdivision()

    End Sub

    Private Sub txtBUSQUEDAEQUIPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAEQUIPO.TextChanged
        actualizardatagridequipo = True
    End Sub

    Private Sub txtBUSQUEDAEQUIPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAEQUIPO.KeyPress


        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAEQUIPO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnNUEVOESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOESTADIO.Click

        Try
            AbrirConexion()
            strSQL = "SELECT estcodigo FROM estadio order by estcodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOESTADIO.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOESTADIO.Text = "1"
        End Try


        'Me.intCODIGOESTADIO.Text = ""
        Me.txtNOMBREESTADIO.Text = ""
        Me.txtNOMBREBREVEESTADIO.Text = ""
        Me.txtBUSQUEDAESTADIO.Text = ""
        Me.btnAGREGARESTADIO.Enabled = True
        Me.btnMODIFICARESTADIO.Enabled = False
        Me.btnELIMINARESTADIO.Enabled = False
        Me.btnCANCELARESTADIO.Enabled = True
        Me.intCODIGOESTADIO.Focus()

    End Sub

    Private Sub intCODIGOESTADIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOESTADIO.TextChanged

    End Sub

    Private Sub intCODIGOESTADIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOESTADIO.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOESTADIO.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBREESTADIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREESTADIO.TextChanged

    End Sub

    Private Sub txtNOMBREESTADIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREESTADIO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREESTADIO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub txtNOMBREBREVEESTADIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREBREVEESTADIO.TextChanged

    End Sub

    Private Sub txtNOMBREBREVEESTADIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREBREVEESTADIO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREBREVEESTADIO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnAGREGARESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARESTADIO.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOESTADIO.Text = "" Or Me.txtNOMBREESTADIO.Text = "" Or Me.txtNOMBREBREVEESTADIO.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from estadio WHERE estcodigo = " & Me.intCODIGOESTADIO.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN ESTADIOS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from estadio WHERE estnombre ILIKE '" & Me.txtNOMBREESTADIO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL



            ''CONTROL PARA EVITAR QUE SE INGRESEN ESTADIOS HOMÓNIMOS

            AbrirConexion()
            strSQL = "SELECT * from estadio WHERE estbreve ILIKE '" & Me.txtNOMBREBREVEESTADIO.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO estadio(estcodigo, estnombre, estbreve) VALUES (" & _
                    Me.intCODIGOESTADIO.Text & ", '" & Me.txtNOMBREESTADIO.Text & "','" & Me.txtNOMBREBREVEESTADIO.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El nombre fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOESTADIO.Text = ""
        Me.txtNOMBREESTADIO.Text = ""
        Me.txtNOMBREBREVEESTADIO.Text = ""
        Me.txtBUSQUEDAESTADIO.Text = ""
        Me.intCODIGOCIUDAD.Focus()
        actualizardatagridestadio = True


    End Sub

    Private Sub timerESTADIO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerESTADIO.Tick

        If (actualizardatagridestadio = True) Then

            AbrirConexion()
            cargarGrillaestadio()
            setEstiloGrillaestadio()
            CerrarConexion()
            actualizardatagridestadio = False
            Me.dtaESTADIO.Update()

        End If

    End Sub

    Private Sub dtaESTADIO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaESTADIO.Navigate

    End Sub

    Private Sub dtaESTADIO_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaESTADIO.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARESTADIO.Enabled = False
        Me.btnMODIFICARESTADIO.Enabled = True
        Me.btnELIMINARESTADIO.Enabled = True
        Me.btnCANCELARESTADIO.Enabled = True

        filaGrillaActual = Me.dtaESTADIO.CurrentCell.RowNumber

        Try

            Me.intCODIGOESTADIO.Text = Me.dtaESTADIO.Item(filaGrillaActual, 0)
            Me.txtNOMBREESTADIO.Text = Me.dtaESTADIO.Item(filaGrillaActual, 1)
            Me.txtNOMBREBREVEESTADIO.Text = Me.dtaESTADIO.Item(filaGrillaActual, 2)
            Me.intCODIGOESTADIO.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOESTADIO.Text = ""
            Me.txtNOMBREESTADIO.Text = ""
            Me.txtNOMBREBREVEESTADIO.Text = ""
            Me.txtBUSQUEDAESTADIO.Text = ""
            Me.intCODIGOESTADIO.Focus()
            Me.btnAGREGARESTADIO.Enabled = False
            Me.btnMODIFICARESTADIO.Enabled = False
            Me.btnELIMINARESTADIO.Enabled = False
            Me.btnCANCELARESTADIO.Enabled = True
        End Try

    End Sub

    Private Sub btnMODIFICARESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARESTADIO.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        ' ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGOESTADIO As Integer
            Dim auxNOMBREESTADIO As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT estcodigo FROM estadio;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOESTADIO = myReader.GetValue(0)
                If (auxCODIGOESTADIO <> Integer.Parse(Me.intCODIGOESTADIO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT estnombre FROM estadio WHERE estcodigo=" & auxCODIGOESTADIO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREESTADIO = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREESTADIO, Me.txtNOMBREESTADIO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()


            AbrirConexion()
            strSQL = "SELECT estcodigo FROM estadio;"
            myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOESTADIO = myReader.GetValue(0)
                If (auxCODIGOESTADIO <> Integer.Parse(Me.intCODIGOESTADIO.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT estbreve FROM estadio WHERE estcodigo=" & auxCODIGOESTADIO
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREESTADIO = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREESTADIO, Me.txtNOMBREBREVEESTADIO.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()


            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update estadio set " & _
                                               "estcodigo = " & Me.intCODIGOESTADIO.Text & ", " & _
                                               "estnombre = '" & Me.txtNOMBREESTADIO.Text & "', " & _
                                               "estbreve  = '" & Me.txtNOMBREBREVEESTADIO.Text & "' " & _
                                               "where estcodigo = " & Me.intCODIGOESTADIO.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridestadio = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnELIMINARESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARESTADIO.Click

        Dim auxCODIGOESTADIO As Integer
        Dim auxNOMBREESTADIO As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT estcodigo FROM estadio WHERE estnombre= '" & Me.txtNOMBREESTADIO.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOESTADIO = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOESTADIO = Integer.Parse(Me.intCODIGOESTADIO.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from estadio where estcodigo = " & auxCODIGOESTADIO & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridestadio = True
                    Me.btnAGREGARESTADIO.Enabled = False
                    Me.btnMODIFICARESTADIO.Enabled = False
                    Me.btnELIMINARESTADIO.Enabled = False
                    Me.intCODIGOESTADIO.Text = ""
                    Me.txtNOMBREESTADIO.Text = ""
                    Me.txtNOMBREBREVEESTADIO.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub tabpESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpESTADIO.Click

    End Sub

    Private Sub btnCANCELARESTADIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARESTADIO.Click

        Me.intCODIGOESTADIO.Text = ""
        Me.txtNOMBREESTADIO.Text = ""
        Me.txtNOMBREBREVEESTADIO.Text = ""
        Me.txtBUSQUEDAESTADIO.Text = ""
        Me.intCODIGOESTADIO.Focus()
        Me.btnAGREGARESTADIO.Enabled = False
        Me.btnMODIFICARESTADIO.Enabled = False
        Me.btnELIMINARESTADIO.Enabled = False
        Me.btnCANCELARESTADIO.Enabled = True

    End Sub

    Private Sub txtBUSQUEDAESTADIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAESTADIO.TextChanged

        actualizardatagridestadio = True

    End Sub

    Private Sub txtBUSQUEDAESTADIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAESTADIO.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAESTADIO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub tabCODIGOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabCODIGOS.SelectedIndexChanged

    End Sub

    Private Sub intCODIGOPROFESION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOPROFESION.TextChanged

    End Sub

    Private Sub intCODIGOPROFESION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOPROFESION.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOPROFESION.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBREPROFESION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREPROFESION.TextChanged

    End Sub

    Private Sub txtNOMBREPROFESION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREPROFESION.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREPROFESION.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    'Private Sub txtNOMBREBREVEPROFESION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    '    'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
    '    If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
    '        e.Handled = True
    '        SendKeys.Send("{TAB}")
    '    ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
    '        e.Handled = False
    '    ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
    '        e.Handled = True
    '        Me.txtNOMBREBREVEPROFESION.Text = ""
    '    ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
    '        e.Handled = False

    '    Else
    '        e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
    '    End If

    'End Sub

    Private Sub btnNUEVOPROFESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOPROFESION.Click


        Try
            AbrirConexion()
            strSQL = "SELECT profcodigo FROM profesion order by profcodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOPROFESION.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOPROFESION.Text = "1"
        End Try


        Me.txtNOMBREPROFESION.Text = ""
        Me.btnAGREGARPROFESION.Enabled = True
        Me.btnMODIFICARPROFESION.Enabled = False
        Me.btnELIMINARPROFESION.Enabled = False
        Me.btnCANCELARPROFESION.Enabled = True
        Me.intCODIGOPROFESION.Focus()

    End Sub

    Private Sub btnAGREGARPROFESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARPROFESION.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOPROFESION.Text = "" Or Me.txtNOMBREPROFESION.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from profesion WHERE profcodigo = " & Me.intCODIGOPROFESION.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN profesiones HOMÓNIMAS

            AbrirConexion()
            strSQL = "SELECT * from profesion WHERE profnombre ILIKE '" & Me.txtNOMBREPROFESION.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO profesion (profcodigo,profnombre) VALUES (" & _
                    Me.intCODIGOPROFESION.Text & ", '" & Me.txtNOMBREPROFESION.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOPROFESION.Text = ""
        Me.txtNOMBREPROFESION.Text = ""
        'Me.txtNOMBREBREVEPROFESION.Text = ""
        Me.intCODIGOPROFESION.Focus()
        actualizardatagridprofesion = True



    End Sub

    Private Sub timerPROFESION_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPROFESION.Tick


        If (actualizardatagridprofesion = True) Then

            AbrirConexion()
            cargarGrillaProfesion()
            setEstiloGrillaProfesion()
            CerrarConexion()
            actualizardatagridprofesion = False
            Me.dtaPROFESION.Update()

        End If

    End Sub

    Private Sub btnMODIFICARPROFESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARPROFESION.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        ' ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGOPROFESION As Integer
            Dim auxNOMBREPROFESION As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT profcodigo FROM profesion;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGOPROFESION = myReader.GetValue(0)
                If (auxCODIGOPROFESION <> Integer.Parse(Me.intCODIGOPROFESION.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT profnombre FROM profesion WHERE profcodigo=" & auxCODIGOPROFESION
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREPROFESION = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREPROFESION, Me.txtNOMBREPROFESION.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()


            'AbrirConexion()
            'strsql = "SELECT profcodigo FROM profesion;"
            'myCommand = New Odbc.OdbcCommand(strsql, ca_cn)
            'myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            ''blnexiste = False

            'While myReader.Read()
            '    auxCODIGOPROFESION = myReader.GetValue(0)
            '    If (auxCODIGOPROFESION <> Integer.Parse(Me.intCODIGOPROFESION.Text)) Then

            '        Dim ca_cn2 As New Odbc.OdbcConnection(strcadena)
            '        ca_cn2.Open()
            '        strsql = "SELECT profbreve FROM profesion WHERE profcodigo=" & auxCODIGOPROFESION
            '        Dim mycommand2 As New Odbc.OdbcCommand(strsql, ca_cn2)
            '        Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
            '        myreader2.Read()
            '        auxNOMBREPROFESION = myreader2.GetValue(0)
            '        ca_cn2.Close()


            '        If (String.Compare(auxNOMBREPROFESION, Me.txtNOMBREBREVEPROFESION.Text, True) = 0) Then
            '            blnexiste = True
            '            Exit While
            '        End If

            '    End If

            'End While

            'CerrarConexion()


            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update profesion set " & _
                                               "profcodigo = " & Me.intCODIGOPROFESION.Text & ", " & _
                                               "profnombre = '" & Me.txtNOMBREPROFESION.Text & "' " & _
                                               "where profcodigo = " & Me.intCODIGOPROFESION.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagridprofesion = True

            Else
                MessageBox.Show("El nombre que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub dtaPROFESION_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaPROFESION.Navigate

    End Sub

    Private Sub dtaPROFESION_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaPROFESION.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARPROFESION.Enabled = False
        Me.btnMODIFICARPROFESION.Enabled = True
        Me.btnELIMINARPROFESION.Enabled = True
        Me.btnCANCELARPROFESION.Enabled = True

        filaGrillaActual = Me.dtaPROFESION.CurrentCell.RowNumber

        Try

            Me.intCODIGOPROFESION.Text = Me.dtaPROFESION.Item(filaGrillaActual, 0)
            Me.txtNOMBREPROFESION.Text = Me.dtaPROFESION.Item(filaGrillaActual, 1)
            'Me.txtNOMBREBREVEPROFESION.Text = Me.dtaPROFESION.Item(filaGrillaActual, 2)
            Me.intCODIGOPROFESION.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOPROFESION.Text = ""
            Me.txtNOMBREPROFESION.Text = ""
            Me.intCODIGOPROFESION.Focus()
            Me.btnAGREGARPROFESION.Enabled = False
            Me.btnMODIFICARPROFESION.Enabled = False
            Me.btnELIMINARPROFESION.Enabled = False
            Me.btnCANCELARPROFESION.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINARPROFESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARPROFESION.Click

        Dim auxCODIGOPROFESION As Integer
        Dim auxNOMBREPROFESION As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT profcodigo FROM profesion WHERE profnombre= '" & Me.txtNOMBREPROFESION.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOPROFESION = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOPROFESION = Integer.Parse(Me.intCODIGOPROFESION.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from profesion where profcodigo = " & auxCODIGOPROFESION & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridprofesion = True
                    Me.btnAGREGARPROFESION.Enabled = False
                    Me.btnMODIFICARPROFESION.Enabled = False
                    Me.btnELIMINARPROFESION.Enabled = False
                    Me.intCODIGOPROFESION.Text = ""
                    'Me.txtNOMBREBREVEPROFESION.Text = ""
                    Me.txtNOMBREPROFESION.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELARPROFESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARPROFESION.Click

        Me.intCODIGOPROFESION.Text = ""
        Me.txtNOMBREPROFESION.Text = ""
        'Me.txtNOMBREBREVEPROFESION.Text = ""
        Me.txtBUSQUEDAPROFESION.Text = ""
        Me.intCODIGOPROFESION.Focus()
        Me.btnAGREGARPROFESION.Enabled = False
        Me.btnMODIFICARPROFESION.Enabled = False
        Me.btnELIMINARPROFESION.Enabled = False
        Me.btnCANCELARPROFESION.Enabled = True

    End Sub

    Private Sub txtBUSQUEDAPROFESION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDAPROFESION.TextChanged
        actualizardatagridprofesion = True
    End Sub

    Private Sub txtBUSQUEDAPROFESION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDAPROFESION.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDAPROFESION.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub tabpmantcapital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpmantcapital.Click

    End Sub

    Private Sub lblMONTOFINALMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMONTOFINALMANTENIMIENTOCAPITAL.Click

    End Sub

    Private Sub intCODIGOMANTENIMIENTOCAPITAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intCODIGOMANTENIMIENTOCAPITAL.TextChanged

    End Sub

    Private Sub intCODIGOMANTENIMIENTOCAPITAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGOMANTENIMIENTOCAPITAL.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGOMANTENIMIENTOCAPITAL.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub intMONTOINICIALMANTENIMIENTOCAPITAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intMONTOINICIALMANTENIMIENTOCAPITAL.TextChanged

    End Sub

    Private Sub intMONTOINICIALMANTENIMIENTOCAPITAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intMONTOINICIALMANTENIMIENTOCAPITAL.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub intMONTOFINALMANTENIMIENTOCAPITAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intMONTOFINALMANTENIMIENTOCAPITAL.TextChanged

    End Sub

    Private Sub intMONTOFINALMANTENIMIENTOCAPITAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intMONTOFINALMANTENIMIENTOCAPITAL.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub intMONTOASIGNADOMANTENIMIENTOCAPITAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intMONTOASIGNADOMANTENIMIENTOCAPITAL.TextChanged

    End Sub

    Private Sub intMONTOASIGNADOMANTENIMIENTOCAPITAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intMONTOASIGNADOMANTENIMIENTOCAPITAL.KeyPress
        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub btnNUEVOMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVOMANTENIMIENTOCAPITAL.Click

        Try
            AbrirConexion()
            strSQL = "SELECT mancodigo FROM mantenimientocapital order by mancodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGOMANTENIMIENTOCAPITAL.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGOMANTENIMIENTOCAPITAL.Text = "1"
        End Try


        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""
        Me.btnAGREGARMANTENIMIENTOCAPITAL.Enabled = True
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Enabled = True
        Me.intCODIGOCIUDAD.Focus()


    End Sub

    Private Sub dtaMANTENIMIENTOCAPITAL_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaMANTENIMIENTOCAPITAL.Navigate

    End Sub

    Private Sub btnAGREGARMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARMANTENIMIENTOCAPITAL.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGOMANTENIMIENTOCAPITAL.Text = "" Or Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = "" Or Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = "" Or Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT mancodigo from mantenimientocapital WHERE mancodigo = " & Me.intCODIGOMANTENIMIENTOCAPITAL.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN montos iniciales mayores a los montos finales

            If (Integer.Parse(Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text) > Integer.Parse(Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text)) Then
                MessageBox.Show("debe ingresar un monto inicial menor o igual al monto final", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
            End If
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO mantenimientocapital (mancodigo,manmontoinicial,manmontofinal,manmontoasignado) VALUES (" & _
                    Me.intCODIGOMANTENIMIENTOCAPITAL.Text & ", " & Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text & "," & _
                     Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text & "," & Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text & ")"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGOMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""
        Me.intCODIGOMANTENIMIENTOCAPITAL.Focus()
        actualizardatagridmantenimientocapital = True



    End Sub

    Private Sub timerMANTENIMIENTOCAPITAL_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerMANTENIMIENTOCAPITAL.Tick

        If (actualizardatagridmantenimientocapital = True) Then

            AbrirConexion()
            cargarGrillamantenimientocapital()
            setEstiloGrillamantenimientocapital()
            CerrarConexion()
            actualizardatagridmantenimientocapital = False
            Me.dtaMANTENIMIENTOCAPITAL.Update()

        End If


    End Sub

    Private Sub timerPAIS_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerPAIS.Disposed

    End Sub

    Private Sub btnMODIFICARMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARMANTENIMIENTOCAPITAL.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        ' ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGOMANTENIMIENTOCAPITAL As Integer
            'Dim auxMONTOI As String
            Dim blnexiste As Boolean

            'AbrirConexion()
            'strsql = "SELECT mancodigo FROM mantenimientocapital;"
            Dim myCommand As Odbc.OdbcCommand
            Dim myReader As Odbc.OdbcDataReader
            blnexiste = False

            'While myReader.Read()
            '    auxCODIGOMANTENIMIENTOCAPITAL = myReader.GetValue(0)
            '    If (auxCODIGOMANTENIMIENTOCAPITAL <> Integer.Parse(Me.intCODIGOMANTENIMIENTOCAPITAL.Text)) Then

            '        Dim ca_cn2 As New Odbc.OdbcConnection(strcadena)
            '        ca_cn2.Open()
            '        strsql = "SELECT nombreciudad FROM ciudad WHERE codciudad=" & auxCODIGOCIUDAD
            '        Dim mycommand2 As New Odbc.OdbcCommand(strsql, ca_cn2)
            '        Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
            '        myreader2.Read()
            '        auxNOMBRECIUDAD = myreader2.GetValue(0)
            '        ca_cn2.Close()


            '        If (String.Compare(auxNOMBRECIUDAD, Me.txtDESCRIPCIONCIUDAD.Text, True) = 0) Then
            '            blnexiste = True
            '            Exit While
            '        End If

            '    End If

            'End While

            'CerrarConexion()
            If (Integer.Parse(Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text) <= Integer.Parse(Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text)) Then
                AbrirConexion()
                If (blnexiste = False) Then


                    strSQL = "update mantenimientocapital set " & _
                                                   "mancodigo = " & Me.intCODIGOMANTENIMIENTOCAPITAL.Text & ", " & _
                                                   "manmontoinicial = " & Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text & ", " & _
                                                   "manmontofinal=" & Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text & ", " & _
                                                   "manmontoasignado=" & Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text & _
                                                   " where mancodigo = " & Me.intCODIGOMANTENIMIENTOCAPITAL.Text & ""

                    AbrirConexion()
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    MessageBox.Show("Se modificó exitosamente el registro de ciudad", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridCIUDAD = True

                Else
                    MessageBox.Show("El nombre de ciudad que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
                End If

                CerrarConexion()
            Else
                MessageBox.Show("El monto inicial ingresado debe ser menor al monto final. Debe corregir esto para guardar el registro", "Error en la carga de datos", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try
        actualizardatagridmantenimientocapital = True



    End Sub

    Private Sub dtaMANTENIMIENTOCAPITAL_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaMANTENIMIENTOCAPITAL.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARMANTENIMIENTOCAPITAL.Enabled = False
        Me.btnMODIFICARMANTENIMIENTOCAPITAL.Enabled = True
        Me.btnELIMINARMANTENIMIENTOCAPITAL.Enabled = True
        Me.btnCANCELARMANTENIMIENTOCAPITAL.Enabled = True

        filaGrillaActual = Me.dtaMANTENIMIENTOCAPITAL.CurrentCell.RowNumber

        Try

            Me.intCODIGOMANTENIMIENTOCAPITAL.Text = Me.dtaMANTENIMIENTOCAPITAL.Item(filaGrillaActual, 0)
            Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = Me.dtaMANTENIMIENTOCAPITAL.Item(filaGrillaActual, 1)
            Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = Me.dtaMANTENIMIENTOCAPITAL.Item(filaGrillaActual, 2)
            Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = Me.dtaMANTENIMIENTOCAPITAL.Item(filaGrillaActual, 3)


            Me.intCODIGOCIUDAD.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGOMANTENIMIENTOCAPITAL.Text = ""
            Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
            Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
            Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""
            Me.intCODIGOMANTENIMIENTOCAPITAL.Focus()
            Me.btnAGREGARMANTENIMIENTOCAPITAL.Enabled = False
            Me.btnMODIFICARMANTENIMIENTOCAPITAL.Enabled = False
            Me.btnELIMINARMANTENIMIENTOCAPITAL.Enabled = False
            Me.btnCANCELARMANTENIMIENTOCAPITAL.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINARMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARMANTENIMIENTOCAPITAL.Click

        Dim auxCODIGOMANTENIMIENTOCAPITAL As Integer
        'Dim auxNOMBRECIUDAD As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT mancodigo FROM mantenimientocapital WHERE mancodigo= '" & Me.intCODIGOMANTENIMIENTOCAPITAL.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGOMANTENIMIENTOCAPITAL = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGOMANTENIMIENTOCAPITAL = Integer.Parse(Me.intCODIGOMANTENIMIENTOCAPITAL.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from mantenimientocapital where mancodigo = " & auxCODIGOMANTENIMIENTOCAPITAL & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagridmantenimientocapital = True
                    Me.btnAGREGARMANTENIMIENTOCAPITAL.Enabled = False
                    Me.btnMODIFICARMANTENIMIENTOCAPITAL.Enabled = False
                    Me.btnELIMINARMANTENIMIENTOCAPITAL.Enabled = False
                    Me.intCODIGOMANTENIMIENTOCAPITAL.Text = ""
                    Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
                    Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
                    Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""


                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELARMANTENIMIENTOCAPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARMANTENIMIENTOCAPITAL.Click

        Me.intCODIGOMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOINICIALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOFINALMANTENIMIENTOCAPITAL.Text = ""
        Me.intMONTOASIGNADOMANTENIMIENTOCAPITAL.Text = ""
        Me.intCODIGOMANTENIMIENTOCAPITAL.Focus()

    End Sub

    Private Sub btnVOLVER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVOLVER.Click
        Me.Close()
    End Sub



    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles intCODIGODIVISIONES.KeyPress

        'se espera que en este campo se ingresen solamente números, por lo tanto debemos controlar que no se ingrese otro tipo de caracteres
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO INGRESAR NÚMEROS, ENTER O BACKSPACE
            e.Handled = False
            If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.intCODIGODIVISIONES.Text = ""
        Else
            e.Handled = True 'NO ES VÁLIDO INGRESAR OTROS CARACTERES
        End If

    End Sub

    Private Sub txtNOMBREDIVISIONES_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOMBREDIVISIONES.TextChanged

    End Sub

    Private Sub txtNOMBREDIVISIONES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOMBREDIVISIONES.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtNOMBREDIVISIONES.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub btnNUEVODIVISIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNUEVODIVISIONES.Click

        Try
            AbrirConexion()
            strSQL = "SELECT divcodigo FROM division order by divcodigo desc limit 1"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim auxcodigo As String
            myReader.Read()
            auxcodigo = myReader.GetValue(0)
            auxcodigo = auxcodigo + 1
            Me.intCODIGODIVISIONES.Text = auxcodigo

        Catch ex As Exception
            Me.intCODIGODIVISIONES.Text = "1"
        End Try


        Me.txtNOMBREDIVISIONES.Text = ""
        Me.btnAGREGARDIVISIONES.Enabled = True
        Me.btnMODIFICARDIVISIONES.Enabled = False
        Me.btnELIMINARDIVISIONES.Enabled = False
        Me.btnCANCELARDIVISIONES.Enabled = True
        Me.intCODIGODIVISIONES.Focus()

    End Sub

    Private Sub btnAGREGARDIVISIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGARDIVISIONES.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myReader As Odbc.OdbcDataReader
        Dim auxcodigo As Integer
        Dim auxnombre As String
        Dim auxnombre1 As String
        Dim esrepetido As Boolean = False

        If (Me.intCODIGODIVISIONES.Text = "" Or Me.txtNOMBREDIVISIONES.Text = "") Then
            MessageBox.Show("Debe ingresar correctamente los campos para guardar el registro", "Sistema Delta", MessageBoxButtons.OK)

        Else

            'SE CONTROLA QUE EL CÓDIGO NO SEA REPETIDO
            AbrirConexion()
            strSQL = "SELECT * from division WHERE divcodigo = " & Me.intCODIGODIVISIONES.Text & ";"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El código ingresado es repetido, por favor ingrese un código diferente...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True
                Exit While

            End While
            CerrarConexion()
            ''FIN DEL CONTROL

            ''CONTROL PARA EVITAR QUE SE INGRESEN CIUDADES HOMÓNIMAS

            AbrirConexion()
            strSQL = "SELECT * from division WHERE divnombre ILIKE '" & Me.txtNOMBREDIVISIONES.Text & "';"
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            While myReader.Read()

                MessageBox.Show("El nombre ingresado es repetido, por favor ingrese un nombre único...", "Sistema Delta", MessageBoxButtons.OK)
                esrepetido = True

            End While
            CerrarConexion()
            '' FIN DEL CONTROL

            If (esrepetido = False) Then
                Try
                    AbrirConexion()
                    strSQL = "INSERT INTO division (divcodigo,divnombre) VALUES (" & _
                    Me.intCODIGODIVISIONES.Text & ", '" & Me.txtNOMBREDIVISIONES.Text & "')"
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    mycommand.Dispose()
                    CerrarConexion()

                    MessageBox.Show("El registro fué almacenado con éxito", "Sistema Delta", MessageBoxButtons.OK)

                Catch err As Exception
                    MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)

                End Try
            Else

            End If
        End If

        Me.intCODIGODIVISIONES.Text = ""
        Me.txtNOMBREDIVISIONES.Text = ""
        Me.intCODIGODIVISIONES.Focus()
        actualizardatagriddivisiones = True

    End Sub

    Private Sub btnMODIFICARDIVISIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMODIFICARDIVISIONES.Click

        'CÓDIGO PARA VERIFICAR SI EL CÓDIGO INGRESADO ES REPETIDO,
        'SE REALIZA UNA CONSULTA A LA BASE DE DATOS PARA OBTENER TODOS LOS CÓDIGOS
        'ALMACENADOS ANTERIORMENTE, Y SE COMPARAN UNO POR UNO CON EL 
        'CODIGO INGRESADO PARA ENCONTRAR POSIBLES REPETICIONES DEL CÓDIGO

        Try


            Dim auxCODIGODIVISIONES As Integer
            Dim auxNOMBREDIVISIONES As String
            Dim blnexiste As Boolean

            AbrirConexion()
            strSQL = "SELECT divcodigo FROM division;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            blnexiste = False

            While myReader.Read()
                auxCODIGODIVISIONES = myReader.GetValue(0)
                If (auxCODIGODIVISIONES <> Integer.Parse(Me.intCODIGODIVISIONES.Text)) Then

                    Dim ca_cn2 As New Odbc.OdbcConnection(strCADENA)
                    ca_cn2.Open()
                    strSQL = "SELECT divnombre FROM division WHERE divcodigo=" & auxCODIGODIVISIONES
                    Dim mycommand2 As New Odbc.OdbcCommand(strSQL, ca_cn2)
                    Dim myreader2 As Odbc.OdbcDataReader = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
                    myreader2.Read()
                    auxNOMBREDIVISIONES = myreader2.GetValue(0)
                    ca_cn2.Close()


                    If (String.Compare(auxNOMBREDIVISIONES, Me.txtNOMBREDIVISIONES.Text, True) = 0) Then
                        blnexiste = True
                        Exit While
                    End If

                End If

            End While

            CerrarConexion()

            AbrirConexion()
            If (blnexiste = False) Then


                strSQL = "update division set " & _
                                               "divcodigo = " & Me.intCODIGODIVISIONES.Text & ", " & _
                                               "divnombre = '" & Me.txtNOMBREDIVISIONES.Text & "' " & _
                                               "where divcodigo= " & Me.intCODIGODIVISIONES.Text & ""

                AbrirConexion()
                myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                myCommand.ExecuteNonQuery()
                myCommand.Dispose()
                MessageBox.Show("Se modificó exitosamente el registro", "Sistema Delta", MessageBoxButtons.OK)
                actualizardatagriddivisiones = True

            Else
                MessageBox.Show("El registro que se quiere modificar ya se encuentra registrado con un código diferente", "Sistema Delta", MessageBoxButtons.OK)
            End If

            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Hubo un error al intentar modificar el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub Timer1_Tick_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerDIVISIONES.Tick


        If (actualizardatagriddivisiones = True) Then

            AbrirConexion()
            cargarGrilladivisiones()
            setEstiloGrilladivisiones()
            CerrarConexion()
            actualizardatagriddivisiones = False
            actualizarchkdivision()
            Me.dtaDIVISIONES.Update()

        End If

    End Sub

    Private Sub actualizarchkdivision()

        Dim myreader As Odbc.OdbcDataReader

        AbrirConexion()
        Me.chkdivision.Items.Clear()
        strSQL = "select divnombre from division"
        Dim mycommand As New Odbc.OdbcCommand(strSQL, ca_cn)


        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        While myreader.Read()
            Me.chkdivision.Items.Add(myreader.GetValue(0))
        End While
        CerrarConexion()

    End Sub

    Private Sub dtaDIVISIONES_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaDIVISIONES.Navigate

    End Sub

    Private Sub dtaDIVISIONES_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaDIVISIONES.CurrentCellChanged

        Dim filaGrillaActual As Integer

        Me.btnAGREGARDIVISIONES.Enabled = False
        Me.btnMODIFICARDIVISIONES.Enabled = True
        Me.btnELIMINARDIVISIONES.Enabled = True
        Me.btnCANCELARDIVISIONES.Enabled = True

        filaGrillaActual = Me.dtaDIVISIONES.CurrentCell.RowNumber

        Try

            Me.intCODIGODIVISIONES.Text = Me.dtaDIVISIONES.Item(filaGrillaActual, 0)
            Me.txtNOMBREDIVISIONES.Text = Me.dtaDIVISIONES.Item(filaGrillaActual, 1)
            Me.intCODIGOCIUDAD.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede modificar o eliminar un registro vacío", "Sistema Delta", MessageBoxButtons.OK)
            Me.intCODIGODIVISIONES.Text = ""
            Me.txtNOMBREDIVISIONES.Text = ""
            Me.intCODIGODIVISIONES.Focus()
            Me.btnAGREGARDIVISIONES.Enabled = False
            Me.btnMODIFICARDIVISIONES.Enabled = False
            Me.btnELIMINARDIVISIONES.Enabled = False
            Me.btnCANCELARDIVISIONES.Enabled = True
        End Try

    End Sub

    Private Sub btnELIMINARDIVISIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELIMINARDIVISIONES.Click

        Dim auxCODIGODIVISIONES As Integer
        Dim auxNOMBREDIVISIONES As String
        Dim blnexiste As Boolean
        Try
            AbrirConexion()
            strSQL = "SELECT divcodigo FROM division WHERE divnombre= '" & Me.txtNOMBREDIVISIONES.Text & "';"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            myReader.Read()
            auxCODIGODIVISIONES = myReader.GetValue(0)
            CerrarConexion()

            If (auxCODIGODIVISIONES = Integer.Parse(Me.intCODIGODIVISIONES.Text)) Then

                If (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Sistema Delta", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    AbrirConexion()
                    strSQL = "delete from division where divcodigo = " & auxCODIGODIVISIONES & ""
                    myCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    myCommand.ExecuteNonQuery()
                    myCommand.Dispose()
                    CerrarConexion()
                    MessageBox.Show("El registro se eliminó satisfactoriamente!", "Sistema Delta", MessageBoxButtons.OK)
                    actualizardatagriddivisiones = True
                    Me.btnAGREGARDIVISIONES.Enabled = False
                    Me.btnMODIFICARDIVISIONES.Enabled = False
                    Me.btnELIMINARDIVISIONES.Enabled = False
                    Me.intCODIGODIVISIONES.Text = ""
                    Me.txtNOMBREDIVISIONES.Text = ""

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar satisfactoriamente el registro", "Sistema Delta", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCANCELARDIVISIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELARDIVISIONES.Click

        Me.intCODIGODIVISIONES.Text = ""
        Me.txtNOMBREDIVISIONES.Text = ""
        Me.txtBUSQUEDADIVISIONES.Text = ""
        Me.intCODIGODIVISIONES.Focus()
        Me.btnAGREGARDIVISIONES.Enabled = False
        Me.btnMODIFICARDIVISIONES.Enabled = False
        Me.btnELIMINARDIVISIONES.Enabled = False
        Me.btnCANCELARDIVISIONES.Enabled = True

    End Sub

    Private Sub txtBUSQUEDADIVISIONES_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDADIVISIONES.TextChanged
        actualizardatagriddivisiones = True
    End Sub

    Private Sub txtBUSQUEDADIVISIONES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUSQUEDADIVISIONES.KeyPress

        'SE ENVIA EL FOCUS AL CAMPO SIGUIENTE LUEGO DE PRESIONAR "ENTER"
        If e.KeyChar = ChrW(Keys.Enter) Then 'ES VÁLIDO PULSAR ENTER
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then 'ES VÁLIDO INGRESAR LETRAS O NÚMEROS
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Then 'ES VÁLIDO PULSAR LA BARRA ESPACIADORA O LA TECLA BACKSPACE
            e.Handled = False
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then 'ES VÁLIDO INGRESAR ESCAPE
            e.Handled = True
            Me.txtBUSQUEDADIVISIONES.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If

    End Sub

    Private Sub tabpCONCEPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpCONCEPTO.Click

    End Sub

    Private Sub chkCATEGORIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdivision.SelectedIndexChanged

    End Sub
End Class

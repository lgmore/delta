Public Class frmMENU
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents mnuHABILITAR As System.Windows.Forms.ContextMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents tbbHABILITACION As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSALIR As System.Windows.Forms.ContextMenu
    Friend WithEvents tbbSALIR As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSI As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSOCIO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUSUARIO As System.Windows.Forms.MenuItem
    Friend WithEvents tbbSEPARADOR As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuBONO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCODIGOS As System.Windows.Forms.MenuItem
    Friend WithEvents tbbSEPARADOR1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuINFORMES As System.Windows.Forms.ContextMenu
    Friend WithEvents tbbINFORMES As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbSEPARADOR2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbCARGAR As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuCARGAR As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRECIBO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPLANILLAAPF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPLANILLACONTADURIA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAUTOFACTURA As System.Windows.Forms.MenuItem
    Friend WithEvents tbbSEPARADOR3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuEMISIONRECIBO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRECIBODINERO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFACURAREP As System.Windows.Forms.MenuItem
    Friend WithEvents tbbREPORTE As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuREPORTE As System.Windows.Forms.ContextMenu
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuHABILITACION As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSOCIOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUSUARIOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCÓDIGOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCARGAS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBONOS_DESC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAUTOFACTURAS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRECIBOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuINFORME As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRECIBOLIQUI As System.Windows.Forms.MenuItem
    Friend WithEvents mnuINFORMEAPF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuINDORMESCONTADURIA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuREPORTES As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRECIBOREP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAUTOFACTURAREP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSALIRSIST As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSOCIOPROMO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSOCIOPROMOCION As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBANCO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFACTURA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDISKETTE As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBANCOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDISKETTES As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFACTURAS As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMENU))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.mnuHABILITAR = New System.Windows.Forms.ContextMenu
        Me.mnuSOCIO = New System.Windows.Forms.MenuItem
        Me.mnuUSUARIO = New System.Windows.Forms.MenuItem
        Me.mnuCODIGOS = New System.Windows.Forms.MenuItem
        Me.mnuSALIR = New System.Windows.Forms.ContextMenu
        Me.mnuSI = New System.Windows.Forms.MenuItem
        Me.mnuNO = New System.Windows.Forms.MenuItem
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tbbHABILITACION = New System.Windows.Forms.ToolBarButton
        Me.tbbSEPARADOR = New System.Windows.Forms.ToolBarButton
        Me.tbbCARGAR = New System.Windows.Forms.ToolBarButton
        Me.mnuCARGAR = New System.Windows.Forms.ContextMenu
        Me.mnuBONO = New System.Windows.Forms.MenuItem
        Me.mnuAUTOFACTURA = New System.Windows.Forms.MenuItem
        Me.mnuEMISIONRECIBO = New System.Windows.Forms.MenuItem
        Me.tbbSEPARADOR1 = New System.Windows.Forms.ToolBarButton
        Me.tbbINFORMES = New System.Windows.Forms.ToolBarButton
        Me.mnuINFORMES = New System.Windows.Forms.ContextMenu
        Me.mnuRECIBO = New System.Windows.Forms.MenuItem
        Me.mnuPLANILLAAPF = New System.Windows.Forms.MenuItem
        Me.mnuPLANILLACONTADURIA = New System.Windows.Forms.MenuItem
        Me.tbbSEPARADOR2 = New System.Windows.Forms.ToolBarButton
        Me.tbbREPORTE = New System.Windows.Forms.ToolBarButton
        Me.mnuREPORTE = New System.Windows.Forms.ContextMenu
        Me.mnuRECIBODINERO = New System.Windows.Forms.MenuItem
        Me.mnuFACURAREP = New System.Windows.Forms.MenuItem
        Me.mnuSOCIOPROMO = New System.Windows.Forms.MenuItem
        Me.tbbSEPARADOR3 = New System.Windows.Forms.ToolBarButton
        Me.tbbSALIR = New System.Windows.Forms.ToolBarButton
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuHABILITACION = New System.Windows.Forms.MenuItem
        Me.mnuSOCIOS = New System.Windows.Forms.MenuItem
        Me.mnuUSUARIOS = New System.Windows.Forms.MenuItem
        Me.mnuCÓDIGOS = New System.Windows.Forms.MenuItem
        Me.mnuCARGAS = New System.Windows.Forms.MenuItem
        Me.mnuBONOS_DESC = New System.Windows.Forms.MenuItem
        Me.mnuAUTOFACTURAS = New System.Windows.Forms.MenuItem
        Me.mnuRECIBOS = New System.Windows.Forms.MenuItem
        Me.mnuFACTURA = New System.Windows.Forms.MenuItem
        Me.mnuINFORME = New System.Windows.Forms.MenuItem
        Me.mnuRECIBOLIQUI = New System.Windows.Forms.MenuItem
        Me.mnuINFORMEAPF = New System.Windows.Forms.MenuItem
        Me.mnuINDORMESCONTADURIA = New System.Windows.Forms.MenuItem
        Me.mnuREPORTES = New System.Windows.Forms.MenuItem
        Me.mnuRECIBOREP = New System.Windows.Forms.MenuItem
        Me.mnuAUTOFACTURAREP = New System.Windows.Forms.MenuItem
        Me.mnuSOCIOPROMOCION = New System.Windows.Forms.MenuItem
        Me.mnuBANCO = New System.Windows.Forms.MenuItem
        Me.mnuDISKETTE = New System.Windows.Forms.MenuItem
        Me.mnuSALIRSIST = New System.Windows.Forms.MenuItem
        Me.mnuBANCOS = New System.Windows.Forms.MenuItem
        Me.mnuDISKETTES = New System.Windows.Forms.MenuItem
        Me.mnuFACTURAS = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(25, 25)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 709)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(936, 16)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'mnuHABILITAR
        '
        Me.mnuHABILITAR.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSOCIO, Me.mnuUSUARIO, Me.mnuCODIGOS})
        '
        'mnuSOCIO
        '
        Me.mnuSOCIO.Index = 0
        Me.mnuSOCIO.Text = "SOCIO"
        '
        'mnuUSUARIO
        '
        Me.mnuUSUARIO.Index = 1
        Me.mnuUSUARIO.Text = "USUARIO"
        '
        'mnuCODIGOS
        '
        Me.mnuCODIGOS.Index = 2
        Me.mnuCODIGOS.Text = "CODIGOS"
        '
        'mnuSALIR
        '
        Me.mnuSALIR.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSI, Me.mnuNO})
        '
        'mnuSI
        '
        Me.mnuSI.Index = 0
        Me.mnuSI.Text = "SI"
        '
        'mnuNO
        '
        Me.mnuNO.Index = 1
        Me.mnuNO.Text = "NO"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbHABILITACION, Me.tbbSEPARADOR, Me.tbbCARGAR, Me.tbbSEPARADOR1, Me.tbbINFORMES, Me.tbbSEPARADOR2, Me.tbbREPORTE, Me.tbbSEPARADOR3, Me.tbbSALIR})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(936, 51)
        Me.ToolBar1.TabIndex = 1
        '
        'tbbHABILITACION
        '
        Me.tbbHABILITACION.DropDownMenu = Me.mnuHABILITAR
        Me.tbbHABILITACION.ImageIndex = 16
        Me.tbbHABILITACION.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbHABILITACION.Text = "HABILITACION"
        '
        'tbbSEPARADOR
        '
        Me.tbbSEPARADOR.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbCARGAR
        '
        Me.tbbCARGAR.DropDownMenu = Me.mnuCARGAR
        Me.tbbCARGAR.ImageIndex = 15
        Me.tbbCARGAR.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbCARGAR.Text = "CARGAR"
        '
        'mnuCARGAR
        '
        Me.mnuCARGAR.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBONO, Me.mnuAUTOFACTURA, Me.mnuEMISIONRECIBO, Me.mnuFACTURAS})
        '
        'mnuBONO
        '
        Me.mnuBONO.Index = 0
        Me.mnuBONO.Text = "BONO/DESCUENTO"
        '
        'mnuAUTOFACTURA
        '
        Me.mnuAUTOFACTURA.Index = 1
        Me.mnuAUTOFACTURA.Text = "AUTOFACTURA"
        '
        'mnuEMISIONRECIBO
        '
        Me.mnuEMISIONRECIBO.Index = 2
        Me.mnuEMISIONRECIBO.Text = "EMISION DE RECIBO"
        '
        'tbbSEPARADOR1
        '
        Me.tbbSEPARADOR1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbINFORMES
        '
        Me.tbbINFORMES.DropDownMenu = Me.mnuINFORMES
        Me.tbbINFORMES.ImageIndex = 1
        Me.tbbINFORMES.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbINFORMES.Text = "INFORMES"
        '
        'mnuINFORMES
        '
        Me.mnuINFORMES.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRECIBO, Me.mnuPLANILLAAPF, Me.mnuPLANILLACONTADURIA})
        '
        'mnuRECIBO
        '
        Me.mnuRECIBO.Index = 0
        Me.mnuRECIBO.Text = "RECIBO DE LIQUIDACION"
        '
        'mnuPLANILLAAPF
        '
        Me.mnuPLANILLAAPF.Index = 1
        Me.mnuPLANILLAAPF.Text = "PLANILLA DE PAGO APF"
        '
        'mnuPLANILLACONTADURIA
        '
        Me.mnuPLANILLACONTADURIA.Index = 2
        Me.mnuPLANILLACONTADURIA.Text = "PLANILLA PARA CONTADURIA"
        '
        'tbbSEPARADOR2
        '
        Me.tbbSEPARADOR2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbREPORTE
        '
        Me.tbbREPORTE.DropDownMenu = Me.mnuREPORTE
        Me.tbbREPORTE.ImageIndex = 14
        Me.tbbREPORTE.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbREPORTE.Text = "REPORTE"
        '
        'mnuREPORTE
        '
        Me.mnuREPORTE.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRECIBODINERO, Me.mnuFACURAREP, Me.mnuSOCIOPROMO, Me.mnuBANCOS, Me.mnuDISKETTES})
        '
        'mnuRECIBODINERO
        '
        Me.mnuRECIBODINERO.Index = 0
        Me.mnuRECIBODINERO.Text = "RECIBO"
        '
        'mnuFACURAREP
        '
        Me.mnuFACURAREP.Index = 1
        Me.mnuFACURAREP.Text = "AUTOFACTURA"
        '
        'mnuSOCIOPROMO
        '
        Me.mnuSOCIOPROMO.Index = 2
        Me.mnuSOCIOPROMO.Text = "SOCIO POR PROMOCIÓN"
        '
        'tbbSEPARADOR3
        '
        Me.tbbSEPARADOR3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbSALIR
        '
        Me.tbbSALIR.DropDownMenu = Me.mnuSALIR
        Me.tbbSALIR.ImageIndex = 0
        Me.tbbSALIR.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbSALIR.Text = "SALIR"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHABILITACION, Me.mnuCARGAS, Me.mnuINFORME, Me.mnuREPORTES, Me.mnuSALIRSIST})
        '
        'mnuHABILITACION
        '
        Me.mnuHABILITACION.Index = 0
        Me.mnuHABILITACION.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSOCIOS, Me.mnuUSUARIOS, Me.mnuCÓDIGOS})
        Me.mnuHABILITACION.Text = "HABILITACION"
        '
        'mnuSOCIOS
        '
        Me.mnuSOCIOS.Index = 0
        Me.mnuSOCIOS.Text = "SOCIO"
        '
        'mnuUSUARIOS
        '
        Me.mnuUSUARIOS.Index = 1
        Me.mnuUSUARIOS.Text = "USUARIO"
        '
        'mnuCÓDIGOS
        '
        Me.mnuCÓDIGOS.Index = 2
        Me.mnuCÓDIGOS.Text = "CÓDIGOS"
        '
        'mnuCARGAS
        '
        Me.mnuCARGAS.Index = 1
        Me.mnuCARGAS.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBONOS_DESC, Me.mnuAUTOFACTURAS, Me.mnuRECIBOS, Me.mnuFACTURA})
        Me.mnuCARGAS.Text = "CARGAR"
        '
        'mnuBONOS_DESC
        '
        Me.mnuBONOS_DESC.Index = 0
        Me.mnuBONOS_DESC.Text = "BONO/DESCUENTO"
        '
        'mnuAUTOFACTURAS
        '
        Me.mnuAUTOFACTURAS.Index = 1
        Me.mnuAUTOFACTURAS.Text = "AUTOFACTURA"
        '
        'mnuRECIBOS
        '
        Me.mnuRECIBOS.Index = 2
        Me.mnuRECIBOS.Text = "RECIBO"
        '
        'mnuFACTURA
        '
        Me.mnuFACTURA.Index = 3
        Me.mnuFACTURA.Text = "FACTURA"
        '
        'mnuINFORME
        '
        Me.mnuINFORME.Index = 2
        Me.mnuINFORME.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRECIBOLIQUI, Me.mnuINFORMEAPF, Me.mnuINDORMESCONTADURIA})
        Me.mnuINFORME.Text = "INFORMES"
        '
        'mnuRECIBOLIQUI
        '
        Me.mnuRECIBOLIQUI.Index = 0
        Me.mnuRECIBOLIQUI.Text = "RECIBO DE LIQUIDACION"
        '
        'mnuINFORMEAPF
        '
        Me.mnuINFORMEAPF.Index = 1
        Me.mnuINFORMEAPF.Text = "INFORMES PARA APF"
        '
        'mnuINDORMESCONTADURIA
        '
        Me.mnuINDORMESCONTADURIA.Index = 2
        Me.mnuINDORMESCONTADURIA.Text = "INFORMES PARA CONTADURIA"
        '
        'mnuREPORTES
        '
        Me.mnuREPORTES.Index = 3
        Me.mnuREPORTES.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRECIBOREP, Me.mnuAUTOFACTURAREP, Me.mnuSOCIOPROMOCION, Me.mnuBANCO, Me.mnuDISKETTE})
        Me.mnuREPORTES.Text = "REPORTE"
        '
        'mnuRECIBOREP
        '
        Me.mnuRECIBOREP.Index = 0
        Me.mnuRECIBOREP.Text = "RECIBOS "
        '
        'mnuAUTOFACTURAREP
        '
        Me.mnuAUTOFACTURAREP.Index = 1
        Me.mnuAUTOFACTURAREP.Text = "AUTOFACTURA"
        '
        'mnuSOCIOPROMOCION
        '
        Me.mnuSOCIOPROMOCION.Index = 2
        Me.mnuSOCIOPROMOCION.Text = "SOCIO POR PROMOCION"
        '
        'mnuBANCO
        '
        Me.mnuBANCO.Index = 3
        Me.mnuBANCO.Text = "BANCO"
        '
        'mnuDISKETTE
        '
        Me.mnuDISKETTE.Index = 4
        Me.mnuDISKETTE.Text = "DISKETTE"
        '
        'mnuSALIRSIST
        '
        Me.mnuSALIRSIST.Index = 4
        Me.mnuSALIRSIST.Text = "SALIR "
        '
        'mnuBANCOS
        '
        Me.mnuBANCOS.Index = 3
        Me.mnuBANCOS.Text = "BANCO"
        '
        'mnuDISKETTES
        '
        Me.mnuDISKETTES.Index = 4
        Me.mnuDISKETTES.Text = "DISKETTE"
        '
        'mnuFACTURAS
        '
        Me.mnuFACTURAS.Index = 3
        Me.mnuFACTURAS.Text = "FACTURA"
        '
        'frmMENU
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 24)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(936, 725)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "MENU DE ADMINISTRACION ""CIRCULO PARAGUAYO DE ARBITROS DE FUTBOLL"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub mnuSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSI.Click
        Call CerrarConexion()
        'MessageBox.Show(" ¿ESTAS SEGURO QUE DESEA SALIR DEL SISTEMA ? ", strSLOGAN)
        If MessageBox.Show("Desea cerrar la Sesión?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim frmnew As New frmINGRESO
            frmnew.Show()
            Me.Close()
            'Me.Dispose()
        End If
    End Sub

    Private Sub mnuUSUARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUSUARIO.Click
        Dim frmnew As New frmUSUARIOS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuBONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBONO.Click
        Dim frmnew As New frmPROCESOCRUD
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuCODIGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCODIGOS.Click
        Dim frmnew As New CRUDcodigos
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuSOCIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSOCIO.Click
        Dim frmnew As New frmDATOS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuRECIBO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRECIBO.Click
        Dim frmnew As New frmEMISIONRECIBO
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuAUTOFACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAUTOFACTURA.Click
        Dim frmnew As New frmAUTOFACTURA
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuAUTOFACTCON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmnew As New frmAUTOFACTURACON
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuPLANILLACONTADURIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPLANILLACONTADURIA.Click
        Dim frmnew As New frmCONTADURIA
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuPLANILLAAPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPLANILLAAPF.Click
        Dim frmnew As New frmPAGOAARBITROS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuEMISIONRECIBO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEMISIONRECIBO.Click
        Dim frmnew As New frmRECIBO
        frmnew.ShowDialog(Me)

    End Sub

    Private Sub mnuRECIBODINERO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRECIBODINERO.Click
        Dim frmnew As New frmRECIBOREP
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuFACURAREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFACURAREP.Click
        Dim frmnew As New frmAUTOFACTURAREP
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuSOCIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSOCIOS.Click
        Dim frmnew As New frmDATOS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuUSUARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUSUARIOS.Click
        Dim frmnew As New frmUSUARIOS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuCÓDIGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCÓDIGOS.Click
        Dim frmnew As New CRUDcodigos
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuBONOS_DESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBONOS_DESC.Click
        Dim frmnew As New frmPROCESOCRUD
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuAUTOFACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAUTOFACTURAS.Click
        Dim frmnew As New frmAUTOFACTURA
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuRECIBOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRECIBOS.Click
        Dim frmnew As New frmRECIBO
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuRECIBOLIQUI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRECIBOLIQUI.Click
        Dim frmnew As New frmEMISIONRECIBO
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuINFORMEAPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuINFORMEAPF.Click
        Dim frmnew As New frmPAGOAARBITROS
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuINDORMESCONTADURIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuINDORMESCONTADURIA.Click
        Dim frmnew As New frmCONTADURIA
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuRECIBOREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRECIBOREP.Click
        Dim frmnew As New frmRECIBOREP
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuAUTOFACTURAREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAUTOFACTURAREP.Click
        Dim frmnew As New frmAUTOFACTURAREP
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuSALIRSIST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSALIRSIST.Click
        Call CerrarConexion()
        'MessageBox.Show(" ¿ESTAS SEGURO QUE DESEA SALIR DEL SISTEMA ? ", strSLOGAN)
        If MessageBox.Show("Desea cerrar la Sesión?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim frmnew As New frmINGRESO
            frmnew.Show()
            Me.Close()
            'Me.Dispose()
        End If
    End Sub

    'Private Sub mnuSALIR_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSALIR.Popup
    '    Call CerrarConexion()
    '    'MessageBox.Show(" ¿ESTAS SEGURO QUE DESEA SALIR DEL SISTEMA ? ", strSLOGAN)
    '    If MessageBox.Show("Desea cerrar la Sesión?", strSLOGAN, MessageBoxButtons.YesNo) = DialogResult.Yes Then
    '        Dim frmnew As New frmINGRESO
    '        frmnew.Show()
    '        Me.Close()
    '        'Me.Dispose()
    '    End If
    'End Sub

    Private Sub mnuSOCIOPROMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSOCIOPROMO.Click
        Dim frmnew As New frmSOCIOSPROMOCION
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuSOCIOPROMOCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSOCIOPROMOCION.Click
        Dim frmnew As New frmSOCIOSPROMOCION
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuFACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFACTURA.Click
        Dim frmnew As New frmFACTURA
        frmnew.ShowDialog(Me)

    End Sub

    Private Sub mnuBANCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBANCO.Click
        Dim frmnew As New frmBANCO
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuDISKETTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDISKETTE.Click
        Dim frmnew As New frmDISKETE
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuFACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFACTURAS.Click
        Dim frmnew As New frmFACTURA
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuBANCOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBANCOS.Click
        Dim frmnew As New frmBANCO
        frmnew.ShowDialog(Me)
    End Sub

    Private Sub mnuDISKETTES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDISKETTES.Click
        Dim frmnew As New frmDISKETE
        frmnew.ShowDialog(Me)
    End Sub
End Class

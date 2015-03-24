Public Class frmAUTOFACTURACON
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdAUTOFACTURA As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdAUTOFACTURA = New System.Windows.Forms.DataGrid
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdAUTOFACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdAUTOFACTURA)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Datos"
        '
        'grdAUTOFACTURA
        '
        Me.grdAUTOFACTURA.DataMember = ""
        Me.grdAUTOFACTURA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdAUTOFACTURA.Location = New System.Drawing.Point(8, 18)
        Me.grdAUTOFACTURA.Name = "grdAUTOFACTURA"
        Me.grdAUTOFACTURA.ReadOnly = True
        Me.grdAUTOFACTURA.Size = New System.Drawing.Size(471, 168)
        Me.grdAUTOFACTURA.TabIndex = 1
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(91, 14)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(200, 22)
        Me.txtbusqueda.TabIndex = 0
        Me.txtbusqueda.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Búsqueda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Click en la Primera fila para SELECCIONAR"
        '
        'frmAUTOFACTURACON
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(511, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAUTOFACTURACON"
        Me.Text = "Ayuda de Número de Autofactura"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdAUTOFACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAUTOFACTURACON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        CerrarConexion()
    End Sub

    Private Sub cargarGrilla()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT autfecha, autbeneficiario,  autnumero FROM autofactura order by autnumero DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "autofactura")

        dataviewLOCAL = New DataView(dsDATOS.Tables("autofactura"), "autbeneficiario LIKE '%'", "autnumero DESC", DataViewRowState.OriginalRows)
        Me.grdAUTOFACTURA.DataSource = dataviewLOCAL
        Me.grdAUTOFACTURA.CaptionText = "Cantidad de Autofactura: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaAUTOFACTURA(Trim(Me.txtbusqueda.Text))
    End Sub
    Sub cargarGrillaAUTOFACTURA(ByVal auxnombre As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT autfecha, autbeneficiario, autnumero FROM autofactura order by autfecha DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "AUTOFACTURA")

        dataviewLOCAL = New DataView(dsDATOS.Tables("AUTOFACTURA"), "autbeneficiario like '%" & auxnombre & "%'", "autfecha ASC", DataViewRowState.OriginalRows)
        Me.grdAUTOFACTURA.DataSource = dataviewLOCAL
        Me.grdAUTOFACTURA.CaptionText = "Cantidad de Autofactura: " + dataviewLOCAL.Count.ToString
    End Sub

    Private Sub grdAUTOFACTURA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdAUTOFACTURA.Navigate

    End Sub

    Private Sub setEstiloGrilla()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOS.Tables("AUTOFACTURA").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn

        With estilo1
            .MappingName = "autfecha"
            .HeaderText = " Fecha "
            .Width = 75
        End With

        With estilo2
            .MappingName = "autbeneficiario"
            .HeaderText = "Beneficiario"
            .Width = 250
        End With


        With estilo3
            .MappingName = "autnumero"
            .HeaderText = " NUMERO "
            .Width = 70
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        Me.grdAUTOFACTURA.TableStyles.Clear()
        Me.grdAUTOFACTURA.TableStyles.Add(estilos)

    End Sub

    Private Sub grdAUTOFACTURA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdAUTOFACTURA.Click
        Dim fila As Integer
        fila = grdAUTOFACTURA.CurrentRowIndex
        glonumero = grdAUTOFACTURA.Item(fila, 2)
        Me.Dispose()
    End Sub
End Class

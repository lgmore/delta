Public Class frmFACTURACON
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdFACTURA As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdFACTURA = New System.Windows.Forms.DataGrid
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdFACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdFACTURA)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Datos"
        '
        'grdFACTURA
        '
        Me.grdFACTURA.DataMember = ""
        Me.grdFACTURA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdFACTURA.Location = New System.Drawing.Point(8, 18)
        Me.grdFACTURA.Name = "grdFACTURA"
        Me.grdFACTURA.ReadOnly = True
        Me.grdFACTURA.Size = New System.Drawing.Size(471, 168)
        Me.grdFACTURA.TabIndex = 1
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
        Me.Label2.Text = "B�squeda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(16, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Click en la Primera fila para SELECCIONAR"
        '
        'frmFACTURACON
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(511, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFACTURACON"
        Me.Text = "Ayuda de N�mero de Factura"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdFACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFACTURACON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        CerrarConexion()
    End Sub

    Private Sub cargarGrilla()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT facfecha, facbeneficiario,  facnumero FROM factura order by facnumero DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "factura")

        dataviewLOCAL = New DataView(dsDATOS.Tables("factura"), "facbeneficiario LIKE '%'", "facnumero DESC", DataViewRowState.OriginalRows)
        Me.grdFACTURA.DataSource = dataviewLOCAL
        Me.grdFACTURA.CaptionText = "Cantidad de factura: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaFACTURA(Trim(Me.txtbusqueda.Text))
    End Sub
    Sub cargarGrillaFACTURA(ByVal auxnombre As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT facfecha, facbeneficiario, facnumero FROM facfactura order by facfecha DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "FACTURA")

        dataviewLOCAL = New DataView(dsDATOS.Tables("FACTURA"), "facbeneficiario like '%" & auxnombre & "%'", "facfecha ASC", DataViewRowState.OriginalRows)
        Me.grdFACTURA.DataSource = dataviewLOCAL
        Me.grdFACTURA.CaptionText = "Cantidad de Factura: " + dataviewLOCAL.Count.ToString
    End Sub

    Private Sub grdFACTURA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdFACTURA.Navigate

    End Sub

    Private Sub setEstiloGrilla()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOS.Tables("FACTURA").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn

        With estilo1
            .MappingName = "facfecha"
            .HeaderText = " Fecha "
            .Width = 75
        End With

        With estilo2
            .MappingName = "facbeneficiario"
            .HeaderText = "Razon Social"
            .Width = 250
        End With


        With estilo3
            .MappingName = "facnumero"
            .HeaderText = " NUMERO "
            .Width = 70
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        Me.grdFACTURA.TableStyles.Clear()
        Me.grdFACTURA.TableStyles.Add(estilos)

    End Sub

    Private Sub grdFACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFACTURA.Click
        Dim fila As Integer
        fila = grdFACTURA.CurrentRowIndex
        glonumero = grdFACTURA.Item(fila, 2)
        Me.Dispose()
    End Sub
End Class

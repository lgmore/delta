Public Class frmDATOSCON
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdarbitro As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdarbitro = New System.Windows.Forms.DataGrid
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdarbitro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdarbitro)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Datos"
        '
        'grdarbitro
        '
        Me.grdarbitro.DataMember = ""
        Me.grdarbitro.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdarbitro.Location = New System.Drawing.Point(8, 17)
        Me.grdarbitro.Name = "grdarbitro"
        Me.grdarbitro.ReadOnly = True
        Me.grdarbitro.Size = New System.Drawing.Size(428, 169)
        Me.grdarbitro.TabIndex = 1
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(93, 12)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(200, 22)
        Me.txtbusqueda.TabIndex = 0
        Me.txtbusqueda.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Búsqueda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(25, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Click en la Primera fila para SELECCIONAR"
        '
        'frmDATOSCON
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(479, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDATOSCON"
        Me.Text = "Ayuda de Arbitros"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdarbitro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDATOSCON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        CerrarConexion()
    End Sub

    Private Sub cargarGrilla()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT arbcedula, arbnombre FROM arbitro order by arbnombre ASC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre LIKE '%'", "arbnombre ASC", DataViewRowState.OriginalRows)
        Me.grdarbitro.DataSource = dataviewLOCAL
        Me.grdarbitro.CaptionText = "Cantidad de Arbitros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaArbitro(Trim(Me.txtbusqueda.Text))
    End Sub
    Sub cargarGrillaArbitro(ByVal auxnombre As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT arbcedula, arbnombre FROM arbitro order by arbnombre ASC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre like '%" & auxnombre & "%'", "arbnombre ASC", DataViewRowState.OriginalRows)
        Me.grdarbitro.DataSource = dataviewLOCAL
        Me.grdarbitro.CaptionText = "Cantidad de Arbitros: " + dataviewLOCAL.Count.ToString
    End Sub

    Private Sub grdAUTOFACTURA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdarbitro.Navigate

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
            .HeaderText = " Cédula  "
            .Width = 75
        End With

        With estilo2
            .MappingName = "arbnombre"
            .HeaderText = " Nombre"
            .Width = 300
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.grdarbitro.TableStyles.Clear()
        Me.grdarbitro.TableStyles.Add(estilos)

    End Sub

    Private Sub grdarbitro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdarbitro.Click
        Dim fila As Integer
        fila = grdarbitro.CurrentRowIndex
        wkarbcedula = grdarbitro.Item(fila, 0)
        glonombre = grdarbitro.Item(fila, 1)
        Me.Dispose()
    End Sub
End Class

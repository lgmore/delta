Public Class frmRECIBOCON
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
    Friend WithEvents grdRECIBO As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdRECIBO = New System.Windows.Forms.DataGrid
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdRECIBO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdRECIBO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Datos"
        '
        'grdRECIBO
        '
        Me.grdRECIBO.DataMember = ""
        Me.grdRECIBO.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRECIBO.Location = New System.Drawing.Point(6, 18)
        Me.grdRECIBO.Name = "grdRECIBO"
        Me.grdRECIBO.ReadOnly = True
        Me.grdRECIBO.Size = New System.Drawing.Size(523, 168)
        Me.grdRECIBO.TabIndex = 1
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(90, 14)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(200, 22)
        Me.txtbusqueda.TabIndex = 0
        Me.txtbusqueda.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Búsqueda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Click en la Primera fila para SELECCIONAR"
        '
        'frmRECIBOCON
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(558, 277)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRECIBOCON"
        Me.Text = "Ayuda de Números de Recibo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdRECIBO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRECIBOCON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        cargarGrilla()
        setEstiloGrilla()
        CerrarConexion()
    End Sub

    Private Sub cargarGrilla()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT recfecha, recbeneficiario,  recnumero FROM recibo where rectipo = '" & glotipo & "' order by recfecha DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "recibo")

        dataviewLOCAL = New DataView(dsDATOS.Tables("recibo"), "recbeneficiario LIKE '%'", "recnumero DESC", DataViewRowState.OriginalRows)
        Me.grdRECIBO.DataSource = dataviewLOCAL
        Me.grdRECIBO.CaptionText = "Cantidad de Recibo ==>> " & glotipo & " " + dataviewLOCAL.Count.ToString
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        cargarGrillaAUTOFACTURA(Trim(Me.txtbusqueda.Text), glotipo)
    End Sub
    Sub cargarGrillaAUTOFACTURA(ByVal auxnombre As String, ByVal auxtipo As String)
        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT recfecha, recbeneficiario, recnumero, rectipo FROM recibo order by recfecha DESC"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "RECIBO")

        dataviewLOCAL = New DataView(dsDATOS.Tables("RECIBO"), "recbeneficiario like '%" & auxnombre & "%' and rectipo = '" & auxtipo & "'", "recnumero ASC", DataViewRowState.OriginalRows)
        Me.grdRECIBO.DataSource = dataviewLOCAL
        Me.grdRECIBO.CaptionText = "Cantidad de Recibo ==>> " & glotipo & " " & dataviewLOCAL.Count.ToString
    End Sub

    Private Sub grdRECIBO_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdRECIBO.Navigate

    End Sub

    Private Sub setEstiloGrilla()
        Dim estilos As New DataGridTableStyle
        Dim xcolor As New Color


        estilos.MappingName = dsDATOS.Tables("RECIBO").TableName

        estilos.ForeColor = xcolor.DarkBlue
        estilos.BackColor = xcolor.Honeydew
        estilos.HeaderBackColor = xcolor.Wheat

        Dim estilo1 As New DataGridTextBoxColumn
        Dim estilo2 As New DataGridTextBoxColumn
        Dim estilo3 As New DataGridTextBoxColumn

        With estilo1
            .MappingName = "recfecha"
            .HeaderText = " Fecha "
            .Width = 75
        End With

        With estilo2
            .MappingName = "recbeneficiario"
            .HeaderText = "Beneficiario"
            .Width = 300
        End With


        With estilo3
            .MappingName = "recnumero"
            .HeaderText = " NUMERO "
            .Width = 85
        End With

        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)
        estilos.GridColumnStyles.Add(estilo3)
        Me.grdRECIBO.TableStyles.Clear()
        Me.grdRECIBO.TableStyles.Add(estilos)

    End Sub

    Private Sub grdRECIBO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdRECIBO.Click
        Dim fila As Integer
        fila = grdRECIBO.CurrentRowIndex
        glonumero = grdRECIBO.Item(fila, 2)
        Me.Dispose()
    End Sub
End Class

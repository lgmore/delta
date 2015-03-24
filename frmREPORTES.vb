Imports claseNUMEROALETRA.NumLetras
Imports CrystalDecisions.Shared


Public Class frmREPORTES

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
    Friend WithEvents tabcCONDICIONES As System.Windows.Forms.TabControl
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tabpRECIBOLIQUIDACION As System.Windows.Forms.TabPage
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAINICIAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAFINAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtaLISTACEDULA As System.Windows.Forms.DataGrid
    Friend WithEvents btnGENERARRECIBOLIQUIDACION As System.Windows.Forms.Button
    Friend WithEvents lblNUMEROCEDULA As System.Windows.Forms.Label
    Friend WithEvents lblNOMBREAPELLIDO As System.Windows.Forms.Label
    Friend WithEvents txtNUMEROCEDULA As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBREAPELLIDO As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tabcCONDICIONES = New System.Windows.Forms.TabControl
        Me.tabpRECIBOLIQUIDACION = New System.Windows.Forms.TabPage
        Me.txtNOMBREAPELLIDO = New System.Windows.Forms.TextBox
        Me.txtNUMEROCEDULA = New System.Windows.Forms.TextBox
        Me.lblNOMBREAPELLIDO = New System.Windows.Forms.Label
        Me.lblNUMEROCEDULA = New System.Windows.Forms.Label
        Me.btnGENERARRECIBOLIQUIDACION = New System.Windows.Forms.Button
        Me.dtaLISTACEDULA = New System.Windows.Forms.DataGrid
        Me.dtpFECHAFINAL = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFECHAINICIAL = New System.Windows.Forms.DateTimePicker
        Me.lblFECHAINICIO = New System.Windows.Forms.Label
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tabcCONDICIONES.SuspendLayout()
        Me.tabpRECIBOLIQUIDACION.SuspendLayout()
        CType(Me.dtaLISTACEDULA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcCONDICIONES
        '
        Me.tabcCONDICIONES.Controls.Add(Me.tabpRECIBOLIQUIDACION)
        Me.tabcCONDICIONES.Location = New System.Drawing.Point(16, 16)
        Me.tabcCONDICIONES.Name = "tabcCONDICIONES"
        Me.tabcCONDICIONES.SelectedIndex = 0
        Me.tabcCONDICIONES.Size = New System.Drawing.Size(992, 232)
        Me.tabcCONDICIONES.TabIndex = 0
        '
        'tabpRECIBOLIQUIDACION
        '
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.txtNOMBREAPELLIDO)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.txtNUMEROCEDULA)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.lblNOMBREAPELLIDO)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.lblNUMEROCEDULA)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.btnGENERARRECIBOLIQUIDACION)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.dtaLISTACEDULA)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.dtpFECHAFINAL)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.Label1)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.dtpFECHAINICIAL)
        Me.tabpRECIBOLIQUIDACION.Controls.Add(Me.lblFECHAINICIO)
        Me.tabpRECIBOLIQUIDACION.Location = New System.Drawing.Point(4, 22)
        Me.tabpRECIBOLIQUIDACION.Name = "tabpRECIBOLIQUIDACION"
        Me.tabpRECIBOLIQUIDACION.Size = New System.Drawing.Size(984, 206)
        Me.tabpRECIBOLIQUIDACION.TabIndex = 0
        Me.tabpRECIBOLIQUIDACION.Text = "Recibo de liquidación"
        '
        'txtNOMBREAPELLIDO
        '
        Me.txtNOMBREAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREAPELLIDO.Location = New System.Drawing.Point(744, 168)
        Me.txtNOMBREAPELLIDO.Name = "txtNOMBREAPELLIDO"
        Me.txtNOMBREAPELLIDO.ReadOnly = True
        Me.txtNOMBREAPELLIDO.Size = New System.Drawing.Size(184, 26)
        Me.txtNOMBREAPELLIDO.TabIndex = 9
        Me.txtNOMBREAPELLIDO.Text = ""
        '
        'txtNUMEROCEDULA
        '
        Me.txtNUMEROCEDULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMEROCEDULA.Location = New System.Drawing.Point(744, 112)
        Me.txtNUMEROCEDULA.Name = "txtNUMEROCEDULA"
        Me.txtNUMEROCEDULA.ReadOnly = True
        Me.txtNUMEROCEDULA.Size = New System.Drawing.Size(184, 26)
        Me.txtNUMEROCEDULA.TabIndex = 8
        Me.txtNUMEROCEDULA.Text = ""
        '
        'lblNOMBREAPELLIDO
        '
        Me.lblNOMBREAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBREAPELLIDO.Location = New System.Drawing.Point(744, 144)
        Me.lblNOMBREAPELLIDO.Name = "lblNOMBREAPELLIDO"
        Me.lblNOMBREAPELLIDO.Size = New System.Drawing.Size(184, 23)
        Me.lblNOMBREAPELLIDO.TabIndex = 7
        Me.lblNOMBREAPELLIDO.Text = "Nombre y Apellido"
        '
        'lblNUMEROCEDULA
        '
        Me.lblNUMEROCEDULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMEROCEDULA.Location = New System.Drawing.Point(744, 88)
        Me.lblNUMEROCEDULA.Name = "lblNUMEROCEDULA"
        Me.lblNUMEROCEDULA.Size = New System.Drawing.Size(184, 23)
        Me.lblNUMEROCEDULA.TabIndex = 6
        Me.lblNUMEROCEDULA.Text = "Número de Cédula"
        '
        'btnGENERARRECIBOLIQUIDACION
        '
        Me.btnGENERARRECIBOLIQUIDACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARRECIBOLIQUIDACION.Location = New System.Drawing.Point(744, 24)
        Me.btnGENERARRECIBOLIQUIDACION.Name = "btnGENERARRECIBOLIQUIDACION"
        Me.btnGENERARRECIBOLIQUIDACION.Size = New System.Drawing.Size(184, 56)
        Me.btnGENERARRECIBOLIQUIDACION.TabIndex = 5
        Me.btnGENERARRECIBOLIQUIDACION.Text = "Generar Recibo"
        '
        'dtaLISTACEDULA
        '
        Me.dtaLISTACEDULA.DataMember = ""
        Me.dtaLISTACEDULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaLISTACEDULA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaLISTACEDULA.Location = New System.Drawing.Point(64, 56)
        Me.dtaLISTACEDULA.Name = "dtaLISTACEDULA"
        Me.dtaLISTACEDULA.ReadOnly = True
        Me.dtaLISTACEDULA.Size = New System.Drawing.Size(672, 144)
        Me.dtaLISTACEDULA.TabIndex = 4
        '
        'dtpFECHAFINAL
        '
        Me.dtpFECHAFINAL.Location = New System.Drawing.Point(536, 24)
        Me.dtpFECHAFINAL.Name = "dtpFECHAFINAL"
        Me.dtpFECHAFINAL.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(432, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFECHAINICIAL
        '
        Me.dtpFECHAINICIAL.Location = New System.Drawing.Point(160, 24)
        Me.dtpFECHAINICIAL.Name = "dtpFECHAINICIAL"
        Me.dtpFECHAINICIAL.TabIndex = 1
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(32, 24)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(128, 24)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha inicial: "
        Me.lblFECHAINICIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.Location = New System.Drawing.Point(16, 256)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.ReportSource = Nothing
        Me.crpREPORTE.Size = New System.Drawing.Size(992, 472)
        Me.crpREPORTE.TabIndex = 1
        '
        'frmREPORTES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.tabcCONDICIONES)
        Me.Name = "frmREPORTES"
        Me.Text = "frmREPORTES"
        Me.tabcCONDICIONES.ResumeLayout(False)
        Me.tabpRECIBOLIQUIDACION.ResumeLayout(False)
        CType(Me.dtaLISTACEDULA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Class tipocampoRECIBOLIQUIDACION
        Public codigo As Integer
        Public descripcion As String
        Public fecha As Date
        Public bono As Integer
        Public descuento As Integer
        Public saldo As Integer
        Public tipo As String
        Public nrocuota As Integer
        Public pagada As Integer
        Public codigoconcepto As Integer
        Public descripcionconcepto As String
        Public equipo1 As String
        Public equipo2 As String
        Public estadio As String
        Public fechapartida As Date

    End Class
    Class tipoauxPARAMETROSRL
        Public arbnombre As String
        Public arbcedula As Integer
        Public arbcategoria As Integer
        Public arbpromocion As Integer
        Public fechainicio As String
        Public fechafin As String
    End Class

    Private Sub frmREPORTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AbrirConexion()
        cargarGrillaRECIBOLIQUIDACION()
        setEstiloGrillaRECIBOLIQUIDACION()
        CerrarConexion()

    End Sub

    Private Sub cargarGrillaRECIBOLIQUIDACION()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strsql = "SELECT arbcedula,arbnombre FROM arbitro"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strsql, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "arbnombre LIKE '%'", "arbcedula ASC", DataViewRowState.OriginalRows)
        Me.dtaLISTACEDULA.DataSource = dataviewLOCAL
        Me.dtaLISTACEDULA.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaRECIBOLIQUIDACION()
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
            .HeaderText = "Cédula de identidad"
            .Width = 110
        End With


        With estilo2
            .MappingName = "arbnombre"
            .HeaderText = "Nombre y Apellido"
            .Width = 595

        End With


        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)

        Me.dtaLISTACEDULA.TableStyles.Clear()
        Me.dtaLISTACEDULA.TableStyles.Add(estilos)
    End Sub

    Private Sub dtaLISTACEDULA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaLISTACEDULA.Navigate

    End Sub

    Private Sub dtaLISTACEDULA_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaLISTACEDULA.CurrentCellChanged

        Dim filagrillaactual As Integer

        filagrillaactual = Me.dtaLISTACEDULA.CurrentCell.RowNumber

        Me.txtNUMEROCEDULA.Text = Me.dtaLISTACEDULA.Item(filagrillaactual, 0)
        Me.txtNOMBREAPELLIDO.Text = Me.dtaLISTACEDULA.Item(filagrillaactual, 1)
    End Sub

    Private Sub btnGENERARRECIBOLIQUIDACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERARRECIBOLIQUIDACION.Click
        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader

        Dim mycommand2 As Odbc.OdbcCommand
        Dim myreader2 As Odbc.OdbcDataReader
        Dim actual As New tipocampoRECIBOLIQUIDACION
        Dim auxCANTIDADREGISTROSCONTADOS As Integer = 0

        Try
            AbrirConexion()
            strsql = "SELECT fijcodigo,fijmonto,fijfecha,fijcuota,fijpagado,fijtipo " & _
                     " from bonodesfijo " & _
                     " where (fijfecha > '" & Me.dtpFECHAINICIAL.Value.Date.ToString("yyyy-MM-dd") & "' and fijfecha<'" & Me.dtpFECHAFINAL.Value.Date.ToString("yyyy-MM-dd") & "' " & _
                     " and fijcedula= " & Me.txtNUMEROCEDULA.Text & " ) "

            mycommand = New Odbc.OdbcCommand(strsql, ca_cn)
            myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

            actual = New tipocampoRECIBOLIQUIDACION
            While (myreader.Read())

                actual.codigo = myreader.GetValue(0)
                actual.tipo = myreader.GetValue(5)
                If (LCase(actual.tipo) = "B") Then
                    actual.bono = myreader.GetValue(1)
                    actual.saldo = actual.saldo + actual.bono
                Else
                    actual.descuento = myreader.GetValue(1)
                    actual.saldo = actual.saldo - actual.descuento
                End If

                actual.fecha = myreader.GetValue(2)
                actual.nrocuota = myreader.GetValue(3)
                actual.pagada = myreader.GetValue(4)
                actual.codigoconcepto = myreader.GetValue(0)

                ''CARGA DE DATOS DE CONCEPTO
                Dim ca_cn2 As New Odbc.OdbcConnection(strcadena)
                ca_cn2.Open()
                strsql = "SELECT conbreve " & _
                     " from concepto " & _
                     " where concodigo= " & actual.codigoconcepto
                mycommand = New Odbc.OdbcCommand(strsql, ca_cn2)
                myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                While myreader.Read()
                    actual.descripcionconcepto = myreader.GetValue(0)
                End While
                ca_cn2.Close()
                ''FIN DE CARGA DE DATOS DE CONCEPTO

                ''CARGA DE DATOS DE RECIBO DE LIQUIDACION
                ca_cn2.Open()
                strsql = "INSERT INTO auxRECIBOLIQUIDACION2 (codigo,descripcion,fecha,bono,descuento,saldo,nrocuota,nrocuotapagada)" & _
                "values (" & actual.codigo & ",'" & actual.descripcionconcepto & "'," & actual.fecha.Date.ToString("yyyy-MM-dd") & "," & actual.bono & _
                "," & actual.descuento & "," & actual.saldo & "," & actual.nrocuota & "," & actual.pagada & ")"

                mycommand = New Odbc.OdbcCommand(strsql, ca_cn2)
                mycommand.ExecuteNonQuery()
                ca_cn2.Close()
                auxCANTIDADREGISTROSCONTADOS = auxCANTIDADREGISTROSCONTADOS + 1
                ''FIN DE CARGA DE DATOS DE RECIBO DE LIQUIDACION

            End While
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

        Try

            AbrirConexion()
            strsql = "SELECT movmonto,movfecha,movequipo1,movequipo2,movestadio,movfechapartida,movconcepto " & _
                     " from movmensual " & _
                     " where (movfecha > '" & Me.dtpFECHAINICIAL.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <'" & Me.dtpFECHAFINAL.Value.Date.ToString("yyyy-MM-dd") & "') " & _
                     " and movcedula= " & Me.txtNUMEROCEDULA.Text
            mycommand = New Odbc.OdbcCommand(strsql, ca_cn)
            myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            'Dim actual As New tipocampoRECIBOLIQUIDACION
            'actual = New tipocampoRECIBOLIQUIDACION
            While (myreader.Read())

                actual.bono = myreader.GetValue(0)
                actual.saldo = actual.saldo + actual.bono
                actual.fecha = myreader.GetValue(1)
                actual.equipo1 = myreader.GetValue(2)
                actual.equipo2 = myreader.GetValue(3)
                actual.estadio = myreader.GetValue(4)
                actual.fechapartida = myreader.GetValue(5)
                actual.codigoconcepto = myreader.GetValue(6)

                ''CARGA DE DATOS DE CONCEPTO
                Dim ca_cn2 As New Odbc.OdbcConnection(strcadena)
                ca_cn2.Open()
                strsql = "SELECT conbreve " & _
                     " from concepto " & _
                     " where concodigo= " & actual.codigoconcepto
                mycommand = New Odbc.OdbcCommand(strsql, ca_cn2)
                myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                While myreader.Read()
                    actual.descripcionconcepto = myreader.GetValue(0)
                End While
                ca_cn2.Close()
                ''FIN DE CARGA DE DATOS DE CONCEPTO

                ''CARGA DE DATOS DE RECIBO DE LIQUIDACION
                ca_cn2.Open()
                strsql = "INSERT INTO auxRECIBOLIQUIDACION (cedula,codigo,descripcion,bono,equipo1,equipo2,estadio,fechapartida)" & _
                "values (" & Me.txtNUMEROCEDULA.Text & ",'" & actual.codigo & ",'" & actual.descripcionconcepto & "'," & actual.bono & _
                ",'" & actual.equipo1 & "','" & actual.equipo2 & "','" & actual.estadio & "'," & actual.fechapartida.Date.ToString("yyyy-MM-dd") & ")"

                mycommand = New Odbc.OdbcCommand(strsql, ca_cn2)
                mycommand.ExecuteNonQuery()
                ca_cn2.Close()
                ''FIN DE CARGA DE DATOS DE RECIBO DE LIQUIDACION

            End While
            CerrarConexion()

        Catch ex As Exception

        End Try

        Dim saldoenLETRAS As String
        Dim auxsaldoenNUMERO As Integer

        auxsaldoenNUMERO = actual.saldo
        Dim convertidor As New NumLetras
        saldoenLETRAS = convertidor.Convierte(auxsaldoenNUMERO.ToString, Tipo.Pronombre)
        If (String.Compare(saldoenLETRAS, "") = 0) Then
            saldoenLETRAS = "cero"
        End If
        Dim auxiliarPARAMETROS As New tipoauxPARAMETROSRL
        Me.txtNUMEROCEDULA.Text = Me.dtaLISTACEDULA.Item(Me.dtaLISTACEDULA.CurrentRowIndex, 0)
        auxiliarPARAMETROS.arbcedula = Integer.Parse(Me.txtNUMEROCEDULA.Text)
        auxiliarPARAMETROS.arbnombre = Me.txtNOMBREAPELLIDO.Text
        auxiliarPARAMETROS.fechafin = Me.dtpFECHAFINAL.Value.Date.ToString("dd/MM/yyyy")
        auxiliarPARAMETROS.fechainicio = Me.dtpFECHAFINAL.Value.Date.ToString("dd/MM/yyyy")

        Try
            strsql = "SELECT arbcategoria,arbpromocion FROM arbitro where arbcedula= " & Me.txtNUMEROCEDULA.Text
            AbrirConexion()
            mycommand = New Odbc.OdbcCommand(strsql, ca_cn)
            myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)


            While (myreader.Read())
                auxiliarPARAMETROS.arbcategoria = myreader.GetValue(0)
                auxiliarPARAMETROS.arbpromocion = myreader.GetValue(1)

            End While
            CerrarConexion()
        Catch ex As Exception

        End Try

        strsql = "truncate table auxparametros"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strsql, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()


        strsql = "insert into auxparametros (arbcedula,arbnombre,arbcategoria,arbpromocion,fechainicio,fechafin,saldoletras) " & _
        "values (" & auxiliarPARAMETROS.arbcedula & ",'" & auxiliarPARAMETROS.arbnombre & "'," & auxiliarPARAMETROS.arbcategoria & "," & _
        "" & auxiliarPARAMETROS.arbpromocion & ",'" & auxiliarPARAMETROS.fechainicio & "','" & auxiliarPARAMETROS.fechafin & "','" & saldoenLETRAS & "')"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strsql, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()
        'Dim reporte As New crpRECIBOLIQUIDACIONFINAL
        Dim reporte As New crpRECIBOREP
        ' objeto para contener una colección de valores de parámetros
        Dim pvValoresParametros As New ParameterValues
        '' objeto para almacenar un valor de un parámetro
        Dim parfechainicial As New ParameterDiscreteValue
        'Dim parfechafinal As New ParameterDiscreteValue
        'Dim auxsaldoenletras As New ParameterDiscreteValue


        '' asignar el valor al parámetro
        parfechainicial.Value = Me.dtpFECHAINICIAL.Value.Date.ToString("dd/MM/yyyy")

        '' añadir el parámetro a la colección de parámetros
        pvValoresParametros.Clear()
        pvValoresParametros.Add(parfechainicial)

        'reporte.OpenSubreport("crpRECIBOLIQUIDACION")
        'reporte.DataDefinition.ParameterFields("fechaINICIO").ApplyCurrentValues(pvValoresParametros)
        'parfechafinal.Value = 
        'pvValoresParametros.Clear()
        'pvValoresParametros.Add(parfechafinal)

        ' tomar del informe, el parámetro que necesitemos,
        ' a través de su colección de campos de parámetros,
        ' y aplicar a dicho parámetro los valores de los

        ' parámetros que están en la colección (en este caso sólo uno)

        reporte.DataDefinition.ParameterFields("fecha").ApplyCurrentValues(pvValoresParametros)

        'auxsaldoenletras.Value = saldoenLETRAS
        'pvValoresParametros.Clear()
        'pvValoresParametros.Add(auxsaldoenletras)

        'reporte.DataDefinition.ParameterFields("saldoLETRAS").ApplyCurrentValues(pvValoresParametros)

        'Me.crpREPORTE.SelectionFormula = "{arbitro.arbcedula} = " & Me.txtNUMEROCEDULA.Text & ""

        'If (auxCANTIDADREGISTROSCONTADOS = 0) Then

        '    reporte.ReportDefinition.Sections("Section16").SectionFormat.EnableSuppress = True

        'End If

        ''reporte.SetDatabaseLogon("postgres", "cielo")

        Me.crpREPORTE.ReportSource = reporte


    End Sub
End Class

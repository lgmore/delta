Imports claseNUMEROALETRA.NumLetras

Public Class frmEMISIONRECIBO
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
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents lblFECHAFINAL As System.Windows.Forms.Label
    Friend WithEvents lblCEDULA As System.Windows.Forms.Label
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents grpCONTROLES As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCEDULA As System.Windows.Forms.TextBox
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtaBUSQUEDA As System.Windows.Forms.DataGrid
    Friend WithEvents lblBUSQUEDA As System.Windows.Forms.Label
    Friend WithEvents txtBUSQUEDA As System.Windows.Forms.TextBox
    Friend WithEvents timerBUSQUEDA As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblTITULO = New System.Windows.Forms.Label
        Me.grpCONTROLES = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBUSQUEDA = New System.Windows.Forms.TextBox
        Me.lblBUSQUEDA = New System.Windows.Forms.Label
        Me.dtaBUSQUEDA = New System.Windows.Forms.DataGrid
        Me.txtCEDULA = New System.Windows.Forms.TextBox
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker
        Me.dtpFECHAINICIO = New System.Windows.Forms.DateTimePicker
        Me.lblCEDULA = New System.Windows.Forms.Label
        Me.lblFECHAFINAL = New System.Windows.Forms.Label
        Me.lblFECHAINICIO = New System.Windows.Forms.Label
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.timerBUSQUEDA = New System.Windows.Forms.Timer(Me.components)
        Me.grpCONTROLES.SuspendLayout()
        CType(Me.dtaBUSQUEDA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTITULO
        '
        Me.lblTITULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(16, 8)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(984, 32)
        Me.lblTITULO.TabIndex = 0
        Me.lblTITULO.Text = "EMISIÓN DE RECIBOS"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCONTROLES
        '
        Me.grpCONTROLES.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grpCONTROLES.Controls.Add(Me.Label1)
        Me.grpCONTROLES.Controls.Add(Me.txtBUSQUEDA)
        Me.grpCONTROLES.Controls.Add(Me.lblBUSQUEDA)
        Me.grpCONTROLES.Controls.Add(Me.dtaBUSQUEDA)
        Me.grpCONTROLES.Controls.Add(Me.txtCEDULA)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAFIN)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAINICIO)
        Me.grpCONTROLES.Controls.Add(Me.lblCEDULA)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAFINAL)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAINICIO)
        Me.grpCONTROLES.Controls.Add(Me.btnGENERARREPORTE)
        Me.grpCONTROLES.Controls.Add(Me.btnSALIR)
        Me.grpCONTROLES.Location = New System.Drawing.Point(16, 40)
        Me.grpCONTROLES.Name = "grpCONTROLES"
        Me.grpCONTROLES.Size = New System.Drawing.Size(984, 240)
        Me.grpCONTROLES.TabIndex = 1
        Me.grpCONTROLES.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Obs: Deje el campo de número de cédula en blanco para imprimir los recibos para t" & _
        "odos los árbitros"
        '
        'txtBUSQUEDA
        '
        Me.txtBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUSQUEDA.Location = New System.Drawing.Point(544, 16)
        Me.txtBUSQUEDA.Name = "txtBUSQUEDA"
        Me.txtBUSQUEDA.Size = New System.Drawing.Size(424, 26)
        Me.txtBUSQUEDA.TabIndex = 11
        Me.txtBUSQUEDA.Text = ""
        '
        'lblBUSQUEDA
        '
        Me.lblBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBUSQUEDA.Location = New System.Drawing.Point(376, 16)
        Me.lblBUSQUEDA.Name = "lblBUSQUEDA"
        Me.lblBUSQUEDA.Size = New System.Drawing.Size(176, 24)
        Me.lblBUSQUEDA.TabIndex = 10
        Me.lblBUSQUEDA.Text = "Búsqueda por nombre:"
        '
        'dtaBUSQUEDA
        '
        Me.dtaBUSQUEDA.DataMember = ""
        Me.dtaBUSQUEDA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtaBUSQUEDA.Location = New System.Drawing.Point(376, 48)
        Me.dtaBUSQUEDA.Name = "dtaBUSQUEDA"
        Me.dtaBUSQUEDA.ReadOnly = True
        Me.dtaBUSQUEDA.Size = New System.Drawing.Size(592, 152)
        Me.dtaBUSQUEDA.TabIndex = 9
        '
        'txtCEDULA
        '
        Me.txtCEDULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEDULA.Location = New System.Drawing.Point(160, 120)
        Me.txtCEDULA.Name = "txtCEDULA"
        Me.txtCEDULA.Size = New System.Drawing.Size(200, 26)
        Me.txtCEDULA.TabIndex = 5
        Me.txtCEDULA.Text = ""
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(160, 80)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.TabIndex = 4
        '
        'dtpFECHAINICIO
        '
        Me.dtpFECHAINICIO.Location = New System.Drawing.Point(160, 32)
        Me.dtpFECHAINICIO.Name = "dtpFECHAINICIO"
        Me.dtpFECHAINICIO.TabIndex = 3
        '
        'lblCEDULA
        '
        Me.lblCEDULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEDULA.Location = New System.Drawing.Point(32, 128)
        Me.lblCEDULA.Name = "lblCEDULA"
        Me.lblCEDULA.Size = New System.Drawing.Size(120, 24)
        Me.lblCEDULA.TabIndex = 2
        Me.lblCEDULA.Text = "Nro de cédula:"
        '
        'lblFECHAFINAL
        '
        Me.lblFECHAFINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAFINAL.Location = New System.Drawing.Point(32, 80)
        Me.lblFECHAFINAL.Name = "lblFECHAFINAL"
        Me.lblFECHAFINAL.Size = New System.Drawing.Size(104, 24)
        Me.lblFECHAFINAL.TabIndex = 1
        Me.lblFECHAFINAL.Text = "Fecha final:"
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(32, 32)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(128, 24)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha de inicio:"
        '
        'btnGENERARREPORTE
        '
        Me.btnGENERARREPORTE.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGENERARREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGENERARREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(160, 160)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 7
        Me.btnGENERARREPORTE.Text = "Imprimir"
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(280, 160)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(80, 32)
        Me.btnSALIR.TabIndex = 8
        Me.btnSALIR.Text = "Salir"
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.Location = New System.Drawing.Point(16, 280)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.ReportSource = Nothing
        Me.crpREPORTE.Size = New System.Drawing.Size(984, 424)
        Me.crpREPORTE.TabIndex = 2
        '
        'timerBUSQUEDA
        '
        '
        'frmEMISIONRECIBO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 746)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.grpCONTROLES)
        Me.Controls.Add(Me.lblTITULO)
        Me.Name = "frmEMISIONRECIBO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Emisión de Recibos - Sistema Delta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCONTROLES.ResumeLayout(False)
        CType(Me.dtaBUSQUEDA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Class tipocampoRECIBOLIQUIDACION
        Public arbnombre As String
        Public arbcedula As Integer
        Public arbcategoria As Integer
        Public arbcategoriastring As String
        Public arbpromocion As Integer
        Public fechainicio As String
        Public fechafin As String

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
        Public fechapartida As Integer
        Public observaciones As String


    End Class
    Class auxconceptobreve
        Public codigo As Integer
        Public nombre As String
    End Class
    Class auxequipo
        Public codigo As Integer
        Public nombre As String
    End Class
    Class auxestadio
        Public codigo As Integer
        Public nombre As String
    End Class
    Class datosarbitros
        Public arbcedula As Integer
        Public arbnombre As String
        'Public arbcategoria As Integer
        Public arbpromocion As Integer
        Public saldo As Double
        Public saldoLETRAS As String
    End Class

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCONTROLES.Enter

    End Sub

    Private Sub btnGENERARREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERARREPORTE.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader

        Dim mycommand2 As Odbc.OdbcCommand
        Dim myreader2 As Odbc.OdbcDataReader

        Dim ca_cn2 As New Odbc.OdbcConnection
        ca_cn2 = New Odbc.OdbcConnection(strCADENA)
        ca_cn2.ConnectionTimeout = 0
        ca_cn2.Open()

        Dim ca_cn3 As New Odbc.OdbcConnection
        ca_cn3.ConnectionTimeout = 0
        ca_cn3 = New Odbc.OdbcConnection(strCADENA)
        'ca_cn3.Open()

        Dim mycommand3 As Odbc.OdbcCommand
        Dim myreader3 As Odbc.OdbcDataReader

        Dim contador As Integer = 0
        Dim nroarbitro As Integer = 1
        Dim cantidadarbitros As Integer
        Dim auxcodigoconceptobreve As Integer
        Dim ncopia As Integer
        Dim auxiliarcarga As tipocampoRECIBOLIQUIDACION
        Dim auxcodigoestadio As Integer



        Dim reporte As New crpRECIBOLIQUIDACION

        Dim saldoenLETRAS As String
        Dim auxsaldoenNUMERO As Integer

        ''VACIAR LA TABLA auxRECIBOLIQUIDACIÓN

        strSQL = "truncate table auxRECIBOLIQUIDACION"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()

        'FIN VACIAR LA TABLA auxRECIBOLIQUIDACIÓN
        ''BUSCAR LA CEDULA MAXIMA DE LOS ARBITROS PARA DIMENSIONAR EL ARRAY
        strSQL = "SELECT MAX(arbcedula) FROM arbitro"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        contador = myreader.GetValue(0) + 1
        Dim auxdatosarbitros(contador) As datosarbitros
        'FIN BUSCAR LA CEDULA MAXIMA


        ''BUSCAR EL CODIGO MAXIMO DE CONCEPTO 
        strSQL = "SELECT MAX(concodigo) FROM concepto"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        auxcodigoconceptobreve = myreader.GetValue(0) + 1
        CerrarConexion()
        Dim auxiliarconceptosbreves(auxcodigoconceptobreve) As auxconceptobreve
        'FIN BUSCAR CODIGO MAXIMO DE CONCEPTO

        'CARGA DE CONCEPTOS EN EL ARRAY DE CONCEPTOS
        ca_cn3 = New Odbc.OdbcConnection(strCADENA)
        ca_cn3.Open()
        strSQL = "SELECT concodigo,conbreve from concepto"

        mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
        myreader3 = mycommand3.ExecuteReader(CommandBehavior.Default)

        While (myreader3.Read())

            auxcodigoconceptobreve = myreader3.GetValue(0)
            auxiliarconceptosbreves(auxcodigoconceptobreve) = New auxconceptobreve
            auxiliarconceptosbreves(auxcodigoconceptobreve).codigo = myreader3.GetValue(0)
            auxiliarconceptosbreves(auxcodigoconceptobreve).nombre = myreader3.GetValue(1)
        End While
        ca_cn3.Close()
        ''FIN CARGA DE CONCEPTOS EN EL ARRAY DE CONCEPTOS

        Dim auxcodigoequipo As Integer
        ''BUSCAR EL CODIGO MAXIMO DE EQUIPOS
        strSQL = "SELECT MAX(equicodigo) FROM equipo"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        auxcodigoequipo = myreader.GetValue(0) + 1
        CerrarConexion()
        Dim auxiliarequipos(auxcodigoequipo) As auxequipo
        'FIN BUSCAR CODIGO MAXIMO DE EQUIPOS

        'CARGA DE EQUIPOS EN EL ARRAY DE EQUIPOS
        ca_cn3 = New Odbc.OdbcConnection(strCADENA)
        ca_cn3.Open()
        strSQL = "SELECT equicodigo,equibreve from equipo"
        mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
        myreader3 = mycommand3.ExecuteReader(CommandBehavior.Default)

        While (myreader3.Read())

            auxcodigoequipo = myreader3.GetValue(0)
            auxiliarequipos(auxcodigoequipo) = New auxequipo
            auxiliarequipos(auxcodigoequipo).codigo = myreader3.GetValue(0)
            auxiliarequipos(auxcodigoequipo).nombre = myreader3.GetValue(1)
        End While
        ca_cn3.Close()
        ''FIN CARGA DE EQUIPOS EN EL ARRAY DE EQUIPOS


        ''BUSCAR EL CODIGO MAXIMO DE ESTADIOS

        strSQL = "SELECT MAX(estcodigo) FROM estadio"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        auxcodigoestadio = myreader.GetValue(0)
        CerrarConexion()
        Dim auxiliarestadio(auxcodigoestadio) As auxestadio
        'FIN BUSCAR CODIGO MAXIMO DE EQUIPOS

        'CARGA DE ESTADIOS EN EL ARRAY DE ESTADIOS
        ca_cn3 = New Odbc.OdbcConnection(strCADENA)
        ca_cn3.Open()
        strSQL = "SELECT estcodigo,estnombre from estadio"
        mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
        myreader3 = mycommand3.ExecuteReader(CommandBehavior.Default)

        While (myreader3.Read())

            auxcodigoestadio = myreader3.GetValue(0)
            auxiliarestadio(auxcodigoestadio) = New auxestadio
            auxiliarestadio(auxcodigoestadio).codigo = myreader3.GetValue(0)
            auxiliarestadio(auxcodigoestadio).nombre = myreader3.GetValue(1)
        End While
        ca_cn3.Close()
        ''FIN CARGA DE EQUIPOS EN EL ARRAY DE EQUIPOS


        Dim aux As Integer
        Try
            aux = Integer.Parse(Me.txtCEDULA.Text)
        Catch ex As Exception
            aux = 0
        End Try
        If (aux > 0) Then

            strSQL = "SELECT arbcedula,arbnombre,arbcategoria,arbpromocion from arbitro where arbcedula= " & Me.txtCEDULA.Text

        Else
            strSQL = "SELECT arbcedula,arbnombre,arbcategoria,arbpromocion from arbitro"

        End If



        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

        'CARGA DE LOS ARBITROS EN EL ARRAY DE DATOS DE ARBITROS
        While (myreader.Read())
            nroarbitro = myreader.GetValue(0)
            If (IsNothing(auxdatosarbitros(nroarbitro))) Then
                auxdatosarbitros(nroarbitro) = New datosarbitros
            End If
            'auxdatosarbitros(nroarbitro).fechainicio = Me.dtpFECHAINICIO.Value.ToString("yyyy-MM-dd")
            'auxdatosarbitros(nroarbitro).fechafin = Me.dtpFECHAFIN.Value.ToString("yyyy-MM-dd")

            Try

                auxdatosarbitros(nroarbitro).arbcedula = myreader.GetValue(0)
                auxdatosarbitros(nroarbitro).arbnombre = myreader.GetValue(1)
                'auxdatosarbitros(nroarbitro).arbcategoria = myreader.GetValue(2)
                auxdatosarbitros(nroarbitro).arbpromocion = myreader.GetValue(3)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Sistema Delta", MessageBoxButtons.OK)

            End Try
        End While
        CerrarConexion()
        'FIN CARGA DE LOS ARBITROS EN EL ARRAY DE DATOS DE ARBITROS
        Try
            Integer.Parse(Me.txtCEDULA.Text)

            strSQL = "SELECT movmonto,movfecha,movtipo,movequipo1,movequipo2,movestadio,movcuota,movfechapartida," & _
                       "movconcepto,movcedula,movobservaciones from movmensual where " & _
                        " (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "' and movcedula=" & Me.txtCEDULA.Text & ") order by movfecha asc"


        Catch ex As Exception

            strSQL = "SELECT movmonto,movfecha,movtipo,movequipo1,movequipo2,movestadio,movcuota,movfechapartida," & _
                                     "movconcepto,movcedula,movobservaciones from movmensual where " & _
                                     " (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "') order by movfecha asc"

        End Try
        ca_cn2 = New Odbc.OdbcConnection(strCADENA)
        ca_cn2.Open()
        mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
        myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

        contador = 1


        ncopia = ncopia + 1
        auxiliarcarga = New tipocampoRECIBOLIQUIDACION
        Dim cardinal As Double = 1
        Dim saldoanterior As Double
        Try
            While (myreader2.Read())
                contador = 1
                Do While (contador <= 2)
                    cardinal = cardinal + 1
                    nroarbitro = myreader2.GetValue(9)
                    auxiliarcarga.tipo = myreader2.GetValue(2)
                    Try
                        If (contador = 2) Then
                            auxdatosarbitros(nroarbitro).saldo = saldoanterior
                        Else
                            saldoanterior = auxdatosarbitros(nroarbitro).saldo
                        End If
                        If (String.Compare(Trim(auxiliarcarga.tipo), "B") = 0) Then

                            auxiliarcarga.bono = myreader2.GetValue(0)
                            auxiliarcarga.descuento = 0
                            auxdatosarbitros(nroarbitro).saldo = auxdatosarbitros(nroarbitro).saldo + auxiliarcarga.bono

                        Else
                            auxiliarcarga.descuento = myreader2.GetValue(0)
                            auxiliarcarga.bono = 0
                            auxdatosarbitros(nroarbitro).saldo = auxdatosarbitros(nroarbitro).saldo - auxiliarcarga.descuento

                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "error 001", MessageBoxButtons.OK)
                    End Try
                    Try
                        Dim convertidor As New NumLetras
                        saldoenLETRAS = convertidor.Convierte(auxdatosarbitros(nroarbitro).saldo.ToString, Tipo.Pronombre)
                        If (auxdatosarbitros(nroarbitro).saldo <= 0) Then
                            saldoenLETRAS = "cero"
                        End If
                        auxdatosarbitros(nroarbitro).saldoLETRAS = saldoenLETRAS
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "error 002", MessageBoxButtons.OK)
                    End Try

                    auxiliarcarga.fecha = myreader2.GetValue(1)
                    Try
                        auxiliarcarga.equipo1 = myreader2.GetValue(3)
                    Catch ex As Exception
                        auxiliarcarga.equipo1 = ""
                    End Try
                    Try
                        auxiliarcarga.equipo2 = myreader2.GetValue(4)
                    Catch ex As Exception
                        auxiliarcarga.equipo2 = ""
                    End Try
                    Try
                        auxiliarcarga.estadio = myreader2.GetValue(5)
                    Catch ex As Exception
                        auxiliarcarga.estadio = ""
                    End Try
                    Try
                        auxiliarcarga.nrocuota = myreader2.GetValue(6)
                    Catch ex As Exception
                        auxiliarcarga.nrocuota = 0
                    End Try
                    Try
                        auxiliarcarga.fechapartida = myreader2.GetValue(7)
                    Catch ex As Exception
                        auxiliarcarga.fechapartida = 0
                    End Try
                    Try
                        auxiliarcarga.codigoconcepto = myreader2.GetValue(8)
                    Catch ex As Exception
                        auxiliarcarga.codigoconcepto = 0
                    End Try
                    Try
                        auxiliarcarga.observaciones = myreader2.GetValue(10)
                    Catch ex As Exception
                        auxiliarcarga.observaciones = ""
                    End Try


                    'OBTENER LA DESCRIPCION BREVE DEL CONCEPTO
                    Try
                        auxiliarcarga.descripcionconcepto = auxiliarconceptosbreves(auxiliarcarga.codigoconcepto).nombre & "." & auxiliarcarga.observaciones
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "error 002", MessageBoxButtons.OK)
                    End Try
                    'FIN


                    If (String.Compare(auxiliarcarga.equipo1, "") <> 0 Or String.Compare(auxiliarcarga.equipo2, "") <> 0) Then

                        Try
                            auxiliarcarga.equipo1 = auxiliarequipos(auxiliarcarga.equipo1).nombre

                        Catch ex As Exception
                            auxiliarcarga.equipo1 = ""
                        End Try

                        Try

                            auxiliarcarga.equipo2 = auxiliarequipos(auxiliarcarga.equipo2).nombre

                        Catch ex As Exception
                            auxiliarcarga.equipo2 = ""
                        End Try

                        Try

                            auxiliarcarga.estadio = auxiliarestadio(auxiliarcarga.estadio).nombre

                        Catch ex As Exception
                            auxiliarcarga.estadio = ""
                        End Try

                        auxiliarcarga.descripcionconcepto = auxiliarcarga.descripcionconcepto & "." & auxiliarcarga.equipo1 & " vs " & _
                        auxiliarcarga.equipo2 & " .Estadio: " & auxiliarcarga.estadio & ". En fecha: " & auxiliarcarga.fechapartida

                    End If


                    Try
                        If (Not IsNothing(auxdatosarbitros(nroarbitro))) Then
                            auxiliarcarga.fechainicio = Me.dtpFECHAINICIO.Value.Date.ToString("dd/MM/yyyy")
                            auxiliarcarga.fechafin = Me.dtpFECHAFIN.Value.Date.ToString("dd/MM/yyyy")
                            ca_cn3.Open()
                            strSQL = "insert into auxRECIBOLIQUIDACION (codigo,descripcion,fecha,bono,descuento,saldo,cuota,equipo1,equipo2,estadio,fechapartida,arbcedula,arbnombre,arbpromocion,arbcategoriastring,fechainicio,fechafin,ncopia,saldoletras,cardinal) " & _
                            " values ( " & auxiliarcarga.codigoconcepto & ",'" & auxiliarcarga.descripcionconcepto & "','" & auxiliarcarga.fecha.ToString("yyyy-MM-dd") & "'," & auxiliarcarga.bono & "," & _
                            auxiliarcarga.descuento & "," & auxdatosarbitros(nroarbitro).saldo & "," & auxiliarcarga.nrocuota & ",'" & auxiliarcarga.equipo1 & "','" & auxiliarcarga.equipo2 & "','" & auxiliarcarga.estadio & _
                            "'," & auxiliarcarga.fechapartida & "," & auxdatosarbitros(nroarbitro).arbcedula & ",'" & auxdatosarbitros(nroarbitro).arbnombre & "'," & auxdatosarbitros(nroarbitro).arbpromocion & ",'" & auxiliarcarga.arbcategoriastring & "','" & _
                            auxiliarcarga.fechainicio & "','" & auxiliarcarga.fechafin & "','" & auxdatosarbitros(nroarbitro).arbcedula & contador & "','" & auxdatosarbitros(nroarbitro).saldoLETRAS & "'," & cardinal & ")"
                            mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
                            mycommand3.ExecuteNonQuery()

                            ca_cn3.Close()
                        End If

                        If (Trim(auxiliarcarga.tipo) = "B") Then
                            'calcularmantenimientocapital(auxiliarcarga, auxdatosarbitros(nroarbitro).arbcedula & contador, auxdatosarbitros(nroarbitro), cardinal)
                        End If

                        'auxsaldoenNUMERO = auxiliardatos.saldo
                        'Dim convertidor As New NumLetras
                        'saldoenLETRAS = convertidor.Convierte(auxsaldoenNUMERO.ToString, Tipo.Pronombre)
                        'If (auxsaldoenNUMERO <= 0) Then
                        '    saldoenLETRAS = "cero"
                        'End If

                    Catch ex As Exception
                        MessageBox.Show(ex.StackTrace, "error", MessageBoxButtons.OK)
                    End Try

                    contador = contador + 1
                Loop
            End While

        Catch ex As Exception
            MessageBox.Show(ex.message, "error2", MessageBoxButtons.OK)
        End Try




        '    strSQL = "update auxRECIBOLIQUIDACION set saldoletras='" & saldoenLETRAS & "' " & _
        '    " where ncopia='" & auxiliardatos.arbcedula & contador & "'"
        '    'ca_cn3 = New Odbc.OdbcConnection(strCADENA)
        '    'ca_cn3.ConnectionTimeout = 0
        '    ca_cn3.Open()

        '    mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)

        '    mycommand3.ExecuteNonQuery()

        '    ca_cn3.Close()

        '    contador = contador + 1
        '    auxiliardatos.saldo = 0
        'Loop
        'ca_cn2.Close()


        'End While


        'CerrarConexion()
        ''ca_cn3.Close()
        'ca_cn2.Close()
        Me.crpREPORTE.ReportSource = reporte

    End Sub

    Private Sub calcularmantenimientocapital(ByRef auxiliardatos As tipocampoRECIBOLIQUIDACION, ByVal ncopia As String, ByRef datoarbitro As datosarbitros, ByRef cardinal As Double)

        Try
            Dim mycommand2 As Odbc.OdbcCommand
            Dim myreader2 As Odbc.OdbcDataReader

            Dim ca_cn2 As Odbc.OdbcConnection
            Dim ca_cn3 As New Odbc.OdbcConnection

            Dim mycommand3 As Odbc.OdbcCommand
            Dim myreader3 As Odbc.OdbcDataReader

            Dim auxiliarmontoinicial As Integer
            Dim auxiliarmontofinal As Integer
            Dim auxiliarmontoasignado As Integer
            Dim codigomantenimientocapital As Integer
            Dim auxsaldoletras As Double = 0

            strSQL = "SELECT mancodigo,manmontoinicial,manmontofinal,manmontoasignado from mantenimientocapital"
            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.Open()

            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

            While (myreader2.Read())

                auxiliarmontoinicial = myreader2.GetValue(1)
                auxiliarmontofinal = myreader2.GetValue(2)
                auxiliarmontoasignado = myreader2.GetValue(3)
                auxsaldoletras = 0
                If (auxiliardatos.bono >= auxiliarmontoinicial And auxiliardatos.bono <= auxiliarmontofinal) Then

                    auxiliardatos.descripcionconcepto = "Mantenimiento de capital"
                    auxiliardatos.bono = 0
                    auxiliardatos.descuento = auxiliarmontoasignado
                    datoarbitro.saldo = datoarbitro.saldo - auxiliarmontoasignado
                    If (datoarbitro.saldo = 0) Then
                        datoarbitro.saldoLETRAS = "cero"
                    Else
                        datoarbitro.saldoLETRAS = claseNUMEROALETRA.NumLetras.Convierte(datoarbitro.saldo.ToString, Tipo.Pronombre)
                    End If

                    Exit While

                End If

            End While

            ca_cn2.Close()


            strSQL = "SELECT concodigo from concepto where connombre ilike '%Mantenimiento de capital%'"
            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.Open()

            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)
            myreader2.Read()
            codigomantenimientocapital = myreader2.GetValue(0)
            ca_cn2.Close()
            cardinal = cardinal + 1
            strSQL = "INSERT INTO auxreciboliquidacion (codigo,descripcion,fecha,descuento,saldo,arbcedula,arbnombre,arbpromocion,arbcategoriastring,ncopia,cardinal,saldoletras) VALUES " & _
            "(" & codigomantenimientocapital & ",'" & auxiliardatos.descripcionconcepto & "','" & auxiliardatos.fecha & "'," & auxiliardatos.descuento & "," & datoarbitro.saldo & _
            "," & datoarbitro.arbcedula & ",'" & datoarbitro.arbnombre & "'," & datoarbitro.arbpromocion & ",'" & auxiliardatos.arbcategoriastring & "'," & ncopia & "," & cardinal & ",'" & datoarbitro.saldoLETRAS & "')"
            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.Open()

            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            mycommand2.ExecuteNonQuery()


            ca_cn2.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en calculomantenimientocapital", MessageBoxButtons.OK)
        End Try



    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
    End Sub

    Private Sub lblCEDULA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCEDULA.Click

    End Sub

    Private Sub frmEMISIONRECIBO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AbrirConexion()
        cargarGrillaBUSQUEDA()
        setEstiloGrillaBUSQUEDA()
        CerrarConexion()
        Me.timerBUSQUEDA.Start()
        Me.timerBUSQUEDA.Interval = 500

    End Sub

    Private Sub cargarGrillaBUSQUEDA()

        Dim dataviewLOCAL As DataView
        dsDATOS = New DataSet
        strSQL = "SELECT arbcedula,arbnombre FROM arbitro where arbnombre ilike '%" & Me.txtBUSQUEDA.Text & "%'"

        Dim adDATOS As New Odbc.OdbcDataAdapter
        adDATOS.SelectCommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        adDATOS.Fill(dsDATOS, "arbitro")

        dataviewLOCAL = New DataView(dsDATOS.Tables("arbitro"), "", "arbnombre ASC", DataViewRowState.OriginalRows)
        Me.dtaBUSQUEDA.DataSource = dataviewLOCAL
        Me.dtaBUSQUEDA.CaptionText = "Cantidad Registros: " + dataviewLOCAL.Count.ToString

    End Sub

    Private Sub setEstiloGrillaBUSQUEDA()
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
            .HeaderText = "Número de Cédula"
            .Width = 110
        End With


        With estilo2
            .MappingName = "arbnombre"
            .HeaderText = "Nombre y apellido"
            .Width = 420

        End With




        estilos.GridColumnStyles.Clear()
        estilos.GridColumnStyles.Add(estilo1)
        estilos.GridColumnStyles.Add(estilo2)


        Me.dtaBUSQUEDA.TableStyles.Clear()
        Me.dtaBUSQUEDA.TableStyles.Add(estilos)
    End Sub


    Private Sub timerBUSQUEDA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBUSQUEDA.Tick
        If (actualizardatagridbusqueda = True) Then

            AbrirConexion()
            cargarGrillaBUSQUEDA()
            setEstiloGrillaBUSQUEDA()
            CerrarConexion()
            actualizardatagridbusqueda = False

        End If
    End Sub

    Private Sub dtaBUSQUEDA_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dtaBUSQUEDA.Navigate

    End Sub

    Private Sub dtaBUSQUEDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaBUSQUEDA.Click
        Dim indiceactual As Integer
        indiceactual = Me.dtaBUSQUEDA.CurrentRowIndex
        Me.txtCEDULA.Text = Me.dtaBUSQUEDA.Item(indiceactual, 0)

    End Sub

    Private Sub txtBUSQUEDA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSQUEDA.TextChanged
        actualizardatagridbusqueda = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblFECHAINICIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFECHAINICIO.Click

    End Sub
End Class

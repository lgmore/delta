Imports CrystalDecisions.Shared
Public Class frmPAGOAARBITROS
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
    Friend WithEvents grpCONTROLES As System.Windows.Forms.GroupBox
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFINAL As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblNUMERORECIBO As System.Windows.Forms.Label
    Friend WithEvents txtNRORECIBO As System.Windows.Forms.TextBox
    Friend WithEvents dtpFECHAPLANILLA As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAPLANILLA As System.Windows.Forms.Label
    Friend WithEvents txtTORNEO As System.Windows.Forms.TextBox
    Friend WithEvents lblTORNEO As System.Windows.Forms.Label
    Friend WithEvents txtFECHAPROGRAMACION As System.Windows.Forms.TextBox
    Friend WithEvents lblFECHAPROGRAMACIÓN As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpCONTROLES = New System.Windows.Forms.GroupBox
        Me.txtNRORECIBO = New System.Windows.Forms.TextBox
        Me.lblNUMERORECIBO = New System.Windows.Forms.Label
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker
        Me.dtpFECHAINICIO = New System.Windows.Forms.DateTimePicker
        Me.lblFECHAFINAL = New System.Windows.Forms.Label
        Me.lblFECHAINICIO = New System.Windows.Forms.Label
        Me.lblTITULO = New System.Windows.Forms.Label
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtpFECHAPLANILLA = New System.Windows.Forms.DateTimePicker
        Me.lblFECHAPLANILLA = New System.Windows.Forms.Label
        Me.txtTORNEO = New System.Windows.Forms.TextBox
        Me.lblTORNEO = New System.Windows.Forms.Label
        Me.txtFECHAPROGRAMACION = New System.Windows.Forms.TextBox
        Me.lblFECHAPROGRAMACIÓN = New System.Windows.Forms.Label
        Me.grpCONTROLES.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCONTROLES
        '
        Me.grpCONTROLES.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grpCONTROLES.Controls.Add(Me.txtFECHAPROGRAMACION)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAPROGRAMACIÓN)
        Me.grpCONTROLES.Controls.Add(Me.txtTORNEO)
        Me.grpCONTROLES.Controls.Add(Me.lblTORNEO)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAPLANILLA)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAPLANILLA)
        Me.grpCONTROLES.Controls.Add(Me.txtNRORECIBO)
        Me.grpCONTROLES.Controls.Add(Me.lblNUMERORECIBO)
        Me.grpCONTROLES.Controls.Add(Me.btnSALIR)
        Me.grpCONTROLES.Controls.Add(Me.btnGENERARREPORTE)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAFIN)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAINICIO)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAFINAL)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAINICIO)
        Me.grpCONTROLES.Location = New System.Drawing.Point(8, 40)
        Me.grpCONTROLES.Name = "grpCONTROLES"
        Me.grpCONTROLES.Size = New System.Drawing.Size(1000, 120)
        Me.grpCONTROLES.TabIndex = 6
        Me.grpCONTROLES.TabStop = False
        '
        'txtNRORECIBO
        '
        Me.txtNRORECIBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRORECIBO.Location = New System.Drawing.Point(200, 88)
        Me.txtNRORECIBO.Name = "txtNRORECIBO"
        Me.txtNRORECIBO.Size = New System.Drawing.Size(200, 22)
        Me.txtNRORECIBO.TabIndex = 2
        Me.txtNRORECIBO.Text = ""
        '
        'lblNUMERORECIBO
        '
        Me.lblNUMERORECIBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMERORECIBO.Location = New System.Drawing.Point(24, 88)
        Me.lblNUMERORECIBO.Name = "lblNUMERORECIBO"
        Me.lblNUMERORECIBO.Size = New System.Drawing.Size(168, 24)
        Me.lblNUMERORECIBO.TabIndex = 9
        Me.lblNUMERORECIBO.Text = "Número de Factura:"
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(912, 64)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(80, 32)
        Me.btnSALIR.TabIndex = 4
        Me.btnSALIR.Text = "Salir"
        '
        'btnGENERARREPORTE
        '
        Me.btnGENERARREPORTE.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGENERARREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGENERARREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(912, 16)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 3
        Me.btnGENERARREPORTE.Text = "Imprimir"
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(200, 56)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.TabIndex = 1
        '
        'dtpFECHAINICIO
        '
        Me.dtpFECHAINICIO.Location = New System.Drawing.Point(200, 24)
        Me.dtpFECHAINICIO.Name = "dtpFECHAINICIO"
        Me.dtpFECHAINICIO.TabIndex = 0
        '
        'lblFECHAFINAL
        '
        Me.lblFECHAFINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAFINAL.Location = New System.Drawing.Point(24, 56)
        Me.lblFECHAFINAL.Name = "lblFECHAFINAL"
        Me.lblFECHAFINAL.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAFINAL.TabIndex = 1
        Me.lblFECHAFINAL.Text = "Fecha final:"
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(24, 24)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha de inicio:"
        '
        'lblTITULO
        '
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(16, 8)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(984, 23)
        Me.lblTITULO.TabIndex = 5
        Me.lblTITULO.Text = "PLANILLA DE PAGO A ÁRBITROS"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.Location = New System.Drawing.Point(8, 168)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.ReportSource = Nothing
        Me.crpREPORTE.Size = New System.Drawing.Size(1000, 504)
        Me.crpREPORTE.TabIndex = 7
        '
        'dtpFECHAPLANILLA
        '
        Me.dtpFECHAPLANILLA.Location = New System.Drawing.Point(600, 24)
        Me.dtpFECHAPLANILLA.Name = "dtpFECHAPLANILLA"
        Me.dtpFECHAPLANILLA.TabIndex = 11
        '
        'lblFECHAPLANILLA
        '
        Me.lblFECHAPLANILLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAPLANILLA.Location = New System.Drawing.Point(424, 24)
        Me.lblFECHAPLANILLA.Name = "lblFECHAPLANILLA"
        Me.lblFECHAPLANILLA.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAPLANILLA.TabIndex = 10
        Me.lblFECHAPLANILLA.Text = "Fecha de planilla:"
        '
        'txtTORNEO
        '
        Me.txtTORNEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTORNEO.Location = New System.Drawing.Point(600, 56)
        Me.txtTORNEO.Name = "txtTORNEO"
        Me.txtTORNEO.Size = New System.Drawing.Size(200, 22)
        Me.txtTORNEO.TabIndex = 12
        Me.txtTORNEO.Text = ""
        '
        'lblTORNEO
        '
        Me.lblTORNEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTORNEO.Location = New System.Drawing.Point(424, 56)
        Me.lblTORNEO.Name = "lblTORNEO"
        Me.lblTORNEO.Size = New System.Drawing.Size(168, 24)
        Me.lblTORNEO.TabIndex = 13
        Me.lblTORNEO.Text = "Torneo :"
        '
        'txtFECHAPROGRAMACION
        '
        Me.txtFECHAPROGRAMACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFECHAPROGRAMACION.Location = New System.Drawing.Point(600, 88)
        Me.txtFECHAPROGRAMACION.Name = "txtFECHAPROGRAMACION"
        Me.txtFECHAPROGRAMACION.Size = New System.Drawing.Size(200, 22)
        Me.txtFECHAPROGRAMACION.TabIndex = 14
        Me.txtFECHAPROGRAMACION.Text = ""
        '
        'lblFECHAPROGRAMACIÓN
        '
        Me.lblFECHAPROGRAMACIÓN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAPROGRAMACIÓN.Location = New System.Drawing.Point(424, 88)
        Me.lblFECHAPROGRAMACIÓN.Name = "lblFECHAPROGRAMACIÓN"
        Me.lblFECHAPROGRAMACIÓN.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAPROGRAMACIÓN.TabIndex = 15
        Me.lblFECHAPROGRAMACIÓN.Text = "Fecha programación:"
        '
        'frmPAGOAARBITROS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 686)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.grpCONTROLES)
        Me.Controls.Add(Me.lblTITULO)
        Me.Name = "frmPAGOAARBITROS"
        Me.Text = "formulario de pago a árbitros - Sistema Delta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCONTROLES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Class datosarbitros
        Public arbcedula As Integer
        Public arbnombre As String
        'Public arbcategoria As Integer

        Public apercibir As Double

    End Class

    Private Sub btnGENERARREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERARREPORTE.Click


        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader

        Dim ca_cn2 As Odbc.OdbcConnection
        Dim mycommand2 As Odbc.OdbcCommand
        Dim myreader2 As Odbc.OdbcDataReader


        Dim ca_cn3 As Odbc.OdbcConnection
        Dim mycommand3 As Odbc.OdbcCommand
        Dim myreader3 As Odbc.OdbcDataReader

        Dim auxcedulamax As Integer

        Dim arbcedula As Integer
        Dim arbnombre As String
        Dim apercibir As Double


        ''BUSCAR LA CEDULA MAXIMA DE LOS ARBITROS PARA DIMENSIONAR EL ARRAY
        strSQL = "SELECT MAX(arbcedula) FROM arbitro"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        auxcedulamax = myreader.GetValue(0) + 1
        Dim auxdatosarbitros(auxcedulamax) As datosarbitros
        'FIN BUSCAR LA CEDULA MAXIMA

        Try

            strSQL = "select arbcedula,arbnombre from arbitro order by arbnombre asc"
            AbrirConexion()
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

            While (myreader.Read())

                arbcedula = myreader.GetValue(0)
                auxdatosarbitros(arbcedula) = New datosarbitros
                auxdatosarbitros(arbcedula).arbcedula = arbcedula
                auxdatosarbitros(arbcedula).arbnombre = myreader.GetValue(1)

            End While
            CerrarConexion()

        Catch ex As Exception

        End Try



        Try
            strSQL = "truncate table auxpagoarbitros"
            AbrirConexion()
            mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
            mycommand.ExecuteNonQuery()
            CerrarConexion()


            strSQL = "select movcedula,movmonto from movmensual where  movtipo='B'" & _
            "and (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & _
            "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "') "

            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.Open()

            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

            While (myreader2.Read())
                Try
                    arbcedula = myreader2.GetValue(0)
                    apercibir = myreader2.GetValue(1)
                    auxdatosarbitros(arbcedula).apercibir = auxdatosarbitros(arbcedula).apercibir + apercibir
                Catch ex As Exception
                    apercibir = 0
                End Try

            End While
            ca_cn2.Close()

            Dim x As Integer
            For x = 1 To auxcedulamax

                If (Not IsNothing(auxdatosarbitros(x))) Then

                    strSQL = "INSERT INTO auxpagoarbitros (nombre,cedula,apercibir) VALUES ('" & _
                    auxdatosarbitros(x).arbnombre & "'," & auxdatosarbitros(x).arbcedula & "," & auxdatosarbitros(x).apercibir & ")"
                    AbrirConexion()
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    CerrarConexion()

                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Generación de reporte", MessageBoxButtons.OK)
        End Try


        Dim reporte As New crpPAGOARBITROS


        ' objeto para contener una colección de valores de parámetros
        Dim pvValoresParametros As New ParameterValues
        ' objeto para almacenar un valor de un parámetro
        Dim parinicial As New ParameterDiscreteValue
        Dim parfinal As New ParameterDiscreteValue
        Dim nrorecibo As New ParameterDiscreteValue
        Dim fechaplanilla As New ParameterDiscreteValue
        Dim torneo As New ParameterDiscreteValue
        Dim fechaprogramacion As New ParameterDiscreteValue


        ' asignar el valor al parámetro
        parinicial.Value = Me.dtpFECHAINICIO.Value.Date.ToString("dd/MM/yyyy")
        parfinal.Value = Me.dtpFECHAFIN.Value.Date.ToString("dd/MM/yyyy")
        nrorecibo.Value = Me.txtNRORECIBO.Text

        fechaplanilla.Value = Me.dtpFECHAPLANILLA.Value.Date.ToString("dd/MM/yyyy")
        torneo.Value = Me.txtTORNEO.Text
        fechaprogramacion.Value = Me.txtFECHAPROGRAMACION.Text
        ' añadir el parámetro a la colección de parámetros
        pvValoresParametros.Clear()
        pvValoresParametros.Add(parinicial)
        reporte.DataDefinition.ParameterFields("fechaini").ApplyCurrentValues(pvValoresParametros)


        pvValoresParametros.Clear()
        pvValoresParametros.Add(parfinal)
        reporte.DataDefinition.ParameterFields("fechafin").ApplyCurrentValues(pvValoresParametros)

        pvValoresParametros.Clear()
        pvValoresParametros.Add(nrorecibo)
        reporte.DataDefinition.ParameterFields("nrorecibo").ApplyCurrentValues(pvValoresParametros)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        pvValoresParametros.Clear()
        pvValoresParametros.Add(fechaplanilla)
        reporte.DataDefinition.ParameterFields("fechaplanilla").ApplyCurrentValues(pvValoresParametros)


        pvValoresParametros.Clear()
        pvValoresParametros.Add(torneo)
        reporte.DataDefinition.ParameterFields("torneo").ApplyCurrentValues(pvValoresParametros)

        pvValoresParametros.Clear()
        pvValoresParametros.Add(fechaprogramacion)
        reporte.DataDefinition.ParameterFields("programacion").ApplyCurrentValues(pvValoresParametros)

        Me.crpREPORTE.ReportSource = reporte


    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
    End Sub

    Private Sub lblTITULO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTITULO.Click

    End Sub

    Private Sub txtNRORECIBO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNRORECIBO.TextChanged

    End Sub

    Private Sub txtNRORECIBO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNRORECIBO.KeyPress
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
            Me.txtNRORECIBO.Text = ""
        ElseIf (InStr(".", e.KeyChar)) Then 'ES VÁLIDO INGRESAR .
            e.Handled = False

        Else
            e.Handled = True 'OTROS CARACTERES SE CONSIDERAN NO VÁLIDOS
        End If
    End Sub

    Private Sub crpREPORTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crpREPORTE.Load

    End Sub
End Class

Imports CrystalDecisions.Shared
Public Class frmSOCIOSPROMOCION
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
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents grpCONTROLES As System.Windows.Forms.GroupBox
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents intANHOPROMOCION As System.Windows.Forms.TextBox
    Friend WithEvents lblANHOPROMOCION As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTITULO = New System.Windows.Forms.Label
        Me.intANHOPROMOCION = New System.Windows.Forms.TextBox
        Me.lblANHOPROMOCION = New System.Windows.Forms.Label
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button
        Me.grpCONTROLES = New System.Windows.Forms.GroupBox
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.grpCONTROLES.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTITULO
        '
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(16, 8)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(896, 23)
        Me.lblTITULO.TabIndex = 6
        Me.lblTITULO.Text = "LISTADO DE SOCIOS POR PROMOCIÓN"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intANHOPROMOCION
        '
        Me.intANHOPROMOCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intANHOPROMOCION.Location = New System.Drawing.Point(384, 24)
        Me.intANHOPROMOCION.Name = "intANHOPROMOCION"
        Me.intANHOPROMOCION.Size = New System.Drawing.Size(200, 22)
        Me.intANHOPROMOCION.TabIndex = 2
        Me.intANHOPROMOCION.Text = ""
        '
        'lblANHOPROMOCION
        '
        Me.lblANHOPROMOCION.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblANHOPROMOCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANHOPROMOCION.Location = New System.Drawing.Point(208, 24)
        Me.lblANHOPROMOCION.Name = "lblANHOPROMOCION"
        Me.lblANHOPROMOCION.Size = New System.Drawing.Size(168, 24)
        Me.lblANHOPROMOCION.TabIndex = 9
        Me.lblANHOPROMOCION.Text = "Año de promoción:"
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(896, 16)
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
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(808, 16)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 3
        Me.btnGENERARREPORTE.Text = "Imprimir"
        '
        'grpCONTROLES
        '
        Me.grpCONTROLES.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grpCONTROLES.Controls.Add(Me.intANHOPROMOCION)
        Me.grpCONTROLES.Controls.Add(Me.lblANHOPROMOCION)
        Me.grpCONTROLES.Controls.Add(Me.btnSALIR)
        Me.grpCONTROLES.Controls.Add(Me.btnGENERARREPORTE)
        Me.grpCONTROLES.Location = New System.Drawing.Point(8, 40)
        Me.grpCONTROLES.Name = "grpCONTROLES"
        Me.grpCONTROLES.Size = New System.Drawing.Size(984, 64)
        Me.grpCONTROLES.TabIndex = 7
        Me.grpCONTROLES.TabStop = False
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.Location = New System.Drawing.Point(8, 112)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.ReportSource = Nothing
        Me.crpREPORTE.Size = New System.Drawing.Size(984, 576)
        Me.crpREPORTE.TabIndex = 8
        '
        'frmSOCIOSPROMOCION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 746)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.grpCONTROLES)
        Me.Controls.Add(Me.lblTITULO)
        Me.Name = "frmSOCIOSPROMOCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSOCIOSPROMOCION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCONTROLES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Class datosarbitros
        Public arbcedula As Integer
        Public arbnombre As String
        'Public arbcategoria As Integer

    End Class

    Private Sub lblTITULO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTITULO.Click

    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btnGENERARREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERARREPORTE.Click

        Dim mycommand As Odbc.OdbcCommand
        Dim myreader As Odbc.OdbcDataReader
        Dim arbcedula As Integer
        Dim auxcedulamax As Integer
        Dim aux As Integer


        strSQL = "SELECT MAX(arbcedula) FROM arbitro"

        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
        myreader.Read()
        auxcedulamax = myreader.GetValue(0) + 1
        Dim auxdatosarbitros(auxcedulamax) As datosarbitros

        strSQL = "truncate table auxsociopromocion"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()

        Try




            Try
                aux = Integer.Parse(Me.intANHOPROMOCION.Text)
            Catch ex As Exception
                aux = 0
            End Try
            If (aux > 0) Then

                strSQL = "SELECT arbcedula,arbnombre,arbcategoria,arbpromocion from arbitro where arbpromocion= " & aux & " order by arbnombre asc"

            Else
                strSQL = "SELECT arbcedula,arbnombre,arbcategoria,arbpromocion from arbitro order by arbnombre asc"

            End If
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

            Dim x As Integer
            For x = 1 To auxcedulamax

                If (Not IsNothing(auxdatosarbitros(x))) Then

                    strSQL = "INSERT INTO auxsociopromocion (nombre,cedula) VALUES ('" & _
                    auxdatosarbitros(x).arbnombre & "'," & auxdatosarbitros(x).arbcedula & ")"
                    AbrirConexion()
                    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    mycommand.ExecuteNonQuery()
                    CerrarConexion()

                End If

            Next

        Catch ex As Exception
        End Try

        Dim reporte As New crpARBITROSPROMOCION


        ' objeto para contener una colección de valores de parámetros
        Dim pvValoresParametros As New ParameterValues
        Dim anhopromocion As New ParameterDiscreteValue

        anhopromocion.Value = aux

        pvValoresParametros.Clear()
        pvValoresParametros.Add(anhopromocion)
        reporte.DataDefinition.ParameterFields("anhopromocion").ApplyCurrentValues(pvValoresParametros)

        Me.crpREPORTE.ReportSource = reporte



    End Sub
End Class

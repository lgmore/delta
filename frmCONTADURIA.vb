Public Class frmCONTADURIA
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
    Friend WithEvents crpREPORTE As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grpCONTROLES As System.Windows.Forms.GroupBox
    Friend WithEvents btnSALIR As System.Windows.Forms.Button
    Friend WithEvents btnGENERARREPORTE As System.Windows.Forms.Button
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFINAL As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents lblTITULO As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crpREPORTE = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.grpCONTROLES = New System.Windows.Forms.GroupBox
        Me.btnSALIR = New System.Windows.Forms.Button
        Me.btnGENERARREPORTE = New System.Windows.Forms.Button
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker
        Me.dtpFECHAINICIO = New System.Windows.Forms.DateTimePicker
        Me.lblFECHAFINAL = New System.Windows.Forms.Label
        Me.lblFECHAINICIO = New System.Windows.Forms.Label
        Me.lblTITULO = New System.Windows.Forms.Label
        Me.grpCONTROLES.SuspendLayout()
        Me.SuspendLayout()
        '
        'crpREPORTE
        '
        Me.crpREPORTE.ActiveViewIndex = -1
        Me.crpREPORTE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.crpREPORTE.Location = New System.Drawing.Point(144, 168)
        Me.crpREPORTE.Name = "crpREPORTE"
        Me.crpREPORTE.ReportSource = Nothing
        Me.crpREPORTE.Size = New System.Drawing.Size(720, 496)
        Me.crpREPORTE.TabIndex = 5
        '
        'grpCONTROLES
        '
        Me.grpCONTROLES.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grpCONTROLES.Controls.Add(Me.btnSALIR)
        Me.grpCONTROLES.Controls.Add(Me.btnGENERARREPORTE)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAFIN)
        Me.grpCONTROLES.Controls.Add(Me.dtpFECHAINICIO)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAFINAL)
        Me.grpCONTROLES.Controls.Add(Me.lblFECHAINICIO)
        Me.grpCONTROLES.Location = New System.Drawing.Point(148, 40)
        Me.grpCONTROLES.Name = "grpCONTROLES"
        Me.grpCONTROLES.Size = New System.Drawing.Size(720, 125)
        Me.grpCONTROLES.TabIndex = 4
        Me.grpCONTROLES.TabStop = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(480, 80)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(75, 32)
        Me.btnSALIR.TabIndex = 8
        Me.btnSALIR.Text = "Salir"
        '
        'btnGENERARREPORTE
        '
        Me.btnGENERARREPORTE.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGENERARREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGENERARREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGENERARREPORTE.Location = New System.Drawing.Point(480, 24)
        Me.btnGENERARREPORTE.Name = "btnGENERARREPORTE"
        Me.btnGENERARREPORTE.Size = New System.Drawing.Size(80, 32)
        Me.btnGENERARREPORTE.TabIndex = 7
        Me.btnGENERARREPORTE.Text = "Imprimir"
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(200, 80)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.TabIndex = 4
        '
        'dtpFECHAINICIO
        '
        Me.dtpFECHAINICIO.Location = New System.Drawing.Point(200, 32)
        Me.dtpFECHAINICIO.Name = "dtpFECHAINICIO"
        Me.dtpFECHAINICIO.TabIndex = 3
        '
        'lblFECHAFINAL
        '
        Me.lblFECHAFINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAFINAL.Location = New System.Drawing.Point(24, 80)
        Me.lblFECHAFINAL.Name = "lblFECHAFINAL"
        Me.lblFECHAFINAL.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAFINAL.TabIndex = 1
        Me.lblFECHAFINAL.Text = "Fecha final:"
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(24, 32)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(168, 24)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha de inicio:"
        '
        'lblTITULO
        '
        Me.lblTITULO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITULO.Location = New System.Drawing.Point(148, 8)
        Me.lblTITULO.Name = "lblTITULO"
        Me.lblTITULO.Size = New System.Drawing.Size(720, 23)
        Me.lblTITULO.TabIndex = 3
        Me.lblTITULO.Text = "INFORME PARA CONTADURIA"
        Me.lblTITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCONTADURIA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.crpREPORTE)
        Me.Controls.Add(Me.grpCONTROLES)
        Me.Controls.Add(Me.lblTITULO)
        Me.Name = "frmCONTADURIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe para contaduria - Sistema Delta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCONTROLES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Class auxcodigonombre
        Public indice As Integer
        Public codigo As Integer
        Public nombre As String
    End Class
    Class auxmontosinformecontaduria
        Public nombre As String
        Public apercibir As Double
        Public montotitulo(9) As Double
        Public montootros As Double
        Public montototal As Double
        Public cedula As Integer
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

        Dim ca_cn4 As Odbc.OdbcConnection
        Dim mycommand4 As Odbc.OdbcCommand


        Dim arbnombre As String
        Dim arbcedula As String

        Dim titulo1monto As Integer = 0
        Dim titulo2monto As Integer = 0
        Dim titulo3monto As Integer = 0
        Dim titulo4monto As Integer = 0
        Dim titulo5monto As Integer = 0
        Dim titulo6monto As Integer = 0
        Dim titulo7monto As Integer = 0
        Dim titulo8monto As Integer = 0
        Dim otromonto As Integer = 0
        Dim totalmonto As Integer = 0
        Dim arraycargados(9) As Integer

        Dim auxmontoconcepto As Integer = 0


        strSQL = "truncate table auxtitulosinformecontaduria"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()


        strSQL = "truncate table auxmontosinformecontaduria"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        mycommand.ExecuteNonQuery()
        CerrarConexion()

        strSQL = "select concodigo,connombre from concepto where contipo = 'D' order by concodigo asc"
        AbrirConexion()
        mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

        Dim auxcodigoconcepto As Integer
        Dim auxnombreconcepto As String
        Dim auxtipoconcepto As String
        Dim contador As Integer = 1
        Dim auxmantenimientocapital As Integer

        Dim arrayauxiliar(9) As auxcodigonombre

        strSQL = "insert into auxtitulosinformecontaduria (titulo1,titulo1cod,fechainicio,fechafin) values ('',0,'" & Me.dtpFECHAINICIO.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpFECHAFIN.Value.ToString("dd/MM/yyyy") & "')"
        ca_cn2 = New Odbc.OdbcConnection(strCADENA)
        ca_cn2.Open()

        mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
        mycommand2.ExecuteNonQuery()

        ca_cn2.Close()

        While (myreader.Read() And contador <= 8)
            Try
                arrayauxiliar(contador) = New auxcodigonombre
                arrayauxiliar(contador).indice = contador
                arrayauxiliar(contador).codigo = myreader.GetValue(0)
                arrayauxiliar(contador).nombre = myreader.GetValue(1)
            Catch ex As Exception
                arrayauxiliar(contador) = New auxcodigonombre
                arrayauxiliar(contador).indice = 0
                arrayauxiliar(contador).codigo = 0
                arrayauxiliar(contador).nombre = ""
            End Try

            If (String.Compare(Trim(UCase(arrayauxiliar(contador).nombre)), UCase("mantenimiento de capital")) = 0) Then

                auxmantenimientocapital = contador
                'PARA SABER EN QUÉ COLUMNA ESTÁ EL MANTENIMIENTO DE CAPITAL  
            End If
            contador = contador + 1
        End While

        'en una sola consulta se guardan todos los títulos
        strSQL = "update auxtitulosinformecontaduria set " & _
                                                    "titulo1='" & arrayauxiliar(1).nombre & "'," & _
                                                    "titulo1cod=" & arrayauxiliar(1).codigo & "," & _
                                                    "titulo2='" & arrayauxiliar(2).nombre & "'," & _
                                                    "titulo2cod=" & arrayauxiliar(2).codigo & "," & _
                                                    "titulo3='" & arrayauxiliar(3).nombre & "'," & _
                                                    "titulo3cod=" & arrayauxiliar(3).codigo & "," & _
                                                    "titulo4='" & arrayauxiliar(4).nombre & "'," & _
                                                    "titulo4cod=" & arrayauxiliar(4).codigo & "," & _
                                                    "titulo5='" & arrayauxiliar(5).nombre & "'," & _
                                                    "titulo5cod=" & arrayauxiliar(5).codigo & "," & _
                                                    "titulo6='" & arrayauxiliar(6).nombre & "'," & _
                                                    "titulo6cod=" & arrayauxiliar(6).codigo & "," & _
                                                    "titulo7='" & arrayauxiliar(7).nombre & "'," & _
                                                    "titulo7cod=" & arrayauxiliar(7).codigo & "," & _
                                                    "titulo8='" & arrayauxiliar(8).nombre & "'," & _
                                                    "titulo8cod=" & arrayauxiliar(8).codigo & " " & _
                                                    " where fechainicio= '" & Me.dtpFECHAINICIO.Value.ToString("dd/MM/yyyy") & "'"
        ca_cn2 = New Odbc.OdbcConnection(strCADENA)
        ca_cn2.Open()
        mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
        mycommand2.ExecuteNonQuery()

        CerrarConexion()
        ca_cn2.Close()
        ca_cn2.Dispose()

        Dim X As Integer

        Try
            strSQL = "select arbcedula,arbnombre from arbitro"
            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.ConnectionTimeout = 0
            ca_cn2.Open()
            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

            While (myreader2.Read)

                arbcedula = myreader2.GetValue(0)
                arbnombre = myreader2.GetValue(1)

                strSQL = "insert into auxmontosinformecontaduria (cedula,nombre) values " & _
                "(" & arbcedula & ",'" & arbnombre & "')"
                AbrirConexion()
                mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                mycommand.ExecuteNonQuery()
                CerrarConexion()

                For X = 1 To 8
                    'AbrirConexion()
                    'strSQL = "select titulo" & X & "cod from auxtitulosinformecontaduria"
                    'mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                    'myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                    'myreader.Read()
                    auxcodigoconcepto = arrayauxiliar(X).codigo
                    arraycargados(X) = arrayauxiliar(X).codigo
                    'CerrarConexion()
                Next X

                strSQL = "select movconcepto,movmonto,movtipo from movmensual where movcedula= " & arbcedula & _
                " and (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "') "
                ca_cn3 = New Odbc.OdbcConnection(strCADENA)
                ca_cn3.ConnectionTimeout = 0
                ca_cn3.Open()

                mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
                myreader3 = mycommand3.ExecuteReader(CommandBehavior.CloseConnection)
                Dim auxmontos As New auxmontosinformecontaduria
                auxmontos.cedula = arbcedula
                While (myreader3.Read())

                    Try
                        auxnombreconcepto = myreader3.GetValue(0)
                        auxmontoconcepto = myreader3.GetValue(1)
                        auxtipoconcepto = myreader3.GetValue(2)
                    Catch ex As Exception
                        auxnombreconcepto = ""
                        auxmontoconcepto = 0
                        auxtipoconcepto = "B"
                    End Try

                    If (UCase(Trim(auxtipoconcepto)) = "B") Then

                        auxmontos.apercibir = auxmontos.apercibir + auxmontoconcepto
                        auxmontos.montototal = auxmontos.montototal + auxmontoconcepto
                        calcularmantenimientocapital(auxmontoconcepto, auxmantenimientocapital, auxmontos)

                    Else
                        If (auxnombreconcepto = arraycargados(1)) Then
                            auxmontos.montotitulo(1) = auxmontos.montotitulo(1) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(2)) Then
                            auxmontos.montotitulo(2) = auxmontos.montotitulo(2) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(3)) Then
                            auxmontos.montotitulo(3) = auxmontos.montotitulo(3) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(4)) Then
                            auxmontos.montotitulo(4) = auxmontos.montotitulo(4) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(5)) Then
                            auxmontos.montotitulo(5) = auxmontos.montotitulo(5) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(6)) Then
                            auxmontos.montotitulo(6) = auxmontos.montotitulo(6) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(7)) Then
                            auxmontos.montotitulo(7) = auxmontos.montotitulo(7) + auxmontoconcepto

                        ElseIf (auxnombreconcepto = arraycargados(8)) Then
                            auxmontos.montotitulo(8) = auxmontos.montotitulo(8) + auxmontoconcepto
                        Else
                            auxmontos.montootros = auxmontos.montootros + auxmontoconcepto

                        End If
                        auxmontos.montototal = auxmontos.montototal - auxmontoconcepto
                    End If


                End While
                ca_cn3.Close()
                ca_cn3.Dispose()


                'strSQL = "update auxmontosinformecontaduria set montotitulo" & X & "=" & auxmontoconcepto & " where cedula=" & arbcedula
                'ca_cn4 = New Odbc.OdbcConnection(strCADENA)
                'ca_cn4.ConnectionTimeout = 0
                'ca_cn4.Open()
                'mycommand4 = New Odbc.OdbcCommand(strSQL, ca_cn4)
                'mycommand4.ExecuteNonQuery()
                'ca_cn4.Close()
                'ca_cn4.Dispose()

                'strSQL = "update auxmontosinformecontaduria set montototal=montototal-" & auxmontoconcepto & " where cedula=" & arbcedula
                'ca_cn4 = New Odbc.OdbcConnection(strCADENA)
                'ca_cn4.ConnectionTimeout = 0
                'ca_cn4.Open()
                'mycommand4 = New Odbc.OdbcCommand(strSQL, ca_cn4)
                'mycommand4.ExecuteNonQuery()
                'ca_cn4.Close()
                'ca_cn4.Dispose()


                'strSQL = "select sum(movmonto) as monto from movmensual where movtipo='D'and movcedula= " & arbcedula & " and  movconcepto not in (" & _
                'arraycargados(1) & "," & arraycargados(2) & "," & arraycargados(3) & "," & arraycargados(4) & "," & arraycargados(5) & "," & arraycargados(6) & "," & arraycargados(7) & "," & arraycargados(8) & ") " & _
                '"and (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "') "
                'ca_cn3 = New Odbc.OdbcConnection(strCADENA)
                'ca_cn3.Open()

                'mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
                'myreader3 = mycommand3.ExecuteReader(CommandBehavior.CloseConnection)

                'auxmontoconcepto = 0

                'While (myreader3.Read())

                '    Try
                '        auxnombreconcepto=myreader3.GetValue(
                '        auxmontoconcepto = myreader3.GetValue(0)
                '    Catch ex As Exception
                '        auxmontoconcepto = 0
                '    End Try

                '    'strSQL = "update auxmontosinformecontaduria set montootros=" & auxmontoconcepto & " where cedula=" & arbcedula
                '    'AbrirConexion()
                '    'mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                '    'mycommand.ExecuteNonQuery()
                '    'CerrarConexion()

                '    'strSQL = "update auxmontosinformecontaduria set montototal= montototal -" & auxmontoconcepto & " where cedula=" & arbcedula
                '    'AbrirConexion()
                '    'mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                '    'mycommand.ExecuteNonQuery()
                '    'CerrarConexion()




                'End While
                'ca_cn3.Close()
                'ca_cn3.Dispose()


                ''DESGLOSE DE LOS BONOS PARA GENERAR EL INFORME
                'strSQL = "select movmonto from movmensual where movcedula= " & arbcedula & " and  movtipo='B'" & _
                '"and (movfecha >= '" & Me.dtpFECHAINICIO.Value.Date.ToString("yyyy-MM-dd") & "' and movfecha <='" & Me.dtpFECHAFIN.Value.Date.ToString("yyyy-MM-dd") & "') "
                'ca_cn3 = New Odbc.OdbcConnection(strCADENA)
                'ca_cn3.Open()

                'mycommand3 = New Odbc.OdbcCommand(strSQL, ca_cn3)
                'myreader3 = mycommand3.ExecuteReader(CommandBehavior.CloseConnection)

                'auxmontoconcepto = 0

                'While (myreader3.Read())

                '    Try
                '        auxmontoconcepto = myreader3.GetValue(0)
                '    Catch ex As Exception
                '        auxmontoconcepto = 0
                '    End Try

                '    strSQL = "update auxmontosinformecontaduria set apercibir=apercibir+" & auxmontoconcepto & " where cedula=" & arbcedula
                '    AbrirConexion()
                '    mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                '    mycommand.ExecuteNonQuery()
                '    CerrarConexion()

                strSQL = "update auxmontosinformecontaduria set " & _
                                                            "apercibir=" & auxmontos.apercibir & "," & _
                                                            "montotitulo1= " & auxmontos.montotitulo(1) & "," & _
                                                            "montotitulo2= " & auxmontos.montotitulo(2) & "," & _
                                                            "montotitulo3= " & auxmontos.montotitulo(3) & "," & _
                                                            "montotitulo4= " & auxmontos.montotitulo(4) & "," & _
                                                            "montotitulo5= " & auxmontos.montotitulo(5) & "," & _
                                                            "montotitulo6= " & auxmontos.montotitulo(6) & "," & _
                                                            "montotitulo7= " & auxmontos.montotitulo(7) & "," & _
                                                            "montotitulo8= " & auxmontos.montotitulo(8) & "," & _
                                                            "montootros= " & auxmontos.montootros & "," & _
                                                            "montototal= " & auxmontos.montototal & " " & _
                                                            "where cedula = " & arbcedula & ""
                AbrirConexion()
                mycommand = New Odbc.OdbcCommand(strSQL, ca_cn)
                mycommand.ExecuteNonQuery()
                CerrarConexion()

                'End While
                'ca_cn3.Close()
                'ca_cn3.Dispose()

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK)
        End Try
        ca_cn2.Close()
        ca_cn2.Dispose()

        Dim reporte As New crpINFORMECONTADURIA
        Me.crpREPORTE.ReportSource = reporte

    End Sub

    Private Sub btnSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALIR.Click
        Me.Close()
    End Sub


    Private Sub calcularmantenimientocapital(ByVal auxmontoconcepto As Integer, ByVal posicion As Integer, ByRef auxiliar As auxmontosinformecontaduria)

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

            strSQL = "SELECT mancodigo,manmontoinicial,manmontofinal,manmontoasignado from mantenimientocapital"
            ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            ca_cn2.Open()

            mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)

            While (myreader2.Read())

                auxiliarmontoinicial = myreader2.GetValue(1)
                auxiliarmontofinal = myreader2.GetValue(2)
                auxiliarmontoasignado = myreader2.GetValue(3)

                If (auxmontoconcepto >= auxiliarmontoinicial And auxmontoconcepto <= auxiliarmontofinal) Then

                    Exit While

                End If

            End While

            ca_cn2.Close()

            'ca_cn2 = New Odbc.OdbcConnection(strCADENA)
            'ca_cn2.Open()
            'strSQL = "update auxmontosinformecontaduria set montotitulo" & posicion & "=montotitulo" & posicion & "+" & auxiliarmontoasignado & " where cedula=" & arbcedula
            'AbrirConexion()
            'mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            'mycommand2.ExecuteNonQuery()
            'CerrarConexion()

            auxiliar.montotitulo(posicion) = auxiliar.montotitulo(posicion) + auxiliarmontoasignado
            auxiliar.montototal = auxiliar.montototal - auxiliarmontoasignado

            'strSQL = "update auxmontosinformecontaduria set montototal=montototal-" & auxiliarmontoasignado & " where cedula=" & arbcedula
            'AbrirConexion()
            'mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn2)
            'mycommand2.ExecuteNonQuery()
            'CerrarConexion()


        Catch ex As Exception
            MessageBox.Show("Error en el procesamiento de registro", "Error de procesamiento", MessageBoxButtons.OK)
        End Try



    End Sub

    Private Sub grpCONTROLES_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCONTROLES.Enter

    End Sub

    Private Sub crpREPORTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crpREPORTE.Load

    End Sub

    Private Sub btnGENERARREPORTE_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGENERARREPORTE.ContextMenuChanged

    End Sub
End Class

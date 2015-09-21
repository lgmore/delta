Imports CrystalDecisions.Shared

Public Class frmRENDICIONTESORERIA

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim reporte As New crpRENDICIONTESORERIA
        Dim ca_cn2 As Odbc.OdbcConnection
        Dim mycommand2 As Odbc.OdbcCommand
        Dim myreader2 As Odbc.OdbcDataReader

        strSQL = "select c.connombre,sum(m.movmonto) from movmensual m, concepto c where m.movconcepto=c.concodigo and  movfecha between '" & Me.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "'::date and '" & Me.DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "'::date and movtipo like '%D%' group by c.connombre" & _
        " union all " & _
"select 'IVA Planilla' as ivaplanilla,sum(movmonto)/10 from movmensual where movfecha between '" & Me.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "'::date and '" & Me.DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "'::date and movtipo like '%B%'"
        AbrirConexion()
        mycommand2 = New Odbc.OdbcCommand(strSQL, ca_cn)
        myreader2 = mycommand2.ExecuteReader(CommandBehavior.CloseConnection)



        Dim valor As Integer
        Dim sumatoria As Integer
        While (myreader2.Read())
            valor = myreader2.GetValue(1)
            sumatoria = sumatoria + valor
        End While
        CerrarConexion()
        sumatoria = sumatoria + Integer.Parse(Me.TextBox1.Text)
        Dim convertidor As New NumLetras
        Dim saldoenLETRAS As String
        saldoenLETRAS = NumLetras.Convierte(sumatoria.ToString, claseNUMEROALETRA.NumLetras.Tipo.Pronombre)
        If (1000 <= 0) Then
            saldoenLETRAS = "cero"
        End If

        reporte.SetParameterValue("fechainicio", Me.DateTimePicker1.Value.ToString("dd/MM/yyyy"))
        reporte.SetParameterValue("fechafin", Me.DateTimePicker2.Value.ToString("dd/MM/yyyy"))
        reporte.SetParameterValue("fechainforme", Me.DateTimePicker3.Value.ToString("dd/MM/yyyy"))
        reporte.SetParameterValue("ivaviatico", Me.TextBox1.Text)
        reporte.SetParameterValue("totalenletras", saldoenLETRAS)

        Me.crpREPORTE.ReportSource = reporte
    End Sub

End Class
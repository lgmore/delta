Imports CrystalDecisions.Shared

Public Class frmDEUDASPENDIENTES

    Private Sub frmDEUDASPENDIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.arbitro' table. You can move, or remove it, as needed.
        Me.ArbitroTableAdapter.Fill(Me.DataSet1.arbitro)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim parametroReporte As String = ""
        Dim primeravez As Boolean = True
        For Each filaConceptos As DataGridViewRow In dgvArbitros.Rows
            If (filaConceptos.Cells.Item("colSeleccionado").Value = True) Then
                If (primeravez) Then
                    parametroReporte = parametroReporte + filaConceptos.Cells.Item("arbcedula").Value.ToString

                    primeravez = False

                Else
                    parametroReporte = parametroReporte + "," + filaConceptos.Cells.Item("arbcedula").Value.ToString

                End If
            End If




        Next
        Dim reporte As New crpDEUDASPENDIENTES
        Dim pvValoresParametros As New ParameterValues
        Dim listaarbitros As New ParameterDiscreteValue

        listaarbitros.Value = parametroReporte

        pvValoresParametros.Clear()
        pvValoresParametros.Add(listaarbitros)
        reporte.DataDefinition.ParameterFields("cedulas").ApplyCurrentValues(pvValoresParametros)

        Me.crpREPORTE.ReportSource = reporte
    End Sub
End Class
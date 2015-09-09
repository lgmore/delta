Public Class frmSOCIOSALDIA

    Private Sub btnGENERARREPORTE_Click(sender As Object, e As EventArgs) Handles btnGENERARREPORTE.Click


        Dim reporte As New crpREPORTESOCIOSALDIA


        ' objeto para contener una colección de valores de parámetros
        'Dim pvValoresParametros As New ParameterValues
        'Dim anhopromocion As New ParameterDiscreteValue

        'anhopromocion.Value = aux

        'pvValoresParametros.Clear()
        'pvValoresParametros.Add(anhopromocion)
        'reporte.DataDefinition.ParameterFields("anhopromocion").ApplyCurrentValues(pvValoresParametros)

        Me.crpREPORTE.ReportSource = reporte

    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Close()

    End Sub
End Class
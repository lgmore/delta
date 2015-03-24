Imports CrystalDecisions.Shared



Public Class frmREPORTE
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
    Friend WithEvents crvIMPRESION As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvimpre As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crvimpre = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvimpre
        '
        Me.crvimpre.ActiveViewIndex = -1
        Me.crvimpre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvimpre.Location = New System.Drawing.Point(0, 0)
        Me.crvimpre.Name = "crvimpre"
        Me.crvimpre.ReportSource = Nothing
        Me.crvimpre.Size = New System.Drawing.Size(1016, 578)
        Me.crvimpre.TabIndex = 0
        '
        'frmREPORTE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 578)
        Me.Controls.Add(Me.crvimpre)
        Me.Name = "frmREPORTE"
        Me.Text = "frmREPORTE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class

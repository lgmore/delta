Module modDELTAant
    Public strCADENA As String
    Public ca_cn As Odbc.OdbcConnection
    Public strSQL As String
    'Public blnEXISTE As Boolean
    'Public wkdirectorio As String
    Public dsDATOS As DataSet
    'Public dsDATOSM As DataSet
    'Public strSLOGAN As String = "DELTA - Un vuelo a la excelencia!"
    'Public wkarbcedula As Integer
    'Public glofecha, glotipo As String
    'Public glomonto, gloconcepto, glocedula As Integer
    'Public glonumero As Double


    Public Function AbrirConexion() As Boolean
        Try
            strCADENA = "DSN=CPAF"
            ca_cn = New Odbc.OdbcConnection(strCADENA)
            ca_cn.Open()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
            End
        End Try
    End Function
    Public Function CerrarConexion() As Boolean
        Try
            ca_cn.Close()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en el Cierre de Base de Datos", MessageBoxButtons.OK)
            End
        End Try
    End Function

End Module

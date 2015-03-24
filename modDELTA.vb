Module modDELTA
    'Public strCADENA As String
    'Public ca_cn As Odbc.OdbcConnection
    'Public strSQL As String
    Public blnEXISTE As Boolean
    Public wkdirectorio As String = Trim(Application.StartupPath)
    'Public dsDATOS As DataSet
    Public dsDATOSM As DataSet
    Public strSLOGAN As String = "DELTA - Un vuelo a la excelencia!"
    Public wkarbcedula As Integer
    'Public glonombre As String
    Public glofecha, glotipo As String
    Public glomonto, gloconcepto, glocedula, gloequipo, glomovid As Integer
    Public glonumero As Double
  



    'Public Function AbrirConexion() As Boolean
    '    Try
    '        strCADENA = "DSN=delta"
    '        ca_cn = New Odbc.OdbcConnection(strCADENA)
    '        ca_cn.Open()
    '    Catch err As Exception
    '        MessageBox.Show(err.Message, "Error en Apertura de Base de Datos", MessageBoxButtons.OK)
    '        End
    '    End Try
    'End Function
    'Public Function CerrarConexion() As Boolean
    '    Try
    '        ca_cn.Close()
    '    Catch err As Exception
    '        MessageBox.Show(err.Message, "Error en el Cierre de Base de Datos", MessageBoxButtons.OK)
    '        End
    '    End Try
    'End Function
    Public Function enletras(ByVal auxnumero As Double) As String
        enletras = "Aqui va el numero en letras"
    End Function
    Public Sub AsignarMonto(ByVal wkfecha As String)
        Dim tablas(10, 3) As Integer
        Dim wkpuntero, wkindice As Integer
        Dim wkmontoinicial, wkmontofinal, wkmonto As Double
        '
        AbrirConexion()
        Dim strsql As String = "SELECT raninicial, ranfinal, ranmonto from rango;"
        Dim myCommand As New Odbc.OdbcCommand(strsql, ca_cn)
        Dim myReader As Odbc.OdbcDataReader


        wkpuntero = 0
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            wkmontoinicial = myReader.GetValue(0)
            wkmontofinal = myReader.GetValue(1)
            wkmonto = myReader.GetValue(2)
            tablas(wkpuntero, 1) = wkmontoinicial
            tablas(wkpuntero, 2) = wkmontofinal
            tablas(wkpuntero, 3) = wkmonto
            wkpuntero = wkpuntero + 1
        End While
        myReader.Close()
        CerrarConexion()
        For wkindice = 0 To wkpuntero
            wkmontoinicial = tablas(wkindice, 1)
            wkmontofinal = tablas(wkindice, 2)
            wkmonto = tablas(wkindice, 3)
            Try
                AbrirConexion()
                strsql = "UPDATE movmensual set movcalculo = " & wkmonto & " " & _
                         "WHERE (movmensual.movmonto >= " & wkmontoinicial & " and " & _
                                "movmensual.movmonto <= " & wkmontofinal & " and movmensual.movtipo = 'B' and " & _
                                "movmensual.movfecha = '" & wkfecha & "');"
                Dim myCommand1 As New Odbc.OdbcCommand(strsql, ca_cn)
                myCommand1.ExecuteNonQuery()
                myCommand1.Dispose()
                CerrarConexion()
            Catch err As Exception
                MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
                End
            End Try
        Next wkindice

    End Sub
    Public Function vaciarMonto()
        Try
            AbrirConexion()
            strSQL = "UPDATE arbitro set arbmonto = 0;"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
            End
        End Try
    End Function

    Public Sub actualizarBono(ByVal wkfecha As String)
        Try
            AbrirConexion()
            strSQL = "UPDATE arbitro SET arbmonto = (arbitro.arbmonto+(movmensual.movmonto-movmensual.movcalculo)) " & _
                     "FROM movmensual " & _
                     "WHERE (movmensual.movcedula = arbitro.arbcedula and movmensual.movtipo ='B' and movmensual.movfecha = '" & wkfecha & "');"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
            End
        End Try


    End Sub
    Public Sub actualizarDescuento(ByVal wkfecha As String)
        Try
            AbrirConexion()
            strSQL = "UPDATE arbitro SET arbmonto = (arbitro.arbmonto-movmensual.movmonto) " & _
                     "FROM movmensual " & _
                     "WHERE (movmensual.movcedula = arbitro.arbcedula and movmensual.movtipo ='D' and movmensual.movfecha = '" & wkfecha & "');"
            Dim myCommand As New Odbc.OdbcCommand(strSQL, ca_cn)
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            CerrarConexion()
        Catch err As Exception
            MessageBox.Show(err.Message, "Error en la Grabación de Registro", MessageBoxButtons.OK)
            End
        End Try


    End Sub
End Module

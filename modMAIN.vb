Module modMAIN

    'Public strcadena As String
    'Public ca_cn As Odbc.OdbcConnection
    'Public dsDATOS As DataSet
    'Public strsql As String
    Public actualizardatagridCIUDAD As Boolean = False
    Public actualizardatagridIDIOMA As Boolean = False
    Public actualizardatagridCATEGORIA As Boolean = False
    Public actualizardatagridtipodocumento As Boolean = False
    Public actualizardatagridparentesco As Boolean = False
    Public actualizardatagridpais As Boolean = False
    Public actualizardatagridconcepto As Boolean = False
    Public actualizardatagridequipo As Boolean = False
    Public actualizardatagridestadio As Boolean = False
    Public actualizardatagrid As Boolean
    Public wkusucodigo As String
    Public wkusunombre As String
    Public wkusupassword As String
    Public wkusuusuario As String
    Public actualizardatagridprofesion As Boolean = False
    Public actualizardatagridmantenimientocapital As Boolean = False
    Public actualizardatagriddivisiones As Boolean = False
    Public actualizardatagridbusqueda As Boolean = True
    Public glonombre As String
    'Public glofecha, glotipo As String
    'Public glomonto, gloconcepto, glocedula As Integer
    'Public glonumero As Double

    'Public Function AbrirConexion() As Boolean
    '    Try
    '        strcadena = "DSN=CPAF"
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

End Module

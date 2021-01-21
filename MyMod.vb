Imports MySql.Data.MySqlClient

Module MyMod
    Public mycommand As New MySqlCommand
    Public myadapter As New MySqlDataAdapter
    Public mydata As New System.Data.DataTable
    Public ds As New DataSet
    Public DR As MySql.Data.MySqlClient.MySqlDataReader
    Public SQL As String
    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public cn As New Connection
    
    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    Public Sub DBConnect()
        cn.Host = "localhost"
        cn.User = "root"
        cn.Password = ""
        cn.DatabaseName = "dbumc"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
End Module

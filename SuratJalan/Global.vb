Imports MySql.Data.MySqlClient
Module Globals

    Public userlogin As String
    Public waktu As DateTime

    'Iniate App Path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory
    End Function
    'DB Config
    Public Server_Host As String
    Public Server_User As String
    Public Server_Password As String
    Public Server_Database As String

    Sub alamat()
        Server_Host = My.Settings.dbServer
        Server_User = My.Settings.dbUser
        Server_Password = My.Settings.dbPassowrd
        Server_Database = My.Settings.dbName
    End Sub

    'Create Connection
    Dim con As New ClsKoneksi

    'Server Status
    Public str_status As Integer
    Sub Koneksikan()
        Try
            con.OpenConn()
            str_status = 1
            con.CloseConn()
        Catch ex As Exception
            str_status = 0
        End Try
    End Sub

    'User Information
    Public kry_id, kry_lvl, kry_name, kry_username, kry_password, kry_alamat, kry_telp As String

    Sub Logout()
        kry_id = ""
        kry_lvl = ""
        kry_name = ""
        kry_username = ""
        kry_password = ""
        kry_alamat = ""
        kry_telp = ""
    End Sub

    Public Function Rep(ByVal Kata As String) As String
        Rep = Replace(Kata, "'", "''")
    End Function




End Module




'Public Module Functions
'    Public Sub singleqoute()
'        Dim ctrl As Control
'        Dim txt As TextBox

'        For Each txt In FrmLogin.Controls()
'            If TypeOf txt Is TextBox Then
'                txt = CType(txt, TextBox)
'                txt.Text = txt.Text.Replace("'", "''")
'            End If
'        Next
'        For Each txt In FrmUtama.Controls
'            If TypeOf txt Is TextBox Then
'                txt = CType(txt, TextBox)
'                txt.Text = Replace(txt.Text, "'", "''")
'            End If
'        Next
'        For Each txt In FrmConfig.Controls
'            If TypeOf txt Is TextBox Then
'                txt = CType(txt, TextBox)
'                txt.Text = Replace(txt.Text, "'", "''")
'            End If
'        Next

'    End Sub

'End Module
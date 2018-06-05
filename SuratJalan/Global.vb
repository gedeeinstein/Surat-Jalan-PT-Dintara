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


    Public Sub AuthorIG()
        System.Diagnostics.Process.Start("https://www.instagram.com/gedeeinstein/")
    End Sub


    Public Sub InstagramOpen()
        System.Diagnostics.Process.Start("https://www.instagram.com/dintara.kitchenn/")
    End Sub
    Public Sub FaceboookOpen()
        System.Diagnostics.Process.Start("https://www.facebook.com/DintaraKitchen")
    End Sub
    Public Sub TwitterOpen()
        System.Diagnostics.Process.Start("https://twitter.com/DintaraKitchen")
    End Sub
    Public Sub LinkedinOpen()
        System.Diagnostics.Process.Start("https://www.linkedin.com/in/dintara-kitchen-equipment/")
    End Sub
    Public Sub GplusOpen()
        System.Diagnostics.Process.Start("https://instagram.com/gedeeinstein")
    End Sub
    Public Sub WhatsappSend()

        System.Diagnostics.Process.Start("https://goo.gl/p4STJm")
    End Sub

    Public Sub GmapsOpen()
        System.Diagnostics.Process.Start("https://goo.gl/maps/q2TSq1sHooD2")
    End Sub
    Public Sub GmailSend()
        System.Diagnostics.Process.Start("mailto:dintara.kitchen@gmail.com?Subject=Tanya%20Tentang%20Aplikasi%20Surat%20Jalan")
    End Sub

    Public Sub OutlookSend()
        System.Diagnostics.Process.Start("mailto:it@dintarakitchen.co.id?Subject=Tanya%20Tentang%20Aplikasi%20Surat%20Jalan&body=Tolong%20Datang%20dan%20perbaiki%20aplikasinya")
    End Sub

    Public Sub Koneksi_Error()
        MessageBox.Show("Ada kesalahan koneksi", "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
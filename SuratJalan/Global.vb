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

    'Sub User_Program()
    '    Dim proses As New ClsKoneksi
    '    Dim Nama As String
    '    Dim masuk As DataTable
    '    Dim User_Programs As String
    '    Try
    '        masuk = proses.ExecuteQuery("SELECT nama_user FROM karyawan WHERE username ='" & FrmLogin.txtusername.Text & "'")
    '        If masuk.Rows.Count = 0 Then
    '            MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
    '            Call Reset()
    '            FrmLogin.txtusername.Focus()
    '            : Exit Sub
    '        Else
    '            FrmLogin.txtNama.Text = masuk.Rows(0).Item("nama_user").ToString
    '            User_Programs = FrmLogin.txtNama.Text
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

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



    'Test

    Dim isAdmin As Integer
    Dim level_1, level_2, level_3 As String
    Dim masuk As DataTable

    Public Sub Check_Level_Rpt()

        Try
            con.OpenConn()
            masuk = con.ExecuteQuery("SELECT nama_user FROM karyawan WHERE username ='" & FrmLogin.txtusername.Text & "' and level_id='1'")
            If masuk.Rows.Count = 0 Then
                MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
                Call Reset()
                : Exit Sub
            Else
                level_1 = masuk.Rows(0).Item("nama_user").ToString

            End If
        Catch ex As Exception
            MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
        End Try

        'Dim myadapter As New MySqlDataAdapter
        'Dim sqlquery = "SELECT * FROM karyawan where username='" +
        '    Trim(FrmLogin.txtusername.Text) + "' And passwd='" + Trim(FrmLogin.txtpassword.Text) + "'"
        'Dim mycommand As New MySqlCommand
        'mycommand.Connection = con.Cn
        'mycommand.CommandText = sqlquery
        'myadapter.SelectCommand = mycommand

        'Dim mydata As MySqlDataReader
        'mydata = mycommand.ExecuteReader()

        'mydata.Read()
        'isAdmin = mydata("level")

        'If isAdmin = 2 Then
        'End If

        'If isAdmin = 1 Then
        '    MsgBox("Kamu login sebagai Administrator Aplikasi. Silahkan gunakan aplikasi dengan baik !")
        'End If

        'If isAdmin = 1 Then
        '    FrmUtama.btnTambahUser.Enabled = True
        '    FrmUtamaATM.btnTambahUser.Enabled = True
        'End If

        'If isAdmin = 2 Then
        '    FrmUtama.btnTambahUser.Enabled = True
        '    FrmUtamaATM.btnTambahUser.Enabled = True
        'End If
        'proses.CloseConn()
    End Sub

End Module
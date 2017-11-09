Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Dim proses As New ClsKoneksi
    Dim Nama As String
    Dim masuk As DataTable


    Sub Connect()
        Koneksikan()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
        End If
    End Sub
    Sub ReconfigDB()
        Koneksikan()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
            MsgBox("Pengaturan berhasil diterapkan", MsgBoxStyle.Information, "Info")
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Pengaturan Gagal diterapkan, pastikan server telah online dan konfigurasi yang di masukkan telah benar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub ReconectDB()
        Koneksikan()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub reset()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtNama.Text = ""
        txtusername.Focus()
    End Sub
    Sub save_info()
        If (cb_saveuser.Checked = True) And (cb_saveuserpass.Checked) = True Then
            'None
        ElseIf (cb_saveuser.Checked) = True And (cb_saveuserpass.Checked) = False Then
            txtpassword.Text = ""
            txtusername.Focus()
        Else
            txtusername.Text = ""
            txtpassword.Text = ""
            txtNama.Text = ""
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                Dim myadapter As New MySqlDataAdapter
                Dim sqlquery = "SELECT * FROM karyawan where username='" +
                        Trim(txtusername.Text) + "' And passwd='" + Trim(txtpassword.Text) + "'"
                Dim mycommand As New MySqlCommand
                mycommand.Connection = proses.Cn
                mycommand.CommandText = sqlquery
                myadapter.SelectCommand = mycommand
                Dim mydata As MySqlDataReader
                mydata = mycommand.ExecuteReader()


                If txtusername.Text.Count = 0 Then
                    MsgBox("Masukkan Username !", MsgBoxStyle.Information, "Info")
                    txtusername.Focus() : Exit Sub
                ElseIf txtpassword.Text.Count = 0 Then
                    MsgBox("Masukkan Password !", MsgBoxStyle.Information, "Info")
                    txtpassword.Focus()
                Else
                    If mydata.HasRows = 0 Then
                        MsgBox("Username atau password ada yang salah! ", MsgBoxStyle.Exclamation,
                    "Error Login")
                        Call reset()
                        : Exit Sub
                    Else
                        mydata.Read()
                        'kry_id = mydata("KARYAWANID")
                        'kry_lvl = mydata("LEVELID")
                        'kry_name = mydata("KARYAWANNAME")
                        'kry_username = mydata("KARYAWANUSERNAME")
                        'kry_password = mydata("KARYAWANPASSWORD")
                        'kry_alamat = mydata("KARYAWANALAMAT")
                        'kry_telp = mydata("KARYAWANTELP")
                        'MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")

                        userlogin = txtNama.Text
                        If rbATM.Checked = True Then
                            MsgBox("Selamat Datang " + userlogin, MsgBoxStyle.Information, "Login Berhasil")
                            FrmUtamaATM.Show()
                        ElseIf rbDIN.Checked = True Then
                            MsgBox("Selamat Datang " + userlogin, MsgBoxStyle.Information, "Login Berhasil")
                            FrmUtama.Show()
                        Else
                            MsgBox("Silahkan Pilih Login Tipe Terlebih Dahulu", MsgBoxStyle.Exclamation, "Pilih Salah Satu")
                        End If

                        Me.Hide()
                        Call save_info()
                    End If
                End If

                mydata.Read()
                isAdmin = mydata("level_id")

                If isAdmin = 2 Then
                    MsgBox("Kamu Login sebagai user biasa, beberapa fitur akan dibatasi !", MsgBoxStyle.Information, "Hai 😍 " + userlogin)
                End If

                If isAdmin = 1 Then
                    MsgBox("Kamu login sebagai Administrator Aplikasi. Silahkan gunakan aplikasi dengan baik !", MsgBoxStyle.Information, "Hai 😍 " + userlogin)
                End If

                If isAdmin = 1 Then
                    FrmUtama.btnTambahUser.Enabled = True
                    FrmUtamaATM.btnTambahUser.Enabled = True
                End If

                If isAdmin = 2 Then
                    FrmUtama.btnTambahUser.Enabled = False
                    FrmUtamaATM.btnTambahUser.Enabled = False
                    FrmUtama.btnMasterSurat.Enabled = False
                    FrmUtamaATM.btnMasterSurat.Enabled = False
                End If

                proses.CloseConn()
            Else
                'MsgBox("Tidak dapat terhubung ke server, silahkan reset terlebih dahulu", MsgBoxStyle.Critical, "Connection Error")
                Connect()
            End If

        Catch ex As Exception
            Connect()
            MsgBox("Tidak dapat terhubung ke server, silahkan reset terlebih dahulu" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect()
        rbATM.Checked = False
        rbDIN.Checked = True
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        ReconectDB()
    End Sub

    Private Sub cb_saveuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_saveuser.CheckedChanged
        If cb_saveuser.Checked = False Then
            cb_saveuserpass.Enabled = False
        ElseIf cb_saveuser.Checked = True Then
            cb_saveuserpass.Enabled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfig.Click
        If MsgBox("Apakah anda sudah tau cara mengkonfigurasi aplikasi ini ?" + vbNewLine + "Jika Belum hubungi IT", MsgBoxStyle.OkCancel, "Lanjutkan ?") = MsgBoxResult.Ok Then
            FrmConfig.ShowDialog()
        End If

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmConfig.Text = "Pengaturan Aplikasi Surat Jalan"
        FrmConfig.Show()
    End Sub

    Private Sub txtusername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call nama_user()
            txtpassword.Focus()
        End If

    End Sub

    Public Sub nama_user()
        Try
            masuk = proses.ExecuteQuery("SELECT nama_user FROM karyawan WHERE username ='" & txtusername.Text & "'")
            If masuk.Rows.Count = 0 Then
                MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
                Call reset()
                txtusername.Focus()
                : Exit Sub
            Else
                txtNama.Text = masuk.Rows(0).Item("nama_user").ToString
            End If
        Catch ex As Exception
            MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtpassword_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtpassword.MouseDown
        Call nama_user()
    End Sub

    Private Sub txtusername_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TabIndexChanged
        'Call nama_user()
    End Sub

    Private Sub txtusername_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtusername.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            Call nama_user()
        End If
    End Sub


    Dim isAdmin As Integer


    Public Sub Cek_level()
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT * FROM karyawan where username='" +
            Trim(txtusername.Text) + "' And passwd='" + Trim(txtpassword.Text) + "'"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        myData.Read()
        isAdmin = mydata("level")

        If isAdmin = 2 Then
            MsgBox("Kamu Login Sebagai User Biasa !")
        End If

        If isAdmin = 1 Then
            MsgBox("Kamu login sebagai Administrator Aplikasi. Silahkan gunakan aplikasi dengan baik !")
        End If

        If isAdmin = 1 Then
            FrmUtama.btnTambahUser.Enabled = True
            FrmUtamaATM.btnTambahUser.Enabled = True
        End If

        If isAdmin = 2 Then
            FrmUtama.btnTambahUser.Enabled = True
            FrmUtamaATM.btnTambahUser.Enabled = True
        End If
        proses.CloseConn()
    End Sub

End Class
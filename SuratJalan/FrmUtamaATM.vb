Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmUtamaATM
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer

    Dim dtPelanggan As DataTable
    Dim dtOrder As DataTable
    Dim dtSurat As DataTable

    Sub Data_Record_Pengiriman()
        dtSurat = Proses.ExecuteQuery("SELECT nosurat AS 'NO SURAT', kode AS 'KODE BARANG', nama_barang AS 'NAMA BARANG', qty AS 'QTY' FROM suratjalan_detail WHERE nosurat = '" & txtNoSurat.Text & "'")

        DGBarangKirim.DataSource = dtSurat
        DGBarangKirim.Columns(0).Visible = False
        DGBarangKirim.Columns(1).Width = 130
        DGBarangKirim.Columns(2).Width = 600
        DGBarangKirim.Columns(3).Width = 65

        DGBarangKirim.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarangKirim.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Sub Data_Pelanggan()
        dtPelanggan = Proses.ExecuteQuery("SELECT kode, nama FROM pelanggan ORDER BY kode ASC")
        If dtPelanggan.Rows.Count = 0 Then
        Else
            cmbPerusahaan.Items.Clear()
            With dtPelanggan.Columns(1)
                For Me.haha = 0 To dtPelanggan.Rows.Count - 1
                    cmbPerusahaan.Items.Add("" & .Table.Rows(haha).Item(0) & "/" & .Table.Rows(haha).Item(1) & "")
                Next haha
            End With
        End If

    End Sub

    Sub Data_Perusahaan()
        dtPelanggan = Proses.ExecuteQuery("SELECT nama from pelanggan where kode = '" & vb.Left(cmbPerusahaan.Text, 10) & "'")

        If dtPelanggan.Rows.Count = 0 Then
        Else
            txtPerusahaan.Text = dtPelanggan.Rows(0).Item("nama")

        End If

    End Sub

    Sub Data_Barang()
        dtPelanggan = Proses.ExecuteQuery("SELECT barang.kode, barang.nama FROM barang INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang WHERE tawar02.kode ='" & txtNoOrder.Text & "'")

        If dtPelanggan.Rows.Count = 0 Then
        Else
            txtBarang.Text = dtPelanggan.Rows(0).Item("nama")
        End If

    End Sub

    Sub Bulan_Romawi()

        Dim bln = Format(Now, "MM")

        If bln = "01" Then
            bln = "I"
        ElseIf bln = "02" Then
            bln = "II"
        ElseIf bln = "03" Then
            bln = "III"
        ElseIf bln = "04" Then
            bln = "IV"
        ElseIf bln = "05" Then
            bln = "V"
        ElseIf bln = "06" Then
            bln = "VI"
        ElseIf bln = "07" Then
            bln = "VII"
        ElseIf bln = "08" Then
            bln = "VIII"
        ElseIf bln = "09" Then
            bln = "IX"
        ElseIf bln = "10" Then
            bln = "X"
        ElseIf bln = "11" Then
            bln = "XI"
        ElseIf bln = "12" Then
            bln = "XII"
        End If

        ' romawi_label.Text = bln

    End Sub

    Sub No_Surat_Otomatis()
        Dim bln = Format(Now, "MM")

        If bln = "01" Then
            bln = "I"
        ElseIf bln = "02" Then
            bln = "II"
        ElseIf bln = "03" Then
            bln = "III"
        ElseIf bln = "04" Then
            bln = "IV"
        ElseIf bln = "05" Then
            bln = "V"
        ElseIf bln = "06" Then
            bln = "VI"
        ElseIf bln = "07" Then
            bln = "VII"
        ElseIf bln = "08" Then
            bln = "VIII"
        ElseIf bln = "09" Then
            bln = "IX"
        ElseIf bln = "10" Then
            bln = "X"
        ElseIf bln = "11" Then
            bln = "XI"
        ElseIf bln = "12" Then
            bln = "XII"
        End If

        dtSurat = Proses.ExecuteQuery("SELECT * FROM suratjalan order by nosurat desc")
        If dtSurat.Rows.Count = 0 Then
            txtNoSurat.Text = "001" + "/SJ/" + Format(Now, "MM") + "/CV/" + Format(Now, "yyyy")
        Else
            With dtSurat.Rows(0)
                txtNoSurat.Text = .Item("nosurat")
            End With
            txtNoSurat.Text = Val(Microsoft.VisualBasic.Mid(txtNoSurat.Text, 1, 3)) + 1
            If Len(txtNoSurat.Text) = 1 Then
                txtNoSurat.Text = "00" & txtNoSurat.Text + "/SJ/" + bln + "/CV/" + Format(Now, "yyyy")
            ElseIf Len(txtNoSurat.Text) = 2 Then
                txtNoSurat.Text = "0" & txtNoSurat.Text + "/SJ/" + bln + "/CV/" + Format(Now, "yyyy")
            ElseIf Len(txtNoSurat.Text) = 3 Then
                txtNoSurat.Text = "" & txtNoSurat.Text + "/SJ/" + bln + "/CV/" + Format(Now, "yyyy") '& txtNoSurat.Text & ""
            End If
        End If
    End Sub


    Sub Reset()
        'txtNoSurat.Text = Nothing
        txtNoOrder.Text = Nothing
        cmbPerusahaan.Text = "Silahkan Pilih Tujuan Pengiriman"
        txtBarang.Text = Nothing
        txtPelanggan.Text = Nothing
        txtPelanggan.Enabled = False
        txtPerusahaan.Text = Nothing
        txtQty.Text = Nothing
        txtPerusahaan.Text = ""
        txtKodePerusahaan.Text = ""
        txtKodeBarang.Text = ""
        btnCariPerusahaan.Enabled = True
        txtAlamat.Text = ""
        Label_TotalBarang.Text = "0"
    End Sub


    Sub Data_Awal()
        Call Data_Pelanggan()
        Call No_Surat_Otomatis()
        Call Data_Barang()
        Call Data_Perusahaan()
        Call cmbPerusahaan.Focus()
        cmbPerusahaan.Focus()
        cmbPerusahaan.Text = "Silahkan Pilih Tujuan Pengiriman"
        cmbPerusahaan.Enabled = False
        Call Bulan_Romawi()
        'Call Data_Barang_Dintara()
        'DataOrder()
    End Sub


    Private Sub FrmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Awal()
        Call Data_Record_Pengiriman()
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        Call Pengguna()

        'Data_Pelanggan()
        'No_Surat_Otomatis()
        'cmbPerushaan.Text = ""
        ''DataOrder()
        'Data_Barang()
        'Data_Barang_Dintara()
        'Data_Perusahaan()
        'cmbPerushaan.Focus()
    End Sub

    Sub Pengguna()
        loged_in.Text = userlogin
    End Sub


    Private Sub cmbPelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerusahaan.SelectedIndexChanged
        Try
            dtPelanggan = Proses.ExecuteQuery("SELECT kode, kode_pelanggan, att FROM tawar01 where kode_pelanggan = '" & vb.Left(cmbPerusahaan.Text, 10) & "' ")
            If dtPelanggan.Rows.Count = 0 Then
            Else
                txtPelanggan.Text = dtPelanggan.Rows(0).Item("att")
                txtNoOrder.Text = dtPelanggan.Rows(0).Item("kode")
                Trim(txtNoOrder.Text)
                Call Att_Kosong()
                txtPelanggan.Text = txtPelanggan.Text.Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ada Kesalahan, Hubungi IT Untuk informasi penggunaan Aplikasi ini",
                            MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    ' I Think This Code is unused anymore
    Private Sub cmbPelanggan_SelectedIndexChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerusahaan.SelectedIndexChanged
        dtPelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan where kode = '" & vb.Left(cmbPerusahaan.Text, 10) & "' ")
        If dtPelanggan.Rows.Count = 0 Then
        Else
            txtPerusahaan.Text = dtPelanggan.Rows(0).Item("nama")
            txtKodePerusahaan.Text = dtPelanggan.Rows(0).Item("kode")
            Trim(txtKodePerusahaan.Text)
            RTrim(txtPerusahaan.Text)
        End If
    End Sub


    Private Sub txtPelanggan_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtPelanggan.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            txtBarang.Focus()
        End If
    End Sub

    Private Sub Att_Kosong()
        If txtPelanggan.Text = "" Then
            MsgBox("Data penerima barang yang akan dikirim belum dinput oleh Admin Marketing / Purchasing",
                   MsgBoxStyle.Information, "Hubungi Admin Marketing / Purchasing")
            If MsgBox("Apakah Mau input Manual?", MsgBoxStyle.YesNo, "Input Sendiri?") = vbYes Then
                txtPelanggan.Enabled = True
                txtPelanggan.ReadOnly = False
                txtPelanggan.Focus()
            Else
                Call Reset()
                cmbPerusahaan.Focus()
            End If
        End If
    End Sub


    Private Sub txtBarang_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtBarang.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            txtQty.Focus()
        End If
    End Sub

    'Private Sub Sama_Barang_NoSurat()
    '    Dim i As Integer
    '    Dim total As Double
    '    Dim nomorsurat As String
    '    Dim KodeBarang As String

    '    total = 0


    '    For i = 0 To DGBarangKirim.Rows.Count - 1
    '        nomorsurat = DGBarangKirim.Item(0, i).ToString
    '        KodeBarang = DGBarangKirim.Item(1, i).ToString
    '        'total += Val(DGBarangKirim.Item(5, i).Value)
    '    Next
    '    'txtTotal.Text = Format(Val(Replace(total, ".", "")))

    '    Try
    '        If txtKodeBarang.Text = KodeBarang Then
    '            MessageBox.Show("Gagal. Tidak diperbolehkan menginput barang yang sama. Masukanlah jumlah quantity. Jika Pertama kali input sudah salah harap ulangi proses dengan tekan tombol batal ", "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
    '    End Try


    'End Sub


    'This Sub Jumlah_QTY() is unused anymore
    Private Sub Jumlah_QTY()
        Proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT * FROM suratjalan_detail WHERE nosurat = '" & txtNoSurat.Text & "'"

        Dim mycommand As New MySqlCommand



        mycommand.Connection = Proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim totalbarang As Integer
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        totalbarang = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                totalbarang = totalbarang + 1
            End While
        End If
        Label_TotalBarang.Text = Val(totalbarang)


        Proses.CloseConn()
    End Sub

    Private Sub total_item()
        Dim hitung As Integer
        For baris As Integer = 0 To DGBarangKirim.RowCount - 1
            hitung = hitung + DGBarangKirim.Rows(baris).Cells(3).Value
        Next

        'Label_TotalBarang.Text = 'DGBarangKirim.RowCount - 1
        Label_TotalBarang.Text = hitung

    End Sub

    Private Sub Cek_Barang_Sudah_Kirim()
        Dim SQL = "SELECT kode, nama_barang FROM suratjalan_detail WHERE no_order = '" & Trim(txtNoOrder.Text) & "'"
        'If DGBarangKirim.Item(2) = txtKodeBarang.Text Then

        'End If
    End Sub

    Private Sub Simpan_Details_Surat()
        Try
            Proses.OpenConn()
            SQL = "insert into suratjalan_detail " _
                & "(nosurat, kode, nama_barang, qty, no_order) VALUES " _
                & "('" & txtNoSurat.Text & "','" & Trim(txtKodeBarang.Text) & "' " _
                & ",'" & Rep(txtBarang.Text) & "','" & txtQty.Text & "','" & Trim(txtNoOrder.Text) & "')"
            Proses.ExecuteNonQuery(SQL)
            ' MsgBox("Barang ditambahakan", MsgBoxStyle.OkOnly, "Sukses")
            'MessageBox.Show("Barang yang akan dikirimkan sudah ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Data_Record_Pengiriman()
            Proses.CloseConn()

        Catch ex As Exception
            MessageBox.Show("Gagal. Tidak diperbolehkan menginput barang yang sama. Masukanlah jumlah quantity. Jika Pertama kali input sudah salah harap ulangi proses dengan tekan tombol batal " + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    'Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If

    '    Try
    '        Select Case e.KeyCode
    '            Case Keys.A To Keys.Z

    '            Case Keys.Enter

    '                If txtNoOrder.Text = "" Then
    '                    MsgBox("Tanyakan ke Admin apakah sudah melakukan input penawaran/order ke system ", MsgBoxStyle.Critical,
    '                           "Gagal !") : Exit Sub
    '                    cmbPerusahaan.Focus()
    '                ElseIf txtPerusahaan.Text = "" Then
    '                    MsgBox("Tanyakan ke admin Marketing untuk melengkapi data Perusahaan dari penawaran yang dibuat", MsgBoxStyle.Exclamation,
    '                           "Data Belum Lengkap") : Exit Sub
    '                    cmbPerusahaan.Focus()
    '                ElseIf txtPelanggan.Text = "" Then
    '                    MsgBox("Tanyakan ke admin Marketing untuk melengkapi data Penerima dari Penawaran yang dibuat", MsgBoxStyle.Exclamation,
    '                           "Data Belum Lengkap") : Exit Sub
    '                    cmbPerusahaan.Focus()
    '                ElseIf txtBarang.Text = "" Then
    '                    MsgBox("Pilih Barang yang akan dikirim. Harap tanyakan data ke bagian marketing/purchasing ", MsgBoxStyle.Exclamation,
    '                           "Barang Belum Dipilih") : Exit Sub
    '                    txtBarang.Focus()
    '                ElseIf txtQty.Text = "" Then
    '                    MsgBox("QTY Salah", MsgBoxStyle.Exclamation,
    '                            "Qty Salah") : Exit Sub
    '                ElseIf txtAlamat.Text = "" Or txtAlamat.TextLength < 3 Then
    '                    MessageBox.Show("Harap isi alamat tujuan pengiriman jika di database tidak ada, isi manual saja ", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    txtAlamat.Focus() : Exit Sub
    '                End If

    '                Call Simpan_Details_Surat()
    '                ' Call Jumlah_QTY()
    '                Call total_item()
    '                btnReset.Enabled = False
    '                txtKodeBarang.Text = Nothing
    '                txtBarang.Text = Nothing
    '                txtQty.Text = Nothing
    '                btnBatal.Enabled = True
    '                btnSimpan.Enabled = True

    '            Case Else

    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show("Gagal. Tidak diperbolehkan menginput barang yang sama. Masukanlah jumlah quantity. Jika Pertama kali input sudah salah harap ulangi proses dengan tekan tombol batal " + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub

    '    End Try

    'End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress

        Try

            Select Case e.KeyChar
                Case Chr(47) To Chr(57)
                    'cmbPerushaan.Focus()
                Case Chr(8)
                    e.KeyChar = Chr(8)
                Case Chr(13)
                    If txtNoOrder.Text = "" Then
                        MsgBox("Tanyakan ke Admin apakah sudah melakukan input penawaran/order ke system ", MsgBoxStyle.Critical,
                               "Gagal !") : Exit Sub
                        cmbPerusahaan.Focus()
                    ElseIf txtPerusahaan.Text = "" Then
                        MsgBox("Tanyakan ke admin Marketing untuk melengkapi data Perusahaan dari penawaran yang dibuat", MsgBoxStyle.Exclamation,
                               "Data Belum Lengkap") : Exit Sub
                        cmbPerusahaan.Focus()
                    ElseIf txtPelanggan.Text = "" Then
                        MsgBox("Tanyakan ke admin Marketing untuk melengkapi data Penerima dari Penawaran yang dibuat", MsgBoxStyle.Exclamation,
                               "Data Belum Lengkap") : Exit Sub
                        cmbPerusahaan.Focus()
                    ElseIf txtBarang.Text = "" Then
                        MsgBox("Pilih Barang yang akan dikirim. Harap tanyakan data ke bagian marketing/purchasing ", MsgBoxStyle.Exclamation,
                               "Barang Belum Dipilih") : Exit Sub
                        txtBarang.Focus()
                    ElseIf txtQty.Text = "" Then
                        MsgBox("QTY Salah", MsgBoxStyle.Exclamation,
                                "Qty Salah") : Exit Sub
                    ElseIf txtAlamat.Text = "" Or txtAlamat.TextLength < 3 Then
                        MessageBox.Show("Harap isi alamat tujuan pengiriman jika di database tidak ada, isi manual saja ", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtAlamat.Focus() : Exit Sub
                    End If

                    Call Simpan_Details_Surat()
                    ' Call Jumlah_QTY()
                    Call total_item()
                    btnReset.Enabled = False
                    txtKodeBarang.Text = Nothing
                    txtBarang.Text = Nothing
                    txtQty.Text = Nothing
                    btnBatal.Enabled = True
                    btnSimpan.Enabled = True

                Case Else
                    e.KeyChar = Chr(0)
            End Select

        Catch ex As Exception
            MessageBox.Show("Gagal. Tidak diperbolehkan menginput barang yang sama. Masukanlah jumlah quantity. Jika Pertama kali input sudah salah harap ulangi proses dengan tekan tombol batal " + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

        If (Not Char.IsControl(e.KeyChar) _
           AndAlso (Not Char.IsDigit(e.KeyChar) _
           AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Sub Simpan_Surat()
        Try
            If txtPerusahaan.Text = "" Then
                MessageBox.Show("Data Perusahaan Belum Ada", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            ElseIf txtPelanggan.Text = "" Then
                MessageBox.Show("Data Attention Tidak Ada", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            ElseIf txtNoOrder.Text = "" Then
                MessageBox.Show("Data Penawaran / Order Tidak Ada ", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            ElseIf txtAlamat.Text = "" Or txtAlamat.TextLength < 3 Then
                MessageBox.Show("Harap isi alamat tujuan pengiriman jika di database tidak ada, isi manual saja ", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAlamat.Focus() : Exit Sub

            End If
            Dim tgl = Format(DateTimePicker1.Value.Date, "dd-MM-yyyy")
            SQL = "insert into suratjalan " _
                & "(nosurat, kode_perusahaan, nama_perusahaan, att, tanggal, no_order, total, alamat, user) VALUES " _
                & "('" & txtNoSurat.Text & "','" & Trim(txtKodePerusahaan.Text) & "','" & Rep(txtPerusahaan.Text) & "','" & Rep(txtPelanggan.Text) & "' " _
                & ",'" & tgl & "','" & Trim(txtNoOrder.Text) & "', '" & Label_TotalBarang.Text & "', '" & Rep(txtAlamat.Text) & "', '" & loged_in.Text & "')"

            If MsgBox("Apakah anda yakin akan menyimpan Data Pengiriman Barang" & vbNewLine & "Data yang sudah disimpan tidak dapat di ubah atau hapus lagi !", vbYesNo, "Konfirmasi") = vbYes Then
                Proses.ExecuteNonQuery(SQL)
                MessageBox.Show("Data surat pengiriman barang berhasil disimpan. " + vbNewLine + "Harap tunggu sistem akan mencetak surat Anda ", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FrmRptSPK_ATM.Text = "Cetak Surat Jalan No CV " + txtNoSurat.Text
                FrmRptSPK_ATM.ShowDialog()
                Call Data_Awal()
                Call Reset()
                Call No_Surat_Otomatis()
                Call Data_Record_Pengiriman()

                btnSimpan.Enabled = False
                btnBatal.Enabled = False
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbNewLine + "Terjadi kesalahan saat penginputan data", "Gagal, Hubung IT", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

        FrmConfig.Text = "Pengaturan Aplikasi Surat Jalan"
        FrmConfig.Show()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FrmLogin.Show()
        End If

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Me.Close()
            FrmLogin.Close()
            Application.Exit()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click

        If txtPerusahaan.Text = "" Or txtPerusahaan.Text = Nothing Then
            MsgBox("Data Kosong. Pilih Customer yang akan dikirimkan barang", MsgBoxStyle.Exclamation, "Pilih Customer !!!")
            cmbPerusahaan.Focus()
        ElseIf txtPelanggan.Text = "" Or txtPelanggan.Text = Nothing Then
            MsgBox("Silahkan tanyakan ke admin Marketing / Purchasing siapa penerima (att) dari pengiriman yang akan dilakukan",
                   MsgBoxStyle.OkOnly, "Silahkan Lengkapi Data Dulu")
            If MsgBox("Apakah Mau input Manual?", MsgBoxStyle.YesNo, "Input Sendiri?") = vbYes Then
                txtPelanggan.Enabled = True
                txtPelanggan.ReadOnly = False
                txtPelanggan.Focus()
            End If
        ElseIf txtNoOrder.Text = "" Or txtNoOrder.Text = Nothing Then
            MsgBox("Tidak Ada penawaran / order yang dibuat untuk customer ini, tanyakan admin marketing apaka penawaran / order sudah diinputkan ke system ?",
                   MsgBoxStyle.OkOnly, "Data Order Tidak Ada")
        Else
            FrmCariBarang.Text = "Cari Barang"
            FrmCariBarang.ShowDialog()
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Call Reset()
        Proses.CloseConn()
    End Sub

    Private Sub btnCariPerusahaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPerusahaan.Click

        FrmCariPerusahaan.Text = "Pilih Perusahaan CV"
        FrmCariPerusahaan.ShowDialog()
    End Sub


    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click

        If MsgBox("Membatalkan akan menyebabkan data yang sudah di input akan dihapus dan perlu melakukan penginputan lagi?", vbYesNo, "Apakah anda yakin ?") = vbYes Then

            Try

                Proses.OpenConn()
                SQL = "DELETE FROM suratjalan_detail WHERE nosurat = '" & txtNoSurat.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Transaksi sudah dibatalkan...!!", "Pembatalan Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call Reset()
                Call Data_Awal()
                Call Data_Record_Pengiriman()
                btnReset.Enabled = True
                btnBatal.Enabled = False
                btnSimpan.Enabled = False

                Label_TotalBarang.Text = 0

                Proses.CloseConn()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If

    End Sub

    'Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
    '    Try
    '        txtQty_KeyPress(e, sender)
    '    Catch ex As Exception
    '        MessageBox.Show("Ada Kesalahan Detailsnya" & vbNewLine _
    '                        & ex.Message, "Error", MessageBoxButtons.OK)
    '    End Try

    'End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Call Simpan_Surat()
        Proses.CloseConn()
    End Sub

    Private Sub txtAlamat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtQty.Focus()
            txtPelanggan.ReadOnly = False
            txtPelanggan.Enabled = True
        End If
    End Sub


    Private Sub txtPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPelanggan.Click
        txtPelanggan.ReadOnly = False
        txtPelanggan.Enabled = True

    End Sub

    Private Sub loged_in_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loged_in.Click
        MessageBox.Show("Hai " + loged_in.Text + ", Selamat beraktifitas.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahUser.Click

    End Sub

    Private Sub btnFrmATM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmDIN.Click

        'SplashScreen1.Text = "Loading Form Dintara"
        'SplashScreen1.ShowDialog()

        'FrmUtama.Show()
        'Me.Visible = False


        If txtNoOrder.TextLength = 0 Then
            SplashScreen1.Text = "Loading Form Dintara"
            SplashScreen1.ShowDialog()
            FrmUtama.Show()
            Me.Visible = False
        Else
            MessageBox.Show("Selesaikan transaksi dulu atau klik tombol reset ya " + userlogin, "403 Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterSurat.Click

    End Sub
End Class
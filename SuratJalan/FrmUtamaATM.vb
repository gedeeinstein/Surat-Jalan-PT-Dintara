﻿Imports vb = Microsoft.VisualBasic
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

        If str_status > 0 Then
            Proses.OpenConn()
            dtSurat = Proses.ExecuteQuery("SELECT nosurat AS 'NO SURAT', kode AS 'KODE BARANG', kode_lokasi as 'KODE AREA', nama_barang AS 'NAMA BARANG', merk as 'MERK', qty AS 'QTY' FROM suratjalan_detail_atm WHERE nosurat = '" & txtNoSurat.Text & "'")

            DGBarangKirim.DataSource = dtSurat
            DGBarangKirim.Columns(0).Visible = False

            DGBarangKirim.Columns(1).Width = 100
            DGBarangKirim.Columns(2).Width = 70
            DGBarangKirim.Columns(3).Width = 520
            DGBarangKirim.Columns(4).Width = 115 ' MERK
            DGBarangKirim.Columns(5).Width = 60 ' QTY


            DGBarangKirim.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGBarangKirim.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGBarangKirim.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGBarangKirim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Proses.CloseConn()
        Else
            Koneksi_Error() : Exit Sub
        End If

    End Sub

    Sub Data_Pelanggan()

        Try
            If str_status > 0 Then
                Proses.OpenConn()
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
                Proses.CloseConn()
            Else
                Koneksi_Error()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Data_Perusahaan()
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                dtPelanggan = Proses.ExecuteQuery("SELECT nama from pelanggan where kode = '" & vb.Left(cmbPerusahaan.Text, 10) & "'")

                If dtPelanggan.Rows.Count = 0 Then
                Else
                    txtPerusahaan.Text = dtPelanggan.Rows(0).Item("nama")

                End If
                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Data_Barang()
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                dtPelanggan = Proses.ExecuteQuery("SELECT barang.kode, barang.nama FROM barang INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang WHERE tawar02.kode ='" & txtNoOrder.Text & "'")

                If dtPelanggan.Rows.Count = 0 Then
                Else
                    txtBarang.Text = dtPelanggan.Rows(0).Item("nama")
                End If
                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

        Try
            If str_status > 0 Then
                Proses.OpenConn()

                dtSurat = Proses.ExecuteQuery("SELECT * FROM suratjalan_atm order by nosurat desc")
                If dtSurat.Rows.Count = 0 Then
                    txtNoSurat.Text = "001" + "/SJ/" + bln + "/ATM/" + Format(Now, "yyyy")
                Else
                    With dtSurat.Rows(0)
                        txtNoSurat.Text = .Item("nosurat")
                    End With
                    txtNoSurat.Text = Val(Microsoft.VisualBasic.Mid(txtNoSurat.Text, 1, 3)) + 1
                    If Len(txtNoSurat.Text) = 1 Then
                        txtNoSurat.Text = "00" & txtNoSurat.Text + "/SJ/" + bln + "/ATM/" + Format(Now, "yyyy")
                    ElseIf Len(txtNoSurat.Text) = 2 Then
                        txtNoSurat.Text = "0" & txtNoSurat.Text + "/SJ/" + bln + "/ATM/" + Format(Now, "yyyy")
                    ElseIf Len(txtNoSurat.Text) = 3 Then
                        txtNoSurat.Text = "" & txtNoSurat.Text + "/SJ/" + bln + "/ATM/" + Format(Now, "yyyy") '& txtNoSurat.Text & ""
                    End If
                End If
                Proses.CloseConn()
            Else
                Koneksi_Error()
                str_status = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        txtKodeLokasi.Text = ""
        txtQtyBeliCust.Text = ""
        txtMerkBarang.Text = ""
        txtQtyBeliCust.Text = ""
        txtStokGudang.Text = ""
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
    End Sub


    Private Sub FrmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Check_Users()
        Call Data_Awal()
        Call Data_Record_Pengiriman()
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        Call Pengguna()
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
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                Dim myadapter As New MySqlDataAdapter
                Dim sqlquery = "SELECT * FROM suratjalan_detail_atm WHERE nosurat = '" & txtNoSurat.Text & "'"

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
            Else
                Koneksi_Error()
                str_status = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub total_item()
        Dim hitung As Integer
        For baris As Integer = 0 To DGBarangKirim.RowCount - 1
            hitung = hitung + DGBarangKirim.Rows(baris).Cells(5).Value
        Next

        'Label_TotalBarang.Text = 'DGBarangKirim.RowCount - 1
        Label_TotalBarang.Text = hitung

    End Sub

    Private Sub Cek_Barang_Sudah_Kirim()
        Dim SQL = "SELECT kode, nama_barang FROM suratjalan_detail_atm WHERE no_order = '" & Trim(txtNoOrder.Text) & "'"
        'If DGBarangKirim.Item(2) = txtKodeBarang.Text Then

        'End If
    End Sub

    Private Sub Simpan_Details_Surat()
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                SQL = "insert into suratjalan_detail_atm " _
                    & "(nosurat, kode, kode_lokasi, nama_barang, qty, no_order, merk) VALUES " _
                    & "('" & txtNoSurat.Text & "','" & Trim(txtKodeBarang.Text) & "','" & Trim(txtKodeLokasi.Text) & "' " _
                    & ",'" & Rep(txtBarang.Text) & "','" & txtQty.Text & "','" & Trim(txtNoOrder.Text) & "','" & Rep(Trim(txtMerkBarang.Text)) & "')"
                'INSERT INTO `dbatm`.`suratjalan_detail` (`nosurat`, `kode`, `kode_lokasi`, `nama_barang`, `qty`, `no_order`)

                Proses.ExecuteNonQuery(SQL)
                ' MsgBox("Barang ditambahakan", MsgBoxStyle.OkOnly, "Sukses")
                'MessageBox.Show("Barang yang akan dikirimkan sudah ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Data_Record_Pengiriman()
                Proses.CloseConn()
            Else
                Koneksi_Error() : Exit Sub
            End If


        Catch ex As Exception
            MessageBox.Show("Gagal. Tidak diperbolehkan menginput barang yang sama. Masukanlah jumlah quantity. Jika Pertama kali input sudah salah harap ulangi proses dengan tekan tombol batal " + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub

    ' SAMPLE

    'Sub Data_Sepatu()
    '    transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang")
    '    If transaksi_jual.Rows.Count = 0 Then
    '    Else
    '        cmbSepatu.Items.Clear()
    '        With transaksi_jual.Columns(1)
    '            For a = 0 To transaksi_jual.Rows.Count - 1
    '                cmbSepatu.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
    '            Next a
    '        End With
    '    End If
    'End Sub



    Sub Cek_Stok()

        'Dim hitung_qty_order As Double
        'Dim hitung_qty_stok As Double

        'For baris2 As Double = 0 To FrmCariBarang.DGBarang.RowCount - 1
        '    hitung_qty_order = FrmCariBarang.DGBarang.Rows(baris2).Cells(4).Value
        '    hitung_qty_stok = FrmCariBarang.DGBarang.Rows(baris2).Cells(5).Value
        'Next

        'Dim Stok As Double = hitung_qty_stok
        'Dim QtyOrder As Double = hitung_qty_order

        Try
            If txtStokGudang.Text < txtQty.Text Then
                MessageBox.Show("Stok kurang, ", "Tidak ada stok barang", MessageBoxButtons.OKCancel) : Exit Sub
            ElseIf txtQty.Text > txtQtyBeliCust.Text Then
                MessageBox.Show("Input Stok Melebihi Order, ", "Salah Input", MessageBoxButtons.OKCancel) : Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message) : Exit Sub
        End Try


    End Sub

    Sub Tambah_Detail_Kirim()
        Try
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
            Else
                Try
                    If Val(txtStokGudang.Text) < (txtQty.Text) Then
                        MessageBox.Show("Pastikan ada stok barang, tanyakan purchasing / gudang apabila barang belum di update stoknya", "Stok Kurang", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) : Exit Sub
                        'ElseIf Val(txtQty.Text) > Val(txtQtyBeliCust.Text) Then
                    ElseIf Val(txtQty.Text) > Val(txtQtyBeliCust.Text) Then
                        MessageBox.Show("Input qty kirim barang melebihi order dari penawaran, ", "Salah Input Qty", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) : Exit Sub
                    Else
                        Call Simpan_Details_Surat()
                        Call total_item() 'Menjumlahkan Total Barang yang di kirim
                        Call Kurangi_Stock() 'Untuk Mengurangi Stok di Gudang
                        btnReset.Enabled = False
                        txtKodeBarang.Text = Nothing
                        txtKodeLokasi.Text = ""
                        txtBarang.Text = Nothing
                        txtQty.Text = Nothing
                        btnBatal.Enabled = True
                        btnSimpan.Enabled = True
                        txtQtyBeliCust.Text = ""
                        txtMerkBarang.Text = ""
                        txtQtyBeliCust.Text = ""
                        txtStokGudang.Text = ""
                        MySqlConnection.ClearAllPools()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message) : Exit Sub
                End Try
                'Call Simpan_Details_Surat()
                'Call total_item()
                'btnReset.Enabled = False
                'txtKodeBarang.Text = Nothing
                'txtKodeLokasi.Text = ""
                'txtBarang.Text = Nothing
                'txtQty.Text = Nothing
                'btnBatal.Enabled = True
                'btnSimpan.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Gagal Menyimpan", "Program Error") : Exit Sub
        End Try
    End Sub

    Private Sub btnTambah_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Tambah_Detail_Kirim()
    End Sub

    Sub Kurangi_Stock()
        Dim stok_dikurangi = Val(txtStokGudang.Text) - Val(txtQty.Text)
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                SQL = "UPDATE barang set qty = '" & stok_dikurangi & "' where kode = '" & txtKodeBarang.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress

        Try
            If str_status > 0 Then
                Proses.OpenConn()
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
                        Else
                            Tambah_Detail_Kirim()
                            'Try
                            '    ''Cek STOK GUDANG APAKAH LEBIH BESAR DARI QTY KIRIM
                            '    'If Val(txtStokGudang.Text) < (txtQty.Text) Then
                            '    '    MessageBox.Show("Pastikan ada stok barang, tanyakan purchasing / gudang apabila barang belum di update stoknya", "Stok Kurang", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) : Exit Sub
                            '    'ElseIf Val(txtQty.Text) > Val(txtQtyBeliCust.Text) Then
                            '    If Val(txtQty.Text) > Val(txtQtyBeliCust.Text) Then
                            '        MessageBox.Show("Input qty kirim barang melebihi order dari penawaran, ", "Salah Input Qty", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) : Exit Sub
                            '    Else
                            '        Call Simpan_Details_Surat()
                            '        Call total_item()
                            '        ' Call Kurangi_Stock() 'Untuk Mengurangi Stok di Gudang

                            '        btnReset.Enabled = False
                            '        txtKodeBarang.Text = Nothing
                            '        txtKodeLokasi.Text = ""
                            '        txtBarang.Text = Nothing
                            '        txtQty.Text = Nothing
                            '        btnBatal.Enabled = True
                            '        btnSimpan.Enabled = True
                            '        txtQtyBeliCust.Text = ""
                            '        txtMerkBarang.Text = ""
                            '        txtQtyBeliCust.Text = ""
                            '        txtStokGudang.Text = ""
                            '    End If
                            'Catch ex As Exception
                            '    MessageBox.Show(ex.Message) : Exit Sub
                            'End Try
                        End If

                        'Call Simpan_Details_Surat()
                        '' Call Jumlah_QTY()
                        'Call total_item()
                        'btnReset.Enabled = False
                        'txtKodeBarang.Text = Nothing
                        'txtKodeLokasi.Text = ""
                        'txtBarang.Text = Nothing
                        'txtQty.Text = Nothing
                        'btnBatal.Enabled = True
                        'btnSimpan.Enabled = True

                    Case Else
                        e.KeyChar = Chr(0)
                End Select
                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If

        Catch ex As Exception
            MessageBox.Show("Ada kesalahan" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

        If (Not Char.IsControl(e.KeyChar) _
           AndAlso (Not Char.IsDigit(e.KeyChar) _
           AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Dim tgl_buat As Date
    Dim tgl_surat As String

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

            tgl_buat = DateTimePicker1.Value
            tgl_surat = Format(tgl_buat, "yyyy-MM-dd")

            If str_status > 0 Then

                SQL = "insert into suratjalan_atm " _
                    & "(nosurat, kode_perusahaan, nama_perusahaan, att, tanggal, no_order, total, alamat, user) VALUES " _
                    & "('" & txtNoSurat.Text & "','" & Trim(txtKodePerusahaan.Text) & "','" & Rep(txtPerusahaan.Text) & "','" & Rep(txtPelanggan.Text) & "' " _
                    & ",'" + tgl_surat + "','" & Trim(txtNoOrder.Text) & "', '" & Label_TotalBarang.Text & "', '" & Rep(txtAlamat.Text) & "', '" & loged_in.Text & "')"

                If MsgBox("Apakah anda yakin akan menyimpan Data Pengiriman Barang" & vbNewLine & "Data yang sudah disimpan tidak dapat di ubah atau hapus lagi !", vbYesNo, "Konfirmasi") = vbYes Then
                    Proses.OpenConn()
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Data surat pengiriman barang berhasil disimpan. " + vbNewLine + "Harap tunggu sistem akan mencetak surat Anda ", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    FrmRptSPK_ATM.Text = "Cetak Surat Jalan No CV "
                    FrmRptSPK_ATM.ShowDialog()
                    Call Data_Awal()
                    Call Reset()
                    Call No_Surat_Otomatis()
                    Call Data_Record_Pengiriman()

                    btnSimpan.Enabled = False
                    btnBatal.Enabled = False
                    Proses.CloseConn()
                Else
                    MsgBox("Surat belum disimpan, silahkan klik cancel untuk menghapus seluruh data yang diinput, atau lanjutkan input data", MsgBoxStyle.Information, "Tidak disimpan")
                End If
            Else
                Koneksi_Error() : Exit Sub
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
        'If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "Konfirmasi") = vbYes Then
        '    Me.Close()
        '    FrmLogin.Show()
        'End If


        If txtNoOrder.TextLength = 0 Then
            If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "Konfirmasi") = vbYes Then
                Me.Close()
                FrmLogin.txtNama.Text = ""
                FrmLogin.Show()
            End If
        Else
            MessageBox.Show("Selesaikan transaksi dulu atau klik tombol reset ya :( " + userlogin, "403 Forbidden ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        'If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
        '    Me.Close()
        '    FrmLogin.Close()
        '    Application.Exit()
        'End If
        If txtNoOrder.TextLength = 0 Then

            If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
                Me.Close()

                FrmLogin.Close()
                Application.Exit()
            End If
        Else
            MessageBox.Show("Selesaikan transaksi dulu atau klik tombol reset ya :( " + userlogin, "403 Forbidden ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If
    End Sub


    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click

        Try

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
                Try
                    If str_status > 0 Then
                        Proses.OpenConn()
                        FrmCariBarang.Text = "Cari Barang"
                        FrmCariBarang.ShowDialog()
                        Proses.CloseConn()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information) : Exit Sub

                End Try

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ada kesalahan", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub











    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Call Reset()
        MySqlConnection.ClearAllPools()
    End Sub

    Private Sub btnCariPerusahaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPerusahaan.Click

        Try
            If str_status > 0 Then
                Proses.OpenConn()
                FrmCariPerusahaan.Text = "Pilih Perusahaan CV"
                FrmCariPerusahaan.Show()
                Proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try

    End Sub


    Public Sub Kembalikan_Stok()
        Dim i As Integer

        i = DGBarangKirim.CurrentRow.Index

        For i = 0 To DGBarangKirim.Rows.Count - 1
            barang = Proses.ExecuteQuery("SELECT * FROM barang where kode = '" & DGBarangKirim.Item(1, i).Value & "'")
            If barang.Rows.Count = 0 Then
                'do nothing here ?
            Else
                Dim jumlah = CInt(barang.Rows(0).Item("qty")) + CInt(DGBarangKirim.Item(5, i).Value)
                Dim SQL = "UPDATE barang set qty = '" & CInt(jumlah) & "' where kode = '" & DGBarangKirim.Item(1, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
                MessageBox.Show("Transaksi sudah dibatalkan & semua details input telah dihapus", "Pembatalan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Next
    End Sub


    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If MsgBox("Membatalkan akan menyebabkan data yang sudah di input akan dihapus dan perlu melakukan penginputan lagi?", vbYesNo, "Apakah anda yakin ?") = vbYes Then

            Kembalikan_Stok() ' MENGEMBALIKAN STOK YANG SUDAH DI KURANGI KARENA BARANG DIPILIH AKAN DI KELUARKAN DARI STOK DATABASE


            SQL = "DELETE FROM suratjalan_detail_atm WHERE nosurat = '" & txtNoSurat.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Transaksi sudah dibatalkan & semua details input telah dihapus", "Pembatalan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Reset()
            Call Data_Awal()
            Call Data_Record_Pengiriman()
            btnReset.Enabled = True
            btnBatal.Enabled = False
            btnSimpan.Enabled = False
            Label_TotalBarang.Text = 0
            Proses.CloseConn()
            MySqlConnection.ClearAllPools()
        End If

    End Sub


    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Call Simpan_Surat()
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
        MessageBox.Show("Hai :) " + loged_in.Text + ", Selamat beraktifitas.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahUser.Click
        FrmTambahUser.ShowDialog()
    End Sub

    Private Sub btnFrmATM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmDIN.Click

        'SplashScreen1.Text = "Loading Form Dintara"
        'SplashScreen1.ShowDialog()

        'FrmUtama.Show()
        'Me.Visible = False
        Proses.CloseConn()

        If txtNoOrder.TextLength = 0 Then
            SplashScreen1.Text = "Loading Form Dintara"
            SplashScreen1.ShowDialog()
            FrmUtama.Show()
            Me.Close()
        Else
            MessageBox.Show("Selesaikan transaksi dulu atau klik tombol reset ya " + userlogin, "403 Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        End If

    End Sub

    Private Sub btnMasterSurat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterSurat.Click
        Try
            If str_status > 0 Then
                FrmMasterSurat.Text = "Riwayat Surat Jalan ATM"
                FrmMasterSurat.ShowDialog()

                MySqlConnection.ClearAllPools()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try


    End Sub

    Private Sub instagram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instagram.Click
        Try
            InstagramOpen()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub fb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fb.Click
        Try
            FaceboookOpen()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub twitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twitter.Click
        Try
            TwitterOpen()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub gplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gplus.Click
        Try
            GplusOpen()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub linkedin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linkedin.Click
        Try
            LinkedinOpen()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub whatsapp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whatsapp.Click
        Try
            If MsgBox("Apakah anda yakin akan menghubungi Author via WhatsApp ? Anda akan dialihkan ke halaman web.whatsapp.com", vbYesNo, "Buka Browser") = vbYes Then
                WhatsappSend()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub maps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maps.Click
        Try
            If MsgBox("Anda akan dialihkan ke halaman maps dari lokasi CV Angkasa Teknik Mandiri " + vbNewLine + "Lanjutkan ?", vbYesNo, "Buka Lokasi Perusahaan") = vbYes Then
                GmapsOpen()
                AuthorIG()
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub gmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gmail.Click
        Try
            If MsgBox("Apakah anda yakin akan Mengirim email ke dintara.kitchen@gmail.com ? Default email akan dibuka sekarang ?", vbYesNo, "Kirim Email") = vbYes Then

                GmailSend()
                AuthorIG()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal Mengirim Email" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub outlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outlook.Click
        Try
            If MsgBox("Apakah anda yakin akan Mengirim email ke it@dintarakitchen.co.id ? Default email akan dibuka sekarang ?", vbYesNo, "Kirim Email") = vbYes Then

                OutlookSend()
                '("OUTLOOK")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal Mengirim Email" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub txtKodeLokasi_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtKodeLokasi.MouseDoubleClick
        Try
            If MsgBox("Apakah anda ingin mengubah kode lokasi dari data yang sudah diinput oleh marketing ?", vbYesNo, "Ganti Data") = vbYes Then
                txtKodeLokasi.ReadOnly = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtQty_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtQty.MouseDoubleClick
        txtQty.ReadOnly = False
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Kurangi_Details()
    End Sub

    Public Sub KembalikanStokJikaDetailDiHapus()
        Dim i As Integer

        i = DGBarangKirim.CurrentRow.Index
        barang = Proses.ExecuteQuery("select * from barang where kode = '" & DGBarangKirim.Item(1, i).Value & "'")
        Dim jumlah = CInt(barang.Rows(0).Item("qty")) + CInt(DGBarangKirim.Item(5, i).Value)
        Dim SQL2 = "UPDATE barang set qty ='" & CInt(jumlah) & "' where kode = '" & DGBarangKirim.Item(1, i).Value & "'"
        Proses.ExecuteNonQuery(SQL2)
    End Sub

    Public Sub Kurangi_Details()
        Dim i As Integer
        If DGBarangKirim.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang bisa dihapus", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        Else
            Try

                i = DGBarangKirim.SelectedRows(0).Index
                If MsgBox("Hapus Detail Barang ", vbYesNo, "Apakah anda yakin ?") = vbYes Then

                    KembalikanStokJikaDetailDiHapus()

                    SQL = "DELETE FROM suratjalan_detail_atm WHERE nosurat = '" & DGBarangKirim.Item(0, i).Value & "' AND kode = '" & DGBarangKirim.Item(1, i).Value & "' and kode_lokasi = '" & DGBarangKirim.Item(2, i).Value & "' "
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Barang Sudah dihapus dari detail pengiriman", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Data_Record_Pengiriman()
                    Call Data_Awal()
                    Jumlah_QTY()
                    txtBarang.Text = ""
                    MySqlConnection.ClearAllPools()
                    If DGBarangKirim.RowCount = 0 Then
                        btnReset.Enabled = True
                        btnSimpan.Enabled = False
                        btnBatal.Enabled = False
                    End If
                Else
                    MessageBox.Show("Barang batal di hapus", "Batal Menghapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Tidak ada barang yang terisa untuk dihapus " + userlogin + " :( " + vbNewLine + "Jangan paksakan aplikasi sederhana ini berbuat seperti itu ya :(", "Maaf Sudah Dihapus Semua", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            Finally
                MySqlConnection.ClearAllPools()
            End Try
        End If
    End Sub

    Private Sub btnStok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStok.Click
        Try
            If str_status > 0 Then
                FrmMasterBarang.Text = "MASTER DATA BARANG"
                FrmMasterBarang.ShowDialog()

                MySqlConnection.ClearAllPools()
            Else
                str_status = 0
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub

    Public Sub Check_Users()
        Dim masuk, sql2 As DataTable
        Dim con As New ClsKoneksi
        Try
            con.OpenConn()
            masuk = con.ExecuteQuery("SELECT a.username, a.nama_user, b.level_name, b.jabatan FROM karyawan a INNER JOIN suratjalan_level b ON a.level_id = b.level_id WHERE a.level_id='2'")
            If masuk.Rows.Count = 0 Then
                MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
                Call Reset()
                : Exit Sub
            Else
                Me.txtAdminAR.Text = masuk.Rows(0).Item("nama_user").ToString
            End If

            sql2 = con.ExecuteQuery("SELECT a.username, a.nama_user, b.level_name, b.jabatan FROM karyawan a INNER JOIN suratjalan_level b ON a.level_id = b.level_id WHERE a.level_id='3'")
            If sql2.Rows.Count = 0 Then
                MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
                Call Reset()
                : Exit Sub
            Else
                Me.txtGudang.Text = sql2.Rows(0).Item("nama_user").ToString
            End If

        Catch ex As Exception
            MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
        Finally

            con.CloseConn()
            MySqlConnection.ClearAllPools()
        End Try
    End Sub

End Class

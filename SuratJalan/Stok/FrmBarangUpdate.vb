Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms



Public Class FrmBarangUpdate
    Dim Proses As New ClsKoneksi
    Dim barang_saya, barangku As DataTable
    Dim SQL As String
    Dim Data As DataSet

    Public Sub data_barang()

        'barang_saya = Proses.ExecuteQuery("SELECT kode as 'KODE', merk as 'Merk / Brand' FROM merk ORDER BY kode ASC")

                'SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'Brand', a.hpp AS 'HPP', a.hpp_awal AS 'HPP Awal', a.harju AS 'Harga Jual', a.qty AS 'Stok', a.ket AS 'KET', b.kode AS 'KODE KAT', c.kode AS 'KODE MERK' FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode INNER JOIN merk c ON a.kode_merk = c.kode ORDER BY a.nama ASC

        'barang_saya = Proses.ExecuteQuery("SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'BRAND', a.hpp AS 'Harga Pokok', a.harju AS 'Harga Jual', a.qty AS 'Stok' FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode INNER JOIN merk c ON a.kode_merk = c.kode ORDER BY a.kode ASC")
        'barang_saya = Proses.ExecuteQuery("SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'BRAND', a.hpp AS 'HPP', a.hpp_awal AS 'HPP AWAL', a.harju AS 'Harga Jual', a.qty AS 'Jumlah', a.ket AS 'KETERANGAN' FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode INNER JOIN merk c ON a.kode_merk = c.kode ORDER BY a.nama ASC")

        barang_saya = Proses.ExecuteQuery("SELECT a.kode AS 'Kode Barang', " _
                                        & " a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'Brand', a.hpp AS 'HPP', " _
                                        & " a.hpp_awal AS 'HPP Awal', a.harju AS 'Harga Jual', a.qty AS 'Stok', a.w AS 'W', a.d AS 'D', a.h AS 'H', " _
                                        & " a.ket AS 'KET', " _
                                        & " b.kode AS 'KODE KAT', c.kode AS 'KODE MERK' " _
                                        & " FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode " _
                                        & " INNER JOIN merk c ON a.kode_merk = c.kode ORDER BY a.nama ASC")


        Me.DGBarang.DataSource = barang_saya

        DGBarang.Columns(12).Visible = False ' KODE KATEGORI 
        DGBarang.Columns(13).Visible = False ' KODE MERK

        Me.DGBarang.Columns(0).Width = 70  ' KODE Barang
        Me.DGBarang.Columns(1).Width = 350 ' NAMA Barang
        Me.DGBarang.Columns(2).Width = 80 ' KATEGORI
        Me.DGBarang.Columns(3).Width = 80 ' BRAND
        Me.DGBarang.Columns(7).Width = 50 ' STOK
        Me.DGBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Me.DGBarang.Columns(8).Width = 50 ' width 
        Me.DGBarang.Columns(9).Width = 50 ' depth 
        Me.DGBarang.Columns(10).Width = 50 ' height 

        Me.DGBarang.Columns(11).Width = 200 ' KETERANGAN
        Me.DGBarang.Columns(12).Width = 50 ' KODE KATEGORI 
        Me.DGBarang.Columns(13).Width = 50 ' KODE MERK
        
        Me.DGBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

       
        DGBarang.GridColor = Color.White
        DGBarang.DefaultCellStyle.ForeColor = Color.White
        DGBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.Green
        DGBarang.RowsDefaultCellStyle.BackColor = Color.Blue

    End Sub

    Public Sub KodeBarang_Auto()
        barang_saya = Proses.ExecuteQuery("SELECT * FROM barang WHERE kode='201889514'")
        Dim Tahun As Integer = Date.Now.Year
        Dim Bulan As String = Date.Now.Month
        'Dim brg_kode As Integer

        If barang_saya.Rows.Count = 0 Then
            txtKodeBarang.Text = Tahun & Bulan
            '201889514
            '20188000515
            '201880896
            '201889459 TEST BARANG
        Else
            With barang_saya.Rows(0)
                txtKodeBarang.Text = .Item("kode")
            End With
            txtKodeBarang.Text = Val(Microsoft.VisualBasic.Mid(txtKodeBarang.Text, 5, 3)) + 1

            If Len(txtKodeBarang.Text) = 1 Then
                txtKodeBarang.Text = Tahun & Bulan & "000" & txtKodeBarang.Text & ""
            ElseIf Len(txtKodeBarang.Text) = 2 Then
                txtKodeBarang.Text = Tahun & Bulan & "00" & txtKodeBarang.Text & ""
            ElseIf Len(txtKodeBarang.Text) = 3 Then
                txtKodeBarang.Text = Tahun & Bulan & "0" & txtKodeBarang.Text & ""
            End If
        End If
        Proses.CloseConn()
    End Sub

    Sub Atur()
        Call data_barang()
        Call KodeBarang_Auto()
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        txtNamaBarang.Focus()
        label_info.Text = "Tambah Data Barang"
        label_info.ForeColor = Color.LawnGreen

        txtKategori.Enabled = False
        txtMerk.Enabled = False

        txtKodeGol.Enabled = False
        txtKodeMerk.Enabled = False

    End Sub

    Private Sub FrmBarangUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KodeBarang_Auto()
        data_barang()
        Call Atur()

        'Me.WindowState = FormWindowState.Maximized
        'merk_auto_complete()
    End Sub


    Private Sub DGBarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick, DGBarang.CellContentClick

        '    SQL = "SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', " _
        '        & " c.merk AS 'Brand', a.hpp AS 'HPP', a.hpp_awal AS 'HPP Awal', a.harju AS 'Harga Jual', " _
        '        & " a.qty AS 'Stok', a.w AS 'W', a.d AS 'D', a.h AS 'H', a.ket AS 'KET', b.kode AS 'KODE KAT', c.kode AS 'KODE MERK' " _
        '        & " FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode " _
        '        & " INNER JOIN merk c ON a.kode_merk = c.kode " _
        '        & " WHERE a.nama LIKE '%" & Rep(txtCari.Text) & "%' ORDER BY a.nama ASC"


        txtKodeBarang.Text = Trim(DGBarang.SelectedCells(0).Value)
        txtNamaBarang.Text = Trim(DGBarang.SelectedCells(1).Value)
        txtKategori.Text = Trim(DGBarang.SelectedCells(2).Value)
        txtMerk.Text = Trim(DGBarang.SelectedCells(3).Value)
        txtHPP.Text = Trim(DGBarang.SelectedCells(4).Value)
        txtHargaJual.Text = Trim(DGBarang.SelectedCells(6).Value)
        txtStok.Text = Trim(DGBarang.SelectedCells(7).Value)
        txtWidth.Text = Trim(DGBarang.SelectedCells(8).Value)
        txtDepth.Text = Trim(DGBarang.SelectedCells(9).Value)
        txtHeight.Text = Trim(DGBarang.SelectedCells(10).Value)
        txtKet.Text = Trim(DGBarang.SelectedCells(11).Value)

        txtKodeGol.Text = Trim(DGBarang.SelectedCells(12).Value)
        txtKodeMerk.Text = Trim(DGBarang.SelectedCells(13).Value)

        txtNamaBarang.Focus()
        'btnHapus.Enabled = True
        btnEdit.Enabled = True
        btnTambah.Enabled = False
        txtKodeBarang.Enabled = False

        txtKategori.Enabled = False
        txtMerk.Enabled = False

        txtKodeGol.Enabled = False
        txtKodeMerk.Enabled = False

        label_info.Text = "Edit Data Barang"
        label_info.ForeColor = Color.Red

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnBatal()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Cari()
    End Sub

    Sub btnBatal()
        'Atur()
        KodeBarang_Auto()
        txtNamaBarang.Text = Nothing
        txtKategori.Text = Nothing
        txtMerk.Text = Nothing
        txtHPP.Text = Nothing
        txtHargaJual.Text = Nothing
        txtStok.Text = Nothing
        txtWidth.Text = Nothing
        txtDepth.Text = Nothing
        txtHeight.Text = Nothing
        txtKet.Text = Nothing
        txtKodeGol.Text = Nothing
        txtKodeMerk.Text = Nothing

        btnTambah.Enabled = True
        btnEdit.Enabled = False

        'btnEdit.BackColor = Color.Black
        'btnEdit.ForeColor = Color.White

        txtNamaBarang.Focus()

        label_info.Text = "Tambah Data Barang"
        label_info.ForeColor = Color.LawnGreen

    End Sub

    Sub Cari()

        'barang_saya = Proses.ExecuteQuery("SELECT a.kode AS 'Kode Barang', " _
        '                        & " a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'Brand', a.hpp AS 'HPP', " _
        '                        & " a.hpp_awal AS 'HPP Awal', a.harju AS 'Harga Jual', a.qty AS 'Stok', a.w AS 'W', a.d AS 'D', a.h AS 'H', a.ket AS 'KET', " _
        '                        & " b.kode AS 'KODE KAT', c.kode AS 'KODE MERK' " _
        '                        & " FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode " _
        '                        & " INNER JOIN merk c ON a.kode_merk = c.kode ORDER BY a.nama ASC")


        Try
            SQL = "SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', " _
                & " c.merk AS 'Brand', a.hpp AS 'HPP', a.hpp_awal AS 'HPP Awal', a.harju AS 'Harga Jual', " _
                & " a.qty AS 'Stok', a.w AS 'W', a.d AS 'D', a.h AS 'H', a.ket AS 'KET', b.kode AS 'KODE KAT', c.kode AS 'KODE MERK' " _
                & " FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode " _
                & " INNER JOIN merk c ON a.kode_merk = c.kode " _
                & " WHERE a.nama LIKE '%" & Rep(txtCari.Text) & "%' ORDER BY a.nama ASC"

            barang_saya = Proses.ExecuteQuery(SQL)

            Try

                Me.DGBarang.DataSource = barang_saya
                Proses.OpenConn()

                DGBarang.Columns(12).Visible = False ' KODE KATEGORI 
                DGBarang.Columns(13).Visible = False ' KODE MERK

                Me.DGBarang.Columns(0).Width = 70  ' KODE Barang
                Me.DGBarang.Columns(1).Width = 350 ' NAMA Barang
                Me.DGBarang.Columns(2).Width = 80 ' KATEGORI
                Me.DGBarang.Columns(3).Width = 80 ' BRAND
                Me.DGBarang.Columns(7).Width = 50 ' STOK
                Me.DGBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                Me.DGBarang.Columns(8).Width = 50 ' width 
                Me.DGBarang.Columns(9).Width = 50 ' depth 
                Me.DGBarang.Columns(10).Width = 50 ' Height 

                Me.DGBarang.Columns(11).Width = 200 ' KETERANGAN
                Me.DGBarang.Columns(12).Width = 50 ' KODE KATEGORI 
                Me.DGBarang.Columns(13).Width = 50 ' KODE MERK

                'Me.DGBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Me.DGBarang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                'DGBarang.GridColor = Color.White
                'DGBarang.DefaultCellStyle.ForeColor = Color.White
                'DGBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.Green
                'DGBarang.RowsDefaultCellStyle.BackColor = Color.Blue


                Proses.OpenConn()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConnection.ClearAllPools()
            End Try

            Me.DGBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.DGBarang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGBarang.GridColor = Color.White
            DGBarang.DefaultCellStyle.ForeColor = Color.White
            DGBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.Green
            DGBarang.RowsDefaultCellStyle.BackColor = Color.Blue
            Proses.CloseConn()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConnection.ClearAllPools()
        End Try
    End Sub



    '#Region "Auto Merk"



    '    Sub merk_auto_complete()

    '        Proses.OpenConn()

    '        Using Cmd As New MySqlCommand("SELECT DISTINCT (merk) FROM merk", Proses.Cn)

    '            Using rd As MySqlDataReader = Cmd.ExecuteReader
    '                While rd.Read
    '                    With txtKodeMerk
    '                        .AutoCompleteMode = AutoCompleteMode.Suggest
    '                        .AutoCompleteCustomSource.Add(rd.Item(0))
    '                        .AutoCompleteSource = AutoCompleteSource.CustomSource
    '                    End With

    '                End While
    '                rd.Close()
    '            End Using

    '        End Using
    '        Proses.CloseConn()

    '    End Sub


    '#End Region



    Sub CariMerk()
        Try
            'If str_status > 0 Then
            Proses.OpenConn()
            FrmMerk.Text = "Pilih Merk"
            FrmMerk.ShowDialog()
            Proses.CloseConn()
            'Else
            '    MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            '    str_status = 0
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub

    Sub Cari_Kategori()
        Try
            'If str_status > 0 Then
            Proses.OpenConn()
            FrmKategori.Text = "Pilih Kategori"
            FrmKategori.ShowDialog()
            Proses.CloseConn()
            'Else
            '    MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            '    str_status = 0
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub


    Private Sub cariKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariKategori.Click
        Cari_Kategori()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMerk.Click
        CariMerk()
    End Sub

End Class
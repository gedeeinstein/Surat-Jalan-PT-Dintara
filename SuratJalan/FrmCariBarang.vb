Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmCariBarang
    Dim Proses As New ClsKoneksi
    Dim barangku, mysurat As DataTable
    Dim SQL As String
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String

    Sub No_Order()

        Try

            Select Case Me.Text
                Case "Cari Barang"
                    txtNoOrder.Text = FrmUtamaATM.txtNoOrder.Text.ToString

                Case "Pilih Barang"
                    txtNoOrder.Text = FrmUtama.txtNoOrder.Text.ToString

            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    Sub Compare_Barang()
        Dim SQL2 As String

        SQL = "SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG',  " _
                & "tawar02.qty AS 'QTY PESANAN' FROM barang " _
                & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
                & "WHERE tawar02.kode ='SA-0000001871' ORDER BY barang.nama ASC"

        SQL2 = "SELECT kode AS 'Kode Barang',  " _
                & " nama_barang AS 'Nama Barang',  " _
                & "qty AS 'QTY' " _
                & "FROM suratjalan_detail_atm WHERE no_order = 'SA-0000001871' ORDER BY nama_barang ASC"



    End Sub

    Sub Data_Barang()
        barangku = Proses.ExecuteQuery("SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.merk as 'MERK', tawar02.kode_lokasi AS 'KODE AREA', tawar02.qty as 'QTY PESANAN', barang.qty as 'STOK GUDANG' FROM barang " _
                                     & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
                                     & "WHERE tawar02.kode ='" & txtNoOrder.Text & "' ORDER BY barang.nama ASC")

        Me.DGBarang.DataSource = barangku
        Me.DGBarang.Columns(0).Width = 130 ' KODE BARANG
        Me.DGBarang.Columns(1).Width = 550 ' NAMA BARANG
        Me.DGBarang.Columns(2).Width = 140 ' MERK
        Me.DGBarang.Columns(3).Width = 120 ' KODE AREA
        Me.DGBarang.Columns(4).Width = 100 ' QTY
        Me.DGBarang.Columns(5).Width = 100 ' STOCK GUDANG

        Me.DGBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGBarang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGBarang.GridColor = Color.White
        DGBarang.DefaultCellStyle.ForeColor = Color.White
        DGBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkBlue
        DGBarang.RowsDefaultCellStyle.BackColor = Color.Black
        total_item()
    End Sub

    Sub Details_Surat_Jalan()
        Try
            Select Case Me.Text

                Case "Cari Barang"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        'SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan"
                        SQL = "SELECT nosurat AS 'No Surat', kode AS 'Kode Barang', kode_lokasi AS 'Kode Area', nama_barang AS 'Nama Barang', qty AS 'QTY', no_order AS 'No Order', merk AS 'Merk' FROM suratjalan_detail_atm where no_order = '" & txtNoOrder.Text & "' ORDER BY nama_barang ASC"
                        mysurat = Proses.ExecuteQuery(SQL)

                        Me.DGBarangTerkirim.DataSource = mysurat
                        Me.DGBarangTerkirim.Columns(0).Width = 120 ' NO SURAT
                        Me.DGBarangTerkirim.Columns(1).Width = 130 ' KD BRG
                        Me.DGBarangTerkirim.Columns(2).Width = 100 ' KD AREA
                        Me.DGBarangTerkirim.Columns(3).Width = 420 ' NAMA BARANG
                        Me.DGBarangTerkirim.Columns(4).Width = 70  ' QTY
                        Me.DGBarangTerkirim.Columns(5).Width = 150 ' NO ORDER
                        Me.DGBarangTerkirim.Columns(6).Width = 150 ' MERK
                        'Me.DGDetailsMasterSurat.Columns(7).Width = 200
                        '1159
                        Me.DGBarangTerkirim.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                        Dim myadapter As New MySqlDataAdapter
                        Dim sqlquery = "SELECT * FROM suratjalan_detail_atm"
                        Dim mycommand As New MySqlCommand
                        mycommand.Connection = Proses.Cn
                        mycommand.CommandText = SQL
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
                        Label4.Text = Val(totalbarang)

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                    End If

                Case "Pilih Barang"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        'SQL = "SELECT nosurat AS 'No Surat', nama_perusahaan AS 'Perusahaan', att AS 'Attn.', tanggal AS 'Tanggal Kirim', no_order AS 'No Order', USER AS 'Dibuat Oleh' FROM suratjalan"
                        SQL = "SELECT nosurat AS 'No Surat', kode AS 'Kode Barang', kode_lokasi AS 'Kode Area', nama_barang AS 'Nama Barang', qty AS 'QTY', no_order AS 'No Order', merk AS 'Merk' FROM suratjalan_detail where no_order = '" & txtNoOrder.Text & "'ORDER BY nama_barang ASC"
                        mysurat = Proses.ExecuteQuery(SQL)

                        Me.DGBarangTerkirim.DataSource = mysurat
                        Me.DGBarangTerkirim.Columns(0).Width = 120 ' NO SURAT
                        Me.DGBarangTerkirim.Columns(1).Width = 130 ' KD BRG
                        Me.DGBarangTerkirim.Columns(2).Width = 100 ' KD AREA
                        Me.DGBarangTerkirim.Columns(3).Width = 420 ' NAMA BARANG
                        Me.DGBarangTerkirim.Columns(4).Width = 70  ' QTY
                        Me.DGBarangTerkirim.Columns(5).Width = 150 ' NO ORDER
                        Me.DGBarangTerkirim.Columns(6).Width = 150 ' MERK
                        'Me.DGDetailsMasterSurat.Columns(7).Width = 200
                        '1192

                        Me.DGBarangTerkirim.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGBarangTerkirim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                        Dim myadapter As New MySqlDataAdapter
                        Dim sqlquery = "SELECT * FROM suratjalan_detail_atm"
                        Dim mycommand As New MySqlCommand
                        mycommand.Connection = Proses.Cn
                        mycommand.CommandText = SQL
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
                        Label4.Text = Val(totalbarang)

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub total_item()
        Dim hitung As Integer
        For baris As Integer = 0 To DGBarang.RowCount - 1
            hitung = hitung + DGBarang.Rows(baris).Cells(4).Value
        Next

        lbl_totalbarang.Text = hitung

    End Sub


    


    Private Sub FrmCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        No_Order()
        Data_Barang()
        Details_Surat_Jalan()
        'Compare_Barang()
    End Sub


    Public Sub Input_Qty()
        'Dim Jumlah As Double = 0

        'Try
        '    Select Case Me.Text
        '        Case "Cari Barang"
        '            Jumlah = InputBox("Masukan Jumlah / Qty Barang yang akan dikirimkan", "Input QTY", , , )
        '            FrmUtamaATM.txtQty.Text = Jumlah
        '            FrmUtamaATM.txtQty.Focus()
        '        Case "Pilih Barang"
        '            Jumlah = InputBox("Masukan Jumlah / Qty Barang yang akan dikirimkan", "Input QTY", , , )
        '            FrmUtama.txtQty.Text = Jumlah
        '            FrmUtama.txtQty.Focus()
        '    End Select
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'Dim hitung As Integer
        'For baris2 As Integer = 0 To DGBarang.RowCount - 1
        '    hitung = hitung + DGBarang.Rows(baris2).Cells(4).Value
        'Next
        'lbl_totalbarang.Text = hitung


        'If DGBarang.Rows(baris).Cells(4).Value < DGBarang.Rows(baris).Cells(4).Value Then


        'End If

        Dim hitung_qty_order As Double
        Dim hitung_qty_stok As Double

        hitung_qty_order = DGBarang.SelectedCells(4).Value
        hitung_qty_stok = DGBarang.SelectedCells(5).Value

        Dim Stok As Double = hitung_qty_stok
        Dim QtyOrder As Double = hitung_qty_order


        'Try
        '    If Stok < QtyOrder Then
        '        MessageBox.Show("Stok kurang, ", "Tidak ada stok barang", MessageBoxButtons.OKCancel)
        '    ElseIf QtyOrder > QtyOrder Then

        '    End If
        'Catch ex As Exception

        'End Try

        Select Case Me.Text
            Case "Cari Barang"
                FrmUtamaATM.txtQtyBeliCust.Text = QtyOrder
                FrmUtamaATM.txtStokGudang.Text = Stok

                Trim(FrmUtamaATM.txtStokGudang.Text)
                Trim(FrmUtamaATM.txtQtyBeliCust.Text)
               


            Case "Pilih Barang"
                FrmUtama.txtQtyBeliCust.Text = QtyOrder
                FrmUtama.txtStokGudang.Text = Stok
                Trim(FrmUtama.txtStokGudang.Text)
                Trim(FrmUtama.txtQtyBeliCust.Text)
                

        End Select
    End Sub

    


    Private Sub DGBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick

        Try

            Dim Jumlah As String
            If str_status > 0 Then

                Select Case Me.Text


                    Case "Cari Barang"
                        
                        Jumlah = InputBox("Masukan Jumlah / Qty Barang yang akan dikirimkan", "Input QTY", , , )
                        If Jumlah.Length > 0 Then
                            FrmUtamaATM.txtQty.Text = Val(Jumlah)
                            FrmUtamaATM.btnTambah.Focus()

                            FrmUtamaATM.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                            FrmUtamaATM.txtBarang.Text = DGBarang.SelectedCells(1).Value
                            FrmUtamaATM.txtMerkBarang.Text = DGBarang.SelectedCells(2).Value
                            FrmUtamaATM.txtKodeLokasi.Text = DGBarang.SelectedCells(3).Value

                            Input_Qty()

                            Trim(FrmUtamaATM.txtBarang.Text)
                            Trim(FrmUtamaATM.txtKodeLokasi.Text)
                            Trim(FrmUtamaATM.txtMerkBarang.Text)

                            Me.Close()

                            FrmUtamaATM.txtQty.Focus()
                            FrmUtamaATM.btnCariPerusahaan.Enabled = False

                        ElseIf Jumlah = "" Then
                            MessageBox.Show("Barang Batal dipilih", "Masukan Qty Barang")
                        Else
                            MessageBox.Show("Inputan Salah")
                        End If

                        

                    Case "Pilih Barang"

                        Jumlah = InputBox("Masukan Jumlah / Qty Barang yang akan dikirimkan", "Input QTY", , , )
                        If Jumlah.Length > 0 Then

                            FrmUtama.txtQty.Text = Val(Jumlah)
                            FrmUtama.btnTambah.Focus()


                            FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                            FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
                            FrmUtama.txtMerkBarang.Text = DGBarang.SelectedCells(2).Value
                            FrmUtama.txtKodeLokasi.Text = DGBarang.SelectedCells(3).Value

                            Input_Qty()

                            Trim(FrmUtama.txtBarang.Text)
                            Trim(FrmUtama.txtKodeLokasi.Text)
                            Trim(FrmUtama.txtMerkBarang.Text)

                            Me.Close()

                            FrmUtama.txtQty.Focus()
                            FrmUtama.btnCariPerusahaan.Enabled = False

                        ElseIf Jumlah = "" Then
                            MessageBox.Show("Barang Batal dipilih", "Masukan Qty Barang")
                        Else
                            MessageBox.Show("Inputan Salah")
                        End If
                        

                End Select
                MySqlConnection.ClearAllPools()
            Else
                MessageBox.Show("Kesalahan konektivitas", "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    'Public Sub PilihBarang()

    '    Try
    '        Select Case Me.Text

    '            Case "ATM"
    '                FrmUtamaATM.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
    '                FrmUtamaATM.txtBarang.Text = DGBarang.SelectedCells(1).Value
    '                Trim(FrmUtamaATM.txtBarang.Text)

    '                Me.Close()
    '                FrmUtamaATM.txtQty.Focus()
    '                FrmUtamaATM.btnCariPerusahaan.Enabled = False
    '                MySqlConnection.ClearAllPools()
    '            Case "PT"
    '                FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
    '                FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
    '                Trim(FrmUtama.txtBarang.Text)

    '                Me.Close()
    '                FrmUtama.txtQty.Focus()
    '                FrmUtama.btnCariPerusahaan.Enabled = False
    '                MySqlConnection.ClearAllPools()

    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show("Batal" + vbNewLine, "Bara", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
    '    End Try


    'End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        DGBarang_DoubleClick(sender, e)
        FrmUtama.txtQty.Focus()

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class
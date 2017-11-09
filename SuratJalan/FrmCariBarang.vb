Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmCariBarang
    Dim Proses As New ClsKoneksi
    Dim barangku As DataTable
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

        'txtNoOrder.Text = FrmUtama.txtNoOrder.Text.ToString

        'txtNoOrder.Text = FrmUtama.txtNoOrder.Text.ToString
            'FrmUtama.txtNoOrder.Text = txtNoOrder.Text
    End Sub


    Sub Data_Barang()
        'barangku = Proses.ExecuteQuery("SELECT barang.kode as 'KODE BARANG', barang.nama as 'NAMA BARANG' FROM barang " _
        '                             & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
        '                             & "WHERE tawar02.kode ='" & txtNoOrder.Text & "'")

        'OLD QUERY ABOVE

        'New Query
        'SELECT tawar02.kode_lokasi AS 'KL', barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.qty as 'QTY PESANAN' FROM barang
        'INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang 


        barangku = Proses.ExecuteQuery("SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.merk as 'MERK', tawar02.kode_lokasi AS 'KL', tawar02.qty as 'QTY PESANAN', barang.qty as 'STOK GUDANG' FROM barang " _
                                     & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
                                     & "WHERE tawar02.kode ='" & txtNoOrder.Text & "'")

        Me.DGBarang.DataSource = barangku
        Me.DGBarang.Columns(0).Width = 150
        Me.DGBarang.Columns(1).Width = 540
        Me.DGBarang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGBarang.GridColor = Color.White
        DGBarang.DefaultCellStyle.ForeColor = Color.White
        DGBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkBlue
        DGBarang.RowsDefaultCellStyle.BackColor = Color.Black


        Proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        'Dim sqlquery = "SELECT barang.kode as 'KODE BARANG', barang.nama as 'NAMA BARANG' FROM barang " _
        '                             & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
        '                             & "WHERE tawar02.kode ='" & txtNoOrder.Text & "'"

        Dim sqlquery = "SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.merk as 'MERK', tawar02.kode_lokasi AS 'KL', tawar02.qty as 'QTY PESANAN', barang.qty as 'STOK GUDANG' FROM barang " _
                                     & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
                                     & "WHERE tawar02.kode ='" & txtNoOrder.Text & "'"

        'Dim mycommand As New MySqlCommand
        'mycommand.Connection = Proses.Cn
        'mycommand.CommandText = sqlquery
        'myadapter.SelectCommand = mycommand
        'Dim totalbarang As Integer
        'Dim mydata As MySqlDataReader
        'mydata = mycommand.ExecuteReader()

        'totalbarang = 0
        'If (mydata.HasRows) Then
        '    While (mydata.Read)
        '        totalbarang = totalbarang + 1
        '    End While
        'End If
        'lbl_totalbarang.Text = Val(totalbarang)
        total_item()
        Proses.CloseConn()
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
                'FrmUtama.txtQtyBeliCust.Text = QtyOrder
                'FrmUtama.txtStokGudang.Text = Stok
        End Select
    End Sub

    Private Sub DGBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick

        Try
            Select Case Me.Text


                Case "Cari Barang"
                    FrmUtamaATM.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtamaATM.txtBarang.Text = DGBarang.SelectedCells(1).Value
                    FrmUtamaATM.txtMerkBarang.Text = DGBarang.SelectedCells(2).Value
                    FrmUtamaATM.txtKodeLokasi.Text = DGBarang.SelectedCells(3).Value

                    Input_Qty()

                    Trim(FrmUtamaATM.txtBarang.Text)
                    Trim(FrmUtamaATM.txtKodeLokasi.Text)
                    Trim(FrmUtamaATM.txtMerkBarang.Text)

                    Me.Close()
                    'Trim(FrmUtamaATM.txtBarang.Text)
                    'Trim(FrmUtamaATM.txtKodeLokasi.Text)
                    FrmUtamaATM.txtQty.Focus()
                    FrmUtamaATM.btnCariPerusahaan.Enabled = False

                Case "Pilih Barang"
                    FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
                    'FrmUtama.txtMerkBarang.Text = DGBarang.SelectedCells(2).Value
                    FrmUtama.txtKodeLokasi.Text = DGBarang.SelectedCells(3).Value

                    Input_Qty()

                    Trim(FrmUtama.txtBarang.Text)
                    Trim(FrmUtama.txtKodeLokasi.Text)
                    'Trim(FrmUtama.txtMerkBarang.Text)

                    Me.Close()

                    'Trim(FrmUtama.txtBarang.Text)
                    'Trim(FrmUtama.txtKodeLokasi.Text)
                    ''Trim(FrmUtama.txtMerkBarang.Text)
                    FrmUtama.txtQty.Focus()
                    FrmUtama.btnCariPerusahaan.Enabled = False

            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    Public Sub PilihBarang()

        Try
            Select Case Me.Text

                Case "ATM"
                    FrmUtamaATM.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtamaATM.txtBarang.Text = DGBarang.SelectedCells(1).Value
                    RTrim(FrmUtamaATM.txtBarang.Text)

                    Me.Close()
                    FrmUtamaATM.txtQty.Focus()
                    FrmUtamaATM.btnCariPerusahaan.Enabled = False

                Case "PT"
                    FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
                    RTrim(FrmUtama.txtBarang.Text)

                    Me.Close()
                    FrmUtama.txtQty.Focus()
                    FrmUtama.btnCariPerusahaan.Enabled = False


            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try


    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        DGBarang_DoubleClick(sender, e)
        FrmUtama.txtQty.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Proses.CloseConn()
        Me.Close()

        FrmUtama.txtQty.Focus()
    End Sub

End Class
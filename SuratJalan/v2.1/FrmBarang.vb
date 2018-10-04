Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmBarang
    Dim Proses As New ClsKoneksi
    Dim barangku, mysurat As DataTable
    Dim SQL As String
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer

    'MENAMPILKAN DATA BARANG BERDASARKAN NO ORDER



    Private Sub FrmCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        No_Order()
        Data_Barang()
        'Details_Surat_Jalan()
        'Compare_Barang()
    End Sub

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

    Private Sub total_item()
        Dim hitung As Integer
        For baris As Integer = 0 To DGBarang.RowCount - 1
            hitung = hitung + DGBarang.Rows(baris).Cells(4).Value
        Next

        lbl_totalbarang.Text = hitung

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
        'total_item()


    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Sub Terpilih()

    End Sub
End Class
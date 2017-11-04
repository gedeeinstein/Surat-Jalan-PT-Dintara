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


        barangku = Proses.ExecuteQuery("SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.kode_lokasi AS 'KL', tawar02.qty as 'QTY PESANAN' FROM barang " _
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

        Dim sqlquery = "SELECT barang.kode AS 'KODE BARANG', barang.nama AS 'NAMA BARANG', tawar02.kode_lokasi AS 'KL', tawar02.qty as 'QTY PESANAN' FROM barang " _
                                     & "INNER JOIN tawar02 ON barang.kode = tawar02.kode_barang " _
                                     & "WHERE tawar02.kode ='" & txtNoOrder.Text & "'"
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
        lbl_totalbarang.Text = Val(totalbarang)
        Proses.CloseConn()
    End Sub

    Private Sub FrmCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        No_Order()
        Data_Barang()
    End Sub

    Private Sub DGBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick

        'FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
        'FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
        'RTrim(FrmUtama.txtBarang.Text)

        'Me.Close()
        'FrmUtama.txtQty.Focus()
        'FrmUtama.btnCariPerusahaan.Enabled = False]

        Try
            Select Case Me.Text

                Case "Cari Barang"
                    FrmUtamaATM.txtKodeLokasi.Text = DGBarang.SelectedCells(2).Value
                    FrmUtamaATM.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtamaATM.txtBarang.Text = DGBarang.SelectedCells(1).Value

                    Trim(FrmUtamaATM.txtBarang.Text)
                    Trim(FrmUtamaATM.txtKodeLokasi.Text)
                    FrmUtamaATM.txtQty.Focus()
                    Me.Close()
                    FrmUtamaATM.txtQty.Focus()
                    FrmUtamaATM.btnCariPerusahaan.Enabled = False

                Case "Pilih Barang"
                    FrmUtama.txtKodeLokasi.Text = DGBarang.SelectedCells(2).Value
                    FrmUtama.txtKodeBarang.Text = DGBarang.SelectedCells(0).Value
                    FrmUtama.txtBarang.Text = DGBarang.SelectedCells(1).Value
                    Trim(FrmUtama.txtBarang.Text)
                    Trim(FrmUtama.txtKodeLokasi.Text)
                    FrmUtama.txtQty.Focus()

                    Me.Close()
                    FrmUtama.txtQty.Focus()
                    FrmUtama.btnCariPerusahaan.Enabled = False


            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    Public Sub PilihBarang()

        'Dim Pilihan As Boolean



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
Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmCariPerusahaan
    Dim Proses As New ClsKoneksi
    Dim perusahaan As DataTable
    Dim SQL As String
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String

    Sub No_Order()
        'txtCariPerusahaan.Text = FrmUtama.txtNoOrder.Text.ToString
        'FrmUtama.txtNoOrder.Text = txtNoOrder.Text
        FrmUtama.txtKodePerusahaan.Text = Nothing
        FrmUtama.txtPerusahaan.Text = Nothing
        FrmUtama.txtPelanggan.Text = Nothing
        FrmUtama.txtNoOrder.Text = Nothing
        FrmUtama.cmbPerusahaan.Text = Nothing
        FrmUtama.txtKodeBarang.Text = Nothing
        FrmUtama.txtBarang.Text = Nothing
        FrmUtama.txtAlamat.Text = Nothing

    End Sub


    Sub Data_Perusahaan()
        Try

            SQL = "SELECT tawar01.kode_pelanggan AS 'KODE PERUSAHAAN', " _
                & "pelanggan.nama AS 'NAMA PERUSAHAAN', tawar01.att AS 'PENERIMA', tawar01.kode AS 'PENAWARAN', pelanggan.alamat as 'ALAMAT', tawar01.tgl AS 'TGL' " _
                & "FROM tawar01 INNER JOIN pelanggan " _
                & "ON pelanggan.kode = tawar01.kode_pelanggan " _
                & "WHERE pelanggan.nama LIKE '%" & Rep(txtCariPerusahaan.Text) & "%' ORDER BY tawar01.tgl DESC"
            perusahaan = Proses.ExecuteQuery(SQL)

            Try
                Proses.OpenConn()
                Me.DGPerusahaan.DataSource = perusahaan
                'Me.DGPerusahaan.Columns(0).Visible = False
                Me.DGPerusahaan.Columns(0).Width = 100
                Me.DGPerusahaan.Columns(1).Width = 380
                Me.DGPerusahaan.Columns(2).Width = 180
                Me.DGPerusahaan.Columns(3).Width = 190
                Me.DGPerusahaan.Columns(4).Visible = False
                Me.DGPerusahaan.Columns(5).Visible = False ' Untuk Memasukan Alamat ke Form utama
                Proses.CloseConn()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally

                MySqlConnection.ClearAllPools()
            End Try

            '850

            DGPerusahaan.GridColor = Color.White
            DGPerusahaan.DefaultCellStyle.ForeColor = Color.White
            DGPerusahaan.AlternatingRowsDefaultCellStyle.BackColor = Color.Purple
            DGPerusahaan.RowsDefaultCellStyle.BackColor = Color.DarkGreen
            Proses.CloseConn()
            DGPerusahaan.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Proses.OpenConn()

            Dim myadapter As New MySqlDataAdapter
            Dim sqlquery = "SELECT * FROM tawar01"
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
            lbl_totalperusahaan.Text = Val(totalbarang)


        Catch ex As Exception
            MessageBox.Show("Error. Hubungi IT atau periksa ulang data yang di input" + ex.Message, "Hubungi IT", MessageBoxButtons.OK) : Exit Sub
        Finally
            Proses.CloseConn()
        End Try
    End Sub

    Private Sub FrmCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        No_Order()
        Data_Perusahaan()
        txtCariPerusahaan.Text = Nothing
        RbNama.Checked = True
    End Sub

    Private Sub DGPerusahaan_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGPerusahaan.DoubleClick

        PilihPerusahaan()

    End Sub


    Public Sub PilihPerusahaan()
        Dim i = DGPerusahaan.CurrentRow.Index
        Dim row As DataGridViewRow = DGPerusahaan.CurrentRow

        Try
            Select Case Me.Text

                Case "Pilih Perusahaan PT"
                    FrmUtama.txtKodePerusahaan.Text = row.Cells(0).Value
                    FrmUtama.txtPerusahaan.Text = row.Cells(1).Value
                    FrmUtama.txtPelanggan.Text = row.Cells(2).Value
                    FrmUtama.txtNoOrder.Text = row.Cells(3).Value
                    FrmUtama.txtAlamat.Text = row.Cells(4).Value
                    FrmUtama.cmbPerusahaan.Text = "" & DGPerusahaan.SelectedCells(0).Value & "/" & DGPerusahaan.SelectedCells(1).Value & ""
                    Me.Close()
                    Trim(FrmUtama.txtKodePerusahaan.Text)
                    Trim(FrmUtama.txtPerusahaan.Text)
                    Trim(FrmUtama.txtPelanggan.Text)
                    Trim(FrmUtama.txtNoOrder.Text)
                    Trim(FrmUtama.txtAlamat.Text)
                    FrmUtama.txtBarang.Focus()
                    MySqlConnection.ClearAllPools()


                Case "Pilih Perusahaan CV"
                    'FrmUtamaATM.txtKodePerusahaan.Text = DGPerusahaan.SelectedCells(0).Value
                    'FrmUtamaATM.txtPerusahaan.Text = DGPerusahaan.SelectedCells(1).Value
                    'FrmUtamaATM.txtPelanggan.Text = DGPerusahaan.SelectedCells(2).Value
                    'FrmUtamaATM.txtNoOrder.Text = DGPerusahaan.SelectedCells(3).Value
                    'FrmUtamaATM.txtAlamat.Text = DGPerusahaan.SelectedCells(4).Value
                    FrmUtamaATM.txtKodePerusahaan.Text = row.Cells(0).Value
                    FrmUtamaATM.txtPerusahaan.Text = row.Cells(1).Value
                    FrmUtamaATM.txtPelanggan.Text = row.Cells(2).Value
                    FrmUtamaATM.txtNoOrder.Text = row.Cells(3).Value
                    FrmUtamaATM.txtAlamat.Text = row.Cells(4).Value

                    FrmUtamaATM.cmbPerusahaan.Text = "" & DGPerusahaan.SelectedCells(0).Value & "/" & DGPerusahaan.SelectedCells(1).Value & ""
                    Me.Close()
                    Trim(FrmUtamaATM.txtKodePerusahaan.Text)
                    Trim(FrmUtamaATM.txtPerusahaan.Text)
                    Trim(FrmUtamaATM.txtPelanggan.Text)
                    Trim(FrmUtamaATM.txtNoOrder.Text)
                    Trim(FrmUtamaATM.txtAlamat.Text)
                    FrmUtamaATM.txtBarang.Focus()
                    MySqlConnection.ClearAllPools()
            End Select
        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub



    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        PilihPerusahaan()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub txtCariPerusahaan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariPerusahaan.TextChanged
        If RbNama.Checked = True Then
            SQL = "SELECT tawar01.kode_pelanggan as 'KODE' , " _
                & "pelanggan.nama as 'NAMA PERUSAHAAN', tawar01.att as 'PENERIMA', tawar01.kode AS 'PENAWARAN', tawar01.alamat as 'ALAMAT', tawar01.tgl AS 'TGL' " _
                & "FROM tawar01 INNER JOIN pelanggan " _
                & "ON pelanggan.kode = tawar01.kode_pelanggan " _
                & "WHERE pelanggan.nama LIKE '%" & Rep(txtCariPerusahaan.Text) & "%' ORDER BY tawar01.tgl DESC"

            perusahaan = Proses.ExecuteQuery(SQL)
            DGPerusahaan.DataSource = perusahaan
            txtCariPerusahaan.Focus()
        ElseIf RbPenerima.Checked = True Then
            SQL = "SELECT tawar01.kode_pelanggan as 'KODE' , " _
               & "pelanggan.nama as 'NAMA PERUSAHAAN', tawar01.att as 'PENERIMA', tawar01.kode AS 'PENAWARAN', tawar01.alamat as 'ALAMAT', tawar01.tgl AS 'TGL' " _
               & "FROM tawar01 INNER JOIN pelanggan " _
               & "ON pelanggan.kode = tawar01.kode_pelanggan " _
               & "WHERE tawar01.att LIKE '%" & Rep(txtCariPerusahaan.Text) & "%' ORDER BY tawar01.tgl DESC"

            perusahaan = Proses.ExecuteQuery(SQL)
            DGPerusahaan.DataSource = perusahaan
            txtCariPerusahaan.Focus()
        ElseIf RbNoOrder.Checked = True Then
            SQL = "SELECT tawar01.kode_pelanggan as 'KODE' , " _
               & "pelanggan.nama as 'NAMA PERUSAHAAN', tawar01.att as 'PENERIMA', tawar01.kode AS 'PENAWARAN', tawar01.alamat as 'ALAMAT', tawar01.tgl AS 'TGL' " _
               & "FROM tawar01 INNER JOIN pelanggan " _
               & "ON pelanggan.kode = tawar01.kode_pelanggan " _
               & "WHERE tawar01.kode LIKE '%" & Rep(txtCariPerusahaan.Text) & "%' ORDER BY tawar01.tgl DESC"

            perusahaan = Proses.ExecuteQuery(SQL)
            DGPerusahaan.DataSource = perusahaan
            txtCariPerusahaan.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtCariPerusahaan_TextChanged(sender, e)
    End Sub

    Private Sub DGPerusahaan_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPerusahaan.CellDoubleClick
        PilihPerusahaan()
    End Sub
End Class
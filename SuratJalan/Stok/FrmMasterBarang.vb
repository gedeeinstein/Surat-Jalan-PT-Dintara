Imports MySql.Data.MySqlClient
Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmMasterBarang
    Dim Proses As New ClsKoneksi
    Dim barangku, mysurat As DataTable
    Dim SQL As String
    Dim Data As DataSet
    'Dim i As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String


    Private Sub BarangMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangMasukToolStripMenuItem.Click
        'Memanggil Form Barang Masuk
        Try
            If str_status > 0 Then
                Proses.CloseConn()
                'FrmLoading.Text = "Load Data Barang"
                'FrmLoading.ShowDialog()
                'Panggil Form Data Barang
                FrmStok.Text = "DATA BARANG MASUK"
                FrmStok.MdiParent = Me
                FrmStok.WindowState = FormWindowState.Maximized
                FrmStok.Dock = DockStyle.Fill
                FrmStok.Show()
                'ToolStripMenuItem1.Enabled = False
                MySqlConnection.ClearAllPools()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        'Memanggil Form Barang Keluar / Surat Jalan
        Try
            Proses.CloseConn()
            'SplashScreen1.Text = "Loading Barang Keluar (Surat Jalan)"
            'SplashScreen1.ShowDialog()
            'FrmUtama.Text = "(Surat Jalan Barang Keluar)"
            FrmUtama.Show()
            Me.Close()
            MySqlConnection.ClearAllPools()


        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub

    'Sub Coba()
    '    Proses.CloseConn()
    '    If txtNoOrder.TextLength = 0 Then
    '        SplashScreen1.Text = "Loading Form ATM"
    '        SplashScreen1.ShowDialog()
    '        FrmUtamaATM.Show()
    '        Me.Close()
    '    Else
    '        MessageBox.Show("Selesaikan transaksi dulu atau klik tombol reset ya :( " + userlogin, "403 Forbidden ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
    '    End If
    'End Sub


    Private Sub FrmMasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub KategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategoriToolStripMenuItem.Click

        Try
            If str_status > 0 Then
                Proses.OpenConn()
                FrmKategori.Text = "Pilih Perusahaan PT"
                FrmKategori.ShowDialog()
                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try


    End Sub

    Private Sub MerkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerkToolStripMenuItem.Click
        Try
            If str_status > 0 Then
                Proses.OpenConn()
                'FrmMerk.Text = ""
                FrmMerk.ShowDialog()
                Proses.CloseConn()
            Else
                Koneksi_Error()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub
End Class
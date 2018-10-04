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
            'If str_status > 0 Then
            'Proses.CloseConn()
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
            'Else
            'MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            FrmLogin.Connect()
        End Try
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        'Memanggil Form Barang Keluar / Surat Jalan
        Try
            Proses.OpenConn()
            FrmUtama.Show()
            Me.Close()
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub


    Private Sub FrmMasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub KategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategoriToolStripMenuItem.Click

        Try
            'If str_status > 0 Then
            Proses.OpenConn()
            FrmKategori.Text = "Pilih Perusahaan PT"
            FrmKategori.ShowDialog()
            Proses.CloseConn()
            'Else
            'Koneksi_Error()
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
            Koneksi_Error()
        End Try


    End Sub

    Private Sub MerkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerkToolStripMenuItem.Click
        Try
            Proses.OpenConn()
            FrmMerk.ShowDialog()
            Proses.CloseConn()
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Ada kesalahan, harap ulangi proses atau restart aplikasi", "Gagak membuka form pencarian perusahaan", MessageBoxButtons.OK)
            FrmLogin.Connect()
        End Try
    End Sub


    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        'Memanggil Form Barang Masuk
        Try
            ' If str_status > 0 Then
            Proses.OpenConn()
            'FrmLoading.Text = "Load Data Barang"
            'FrmLoading.ShowDialog()
            'Panggil Form Data Barang
            FrmBarangUpdate.Text = "MASTER DATA BARANG"
            FrmBarangUpdate.MdiParent = Me
            FrmBarangUpdate.WindowState = FormWindowState.Maximized
            FrmBarangUpdate.Dock = DockStyle.Fill
            FrmBarangUpdate.Show()
            'ToolStripMenuItem1.Enabled = False
            MySqlConnection.ClearAllPools()
            'Else
            'Koneksi_Error()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
            Koneksi_Error()
            FrmLogin.Connect()

        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        KeluarApp()
    End Sub


    Sub KeluarApp()
        Try
            If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
                Me.Close()

                FrmLogin.Close()
                Application.Exit()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Error", "Kesalahan Membuka Data Master Barang", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        KeluarApp()
    End Sub

    Private Sub StokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokToolStripMenuItem.Click

    End Sub
End Class
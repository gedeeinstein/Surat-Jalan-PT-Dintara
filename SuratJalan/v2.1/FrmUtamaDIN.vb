Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class FrmUtamaDIN
    'DEKLARASI VARIABLE
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    Dim dtPelanggan As DataTable
    Dim dtOrder As DataTable
    Dim dtSurat As DataTable


    'button pencarian barang
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click

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
                        FrmCariBarang.Text = "Pilih Barang"
                        FrmCariBarang.ShowDialog()
                        Proses.CloseConn()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information)
                End Try

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Kode 404", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information)
        End Try

    End Sub
End Class
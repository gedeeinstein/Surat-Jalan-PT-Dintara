Public Class FrmLoading


    Private Sub FrmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Select Case Me.Text

                Case "Load Data Barang" 'Menampilkan Form Loading Saat di klik menu Stok Barang Masuk

                    ProgressBar2.Increment(1)
                    If ProgressBar2.Value = 70 Then
                        FrmStok.Show()
                        Me.Close()
                    End If

                Case "Loading Barang Keluar (Surat Jalan)"
                    ProgressBar2.Increment(1)
                    If ProgressBar2.Value = 100 Then
                        FrmMasterBarang.Visible = False
                        FrmUtama.Show()
                        FrmMasterBarang.Hide()
                        Me.Close()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    Private Sub author2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles author2.LinkClicked

        Try
            author2.LinkVisited = True
            AuthorIG()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

End Class

Public Class SplashScreen1


    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ProgressBar1.Increment(1)
        'If ProgressBar1.Value = 100 Then

        'End If
        'Dim s = New SplashScreen1()
        's.Show()
        'System.Threading.Thread.Sleep(1000)
        's.Close()


        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Select Case Me.Text

                Case "Loading Form Dintara"

                    ProgressBar1.Increment(1)
                    If ProgressBar1.Value = 100 Then
                        FrmUtamaATM.Visible = False

                        'System.Threading.Thread.Sleep(1000)

                        FrmUtama.Show()
                        FrmUtamaATM.Hide()
                        Me.Close()
                    End If

                Case "Loading Form ATM"

                    ProgressBar1.Increment(1)
                    If ProgressBar1.Value = 100 Then
                        FrmUtama.Visible = False

                        'System.Threading.Thread.Sleep(1000)

                        FrmUtamaATM.Show()
                        FrmUtama.Hide()
                        Me.Close()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://instagram.com/gedeeinstein")
    End Sub
<<<<<<< HEAD
<<<<<<< HEAD

    Private Sub author_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles author.LinkClicked

        Try
            VisitLink()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka tautan" + ex.Message, " Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub VisitLink()
        author.LinkVisited = True
        System.Diagnostics.Process.Start("https://instagram.com/gedeeinstein")
    End Sub

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
End Class

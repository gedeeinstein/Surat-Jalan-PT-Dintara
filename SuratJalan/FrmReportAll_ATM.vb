Imports MySql.Data.MySqlClient

Public Class FrmReportAll_ATM

    Private Sub FrmReportAll_ATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintFromMaster()
    End Sub



    Sub PrintFromMaster()
        Try
            Select Case Me.Text
                Case "Cetak Riwayat Surat Jalan ATM"
                    Dim RiwayatNoOrder_Atm As New RptNoAll_ATM

                    RiwayatNoOrder_Atm.SetParameterValue("pmNoOrder", FrmMasterSurat.txtNoOrder.Text)
                    CrystalReportViewer1.ReportSource = RiwayatNoOrder_Atm
                Case "Cetak Riwayat Surat Jalan DIN"
                    Dim RiwayatNoOrder_DIN As New RptNoAll_DIN

                    RiwayatNoOrder_DIN.SetParameterValue("pmNoOrder", FrmMasterSurat.txtNoOrder.Text)
                    CrystalReportViewer1.ReportSource = RiwayatNoOrder_DIN
            End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
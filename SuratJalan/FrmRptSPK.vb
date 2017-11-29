Imports MySql.Data.MySqlClient

Public Class FrmRptSPK


    Private Sub FrmRptSPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim SuratPerintahKirim As New RptSuratJalanNew

        SuratPerintahKirim.SetParameterValue("PmNoSurat", FrmUtama.txtNoSurat.Text)
        CrystalReportViewer1.ReportSource = SuratPerintahKirim
        PrintFromMaster()

    End Sub

    Sub PrintFromMaster()
        Try
            Select Case Me.Text
                Case "Cetak Surat Jalan DIN No "
                    Dim SuratPerintahKirim As New RptSuratJalanNew
                    SuratPerintahKirim.SetParameterValue("PmNoSurat", FrmMasterSurat.txtNoSurat.Text)
                    CrystalReportViewer1.ReportSource = SuratPerintahKirim
            End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
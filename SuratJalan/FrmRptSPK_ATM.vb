Imports MySql.Data.MySqlClient

Public Class FrmRptSPK_ATM

    'Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
    '    Dim SuratPerintahKirim As New RptSuratJalanNew

    '    SuratPerintahKirim.SetParameterValue("PmNoSurat", FrmUtamaATM.txtNoSurat.Text)
    '    CrystalReportViewer1.ReportSource = SuratPerintahKirim
    'End Sub

    Private Sub FrmRptSPK_ATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim SuratPerintahKirim As New RptSuratJalanATM

        Dim SuratPerintahKirimATM As New ATM

        SuratPerintahKirimATM.SetParameterValue("PmNoSurat", FrmUtamaATM.txtNoSurat.Text)
        CrystalReportViewer1.ReportSource = SuratPerintahKirimATM
        PrintFromMaster()
    End Sub


    Sub PrintFromMaster()
        Try
            Select Case Me.Text
                Case "Cetak Surat Jalan CV No "
                    Dim SuratPerintahKirimATM As New ATM
                    SuratPerintahKirimATM.SetParameterValue("PmNoSurat", FrmMasterSurat.txtNoSurat.Text)
                    CrystalReportViewer1.ReportSource = SuratPerintahKirimATM
            End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

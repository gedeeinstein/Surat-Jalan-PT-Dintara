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
    End Sub

End Class

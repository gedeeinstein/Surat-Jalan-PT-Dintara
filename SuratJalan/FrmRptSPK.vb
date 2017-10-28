Public Class FrmRptSPK


    Private Sub FrmRptSPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim SuratPerintahKirim As New RptSuratJalanNew

        SuratPerintahKirim.SetParameterValue("PmNoSurat", FrmUtama.txtNoSurat.Text)
        CrystalReportViewer1.ReportSource = SuratPerintahKirim

    End Sub


End Class
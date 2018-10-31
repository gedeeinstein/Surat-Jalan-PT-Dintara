Imports MySql.Data.MySqlClient

Public Class FrmRptSPK_ATM

    Private Sub FrmRptSPK_ATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintFromMaster()
    End Sub


    Sub PrintFromMaster()
        Try
            Dim isLvlGudang As String = FrmUtamaATM.txtGudang.Text
            Dim isLvlAR As String = FrmUtamaATM.txtAdminAR.Text
            Dim User As String = FrmMasterSurat.txtUser.Text

            Dim SuratJalanATM As New ATM

            Dim PrintByUser As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim AdmGudang As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim AdminAR As CrystalDecisions.CrystalReports.Engine.TextObject

            PrintByUser = SuratJalanATM.Section1.ReportObjects.Item("PrintUserText")
            AdmGudang = SuratJalanATM.Section1.ReportObjects.Item("txtGudangRpt")
            AdminAR = SuratJalanATM.Section1.ReportObjects.Item("txtAdminRpt")

            Select Case Me.Text
                Case "Cetak Surat Jalan No CV "
                    SuratJalanATM.SetParameterValue("PmNoSurat", FrmUtamaATM.txtNoSurat.Text)
                Case "Cetak Surat Jalan CV No "
                    SuratJalanATM.SetParameterValue("PmNoSurat", FrmMasterSurat.txtNoSurat.Text)
            End Select

            PrintByUser.Text = User
            AdmGudang.Text = isLvlGudang
            AdminAR.Text = isLvlAR

            CrystalReportViewer1.ReportSource = SuratJalanATM


            'End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Disini Errornya Saat Passing Data TextBox")
        End Try
    End Sub
End Class



'Dim SuratPerintahKirim As New RptSuratJalanATM
'Dim SuratPerintahKirimATM As New ATM
'SuratPerintahKirimATM.SetParameterValue("PmNoSurat", FrmUtamaATM.txtNoSurat.Text)
'CrystalReportViewer1.ReportSource = SuratPerintahKirimATM
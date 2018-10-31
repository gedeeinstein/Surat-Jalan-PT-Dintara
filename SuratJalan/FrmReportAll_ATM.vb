Imports MySql.Data.MySqlClient
Imports SuratJalan.FrmLogin
'Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReportAll_ATM

    Private Sub FrmReportAll_ATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintFromMaster()

    End Sub

    Sub PrintFromMaster()
        Dim User As String = FrmMasterSurat.txtUser.Text
        Dim RiwayatNoOrder_ATM As New RptNoAll_ATM
        Dim RiwayatNoOrder_DIN As New RptNoAll_DIN
        Dim myTextObject As CrystalDecisions.CrystalReports.Engine.TextObject
        Try
            Select Case Me.Text
                Case "Cetak Riwayat Surat Jalan ATM"

                    'Dim myTextObject As CrystalDecisions.CrystalReports.Engine.TextObject
                    myTextObject = RiwayatNoOrder_ATM.Section1.ReportObjects.Item("PrintUserText")
                    RiwayatNoOrder_ATM.SetParameterValue("pmNoOrder", FrmMasterSurat.txtNoOrder.Text)
                    myTextObject.Text = User
                    CrystalReportViewer1.ReportSource = RiwayatNoOrder_ATM

                Case "Cetak Riwayat Surat Jalan DIN"

                    'Dim myTextObject As CrystalDecisions.CrystalReports.Engine.TextObject

                    myTextObject = RiwayatNoOrder_DIN.Section1.ReportObjects.Item("PrintUserText")
                    myTextObject.Text = User
                    RiwayatNoOrder_DIN.SetParameterValue("pmNoOrder", FrmMasterSurat.txtNoOrder.Text)
                    CrystalReportViewer1.ReportSource = RiwayatNoOrder_DIN

            End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
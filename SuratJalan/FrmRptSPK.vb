Imports MySql.Data.MySqlClient

Public Class FrmRptSPK


    Private Sub FrmRptSPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PrintFromMaster()

    End Sub

    Sub DirectPrint()
        Dim isLvlGudang As String = FrmUtama.txtGudang.Text
        Dim isLvlAR As String = FrmUtama.txtAdminAR.Text
        Dim User As String = FrmMasterSurat.txtUser.Text

        Dim SuratJalanDIN As New RptSuratJalanNew

        Dim PrintByUser As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AdmGudang As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim AdminAR As CrystalDecisions.CrystalReports.Engine.TextObject

        Try
            PrintByUser = SuratJalanDIN.Section1.ReportObjects.Item("PrintUserText")
            AdmGudang = SuratJalanDIN.Section1.ReportObjects.Item("txtGudangRpt")
            AdminAR = SuratJalanDIN.Section1.ReportObjects.Item("txtAdminRpt")

            SuratJalanDIN.SetParameterValue("pmNoOrder", FrmUtama.txtNoOrder.Text)

            PrintByUser.Text = User
            AdmGudang.Text = isLvlGudang
            AdminAR.Text = isLvlAR

            CrystalReportViewer1.ReportSource = SuratJalanDIN

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub PrintFromMaster()
        Try

            Dim isLvlGudang As String = FrmUtama.txtGudang.Text
            Dim isLvlAR As String = FrmUtama.txtAdminAR.Text
            Dim User As String = FrmMasterSurat.txtUser.Text

            Dim SuratJalanDIN As New RptSuratJalanNew

            Dim PrintByUser As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim AdmGudang As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim AdminAR As CrystalDecisions.CrystalReports.Engine.TextObject

            PrintByUser = SuratJalanDIN.Section1.ReportObjects.Item("PrintUserText")
            AdmGudang = SuratJalanDIN.Section1.ReportObjects.Item("txtGudangRpt")
            AdminAR = SuratJalanDIN.Section1.ReportObjects.Item("txtAdminRpt")

            Select Case Me.Text
                Case "Cetak Surat Jalan PT No "
                    SuratJalanDIN.SetParameterValue("PmNoSurat", FrmUtama.txtNoSurat.Text)
                Case "Cetak Surat Jalan DIN No "
                    SuratJalanDIN.SetParameterValue("PmNoSurat", FrmMasterSurat.txtNoSurat.Text)
            End Select

            PrintByUser.Text = User
            AdmGudang.Text = isLvlGudang
            AdminAR.Text = isLvlAR

            CrystalReportViewer1.ReportSource = SuratJalanDIN

            'Case "Cetak Surat Jalan PT No " + FrmUtama.txtNoSurat.Text
            ' DirectPrint()
            'End Select
            MySqlConnection.ClearAllPools()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Sub Check_Users()
    '    Dim masuk, sql2 As DataTable
    '    Dim con As New ClsKoneksi
    '    Try
    '        con.OpenConn()
    '        masuk = con.ExecuteQuery("SELECT a.username, a.nama_user, b.level_name, b.jabatan FROM karyawan a INNER JOIN suratjalan_level b ON a.level_id = b.level_id WHERE a.level_id='2'")
    '        If masuk.Rows.Count = 0 Then
    '            MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
    '            Call Reset()
    '            : Exit Sub
    '        Else
    '            FrmUtama.txtGudang.Text = masuk.Rows(0).Item("nama_user").ToString
    '        End If

    '        sql2 = con.ExecuteQuery("SELECT a.username, a.nama_user, b.level_name, b.jabatan FROM karyawan a INNER JOIN suratjalan_level b ON a.level_id = b.level_id WHERE a.level_id='3'")
    '        If sql2.Rows.Count = 0 Then
    '            MsgBox("Maaf User Tersebut Belum Terdaftar", MsgBoxStyle.Critical, "Error")
    '            Call Reset()
    '            : Exit Sub
    '        Else
    '            FrmUtama.txtAdminAR.Text = masuk.Rows(0).Item("nama_user").ToString
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
    '    Finally

    '        con.CloseConn()
    '        MySqlConnection.ClearAllPools()
    '    End Try
    'End Sub

End Class
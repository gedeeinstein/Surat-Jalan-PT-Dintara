Imports MySql.Data.MySqlClient

Public Class FrmReportNilaiAsset

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub


    Dim SQL = "SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'BRAND', a.harga_beli AS 'HPP', a.qty AS 'STOK', a.qty * a.harga_beli AS nilai_aset, a.ket AS 'KETERANGAN' FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode INNER JOIN merk c ON a.kode_merk = c.kode"

    Public Sub Assets()
        Dim SQLAssets = "SELECT * From Assets"
    End Sub

    Sub PrintFromMaster()
        'Try

        '    Dim isLvlGudang As String
        '    Dim isLvlAR As String
        '    Dim User As String

        '    Dim SuratJalanDIN As New RptSuratJalanNew

        '    Dim PrintByUser As CrystalDecisions.CrystalReports.Engine.TextObject
        '    Dim AdmGudang As CrystalDecisions.CrystalReports.Engine.TextObject
        '    Dim AdminAR As CrystalDecisions.CrystalReports.Engine.TextObject

        '    PrintByUser = SuratJalanDIN.Section1.ReportObjects.Item("PrintUserText")
        '    AdmGudang = SuratJalanDIN.Section1.ReportObjects.Item("txtGudangRpt")
        '    AdminAR = SuratJalanDIN.Section1.ReportObjects.Item("txtAdminRpt")

        '    Select Case Me.Text
        '        Case "Cetak Surat Jalan PT No "
        '            SuratJalanDIN.SetParameterValue("PmNoSurat", FrmUtama.txtNoSurat.Text)
        '        Case "Cetak Surat Jalan DIN No "
        '            SuratJalanDIN.SetParameterValue("PmNoSurat", FrmMasterSurat.txtNoSurat.Text)
        '    End Select

        '    PrintByUser.Text = User
        '    AdmGudang.Text = isLvlGudang
        '    AdminAR.Text = isLvlAR

        '    CrystalReportViewer1.ReportSource = SuratJalanDIN

        '    'Case "Cetak Surat Jalan PT No " + FrmUtama.txtNoSurat.Text
        '    ' DirectPrint()
        '    'End Select
        '    MySqlConnection.ClearAllPools()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Public Sub Check_Users()
        'Dim data_asset As DataTable
        'Dim con As New ClsKoneksi
        'Dim kodeBrg, namaBrg, merk, kategori, qty, hargaBeli As Windows.Forms.TextBox


        'Try
        '    con.OpenConn()
        '    Dim SQL = "SELECT a.kode AS 'Kode Barang', a.nama AS 'Nama Barang', b.golongan AS 'Kagetori', c.merk AS 'BRAND', a.harga_beli AS 'HPP', a.qty AS 'STOK', a.qty * a.harga_beli AS nilai_aset, a.ket AS 'KETERANGAN' FROM barang a INNER JOIN golongan b ON a.kode_gol = b.kode INNER JOIN merk c ON a.kode_merk = c.kode"

        '    data_asset = con.ExecuteQuery(SQL)

        '    If data_asset.Rows.Count = 0 Then
        '        MsgBox("Tidak Ada Data", MsgBoxStyle.Critical, "Error")
        '        Call Reset()
        '        : Exit Sub
        '    Else
        '        kodeBrg.Text = data_asset.Rows(0).Item("a.kode").ToString
        '        namaBrg.Text = data_asset.Rows(0).Item("")
        '    End If

        'Catch ex As Exception
        '    MsgBox("Silahkan Ulangi / Restart Aplikasi", MsgBoxStyle.Critical, "Error")
        'Finally

        '    con.CloseConn()
        '    MySqlConnection.ClearAllPools()
        'End Try
    End Sub

    Sub Testis()
        'Dim i As Integer

        'i = CurrentRow.Index

        'For i = 0 To DGBarangKirim.Rows.Count - 1
        '    barang = Proses.ExecuteQuery("SELECT * FROM barang where kode = '" & DGBarangKirim.Item(1, i).Value & "'")
        '    If barang.Rows.Count = 0 Then
        '        'do nothing here ?
        '    Else
        '        Dim jumlah = CInt(barang.Rows(0).Item("qty")) + CInt(DGBarangKirim.Item(5, i).Value)
        '        Dim SQL = "UPDATE barang set qty = '" & CInt(jumlah) & "' where kode = '" & DGBarangKirim.Item(1, i).Value & "'"
        '        Proses.ExecuteNonQuery(SQL)
        '        MessageBox.Show("Transaksi sudah dibatalkan & semua details input telah dihapus", "Pembatalan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'Next
    End Sub

End Class
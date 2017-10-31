Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class FrmMasterSurat

    Dim Proses As New ClsKoneksi
    Dim mysurat As DataTable
    Dim SQL As String
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    'Dim kode_barang, search_name, search_condition, search_d As String

    Sub Data_Surat()





    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles title.Click

    End Sub

    Private Sub FrmMasterSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGMasterSurat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGMasterSurat.CellContentClick

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Apakah anda yakin mau keluar dari form master surat ", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            'Application.Exit()
        End If
    End Sub

    Private Sub GBPencarian_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBPencarian.Enter

    End Sub

    Private Sub GBDataKaryawan_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBDataKaryawan.Enter

    End Sub
End Class
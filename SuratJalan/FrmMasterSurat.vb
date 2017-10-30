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

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
    End Sub

    Private Sub title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles title.Click

    End Sub

    Private Sub FrmMasterSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
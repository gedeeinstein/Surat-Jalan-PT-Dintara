Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmKategori

    Dim Proses As New ClsKoneksi
    Dim kategoriku, mykategori As DataTable
    Dim SQL As String
    Dim Data As DataSet

    Private Sub FrmKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Kategori()
        Edit()

    End Sub


    Sub Edit()

    End Sub


    Public Sub Data_Kategori()

        kategoriku = Proses.ExecuteQuery("SELECT * FROM GOLONGAN ORDER BY golongan ASC")
        Me.DGKategori.DataSource = kategoriku
        Me.DGKategori.Columns(0).Width = 80  ' KODE KATEGORI
        Me.DGKategori.Columns(1).Width = 150 ' NAMA KATEGORI
        Me.DGKategori.Columns(2).Width = 50  ' USABLE
        'Me.DGKategori.Columns(3).Width = 120 ' KODE AREA
        'Me.DGKategori.Columns(4).Width = 100 ' QTY
        'Me.DGKategori.Columns(5).Width = 100 ' STOCK GUDANG

        Me.DGKategori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGKategori.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.DGKategori.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGKategori.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.DGKategori.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.DGKategori.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGKategori.GridColor = Color.White
        DGKategori.DefaultCellStyle.ForeColor = Color.White
        DGKategori.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray
        DGKategori.RowsDefaultCellStyle.BackColor = Color.Black
        'total_item()
    End Sub
End Class
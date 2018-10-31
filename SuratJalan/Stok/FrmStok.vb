Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmStok
    Dim Proses As New ClsKoneksi
    Dim barangku, mysurat As DataTable
    Dim SQL As String
    Dim Data As DataSet
    'Dim i As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String


    Private Sub FrmStok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Proses.OpenConn()
        Catch ex As Exception
            Koneksi_Error()
        End Try
        LoadBarang()
    End Sub

    Public Sub LoadBarang()
        Dim SqlQuery As String = "SELECT * FROM BARANG LIMIT 0, 100"
        Dim SqlAdapter As New MySqlDataAdapter
        Dim SqlCommand As New MySqlCommand
        Dim TabelBarang As New DataTable
        'Dim i As Integer

        With SqlCommand
            .CommandText = SqlQuery
            .Connection = Proses.Cn
        End With

        With SqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TabelBarang)

        End With

        ''ListBarang.Items.Clear()

        'koding perulangan 
        'For i = 0 To TabelBarang.Rows.Count - 1
        '    With ListBarang
        '        .Items.Add(TabelBarang.Rows(i)("kode"))
        '        With .Items(.Items.Count - 1).SubItems
        '            .Add(TabelBarang.Rows(i)("kode_gol"))
        '            .Add(TabelBarang.Rows(i)("kode_merk"))
        '            .Add(TabelBarang.Rows(i)("nama"))
        '            .Add(TabelBarang.Rows(i)("ket"))
        '            .Add(TabelBarang.Rows(i)("hpp"))
        '            .Add(TabelBarang.Rows(i)("hpp_awal"))
        '            .Add(TabelBarang.Rows(i)("qty"))
        '            .Add(TabelBarang.Rows(i)("qty_awal"))
        '            .Add(TabelBarang.Rows(i)("harju"))
        '            .Add(TabelBarang.Rows(i)("stok_min"))
        '            .Add(TabelBarang.Rows(i)("servis"))
        '            .Add(TabelBarang.Rows(i)("w"))
        '            .Add(TabelBarang.Rows(i)("d"))
        '            .Add(TabelBarang.Rows(i)("h"))

        '        End With
        '    End With
        'Next

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
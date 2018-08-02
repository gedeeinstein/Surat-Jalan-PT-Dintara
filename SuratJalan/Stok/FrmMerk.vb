Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FrmMerk

    Dim Proses As New ClsKoneksi
    Dim my_brand, my_merk As DataTable
    Dim SQL As String
    Dim Data As DataSet


    Public Sub Data_Merk()

        my_merk = Proses.ExecuteQuery("SELECT kode as 'KODE', merk as 'Merk / Brand' FROM merk ORDER BY kode ASC")
        Me.DGMerk.DataSource = my_merk
        Me.DGMerk.Columns(0).Width = 120  ' KODE KATEGORI
        Me.DGMerk.Columns(1).Width = 210 ' NAMA KATEGORI
        'Me.DGMerk.Columns(2).Width = 50  ' USABLE

        Me.DGMerk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGMerk.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.DGMerk.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGMerk.GridColor = Color.White
        DGMerk.DefaultCellStyle.ForeColor = Color.White
        DGMerk.AlternatingRowsDefaultCellStyle.BackColor = Color.Green
        DGMerk.RowsDefaultCellStyle.BackColor = Color.Purple

    End Sub

    Sub Kode_Otomatis()
        my_merk = Proses.ExecuteQuery("SELECT * FROM merk order by kode desc")

        If my_merk.Rows.Count = 0 Then
            txtKodeMerk.Text = "M001"
        Else
            With my_merk.Rows(0)
                txtKodeMerk.Text = .Item("kode")
            End With
            txtKodeMerk.Text = Val(Microsoft.VisualBasic.Mid(txtKodeMerk.Text, 2, 3)) + 1

            If Len(txtKodeMerk.Text) = 1 Then
                txtKodeMerk.Text = "M00" & txtKodeMerk.Text & ""
            ElseIf Len(txtKodeMerk.Text) = 2 Then
                txtKodeMerk.Text = "M0" & txtKodeMerk.Text & ""
            ElseIf Len(txtKodeMerk.Text) = 3 Then
                txtKodeMerk.Text = "M" & txtKodeMerk.Text & ""
            End If
        End If
    End Sub


    Public Sub Atur()

        Call Data_Merk()
        Call Kode_Otomatis()
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        txtKodeMerk.Enabled = False
        txtNamaMerk.Text = ""
        txtNamaMerk.Focus()

    End Sub

    Private Sub FrmMerk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Merk()
        Call Atur()
    End Sub


    'Klik Dua Kali di Data Grid View
    Private Sub DGMerk_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGMerk.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        txtKodeMerk.Text = DGMerk.SelectedCells(0).Value
        txtNamaMerk.Text = DGMerk.SelectedCells(1).Value

        txtNamaMerk.Focus()


        btnHapus.Enabled = True
        btnEdit.Enabled = True

        btnTambah.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub


    'Klik button Action

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click

        If txtNamaMerk.Text = "" Then
            MsgBox("Nama kategori Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaMerk.Focus() : Exit Sub
        End If
        Try
            If MsgBox("Data Akan Disimpan, Pastikan Data Sudah Benar ?", vbYesNo, "Lanjutkan") = vbYes Then
                SQL = "INSERT INTO merk VALUES ('" & txtKodeMerk.Text & "','" & txtNamaMerk.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Kategori Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNamaMerk.Text = "" Then
            MsgBox("Nama Kategori Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaMerk.Focus() : Exit Sub

        End If

        Try
            SQL = "UPDATE merk set merk = '" & txtNamaMerk.Text & "' where kode ='" & txtKodeMerk.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Berhasil Diperharui", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If txtNamaMerk.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        MessageBox.Show("Data Master Tidak Boleh Di Hapus untuk kepentingan history data !!!", "Hubungi Administrator", MessageBoxButtons.OK)
    End Sub
End Class
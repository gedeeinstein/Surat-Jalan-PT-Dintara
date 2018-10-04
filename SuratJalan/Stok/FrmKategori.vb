Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FrmKategori

    Dim Proses As New ClsKoneksi
    Dim kategoriku, mykategori As DataTable
    Dim SQL As String
    Dim Data As DataSet

    Private Sub FrmKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Kategori()
        Call Atur()

    End Sub


    Public Sub Data_Kategori()

        kategoriku = Proses.ExecuteQuery("SELECT kode as 'KODE', golongan as 'KATEGORI', usable as 'STATUS' FROM GOLONGAN ORDER BY kode ASC")
        Me.DGKategori.DataSource = kategoriku
        Me.DGKategori.Columns(0).Width = 80  ' KODE KATEGORI
        Me.DGKategori.Columns(1).Width = 150 ' NAMA KATEGORI
        Me.DGKategori.Columns(2).Width = 70  ' USABLE

        Me.DGKategori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGKategori.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGKategori.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGKategori.GridColor = Color.White
        DGKategori.DefaultCellStyle.ForeColor = Color.White
        DGKategori.AlternatingRowsDefaultCellStyle.BackColor = Color.Green
        DGKategori.RowsDefaultCellStyle.BackColor = Color.Purple
    End Sub


    Public Sub PilihKategori()
        Dim i = DGKategori.CurrentRow.Index
        Dim row As DataGridViewRow = DGKategori.CurrentRow

        Try
            Select Case Me.Text

                Case "Pilih Kategori"
                    FrmBarangUpdate.txtKodeGol.Text = row.Cells(0).Value
                    FrmBarangUpdate.txtKategori.Text = row.Cells(1).Value
                    Me.Close()
                    Trim(FrmBarangUpdate.txtKodeGol.Text)
                    Trim(FrmBarangUpdate.txtKategori.Text)
                    'Trim(FrmUtama.txtPelanggan.Text)
                    'Trim(FrmUtama.txtNoOrder.Text)
                    'Trim(FrmUtama.txtAlamat.Text)
                    FrmBarangUpdate.txtKategori.Enabled = False
                    FrmBarangUpdate.txtMerk.Focus()
                    MySqlConnection.ClearAllPools()

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNamaKategori.Text = "" Then
            MsgBox("Nama Kategori Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaKategori.Focus() : Exit Sub

        End If

        Try
            SQL = "UPDATE golongan set golongan = '" & txtNamaKategori.Text & "' where kode ='" & txtKodeKategori.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Berhasil Diperharui", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub


    Private Sub DGPerusahaan_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGKategori.CellDoubleClick
        'EditKategori()
    End Sub

    Private Sub DGPerusahaan_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGKategori.DoubleClick
        'EditKategori()
    End Sub

    Private Sub DGKategori_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGKategori.CellContentClick

    End Sub


    Public Sub Atur()
        Call Data_Kategori()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        txtKodeKategori.Enabled = False
        txtNamaKategori.Text = ""
        txtNamaKategori.Focus()
    End Sub

    Public Sub Kode_Otomatis()
        kategoriku = Proses.ExecuteQuery("SELECT * FROM golongan order by kode desc")

        If kategoriku.Rows.Count = 0 Then
            txtKodeKategori.Text = "G001"
        Else
            With kategoriku.Rows(0)
                txtKodeKategori.Text = .Item("kode")
            End With
            txtKodeKategori.Text = Val(Microsoft.VisualBasic.Mid(txtKodeKategori.Text, 2, 3)) + 1

            If Len(txtKodeKategori.Text) = 1 Then
                txtKodeKategori.Text = "G00" & txtKodeKategori.Text & ""
            ElseIf Len(txtKodeKategori.Text) = 2 Then
                txtKodeKategori.Text = "G0" & txtKodeKategori.Text & ""
            ElseIf Len(txtKodeKategori.Text) = 3 Then
                txtKodeKategori.Text = "G" & txtKodeKategori.Text & ""
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If txtNamaKategori.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                SQL = "DELETE FROM golongan where kode = '" & txtKodeKategori.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If txtNamaKategori.Text = "" Then
            MsgBox("Nama kategori Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaKategori.Focus() : Exit Sub
        End If
        Try
            If MsgBox("Data Akan Disimpan, Pastikan Data Sudah Benar ?", vbYesNo, "Lanjutkan") = vbYes Then
                SQL = "INSERT INTO golongan VALUES ('" & txtKodeKategori.Text & "','" & txtNamaKategori.Text & "', 'T')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Kategori Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub


    Private Sub DGSatuan_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGKategori.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        txtKodeKategori.Text = DGKategori.SelectedCells(0).Value
        txtNamaKategori.Text = DGKategori.SelectedCells(1).Value

        txtNamaKategori.Focus()


        btnHapus.Enabled = False
        btnEdit.Enabled = True

        btnTambah.Enabled = False


        Try
            Select Case Me.Text

                Case "Pilih Kategori"
                    PilihKategori()

            End Select
        Catch ex As Exception
            MessageBox.Show("Maaf terjadi kesalahan pemrosesan data, harap ulangi lagi prosesnya. Jika hal yang sama masih terjadi catat kode error dibawah ini" + vbNewLine + ex.Message, "Hubungi IT", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

End Class
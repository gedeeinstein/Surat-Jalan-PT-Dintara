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

    Sub Data_Riwayat_Surat()
        'Dim mycommand As New MySqlCommand
        'Dim mydata As MySqlDataReader
        'mydata = mycommand.ExecuteReader()
        'Dim i = DGMasterSurat.CurrentRow.Index
        'Dim row As DataGridViewRow = DGMasterSurat.CurrentRow
        Try
            Select Case Me.Text
                Case "Riwayat Surat Jalan ATM"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATTN.', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan_atm"
                        mysurat = Proses.ExecuteQuery(SQL)
                        'mydata = mycommand.ExecuteReader
                        '1192

                        Me.DGMasterSurat.DataSource = mysurat
                        Me.DGMasterSurat.Columns(0).Width = 120 ' No Surat
                        Me.DGMasterSurat.Columns(1).Width = 430 ' Nama Perusahaan
                        Me.DGMasterSurat.Columns(2).Width = 200 ' ATT
                        Me.DGMasterSurat.Columns(3).Width = 80 ' TANGGAL KIRIM
                        Me.DGMasterSurat.Columns(4).Width = 100 ' NO ORDER
                        Me.DGMasterSurat.Columns(5).Width = 250 ' PEMBUAT / USER

                        Me.DGMasterSurat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                        str_status = 0

                    End If
                Case "Riwayat Surat Jalan DIN"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATTN.', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan"
                        mysurat = Proses.ExecuteQuery(SQL)
                        'mydata = mycommand.ExecuteReader
                        '1192

                        Me.DGMasterSurat.DataSource = mysurat
                        Me.DGMasterSurat.Columns(0).Width = 120 ' No Surat
                        Me.DGMasterSurat.Columns(1).Width = 430 ' Nama Perusahaan
                        Me.DGMasterSurat.Columns(2).Width = 200 ' ATT
                        Me.DGMasterSurat.Columns(3).Width = 80  ' TANGGAL KIRIM
                        Me.DGMasterSurat.Columns(4).Width = 100 ' NO ORDER
                        Me.DGMasterSurat.Columns(5).Width = 250 ' PEMBUAT / USER

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                        str_status = 0

                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCr + "Aplikasi Error Ulangi Proses / Restart Aplikasi")
        End Try

    End Sub


    Sub Details_Surat_Jalan()
        Try
            Select Case Me.Text

                Case "Riwayat Surat Jalan ATM"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        'SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan"
                        SQL = "SELECT nosurat AS 'NO SURAT', kode AS 'KODE BARANG', kode_lokasi AS 'KODE AREA', nama_barang AS 'NAMA BARANG', qty AS 'QTY', no_order AS 'NO ORDER', merk AS 'MERK' FROM suratjalan_detail_atm where no_order = '" & txtNoOrder.Text & "' "
                        mysurat = Proses.ExecuteQuery(SQL)

                        Me.DGDetailsMasterSurat.DataSource = mysurat
                        Me.DGDetailsMasterSurat.Columns(0).Width = 120 ' NO SURAT
                        Me.DGDetailsMasterSurat.Columns(1).Width = 150 ' KD BRG
                        Me.DGDetailsMasterSurat.Columns(2).Width = 80 ' KD AREA
                        Me.DGDetailsMasterSurat.Columns(3).Width = 450 ' NAMA BARANG
                        Me.DGDetailsMasterSurat.Columns(4).Width = 70  ' QTY
                        Me.DGDetailsMasterSurat.Columns(5).Width = 150 ' NO ORDER
                        Me.DGDetailsMasterSurat.Columns(6).Width = 142 ' MERK
                        'Me.DGDetailsMasterSurat.Columns(7).Width = 200
                        '1192

                        Me.DGDetailsMasterSurat.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                        Dim myadapter As New MySqlDataAdapter
                        Dim sqlquery = "SELECT * FROM suratjalan_detail_atm"
                        Dim mycommand As New MySqlCommand
                        mycommand.Connection = Proses.Cn
                        mycommand.CommandText = SQL
                        myadapter.SelectCommand = mycommand
                        Dim totalbarang As Integer
                        Dim mydata As MySqlDataReader
                        mydata = mycommand.ExecuteReader()


                        totalbarang = 0
                        If (mydata.HasRows) Then
                            While (mydata.Read)
                                totalbarang = totalbarang + 1
                            End While
                        End If
                        Label4.Text = Val(totalbarang)

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                    End If

                Case "Riwayat Surat Jalan DIN"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        'SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan"
                        SQL = "SELECT nosurat AS 'NO SURAT', kode AS 'KODE BARANG', kode_lokasi AS 'KODE AREA', nama_barang AS 'NAMA BARANG', qty AS 'QTY', no_order AS 'NO ORDER', merk AS 'MERK' FROM suratjalan_detail where no_order = '" & txtNoOrder.Text & "'"
                        mysurat = Proses.ExecuteQuery(SQL)

                        Me.DGDetailsMasterSurat.DataSource = mysurat
                        Me.DGDetailsMasterSurat.Columns(0).Width = 120 ' NO SURAT
                        Me.DGDetailsMasterSurat.Columns(1).Width = 150 ' KD BRG
                        Me.DGDetailsMasterSurat.Columns(2).Width = 80 ' KD AREA
                        Me.DGDetailsMasterSurat.Columns(3).Width = 450 ' NAMA BARANG
                        Me.DGDetailsMasterSurat.Columns(4).Width = 70  ' QTY
                        Me.DGDetailsMasterSurat.Columns(5).Width = 150 ' NO ORDER
                        Me.DGDetailsMasterSurat.Columns(6).Width = 142 ' MERK
                        'Me.DGDetailsMasterSurat.Columns(7).Width = 200
                        '1192

                        Me.DGDetailsMasterSurat.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.DGDetailsMasterSurat.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                        Dim myadapter As New MySqlDataAdapter
                        Dim sqlquery = "SELECT * FROM suratjalan_detail"
                        Dim mycommand As New MySqlCommand
                        mycommand.Connection = Proses.Cn
                        mycommand.CommandText = SQL
                        myadapter.SelectCommand = mycommand
                        Dim totalbarang As Integer
                        Dim mydata As MySqlDataReader
                        mydata = mycommand.ExecuteReader()


                        totalbarang = 0
                        If (mydata.HasRows) Then
                            While (mydata.Read)
                                totalbarang = totalbarang + 1
                            End While
                        End If
                        Label4.Text = Val(totalbarang)

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()
                    Else
                        MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error Saat Koneksi Ke DataBase")
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub FrmMasterSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Riwayat_Surat()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Apakah anda yakin mau keluar dari form master surat ", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            'Application.Exit()
        End If
    End Sub

    Private Sub DGMasterSurat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGMasterSurat.MouseClick
        Dim i = DGMasterSurat.CurrentRow.Index
        Dim row As DataGridViewRow = DGMasterSurat.CurrentRow
        txtNoOrder.Text = row.Cells(4).Value
    End Sub

    Private Sub txtNoOrder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoOrder.TextChanged
        Details_Surat_Jalan()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Try
            Select Case Me.Text

                Case "Riwayat Surat Jalan ATM"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        If rb_no_order.Checked = True Then
                            SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan_atm where no_order LIKE '%" & txtCari.Text & "%' "
                            mysurat = Proses.ExecuteQuery(SQL)

                            Me.DGMasterSurat.DataSource = mysurat
                            txtCari.Focus()

                        ElseIf rb_nama_perusahaan.Checked = True Then
                            SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan_atm where nama_perusahaan LIKE '%" & txtCari.Text & "%' "
                            mysurat = Proses.ExecuteQuery(SQL)

                            Me.DGMasterSurat.DataSource = mysurat
                            txtCari.Focus()

                        End If

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()

                    Else
                        Koneksi_Error()
                    End If


                Case "Riwayat Surat Jalan DIN"
                    If str_status > 0 Then
                        Proses.OpenConn()
                        If rb_no_order.Checked = True Then
                            SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan where no_order LIKE '%" & txtCari.Text & "%' "
                            mysurat = Proses.ExecuteQuery(SQL)

                            Me.DGMasterSurat.DataSource = mysurat
                            txtCari.Focus()
                            
                        ElseIf rb_nama_perusahaan.Checked = True Then
                            SQL = "SELECT nosurat AS 'NO SURAT', nama_perusahaan AS 'PERUSAHAAN', att AS 'ATT', tanggal AS 'TANGGAL', no_order AS 'NO ORDER', USER AS 'DIBUAT OLEH' FROM suratjalan where nama_perusahaan LIKE '%" & txtCari.Text & "%' "
                            mysurat = Proses.ExecuteQuery(SQL)

                            Me.DGMasterSurat.DataSource = mysurat
                            txtCari.Focus()

                        End If

                        Proses.CloseConn()
                        MySqlConnection.ClearAllPools()

                    Else
                        Koneksi_Error()
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbNewLine + "Error Pencarian Surat Jalan")
        End Try
    End Sub
End Class
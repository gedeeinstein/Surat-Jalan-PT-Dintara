Imports System.Data.Odbc

Public Class FrmTambahUser

    Dim sql As String
    Dim Proses As New ClsKoneksi
    Dim karyawan As DataTable
    Private pwd As Char = "*"

    Sub Data_User()
        karyawan = Proses.ExecuteQuery("SELECT kode as 'Kode', username as 'Login', nama_user as 'Nama Lengkap', level_id as 'Level', tgl_update as 'Terdaftar', passwd as 'Password' FROM karyawan ORDER BY kode ASC")
        DG_User.DataSource = karyawan
        DG_User.Columns(0).Width = 80
        DG_User.Columns(1).Width = 90
        DG_User.Columns(2).Width = 250
        DG_User.Columns(3).Width = 100
        DG_User.Columns(4).Width = 100
        DG_User.Columns(5).Width = 100

        DG_User.Columns(5).DataPropertyName = "password"


        DG_User.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DG_User.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub



    Private Sub dgv_PwdFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_User.CellFormatting
        If DG_User.Columns(e.ColumnIndex).DataPropertyName = "password" And e.Value <> Nothing Then
            DG_User.Rows(e.RowIndex).Tag = e.Value
            e.Value = New String(pwd, e.Value.ToString.Length)
        Else
            DG_User.Rows(e.RowIndex).Tag = Nothing
        End If
    End Sub

    Private Sub dgv_PwdEditing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DG_User.EditingControlShowing
        If (DG_User.CurrentRow.Tag <> Nothing) Then
            e.Control.Text = DG_User.CurrentRow.Tag.ToString()
        End If
    End Sub


    'SUB NO KARYAWAN OTOMATIS
    Sub Kode_Otomatis_Kry()
        Try
            karyawan = Proses.ExecuteQuery("SELECT * FROM karyawan order by kode desc")

            If karyawan.Rows.Count = 0 Then
                txtID_User.Text = "USR-001"
            Else
                With karyawan.Rows(0)
                    txtID_User.Text = .Item("kode")
                End With

                txtID_User.Text = Val(Microsoft.VisualBasic.Mid(txtID_User.Text, 5, 3)) + 1

                If Len(txtID_User.Text) = 1 Then
                    txtID_User.Text = "USR-00" & txtID_User.Text & ""
                ElseIf Len(txtID_User.Text) = 2 Then
                    txtID_User.Text = "USR-0" & txtID_User.Text & ""
                ElseIf Len(txtID_User.Text) = 3 Then
                    txtID_User.Text = "USR-" & txtID_User.Text & ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
        End Try

        

    End Sub

    'LOAD DATA SAAT FORM PERTAMA KALI DI PANGGIL
    Private Sub FrmTambahUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Atur_Awal()


    End Sub

    'Sub Atur

    Sub Atur_Awal()
        Data_User()
        Kode_Otomatis_Kry()
    End Sub




    'LABEL UNTUK KELUAR DARI FORM TAMBAH USER
    Private Sub Exit_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Label.Click
        Me.Close()
    End Sub




    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub GBTombol_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBTombol.Enter

    End Sub

    Private Sub DG_User_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_User.CellContentClick

    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

    End Sub
End Class
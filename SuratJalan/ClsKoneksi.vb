﻿Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class ClsKoneksi
    Public SQL As String
    Public Cn As New MySqlConnection
    Public Cmd As New MySql.Data.MySqlClient.MySqlCommand
    Public Da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public Ds As New DataSet
    Public Dt As DataTable

    Const DSN = "DSN=SPK_DSN_SYS"
    Dim koneksi As OdbcConnection


    Public Function OpenConn() As Boolean
        alamat()
        Cn = New MySqlConnection("server=" + Server_Host + ";" _
            & "user id=" + Server_User + ";" _
            & "password=" + Server_Password + ";" _
            & "database=" + Server_Database + ";" _
            & "Convert Zero Datetime=True;Pooling=False;")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub


    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class

Imports System.Data.OleDb

Public Class Form2
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database2.accdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        qry = "select * from LoginForm where lusername = '" & txtuser.Text & "' and lpassword = '" & txtpass.Text & "'"
        cmd = New OleDbCommand(qry, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim x As New Form5
            x.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical)
        End If
        cn.Close()
    End Sub
    Sub clear()
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

End Class
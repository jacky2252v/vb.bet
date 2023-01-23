Imports System.Data.OleDb

Public Class Form3

    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb score\GymBuild\Database1.accdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cn.Open()
        qry = "select * from RegisterForm where username = '" & txtuser.Text & "' and password = '" & txtpass.Text & "'"
        cmd = New OleDbCommand(qry, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim x As New Form6
            x.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical)
        End If
        cn.Close()
    End Sub
End Class
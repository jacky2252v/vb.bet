Imports System.Data.OleDb

Public Class Form4

    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb score\GymBuild\Database1.accdb")
    Dim cmd As New OleDbCommand
    Dim qry As String

    Dim dap As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim gender As String

    'Sub Fillgrid()
    '    ds.Clear()
    '    qry = "Select * from RegisterForm"
    '    dap = New OleDbDataAdapter(qry, cn)
    '    dap.Fill(ds)
    '    DataGridView1.DataSource = ds.Tables(0)
    'End Sub
    Sub Clear()
        txtname.Text = ""
        gender = ""
        DateTimePicker1.Text = ""
        txtpass.Text = ""
        txtusername.Text = ""
        txtcontact.Text = ""
        txtmail.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Male.Checked Then
            gender = Male.Text
        Else
            gender = Female.Text
        End If
        cn.Open()
        qry = "insert into RegisterForm values('" & txtname.Text & "','" & DateTimePicker1.Text & "','" & gender & "','" & txtcontact.Text & "','" & txtmail.Text & "','" & txtusername.Text & "','" & txtpass.Text & "')"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Inserted.")
        Me.Close()
        'Fillgrid()
        Clear()
    End Sub

End Class
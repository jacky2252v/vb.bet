Imports System.Data.OleDb

Public Class Form5

    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb score\GymBuild\Database1.accdb")
    Dim cmd As New OleDbCommand
    Dim qry As String

    Dim dap As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim gender As String

    Sub Fillgrid()
        ds.Clear()
        qry = "Select * from RegisterForm"
        dap = New OleDbDataAdapter(qry, cn)
        dap.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Sub Clear()
        txtname.Text = ""
        gender = ""
        DateTimePicker1.Text = ""
        txtusername.Text = ""
        txtpass.Text = ""
        txtcontact.Text = ""
        txtmail.Text = ""
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
        Fillgrid()
        Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtusername.Text = "" Or txtpass.Text = "" Then
            MsgBox("Missing Information!")
        Else
            cn.Open()
            qry = "Update RegisterForm set uname='" & txtname.Text & "', dob='" & DateTimePicker1.Text & "', gender='" & gender & "', contact='" & txtcontact.Text & "', email='" & txtmail.Text & "', username='" & txtusername.Text & "', password='" & txtpass.Text & "' where uname='" & txtname.Text & "'"
            cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Updated!")
            Fillgrid()
            Clear()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtname.Text = row.Cells(0).Value.ToString()
        DateTimePicker1.Text = row.Cells(1).Value.ToString()
        gender = row.Cells(2).Value.ToString()
        txtcontact.Text = row.Cells(3).Value.ToString()
        txtmail.Text = row.Cells(4).Value.ToString()
        txtusername.Text = row.Cells(5).Value.ToString()
        txtpass.Text = row.Cells(6).Value.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cn.Open()
        qry = "delete from RegisterForm where uname = '" & txtname.Text & "'"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Deleted!")
        Fillgrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtname.Text = "" Then
            MsgBox("Enter the employee ID")
        Else
            Try
                cn.Open()
                Dim adp As New OleDbDataAdapter("select * from RegisterForm where uname='" & txtname.Text & "'", cn)
                Dim dt As New DataTable
                Dim cmd As New OleDbCommandBuilder(adp)
                adp.Fill(dt)
                For Each dr As DataRow In dt.Rows
                    txtname.Text = dr(0).ToString()
                    txtname.Visible = True
                    DateTimePicker1.Text = dr(1).ToString()
                    DateTimePicker1.Visible = True
                    gender = dr(2).ToString()
                    txtcontact.Text = dr(3).ToString()
                    txtcontact.Visible = True
                    txtmail.Text = dr(4).ToString()
                    txtmail.Visible = True
                    txtusername.Text = dr(5).ToString()
                    txtusername.Visible = True
                    txtpass.Text = dr(6).ToString()
                    txtpass.Visible = True

                Next
                If dt.Rows.Count = 0 Then
                    MsgBox("Invalid ID")
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.RegisterForm' table. You can move, or remove it, as needed.
        Me.RegisterFormTableAdapter.Fill(Me.Database1DataSet.RegisterForm)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
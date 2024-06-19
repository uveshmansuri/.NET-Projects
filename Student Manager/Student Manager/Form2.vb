Imports System.Data.OleDb
Imports System.IO
Public Class Form2
    Dim con As New OleDbConnection()
    Dim cmd As New OleDbCommand()

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students_Details.mdb"
        res_lal.Text = ""
    End Sub

    Private Sub name_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles name_txt.TextChanged
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from student_info where course='" & course_selection.SelectedItem.ToString & "' and student_name like '%" & name_txt.Text & "%';"

            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Dim str As String = ""

            While dr.Read
                str += (dr.GetValue(0) & "    " & dr.GetValue(1) & "    " & dr.GetValue(2) & "    " & dr.GetValue(3) & "    " & dr.GetValue(4) & "    " & dr.GetValue(5) & "    " & dr.GetValue(6) & "    " & dr.GetValue(7) & vbCrLf)
            End While

            res_lal.Text = str
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub course_selection_TextChanged(sender As Object, e As System.EventArgs) Handles course_selection.TextChanged
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from student_info where course='" & course_selection.SelectedItem.ToString & "'"
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            Dim str As String = ""

            While dr.Read
                str += (dr.GetValue(0) & "    " & dr.GetValue(1) & "    " & dr.GetValue(2) & "    " & dr.GetValue(3) & "    " & dr.GetValue(4) & "    " & dr.GetValue(5) & "    " & dr.GetValue(6) & "    " & dr.GetValue(7) & vbCrLf)
            End While

            If str.Length <> 0 Then
                res_lal.Text = str
                name_txt.Enabled = True
            Else
                res_lal.Text = "No Data Found"
                name_txt.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
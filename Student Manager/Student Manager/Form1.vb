Imports System.Data.OleDb
Imports System.IO
Public Class Form1

    Dim con As New OleDbConnection()
    Dim cmd As New OleDbCommand()

    Dim rollno As String
    Dim sname As String
    Dim address As String
    Dim contect As String
    Dim dob As String
    Dim gender As String
    Dim group As String
    Dim course As String

    Public Sub ref()
        Dim dad As New OleDbDataAdapter("select * from student_info", con)
        Dim dset As New DataSet
        Try
            dad.Fill(dset)
            dgv.DataSource = dset.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message & " ref")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub get_data()

        rollno = no_txt.Text
        sname = name_txt.Text
        address = address_txt.Text
        contect = contect_txt.Text
        dob = dob_pick.Text

        If male_btn.Checked Then
            gender = "Male"
        ElseIf female_btn.Checked Then
            gender = "Female"
        Else
            MsgBox("Select Gender")
        End If

        course = course_selection.SelectedItem.ToString

        group = ""
        If C1.Checked Then
            group += C1.Text & " "
        End If
        If C2.Checked Then
            group += C2.Text & " "
        End If
        If C3.Checked Then
            group += C3.Text & " "
        End If
        If C4.Checked Then
            group += C4.Text & " "
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        create_db("Students_Details.mdb")
        ref()
    End Sub
    
    Private Sub ins_btn_Click(sender As System.Object, e As System.EventArgs) Handles ins_btn.Click
        Try
            'Dim lst As String = ""
            'lst += "Roll no " & rollno & vbCrLf
            'lst += "Name " & sname & vbCrLf
            'lst += "Address " & address & vbCrLf
            'lst += "Contect no " & contect & vbCrLf
            'lst += "DOB " & dob & vbCrLf
            'lst += "Gender " & gender & vbCrLf
            'lst += "Course " & course & vbCrLf
            'lst += "Group " & group & vbCrLf
            'MsgBox(lst)

            con.Open()
            cmd.Connection = con
            get_data()
            cmd.CommandText = "insert into student_info values(" & rollno & ",'" & sname & "','" & address & "','" & contect & "','" & dob & "','" & gender & "','" & course & "','" & group & "');"
            cmd.ExecuteNonQuery()
            ref()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub up_btn_Click(sender As System.Object, e As System.EventArgs) Handles up_btn.Click
        Try
            get_data()
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update student_info set student_name='" & sname & "',address='" & address & "',contect_no='" & contect & "',date_of_birth='" & dob & "',gender='" & gender & "',course='" & course & "',activity=' " & group & "' where rollno=" & rollno
            cmd.ExecuteNonQuery()
            ref()
            MsgBox("Data Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub del_btn_Click(sender As System.Object, e As System.EventArgs) Handles del_btn.Click
        Dim ask As Integer
        ask = MsgBox("Are you sure to Delete???", MsgBoxStyle.YesNo)

        If ask = vbYes Then
            Try
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "delete from student_info where rollno=" & no_txt.Text
                cmd.ExecuteNonQuery()
                ref()
                MsgBox("Data Deleted")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgv.SelectionChanged
        Try
            If dgv.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = dgv.SelectedRows(0)
                no_txt.Text = row.Cells(0).Value.ToString
                name_txt.Text = row.Cells(1).Value.ToString
                address_txt.Text = row.Cells(2).Value.ToString
                contect_txt.Text = row.Cells(3).Value.ToString
                dob = row.Cells(4).Value.ToString

                If dob.Length <> 0 Then
                    dob_pick.Text = dob
                Else
                    dob_pick.Text = dob_pick.MaxDate
                End If

                If row.Cells(5).Value.ToString = "Male" Then
                    male_btn.Checked = True
                ElseIf row.Cells(5).Value.ToString = "Female" Then
                    female_btn.Checked = True
                Else
                    male_btn.Checked = False
                    female_btn.Checked = False
                End If

                If row.Cells(6).Value.ToString.Length <> 0 Then
                    course_selection.Text = row.Cells(6).Value.ToString
                Else
                    course_selection.Text = "Select Course"
                End If

                group = row.Cells(7).Value.ToString
                C1.Checked = group.Contains("NCC ")
                C2.Checked = group.Contains("Sports ")
                C3.Checked = group.Contains("NSS ")
                C4.Checked = group.Contains("Drama ")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clr_btn_Click(sender As System.Object, e As System.EventArgs) Handles clr_btn.Click
        no_txt.Text = ""
        name_txt.Text = ""
        address_txt.Text = ""
        contect_txt.Text = ""
        dob_pick.Text = dob_pick.MaxDate
        male_btn.Checked = False
        female_btn.Checked = False
        course_selection.SelectedIndex = -1
        C1.CheckState = CheckState.Unchecked
        C2.CheckState = CheckState.Unchecked
        C3.CheckState = CheckState.Unchecked
        C4.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim obj As New Form2
        obj.Show()
    End Sub

    Sub create_db(dp As String)
        Try
            If File.Exists(dp) Then
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dp
            Else
                Dim catalog As Object = CreateObject("ADOX.Catalog")
                catalog.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dp)
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dp
                con.Open()
                cmd.Connection = con
                Dim str As String = "create table Student_info(RollNo Number Primary Key,Student_Name Text,Address Text,Contect_No Text,Date_of_Birth Text,Gender Text,Course Text,Activity Text);"
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                'MsgBox("Database & Table Created")
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class



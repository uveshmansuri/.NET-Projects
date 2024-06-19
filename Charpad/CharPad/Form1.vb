Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        open_file_icon()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        save_file_icone()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        rtf.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        rtf.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        rtf.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        rtf.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        rtf.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        rtf.Focus()
        rtf.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        rtf.Focus()
        rtf.Find((InputBox("Enter text to Find")))
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        Dim str As String = InputBox("Enter text to Find")
        If DialogResult.OK Then
            rtf.SelectedText = rtf.SelectedText.Replace(rtf.SelectedText, str)
        End If
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeToolStripMenuItem.Click
        rtf.AppendText(System.DateTime.Now)
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If font_pro.ShowDialog <> DialogResult.Cancel Then
            rtf.SelectionFont = font_pro.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If font_color.ShowDialog <> DialogResult.Cancel Then
            rtf.SelectionColor = font_color.Color
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        MsgBox("CharPad" & vbCrLf & "Version 1.0" & vbCrLf & "Developed By CodingHub")
        '    Dim obj As New Form2
        '    Me.IsMdiContainer = True
        '    obj.MdiParent = Me
        '    obj.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        new_file()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        new_file()
    End Sub

    Public Sub new_file()
        Dim ask As MsgBoxResult
        ask = MsgBox("Do you Want to Save??", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            save_file_icone()
            rtf.Clear()
        ElseIf ask = MsgBoxResult.No Then
            rtf.Clear()
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        open_file_icon()
    End Sub

    Public Sub open_file_icon()
        open_file.Filter = "Text File | *.txt|Doc File | *.docx |Rich Text Formate |*.rtf |All Files |*.*"
        If open_file.ShowDialog = DialogResult.OK Then
            rtf.LoadFile(open_file.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Public Sub save_file_icone()
        save_file.Filter = "Text File | *.txt|Doc File | *.docx |Rich Text Formate |*.rtf |All Files |*.*"
        If save_file.ShowDialog = DialogResult.OK Then
            rtf.SaveFile(save_file.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        save_file_icone()
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        rtf.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        rtf.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        rtf.Paste()
    End Sub

    Private Sub timeer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeer.Tick
        date_time.Text = System.DateTime.Now
    End Sub

    Private Sub CleaerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleaerToolStripMenuItem.Click
        rtf.Clear()
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        rtf.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        rtf.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rtf.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub UndoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem1.Click
        rtf.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem1.Click
        rtf.Redo()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem1.Click
        rtf.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        rtf.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        rtf.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem1.Click
        rtf.Focus()
        rtf.SelectAll()
    End Sub

    Private Sub CenterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        rtf.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub rtf_Enter(sender As Object, e As System.EventArgs) Handles rtf.Enter
        count_txt.Text = "Character count " & rtf.Text.Length
    End Sub

    Private Sub rtf_TextChanged(sender As System.Object, e As System.EventArgs) Handles rtf.TextChanged
        count_txt.Text = "Character count " & rtf.Text.Length
    End Sub
End Class
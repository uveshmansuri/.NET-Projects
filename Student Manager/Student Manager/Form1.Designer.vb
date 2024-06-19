<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.course_selection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.contect_txt = New System.Windows.Forms.MaskedTextBox()
        Me.no_txt = New System.Windows.Forms.MaskedTextBox()
        Me.male_btn = New System.Windows.Forms.RadioButton()
        Me.female_btn = New System.Windows.Forms.RadioButton()
        Me.dob_pick = New System.Windows.Forms.DateTimePicker()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.C2 = New System.Windows.Forms.CheckBox()
        Me.C3 = New System.Windows.Forms.CheckBox()
        Me.C4 = New System.Windows.Forms.CheckBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ins_btn = New System.Windows.Forms.Button()
        Me.up_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'course_selection
        '
        Me.course_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.course_selection.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.course_selection.FormattingEnabled = True
        Me.course_selection.Items.AddRange(New Object() {"BCom", "BSc", "BScCS", "BCA", "BA", "MCom", "MSC", "MCA", "MSc IT", "MBA", "MA", "LLB", "LLM"})
        Me.course_selection.Location = New System.Drawing.Point(136, 282)
        Me.course_selection.Name = "course_selection"
        Me.course_selection.Size = New System.Drawing.Size(176, 27)
        Me.course_selection.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acadmic Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(8, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(60, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(34, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contect No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(18, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(60, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(51, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Activity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(63, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Course"
        '
        'name_txt
        '
        Me.name_txt.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.name_txt.Location = New System.Drawing.Point(142, 89)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(170, 27)
        Me.name_txt.TabIndex = 19
        '
        'address_txt
        '
        Me.address_txt.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.address_txt.Location = New System.Drawing.Point(142, 119)
        Me.address_txt.Multiline = True
        Me.address_txt.Name = "address_txt"
        Me.address_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.address_txt.Size = New System.Drawing.Size(170, 58)
        Me.address_txt.TabIndex = 20
        '
        'contect_txt
        '
        Me.contect_txt.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contect_txt.Location = New System.Drawing.Point(142, 183)
        Me.contect_txt.Mask = "+000000000000"
        Me.contect_txt.Name = "contect_txt"
        Me.contect_txt.Size = New System.Drawing.Size(117, 27)
        Me.contect_txt.TabIndex = 21
        Me.contect_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'no_txt
        '
        Me.no_txt.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.no_txt.Location = New System.Drawing.Point(142, 56)
        Me.no_txt.Mask = "0000000"
        Me.no_txt.Name = "no_txt"
        Me.no_txt.Size = New System.Drawing.Size(131, 27)
        Me.no_txt.TabIndex = 22
        Me.no_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'male_btn
        '
        Me.male_btn.AutoSize = True
        Me.male_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.male_btn.Location = New System.Drawing.Point(136, 253)
        Me.male_btn.Name = "male_btn"
        Me.male_btn.Size = New System.Drawing.Size(68, 23)
        Me.male_btn.TabIndex = 23
        Me.male_btn.TabStop = True
        Me.male_btn.Text = "Male"
        Me.male_btn.UseVisualStyleBackColor = True
        '
        'female_btn
        '
        Me.female_btn.AutoSize = True
        Me.female_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.female_btn.Location = New System.Drawing.Point(210, 253)
        Me.female_btn.Name = "female_btn"
        Me.female_btn.Size = New System.Drawing.Size(88, 23)
        Me.female_btn.TabIndex = 24
        Me.female_btn.TabStop = True
        Me.female_btn.Text = "Female"
        Me.female_btn.UseVisualStyleBackColor = True
        '
        'dob_pick
        '
        Me.dob_pick.CustomFormat = "dd-MMM-yyyy"
        Me.dob_pick.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dob_pick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob_pick.Location = New System.Drawing.Point(142, 216)
        Me.dob_pick.MaxDate = New Date(2008, 6, 1, 0, 0, 0, 0)
        Me.dob_pick.MinDate = New Date(1990, 6, 1, 0, 0, 0, 0)
        Me.dob_pick.Name = "dob_pick"
        Me.dob_pick.Size = New System.Drawing.Size(170, 27)
        Me.dob_pick.TabIndex = 26
        Me.dob_pick.Value = New Date(2008, 6, 1, 0, 0, 0, 0)
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C1.Location = New System.Drawing.Point(136, 322)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(65, 23)
        Me.C1.TabIndex = 28
        Me.C1.Text = "NCC"
        Me.C1.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C2.Location = New System.Drawing.Point(207, 322)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(83, 23)
        Me.C2.TabIndex = 29
        Me.C2.Text = "Sports"
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C3.Location = New System.Drawing.Point(296, 322)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(63, 23)
        Me.C3.TabIndex = 30
        Me.C3.Text = "NSS"
        Me.C3.UseVisualStyleBackColor = True
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C4.Location = New System.Drawing.Point(365, 322)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(84, 23)
        Me.C4.TabIndex = 31
        Me.C4.Text = "Drama"
        Me.C4.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv.Location = New System.Drawing.Point(451, 64)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(536, 190)
        Me.dgv.TabIndex = 32
        '
        'ins_btn
        '
        Me.ins_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ins_btn.Location = New System.Drawing.Point(55, 364)
        Me.ins_btn.Name = "ins_btn"
        Me.ins_btn.Size = New System.Drawing.Size(81, 34)
        Me.ins_btn.TabIndex = 33
        Me.ins_btn.Text = "Insert&i"
        Me.ins_btn.UseVisualStyleBackColor = True
        '
        'up_btn
        '
        Me.up_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.up_btn.Location = New System.Drawing.Point(142, 364)
        Me.up_btn.Name = "up_btn"
        Me.up_btn.Size = New System.Drawing.Size(98, 34)
        Me.up_btn.TabIndex = 34
        Me.up_btn.Text = "Update&u"
        Me.up_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.del_btn.Location = New System.Drawing.Point(242, 364)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(96, 34)
        Me.del_btn.TabIndex = 35
        Me.del_btn.Text = "Delete&d"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'clr_btn
        '
        Me.clr_btn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clr_btn.Location = New System.Drawing.Point(207, 404)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(86, 34)
        Me.clr_btn.TabIndex = 36
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(96, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Search&s"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(335, 24)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Student's Acadmic Detail Manager"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 486)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clr_btn)
        Me.Controls.Add(Me.del_btn)
        Me.Controls.Add(Me.up_btn)
        Me.Controls.Add(Me.ins_btn)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.course_selection)
        Me.Controls.Add(Me.female_btn)
        Me.Controls.Add(Me.dob_pick)
        Me.Controls.Add(Me.male_btn)
        Me.Controls.Add(Me.no_txt)
        Me.Controls.Add(Me.contect_txt)
        Me.Controls.Add(Me.address_txt)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Student Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents name_txt As System.Windows.Forms.TextBox
    Friend WithEvents address_txt As System.Windows.Forms.TextBox
    Friend WithEvents contect_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents no_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents male_btn As System.Windows.Forms.RadioButton
    Friend WithEvents female_btn As System.Windows.Forms.RadioButton
    Friend WithEvents dob_pick As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents C2 As System.Windows.Forms.CheckBox
    Friend WithEvents C3 As System.Windows.Forms.CheckBox
    Friend WithEvents C4 As System.Windows.Forms.CheckBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ins_btn As System.Windows.Forms.Button
    Friend WithEvents course_selection As System.Windows.Forms.ComboBox
    Friend WithEvents up_btn As System.Windows.Forms.Button
    Friend WithEvents del_btn As System.Windows.Forms.Button
    Friend WithEvents clr_btn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class

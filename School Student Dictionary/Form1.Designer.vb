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
        Me.btn_addstudent = New System.Windows.Forms.Button()
        Me.btn_editstudent = New System.Windows.Forms.Button()
        Me.btn_deletestudent = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_studentfirstname = New System.Windows.Forms.Label()
        Me.txt_averagegrade = New System.Windows.Forms.TextBox()
        Me.lbl_studentID = New System.Windows.Forms.Label()
        Me.txt_studentlastname = New System.Windows.Forms.TextBox()
        Me.lbl_studentlastname = New System.Windows.Forms.Label()
        Me.txt_studentID = New System.Windows.Forms.TextBox()
        Me.lbl_grade = New System.Windows.Forms.Label()
        Me.txt_studentfirstname = New System.Windows.Forms.TextBox()
        Me.lst_students = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_addstudent
        '
        Me.btn_addstudent.Location = New System.Drawing.Point(474, 91)
        Me.btn_addstudent.Name = "btn_addstudent"
        Me.btn_addstudent.Size = New System.Drawing.Size(133, 20)
        Me.btn_addstudent.TabIndex = 0
        Me.btn_addstudent.Text = "Add Student"
        Me.btn_addstudent.UseVisualStyleBackColor = True
        '
        'btn_editstudent
        '
        Me.btn_editstudent.Location = New System.Drawing.Point(492, 215)
        Me.btn_editstudent.Name = "btn_editstudent"
        Me.btn_editstudent.Size = New System.Drawing.Size(133, 46)
        Me.btn_editstudent.TabIndex = 1
        Me.btn_editstudent.Text = "Edit Student"
        Me.btn_editstudent.UseVisualStyleBackColor = True
        '
        'btn_deletestudent
        '
        Me.btn_deletestudent.Location = New System.Drawing.Point(492, 267)
        Me.btn_deletestudent.Name = "btn_deletestudent"
        Me.btn_deletestudent.Size = New System.Drawing.Size(133, 46)
        Me.btn_deletestudent.TabIndex = 2
        Me.btn_deletestudent.Text = "Delete Student"
        Me.btn_deletestudent.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_studentfirstname)
        Me.GroupBox1.Controls.Add(Me.txt_averagegrade)
        Me.GroupBox1.Controls.Add(Me.lbl_studentID)
        Me.GroupBox1.Controls.Add(Me.btn_addstudent)
        Me.GroupBox1.Controls.Add(Me.txt_studentlastname)
        Me.GroupBox1.Controls.Add(Me.lbl_studentlastname)
        Me.GroupBox1.Controls.Add(Me.txt_studentID)
        Me.GroupBox1.Controls.Add(Me.lbl_grade)
        Me.GroupBox1.Controls.Add(Me.txt_studentfirstname)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 122)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lbl_studentfirstname
        '
        Me.lbl_studentfirstname.AutoSize = True
        Me.lbl_studentfirstname.Location = New System.Drawing.Point(6, 42)
        Me.lbl_studentfirstname.Name = "lbl_studentfirstname"
        Me.lbl_studentfirstname.Size = New System.Drawing.Size(57, 13)
        Me.lbl_studentfirstname.TabIndex = 11
        Me.lbl_studentfirstname.Text = "First Name"
        '
        'txt_averagegrade
        '
        Me.txt_averagegrade.Location = New System.Drawing.Point(124, 91)
        Me.txt_averagegrade.Name = "txt_averagegrade"
        Me.txt_averagegrade.Size = New System.Drawing.Size(344, 20)
        Me.txt_averagegrade.TabIndex = 3
        '
        'lbl_studentID
        '
        Me.lbl_studentID.AutoSize = True
        Me.lbl_studentID.Location = New System.Drawing.Point(6, 16)
        Me.lbl_studentID.Name = "lbl_studentID"
        Me.lbl_studentID.Size = New System.Drawing.Size(58, 13)
        Me.lbl_studentID.TabIndex = 12
        Me.lbl_studentID.Text = "Student ID"
        '
        'txt_studentlastname
        '
        Me.txt_studentlastname.Location = New System.Drawing.Point(124, 65)
        Me.txt_studentlastname.Name = "txt_studentlastname"
        Me.txt_studentlastname.Size = New System.Drawing.Size(483, 20)
        Me.txt_studentlastname.TabIndex = 2
        '
        'lbl_studentlastname
        '
        Me.lbl_studentlastname.AutoSize = True
        Me.lbl_studentlastname.Location = New System.Drawing.Point(6, 68)
        Me.lbl_studentlastname.Name = "lbl_studentlastname"
        Me.lbl_studentlastname.Size = New System.Drawing.Size(58, 13)
        Me.lbl_studentlastname.TabIndex = 13
        Me.lbl_studentlastname.Text = "Last Name"
        '
        'txt_studentID
        '
        Me.txt_studentID.Location = New System.Drawing.Point(124, 13)
        Me.txt_studentID.Name = "txt_studentID"
        Me.txt_studentID.Size = New System.Drawing.Size(483, 20)
        Me.txt_studentID.TabIndex = 0
        '
        'lbl_grade
        '
        Me.lbl_grade.AutoSize = True
        Me.lbl_grade.Location = New System.Drawing.Point(6, 94)
        Me.lbl_grade.Name = "lbl_grade"
        Me.lbl_grade.Size = New System.Drawing.Size(79, 13)
        Me.lbl_grade.TabIndex = 14
        Me.lbl_grade.Text = "Average Grade"
        '
        'txt_studentfirstname
        '
        Me.txt_studentfirstname.Location = New System.Drawing.Point(124, 39)
        Me.txt_studentfirstname.Name = "txt_studentfirstname"
        Me.txt_studentfirstname.Size = New System.Drawing.Size(483, 20)
        Me.txt_studentfirstname.TabIndex = 1
        '
        'lst_students
        '
        Me.lst_students.FormattingEnabled = True
        Me.lst_students.Location = New System.Drawing.Point(12, 140)
        Me.lst_students.Name = "lst_students"
        Me.lst_students.Size = New System.Drawing.Size(474, 173)
        Me.lst_students.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 330)
        Me.Controls.Add(Me.lst_students)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_deletestudent)
        Me.Controls.Add(Me.btn_editstudent)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_addstudent As Button
    Friend WithEvents btn_editstudent As Button
    Friend WithEvents btn_deletestudent As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_studentfirstname As Label
    Friend WithEvents txt_averagegrade As TextBox
    Friend WithEvents lbl_studentID As Label
    Friend WithEvents txt_studentlastname As TextBox
    Friend WithEvents lbl_studentlastname As Label
    Friend WithEvents txt_studentID As TextBox
    Friend WithEvents lbl_grade As Label
    Friend WithEvents txt_studentfirstname As TextBox
    Friend WithEvents lst_students As ListBox
End Class

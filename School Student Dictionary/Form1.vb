Public Class Form1
    Private studentdatabase As Dictionary(Of Integer, Student)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentdatabase = New Dictionary(Of Integer, Student)
    End Sub

    Private Sub btn_addstudent_Click(sender As Object, e As EventArgs) Handles btn_addstudent.Click
        For Each c As Control In GroupBox1.Controls
            If (TypeOf c Is TextBox) Then
                Dim cText As TextBox = CType(c, TextBox)
                If (cText.Text.Equals("")) Then
                    MsgBox("All fields must be filled")
                    Return
                End If
            End If
        Next


        If (btn_addstudent.Text.Equals("Add Student")) Then
            Dim studenttoadd As New Student(txt_studentfirstname.Text, txt_studentlastname.Text,
                                            txt_averagegrade.Text)
            AddStudent(CInt(txt_studentID.Text), studenttoadd)
        ElseIf (btn_addstudent.text.Equals("Edit Student")) Then
            Dim studenttoreplace As New Student(txt_studentfirstname.Text, txt_studentlastname.Text,
                                                txt_averagegrade.Text)
            editstudent(CInt(txt_studentID.Text), studenttoreplace)

        End If
    End Sub

    Public Sub editstudent(ByVal IDnumber As Integer, ByVal student As Student)
        studentdatabase.Remove(IDnumber)
        studentdatabase.Add(IDnumber, student)

        btn_addstudent.Text = "Add Student"
        txt_studentID.Enabled = True
        refreshlistbox()
    End Sub

    Public Sub AddStudent(ByVal IDnumber As Integer, ByVal student As Student)
        If (studentdatabase.ContainsKey(IDnumber)) Then
            Dim studenttocheck As Student = studentdatabase.Item(IDnumber)
            Dim msgboxresult As DialogResult
            msgboxresult = MessageBox.Show("That ID number already exists. It belongs to: " _
                                           & studenttocheck.FirstName & " " & studenttocheck.LastName &
                                           " would you like to replace this student?",
                                           "Replace?", MessageBoxButtons.YesNo)
            If (msgboxresult = DialogResult.Yes) Then
                studentdatabase.Remove(IDnumber)
                studentdatabase.Add(IDnumber, student)
            End If
        Else
            studentdatabase.Add(IDnumber, student)
        End If

        refreshlistbox()
    End Sub

    Public Sub DeleteStudent(ByVal IDnumber As Integer)
        studentdatabase.Remove(IDnumber)

        refreshlistbox()
    End Sub


    Public Sub refreshlistbox()
        lst_students.Items.Clear()
        For Each id As Integer In studentdatabase.Keys
            Dim Student As Student = studentdatabase.Item(id)
            lst_students.Items.Add(id & ": " & Student.FirstName & " " & Student.LastName &
                                   " (" & Student.AverageGrade & ")")

        Next
    End Sub

    Private Sub btn_deletestudent_Click(sender As Object, e As EventArgs) Handles btn_deletestudent.Click
        If Not (lst_students.SelectedItem Is Nothing) Then
            Dim studentinformation As String = lst_students.SelectedItem.ToString
            Dim studentid As Integer = CInt(studentinformation.Split(":")(0))
            DeleteStudent(studentid)
        End If
    End Sub

    Private Sub btn_editstudent_Click(sender As Object, e As EventArgs) Handles btn_editstudent.Click
        If Not (lst_students.SelectedItem Is Nothing) Then
            Dim studentinformation As String = lst_students.SelectedItem.ToString
            txt_studentID.Text = studentinformation.Split(":")(0).ToString
            txt_studentID.Enabled = False
            txt_studentfirstname.Text = studentinformation.Split(":")(1).Split(" ")(1).ToString
            txt_studentlastname.Text = studentinformation.Split(":")(1).Split(" ")(2).ToString
            Dim averagegrade As String = studentinformation.Split(":")(1).Split(" ")(3)
            averagegrade = averagegrade.Replace("(", "")
            averagegrade = averagegrade.Replace(")", "")
            txt_averagegrade.Text = averagegrade

            btn_addstudent.Text = "Edit Student"
        End If
    End Sub

End Class

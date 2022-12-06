Imports System.IO

Public Class CourseEnrollment
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Reads all the CSV files and puts them into a rich textbox
        Dim DisplayStudents As String
        DisplayStudents = My.Computer.FileSystem.ReadAllText("students.csv")

        Dim DisplayInstructor As String
        DisplayInstructor = My.Computer.FileSystem.ReadAllText("instructor.csv")

        Dim DisplayCourse As String
        DisplayCourse = My.Computer.FileSystem.ReadAllText("course.csv")


        Dim Identifier As String = ""
        txtDisplayInformation.Text = "Student:" + Environment.NewLine + DisplayStudents + Environment.NewLine + "Instructor: " + Environment.NewLine + DisplayInstructor + Environment.NewLine + "Course Information: " + Environment.NewLine + DisplayCourse

        'This is responsible for making certain words bold
        Identifier = "Student:"
        txtDisplayInformation.SelectionStart = txtDisplayInformation.Text.IndexOf(Identifier)
        txtDisplayInformation.SelectionLength = Identifier.Length
        txtDisplayInformation.SelectionFont = New Font("Times New Roman", 16, FontStyle.Bold)


        Identifier = "Instructor: "
        txtDisplayInformation.SelectionStart = txtDisplayInformation.Text.IndexOf(Identifier)
        txtDisplayInformation.SelectionLength = Identifier.Length
        txtDisplayInformation.SelectionFont = New Font("Times New Roman", 16, FontStyle.Bold)

        Identifier = "Course Information: "
        txtDisplayInformation.SelectionStart = txtDisplayInformation.Text.IndexOf(Identifier)
        txtDisplayInformation.SelectionLength = Identifier.Length
        txtDisplayInformation.SelectionFont = New Font("Times New Roman", 16, FontStyle.Bold)

    End Sub

    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDataToolStripMenuItem.Click

        txtDisplayInformation.Text = ""

    End Sub


    'clears textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplayInformation.Clear()
    End Sub

    'sends to main form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub
End Class
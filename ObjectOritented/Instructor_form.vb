Imports System.IO

Public Class Instructor_form

    Dim oInstructor As instructor

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'instantiating
        oInstructor = New instructor
        oInstructor.FistName = txtInstructor_FirstName.Text
        oInstructor.LastName = txtInstructor_LastName.Text
        oInstructor.email = txtInstructor_Email.Text
        oInstructor.OfficePhoneNumber = txt_instructor_officenumber.Text

        'When the button is pressed it writes the contexts of textboxes to Instructor.CSV

        Dim writen As Boolean = writeToInstructor("instructor.csv", oInstructor.FistName, oInstructor.LastName, oInstructor.email, oInstructor.OfficePhoneNumber, ",")

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click


        'Displays instructors in a datagrid
        Dim instructors() As String = IO.File.ReadAllLines("instructor.csv")


        'Sorting the data based on its position in the text file
        Dim query = From line In instructors
                    Let data = line.Split(",")
                    Let firstName = data(0)
                    Let lastName = data(1)
                    Let email = data(2)
                    Let officePhoneNumber = data(3)

        DisplayInstructorData.DataSource = query.ToList
        Me.DisplayInstructorData.Columns.RemoveAt(0)

        DisplayInstructorData.Columns("firstName").HeaderText = "First Name"
        DisplayInstructorData.Columns("lastName").HeaderText = "Last Name"
        DisplayInstructorData.Columns("email").HeaderText = "Instructor Email"
        DisplayInstructorData.Columns("officePhoneNumber").HeaderText = "Offce Phone Number"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closes the form sends the user back to the main form
        Me.Close()

    End Sub

    'Writes to the CSV Instructor file 

    Function writeToInstructor(ByVal Filepath As String, ByVal firstName As String, ByVal lastName As String, ByVal instructorEmail As String, ByVal officeNumber As String, ByVal delimiter As String) As Boolean

        Dim fileWriters As New System.IO.StreamWriter(Filepath, True)

        Dim record As String = firstName + delimiter + lastName + delimiter + instructorEmail + delimiter + officeNumber + delimiter
        fileWriters.WriteLine(record)
        fileWriters.Close()

        Return True

    End Function

    Private Sub ClearTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTextToolStripMenuItem.Click

        'Clears Data From CSV
        System.IO.File.WriteAllText("instructor.csv", "")


        'Clears data grid

        DisplayInstructorData.DataSource = Nothing

        'Clears Instructor textboxs
        txtInstructor_FirstName.Clear()
        txtInstructor_LastName.Clear()
        txtInstructor_Email.Clear()
        txt_instructor_officenumber.Clear()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clears textboxs
        txtInstructor_FirstName.Clear()
        txtInstructor_LastName.Clear()
        txt_instructor_officenumber.Clear()
        txtInstructor_Email.Clear()

    End Sub
End Class


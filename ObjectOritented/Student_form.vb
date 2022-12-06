Imports System.IO

Public Class Student_form

    Dim ooStudent As Student_Class



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'instantiating  
        ooStudent = New Student_Class

        ooStudent.FistName = txtStudentName.Text
        ooStudent.LastName = txtStudentLastName.Text
        ooStudent.email = txtEmail.Text
        ooStudent.units = txtStudentUnits.Text

        'When the button is pressed it writes the contexts of textboxes to Students.CSV
        Dim writen As Boolean = WriteToStudent("students.csv", ooStudent.FistName, ooStudent.LastName, ooStudent.email, ooStudent.units, ",")

        Dim lineCount = File.ReadLines("Students.csv").Count()
        lblUpdateStudents.Text = lineCount

        'Checks for 20 lines
        If lineCount >= 20 Then
            MessageBox.Show("Maximum Number of Students Reached. To Enter More Data Go to File -> Data - Clear Data")
            txtStudentName.ReadOnly = True
            txtStudentLastName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtStudentUnits.ReadOnly = True
        End If




    End Sub


    Private Sub btnDisplayStudent_Click(sender As Object, e As EventArgs) Handles btnDisplayStudent.Click

        'Displays Students.csv into a Datagrid
        Dim students = IO.File.ReadLines("students.csv").Take(20)

        'Sorting the data based on its position in the text file
        Dim query = From line In students
                    Let data = line.Split(",")
                    Let firstName = data(0)
                    Let lastName = data(1)
                    Let studentEmail = data(2)
                    Let Units = data(3)

        DisplayDataGridStudent.DataSource = query.ToList
        Me.DisplayDataGridStudent.Columns.RemoveAt(0)

        DisplayDataGridStudent.Columns("firstName").HeaderText = "First Name"
        DisplayDataGridStudent.Columns("lastName").HeaderText = "Last Name"
        DisplayDataGridStudent.Columns("studentEmail").HeaderText = "Student Email"
        DisplayDataGridStudent.Columns("Units").HeaderText = "Units"

    End Sub

    'Sends user back to the main form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


    'Resonsible for formating the way information is put in the csv file
    Function WriteToStudent(ByVal Filepath As String, ByVal firstName As String, ByVal lastName As String, ByVal studentEmail As String, ByVal Units As String, ByVal delimiter As String) As Boolean

        Dim fileWriters As New System.IO.StreamWriter(Filepath, True)

        Dim record As String = firstName + delimiter + lastName + delimiter + studentEmail + delimiter + Units + delimiter
        fileWriters.WriteLine(record)
        fileWriters.Close()

        Return True

    End Function

    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDataToolStripMenuItem.Click

        'responsible for clearing CSV
        System.IO.File.WriteAllText("Students.csv", "")

        'clears data grid

        DisplayDataGridStudent.DataSource = Nothing

        'Resets Student Counter

        lblUpdateStudents.Text = "0"


        'Clears Student textboxs
        txtStudentName.Text = ""
        txtStudentLastName.Text = ""
        txtEmail.Text = ""
        txtStudentUnits.Text = ""





        'checks if there is 20 lines

        Dim lineCount = File.ReadLines("Students.csv").Count()


        If lineCount >= 20 Then
            MessageBox.Show("Maximum Number of Students Reached. To Enter more Naviage to File -> Data - Clear Data")
            txtStudentName.ReadOnly = True
            txtStudentLastName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtStudentUnits.ReadOnly = True
        Else
            txtStudentName.ReadOnly = False
            txtStudentLastName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtStudentUnits.ReadOnly = False
        End If



    End Sub

    Private Sub Student_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'When the form loads it counts how many lines are written in the CVS Student File then displays it to a label
        Dim lineCount = File.ReadLines("Students.csv").Count()
        lblUpdateStudents.Text = lineCount


        'checks if there is 20 lines
        If lineCount >= 20 Then
            MessageBox.Show("Maximum Number of Students Reached. To Enter more Naviage to File -> Data - Clear Data")
            txtStudentName.ReadOnly = True
            txtStudentLastName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtStudentUnits.ReadOnly = True
        Else
            txtStudentName.ReadOnly = False
            txtStudentLastName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtStudentUnits.ReadOnly = False
        End If


    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click

        'clear text boxes
        txtStudentName.Clear()
        txtStudentLastName.Clear()
        txtStudentUnits.Clear()
        txtEmail.Clear()

    End Sub
End Class
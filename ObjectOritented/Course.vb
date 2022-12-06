Public Class Course

    Dim ocourse As Course_Class

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'instantiating 
        ocourse = New Course_Class

        ocourse.CourseNumber = txtCourseNumber.Text
        ocourse.CourseName = txtCourseName.Text
        ocourse.day = txtDay.Text
        ocourse.hours = txtHours.Text
        ocourse.units = txtUnits.Text
        ocourse.roomnumber = txtRoomNumber.Text
        ocourse.TaFirstName = txtTaFirstName.Text
        ocourse.TaEmail = txtTaEmail.Text

        'When the button is pressed it writes the contents of textboxes to Course.CSV
        Dim writen As Boolean = writeToCourse("course.csv", ocourse.CourseNumber, ocourse.CourseName, ocourse.day, ocourse.hours, ocourse.units, ocourse.roomnumber, ocourse.TaFirstName, ocourse.TaEmail, ",")

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Displays Course.csv into a Datagrid
        Dim course() As String = IO.File.ReadAllLines("course.csv")


        'Sorting the data based on its position in the text file
        Dim query = From line In course
                    Let data = line.Split(",")
                    Let courseNumber = data(0)
                    Let courseName = data(1)
                    Let day = data(2)
                    Let hours = data(3)
                    Let units = data(4)
                    Let roomnumber = data(5)
                    Let tafirstname = data(6)
                    Let taEmail = data(7)

        DisplayCourseData.DataSource = query.ToList
        Me.DisplayCourseData.Columns.RemoveAt(0)

        DisplayCourseData.Columns("courseNumber").HeaderText = "Course Number"
        DisplayCourseData.Columns("courseName").HeaderText = "Course Name"
        DisplayCourseData.Columns("day").HeaderText = "Days"
        DisplayCourseData.Columns("hours").HeaderText = "Hours"
        DisplayCourseData.Columns("units").HeaderText = "Units"
        DisplayCourseData.Columns("roomnumber").HeaderText = "Room Number"
        DisplayCourseData.Columns("tafirstname").HeaderText = "Ta First Name"
        DisplayCourseData.Columns("taEmail").HeaderText = "Ta Email"

    End Sub

    'sends the user back to the main form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    'Resonsible for formating the way information is put in the csv file
    Function writeToCourse(ByVal Filepath As String, ByVal courseNumber As String, ByVal courseName As String, ByVal Day As String, ByVal Hours As String, ByVal Units As String, ByVal roomNumber As String, ByVal tafirstName As String, ByVal taEmail As String, ByVal delimiter As String) As Boolean

        Dim fileWriters As New System.IO.StreamWriter(Filepath, True)

        Dim record As String = courseNumber + delimiter + courseName + delimiter + Day + delimiter + Hours + delimiter + Units + delimiter + roomNumber + delimiter + tafirstName + delimiter + taEmail + delimiter
        fileWriters.WriteLine(record)
        fileWriters.Close()

        Return True

    End Function

    Private Sub ClearCSVDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCSVDataToolStripMenuItem.Click

        'Clears CSV
        System.IO.File.WriteAllText("course.csv", "")

        'Clears data grid

        DisplayCourseData.DataSource = Nothing


        'Clear Course textboxs 
        txtCourseNumber.Clear()
        txtCourseName.Clear()
        txtDay.Clear()
        txtHours.Clear()
        txtUnits.Clear()
        txtRoomNumber.Clear()
        txtTaFirstName.Clear()
        txtTaEmail.Clear()


    End Sub

    'clear text boxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtCourseName.Clear()
        txtCourseNumber.Clear()
        txtDay.Clear()
        txtHours.Clear()
        txtRoomNumber.Clear()
        txtTaEmail.Clear()
        txtTaFirstName.Clear()
        txtUnits.Clear()

    End Sub
End Class
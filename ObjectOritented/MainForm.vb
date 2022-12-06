Imports System.Runtime.CompilerServices

Public Class MainForm
    Private Sub btnSendToStudent_Click(sender As Object, e As EventArgs) Handles btnSendToStudent.Click

        'Hides MainForm ---> Creates a new Student Form ---> Display new form
        Me.Hide()
        Dim frmStudent As New Student_form
        frmStudent.ShowDialog()
        Me.Show()



    End Sub

    Private Sub btnSendToInstructor_Click(sender As Object, e As EventArgs) Handles btnSendToInstructor.Click

        'Hides MainForm ---> Creates a new Instructor Form ---> Display new form
        Me.Hide()
        Dim frmInstructor As New Instructor_form
        Instructor_form.ShowDialog()
        Me.Show()




    End Sub

    Private Sub btnSendToCourse_Click(sender As Object, e As EventArgs) Handles btnSendToCourse.Click

        'Hides MainForm ---> Creates a new Course Form ---> Display new form
        Me.Hide()
        Dim frmCourse As New Course
        Course.ShowDialog()
        Me.Show()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'Exits of program
        Me.Close()

    End Sub

    Private Sub btnCourseEnrollment_Click(sender As Object, e As EventArgs) Handles btnCourseEnrollment.Click

        'Hides MainForm ---> Creates a new CourseEnrollment Form ---> Display new form
        Me.Hide()
        Dim frmCourseEnrollment As New CourseEnrollment
        CourseEnrollment.ShowDialog()
        Me.Show()


    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSendToStudent = New System.Windows.Forms.Button()
        Me.btnSendToInstructor = New System.Windows.Forms.Button()
        Me.btnSendToCourse = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCourseEnrollment = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(263, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose a page"
        '
        'btnSendToStudent
        '
        Me.btnSendToStudent.Location = New System.Drawing.Point(186, 227)
        Me.btnSendToStudent.Name = "btnSendToStudent"
        Me.btnSendToStudent.Size = New System.Drawing.Size(127, 89)
        Me.btnSendToStudent.TabIndex = 2
        Me.btnSendToStudent.Text = "1.Student"
        Me.btnSendToStudent.UseVisualStyleBackColor = True
        '
        'btnSendToInstructor
        '
        Me.btnSendToInstructor.Location = New System.Drawing.Point(335, 227)
        Me.btnSendToInstructor.Name = "btnSendToInstructor"
        Me.btnSendToInstructor.Size = New System.Drawing.Size(113, 89)
        Me.btnSendToInstructor.TabIndex = 3
        Me.btnSendToInstructor.Text = "2. Instructor "
        Me.btnSendToInstructor.UseVisualStyleBackColor = True
        '
        'btnSendToCourse
        '
        Me.btnSendToCourse.Location = New System.Drawing.Point(464, 227)
        Me.btnSendToCourse.Name = "btnSendToCourse"
        Me.btnSendToCourse.Size = New System.Drawing.Size(119, 89)
        Me.btnSendToCourse.TabIndex = 4
        Me.btnSendToCourse.Text = "3.Course"
        Me.btnSendToCourse.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnCourseEnrollment
        '
        Me.btnCourseEnrollment.Location = New System.Drawing.Point(607, 227)
        Me.btnCourseEnrollment.Name = "btnCourseEnrollment"
        Me.btnCourseEnrollment.Size = New System.Drawing.Size(175, 89)
        Me.btnCourseEnrollment.TabIndex = 6
        Me.btnCourseEnrollment.Text = "4. See Course Enrollment"
        Me.btnCourseEnrollment.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 522)
        Me.Controls.Add(Me.btnCourseEnrollment)
        Me.Controls.Add(Me.btnSendToCourse)
        Me.Controls.Add(Me.btnSendToInstructor)
        Me.Controls.Add(Me.btnSendToStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSendToStudent As Button
    Friend WithEvents btnSendToInstructor As Button
    Friend WithEvents btnSendToCourse As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCourseEnrollment As Button
End Class

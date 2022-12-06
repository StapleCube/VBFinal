<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_form
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
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtStudentLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentUnits = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnDisplayStudent = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DisplayDataGridStudent = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTextStudents = New System.Windows.Forms.Label()
        Me.lblUpdateStudents = New System.Windows.Forms.Label()
        Me.btnClearText = New System.Windows.Forms.Button()
        CType(Me.DisplayDataGridStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(491, 124)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(100, 23)
        Me.txtStudentName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(378, 183)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(107, 15)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Student Last Name"
        '
        'txtStudentLastName
        '
        Me.txtStudentLastName.Location = New System.Drawing.Point(491, 180)
        Me.txtStudentLastName.Name = "txtStudentLastName"
        Me.txtStudentLastName.Size = New System.Drawing.Size(100, 23)
        Me.txtStudentLastName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(682, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Units"
        '
        'txtStudentUnits
        '
        Me.txtStudentUnits.Location = New System.Drawing.Point(722, 180)
        Me.txtStudentUnits.Name = "txtStudentUnits"
        Me.txtStudentUnits.Size = New System.Drawing.Size(100, 23)
        Me.txtStudentUnits.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Student Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(722, 124)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 23)
        Me.txtEmail.TabIndex = 2
        '
        'btnDisplayStudent
        '
        Me.btnDisplayStudent.Location = New System.Drawing.Point(697, 242)
        Me.btnDisplayStudent.Name = "btnDisplayStudent"
        Me.btnDisplayStudent.Size = New System.Drawing.Size(137, 23)
        Me.btnDisplayStudent.TabIndex = 5
        Me.btnDisplayStudent.Text = "2.Display"
        Me.btnDisplayStudent.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(368, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(588, 60)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Student information"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(472, 555)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(362, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Main Form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(454, 242)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "1.Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DisplayDataGridStudent
        '
        Me.DisplayDataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayDataGridStudent.Location = New System.Drawing.Point(432, 271)
        Me.DisplayDataGridStudent.Name = "DisplayDataGridStudent"
        Me.DisplayDataGridStudent.ReadOnly = True
        Me.DisplayDataGridStudent.RowTemplate.Height = 25
        Me.DisplayDataGridStudent.Size = New System.Drawing.Size(442, 226)
        Me.DisplayDataGridStudent.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1273, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearDataToolStripMenuItem})
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.TextFileToolStripMenuItem.Text = "Data"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClearDataToolStripMenuItem.Text = "Clear Data"
        '
        'lblTextStudents
        '
        Me.lblTextStudents.AutoSize = True
        Me.lblTextStudents.Location = New System.Drawing.Point(558, 87)
        Me.lblTextStudents.Name = "lblTextStudents"
        Me.lblTextStudents.Size = New System.Drawing.Size(117, 15)
        Me.lblTextStudents.TabIndex = 16
        Me.lblTextStudents.Text = "Number of Students:"
        '
        'lblUpdateStudents
        '
        Me.lblUpdateStudents.AutoSize = True
        Me.lblUpdateStudents.Location = New System.Drawing.Point(675, 87)
        Me.lblUpdateStudents.Name = "lblUpdateStudents"
        Me.lblUpdateStudents.Size = New System.Drawing.Size(0, 15)
        Me.lblUpdateStudents.TabIndex = 17
        '
        'btnClearText
        '
        Me.btnClearText.Location = New System.Drawing.Point(591, 515)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(137, 23)
        Me.btnClearText.TabIndex = 18
        Me.btnClearText.Text = "Clear Text Boxes"
        Me.btnClearText.UseVisualStyleBackColor = True
        '
        'Student_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 653)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.lblUpdateStudents)
        Me.Controls.Add(Me.lblTextStudents)
        Me.Controls.Add(Me.DisplayDataGridStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplayStudent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStudentUnits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtStudentLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Student_form"
        Me.Text = "Student Information"
        CType(Me.DisplayDataGridStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txtStudentLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentUnits As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnDisplayStudent As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DisplayDataGridStudent As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTextStudents As Label
    Friend WithEvents lblUpdateStudents As Label
    Friend WithEvents btnClearText As Button
End Class

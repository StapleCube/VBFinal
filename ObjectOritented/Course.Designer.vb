<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourseNumber = New System.Windows.Forms.TextBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTaEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTaFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.DisplayCourseData = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FiileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCSVDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.DisplayCourseData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(80, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Number"
        '
        'txtCourseNumber
        '
        Me.txtCourseNumber.Location = New System.Drawing.Point(113, 117)
        Me.txtCourseNumber.Name = "txtCourseNumber"
        Me.txtCourseNumber.Size = New System.Drawing.Size(100, 23)
        Me.txtCourseNumber.TabIndex = 1
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(113, 166)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(100, 23)
        Me.txtCourseName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Course Name"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(113, 259)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 23)
        Me.txtHours.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hours"
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(113, 210)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(100, 23)
        Me.txtDay.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Day"
        '
        'txtTaEmail
        '
        Me.txtTaEmail.Location = New System.Drawing.Point(504, 262)
        Me.txtTaEmail.Name = "txtTaEmail"
        Me.txtTaEmail.Size = New System.Drawing.Size(100, 23)
        Me.txtTaEmail.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ta Email"
        '
        'txtTaFirstName
        '
        Me.txtTaFirstName.Location = New System.Drawing.Point(504, 213)
        Me.txtTaFirstName.Name = "txtTaFirstName"
        Me.txtTaFirstName.Size = New System.Drawing.Size(100, 23)
        Me.txtTaFirstName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TA First Name"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(504, 169)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(100, 23)
        Me.txtRoomNumber.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Room Number"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(504, 120)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 23)
        Me.txtUnits.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Units"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(178, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "1.Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(246, 577)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(194, 41)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Main Form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(381, 304)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(129, 23)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "2.Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'DisplayCourseData
        '
        Me.DisplayCourseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayCourseData.Location = New System.Drawing.Point(128, 349)
        Me.DisplayCourseData.Name = "DisplayCourseData"
        Me.DisplayCourseData.ReadOnly = True
        Me.DisplayCourseData.RowTemplate.Height = 25
        Me.DisplayCourseData.Size = New System.Drawing.Size(476, 184)
        Me.DisplayCourseData.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1007, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FiileToolStripMenuItem
        '
        Me.FiileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSVToolStripMenuItem})
        Me.FiileToolStripMenuItem.Name = "FiileToolStripMenuItem"
        Me.FiileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FiileToolStripMenuItem.Text = "File"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearCSVDataToolStripMenuItem})
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.CSVToolStripMenuItem.Text = "Data"
        '
        'ClearCSVDataToolStripMenuItem
        '
        Me.ClearCSVDataToolStripMenuItem.Name = "ClearCSVDataToolStripMenuItem"
        Me.ClearCSVDataToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClearCSVDataToolStripMenuItem.Text = "Clear Data"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(279, 539)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear Text Boxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 660)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DisplayCourseData)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTaEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTaFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCourseName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCourseNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Course"
        Me.Text = "Course"
        CType(Me.DisplayCourseData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCourseNumber As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTaEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTaFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents DisplayCourseData As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FiileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearCSVDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Instructor_form
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
        Me.txtInstructor_FirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInstructor_LastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInstructor_Email = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DisplayInstructorData = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txt_instructor_officenumber = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.DisplayInstructorData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInstructor_FirstName
        '
        Me.txtInstructor_FirstName.Location = New System.Drawing.Point(187, 168)
        Me.txtInstructor_FirstName.Name = "txtInstructor_FirstName"
        Me.txtInstructor_FirstName.Size = New System.Drawing.Size(100, 23)
        Me.txtInstructor_FirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'txtInstructor_LastName
        '
        Me.txtInstructor_LastName.Location = New System.Drawing.Point(187, 221)
        Me.txtInstructor_LastName.Name = "txtInstructor_LastName"
        Me.txtInstructor_LastName.Size = New System.Drawing.Size(100, 23)
        Me.txtInstructor_LastName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "office number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email"
        '
        'txtInstructor_Email
        '
        Me.txtInstructor_Email.Location = New System.Drawing.Point(481, 171)
        Me.txtInstructor_Email.Name = "txtInstructor_Email"
        Me.txtInstructor_Email.Size = New System.Drawing.Size(100, 23)
        Me.txtInstructor_Email.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(393, 267)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "2.Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(141, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(478, 60)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Instructor Form"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(187, 534)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(349, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Main form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DisplayInstructorData
        '
        Me.DisplayInstructorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayInstructorData.Location = New System.Drawing.Point(187, 308)
        Me.DisplayInstructorData.Name = "DisplayInstructorData"
        Me.DisplayInstructorData.ReadOnly = True
        Me.DisplayInstructorData.RowTemplate.Height = 25
        Me.DisplayInstructorData.Size = New System.Drawing.Size(349, 172)
        Me.DisplayInstructorData.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(232, 267)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "1.Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txt_instructor_officenumber
        '
        Me.txt_instructor_officenumber.Location = New System.Drawing.Point(481, 221)
        Me.txt_instructor_officenumber.Mask = "(999) 000-0000"
        Me.txt_instructor_officenumber.Name = "txt_instructor_officenumber"
        Me.txt_instructor_officenumber.Size = New System.Drawing.Size(100, 23)
        Me.txt_instructor_officenumber.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
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
        Me.TextFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearTextToolStripMenuItem})
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.TextFileToolStripMenuItem.Text = "Data"
        '
        'ClearTextToolStripMenuItem
        '
        Me.ClearTextToolStripMenuItem.Name = "ClearTextToolStripMenuItem"
        Me.ClearTextToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClearTextToolStripMenuItem.Text = "Clear Data"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(284, 492)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear Text Boxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Instructor_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 583)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txt_instructor_officenumber)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DisplayInstructorData)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInstructor_Email)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInstructor_LastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInstructor_FirstName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Instructor_form"
        Me.Text = "Instructor_form"
        CType(Me.DisplayInstructorData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInstructor_FirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInstructor_LastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInstructor_Email As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents DisplayInstructorData As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txt_instructor_officenumber As MaskedTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
End Class

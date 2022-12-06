<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseEnrollment
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDisplayInformation = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(124, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(535, 60)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Course Enrollment"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(33, 357)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(203, 39)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Information"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtDisplayInformation
        '
        Me.txtDisplayInformation.Location = New System.Drawing.Point(71, 114)
        Me.txtDisplayInformation.Name = "txtDisplayInformation"
        Me.txtDisplayInformation.ReadOnly = True
        Me.txtDisplayInformation.Size = New System.Drawing.Size(694, 221)
        Me.txtDisplayInformation.TabIndex = 14
        Me.txtDisplayInformation.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearDataToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClearDataToolStripMenuItem.Text = "Clear Data"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(240, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Main Form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(269, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(240, 39)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear TextBox"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CourseEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtDisplayInformation)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CourseEnrollment"
        Me.Text = "CourseEnrollment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDisplayInformation As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
End Class

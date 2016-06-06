<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks
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
        Me.StudentList = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMarks = New System.Windows.Forms.Button()
        Me.btnNames = New System.Windows.Forms.Button()
        Me.txtstudents = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmarks = New System.Windows.Forms.TextBox()
        Me.lblhighest = New System.Windows.Forms.Label()
        Me.lbllowest = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentList
        '
        Me.StudentList.FormattingEnabled = True
        Me.StudentList.Location = New System.Drawing.Point(12, 31)
        Me.StudentList.Name = "StudentList"
        Me.StudentList.Size = New System.Drawing.Size(186, 212)
        Me.StudentList.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(306, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 29)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMarks
        '
        Me.btnMarks.Location = New System.Drawing.Point(12, 251)
        Me.btnMarks.Name = "btnMarks"
        Me.btnMarks.Size = New System.Drawing.Size(186, 26)
        Me.btnMarks.TabIndex = 5
        Me.btnMarks.Text = "Sort by Marks"
        Me.btnMarks.UseVisualStyleBackColor = True
        '
        'btnNames
        '
        Me.btnNames.Location = New System.Drawing.Point(12, 285)
        Me.btnNames.Name = "btnNames"
        Me.btnNames.Size = New System.Drawing.Size(186, 26)
        Me.btnNames.TabIndex = 6
        Me.btnNames.Text = "Sort by Name"
        Me.btnNames.UseVisualStyleBackColor = True
        '
        'txtstudents
        '
        Me.txtstudents.Location = New System.Drawing.Point(306, 44)
        Me.txtstudents.MaxLength = 15
        Me.txtstudents.Name = "txtstudents"
        Me.txtstudents.ShortcutsEnabled = False
        Me.txtstudents.Size = New System.Drawing.Size(155, 20)
        Me.txtstudents.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(204, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(265, 122)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student Mark:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name of Student:"
        '
        'txtmarks
        '
        Me.txtmarks.Location = New System.Drawing.Point(407, 70)
        Me.txtmarks.MaxLength = 3
        Me.txtmarks.Name = "txtmarks"
        Me.txtmarks.ShortcutsEnabled = False
        Me.txtmarks.Size = New System.Drawing.Size(51, 20)
        Me.txtmarks.TabIndex = 2
        '
        'lblhighest
        '
        Me.lblhighest.AutoSize = True
        Me.lblhighest.Location = New System.Drawing.Point(306, 222)
        Me.lblhighest.Name = "lblhighest"
        Me.lblhighest.Size = New System.Drawing.Size(51, 13)
        Me.lblhighest.TabIndex = 17
        Me.lblhighest.Text = "lblhighest"
        '
        'lbllowest
        '
        Me.lbllowest.AutoSize = True
        Me.lbllowest.Location = New System.Drawing.Point(306, 248)
        Me.lbllowest.Name = "lbllowest"
        Me.lbllowest.Size = New System.Drawing.Size(39, 13)
        Me.lbllowest.TabIndex = 18
        Me.lbllowest.Text = "Label4"
        '
        'lblaverage
        '
        Me.lblaverage.AutoSize = True
        Me.lblaverage.Location = New System.Drawing.Point(306, 276)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(39, 13)
        Me.lblaverage.TabIndex = 19
        Me.lblaverage.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Highest Mark:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Lowest Mark:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Average Mark:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(204, 200)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(265, 111)
        Me.RichTextBox2.TabIndex = 23
        Me.RichTextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Clear List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 329)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblaverage)
        Me.Controls.Add(Me.lbllowest)
        Me.Controls.Add(Me.lblhighest)
        Me.Controls.Add(Me.txtmarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNames)
        Me.Controls.Add(Me.btnMarks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstudents)
        Me.Controls.Add(Me.StudentList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Marks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mark Sorter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentList As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMarks As System.Windows.Forms.Button
    Friend WithEvents btnNames As System.Windows.Forms.Button
    Friend WithEvents txtstudents As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmarks As System.Windows.Forms.TextBox
    Friend WithEvents lblhighest As System.Windows.Forms.Label
    Friend WithEvents lbllowest As System.Windows.Forms.Label
    Friend WithEvents lblaverage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

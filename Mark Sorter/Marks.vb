Public Class Marks

    Dim studentname() As String
    Dim studentmark() As Double
    Dim namemark() As String
    Dim numofstudents As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Enabled = False
        RichTextBox2.Enabled = False
        numofstudents = 0
        lblaverage.Text = ""
        lblhighest.Text = ""
        lbllowest.Text = ""
        btnNames.Enabled = False
        btnMarks.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This is a mark sorting tool made by Abhijeet Prasad", MsgBoxStyle.Information)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim students As String
        Dim marks As Double
        marks = Val(txtmarks.Text)
        students = txtstudents.Text.Trim(" ")
        numofstudents = numofstudents + 1
        If txtmarks.Text = "" Or txtstudents.Text = "" Then
            MessageBox.Show("Please fill out all information")
            txtmarks.Clear()
            txtstudents.Clear()
            numofstudents = numofstudents - 1
        ElseIf Val(marks) > 100 Or Val(marks) < 0 Then
            MessageBox.Show("The mark is invalid! Please try again!")
            numofstudents = numofstudents - 1
            txtmarks.Clear()
            txtstudents.Clear()
            If StudentList.Text = Nothing Or StudentList.Text = "" Then
                btnMarks.Enabled = False
                btnNames.Enabled = False
                Button1.Enabled = False
            End If
        Else
            ReDim Preserve studentname(numofstudents)
            ReDim Preserve studentmark(numofstudents)
            ReDim Preserve namemark(numofstudents)
            studentname(numofstudents) = students
            studentmark(numofstudents) = Math.Round(Val(marks), 2)
            namemark(numofstudents) = studentname(numofstudents) & vbTab & studentmark(numofstudents)
            StudentList.Items.Add(studentname(numofstudents) & vbTab & studentmark(numofstudents))
            Calculate()
            txtmarks.Clear()
            txtstudents.Clear()
            btnMarks.Enabled = True
            btnNames.Enabled = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentList.Items.Clear()
        ReDim studentname(0)
        ReDim studentmark(0)
        numofstudents = 0
        btnMarks.Enabled = False
        btnNames.Enabled = False
        Button1.Enabled = False
        lblhighest.Text = ""
        lblaverage.Text = ""
        lbllowest.Text = ""
    End Sub

    Public Sub Calculate()
        'calculate average
        Dim averagenum As Single = Nothing
        For x = 1 To numofstudents
            averagenum = averagenum + studentmark(x)
        Next
        lblaverage.Text = Math.Round(averagenum / numofstudents, 2) & "%"

        'calculate highest mark
        Dim highest As Single = Nothing
        highest = studentmark(1)
        lblhighest.Text = studentname(1) & " with a " & studentmark(1) & "%"
        For y = 1 To numofstudents
            If highest < studentmark(y) Then
                highest = studentmark(y)
                lblhighest.Text = studentname(y) & " with a " & Math.Round(highest, 2) & "%"
            End If
        Next

        'calculate lowest mark
        Dim lowest As Single = Nothing
        lowest = studentmark(1)
        lbllowest.Text = studentname(1) & " with a " & studentmark(1) & "%"
        For y = 1 To numofstudents
            If lowest > studentmark(y) Then
                lowest = studentmark(y)
                lbllowest.Text = studentname(y) & " with a " & Math.Round(lowest, 2) & "%"
            End If
        Next
    End Sub

    Private Sub Txtmarks_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarks.KeyPress
        If Not Char.IsDigit(CChar(e.KeyChar)) AndAlso Not {ControlChars.Back}.Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If (txtmarks.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNames_Click(sender As Object, e As EventArgs) Handles btnNames.Click
        Array.Sort(namemark)
        StudentList.Items.Clear()
        For x = 1 To numofstudents
            StudentList.Items.Add(namemark(x))
        Next
    End Sub

    Private Sub btnMarks_Click(sender As Object, e As EventArgs) Handles btnMarks.Click
        Dim temp As String
        Dim temp2 As String
        StudentList.Items.Clear()
        For x = 1 To numofstudents
            For y = 1 To (numofstudents - 1)
                If Val(studentmark(y)) < Val(studentmark(y + 1)) Then
                    temp = studentmark(y)
                    studentmark(y) = studentmark(y + 1)
                    studentmark(y + 1) = temp
                    temp2 = studentname(y)
                    studentname(y) = studentname(y + 1)
                    studentname(y + 1) = temp2
                End If
            Next
        Next
        For x = 1 To numofstudents
            StudentList.Items.Add(studentmark(x) & vbTab & studentname(x))
        Next
    End Sub

End Class

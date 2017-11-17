Public Class Preferences
    Dim BreakHour As String
    Dim BreakMinute As String
    Dim Breakseconds As String
    Dim LunchHour As String
    Dim Lunchminute As String
    Dim LunchSeconds As String
    Dim HomeHour As String
    Dim HomeMinute As String
    Dim HomeSeconds As String
    Dim break As String() = Split(My.Settings.Break, ":")
    Dim lunch As String() = Split(My.Settings.Lunch, ":")
    Dim home As String() = Split(My.Settings.Home, ":")

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'use the split strings from the my.settings section of the program to define the hour,minute,second of each time
        BreakHour = LTrim(break(0))
        BreakMinute = break(1)
        'for the seconds portion remove all characters after the index position of 2 to get rid of the "AM" or "PM" designation
        Breakseconds = break(2).Remove(2)
        LunchHour = LTrim(lunch(0))
        Lunchminute = lunch(1)
        LunchSeconds = lunch(2).Remove(2)
        HomeHour = LTrim(home(0))
        HomeMinute = home(1)
        HomeSeconds = home(2).Remove(2)

        'populate the text boxes on the form with the relevant times
        TBBH.Text = BreakHour
        TBBM.Text = BreakMinute
        TBBS.Text = Breakseconds
        TBLH.Text = LunchHour
        TBLM.Text = Lunchminute
        TBLS.Text = LunchSeconds
        TBHH.Text = HomeHour
        TBHM.Text = HomeMinute
        TBHS.Text = HomeSeconds

        'populate the combo boxes with the current time designator ("AM" or "PM")
        CBB.Text = break(2).Remove(0, 2)
        CBL.Text = lunch(2).Remove(0, 2)
        CBH.Text = home(2).Remove(0, 2)

        lblR.Text = My.Settings.red
        lblG.Text = My.Settings.green
        lblB.Text = My.Settings.blue
        TBR.Value = My.Settings.red
        TBG.Value = My.Settings.green
        TBB.Value = My.Settings.blue

        TBColorInterval.Text = My.Settings.ColorInterval

    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Close()
    End Sub

    Private Sub BTNApply_Click(sender As Object, e As EventArgs) Handles BTNApply.Click
        Dim flag1 As Boolean = True
        Dim flag2 As Boolean = True

        'create a text box array to make it easier to iterate through all of the text boxes on the form
        Dim tbarr(8) As TextBox
        tbarr(0) = TBBH
        tbarr(1) = TBBM
        tbarr(2) = TBBS
        tbarr(3) = TBLH
        tbarr(4) = TBLM
        tbarr(5) = TBLS
        tbarr(6) = TBHH
        tbarr(7) = TBHM
        tbarr(8) = TBHS

        'use a for loop to loop through each text box in the text box array
        For Each item In tbarr
            'use try catch to handle checking if the text box has a numeric value or not
            Try
                'try converting the contents of the text box to a 16 bit integer
                Convert.ToInt16(item.Text)
                'if it fails the exception is caught and the user is informed that there needs to be an integer in the text box
            Catch ex As Exception
                'flags are used so that the message box wont pop up more than once. flag is turned off after the first message box
                If flag1 = True Then
                    MsgBox("All text boxes must have numeric values assigned to them.", vbCritical, "Error")
                    flag1 = False
                    'flag 2 used to tell the program not to run the rest of the code after the for loop
                    flag2 = False
                End If
                'set the offending text box(es) to blank so the user can see which ones were wrong
                item.Text = ""
                'Exit Sub
            End Try
            'use an if statement to check of the value is over 60 or less than 0
            If (item.Text > 60) Or (item.Text < 0) Then
                'set the offending text box(es) to blank so the user can see which ones were wrong
                item.Text = ""
                If flag1 = True Then
                    MsgBox("No text box value may be greater than 60 or less than 0.", vbCritical, "Error")
                    flag2 = False
                    Exit For
                End If
            End If
            'check if the hour text box is more than 12
            If tbarr(0).Text > 12 Then
                tbarr(0).Text = ""
                If flag1 = True Then
                    MsgBox("Hours cannot be greater than 12.", vbCritical, "Error")
                    flag2 = False
                    Exit For
                End If
                'check if the hour text box is more than 12
            ElseIf tbarr(3).Text > 12 Then
                tbarr(3).Text = ""
                If flag1 = True Then
                    MsgBox("Hours cannot be greater than 12.", vbCritical, "Error")
                    flag2 = False
                    Exit For
                End If
                'check if the hour text box is more than 12
            ElseIf tbarr(6).Text > 12 Then
                tbarr(6).Text = ""
                If flag1 = True Then
                    MsgBox("Hours cannot be greater than 12.", vbCritical, "Error")
                    flag2 = False
                    Exit For
                End If
            End If
        Next
        If flag2 = False Then
            Exit Sub
        End If

        Form1.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
        Dim newred As Integer
        Dim newgreen As Integer
        Dim newblue As Integer

        Select Case lblR.Text
            Case >= 245
                newred = lblR.Text - 10
            Case <= 10
                newred = lblR.Text + 10
            Case > 10 And (lblR.Text < 245)
                newred = lblR.Text + 10
        End Select

        Select Case lblG.Text
            Case >= 245
                newgreen = lblG.Text - 10
            Case <= 10
                newgreen = lblG.Text + 10
            Case > 10 And (lblG.Text < 245)
                newgreen = lblG.Text + 10
        End Select

        Select Case lblB.Text
            Case >= 245
                newblue = lblB.Text - 10
            Case <= 10
                newblue = lblB.Text + 10
            Case > 10 And (lblB.Text < 245)
                newblue = lblB.Text + 10
        End Select

        Form1.MS.BackColor = Color.FromArgb(newred, newgreen, newblue)



        'if all the rules above are followed then update all of the settings values with the new numbers
        My.Settings.Break = " " & TBBH.Text & ":" & TBBM.Text & ":" & TBBS.Text & CBB.Text
        My.Settings.Lunch = " " & TBLH.Text & ":" & TBLM.Text & ":" & TBLS.Text & CBL.Text
        My.Settings.Home = " " & TBHH.Text & ":" & TBHM.Text & ":" & TBHS.Text & CBH.Text
        My.Settings.red = lblR.Text
        My.Settings.green = lblG.Text
        My.Settings.blue = lblB.Text
        My.Settings.newred = newred
        My.Settings.newgreen = newgreen
        My.Settings.newblue = newblue
        If IsNumeric(TBColorInterval.Text) Then
            If TBColorInterval.Text > 0 Then
                My.Settings.ColorInterval = TBColorInterval.Text
                Form1.TMRColor.Interval = My.Settings.ColorInterval
            Else
                MsgBox("Color Interval must be greater than zero", vbCritical, "Error")
            End If
        Else
            MsgBox("Color Interval must be an integer", vbCritical, "Error")
        End If
        'save the settings
        My.Settings.Save()


        MsgBox("Your settings have been saved successfully!", vbInformation, "Success")
    End Sub

    Private Sub TBR_Scroll(sender As Object, e As EventArgs) Handles TBR.Scroll
        If CBLOCK.Checked = True Then
            TBG.Value = TBR.Value - 50
            TBB.Value = TBR.Value - 60
            lblG.Text = TBR.Value - 50
            lblB.Text = TBR.Value - 60
        End If
        lblR.Text = TBR.Value
        PBColour.BackColor = Color.FromArgb(TBR.Value, TBG.Value, TBB.Value)
    End Sub

    Private Sub TBG_Scroll(sender As Object, e As EventArgs) Handles TBG.Scroll
        If CBLOCK.Checked = True Then
            TBR.Value = TBG.Value
            TBB.Value = TBG.Value
            lblR.Text = TBG.Value
            lblB.Text = TBG.Value
        End If
        lblG.Text = TBG.Value
        PBColour.BackColor = Color.FromArgb(TBR.Value, TBG.Value, TBB.Value)
    End Sub

    Private Sub TBB_Scroll(sender As Object, e As EventArgs) Handles TBB.Scroll
        If CBLOCK.Checked = True Then
            TBG.Value = TBB.Value
            TBR.Value = TBB.Value
            lblG.Text = TBB.Value
            lblR.Text = TBB.Value
        End If
        lblB.Text = TBB.Value
        PBColour.BackColor = Color.FromArgb(TBR.Value, TBG.Value, TBB.Value)
    End Sub

    Private Sub LblR_TextChanged(sender As Object, e As EventArgs) Handles lblR.TextChanged
        Try
            If IsNumeric(lblR.Text) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBR.Value = lblR.Text
            ElseIf (lblR.Text > 0) And (lblR.Text < 255) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBR.Value = lblR.Text
            Else
                MsgBox("Color red must be an integer between 0 and 255")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblG_TextChanged(sender As Object, e As EventArgs) Handles lblG.TextChanged
        Try
            If IsNumeric(lblG.Text) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBG.Value = lblG.Text
            ElseIf (lblG.Text > 0) And (lblG.Text < 255) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBG.Value = lblG.Text
            Else
                MsgBox("Color green must be an integer between 0 and 255")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LblB_TextChanged(sender As Object, e As EventArgs) Handles lblB.TextChanged
        Try
            If IsNumeric(lblB.Text) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBB.Value = lblB.Text
            ElseIf (lblB.Text > 0) And (lblB.Text < 255) Then
                PBColour.BackColor = Color.FromArgb(lblR.Text, lblG.Text, lblB.Text)
                TBB.Value = lblB.Text
            Else
                MsgBox("Color blue must be an integer between 0 and 255")
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
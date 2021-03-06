﻿Imports System.Runtime.InteropServices
Public Class Form1
    Dim break As Integer
    Dim lunch As Integer
    Dim home As Integer
    Dim BreakSpan As TimeSpan
    Dim LunchSpan As TimeSpan
    Dim HomeSpan As TimeSpan
    Dim delay As Integer
    Dim lockflag As Boolean = False
    Dim logoffflag As Boolean = False
    Dim shutdownflag As Boolean = False
    Dim restartflag As Boolean = False
    Dim returnstring As String
    Dim counter As Integer = 0
    Dim red As Integer = 0
    Dim green As Integer = 0
    Dim blue As Integer = 0
    Dim rf As Boolean = True
    Dim gf As Boolean = False
    Dim bf As Boolean = False
    Dim rainbow As Boolean
    'new edit for test
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start the timer to start the clocks
        Timer.Start()
        TMRColor.Start()

        'If time gets stuck and it becomes impossible to start the application use one or multiple of these following lines
        'My.Settings.Break = " 9:30:00 AM"
        'My.Settings.Lunch = " 12:00:00 PM"
        'My.Settings.Home = "

        'use the datediff function to get the time in seconds between the start of the day (7 AM) and break/lunch/home time. Use that value as the maximum for each respective progressbar
        PBBreak.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Break))
        PBLunch.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Lunch))
        PBHome.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Home))
        'find the amount of time from the current time to each event in seconds
        break = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Break))
        lunch = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Lunch))
        home = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Home))
        'convert the time in seconds to a timespan (HH:MM:SS) for use later
        BreakSpan = TimeSpan.FromSeconds(break)
        LunchSpan = TimeSpan.FromSeconds(lunch)
        HomeSpan = TimeSpan.FromSeconds(home)
        'set the label texts to the format of *TIME* *EVENT* (*CURRENT TIME*)
        lblBreak.Text = $"{LTrim(My.Settings.Break)} Break: ({Convert.ToString(BreakSpan)})"
        lblLunch.Text = $"{LTrim(My.Settings.Lunch)} Lunch: ({Convert.ToString(LunchSpan)})"
        lblHome.Text = $"{LTrim(My.Settings.Home)} Home Time: ({Convert.ToString(HomeSpan)})"
        Me.BackColor = Color.FromArgb(My.Settings.red, My.Settings.green, My.Settings.blue)
        MS.BackColor = Color.FromArgb(My.Settings.newred, My.Settings.newgreen, My.Settings.newblue)
        Formstart()
        TMRColor.Interval = My.Settings.ColorInterval

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        On Error Resume Next
        'use the datediff function to get the time in seconds between the start of the day (7 AM) and break/lunch/home time. Use that value as the maximum for each respective progressbar
        PBBreak.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Break))
        PBLunch.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Lunch))
        PBHome.Maximum = DateDiff(DateInterval.Second, Convert.ToDateTime(Date.Today + " 7:00:00 AM"), Convert.ToDateTime(Date.Today + My.Settings.Home))
        'find the amount of time from the current time to each event in seconds
        break = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Break))
        lunch = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Lunch))
        home = DateDiff(DateInterval.Second, Date.Now, Convert.ToDateTime(Date.Today + My.Settings.Home))
        'convert the time in seconds to a timespan (HH:MM:SS) for use later
        BreakSpan = TimeSpan.FromSeconds(break)
        LunchSpan = TimeSpan.FromSeconds(lunch)
        HomeSpan = TimeSpan.FromSeconds(home)
        'set the label texts to the format of *TIME* *EVENT* (*CURRENT TIME*)
        lblBreak.Text = $"{LTrim(My.Settings.Break)} Break: ({Convert.ToString(BreakSpan)})"
        lblLunch.Text = $"{LTrim(My.Settings.Lunch)} Lunch: ({Convert.ToString(LunchSpan)})"
        lblHome.Text = $"{LTrim(My.Settings.Home)} Home Time: ({Convert.ToString(HomeSpan)})"

        'check if the amount of seconds for break is > 0  which means it is still upcoming
        If break > 0 Then
            'set the value of the progressbar to the elapsed time since 7
            PBBreak.Value = PBBreak.Maximum - break
        Else
            'if the event has passed set the progressbar value to the maximum
            PBBreak.Value = PBBreak.Maximum
        End If

        'check if the amount of seconds for lunch is > 0  which means it is still upcoming
        If lunch > 0 Then
            'set the value of the progressbar to the elapsed time since 7
            PBLunch.Value = PBLunch.Maximum - lunch
        Else
            'if the event has passed set the progressbar value to the maximum
            PBLunch.Value = PBLunch.Maximum
        End If

        'check if the amount of seconds for home time is > 0  which means it is still upcoming
        If home > 0 Then
            'set the value of the progressbar to the elapsed time since 7
            PBHome.Value = PBHome.Maximum - home
        Else
            'if the event has passed set the progressbar value to the maximum
            PBHome.Value = PBHome.Maximum
        End If

        If break = 0 Then
            notifier.BalloonTipTitle = "BREAK TIME"
            notifier.BalloonTipText = " It is now break time, please proceed to the break room."
            notifier.BalloonTipIcon = ToolTipIcon.Info
            ' CmdOpenCD_Click()
            notifier.ShowBalloonTip(5000)
        End If

        If lunch = 0 Then
            notifier.BalloonTipTitle = "LUNCH TIME"
            notifier.BalloonTipText = " It is now lunch time, please proceed to the break room."
            notifier.BalloonTipIcon = ToolTipIcon.Warning
            notifier.BalloonTipIcon = ToolTipIcon.Info
            ' CmdOpenCD_Click()
            notifier.ShowBalloonTip(5000)
        End If

        If home = 0 Then
            notifier.BalloonTipTitle = "HOME TIME"
            notifier.BalloonTipText = " It is now home time, please proceed home."
            notifier.BalloonTipIcon = ToolTipIcon.Info
            '  CmdOpenCD_Click()
            notifier.ShowBalloonTip(5000)
        End If
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ExitAndLogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAndLogOffToolStripMenuItem.Click
        Close()
        Shell("shutdown -1")
    End Sub

    Private Sub ExitAndShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAndShutDownToolStripMenuItem.Click
        Close()
        Shell("shutdown -s")
    End Sub

    Private Sub ExitAndRestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAndRestartToolStripMenuItem.Click
        Close()
        Shell("shutdown -r")
    End Sub

    Private Sub ExitAndLockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAndLockToolStripMenuItem.Click
        Close()
        LockWorkStation
    End Sub
    Private Declare Function LockWorkStation Lib "user32.dll" () As Long

    Private Sub ImmediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImmediateToolStripMenuItem.Click
        LockWorkStation
    End Sub

    Private Sub ImmediateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImmediateToolStripMenuItem1.Click
        Shell("shutdown -1")
    End Sub

    Private Sub ImmediateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ImmediateToolStripMenuItem2.Click
        Shell("shutdown -s")
    End Sub

    Private Sub DelayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelayToolStripMenuItem.Click
        lockflag = True
        delay = InputBox("Please enter the length of delay in milliseconds",, "1000")
        DelayTimer.Interval = delay
        DelayTimer.Start()
    End Sub

    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs) Handles DelayTimer.Tick
        If lockflag = True Then
            LockWorkStation
            lockflag = False
        ElseIf logoffflag = True Then
            Shell("shutdown -1")
            logoffflag = False
        ElseIf shutdownflag = True Then
            Shell("shutdown -s")
            shutdownflag = False
        ElseIf restartflag = True Then
            Shell("shutdown -r")
            restartflag = False
        Else
            DelayTimer.Stop()
        End If
    End Sub

    Private Sub ImmediateToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ImmediateToolStripMenuItem3.Click
        Shell("shutdown -r")
    End Sub

    Private Sub DelayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DelayToolStripMenuItem1.Click
        logoffflag = True
        delay = InputBox("Please enter the length of delay in milliseconds",, "1000")
        DelayTimer.Interval = delay
        DelayTimer.Start()
    End Sub

    Private Sub DelayToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DelayToolStripMenuItem2.Click
        shutdownflag = True
        delay = InputBox("Please enter the length of delay in milliseconds",, "1000")
        DelayTimer.Interval = delay
        DelayTimer.Start()
    End Sub

    Private Sub DelayToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DelayToolStripMenuItem3.Click
        restartflag = True
        delay = InputBox("Please enter the length of delay in milliseconds",, "1000")
        DelayTimer.Interval = delay
        DelayTimer.Start()
    End Sub

    Private Sub Notifier_DoubleClick(sender As Object, e As EventArgs) Handles notifier.DoubleClick
        counter = counter + 1
        My.Settings.nickels = My.Settings.nickels + 1
        My.Settings.Save()
        Dim randomnum As Integer
        Dim dollars As Decimal
        Dim cents As Integer
        cents = My.Settings.nickels * 5
        dollars = cents / 100
        Dim stuff(3) As String
        stuff(0) = "Get back to work you!"
        stuff(1) = "If I had a nickel for every time you've clicked this I'd have " & My.Settings.nickels & "! Thats $" & dollars & "!"
        stuff(2) = "Its not time yet, shhhh"
        stuff(3) = "Would you stop clicking me, please?"

        randomnum = Getrandomnum(0, stuff.Count)

        If counter = 5 Then
            notifier.BalloonTipTitle = "HELLO AGAIN"
            notifier.BalloonTipText = stuff(randomnum)
            notifier.BalloonTipIcon = ToolTipIcon.Warning
            notifier.ShowBalloonTip(5000)
            counter = 0
            Exit Sub
        End If

        If break > 0 Then
            notifier.BalloonTipTitle = "BREAK TIME"
            notifier.BalloonTipText = "Break time is in " & Convert.ToString(BreakSpan)
            notifier.BalloonTipIcon = ToolTipIcon.Info
            notifier.ShowBalloonTip(5000)
            Exit Sub
        End If

        If lunch > 0 Then
            notifier.BalloonTipTitle = "LUNCH TIME"
            notifier.BalloonTipText = "Lunch time is in " & Convert.ToString(LunchSpan)
            notifier.BalloonTipIcon = ToolTipIcon.Info
            notifier.ShowBalloonTip(5000)
            Exit Sub
        End If

        If home > 0 Then
            notifier.BalloonTipTitle = "HOME TIME"
            notifier.BalloonTipText = "Home time is in " & Convert.ToString(HomeSpan)
            notifier.BalloonTipIcon = ToolTipIcon.Info
            notifier.ShowBalloonTip(5000)
            Exit Sub
        End If

        notifier.BalloonTipTitle = "GO HOME ALREADY"
        notifier.BalloonTipText = "Its past time to go home so you should be out of here!"
        notifier.BalloonTipIcon = ToolTipIcon.Info
        notifier.ShowBalloonTip(5000)
    End Sub
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Int32, ByVal hwndCallback As Int32) As Int32

    Private Sub CmdOpenCD_Click()
        Dim lRet As Long
        lRet = mciSendString("set CDAudio door open", returnstring, 127, 0)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        CmdOpenCD_Click()
    End Sub
    Public Function Getrandomnum(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim myrandom As New Random
        Dim randomnumber As Integer = myrandom.Next(num1, num2)
        Return randomnumber
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.C Then
            CmdOpenCD_Click()
        End If
    End Sub

    Private Sub Notifier_BalloonTipClicked(sender As Object, e As EventArgs) Handles notifier.BalloonTipClicked
        'Console.Beep(700, 1000)
        'Console.Beep(200, 1000)
    End Sub

    Private Sub LblBreak_DoubleClick(sender As Object, e As EventArgs) Handles lblBreak.DoubleClick
        Dim test As Decimal
        test = Convert.ToDecimal("6.0000") + Convert.ToDecimal("9.00")

        MsgBox(test)
    End Sub
    'control required to manipulate system volume
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    'variables used to control the sound
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Const APPCOMMAND_NEXT As UInteger = 11
    Const APPCOMMAND_PREVIOUS As UInteger = 12
    Const APPCOMMAND_BASSBOOST As UInteger = 20
    Const APPCOMMAND_INCREASEBASS As UInteger = 21
    Const APPCOMMAND_DECREASEBASS As UInteger = 19
    Const APPCOMMAND_PLAY As UInteger = 46
    Const APPCOMMAND_PAUSE As UInteger = 47
    Const APPCOMMAND_PLAYPAUSE As UInteger = 14

    Public Sub Formstart()
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
        BtnMute.Text = "0"
    End Sub
    Private Sub BtnVolDown_Click(sender As Object, e As EventArgs) Handles BtnVolDown.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        BtnMute.Text = "1"
    End Sub

    Private Sub BtnMute_Click(sender As Object, e As EventArgs) Handles BtnMute.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
        If BtnMute.Text = "0" Then
            BtnMute.Text = "1"
        Else
            BtnMute.Text = "0"
        End If
    End Sub

    Private Sub BtnVolUp_Click(sender As Object, e As EventArgs) Handles BtnVolUp.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        BtnMute.Text = "1"
    End Sub

    Private Sub BTNPrev_Click(sender As Object, e As EventArgs) Handles BTNPrev.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_PREVIOUS * &H10000)

    End Sub

    Private Sub BTNNext_Click(sender As Object, e As EventArgs) Handles BTNNext.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_NEXT * &H10000)
    End Sub

    Private Sub BTNPlay_Click(sender As Object, e As EventArgs) Handles BTNPlay.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_PLAY * &H10000)
    End Sub

    Private Sub BTNPlayPause_Click(sender As Object, e As EventArgs) Handles BTNPlayPause.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_PLAYPAUSE * &H10000)
    End Sub

    Private Sub BTNPause_Click(sender As Object, e As EventArgs) Handles BTNPause.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_PAUSE * &H10000)
    End Sub

    Private Sub BTNBassDown_Click(sender As Object, e As EventArgs) Handles BTNBassDown.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_DECREASEBASS * &H10000)
    End Sub

    Private Sub BTNBass_Click(sender As Object, e As EventArgs) Handles BTNBass.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_BASSBOOST * &H10000)
    End Sub

    Private Sub BTNBassUp_Click(sender As Object, e As EventArgs) Handles BTNBassUp.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_INCREASEBASS * &H10000)
    End Sub

    Private Sub TMRColor_Tick(sender As Object, e As EventArgs) Handles TMRColor.Tick
        'code to cycle colors.
        'first red goes from 0 to 255
        'then green goes from 0 to 255 while red goes from 255 to 0
        'then blue goes from 0 to 255 while green goes from 255 to 0
        If rf = True And gf = False And bf = False Then
            Select Case red
                Case < 255
                    red += 1
                Case 0
                    red += 1
                Case 255
                    rf = False
                    gf = True
                    bf = False
            End Select
        ElseIf rf = False And gf = True And bf = False Then
            Select Case green
                Case < 255
                    green += 1
                    red -= 1
                Case 0
                    green += 1
                Case 255
                    rf = False
                    gf = False
                    bf = True
            End Select
        ElseIf rf = False And gf = False And bf = True Then
            Select Case blue
                Case < 255
                    blue += 1
                    green -= 1
                Case 0
                    blue += 1
                Case 255
                    rf = True
                    gf = False
                    bf = False
                    blue = 0
                    green = 0
                    red = 0
            End Select
        End If








        'cycles colors. red goes from 0 to 255 then green then blue
        '(basically just goes red/orange/yellow/white)
        'If red < 254 Then
        '    red += 1
        'Else
        '    If green < 254 Then
        '        green += 1
        '    Else
        '        If blue < 254 Then
        '            blue += 1
        '        Else
        '            red = 0
        '            green = 0
        '            blue = 0
        '        End If
        '    End If
        'End If
        PBRainbow.BackColor = Color.FromArgb(red, green, blue)
        If rainbow = True Then
            Me.BackColor = Color.FromArgb(red, green, blue)
            MS.BackColor = Color.FromArgb(red, green, blue)
        Else
            Me.BackColor = Color.FromArgb(My.Settings.red, My.Settings.green, My.Settings.blue)
            MS.BackColor = Color.FromArgb(My.Settings.newred, My.Settings.newgreen, My.Settings.newblue)
        End If
    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        rainbow = True
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem.Click
        rainbow = False
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PBBreak = New System.Windows.Forms.ProgressBar()
        Me.PBLunch = New System.Windows.Forms.ProgressBar()
        Me.PBHome = New System.Windows.Forms.ProgressBar()
        Me.lblBreak = New System.Windows.Forms.Label()
        Me.lblLunch = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MS = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAndLogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAndLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAndShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAndRestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmediateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmediateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmediateToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.notifier = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BtnVolDown = New System.Windows.Forms.Button()
        Me.BtnMute = New System.Windows.Forms.Button()
        Me.BtnVolUp = New System.Windows.Forms.Button()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBBreak
        '
        Me.PBBreak.Location = New System.Drawing.Point(12, 50)
        Me.PBBreak.Name = "PBBreak"
        Me.PBBreak.Size = New System.Drawing.Size(260, 23)
        Me.PBBreak.Step = 1
        Me.PBBreak.TabIndex = 0
        '
        'PBLunch
        '
        Me.PBLunch.Location = New System.Drawing.Point(12, 92)
        Me.PBLunch.Name = "PBLunch"
        Me.PBLunch.Size = New System.Drawing.Size(260, 23)
        Me.PBLunch.Step = 1
        Me.PBLunch.TabIndex = 1
        '
        'PBHome
        '
        Me.PBHome.Location = New System.Drawing.Point(12, 134)
        Me.PBHome.Name = "PBHome"
        Me.PBHome.Size = New System.Drawing.Size(260, 23)
        Me.PBHome.Step = 1
        Me.PBHome.TabIndex = 2
        '
        'lblBreak
        '
        Me.lblBreak.AutoSize = True
        Me.lblBreak.Location = New System.Drawing.Point(9, 34)
        Me.lblBreak.Name = "lblBreak"
        Me.lblBreak.Size = New System.Drawing.Size(138, 13)
        Me.lblBreak.TabIndex = 3
        Me.lblBreak.Text = "9:30 Break: (time remaining)"
        '
        'lblLunch
        '
        Me.lblLunch.AutoSize = True
        Me.lblLunch.Location = New System.Drawing.Point(9, 76)
        Me.lblLunch.Name = "lblLunch"
        Me.lblLunch.Size = New System.Drawing.Size(146, 13)
        Me.lblLunch.TabIndex = 4
        Me.lblLunch.Text = "12:00 Lunch: (time remaining)"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(9, 118)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(160, 13)
        Me.lblHome.TabIndex = 5
        Me.lblHome.Text = "3:00 Home time: (time remaining)"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'MS
        '
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PowerLockToolStripMenuItem, Me.CDToolStripMenuItem})
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(284, 24)
        Me.MS.TabIndex = 8
        Me.MS.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegularToolStripMenuItem, Me.ExitAndLogOffToolStripMenuItem, Me.ExitAndLockToolStripMenuItem, Me.ExitAndShutDownToolStripMenuItem, Me.ExitAndRestartToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RegularToolStripMenuItem
        '
        Me.RegularToolStripMenuItem.Name = "RegularToolStripMenuItem"
        Me.RegularToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RegularToolStripMenuItem.Text = "Regular"
        '
        'ExitAndLogOffToolStripMenuItem
        '
        Me.ExitAndLogOffToolStripMenuItem.Name = "ExitAndLogOffToolStripMenuItem"
        Me.ExitAndLogOffToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitAndLogOffToolStripMenuItem.Text = "Exit and Log Off"
        '
        'ExitAndLockToolStripMenuItem
        '
        Me.ExitAndLockToolStripMenuItem.Name = "ExitAndLockToolStripMenuItem"
        Me.ExitAndLockToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitAndLockToolStripMenuItem.Text = "Exit and Lock"
        '
        'ExitAndShutDownToolStripMenuItem
        '
        Me.ExitAndShutDownToolStripMenuItem.Name = "ExitAndShutDownToolStripMenuItem"
        Me.ExitAndShutDownToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitAndShutDownToolStripMenuItem.Text = "Exit and Shut Down"
        '
        'ExitAndRestartToolStripMenuItem
        '
        Me.ExitAndRestartToolStripMenuItem.Name = "ExitAndRestartToolStripMenuItem"
        Me.ExitAndRestartToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitAndRestartToolStripMenuItem.Text = "Exit and Restart"
        '
        'PowerLockToolStripMenuItem
        '
        Me.PowerLockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.LogOffToolStripMenuItem, Me.ShutDownToolStripMenuItem, Me.RestartToolStripMenuItem})
        Me.PowerLockToolStripMenuItem.Name = "PowerLockToolStripMenuItem"
        Me.PowerLockToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.PowerLockToolStripMenuItem.Text = "Power/Lock"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImmediateToolStripMenuItem, Me.DelayToolStripMenuItem})
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'ImmediateToolStripMenuItem
        '
        Me.ImmediateToolStripMenuItem.Name = "ImmediateToolStripMenuItem"
        Me.ImmediateToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ImmediateToolStripMenuItem.Text = "Immediate"
        '
        'DelayToolStripMenuItem
        '
        Me.DelayToolStripMenuItem.Name = "DelayToolStripMenuItem"
        Me.DelayToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DelayToolStripMenuItem.Text = "Delay"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImmediateToolStripMenuItem1, Me.DelayToolStripMenuItem1})
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'ImmediateToolStripMenuItem1
        '
        Me.ImmediateToolStripMenuItem1.Name = "ImmediateToolStripMenuItem1"
        Me.ImmediateToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ImmediateToolStripMenuItem1.Text = "Immediate"
        '
        'DelayToolStripMenuItem1
        '
        Me.DelayToolStripMenuItem1.Name = "DelayToolStripMenuItem1"
        Me.DelayToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.DelayToolStripMenuItem1.Text = "Delay"
        '
        'ShutDownToolStripMenuItem
        '
        Me.ShutDownToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImmediateToolStripMenuItem2, Me.DelayToolStripMenuItem2})
        Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
        Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ShutDownToolStripMenuItem.Text = "Shut Down"
        '
        'ImmediateToolStripMenuItem2
        '
        Me.ImmediateToolStripMenuItem2.Name = "ImmediateToolStripMenuItem2"
        Me.ImmediateToolStripMenuItem2.Size = New System.Drawing.Size(131, 22)
        Me.ImmediateToolStripMenuItem2.Text = "Immediate"
        '
        'DelayToolStripMenuItem2
        '
        Me.DelayToolStripMenuItem2.Name = "DelayToolStripMenuItem2"
        Me.DelayToolStripMenuItem2.Size = New System.Drawing.Size(131, 22)
        Me.DelayToolStripMenuItem2.Text = "Delay"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImmediateToolStripMenuItem3, Me.DelayToolStripMenuItem3})
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ImmediateToolStripMenuItem3
        '
        Me.ImmediateToolStripMenuItem3.Name = "ImmediateToolStripMenuItem3"
        Me.ImmediateToolStripMenuItem3.Size = New System.Drawing.Size(131, 22)
        Me.ImmediateToolStripMenuItem3.Text = "Immediate"
        '
        'DelayToolStripMenuItem3
        '
        Me.DelayToolStripMenuItem3.Name = "DelayToolStripMenuItem3"
        Me.DelayToolStripMenuItem3.Size = New System.Drawing.Size(131, 22)
        Me.DelayToolStripMenuItem3.Text = "Delay"
        '
        'CDToolStripMenuItem
        '
        Me.CDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.CDToolStripMenuItem.Name = "CDToolStripMenuItem"
        Me.CDToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.CDToolStripMenuItem.Text = "CD"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DelayTimer
        '
        '
        'notifier
        '
        Me.notifier.Icon = CType(resources.GetObject("notifier.Icon"), System.Drawing.Icon)
        Me.notifier.Text = "Nicks Toolbox"
        Me.notifier.Visible = True
        '
        'BtnVolDown
        '
        Me.BtnVolDown.Location = New System.Drawing.Point(197, 21)
        Me.BtnVolDown.Name = "BtnVolDown"
        Me.BtnVolDown.Size = New System.Drawing.Size(21, 23)
        Me.BtnVolDown.TabIndex = 9
        Me.BtnVolDown.Text = "-"
        Me.BtnVolDown.UseVisualStyleBackColor = True
        '
        'BtnMute
        '
        Me.BtnMute.Location = New System.Drawing.Point(224, 21)
        Me.BtnMute.Name = "BtnMute"
        Me.BtnMute.Size = New System.Drawing.Size(21, 23)
        Me.BtnMute.TabIndex = 9
        Me.BtnMute.Text = "1"
        Me.BtnMute.UseVisualStyleBackColor = True
        '
        'BtnVolUp
        '
        Me.BtnVolUp.Location = New System.Drawing.Point(251, 21)
        Me.BtnVolUp.Name = "BtnVolUp"
        Me.BtnVolUp.Size = New System.Drawing.Size(21, 23)
        Me.BtnVolUp.TabIndex = 9
        Me.BtnVolUp.Text = "+"
        Me.BtnVolUp.UseVisualStyleBackColor = True
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.AboutToolStripMenuItem1.Text = "&About..."
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Image = CType(resources.GetObject("OpenToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.OpenToolStripMenuItem1.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 170)
        Me.Controls.Add(Me.BtnVolUp)
        Me.Controls.Add(Me.BtnMute)
        Me.Controls.Add(Me.BtnVolDown)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblLunch)
        Me.Controls.Add(Me.lblBreak)
        Me.Controls.Add(Me.PBHome)
        Me.Controls.Add(Me.PBLunch)
        Me.Controls.Add(Me.PBBreak)
        Me.Controls.Add(Me.MS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MS
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Nicks Toolbox"
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBBreak As ProgressBar
    Friend WithEvents PBLunch As ProgressBar
    Friend WithEvents PBHome As ProgressBar
    Friend WithEvents lblBreak As Label
    Friend WithEvents lblLunch As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents MS As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitAndLogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitAndLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitAndShutDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowerLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImmediateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImmediateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DelayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShutDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImmediateToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DelayToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExitAndRestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelayTimer As Timer
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImmediateToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DelayToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents notifier As NotifyIcon
    Friend WithEvents CDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnVolDown As Button
    Friend WithEvents BtnMute As Button
    Friend WithEvents BtnVolUp As Button
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class

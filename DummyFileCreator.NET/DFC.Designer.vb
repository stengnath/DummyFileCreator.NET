<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DummyFileCreator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DummyFileCreator))
        Me.Dialog_Speicherort = New System.Windows.Forms.SaveFileDialog
        Me.Timer_Check = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Menu_Datei = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_Datei_Close = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_About = New System.Windows.Forms.ToolStripMenuItem
        Me.tab_DFC = New System.Windows.Forms.TabPage
        Me.grp_Content = New System.Windows.Forms.GroupBox
        Me.txt_Content = New System.Windows.Forms.TextBox
        Me.check_Content = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Status_text = New System.Windows.Forms.Label
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.grp_Analysis = New System.Windows.Forms.GroupBox
        Me.txt_progessFile = New System.Windows.Forms.TextBox
        Me.txt_FileSize = New System.Windows.Forms.TextBox
        Me.lbl_Filename = New System.Windows.Forms.Label
        Me.txt_SpaceLeft = New System.Windows.Forms.TextBox
        Me.txt_DriveInfo = New System.Windows.Forms.TextBox
        Me.lbl_speed_average = New System.Windows.Forms.Label
        Me.lbl_FileSize = New System.Windows.Forms.Label
        Me.lbl_TotalSpace = New System.Windows.Forms.Label
        Me.lbl_spaceLeft = New System.Windows.Forms.Label
        Me.progressbar_spaceleft = New System.Windows.Forms.ProgressBar
        Me.txt_speed_average = New System.Windows.Forms.TextBox
        Me.grp_rules = New System.Windows.Forms.GroupBox
        Me.combo_Copies = New System.Windows.Forms.ComboBox
        Me.lbl_Copy = New System.Windows.Forms.Label
        Me.check_OverwriteFiles = New System.Windows.Forms.CheckBox
        Me.txt_SpeicherOrt = New System.Windows.Forms.TextBox
        Me.txt_SizeOfFileToCreate = New System.Windows.Forms.TextBox
        Me.lbl_SpaceLeftPercent = New System.Windows.Forms.Label
        Me.cmd_CreateFile = New System.Windows.Forms.Button
        Me.radio_endless = New System.Windows.Forms.RadioButton
        Me.lbl_Speicherort = New System.Windows.Forms.Label
        Me.combo_unit = New System.Windows.Forms.ComboBox
        Me.radio_FileSize = New System.Windows.Forms.RadioButton
        Me.cmd_Speicherort_auswaehlen = New System.Windows.Forms.Button
        Me.tab_Main = New System.Windows.Forms.TabControl
        Me.tab_preferences = New System.Windows.Forms.TabPage
        Me.grp_Language = New System.Windows.Forms.GroupBox
        Me.radio_language_german = New System.Windows.Forms.RadioButton
        Me.radio_language_english = New System.Windows.Forms.RadioButton
        Me.check_minimizeToTray = New System.Windows.Forms.CheckBox
        Me.trayicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tray_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.trayMenu_Open = New System.Windows.Forms.ToolStripMenuItem
        Me.trayMenu_Close = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip_Minimize = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.tab_DFC.SuspendLayout()
        Me.grp_Content.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grp_Analysis.SuspendLayout()
        Me.grp_rules.SuspendLayout()
        Me.tab_Main.SuspendLayout()
        Me.tab_preferences.SuspendLayout()
        Me.grp_Language.SuspendLayout()
        Me.tray_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Check
        '
        Me.Timer_Check.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Datei, Me.Menu_About})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "About"
        '
        'Menu_Datei
        '
        Me.Menu_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Datei_Close})
        Me.Menu_Datei.Name = "Menu_Datei"
        Me.Menu_Datei.Size = New System.Drawing.Size(37, 20)
        Me.Menu_Datei.Text = "File"
        '
        'menu_Datei_Close
        '
        Me.menu_Datei_Close.Name = "menu_Datei_Close"
        Me.menu_Datei_Close.Size = New System.Drawing.Size(103, 22)
        Me.menu_Datei_Close.Text = "Close"
        '
        'Menu_About
        '
        Me.Menu_About.Name = "Menu_About"
        Me.Menu_About.Size = New System.Drawing.Size(77, 20)
        Me.Menu_About.Text = "About DFC"
        '
        'tab_DFC
        '
        Me.tab_DFC.Controls.Add(Me.grp_Content)
        Me.tab_DFC.Controls.Add(Me.PictureBox1)
        Me.tab_DFC.Controls.Add(Me.Panel1)
        Me.tab_DFC.Controls.Add(Me.grp_Analysis)
        Me.tab_DFC.Controls.Add(Me.grp_rules)
        Me.tab_DFC.Controls.Add(Me.txt_SpeicherOrt)
        Me.tab_DFC.Controls.Add(Me.txt_SizeOfFileToCreate)
        Me.tab_DFC.Controls.Add(Me.lbl_SpaceLeftPercent)
        Me.tab_DFC.Controls.Add(Me.cmd_CreateFile)
        Me.tab_DFC.Controls.Add(Me.radio_endless)
        Me.tab_DFC.Controls.Add(Me.lbl_Speicherort)
        Me.tab_DFC.Controls.Add(Me.combo_unit)
        Me.tab_DFC.Controls.Add(Me.radio_FileSize)
        Me.tab_DFC.Controls.Add(Me.cmd_Speicherort_auswaehlen)
        Me.tab_DFC.Location = New System.Drawing.Point(4, 22)
        Me.tab_DFC.Name = "tab_DFC"
        Me.tab_DFC.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DFC.Size = New System.Drawing.Size(352, 410)
        Me.tab_DFC.TabIndex = 0
        Me.tab_DFC.Text = "DFC"
        Me.tab_DFC.UseVisualStyleBackColor = True
        '
        'grp_Content
        '
        Me.grp_Content.Controls.Add(Me.txt_Content)
        Me.grp_Content.Controls.Add(Me.check_Content)
        Me.grp_Content.Location = New System.Drawing.Point(179, 125)
        Me.grp_Content.Name = "grp_Content"
        Me.grp_Content.Size = New System.Drawing.Size(150, 71)
        Me.grp_Content.TabIndex = 30
        Me.grp_Content.TabStop = False
        Me.grp_Content.Text = "Content"
        '
        'txt_Content
        '
        Me.txt_Content.Location = New System.Drawing.Point(9, 42)
        Me.txt_Content.Name = "txt_Content"
        Me.txt_Content.Size = New System.Drawing.Size(135, 20)
        Me.txt_Content.TabIndex = 1
        '
        'check_Content
        '
        Me.check_Content.AutoSize = True
        Me.check_Content.Enabled = False
        Me.check_Content.Location = New System.Drawing.Point(10, 20)
        Me.check_Content.Name = "check_Content"
        Me.check_Content.Size = New System.Drawing.Size(100, 17)
        Me.check_Content.TabIndex = 0
        Me.check_Content.Text = "custom Content"
        Me.check_Content.UseVisualStyleBackColor = True
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.DummyFileCreator.NET.My.Resources.Resources.DFC2
    Me.PictureBox1.Location = New System.Drawing.Point(26, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 27)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_Status_text)
        Me.Panel1.Controls.Add(Me.lbl_Status)
        Me.Panel1.Location = New System.Drawing.Point(-4, 378)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 31)
        Me.Panel1.TabIndex = 27
        '
        'lbl_Status_text
        '
        Me.lbl_Status_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status_text.Location = New System.Drawing.Point(67, 1)
        Me.lbl_Status_text.Name = "lbl_Status_text"
        Me.lbl_Status_text.Size = New System.Drawing.Size(281, 24)
        Me.lbl_Status_text.TabIndex = 0
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(15, 8)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 0
        Me.lbl_Status.Text = "Status"
        '
        'grp_Analysis
        '
        Me.grp_Analysis.Controls.Add(Me.txt_progessFile)
        Me.grp_Analysis.Controls.Add(Me.txt_FileSize)
        Me.grp_Analysis.Controls.Add(Me.lbl_Filename)
        Me.grp_Analysis.Controls.Add(Me.txt_SpaceLeft)
        Me.grp_Analysis.Controls.Add(Me.txt_DriveInfo)
        Me.grp_Analysis.Controls.Add(Me.lbl_speed_average)
        Me.grp_Analysis.Controls.Add(Me.lbl_FileSize)
        Me.grp_Analysis.Controls.Add(Me.lbl_TotalSpace)
        Me.grp_Analysis.Controls.Add(Me.lbl_spaceLeft)
        Me.grp_Analysis.Controls.Add(Me.progressbar_spaceleft)
        Me.grp_Analysis.Controls.Add(Me.txt_speed_average)
        Me.grp_Analysis.Location = New System.Drawing.Point(11, 202)
        Me.grp_Analysis.Name = "grp_Analysis"
        Me.grp_Analysis.Size = New System.Drawing.Size(318, 172)
        Me.grp_Analysis.TabIndex = 26
        Me.grp_Analysis.TabStop = False
        Me.grp_Analysis.Text = "Analysis"
        '
        'txt_progessFile
        '
        Me.txt_progessFile.BackColor = System.Drawing.SystemColors.Control
        Me.txt_progessFile.Enabled = False
        Me.txt_progessFile.Location = New System.Drawing.Point(100, 19)
        Me.txt_progessFile.Name = "txt_progessFile"
        Me.txt_progessFile.Size = New System.Drawing.Size(212, 20)
        Me.txt_progessFile.TabIndex = 25
        Me.txt_progessFile.Text = "-"
        Me.txt_progessFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_FileSize
        '
        Me.txt_FileSize.BackColor = System.Drawing.SystemColors.Control
        Me.txt_FileSize.Enabled = False
        Me.txt_FileSize.Location = New System.Drawing.Point(100, 44)
        Me.txt_FileSize.Name = "txt_FileSize"
        Me.txt_FileSize.Size = New System.Drawing.Size(212, 20)
        Me.txt_FileSize.TabIndex = 12
        Me.txt_FileSize.Text = "0"
        Me.txt_FileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Filename
        '
        Me.lbl_Filename.AutoSize = True
        Me.lbl_Filename.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Filename.Name = "lbl_Filename"
        Me.lbl_Filename.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Filename.TabIndex = 24
        Me.lbl_Filename.Text = "progress File:"
        '
        'txt_SpaceLeft
        '
        Me.txt_SpaceLeft.BackColor = System.Drawing.SystemColors.Control
        Me.txt_SpaceLeft.Enabled = False
        Me.txt_SpaceLeft.Location = New System.Drawing.Point(100, 122)
        Me.txt_SpaceLeft.Name = "txt_SpaceLeft"
        Me.txt_SpaceLeft.Size = New System.Drawing.Size(212, 20)
        Me.txt_SpaceLeft.TabIndex = 9
        Me.txt_SpaceLeft.Text = "-"
        Me.txt_SpaceLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DriveInfo
        '
        Me.txt_DriveInfo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_DriveInfo.Enabled = False
        Me.txt_DriveInfo.Location = New System.Drawing.Point(100, 96)
        Me.txt_DriveInfo.Name = "txt_DriveInfo"
        Me.txt_DriveInfo.Size = New System.Drawing.Size(212, 20)
        Me.txt_DriveInfo.TabIndex = 10
        Me.txt_DriveInfo.Text = "-"
        Me.txt_DriveInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_speed_average
        '
        Me.lbl_speed_average.AutoSize = True
        Me.lbl_speed_average.Location = New System.Drawing.Point(12, 74)
        Me.lbl_speed_average.Name = "lbl_speed_average"
        Me.lbl_speed_average.Size = New System.Drawing.Size(84, 13)
        Me.lbl_speed_average.TabIndex = 13
        Me.lbl_speed_average.Text = "Avarage Speed:"
        '
        'lbl_FileSize
        '
        Me.lbl_FileSize.AutoSize = True
        Me.lbl_FileSize.Location = New System.Drawing.Point(12, 48)
        Me.lbl_FileSize.Name = "lbl_FileSize"
        Me.lbl_FileSize.Size = New System.Drawing.Size(79, 13)
        Me.lbl_FileSize.TabIndex = 11
        Me.lbl_FileSize.Text = "actual File size:"
        '
        'lbl_TotalSpace
        '
        Me.lbl_TotalSpace.AutoSize = True
        Me.lbl_TotalSpace.Location = New System.Drawing.Point(12, 100)
        Me.lbl_TotalSpace.Name = "lbl_TotalSpace"
        Me.lbl_TotalSpace.Size = New System.Drawing.Size(68, 13)
        Me.lbl_TotalSpace.TabIndex = 6
        Me.lbl_TotalSpace.Text = "Total Space:"
        '
        'lbl_spaceLeft
        '
        Me.lbl_spaceLeft.AutoSize = True
        Me.lbl_spaceLeft.Location = New System.Drawing.Point(12, 126)
        Me.lbl_spaceLeft.Name = "lbl_spaceLeft"
        Me.lbl_spaceLeft.Size = New System.Drawing.Size(62, 13)
        Me.lbl_spaceLeft.TabIndex = 7
        Me.lbl_spaceLeft.Text = "Space Left:"
        '
        'progressbar_spaceleft
        '
        Me.progressbar_spaceleft.Location = New System.Drawing.Point(100, 148)
        Me.progressbar_spaceleft.Name = "progressbar_spaceleft"
        Me.progressbar_spaceleft.Size = New System.Drawing.Size(212, 20)
        Me.progressbar_spaceleft.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressbar_spaceleft.TabIndex = 8
        '
        'txt_speed_average
        '
        Me.txt_speed_average.BackColor = System.Drawing.SystemColors.Control
        Me.txt_speed_average.Enabled = False
        Me.txt_speed_average.Location = New System.Drawing.Point(100, 70)
        Me.txt_speed_average.Name = "txt_speed_average"
        Me.txt_speed_average.Size = New System.Drawing.Size(212, 20)
        Me.txt_speed_average.TabIndex = 14
        Me.txt_speed_average.Text = "0"
        Me.txt_speed_average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grp_rules
        '
        Me.grp_rules.Controls.Add(Me.combo_Copies)
        Me.grp_rules.Controls.Add(Me.lbl_Copy)
        Me.grp_rules.Controls.Add(Me.check_OverwriteFiles)
        Me.grp_rules.Location = New System.Drawing.Point(11, 125)
        Me.grp_rules.Name = "grp_rules"
        Me.grp_rules.Size = New System.Drawing.Size(162, 71)
        Me.grp_rules.TabIndex = 23
        Me.grp_rules.TabStop = False
        Me.grp_rules.Text = "Rules"
        '
        'combo_Copies
        '
        Me.combo_Copies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Copies.Enabled = False
        Me.combo_Copies.FormattingEnabled = True
        Me.combo_Copies.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.combo_Copies.Location = New System.Drawing.Point(51, 20)
        Me.combo_Copies.Name = "combo_Copies"
        Me.combo_Copies.Size = New System.Drawing.Size(86, 21)
        Me.combo_Copies.TabIndex = 24
        '
        'lbl_Copy
        '
        Me.lbl_Copy.AutoSize = True
        Me.lbl_Copy.Location = New System.Drawing.Point(6, 23)
        Me.lbl_Copy.Name = "lbl_Copy"
        Me.lbl_Copy.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Copy.TabIndex = 23
        Me.lbl_Copy.Text = "Copies:"
        '
        'check_OverwriteFiles
        '
        Me.check_OverwriteFiles.AutoSize = True
        Me.check_OverwriteFiles.Enabled = False
        Me.check_OverwriteFiles.Location = New System.Drawing.Point(9, 46)
        Me.check_OverwriteFiles.Name = "check_OverwriteFiles"
        Me.check_OverwriteFiles.Size = New System.Drawing.Size(128, 17)
        Me.check_OverwriteFiles.TabIndex = 22
        Me.check_OverwriteFiles.Text = "overwrite existing files"
        Me.check_OverwriteFiles.UseVisualStyleBackColor = True
        '
        'txt_SpeicherOrt
        '
        Me.txt_SpeicherOrt.Location = New System.Drawing.Point(96, 39)
        Me.txt_SpeicherOrt.Name = "txt_SpeicherOrt"
        Me.txt_SpeicherOrt.Size = New System.Drawing.Size(208, 20)
        Me.txt_SpeicherOrt.TabIndex = 3
        '
        'txt_SizeOfFileToCreate
        '
        Me.txt_SizeOfFileToCreate.Location = New System.Drawing.Point(96, 65)
        Me.txt_SizeOfFileToCreate.Name = "txt_SizeOfFileToCreate"
        Me.txt_SizeOfFileToCreate.Size = New System.Drawing.Size(160, 20)
        Me.txt_SizeOfFileToCreate.TabIndex = 16
        Me.txt_SizeOfFileToCreate.Text = "1"
        '
        'lbl_SpaceLeftPercent
        '
        Me.lbl_SpaceLeftPercent.AutoSize = True
        Me.lbl_SpaceLeftPercent.Location = New System.Drawing.Point(262, 315)
        Me.lbl_SpaceLeftPercent.Name = "lbl_SpaceLeftPercent"
        Me.lbl_SpaceLeftPercent.Size = New System.Drawing.Size(0, 13)
        Me.lbl_SpaceLeftPercent.TabIndex = 21
        '
        'cmd_CreateFile
        '
        Me.cmd_CreateFile.Enabled = False
        Me.cmd_CreateFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CreateFile.Location = New System.Drawing.Point(259, 91)
        Me.cmd_CreateFile.Name = "cmd_CreateFile"
        Me.cmd_CreateFile.Size = New System.Drawing.Size(70, 31)
        Me.cmd_CreateFile.TabIndex = 2
        Me.cmd_CreateFile.Text = "start"
        Me.cmd_CreateFile.UseVisualStyleBackColor = True
        '
        'radio_endless
        '
        Me.radio_endless.AutoSize = True
        Me.radio_endless.Enabled = False
        Me.radio_endless.Location = New System.Drawing.Point(11, 91)
        Me.radio_endless.Name = "radio_endless"
        Me.radio_endless.Size = New System.Drawing.Size(80, 17)
        Me.radio_endless.TabIndex = 20
        Me.radio_endless.TabStop = True
        Me.radio_endless.Text = "endless File"
        Me.radio_endless.UseVisualStyleBackColor = True
        '
        'lbl_Speicherort
        '
        Me.lbl_Speicherort.AutoSize = True
        Me.lbl_Speicherort.Location = New System.Drawing.Point(8, 43)
        Me.lbl_Speicherort.Name = "lbl_Speicherort"
        Me.lbl_Speicherort.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Speicherort.TabIndex = 4
        Me.lbl_Speicherort.Text = "Destination:"
        '
        'combo_unit
        '
        Me.combo_unit.FormattingEnabled = True
        Me.combo_unit.Items.AddRange(New Object() {"KB", "MB", "GB"})
        Me.combo_unit.Location = New System.Drawing.Point(259, 65)
        Me.combo_unit.Name = "combo_unit"
        Me.combo_unit.Size = New System.Drawing.Size(70, 21)
        Me.combo_unit.TabIndex = 17
        '
        'radio_FileSize
        '
        Me.radio_FileSize.AutoSize = True
        Me.radio_FileSize.Enabled = False
        Me.radio_FileSize.Location = New System.Drawing.Point(11, 66)
        Me.radio_FileSize.Name = "radio_FileSize"
        Me.radio_FileSize.Size = New System.Drawing.Size(64, 17)
        Me.radio_FileSize.TabIndex = 19
        Me.radio_FileSize.TabStop = True
        Me.radio_FileSize.Text = "File Size"
        Me.radio_FileSize.UseVisualStyleBackColor = True
        '
        'cmd_Speicherort_auswaehlen
        '
        Me.cmd_Speicherort_auswaehlen.Location = New System.Drawing.Point(305, 39)
        Me.cmd_Speicherort_auswaehlen.Name = "cmd_Speicherort_auswaehlen"
        Me.cmd_Speicherort_auswaehlen.Size = New System.Drawing.Size(24, 20)
        Me.cmd_Speicherort_auswaehlen.TabIndex = 5
        Me.cmd_Speicherort_auswaehlen.Text = "..."
        Me.cmd_Speicherort_auswaehlen.UseVisualStyleBackColor = True
        '
        'tab_Main
        '
        Me.tab_Main.Controls.Add(Me.tab_DFC)
        Me.tab_Main.Controls.Add(Me.tab_preferences)
        Me.tab_Main.Location = New System.Drawing.Point(0, 27)
        Me.tab_Main.Name = "tab_Main"
        Me.tab_Main.SelectedIndex = 0
        Me.tab_Main.Size = New System.Drawing.Size(360, 436)
        Me.tab_Main.TabIndex = 22
        '
        'tab_preferences
        '
        Me.tab_preferences.Controls.Add(Me.grp_Language)
        Me.tab_preferences.Controls.Add(Me.check_minimizeToTray)
        Me.tab_preferences.Location = New System.Drawing.Point(4, 22)
        Me.tab_preferences.Name = "tab_preferences"
        Me.tab_preferences.Size = New System.Drawing.Size(352, 410)
        Me.tab_preferences.TabIndex = 1
        Me.tab_preferences.Text = "Preferences"
        Me.tab_preferences.UseVisualStyleBackColor = True
        '
        'grp_Language
        '
        Me.grp_Language.Controls.Add(Me.radio_language_german)
        Me.grp_Language.Controls.Add(Me.radio_language_english)
        Me.grp_Language.Location = New System.Drawing.Point(17, 42)
        Me.grp_Language.Name = "grp_Language"
        Me.grp_Language.Size = New System.Drawing.Size(141, 78)
        Me.grp_Language.TabIndex = 1
        Me.grp_Language.TabStop = False
        Me.grp_Language.Text = "Language"
        '
        'radio_language_german
        '
        Me.radio_language_german.AutoSize = True
        Me.radio_language_german.Location = New System.Drawing.Point(6, 42)
        Me.radio_language_german.Name = "radio_language_german"
        Me.radio_language_german.Size = New System.Drawing.Size(62, 17)
        Me.radio_language_german.TabIndex = 1
        Me.radio_language_german.Text = "German"
        Me.radio_language_german.UseVisualStyleBackColor = True
        '
        'radio_language_english
        '
        Me.radio_language_english.Location = New System.Drawing.Point(6, 19)
        Me.radio_language_english.Name = "radio_language_english"
        Me.radio_language_english.Size = New System.Drawing.Size(89, 17)
        Me.radio_language_english.TabIndex = 0
        Me.radio_language_english.Text = "English"
        Me.radio_language_english.UseVisualStyleBackColor = True
        '
        'check_minimizeToTray
        '
        Me.check_minimizeToTray.AutoSize = True
        Me.check_minimizeToTray.Location = New System.Drawing.Point(17, 19)
        Me.check_minimizeToTray.Name = "check_minimizeToTray"
        Me.check_minimizeToTray.Size = New System.Drawing.Size(141, 17)
        Me.check_minimizeToTray.TabIndex = 0
        Me.check_minimizeToTray.Text = "Minimize to tray on close"
        Me.check_minimizeToTray.UseVisualStyleBackColor = True
        '
        'trayicon
        '
        Me.trayicon.ContextMenuStrip = Me.tray_menu
        Me.trayicon.Icon = CType(resources.GetObject("trayicon.Icon"), System.Drawing.Icon)
        Me.trayicon.Text = "Dummy File Creator"
        Me.trayicon.Visible = True
        '
        'tray_menu
        '
        Me.tray_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trayMenu_Open, Me.trayMenu_Close})
        Me.tray_menu.Name = "tray_menu"
        Me.tray_menu.Size = New System.Drawing.Size(103, 48)
        '
        'trayMenu_Open
        '
        Me.trayMenu_Open.Name = "trayMenu_Open"
        Me.trayMenu_Open.Size = New System.Drawing.Size(102, 22)
        Me.trayMenu_Open.Text = "show"
        '
        'trayMenu_Close
        '
        Me.trayMenu_Close.Name = "trayMenu_Close"
        Me.trayMenu_Close.Size = New System.Drawing.Size(102, 22)
        Me.trayMenu_Close.Text = "close"
        '
        'DummyFileCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(360, 463)
        Me.Controls.Add(Me.tab_Main)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DummyFileCreator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tab_DFC.ResumeLayout(False)
        Me.tab_DFC.PerformLayout()
        Me.grp_Content.ResumeLayout(False)
        Me.grp_Content.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grp_Analysis.ResumeLayout(False)
        Me.grp_Analysis.PerformLayout()
        Me.grp_rules.ResumeLayout(False)
        Me.grp_rules.PerformLayout()
        Me.tab_Main.ResumeLayout(False)
        Me.tab_preferences.ResumeLayout(False)
        Me.tab_preferences.PerformLayout()
        Me.grp_Language.ResumeLayout(False)
        Me.grp_Language.PerformLayout()
        Me.tray_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dialog_Speicherort As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer_Check As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_Datei As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Datei_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tab_DFC As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Status_text As System.Windows.Forms.Label
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents grp_Analysis As System.Windows.Forms.GroupBox
    Friend WithEvents txt_progessFile As System.Windows.Forms.TextBox
    Friend WithEvents txt_FileSize As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Filename As System.Windows.Forms.Label
    Friend WithEvents txt_SpaceLeft As System.Windows.Forms.TextBox
    Friend WithEvents txt_DriveInfo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_speed_average As System.Windows.Forms.Label
    Friend WithEvents lbl_FileSize As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalSpace As System.Windows.Forms.Label
    Friend WithEvents lbl_spaceLeft As System.Windows.Forms.Label
    Friend WithEvents progressbar_spaceleft As System.Windows.Forms.ProgressBar
    Friend WithEvents txt_speed_average As System.Windows.Forms.TextBox
    Friend WithEvents grp_rules As System.Windows.Forms.GroupBox
    Friend WithEvents combo_Copies As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Copy As System.Windows.Forms.Label
    Friend WithEvents check_OverwriteFiles As System.Windows.Forms.CheckBox
    Friend WithEvents txt_SpeicherOrt As System.Windows.Forms.TextBox
    Friend WithEvents txt_SizeOfFileToCreate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SpaceLeftPercent As System.Windows.Forms.Label
    Friend WithEvents cmd_CreateFile As System.Windows.Forms.Button
    Friend WithEvents radio_endless As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Speicherort As System.Windows.Forms.Label
    Friend WithEvents combo_unit As System.Windows.Forms.ComboBox
    Friend WithEvents radio_FileSize As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_Speicherort_auswaehlen As System.Windows.Forms.Button
    Friend WithEvents tab_Main As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents trayicon As System.Windows.Forms.NotifyIcon
    Friend WithEvents tray_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents trayMenu_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents trayMenu_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tab_preferences As System.Windows.Forms.TabPage
    Friend WithEvents check_minimizeToTray As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Content As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Content As System.Windows.Forms.TextBox
    Friend WithEvents check_Content As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Language As System.Windows.Forms.GroupBox
    Friend WithEvents radio_language_german As System.Windows.Forms.RadioButton
    Friend WithEvents radio_language_english As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip_Minimize As System.Windows.Forms.ToolTip

End Class

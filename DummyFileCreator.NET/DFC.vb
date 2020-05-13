Imports System.IO
Imports System
Imports System.Management

Public Class DummyFileCreator
    
    Private copies As Integer
    Private LanguageChanger As Language = New Language()
    Dim seconds As Long
    Dim mytext As String
    Dim flagThreadsReady As Boolean = True

    Public randomValue() As Byte
    Public lenRandomValue As Integer
    Private encoding As New System.Text.UTF8Encoding()
    Public Delegate Sub formInvokeDelegate()

    Private Sub cmd_Speicherort_auswaehlen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Speicherort_auswaehlen.Click
        Dialog_Speicherort.ShowDialog()
        filename = Dialog_Speicherort.FileName
        txt_SpeicherOrt.Text = Dialog_Speicherort.FileName
        If Dialog_Speicherort.FileName <> "" Then
            cmd_CreateFile.Enabled = True
        Else
            cmd_CreateFile.Enabled = False
        End If
        If File.Exists(Dialog_Speicherort.FileName) Then
            check_OverwriteFiles.Enabled = True
        Else
            check_OverwriteFiles.Enabled = False
        End If
        radio_endless.Enabled = True
        radio_FileSize.Enabled = True
        check_Content.Enabled = True
    End Sub

    Private Sub txt_SpeicherOrt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SpeicherOrt.TextChanged
        txt_SpeicherOrt.Text = filename
    End Sub

    Private Sub cmd_CreateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CreateFile.Click
        mytext = txt_Content.Text
        filename = Dialog_Speicherort.FileName
        If cmd_CreateFile.Text = ObjectHandler.CurrentLanguage.cmd_CreateFile_Start Then
            cmd_CreateFile.Text = ObjectHandler.CurrentLanguage.cmd_CreateFile_Stop
            If check_Content.Checked = True Then
                If txt_Content.Text <> "" Then
                    myWriteThread = New System.Threading.Thread(AddressOf writeWords)
                Else
                    MsgBox(ObjectHandler.CurrentLanguage.Enter_Text_Befor_Start)
                    cmd_CreateFile.Text = ObjectHandler.CurrentLanguage.cmd_CreateFile_Start
                    txt_Content.Focus()
                    Exit Sub
                End If
            Else
                myRandomValueThread = New System.Threading.Thread(AddressOf getRandomValue)
                myWriteThread = New System.Threading.Thread(AddressOf writeBytes)
                randomValue = encoding.GetBytes("")
                myRandomValueThread.Start()
            End If
            myWriteThread.Start()
            Timer_Check.Start()
            Dim BytesSend = 0
            flagThreadsReady = False
        Else
            cmd_CreateFile.Text = ObjectHandler.CurrentLanguage.cmd_CreateFile_Start
            Try
                killAllThreads()
                CloseFileStream(FS)
                FS = Nothing
                Status = ObjectHandler.CurrentLanguage.Status_Aborted
                check()
                Timer_Check.Stop()
            Catch ex As System.Threading.ThreadAbortException
            End Try
        End If
    End Sub
    

    Private Sub check()
        seconds += 1
        fileinfo = New FileInfo(filename)
        txt_FileSize.Text = Format(fileinfo.Length / 1024 ^ 3, "###0.00") & " GB "
        Dim drive As New IO.DriveInfo(Mid(txt_SpeicherOrt.Text, 1, 3))
        txt_DriveInfo.Text = Math.Round(drive.TotalSize / 1024 / 1024 / 1024, 2) & " GByte"
        txt_SpaceLeft.Text = Math.Round(drive.TotalFreeSpace / 1024 / 1024 / 1024, 3) & " / " & Math.Round(drive.TotalSize / 1024 / 1024 / 1024, 3) & " GByte"
        progressbar_spaceleft.Value = (drive.TotalFreeSpace / drive.TotalSize) * 100
        txt_speed_average.Text = Math.Round(BytesSend / 1024 / 1024 / seconds, 2) & " MByte/sec"
        lbl_SpaceLeftPercent.Text = Math.Round((drive.TotalFreeSpace / drive.TotalSize) * 100, 3) & " %"
        txt_progessFile.Text = ObjectHandler.CurrentLanguage.InfoFile & copies - 1 & "/" & copyCounter & " - " & filename & "  (" & Convert.ToString(Math.Round((copies - 1) / copyCounter, 2) * 100) & "%)"
        lbl_Status_text.Text = Status
        If Status = ObjectHandler.CurrentLanguage.Status_Finished Or Status = ObjectHandler.CurrentLanguage.Status_Aborted Then
            Me.progressbar_spaceleft.Value = 0
            Me.cmd_CreateFile.Text = ObjectHandler.CurrentLanguage.cmd_CreateFile_Start
            check_OverwriteFiles.Enabled = File.Exists(txt_SpeicherOrt.Text)
            initEnabled(True)
            seconds = 0
            BytesSend = 0
        Else
            initEnabled(False)
        End If
        If flagThreadsReady = True Then
            killAllThreads()
            Timer_Check.Stop()
        End If
    End Sub
    Private Sub initEnabled(ByVal bln As Boolean)
        check_OverwriteFiles.Enabled = bln
        radio_FileSize.Enabled = bln
        radio_endless.Checked = bln
        cmd_Speicherort_auswaehlen.Enabled = bln
        check_Content.Enabled = bln
    End Sub

    Private Sub Timer_Check_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Check.Tick
        check()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub DummyFileCreator_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If check_minimizeToTray.Checked = True Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            Me.trayicon.ShowBalloonTip(50, ObjectHandler.CurrentLanguage.BallonTip_Info, ObjectHandler.CurrentLanguage.BallonTip_Content, ToolTipIcon.Info)
            e.Cancel = True
        Else
            AppClosing()
        End If
    End Sub

    Private Sub radio_FileSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_FileSize.CheckedChanged
        txt_SizeOfFileToCreate.Enabled = True
        combo_unit.Enabled = True
        combo_Copies.Enabled = True
    End Sub

    Private Sub radio_endless_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_endless.CheckedChanged
        txt_SizeOfFileToCreate.Enabled = False
        combo_unit.Enabled = False
        combo_Copies.Enabled = False
        combo_Copies.SelectedIndex = 0
    End Sub

    Private Sub txt_SizeOfFileToCreate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SizeOfFileToCreate.TextChanged
        If txt_SizeOfFileToCreate.Text = "0" Then
            MessageBox.Show(ObjectHandler.CurrentLanguage.FilsizeNotAllowed)
            txt_SizeOfFileToCreate.Text = 1
        Else
            If txt_SizeOfFileToCreate.Text <> "" Then
                sizeoffiletocreate = CLng(txt_SizeOfFileToCreate.Text)
            End If
        End If
    End Sub

    Private Sub DummyFileCreator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObjectHandler.setDFC(Me)
        ObjectHandler.Language_Main.changeLanguageDFC(GetSetting("DummyFileCreator", "settings", "Language", "ENG"))
        radio_endless.Checked = True
        combo_unit.SelectedIndex = 0
        unit = combo_unit.SelectedItem.ToString
        combo_Copies.SelectedIndex = 0
        Me.Location = New Point((SystemInformation.WorkingArea.Right - Me.Width) / 2, (SystemInformation.WorkingArea.Bottom - Me.Height) / 2)
        checkContent()
        initSettings()
    End Sub

    Private Sub combo_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_unit.SelectedIndexChanged
        unit = combo_unit.SelectedItem.ToString
    End Sub

    Private Sub check_OverwriteFiles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_OverwriteFiles.CheckedChanged
        If Me.check_OverwriteFiles.Checked = True Then
            Status = ObjectHandler.CurrentLanguage.Status_OverwrightMode
        Else
            Status = ObjectHandler.CurrentLanguage.Status_AppendMode
        End If
        
    End Sub

    Private Sub combo_Copies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_Copies.SelectedIndexChanged
        copyCounter = combo_Copies.SelectedItem.ToString
    End Sub

    Private Sub writeBytes()
        Dim counter As Long
        Dim drive As New IO.DriveInfo(Mid(filename, 1, 3))
        Dim enc As System.Text.Encoding = System.Text.Encoding.Default
        Dim encoding As New System.Text.UTF8Encoding()
        Dim randomtmp() As Byte

        Status = ObjectHandler.CurrentLanguage.Status_Working
        If checkForFile() = False Then
            GoTo ende
        End If

        If radio_endless.Checked = True Then
            For counter = drive.TotalSize - drive.TotalFreeSpace To drive.TotalSize
                For x As Integer = 0 To 1024
                    randomtmp = randomValue
                    FS.Write(randomtmp, 0, randomtmp.Length)
                Next
                BytesSend = BytesSend + 1024 * (randomtmp.Length)
            Next

        ElseIf radio_FileSize.Checked = True Then
            filelength = calc_file_length(sizeoffiletocreate, unit)
            If filelength <> 0 Then
                For Me.copies = 1 To copyCounter
                    Do While BytesSend <= filelength - randomValue.Length
                        randomtmp = randomValue
                        FS.Write(randomtmp, 0, randomtmp.Length)
                        BytesSend = BytesSend + randomtmp.Length
                    Loop
                    FS.Flush()
                    If FileLen(filename) <> filelength Then
                        'letzten Rest schreiben weil die Bytelänge vorher nicht definiert werden konnte
                        FS.Write(randomValue, 0, filelength - FileLen(filename))
                    End If
                    If copies < copyCounter Then
                        filename = txt_SpeicherOrt.Text & "_" & copies.ToString
                        If checkForFile() = False Then
                            GoTo ende
                        End If
                        CloseFileStream(FS)
                        FS = New FileStream(filename, FileMode.Create)
                        BytesSend = 0
                    Else
                        BytesSend = BytesSend * copyCounter
                    End If
                Next
            End If
        End If
ende:
        CloseFileStream(FS)
        Status = ObjectHandler.CurrentLanguage.Status_Finished
        invokeForm()
        flagThreadsReady = True
        Exit Sub
    End Sub

    Private Sub writeWords()
        Dim counter As Long
        Dim drive As New IO.DriveInfo(Mid(filename, 1, 3))
        Dim enc As System.Text.Encoding = System.Text.Encoding.Default
        Dim myRandom As New System.Random()

        Dim myByte() As Byte
        Dim ByteLength As Integer

        Status = ObjectHandler.CurrentLanguage.Status_Working

        If checkForFile() = False Then
            GoTo ende
        End If
        myByte = encoding.GetBytes(getLongerText(mytext))
        ByteLength = myByte.Length
        If radio_endless.Checked = True Then
            For counter = drive.TotalSize - drive.TotalFreeSpace To drive.TotalSize
                For x As Integer = 0 To 1024
                    FS.Write(myByte, 0, ByteLength)
                Next
                BytesSend = BytesSend + (ByteLength * 1024)
            Next
        ElseIf radio_FileSize.Checked = True Then
            filelength = calc_file_length(sizeoffiletocreate, unit)
            If filelength <> 0 Then
                For Me.copies = 1 To copyCounter
                    For x As Integer = 0 To filelength - ByteLength Step ByteLength
                        FS.Write(myByte, 0, ByteLength)
                        BytesSend = BytesSend + ByteLength
                    Next
                    FS.Flush()
                    If FileLen(filename) <> filelength Then
                        'letzten Rest schreiben weil die Bytelänge vorher nicht definiert werden konnte
                        FS.Write(myByte, 0, filelength - FileLen(filename))
                    End If
                    If copies < copyCounter Then
                        filename = txt_SpeicherOrt.Text & "_" & copies.ToString
                        If checkForFile() = False Then
                            GoTo ende
                        End If
                        CloseFileStream(FS)
                        FS = New FileStream(filename, FileMode.Create)
                    End If
                Next
            End If
        End If
ende:
        CloseFileStream(FS)
        Status = ObjectHandler.CurrentLanguage.Status_Finished
        invokeForm()
        flagThreadsReady = True
    End Sub

    Private Sub AppClosing()
        Try
            killAllThreads()
            Timer_Check.Stop()
            If TypeName(FS) <> "Nothing" Then
                CloseFileStream(FS)
                FS = Nothing
            End If
        Catch ex As System.Threading.ThreadAbortException
        End Try
        trayicon.Visible = False
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_About.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Datei_Close.Click
        AppClosing()
        Application.Exit()
    End Sub

    Public Sub invokeForm()
        Me.Invoke(New formInvokeDelegate(AddressOf check))
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trayMenu_Open.Click
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub DummyFileCreator_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            Me.trayicon.Visible = True
        End If
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trayMenu_Close.Click
        AppClosing()
        Application.Exit()
    End Sub

    Private Sub trayicon_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trayicon.DoubleClick
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub check_minimizeToTray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_minimizeToTray.CheckedChanged
        SaveSetting("DummyFileCreator", "settings", "check_minimizeToTray", check_minimizeToTray.Checked.ToString)
    End Sub

    Private Sub check_Content_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Content.CheckedChanged
        checkContent()
    End Sub

    Public Sub checkContent()
        If check_Content.Checked = True Then
            txt_Content.Enabled = True
        Else
            txt_Content.Enabled = False
        End If
    End Sub

    Private Sub radio_language_english_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_language_english.CheckedChanged
        LanguageChanger.changeLanguageDFC("ENG")
    End Sub

    Private Sub radio_language_german_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_language_german.CheckedChanged
        LanguageChanger.changeLanguageDFC("DEU")
    End Sub

    Private Sub initSettings()
        Me.check_minimizeToTray.Checked = GetSetting("DummyFileCreator", "settings", "check_minimizeToTray", "TRUE")
    End Sub

    Private Function checkForFile() As Boolean
        CloseFileStream(FS)
        If check_OverwriteFiles.Checked = True Then
            File.Delete(filename)
            FS = New FileStream(filename, FileMode.Create)
            Return True
        Else
            If File.Exists(filename) Then
                MsgBox(ObjectHandler.CurrentLanguage.Message_File_Exist)
                Return False
            Else
                FS = New FileStream(filename, FileMode.Create)
                Return True
            End If
        End If
    End Function
End Class


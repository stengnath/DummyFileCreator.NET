Public Class Language

    Public Sub changeLanguageDFC(ByVal Language As String)
        SaveSetting("DummyFileCreator", "settings", "Language", Language)
        Select Case Language
            Case "DEU"
                setLanguageDFC(ObjectHandler.Language_DE)
                ObjectHandler.CurrentLanguage = ObjectHandler.Language_DE
            Case "ENG"
                setLanguageDFC(ObjectHandler.Language_ENG)
                ObjectHandler.CurrentLanguage = ObjectHandler.Language_ENG
        End Select
    End Sub

    Public Sub setLanguageDFC(ByRef languageObject As Object)
        'Textbox
        'DummyFileCreator.txt_Content.Text = ""
        'DummyFileCreator.txt_DriveInfo.Text = ""
        'DummyFileCreator.txt_progessFile.Text = ""
        'DummyFileCreator.txt_FileSize.Text = ""
        'DummyFileCreator.txt_SizeOfFileToCreate.Text = ""
        'DummyFileCreator.txt_SpaceLeft.Text = ""
        'DummyFileCreator.txt_speed_average.Text = ""
        'DummyFileCreator.txt_SpeicherOrt.Text = ""
        'Label
        ObjectHandler.DFC.lbl_Copy.Text = languageObject.lbl_Copy
        ObjectHandler.DFC.lbl_Filename.Text = languageObject.lbl_Filename
        ObjectHandler.DFC.lbl_FileSize.Text = languageObject.lbl_FileSize
        ObjectHandler.DFC.lbl_speed_average.Text = languageObject.lbl_speed_average
        ObjectHandler.DFC.lbl_Speicherort.Text = languageObject.lbl_Speicherort
        ObjectHandler.DFC.lbl_Status.Text = languageObject.lbl_Status
        ObjectHandler.DFC.lbl_Status_text.Text = languageObject.lbl_Status
        ObjectHandler.DFC.lbl_TotalSpace.Text = languageObject.lbl_TotalSpace
        ObjectHandler.DFC.lbl_spaceLeft.Text = languageObject.lbl_spaceLeft

        'Button
        ObjectHandler.DFC.cmd_CreateFile.Text = languageObject.cmd_CreateFile_Start


        'GroupBox
        ObjectHandler.DFC.grp_Analysis.Text = languageObject.grp_Analysis
        ObjectHandler.DFC.grp_Content.Text = languageObject.grp_Content
        ObjectHandler.DFC.grp_Language.Text = languageObject.grp_Language
        ObjectHandler.DFC.grp_rules.Text = languageObject.grp_rules

        'checkbox
        ObjectHandler.DFC.check_Content.Text = languageObject.check_Content
        ObjectHandler.DFC.check_minimizeToTray.Text = languageObject.check_minimizeToTray
        ObjectHandler.DFC.check_OverwriteFiles.Text = languageObject.check_OverwriteFiles

        'radio
        ObjectHandler.DFC.radio_endless.Text = languageObject.radio_endless
        ObjectHandler.DFC.radio_FileSize.Text = languageObject.radio_FileSize
        ObjectHandler.DFC.radio_language_english.Text = languageObject.radio_language_english
        ObjectHandler.DFC.radio_language_german.Text = languageObject.radio_language_german

        'Menü
        ObjectHandler.DFC.Menu_Datei.Text = languageObject.Menu_Datei
        ObjectHandler.DFC.menu_Datei_Close.Text = languageObject.menu_Datei_Close
        ObjectHandler.DFC.Menu_About.Text = languageObject.Menu_About

        'Tabs
        ObjectHandler.DFC.tab_preferences.Text = languageObject.tab_preferences

        'TrayMenu
        ObjectHandler.DFC.trayMenu_Open.Text = languageObject.trayMenu_Open
        ObjectHandler.DFC.trayMenu_Close.Text = languageObject.trayMenu_Close


    End Sub
End Class

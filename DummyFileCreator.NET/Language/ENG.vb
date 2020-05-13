Public Class ENG
#Region "DFC"
    Public txt_Content = ""
    Public txt_DriveInfo = ""
    Public txt_progessFile = ""
    Public txt_FileSize = ""
    Public txt_SpaceLeft = ""
    Public txt_speed_average = ""

    'Label
    Public lbl_Copy = "Copies:"
    Public lbl_Filename = "Filename"
    Public lbl_FileSize = "Acutal file size"
    Public lbl_spaceLeft = "Space left:"
    Public lbl_speed_average = "Average Speed"
    Public lbl_Speicherort = "Destination:"
    Public lbl_Status = "Status"
    Public lbl_TotalSpace = "Total space"

    'Button
    Public cmd_CreateFile_Start = "Start"
    Public cmd_CreateFile_Stop = "Stop"

    'GroupBox
    Public grp_Analysis = "Analysis"
    Public grp_Content = "Content"
    Public grp_Language = "Language"
    Public grp_rules = "Rules"

    'checkbox
    Public check_Content = "Custom content"
    Public check_minimizeToTray = "minimize to tray"
    Public check_OverwriteFiles = "Overwrite files"

    'radio
    Public radio_endless = "endless"
    Public radio_FileSize = "File size"
    Public radio_language_english = "English"
    Public radio_language_german = "German"

    'Menü
    Public Menu_Datei = "File"
    Public menu_Datei_Close = "Close"
    Public Menu_About = "About DFC"

    'Tabs
    Public tab_preferences = "Preferences"

    'TrayMenu
    Public trayMenu_Close = "Close"
    Public trayMenu_Open = "Show"

    'Misc Text
    Public FilsizeNotAllowed = "Filesize less then 0 not allowed"
    Public InfoFile = "File "
    Public BallonTip_Info = "DFC is still running..."
    Public BallonTip_Content = "The Dummy File Creator is still running"
    Public Status_Working = "In progress"
    Public Status_Finished = "Finished"
    Public Status_Aborted = "Aborted"
    Public Status_OverwrightMode = "Overwrite-Mode"
    Public Status_AppendMode = "Append-Mode"

    'MessageBox
    Public Enter_Text_Befor_Start = "Please enter a text befor starting the creation process"
    Public Message_File_Exist = "The file that should have been written already exists. Process was stopped."
#End Region

#Region "About"
    Public lblCompany = "Producer: "
    Public lblVersion = "Version: "
#End Region
End Class

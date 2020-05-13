Public Class DE
#Region "DFC"

    Public txt_Content = ""
    Public txt_DriveInfo = ""
    Public txt_progessFile = ""
    Public txt_FileSize = ""
    Public txt_SpaceLeft = ""
    Public txt_speed_average = ""

    'Label
    Public lbl_Copy = "Kopien:"
    Public lbl_Filename = "Dateiname"
    Public lbl_FileSize = "Dateigrösse"
    Public lbl_speed_average = "Geschwindigkeit"
    Public lbl_Speicherort = "Ziel:"
    Public lbl_Status = "Status"
    Public lbl_TotalSpace = "Speicher gesamt"
    Public lbl_spaceLeft = "Speicher übrig"

    'Button
    Public cmd_CreateFile_Start = "Start"
    Public cmd_CreateFile_Stop = "Stop"

    'GroupBox
    Public grp_Analysis = "Analyse"
    Public grp_Content = "Inhalt"
    Public grp_Language = "Sprache"
    Public grp_rules = "Optionen"

    'checkbox
    Public check_Content = "spezieller Inhalt"
    Public check_minimizeToTray = "In Taskleiste minimieren"
    Public check_OverwriteFiles = "Dateien überschreiben"

    'radio
    Public radio_endless = "endlos"
    Public radio_FileSize = "Dateigrösse"
    Public radio_language_english = "Englisch"
    Public radio_language_german = "Deutsch"

    'Menu
    Public Menu_Datei = "Datei"
    Public menu_Datei_Close = "Schließen"
    Public Menu_About = "Über DFC"

    'Tabs
    Public tab_preferences = "Einstellungen"

    'TrayMenu
    Public trayMenu_Close = "Beenden"
    Public trayMenu_Open = "Anzeigen"

    'Misc Text
    Public FilsizeNotAllowed = "Dateigröße von 0 nicht zulässig"
    Public BallonTip_Info = "DFC wird noch ausgeführt..."
    Public BallonTip_Content = "Der Dummy File Creator wird noch ausgeführt."
    Public Status_Working = "Verarbeitung gestartet"
    Public Status_Finished = "Beendet"
    Public Status_OverwrightMode = "Überschreiben aktiviert"
    Public Status_AppendMode = "Anhängen aktiviert"
    Public Status_Aborted = "Abgebrochen"
    Public InfoFile = "Datei "

    'MessageBox
    Public Enter_Text_Befor_Start = "Bitte geben Sie erst einen Text ein bevor sie die Verarbeitung starten"
    Public Message_File_Exist = "Eine Datei existiert bereits. Vorgang wird abgebrochen"
#End Region

#Region "About"

    Public lblCompany = "Hersteller: "
    Public lblVersion = "Version: "
#End Region

End Class

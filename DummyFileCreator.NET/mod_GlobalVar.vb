Imports System.IO

Module mod_GlobalVar

    Private m_drive As IO.DriveInfo
    Private m_fileinfo As IO.FileInfo
    Private m_myWriteThread As System.Threading.Thread
    Private m_myRandomValueThread As System.Threading.Thread
    Private m_BytesSend As Long
    Private m_TimeSpan As TimeSpan
    Private m_FS As IO.FileStream
    Private m_filelength As Long
    Private m_sizeoffiletocreate As Long
    Private m_unit As String
    Private m_copyCounter As Long
    Private m_filename As String
    Private m_Status As String

    Public Property Status() As String
        Get
            Return m_Status
        End Get
        Set(ByVal value As String)
            m_Status = value
        End Set
    End Property

    Public Property drive() As IO.DriveInfo
        Get
            Return m_drive
        End Get
        Set(ByVal value As IO.DriveInfo)
            m_drive = value
        End Set
    End Property
    Public Property fileinfo() As IO.FileInfo
        Get
            Return m_fileinfo
        End Get
        Set(ByVal value As IO.FileInfo)
            m_fileinfo = value
        End Set
    End Property

    Public Property BytesSend() As Long
        Get
            Return m_BytesSend
        End Get
        Set(ByVal value As Long)
            m_BytesSend = value
        End Set
    End Property

    Public Property copyCounter() As Long
        Get
            Return m_copyCounter
        End Get
        Set(ByVal value As Long)
            m_copyCounter = value
        End Set
    End Property

    Public Property filelength() As Long
        Get
            Return m_filelength
        End Get
        Set(ByVal value As Long)
            m_filelength = value
        End Set
    End Property

    Public Property filename() As String
        Get
            Return m_filename
        End Get
        Set(ByVal value As String)
            m_filename = value
        End Set
    End Property

    Public Property FS() As FileStream
        Get
            Return m_FS
        End Get
        Set(ByVal value As FileStream)
            m_FS = value
        End Set
    End Property

    Public Property myWriteThread() As System.Threading.Thread
        Get
            Return m_myWriteThread
        End Get
        Set(ByVal value As System.Threading.Thread)
            m_myWriteThread = value
        End Set
    End Property

    Public Property myRandomValueThread() As System.Threading.Thread
        Get
            Return m_myRandomValueThread
        End Get
        Set(ByVal value As System.Threading.Thread)
            m_myRandomValueThread = value
        End Set
    End Property

    Public Property sizeoffiletocreate() As Long
        Get
            Return m_sizeoffiletocreate
        End Get
        Set(ByVal value As Long)
            m_sizeoffiletocreate = value
        End Set
    End Property

    Public Property TimeSpan() As TimeSpan
        Get
            Return m_TimeSpan
        End Get
        Set(ByVal value As TimeSpan)
            m_TimeSpan = value
        End Set
    End Property

    Public Property unit() As String
        Get
            Return m_unit
        End Get
        Set(ByVal value As String)
            m_unit = value
        End Set
    End Property

End Module

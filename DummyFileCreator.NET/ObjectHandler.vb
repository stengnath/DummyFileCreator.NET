Module ObjectHandler
    Private m_frmDFC As DummyFileCreator
    Private m_frmAbout As frmAbout
    Private m_Language As Language
    Private m_DE As DE
    Private m_ENG As ENG
    Private m_CurrentLanguage As Object

    Public Sub setDFC(ByRef DFC As DummyFileCreator)
        m_frmDFC = DFC
    End Sub
    Public ReadOnly Property DFC() As DummyFileCreator
        Get
            Return m_frmDFC
        End Get
    End Property

    Public Property FormAbout() As frmAbout
        Get
            If m_frmAbout Is Nothing = True Then
                m_frmAbout = New frmAbout
            End If
            Return m_frmAbout
        End Get
        Set(ByVal value As frmAbout)
            m_frmAbout = value
        End Set
    End Property

    Public Property Language_Main() As Language
        Get
            If m_Language Is Nothing = True Then
                m_Language = New Language
            End If
            Return m_Language
        End Get
        Set(ByVal value As Language)
            m_Language = value
        End Set
    End Property

    Public Property Language_DE() As DE
        Get
            If m_DE Is Nothing = True Then
                m_DE = New DE
            End If
            Return m_DE
        End Get
        Set(ByVal value As DE)
            m_DE = value
        End Set
    End Property

    Public Property Language_ENG() As ENG
        Get
            If m_frmAbout Is Nothing = True Then
                m_ENG = New ENG
            End If
            Return m_ENG
        End Get
        Set(ByVal value As ENG)
            m_ENG = value
        End Set
    End Property

    Public Property CurrentLanguage() As Object
        Get
            Return m_CurrentLanguage
        End Get
        Set(ByVal value As Object)
            m_CurrentLanguage = value
        End Set
    End Property
End Module

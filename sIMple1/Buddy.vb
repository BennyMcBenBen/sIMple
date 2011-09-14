Public Class Buddy

    Private m_screenname As String = ""
    Private m_alias As String = ""
    Private m_status As String = ""
    Private m_msg As String = ""
    Private m_info As String = ""

    Public Sub New(ByVal sn As String, ByVal aliasin As String, ByVal status As String, ByVal msg As String, ByVal info As String)
        m_screenname = sn

        If aliasin = "" Then
            m_alias = sn
        Else
            m_alias = aliasin
        End If

        m_status = status
        m_msg = msg
        m_info = info
    End Sub

    Public Property Screenname() As String
        Get
            Return m_screenname
        End Get
        Set(ByVal value As String)
            m_screenname = value
        End Set
    End Property

    Public Property NameAlias() As String
        Get
            Return m_alias
        End Get
        Set(ByVal value As String)
            m_alias = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return m_status
        End Get
        Set(ByVal value As String)
            m_status = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return m_msg
        End Get
        Set(ByVal value As String)
            m_msg = value
        End Set
    End Property

    Public Property Info() As String
        Get
            Return m_info
        End Get
        Set(ByVal value As String)
            m_info = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Dim str As String = ""
        If m_alias IsNot "" Then
            str = m_alias & vbNewLine
        End If
        str &= "Screenname: " & m_screenname & vbNewLine & "Status: " & m_status
        If m_msg <> "" Then
            str &= vbNewLine & "Message: " & m_msg
        End If
        Return str
    End Function
End Class

Public Class BuddyList

    Dim buddies As New Dictionary(Of String, Dictionary(Of String, Buddy))
    Dim chatWindows As New Dictionary(Of String, ChatWindow)
    Dim self As New Buddy("simpleScreenName", "Guy", "available", "", "")
    Dim responses As New ArrayList
    Shared first As Boolean = True
    Dim _tempName As String


    Public Property TempName() As String
        Get
            Return _tempName
        End Get
        Set(ByVal value As String)
            _tempName = value
        End Set
    End Property

    Public Property Myself() As Buddy
        Get
            Return self
        End Get
        Set(ByVal value As Buddy)
            self = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        Randomize()

        InitMessages()

        UpdateB1Caption()
        If first Then
            Dim login As New System.Media.SoundPlayer
            login.SoundLocation = "login.wav"
            login.Load()
            login.Play()
            NotifyIcon1.Visible = True
            first = False
        End If

        DockRight()

        ' load status icons
        TreeView1.ImageList = StatusImages

        TempName = ""

        LoadXML()

        UpdateBuddyList()

    End Sub

    Public Sub LoadXML()
        ' read in the XML document and put in the Dictionary
        Dim sr As New System.IO.StreamReader("BuddyList.xml")
        Dim xr As New System.Xml.XmlTextReader(sr)
        Dim buddylistDoc As New System.Xml.XmlDocument
        buddylistDoc.Load(xr)

        Dim buddiesNode As System.Xml.XmlNode = buddylistDoc.SelectSingleNode("/buddies")

        Dim groupNode As System.Xml.XmlNode
        For Each groupNode In buddiesNode
            Dim groupName As String = groupNode.Attributes.GetNamedItem("name").Value
            Dim group As New Dictionary(Of String, Buddy)
            AddBuddies(group, groupNode)
            buddies.Add(groupName, group)
        Next
        xr.Close()
        sr.Close()
    End Sub


    Public Sub UpdateB1Caption()
        Dim b1Caption = "Status: " & self.Status
        If self.Message <> "" Then
            b1Caption &= vbNewLine & "Message: " & self.Message
        End If
        ToolTip1.SetToolTip(Button1, b1Caption)
    End Sub

    Private Sub InitMessages()

        ' read in the XML document and put in the Dictionary
        Dim sr As New System.IO.StreamReader("Messages.xml")
        Dim xr As New System.Xml.XmlTextReader(sr)
        Dim messagesDoc As New System.Xml.XmlDocument
        messagesDoc.Load(xr)

        Dim messagesNode As System.Xml.XmlNode = messagesDoc.SelectSingleNode("/messages")

        Dim msgNode As System.Xml.XmlNode
        For Each msgNode In messagesNode
            responses.Add(msgNode.InnerText)
        Next
    End Sub

    Public Function GetResponse() As String

        Dim value As Integer = Int(responses.Count * Rnd())

        Return responses.Item(value)
    End Function

    Private Function AddBuddies(ByVal group As Dictionary(Of String, Buddy), ByVal groupNode As System.Xml.XmlNode) As Dictionary(Of String, Buddy)
        Dim buddyNode As System.Xml.XmlNode
        For Each buddyNode In groupNode
            Dim sn As String = buddyNode.Attributes.GetNamedItem("sn").Value
            Dim realName As String = buddyNode.Attributes.GetNamedItem("alias").Value
            Dim status As String = buddyNode.Attributes.GetNamedItem("status").Value
            Dim msg As String = buddyNode.Item("statusMessage").InnerText
            Dim info As String = buddyNode.Item("info").InnerText
            Dim buddy As New Buddy(sn, realName, status, msg, info)
            group.Add(sn, buddy)
        Next
        Return group
    End Function

    Private Sub UpdateBuddyList()
        ' clear treeview
        TreeView1.Nodes.Clear()

        ' load buddies from Dictionary
        Dim groupNames = buddies.Keys
        Dim groupName As String
        For Each groupName In groupNames
            Dim groupNode As TreeNode
            groupNode = TreeView1.Nodes.Add(groupName, groupName, 0, 0)
            groupNode.NodeFont = New Font(TreeView1.Font, FontStyle.Bold)

            Dim group As Dictionary(Of String, Buddy)
            group = buddies.Item(groupName)

            Dim sns = group.Keys
            Dim sn As String
            For Each sn In sns
                Dim buddy As Buddy = group.Item(sn)
                AddBuddyNodeToTreeView(buddy, groupNode)
            Next
        Next

        ' expand and sort the buddy list
        TreeView1.Sort()
        TreeView1.ExpandAll()
    End Sub

    Private Sub AddBuddyNodeToTreeView(ByVal buddy As Buddy, ByVal groupNode As TreeNode)
        Dim displayAvailable As Boolean = AvailableCheckBox.Checked
        Dim displayAway As Boolean = AwayCheckBox.Checked
        Dim displayOffline As Boolean = OfflineCheckBox.Checked

        ' set buddy status icon
        Dim buddyNode As TreeNode
        Dim index As Integer
        Select Case buddy.Status
            Case Is = "available"
                If displayAvailable Then
                    index = 1
                    buddyNode = groupNode.Nodes.Add(buddy.Screenname, buddy.NameAlias, index, index)
                    buddyNode.ToolTipText = buddy.ToString
                End If
            Case Is = "away"
                If displayAway Then
                    index = 2
                    buddyNode = groupNode.Nodes.Add(buddy.Screenname, buddy.NameAlias, index, index)
                    buddyNode.ToolTipText = buddy.ToString
                End If
            Case Else
                If displayOffline Then
                    index = 3
                    buddyNode = groupNode.Nodes.Add(buddy.Screenname, buddy.NameAlias, index, index)
                    buddyNode.ToolTipText = buddy.ToString
                End If
        End Select

    End Sub

    Private Sub DockRight()
        ' This will dock the form to the top right side of the screen
        Me.Top = 0
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width

    End Sub

    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        If MouseButtons = Windows.Forms.MouseButtons.Right Then
            ' Point where mouse is clicked
            Dim p As Point = New Point(e.X, e.Y)

            ' Go to the node that the user clicked
            Dim node As TreeNode = TreeView1.GetNodeAt(p)

            If Not node Is Nothing Then
                TreeView1.SelectedNode = node

                If node.Level = 1 Then
                    ContextMenuStrip2.Show(TreeView1, p)
                End If
            End If
            
        End If
    End Sub


    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim node As TreeNode = e.Node
        If node.Level = 1 Then
            OpenChatWindow(node.Name, node.Text, node.Parent.Text)
        End If
    End Sub

    Private Function OpenChatWindow(ByVal screenname As String, ByVal name As String, ByVal group As String) As ChatWindow

        Dim chat As ChatWindow
        If chatWindows.ContainsKey(screenname) Then
            chat = chatWindows.Item(screenname)

        Else
            Dim b As Buddy = buddies.Item(group).Item(screenname)
            chat = New ChatWindow(b)

            ' so you don't IM the same person twice
            chatWindows.Add(screenname, chat)
        End If
        chat.Show()
        chat.Input.Focus()
        Return chat
    End Function

    Private Function OpenChatWindow(ByVal sn As String) As ChatWindow
        Dim chat As ChatWindow
        If chatWindows.ContainsKey(sn) Then
            chat = chatWindows.Item(sn)

        Else
            chat = New ChatWindow(sn)

            ' so you don't IM the same person twice
            chatWindows.Add(sn, chat)
        End If
        chat.Show()
        chat.Input.Focus()
        Return chat
    End Function



    Private Sub NotImplemented(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click, HelpToolStripMenuItem.Click
        MessageBox.Show("Not implemented")
    End Sub

    Public Sub DeleteChatWindowKey(ByVal sn As String)
        chatWindows.Remove(sn)
    End Sub

    Private Sub AvailableCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableCheckBox.CheckStateChanged
        UpdateBuddyList()
    End Sub

    Private Sub AwayCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AwayCheckBox.CheckStateChanged
        UpdateBuddyList()
    End Sub

    Private Sub OfflineCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OfflineCheckBox.CheckStateChanged
        UpdateBuddyList()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, ChangeStatusToolStripMenuItem.Click
        ChangeStatusForm.Show()
    End Sub

    Private Sub ChangeProfileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChangeProfileToolStripMenuItem.Click
        ChangeProfileForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BuddyList_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Application.Exit()
    End Sub

    Private Sub BuddyList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim xw As New System.Xml.XmlTextWriter("BuddyList.xml", Nothing)
        xw.Formatting = Xml.Formatting.Indented
        xw.WriteStartDocument(False)

        xw.WriteStartElement("buddies")

        Dim groupNames = buddies.Keys
        Dim groupName As String
        For Each groupName In groupNames

            xw.WriteStartElement("group")
            xw.WriteAttributeString("name", groupName)

            Dim group As Dictionary(Of String, Buddy)
            group = buddies.Item(groupName)

            Dim sns = group.Keys
            Dim sn As String
            For Each sn In sns
                Dim buddy As Buddy = group.Item(sn)

                xw.WriteStartElement("buddy")
                xw.WriteAttributeString("sn", buddy.Screenname)
                xw.WriteAttributeString("alias", buddy.NameAlias)
                xw.WriteAttributeString("status", buddy.Status)
                xw.WriteElementString("statusMessage", buddy.Message)
                xw.WriteElementString("info", buddy.Info)

                ' end buddy
                xw.WriteEndElement()

            Next


            'end group
            xw.WriteEndElement()

        Next

        ' end buddy
        xw.WriteEndElement()

        xw.Flush()
        xw.Close()


    End Sub

    Public Function GetGroups()
        Return buddies.Keys
    End Function

    Private Sub AddBuddyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBuddyToolStripMenuItem.Click
        AddBuddy.ShowDialog()
    End Sub

    Public Sub AddNewBuddy(ByVal group As String, ByVal buddy As Buddy)
        Dim groupBuddies As Dictionary(Of String, Buddy)
        If buddies.ContainsKey(group) Then
            groupBuddies = buddies.Item(group)
            groupBuddies.Add(buddy.Screenname, buddy)
        Else
            groupBuddies = New Dictionary(Of String, Buddy)
            groupBuddies.Add(buddy.Screenname, buddy)
            buddies.Add(group, groupBuddies)
        End If
        UpdateBuddyList()
    End Sub

    Private Sub RemoveBuddyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBuddyToolStripMenuItem.Click, RemoveBuddyToolStripMenuItem1.Click
        Dim node As TreeNode = TreeView1.SelectedNode
        If node IsNot Nothing Then
            If node.Level = 1 Then
                RemoveConfirmation.RichTextBox1.Text = "Are you sure you want to remove " & node.Text & " from the buddy list?"
                RemoveConfirmation.ShowDialog()
                If RemoveConfirmation.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    RemoveBuddyFromList(node)
                End If
            End If
        End If
    End Sub

    Private Sub RemoveBuddyFromList(ByVal node As TreeNode)
        buddies.Item(node.Parent.Text).Remove(node.Name)
        If buddies.Item(node.Parent.Text).Count = 0 Then
            buddies.Remove(node.Parent.Name)
        End If
        UpdateBuddyList()
    End Sub

    Private Sub ChangeAlias(ByVal node As TreeNode)
        buddies.Item(node.Parent.Text).Item(node.Name).NameAlias = TempName
        UpdateBuddyList()
    End Sub


    Private Sub ChangeAliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAliasToolStripMenuItem.Click, ChangeAliasToolStripMenuItem1.Click
        Dim node As TreeNode = TreeView1.SelectedNode
        If node IsNot Nothing Then
            If node.Level = 1 Then
                Dim ca As New ChangeAliasDialog
                ca.TextBox1.Text = node.Text
                ca.ShowDialog()
                If ca.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    ChangeAlias(node)
                End If
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomIMTimer.Tick
        ' a random buddy from the buddy list randomly sends an IM periodically

        Dim gb As KeyValuePair(Of String, Buddy) = GetRandomBuddy()
        Dim b As Buddy = gb.Value
        Dim g As String = gb.Key

        ' check if buddy is available
        If b.Status.CompareTo("available") = 0 Then

            ' open new window
            Dim window As ChatWindow = OpenChatWindow(b.Screenname, b.NameAlias, g)

            ' buddy send message
            window.BuddySendMessage()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomStatusChangeTimer.Tick
        ' a random buddy from the buddy list changes status randomly

        Dim gb As KeyValuePair(Of String, Buddy) = GetRandomBuddy()
        Dim b As Buddy = gb.Value
        Dim g As String = gb.Key

        Dim num = Int(3 * Rnd())
        Select Case num
            Case 0
                b.Status = "available"
            Case 1
                b.Status = "away"
            Case Else
                b.Status = "offline"
        End Select
        UpdateBuddyList()

        If chatWindows.ContainsKey(b.Screenname) Then
            Dim chat As ChatWindow = chatWindows.Item(b.Screenname)
            chat.PrintAlert(b.NameAlias & " is now " & b.Status)
        End If
    End Sub

    Private Function GetRandomBuddy() As KeyValuePair(Of String, Buddy)
        ' get random group
        Dim groupIndex = Int(buddies.Count * Rnd())
        Dim i As Integer = 0
        Dim groupKey As KeyValuePair(Of String, Dictionary(Of String, Buddy)) = Nothing
        For Each groupKey In buddies
            If i = groupIndex Then
                Exit For
            End If
            i += 1
        Next

        ' get random buddy
        Dim buddyIndex = Int(groupKey.Value.Count * Rnd())
        i = 0
        Dim buddyKey As KeyValuePair(Of String, Buddy) = Nothing
        For Each buddyKey In groupKey.Value
            If i = buddyIndex Then
                Exit For
            End If
            i += 1
        Next
        Dim b As Buddy = buddies.Item(groupKey.Key).Item(buddyKey.Key)
        Dim g As String = groupKey.Key

        Return New KeyValuePair(Of String, Buddy)(g, b)
    End Function


    Private Sub ViewProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProfileToolStripMenuItem.Click, ViewProfileToolStripMenuItem1.Click
        Dim node As TreeNode = TreeView1.SelectedNode
        If node IsNot Nothing Then
            If node.Level = 1 Then
                Dim b = buddies.Item(node.Parent.Text).Item(node.Name)
                Dim profile As New ViewProfileForm
                profile.SetBuddy(b)
                profile.Show()
            End If
        End If

    End Sub

    Private Sub ChangeProfileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeProfileToolStripMenuItem1.Click
        ChangeProfileForm.Show()
    End Sub

    Public Function ContainsBuddy(ByVal sn As String) As Boolean
        ' checks if a buddy is in the dictionary given a screenname
        Dim group As String
        For Each group In buddies.Keys
            If buddies.Item(group).ContainsKey(sn) Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Function GetBuddyNode(ByVal sn As String) As TreeNode
        ' gets a buddy tree node from the treeview if you only have a screenname
        If ContainsBuddy(sn) Then
            Dim groupNode As TreeNode
            For Each groupNode In TreeView1.Nodes
                Dim buddyNode As TreeNode
                For Each buddyNode In groupNode.Nodes
                    If buddyNode.Name.CompareTo(sn) = 0 Then
                        Return buddyNode
                    End If
                Next

            Next
        End If
        Return Nothing
    End Function

    Private Sub NewInstantMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInstantMessageToolStripMenuItem.Click
        If NewIM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If ContainsBuddy(_tempName) Then
                Dim node As TreeNode = GetBuddyNode(_tempName)
                OpenChatWindow(node.Name, node.Text, node.Parent.Text)
            Else
                OpenChatWindow(_tempName)
            End If

        End If
    End Sub

    Private Sub FacebookTestTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacebookTestTimer.Tick
        FacebookTestTimer.Enabled = False
        Dim sn As String = "Space4Ever"
        Dim chat As ChatWindow = OpenChatWindow(sn)
        chat.BuddySendMessage()
    End Sub

    'Private Sub BuddyList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    TimerControl.Show()
    'End Sub
End Class

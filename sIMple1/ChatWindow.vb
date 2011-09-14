Public Class ChatWindow
    Dim buddy As Buddy
    Dim self As String
    Dim responses As ArrayList
    Dim selfIndex As Integer
    Dim first As Boolean
    Dim queue As Integer

    Public Sub New(ByVal b As Buddy)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        buddy = b
    End Sub

    Public Sub New(ByVal sn As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        buddy = New Buddy(sn, sn, "available", "", "")
    End Sub


    Private Sub ChatWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()
        first = True
        Me.Text = buddy.NameAlias
        queue = 0
        self = BuddyList.Myself.NameAlias
        RadioButton1.Checked = True
    End Sub


    Private Sub SelfSendMessage(ByVal message As String)

        SyncLock Output
            'play sound
            Dim send As New System.Media.SoundPlayer
            send.SoundLocation = "send.wav"
            send.Load()
            send.Play()
            Dim align As HorizontalAlignment
            align = HorizontalAlignment.Left
            If Output.Text <> "" Then
                Output.AppendText(vbNewLine & vbNewLine)
            End If

            ' print smilie
            InsertImageIntoRtb(WhiteSmilies.Images.Item(selfIndex))

            ' print user
            With Output
                .SelectionColor = Color.Blue
                .SelectionFont = New Font(.SelectionFont, FontStyle.Bold)
                .SelectionAlignment = align
            End With
            Output.AppendText(" " & self & " ")

            ' print message
            With Output
                .SelectionColor = Color.Black
                .SelectionFont = New Font(.SelectionFont, FontStyle.Regular)
            End With
            Output.AppendText(message)
        End SyncLock
    End Sub


    Public Sub BuddySendMessage()
        SyncLock Output
            If buddy.Status.CompareTo("available") = 0 Then
                ' play the sound
                Dim receive As New System.Media.SoundPlayer
                receive.SoundLocation = "receive.wav"
                receive.Load()
                receive.Play()

                ' print the message
                Dim userColor As Color
                Dim align As HorizontalAlignment
                userColor = Color.Red
                align = HorizontalAlignment.Right
                If Output.Text() <> "" Then
                    Output.AppendText(vbNewLine & vbNewLine)
                End If
                Output.SelectionColor = Color.Black
                Output.SelectionFont = New Font(Output.SelectionFont(), FontStyle.Regular)
                Output.SelectionAlignment = align
                Output.AppendText(BuddyList.GetResponse())

                ' print the buddy alias
                Output.SelectionColor = userColor
                Output.SelectionFont = New Font(Output.SelectionFont(), FontStyle.Bold)
                Output.AppendText(" ")
                Output.AppendText(buddy.NameAlias)
                Output.AppendText(" ")

                ' print an emoticon
                Dim buddyIndex As Integer = Int(6 * Rnd() + 1)
                InsertImageIntoRtb(WhiteSmilies.Images.Item(buddyIndex))
            End If

        End SyncLock
    End Sub



    Public Sub PrintAlert(ByVal alert As String)
        SyncLock Output
            Output.SelectionAlignment = HorizontalAlignment.Left
            Output.SelectionFont = New Font(Output.SelectionFont(), FontStyle.Italic)
            If Output.Text() <> "" Then
                Output.AppendText(vbNewLine & vbNewLine)
            End If
            Output.AppendText(alert)
            Output.SelectionFont = New Font(Output.SelectionFont(), FontStyle.Regular)
        End SyncLock
    End Sub



    Private Sub Input_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Input.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then

            ' self sends message
            SelfSendMessage(Input.Text)

            Input.Text = ""
            e.Handled = True
            Output.Update()
            Input.Update()


            ' user sends message back
            Select Case buddy.Status
                Case "available"

                    queue += 1

                Case "away"
                    If first Then
                        If buddy.Message <> "" Then
                            Output.AppendText(vbNewLine & buddy.NameAlias & "'s Away Message: " & buddy.Message)
                        Else
                            Output.AppendText(vbNewLine & buddy.NameAlias & " is Away")
                        End If
                        first = False
                    End If
                Case "offline"
                    If first Then
                        MessageBox.Show(buddy.NameAlias & " is offline. " & buddy.NameAlias & " will receive message when " & buddy.NameAlias & " comes back online.")
                    End If
                    first = False
            End Select
            Output.Update()
        End If
    End Sub


    Private Sub Output_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Output.TextChanged
        If Input.Focused Then
            SyncLock Me
                Output.SelectionStart = Output.TextLength
                Output.Focus()
                Input.Focus()
            End SyncLock
        End If

    End Sub

    Private Sub ChatWindow_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        BuddyList.DeleteChatWindowKey(buddy.Screenname)
    End Sub

    Sub InsertImageIntoRtb(ByVal img As Image)
        Clipboard.SetDataObject(img)

        Output.ReadOnly = False
        Output.Paste()
        Output.ReadOnly = True
    End Sub


    Sub FaceBackground(ByVal rb As RadioButton, ByVal num As Integer)
        If rb.Checked Then
            selfIndex = num
            rb.ImageList = Down
        Else
            rb.ImageList = Up
        End If
        Input.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        FaceBackground(RadioButton1, 1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        FaceBackground(RadioButton2, 2)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        FaceBackground(RadioButton3, 3)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        FaceBackground(RadioButton4, 4)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        FaceBackground(RadioButton5, 5)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        FaceBackground(RadioButton6, 6)
    End Sub


    Public Sub UpdateOutput()
        Output.SelectionStart = Output.TextLength
        Output.Focus()
        Input.Focus()
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FacebookToolStripMenuItem.Click
        Dim IE As Object
        IE = CreateObject("InternetExplorer.Application")
        With IE
            .Navigate2("http://www.facebook.com/s.php?q=" & buddy.Screenname)
            .Visible = True
        End With
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProfileToolStripMenuItem.Click
        Dim profile As New ViewProfileForm
        profile.SetBuddy(buddy)
        profile.Show()
    End Sub

    Private Sub NotImplemented(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click, AliasToolStripMenuItem.Click, BlockToolStripMenuItem.Click, InsertImageToolStripMenuItem1.Click, InsertLinkToolStripMenuItem1.Click
        MessageBox.Show("Not implemented")
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoReplyTimer.Tick
        If queue > 0 Then

            If Int(6 * Rnd()) <> 5 Then
                BuddySendMessage()
            End If
            queue -= 1
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        Output.Text = ""
    End Sub

    Private Sub AddToBuddyListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToBuddyListToolStripMenuItem.Click

        If BuddyList.ContainsBuddy(buddy.Screenname) Then
            MessageBox.Show(buddy.NameAlias & " is already in the buddy list")
        Else
            Dim ab As New AddBuddy
            ab.TextBox1.Text = buddy.Screenname
            ab.TextBox2.Text = buddy.NameAlias
            ab.ShowDialog()
            
        End If
    End Sub
End Class

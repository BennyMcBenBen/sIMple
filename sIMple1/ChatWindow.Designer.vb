<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BuddyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertLinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertImageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConversationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToBuddyListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AliasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Output = New System.Windows.Forms.RichTextBox
        Me.Input = New System.Windows.Forms.RichTextBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.Up = New System.Windows.Forms.ImageList(Me.components)
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.AutoReplyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WhiteSmilies = New System.Windows.Forms.ImageList(Me.components)
        Me.Down = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuddyToolStripMenuItem, Me.ConversationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuddyToolStripMenuItem
        '
        Me.BuddyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertLinkToolStripMenuItem1, Me.InsertImageToolStripMenuItem1, Me.ClearToolStripMenuItem1, Me.CloseToolStripMenuItem1})
        Me.BuddyToolStripMenuItem.Name = "BuddyToolStripMenuItem"
        Me.BuddyToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.BuddyToolStripMenuItem.Text = "Chat Window"
        '
        'InsertLinkToolStripMenuItem1
        '
        Me.InsertLinkToolStripMenuItem1.Name = "InsertLinkToolStripMenuItem1"
        Me.InsertLinkToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.InsertLinkToolStripMenuItem1.Text = "Insert Link"
        '
        'InsertImageToolStripMenuItem1
        '
        Me.InsertImageToolStripMenuItem1.Name = "InsertImageToolStripMenuItem1"
        Me.InsertImageToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.InsertImageToolStripMenuItem1.Text = "Insert Image"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.CloseToolStripMenuItem1.Text = "Close"
        '
        'ConversationToolStripMenuItem
        '
        Me.ConversationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.AddToBuddyListToolStripMenuItem, Me.FacebookToolStripMenuItem, Me.AliasToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.BlockToolStripMenuItem})
        Me.ConversationToolStripMenuItem.Name = "ConversationToolStripMenuItem"
        Me.ConversationToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ConversationToolStripMenuItem.Text = "Buddy"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'AddToBuddyListToolStripMenuItem
        '
        Me.AddToBuddyListToolStripMenuItem.Name = "AddToBuddyListToolStripMenuItem"
        Me.AddToBuddyListToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AddToBuddyListToolStripMenuItem.Text = "Add To Buddy List"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.FacebookToolStripMenuItem.Text = "Search for Buddy on Facebook"
        '
        'AliasToolStripMenuItem
        '
        Me.AliasToolStripMenuItem.Name = "AliasToolStripMenuItem"
        Me.AliasToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AliasToolStripMenuItem.Text = "Change Alias"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove From Buddy List"
        '
        'BlockToolStripMenuItem
        '
        Me.BlockToolStripMenuItem.Name = "BlockToolStripMenuItem"
        Me.BlockToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.BlockToolStripMenuItem.Text = "Block"
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.SystemColors.Window
        Me.Output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Output.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(0, 0)
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Output.Size = New System.Drawing.Size(473, 270)
        Me.Output.TabIndex = 4
        Me.Output.Text = ""
        '
        'Input
        '
        Me.Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(0, 0)
        Me.Input.Name = "Input"
        Me.Input.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Input.Size = New System.Drawing.Size(391, 122)
        Me.Input.TabIndex = 3
        Me.Input.Text = ""
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.BackColor = System.Drawing.Color.White
        Me.RadioButton6.ImageIndex = 6
        Me.RadioButton6.ImageList = Me.Up
        Me.RadioButton6.Location = New System.Drawing.Point(42, 83)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(33, 35)
        Me.RadioButton6.TabIndex = 11
        Me.RadioButton6.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton6, "Sarcastic")
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'Up
        '
        Me.Up.ImageStream = CType(resources.GetObject("Up.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Up.TransparentColor = System.Drawing.Color.Transparent
        Me.Up.Images.SetKeyName(0, "ben_bowie2.bmp")
        Me.Up.Images.SetKeyName(1, "happy-buttonup.png")
        Me.Up.Images.SetKeyName(2, "laughing-buttonup.png")
        Me.Up.Images.SetKeyName(3, "confused-buttonup.png")
        Me.Up.Images.SetKeyName(4, "angry-buttonup.png")
        Me.Up.Images.SetKeyName(5, "sad-very-buttonup.png")
        Me.Up.Images.SetKeyName(6, "cunning-buttonup.png")
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.ImageIndex = 3
        Me.RadioButton3.ImageList = Me.Up
        Me.RadioButton3.Location = New System.Drawing.Point(3, 83)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(33, 35)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton3, "Confused")
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackColor = System.Drawing.Color.White
        Me.RadioButton5.ImageIndex = 5
        Me.RadioButton5.ImageList = Me.Up
        Me.RadioButton5.Location = New System.Drawing.Point(42, 43)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(33, 34)
        Me.RadioButton5.TabIndex = 13
        Me.RadioButton5.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton5, "Sad")
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.ImageIndex = 2
        Me.RadioButton2.ImageList = Me.Up
        Me.RadioButton2.Location = New System.Drawing.Point(3, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(33, 34)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Laughing")
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.ImageIndex = 1
        Me.RadioButton1.ImageList = Me.Up
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(33, 34)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "Happy")
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "confused_sm.png")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.BackColor = System.Drawing.Color.White
        Me.RadioButton4.ImageIndex = 4
        Me.RadioButton4.ImageList = Me.Up
        Me.RadioButton4.Location = New System.Drawing.Point(42, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(33, 34)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton4, "Angry")
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'AutoReplyTimer
        '
        Me.AutoReplyTimer.Enabled = True
        Me.AutoReplyTimer.Interval = 2000
        '
        'WhiteSmilies
        '
        Me.WhiteSmilies.ImageStream = CType(resources.GetObject("WhiteSmilies.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WhiteSmilies.TransparentColor = System.Drawing.Color.Transparent
        Me.WhiteSmilies.Images.SetKeyName(0, "ben_bowie2.bmp")
        Me.WhiteSmilies.Images.SetKeyName(1, "happy2.png")
        Me.WhiteSmilies.Images.SetKeyName(2, "laughing2.png")
        Me.WhiteSmilies.Images.SetKeyName(3, "confused.png")
        Me.WhiteSmilies.Images.SetKeyName(4, "angry.png")
        Me.WhiteSmilies.Images.SetKeyName(5, "sad-very.png")
        Me.WhiteSmilies.Images.SetKeyName(6, "cunning.png")
        '
        'Down
        '
        Me.Down.ImageStream = CType(resources.GetObject("Down.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Down.TransparentColor = System.Drawing.Color.Transparent
        Me.Down.Images.SetKeyName(0, "ben_bowie2.bmp")
        Me.Down.Images.SetKeyName(1, "happy-buttondown.png")
        Me.Down.Images.SetKeyName(2, "laughing-buttondown.png")
        Me.Down.Images.SetKeyName(3, "confused-buttondown.png")
        Me.Down.Images.SetKeyName(4, "angry-buttondown.png")
        Me.Down.Images.SetKeyName(5, "sad-very-buttondown.png")
        Me.Down.Images.SetKeyName(6, "cunning-buttondown.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Output)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(473, 396)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 18
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Input)
        Me.SplitContainer2.Size = New System.Drawing.Size(473, 122)
        Me.SplitContainer2.SplitterDistance = 78
        Me.SplitContainer2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton6, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton5, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(78, 122)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ChatWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 420)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(481, 454)
        Me.Name = "ChatWindow"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConversationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AliasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Output As System.Windows.Forms.RichTextBox
    Friend WithEvents Input As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents FacebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoReplyTimer As System.Windows.Forms.Timer
    Friend WithEvents WhiteSmilies As System.Windows.Forms.ImageList
    Friend WithEvents Up As System.Windows.Forms.ImageList
    Friend WithEvents Down As System.Windows.Forms.ImageList
    Friend WithEvents AddToBuddyListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BuddyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertLinkToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertImageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class

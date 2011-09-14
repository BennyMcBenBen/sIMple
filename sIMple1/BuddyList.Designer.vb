<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuddyList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuddyList))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BuddiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewInstantMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBuddyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeAliasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveBuddyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.AwayCheckBox = New System.Windows.Forms.CheckBox
        Me.AvailableCheckBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OfflineCheckBox = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeAliasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveBuddyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RandomIMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomStatusChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FacebookTestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuddiesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(243, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuddiesToolStripMenuItem
        '
        Me.BuddiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInstantMessageToolStripMenuItem, Me.ViewProfileToolStripMenuItem, Me.AddBuddyToolStripMenuItem, Me.ChangeAliasToolStripMenuItem, Me.RemoveBuddyToolStripMenuItem})
        Me.BuddiesToolStripMenuItem.Name = "BuddiesToolStripMenuItem"
        Me.BuddiesToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.BuddiesToolStripMenuItem.Text = "Buddies"
        '
        'NewInstantMessageToolStripMenuItem
        '
        Me.NewInstantMessageToolStripMenuItem.Name = "NewInstantMessageToolStripMenuItem"
        Me.NewInstantMessageToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NewInstantMessageToolStripMenuItem.Text = "New Instant Message"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'AddBuddyToolStripMenuItem
        '
        Me.AddBuddyToolStripMenuItem.Image = CType(resources.GetObject("AddBuddyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddBuddyToolStripMenuItem.Name = "AddBuddyToolStripMenuItem"
        Me.AddBuddyToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddBuddyToolStripMenuItem.Text = "Add Buddy"
        '
        'ChangeAliasToolStripMenuItem
        '
        Me.ChangeAliasToolStripMenuItem.Name = "ChangeAliasToolStripMenuItem"
        Me.ChangeAliasToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ChangeAliasToolStripMenuItem.Text = "Change Alias"
        '
        'RemoveBuddyToolStripMenuItem
        '
        Me.RemoveBuddyToolStripMenuItem.Image = CType(resources.GetObject("RemoveBuddyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveBuddyToolStripMenuItem.Name = "RemoveBuddyToolStripMenuItem"
        Me.RemoveBuddyToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RemoveBuddyToolStripMenuItem.Text = "Remove Buddy"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeProfileToolStripMenuItem1})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ChangeProfileToolStripMenuItem1
        '
        Me.ChangeProfileToolStripMenuItem1.Name = "ChangeProfileToolStripMenuItem1"
        Me.ChangeProfileToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ChangeProfileToolStripMenuItem1.Text = "Change Profile"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeProfileToolStripMenuItem, Me.ChangeStatusToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 70)
        '
        'ChangeProfileToolStripMenuItem
        '
        Me.ChangeProfileToolStripMenuItem.Name = "ChangeProfileToolStripMenuItem"
        Me.ChangeProfileToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ChangeProfileToolStripMenuItem.Text = "Change Profile"
        '
        'ChangeStatusToolStripMenuItem
        '
        Me.ChangeStatusToolStripMenuItem.Name = "ChangeStatusToolStripMenuItem"
        Me.ChangeStatusToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ChangeStatusToolStripMenuItem.Text = "Change Status"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "sIMple"
        '
        'StatusImages
        '
        Me.StatusImages.ImageStream = CType(resources.GetObject("StatusImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StatusImages.TransparentColor = System.Drawing.Color.Transparent
        Me.StatusImages.Images.SetKeyName(0, "group.bmp")
        Me.StatusImages.Images.SetKeyName(1, "available.png")
        Me.StatusImages.Images.SetKeyName(2, "away.png")
        Me.StatusImages.Images.SetKeyName(3, "offline.png")
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Change Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Detail View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(3, 28)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(237, 526)
        Me.TreeView1.TabIndex = 1
        '
        'AwayCheckBox
        '
        Me.AwayCheckBox.AutoSize = True
        Me.AwayCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AwayCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AwayCheckBox.Checked = True
        Me.AwayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AwayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayCheckBox.Location = New System.Drawing.Point(118, 1)
        Me.AwayCheckBox.Name = "AwayCheckBox"
        Me.AwayCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.AwayCheckBox.TabIndex = 5
        Me.AwayCheckBox.Text = "Away"
        Me.AwayCheckBox.UseVisualStyleBackColor = False
        '
        'AvailableCheckBox
        '
        Me.AvailableCheckBox.AutoSize = True
        Me.AvailableCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AvailableCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AvailableCheckBox.Checked = True
        Me.AvailableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AvailableCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableCheckBox.Location = New System.Drawing.Point(43, 1)
        Me.AvailableCheckBox.Name = "AvailableCheckBox"
        Me.AvailableCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.AvailableCheckBox.TabIndex = 4
        Me.AvailableCheckBox.Text = "Available"
        Me.AvailableCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Show"
        '
        'OfflineCheckBox
        '
        Me.OfflineCheckBox.AutoSize = True
        Me.OfflineCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OfflineCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OfflineCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfflineCheckBox.Location = New System.Drawing.Point(176, 1)
        Me.OfflineCheckBox.Name = "OfflineCheckBox"
        Me.OfflineCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.OfflineCheckBox.TabIndex = 6
        Me.OfflineCheckBox.Text = "Offline"
        Me.OfflineCheckBox.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TreeView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 587)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AvailableCheckBox)
        Me.Panel1.Controls.Add(Me.AwayCheckBox)
        Me.Panel1.Controls.Add(Me.OfflineCheckBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 19)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 560)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Size = New System.Drawing.Size(237, 24)
        Me.SplitContainer1.SplitterDistance = 117
        Me.SplitContainer1.TabIndex = 2
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem1, Me.ChangeAliasToolStripMenuItem1, Me.RemoveBuddyToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(158, 70)
        '
        'ViewProfileToolStripMenuItem1
        '
        Me.ViewProfileToolStripMenuItem1.Name = "ViewProfileToolStripMenuItem1"
        Me.ViewProfileToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ViewProfileToolStripMenuItem1.Text = "View Profile"
        '
        'ChangeAliasToolStripMenuItem1
        '
        Me.ChangeAliasToolStripMenuItem1.Name = "ChangeAliasToolStripMenuItem1"
        Me.ChangeAliasToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ChangeAliasToolStripMenuItem1.Text = "Change Alias"
        '
        'RemoveBuddyToolStripMenuItem1
        '
        Me.RemoveBuddyToolStripMenuItem1.Image = CType(resources.GetObject("RemoveBuddyToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RemoveBuddyToolStripMenuItem1.Name = "RemoveBuddyToolStripMenuItem1"
        Me.RemoveBuddyToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.RemoveBuddyToolStripMenuItem1.Text = "Remove Buddy"
        '
        'RandomIMTimer
        '
        Me.RandomIMTimer.Enabled = True
        Me.RandomIMTimer.Interval = 45000
        '
        'RandomStatusChangeTimer
        '
        Me.RandomStatusChangeTimer.Enabled = True
        Me.RandomStatusChangeTimer.Interval = 60000
        '
        'FacebookTestTimer
        '
        Me.FacebookTestTimer.Interval = 10000
        '
        'BuddyList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(251, 645)
        Me.Name = "BuddyList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buddy List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BuddiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents StatusImages As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents AwayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AvailableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OfflineCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AddBuddyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBuddyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveBuddyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeAliasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeAliasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RandomIMTimer As System.Windows.Forms.Timer
    Friend WithEvents RandomStatusChangeTimer As System.Windows.Forms.Timer
    Friend WithEvents ViewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeProfileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewInstantMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacebookTestTimer As System.Windows.Forms.Timer

End Class

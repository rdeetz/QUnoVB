<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorGameMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainStatus = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelCurrentCard = New System.Windows.Forms.Label()
        Me.labelCurrentWildColor = New System.Windows.Forms.Label()
        Me.listHumanHand = New System.Windows.Forms.ListBox()
        Me.buttonPlay = New System.Windows.Forms.Button()
        Me.buttonDraw = New System.Windows.Forms.Button()
        Me.listComputerPlayers = New System.Windows.Forms.ListBox()
        Me.labelCurrentDirection = New System.Windows.Forms.Label()
        Me.labelHumanName = New System.Windows.Forms.Label()
        Me.mainMenu.SuspendLayout()
        Me.mainStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(998, 48)
        Me.mainMenu.TabIndex = 0
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.separatorGameMenu, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(97, 44)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'separatorGameMenu
        '
        Me.separatorGameMenu.Name = "separatorGameMenu"
        Me.separatorGameMenu.Size = New System.Drawing.Size(280, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(90, 44)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(248, 44)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 44)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.AboutToolStripMenuItem.Text = "&About QUno"
        '
        'mainStatus
        '
        Me.mainStatus.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.mainStatus.Location = New System.Drawing.Point(0, 655)
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(998, 42)
        Me.mainStatus.TabIndex = 1
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(79, 32)
        Me.statusLabel.Text = "Ready"
        '
        'labelCurrentCard
        '
        Me.labelCurrentCard.AutoSize = True
        Me.labelCurrentCard.Location = New System.Drawing.Point(397, 230)
        Me.labelCurrentCard.Name = "labelCurrentCard"
        Me.labelCurrentCard.Size = New System.Drawing.Size(76, 32)
        Me.labelCurrentCard.TabIndex = 2
        Me.labelCurrentCard.Text = "{0} {1}"
        '
        'labelCurrentWildColor
        '
        Me.labelCurrentWildColor.AutoSize = True
        Me.labelCurrentWildColor.Location = New System.Drawing.Point(397, 284)
        Me.labelCurrentWildColor.Name = "labelCurrentWildColor"
        Me.labelCurrentWildColor.Size = New System.Drawing.Size(42, 32)
        Me.labelCurrentWildColor.TabIndex = 3
        Me.labelCurrentWildColor.Text = "{0}"
        '
        'listHumanHand
        '
        Me.listHumanHand.FormattingEnabled = True
        Me.listHumanHand.ItemHeight = 32
        Me.listHumanHand.Location = New System.Drawing.Point(187, 376)
        Me.listHumanHand.Name = "listHumanHand"
        Me.listHumanHand.Size = New System.Drawing.Size(302, 164)
        Me.listHumanHand.TabIndex = 4
        '
        'buttonPlay
        '
        Me.buttonPlay.Location = New System.Drawing.Point(531, 376)
        Me.buttonPlay.Name = "buttonPlay"
        Me.buttonPlay.Size = New System.Drawing.Size(75, 23)
        Me.buttonPlay.TabIndex = 5
        Me.buttonPlay.Text = "&Play"
        Me.buttonPlay.UseVisualStyleBackColor = True
        '
        'buttonDraw
        '
        Me.buttonDraw.Location = New System.Drawing.Point(531, 440)
        Me.buttonDraw.Name = "buttonDraw"
        Me.buttonDraw.Size = New System.Drawing.Size(75, 23)
        Me.buttonDraw.TabIndex = 6
        Me.buttonDraw.Text = "&Draw"
        Me.buttonDraw.UseVisualStyleBackColor = True
        '
        'listComputerPlayers
        '
        Me.listComputerPlayers.FormattingEnabled = True
        Me.listComputerPlayers.ItemHeight = 32
        Me.listComputerPlayers.Location = New System.Drawing.Point(133, 92)
        Me.listComputerPlayers.Name = "listComputerPlayers"
        Me.listComputerPlayers.Size = New System.Drawing.Size(786, 100)
        Me.listComputerPlayers.TabIndex = 7
        '
        'labelCurrentDirection
        '
        Me.labelCurrentDirection.AutoSize = True
        Me.labelCurrentDirection.Location = New System.Drawing.Point(597, 284)
        Me.labelCurrentDirection.Name = "labelCurrentDirection"
        Me.labelCurrentDirection.Size = New System.Drawing.Size(42, 32)
        Me.labelCurrentDirection.TabIndex = 8
        Me.labelCurrentDirection.Text = "{0}"
        '
        'labelHumanName
        '
        Me.labelHumanName.AutoSize = True
        Me.labelHumanName.Location = New System.Drawing.Point(419, 582)
        Me.labelHumanName.Name = "labelHumanName"
        Me.labelHumanName.Size = New System.Drawing.Size(42, 32)
        Me.labelHumanName.TabIndex = 9
        Me.labelHumanName.Text = "{0}"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 697)
        Me.Controls.Add(Me.labelHumanName)
        Me.Controls.Add(Me.listComputerPlayers)
        Me.Controls.Add(Me.buttonPlay)
        Me.Controls.Add(Me.buttonDraw)
        Me.Controls.Add(Me.listHumanHand)
        Me.Controls.Add(Me.labelCurrentCard)
        Me.Controls.Add(Me.labelCurrentWildColor)
        Me.Controls.Add(Me.labelCurrentDirection)
        Me.Controls.Add(Me.mainStatus)
        Me.Controls.Add(Me.mainMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUno"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.mainStatus.ResumeLayout(False)
        Me.mainStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents separatorGameMenu As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainStatus As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents labelCurrentCard As Label
    Friend WithEvents labelCurrentWildColor As Label
    Friend WithEvents listHumanHand As ListBox
    Friend WithEvents buttonPlay As Button
    Friend WithEvents buttonDraw As Button
    Friend WithEvents listComputerPlayers As ListBox
    Friend WithEvents labelCurrentDirection As Label
    Friend WithEvents labelHumanName As Label
End Class

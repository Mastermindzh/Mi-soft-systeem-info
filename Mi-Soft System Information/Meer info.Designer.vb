<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meer_info
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Systeem overzicht", 16, 16)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Moederbord", 10, 10)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BIOS", 1, 1)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processor", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Geheugen", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Video", 8, 8)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Netwerk adapters", 11, 11)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stations")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hardware", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Besturingssysteem", 12, 12)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Geïnstalleerde Software", 7, 7)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opstart Programma's", 17, 17)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processen", 18, 18)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Software", 15, 15, New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Netwerk", 13, 13)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Systeem Informatie", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode14, TreeNode15})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Meer_info))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FunctiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HttpmisoftnlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.SysteemAfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SysteemHerstartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 26)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Size = New System.Drawing.Size(744, 524)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = 11
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Indent = 20
        Me.TreeView1.LineColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 16
        TreeNode1.Name = "Node4"
        TreeNode1.SelectedImageIndex = 16
        TreeNode1.Text = "Systeem overzicht"
        TreeNode2.ImageIndex = 10
        TreeNode2.Name = "Node5"
        TreeNode2.SelectedImageIndex = 10
        TreeNode2.Text = "Moederbord"
        TreeNode3.ImageIndex = 1
        TreeNode3.Name = "Node6"
        TreeNode3.SelectedImageIndex = 1
        TreeNode3.Text = "BIOS"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Node7"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Processor"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Node8"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Geheugen"
        TreeNode6.ImageIndex = 8
        TreeNode6.Name = "Node9"
        TreeNode6.SelectedImageIndex = 8
        TreeNode6.Text = "Video"
        TreeNode7.ImageIndex = 11
        TreeNode7.Name = "Node0"
        TreeNode7.SelectedImageIndex = 11
        TreeNode7.Text = "Netwerk adapters"
        TreeNode8.ImageIndex = 14
        TreeNode8.Name = "Node1"
        TreeNode8.SelectedImageKey = "2525.png"
        TreeNode8.Text = "Stations"
        TreeNode9.ImageKey = "hwbrowser.png"
        TreeNode9.Name = "Node1"
        TreeNode9.SelectedImageIndex = 6
        TreeNode9.Text = "Hardware"
        TreeNode10.ImageIndex = 12
        TreeNode10.Name = "Node2"
        TreeNode10.SelectedImageIndex = 12
        TreeNode10.Text = "Besturingssysteem"
        TreeNode11.ImageIndex = 7
        TreeNode11.Name = "Node0"
        TreeNode11.SelectedImageIndex = 7
        TreeNode11.Text = "Geïnstalleerde Software"
        TreeNode12.ImageIndex = 17
        TreeNode12.Name = "Node0"
        TreeNode12.SelectedImageIndex = 17
        TreeNode12.Text = "Opstart Programma's"
        TreeNode13.ImageIndex = 18
        TreeNode13.Name = "Node0"
        TreeNode13.SelectedImageIndex = 18
        TreeNode13.Text = "Processen"
        TreeNode14.ImageIndex = 15
        TreeNode14.Name = "Node0"
        TreeNode14.SelectedImageIndex = 15
        TreeNode14.Text = "Software"
        TreeNode15.ImageIndex = 13
        TreeNode15.Name = "netwerk"
        TreeNode15.SelectedImageIndex = 13
        TreeNode15.Text = "Netwerk"
        TreeNode16.ImageIndex = 0
        TreeNode16.Name = "Node2"
        TreeNode16.SelectedImageIndex = 0
        TreeNode16.Text = "Systeem Informatie"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(240, 524)
        Me.TreeView1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "SQUARE.png")
        Me.ImageList1.Images.SetKeyName(1, "bios.png")
        Me.ImageList1.Images.SetKeyName(2, "audio_card.png")
        Me.ImageList1.Images.SetKeyName(3, "cpu.png")
        Me.ImageList1.Images.SetKeyName(4, "ram_drive.png")
        Me.ImageList1.Images.SetKeyName(5, "usbflashcardwithcardreader2.png")
        Me.ImageList1.Images.SetKeyName(6, "hwbrowser.png")
        Me.ImageList1.Images.SetKeyName(7, "software_green_1.png")
        Me.ImageList1.Images.SetKeyName(8, "display.png")
        Me.ImageList1.Images.SetKeyName(9, "my_computer.png")
        Me.ImageList1.Images.SetKeyName(10, "motherboard.png")
        Me.ImageList1.Images.SetKeyName(11, "ethernet_card_vista.png")
        Me.ImageList1.Images.SetKeyName(12, "icone_windows.png")
        Me.ImageList1.Images.SetKeyName(13, "Network_32x32.png")
        Me.ImageList1.Images.SetKeyName(14, "2525.png")
        Me.ImageList1.Images.SetKeyName(15, "2525win.png")
        Me.ImageList1.Images.SetKeyName(16, "my_computer.png")
        Me.ImageList1.Images.SetKeyName(17, "software_properties.png")
        Me.ImageList1.Images.SetKeyName(18, "settings.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctiesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FunctiesToolStripMenuItem
        '
        Me.FunctiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HttpmisoftnlToolStripMenuItem, Me.AboutToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.FunctiesToolStripMenuItem.Name = "FunctiesToolStripMenuItem"
        Me.FunctiesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FunctiesToolStripMenuItem.Text = "Functies"
        '
        'HttpmisoftnlToolStripMenuItem
        '
        Me.HttpmisoftnlToolStripMenuItem.Name = "HttpmisoftnlToolStripMenuItem"
        Me.HttpmisoftnlToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.HttpmisoftnlToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.HttpmisoftnlToolStripMenuItem.Text = "http://mi-soft.nl"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AboutToolStripMenuItem.Text = "about"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.RefreshToolStripMenuItem.Text = "refresh"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton8, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.ToolStripSplitButton1, Me.ToolStripButton7})
        Me.BindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(744, 25)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.info_square_blue
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripButton2.Text = "Compacte modus"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.camera1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Maak een screenshot"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.refresh
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.About1
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.copy
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Kopiëren"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Enabled = False
        Me.ToolStripButton4.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.SaveHH
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Opslaan"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Enabled = False
        Me.ToolStripButton5.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.printer
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Print"
        Me.ToolStripButton5.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SysteemAfsluitenToolStripMenuItem, Me.SysteemHerstartenToolStripMenuItem, Me.AfmeldenToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.shutdown1
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripSplitButton1.Text = "Afsluiten systeem"
        '
        'SysteemAfsluitenToolStripMenuItem
        '
        Me.SysteemAfsluitenToolStripMenuItem.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.exit1
        Me.SysteemAfsluitenToolStripMenuItem.Name = "SysteemAfsluitenToolStripMenuItem"
        Me.SysteemAfsluitenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SysteemAfsluitenToolStripMenuItem.Text = "Systeem Afsluiten"
        '
        'SysteemHerstartenToolStripMenuItem
        '
        Me.SysteemHerstartenToolStripMenuItem.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.reboot1
        Me.SysteemHerstartenToolStripMenuItem.Name = "SysteemHerstartenToolStripMenuItem"
        Me.SysteemHerstartenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SysteemHerstartenToolStripMenuItem.Text = "Systeem herstarten"
        '
        'AfmeldenToolStripMenuItem
        '
        Me.AfmeldenToolStripMenuItem.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.log_out_png_v2
        Me.AfmeldenToolStripMenuItem.Name = "AfmeldenToolStripMenuItem"
        Me.AfmeldenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AfmeldenToolStripMenuItem.Text = "Afmelden"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.square
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton7.Text = "mi-soft.nl"
        '
        'Meer_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 553)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Meer_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi-Soft systeem informatie"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FunctiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HttpmisoftnlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SysteemAfsluitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SysteemHerstartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AfmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class

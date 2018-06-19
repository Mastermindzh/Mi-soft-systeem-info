<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Systeem_overzicht
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Systeem_overzicht))
        Me.ListViewInfo = New System.Windows.Forms.ListView()
        Me.Item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Omschrijving = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpnieuwScannenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezoekMiSoftnlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewInfo
        '
        Me.ListViewInfo.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.Omschrijving})
        Me.ListViewInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewInfo.FullRowSelect = True
        Me.ListViewInfo.LabelWrap = False
        Me.ListViewInfo.Location = New System.Drawing.Point(0, 0)
        Me.ListViewInfo.MultiSelect = False
        Me.ListViewInfo.Name = "ListViewInfo"
        Me.ListViewInfo.Size = New System.Drawing.Size(502, 501)
        Me.ListViewInfo.SmallImageList = Me.ImageList1
        Me.ListViewInfo.TabIndex = 52
        Me.ListViewInfo.UseCompatibleStateImageBehavior = False
        Me.ListViewInfo.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 200
        '
        'Omschrijving
        '
        Me.Omschrijving.Text = "Omschrijving"
        Me.Omschrijving.Width = 350
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cpu.png")
        Me.ImageList1.Images.SetKeyName(1, "motherboard.png")
        Me.ImageList1.Images.SetKeyName(2, "ram_drive.png")
        Me.ImageList1.Images.SetKeyName(3, "GPU.png")
        Me.ImageList1.Images.SetKeyName(4, "vir_ram.png")
        Me.ImageList1.Images.SetKeyName(5, "bit_icon.jpg")
        Me.ImageList1.Images.SetKeyName(6, "icone_windows.png")
        Me.ImageList1.Images.SetKeyName(7, "chronometer.png")
        Me.ImageList1.Images.SetKeyName(8, "windows-performance-monitor-icon.png")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 24)
        Me.Panel1.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.hwbrowser
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Systeem overzicht"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListViewInfo)
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 501)
        Me.Panel2.TabIndex = 54
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpnieuwScannenToolStripMenuItem, Me.ToolStripSeparator2, Me.KopierenToolStripMenuItem, Me.InfoToolStripMenuItem, Me.ToolStripSeparator1, Me.AfsluitenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 104)
        '
        'OpnieuwScannenToolStripMenuItem
        '
        Me.OpnieuwScannenToolStripMenuItem.Name = "OpnieuwScannenToolStripMenuItem"
        Me.OpnieuwScannenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.OpnieuwScannenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.OpnieuwScannenToolStripMenuItem.Text = "Opnieuw scannen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BezoekMiSoftnlToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'BezoekMiSoftnlToolStripMenuItem
        '
        Me.BezoekMiSoftnlToolStripMenuItem.Name = "BezoekMiSoftnlToolStripMenuItem"
        Me.BezoekMiSoftnlToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.BezoekMiSoftnlToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BezoekMiSoftnlToolStripMenuItem.Text = "Bezoek Mi-Soft.nl"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AfsluitenToolStripMenuItem.Text = "Afsluiten"
        '
        'BackgroundWorker1
        '
        '
        'Systeem_overzicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Systeem_overzicht"
        Me.Size = New System.Drawing.Size(509, 524)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ListViewInfo As System.Windows.Forms.ListView
    Private WithEvents Item As System.Windows.Forms.ColumnHeader
    Friend WithEvents Omschrijving As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpnieuwScannenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AfsluitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezoekMiSoftnlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class

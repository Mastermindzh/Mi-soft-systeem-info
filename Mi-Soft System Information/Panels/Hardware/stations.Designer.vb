<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stations))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewDrives = New System.Windows.Forms.ListView()
        Me.PhysDrive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InterfaceType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Capacity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModelNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListDrives = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewVolumes = New System.Windows.Forms.ListView()
        Me.Drive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VolumeLabel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileSystem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UsedSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FreeSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PercentFree = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListViewDrives)
        Me.Panel2.Controls.Add(Me.ListViewVolumes)
        Me.Panel2.Location = New System.Drawing.Point(-1, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 501)
        Me.Panel2.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Fysieke stations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Volumes"
        '
        'ListViewDrives
        '
        Me.ListViewDrives.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewDrives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PhysDrive, Me.InterfaceType, Me.Capacity, Me.ModelNumber})
        Me.ListViewDrives.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDrives.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewDrives.FullRowSelect = True
        Me.ListViewDrives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewDrives.Location = New System.Drawing.Point(1, 28)
        Me.ListViewDrives.Name = "ListViewDrives"
        Me.ListViewDrives.ShowGroups = False
        Me.ListViewDrives.Size = New System.Drawing.Size(500, 181)
        Me.ListViewDrives.SmallImageList = Me.ImageListDrives
        Me.ListViewDrives.TabIndex = 21
        Me.ListViewDrives.UseCompatibleStateImageBehavior = False
        Me.ListViewDrives.View = System.Windows.Forms.View.Details
        '
        'PhysDrive
        '
        Me.PhysDrive.Text = "Station"
        Me.PhysDrive.Width = 120
        '
        'InterfaceType
        '
        Me.InterfaceType.Text = "Type"
        Me.InterfaceType.Width = 80
        '
        'Capacity
        '
        Me.Capacity.Text = "Groote"
        Me.Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Capacity.Width = 72
        '
        'ModelNumber
        '
        Me.ModelNumber.Text = "Model"
        Me.ModelNumber.Width = 213
        '
        'ImageListDrives
        '
        Me.ImageListDrives.ImageStream = CType(resources.GetObject("ImageListDrives.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListDrives.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListDrives.Images.SetKeyName(0, "SaveHH.png")
        Me.ImageListDrives.Images.SetKeyName(1, "internal_drive_open.png")
        Me.ImageListDrives.Images.SetKeyName(2, "network_drive.png")
        Me.ImageListDrives.Images.SetKeyName(3, "cdrom.png")
        Me.ImageListDrives.Images.SetKeyName(4, "drive_harddisk_usb.png")
        '
        'ListViewVolumes
        '
        Me.ListViewVolumes.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewVolumes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewVolumes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Drive, Me.VolumeLabel, Me.FileSystem, Me.TotalSize, Me.UsedSpace, Me.FreeSpace, Me.PercentFree})
        Me.ListViewVolumes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewVolumes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewVolumes.FullRowSelect = True
        Me.ListViewVolumes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewVolumes.Location = New System.Drawing.Point(1, 237)
        Me.ListViewVolumes.MultiSelect = False
        Me.ListViewVolumes.Name = "ListViewVolumes"
        Me.ListViewVolumes.ShowGroups = False
        Me.ListViewVolumes.Size = New System.Drawing.Size(500, 261)
        Me.ListViewVolumes.SmallImageList = Me.ImageListDrives
        Me.ListViewVolumes.TabIndex = 20
        Me.ListViewVolumes.UseCompatibleStateImageBehavior = False
        Me.ListViewVolumes.View = System.Windows.Forms.View.Details
        '
        'Drive
        '
        Me.Drive.Text = "Station"
        Me.Drive.Width = 59
        '
        'VolumeLabel
        '
        Me.VolumeLabel.Text = "Naam"
        Me.VolumeLabel.Width = 98
        '
        'FileSystem
        '
        Me.FileSystem.Text = "Formaat"
        Me.FileSystem.Width = 77
        '
        'TotalSize
        '
        Me.TotalSize.Text = "Grootte"
        Me.TotalSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalSize.Width = 69
        '
        'UsedSpace
        '
        Me.UsedSpace.Text = "Gebruikt"
        Me.UsedSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UsedSpace.Width = 72
        '
        'FreeSpace
        '
        Me.FreeSpace.Text = "Vrij"
        Me.FreeSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FreeSpace.Width = 70
        '
        'PercentFree
        '
        Me.PercentFree.Text = "% Vrij"
        Me.PercentFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercentFree.Width = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.hard_drive_programs_linux_2
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
        Me.Label1.Location = New System.Drawing.Point(23, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Stations"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 24)
        Me.Panel1.TabIndex = 62
        '
        'stations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "stations"
        Me.Size = New System.Drawing.Size(509, 524)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents ListViewDrives As System.Windows.Forms.ListView
    Private WithEvents PhysDrive As System.Windows.Forms.ColumnHeader
    Friend WithEvents InterfaceType As System.Windows.Forms.ColumnHeader
    Private WithEvents Capacity As System.Windows.Forms.ColumnHeader
    Private WithEvents ModelNumber As System.Windows.Forms.ColumnHeader
    Private WithEvents ListViewVolumes As System.Windows.Forms.ListView
    Private WithEvents Drive As System.Windows.Forms.ColumnHeader
    Private WithEvents VolumeLabel As System.Windows.Forms.ColumnHeader
    Private WithEvents FileSystem As System.Windows.Forms.ColumnHeader
    Private WithEvents TotalSize As System.Windows.Forms.ColumnHeader
    Private WithEvents UsedSpace As System.Windows.Forms.ColumnHeader
    Private WithEvents FreeSpace As System.Windows.Forms.ColumnHeader
    Private WithEvents PercentFree As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageListDrives As System.Windows.Forms.ImageList

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installedsoftware
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(installedsoftware))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabelHelpLink = New System.Windows.Forms.LinkLabel()
        Me.LabelDisplayName = New System.Windows.Forms.Label()
        Me.LabelDisplayVersion = New System.Windows.Forms.Label()
        Me.LabelDisplayVersionDesc = New System.Windows.Forms.Label()
        Me.PictureBoxProgram = New System.Windows.Forms.PictureBox()
        Me.labelNumberPrograms = New System.Windows.Forms.Label()
        Me.LabelEstimatedSize = New System.Windows.Forms.Label()
        Me.LabelEstSizeDesc = New System.Windows.Forms.Label()
        Me.LabelHelpTelephoneDesc = New System.Windows.Forms.Label()
        Me.LabelHelpLinkDesc = New System.Windows.Forms.Label()
        Me.LabelInstallDateDesc = New System.Windows.Forms.Label()
        Me.LabelHelpTelephone = New System.Windows.Forms.Label()
        Me.LabelInstallDate = New System.Windows.Forms.Label()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.ListViewPrograms = New System.Windows.Forms.ListView()
        Me.DisplayName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Publisher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DisplayVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HelpLink = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstimatedSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IconIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabelHelpLink)
        Me.Panel2.Controls.Add(Me.LabelDisplayName)
        Me.Panel2.Controls.Add(Me.LabelDisplayVersion)
        Me.Panel2.Controls.Add(Me.LabelDisplayVersionDesc)
        Me.Panel2.Controls.Add(Me.PictureBoxProgram)
        Me.Panel2.Controls.Add(Me.labelNumberPrograms)
        Me.Panel2.Controls.Add(Me.LabelEstimatedSize)
        Me.Panel2.Controls.Add(Me.LabelEstSizeDesc)
        Me.Panel2.Controls.Add(Me.LabelHelpTelephoneDesc)
        Me.Panel2.Controls.Add(Me.LabelHelpLinkDesc)
        Me.Panel2.Controls.Add(Me.LabelInstallDateDesc)
        Me.Panel2.Controls.Add(Me.LabelHelpTelephone)
        Me.Panel2.Controls.Add(Me.LabelInstallDate)
        Me.Panel2.Controls.Add(Me.LabelDetails)
        Me.Panel2.Controls.Add(Me.ListViewPrograms)
        Me.Panel2.Location = New System.Drawing.Point(-1, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 501)
        Me.Panel2.TabIndex = 65
        '
        'LinkLabelHelpLink
        '
        Me.LinkLabelHelpLink.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelHelpLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabelHelpLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabelHelpLink.Location = New System.Drawing.Point(127, 481)
        Me.LinkLabelHelpLink.Name = "LinkLabelHelpLink"
        Me.LinkLabelHelpLink.Size = New System.Drawing.Size(343, 15)
        Me.LinkLabelHelpLink.TabIndex = 115
        '
        'LabelDisplayName
        '
        Me.LabelDisplayName.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayName.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayName.Location = New System.Drawing.Point(64, 425)
        Me.LabelDisplayName.Name = "LabelDisplayName"
        Me.LabelDisplayName.Size = New System.Drawing.Size(248, 15)
        Me.LabelDisplayName.TabIndex = 114
        '
        'LabelDisplayVersion
        '
        Me.LabelDisplayVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayVersion.Location = New System.Drawing.Point(127, 444)
        Me.LabelDisplayVersion.Name = "LabelDisplayVersion"
        Me.LabelDisplayVersion.Size = New System.Drawing.Size(115, 15)
        Me.LabelDisplayVersion.TabIndex = 113
        Me.LabelDisplayVersion.Visible = False
        '
        'LabelDisplayVersionDesc
        '
        Me.LabelDisplayVersionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayVersionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayVersionDesc.Location = New System.Drawing.Point(51, 444)
        Me.LabelDisplayVersionDesc.Name = "LabelDisplayVersionDesc"
        Me.LabelDisplayVersionDesc.Size = New System.Drawing.Size(52, 15)
        Me.LabelDisplayVersionDesc.TabIndex = 112
        Me.LabelDisplayVersionDesc.Text = "Versie:"
        Me.LabelDisplayVersionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelDisplayVersionDesc.Visible = False
        '
        'PictureBoxProgram
        '
        Me.PictureBoxProgram.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxProgram.Location = New System.Drawing.Point(7, 427)
        Me.PictureBoxProgram.Name = "PictureBoxProgram"
        Me.PictureBoxProgram.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxProgram.TabIndex = 111
        Me.PictureBoxProgram.TabStop = False
        '
        'labelNumberPrograms
        '
        Me.labelNumberPrograms.BackColor = System.Drawing.Color.Transparent
        Me.labelNumberPrograms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumberPrograms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelNumberPrograms.Location = New System.Drawing.Point(382, 404)
        Me.labelNumberPrograms.Name = "labelNumberPrograms"
        Me.labelNumberPrograms.Size = New System.Drawing.Size(104, 17)
        Me.labelNumberPrograms.TabIndex = 110
        Me.labelNumberPrograms.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEstimatedSize
        '
        Me.LabelEstimatedSize.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstimatedSize.ForeColor = System.Drawing.Color.Black
        Me.LabelEstimatedSize.Location = New System.Drawing.Point(127, 462)
        Me.LabelEstimatedSize.Name = "LabelEstimatedSize"
        Me.LabelEstimatedSize.Size = New System.Drawing.Size(115, 15)
        Me.LabelEstimatedSize.TabIndex = 109
        Me.LabelEstimatedSize.Visible = False
        '
        'LabelEstSizeDesc
        '
        Me.LabelEstSizeDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstSizeDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelEstSizeDesc.Location = New System.Drawing.Point(18, 462)
        Me.LabelEstSizeDesc.Name = "LabelEstSizeDesc"
        Me.LabelEstSizeDesc.Size = New System.Drawing.Size(92, 15)
        Me.LabelEstSizeDesc.TabIndex = 108
        Me.LabelEstSizeDesc.Text = "Grootte:"
        Me.LabelEstSizeDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelEstSizeDesc.Visible = False
        '
        'LabelHelpTelephoneDesc
        '
        Me.LabelHelpTelephoneDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpTelephoneDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpTelephoneDesc.Location = New System.Drawing.Point(410, 475)
        Me.LabelHelpTelephoneDesc.Name = "LabelHelpTelephoneDesc"
        Me.LabelHelpTelephoneDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelHelpTelephoneDesc.TabIndex = 107
        Me.LabelHelpTelephoneDesc.Text = "Help Phone:"
        Me.LabelHelpTelephoneDesc.Visible = False
        '
        'LabelHelpLinkDesc
        '
        Me.LabelHelpLinkDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpLinkDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpLinkDesc.Location = New System.Drawing.Point(64, 481)
        Me.LabelHelpLinkDesc.Name = "LabelHelpLinkDesc"
        Me.LabelHelpLinkDesc.Size = New System.Drawing.Size(39, 15)
        Me.LabelHelpLinkDesc.TabIndex = 106
        Me.LabelHelpLinkDesc.Text = "Link:"
        Me.LabelHelpLinkDesc.Visible = False
        '
        'LabelInstallDateDesc
        '
        Me.LabelInstallDateDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstallDateDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallDateDesc.Location = New System.Drawing.Point(410, 450)
        Me.LabelInstallDateDesc.Name = "LabelInstallDateDesc"
        Me.LabelInstallDateDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelInstallDateDesc.TabIndex = 105
        Me.LabelInstallDateDesc.Text = "Install Date:"
        Me.LabelInstallDateDesc.Visible = False
        '
        'LabelHelpTelephone
        '
        Me.LabelHelpTelephone.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpTelephone.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpTelephone.Location = New System.Drawing.Point(372, 475)
        Me.LabelHelpTelephone.Name = "LabelHelpTelephone"
        Me.LabelHelpTelephone.Size = New System.Drawing.Size(343, 15)
        Me.LabelHelpTelephone.TabIndex = 104
        Me.LabelHelpTelephone.Visible = False
        '
        'LabelInstallDate
        '
        Me.LabelInstallDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstallDate.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallDate.Location = New System.Drawing.Point(359, 450)
        Me.LabelInstallDate.Name = "LabelInstallDate"
        Me.LabelInstallDate.Size = New System.Drawing.Size(128, 15)
        Me.LabelInstallDate.TabIndex = 103
        Me.LabelInstallDate.Visible = False
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.BackColor = System.Drawing.Color.Transparent
        Me.LabelDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelDetails.Location = New System.Drawing.Point(4, 404)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(125, 17)
        Me.LabelDetails.TabIndex = 102
        Me.LabelDetails.Text = "Programma details"
        '
        'ListViewPrograms
        '
        Me.ListViewPrograms.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DisplayName, Me.Publisher, Me.DisplayVersion, Me.HelpLink, Me.EstimatedSize, Me.IconIndex})
        Me.ListViewPrograms.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewPrograms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewPrograms.FullRowSelect = True
        Me.ListViewPrograms.LabelWrap = False
        Me.ListViewPrograms.Location = New System.Drawing.Point(0, 0)
        Me.ListViewPrograms.MultiSelect = False
        Me.ListViewPrograms.Name = "ListViewPrograms"
        Me.ListViewPrograms.Size = New System.Drawing.Size(497, 401)
        Me.ListViewPrograms.SmallImageList = Me.SmallImageList
        Me.ListViewPrograms.TabIndex = 100
        Me.ListViewPrograms.UseCompatibleStateImageBehavior = False
        Me.ListViewPrograms.View = System.Windows.Forms.View.Details
        '
        'DisplayName
        '
        Me.DisplayName.Text = "Name"
        Me.DisplayName.Width = 280
        '
        'Publisher
        '
        Me.Publisher.Text = "Publisher"
        Me.Publisher.Width = 177
        '
        'DisplayVersion
        '
        Me.DisplayVersion.Text = "Version"
        Me.DisplayVersion.Width = 0
        '
        'HelpLink
        '
        Me.HelpLink.Text = "HelpLink"
        Me.HelpLink.Width = 0
        '
        'EstimatedSize
        '
        Me.EstimatedSize.Text = "EstimatedSize"
        Me.EstimatedSize.Width = 0
        '
        'IconIndex
        '
        Me.IconIndex.Text = "IconNumber"
        Me.IconIndex.Width = 0
        '
        'SmallImageList
        '
        Me.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.SmallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LargeImageList
        '
        Me.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LargeImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 24)
        Me.Panel1.TabIndex = 64
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(311, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(186, 13)
        Me.LinkLabel1.TabIndex = 55
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Programma's toevoegen / verwijderen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.software_green_1
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
        Me.Label1.Size = New System.Drawing.Size(194, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Geïnstalleerde software"
        '
        'installedsoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "installedsoftware"
        Me.Size = New System.Drawing.Size(509, 524)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxProgram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SmallImageList As System.Windows.Forms.ImageList
    Friend WithEvents LargeImageList As System.Windows.Forms.ImageList
    Private WithEvents ListViewPrograms As System.Windows.Forms.ListView
    Private WithEvents DisplayName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Publisher As System.Windows.Forms.ColumnHeader
    Friend WithEvents DisplayVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpLink As System.Windows.Forms.ColumnHeader
    Friend WithEvents EstimatedSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconIndex As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabelHelpLink As System.Windows.Forms.LinkLabel
    Private WithEvents LabelDisplayName As System.Windows.Forms.Label
    Private WithEvents LabelDisplayVersion As System.Windows.Forms.Label
    Private WithEvents LabelDisplayVersionDesc As System.Windows.Forms.Label
    Private WithEvents PictureBoxProgram As System.Windows.Forms.PictureBox
    Private WithEvents labelNumberPrograms As System.Windows.Forms.Label
    Private WithEvents LabelEstimatedSize As System.Windows.Forms.Label
    Private WithEvents LabelEstSizeDesc As System.Windows.Forms.Label
    Private WithEvents LabelHelpTelephoneDesc As System.Windows.Forms.Label
    Private WithEvents LabelHelpLinkDesc As System.Windows.Forms.Label
    Private WithEvents LabelInstallDateDesc As System.Windows.Forms.Label
    Private WithEvents LabelHelpTelephone As System.Windows.Forms.Label
    Private WithEvents LabelInstallDate As System.Windows.Forms.Label
    Private WithEvents LabelDetails As System.Windows.Forms.Label

End Class

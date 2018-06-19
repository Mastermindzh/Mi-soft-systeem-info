<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opstart_programma_s
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opstart_programma_s))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListViewStartup = New System.Windows.Forms.ListView()
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.FileName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.DisplayCommand = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.DisplayFilePath = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.LabelProductNameDesc = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelFileVersionDesc = New System.Windows.Forms.Label()
        Me.LabelDescriptionDesc = New System.Windows.Forms.Label()
        Me.LabelCompanyDesc = New System.Windows.Forms.Label()
        Me.LabelFileVersion = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelCompany = New System.Windows.Forms.Label()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.StartupImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.labelNumberPrograms = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 24)
        Me.Panel1.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.icone_windows
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
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
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Opstart Programma's"
        '
        'ListViewStartup
        '
        Me.ListViewStartup.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewStartup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemName, Me.FileName, Me.Type, Me.Status, Me.DisplayCommand, Me.DisplayFilePath})
        Me.ListViewStartup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStartup.ForeColor = System.Drawing.Color.Black
        Me.ListViewStartup.FullRowSelect = True
        Me.ListViewStartup.LabelWrap = False
        Me.ListViewStartup.Location = New System.Drawing.Point(0, 24)
        Me.ListViewStartup.MultiSelect = False
        Me.ListViewStartup.Name = "ListViewStartup"
        Me.ListViewStartup.Size = New System.Drawing.Size(502, 398)
        Me.ListViewStartup.TabIndex = 57
        Me.ListViewStartup.UseCompatibleStateImageBehavior = False
        Me.ListViewStartup.View = System.Windows.Forms.View.Details
        '
        'ItemName
        '
        Me.ItemName.Text = "Naam"
        Me.ItemName.Width = 160
        '
        'FileName
        '
        Me.FileName.Text = "Bestandsnaam"
        Me.FileName.Width = 141
        '
        'Type
        '
        Me.Type.Text = "Locatie"
        Me.Type.Width = 0
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 0
        '
        'DisplayCommand
        '
        Me.DisplayCommand.Text = ""
        Me.DisplayCommand.Width = 0
        '
        'DisplayFilePath
        '
        Me.DisplayFilePath.Text = ""
        Me.DisplayFilePath.Width = 0
        '
        'LabelProductNameDesc
        '
        Me.LabelProductNameDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductNameDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelProductNameDesc.Location = New System.Drawing.Point(2, 465)
        Me.LabelProductNameDesc.Name = "LabelProductNameDesc"
        Me.LabelProductNameDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelProductNameDesc.TabIndex = 89
        Me.LabelProductNameDesc.Text = "Product:"
        '
        'LabelProductName
        '
        Me.LabelProductName.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductName.ForeColor = System.Drawing.Color.Black
        Me.LabelProductName.Location = New System.Drawing.Point(87, 465)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(398, 15)
        Me.LabelProductName.TabIndex = 88
        '
        'LabelFileVersionDesc
        '
        Me.LabelFileVersionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelFileVersionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelFileVersionDesc.Location = New System.Drawing.Point(2, 505)
        Me.LabelFileVersionDesc.Name = "LabelFileVersionDesc"
        Me.LabelFileVersionDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelFileVersionDesc.TabIndex = 86
        Me.LabelFileVersionDesc.Text = "Versie:"
        '
        'LabelDescriptionDesc
        '
        Me.LabelDescriptionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescriptionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelDescriptionDesc.Location = New System.Drawing.Point(2, 485)
        Me.LabelDescriptionDesc.Name = "LabelDescriptionDesc"
        Me.LabelDescriptionDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelDescriptionDesc.TabIndex = 85
        Me.LabelDescriptionDesc.Text = "Beschrijving:"
        '
        'LabelCompanyDesc
        '
        Me.LabelCompanyDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompanyDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelCompanyDesc.Location = New System.Drawing.Point(2, 445)
        Me.LabelCompanyDesc.Name = "LabelCompanyDesc"
        Me.LabelCompanyDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelCompanyDesc.TabIndex = 84
        Me.LabelCompanyDesc.Text = "Bedrijf:"
        '
        'LabelFileVersion
        '
        Me.LabelFileVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelFileVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelFileVersion.Location = New System.Drawing.Point(87, 505)
        Me.LabelFileVersion.Name = "LabelFileVersion"
        Me.LabelFileVersion.Size = New System.Drawing.Size(398, 15)
        Me.LabelFileVersion.TabIndex = 82
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.ForeColor = System.Drawing.Color.Black
        Me.LabelDescription.Location = New System.Drawing.Point(87, 485)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(398, 15)
        Me.LabelDescription.TabIndex = 81
        '
        'LabelCompany
        '
        Me.LabelCompany.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompany.ForeColor = System.Drawing.Color.Black
        Me.LabelCompany.Location = New System.Drawing.Point(87, 445)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New System.Drawing.Size(398, 15)
        Me.LabelCompany.TabIndex = 80
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.BackColor = System.Drawing.Color.Transparent
        Me.LabelDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelDetails.Location = New System.Drawing.Point(2, 425)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(51, 17)
        Me.LabelDetails.TabIndex = 79
        Me.LabelDetails.Text = "Details"
        '
        'StartupImageList
        '
        Me.StartupImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.StartupImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.StartupImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'labelNumberPrograms
        '
        Me.labelNumberPrograms.BackColor = System.Drawing.Color.Transparent
        Me.labelNumberPrograms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumberPrograms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelNumberPrograms.Location = New System.Drawing.Point(398, 425)
        Me.labelNumberPrograms.Name = "labelNumberPrograms"
        Me.labelNumberPrograms.Size = New System.Drawing.Size(104, 17)
        Me.labelNumberPrograms.TabIndex = 111
        Me.labelNumberPrograms.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Opstart_programma_s
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labelNumberPrograms)
        Me.Controls.Add(Me.LabelProductNameDesc)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelFileVersionDesc)
        Me.Controls.Add(Me.LabelDescriptionDesc)
        Me.Controls.Add(Me.LabelCompanyDesc)
        Me.Controls.Add(Me.LabelFileVersion)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelCompany)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.ListViewStartup)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Opstart_programma_s"
        Me.Size = New System.Drawing.Size(509, 524)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents ListViewStartup As System.Windows.Forms.ListView
    Private WithEvents ItemName As System.Windows.Forms.ColumnHeader
    Private WithEvents FileName As System.Windows.Forms.ColumnHeader
    Private WithEvents Type As System.Windows.Forms.ColumnHeader
    Private WithEvents Status As System.Windows.Forms.ColumnHeader
    Private WithEvents DisplayCommand As System.Windows.Forms.ColumnHeader
    Private WithEvents DisplayFilePath As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelProductNameDesc As System.Windows.Forms.Label
    Private WithEvents LabelProductName As System.Windows.Forms.Label
    Private WithEvents LabelFileVersionDesc As System.Windows.Forms.Label
    Private WithEvents LabelDescriptionDesc As System.Windows.Forms.Label
    Private WithEvents LabelCompanyDesc As System.Windows.Forms.Label
    Private WithEvents LabelFileVersion As System.Windows.Forms.Label
    Private WithEvents LabelDescription As System.Windows.Forms.Label
    Private WithEvents LabelCompany As System.Windows.Forms.Label
    Private WithEvents LabelDetails As System.Windows.Forms.Label
    Friend WithEvents StartupImageList As System.Windows.Forms.ImageList
    Private WithEvents labelNumberPrograms As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Video))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.LabelScreenWorkingArea1 = New System.Windows.Forms.Label()
        Me.LabelScreenDimensions1 = New System.Windows.Forms.Label()
        Me.ListViewAdaptors = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelNumberControllers = New System.Windows.Forms.Label()
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
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LabelDetails)
        Me.Panel2.Controls.Add(Me.LabelScreenWorkingArea1)
        Me.Panel2.Controls.Add(Me.LabelScreenDimensions1)
        Me.Panel2.Controls.Add(Me.ListViewAdaptors)
        Me.Panel2.Controls.Add(Me.LabelNumberControllers)
        Me.Panel2.Location = New System.Drawing.Point(-1, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 501)
        Me.Panel2.TabIndex = 63
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.BackColor = System.Drawing.Color.Transparent
        Me.LabelDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelDetails.Location = New System.Drawing.Point(-2, 67)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(102, 17)
        Me.LabelDetails.TabIndex = 103
        Me.LabelDetails.Text = "Adapter details"
        '
        'LabelScreenWorkingArea1
        '
        Me.LabelScreenWorkingArea1.AutoSize = True
        Me.LabelScreenWorkingArea1.BackColor = System.Drawing.Color.Transparent
        Me.LabelScreenWorkingArea1.ForeColor = System.Drawing.Color.Black
        Me.LabelScreenWorkingArea1.Location = New System.Drawing.Point(5, 38)
        Me.LabelScreenWorkingArea1.Name = "LabelScreenWorkingArea1"
        Me.LabelScreenWorkingArea1.Size = New System.Drawing.Size(149, 13)
        Me.LabelScreenWorkingArea1.TabIndex = 24
        Me.LabelScreenWorkingArea1.Text = "Current Screen Working Area:"
        '
        'LabelScreenDimensions1
        '
        Me.LabelScreenDimensions1.AutoSize = True
        Me.LabelScreenDimensions1.BackColor = System.Drawing.Color.Transparent
        Me.LabelScreenDimensions1.ForeColor = System.Drawing.Color.Black
        Me.LabelScreenDimensions1.Location = New System.Drawing.Point(5, 22)
        Me.LabelScreenDimensions1.Name = "LabelScreenDimensions1"
        Me.LabelScreenDimensions1.Size = New System.Drawing.Size(138, 13)
        Me.LabelScreenDimensions1.TabIndex = 23
        Me.LabelScreenDimensions1.Text = "Current Screen Dimensions:"
        '
        'ListViewAdaptors
        '
        Me.ListViewAdaptors.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewAdaptors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewAdaptors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListViewAdaptors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAdaptors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewAdaptors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewAdaptors.LabelWrap = False
        Me.ListViewAdaptors.Location = New System.Drawing.Point(1, 87)
        Me.ListViewAdaptors.MultiSelect = False
        Me.ListViewAdaptors.Name = "ListViewAdaptors"
        Me.ListViewAdaptors.ShowGroups = False
        Me.ListViewAdaptors.Size = New System.Drawing.Size(502, 414)
        Me.ListViewAdaptors.TabIndex = 22
        Me.ListViewAdaptors.UseCompatibleStateImageBehavior = False
        Me.ListViewAdaptors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 400
        '
        'LabelNumberControllers
        '
        Me.LabelNumberControllers.AutoSize = True
        Me.LabelNumberControllers.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumberControllers.ForeColor = System.Drawing.Color.Black
        Me.LabelNumberControllers.Location = New System.Drawing.Point(5, 6)
        Me.LabelNumberControllers.Name = "LabelNumberControllers"
        Me.LabelNumberControllers.Size = New System.Drawing.Size(108, 13)
        Me.LabelNumberControllers.TabIndex = 21
        Me.LabelNumberControllers.Text = "Number of Controllers"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.display
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
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Video informatie"
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
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Video"
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
    Private WithEvents LabelScreenWorkingArea1 As System.Windows.Forms.Label
    Private WithEvents LabelScreenDimensions1 As System.Windows.Forms.Label
    Private WithEvents ListViewAdaptors As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelNumberControllers As System.Windows.Forms.Label
    Private WithEvents LabelDetails As System.Windows.Forms.Label

End Class

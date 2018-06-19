<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processes))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListViewProcesses = New System.Windows.Forms.ListView()
        Me.Process = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Threads = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BasePriority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Memory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStripProcesses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuEndProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripProcesses.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icone_windows.png")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListViewProcesses)
        Me.Panel2.Location = New System.Drawing.Point(-1, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 501)
        Me.Panel2.TabIndex = 58
        '
        'ListViewProcesses
        '
        Me.ListViewProcesses.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewProcesses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Process, Me.PID, Me.Threads, Me.BasePriority, Me.Memory})
        Me.ListViewProcesses.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewProcesses.ForeColor = System.Drawing.Color.Black
        Me.ListViewProcesses.FullRowSelect = True
        Me.ListViewProcesses.LabelWrap = False
        Me.ListViewProcesses.Location = New System.Drawing.Point(0, 0)
        Me.ListViewProcesses.MultiSelect = False
        Me.ListViewProcesses.Name = "ListViewProcesses"
        Me.ListViewProcesses.Size = New System.Drawing.Size(502, 501)
        Me.ListViewProcesses.TabIndex = 52
        Me.ListViewProcesses.UseCompatibleStateImageBehavior = False
        Me.ListViewProcesses.View = System.Windows.Forms.View.Details
        '
        'Process
        '
        Me.Process.Text = "Process"
        Me.Process.Width = 115
        '
        'PID
        '
        Me.PID.Text = "PID"
        '
        'Threads
        '
        Me.Threads.Text = "Threads"
        '
        'BasePriority
        '
        Me.BasePriority.Text = "Priorieteit"
        Me.BasePriority.Width = 80
        '
        'Memory
        '
        Me.Memory.Text = "Geheugen"
        Me.Memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Memory.Width = 70
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
        Me.Panel1.TabIndex = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.settings
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
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Processen"
        '
        'ContextMenuStripProcesses
        '
        Me.ContextMenuStripProcesses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEndProcess})
        Me.ContextMenuStripProcesses.Name = "ContextMenuStripProcesses"
        Me.ContextMenuStripProcesses.Size = New System.Drawing.Size(138, 26)
        '
        'MenuEndProcess
        '
        Me.MenuEndProcess.Name = "MenuEndProcess"
        Me.MenuEndProcess.Size = New System.Drawing.Size(152, 22)
        Me.MenuEndProcess.Text = "End process"
        '
        'Processes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Processes"
        Me.Size = New System.Drawing.Size(509, 524)
        Me.Panel2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStripProcesses.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents ListViewProcesses As System.Windows.Forms.ListView
    Private WithEvents Process As System.Windows.Forms.ColumnHeader
    Private WithEvents PID As System.Windows.Forms.ColumnHeader
    Private WithEvents Threads As System.Windows.Forms.ColumnHeader
    Private WithEvents BasePriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents Memory As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStripProcesses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuEndProcess As System.Windows.Forms.ToolStripMenuItem

End Class

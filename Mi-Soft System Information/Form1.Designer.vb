<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Version = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GPU = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.Label()
        Me.ram = New System.Windows.Forms.Label()
        Me.mb = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Fullname = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.Label()
        Me.Verzie = New System.Windows.Forms.Label()
        Me.sp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Firebrick
        Me.Version.Location = New System.Drawing.Point(145, -5)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(96, 35)
        Me.Version.TabIndex = 19
        Me.Version.Text = "Versie"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Service pack"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Volledige naam "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Versie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Videokaart"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Processor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Geheugen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Moederbord"
        '
        'GPU
        '
        Me.GPU.AutoSize = True
        Me.GPU.Location = New System.Drawing.Point(106, 177)
        Me.GPU.Name = "GPU"
        Me.GPU.Size = New System.Drawing.Size(13, 13)
        Me.GPU.TabIndex = 33
        Me.GPU.Text = "0"
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.Location = New System.Drawing.Point(106, 114)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(13, 13)
        Me.CPU.TabIndex = 32
        Me.CPU.Text = "0"
        '
        'ram
        '
        Me.ram.AutoSize = True
        Me.ram.Location = New System.Drawing.Point(106, 135)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(13, 13)
        Me.ram.TabIndex = 31
        Me.ram.Text = "0"
        '
        'mb
        '
        Me.mb.AutoSize = True
        Me.mb.Location = New System.Drawing.Point(106, 157)
        Me.mb.Name = "mb"
        Me.mb.Size = New System.Drawing.Size(13, 13)
        Me.mb.TabIndex = 34
        Me.mb.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(106, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Type systeem"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.camera1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(64, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 23)
        Me.Button3.TabIndex = 39
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Mi_Soft_System_Information.My.Resources.Resources.About1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "About"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(302, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Meer info"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mi_Soft_System_Information.My.Resources.Resources.square
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Fullname
        '
        Me.Fullname.BackColor = System.Drawing.SystemColors.Control
        Me.Fullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Fullname.Location = New System.Drawing.Point(209, 29)
        Me.Fullname.Multiline = True
        Me.Fullname.Name = "Fullname"
        Me.Fullname.Size = New System.Drawing.Size(163, 17)
        Me.Fullname.TabIndex = 40
        '
        'type
        '
        Me.type.AutoSize = True
        Me.type.Location = New System.Drawing.Point(207, 86)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(21, 13)
        Me.type.TabIndex = 38
        Me.type.Text = "SP"
        '
        'Verzie
        '
        Me.Verzie.AutoSize = True
        Me.Verzie.Location = New System.Drawing.Point(207, 67)
        Me.Verzie.Name = "Verzie"
        Me.Verzie.Size = New System.Drawing.Size(21, 13)
        Me.Verzie.TabIndex = 25
        Me.Verzie.Text = "SP"
        '
        'sp
        '
        Me.sp.AutoSize = True
        Me.sp.Location = New System.Drawing.Point(207, 47)
        Me.sp.Name = "sp"
        Me.sp.Size = New System.Drawing.Size(21, 13)
        Me.sp.TabIndex = 21
        Me.sp.Text = "SP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 225)
        Me.Controls.Add(Me.Fullname)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.mb)
        Me.Controls.Add(Me.GPU)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.ram)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Verzie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi-Soft Systeem Informatie"
        Me.TopMost = true
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GPU As System.Windows.Forms.Label
    Friend WithEvents CPU As System.Windows.Forms.Label
    Friend WithEvents ram As System.Windows.Forms.Label
    Friend WithEvents mb As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Fullname As System.Windows.Forms.TextBox
    Friend WithEvents type As System.Windows.Forms.Label
    Friend WithEvents Verzie As System.Windows.Forms.Label
    Friend WithEvents sp As System.Windows.Forms.Label

End Class

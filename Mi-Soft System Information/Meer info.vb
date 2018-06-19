Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices
Public Class Meer_info

    Public Shared copytext As String

    Public Shared refresh2 As String = Nothing
    Private Sub Meer_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gpuscreen = False
            TreeView1.ExpandAll()
            TreeView1.SelectedNode = TreeView1.Nodes(0).Nodes(0).Nodes(0)
            TreeView1.Nodes(0).Nodes(2).Collapse()
        Catch ex As Exception
            gpuscreen = False
            TreeView1.ExpandAll()
            TreeView1.SelectedNode = TreeView1.Nodes(0).Nodes(0).Nodes(0)
            TreeView1.Nodes(0).Nodes(2).Collapse()
        End Try

    End Sub
    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            Select Case e.Node.Text.ToLower
                Case "systeem overzicht"
                    refresh2 = "systeem overzicht"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Systeem_overzicht.CreateInstance())
                  
                Case "netwerk adapters"
                    refresh2 = "netwerk kaarten"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(netwerkadapters.CreateInstance())
            
                Case "software"
                    refresh2 = "software"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Software.CreateInstance())


                Case "bios"
                    refresh2 = "bios"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Bios.CreateInstance())


                Case "systeem informatie"
                    refresh2 = "systeem informatie"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Systeem_informatie.CreateInstance())
                    ToolStripButton4.Enabled = False
                    ToolStripButton5.Enabled = False
                Case "hardware"
                    refresh2 = "hardware"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Hardware.CreateInstance)
                    ToolStripButton4.Enabled = False
                    ToolStripButton5.Enabled = False
                Case "besturingssysteem"
                    refresh2 = "besturingssysteem"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Besturingssysteem.CreateInstance())


                Case "software"
                    refresh2 = "software"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Software.CreateInstance())
                    ToolStripButton4.Enabled = False
                    ToolStripButton5.Enabled = False
                Case "moederbord"
                    refresh2 = "moederbord"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Moederbord.CreateInstance())


                Case "processor"
                    refresh2 = "processor"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Processor.CreateInstance())


                Case "geheugen"
                    refresh2 = "geheugen"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Geheugen.CreateInstance())


                Case "video"
                    refresh2 = "video"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Video.CreateInstance())


                Case "stations"
                    refresh2 = "stations"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(stations.CreateInstance())


                Case "geïnstalleerde software"
                    refresh2 = "geïnstalleerde software"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(installedsoftware.CreateInstance())


                Case "opstart programma's"
                    refresh2 = "opstart programma's"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Opstart_programma_s.CreateInstance())


                Case "processen"
                    refresh2 = "processen"
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(Processes.CreateInstance())


            End Select
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub refreshpanel()
        If refresh2 = "systeem overzicht" Then
            Systeem_overzicht.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Systeem_overzicht.CreateInstance())
        ElseIf refresh2 = "opstart programma's" Then
            Opstart_programma_s.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Opstart_programma_s.CreateInstance())
        ElseIf refresh2 = "netwerk kaarten" Then
            netwerkadapters.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(netwerkadapters.CreateInstance())
        ElseIf refresh2 = "besturingssysteem" Then
            Besturingssysteem.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Software.CreateInstance())
        ElseIf refresh2 = "systeem informatie" Then
            Systeem_informatie.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Systeem_informatie.CreateInstance())
        ElseIf refresh2 = "hardware" Then
            Hardware.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Hardware.CreateInstance)
        ElseIf refresh2 = "bios" Then
            Bios.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Bios.CreateInstance())
        ElseIf refresh2 = "moederbord" Then
            Moederbord.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Moederbord.CreateInstance())
        ElseIf refresh2 = "processor" Then
            Processor.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Processor.CreateInstance())
        ElseIf refresh2 = "geheugen" Then
            Geheugen.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Geheugen.CreateInstance())
        ElseIf refresh2 = "video" Then
            Video.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Video.CreateInstance())
        ElseIf refresh2 = "stations" Then
            stations.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(stations.CreateInstance())
        ElseIf refresh2 = "geïnstalleerde software" Then
            stations.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(installedsoftware.CreateInstance())

        ElseIf refresh2 = "processen" Then
            Processes.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(Processes.CreateInstance())
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        refreshpanel()
    End Sub
    Private Sub HttpmisoftnlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HttpmisoftnlToolStripMenuItem.Click
        Process.Start("Http://mi-soft.nl")
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub BindingNavigatorMoveFirstItem_Click(sender As System.Object, e As System.EventArgs)
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim wid As Integer = Me.Width
            Dim hgt As Integer = Me.Height
            Dim pic As New Bitmap(wid, hgt)
            Dim ext As String = Nothing
            Me.DrawToBitmap(pic, New Rectangle(0, 0, wid, hgt))
            With SaveFileDialog1
                SaveFileDialog1.FileName = "Systeem informatie van " & SystemInformation.ComputerName
                SaveFileDialog1.Filter = "JPEG |*.jpeg|Bitmap Image|*.bmp|PNG |*.png|GIF |*.gif|TIFF |*.tiff"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ext = Path.GetExtension(SaveFileDialog1.FileName)
                    ext.ToLower()
                    If ext = ".jpeg" Then
                        pic.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ElseIf ext = ".bmp" Then
                        pic.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                    ElseIf ext = ".png" Then
                        pic.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                    ElseIf ext = ".gif" Then
                        pic.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                    ElseIf ext = ".tiff" Then
                        pic.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Tiff)

                    End If

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        refreshpanel()
    End Sub
    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        Process.Start("Http://www.mi-soft.nl")
    End Sub
    Private Sub SysteemAfsluitenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SysteemAfsluitenToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Shutdown", "/s /t 00") 'to shutdown
    End Sub
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        waitform.Label2.Text = "Meer info sluiten"
        waitform.Show()
        If refresh2 = "systeem overzicht" Then
            Systeem_overzicht.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "opstart programma's" Then
            Opstart_programma_s.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "netwerk kaarten" Then
            netwerkadapters.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "besturingssysteem" Then
            Besturingssysteem.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "systeem informatie" Then
            Systeem_informatie.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "hardware" Then
            Hardware.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "bios" Then
            Bios.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "moederbord" Then
            Moederbord.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "processor" Then
            Processor.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "geheugen" Then
            Geheugen.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "video" Then
            Video.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "stations" Then
            stations.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        ElseIf refresh2 = "geïnstalleerde software" Then
            stations.deleteinstance()
            SplitContainer1.Panel2.Controls.Clear()
        End If
        gpuscreen = True
        waitform.Close()
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        About.ShowDialog()
    End Sub
    Private Sub ToolStripButton9_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Systeem_informatie.test()
    End Sub
    Private Sub SysteemHerstartenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SysteemHerstartenToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Shutdown", "/r /t 00") 'to restart
    End Sub

    Private Sub AfmeldenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AfmeldenToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Shutdown", "/l") 'to logoff
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        My.Computer.Clipboard.SetText(copytext)
     

    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        MsgBox("Deze functie is nog niet ingebouwd")
    End Sub
End Class
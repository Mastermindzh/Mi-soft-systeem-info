Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.management
Imports Microsoft.VisualBasic.Devices
Public Class Form1
    Enum InfoTypes
        OperatingSystemName
        ProcessorName
        AmountOfMemory
        VideocardName
        VideocardMem
    End Enum
    Public Function GetInfo(ByVal InfoType As InfoTypes) As String
        Dim Info As New ComputerInfo
        Dim Value As String = Nothing
        Dim vganame As String = Nothing
        Dim vgamem As String = Nothing
        Dim proc As String = Nothing
        Dim searcher As New Management.ManagementObjectSearcher( _
            "root\CIMV2", "SELECT * FROM Win32_VideoController")
        Dim searcher1 As New Management.ManagementObjectSearcher( _
            "SELECT * FROM Win32_Processor")
        If InfoType = InfoTypes.OperatingSystemName Then
            Value = Info.OSFullName
        ElseIf InfoType = InfoTypes.ProcessorName Then
            For Each queryObject As ManagementObject In searcher1.Get
                proc = queryObject.GetPropertyValue("Name").ToString
            Next
            Value = proc
            Value = Value.Replace("  ", " ")
        ElseIf InfoType = InfoTypes.AmountOfMemory Then
            Value = Math.Round((((CDbl(Convert.ToDouble(Val(Info.TotalPhysicalMemory))) / 1024)) / 1024 / 1024), 2) & " GB"
        ElseIf InfoType = InfoTypes.VideocardName Then
            For Each queryObject As ManagementObject In searcher.Get
                vganame = queryObject.GetPropertyValue("Name").ToString
            Next
            Value = vganame
        ElseIf InfoType = InfoTypes.VideocardMem Then
            For Each queryObject As ManagementObject In searcher.Get
                vgamem = queryObject.GetPropertyValue("AdapterRAM").ToString
            Next
            Value = Math.Round((((CDbl(Convert.ToDouble(Val(vgamem))) / 1024)) / 1024), 2) & " MB"
        End If
        Return Value
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = False
        determinewindows()
        sp.Text = getServicePack()
        Verzie.Text = My.Computer.Info.OSVersion
        type.Text = My.Computer.Info.OSPlatform
        determineosbit()
        mb.Text = getmotherboardname()
        CPU.Text = GetInfo(InfoTypes.ProcessorName)
        'ram.Text = GetInfo(InfoTypes.AmountOfMemory)


        Dim fakemem As String = My.Computer.Info.TotalPhysicalMemory / 1000 / 1000 / 1000
        Dim formatted As String = FormatNumber(fakemem, 0)
        ram.Text = formatted & " GB"
        GPU.Text = getvideoname()
    End Sub
    Private Sub determineosbit()
        If My.Computer.Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x86") Then
            type.Text = "32 Bit"
        Else
            type.Text = "64 bit"
        End If
    End Sub
    Private Sub determinewindows()
        Dim osfullname As String = My.Computer.Info.OSFullName
        Fullname.Text = osfullname
        If osfullname.ToLower.Contains("windows 7") Then
            Version.Text = "Windows 7"
        ElseIf osfullname.ToLower.Contains("windows xp") Then
            Version.Text = "Windows XP"
            Version.Location = New Point(145, 0)
        ElseIf osfullname.ToLower.Contains("windows vista") Then
            Version.Text = "Windows Vista"
            Version.Location = New Point(130, 0)
        ElseIf osfullname.ToLower.Contains("windows 2000") Then
            Version.Text = "Windows 2000"
            Version.Location = New Point(130, 0)
        ElseIf osfullname.ToLower.Contains("windows 8") Then
            Version.Text = "Windows 8"
        ElseIf osfullname.ToLower.Contains("windows 98") Then
            Version.Text = "Windows 98"
        ElseIf osfullname.ToLower.Contains("windows 95") Then
            Version.Text = "Windows 95"
        ElseIf osfullname.ToLower.Contains("windows me") Then
            Version.Text = "Windows XP"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        About.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Meer_info.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

                '              bm.Save(SaveFileDialog1.FileName, _
                'System.Drawing.Imaging.ImageFormat.Bmp)
            End If
        End With
    End Sub

End Class

Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices

Public Class Systeem_overzicht
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub
    Enum InfoTypes
        OperatingSystemName
        ProcessorName
        AmountOfMemory
        VideocardName
        VideocardMem
    End Enum
    Private _Info As New InformationClass
    Private Shared panelInstance As Systeem_overzicht
    Public Sub copytest()


        For i As Integer = 0 To ListViewInfo.SelectedItems.Count - 1
            Meer_info.copytext = ListViewInfo.SelectedItems(i).Text
        Next

    End Sub
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
            CleanString(Value)

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
    Public Function CleanString(strSource As String) As String
        On Error GoTo CleanStringErr

        ' convert tabs to spaces first
        strSource = Replace(strSource, vbTab, " ")

        ' convert all CRLFs to spaces
        strSource = Replace(strSource, vbCrLf, " ")

        ' Find and replace any occurences of multiple spaces
        Do While (InStr(strSource, "  "))
            ' if true, the string still contains double spaces,
            ' replace with single space
            strSource = Replace(strSource, "  ", " ")
        Loop

        ' Remove any leading or training spaces and return
        ' result
        CleanString = Trim(strSource)

        Exit Function

CleanStringErr:

    End Function
    Public Shared Function CreateInstance() As Systeem_overzicht
        If (panelInstance Is Nothing) Then
            panelInstance = New Systeem_overzicht()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Systeem_overzicht
        panelInstance = Nothing
    End Function
    '<<<<-----------End all that is needed on every panel------------>>>>
    Private Sub Systeem_overzicht_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub


    Private Sub getinfo2()

        Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()
        ' Add some groups to the ListView.
        Dim hardware_group As New ListViewGroup("Hardware")
        ListViewInfo.Groups.Add(hardware_group)
        Dim besturingssysteem_group As New ListViewGroup("Besturingssysteem")
        ListViewInfo.Groups.Add(besturingssysteem_group)

        ' Allow panel to paint.
        Application.DoEvents()
        Dim X As Integer
        ' Get information.
        _Info.Initialize(InformationClass.Initializers.GetVideoInfo)
        'Moederbord'
        Dim mobo As ListViewItem = New ListViewItem(New String() {"Moederbord", GetMainBoardManufacturer() & "  " & getmotherboardname()}, hardware_group)
        mobo.ImageIndex = 1
        ListViewInfo.Items.Add(mobo)
        'Processor'
        Dim CPU As ListViewItem = New ListViewItem(New String() {"Processor", GetInfo(InfoTypes.ProcessorName)}, hardware_group)
        CPU.ImageIndex = 0
        ListViewInfo.Items.Add(CPU)
        'Fysiek geheugen'
        Dim ram As ListViewItem = New ListViewItem(New String() {"Fysiek geheugen", GetInfo(InfoTypes.AmountOfMemory)}, hardware_group)
        ram.ImageIndex = 2
        ListViewInfo.Items.Add(ram)
        'Virtueel geheugen'
        Dim virram As ListViewItem = New ListViewItem(New String() {"Virtueel geheugen", GetMemTotalVirtual()}, hardware_group)
        virram.ImageIndex = 4
        ListViewInfo.Items.Add(virram)
        'Videokaart'
        If _Info.VidNumberOfControllers > 0 Then
            For X = 0 To _Info.VidNumberOfControllers - 1
                Try
                    Dim gpu As ListViewItem = New ListViewItem(New String() {"Videokaart", _Info.VidController.Item(X).ToString}, hardware_group)
                    gpu.ImageIndex = 3
                    ListViewInfo.Items.Add(gpu)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If

        'Besturingssysteem'
        Dim besturingssysteem As ListViewItem = New ListViewItem(New String() {"Besturingssysteem", My.Computer.Info.OSFullName}, besturingssysteem_group)
        besturingssysteem.ImageIndex = 6
        ListViewInfo.Items.Add(besturingssysteem)
        'Versie'
        Dim versie As ListViewItem = New ListViewItem(New String() {"Versie", Environment.OSVersion.Version.Major.ToString & "." & Environment.OSVersion.Version.Minor.ToString}, besturingssysteem_group)
        versie.ImageIndex = 6
        ListViewInfo.Items.Add(versie)
        'Oscodename'
        Dim oscodename As ListViewItem = New ListViewItem(New String() {"Besturingssysteem codenaam", GetOSCodename()}, besturingssysteem_group)
        oscodename.ImageIndex = 6
        ListViewInfo.Items.Add(oscodename)
        'Systeem type'
        Dim type As ListViewItem = New ListViewItem(New String() {"Systeem type", getSystemType2()}, besturingssysteem_group)
        type.ImageIndex = 5
        ListViewInfo.Items.Add(type)
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim performance_group As New ListViewGroup("Windows Prestatie Index")
            ListViewInfo.Groups.Add(performance_group)
            performance_group.Name = "Windows prestatie Index"
            Dim indexnumber As ListViewItem = New ListViewItem(New String() {"Basisscore", GetBaseScore()}, performance_group)
            indexnumber.ImageIndex = 8
            ListViewInfo.Items.Add(indexnumber)
            thread.Abort()
            Dim cpuscore As ListViewItem = New ListViewItem(New String() {"Processor", GetCPUscore()}, performance_group)
            ListViewInfo.Items.Add(cpuscore)
            cpuscore.ImageIndex = 8
            Dim memscore As ListViewItem = New ListViewItem(New String() {"Geheugen(RAM)", getmemscore()}, performance_group)
            ListViewInfo.Items.Add(memscore)
            memscore.ImageIndex = 8
            Dim gpuscore As ListViewItem = New ListViewItem(New String() {"Grafisch", getgpuscore()}, performance_group)
            ListViewInfo.Items.Add(gpuscore)
            gpuscore.ImageIndex = 8
            Dim gpugamescore As ListViewItem = New ListViewItem(New String() {"Grafisch voor spellen", getgpugamescore()}, performance_group)
            ListViewInfo.Items.Add(gpugamescore)
            gpugamescore.ImageIndex = 8
            Dim hddscore As ListViewItem = New ListViewItem(New String() {"Harde schijf", gethddscore()}, performance_group)
            ListViewInfo.Items.Add(hddscore)
            hddscore.ImageIndex = 8
            thread.Abort()
        Else
            thread.Abort()
        End If
        thread.Abort()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        getinfo2()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        copytest()
    End Sub

    Private Sub ListViewInfo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewInfo.SelectedIndexChanged
        Dim copy As String = Nothing
        Dim een As String = Nothing
        Dim twee As String
        For i As Integer = 0 To ListViewInfo.SelectedItems.Count - 1
            een = ListViewInfo.SelectedItems(i).Text
            twee = ListViewInfo.SelectedItems(i).SubItems(1).Text
        Next
        copy = een & ": " & twee
        Meer_info.copytext = copy
    End Sub

End Class

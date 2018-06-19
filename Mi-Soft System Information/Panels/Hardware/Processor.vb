Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices

Public Class Processor
    Enum InfoTypes
        OperatingSystemName
        ProcessorName
        AmountOfMemory
        VideocardName
        VideocardMem
    End Enum
    Private Shared panelInstance As Processor
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Processor
        If (panelInstance Is Nothing) Then
            panelInstance = New Processor()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Processor
        panelInstance = Nothing
    End Function
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
            For i = 0 To 10
                Value.Replace("  ", " ")
            Next

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
    Private Sub Processor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Algemeen_group As New ListViewGroup("Algemeen")
        ListViewInfo.Groups.Add(Algemeen_group)
        Dim Powermanagement_group As New ListViewGroup("Power management")
        ListViewInfo.Groups.Add(Powermanagement_group)


        Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()
        _Info.Initialize(InformationClass.Initializers.GetCpuInfo)

        Dim cpuinfo As ListViewItem = New ListViewItem(New String() {"Beschrijving", _Info.CpuDescription}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"CPU Naam", GetInfo(InfoTypes.ProcessorName)}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"CPU fabrikant", _Info.CpuManufacturer}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"Processor Snelheid", _Info.CpuSpeed}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)


        If _Info.OSMajorVersion > 5 Then
            cpuinfo = New ListViewItem(New String() {"Aantal cores", _Info.CpuNumberOfCores}, Algemeen_group)
            cpuinfo.ImageIndex = 0
            ListViewInfo.Items.Add(cpuinfo)
            cpuinfo = New ListViewItem(New String() {"Aantal logische cores", _Info.CpuNumberOfLogicalProcessors.ToString}, Algemeen_group)
            cpuinfo.ImageIndex = 0
            ListViewInfo.Items.Add(cpuinfo)
        End If

        cpuinfo = New ListViewItem(New String() {"Front side bus snelheid", _Info.CpuFsbSpeed}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"L2cache groote", _Info.CpuL2CacheSize}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"L2cache snelheid", _Info.CpuL2CacheSpeed}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        cpuinfo = New ListViewItem(New String() {"Socket", _Info.CpuSocket}, Algemeen_group)
        cpuinfo.ImageIndex = 0
        ListViewInfo.Items.Add(cpuinfo)

        If _Info.CpuPowerManagementSupported Then
            cpuinfo = New ListViewItem(New String() {"Power management", "Ondersteunt"}, Powermanagement_group)
            cpuinfo.ImageIndex = 0
            ListViewInfo.Items.Add(cpuinfo)
            cpuinfo = New ListViewItem(New String() {"Power management", _Info.CpuPowerManagementCapabilities}, Powermanagement_group)
            cpuinfo.ImageIndex = 0
            ListViewInfo.Items.Add(cpuinfo)
        Else
            cpuinfo = New ListViewItem(New String() {"Power management", "Niet ondersteunt"}, Powermanagement_group)
            cpuinfo.ImageIndex = 0
            ListViewInfo.Items.Add(cpuinfo)
        End If
      


        
        thread.Abort()
    End Sub
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
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

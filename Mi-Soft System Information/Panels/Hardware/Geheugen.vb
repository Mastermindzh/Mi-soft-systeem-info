Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices

Public Class Geheugen
    Enum InfoTypes
        OperatingSystemName
        ProcessorName
        AmountOfMemory
        VideocardName
        VideocardMem
    End Enum
    Private Shared panelInstance As Geheugen
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Geheugen
        If (panelInstance Is Nothing) Then
            panelInstance = New Geheugen()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Geheugen
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
    Private Sub Geheugen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        waitform.Show()
        _Info.Initialize(InformationClass.Initializers.GetNone)

        
        Dim functies_group As New ListViewGroup("1MB = 1024 KB")
        ListView.Groups.Add(functies_group)

        Dim bit_group As New ListViewGroup("1MB = 1000 KB")
        ListView.Groups.Add(bit_group)

        Dim percent_group As New ListViewGroup("Percentages")
        ListView.Groups.Add(percent_group)
        Dim mem As ListViewItem = New ListViewItem(New String() {"Totaal fysiek geheugen", _Info.MemTotalPhysical}, functies_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Beschikbaar Fysiek Geheugen", _Info.MemAvailPhysical}, functies_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Totaal virtueel Geheugen", _Info.MemTotalVirtual}, functies_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Beschikbaar Virtueel Geheugen", _Info.MemAvailVirtual}, functies_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)
        Dim fakemem As String = My.Computer.Info.TotalPhysicalMemory / 1000 / 1000 / 1000
        Dim formatted As String = FormatNumber(fakemem, 2)
        mem = New ListViewItem(New String() {"Totaal fysiek Geheugen", formatted & " GB"}, bit_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        fakemem = My.Computer.Info.AvailablePhysicalMemory / 1000 / 1000 / 1000
        formatted = FormatNumber(fakemem, 2)
        mem = New ListViewItem(New String() {"Beschikbaar fysiek geheugen", formatted & " GB"}, bit_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        Dim answer As String = (Format((100 / CBNMB(My.Computer.Info.TotalPhysicalMemory)) * CBNMB(My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory), "#.#") & "%")
        mem = New ListViewItem(New String() {"% Fysiek gebruikte geheugen", answer}, percent_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        fakemem = My.Computer.Info.TotalVirtualMemory / 1000 / 1000 / 1000
        formatted = FormatNumber(fakemem, 2)
        mem = New ListViewItem(New String() {"Totaal virtueel Geheugen", formatted & " GB"}, bit_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)
        fakemem = My.Computer.Info.AvailableVirtualMemory / 1000 / 1000 / 1000
        formatted = FormatNumber(fakemem, 2)
        mem = New ListViewItem(New String() {"Beschikbaar Virtueel Geheugen", formatted & " GB"}, bit_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        Dim answer2 As String = (Format((100 / CBNMB(My.Computer.Info.TotalVirtualMemory)) * CBNMB(My.Computer.Info.TotalVirtualMemory - My.Computer.Info.AvailableVirtualMemory), "#.#") & "%")
        mem = New ListViewItem(New String() {"% Virtueel gebruikte geheugen", answer2}, percent_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)
        waitform.Close()

   
    End Sub
    Private Function CBNMB(ByVal bytes As Double) As Double
        Dim MB As Double
        MB = (bytes / 1024) / 1024
        CBNMB = Format(MB, "###,###,###0.00")
    End Function

  
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        waitform.Show()
        Geheugen.deleteinstance()
        Meer_info.SplitContainer1.Panel2.Controls.Clear()
        Meer_info.SplitContainer1.Panel2.Controls.Add(Geheugen.CreateInstance)
        waitform.Close()
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView.SelectedIndexChanged
        Dim copy As String = Nothing
        Dim een As String = Nothing
        Dim twee As String
        For i As Integer = 0 To ListView.SelectedItems.Count - 1
            een = ListView.SelectedItems(i).Text
            twee = ListView.SelectedItems(i).SubItems(1).Text
        Next
        copy = een & ": " & twee
        Meer_info.copytext = copy
    End Sub
End Class

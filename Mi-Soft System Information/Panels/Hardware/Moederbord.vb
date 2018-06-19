Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices

Public Class Moederbord
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub
    Private Shared panelInstance As Moederbord
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Moederbord
        If (panelInstance Is Nothing) Then
            panelInstance = New Moederbord()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Moederbord
        panelInstance = Nothing
    End Function



    Private Sub Moederbord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()
        _Info.Initialize(InformationClass.Initializers.GetCpuInfo)

        Dim Samenvatting_group As New ListViewGroup("Samenvatting")
        ListView.Groups.Add(Samenvatting_group)
        Dim brug_group As New ListViewGroup("CPU")
        ListView.Groups.Add(brug_group)
        Dim Geheugen_group As New ListViewGroup("Geheugen")
        ListView.Groups.Add(Geheugen_group)

        Dim virram As ListViewItem = New ListViewItem(New String() {"Fabrikant", GetMainBoardManufacturer()}, Samenvatting_group)
        virram.ImageIndex = 0
        ListView.Items.Add(virram)
        virram = New ListViewItem(New String() {"Model", GetMainBoardModel()}, Samenvatting_group)
        virram.ImageIndex = 0
        ListView.Items.Add(virram)
        virram = New ListViewItem(New String() {"Volledige naam", getmotherboardname()}, Samenvatting_group)
        virram.ImageIndex = 0
        ListView.Items.Add(virram)
        Dim ram As ListViewItem = New ListViewItem(New String() {"Serienummer", GetMotherBoardID()}, Samenvatting_group)
        ram.ImageIndex = 0
        ListView.Items.Add(ram)




        Dim brug As ListViewItem = New ListViewItem(New String() {"Naam", _Info.CpuName}, brug_group)
        brug.ImageIndex = 2
        ListView.Items.Add(brug)
        brug = New ListViewItem(New String() {"Processor voet", _Info.CpuSocket}, brug_group)
        brug.ImageIndex = 2
        ListView.Items.Add(brug)
        brug = New ListViewItem(New String() {"Max. CPU-Snelheid", _Info.CpuSpeed}, brug_group)
        brug.ImageIndex = 2
        ListView.Items.Add(brug)

        Dim mem As ListViewItem = New ListViewItem(New String() {"Geheugen geïnstalleerd", _Info.MemTotalPhysical}, Geheugen_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Beschikbaar Fysiek Geheugen", _Info.MemAvailPhysical}, Geheugen_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Virtueel Geheugen", _Info.MemTotalVirtual}, Geheugen_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)

        mem = New ListViewItem(New String() {"Beschikbaar Virtueel Geheugen", _Info.MemAvailVirtual}, Geheugen_group)
        mem.ImageIndex = 3
        ListView.Items.Add(mem)
        thread.Abort()
    End Sub

    Private Function CBNMB(ByVal bytes As Double) As Double
        Dim MB As Double
        MB = (bytes / 1024) / 1024
        CBNMB = Format(MB, "###,###,###0.00")
    End Function

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

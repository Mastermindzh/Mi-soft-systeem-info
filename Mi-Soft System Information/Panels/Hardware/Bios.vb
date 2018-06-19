Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices
Enum InfoTypes
    OperatingSystemName
    ProcessorName
    AmountOfMemory
    VideocardName
    VideocardMem
End Enum
Public Class Bios
    Private Shared panelInstance As Bios
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Bios
        If (panelInstance Is Nothing) Then
            panelInstance = New Bios()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Bios
        panelInstance = Nothing
    End Function
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub

    Private Sub Bios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()


        _Info.Initialize(InformationClass.Initializers.GetBiosInfo)
        Dim algemeen_group As New ListViewGroup("Algemeen")
        ListView.Groups.Add(algemeen_group)
        Dim functies_group As New ListViewGroup("Functies")
        ListView.Groups.Add(functies_group)
        Try
            Dim feature As Object
            ' Get Information
            _Info.Initialize(InformationClass.Initializers.GetBiosInfo)
            Dim bios As ListViewItem = New ListViewItem(New String() {"Fabrikant", _Info.BiosManufacturer}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)
            bios = New ListViewItem(New String() {"Versie", _Info.BiosVersion}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)
            bios = New ListViewItem(New String() {"Uitgebracht op", _Info.BiosReleaseDate}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)
            bios = New ListViewItem(New String() {"Huidige SMBIOS", CStr(_Info.BiosSMBiosPresent)}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)

            bios = New ListViewItem(New String() {"Versie SMBIOS", _Info.BiosSMBiosVersion}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)
            bios = New ListViewItem(New String() {"Volledige informatie", _Info.BiosName}, algemeen_group)
            bios.ImageIndex = 0
            ListView.Items.Add(bios)
            ' Fill in listview with features, if present
            If _Info.BiosFeatures IsNot Nothing Then
                For Each feature In _Info.BiosFeatures

                    If feature.ToString = "Reserved for BIOS vendor" Or feature = "Reserved for system vendor" Then
                    Else
                        feature = New ListViewItem(New String() {"", feature.ToString}, functies_group)
                        ListView.Items.Add(feature)
                    End If

                Next
            Else
                ListView.Items.Add("Not Available")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        thread.Abort()
    End Sub
   
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
      
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

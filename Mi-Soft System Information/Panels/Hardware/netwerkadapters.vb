Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Public Class netwerkadapters
    Private Shared panelInstance As netwerkadapters
    Dim strstr As String = Nothing
    Public Shared Function CreateInstance() As netwerkadapters
        If (panelInstance Is Nothing) Then
            panelInstance = New netwerkadapters()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As netwerkadapters
        panelInstance = Nothing
    End Function
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub
    Private _Info As New InformationClass
    Dim hardware_group As New ListViewGroup("Adapter informatie")
    Dim besturingssysteem_group As New ListViewGroup("Selecteer een adapter:")
    Private Sub loaditems()
        Try
            ListViewInterface.Items.Clear()
            ' Show the wait form.

            Dim thread As Threading.Thread
            thread = New Threading.Thread(AddressOf Me.showform)
            thread.Start()

            ' Get Information
            Try
                _Info.Initialize(InformationClass.Initializers.GetNetAdaptorInfo)
                _Info.Initialize(InformationClass.Initializers.GetNetInterfaceInfo)
            Catch ex As Exception
                _Info.Initialize(InformationClass.Initializers.GetNetAdaptorInfo)
                _Info.Initialize(InformationClass.Initializers.GetNetInterfaceInfo)
            End Try


            Dim hardware_group As New ListViewGroup("Adapter informatie")
            Dim besturingssysteem_group As New ListViewGroup("Selecteer een adapter:")
            ListViewInterface.Groups.Add(hardware_group)
            ListViewInterface.Groups.Add(besturingssysteem_group)
            If CheckBox1.Checked = False Then
                For i = 0 To _Info.NetNumberOfAdapters - 1
                    Dim screenstring As String = _Info.NetProductName(i).ToLower
                    If screenstring.Contains("vmware") Or screenstring.Contains("wan") Or screenstring.Contains("logmein") Or screenstring.Contains("avast") Or screenstring.Contains("isatap") Then
                    Else
                        Dim str As ListViewItem = New ListViewItem(New String() {_Info.NetProductName(i)}, besturingssysteem_group)
                        ListViewInterface.Items.Add(str)
                    End If
                Next
            Else
                For i = 0 To _Info.NetNumberOfAdapters - 1
                    Dim str As ListViewItem = New ListViewItem(New String() {_Info.NetProductName(i)}, besturingssysteem_group)
                    ListViewInterface.Items.Add(str)
                Next
            End If
            thread.Abort()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub netwerk2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaditems()
    End Sub
    Private Sub ListViewInterface_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewInterface.SelectedIndexChanged
        Dim copy As String = Nothing
        Dim een As String = Nothing
        Dim twee As String
        For i As Integer = 0 To ListViewInterface.SelectedItems.Count - 1
            een = ListViewInterface.SelectedItems(i).Text
            twee = ListViewInterface.SelectedItems(i).SubItems(1).Text
        Next
        copy = een & ": " & twee
        Meer_info.copytext = copy


        ListView1.Items.Clear()
        If CheckBox1.Checked = False Then

        Else
            '''''''''test''''''
            For i As Integer = 0 To ListViewInterface.SelectedItems.Count - 1
                Meer_info.copytext = ListViewInterface.SelectedItems(i).Text
            Next

            'get listviews selected index
            If Me.ListViewInterface.SelectedIndices.Count <= 0 Then
                Return
            End If
            Dim selNdx = Me.ListViewInterface.SelectedIndices(0)
            If selNdx >= 0 Then
                Dim i As Integer = ListViewInterface.Items(selNdx).Index
                Dim manufacturer As ListViewItem = New ListViewItem(New String() {"Fabrikant", _Info.NetManufacturer.Item(i)})
                ListView1.Items.Add(manufacturer)
                Dim ikbeneenstring As ListViewItem = New ListViewItem(New String() {"Adapter Type", _Info.NetAdapterType.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Autosense", _Info.NetAutoSense.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Maximum Snelheid", _Info.NetMaxSpeed.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Snelheid", _Info.NetSpeed.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Verbindings ID", _Info.NetConnectionId.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Verbindings status", _Info.NetConnectionStatus.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"MAC Adres", _Info.NetMacAddress.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Ip adres", _Info.NetIPAddress.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"DNS host naam", _Info.NetHostName.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"DNS Domein", _Info.NetDomain.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"Aantal verbindingen", _Info.NetTcpNumConnections.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"TTL (Time-To-Live)", _Info.NetDefaultTtl.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"MTU ( Maximum Transmission Unit)", _Info.NetMtu.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                ikbeneenstring = New ListViewItem(New String() {"TCP venstergrootte", _Info.NetTcpWindowSize.Item(i)})
                ListView1.Items.Add(ikbeneenstring)
                If _Info.NetDhcpEnabled.Item(i) = True Then
                    Dim dhcp_group As New ListViewGroup("DHCP")
                    ListView1.Groups.Add(dhcp_group)
                    ikbeneenstring = New ListViewItem(New String() {"DHCP lease verkregen ", _Info.NetDhcpLeaseObtained.Item(i)}, dhcp_group)
                    ListView1.Items.Add(ikbeneenstring)
                    ikbeneenstring = New ListViewItem(New String() {"DHCP lease einde", _Info.NetDhcpLeaseExpires.Item(i)}, dhcp_group)
                    ListView1.Items.Add(ikbeneenstring)
                    ikbeneenstring = New ListViewItem(New String() {"DHCP server", _Info.NetDhcpServer.Item(i)}, dhcp_group)
                    ListView1.Items.Add(ikbeneenstring)
                End If
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        loaditems()
        If CheckBox1.Checked = False Then
            Label2.Show()
            ListView1.Items.Clear()
            ListView1.Visible = False
            ListViewInterface.Height = 498
        Else
            Label2.Hide()
            ListViewInterface.Height = 235
            ListView1.Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
       
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim copy As String = Nothing
        Dim een As String = Nothing
        Dim twee As String
        For i As Integer = 0 To ListView1.SelectedItems.Count - 1
            een = ListView1.SelectedItems(i).Text
            twee = ListView1.SelectedItems(i).SubItems(1).Text
        Next
        copy = een & ": " & twee
        Meer_info.copytext = copy
    End Sub
End Class

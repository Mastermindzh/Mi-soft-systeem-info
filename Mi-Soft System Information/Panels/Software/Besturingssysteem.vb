''Some code is not written by Rick van Lieshout from Mi-Soft but by:
'
'
' Copyright © 2006-2008 Herbert N Swearengen III (hswear3@swbell.net)
' All rights reserved.
'
' Redistribution and use in source and binary forms, with or without modification, 
' are permitted provided that the following conditions are met:
'
'   - Redistributions of source code must retain the above copyright notice, 
'     this list of conditions and the following disclaimer.
'
'   - Redistributions in binary form must reproduce the above copyright notice, 
'     this list of conditions and the following disclaimer in the documentation 
'     and/or other materials provided with the distribution.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
' ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
' IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
' INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
' NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
' OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
' WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
' ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
' OF SUCH DAMAGE.

Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Public Class Besturingssysteem
    Private Shared panelInstance As Besturingssysteem
    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Besturingssysteem
        If (panelInstance Is Nothing) Then
            panelInstance = New Besturingssysteem()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Besturingssysteem
        panelInstance = Nothing
    End Function
    Private _Info As New InformationClass

    Private Sub Besturingssysteem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim algemeen_group As New ListViewGroup("Algemeen")
        ListViewInfo.Groups.Add(algemeen_group)
        Dim netinfo_group As New ListViewGroup(".Net Framework informatie")
        ListViewInfo.Groups.Add(netinfo_group)
        If _Info.OSIs64Bit Then
            Dim osfullname As ListViewItem = New ListViewItem(New String() {"Volledige naam", GetOSFullName() & " (64-Bit)"}, algemeen_group)
            osfullname.ImageIndex = 0
            ListViewInfo.Items.Add(osfullname)
        Else
            Dim osfullname2 As ListViewItem = New ListViewItem(New String() {"Volledige naam", _Info.OSFullName & " (32-Bit)"}, algemeen_group)
            osfullname2.ImageIndex = 0
            ListViewInfo.Items.Add(osfullname2)
        End If
        Dim osversion As ListViewItem = New ListViewItem(New String() {"Versie", _Info.OSVersion}, algemeen_group)
        osversion.ImageIndex = 0
        ListViewInfo.Items.Add(osversion)
        Dim build As ListViewItem = New ListViewItem(New String() {"Build", GetOSBuild()}, algemeen_group)
        build.ImageIndex = 0
        ListViewInfo.Items.Add(build)
        Dim systemtype As ListViewItem = New ListViewItem(New String() {"Type", getSystemType2()}, algemeen_group)
        systemtype.ImageIndex = 0
        ListViewInfo.Items.Add(systemtype)
        Dim domain As ListViewItem = New ListViewItem(New String() {"Domain", GetOSDomain()}, algemeen_group)
        domain.ImageIndex = 0
        ListViewInfo.Items.Add(domain)
        Dim codename As ListViewItem = New ListViewItem(New String() {"Codename", GetOSCodename()}, algemeen_group)
        codename.ImageIndex = 0
        ListViewInfo.Items.Add(codename)
        Dim bootstate As ListViewItem = New ListViewItem(New String() {"Opstart modus", GetOSBootupState()}, algemeen_group)
        bootstate.ImageIndex = 0
        ListViewInfo.Items.Add(bootstate)
        If GetOSServicePack() = "" Then
            Dim sp As ListViewItem = New ListViewItem(New String() {"Service pack", "Geen servicepack geïnstalleerd."}, algemeen_group)
            sp.ImageIndex = 0
            ListViewInfo.Items.Add(sp)
        Else
            Dim sp As ListViewItem = New ListViewItem(New String() {"Service pack", GetOSServicePack()}, algemeen_group)
            sp.ImageIndex = 0
            ListViewInfo.Items.Add(sp)
        End If
        ''clean
        'Dim  As ListViewItem = New ListViewItem(New String() {"", })
        '.ImageIndex = 0
        'ListViewInfo.Items.Add()

        Dim OSinfoinfo As ListViewItem = New ListViewItem(New String() {"Versie", "Microsoft.NET Framework " & _Info.NetFrameworkVersion}, netinfo_group)
        OSinfoinfo.ImageIndex = 0
        ListViewInfo.Items.Add(OSinfoinfo)
        OSinfoinfo = New ListViewItem(New String() {"CLR Versie", _Info.ClrVersion}, netinfo_group)
        OSinfoinfo.ImageIndex = 0
        ListViewInfo.Items.Add(OSinfoinfo)
        If String.IsNullOrEmpty(_Info.ClrServicePack) Then

        Else
            OSinfoinfo = New ListViewItem(New String() {"Service Pack", _Info.ClrServicePack}, netinfo_group)
            OSinfoinfo.ImageIndex = 0
            ListViewInfo.Items.Add(OSinfoinfo)
        End If
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

Public Class stations
    Private Shared panelInstance As stations
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As stations
        If (panelInstance Is Nothing) Then
            panelInstance = New stations()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As stations
        panelInstance = Nothing
    End Function
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub
    Private Sub stations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim X As Integer
        Dim Y As Integer
        Dim index As Integer

        ' Show the wait form.

        Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()
        Application.DoEvents()

        ' Get Information
        _Info.Initialize(InformationClass.Initializers.GetDriveInformation)
        _Info.Initialize(InformationClass.Initializers.GetVolumeInfo)

        ' Clear ListViews
        ListViewVolumes.Items.Clear()
        ListViewDrives.Items.Clear()

        ' Fill Volume ListView
        If _Info.VolumeLetter IsNot Nothing Then
            For X = 0 To _Info.VolumeLetter.Count - 1
                ' Get image list index for drive type
                index = ReturnImageIndex(_Info.VolumeType.Item(X))
                ListViewVolumes.Items.Add(_Info.VolumeLetter.Item(X), index)

                If _Info.VolumeLabel IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeLabel.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumeFileSystem IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeFileSystem.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumeTotalSize IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeTotalSize.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumeUsedSpace IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeUsedSpace.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumeFreeSpace IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeFreeSpace.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumePercentFreeSpace IsNot Nothing Then
                    ListViewVolumes.Items(X).SubItems.Add(_Info.VolumePercentFreeSpace.Item(X))
                Else
                    ListViewVolumes.Items(X).SubItems.Add("N/A")
                End If

                If _Info.VolumeReady IsNot Nothing Then
                    If CBool(_Info.VolumeReady.Item(X)) = True Then
                        ListViewVolumes.Items(X).SubItems.Add("Y")
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N")
                    End If
                Else
                    ListViewVolumes.Items(X).SubItems.Add("U")
                End If

            Next X
        Else
            ListViewVolumes.Items.Add("")
            ListViewVolumes.Items(0).SubItems.Add("None")
        End If

        ' Add physical hard drive information
        If _Info.DriveCapacity IsNot Nothing Then
            For X = 0 To _Info.DriveCapacity.Count - 1

                If _Info.DriveInterface.Item(X).ToString().ToUpper().Contains("USB") Then
                    ' If the drive model includes "USB" use USB image.
                    ListViewDrives.Items.Add(CStr(X), 4)
                Else
                    ' Otherwise use hard drive image.
                    ListViewDrives.Items.Add(CStr(X), 1)
                End If

                If _Info.DriveInterface(X) <> "" Then
                    ListViewDrives.Items(X).SubItems.Add(_Info.DriveInterface.Item(X))
                Else
                    ListViewDrives.Items(X).SubItems.Add("N/A")
                End If

                If _Info.DriveCapacity(X) <> "" Then
                    ListViewDrives.Items(X).SubItems.Add(_Info.DriveCapacity.Item(X))
                Else
                    ListViewDrives.Items(X).SubItems.Add("N/A")
                End If

                If _Info.DriveModelNo(X) <> "" Then
                    ListViewDrives.Items(X).SubItems.Add(_Info.DriveModelNo.Item(X))
                Else
                    ListViewDrives.Items(X).SubItems.Add("N/A")
                End If

                If _Info.DriveStatus(X) <> "" Then
                    ListViewDrives.Items(X).SubItems.Add(_Info.DriveStatus.Item(X))
                Else
                    ListViewDrives.Items(X).SubItems.Add("")
                End If

            Next
        Else
            ListViewDrives.Items.Add("")
            ListViewDrives.Items(0).SubItems.Add("Not Available")
        End If

        ' Add CDROM drive information to the end of hard drives
        If _Info.CDDrive IsNot Nothing Then
            For Y = 0 To _Info.CDDrive.Count - 1

                ListViewDrives.Items.Add(CStr(Y + X), 3)

                ' Drive type (interface) is undefined for CD drives.
                ListViewDrives.Items(Y + X).SubItems.Add("")

                If _Info.CDMediaSize(Y) <> "" Then
                    ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDMediaSize.Item(Y))
                Else
                    ListViewDrives.Items(Y + X).SubItems.Add("")
                End If

                If _Info.CDModel(Y) <> "" Then
                    ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDModel.Item(Y))
                Else
                    ListViewDrives.Items(Y + X).SubItems.Add("N/A")
                End If

                If _Info.CDStatus(Y) <> "" Then
                    ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDStatus.Item(Y))
                Else
                    ListViewDrives.Items(Y + X).SubItems.Add("N/A")
                End If

            Next
        End If

        ' Close the wait form.
        thread.Abort()
    End Sub

    Private Shared Function ReturnImageIndex(ByVal strDriveType As String) As Integer

        Select Case strDriveType.ToLower
            Case "removable"
                Return 0
            Case "fixed"
                Return 1
            Case "network"
                Return 2
            Case "cdrom"
                Return 3
            Case "usb"
                Return 4
            Case Else
                Return 5
        End Select

    End Function
 
End Class

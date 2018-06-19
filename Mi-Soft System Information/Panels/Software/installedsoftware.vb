Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports Microsoft.VisualBasic.Devices
Imports EnumInstalledPrograms
Public Class installedsoftware
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub

    Private _Info As New InformationClass
    Private Shared panelInstance As installedsoftware
    Public Shared Function CreateInstance() As installedsoftware
        If (panelInstance Is Nothing) Then
            panelInstance = New installedsoftware()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As installedsoftware
        panelInstance = Nothing
    End Function
    Private Sub installedsoftware_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim rk As RegistryKey = Nothing
        Dim subKey As RegistryKey = Nothing
        Dim count As Integer                    ' Count of installed programs.
        Dim subKeyName As String
        Dim valueNames(200) As String           ' It is very, very unlikely that there will be 200 values.
        Dim appIcon As Icon                     ' Temporary variable for application icon.
        Dim iconPath As String                  ' Path to application icon.
        Dim iconIndex As Integer                ' Index to application icon in a dll or exe.
        Dim iconFound As Boolean                ' Indicates icon for application has been found.
        Dim folder As String                    ' Temporary variable for folders.

        ' Installed program data.
        Dim displayName As String
        Dim publisher As String
        Dim displayVersion As String
        Dim helpLink As String
        Dim helpTelephone As String
        Dim installDate As String
        Dim estimatedSize As String
        Dim tempDate As Date

        ' Programmer's comment: Wouldn't it be nice if everyone used the same installation standard?

        ' Show wait form.
        Dim thread As Threading.Thread
        thread = New Threading.Thread(AddressOf Me.showform)
        thread.Start()
        Application.DoEvents()

        ' Do this first for 32-bit programs.
        Try

            ' Image list and listview.
            ListViewPrograms.Items.Clear()
            SmallImageList.Images.Clear()

            ' Open the uninstall key. In 64-Bit systems, 32-Bit information is stored on a special key.
            ' But 32-Bit systems used the same key as 64-Bit systems.
            If _Info.OSIs64Bit Then
                rk = Registry.LocalMachine.OpenSubKey(_UninstallKey32Bit, False)
            Else
                rk = Registry.LocalMachine.OpenSubKey(_UninstallKey64Bit, False)
            End If

            ' Get all installed programs.
            For Each subKeyName In rk.GetSubKeyNames()

                ' Clear the system array holding the value names.
                Array.Clear(valueNames, 0, valueNames.Length)

                ' Open the sub key.
                If _Info.OSIs64Bit Then
                    subKey = Registry.LocalMachine.OpenSubKey(_UninstallKey32Bit & "\" & subKeyName, False)
                Else
                    subKey = Registry.LocalMachine.OpenSubKey(_UninstallKey64Bit & "\" & subKeyName, False)
                End If

                ' Iterate through all of the values
                If subKey.ValueCount > 0 Then

                    ' Save the value names in a system array.
                    valueNames = subKey.GetValueNames

                    ' Only display entries that are not system components.
                    If Array.IndexOf(valueNames, "SystemComponent") = -1 Then

                        ' Only add values that have a display name.
                        If Array.IndexOf(valueNames, "DisplayName") > 0 Then
                            ' Set iconFound to false since we have not found an icon for this item.
                            iconFound = False

                            ' Get the display name.
                            displayName = subKey.GetValue("DisplayName").ToString()

                            ' Get the publisher.
                            If Array.IndexOf(valueNames, "Publisher") > 0 Then
                                publisher = subKey.GetValue("Publisher").ToString()
                            Else
                                publisher = ""
                            End If

                            ' Get the display version.
                            If Array.IndexOf(valueNames, "DisplayVersion") > 0 Then
                                displayVersion = subKey.GetValue("DisplayVersion").ToString()
                            Else
                                displayVersion = ""
                            End If

                            ' Get the help link.
                            If Array.IndexOf(valueNames, "HelpLink") > 0 Then
                                helpLink = subKey.GetValue("HelpLink").ToString()
                            Else
                                helpLink = " "
                            End If

                            ' Get the help telephone.
                            If Array.IndexOf(valueNames, "HelpTelephone") > 0 Then
                                helpTelephone = subKey.GetValue("HelpTelephone").ToString()
                            Else
                                helpTelephone = ""
                            End If

                            ' Get the install date.
                            If Array.IndexOf(valueNames, "InstallDate") > 0 Then
                                installDate = subKey.GetValue("InstallDate").ToString()

                                Try
                                    If Not (installDate.Contains(",") Or installDate.Contains("/")) Then
                                        ' If the install date does not contains "/" or ",",
                                        ' assume that the date format is YYYYMMDD.
                                        installDate = New DateTime(CInt(installDate.Substring(0, 4)), CInt(installDate.Substring(4, 2)), CInt(installDate.Substring(6, 2))).ToLongDateString()
                                        ' Remove the day of the week.
                                        installDate = installDate.Remove(0, installDate.IndexOf(",") + 2)
                                    ElseIf installDate.Contains("/") Then
                                        ' Declare tempDate As Date at the top of the method.
                                        ' TryParse will place the Date of the string in local format in tempDate.
                                        DateTime.TryParse(installDate, tempDate)
                                        ' Use the Framework to extract a local long date string.
                                        installDate = tempDate.ToLongDateString()
                                        ' Remove the day of the week.
                                        installDate = installDate.Remove(0, installDate.IndexOf(",") + 2)
                                    End If
                                Catch ex As Exception
                                    installDate = ""
                                End Try
                            Else
                                installDate = ""
                            End If

                            ' Get the estimated size.
                            If Array.IndexOf(valueNames, "EstimatedSize") > 0 Then
                                ' EstimateSize is a DWORD, so it needs to be formatted as megabytes.
                                estimatedSize = String.Format("{0:N2}", _
                                    CDbl(subKey.GetValue("EstimatedSize")) / 1024) & " MB"
                            Else
                                estimatedSize = ""
                            End If

                            ' If there is a display icon, and add to image list.
                            If Array.IndexOf(valueNames, "DisplayIcon") > 0 Then
                                Try
                                    iconPath = subKey.GetValue("DisplayIcon").ToString()

                                    If String.IsNullOrEmpty(iconPath) Then

                                        iconFound = False

                                    ElseIf iconPath.Contains(",") Then

                                        ' Check if DisplayIcon contain an icon indes.
                                        iconIndex = CInt(iconPath.Substring(iconPath.IndexOf(",") + 1, 1))
                                        iconPath = iconPath.Substring(0, iconPath.IndexOf(",") - 1)

                                        ' Get the icon.
                                        appIcon = _Native.GetIcon(iconPath, iconIndex)

                                        If appIcon IsNot Nothing Then
                                            ' Add the icon to the both the small and image lists.
                                            AddIcon(appIcon)
                                            iconFound = True
                                        End If
                                    Else
                                        ' Get the icon.
                                        appIcon = _Native.GetIcon(iconPath)

                                        If appIcon IsNot Nothing Then
                                            ' Add the icon to the both the small and image lists.
                                            AddIcon(appIcon)
                                            iconFound = True
                                        End If
                                    End If
                                Catch ex As Exception
                                    iconFound = False
                                End Try
                            End If ' If there is a display icon, and add to image list.

                            ' Now try searching in Program Files for the Publisher\Display Name.
                            folder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                                    "\" & publisher & "\" & displayName

                            If iconFound = False Then
                                ' Look for executible files first.
                                iconFound = SearchFolder(folder, "*.exe", True)
                            End If

                            If iconFound = False Then
                                ' Look for icon files next.
                                iconFound = SearchFolder(folder, "*.ico", True)
                            End If

                            ' Next try searching in Program Files for the  just the Display Name.
                            folder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                                     "\" & displayName

                            If iconFound = False Then
                                ' Look for executible files first.
                                iconFound = SearchFolder(folder, "*.exe", True)
                            End If

                            If iconFound = False Then
                                ' Look for icon files next.
                                iconFound = SearchFolder(folder, "*.ico", True)
                            End If

                            ' Finally, check uninstall key that begin with "{" because icons for
                            ' Windows Installer installations may be stored in WINDOWS\Installer\KeyName.
                            If subKeyName.StartsWith("{") And iconFound = False Then

                                folder = Environment.GetEnvironmentVariable("windir") & "\Installer\" & subKeyName

                                If Directory.Exists(folder) Then
                                    If iconFound = False Then
                                        ' Look for an executible file first.
                                        iconFound = SearchFolder(folder, "*.exe", False)
                                    End If

                                    If iconFound = False Then
                                        ' Look for an an icon file next.
                                        iconFound = SearchFolder(folder, "*.ico", False)
                                    End If

                                    If iconFound = False Then
                                        ' Look for an an file that contains "ArpIco" next.
                                        iconFound = SearchFolder(folder, "*ArpIco*", False)
                                    End If

                                End If ' Check uninstall key that begin with "{".
                            End If

                            ' If no icon was found, add a blank icon.
                            If iconFound = False Then
                                AddBlankIcon()
                            End If

                            ' Add the display name and icon, if present, to the listview.
                            ListViewPrograms.Items.Add(displayName, count)

                            ' Add the other entries as subitems.
                            ListViewPrograms.Items(count).SubItems.Add(publisher)
                            ListViewPrograms.Items(count).SubItems.Add(displayVersion)
                            ListViewPrograms.Items(count).SubItems.Add(helpLink)
                            ListViewPrograms.Items(count).SubItems.Add(helpTelephone)
                            ListViewPrograms.Items(count).SubItems.Add(installDate)
                            ListViewPrograms.Items(count).SubItems.Add(estimatedSize)
                            ListViewPrograms.Items(count).SubItems.Add(CStr(count))    ' Icon Number.

                            count += 1

                        End If ' Only add values that have a display name.
                    End If ' Only display entries that are not system components.
                End If ' Iterate through all of the values
            Next ' Get all installed programs.

        Catch ex As NullReferenceException
            ' Do nothing.
        Catch ex As FormatException
            ' Do nothing.
        Catch ex As Exception
         
        Finally
            If rk IsNot Nothing Then
                ' Close the registry key.
                rk.Close()
            End If
            If subKey IsNot Nothing Then
                'Close the registry key.
                subKey.Close()
            End If
            If waitform.Visible Then
                If Not _Info.OSIs64Bit Then thread.Abort()
            End If
        End Try

        ' Display total items.
        If Not _Info.OSIs64Bit Then labelNumberPrograms.Text = (count - 1).ToString() & " Items"

        ' Sort the listview.
        If Not _Info.OSIs64Bit Then
            ListViewPrograms.Sorting = SortOrder.Ascending
            ListViewPrograms.Sort()
        End If

        Try
            If _Info.OSIs64Bit Then
                ' Do this first next 64-bit programs.

                ' Open the uninstall key.
                rk = Registry.LocalMachine.OpenSubKey(_UninstallKey64Bit, False)

                ' Get all installed programs.
                For Each subKeyName In rk.GetSubKeyNames()

                    ' Clear the system array holding the value names.
                    Array.Clear(valueNames, 0, valueNames.Length)

                    ' Open the sub key.
                    subKey = Registry.LocalMachine.OpenSubKey(_UninstallKey64Bit & "\" & subKeyName, False)

                    ' Iterate through all of the values
                    If subKey.ValueCount > 0 Then

                        ' Save the value names in a system array.
                        valueNames = subKey.GetValueNames

                        ' Only display entries that are not system components.
                        If Array.IndexOf(valueNames, "SystemComponent") = -1 Then

                            ' Only add values that have a display name.
                            If Array.IndexOf(valueNames, "DisplayName") > 0 Then

                                ' Set iconFound to false since we have not found an icon for this item.
                                iconFound = False

                                ' Get the display name.
                                displayName = subKey.GetValue("DisplayName").ToString()

                                ' Get the publisher.
                                If Array.IndexOf(valueNames, "Publisher") > 0 Then
                                    publisher = subKey.GetValue("Publisher").ToString()
                                Else
                                    publisher = ""
                                End If

                                ' Get the display version.
                                If Array.IndexOf(valueNames, "DisplayVersion") > 0 Then
                                    displayVersion = subKey.GetValue("DisplayVersion").ToString()
                                Else
                                    displayVersion = ""
                                End If

                                ' Get the help link.
                                If Array.IndexOf(valueNames, "HelpLink") > 0 Then
                                    helpLink = subKey.GetValue("HelpLink").ToString()
                                Else
                                    helpLink = ""
                                End If

                                ' Get the help telephone.
                                If Array.IndexOf(valueNames, "HelpTelephone") > 0 Then
                                    helpTelephone = subKey.GetValue("HelpTelephone").ToString()
                                Else
                                    helpTelephone = ""
                                End If

                                ' Get the install date.
                                If Array.IndexOf(valueNames, "InstallDate") > 0 Then
                                    installDate = subKey.GetValue("InstallDate").ToString()

                                    If Not (installDate.Contains(",") Or installDate.Contains("/")) Then
                                        ' If the install date does not contains "/" or ",",
                                        ' assume that the date format is YYYYMMDD.
                                        installDate = New DateTime(CInt(installDate.Substring(0, 4)), CInt(installDate.Substring(4, 2)), CInt(installDate.Substring(6, 2))).ToLongDateString()
                                        ' Remove the day of the week.
                                        installDate = installDate.Remove(0, installDate.IndexOf(",") + 2)
                                    ElseIf installDate.Contains("/") Then
                                        ' Declare tempDate As Date at the top of the method.
                                        ' TryParse will place the Date of the string in local format in tempDate.
                                        DateTime.TryParse(installDate, tempDate)
                                        ' Use the Framework to extract a local long date string.
                                        installDate = tempDate.ToLongDateString()
                                        ' Remove the day of the week.
                                        installDate = installDate.Remove(0, installDate.IndexOf(",") + 2)
                                    End If

                                Else
                                    installDate = ""
                                End If

                                ' Get the estimated size.
                                If Array.IndexOf(valueNames, "EstimatedSize") > 0 Then
                                    ' EstimateSize is a DWORD, so it needs to be formatted as megabytes.
                                    estimatedSize = String.Format("{0:N2}", _
                                        CDbl(subKey.GetValue("EstimatedSize")) / 1024) & " MB"
                                Else
                                    estimatedSize = ""
                                End If

                                ' If there is a display icon, and add to image list.
                                If Array.IndexOf(valueNames, "DisplayIcon") > 0 Then

                                    iconPath = subKey.GetValue("DisplayIcon").ToString()

                                    If String.IsNullOrEmpty(iconPath) Then

                                        iconFound = False

                                    ElseIf iconPath.Contains(",") Then

                                        ' Check if DisplayIcon contain an icon indes.
                                        iconIndex = CInt(iconPath.Substring(iconPath.IndexOf(",") + 1, 1))
                                        iconPath = iconPath.Substring(0, iconPath.IndexOf(",") - 1)

                                        ' Get the icon.
                                        appIcon = _Native.GetIcon(iconPath, iconIndex)

                                        If appIcon IsNot Nothing Then
                                            ' Add the icon to the both the small and image lists.
                                            AddIcon(appIcon)
                                            iconFound = True
                                        End If
                                    Else
                                        ' Get the icon.
                                        appIcon = _Native.GetIcon(iconPath)

                                        If appIcon IsNot Nothing Then
                                            ' Add the icon to the both the small and image lists.
                                            AddIcon(appIcon)
                                            iconFound = True
                                        End If
                                    End If

                                End If ' If there is a display icon, and add to image list.

                                ' Now try searching in Program Files for the Publisher\Display Name.
                                folder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                                        "\" & publisher & "\" & displayName

                                If iconFound = False Then
                                    ' Look for executible files first.
                                    iconFound = SearchFolder(folder, "*.exe", True)
                                End If

                                If iconFound = False Then
                                    ' Look for icon files next.
                                    iconFound = SearchFolder(folder, "*.ico", True)
                                End If

                                ' Next try searching in Program Files for the  just the Display Name.
                                folder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                                         "\" & displayName

                                If iconFound = False Then
                                    ' Look for executible files first.
                                    iconFound = SearchFolder(folder, "*.exe", True)
                                End If

                                If iconFound = False Then
                                    ' Look for icon files next.
                                    iconFound = SearchFolder(folder, "*.ico", True)
                                End If

                                ' Finally, check uninstall key that begin with "{" because icons for
                                ' Windows Installer installations may be stored in WINDOWS\Installer\KeyName.
                                If subKeyName.StartsWith("{") And iconFound = False Then

                                    folder = Environment.GetEnvironmentVariable("windir") & "\Installer\" _
                                        & subKeyName

                                    If Directory.Exists(folder) Then
                                        If iconFound = False Then
                                            ' Look for an executible file first.
                                            iconFound = SearchFolder(folder, "*.exe", False)
                                        End If

                                        If iconFound = False Then
                                            ' Look for an an icon file next.
                                            iconFound = SearchFolder(folder, "*.ico", False)
                                        End If

                                        If iconFound = False Then
                                            ' Look for an an file that contains "ArpIco" next.
                                            iconFound = SearchFolder(folder, "*ArpIco*", False)
                                        End If

                                    End If ' Check uninstall key that begin with "{".
                                End If

                                ' If no icon was found, add a blank icon.
                                If iconFound = False Then
                                    AddBlankIcon()
                                End If

                                ' Add the display name and icon, if present, to the listview.
                                ListViewPrograms.Items.Add(displayName, count)

                                ' Add the other entries as subitems.
                                ListViewPrograms.Items(count).SubItems.Add(publisher)
                                ListViewPrograms.Items(count).SubItems.Add(displayVersion)
                                ListViewPrograms.Items(count).SubItems.Add(helpLink)
                                ListViewPrograms.Items(count).SubItems.Add(helpTelephone)
                                ListViewPrograms.Items(count).SubItems.Add(installDate)
                                ListViewPrograms.Items(count).SubItems.Add(estimatedSize)
                                ListViewPrograms.Items(count).SubItems.Add(CStr(count))    ' Icon Number.

                                ' Bump count of programs.
                                count += 1

                            End If ' Only add values that have a display name.
                        End If ' Only display entries that are not system components.
                    End If ' Iterate through all of the values
                Next ' Get all installed programs.

                ' Display total items.
                labelNumberPrograms.Text = (count - 1).ToString() & " Items"

                ' Sort the listview.
                ListViewPrograms.Sorting = SortOrder.Ascending
                ListViewPrograms.Sort()

            End If
        Catch ex As NullReferenceException
            ' Do nothing.
            MsgBox(ex.Message)
        Catch ex As FormatException
            ' Do nothing.
            MsgBox(ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Installed Programs panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        Finally

            If rk IsNot Nothing Then
                ' Close the registry key.
                rk.Close()
            End If

            If subKey IsNot Nothing Then
                'Close the registry key.
                subKey.Close()
            End If
            RemoveDuplicates()
            If waitform.Visible Then
                thread.Abort()
            End If

        End Try

    End Sub
  
  
    Function RemoveDuplicates() As Boolean
        Dim lstview = ListViewPrograms
        Dim itemI As ListViewItem
        Dim itemJ As ListViewItem
        Dim progress As Integer
        Dim count As Integer
        Dim ProgressDupCounter As Integer = lstview.Items.Count
        For i As Integer = lstview.Items.Count - 1 To 0 Step -1
            itemI = lstview.Items(i)
            progress = progress + 1
            ' start one after hence +1
            For z As Integer = i + 1 To lstview.Items.Count - 1 Step 1
                itemJ = lstview.Items(z)
                If itemI.Text = itemJ.Text Then
                    'duplicate found, now delete duplicate
                    lstview.Items.Remove(itemJ)
                    count = count + 1
                    Exit For
                End If
            Next z
        Next (i)

    End Function

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("appwiz.cpl")
    End Sub



#Region " ListView Events "

    Private Sub ListViewPrograms_ItemSelectionChanged(ByVal sender As Object, _
         ByVal e As ListViewItemSelectionChangedEventArgs) Handles ListViewPrograms.ItemSelectionChanged

        Try

            If e.IsSelected Then

                ' Get the index of the selected item in the listview.
                Dim i As Integer = e.ItemIndex

                ' All of the information is stored in the listview.
                ' Some items have 0 width, so they do not display.
                LabelDisplayName.Text = ListViewPrograms.Items(i).Text

                ' Hide values if they are not available.
                If ListViewPrograms.Items(i).SubItems.Count > 1 Then
                    If String.IsNullOrEmpty(ListViewPrograms.Items(i).SubItems(2).Text) Then
                        LabelDisplayVersionDesc.Visible = False
                        LabelDisplayVersion.Visible = False
                        LabelDisplayVersion.Text = ""
                    Else
                        LabelDisplayVersionDesc.Visible = True
                        LabelDisplayVersion.Visible = True
                        LabelDisplayVersion.Text = ListViewPrograms.Items(i).SubItems(2).Text
                    End If
                End If

                If ListViewPrograms.Items(i).SubItems.Count > 2 Then
                    If String.IsNullOrEmpty(ListViewPrograms.Items(i).SubItems(3).Text) Then
                        LabelHelpLinkDesc.Visible = False
                        LinkLabelHelpLink.Visible = False
                        LinkLabelHelpLink.Text = ""
                    Else
                        LabelHelpLinkDesc.Visible = True
                        LinkLabelHelpLink.Visible = True
                        LinkLabelHelpLink.Text = ListViewPrograms.Items(i).SubItems(3).Text
                    End If
                End If

                If ListViewPrograms.Items(i).SubItems.Count > 3 Then
                    If String.IsNullOrEmpty(ListViewPrograms.Items(i).SubItems(4).Text) Then
                        LabelHelpTelephoneDesc.Visible = False
                        LabelHelpTelephone.Visible = False
                        LabelHelpTelephone.Text = ""
                    Else
                        LabelHelpTelephoneDesc.Visible = False
                        LabelHelpTelephone.Visible = False
                        LabelHelpTelephone.Text = ListViewPrograms.Items(i).SubItems(4).Text
                    End If
                End If

                If ListViewPrograms.Items(i).SubItems.Count > 4 Then
                    If String.IsNullOrEmpty(ListViewPrograms.Items(i).SubItems(5).Text) Then
                        LabelInstallDateDesc.Visible = False
                        LabelInstallDate.Visible = False
                        LabelInstallDate.Text = ""
                    Else
                        LabelInstallDateDesc.Visible = False
                        LabelInstallDate.Visible = False
                        LabelInstallDate.Text = ListViewPrograms.Items(i).SubItems(5).Text
                    End If
                End If

                If ListViewPrograms.Items(i).SubItems.Count > 5 Then
                    If String.IsNullOrEmpty(ListViewPrograms.Items(i).SubItems(6).Text) Then
                        LabelEstSizeDesc.Visible = False
                        LabelEstimatedSize.Visible = False
                        LabelEstimatedSize.Text = ""
                    Else
                        LabelEstSizeDesc.Visible = True
                        LabelEstimatedSize.Visible = True
                        LabelEstimatedSize.Text = ListViewPrograms.Items(i).SubItems(6).Text
                    End If
                End If

                ' Display the picture.
                PictureBoxProgram.BackgroundImageLayout = ImageLayout.Stretch
                If ListViewPrograms.Items(i).SubItems.Count > 6 Then
                    PictureBoxProgram.BackgroundImage = LargeImageList.Images.Item(CInt(ListViewPrograms.Items(i).SubItems(7).Text))
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Installed Programs ListView." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Set the ListViewItemSorter property to a new ListViewItemComparer 
    ''' object. Setting this property immediately sorts the 
    ''' ListView using the ListViewItemComparer object.
    ''' </summary>
    Private Sub ListViewPrograms_ColumnClick(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ColumnClickEventArgs)

        ' Toggle sort order.
        If _Ascending = False Then
            _Ascending = True
        Else
            _Ascending = False
        End If

        ' Perform sort of items in specified column.
        ListViewPrograms.ListViewItemSorter = New ListViewItemComparer(e.Column, _Ascending)

    End Sub

#End Region

#Region " Methods "

    ''' <summary>
    ''' Adds a icon to both image lists.
    ''' </summary>
    ''' <param name="newIcon">Icon to be added.</param>
    Private Sub AddIcon(ByVal newIcon As Icon)

        ' Add the icon to the small image list.
        SmallImageList.Images.Add(newIcon)

        ' Also add the icon to the large image list.
        LargeImageList.Images.Add(newIcon)

    End Sub

    ''' <summary>
    ''' Adds a blank icon to both image lists.
    ''' </summary>
    Private Sub AddBlankIcon()

        ' Add a blank icon to the small image list.
        SmallImageList.Images.Add(My.Resources.system_help__1_)

        ' Add a blank icon to the large image list.
        LargeImageList.Images.Add(My.Resources.system_help__1_)

    End Sub

    ''' <summary>
    ''' Search folder using search pattern. If icon is found, it is added to both image lists.
    ''' </summary>
    ''' <param name="folder">Folder to be searched.</param>
    ''' <param name="searchPattern">Matching pattern</param>
    ''' <param name="searchSubDirs">If true, subdirectories are also searched.</param>
    ''' <returns>Return true if icon is found.</returns>
    Private Function SearchFolder(ByVal folder As String, ByVal searchPattern As String, _
        ByVal searchSubDirs As Boolean) As Boolean

        Dim iconPath As String
        Dim appIcon As Icon
        Dim found As Boolean
        Dim searchOpt As SearchOption

        ' Change a boolean method parameter to a SearchOption.
        If searchSubDirs Then
            searchOpt = SearchOption.AllDirectories
        Else
            searchOpt = SearchOption.TopDirectoryOnly
        End If

        ' Verify that the folder exists.
        If Directory.Exists(folder) Then

            For Each iconPath In Directory.GetFiles(folder, searchPattern, searchOpt)

                If iconPath.Contains("Adobe.ico") Or iconPath.Contains("GAC.exe") Then
                    ' Skip these files that are common on my computer. Add additional ones as you desire.
                ElseIf iconPath.Length <= _MaxPath And File.Exists(iconPath) Then
                    ' Check to make sure the file is a valid icon.
                    appIcon = _Native.GetIcon(iconPath)
                    If appIcon IsNot Nothing Then
                        AddIcon(appIcon)
                        found = True
                        Exit For           ' This exit for must be here for this to work!
                    Else
                        found = False
                    End If
                End If
            Next

        Else
            ' If directory is not valid, return false.
            found = False
        End If

        ' Return result
        Return found

    End Function

#End Region

#Region " Link Label Events "

    Private Sub LinkLabelHelpLink_LinkClicked(ByVal sender As System.Object, ByVal e As  _
        System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        ' Open the link in the default browser.
        Try
            Dim startInfo As New ProcessStartInfo(LinkLabelHelpLink.Text)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)
        Catch
            ' cannot find file
            MessageBox.Show("Unable to open website.", Application.ProductName, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

#End Region

#Region " Constants and Variables "

    Private Const _UninstallKey64Bit As String = "Software\Microsoft\Windows\CurrentVersion\Uninstall"
    Private Const _UninstallKey32Bit As String = "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
    Private Const _MaxPath As Integer = 255
    Private _Ascending As Boolean        ' Used to toggle listview sorting.

    Private _Native As New NativeMethods

#End Region

    Private Sub ListViewPrograms_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewPrograms.SelectedIndexChanged
        Dim copy As String = Nothing
        Dim een As String = Nothing
        Dim twee As String
        For i As Integer = 0 To ListViewPrograms.SelectedItems.Count - 1
            een = ListViewPrograms.SelectedItems(i).Text
            twee = ListViewPrograms.SelectedItems(i).SubItems(1).Text
        Next
        copy = een & ": " & twee
        Meer_info.copytext = copy
    End Sub
End Class

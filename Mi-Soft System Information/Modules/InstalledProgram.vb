Imports Microsoft.Win32

''' <summary>
''' Represents a program that is installed on a PC
''' </summary>
Public Class InstalledProgram : Implements IComparable(Of InstalledProgram) : Implements IEquatable(Of InstalledProgram)


#Region "Properties"

    Private _DisplayName As String = String.Empty
    ''' <summary>
    ''' The name that would be displayed in Add/Remove Programs
    ''' </summary>
    Public Property DisplayName() As String
        Get
            Return _DisplayName
        End Get
        Set(ByVal value As String)
            _DisplayName = value
        End Set
    End Property

    Private _Version As String = String.Empty
    ''' <summary>
    ''' The version of the program
    ''' </summary>
    Public Property Version() As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property

    Private _ParentDisplayName As String = String.Empty
    ''' <summary>
    ''' If this program is an update then this will contain the display name of the product that 
    ''' this is an update to
    ''' </summary>
    Public Property ParentDisplayName() As String
        Get
            Return _ParentDisplayName
        End Get
        Set(ByVal value As String)
            _ParentDisplayName = value
        End Set
    End Property

    Private _IsUpdate As Boolean
    ''' <summary>
    ''' Is this program classed as an update 
    ''' </summary>
    Public Property IsUpdate() As Boolean
        Get
            Return _IsUpdate
        End Get
        Set(ByVal value As Boolean)
            _IsUpdate = value
        End Set
    End Property


#End Region

#Region "Constructors"

    Public Sub New(ByVal ProgramDisplayName As String)
        Me.DisplayName = ProgramDisplayName
    End Sub

    Public Sub New(ByVal ProgramDisplayName As String, ByVal ProgramParentDisplayName As String, ByVal IsProgramUpdate As Boolean, ByVal ProgramVersion As String)
        Me.DisplayName = ProgramDisplayName
        Me.ParentDisplayName = ProgramParentDisplayName
        Me.IsUpdate = IsProgramUpdate
        Me.Version = ProgramVersion
    End Sub

#End Region

#Region "Public Methods"

    Public Overrides Function ToString() As String
        Return DisplayName
    End Function

    ''' <summary>
    ''' Retrieves a list of all installed programs on the local computer
    ''' </summary>
    Public Shared Function GetInstalledPrograms(ByVal IncludeUpdates As Boolean) As List(Of InstalledProgram)
        Return InternalGetInstalledPrograms(IncludeUpdates, My.Computer.Registry.LocalMachine, My.Computer.Registry.Users)
    End Function

    ''' <summary>
    ''' Retrieves a list of all installed programs on the specified computer
    ''' </summary>
    ''' <param name="ComputerName">The name of the computer to get the list of installed programs from</param>
    ''' <param name="IncludeUpdates">Determines whether or not updates for installed programs are included in the list</param>
    Public Shared Function GetInstalledPrograms(ByVal ComputerName As String, ByVal IncludeUpdates As Boolean) As List(Of InstalledProgram)
        Try
            Return InternalGetInstalledPrograms(IncludeUpdates, RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, ComputerName), RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, ComputerName))
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return New List(Of InstalledProgram)
        End Try
    End Function

    'Sorting function, required by IComparable interface
    Public Function CompareTo(ByVal other As InstalledProgram) As Integer Implements System.IComparable(Of InstalledProgram).CompareTo
        Return String.Compare(Me.DisplayName, other.DisplayName)
    End Function

    'Equality function, required by IEquatable interface
    Public Function Equals1(ByVal other As InstalledProgram) As Boolean Implements System.IEquatable(Of InstalledProgram).Equals
        If Me.DisplayName = other.DisplayName AndAlso Me.Version = other.Version Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Private Methods"

    Private Shared Function InternalGetInstalledPrograms(ByVal IncludeUpdates As Boolean, ByVal HklmPath As RegistryKey, ByVal HkuPath As RegistryKey) As List(Of InstalledProgram)
        Dim ProgramList As New List(Of InstalledProgram)

        Dim ClassesKey As RegistryKey = HklmPath.OpenSubKey("Software\Classes\Installer\Products")

        '---Wow64 Uninstall key
        Dim Wow64UninstallKey As RegistryKey = HklmPath.OpenSubKey("Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall")
        ProgramList = GetUninstallKeyPrograms(Wow64UninstallKey, ClassesKey, ProgramList, IncludeUpdates)

        '---Standard Uninstall key
        Dim StdUninstallKey As RegistryKey = HklmPath.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall")
        ProgramList = GetUninstallKeyPrograms(StdUninstallKey, ClassesKey, ProgramList, IncludeUpdates)

        For Each UserSid As String In HkuPath.GetSubKeyNames
            '---HKU Uninstall key
            Dim CuUnInstallKey As RegistryKey = HkuPath.OpenSubKey(UserSid & "\Software\Microsoft\Windows\CurrentVersion\Uninstall")
            ProgramList = GetUninstallKeyPrograms(CuUnInstallKey, ClassesKey, ProgramList, IncludeUpdates)
            '---HKU Installer key
            Dim CuInstallerKey As RegistryKey = HkuPath.OpenSubKey(UserSid & "\Software\Microsoft\Installer\Products")
            ProgramList = GetUserInstallerKeyPrograms(CuInstallerKey, HklmPath, ProgramList)
        Next

        'Close the registry keys
        Try
            HklmPath.Close()
            HkuPath.Close()
        Catch ex As Exception
            Debug.WriteLine("Error closing registry key - " & ex.Message)
        End Try

        'Sort the list alphabetically and return it to the caller
        ProgramList.Sort()
        Return ProgramList
    End Function

    Private Shared Function IsProgramInList(ByVal ProgramName As String, ByVal ListToCheck As List(Of InstalledProgram)) As Boolean
        Return ListToCheck.Contains(New InstalledProgram(ProgramName))
    End Function

    Private Shared Function GetUserInstallerKeyPrograms(ByVal CuInstallerKey As RegistryKey, ByVal HklmRootKey As RegistryKey, ByVal ExistingProgramList As List(Of InstalledProgram)) As List(Of InstalledProgram)
        If Not CuInstallerKey Is Nothing Then
            For Each CuProductGuid As String In CuInstallerKey.GetSubKeyNames
                Dim ProductFound As Boolean = False
                For Each UserDataKeyName As String In HklmRootKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Installer\UserData").GetSubKeyNames
                    If Not UserDataKeyName = "S-1-5-18" Then 'Ignore the LocalSystem account
                        Dim ProductsKey As RegistryKey = HklmRootKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Installer\UserData\" & UserDataKeyName & "\Products")
                        If Not ProductsKey Is Nothing Then
                            Dim LmProductGuids() As String = ProductsKey.GetSubKeyNames
                            For Each LmProductGuid As String In LmProductGuids
                                If LmProductGuid = CuProductGuid Then
                                    Dim UserDataProgramKey As RegistryKey = HklmRootKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Installer\UserData\" & UserDataKeyName & "\Products\" & LmProductGuid & "\InstallProperties")
                                    If Not CInt(UserDataProgramKey.GetValue("SystemComponent", 0)) = 1 Then
                                        Dim Name As String = CStr(CuInstallerKey.OpenSubKey(CuProductGuid).GetValue("ProductName", String.Empty))
                                        Dim ProgVersion As String = String.Empty
                                        Try
                                            ProgVersion = CStr(UserDataProgramKey.GetValue("DisplayVersion", String.Empty))
                                        Catch ex As Exception
                                            Debug.WriteLine(ex.Message)
                                        End Try
                                        If Not Name = String.Empty AndAlso Not IsProgramInList(Name, ExistingProgramList) Then
                                            ExistingProgramList.Add(New InstalledProgram(Name))
                                            ProductFound = True
                                        End If
                                    End If
                                    Exit For
                                End If
                            Next
                            If ProductFound Then
                                Exit For
                            End If
                            Try
                                ProductsKey.Close()
                            Catch ex As Exception
                                Debug.WriteLine(ex.Message)
                            End Try
                        End If
                    End If
                Next
            Next
        End If
        Return ExistingProgramList
    End Function

    Private Shared Function GetUninstallKeyPrograms(ByVal UninstallKey As RegistryKey, ByVal ClassesKey As RegistryKey, ByVal ExistingProgramList As List(Of InstalledProgram), ByVal IncludeUpdates As Boolean) As List(Of InstalledProgram)
        'Make sure the key exists
        If Not UninstallKey Is Nothing Then
            'Loop through all subkeys (each one represents an installed program)
            For Each SubKeyName As String In UninstallKey.GetSubKeyNames
                Try
                    Dim CurrentSubKey As RegistryKey = UninstallKey.OpenSubKey(SubKeyName)
                    'Skip this program if the SystemComponent flag is set
                    Dim IsSystemComponent As Integer = 0
                    Dim ErrorCheckingSystemComponent As Boolean = False
                    Try
                        IsSystemComponent = CInt(CurrentSubKey.GetValue("SystemComponent", 0))
                    Catch ex As Exception
                        Debug.WriteLine(SubKeyName & " - " & ex.Message)
                    End Try
                    If Not IsSystemComponent = 1 Then
                        'If the WindowsInstaller flag is set then add the key name to our list of Windows Installer GUIDs
                        If Not CInt(CurrentSubKey.GetValue("WindowsInstaller", 0)) = 1 Then
                            Dim WindowsUpdateRegEx As New System.Text.RegularExpressions.Regex("KB[0-9]{6}$")
                            Dim ProgramReleaseType As String = CStr(CurrentSubKey.GetValue("ReleaseType", String.Empty))
                            Dim ProgVersion As String = String.Empty
                            Try
                                ProgVersion = CStr(CurrentSubKey.GetValue("DisplayVersion", String.Empty))
                            Catch ex As Exception
                                Debug.WriteLine(SubKeyName & " - " & ex.Message)
                            End Try
                            'Check to see if this program is classed as an update
                            If WindowsUpdateRegEx.Match(SubKeyName).Success = True OrElse Not CStr(CurrentSubKey.GetValue("ParentKeyName", String.Empty)) = String.Empty OrElse _
                                    ProgramReleaseType = "Security Update" OrElse ProgramReleaseType = "Update Rollup" OrElse _
                                    ProgramReleaseType = "Hotfix" Then
                                If IncludeUpdates Then
                                    'Add the program to our list if we are including updates in this search
                                    Dim Name As String = CStr(CurrentSubKey.GetValue("DisplayName", String.Empty))
                                    If Not Name = String.Empty AndAlso Not IsProgramInList(Name, ExistingProgramList) Then
                                        ExistingProgramList.Add(New InstalledProgram(Name, CStr(CurrentSubKey.GetValue("ParentDisplayName", String.Empty)), True, ProgVersion))
                                    End If
                                End If
                            Else 'If not classed as an update
                                Dim UninstallStringExists As Boolean = False
                                For Each valuename As String In CurrentSubKey.GetValueNames
                                    If String.Equals("UninstallString", valuename, StringComparison.CurrentCultureIgnoreCase) Then
                                        UninstallStringExists = True
                                        Exit For
                                    End If
                                Next
                                If UninstallStringExists Then
                                    Dim Name As String = CStr(CurrentSubKey.GetValue("DisplayName", String.Empty))
                                    If Not Name = String.Empty AndAlso Not IsProgramInList(Name, ExistingProgramList) Then
                                        ExistingProgramList.Add(New InstalledProgram(Name, CStr(CurrentSubKey.GetValue("ParentDisplayName", String.Empty)), False, ProgVersion))
                                    End If
                                End If
                            End If
                        Else 'If WindowsInstaller
                            Dim ProgVersion As String = String.Empty
                            Dim Name As String = String.Empty
                            Dim FoundName As Boolean = False
                            Try
                                Dim MsiKeyName As String = GetInstallerKeyNameFromGuid(SubKeyName)
                                Dim CrGuidKey As RegistryKey = ClassesKey.OpenSubKey(MsiKeyName)
                                If Not CrGuidKey Is Nothing Then
                                    Name = CStr(CrGuidKey.GetValue("ProductName", String.Empty))
                                End If
                            Catch ex As Exception
                                Debug.WriteLine(SubKeyName & " - " & ex.Message)
                            End Try
                            Try
                                ProgVersion = CStr(CurrentSubKey.GetValue("DisplayVersion", String.Empty))
                            Catch ex As Exception
                                Debug.WriteLine(ex.Message)
                            End Try
                            If Not Name = String.Empty AndAlso Not IsProgramInList(Name, ExistingProgramList) Then
                                ExistingProgramList.Add(New InstalledProgram(Name, CStr(CurrentSubKey.GetValue("ParentDisplayName", String.Empty)), False, ProgVersion))
                            End If
                        End If
                    End If
                Catch ex As Exception
                    Debug.WriteLine(SubKeyName & " - " & ex.Message)
                End Try
            Next
            'Close the registry key
            Try
                UninstallKey.Close()
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
        Return ExistingProgramList
    End Function

    Private Shared Function GetInstallerKeyNameFromGuid(ByVal GuidName As String) As String
        Dim MsiNameParts() As String = GuidName.Replace("{", "").Replace("}", "").Split("-"c)
        Dim MsiName As New System.Text.StringBuilder
        'Just reverse the first 3 parts
        For i As Integer = 0 To 2
            MsiName.Append(ReverseString(MsiNameParts(i)))
        Next
        'For the last 2 parts, reverse each character pair
        For j As Integer = 3 To 4
            For i As Integer = 0 To MsiNameParts(j).Length - 1
                MsiName.Append(MsiNameParts(j)(i + 1))
                MsiName.Append(MsiNameParts(j)(i))
                i += 1
            Next
        Next
        Return MsiName.ToString
    End Function

    Private Shared Function ReverseString(ByVal input As String) As String
        Dim Chars() As Char = input.ToCharArray
        Array.Reverse(Chars)
        Return Chars
    End Function

#End Region


End Class

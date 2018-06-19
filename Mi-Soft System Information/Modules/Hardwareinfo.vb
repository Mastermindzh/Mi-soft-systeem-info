Imports System
Imports System.Management
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Permissions
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.IO
Imports System.Environment
Imports System.Drawing
Imports System.Text
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles
Imports System.Xml
Module Hardwareinfo
    Public vidcontroller As New Collection
    Public gpuscreen As Boolean = True
    Public MemoryStatus As MEMORYSTATUSEX
    'privates'
#Region "privates"
    Private _AppBuild As String
    Private _AppCompanyName As String
    Private _AppCopyright As String
    Private _AppDescription As String
    Private _AppDirectory As String
    Private _AppMajorRevision As Integer
    Private _AppMajorVersion As Integer
    Private _AppMinorRevision As Integer
    Private _AppMinorVersion As Integer
    Private _AppProductName As String
    Private _AppRevision As String
    Private _AppShortVersion As String
    Private _AppTitle As String
    Private _AppTrademark As String
    Private _AppVersion As String
    Private _BiosFeatures As New Collection(Of String)
    Private _BiosManufacturer As String
    Private _BiosName As String
    Private _BiosReleaseDate As String
    Private _BiosSmBiosPresent As Boolean
    Private _BiosSmBiosVersion As String
    Private _BiosVersion As String
    Private _CDDrive As New Collection(Of String)
    Private _CDManufacturer As New Collection(Of String)
    Private _CDMediaSize As New Collection(Of String)
    Private _CDModel As New Collection(Of String)
    Private _CDRevisionLevel As New Collection(Of String)
    Private _CDStatus As New Collection(Of String)
    Private _CompAutomaticResetCapability As Boolean
    Private _CompDescription As String
    Private _CompManufacturer As String
    Private _CompModel As String
    Private _CompSystemType As String
    Private _CpuAddressWidth As String
    Private _CpuDescription As String
    Private _CpuFsbSpeed As String
    Private _CpuL2CacheSize As String
    Private _CpuL2CacheSpeed As String
    Private _CpuLoadPercentage As New Collection(Of Integer)
    Private _CpuManufacturer As String
    Private _CpuName As String
    Private _CpuNumberOfCores As Integer
    Private _CpuNumberOfLogicalProcessors As Integer
    Private _CpuNumberOfProcessors As Integer
    Private _CpuPowerManagementSupported As Boolean
    Private _CpuPowerManagementCapabilities As String
    Private _CpuProcessorId As String
    Private _CpuSocket As String
    Private _CpuSpeed As String
    Private _DriveCapacity As New Collection(Of String)
    Private _DriveInterface As New Collection(Of String)
    Private _DriveModelNo As New Collection(Of String)
    Private _DriveStatus As New Collection(Of String)
    Private _CLRMajorVersion As Integer
    Private _CLRMinorVersion As Integer
    Private _CLRServicePack As String
    Private _CLRShortVersion As String
    Private _CLRVersion As String
    Private _Is64Bit As Boolean
    Private _MainBoardManufacturer As String
    Private _MainBoardModel As String
    Private _MemAvailPhysical As String
    Private _MemAvailVirtual As String
    Private _MemTotalPhysical As String
    Private _MemTotalVirtual As String
    Private _NetFrameworkVersion As String
    Private _NetAdapterType As New Collection(Of String)
    Private _NetAutoSense As New Collection(Of String)
    Private _NetConnectionId As New Collection(Of String)
    Private _NetConnectionStatus As New Collection(Of String)
    Private _NetDefaultTtl As New Collection(Of String)
    Private _NetDhcpEnabled As New Collection(Of Boolean)
    Private _NetDhcpLeaseExpires As New Collection(Of String)
    Private _NetDhcpLeaseObtained As New Collection(Of String)
    Private _NetDhcpServer As New Collection(Of String)
    Private _NetDomain As New Collection(Of String)
    Private _NetHostName As New Collection(Of String)
    Private _NetIPAddress As New Collection(Of String)
    Private _NetIPEnabled As New Collection(Of Boolean)
    Private _NetIsNetworkConfigured As Boolean
    Private _NetMacAddress As New Collection(Of String)
    Private _NetManufacturer As New Collection(Of String)
    Private _NetMaxSpeed As New Collection(Of String)
    Private _NetMtu As New Collection(Of String)
    Private _NetNumberOfAdaptors As Integer
    Private _NetProductName As New Collection(Of String)
    Private _NetSpeed As New Collection(Of String)
    Private _NetTcpNumConnections As New Collection(Of String)
    Private _NetTcpWindowSize As New Collection(Of String)
    Private _OSBootupState As String
    Private _OSBuild As String
    Private _OSCodename As String
    Private _OSDomain As String
    Private _OSFullName As String
    Private _OSInstallDate As Date
    Private _OSInstallTime As Date
    Private _OSMachineName As String
    Private _OSMajorVersion As Integer
    Private _OSMinorVersion As Integer
    Private _OSPartOfDomain As Boolean
    Private _OSPlatform As System.PlatformID
    Private _OSProductId As String
    Private _OSProductKey As String
    Private _OSServicePack As String
    Private _OSShortVersion As String
    Private _OSStartTime As Date
    Private _OSType As String
    Private _OSUptime As String
    Private _OSUserName As String
    Private _OSVersion As String
    Private _PwrCanHibernate As Boolean
    Private _PwrCanShutdown As Boolean
    Private _PwrCanSuspend As Boolean
    Private _ServiceDisplayName As New Collection(Of String)
    Private _ServiceDescription As New Collection(Of String)
    Private _ServiceStartMode As New Collection(Of String)
    Private _ServiceState As New Collection(Of String)
    Private _ServiceStatus As New Collection(Of String)
    Private _ServicePathName As New Collection(Of String)
    Private _SndController As New Collection(Of String)
    Private _SndDMABufferSize As New Collection(Of String)
    Private _SndManufacturer As New Collection(Of String)
    Private _SndNumberOfControllers As Integer
    Private _TimeCurrentTimeZone As String
    Private _TimeDaylightSavingsInEffect As Boolean
    Private _TimeDaylightSavingsName As String
    Private _TimeDaylightSavingsOffset As Integer
    Private _TimeLocalDaylightEndDate As Date
    Private _TimeLocalDaylightEndTime As Date
    Private _TimeLocalDaylightStartDate As Date
    Private _TimeLocalDaylightStartTime As Date
    Private _TimeLocalDateTime As Date
    Private _TimeUniversalDateTime As Date
    Private _TimeUniversalDaylightEndDate As Date
    Private _TimeUniversalDaylightEndTime As Date
    Private _TimeUniversalDaylightStartDate As Date
    Private _TimeUniversalDaylightStartTime As Date
    Private _UniversalTimeOffset As Integer
    Private _TimeWeekOfYear As Integer
    Private _UserFlags As New Collection(Of Integer)
    Private _UserRegisteredName As String
    Private _UserRegisteredOrganization As String
    Private _UserRegisteredNameWow6432Node As String
    Private _UserRegisteredOrganizationWow6432Node As String
    Private _UserIsAdministrator As Boolean
    Private _UserAccounts As New Collection(Of String)
    Private _UserFullNames As New Collection(Of String)
    Private _UserPrivileges As New Collection(Of String)
    Private _VidController As New Collection(Of String)
    Private _VidPrimaryScreenDimensions As String
    Private _VidPrimaryScreenWorkingArea As String
    Private _VidNumberOfControllers As Integer
    Private _VidRam As New Collection(Of String)
    Private _VidRefreshRate As New Collection(Of String)
    Private _VidScreenColors As New Collection(Of String)
    Private _VolumeFileSystem As New Collection(Of String)
    Private _VolumeFreeSpace As New Collection(Of String)
    Private _VolumeIsFloppyReady As Boolean
    Private _VolumeLabel As New Collection(Of String)
    Private _VolumeLetter As New Collection(Of String)
    Private _VolumePercentFreeSpace As New Collection(Of String)
    Private _VolumeReady As New Collection(Of Boolean)
    Private _VolumeSerialNumber As New Collection(Of String)
    Private _VolumeTotalSize As New Collection(Of String)
    Private _VolumeType As New Collection(Of String)
    Private _VolumeUsedSpace As New Collection(Of String)
    Private _VstAuthor As String
    Private _VstColorScheme As String
    Private _VstCompany As String
    Private _VstControlHighlightHot As Drawing.Color
    Private _VstCopyright As String
    Private _VstDescription As String
    Private _VstDisplayName As String
    Private _VstIsEnabledByUser As Boolean
    Private _VstIsSupportedByOS As Boolean
    Private _VstMinimumColorDepth As Integer
    Private _VstSize As String
    Private _VstSupportsFlatMenus As Boolean
    Private _VstTextControlBorder As Drawing.Color
    Private _VstUrl As String
    Private _VstVersion As String
#End Region
    ' Class-level constants.
    Public Const mRevision As String = "Revision"
    Public Const mUnknown As String = "Unknown"
    Public Const mDefaultDate As Date = #1/1/2006#
    Public Const mstrChicago As String = "Chicago"
    Public Const mstrDaytona As String = "Daytona"
    Public Const mstrDetroit As String = "Detroit"
    Public Const mstrMemphis As String = "Memphis"
    Public Const mstrGeorgia As String = "Georgia"
    Public Const mstrCairo As String = "Cairo"
    Public Const mstrCairoNT5 As String = "Cairo/NT5"
    Public Const mstrWhistler As String = "Whistler"
    Public Const mstrWhistlerServer As String = "Whistler Server"
    Public Const mstrLonghorn As String = "Longhorn"
#Region "Processor"
    Friend Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function
#End Region
#Region "Netwerk"
    Friend Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc
            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)
        Next
        Return MACAddress
    End Function
    Private Function ReturnNetConnectionStatus(ByVal intStatus As Integer) As String
        Select Case intStatus
            Case 0
                Return "Disconnected"
            Case 1
                Return "Connecting"
            Case 2
                Return "Connected"
            Case 3
                Return "Disconnecting"
            Case 4
                Return "Hardware not present"
            Case 5
                Return "Hardware disabled"
            Case 6
                Return "Hardware malfunction"
            Case 7
                Return "Media disconnected"
            Case 8
                Return "Authenticating"
            Case 9
                Return "Authentication succeeded"
            Case 10
                Return "Authentication failed"
            Case 11
                Return "Invalid address"
            Case 12
                Return "Credentials required"
            Case Else
                Return ""
        End Select
    End Function
    Public Sub GetNetAdaptorInfo()
        Dim query As New SelectQuery("Win32_NetworkAdapter")
        Dim search As New ManagementObjectSearcher(query)
        Dim count As Integer
        For Each info In search.Get
            Try
                _NetAdapterType.Add(info("AdapterType").ToString)
            Catch
                _NetAdapterType.Add("N/A")
            End Try
            Try
                _NetAutoSense.Add(info("AutoSense").ToString)
            Catch
                _NetAutoSense.Add("N/A")
            End Try
            Try
                _NetMacAddress.Add(info("MACAddress").ToString)
            Catch
                _NetMacAddress.Add("N/A")
            End Try
            Try
                _NetManufacturer.Add(info("Manufacturer").ToString)
            Catch
                _NetManufacturer.Add("N/A")
            End Try
            Try
                _NetMaxSpeed.Add(info("MaxSpeed").ToString)
            Catch
                _NetMaxSpeed.Add("N/A")
            End Try
            Try
                _NetConnectionId.Add(info("NetConnectionID").ToString)
            Catch
                _NetConnectionId.Add("N/A")
            End Try
            ' this feature was not implemented until Windows XP
            Try
                If GetOSMajorVersion() >= 5 And GetOSMajorVersion() >= 1 Then
                    _NetConnectionStatus.Add( _
                        ReturnNetConnectionStatus(CInt(info("NetConnectionStatus"))))
                Else
                    _NetConnectionStatus.Add("N/A")
                End If
            Catch
                _NetConnectionStatus.Add("N/A")
            End Try
            Try
                _NetProductName.Add(info("ProductName").ToString)
            Catch
                _NetProductName.Add("N/A")
            End Try
            Try
                _NetSpeed.Add(info("Speed").ToString)
            Catch
                _NetSpeed.Add("N/A")
            End Try
            count += 1
            _NetNumberOfAdaptors = count
        Next
        If search IsNot Nothing Then search.Dispose()
    End Sub
#End Region
#Region "Drives"
    Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String
        Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        disk.Get()
        Return disk("VolumeSerialNumber").ToString()
    End Function
#End Region

#Region "Videokaart"
    Friend Function getvideoname() As String
        Dim query As New SelectQuery("Win32_VideoController")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject = Nothing
        Dim finaltext As String = Nothing
        Dim count As Integer = Nothing
        Dim finaltext2 As String = Nothing
        Dim countgpu As Integer = 0
        For Each info In search.Get()
            If GPUscreen = True Then
                Try
                    finaltext2 = info("name").Tolower
                    If finaltext2.Contains("logmein") Or finaltext2.Contains("maxivista") Then
                    Else
                        vidcontroller.Add(info("Name").ToString)
                        countgpu = countgpu + 1
                        If finaltext = "" Then
                            finaltext = info("name").ToString
                        Else
                            finaltext = finaltext & vbNewLine & info("Name").ToString()
                        End If
                    End If
                Catch
                    vidcontroller.Add("onbekende video controller")
                End Try
            Else
                Try
                    If finaltext = "" Then
                        finaltext = info("name").ToString
                    Else
                        finaltext = finaltext & vbNewLine & info("Name").ToString()
                    End If
                Catch
                    vidcontroller.Add("onbekende video controller")
                End Try
            End If
        Next
        If countgpu >= 2 Then Form1.Label4.Text = "Videokaarten"
        Return finaltext
    End Function
    Friend Function getsinglevideoname() As String
        Dim query As New SelectQuery("Win32_VideoController")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject = Nothing
        Dim finaltext As String = Nothing
        Dim count As Integer = Nothing
        For Each info In search.Get()
            Try
                vidcontroller.Add(info("Name").ToString)
                If finaltext = "" Then
                    finaltext = info("name").ToString
                Else
                    'skip'
                End If
            Catch
                vidcontroller.Add("onbekende video controller")
            End Try
        Next
        Return finaltext
    End Function
#End Region
#Region " Moederbord informatie "
    Friend Function GetMainBoardManufacturer() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get
            Try
                temp = (info("Manufacturer").ToString)
            Catch
                temp = "N/A"
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
    Friend Function GetMainBoardModel() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get
            Try
                temp = info("Product").ToString
            Catch
                temp = "N/A"
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
  
    Friend Function GetMotherBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("SerialNumber").ToString()
        Next
        Return strMotherBoardID
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
    Friend Function getmotherboardname() As String
        Dim strmotherboardname As String = String.Empty
        Dim query As New SelectQuery("Win32_baseboard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strmotherboardname = info("Product").ToString()
            strmotherboardname = strmotherboardname.Replace("  ", " ")
        Next
        Return strmotherboardname
    End Function
#End Region
#Region " Get Memory Information "
#Region " Formatting Subroutines "
    Public Function FormatBytes(ByVal bytes As Double) As String
        Dim temp As Double
        If bytes >= 1073741824 Then
            temp = bytes / 1073741824   ' GB
            Return String.Format("{0:N2}", temp) & " GB"
        ElseIf bytes >= 1048576 And bytes <= 1073741823 Then
            temp = bytes / 1048576  'MB
            Return String.Format("{0:N0}", temp) & " MB"
        ElseIf bytes >= 1024 And bytes <= 1048575 Then
            temp = bytes / 1024 ' KB
            Return String.Format("{0:N0}", temp) & " KB"
        ElseIf bytes = 0 And bytes <= 1023 Then
            temp = bytes    ' bytes
            Return String.Format("{0:N0}", temp) & " bytes"
        Else
            Return ""
        End If
    End Function
#End Region
#Region " API Declaration and Structure "
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto), CLSCompliant(False)> _
    Public Structure MEMORYSTATUSEX
        Dim dwLength As Integer
        Dim dwMemoryLoad As Integer
        Dim ullTotalPhys As UInt64
        Dim ullAvailPhys As UInt64
        Dim ullTotalPageFile As UInt64
        Dim ullAvailPageFile As UInt64
        Dim ullTotalVirtual As UInt64
        Dim ullAvailVirtual As UInt64
        Dim ullAvailExtendedVirtual As UInt64
    End Structure
    ' API declarations
    Public Declare Auto Function GlobalMemoryStatusEx Lib "kernel32" _
        (<MarshalAs(UnmanagedType.Struct)> ByRef lpBuffer As MEMORYSTATUSEX) As _
        <MarshalAs(UnmanagedType.Bool)> Boolean
#End Region
    <EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted:=True)> _
    Public Function GetMemAvailVirtual() As String
        Dim dblInfo As Double
        ' Call API
        MemoryStatus.dwLength = Marshal.SizeOf(MemoryStatus)
        GlobalMemoryStatusEx(MemoryStatus)
        ' get memory information
        dblInfo = CDbl(MemoryStatus.ullAvailVirtual)
        ' return formatted string
        Return FormatBytes(dblInfo)
    End Function
    <EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted:=True)> _
    Public Function GetMemAvailPhysical() As String
        Dim dblInfo As Double
        ' Call API
        MemoryStatus.dwLength = Marshal.SizeOf(MemoryStatus)
        GlobalMemoryStatusEx(MemoryStatus)
        ' get memory information
        dblInfo = CDbl(MemoryStatus.ullAvailPhys)
        ' return formatted string
        Return FormatBytes(dblInfo)
    End Function
    <EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted:=True)> _
    Public Function GetMemTotalVirtual() As String
        Dim dblInfo As Double
        ' Call API
        MemoryStatus.dwLength = Marshal.SizeOf(MemoryStatus)
        GlobalMemoryStatusEx(MemoryStatus)
        ' get memory information
        dblInfo = CDbl(MemoryStatus.ullTotalVirtual)
        ' return formatted string
        Return FormatBytes(dblInfo)
    End Function
    <EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted:=True)> _
    Public Function GetMemTotalPhysical() As String
        Dim dblInfo As Double
        ' Call API
        MemoryStatus.dwLength = Marshal.SizeOf(MemoryStatus)
        GlobalMemoryStatusEx(MemoryStatus)
        ' get memory information
        dblInfo = CDbl(MemoryStatus.ullTotalPhys)
        ' return formatted string
        Return FormatBytes(dblInfo)
    End Function
#End Region
#Region "Besturingssysteem"
    Public Function getSystemType2() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_ComputerSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get()
            Try
                temp = info("SystemType").ToString
            Catch
                temp = ""
            End Try
        Next
        Return temp
    End Function
    Public Function GetOSDomain() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_ComputerSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get()
            Try
                temp = info("Domain").ToString
            Catch
                temp = ""
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
    Public Function GetOSPartOfDomain() As Boolean
        Dim temp As Boolean
        Dim query As New SelectQuery("Win32_ComputerSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get()
            Try
                temp = CBool(info("PartOfDomain"))
            Catch
                temp = False
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
    Public Function GetOSInstallDate() As Date
        ' The install date/time is stored in the registry as the number of seconds since 01/01/1970 @ midnight.
        Dim rk As RegistryKey = Nothing
        Dim installDate As Date
        Dim origDate As Date
        Dim secondsSince1970 As Double
        Try
            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            secondsSince1970 = CDbl(rk.GetValue("InstallDate"))
            If DateTime.TryParse("01/01/1970 00:00:00", origDate) Then
                installDate = origDate.AddSeconds(secondsSince1970)
            End If
        Catch
            installDate = DateTime.Today    ' If error, just return today's date.
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try
        Return installDate
    End Function
    Public Function GetOSBootupState() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_ComputerSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get()
            Try
                temp = info("BootupState").ToString
            Catch
                temp = ""
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
    Public Function GetOSMajorVersion() As Integer
        Return Environment.OSVersion.Version.Major
    End Function
    Public Function GetOSMinorVersion() As Integer
        Return Environment.OSVersion.Version.Minor
    End Function
    Public Function GetOSShortVersion() As String
        Return Environment.OSVersion.Version.Major.ToString & "." & _
                Environment.OSVersion.Version.Minor.ToString
    End Function
    Public Function GetOSCodename() As String
        Dim intMinorVersion As Integer
        Dim intMajorVersion As Integer
        intMajorVersion = Environment.OSVersion.Version.Major
        intMinorVersion = Environment.OSVersion.Version.Minor
        Select Case Environment.OSVersion.Platform
            Case System.PlatformID.Win32Windows
                Select Case intMinorVersion
                    Case 0
                        If mRevision = String.Empty Then
                            Return mstrChicago
                        Else
                            Return mstrDetroit
                        End If
                    Case 10
                        Return mstrMemphis
                    Case 90
                        Return mstrGeorgia
                    Case Else
                        Return mUnknown
                End Select
            Case System.PlatformID.Win32NT
                ' get information for Windows NT SP6 and above
                If intMajorVersion = 4 And intMinorVersion = 0 Then
                    ' Windows NT
                    Return mstrCairo
                ElseIf intMajorVersion = 5 And intMinorVersion = 0 Then
                    ' Windows 2000
                    Return mstrCairoNT5
                ElseIf intMajorVersion = 5 And intMinorVersion = 1 Then
                    ' Windows XP
                    Return mstrWhistler
                ElseIf intMajorVersion = 5 And intMinorVersion = 2 Then
                    ' Windows Server 2003
                    Return mstrWhistlerServer
                ElseIf intMajorVersion = 6 Then
                    ' Windows Vista
                    Return mstrLonghorn
                Else
                    Return mUnknown
                End If
            Case Else
                Return mUnknown
        End Select
    End Function
    Public Function GetOSServicePack() As String
        Return Environment.OSVersion.ServicePack.ToString()
    End Function
    Public Function GetOSBuild() As String
        Return Environment.OSVersion.Version.Build.ToString
    End Function
    Public Function GetOSFullName() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_OperatingSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each info In search.Get()
            Try
                temp = info("Caption").ToString
            Catch
                temp = ""
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function
    Public Function GetOSVersion() As String
        Return Environment.OSVersion.Version.ToString
    End Function
    Public Function GetOSPlatform() As System.PlatformID
        Return Environment.OSVersion.Platform
    End Function
    Public Function GetOSUserName() As String
        Return Environment.UserName
    End Function
    Public Function GetOSMachineName() As String
        Return Environment.MachineName
    End Function
    Public Function GetOSProductId() As String
        Dim rk As RegistryKey = Nothing
        Try
            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            Dim productID As String = rk.GetValue("ProductID", "").ToString()
            rk.Close()
            Return productID
        Catch
            If rk IsNot Nothing Then
                rk.Close()
            End If
            Return ""
        End Try
    End Function
    Public Function GetOSType() As String
        Dim rk As RegistryKey = Nothing
        Try
            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            Dim productID As String = rk.GetValue("CurrentType").ToString()
            rk.Close()
            Return productID
        Catch
            If rk IsNot Nothing Then
                rk.Close()
            End If
            Return ""
        End Try
    End Function
    Public Function GetOSIs64Bit() As Boolean
        Dim returnValue As Boolean
        ' First try to determine if the 32-bit program files environment variable exists.
        If Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ProgramFiles(x86)")) Then
            returnValue = True
        End If
        ' If false, try this method of determing if running in 64 or 32 Bit environment.
        If returnValue = False Then
            For Each ra As Reflection.Assembly In My.Application.Info.LoadedAssemblies
                If ra.Location.ToLower.Contains("framework64") Then returnValue = True
                Exit For
            Next
        End If
        Return returnValue
    End Function
#End Region
#Region "Windows prestatie index"
    Public Function GetBaseScore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName
                End If
            Next
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim score As String = elementsByTagName.ItemOf(0).FirstChild.InnerXml
            Return score
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
    Public Function GetCPUscore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName

                End If
            Next
            'MsgBox(lastaccesspath)
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim scorecpu As String = elementsByTagName.ItemOf(0).ChildNodes(2).InnerXml
            Return scorecpu
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
    Public Function getmemscore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName
                End If
            Next
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim score As String = elementsByTagName.ItemOf(0).ChildNodes(1).InnerXml
            Return score
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
    Public Function getgpuscore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName
                End If
            Next
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim score As String = elementsByTagName.ItemOf(0).ChildNodes(5).InnerXml
            Return score
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
    Public Function getgpugamescore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName
                End If
            Next
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim score As String = elementsByTagName.ItemOf(0).ChildNodes(8).InnerXml
            Return score
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
    Public Function gethddscore() As String
        ' Check if the computer has a \WinSAT dir.
        If System.IO.Directory.Exists("C:\Windows\Performance\WinSAT\DataStore") Then
            Dim document As New XmlDocument
            Dim file As New IO.DirectoryInfo("C:\WINDOWS\Performance\WinSAT\DataStore")
            Dim filedir() As IO.FileInfo
            Dim fmst As IO.FileInfo
            Dim accesstime As Date
            Dim lastaccesspath As String = Nothing
            filedir = file.GetFiles
            For Each fmst In filedir
                If fmst.LastAccessTime >= accesstime Then
                    accesstime = fmst.LastAccessTime
                    lastaccesspath = fmst.FullName
                End If
            Next
            document.Load(lastaccesspath)
            Dim elementsByTagName As XmlNodeList = document.GetElementsByTagName("WinSPR")
            Dim score As String = elementsByTagName.ItemOf(0).ChildNodes(11).InnerXml
            Return score
        Else
            Return "Geen windows eperience index gevonden"
        End If
    End Function
#End Region
End Module

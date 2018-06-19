Module module1
    Private Structure OSVERSIONINFO
        Dim dwOSVersionInfoSize As Integer
        Dim dwMajorVersion As Integer
        Dim dwMinorVersion As Integer
        Dim dwBuildNumber As Integer
        Dim dwPlatformId As Integer
        <VBFixedString(128), _
          System.Runtime.InteropServices.MarshalAs _
               (System.Runtime.InteropServices.UnmanagedType.ByValTStr, _
            SizeConst:=128)> Dim szCSDVersion As String
    End Structure
    Private Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As OSVERSIONINFO) As Short
    Public Function getServicePack() As String
        Dim osinfo As OSVERSIONINFO = Nothing
        Dim retvalue As Short
        osinfo.dwOSVersionInfoSize = 148
        retvalue = GetVersionExA(osinfo)
        If Len(osinfo.szCSDVersion) = 0 Then
            Return ("Geen Service Pack geïnstalleerd")
        Else
            Return (CStr(osinfo.szCSDVersion))
        End If
    End Function
    Public Sub main()
        Console.WriteLine(getServicePack())
    End Sub
End Module
Public Class Systeem_informatie
    Private Shared panelInstance As Systeem_informatie
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Systeem_informatie
        If (panelInstance Is Nothing) Then
            panelInstance = New Systeem_informatie()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Systeem_informatie
        panelInstance = Nothing
    End Function
    Public Shared Sub test()
        MsgBox("Deze functie is nog niet ingebouwd")
    End Sub
    Private Sub Systeem_informatie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("Http://mi-soft.nl")
    End Sub
End Class

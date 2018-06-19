Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Public Class Software
    Private Shared panelInstance As Software
    Public Shared Function CreateInstance() As Software
        If (panelInstance Is Nothing) Then
            panelInstance = New Software()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Software
        panelInstance = Nothing
    End Function
    Private _Info As New InformationClass
    Private Sub Software_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(1).Nodes(3)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(1).Nodes(0)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(1).Nodes(1)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(1).Nodes(2)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

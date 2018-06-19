Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Public Class Hardware
    Private Shared panelInstance As Hardware
    Public Shared Function CreateInstance() As Hardware
        If (panelInstance Is Nothing) Then
            panelInstance = New Hardware()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Hardware
        panelInstance = Nothing
    End Function
    Private _Info As New InformationClass

    Private Sub Hardware_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(0)
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(6)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(2)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(1)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(3)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(4)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(5)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Meer_info.TreeView1.SelectedNode = Meer_info.TreeView1.Nodes(0).Nodes(0).Nodes(7)
    End Sub
End Class

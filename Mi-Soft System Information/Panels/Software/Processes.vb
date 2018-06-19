Option Explicit On
Option Strict On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections
Imports System.Diagnostics
Imports System.Threading
Imports System
Imports System.Text
Imports System.IO

Public Class Processes
    ' Boolean used to toggle listview sort.
    Private _Ascending As Boolean
    Private _SelectedIndex As Integer
    Private _Info As New InformationClass

    Private ResourceManager As New  _
      System.Resources.ResourceManager("SystemInformation.Resources", GetType(Processes).Assembly)

    Private Shared panelInstance As Processes
    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Processes
        If (panelInstance Is Nothing) Then
            panelInstance = New Processes()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Processes
        panelInstance = Nothing
    End Function


    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Try

            ' Clear listview.
            ListViewProcesses.Items.Clear()

            '' Add services info to listview.
            Dim allProcesses() As Diagnostics.Process = Diagnostics.Process.GetProcesses()

            Try
                For Each proc As Diagnostics.Process In allProcesses
                    Try
                        Dim lItem As ListViewItem = ListViewProcesses.Items.Add(proc.ProcessName)
                        lItem.SubItems.Add(proc.Id.ToString)
                        lItem.SubItems.Add(proc.Threads.Count.ToString)
                        Dim processPriority As String = "Normal"
                        Select Case proc.BasePriority
                            Case 13
                                processPriority = "High"
                            Case 4
                                processPriority = "Idle"
                            Case 8
                                processPriority = "Normal"
                            Case 24
                                processPriority = "Real Time"
                        End Select
                        lItem.SubItems.Add(processPriority)
                        lItem.SubItems.Add(FormatBytes(proc.PrivateMemorySize64))
                        lItem.SubItems.Add(proc.StartTime.ToShortTimeString)
                    Catch ex As Exception
                        ' Ignore
                    End Try
                Next
            Catch ex As Exception
                ' Access error: ignore.
            End Try

  

            ' Sort the listview.
            ListViewProcesses.Sorting = SortOrder.Ascending
            ListViewProcesses.Sort()

            ' Close the wait form.
            'WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Processes panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub



#Region " ListView Events "

    ''' <summary>
    ''' Set the ListViewItemSorter property to a new ListViewItemComparer 
    ''' object. Setting this property immediately sorts the 
    ''' ListView using the ListViewItemComparer object.
    ''' </summary>
    Private Sub ListViewProcesses_ColumnClick(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ColumnClickEventArgs)

        ' Toggle sort order.
        If _Ascending = False Then
            _Ascending = True
        Else
            _Ascending = False
        End If

        ' Perform sort of items in specified column.
        ListViewProcesses.ListViewItemSorter = New ListViewItemComparer(e.Column, _Ascending)

    End Sub

    Private Sub ListViewProcesses_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs)

        If e.IsSelected Then
            _SelectedIndex = e.ItemIndex
        End If

    End Sub

#End Region

#Region " Menu Events "

    Private Sub MenuEndProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuEndProcess.Click

        Dim processId As String = ListViewProcesses.Items(_SelectedIndex).SubItems(1).Text

        Diagnostics.Process.GetProcessById(CInt(processId), _Info.OSMachineName).Kill()

        ListViewProcesses.Items(_SelectedIndex).Remove()

    End Sub

#End Region

#Region " Private Methods "

    Private Shared Function FormatBytes(ByVal bytes As Double) As String
        Dim temp As Double

        If bytes >= 1024 And bytes <= 1073741823 Then
            temp = bytes / 1024 ' KB
            Return String.Format("{0:N0}", temp) & " KB"
        ElseIf bytes = 0 And bytes <= 1023 Then
            temp = bytes    ' bytes
            Return String.Format("{0:N0}", bytes) & " bytes"
        Else
            Return ""
        End If

    End Function

#End Region
End Class

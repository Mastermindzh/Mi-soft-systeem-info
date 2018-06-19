Public Class Video
    Private Shared panelInstance As Video
    Private _Info As New InformationClass
    Public Shared Function CreateInstance() As Video
        If (panelInstance Is Nothing) Then
            panelInstance = New Video()
        End If
        Return panelInstance
    End Function
    Public Shared Function deleteinstance() As Video
        panelInstance = Nothing
    End Function
    <STAThread()> _
    Sub showform()
        Application.Run(New waitform())
    End Sub
    Private Sub Video_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Dim thread As Threading.Thread
            thread = New Threading.Thread(AddressOf Me.showform)
            thread.Start()

            ' Allow panel to paint.
            Application.DoEvents()

            Dim X As Integer

            ' Get information.
            _Info.Initialize(InformationClass.Initializers.GetVideoInfo)

            ' Display number of adaptors
            LabelNumberControllers.Text = "Aantal video adapters: " & _
                _Info.VidNumberOfControllers.ToString

            ' Display dimensions
            If _Info.VidNumberOfControllers > 0 Then
                LabelScreenDimensions1.Text = "Resolutie: " & _
                    _Info.VidPrimaryScreenDimensions
                LabelScreenWorkingArea1.Text = "Echte werkruimte (in pixels): " & _
                    _Info.VidPrimaryScreenWorkingArea
            End If

            ' Clear listview
            ListViewAdaptors.Items.Clear()

            ' Add information to listview
            If _Info.VidNumberOfControllers > 0 Then
                For X = 0 To _Info.VidNumberOfControllers - 1

                    Try
                        ListViewAdaptors.Items.Add("Video adapter: " & _
                            _Info.VidController.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Video adapter: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Kleurenindex: " & _
                            _Info.VidScreenColors.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Kleurenindex: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Refresh Rate: " & _
                            _Info.VidRefreshRate.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Refresh Rate: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Video RAM: " & _
                            _Info.VidRam.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Video RAM: N/A")
                    End Try

                    ' Add blank line between adaptors
                    ListViewAdaptors.Items.Add("")
                Next

            End If
            thread.Abort()
        Catch ex As Exception

            MessageBox.Show("An error has occurred in the Video panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

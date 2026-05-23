'AI ASSISTED CODE - GEMINI - GRACIAS

Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Windows.Compatibility

Public Class ScannerManager
    Private videoSource As VideoCaptureDevice
    ' Use the Generic version to avoid the "Too few arguments" error in modern .NET
    Private reader As New BarcodeReader()

    ' Event to send the decoded text back to the Form
    Public Event ScanComplete(decodedText As String)

    Public Sub StartCamera(pictureBox As PictureBox)
        Dim videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)

            ' Attach the frame handler
            AddHandler videoSource.NewFrame, Sub(sender, eventArgs)
                                                 Try
                                                     ' 1. Create a clone for the UI display
                                                     Dim uiFrame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

                                                     ' Update PictureBox safely (clearing old memory)
                                                     If pictureBox.Image IsNot Nothing Then pictureBox.Image.Dispose()
                                                     pictureBox.Image = uiFrame

                                                     ' 2. Create a separate clone for the Scanning process
                                                     ' Using a 'Using' block ensures this bitmap is deleted immediately after scanning
                                                     Using scanFrame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                                                         ' Create the luminance source specifically from the scanFrame
                                                         Dim source As New BitmapLuminanceSource(scanFrame)
                                                         Dim result = reader.Decode(source)

                                                         If result IsNot Nothing Then
                                                             ' Raise event to notify Form1
                                                             RaiseEvent ScanComplete(result.Text)
                                                         End If
                                                     End Using

                                                 Catch ex As Exception
                                                     ' We catch exceptions here because camera frames happen so fast (30fps)
                                                     ' that occasionally the UI thread and Camera thread still bump into each other.
                                                     ' Skipping one frame is better than crashing.
                                                 End Try
                                             End Sub

            videoSource.Start()
        End If
    End Sub

    Public Sub StopCamera()
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            ' Proper shutdown sequence for AForge
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            videoSource = Nothing
        End If
    End Sub
End Class
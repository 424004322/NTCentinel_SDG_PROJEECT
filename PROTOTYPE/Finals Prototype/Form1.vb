Imports Microsoft.Data.SqlClient

Public Class Form1
    Private WithEvents qrScanner As New ScannerManager()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon("C:\Users\pc\Documents\New folder (3)\PROTOTYPE\Finals Prototype\Resources\NTCENTINEL_ICON.ico")
        qrScanner.StartCamera(pcBox)
        cboViolation.SelectedIndex = 0

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MessageBox.Show("Please enter a Student ID or scan a QR ID.")
            Exit Sub
        End If

        Dim vManager As New ViolationManager()

        Try
            lbReciept.Items.Clear()

            ' Call the function and get the returned list
            Dim details As List(Of String) = vManager.Record(txtStudentID.Text, Session.CurrentUserID, cboViolation.Text)

            ' Loop through the list and add each line to the ListBox
            For Each line In details
                lbReciept.Items.Add(line)
            Next

            MessageBox.Show("Violation Logged Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim inputID As Integer
        If Not Integer.TryParse(txtStudentID.Text, inputID) Then

            MessageBox.Show("Please enter a valid ID.")

            Exit Sub

        End If

        Dim currentStudent As New Student()
        If currentStudent.LoadFromDatabase(txtStudentID.Text) Then
            txtStudentName.Text = currentStudent.FullName
        Else
            MessageBox.Show("Student Not Found")
        End If
    End Sub

    Private Sub qrScanner_ScanComplete(decodedText As String) Handles qrScanner.ScanComplete
        Me.Invoke(Sub()
                      Try
                          ' 1. Split the string by the comma
                          ' Example: "424004322,Gracias" becomes an array ["424004322", "Gracias"]
                          Dim dataParts As String() = decodedText.Split(","c)
                          Dim cleanedID As String = dataParts(0).Trim() ' Take the first part (The ID)

                          ' 2. Assign the cleaned ID to your textbox
                          txtStudentID.Text = cleanedID

                          ' 3. Now run your OOP logic with the CLEANED ID
                          Dim currentStudent As New Student()
                          If currentStudent.LoadFromDatabase(cleanedID) Then
                              txtStudentName.Text = currentStudent.FullName
                              Console.Beep()
                          End If

                      Catch ex As Exception
                          ' If the QR code format is wrong, handle it gracefully
                          lbReciept.Text = "Invalid QR Format"
                      End Try
                  End Sub)
    End Sub
End Class

Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUserName.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As SqlConnection = DBManager.GetConnection()
            Try
                conn.Open()

                Dim sql As String = "SELECT * FROM Users WHERE User_Name = @Username"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Username", txtUserName.Text)

                Dim dtRead As SqlDataReader = cmd.ExecuteReader()

                If dtRead.Read() Then
                    Dim pass = dtRead("Password_Hash").ToString()
                    Dim user = dtRead("User_Name").ToString()
                    Dim userId = dtRead("User_ID").ToString()

                    If pass = txtPassword.Text Then

                        Session.CurrentUserID = userId
                        Session.CurrentUserName = user

                        MessageBox.Show("Login Successful!")

                        Form1.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Username not found in the system.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon("C:\Users\pc\Documents\New folder (3)\PROTOTYPE\Finals Prototype\Resources\NTCENTINEL_ICON.ico")
    End Sub
End Class
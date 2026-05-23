Imports Microsoft.Data.SqlClient

Public MustInherit Class Person
    Public Property UserID As Integer
    Public Property UserName As String
End Class

Public Class Guard
    Inherits Person

    Public Function Authenticate(pass As String) As Boolean
        Using conn = DBManager.GetConnection()
            Dim sql = "SELECT User_ID, Password_Hash FROM Users WHERE User_Name = @user"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", Me.UserName)

            Using reader = cmd.ExecuteReader()
                If reader.Read() AndAlso reader("Password_Hash").ToString() = pass Then
                    Me.UserID = reader("User_ID")
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function
End Class
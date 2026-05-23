Imports Microsoft.Data.SqlClient

Public Class Student
    Private _id As String
    Private _fullName As String
    Public Property StudentID As String
        Get
            Return _id
        End Get
        Set(value As String)
            If _id < 0 Then
                _id = _id * -1
            Else
                _id = value
            End If
        End Set
    End Property

    Public Property FullName As String
        Get
            Return _fullName
        End Get
        Set(value As String)
            _fullName = value
        End Set
    End Property

    Public Function LoadFromDatabase(id As String) As Boolean
        Using conn = DBManager.GetConnection()
            conn.Open()
            Dim sql = "SELECT First_Name, Last_Name FROM Student WHERE Student_ID = @id"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    Me._id = id
                    Me._fullName = reader("First_Name").ToString() & " " & reader("Last_Name").ToString()
                    Return True
                Else
                    MessageBox.Show("No Record found!")
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
End Class
Imports Microsoft.Data.SqlClient

Public Interface IViolationAction
    Function Record(studentID As String, guardID As Integer, category As String) As List(Of String)
End Interface
Public Class ViolationManager
    Implements IViolationAction

    Public Function Record(studentID As String, guardID As Integer, category As String) As List(Of String) Implements IViolationAction.Record
        Dim receiptDetails As New List(Of String)

        Using conn = DBManager.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim currentStrikes As Integer = GetCurrentStrikes(studentID, conn)
            Dim prevSanction As String = GetSanctionName(currentStrikes)
            Dim imposedSanction As String = GetSanctionName(currentStrikes + 1)
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            Dim sql As String = "INSERT INTO Violation_Records (Student_ID, User_ID, Violation_Type_ID, Imposed_Sanction, Previous_Sanction, DATE_TIME) " &
                                "SELECT @sID, @uID, Violation_Type_ID, @current, @prev, GETDATE() " &
                                "FROM Violation_Type WHERE Category = @cat"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sID", studentID)
                cmd.Parameters.AddWithValue("@uID", guardID)
                cmd.Parameters.AddWithValue("@cat", category)
                cmd.Parameters.AddWithValue("@current", imposedSanction)
                cmd.Parameters.AddWithValue("@prev", prevSanction)
                cmd.ExecuteNonQuery()
            End Using

            UpdateStrikeCounter(studentID, conn)

            receiptDetails.Add("--- NTCentinel VIOLATION RECEIPT ---")
            receiptDetails.Add("Date/Time: " & timestamp)
            receiptDetails.Add("Student ID: " & studentID)
            receiptDetails.Add("Violation: " & category)
            receiptDetails.Add("Previous Strike: " & prevSanction)
            receiptDetails.Add("CURRENT SANCTION: " & imposedSanction)
            receiptDetails.Add("Total Strikes: " & (currentStrikes + 1).ToString())
            receiptDetails.Add("Guard ID in Charge: " & guardID)
            receiptDetails.Add("------------------------------------")
        End Using

        Return receiptDetails
    End Function


    Private Function GetCurrentStrikes(studentID As String, conn As SqlConnection) As Integer
        Dim sql = "SELECT Total_Violation_Count FROM Student WHERE Student_ID = @id"
        Using cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", studentID)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function GetSanctionName(strikeLevel As Integer) As String
        Select Case strikeLevel
            Case 0 : Return "None"
            Case 1 : Return "1st Warning"
            Case 2 : Return "2nd Warning / Parent Call"
            Case 3 : Return "Suspension"
            Case Else : Return "Expulsion / Disciplinary Action"
        End Select
    End Function

    Private Sub UpdateStrikeCounter(studentID As String, conn As SqlConnection)
        Dim upSql = "UPDATE Student SET Total_Violation_Count = Total_Violation_Count + 1 WHERE Student_ID = @sID"
        Using upCmd As New SqlCommand(upSql, conn)
            upCmd.Parameters.AddWithValue("@sID", studentID)
            upCmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
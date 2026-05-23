Imports Microsoft.Data.SqlClient
Public Class DBManager

    Private Shared connString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connString)
    End Function

End Class

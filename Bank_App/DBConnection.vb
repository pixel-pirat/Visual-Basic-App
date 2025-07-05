Imports System.Data.SQLite

Module DBConnection
    Public conn As New SQLiteConnection("Data Source=bank.db;Version=3;")

    ' Open database connection
    Public Sub OpenConn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()

            ' Enable foreign key constraints
            Dim pragmaCmd As New SQLiteCommand("PRAGMA foreign_keys = ON;", conn)
            pragmaCmd.ExecuteNonQuery()
        End If
    End Sub

    ' Close database connection
    Public Sub CloseConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' Generate a 13-digit account number with a prefix like 1024000000001
    Public Function GenerateAccountNumber() As String
        Dim prefix As String = "1024"
        Dim newId As Integer = 1

        OpenConn()
        Dim cmd As New SQLiteCommand("SELECT COUNT(*) FROM accounts", conn)
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then newId = CInt(result) + 1
        CloseConn()

        Dim paddedId = newId.ToString().PadLeft(9, "0"c)
        Return prefix & paddedId
    End Function

    ' Generate a unique transaction or loan code
    Public Function GenerateUniqueCode(prefix As String) As String
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim randomPart As String = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper()
        Return $"{prefix}-{timestamp}-{randomPart}"
    End Function

    ' Get account ID from account number
    Public Function GetAccountId(accountNumber As String) As Integer
        OpenConn()
        Dim cmd As New SQLiteCommand("SELECT id FROM accounts WHERE account_number = @acc", conn)
        cmd.Parameters.AddWithValue("@acc", accountNumber)
        Dim result = cmd.ExecuteScalar()
        CloseConn()

        If result IsNot Nothing Then Return CInt(result)
        Return 0
    End Function
End Module

Imports System.Data.SQLite
Imports System.IO

Module DBConnection
    Public conn As New SQLiteConnection("Data Source=bank.db;Version=3;")

    ' Open database connection
    Public Sub OpenConn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Close database connection
    Public Sub CloseConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' Create database and tables on first run
    Public Sub InitDatabase()
        If Not File.Exists("bank.db") Then
            SQLiteConnection.CreateFile("bank.db")
            OpenConn()

            Dim sql As String =
                "CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL,
                    password TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS accounts (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER,
                    account_number TEXT UNIQUE,
                    account_type TEXT,
                    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS savings (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    account_id INTEGER,
                    amount REAL,
                    type TEXT,
                    transaction_date DATETIME DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS loans (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    account_id INTEGER,
                    amount REAL,
                    term INTEGER,
                    status TEXT DEFAULT 'pending',
                    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                );"

            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.ExecuteNonQuery()

            CloseConn()
        End If
    End Sub

    ' Generate an account number with prefix and padded ID
    Public Function GenerateAccountNumber() As String
        Dim prefix As String = "1024"
        Dim newId As Integer = 1

        OpenConn()
        Dim cmd As New SQLiteCommand("SELECT COUNT(*) FROM accounts", conn)
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            newId = CInt(result) + 1
        End If
        CloseConn()

        Dim paddedId = newId.ToString().PadLeft(9, "0"c) ' 9 digits after prefix
        Return prefix & paddedId
    End Function

    ' Generate unique code for transaction or loan
    Public Function GenerateUniqueCode(prefix As String) As String
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim randomPart As String = Path.GetRandomFileName().Replace(".", "").Substring(0, 4).ToUpper()
        Return $"{prefix}-{timestamp}-{randomPart}"
    End Function

    ' Get account ID from account number
    Public Function GetAccountId(accountNumber As String) As Integer
        OpenConn()
        Dim cmd As New SQLiteCommand("SELECT id FROM accounts WHERE account_number=@acc", conn)
        cmd.Parameters.AddWithValue("@acc", accountNumber)
        Dim result = cmd.ExecuteScalar()
        CloseConn()

        If result IsNot Nothing Then Return CInt(result)
        Return 0
    End Function
End Module

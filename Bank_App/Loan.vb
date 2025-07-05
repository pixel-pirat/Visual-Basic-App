Imports System.Data.SQLite

Public Class Loan

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoanTable()
    End Sub

    ' Load all loans into the grid
    Private Sub LoadLoanTable()
        Try
            OpenConn()
            Dim dt As New DataTable()
            Dim query As String =
                "SELECT a.account_number, l.amount, l.term, l.status, l.created_at
                 FROM loans l
                 INNER JOIN accounts a ON a.id = l.account_id
                 ORDER BY l.created_at DESC"

            Using adapter As New SQLiteDataAdapter(query, conn)
                adapter.Fill(dt)
                LoanTable.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading loan data: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Handle loan submission
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim accNumber = txtAccountNumber.Text.Trim
        Dim loanAmountStr = txtLoanAmount.Text.Trim
        Dim loanTermStr = txtLoanTerm.Text.Trim

        If accNumber = "" OrElse loanAmountStr = "" OrElse loanTermStr = "" Then
            MsgBox("All fields are required.")
            Return
        End If

        Dim amount As Double
        Dim term As Integer

        If Not Double.TryParse(loanAmountStr, amount) OrElse amount <= 0 Then
            MsgBox("Enter a valid loan amount.")
            Return
        End If

        If Not Integer.TryParse(loanTermStr, term) OrElse term <= 0 Then
            MsgBox("Enter a valid loan term.")
            Return
        End If

        Try
            OpenConn()

            ' ✅ Ensure we fetch account ID with the connection already open
            Dim accId = GetAccountId(accNumber, conn)
            If accId = 0 Then
                MsgBox("Account number not found.")
                Return
            End If

            ' Insert loan record
            Dim insertLoanQuery =
                "INSERT INTO loans (account_id, amount, term) VALUES (@acc, @amt, @term)"
            Using cmdLoan As New SQLiteCommand(insertLoanQuery, conn)
                cmdLoan.Parameters.AddWithValue("@acc", accId)
                cmdLoan.Parameters.AddWithValue("@amt", amount)
                cmdLoan.Parameters.AddWithValue("@term", term)
                cmdLoan.ExecuteNonQuery()
            End Using

            ' Update balance in accounts table
            Dim updateBalanceQuery =
                "UPDATE accounts SET balance = balance + @amount WHERE id = @accId"
            Using cmdUpdate As New SQLiteCommand(updateBalanceQuery, conn)
                cmdUpdate.Parameters.AddWithValue("@amount", amount)
                cmdUpdate.Parameters.AddWithValue("@accId", accId)
                cmdUpdate.ExecuteNonQuery()
            End Using

            MsgBox("Loan application submitted and balance updated successfully.")
            LoadLoanTable()
            ClearFormFields()

        Catch ex As Exception
            MsgBox("Error submitting loan: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Clear form fields after loan submission
    Private Sub ClearFormFields()
        txtAccountNumber.Clear()
        txtLoanAmount.Clear()
        txtLoanTerm.Clear()
    End Sub

    ' ✅ FIXED: Get account ID using an existing open connection
    Private Function GetAccountId(accountNumber As String, connection As SQLiteConnection) As Integer
        Try
            Using cmd As New SQLiteCommand("SELECT id FROM accounts WHERE account_number = @accNum", connection)
                cmd.Parameters.AddWithValue("@accNum", accountNumber)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error fetching account ID: " & ex.Message)
        End Try
        Return 0
    End Function

End Class

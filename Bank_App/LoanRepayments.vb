Imports System.Data.SQLite

Public Class LoanRepayments

    Private Sub LoanRepayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountNumbers()
    End Sub

    ' Load account numbers into ComboBox
    Private Sub LoadAccountNumbers()
        Try
            OpenConn()
            Dim cmd As New SQLiteCommand("SELECT account_number FROM accounts", conn)
            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbAccount.Items.Add(reader("account_number").ToString())
                End While
            End Using
        Catch ex As Exception
            MsgBox("Error loading accounts: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' When account is selected, load active loan
    Private Sub cmbAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccount.SelectedIndexChanged
        Dim accNumber As String = cmbAccount.SelectedItem.ToString()
        LoadActiveLoan(accNumber)
    End Sub

    Private Sub LoadActiveLoan(accountNumber As String)
        Try
            OpenConn()
            Dim cmd As New SQLiteCommand("
                SELECT l.id, l.amount, 
                       IFNULL(SUM(r.amount), 0) AS repaid,
                       (l.amount - IFNULL(SUM(r.amount), 0)) AS remaining
                FROM loans l
                LEFT JOIN loan_repayments r ON l.id = r.loan_id
                INNER JOIN accounts a ON a.id = l.account_id
                WHERE a.account_number = @accNum AND l.status = 'pending'
                GROUP BY l.id
                LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@accNum", accountNumber)

            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    lblLoanId.Text = reader("id").ToString()
                    lblRemaining.Text = reader("remaining").ToString()
                    LoadRepaymentHistory(Convert.ToInt32(reader("id")))
                Else
                    lblLoanId.Text = "N/A"
                    lblRemaining.Text = "0.00"
                    dgvLoanRepayment.DataSource = Nothing
                    MsgBox("No active loan found for this account.")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error loading loan: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    Private Sub LoadRepaymentHistory(loanId As Integer)
        Try
            Dim dt As New DataTable()
            Dim query As String = "
                SELECT amount AS 'Amount Paid',
                       repayment_date AS 'Date Paid'
                FROM loan_repayments
                WHERE loan_id = @loanId
                ORDER BY repayment_date DESC"
            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@loanId", loanId)
            Using adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dt)
                dgvLoanRepayment.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading repayment history: " & ex.Message)
        End Try
    End Sub

    ' Handle repayment
    Private Sub btnRepay_Click(sender As Object, e As EventArgs) Handles btnRepay.Click
        Dim repaymentAmount As Decimal
        If Not Decimal.TryParse(txtAmount.Text.Trim(), repaymentAmount) OrElse repaymentAmount <= 0 Then
            MsgBox("Enter a valid repayment amount.")
            Return
        End If

        If lblLoanId.Text = "N/A" Then
            MsgBox("No loan selected.")
            Return
        End If

        Dim loanId As Integer = Integer.Parse(lblLoanId.Text)
        Dim accNumber As String = cmbAccount.SelectedItem.ToString()

        Try
            OpenConn()

            ' Get account ID and current balance
            Dim getAccCmd As New SQLiteCommand("SELECT id, balance FROM accounts WHERE account_number = @acc", conn)
            getAccCmd.Parameters.AddWithValue("@acc", accNumber)
            Dim accReader = getAccCmd.ExecuteReader()
            Dim accId As Integer = 0
            Dim accBalance As Decimal = 0
            If accReader.Read() Then
                accId = Convert.ToInt32(accReader("id"))
                accBalance = Convert.ToDecimal(accReader("balance"))
            End If
            accReader.Close()

            If accBalance < repaymentAmount Then
                MsgBox("Insufficient balance to make repayment.")
                Return
            End If

            ' Insert repayment
            Dim repayCmd As New SQLiteCommand("
                INSERT INTO loan_repayments (loan_id, amount)
                VALUES (@loanId, @amount)", conn)
            repayCmd.Parameters.AddWithValue("@loanId", loanId)
            repayCmd.Parameters.AddWithValue("@amount", repaymentAmount)
            repayCmd.ExecuteNonQuery()

            ' Deduct from account balance
            Dim deductCmd As New SQLiteCommand("
                UPDATE accounts SET balance = balance - @amt WHERE id = @accId", conn)
            deductCmd.Parameters.AddWithValue("@amt", repaymentAmount)
            deductCmd.Parameters.AddWithValue("@accId", accId)
            deductCmd.ExecuteNonQuery()

            ' Check if loan is fully paid
            Dim checkLoanCmd As New SQLiteCommand("
                SELECT l.amount, IFNULL(SUM(r.amount), 0) AS repaid
                FROM loans l
                LEFT JOIN loan_repayments r ON l.id = r.loan_id
                WHERE l.id = @loanId
                GROUP BY l.id", conn)
            checkLoanCmd.Parameters.AddWithValue("@loanId", loanId)

            Dim loanReader = checkLoanCmd.ExecuteReader()
            If loanReader.Read() Then
                Dim totalLoan = Convert.ToDecimal(loanReader("amount"))
                Dim totalPaid = Convert.ToDecimal(loanReader("repaid"))
                If totalPaid >= totalLoan Then
                    ' Mark loan as paid
                    loanReader.Close()
                    Dim updateLoan = New SQLiteCommand("UPDATE loans SET status = 'paid' WHERE id = @id", conn)
                    updateLoan.Parameters.AddWithValue("@id", loanId)
                    updateLoan.ExecuteNonQuery()
                    MsgBox("Loan fully repaid!")
                Else
                    MsgBox("Repayment recorded.")
                End If
            End If
            loanReader.Close()

            ' Refresh
            txtAmount.Clear()
            LoadActiveLoan(accNumber)

        Catch ex As Exception
            MsgBox("Error processing repayment: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub
End Class

Imports System.Data.SQLite

Public Class Transactions

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionTable()
        LoadAccountNumbers()
    End Sub

    ' Load existing transactions into DataGridView
    Private Sub LoadTransactionTable()
        Try
            OpenConn()
            Dim dt As New DataTable()
            Dim adapter As New SQLiteDataAdapter("
                SELECT a.account_number, s.type, s.amount, s.transaction_date
                FROM savings s
                JOIN accounts a ON a.id = s.account_id
                ORDER BY s.transaction_date DESC", conn)
            adapter.Fill(dt)
            dgvTransactions.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Failed to load transactions: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Load available account numbers into ComboBox
    Private Sub LoadAccountNumbers()
        Try
            OpenConn()
            Dim cmd As New SQLiteCommand("SELECT account_number FROM accounts", conn)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbAccountNumber.Items.Add(reader("account_number").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Submit deposit or withdrawal
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim accountNumber As String = cmbAccountNumber.Text.Trim()
        Dim transType As String = cmbType.Text.Trim().ToLower()
        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse amount <= 0 Then
            MsgBox("Enter a valid amount.")
            Return
        End If

        If accountNumber = "" Or transType = "" Then
            MsgBox("Please select account number and transaction type.")
            Return
        End If

        Try
            OpenConn()

            ' Get account ID using an open connection
            Dim accId As Integer = GetAccountId(accountNumber, conn)
            If accId = 0 Then
                MsgBox("Invalid account number.")
                Return
            End If

            ' Check balance for withdrawal
            If transType = "withdraw" Then
                Dim checkCmd As New SQLiteCommand("SELECT balance FROM accounts WHERE id = @id", conn)
                checkCmd.Parameters.AddWithValue("@id", accId)
                Dim currentBalance As Decimal = Convert.ToDecimal(checkCmd.ExecuteScalar())

                If currentBalance < amount Then
                    MsgBox("Insufficient balance.")
                    Return
                End If
            End If

            ' Insert transaction into savings table
            Dim transCmd As New SQLiteCommand("
                INSERT INTO savings (account_id, amount, type)
                VALUES (@accId, @amount, @type)", conn)
            transCmd.Parameters.AddWithValue("@accId", accId)
            transCmd.Parameters.AddWithValue("@amount", amount)
            transCmd.Parameters.AddWithValue("@type", transType)
            transCmd.ExecuteNonQuery()

            ' Update account balance
            Dim updateCmd As New SQLiteCommand("
                UPDATE accounts 
                SET balance = balance " & If(transType = "deposit", "+", "-") & " @amount 
                WHERE id = @id", conn)
            updateCmd.Parameters.AddWithValue("@amount", amount)
            updateCmd.Parameters.AddWithValue("@id", accId)
            updateCmd.ExecuteNonQuery()

            MsgBox("Transaction recorded successfully.")

            ' Reset form and reload table
            txtAmount.Clear()
            cmbType.SelectedIndex = -1
            cmbAccountNumber.SelectedIndex = -1
            LoadTransactionTable()

        Catch ex As Exception
            MessageBox.Show("Error recording transaction: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Get account ID from account number using an open connection
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
            MessageBox.Show("Error fetching account ID: " & ex.Message)
        End Try
        Return 0
    End Function

End Class

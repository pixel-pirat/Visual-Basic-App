Imports System.Data.SQLite

Public Class Accounts

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountsTable()
    End Sub

    ' Load accounts into DataGridView
    Private Sub LoadAccountsTable()
        Try
            OpenConn()
            Dim dt As New DataTable()
            Dim query As String =
                "SELECT a.id, a.full_name, a.account_number, a.account_type, 
                        IFNULL(a.balance, 0) AS balance, a.created_at, u.username 
                 FROM accounts a
                 LEFT JOIN users u ON a.user_id = u.id
                 ORDER BY a.created_at DESC"

            Using adapter As New SQLiteDataAdapter(query, conn)
                adapter.Fill(dt)
                dgvAccounts.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading accounts: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Create new account
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim fullName = txtFullName.Text.Trim()
        Dim accountType = cmbAccountType.Text.Trim().ToLower()

        If fullName = "" OrElse accountType = "" Then
            MsgBox("Full name and account type are required.")
            Return
        End If

        Try
            Dim accountNumber = GenerateAccountNumber()
            Dim userId = 1 ' Replace with actual logged-in user
            Dim startingBalance As Double = 0

            OpenConn()
            Dim insertQuery =
                "INSERT INTO accounts (user_id, full_name, account_number, account_type, balance) 
                 VALUES (@user_id, @full_name, @account_number, @account_type, @balance)"

            Using cmd As New SQLiteCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@user_id", userId)
                cmd.Parameters.AddWithValue("@full_name", fullName)
                cmd.Parameters.AddWithValue("@account_number", accountNumber)
                cmd.Parameters.AddWithValue("@account_type", accountType)
                cmd.Parameters.AddWithValue("@balance", startingBalance)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Account created successfully!")
            LoadAccountsTable()
            ClearFormFields()
        Catch ex As Exception
            MsgBox("Error creating account: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Update selected account
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim fullName = txtFullName.Text.Trim()
        Dim accountType = cmbAccountType.Text.Trim().ToLower()
        Dim accountId As Integer

        If Not Integer.TryParse(txtAccountId.Text, accountId) OrElse fullName = "" Then
            MsgBox("Select a valid account to update.")
            Return
        End If

        Try
            OpenConn()
            Dim query = "UPDATE accounts SET full_name = @full_name, account_type = @account_type WHERE id = @id"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@full_name", fullName)
                cmd.Parameters.AddWithValue("@account_type", accountType)
                cmd.Parameters.AddWithValue("@id", accountId)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Account updated successfully!")
            LoadAccountsTable()
            ClearFormFields()
        Catch ex As Exception
            MsgBox("Error updating account: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Delete selected account
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim accountId As Integer
        If Not Integer.TryParse(txtAccountId.Text, accountId) Then
            MsgBox("Select an account to delete.")
            Return
        End If

        If MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

        Try
            OpenConn()
            Dim query = "DELETE FROM accounts WHERE id = @id"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", accountId)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Account deleted.")
            LoadAccountsTable()
            ClearFormFields()
        Catch ex As Exception
            MsgBox("Error deleting account: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Populate form on table click
    Private Sub dgvAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAccounts.Rows(e.RowIndex)
            txtAccountId.Text = row.Cells("id").Value.ToString()
            txtFullName.Text = row.Cells("full_name").Value.ToString()
            cmbAccountType.Text = row.Cells("account_type").Value.ToString()
        End If
    End Sub

    ' Clear form inputs
    Private Sub ClearFormFields()
        txtFullName.Clear()
        txtAccountId.Clear()
        cmbAccountType.SelectedIndex = -1
    End Sub

End Class

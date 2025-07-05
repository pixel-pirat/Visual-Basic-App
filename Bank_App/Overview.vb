Imports System.Data.SQLite
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Overview

    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSummaryCards()
        ' LoadAccountChart() ' You can enable this once charting is fixed
        LoadRecentActivity()
    End Sub

    ' Summary Cards
    Private Sub LoadSummaryCards()
        Try
            OpenConn()

            ' Replace 'Revenue' with Total Repayments from loan_repayments
            Dim revenueCmd As New SQLiteCommand("SELECT IFNULL(SUM(amount), 0) FROM loan_repayments", conn)
            lblRevenue.Text = "GH" & FormatCurrency(revenueCmd.ExecuteScalar().ToString(), 2)

            ' Total Accounts
            Dim accountsCmd As New SQLiteCommand("SELECT COUNT(*) FROM accounts", conn)
            lblAccounts.Text = accountsCmd.ExecuteScalar().ToString()

            ' Total Loans Taken
            Dim loansCmd As New SQLiteCommand("SELECT IFNULL(SUM(amount), 0) FROM loans", conn)
            lblLoans.Text = "GH" & FormatCurrency(loansCmd.ExecuteScalar().ToString(), 2)

        Catch ex As Exception
            MsgBox("Error loading summary: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

    ' Recent Activity (without transactions)
    Private Sub LoadRecentActivity()
        Try
            OpenConn()
            lstRecent.Items.Clear()

            Dim query As String = "
                SELECT 'Account Created: ' || account_number || ' at ' || created_at AS activity, created_at
                FROM accounts
                UNION
                SELECT 'Loan Taken: GHS' || amount || ' on ' || created_at, created_at
                FROM loans
                UNION
                SELECT 'Loan Repayment: GHS' || amount || ' on ' || repayment_date, repayment_date
                FROM loan_repayments
                ORDER BY created_at DESC
                LIMIT 10"
            Dim cmd As New SQLiteCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                lstRecent.Items.Add(reader("activity").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error loading recent activity: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub

End Class

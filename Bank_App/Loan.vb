Imports System.Data.SQLite

Public Class Loan
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDatabase()
    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnApplyLoan_Click(sender As Object, e As EventArgs) Handles btnApplyLoan.Click

        Dim accId As Integer = GetAccountId(txtAccountNumber.Text)
        If accId = 0 Then
            MsgBox("Invalid account.")
            Exit Sub
        End If

        Dim amount As Double = CDbl(txtLoanAmount.Text)
        Dim term As Integer = CInt(txtLoanTerm.Text)

        OpenConn()
        Dim cmd As New SQLiteCommand("INSERT INTO loans (account_id, amount, term) VALUES (@acc, @amt, @term)", conn)
        cmd.Parameters.AddWithValue("@acc", accId)
        cmd.Parameters.AddWithValue("@amt", amount)
        cmd.Parameters.AddWithValue("@term", term)
        cmd.ExecuteNonQuery()
        CloseConn()

        MsgBox("Loan application submitted.")



    End Sub
End Class

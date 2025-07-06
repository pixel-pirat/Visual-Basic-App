Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUserControl(New Overview())
    End Sub

    Private Sub LoadUserControl(control As UserControl)
        MainPanel.Controls.Clear()
        control.Dock = DockStyle.Fill
        MainPanel.Controls.Add(control)
    End Sub
    Private Sub dasboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        LoadUserControl(New Overview())
    End Sub
    Private Sub accountbtn_Click(sender As Object, e As EventArgs) Handles accountbtn.Click
        LoadUserControl(New Accounts())
    End Sub

    Private Sub transactionbtn_Click(sender As Object, e As EventArgs) Handles transactionbtn.Click
        LoadUserControl(New Transactions())
    End Sub
    Private Sub loanbtn_Click(sender As Object, e As EventArgs) Handles loanbtn.Click
        LoadUserControl(New Loan)
    End Sub

    Private Sub settingbtn_Click(sender As Object, e As EventArgs) Handles settingbtn.Click

    End Sub

    Private Sub supportbtn_Click(sender As Object, e As EventArgs) Handles supportbtn.Click

    End Sub

    Private Sub LoanPay_click(sender As Object, e As EventArgs) Handles LoanPay.Click
        LoadUserControl(New LoanRepayments())
    End Sub


    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class

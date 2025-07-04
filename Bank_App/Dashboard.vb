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
End Class

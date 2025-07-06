Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Get the entered username and password
        Dim username As String = email.Text.Trim()
        Dim password As String = Pass.Text

        ' Check credentials
        If username = "admin@acme" AndAlso password = "acme@1234" Then
            ' Login success
            Me.Hide()
            Dashboard.Show()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

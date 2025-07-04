<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BorderColor = Color.White
        Guna2CustomGradientPanel1.BorderRadius = 30
        Guna2CustomGradientPanel1.BorderThickness = 1
        Guna2CustomGradientPanel1.Controls.Add(Guna2Button1)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel3)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel2)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel1.FillColor = Color.Black
        Guna2CustomGradientPanel1.FillColor2 = Color.Gray
        Guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Guna2CustomGradientPanel1.Location = New Point(38, 110)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel1.Size = New Size(596, 274)
        Guna2CustomGradientPanel1.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = SystemColors.AppWorkspace
        Guna2HtmlLabel1.Location = New Point(26, 29)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(114, 27)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Total Revenue"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.White
        Guna2HtmlLabel2.Location = New Point(24, 59)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(243, 56)
        Guna2HtmlLabel2.TabIndex = 1
        Guna2HtmlLabel2.Text = "$ 300,000.00"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel3.Location = New Point(26, 187)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(190, 27)
        Guna2HtmlLabel3.TabIndex = 2
        Guna2HtmlLabel3.Text = "Trending up this month"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(469, 29)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(99, 32)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "+12.3%"
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "UserControl1"
        Size = New Size(1527, 1006)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        transactionForm = New Guna.UI2.WinForms.Guna2Panel()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(transactionForm)
        Guna2Panel1.Controls.Add(Guna2DataGridView1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(25, 48)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(1561, 884)
        Guna2Panel1.TabIndex = 4
        ' 
        ' transactionForm
        ' 
        transactionForm.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        transactionForm.CustomizableEdges = CustomizableEdges5
        transactionForm.Location = New Point(1050, 36)
        transactionForm.Name = "transactionForm"
        transactionForm.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        transactionForm.Size = New Size(487, 823)
        transactionForm.TabIndex = 1
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Guna2DataGridView1.BackgroundColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        Guna2DataGridView1.Location = New Point(24, 36)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 62
        Guna2DataGridView1.Size = New Size(994, 823)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 33
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 11F)
        Guna2HtmlLabel1.ForeColor = Color.White
        Guna2HtmlLabel1.Location = New Point(49, 13)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(58, 32)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "Loans"
        ' 
        ' Loan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2Panel1)
        Name = "Loan"
        Size = New Size(1610, 957)
        Guna2Panel1.ResumeLayout(False)
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents transactionForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel

End Class

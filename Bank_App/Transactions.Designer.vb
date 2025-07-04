<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        transactionForm = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 11F)
        Guna2HtmlLabel1.ForeColor = Color.White
        Guna2HtmlLabel1.Location = New Point(49, 16)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(122, 32)
        Guna2HtmlLabel1.TabIndex = 4
        Guna2HtmlLabel1.Text = "Transactions"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(transactionForm)
        Guna2Panel1.Controls.Add(Guna2DataGridView1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Location = New Point(25, 57)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(1561, 884)
        Guna2Panel1.TabIndex = 3
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.BackgroundColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
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
        ' transactionForm
        ' 
        transactionForm.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        transactionForm.CustomizableEdges = CustomizableEdges1
        transactionForm.Location = New Point(1050, 36)
        transactionForm.Name = "transactionForm"
        transactionForm.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        transactionForm.Size = New Size(487, 823)
        transactionForm.TabIndex = 1
        ' 
        ' Transactions
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2Panel1)
        Name = "Transactions"
        Size = New Size(1610, 957)
        Guna2Panel1.ResumeLayout(False)
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents transactionForm As Guna.UI2.WinForms.Guna2Panel

End Class

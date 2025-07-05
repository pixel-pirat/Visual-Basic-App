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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        txtLoanTerm = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        txtLoanAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtAccountNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        LoanTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        CType(LoanTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.Controls.Add(LoanTable)
        Guna2Panel1.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Location = New Point(25, 48)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.Size = New Size(1561, 884)
        Guna2Panel1.TabIndex = 4
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Panel2.Controls.Add(txtLoanTerm)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel7)
        Guna2Panel2.Controls.Add(btnSubmit)
        Guna2Panel2.Controls.Add(txtLoanAmount)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel4)
        Guna2Panel2.Controls.Add(txtAccountNumber)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel8)
        Guna2Panel2.CustomizableEdges = CustomizableEdges9
        Guna2Panel2.Location = New Point(1037, 36)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel2.Size = New Size(505, 823)
        Guna2Panel2.TabIndex = 2
        ' 
        ' txtLoanTerm
        ' 
        txtLoanTerm.BorderRadius = 10
        txtLoanTerm.CustomizableEdges = CustomizableEdges1
        txtLoanTerm.DefaultText = ""
        txtLoanTerm.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtLoanTerm.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtLoanTerm.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoanTerm.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoanTerm.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtLoanTerm.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoanTerm.Font = New Font("Segoe UI", 9F)
        txtLoanTerm.ForeColor = Color.White
        txtLoanTerm.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoanTerm.Location = New Point(31, 458)
        txtLoanTerm.Margin = New Padding(4, 5, 4, 5)
        txtLoanTerm.Name = "txtLoanTerm"
        txtLoanTerm.PlaceholderForeColor = Color.DimGray
        txtLoanTerm.PlaceholderText = "no. months"
        txtLoanTerm.SelectedText = ""
        txtLoanTerm.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtLoanTerm.Size = New Size(429, 51)
        txtLoanTerm.TabIndex = 10
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel7.ForeColor = Color.White
        Guna2HtmlLabel7.Location = New Point(31, 416)
        Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Guna2HtmlLabel7.Size = New Size(58, 34)
        Guna2HtmlLabel7.TabIndex = 9
        Guna2HtmlLabel7.Text = "Term"
        Guna2HtmlLabel7.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BorderRadius = 10
        btnSubmit.CustomizableEdges = CustomizableEdges3
        btnSubmit.DisabledState.BorderColor = Color.DarkGray
        btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray
        btnSubmit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSubmit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSubmit.FillColor = Color.White
        btnSubmit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(119, 594)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSubmit.Size = New Size(267, 51)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Confirm"
        ' 
        ' txtLoanAmount
        ' 
        txtLoanAmount.BorderRadius = 10
        txtLoanAmount.CustomizableEdges = CustomizableEdges5
        txtLoanAmount.DefaultText = ""
        txtLoanAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtLoanAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtLoanAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoanAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLoanAmount.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtLoanAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoanAmount.Font = New Font("Segoe UI", 9F)
        txtLoanAmount.ForeColor = Color.White
        txtLoanAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLoanAmount.Location = New Point(31, 341)
        txtLoanAmount.Margin = New Padding(4, 5, 4, 5)
        txtLoanAmount.Name = "txtLoanAmount"
        txtLoanAmount.PlaceholderForeColor = Color.DimGray
        txtLoanAmount.PlaceholderText = "0.00"
        txtLoanAmount.SelectedText = ""
        txtLoanAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtLoanAmount.Size = New Size(429, 51)
        txtLoanAmount.TabIndex = 5
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel4.ForeColor = Color.White
        Guna2HtmlLabel4.Location = New Point(31, 299)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(89, 34)
        Guna2HtmlLabel4.TabIndex = 4
        Guna2HtmlLabel4.Text = "Amount"
        Guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.BorderRadius = 10
        txtAccountNumber.CustomizableEdges = CustomizableEdges7
        txtAccountNumber.DefaultText = ""
        txtAccountNumber.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtAccountNumber.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtAccountNumber.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAccountNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAccountNumber.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtAccountNumber.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAccountNumber.Font = New Font("Segoe UI", 9F)
        txtAccountNumber.ForeColor = Color.White
        txtAccountNumber.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAccountNumber.Location = New Point(31, 212)
        txtAccountNumber.Margin = New Padding(4, 5, 4, 5)
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.PlaceholderForeColor = Color.DimGray
        txtAccountNumber.PlaceholderText = "1024XXXXXXXXX"
        txtAccountNumber.SelectedText = ""
        txtAccountNumber.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtAccountNumber.Size = New Size(429, 51)
        txtAccountNumber.TabIndex = 3
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel3.ForeColor = Color.White
        Guna2HtmlLabel3.Location = New Point(31, 170)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(185, 34)
        Guna2HtmlLabel3.TabIndex = 2
        Guna2HtmlLabel3.Text = "Account Number"
        Guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel2.ForeColor = Color.DarkGray
        Guna2HtmlLabel2.Location = New Point(134, 91)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(237, 34)
        Guna2HtmlLabel2.TabIndex = 1
        Guna2HtmlLabel2.Text = "Fill in the fields below"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.White
        Guna2HtmlLabel8.Location = New Point(161, 42)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(182, 50)
        Guna2HtmlLabel8.TabIndex = 0
        Guna2HtmlLabel8.Text = "Loan Form"
        Guna2HtmlLabel8.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' LoanTable
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        LoanTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        LoanTable.BackgroundColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        LoanTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        LoanTable.ColumnHeadersHeight = 4
        LoanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        LoanTable.DefaultCellStyle = DataGridViewCellStyle3
        LoanTable.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        LoanTable.Location = New Point(24, 36)
        LoanTable.Name = "LoanTable"
        LoanTable.RowHeadersVisible = False
        LoanTable.RowHeadersWidth = 62
        LoanTable.Size = New Size(994, 823)
        LoanTable.TabIndex = 0
        LoanTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        LoanTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        LoanTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        LoanTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        LoanTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        LoanTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        LoanTable.ThemeStyle.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        LoanTable.ThemeStyle.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        LoanTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        LoanTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        LoanTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        LoanTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        LoanTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        LoanTable.ThemeStyle.HeaderStyle.Height = 4
        LoanTable.ThemeStyle.ReadOnly = False
        LoanTable.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        LoanTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        LoanTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        LoanTable.ThemeStyle.RowsStyle.ForeColor = Color.White
        LoanTable.ThemeStyle.RowsStyle.Height = 33
        LoanTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        LoanTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
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
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        CType(LoanTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LoanTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLoanAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAccountNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtLoanTerm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel

End Class

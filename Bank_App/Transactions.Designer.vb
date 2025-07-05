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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        dgvTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbAccountNumber = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2Panel1.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel2.SuspendLayout()
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
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.Controls.Add(dgvTransactions)
        Guna2Panel1.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Location = New Point(25, 57)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.Size = New Size(1561, 884)
        Guna2Panel1.TabIndex = 3
        ' 
        ' dgvTransactions
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTransactions.BackgroundColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTransactions.ColumnHeadersHeight = 4
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTransactions.DefaultCellStyle = DataGridViewCellStyle3
        dgvTransactions.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        dgvTransactions.Location = New Point(24, 36)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.RowHeadersVisible = False
        dgvTransactions.RowHeadersWidth = 62
        dgvTransactions.Size = New Size(994, 823)
        dgvTransactions.TabIndex = 0
        dgvTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(44), CByte(48), CByte(52))
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTransactions.ThemeStyle.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        dgvTransactions.ThemeStyle.GridColor = Color.FromArgb(CByte(50), CByte(56), CByte(62))
        dgvTransactions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(15), CByte(16), CByte(18))
        dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTransactions.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvTransactions.ThemeStyle.HeaderStyle.Height = 4
        dgvTransactions.ThemeStyle.ReadOnly = False
        dgvTransactions.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTransactions.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvTransactions.ThemeStyle.RowsStyle.ForeColor = Color.White
        dgvTransactions.ThemeStyle.RowsStyle.Height = 33
        dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(114), CByte(117), CByte(119))
        dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Guna2Panel2.Controls.Add(cmbAccountNumber)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel5)
        Guna2Panel2.Controls.Add(cmbType)
        Guna2Panel2.Controls.Add(btnSubmit)
        Guna2Panel2.Controls.Add(txtAmount)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel4)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel8)
        Guna2Panel2.CustomizableEdges = CustomizableEdges9
        Guna2Panel2.Location = New Point(1036, 36)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel2.Size = New Size(505, 823)
        Guna2Panel2.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BorderRadius = 10
        btnSubmit.CustomizableEdges = CustomizableEdges5
        btnSubmit.DisabledState.BorderColor = Color.DarkGray
        btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray
        btnSubmit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSubmit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSubmit.FillColor = Color.White
        btnSubmit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(134, 602)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSubmit.Size = New Size(267, 51)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Confirm"
        ' 
        ' txtAmount
        ' 
        txtAmount.BorderRadius = 10
        txtAmount.CustomizableEdges = CustomizableEdges7
        txtAmount.DefaultText = ""
        txtAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAmount.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAmount.Font = New Font("Segoe UI", 9F)
        txtAmount.ForeColor = Color.White
        txtAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAmount.Location = New Point(31, 185)
        txtAmount.Margin = New Padding(4, 5, 4, 5)
        txtAmount.Name = "txtAmount"
        txtAmount.PlaceholderForeColor = Color.DimGray
        txtAmount.PlaceholderText = "0.00"
        txtAmount.SelectedText = ""
        txtAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtAmount.Size = New Size(429, 51)
        txtAmount.TabIndex = 5
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel4.ForeColor = Color.White
        Guna2HtmlLabel4.Location = New Point(31, 143)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(89, 34)
        Guna2HtmlLabel4.TabIndex = 4
        Guna2HtmlLabel4.Text = "Amount"
        Guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel3.ForeColor = Color.White
        Guna2HtmlLabel3.Location = New Point(31, 385)
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
        ' cmbType
        ' 
        cmbType.BackColor = Color.Transparent
        cmbType.BorderRadius = 10
        cmbType.CustomizableEdges = CustomizableEdges3
        cmbType.DrawMode = DrawMode.OwnerDrawFixed
        cmbType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbType.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cmbType.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbType.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbType.Font = New Font("Segoe UI", 10F)
        cmbType.ForeColor = Color.White
        cmbType.ItemHeight = 30
        cmbType.Items.AddRange(New Object() {"Deposit", "Withdrawal"})
        cmbType.ItemsAppearance.ForeColor = Color.White
        cmbType.Location = New Point(31, 314)
        cmbType.Name = "cmbType"
        cmbType.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cmbType.Size = New Size(429, 36)
        cmbType.TabIndex = 12
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel5.ForeColor = Color.White
        Guna2HtmlLabel5.Location = New Point(31, 274)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(184, 34)
        Guna2HtmlLabel5.TabIndex = 13
        Guna2HtmlLabel5.Text = "Transaction Type"
        Guna2HtmlLabel5.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' cmbAccountNumber
        ' 
        cmbAccountNumber.BackColor = Color.Transparent
        cmbAccountNumber.BorderRadius = 10
        cmbAccountNumber.CustomizableEdges = CustomizableEdges1
        cmbAccountNumber.DrawMode = DrawMode.OwnerDrawFixed
        cmbAccountNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAccountNumber.FillColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cmbAccountNumber.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbAccountNumber.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbAccountNumber.Font = New Font("Segoe UI", 10F)
        cmbAccountNumber.ForeColor = Color.White
        cmbAccountNumber.ItemHeight = 30
        cmbAccountNumber.Items.AddRange(New Object() {"1024XXXXXXXXX", "Deposit", "Withdrawal"})
        cmbAccountNumber.ItemsAppearance.ForeColor = Color.White
        cmbAccountNumber.Location = New Point(31, 439)
        cmbAccountNumber.Name = "cmbAccountNumber"
        cmbAccountNumber.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbAccountNumber.Size = New Size(429, 36)
        cmbAccountNumber.TabIndex = 14
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
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvTransactions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbAccountNumber As Guna.UI2.WinForms.Guna2ComboBox

End Class

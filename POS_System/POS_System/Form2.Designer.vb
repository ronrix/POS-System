<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SearchProductsView = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TransactionDetailsView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.username = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.transactionID = New System.Windows.Forms.TextBox()
        Me.barcodeInputBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.SearchProductsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TransactionDetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 463)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox6.Controls.Add(Me.SearchProductsView)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 78)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(241, 382)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'SearchProductsView
        '
        Me.SearchProductsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SearchProductsView.DefaultCellStyle = DataGridViewCellStyle1
        Me.SearchProductsView.Location = New System.Drawing.Point(3, 14)
        Me.SearchProductsView.Name = "SearchProductsView"
        Me.SearchProductsView.Size = New System.Drawing.Size(232, 362)
        Me.SearchProductsView.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.searchInput)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(241, 62)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Search Products:"
        '
        'searchInput
        '
        Me.searchInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchInput.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchInput.Location = New System.Drawing.Point(11, 34)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(210, 22)
        Me.searchInput.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.GroupBox1.Controls.Add(Me.totalLbl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 463)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'totalLbl
        '
        Me.totalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalLbl.AutoSize = True
        Me.totalLbl.BackColor = System.Drawing.Color.Transparent
        Me.totalLbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalLbl.Location = New System.Drawing.Point(647, 94)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(31, 36)
        Me.totalLbl.TabIndex = 5
        Me.totalLbl.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(540, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TOTAL: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox4.Controls.Add(Me.TransactionDetailsView)
        Me.GroupBox4.Location = New System.Drawing.Point(260, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 235)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product List"
        '
        'TransactionDetailsView
        '
        Me.TransactionDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDetailsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailsView.Location = New System.Drawing.Point(3, 16)
        Me.TransactionDetailsView.Name = "TransactionDetailsView"
        Me.TransactionDetailsView.Size = New System.Drawing.Size(466, 216)
        Me.TransactionDetailsView.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Controls.Add(Me.transactionID)
        Me.GroupBox3.Controls.Add(Me.barcodeInputBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(260, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 73)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.username, Me.ToolStripLabel2, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(466, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'username
        '
        Me.username.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.username.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(66, 22)
        Me.username.Text = "username"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel2.Text = "LOGOUT"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel1.Text = "User Manual"
        '
        'transactionID
        '
        Me.transactionID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionID.Location = New System.Drawing.Point(352, 47)
        Me.transactionID.Name = "transactionID"
        Me.transactionID.Size = New System.Drawing.Size(114, 22)
        Me.transactionID.TabIndex = 6
        '
        'barcodeInputBox
        '
        Me.barcodeInputBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcodeInputBox.Location = New System.Drawing.Point(105, 46)
        Me.barcodeInputBox.Name = "barcodeInputBox"
        Me.barcodeInputBox.Size = New System.Drawing.Size(117, 22)
        Me.barcodeInputBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Transaction ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Barcode:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(309, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 76)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "REFUND"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(513, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 77)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 463)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CashierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.SearchProductsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TransactionDetailsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionDetailsView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents transactionID As System.Windows.Forms.TextBox
    Friend WithEvents barcodeInputBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchProductsView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents username As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents totalLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class

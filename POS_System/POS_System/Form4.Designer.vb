<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RefundForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transactionCodeInput = New System.Windows.Forms.TextBox()
        Me.transactionView = New System.Windows.Forms.DataGridView()
        Me.TransactionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_SysteDataSet = New POS_System.POS_SysteDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransactionDetailsTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.TransactionDetailsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransactionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactiondateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.transactionView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Refund Form"
        '
        'transactionCodeInput
        '
        Me.transactionCodeInput.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionCodeInput.Location = New System.Drawing.Point(122, 79)
        Me.transactionCodeInput.Name = "transactionCodeInput"
        Me.transactionCodeInput.Size = New System.Drawing.Size(181, 21)
        Me.transactionCodeInput.TabIndex = 1
        '
        'transactionView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.transactionView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.transactionView.AutoGenerateColumns = False
        Me.transactionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.transactionView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionidDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.TransactiondateDataGridViewTextBoxColumn, Me.AssignedempDataGridViewTextBoxColumn})
        Me.transactionView.DataSource = Me.TransactionDetailsBindingSource
        Me.transactionView.Location = New System.Drawing.Point(123, 105)
        Me.transactionView.Name = "transactionView"
        Me.transactionView.Size = New System.Drawing.Size(496, 279)
        Me.transactionView.TabIndex = 2
        '
        'TransactionDetailsBindingSource
        '
        Me.TransactionDetailsBindingSource.DataMember = "TransactionDetails"
        Me.TransactionDetailsBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'POS_SysteDataSet
        '
        Me.POS_SysteDataSet.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Transaction ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 45)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(330, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Refund"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TransactionDetailsTableAdapter
        '
        Me.TransactionDetailsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_System.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TransactionidDataGridViewTextBoxColumn
        '
        Me.TransactionidDataGridViewTextBoxColumn.DataPropertyName = "transaction_id"
        Me.TransactionidDataGridViewTextBoxColumn.HeaderText = "transaction_id"
        Me.TransactionidDataGridViewTextBoxColumn.Name = "TransactionidDataGridViewTextBoxColumn"
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        '
        'TransactiondateDataGridViewTextBoxColumn
        '
        Me.TransactiondateDataGridViewTextBoxColumn.DataPropertyName = "transaction_date"
        Me.TransactiondateDataGridViewTextBoxColumn.HeaderText = "transaction_date"
        Me.TransactiondateDataGridViewTextBoxColumn.Name = "TransactiondateDataGridViewTextBoxColumn"
        '
        'AssignedempDataGridViewTextBoxColumn
        '
        Me.AssignedempDataGridViewTextBoxColumn.DataPropertyName = "assigned_emp"
        Me.AssignedempDataGridViewTextBoxColumn.HeaderText = "assigned_emp"
        Me.AssignedempDataGridViewTextBoxColumn.Name = "AssignedempDataGridViewTextBoxColumn"
        '
        'RefundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.ClientSize = New System.Drawing.Size(746, 473)
        Me.Controls.Add(Me.transactionCodeInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.transactionView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RefundForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.transactionView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents transactionCodeInput As TextBox
    Friend WithEvents transactionView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents POS_SysteDataSet As POS_SysteDataSet
    Friend WithEvents TransactionDetailsBindingSource As BindingSource
    Friend WithEvents TransactionDetailsTableAdapter As POS_SysteDataSetTableAdapters.TransactionDetailsTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransactionidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactiondateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignedempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

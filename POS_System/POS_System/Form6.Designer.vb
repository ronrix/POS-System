<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.POS_SysteDataSet = New POS_System.POS_SysteDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.suppliersTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New POS_System.POS_SysteDataSetTableAdapters.TableAdapterManager()
        Me.Supplier_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Company_nameTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel3 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IDLabel.Location = New System.Drawing.Point(11, 102)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(23, 17)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(446, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(527, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(608, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(110, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Supplier Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(268, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Company Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SuppliernameDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SuppliersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(679, 270)
        Me.DataGridView1.TabIndex = 15
        '
        'POS_SysteDataSet
        '
        Me.POS_SysteDataSet.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'SuppliernameDataGridViewTextBoxColumn
        '
        Me.SuppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.HeaderText = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.Name = "SuppliernameDataGridViewTextBoxColumn"
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "company_name"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "company_name"
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "_date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "_date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.invertoryTableAdapter = Nothing
        Me.TableAdapterManager.productsTableAdapter = Nothing
        Me.TableAdapterManager.refundsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.suppliesDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TORTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_System.POS_SysteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Supplier_nameTextBox
        '
        Me.Supplier_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "supplier_name", True))
        Me.Supplier_nameTextBox.Location = New System.Drawing.Point(113, 106)
        Me.Supplier_nameTextBox.Name = "Supplier_nameTextBox"
        Me.Supplier_nameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Supplier_nameTextBox.TabIndex = 16
        '
        'Company_nameTextBox
        '
        Me.Company_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "company_name", True))
        Me.Company_nameTextBox.Location = New System.Drawing.Point(271, 106)
        Me.Company_nameTextBox.Name = "Company_nameTextBox"
        Me.Company_nameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Company_nameTextBox.TabIndex = 17
        '
        'IDLabel3
        '
        Me.IDLabel3.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ID", True))
        Me.IDLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IDLabel3.Location = New System.Drawing.Point(40, 102)
        Me.IDLabel3.Name = "IDLabel3"
        Me.IDLabel3.Size = New System.Drawing.Size(34, 23)
        Me.IDLabel3.TabIndex = 18
        Me.IDLabel3.Text = "0"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(727, 422)
        Me.Controls.Add(Me.IDLabel3)
        Me.Controls.Add(Me.Company_nameTextBox)
        Me.Controls.Add(Me.Supplier_nameTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents POS_SysteDataSet As POS_SysteDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As POS_SysteDataSetTableAdapters.suppliersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As POS_SysteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Supplier_nameTextBox As TextBox
    Friend WithEvents Company_nameTextBox As TextBox
    Friend WithEvents IDLabel3 As Label
End Class

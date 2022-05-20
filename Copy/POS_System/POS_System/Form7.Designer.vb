<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TORSearchInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TORPrint = New System.Windows.Forms.Button()
        Me.POS_SysteDataSet = New POS_System.POS_SysteDataSet()
        Me.TORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.TORTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(62, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time of Records (TOR)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EmployeeDataGridViewTextBoxColumn, Me.TimeinDataGridViewTextBoxColumn, Me.TimeoutDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TORBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(65, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(704, 307)
        Me.DataGridView1.TabIndex = 1
        '
        'TORSearchInput
        '
        Me.TORSearchInput.Location = New System.Drawing.Point(65, 91)
        Me.TORSearchInput.Name = "TORSearchInput"
        Me.TORSearchInput.Size = New System.Drawing.Size(219, 20)
        Me.TORSearchInput.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(62, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search"
        '
        'TORPrint
        '
        Me.TORPrint.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TORPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TORPrint.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TORPrint.Location = New System.Drawing.Point(694, 91)
        Me.TORPrint.Name = "TORPrint"
        Me.TORPrint.Size = New System.Drawing.Size(75, 23)
        Me.TORPrint.TabIndex = 4
        Me.TORPrint.Text = "Print"
        Me.TORPrint.UseVisualStyleBackColor = False
        '
        'POS_SysteDataSet
        '
        Me.POS_SysteDataSet.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TORBindingSource
        '
        Me.TORBindingSource.DataMember = "TOR"
        Me.TORBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'TORTableAdapter
        '
        Me.TORTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        '
        'TimeinDataGridViewTextBoxColumn
        '
        Me.TimeinDataGridViewTextBoxColumn.DataPropertyName = "time_in"
        Me.TimeinDataGridViewTextBoxColumn.HeaderText = "time_in"
        Me.TimeinDataGridViewTextBoxColumn.Name = "TimeinDataGridViewTextBoxColumn"
        '
        'TimeoutDataGridViewTextBoxColumn
        '
        Me.TimeoutDataGridViewTextBoxColumn.DataPropertyName = "time_out"
        Me.TimeoutDataGridViewTextBoxColumn.HeaderText = "time_out"
        Me.TimeoutDataGridViewTextBoxColumn.Name = "TimeoutDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TORPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TORSearchInput)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TORSearchInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TORPrint As Button
    Friend WithEvents POS_SysteDataSet As POS_SysteDataSet
    Friend WithEvents TORBindingSource As BindingSource
    Friend WithEvents TORTableAdapter As POS_SysteDataSetTableAdapters.TORTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim Product_nameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim BarcodeLabel As System.Windows.Forms.Label
        Dim PcodeLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Inventory_codeLabel As System.Windows.Forms.Label
        Dim Product_nameLabel1 As System.Windows.Forms.Label
        Dim Total_stocksLabel As System.Windows.Forms.Label
        Dim Stocks_leftLabel As System.Windows.Forms.Label
        Dim Supplier_idLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim Product_nameLabel2 As System.Windows.Forms.Label
        Dim Total_receivedLabel As System.Windows.Forms.Label
        Dim IDLabel3 As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim IDLabel4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.DashboardPage = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductPage = New System.Windows.Forms.Panel()
        Me.productPrintBtn = New System.Windows.Forms.Button()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_SysteDataSet = New POS_System.POS_SysteDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addNew = New FontAwesome.Sharp.IconButton()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBtn = New FontAwesome.Sharp.IconButton()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.addBtn = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Product_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PcodeTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.InventoryPage = New System.Windows.Forms.Panel()
        Me.InventoryPrint = New System.Windows.Forms.Button()
        Me.IDLabel2 = New System.Windows.Forms.Label()
        Me.InvertoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inventorySaveBtn = New System.Windows.Forms.Button()
        Me.Supplier_idTextBox = New System.Windows.Forms.TextBox()
        Me.Stocks_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Total_stocksTextBox = New System.Windows.Forms.TextBox()
        Me.Product_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Inventory_codeTextBox = New System.Windows.Forms.TextBox()
        Me.searchLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.InvertoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.accountSettingBtn = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logoutBtn = New FontAwesome.Sharp.IconButton()
        Me.productBtn = New FontAwesome.Sharp.IconButton()
        Me.suppliesBtn = New FontAwesome.Sharp.IconButton()
        Me.inventoryBtn = New FontAwesome.Sharp.IconButton()
        Me.dashboardBtn = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.SuppliesPage = New System.Windows.Forms.Panel()
        Me.IDLabel5 = New System.Windows.Forms.Label()
        Me.SuppliesDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Total_receivedTextBox = New System.Windows.Forms.TextBox()
        Me.Product_nameTextBox3 = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox1 = New System.Windows.Forms.TextBox()
        Me.printSuppliesBtn = New System.Windows.Forms.Button()
        Me.showSupplierBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.supplySearchBox = New System.Windows.Forms.TextBox()
        Me.SuppliesDetailsView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalreceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatereceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliesDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_SysteDataSet2 = New POS_System.POS_SysteDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvertoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.productsTableAdapter()
        Me.TableAdapterManager = New POS_System.POS_SysteDataSetTableAdapters.TableAdapterManager()
        Me.InvertoryTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.invertoryTableAdapter()
        Me.InvertoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_SysteDataSet1 = New POS_System.POS_SysteDataSet()
        Me.InvertoryBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliesDetailsTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.suppliesDetailsTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.AccountPage = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.accountNewPasswordInput = New System.Windows.Forms.TextBox()
        Me.showUserManualBtn = New System.Windows.Forms.Button()
        Me.changePasswordBtn = New System.Windows.Forms.Button()
        Me.showTORBtn = New System.Windows.Forms.Button()
        Me.accountDelBtn = New System.Windows.Forms.Button()
        Me.accountSaveBtn = New System.Windows.Forms.Button()
        Me.accountAddNewBtn = New System.Windows.Forms.Button()
        Me.IDLabel6 = New System.Windows.Forms.Label()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.accountSettingsView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New POS_System.POS_SysteDataSetTableAdapters.UsersTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Product_nameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        BarcodeLabel = New System.Windows.Forms.Label()
        PcodeLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Inventory_codeLabel = New System.Windows.Forms.Label()
        Product_nameLabel1 = New System.Windows.Forms.Label()
        Total_stocksLabel = New System.Windows.Forms.Label()
        Stocks_leftLabel = New System.Windows.Forms.Label()
        Supplier_idLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        Product_nameLabel2 = New System.Windows.Forms.Label()
        Total_receivedLabel = New System.Windows.Forms.Label()
        IDLabel3 = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        IDLabel4 = New System.Windows.Forms.Label()
        Me.DashboardPage.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ProductPage.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryPage.SuspendLayout()
        CType(Me.InvertoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvertoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliesPage.SuspendLayout()
        CType(Me.SuppliesDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliesDetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliesDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvertoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvertoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_SysteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvertoryBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountPage.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountSettingsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_nameLabel
        '
        Product_nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Product_nameLabel.AutoSize = True
        Product_nameLabel.BackColor = System.Drawing.Color.Transparent
        Product_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_nameLabel.ForeColor = System.Drawing.Color.White
        Product_nameLabel.Location = New System.Drawing.Point(767, 219)
        Product_nameLabel.Name = "Product_nameLabel"
        Product_nameLabel.Size = New System.Drawing.Size(96, 17)
        Product_nameLabel.TabIndex = 10
        Product_nameLabel.Text = "product name:"
        '
        'PriceLabel
        '
        PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        PriceLabel.AutoSize = True
        PriceLabel.BackColor = System.Drawing.Color.Transparent
        PriceLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.ForeColor = System.Drawing.Color.White
        PriceLabel.Location = New System.Drawing.Point(815, 249)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(42, 17)
        PriceLabel.TabIndex = 11
        PriceLabel.Text = "price:"
        '
        'BarcodeLabel
        '
        BarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        BarcodeLabel.AutoSize = True
        BarcodeLabel.BackColor = System.Drawing.Color.Transparent
        BarcodeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeLabel.ForeColor = System.Drawing.Color.White
        BarcodeLabel.Location = New System.Drawing.Point(799, 279)
        BarcodeLabel.Name = "BarcodeLabel"
        BarcodeLabel.Size = New System.Drawing.Size(63, 17)
        BarcodeLabel.TabIndex = 12
        BarcodeLabel.Text = "barcode:"
        '
        'PcodeLabel
        '
        PcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        PcodeLabel.AutoSize = True
        PcodeLabel.BackColor = System.Drawing.Color.Transparent
        PcodeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PcodeLabel.ForeColor = System.Drawing.Color.White
        PcodeLabel.Location = New System.Drawing.Point(808, 193)
        PcodeLabel.Name = "PcodeLabel"
        PcodeLabel.Size = New System.Drawing.Size(51, 17)
        PcodeLabel.TabIndex = 13
        PcodeLabel.Text = "pcode:"
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(827, 163)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(23, 17)
        IDLabel.TabIndex = 20
        IDLabel.Text = "ID:"
        '
        'Inventory_codeLabel
        '
        Inventory_codeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Inventory_codeLabel.AutoSize = True
        Inventory_codeLabel.BackColor = System.Drawing.Color.Transparent
        Inventory_codeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Inventory_codeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Inventory_codeLabel.Location = New System.Drawing.Point(782, 164)
        Inventory_codeLabel.Name = "Inventory_codeLabel"
        Inventory_codeLabel.Size = New System.Drawing.Size(102, 17)
        Inventory_codeLabel.TabIndex = 11
        Inventory_codeLabel.Text = "inventory code:"
        '
        'Product_nameLabel1
        '
        Product_nameLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Product_nameLabel1.AutoSize = True
        Product_nameLabel1.BackColor = System.Drawing.Color.Transparent
        Product_nameLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_nameLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Product_nameLabel1.Location = New System.Drawing.Point(787, 203)
        Product_nameLabel1.Name = "Product_nameLabel1"
        Product_nameLabel1.Size = New System.Drawing.Size(96, 17)
        Product_nameLabel1.TabIndex = 12
        Product_nameLabel1.Text = "product name:"
        '
        'Total_stocksLabel
        '
        Total_stocksLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Total_stocksLabel.AutoSize = True
        Total_stocksLabel.BackColor = System.Drawing.Color.Transparent
        Total_stocksLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_stocksLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Total_stocksLabel.Location = New System.Drawing.Point(798, 239)
        Total_stocksLabel.Name = "Total_stocksLabel"
        Total_stocksLabel.Size = New System.Drawing.Size(80, 17)
        Total_stocksLabel.TabIndex = 13
        Total_stocksLabel.Text = "total stocks:"
        '
        'Stocks_leftLabel
        '
        Stocks_leftLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Stocks_leftLabel.AutoSize = True
        Stocks_leftLabel.BackColor = System.Drawing.Color.Transparent
        Stocks_leftLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stocks_leftLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Stocks_leftLabel.Location = New System.Drawing.Point(804, 277)
        Stocks_leftLabel.Name = "Stocks_leftLabel"
        Stocks_leftLabel.Size = New System.Drawing.Size(71, 17)
        Stocks_leftLabel.TabIndex = 14
        Stocks_leftLabel.Text = "stocks left:"
        '
        'Supplier_idLabel
        '
        Supplier_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Supplier_idLabel.AutoSize = True
        Supplier_idLabel.BackColor = System.Drawing.Color.Transparent
        Supplier_idLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Supplier_idLabel.Location = New System.Drawing.Point(806, 318)
        Supplier_idLabel.Name = "Supplier_idLabel"
        Supplier_idLabel.Size = New System.Drawing.Size(71, 17)
        Supplier_idLabel.TabIndex = 15
        Supplier_idLabel.Text = "supplier id:"
        '
        'IDLabel1
        '
        IDLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        IDLabel1.AutoSize = True
        IDLabel1.BackColor = System.Drawing.Color.Transparent
        IDLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IDLabel1.Location = New System.Drawing.Point(853, 131)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(23, 17)
        IDLabel1.TabIndex = 17
        IDLabel1.Text = "ID:"
        '
        'SupplierLabel
        '
        SupplierLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        SupplierLabel.AutoSize = True
        SupplierLabel.BackColor = System.Drawing.Color.Transparent
        SupplierLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupplierLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        SupplierLabel.Location = New System.Drawing.Point(816, 257)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(57, 17)
        SupplierLabel.TabIndex = 12
        SupplierLabel.Text = "supplier:"
        '
        'Product_nameLabel2
        '
        Product_nameLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Product_nameLabel2.AutoSize = True
        Product_nameLabel2.BackColor = System.Drawing.Color.Transparent
        Product_nameLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_nameLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Product_nameLabel2.Location = New System.Drawing.Point(787, 283)
        Product_nameLabel2.Name = "Product_nameLabel2"
        Product_nameLabel2.Size = New System.Drawing.Size(96, 17)
        Product_nameLabel2.TabIndex = 13
        Product_nameLabel2.Text = "product name:"
        '
        'Total_receivedLabel
        '
        Total_receivedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Total_receivedLabel.AutoSize = True
        Total_receivedLabel.BackColor = System.Drawing.Color.Transparent
        Total_receivedLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_receivedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Total_receivedLabel.Location = New System.Drawing.Point(787, 315)
        Total_receivedLabel.Name = "Total_receivedLabel"
        Total_receivedLabel.Size = New System.Drawing.Size(98, 17)
        Total_receivedLabel.TabIndex = 14
        Total_receivedLabel.Text = "total received:"
        '
        'IDLabel3
        '
        IDLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        IDLabel3.AutoSize = True
        IDLabel3.BackColor = System.Drawing.Color.Transparent
        IDLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IDLabel3.Location = New System.Drawing.Point(859, 216)
        IDLabel3.Name = "IDLabel3"
        IDLabel3.Size = New System.Drawing.Size(23, 17)
        IDLabel3.TabIndex = 16
        IDLabel3.Text = "ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        PasswordLabel.Location = New System.Drawing.Point(950, 209)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(74, 17)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "password:"
        '
        'UsernameLabel
        '
        UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        UsernameLabel.Location = New System.Drawing.Point(949, 183)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 7
        UsernameLabel.Text = "username:"
        '
        'IDLabel4
        '
        IDLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        IDLabel4.AutoSize = True
        IDLabel4.BackColor = System.Drawing.Color.Transparent
        IDLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IDLabel4.Location = New System.Drawing.Point(1003, 153)
        IDLabel4.Name = "IDLabel4"
        IDLabel4.Size = New System.Drawing.Size(25, 17)
        IDLabel4.TabIndex = 9
        IDLabel4.Text = "ID:"
        '
        'DashboardPage
        '
        Me.DashboardPage.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.DashboardPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DashboardPage.Controls.Add(Me.GroupBox3)
        Me.DashboardPage.Controls.Add(Me.IconPictureBox1)
        Me.DashboardPage.Controls.Add(Me.GroupBox1)
        Me.DashboardPage.Controls.Add(Me.GroupBox2)
        Me.DashboardPage.Controls.Add(Me.Label2)
        Me.DashboardPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardPage.Location = New System.Drawing.Point(200, 0)
        Me.DashboardPage.Name = "DashboardPage"
        Me.DashboardPage.Size = New System.Drawing.Size(1036, 571)
        Me.DashboardPage.TabIndex = 2
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wpforms
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 40
        Me.IconPictureBox1.Location = New System.Drawing.Point(41, 17)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 12
        Me.IconPictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(131, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REVENUE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(124, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 46)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "WHOLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REVENUE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(53, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(81, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dashboard"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(429, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 151)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TARGET"
        '
        'ProductPage
        '
        Me.ProductPage.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.ProductPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductPage.Controls.Add(Me.productPrintBtn)
        Me.ProductPage.Controls.Add(IDLabel)
        Me.ProductPage.Controls.Add(Me.IconPictureBox2)
        Me.ProductPage.Controls.Add(Me.IDTextBox)
        Me.ProductPage.Controls.Add(Me.Label3)
        Me.ProductPage.Controls.Add(Me.addNew)
        Me.ProductPage.Controls.Add(Me.ProductDGV)
        Me.ProductPage.Controls.Add(Me.deleteBtn)
        Me.ProductPage.Controls.Add(Me.updateBtn)
        Me.ProductPage.Controls.Add(Me.searchInput)
        Me.ProductPage.Controls.Add(Me.addBtn)
        Me.ProductPage.Controls.Add(Me.Label9)
        Me.ProductPage.Controls.Add(Me.Product_nameTextBox)
        Me.ProductPage.Controls.Add(Me.PcodeTextBox)
        Me.ProductPage.Controls.Add(PcodeLabel)
        Me.ProductPage.Controls.Add(Me.BarcodeTextBox)
        Me.ProductPage.Controls.Add(Product_nameLabel)
        Me.ProductPage.Controls.Add(PriceLabel)
        Me.ProductPage.Controls.Add(BarcodeLabel)
        Me.ProductPage.Controls.Add(Me.PriceTextBox)
        Me.ProductPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductPage.Location = New System.Drawing.Point(200, 0)
        Me.ProductPage.Name = "ProductPage"
        Me.ProductPage.Size = New System.Drawing.Size(1036, 571)
        Me.ProductPage.TabIndex = 9
        '
        'productPrintBtn
        '
        Me.productPrintBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productPrintBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productPrintBtn.Location = New System.Drawing.Point(690, 86)
        Me.productPrintBtn.Name = "productPrintBtn"
        Me.productPrintBtn.Size = New System.Drawing.Size(75, 23)
        Me.productPrintBtn.TabIndex = 22
        Me.productPrintBtn.Text = "Print"
        Me.productPrintBtn.UseVisualStyleBackColor = True
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(47, 18)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 9
        Me.IconPictureBox2.TabStop = False
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(862, 160)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 21
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'POS_SysteDataSet
        '
        Me.POS_SysteDataSet.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Products"
        '
        'addNew
        '
        Me.addNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.addNew.BackColor = System.Drawing.Color.IndianRed
        Me.addNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addNew.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNew.IconChar = FontAwesome.Sharp.IconChar.None
        Me.addNew.IconColor = System.Drawing.Color.Black
        Me.addNew.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addNew.Location = New System.Drawing.Point(823, 338)
        Me.addNew.Name = "addNew"
        Me.addNew.Size = New System.Drawing.Size(75, 40)
        Me.addNew.TabIndex = 20
        Me.addNew.Text = "Add New"
        Me.addNew.UseVisualStyleBackColor = False
        '
        'ProductDGV
        '
        Me.ProductDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDGV.AutoGenerateColumns = False
        Me.ProductDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PcodeDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn})
        Me.ProductDGV.DataSource = Me.ProductsBindingSource
        Me.ProductDGV.Location = New System.Drawing.Point(52, 115)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.Size = New System.Drawing.Size(712, 429)
        Me.ProductDGV.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PcodeDataGridViewTextBoxColumn
        '
        Me.PcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode"
        Me.PcodeDataGridViewTextBoxColumn.HeaderText = "pcode"
        Me.PcodeDataGridViewTextBoxColumn.Name = "PcodeDataGridViewTextBoxColumn"
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        '
        'deleteBtn
        '
        Me.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.deleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.deleteBtn.IconColor = System.Drawing.Color.Black
        Me.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteBtn.Location = New System.Drawing.Point(914, 384)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 40)
        Me.deleteBtn.TabIndex = 19
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'updateBtn
        '
        Me.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.updateBtn.BackColor = System.Drawing.Color.IndianRed
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.updateBtn.IconColor = System.Drawing.Color.Black
        Me.updateBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.updateBtn.Location = New System.Drawing.Point(823, 384)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 40)
        Me.updateBtn.TabIndex = 18
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'searchInput
        '
        Me.searchInput.Location = New System.Drawing.Point(56, 86)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(209, 20)
        Me.searchInput.TabIndex = 15
        '
        'addBtn
        '
        Me.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.addBtn.BackColor = System.Drawing.Color.IndianRed
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.addBtn.IconColor = System.Drawing.Color.Black
        Me.addBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addBtn.Location = New System.Drawing.Point(914, 338)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 40)
        Me.addBtn.TabIndex = 17
        Me.addBtn.Text = "Save"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(54, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Search:"
        '
        'Product_nameTextBox
        '
        Me.Product_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Product_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "product_name", True))
        Me.Product_nameTextBox.Location = New System.Drawing.Point(862, 216)
        Me.Product_nameTextBox.Name = "Product_nameTextBox"
        Me.Product_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Product_nameTextBox.TabIndex = 11
        '
        'PcodeTextBox
        '
        Me.PcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "pcode", True))
        Me.PcodeTextBox.Location = New System.Drawing.Point(862, 187)
        Me.PcodeTextBox.Name = "PcodeTextBox"
        Me.PcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PcodeTextBox.TabIndex = 14
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "barcode", True))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(862, 276)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarcodeTextBox.TabIndex = 13
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(862, 246)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 12
        '
        'InventoryPage
        '
        Me.InventoryPage.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.InventoryPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryPage.Controls.Add(Me.InventoryPrint)
        Me.InventoryPage.Controls.Add(IDLabel1)
        Me.InventoryPage.Controls.Add(Me.IDLabel2)
        Me.InventoryPage.Controls.Add(Me.inventorySaveBtn)
        Me.InventoryPage.Controls.Add(Supplier_idLabel)
        Me.InventoryPage.Controls.Add(Me.Supplier_idTextBox)
        Me.InventoryPage.Controls.Add(Stocks_leftLabel)
        Me.InventoryPage.Controls.Add(Me.Stocks_leftTextBox)
        Me.InventoryPage.Controls.Add(Total_stocksLabel)
        Me.InventoryPage.Controls.Add(Me.Total_stocksTextBox)
        Me.InventoryPage.Controls.Add(Product_nameLabel1)
        Me.InventoryPage.Controls.Add(Me.Product_nameTextBox1)
        Me.InventoryPage.Controls.Add(Inventory_codeLabel)
        Me.InventoryPage.Controls.Add(Me.Inventory_codeTextBox)
        Me.InventoryPage.Controls.Add(Me.searchLabel)
        Me.InventoryPage.Controls.Add(Me.TextBox1)
        Me.InventoryPage.Controls.Add(Me.IconPictureBox4)
        Me.InventoryPage.Controls.Add(Me.InvertoryDataGridView)
        Me.InventoryPage.Controls.Add(Me.Label4)
        Me.InventoryPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryPage.Location = New System.Drawing.Point(200, 0)
        Me.InventoryPage.Name = "InventoryPage"
        Me.InventoryPage.Size = New System.Drawing.Size(1036, 571)
        Me.InventoryPage.TabIndex = 10
        '
        'InventoryPrint
        '
        Me.InventoryPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventoryPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryPrint.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryPrint.Location = New System.Drawing.Point(701, 87)
        Me.InventoryPrint.Name = "InventoryPrint"
        Me.InventoryPrint.Size = New System.Drawing.Size(75, 23)
        Me.InventoryPrint.TabIndex = 19
        Me.InventoryPrint.Text = "Print"
        Me.InventoryPrint.UseVisualStyleBackColor = True
        '
        'IDLabel2
        '
        Me.IDLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IDLabel2.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "ID", True))
        Me.IDLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IDLabel2.Location = New System.Drawing.Point(880, 131)
        Me.IDLabel2.Name = "IDLabel2"
        Me.IDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel2.TabIndex = 18
        Me.IDLabel2.Text = "Label10"
        '
        'InvertoryBindingSource
        '
        Me.InvertoryBindingSource.DataMember = "invertory"
        Me.InvertoryBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'inventorySaveBtn
        '
        Me.inventorySaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.inventorySaveBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.inventorySaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventorySaveBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventorySaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.inventorySaveBtn.Location = New System.Drawing.Point(905, 366)
        Me.inventorySaveBtn.Name = "inventorySaveBtn"
        Me.inventorySaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.inventorySaveBtn.TabIndex = 17
        Me.inventorySaveBtn.Text = "Save"
        Me.inventorySaveBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.inventorySaveBtn.UseVisualStyleBackColor = False
        '
        'Supplier_idTextBox
        '
        Me.Supplier_idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Supplier_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "supplier_id", True))
        Me.Supplier_idTextBox.Location = New System.Drawing.Point(890, 318)
        Me.Supplier_idTextBox.Name = "Supplier_idTextBox"
        Me.Supplier_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Supplier_idTextBox.TabIndex = 16
        '
        'Stocks_leftTextBox
        '
        Me.Stocks_leftTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Stocks_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "stocks_left", True))
        Me.Stocks_leftTextBox.Location = New System.Drawing.Point(889, 277)
        Me.Stocks_leftTextBox.Name = "Stocks_leftTextBox"
        Me.Stocks_leftTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stocks_leftTextBox.TabIndex = 15
        '
        'Total_stocksTextBox
        '
        Me.Total_stocksTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Total_stocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "total_stocks", True))
        Me.Total_stocksTextBox.Location = New System.Drawing.Point(889, 239)
        Me.Total_stocksTextBox.Name = "Total_stocksTextBox"
        Me.Total_stocksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_stocksTextBox.TabIndex = 14
        '
        'Product_nameTextBox1
        '
        Me.Product_nameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Product_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "product_name", True))
        Me.Product_nameTextBox1.Location = New System.Drawing.Point(889, 203)
        Me.Product_nameTextBox1.Name = "Product_nameTextBox1"
        Me.Product_nameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Product_nameTextBox1.TabIndex = 13
        '
        'Inventory_codeTextBox
        '
        Me.Inventory_codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Inventory_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvertoryBindingSource, "inventory_code", True))
        Me.Inventory_codeTextBox.Location = New System.Drawing.Point(889, 164)
        Me.Inventory_codeTextBox.Name = "Inventory_codeTextBox"
        Me.Inventory_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Inventory_codeTextBox.TabIndex = 12
        '
        'searchLabel
        '
        Me.searchLabel.AutoSize = True
        Me.searchLabel.BackColor = System.Drawing.Color.Transparent
        Me.searchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchLabel.Location = New System.Drawing.Point(63, 69)
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(51, 17)
        Me.searchLabel.TabIndex = 11
        Me.searchLabel.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 20)
        Me.TextBox1.TabIndex = 10
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.IconPictureBox4.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 40
        Me.IconPictureBox4.Location = New System.Drawing.Point(66, 21)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox4.TabIndex = 9
        Me.IconPictureBox4.TabStop = False
        '
        'InvertoryDataGridView
        '
        Me.InvertoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvertoryDataGridView.AutoGenerateColumns = False
        Me.InvertoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.InvertoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvertoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InvertoryDataGridView.DataSource = Me.InvertoryBindingSource
        Me.InvertoryDataGridView.Location = New System.Drawing.Point(66, 115)
        Me.InvertoryDataGridView.Name = "InvertoryDataGridView"
        Me.InvertoryDataGridView.Size = New System.Drawing.Size(710, 444)
        Me.InvertoryDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "inventory_code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "inventory_code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "product_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "total_stocks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "total_stocks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "stocks_left"
        Me.DataGridViewTextBoxColumn5.HeaderText = "stocks_left"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "supplier_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "supplier_id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(104, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Inventory"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.accountSettingBtn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Controls.Add(Me.productBtn)
        Me.Panel1.Controls.Add(Me.suppliesBtn)
        Me.Panel1.Controls.Add(Me.inventoryBtn)
        Me.Panel1.Controls.Add(Me.dashboardBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 571)
        Me.Panel1.TabIndex = 1
        '
        'accountSettingBtn
        '
        Me.accountSettingBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.accountSettingBtn.BackColor = System.Drawing.Color.SkyBlue
        Me.accountSettingBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accountSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountSettingBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountSettingBtn.IconChar = FontAwesome.Sharp.IconChar.ShareSquare
        Me.accountSettingBtn.IconColor = System.Drawing.Color.Black
        Me.accountSettingBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.accountSettingBtn.IconSize = 30
        Me.accountSettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.accountSettingBtn.Location = New System.Drawing.Point(1, 307)
        Me.accountSettingBtn.Name = "accountSettingBtn"
        Me.accountSettingBtn.Size = New System.Drawing.Size(199, 36)
        Me.accountSettingBtn.TabIndex = 8
        Me.accountSettingBtn.Text = "ACCOUNT SETTING"
        Me.accountSettingBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.POS_System.My.Resources.Resources.logo_removebg_preview__4_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'logoutBtn
        '
        Me.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.logoutBtn.BackColor = System.Drawing.Color.IndianRed
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.logoutBtn.IconColor = System.Drawing.Color.Black
        Me.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logoutBtn.Location = New System.Drawing.Point(-1, 544)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(200, 28)
        Me.logoutBtn.TabIndex = 6
        Me.logoutBtn.Text = "LOGOUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'productBtn
        '
        Me.productBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.productBtn.BackColor = System.Drawing.Color.SkyBlue
        Me.productBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productBtn.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.productBtn.IconColor = System.Drawing.Color.Black
        Me.productBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.productBtn.IconSize = 30
        Me.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.productBtn.Location = New System.Drawing.Point(0, 209)
        Me.productBtn.Name = "productBtn"
        Me.productBtn.Size = New System.Drawing.Size(200, 36)
        Me.productBtn.TabIndex = 3
        Me.productBtn.Text = "PRODUCTS"
        Me.productBtn.UseVisualStyleBackColor = False
        '
        'suppliesBtn
        '
        Me.suppliesBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.suppliesBtn.BackColor = System.Drawing.Color.SkyBlue
        Me.suppliesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suppliesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppliesBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppliesBtn.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.suppliesBtn.IconColor = System.Drawing.Color.Black
        Me.suppliesBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.suppliesBtn.IconSize = 30
        Me.suppliesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.suppliesBtn.Location = New System.Drawing.Point(1, 275)
        Me.suppliesBtn.Name = "suppliesBtn"
        Me.suppliesBtn.Size = New System.Drawing.Size(199, 36)
        Me.suppliesBtn.TabIndex = 5
        Me.suppliesBtn.Text = "SUPPLIES TRANSACTION"
        Me.suppliesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.suppliesBtn.UseVisualStyleBackColor = False
        '
        'inventoryBtn
        '
        Me.inventoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inventoryBtn.BackColor = System.Drawing.Color.SkyBlue
        Me.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventoryBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryBtn.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.inventoryBtn.IconColor = System.Drawing.Color.Black
        Me.inventoryBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.inventoryBtn.IconSize = 30
        Me.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventoryBtn.Location = New System.Drawing.Point(0, 239)
        Me.inventoryBtn.Name = "inventoryBtn"
        Me.inventoryBtn.Size = New System.Drawing.Size(200, 36)
        Me.inventoryBtn.TabIndex = 4
        Me.inventoryBtn.Text = "INVENTORY"
        Me.inventoryBtn.UseVisualStyleBackColor = False
        '
        'dashboardBtn
        '
        Me.dashboardBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashboardBtn.BackColor = System.Drawing.Color.DarkOrange
        Me.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.dashboardBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.Wpforms
        Me.dashboardBtn.IconColor = System.Drawing.Color.Black
        Me.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dashboardBtn.IconSize = 30
        Me.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBtn.Location = New System.Drawing.Point(0, 176)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(200, 36)
        Me.dashboardBtn.TabIndex = 2
        Me.dashboardBtn.Text = "DASHBOARD"
        Me.dashboardBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(90, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Supplies Transaction"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.IconPictureBox3.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 40
        Me.IconPictureBox3.Location = New System.Drawing.Point(52, 18)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 9
        Me.IconPictureBox3.TabStop = False
        '
        'SuppliesPage
        '
        Me.SuppliesPage.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.SuppliesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuppliesPage.Controls.Add(Me.IDLabel5)
        Me.SuppliesPage.Controls.Add(Me.Total_receivedTextBox)
        Me.SuppliesPage.Controls.Add(Me.Product_nameTextBox3)
        Me.SuppliesPage.Controls.Add(Me.SupplierTextBox1)
        Me.SuppliesPage.Controls.Add(Me.printSuppliesBtn)
        Me.SuppliesPage.Controls.Add(Me.showSupplierBtn)
        Me.SuppliesPage.Controls.Add(Me.Button2)
        Me.SuppliesPage.Controls.Add(IDLabel3)
        Me.SuppliesPage.Controls.Add(Me.Button1)
        Me.SuppliesPage.Controls.Add(Total_receivedLabel)
        Me.SuppliesPage.Controls.Add(Product_nameLabel2)
        Me.SuppliesPage.Controls.Add(SupplierLabel)
        Me.SuppliesPage.Controls.Add(Me.Label10)
        Me.SuppliesPage.Controls.Add(Me.supplySearchBox)
        Me.SuppliesPage.Controls.Add(Me.SuppliesDetailsView)
        Me.SuppliesPage.Controls.Add(Me.IconPictureBox3)
        Me.SuppliesPage.Controls.Add(Me.Label5)
        Me.SuppliesPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuppliesPage.Location = New System.Drawing.Point(200, 0)
        Me.SuppliesPage.Name = "SuppliesPage"
        Me.SuppliesPage.Size = New System.Drawing.Size(1036, 571)
        Me.SuppliesPage.TabIndex = 11
        '
        'IDLabel5
        '
        Me.IDLabel5.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliesDetailsBindingSource1, "ID", True))
        Me.IDLabel5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IDLabel5.Location = New System.Drawing.Point(884, 216)
        Me.IDLabel5.Name = "IDLabel5"
        Me.IDLabel5.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel5.TabIndex = 24
        Me.IDLabel5.Text = "0"
        '
        'SuppliesDetailsBindingSource1
        '
        Me.SuppliesDetailsBindingSource1.DataMember = "suppliesDetails"
        Me.SuppliesDetailsBindingSource1.DataSource = Me.POS_SysteDataSet
        '
        'Total_receivedTextBox
        '
        Me.Total_receivedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliesDetailsBindingSource1, "total_received", True))
        Me.Total_receivedTextBox.Location = New System.Drawing.Point(879, 311)
        Me.Total_receivedTextBox.Name = "Total_receivedTextBox"
        Me.Total_receivedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_receivedTextBox.TabIndex = 23
        '
        'Product_nameTextBox3
        '
        Me.Product_nameTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliesDetailsBindingSource1, "product_name", True))
        Me.Product_nameTextBox3.Location = New System.Drawing.Point(878, 279)
        Me.Product_nameTextBox3.Name = "Product_nameTextBox3"
        Me.Product_nameTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.Product_nameTextBox3.TabIndex = 22
        '
        'SupplierTextBox1
        '
        Me.SupplierTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliesDetailsBindingSource1, "supplier", True))
        Me.SupplierTextBox1.Location = New System.Drawing.Point(878, 251)
        Me.SupplierTextBox1.Name = "SupplierTextBox1"
        Me.SupplierTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SupplierTextBox1.TabIndex = 21
        '
        'printSuppliesBtn
        '
        Me.printSuppliesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printSuppliesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printSuppliesBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printSuppliesBtn.Location = New System.Drawing.Point(689, 100)
        Me.printSuppliesBtn.Name = "printSuppliesBtn"
        Me.printSuppliesBtn.Size = New System.Drawing.Size(75, 23)
        Me.printSuppliesBtn.TabIndex = 20
        Me.printSuppliesBtn.Text = "Print"
        Me.printSuppliesBtn.UseVisualStyleBackColor = True
        '
        'showSupplierBtn
        '
        Me.showSupplierBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showSupplierBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showSupplierBtn.Location = New System.Drawing.Point(570, 100)
        Me.showSupplierBtn.Name = "showSupplierBtn"
        Me.showSupplierBtn.Size = New System.Drawing.Size(114, 23)
        Me.showSupplierBtn.TabIndex = 19
        Me.showSupplierBtn.Text = "Show Suppliers"
        Me.showSupplierBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(821, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(909, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(45, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Search by Product Name"
        '
        'supplySearchBox
        '
        Me.supplySearchBox.Location = New System.Drawing.Point(47, 105)
        Me.supplySearchBox.Name = "supplySearchBox"
        Me.supplySearchBox.Size = New System.Drawing.Size(210, 20)
        Me.supplySearchBox.TabIndex = 11
        '
        'SuppliesDetailsView
        '
        Me.SuppliesDetailsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuppliesDetailsView.AutoGenerateColumns = False
        Me.SuppliesDetailsView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SuppliesDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppliesDetailsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.SupplierDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn1, Me.TotalreceivedDataGridViewTextBoxColumn, Me.DatereceivedDataGridViewTextBoxColumn})
        Me.SuppliesDetailsView.DataSource = Me.SuppliesDetailsBindingSource
        Me.SuppliesDetailsView.Location = New System.Drawing.Point(47, 133)
        Me.SuppliesDetailsView.Name = "SuppliesDetailsView"
        Me.SuppliesDetailsView.Size = New System.Drawing.Size(717, 426)
        Me.SuppliesDetailsView.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        '
        'ProductnameDataGridViewTextBoxColumn1
        '
        Me.ProductnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn1.HeaderText = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn1.Name = "ProductnameDataGridViewTextBoxColumn1"
        '
        'TotalreceivedDataGridViewTextBoxColumn
        '
        Me.TotalreceivedDataGridViewTextBoxColumn.DataPropertyName = "total_received"
        Me.TotalreceivedDataGridViewTextBoxColumn.HeaderText = "total_received"
        Me.TotalreceivedDataGridViewTextBoxColumn.Name = "TotalreceivedDataGridViewTextBoxColumn"
        '
        'DatereceivedDataGridViewTextBoxColumn
        '
        Me.DatereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received"
        Me.DatereceivedDataGridViewTextBoxColumn.HeaderText = "date_received"
        Me.DatereceivedDataGridViewTextBoxColumn.Name = "DatereceivedDataGridViewTextBoxColumn"
        '
        'SuppliesDetailsBindingSource
        '
        Me.SuppliesDetailsBindingSource.DataMember = "suppliesDetails"
        Me.SuppliesDetailsBindingSource.DataSource = Me.POS_SysteDataSet2
        '
        'POS_SysteDataSet2
        '
        Me.POS_SysteDataSet2.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'InvertoryBindingSource1
        '
        Me.InvertoryBindingSource1.DataMember = "invertory"
        Me.InvertoryBindingSource1.DataSource = Me.POS_SysteDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.invertoryTableAdapter = Nothing
        Me.TableAdapterManager.productsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.refundsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.suppliesDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TORTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_System.POS_SysteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'InvertoryTableAdapter
        '
        Me.InvertoryTableAdapter.ClearBeforeFill = True
        '
        'InvertoryBindingSource2
        '
        Me.InvertoryBindingSource2.DataMember = "invertory"
        Me.InvertoryBindingSource2.DataSource = Me.POS_SysteDataSet
        '
        'POS_SysteDataSet1
        '
        Me.POS_SysteDataSet1.DataSetName = "POS_SysteDataSet"
        Me.POS_SysteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvertoryBindingSource3
        '
        Me.InvertoryBindingSource3.DataMember = "invertory"
        Me.InvertoryBindingSource3.DataSource = Me.POS_SysteDataSet1
        '
        'SuppliesDetailsTableAdapter
        '
        Me.SuppliesDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument2
        '
        '
        'PrintDocument3
        '
        '
        'AccountPage
        '
        Me.AccountPage.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.AccountPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AccountPage.Controls.Add(Me.Label13)
        Me.AccountPage.Controls.Add(Me.accountNewPasswordInput)
        Me.AccountPage.Controls.Add(Me.showUserManualBtn)
        Me.AccountPage.Controls.Add(Me.changePasswordBtn)
        Me.AccountPage.Controls.Add(Me.showTORBtn)
        Me.AccountPage.Controls.Add(Me.accountDelBtn)
        Me.AccountPage.Controls.Add(Me.accountSaveBtn)
        Me.AccountPage.Controls.Add(Me.accountAddNewBtn)
        Me.AccountPage.Controls.Add(IDLabel4)
        Me.AccountPage.Controls.Add(Me.IDLabel6)
        Me.AccountPage.Controls.Add(UsernameLabel)
        Me.AccountPage.Controls.Add(Me.UsernameTextBox)
        Me.AccountPage.Controls.Add(PasswordLabel)
        Me.AccountPage.Controls.Add(Me.PasswordTextBox)
        Me.AccountPage.Controls.Add(Me.Label12)
        Me.AccountPage.Controls.Add(Me.TextBox2)
        Me.AccountPage.Controls.Add(Me.accountSettingsView)
        Me.AccountPage.Controls.Add(Me.IconPictureBox5)
        Me.AccountPage.Controls.Add(Me.Label11)
        Me.AccountPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountPage.Location = New System.Drawing.Point(0, 0)
        Me.AccountPage.Name = "AccountPage"
        Me.AccountPage.Size = New System.Drawing.Size(1236, 571)
        Me.AccountPage.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(167, 469)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "New Password"
        '
        'accountNewPasswordInput
        '
        Me.accountNewPasswordInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.accountNewPasswordInput.Location = New System.Drawing.Point(169, 491)
        Me.accountNewPasswordInput.Name = "accountNewPasswordInput"
        Me.accountNewPasswordInput.Size = New System.Drawing.Size(211, 20)
        Me.accountNewPasswordInput.TabIndex = 17
        '
        'showUserManualBtn
        '
        Me.showUserManualBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.showUserManualBtn.Location = New System.Drawing.Point(649, 521)
        Me.showUserManualBtn.Name = "showUserManualBtn"
        Me.showUserManualBtn.Size = New System.Drawing.Size(135, 23)
        Me.showUserManualBtn.TabIndex = 16
        Me.showUserManualBtn.Text = "User Manual"
        Me.showUserManualBtn.UseVisualStyleBackColor = True
        '
        'changePasswordBtn
        '
        Me.changePasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.changePasswordBtn.Location = New System.Drawing.Point(169, 521)
        Me.changePasswordBtn.Name = "changePasswordBtn"
        Me.changePasswordBtn.Size = New System.Drawing.Size(211, 23)
        Me.changePasswordBtn.TabIndex = 15
        Me.changePasswordBtn.Text = "Change admin password"
        Me.changePasswordBtn.UseVisualStyleBackColor = True
        '
        'showTORBtn
        '
        Me.showTORBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showTORBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showTORBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showTORBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.showTORBtn.Location = New System.Drawing.Point(808, 119)
        Me.showTORBtn.Name = "showTORBtn"
        Me.showTORBtn.Size = New System.Drawing.Size(75, 23)
        Me.showTORBtn.TabIndex = 14
        Me.showTORBtn.Text = "Show TOR"
        Me.showTORBtn.UseVisualStyleBackColor = True
        '
        'accountDelBtn
        '
        Me.accountDelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.accountDelBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.accountDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountDelBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountDelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.accountDelBtn.Location = New System.Drawing.Point(1104, 260)
        Me.accountDelBtn.Name = "accountDelBtn"
        Me.accountDelBtn.Size = New System.Drawing.Size(75, 23)
        Me.accountDelBtn.TabIndex = 13
        Me.accountDelBtn.Text = "Delete"
        Me.accountDelBtn.UseVisualStyleBackColor = False
        '
        'accountSaveBtn
        '
        Me.accountSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.accountSaveBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.accountSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountSaveBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountSaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.accountSaveBtn.Location = New System.Drawing.Point(1023, 260)
        Me.accountSaveBtn.Name = "accountSaveBtn"
        Me.accountSaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.accountSaveBtn.TabIndex = 12
        Me.accountSaveBtn.Text = "Save"
        Me.accountSaveBtn.UseVisualStyleBackColor = False
        '
        'accountAddNewBtn
        '
        Me.accountAddNewBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.accountAddNewBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.accountAddNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountAddNewBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountAddNewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.accountAddNewBtn.Location = New System.Drawing.Point(942, 260)
        Me.accountAddNewBtn.Name = "accountAddNewBtn"
        Me.accountAddNewBtn.Size = New System.Drawing.Size(75, 23)
        Me.accountAddNewBtn.TabIndex = 11
        Me.accountAddNewBtn.Text = "Add New"
        Me.accountAddNewBtn.UseVisualStyleBackColor = False
        '
        'IDLabel6
        '
        Me.IDLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IDLabel6.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ID", True))
        Me.IDLabel6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IDLabel6.Location = New System.Drawing.Point(1030, 153)
        Me.IDLabel6.Name = "IDLabel6"
        Me.IDLabel6.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel6.TabIndex = 10
        Me.IDLabel6.Text = "0"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.POS_SysteDataSet
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(1030, 183)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 8
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(1030, 209)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(66, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Search"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(69, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 3
        '
        'accountSettingsView
        '
        Me.accountSettingsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accountSettingsView.AutoGenerateColumns = False
        Me.accountSettingsView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.accountSettingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.accountSettingsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.RoleDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn})
        Me.accountSettingsView.DataSource = Me.UsersBindingSource
        Me.accountSettingsView.Location = New System.Drawing.Point(69, 147)
        Me.accountSettingsView.Name = "accountSettingsView"
        Me.accountSettingsView.Size = New System.Drawing.Size(815, 291)
        Me.accountSettingsView.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ShareSquare
        Me.IconPictureBox5.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 40
        Me.IconPictureBox5.Location = New System.Drawing.Point(69, 28)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox5.TabIndex = 1
        Me.IconPictureBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(107, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Account Setting"
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(724, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 151)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TARGET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(121, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "WHOLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REVENUE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(50, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "2000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(115, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 46)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "WHOLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REVENUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(44, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 19)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "2000"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 571)
        Me.Controls.Add(Me.DashboardPage)
        Me.Controls.Add(Me.SuppliesPage)
        Me.Controls.Add(Me.ProductPage)
        Me.Controls.Add(Me.InventoryPage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccountPage)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.DashboardPage.ResumeLayout(False)
        Me.DashboardPage.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ProductPage.ResumeLayout(False)
        Me.ProductPage.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryPage.ResumeLayout(False)
        Me.InventoryPage.PerformLayout()
        CType(Me.InvertoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvertoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliesPage.ResumeLayout(False)
        Me.SuppliesPage.PerformLayout()
        CType(Me.SuppliesDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliesDetailsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliesDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvertoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvertoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_SysteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvertoryBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountPage.ResumeLayout(False)
        Me.AccountPage.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountSettingsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents suppliesBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents inventoryBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents productBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents dashboardBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DashboardPage As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductPage As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents InventoryPage As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents POS_SysteDataSet As POS_SysteDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As POS_SysteDataSetTableAdapters.productsTableAdapter
    Friend WithEvents PcodeTextBox As TextBox
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Product_nameTextBox As TextBox
    Friend WithEvents TableAdapterManager As POS_SysteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label9 As Label
    Friend WithEvents searchInput As TextBox
    Friend WithEvents deleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents addBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents addNew As FontAwesome.Sharp.IconButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents InvertoryBindingSource As BindingSource
    Friend WithEvents InvertoryTableAdapter As POS_SysteDataSetTableAdapters.invertoryTableAdapter
    Friend WithEvents InvertoryBindingSource1 As BindingSource
    Friend WithEvents InvertoryBindingSource2 As BindingSource
    Friend WithEvents POS_SysteDataSet1 As POS_SysteDataSet
    Friend WithEvents InvertoryBindingSource3 As BindingSource
    Friend WithEvents InvertoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProductDGV As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents POS_SysteDataSet2 As POS_SysteDataSet
    Friend WithEvents SuppliesDetailsBindingSource As BindingSource
    Friend WithEvents SuppliesDetailsTableAdapter As POS_SysteDataSetTableAdapters.suppliesDetailsTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SuppliesPage As Panel
    Friend WithEvents SuppliesDetailsView As DataGridView
    Friend WithEvents searchLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents inventorySaveBtn As Button
    Friend WithEvents Supplier_idTextBox As TextBox
    Friend WithEvents Stocks_leftTextBox As TextBox
    Friend WithEvents Total_stocksTextBox As TextBox
    Friend WithEvents Product_nameTextBox1 As TextBox
    Friend WithEvents Inventory_codeTextBox As TextBox
    Friend WithEvents IDLabel2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents supplySearchBox As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalreceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatereceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliesDetailsBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents printSuppliesBtn As Button
    Friend WithEvents showSupplierBtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Product_nameTextBox3 As TextBox
    Friend WithEvents SupplierTextBox1 As TextBox
    Friend WithEvents IDLabel5 As Label
    Friend WithEvents Total_receivedTextBox As TextBox
    Friend WithEvents InventoryPrint As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents productPrintBtn As Button
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents accountSettingBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents AccountPage As Panel
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents accountSettingsView As DataGridView
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As POS_SysteDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents accountDelBtn As Button
    Friend WithEvents accountSaveBtn As Button
    Friend WithEvents accountAddNewBtn As Button
    Friend WithEvents IDLabel6 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents showTORBtn As Button
    Friend WithEvents changePasswordBtn As Button
    Friend WithEvents showUserManualBtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents accountNewPasswordInput As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class

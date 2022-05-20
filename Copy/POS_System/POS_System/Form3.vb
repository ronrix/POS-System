Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports System.Drawing.Bitmap

Public Class AdminForm

    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)
    Dim cmd As New OleDbCommand

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_SysteDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.POS_SysteDataSet.Users)
        'TODO: This line of code loads data into the 'POS_SysteDataSet2.suppliesDetails' table. You can move, or remove it, as needed.
        Me.SuppliesDetailsTableAdapter.Fill(Me.POS_SysteDataSet2.suppliesDetails)

        'TODO: This line of code loads data into the 'POS_SysteDataSet1.invertory' table. You can move, or remove it, as needed.
        Me.InvertoryTableAdapter.Fill(Me.POS_SysteDataSet.invertory)

        'Me.InvertoryTableAdapter.Fill(Me.POS_SysteDataSet.invertory)
        'TODO: This line of code loads data into the 'POS_SysteDataSet.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.POS_SysteDataSet.products)

        ' open db connection
        ' connection.Open()

        ' active button - dashboard
        dashboardBtn.BackColor = Color.OrangeRed
        DashboardPage.BringToFront()

        ' remove the border in buttons
        dashboardBtn.FlatAppearance.BorderSize = 0
        productBtn.FlatAppearance.BorderSize = 0
        inventoryBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatAppearance.BorderSize = 0
        suppliesBtn.FlatAppearance.BorderSize = 0
        accountSettingBtn.FlatAppearance.BorderSize = 0


        ProductDGV.DataSource = ProductsBindingSource

        ' filter users table, don't show admin
        Me.UsersBindingSource.Filter = "role LIKE '%Cashier%'"

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        DashboardPage.BringToFront()
        ' active button - dashboard
        dashboardBtn.BackColor = Color.DarkOrange
        inventoryBtn.BackColor = Color.SkyBlue
        suppliesBtn.BackColor = Color.SkyBlue
        productBtn.BackColor = Color.SkyBlue
        accountSettingBtn.BackColor = Color.SkyBlue
    End Sub

    Private Sub productBtn_Click(sender As Object, e As EventArgs) Handles productBtn.Click
        ProductPage.BringToFront()
        ' active button - product
        dashboardBtn.BackColor = Color.SkyBlue
        productBtn.BackColor = Color.DarkOrange
        inventoryBtn.BackColor = Color.SkyBlue
        suppliesBtn.BackColor = Color.SkyBlue

        accountSettingBtn.BackColor = Color.SkyBlue

    End Sub

    Private Sub inventoryBtn_Click(sender As Object, e As EventArgs) Handles inventoryBtn.Click
        InventoryPage.BringToFront()
        ' active button - inventory
        dashboardBtn.BackColor = Color.SkyBlue
        productBtn.BackColor = Color.SkyBlue
        inventoryBtn.BackColor = Color.DarkOrange
        suppliesBtn.BackColor = Color.SkyBlue

        accountSettingBtn.BackColor = Color.SkyBlue
    End Sub

    Private Sub suppliesBtn_Click(sender As Object, e As EventArgs) Handles suppliesBtn.Click
        SuppliesPage.BringToFront()
        ' active button - supplies
        dashboardBtn.BackColor = Color.SkyBlue
        productBtn.BackColor = Color.SkyBlue
        inventoryBtn.BackColor = Color.SkyBlue
        suppliesBtn.BackColor = Color.DarkOrange
        accountSettingBtn.BackColor = Color.SkyBlue
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchInput.TextChanged
        Me.ProductsBindingSource.Filter = "product_name Like '%" & searchInput.Text & "%'"
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this record?", "Action", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ProductsTableAdapter.Insert(CInt(PcodeTextBox.Text), Product_nameTextBox.Text, PriceTextBox.Text, BarcodeTextBox.Text)
        Else
            MsgBox("Adding aborted!", MsgBoxStyle.Information)
            Return
        End If

        MsgBox("Product Successfully Added to the Lists!")
        Me.ProductsTableAdapter.Fill(Me.POS_SysteDataSet.products)
        'reset the datasource from the binding source
        Me.ProductDGV.DataSource = Me.ProductsBindingSource
        'should redraw with the new data
        Me.ProductDGV.Refresh()

        ' clear the textboxes
        Product_nameTextBox.Text = Nothing
        PcodeTextBox.Text = Nothing
        PriceTextBox.Text = Nothing
        BarcodeTextBox.Text = Nothing
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Action", MessageBoxButtons.YesNo)

        Dim access As String = "DELETE FROM products WHERE id=" & CInt(IDTextBox.Text)

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Delete aborted!", MsgBoxStyle.Information)
            Return
        End If


        connection.Close()
        MsgBox("Record Successfully Deleted")
        Me.ProductsTableAdapter.Fill(Me.POS_SysteDataSet.products)
        'reset the datasource from the binding source
        Me.ProductDGV.DataSource = Me.ProductsBindingSource
        'should redraw with the new data
        Me.ProductDGV.Refresh()


    End Sub


    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Action", MessageBoxButtons.YesNo)

        Dim access As String = "UPDATE products SET pcode=" & CInt(PcodeTextBox.Text) & ", product_name='" & Product_nameTextBox.Text & "', price=" & CInt(PriceTextBox.Text) & ", barcode='" & BarcodeTextBox.Text & "' where id=" & CInt(IDTextBox.Text) & ""

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Update aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.ProductsTableAdapter.Fill(Me.POS_SysteDataSet.products)
        'reset the datasource from the binding source
        Me.ProductDGV.DataSource = Me.ProductsBindingSource
        'should redraw with the new data
        Me.ProductDGV.Refresh()
    End Sub

    Private Sub addNew_Click(sender As Object, e As EventArgs) Handles addNew.Click
        Me.ProductsBindingSource.AddNew()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.InvertoryBindingSource.Filter = "product_name Like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub inventorySaveBtn_Click(sender As Object, e As EventArgs) Handles inventorySaveBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Action", MessageBoxButtons.YesNo)

        Dim access As String = "UPDATE invertory SET inventory_code=" & CInt(Inventory_codeTextBox.Text) & ", product_name='" & Product_nameTextBox1.Text & "', total_stocks=" & CInt(Total_stocksTextBox.Text) & ", stocks_left=" & Stocks_leftTextBox.Text & ", supplier_id=" & Supplier_idTextBox.Text & " where id=" & CInt(IDLabel2.Text) & ""

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Update aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.InvertoryTableAdapter.Fill(Me.POS_SysteDataSet.invertory)
        'reset the datasource from the binding source
        Me.InvertoryDataGridView.DataSource = Me.InvertoryBindingSource
        'should redraw with the new data
        Me.InvertoryDataGridView.Refresh()


    End Sub

    Private Sub supplySearchBox_TextChanged(sender As Object, e As EventArgs) Handles supplySearchBox.TextChanged
        Me.SuppliesDetailsBindingSource.Filter = "product_name LIKE '%" & supplySearchBox.Text & "%'"
    End Sub

    ' supplies save btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult

        If IDLabel5.Text = "0" Or IDLabel5.Text = "-1" Then
            result = MessageBox.Show("Are you sure you want to add this record?", "Action", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Me.SuppliesDetailsTableAdapter.Insert(SupplierTextBox1.Text, Product_nameTextBox3.Text, Total_receivedTextBox.Text, DateTime.Now())
                MsgBox("Record Successfully Saved")
                Me.SuppliesDetailsTableAdapter.Fill(Me.POS_SysteDataSet.suppliesDetails)
                'reset the datasource from the binding source
                Me.SuppliesDetailsView.DataSource = Me.SuppliesDetailsBindingSource
                'should redraw with the new data
                Me.SuppliesDetailsView.Refresh()
                Return
            End If
            MsgBox("Aborted!")
            Return
        End If

        result = MessageBox.Show("Are you sure you want to update this record?", "Action", MessageBoxButtons.YesNo)
        Dim access As String = "UPDATE suppliesDetails SET supplier=" & CInt(SupplierTextBox1.Text) & ", product_name='" & Product_nameTextBox3.Text & "', total_received=" & CInt(Total_receivedTextBox.Text) & " where id=" & CInt(IDLabel5.Text) & ""

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Update aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.SuppliesDetailsTableAdapter.Fill(Me.POS_SysteDataSet.suppliesDetails)
        'reset the datasource from the binding source
        Me.SuppliesDetailsView.DataSource = Me.SuppliesDetailsBindingSource
        'should redraw with the new data
        Me.SuppliesDetailsView.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SuppliesDetailsBindingSource.AddNew()
    End Sub

    Private Sub showSupplierBtn_Click(sender As Object, e As EventArgs) Handles showSupplierBtn.Click
        Form6.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'e.Graphics.DrawString("Hello, World!", Font, Brushes.Black, 302.86, 215.43)
        Dim bm As New Bitmap(SuppliesDetailsView.Width, SuppliesDetailsView.Height)

        SuppliesDetailsView.DrawToBitmap(bm, New Rectangle(0, 0, SuppliesDetailsView.Width, SuppliesDetailsView.Height))
        e.Graphics.DrawImage(bm, 80, 100)
    End Sub

    Private Sub printSuppliesBtn_Click(sender As Object, e As EventArgs) Handles printSuppliesBtn.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'e.Graphics.DrawString("Hello, World!", Font, Brushes.Black, 302.86, 215.43)
        Dim bm As New Bitmap(InvertoryDataGridView.Width, InvertoryDataGridView.Height)

        InvertoryDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, InvertoryDataGridView.Width, InvertoryDataGridView.Height))
        e.Graphics.DrawImage(bm, 80, 100)
    End Sub

    Private Sub InventoryPrint_Click(sender As Object, e As EventArgs) Handles InventoryPrint.Click
        PrintDialog1.Document = PrintDocument2
        PrintDialog1.PrinterSettings = PrintDocument2.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument2.Print()
        End If
    End Sub

    Private Sub productPrintBtn_Click(sender As Object, e As EventArgs) Handles productPrintBtn.Click
        PrintDialog1.Document = PrintDocument3
        PrintDialog1.PrinterSettings = PrintDocument3.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument3.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument3.Print()
        End If
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        'e.Graphics.DrawString("Hello, World!", Font, Brushes.Black, 302.86, 215.43)
        Dim bm As New Bitmap(ProductDGV.Width, ProductDGV.Height)

        ProductDGV.DrawToBitmap(bm, New Rectangle(0, 0, ProductDGV.Width, ProductDGV.Height))
        e.Graphics.DrawImage(bm, 80, 100)
    End Sub

    Private Sub accountSettingBtn_Click(sender As Object, e As EventArgs) Handles accountSettingBtn.Click
        AccountPage.BringToFront()
        ' active button - accountSetting
        dashboardBtn.BackColor = Color.SkyBlue
        inventoryBtn.BackColor = Color.SkyBlue
        suppliesBtn.BackColor = Color.SkyBlue
        productBtn.BackColor = Color.SkyBlue
        accountSettingBtn.BackColor = Color.DarkOrange
    End Sub

    Private Sub accountAddNewBtn_Click(sender As Object, e As EventArgs) Handles accountAddNewBtn.Click
        Me.UsersBindingSource.AddNew()
    End Sub

    Private Sub accountSaveBtn_Click(sender As Object, e As EventArgs) Handles accountSaveBtn.Click
        Dim result As DialogResult

        If IDLabel6.Text = "0" Or IDLabel6.Text = "-1" Then
            result = MessageBox.Show("Are you sure you want to add this account?", "Action", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Me.UsersTableAdapter.Insert("cashier", PasswordTextBox.Text, UsernameTextBox.Text)
                MsgBox("Record Successfully Saved")
                Me.UsersTableAdapter.Fill(Me.POS_SysteDataSet.Users)
                'reset the datasource from the binding source
                Me.accountSettingsView.DataSource = Me.UsersBindingSource
                'should redraw with the new data
                Me.accountSettingsView.Refresh()
                Return
            End If
            MsgBox("Aborted!")
            Return
        End If

        result = MessageBox.Show("Are you sure you want to update this account?", "Action", MessageBoxButtons.YesNo)
        Dim access As String = "UPDATE Users SET username=" & UsernameTextBox.Text & ", product_name='" & PasswordTextBox.Text & " where id=" & CInt(IDLabel6.Text) & ""

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Update aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.UsersTableAdapter.Fill(Me.POS_SysteDataSet.Users)
        'reset the datasource from the binding source
        Me.accountSettingsView.DataSource = Me.UsersBindingSource
        'should redraw with the new data
        Me.accountSettingsView.Refresh()
    End Sub

    Private Sub accountDelBtn_Click(sender As Object, e As EventArgs) Handles accountDelBtn.Click
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to delete this account?", "Action", MessageBoxButtons.YesNo)
        Dim access As String = "DELETE FROM Users where id=" & CInt(IDLabel6.Text)

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Deletion aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.UsersTableAdapter.Fill(Me.POS_SysteDataSet.Users)
        'reset the datasource from the binding source
        Me.accountSettingsView.DataSource = Me.UsersBindingSource
        'should redraw with the new data
        Me.accountSettingsView.Refresh()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.UsersBindingSource.Filter = "username LIKE '%" & TextBox2.Text & "%'"
    End Sub

    Private Sub changePasswordBtn_Click(sender As Object, e As EventArgs) Handles changePasswordBtn.Click
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to change your password?", "Action", MessageBoxButtons.YesNo)
        Dim access As String = "UPDATE Users SET [password]='" & CStr(accountNewPasswordInput.Text) & "' WHERE role='admin'"

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        If result = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Changing password aborted!", MsgBoxStyle.Information)
            Return
        End If
        MsgBox("Successfully changing the password!")
    End Sub

    Private Sub showTORBtn_Click(sender As Object, e As EventArgs) Handles showTORBtn.Click
        Form7.Show()
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        MsgBox("Supplies Printed!")
    End Sub

    Private Sub PrintDocument2_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument2.EndPrint
        MsgBox("Inventory Printed!")
    End Sub

    Private Sub PrintDocument3_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument3.EndPrint
        MsgBox("Products Printed!")
    End Sub
End Class
Imports System.Data.OleDb

Public Class CashierForm


    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)

    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    Dim i As Integer
    Dim j As Integer

    Dim whole_total As Double = 0


    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' add transaction id base on time in milliseconds
        transactionID.Text = Convert.ToString("" + Convert.ToString(DateTime.UtcNow().Year) + "" + CStr(DateTime.UtcNow().Month) + "" + CStr(DateTime.UtcNow().Day) + "" + Convert.ToString(DateTime.UtcNow().Millisecond) + "")

        ' refresh transaction table
        dbds = New DataSet
        tables = dbds.Tables

        Try
            dbda = New OleDbDataAdapter("select pcode, product_name, price, barcode from products where [product_name] like('" + searchInput.Text + "%')", connection)
            dbda.Fill(dbds, "products")
            Dim view As New DataView(tables(0))
            source.DataSource = view
            SearchProductsView.DataSource = view

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub barcodeInputBox_TextChanged(sender As Object, e As EventArgs) Handles barcodeInputBox.TextChanged

        If barcodeInputBox.Text = "" Or barcodeInputBox.TextLength < 10 Then
            Return
        End If

        If TransactionDetailsView.Rows.Count < 1 Then
            TransactionDetailsView.ColumnCount = 5

            TransactionDetailsView.Columns(0).Name = "product name"
            TransactionDetailsView.Columns(1).Name = "quantity"
            TransactionDetailsView.Columns(2).Name = "price"
            TransactionDetailsView.Columns(3).Name = "total"
            TransactionDetailsView.Columns(4).Name = "barcode"

        End If

        Dim cmd As New OleDbCommand("SELECT product_name, price, barcode FROM [products] WHERE barcode=@barcode", connection)

        cmd.Parameters.AddWithValue("@barcocde", barcodeInputBox.Text)

            connection.Open()
            Dim result = cmd.ExecuteReader

            Dim idx As Integer = 0

            While result.Read
                TransactionDetailsView.Rows.Add(result(0), "1", result(1), result(1), result(2))
            totalLbl.Text += CInt(result(1))
            whole_total = CInt(totalLbl.Text)
            barcodeInputBox.Text = ""
        End While


        connection.Close()

    End Sub

    Private Sub searchInput_TextChanged(sender As Object, e As EventArgs) Handles searchInput.TextChanged
        dbds = New DataSet
        tables = dbds.Tables

        Try
            dbda = New OleDbDataAdapter("select pcode, product_name, price, barcode from products where [product_name] like('" + searchInput.Text + "%')", connection)
            dbda.Fill(dbds, "products")
            Dim view As New DataView(tables(0))
            source.DataSource = view
            SearchProductsView.DataSource = view

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cellValues As New List(Of Object)

        If TransactionDetailsView.Rows.Count = Nothing Then
            Return
        End If

        Dim total As Double = 0

        For j = 0 To TransactionDetailsView.Rows.Count - 1
            ' qty
            cellValues.Add(TransactionDetailsView(1, j).Value)
            ' product name
            cellValues.Add(TransactionDetailsView(0, j).Value)
            ' price
            cellValues.Add(TransactionDetailsView(2, j).Value)

            ' get total
            total += TransactionDetailsView(2, j).Value * TransactionDetailsView(1, j).Value
        Next

        ' transaction ID kape boss
        PaymentForm.TextBox1.Text += vbTab + vbTab + vbTab + "Group1 " + vbNewLine + vbTab + vbTab + "Group 1 POS system " + vbNewLine + vbTab + "THIS SERVES AS YOUR OFFICIAL RECEIPT " + vbNewLine + vbNewLine + "---------------------------------------------" + vbNewLine + "transaction id: " + transactionID.Text + vbNewLine + "---------------------------------------------" + vbNewLine + "qty" + vbTab + "name" & vbTab & vbTab & vbTab + "price" + vbNewLine

        Dim handler As Integer = 0

        For Each value In cellValues
            If handler = 3 Then
                PaymentForm.TextBox1.Text += Convert.ToString(value) & vbTab & vbTab & vbNewLine
                handler = 0
            End If
            PaymentForm.TextBox1.Text += Convert.ToString(value) + vbTab
            handler += 1
        Next

        PaymentForm.TextBox1.Text += vbNewLine + "---------------------------------------------" + vbNewLine + vbNewLine + vbNewLine
        PaymentForm.TextBox1.Text += "Total: " + Convert.ToString(totalLbl.Text) + vbNewLine

        PaymentForm.TextBox1.Text += vbNewLine + vbNewLine + vbNewLine + "Thank you - Please Come Again!"

        PaymentForm.ShowDialog()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        ' add OTR
        Try
            Dim newCmd As New OleDbCommand("UPDATE TOR SET time_out=@out WHERE employee='" + username.Text + "' AND time_in IS NOT NULL", connection)

            newCmd.Parameters.AddWithValue("@out", Date.Now().TimeOfDay)
            connection.Open()
            newCmd.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RefundForm.Show()
    End Sub


    Private Sub TransactionDetailsView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDetailsView.CellValueChanged

        j = TransactionDetailsView.CurrentRow.Index

        ' qty
        Dim qty As Integer = TransactionDetailsView(1, j).Value

        ' price
        Dim price As Integer = TransactionDetailsView(2, j).Value

        ' get total
        Dim total As Integer
        total += TransactionDetailsView(2, j).Value * TransactionDetailsView(1, j).Value

        TransactionDetailsView(3, j).Value = total
        totalLbl.Text = total
        whole_total = total
    End Sub


    Private Sub SearchProductsView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchProductsView.CellClick
        Dim sI As Integer
        Dim pname, barcode As String
        Dim price As Integer


        sI = SearchProductsView.CurrentRow.Index

        ' input selected data to transaction table
        ' add columns details
        TransactionDetailsView.ColumnCount = 5

        TransactionDetailsView.Columns(0).Name = "product name"
        TransactionDetailsView.Columns(1).Name = "quantity"
        TransactionDetailsView.Columns(2).Name = "price"
        TransactionDetailsView.Columns(3).Name = "total"
        TransactionDetailsView.Columns(4).Name = "barcode"

        ' get data from this->table
        pname = SearchProductsView(1, sI).Value
        barcode = SearchProductsView(3, sI).Value
        price = SearchProductsView(2, sI).Value

        ' add data to the row
        Dim row As String() = New String() {pname, "1", price, price, barcode}
        TransactionDetailsView.Rows.Add(row)


        whole_total += price
        totalLbl.Text = whole_total

    End Sub

    Private Sub TransactionDetailsView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TransactionDetailsView.RowsAdded
        ' calculate total
        'For j = 0 To TransactionDetailsView.Rows.Count - 1

        '    ' get total
        '    total += TransactionDetailsView(2, j).Value * TransactionDetailsView(1, j).Value
        '    totalLbl.Text = total
        'Next

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        UserManual.Show()

    End Sub
End Class
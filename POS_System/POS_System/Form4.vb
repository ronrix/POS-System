Imports System.Data.OleDb
Public Class RefundForm

    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)

    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    Dim dg As New BindingSource

    Dim i As Integer

    Private Sub barcodeInput_TextChanged(sender As Object, e As EventArgs) Handles transactionCodeInput.TextChanged
        dbds = New DataSet
        tables = dbds.Tables
        If transactionCodeInput.Text = Nothing Then
            Return
        End If


        Try
            'dbda = New OleDbDataAdapter("SELECT transaction_id, product_name, qty, total, barcode, transaction_date, assigned_emp from TransactionDetails where transaction_id LIKE '%" + transactionCodeInput.Text + "%'", connection)
            'dbda.Fill(dbds, "TransactionDetails")
            'Dim view As New DataView(dbds.Tables(0))
            'source.DataSource = view
            'transactionView.DataSource = view

            TransactionDetailsBindingSource.Filter = "Convert(transaction_id, 'System.String') LIKE '%" + transactionCodeInput.Text + "%'"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tId As Integer
        Dim prod_name As String
        Dim cmd As OleDbCommand
        Dim newCmd As OleDbCommand

        Try
            tId = transactionView.Item(0, i).Value
            prod_name = transactionView.Item(1, i).Value


            ' deletion
            cmd = New OleDbCommand("DELETE FROM TransactionDetails WHERE transaction_id=@id and product_name=@name", connection)
            ' delete value parameter
            ' insert value parameter        

            cmd.Parameters.AddWithValue("@id", tId)
            cmd.Parameters.AddWithValue("@name", prod_name)

            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()
            newCmd = New OleDbCommand("INSERT INTO refunds([transaction_id], [product_name], [barcode], [qty], [total], [transaction_date], [assigned_emp]) VALUES(@transaction_id, @product_name, @barcode, @qty, @total, @transaction_date, @assigned_emp)", connection)

            newCmd.Parameters.Add("@transaction_id", OleDbType.Integer).Value = transactionView.Item(0, i).Value
            newCmd.Parameters.Add("@product_name", OleDbType.VarChar).Value = transactionView.Item(1, i).Value
            newCmd.Parameters.Add("@barcode", OleDbType.VarChar).Value = transactionView.Item(5, i).Value
            newCmd.Parameters.Add("@qty", OleDbType.Integer).Value = transactionView.Item(2, i).Value

            newCmd.Parameters.Add("@total", OleDbType.Integer).Value = transactionView.Item(4, i).Value

            newCmd.Parameters.Add("@transaction_date", OleDbType.Date).Value = CStr(DateTime.Now())
            newCmd.Parameters.Add("@assigned_emp", OleDbType.VarChar).Value = transactionView.Item(6, i).Value

            connection.Open()
            newCmd.ExecuteNonQuery()

            MsgBox("Refund Successfull")

            connection.Close()
            Me.TransactionDetailsTableAdapter.Fill(Me.POS_SysteDataSet.TransactionDetails)
            'reset the datasource from the binding source
            Me.transactionView.DataSource = Me.TransactionDetailsBindingSource
            'should redraw with the new data
            Me.transactionView.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub transactionView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles transactionView.CellClick
        i = transactionView.CurrentRow.Index
    End Sub

    Private Sub RefundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_SysteDataSet.TransactionDetails' table. You can move, or remove it, as needed.
        Me.TransactionDetailsTableAdapter.Fill(Me.POS_SysteDataSet.TransactionDetails)
        transactionCodeInput.Select()

    End Sub


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
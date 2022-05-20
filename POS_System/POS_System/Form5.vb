Imports System.Data.OleDb
Public Class PaymentForm
    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)

    Dim total As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        CashierForm.TransactionDetailsView.Rows.Clear()
        CashierForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If TextBox2.Text = "" Then
            Return
        End If

        For Each row As DataGridViewRow In CashierForm.TransactionDetailsView.Rows
            Dim obj(row.Cells.Count - 1) As Object
            For i = 0 To row.Cells.Count - 1
                obj(i) = row.Cells(i).Value
            Next

            ' check inventory if the stock of any product is still good
            ' update inventory 
            Try
                Using u_inv As New OleDbCommand("UPDATE invertory SET stocks_left=invertory.stocks_left-" & CInt(obj(1)) & " WHERE [product_name]='" & obj(0) & "'", connection)
                    connection.Open()
                    u_inv.ExecuteNonQuery()
                    connection.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ' insert each row to database

            ' issue -> parameter barcode has no default value
            Try

                Using comd As New OleDbCommand("INSERT INTO TransactionDetails([transaction_id], [product_name], [qty], [price], [total], [barcode], [transaction_date], [assigned_emp]) VALUES(@transactionID, @pname, @qty, @price, @total, @barcode, @date, @emp_name)", connection)
                    comd.Parameters.Add("@transactionID", OleDbType.Integer).Value = CInt(CashierForm.transactionID.Text)
                    Dim prodName As String = "null"

                    comd.Parameters.Add("@pname", OleDbType.VarChar).Value = Convert.ToString(obj(0))
                    comd.Parameters.Add("@qty", OleDbType.Integer).Value = CInt(obj(1))
                    comd.Parameters.Add("@price", OleDbType.Integer).Value = CInt(obj(2))
                    comd.Parameters.Add("@total", OleDbType.Double).Value = CDbl(obj(3))

                    comd.Parameters.Add("@barcode", OleDbType.VarChar).Value = IIf(obj(4), Convert.ToString(obj(4)), Convert.ToString(" "))
                    'comd.Parameters.AddWithValue("@barcode", obj(4))

                    comd.Parameters.Add("@date", OleDbType.VarChar).Value = CStr(DateTime.Now())
                    comd.Parameters.Add("@emp_name", OleDbType.VarChar).Value = CStr(CashierForm.username.Text)

                    connection.Open()
                    comd.ExecuteNonQuery()

                    connection.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

            ' delete obj's data
            obj = Nothing

        Next



        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

            ' clear transaction table and barcode on cashier form
            CashierForm.TransactionDetailsView.Rows.Clear()
            CashierForm.barcodeInputBox.Text = Nothing

            CashierForm.transactionID.Text = Convert.ToInt32(DateTime.UtcNow().Millisecond)

            ' clear print textbox
            TextBox1.Text = Nothing

            ' back to the cashier form
            CashierForm.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, Font, Brushes.Black, 302.86, 215.43)

    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        MsgBox("Receipt Printed!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form8.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not TextBox2.Text = "" Then
            TextBox2.AppendText(Button16.Text)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.AppendText(Button11.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        TextBox2.AppendText(Button12.Text)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        TextBox2.AppendText(Button13.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox2.AppendText(Button8.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox2.AppendText(Button9.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox2.AppendText(Button10.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox2.AppendText(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox2.AppendText(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox2.AppendText(Button7.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'DiscountForm.ShowDialog()
        CashierForm.totalLbl.Text = CDbl(CashierForm.totalLbl.Text) - CDbl(CashierForm.totalLbl.Text) * 0.03
        If changeLabel.Text = "" Then
            Return
        End If
        changeLabel.Text = TextBox2.Text - CashierForm.totalLbl.Text
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Return
        End If
        changeLabel.Text = CDbl(TextBox2.Text) - CDbl(CashierForm.totalLbl.Text)
    End Sub

End Class
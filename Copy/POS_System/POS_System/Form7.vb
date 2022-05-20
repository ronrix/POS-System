Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_SysteDataSet.TOR' table. You can move, or remove it, as needed.
        Me.TORTableAdapter.Fill(Me.POS_SysteDataSet.TOR)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'e.Graphics.DrawString("Hello, World!", Font, Brushes.Black, 302.86, 215.43)
        Dim bm As New Bitmap(DataGridView1.Width, DataGridView1.Height)

        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        e.Graphics.DrawImage(bm, 80, 100)
    End Sub

    Private Sub TORPrint_Click(sender As Object, e As EventArgs) Handles TORPrint.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub TORSearchInput_TextChanged(sender As Object, e As EventArgs) Handles TORSearchInput.TextChanged
        Me.TORBindingSource.Filter = "employee LIKE '%" & TORSearchInput.Text & "%'"
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        MsgBox("TOR Printed!")
    End Sub
End Class
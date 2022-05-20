Imports System.Data.OleDb
Public Class Form6

    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)
    Dim cmd As New OleDbCommand

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_SysteDataSet.suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.POS_SysteDataSet.suppliers)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.SuppliersBindingSource.Filter = "company_name LIKE '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SuppliersBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dialog As DialogResult

        ' insert
        If IDLabel3.Text = "0" Or IDLabel3.Text = "-1" Then
            dialog = MessageBox.Show("Are you sure you want to add this record?", "Action", MessageBoxButtons.YesNo)

            If dialog = DialogResult.Yes Then

                Me.SuppliersTableAdapter.Insert(Supplier_nameTextBox.Text, Company_nameTextBox.Text, DateTime.Now())

                MsgBox("Successfully added the record!")
                Me.SuppliersTableAdapter.Fill(Me.POS_SysteDataSet.suppliers)
                'reset the datasource from the binding source
                Me.DataGridView1.DataSource = Me.SuppliersBindingSource
                'should redraw with the new data
                Me.DataGridView1.Refresh()
                Return
            End If
            MsgBox("Aborted!")

            Return
        End If

        ' update

        Dim access As String = "UPDATE suppliers SET supplier_name='" & Supplier_nameTextBox.Text & "', company_name='" & Company_nameTextBox.Text & "' where id=" & CInt(IDLabel3.Text) & ""

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        dialog = MessageBox.Show("Are you sure you want to update this record?", "Action", MessageBoxButtons.YesNo)

        If dialog = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Update aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Updated")
        Me.SuppliersTableAdapter.Fill(Me.POS_SysteDataSet.suppliers)
        'reset the datasource from the binding source
        Me.DataGridView1.DataSource = Me.SuppliersBindingSource
        'should redraw with the new data
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As DialogResult


        Dim access As String = "DELETE FROM suppliers where id=" & CInt(IDLabel3.Text)

        connection.Open()

        cmd.Connection = connection
        cmd.CommandText = access

        dialog = MessageBox.Show("Are you sure you want to delete this record?", "Action", MessageBoxButtons.YesNo)

        If dialog = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
            connection.Close()
            MsgBox("Delete Aborted!", MsgBoxStyle.Information)
            Return
        End If

        connection.Close()
        MsgBox("Record Successfully Deleted")
        Me.SuppliersTableAdapter.Fill(Me.POS_SysteDataSet.suppliers)
        'reset the datasource from the binding source
        Me.DataGridView1.DataSource = Me.SuppliersBindingSource
        'should redraw with the new data
        Me.DataGridView1.Refresh()
    End Sub
End Class
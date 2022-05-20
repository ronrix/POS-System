Imports System.Data.OleDb
Imports System.Data

Public Class LoginForm

    Dim connection As New OleDbConnection(My.Settings.POS_SysteConnectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If RoleBox.Text = Nothing Or InputPass.Text = Nothing Then
            MsgBox("Enter Credentials ", MsgBoxStyle.Exclamation)
            Return
        End If


        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim cmd As New OleDbCommand("SELECT role, username FROM Users WHERE role=? AND password=?", connection)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = RoleBox.Text
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = InputPass.Text

        Dim ress = cmd.ExecuteReader
        Dim username = Nothing
        Dim role = Nothing

        While ress.Read()
            username = ress(1)
            role = ress(0)
        End While


        connection.Close()

        If Not String.IsNullOrEmpty(username) Then

            MsgBox("Login Passed", MsgBoxStyle.Information)

            If role = "cashier" Then
                InputPass.Text = ""
                CashierForm.username.Text = username

                ' add TOR
                Try
                    Dim newCmd As New OleDbCommand("INSERT INTO TOR([employee], [time_in], [date]) VALUES(@emp, @now, @date)", connection)

                    newCmd.Parameters.AddWithValue("@emp", username)
                    newCmd.Parameters.AddWithValue("@now", Date.Now().TimeOfDay)
                    newCmd.Parameters.AddWithValue("@date", CStr(Date.Now().Date))
                    connection.Open()
                    newCmd.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                Me.Hide()
                CashierForm.Show()
            ElseIf role = "admin" Then
                AdminForm.Text = username
                InputPass.Text = ""
                Me.Hide()
                AdminForm.Show()
            End If
        Else
            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
            InputPass.Text = ""
        End If


    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.RoleBox
            .DropDownStyle = ComboBoxStyle.DropDown
            .Text = "cashier"
        End With
    End Sub

    Private Sub InputPass_KeyDown(sender As Object, e As KeyEventArgs) Handles InputPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        System.Windows.Forms.Application.Exit()
    End Sub
End Class

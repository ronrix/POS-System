<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.InputPass = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.RoleBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputPass
        '
        Me.InputPass.BackColor = System.Drawing.Color.SkyBlue
        Me.InputPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputPass.ForeColor = System.Drawing.Color.Black
        Me.InputPass.Location = New System.Drawing.Point(655, 193)
        Me.InputPass.Multiline = True
        Me.InputPass.Name = "InputPass"
        Me.InputPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.InputPass.Size = New System.Drawing.Size(153, 27)
        Me.InputPass.TabIndex = 1
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Salmon
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loginBtn.Location = New System.Drawing.Point(655, 237)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(153, 36)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'RoleBox
        '
        Me.RoleBox.BackColor = System.Drawing.Color.SkyBlue
        Me.RoleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.RoleBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleBox.FormattingEnabled = True
        Me.RoleBox.Items.AddRange(New Object() {"admin", "cashier"})
        Me.RoleBox.Location = New System.Drawing.Point(655, 157)
        Me.RoleBox.Name = "RoleBox"
        Me.RoleBox.Size = New System.Drawing.Size(153, 47)
        Me.RoleBox.TabIndex = 3
        Me.RoleBox.Tag = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_System.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(873, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.logo_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(908, 386)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RoleBox)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.InputPass)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputPass As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents RoleBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

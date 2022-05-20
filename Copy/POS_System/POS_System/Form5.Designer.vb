<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.changeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(523, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cancel Pay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 302)
        Me.TextBox1.TabIndex = 1
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 33)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Cash"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(429, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "GCash"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(473, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Coupon Discount"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(348, 57)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 40)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(348, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 38)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "7"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(429, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 38)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "8"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(518, 101)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 38)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "9"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(518, 134)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 38)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "4"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(429, 134)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 38)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "5"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(348, 134)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 38)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "6"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(518, 169)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(88, 38)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "1"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(429, 169)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 38)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "2"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(348, 169)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(88, 38)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "3"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(429, 203)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(94, 38)
        Me.Button15.TabIndex = 15
        Me.Button15.Text = "C"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(348, 203)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(88, 38)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "0"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'changeLabel
        '
        Me.changeLabel.AutoSize = True
        Me.changeLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeLabel.Location = New System.Drawing.Point(556, 31)
        Me.changeLabel.Name = "changeLabel"
        Me.changeLabel.Size = New System.Drawing.Size(21, 23)
        Me.changeLabel.TabIndex = 16
        Me.changeLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(469, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CHANGE:"
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.OIP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.changeLabel)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents changeLabel As Label
    Friend WithEvents Label1 As Label
End Class

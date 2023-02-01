<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ListBoxDvd = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ListBoxDisplay = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelSubTotal = New System.Windows.Forms.Label()
        Me.LabelShippingCharge = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelTax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxDvd
        '
        Me.ListBoxDvd.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxDvd.FormattingEnabled = True
        Me.ListBoxDvd.ItemHeight = 15
        Me.ListBoxDvd.Location = New System.Drawing.Point(45, 41)
        Me.ListBoxDvd.Name = "ListBoxDvd"
        Me.ListBoxDvd.Size = New System.Drawing.Size(194, 274)
        Me.ListBoxDvd.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddButton.Location = New System.Drawing.Point(640, 100)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(118, 43)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "&Add To Cart"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RemoveButton.Location = New System.Drawing.Point(640, 149)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(118, 40)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "&Remove From Cart "
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClearButton.Location = New System.Drawing.Point(640, 195)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(118, 45)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ExitButton.Location = New System.Drawing.Point(640, 246)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(118, 40)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ListBoxDisplay
        '
        Me.ListBoxDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxDisplay.FormattingEnabled = True
        Me.ListBoxDisplay.ItemHeight = 15
        Me.ListBoxDisplay.Location = New System.Drawing.Point(288, 48)
        Me.ListBoxDisplay.Name = "ListBoxDisplay"
        Me.ListBoxDisplay.Size = New System.Drawing.Size(178, 259)
        Me.ListBoxDisplay.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "List of Dvd's"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(339, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cart"
        '
        'LabelSubTotal
        '
        Me.LabelSubTotal.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSubTotal.Location = New System.Drawing.Point(496, 217)
        Me.LabelSubTotal.Name = "LabelSubTotal"
        Me.LabelSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.LabelSubTotal.TabIndex = 8
        '
        'LabelShippingCharge
        '
        Me.LabelShippingCharge.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelShippingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelShippingCharge.Location = New System.Drawing.Point(496, 113)
        Me.LabelShippingCharge.Name = "LabelShippingCharge"
        Me.LabelShippingCharge.Size = New System.Drawing.Size(100, 23)
        Me.LabelShippingCharge.TabIndex = 9
        '
        'LabelTotal
        '
        Me.LabelTotal.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotal.Location = New System.Drawing.Point(496, 258)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(100, 23)
        Me.LabelTotal.TabIndex = 10
        '
        'LabelTax
        '
        Me.LabelTax.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTax.Location = New System.Drawing.Point(496, 161)
        Me.LabelTax.Name = "LabelTax"
        Me.LabelTax.Size = New System.Drawing.Size(100, 28)
        Me.LabelTax.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Shipping Charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sales Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(496, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(496, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 73)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "***Online Music and DvD Shopping Application***"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(836, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelTax)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelShippingCharge)
        Me.Controls.Add(Me.LabelSubTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxDisplay)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ListBoxDvd)
        Me.Name = "Form1"
        Me.Text = "Final Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxDvd As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ListBoxDisplay As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelSubTotal As Label
    Friend WithEvents LabelShippingCharge As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelTax As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

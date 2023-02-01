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
        Me.Calculate = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Sales = New System.Windows.Forms.Label()
        Me.UserText = New System.Windows.Forms.TextBox()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.TextBoxCommission = New System.Windows.Forms.Label()
        Me.Addition = New System.Windows.Forms.Label()
        Me.AdditionalBox = New System.Windows.Forms.Label()
        Me.LoyalEmployee = New System.Windows.Forms.CheckBox()
        Me.Travel = New System.Windows.Forms.CheckBox()
        Me.LabelDue = New System.Windows.Forms.Label()
        Me.FinalAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(583, 52)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(106, 23)
        Me.Calculate.TabIndex = 0
        Me.Calculate.Text = "&Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(583, 126)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(106, 20)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.Sales.AutoSize = True
        Me.Sales.Location = New System.Drawing.Point(55, 28)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(36, 15)
        Me.Sales.TabIndex = 2
        Me.Sales.Text = "Sales:"
        '
        'UserText
        '
        Me.UserText.Location = New System.Drawing.Point(55, 53)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(100, 23)
        Me.UserText.TabIndex = 3
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(52, 103)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(103, 15)
        Me.CommissionLabel.TabIndex = 4
        Me.CommissionLabel.Text = "Commission only:"
        '
        'TextBoxCommission
        '
        Me.TextBoxCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCommission.Location = New System.Drawing.Point(55, 126)
        Me.TextBoxCommission.Name = "TextBoxCommission"
        Me.TextBoxCommission.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCommission.TabIndex = 5
        '
        'Addition
        '
        Me.Addition.AutoSize = True
        Me.Addition.Location = New System.Drawing.Point(55, 179)
        Me.Addition.Name = "Addition"
        Me.Addition.Size = New System.Drawing.Size(110, 15)
        Me.Addition.TabIndex = 6
        Me.Addition.Text = "Additional amount:"
        '
        'AdditionalBox
        '
        Me.AdditionalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdditionalBox.Location = New System.Drawing.Point(55, 211)
        Me.AdditionalBox.Name = "AdditionalBox"
        Me.AdditionalBox.Size = New System.Drawing.Size(100, 23)
        Me.AdditionalBox.TabIndex = 7
        '
        'LoyalEmployee
        '
        Me.LoyalEmployee.AutoSize = True
        Me.LoyalEmployee.Location = New System.Drawing.Point(223, 23)
        Me.LoyalEmployee.Name = "LoyalEmployee"
        Me.LoyalEmployee.Size = New System.Drawing.Size(96, 19)
        Me.LoyalEmployee.TabIndex = 8
        Me.LoyalEmployee.Text = "&Over 10 years"
        Me.LoyalEmployee.UseVisualStyleBackColor = True
        '
        'Travel
        '
        Me.Travel.AutoSize = True
        Me.Travel.Location = New System.Drawing.Point(223, 52)
        Me.Travel.Name = "Travel"
        Me.Travel.Size = New System.Drawing.Size(73, 19)
        Me.Travel.TabIndex = 9
        Me.Travel.Text = "&Traveling"
        Me.Travel.UseVisualStyleBackColor = True
        '
        'LabelDue
        '
        Me.LabelDue.AutoSize = True
        Me.LabelDue.Location = New System.Drawing.Point(224, 156)
        Me.LabelDue.Name = "LabelDue"
        Me.LabelDue.Size = New System.Drawing.Size(123, 15)
        Me.LabelDue.TabIndex = 10
        Me.LabelDue.Text = "Total due SalesPerson:"
        '
        'FinalAmount
        '
        Me.FinalAmount.BackColor = System.Drawing.SystemColors.Info
        Me.FinalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FinalAmount.Location = New System.Drawing.Point(223, 179)
        Me.FinalAmount.Name = "FinalAmount"
        Me.FinalAmount.Size = New System.Drawing.Size(124, 55)
        Me.FinalAmount.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FinalAmount)
        Me.Controls.Add(Me.LabelDue)
        Me.Controls.Add(Me.Travel)
        Me.Controls.Add(Me.LoyalEmployee)
        Me.Controls.Add(Me.AdditionalBox)
        Me.Controls.Add(Me.Addition)
        Me.Controls.Add(Me.TextBoxCommission)
        Me.Controls.Add(Me.CommissionLabel)
        Me.Controls.Add(Me.UserText)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Calculate)
        Me.Name = "Form1"
        Me.Text = "Canton Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calculate As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Sales As Label
    Friend WithEvents UserText As TextBox
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents TextBoxCommission As Label
    Friend WithEvents Addition As Label
    Friend WithEvents AdditionalBox As Label
    Friend WithEvents LoyalEmployee As CheckBox
    Friend WithEvents Travel As CheckBox
    Friend WithEvents LabelDue As Label
    Friend WithEvents FinalAmount As Label
End Class

Option Explicit On
Option Strict Off
Option Infer Off
Imports System.Threading

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Const SalesPercentage As Double = 0.1
        Const SalesPercentage13 As Double = 0.13
        Const SalesPercentage14 As Double = 0.14

        Const Additionalone As Double = 500
        Const Additionaltwo As Double = 700
        Const Additionalthree As Double = 0

        Dim UserInput As Decimal
        Dim TotalAdditions As Decimal
        Dim CommissionOnly As Decimal

        Decimal.TryParse(UserText.Text, UserInput)


        If UserInput >= 6000 Then
            If UserInput <= 29999.99 Then
                CommissionOnly = UserInput * SalesPercentage13 + 600
                TextBoxCommission.Text = CommissionOnly.ToString("C2")
            ElseIf UserInput >= 30000 Then
                CommissionOnly = UserInput * SalesPercentage14 + 3720
                TextBoxCommission.Text = CommissionOnly.ToString("C2")
            End If
        ElseIf UserInput <= 6000 Then
            CommissionOnly = UserInput * SalesPercentage
            TextBoxCommission.Text = CommissionOnly.ToString("C2")

        End If




        If UserInput >= 10000 Then
            If Travel.Checked = True Then
                TotalAdditions = Additionaltwo
                AdditionalBox.Text = TotalAdditions.ToString("C2")
            Else


                If LoyalEmployee.Checked = True Then
                    TotalAdditions = Additionalone
                    AdditionalBox.Text = TotalAdditions.ToString("C2")
                Else
                    TotalAdditions = Additionalthree
                    AdditionalBox.Text = TotalAdditions.ToString("C2")
                End If
            End If

        Else
            TotalAdditions = Additionalthree
            AdditionalBox.Text = TotalAdditions.ToString("C2")
        End If
        Dim Final As Decimal = TotalAdditions + CommissionOnly
        FinalAmount.Text = Final.ToString("C2")
    End Sub




    Private Sub TextBoxCommission_Click(sender As Object, e As EventArgs) Handles TextBoxCommission.Click

    End Sub

    Private Sub UserText_TextChanged(sender As Object, e As EventArgs) Handles UserText.TextChanged


    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Addition.Click

    End Sub

    Private Sub AdditionalBox_Click(sender As Object, e As EventArgs) Handles AdditionalBox.Click

    End Sub

    Private Sub LoyalEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles LoyalEmployee.CheckedChanged

    End Sub

    Private Sub FinalAmount_Click(sender As Object, e As EventArgs) Handles FinalAmount.Click

    End Sub
    Private Sub UserText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserText.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If
        If e.KeyChar = "." Then
            e.Handled = False
        End If
    End Sub


End Class

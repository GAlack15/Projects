Option Explicit On
Option Strict Off
Option Infer Off
Imports System.Net.Security
Imports System.Reflection.Metadata

Public Class Form1


    Public Const mathPrices As Double = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBoxDisplay.Items.Clear()
        Dim zero As Double = 0
        LabelSubTotal.Text = zero.ToString("c2")
        LabelTax.Text = 0
        LabelShippingCharge.Text = zero.ToString("c2")
        LabelTotal.Text = zero.ToString("c2")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBoxDvd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDvd.SelectedIndexChanged

    End Sub

    Private Sub ListBoxDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDisplay.SelectedIndexChanged

    End Sub

    Public Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim myIndex As Integer = ListBoxDvd.SelectedIndex
        Dim mathPrices As Double = 0
        Static i As Integer
        Static sales As Double = 0.4
        Double.TryParse(LabelSubTotal.Text, mathPrices)

        Dim prices(10) As String
        prices(0) = 2
        prices(1) = 2
        prices(2) = 2
        prices(3) = 3
        prices(4) = 3
        prices(5) = 3
        prices(6) = 4
        prices(7) = 4
        prices(8) = 7
        prices(9) = 7
        Static myCharge As Double = 0
        Dim number1 = 1
        If myCharge < 5 Then


            myCharge = myCharge + number1
        End If

        LabelShippingCharge.Text = myCharge.ToString("n2")



        'Double.TryParse(LabelSubTotal.Text, mathPrices)

        Dim mystring As String = ListBoxDvd.SelectedItems(i) + prices(myIndex)
        ListBoxDisplay.Items.Add(mystring)
        'ListBoxDisplay.Items.Add(prices(myIndex))
        mathPrices = mathPrices + prices(myIndex)
        LabelSubTotal.Text = mathPrices.ToString("N2")

        Dim HelloThere As Double = sales * mathPrices
        LabelTax.Text = HelloThere.ToString("N2")

        Dim theFinalTotal As Double = HelloThere + mathPrices + myCharge
        LabelTotal.Text = theFinalTotal.ToString("N2")



    End Sub

    Public Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If ListBoxDisplay.Items.Count > 0 Then



            Dim myIndex As Integer = ListBoxDvd.SelectedIndex
            'Dim y = Integer.TryParse(myIndex, y)
            Static mathPrices As Double
            Double.TryParse(LabelSubTotal.Text, mathPrices)
            Dim x As Integer
            Static Sales As Double = 0.4
            Dim myCharge As Double = 0
            Dim prices(10) As Double
            prices(0) = -2
            prices(1) = -2
            prices(2) = -2
            prices(3) = -3
            prices(4) = -3
            prices(5) = -3
            prices(6) = -4
            prices(7) = -4
            prices(8) = -7
            prices(9) = -7

            Static count As Integer = 0
            Dim value As String = ""


            value = ListBoxDisplay.Items(count).ToString
            ListBoxDisplay.SelectedIndex = count



            'value = ListBoxDisplay.Items(count).ToString


            'MsgBox(value)
            If value = "Gandalfs jazz 2" Then
                mathPrices = mathPrices + prices(0)
                LabelSubTotal.Text = mathPrices.ToString("N2")
            ElseIf value = "Darth vader's country music 2" Then
                mathPrices = mathPrices + prices(0)
            ElseIf value = "Lord of the Rings 2" Then
                mathPrices = mathPrices + prices(0)
            ElseIf value = "Star Wars 3" Then
                mathPrices = mathPrices + prices(3)
            ElseIf value = "Country music 3" Then
                mathPrices = mathPrices + prices(3)
            ElseIf value = "Elvis music 3" Then
                mathPrices = mathPrices + prices(3)
            ElseIf value = "Treasure Island movie 4" Then
                mathPrices = mathPrices + prices(7)
            ElseIf value = "Blu-Ray Dvd 4" Then
                mathPrices = mathPrices + prices(7)
            ElseIf value = "Regular Dvd 7" Then
                mathPrices = mathPrices + prices(9)
            ElseIf value = "Extended Edition 7" Then
                mathPrices = mathPrices + prices(9)

            End If

            Double.TryParse(LabelShippingCharge.Text, myCharge)
            If myCharge > 0 Then
                myCharge = myCharge - 1
            End If
            LabelShippingCharge.Text = myCharge.ToString("N2")


            'mathPrices = mathPrices + prices(myIndex)
            Dim mymath1 As Double = 0



            If mathPrices > 0 Or mathPrices > -1 Then
                ListBoxDisplay.Items.RemoveAt(ListBoxDisplay.SelectedIndex)
                LabelSubTotal.Text = mathPrices.ToString("N2")

            End If

            If mathPrices < 0 Then
                mathPrices = 0
                mymath1 = 0
                myCharge = 0
            End If


            mymath1 = Sales * mathPrices
            LabelTax.Text = mymath1.ToString("N2")

            Dim theFinalTotal As Double = 0

            theFinalTotal = mymath1 + mathPrices + myCharge
            LabelTotal.Text = theFinalTotal.ToString("N2")


        Else
            MsgBox(" nothing in the shopping cart was selected")
        End If
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim loadMyArrayNow(10) As String

        loadMyArrayNow(0) = "Gandalfs jazz                  "
        loadMyArrayNow(1) = "Darth vader's country music "
        loadMyArrayNow(2) = "Lord of the Rings              "
        loadMyArrayNow(3) = "Star Wars                      "
        loadMyArrayNow(4) = "Country music                  "
        loadMyArrayNow(5) = "Elvis music                    "
        loadMyArrayNow(6) = "Treasure Island movie          "
        loadMyArrayNow(7) = "Blu-Ray Dvd                    "
        loadMyArrayNow(8) = "Regular Dvd                    "
        loadMyArrayNow(9) = "Extended Edition               "


        ListBoxDvd.Items.Insert(0, "Gandalfs jazz ")
        ListBoxDvd.Items.Insert(1, "Darth vader's country music ")
        ListBoxDvd.Items.Insert(2, "Lord of the Rings ")
        ListBoxDvd.Items.Insert(3, "Star Wars ")
        ListBoxDvd.Items.Insert(4, "Country music ")
        ListBoxDvd.Items.Insert(5, "Elvis music ")
        ListBoxDvd.Items.Insert(6, "Treasure Island movie ")
        ListBoxDvd.Items.Insert(7, "Blu-Ray Dvd ")
        ListBoxDvd.Items.Insert(8, "Regular Dvd ")
        ListBoxDvd.Items.Insert(9, "Extended Edition ")

    End Sub
End Class

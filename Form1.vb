Public Class Form1

    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblMonthSavings.Text = ""
        lblAveSavings.Text = ""
        lblMostSavings.Text = ""

        If IO.File.Exists("C:\Users\Ian\Desktop\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\Ian\Desktop\savings.txt")

            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (_strSavings.Length - 1)
                cmbOptions.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub

    Private Sub cmbOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOptions.SelectedIndexChanged
        Dim intSelectedCityIndex As Integer

        intSelectedCityIndex = cmbOptions.SelectedIndex
        lblMonthSavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnDisplayStats.Visible = True
    End Sub

    Private Sub btnDisplayStats_Click(sender As Object, e As EventArgs) Handles btnDisplayStats.Click
        ComputeAverage()
        ComputeMaxSavings()
        lblAveSavings.Visible = True
        lblMonthSavings.Visible = True
        lblMostSavings.Visible = True
    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMostSavings.Text = strYearValue & " had the most significant monthly savings"
    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAveSavings.Text = "The Avertage monthly savings: " & decAverageNumberOfBill.ToString("C2")

    End Sub

    Private Sub lblAveSavings_Click(sender As Object, e As EventArgs) Handles lblAveSavings.Click

    End Sub

    Private Sub lblMostSavings_Click(sender As Object, e As EventArgs) Handles lblMostSavings.Click

    End Sub

    Private Sub lblMonthSavings_Click(sender As Object, e As EventArgs) Handles lblMonthSavings.Click

    End Sub
End Class

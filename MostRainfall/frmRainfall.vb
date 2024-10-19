' Progarm Name: Most Rainfall in US
' Date: October 19, 2024
' Author: K Bola
' Purpose: This application is written for Kauai, Hawaii, the rainiest location in the united states to compute the average monthly amount of rainfall per year 
Public Class frmRainfall
    Private Sub frmRainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRainfall.Items.Clear()
    End Sub
    Private Sub btnEnterRainfall_Click(sender As Object, e As EventArgs) Handles btnEnterRainfall.Click
        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0
        Dim strInputMessage As String = "Enter the amount of rainfall for month "
        Dim strInputHeading As String = "Amount of Rainfall in a Year"
        Dim strNormalMessage As String = "Enter the amount of rainfall for month "
        Dim strNonNumericValue As String = "Enter a number"
        Dim strNegativeValue As String = "Enter a positive number"
        Dim strCancelClicked As String = ""
        Dim intNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 12
        strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = strCancelClicked
            If (IsNumeric(strRainfall)) Then
                decRainfall = Convert.ToDecimal(strRainfall)
                If decRainfall > 0 Then
                    lstRainfall.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeValue
                End If
                If intNumberOfEntries <= intMaxNumberOfEntries Then
                    strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
                End If
            Else
                strInputMessage = strNonNumericValue
            End If
        Loop
        If intNumberOfEntries > 1 Then
            decAverageRainfall = decTotalRainfall / 12
            lblAverageRainfall.Visible = True
            lblAverageRainfall.Text = "Average rainfall per month is " & decAverageRainfall.ToString("N1") & " inches"
        Else
            MsgBox("No Value Entered", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Empty")
        End If
    End Sub
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstRainfall.Items.Clear()
        lblAverageRainfall.Text = ""
        btnEnterRainfall.Enabled = True
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class

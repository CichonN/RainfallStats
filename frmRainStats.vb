'**************************************************
' Neina Cichon
' 2020-06-21
' Rainfall Statistics
'**************************************************


Public Class frmRainStats

    Dim dblRainfall(11) As Double
    Dim strMonth As String
    Dim intMaximumRain As Integer
    Dim intMinimumRain As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the form
        lblAverageRainfall.ResetText()
        lblMaximumRainfall.ResetText()
        lblMinimumRainfall.ResetText()
        lblTotalRainfall.ResetText()
        lstResult.Items.Clear()

    End Sub

    Public Function Validation(ByVal Rainfall As String, ByRef RainfallNumeric As Double) As Boolean

        If IsNumeric(Rainfall) Then
            If Rainfall >= 0 Then
                RainfallNumeric = CDbl(Rainfall)
                Return True
            Else
                MessageBox.Show("Please enter positive number only.")
            End If
        Else
            MessageBox.Show("Please enter numbers only")
            Return False

        End If

    End Function

    Private Function GetMonth(ByVal Month As Integer) As String
        Select Case Month
            Case 0
                strMonth = "January"
            Case 1
                strMonth = "February"
            Case 2
                strMonth = "March"
            Case 3
                strMonth = "April"
            Case 4
                strMonth = "May"
            Case 5
                strMonth = "June"
            Case 6
                strMonth = "July"
            Case 7
                strMonth = "August"
            Case 8
                strMonth = "September"
            Case 9
                strMonth = "October"
            Case 10
                strMonth = "November"
            Case 11
                strMonth = "December"
        End Select

        Return strMonth
    End Function

    Private Function GetTotal() As Double
        Dim dblTotal As Double

        For i = 0 To dblRainfall.Length - 1
            dblTotal += dblRainfall(i)
        Next


        Return dblTotal
    End Function


    Private Function GetMaximum() As Double
        Dim dblMaximum As Double

        For i = 0 To dblRainfall.Length - 1
            If dblRainfall(i) > dblMaximum Then
                dblMaximum = dblRainfall(i)
                intMaximumRain = i
            End If
        Next

        Return dblMaximum


    End Function

    Private Function GetMinimum() As Double
        Dim dblMinimum As Double = 100

        For i = 0 To dblRainfall.Length - 1
            If dblRainfall(i) < dblMinimum Then
                dblMinimum = dblRainfall(i)
                intMinimumRain = i
            End If
        Next

        Return dblMinimum

        Return dblMinimum


    End Function

    Private Function GetAverage() As Double
        Dim dblAverageTotal As Double
        Dim dblAverage As Double

        For i = 0 To dblRainfall.Length - 1
            dblAverage += dblRainfall(i)

        Next

        dblAverageTotal = dblAverage / dblRainfall.Length

        Return dblAverageTotal

    End Function


    Private Sub btnInputRainfall_Click(sender As Object, e As EventArgs) Handles btnInputRainfall.Click

        Dim strAmount As String
        Dim strInputMonth As String


        Try
            For i = 0 To dblRainfall.Length - 1
                strInputMonth = GetMonth(i)
                strAmount = InputBox("Please enter rainfall for " & strInputMonth)

                If Validation(strAmount, dblRainfall(i)) = True Then

                    lstResult.Items.Add("Rainfall for " & strInputMonth & " is " & dblRainfall(i))
                Else
                    i -= 1
                End If

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDisplayStats_Click(sender As Object, e As EventArgs) Handles btnDisplayStats.Click

        Dim dblTotalDisplay As Double
        Dim dblMaximumDisplay As Double
        Dim strMonthDisplay As String
        Dim dblMinimumDisplay As Double
        Dim dblAverageDisplay As Double

        dblTotalDisplay = GetTotal()

        dblMaximumDisplay = GetMaximum()

        strMonthDisplay = GetMonth(intMaximumRain)

        lblTotalRainfall.Text = "The total rainfall was " & dblTotalDisplay

        lblMaximumRainfall.Text = "The maximum rainfall was " & dblMaximumDisplay & " in " & strMonthDisplay

        dblMinimumDisplay = GetMinimum()

        strMonthDisplay = GetMonth(intMinimumRain)

        lblMinimumRainfall.Text = "The minimum rainfall was " & dblMinimumDisplay & " in " & strMonthDisplay

        dblAverageDisplay = GetAverage()

        lblAverageRainfall.Text = "The average rainfall was " & dblAverageDisplay.ToString("G3")

    End Sub

End Class

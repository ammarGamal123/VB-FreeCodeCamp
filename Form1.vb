Public Class Form1

    Private Sub btnCountEvenOdd_Click(sender As Object, e As EventArgs) Handles btnCountEvenOdd.Click

        Dim iLimit, iCount As Integer
        Dim stChoice As String


        iLimit = InputBox("what is your number")
        stChoice = InputBox("Even Or Odd")


        Select Case stChoice
            Case Is = "Even"
                For iCount = 0 To iLimit Step 2
                    MsgBox(iCount)
                Next

            Case Else
                For iCount = 1 To iLimit Step 2
                    MsgBox(iCount)
                Next
        End Select








    End Sub



End Class

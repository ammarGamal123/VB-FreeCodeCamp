Public Class Form1


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim iTemperature As Integer

        If Not IsNumeric(txtTemperature.Text) = True Then
            MsgBox("You should Enter a Temperature Number")
            Exit Sub
        End If

        iTemperature = CInt(txtTemperature.Text)


        ' You can only test 1 variable not more 
        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 0
                MsgBox("Sub Zero")
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select




    End Sub



End Class

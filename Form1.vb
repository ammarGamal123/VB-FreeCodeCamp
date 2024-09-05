Public Class Form1



    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer


        If IsNumeric(txtExamScore) = True Then
            ' Using CInt is more efficient
            iScore = CInt(txtExamScore.Text)
        Else
            MsgBox("your input must be a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("Not a valid grade , it should be between 0 and 100")
        ElseIf iScore >= 50 Then
            MsgBox("Passed")
        ElseIf iScore < 50 Then
            MsgBox("Fail")
        End If

        MsgBox("all done")

    End Sub



End Class
